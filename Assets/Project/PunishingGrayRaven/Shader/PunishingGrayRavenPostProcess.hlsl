#ifndef GRAY_RAVEN_POSTFX_INCLUDED
#define GRAY_RAVEN_POSTFX_INCLUDED

inline half3 LinearToGammaSpace (half3 linRGB)
{
    linRGB = max(linRGB, half3(0.h, 0.h, 0.h));
    // An almost-perfect approximation from http://chilliant.blogspot.com.au/2012/08/srgb-approximations-for-hlsl.html?m=1
    return max(1.055h * pow(linRGB, 0.416666667h) - 0.055h, 0.h);

    // Exact version, useful for debugging.
    //return half3(LinearToGammaSpaceExact(linRGB.r), LinearToGammaSpaceExact(linRGB.g), LinearToGammaSpaceExact(linRGB.b));
}
inline half3 GammaToLinearSpace (half3 sRGB)
{
    // Approximate version from http://chilliant.blogspot.com.au/2012/08/srgb-approximations-for-hlsl.html?m=1
    return sRGB * (sRGB * (sRGB * 0.305306011h + 0.682171111h) + 0.012522878h);

    // Precise version, useful for debugging.
    //return half3(GammaToLinearSpaceExact(sRGB.r), GammaToLinearSpaceExact(sRGB.g), GammaToLinearSpaceExact(sRGB.b));
}


// 均值模糊Pass
half4 Blur_Fragment(Varyings i) : SV_TARGET
{
    // 采样点颜色并均值模糊
    float2 uv1 = i.texcoord.xy + _BlitTexture_TexelSize.xy;                          // 右上
    float2 uv2 = i.texcoord.xy + _BlitTexture_TexelSize.xy * float2(1.0, -1.0);      // 右下
    float2 uv3 = i.texcoord.xy - _BlitTexture_TexelSize.xy;                          // 左下
    float2 uv4 = i.texcoord.xy + _BlitTexture_TexelSize.xy * float2(-1.0, 1.0);      // 左上

    // 均值模糊采样
    half4 color1 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv1);
    half4 color2 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv2);
    half4 color3 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv3);
    half4 color4 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv4);

    return (color1 + color2 + color3 + color4) * 0.25h;
}

// 亮度提取Pass
half4 LuminancePicker_Fragment(Varyings i) : SV_TARGET
{
    half4 main_color = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, i.texcoord);
    // 转换到Gamma空间下来提取计算亮度
    half3 main_color_gamma = LinearToGammaSpace(main_color.rgb);
    main_color_gamma = (main_color_gamma - _FilterThreshold) * _FilterScaler * main_color.a;
    main_color_gamma = max(0, main_color_gamma);

    return half4(main_color_gamma, 1.0);
}

