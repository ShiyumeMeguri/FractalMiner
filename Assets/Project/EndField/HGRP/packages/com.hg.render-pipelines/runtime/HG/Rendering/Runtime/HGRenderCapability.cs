using System;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;

namespace HG.Rendering.Runtime
{
	public sealed class HGRenderCapability
	{
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00002BC0 File Offset: 0x00000DC0
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x000025D0 File Offset: 0x000007D0
		internal HGRenderPathInternal renderPath
		{
			[CompilerGenerated]
			get
			{
				// // MjfRFftkTcBeBOoxrCKsCyjeiVkX get_Current()
				// MjfRFftkTcBeBOoxrCKsCyjeiVkX Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<MjfRFftkTcBeBOoxrCKsCyjeiVkX>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_MjfRFftkTcBeBOoxrCKsCyjeiVkX_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return (HGRenderPathInternal)HGRenderPathInternal.Forward;
			}
			[CompilerGenerated]
			private set
			{
				// // UpdateLoopDataSet`1[T]+yGyjUqbndvpPzKlyNzUYInPtwsHF[System.Object](UpdateLoopType)
				// void Rewired::UpdateLoopDataSet_1_T_::yGyjUqbndvpPzKlyNzUYInPtwsHF<System::Object>::yGyjUqbndvpPzKlyNzUYInPtwsHF(
				//         UpdateLoopDataSet_1_T_yGyjUqbndvpPzKlyNzUYInPtwsHF_System_Object_ *this,
				//         UpdateLoopType__Enum param_0004ff5a,
				//         MethodInfo *method)
				// {
				//   this.fields.URsVCNeXtjuGuUuIdAEYavYwEgUe = param_0004ff5a;
				// }
				// 
			}
		}

		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool useGBufferDepth
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_useOverride()
				// bool HG::Rendering::Runtime::ScalableSettingValue<unsigned int>::get_useOverride(
				//         ScalableSettingValue_1_System_UInt32_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_UseOverride;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_useOverride(Boolean)
				// void HG::Rendering::Runtime::ScalableSettingValue<unsigned int>::set_useOverride(
				//         ScalableSettingValue_1_System_UInt32_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_UseOverride = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool isMobilePlatform
		{
			[CompilerGenerated]
			get
			{
				// // Byte get_Current()
				// uint8_t Unity::Collections::NativeParallelMultiHashMap_2_TKey_TValue_::Enumerator<int,unsigned char>::get_Current(
				//         NativeParallelMultiHashMap_2_TKey_TValue_Enumerator_System_Int32_System_Byte_ *this,
				//         MethodInfo *method)
				// {
				//   return this.value;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_parentEnabled(Boolean)
				// void Beyond::Input::InputBindingGroup::set_parentEnabled(InputBindingGroup *this, bool value, MethodInfo *method)
				// {
				//   this.fields._parentEnabled_k__BackingField = value;
				// }
				// 
			}
		}

		private HGRenderCapability()
		{
			// // HGRenderCapability()
			// void HG::Rendering::Runtime::HGRenderCapability::HGRenderCapability(HGRenderCapability *this, MethodInfo *method)
			// {
			//   this.fields._renderPath_k__BackingField = 0;
			//   *(_WORD *)&this.fields._useGBufferDepth_k__BackingField = 257;
			// }
			// 
		}

