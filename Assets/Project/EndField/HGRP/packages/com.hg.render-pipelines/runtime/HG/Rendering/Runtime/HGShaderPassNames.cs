using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGShaderPassNames
	{
		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly string s_EmptyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly string s_ForwardStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly string s_ForwardLitStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static readonly string s_DepthOnlyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static readonly string s_DepthForwardOnlyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		public static readonly string s_DepthCharacterOnlyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		public static readonly string s_ForwardCharacterOnlyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		public static readonly string s_CharacterOutlineStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		public static readonly string s_ForwardOnlyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		public static readonly string s_ReflectionForwardOnlyStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static readonly string s_VFXDecalStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		public static readonly string s_GBufferStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		public static readonly string s_ErosionStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		public static readonly string s_ErosionMobileStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		public static readonly string s_HGBufferStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		public static readonly string s_TerrainDepthOnly;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		public static readonly string s_GBufferWithPrepassStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		public static readonly string s_SRPDefaultUnlitStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		public static readonly string s_MotionVectorsStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		public static readonly string s_DistortionStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		public static readonly string s_VolumerticFogVoxelizationStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		public static readonly string s_TransparentDepthPrepassStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		public static readonly string s_TransparentBackfaceStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		public static readonly string s_TransparentDepthPostpassStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		public static readonly string s_MetaStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		public static readonly string s_ShadowCasterStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD0")]
		public static readonly string s_FullScreenDebugStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xD8")]
		public static readonly string s_BakeHLODStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		public static readonly string s_OccludedDisplayStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE8")]
		public static readonly string s_StencilAlphaBlendStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF0")]
		public static readonly string s_PostProcessMaskStr;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xF8")]
		public static readonly ShaderTagId s_EmptyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xFC")]
		public static readonly ShaderTagId s_ForwardName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x100")]
		public static readonly ShaderTagId s_DepthOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x104")]
		public static readonly ShaderTagId s_DepthForwardOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x108")]
		public static readonly ShaderTagId s_DepthCharacterOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10C")]
		public static readonly ShaderTagId s_ForwardCharacterOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x110")]
		public static readonly ShaderTagId s_CharacterOutlineName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x114")]
		public static readonly ShaderTagId s_ForwardOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x118")]
		public static readonly ShaderTagId s_ReflectionForwardOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x11C")]
		public static readonly ShaderTagId s_VFXDecalName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x120")]
		public static readonly ShaderTagId s_GBufferName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x124")]
		public static readonly ShaderTagId s_ErosionName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x128")]
		public static readonly ShaderTagId s_ErosionMobileName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x12C")]
		public static readonly ShaderTagId s_TerrainDepthOnlyName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x130")]
		public static readonly ShaderTagId s_GBufferWithPrepassName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x134")]
		public static readonly ShaderTagId s_SRPDefaultUnlitName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x138")]
		public static readonly ShaderTagId s_MotionVectorsName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x13C")]
		public static readonly ShaderTagId s_DistortionName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x140")]
		public static readonly ShaderTagId s_VolumerticFogVoxelizationName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x144")]
		public static readonly ShaderTagId s_TransparentDepthPrepassName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x148")]
		public static readonly ShaderTagId s_TransparentBackfaceName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14C")]
		public static readonly ShaderTagId s_TransparentDepthPostpassName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x150")]
		public static readonly ShaderTagId s_FullScreenDebugName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x154")]
		public static readonly ShaderTagId s_StencilAlphaBlendName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x158")]
		public static readonly ShaderTagId s_PPMaskName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x15C")]
		public static readonly ShaderTagId s_OccludedDisplayName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x160")]
		internal static readonly ShaderTagId s_AlwaysName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x164")]
		internal static readonly ShaderTagId s_ForwardBaseName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x168")]
		internal static readonly ShaderTagId s_DeferredName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x16C")]
		internal static readonly ShaderTagId s_PrepassBaseName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x170")]
		internal static readonly ShaderTagId s_VertexName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x174")]
		internal static readonly ShaderTagId s_VertexLMRGBMName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x178")]
		internal static readonly ShaderTagId s_VertexLMName;
	}
}
