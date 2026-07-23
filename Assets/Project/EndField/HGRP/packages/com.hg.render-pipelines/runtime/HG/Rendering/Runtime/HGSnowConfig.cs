using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGSnowConfig : IEnvConfig // TypeDefIndex: 37623
	{
		// Fields
		[Header("\u542F\u7528\u4E0B\u96EA")]
		public bool enable; // 0x00
		[Range(0f, 100f)]
		public float intensity; // 0x04
		public Vector2 speed; // 0x08
		public UnityEngine.Color color; // 0x10
		public Vector2 snowSizeRange; // 0x20
		[Range(0f, 360f)]
		public float horizontalSnowAngle; // 0x28
		[Range(0f, 1f)]
		public float horizontalSnowLevel; // 0x2C
		[Range(0f, 2f)]
		public float snowTrailLength; // 0x30
		[Range(0f, 1f)]
		public float snowJitterLevel; // 0x34
		[Range(0f, 1f)]
		public float snowSpeedNoiseLevel; // 0x38
		[Range(0f, 3f)]
		public float snowSpeedNoiseFreq; // 0x3C
		[Range(0f, 1f)]
		public float snowLightingPercent; // 0x40
		[Range(0.01f, 10f)]
		public float snowCollisionFadeTimeScale; // 0x44
		[HideInInspector]
		public Vector3 snowDirection; // 0x48
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x54
		public static HGSnowConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B9F290-0x0000000183B9F2F0 0x00000001831D5230-0x00000001831D5270
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGSnowConfig::get_active(HGSnowConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1401 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x579 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29].vtable.Finalize.method )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1401, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_570(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGSnowConfig::set_active(HGSnowConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1402, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1402, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_571(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGSnowConfig(bool active) : this() {
			enable = default;
			intensity = default;
			speed = default;
			color = default;
			snowSizeRange = default;
			horizontalSnowAngle = default;
			horizontalSnowLevel = default;
			snowTrailLength = default;
			snowJitterLevel = default;
			snowSpeedNoiseLevel = default;
			snowSpeedNoiseFreq = default;
			snowLightingPercent = default;
			snowCollisionFadeTimeScale = default;
			snowDirection = default;
			m_active = default;
		} // 0x0000000184A7E040-0x0000000184A7E0B0
		// HGSnowConfig(Boolean)
		void HG::Rendering::Runtime::HGSnowConfig::HGSnowConfig(HGSnowConfig *this, bool active, MethodInfo *method)
		{
		  ITilemap *v3; // r9
		  TileAnimationData v4; // xmm1
		  __int64 v5; // rdx
		  __int64 v6; // r8
		  TileAnimationData v7; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  *(_QWORD *)&this->intensity = 0LL;
		  this->enable = 0;
		  this->speed.y = 0.0;
		  v4 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		          &v7,
		          (TileBase *)this,
		          0LL,
		          v3,
		          (MethodInfo *)v7.m_AnimatedSprites);
		  *(_QWORD *)(v5 + 40) = v6;
		  *(_QWORD *)(v5 + 48) = v6;
		  *(TileAnimationData *)(v5 + 16) = v4;
		  *(_QWORD *)(v5 + 56) = v6;
		  *(_DWORD *)(v5 + 64) = v6;
		  *(_DWORD *)(v5 + 32) = v6;
		  *(_QWORD *)(v5 + 72) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  *(_DWORD *)(v5 + 80) = 0;
		  *(_DWORD *)(v5 + 36) = 1036831949;
		  *(_DWORD *)(v5 + 68) = 1065353216;
		}
		
		static HGSnowConfig() {
			defaultConfig = default;
		} // 0x0000000184A7DFB0-0x0000000184A7E040
		// HGSnowConfig()
		void HG::Rendering::Runtime::HGSnowConfig::cctor(MethodInfo *method)
		{
		  Color color; // xmm1
		  HGSnowConfig__StaticFields *static_fields; // rcx
		  __int128 v3; // xmm0
		  __int128 v4; // xmm1
		  __int128 v5; // xmm0
		  HGSnowConfig v6; // [rsp+20h] [rbp-68h] BYREF
		
		  memset(&v6, 0, sizeof(v6));
		  HG::Rendering::Runtime::HGSnowConfig::HGSnowConfig(&v6, 0, 0LL);
		  color = v6.color;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGSnowConfig->static_fields;
		  *(_OWORD *)&static_fields->defaultConfig.enable = *(_OWORD *)&v6.enable;
		  v3 = *(_OWORD *)&v6.snowSizeRange.x;
		  static_fields->defaultConfig.color = color;
		  v4 = *(_OWORD *)&v6.snowTrailLength;
		  *(_OWORD *)&static_fields->defaultConfig.snowSizeRange.x = v3;
		  v5 = *(_OWORD *)&v6.snowLightingPercent;
		  *(_OWORD *)&static_fields->defaultConfig.snowTrailLength = v4;
		  *(_QWORD *)&v4 = *(_QWORD *)&v6.snowDirection.z;
		  *(_OWORD *)&static_fields->defaultConfig.snowLightingPercent = v5;
		  *(_QWORD *)&static_fields->defaultConfig.snowDirection.z = v4;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
