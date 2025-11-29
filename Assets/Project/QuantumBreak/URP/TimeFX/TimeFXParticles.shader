Shader "Ruri/Particles/TimeFXParticles"
{
    Properties
    {
        [Header(General)]
        [MainTexture] _BaseMap("g_sColorMap", 2D) = "white" {}
        [HDR] _BaseColor("Intensity Modulator", Color) = (1,1,1,1)
        
        [Header(Distortion)]
        _DistortionIntensity ("Distortion Intensity", Float) = 2.0
        
        [Header(TimeFX Visual)]
        _ExplosionIntensity ("Visual Intensity", Float) = 2.5
        _NearFadeDistance ("Near Fade Distance", Float) = 1.0
        _SoftParticleFade ("Soft Particle Fade", Float) = 1.0 
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" "RenderPipeline" = "UniversalPipeline" }

        // 引用 DisplateFX 的 Pass (需要确保 DisplateFX shader 中的 Pass Name 为 "DisplateFX")
        UsePass "Ruri/Particles/DisplateFX/DISPLATEFX"

        // 引用 TimeFX 的 Pass
        UsePass "Ruri/Particles/TimeFX/TIMEFX"
    }
}