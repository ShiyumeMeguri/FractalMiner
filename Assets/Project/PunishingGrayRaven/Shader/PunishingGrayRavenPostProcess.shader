Shader "Ruri/PunishingGrayRaven/PostProcess"
{
    Properties
    {
        _BlitTexture ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/SurfaceInput.hlsl"
            #include "Packages/com.unity.render-pipelines.core/Runtime/Utilities/Blit.hlsl"
            #include "PunishingGrayRavenPostProcessInput.hlsl"
            #include "PunishingGrayRavenPostProcess.hlsl"
        ENDHLSL

        Pass
        {
            Name "Even Blur" // 0
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment Blur_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Luminance Picker" // 1
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment LuminancePicker_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Luminance Blur 5x5" // 2
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment LuminanceBlur_5x5_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Luminance Blur 8x8" // 3
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment LuminanceBlur_8x8_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Luminance Blur 11x11" // 4
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment LuminanceBlur_11x11_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Luminance Add" // 5
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment LuminanceBlur_Add_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Color Grading" // 6
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment ColorGrading_Fragment
            ENDHLSL
        }

        Pass
        {
            Name "Particle Disslove" // 7
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment ParticleDisslove_Fragment
            ENDHLSL
        }
    }
}
