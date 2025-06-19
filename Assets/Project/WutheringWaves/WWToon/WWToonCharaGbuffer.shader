 Shader "Custom/WWToonCharaGBuffer"
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
    float4 positionOS   : POSITION;
    float2 uv           : TEXCOORD0;
};

struct Varyings
{
    float4 positionCS   : SV_POSITION;
    float4 uv           : TEXCOORD0;
};
            
            TEXTURE2D(_IN0); SAMPLER(sampler_IN0);
            TEXTURE2D(_IN1); SAMPLER(sampler_IN1);
            TEXTURE2D(_IN2); SAMPLER(sampler_IN2);
            TEXTURE2D(_IN3); SAMPLER(sampler_IN3);
            TEXTURE2D(_IN4); SAMPLER(sampler_IN4);

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
            float4 _FrameJitterSeed;
            
            Varyings vert (Attributes vertexInput)
            {
                Varyings vertOutput;
                vertOutput.positionCS = TransformObjectToHClip(vertexInput.positionOS.xyz);
                vertOutput.uv.xy = vertexInput.uv;
                float2 ndc = vertOutput.positionCS.xy / vertOutput.positionCS.w;
                vertOutput.uv.zw = ndc;
                return vertOutput;
            }
            
            StructuredBuffer<float4> cb0;
            StructuredBuffer<float4> cb1;
            StructuredBuffer<float4> cb2;
            StructuredBuffer<float4> cb3;
            StructuredBuffer<float4> cb4;
            
            struct FragOutput
            {
                float4 o0_GI : SV_Target0;
                float4 o1_Normal_Diffuse_FaceSDFMask : SV_Target1;
                float4 o2_ShadowColor_PackShadeMode_OutputMask : SV_Target2;
                float4 o3_BaseColor_ToonSkinMask : SV_Target3;
                float4 o4 : SV_Target4;
                float4 o5_RimDepth : SV_Target5;
                float4 o6_rimStrength_HSVPack_groundSpec_charRegion : SV_Target6;
            };

