using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricPipelineRT // TypeDefIndex: 38763
	{
		// Fields
		private string Name; // 0x10
		private RenderTextureDescriptor Desc; // 0x18
		private RTLifeCycle lifeCycle; // 0x4C
		private bool bUsed; // 0x50
		private RenderTexture rt; // 0x58
	
		// Properties
		public bool WasFreshlyCreated { get; set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000184D88350-0x0000000184D88360
		// Boolean get_isPrediction()
		bool Unity::VisualScripting::Flow::get_isPrediction(Flow_1 *this, MethodInfo *method)
		{
		  return this->fields._isPrediction_k__BackingField;
		}
		

		// Void set_isPrediction(Boolean)
		void Unity::VisualScripting::Flow::set_isPrediction(Flow_1 *this, bool value, MethodInfo *method)
		{
		  this->fields._isPrediction_k__BackingField = value;
		}
		
		public RenderTexture RT { get => default; } // 0x0000000189C64EDC-0x0000000189C64F34 
		// RenderTexture get_RT()
		RenderTexture *HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(VolumetricPipelineRT *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5092, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5092, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_413(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(this, 0LL);
		    return this->fields.rt;
		  }
		}
		
	
		// Constructors
		public VolumetricPipelineRT() {} // Dummy constructor
		public VolumetricPipelineRT(string name, RTLifeCycle life) {} // 0x0000000189C64EB0-0x0000000189C64EDC
		// VolumetricPipelineRT(String, RTLifeCycle)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::VolumetricPipelineRT::VolumetricPipelineRT(
		        VolumetricPipelineRT *this,
		        String *name,
		        RTLifeCycle__Enum life,
		        MethodInfo *method)
		{
		  __int64 v4; // r9
		  int v5; // r10d
		  MethodInfo *v6; // [rsp+20h] [rbp-8h]
		
		  this->fields.lifeCycle = 2;
		  this->fields.Name = name;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields,
		    (HGRuntimeGrassQuery_Node *)name,
		    *(HGRuntimeGrassQuery_Node **)&life,
		    (Int32__Array **)this,
		    v6);
		  *(_DWORD *)(v4 + 76) = v5;
		  *(_BYTE *)(v4 + 80) = 0;
		}
		
	
		// Methods
		public void Create(int width, int height, RenderTextureFormat format, bool enableMipmap = false /* Metadata: 0x02304162 */) {} // 0x0000000189C64BBC-0x0000000189C64CE8
		// Void Create(Int32, Int32, RenderTextureFormat, Boolean)
		void HG::Rendering::Runtime::VolumetricPipelineRT::Create(
		        VolumetricPipelineRT *this,
		        int32_t width,
		        int32_t height,
		        RenderTextureFormat__Enum format,
		        bool enableMipmap,
		        MethodInfo *method)
		{
		  int32_t v10; // edx
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  RenderTextureDescriptor v16; // [rsp+40h] [rbp-40h] BYREF
		
		  memset(&v16, 0, sizeof(v16));
		  if ( !IFix::WrappersManagerImpl::IsPatched(5091, 0LL) )
		  {
		    UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(&v16, width, height, format, 0LL);
		    v16._dimension_k__BackingField = 2;
		    UnityEngine::RenderTextureDescriptor::set_colorFormat(&v16, format, 0LL);
		    v10 = 24;
		    if ( format != RenderTextureFormat__Enum_Depth )
		      v10 = 0;
		    UnityEngine::RenderTextureDescriptor::set_depthBufferBits(&v16, v10, 0LL);
		    v16._volumeDepth_k__BackingField = 1;
		    UnityEngine::RenderTextureDescriptor::set_useMipMap(&v16, enableMipmap, 0LL);
		    if ( this )
		    {
		      memoryless_k__BackingField = v16._memoryless_k__BackingField;
		      v14 = *(_OWORD *)&v16._mipCount_k__BackingField;
		      *(_OWORD *)&this->fields.Desc._width_k__BackingField = *(_OWORD *)&v16._width_k__BackingField;
		      v15 = *(_OWORD *)&v16._dimension_k__BackingField;
		      *(_OWORD *)&this->fields.Desc._mipCount_k__BackingField = v14;
		      *(_OWORD *)&this->fields.Desc._dimension_k__BackingField = v15;
		      this->fields.Desc._memoryless_k__BackingField = memoryless_k__BackingField;
		      this->fields.bUsed = 0;
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(Patch, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5091, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1482(Patch, (Object *)this, width, height, format, enableMipmap, 0LL);
		}
		
		public void Release(bool full) {} // 0x0000000189C64D38-0x0000000189C64E28
		// Void Release(Boolean)
		void HG::Rendering::Runtime::VolumetricPipelineRT::Release(VolumetricPipelineRT *this, bool full, MethodInfo *method)
		{
		  BOOL v3; // edi
		  int v5; // eax
		  __int64 v6; // rax
		  NotImplementedException *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  NotImplementedException *v10; // rbx
		  __int64 v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = full;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3459, 0LL) )
		  {
		    v5 = v3;
		    if ( this->fields.lifeCycle != 2 )
		      v5 = 1;
		    if ( !v5 && this->fields.bUsed )
		      goto LABEL_12;
		    if ( !this->fields.lifeCycle )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseTemporaryTexture(&this->fields.rt, 0LL);
		      goto LABEL_12;
		    }
		    if ( this->fields.lifeCycle != 1 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseRenderTexture(&this->fields.rt, 0LL);
		LABEL_12:
		      this->fields.bUsed = 0;
		      return;
		    }
		    v6 = sub_18007E180(&TypeInfo::System::NotImplementedException);
		    v7 = (NotImplementedException *)sub_1800368D0(v6);
		    v10 = v7;
		    if ( v7 )
		    {
		      System::NotImplementedException::NotImplementedException(v7, 0LL);
		      v11 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricPipelineRT::Release);
		      sub_18007E190(v10, v11);
		    }
		LABEL_14:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3459, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, v3, 0LL);
		}
		
		private void CreateIfNeeded() {} // 0x0000000189C649F4-0x0000000189C64BBC
		// Void CreateIfNeeded()
		void HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(VolumetricPipelineRT *this, MethodInfo *method)
		{
		  int32_t memoryless_k__BackingField; // ebx
		  __int64 v4; // rdx
		  RenderTexture *rt; // rbx
		  __int64 v6; // rax
		  NotImplementedException *v7; // rax
		  Texture *v8; // rcx
		  NotImplementedException *v9; // rbx
		  __int64 v10; // rax
		  int32_t v11; // ebx
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v16; // [rsp+20h] [rbp-78h]
		  __int128 v17; // [rsp+20h] [rbp-78h]
		  __int128 v18; // [rsp+30h] [rbp-68h]
		  __int128 v19; // [rsp+30h] [rbp-68h]
		  __int128 v20; // [rsp+40h] [rbp-58h]
		  __int128 v21; // [rsp+40h] [rbp-58h]
		  RenderTextureDescriptor v22; // [rsp+50h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5093, 0LL) )
		  {
		    if ( this->fields.bUsed )
		      return;
		    if ( this->fields.lifeCycle )
		    {
		      if ( this->fields.lifeCycle == 1 )
		      {
		        v6 = sub_18007E180(&TypeInfo::System::NotImplementedException);
		        v7 = (NotImplementedException *)sub_18002C620(v6);
		        v9 = v7;
		        if ( v7 )
		        {
		          System::NotImplementedException::NotImplementedException(v7, 0LL);
		          v10 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded);
		          sub_18007E190(v9, v10);
		        }
		        goto LABEL_13;
		      }
		      memoryless_k__BackingField = this->fields.Desc._memoryless_k__BackingField;
		      v16 = *(_OWORD *)&this->fields.Desc._width_k__BackingField;
		      v18 = *(_OWORD *)&this->fields.Desc._mipCount_k__BackingField;
		      v20 = *(_OWORD *)&this->fields.Desc._dimension_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v22._memoryless_k__BackingField = memoryless_k__BackingField;
		      *(_OWORD *)&v22._width_k__BackingField = v16;
		      *(_OWORD *)&v22._mipCount_k__BackingField = v18;
		      *(_OWORD *)&v22._dimension_k__BackingField = v20;
		      if ( HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded(&this->fields.rt, &v22, 0LL) )
		      {
		        rt = this->fields.rt;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        HG::Rendering::Runtime::VolumetricSDFUtils::ClearRenderTarget(rt, 0LL);
		        this->fields._WasFreshlyCreated_k__BackingField = 1;
		      }
		    }
		    else
		    {
		      v11 = this->fields.Desc._memoryless_k__BackingField;
		      v21 = *(_OWORD *)&this->fields.Desc._width_k__BackingField;
		      v19 = *(_OWORD *)&this->fields.Desc._mipCount_k__BackingField;
		      v17 = *(_OWORD *)&this->fields.Desc._dimension_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v22._memoryless_k__BackingField = v11;
		      *(_OWORD *)&v22._width_k__BackingField = v21;
		      *(_OWORD *)&v22._mipCount_k__BackingField = v19;
		      *(_OWORD *)&v22._dimension_k__BackingField = v17;
		      this->fields.rt = HG::Rendering::Runtime::VolumetricSDFUtils::GetTemporaryTexture(&v22, 0LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.rt, v12, v13, v14, (MethodInfo *)v17);
		    }
		    v8 = (Texture *)this->fields.rt;
		    if ( v8 )
		    {
		      UnityEngine::Texture::set_filterMode(v8, FilterMode__Enum_Bilinear, 0LL);
		      this->fields.bUsed = 1;
		      return;
		    }
		LABEL_13:
		    sub_1800D8260(v8, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5093, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void MarkUsed() {} // 0x0000000189C64CE8-0x0000000189C64D38
		// Void MarkUsed()
		void HG::Rendering::Runtime::VolumetricPipelineRT::MarkUsed(VolumetricPipelineRT *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5311, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5311, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.bUsed = 1;
		  }
		}
		
		public bool ConsumeFreshlyCreated() => default; // 0x0000000189C6499C-0x0000000189C649F4
		// Boolean ConsumeFreshlyCreated()
		bool HG::Rendering::Runtime::VolumetricPipelineRT::ConsumeFreshlyCreated(
		        VolumetricPipelineRT *this,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5099, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5099, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(this, 0LL);
		    result = this->fields._WasFreshlyCreated_k__BackingField;
		    this->fields._WasFreshlyCreated_k__BackingField = 0;
		  }
		  return result;
		}
		
		public override string ToString() => default; // 0x0000000189C64E28-0x0000000189C64EB0
		// String ToString()
		String *HG::Rendering::Runtime::VolumetricPipelineRT::ToString(VolumetricPipelineRT *this, MethodInfo *method)
		{
		  Object *Name; // rbx
		  Object *v4; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  bool bUsed; // [rsp+50h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5312, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5312, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Name = (Object *)this->fields.Name;
		    bUsed = this->fields.bUsed;
		    v4 = (Object *)il2cpp_value_box_0(TypeInfo::System::Boolean, &bUsed);
		    return System::String::Format((String *)"Name:{0}, Used:{1}, rt:{2}", Name, v4, (Object *)this->fields.rt, 0LL);
		  }
		}
		
		public string __iFixBaseProxy_ToString() => default; // 0x000000018669AD6C-0x000000018669AD74
		// String ObjectToString()
		String *IFix::Core::AnonymousStorey::ObjectToString(AnonymousStorey *this, MethodInfo *method)
		{
		  return System::Object::ToString((Object *)this, 0LL);
		}
		
	}
}
