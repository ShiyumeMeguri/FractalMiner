using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace HG.Rendering.Tools
{
	public class HGShadowDetailDumper
	{
		public HGShadowDetailDumper()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		private static Task<List<HGShadowDetailDumper.ShadowDetailRowContent>> DumpShadowDetails(Camera targetCamera, [MetadataOffset(Offset = "0x01F909DC")] bool realtimeDataOnly = true)
		{
			// // Task`1[System.Collections.Generic.List`1[HG.Rendering.Tools.HGShadowDetailDumper+ShadowDetailRowContent]] DumpShadowDetails(Camera, Boolean)
			// Task_1_System_Collections_Generic_List_1_HG_Rendering_Tools_HGShadowDetailDumper_ShadowDetailRowContent_ *HG::Rendering::Tools::HGShadowDetailDumper::DumpShadowDetails(
			//         Camera *targetCamera,
			//         bool realtimeDataOnly,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v5; // rdx
			//   Bounds *v6; // r8
			//   Object__Array *v7; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   MethodInfo *v12; // [rsp+20h] [rbp-58h]
			//   MethodInfo *v13; // [rsp+28h] [rbp-50h]
			//   HGShadowDetailDumper_DumpShadowDetails_d_2 stateMachine; // [rsp+38h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D919310 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::Create);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpShadowDetails_d__2>);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::get_Task);
			//     sub_18003C530(&TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
			//     byte_18D919310 = 1;
			//   }
			//   *(_QWORD *)&stateMachine.__1__state = 0LL;
			//   *(_OWORD *)&stateMachine._result_5__2 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(21, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(21, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_16(Patch, (Object *)targetCamera, realtimeDataOnly, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
			//     memset(&stateMachine.__t__builder, 0, sizeof(stateMachine.__t__builder));
			//     sub_1800054D0((BSP *)&stateMachine.__t__builder, v5, v6, v7, v12, v13);
			//     stateMachine.__1__state = -1;
			//     System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpShadowDetails_d__2>(
			//       (AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder,
			//       &stateMachine,
			//       MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpShadowDetails_d__2>);
			//     return (Task_1_System_Collections_Generic_List_1_HG_Rendering_Tools_HGShadowDetailDumper_ShadowDetailRowContent_ *)System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::get_Task((AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder, MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::get_Task);
			//   }
			// }
			// 
			return null;
		}

		public static void DumpCurrentShadowStatsToCSV(Camera targetCamera, string filePath)
		{
			// // Void DumpCurrentShadowStatsToCSV(Camera, String)
			// void HG::Rendering::Tools::HGShadowDetailDumper::DumpCurrentShadowStatsToCSV(
			//         Camera *targetCamera,
			//         String *filePath,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v5; // rdx
			//   Bounds *v6; // r8
			//   Object__Array *v7; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v8; // rdx
			//   Bounds *v9; // r8
			//   Object__Array *v10; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v11; // rdx
			//   Bounds *v12; // r8
			//   Object__Array *v13; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   AsyncVoidMethodBuilder v17; // [rsp+20h] [rbp-29h] BYREF
			//   HGShadowDetailDumper_DumpCurrentShadowStatsToCSV_d_3 stateMachine; // [rsp+40h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D919311 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpCurrentShadowStatsToCSV_d__3>);
			//     byte_18D919311 = 1;
			//   }
			//   sub_1802F01E0(&stateMachine, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(24, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(24, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)targetCamera,
			//       (Object *)filePath,
			//       0LL);
			//   }
			//   else
			//   {
			//     stateMachine.__t__builder = *System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Create(&v17, 0LL);
			//     sub_1800054D0(
			//       (BSP *)&stateMachine.__t__builder,
			//       v5,
			//       v6,
			//       v7,
			//       (MethodInfo *)v17.m_synchronizationContext,
			//       (MethodInfo *)v17.m_coreState.m_stateMachine);
			//     stateMachine.targetCamera = targetCamera;
			//     sub_1800054D0(
			//       (BSP *)&stateMachine.targetCamera,
			//       v8,
			//       v9,
			//       v10,
			//       (MethodInfo *)v17.m_synchronizationContext,
			//       (MethodInfo *)v17.m_coreState.m_stateMachine);
			//     stateMachine.filePath = filePath;
			//     sub_1800054D0(
			//       (BSP *)&stateMachine.filePath,
			//       v11,
			//       v12,
			//       v13,
			//       (MethodInfo *)v17.m_synchronizationContext,
			//       (MethodInfo *)v17.m_coreState.m_stateMachine);
			//     stateMachine.__1__state = -1;
			//     System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpCurrentShadowStatsToCSV_d__3>(
			//       &stateMachine.__t__builder,
			//       &stateMachine,
			//       MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpCurrentShadowStatsToCSV_d__3>);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static string[] s_shadowRowTitles;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
		public struct ShadowDetailRowContent
		{
			public string shadowDebugName;

			public string lightName;

			public int batchCount;

			public int instanceCount;

			public int vertexCount;

			public int triangleCount;

			public bool isBakedRequest;
		}
	}
}
