Shader "Custom/WWToon"
{
    Properties
    {
        
        _IN0("IN0", 2D) = "white" {}
        _IN1("IN1", 2D) = "white" {}
        _IN2("IN2", 2D) = "white" {}
        _IN3("IN3", 2D) = "white" {}
        _IN4("IN4", 2D) = "white" {}
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
            // 已知 _IN1 XYZ是法线 A是PerObjectData
            // 已知 _IN2 X是Metallic Y是Specular Z是Roughness W是ShadingModelID 场景时 X是 isScene Y不知道 Z不知道
            // 已知 _IN3 是Albedo和Alpha
            // 未知 _IN4
            // 已知 _IN5 R是阴影 G未使用 B是阴影强度 A通道为什么和B一样
            // 已知 _IN6 R16深度
            // 已知 _IN7 1x1像素 全0
            // 已知 _IN8 MSSAO 多分辨率屏幕空间AO
            // 已知 _IN9 1x1像素 控制屏幕亮度
          
float4 frag (Varyings fragmentInput) : SV_Target
{
    // 基于输入uv定义screenUV_ndcUV，zw分量是NDC x（clip.x / clip.w）并复制到 zw
    float4 screenUV_ndcUV = fragmentInput.uv; 

    float4 color = 0;
    
    float4 packedNormalWS_perObjectData = 0, msr_shadingModelID = 0, albedo_alpha = 0, customData = 0, model_low4_high4 = 0, model13_14_15 = 0, r6 = 0, r7 = 0, r8 = 0, r9 = 0, r10 = 0, r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0, r16 = 0;
uint4 bitmask = 0, uiDest = 0;
float4 fDest = 0;
    float alpha_dynamic;
    float checkerboardPattern;
    float shadingModelID;
    float depth;
    float3 msr;
    float3 msrSq;
    float3 sceneMask_unk_unk;
    uint3 sceneMask_unk_unk_mask;
    float3 normal;
    bool isChara12;
    bool isCharaHair13;
    bool isCharaAnisotropicMetal14;
    bool isCharaAnisotropicFabric15;
    bool isCharaPart; // low 13 14 15
    bool isScene; // low 10
    float nomalizeTemp;
    float perObjectData = 0;
    bool is_cb1_162y;
    bool is_cb1_220z;
    bool is_unk1;
    bool2 isModel_5_13;
    float3 albedo_new;
    float light_intensity;
    float2 clipPos;
    float3 posWS;
    float2 shadow_shadowIntentity;
    float shadow;

    packedNormalWS_perObjectData.xyzw = tex2Dlod(_IN1, float4(screenUV_ndcUV.xy, 0, 0)).wxyz;
    msr_shadingModelID.xyzw = tex2Dlod(_IN2, float4(screenUV_ndcUV.xy, 0, 0)).xyzw;
    albedo_alpha.xyz = tex2Dlod(_IN3, float4(screenUV_ndcUV.xy, 0, 0)).xyz;
    customData.xyz = tex2Dlod(_IN4, float4(screenUV_ndcUV.xy, 0, 0)).yxz;
    
    depth = tex2Dlod(_IN0, float4(screenUV_ndcUV.xy, 0, 0)).x;
    alpha_dynamic = depth * cb1[65].x + cb1[65].y;
    depth = depth * cb1[65].z + -cb1[65].w;
    depth = 1 / depth;
    depth = alpha_dynamic + depth;
    
    uint2 uv_scaled = _ScaledScreenParams.xy * screenUV_ndcUV.xy;
    uv_scaled = (uint2)uv_scaled.xy;
    _FrameJitterSeed = (uint)cb1[158].x;
    uv_scaled.x = (int)uv_scaled.y + (int)uv_scaled.x;
    checkerboardPattern = (int)_FrameJitterSeed + (int)uv_scaled.x;
    checkerboardPattern = (int)checkerboardPattern & 1;
    
    shadingModelID = 255 * msr_shadingModelID.w;
    shadingModelID = round(shadingModelID);
    shadingModelID = (uint)shadingModelID;
    model_low4_high4.xy = (int2)shadingModelID & int2(15,-16); // x是00001111 y是11110000 mask后的结果
    isChara12 = ((int)model_low4_high4.x != 12) ? 1.0 : 0.0;
    model13_14_15.xyz = ((int3)model_low4_high4.xxx == int3(13,14,15)) ? 1.0 : 0.0;
    isCharaHair13 = model13_14_15.x;
    isCharaAnisotropicMetal14 = model13_14_15.y;
    isCharaAnisotropicFabric15 = model13_14_15.z;
    model_low4_high4.z = (int)isCharaAnisotropicFabric15 | (int)isCharaAnisotropicMetal14;
    model_low4_high4.z = (int)model_low4_high4.z | (int)isCharaHair13;
    isCharaPart = isChara12 ? model_low4_high4.z : -1;
    if (isCharaPart != 0) {
        model_low4_high4.x = isCharaHair13 ? 13 : 12;
        model13_14_15.xz = float2(isCharaAnisotropicMetal14, isCharaAnisotropicFabric15) ? float2(1,1) : 0;
        float2 octNormalWS = packedNormalWS_perObjectData.yz * float2(2,2) - float2(1,1);
        // shadingModelID = dot(float2(1,1), abs(octNormalWS.xy));
        // normal.z = 1 + -shadingModelID;
        // shadingModelID = max(0, -normal.z);
        // r7.xy = (octNormalWS.xy >= float2(0,0)) ? 1.0 : 0.0;
        // r7.xy = r7.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
        // r7.xy = r7.xy * shadingModelID;
        // normal.xy = r7.xy * float2(-2,-2) + octNormalWS.xy;
        // shadingModelID = dot(normal.xyz, normal.xyz);
        // shadingModelID = rsqrt(shadingModelID);
        // normal.xyz = normal.xyz * shadingModelID;
        normal.xyz = UnpackNormalOctQuadEncode(octNormalWS);
        msrSq = msr_shadingModelID.xyz * msr_shadingModelID.xyz;
        isCharaAnisotropicMetal14 = customData.z;
    } else { // isScene
        isScene = ((int)model_low4_high4.x == 10) ? 1.0 : 0.0;
        sceneMask_unk_unk.xyz = saturate(msr_shadingModelID.xyz);
        sceneMask_unk_unk.xyz = float3(16777215,65535,255) * sceneMask_unk_unk.xyz;
        sceneMask_unk_unk.xyz = round(sceneMask_unk_unk.xyz);
        sceneMask_unk_unk_mask.xyz = (uint3)sceneMask_unk_unk.xyz;
        bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  sceneMask_unk_unk_mask.y = (((uint)sceneMask_unk_unk_mask.z << 0) & bitmask.y) | ((uint)sceneMask_unk_unk_mask.y & ~bitmask.y);
        bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  sceneMask_unk_unk_mask.x = (((uint)sceneMask_unk_unk_mask.y << 0) & bitmask.x) | ((uint)sceneMask_unk_unk_mask.x & ~bitmask.x);
        sceneMask_unk_unk_mask.x = (uint)sceneMask_unk_unk_mask.x;
        sceneMask_unk_unk_mask.x = 5.96046519e-008 * sceneMask_unk_unk_mask.x;
        sceneMask_unk_unk_mask.y = sceneMask_unk_unk_mask.x * cb1[65].x + cb1[65].y;
        sceneMask_unk_unk_mask.x = sceneMask_unk_unk_mask.x * cb1[65].z + -cb1[65].w;
        sceneMask_unk_unk_mask.x = 1 / sceneMask_unk_unk_mask.x;
        sceneMask_unk_unk_mask.x = sceneMask_unk_unk_mask.y + sceneMask_unk_unk_mask.x;
        depth = isScene ? sceneMask_unk_unk_mask.x : depth;
        normal.xyz = packedNormalWS_perObjectData.yzw * float3(2,2,2) + float3(-1,-1,-1);
        msrSq = float3(0,0,0);
        model13_14_15.xyz = float3(0,0,0);
        packedNormalWS_perObjectData.xw = float2(0,0);
        customData.xy = float2(0,0);
    }
    nomalizeTemp = dot(normal.xyz, normal.xyz);
    nomalizeTemp = rsqrt(nomalizeTemp);
    normal.xyz = normal.xyz * nomalizeTemp;
    isModel_5_13 = ((int2)model_low4_high4.xx == int2(5,13)) ? 1.0 : 0.0;
    is_cb1_162y = (0 < cb1[162].y) ? 1.0 : 0.0;
    is_cb1_220z = (0 < cb1[220].z) ? 1.0 : 0.0;
    is_unk1 = is_cb1_162y ? is_cb1_220z : 0;
    is_cb1_220z = (0 != cb1[162].y) ? 1.0 : 0.0;
    albedo_new.xyz = is_cb1_220z ? float3(1,1,1) : albedo_alpha.xyz;
    checkerboardPattern = checkerboardPattern ? 1 : 0;
    albedo_new.xyz = is_unk1 ? checkerboardPattern : albedo_new.xyz;
    albedo_alpha.xyz = isModel_5_13.x ? albedo_new.xyz : albedo_alpha.xyz;
    light_intensity = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
    clipPos = screenUV_ndcUV.zw * depth;
    
    posWS.xyz = cb1[49].xyz * clipPos.y;
    posWS.xyz = clipPos.x * cb1[48].xyz + posWS.xyz;
    posWS.xyz = depth * cb1[50].xyz + posWS.xyz;
    posWS.xyz = cb1[51].xyz + posWS.xyz;
    shadow_shadowIntentity = tex2Dlod(_IN5, float4(screenUV_ndcUV.xy, 0, 0)).xz;
    shadow_shadowIntentity = shadow_shadowIntentity * shadow_shadowIntentity;
    shadow = shadow_shadowIntentity.x * shadow_shadowIntentity.y;
    checkerboardPattern = cb1[253].y * shadow;
    if (cb1[255].x != 0) {
        r8.xyz = float3(0,0,0);
        model_low4_high4.zw = float2(0,0);
        model13_14_15.w = 0;
        r6.w = 0;
        while (true) {
        r7.w = ((int)model_low4_high4.z >= 3) ? 1.0 : 0.0;
        if (r7.w != 0) break;
        model_low4_high4.w = 0.000833333295 + model_low4_high4.w;
        r9.xyz = r8.xyz;
        r7.w = model13_14_15.w;
        r8.w = r6.w;
        r9.w = 0;
        while (true) {
            r10.x = ((int)r9.w >= 3) ? 1.0 : 0.0;
            if (r10.x != 0) break;
            r7.w = 1 + r7.w;
            r10.x = 2.09439516 * r7.w;
            sincos(r10.x, r10.x, r11.x);
            r11.x = r11.x * model_low4_high4.w + screenUV_ndcUV.x;
            r11.y = r10.x * model_low4_high4.w + screenUV_ndcUV.y;
            r10.xyz = tex2D(_IN7, r11.xy).xyz;
            r9.xyz = r10.xyz * model_low4_high4.www + r9.xyz;
            r8.w = r8.w + model_low4_high4.w;
            r9.w = (int)r9.w + 1;
        }
        r8.xyz = r9.xyz;
        r6.w = r8.w;
        model13_14_15.w = 0.620000005 + r7.w;
        model_low4_high4.z = (int)model_low4_high4.z + 1;
        }
        r8.xyz = r8.xyz / r6.www;
        r9.xyz = (float3(0.644999981,0.312000006,0.978999972) < perObjectData) ? 1.0 : 0.0;
        r10.xyz = (perObjectData < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
        r9.xyz = r9.xyz ? r10.xyz : 0;
        perObjectData = r9.z ? 1.000000 : 0;
        perObjectData = r9.y ? 0 : perObjectData;
        perObjectData = r9.x ? 1 : perObjectData;
        model_low4_high4.z = (int)r9.y | (int)r9.z;
        model_low4_high4.z = (int)model_low4_high4.z & 0x3f800000;
        model_low4_high4.z = r9.x ? 0 : model_low4_high4.z;
        customData.x = 255 * customData.x;
        customData.x = round(customData.x);
        customData.x = (uint)customData.x;
        r9.xyzw = (int4)customData.xxxx & int4(15,240,240,15);
        r9.xyzw = (uint4)r9.xyzw;
        customData.x = saturate(packedNormalWS_perObjectData.w + packedNormalWS_perObjectData.w);
        model_low4_high4.w = customData.x * -2 + 3;
        customData.x = customData.x * customData.x;
        customData.x = model_low4_high4.w * customData.x;
        model_low4_high4.w = -0.5 + packedNormalWS_perObjectData.w;
        model_low4_high4.w = saturate(model_low4_high4.w + model_low4_high4.w);
        model13_14_15.w = model_low4_high4.w * -2 + 3;
        model_low4_high4.w = model_low4_high4.w * model_low4_high4.w;
        model_low4_high4.w = model13_14_15.w * model_low4_high4.w;
        r10.xyz = cb1[262].xyz + -cb1[261].xyz;
        model13_14_15.w = dot(abs(r10.xyz), float3(0.300000012,0.589999974,0.109999999));
        model13_14_15.w = 10 * model13_14_15.w;
        model13_14_15.w = min(1, model13_14_15.w);
        r6.w = model13_14_15.w * -2 + 3;
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = r6.w * model13_14_15.w;
        r6.w = model13_14_15.w * model_low4_high4.w;
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
        model_low4_high4.w = model_low4_high4.w * model13_14_15.w + -r6.w;
        model_low4_high4.w = cb1[265].z * model_low4_high4.w + r6.w;
        model13_14_15.w = -1 + r8.w;
        model13_14_15.w = cb1[260].y * model13_14_15.w + 1;
        r6.w = checkerboardPattern * model_low4_high4.w + -model13_14_15.w;
        model13_14_15.w = model13_14_15.x * r6.w + model13_14_15.w;
        r6.w = checkerboardPattern * model_low4_high4.w + -model_low4_high4.w;
        r10.x = model13_14_15.x * r6.w + model_low4_high4.w;
        model_low4_high4.w = (r8.y >= r8.z) ? 1.0 : 0.0;
        model_low4_high4.w = model_low4_high4.w ? 1.000000 : 0;
        r11.xy = r8.zy;
        r11.zw = float2(-1,0.666666687);
        r12.xy = -r11.xy + r8.yz;
        r12.zw = float2(1,-1);
        r11.xyzw = model_low4_high4.wwww * r12.xyzw + r11.xyzw;
        model_low4_high4.w = (r8.x >= r11.x) ? 1.0 : 0.0;
        model_low4_high4.w = model_low4_high4.w ? 1.000000 : 0;
        r12.xyz = r11.xyw;
        r12.w = r8.x;
        r11.xyw = r12.wyx;
        r11.xyzw = r11.xyzw + -r12.xyzw;
        r11.xyzw = model_low4_high4.wwww * r11.xyzw + r12.xyzw;
        model_low4_high4.w = min(r11.w, r11.y);
        model_low4_high4.w = r11.x + -model_low4_high4.w;
        r6.w = r11.w + -r11.y;
        r7.w = model_low4_high4.w * 6 + 0.00100000005;
        r6.w = r6.w / r7.w;
        r6.w = r11.z + r6.w;
        r7.w = 0.00100000005 + r11.x;
        model_low4_high4.w = model_low4_high4.w / r7.w;
        r7.w = r11.x * 0.300000012 + 1;
        r11.xyzw = r9.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
        r8.w = (r9.z >= 2.54999971) ? 1.0 : 0.0;
        r8.w = r8.w ? 1.000000 : 0;
        r9.x = r11.y + -r11.x;
        r9.x = r8.w * r9.x + r11.x;
        model_low4_high4.w = r9.x * model_low4_high4.w;
        model_low4_high4.w = min(0.349999994, model_low4_high4.w);
        r9.x = max(0, model_low4_high4.w);
        r9.yzw = float3(1,0.666666687,0.333333343) + abs(r6.www);
        r9.yzw = frac(r9.yzw);
        r9.yzw = r9.yzw * float3(6,6,6) + float3(-3,-3,-3);
        r9.yzw = saturate(float3(-1,-1,-1) + abs(r9.yzw));
        r9.yzw = float3(-1,-1,-1) + r9.yzw;
        r9.xyz = r9.xxx * r9.yzw + float3(1,1,1);
        model_low4_high4.w = 1 + model_low4_high4.w;
        r12.xyz = r9.xyz * model_low4_high4.www;
        r13.xyz = r9.xyz * model_low4_high4.www + float3(-1,-1,-1);
        r13.xyz = r13.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
        r9.xyz = -r9.xyz * model_low4_high4.www + r13.xyz;
        r9.xyz = perObjectData * r9.xyz + r12.xyz;
        r12.xyz = r9.xyz + -albedo_alpha.xyz;
        r12.xyz = r12.xyz * float3(0.850000024,0.850000024,0.850000024) + albedo_alpha.xyz;
        r11.xyz = r11.zzz * r12.xyz + -r9.xyz;
        r9.xyz = r8.www * r11.xyz + r9.xyz;
        r9.xyz = float3(-1,-1,-1) + r9.xyz;
        r9.xyz = r11.www * r9.xyz + float3(1,1,1);
        r11.xyz = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r12.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r11.xyz;
        r11.xyz = model13_14_15.www * r12.xyz + r11.xyz;
        r11.xyz = cb1[260].xxx * r11.xyz;
        r11.xyz = r11.xyz * albedo_alpha.xyz;
        r12.xyz = r11.xyz * msrSq;
        r13.xyz = cb1[261].xyz * albedo_alpha.xyz;
        perObjectData = customData.x * 0.300000012 + 0.699999988;
        r14.xyz = r13.xyz * perObjectData;
        r15.xyz = cb1[262].xyz * albedo_alpha.xyz;
        r12.xyz = r13.xyz * perObjectData + r12.xyz;
        r13.xyz = albedo_alpha.xyz * cb1[262].xyz + -r14.xyz;
        r13.xyz = r13.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r16.xyz = r14.xyz * r9.xyz;
        r13.xyz = r13.xyz * r9.xyz + -r16.xyz;
        r13.xyz = r10.xxx * r13.xyz + r16.xyz;
        r11.xyz = r11.xyz * msrSq + r13.xyz;
        r12.xyz = r12.xyz * r9.xyz;
        r13.xyz = r15.xyz * r7.www;
        r9.xyz = r13.xyz * r9.xyz + -r12.xyz;
        r9.xyz = r10.xxx * r9.xyz + r12.xyz;
        perObjectData = tex2Dlod(_IN8, float4(screenUV_ndcUV.xy, 0, 0)).x;
        perObjectData = -1 + perObjectData;
        perObjectData = model_low4_high4.z * perObjectData + 1;
        r9.xyz = r9.xyz + -r11.xyz;
        r9.xyz = model13_14_15.www * r9.xyz + r11.xyz;
        r11.xyz = float3(1,1,1) + -r8.xyz;
        r8.xyz = perObjectData * r11.xyz + r8.xyz;
        r8.xyz = r9.xyz * r8.xyz;
    } else {
        perObjectData = saturate(packedNormalWS_perObjectData.w + packedNormalWS_perObjectData.w);
        customData.x = perObjectData * -2 + 3;
        perObjectData = perObjectData * perObjectData;
        perObjectData = customData.x * perObjectData;
        customData.x = -0.5 + packedNormalWS_perObjectData.w;
        customData.x = saturate(customData.x + customData.x);
        model_low4_high4.z = customData.x * -2 + 3;
        customData.x = customData.x * customData.x;
        customData.x = model_low4_high4.z * customData.x;
        r9.xyz = cb1[262].xyz + -cb1[261].xyz;
        model_low4_high4.z = dot(abs(r9.xyz), float3(0.300000012,0.589999974,0.109999999));
        model_low4_high4.z = 10 * model_low4_high4.z;
        model_low4_high4.z = min(1, model_low4_high4.z);
        model_low4_high4.w = model_low4_high4.z * -2 + 3;
        model_low4_high4.z = model_low4_high4.z * model_low4_high4.z;
        model_low4_high4.z = model_low4_high4.w * model_low4_high4.z;
        model_low4_high4.w = model_low4_high4.z * customData.x;
        model13_14_15.w = cb1[265].y + -cb1[265].x;
        r6.w = shadow * cb1[253].y + -cb1[265].x;
        model13_14_15.w = 1 / model13_14_15.w;
        r6.w = saturate(r6.w * model13_14_15.w);
        r7.w = r6.w * -2 + 3;
        r6.w = r6.w * r6.w;
        r6.w = r7.w * r6.w;
        r6.w = r6.w * model_low4_high4.w;
        shadingModelID = shadow * cb1[253].y + -r6.w;
        shadingModelID = cb1[265].z * shadingModelID + r6.w;
        r6.w = -cb1[265].x + shadingModelID;
        model13_14_15.w = saturate(r6.w * model13_14_15.w);
        r6.w = model13_14_15.w * -2 + 3;
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = r6.w * model13_14_15.w;
        model_low4_high4.w = model13_14_15.w * model_low4_high4.w;
        customData.x = customData.x * model_low4_high4.z + -model_low4_high4.w;
        customData.x = cb1[265].z * customData.x + model_low4_high4.w;
        model_low4_high4.z = shadingModelID * isCharaAnisotropicMetal14;
        model_low4_high4.z = 10 * model_low4_high4.z;
        shadingModelID = -1 + shadingModelID;
        shadingModelID = cb1[260].y * shadingModelID + 1;
        model_low4_high4.w = checkerboardPattern * customData.x + -shadingModelID;
        shadingModelID = model13_14_15.x * model_low4_high4.w + shadingModelID;
        model_low4_high4.w = checkerboardPattern * customData.x + -customData.x;
        r10.x = model13_14_15.x * model_low4_high4.w + customData.x;
        model13_14_15.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r9.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -model13_14_15.xyw;
        model13_14_15.xyw = shadingModelID * r9.xyz + model13_14_15.xyw;
        model13_14_15.xyw = cb1[260].xxx * model13_14_15.xyw;
        model13_14_15.xyw = model13_14_15.xyw * albedo_alpha.xyz;
        r9.xyz = model13_14_15.xyw * msrSq;
        r11.xyz = cb1[261].xyz * albedo_alpha.xyz;
        perObjectData = perObjectData * 0.300000012 + 0.699999988;
        r14.xyz = r11.xyz * perObjectData;
        r11.xyz = r11.xyz * perObjectData + r9.xyz;
        r9.xyz = r9.xyz * model_low4_high4.zzz + r11.xyz;
        r11.xyz = albedo_alpha.xyz * cb1[262].xyz + -r14.xyz;
        r11.xyz = r11.xyz * r10.xxx;
        r11.xyz = r11.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        model13_14_15.xyw = model13_14_15.xyw * msrSq + r11.xyz;
        r11.xyz = albedo_alpha.xyz * cb1[262].xyz + -r9.xyz;
        r9.xyz = r10.xxx * r11.xyz + r9.xyz;
        r9.xyz = r9.xyz + -model13_14_15.xyw;
        r8.xyz = shadingModelID * r9.xyz + model13_14_15.xyw;
    }
    perObjectData = -0.400000006 + packedNormalWS_perObjectData.w;
    perObjectData = saturate(10.000001 * perObjectData);
    packedNormalWS_perObjectData.w = perObjectData * -2 + 3;
    perObjectData = perObjectData * perObjectData;
    r10.y = packedNormalWS_perObjectData.w * perObjectData;
    model13_14_15.xyw = r8.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
    model13_14_15.xyw = model13_14_15.xyw * albedo_alpha.xyz;
    r9.xyz = cb1[261].xyz * albedo_alpha.xyz;
    model13_14_15.xyw = cb1[255].xxx ? model13_14_15.xyw : r9.xyz;
    r9.xyz = isModel_5_13.y ? model13_14_15.xyw : r14.xyz;
    model13_14_15.xyw = isModel_5_13.y ? model13_14_15.xyw : r8.xyz;
    packedNormalWS_perObjectData.xw = isModel_5_13.y ? float2(0,0) : r10.xy;
    r8.xyz = cb1[264].xyz + cb1[264].xyz;
    r8.xyz = perObjectData * r8.xyz + -cb1[264].xyz;
    r10.xyz = float3(0,0,0);
    shadingModelID = 1;
    customData.x = 0;
    while (true) {
        model_low4_high4.z = ((uint)customData.x >= asuint(cb2[128].x)) ? 1.0 : 0.0;
        if (model_low4_high4.z != 0) break;
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  model_low4_high4.z = (((uint)customData.x << 3) & bitmask.z) | ((uint)7 & ~bitmask.z);
        bitmask.w = ((~(-1 << 3)) << 5) & 0xffffffff;  model_low4_high4.w = (((uint)cb2[model_low4_high4.z+0].w << 5) & bitmask.w) | ((uint)0 & ~bitmask.w);
        model_low4_high4.w = (int)model_low4_high4.y & (int)model_low4_high4.w;
        if (model_low4_high4.w == 0) {
        model_low4_high4.w = (int)customData.x + 1;
        customData.x = model_low4_high4.w;
        continue;
        }
        model_low4_high4.w = (uint)customData.x << 3;
        r11.xyz = cb2[model_low4_high4.w+0].xyz + -posWS.xyz;
        r6.w = cb2[model_low4_high4.w+0].w * cb2[model_low4_high4.w+0].w;
        r7.w = dot(r11.xyz, r11.xyz);
        r6.w = r7.w * r6.w;
        r8.w = (1 >= r6.w) ? 1.0 : 0.0;
        if (r8.w != 0) {
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.x = (((uint)customData.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.y = (((uint)customData.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.y);
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.z = (((uint)customData.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
        bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.w = (((uint)customData.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.x = (((uint)customData.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.y = (((uint)customData.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.y);
        r6.w = saturate(r6.w * 2.5 + -1.5);
        r8.w = r6.w * r6.w;
        r6.w = -r6.w * 2 + 3;
        r6.w = -r8.w * r6.w + 1;
        r7.w = rsqrt(r7.w);
        r14.xyz = r11.xyz * r7.www;
        r7.w = dot(normal.xyz, r14.xyz);
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
        r13.xzw = albedo_alpha.xyz * cb2[r13.x+0].xyz + -r15.xyz;
        r13.xzw = r7.www * r13.xzw + r15.xyz;
        r13.xzw = cb2[model_low4_high4.z+0].xxx * r13.xzw;
        r11.xyz = cb2[model_low4_high4.w+0].www * r11.xyz;
        model_low4_high4.w = dot(r11.xyz, r11.xyz);
        model_low4_high4.w = model_low4_high4.w * cb2[r12.w+0].x + cb2[r12.w+0].y;
        model_low4_high4.w = 9.99999975e-005 + model_low4_high4.w;
        model_low4_high4.w = 1 / model_low4_high4.w;
        model_low4_high4.w = -1 + model_low4_high4.w;
        model_low4_high4.w = cb2[r12.w+0].z * model_low4_high4.w;
        model_low4_high4.w = model_low4_high4.w * model_low4_high4.w;
        model_low4_high4.w = min(1, model_low4_high4.w);
        if (4 == 0) r7.w = 0; else if (4+16 < 32) {       r7.w = (uint)cb2[r12.x+0].w << (32-(4 + 16)); r7.w = (uint)r7.w >> (32-4);      } else r7.w = (uint)cb2[r12.x+0].w >> 16;
        r7.w = ((int)r7.w == 2) ? 1.0 : 0.0;
        r8.w = dot(r14.xyz, cb2[r12.x+0].xyz);
        r8.w = -cb2[r12.y+0].x + r8.w;
        r8.w = saturate(cb2[r12.y+0].y * r8.w);
        r8.w = r8.w * r8.w;
        r8.w = r8.w * r8.w;
        r8.w = r8.w * model_low4_high4.w;
        model_low4_high4.w = r7.w ? r8.w : model_low4_high4.w;
        r7.w = dot(r8.xyz, r14.xyz);
        r7.w = saturate(r7.w * 0.5 + 0.5);
        r7.w = packedNormalWS_perObjectData.w * r7.w + -perObjectData;
        r7.w = cb2[r12.w+0].w * r7.w + perObjectData;
        r11.xyz = cb2[r12.z+0].www * r9.xyz;
        r12.xyw = -r9.xyz * cb2[r12.z+0].www + albedo_alpha.xyz;
        r11.xyz = r7.www * r12.xyw + r11.xyz;
        r11.xyz = cb2[r12.z+0].xyz * r11.xyz;
        r7.w = cb2[r12.z+0].x + cb2[r12.z+0].y;
        r7.w = cb2[r12.z+0].z + r7.w;
        r7.w = cb2[model_low4_high4.z+0].x + r7.w;
        r7.w = saturate(10 * r7.w);
        model_low4_high4.z = cb2[model_low4_high4.z+0].y * r7.w;
        r12.xyz = r13.xzw * model_low4_high4.www;
        r11.xyz = r11.xyz * model_low4_high4.www + r12.xyz;
        r6.w = r6.w + -model_low4_high4.w;
        model_low4_high4.w = cb2[r13.y+0].w * r6.w + model_low4_high4.w;
        r10.xyz = r11.xyz * shadingModelID + r10.xyz;
        model_low4_high4.z = -model_low4_high4.w * model_low4_high4.z + 1;
        shadingModelID = model_low4_high4.z * shadingModelID;
        }
        customData.x = (int)customData.x + 1;
    }
    model_low4_high4.yzw = shadingModelID * model13_14_15.xyw + r10.xyz;
    perObjectData = ((int)model_low4_high4.x != 13) ? 1.0 : 0.0;
    if (perObjectData != 0) {
        perObjectData = ((int)model_low4_high4.x == 1) ? 1.0 : 0.0;
        perObjectData = perObjectData ? customData.z : customData.y;
        customData.xyz = cb1[67].xyz + -posWS.xyz;
        packedNormalWS_perObjectData.w = dot(customData.xyz, customData.xyz);
        packedNormalWS_perObjectData.w = rsqrt(packedNormalWS_perObjectData.w);
        customData.xyz = customData.xyz * packedNormalWS_perObjectData.www;
        packedNormalWS_perObjectData.w = saturate(-0.100000001 + perObjectData);
        perObjectData = saturate(10 * perObjectData);
        shadingModelID = packedNormalWS_perObjectData.w * 2000 + 50;
        model_low4_high4.x = packedNormalWS_perObjectData.w + packedNormalWS_perObjectData.w;
        perObjectData = cb0[0].x * perObjectData;
        perObjectData = perObjectData * 0.800000012 + model_low4_high4.x;
        model13_14_15.xyw = cb1[21].xyz * normal.yyy;
        model13_14_15.xyw = normal.xxx * cb1[20].xyz + model13_14_15.xyw;
        model13_14_15.xyw = normal.zzz * cb1[22].xyz + model13_14_15.xyw;
        model_low4_high4.x = asint(cb0[0].w);
        model_low4_high4.x = (0.5 < model_low4_high4.x) ? 1.0 : 0.0;
        customData.xyz = model_low4_high4.xxx ? float3(0,0,0) : customData.xyz;
        r6.xy = model_low4_high4.xx ? cb0[0].yz : cb1[264].xy;
        r6.z = model_low4_high4.x ? 0.5 : cb1[264].z;
        normal.xyz = model_low4_high4.xxx ? model13_14_15.xyw : normal.xyz;
        model_low4_high4.x = dot(r6.xyz, normal.xyz);
        r8.xy = float2(0.200000003,1) + model_low4_high4.xx;
        model_low4_high4.x = 5 * r8.x;
        model_low4_high4.x = saturate(model_low4_high4.x);
        model13_14_15.w = model_low4_high4.x * -2 + 3;
        model_low4_high4.x = model_low4_high4.x * model_low4_high4.x;
        model_low4_high4.x = model13_14_15.w * model_low4_high4.x;
        r8.xzw = r6.xyz + customData.xyz;
        model13_14_15.w = dot(r8.xzw, r8.xzw);
        model13_14_15.w = rsqrt(model13_14_15.w);
        r8.xzw = r8.xzw * model13_14_15.www;
        model13_14_15.w = saturate(dot(normal.xyz, r8.xzw));
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = model13_14_15.w * -0.800000012 + 1;
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = 3.14159274 * model13_14_15.w;
        model13_14_15.w = 0.200000003 / model13_14_15.w;
        model13_14_15.w = model13_14_15.w * checkerboardPattern;
        r6.x = dot(r6.xyz, customData.xyz);
        r6.xy = float2(-0.5,1) + -r6.xx;
        r6.x = saturate(r6.x + r6.x);
        r6.z = r6.x * -2 + 3;
        r6.x = r6.x * r6.x;
        r6.x = r6.z * r6.x + 1;
        normal.x = saturate(dot(customData.xyz, normal.xyz));
        normal.x = 0.800000012 + -normal.x;
        normal.x = max(0, normal.x);
        normal.y = max(0, cb1[133].x);
        normal.y = min(1.74532926, normal.y);
        normal.xy = float2(1.5,0.572957814) * normal.xy;
        normal.z = max(0, depth);
        customData.xy = min(float2(3000,50), normal.zz);
        customData.xy = float2(3000,50) + -customData.xy;
        customData.xy = float2(0.00033333333,0.0199999996) * customData.xy;
        normal.z = customData.x * customData.x;
        normal.z = normal.z * normal.z;
        normal.z = normal.z * normal.z + customData.y;
        normal.z = -1 + normal.z;
        normal.y = normal.y * normal.z + 1;
        normal.z = 1 + -normal.y;
        normal.y = packedNormalWS_perObjectData.w * normal.z + normal.y;
        normal.z = r8.y * 0.25 + 0.5;
        normal.x = normal.z * normal.x;
        normal.x = normal.x * normal.y;
        normal.x = normal.x * r6.x;
        normal.x = 0.00999999978 * normal.x;
        customData.xy = float2(9.99999975e-005,9.99999975e-005) + model13_14_15.xy;
        normal.z = dot(customData.xy, customData.xy);
        normal.z = rsqrt(normal.z);
        customData.xy = customData.xy * normal.zz;
        customData.xy = customData.xy * perObjectData;
        customData.z = customData.y * normal.x;
        normal.y = -0.5;
        normal.xy = customData.xz * normal.xy;
        perObjectData = 0.400000006 * r6.y;
        normal.z = model_low4_high4.x * 0.800000012 + 0.200000003;
        customData.x = model13_14_15.w * model_low4_high4.x;
        customData.x = 1.5 * customData.x;
        perObjectData = perObjectData * normal.z + customData.x;
        normal.z = checkerboardPattern * 0.5 + 0.5;
        perObjectData = normal.z * perObjectData;
        customData.xy = screenUV_ndcUV.xy * _ScaledScreenParams.xy + -cb1[134].xy;
        normal.xy = customData.xy * cb1[135].zw + normal.xy;
        normal.xy = normal.xy * cb1[135].xy + cb1[134].xy;
        normal.xy = ((_ScaledScreenParams.zw - 1) * normal.xy); // unity需要多一步 因为是1开头的
        normal.x = tex2D(_IN6, normal.xy).x;
        normal.y = normal.x * cb1[65].x + cb1[65].y;
        normal.x = normal.x * cb1[65].z + -cb1[65].w;
        normal.x = 1 / normal.x;
        normal.x = normal.y + normal.x;
        normal.x = normal.x + -depth;
        normal.x = max(9.99999975e-005, normal.x);
        packedNormalWS_perObjectData.w = -packedNormalWS_perObjectData.w * 1000 + normal.x;
        normal.x = 1 / shadingModelID;
        packedNormalWS_perObjectData.w = saturate(normal.x * packedNormalWS_perObjectData.w);
        normal.x = packedNormalWS_perObjectData.w * -2 + 3;
        packedNormalWS_perObjectData.w = packedNormalWS_perObjectData.w * packedNormalWS_perObjectData.w;
        packedNormalWS_perObjectData.w = normal.x * packedNormalWS_perObjectData.w;
        packedNormalWS_perObjectData.w = min(1, packedNormalWS_perObjectData.w);
        normal.x = dot(cb1[263].xyz, float3(0.300000012,0.589999974,0.109999999));
        float3 smjb = cb1[263].xyz + -normal.xxx;
        normal.xyz = smjb * float3(0.75,0.75,0.75) + normal.xxx;
        customData.xyz = cb1[263].xyz + -normal.xyz;
        normal.xyz = checkerboardPattern * customData.xyz + normal.xyz;
        normal.xyz = normal.xyz * perObjectData;
        normal.xyz = float3(0.100000001,0.100000001,0.100000001) * normal.xyz;
        customData.xyz = float3(1,1,1) + albedo_alpha.xyz;
        customData.xyz = customData.xyz * normal.xyz;
        model13_14_15.xyw = albedo_alpha.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
        model13_14_15.xyw = saturate(-model13_14_15.xyw);
        r6.xyz = model13_14_15.xyw * float3(-2,-2,-2) + float3(3,3,3);
        model13_14_15.xyw = model13_14_15.xyw * model13_14_15.xyw;
        model13_14_15.xyw = r6.xyz * model13_14_15.xyw;
        model13_14_15.xyw = model13_14_15.xyw * float3(14,14,14) + float3(1,1,1);
        normal.xyz = model13_14_15.xyw * normal.xyz;
        normal.xyz = normal.xyz * albedo_alpha.xyz + -customData.xyz;
        normal.xyz = cb1[260].zzz * normal.xyz + customData.xyz;
        normal.xyz = normal.xyz * packedNormalWS_perObjectData.www;
        perObjectData = -10000 + depth;
        perObjectData = max(0, perObjectData);
        perObjectData = min(5000, perObjectData);
        perObjectData = 5000 + -perObjectData;
        perObjectData = 0.000199999995 * perObjectData;
        normal.xyz = perObjectData * normal.xyz;
        normal.xyz = cb0[1].xyz * normal.xyz;
    } else {
        normal.xyz = float3(0,0,0);
    }
    perObjectData = (0 != isCharaAnisotropicFabric15) ? 1.0 : 0.0;
    albedo_alpha.xyz = model_low4_high4.yzw * msrSq;
    albedo_alpha.xyz = cb1[263].xyz * albedo_alpha.xyz;
    albedo_alpha.xyz = albedo_alpha.xyz * float3(0.5,0.5,0.5) + -model_low4_high4.yzw;
    albedo_alpha.xyz = packedNormalWS_perObjectData.www * albedo_alpha.xyz + model_low4_high4.yzw;
    normal.xyz = model_low4_high4.yzw + normal.xyz;
    normal.xyz = perObjectData ? albedo_alpha.xyz : normal.xyz;
    packedNormalWS_perObjectData.xzw = isModel_5_13.y ? model_low4_high4.yzw : normal.xyz;
    packedNormalWS_perObjectData.xyz = packedNormalWS_perObjectData.xzw / light_intensity;
    packedNormalWS_perObjectData.xyz = min(float3(0,0,0), -packedNormalWS_perObjectData.xyz);
    color.xyz = -packedNormalWS_perObjectData.xyz;
    return color;
}
            ENDHLSL
        }
    }
}