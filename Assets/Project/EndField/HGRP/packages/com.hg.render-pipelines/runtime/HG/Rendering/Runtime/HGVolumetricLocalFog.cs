using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/Volumetric Local Fog")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGVolumetricLocalFog : MonoBehaviour // TypeDefIndex: 37662
	{
		// Fields
		[SerializeField]
		private Material m_material; // 0x18
		private Material m_previousMaterial; // 0x20
	
		// Properties
		public Material material { get => default; set {} } // 0x0000000189CEFF8C-0x0000000189CEFFDC 0x0000000189CEFFDC-0x0000000189CF0040
		// Material get_material()
		Material *HG::Rendering::Runtime::HGVolumetricLocalFog::get_material(HGVolumetricLocalFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1554, 0LL) )
		    return this->fields.m_material;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1554, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_641(Patch, (Object *)this, 0LL);
		}
		

		// Void set_material(Material)
		void HG::Rendering::Runtime::HGVolumetricLocalFog::set_material(
		        HGVolumetricLocalFog *this,
		        Material *value,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1562, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1562, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_material = value;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_material, v5, v6, v7, v11);
		  }
		}
		
	
		// Constructors
		public HGVolumetricLocalFog() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		protected void OnEnable() {} // 0x0000000189CEFE3C-0x0000000189CEFEAC
		// Void OnEnable()
		void HG::Rendering::Runtime::HGVolumetricLocalFog::OnEnable(HGVolumetricLocalFog *this, MethodInfo *method)
		{
		  HGVolumetricLocalFogManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1563, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
		    instance = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
		    if ( instance )
		    {
		      HG::Rendering::Runtime::HGVolumetricLocalFogManager::AddVolumetricLocalFog(instance, this, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1563, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected void OnDisable() {} // 0x0000000189CEFDCC-0x0000000189CEFE3C
		// Void OnDisable()
		void HG::Rendering::Runtime::HGVolumetricLocalFog::OnDisable(HGVolumetricLocalFog *this, MethodInfo *method)
		{
		  HGVolumetricLocalFogManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1566, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
		    instance = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
		    if ( instance )
		    {
		      HG::Rendering::Runtime::HGVolumetricLocalFogManager::RemoveVolumetricLocalFog(instance, this, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1566, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected void Reset() {} // 0x0000000189CEFF3C-0x0000000189CEFF8C
		// Void Reset()
		void HG::Rendering::Runtime::HGVolumetricLocalFog::Reset(HGVolumetricLocalFog *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1570, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1570, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGVolumetricLocalFog::OnValidate(this, 0LL);
		  }
		}
		
		internal void OnValidate() {} // 0x0000000189CEFEAC-0x0000000189CEFF3C
		// Void OnValidate()
		void HG::Rendering::Runtime::HGVolumetricLocalFog::OnValidate(HGVolumetricLocalFog *this, MethodInfo *method)
		{
		  Object_1 *m_previousMaterial; // rdi
		  Object_1 *m_material; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1571, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1571, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_previousMaterial = (Object_1 *)this->fields.m_previousMaterial;
		    m_material = (Object_1 *)this->fields.m_material;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_previousMaterial, m_material, 0LL) )
		    {
		      this->fields.m_previousMaterial = this->fields.m_material;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_previousMaterial, v5, v6, v7, v11);
		    }
		  }
		}
		
	}
}
