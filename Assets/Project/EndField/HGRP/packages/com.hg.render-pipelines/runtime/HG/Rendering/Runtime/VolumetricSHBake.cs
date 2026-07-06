using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class VolumetricSHBake
	{
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x000025D0 File Offset: 0x000007D0
		public static ComputeBuffer SHBuffer
		{
			[CompilerGenerated]
			get
			{
				// // ComputeBuffer get_SHBuffer()
				// ComputeBuffer *HG::Rendering::Runtime::VolumetricSHBake::get_SHBuffer(MethodInfo *method)
				// {
				//   if ( !byte_18D919824 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake);
				//     byte_18D919824 = 1;
				//   }
				//   return TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields._SHBuffer_k__BackingField;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_SHBuffer(ComputeBuffer)
				// void HG::Rendering::Runtime::VolumetricSHBake::set_SHBuffer(ComputeBuffer *value, MethodInfo *method)
				// {
				//   VolumetricRenderer_VolumetricBounds *v2; // r8
				//   Material *v3; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
				//   MethodInfo *v6; // [rsp+50h] [rbp+28h]
				//   MethodInfo *v7; // [rsp+58h] [rbp+30h]
				//   int32_t v8; // [rsp+60h] [rbp+38h]
				//   int32_t v9; // [rsp+68h] [rbp+40h]
				//   float v10; // [rsp+70h] [rbp+48h]
				//   int32_t v11; // [rsp+78h] [rbp+50h]
				//   bool v12; // [rsp+80h] [rbp+58h]
				//   bool v13; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v14; // [rsp+90h] [rbp+68h]
				// 
				//   if ( !byte_18D919825 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake);
				//     byte_18D919825 = 1;
				//   }
				//   static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields;
				//   static_fields.monitor = (MonitorData *)value;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields._SHBuffer_k__BackingField,
				//     static_fields,
				//     v2,
				//     v3,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14);
				// }
				// 
			}
		}

		public VolumetricSHBake()
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

		public static List<Vector4> GenerateSphereSamples(int NumThetaSteps, int NumPhiSteps)
		{
			// // List`1[UnityEngine.Vector4] GenerateSphereSamples(Int32, Int32)
			// List_1_UnityEngine_Vector4_ *HG::Rendering::Runtime::VolumetricSHBake::GenerateSphereSamples(
			//         int32_t NumThetaSteps,
			//         int32_t NumPhiSteps,
			//         MethodInfo *method)
			// {
			//   LowLevelList_1_System_Object_ *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   List_1_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_LayoutMatcher_ *v8; // rdi
			//   int32_t i; // r14d
			//   int32_t j; // r15d
			//   unsigned int v11; // xmm8_4
			//   float3 *v12; // rdx
			//   float3 *v13; // rcx
			//   float3 *v14; // r8
			//   float3 *v15; // r9
			//   float v16; // xmm7_4
			//   double v17; // xmm0_8
			//   double v18; // xmm0_8
			//   double v19; // xmm0_8
			//   double v20; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v23; // [rsp+28h] [rbp-49h]
			//   __int128 v24; // [rsp+38h] [rbp-39h]
			//   _OWORD v25[7]; // [rsp+48h] [rbp-29h] BYREF
			// 
			//   if ( !byte_18D919826 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::set_Capacity);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
			//     byte_18D919826 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4638, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4638, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1331(Patch, NumThetaSteps, NumPhiSteps, 0LL);
			// LABEL_11:
			//     sub_180B536AC(v7, v6);
			//   }
			//   v5 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
			//   v8 = (List_1_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_LayoutMatcher_ *)v5;
			//   if ( !v5 )
			//     goto LABEL_11;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v5,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
			//   System::Collections::Generic::List<UnityEngine::InputSystem::Layouts::InputControlLayout_Collection::LayoutMatcher>::set_Capacity(
			//     v8,
			//     NumPhiSteps * NumThetaSteps,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::set_Capacity);
			//   for ( i = 0; i < NumThetaSteps; ++i )
			//   {
			//     for ( j = 0; j < NumPhiSteps; ++j )
			//     {
			//       *(float *)&v11 = (float)(UnityEngine::Random::get_value(0LL) + (float)i) / (float)NumThetaSteps;
			//       v16 = sub_1802ECED0(v13, v12, v14, v15);
			//       UnityEngine::Random::get_value(0LL);
			//       v17 = Beyond::DampingMath::cosf();
			//       *(float *)&v23 = *(float *)&v17 * v16;
			//       v18 = Beyond::DampingMath::sinf();
			//       *((_QWORD *)&v23 + 1) = v11;
			//       *((float *)&v23 + 1) = *(float *)&v18 * v16;
			//       v25[0] = v23;
			//       sub_182571DC0(v8, v25, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
			//       v19 = Beyond::DampingMath::cosf();
			//       *(float *)&v24 = *(float *)&v19 * v16;
			//       v20 = Beyond::DampingMath::sinf();
			//       *((_QWORD *)&v24 + 1) = COERCE_UNSIGNED_INT(-*(float *)&v11);
			//       *((float *)&v24 + 1) = *(float *)&v20 * v16;
			//       v25[0] = v24;
			//       sub_182571DC0(v8, v25, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
			//     }
			//   }
			//   return (List_1_UnityEngine_Vector4_ *)v8;
			// }
			// 
			return null;
		}

		private static List<Vector4> SetupSphericalSamples(List<Vector4> SampleDirections)
		{
			// // List`1[UnityEngine.Vector4] SetupSphericalSamples(List`1[UnityEngine.Vector4])
			// List_1_UnityEngine_Vector4_ *HG::Rendering::Runtime::VolumetricSHBake::SetupSphericalSamples(
			//         List_1_UnityEngine_Vector4_ *SampleDirections,
			//         MethodInfo *method)
			// {
			//   int32_t v2; // ebx
			//   LowLevelList_1_System_Object_ *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_UnityEngine_Vector4_ *v7; // rdi
			//   __m128 v8; // xmm6
			//   float3 *v9; // rdx
			//   float3 *v10; // rcx
			//   float3 *v11; // r8
			//   float3 *v12; // r9
			//   float3 *v13; // rdx
			//   float3 *v14; // rcx
			//   float3 *v15; // r8
			//   float3 *v16; // r9
			//   float v17; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v20; // [rsp+20h] [rbp-48h]
			//   __m128 v21; // [rsp+30h] [rbp-38h] BYREF
			//   __int128 v22; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   v2 = 0;
			//   if ( !byte_18D919827 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
			//     byte_18D919827 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4639, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4639, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1332(Patch, (Object *)SampleDirections, 0LL);
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   v4 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
			//   v7 = (List_1_UnityEngine_Vector4_ *)v4;
			//   if ( !v4 )
			//     goto LABEL_10;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v4,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
			//   if ( !SampleDirections )
			//     goto LABEL_10;
			//   while ( v2 < SampleDirections.fields._size )
			//   {
			//     System::Collections::Generic::List<Beyond::Gameplay::MissionSystem::NewMissionTag>::get_Item(
			//       (MissionSystem_NewMissionTag *)&v21,
			//       (List_1_Beyond_Gameplay_MissionSystem_NewMissionTag_ *)SampleDirections,
			//       v2,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
			//     v8 = v21;
			//     *(float *)&v20 = sub_1802ECED0(v10, v9, v11, v12) * 0.5;
			//     v17 = sub_1802ECED0(v14, v13, v15, v16) * 0.5;
			//     *((float *)&v20 + 1) = v17 * _mm_shuffle_ps(v8, v8, 85).m128_f32[0];
			//     *((float *)&v20 + 3) = v17 * v8.m128_f32[0];
			//     *((float *)&v20 + 2) = v17 * _mm_shuffle_ps(v8, v8, 170).m128_f32[0];
			//     v22 = v20;
			//     sub_182571DC0(v7, &v22, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
			//     ++v2;
			//   }
			//   return v7;
			// }
			// 
			return null;
		}

		public static ComputeBuffer BuildSHSampleBuffer(int NumThetaSteps, int NumPhiSteps)
		{
			// // ComputeBuffer BuildSHSampleBuffer(Int32, Int32)
			// ComputeBuffer *HG::Rendering::Runtime::VolumetricSHBake::BuildSHSampleBuffer(
			//         int32_t NumThetaSteps,
			//         int32_t NumPhiSteps,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   struct VolumetricSHBake__Class *v6; // rcx
			//   VolumetricSHBake__StaticFields *static_fields; // rax
			//   List_1_UnityEngine_Vector4_ *SphereSamples; // rbp
			//   List_1_UnityEngine_Vector4_ *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   List_1_Beyond_Gameplay_MissionSystem_NewMissionTag_ *v12; // rsi
			//   int size; // ebx
			//   int32_t v14; // edi
			//   ComputeBuffer *v15; // rax
			//   ComputeBuffer *v16; // rax
			//   ComputeBuffer *v17; // rbx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v18; // rdx
			//   VolumetricRenderer_VolumetricBounds *v19; // r8
			//   Material *v20; // r9
			//   List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *v21; // rax
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v22; // rbx
			//   int32_t i; // edi
			//   MissionSystem_NewMissionTag v24; // xmm6
			//   ComputeBuffer *v25; // rdi
			//   Array *v26; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v29; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v30; // [rsp+28h] [rbp-60h]
			//   MissionSystem_NewMissionTag v31; // [rsp+30h] [rbp-58h] BYREF
			//   MissionSystem_NewMissionTag v32; // [rsp+40h] [rbp-48h] BYREF
			//   MissionSystem_NewMissionTag v33; // [rsp+50h] [rbp-38h] BYREF
			//   MissionSystem_NewMissionTag v34; // [rsp+60h] [rbp-28h]
			// 
			//   if ( !byte_18D919828 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::ToArray);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake);
			//     byte_18D919828 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4640, 0LL) )
			//   {
			//     v5 = ((__int64 (*)(void))sub_1886D58C4)();
			//     v6 = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake;
			//     if ( v5 )
			//     {
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields;
			//       if ( NumThetaSteps == static_fields._numThetaSteps && NumPhiSteps == static_fields._numPhiSteps )
			//         return (ComputeBuffer *)sub_1886D58C4(v6);
			//     }
			//     TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields._numThetaSteps = NumThetaSteps;
			//     TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields._numPhiSteps = NumPhiSteps;
			//     SphereSamples = HG::Rendering::Runtime::VolumetricSHBake::GenerateSphereSamples(NumThetaSteps, NumPhiSteps, 0LL);
			//     v9 = HG::Rendering::Runtime::VolumetricSHBake::SetupSphericalSamples(SphereSamples, 0LL);
			//     v12 = (List_1_Beyond_Gameplay_MissionSystem_NewMissionTag_ *)v9;
			//     if ( v9 )
			//     {
			//       size = v9.fields._size;
			//       sub_180002C70(TypeInfo::System::Math);
			//       v14 = 1;
			//       if ( size >= 1 )
			//         v14 = size;
			//       v15 = (ComputeBuffer *)((__int64 (*)(void))sub_1886D58C4)();
			//       if ( v15 )
			//         UnityEngine::ComputeBuffer::Dispose(v15, 0LL);
			//       v16 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v17 = v16;
			//       if ( v16 )
			//       {
			//         UnityEngine::ComputeBuffer::ComputeBuffer(v16, v14, 32, ComputeBufferType__Enum_Default, 0LL);
			//         if ( !byte_18D919861 )
			//         {
			//           sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake);
			//           byte_18D919861 = 1;
			//         }
			//         TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields._SHBuffer_k__BackingField = v17;
			//         sub_1800054D0(
			//           (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake.static_fields._SHBuffer_k__BackingField,
			//           v18,
			//           v19,
			//           v20,
			//           v29,
			//           v30,
			//           (int32_t)v31.missionId,
			//           (int32_t)v31.questId,
			//           *(float *)&v32.missionId,
			//           (int32_t)v32.questId,
			//           (bool)v33.missionId,
			//           (bool)v33.questId,
			//           (MethodInfo *)v34.missionId);
			//         v21 = (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>);
			//         v22 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v21;
			//         if ( v21 )
			//         {
			//           System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::List(
			//             v21,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::List);
			//           for ( i = 0; i < v12.fields._size; ++i )
			//           {
			//             if ( !SphereSamples )
			//               goto LABEL_24;
			//             System::Collections::Generic::List<Beyond::Gameplay::MissionSystem::NewMissionTag>::get_Item(
			//               &v31,
			//               (List_1_Beyond_Gameplay_MissionSystem_NewMissionTag_ *)SphereSamples,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
			//             v24 = v31;
			//             System::Collections::Generic::List<Beyond::Gameplay::MissionSystem::NewMissionTag>::get_Item(
			//               &v32,
			//               v12,
			//               i,
			//               MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
			//             v33 = v24;
			//             v34 = v32;
			//             sub_18043E414(
			//               v22,
			//               &v33,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::Add);
			//           }
			//           v25 = (ComputeBuffer *)((__int64 (*)(void))sub_1886D58C4)();
			//           v26 = (Array *)System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::ToArray(
			//                            v22,
			//                            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::ToArray);
			//           if ( v25 )
			//           {
			//             UnityEngine::ComputeBuffer::SetData(v25, v26, 0LL);
			//             return (ComputeBuffer *)sub_1886D58C4(v6);
			//           }
			//         }
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(v11, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4640, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1333(Patch, NumThetaSteps, NumPhiSteps, 0LL);
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int _numThetaSteps;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		private static int _numPhiSteps;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		public struct FSHSampleData
		{
			public Vector4 Direction;

			public Vector4 SHValue;
		}
	}
}
