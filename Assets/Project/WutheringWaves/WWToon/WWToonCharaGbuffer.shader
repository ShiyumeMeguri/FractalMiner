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
            
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VETEX _ADDITIONAL_LIGHTS
            #pragma multi_compile _ _SHADOWS_SOFT

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            
            struct Attributes
            {
                float4 positionOS   : POSITION;
                float2 uv           : TEXCOORD0;
                float3 normalOS     : NORMAL;       
                float4 tangentOS    : TANGENT;      
            };

            struct Varyings
            {
                float4 positionCS   : SV_POSITION;  
                float4 uv           : TEXCOORD0;    
                float3 normalWS     : TEXCOORD1;    
                float3 tangentWS    : TEXCOORD2;    
                float3 bitangentWS  : TEXCOORD3;    
                float3 lightDirWS   : TEXCOORD4;    
                float3 viewDirWS    : TEXCOORD5;    
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

            Varyings vert (Attributes i)
            {
                Varyings o;

                float4 positionWS4 = mul(unity_ObjectToWorld, i.positionOS);
                float3 positionWS = positionWS4.xyz;

                o.positionCS = mul(UNITY_MATRIX_VP, positionWS4);

                o.uv.xy = i.uv;
                float2 ndc = o.positionCS.xy / o.positionCS.w;
                o.uv.zw = ndc;

                o.normalWS = normalize(mul((float3x3)unity_ObjectToWorld, i.normalOS));
                o.tangentWS = normalize(mul((float3x3)unity_ObjectToWorld, i.tangentOS.xyz));
                o.bitangentWS = cross(o.normalWS, o.tangentWS) * i.tangentOS.w;
                
                o.lightDirWS = _MainLightPosition.xyz; 
                o.viewDirWS = normalize(_WorldSpaceCameraPos.xyz - positionWS);

                return o;
            }
            
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

FragOutput frag(Varyings fragmentInput)
{
    // ---- 在 frag 开始时为全局参数变量赋值 ----
    float4 _ClipToWorldRowX          = float4(-0.001,      0.00027,  0.00,    0.00);
    float4 _ClipToWorldRowY          = float4(-0.00011,   -0.0004,  -0.00095, 0.00);
    float4 _ClipToWorldRowZ          = float4( 0.00,       0.00,     0.00,    0.10);
    float4 _ClipToWorldRowW          = float4( 1.02657,    0.84954, -0.00344, 0.00);

    float4 _NormalBlendParams        = float4( 0.00, 0.00, 0.00, 1.00);
    float4 _MipBiasParams            = float4( 0.01525, -0.37648, 0.77031, 3.99356E-41);
    float4 _DebugBranchParam         = float4( 0.00, 0.00, 0.00, 0.00);

    float4 _AnchorPosition           = float4( 0.00, 0.00, 0.00, 1.00);
    float4 _LightDirScaleParam       = float4( 0.00, 0.00, 0.00, 1.00);

    float4 _LargeWorldOffset         = float4(4046.79565, 15060.82422, 9682.03906, 69.95145);
    float4 _BitPackParam             = float4(-63.72506, -75.28133, -0.06375, 1.40130E-45);
    float4 _LightDirFadeParam        = float4( 0.00, 0.00, 0.09153, -0.69992);

    float4 _SkinMaskParam            = float4( 0.50, 1.00, 0.00, 4.70083);
    float4 _SecondaryLightDir        = float4(-0.99005, 0.14073, 0.00, 1.00);
    float4 _PrimaryLightDir          = float4(-0.70007, 0.09951, 0.70711, 1.00);

    float4 _FrameWorldOffset         = float4( 0.00, 0.00, 100.00, 0.00);
    float4 _BrightShadeColor         = float4( 0.93869, 0.60383, 0.40724, 0.00);
    float4 _DarkShadeColor           = float4( 0.76803, 0.78755, 0.82292, 0.00);
    float4 _NormalMapStrength        = float4( 0.00, 0.00, 0.50, 1.00);
    float4 _ShadeModeParams          = float4( 0.00, 1.00, 0.00, 1.00);
    float4 _LightBlendParams         = float4( 1.00, 2.00, 5.00, 30.00);
    float4 _LightBlendFactors        = float4( 0.66667, 0.66667, 0.55, 0.40);
    float4 _SpecularParams           = float4(-0.10, 0.55, 0.10, 1.00);
    float4 _ShadowRampParams         = float4( 0.50, 0.90, 0.20, 1.00);
    float4 _ShadowExponentParams     = float4( 1.00, 0.00, 0.20, 0.00);
    float4 _ShadowBlendParams        = float4( 0.00, 0.00, 0.40, 0.50);
    float4 _DesaturateParams         = float4( 0.00, 0.30, 0.00, 0.00);
    // --------------------------------------------------

    FragOutput fragOutput;

    float4 interpolatedUV = fragmentInput.uv;
    float3 worldTangent   = fragmentInput.tangentWS;
    float3 worldBitangent = fragmentInput.bitangentWS;

    float4 clipSpacePosition = fragmentInput.positionCS;
    float4 clipToWorldAccum  = _ClipToWorldRowY * clipSpacePosition.yyyy;
    float4 clipToWorldRow    = _ClipToWorldRowX;
    clipToWorldAccum         = clipSpacePosition.xxxx * clipToWorldRow + clipToWorldAccum;
    clipToWorldRow           = _ClipToWorldRowZ;
    clipToWorldAccum         = clipSpacePosition.zzzz * clipToWorldRow + clipToWorldAccum;
    clipToWorldRow           = _ClipToWorldRowW;
    clipToWorldAccum         = clipToWorldAccum + clipToWorldRow;

    float3 worldPosition     = clipToWorldAccum.xyz / clipToWorldAccum.www;

    float invDistance        = dot(-worldPosition, -worldPosition);
    invDistance              = rsqrt(invDistance);
    float3 viewDirectionWS   = float3(invDistance, invDistance, invDistance) * -worldPosition;

    float mipBias            = _MipBiasParams.y;
    float normalMapSample    = _IN0.SampleBias(sampler_IN0, interpolatedUV.xy, mipBias).x;
    float unpackedNormalX    = normalMapSample * 2.0 - 1.0;
    float normalStrength     = _NormalMapStrength.w;
    unpackedNormalX         *= normalStrength;

    float normalBlendFactor  = _NormalBlendParams.w;
    clipToWorldRow.xyz       = unpackedNormalX.xxx * worldTangent + worldBitangent;
    float4 blendVec4;
    blendVec4.x              = -normalBlendFactor + 1.0;
    blendVec4.xyz            = blendVec4.xxx * worldBitangent;
    clipToWorldRow.xyz       = clipToWorldRow.xyz * float3(normalBlendFactor, normalBlendFactor, normalBlendFactor) + blendVec4.xyz;

    float shadeModeCompute   = dot(clipToWorldRow.xyz, clipToWorldRow.xyz);
    shadeModeCompute         = rsqrt(shadeModeCompute);
    float3 perturbedNormalWS = clipToWorldRow.xyz * shadeModeCompute.xxx;

    float2 maskSample        = _IN1.SampleLevel(sampler_IN1, interpolatedUV.xy, mipBias).xy;

    bool4 channelAboveThreshold = maskSample.xxxx >= float4(0.05, 0.3, 0.5, 0.9);
    float3 channelMaskVec3;
    channelMaskVec3.x        = channelAboveThreshold.y ? 1.0 : 0.0;
    channelMaskVec3.y        = channelAboveThreshold.z ? 1.0 : 0.0;
    channelMaskVec3.z        = channelAboveThreshold.w ? 1.0 : 0.0;

    bool4 channelBelowThreshold = float4(0.05, 0.3, 0.5, 0.9) >= maskSample.xxxx;
    blendVec4.x                = channelBelowThreshold.z ? 1.0 : 0.0;
    blendVec4.z                = channelBelowThreshold.w ? 1.0 : 0.0;
    blendVec4.xz               = channelMaskVec3.xy * blendVec4.xz; 

    shadeModeCompute           = channelBelowThreshold.y ? 0.0 : 1.0;
    shadeModeCompute           = channelAboveThreshold.x ? shadeModeCompute : 1.0;
    shadeModeCompute           = channelBelowThreshold.x ? 1.0 : shadeModeCompute;
    shadeModeCompute           = (-blendVec4.x) * shadeModeCompute + 1.0;
    shadeModeCompute           = (-blendVec4.z) * shadeModeCompute + 1.0;
    float shadeModeSelector    = shadeModeCompute * channelMaskVec3.z;

    float3 shadeModeParams     = _ShadeModeParams.xyz;
    bool isShadeModeY          = shadeModeParams.y >= 0.5;
    float shadeMode            = isShadeModeY ? shadeModeSelector : shadeModeParams.x;
    blendVec4.x                = -shadeMode + 1.0;
    float finalShadeFactor     = shadeModeParams.z * blendVec4.x + shadeMode; 

    float shadowMapSample      = _IN2.SampleBias(sampler_IN2, interpolatedUV.xy, mipBias).w;
    float NdotV                = dot(perturbedNormalWS, viewDirectionWS);
    NdotV                      = clamp(NdotV, 0.0, 1.0);

    // ---------- 计算光方向 ----------
    float3 lightDirIntermediate = _PrimaryLightDir.xyz;
    float3 lightDirBlend        = _SecondaryLightDir.xyz - lightDirIntermediate;
    float scalarWork            = _LightBlendFactors.y;
    lightDirBlend              *= scalarWork.xxx;
    scalarWork                  = _LightBlendParams.w;
    bool isCondition            = scalarWork >= 0.5;
    scalarWork                  = isCondition ? 1.0 : 0.0;
    lightDirIntermediate        = lightDirIntermediate + scalarWork.xxx * lightDirBlend;
    scalarWork                  = sqrt(dot(lightDirIntermediate, lightDirIntermediate));
    lightDirIntermediate        = lightDirIntermediate / scalarWork.xxx;

    lightDirBlend               = _FrameWorldOffset.xyz + _LargeWorldOffset.xyz;
    float4 tempVector4          = _AnchorPosition;
    tempVector4.xyz             = tempVector4.xyz - lightDirBlend;
    scalarWork                  = sqrt(dot(tempVector4.xyz, tempVector4.xyz));
    tempVector4.xyz            /= scalarWork.xxx;

    float3 anchorPosition       = _AnchorPosition.xyz;
    lightDirBlend               = lightDirBlend - anchorPosition;
    scalarWork                  = sqrt(dot(lightDirBlend, lightDirBlend));
    scalarWork                  = clamp(scalarWork * tempVector4.w, 0.0, 1.0);
    lightDirBlend               = tempVector4.xyz + scalarWork.xxx * (lightDirIntermediate - tempVector4.xyz);
    lightDirBlend               = lightDirBlend - lightDirIntermediate;
    scalarWork                  = _LightDirScaleParam.z;
    lightDirIntermediate        = lightDirIntermediate + scalarWork.xxx * lightDirBlend;
    scalarWork                  = clamp(_LightDirFadeParam.y, 0.0, 1.0);
    lightDirIntermediate        = lightDirIntermediate + scalarWork.xxx * (-lightDirIntermediate);
    scalarWork                  = sqrt(dot(lightDirIntermediate, lightDirIntermediate));
    float3 finalLightDirection  = lightDirIntermediate / scalarWork.xxx;
    // ---------------------------------

    clipToWorldAccum.x          = dot(finalLightDirection, viewDirectionWS);
    float2 workUV2;
    workUV2.x                   = 1.0 - abs(viewDirectionWS.z);
    clipToWorldAccum.x          = (clipToWorldAccum.x * workUV2.x + 1.0) * 0.5;

    float2 specularParams       = _SpecularParams.xy;
    scalarWork                  = _LightBlendFactors.w;
    workUV2.x                   = scalarWork - specularParams.x;
    clipToWorldAccum.x          = clipToWorldAccum.x * workUV2.x + _SpecularParams.x;
    workUV2.x                   = 1.0 - NdotV;
    float finalSpecularTerm     = clipToWorldAccum.x * workUV2.x + specularParams.y;

    float shadowMapScale        = _SpecularParams.w;
    float scaledShadow          = shadowMapSample * shadowMapScale;
    scaledShadow                = clamp(scaledShadow, 0.0, _ShadowRampParams.x);
    float normalizedShadow      = scaledShadow / _ShadowRampParams.x;

    float2 shadowRampParams     = _ShadowRampParams.zz; 
    float rampWidthInv          = 1.0 / (1.0 - shadowRampParams.x);
    scalarWork                  = (normalizedShadow - shadowRampParams.x) * rampWidthInv;
    float rampT                 = clamp(scalarWork, 0.0, 1.0);
    scalarWork                  = rampT * -2.0 + 3.0;
    float smoothedRampT         = rampT * rampT * scalarWork;
    float rampedShadow          = smoothedRampT * shadowRampParams.y;

    isShadeModeY                = 2.98023295e-08 >= rampedShadow;
    rampedShadow                = exp2(log2(rampedShadow) * _ShadowExponentParams.x) * _ShadowExponentParams.y;
    float shadowTerm            = isShadeModeY ? 0.0 : rampedShadow;

    float NdotL                 = dot(perturbedNormalWS, finalLightDirection);
    float diffuseShadow         = NdotL * 0.5 + shadowTerm + 0.5;
    float compressedShadow      = min(normalizedShadow, shadowRampParams.x) / _ShadowExponentParams.z;
    float clampedDiffuse        = min(max(diffuseShadow, 0.0), _ShadowBlendParams.z);
    float overflowDiffuse       = diffuseShadow - clampedDiffuse;
    float blendedShadow         = (compressedShadow * overflowDiffuse + clampedDiffuse) + 0.5;

    float rampLookupU           = clamp(-finalSpecularTerm + blendedShadow, 0.0, 1.0);
    float rampVOffset           = -_ShadowBlendParams.w + 0.1;
    float rampLookupV           = finalShadeFactor * rampVOffset + _ShadowBlendParams.w;

    float3 rampedColor          = _IN4.SampleBias(sampler_IN4, float2(rampLookupU, rampLookupV), mipBias).xyz;

    float  skinMaskEnable       = _SkinMaskParam.w;
    bool   isSkinMaskEnabled    = skinMaskEnable >= 0.05;
    float  finalSkinMask        = (isSkinMaskEnabled ? 1.0 : 0.0) * maskSample.y;

    float3 baseColor            = lerp(_DarkShadeColor.xyz, _BrightShadeColor.xyz, finalShadeFactor);
    float3 finalColor           = lerp(baseColor, rampedColor, finalSkinMask);

    float  luma                 = dot(finalColor, float3(0.3, 0.589999974, 0.109999999));
    float3 desaturatedColor     = luma.xxx;
    float3 finalSaturatedColor  = lerp(finalColor, desaturatedColor, _DesaturateParams.x);

    int  branchCondition        = int(_DebugBranchParam.x);
    bool branchEQ               = branchCondition == 1;
    if (branchEQ) {
        finalSaturatedColor  = clamp(finalSaturatedColor, 0.0, 1.0);
        fragOutput.o0_GI.xyz = sqrt(finalSaturatedColor);

        uint packedTempUint1 = asuint(_BitPackParam.w);
        {
            uint mask       = ~(((1u << 3) - 1) << 5);
            packedTempUint1 = (12u & mask) | ((packedTempUint1 & 7u) << 5);
        }
        fragOutput.o0_GI.w = asfloat(packedTempUint1) * 0.00392156886;
    }
    else {
        finalSaturatedColor  = clamp(finalSaturatedColor, 0.0, 1.0);
        fragOutput.o0_GI.xyz = sqrt(finalSaturatedColor);

        uint packedTempUint0 = asuint(_BitPackParam.w);
        {
            uint mask       = ~(((1u << 3) - 1) << 5);
            packedTempUint0 = (12u & mask) | ((packedTempUint0 & 7u) << 5);
        }
        fragOutput.o0_GI.w = asfloat(packedTempUint0) * 0.00392156886;
    }

    // debug用 不要删
    fragOutput.o0_GI = pow(fragOutput.o0_GI, 5);
    return fragOutput;

    fragOutput.o1_Normal_Diffuse_FaceSDFMask                       = float4(0.0, 0.0, 0.0, 0.0);
    fragOutput.o2_ShadowColor_PackShadeMode_OutputMask             = float4(0.0, 0.0, 0.0, 0.0);
    fragOutput.o3_BaseColor_ToonSkinMask                           = float4(0.0, 0.0, 0.0, 0.0);
    fragOutput.o4                                                  = float4(0.0, 0.0, 0.0, 0.0);
    fragOutput.o5_RimDepth                                         = float4(0.0, 0.0, 0.0, 0.0);
    fragOutput.o6_rimStrength_HSVPack_groundSpec_charRegion        = float4(0.0, 0.0, 0.0, 0.0);
    
    return fragOutput;
}

            ENDHLSL
        }
    }
}
