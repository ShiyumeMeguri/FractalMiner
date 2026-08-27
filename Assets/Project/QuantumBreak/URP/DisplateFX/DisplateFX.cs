using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Overrides
{
    [Serializable, VolumeComponentMenu("Ruri/DisplateFX")]
    public sealed class DisplateFX : VolumeComponent, IPostProcessComponent
    {
        public BoolParameter enable = new BoolParameter(false);

        [Header("Distortion Generation")]
        [Tooltip("Intensity of the distortion velocity written to the buffer.")]
        public ClampedFloatParameter distortionIntensity = new ClampedFloatParameter(1.0f, 0f, 5f);

        [Header("Visual Generation")]
        [Tooltip("Intensity of the visual effect (glow/particles) written to the buffer.")]
        public ClampedFloatParameter visualIntensity = new ClampedFloatParameter(1.0f, 0f, 10f);

        public bool IsActive() => enable.value;
        public bool IsTileCompatible() => false;
    }
}