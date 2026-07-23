using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGFoliageInteractiveConfig // TypeDefIndex: 37692
	{
		// Fields
		public Vector2Int textureSize; // 0x00
		public float centerOffsetHeight; // 0x08
		public float characterOffsetHeight; // 0x0C
		public GraphicsFormat graphicsFormat; // 0x10
		public const float FOLIAGE_INTERACTIVE_RAISE_SPEED = 0.5f; // Metadata: 0x02303066
		public const float FOLIAGE_INTERACTIVE_MIN_DELTA_TIME = 0.033f; // Metadata: 0x0230306A
		public static readonly Vector3 FOLIAGE_INTERACTIVE_CENTER_SIZE; // 0x00
	
		// Properties
		public static HGFoliageInteractiveConfig defaultConfig { get => default; } // 0x0000000182ED7FA0-0x0000000182ED8000 
		// HGFoliageInteractiveConfig get_defaultConfig()
		HGFoliageInteractiveConfig *HG::Rendering::Runtime::HGFoliageInteractiveConfig::get_defaultConfig(
		        HGFoliageInteractiveConfig *__return_ptr retstr,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGFoliageInteractiveConfig *v7; // rax
		  __int128 v8; // xmm0
		  HGFoliageInteractiveConfig v9; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1679, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1679, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_677(&v9, Patch, 0LL);
		    v8 = *(_OWORD *)&v7->textureSize.m_X;
		    LODWORD(v7) = v7->graphicsFormat;
		    *(_OWORD *)&retstr->textureSize.m_X = v8;
		    retstr->graphicsFormat = (int)v7;
		  }
		  else
		  {
		    v9.textureSize = (Vector2Int)0x10000000100LL;
		    *(_QWORD *)&v9.centerOffsetHeight = 0x3F800000BF800000LL;
		    *(_OWORD *)&retstr->textureSize.m_X = *(_OWORD *)&v9.textureSize.m_X;
		    retstr->graphicsFormat = 46;
		  }
		  return retstr;
		}
		
	
		// Constructors
		static HGFoliageInteractiveConfig() {
			FOLIAGE_INTERACTIVE_CENTER_SIZE = default;
		} // 0x0000000184D7D970-0x0000000184D7D9A0
		// HGFoliageInteractiveConfig()
		void HG::Rendering::Runtime::HGFoliageInteractiveConfig::cctor(MethodInfo *method)
		{
		  HGFoliageInteractiveConfig__StaticFields *static_fields; // rcx
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig->static_fields;
		  *(_QWORD *)&static_fields->FOLIAGE_INTERACTIVE_CENTER_SIZE.x = _mm_unpacklo_ps(
		                                                                   (__m128)0x42000000u,
		                                                                   (__m128)0x41200000u).m128_u64[0];
		  static_fields->FOLIAGE_INTERACTIVE_CENTER_SIZE.z = 32.0;
		}
		
	}
}
