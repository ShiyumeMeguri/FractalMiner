using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Overrides
{
    [Serializable, VolumeComponentMenu("Ruri/Time FX")]
    public sealed class TimeFX : VolumeComponent, IPostProcessComponent
    {
        public BoolParameter enable = new BoolParameter(false);

        [Header("Composite Settings")]
        public ClampedFloatParameter effectIntensity = new ClampedFloatParameter(1.0f, 0f, 5.0f);
        public ClampedFloatParameter stutterFrequency = new ClampedFloatParameter(10.0f, 0f, 60f);
        public ClampedFloatParameter chromaticAberration = new ClampedFloatParameter(1.0f, 0f, 5f);

        public bool IsActive() => enable.value;
        public bool IsTileCompatible() => false;
    }
}