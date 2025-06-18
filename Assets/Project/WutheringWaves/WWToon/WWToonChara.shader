Shader "Custom/WWToonChara"
{
    Properties
    {
        
        _IN0("IN0", 2D) = "white" {}
        _IN1("IN1", 2D) = "white" {}
        _IN2("IN2", 2D) = "white" {}
        _IN3("IN3", 2D) = "white" {}
        _IN4("InTex4", 2D) = "white" {}
        _IN5("IN5", 2D) = "white" {}
        _IN6("IN6", 2D) = "white" {}
        _IN7("IN7", 2D) = "white" {}
        _IN8("IN8", 2D) = "white" {}
        _IN9("IN9", 2D) = "white" {}
    }

    SubShader
    {
        Pass
        {
            HLSLPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 5.0
            //#pragma enable_d3d11_debug_symbols
            
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

struct Attributes
{
    float4 positionOS   : POSITION;     // OS = Object Space
    float2 uv           : TEXCOORD0;
};

struct Varyings
{
    float4 positionCS   : SV_POSITION;  // CS = Clip Space
    float4 uv           : TEXCOORD0;    // 使用float4来存储 uv.xy 和 ndc.xy
};
            
            sampler2D _IN0;
            sampler2D _IN1;
            sampler2D _IN2;
            sampler2D _IN3;
            sampler2D _IN4;
            sampler2D _IN5;
            sampler2D _IN6;
            sampler2D _IN7;
            sampler2D _IN8;
            sampler2D _IN9;

            float4 _IN0_ST;
            float4 _IN1_ST;
            float4 _IN2_ST;
            float4 _IN3_ST;
            float4 _IN4_ST;
            float4 _IN5_ST;
            float4 _IN6_ST;
            float4 _IN7_ST;
            float4 _IN8_ST;
            float4 _IN9_ST;
            float4 _FrameJitterSeed;     // cb1[158]
            
            //float4 _ScaledScreenParams;     // cb1[138] zw不等价需要-1
            //float4 _MainLightPosition;     // cb1[138] zw不等价需要-1

            Varyings vert (Attributes IN)
            {
                Varyings OUT;

                // 1. 使用 URP 的标准函数进行变换
                OUT.positionCS = TransformObjectToHClip(IN.positionOS.xyz);
                
                // 2. 传递 UV 坐标
                OUT.uv.xy = IN.uv;

                // 3. 计算 NDC 并传递
                // 逻辑完全相同：用裁剪空间坐标的 xy 除以 w
                float2 ndc = OUT.positionCS.xy / OUT.positionCS.w;
                OUT.uv.zw = ndc;
                
                return OUT;
            }
            
            StructuredBuffer<float4> cb0;
            StructuredBuffer<float4> cb1;
            StructuredBuffer<float4> cb2;
            
            // 已知 _IN0 是深度+Stencil 
            // 已知 _IN1 XY八面体压缩法线 B是diffuseFactor A是FaceSDFMask
            // 已知 _IN2 XYZ是ShadowColor W是00001111=ShadeMode 11110000=OutputMask 
            // 已知 _IN3 是Albedo和ToonSkinMask
            // 未知 _IN4
            // 已知 _IN5 R是阴影 G未使用 B是阴影强度 A通道为什么和B一样
            // 已知 _IN6 R16深度
            // 已知 _IN7 1x1像素 全0
            // 已知 _IN8 MSSAO 多分辨率屏幕空间AO
            // 已知 _IN9 1x1像素 EyeAdaptation自动曝光
          
float4 frag (Varyings fragmentInput) : SV_Target
{
    // 基于输入uv定义v0，zw分量是NDC x（clip.x / clip.w）并复制到 zw
    float4 v0 = fragmentInput.uv; 
if(tex2Dlod(_IN4, float4(v0.xy, 0, 0)).a){discard;} // debug 模拟延迟渲染stencil

    float4 color = 0;
    
    float4 r0=0, r1=0, r2=0, InTex4=0, r4=0, r5=0, r6=0, r7=0, r8=0, r9=0, r10=0, r11=0, r12=0, r13=0, r14=0, r15=0, r16=0;
    uint4 bitmask=0, uiDest=0;
    float4 fDest=0;
    
float4 depthStencil=0;                // _IN0：深度 + Stencil
float4 SDFMask_octNormal_Diffuse=0;  // _IN1：XY八面体压缩法线, B=diffuseFactor, A=FaceSDFMask
float4 shadowColor_ShadeModeOutputMask=0;  // _IN2：XYZ=ShadowColor, W=ShadeMode|OutputMask
float4 albedo_ToonSkinMask=0;        // _IN3：Albedo 和 ToonSkinMask
float4 unknownInput=0;               // _IN4：未知用途
float2 shadowShadowStrength=0;       // _IN5：R=阴影, G=未使用, B=阴影强度, A=冗余B?
float linearDepth=0;                // _IN6：R16深度
float4 blackPixel=0;                 // _IN7：1x1黑色像素，全0
float ssao=0;                       // _IN8：屏幕空间AO（多分辨率）
float4 eyeAdaptation=0;             // _IN9：自动曝光（Eye Adaptation）
float2 octNormal = 0;
float diffuse = 0;
float SDFMask = 0;
float3 otherNormal = 0;
float EyeAdaptation = 0;
float shadow=0;             
float ShadowStrength=0;             

    SDFMask_octNormal_Diffuse.xyzw = tex2Dlod(_IN1, float4(v0.xy, 0, 0)).wxyz;
        SDFMask = SDFMask_octNormal_Diffuse.x;
        octNormal = SDFMask_octNormal_Diffuse.yz;
        diffuse = SDFMask_octNormal_Diffuse.w;
        otherNormal = SDFMask_octNormal_Diffuse.yzw; // 角色以外不是2维法线
    shadowColor_ShadeModeOutputMask.xyzw = tex2Dlod(_IN2, float4(v0.xy, 0, 0)).xyzw;
    albedo_ToonSkinMask.xyz = tex2Dlod(_IN3, float4(v0.xy, 0, 0)).xyz;
    InTex4.xyz = tex2Dlod(_IN4, float4(v0.xy, 0, 0)).yxz;
    albedo_ToonSkinMask.w = tex2Dlod(_IN0, float4(v0.xy, 0, 0)).x;
    InTex4.w = albedo_ToonSkinMask.w * cb1[65].x + cb1[65].y;
    albedo_ToonSkinMask.w = albedo_ToonSkinMask.w * cb1[65].z + -cb1[65].w;
    albedo_ToonSkinMask.w = 1 / albedo_ToonSkinMask.w;
    albedo_ToonSkinMask.w = InTex4.w + albedo_ToonSkinMask.w;
    r4.xy = cb1[138].xy * v0.xy;
    r4.xy = (uint2)r4.xy;
    InTex4.w = (uint)cb1[158].x;
    r4.x = (int)r4.y + (int)r4.x;
    InTex4.w = (int)InTex4.w + (int)r4.x;
    InTex4.w = (int)InTex4.w & 1;
    shadowColor_ShadeModeOutputMask.w = 255 * shadowColor_ShadeModeOutputMask.w;
    shadowColor_ShadeModeOutputMask.w = round(shadowColor_ShadeModeOutputMask.w);
    shadowColor_ShadeModeOutputMask.w = (uint)shadowColor_ShadeModeOutputMask.w;
    r4.xy = (int2)shadowColor_ShadeModeOutputMask.ww & int2(15,-16);
    shadowColor_ShadeModeOutputMask.w = ((int)r4.x != 12) ? 1.0 : 0.0;
    r5.xyz = ((int3)r4.xxx == int3(13,14,15)) ? 1.0 : 0.0;
    r4.z = (int)r5.z | (int)r5.y;
    r4.z = (int)r4.z | (int)r5.x;
    shadowColor_ShadeModeOutputMask.w = shadowColor_ShadeModeOutputMask.w ? r4.z : -1;
    if (shadowColor_ShadeModeOutputMask.w != 0) {
        r4.x = r5.x ? 13 : 12;
        r5.xz = r5.yz ? float2(1,1) : 0;
        r4.zw = octNormal * float2(2,2) + float2(-1,-1);
        shadowColor_ShadeModeOutputMask.w = dot(float2(1,1), abs(r4.zw));
        r6.z = 1 + -shadowColor_ShadeModeOutputMask.w;
        shadowColor_ShadeModeOutputMask.w = max(0, -r6.z);
        r7.xy = (r4.zw >= float2(0,0)) ? 1.0 : 0.0;
        r7.xy = r7.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
        r7.xy = r7.xy * shadowColor_ShadeModeOutputMask.ww;
        r6.xy = r7.xy * float2(-2,-2) + r4.zw;
        shadowColor_ShadeModeOutputMask.w = dot(r6.xyz, r6.xyz);
        shadowColor_ShadeModeOutputMask.w = rsqrt(shadowColor_ShadeModeOutputMask.w);
        r6.xyz = r6.xyz * shadowColor_ShadeModeOutputMask.www;
        r7.xyz = shadowColor_ShadeModeOutputMask.xyz * shadowColor_ShadeModeOutputMask.xyz;
        r5.y = InTex4.z;
    } else {
        shadowColor_ShadeModeOutputMask.w = ((int)r4.x == 10) ? 1.0 : 0.0;
        shadowColor_ShadeModeOutputMask.xyz = saturate(shadowColor_ShadeModeOutputMask.xyz);
        shadowColor_ShadeModeOutputMask.xyz = float3(16777215,65535,255) * shadowColor_ShadeModeOutputMask.xyz;
        shadowColor_ShadeModeOutputMask.xyz = round(shadowColor_ShadeModeOutputMask.xyz);
        shadowColor_ShadeModeOutputMask.xyz = (uint3)shadowColor_ShadeModeOutputMask.xyz;
        bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  shadowColor_ShadeModeOutputMask.y = (((uint)shadowColor_ShadeModeOutputMask.z << 0) & bitmask.y) | ((uint)shadowColor_ShadeModeOutputMask.y & ~bitmask.y);
        bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  shadowColor_ShadeModeOutputMask.x = (((uint)shadowColor_ShadeModeOutputMask.y << 0) & bitmask.x) | ((uint)shadowColor_ShadeModeOutputMask.x & ~bitmask.x);
        shadowColor_ShadeModeOutputMask.x = (uint)shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = 5.96046519e-008 * shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.y = shadowColor_ShadeModeOutputMask.x * cb1[65].x + cb1[65].y;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.x * cb1[65].z + -cb1[65].w;
        shadowColor_ShadeModeOutputMask.x = 1 / shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.y + shadowColor_ShadeModeOutputMask.x;
        albedo_ToonSkinMask.w = shadowColor_ShadeModeOutputMask.w ? shadowColor_ShadeModeOutputMask.x : albedo_ToonSkinMask.w;
        r6.xyz = SDFMask_octNormal_Diffuse.yzw * float3(2,2,2) + float3(-1,-1,-1);
        r7.xyz = float3(0,0,0);
        r5.xyz = float3(0,0,0);
        SDFMask_octNormal_Diffuse.xw = float2(0,0);
        InTex4.xy = float2(0,0);
    }
    SDFMask_octNormal_Diffuse.y = dot(r6.xyz, r6.xyz);
    SDFMask_octNormal_Diffuse.y = rsqrt(SDFMask_octNormal_Diffuse.y);
    shadowColor_ShadeModeOutputMask.xyz = r6.xyz * SDFMask_octNormal_Diffuse.yyy;
    SDFMask_octNormal_Diffuse.yz = ((int2)r4.xx == int2(5,13)) ? 1.0 : 0.0;
    shadowColor_ShadeModeOutputMask.w = (0 < cb1[162].y) ? 1.0 : 0.0;
    r4.z = (0 < cb1[220].z) ? 1.0 : 0.0;
    shadowColor_ShadeModeOutputMask.w = shadowColor_ShadeModeOutputMask.w ? r4.z : 0;
    r4.z = (0 != cb1[162].y) ? 1.0 : 0.0;
    r6.xyz = r4.zzz ? float3(1,1,1) : albedo_ToonSkinMask.xyz;
    InTex4.w = InTex4.w ? 1 : 0;
    r6.xyz = shadowColor_ShadeModeOutputMask.www ? InTex4.www : r6.xyz;
    albedo_ToonSkinMask.xyz = SDFMask_octNormal_Diffuse.yyy ? r6.xyz : albedo_ToonSkinMask.xyz;
    EyeAdaptation = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
    r4.zw = v0.zw * albedo_ToonSkinMask.ww;
    r6.xyz = cb1[49].xyz * r4.www;
    r6.xyz = r4.zzz * cb1[48].xyz + r6.xyz;
    r6.xyz = albedo_ToonSkinMask.www * cb1[50].xyz + r6.xyz;
    r6.xyz = cb1[51].xyz + r6.xyz;
    shadowShadowStrength = tex2Dlod(_IN5, float4(v0.xy, 0, 0)).xz;
    r4.zw = shadowShadowStrength * shadowShadowStrength;
    shadow = r4.z * r4.w;
    InTex4.w = cb1[253].y * shadow;
    if (cb1[255].x != 0) {
        r8.xyz = float3(0,0,0);
        float2 unkonw01 = float2(0,0);
        r5.w = 0;
        r6.w = 0;
        while (true) {
        r7.w = ((int)unkonw01.x >= 3) ? 1.0 : 0.0;
        if (r7.w != 0) break;
        unkonw01.y = 0.000833333295 + unkonw01.y;
        r9.xyz = r8.xyz;
        r7.w = r5.w;
        r8.w = r6.w;
        r9.w = 0;
        while (true) {
            r10.x = ((int)r9.w >= 3) ? 1.0 : 0.0;
            if (r10.x != 0) break;
            r7.w = 1 + r7.w;
            r10.x = 2.09439516 * r7.w;
            sincos(r10.x, r10.x, r11.x);
            r11.x = r11.x * unkonw01.y + v0.x;
            r11.y = r10.x * unkonw01.y + v0.y;
            r10.xyz = tex2D(_IN7, r11.xy).xyz;
            r9.xyz = r10.xyz * unkonw01.y + r9.xyz;
            r8.w = r8.w + unkonw01.y;
            r9.w = (int)r9.w + 1;
        }
        r8.xyz = r9.xyz;
        r6.w = r8.w;
        r5.w = 0.620000005 + r7.w;
        unkonw01.x = (int)unkonw01.x + 1;
        }
        r8.xyz = r8.xyz / r6.www;
        r9.xyz = (float3(0.644999981,0.312000006,0.978999972) < SDFMask_octNormal_Diffuse.xxx) ? 1.0 : 0.0;
        r10.xyz = (SDFMask_octNormal_Diffuse.xxx < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
        r9.xyz = r9.xyz ? r10.xyz : 0;
        SDFMask_octNormal_Diffuse.x = r9.z ? 1.000000 : 0;
        SDFMask_octNormal_Diffuse.x = r9.y ? 0 : SDFMask_octNormal_Diffuse.x;
        SDFMask_octNormal_Diffuse.x = r9.x ? 1 : SDFMask_octNormal_Diffuse.x;
        r4.z = (int)r9.y | (int)r9.z;
        r4.z = (int)r4.z & 0x3f800000;
        r4.z = r9.x ? 0 : r4.z;
        InTex4.x = 255 * InTex4.x;
        InTex4.x = round(InTex4.x);
        InTex4.x = (uint)InTex4.x;
        r9.xyzw = (int4)InTex4.xxxx & int4(15,240,240,15);
        r9.xyzw = (uint4)r9.xyzw;
        InTex4.x = saturate(diffuse + diffuse);
        r4.w = InTex4.x * -2 + 3;
        InTex4.x = InTex4.x * InTex4.x;
        InTex4.x = r4.w * InTex4.x;
        r4.w = -0.5 + diffuse;
        r4.w = saturate(r4.w + r4.w);
        r5.w = r4.w * -2 + 3;
        r4.w = r4.w * r4.w;
        r4.w = r5.w * r4.w;
        r10.xyz = cb1[262].xyz + -cb1[261].xyz;
        r5.w = dot(abs(r10.xyz), float3(0.300000012,0.589999974,0.109999999));
        r5.w = 10 * r5.w;
        r5.w = min(1, r5.w);
        r6.w = r5.w * -2 + 3;
        r5.w = r5.w * r5.w;
        r5.w = r6.w * r5.w;
        r6.w = r5.w * r4.w;
        r7.w = cb1[265].y + -cb1[265].x;
        r8.w = shadow * cb1[253].y + -cb1[265].x;
        r7.w = 1 / r7.w;
        r8.w = saturate(r8.w * r7.w);
        r10.x = r8.w * -2 + 3;
        r8.w = r8.w * r8.w;
        r8.w = r10.x * r8.w;
        r8.w = r8.w * r6.w;
        r10.x = shadow * cb1[253].y + -r8.w;
        r8.w = cb1[265].z * r10.x + r8.w;
        r10.x = -cb1[265].x + r8.w;
        r7.w = saturate(r10.x * r7.w);
        r10.x = r7.w * -2 + 3;
        r7.w = r7.w * r7.w;
        r7.w = r10.x * r7.w;
        r6.w = r7.w * r6.w;
        r4.w = r4.w * r5.w + -r6.w;
        r4.w = cb1[265].z * r4.w + r6.w;
        r5.w = -1 + r8.w;
        r5.w = cb1[260].y * r5.w + 1;
        r6.w = InTex4.w * r4.w + -r5.w;
        r5.w = r5.x * r6.w + r5.w;
        r6.w = InTex4.w * r4.w + -r4.w;
        r10.x = r5.x * r6.w + r4.w;
        r4.w = (r8.y >= r8.z) ? 1.0 : 0.0;
        r4.w = r4.w ? 1.000000 : 0;
        r11.xy = r8.zy;
        r11.zw = float2(-1,0.666666687);
        r12.xy = -r11.xy + r8.yz;
        r12.zw = float2(1,-1);
        r11.xyzw = r4.wwww * r12.xyzw + r11.xyzw;
        r4.w = (r8.x >= r11.x) ? 1.0 : 0.0;
        r4.w = r4.w ? 1.000000 : 0;
        r12.xyz = r11.xyw;
        r12.w = r8.x;
        r11.xyw = r12.wyx;
        r11.xyzw = r11.xyzw + -r12.xyzw;
        r11.xyzw = r4.wwww * r11.xyzw + r12.xyzw;
        r4.w = min(r11.w, r11.y);
        r4.w = r11.x + -r4.w;
        r6.w = r11.w + -r11.y;
        r7.w = r4.w * 6 + 0.00100000005;
        r6.w = r6.w / r7.w;
        r6.w = r11.z + r6.w;
        r7.w = 0.00100000005 + r11.x;
        r4.w = r4.w / r7.w;
        r7.w = r11.x * 0.300000012 + 1;
        r11.xyzw = r9.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
        r8.w = (r9.z >= 2.54999971) ? 1.0 : 0.0;
        r8.w = r8.w ? 1.000000 : 0;
        r9.x = r11.y + -r11.x;
        r9.x = r8.w * r9.x + r11.x;
        r4.w = r9.x * r4.w;
        r4.w = min(0.349999994, r4.w);
        r9.x = max(0, r4.w);
        r9.yzw = float3(1,0.666666687,0.333333343) + abs(r6.www);
        r9.yzw = frac(r9.yzw);
        r9.yzw = r9.yzw * float3(6,6,6) + float3(-3,-3,-3);
        r9.yzw = saturate(float3(-1,-1,-1) + abs(r9.yzw));
        r9.yzw = float3(-1,-1,-1) + r9.yzw;
        r9.xyz = r9.xxx * r9.yzw + float3(1,1,1);
        r4.w = 1 + r4.w;
        r12.xyz = r9.xyz * r4.www;
        r13.xyz = r9.xyz * r4.www + float3(-1,-1,-1);
        r13.xyz = r13.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
        r9.xyz = -r9.xyz * r4.www + r13.xyz;
        r9.xyz = SDFMask_octNormal_Diffuse.xxx * r9.xyz + r12.xyz;
        r12.xyz = r9.xyz + -albedo_ToonSkinMask.xyz;
        r12.xyz = r12.xyz * float3(0.850000024,0.850000024,0.850000024) + albedo_ToonSkinMask.xyz;
        r11.xyz = r11.zzz * r12.xyz + -r9.xyz;
        r9.xyz = r8.www * r11.xyz + r9.xyz;
        r9.xyz = float3(-1,-1,-1) + r9.xyz;
        r9.xyz = r11.www * r9.xyz + float3(1,1,1);
        r11.xyz = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r12.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r11.xyz;
        r11.xyz = r5.www * r12.xyz + r11.xyz;
        r11.xyz = cb1[260].xxx * r11.xyz;
        r11.xyz = r11.xyz * albedo_ToonSkinMask.xyz;
        r12.xyz = r11.xyz * r7.xyz;
        r13.xyz = cb1[261].xyz * albedo_ToonSkinMask.xyz;
        SDFMask_octNormal_Diffuse.x = InTex4.x * 0.300000012 + 0.699999988;
        r14.xyz = r13.xyz * SDFMask_octNormal_Diffuse.xxx;
        r15.xyz = cb1[262].xyz * albedo_ToonSkinMask.xyz;
        r12.xyz = r13.xyz * SDFMask_octNormal_Diffuse.xxx + r12.xyz;
        r13.xyz = albedo_ToonSkinMask.xyz * cb1[262].xyz + -r14.xyz;
        r13.xyz = r13.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r16.xyz = r14.xyz * r9.xyz;
        r13.xyz = r13.xyz * r9.xyz + -r16.xyz;
        r13.xyz = r10.xxx * r13.xyz + r16.xyz;
        r11.xyz = r11.xyz * r7.xyz + r13.xyz;
        r12.xyz = r12.xyz * r9.xyz;
        r13.xyz = r15.xyz * r7.www;
        r9.xyz = r13.xyz * r9.xyz + -r12.xyz;
        r9.xyz = r10.xxx * r9.xyz + r12.xyz;
        ssao = tex2Dlod(_IN8, float4(v0.xy, 0, 0)).x;
        ssao = -1 + ssao;
        ssao = r4.z * ssao + 1;
        r9.xyz = r9.xyz + -r11.xyz;
        r9.xyz = r5.www * r9.xyz + r11.xyz;
        r11.xyz = float3(1,1,1) + -r8.xyz;
        r8.xyz = ssao * r11.xyz + r8.xyz;
        r8.xyz = r9.xyz * r8.xyz;
    } else {
        SDFMask_octNormal_Diffuse.x = saturate(diffuse + diffuse);
        InTex4.x = SDFMask_octNormal_Diffuse.x * -2 + 3;
        SDFMask_octNormal_Diffuse.x = SDFMask_octNormal_Diffuse.x * SDFMask_octNormal_Diffuse.x;
        SDFMask_octNormal_Diffuse.x = InTex4.x * SDFMask_octNormal_Diffuse.x;
        InTex4.x = -0.5 + diffuse;
        InTex4.x = saturate(InTex4.x + InTex4.x);
        r4.z = InTex4.x * -2 + 3;
        InTex4.x = InTex4.x * InTex4.x;
        InTex4.x = r4.z * InTex4.x;
        r9.xyz = cb1[262].xyz + -cb1[261].xyz;
        r4.z = dot(abs(r9.xyz), float3(0.300000012,0.589999974,0.109999999));
        r4.z = 10 * r4.z;
        r4.z = min(1, r4.z);
        r4.w = r4.z * -2 + 3;
        r4.z = r4.z * r4.z;
        r4.z = r4.w * r4.z;
        r4.w = r4.z * InTex4.x;
        r5.w = cb1[265].y + -cb1[265].x;
        r6.w = shadow * cb1[253].y + -cb1[265].x;
        r5.w = 1 / r5.w;
        r6.w = saturate(r6.w * r5.w);
        r7.w = r6.w * -2 + 3;
        r6.w = r6.w * r6.w;
        r6.w = r7.w * r6.w;
        r6.w = r6.w * r4.w;
        shadowColor_ShadeModeOutputMask.w = shadow * cb1[253].y + -r6.w;
        shadowColor_ShadeModeOutputMask.w = cb1[265].z * shadowColor_ShadeModeOutputMask.w + r6.w;
        r6.w = -cb1[265].x + shadowColor_ShadeModeOutputMask.w;
        r5.w = saturate(r6.w * r5.w);
        r6.w = r5.w * -2 + 3;
        r5.w = r5.w * r5.w;
        r5.w = r6.w * r5.w;
        r4.w = r5.w * r4.w;
        InTex4.x = InTex4.x * r4.z + -r4.w;
        InTex4.x = cb1[265].z * InTex4.x + r4.w;
        r4.z = shadowColor_ShadeModeOutputMask.w * r5.y;
        r4.z = 10 * r4.z;
        shadowColor_ShadeModeOutputMask.w = -1 + shadowColor_ShadeModeOutputMask.w;
        shadowColor_ShadeModeOutputMask.w = cb1[260].y * shadowColor_ShadeModeOutputMask.w + 1;
        r4.w = InTex4.w * InTex4.x + -shadowColor_ShadeModeOutputMask.w;
        shadowColor_ShadeModeOutputMask.w = r5.x * r4.w + shadowColor_ShadeModeOutputMask.w;
        r4.w = InTex4.w * InTex4.x + -InTex4.x;
        r10.x = r5.x * r4.w + InTex4.x;
        r5.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r9.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r5.xyw;
        r5.xyw = shadowColor_ShadeModeOutputMask.www * r9.xyz + r5.xyw;
        r5.xyw = cb1[260].xxx * r5.xyw;
        r5.xyw = r5.xyw * albedo_ToonSkinMask.xyz;
        r9.xyz = r5.xyw * r7.xyz;
        r11.xyz = cb1[261].xyz * albedo_ToonSkinMask.xyz;
        SDFMask_octNormal_Diffuse.x = SDFMask_octNormal_Diffuse.x * 0.300000012 + 0.699999988;
        r14.xyz = r11.xyz * SDFMask_octNormal_Diffuse.xxx;
        r11.xyz = r11.xyz * SDFMask_octNormal_Diffuse.xxx + r9.xyz;
        r9.xyz = r9.xyz * r4.zzz + r11.xyz;
        r11.xyz = albedo_ToonSkinMask.xyz * cb1[262].xyz + -r14.xyz;
        r11.xyz = r11.xyz * r10.xxx;
        r11.xyz = r11.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r5.xyw = r5.xyw * r7.xyz + r11.xyz;
        r11.xyz = albedo_ToonSkinMask.xyz * cb1[262].xyz + -r9.xyz;
        r9.xyz = r10.xxx * r11.xyz + r9.xyz;
        r9.xyz = r9.xyz + -r5.xyw;
        r8.xyz = shadowColor_ShadeModeOutputMask.www * r9.xyz + r5.xyw;
    }
    SDFMask_octNormal_Diffuse.x = -0.400000006 + diffuse;
    SDFMask_octNormal_Diffuse.x = saturate(10.000001 * SDFMask_octNormal_Diffuse.x);
    SDFMask_octNormal_Diffuse.w = SDFMask_octNormal_Diffuse.x * -2 + 3;
    SDFMask_octNormal_Diffuse.x = SDFMask_octNormal_Diffuse.x * SDFMask_octNormal_Diffuse.x;
    r10.y = SDFMask_octNormal_Diffuse.w * SDFMask_octNormal_Diffuse.x;
    r5.xyw = r8.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
    r5.xyw = r5.xyw * albedo_ToonSkinMask.xyz;
    r9.xyz = cb1[261].xyz * albedo_ToonSkinMask.xyz;
    r5.xyw = cb1[255].xxx ? r5.xyw : r9.xyz;
    r9.xyz = SDFMask_octNormal_Diffuse.zzz ? r5.xyw : r14.xyz;
    r5.xyw = SDFMask_octNormal_Diffuse.zzz ? r5.xyw : r8.xyz;
    SDFMask_octNormal_Diffuse.xw = SDFMask_octNormal_Diffuse.zz ? float2(0,0) : r10.xy;
    r8.xyz = cb1[264].xyz + cb1[264].xyz;
    r8.xyz = SDFMask_octNormal_Diffuse.xxx * r8.xyz + -cb1[264].xyz;
    r10.xyz = float3(0,0,0);
    shadowColor_ShadeModeOutputMask.w = 1;
    InTex4.x = 0;
    while (true) {
        r4.z = ((uint)InTex4.x >= asuint(cb2[128].x)) ? 1.0 : 0.0;
        if (r4.z != 0) break;
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  r4.z = (((uint)InTex4.x << 3) & bitmask.z) | ((uint)7 & ~bitmask.z);
        bitmask.w = ((~(-1 << 3)) << 5) & 0xffffffff;  r4.w = (((uint)cb2[r4.z+0].w << 5) & bitmask.w) | ((uint)0 & ~bitmask.w);
        r4.w = (int)r4.y & (int)r4.w;
        if (r4.w == 0) {
        r4.w = (int)InTex4.x + 1;
        InTex4.x = r4.w;
        continue;
        }
        r4.w = (uint)InTex4.x << 3;
        r11.xyz = cb2[r4.w+0].xyz + -r6.xyz;
        r6.w = cb2[r4.w+0].w * cb2[r4.w+0].w;
        r7.w = dot(r11.xyz, r11.xyz);
        r6.w = r7.w * r6.w;
        r8.w = (1 >= r6.w) ? 1.0 : 0.0;
        if (r8.w != 0) {
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.x = (((uint)InTex4.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.y = (((uint)InTex4.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.y);
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.z = (((uint)InTex4.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
        bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.w = (((uint)InTex4.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.x = (((uint)InTex4.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.y = (((uint)InTex4.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.y);
        r6.w = saturate(r6.w * 2.5 + -1.5);
        r8.w = r6.w * r6.w;
        r6.w = -r6.w * 2 + 3;
        r6.w = -r8.w * r6.w + 1;
        r7.w = rsqrt(r7.w);
        r14.xyz = r11.xyz * r7.www;
        r7.w = dot(shadowColor_ShadeModeOutputMask.xyz, r14.xyz);
        r7.w = 1 + r7.w;
        r13.zw = cb2[r13.x+0].ww * float2(0.939999998,0.0600000024);
        r7.w = r7.w * 0.5 + -r13.z;
        r8.w = 1 / r13.w;
        r7.w = saturate(r8.w * r7.w);
        r8.w = r7.w * -2 + 3;
        r7.w = r7.w * r7.w;
        r7.w = r8.w * r7.w;
        r7.w = min(1, r7.w);
        r15.xyz = cb2[r13.y+0].xyz * r9.xyz;
        r13.xzw = albedo_ToonSkinMask.xyz * cb2[r13.x+0].xyz + -r15.xyz;
        r13.xzw = r7.www * r13.xzw + r15.xyz;
        r13.xzw = cb2[r4.z+0].xxx * r13.xzw;
        r11.xyz = cb2[r4.w+0].www * r11.xyz;
        r4.w = dot(r11.xyz, r11.xyz);
        r4.w = r4.w * cb2[r12.w+0].x + cb2[r12.w+0].y;
        r4.w = 9.99999975e-005 + r4.w;
        r4.w = 1 / r4.w;
        r4.w = -1 + r4.w;
        r4.w = cb2[r12.w+0].z * r4.w;
        r4.w = r4.w * r4.w;
        r4.w = min(1, r4.w);
        if (4 == 0) r7.w = 0; else if (4+16 < 32) {       r7.w = (uint)cb2[r12.x+0].w << (32-(4 + 16)); r7.w = (uint)r7.w >> (32-4);      } else r7.w = (uint)cb2[r12.x+0].w >> 16;
        r7.w = ((int)r7.w == 2) ? 1.0 : 0.0;
        r8.w = dot(r14.xyz, cb2[r12.x+0].xyz);
        r8.w = -cb2[r12.y+0].x + r8.w;
        r8.w = saturate(cb2[r12.y+0].y * r8.w);
        r8.w = r8.w * r8.w;
        r8.w = r8.w * r8.w;
        r8.w = r8.w * r4.w;
        r4.w = r7.w ? r8.w : r4.w;
        r7.w = dot(r8.xyz, r14.xyz);
        r7.w = saturate(r7.w * 0.5 + 0.5);
        r7.w = SDFMask_octNormal_Diffuse.w * r7.w + -SDFMask_octNormal_Diffuse.x;
        r7.w = cb2[r12.w+0].w * r7.w + SDFMask_octNormal_Diffuse.x;
        r11.xyz = cb2[r12.z+0].www * r9.xyz;
        r12.xyw = -r9.xyz * cb2[r12.z+0].www + albedo_ToonSkinMask.xyz;
        r11.xyz = r7.www * r12.xyw + r11.xyz;
        r11.xyz = cb2[r12.z+0].xyz * r11.xyz;
        r7.w = cb2[r12.z+0].x + cb2[r12.z+0].y;
        r7.w = cb2[r12.z+0].z + r7.w;
        r7.w = cb2[r4.z+0].x + r7.w;
        r7.w = saturate(10 * r7.w);
        r4.z = cb2[r4.z+0].y * r7.w;
        r12.xyz = r13.xzw * r4.www;
        r11.xyz = r11.xyz * r4.www + r12.xyz;
        r6.w = r6.w + -r4.w;
        r4.w = cb2[r13.y+0].w * r6.w + r4.w;
        r10.xyz = r11.xyz * shadowColor_ShadeModeOutputMask.www + r10.xyz;
        r4.z = -r4.w * r4.z + 1;
        shadowColor_ShadeModeOutputMask.w = r4.z * shadowColor_ShadeModeOutputMask.w;
        }
        InTex4.x = (int)InTex4.x + 1;
    }
    r4.yzw = shadowColor_ShadeModeOutputMask.www * r5.xyw + r10.xyz;
    bool useRim = ((int)r4.x != 13) ? 1.0 : 0.0;
    float3 rimColor;
    float3 finalRimColor;
    if (useRim != 0) {
        SDFMask_octNormal_Diffuse.x = ((int)r4.x == 1) ? 1.0 : 0.0;
        SDFMask_octNormal_Diffuse.x = SDFMask_octNormal_Diffuse.x ? InTex4.z : InTex4.y;
        InTex4.xyz = cb1[67].xyz + -r6.xyz;
        SDFMask_octNormal_Diffuse.w = dot(InTex4.xyz, InTex4.xyz);
        SDFMask_octNormal_Diffuse.w = rsqrt(SDFMask_octNormal_Diffuse.w);
        InTex4.xyz = InTex4.xyz * SDFMask_octNormal_Diffuse.www;
        SDFMask_octNormal_Diffuse.w = saturate(-0.100000001 + SDFMask_octNormal_Diffuse.x);
        SDFMask_octNormal_Diffuse.x = saturate(10 * SDFMask_octNormal_Diffuse.x);
        shadowColor_ShadeModeOutputMask.w = SDFMask_octNormal_Diffuse.w * 2000 + 50;
        r4.x = SDFMask_octNormal_Diffuse.w + SDFMask_octNormal_Diffuse.w;
        SDFMask_octNormal_Diffuse.x = cb0[0].x * SDFMask_octNormal_Diffuse.x;
        SDFMask_octNormal_Diffuse.x = SDFMask_octNormal_Diffuse.x * 0.800000012 + r4.x;
        r5.xyw = cb1[21].xyz * shadowColor_ShadeModeOutputMask.yyy;
        r5.xyw = shadowColor_ShadeModeOutputMask.xxx * cb1[20].xyz + r5.xyw;
        r5.xyw = shadowColor_ShadeModeOutputMask.zzz * cb1[22].xyz + r5.xyw;
        r4.x = asint(cb0[0].w);
        r4.x = (0.5 < r4.x) ? 1.0 : 0.0;
        InTex4.xyz = r4.xxx ? float3(0,0,0) : InTex4.xyz;
        r6.xy = r4.xx ? cb0[0].yz : cb1[264].xy;
        r6.z = r4.x ? 0.5 : cb1[264].z;
        shadowColor_ShadeModeOutputMask.xyz = r4.xxx ? r5.xyw : shadowColor_ShadeModeOutputMask.xyz;
        r4.x = dot(r6.xyz, shadowColor_ShadeModeOutputMask.xyz);
        r8.xy = float2(0.200000003,1) + r4.xx;
        r4.x = 5 * r8.x;
        r4.x = saturate(r4.x);
        r5.w = r4.x * -2 + 3;
        r4.x = r4.x * r4.x;
        r4.x = r5.w * r4.x;
        r8.xzw = r6.xyz + InTex4.xyz;
        r5.w = dot(r8.xzw, r8.xzw);
        r5.w = rsqrt(r5.w);
        r8.xzw = r8.xzw * r5.www;
        r5.w = saturate(dot(shadowColor_ShadeModeOutputMask.xyz, r8.xzw));
        r5.w = r5.w * r5.w;
        r5.w = r5.w * -0.800000012 + 1;
        r5.w = r5.w * r5.w;
        r5.w = 3.14159274 * r5.w;
        r5.w = 0.200000003 / r5.w;
        r5.w = r5.w * InTex4.w;
        r6.x = dot(r6.xyz, InTex4.xyz);
        r6.xy = float2(-0.5,1) + -r6.xx;
        r6.x = saturate(r6.x + r6.x);
        r6.z = r6.x * -2 + 3;
        r6.x = r6.x * r6.x;
        r6.x = r6.z * r6.x + 1;
        shadowColor_ShadeModeOutputMask.x = saturate(dot(InTex4.xyz, shadowColor_ShadeModeOutputMask.xyz));
        shadowColor_ShadeModeOutputMask.x = 0.800000012 + -shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = max(0, shadowColor_ShadeModeOutputMask.x);
        shadowColor_ShadeModeOutputMask.y = max(0, cb1[133].x);
        shadowColor_ShadeModeOutputMask.y = min(1.74532926, shadowColor_ShadeModeOutputMask.y);
        shadowColor_ShadeModeOutputMask.xy = float2(1.5,0.572957814) * shadowColor_ShadeModeOutputMask.xy;
        shadowColor_ShadeModeOutputMask.z = max(0, albedo_ToonSkinMask.w);
        InTex4.xy = min(float2(3000,50), shadowColor_ShadeModeOutputMask.zz);
        InTex4.xy = float2(3000,50) + -InTex4.xy;
        InTex4.xy = float2(0.00033333333,0.0199999996) * InTex4.xy;
        shadowColor_ShadeModeOutputMask.z = InTex4.x * InTex4.x;
        shadowColor_ShadeModeOutputMask.z = shadowColor_ShadeModeOutputMask.z * shadowColor_ShadeModeOutputMask.z;
        shadowColor_ShadeModeOutputMask.z = shadowColor_ShadeModeOutputMask.z * shadowColor_ShadeModeOutputMask.z + InTex4.y;
        shadowColor_ShadeModeOutputMask.z = -1 + shadowColor_ShadeModeOutputMask.z;
        shadowColor_ShadeModeOutputMask.y = shadowColor_ShadeModeOutputMask.y * shadowColor_ShadeModeOutputMask.z + 1;
        shadowColor_ShadeModeOutputMask.z = 1 + -shadowColor_ShadeModeOutputMask.y;
        shadowColor_ShadeModeOutputMask.y = SDFMask_octNormal_Diffuse.w * shadowColor_ShadeModeOutputMask.z + shadowColor_ShadeModeOutputMask.y;
        shadowColor_ShadeModeOutputMask.z = r8.y * 0.25 + 0.5;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.z * shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.x * shadowColor_ShadeModeOutputMask.y;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.x * r6.x;
        shadowColor_ShadeModeOutputMask.x = 0.00999999978 * shadowColor_ShadeModeOutputMask.x;
        InTex4.xy = float2(9.99999975e-005,9.99999975e-005) + r5.xy;
        shadowColor_ShadeModeOutputMask.z = dot(InTex4.xy, InTex4.xy);
        shadowColor_ShadeModeOutputMask.z = rsqrt(shadowColor_ShadeModeOutputMask.z);
        InTex4.xy = InTex4.xy * shadowColor_ShadeModeOutputMask.zz;
        InTex4.xy = InTex4.xy * SDFMask_octNormal_Diffuse.xx;
        InTex4.z = InTex4.y * shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.y = -0.5;
        shadowColor_ShadeModeOutputMask.xy = InTex4.xz * shadowColor_ShadeModeOutputMask.xy;
        SDFMask_octNormal_Diffuse.x = 0.400000006 * r6.y;
        shadowColor_ShadeModeOutputMask.z = r4.x * 0.800000012 + 0.200000003;
        InTex4.x = r5.w * r4.x;
        InTex4.x = 1.5 * InTex4.x;
        SDFMask_octNormal_Diffuse.x = SDFMask_octNormal_Diffuse.x * shadowColor_ShadeModeOutputMask.z + InTex4.x;
        shadowColor_ShadeModeOutputMask.z = InTex4.w * 0.5 + 0.5;
        SDFMask_octNormal_Diffuse.x = shadowColor_ShadeModeOutputMask.z * SDFMask_octNormal_Diffuse.x;
        InTex4.xy = v0.xy * cb1[138].xy + -cb1[134].xy;
        shadowColor_ShadeModeOutputMask.xy = InTex4.xy * cb1[135].zw + shadowColor_ShadeModeOutputMask.xy;
        shadowColor_ShadeModeOutputMask.xy = shadowColor_ShadeModeOutputMask.xy * cb1[135].xy + cb1[134].xy;
        shadowColor_ShadeModeOutputMask.xy = cb1[138].zw * shadowColor_ShadeModeOutputMask.xy;
        linearDepth = tex2D(_IN6, shadowColor_ShadeModeOutputMask.xy).x;
        shadowColor_ShadeModeOutputMask.y = linearDepth * cb1[65].x + cb1[65].y;
        shadowColor_ShadeModeOutputMask.x = linearDepth * cb1[65].z + -cb1[65].w;
        shadowColor_ShadeModeOutputMask.x = 1 / shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.y + shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = shadowColor_ShadeModeOutputMask.x + -albedo_ToonSkinMask.w;
        shadowColor_ShadeModeOutputMask.x = max(9.99999975e-005, shadowColor_ShadeModeOutputMask.x);
        SDFMask_octNormal_Diffuse.w = -SDFMask_octNormal_Diffuse.w * 1000 + shadowColor_ShadeModeOutputMask.x;
        shadowColor_ShadeModeOutputMask.x = 1 / shadowColor_ShadeModeOutputMask.w;
        SDFMask_octNormal_Diffuse.w = saturate(shadowColor_ShadeModeOutputMask.x * SDFMask_octNormal_Diffuse.w);
        shadowColor_ShadeModeOutputMask.x = SDFMask_octNormal_Diffuse.w * -2 + 3;
        SDFMask_octNormal_Diffuse.w = SDFMask_octNormal_Diffuse.w * SDFMask_octNormal_Diffuse.w;
        SDFMask_octNormal_Diffuse.w = shadowColor_ShadeModeOutputMask.x * SDFMask_octNormal_Diffuse.w;
        SDFMask_octNormal_Diffuse.w = min(1, SDFMask_octNormal_Diffuse.w);
        shadowColor_ShadeModeOutputMask.x = dot(cb1[263].xyz, float3(0.300000012,0.589999974,0.109999999));
        shadowColor_ShadeModeOutputMask.yzw = cb1[263].xyz + -shadowColor_ShadeModeOutputMask.xxx;
        shadowColor_ShadeModeOutputMask.xyz = shadowColor_ShadeModeOutputMask.yzw * float3(0.75,0.75,0.75) + shadowColor_ShadeModeOutputMask.xxx;
        InTex4.xyz = cb1[263].xyz + -shadowColor_ShadeModeOutputMask.xyz;
        shadowColor_ShadeModeOutputMask.xyz = InTex4.www * InTex4.xyz + shadowColor_ShadeModeOutputMask.xyz;
        shadowColor_ShadeModeOutputMask.xyz = shadowColor_ShadeModeOutputMask.xyz * SDFMask_octNormal_Diffuse.xxx;
        shadowColor_ShadeModeOutputMask.xyz = float3(0.100000001,0.100000001,0.100000001) * shadowColor_ShadeModeOutputMask.xyz;
        InTex4.xyz = float3(1,1,1) + albedo_ToonSkinMask.xyz;
        InTex4.xyz = InTex4.xyz * shadowColor_ShadeModeOutputMask.xyz;
        r5.xyw = albedo_ToonSkinMask.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
        r5.xyw = saturate(-r5.xyw);
        r6.xyz = r5.xyw * float3(-2,-2,-2) + float3(3,3,3);
        r5.xyw = r5.xyw * r5.xyw;
        r5.xyw = r6.xyz * r5.xyw;
        r5.xyw = r5.xyw * float3(14,14,14) + float3(1,1,1);
        shadowColor_ShadeModeOutputMask.xyz = r5.xyw * shadowColor_ShadeModeOutputMask.xyz;
        shadowColor_ShadeModeOutputMask.xyz = shadowColor_ShadeModeOutputMask.xyz * albedo_ToonSkinMask.xyz + -InTex4.xyz;
        shadowColor_ShadeModeOutputMask.xyz = cb1[260].zzz * shadowColor_ShadeModeOutputMask.xyz + InTex4.xyz;
        shadowColor_ShadeModeOutputMask.xyz = shadowColor_ShadeModeOutputMask.xyz * SDFMask_octNormal_Diffuse.www;
        SDFMask_octNormal_Diffuse.x = -10000 + albedo_ToonSkinMask.w;
        SDFMask_octNormal_Diffuse.x = max(0, SDFMask_octNormal_Diffuse.x);
        SDFMask_octNormal_Diffuse.x = min(5000, SDFMask_octNormal_Diffuse.x);
        SDFMask_octNormal_Diffuse.x = 5000 + -SDFMask_octNormal_Diffuse.x;
        SDFMask_octNormal_Diffuse.x = 0.000199999995 * SDFMask_octNormal_Diffuse.x;
        shadowColor_ShadeModeOutputMask.xyz = SDFMask_octNormal_Diffuse.xxx * shadowColor_ShadeModeOutputMask.xyz;
        finalRimColor.xyz = cb0[1].xyz * shadowColor_ShadeModeOutputMask.xyz;
    } else {
        finalRimColor.xyz = float3(0,0,0);
    }
    SDFMask_octNormal_Diffuse.x = (0 != r5.z) ? 1.0 : 0.0;
    albedo_ToonSkinMask.xyz = r4.yzw * r7.xyz;
    albedo_ToonSkinMask.xyz = cb1[263].xyz * albedo_ToonSkinMask.xyz;
    albedo_ToonSkinMask.xyz = albedo_ToonSkinMask.xyz * float3(0.5,0.5,0.5) + -r4.yzw;
    albedo_ToonSkinMask.xyz = SDFMask_octNormal_Diffuse.www * albedo_ToonSkinMask.xyz + r4.yzw;
    shadowColor_ShadeModeOutputMask.xyz = r4.yzw + finalRimColor.xyz;
    shadowColor_ShadeModeOutputMask.xyz = SDFMask_octNormal_Diffuse.xxx ? albedo_ToonSkinMask.xyz : shadowColor_ShadeModeOutputMask.xyz;
    SDFMask_octNormal_Diffuse.xzw = SDFMask_octNormal_Diffuse.zzz ? r4.yzw : shadowColor_ShadeModeOutputMask.xyz;
    SDFMask_octNormal_Diffuse.xyz = SDFMask_octNormal_Diffuse.xzw / EyeAdaptation;
    SDFMask_octNormal_Diffuse.xyz = min(float3(0,0,0), -SDFMask_octNormal_Diffuse.xyz);
    color.xyz = -SDFMask_octNormal_Diffuse.xyz;
    return color;
}

            ENDHLSL
        }
    }
}