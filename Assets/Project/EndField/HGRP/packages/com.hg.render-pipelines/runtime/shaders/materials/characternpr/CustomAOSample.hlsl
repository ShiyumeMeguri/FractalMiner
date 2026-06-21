#ifndef ENDFIELD_CUSTOM_AO_SAMPLE_INCLUDED
#define ENDFIELD_CUSTOM_AO_SAMPLE_INCLUDED

// Custom AO sampling helpers — paired with CustomAmbientOcclusionRendererFeature.
//
// The renderer publishes a single RG8 texture as `_CustomAOTexture`:
//   .r = Ground Truth AO factor  (1.0 if disabled in the volume)
//   .g = Alchemy AO factor       (1.0 if disabled in the volume)
// Each factor already has its own intensity + power applied.
//
// The global keyword `_CUSTOM_AO_ON` indicates that the AO system is active
// for the current frame. Materials opt in to Ground Truth AO and/or Alchemy
// individually via the per-material toggles `_USE_GROUND_TRUTH_AO` and
// `_USE_ALCHEMY_AO`. The shadow color used to tint occluded pixels is
// supplied by the caller — each NPR shader passes its own per-material shadow
// color (e.g. _ShadowColor LUT or brightness/saturation derived color) so the
// AO darkening matches the shader's existing shadow look.

TEXTURE2D_X(_CustomAOTexture);
SAMPLER(sampler_CustomAOTexture);

// Sample the raw two-channel AO at a normalized [0,1] screen UV. The texture
// is allocated at the exact camera target size, so no _RTHandleScale fix-up
// is needed.
half2 SampleCustomAOFactors(float2 normalizedScreenUV)
{
    return SAMPLE_TEXTURE2D_X(_CustomAOTexture, sampler_CustomAOTexture, normalizedScreenUV).rg;
}

// Apply CustomAO darkening to a lit color using the caller's shadow color:
//   ao = 1 (unoccluded) -> color (unchanged)
//   ao = 0 (occluded)   -> shadowColor (replaces lit color)
// Per-material toggles select which AO contributions to use; both can be
// active (multiplied), one of them, or neither (helper becomes a no-op).
half3 ApplyCustomAO(half3 color, half3 shadowColor, float2 normalizedScreenUV)
{
#ifdef _CUSTOM_AO_ON
    half2 aoFactors = SampleCustomAOFactors(normalizedScreenUV);
    half ao = 1.0;
    #ifdef _USE_GROUND_TRUTH_AO
        ao *= aoFactors.r;
    #endif
    #ifdef _USE_ALCHEMY_AO
        ao *= aoFactors.g;
    #endif
    return lerp(shadowColor, color, ao);
#else
    return color;
#endif
}

#endif // ENDFIELD_CUSTOM_AO_SAMPLE_INCLUDED
