using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/ScreenSpaceReflection", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class ScreenSpaceReflectionVolume : VolumeComponent // TypeDefIndex: 38060
	{
		// Fields
		public BoolParameter enable; // 0x30
		public ClampedFloatParameter fadenessOnScreen; // 0x38
		public FloatParameter fadenessOnDepth; // 0x40
		public ClampedFloatParameter fadenessOnDepthFactor; // 0x48
		public FloatParameter fadenessOnMirrorMul; // 0x50
		public FloatParameter fadenessOnMirrorAdd; // 0x58
		public ClampedFloatParameter mipThreshold; // 0x60
	
		// Constructors
		public ScreenSpaceReflectionVolume() {} // 0x00000001845D07D0-0x00000001845D0960
		// ScreenSpaceReflectionVolume()
		void HG::Rendering::Runtime::ScreenSpaceReflectionVolume::ScreenSpaceReflectionVolume(
		        ScreenSpaceReflectionVolume *this,
		        MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rax
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  __int64 v23; // rax
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+20h] [rbp-8h]
		  MethodInfo *v30; // [rsp+20h] [rbp-8h]
		  MethodInfo *v31; // [rsp+20h] [rbp-8h]
		  MethodInfo *v32; // [rsp+20h] [rbp-8h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_9;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enable = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enable, v4, v6, v7, v26);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_9;
		  *(_DWORD *)(v8 + 24) = 1036831949;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1065353216;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.fadenessOnScreen = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fadenessOnScreen, v4, v9, v10, v27);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v11 )
		    goto LABEL_9;
		  *(_DWORD *)(v11 + 24) = 1112014848;
		  *(_BYTE *)(v11 + 16) = 0;
		  this->fields.fadenessOnDepth = (FloatParameter *)v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fadenessOnDepth, v4, v12, v13, v28);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_9;
		  *(_DWORD *)(v14 + 24) = 1036831949;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 0;
		  *(_DWORD *)(v14 + 36) = 1065353216;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.fadenessOnDepthFactor = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fadenessOnDepthFactor, v4, v15, v16, v29);
		  v17 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v17 )
		    goto LABEL_9;
		  *(_DWORD *)(v17 + 24) = 0x40000000;
		  *(_BYTE *)(v17 + 16) = 0;
		  this->fields.fadenessOnMirrorMul = (FloatParameter *)v17;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fadenessOnMirrorMul, v4, v18, v19, v30);
		  v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v20
		    || (*(_DWORD *)(v20 + 24) = -1082130432,
		        *(_BYTE *)(v20 + 16) = 0,
		        this->fields.fadenessOnMirrorAdd = (FloatParameter *)v20,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fadenessOnMirrorAdd, v4, v21, v22, v31),
		        (v23 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v23 + 24) = 0;
		  *(_BYTE *)(v23 + 16) = 0;
		  *(_DWORD *)(v23 + 32) = -1082130432;
		  *(_DWORD *)(v23 + 36) = 1065353216;
		  *(_DWORD *)(v23 + 40) = 1065353216;
		  this->fields.mipThreshold = (ClampedFloatParameter *)v23;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mipThreshold, v4, v24, v25, v32);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x00000001831CBA40-0x00000001831CBB50
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ScreenSpaceReflectionVolume::IsActive(
		        ScreenSpaceReflectionVolume *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  BoolParameter *enable; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_21;
		  if ( wrapperArray->max_length.size <= 950 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_21;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3B6 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[20]._0.interopData )
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
		        if ( (*(_DWORD *)(*(_QWORD *)&v9 + 8LL) & 0x20000000) != 0 )
		          return 1;
		        v10 = *(_BYTE *)(*(_QWORD *)&v9 + 10LL);
		        if ( v10 == 29 || v10 == 16 || v10 == 20 || v10 == 15 )
		          return 1;
		      }
		      else
		      {
		        if ( v6 == System::RuntimeType::get_IsGenericType )
		          return System::RuntimeTypeHandle::HasInstantiation(enable, methodPtr);
		        if ( v6 != System::RuntimeType::get_IsGenericParameter )
		          return ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(enable, methodPtr);
		        v11 = enable->fields._._;
		        if ( (*(_DWORD *)(*(_QWORD *)&v11 + 8LL) & 0x20000000) == 0
		          && (*(_BYTE *)(*(_QWORD *)&v11 + 10LL) == 19 || *(_BYTE *)(*(_QWORD *)&v11 + 10LL) == 30) )
		        {
		          return 1;
		        }
		      }
		      return 0;
		    }
		LABEL_21:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(950, 0LL);
		  if ( !Patch )
		    goto LABEL_21;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