// 提取亮度后的纹理模糊Pass
half4 LuminanceBlur_5x5_Fragment(Varyings i) : SV_TARGET
{
    float2 uv1 = i.texcoord + 0.015625 * _BlurDir.xy; // 0.25  4
    float2 uv2 = i.texcoord + 0.001547 * _BlurDir.xy; // 2.525  0.396032
    float2 uv3 = i.texcoord + 0.0082339998 * _BlurDir.xy; // 0.4744  2.107
    float2 uv4 = i.texcoord - 0.011912 * _BlurDir.xy; // 0.3279  3.04
    float2 uv5 = i.texcoord - 0.004764 * _BlurDir.xy; // 0.81995 1.2196
    // 猜测是使用了单独计算的卷积核 计算约等于偏移0.4 1.2 2 3 4纹素的像素并卷积

    half4 color1 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv1) * 0.000425;
    half4 color2 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv2) * 0.60708803;
    half4 color3 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv3) * 0.075851999;
    half4 color4 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv4) * 0.0086089997;
    half4 color5 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv5) * 0.30802599;

    return color1 + color2 + color3 + color4 + color5;
}
half4 LuminanceBlur_8x8_Fragment(Varyings i) : SV_TARGET
{
    float2 uv1 = i.texcoord + 0.010686 * _BlurDir.xy;
    float2 uv2 = i.texcoord + 0.025157999 * _BlurDir.xy;
    float2 uv3 = i.texcoord + 0.040004998 * _BlurDir.xy;
    float2 uv4 = i.texcoord + 0.054687999 * _BlurDir.xy;
    float2 uv5 = i.texcoord - 0.047556002 * _BlurDir.xy;
    float2 uv6 = i.texcoord - 0.032535002 * _BlurDir.xy;
    float2 uv7 = i.texcoord - 0.017878 * _BlurDir.xy;
    float2 uv8 = i.texcoord - 0.0035540001 * _BlurDir.xy;

    half4 color1 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv1) * 0.31658;
    half4 color2 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv2) * 0.060511999;
    half4 color3 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv3) * 0.0029819999;
    half4 color4 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv4) * 3.4000001e-5f;
    half4 color5 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv5) * 0.000394;
    half4 color6 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv6) * 0.015949;
    half4 color7 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv7) * 0.163609;
    half4 color8 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv8) * 0.43993899;

    return color1 + color2 + color3 + color4 + color5 + color6 + color7 + color8;
}
half4 LuminanceBlur_11x11_Fragment(Varyings i) : SV_TARGET
{
    float2 uv1 = i.texcoord + 0.037498001 * _BlurDir.xy;
    float2 uv2 = i.texcoord + 0.067578003 * _BlurDir.xy;
    float2 uv3 = i.texcoord + 0.097782999 * _BlurDir.xy;
    float2 uv4 = i.texcoord + 0.007495 * _BlurDir.xy;
    float2 uv5 = i.texcoord - 0.14337599 * _BlurDir.xy;
    float2 uv6 = i.texcoord - 0.112941 * _BlurDir.xy;
    float2 uv7 = i.texcoord - 0.082662001 * _BlurDir.xy;
    float2 uv8 = i.texcoord - -0.052524 * _BlurDir.xy;
    float2 uv9 = i.texcoord - 0.02249 * _BlurDir.xy;
    float2 uv10 = i.texcoord + 0.128139 * _BlurDir.xy;
    float2 uv11 = i.texcoord + 0.015625 * _BlurDir.xy;

    half4 color1 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv1) * 0.193602;
    half4 color2 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv2) * 0.064944997;
    half4 color3 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv3) * 0.011641;
    half4 color4 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv4) * 0.30904999;
    half4 color5 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv5) * 0.000271;
    half4 color6 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv6) * 0.0038930001;
    half4 color7 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv7) * 0.029742001;
    half4 color8 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv8) * 0.12125;
    half4 color9 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv9) * 0.26444501;
    half4 color10 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv10) * 0.001112;
    half4 color11 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, uv11) * 4.8000002e-5f;

    return color1 + color2 + color3 + color4 + color5 + color6 + color7 + color8 + color9 + color10 + color11;
}
half4 LuminanceBlur_Add_Fragment(Varyings i) : SV_TARGET
{
    half4 bloom0 = SAMPLE_TEXTURE2D(_BloomTex0, sampler_BloomTex0, i.texcoord) * _BloomCombineCoeff.x;
    half4 bloom1 = SAMPLE_TEXTURE2D(_BloomTex1, sampler_BloomTex1, i.texcoord) * _BloomCombineCoeff.y;
    half4 bloom2 = SAMPLE_TEXTURE2D(_BloomTex2, sampler_BloomTex2, i.texcoord) * _BloomCombineCoeff.z;
    half4 bloom3 = SAMPLE_TEXTURE2D(_BloomTex3, sampler_BloomTex3, i.texcoord) * _BloomCombineCoeff.w;

    return bloom0 + bloom1 + bloom2 + bloom3;
}

