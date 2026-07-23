using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public sealed class HGRenderCapability // TypeDefIndex: 38695
	{
		// Fields
		private static readonly Lazy<HGRenderCapability> s_Instance; // 0x00
		public static HGRenderCapability instance; // 0x08
		private HGInitGraphicsAPIOptions m_initGraphicsAPIOptions; // 0x18
	
		// Properties
		internal HGRenderPathInternal renderPath { get; private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		// MjfRFftkTcBeBOoxrCKsCyjeiVkX get_Current()
		MjfRFftkTcBeBOoxrCKsCyjeiVkX Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<MjfRFftkTcBeBOoxrCKsCyjeiVkX>::get_Current(
		        RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_MjfRFftkTcBeBOoxrCKsCyjeiVkX_ *this,
		        MethodInfo *method)
		{
		  return this->current;
		}
		

		// UpdateLoopDataSet`1[T]+yGyjUqbndvpPzKlyNzUYInPtwsHF[System.Object](UpdateLoopType)
		void Rewired::UpdateLoopDataSet_1_T_::yGyjUqbndvpPzKlyNzUYInPtwsHF<System::Object>::yGyjUqbndvpPzKlyNzUYInPtwsHF(
		        UpdateLoopDataSet_1_T_yGyjUqbndvpPzKlyNzUYInPtwsHF_System_Object_ *this,
		        UpdateLoopType__Enum param_000585ac,
		        MethodInfo *method)
		{
		  this->fields.URsVCNeXtjuGuUuIdAEYavYwEgUe = param_000585ac;
		}
		
		public bool useGBufferDepth { get; private set; } // 0x0000000184D8EE50-0x0000000184D8EE60 0x0000000184D8EE70-0x0000000184D8EE80
		// Boolean get_useOverride()
		bool HG::Rendering::Runtime::ScalableSettingValue<unsigned int>::get_useOverride(
		        ScalableSettingValue_1_System_UInt32_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_UseOverride;
		}
		

		// Void set_useOverride(Boolean)
		void HG::Rendering::Runtime::ScalableSettingValue<unsigned int>::set_useOverride(
		        ScalableSettingValue_1_System_UInt32_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields.m_UseOverride = value;
		}
		
		public bool isMobilePlatform { get; private set; } // 0x0000000184D8EE60-0x0000000184D8EE70 0x0000000184D8EE80-0x0000000184D8EE90
		// Byte get_Current()
		uint8_t Unity::Collections::NativeParallelMultiHashMap_2_TKey_TValue_::Enumerator<int,unsigned char>::get_Current(
		        NativeParallelMultiHashMap_2_TKey_TValue_Enumerator_System_Int32_System_Byte_ *this,
		        MethodInfo *method)
		{
		  return this->value;
		}
		

		// Void set_parentEnabled(Boolean)
		void Beyond::Input::InputBindingGroup::set_parentEnabled(InputBindingGroup *this, bool value, MethodInfo *method)
		{
		  this->fields._parentEnabled_k__BackingField = value;
		}
		
	
		// Constructors
		private HGRenderCapability() {} // 0x0000000184DA1DF0-0x0000000184DA1E00
		// HGRenderCapability()
		void HG::Rendering::Runtime::HGRenderCapability::HGRenderCapability(HGRenderCapability *this, MethodInfo *method)
		{
		  this->fields._renderPath_k__BackingField = 0;
		  *(_WORD *)&this->fields._useGBufferDepth_k__BackingField = 257;
		}
		
		static HGRenderCapability() {} // 0x0000000184CA92C0-0x0000000184CA93D0
		// HGRenderCapability()
		void HG::Rendering::Runtime::HGRenderCapability::cctor(MethodInfo *method)
		{
		  struct HGRenderCapability_c__Class *v1; // rax
		  Object *v2; // rdi
		  Func_1_Object_ *v3; // rax
		  __int64 v4; // rdx
		  Lazy_1_HG_Rendering_Runtime_HGRenderCapability_ *s_Instance; // rcx
		  Func_1_Object_ *v6; // rbx
		  Lazy_1_Object_ *v7; // rax
		  Type__Class *v8; // rdi
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  Object *Value; // rax
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGRenderCapability::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderCapability::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderCapability::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGRenderCapability::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (Func_1_Object_ *)sub_1800368D0(TypeInfo::System::Func<HG::Rendering::Runtime::HGRenderCapability>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_4;
		  System::Func<System::Object>::Func(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::HGRenderCapability::__c::__cctor_b__22_0,
		    0LL);
		  v7 = (Lazy_1_Object_ *)sub_1800368D0(TypeInfo::System::Lazy<HG::Rendering::Runtime::HGRenderCapability>);
		  v8 = (Type__Class *)v7;
		  if ( !v7
		    || (System::Lazy<System::Object>::Lazy(
		          v7,
		          v6,
		          MethodInfo::System::Lazy<HG::Rendering::Runtime::HGRenderCapability>::Lazy),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGRenderCapability->static_fields,
		        static_fields->klass = v8,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGRenderCapability->static_fields,
		          static_fields,
		          v10,
		          v11,
		          v16),
		        (s_Instance = TypeInfo::HG::Rendering::Runtime::HGRenderCapability->static_fields->s_Instance) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(s_Instance, v4);
		  }
		  Value = System::Lazy<System::Object>::get_Value(
		            (Lazy_1_Object_ *)s_Instance,
		            MethodInfo::System::Lazy<HG::Rendering::Runtime::HGRenderCapability>::get_Value);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGRenderCapability->static_fields;
		  v13->monitor = (MonitorData *)Value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGRenderCapability->static_fields->instance,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		public void Setup(HGRenderGraph renderGraph) {} // 0x000000018366DC00-0x000000018366DC70
		// Void Setup(HGRenderGraph)
		void HG::Rendering::Runtime::HGRenderCapability::Setup(
		        HGRenderCapability *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGInitGraphicsAPIOptions *m_initGraphicsAPIOptions; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4169, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4169, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)renderGraph,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !HG::Rendering::Runtime::HGInitGraphicsAPIUtils::LoadOptionsFromFile(&this->fields.m_initGraphicsAPIOptions, 0LL) )
		  {
		LABEL_3:
		    this->fields._renderPath_k__BackingField = HG::Rendering::Runtime::HGRenderCapability::GetPlatformBestMatchRenderPath(
		                                                 this,
		                                                 0LL);
		    this->fields._isMobilePlatform_k__BackingField = UnityEngine::Application::get_isMobilePlatform(0LL);
		    this->fields._useGBufferDepth_k__BackingField = HG::Rendering::Runtime::HGRenderCapability::GetUseGBufferDepth(
		                                                      this,
		                                                      0LL);
		    return;
		  }
		  m_initGraphicsAPIOptions = this->fields.m_initGraphicsAPIOptions;
		  if ( !m_initGraphicsAPIOptions )
		    goto LABEL_10;
		  if ( m_initGraphicsAPIOptions->fields.m_preferredDeviceType == 4
		    || !m_initGraphicsAPIOptions->fields.m_forceRenderPath )
		  {
		    goto LABEL_3;
		  }
		  this->fields._renderPath_k__BackingField = m_initGraphicsAPIOptions->fields.m_renderPath;
		  this->fields._useGBufferDepth_k__BackingField = HG::Rendering::Runtime::HGRenderCapability::GetUseGBufferDepth(
		                                                    this,
		                                                    0LL);
		  this->fields._isMobilePlatform_k__BackingField = UnityEngine::Application::get_isMobilePlatform(0LL);
		}
		
		internal bool IsOnePassDeferred(HGRenderPathInternal renderPath) => default; // 0x000000018366DD30-0x000000018366DD70
		// Boolean IsOnePassDeferred(HGRenderPathInternal)
		bool HG::Rendering::Runtime::HGRenderCapability::IsOnePassDeferred(
		        HGRenderCapability *this,
		        HGRenderPathInternal__Enum renderPath,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4173, 0LL) )
		    return renderPath == HGRenderPathInternal__Enum_OnePassDeferredSubpass;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4173, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		           (ILFixDynamicMethodWrapper_13 *)Patch,
		           (Object *)this,
		           (NaviDirection__Enum)renderPath,
		           0LL);
		}
		
		private HGRenderPathInternal GetPlatformBestMatchRenderPath() => default; // 0x000000018366DC70-0x000000018366DCC0
		// HGRenderPathInternal GetPlatformBestMatchRenderPath()
		HGRenderPathInternal__Enum HG::Rendering::Runtime::HGRenderCapability::GetPlatformBestMatchRenderPath(
		        HGRenderCapability *this,
		        MethodInfo *method)
		{
		  GraphicsDeviceType__Enum GraphicsDeviceType; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4176, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4176, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
		    if ( GraphicsDeviceType == GraphicsDeviceType__Enum_Vulkan || GraphicsDeviceType == GraphicsDeviceType__Enum_Metal )
		      return UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
		               BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
		               0LL)
		           + 3;
		    else
		      return 3;
		  }
		}
		
		private bool GetUseGBufferDepth() => default; // 0x000000018366DCF0-0x000000018366DD30
		// Boolean GetUseGBufferDepth()
		bool HG::Rendering::Runtime::HGRenderCapability::GetUseGBufferDepth(HGRenderCapability *this, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4171, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4171, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    result = HG::Rendering::Runtime::HGRenderCapability::IsOnePassDeferred(
		               this,
		               (HGRenderPathInternal__Enum)this->fields._renderPath_k__BackingField,
		               0LL);
		    if ( result )
		      return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Metal;
		  }
		  return result;
		}
		
		public bool IsSupportedHardware() => default; // 0x0000000183948D40-0x0000000183948D90
		// Boolean IsSupportedHardware()
		bool HG::Rendering::Runtime::HGRenderCapability::IsSupportedHardware(HGRenderCapability *this, MethodInfo *method)
		{
		  GraphicsDeviceType__Enum GraphicsDeviceType; // eax
		  int v4; // ecx
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4177, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4177, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
		    result = (unsigned int)GraphicsDeviceType <= GraphicsDeviceType__Enum_PlayStation5NGGC
		          && (v4 = 136513796, _bittest(&v4, GraphicsDeviceType))
		          || GraphicsDeviceType == GraphicsDeviceType__Enum_PlayStation5;
		  }
		  return result;
		}
		
		public bool SupportNativeRenderPass() => default; // 0x0000000182EDA880-0x0000000182EDA8E0
		// Boolean SupportNativeRenderPass()
		bool HG::Rendering::Runtime::HGRenderCapability::SupportNativeRenderPass(HGRenderCapability *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4178, 0LL) )
		    return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLES2
		        && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLES3
		        && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLCore
		        && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_Direct3D11;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4178, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
