using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXSceneColorAdjustment(\u573A\u666F\u989C\u8272\u8C03\u8282)")]
	[ExecuteAlways]
	public class VFXSceneDark : VFXPlayableMonoBase // TypeDefIndex: 37976
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float _sceneDark; // 0x20
		[SerializeField]
		private UnityEngine.Color _sceneDarkColor; // 0x24
		[SerializeField]
		private bool _useSceneSaturation; // 0x34
		[Range(0f, 1f)]
		[SerializeField]
		private float _sceneSaturation; // 0x38
		[SerializeField]
		private bool _stopAutoExposure; // 0x3C
	
		// Properties
		public Vector3 sceneDark { get => default; } // 0x0000000184258C40-0x0000000184258D10 
		// Vector3 get_sceneDark()
		Vector3 *HG::Rendering::Runtime::VFXSceneDark::get_sceneDark(
		        Vector3 *__return_ptr retstr,
		        VFXSceneDark *this,
		        MethodInfo *method)
		{
		  float b; // xmm5_4
		  float sceneDark; // xmm3_4
		  __m128 v7; // xmm0
		  __m128 v8; // xmm1
		  Vector3 *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Vector3 *v13; // rax
		  __int64 v14; // xmm0_8
		  Vector3 v15[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2330, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2330, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v15, Patch, (Object *)this, 0LL);
		    v14 = *(_QWORD *)&v13->x;
		    *(float *)&v13 = v13->z;
		    *(_QWORD *)&retstr->x = v14;
		    LODWORD(retstr->z) = (_DWORD)v13;
		    return retstr;
		  }
		  if ( this->fields._sceneDark < 0.99 )
		  {
		    b = this->fields._sceneDarkColor.b;
		    sceneDark = this->fields._sceneDark;
		    if ( sceneDark < 0.0 )
		    {
		      sceneDark = 0.0;
		    }
		    else if ( sceneDark > 1.0 )
		    {
		      sceneDark = 1.0;
		    }
		    v7 = (__m128)0x3F800000u;
		    v7.m128_f32[0] = (float)((float)(1.0 - this->fields._sceneDarkColor.r) * sceneDark) + this->fields._sceneDarkColor.r;
		    v8 = (__m128)0x3F800000u;
		    v8.m128_f32[0] = (float)((float)(1.0 - this->fields._sceneDarkColor.g) * sceneDark) + this->fields._sceneDarkColor.g;
		    *(_QWORD *)&retstr->x = _mm_unpacklo_ps(v7, v8).m128_u64[0];
		    retstr->z = (float)((float)(1.0 - b) * sceneDark) + b;
		    return retstr;
		  }
		  result = retstr;
		  *(_QWORD *)&retstr->x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  retstr->z = 1.0;
		  return result;
		}
		
		public float sceneSaturation { get => default; } // 0x000000018445D410-0x000000018445D450 
		// Single get_sceneSaturation()
		float HG::Rendering::Runtime::VFXSceneDark::get_sceneSaturation(VFXSceneDark *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2332, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2332, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields._useSceneSaturation )
		  {
		    return this->fields._sceneSaturation;
		  }
		  else
		  {
		    return 1.0;
		  }
		}
		
		public bool stopAutoExposure { get => default; } // 0x00000001844B0200-0x00000001844B0230 
		// Boolean get_stopAutoExposure()
		bool HG::Rendering::Runtime::VFXSceneDark::get_stopAutoExposure(VFXSceneDark *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2331, 0LL) )
		    return this->fields._stopAutoExposure;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2331, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXSceneDark() {} // 0x00000001842EDF90-0x00000001842EDFC0
		// VFXSceneDark()
		void HG::Rendering::Runtime::VFXSceneDark::VFXSceneDark(VFXSceneDark *this, MethodInfo *method)
		{
		  Quaternion *identity; // rax
		  __int64 v3; // r8
		  Quaternion v4; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields._sceneDark = 1.0;
		  identity = UnityEngine::Quaternion::get_identity(&v4, method);
		  *(Quaternion *)(v3 + 36) = *identity;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)v3, 0LL);
		}
		
	
		// Methods
		protected override void OnPlay() {} // 0x0000000184695A20-0x0000000184695A80
		// Void OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HGVFXManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2608, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2608, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( instance )
		      HG::Rendering::Runtime::HGVFXManager::AddSceneDarkToManager(instance, this, 0LL);
		  }
		}
		
		protected override void OnStop() {} // 0x0000000184703890-0x00000001847038F0
		// Void OnStop()
		void HG::Rendering::Runtime::VFXSceneDark::OnStop(VFXSceneDark *this, MethodInfo *method)
		{
		  HGVFXManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2609, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2609, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		    instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		    if ( instance )
		      HG::Rendering::Runtime::HGVFXManager::RemoveSceneDarkToManager(instance, this, 0LL);
		  }
		}
		
		public void __iFixBaseProxy_OnPlay() {} // 0x000000018745BF58-0x000000018745BF60
		// Void <>iFixBaseProxy_OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnStop() {} // 0x0000000186FE0B3C-0x0000000186FE0B44
		// Void <>iFixBaseProxy_OnStop()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
		}
		
	}
}
