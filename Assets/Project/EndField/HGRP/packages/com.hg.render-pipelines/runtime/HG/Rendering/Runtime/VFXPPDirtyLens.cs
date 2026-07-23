using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPDirtyLens(\u955C\u5934\u810F\u8FF9)")]
	[ExecuteInEditMode]
	public class VFXPPDirtyLens : VFXPPComponent // TypeDefIndex: 37955
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float _intensity; // 0x48
		[SerializeField]
		private Texture2D _dirtyTex; // 0x50
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184D51690-0x0000000184D516C0 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPDirtyLens::get_m_VFXPPType(VFXPPDirtyLens *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2503, 0LL) )
		    return 6;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2503, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPDirtyLens() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000183089B80-0x0000000183089E50
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPDirtyLens::Apply(
		        VFXPPDirtyLens *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  void *monitor; // rcx
		  MonitorData *v6; // rdx
		  __int64 (__fastcall *v7)(VFXPPDirtyLens *, MonitorData *, MethodInfo *); // rax
		  __int64 v8; // rax
		  __int64 v9; // rbx
		  struct MethodInfo *v10; // rbx
		  RuntimeTypeHandle v11; // rbx
		  Type *TypeFromHandle; // rax
		  struct MethodInfo *v13; // rdi
		  RuntimeTypeHandle v14; // rbx
		  Type *v15; // rbx
		  Il2CppRGCTXData v16; // rdx
		  Object__Class *klass; // rax
		  Object__Class *v18; // rbx
		  Texture2D *dirtyTex; // rdi
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  Int32__Array **v21; // r9
		  HGRuntimeGrassQuery_Node *name; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v24; // rax
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  monitor = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    monitor = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (MonitorData *)**((_QWORD **)monitor + 23);
		  if ( !v6 )
		    goto LABEL_37;
		  if ( *((int *)v6 + 6) > 2504 )
		  {
		    if ( !*((_DWORD *)monitor + 56) )
		    {
		      il2cpp_runtime_class_init_1(monitor);
		      monitor = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    monitor = (void *)**((_QWORD **)monitor + 23);
		    if ( !monitor )
		      goto LABEL_37;
		    if ( *((_DWORD *)monitor + 6) <= 0x9C8u )
		      sub_1800D2AB0(monitor, v6);
		    if ( *((_QWORD *)monitor + 2508) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2504, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		          (ILFixDynamicMethodWrapper_39 *)Patch,
		          (Object *)this,
		          (Object *)volumeProfile,
		          0LL);
		        return;
		      }
		      goto LABEL_37;
		    }
		  }
		  v7 = (__int64 (__fastcall *)(VFXPPDirtyLens *, MonitorData *, MethodInfo *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v7 = (__int64 (__fastcall *)(VFXPPDirtyLens *, MonitorData *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                  "UnityEngine.Component::get_transform()");
		    if ( !v7 )
		    {
		      v24 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v24, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v7;
		  }
		  v8 = v7(this, v6, method);
		  monitor = TypeInfo::UnityEngine::Object;
		  v9 = v8;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    monitor = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      monitor = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v9 )
		  {
		    if ( !*((_DWORD *)monitor + 56) )
		      il2cpp_runtime_class_init_1(monitor);
		    if ( *(_QWORD *)(v9 + 16) )
		    {
		      if ( !volumeProfile )
		        goto LABEL_37;
		      v10 = MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGDirtyLens>;
		      if ( !MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGDirtyLens>->rgctx_data )
		        sub_1800430B0(MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGDirtyLens>);
		      v11.value = v10->rgctx_data->rgctxDataDummy;
		      if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		      TypeFromHandle = System::Type::GetTypeFromHandle(v11, 0LL);
		      if ( !UnityEngine::Rendering::VolumeProfile::Has(volumeProfile, TypeFromHandle, 0LL) )
		        UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		          volumeProfile,
		          0,
		          MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGDirtyLens>);
		      v13 = MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGDirtyLens>;
		      if ( !MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGDirtyLens>->rgctx_data )
		        sub_1800430B0(MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGDirtyLens>);
		      v14.value = v13->rgctx_data->rgctxDataDummy;
		      if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		      v15 = System::Type::GetTypeFromHandle(v14, 0LL);
		      v16.rgctxDataDummy = v13->rgctx_data[1].rgctxDataDummy;
		      if ( !*((_QWORD *)v16.rgctxDataDummy + 4) )
		        (*(void (**)(void))v16.rgctxDataDummy)();
		      if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		             volumeProfile,
		             v15,
		             &component,
		             (MethodInfo *)v13->rgctx_data[1].rgctxDataDummy) )
		      {
		        if ( component )
		        {
		          LOBYTE(component[1].monitor) = 1;
		          if ( component )
		          {
		            monitor = component[3].monitor;
		            if ( monitor )
		            {
		              *((_BYTE *)monitor + 16) = 1;
		              if ( component )
		              {
		                v6 = component[3].monitor;
		                if ( v6 )
		                {
		                  sub_180049310(11LL, v6);
		                  if ( component )
		                  {
		                    klass = component[3].klass;
		                    if ( klass )
		                    {
		                      LOBYTE(klass->_0.name) = 1;
		                      if ( component )
		                      {
		                        v18 = component[3].klass;
		                        dirtyTex = this->fields._dirtyTex;
		                        if ( v18 )
		                        {
		                          sub_1800049A0(v18->_0.image);
		                          v21 = *(Int32__Array ***)&v18->_0.image[6].token;
		                          name = (HGRuntimeGrassQuery_Node *)v18->_0.image[7].name;
		                          if ( v21 == (Int32__Array **)UnityEngine::Rendering::VolumeParameter<System::Object>::set_value )
		                          {
		                            v18->_0.namespaze = (const char *)dirtyTex;
		                            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v18->_0.namespaze, v20, name, v21, v25);
		                          }
		                          else
		                          {
		                            ((void (__fastcall *)(Object__Class *, Texture2D *, HGRuntimeGrassQuery_Node *))v21)(
		                              v18,
		                              dirtyTex,
		                              name);
		                          }
		                          return;
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_37:
		        sub_1800D8260(monitor, v6);
		      }
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000184B32DF0-0x0000000184B32F20
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPDirtyLens::ResetByVolumeProfile(
		        VFXPPDirtyLens *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  void *v6; // rdx
		  MonitorData *monitor; // rcx
		  Object__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2505, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2505, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_11;
		  }
		  v5 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( volumeProfile )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( volumeProfile->fields._._.m_CachedPtr
		      && UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGDirtyLens>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 0;
		        if ( component )
		        {
		          monitor = component[3].monitor;
		          if ( monitor )
		          {
		            *((_BYTE *)monitor + 16) = 0;
		            if ( component )
		            {
		              v6 = component[3].monitor;
		              if ( v6 )
		              {
		                sub_180049310(11LL, v6);
		                if ( component )
		                {
		                  klass = component[3].klass;
		                  if ( klass )
		                  {
		                    LOBYTE(klass->_0.name) = 0;
		                    if ( component )
		                    {
		                      v6 = component[3].klass;
		                      if ( v6 )
		                      {
		                        sub_18003BA30(monitor, v6, 0LL);
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_11:
		      sub_1800D8260(monitor, v6);
		    }
		  }
		}
		
		public override bool IsActive() => default; // 0x0000000183EE4370-0x0000000183EE43E0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPDirtyLens::IsActive(VFXPPDirtyLens *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
		  if ( wrapperArray->max_length.size <= 2506 )
		    return this->fields._intensity != 0.0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x9CA )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[53]._0.methods )
		    return this->fields._intensity != 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2506, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public VFXPPType __iFixBaseProxy_get_m_VFXPPType() => default; // 0x0000000189B5D900-0x0000000189B5D908
		// VFXPPType <>iFixBaseProxy_get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_get_m_VFXPPType(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_m_VFXPPType((VFXPPComponent *)this, 0LL);
		}
		
		public void __iFixBaseProxy_Apply(VolumeProfile P0) {} // 0x0000000189B5D8E8-0x0000000189B5D8F0
		// Void <>iFixBaseProxy_Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0) {} // 0x0000000189B5D8F8-0x0000000189B5D900
		// Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
		}
		
		public bool __iFixBaseProxy_IsActive() => default; // 0x0000000189B5D8F0-0x0000000189B5D8F8
		// Boolean <>iFixBaseProxy_IsActive()
		bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
		}
		
	}
}
