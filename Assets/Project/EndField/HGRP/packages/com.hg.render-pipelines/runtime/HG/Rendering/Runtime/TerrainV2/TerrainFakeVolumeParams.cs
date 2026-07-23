using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	public struct TerrainFakeVolumeParams // TypeDefIndex: 38830
	{
		// Fields
		public bool _EnableFakeVolume; // 0x00
		public float _FakeVolumeIoR; // 0x04
		public float _FakeVolumeFresnelStrength; // 0x08
		public EFakeVolumeMode _FakeVolumeMode; // 0x0C
		public float _FakeVolumeOpacityTiling; // 0x10
		public float _FakeCrackLayerTiling; // 0x14
		public UnityEngine.Color _FakeCrackTint; // 0x18
		public float _FakeCrackHeightScale; // 0x28
		public float _FakeCrackDepth; // 0x2C
		public float _FakeCrackMarchSteps; // 0x30
		public UnityEngine.Color _FakeRefractionTint; // 0x34
		public float _FakeRefractionLayerTiling; // 0x44
		public UnityEngine.Color _FakeVolumeScatterExtinction; // 0x48
		public UnityEngine.Color _FakeVolumeScatterAlbedo; // 0x58
		public float _FakeRefractionHeightScale; // 0x68
		public float _FakeRefractionDepth; // 0x6C
		public float _FakeRefractionMarchSteps; // 0x70
		public float _FakeDustLayerTiling; // 0x74
		public float _FakeDustDepth; // 0x78
		public Vector4 _FakeDustFlowSpeed; // 0x7C
		public UnityEngine.Color _FakeDustTint; // 0x8C
	}
}
