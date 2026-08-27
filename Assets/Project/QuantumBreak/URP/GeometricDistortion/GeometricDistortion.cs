using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Ruri.Rendering.Overrides
{
    [Serializable, VolumeComponentMenu("Ruri/Geometric Distortion")]
    public sealed class GeometricDistortion : VolumeComponent, IPostProcessComponent
    {
        public BoolParameter enable = new BoolParameter(false);

        [Header("Projection & Masking")]
        [Tooltip("World space center of the distortion field.")]
        public Vector3Parameter centerPosition = new Vector3Parameter(Vector3.zero);

        [Tooltip("Size of the simulation area (Orthographic Size).")]
        public FloatParameter areaSize = new FloatParameter(20f);

        [Tooltip("Direction of the displacement in World Space.")]
        public Vector3Parameter displacementDirection = new Vector3Parameter(Vector3.up);

        [Tooltip("Visual intensity of the displacement. Use this to fix the 'too high' issue.")]
        public FloatParameter displacementScale = new FloatParameter(0.1f);

        [Tooltip("Inner radius for the spherical mask (full effect).")]
        public FloatParameter innerRadius = new FloatParameter(5.0f);

        [Tooltip("Outer radius for the spherical mask (fade out).")]
        public FloatParameter outerRadius = new FloatParameter(8.0f);

        [Header("Simulation Settings")]
        public ClampedIntParameter simulationResolution = new ClampedIntParameter(256, 64, 2048);

        [Tooltip("Simulation speed.")]
        public ClampedFloatParameter waveSpeed = new ClampedFloatParameter(1.0f, 0.1f, 20.0f);

        [Tooltip("Wave decay factor. (RenderDoc: ~1.5)")]
        public ClampedFloatParameter decayFactor = new ClampedFloatParameter(1.5f, 0.8f, 3.0f);

        [Tooltip("Max height clamp for simulation values. (RenderDoc: ~6.0)")]
        public FloatParameter heightClamp = new FloatParameter(6.0f);

        public bool IsActive() => enable.value;

        public bool IsTileCompatible() => false;
    }
}