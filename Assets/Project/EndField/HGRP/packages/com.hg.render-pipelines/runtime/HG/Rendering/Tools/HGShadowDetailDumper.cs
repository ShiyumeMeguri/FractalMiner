using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Tools
{
	public class HGShadowDetailDumper // TypeDefIndex: 37408
	{
		// Fields
		internal static string[] s_shadowRowTitles; // 0x00
	
		// Nested types
		public struct ShadowDetailRowContent // TypeDefIndex: 37405
		{
			// Fields
			public string shadowDebugName; // 0x00
			public string lightName; // 0x08
			public int batchCount; // 0x10
			public int instanceCount; // 0x14
			public int vertexCount; // 0x18
			public int triangleCount; // 0x1C
			public bool isBakedRequest; // 0x20
		}
	
		// Constructors
		public HGShadowDetailDumper() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGShadowDetailDumper() {} // 0x0000000189B306B4-0x0000000189B3078C
		// HGShadowDetailDumper()
		void HG::Rendering::Tools::HGShadowDetailDumper::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  String__Array *v4; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v5; // rdx
		  VolumetricRenderer_VolumetricBounds *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		  MethodInfo *v9; // [rsp+58h] [rbp+30h]
		  int32_t v10; // [rsp+60h] [rbp+38h]
		  int32_t v11; // [rsp+68h] [rbp+40h]
		  float v12; // [rsp+70h] [rbp+48h]
		  int32_t v13; // [rsp+78h] [rbp+50h]
		  bool v14; // [rsp+80h] [rbp+58h]
		  bool v15; // [rsp+88h] [rbp+60h]
		  MethodInfo *v16; // [rsp+90h] [rbp+68h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::System::String, 7LL);
		  v4 = (String__Array *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  sub_180005370(v1, 0LL, "Shadow Name");
		  sub_180005370(v4, 1LL, "Light Name");
		  sub_180005370(v4, 2LL, "Batch Count");
		  sub_180005370(v4, 3LL, "Instance Count");
		  sub_180005370(v4, 4LL, "Vertex Count");
		  sub_180005370(v4, 5LL, "Triangle Count");
		  sub_180005370(v4, 6LL, "Is Baked Shadow");
		  TypeInfo::HG::Rendering::Tools::HGShadowDetailDumper->static_fields->s_shadowRowTitles = v4;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)TypeInfo::HG::Rendering::Tools::HGShadowDetailDumper->static_fields,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14,
		    v15,
		    v16);
		}
		
	
		// Methods
		private static async Task<List<ShadowDetailRowContent>> DumpShadowDetails(Camera targetCamera, bool realtimeDataOnly = true /* Metadata: 0x02302D4C */) => default; // 0x0000000189B305F4-0x0000000189B306B4
		// Task`1[System.Collections.Generic.List`1[HG.Rendering.Tools.HGShadowDetailDumper+ShadowDetailRowContent]] DumpShadowDetails(Camera, Boolean)
		Task_1_System_Collections_Generic_List_1_HG_Rendering_Tools_HGShadowDetailDumper_ShadowDetailRowContent_ *HG::Rendering::Tools::HGShadowDetailDumper::DumpShadowDetails(
		        Camera *targetCamera,
		        bool realtimeDataOnly,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v5; // rdx
		  VolumetricRenderer_VolumetricBounds *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-58h]
		  MethodInfo *v13; // [rsp+28h] [rbp-50h]
		  HGShadowDetailDumper_DumpShadowDetails_d_2 stateMachine; // [rsp+38h] [rbp-40h] BYREF
		
		  *(_QWORD *)&stateMachine.__1__state = 0LL;
		  *(_OWORD *)&stateMachine._result_5__2 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(15, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(15, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(Patch, (Object *)targetCamera, realtimeDataOnly, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
		    memset(&stateMachine.__t__builder, 0, sizeof(stateMachine.__t__builder));
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&stateMachine.__t__builder,
		      v5,
		      v6,
		      v7,
		      v12,
		      v13,
		      0,
		      stateMachine.__1__state);
		    stateMachine.__1__state = -1;
		    System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpShadowDetails_d__2>(
		      (AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder,
		      &stateMachine,
		      MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpShadowDetails_d__2>);
		    return (Task_1_System_Collections_Generic_List_1_HG_Rendering_Tools_HGShadowDetailDumper_ShadowDetailRowContent_ *)System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::get_Task((AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder, MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::get_Task);
		  }
		}
		
		public static async void DumpCurrentShadowStatsToCSV(Camera targetCamera, string filePath) {} // 0x0000000189B30528-0x0000000189B305F4
		// Void DumpCurrentShadowStatsToCSV(Camera, String)
		void HG::Rendering::Tools::HGShadowDetailDumper::DumpCurrentShadowStatsToCSV(
		        Camera *targetCamera,
		        String *filePath,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v5; // rdx
		  VolumetricRenderer_VolumetricBounds *v6; // r8
		  Int32__Array **v7; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  VolumetricRenderer_VolumetricBounds *v9; // r8
		  Int32__Array **v10; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v11; // rdx
		  VolumetricRenderer_VolumetricBounds *v12; // r8
		  Int32__Array **v13; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  AsyncVoidMethodBuilder v17; // [rsp+20h] [rbp-29h] BYREF
		  HGShadowDetailDumper_DumpCurrentShadowStatsToCSV_d_3 stateMachine; // [rsp+40h] [rbp-9h] BYREF
		
		  sub_18033B9D0(&stateMachine, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(18, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(18, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)targetCamera,
		      (Object *)filePath,
		      0LL);
		  }
		  else
		  {
		    stateMachine.__t__builder = *System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Create(&v17, 0LL);
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t, float))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&stateMachine.__t__builder,
		      v5,
		      v6,
		      v7,
		      (MethodInfo *)v17.m_synchronizationContext,
		      (MethodInfo *)v17.m_coreState.m_stateMachine,
		      (int32_t)v17.m_coreState.m_defaultContextAction,
		      (int32_t)v17.m_task,
		      *(float *)&stateMachine.__1__state);
		    stateMachine.targetCamera = targetCamera;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&stateMachine.targetCamera,
		      v8,
		      v9,
		      v10,
		      (MethodInfo *)v17.m_synchronizationContext,
		      (MethodInfo *)v17.m_coreState.m_stateMachine,
		      (int32_t)v17.m_coreState.m_defaultContextAction,
		      (int32_t)v17.m_task,
		      *(float *)&stateMachine.__1__state,
		      (int32_t)stateMachine.__t__builder.m_synchronizationContext,
		      (bool)stateMachine.__t__builder.m_coreState.m_stateMachine,
		      (bool)stateMachine.__t__builder.m_coreState.m_defaultContextAction,
		      (MethodInfo *)stateMachine.__t__builder.m_task);
		    stateMachine.filePath = filePath;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&stateMachine.filePath,
		      v11,
		      v12,
		      v13,
		      (MethodInfo *)v17.m_synchronizationContext,
		      (MethodInfo *)v17.m_coreState.m_stateMachine,
		      (int32_t)v17.m_coreState.m_defaultContextAction,
		      (int32_t)v17.m_task,
		      *(float *)&stateMachine.__1__state,
		      (int32_t)stateMachine.__t__builder.m_synchronizationContext,
		      (bool)stateMachine.__t__builder.m_coreState.m_stateMachine,
		      (bool)stateMachine.__t__builder.m_coreState.m_defaultContextAction,
		      (MethodInfo *)stateMachine.__t__builder.m_task);
		    stateMachine.__1__state = -1;
		    System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpCurrentShadowStatsToCSV_d__3>(
		      &stateMachine.__t__builder,
		      &stateMachine,
		      MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<HG::Rendering::Tools::HGShadowDetailDumper::_DumpCurrentShadowStatsToCSV_d__3>);
		  }
		}
		
	}
}