FragOutput frag (Varyings fragmentInput)
{
    float4 fragInput_UvAndNdc = fragmentInput.uv;
    float4 fragInput_ClipPos = fragmentInput.positionCS;
    float4 fragInput_UvAndNdc_Copy = fragmentInput.uv;

    float4 placeholder_Tangent = 0;
    float4 placeholder_TexCoord1 = 0;
    float2 placeholder_TexCoord2 = 0;
    float4 placeholder_ScreenPos = 0;
    
    FragOutput fragOutput;
    float4 gBuffer_GI, gBuffer_Normal, gBuffer_Shadow, gBuffer_BaseColor, gBuffer_MotionVectors, gBuffer_RimDepth, gBuffer_RimAndMasks;
    float4 normalAndLightingCalcs,worldPosAndFlags,viewDirAndShading,texSampleAndColor,maskingAndConditions,baseColorAndSss,litColorAndConstants,lightParamsAndGI,lightDirAndDiffuse,lightVecsAndHair,lightVecsAndOutline,matcapAndGI,matcapCoordHelper;
    uint4 bitmask, unused_UintDest;
    float4 unused_FloatDest;

  normalAndLightingCalcs.xyz = placeholder_Tangent.zxy * fragInput_UvAndNdc.yzx;
  normalAndLightingCalcs.xyz = placeholder_Tangent.yzx * fragInput_UvAndNdc.zxy + -normalAndLightingCalcs.xyz;
  normalAndLightingCalcs.xyz = placeholder_Tangent.www * normalAndLightingCalcs.xyz;
  worldPosAndFlags.xyzw = cb0[45].xyzw * fragInput_ClipPos.yyyy;
  worldPosAndFlags.xyzw = fragInput_ClipPos.xxxx * cb0[44].xyzw + worldPosAndFlags.xyzw;
  worldPosAndFlags.xyzw = fragInput_ClipPos.zzzz * cb0[46].xyzw + worldPosAndFlags.xyzw;
  worldPosAndFlags.xyzw = cb0[47].xyzw + worldPosAndFlags.xyzw;
  worldPosAndFlags.xyz = worldPosAndFlags.xyz / worldPosAndFlags.www;
  normalAndLightingCalcs.w = dot(-worldPosAndFlags.xyz, -worldPosAndFlags.xyz);
  normalAndLightingCalcs.w = rsqrt(normalAndLightingCalcs.w);
  viewDirAndShading.xyz = -worldPosAndFlags.xyz * normalAndLightingCalcs.www;
  texSampleAndColor.xyzw = _IN0.SampleBias(sampler_IN0, fragInput_UvAndNdc_Copy.xy, cb0[149].y).xyzw;
  texSampleAndColor.xy = texSampleAndColor.xy * float2(2,2) + float2(-1,-1);
  texSampleAndColor.xy = cb4[64].ww * texSampleAndColor.xy;
  normalAndLightingCalcs.xyz = texSampleAndColor.yyy * normalAndLightingCalcs.xyz;
  normalAndLightingCalcs.xyz = texSampleAndColor.xxx * fragInput_UvAndNdc.xyz + normalAndLightingCalcs.xyz;
  normalAndLightingCalcs.xyz = placeholder_Tangent.xyz + normalAndLightingCalcs.xyz;
  worldPosAndFlags.w = 1 + -cb0[144].w;
  maskingAndConditions.xyz = placeholder_Tangent.xyz * worldPosAndFlags.www;
  normalAndLightingCalcs.xyz = normalAndLightingCalcs.xyz * cb0[144].www + maskingAndConditions.xyz;
  worldPosAndFlags.w = dot(normalAndLightingCalcs.xyz, normalAndLightingCalcs.xyz);
  worldPosAndFlags.w = rsqrt(worldPosAndFlags.w);
  normalAndLightingCalcs.xyz = worldPosAndFlags.www * normalAndLightingCalcs.xyz;
  texSampleAndColor.xy = _IN1.SampleLevel(sampler_IN1, fragInput_UvAndNdc_Copy.xy, cb0[149].y).xy;
  maskingAndConditions.xyzw = (texSampleAndColor.xxxx >= float4(0.0500000007,0.300000012,0.5,0.899999976));
  maskingAndConditions.xyzw = maskingAndConditions.xyzw ? float4(1,1,1,1) : 0;
  baseColorAndSss.xyzw = (float4(0.0500000007,0.300000012,0.5,0.899999976) >= texSampleAndColor.xxxx);
  baseColorAndSss.yzw = baseColorAndSss.yzw ? float3(1,1,1) : 0;
  maskingAndConditions.yz = baseColorAndSss.zw * maskingAndConditions.yz;
  worldPosAndFlags.w = -maskingAndConditions.x * baseColorAndSss.y + 1;
  worldPosAndFlags.w = baseColorAndSss.x ? 1 : worldPosAndFlags.w;
  worldPosAndFlags.w = -maskingAndConditions.y * worldPosAndFlags.w + 1;
  viewDirAndShading.w = maskingAndConditions.z * worldPosAndFlags.w;
  worldPosAndFlags.w = -maskingAndConditions.z * worldPosAndFlags.w + 1;
  worldPosAndFlags.w = maskingAndConditions.w * worldPosAndFlags.w;
  texSampleAndColor.x = (cb4[65].y >= 0.5);
  worldPosAndFlags.w = texSampleAndColor.x ? worldPosAndFlags.w : cb4[65].x;
  texSampleAndColor.x = 1 + -worldPosAndFlags.w;
  worldPosAndFlags.w = cb4[65].z * texSampleAndColor.x + worldPosAndFlags.w;
  maskingAndConditions.xyz = float3(-1,-1,-1) + cb4[4].xyz;
  maskingAndConditions.xyz = worldPosAndFlags.www * maskingAndConditions.xyz + float3(1,1,1);
  baseColorAndSss.xyzw = _IN2.SampleBias(sampler_IN2, fragInput_UvAndNdc_Copy.xy, cb0[149].y).xyzw;
  baseColorAndSss.xyz = cb4[6].xyz * baseColorAndSss.xyz;
  litColorAndConstants.xyz = baseColorAndSss.xyz * maskingAndConditions.xyz;
  texSampleAndColor.x = cb4[65].w * texSampleAndColor.z;
  texSampleAndColor.z = cb4[66].x * texSampleAndColor.w;
  maskingAndConditions.w = saturate(dot(normalAndLightingCalcs.xyz, viewDirAndShading.xyz));
  litColorAndConstants.w = (2.98023295e-008 >= texSampleAndColor.z);
  lightParamsAndGI.x = log2(texSampleAndColor.z);
  lightParamsAndGI.x = 0.100000001 * lightParamsAndGI.x;
  lightParamsAndGI.x = exp2(lightParamsAndGI.x);
  litColorAndConstants.w = litColorAndConstants.w ? 0 : lightParamsAndGI.x;
  lightParamsAndGI.x = 1 + -litColorAndConstants.w;
  lightParamsAndGI.x = lightParamsAndGI.x * 19.8999996 + 0.100000001;
  litColorAndConstants.w = litColorAndConstants.w * -999 + 1000;
  lightParamsAndGI.y = (texSampleAndColor.x >= 0.850000024);
  lightParamsAndGI.y = lightParamsAndGI.y ? 1.000000 : 0;
  lightParamsAndGI.z = cb4[66].y + -cb4[66].z;
  lightParamsAndGI.z = lightParamsAndGI.y * lightParamsAndGI.z + cb4[66].z;
  lightDirAndDiffuse.xyz = -cb3[36].xyz + cb3[17].xyz;
  lightDirAndDiffuse.xyz = cb4[67].yyy * lightDirAndDiffuse.xyz;
  lightParamsAndGI.w = (cb4[66].w >= 0.5);
  lightParamsAndGI.w = lightParamsAndGI.w ? 1.000000 : 0;
  lightDirAndDiffuse.xyz = lightParamsAndGI.www * lightDirAndDiffuse.xyz + cb3[36].xyz;
  lightParamsAndGI.w = dot(lightDirAndDiffuse.xyz, lightDirAndDiffuse.xyz);
  lightParamsAndGI.w = sqrt(lightParamsAndGI.w);
  lightDirAndDiffuse.xyz = lightDirAndDiffuse.xyz / lightParamsAndGI.www;
  lightVecsAndHair.xyz = cb4[8].xyz + cb2[5].xyz;
  lightVecsAndOutline.xyz = cb1[0].xyz + -lightVecsAndHair.xyz;
  lightParamsAndGI.w = dot(lightVecsAndOutline.xyz, lightVecsAndOutline.xyz);
  lightParamsAndGI.w = sqrt(lightParamsAndGI.w);
  lightVecsAndOutline.xyz = lightVecsAndOutline.xyz / lightParamsAndGI.www;
  lightVecsAndHair.xyz = -cb1[0].xyz + lightVecsAndHair.xyz;
  lightParamsAndGI.w = dot(lightVecsAndHair.xyz, lightVecsAndHair.xyz);
  lightParamsAndGI.w = sqrt(lightParamsAndGI.w);
  lightParamsAndGI.w = saturate(cb1[0].w * lightParamsAndGI.w);
  lightVecsAndHair.xyz = -lightVecsAndOutline.xyz + lightDirAndDiffuse.xyz;
  lightVecsAndHair.xyz = lightParamsAndGI.www * lightVecsAndHair.xyz + lightVecsAndOutline.xyz;
  lightVecsAndHair.xyz = lightVecsAndHair.xyz + -lightDirAndDiffuse.xyz;
  lightDirAndDiffuse.xyz = cb1[1].zzz * lightVecsAndHair.xyz + lightDirAndDiffuse.xyz;
  lightParamsAndGI.w = saturate(cb2[27].y);
  lightVecsAndHair.xy = placeholder_TexCoord1.xy;
  lightVecsAndHair.z = placeholder_TexCoord2.x;
  lightVecsAndHair.xyz = lightVecsAndHair.xyz + -lightDirAndDiffuse.xyz;
  lightDirAndDiffuse.xyz = lightParamsAndGI.www * lightVecsAndHair.xyz + lightDirAndDiffuse.xyz;
  lightParamsAndGI.w = dot(lightDirAndDiffuse.xyz, lightDirAndDiffuse.xyz);
  lightParamsAndGI.w = sqrt(lightParamsAndGI.w);
  lightDirAndDiffuse.xyz = lightDirAndDiffuse.xyz / lightParamsAndGI.www;
  viewDirAndShading.x = dot(lightDirAndDiffuse.xyz, viewDirAndShading.xyz);
  viewDirAndShading.y = 1 + -abs(viewDirAndShading.z);
  viewDirAndShading.x = viewDirAndShading.x * viewDirAndShading.y + 1;
  viewDirAndShading.x = 0.5 * viewDirAndShading.x;
  viewDirAndShading.y = -cb4[68].x + cb4[67].w;
  viewDirAndShading.x = viewDirAndShading.x * viewDirAndShading.y + cb4[68].x;
  viewDirAndShading.y = 1 + -maskingAndConditions.w;
  viewDirAndShading.x = viewDirAndShading.x * viewDirAndShading.y + cb4[68].y;
  viewDirAndShading.y = -cb4[68].z + viewDirAndShading.x;
  viewDirAndShading.z = cb4[68].z + viewDirAndShading.x;
  maskingAndConditions.w = cb4[68].w * baseColorAndSss.w;
  baseColorAndSss.w = max(0, maskingAndConditions.w);
  baseColorAndSss.w = min(cb4[69].x, baseColorAndSss.w);
  baseColorAndSss.w = baseColorAndSss.w / cb4[69].x;
  lightParamsAndGI.w = max(cb4[69].y, maskingAndConditions.w);
  lightParamsAndGI.w = min(1, lightParamsAndGI.w);
  lightParamsAndGI.w = -cb4[69].y + lightParamsAndGI.w;
  lightVecsAndHair.xy = float2(1,1) + -cb4[69].yz;
  lightParamsAndGI.w = lightParamsAndGI.w / lightVecsAndHair.x;
  lightDirAndDiffuse.w = -cb4[69].z + baseColorAndSss.w;
  lightVecsAndHair.x = 1 / lightVecsAndHair.y;
  lightDirAndDiffuse.w = saturate(lightVecsAndHair.x * lightDirAndDiffuse.w);
  lightVecsAndHair.x = lightDirAndDiffuse.w * -2 + 3;
  lightDirAndDiffuse.w = lightDirAndDiffuse.w * lightDirAndDiffuse.w;
  lightDirAndDiffuse.w = lightVecsAndHair.x * lightDirAndDiffuse.w;
  lightDirAndDiffuse.w = cb4[69].w * lightDirAndDiffuse.w;
  lightVecsAndHair.x = (2.98023295e-008 >= lightDirAndDiffuse.w);
  lightDirAndDiffuse.w = log2(lightDirAndDiffuse.w);
  lightDirAndDiffuse.w = cb4[70].x * lightDirAndDiffuse.w;
  lightDirAndDiffuse.w = exp2(lightDirAndDiffuse.w);
  lightDirAndDiffuse.w = cb4[70].y * lightDirAndDiffuse.w;
  lightDirAndDiffuse.w = lightVecsAndHair.x ? 0 : lightDirAndDiffuse.w;
  lightVecsAndHair.x = dot(normalAndLightingCalcs.xyz, lightDirAndDiffuse.xyz);
  lightDirAndDiffuse.w = lightVecsAndHair.x * 0.5 + lightDirAndDiffuse.w;
  lightDirAndDiffuse.w = 0.5 + lightDirAndDiffuse.w;
  viewDirAndShading.z = viewDirAndShading.z + -viewDirAndShading.y;
  viewDirAndShading.y = lightDirAndDiffuse.w + -viewDirAndShading.y;
  viewDirAndShading.z = 1 / viewDirAndShading.z;
  viewDirAndShading.y = saturate(viewDirAndShading.y * viewDirAndShading.z);
  viewDirAndShading.z = viewDirAndShading.y * -2 + 3;
  viewDirAndShading.y = viewDirAndShading.y * viewDirAndShading.y;
  viewDirAndShading.y = viewDirAndShading.z * viewDirAndShading.y;
  viewDirAndShading.z = min(cb4[69].z, baseColorAndSss.w);
  viewDirAndShading.z = viewDirAndShading.z / cb4[70].z;
  baseColorAndSss.w = max(0.899999976, viewDirAndShading.z);
  baseColorAndSss.w = min(1, baseColorAndSss.w);
  baseColorAndSss.w = -0.899999976 + baseColorAndSss.w;
  viewDirAndShading.y = baseColorAndSss.w * viewDirAndShading.y;
  baseColorAndSss.w = (viewDirAndShading.y >= 0.0400000066);
  lightVecsAndHair.x = baseColorAndSss.w ? 1.000000 : 0;
  lightVecsAndHair.yzw = lightVecsAndHair.xxx * lightDirAndDiffuse.xyz;
  lightVecsAndHair.yzw = float3(2,2,0) * lightVecsAndHair.yzw;
  lightVecsAndHair.yzw = lightDirAndDiffuse.xyz * float3(-1,-1,1) + lightVecsAndHair.yzw;
  lightVecsAndHair.yzw = -worldPosAndFlags.xyz * normalAndLightingCalcs.www + lightVecsAndHair.yzw;
  lightVecsAndOutline.x = dot(lightVecsAndHair.yzw, lightVecsAndHair.yzw);
  lightVecsAndOutline.x = sqrt(lightVecsAndOutline.x);
  lightVecsAndHair.yzw = lightVecsAndHair.yzw / lightVecsAndOutline.xxx;
  lightVecsAndHair.y = saturate(dot(lightVecsAndHair.yzw, normalAndLightingCalcs.xyz));
  lightDirAndDiffuse.xyz = -worldPosAndFlags.xyz * normalAndLightingCalcs.www + lightDirAndDiffuse.xyz;
  normalAndLightingCalcs.w = dot(lightDirAndDiffuse.xyz, lightDirAndDiffuse.xyz);
  normalAndLightingCalcs.w = sqrt(normalAndLightingCalcs.w);
  lightDirAndDiffuse.xyz = lightDirAndDiffuse.xyz / normalAndLightingCalcs.www;
  normalAndLightingCalcs.w = saturate(dot(normalAndLightingCalcs.xyz, lightDirAndDiffuse.xyz));
  normalAndLightingCalcs.w = normalAndLightingCalcs.w + -lightVecsAndHair.y;
  normalAndLightingCalcs.w = lightParamsAndGI.y * normalAndLightingCalcs.w + lightVecsAndHair.y;
  normalAndLightingCalcs.w = log2(normalAndLightingCalcs.w);
  normalAndLightingCalcs.w = litColorAndConstants.w * normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = exp2(normalAndLightingCalcs.w);
  normalAndLightingCalcs.w = normalAndLightingCalcs.w * lightParamsAndGI.z;
  litColorAndConstants.w = 2 + lightParamsAndGI.z;
  normalAndLightingCalcs.w = litColorAndConstants.w * normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = normalAndLightingCalcs.w * 0.159154937 + -0.600000024;
  normalAndLightingCalcs.w = saturate(0.833333373 * normalAndLightingCalcs.w);
  litColorAndConstants.w = normalAndLightingCalcs.w * -2 + 3;
  normalAndLightingCalcs.w = normalAndLightingCalcs.w * normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = litColorAndConstants.w * normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = lightParamsAndGI.x * normalAndLightingCalcs.w;
  litColorAndConstants.w = texSampleAndColor.x * 0.5 + 0.5;
  lightDirAndDiffuse.xyz = litColorAndConstants.xyz * texSampleAndColor.xxx;
  litColorAndConstants.w = 0.0799999982 * litColorAndConstants.w;
  lightVecsAndHair.yzw = maskingAndConditions.xyz * baseColorAndSss.xyz + -litColorAndConstants.www;
  lightVecsAndHair.yzw = texSampleAndColor.xxx * lightVecsAndHair.yzw + litColorAndConstants.www;
  lightVecsAndOutline.xyzw = texSampleAndColor.zzzz * float4(-1,-0.0274999999,-0.572000027,0.0219999999) + float4(1,0.0425000004,1.03999996,-0.0399999991);
  texSampleAndColor.x = lightVecsAndOutline.x * lightVecsAndOutline.x;
  texSampleAndColor.x = min(0.00160857651, texSampleAndColor.x);
  texSampleAndColor.x = texSampleAndColor.x * lightVecsAndOutline.x + lightVecsAndOutline.y;
  lightParamsAndGI.xz = texSampleAndColor.xx * float2(-1.03999996,1.03999996) + lightVecsAndOutline.zw;
  texSampleAndColor.x = saturate(50 * lightVecsAndHair.z);
  texSampleAndColor.x = lightParamsAndGI.z * texSampleAndColor.x;
  lightVecsAndOutline.xyz = lightVecsAndHair.yzw * lightParamsAndGI.xxx + texSampleAndColor.xxx;
  lightVecsAndHair.yzw = cb4[71].xxx * lightVecsAndHair.yzw;
  matcapAndGI.xyz = lightVecsAndHair.yzw * normalAndLightingCalcs.www;
  lightVecsAndOutline.xyz = cb4[71].xxx * lightVecsAndOutline.xyz;
  lightDirAndDiffuse.xyz = cb4[71].xxx * -lightDirAndDiffuse.xyz + litColorAndConstants.xyz;
  matcapAndGI.xyz = matcapAndGI.xyz * lightParamsAndGI.yyy;
  matcapAndGI.xyz = cb4[71].yyy * matcapAndGI.xyz;
  viewDirAndShading.w = max(worldPosAndFlags.w, viewDirAndShading.w);
  viewDirAndShading.w = 1 + -viewDirAndShading.w;
  texSampleAndColor.x = -texSampleAndColor.w * cb4[66].x + 1;
  texSampleAndColor.x = (texSampleAndColor.x >= 0.00999999978);
  texSampleAndColor.x = texSampleAndColor.x ? 1.000000 : 0;
  viewDirAndShading.w = texSampleAndColor.x * viewDirAndShading.w;
  lightParamsAndGI.xzw = lightParamsAndGI.www * litColorAndConstants.xyz;
  lightParamsAndGI.xzw = cb4[10].xyz * lightParamsAndGI.xzw;
  lightParamsAndGI.xzw = viewDirAndShading.www * matcapAndGI.xyz + lightParamsAndGI.xzw;
  lightParamsAndGI.xzw = placeholder_TexCoord2.yyy * cb4[45].xyz + lightParamsAndGI.xzw;
  matcapAndGI.xyz = cb4[46].xyz + -lightParamsAndGI.xzw;
  lightParamsAndGI.xzw = cb4[83].yyy * matcapAndGI.xyz + lightParamsAndGI.xzw;
  lightDirAndDiffuse.xyz = lightVecsAndHair.yzw * normalAndLightingCalcs.www + lightDirAndDiffuse.xyz;
  matcapAndGI.xyzw = cb0[13].yzzx * worldPosAndFlags.yyyy;
  matcapAndGI.xyzw = worldPosAndFlags.xxxx * cb0[12].yzzx + matcapAndGI.xyzw;
  matcapAndGI.xyzw = worldPosAndFlags.zzzz * cb0[14].yzzx + matcapAndGI.xyzw;
  matcapAndGI.xyzw = cb0[15].yzzx + matcapAndGI.xyzw;
  normalAndLightingCalcs.w = dot(matcapAndGI.xzw, matcapAndGI.xzw);
  normalAndLightingCalcs.w = sqrt(normalAndLightingCalcs.w);
  matcapAndGI.xyzw = matcapAndGI.xyzw / normalAndLightingCalcs.wwww;
  matcapCoordHelper.xyzw = cb0[13].zxyz * normalAndLightingCalcs.yyyy;
  matcapCoordHelper.xyzw = normalAndLightingCalcs.xxxx * cb0[12].zxyz + matcapCoordHelper.xyzw;
  matcapCoordHelper.xyzw = normalAndLightingCalcs.zzzz * cb0[14].zxyz + matcapCoordHelper.xyzw;
  texSampleAndColor.xw = matcapCoordHelper.zw * matcapAndGI.zw;
  texSampleAndColor.xw = matcapAndGI.yx * matcapCoordHelper.yx + -texSampleAndColor.wx;
  texSampleAndColor.xw = texSampleAndColor.xw * float2(0.5,0.5) + float2(0.5,0.5);
  matcapAndGI.xyzw = _IN3.SampleBias(sampler_IN3, texSampleAndColor.xw, cb0[149].y).xyzw;
  normalAndLightingCalcs.w = 3 * texSampleAndColor.z;
  normalAndLightingCalcs.w = saturate(normalAndLightingCalcs.w);
  texSampleAndColor.x = matcapAndGI.y + -matcapAndGI.x;
  normalAndLightingCalcs.w = normalAndLightingCalcs.w * texSampleAndColor.x + matcapAndGI.x;
  texSampleAndColor.xz = saturate(texSampleAndColor.zz * float2(3,3) + float2(-1,-2));
  texSampleAndColor.w = matcapAndGI.z + -normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = texSampleAndColor.x * texSampleAndColor.w + normalAndLightingCalcs.w;
  texSampleAndColor.x = matcapAndGI.w + -normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = texSampleAndColor.z * texSampleAndColor.x + normalAndLightingCalcs.w;
  texSampleAndColor.x = cb4[83].z + -cb4[83].w;
  texSampleAndColor.x = lightParamsAndGI.y * texSampleAndColor.x + cb4[83].w;
  texSampleAndColor.z = baseColorAndSss.w ? 0 : 1;
  texSampleAndColor.w = texSampleAndColor.x * texSampleAndColor.z;
  baseColorAndSss.w = cb4[84].x + -cb4[83].w;
  baseColorAndSss.w = lightParamsAndGI.y * baseColorAndSss.w + cb4[83].w;
  texSampleAndColor.x = -texSampleAndColor.x * texSampleAndColor.z + baseColorAndSss.w;
  texSampleAndColor.x = lightVecsAndHair.x * texSampleAndColor.x + texSampleAndColor.w;
  normalAndLightingCalcs.w = texSampleAndColor.x * normalAndLightingCalcs.w;
  texSampleAndColor.xzw = lightVecsAndOutline.xyz * normalAndLightingCalcs.www + lightDirAndDiffuse.xyz;
  texSampleAndColor.xzw = -maskingAndConditions.xyz * baseColorAndSss.xyz + texSampleAndColor.xzw;
  texSampleAndColor.xzw = viewDirAndShading.www * texSampleAndColor.xzw + litColorAndConstants.xyz;
  maskingAndConditions.xyz = cb4[84].zzz * texSampleAndColor.xzw;
  normalAndLightingCalcs.w = max(0, lightDirAndDiffuse.w);
  normalAndLightingCalcs.w = min(cb4[85].z, normalAndLightingCalcs.w);
  viewDirAndShading.w = lightDirAndDiffuse.w + -normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = viewDirAndShading.z * viewDirAndShading.w + normalAndLightingCalcs.w;
  normalAndLightingCalcs.w = 0.5 + normalAndLightingCalcs.w;
  baseColorAndSss.x = saturate(normalAndLightingCalcs.w + -viewDirAndShading.x);
  normalAndLightingCalcs.w = 0.100000001 + -cb4[85].w;
  baseColorAndSss.y = worldPosAndFlags.w * normalAndLightingCalcs.w + cb4[85].w;
  baseColorAndSss.xyz = _IN4.SampleBias(sampler_IN4, baseColorAndSss.xy, cb0[149].y).xyz;
  normalAndLightingCalcs.w = (cb3[1].w >= 0.0500000007);
  normalAndLightingCalcs.w = normalAndLightingCalcs.w ? 1.000000 : 0;
  normalAndLightingCalcs.w = texSampleAndColor.y * normalAndLightingCalcs.w;
  texSampleAndColor.xyz = -cb4[84].zzz * texSampleAndColor.xzw + baseColorAndSss.xyz;
  litColorAndConstants.xyz = maskingAndConditions.xyz + maskingAndConditions.xyz;
  texSampleAndColor.xyz = normalAndLightingCalcs.www * texSampleAndColor.xyz + litColorAndConstants.xyz;
  texSampleAndColor.xyz = texSampleAndColor.xyz * float3(0.5,0.5,0.5) + -maskingAndConditions.xyz;
  texSampleAndColor.xyz = worldPosAndFlags.www * texSampleAndColor.xyz + maskingAndConditions.xyz;
  viewDirAndShading.x = dot(texSampleAndColor.xyz, float3(0.300000012,0.589999974,0.109999999));
  maskingAndConditions.xyz = viewDirAndShading.xxx + -texSampleAndColor.xyz;
  gBuffer_BaseColor.xyz = cb4[86].xxx * maskingAndConditions.xyz + texSampleAndColor.xyz;
  texSampleAndColor.xyz = -cb4[62].xyz + cb4[61].xyz;
  texSampleAndColor.xyz = worldPosAndFlags.www * texSampleAndColor.xyz + cb4[62].xyz;
  maskingAndConditions.xyz = baseColorAndSss.xyz + -texSampleAndColor.xyz;
  texSampleAndColor.xyz = normalAndLightingCalcs.www * maskingAndConditions.xyz + texSampleAndColor.xyz;
  normalAndLightingCalcs.w = dot(texSampleAndColor.xyz, float3(0.300000012,0.589999974,0.109999999));
  maskingAndConditions.xyz = normalAndLightingCalcs.www + -texSampleAndColor.xyz;
  texSampleAndColor.xyz = cb4[86].xxx * maskingAndConditions.xyz + texSampleAndColor.xyz;
  normalAndLightingCalcs.w = 1 + -viewDirAndShading.z;
  normalAndLightingCalcs.w = -normalAndLightingCalcs.w * cb4[94].y + 1;
  viewDirAndShading.x = viewDirAndShading.y * 4.99999905 + 0.5;
  normalAndLightingCalcs.w = viewDirAndShading.x * normalAndLightingCalcs.w;
  viewDirAndShading.x = asint(cb2[26].w) & 1;
  viewDirAndShading.x = (0 < (uint)viewDirAndShading.x);
  viewDirAndShading.y = (asint(cb0[160].x) != 0);
  viewDirAndShading.x = (int)viewDirAndShading.y | (int)viewDirAndShading.x;
  if (viewDirAndShading.x != 0) {
    viewDirAndShading.xy = -cb0[134].xy + fragInput_ClipPos.xy;
    viewDirAndShading.xy = viewDirAndShading.xy * cb0[135].zw + float2(-0.5,-0.5);
    viewDirAndShading.xy = fragInput_ClipPos.ww * viewDirAndShading.xy;
    viewDirAndShading.zw = fragInput_ClipPos.zw;
    baseColorAndSss.xyw = float3(2,-2,1);
    baseColorAndSss.z = fragInput_ClipPos.w;
    viewDirAndShading.xyzw = baseColorAndSss.xyzw * viewDirAndShading.xyzw;
    viewDirAndShading.xyz = viewDirAndShading.zxy / viewDirAndShading.www;
    viewDirAndShading.yz = -cb0[131].xy + viewDirAndShading.yz;
    maskingAndConditions.xyz = placeholder_ScreenPos.zxy / placeholder_ScreenPos.www;
    maskingAndConditions.yz = -cb0[131].zw + maskingAndConditions.yz;
    viewDirAndShading.xyz = -maskingAndConditions.xyz + viewDirAndShading.xyz;
    baseColorAndSss.xy = viewDirAndShading.yz * float2(0.249500006,0.249500006) + float2(0.499992371,0.499992371);
    viewDirAndShading.y = (uint)viewDirAndShading.x >> 16;
    viewDirAndShading.y = (uint)viewDirAndShading.y;
    viewDirAndShading.y = viewDirAndShading.y * 1.52590219e-005 + 1.52590223e-006;
    viewDirAndShading.x = (int)viewDirAndShading.x & 0x0000ffff;
    viewDirAndShading.x = (uint)viewDirAndShading.x;
    viewDirAndShading.x = viewDirAndShading.x * 1.52590219e-005 + 1.52590223e-006;
    baseColorAndSss.zw = min(float2(1,1), viewDirAndShading.yx);
    viewDirAndShading.x = (cb2[20].w == 0.000000);
    viewDirAndShading.y = (asint(cb0[160].x) == 0);
    viewDirAndShading.x = viewDirAndShading.y ? viewDirAndShading.x : 0;
    gBuffer_MotionVectors.xyzw = viewDirAndShading.xxxx ? float4(0,0,0,0) : baseColorAndSss.xyzw;
  } else {
    gBuffer_MotionVectors.xyzw = float4(0,0,0,0);
  }
  viewDirAndShading.xyz = max(float3(0,0,0), lightParamsAndGI.xzw);
  viewDirAndShading.w = (0 < cb0[146].x);
  if (viewDirAndShading.w != 0) {
    worldPosAndFlags.xyz = -cb0[70].xyz + worldPosAndFlags.xyz;
    maskingAndConditions.xyz = -cb2[5].xyz + worldPosAndFlags.xyz;
    baseColorAndSss.xyz = float3(1,1,1) + cb2[19].xyz;
    maskingAndConditions.xyz = (baseColorAndSss.xyz < abs(maskingAndConditions.xyz));
    viewDirAndShading.w = (int)maskingAndConditions.y | (int)maskingAndConditions.x;
    viewDirAndShading.w = (int)maskingAndConditions.z | (int)viewDirAndShading.w;
    worldPosAndFlags.x = dot(worldPosAndFlags.xyz, float3(0.577000022,0.577000022,0.577000022));
    worldPosAndFlags.x = 0.00200000009 * worldPosAndFlags.x;
    worldPosAndFlags.x = frac(worldPosAndFlags.x);
    worldPosAndFlags.x = (0.5 < worldPosAndFlags.x);
    worldPosAndFlags.xyz = worldPosAndFlags.xxx ? float3(0,1,1) : float3(1,1,0);
    viewDirAndShading.xyz = viewDirAndShading.www ? worldPosAndFlags.xyz : viewDirAndShading.xyz;
  }
  worldPosAndFlags.x = (asint(cb0[249].x) == 1);
  if (worldPosAndFlags.x != 0) {
    worldPosAndFlags.x = dot(float3(1,1,1), abs(normalAndLightingCalcs.xyz));
    worldPosAndFlags.xy = normalAndLightingCalcs.xy / worldPosAndFlags.xx;
    maskingAndConditions.xy = float2(1,1) + -abs(worldPosAndFlags.yx);
    baseColorAndSss.xy = (worldPosAndFlags.xy >= float2(0,0));
    baseColorAndSss.xy = baseColorAndSss.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
    maskingAndConditions.xy = baseColorAndSss.xy * maskingAndConditions.xy;
    worldPosAndFlags.z = (0 >= normalAndLightingCalcs.z);
    worldPosAndFlags.z = worldPosAndFlags.z ? 1.000000 : 0;
    maskingAndConditions.xy = maskingAndConditions.xy * float2(2,2) + -worldPosAndFlags.xy;
    worldPosAndFlags.xy = worldPosAndFlags.zz * maskingAndConditions.xy + worldPosAndFlags.xy;
    gBuffer_Normal.xy = worldPosAndFlags.xy * float2(0.5,0.5) + float2(0.5,0.5);
    texSampleAndColor.xyz = saturate(texSampleAndColor.xyz);
    gBuffer_Shadow.xyz = sqrt(texSampleAndColor.xyz);
    bitmask.x = ((~(-1 << 3)) << 5) & 0xffffffff;  worldPosAndFlags.x = (((uint)cb2[23].w << 5) & bitmask.x) | ((uint)12 & ~bitmask.x);
    worldPosAndFlags.x = (uint)worldPosAndFlags.x;
    gBuffer_Shadow.w = 0.00392156886 * worldPosAndFlags.x;
    gBuffer_Normal.z = 1;
    gBuffer_Normal.w = normalAndLightingCalcs.w;
    gBuffer_MotionVectors.xyzw = float4(0,0,0,0);
    worldPosAndFlags.xy = float2(0,0);
    gBuffer_BaseColor.w = cb4[94].z;
  } else {
    worldPosAndFlags.z = (worldPosAndFlags.w >= 0.5);
    gBuffer_Normal.w = worldPosAndFlags.z ? 0.666000 : 0;
    worldPosAndFlags.z = saturate(cb4[94].w);
    worldPosAndFlags.z = 255 * worldPosAndFlags.z;
    worldPosAndFlags.z = round(worldPosAndFlags.z);
    worldPosAndFlags.w = saturate(cb4[95].x);
    worldPosAndFlags.w = 15 * worldPosAndFlags.w;
    worldPosAndFlags.w = round(worldPosAndFlags.w);
    worldPosAndFlags.zw = (uint2)worldPosAndFlags.zw;
    bitmask.z = ((~(-1 << 4)) << 0) & 0xffffffff;  worldPosAndFlags.z = (((uint)worldPosAndFlags.w << 0) & bitmask.z) | ((uint)worldPosAndFlags.z & ~bitmask.z);
    worldPosAndFlags.z = (uint)worldPosAndFlags.z;
    worldPosAndFlags.y = 0.00392156886 * worldPosAndFlags.z;
    worldPosAndFlags.z = dot(float3(1,1,1), abs(normalAndLightingCalcs.xyz));
    normalAndLightingCalcs.xy = normalAndLightingCalcs.xy / worldPosAndFlags.zz;
    worldPosAndFlags.zw = float2(1,1) + -abs(normalAndLightingCalcs.yx);
    maskingAndConditions.xy = (normalAndLightingCalcs.xy >= float2(0,0));
    maskingAndConditions.xy = maskingAndConditions.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
    worldPosAndFlags.zw = maskingAndConditions.xy * worldPosAndFlags.zw;
    normalAndLightingCalcs.z = (0 >= normalAndLightingCalcs.z);
    normalAndLightingCalcs.z = normalAndLightingCalcs.z ? 1.000000 : 0;
    worldPosAndFlags.zw = worldPosAndFlags.zw * float2(2,2) + -normalAndLightingCalcs.xy;
    normalAndLightingCalcs.xy = normalAndLightingCalcs.zz * worldPosAndFlags.zw + normalAndLightingCalcs.xy;
    gBuffer_Normal.xy = normalAndLightingCalcs.xy * float2(0.5,0.5) + float2(0.5,0.5);
    texSampleAndColor.xyz = saturate(texSampleAndColor.xyz);
    gBuffer_Shadow.xyz = sqrt(texSampleAndColor.xyz);
    bitmask.x = ((~(-1 << 3)) << 5) & 0xffffffff;  normalAndLightingCalcs.x = (((uint)cb2[23].w << 5) & bitmask.x) | ((uint)12 & ~bitmask.x);
    normalAndLightingCalcs.x = (uint)normalAndLightingCalcs.x;
    gBuffer_Shadow.w = 0.00392156886 * normalAndLightingCalcs.x;
    gBuffer_Normal.z = normalAndLightingCalcs.w;
    worldPosAndFlags.x = cb4[94].z;
    gBuffer_BaseColor.w = maskingAndConditions.w;
  }
  gBuffer_GI.xyz = viewDirAndShading.xyz;
  gBuffer_GI.w = 0;
  gBuffer_RimDepth.xyzw = fragInput_ClipPos.zzzz;
  gBuffer_RimAndMasks.xy = worldPosAndFlags.xy;
  gBuffer_RimAndMasks.zw = float2(0,0);

  fragOutput.o0_GI = gBuffer_Normal;
  fragOutput.o1_Normal_Diffuse_FaceSDFMask = gBuffer_Normal;
  fragOutput.o2_ShadowColor_PackShadeMode_OutputMask = gBuffer_Shadow;
  fragOutput.o3_BaseColor_ToonSkinMask = gBuffer_BaseColor;
  fragOutput.o4 = gBuffer_MotionVectors;
  fragOutput.o5_RimDepth = gBuffer_RimDepth;
  fragOutput.o6_rimStrength_HSVPack_groundSpec_charRegion = gBuffer_RimAndMasks;
  
  return fragOutput;
}
            ENDHLSL
        }
    }
}