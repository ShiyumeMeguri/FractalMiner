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
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 5.0
            //#pragma enable_d3d11_debug_symbols
            
            #include "UnityCG.cginc"

            struct VertexInput
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct VertexToFragment
            {
                float4 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
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

            VertexToFragment vert (VertexInput vertexInput)
            {
                VertexToFragment output;
                output.vertex = UnityObjectToClipPos(vertexInput.vertex);
                output.uv.xy = vertexInput.uv;
                // 计算 NDC x（clip.x / clip.w）并复制到 zw
                float ndcX = output.vertex.x / output.vertex.w;
                output.uv.zw = ndcX;
                return output;
            }
            
            StructuredBuffer<float4> cb0;
            StructuredBuffer<float4> cb1;
            StructuredBuffer<float4> cb2;
            
            // 已知 _IN0 是深度+Stencil 
            // 已知 _IN1 XYZ是法线 A是PerObjectData
            // 已知 _IN2 X是Metallic Y是Specular Z是Roughness W是ShadingModelID 
            // 已知 _IN3 是Albedo和Alpha
            // 未知 _IN4
            // 已知 _IN5 R是阴影 G未使用 B是阴影强度 A通道为什么和B一样
            // 已知 _IN6 R16深度
            // 已知 _IN7 1x1像素 全0
            // 已知 _IN8 MSSAO 多分辨率屏幕空间AO
            // 已知 _IN9 1x1像素 控制屏幕亮度
            
float4 frag (VertexToFragment fragmentInput) : SV_Target
{
    // 基于输入uv定义uvAndNDC，zw分量是NDC x（clip.x / clip.w）并复制到 zw
    float4 uvAndNDC = fragmentInput.uv; 

    float4 color = 0;
    
    // 临时寄存器 r0-r16 的声明已被移除。
    // 其功能将由以下具有明确上下文含义的局部变量代替。
    uint4 bitmask, uiDest;
    float4 fDest;

    float4 gBufferA_WYZX = tex2Dlod(_IN1, float4(uvAndNDC.xy, 0, 0)).wxyz;
    float4 gBufferB = tex2Dlod(_IN2, float4(uvAndNDC.xy, 0, 0));
    float3 albedo = tex2Dlod(_IN3, float4(uvAndNDC.xy, 0, 0)).xyz;
    float3 gBufferD_YXZ = tex2Dlod(_IN4, float4(uvAndNDC.xy, 0, 0)).yxz;
    float sceneDepth = tex2Dlod(_IN0, float4(uvAndNDC.xy, 0, 0)).x;
    float viewDepth_intermediate = sceneDepth * cb1[65].x + cb1[65].y;
    float linearEyeDepth_denominator = sceneDepth * cb1[65].z - cb1[65].w;
    float inv_linearEyeDepth_denominator = 1.0f / linearEyeDepth_denominator;
    float linearEyeDepth = viewDepth_intermediate + inv_linearEyeDepth_denominator;
    float2 screenCoord_unscaled = cb1[138].xy * uvAndNDC.xy;
    uint2 screenCoord_int = (uint2)screenCoord_unscaled;
    uint ditherFrameConst = (uint)cb1[158].x;
    int ditherSeed_base = (int)screenCoord_int.y + (int)screenCoord_int.x;
    int ditherSeed_final = (int)ditherFrameConst + ditherSeed_base;
    int checkerboardPattern = ditherSeed_final & 1;
    float shadingModelID_encoded = 255.0f * gBufferB.w;
    float shadingModelID_rounded = round(shadingModelID_encoded);
    uint shadingModelID = (uint)shadingModelID_rounded;
    int2 shadingModelFlags = (int2)shadingModelID & int2(15, -16);
    float isNotFoliageFlag = ((int)shadingModelFlags.x != 12) ? 1.0f : 0.0f;
    float3 isClothHairEye_flags = ((int3)shadingModelFlags.x == int3(13, 14, 15)) ? 1.0f : 0.0f;
    int isHairOrEye_flag = (int)isClothHairEye_flags.z | (int)isClothHairEye_flags.y;
    int isClothHairOrEye_flag = isHairOrEye_flag | (int)isClothHairEye_flags.x;
    float specialShadingPath_flag = isNotFoliageFlag ? (float)isClothHairOrEye_flag : -1.0f;
    
    // 声明将在 if/else 块内外使用的变量
    float3 worldNormal;
    float3 materialParams_squared;
    float gBufferD_Z_copy;
    float2 shadingModel_flag_copies;
    float finalLinearEyeDepth;

    if (specialShadingPath_flag != 0.0f) {
        int selectedShadingModelID = isClothHairEye_flags.x ? 13 : 12;
        bool isHairOrEye_bool = isClothHairEye_flags.y || isClothHairEye_flags.z;
        shadingModel_flag_copies = isHairOrEye_bool ? float2(1.0f, 1.0f) : 0.0f;
        float2 unpackedNormal_pre = gBufferA_WYZX.yz * 2.0f - 1.0f;
        float sumAbsUnpackedNormal = dot(float2(1.0f, 1.0f), abs(unpackedNormal_pre));
        float reconstructedNormalZ_oct = 1.0f - sumAbsUnpackedNormal;
        float octNormal_correctionFactor = max(0.0f, -reconstructedNormalZ_oct);
        float2 octNormal_sign = (unpackedNormal_pre >= 0.0f) ? 1.0f : 0.0f;
        float2 octNormal_decodeBias = octNormal_sign ? float2(0.5f, 0.5f) : float2(-0.5f, -0.5f);
        float2 octNormal_scaledDecodeBias = octNormal_decodeBias * octNormal_correctionFactor;
        float2 reconstructedNormalXY_oct = octNormal_scaledDecodeBias * -2.0f + unpackedNormal_pre;
        float3 reconstructedNormal_oct = float3(reconstructedNormalXY_oct, reconstructedNormalZ_oct);
        float reconstructedNormal_lenSq = dot(reconstructedNormal_oct, reconstructedNormal_oct);
        float invLen_reconstructedNormal = rsqrt(reconstructedNormal_lenSq);
        worldNormal = reconstructedNormal_oct * invLen_reconstructedNormal;
        materialParams_squared = gBufferB.xyz * gBufferB.xyz;
        gBufferD_Z_copy = gBufferD_YXZ.z;
        finalLinearEyeDepth = linearEyeDepth; // 保持状态一致
    } else {
        float isClearCoatFlag = ((int)shadingModelFlags.x == 10) ? 1.0f : 0.0f;
        float3 materialParams_clamped = saturate(gBufferB.xyz);
        float3 materialParams_encoded = float3(16777215.0f, 65535.0f, 255.0f) * materialParams_clamped;
        uint3 materialParams_encoded_rounded = (uint3)round(materialParams_encoded);
        bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  uint packedDataY = (((uint)materialParams_encoded_rounded.z << 0) & bitmask.y) | ((uint)materialParams_encoded_rounded.y & ~bitmask.y);
        bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  uint packedDataX = (((uint)packedDataY << 0) & bitmask.x) | ((uint)materialParams_encoded_rounded.x & ~bitmask.x);
        uint finalPackedData = (uint)packedDataX;
        float decodedDepthFromPacking = 5.96046519e-008f * finalPackedData;
        float linearDepthFromPacking_part1 = decodedDepthFromPacking * cb1[65].x + cb1[65].y;
        float linearDepthFromPacking_part2 = decodedDepthFromPacking * cb1[65].z - cb1[65].w;
        float inv_linearDepthFromPacking_part2 = 1.0f / linearDepthFromPacking_part2;
        float linearDepthFromPacking = linearDepthFromPacking_part1 + inv_linearDepthFromPacking_part2;
        finalLinearEyeDepth = isClearCoatFlag ? linearDepthFromPacking : linearEyeDepth;
        worldNormal = gBufferA_WYZX.yzw * 2.0f - 1.0f;
        materialParams_squared = float3(0.0f, 0.0f, 0.0f);
        gBufferD_Z_copy = 0.0f; // 保持状态一致
        shadingModel_flag_copies = float2(0.0f, 0.0f); // 保持状态一致
    }
    float worldNormal_lenSq = dot(worldNormal, worldNormal);
    float invLen_worldNormal = rsqrt(worldNormal_lenSq);
    float3 normalizedWorldNormal = worldNormal * invLen_worldNormal;
    bool isShadingModel_5_or_13 = (shadingModelFlags.x == 5) || (shadingModelFlags.x == 13);
    bool useDitherPattern = (cb1[162].y > 0.0f) && (cb2[220].z > 0.0f);
    bool isAlbedoForced = (cb1[162].y != 0);
    float3 albedoOrWhite = isAlbedoForced ? float3(1.0f, 1.0f, 1.0f) : albedo;
    float checkerboardPattern_float = checkerboardPattern ? 1.0f : 0.0f;
    float3 albedoOrCheckerboard = useDitherPattern ? float3(checkerboardPattern_float, checkerboardPattern_float, checkerboardPattern_float) : albedoOrWhite;
    float3 finalAlbedo = isShadingModel_5_or_13 ? albedoOrCheckerboard : albedo;
    float eyeAdaptation = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
    float2 worldPos_proj = uvAndNDC.zw * finalLinearEyeDepth;
    float3 viewSpacePos = cb1[49].xyz * worldPos_proj.y;
    viewSpacePos = worldPos_proj.x * cb1[48].xyz + viewSpacePos;
    viewSpacePos = finalLinearEyeDepth * cb1[50].xyz + viewSpacePos;
    float3 worldPosition = cb1[51].xyz + viewSpacePos;
    float2 shadowMask_TermAndStrength = tex2Dlod(_IN5, float4(uvAndNDC.xy, 0, 0)).xz;
    float2 shadowMask_squared = shadowMask_TermAndStrength * shadowMask_TermAndStrength;
    float shadowFactor = shadowMask_squared.x * shadowMask_squared.y;
    float finalShadowFactor = cb1[253].y * shadowFactor;

    float3 finalLighting;
    float3 specular_base_color;
    if (cb1[255].x != 0) {
        float3 ssrAccumulator = float3(0.0f, 0.0f, 0.0f);
        float ssrRadius = 0.0f;
        float ssrStep = 0.0f;
        float ssrTotalWeight = 0.0f;
        int outerLoopCount = 0;
        while (true) {
            bool endOuterLoop = (outerLoopCount >= 3);
            if (endOuterLoop) break;
            ssrStep += 0.000833333295f;
            float3 innerLoopAccumulator = ssrAccumulator;
            float ssrAngle = shadingModel_flag_copies.y; // r5.w
            float innerLoopTotalWeight = ssrTotalWeight;
            int innerLoopCount = 0;
            while (true) {
                bool endInnerLoop = (innerLoopCount >= 3);
                if (endInnerLoop) break;
                ssrAngle += 1.0f;
                float currentAngleRad = 2.09439516f * ssrAngle;
                float sinAngle, cosAngle;
                sincos(currentAngleRad, sinAngle, cosAngle);
                float ssrSampleU = cosAngle * ssrStep + uvAndNDC.x;
                float ssrSampleV = sinAngle * ssrStep + uvAndNDC.y;
                float3 blackSample = tex2D(_IN7, float2(ssrSampleU, ssrSampleV)).xyz;
                innerLoopAccumulator += blackSample * ssrStep;
                innerLoopTotalWeight += ssrStep;
                innerLoopCount++;
            }
            ssrAccumulator = innerLoopAccumulator;
            ssrTotalWeight = innerLoopTotalWeight;
            shadingModel_flag_copies.y = 0.620000005f + ssrAngle;
            outerLoopCount++;
        }
        float3 ssrResult = ssrAccumulator / ssrTotalWeight;
        bool3 colorRangeCheck1 = (float3(0.644999981f, 0.312000006f, 0.978999972f) < gBufferA_WYZX.xxx);
        bool3 colorRangeCheck2 = (gBufferA_WYZX.xxx < float3(0.685000002f, 0.351999998f, 1.02100003f));
        bool3 inColorRange = colorRangeCheck1 && colorRangeCheck2;
        float colorSelect = inColorRange.z ? 1.0f : 0.0f;
        colorSelect = inColorRange.y ? 0.0f : colorSelect;
        colorSelect = inColorRange.x ? 1.0f : colorSelect;
        int colorRange_anyYorZ = (int)inColorRange.y | (int)inColorRange.z;
        int colorRange_any_asFloat = colorRange_anyYorZ & 0x3f800000;
        float finalColorSelect = inColorRange.x ? 0.0f : (float)colorRange_any_asFloat;
        uint gBufferD_X_encoded = (uint)round(gBufferD_YXZ.x * 255.0f);
        uint4 materialFlags = (uint4)gBufferD_X_encoded & uint4(15, 240, 240, 15);
        float smoothstep_in1 = saturate(gBufferA_WYZX.w * 2.0f);
        float smoothstep_poly1 = smoothstep_in1 * smoothstep_in1 * (3.0f - 2.0f * smoothstep_in1);
        float smoothstep_in2 = saturate((gBufferA_WYZX.w - 0.5f) * 2.0f);
        float smoothstep_poly2 = smoothstep_in2 * smoothstep_in2 * (3.0f - 2.0f * smoothstep_in2);
        float3 colorDiff = cb1[262].xyz - cb1[261].xyz;
        float colorDiff_luma = dot(abs(colorDiff), float3(0.300000012f, 0.589999974f, 0.109999999f));
        float smoothstep_in3 = min(1.0f, 10.0f * colorDiff_luma);
        float smoothstep_poly3 = smoothstep_in3 * smoothstep_in3 * (3.0f - 2.0f * smoothstep_in3);
        float combined_smoothstep_1 = smoothstep_poly3 * smoothstep_poly2;
        float range_blend_min = cb1[265].x;
        float range_blend_max = cb1[265].y;
        float range_blend_inv_dist = 1.0f / (range_blend_max - range_blend_min);
        float blend_alpha_unclamped = (finalShadowFactor - range_blend_min) * range_blend_inv_dist;
        float blend_alpha = saturate(blend_alpha_unclamped);
        float blend_poly = blend_alpha * blend_alpha * (3.0f - 2.0f * blend_alpha);
        float combined_smoothstep_2 = blend_poly * combined_smoothstep_1;
        float blended_shadow_val1 = finalShadowFactor - combined_smoothstep_2;
        float blended_shadow_final = cb1[265].z * blended_shadow_val1 + combined_smoothstep_2;
        float post_blend_shadow = blended_shadow_final - range_blend_min;
        float final_blend_alpha_unclamped = post_blend_shadow * range_blend_inv_dist;
        float final_blend_alpha = saturate(final_blend_alpha_unclamped);
        float final_blend_poly = final_blend_alpha * final_blend_alpha * (3.0f - 2.0f * final_blend_alpha);
        float final_combined_smoothstep = final_blend_poly * combined_smoothstep_1;
        float lerp_factor_1 = smoothstep_poly2 * smoothstep_poly3 - final_combined_smoothstep;
        float lerped_val_1 = cb1[265].z * lerp_factor_1 + final_combined_smoothstep;
        float lerp_factor_2 = checkerboardPattern - blended_shadow_final;
        float lerped_val_2 = shadingModel_flag_copies.x * lerp_factor_2 + blended_shadow_final;
        float lerp_factor_3 = checkerboardPattern * lerped_val_1 - lerped_val_1;
        float lerped_val_3 = shadingModel_flag_copies.x * lerp_factor_3 + lerped_val_1;
        bool is_ssr_greater = ssrResult.y >= ssrResult.z;
        float hsv_selector = is_ssr_greater ? 1.0f : 0.0f;
        float4 hsv_base = is_ssr_greater ? float4(ssrResult.z, ssrResult.y, -1.0f, 0.666666687f) : float4(ssrResult.y, ssrResult.z, 1.0f, -1.0f);
        float4 hsv_intermediate = float4(hsv_base.w, 0.0f, 0.0f, 0.0f);
        hsv_intermediate = hsv_selector * float4(0.0f, hsv_base.y - hsv_base.x, 1.0f, -1.0f) + hsv_intermediate;
        bool is_ssr_x_greater = ssrResult.x >= hsv_intermediate.x;
        float hsv_selector_2 = is_ssr_x_greater ? 1.0f : 0.0f;
        float4 hsv_base_2 = float4(hsv_intermediate.x, hsv_intermediate.y, hsv_intermediate.w, ssrResult.x);
        float4 hsv_intermediate_2 = float4(hsv_base_2.w, hsv_base_2.y, hsv_base_2.x, 0.0f);
        hsv_intermediate_2 = hsv_intermediate_2 - hsv_base_2;
        float4 hsv_final_unselected = hsv_intermediate_2 * hsv_selector_2 + hsv_base_2;
        float hsv_v = hsv_final_unselected.x;
        float hsv_s = (hsv_v - min(hsv_final_unselected.w, hsv_final_unselected.y)) / (hsv_v + 0.00100000005f);
        float hsv_h_div = (hsv_final_unselected.w - hsv_final_unselected.y) * 6.0f + 0.00100000005f;
        float hsv_h = hsv_final_unselected.z + (hsv_final_unselected.w - hsv_final_unselected.y) / hsv_h_div;
        float hsv_s_div = hsv_v + 0.00100000005f;
        float hsv_s_mod = hsv_s / hsv_s_div;
        float luma_factor = 0.300000012f * hsv_v + 1.0f;
        float4 materialFlagRemap = materialFlags * float4(0.0400000028f, 0.0027450982f, 0.00392156886f, 0.0666666701f) + float4(0.400000006f, 0.400000006f, 1.0f, 0.5f);
        bool isMatFlagHigh = (materialFlags.z >= 2.54999971f);
        float materialFlagRemap_blend = isMatFlagHigh ? (materialFlagRemap.y - materialFlagRemap.x) : 0.0f;
        float finalMaterialRemap_x = materialFlagRemap_blend + materialFlagRemap.x;
        float hsv_s_final = finalMaterialRemap_x * hsv_s_mod;
        hsv_s_final = min(0.349999994f, hsv_s_final);
        float hsv_s_clamped = max(0.0f, hsv_s_final);
        float3 hsv_to_rgb_base = abs(hsv_h) + float3(1.0f, 0.666666687f, 0.333333343f);
        hsv_to_rgb_base = frac(hsv_to_rgb_base);
        hsv_to_rgb_base = hsv_to_rgb_base * 6.0f - 3.0f;
        hsv_to_rgb_base = saturate(abs(hsv_to_rgb_base) - 1.0f);
        float3 hsv_to_rgb_intermediate = hsv_to_rgb_base * -1.0f + 1.0f;
        float hsv_s_factor = 1.0f + hsv_s_final;
        float3 rgb_from_hsv_1 = hsv_to_rgb_intermediate * hsv_s_factor;
        float3 rgb_from_hsv_2 = rgb_from_hsv_1 - 1.0f;
        rgb_from_hsv_2 = rgb_from_hsv_2 * 0.600000024f + 1.0f;
        float3 rgb_from_hsv_3 = -hsv_to_rgb_intermediate * hsv_s_factor + rgb_from_hsv_2;
        float3 rgb_from_hsv_lerped = gBufferA_WYZX.xxx * rgb_from_hsv_3 + rgb_from_hsv_1;
        float3 desaturated_color = (rgb_from_hsv_lerped - albedo) * 0.850000024f + albedo;
        float3 color_blend_factor = materialFlagRemap.zzz * desaturated_color - rgb_from_hsv_lerped;
        float3 color_blend_1 = ssrResult * color_blend_factor + rgb_from_hsv_lerped;
        float3 color_blend_2 = (color_blend_1 - 1.0f) * materialFlagRemap.www + 1.0f;
        float3 specColor_base = cb1[261].xyz * 0.200000003f;
        float3 specColor_range = cb1[262].xyz * 0.5f - specColor_base;
        float3 specColor_lerped1 = lerped_val_3 * specColor_range + specColor_base;
        float3 specColor_final = cb1[260].xxx * specColor_lerped1 * albedo;
        float3 specColor_term1 = specColor_final * materialParams_squared.xyz;
        float3 specColor_direct = cb1[261].xyz * albedo;
        float specular_blend_factor = gBufferD_YXZ.x * 0.300000012f + 0.699999988f;
        specular_base_color = specColor_direct * specular_blend_factor;
        float3 specular_mix_1 = specular_base_color + specColor_term1;
        float3 specular_range = cb1[262].xyz * albedo - specular_base_color;
        float3 specular_lerped = specular_range * 0.400000006f + specular_base_color;
        float3 specular_layer1 = specular_base_color * color_blend_2;
        float3 specular_layer2_range = specular_lerped * color_blend_2 - specular_layer1;
        float3 specular_layer2 = lerped_val_2 * specular_layer2_range + specular_layer1;
        float3 final_specular = specColor_final * materialParams_squared.xyz + specular_layer2;
        float3 specular_mix_2 = specular_mix_1 * color_blend_2;
        float3 spec_lobe_color = cb1[262].xyz * final_blend_poly;
        float3 spec_lobe_range = spec_lobe_color * color_blend_2 - specular_mix_2;
        float3 spec_lobe_lerped = lerped_val_2 * spec_lobe_range + specular_mix_2;
        float ao_raw = tex2Dlod(_IN8, float4(uvAndNDC.xy, 0, 0)).x;
        float ao_factor = (float)isClothHairOrEye_flag * (ao_raw - 1.0f) + 1.0f;
        float3 final_specular_desaturated = (spec_lobe_lerped - final_specular) * lerped_val_3 + final_specular;
        float3 ambient_occlusion_mask = 1.0f - ssrResult;
        float3 final_color_occluded = ao_factor * ambient_occlusion_mask + ssrResult;
        finalLighting = final_specular_desaturated * final_color_occluded;
    } else {
        float smoothstep_in1_alt = saturate(gBufferA_WYZX.w * 2.0f);
        float smoothstep_poly1_alt = smoothstep_in1_alt * smoothstep_in1_alt * (3.0f - 2.0f * smoothstep_in1_alt);
        float smoothstep_in2_alt = saturate((gBufferA_WYZX.w - 0.5f) * 2.0f);
        float smoothstep_poly2_alt = smoothstep_in2_alt * smoothstep_in2_alt * (3.0f - 2.0f * smoothstep_in2_alt);
        float3 colorDiff_alt = cb1[262].xyz - cb1[261].xyz;
        float colorDiff_luma_alt = dot(abs(colorDiff_alt), float3(0.300000012f, 0.589999974f, 0.109999999f));
        float smoothstep_in3_alt = min(1.0f, 10.0f * colorDiff_luma_alt);
        float smoothstep_poly3_alt = smoothstep_in3_alt * smoothstep_in3_alt * (3.0f - 2.0f * smoothstep_in3_alt);
        float combined_smoothstep_1_alt = smoothstep_poly3_alt * smoothstep_poly2_alt;
        float range_blend_min_alt = cb1[265].x;
        float range_blend_max_alt = cb1[265].y;
        float range_blend_inv_dist_alt = 1.0f / (range_blend_max_alt - range_blend_min_alt);
        float blend_alpha_unclamped_alt = (finalShadowFactor - range_blend_min_alt) * range_blend_inv_dist_alt;
        float blend_alpha_alt = saturate(blend_alpha_unclamped_alt);
        float blend_poly_alt = blend_alpha_alt * blend_alpha_alt * (3.0f - 2.0f * blend_alpha_alt);
        float combined_smoothstep_2_alt = blend_poly_alt * combined_smoothstep_1_alt;
        float blended_shadow_val1_alt = finalShadowFactor - combined_smoothstep_2_alt;
        float blended_shadow_final_alt = cb1[265].z * blended_shadow_val1_alt + combined_smoothstep_2_alt;
        float post_blend_shadow_alt = blended_shadow_final_alt - range_blend_min_alt;
        float final_blend_alpha_unclamped_alt = post_blend_shadow_alt * range_blend_inv_dist_alt;
        float final_blend_alpha_alt = saturate(final_blend_alpha_unclamped_alt);
        float final_blend_poly_alt = final_blend_alpha_alt * final_blend_alpha_alt * (3.0f - 2.0f * final_blend_alpha_alt);
        float final_combined_smoothstep_alt = final_blend_poly_alt * combined_smoothstep_1_alt;
        float lerp_factor_1_alt = smoothstep_poly2_alt * smoothstep_poly3_alt - final_combined_smoothstep_alt;
        float lerped_val_1_alt = cb1[265].z * lerp_factor_1_alt + final_combined_smoothstep_alt;
        float sheen_factor = blended_shadow_final_alt * gBufferD_YXZ.y;
        float sheen_intensity = 10.0f * sheen_factor;
        float blended_shadow_offset = blended_shadow_final_alt - 1.0f;
        float lerped_val_2_base = cb1[260].y * blended_shadow_offset + 1.0f;
        float lerp_factor_2_alt = checkerboardPattern * lerped_val_1_alt - lerped_val_2_base;
        float lerped_val_2_alt = gBufferD_YXZ.x * lerp_factor_2_alt + lerped_val_2_base;
        float lerp_factor_3_alt = checkerboardPattern * lerped_val_1_alt - lerped_val_1_alt;
        float lerped_val_3_alt = gBufferD_YXZ.x * lerp_factor_3_alt + lerped_val_1_alt;
        float3 specColor_base_alt = cb1[261].xyz * 0.200000003f;
        float3 specColor_range_alt = cb1[262].xyz * 0.5f - specColor_base_alt;
        float3 specColor_lerped1_alt = lerped_val_2_alt * specColor_range_alt + specColor_base_alt;
        float3 specColor_final_alt = cb1[260].xxx * specColor_lerped1_alt * albedo;
        float3 specColor_term1_alt = specColor_final_alt * materialParams_squared.xyz;
        float3 specColor_direct_alt = cb1[261].xyz * albedo;
        float specular_blend_factor_alt = smoothstep_poly1_alt * 0.300000012f + 0.699999988f;
        float3 specular_base_color_alt = specColor_direct_alt * specular_blend_factor_alt;
        float3 specular_mix_1_alt = specular_base_color_alt + specColor_term1_alt;
        float3 specular_mix_2_alt = sheen_intensity * specColor_term1_alt + specular_mix_1_alt;
        float3 specular_range_alt = albedo * cb1[262].xyz - specular_base_color_alt;
        float3 specular_lerped_alt = specular_range_alt * lerped_val_3_alt;
        float3 specular_lerped_2_alt = specular_lerped_alt * 0.400000006f + specular_base_color_alt;
        float3 final_specular_alt = specColor_final_alt * materialParams_squared.xyz + specular_lerped_2_alt;
        float3 spec_lobe_range_alt = albedo * cb1[262].xyz - specular_mix_2_alt;
        float3 spec_lobe_lerped_alt = lerped_val_3_alt * spec_lobe_range_alt + specular_mix_2_alt;
        float3 final_specular_desaturated_alt = (spec_lobe_lerped_alt - final_specular_alt) * lerped_val_2_alt + final_specular_alt;
        finalLighting = final_specular_desaturated_alt;
    }
    float smoothstep_in_final = saturate((gBufferA_WYZX.w - 0.400000006f) * 10.000001f);
    float smoothstep_poly_final = smoothstep_in_final * smoothstep_in_final * (3.0f - 2.0f * smoothstep_in_final);
    float3 specColor_base_final = gBufferD_YXZ.x * finalLighting * 0.5f + cb1[261].xyz;
    float3 specColor_final_lerped = specColor_base_final * albedo;
    float3 specColor_direct_final = cb1[261].xyz * albedo;
    float3 final_spec_lerp1 = cb1[255].xxx ? specColor_final_lerped : specColor_direct_final;
    float3 final_spec_lerp2 = checkerboardPattern ? final_spec_lerp1 : specular_base_color;
    float3 final_spec_lerp3 = checkerboardPattern ? final_spec_lerp1 : finalLighting;
    float2 final_spec_remap = checkerboardPattern ? float2(0.0f, 0.0f) : float2(gBufferD_YXZ.x, smoothstep_poly_final);
    float3 sky_specular_reflection = cb1[264].xyz + cb1[264].xyz;
    float3 final_sky_specular = final_spec_remap.x * sky_specular_reflection - cb1[264].xyz;
    float3 totalLightContribution = float3(0.0f, 0.0f, 0.0f);
    float occlusionFactor = 1.0f;
    uint lightIndex = 0;
    while (true) {
        bool endLightLoop = (lightIndex >= asuint(cb2[128].x));
        if (endLightLoop) break;
        uint lightDataOffset = (lightIndex << 3);
        uint lightMaskCheckOffset = lightDataOffset | 7;
        uint lightTypeMask = (uint)cb2[lightMaskCheckOffset + 0].w << 5;
        uint lightType = (uint)shadingModelFlags.y & lightTypeMask;
        if (lightType == 0) {
            lightIndex = lightIndex + 1;
            continue;
        }
        float3 lightVector = cb2[lightDataOffset + 0].xyz - worldPosition;
        float lightRadiusSq = cb2[lightDataOffset + 0].w * cb2[lightDataOffset + 0].w;
        float distToLightSq = dot(lightVector, lightVector);
        bool inLightRange = (1.0f >= (distToLightSq * lightRadiusSq));
        if (inLightRange) {
            uint lightDataOffset1 = lightDataOffset | 1;
            uint lightDataOffset2 = lightDataOffset | 2;
            uint lightDataOffset3 = lightDataOffset | 3;
            uint lightDataOffset4 = lightDataOffset | 4;
            uint lightDataOffset5 = lightDataOffset | 5;
            uint lightDataOffset6 = lightDataOffset | 6;
            float lightFalloff_unclamped = saturate(distToLightSq * lightRadiusSq * 2.5f - 1.5f);
            float lightFalloff_sq = lightFalloff_unclamped * lightFalloff_unclamped;
            float lightFalloff = 1.0f - lightFalloff_sq * (3.0f - 2.0f * lightFalloff_unclamped);
            float invDistToLight = rsqrt(distToLightSq);
            float3 L = lightVector * invDistToLight;
            float NdotL = dot(normalizedWorldNormal, L);
            float NdotL_remap = NdotL * 0.5f + 1.0f - (cb2[lightDataOffset5 + 0].w * 0.939999998f);
            float invLightSpread = 1.0f / (cb2[lightDataOffset5 + 0].w * 0.0600000024f);
            float lightSpreadFactor = saturate(invLightSpread * NdotL_remap);
            float lightSpread_poly = lightSpreadFactor * lightSpreadFactor * (3.0f - 2.0f * lightSpreadFactor);
            float finalLightSpread = min(1.0f, lightSpread_poly);
            float3 lightColor_base = cb2[lightDataOffset6 + 0].xyz * final_spec_lerp2;
            float3 lightColor_spec_range = albedo * cb2[lightDataOffset5 + 0].xyz - lightColor_base;
            float3 lightColor_spec = finalLightSpread * lightColor_spec_range + lightColor_base;
            float3 lightColor_final = (float)checkerboardPattern * lightColor_spec;
            float attenuation_factor = cb2[lightDataOffset4 + 0].x * (dot(lightVector, lightVector)) + cb2[lightDataOffset4 + 0].y;
            float inv_attenuation = 1.0f / (attenuation_factor + 9.99999975e-005f);
            float lightAttenuation = (inv_attenuation - 1.0f) * cb2[lightDataOffset4 + 0].z;
            lightAttenuation = min(1.0f, lightAttenuation * lightAttenuation);
            uint lightProfileMask = (uint)cb2[lightDataOffset1 + 0].w >> 16;
            bool useProfiledLight = (lightProfileMask == 2);
            float VdotL = dot(L, cb2[lightDataOffset1 + 0].xyz);
            float VdotL_remap = saturate((VdotL - cb2[lightDataOffset2 + 0].x) * cb2[lightDataOffset2 + 0].y);
            float VdotL_poly = VdotL_remap * VdotL_remap * VdotL_remap * VdotL_remap;
            float profiledLightAttenuation = VdotL_poly * lightAttenuation;
            lightAttenuation = useProfiledLight ? profiledLightAttenuation : lightAttenuation;
            float NdotV_like = dot(final_sky_specular, L);
            float fresnel_factor = saturate(NdotV_like * 0.5f + 0.5f);
            float fresnel_lerp = smoothstep_poly_final * fresnel_factor - final_spec_remap.y;
            float final_fresnel = cb2[lightDataOffset4 + 0].w * fresnel_lerp + final_spec_remap.y;
            float3 reflection_base = cb2[lightDataOffset3 + 0].www * final_spec_lerp2;
            float3 reflection_range = albedo - final_spec_lerp2 * cb2[lightDataOffset3 + 0].www;
            float3 reflection_color = final_fresnel * reflection_range + reflection_base;
            reflection_color = cb2[lightDataOffset3 + 0].xyz * reflection_color;
            float lightLuma = cb2[lightDataOffset3 + 0].x + cb2[lightDataOffset3 + 0].y + cb2[lightDataOffset3 + 0].z + (float)checkerboardPattern;
            float lightLuma_factor = saturate(10.0f * lightLuma);
            float shadowStrength = (float)checkerboardPattern * lightLuma_factor;
            float3 lightContribution = lightColor_final * lightAttenuation;
            lightContribution = reflection_color * lightAttenuation + lightContribution;
            float lightFalloff_remaining = lightFalloff - lightAttenuation;
            float attenuatedFalloff = cb2[lightDataOffset6 + 0].w * lightFalloff_remaining + lightAttenuation;
            totalLightContribution += lightContribution * occlusionFactor;
            float newOcclusion = 1.0f - attenuatedFalloff * shadowStrength;
            occlusionFactor = newOcclusion * occlusionFactor;
        }
        lightIndex = lightIndex + 1;
    }
    float3 finalColor = occlusionFactor * final_spec_lerp3 + totalLightContribution;
    bool isClothModel = (shadingModelFlags.x == 13);
    float contactShadow_final;
    if (!isClothModel) {
        bool isSkinModel = (shadingModelFlags.x == 1);
        float roughness_remap = isSkinModel ? gBufferD_YXZ.z : gBufferD_YXZ.y;
        float3 viewVector = cb1[67].xyz - worldPosition;
        float invLen_viewVector = rsqrt(dot(viewVector, viewVector));
        float3 V = viewVector * invLen_viewVector;
        float roughness_remap_clamped = saturate(roughness_remap - 0.100000001f);
        float roughness_scaled = saturate(10.0f * roughness_remap) * 0.800000012f;
        float contactShadowLength = roughness_remap_clamped * 2000.0f + 50.0f;
        float contactShadowInput = roughness_remap_clamped + roughness_remap_clamped;
        roughness_scaled = cb0[0].x * roughness_scaled + contactShadowInput;
        float3 lightDir_Primary = cb1[20].xyz * normalizedWorldNormal.x + cb1[21].xyz * normalizedWorldNormal.y + cb1[22].xyz * normalizedWorldNormal.z;
        bool useSkylight = (asint(cb0[0].w) > 0.5f);
        V = useSkylight ? float3(0.0f, 0.0f, 0.0f) : V;
        float2 halfVectorDir = useSkylight ? cb0[0].yz : cb1[264].xy;
        float halfVectorDirZ = useSkylight ? 0.5f : cb1[264].z;
        float3 H = float3(halfVectorDir, halfVectorDirZ);
        lightDir_Primary = useSkylight ? specColor_final_lerped : lightDir_Primary;
        float LdotH = dot(H, lightDir_Primary);
        float LdotH_remap = saturate(5.0f * (LdotH + 0.200000003f));
        float LdotH_poly = LdotH_remap * LdotH_remap * (3.0f - 2.0f * LdotH_remap);
        float3 H_plus_V = H + V;
        float invLen_H_plus_V = rsqrt(dot(H_plus_V, H_plus_V));
        float3 L_refl = H_plus_V * invLen_H_plus_V;
        float NdotL_refl = saturate(dot(lightDir_Primary, L_refl));
        float specular_D = NdotL_refl * NdotL_refl * (1.0f - 0.800000012f) + 1.0f;
        float specular_D_invSq = 3.14159274f * (specular_D * specular_D);
        float specular_D_final = 0.200000003f / specular_D_invSq * checkerboardPattern;
        float VdotH = dot(H, V);
        float fresnel_remap = saturate((1.0f - VdotH) * 2.0f);
        float fresnel_poly = fresnel_remap * fresnel_remap * (3.0f - 2.0f * fresnel_remap) + 1.0f;
        float NdotV_final = saturate(dot(V, normalizedWorldNormal));
        float fresnel_G_factor = 1.0f - max(0.0f, NdotV_final);
        float scattering_angle = min(1.74532926f, max(0.0f, cb1[133].x));
        float2 scattering_remap = float2(1.5f, 0.572957814f) * float2(fresnel_G_factor, scattering_angle);
        float depth_remap_max = max(0.0f, linearEyeDepth);
        float2 depth_remap = min(float2(3000.0f, 50.0f), depth_remap_max);
        depth_remap = (float2(3000.0f, 50.0f) - depth_remap) * float2(0.00033333333f, 0.0199999996f);
        float depth_poly = depth_remap.x * depth_remap.x;
        depth_poly = depth_poly * depth_poly * depth_poly + depth_remap.y;
        float scattering_F = (scattering_remap.y * (depth_poly - 1.0f)) + 1.0f;
        float scattering_F_lerped = roughness_remap_clamped * (1.0f - scattering_F) + scattering_F;
        float scattering_final = (LdotH + 1.0f) * 0.25f + 0.5f;
        float spec_lobe = scattering_final * scattering_remap.x * scattering_F_lerped * fresnel_poly * 0.00999999978f;
        float2 spec_remap = (gBufferB.xy + 9.99999975e-005f) * rsqrt(dot(gBufferB.xy, gBufferB.xy));
        spec_remap *= roughness_scaled;
        float spec_final = spec_remap.y * spec_lobe;
        float2 spec_offset = float2(-0.5f, 0.0f) * float2(spec_lobe, spec_remap.x);
        float fresnel_V_remap = 0.400000006f * (1.0f - VdotH);
        float spec_D_remap = LdotH_poly * 0.800000012f + 0.200000003f;
        float specular_final = fresnel_V_remap * spec_D_remap + (1.5f * specular_D_final * LdotH_poly);
        specular_final = ((checkerboardPattern * 0.5f) + 0.5f) * specular_final;
        float2 contactShadow_uv_offset = (uvAndNDC.xy * cb1[138].xy - cb1[134].xy) * cb1[135].zw + spec_offset;
        float2 contactShadow_uv = (contactShadow_uv_offset * cb1[135].xy + cb1[134].xy) * cb1[138].zw;
        float contactShadow_sceneDepth = tex2D(_IN6, contactShadow_uv).x;
        float contactShadow_linearDepth_part1 = contactShadow_sceneDepth * cb1[65].x + cb1[65].y;
        float contactShadow_linearDepth_part2 = contactShadow_sceneDepth * cb1[65].z - cb1[65].w;
        float inv_contactShadow_linearDepth_part2 = 1.0f / contactShadow_linearDepth_part2;
        float contactShadow_linearDepth = contactShadow_linearDepth_part1 + inv_contactShadow_linearDepth_part2;
        float contactShadow_depthDelta = max(9.99999975e-005f, contactShadow_linearDepth - linearEyeDepth);
        float contactShadow_factor_unclamped = (contactShadow_depthDelta - roughness_remap_clamped * 1000.0f) / contactShadowLength;
        float contactShadow_factor = saturate(contactShadow_factor_unclamped);
        float contactShadow_poly = contactShadow_factor * contactShadow_factor * (3.0f - 2.0f * contactShadow_factor);
        contactShadow_final = min(1.0f, contactShadow_poly);
        float ambient_luma = dot(cb1[263].xyz, float3(0.300000012f, 0.589999974f, 0.109999999f));
        float3 ambient_desaturated = (cb1[263].xyz - ambient_luma) * 0.75f + ambient_luma;
        float3 ambient_color = checkerboardPattern * (cb1[263].xyz - ambient_desaturated) + ambient_desaturated;
        ambient_color = roughness_scaled * ambient_color * 0.100000001f;
        float3 ambient_base = (albedo + 1.0f) * ambient_color;
        float3 albedo_remap = saturate((albedo * 1.20000005f) - 1.0f);
        float3 albedo_poly = albedo_remap * albedo_remap * (3.0f - 2.0f * albedo_remap);
        float3 ambient_final_layer = albedo_poly * 14.0f + 1.0f;
        float3 ambient_final_color = ambient_final_layer * ambient_color;
        float3 ambient_result = cb1[260].zzz * (ambient_final_color * albedo - ambient_base) + ambient_base;
        ambient_result = contactShadow_final * ambient_result;
        float fog_depth = max(0.0f, linearEyeDepth - 10000.0f);
        fog_depth = min(5000.0f, fog_depth);
        float fog_factor = (5000.0f - fog_depth) * 0.000199999995f;
        ambient_result = fog_factor * ambient_result;
        finalColor = cb0[1].xyz * ambient_result;
    } else {
        finalColor = float3(0.0f, 0.0f, 0.0f);
    }
    bool useHairModel = (isClothHairEye_flags.z != 0.0f);
    float3 hair_lighting_range = cb1[263].xyz * (finalColor * materialParams_squared.xyz) * 0.5f - finalColor;
    float3 hair_lighting_lerped = contactShadow_final * hair_lighting_range + finalColor;
    finalColor = finalColor + finalLighting;
    finalColor = useHairModel ? hair_lighting_lerped : finalColor;
    float3 final_color_composited = checkerboardPattern ? finalColor : (final_spec_lerp3 / eyeAdaptation);
    float3 clamped_output = min(float3(0.0f, 0.0f, 0.0f), -final_color_composited);
    color.xyz = -clamped_output;
    return color;
}
            ENDCG
        }
    }
}