// 颜色分级Pass
half4 ColorGrading_Fragment(Varyings i) : SV_TARGET
{
    // 计算四个偏移位置及像素本身的纹素信息并计算亮度
    float4 main_uv_offset = i.texcoord.xyxy + float4(-0.5, -0.5, 0.5, 0.5) * _BlitTexture_TexelSize.xyxy;
    main_uv_offset = main_uv_offset * _BlitScaleBias.xyxy + _BlitScaleBias.zwzw;
    half3 main_color_offset1 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, main_uv_offset.xy).rgb;
    half lum1 = Luminance(main_color_offset1);
    half3 main_color_offset2 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, main_uv_offset.xw).rgb;
    half lum2 = Luminance(main_color_offset2);
    half3 main_color_offset3 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, main_uv_offset.zy).rgb;
    half lum3 = Luminance(main_color_offset3) + 0.0026041667;
    half3 main_color_offset4 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, main_uv_offset.zw).rgb;
    half lum4 = Luminance(main_color_offset4);
    float2 main_uv = i.texcoord.xy * _BlitScaleBias.xy + _BlitScaleBias.zw;
    half4 main_color = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, main_uv);
    half lum = Luminance(main_color.rgb);

    half offset_max_lum = max(max(lum1, lum2), max(lum3, lum4));
    half lum_console = max(offset_max_lum * _ConsoleSettings.z, _ConsoleSettings.w);
    half max_lum = max(offset_max_lum, lum);
    half offset_min_lum = min(min(lum1, lum2), min(lum3, lum4));
    half min_lum = min(offset_min_lum, lum);
    bool lum_step = (max_lum - min_lum) >= lum_console;
    if(lum_step)
    {
        float2 console_uv1 = _BlitTexture_TexelSize.xy * _ConsoleSettings.x;
        float2 console_uv2 = _BlitTexture_TexelSize.xy * 2;
        // 比较 左上 与 右下 以及 右上 与 左下 的像素亮度差
        half lum_com1 = lum2 - lum3;
        half lum_com2 = lum4 - lum1;
        // 基于亮度差获取到一个方向
        half2 lum_dir = normalize(half2(lum_com1 + lum_com2, lum_com1 - lum_com2));
        // 使用这个亮度差得到的方向来偏移基础uv，并重新采样纹理(2次)
        float2 lum_off_uv = main_uv - console_uv1 * lum_dir; 
        half4 lum_off_color1 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, lum_off_uv);
        lum_off_uv = main_uv + console_uv1 * lum_dir; 
        half4 lum_off_color2 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, lum_off_uv);
        half min_lum_dir = min(abs(lum_dir.x), abs(lum_dir.y)) * _ConsoleSettings.y;
        // 利用这个最小值进一步获得到一个偏移方向再对主纹理进行两次采样
        lum_dir /= min_lum_dir;
        lum_dir = min(max(lum_dir, -2), 2);
        lum_off_uv = main_uv - console_uv2 * lum_dir; 
        half4 lum_off_color3 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, lum_off_uv);
        lum_off_uv = main_uv + console_uv2 * lum_dir; 
        half4 lum_off_color4 = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, lum_off_uv);
        // 均值叠加颜色
        half4 evg_color = (lum_off_color1 + lum_off_color2 + lum_off_color3 + lum_off_color4) * 0.25;
        half evg_color_lum = Luminance(evg_color.rgb);
        // 判断主纹理颜色要采用哪一块
        main_color = (evg_color_lum < offset_min_lum || offset_max_lum < evg_color_lum) ? (lum_off_color1 + lum_off_color2) * 0.5 : evg_color;
    }
    half3 bloom_color = SAMPLE_TEXTURE2D(_BloomTex, sampler_BloomTex, i.texcoord).rgb;
    // 同样的骚操作，用linear转gamma的方式把主颜色提亮
    half3 main_color_gamma = LinearToGammaSpace(main_color.rgb);
    // 混合泛光颜色
    half3 mixed_bloom_color = bloom_color * _FinalBlendFactor.y + main_color_gamma * _FinalBlendFactor.x;
    mixed_bloom_color *= _Exposure;
    // 如果是LDR，在生成GBuffer的fs中，对自发，也就是光照部分进行exp2处理
    // 因为需要将其编码到ARGB8图片，HDR信息全部写在floating point buffer就不需要编码
    mixed_bloom_color = 1 - exp2(-mixed_bloom_color);
    // 应用对比度
    half contrast = _Contrast + 0.01;
    mixed_bloom_color = pow(mixed_bloom_color, contrast);
    // 将颜色变换到线性空间下并clamp
    main_color.rgb = GammaToLinearSpace(mixed_bloom_color);
    main_color.rgb = clamp(main_color.rgb, 0.0, 1.0);
    // 故技重施，将mixed_bloom_color变换到Gamma空间提高亮度来做lut采样
    half3 mixed_bloom_color_gamma = LinearToGammaSpace(mixed_bloom_color);
    // 开始引用color grading lut查找表
    half3 mixed_bloom_color_gamma_lut = mixed_bloom_color_gamma * _UserLut_Params.z;
    mixed_bloom_color_gamma_lut.x = floor(mixed_bloom_color_gamma_lut.x);
    half3 lut_sampler_params;
    lut_sampler_params.xy = _UserLut_Params.xy * 0.5;
    lut_sampler_params.yz = mixed_bloom_color_gamma_lut.yz * _UserLut_Params.xy + lut_sampler_params.xy;
    lut_sampler_params.x = mixed_bloom_color_gamma_lut.x * _UserLut_Params.y + lut_sampler_params.y;

    half3 lut_color1 = SAMPLE_TEXTURE2D(_UserLut, sampler_UserLut, lut_sampler_params.xz).rgb;

    lut_sampler_params.xz += half2(_UserLut_Params.y, 0.0);
    half3 lut_color2 = SAMPLE_TEXTURE2D(_UserLut, sampler_UserLut, lut_sampler_params.xz).rgb;
    // lerp两个lutcolor
    half lut_param1 = mixed_bloom_color_gamma.x * _UserLut_Params.z - mixed_bloom_color_gamma_lut.x;
    half3 lut_color = lerp(lut_color1, lut_color2, lut_param1);
    // 将这个lerp后的lutcolor变换到线性空间下，与MainColor进行线性插值
    half3 lut_color_linear = GammaToLinearSpace(lut_color);
    main_color.rgb = lerp(main_color.rgb, lut_color_linear, _UserLut_Params.www);
    
    return main_color;
}

// 特效深度扭曲效果相关
half4 ParticleDisslove_Fragment(Varyings i) : SV_TARGET
{
    float4 particle_depth_color = SAMPLE_TEXTURE2D(_ParticleDepthTexture, sampler_ParticleDepthTexture, i.texcoord);
    float depth = SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, sampler_CameraDepthTexture, i.texcoord).r;
    float depth_linear = Linear01Depth(depth, _ZBufferParams);
    // 取出属于需要模糊的部分 1代表可以扭曲的部分，0代表被不透明对象挡住不可以扭曲的部分
    float particle_depth_step = step(particle_depth_color.a, depth_linear);
    // 处理扭曲的部分
    half2 dissolve_uv = i.texcoord + (_BlitTexture_TexelSize.xy * (particle_depth_color.gb * 2 - 1) * particle_depth_color.r) / _GlobalDissolveScale;
    half4 disslove_color = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, dissolve_uv);
    // 采样正常的纹理部分
    half4 main_tex = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, i.texcoord);
    half4 final_color = lerp(main_tex, disslove_color, particle_depth_step);
    return final_color;
}

#endif // GRAY_RAVEN_POSTFX_INCLUDED