using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/Other Settings", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class OtherSettings : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38055
	{
		// Fields
		public BoolParameter enable; // 0x30
		public BoolParameter fakePlanarReflection; // 0x38
		public BoolParameter fakePlanarDisableCharacterOutline; // 0x40
		public Vector3Parameter fakeReflectionProbeNormal; // 0x48
		public Vector3Parameter fakeReflectionPos; // 0x50
		public FloatParameter fakePlanarReflectionBlur; // 0x58
	
		// Constructors
		public OtherSettings() {} // 0x00000001844160C0-0x0000000184416260
		// OtherSettings()
		void HG::Rendering::Runtime::OtherSettings::OtherSettings(OtherSettings *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  BoolParameter *v8; // rax
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  BoolParameter *v11; // rax
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rdi
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rdi
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  MethodInfo *v23; // [rsp+20h] [rbp-18h]
		  MethodInfo *v24; // [rsp+20h] [rbp-18h]
		  MethodInfo *v25; // [rsp+20h] [rbp-18h]
		  MethodInfo *v26; // [rsp+20h] [rbp-18h]
		  MethodInfo *v27; // [rsp+20h] [rbp-18h]
		  MethodInfo *v28; // [rsp+20h] [rbp-18h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_12;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enable = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enable, v4, v6, v7, v23);
		  v8 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v8 )
		    goto LABEL_12;
		  v8->fields._.m_Value = 0;
		  v8->fields._._.overrideState = 0;
		  this->fields.fakePlanarReflection = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fakePlanarReflection, v4, v9, v10, v24);
		  v11 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v11 )
		    goto LABEL_12;
		  v11->fields._.m_Value = 0;
		  v11->fields._._.overrideState = 0;
		  this->fields.fakePlanarDisableCharacterOutline = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fakePlanarDisableCharacterOutline, v4, v12, v13, v25);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector3Parameter);
		  if ( !v14 )
		    goto LABEL_12;
		  if ( !byte_18F36E4F5 )
		  {
		    sub_180035ED0(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector3>::VolumeParameter);
		    byte_18F36E4F5 = 1;
		  }
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_QWORD *)(v14 + 24) = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  *(_DWORD *)(v14 + 32) = 0;
		  this->fields.fakeReflectionProbeNormal = (Vector3Parameter *)v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fakeReflectionProbeNormal, v4, v15, v16, v26);
		  v17 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector3Parameter);
		  if ( !v17 )
		    goto LABEL_12;
		  if ( !byte_18F36E4F5 )
		  {
		    sub_180035ED0(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector3>::VolumeParameter);
		    byte_18F36E4F5 = 1;
		  }
		  *(_BYTE *)(v17 + 16) = 0;
		  *(_QWORD *)(v17 + 24) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v17 + 32) = 0;
		  this->fields.fakeReflectionPos = (Vector3Parameter *)v17;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fakeReflectionPos, v4, v18, v19, v27);
		  v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v20 )
		LABEL_12:
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v20 + 24) = 1065353216;
		  *(_BYTE *)(v20 + 16) = 0;
		  this->fields.fakePlanarReflectionBlur = (FloatParameter *)v20;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fakePlanarReflectionBlur, v4, v21, v22, v28);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x00000001839741A0-0x00000001839742C0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::OtherSettings::IsActive(OtherSettings *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  BoolParameter *enable; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rcx
		  __int64 v12; // rax
		  VolumeParameter__Fields v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_24;
		  if ( wrapperArray->max_length.size <= 1097 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_24;
		  if ( LODWORD(v3->_0.namespaze) <= 0x449 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[23]._0.nestedTypes )
		  {
		LABEL_5:
		    enable = this->fields.enable;
		    if ( enable )
		    {
		      sub_1800049A0(enable->klass);
		      v6 = (bool (*)(RuntimeType *, MethodInfo *))enable->klass->vtable.get_value.method;
		      methodPtr = enable->klass->vtable.set_value.methodPtr;
		      if ( v6 == System::RuntimeType::HasElementTypeImpl )
		      {
		        v9 = enable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v9 + 8LL) & 0x20000000) == 0 )
		        {
		          v10 = *(_BYTE *)(*(_QWORD *)&v9 + 10LL);
		          if ( v10 != 29 && v10 != 16 && v10 != 20 && v10 != 15 )
		            return 0;
		        }
		      }
		      else
		      {
		        if ( v6 != System::RuntimeType::get_IsGenericType )
		        {
		          if ( v6 != System::RuntimeType::get_IsGenericParameter )
		            return ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(enable, methodPtr);
		          v13 = enable->fields._._;
		          return (*(_DWORD *)(*(_QWORD *)&v13 + 8LL) & 0x20000000) == 0
		              && (*(_BYTE *)(*(_QWORD *)&v13 + 10LL) == 19 || *(_BYTE *)(*(_QWORD *)&v13 + 10LL) == 30);
		        }
		        v11 = enable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v11 + 8LL) & 0x20000000) != 0 )
		          return 0;
		        LOBYTE(methodPtr) = 1;
		        v12 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_180028750)(v11, methodPtr);
		        if ( (*(_BYTE *)(v12 + 312) & 0x10) == 0 && !*(_QWORD *)(v12 + 96) )
		          return 0;
		      }
		      return 1;
		    }
		LABEL_24:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1097, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
