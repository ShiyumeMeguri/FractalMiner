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

            #include "UnityCG.cginc"

            struct VertexInput
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct VertexToFragment
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            
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
                output.uv = vertexInput.uv;
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
            // 未知 _IN5 R是阴影 G不知道 B是反光强度? A为什么和B一样
            // 已知 _IN6 R16深度
            // 已知 _IN7 1x1像素 全0
            // 已知 _IN8 MSSAO 多分辨率屏幕空间AO
            // 已知 _IN9 1x1像素 R32G32B32A32 值看上去是 1.0 0.98065 0.07967 0.43407
            
float4 frag (VertexToFragment fragmentInput) : SV_Target
{
    float4 screenUV = float4(fragmentInput.uv.xy, 0.0, 0.0);

    float4 gbufferNormalSample_raw = tex2Dlod(_IN1, float4(screenUV.xy, 0, 0)).wxyz;
    float perObjectData = gbufferNormalSample_raw.x;
    float3 gbuffer_normal = gbufferNormalSample_raw.yzw;
    
    float4 materialParams_and_Temp_sampler = tex2Dlod(_IN2, float4(screenUV.xy, 0, 0));
    float3 msr = materialParams_and_Temp_sampler.xyz;
    float shadingModelID_raw = materialParams_and_Temp_sampler.w;
    
    float3 baseColor = tex2Dlod(_IN3, float4(screenUV.xy, 0, 0)).xyz;
    
    float4 customDataA_and_Temp;
    customDataA_and_Temp.xyz = tex2Dlod(_IN4, float4(screenUV.xy, 0, 0)).yxz;
    
    float depth = tex2Dlod(_IN0, float4(screenUV.xy, 0, 0)).x;
    
    float temp_depth_calc = depth * cb1[65].x + cb1[65].y;
    float linearizedDepth_part1 = depth * cb1[65].z - cb1[65].w;
    float linearizedDepth_part2 = 1.0 / linearizedDepth_part1;
    depth = temp_depth_calc + linearizedDepth_part2;
    
    float2 tileCoords = cb1[138].xy * screenUV.xy;
    tileCoords = (uint2)tileCoords;
    float cb158 = (uint)cb1[158].x;
    float tileCoordsSum = (int)tileCoords.y + (int)tileCoords.x;
    cb158 = (int)cb158 + (int)tileCoordsSum;
    float isOddPixel = (int)cb158 & 1;

    float shadingModelID_rounded = round(255.0 * shadingModelID_raw);
    uint uintShadingModelID = (uint)shadingModelID_rounded;
    int2 shadingModelBitfields = (int2)uintShadingModelID & int2(15, -16);
    
    float isNotClothShadingModel = (shadingModelBitfields.x != 12) ? 1.0 : 0.0;
    float3 specialShadingModelFlags = (shadingModelBitfields.xxx == int3(13, 14, 15)) ? 1.0 : 0.0;
    float isSpecialModel_yz = (int)specialShadingModelFlags.y | (int)specialShadingModelFlags.z;
    float isAnySpecialModel = (int)isSpecialModel_yz | (int)specialShadingModelFlags.x;
    float shadingModelOverride = isNotClothShadingModel ? isAnySpecialModel : -1.0;

    float3 worldNormal;
    float3 initialLighting;
    float hairShadowingFactor = 0.0;
    float3 final_gbuffer_normal = gbuffer_normal; 
    
    if (shadingModelOverride != 0.0)
    {
        float debug_shadingInfo_x = (specialShadingModelFlags.x != 0.0) ? 13.0 : 12.0;
        float2 debug_shadingModelFlags_xz = (specialShadingModelFlags.yz != float2(0.0, 0.0)) ? float2(1.0, 1.0) : float2(0.0, 0.0);

        float2 encodedNormal = gbuffer_normal.yz * 2.0 - 1.0;
        float encodedNormalAbsSum = dot(float2(1.0, 1.0), abs(encodedNormal));
        float worldNormalZ_unpacked = 1.0 - encodedNormalAbsSum;
        float unpack_factor = max(0.0, -worldNormalZ_unpacked);
        float2 lightingSign = (encodedNormal >= float2(0.0, 0.0)) ? float2(1.0, 1.0) : float2(0.0, 0.0);
        float2 lightingOffset = (lightingSign * 2.0 - 1.0) * 0.5;
        lightingOffset = lightingOffset * unpack_factor;
        float2 worldNormalXY_unpacked = lightingOffset * -2.0 + encodedNormal;
        worldNormal = float3(worldNormalXY_unpacked.x, worldNormalXY_unpacked.y, worldNormalZ_unpacked);
        float worldNormalLengthInv = rsqrt(dot(worldNormal, worldNormal));
        worldNormal = worldNormal * worldNormalLengthInv;

        initialLighting = msr * msr;
        hairShadowingFactor = customDataA_and_Temp.z;
    }
    else
    {
        float isClearCoatModel = (shadingModelBitfields.x == 10) ? 1.0 : 0.0;
        if (isClearCoatModel != 0.0)
        {
            float3 saturated_msr = saturate(msr);
            float3 scaled_msr = float3(16777215.0, 65535.0, 255.0) * saturated_msr;
            uint3 rounded_msr = (uint3)round(scaled_msr);
            
            uint packed_val_y = (rounded_msr.y & ~0xFFFFFF00u) | (rounded_msr.z & 0xFFu);
            uint packed_val_x = (rounded_msr.x & ~0xFFFF0000u) | (packed_val_y & 0xFFFFu);

            float packed_depth_float = 5.96046519e-08 * (float)packed_val_x;
            float linear_depth_temp = packed_depth_float * cb1[65].x + cb1[65].y;
            float linear_depth_p1 = packed_depth_float * cb1[65].z - cb1[65].w;
            float linear_depth_p2 = 1.0 / linear_depth_p1;
            float final_packed_depth = linear_depth_temp + linear_depth_p2;
            
            depth = final_packed_depth;
        }

        worldNormal = gbuffer_normal * 2.0 - 1.0;
        initialLighting = float3(0.0, 0.0, 0.0);
        specialShadingModelFlags = float3(0.0, 0.0, 0.0);
        perObjectData = 0.0;
        final_gbuffer_normal.z = 0.0; 
        customDataA_and_Temp.xy = float2(0.0, 0.0);
    }
    
    float worldNormalLengthRsqrt = rsqrt(dot(worldNormal, worldNormal));
    float3 normalizedWorldNormal = worldNormal * worldNormalLengthRsqrt;

    float isShadingModel_5 = (shadingModelBitfields.x == 5) ? 1.0 : 0.0;
    float isShadingModel_13 = (shadingModelBitfields.x == 13) ? 1.0 : 0.0;
    
    float hasValidFogData = (0.0 < cb1[162].y) ? 1.0 : 0.0;
    float hasVolumetricFog = (0.0 < cb1[220].z) ? 1.0 : 0.0;
    float useVolumetricFog = hasValidFogData ? hasVolumetricFog : 0.0;
    float useDitheredLodTransition = (0.0 != cb1[162].y) ? 1.0 : 0.0;
    
    float3 processedBaseColor = useDitheredLodTransition ? float3(1.0, 1.0, 1.0) : baseColor;
    float useOddPixelResult = isOddPixel ? 1.0 : 0.0;
    processedBaseColor = useVolumetricFog ? useOddPixelResult.xxx : processedBaseColor;
    baseColor = (worldNormalLengthRsqrt > 0.0) ? processedBaseColor : baseColor;
    
    float aoFactor = tex2Dlod(_IN9, float4(0.0, 0.0, 0.0, 0.0)).x;

    float3 worldPos = depth * cb1[50].xyz;
    worldPos = (useDitheredLodTransition * cb1[48].xyz) + worldPos;
    worldPos = cb1[51].xyz + worldPos;

    float2 ssrParams = tex2Dlod(_IN5, float4(screenUV.xy, 0, 0)).xz;
    float2 ssrParamsSq = ssrParams * ssrParams;
    float ssrIntensity = ssrParamsSq.x * ssrParamsSq.y;

    float ssrTerm_preBlend = cb1[253].y * ssrIntensity;

    float3 indirectLightingResult;
    float3 diffuseIBLBase;
    
    if (cb1[255].x != 0.0)
    {
        float3 accumulatedGIBounceColor = float3(0.0, 0.0, 0.0);
        float giRadius = 0.0;
        float giTotalWeight = 0.0;
        float giAngleCounter = 0.0;
        
        for (int i = 0; i < 3; ++i)
        {
            float sampleRadius = 0.000833333295 + giRadius;
            float3 currentLoopColor = accumulatedGIBounceColor;
            float currentSampleAngle = giAngleCounter;
            
            for (int j = 0; j < 3; ++j)
            {
                currentSampleAngle = 1.0 + currentSampleAngle;
                float angle_rad = 2.09439516 * currentSampleAngle;
                float sin_a, cos_a;
                sincos(angle_rad, sin_a, cos_a);
                float2 sampleUV_offset = float2(cos_a, sin_a) * sampleRadius;
                float2 sampleUV = screenUV.xy + sampleUV_offset;
                float3 giSampleColor = tex2D(_IN7, sampleUV).xyz;
                
                currentLoopColor = giSampleColor * sampleRadius + currentLoopColor;
                giTotalWeight = giTotalWeight + sampleRadius;
            }
            accumulatedGIBounceColor = currentLoopColor;
            giAngleCounter = 0.620000005 + currentSampleAngle;
            giRadius = sampleRadius;
        }
        
        float3 finalGIColor = accumulatedGIBounceColor / giTotalWeight;

        float3 perObjectMask_high = (float3(0.644999981, 0.312000006, 0.978999972) < perObjectData.xxx) ? 1.0 : 0.0;
        float3 perObjectMask_low = (perObjectData.xxx < float3(0.685000002, 0.351999998, 1.02100003)) ? 1.0 : 0.0;
        float3 perObjectMask = perObjectMask_high * perObjectMask_low;
        float maskResult = perObjectMask.z ? 1.0 : 0.0;
        maskResult = perObjectMask.y ? 0.0 : maskResult;
        maskResult = perObjectMask.x ? 1.0 : maskResult;
        
        float isMaskYorZ = (int)perObjectMask.y | (int)perObjectMask.z;
        float specularMask = (perObjectMask.x != 0.0) ? 0.0 : isMaskYorZ;

        float customData_rounded = round(255.0 * customDataA_and_Temp.x);
        uint4 customDataMasks = (uint4)((uint)customData_rounded) & uint4(15, 240, 240, 15);
        
        float fresnelTerm_IBL = saturate(final_gbuffer_normal.z + final_gbuffer_normal.z);
        float fresnel_factor1_IBL = fresnelTerm_IBL * -2.0 + 3.0;
        fresnelTerm_IBL = fresnelTerm_IBL * fresnelTerm_IBL;
        float roughness_from_normal = fresnel_factor1_IBL * fresnelTerm_IBL;

        float roughness_term = saturate(final_gbuffer_normal.z * 2.0 - 0.5 * 2.0);
        float roughness_factor = roughness_term * -2.0 + 3.0;
        roughness_term = roughness_term * roughness_term;
        float roughness_final = roughness_factor * roughness_term;
        
        float3 color_diff = cb1[262].xyz - cb1[261].xyz;
        float luma = dot(abs(color_diff), float3(0.300000012, 0.589999974, 0.109999999));
        float luma_scaled = min(1.0, 10.0 * luma);
        float luma_factor = luma_scaled * -2.0 + 3.0;
        luma_scaled = luma_scaled * luma_scaled;
        float luma_fresnel = luma_factor * luma_scaled;
        
        float blended_roughness = luma_fresnel * roughness_final;
        
        float blend_range = cb1[265].y - cb1[265].x;
        float blend_inv_range = 1.0 / blend_range;
        float blend_val = ssrTerm_preBlend - cb1[265].x;
        float blend_ratio = saturate(blend_val * blend_inv_range);
        float blend_factor = blend_ratio * -2.0 + 3.0;
        blend_ratio = blend_ratio * blend_ratio;
        float blend_fresnel = blend_factor * blend_ratio;
        
        float final_blend = blend_fresnel * blended_roughness;
        float ssr_term = ssrTerm_preBlend - final_blend;
        float final_ssr = cb1[265].z * ssr_term + final_blend;
        
        float ssr_clamped = -cb1[265].x + final_ssr;
        float ssr_ratio = saturate(ssr_clamped * blend_inv_range);
        float ssr_factor = ssr_ratio * -2.0 + 3.0;
        ssr_ratio = ssr_ratio * ssr_ratio;
        float ssr_fresnel = ssr_factor * ssr_ratio;
        blended_roughness = ssr_fresnel * blended_roughness;
        
        float combined_roughness = roughness_final * luma_fresnel - blended_roughness;
        combined_roughness = cb1[265].z * combined_roughness + blended_roughness;
        
        float final_spec_occlusion = cb1[260].y * (final_ssr - 1.0) + 1.0;
        float spec_ao_combined = roughness_from_normal * combined_roughness - final_spec_occlusion;
        final_spec_occlusion = specialShadingModelFlags.x * spec_ao_combined + final_spec_occlusion;
        
        float spec_ao_combined_2 = roughness_from_normal * combined_roughness - combined_roughness;
        float accumulatedLightColor_x = specialShadingModelFlags.x * spec_ao_combined_2 + combined_roughness;
        
        float3 hsv_modulated_color;
        {
            float hsv_check = (finalGIColor.y >= finalGIColor.z) ? 1.0 : 0.0;
            float2 hsv_prep1 = finalGIColor.zy;
            float4 hsv_consts1 = float4(-1.0, 0.666666687, 1.0, -1.0);
            float4 hsv_interp1 = hsv_check * (-hsv_prep1.xyxy + finalGIColor.yzyy) + float4(hsv_prep1.x, hsv_prep1.y, hsv_consts1.z, hsv_consts1.w);
            float hsv_check2 = (finalGIColor.x >= hsv_interp1.x) ? 1.0 : 0.0;
            float4 hsv_prep2 = float4(hsv_interp1.x, hsv_interp1.y, hsv_interp1.w, finalGIColor.x);
            float4 hsv_interp2 = hsv_check2 * (hsv_prep2.wyxz - hsv_prep2.xyzw) + hsv_prep2;
            float hsv_V_minus_min = hsv_interp2.x - min(hsv_interp2.w, hsv_interp2.y);
            float hsv_V_minus_min_plus_delta = hsv_interp2.w - hsv_interp2.y;
            float hsv_H = hsv_interp2.z + hsv_V_minus_min_plus_delta / (hsv_V_minus_min * 6.0 + 0.00100000005);
            float hsv_S = hsv_V_minus_min / (hsv_interp2.x + 0.00100000005);
            float4 customDataMasks_shifted = (float4)customDataMasks * float4(0.0400000028, 0.0027450982, 0.00392156886, 0.0666666701) + float4(0.400000006, 0.400000006, 1.0, 0.5);
            float custom_mask_z_check = (customDataMasks.z >= 2.54999971) ? 1.0 : 0.0;
            float custom_mask_x = custom_mask_z_check * (customDataMasks_shifted.y - customDataMasks_shifted.x) + customDataMasks_shifted.x;
            hsv_S = min(0.349999994, custom_mask_x * hsv_S);
            float hsv_S_clamped = max(0.0, hsv_S);
            float3 hsv_frac_H = frac(float3(1.0, 0.666666687, 0.333333343) + hsv_H.xxx);
            float3 hsv_remap_H = saturate(abs(hsv_frac_H * 6.0 - 3.0) - 1.0);
            float3 hsv_to_rgb_base = hsv_remap_H - 1.0;
            float3 hsv_to_rgb_interp = hsv_S_clamped * hsv_to_rgb_base + 1.0;
            float3 base_hsv_rgb = hsv_to_rgb_interp * (hsv_S_clamped + 1.0);
            float3 lerp_factor_1 = hsv_to_rgb_interp * hsv_S_clamped - 1.0;
            lerp_factor_1 = lerp_factor_1 * 0.600000024 + 1.0;
            float3 lerp_factor_2 = -hsv_to_rgb_interp * hsv_S_clamped + lerp_factor_1;
            float3 final_hsv_rgb_1 = maskResult * lerp_factor_2 + base_hsv_rgb;
            float3 final_hsv_rgb_2 = (final_hsv_rgb_1 - baseColor) * 0.850000024 + baseColor;
            float3 hsv_blend_factor = customDataMasks_shifted.z * final_hsv_rgb_2 - final_hsv_rgb_1;
            float3 final_hsv_rgb_3 = custom_mask_z_check * hsv_blend_factor + final_hsv_rgb_1;
            hsv_modulated_color = (-1.0 + final_hsv_rgb_3) * customDataMasks_shifted.w + 1.0;
        }
        
        float3 indirect_spec_base = 0.200000003 * cb1[261].xyz;
        float3 indirect_spec_add = cb1[262].xyz * 0.5 - indirect_spec_base;
        indirect_spec_base = final_spec_occlusion * indirect_spec_add + indirect_spec_base;
        indirect_spec_base = cb1[260].xxx * indirect_spec_base;
        indirect_spec_base = indirect_spec_base * baseColor;
        
        float3 indirect_spec_lit = indirect_spec_base * initialLighting;
        float3 indirect_diffuse_lit = cb1[261].xyz * baseColor;
        float ibl_factor = roughness_from_normal * 0.300000012 + 0.699999988;
        diffuseIBLBase = indirect_diffuse_lit * ibl_factor;
        
        float3 ibl_spec_base_plus_diffuse = diffuseIBLBase + indirect_spec_lit;
        float3 hsv_modulated_ibl_spec_base = ibl_spec_base_plus_diffuse * hsv_modulated_color;
        
        float3 ibl_diffuse_add = baseColor * cb1[262].xyz - diffuseIBLBase;
        float3 ibl_diffuse_lerp = ibl_diffuse_add * 0.400000006 + diffuseIBLBase;
        
        float3 ibl_spec_occluded = diffuseIBLBase * hsv_modulated_color;
        float3 ibl_diffuse_occluded = (ibl_diffuse_lerp * hsv_modulated_color) - ibl_spec_occluded;
        float3 ibl_diffuse_final = accumulatedLightColor_x * ibl_diffuse_occluded + ibl_spec_occluded;
        
        float3 lightLoopTempA_resolved = indirect_spec_lit + ibl_diffuse_final;

        float3 ibl_spec_lerp = (initialLighting * hsv_modulated_color) - hsv_modulated_ibl_spec_base;
        float3 final_ibl_spec = accumulatedLightColor_x * ibl_spec_lerp + hsv_modulated_ibl_spec_base;
        
        float occlusion_from_bent_normal = tex2Dlod(_IN8, float4(screenUV.xy, 0, 0)).x;
        occlusion_from_bent_normal = specularMask * (occlusion_from_bent_normal - 1.0) + 1.0;
        
        float3 final_ibl_spec_temp = final_ibl_spec - lightLoopTempA_resolved;
        final_ibl_spec = luma_fresnel * final_ibl_spec_temp + lightLoopTempA_resolved;
        
        float3 ibl_unoccluded = float3(1.0, 1.0, 1.0) - hsv_modulated_ibl_spec_base;
        float3 occluded_ibl_spec_base = occlusion_from_bent_normal * ibl_unoccluded + hsv_modulated_ibl_spec_base;
        
        indirectLightingResult = final_ibl_spec * occluded_ibl_spec_base;
    }
    else
    {
        float fresnelTerm_NdotV_alt = saturate(final_gbuffer_normal.z + final_gbuffer_normal.z);
        float fresnel_factor1_alt = fresnelTerm_NdotV_alt * -2.0 + 3.0;
        fresnelTerm_NdotV_alt = fresnelTerm_NdotV_alt * fresnelTerm_NdotV_alt;
        float fresnel_NdotV_alt = fresnel_factor1_alt * fresnelTerm_NdotV_alt;
        
        float roughness_term_alt = saturate(final_gbuffer_normal.z * 2.0 - 1.0);
        float specularMask_alt = roughness_term_alt * -2.0 + 3.0;
        roughness_term_alt = roughness_term_alt * roughness_term_alt;
        float roughness_final_alt = specularMask_alt * roughness_term_alt;
        
        float3 color_diff_alt = cb1[262].xyz - cb1[261].xyz;
        float luma_alt = dot(abs(color_diff_alt), float3(0.300000012, 0.589999974, 0.109999999));
        luma_alt = min(1.0, 10.0 * luma_alt);
        float luma_factor_alt = luma_alt * -2.0 + 3.0;
        luma_alt = luma_alt * luma_alt;
        float luma_fresnel_alt = luma_factor_alt * luma_alt;
        
        float blended_roughness_alt = luma_fresnel_alt * roughness_final_alt;
        
        float blend_range_alt = cb1[265].y - cb1[265].x;
        float blend_inv_range_alt = 1.0 / blend_range_alt;
        float blend_val_alt = ssrIntensity * cb1[253].y - cb1[265].x;
        float blend_ratio_alt = saturate(blend_val_alt * blend_inv_range_alt);
        float blend_factor_alt = blend_ratio_alt * -2.0 + 3.0;
        blend_ratio_alt = blend_ratio_alt * blend_ratio_alt;
        float blend_fresnel_alt = blend_factor_alt * blend_ratio_alt;
        
        float final_blend_alt = blend_fresnel_alt * blended_roughness_alt;
        float ssr_term_alt = ssrIntensity * cb1[253].y - final_blend_alt;
        float final_ssr_alt = cb1[265].z * ssr_term_alt + final_blend_alt;
        
        float ssr_clamped_alt = -cb1[265].x + final_ssr_alt;
        float ssr_ratio_alt = saturate(ssr_clamped_alt * blend_inv_range_alt);
        float ssr_factor_alt = ssr_ratio_alt * -2.0 + 3.0;
        ssr_ratio_alt = ssr_ratio_alt * ssr_ratio_alt;
        float ssr_fresnel_alt = ssr_factor_alt * ssr_ratio_alt;
        blended_roughness_alt = ssr_fresnel_alt * blended_roughness_alt;
        
        float combined_roughness_alt = roughness_final_alt * luma_fresnel_alt - blended_roughness_alt;
        combined_roughness_alt = cb1[265].z * combined_roughness_alt + blended_roughness_alt;
        
        float final_spec_occlusion_alt = cb1[260].y * (final_ssr_alt - 1.0) + 1.0;
        float spec_ao_combined_alt = aoFactor * combined_roughness_alt - final_spec_occlusion_alt;
        final_spec_occlusion_alt = specialShadingModelFlags.x * spec_ao_combined_alt + final_spec_occlusion_alt;
        
        float spec_ao_combined_2_alt = aoFactor * combined_roughness_alt - combined_roughness_alt;
        float accumulatedLightColor_x_alt = specialShadingModelFlags.x * spec_ao_combined_2_alt + combined_roughness_alt;
        
        float3 indirect_spec_base_alt = 0.200000003 * cb1[261].xyz;
        float3 indirect_spec_add_alt = cb1[262].xyz * 0.5 - indirect_spec_base_alt;
        indirect_spec_base_alt = final_spec_occlusion_alt * indirect_spec_add_alt + indirect_spec_base_alt;
        indirect_spec_base_alt = cb1[260].xxx * indirect_spec_base_alt;
        indirect_spec_base_alt = indirect_spec_base_alt * baseColor;
        
        float3 indirect_spec_lit_alt = indirect_spec_base_alt * initialLighting;
        float3 indirect_diffuse_lit_alt = cb1[261].xyz * baseColor;
        float ibl_factor_alt = fresnel_NdotV_alt * 0.300000012 + 0.699999988;
        
        diffuseIBLBase = indirect_diffuse_lit_alt * ibl_factor_alt;
        
        float3 temp_spec_plus_diffuse_base = diffuseIBLBase + indirect_spec_lit_alt;
        float3 temp_lighting_C = luma_fresnel_alt * indirect_spec_lit_alt + temp_spec_plus_diffuse_base;
        
        float3 temp_diffuse_add = baseColor * cb1[262].xyz - diffuseIBLBase;
        temp_diffuse_add = temp_diffuse_add * accumulatedLightColor_x_alt;
        float3 temp_diffuse_final = temp_diffuse_add * 0.400000006 + diffuseIBLBase;

        float3 term_B_final = indirect_spec_lit_alt + temp_diffuse_final;

        float3 term_A_base = baseColor * cb1[262].xyz - temp_lighting_C;
        float3 term_A_final = accumulatedLightColor_x_alt * term_A_base + temp_lighting_C;

        float3 term_A_minus_B = term_A_final - term_B_final;
        indirectLightingResult = final_spec_occlusion_alt * term_A_minus_B + term_B_final;
    }

    float subsurf_scatter_term = saturate(10.000001 * (final_gbuffer_normal.z - 0.400000006));
    float subsurf_fresnel_factor = subsurf_scatter_term * -2.0 + 3.0;
    subsurf_scatter_term = subsurf_scatter_term * subsurf_scatter_term;
    float subsurf_fresnel = subsurf_fresnel_factor * subsurf_scatter_term;

    float3 preLoopLighting_IBL = indirectLightingResult * 0.5 + cb1[261].xyz;
    preLoopLighting_IBL = preLoopLighting_IBL * baseColor;
    float3 preLoopLighting_NonIBL = cb1[261].xyz * baseColor;
    float3 chosenPreLoopLighting = (cb1[255].x != 0.0) ? preLoopLighting_IBL : preLoopLighting_NonIBL;

    diffuseIBLBase = isShadingModel_5 ? chosenPreLoopLighting : diffuseIBLBase;
    indirectLightingResult = isShadingModel_5 ? chosenPreLoopLighting : indirectLightingResult;
    
    float finalSubsurfTerm = isShadingModel_5 ? 0.0 : subsurf_fresnel;
    float finalSubsurfScatter = isShadingModel_5 ? 0.0 : subsurf_scatter_term;
    
    float3 foggedLighting = (finalSubsurfTerm * (cb1[264].xyz + cb1[264].xyz)) - cb1[264].xyz;
    float3 lightAccumulator = float3(0.0, 0.0, 0.0);
    float lightLoopFalloff = 1.0;
    
    uint lightLoopCounter = 0;
    uint numLights = asuint(cb2[128].x);
    
    while (lightLoopCounter < numLights)
    {
        uint lightIndex_base = lightLoopCounter << 3;
        uint lightDataIndex = lightIndex_base | 7;
        uint lightTypeMask = (uint)shadingModelBitfields.y & (((asuint(cb2[lightDataIndex].w) << 5) & 0xffffffe0));
        
        if (lightTypeMask != 0)
        {
            float3 lightPos = cb2[lightIndex_base + 0].xyz - worldPos;
            float lightRadiusSq_inv = cb2[lightIndex_base + 0].w * cb2[lightIndex_base + 0].w;
            float distToLightSq = dot(lightPos, lightPos);
            float lightAttenuation = distToLightSq * lightRadiusSq_inv;
            
            if (1.0 >= lightAttenuation)
            {
                float lightAttenFactor = saturate(lightAttenuation * 2.5 - 1.5);
                float lightAttenFresnel = (lightAttenFactor * -2.0 + 3.0) * (-lightAttenFactor * lightAttenFactor) + 1.0;
                float rsqrtDistToLight = rsqrt(distToLightSq);
                float3 lightVec = lightPos * rsqrtDistToLight;
                float NdotL = dot(normalizedWorldNormal, lightVec);
                float shadowKernelTerm = (NdotL + 1.0) * 0.5 - (cb2[lightIndex_base + 5].w * 0.939999998);
                float shadowInvRange = 1.0 / (cb2[lightIndex_base + 5].w * 0.0600000024);
                float shadowFactor = saturate(shadowInvRange * shadowKernelTerm);
                float shadowFresnel = (shadowFactor * -2.0 + 3.0) * (shadowFactor * shadowFactor);
                shadowFactor = min(1.0, shadowFresnel);
                float3 shadowColor_base = cb2[lightIndex_base + 6].xyz * foggedLighting.xyz;
                float3 shadowLerp = baseColor * cb2[lightIndex_base + 5].xyz - shadowColor_base;
                float3 shadowColor = shadowFactor * shadowLerp + shadowColor_base;
                shadowColor = cb2[lightDataIndex].xxx * shadowColor;
                
                float currentLightFalloff = distToLightSq * cb2[lightIndex_base + 4].x + cb2[lightIndex_base + 4].y;
                currentLightFalloff = 1.0 / (9.99999975e-05 + currentLightFalloff);
                currentLightFalloff = (currentLightFalloff - 1.0) * cb2[lightIndex_base + 4].z;
                currentLightFalloff = min(1.0, currentLightFalloff * currentLightFalloff);
                
                uint lightFlags = asuint(cb2[lightIndex_base + 1].w) >> 16;
                if (lightFlags == 2)
                {
                    float spotFactor = dot(lightVec, cb2[lightIndex_base + 1].xyz);
                    spotFactor = saturate(cb2[lightIndex_base + 2].y * (spotFactor - cb2[lightIndex_base + 2].x));
                    spotFactor = spotFactor * spotFactor * spotFactor * spotFactor;
                    currentLightFalloff = spotFactor * currentLightFalloff;
                }
                
                float subsurf_final = (finalSubsurfTerm * saturate(NdotL * 0.5 + 0.5)) - finalSubsurfScatter;
                subsurf_final = cb2[lightIndex_base + 4].w * subsurf_final + finalSubsurfScatter;
                float3 lightColor_direct_base = cb2[lightIndex_base + 3].www * shadowColor;
                float3 lightColor_indirect = baseColor - lightColor_direct_base;
                float3 lightColor_direct = subsurf_final * lightColor_indirect + lightColor_direct_base;
                lightColor_direct = cb2[lightIndex_base + 3].xyz * lightColor_direct;
                
                float totalLightIntensity = cb2[lightIndex_base + 3].x + cb2[lightIndex_base + 3].y + cb2[lightIndex_base + 3].z + cb2[lightDataIndex].x;
                float lightIntensityFactor = saturate(10.0 * totalLightIntensity);
                float visibilityTerm = cb2[lightDataIndex].y * lightIntensityFactor;

                float3 finalLightColor_this_loop = lightColor_direct * currentLightFalloff;

                currentLightFalloff = lightAttenFresnel - currentLightFalloff;
                currentLightFalloff = cb2[lightIndex_base + 6].w * currentLightFalloff + currentLightFalloff;
                lightAccumulator = finalLightColor_this_loop * lightLoopFalloff + lightAccumulator;
                visibilityTerm = 1.0 - (currentLightFalloff * visibilityTerm);
                lightLoopFalloff = visibilityTerm * lightLoopFalloff;
            }
        }
        lightLoopCounter = lightLoopCounter + 1;
    }
    
    float3 preSssLighting = lightLoopFalloff * indirectLightingResult + lightAccumulator;
    
    float3 sssColor = float3(0.0, 0.0, 0.0);
    float reprojected_fresnel = finalSubsurfTerm;
    
    float isNotEyeShadingModel = (shadingModelBitfields.x != 13) ? 1.0 : 0.0;
    if (isNotEyeShadingModel != 0.0)
    {
        float isSubsurfaceProfileModel = (shadingModelBitfields.x == 1) ? 1.0 : 0.0;
        
        float scatterRadius = isSubsurfaceProfileModel ? customDataA_and_Temp.z : customDataA_and_Temp.y;
        
        float3 viewVec = cb1[67].xyz - worldPos;
        float viewVecLengthInv = rsqrt(dot(viewVec, viewVec));
        viewVec = viewVec * viewVecLengthInv;
        float scatterRadiusClamped = saturate(scatterRadius - 0.100000001);
        scatterRadius = saturate(10.0 * scatterRadius);
        float scatterPower = scatterRadiusClamped * 2000.0 + 50.0;
        float scatterKernelSize = scatterRadiusClamped + scatterRadiusClamped;
        scatterRadius = cb0[0].x * scatterRadius;
        scatterRadius = scatterRadius * 0.800000012 + scatterKernelSize;
        
        float3x3 tangentToWorld;
        tangentToWorld[0] = cb1[20].xyz;
        tangentToWorld[1] = cb1[21].xyz;
        tangentToWorld[2] = cb1[22].xyz;
        float3 worldNormalFromTangent = mul(normalizedWorldNormal, tangentToWorld);
        
        bool useStaticLighting = (asint(cb0[0].w) > 0.5);
        viewVec = useStaticLighting ? float3(0.0, 0.0, 0.0) : viewVec;
        float3 lightDir = useStaticLighting ? float3(cb0[0].y, cb0[0].z, 0.5) : cb1[264].xyz;
        float3 sssNormal = useStaticLighting ? worldNormalFromTangent : normalizedWorldNormal;
        
        float NdotL_final = dot(lightDir, sssNormal);
        float NdotL_remap = saturate(5.0 * (0.200000003 + NdotL_final));
        float NdotL_fresnel = (NdotL_remap * -2.0 + 3.0) * (NdotL_remap * NdotL_remap);
        
        float3 halfVec = normalize(lightDir + viewVec);
        float NdotH = saturate(dot(sssNormal, halfVec));
        float NdotH_sq = NdotH * NdotH;
        float specTerm = (NdotH_sq * -0.800000012 + 1.0);
        specTerm = specTerm * specTerm;
        specTerm = 0.200000003 / (3.14159274 * specTerm);
        specTerm = specTerm * scatterRadiusClamped;
        
        float LdotV = dot(lightDir, viewVec);
        float LdotV_remap = saturate((LdotV + LdotV) - 1.0 + 1.0);
        float LdotV_fresnel = (LdotV_remap * -2.0 + 3.0) * (LdotV_remap * LdotV_remap) + 1.0;
        
        float VdotN = saturate(dot(viewVec, sssNormal));
        float schlick_V = max(0.0, 0.800000012 - VdotN);
        float screen_space_subsurf_falloff = min(1.74532926, max(0.0, cb1[133].x));
        float2 schlick_and_falloff = float2(schlick_V, screen_space_subsurf_falloff) * float2(1.5, 0.572957814);
        
        float depth_clamped = max(0.0, depth);
        float2 depth_remap_vals = min(float2(3000.0, 50.0), float2(depth_clamped, depth_clamped));
        depth_remap_vals = (float2(3000.0, 50.0) - depth_remap_vals) * float2(0.00033333333, 0.0199999996);
        float depth_falloff = depth_remap_vals.x * depth_remap_vals.x;
        depth_falloff = depth_falloff * depth_falloff;
        depth_falloff = depth_falloff * depth_falloff + depth_remap_vals.y;
        
        float sss_profile_lerp = (depth_falloff - 1.0) * schlick_and_falloff.y + 1.0;
        float sss_profile_final = (1.0 - sss_profile_lerp) * scatterRadiusClamped + sss_profile_lerp;
        
        float schlick_final = (NdotL_final * 0.25 + 0.5) * schlick_and_falloff.x;
        schlick_final = schlick_final * sss_profile_final;
        schlick_final = schlick_final * LdotV_fresnel;
        schlick_final = 0.00999999978 * schlick_final;
        
        float2 worldNormalXY_sq_plus_eps = sssNormal.xy * sssNormal.xy + 9.99999975e-05;
        float rsqrt_normal_xy = rsqrt(dot(worldNormalXY_sq_plus_eps, float2(1.0, 1.0)));
        float2 normal_xy_normalized = sssNormal.xy * rsqrt_normal_xy;
        normal_xy_normalized = normal_xy_normalized * scatterRadius;
        
        float sss_lobe_y_component = schlick_final * normal_xy_normalized.y;
        float2 sss_lobes = float2(normal_xy_normalized.x * schlick_final, sss_lobe_y_component * -0.5);
        
        float2 uv_offset = (screenUV.xy * cb1[138].xy - cb1[134].xy) * cb1[135].zw + sss_lobes;
        float2 final_uv = (uv_offset * cb1[135].xy + cb1[134].xy) * cb1[138].zw;
        
        float reprojectedDepth_raw = tex2D(_IN6, final_uv).x;
        float reprojectedViewDepth_temp = reprojectedDepth_raw * cb1[65].x + cb1[65].y;
        reprojectedDepth_raw = 1.0 / (reprojectedDepth_raw * cb1[65].z - cb1[65].w);
        float reprojectedViewDepth = reprojectedViewDepth_temp + reprojectedDepth_raw;
        
        float depth_diff = max(9.99999975e-05, reprojectedViewDepth - depth);
        float reprojected_falloff = saturate((depth_diff - scatterRadiusClamped * 1000.0) / scatterPower);
        float reprojected_fresnel_temp = (reprojected_falloff * -2.0 + 3.0) * (reprojected_falloff * reprojected_falloff);
        reprojected_fresnel = min(1.0, reprojected_fresnel_temp);
        
        float ambient_luma = dot(cb1[263].xyz, float3(0.300000012, 0.589999974, 0.109999999));
        float3 ambient_color = (cb1[263].xyz - ambient_luma) * 0.75 + ambient_luma;
        ambient_color = reprojected_fresnel * (cb1[263].xyz - ambient_color) + ambient_color;
        ambient_color = ambient_color * scatterRadius;
        ambient_color = ambient_color * 0.100000001;
        float3 ambient_base = (1.0 + baseColor) * ambient_color;
        float3 spec_highlight_mask = saturate((baseColor * 1.20000005) - 1.0);
        float3 spec_highlight_factor = (spec_highlight_mask * -2.0 + 3.0) * (spec_highlight_mask * spec_highlight_mask);
        spec_highlight_factor = spec_highlight_factor * 14.0 + 1.0;
        ambient_color = spec_highlight_factor * ambient_color;
        ambient_color = (ambient_color * baseColor) - ambient_base;
        ambient_color = cb1[260].zzz * ambient_color + ambient_base;
        ambient_color = ambient_color * reprojected_fresnel;
        
        float fog_factor = 0.000199999995 * (5000.0 - min(5000.0, max(0.0, depth - 10000.0)));
        ambient_color = fog_factor * ambient_color;
        sssColor = cb0[1].xyz * ambient_color;
    }
    
    float3 baseLighting = preSssLighting * initialLighting.xyz;
    baseLighting = cb1[263].xyz * baseLighting;
    baseLighting = (baseLighting * 0.5) - preSssLighting;
    baseLighting = reprojected_fresnel * baseLighting + preSssLighting;
    
    float3 finalCompositedColor = preSssLighting + sssColor;

    finalCompositedColor = (specialShadingModelFlags.z != 0.0) ? baseLighting : finalCompositedColor;

    float3 finalColorXYZ = isShadingModel_5 ? preSssLighting : finalCompositedColor;
    
    finalColorXYZ = finalColorXYZ / aoFactor;
    
    finalColorXYZ = min(float3(0.0, 0.0, 0.0), -finalColorXYZ);
    
    float4 finalColor;
    finalColor.xyz = -finalColorXYZ;
    finalColor.w = 0.0;
    
    return finalColor;
}

            ENDCG
        }
    }
}