using System;

namespace HG.Rendering.Runtime
{
	public class HGSMAA
	{
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGSMAA instance
		{
			get
			{
				// // HGSMAA get_instance()
				// HGSMAA *HG::Rendering::Runtime::HGSMAA::get_instance(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   Lazy_1_HG_Rendering_Runtime_HGSMAA_ *s_instance; // rcx
				// 
				//   if ( !byte_18D919459 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSMAA);
				//     sub_18003C530(&MethodInfo::System::Lazy<HG::Rendering::Runtime::HGSMAA>::get_Value);
				//     byte_18D919459 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSMAA);
				//   s_instance = TypeInfo::HG::Rendering::Runtime::HGSMAA.static_fields.s_instance;
				//   if ( !s_instance )
				//     sub_180B536AC(0LL, v1);
				//   return (HGSMAA *)System::Lazy<System::Object>::get_Value(
				//                      (Lazy_1_Object_ *)s_instance,
				//                      MethodInfo::System::Lazy<HG::Rendering::Runtime::HGSMAA>::get_Value);
				// }
				// 
				return null;
			}
		}

		public HGSMAA()
		{
			// // HGSMAA()
			// void HG::Rendering::Runtime::HGSMAA::HGSMAA(HGSMAA *this, MethodInfo *method)
			// {
			//   this.fields.m_edgeMode = 1;
			//   this.fields.m_blendMode = 1;
			// }
			// 
		}

		public bool DoSMAA()
		{
			// // Boolean DoSMAA()
			// bool HG::Rendering::Runtime::HGSMAA::DoSMAA(HGSMAA *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2233, 0LL) )
			//     return this.fields.m_smaaMode != 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2233, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void SetSMAAMode(HGSMAAMode mode)
		{
			// // Void SetSMAAMode(HGSMAAMode)
			// void HG::Rendering::Runtime::HGSMAA::SetSMAAMode(HGSMAA *this, HGSMAAMode__Enum mode, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2234, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2234, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, mode, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_smaaMode = mode;
			//     this.fields.m_edgeMode = mode;
			//     this.fields.m_blendMode = mode;
			//   }
			// }
			// 
		}

		public int GetEdgeClearPass()
		{
			// // Int32 GetEdgeClearPass()
			// int32_t HG::Rendering::Runtime::HGSMAA::GetEdgeClearPass(HGSMAA *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2235, 0LL) )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2235, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public int GetEdgePass()
		{
			// // Int32 GetEdgePass()
			// int32_t HG::Rendering::Runtime::HGSMAA::GetEdgePass(HGSMAA *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2236, 0LL) )
			//     return this.fields.m_edgeMode;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2236, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public int GetBlendWeightsPass()
		{
			// // Int32 GetBlendWeightsPass()
			// int32_t HG::Rendering::Runtime::HGSMAA::GetBlendWeightsPass(HGSMAA *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2237, 0LL) )
			//     return this.fields.m_blendMode + 4;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2237, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public int GetNeighborBlendPass()
		{
			// // Int32 GetNeighborBlendPass()
			// int32_t HG::Rendering::Runtime::HGSMAA::GetNeighborBlendPass(HGSMAA *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2238, 0LL) )
			//     return 9;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2238, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public void SetEdgeMode(HGSMAAMode mode)
		{
			// // Void SetEdgeMode(HGSMAAMode)
			// void HG::Rendering::Runtime::HGSMAA::SetEdgeMode(HGSMAA *this, HGSMAAMode__Enum mode, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2239, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2239, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, mode, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_edgeMode = mode;
			//   }
			// }
			// 
		}

		public void SetBlendWeightsMode(HGSMAAMode mode)
		{
			// // Void SetBlendWeightsMode(HGSMAAMode)
			// void HG::Rendering::Runtime::HGSMAA::SetBlendWeightsMode(HGSMAA *this, HGSMAAMode__Enum mode, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2240, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2240, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, mode, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_blendMode = mode;
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Lazy<HGSMAA> s_instance;

		private HGSMAAMode m_smaaMode;

		private HGSMAAMode m_edgeMode;

		private HGSMAAMode m_blendMode;
	}
}
