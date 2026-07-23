using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Texture ({handle.index})")]
	public struct TextureHandle // TypeDefIndex: 37468
	{
		// Fields
		private static TextureHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
		internal ResourceHandle fallBackResource; // 0x08
	
		// Properties
		public static TextureHandle nullHandle { get => default; } // 0x0000000182EDBDD0-0x0000000182EDBE30 
		// TextureHandle get_nullHandle()
		TextureHandle *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		        TextureHandle *__return_ptr retstr,
		        MethodInfo *method)
		{
		  struct TextureHandle__Class *v3; // rax
		  TextureHandle s_NullHandle; // xmm0
		  TextureHandle *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle v9; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(275, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(275, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    s_NullHandle = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_132(&v9, Patch, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle;
		    if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v3 = TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle;
		    }
		    s_NullHandle = v3->static_fields->s_NullHandle;
		  }
		  result = retstr;
		  *retstr = s_NullHandle;
		  return result;
		}
		
	
		// Constructors
		internal TextureHandle(int handle, bool shared = false /* Metadata: 0x02302D92 */) : this() {
			this.handle = default;
			fallBackResource = default;
		} // 0x0000000189B41AA0-0x0000000189B41AF4
		// TextureHandle(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(
		        TextureHandle *this,
		        int32_t handle,
		        bool shared,
		        MethodInfo *method)
		{
		  ResourceHandle v5; // [rsp+40h] [rbp+8h] BYREF
		
		  v5 = 0LL;
		  HG::Rendering::RenderGraphModule::ResourceHandle::ResourceHandle(
		    &v5,
		    handle,
		    HGRenderGraphResourceType__Enum_Texture,
		    shared,
		    0LL);
		  this->handle = v5;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fallBackResource = TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->static_fields->s_NullHandle.handle;
		}
		
		static TextureHandle() {
			s_NullHandle = default;
		} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		[IDTag(0)]
		public static implicit operator RenderTargetIdentifier(TextureHandle texture) => default; // 0x0000000189B41B80-0x0000000189B41C5C
		// RenderTargetIdentifier op_Implicit(TextureHandle)
		RenderTargetIdentifier *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		        RenderTargetIdentifier *__return_ptr retstr,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *current; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  RTHandle *v8; // rax
		  RenderTargetIdentifier *v9; // rax
		  __int64 v10; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v12; // xmm1
		  TextureHandle v14; // [rsp+20h] [rbp-48h] BYREF
		  RenderTargetIdentifier v15; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(320, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(320, 0LL);
		    if ( Patch )
		    {
		      v14 = *texture;
		      v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(&v15, Patch, &v14, 0LL);
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(v7, v6);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
		  {
		    current = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(0LL);
		    if ( current )
		    {
		      v8 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(current, texture, 0LL);
		      v9 = UnityEngine::Rendering::RTHandle::op_Implicit(&v15, v8, 0LL);
		LABEL_9:
		      v12 = *(_OWORD *)&v9->m_BufferPointer;
		      *(_OWORD *)&retstr->m_Type = *(_OWORD *)&v9->m_Type;
		      v10 = *(_QWORD *)&v9->m_DepthSlice;
		      *(_OWORD *)&retstr->m_BufferPointer = v12;
		      goto LABEL_10;
		    }
		    goto LABEL_7;
		  }
		  *(_OWORD *)&retstr->m_Type = 0LL;
		  *(_QWORD *)&v15.m_DepthSlice = 0LL;
		  *(_OWORD *)&retstr->m_BufferPointer = 0LL;
		  v10 = *(_QWORD *)&v15.m_DepthSlice;
		LABEL_10:
		  *(_QWORD *)&retstr->m_DepthSlice = v10;
		  return retstr;
		}
		
		[IDTag(1)]
		public static implicit operator Texture(TextureHandle texture) => default; // 0x0000000189B41CF8-0x0000000189B41D98
		// Texture op_Implicit(TextureHandle)
		Texture *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(TextureHandle *texture, MethodInfo *method)
		{
		  RTHandle *v3; // rbx
		  HGRenderGraphResourceRegistry *current; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(321, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
		      return UnityEngine::Rendering::RTHandle::op_Implicit(v3, 0LL);
		    current = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(0LL);
		    if ( current )
		    {
		      v3 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(current, texture, 0LL);
		      return UnityEngine::Rendering::RTHandle::op_Implicit(v3, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(321, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  v9 = *texture;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_150(Patch, &v9, 0LL);
		}
		
		[IDTag(2)]
		public static implicit operator RenderTexture(TextureHandle texture) => default; // 0x0000000189B41C5C-0x0000000189B41CF8
		// RenderTexture op_Implicit(TextureHandle)
		RenderTexture *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(TextureHandle *texture, MethodInfo *method)
		{
		  RenderTexture *v3; // rbx
		  HGRenderGraphResourceRegistry *current; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  RTHandle *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(322, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
		      return v3;
		    current = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(0LL);
		    if ( current )
		    {
		      v7 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(current, texture, 0LL);
		      if ( v7 )
		        return v7->fields.m_RT;
		      return v3;
		    }
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(322, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  v10 = *texture;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_151(Patch, &v10, 0LL);
		}
		
		[IDTag(3)]
		public static implicit operator RTHandle(TextureHandle texture) => default; // 0x0000000189B41AF4-0x0000000189B41B80
		// RTHandle op_Implicit(TextureHandle)
		RTHandle *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(TextureHandle *texture, MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *current; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(323, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(323, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    v8 = *texture;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_152(Patch, &v8, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
		    {
		      current = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(0LL);
		      if ( current )
		        return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(current, texture, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return 0LL;
		  }
		}
		
		[IsReadOnly]
		public bool IsValid() => default; // 0x0000000189B419D8-0x0000000189B41A38
		// Boolean IsValid()
		bool HG::Rendering::RenderGraphModule::TextureHandle::IsValid(TextureHandle *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(152, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(152, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_73(Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    return HG::Rendering::RenderGraphModule::ResourceHandle::IsValid(&this->handle, 0LL);
		  }
		}
		
		public void SetFallBackResource(TextureHandle texture) {} // 0x0000000189B41A38-0x0000000189B41AA0
		// Void SetFallBackResource(TextureHandle)
		void HG::Rendering::RenderGraphModule::TextureHandle::SetFallBackResource(
		        TextureHandle *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(324, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(324, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = *texture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_153(Patch, this, &v8, 0LL);
		  }
		  else
		  {
		    this->fallBackResource = texture->handle;
		  }
		}
		
	}
}