		public void Setup(HGRenderGraph renderGraph)
		{
			// // Void Setup(HGRenderGraph)
			// void HG::Rendering::Runtime::HGRenderCapability::Setup(
			//         HGRenderCapability *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGInitGraphicsAPIOptions *m_initGraphicsAPIOptions; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3516, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3516, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)renderGraph,
			//         0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !HG::Rendering::Runtime::HGInitGraphicsAPIUtils::LoadOptionsFromFile(&this.fields.m_initGraphicsAPIOptions, 0LL) )
			//   {
			// LABEL_3:
			//     this.fields._renderPath_k__BackingField = HG::Rendering::Runtime::HGRenderCapability::GetPlatformBestMatchRenderPath(
			//                                                  this,
			//                                                  0LL);
			//     this.fields._isMobilePlatform_k__BackingField = UnityEngine::Application::get_isMobilePlatform(0LL);
			//     this.fields._useGBufferDepth_k__BackingField = HG::Rendering::Runtime::HGRenderCapability::GetUseGBufferDepth(
			//                                                       this,
			//                                                       0LL);
			//     return;
			//   }
			//   m_initGraphicsAPIOptions = this.fields.m_initGraphicsAPIOptions;
			//   if ( !m_initGraphicsAPIOptions )
			//     goto LABEL_10;
			//   if ( m_initGraphicsAPIOptions.fields.m_preferredDeviceType == 4
			//     || !m_initGraphicsAPIOptions.fields.m_forceRenderPath )
			//   {
			//     goto LABEL_3;
			//   }
			//   this.fields._renderPath_k__BackingField = m_initGraphicsAPIOptions.fields.m_renderPath;
			//   this.fields._useGBufferDepth_k__BackingField = HG::Rendering::Runtime::HGRenderCapability::GetUseGBufferDepth(
			//                                                     this,
			//                                                     0LL);
			//   this.fields._isMobilePlatform_k__BackingField = UnityEngine::Application::get_isMobilePlatform(0LL);
			// }
			// 
		}

		internal bool IsOnePassDeferred(HGRenderPathInternal renderPath)
		{
			// // Boolean IsOnePassDeferred(HGRenderPathInternal)
			// bool HG::Rendering::Runtime::HGRenderCapability::IsOnePassDeferred(
			//         HGRenderCapability *this,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3520, 0LL) )
			//     return renderPath == HGRenderPathInternal__Enum_OnePassDeferredSubpass;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3520, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
			//            (ILFixDynamicMethodWrapper_13 *)Patch,
			//            (Object *)this,
			//            (NaviDirection__Enum)renderPath,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		private HGRenderPathInternal GetPlatformBestMatchRenderPath()
		{
			// // HGRenderPathInternal GetPlatformBestMatchRenderPath()
			// HGRenderPathInternal__Enum HG::Rendering::Runtime::HGRenderCapability::GetPlatformBestMatchRenderPath(
			//         HGRenderCapability *this,
			//         MethodInfo *method)
			// {
			//   GraphicsDeviceType__Enum GraphicsDeviceType; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3523, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3523, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
			//     if ( GraphicsDeviceType == GraphicsDeviceType__Enum_Vulkan || GraphicsDeviceType == GraphicsDeviceType__Enum_Metal )
			//       return UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
			//                BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
			//                0LL)
			//            + 3;
			//     else
			//       return 3;
			//   }
			// }
			// 
			return (HGRenderPathInternal)HGRenderPathInternal.Forward;
		}

		private bool GetUseGBufferDepth()
		{
			// // Boolean GetUseGBufferDepth()
			// bool HG::Rendering::Runtime::HGRenderCapability::GetUseGBufferDepth(HGRenderCapability *this, MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3518, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3518, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     result = HG::Rendering::Runtime::HGRenderCapability::IsOnePassDeferred(
			//                this,
			//                (HGRenderPathInternal__Enum)this.fields._renderPath_k__BackingField,
			//                0LL);
			//     if ( result )
			//       return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Metal;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public bool IsSupportedHardware()
		{
			// // Boolean IsSupportedHardware()
			// bool HG::Rendering::Runtime::HGRenderCapability::IsSupportedHardware(HGRenderCapability *this, MethodInfo *method)
			// {
			//   GraphicsDeviceType__Enum GraphicsDeviceType; // eax
			//   int v4; // ecx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3524, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3524, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
			//     result = (unsigned int)GraphicsDeviceType <= GraphicsDeviceType__Enum_PlayStation5NGGC
			//           && (v4 = 136513796, _bittest(&v4, GraphicsDeviceType))
			//           || GraphicsDeviceType == GraphicsDeviceType__Enum_PlayStation5;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public bool SupportNativeRenderPass()
		{
			// // Boolean SupportNativeRenderPass()
			// bool HG::Rendering::Runtime::HGRenderCapability::SupportNativeRenderPass(HGRenderCapability *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3525, 0LL) )
			//     return UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLES2
			//         && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLES3
			//         && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLCore
			//         && UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_Direct3D11;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3525, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<HGRenderCapability> s_Instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static HGRenderCapability instance;

		private HGInitGraphicsAPIOptions m_initGraphicsAPIOptions;
	}
}
