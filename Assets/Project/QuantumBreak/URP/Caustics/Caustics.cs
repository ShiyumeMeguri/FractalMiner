using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Overrides
{
    [Serializable, VolumeComponentMenu("Ruri/Caustics")]
    public sealed class Caustics : VolumeComponent, IPostProcessComponent
    {
        public BoolParameter enable = new BoolParameter(false);

        [Header("Caustics Settings")]
        [Tooltip("Caustics texture pattern.")]
        public TextureParameter causticsTexture = new TextureParameter(null);

        [Tooltip("Color of the caustics.")]
        public ColorParameter causticsColor = new ColorParameter(new Color(0.16f, 0.65f, 1.0f)); // 还原参考颜色

        [Tooltip("Intensity of the effect.")]
        public ClampedFloatParameter intensity = new ClampedFloatParameter(1.0f, 0f, 10f);

        [Tooltip("Size of the caustics projection.")]
        public FloatParameter scale = new FloatParameter(1.0f);

        [Tooltip("Animation speed.")]
        public FloatParameter speed = new FloatParameter(0.2f);

        [Header("Distortion Interaction")]
        [Tooltip("How much the geometric distortion affects the caustics UV.")]
        public ClampedFloatParameter distortionInfluence = new ClampedFloatParameter(0.5f, 0f, 2f);

        [Header("Masking")]
        [Tooltip("Height range relative to the distortion center where caustics appear.")]
        public FloatParameter heightFalloff = new FloatParameter(10.0f);
        
        [Tooltip("Cutoff for light facing (dot product).")]
        public ClampedFloatParameter normalThreshold = new ClampedFloatParameter(0.1f, -1f, 1f);

        public bool IsActive() => enable.value && causticsTexture.value != null;
        public bool IsTileCompatible() => false;
    }
}