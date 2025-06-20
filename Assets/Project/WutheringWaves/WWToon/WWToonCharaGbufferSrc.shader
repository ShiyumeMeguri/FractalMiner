Shader "Custom/WWToonCharaGBufferSrc"
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
        Tags
        {
            "Queue" = "Geometry+1000"
        }
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
            
            // 给AI的说明 我已经在这里给出的输出的准确含义 基于这个分析
            TEXTURE2D(_IN0); SAMPLER(sampler_IN0); // XY法线 Z金属度 W不清楚
            TEXTURE2D(_IN1); SAMPLER(sampler_IN1); // 也是一堆mask 
            TEXTURE2D(_IN2); SAMPLER(sampler_IN2); // BaseColor A通道是mask
            TEXTURE2D(_IN3); SAMPLER(sampler_IN3); // Matcap
            TEXTURE2D(_IN4); SAMPLER(sampler_IN4); // Ramp SSS模拟用
            // _IN5 到 _IN9 虽然在Properties中定义，但未在代码中使用

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
            
            Varyings vert (Attributes IN)
            {
                Varyings fragOutput;
                fragOutput.positionCS = TransformObjectToHClip(IN.positionOS.xyz);
                fragOutput.uv.xy = IN.uv;
                float2 ndc = fragOutput.positionCS.xy / fragOutput.positionCS.w;
                fragOutput.uv.zw = ndc;
                return fragOutput;
            }
            
            StructuredBuffer<float4> cb0;
            StructuredBuffer<float4> cb1;
            StructuredBuffer<float4> cb2;
            StructuredBuffer<float4> cb3;
            StructuredBuffer<float4> cb4;
            
            // 给AI的说明 我已经在这里给出的输出的准确含义 基于这个分析
            struct FragOutput
            {
                float4 o0_GI : SV_Target0;
                float4 o1_Normal_Diffuse_FaceSDFMask : SV_Target1;
                float4 o2_ShadowColor_PackShadeMode_OutputMask : SV_Target2;
                float4 o3_BaseColor_ToonSkinMask : SV_Target3;
                float4 o4 : SV_Target4; // 不知道干嘛的
                float4 o5_RimDepth : SV_Target5;
                float4 o6_rimStrength_HSVPack_groundSpec_charRegion : SV_Target6;
            };

