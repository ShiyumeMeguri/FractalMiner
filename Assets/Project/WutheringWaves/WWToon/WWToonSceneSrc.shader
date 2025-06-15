Shader "Custom/WWToonSceneSrc"
{
    Properties
    {
        // Properties block is unchanged as requested
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
    float4 positionOS   : POSITION;
    float2 uv           : TEXCOORD0;
};

struct Varyings
{
    float4 positionCS   : SV_POSITION;
    // v0 (uv.xy) 和 v2 (positionCS.xy) 都从这里获取
    // 增加 noperspective 确保与原始 dcl_input_ps_siv linear noperspective v2.xy, position 一致
    noperspective float4 uv : TEXCOORD0; // uv.xy = 原始 UV, uv.zw = NDC.xy
    float3 color        : TEXCOORD1;    // v1.xyz
};

// ------------------------------------------------------------
// 纹理和采样器定义 (t0-t9, s0-s2)
// ------------------------------------------------------------
// 对应 t0-t9
            
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
// 对应 cb0, cb1, cb2
StructuredBuffer<float4> cb0;
StructuredBuffer<float4> cb1;
StructuredBuffer<float4> cb2;

// 全局变量，保持不变
float4 _FrameJitterSeed;
float3 _GradientX;
float3 _GradientY;
float3 _ColorOffset;


// ------------------------------------------------------------
//  Vertex Shader (保持原样)
// ------------------------------------------------------------
Varyings vert (Attributes IN)
{
    Varyings OUT;

    float2 clip = IN.uv * 2.0 - 1.0;
    clip.y = -clip.y;
                // 1. 使用 URP 的标准函数进行变换
                OUT.positionCS = TransformObjectToHClip(IN.positionOS.xyz);
                
                // 2. 传递 UV 坐标
                OUT.uv.xy = IN.uv;

                // 3. 计算 NDC 并传递
                // 逻辑完全相同：用裁剪空间坐标的 xy 除以 w
                float2 ndc = OUT.positionCS.xy / OUT.positionCS.w;
                OUT.uv.zw = ndc;
                
    
    // v1.xyz 的数据源
    OUT.color = clip.x* clip.y;

    return OUT;
}
            
float4 frag (Varyings fragmentInput) : SV_Target
{
// 3Dmigoto declarations - adapted for Unity
#define cmp(x) (-(x))

  // Map decompiled inputs to Unity's v2f struct
  float4 v0 = fragmentInput.uv;
  float3 v1 = fragmentInput.color;
  float4 v2 = fragmentInput.positionCS;
  float4 o0; // Output variable

  float4 r0,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20;
  uint4 bitmask, uiDest;
  float4 fDest;

  r0.xyz = tex2D(_IN2, v0.xy).xyz;
  r1.xyzw = tex2D(_IN3, v0.xy).xyzw;
  r2.xyzw = tex2D(_IN4, v0.xy).wxyz;
  r3.xyzw = tex2D(_IN5, v0.xy).xyzw;
  r0.w = tex2D(_IN1, v0.xy).x;
  r4.x = r0.w * cb0[65].x + cb0[65].y;
  r0.w = r0.w * cb0[65].z + -cb0[65].w;
  r0.w = 1 / r0.w;
  r4.x = r4.x + r0.w;
  r0.w = 255 * r1.w;
  r0.w = round(r0.w);
  r0.w = (uint)r0.w;
  r1.w = (int)r0.w & 15;
  r5.x = cmp((int)r1.w != 12);
  r5.yzw = cmp((int3)r1.www == int3(13,14,15));
  r5.z = (int)r5.w | (int)r5.z;
  r5.z = (int)r5.z | (int)r5.y;
  r5.x = r5.x ? r5.z : -1;
  if (r5.x != 0) {
    r1.w = r5.y ? 13 : 12;
    r5.xy = r0.xy * float2(2,2) + float2(-1,-1);
    r5.z = dot(float2(1,1), abs(r5.xy));
    r6.z = 1 + -r5.z;
    r5.z = max(0, -r6.z);
    r7.xy = cmp(r5.xy >= float2(0,0));
    r7.xy = r7.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
    r5.zw = r7.xy * r5.zz;
    r6.xy = r5.zw * float2(-2,-2) + r5.xy;
    r5.x = dot(r6.xyz, r6.xyz);
    r5.x = rsqrt(r5.x);
    r5.xyz = r6.xyz * r5.xxx;
    r5.w = r4.x;
    r6.x = 0;
    r7.xw = float2(0,1);
    r2.x = 1;
    r8.x = r3.x;
  } else {
    r6.y = cmp((int)r1.w == 10);
    r9.xyz = saturate(r1.xyz);
    r9.xyz = float3(16777215,65535,255) * r9.xyz;
    r9.xyz = round(r9.xyz);
    r9.xyz = (uint3)r9.xyz;
    bitmask.z = ((~(-1 << 8)) << 0) & 0xffffffff;  r6.z = (((uint)r9.z << 0) & bitmask.z) | ((uint)r9.y & ~bitmask.z);
    bitmask.z = ((~(-1 << 16)) << 0) & 0xffffffff;  r6.z = (((uint)r6.z << 0) & bitmask.z) | ((uint)r9.x & ~bitmask.z);
    r6.z = (uint)r6.z;
    r6.z = 5.96046519e-008 * r6.z;
    r6.w = r6.z * cb0[65].x + cb0[65].y;
    r6.z = r6.z * cb0[65].z + -cb0[65].w;
    r6.z = 1 / r6.z;
    r9.x = r6.w + r6.z;
    r9.yzw = float3(0.100000001,0.224999994,0.0199999996);
    r4.yzw = r1.xyz;
    r7.xyzw = r6.yyyy ? r9.zxyw : r4.zxyw;
    r5.xyz = r0.xyz * float3(2,2,2) + float3(-1,-1,-1);
    r5.w = r7.y;
    r6.x = r7.z;
    r8.x = 0;
  }
  r0.x = cmp((int)r1.w != 12);
  r4.yzw = cmp((int3)r1.www == int3(13,14,15));
  r0.y = (int)r4.w | (int)r4.z;
  r0.y = (int)r0.y | (int)r4.y;
  r0.x = r0.x ? r0.y : -1;
  if (r0.x != 0) {
    return float4(0,0,0,0);
  }
  if (r1.w != 0) {
    r0.x = tex2D(_IN6, v0.xy).w;
    r0.yz = cb0[138].xy * v0.xy;
    r0.yz = (uint2)r0.yz;
    r1.x = (uint)cb0[158].x;
    r0.y = (int)r0.z + (int)r0.y;
    r0.y = (int)r1.x + (int)r0.y;
    r0.y = (int)r0.y & 1;
    r0.z = dot(r5.xyz, r5.xyz);
    r0.z = rsqrt(r0.z);
    r4.yzw = r5.xyz * r0.zzz;
    r9.xyzw = cmp((int4)r1.wwww == int4(2,4,5,6));
    r0.z = (int)r9.y | (int)r9.x;
    r0.z = (int)r9.z | (int)r0.z;
    r0.z = (int)r9.w | (int)r0.z;
    r5.xyz = cmp((int3)r1.www == int3(7,10,1));
    r0.z = (int)r0.z | (int)r5.x;
    r0.z = (int)r5.y | (int)r0.z;
    r10.xyzw = (int4)r3.xyzw & (int4)r0.zzzz;
    r8.yz = float2(1,0.5);
    r7.yz = r5.zz ? r3.zw : r8.xy;
    r8.w = r1.y;
    r8.xw = r9.xx ? r8.wz : r7.zx;
    r1.x = r9.y ? r3.w : r8.x;
    r3.yz = (int2)r5.xz | (int2)r9.wy;
    r0.z = r3.y ? 0 : r6.x;
    r3.w = 0.0799999982 * r8.w;
    r6.yzw = -r8.www * float3(0.0799999982,0.0799999982,0.0799999982) + r2.yzw;
    r8.xyz = r0.zzz * r6.yzw + r3.www;
    r3.w = cmp(0 < cb0[162].y);
    r5.y = cmp(0 < cb0[220].z);
    r3.w = r3.w ? r5.y : 0;
    r5.y = cmp(0 != cb0[162].y);
    r6.yzw = r5.yyy ? float3(1,1,1) : r2.yzw;
    r7.xz = r0.yy ? float2(1,0) : float2(0,1);
    r11.xyzw = r8.xyzw * r7.zzzz;
    r12.xyz = r3.www ? r7.xxx : r6.yzw;
    r11.xyzw = r3.wwww ? r11.xyzw : r8.xyzw;
    r6.yzw = r9.zzz ? r11.xyz : r8.xyz;
    r12.w = r11.w;
    r8.xyz = r2.yzw;
    r8.xyzw = r9.zzzz ? r12.xyzw : r8.xyzw;
    r2.yzw = -r8.xyz * r0.zzz + r8.xyz;
    r2.yzw = r2.yzw * cb0[142].www + cb0[142].xyz;
    r6.yzw = r6.yzw * cb0[143].www + cb0[143].xyz;
    r0.y = (int)r0.w & 16;
    r0.x = r0.x * 2 + -1;
    r0.x = r0.y ? r0.x : 0;
    r0.x = r3.y ? r1.z : r0.x;
    r0.w = tex2D(_IN7, v0.xy).x;
    r1.z = cmp(cb1[1].z < 0);
    r3.w = max(0.00100000005, cb1[17].w);
    r3.w = saturate(r4.x / r3.w);
    r3.w = 1 + -r3.w;
    r11.xyz = cb1[17].xyz + -cb1[6].xyz;
    r11.xyz = r3.www * r11.xyz + cb1[6].xyz;
    r12.xyz = v1.xyz * r4.xxx + cb0[67].xyz;
    r3.w = dot(v1.xyz, v1.xyz);
    r3.w = rsqrt(r3.w);
    r13.xyz = v1.xyz * r3.www;
    r3.w = asuint(cb0[150].y);
    r7.xz = r3.ww * float2(32.6650009,11.8149996) + v2.xy;
    r3.w = dot(r7.xz, float2(0.0671105608,0.00583714992));
    r3.w = frac(r3.w);
    r3.w = 52.9829178 * r3.w;
    r3.w = frac(r3.w);
    r14.xyz = tex2D(_IN8, v0.xy).xyz;
    r15.xyz = r14.xyz * r14.xyz;
    r5.y = cb0[37].y * r5.w;
    if (cb1[3].y != 0) {
      r7.x = saturate(r5.w * cb1[1].x + cb1[1].y);
      r7.x = r7.x * r7.x;
      r14.xy = -r14.xy * r14.xy + r0.ww;
      r7.xz = r7.xx * r14.xy + r15.xy;
      r7.xz = cb0[253].yy * r7.xz;
      r7.xz = r7.xz * r15.zz;
      r11.w = cmp(1 < asuint(cb1[3].y));
      r12.w = cmp(0 < abs(cb1[1].z));
      r11.w = r11.w ? r12.w : 0;
      r12.w = -cb1[2].z + r5.w;
      r13.w = max(0.100000001, cb1[2].w);
      r12.w = saturate(r12.w / r13.w);
      r13.w = abs(cb1[1].z) + -abs(cb1[1].w);
      r12.w = r12.w * r13.w + abs(cb1[1].w);
      r1.z = r1.z ? 1 : r5.y;
      r1.z = r12.w * r1.z;
      r1.z = r11.w ? r1.z : 0;
    } else {
      r7.x = r0.w;
      r7.z = 1;
      r1.z = 0;
    }
    r5.y = cmp(0 < r1.z);
    if (r5.y != 0) {
      r3.w = -0.5 + r3.w;
      r12.xyz = cb0[70].xyz + r12.xyz;
      r14.xyzw = cb0[1].xyzw * r12.yyyy;
      r14.xyzw = r12.xxxx * cb0[0].xyzw + r14.xyzw;
      r12.xyzw = r12.zzzz * cb0[2].xyzw + r14.xyzw;
      r12.xyzw = cb0[3].xyzw + r12.xyzw;
      r14.xyz = cb1[7].xyz * r1.zzz;
      r16.xyzw = cb0[1].xyzw * r14.yyyy;
      r16.xyzw = r14.xxxx * cb0[0].xyzw + r16.xyzw;
      r14.xyzw = r14.zzzz * cb0[2].xyzw + r16.xyzw;
      r14.xyzw = r14.xyzw + r12.xyzw;
      r15.xyw = r12.xyz / r12.www;
      r14.xyz = r14.xyz / r14.www;
      r14.xyz = r14.xyz + -r15.xyw;
      r15.xy = r15.xy * cb0[66].xy + cb0[66].wz;
      r14.xy = cb0[66].xy * r14.xy;
      r12.xy = r1.zz * cb0[30].zw + r12.zw;
      r5.y = r12.x / r12.y;
      r5.y = r5.y + -r15.w;
      r11.w = 0.25 * abs(r5.y);
      r12.xyzw = r3.wwww * float4(0.125,0.125,0.125,0.125) + float4(0.125,0.25,0.375,0.5);
      r16.xyz = r14.xyz * r12.xxx + r15.xyw;
      r13.w = tex2D(_IN1, r16.xy).x;
      r13.w = r16.z + -r13.w;
      r13.w = abs(r5.y) * 0.25 + r13.w;
      r13.w = cmp(abs(r13.w) < r11.w);
      r12.x = r13.w ? r12.x : -1;
      r16.xyz = r14.xyz * r12.yyy + r15.xyw;
      r13.w = tex2D(_IN1, r16.xy).x;
      r13.w = r16.z + -r13.w;
      r13.w = abs(r5.y) * 0.25 + r13.w;
      r13.w = cmp(abs(r13.w) < r11.w);
      r14.w = cmp(r12.x < 0);
      r13.w = r13.w ? r14.w : 0;
      r12.x = r13.w ? r12.y : r12.x;
      r16.xyz = r14.xyz * r12.zzz + r15.xyw;
      r12.y = tex2D(_IN1, r16.xy).x;
      r12.y = r16.z + -r12.y;
      r12.y = abs(r5.y) * 0.25 + r12.y;
      r12.y = cmp(abs(r12.y) < r11.w);
      r13.w = cmp(r12.x < 0);
      r12.y = r12.y ? r13.w : 0;
      r12.x = r12.y ? r12.z : r12.x;
      r16.xyz = r14.xyz * r12.www + r15.xyw;
      r12.y = tex2D(_IN1, r16.xy).x;
      r12.y = r16.z + -r12.y;
      r12.y = abs(r5.y) * 0.25 + r12.y;
      r12.y = cmp(abs(r12.y) < r11.w);
      r12.z = cmp(r12.x < 0);
      r12.y = r12.z ? r12.y : 0;
      r12.x = r12.y ? r12.w : r12.x;
      r16.xyzw = r3.wwww * float4(0.125,0.125,0.125,0.125) + float4(0.625,0.75,0.875,1);
      r12.yzw = r14.xyz * r16.xxx + r15.xyw;
      r3.w = tex2D(_IN1, r12.yz).x;
      r3.w = r12.w + -r3.w;
      r3.w = abs(r5.y) * 0.25 + r3.w;
      r3.w = cmp(abs(r3.w) < r11.w);
      r12.y = cmp(r12.x < 0);
      r3.w = r3.w ? r12.y : 0;
      r3.w = r3.w ? r16.x : r12.x;
      r12.xyz = r14.xyz * r16.yyy + r15.xyw;
      r12.x = tex2D(_IN1, r12.xy).x;
      r12.x = r12.z + -r12.x;
      r12.x = abs(r5.y) * 0.25 + r12.x;
      r12.x = cmp(abs(r12.x) < r11.w);
      r12.y = cmp(r3.w < 0);
      r12.x = r12.y ? r12.x : 0;
      r3.w = r12.x ? r16.y : r3.w;
      r12.xyz = r14.xyz * r16.zzz + r15.xyw;
      r12.x = tex2D(_IN1, r12.xy).x;
      r12.x = r12.z + -r12.x;
      r12.x = abs(r5.y) * 0.25 + r12.x;
      r12.x = cmp(abs(r12.x) < r11.w);
      r12.y = cmp(r3.w < 0);
      r12.x = r12.y ? r12.x : 0;
      r3.w = r12.x ? r16.z : r3.w;
      r12.xyz = r14.xyz * r16.www + r15.xyw;
      r12.x = tex2D(_IN1, r12.xy).x;
      r12.x = r12.z + -r12.x;
      r5.y = abs(r5.y) * 0.25 + r12.x;
      r5.y = cmp(abs(r5.y) < r11.w);
      r11.w = cmp(r3.w < 0);
      r5.y = r5.y ? r11.w : 0;
      r3.w = r5.y ? r16.w : r3.w;
      r5.y = cmp(0 < r3.w);
      if (r5.y != 0) {
        r12.xy = r14.xy * r3.ww + r15.xy;
        r5.y = tex2D(_IN3, r12.xy).w;
        r5.y = 255 * r5.y;
        r5.y = round(r5.y);
        r5.y = (uint)r5.y;
        r5.y = (int)r5.y & 15;
        r11.w = cmp((int)r5.y != 12);
        r14.xyz = cmp((int3)r5.yyy == int3(13,14,15));
        r5.y = (int)r14.z | (int)r14.y;
        r5.y = (int)r5.y | (int)r14.x;
        r5.y = r11.w ? r5.y : -1;
        if (r5.y != 0) {
          r5.y = 0;
        } else {
          r5.y = tex2D(_IN2, r12.xy).w;
        }
        r5.y = 3.99900007 * r5.y;
        r5.y = (uint)r5.y;
        r5.y = (int)r5.y & 1;
        r5.y = cmp((int)r5.y != 0);
        r12.zw = cmp(float2(0,0) < r12.xy);
        r12.xy = cmp(r12.xy < float2(1,1));
        r12.xy = r12.xy ? r12.zw : 0;
        r11.w = r12.y ? r12.x : 0;
        r1.z = r3.w * r1.z;
        r1.z = r11.w ? r1.z : -1;
      } else {
        r5.y = 0;
        r1.z = -1;
      }
      r3.w = cmp(0 < r1.z);
      r5.y = r5.y ? cb1[2].y : cb1[2].x;
      r11.w = cmp(0 < r5.y);
      r12.x = (int)r9.z | (int)r9.x;
      r12.x = (int)r9.w | (int)r12.x;
      r5.x = (int)r5.x | (int)r12.x;
      r5.x = (int)r9.y | (int)r5.x;
      r5.x = r5.x ? r11.w : 0;
      r12.xyz = cmp((int3)r1.www != int3(7,5,4));
      r5.x = r5.x ? r12.x : 0;
      r5.x = r12.y ? r5.x : 0;
      r5.x = r12.z ? r5.x : 0;
      if (r5.x != 0) {
        r5.x = min(0.999000013, r10.w);
        r5.x = 1 + -r5.x;
        r5.x = log2(r5.x);
        r5.x = -0.0346573591 * r5.x;
        r1.z = -r5.x * r1.z;
        r1.z = 1.44269502 * r1.z;
        r1.z = exp2(r1.z);
        r1.z = min(1, r1.z);
        r1.z = 1 + -r1.z;
        r5.y = r5.y * r1.z;
      }
      r1.z = 1 + -r5.y;
      r5.xy = r7.xz * r1.zz;
      r7.xz = r3.ww ? r5.xy : r7.xz;
    }
    r1.z = cmp(0 < r0.x);
    r5.xy = r1.zz ? float2(1,1) : r7.xz;
    r5.xy = r3.yy ? r5.xy : r7.xz;
    r1.z = 1 + -cb0[268].w;
    r3.w = 1 + -r1.x;
    r12.x = r1.z * r3.w + r1.x;
    r12.y = r5.z ? r3.x : 1;
    r1.y = 1;
    r1.xy = r3.zz ? r12.xy : r1.xy;
    r3.x = 1 + -r1.x;
    r1.z = r1.z * r3.x + r1.x;
    r1.x = r9.x ? r1.z : r1.x;
    r1.z = r5.x + r5.y;
    r1.z = cmp(0 < r1.z);
    if (r1.z != 0) {
      r1.z = r9.w ? 0.300000012 : r7.w;
      r3.x = 1 + -r6.x;
      r3.xz = r7.xz * r3.xx;
      r3.xz = r3.yy ? r3.xz : r7.xz;
      r3.w = 0.5 * cb1[9].w;
      r9.xyw = -r3.www * cb1[8].xyz + cb1[7].xyz;
      r12.xyz = r3.www * cb1[8].xyz + cb1[7].xyz;
      r3.w = cmp(0 < cb1[9].w);
      if (r3.w != 0) {
        r5.x = dot(r9.xyw, r9.xyw);
        r5.y = dot(r12.xyz, r12.xyz);
        r5.x = rsqrt(r5.x);
        r5.y = rsqrt(r5.y);
        r6.x = r5.x * r5.y;
        r7.w = dot(r9.xyw, r12.xyz);
        r7.w = r7.w * r6.x;
        r7.w = r7.w * 0.5 + r6.x;
        r7.w = 0.5 + r7.w;
        r6.x = r6.x / r7.w;
        r7.w = dot(r4.yzw, r9.xyw);
        r11.w = dot(r4.yzw, r12.xyz);
        r5.y = r11.w * r5.y;
        r5.x = r7.w * r5.x + r5.y;
        r5.x = 0.5 * r5.x;
      } else {
        r5.y = dot(r9.xyw, r9.xyw);
        r7.w = 1 + r5.y;
        r6.x = rcp(r7.w);
        r5.y = rsqrt(r5.y);
        r14.xyz = r9.xyw * r5.yyy;
        r5.x = dot(r4.yzw, r14.xyz);
      }
      r5.y = cmp(0 < cb1[8].w);
      r7.w = cb1[8].w * cb1[8].w;
      r6.x = saturate(r7.w * r6.x);
      r6.x = sqrt(r6.x);
      r7.w = cmp(r5.x < r6.x);
      r11.w = max(-r6.x, r5.x);
      r11.w = r11.w + r6.x;
      r11.w = r11.w * r11.w;
      r6.x = 4 * r6.x;
      r6.x = r11.w / r6.x;
      r6.x = r7.w ? r6.x : r5.x;
      r5.x = r5.y ? r6.x : r5.x;
      r14.xyz = saturate(r5.xxx);
      r5.x = dot(r13.xyz, r4.yzw);
      r5.x = r5.x + r5.x;
      r15.xyw = r4.yzw * -r5.xxx + r13.xyz;
      r12.xyz = r12.xyz + -r9.xyw;
      r5.x = dot(r15.xyw, r12.xyz);
      r15.xyw = r5.xxx * r15.xyw + -r12.xyz;
      r5.y = dot(r9.xyw, r15.xyw);
      r5.x = r5.x * r5.x;
      r5.x = cb1[9].w * cb1[9].w + -r5.x;
      r5.x = saturate(r5.y / r5.x);
      r12.xyz = r5.xxx * r12.xyz + r9.xyw;
      r9.xyw = r3.www ? r12.xyz : r9.xyw;
      r3.w = dot(r9.xyw, r9.xyw);
      r3.w = rsqrt(r3.w);
      r12.xyz = r9.xyw * r3.www;
      r1.z = max(cb0[239].y, r1.z);
      r5.x = cb1[8].w * r3.w;
      r5.y = -r1.z * r1.z + 1;
      r5.x = saturate(r5.x * r5.y);
      r5.y = saturate(cb1[9].z * r3.w);
      switch ((int)r1.w) {
        case 1: case 8: case 9:
        r6.x = dot(r4.yzw, r12.xyz);
        r7.w = dot(r4.yzw, -r13.xyz);
        r11.w = dot(-r13.xyz, r12.xyz);
        r12.w = cmp(0 < r5.x);
        if (r12.w != 0) {
          r12.w = -r5.x * r5.x + 1;
          r12.w = sqrt(r12.w);
          r13.w = dot(r7.ww, r6.xx);
          r14.w = r13.w + -r11.w;
          r16.w = cmp(r14.w >= r12.w);
          if (r16.w != 0) {
            r18.y = abs(r7.w);
            r18.x = 1;
          } else {
            r16.w = -r14.w * r14.w + 1;
            r16.w = rsqrt(r16.w);
            r16.w = r16.w * r5.x;
            r17.w = -r14.w * r6.x + r7.w;
            r18.z = r17.w * r16.w;
            r18.w = r7.w * r7.w;
            r18.w = r18.w * 2 + -1;
            r14.w = -r14.w * r11.w + r18.w;
            r14.w = r16.w * r14.w;
            r18.w = -r6.x * r6.x + 1;
            r18.w = -r7.w * r7.w + r18.w;
            r18.w = -r11.w * r11.w + r18.w;
            r13.w = saturate(r13.w * r11.w + r18.w);
            r13.w = sqrt(r13.w);
            r13.w = r16.w * r13.w;
            r18.w = r13.w * r7.w;
            r19.x = r18.w + r18.w;
            r19.y = r6.x * r12.w + r7.w;
            r16.w = r16.w * r17.w + r19.y;
            r17.w = r11.w * r12.w + r14.w;
            r17.w = 1 + r17.w;
            r19.z = r17.w * r13.w;
            r19.w = r17.w * r16.w;
            r20.x = r19.x * r16.w;
            r18.w = r16.w * r18.w;
            r18.w = 0.5 * r18.w;
            r18.w = r19.z * -0.5 + r18.w;
            r18.w = r19.w * r18.w;
            r20.y = -r19.z * 2 + r20.x;
            r20.x = r20.x * r20.y;
            r19.z = r19.z * r19.z + r20.x;
            r20.x = r17.w * r17.w;
            r17.w = r11.w * r12.w + r17.w;
            r17.w = r17.w * -0.5 + -0.5;
            r17.w = r19.w * r17.w;
            r17.w = r19.y * r20.x + r17.w;
            r16.w = r16.w * r17.w + r19.z;
            r17.w = r18.w + r18.w;
            r19.y = r18.w * r18.w;
            r19.y = r16.w * r16.w + r19.y;
            r17.w = r17.w / r19.y;
            r16.w = r17.w * r16.w;
            r17.w = -r17.w * r18.w + 1;
            r13.w = r16.w * r13.w;
            r13.w = r17.w * r18.z + r13.w;
            r16.w = r16.w * r19.x;
            r14.w = r17.w * r14.w + r16.w;
            r13.w = r6.x * r12.w + r13.w;
            r12.w = r11.w * r12.w + r14.w;
            r14.w = r12.w * 2 + 2;
            r14.w = rsqrt(r14.w);
            r13.w = r13.w + r7.w;
            r18.x = saturate(r13.w * r14.w);
            r18.y = saturate(r14.w * r12.w + r14.w);
          }
        } else {
          r12.w = r11.w * 2 + 2;
          r12.w = rsqrt(r12.w);
          r13.w = r7.w + r6.x;
          r18.x = saturate(r13.w * r12.w);
          r18.y = saturate(r12.w * r11.w + r12.w);
        }
        r7.w = 9.99999975e-006 + abs(r7.w);
        r7.w = min(1, r7.w);
        r11.w = cmp(r1.x < 1);
        if (r11.w != 0) {
          r19.x = saturate(r6.x * 0.5 + 0.5);
          r19.y = 1 + -cb0[267].w;
          r19.xyz = tex2D(_IN0, r19.xy).xyz;
          r20.xyz = -r19.xyz + r14.zzz;
          r19.xyz = r1.xxx * r20.xyz + r19.xyz;
        } else {
          r19.xyz = r14.zzz;
        }
        r19.xyz = r19.xyz * r2.yzw;
        r15.xyw = float3(0.318309873,0.318309873,0.318309873) * r19.xyz;
        r6.x = max(9.99999975e-006, r1.z);
        r6.x = r6.x * r6.x;
        r11.w = r6.x * r6.x;
        r12.w = cmp(0 < r5.y);
        r13.w = r5.y * r5.y;
        r14.w = r18.y * 3.5999999 + 0.400000006;
        r13.w = r13.w / r14.w;
        r6.x = r6.x * r6.x + r13.w;
        r6.x = min(1, r6.x);
        r6.x = r12.w ? r6.x : r11.w;
        r11.w = r18.x * r6.x + -r18.x;
        r11.w = r11.w * r18.x + 1;
        r11.w = r11.w * r11.w;
        r11.w = 3.14159274 * r11.w;
        r11.w = r6.x / r11.w;
        r6.x = sqrt(r6.x);
        r12.w = 1 + -r6.x;
        r13.w = r7.w * r12.w + r6.x;
        r6.x = r14.z * r12.w + r6.x;
        r6.x = r7.w * r6.x;
        r6.x = r14.z * r13.w + r6.x;
        r6.x = rcp(r6.x);
        r6.x = r11.w * r6.x;
        r7.w = 1 + -r18.y;
        r11.w = r7.w * r7.w;
        r11.w = r11.w * r11.w;
        r12.w = r11.w * r7.w;
        r13.w = saturate(50 * r6.z);
        r7.w = -r11.w * r7.w + 1;
        r18.xyz = r7.www * r6.yzw;
        r18.xyz = r13.www * r12.www + r18.xyz;
        r6.x = 0.5 * r6.x;
        r18.xyz = r6.xxx * r18.xyz;
        r18.xyz = r18.xyz * r14.zzz;
        r6.x = cmp(0.99000001 < r8.w);
        r6.x = r6.x ? 0.5 : cb0[253].z;
        r18.xyz = cb0[198].xxx * r18.xyz;
        r16.xyz = min(r18.xyz, r6.xxx);
        r0.w = saturate(r3.x + -r0.w);
        r0.w = cmp(0.899999976 >= r0.w);
        r6.x = 1 + -cb0[253].y;
        r0.w = r0.w ? 1 : r6.x;
        r6.x = cmp(r0.z >= cb0[199].z);
        r6.x = r6.x ? 1.000000 : 0;
        r7.w = cmp(cb0[31].w >= 1);
        r7.w = r7.w ? 1.000000 : 0;
        r11.w = cb0[65].w + r5.w;
        r11.w = cb0[65].z * r11.w;
        r11.w = 1 / r11.w;
        r5.w = r5.w * cb0[30].z + cb0[31].z;
        r5.w = r5.w + -r11.w;
        r5.w = r7.w * r5.w + r11.w;
        r5.w = saturate(300 * r5.w);
        r0.z = cb0[199].x * r0.z;
        r0.z = r0.z * r6.x;
        r0.z = r0.z * r0.w;
        r18.xyz = r0.zzz * r16.xyz;
        r18.xyz = r18.xyz * r5.www;
        r17.xyz = min(float3(5,5,5), r18.xyz);
        break;
        case 2:
        r0.z = dot(r4.yzw, r12.xyz);
        r0.w = dot(r4.yzw, -r13.xyz);
        r5.w = dot(-r13.xyz, r12.xyz);
        r6.x = cmp(0 < r5.x);
        if (r6.x != 0) {
          r6.x = -r5.x * r5.x + 1;
          r6.x = sqrt(r6.x);
          r7.w = dot(r0.ww, r0.zz);
          r11.w = r7.w + -r5.w;
          r12.w = cmp(r11.w >= r6.x);
          if (r12.w != 0) {
            r18.y = abs(r0.w);
            r18.x = 1;
          } else {
            r12.w = -r11.w * r11.w + 1;
            r12.w = rsqrt(r12.w);
            r12.w = r12.w * r5.x;
            r13.w = -r11.w * r0.z + r0.w;
            r14.w = r13.w * r12.w;
            r16.w = r0.w * r0.w;
            r16.w = r16.w * 2 + -1;
            r11.w = -r11.w * r5.w + r16.w;
            r11.w = r12.w * r11.w;
            r16.w = -r0.z * r0.z + 1;
            r16.w = -r0.w * r0.w + r16.w;
            r16.w = -r5.w * r5.w + r16.w;
            r7.w = saturate(r7.w * r5.w + r16.w);
            r7.w = sqrt(r7.w);
            r7.w = r12.w * r7.w;
            r16.w = r7.w * r0.w;
            r17.w = r16.w + r16.w;
            r18.z = r0.z * r6.x + r0.w;
            r12.w = r12.w * r13.w + r18.z;
            r13.w = r5.w * r6.x + r11.w;
            r13.w = 1 + r13.w;
            r18.w = r13.w * r7.w;
            r19.x = r13.w * r12.w;
            r19.y = r17.w * r12.w;
            r16.w = r12.w * r16.w;
            r16.w = 0.5 * r16.w;
            r16.w = r18.w * -0.5 + r16.w;
            r16.w = r19.x * r16.w;
            r19.z = -r18.w * 2 + r19.y;
            r19.y = r19.y * r19.z;
            r18.w = r18.w * r18.w + r19.y;
            r19.y = r13.w * r13.w;
            r13.w = r5.w * r6.x + r13.w;
            r13.w = r13.w * -0.5 + -0.5;
            r13.w = r19.x * r13.w;
            r13.w = r18.z * r19.y + r13.w;
            r12.w = r12.w * r13.w + r18.w;
            r13.w = r16.w + r16.w;
            r18.z = r16.w * r16.w;
            r18.z = r12.w * r12.w + r18.z;
            r13.w = r13.w / r18.z;
            r12.w = r13.w * r12.w;
            r13.w = -r13.w * r16.w + 1;
            r7.w = r12.w * r7.w;
            r7.w = r13.w * r14.w + r7.w;
            r12.w = r12.w * r17.w;
            r11.w = r13.w * r11.w + r12.w;
            r7.w = r0.z * r6.x + r7.w;
            r6.x = r5.w * r6.x + r11.w;
            r11.w = r6.x * 2 + 2;
            r11.w = rsqrt(r11.w);
            r7.w = r7.w + r0.w;
            r18.x = saturate(r7.w * r11.w);
            r18.y = saturate(r11.w * r6.x + r11.w);
          }
        } else {
          r6.x = r5.w * 2 + 2;
          r6.x = rsqrt(r6.x);
          r7.w = r0.z + r0.w;
          r18.x = saturate(r7.w * r6.x);
          r18.y = saturate(r6.x * r5.w + r6.x);
        }
        r0.w = 9.99999975e-006 + abs(r0.w);
        r5.w = cmp(r1.x < 1);
        if (r5.w != 0) {
          r19.x = saturate(r0.z * 0.5 + 0.5);
          r19.y = 1 + -cb0[267].w;
          r19.xyz = tex2D(_IN0, r19.xy).xyz;
          r20.xyz = -r19.xyz + r14.zzz;
          r19.xyz = r1.xxx * r20.xyz + r19.xyz;
        } else {
          r19.xyz = r14.zzz;
        }
        r19.xyz = r19.xyz * r2.yzw;
        r15.xyw = float3(0.318309873,0.318309873,0.318309873) * r19.xyz;
        r0.z = max(9.99999975e-006, r1.z);
        r0.z = r0.z * r0.z;
        r5.w = r0.z * r0.z;
        r6.x = cmp(0 < r5.y);
        r7.w = r5.y * r5.y;
        r11.w = r18.y * 3.5999999 + 0.400000006;
        r7.w = r7.w / r11.w;
        r0.z = r0.z * r0.z + r7.w;
        r0.zw = min(float2(1,1), r0.zw);
        r0.z = r6.x ? r0.z : r5.w;
        r5.w = r18.x * r0.z + -r18.x;
        r5.w = r5.w * r18.x + 1;
        r5.w = r5.w * r5.w;
        r5.w = 3.14159274 * r5.w;
        r5.w = r0.z / r5.w;
        r0.z = sqrt(r0.z);
        r6.x = 1 + -r0.z;
        r7.w = r0.w * r6.x + r0.z;
        r0.z = r14.z * r6.x + r0.z;
        r0.z = r0.w * r0.z;
        r0.z = r14.z * r7.w + r0.z;
        r0.z = rcp(r0.z);
        r0.z = r5.w * r0.z;
        r0.w = 1 + -r18.y;
        r5.w = r0.w * r0.w;
        r5.w = r5.w * r5.w;
        r6.x = r5.w * r0.w;
        r7.w = saturate(50 * r6.z);
        r0.w = -r5.w * r0.w + 1;
        r18.xyz = r0.www * r6.yzw;
        r18.xyz = r7.www * r6.xxx + r18.xyz;
        r0.z = 0.5 * r0.z;
        r18.xyz = r0.zzz * r18.xyz;
        r18.xyz = r18.xyz * r14.zzz;
        r0.z = cmp(0.99000001 < r8.w);
        r0.z = r0.z ? 0.5 : cb0[253].z;
        r18.xyz = cb0[198].xxx * r18.xyz;
        r16.xyz = min(r18.xyz, r0.zzz);
        r18.xyz = r10.xyz * r10.xyz;
        r19.xyz = r9.xyw * r3.www + -r13.xyz;
        r0.z = dot(r19.xyz, r19.xyz);
        r0.z = rsqrt(r0.z);
        r19.xyz = r19.xyz * r0.zzz;
        r0.z = saturate(dot(r12.xyz, r13.xyz));
        r0.z = log2(r0.z);
        r0.z = 12 * r0.z;
        r0.z = exp2(r0.z);
        r0.w = r10.w * -2.9000001 + 3;
        r0.z = r0.z * r0.w;
        r0.w = dot(r4.yzw, r19.xyz);
        r0.w = r0.w * r10.w + 1;
        r0.w = saturate(r0.w + -r10.w);
        r0.w = r2.x * r0.w;
        r5.w = 0.159154937 * r0.w;
        r0.w = -r0.w * 0.159154937 + 1;
        r0.z = r0.z * r0.w + r5.w;
        r17.xyz = r0.zzz * r18.xyz;
        break;
        case 4:
        r0.z = dot(r4.yzw, r12.xyz);
        r0.w = dot(r4.yzw, -r13.xyz);
        r5.w = dot(-r13.xyz, r12.xyz);
        r6.x = cmp(0 < r5.x);
        if (r6.x != 0) {
          r6.x = -r5.x * r5.x + 1;
          r6.x = sqrt(r6.x);
          r7.w = dot(r0.ww, r0.zz);
          r10.w = r7.w + -r5.w;
          r11.w = cmp(r10.w >= r6.x);
          if (r11.w != 0) {
            r18.y = abs(r0.w);
            r18.x = 1;
          } else {
            r11.w = -r10.w * r10.w + 1;
            r11.w = rsqrt(r11.w);
            r11.w = r11.w * r5.x;
            r12.w = -r10.w * r0.z + r0.w;
            r13.w = r12.w * r11.w;
            r14.w = r0.w * r0.w;
            r14.w = r14.w * 2 + -1;
            r10.w = -r10.w * r5.w + r14.w;
            r10.w = r11.w * r10.w;
            r14.w = -r0.z * r0.z + 1;
            r14.w = -r0.w * r0.w + r14.w;
            r14.w = -r5.w * r5.w + r14.w;
            r7.w = saturate(r7.w * r5.w + r14.w);
            r7.w = sqrt(r7.w);
            r7.w = r11.w * r7.w;
            r14.w = r7.w * r0.w;
            r16.w = r14.w + r14.w;
            r17.w = r0.z * r6.x + r0.w;
            r11.w = r11.w * r12.w + r17.w;
            r12.w = r5.w * r6.x + r10.w;
            r12.w = 1 + r12.w;
            r18.z = r12.w * r7.w;
            r18.w = r12.w * r11.w;
            r19.x = r16.w * r11.w;
            r14.w = r11.w * r14.w;
            r14.w = 0.5 * r14.w;
            r14.w = r18.z * -0.5 + r14.w;
            r14.w = r18.w * r14.w;
            r19.y = -r18.z * 2 + r19.x;
            r19.x = r19.x * r19.y;
            r18.z = r18.z * r18.z + r19.x;
            r19.x = r12.w * r12.w;
            r12.w = r5.w * r6.x + r12.w;
            r12.w = r12.w * -0.5 + -0.5;
            r12.w = r18.w * r12.w;
            r12.w = r17.w * r19.x + r12.w;
            r11.w = r11.w * r12.w + r18.z;
            r12.w = r14.w + r14.w;
            r17.w = r14.w * r14.w;
            r17.w = r11.w * r11.w + r17.w;
            r12.w = r12.w / r17.w;
            r11.w = r12.w * r11.w;
            r12.w = -r12.w * r14.w + 1;
            r7.w = r11.w * r7.w;
            r7.w = r12.w * r13.w + r7.w;
            r11.w = r11.w * r16.w;
            r10.w = r12.w * r10.w + r11.w;
            r7.w = r0.z * r6.x + r7.w;
            r6.x = r5.w * r6.x + r10.w;
            r10.w = r6.x * 2 + 2;
            r10.w = rsqrt(r10.w);
            r7.w = r7.w + r0.w;
            r18.x = saturate(r7.w * r10.w);
            r18.y = saturate(r10.w * r6.x + r10.w);
          }
        } else {
          r6.x = r5.w * 2 + 2;
          r6.x = rsqrt(r6.x);
          r7.w = r0.z + r0.w;
          r18.x = saturate(r7.w * r6.x);
          r18.y = saturate(r6.x * r5.w + r6.x);
        }
        r0.w = 9.99999975e-006 + abs(r0.w);
        r0.w = min(1, r0.w);
        r6.x = cmp(r1.x < 1);
        if (r6.x != 0) {
          r19.x = saturate(r0.z * 0.5 + 0.5);
          r19.y = 1 + -cb0[267].w;
          r19.xyz = tex2D(_IN0, r19.xy).xyz;
          r20.xyz = -r19.xyz + r14.zzz;
          r19.xyz = r1.xxx * r20.xyz + r19.xyz;
        } else {
          r19.xyz = r14.zzz;
        }
        r19.xyz = r19.xyz * r2.yzw;
        r15.xyw = float3(0.318309873,0.318309873,0.318309873) * r19.xyz;
        r6.x = max(9.99999975e-006, r1.z);
        r6.x = r6.x * r6.x;
        r7.w = r6.x * r6.x;
        r10.w = cmp(0 < r5.y);
        r11.w = r5.y * r5.y;
        r12.w = r18.y * 3.5999999 + 0.400000006;
        r11.w = r11.w / r12.w;
        r6.x = r6.x * r6.x + r11.w;
        r6.x = min(1, r6.x);
        r6.x = r10.w ? r6.x : r7.w;
        r7.w = r18.x * r6.x + -r18.x;
        r7.w = r7.w * r18.x + 1;
        r7.w = r7.w * r7.w;
        r7.w = 3.14159274 * r7.w;
        r7.w = r6.x / r7.w;
        r6.x = sqrt(r6.x);
        r10.w = 1 + -r6.x;
        r11.w = r0.w * r10.w + r6.x;
        r6.x = r14.z * r10.w + r6.x;
        r0.w = r6.x * r0.w;
        r0.w = r14.z * r11.w + r0.w;
        r0.w = rcp(r0.w);
        r0.w = r7.w * r0.w;
        r6.x = 1 + -r18.y;
        r7.w = r6.x * r6.x;
        r7.w = r7.w * r7.w;
        r10.w = r7.w * r6.x;
        r11.w = saturate(50 * r6.z);
        r6.x = -r7.w * r6.x + 1;
        r18.xyz = r6.xxx * r6.yzw;
        r18.xyz = r11.www * r10.www + r18.xyz;
        r0.w = 0.5 * r0.w;
        r18.xyz = r0.www * r18.xyz;
        r18.xyz = r18.xyz * r14.zzz;
        r0.w = cmp(0.99000001 < r8.w);
        r0.w = r0.w ? 0.5 : cb0[253].z;
        r18.xyz = cb0[198].xxx * r18.xyz;
        r18.xyz = min(r18.xyz, r0.www);
        r18.xyz = r18.xyz * r8.www;
        r16.xyz = min(float3(10,10,10), r18.xyz);
        r18.xyz = r10.xyz * r10.xyz;
        r0.z = 0.5 + -r0.z;
        r0.z = saturate(0.444444448 * r0.z);
        r5.w = saturate(-r5.w);
        r0.w = r5.w * r5.w;
        r0.w = r0.w * -0.639999986 + 1;
        r0.w = r0.w * r0.w;
        r0.w = 3.14159274 * r0.w;
        r0.w = 0.360000014 / r0.w;
        r0.z = r0.z * r0.w;
        r17.xyz = r0.zzz * r18.xyz;
        break;
        case 5:
        r15.xyw = float3(0,0,0);
        r16.xyz = float3(0,0,0);
        r17.xyz = float3(0,0,0);
        break;
        case 6:
        r0.z = dot(r4.yzw, r12.xyz);
        r0.w = cmp(0.99000001 < r0.x);
        r5.w = dot(-r13.xyz, r12.xyz);
        r5.w = r5.w * 0.5 + 0.5;
        r18.x = 0.25 * r5.w;
        r18.y = r5.w * 0.25 + 0.5;
        r0.y = 1;
        r0.xy = r0.ww ? r18.xy : r0.xy;
        r0.w = max(0, r0.z);
        r6.x = 1 + -r0.w;
        r0.w = saturate(r0.x * r6.x + r0.w);
        r18.xy = float2(1,1) + -r3.xz;
        r0.x = r0.x * r18.x + r3.x;
        r0.x = r0.x * r2.x;
        r18.xzw = float3(0.318309873,0.318309873,0.318309873) * r2.yzw;
        r19.xyz = r18.xzw * r0.www;
        r15.xyw = r19.xyz * r0.xxx;
        r19.xyz = r9.xyw * r3.www + -r13.xyz;
        r0.w = dot(r19.xyz, r19.xyz);
        r0.w = rsqrt(r0.w);
        r19.xyz = r19.xyz * r0.www;
        r0.w = dot(r4.yzw, r19.xyz);
        r5.w = 1 + -r5.w;
        r5.w = r5.w * r5.w;
        r5.w = r5.w * r5.w;
        r0.z = 1 + r0.z;
        r0.z = saturate(0.5 * r0.z);
        r6.x = r0.z * -2 + 3;
        r0.z = r0.z * r0.z;
        r0.z = r6.x * r0.z;
        r6.x = -0.449999988 * r5.w;
        r19.xy = r5.ww * float2(0.0500000119,0.600000024) + float2(0.949999988,0.400000006);
        r7.w = r0.w * r19.x + -r0.w;
        r0.w = r0.w * r7.w + r6.x;
        r0.w = 1 + r0.w;
        r0.w = r0.w * r0.w;
        r0.w = 3.1415925 * r0.w;
        r0.w = r19.y / r0.w;
        r0.z = r0.w * r0.z;
        r0.w = 5 * r1.z;
        r6.x = -r1.z * 5 + 1;
        r0.w = r5.w * r6.x + r0.w;
        r0.z = r0.z * r0.w;
        r0.w = -0.5 + r8.w;
        r0.w = saturate(r0.w * 2 + r5.w);
        r19.xyz = r10.xyz * r10.xyz + -r18.xzw;
        r18.xzw = r0.www * r19.xyz + r18.xzw;
        r0.w = r18.y * 0.100000001 + r3.z;
        r0.w = r0.w * r2.x;
        r0.x = min(r0.w, r0.x);
        r0.x = r0.x * r0.z + 0.300000012;
        r0.x = saturate(0.769230783 * r0.x);
        r0.z = r0.x * -2 + 3;
        r0.x = r0.x * r0.x;
        r0.x = r0.z * r0.x;
        r18.xyz = r18.xzw * r0.xxx;
        r0.x = r0.w * r0.y;
        r17.xyz = r18.xyz * r0.xxx;
        r16.xyz = float3(0,0,0);
        break;
        case 7:
        r0.x = r8.w * 255 + 0.5;
        r0.x = (uint)r0.x;
        r0.y = (int)r0.x & 1;
        if (r0.y == 0) {
          r0.y = dot(r4.yzw, r12.xyz);
          r0.z = dot(r4.yzw, -r13.xyz);
          r0.w = dot(-r13.xyz, r12.xyz);
          r5.w = cmp(0 < r5.x);
          if (r5.w != 0) {
            r5.w = -r5.x * r5.x + 1;
            r5.w = sqrt(r5.w);
            r6.x = dot(r0.zz, r0.yy);
            r7.w = r6.x + -r0.w;
            r10.w = cmp(r7.w >= r5.w);
            if (r10.w != 0) {
              r18.y = abs(r0.z);
              r18.x = 1;
            } else {
              r10.w = -r7.w * r7.w + 1;
              r10.w = rsqrt(r10.w);
              r10.w = r10.w * r5.x;
              r11.w = -r7.w * r0.y + r0.z;
              r12.w = r11.w * r10.w;
              r13.w = r0.z * r0.z;
              r13.w = r13.w * 2 + -1;
              r7.w = -r7.w * r0.w + r13.w;
              r7.w = r10.w * r7.w;
              r13.w = -r0.y * r0.y + 1;
              r13.w = -r0.z * r0.z + r13.w;
              r13.w = -r0.w * r0.w + r13.w;
              r6.x = saturate(r6.x * r0.w + r13.w);
              r6.x = sqrt(r6.x);
              r6.x = r10.w * r6.x;
              r13.w = r6.x * r0.z;
              r14.w = r13.w + r13.w;
              r16.w = r0.y * r5.w + r0.z;
              r10.w = r10.w * r11.w + r16.w;
              r11.w = r0.w * r5.w + r7.w;
              r11.w = 1 + r11.w;
              r17.w = r11.w * r6.x;
              r18.z = r11.w * r10.w;
              r18.w = r14.w * r10.w;
              r13.w = r10.w * r13.w;
              r13.w = 0.5 * r13.w;
              r13.w = r17.w * -0.5 + r13.w;
              r13.w = r18.z * r13.w;
              r19.x = -r17.w * 2 + r18.w;
              r18.w = r19.x * r18.w;
              r17.w = r17.w * r17.w + r18.w;
              r18.w = r11.w * r11.w;
              r11.w = r0.w * r5.w + r11.w;
              r11.w = r11.w * -0.5 + -0.5;
              r11.w = r18.z * r11.w;
              r11.w = r16.w * r18.w + r11.w;
              r10.w = r10.w * r11.w + r17.w;
              r11.w = r13.w + r13.w;
              r16.w = r13.w * r13.w;
              r16.w = r10.w * r10.w + r16.w;
              r11.w = r11.w / r16.w;
              r10.w = r11.w * r10.w;
              r11.w = -r11.w * r13.w + 1;
              r6.x = r10.w * r6.x;
              r6.x = r11.w * r12.w + r6.x;
              r10.w = r10.w * r14.w;
              r7.w = r11.w * r7.w + r10.w;
              r6.x = r0.y * r5.w + r6.x;
              r5.w = r0.w * r5.w + r7.w;
              r7.w = r5.w * 2 + 2;
              r7.w = rsqrt(r7.w);
              r6.x = r6.x + r0.z;
              r18.x = saturate(r6.x * r7.w);
              r18.y = saturate(r7.w * r5.w + r7.w);
            }
          } else {
            r5.w = r0.w * 2 + 2;
            r5.w = rsqrt(r5.w);
            r6.x = r0.y + r0.z;
            r18.x = saturate(r6.x * r5.w);
            r18.y = saturate(r5.w * r0.w + r5.w);
          }
          r0.z = 9.99999975e-006 + abs(r0.z);
          r0.z = min(1, r0.z);
          r5.w = cmp(r1.x < 1);
          if (r5.w != 0) {
            r19.x = saturate(r0.y * 0.5 + 0.5);
            r19.y = 1 + -cb0[267].w;
            r19.xyz = tex2D(_IN0, r19.xy).xyz;
            r20.xyz = -r19.xyz + r14.zzz;
            r19.xyz = r1.xxx * r20.xyz + r19.xyz;
          } else {
            r19.xyz = r14.xyz;
          }
          r14.xyw = r19.xyz * r2.yzw;
          r14.xyw = r14.xyw * r3.xxx;
          r1.x = max(9.99999975e-006, r1.z);
          r1.x = r1.x * r1.x;
          r5.w = r1.x * r1.x;
          r6.x = cmp(0 < r5.y);
          r7.w = r5.y * r5.y;
          r10.w = r18.y * 3.5999999 + 0.400000006;
          r7.w = r7.w / r10.w;
          r1.x = r1.x * r1.x + r7.w;
          r1.x = min(1, r1.x);
          r1.x = r6.x ? r1.x : r5.w;
          r5.w = r18.x * r1.x + -r18.x;
          r5.w = r5.w * r18.x + 1;
          r5.w = r5.w * r5.w;
          r5.w = 3.14159274 * r5.w;
          r5.w = r1.x / r5.w;
          r1.x = sqrt(r1.x);
          r6.x = 1 + -r1.x;
          r7.w = r0.z * r6.x + r1.x;
          r1.x = r14.z * r6.x + r1.x;
          r0.z = r1.x * r0.z;
          r0.z = r14.z * r7.w + r0.z;
          r0.z = rcp(r0.z);
          r0.z = r5.w * r0.z;
          r1.x = 1 + -r18.y;
          r5.w = r1.x * r1.x;
          r5.w = r5.w * r5.w;
          r6.x = r5.w * r1.x;
          r7.w = saturate(50 * r6.z);
          r1.x = -r5.w * r1.x + 1;
          r18.xyz = r1.xxx * r6.yzw;
          r18.xyz = r7.www * r6.xxx + r18.xyz;
          r0.z = 0.5 * r0.z;
          r18.xyz = r0.zzz * r18.xyz;
          r18.xyz = r18.xyz * r14.zzz;
          r0.z = cmp(0.99000001 < r8.w);
          r0.z = r0.z ? 0.5 : cb0[253].z;
          r18.xyz = cb0[198].xxx * r18.xyz;
          r18.xyz = min(r18.xyz, r0.zzz);
          r19.xyz = r10.xyz * r10.xyz;
          r0.y = 0.5 + -r0.y;
          r0.y = saturate(0.444444448 * r0.y);
          r0.w = saturate(-r0.w);
          r0.z = r0.w * r0.w;
          r0.z = r0.z * -0.639999986 + 1;
          r0.z = r0.z * r0.z;
          r0.z = 3.14159274 * r0.z;
          r0.z = 0.360000014 / r0.z;
          r15.xyw = float3(0.318309873,0.318309873,0.318309873) * r14.xyw;
          r16.xyz = r18.xyz * r3.xxx;
          r0.y = r0.y * r0.z;
          r0.yzw = r0.yyy * r19.xyz;
          r17.xyz = r0.yzw * r3.zzz;
        } else {
          if (3 == 0) r0.x = 0; else if (3+5 < 32) {           r0.x = (uint)r0.x << (32-(3 + 5)); r0.x = (uint)r0.x >> (32-3);          } else r0.x = (uint)r0.x >> 5;
          if (4 == 0) r0.y = 0; else if (4+1 < 32) {           r0.y = (uint)r0.x << (32-(4 + 1)); r0.y = (uint)r0.y >> (32-4);          } else r0.y = (uint)r0.x >> 1;
          r0.xy = (uint2)r0.xy;
          r18.y = 0.0666666701 * r0.y;
          r0.z = dot(r4.yzw, r12.xyz);
          r0.w = dot(r4.yzw, -r13.xyz);
          r1.x = dot(-r13.xyz, r12.xyz);
          r5.w = cmp(0 < r5.x);
          if (r5.w != 0) {
            r5.w = -r5.x * r5.x + 1;
            r5.w = sqrt(r5.w);
            r6.x = dot(r0.ww, r0.zz);
            r7.w = r6.x + -r1.x;
            r10.w = cmp(r7.w >= r5.w);
            if (r10.w != 0) {
              r12.y = abs(r0.w);
              r12.x = 1;
            } else {
              r10.w = -r7.w * r7.w + 1;
              r10.w = rsqrt(r10.w);
              r5.x = r10.w * r5.x;
              r10.w = -r7.w * r0.z + r0.w;
              r11.w = r10.w * r5.x;
              r12.z = r0.w * r0.w;
              r12.z = r12.z * 2 + -1;
              r7.w = -r7.w * r1.x + r12.z;
              r7.w = r7.w * r5.x;
              r12.z = -r0.z * r0.z + 1;
              r12.z = -r0.w * r0.w + r12.z;
              r12.z = -r1.x * r1.x + r12.z;
              r6.x = saturate(r6.x * r1.x + r12.z);
              r6.x = sqrt(r6.x);
              r6.x = r6.x * r5.x;
              r12.z = r6.x * r0.w;
              r12.w = r12.z + r12.z;
              r13.w = r0.z * r5.w + r0.w;
              r5.x = r5.x * r10.w + r13.w;
              r10.w = r1.x * r5.w + r7.w;
              r10.w = 1 + r10.w;
              r14.x = r10.w * r6.x;
              r14.y = r10.w * r5.x;
              r14.w = r12.w * r5.x;
              r12.z = r5.x * r12.z;
              r12.z = 0.5 * r12.z;
              r12.z = r14.x * -0.5 + r12.z;
              r12.z = r14.y * r12.z;
              r16.w = -r14.x * 2 + r14.w;
              r14.w = r16.w * r14.w;
              r14.x = r14.x * r14.x + r14.w;
              r14.w = r10.w * r10.w;
              r10.w = r1.x * r5.w + r10.w;
              r10.w = r10.w * -0.5 + -0.5;
              r10.w = r14.y * r10.w;
              r10.w = r13.w * r14.w + r10.w;
              r5.x = r5.x * r10.w + r14.x;
              r10.w = r12.z + r12.z;
              r13.w = r12.z * r12.z;
              r13.w = r5.x * r5.x + r13.w;
              r10.w = r10.w / r13.w;
              r5.x = r10.w * r5.x;
              r10.w = -r10.w * r12.z + 1;
              r6.x = r5.x * r6.x;
              r6.x = r10.w * r11.w + r6.x;
              r5.x = r5.x * r12.w;
              r5.x = r10.w * r7.w + r5.x;
              r6.x = r0.z * r5.w + r6.x;
              r5.x = r1.x * r5.w + r5.x;
              r5.w = r5.x * 2 + 2;
              r5.w = rsqrt(r5.w);
              r6.x = r6.x + r0.w;
              r12.x = saturate(r6.x * r5.w);
              r12.y = saturate(r5.w * r5.x + r5.w);
            }
          } else {
            r5.x = r1.x * 2 + 2;
            r5.x = rsqrt(r5.x);
            r5.w = r0.z + r0.w;
            r12.x = saturate(r5.w * r5.x);
            r12.y = saturate(r5.x * r1.x + r5.x);
          }
          r0.w = 9.99999975e-006 + abs(r0.w);
          r0.y = cmp(14.8499994 < r0.y);
          r1.x = r1.x * 0.5 + 0.5;
          r14.x = 0.25 * r1.x;
          r14.y = r1.x * 0.25 + 0.5;
          r18.z = 1;
          r5.xw = r0.yy ? r14.xy : r18.yz;
          r0.y = max(0, r0.z);
          r6.x = 1 + -r0.y;
          r0.y = saturate(r5.x * r6.x + r0.y);
          r12.zw = float2(1,1) + -r3.xz;
          r5.x = r5.x * r12.z + r3.x;
          r5.x = r5.x * r2.x;
          r14.xyw = float3(0.318309873,0.318309873,0.318309873) * r2.yzw;
          r18.xyz = r14.xyw * r0.yyy;
          r15.xyw = r18.xyz * r5.xxx;
          r9.xyw = r9.xyw * r3.www + -r13.xyz;
          r0.y = dot(r9.xyw, r9.xyw);
          r0.y = rsqrt(r0.y);
          r9.xyw = r9.xyw * r0.yyy;
          r0.y = dot(r4.yzw, r9.xyw);
          r1.x = 1 + -r1.x;
          r1.x = r1.x * r1.x;
          r1.x = r1.x * r1.x;
          r0.z = 1 + r0.z;
          r0.z = saturate(0.5 * r0.z);
          r3.w = r0.z * -2 + 3;
          r0.z = r0.z * r0.z;
          r0.z = r3.w * r0.z;
          r3.w = -0.449999988 * r1.x;
          r9.xyw = r1.xxx * float3(0.0500000119,0.600000024,-0.5) + float3(0.949999988,0.400000006,1.5);
          r6.x = r0.y * r9.x + -r0.y;
          r0.y = r0.y * r6.x + r3.w;
          r0.y = 1 + r0.y;
          r0.y = r0.y * r0.y;
          r0.y = 3.1415925 * r0.y;
          r0.y = r9.y / r0.y;
          r0.y = r0.y * r0.z;
          r0.y = r0.y * r9.w;
          r0.x = r0.x * 0.142857149 + -0.5;
          r0.x = saturate(r0.x * 2 + r1.x);
          r9.xyw = r10.xyz * r10.xyz + -r14.xyw;
          r9.xyw = r0.xxx * r9.xyw + r14.xyw;
          r0.x = r12.w * 0.100000001 + r3.z;
          r0.x = r0.x * r2.x;
          r0.z = min(r0.x, r5.x);
          r0.y = r0.z * r0.y + 0.300000012;
          r0.y = saturate(0.769230783 * r0.y);
          r0.z = r0.y * -2 + 3;
          r0.y = r0.y * r0.y;
          r0.y = r0.z * r0.y;
          r9.xyw = r9.xyw * r0.yyy;
          r0.x = r0.x * r5.w;
          r17.xyz = r9.xyw * r0.xxx;
          r0.x = max(9.99999975e-006, r1.z);
          r0.x = r0.x * r0.x;
          r0.y = r0.x * r0.x;
          r0.z = cmp(0 < r5.y);
          r1.x = r5.y * r5.y;
          r1.z = r12.y * 3.5999999 + 0.400000006;
          r1.x = r1.x / r1.z;
          r0.x = r0.x * r0.x + r1.x;
          r0.xw = min(float2(1,1), r0.xw);
          r0.x = r0.z ? r0.x : r0.y;
          r0.y = r12.x * r0.x + -r12.x;
          r0.y = r0.y * r12.x + 1;
          r0.y = r0.y * r0.y;
          r0.y = 3.14159274 * r0.y;
          r0.y = r0.x / r0.y;
          r0.x = sqrt(r0.x);
          r0.z = 1 + -r0.x;
          r1.x = r0.w * r0.z + r0.x;
          r0.x = r14.z * r0.z + r0.x;
          r0.x = r0.w * r0.x;
          r0.x = r14.z * r1.x + r0.x;
          r0.x = rcp(r0.x);
          r0.x = r0.y * r0.x;
          r0.y = 1 + -r12.y;
          r0.z = r0.y * r0.y;
          r0.z = r0.z * r0.z;
          r0.w = r0.z * r0.y;
          r0.y = -r0.z * r0.y + 1;
          r0.y = r0.y * 0.0399999991 + r0.w;
          r0.x = r0.y * r0.x;
          r0.x = r0.x * r14.z;
          r0.x = r3.x * r0.x;
          r16.xyz = float3(0.5,0.5,0.5) * r0.xxx;
        }
        break;
        default:
        r15.xyw = float3(0,0,0);
        r16.xyz = float3(0,0,0);
        r17.xyz = float3(0,0,0);
        break;
      }
      r0.xyz = cb1[7].www * r16.xyz;
      r1.xz = r3.yy ? float2(1,1) : r7.xz;
      r3.xzw = r0.xyz * r8.www;
      r3.xzw = float3(0.399999976,0.399999976,0.399999976) * r3.xzw;
      r0.xyz = r0.xyz * float3(0.600000024,0.600000024,0.600000024) + r3.xzw;
      r3.xzw = cmp((int3)r1.www != int3(6,4,7));
      r0.w = r3.z ? r3.x : 0;
      r0.w = r3.w ? r0.w : 0;
      r1.w = min(1, r15.z);
      r1.w = r1.x / r1.w;
      r2.x = cmp(cb1[4].x >= r1.w);
      r3.x = r1.w / cb1[4].x;
      r3.xzw = cb1[4].yzw * r3.xxx;
      r1.w = -cb1[4].x + r1.w;
      r10.xyzw = float4(1,1,1,1) + -cb1[4].xyzw;
      r1.w = r1.w / r10.x;
      r5.xyw = r1.www * r10.yzw + cb1[4].yzw;
      r3.xzw = r2.xxx ? r3.xzw : r5.xyw;
      r3.xzw = r3.xzw * r15.zzz;
      r3.xzw = r0.www ? r3.xzw : r1.xxx;
      r3.xzw = r11.xyz * r3.xzw;
      r1.xyw = r3.xzw * r1.yyy;
      r0.w = cmp(cb0[220].z == 0.000000);
      r3.xzw = r15.xyw * r1.xyw;
      r2.x = dot(r3.xzw, float3(0.300000012,0.589999974,0.109999999));
      r2.x = r0.w ? r2.x : 0;
      r2.x = r9.z ? r2.x : 0;
      r10.xyz = r1.xyw * r0.xyz;
      r0.xyz = r11.xyz * r1.zzz;
      r0.xyz = r17.xyz * r0.xyz;
      r1.z = dot(r0.xyz, float3(0.300000012,0.589999974,0.109999999));
      r1.z = r2.x + r1.z;
      r0.w = r0.w ? r1.z : r2.x;
      r0.w = r9.z ? r0.w : 0;
      r1.xyz = r15.xyw * r1.xyw + r0.xyz;
    } else {
      r1.xyz = float3(0,0,0);
      r10.xyz = float3(0,0,0);
      r0.w = 0;
    }
    if (r3.y != 0) {
      r0.x = dot(r4.yzw, cb1[7].xyz);
      r0.yz = cb0[21].xy * r4.zz;
      r0.yz = r4.yy * cb0[20].xy + r0.yz;
      r3.xy = r4.ww * cb0[22].xy + r0.yz;
      r3.z = -r3.y;
      r0.y = dot(r3.xz, r3.xz);
      r0.y = rsqrt(r0.y);
      r0.yz = r3.xz * r0.yy;
      r0.x = 0.5 + r0.x;
      r0.x = saturate(0.666666687 * r0.x);
      r2.x = r0.x * -2 + 3;
      r0.x = r0.x * r0.x;
      r0.x = r2.x * r0.x;
      r0.x = min(1, r0.x);
      r2.x = saturate(r4.x / cb0[269].x);
      r3.x = cb0[138].y / cb0[138].x;
      r3.y = 1;
      r0.yz = r3.xy * r0.yz;
      r0.yz = cb0[266].xx * r0.yz;
      r2.x = log2(r2.x);
      r2.x = 0.449999988 * r2.x;
      r2.x = exp2(r2.x);
      r3.x = -1 + cb0[266].z;
      r2.x = r2.x * r3.x + 1;
      r0.yz = r0.yz * r2.xx + v0.xy;
      r0.y = tex2D(_IN1, r0.yz).x;
      r0.z = r0.y * cb0[65].x + cb0[65].y;
      r0.y = r0.y * cb0[65].z + -cb0[65].w;
      r0.y = 1 / r0.y;
      r0.y = r0.z + r0.y;
      r0.y = r0.y + -r4.x;
      r0.y = saturate(r0.y / cb0[266].y);
      r0.z = r0.y * r0.y;
      r0.y = r0.y * r0.z;
      r3.xyz = float3(0.5,0.5,0.5) * cb0[193].xyz;
      r0.x = r7.x * r0.x;
      r5.xyw = -cb0[193].xyz * float3(0.5,0.5,0.5) + r11.xyz;
      r3.xyz = r0.xxx * r5.xyw + r3.xyz;
      r0.xyz = r3.xyz * r0.yyy;
      r0.xyz = cb0[267].xyz * r0.xyz;
      r10.xyz = r0.xyz * r8.xyz + r10.xyz;
    } else {
      if (r5.z != 0) {
        r0.x = cmp(9.99999975e-005 < r7.y);
        if (r0.x != 0) {
          r0.x = saturate(dot(r4.yzw, cb1[7].xyz));
          r3.xyz = float3(1,1,0.5) * cb1[7].xyz;
          r0.y = dot(r3.xyz, r3.xyz);
          r0.y = rsqrt(r0.y);
          r3.xyz = r3.xyz * r0.yyy;
          r0.y = dot(-r13.xyz, r3.xyz);
          r3.xy = cb0[21].xy * r4.zz;
          r3.xy = r4.yy * cb0[20].xy + r3.xy;
          r3.xy = r4.ww * cb0[22].xy + r3.xy;
          r3.z = -r3.y;
          r0.z = dot(r3.xz, r3.xz);
          r0.z = rsqrt(r0.z);
          r3.xy = r3.xz * r0.zz;
          r0.z = 0.00999999978 * r7.y;
          r2.x = saturate(r4.x / cb0[269].x);
          r5.x = cb0[138].y / cb0[138].x;
          r5.y = 1;
          r3.zw = r5.xy * r0.xx;
          r3.xy = r3.zw * r3.xy;
          r3.xy = r3.xy * r0.zz;
          r0.z = log2(r2.x);
          r0.z = 0.449999988 * r0.z;
          r0.z = exp2(r0.z);
          r2.x = -1 + cb0[266].z;
          r0.z = r0.z * r2.x + 1;
          r3.xy = r3.xy * r0.zz + v0.xy;
          r0.z = tex2D(_IN1, r3.xy).x;
          r2.x = r0.z * cb0[65].x + cb0[65].y;
          r0.z = r0.z * cb0[65].z + -cb0[65].w;
          r0.z = 1 / r0.z;
          r0.z = r2.x + r0.z;
          r0.z = r0.z + -r4.x;
          r0.z = saturate(r0.z / cb0[266].y);
          r2.x = r0.z * r0.z;
          r0.z = r2.x * r0.z;
          r0.x = r7.x * r0.x;
          r3.xyz = r0.xxx * r11.xyz;
          r3.xyz = r3.xyz * r0.zzz;
          r3.xyz = cb0[267].xyz * r3.xyz;
          r0.y = saturate(-r0.y);
          r0.xyz = r6.yzw * r0.yyy + r2.yzw;
          r10.xyz = r3.xyz * r0.xyz + r10.xyz;
        }
      }
    }
    r0.x = cmp(cb0[220].z == 0.000000);
    r1.w = r0.x ? r0.w : 0;
    r10.w = 0;
    r0.xyzw = r10.xyzw + r1.xyzw;
    r1.x = dot(r0.xyz, float3(0.298999995,0.587000012,0.114));
    r1.xyz = r1.xxx + -r0.xyz;
    r0.xyz = cb0[252].zzz * r1.xyz + r0.xyz;
    o0.xyz = cb0[250].xyz * r0.xyz;
    o0.w = r0.w;
  } else {
    o0.xyzw = float4(0,0,0,0);
  }
  return o0;
}

            ENDHLSL
        }
    }
}