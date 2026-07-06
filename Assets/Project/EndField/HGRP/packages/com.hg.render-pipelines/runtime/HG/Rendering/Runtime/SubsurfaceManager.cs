using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class SubsurfaceManager
	{
		public SubsurfaceManager()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterMaterialCallback()
		{
			// // Void RegisterMaterialCallback()
			// void HG::Rendering::Runtime::SubsurfaceManager::RegisterMaterialCallback(MethodInfo *method)
			// {
			//   UnityAction_2_System_Int32_System_Boolean_ *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   UnityAction_2_System_Int32_System_Boolean_ *v4; // rbx
			//   UnityAction_2_System_Int32_System_Boolean_ *v5; // rax
			//   UnityAction_2_System_Int32_System_Boolean_ *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB66 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged);
			//     sub_18003C530(&TypeInfo::UnityEngine::Events::UnityAction<int,bool>);
			//     byte_18D8EDB66 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3295, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3295, 0LL);
			//     if ( !Patch )
			//       goto LABEL_6;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     v1 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_180004920(TypeInfo::UnityEngine::Events::UnityAction<int,bool>);
			//     v4 = v1;
			//     if ( !v1
			//       || (UnityEngine::Events::UnityAction<int,bool>::UnityAction(
			//             v1,
			//             0LL,
			//             MethodInfo::HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged,
			//             0LL),
			//           UnityEngine::HyperGryph::HGShadingStateSystem::remove_shadingStateChanged(v4, 0LL),
			//           v5 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_180004920(TypeInfo::UnityEngine::Events::UnityAction<int,bool>),
			//           (v6 = v5) == 0LL) )
			//     {
			// LABEL_6:
			//       sub_180B536AC(v3, v2);
			//     }
			//     UnityEngine::Events::UnityAction<int,bool>::UnityAction(
			//       v5,
			//       0LL,
			//       MethodInfo::HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged,
			//       0LL);
			//     UnityEngine::HyperGryph::HGShadingStateSystem::add_shadingStateChanged(v6, 0LL);
			//     UnityEngine::HyperGryph::HGShadingStateSystem::FlushAllMaterialCallbacks(0LL);
			//   }
			// }
			// 
		}

		private static void OnShadingStateChanged(int instanceId, bool state)
		{
			// // Void OnShadingStateChanged(Int32, Boolean)
			// void HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged(
			//         int32_t instanceId,
			//         bool state,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   SubsurfaceManager *subsurfaceManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3296, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3296, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1172(Patch, instanceId, state, 0LL);
			//   }
			//   else
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !state )
			//     {
			//       if ( currentManagerContext )
			//       {
			//         subsurfaceManager_k__BackingField = currentManagerContext.fields._subsurfaceManager_k__BackingField;
			//         if ( subsurfaceManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::SubsurfaceManager::UnregisterSubsurfaceMaterial(
			//             subsurfaceManager_k__BackingField,
			//             instanceId,
			//             0LL);
			//           return;
			//         }
			//       }
			// LABEL_11:
			//       sub_180B536AC(subsurfaceManager_k__BackingField, v6);
			//     }
			//     if ( !currentManagerContext )
			//       goto LABEL_11;
			//     subsurfaceManager_k__BackingField = currentManagerContext.fields._subsurfaceManager_k__BackingField;
			//     if ( !subsurfaceManager_k__BackingField )
			//       goto LABEL_11;
			//     HG::Rendering::Runtime::SubsurfaceManager::RegisterSubsurfaceMaterial(
			//       subsurfaceManager_k__BackingField,
			//       instanceId,
			//       0LL);
			//   }
			// }
			// 
		}

		public void RegisterSubsurfaceMaterial(int instanceId)
		{
			// // Void RegisterSubsurfaceMaterial(Int32)
			// void HG::Rendering::Runtime::SubsurfaceManager::RegisterSubsurfaceMaterial(
			//         SubsurfaceManager *this,
			//         int32_t instanceId,
			//         MethodInfo *method)
			// {
			//   uint32_t MaterialHandle; // eax
			//   Material *Material; // r14
			//   __int64 v7; // rdx
			//   Dictionary_2_System_Int32_System_Int32_ *instanceId2Index; // rcx
			//   __int64 v9; // rsi
			//   SubsurfaceData *v10; // rax
			//   _DWORD *v11; // rax
			//   int32_t v12; // ebx
			//   SubsurfaceData *v13; // rax
			//   __int64 v14; // rax
			//   __int64 v15; // xmm1_8
			//   int v16; // esi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SubsurfaceData data; // [rsp+20h] [rbp-38h] BYREF
			//   int32_t value; // [rsp+78h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9196F3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,int>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D515A48);
			//     byte_18D9196F3 = 1;
			//   }
			//   value = 0;
			//   memset(&data, 0, sizeof(data));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3298, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3298, 0LL);
			//     if ( !Patch )
			//       goto LABEL_40;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       instanceId,
			//       0LL);
			//   }
			//   else
			//   {
			//     MaterialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(instanceId, 0LL);
			//     if ( MaterialHandle )
			//     {
			//       Material = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterial(MaterialHandle, 0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Implicit((Object_1 *)Material, 0LL)
			//         && HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceData(Material, &data, 0LL) )
			//       {
			//         instanceId2Index = this.fields.instanceId2Index;
			//         if ( !instanceId2Index )
			//           goto LABEL_40;
			//         if ( System::Collections::Generic::Dictionary<int,int>::TryGetValue(
			//                instanceId2Index,
			//                instanceId,
			//                &value,
			//                MethodInfo::System::Collections::Generic::Dictionary<int,int>::TryGetValue) )
			//         {
			//           instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//           if ( !instanceId2Index )
			//             goto LABEL_40;
			//           v9 = value;
			//           v10 = (SubsurfaceData *)sub_18037A2A0(instanceId2Index, value);
			//           if ( HG::Rendering::Runtime::SubsurfaceData::Equals(v10, &data, 0LL) )
			//             goto LABEL_34;
			//           instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//           if ( !instanceId2Index )
			//             goto LABEL_40;
			//           v11 = (_DWORD *)sub_18037A2A0(instanceId2Index, v9);
			//           --*v11;
			//           instanceId2Index = this.fields.instanceId2Index;
			//           if ( !instanceId2Index )
			//             goto LABEL_40;
			//           System::Collections::Generic::Dictionary<int,int>::Remove(
			//             instanceId2Index,
			//             instanceId,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,int>::Remove);
			//         }
			//         LODWORD(v9) = -1;
			//         v12 = 0;
			//         while ( 1 )
			//         {
			//           instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//           if ( !instanceId2Index )
			//             goto LABEL_40;
			//           if ( *(int *)sub_18037A2A0(instanceId2Index, v12) > 0 )
			//           {
			//             instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//             if ( !instanceId2Index )
			//               goto LABEL_40;
			//             v13 = (SubsurfaceData *)sub_18037A2A0(instanceId2Index, v12);
			//             if ( HG::Rendering::Runtime::SubsurfaceData::Equals(v13, &data, 0LL) )
			//               break;
			//           }
			//           if ( (_DWORD)v9 == -1 )
			//           {
			//             instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//             if ( !instanceId2Index )
			//               goto LABEL_40;
			//             if ( !*(_DWORD *)sub_18037A2A0(instanceId2Index, v12) )
			//               LODWORD(v9) = v12;
			//           }
			//           if ( ++v12 >= 63 )
			//             goto LABEL_24;
			//         }
			//         if ( v12 == -1 )
			//         {
			// LABEL_24:
			//           v12 = v9;
			//           if ( (_DWORD)v9 == -1 )
			//           {
			//             HG::Rendering::HGRPLogger::LogError((String *)"Subsurface material exceed max count", 0LL);
			//             goto LABEL_34;
			//           }
			//         }
			//         else
			//         {
			//           LODWORD(v9) = v12;
			//         }
			//         instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//         if ( !instanceId2Index )
			//           goto LABEL_40;
			//         data.RefCount = *(_DWORD *)sub_18037A2A0(instanceId2Index, v12) + 1;
			//         instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//         if ( !instanceId2Index )
			//           goto LABEL_40;
			//         if ( (unsigned int)v12 >= LODWORD(instanceId2Index.fields._entries) )
			//           sub_180070270(instanceId2Index, v7);
			//         v14 = 3LL * v12;
			//         v15 = *(_QWORD *)&data.SubsurfaceColor.a;
			//         *(_OWORD *)(&instanceId2Index.fields._count + 2 * v14) = *(_OWORD *)&data.RefCount;
			//         *((_QWORD *)&instanceId2Index.fields._comparer + v14) = v15;
			//         instanceId2Index = this.fields.instanceId2Index;
			//         if ( !instanceId2Index )
			//           goto LABEL_40;
			//         System::Collections::Generic::Dictionary<int,int>::Add(
			//           instanceId2Index,
			//           instanceId,
			//           v12,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,int>::Add);
			// LABEL_34:
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         if ( (_DWORD)v9 == -1 )
			//           v16 = 0;
			//         else
			//           v16 = v9 + 1;
			//         if ( Material )
			//         {
			//           UnityEngine::Material::SetFloatImpl(
			//             Material,
			//             TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SubsurfaceInt,
			//             (float)v16,
			//             0LL);
			//           return;
			//         }
			// LABEL_40:
			//         sub_180B536AC(instanceId2Index, v7);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void UnregisterSubsurfaceMaterial(int instanceId)
		{
			// // Void UnregisterSubsurfaceMaterial(Int32)
			// void HG::Rendering::Runtime::SubsurfaceManager::UnregisterSubsurfaceMaterial(
			//         SubsurfaceManager *this,
			//         int32_t instanceId,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_Int32_System_Int32_ *instanceId2Index; // rcx
			//   _DWORD *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t value; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9196F4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,int>::TryGetValue);
			//     byte_18D9196F4 = 1;
			//   }
			//   value = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3299, 0LL) )
			//   {
			//     instanceId2Index = this.fields.instanceId2Index;
			//     if ( instanceId2Index )
			//     {
			//       if ( !System::Collections::Generic::Dictionary<int,int>::TryGetValue(
			//               instanceId2Index,
			//               instanceId,
			//               &value,
			//               MethodInfo::System::Collections::Generic::Dictionary<int,int>::TryGetValue) )
			//         return;
			//       instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this.fields.dataList;
			//       if ( instanceId2Index )
			//       {
			//         v7 = (_DWORD *)sub_18037A2A0(instanceId2Index, value);
			//         --*v7;
			//         instanceId2Index = this.fields.instanceId2Index;
			//         if ( instanceId2Index )
			//         {
			//           System::Collections::Generic::Dictionary<int,int>::Remove(
			//             instanceId2Index,
			//             instanceId,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,int>::Remove);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(instanceId2Index, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3299, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, instanceId, 0LL);
			// }
			// 
		}

		public void BindSubsurfaceData(HGRenderGraphContext context)
		{
			// // Void BindSubsurfaceData(HGRenderGraphContext)
			// void HG::Rendering::Runtime::SubsurfaceManager::BindSubsurfaceData(
			//         SubsurfaceManager *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   int v6; // ebx
			//   float *v7; // rdi
			//   SubsurfaceData__Array *dataList; // rcx
			//   void *v9; // xmm1_8
			//   int v10; // xmm1_4
			//   float v11; // xmm0_4
			//   int ptr_high; // xmm1_4
			//   CBHandle *v13; // rax
			//   void *ptr; // xmm1_8
			//   __int64 v15; // rdx
			//   _OWORD *v16; // rax
			//   _OWORD *v17; // rcx
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   CommandBuffer *cmd; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int v33; // [rsp+30h] [rbp-D0h] BYREF
			//   float v34[3]; // [rsp+34h] [rbp-CCh] BYREF
			//   _BYTE offset[24]; // [rsp+40h] [rbp-C0h] BYREF
			//   CBHandle v36; // [rsp+60h] [rbp-A0h] BYREF
			//   _BYTE v37[4]; // [rsp+80h] [rbp-80h] BYREF
			//   char v38; // [rsp+84h] [rbp-7Ch] BYREF
			//   _BYTE v39[1008]; // [rsp+470h] [rbp+370h] BYREF
			//   int v40; // [rsp+898h] [rbp+798h] BYREF
			// 
			//   if ( !byte_18D9196F5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::SubsurfaceManager::SubsurfaceConstants>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D9196F5 = 1;
			//   }
			//   v33 = 0;
			//   v34[0] = 0.0;
			//   v40 = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3300, 0LL) )
			//   {
			//     sub_1802F01E0(v37, 0LL, 1008LL);
			//     v6 = 0;
			//     v7 = (float *)&v38;
			//     do
			//     {
			//       dataList = this.fields.dataList;
			//       if ( !dataList )
			//         goto LABEL_17;
			//       if ( (unsigned int)v6 >= dataList.max_length.size )
			//         sub_180070270(dataList, static_fields);
			//       static_fields = (HGShaderIDs__StaticFields *)(3LL * v6);
			//       v9 = *(void **)&dataList.vector[v6].SubsurfaceColor.a;
			//       *(_OWORD *)&v36.bufferId = *(_OWORD *)&dataList.vector[v6].RefCount;
			//       v36.ptr = v9;
			//       *(_QWORD *)&offset[16] = v9;
			//       if ( _mm_cvtsi128_si32(*(__m128i *)&v36.bufferId) > 0 )
			//       {
			//         *(_OWORD *)offset = *(_OWORD *)&v36.bufferId;
			//         *(_QWORD *)&offset[16] = v9;
			//         *(_OWORD *)offset = *(_OWORD *)&offset[4];
			//         UnityEngine::Color::RGBToHSV((Color *)offset, (float *)&v33, v34, (float *)&v40, 0LL);
			//         v10 = v33;
			//         *((_DWORD *)v7 - 1) = v40;
			//         v11 = v34[0];
			//         *(_DWORD *)v7 = v10;
			//         ptr_high = HIDWORD(v36.ptr);
			//         v7[1] = v11;
			//         *((_DWORD *)v7 + 2) = ptr_high;
			//       }
			//       ++v6;
			//       v7 += 4;
			//     }
			//     while ( v6 < 63 );
			//     if ( context )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v13 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//               &v36,
			//               &context.fields.renderContext,
			//               1008,
			//               0LL);
			//       ptr = v13.ptr;
			//       *(_OWORD *)offset = *(_OWORD *)&v13.bufferId;
			//       *(_QWORD *)&offset[16] = ptr;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v15 = 7LL;
			//       v16 = v39;
			//       v17 = v37;
			//       do
			//       {
			//         v18 = v17[1];
			//         *v16 = *v17;
			//         v19 = v17[2];
			//         v16[1] = v18;
			//         v20 = v17[3];
			//         v16[2] = v19;
			//         v21 = v17[4];
			//         v16[3] = v20;
			//         v22 = v17[5];
			//         v16[4] = v21;
			//         v23 = v17[6];
			//         v16[5] = v22;
			//         v24 = v17[7];
			//         v17 += 8;
			//         v16[6] = v23;
			//         v16 += 8;
			//         *(v16 - 1) = v24;
			//         --v15;
			//       }
			//       while ( v15 );
			//       v25 = v17[1];
			//       *v16 = *v17;
			//       v26 = v17[2];
			//       v16[1] = v25;
			//       v27 = v17[3];
			//       v16[2] = v26;
			//       v28 = v17[4];
			//       v16[3] = v27;
			//       v29 = v17[5];
			//       v16[4] = v28;
			//       v30 = v17[6];
			//       v16[5] = v29;
			//       v16[6] = v30;
			//       sub_180831F44(offset, v39, 128LL);
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( cmd )
			//       {
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//           cmd,
			//           *(uint32_t *)offset,
			//           static_fields._SubsurfaceConstants,
			//           *(int32_t *)&offset[4],
			//           1008,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(dataList, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3300, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)context,
			//     0LL);
			// }
			// 
		}

		private const int NONE_SUBSURFACE_MATERIAL_INDEX = 0;

		private const int MAX_SUBSURFACE_MATERIAL_COUNT = 63;

		private Dictionary<int, int> instanceId2Index;

		private SubsurfaceData[] dataList;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 1008)]
		internal struct SubsurfaceConstants
		{
			[FixedBuffer(typeof(float), 252)]
			public SubsurfaceManager.SubsurfaceConstants.<_SubsurfaceParams>e__FixedBuffer _SubsurfaceParams;

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 1008)]
			public struct <_SubsurfaceParams>e__FixedBuffer
			{
				public float FixedElementField;
			}
		}
	}
}
