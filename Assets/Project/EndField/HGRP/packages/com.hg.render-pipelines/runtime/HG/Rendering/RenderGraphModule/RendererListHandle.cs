using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RendererList ({handle})")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	public struct RendererListHandle
	{
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000025D0 File Offset: 0x000007D0
		internal int handle
		{
			[CompilerGenerated]
			readonly get
			{
				// // Int32 get_endIndex()
				// int32_t Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_endIndex(
				//         WireRendererInfoCollection_1_WireRendererInfo_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_endIndex;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_area(Int32)
				// void UnityEngine::AI::NavMeshBuildMarkup::set_area(NavMeshBuildMarkup *this, int32_t value, MethodInfo *method)
				// {
				//   this.m_Area = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000025D2 File Offset: 0x000007D2
		public static RendererListHandle InvalidHandle
		{
			get
			{
				// // RendererListHandle get_InvalidHandle()
				// RendererListHandle HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(306, 0LL) )
				//     return 0LL;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(306, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v4, v3);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_142(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		internal RendererListHandle(int handle)
		{
			// // Nullable`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+VSMSupport](CustomDepthOnlyRequestManager+VSMSupport)
			// void System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::VSMSupport>::Nullable(
			//         Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_ *this,
			//         CustomDepthOnlyRequestManager_VSMSupport value,
			//         MethodInfo *method)
			// {
			//   this.value = value;
			//   this.hasValue = 1;
			// }
			// 
		}

		[IDTag(0)]
		public static implicit operator int(RendererListHandle handle)
		{
			// // Int32 op_Implicit(RendererListHandle)
			// int32_t HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
			//         RendererListHandle handle,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int32_t handle_k__BackingField; // [rsp+34h] [rbp+Ch]
			// 
			//   handle_k__BackingField = handle._handle_k__BackingField;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(58, 0LL) )
			//     return handle_k__BackingField;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(58, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_31(Patch, handle, 0LL);
			// }
			// 
			return 0;
		}

		[IDTag(1)]
		public static implicit operator RendererList(RendererListHandle rendererList)
		{
			// // RendererList op_Implicit(RendererListHandle)
			// RendererList *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
			//         RendererList *__return_ptr retstr,
			//         RendererListHandle rendererList,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   RendererList *v8; // rax
			//   RendererList nullRendererList; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RendererList *result; // rax
			//   RendererList v12; // [rsp+20h] [rbp-18h] BYREF
			//   RendererListHandle v13; // [rsp+48h] [rbp+10h] BYREF
			// 
			//   v13 = rendererList;
			//   if ( !byte_18D9193A5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     byte_18D9193A5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(308, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(308, 0LL);
			//     if ( Patch )
			//     {
			//       v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_143(&v12, Patch, rendererList, 0LL);
			//       goto LABEL_11;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, v6);
			//   }
			//   if ( HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(&v13, 0LL) )
			//   {
			//     v5 = (HGRenderGraphResourceRegistry *)sub_1885A7CFC();
			//     if ( v5 )
			//     {
			//       v8 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRendererList(&v12, v5, &v13, 0LL);
			// LABEL_11:
			//       nullRendererList = *v8;
			//       goto LABEL_12;
			//     }
			//     goto LABEL_9;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//   nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList.static_fields.nullRendererList;
			// LABEL_12:
			//   result = retstr;
			//   *retstr = nullRendererList;
			//   return result;
			// }
			// 
			return null;
		}

		public readonly bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(RendererListHandle *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(66, 0LL) )
			//     return this.m_IsValid;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(66, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_33(Patch, this, 0LL);
			// }
			// 
			return default(bool);
		}

		private bool m_IsValid;
	}
}