FragOutput frag (Varyings fragmentInput)
{
    // 根据反编译代码输入调整输入结构
    float4 v0 = fragmentInput.uv; // 您的指定映射
    float4 v9 = fragmentInput.positionCS; // SV_Position -> v9
    float4 v2 = fragmentInput.uv; // TEXCOORD0 -> v2

    // 为缺失的、但在代码中使用的输入变量提供定义以修复语法错误
    float4 v1 = 0;
    float4 v6 = 0;
    float2 v7 = 0;
    float4 v8 = 0;
    
    // 声明输出结构和内部变量
    FragOutput fragOutput = (FragOutput)0;
    float4 o0_GI, o1_Normal_Diffuse_FaceSDFMask, o2_ShadowColor_PackShadeMode_OutputMask, o3_BaseColor_ToonSkinMask, o4, o5_RimDepth, o6_rimStrength_HSVPack_groundSpec_charRegion;
    float4 r0,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12;
    uint4 bitmask, uiDest;
    float4 fDest;

// ---- 移植自反编译代码 ----

  r0.xyz = v1.zxy * v0.yzx;
  r0.xyz = v1.yzx * v0.zxy + -r0.xyz;
  r0.xyz = v1.www * r0.xyz;
  r1.xyzw = cb0[45].xyzw * v9.yyyy;
  r1.xyzw = v9.xxxx * cb0[44].xyzw + r1.xyzw;
  r1.xyzw = v9.zzzz * cb0[46].xyzw + r1.xyzw;
  r1.xyzw = cb0[47].xyzw + r1.xyzw;
  r1.xyz = r1.xyz / r1.www;
  r0.w = dot(-r1.xyz, -r1.xyz);
  r0.w = rsqrt(r0.w);
  r2.xyz = -r1.xyz * r0.www;
  r3.xyzw = _IN0.SampleBias(sampler_IN0, v2.xy, cb0[149].y).xyzw;
  r3.xy = r3.xy * float2(2,2) + float2(-1,-1);
  r3.xy = cb4[64].ww * r3.xy;
  r0.xyz = r3.yyy * r0.xyz;
  r0.xyz = r3.xxx * v0.xyz + r0.xyz;
  r0.xyz = v1.xyz + r0.xyz;
  r1.w = 1 + -cb0[144].w;
  r4.xyz = v1.xyz * r1.www;
  r0.xyz = r0.xyz * cb0[144].www + r4.xyz;
  r1.w = dot(r0.xyz, r0.xyz);
  r1.w = rsqrt(r1.w);
  r0.xyz = r1.www * r0.xyz;
  r3.xy = _IN1.SampleLevel(sampler_IN1, v2.xy, cb0[149].y).xy;
  r4.xyzw = (r3.xxxx >= float4(0.0500000007,0.300000012,0.5,0.899999976));
  r4.xyzw = r4.xyzw ? float4(1,1,1,1) : 0;
  r5.xyzw = (float4(0.0500000007,0.300000012,0.5,0.899999976) >= r3.xxxx);
  r5.yzw = r5.yzw ? float3(1,1,1) : 0;
  r4.yz = r5.zw * r4.yz;
  r1.w = -r4.x * r5.y + 1;
  r1.w = r5.x ? 1 : r1.w;
  r1.w = -r4.y * r1.w + 1;
  r2.w = r4.z * r1.w;
  r1.w = -r4.z * r1.w + 1;
  r1.w = r4.w * r1.w;
  r3.x = (cb4[65].y >= 0.5);
  r1.w = r3.x ? r1.w : cb4[65].x;
  r3.x = 1 + -r1.w;
  r1.w = cb4[65].z * r3.x + r1.w;
  r4.xyz = float3(-1,-1,-1) + cb4[4].xyz;
  r4.xyz = r1.www * r4.xyz + float3(1,1,1);
  r5.xyzw = _IN2.SampleBias(sampler_IN2, v2.xy, cb0[149].y).xyzw;
  r5.xyz = cb4[6].xyz * r5.xyz;
  r6.xyz = r5.xyz * r4.xyz;
  r3.x = cb4[65].w * r3.z;
  r3.z = cb4[66].x * r3.w;
  r4.w = saturate(dot(r0.xyz, r2.xyz));
  r6.w = (2.98023295e-008 >= r3.z);
  r7.x = log2(r3.z);
  r7.x = 0.100000001 * r7.x;
  r7.x = exp2(r7.x);
  r6.w = r6.w ? 0 : r7.x;
  r7.x = 1 + -r6.w;
  r7.x = r7.x * 19.8999996 + 0.100000001;
  r6.w = r6.w * -999 + 1000;
  r7.y = (r3.x >= 0.850000024);
  r7.y = r7.y ? 1.000000 : 0;
  r7.z = cb4[66].y + -cb4[66].z;
  r7.z = r7.y * r7.z + cb4[66].z;
  r8.xyz = -cb3[36].xyz + cb3[17].xyz;
  r8.xyz = cb4[67].yyy * r8.xyz;
  r7.w = (cb4[66].w >= 0.5);
  r7.w = r7.w ? 1.000000 : 0;
  r8.xyz = r7.www * r8.xyz + cb3[36].xyz;
  r7.w = dot(r8.xyz, r8.xyz);
  r7.w = sqrt(r7.w);
  r8.xyz = r8.xyz / r7.www;
  r9.xyz = cb4[8].xyz + cb2[5].xyz;
  r10.xyz = cb1[0].xyz + -r9.xyz;
  r7.w = dot(r10.xyz, r10.xyz);
  r7.w = sqrt(r7.w);
  r10.xyz = r10.xyz / r7.www;
  r9.xyz = -cb1[0].xyz + r9.xyz;
  r7.w = dot(r9.xyz, r9.xyz);
  r7.w = sqrt(r7.w);
  r7.w = saturate(cb1[0].w * r7.w);
  r9.xyz = -r10.xyz + r8.xyz;
  r9.xyz = r7.www * r9.xyz + r10.xyz;
  r9.xyz = r9.xyz + -r8.xyz;
  r8.xyz = cb1[1].zzz * r9.xyz + r8.xyz;
  r7.w = saturate(cb2[27].y);
  r9.xy = v6.xy;
  r9.z = v7.x;
  r9.xyz = r9.xyz + -r8.xyz;
  r8.xyz = r7.www * r9.xyz + r8.xyz;
  r7.w = dot(r8.xyz, r8.xyz);
  r7.w = sqrt(r7.w);
  r8.xyz = r8.xyz / r7.www;
  r2.x = dot(r8.xyz, r2.xyz);
  r2.y = 1 + -abs(r2.z);
  r2.x = r2.x * r2.y + 1;
  r2.x = 0.5 * r2.x;
  r2.y = -cb4[68].x + cb4[67].w;
  r2.x = r2.x * r2.y + cb4[68].x;
  r2.y = 1 + -r4.w;
  r2.x = r2.x * r2.y + cb4[68].y;
  r2.y = -cb4[68].z + r2.x;
  r2.z = cb4[68].z + r2.x;
  r4.w = cb4[68].w * r5.w;
  r5.w = max(0, r4.w);
  r5.w = min(cb4[69].x, r5.w);
  r5.w = r5.w / cb4[69].x;
  r7.w = max(cb4[69].y, r4.w);
  r7.w = min(1, r7.w);
  r7.w = -cb4[69].y + r7.w;
  r9.xy = float2(1,1) + -cb4[69].yz;
  r7.w = r7.w / r9.x;
  r8.w = -cb4[69].z + r5.w;
  r9.x = 1 / r9.y;
  r8.w = saturate(r9.x * r8.w);
  r9.x = r8.w * -2 + 3;
  r8.w = r8.w * r8.w;
  r8.w = r9.x * r8.w;
  r8.w = cb4[69].w * r8.w;
  r9.x = (2.98023295e-008 >= r8.w);
  r8.w = log2(r8.w);
  r8.w = cb4[70].x * r8.w;
  r8.w = exp2(r8.w);
  r8.w = cb4[70].y * r8.w;
  r8.w = r9.x ? 0 : r8.w;
  r9.x = dot(r0.xyz, r8.xyz);
  r8.w = r9.x * 0.5 + r8.w;
  r8.w = 0.5 + r8.w;
  r2.z = r2.z + -r2.y;
  r2.y = r8.w + -r2.y;
  r2.z = 1 / r2.z;
  r2.y = saturate(r2.y * r2.z);
  r2.z = r2.y * -2 + 3;
  r2.y = r2.y * r2.y;
  r2.y = r2.z * r2.y;
  r2.z = min(cb4[69].z, r5.w);
  r2.z = r2.z / cb4[70].z;
  r5.w = max(0.899999976, r2.z);
  r5.w = min(1, r5.w);
  r5.w = -0.899999976 + r5.w;
  r2.y = r5.w * r2.y;
  r5.w = (r2.y >= 0.0400000066);
  r9.x = r5.w ? 1.000000 : 0;
  r9.yzw = r9.xxx * r8.xyz;
  r9.yzw = float3(2,2,0) * r9.yzw;
  r9.yzw = r8.xyz * float3(-1,-1,1) + r9.yzw;
  r9.yzw = -r1.xyz * r0.www + r9.yzw;
  r10.x = dot(r9.yzw, r9.yzw);
  r10.x = sqrt(r10.x);
  r9.yzw = r9.yzw / r10.xxx;
  r9.y = saturate(dot(r9.yzw, r0.xyz));
  r8.xyz = -r1.xyz * r0.www + r8.xyz;
  r0.w = dot(r8.xyz, r8.xyz);
  r0.w = sqrt(r0.w);
  r8.xyz = r8.xyz / r0.www;
  r0.w = saturate(dot(r0.xyz, r8.xyz));
  r0.w = r0.w + -r9.y;
  r0.w = r7.y * r0.w + r9.y;
  r0.w = log2(r0.w);
  r0.w = r6.w * r0.w;
  r0.w = exp2(r0.w);
  r0.w = r0.w * r7.z;
  r6.w = 2 + r7.z;
  r0.w = r6.w * r0.w;
  r0.w = r0.w * 0.159154937 + -0.600000024;
  r0.w = saturate(0.833333373 * r0.w);
  r6.w = r0.w * -2 + 3;
  r0.w = r0.w * r0.w;
  r0.w = r6.w * r0.w;
  r0.w = r7.x * r0.w;
  r6.w = r3.x * 0.5 + 0.5;
  r8.xyz = r6.xyz * r3.xxx;
  r6.w = 0.0799999982 * r6.w;
  r9.yzw = r4.xyz * r5.xyz + -r6.www;
  r9.yzw = r3.xxx * r9.yzw + r6.www;
  r10.xyzw = r3.zzzz * float4(-1,-0.0274999999,-0.572000027,0.0219999999) + float4(1,0.0425000004,1.03999996,-0.0399999991);
  r3.x = r10.x * r10.x;
  r3.x = min(0.00160857651, r3.x);
  r3.x = r3.x * r10.x + r10.y;
  r7.xz = r3.xx * float2(-1.03999996,1.03999996) + r10.zw;
  r3.x = saturate(50 * r9.z);
  r3.x = r7.z * r3.x;
  r10.xyz = r9.yzw * r7.xxx + r3.xxx;
  r9.yzw = cb4[71].xxx * r9.yzw;
  r11.xyz = r9.yzw * r0.www;
  r10.xyz = cb4[71].xxx * r10.xyz;
  r8.xyz = cb4[71].xxx * -r8.xyz + r6.xyz;
  r11.xyz = r11.xyz * r7.yyy;
  r11.xyz = cb4[71].yyy * r11.xyz;
  r2.w = max(r1.w, r2.w);
  r2.w = 1 + -r2.w;
  r3.x = -r3.w * cb4[66].x + 1;
  r3.x = (r3.x >= 0.00999999978);
  r3.x = r3.x ? 1.000000 : 0;
  r2.w = r3.x * r2.w;
  r7.xzw = r7.www * r6.xyz;
  r7.xzw = cb4[10].xyz * r7.xzw;
  r7.xzw = r2.www * r11.xyz + r7.xzw;
  r7.xzw = v7.yyy * cb4[45].xyz + r7.xzw;
  r11.xyz = cb4[46].xyz + -r7.xzw;
  r7.xzw = cb4[83].yyy * r11.xyz + r7.xzw;
  r8.xyz = r9.yzw * r0.www + r8.xyz;
  r11.xyzw = cb0[13].yzzx * r1.yyyy;
  r11.xyzw = r1.xxxx * cb0[12].yzzx + r11.xyzw;
  r11.xyzw = r1.zzzz * cb0[14].yzzx + r11.xyzw;
  r11.xyzw = cb0[15].yzzx + r11.xyzw;
  r0.w = dot(r11.xzw, r11.xzw);
  r0.w = sqrt(r0.w);
  r11.xyzw = r11.xyzw / r0.wwww;
  r12.xyzw = cb0[13].zxyz * r0.yyyy;
  r12.xyzw = r0.xxxx * cb0[12].zxyz + r12.xyzw;
  r12.xyzw = r0.zzzz * cb0[14].zxyz + r12.xyzw;
  r3.xw = r12.zw * r11.zw;
  r3.xw = r11.yx * r12.yx + -r3.wx;
  r3.xw = r3.xw * float2(0.5,0.5) + float2(0.5,0.5);
  r11.xyzw = _IN3.SampleBias(sampler_IN3, r3.xw, cb0[149].y).xyzw;
  r0.w = 3 * r3.z;
  r0.w = saturate(r0.w);
  r3.x = r11.y + -r11.x;
  r0.w = r0.w * r3.x + r11.x;
  r3.xz = saturate(r3.zz * float2(3,3) + float2(-1,-2));
  r3.w = r11.z + -r0.w;
  r0.w = r3.x * r3.w + r0.w;
  r3.x = r11.w + -r0.w;
  r0.w = r3.z * r3.x + r0.w;
  r3.x = cb4[83].z + -cb4[83].w;
  r3.x = r7.y * r3.x + cb4[83].w;
  r3.z = r5.w ? 0 : 1;
  r3.w = r3.x * r3.z;
  r5.w = cb4[84].x + -cb4[83].w;
  r5.w = r7.y * r5.w + cb4[83].w;
  r3.x = -r3.x * r3.z + r5.w;
  r3.x = r9.x * r3.x + r3.w;
  r0.w = r3.x * r0.w;
  r3.xzw = r10.xyz * r0.www + r8.xyz;
  r3.xzw = -r4.xyz * r5.xyz + r3.xzw;
  r3.xzw = r2.www * r3.xzw + r6.xyz;
  r4.xyz = cb4[84].zzz * r3.xzw;
  r0.w = max(0, r8.w);
  r0.w = min(cb4[85].z, r0.w);
  r2.w = r8.w + -r0.w;
  r0.w = r2.z * r2.w + r0.w;
  r0.w = 0.5 + r0.w;
  r5.x = saturate(r0.w + -r2.x);
  r0.w = 0.100000001 + -cb4[85].w;
  r5.y = r1.w * r0.w + cb4[85].w;
  r5.xyz = _IN4.SampleBias(sampler_IN4, r5.xy, cb0[149].y).xyz;
  r0.w = (cb3[1].w >= 0.0500000007);
  r0.w = r0.w ? 1.000000 : 0;
  r0.w = r3.y * r0.w;
  r3.xyz = -cb4[84].zzz * r3.xzw + r5.xyz;
  r6.xyz = r4.xyz + r4.xyz;
  r3.xyz = r0.www * r3.xyz + r6.xyz;
  r3.xyz = r3.xyz * float3(0.5,0.5,0.5) + -r4.xyz;
  r3.xyz = r1.www * r3.xyz + r4.xyz;
  r2.x = dot(r3.xyz, float3(0.300000012,0.589999974,0.109999999));
  r4.xyz = r2.xxx + -r3.xyz;
  o3_BaseColor_ToonSkinMask.xyz = cb4[86].xxx * r4.xyz + r3.xyz;
  r3.xyz = -cb4[62].xyz + cb4[61].xyz;
  r3.xyz = r1.www * r3.xyz + cb4[62].xyz;
  r4.xyz = r5.xyz + -r3.xyz;
  r3.xyz = r0.www * r4.xyz + r3.xyz;
  r0.w = dot(r3.xyz, float3(0.300000012,0.589999974,0.109999999));
  r4.xyz = r0.www + -r3.xyz;
  r3.xyz = cb4[86].xxx * r4.xyz + r3.xyz;
  r0.w = 1 + -r2.z;
  r0.w = -r0.w * cb4[94].y + 1;
  r2.x = r2.y * 4.99999905 + 0.5;
  r0.w = r2.x * r0.w;
  r2.x = asint(cb2[26].w) & 1;
  r2.x = (0 < (uint)r2.x);
  r2.y = (asint(cb0[160].x) != 0);
  r2.x = (int)r2.y | (int)r2.x;
  if (r2.x != 0) {
    r2.xy = -cb0[134].xy + v9.xy;
    r2.xy = r2.xy * cb0[135].zw + float2(-0.5,-0.5);
    r2.xy = v9.ww * r2.xy;
    r2.zw = v9.zw;
    r5.xyw = float3(2,-2,1);
    r5.z = v9.w;
    r2.xyzw = r5.xyzw * r2.xyzw;
    r2.xyz = r2.zxy / r2.www;
    r2.yz = -cb0[131].xy + r2.yz;
    r4.xyz = v8.zxy / v8.www;
    r4.yz = -cb0[131].zw + r4.yz;
    r2.xyz = -r4.xyz + r2.xyz;
    r5.xy = r2.yz * float2(0.249500006,0.249500006) + float2(0.499992371,0.499992371);
    r2.y = (uint)r2.x >> 16;
    r2.y = (uint)r2.y;
    r2.y = r2.y * 1.52590219e-005 + 1.52590223e-006;
    r2.x = (int)r2.x & 0x0000ffff;
    r2.x = (uint)r2.x;
    r2.x = r2.x * 1.52590219e-005 + 1.52590223e-006;
    r5.zw = min(float2(1,1), r2.yx);
    r2.x = (cb2[20].w == 0.000000);
    r2.y = (asint(cb0[160].x) == 0);
    r2.x = r2.y ? r2.x : 0;
    o4.xyzw = r2.xxxx ? float4(0,0,0,0) : r5.xyzw;
  } else {
    o4.xyzw = float4(0,0,0,0);
  }
  r2.xyz = max(float3(0,0,0), r7.xzw);
  r2.w = (0 < cb0[146].x);
  if (r2.w != 0) {
    r1.xyz = -cb0[70].xyz + r1.xyz;
    r4.xyz = -cb2[5].xyz + r1.xyz;
    r5.xyz = float3(1,1,1) + cb2[19].xyz;
    r4.xyz = (r5.xyz < abs(r4.xyz));
    r2.w = (int)r4.y | (int)r4.x;
    r2.w = (int)r4.z | (int)r2.w;
    r1.x = dot(r1.xyz, float3(0.577000022,0.577000022,0.577000022));
    r1.x = 0.00200000009 * r1.x;
    r1.x = frac(r1.x);
    r1.x = (0.5 < r1.x);
    r1.xyz = r1.xxx ? float3(0,1,1) : float3(1,1,0);
    r2.xyz = r2.www ? r1.xyz : r2.xyz;
  }
  r1.x = (asint(cb0[249].x) == 1);
  if (r1.x != 0) {
    r1.x = dot(float3(1,1,1), abs(r0.xyz));
    r1.xy = r0.xy / r1.xx;
    r4.xy = float2(1,1) + -abs(r1.yx);
    r5.xy = (r1.xy >= float2(0,0));
    r5.xy = r5.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
    r4.xy = r5.xy * r4.xy;
    r1.z = (0 >= r0.z);
    r1.z = r1.z ? 1.000000 : 0;
    r4.xy = r4.xy * float2(2,2) + -r1.xy;
    r1.xy = r1.zz * r4.xy + r1.xy;
    o1_Normal_Diffuse_FaceSDFMask.xy = r1.xy * float2(0.5,0.5) + float2(0.5,0.5);
    r3.xyz = saturate(r3.xyz);
    o2_ShadowColor_PackShadeMode_OutputMask.xyz = sqrt(r3.xyz);
    bitmask.x = ((~(-1 << 3)) << 5) & 0xffffffff;  r1.x = (((uint)cb2[23].w << 5) & bitmask.x) | ((uint)12 & ~bitmask.x);
    r1.x = (uint)r1.x;
    o2_ShadowColor_PackShadeMode_OutputMask.w = 0.00392156886 * r1.x;
    o1_Normal_Diffuse_FaceSDFMask.z = 1;
    o1_Normal_Diffuse_FaceSDFMask.w = r0.w;
    o4.xyzw = float4(0,0,0,0);
    r1.xy = float2(0,0);
    o3_BaseColor_ToonSkinMask.w = cb4[94].z;
  } else {
    r1.z = (r1.w >= 0.5);
    o1_Normal_Diffuse_FaceSDFMask.w = r1.z ? 0.666000 : 0;
    r1.z = saturate(cb4[94].w);
    r1.z = 255 * r1.z;
    r1.z = round(r1.z);
    r1.w = saturate(cb4[95].x);
    r1.w = 15 * r1.w;
    r1.w = round(r1.w);
    r1.zw = (uint2)r1.zw;
    bitmask.z = ((~(-1 << 4)) << 0) & 0xffffffff;  r1.z = (((uint)r1.w << 0) & bitmask.z) | ((uint)r1.z & ~bitmask.z);
    r1.z = (uint)r1.z;
    r1.y = 0.00392156886 * r1.z;
    r1.z = dot(float3(1,1,1), abs(r0.xyz));
    r0.xy = r0.xy / r1.zz;
    r1.zw = float2(1,1) + -abs(r0.yx);
    r4.xy = (r0.xy >= float2(0,0));
    r4.xy = r4.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
    r1.zw = r4.xy * r1.zw;
    r0.z = (0 >= r0.z);
    r0.z = r0.z ? 1.000000 : 0;
    r1.zw = r1.zw * float2(2,2) + -r0.xy;
    r0.xy = r0.zz * r1.zw + r0.xy;
    o1_Normal_Diffuse_FaceSDFMask.xy = r0.xy * float2(0.5,0.5) + float2(0.5,0.5);
    r3.xyz = saturate(r3.xyz);
    o2_ShadowColor_PackShadeMode_OutputMask.xyz = sqrt(r3.xyz);
    bitmask.x = ((~(-1 << 3)) << 5) & 0xffffffff;  r0.x = (((uint)cb2[23].w << 5) & bitmask.x) | ((uint)12 & ~bitmask.x);
    r0.x = (uint)r0.x;
    o2_ShadowColor_PackShadeMode_OutputMask.w = 0.00392156886 * r0.x;
    o1_Normal_Diffuse_FaceSDFMask.z = r0.w;
    r1.x = cb4[94].z;
    o3_BaseColor_ToonSkinMask.w = r4.w;
  }
  o0_GI.xyz = r2.xyz;
  o0_GI.w = 0;
  o5_RimDepth.xyzw = v9.zzzz;
  o6_rimStrength_HSVPack_groundSpec_charRegion.xy = r1.xy;
  o6_rimStrength_HSVPack_groundSpec_charRegion.zw = float2(0,0);

  fragOutput.o0_GI = o2_ShadowColor_PackShadeMode_OutputMask;
  return fragOutput;

  // 由于这是测试因此没用MRT 只能改o0预览正确性 即使这里错误也不用管
  fragOutput.o0_GI = o0_GI;
  fragOutput.o1_Normal_Diffuse_FaceSDFMask = o1_Normal_Diffuse_FaceSDFMask;
  fragOutput.o2_ShadowColor_PackShadeMode_OutputMask = o2_ShadowColor_PackShadeMode_OutputMask;
  fragOutput.o3_BaseColor_ToonSkinMask = o3_BaseColor_ToonSkinMask;
  fragOutput.o4 = o4;
  fragOutput.o5_RimDepth = o5_RimDepth;
  fragOutput.o6_rimStrength_HSVPack_groundSpec_charRegion = o6_rimStrength_HSVPack_groundSpec_charRegion;
  
  return fragOutput;
}
            ENDHLSL
        }
    }
}