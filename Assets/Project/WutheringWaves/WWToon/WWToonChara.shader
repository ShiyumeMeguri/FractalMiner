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
    float4 v0 = fragmentInput.uv;

    float4 color = 0;

    // --- 输入纹理采样 (Input Texture Sampling) ---
    float4 rawSDFMask_octNormal_Diffuse = tex2Dlod(_IN1, float4(v0.xy, 0, 0)).wxyz;
    float SDFMask = rawSDFMask_octNormal_Diffuse.x;
    float2 octNormal = rawSDFMask_octNormal_Diffuse.yz;
    float diffuse = rawSDFMask_octNormal_Diffuse.w;
    float3 otherNormalData = rawSDFMask_octNormal_Diffuse.yzw;

    float4 rawShadowColor_ShadeMode = tex2Dlod(_IN2, float4(v0.xy, 0, 0)).xyzw;
    float3 initialShadowColor = rawShadowColor_ShadeMode.xyz;
    float packedShadeAndOutputMask = rawShadowColor_ShadeMode.w;

    float3 albedo = tex2Dlod(_IN3, float4(v0.xy, 0, 0)).xyz;

    float3 swizzledTex4 = tex2Dlod(_IN4, float4(v0.xy, 0, 0)).yxz;
    float toonSkinMaskY = swizzledTex4.y;
    float toonSkinMaskX = swizzledTex4.x;
    float toonSkinMaskZ = swizzledTex4.z;

    float rawDeviceDepth = tex2Dlod(_IN0, float4(v0.xy, 0, 0)).x;
    float viewSpaceDepth_numerator = rawDeviceDepth * cb1[65].x + cb1[65].y;
    float viewSpaceDepth_denominator_term = rawDeviceDepth * cb1[65].z - cb1[65].w;
    float viewSpaceDepth_denominator_inv = 1.0f / viewSpaceDepth_denominator_term;
    float linearEyeDepth = viewSpaceDepth_numerator + viewSpaceDepth_denominator_inv;

    // --- 抖动模式 (Dither Pattern) ---
    float2 screenCoordScaled = cb1[138].xy * v0.xy;
    uint2 screenCoordInt = (uint2)screenCoordScaled;
    uint ditherPatternSelector = (uint)cb1[158].x;
    int screenCoordSum = (int)screenCoordInt.y + (int)screenCoordInt.x;
    int ditherIndex = (int)ditherPatternSelector + screenCoordSum;
    int ditherFlag = ditherIndex & 1;

    // --- 材质ID与掩码解包 (Material ID & Mask Unpacking) ---
    float packedShadeAndOutputMask_f255 = 255.0f * packedShadeAndOutputMask;
    float packedShadeAndOutputMask_float = round(packedShadeAndOutputMask_f255);
    float packedShadeAndOutputMask_uint = (uint)packedShadeAndOutputMask_float;
    float2 shadeModeAndOutputMask_masked = (int2)packedShadeAndOutputMask_uint & int2(15, -16);
    int shadeMode = shadeModeAndOutputMask_masked.x;
    int outputMask = shadeModeAndOutputMask_masked.y;

    bool isNotFace = (shadeMode != 12);
    bool3 isHairOrAccessoryOrOutfit = (int3(shadeMode, shadeMode, shadeMode) == int3(13, 14, 15));
    bool isHair = isHairOrAccessoryOrOutfit.x;
    bool isAccessory = isHairOrAccessoryOrOutfit.y;
    bool isOutfit = isHairOrAccessoryOrOutfit.z;
    
    bool isAccessoryOrOutfit = isOutfit || isAccessory;
    bool isCharacterSubMaterial = isAccessoryOrOutfit || isHair;
    float characterMaterialType = isNotFace ? (float)isCharacterSubMaterial : -1.0f;

    // --- 分支变量声明 (Branch Variable Declaration) ---
    float3 worldNormal;
    float3 shadowColor; 
    int finalMaterialID;
    float toonSkinMaskZ_branch_val; 
    float accessory_flag; 
    float outfit_flag;    
    
    // --- 材质分支: 角色 vs 场景 (Material Branch: Character vs Scene) ---
    if (characterMaterialType != 0) 
    {
        // 角色路径 (Character Path)
        finalMaterialID = isHair ? 13 : 12;
        accessory_flag = isAccessory ? 1.0f : 0.0f;
        outfit_flag = isOutfit ? 1.0f : 0.0f;
        
        float2 unpackedOctNormal = octNormal * 2.0f - 1.0f;
        float l1_norm = dot(float2(1.0f, 1.0f), abs(unpackedOctNormal));
        float normal_z_unpacked = 1.0f - l1_norm;
        float neg_normal_z = max(0.0f, -normal_z_unpacked);

        float2 signCheck = (unpackedOctNormal >= 0.0f) ? 1.0f : -1.0f;
        float2 signFactors = signCheck * 0.5f;
        
        float2 signFactors_scaled = signFactors * neg_normal_z;
        float2 normal_xy = signFactors_scaled * -2.0f + unpackedOctNormal;
        
        float3 normal_pre_norm = float3(normal_xy.x, normal_xy.y, normal_z_unpacked);
        float normal_len_sq = dot(normal_pre_norm, normal_pre_norm);
        float normal_inv_len = rsqrt(normal_len_sq);
        worldNormal = normal_pre_norm * normal_inv_len;

        shadowColor = initialShadowColor * initialShadowColor;
        toonSkinMaskZ_branch_val = toonSkinMaskZ;
    } 
    else 
    {
        // 场景/其他路径 (Scene/Other Path)
        finalMaterialID = shadeMode;
        bool isLandscape = (shadeMode == 10);

        float3 shadowColor_saturated = saturate(initialShadowColor);
        float3 shadowColor_scaled = shadowColor_saturated * float3(16777215.0f, 65535.0f, 255.0f);
        uint3 shadowColor_uint = (uint3)round(shadowColor_scaled);
        
        uint bitmask_8 = ((~(-1 << 8)) << 0) & 0xffffffff;
        uint G_with_B_low = (((uint)shadowColor_uint.z << 0) & bitmask_8) | ((uint)shadowColor_uint.y & ~bitmask_8);
        uint bitmask_16 = ((~(-1 << 16)) << 0) & 0xffffffff;
        uint R_with_G_low = (((uint)G_with_B_low << 0) & bitmask_16) | ((uint)shadowColor_uint.x & ~bitmask_16);
        
        uint packed_uint_from_color = R_with_G_low;
        float unpacked_float_from_color = 5.96046519e-008f * (float)packed_uint_from_color;

        float depth_from_color_numerator = unpacked_float_from_color * cb1[65].x + cb1[65].y;
        float depth_from_color_denominator_term = unpacked_float_from_color * cb1[65].z - cb1[65].w;
        float depth_from_color_denominator_inv = 1.0f / depth_from_color_denominator_term;
        float linearEyeDepth_from_color = depth_from_color_numerator + depth_from_color_denominator_inv;
        linearEyeDepth = isLandscape ? linearEyeDepth_from_color : linearEyeDepth;

        worldNormal = otherNormalData * 2.0f - 1.0f;

        shadowColor = float3(0, 0, 0);
        toonSkinMaskZ_branch_val = 0.0f;
        accessory_flag = 0.0f;
        outfit_flag = 0.0f;
        SDFMask = 0.0f;
        diffuse = 0.0f;
        toonSkinMaskY = 0.0f;
        toonSkinMaskX = 0.0f;
    }
    // --- 通用计算 (Common Calculations) ---
    float worldNormal_len_sq_combined = dot(worldNormal, worldNormal);
    float worldNormal_inv_len_combined = rsqrt(worldNormal_len_sq_combined);
    float3 finalWorldNormal = worldNormal * worldNormal_inv_len_combined;

    bool isSkin = (finalMaterialID == 5);
    bool isHair_check = (finalMaterialID == 13);
    
    bool useWhiteAlbedo_cond1 = (0.0f < cb1[162].y);
    bool useWhiteAlbedo_cond2 = (0.0f < cb1[220].z);
    bool useWhiteAlbedo = useWhiteAlbedo_cond1 ? useWhiteAlbedo_cond2 : false;

    bool useDebugAlbedo = (0.0f != cb1[162].y);
    float3 albedo_after_debug = useDebugAlbedo ? float3(1, 1, 1) : albedo;
    
    float3 albedo_after_dither_debug = useWhiteAlbedo ? (float3)ditherFlag : albedo_after_debug;
    albedo = isSkin ? albedo_after_dither_debug : albedo;

    float EyeAdaptation = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;

    float2 viewPos_xy = v0.zw * linearEyeDepth;
    float3 worldPos_from_y = cb1[49].xyz * viewPos_xy.y;
    float3 worldPos_from_x = viewPos_xy.x * cb1[48].xyz + worldPos_from_y;
    float3 worldPos_from_z = linearEyeDepth * cb1[50].xyz + worldPos_from_x;
    float3 worldPosition = cb1[51].xyz + worldPos_from_z;
    
    float2 shadow_and_strength = tex2Dlod(_IN5, float4(v0.xy, 0, 0)).xz;
    float2 shadow_and_strength_sq = shadow_and_strength * shadow_and_strength;
    float shadow = shadow_and_strength_sq.x * shadow_and_strength_sq.y;
    float otherShadow = cb1[253].y * shadow;

    // --- 主光照计算 (Main Lighting Calculation) ---
    float3 mainLightingColor;
    // **FIX 2: Declare ramp_color1 before the if/else block to fix scope issue.**
    float3 ramp_color1; 
    
    if (cb1[255].x != 0)
    {
        // Path with extra blur/SSAO-like effect
        float3 blur_accum = float3(0,0,0);
        float blur_outer_loop_angle = 0.0f;
        float blur_inner_loop_start_counter = 0.0f;
        float blur_total_weight = 0.0f;
        
        for (int i = 0; i < 3; ++i)
        {
            if (i >= 3) break;
            blur_outer_loop_angle = 0.000833333295f + blur_outer_loop_angle;
            float3 inner_blur_accum = blur_accum;
            float inner_loop_counter = blur_inner_loop_start_counter;
            float inner_blur_weight = blur_total_weight;
            for (int j = 0; j < 3; ++j)
            {
                if (j >= 3) break;
                inner_loop_counter = 1.0f + inner_loop_counter;
                float sample_angle;
                float sample_angle_cos;
                sincos(2.09439516f * inner_loop_counter, sample_angle, sample_angle_cos);
                float2 sample_uv_offset = float2(sample_angle_cos, sample_angle) * blur_outer_loop_angle;
                float2 sample_uv = v0.xy + sample_uv_offset;
                float3 tex7_sample = tex2D(_IN7, sample_uv).xyz;
                inner_blur_accum = tex7_sample * blur_outer_loop_angle + inner_blur_accum;
                inner_blur_weight = inner_blur_weight + blur_outer_loop_angle;
            }
            blur_accum = inner_blur_accum;
            blur_total_weight = inner_blur_weight;
            blur_inner_loop_start_counter = 0.620000005f + inner_loop_counter;
        }
        float3 ssao_like_color = blur_accum / blur_total_weight;

        bool3 sdf_check_lower = (float3(0.644999981f, 0.312000006f, 0.978999972f) < SDFMask.xxx);
        bool3 sdf_check_upper = (SDFMask.xxx < float3(0.685000002f, 0.351999998f, 1.02100003f));
        bool3 sdf_in_range = sdf_check_lower && sdf_check_upper;
        
        float sdf_mask_result_temp = sdf_in_range.z ? 1.0f : 0.0f;
        sdf_mask_result_temp = sdf_in_range.y ? 0.0f : sdf_mask_result_temp;
        float sdf_mask_result = sdf_in_range.x ? 1.0f : sdf_mask_result_temp;

        bool ssao_mask_cond = (int)sdf_in_range.y | (int)sdf_in_range.z;
        bool ssao_mask = sdf_in_range.x ? false : ssao_mask_cond;
        
        uint ToonSkinMask_uint = (uint)round(255.0f * toonSkinMaskX);
        int4 toon_mask_parts = (int4)ToonSkinMask_uint & int4(15, 240, 240, 15);
        
        float diffuse_ramp_x = saturate(diffuse + diffuse);
        float diffuse_ramp_term_a = diffuse_ramp_x * -2.0f + 3.0f;
        float diffuse_ramp_sq = diffuse_ramp_x * diffuse_ramp_x;
        float diffuse_ramp_result1 = diffuse_ramp_term_a * diffuse_ramp_sq;

        float diffuse_ramp_x2 = saturate((-0.5f + diffuse) * 2.0f);
        float diffuse_ramp_term_b = diffuse_ramp_x2 * -2.0f + 3.0f;
        float diffuse_ramp_sq2 = diffuse_ramp_x2 * diffuse_ramp_x2;
        float diffuse_ramp_result2 = diffuse_ramp_term_b * diffuse_ramp_sq2;
        
        float3 color_diff = cb1[262].xyz - cb1[261].xyz;
        float color_luminance = dot(abs(color_diff), float3(0.300000012f, 0.589999974f, 0.109999999f));
        float color_ramp_x = min(1.0f, 10.0f * color_luminance);
        float color_ramp_term = color_ramp_x * -2.0f + 3.0f;
        float color_ramp_sq = color_ramp_x * color_ramp_x;
        float color_ramp_result = color_ramp_term * color_ramp_sq;

        float ramp_blend_factor = color_ramp_result * diffuse_ramp_result2;
        
        float shadow_ramp_range = cb1[265].y - cb1[265].x;
        float shadow_ramp_pos_unclamped = otherShadow - cb1[265].x;
        float shadow_ramp_inv_range = 1.0f / shadow_ramp_range;
        float shadow_ramp_x = saturate(shadow_ramp_pos_unclamped * shadow_ramp_inv_range);
        float shadow_ramp_term = shadow_ramp_x * -2.0f + 3.0f;
        float shadow_ramp_sq = shadow_ramp_x * shadow_ramp_x;
        float shadow_ramp_result = shadow_ramp_term * shadow_ramp_sq;

        float ramp_blend_factor_shadowed = shadow_ramp_result * ramp_blend_factor;
        
        float shadow_ramp_pos_adjusted = otherShadow - ramp_blend_factor_shadowed;
        float final_shadow_ramp_pos = cb1[265].z * shadow_ramp_pos_adjusted + ramp_blend_factor_shadowed;

        float final_shadow_ramp_unclamped = final_shadow_ramp_pos - cb1[265].x;
        float final_shadow_ramp_x = saturate(final_shadow_ramp_unclamped * shadow_ramp_inv_range);
        float final_shadow_ramp_term = final_shadow_ramp_x * -2.0f + 3.0f;
        float final_shadow_ramp_sq = final_shadow_ramp_x * final_shadow_ramp_x;
        float final_shadow_ramp_result = final_shadow_ramp_term * final_shadow_ramp_sq;

        float final_ramp_blend_factor = final_shadow_ramp_result * ramp_blend_factor;

        float ramp_lerp_factor = diffuse_ramp_result2 * color_ramp_result - final_ramp_blend_factor;
        float ramp_result_lerped = cb1[265].z * ramp_lerp_factor + final_ramp_blend_factor;

        float final_shadow_ramp_pos_minus_one = final_shadow_ramp_pos - 1.0f;
        float shadow_ramp_mod = cb1[260].y * final_shadow_ramp_pos_minus_one + 1.0f;

        float dither_blend_term1 = otherShadow * ramp_result_lerped - shadow_ramp_mod;
        float final_ramp_dithered = accessory_flag * dither_blend_term1 + shadow_ramp_mod;

        float dither_blend_term2 = otherShadow * ramp_result_lerped - ramp_result_lerped;
        float final_ramp_no_dither = accessory_flag * dither_blend_term2 + ramp_result_lerped;

        bool is_green_max_bool = (ssao_like_color.y >= ssao_like_color.z);
        float hsv_max_rg = is_green_max_bool ? ssao_like_color.y : ssao_like_color.z;
        float hsv_min_rg = is_green_max_bool ? ssao_like_color.z : ssao_like_color.y;
        float hsv_hue_comp_rg = is_green_max_bool ? 0.0f : 0.666666687f;
        float hsv_hue_comp_const = -1.0f; 

        bool is_blue_max_bool = (ssao_like_color.x >= hsv_max_rg);
        float hsv_v = is_blue_max_bool ? ssao_like_color.x : hsv_max_rg;
        float hsv_max_gb = is_blue_max_bool ? hsv_max_rg : ssao_like_color.x;
        float hsv_hue_comp = is_blue_max_bool ? hsv_hue_comp_rg : hsv_hue_comp_rg + hsv_hue_comp_const;
        
        float hsv_min_rgb = min(hsv_max_gb, hsv_min_rg);
        float hsv_delta = hsv_v - hsv_min_rgb;

        float hsv_delta_scaled = hsv_delta * 6.0f + 0.00100000005f;
        float hsv_hue_term = (hsv_max_gb - hsv_min_rg) / hsv_delta_scaled;
        float hsv_h = hsv_hue_comp + hsv_hue_term;

        float hsv_s_denom = 0.00100000005f + hsv_v;
        float hsv_s = hsv_delta / hsv_s_denom;
        
        float4 toon_mask_scaled = (float4)toon_mask_parts * float4(0.0400000028f, 0.0027450982f, 0.00392156886f, 0.0666666701f) + float4(0.400000006f, 0.400000006f, 1.0f, 0.5f);
        bool toon_mask_z_check = toon_mask_parts.z >= 2.54999971f;
        
        float hue_shift_base = toon_mask_scaled.y - toon_mask_scaled.x;
        float hue_shift = (toon_mask_z_check ? 1.0f : 0.0f) * hue_shift_base + toon_mask_scaled.x;
        
        float saturation_mod = hue_shift * hsv_s;
        saturation_mod = min(0.349999994f, saturation_mod);
        saturation_mod = max(0.0f, saturation_mod);
        
        float hsv_hue_abs = abs(hsv_h);
        float3 hsv_hue_frac = frac(float3(1.0f, 0.666666687f, 0.333333343f) + hsv_hue_abs.xxx);
        float3 hsv_term1 = hsv_hue_frac * 6.0f - 3.0f;
        float3 hsv_term2 = saturate(abs(hsv_term1) - 1.0f);
        float3 hsv_term3 = hsv_term2 - 1.0f;
        
        float3 rgb_pre_sat = saturation_mod * hsv_term3 + 1.0f;
        
        float sat_mod_plus_1 = 1.0f + saturation_mod;
        float3 rgb_from_hsv_v = rgb_pre_sat * sat_mod_plus_1;
        float3 rgb_from_hsv_v_minus_1 = rgb_from_hsv_v - 1.0f;
        float3 rgb_lerp_term = rgb_from_hsv_v_minus_1 * 0.600000024f + 1.0f;
        float3 rgb_lerp_base = -rgb_from_hsv_v + rgb_lerp_term;
        float3 rgb_lerped = SDFMask.xxx * rgb_lerp_base + rgb_from_hsv_v;

        float3 rgb_final_blend_base = rgb_lerped - albedo;
        float3 rgb_final_blend = rgb_final_blend_base * 0.850000024f + albedo;

        float3 v_blend_term = toon_mask_scaled.z * rgb_final_blend - rgb_lerped;
        float3 rgb_v_blended = toon_mask_z_check ? v_blend_term : rgb_lerped;

        float3 rgb_final_pre_mult = rgb_v_blended - 1.0f;
        float3 rgb_final = toon_mask_scaled.w * rgb_final_pre_mult + 1.0f;
        
        float3 base_color = cb1[261].xyz * 0.200000003f;
        float3 highlight_color_diff = cb1[262].xyz * 0.5f - base_color;
        float3 highlight_color = final_ramp_dithered * highlight_color_diff + base_color;
        float3 shaded_color = cb1[260].x * highlight_color;
        float3 final_base_color = shaded_color * albedo;
        
        float3 shadow_contrib = final_base_color * shadowColor;
        
        float3 ramp_color1_base = cb1[261].xyz * albedo;
        float ramp_factor = diffuse_ramp_result1 * 0.300000012f + 0.699999988f;
        ramp_color1 = ramp_color1_base * ramp_factor; 
        float3 ramp_color2_base = cb1[262].xyz * albedo;
        
        float3 ramp_color1_shadowed = ramp_color1 + shadow_contrib;
        
        float3 color_blend1_base = ramp_color2_base - ramp_color1;
        float3 color_blend1 = color_blend1_base * 0.400000006f + ramp_color1;

        float3 color_blend_with_rgb_base = color_blend1 * rgb_final;
        float3 color_blend_with_rgb_term = color_blend_with_rgb_base - ramp_color1 * rgb_final;
        float3 final_rgb_blend = final_ramp_no_dither * color_blend_with_rgb_term + (ramp_color1 * rgb_final);

        float3 final_base_shadowed_color = final_base_color * shadowColor + final_rgb_blend;
        
        float3 final_shadowed_color = ramp_color1_shadowed * rgb_final;
        
        float3 highlight_blend_base = ramp_color2_base * final_shadow_ramp_result;
        float3 highlight_blend_term = highlight_blend_base * rgb_final - final_shadowed_color;
        float3 final_highlight_blend = final_ramp_no_dither * highlight_blend_term + final_shadowed_color;

        float ssao = tex2Dlod(_IN8, float4(v0.xy, 0, 0)).x;
        ssao = ssao - 1.0f;
        ssao = (ssao_mask ? 1.0f : 0.0f) * ssao + 1.0f;

        float3 color_lerp_ssao_term = final_highlight_blend - final_base_shadowed_color;
        float3 color_lerp_ssao = final_ramp_dithered * color_lerp_ssao_term + final_base_shadowed_color;

        float3 ssao_inv = 1.0f - ssao_like_color;
        float3 color_with_ssao = ssao * ssao_inv + ssao_like_color;
        
        mainLightingColor = color_lerp_ssao * color_with_ssao;
    } 
    else 
    {
        // Default lighting path
        float diffuse_ramp_x1 = saturate(diffuse + diffuse);
        float diffuse_ramp_term1 = diffuse_ramp_x1 * -2.0f + 3.0f;
        float diffuse_ramp_val1_sq = diffuse_ramp_x1 * diffuse_ramp_x1;
        float diffuse_ramp_val1 = diffuse_ramp_term1 * diffuse_ramp_val1_sq;

        float diffuse_ramp_x2 = saturate((-0.5f + diffuse) * 2.0f);
        float diffuse_ramp_term2 = diffuse_ramp_x2 * -2.0f + 3.0f;
        float diffuse_ramp_val2_sq = diffuse_ramp_x2 * diffuse_ramp_x2;
        float diffuse_ramp_val2 = diffuse_ramp_term2 * diffuse_ramp_val2_sq;

        float3 color_diff = cb1[262].xyz - cb1[261].xyz;
        float color_luminance = dot(abs(color_diff), float3(0.300000012f, 0.589999974f, 0.109999999f));
        float color_ramp_x = min(1.0f, 10.0f * color_luminance);
        float color_ramp_term = color_ramp_x * -2.0f + 3.0f;
        float color_ramp_sq = color_ramp_x * color_ramp_x;
        float color_ramp_result = color_ramp_term * color_ramp_sq;

        float ramp_blend_factor = color_ramp_result * diffuse_ramp_val2;
        
        float shadow_ramp_range = cb1[265].y - cb1[265].x;
        float shadow_ramp_pos_unclamped = otherShadow - cb1[265].x;
        float shadow_ramp_inv_range = 1.0f / shadow_ramp_range;
        float shadow_ramp_x = saturate(shadow_ramp_pos_unclamped * shadow_ramp_inv_range);
        float shadow_ramp_term = shadow_ramp_x * -2.0f + 3.0f;
        float shadow_ramp_sq = shadow_ramp_x * shadow_ramp_x;
        float shadow_ramp_result = shadow_ramp_term * shadow_ramp_sq;
        
        float ramp_blend_factor_shadowed = shadow_ramp_result * ramp_blend_factor;

        float shadow_ramp_pos_adjusted = otherShadow - ramp_blend_factor_shadowed;
        float final_shadow_ramp_pos = cb1[265].z * shadow_ramp_pos_adjusted + ramp_blend_factor_shadowed;

        float final_shadow_ramp_unclamped = final_shadow_ramp_pos - cb1[265].x;
        float final_shadow_ramp_x = saturate(final_shadow_ramp_unclamped * shadow_ramp_inv_range);
        float final_shadow_ramp_term = final_shadow_ramp_x * -2.0f + 3.0f;
        float final_shadow_ramp_sq = final_shadow_ramp_x * final_shadow_ramp_x;
        float final_shadow_ramp_result = final_shadow_ramp_term * final_shadow_ramp_sq;

        float final_ramp_blend_factor = final_shadow_ramp_result * ramp_blend_factor;

        float ramp_lerp_factor = diffuse_ramp_val2 * color_ramp_result - final_ramp_blend_factor;
        float ramp_result_lerped = cb1[265].z * ramp_lerp_factor + final_ramp_blend_factor;

        float hair_ramp_factor = final_shadow_ramp_pos * toonSkinMaskZ_branch_val;
        hair_ramp_factor = 10.0f * hair_ramp_factor;

        float final_shadow_ramp_pos_minus_one = final_shadow_ramp_pos - 1.0f;
        float shadow_ramp_mod = cb1[260].y * final_shadow_ramp_pos_minus_one + 1.0f;
        
        float dither_blend_term1 = otherShadow * ramp_result_lerped - shadow_ramp_mod;
        float final_ramp_dithered = accessory_flag * dither_blend_term1 + shadow_ramp_mod;

        float dither_blend_term2 = otherShadow * ramp_result_lerped - ramp_result_lerped;
        float final_ramp_no_dither = accessory_flag * dither_blend_term2 + ramp_result_lerped;

        float3 base_color = cb1[261].xyz * 0.200000003f;
        float3 highlight_color_diff = cb1[262].xyz * 0.5f - base_color;
        float3 highlight_color = final_ramp_dithered * highlight_color_diff + base_color;
        float3 shaded_color = cb1[260].x * highlight_color;
        float3 final_base_color = shaded_color * albedo;
        
        float3 shadow_contrib = final_base_color * shadowColor;
        
        float3 ramp_color1_base = cb1[261].xyz * albedo;
        float ramp_factor = diffuse_ramp_val1 * 0.300000012f + 0.699999988f;
        ramp_color1 = ramp_color1_base * ramp_factor;
        
        float3 ramp_color1_shadowed = ramp_color1 + shadow_contrib;
        float3 final_shadowed_color_base = hair_ramp_factor.xxx * shadow_contrib + ramp_color1_shadowed;

        float3 ramp_color2_base = albedo * cb1[262].xyz;
        float3 ramp_color_blend_base = ramp_color2_base - ramp_color1;
        float3 ramp_color_blend_term = ramp_color_blend_base * final_ramp_no_dither;
        float3 ramp_color_blend = ramp_color_blend_term * 0.400000006f + ramp_color1;
        
        float3 final_base_shadowed_color = final_base_color * shadowColor + ramp_color_blend;

        float3 final_shadowed_color_term = ramp_color2_base - final_shadowed_color_base;
        float3 final_shadowed_color = final_ramp_no_dither * final_shadowed_color_term + final_shadowed_color_base;

        float3 color_lerp_term = final_shadowed_color - final_base_shadowed_color;
        mainLightingColor = final_ramp_dithered * color_lerp_term + final_base_shadowed_color;
    }
    
    // --- Pre-Rim Light Calculations ---
    float diffuse_rim_x = saturate(10.000001f * (-0.400000006f + diffuse));
    float diffuse_rim_term = diffuse_rim_x * -2.0f + 3.0f;
    float diffuse_rim_x_sq = diffuse_rim_x * diffuse_rim_x;
    float diffuse_rim_factor = diffuse_rim_term * diffuse_rim_x_sq;
    float3 base_lighting_if_path = mainLightingColor * 0.5f + cb1[261].xyz;
    float3 final_base_lighting_if_path = base_lighting_if_path * albedo;
    
    float3 fallback_lighting_if_path = cb1[261].xyz * albedo;

    float3 pre_rim_lighting = cb1[255].x != 0.0f ? final_base_lighting_if_path : fallback_lighting_if_path;
    pre_rim_lighting = isHair_check ? pre_rim_lighting : ramp_color1;
    mainLightingColor = isHair_check ? pre_rim_lighting : mainLightingColor;

    float2 rim_factors = isHair_check ? float2(0.0f, 0.0f) : float2(diffuse_rim_factor, diffuse_rim_factor);

    float3 lightDir = cb1[264].xyz + cb1[264].xyz;
    lightDir = SDFMask.xxx * lightDir - cb1[264].xyz;

    // --- 局部光源循环 (Local Lights Loop) ---
    float3 local_light_accum = float3(0, 0, 0);
    float local_light_mask = 1.0f;
    
    uint num_lights = asuint(cb2[128].x);
    for (uint i = 0; i < num_lights; ++i)
    {
        if (i >= num_lights) break;
        
        uint light_base_idx_part1 = (i << 3) & 0xfffffff8;
        uint light_base_idx = light_base_idx_part1 | 7;
        uint light_prop_mask_part1 = asuint(cb2[light_base_idx].w) << 5;
        uint light_prop_mask = light_prop_mask_part1 & 0xffffffe0;
        
        bool is_light_active = (outputMask & (int)light_prop_mask) != 0;
        if (!is_light_active) 
        {
            continue;
        }

        uint light_idx_base_offset = i << 3;
        float3 light_pos = cb2[light_idx_base_offset + 0].xyz - worldPosition;
        float light_radius_sq = cb2[light_idx_base_offset + 0].w * cb2[light_idx_base_offset + 0].w;
        float dist_to_light_sq = dot(light_pos, light_pos);
        float attenuation_dist_sq = dist_to_light_sq * light_radius_sq;

        if (1.0f >= attenuation_dist_sq)
        {
            uint base_offset_shifted = (i << 3) & 0xfffffff8;
            uint light_param_idx1 = base_offset_shifted | 1;
            uint light_param_idx2 = base_offset_shifted | 2;
            uint light_param_idx3 = base_offset_shifted | 3;
            uint light_param_idx4 = base_offset_shifted | 4;
            uint light_param_idx5 = base_offset_shifted | 5;
            uint light_param_idx6 = base_offset_shifted | 6;

            float attenuation_ramp_x = saturate(attenuation_dist_sq * 2.5f - 1.5f);
            float attenuation_ramp_sq = attenuation_ramp_x * attenuation_ramp_x;
            float attenuation_ramp_term = -attenuation_ramp_x * 2.0f + 3.0f;
            float attenuation_factor = -attenuation_ramp_sq * attenuation_ramp_term + 1.0f;

            float inv_dist_to_light = rsqrt(dist_to_light_sq);
            float3 light_vec_normalized = light_pos * inv_dist_to_light;

            float NdotL = dot(finalWorldNormal, light_vec_normalized);
            float fresnel_term = 1.0f + NdotL;

            float2 light_fresnel_params = cb2[light_param_idx5].ww * float2(0.939999998f, 0.0600000024f);
            float fresnel_ramp_x_unclamped = fresnel_term * 0.5f - light_fresnel_params.x;
            float inv_fresnel_range = 1.0f / light_fresnel_params.y;
            float fresnel_ramp_x = saturate(inv_fresnel_range * fresnel_ramp_x_unclamped);
            float fresnel_ramp_term = fresnel_ramp_x * -2.0f + 3.0f;
            float fresnel_ramp_sq = fresnel_ramp_x * fresnel_ramp_x;
            float fresnel_factor = fresnel_ramp_term * fresnel_ramp_sq;
            fresnel_factor = min(1.0f, fresnel_factor);

            float3 light_color_base = cb2[light_param_idx6].xyz * mainLightingColor;
            float3 light_color_highlight_base = albedo * cb2[light_param_idx5].xyz - light_color_base;
            float3 light_color_final = fresnel_factor * light_color_highlight_base + light_color_base;
            light_color_final = cb2[light_base_idx].xxx * light_color_final;

            float3 light_pos_scaled = light_pos * cb2[light_idx_base_offset].www;
            float spot_attenuation_base = dot(light_pos_scaled, light_pos_scaled);
            spot_attenuation_base = spot_attenuation_base * cb2[light_param_idx4].x + cb2[light_param_idx4].y;
            spot_attenuation_base = 9.99999975e-005f + spot_attenuation_base;
            float inv_spot_attenuation = 1.0f / spot_attenuation_base;
            float spot_attenuation_unclamped = inv_spot_attenuation - 1.0f;
            float spot_attenuation_scaled = cb2[light_param_idx4].z * spot_attenuation_unclamped;
            float spot_attenuation_sq = spot_attenuation_scaled * spot_attenuation_scaled;
            float spot_attenuation_factor = min(1.0f, spot_attenuation_sq);
            
            uint light_type_bits = (asuint(cb2[light_param_idx1].w) >> 16) & 0xF;
            bool is_spotlight_type2 = (light_type_bits == 2);
            
            float spot_cone_dot = dot(light_vec_normalized, cb2[light_param_idx1].xyz);
            float spot_cone_unclamped = spot_cone_dot - cb2[light_param_idx2].x;
            float spot_cone_ramp_x = saturate(cb2[light_param_idx2].y * spot_cone_unclamped);
            float spot_cone_ramp_sq1 = spot_cone_ramp_x * spot_cone_ramp_x;
            float spot_cone_ramp_sq2 = spot_cone_ramp_sq1 * spot_cone_ramp_sq1;
            float spotlight_factor = spot_cone_ramp_sq2 * spot_attenuation_factor;
            
            spot_attenuation_factor = is_spotlight_type2 ? spotlight_factor : spot_attenuation_factor;
            
            float diffuse_dot = dot(lightDir, light_vec_normalized);
            float diffuse_ramp_x = saturate(diffuse_dot * 0.5f + 0.5f);
            float diffuse_lighting_base = rim_factors.y * diffuse_ramp_x - rim_factors.x;
            float diffuse_lighting = cb2[light_param_idx4].w * diffuse_lighting_base + rim_factors.x;

            float3 specular_base = cb2[light_param_idx3].www * mainLightingColor;
            float3 specular_highlight_base = -mainLightingColor * cb2[light_param_idx3].www + albedo;
            float3 specular_color = diffuse_lighting * specular_highlight_base + specular_base;
            specular_color = cb2[light_param_idx3].xyz * specular_color;

            float light_intensity_sum = cb2[light_param_idx3].x + cb2[light_param_idx3].y;
            light_intensity_sum = cb2[light_param_idx3].z + light_intensity_sum;
            light_intensity_sum = cb2[light_base_idx].x + light_intensity_sum;
            float light_intensity_ramp = saturate(10.0f * light_intensity_sum);
            
            float light_mask_factor = cb2[light_base_idx].y * light_intensity_ramp;
            
            float3 attenuated_light_color = light_color_final * spot_attenuation_factor;
            float3 final_light_contrib = specular_color * spot_attenuation_factor + attenuated_light_color;
            
            float attenuation_remaining = attenuation_factor - spot_attenuation_factor;
            spot_attenuation_factor = cb2[light_param_idx6].w * attenuation_remaining + spot_attenuation_factor;
            
            local_light_accum = final_light_contrib * local_light_mask + local_light_accum;
            
            float local_light_mask_update = -spot_attenuation_factor * light_mask_factor + 1.0f;
            local_light_mask = local_light_mask_update * local_light_mask;
        }
    }
    
    float3 finalColor = local_light_mask * mainLightingColor + local_light_accum;
    
    // --- 边缘光计算 (Rim Light Calculation) ---
    bool useRim = (shadeMode != 13);
    float3 finalRimColor;
    float rim_depth_attenuation = 1.0f; 
    float rim_depth_diff;
    if (useRim)
    {
        bool isRimType1 = (finalMaterialID == 1);
        float rim_mask_source = isRimType1 ? toonSkinMaskZ : toonSkinMaskY;

        float3 view_vec = cb1[67].xyz - worldPosition;
        float view_vec_len_sq = dot(view_vec, view_vec);
        float inv_view_vec_len = rsqrt(view_vec_len_sq);
        view_vec = view_vec * inv_view_vec_len;

        // **FIX 1: Add saturate() to match original code's behavior.**
        float rim_intensity_unclamped = saturate(rim_mask_source - 0.100000001f);
        float rim_intensity_ramp_x = saturate(10.0f * rim_mask_source);
        
        float rim_depth_falloff = rim_intensity_unclamped * 2000.0f + 50.0f;
        float rim_intensity_base = rim_intensity_unclamped + rim_intensity_unclamped;

        float rim_intensity = cb0[0].x * rim_intensity_ramp_x;
        rim_intensity = rim_intensity * 0.800000012f + rim_intensity_base;

        float3 rim_light_color_y = cb1[21].xyz * finalWorldNormal.y;
        float3 rim_light_color_x = finalWorldNormal.x * cb1[20].xyz + rim_light_color_y;
        float3 rim_light_color = finalWorldNormal.z * cb1[22].xyz + rim_light_color_x;
        
        bool is_camera_moving = (0.5f < asfloat(asint(cb0[0].w)));
        float3 view_vec_final = is_camera_moving ? float3(0,0,0) : view_vec;
        
        float3 rim_light_dir;
        rim_light_dir.xy = is_camera_moving ? cb0[0].yz : cb1[264].xy;
        rim_light_dir.z = is_camera_moving ? 0.5f : cb1[264].z;

        float3 worldNormal_for_rim = is_camera_moving ? rim_light_color : finalWorldNormal;

        float NdotL_rim = dot(rim_light_dir, worldNormal_for_rim);
        float2 rim_fresnel_base = float2(0.200000003f, 1.0f) + NdotL_rim;
        
        float rim_fresnel_ramp_x = saturate(5.0f * rim_fresnel_base.x);
        float rim_fresnel_term = rim_fresnel_ramp_x * -2.0f + 3.0f;
        float rim_fresnel_ramp_sq = rim_fresnel_ramp_x * rim_fresnel_ramp_x;
        float rim_fresnel_factor = rim_fresnel_term * rim_fresnel_ramp_sq;

        float3 halfway_vec = rim_light_dir + view_vec_final;
        float halfway_len_sq = dot(halfway_vec, halfway_vec);
        float inv_halfway_len = rsqrt(halfway_len_sq);
        halfway_vec = halfway_vec * inv_halfway_len;

        float NdotH_rim = saturate(dot(worldNormal_for_rim, halfway_vec));
        float NdotH_rim_sq = NdotH_rim * NdotH_rim;
        float specular_falloff = NdotH_rim_sq * -0.800000012f + 1.0f;
        float specular_falloff_sq = specular_falloff * specular_falloff;
        float specular_power = 3.14159274f * specular_falloff_sq;
        float rim_specular = 0.200000003f / specular_power;
        rim_specular = rim_specular * otherShadow;

        float VdotL = dot(rim_light_dir, view_vec_final);
        float2 VdotL_mod = float2(-0.5f, 1.0f) - VdotL;
        float fresnel_ramp_x_2 = saturate(VdotL_mod.x + VdotL_mod.x);
        float fresnel_term_2 = fresnel_ramp_x_2 * -2.0f + 3.0f;
        float fresnel_ramp_sq_2 = fresnel_ramp_x_2 * fresnel_ramp_x_2;
        float fresnel_factor_2 = fresnel_term_2 * fresnel_ramp_sq_2 + 1.0f;

        float NdotV = saturate(dot(view_vec_final, worldNormal_for_rim));
        float NdotV_mod = 0.800000012f - NdotV;
        float rim_fade = max(0.0f, NdotV_mod);
        
        float rim_angle_param = min(1.74532926f, max(0.0f, cb1[133].x));
        float2 rim_params = float2(1.5f, 0.572957814f) * float2(rim_fade, rim_angle_param);
        
        float rim_depth_param = max(0.0f, linearEyeDepth);
        float2 rim_depth_clamped = min(float2(3000.0f, 50.0f), rim_depth_param.xx);
        float2 rim_depth_inv = float2(3000.0f, 50.0f) - rim_depth_clamped;
        float2 rim_depth_scaled = float2(0.00033333333f, 0.0199999996f) * rim_depth_inv;
        
        float rim_depth_ramp_sq1 = rim_depth_scaled.x * rim_depth_scaled.x;
        float rim_depth_ramp_sq2 = rim_depth_ramp_sq1 * rim_depth_ramp_sq1;
        float rim_depth_ramp = rim_depth_ramp_sq2 * rim_depth_ramp_sq2 + rim_depth_scaled.y;
        float rim_depth_final = rim_depth_ramp - 1.0f;

        float rim_angle_final = rim_params.y * rim_depth_final + 1.0f;
        float rim_angle_inv = 1.0f - rim_angle_final;
        rim_angle_final = rim_intensity_unclamped * rim_angle_inv + rim_angle_final;
        
        float rim_factor_base = rim_fresnel_base.y * 0.25f + 0.5f;
        rim_fade = rim_factor_base * rim_params.x;
        rim_fade = rim_fade * rim_angle_final;
        rim_fade = rim_fade * fresnel_factor_2;
        rim_fade = 0.00999999978f * rim_fade;
        
        float2 light_vec_normalized_xy = float2(9.99999975e-005f, 9.99999975e-005f) + final_base_lighting_if_path.xy;
        float light_vec_len_sq = dot(light_vec_normalized_xy, light_vec_normalized_xy);
        float inv_light_vec_len = rsqrt(light_vec_len_sq);
        light_vec_normalized_xy = light_vec_normalized_xy * inv_light_vec_len;
        
        light_vec_normalized_xy = light_vec_normalized_xy * rim_intensity.xx;
        float rim_color_term1 = light_vec_normalized_xy.y * rim_fade;
        
        float rim_color_term2_base = light_vec_normalized_xy.x * rim_fade;
        float2 rim_color_terms = rim_color_term2_base * float2(1.0f, -0.5f);
        
        float rim_specular_final = 0.400000006f * VdotL_mod.y;
        float rim_blend_factor = rim_fresnel_factor * 0.800000012f + 0.200000003f;
        
        float rim_specular_lerp_base = rim_specular * rim_fresnel_factor;
        rim_specular_lerp_base = 1.5f * rim_specular_lerp_base;
        rim_specular_final = rim_specular_final * rim_blend_factor + rim_specular_lerp_base;
        
        float rim_blend_factor2 = otherShadow * 0.5f + 0.5f;
        rim_specular_final = rim_blend_factor2 * rim_specular_final;

        float2 rim_uv_offset = v0.xy * cb1[138].xy - cb1[134].xy;
        float2 rim_uv_base = rim_uv_offset * cb1[135].zw + rim_color_terms;
        float2 rim_uv_final = rim_uv_base * cb1[135].xy + cb1[134].xy;
        rim_uv_final = cb1[138].zw * rim_uv_final;

        float rim_scene_depth = tex2D(_IN6, rim_uv_final).x;
        float rim_scene_depth_num = rim_scene_depth * cb1[65].x + cb1[65].y;
        float rim_scene_depth_den = rim_scene_depth * cb1[65].z - cb1[65].w;
        
        float inv_rim_scene_depth_den = 1.0f / rim_scene_depth_den;
        float rim_scene_linear_depth = rim_scene_depth_num + inv_rim_scene_depth_den;
        rim_depth_diff = rim_scene_linear_depth - linearEyeDepth; // 边缘光计算处
        rim_depth_diff = max(9.99999975e-005f, rim_depth_diff);

        float rim_depth_factor = -rim_intensity_unclamped * 1000.0f + rim_depth_diff;
        float inv_rim_depth_falloff = 1.0f / rim_depth_falloff;
        
        float rim_depth_ramp_x = saturate(inv_rim_depth_falloff * rim_depth_factor);
        float rim_depth_term = rim_depth_ramp_x * -2.0f + 3.0f;
        float rim_depth_ramp_sq = rim_depth_ramp_x * rim_depth_ramp_x;
        float rim_depth_ramp_result = rim_depth_term * rim_depth_ramp_sq;
        rim_depth_attenuation = min(1.0f, rim_depth_ramp_result);

        float rim_color_luminance = dot(cb1[263].xyz, float3(0.300000012f, 0.589999974f, 0.109999999f));
        float3 rim_color_desaturated_base = cb1[263].xyz - rim_color_luminance;
        float3 rim_color_desaturated = rim_color_desaturated_base * 0.75f + rim_color_luminance;
        
        float3 rim_color_lerp_base = cb1[263].xyz - rim_color_desaturated;
        float3 rim_color_lerped = otherShadow * rim_color_lerp_base + rim_color_desaturated;
        
        rim_color_lerped = rim_color_lerped * rim_specular_final;
        rim_color_lerped = rim_color_lerped * 0.100000001f;

        
        float3 albedo_plus_one = 1.0f + albedo;
        float3 rim_color_with_albedo = albedo_plus_one * rim_color_lerped;
        
        float3 albedo_brighten = albedo * 1.20000005f - 1.0f;
        float3 albedo_brighten_ramp_x = saturate(-albedo_brighten);
        float3 albedo_brighten_term = albedo_brighten_ramp_x * -2.0f + 3.0f;
        float3 albedo_brighten_ramp_sq = albedo_brighten_ramp_x * albedo_brighten_ramp_x;
        float3 albedo_brighten_factor = albedo_brighten_term * albedo_brighten_ramp_sq;
        albedo_brighten_factor = albedo_brighten_factor * 14.0f + 1.0f;
        
        float3 rim_color_albedo_mod = albedo_brighten_factor * rim_color_lerped;
        float3 rim_color_lerp2_base = rim_color_albedo_mod * albedo - rim_color_with_albedo;
        float3 rim_color_final_lerped = cb1[260].z * rim_color_lerp2_base + rim_color_with_albedo;
        
        float3 rim_color_with_depth = rim_color_final_lerped * rim_depth_attenuation; // Use the correct attenuation
        
        float rim_fog_dist = -10000.0f + linearEyeDepth;
        rim_fog_dist = max(0.0f, rim_fog_dist);
        rim_fog_dist = min(5000.0f, rim_fog_dist);
        rim_fog_dist = 5000.0f - rim_fog_dist;
        float rim_fog_factor = 0.000199999995f * rim_fog_dist;
        
        float3 rim_color_with_fog = rim_fog_factor * rim_color_with_depth;
        finalRimColor = cb0[1].xyz * rim_color_with_fog;
    }
    else
    {
        finalRimColor = float3(0, 0, 0);
    }
return linearEyeDepth;
    // --- 最终颜色合成 (Final Color Composition) ---
    bool isOutfit_check = (outfit_flag != 0.0f);

    float3 shadow_color_contrib_base = finalColor * shadowColor;
    float3 shadow_color_contrib = cb1[263].xyz * shadow_color_contrib_base;
    float3 final_color_blend_base = shadow_color_contrib * 0.5f - finalColor;
    
    // **FIX 3: Use the correct rim_depth_attenuation factor, not rim_factors.y**
    float3 final_color_with_shadow = rim_depth_attenuation * final_color_blend_base + finalColor;
    
    float3 final_color_with_rim = finalColor + finalRimColor;
    
    float3 final_color_with_shadow_or_rim = isOutfit_check ? final_color_with_shadow : final_color_with_rim;
    float3 final_pixel_color = isHair_check ? finalColor : final_color_with_shadow_or_rim;

    // --- 曝光与输出 (Exposure & Output) ---
    float3 color_div_exposure = final_pixel_color / EyeAdaptation;
    float3 color_clamped = min(float3(0, 0, 0), -color_div_exposure);
    color.xyz = -color_clamped;
    
    return color;
}
            ENDHLSL
        }
    }
}