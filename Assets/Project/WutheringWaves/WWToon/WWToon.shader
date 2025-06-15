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
            // 已知 _IN9 1x1像素 EyeAdaptation自动曝光
          
float4 frag (Varyings fragmentInput) : SV_Target
{
    // 基于输入uv定义screenUV_ndcUV，zw分量是NDC x（clip.x / clip.w）并复制到 zw
    float4 screenUV_ndcUV = fragmentInput.uv; 

    float4 color = 0;
    
    float4 packedNormalWS_perObjectData = 0, msr_shadingModelID = 0, albedo_alpha = 0, customData = 0, model_low4_high4 = 0, model13_14_15 = 0;
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
    float eyeAdaptation;
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
        shadingModelID = dot(float2(1,1), abs(octNormalWS.xy));
        normal.z = 1 + -shadingModelID;
        shadingModelID = max(0, -normal.z);
        float2 oct_normal_sign_check = (octNormalWS.xy >= float2(0,0)) ? 1.0 : 0.0;
        oct_normal_sign_check.xy = oct_normal_sign_check.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
        oct_normal_sign_check.xy = oct_normal_sign_check.xy * shadingModelID;
        normal.xy = oct_normal_sign_check.xy * float2(-2,-2) + octNormalWS.xy;
        shadingModelID = dot(normal.xyz, normal.xyz);
        shadingModelID = rsqrt(shadingModelID);
        normal.xyz = normal.xyz * shadingModelID;
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
    eyeAdaptation = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
    clipPos = screenUV_ndcUV.zw * depth;
    
    posWS.xyz = cb1[49].xyz * clipPos.y;
    posWS.xyz = clipPos.x * cb1[48].xyz + posWS.xyz;
    posWS.xyz = depth * cb1[50].xyz + posWS.xyz;
    posWS.xyz = cb1[51].xyz + posWS.xyz;
    shadow_shadowIntentity = tex2Dlod(_IN5, float4(screenUV_ndcUV.xy, 0, 0)).xz;
    shadow_shadowIntentity = shadow_shadowIntentity * shadow_shadowIntentity;
    shadow = shadow_shadowIntentity.x * shadow_shadowIntentity.y;    
    shadow = cb1[253].y * shadow;
    float3 avg_bloom_color;
    float3 fresnel_base;
    if (cb1[255].x != 0) {
        float3 bloom_accumulator_xyz = float3(0,0,0);
        model_low4_high4.zw = float2(0,0);
        model13_14_15.w = 0;
        float total_bloom_weight = 0;
        while (true) {
        float is_outer_loop_done = ((int)model_low4_high4.z >= 3) ? 1.0 : 0.0;
        if (is_outer_loop_done != 0) break;
        model_low4_high4.w = 0.000833333295 + model_low4_high4.w;
        float3 prev_bloom_accumulator = bloom_accumulator_xyz;
        float inner_loop_counter_w = model13_14_15.w;
        float prev_total_bloom_weight = total_bloom_weight;
        float inner_loop_iterator = 0;
        while (true) {
            float is_inner_loop_done = ((int)inner_loop_iterator >= 3) ? 1.0 : 0.0;
            if (is_inner_loop_done != 0) break;
            inner_loop_counter_w = 1 + inner_loop_counter_w;
            float angle_rad = 2.09439516 * inner_loop_counter_w;
            float sin_angle;
            float cos_angle;
            sincos(angle_rad, sin_angle, cos_angle);
            float sample_uv_x = cos_angle * model_low4_high4.w + screenUV_ndcUV.x;
            float sample_uv_y = sin_angle * model_low4_high4.w + screenUV_ndcUV.y;
            float3 sample_color_in7 = tex2D(_IN7, float2(sample_uv_x, sample_uv_y)).xyz;
            prev_bloom_accumulator.xyz = sample_color_in7.xyz * model_low4_high4.www + prev_bloom_accumulator.xyz;
            prev_total_bloom_weight = prev_total_bloom_weight + model_low4_high4.w;
            inner_loop_iterator = (int)inner_loop_iterator + 1;
        }
        bloom_accumulator_xyz = prev_bloom_accumulator;
        total_bloom_weight = prev_total_bloom_weight;
        model13_14_15.w = 0.620000005 + inner_loop_counter_w;
        model_low4_high4.z = (int)model_low4_high4.z + 1;
        }
        avg_bloom_color = bloom_accumulator_xyz / total_bloom_weight.xxx;
        float3 is_perObject_in_range_A = (float3(0.644999981,0.312000006,0.978999972) < perObjectData) ? 1.0 : 0.0;
        float3 is_perObject_in_range_B = (perObjectData < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
        float3 perObject_range_check = is_perObject_in_range_A.xyz ? is_perObject_in_range_B.xyz : 0;
        perObjectData = perObject_range_check.z ? 1.000000 : 0;
        perObjectData = perObject_range_check.y ? 0 : perObjectData;
        perObjectData = perObject_range_check.x ? 1 : perObjectData;
        model_low4_high4.z = (int)perObject_range_check.y | (int)perObject_range_check.z;
        model_low4_high4.z = (int)model_low4_high4.z & 0x3f800000;
        model_low4_high4.z = perObject_range_check.x ? 0 : model_low4_high4.z;
        customData.x = 255 * customData.x;
        customData.x = round(customData.x);
        customData.x = (uint)customData.x;
        uint4 masked_custom_data = (uint4)((int4)customData.xxxx & int4(15,240,240,15));
        customData.x = saturate(packedNormalWS_perObjectData.w + packedNormalWS_perObjectData.w);
        model_low4_high4.w = customData.x * -2 + 3;
        customData.x = customData.x * customData.x;
        customData.x = model_low4_high4.w * customData.x;
        model_low4_high4.w = -0.5 + packedNormalWS_perObjectData.w;
        model_low4_high4.w = saturate(model_low4_high4.w + model_low4_high4.w);
        model13_14_15.w = model_low4_high4.w * -2 + 3;
        model_low4_high4.w = model_low4_high4.w * model_low4_high4.w;
        model_low4_high4.w = model13_14_15.w * model_low4_high4.w;
        float3 scene_color_diff = cb1[262].xyz + -cb1[261].xyz;
        model13_14_15.w = dot(abs(scene_color_diff.xyz), float3(0.300000012,0.589999974,0.109999999));
        model13_14_15.w = 10 * model13_14_15.w;
        model13_14_15.w = min(1, model13_14_15.w);
        float smoothstep_factor1 = model13_14_15.w * -2 + 3;
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = smoothstep_factor1 * model13_14_15.w;
        float combined_smoothstep_1 = model13_14_15.w * model_low4_high4.w;
        float shadow_range = cb1[265].y + -cb1[265].x;
        float shadow_remap = shadow * cb1[253].y + -cb1[265].x;
        shadow_range = 1 / shadow_range;
        shadow_remap = saturate(shadow_remap * shadow_range);
        float smoothstep_factor2 = shadow_remap * -2 + 3;
        shadow_remap = shadow_remap * shadow_remap;
        shadow_remap = smoothstep_factor2 * shadow_remap;
        shadow_remap = shadow_remap * combined_smoothstep_1;
        float shadow_blend_factor = shadow * cb1[253].y + -shadow_remap;
        shadow_remap = cb1[265].z * shadow_blend_factor + shadow_remap;
        float shadow_remap2 = -cb1[265].x + shadow_remap;
        shadow_range = saturate(shadow_remap2 * shadow_range);
        float smoothstep_factor3 = shadow_range * -2 + 3;
        shadow_range = shadow_range * shadow_range;
        shadow_range = smoothstep_factor3 * shadow_range;
        combined_smoothstep_1 = shadow_range * combined_smoothstep_1;
        model_low4_high4.w = model_low4_high4.w * model13_14_15.w + -combined_smoothstep_1;
        model_low4_high4.w = cb1[265].z * model_low4_high4.w + combined_smoothstep_1;
        model13_14_15.w = -1 + shadow_remap;
        model13_14_15.w = cb1[260].y * model13_14_15.w + 1;
        float temp_blend_val1 = shadow * model_low4_high4.w + -model13_14_15.w;
        model13_14_15.w = model13_14_15.x * temp_blend_val1 + model13_14_15.w;
        float temp_blend_val2 = shadow * model_low4_high4.w + -model_low4_high4.w;
        float shadow_final_blend = model13_14_15.x * temp_blend_val2 + model_low4_high4.w;
        model_low4_high4.w = (avg_bloom_color.y >= avg_bloom_color.z) ? 1.0 : 0.0;
        model_low4_high4.w = model_low4_high4.w ? 1.000000 : 0;
        float4 hsv_temp1 = float4(avg_bloom_color.zy, -1, 0.666666687);
        float4 hsv_temp2 = float4(-hsv_temp1.xy + avg_bloom_color.yz, 1, -1);
        hsv_temp1.xyzw = model_low4_high4.wwww * hsv_temp2.xyzw + hsv_temp1.xyzw;
        model_low4_high4.w = (avg_bloom_color.x >= hsv_temp1.x) ? 1.0 : 0.0;
        model_low4_high4.w = model_low4_high4.w ? 1.000000 : 0;
        float4 hsv_temp3 = float4(hsv_temp1.xyw, avg_bloom_color.x);
        float4 hsv_temp4 = hsv_temp3.wyxz;
        hsv_temp4.xyzw = hsv_temp4.xyzw + -hsv_temp3.xyzw;
        hsv_temp3.xyzw = model_low4_high4.wwww * hsv_temp4.xyzw + hsv_temp3.xyzw;
        model_low4_high4.w = min(hsv_temp3.w, hsv_temp3.y);
        model_low4_high4.w = hsv_temp3.x + -model_low4_high4.w;
        float hsv_S_denom = hsv_temp3.w + -hsv_temp3.y;
        float hsv_H = hsv_S_denom * (1.0f / (model_low4_high4.w * 6 + 0.00100000005));
        hsv_H = hsv_temp3.z + hsv_H;
        float hsv_S = model_low4_high4.w / (0.00100000005 + hsv_temp3.x);
        float bloom_factor = hsv_temp3.x * 0.300000012 + 1;
        float4 hair_params = masked_custom_data.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
        float is_hair_param_z_high = (masked_custom_data.z >= 2.54999971) ? 1.0 : 0.0;
        is_hair_param_z_high = is_hair_param_z_high ? 1.000000 : 0;
        float hair_param_blend = hair_params.y + -hair_params.x;
        hair_param_blend = is_hair_param_z_high * hair_param_blend + hair_params.x;
        hsv_S = hair_param_blend * hsv_S;
        hsv_S = min(0.349999994, hsv_S);
        float hsv_S_clamped = max(0, hsv_S);
        float3 hue_remap_vec = float3(1,0.666666687,0.333333343) + abs(hsv_H.xxx);
        hue_remap_vec.xyz = frac(hue_remap_vec.xyz);
        hue_remap_vec.xyz = hue_remap_vec.xyz * float3(6,6,6) + float3(-3,-3,-3);
        hue_remap_vec.xyz = saturate(float3(-1,-1,-1) + abs(hue_remap_vec.xyz));
        hue_remap_vec.xyz = float3(-1,-1,-1) + hue_remap_vec.xyz;
        float3 hsv_to_rgb_base = hsv_S_clamped.xxx * hue_remap_vec.xyz + float3(1,1,1);
        hsv_S = 1 + hsv_S;
        float3 rgb_from_hsv_A = hsv_to_rgb_base.xyz * hsv_S.xxx;
        float3 rgb_from_hsv_B = hsv_to_rgb_base.xyz * hsv_S.xxx + float3(-1,-1,-1);
        rgb_from_hsv_B.xyz = rgb_from_hsv_B.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
        float3 rgb_from_hsv = -hsv_to_rgb_base.xyz * hsv_S.xxx + rgb_from_hsv_B.xyz;
        rgb_from_hsv.xyz = perObjectData * rgb_from_hsv.xyz + rgb_from_hsv_A.xyz;
        float3 final_bloom_color_temp = rgb_from_hsv.xyz + -albedo_alpha.xyz;
        final_bloom_color_temp.xyz = final_bloom_color_temp.xyz * float3(0.850000024,0.850000024,0.850000024) + albedo_alpha.xyz;
        float3 bloom_blend_interm = hair_params.zzz * final_bloom_color_temp.xyz + -rgb_from_hsv.xyz;
        rgb_from_hsv.xyz = is_hair_param_z_high.xxx * bloom_blend_interm.xyz + rgb_from_hsv.xyz;
        rgb_from_hsv.xyz = float3(-1,-1,-1) + rgb_from_hsv.xyz;
        rgb_from_hsv.xyz = hair_params.www * rgb_from_hsv.xyz + float3(1,1,1);
        float3 scene_color_low = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        float3 scene_color_range = cb1[262].xyz * float3(0.5,0.5,0.5) + -scene_color_low.xyz;
        float3 scene_color_final = model13_14_15.www * scene_color_range.xyz + scene_color_low.xyz;
        scene_color_final.xyz = cb1[260].xxx * scene_color_final.xyz;
        scene_color_final.xyz = scene_color_final.xyz * albedo_alpha.xyz;
        float3 specular_term = scene_color_final.xyz * msrSq;
        float3 diffuse_term_base = cb1[261].xyz * albedo_alpha.xyz;
        perObjectData = customData.x * 0.300000012 + 0.699999988;
        fresnel_base = diffuse_term_base.xyz * perObjectData;
        float3 diffuse_term_high = cb1[262].xyz * albedo_alpha.xyz;
        specular_term.xyz = diffuse_term_base.xyz * perObjectData + specular_term.xyz;
        float3 diffuse_blend_factor = albedo_alpha.xyz * cb1[262].xyz + -fresnel_base.xyz;
        diffuse_blend_factor.xyz = diffuse_blend_factor.xyz * float3(0.400000006,0.400000006,0.400000006) + fresnel_base.xyz;
        float3 fresnel_lit = fresnel_base.xyz * rgb_from_hsv.xyz;
        diffuse_blend_factor.xyz = diffuse_blend_factor.xyz * rgb_from_hsv.xyz + -fresnel_lit.xyz;
        diffuse_blend_factor.xyz = shadow_final_blend.xxx * diffuse_blend_factor.xyz + fresnel_lit.xyz;
        scene_color_final.xyz = scene_color_final.xyz * msrSq + diffuse_blend_factor.xyz;
        specular_term.xyz = specular_term.xyz * rgb_from_hsv.xyz;
        float3 diffuse_term_high_scaled = specular_term.xyz * shadow_range.xxx;
        rgb_from_hsv.xyz = diffuse_term_high_scaled.xyz * rgb_from_hsv.xyz + -specular_term.xyz;
        rgb_from_hsv.xyz = shadow_final_blend.xxx * rgb_from_hsv.xyz + specular_term.xyz;
        perObjectData = tex2Dlod(_IN8, float4(screenUV_ndcUV.xy, 0, 0)).x;
        perObjectData = -1 + perObjectData;
        perObjectData = model_low4_high4.z * perObjectData + 1;
        rgb_from_hsv.xyz = rgb_from_hsv.xyz + -scene_color_final.xyz;
        rgb_from_hsv.xyz = model13_14_15.www * rgb_from_hsv.xyz + scene_color_final.xyz;
        float3 bloom_mask = float3(1,1,1) + -avg_bloom_color.xyz;
        avg_bloom_color.xyz = perObjectData * bloom_mask.xyz + avg_bloom_color.xyz;
        avg_bloom_color.xyz = rgb_from_hsv.xyz * avg_bloom_color.xyz;
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
        float3 scene_color_diff = cb1[262].xyz + -cb1[261].xyz;
        model_low4_high4.z = dot(abs(scene_color_diff.xyz), float3(0.300000012,0.589999974,0.109999999));
        model_low4_high4.z = 10 * model_low4_high4.z;
        model_low4_high4.z = min(1, model_low4_high4.z);
        model_low4_high4.w = model_low4_high4.z * -2 + 3;
        model_low4_high4.z = model_low4_high4.z * model_low4_high4.z;
        model_low4_high4.z = model_low4_high4.w * model_low4_high4.z;
        model_low4_high4.w = model_low4_high4.z * customData.x;
        model13_14_15.w = cb1[265].y + -cb1[265].x;
        float shadow_remap_a = shadow * cb1[253].y + -cb1[265].x;
        model13_14_15.w = 1 / model13_14_15.w;
        shadow_remap_a = saturate(shadow_remap_a * model13_14_15.w);
        float smoothstep_factor_a = shadow_remap_a * -2 + 3;
        shadow_remap_a = shadow_remap_a * shadow_remap_a;
        shadow_remap_a = smoothstep_factor_a * shadow_remap_a;
        shadow_remap_a = shadow_remap_a * model_low4_high4.w;
        shadingModelID = shadow * cb1[253].y + -shadow_remap_a;
        shadingModelID = cb1[265].z * shadingModelID + shadow_remap_a;
        shadow_remap_a = -cb1[265].x + shadingModelID;
        model13_14_15.w = saturate(shadow_remap_a * model13_14_15.w);
        float smoothstep_factor_b = model13_14_15.w * -2 + 3;
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = smoothstep_factor_b * model13_14_15.w;
        model_low4_high4.w = model13_14_15.w * model_low4_high4.w;
        customData.x = customData.x * model_low4_high4.z + -model_low4_high4.w;
        customData.x = cb1[265].z * customData.x + model_low4_high4.w;
        model_low4_high4.z = shadingModelID * isCharaAnisotropicMetal14;
        model_low4_high4.z = 10 * model_low4_high4.z;
        shadingModelID = -1 + shadingModelID;
        shadingModelID = cb1[260].y * shadingModelID + 1;
        model_low4_high4.w = shadow * customData.x + -shadingModelID;
        shadingModelID = model13_14_15.x * model_low4_high4.w + shadingModelID;
        model_low4_high4.w = shadow * customData.x + -customData.x;
        float final_shadow_blend = model13_14_15.x * model_low4_high4.w + customData.x;
        model13_14_15.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        float3 scene_color_range = cb1[262].xyz * float3(0.5,0.5,0.5) + -model13_14_15.xyw;
        model13_14_15.xyw = shadingModelID * scene_color_range.xyz + model13_14_15.xyw;
        model13_14_15.xyw = cb1[260].xxx * model13_14_15.xyw;
        model13_14_15.xyw = model13_14_15.xyw * albedo_alpha.xyz;
        float3 specular_base = model13_14_15.xyw * msrSq;
        float3 diffuse_base = cb1[261].xyz * albedo_alpha.xyz;
        perObjectData = perObjectData * 0.300000012 + 0.699999988;
        fresnel_base = diffuse_base.xyz * perObjectData;
        diffuse_base.xyz = diffuse_base.xyz * perObjectData + specular_base.xyz;
        specular_base.xyz = specular_base.xyz * model_low4_high4.zzz + diffuse_base.xyz;
        float3 diffuse_blend_factor = albedo_alpha.xyz * cb1[262].xyz + -fresnel_base.xyz;
        diffuse_blend_factor.xyz = diffuse_blend_factor.xyz * final_shadow_blend.xxx;
        diffuse_blend_factor.xyz = diffuse_blend_factor.xyz * float3(0.400000006,0.400000006,0.400000006) + fresnel_base.xyz;
        model13_14_15.xyw = model13_14_15.xyw * msrSq + diffuse_blend_factor.xyz;
        float3 diffuse_range = albedo_alpha.xyz * cb1[262].xyz + -specular_base.xyz;
        specular_base.xyz = final_shadow_blend.xxx * diffuse_range.xyz + specular_base.xyz;
        specular_base.xyz = specular_base.xyz + -model13_14_15.xyw;
        avg_bloom_color.xyz = shadingModelID * specular_base.xyz + model13_14_15.xyw;
    }
    perObjectData = -0.400000006 + packedNormalWS_perObjectData.w;
    perObjectData = saturate(10.000001 * perObjectData);
    packedNormalWS_perObjectData.w = perObjectData * -2 + 3;
    perObjectData = perObjectData * perObjectData;
    float rim_factor = packedNormalWS_perObjectData.w * perObjectData;
    model13_14_15.xyw = avg_bloom_color.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
    model13_14_15.xyw = model13_14_15.xyw * albedo_alpha.xyz;
    float3 final_diffuse_base = cb1[261].xyz * albedo_alpha.xyz;
    model13_14_15.xyw = cb1[255].xxx ? model13_14_15.xyw : final_diffuse_base.xyz;
    float3 lighting_result_1 = isModel_5_13.y ? model13_14_15.xyw : fresnel_base.xyz;
    model13_14_15.xyw = isModel_5_13.y ? model13_14_15.xyw : avg_bloom_color.xyz;
    packedNormalWS_perObjectData.xw = isModel_5_13.y ? float2(0,0) : float2(rim_factor, rim_factor);
    float3 light_probe_dir = cb1[264].xyz + cb1[264].xyz;
    light_probe_dir.xyz = perObjectData * light_probe_dir.xyz + -cb1[264].xyz;
    float3 light_accumulator = float3(0,0,0);
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
        float3 light_vec = cb2[model_low4_high4.w+0].xyz + -posWS.xyz;
        float light_radius_sq = cb2[model_low4_high4.w+0].w * cb2[model_low4_high4.w+0].w;
        float dist_to_light_sq = dot(light_vec.xyz, light_vec.xyz);
        light_radius_sq = dist_to_light_sq * light_radius_sq;
        float is_in_light_range = (1 >= light_radius_sq) ? 1.0 : 0.0;
        if (is_in_light_range != 0) {
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  float light_cb_idx1 = (((uint)customData.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  float light_cb_idx2 = (((uint)customData.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.y);
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  float light_cb_idx3 = (((uint)customData.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
        bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  float light_cb_idx4 = (((uint)customData.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  float light_cb_idx5 = (((uint)customData.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  float light_cb_idx6 = (((uint)customData.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.y);
        light_radius_sq = saturate(light_radius_sq * 2.5 + -1.5);
        float falloff_sq = light_radius_sq * light_radius_sq;
        light_radius_sq = -light_radius_sq * 2 + 3;
        light_radius_sq = -falloff_sq * light_radius_sq + 1;
        float inv_dist_to_light = rsqrt(dist_to_light_sq);
        float3 light_dir_norm = light_vec.xyz * inv_dist_to_light.xxx;
        float NdotL = dot(normal.xyz, light_dir_norm.xyz);
        NdotL = 1 + NdotL;
        float2 light_cone_params = cb2[light_cb_idx5+0].ww * float2(0.939999998,0.0600000024);
        NdotL = NdotL * 0.5 + -light_cone_params.x;
        float inv_cone_range = 1 / light_cone_params.y;
        NdotL = saturate(inv_cone_range * NdotL);
        float cone_smoothstep_factor = NdotL * -2 + 3;
        NdotL = NdotL * NdotL;
        NdotL = cone_smoothstep_factor * NdotL;
        NdotL = min(1, NdotL);
        float3 light_color_term1 = cb2[light_cb_idx6+0].xyz * lighting_result_1.xyz;
        float3 light_color_term2 = albedo_alpha.xyz * cb2[light_cb_idx5+0].xyz + -light_color_term1.xyz;
        light_color_term2.xyz = NdotL.xxx * light_color_term2.xyz + light_color_term1.xyz;
        light_color_term2.xyz = cb2[model_low4_high4.z+0].xxx * light_color_term2.xyz;
        light_vec.xyz = cb2[model_low4_high4.w+0].www * light_vec.xyz;
        model_low4_high4.w = dot(light_vec.xyz, light_vec.xyz);
        model_low4_high4.w = model_low4_high4.w * cb2[light_cb_idx4+0].x + cb2[light_cb_idx4+0].y;
        model_low4_high4.w = 9.99999975e-005 + model_low4_high4.w;
        model_low4_high4.w = 1 / model_low4_high4.w;
        model_low4_high4.w = -1 + model_low4_high4.w;
        model_low4_high4.w = cb2[light_cb_idx4+0].z * model_low4_high4.w;
        model_low4_high4.w = model_low4_high4.w * model_low4_high4.w;
        model_low4_high4.w = min(1, model_low4_high4.w);
        if (4 == 0) NdotL = 0; else if (4+16 < 32) {       NdotL = (uint)cb2[light_cb_idx1+0].w << (32-(4 + 16)); NdotL = (uint)NdotL >> (32-4);      } else NdotL = (uint)cb2[light_cb_idx1+0].w >> 16;
        NdotL = ((int)NdotL == 2) ? 1.0 : 0.0;
        float light_falloff_a = dot(light_dir_norm.xyz, cb2[light_cb_idx1+0].xyz);
        light_falloff_a = -cb2[light_cb_idx2+0].x + light_falloff_a;
        light_falloff_a = saturate(cb2[light_cb_idx2+0].y * light_falloff_a);
        light_falloff_a = light_falloff_a * light_falloff_a;
        light_falloff_a = light_falloff_a * light_falloff_a;
        light_falloff_a = light_falloff_a * model_low4_high4.w;
        model_low4_high4.w = NdotL ? light_falloff_a : model_low4_high4.w;
        NdotL = dot(light_probe_dir.xyz, light_dir_norm.xyz);
        NdotL = saturate(NdotL * 0.5 + 0.5);
        NdotL = packedNormalWS_perObjectData.w * NdotL + -perObjectData;
        NdotL = cb2[light_cb_idx4+0].w * NdotL + perObjectData;
        float3 light_color_term3 = cb2[light_cb_idx3+0].www * lighting_result_1.xyz;
        float3 light_color_term4 = -lighting_result_1.xyz * cb2[light_cb_idx3+0].www + albedo_alpha.xyz;
        light_color_term3.xyz = NdotL.xxx * light_color_term4.xyz + light_color_term3.xyz;
        light_color_term3.xyz = cb2[light_cb_idx3+0].xyz * light_color_term3.xyz;
        NdotL = cb2[light_cb_idx3+0].x + cb2[light_cb_idx3+0].y;
        NdotL = cb2[light_cb_idx3+0].z + NdotL;
        NdotL = cb2[model_low4_high4.z+0].x + NdotL;
        NdotL = saturate(10 * NdotL);
        model_low4_high4.z = cb2[model_low4_high4.z+0].y * NdotL;
        float3 final_light_color = light_color_term2.xyz * model_low4_high4.www;
        light_color_term3.xyz = light_color_term3.xyz * model_low4_high4.www + final_light_color.xyz;
        light_radius_sq = light_radius_sq + -model_low4_high4.w;
        model_low4_high4.w = cb2[light_cb_idx6+0].w * light_radius_sq + model_low4_high4.w;
        light_accumulator.xyz = light_color_term3.xyz * shadingModelID + light_accumulator.xyz;
        model_low4_high4.z = -model_low4_high4.w * model_low4_high4.z + 1;
        shadingModelID = model_low4_high4.z * shadingModelID;
        }
        customData.x = (int)customData.x + 1;
    }
    model_low4_high4.yzw = shadingModelID * model13_14_15.xyw + light_accumulator.xyz;
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
        float3 view_vector_params = model_low4_high4.xxx ? cb0[0].yzx : cb1[264].xyz;
        view_vector_params.z = model_low4_high4.x ? 0.5 : cb1[264].z;
        normal.xyz = model_low4_high4.xxx ? model13_14_15.xyw : normal.xyz;
        model_low4_high4.x = dot(view_vector_params.xyz, normal.xyz);
        float2 fresnel_params = float2(0.200000003,1) + model_low4_high4.xx;
        model_low4_high4.x = 5 * fresnel_params.x;
        model_low4_high4.x = saturate(model_low4_high4.x);
        model13_14_15.w = model_low4_high4.x * -2 + 3;
        model_low4_high4.x = model_low4_high4.x * model_low4_high4.x;
        model_low4_high4.x = model13_14_15.w * model_low4_high4.x;
        float3 half_vector = view_vector_params.xyz + customData.xyz;
        model13_14_15.w = dot(half_vector.xyz, half_vector.xyz);
        model13_14_15.w = rsqrt(model13_14_15.w);
        half_vector.xyz = half_vector.xyz * model13_14_15.www;
        model13_14_15.w = saturate(dot(normal.xyz, half_vector.xyz));
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = model13_14_15.w * -0.800000012 + 1;
        model13_14_15.w = model13_14_15.w * model13_14_15.w;
        model13_14_15.w = 3.14159274 * model13_14_15.w;
        model13_14_15.w = 0.200000003 / model13_14_15.w;
        model13_14_15.w = model13_14_15.w * shadow;
        float VdotL = dot(view_vector_params.xyz, customData.xyz);
        float2 VdotL_remap = float2(-0.5,1) + -VdotL.xx;
        VdotL = saturate(VdotL + VdotL);
        float VdotL_smoothstep_factor = VdotL * -2 + 3;
        VdotL = VdotL * VdotL;
        VdotL = VdotL_smoothstep_factor * VdotL + 1;
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
        normal.z = fresnel_params.y * 0.25 + 0.5;
        normal.x = normal.z * normal.x;
        normal.x = normal.x * normal.y;
        normal.x = normal.x * VdotL;
        normal.x = 0.00999999978 * normal.x;
        customData.xy = float2(9.99999975e-005,9.99999975e-005) + model13_14_15.xy;
        normal.z = dot(customData.xy, customData.xy);
        normal.z = rsqrt(normal.z);
        customData.xy = customData.xy * normal.zz;
        customData.xy = customData.xy * perObjectData;
        customData.z = customData.y * normal.x;
        normal.y = -0.5;
        normal.xy = customData.xz * normal.xy;
        perObjectData = 0.400000006 * VdotL_remap.y;
        normal.z = model_low4_high4.x * 0.800000012 + 0.200000003;
        customData.x = model13_14_15.w * model_low4_high4.x;
        customData.x = 1.5 * customData.x;
        perObjectData = perObjectData * normal.z + customData.x;
        normal.z = shadow * 0.5 + 0.5;
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
        normal.xyz = shadow * customData.xyz + normal.xyz;
        normal.xyz = normal.xyz * perObjectData;
        normal.xyz = float3(0.100000001,0.100000001,0.100000001) * normal.xyz;
        customData.xyz = float3(1,1,1) + albedo_alpha.xyz;
        customData.xyz = customData.xyz * normal.xyz;
        model13_14_15.xyw = albedo_alpha.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
        model13_14_15.xyw = saturate(-model13_14_15.xyw);
        float3 albedo_remap_smooth_factor = model13_14_15.xyw * float3(-2,-2,-2) + float3(3,3,3);
        model13_14_15.xyw = model13_14_15.xyw * model13_14_15.xyw;
        model13_14_15.xyw = albedo_remap_smooth_factor.xyz * model13_14_15.xyw;
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
    packedNormalWS_perObjectData.xyz = packedNormalWS_perObjectData.xzw / eyeAdaptation;
    packedNormalWS_perObjectData.xyz = min(float3(0,0,0), -packedNormalWS_perObjectData.xyz);
    color.xyz = -packedNormalWS_perObjectData.xyz;
    return color;
}
            ENDHLSL
        }
    }
}