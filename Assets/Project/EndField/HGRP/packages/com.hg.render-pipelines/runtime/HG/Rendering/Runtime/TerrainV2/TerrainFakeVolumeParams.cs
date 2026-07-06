using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 156)]
	public struct TerrainFakeVolumeParams
	{
		public bool _EnableFakeVolume;

		public float _FakeVolumeIoR;

		public float _FakeVolumeFresnelStrength;

		public EFakeVolumeMode _FakeVolumeMode;

		public float _FakeVolumeOpacityTiling;

		public float _FakeCrackLayerTiling;

		public Color _FakeCrackTint;

		public float _FakeCrackHeightScale;

		public float _FakeCrackDepth;

		public float _FakeCrackMarchSteps;

		public Color _FakeRefractionTint;

		public float _FakeRefractionLayerTiling;

		public Color _FakeVolumeScatterExtinction;

		public Color _FakeVolumeScatterAlbedo;

		public float _FakeRefractionHeightScale;

		public float _FakeRefractionDepth;

		public float _FakeRefractionMarchSteps;

		public float _FakeDustLayerTiling;

		public float _FakeDustDepth;

		public Vector4 _FakeDustFlowSpeed;

		public Color _FakeDustTint;
	}
}
