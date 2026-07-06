using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class GpuClothManager
	{
		public GpuClothManager()
		{
			// // GpuClothManager()
			// void HG::Rendering::Runtime::GpuClothManager::GpuClothManager(GpuClothManager *this, MethodInfo *method)
			// {
			//   Vector4 si128; // xmm1
			//   int v4; // ebx
			//   __int64 v5; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v6; // rax
			//   __int64 v7; // rdx
			//   ComputeBuffer *clothMetaDataBuffer; // rcx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v9; // rsi
			//   OneofDescriptorProto *v10; // rdx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   __int64 v13; // rax
			//   __int64 v14; // rax
			//   __int64 v15; // r8
			//   __int64 v16; // r9
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   IndexedHashSet_1_System_UInt32_ *v20; // rax
			//   ComputeBuffer *v21; // rsi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v25; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v26; // rsi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v30; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v31; // rsi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   Il2CppClass *klass; // rcx
			//   __int64 v36; // rax
			//   Il2CppClass *v37; // rcx
			//   __int64 v38; // rax
			//   Il2CppClass *v39; // rcx
			//   __int64 v40; // rax
			//   Il2CppClass *v41; // rcx
			//   __int64 v42; // rax
			//   Il2CppClass *v43; // rcx
			//   __int64 v44; // rax
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v50; // xmm1
			//   __int128 v51; // xmm0
			//   OneofDescriptorProto *v52; // rdx
			//   FileDescriptor *v53; // r8
			//   MessageDescriptor *v54; // r9
			//   __int64 v55; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-59h]
			//   MethodInfo *methode; // [rsp+20h] [rbp-59h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-59h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-59h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-59h]
			//   MethodInfo *methodf; // [rsp+20h] [rbp-59h]
			//   String *v62; // [rsp+28h] [rbp-51h]
			//   String *v63; // [rsp+28h] [rbp-51h]
			//   String *v64; // [rsp+28h] [rbp-51h]
			//   String *v65; // [rsp+28h] [rbp-51h]
			//   String *v66; // [rsp+28h] [rbp-51h]
			//   String *v67; // [rsp+28h] [rbp-51h]
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v68; // [rsp+30h] [rbp-49h] BYREF
			//   _BYTE v69[128]; // [rsp+40h] [rbp-39h] BYREF
			// 
			//   if ( !byte_18D8EDBFB )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::DynamicArray);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::DynamicArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicArray<unsigned int>);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::IndexedHashSet);
			//     sub_18003C530(&TypeInfo::Beyond::IndexedHashSet<unsigned int>);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::NativeParallelHashMap);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::NativeParallelHashMap);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::NativeParallelHashMap);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
			//     byte_18D8EDBFB = 1;
			//   }
			//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357B20);
			//   this.fields.CHARACTER_POSITION_OFFSET = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//   *(_QWORD *)&this[1].fields.INVALID_POSITION.y = 1090519040LL;
			//   this.fields.INVALID_POSITION = si128;
			//   v4 = 0;
			//   this[1].fields.INVALID_POSITION.w = 0.0;
			//   v68 = 0LL;
			//   v5 = sub_18010B520(MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::NativeParallelHashMap.klass);
			//   Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::NativeParallelHashMap(
			//     &v68,
			//     200,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v5 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z = v68;
			//   v6 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>);
			//   v9 = v6;
			//   if ( !v6 )
			//     goto LABEL_4;
			//   UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v6,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::DynamicArray);
			//   *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z = v9;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.clothConstData.clothParam1.z,
			//     v10,
			//     v11,
			//     v12,
			//     (String__Array *)methoda,
			//     v62,
			//     (MethodInfo *)v68.m_HashMapData.m_Buffer);
			//   v68 = 0LL;
			//   v13 = sub_18010B520(MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::NativeParallelHashMap.klass);
			//   Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::NativeParallelHashMap(
			//     (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&v68,
			//     50,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v13 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.m_characterMesh = v68;
			//   v68 = 0LL;
			//   v14 = sub_18010B520(MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::NativeParallelHashMap.klass);
			//   Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::NativeParallelHashMap(
			//     (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&v68,
			//     50,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v14 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.needClearGPUBuffer = v68;
			//   this[1].fields.clothMetaDataBuffer = (ComputeBuffer *)il2cpp_array_new_specific_0(
			//                                                           TypeInfo::System::Int32,
			//                                                           50LL,
			//                                                           v15,
			//                                                           v16);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.clothMetaDataBuffer,
			//     v17,
			//     v18,
			//     v19,
			//     (String__Array *)methode,
			//     v63,
			//     (MethodInfo *)v68.m_HashMapData.m_Buffer);
			//   v20 = (IndexedHashSet_1_System_UInt32_ *)sub_180004920(TypeInfo::Beyond::IndexedHashSet<unsigned int>);
			//   v21 = (ComputeBuffer *)v20;
			//   if ( !v20 )
			//     goto LABEL_4;
			//   Beyond::IndexedHashSet<unsigned int>::IndexedHashSet(
			//     v20,
			//     50,
			//     MethodInfo::Beyond::IndexedHashSet<unsigned int>::IndexedHashSet);
			//   this[1].fields.clothBatchMetaDataBuffer = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.clothBatchMetaDataBuffer,
			//     v22,
			//     v23,
			//     v24,
			//     (String__Array *)methodb,
			//     v64,
			//     (MethodInfo *)v68.m_HashMapData.m_Buffer);
			//   v68 = 0LL;
			//   Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
			//     (NativeParallelHashSet_1_System_UInt32_ *)&v68,
			//     50,
			//     (AllocatorManager_AllocatorHandle)4,
			//     MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothBatchCacheMapBuffer = v68;
			//   v68 = 0LL;
			//   Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
			//     (NativeParallelHashSet_1_System_UInt32_ *)&v68,
			//     50,
			//     (AllocatorManager_AllocatorHandle)4,
			//     MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.renderData.isValid = v68;
			//   v25 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<unsigned int>);
			//   v26 = v25;
			//   if ( !v25
			//     || (UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//           v25,
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::DynamicArray),
			//         *(_QWORD *)&this[1].fields.renderData.clothConstData.packedDeltaT.z = v26,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this[1].fields.renderData.clothConstData.packedDeltaT.z,
			//           v27,
			//           v28,
			//           v29,
			//           (String__Array *)methodc,
			//           v65,
			//           (MethodInfo *)v68.m_HashMapData.m_Buffer),
			//         v30 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_180004920(TypeInfo::UnityEngine::Rendering::DynamicArray<unsigned int>),
			//         (v31 = v30) == 0LL) )
			//   {
			// LABEL_4:
			//     sub_180B536AC(clothMetaDataBuffer, v7);
			//   }
			//   UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
			//     v30,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::DynamicArray);
			//   *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.x = v31;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.renderData.clothConstData.clothParam1,
			//     v32,
			//     v33,
			//     v34,
			//     (String__Array *)methodd,
			//     v66,
			//     (MethodInfo *)v68.m_HashMapData.m_Buffer);
			//   *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.z = 0LL;
			//   *(_QWORD *)&this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField = 0LL;
			//   v68 = 0LL;
			//   Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
			//     (NativeParallelHashSet_1_System_UInt32_ *)&v68,
			//     50,
			//     (AllocatorManager_AllocatorHandle)4,
			//     MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.renderData.clothNodeDataBuffer = v68;
			//   v68 = 0LL;
			//   Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet(
			//     (NativeParallelHashSet_1_System_UInt32_ *)&v68,
			//     4,
			//     (AllocatorManager_AllocatorHandle)4,
			//     MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::NativeParallelHashSet);
			//   *(_QWORD *)v69 = 0LL;
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.renderData.clothBatchMetaDataBuffer = v68;
			//   memset(&v69[88], 0, 40);
			//   klass = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::NativeList.klass;
			//   v68 = 0LL;
			//   v36 = sub_18010B520(klass);
			//   Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::NativeList(
			//     (NativeList_1_HG_Rendering_Runtime_ClothGroupUploadDataMap_ *)&v68,
			//     4,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v36 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v69[8] = v68;
			//   v37 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::NativeList.klass;
			//   v68 = 0LL;
			//   v38 = sub_18010B520(v37);
			//   Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::NativeList(
			//     (NativeList_1_HG_Rendering_Runtime_ClothMetaData_ *)&v68,
			//     200,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v38 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v69[24] = v68;
			//   v39 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::NativeList.klass;
			//   v68 = 0LL;
			//   v40 = sub_18010B520(v39);
			//   Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::NativeList(
			//     (NativeList_1_HG_Rendering_Runtime_ClothNodeData_ *)&v68,
			//     680,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v40 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v69[40] = v68;
			//   v41 = MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList.klass;
			//   v68 = 0LL;
			//   v42 = sub_18010B520(v41);
			//   Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList(
			//     (NativeList_1_Unity_Mathematics_int4_ *)&v68,
			//     16,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v42 + 192));
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v69[56] = v68;
			//   v43 = MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList.klass;
			//   v68 = 0LL;
			//   v44 = sub_18010B520(v43);
			//   Unity::Collections::NativeList<Unity::Mathematics::int4>::NativeList(
			//     (NativeList_1_Unity_Mathematics_int4_ *)&v68,
			//     128,
			//     (AllocatorManager_AllocatorHandle)4,
			//     2,
			//     **(MethodInfo ***)(v44 + 192));
			//   v45 = v68;
			//   *(_OWORD *)&this[1].fields.clearBufferData.shouldClear = *(_OWORD *)v69;
			//   v46 = *(_OWORD *)&v69[32];
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v69[72] = v45;
			//   *(_OWORD *)&this[1].fields.clearBufferData.eleNum.w = *(_OWORD *)&v69[16];
			//   v47 = *(_OWORD *)&v69[48];
			//   *(_OWORD *)&this[1].fields.clearBufferData.clothBatchMetaDataBuffer = v46;
			//   v48 = *(_OWORD *)&v69[64];
			//   *(_OWORD *)&this[1].fields.isStreamingMode = v47;
			//   v49 = *(_OWORD *)&v69[80];
			//   *(_OWORD *)&this[1].fields.shouldStep = v48;
			//   v50 = *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v69[96];
			//   *(_OWORD *)&this[1].fields.windNoiseUV.x = v49;
			//   v51 = *(_OWORD *)&v69[112];
			//   this[1].fields.m_clothHashToRuntimeClothData = v50;
			//   *(_OWORD *)&this[1].fields.m_runtimeClothMetaArray = v51;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.m_runtimeClothNum,
			//     v52,
			//     v53,
			//     v54,
			//     (String__Array *)methodf,
			//     v67,
			//     (MethodInfo *)v68.m_HashMapData.m_Buffer);
			//   do
			//   {
			//     clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
			//     if ( !clothMetaDataBuffer )
			//       goto LABEL_4;
			//     if ( (unsigned int)v4 >= LODWORD(clothMetaDataBuffer[1].klass) )
			//       sub_180070270(clothMetaDataBuffer, v7);
			//     v55 = v4++;
			//     *((_DWORD *)&clothMetaDataBuffer[1].monitor + v55) = 1;
			//   }
			//   while ( v4 < 50 );
			// }
			// 
		}

		internal void Initialize(HGRenderPipelineRuntimeResources resource)
		{
			// // Void Initialize(HGRenderPipelineRuntimeResources)
			// void HG::Rendering::Runtime::GpuClothManager::Initialize(
			//         GpuClothManager *this,
			//         HGRenderPipelineRuntimeResources *resource,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineRuntimeResources_AssetResources *assets; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1140, 0LL) )
			//   {
			//     if ( resource )
			//     {
			//       assets = resource.fields.assets;
			//       if ( assets )
			//       {
			//         HG::Rendering::Runtime::GpuClothManager::_SetCharacterProxyMesh(this, assets.fields.defaultCapsuleMesh, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, assets);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1140, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)resource,
			//     0LL);
			// }
			// 
		}

		internal void Tick(float deltaTime)
		{
			// // Void Tick(Single)
			// void HG::Rendering::Runtime::GpuClothManager::Tick(GpuClothManager *this, float deltaTime, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1142 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x476 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[24]._0.properties )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1142, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//           (ILFixDynamicMethodWrapper_20 *)Patch,
			//           (Object *)this,
			//           deltaTime,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   this[1].fields.CHARACTER_POSITION_OFFSET.x = deltaTime;
			//   HG::Rendering::Runtime::GpuClothManager::_UpdateWindParams(this, 0LL);
			//   if ( LOBYTE(this[1].monitor) )
			//   {
			//     HG::Rendering::Runtime::GpuClothManager::_ProcessPendingQueue(this, 0LL);
			//     HG::Rendering::Runtime::GpuClothManager::_SetPerDrawData(this, 0LL);
			//     HG::Rendering::Runtime::GpuClothManager::_UpdateStreamingMode(this, 0LL);
			//   }
			// }
			// 
		}

		private void _UpdateWindParams()
		{
			// // Void _UpdateWindParams()
			// void HG::Rendering::Runtime::GpuClothManager::_UpdateWindParams(GpuClothManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGEnvironmentPhase *s_interpolatedPhase; // rax
			//   __m128 z_low; // xmm8
			//   __m128 w_low; // xmm9
			//   __int64 v8; // xmm7_8
			//   float z; // edi
			//   Vector2 v10; // xmm2_8
			//   __int64 v11; // rax
			//   ILFixDynamicMethodWrapper_2 *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v14; // [rsp+20h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDBFC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDBFC = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_20;
			//   if ( wrapperArray.max_length.size <= 1143 )
			//     goto LABEL_38;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_20;
			//   if ( wrapperArray.max_length.size <= 0x477u )
			//     goto LABEL_35;
			//   if ( !wrapperArray[31].vector[27] )
			//   {
			// LABEL_38:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//     s_interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
			//     z_low = (__m128)LODWORD(this[1].fields.INVALID_POSITION.z);
			//     w_low = (__m128)LODWORD(this[1].fields.INVALID_POSITION.w);
			//     this[1].fields.INVALID_POSITION.x = (float)((float)((float)(this[1].fields.INVALID_POSITION.y * 0.25) * 0.079999998)
			//                                               * this[1].fields.CHARACTER_POSITION_OFFSET.x)
			//                                       + this[1].fields.INVALID_POSITION.x;
			//     if ( !s_interpolatedPhase )
			//       goto LABEL_20;
			//     v8 = *(_QWORD *)&s_interpolatedPhase.fields.windConfig.direction.x;
			//     z = s_interpolatedPhase.fields.windConfig.direction.z;
			//     *(_QWORD *)&v14.x = v8;
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v3.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_20;
			//     if ( wrapperArray.max_length.size <= 598 )
			//     {
			// LABEL_18:
			//       v10 = (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v14.x), (__m128)_mm_cvtsi32_si128(LODWORD(z))).m128_u64[0];
			// LABEL_19:
			//       v11 = ((__int64 (__fastcall *)(_QWORD))sub_182C9F010)(v10);
			//       *(_QWORD *)&this[1].fields.INVALID_POSITION.z = sub_18473B264(_mm_unpacklo_ps(z_low, w_low).m128_u64[0], v11);
			//       return;
			//     }
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			// LABEL_20:
			//       sub_180B536AC(v3, wrapperArray);
			//     if ( LODWORD(v3._0.namespaze) > 0x256 )
			//     {
			//       if ( !*(_QWORD *)&v3[12]._1.naturalAligment )
			//         goto LABEL_18;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(598, 0LL);
			//       if ( Patch )
			//       {
			//         *(_QWORD *)&v14.x = v8;
			//         v14.z = z;
			//         v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v14, 0LL);
			//         goto LABEL_19;
			//       }
			//       goto LABEL_20;
			//     }
			// LABEL_35:
			//     sub_180070270(v3, wrapperArray);
			//   }
			//   v12 = IFix::WrappersManagerImpl::GetPatch(1143, 0LL);
			//   if ( !v12 )
			//     goto LABEL_20;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)v12, (Object *)this, 0LL);
			// }
			// 
		}

		private void _ProcessPendingQueue()
		{
			// // Void _ProcessPendingQueue()
			// void HG::Rendering::Runtime::GpuClothManager::_ProcessPendingQueue(GpuClothManager *this, MethodInfo *method)
			// {
			//   double v3; // xmm0_8
			//   float v4; // xmm1_4
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rax
			//   __int64 v8; // rax
			//   int32_t i; // edi
			//   __int64 v10; // rax
			//   DynamicArray_1_System_UInt32_ *v11; // rcx
			//   uint32_t *Item; // rax
			//   int32_t j; // edi
			//   __int64 v14; // rax
			//   DynamicArray_1_System_UInt32_ *v15; // rcx
			//   uint32_t *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   GpuClothManager_ClothGroupData_Internal v18; // [rsp+20h] [rbp-128h] BYREF
			//   __int128 v19; // [rsp+80h] [rbp-C8h]
			//   __int128 v20; // [rsp+90h] [rbp-B8h]
			//   __int128 v21; // [rsp+A0h] [rbp-A8h]
			//   GpuClothManager_ClothGroupData_Internal clothGroupData; // [rsp+B0h] [rbp-98h] BYREF
			//   __int128 v23; // [rsp+110h] [rbp-38h]
			//   __int128 v24; // [rsp+120h] [rbp-28h]
			//   __int128 v25; // [rsp+130h] [rbp-18h]
			//   __int64 v26; // [rsp+160h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919CE3 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_size);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Count);
			//     byte_18D919CE3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1144, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1144, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_23;
			//   }
			//   if ( LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) )
			//     return;
			//   if ( Unity::Collections::NativeParallelHashSet<Unity::Mathematics::int4>::Count(
			//          (NativeParallelHashSet_1_Unity_Mathematics_int4_ *)&this[1].fields.renderData.clothNodeDataBuffer,
			//          MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Count) > 0 )
			//     return;
			//   v26 = sub_18473B264(
			//           _mm_unpacklo_ps(
			//             (__m128)LODWORD(this[1].fields.renderData.clothConstData.clothParam1.z),
			//             (__m128)LODWORD(this[1].fields.renderData.clothConstData.clothParam1.w)).m128_u64[0],
			//           _mm_unpacklo_ps(
			//             (__m128)LODWORD(this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField),
			//             (__m128)*((unsigned int *)&this[1].fields.renderData.clothConstData + 9)).m128_u64[0]);
			//   v3 = sub_182413570(&v26);
			//   if ( *(float *)&v3 < 32.0 && !LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) )
			//     return;
			//   v4 = *((float *)&this[1].fields.renderData.clothConstData + 9);
			//   this[1].fields.renderData.clothConstData.clothParam1.z = this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField;
			//   this[1].fields.renderData.clothConstData.clothParam1.w = v4;
			//   HG::Rendering::Runtime::GpuClothManager::_UpdatePendingGroupHash(this, 1, 0LL);
			//   v7 = *(_QWORD *)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
			//   if ( !v7
			//     || (v6 = *(unsigned int *)(v7 + 24), (v8 = *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.x) == 0) )
			//   {
			// LABEL_23:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( (_DWORD)v6 || *(_DWORD *)(v8 + 24) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       v10 = *(_QWORD *)&this[1].fields.renderData.clothConstData.clothParam1.x;
			//       if ( !v10 )
			//         goto LABEL_23;
			//       v11 = *(DynamicArray_1_System_UInt32_ **)&this[1].fields.renderData.clothConstData.clothParam1.x;
			//       if ( i >= *(_DWORD *)(v10 + 24) )
			//         break;
			//       Item = UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item(
			//                v11,
			//                i,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item);
			//       HG::Rendering::Runtime::GpuClothManager::_DeactivateClothGroup_Internal(this, *Item, 0LL);
			//     }
			//     UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//       (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v11,
			//       MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
			//     for ( j = 0; ; ++j )
			//     {
			//       v14 = *(_QWORD *)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
			//       if ( !v14 )
			//         goto LABEL_23;
			//       v15 = *(DynamicArray_1_System_UInt32_ **)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
			//       if ( j >= *(_DWORD *)(v14 + 24) )
			//         break;
			//       v16 = UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item(
			//               v15,
			//               j,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_Item);
			//       Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
			//         &v18,
			//         (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&this[1].fields.m_characterMesh,
			//         *v16,
			//         MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
			//       clothGroupData = v18;
			//       v23 = v19;
			//       v24 = v20;
			//       v25 = v21;
			//       HG::Rendering::Runtime::GpuClothManager::_ActivateClothGroup_Internal(this, &clothGroupData, 0LL);
			//     }
			//     UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//       (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v15,
			//       MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
			//   }
			//   LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 0;
			// }
			// 
		}

		private void _SetPerDrawData()
		{
			// // Void _SetPerDrawData()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::GpuClothManager::_SetPerDrawData(GpuClothManager *this, MethodInfo *method)
			// {
			//   EntityManagerRange_Enumerator *Enumerator; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rbx
			//   bool v7; // zf
			//   EntityTypeInstanceData *v8; // rbx
			//   ECSClothDataComponent *v9; // r15
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   CommonInstanceDataComponent *v12; // r12
			//   int32_t i; // edi
			//   char *v14; // rsi
			//   bool Value; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   GpuClothManager_RuntimeClothData_Internal item; // [rsp+20h] [rbp-108h] BYREF
			//   EntityManager_1 v20; // [rsp+30h] [rbp-F8h] BYREF
			//   _BYTE v21[48]; // [rsp+40h] [rbp-E8h] BYREF
			//   __int64 v22; // [rsp+70h] [rbp-B8h]
			//   EntityManager_1 v23; // [rsp+78h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v24; // [rsp+88h] [rbp-A0h] BYREF
			//   EntityManagerRange v25; // [rsp+90h] [rbp-98h] BYREF
			//   __int128 v26; // [rsp+B0h] [rbp-78h]
			//   EntityManagerRange v27; // [rsp+C8h] [rbp-60h] BYREF
			//   __int128 v28; // [rsp+E8h] [rbp-40h]
			//   GroupType v29; // [rsp+140h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919CE4 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::ECSClothDataComponent,UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::ECSClothDataComponent>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::TryGetValue);
			//     byte_18D919CE4 = 1;
			//   }
			//   v23 = 0LL;
			//   memset(v21, 0, sizeof(v21));
			//   v22 = 0LL;
			//   *(_QWORD *)&item.isDataReady = 0LL;
			//   item.isSingleSkeleton = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1150, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1150, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v23 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v20, 0LL);
			//     UnityEngine::HyperGryph::ECS::EntityManager::Iterate<Beyond::Gameplay::Factory::UnitTransFragment,Beyond::Gameplay::Factory::CurMapUnitTag>(
			//       &v25,
			//       &v23,
			//       MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::Iterate<UnityEngine::HyperGryph::ECS::ECSClothDataComponent,UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>);
			//     v27 = v25;
			//     v28 = v26;
			//     Enumerator = UnityEngine::HyperGryph::ECS::EntityManagerRange::GetEnumerator(
			//                    (EntityManagerRange_Enumerator *)&v25,
			//                    &v27,
			//                    0LL);
			//     *(_OWORD *)v21 = *(_OWORD *)&Enumerator.m_entityTypes;
			//     *(_OWORD *)&v21[16] = *(_OWORD *)&Enumerator.m_includeComponentMask.componentMaskWords.FixedElementField;
			//     *(_OWORD *)&v21[32] = *(_OWORD *)&Enumerator.m_index;
			//     v22 = *(_QWORD *)&Enumerator[1].m_count;
			//     v20.m_entitiesPPtr = 0LL;
			//     v20.m_entityTypesPPtr = v21;
			//     try
			//     {
			//       while ( UnityEngine::HyperGryph::ECS::EntityManagerRange::Enumerator::MoveNext(
			//                 (EntityManagerRange_Enumerator *)v21,
			//                 0LL) )
			//       {
			//         v6 = 576LL * (int)v22;
			//         v7 = *(_QWORD *)v21 + v6 == 0;
			//         v8 = (EntityTypeInstanceData *)(*(_QWORD *)v21 + v6);
			//         v29.m_entityTypes = v8;
			//         if ( v7 )
			//           sub_1802DC2C8(v5, v4);
			//         v9 = UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::ECSClothDataComponent>(
			//                &v29,
			//                MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::ECSClothDataComponent>);
			//         v12 = UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>(
			//                 &v29,
			//                 MethodInfo::UnityEngine::HyperGryph::ECS::GroupType::GetComponent<UnityEngine::HyperGryph::ECS::CommonInstanceDataComponent>);
			//         for ( i = 0; ; ++i )
			//         {
			//           if ( !v8 )
			//             sub_1802DC2C8(v11, v10);
			//           if ( i >= v8.count )
			//             break;
			//           v14 = (char *)v12 + 256 * (__int64)i;
			//           Value = Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::TryGetValue(
			//                     (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z,
			//                     v9[i].clothHash,
			//                     &item,
			//                     MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::TryGetValue);
			//           *((_DWORD *)v14 + 60) = 0;
			//           if ( Value && item.isDataReady )
			//           {
			//             *((float *)v14 + 60) = item.skeletonOffset + 1.0;
			//             *((_DWORD *)v14 + 61) = LODWORD(item.isSingleSkeleton);
			//           }
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v24 )
			//     {
			//       v20.m_entitiesPPtr = v24.ex;
			//       if ( v20.m_entitiesPPtr )
			//         sub_18000F780(v20.m_entitiesPPtr);
			//     }
			//   }
			// }
			// 
		}

		private void _UpdateStreamingMode()
		{
			// // Void _UpdateStreamingMode()
			// void HG::Rendering::Runtime::GpuClothManager::_UpdateStreamingMode(GpuClothManager *this, MethodInfo *method)
			// {
			//   _BOOL8 v3; // rdi
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   LOBYTE(v3) = 1;
			//   if ( !byte_18D919CE5 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Count);
			//     byte_18D919CE5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1151, 0LL) )
			//   {
			//     if ( !Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int4,bool>::Count(
			//             (NativeParallelHashMap_2_Unity_Mathematics_int4_System_Boolean_ *)&this[1].fields.m_characterMesh,
			//             MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Count) )
			//       v3 = LODWORD(this[1].fields.clothConstData.packedDeltaT.y) != 0;
			//     if ( this )
			//     {
			//       LOBYTE(this[1].monitor) = v3;
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1151, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void _UpdatePendingGroupHash(bool needSwap)
		{
			// // Void _UpdatePendingGroupHash(Boolean)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::GpuClothManager::_UpdatePendingGroupHash(
			//         GpuClothManager *this,
			//         bool needSwap,
			//         MethodInfo *method)
			// {
			//   GpuClothManager *v4; // rdi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rsi
			//   __int64 v8; // rsi
			//   __int128 v9; // xmm1
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   int32_t j; // r14d
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   uint32_t v17; // eax
			//   __int64 v18; // rdx
			//   GpuClothManager__StaticFields *static_fields; // rcx
			//   GpuClothManager_ClothActivateComparer *s_clothActiveComparer; // rsi
			//   float v21; // xmm7_4
			//   GpuClothManager__StaticFields *v22; // rcx
			//   IComparer_1_System_UInt32_ **v23; // rdx
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   int32_t i; // r14d
			//   uint32_t Item; // eax
			//   __int64 v28; // rdx
			//   DynamicArray_1_System_UInt32_ *v29; // rcx
			//   __int64 v30; // rdx
			//   DynamicArray_1_System_UInt32_ *v31; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   Il2CppExceptionWrapper *v35; // [rsp+30h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v36; // [rsp+38h] [rbp-70h] BYREF
			//   NativeParallelHashSet_1_T_Enumerator_System_UInt32_ v37; // [rsp+40h] [rbp-68h] BYREF
			//   NativeParallelHashSet_1_T_Enumerator_System_UInt32_ data; // [rsp+58h] [rbp-50h] BYREF
			//   uint32_t value; // [rsp+C8h] [rbp+20h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D919CE6 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Add);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::get_size);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GpuClothManager);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::Sort);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Count);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Contains);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::GetEnumerator);
			//     byte_18D919CE6 = 1;
			//   }
			//   memset(&data, 0, sizeof(data));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1145, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1145, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v34, v33);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)v4, needSwap, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *(_QWORD *)&v4[1].fields.renderData.clothConstData.packedDeltaT.z;
			//     if ( !v7 )
			//       sub_180B536AC(v6, v5);
			//     if ( *(int *)(v7 + 24) <= 0 )
			//     {
			//       v8 = *(_QWORD *)&v4[1].fields.renderData.clothConstData.clothParam1.x;
			//       if ( !v8 )
			//         sub_180B536AC(v6, v5);
			//       if ( *(int *)(v8 + 24) <= 0 )
			//       {
			//         if ( needSwap )
			//         {
			//           v9 = *(_OWORD *)&v4[1].fields.renderData.isValid;
			//           *(_OWORD *)&v4[1].fields.renderData.isValid = *(_OWORD *)&v4[1].fields.clothBatchCacheMapBuffer;
			//           *(_OWORD *)&v4[1].fields.clothBatchCacheMapBuffer = v9;
			//         }
			//         Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
			//           (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
			//           MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//         if ( !v4[1].fields.clothBatchMetaDataBuffer )
			//           sub_180B536AC(v11, v10);
			//         if ( ParadoxNotion::WeakReferenceTable<System::Object,System::Object>::get_Count(
			//                (WeakReferenceTable_2_System_Object_System_Object_ *)v4[1].fields.clothBatchMetaDataBuffer,
			//                MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Count) > 50 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::GpuClothManager);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::GpuClothManager.static_fields;
			//           s_clothActiveComparer = static_fields.s_clothActiveComparer;
			//           v21 = *((float *)&v4[1].fields.renderData.clothConstData + 9);
			//           if ( !static_fields.s_clothActiveComparer )
			//             sub_180B536AC(static_fields, v18);
			//           s_clothActiveComparer.fields.playerCenterXZ.x = v4[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField;
			//           s_clothActiveComparer.fields.playerCenterXZ.y = v21;
			//           v22 = TypeInfo::HG::Rendering::Runtime::GpuClothManager.static_fields;
			//           if ( !v22.s_clothActiveComparer )
			//             sub_180B536AC(v22, v18);
			//           v22.s_clothActiveComparer.fields.registedClothGroupData = (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&v4[1].fields.m_characterMesh;
			//           v23 = (IComparer_1_System_UInt32_ **)TypeInfo::HG::Rendering::Runtime::GpuClothManager.static_fields;
			//           if ( !v4[1].fields.clothBatchMetaDataBuffer )
			//             sub_180B536AC(v22, v23);
			//           Beyond::IndexedHashSet<unsigned int>::Sort(
			//             (IndexedHashSet_1_System_UInt32_ *)v4[1].fields.clothBatchMetaDataBuffer,
			//             *v23,
			//             MethodInfo::Beyond::IndexedHashSet<unsigned int>::Sort);
			//           for ( i = 0; i < 50; ++i )
			//           {
			//             if ( !v4[1].fields.clothBatchMetaDataBuffer )
			//               sub_180B536AC(v25, v24);
			//             Item = Beyond::IndexedHashSet<unsigned int>::get_Item(
			//                      (IndexedHashSet_1_System_UInt32_ *)v4[1].fields.clothBatchMetaDataBuffer,
			//                      i,
			//                      MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Item);
			//             Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
			//               (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
			//               Item,
			//               MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//           }
			//         }
			//         else
			//         {
			//           for ( j = 0; ; ++j )
			//           {
			//             if ( !v4[1].fields.clothBatchMetaDataBuffer )
			//               sub_180B536AC(v13, v12);
			//             if ( j >= ParadoxNotion::WeakReferenceTable<System::Object,System::Object>::get_Count(
			//                         (WeakReferenceTable_2_System_Object_System_Object_ *)v4[1].fields.clothBatchMetaDataBuffer,
			//                         MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Count) )
			//               break;
			//             if ( !v4[1].fields.clothBatchMetaDataBuffer )
			//               sub_180B536AC(v16, v15);
			//             v17 = Beyond::IndexedHashSet<unsigned int>::get_Item(
			//                     (IndexedHashSet_1_System_UInt32_ *)v4[1].fields.clothBatchMetaDataBuffer,
			//                     j,
			//                     MethodInfo::Beyond::IndexedHashSet<unsigned int>::get_Item);
			//             Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
			//               (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
			//               v17,
			//               MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//           }
			//         }
			//         Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashSet<unsigned int>::GetEnumerator(
			//           (UnsafeParallelHashSet_1_T_Enumerator_System_UInt32_ *)&v37,
			//           (UnsafeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.renderData,
			//           MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::GetEnumerator);
			//         data = v37;
			//         v37.m_Enumerator.m_Buffer = 0LL;
			//         *(_QWORD *)&v37.m_Enumerator.m_Index = &data;
			//         try
			//         {
			//           while ( Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashMapData::MoveNext(
			//                     data.m_Enumerator.m_Buffer,
			//                     &data.m_Enumerator.m_BucketIndex,
			//                     &data.m_Enumerator.m_NextIndex,
			//                     &data.m_Enumerator.m_Index,
			//                     0LL) )
			//           {
			//             value = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
			//                       &data,
			//                       MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
			//             if ( !Unity::Collections::NativeParallelHashSet<unsigned int>::Contains(
			//                     (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.clothBatchCacheMapBuffer,
			//                     value,
			//                     MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Contains) )
			//             {
			//               v29 = *(DynamicArray_1_System_UInt32_ **)&v4[1].fields.renderData.clothConstData.clothParam1.x;
			//               if ( !v29 )
			//                 sub_1802DC2C8(0LL, v28);
			//               UnityEngine::Rendering::DynamicArray<unsigned int>::Add(
			//                 v29,
			//                 &value,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Add);
			//             }
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v35 )
			//         {
			//           v37.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v35.ex;
			//           if ( v37.m_Enumerator.m_Buffer )
			//             sub_18000F780(v37.m_Enumerator.m_Buffer);
			//           v4 = this;
			//         }
			//         v37.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v4[1].fields.clothBatchCacheMapBuffer;
			//         *(_QWORD *)&v37.m_Enumerator.m_Index = 0xFFFFFFFFLL;
			//         *(_QWORD *)&v37.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
			//         *(_OWORD *)&data.m_Enumerator.m_Buffer = *(_OWORD *)&v37.m_Enumerator.m_Buffer;
			//         *(_QWORD *)&data.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
			//         v37.m_Enumerator.m_Buffer = 0LL;
			//         *(_QWORD *)&v37.m_Enumerator.m_Index = &data;
			//         try
			//         {
			//           while ( Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashMapData::MoveNext(
			//                     data.m_Enumerator.m_Buffer,
			//                     &data.m_Enumerator.m_BucketIndex,
			//                     &data.m_Enumerator.m_NextIndex,
			//                     &data.m_Enumerator.m_Index,
			//                     0LL) )
			//           {
			//             value = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
			//                       &data,
			//                       MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
			//             if ( !Unity::Collections::NativeParallelHashSet<unsigned int>::Contains(
			//                     (NativeParallelHashSet_1_System_UInt32_ *)&v4[1].fields.renderData,
			//                     value,
			//                     MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Contains) )
			//             {
			//               v31 = *(DynamicArray_1_System_UInt32_ **)&v4[1].fields.renderData.clothConstData.packedDeltaT.z;
			//               if ( !v31 )
			//                 sub_1802DC2C8(0LL, v30);
			//               UnityEngine::Rendering::DynamicArray<unsigned int>::Add(
			//                 v31,
			//                 &value,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Add);
			//             }
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v36 )
			//         {
			//           v37.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v36.ex;
			//           if ( v37.m_Enumerator.m_Buffer )
			//             sub_18000F780(v37.m_Enumerator.m_Buffer);
			//         }
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void RegisterClothGroup(in ClothGroupData clothGroupData)
		{
			// // Void RegisterClothGroup(ClothGroupData ByRef)
			// void HG::Rendering::Runtime::GpuClothManager::RegisterClothGroup(
			//         GpuClothManager *this,
			//         ClothGroupData *clothGroupData,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   GpuClothManager_ClothGroupData_Internal v8; // [rsp+20h] [rbp-128h] BYREF
			//   __int128 v9; // [rsp+80h] [rbp-C8h]
			//   __int128 v10; // [rsp+90h] [rbp-B8h]
			//   __int128 v11; // [rsp+A0h] [rbp-A8h]
			//   GpuClothManager_ClothGroupData_Internal v12; // [rsp+B0h] [rbp-98h] BYREF
			//   __int128 v13; // [rsp+110h] [rbp-38h]
			//   __int128 v14; // [rsp+120h] [rbp-28h]
			//   __int128 v15; // [rsp+130h] [rbp-18h]
			// 
			//   if ( !byte_18D919CE7 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Add);
			//     byte_18D919CE7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1152, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1152, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_430(Patch, (Object *)this, clothGroupData, 0LL);
			//   }
			//   else
			//   {
			//     if ( !LOBYTE(this[1].monitor) )
			//     {
			//       HG::Rendering::Runtime::GpuClothManager::ResetCpuData(this, 0LL);
			//       HG::Rendering::Runtime::GpuClothManager::ResetStreamingResource(this, 0LL);
			//       HG::Rendering::Runtime::GpuClothManager::_InitStreamingGpuBuffer(this, 0LL);
			//       LOBYTE(this[1].monitor) = 1;
			//     }
			//     sub_1802F01E0(&v8, 0LL, 144LL);
			//     HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::CopyFromClothGroupData(&v8, clothGroupData, 0LL);
			//     v12 = v8;
			//     v13 = v9;
			//     v14 = v10;
			//     v15 = v11;
			//     sub_180638A90(
			//       &this[1].fields.m_characterMesh,
			//       clothGroupData.clothGroupMeta.clothGroupHash,
			//       &v12,
			//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Add);
			//   }
			// }
			// 
		}

		public void ActivateClothGroup(uint clothGroupHash)
		{
			// // Void ActivateClothGroup(UInt32)
			// void HG::Rendering::Runtime::GpuClothManager::ActivateClothGroup(
			//         GpuClothManager *this,
			//         uint32_t clothGroupHash,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ComputeBuffer *clothBatchMetaDataBuffer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919CE8 )
			//   {
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::Add);
			//     byte_18D919CE8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1158, 0LL) )
			//   {
			//     clothBatchMetaDataBuffer = this[1].fields.clothBatchMetaDataBuffer;
			//     if ( clothBatchMetaDataBuffer )
			//     {
			//       Beyond::IndexedHashSet<unsigned int>::Add(
			//         (IndexedHashSet_1_System_UInt32_ *)clothBatchMetaDataBuffer,
			//         clothGroupHash,
			//         MethodInfo::Beyond::IndexedHashSet<unsigned int>::Add);
			//       LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 1;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(clothBatchMetaDataBuffer, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1158, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//     (ILFixDynamicMethodWrapper_26 *)Patch,
			//     (Object *)this,
			//     clothGroupHash,
			//     0LL);
			// }
			// 
		}

		private void _ActivateClothGroup_Internal(ref GpuClothManager.ClothGroupData_Internal clothGroupData)
		{
			// // Void _ActivateClothGroup_Internal(GpuClothManager+ClothGroupData_Internal ByRef)
			// void HG::Rendering::Runtime::GpuClothManager::_ActivateClothGroup_Internal(
			//         GpuClothManager *this,
			//         GpuClothManager_ClothGroupData_Internal *clothGroupData,
			//         MethodInfo *method)
			// {
			//   int32_t updated; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919CE9 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//     byte_18D919CE9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1148, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1148, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_427(Patch, (Object *)this, clothGroupData, 0LL);
			//   }
			//   else
			//   {
			//     updated = HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeGroupMeta(
			//                 this,
			//                 &clothGroupData.clothGroupMeta,
			//                 clothGroupData.groupClothBatchCacheBytes,
			//                 0LL);
			//     HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeBuffer(this, updated, clothGroupData, 0LL);
			//     Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
			//       (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData.clothNodeDataBuffer,
			//       clothGroupData.clothGroupMeta.clothGroupHash,
			//       MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//     LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) = 1;
			//   }
			// }
			// 
		}

		public void DeactivateClothGroup(uint clothGroupHash)
		{
			// // Void DeactivateClothGroup(UInt32)
			// void HG::Rendering::Runtime::GpuClothManager::DeactivateClothGroup(
			//         GpuClothManager *this,
			//         uint32_t clothGroupHash,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ComputeBuffer *clothBatchMetaDataBuffer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919CEA )
			//   {
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::Remove);
			//     byte_18D919CEA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1159, 0LL) )
			//   {
			//     clothBatchMetaDataBuffer = this[1].fields.clothBatchMetaDataBuffer;
			//     if ( clothBatchMetaDataBuffer )
			//     {
			//       Beyond::IndexedHashSet<unsigned int>::Remove(
			//         (IndexedHashSet_1_System_UInt32_ *)clothBatchMetaDataBuffer,
			//         clothGroupHash,
			//         MethodInfo::Beyond::IndexedHashSet<unsigned int>::Remove);
			//       LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 1;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(clothBatchMetaDataBuffer, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1159, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//     (ILFixDynamicMethodWrapper_26 *)Patch,
			//     (Object *)this,
			//     clothGroupHash,
			//     0LL);
			// }
			// 
		}

		private void _DeactivateClothGroup_Internal(uint clothGroupHash)
		{
			// // Void _DeactivateClothGroup_Internal(UInt32)
			// void HG::Rendering::Runtime::GpuClothManager::_DeactivateClothGroup_Internal(
			//         GpuClothManager *this,
			//         uint32_t clothGroupHash,
			//         MethodInfo *method)
			// {
			//   int32_t clothNum; // esi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ClothGroupMeta_clothHashes_e_FixedBuffer *p_clothHashes; // r14
			//   __int64 v9; // r15
			//   ComputeBuffer *clothMetaDataBuffer; // rax
			//   int v11; // r15d
			//   int32_t *i; // rsi
			//   int32_t v13; // r14d
			//   DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ *v14; // rax
			//   unsigned int w; // r12d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _OWORD v17[6]; // [rsp+20h] [rbp-E0h] BYREF
			//   int v18; // [rsp+80h] [rbp-80h]
			//   GpuClothManager_ClothGroupMeta_Internal item; // [rsp+90h] [rbp-70h] BYREF
			//   unsigned int v20; // [rsp+E0h] [rbp-20h]
			//   char v21; // [rsp+E4h] [rbp-1Ch] BYREF
			//   _OWORD v22[6]; // [rsp+100h] [rbp+0h] BYREF
			//   int v23; // [rsp+160h] [rbp+60h]
			// 
			//   if ( !byte_18D919CEB )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_size);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::SwapAndRemove<HG::Rendering::Runtime::ClothMetaData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<unsigned int>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Remove);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::set_Item);
			//     sub_18003C530(&off_18D532580);
			//     sub_18003C530(&off_18D532590);
			//     byte_18D919CEB = 1;
			//   }
			//   sub_1802F01E0(&item, 0LL, 100LL);
			//   sub_1802F01E0(v17, 0LL, 100LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1146, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1146, 0LL);
			//     if ( !Patch )
			//       goto LABEL_26;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       clothGroupHash,
			//       0LL);
			//   }
			//   else if ( Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue(
			//               (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&this[1].fields.needClearGPUBuffer,
			//               clothGroupHash,
			//               &item,
			//               MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue) )
			//   {
			//     --LODWORD(this[1].fields.clothConstData.packedDeltaT.y);
			//     clothNum = item.clothGroupMeta.clothNum;
			//     LODWORD(this[1].fields.clothConstData.packedDeltaT.x) -= item.clothGroupMeta.clothNum;
			//     Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove(
			//       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.needClearGPUBuffer,
			//       clothGroupHash,
			//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Remove);
			//     if ( clothNum > 0 )
			//     {
			//       p_clothHashes = &item.clothGroupMeta.clothHashes;
			//       v9 = (unsigned int)clothNum;
			//       do
			//       {
			//         Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove(
			//           (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z,
			//           p_clothHashes.FixedElementField,
			//           MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove);
			//         ++p_clothHashes;
			//         --v9;
			//       }
			//       while ( v9 );
			//     }
			//     clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
			//     if ( !clothMetaDataBuffer )
			//       goto LABEL_26;
			//     if ( v20 >= LODWORD(clothMetaDataBuffer[1].klass) )
			//       sub_180070270((int)v20, v6);
			//     v11 = 0;
			//     *((_DWORD *)&clothMetaDataBuffer[1].monitor + (int)v20) = 1;
			//     if ( clothNum > 0 )
			//     {
			//       for ( i = (int32_t *)&v21; ; ++i )
			//       {
			//         v13 = *i;
			//         HG::Rendering::Runtime::GpuClothUtils::SwapAndRemove<HG::Rendering::Runtime::ClothMetaData>(
			//           *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z,
			//           *i,
			//           MethodInfo::HG::Rendering::Runtime::GpuClothUtils::SwapAndRemove<HG::Rendering::Runtime::ClothMetaData>);
			//         v14 = *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z;
			//         *i = -1;
			//         LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) = 1;
			//         if ( !v14 )
			//           break;
			//         if ( v13 != v14.fields._size_k__BackingField )
			//         {
			//           w = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item(
			//                 v14,
			//                 v13,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item).groupOffset.w;
			//           if ( w == item.clothGroupMeta.clothGroupHash )
			//           {
			//             v6 = *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z;
			//             if ( !v6 )
			//               break;
			//             HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx(
			//               &item,
			//               *(_DWORD *)(v6 + 24),
			//               v13,
			//               0LL);
			//           }
			//           else if ( Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue(
			//                       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&this[1].fields.needClearGPUBuffer,
			//                       w,
			//                       (GpuClothManager_ClothGroupMeta_Internal *)v17,
			//                       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue) )
			//           {
			//             v6 = *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z;
			//             if ( !v6 )
			//               break;
			//             HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx(
			//               (GpuClothManager_ClothGroupMeta_Internal *)v17,
			//               *(_DWORD *)(v6 + 24),
			//               v13,
			//               0LL);
			//             v22[0] = v17[0];
			//             v22[1] = v17[1];
			//             v22[2] = v17[2];
			//             v22[3] = v17[3];
			//             v22[4] = v17[4];
			//             v22[5] = v17[5];
			//             v23 = v18;
			//             sub_180638CD8(
			//               &this[1].fields.needClearGPUBuffer,
			//               w,
			//               v22,
			//               MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::set_Item);
			//           }
			//           else
			//           {
			//             HG::Rendering::HGRPLogger::LogError<unsigned int>(
			//               (String *)"Cloth group {0} not exist!",
			//               clothGroupHash,
			//               MethodInfo::HG::Rendering::HGRPLogger::LogError<unsigned int>);
			//           }
			//         }
			//         if ( ++v11 >= item.clothGroupMeta.clothNum )
			//           return;
			//       }
			// LABEL_26:
			//       sub_180B536AC(v7, v6);
			//     }
			//   }
			//   else
			//   {
			//     HG::Rendering::HGRPLogger::LogError<unsigned int>(
			//       (String *)"Cloth group ({0}) not exist when unregistering",
			//       clothGroupHash,
			//       MethodInfo::HG::Rendering::HGRPLogger::LogError<unsigned int>);
			//   }
			// }
			// 
		}

		public void UnregisterClothGroup(uint clothGroupHash)
		{
			// // Void UnregisterClothGroup(UInt32)
			// void HG::Rendering::Runtime::GpuClothManager::UnregisterClothGroup(
			//         GpuClothManager *this,
			//         uint32_t clothGroupHash,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   GpuClothManager_ClothGroupData_Internal v8; // [rsp+20h] [rbp-128h] BYREF
			//   __int128 v9; // [rsp+80h] [rbp-C8h]
			//   __int128 v10; // [rsp+90h] [rbp-B8h]
			//   __int128 v11; // [rsp+A0h] [rbp-A8h]
			//   GpuClothManager_ClothGroupData_Internal v12; // [rsp+B0h] [rbp-98h] BYREF
			//   __int128 v13; // [rsp+110h] [rbp-38h]
			//   __int128 v14; // [rsp+120h] [rbp-28h]
			//   __int128 v15; // [rsp+130h] [rbp-18h]
			// 
			//   if ( !byte_18D919CEC )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Remove);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
			//     byte_18D919CEC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1160, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1160, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       clothGroupHash,
			//       0LL);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
			//       &v8,
			//       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&this[1].fields.m_characterMesh,
			//       clothGroupHash,
			//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
			//     v12 = v8;
			//     v13 = v9;
			//     v14 = v10;
			//     v15 = v11;
			//     HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::Reset(&v12, 0LL);
			//     Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Remove(
			//       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.m_characterMesh,
			//       clothGroupHash,
			//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Remove);
			//   }
			// }
			// 
		}

		public void SetPlayerCenter(Vector3 playerCenter)
		{
			// // Void SetPlayerCenter(Vector3)
			// void HG::Rendering::Runtime::GpuClothManager::SetPlayerCenter(
			//         GpuClothManager *this,
			//         Vector3 *playerCenter,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1162, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1162, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v5);
			//     z = playerCenter.z;
			//     *(_QWORD *)&v8.x = *(_QWORD *)&playerCenter.x;
			//     v8.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, &v8, 0LL);
			//   }
			//   else
			//   {
			//     this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField = playerCenter.x;
			//     *((_DWORD *)&this[1].fields.renderData.clothConstData + 9) = LODWORD(playerCenter.z);
			//   }
			// }
			// 
		}

		public void UpdateCharacterPositions(List<Vector3> characterPositions)
		{
			// // Void UpdateCharacterPositions(List`1[UnityEngine.Vector3])
			// void HG::Rendering::Runtime::GpuClothManager::UpdateCharacterPositions(
			//         GpuClothManager *this,
			//         List_1_UnityEngine_Vector3_ *characterPositions,
			//         MethodInfo *method)
			// {
			//   TileBase *wrapperArray; // rdx
			//   int *static_fields; // rcx
			//   Vector3Int *v7; // r8
			//   struct ILFixDynamicMethodWrapper_2__Class *v8; // r9
			//   int32_t v9; // ebx
			//   __int64 v10; // rdi
			//   int32_t v11; // r14d
			//   __int64 v12; // rdx
			//   MethodInfo *v13; // r9
			//   float v14; // xmm0_4
			//   __int64 v15; // xmm6_8
			//   float v16; // esi
			//   __m128 v17; // xmm3
			//   __m128 v18; // xmm3
			//   __m128 v19; // xmm3
			//   Vector4 v20; // xmm3
			//   __int64 v21; // rdx
			//   MethodInfo *v22; // r9
			//   Vector4 v23; // xmm6
			//   __m128 v24; // xmm3
			//   __m128 v25; // xmm3
			//   __m128 v26; // xmm3
			//   __m128 v27; // xmm3
			//   Vector4 v28; // xmm3
			//   __int64 v29; // rdx
			//   __int64 v30; // r8
			//   Vector4 v31; // xmm6
			//   float x; // xmm11_4
			//   float v33; // xmm9_4
			//   float v34; // xmm8_4
			//   float z; // xmm6_4
			//   float v36; // xmm7_4
			//   float v37; // xmm10_4
			//   struct Math__Class *v38; // rcx
			//   __m128d v39; // xmm1
			//   double v40; // xmm0_8
			//   float v41; // xmm6_4
			//   __int64 v42; // xmm6_8
			//   float v43; // esi
			//   struct ILFixDynamicMethodWrapper_2__Class *v44; // r9
			//   __m128 v45; // xmm3
			//   __m128 v46; // xmm3
			//   __m128 v47; // xmm3
			//   __m128 v48; // xmm3
			//   Vector4 v49; // xmm6
			//   __int64 v50; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v52; // rax
			//   ILFixDynamicMethodWrapper_2 *v53; // rax
			//   __int64 v54; // rax
			//   ILFixDynamicMethodWrapper_2 *v55; // rax
			//   __int64 v56; // rax
			//   ILFixDynamicMethodWrapper_2 *v57; // rax
			//   Vector3 *v58; // rax
			//   __int64 v59; // rax
			//   ILFixDynamicMethodWrapper_2 *v60; // rax
			//   ILFixDynamicMethodWrapper_2 *v61; // rax
			//   Vector4 *v62; // rax
			//   ILFixDynamicMethodWrapper_2 *v63; // rax
			//   ILFixDynamicMethodWrapper_2 *v64; // rax
			//   ILFixDynamicMethodWrapper_2 *v65; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-E0h]
			//   __m128 CHARACTER_POSITION_OFFSET; // [rsp+30h] [rbp-D0h] BYREF
			//   Vector4 v68; // [rsp+40h] [rbp-C0h] BYREF
			//   Vector4 v69; // [rsp+50h] [rbp-B0h]
			//   Vector4 v70; // [rsp+60h] [rbp-A0h]
			//   Vector4 v71; // [rsp+70h] [rbp-90h]
			//   Vector3 v72; // [rsp+80h] [rbp-80h] BYREF
			//   float v73[4]; // [rsp+90h] [rbp-70h]
			//   Vector3 v74; // [rsp+A0h] [rbp-60h] BYREF
			//   float v75[4]; // [rsp+B0h] [rbp-50h]
			//   float v76[4]; // [rsp+C0h] [rbp-40h]
			//   Vector3 v77; // [rsp+D0h] [rbp-30h] BYREF
			//   TileAnimationData v78; // [rsp+E0h] [rbp-20h] BYREF
			//   Vector4 v79; // [rsp+F0h] [rbp-10h] BYREF
			//   Vector4 v80; // [rsp+100h] [rbp+0h] BYREF
			//   Vector4 v81; // [rsp+110h] [rbp+10h] BYREF
			//   Vector4 v82; // [rsp+120h] [rbp+20h] BYREF
			//   Vector4 v83; // [rsp+130h] [rbp+30h] BYREF
			//   Vector4 v84; // [rsp+140h] [rbp+40h] BYREF
			// 
			//   if ( !byte_18D8EDBFD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     byte_18D8EDBFD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1163, 0LL) )
			//   {
			//     v9 = 0;
			//     v10 = 0LL;
			//     if ( characterPositions )
			//     {
			//       while ( 1 )
			//       {
			//         v11 = 3 * v9;
			//         if ( v9 >= characterPositions.fields._size )
			//         {
			//           HG::Rendering::Runtime::ClothConstData::SetSingleFloat(&this.fields.clothConstData, v11, 3, -1.0, 0LL);
			//         }
			//         else
			//         {
			//           CHARACTER_POSITION_OFFSET = *(__m128 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                    &v78,
			//                                                    wrapperArray,
			//                                                    v7,
			//                                                    (ITilemap *)v8,
			//                                                    methoda);
			//           if ( !byte_18D8EDC37 )
			//           {
			//             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//             byte_18D8EDC37 = 1;
			//           }
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v12);
			//           static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           wrapperArray = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//           if ( !wrapperArray )
			//             break;
			//           if ( SLODWORD(wrapperArray[1].klass) <= 1117 )
			//             goto LABEL_12;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//           static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//           v50 = *(_QWORD *)static_fields;
			//           if ( !*(_QWORD *)static_fields )
			//             break;
			//           if ( *(_DWORD *)(v50 + 24) <= 0x45Du )
			//             goto LABEL_81;
			//           if ( *(_QWORD *)(v50 + 8968) )
			//           {
			//             Patch = IFix::WrappersManagerImpl::GetPatch(1117, 0LL);
			//             if ( !Patch )
			//               break;
			//             v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_410(Patch, &this.fields.clothConstData, v11, 3, 0LL);
			//           }
			//           else
			//           {
			// LABEL_12:
			//             v14 = *((float *)&(&this.fields.m_characterMesh)[6 * v10] + 1);
			//           }
			//           if ( v14 < 0.0 )
			//           {
			//             v41 = CHARACTER_POSITION_OFFSET.m128_f32[3];
			//             v37 = CHARACTER_POSITION_OFFSET.m128_f32[2];
			//             v33 = CHARACTER_POSITION_OFFSET.m128_f32[1];
			//             x = CHARACTER_POSITION_OFFSET.m128_f32[0];
			//           }
			//           else
			//           {
			//             if ( (unsigned int)v9 >= characterPositions.fields._size )
			//               goto LABEL_139;
			//             wrapperArray = (TileBase *)characterPositions.fields._items;
			//             if ( !wrapperArray )
			//               break;
			//             if ( (unsigned int)v9 >= LODWORD(wrapperArray[1].klass) )
			//               goto LABEL_81;
			//             v15 = *(__int64 *)((char *)&wrapperArray[1].monitor + 12 * v9);
			//             v16 = *((float *)&wrapperArray[1].fields._._.m_CachedPtr + 3 * v9);
			//             *(_QWORD *)v73 = v15;
			//             if ( !byte_18D8EDC37 )
			//             {
			//               sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//               byte_18D8EDC37 = 1;
			//             }
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             wrapperArray = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//             if ( !wrapperArray )
			//               break;
			//             if ( SLODWORD(wrapperArray[1].klass) <= 1164 )
			//               goto LABEL_23;
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//             v52 = *(_QWORD *)static_fields;
			//             if ( !*(_QWORD *)static_fields )
			//               break;
			//             if ( *(_DWORD *)(v52 + 24) <= 0x48Cu )
			//               goto LABEL_81;
			//             if ( *(_QWORD *)(v52 + 9344) )
			//             {
			//               v53 = IFix::WrappersManagerImpl::GetPatch(1164, 0LL);
			//               if ( !v53 )
			//                 break;
			//               *(_QWORD *)&v72.x = v15;
			//               v72.z = v16;
			//               v20 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v79, v53, &v72, 0LL);
			//             }
			//             else
			//             {
			// LABEL_23:
			//               v17 = _mm_shuffle_ps((__m128)LODWORD(v73[0]), (__m128)LODWORD(v73[0]), 225);
			//               v17.m128_f32[0] = v73[1];
			//               v18 = _mm_shuffle_ps(v17, v17, 198);
			//               v18.m128_f32[0] = v16;
			//               v19 = _mm_shuffle_ps(v18, v18, 39);
			//               v19.m128_f32[0] = v73[0];
			//               v20 = (Vector4)_mm_shuffle_ps(v19, v19, 57);
			//             }
			//             CHARACTER_POSITION_OFFSET = (__m128)this.fields.CHARACTER_POSITION_OFFSET;
			//             v68 = v20;
			//             v23 = *UnityEngine::Vector4::op_Addition(&v80, &v68, (Vector4 *)&CHARACTER_POSITION_OFFSET, v13);
			//             if ( !byte_18D8EDC37 )
			//             {
			//               sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//               byte_18D8EDC37 = 1;
			//             }
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v21);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             wrapperArray = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//             if ( !wrapperArray )
			//               break;
			//             if ( SLODWORD(wrapperArray[1].klass) <= 1115 )
			//               goto LABEL_30;
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//             v54 = *(_QWORD *)static_fields;
			//             if ( !*(_QWORD *)static_fields )
			//               break;
			//             if ( *(_DWORD *)(v54 + 24) <= 0x45Bu )
			//               goto LABEL_81;
			//             if ( *(_QWORD *)(v54 + 8952) )
			//             {
			//               v55 = IFix::WrappersManagerImpl::GetPatch(1115, 0LL);
			//               if ( !v55 )
			//                 break;
			//               v28 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_408(
			//                        &v81,
			//                        v55,
			//                        &this.fields.clothConstData,
			//                        3 * v9,
			//                        0LL);
			//             }
			//             else
			//             {
			// LABEL_30:
			//               v24 = (__m128)*((unsigned int *)&this.fields.clothConstData.colliderInfoArray.FixedElementField + 12 * v10);
			//               v25 = _mm_shuffle_ps(v24, v24, 225);
			//               v25.m128_f32[0] = *((float *)&this.fields.clothConstData + 12 * v10 + 9);
			//               v26 = _mm_shuffle_ps(v25, v25, 198);
			//               v26.m128_f32[0] = *(float *)&(&this.fields.m_characterMesh)[6 * v10];
			//               v27 = _mm_shuffle_ps(v26, v26, 39);
			//               v27.m128_f32[0] = *((float *)&(&this.fields.m_characterMesh)[6 * v10] + 1);
			//               v28 = (Vector4)_mm_shuffle_ps(v27, v27, 57);
			//             }
			//             CHARACTER_POSITION_OFFSET = (__m128)v23;
			//             v68 = v28;
			//             v31 = *UnityEngine::Vector4::op_Subtraction(&v82, (Vector4 *)&CHARACTER_POSITION_OFFSET, &v68, v22);
			//             if ( !byte_18D8EDC37 )
			//             {
			//               sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//               byte_18D8EDC37 = 1;
			//             }
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v29);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             wrapperArray = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//             if ( !wrapperArray )
			//               break;
			//             if ( SLODWORD(wrapperArray[1].klass) <= 1165 )
			//               goto LABEL_37;
			//             if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//             v56 = *(_QWORD *)static_fields;
			//             if ( !*(_QWORD *)static_fields )
			//               break;
			//             if ( *(_DWORD *)(v56 + 24) <= 0x48Du )
			//               goto LABEL_81;
			//             if ( *(_QWORD *)(v56 + 9352) )
			//             {
			//               v57 = IFix::WrappersManagerImpl::GetPatch(1165, 0LL);
			//               v69.x = v31.x;
			//               LODWORD(v33) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 85).m128_u32[0];
			//               LODWORD(v37) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 170).m128_u32[0];
			//               x = v31.x;
			//               LODWORD(v69.w) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 255).m128_u32[0];
			//               *(_QWORD *)&v69.y = __PAIR64__(LODWORD(v37), LODWORD(v33));
			//               if ( !v57 )
			//                 break;
			//               v68 = v69;
			//               v58 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v77, v57, &v68, 0LL);
			//               z = v58.z;
			//               *(_QWORD *)v76 = *(_QWORD *)&v58.x;
			//               v34 = v76[0];
			//               LODWORD(v36) = _mm_shuffle_ps((__m128)*(unsigned __int64 *)v76, (__m128)*(unsigned __int64 *)v76, 85).m128_u32[0];
			//             }
			//             else
			//             {
			// LABEL_37:
			//               x = v31.x;
			//               LODWORD(v33) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 85).m128_u32[0];
			//               v34 = v31.x;
			//               LODWORD(z) = _mm_shuffle_ps((__m128)v31, (__m128)v31, 170).m128_u32[0];
			//               v36 = v33;
			//               v37 = z;
			//             }
			//             if ( !byte_18D8E3AA7 )
			//             {
			//               sub_18003C530(&TypeInfo::System::Math);
			//               byte_18D8E3AA7 = 1;
			//             }
			//             v38 = TypeInfo::System::Math;
			//             if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::System::Math, wrapperArray);
			//             v39 = 0LL;
			//             v39.m128d_f64[0] = (float)((float)((float)(v36 * v36) + (float)(v34 * v34)) + (float)(z * z));
			//             if ( v39.m128d_f64[0] < 0.0 )
			//               v40 = sub_1801C22C0(v38, wrapperArray, v30);
			//             else
			//               *(_QWORD *)&v40 = *(_OWORD *)&_mm_sqrt_pd(v39);
			//             v41 = v40;
			//           }
			//           if ( !byte_18D8EDC37 )
			//           {
			//             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//             byte_18D8EDC37 = 1;
			//           }
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//           static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           wrapperArray = (TileBase *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//           if ( !wrapperArray )
			//             break;
			//           if ( SLODWORD(wrapperArray[1].klass) <= 1114 )
			//             goto LABEL_51;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//           static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//           v59 = *(_QWORD *)static_fields;
			//           if ( !*(_QWORD *)static_fields )
			//             break;
			//           if ( *(_DWORD *)(v59 + 24) <= 0x45Au )
			//             goto LABEL_81;
			//           if ( *(_QWORD *)(v59 + 8944) )
			//           {
			//             v60 = IFix::WrappersManagerImpl::GetPatch(1114, 0LL);
			//             *(_QWORD *)&v70.x = __PAIR64__(LODWORD(v33), LODWORD(x));
			//             *(_QWORD *)&v70.z = __PAIR64__(LODWORD(v41), LODWORD(v37));
			//             if ( !v60 )
			//               break;
			//             v68 = v70;
			//             IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(v60, &this.fields.clothConstData, 3 * v9 + 1, &v68, 0LL);
			//           }
			//           else
			//           {
			// LABEL_51:
			//             *(&this.fields.m_capsuleRadius + 12 * v10) = x;
			//             *(&this.fields.m_capsuleHeight + 12 * v10) = v33;
			//             *((float *)&this.fields.needClearGPUBuffer + 12 * v10) = v37;
			//             *((float *)&this.fields.needClearGPUBuffer + 12 * v10 + 1) = v41;
			//           }
			//           if ( (unsigned int)v9 >= characterPositions.fields._size )
			// LABEL_139:
			//             System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//           wrapperArray = (TileBase *)characterPositions.fields._items;
			//           if ( !wrapperArray )
			//             break;
			//           if ( (unsigned int)v9 >= LODWORD(wrapperArray[1].klass) )
			//             goto LABEL_81;
			//           v42 = *(__int64 *)((char *)&wrapperArray[1].monitor + 12 * v9);
			//           v43 = *((float *)&wrapperArray[1].fields._._.m_CachedPtr + 3 * v9);
			//           *(_QWORD *)v75 = v42;
			//           if ( !byte_18D8EDC37 )
			//           {
			//             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//             byte_18D8EDC37 = 1;
			//           }
			//           v44 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//             v44 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           static_fields = (int *)v44.static_fields.wrapperArray;
			//           if ( !static_fields )
			//             break;
			//           if ( static_fields[6] <= 1164 )
			//             goto LABEL_61;
			//           if ( !v44._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v44, wrapperArray);
			//             v44 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           static_fields = (int *)v44.static_fields.wrapperArray;
			//           if ( !static_fields )
			//             break;
			//           if ( (unsigned int)static_fields[6] <= 0x48C )
			//             goto LABEL_81;
			//           if ( *((_QWORD *)static_fields + 1168) )
			//           {
			//             v61 = IFix::WrappersManagerImpl::GetPatch(1164, 0LL);
			//             if ( !v61 )
			//               break;
			//             *(_QWORD *)&v74.x = v42;
			//             v74.z = v43;
			//             v62 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v83, v61, &v74, 0LL);
			//             v44 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             v48 = *(__m128 *)v62;
			//           }
			//           else
			//           {
			// LABEL_61:
			//             v45 = _mm_shuffle_ps((__m128)LODWORD(v75[0]), (__m128)LODWORD(v75[0]), 225);
			//             v45.m128_f32[0] = v75[1];
			//             v46 = _mm_shuffle_ps(v45, v45, 198);
			//             v46.m128_f32[0] = v43;
			//             v47 = _mm_shuffle_ps(v46, v46, 39);
			//             v47.m128_f32[0] = v75[0];
			//             v48 = _mm_shuffle_ps(v47, v47, 57);
			//           }
			//           v68 = this.fields.CHARACTER_POSITION_OFFSET;
			//           CHARACTER_POSITION_OFFSET = v48;
			//           v49 = *UnityEngine::Vector4::op_Addition(&v84, (Vector4 *)&CHARACTER_POSITION_OFFSET, &v68, (MethodInfo *)v44);
			//           if ( !byte_18D8EDC37 )
			//           {
			//             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//             v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             byte_18D8EDC37 = 1;
			//           }
			//           if ( !v8._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v8, wrapperArray);
			//             v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           static_fields = (int *)v8.static_fields.wrapperArray;
			//           if ( !static_fields )
			//             break;
			//           if ( static_fields[6] <= 1114 )
			//             goto LABEL_68;
			//           if ( !v8._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v8, wrapperArray);
			//             v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           static_fields = (int *)v8.static_fields.wrapperArray;
			//           if ( !static_fields )
			//             break;
			//           if ( (unsigned int)static_fields[6] <= 0x45A )
			//             goto LABEL_81;
			//           if ( *((_QWORD *)static_fields + 1118) )
			//           {
			//             v63 = IFix::WrappersManagerImpl::GetPatch(1114, 0LL);
			//             v71.x = v49.x;
			//             LODWORD(v71.w) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 255).m128_u32[0];
			//             LODWORD(v71.y) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 85).m128_u32[0];
			//             LODWORD(v71.z) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 170).m128_u32[0];
			//             if ( !v63 )
			//               break;
			//             v68 = v71;
			//             IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(v63, &this.fields.clothConstData, 3 * v9, &v68, 0LL);
			//           }
			//           else
			//           {
			// LABEL_68:
			//             *((_DWORD *)&this.fields.clothConstData.colliderInfoArray.FixedElementField + 12 * v10) = LODWORD(v49.x);
			//             *((_DWORD *)&this.fields.clothConstData + 12 * v10 + 9) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 85).m128_u32[0];
			//             LODWORD((&this.fields.m_characterMesh)[6 * v10]) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 170).m128_u32[0];
			//             HIDWORD((&this.fields.m_characterMesh)[6 * v10]) = _mm_shuffle_ps((__m128)v49, (__m128)v49, 255).m128_u32[0];
			//           }
			//           if ( !byte_18D8EDC37 )
			//           {
			//             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//             byte_18D8EDC37 = 1;
			//           }
			//           static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           wrapperArray = (TileBase *)**((_QWORD **)static_fields + 23);
			//           if ( !wrapperArray )
			//             break;
			//           if ( SLODWORD(wrapperArray[1].klass) <= 1116 )
			//             goto LABEL_75;
			//           if ( !static_fields[56] )
			//           {
			//             il2cpp_runtime_class_init_0(static_fields, wrapperArray);
			//             static_fields = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           static_fields = (int *)**((_QWORD **)static_fields + 23);
			//           if ( !static_fields )
			//             break;
			//           if ( (unsigned int)static_fields[6] <= 0x45C )
			// LABEL_81:
			//             sub_180070270(static_fields, wrapperArray);
			//           if ( *((_QWORD *)static_fields + 1120) )
			//           {
			//             v64 = IFix::WrappersManagerImpl::GetPatch(1116, 0LL);
			//             if ( !v64 )
			//               break;
			//             IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_409(v64, &this.fields.clothConstData, 3 * v9, 3, 1.0, 0LL);
			//           }
			//           else
			//           {
			// LABEL_75:
			//             HIDWORD((&this.fields.m_characterMesh)[6 * v10]) = 1065353216;
			//           }
			//         }
			//         ++v9;
			//         ++v10;
			//         if ( v9 >= 4 )
			//           return;
			//       }
			//     }
			// LABEL_78:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   v65 = IFix::WrappersManagerImpl::GetPatch(1163, 0LL);
			//   if ( !v65 )
			//     goto LABEL_78;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)v65,
			//     (Object *)this,
			//     (Object *)characterPositions,
			//     0LL);
			// }
			// 
		}

		internal void UpdateTimer()
		{
			// // Void UpdateTimer()
			// void HG::Rendering::Runtime::GpuClothManager::UpdateTimer(GpuClothManager *this, MethodInfo *method)
			// {
			//   float v2; // xmm1_4
			//   System::MathF *v4; // rcx
			//   float v5; // xmm6_4
			//   float v6; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1166, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1166, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) = 0;
			//     if ( HG::Rendering::Runtime::GpuClothManager::IsClothSkeletonValid(this, 0LL) )
			//     {
			//       v5 = this[1].fields.CHARACTER_POSITION_OFFSET.y + this[1].fields.CHARACTER_POSITION_OFFSET.x;
			//       this[1].fields.CHARACTER_POSITION_OFFSET.y = v5;
			//       if ( v5 >= 0.023333333 )
			//       {
			//         System::MathF::Floor(v4, v2);
			//         v6 = fminf(v5 / 0.023333333, 2.0);
			//         this[1].fields.CHARACTER_POSITION_OFFSET.w = v6;
			//         LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) = 1;
			//         this[1].fields.CHARACTER_POSITION_OFFSET.y = v5 - (float)(v6 * 0.023333333);
			//       }
			//     }
			//   }
			// }
			// 
		}

		internal GpuClothRenderData GetRenderData()
		{
			// // GpuClothRenderData GetRenderData()
			// GpuClothRenderData *HG::Rendering::Runtime::GpuClothManager::GetRenderData(
			//         GpuClothRenderData *__return_ptr retstr,
			//         GpuClothManager *this,
			//         MethodInfo *method)
			// {
			//   Vector4 v5; // xmm1
			//   __int128 v6; // xmm0
			//   __int128 v7; // xmm1
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   Vector4 v11; // xmm1
			//   Vector4 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   Vector4 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   Vector4 v24; // xmm1
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   OneofDescriptorProto *v30; // rdx
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   UnsafeList_1_Unity_Mathematics_int4_ *v33; // r9
			//   OneofDescriptorProto *v34; // rdx
			//   FileDescriptor *v35; // r8
			//   MessageDescriptor *v36; // r9
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   UnsafeList_1_Unity_Mathematics_int4_ *windNoiseUV; // r9
			//   OneofDescriptorProto *v40; // rdx
			//   FileDescriptor *v41; // r8
			//   MessageDescriptor *v42; // r9
			//   OneofDescriptorProto *v43; // rdx
			//   FileDescriptor *v44; // r8
			//   GpuClothRenderData *v45; // rax
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *p_m_clothHashToRuntimeClothData; // rcx
			//   __int64 v47; // rdx
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v48; // xmm1
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v49; // xmm0
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v50; // xmm1
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v51; // xmm0
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v52; // xmm1
			//   Vector4 v53; // xmm0
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ v54; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   GpuClothRenderData *v58; // rax
			//   __int64 v59; // rdx
			//   GpuClothRenderData *v60; // rcx
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm0
			//   __int128 v65; // xmm1
			//   Vector4 packedDeltaT; // xmm0
			//   Vector4 clothParam1; // xmm1
			//   Vector4 v69; // [rsp+20h] [rbp-118h] BYREF
			//   Vector4 v70; // [rsp+30h] [rbp-108h]
			//   __int128 v71; // [rsp+40h] [rbp-F8h]
			//   __int128 v72; // [rsp+50h] [rbp-E8h]
			//   __int128 v73; // [rsp+60h] [rbp-D8h]
			//   __int128 v74; // [rsp+70h] [rbp-C8h]
			//   __int128 v75; // [rsp+80h] [rbp-B8h]
			//   Vector4 v76; // [rsp+90h] [rbp-A8h]
			//   Vector4 v77; // [rsp+A0h] [rbp-98h]
			//   __int128 v78; // [rsp+B0h] [rbp-88h]
			//   __int128 v79; // [rsp+C0h] [rbp-78h]
			//   __int128 v80; // [rsp+D0h] [rbp-68h]
			//   __int128 v81; // [rsp+E0h] [rbp-58h]
			//   __int128 v82; // [rsp+F0h] [rbp-48h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1168, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1168, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v57, v56);
			//     v58 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_434((GpuClothRenderData *)&v69, Patch, (Object *)this, 0LL);
			//     v59 = 2LL;
			//     v60 = retstr;
			//     do
			//     {
			//       v61 = *(_OWORD *)&v58.clothConstData.packedDeltaT.z;
			//       *(_OWORD *)&v60.isValid = *(_OWORD *)&v58.isValid;
			//       v62 = *(_OWORD *)&v58.clothConstData.clothParam1.z;
			//       *(_OWORD *)&v60.clothConstData.packedDeltaT.z = v61;
			//       v63 = *(_OWORD *)&v58.clothNodeDataBuffer;
			//       *(_OWORD *)&v60.clothConstData.clothParam1.z = v62;
			//       v64 = *(_OWORD *)&v58.clothBatchMetaDataBuffer;
			//       *(_OWORD *)&v60.clothNodeDataBuffer = v63;
			//       v65 = *(_OWORD *)&v58.clothSkeletonDataBuffer;
			//       *(_OWORD *)&v60.clothBatchMetaDataBuffer = v64;
			//       packedDeltaT = v58[1].clothConstData.packedDeltaT;
			//       *(_OWORD *)&v60.clothSkeletonDataBuffer = v65;
			//       clothParam1 = v58[1].clothConstData.clothParam1;
			//       v58 = (GpuClothRenderData *)((char *)v58 + 128);
			//       v60[1].clothConstData.packedDeltaT = packedDeltaT;
			//       v60 = (GpuClothRenderData *)((char *)v60 + 128);
			//       *(Vector4 *)&v60[-1].clothBatchCacheMapBuffer = clothParam1;
			//       --v59;
			//     }
			//     while ( v59 );
			//     *(_OWORD *)&v60.isValid = *(_OWORD *)&v58.isValid;
			//   }
			//   else
			//   {
			//     LOBYTE(this.fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) = 0;
			//     if ( LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) )
			//     {
			//       HG::Rendering::Runtime::ClothConstData::SetDt(&this.fields.clothConstData, 0.023333333, 0LL);
			//       HG::Rendering::Runtime::ClothConstData::SetSkeletonFlipped(
			//         &this.fields.clothConstData,
			//         *((float *)&this[1].monitor + 1),
			//         0LL);
			//       HG::Rendering::Runtime::ClothConstData::SetLoopNum(
			//         &this.fields.clothConstData,
			//         this[1].fields.CHARACTER_POSITION_OFFSET.w,
			//         0LL);
			//       HG::Rendering::Runtime::ClothConstData::SetClothWindParams(
			//         &this.fields.clothConstData,
			//         this[1].fields.INVALID_POSITION.x,
			//         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                (__m128)LODWORD(this[1].fields.INVALID_POSITION.z),
			//                                (__m128)LODWORD(this[1].fields.INVALID_POSITION.w)),
			//         0LL);
			//       HIDWORD(this.fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) = LODWORD(this[1].fields.clothConstData.packedDeltaT.x);
			//       v5 = this.fields.clothConstData.clothParam1;
			//       v69 = this.fields.clothConstData.packedDeltaT;
			//       v6 = *(_OWORD *)&this.fields.clothConstData.colliderInfoArray.FixedElementField;
			//       v70 = v5;
			//       v7 = *(_OWORD *)&this.fields.m_capsuleRadius;
			//       v71 = v6;
			//       v8 = *(_OWORD *)&this.fields.clothNodeDataBuffer;
			//       v72 = v7;
			//       v9 = *(_OWORD *)&this.fields.clothBatchMetaDataBuffer;
			//       v73 = v8;
			//       v10 = *(_OWORD *)&this.fields.clothSkeletonDataBuffer;
			//       v74 = v9;
			//       v11 = this.fields.renderData.clothConstData.packedDeltaT;
			//       v75 = v10;
			//       v12 = this.fields.renderData.clothConstData.clothParam1;
			//       v76 = v11;
			//       v13 = *(_OWORD *)&this.fields.renderData.clothConstData.colliderInfoArray.FixedElementField;
			//       v77 = v12;
			//       v14 = *(_OWORD *)&this.fields.renderData.clothMetaDataBuffer;
			//       v78 = v13;
			//       v15 = *(_OWORD *)&this.fields.renderData.clothBatchCacheMapBuffer;
			//       v79 = v14;
			//       v16 = *(_OWORD *)&this.fields.clearBufferData.shouldClear;
			//       v80 = v15;
			//       v17 = *(_OWORD *)&this.fields.clearBufferData.eleNum.w;
			//       v81 = v16;
			//       v82 = v17;
			//       v18 = v70;
			//       *(Vector4 *)&this.fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel.Index = v69;
			//       v19 = v71;
			//       *(Vector4 *)&this.fields.m_isForcedRefresh = v18;
			//       v20 = v72;
			//       *(_OWORD *)&this.fields.m_registedClothGroupData.m_HashMapData.m_AllocatorLabel.Index = v19;
			//       v21 = v73;
			//       *(_OWORD *)&this.fields.m_activatedGroupHashToGroupMeta.m_HashMapData.m_AllocatorLabel.Index = v20;
			//       v22 = v74;
			//       *(_OWORD *)&this.fields.m_shouldActivatedGroupHash = v21;
			//       v23 = v75;
			//       *(_OWORD *)&this.fields.m_activatedGroupHash.m_Data.m_HashMapData.m_AllocatorLabel.Index = v22;
			//       v24 = v76;
			//       *(_OWORD *)&this.fields.m_lastActivatedGroupHash.m_Data.m_HashMapData.m_AllocatorLabel.Index = v23;
			//       *(Vector4 *)&this.fields.m_pendingDeactivateGroupHash = v24;
			//       v25 = v78;
			//       *(Vector4 *)&this.fields.m_playerCenterXZ.x = v77;
			//       v26 = v79;
			//       *(_OWORD *)&this.fields.m_groupHashNeedToUpload.m_Data.m_HashMapData.m_AllocatorLabel.Index = v25;
			//       v27 = v80;
			//       *(_OWORD *)&this.fields.m_groupHashUploaded.m_Data.m_HashMapData.m_AllocatorLabel.Index = v26;
			//       v28 = v81;
			//       *(_OWORD *)&this.fields.clothGroupUploadData.isValid = v27;
			//       v29 = v82;
			//       *(_OWORD *)&this.fields.clothGroupUploadData.uploadDataMap.m_DeprecatedAllocator.Index = v28;
			//       *(_OWORD *)&this.fields.clothGroupUploadData.clothMetaUploadData.m_DeprecatedAllocator.Index = v29;
			//       *(_QWORD *)&this.fields.clothGroupUploadData.clothNodeUploadData.m_DeprecatedAllocator.Index = *(_QWORD *)&this.fields.gameplayDt;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothNodeUploadData.m_DeprecatedAllocator,
			//         v30,
			//         v31,
			//         v32,
			//         *(String__Array **)&v69.x,
			//         *(String **)&v69.z,
			//         *(MethodInfo **)&v70.x);
			//       v33 = *(UnsafeList_1_Unity_Mathematics_int4_ **)&this.fields.shouldStep;
			//       this.fields.clothGroupUploadData.clothBatchMetaUploadData.m_ListData = v33;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothBatchMetaUploadData,
			//         v34,
			//         v35,
			//         (MessageDescriptor *)v33,
			//         *(String__Array **)&v69.x,
			//         *(String **)&v69.z,
			//         *(MethodInfo **)&v70.x);
			//       v36 = *(MessageDescriptor **)&this.fields.windTime;
			//       *(_QWORD *)&this.fields.clothGroupUploadData.clothBatchMetaUploadData.m_DeprecatedAllocator.Index = v36;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothBatchMetaUploadData.m_DeprecatedAllocator,
			//         v37,
			//         v38,
			//         v36,
			//         *(String__Array **)&v69.x,
			//         *(String **)&v69.z,
			//         *(MethodInfo **)&v70.x);
			//       windNoiseUV = (UnsafeList_1_Unity_Mathematics_int4_ *)this.fields.windNoiseUV;
			//       this.fields.clothGroupUploadData.clothBatchCacheMapUploadData.m_ListData = windNoiseUV;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothBatchCacheMapUploadData,
			//         v40,
			//         v41,
			//         (MessageDescriptor *)windNoiseUV,
			//         *(String__Array **)&v69.x,
			//         *(String **)&v69.z,
			//         *(MethodInfo **)&v70.x);
			//       v42 = *(MessageDescriptor **)&this.fields.m_runtimeClothNum;
			//       *(_QWORD *)&this.fields.clothGroupUploadData.clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index = v42;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothBatchCacheMapUploadData.m_DeprecatedAllocator,
			//         v43,
			//         v44,
			//         v42,
			//         *(String__Array **)&v69.x,
			//         *(String **)&v69.z,
			//         *(MethodInfo **)&v70.x);
			//       LOBYTE(this.fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) = HIDWORD(this.fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer) != 0;
			//     }
			//     v45 = retstr;
			//     p_m_clothHashToRuntimeClothData = &this.fields.m_clothHashToRuntimeClothData;
			//     v47 = 2LL;
			//     do
			//     {
			//       v48 = p_m_clothHashToRuntimeClothData[1];
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.isValid = *p_m_clothHashToRuntimeClothData;
			//       v49 = p_m_clothHashToRuntimeClothData[2];
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.clothConstData.packedDeltaT.z = v48;
			//       v50 = p_m_clothHashToRuntimeClothData[3];
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.clothConstData.clothParam1.z = v49;
			//       v51 = p_m_clothHashToRuntimeClothData[4];
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.clothNodeDataBuffer = v50;
			//       v52 = p_m_clothHashToRuntimeClothData[5];
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.clothBatchMetaDataBuffer = v51;
			//       v53 = (Vector4)p_m_clothHashToRuntimeClothData[6];
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.clothSkeletonDataBuffer = v52;
			//       v54 = p_m_clothHashToRuntimeClothData[7];
			//       p_m_clothHashToRuntimeClothData += 8;
			//       v45[1].clothConstData.packedDeltaT = v53;
			//       v45 = (GpuClothRenderData *)((char *)v45 + 128);
			//       *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45[-1].clothBatchCacheMapBuffer = v54;
			//       --v47;
			//     }
			//     while ( v47 );
			//     *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v45.isValid = *p_m_clothHashToRuntimeClothData;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		internal GpuClothClearBufferData GetClearBufferData()
		{
			// // GpuClothClearBufferData GetClearBufferData()
			// GpuClothClearBufferData *HG::Rendering::Runtime::GpuClothManager::GetClearBufferData(
			//         GpuClothClearBufferData *__return_ptr retstr,
			//         GpuClothManager *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   ComputeBuffer *v8; // r9
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   GpuClothManager__Class *windNoiseUV; // r9
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   GpuClothClearBufferData *v19; // rax
			//   GpuClothClearBufferData *result; // rax
			//   GpuClothClearBufferData v21; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1169, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1169, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_435(&v21, Patch, (Object *)this, 0LL);
			//     v14 = *(_OWORD *)&v19.eleNum.w;
			//     *(_OWORD *)&retstr.shouldClear = *(_OWORD *)&v19.shouldClear;
			//     v15 = *(_OWORD *)&v19.clothBatchMetaDataBuffer;
			//   }
			//   else
			//   {
			//     LOBYTE(this.fields.clothGroupUploadData.clothMetaDataBuffer) = 0;
			//     if ( this.fields.isStreamingMode )
			//     {
			//       *(__m128i *)((char *)&this.fields.clothGroupUploadData.clothMetaDataBuffer + 4) = _mm_load_si128((const __m128i *)&xmmword_18C370DA0);
			//       this.fields.clothGroupUploadData.clothBatchCacheMapBuffer = *(ComputeBuffer **)&this.fields.gameplayDt;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothBatchCacheMapBuffer,
			//         v5,
			//         v6,
			//         v7,
			//         *(String__Array **)&v21.shouldClear,
			//         *(String **)&v21.eleNum.y,
			//         *(MethodInfo **)&v21.eleNum.w);
			//       v8 = *(ComputeBuffer **)&this.fields.windTime;
			//       this.fields.clothGroupUploadData.clothSkeletonDataBuffer = v8;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.clothGroupUploadData.clothSkeletonDataBuffer,
			//         v9,
			//         v10,
			//         (MessageDescriptor *)v8,
			//         *(String__Array **)&v21.shouldClear,
			//         *(String **)&v21.eleNum.y,
			//         *(MethodInfo **)&v21.eleNum.w);
			//       windNoiseUV = (GpuClothManager__Class *)this.fields.windNoiseUV;
			//       this[1].klass = windNoiseUV;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this[1],
			//         v12,
			//         v13,
			//         (MessageDescriptor *)windNoiseUV,
			//         *(String__Array **)&v21.shouldClear,
			//         *(String **)&v21.eleNum.y,
			//         *(MethodInfo **)&v21.eleNum.w);
			//       LOBYTE(this.fields.clothGroupUploadData.clothMetaDataBuffer) = 1;
			//       this.fields.isStreamingMode = 0;
			//     }
			//     v14 = *(_OWORD *)&this.fields.clothGroupUploadData.clothBatchMetaDataBuffer;
			//     *(_OWORD *)&retstr.shouldClear = *(_OWORD *)&this.fields.clothGroupUploadData.clothMetaDataBuffer;
			//     v15 = *(_OWORD *)&this.fields.clothGroupUploadData.clothSkeletonDataBuffer;
			//   }
			//   result = retstr;
			//   *(_OWORD *)&retstr.eleNum.w = v14;
			//   *(_OWORD *)&retstr.clothBatchMetaDataBuffer = v15;
			//   return result;
			// }
			// 
			return null;
		}

		internal GpuClothGroupUploadData GetUploadData()
		{
			// // GpuClothGroupUploadData GetUploadData()
			// // Hidden C++ exception states: #wind=2 #try_helpers=1
			// GpuClothGroupUploadData *HG::Rendering::Runtime::GpuClothManager::GetUploadData(
			//         GpuClothGroupUploadData *__return_ptr retstr,
			//         GpuClothManager *this,
			//         MethodInfo *method)
			// {
			//   GpuClothManager *v3; // rbx
			//   GpuClothGroupUploadData *v4; // rsi
			//   GpuClothManager *v5; // r14
			//   bool v6; // r15
			//   int v7; // r12d
			//   uint32_t Current; // eax
			//   uint32_t v9; // r13d
			//   AllocatorManager_AllocatorHandle m_DeprecatedAllocator; // r12d
			//   int32_t TotalClothNodeNum; // r13d
			//   int32_t TotalClothBatchNum; // r13d
			//   int32_t TotalClothBatchCacheMapNum; // r13d
			//   int i; // r12d
			//   uint32_t v15; // r13d
			//   uint32_t v16; // eax
			//   int v17; // ecx
			//   unsigned __int64 v18; // r9
			//   signed __int64 v19; // rtt
			//   unsigned __int64 v20; // r9
			//   signed __int64 v21; // rtt
			//   unsigned __int64 v22; // r9
			//   signed __int64 v23; // rtt
			//   unsigned __int64 v24; // r9
			//   signed __int64 v25; // rtt
			//   unsigned __int64 v26; // r9
			//   signed __int64 v27; // rtt
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ m_clothHashToRuntimeClothData; // xmm0
			//   __int128 v29; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   GpuClothGroupUploadData *v33; // rax
			//   NativeParallelHashSet_1_T_Enumerator_System_UInt32_ v35; // [rsp+30h] [rbp-208h] BYREF
			//   NativeParallelHashSet_1_T_Enumerator_System_UInt32_ data; // [rsp+50h] [rbp-1E8h] BYREF
			//   uint32_t v37; // [rsp+68h] [rbp-1D0h]
			//   Il2CppException *ex; // [rsp+70h] [rbp-1C8h]
			//   NativeParallelHashSet_1_T_Enumerator_System_UInt32_ *p_data; // [rsp+78h] [rbp-1C0h]
			//   ClothGroupUploadDataMap value; // [rsp+80h] [rbp-1B8h] BYREF
			//   GpuClothManager *v41; // [rsp+B0h] [rbp-188h]
			//   GpuClothManager_RuntimeClothData_Internal v42; // [rsp+B8h] [rbp-180h] BYREF
			//   __int64 v43; // [rsp+C8h] [rbp-170h]
			//   GpuClothManager_RuntimeClothData_Internal v44; // [rsp+E0h] [rbp-158h] BYREF
			//   Il2CppExceptionWrapper *v45; // [rsp+F8h] [rbp-140h] BYREF
			//   GpuClothGroupUploadData item; // [rsp+100h] [rbp-138h] BYREF
			//   GpuClothManager_ClothGroupData_Internal v47; // [rsp+180h] [rbp-B8h] BYREF
			//   uint8_t *v48; // [rsp+1E0h] [rbp-58h]
			//   int32_t v49; // [rsp+1E8h] [rbp-50h]
			//   uint8_t *v50; // [rsp+1F0h] [rbp-48h]
			//   int32_t v51; // [rsp+1F8h] [rbp-40h]
			//   uint8_t *v52; // [rsp+200h] [rbp-38h]
			//   int32_t v53; // [rsp+208h] [rbp-30h]
			//   int v56; // [rsp+258h] [rbp+20h]
			// 
			//   v3 = this;
			//   v4 = retstr;
			//   v5 = this;
			//   v41 = this;
			//   if ( byte_18D919CED )
			//   {
			//     v6 = 1;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothNodeData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::get_Length);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::get_Length);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::get_Length);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::set_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Count);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Remove);
			//     v6 = 1;
			//     byte_18D919CED = 1;
			//   }
			//   sub_1802F01E0(&item, 0LL, 100LL);
			//   sub_1802F01E0(&v47, 0LL, 144LL);
			//   memset(&value, 0, sizeof(value));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1170, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1170, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v32, v31);
			//     v33 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_436(&item, Patch, (Object *)v3, 0LL);
			//     *(_OWORD *)&v4.isValid = *(_OWORD *)&v33.isValid;
			//     *(_OWORD *)&v4.uploadDataMap.m_DeprecatedAllocator.Index = *(_OWORD *)&v33.uploadDataMap.m_DeprecatedAllocator.Index;
			//     *(_OWORD *)&v4.clothMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33.clothMetaUploadData.m_DeprecatedAllocator.Index;
			//     *(_OWORD *)&v4.clothNodeUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33.clothNodeUploadData.m_DeprecatedAllocator.Index;
			//     *(_OWORD *)&v4.clothBatchMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33.clothBatchMetaUploadData.m_DeprecatedAllocator.Index;
			//     *(_OWORD *)&v4.clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v33.clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index;
			//     m_clothHashToRuntimeClothData = *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v33.clothNodeDataBuffer;
			//     v29 = *(_OWORD *)&v33.clothBatchCacheMapBuffer;
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::GpuClothGroupUploadData::Reset(
			//       (GpuClothGroupUploadData *)&v3[1].fields.clearBufferData,
			//       0LL);
			//     if ( LOBYTE(v3[1].fields.CHARACTER_POSITION_OFFSET.z)
			//       && (LOBYTE(v3[1].fields.renderData.clothSkeletonDataBuffer)
			//        || Unity::Collections::NativeParallelHashSet<Unity::Mathematics::int4>::Count(
			//             (NativeParallelHashSet_1_Unity_Mathematics_int4_ *)&v3[1].fields.renderData.clothNodeDataBuffer,
			//             MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Count)) )
			//     {
			//       v7 = 0;
			//       v56 = 0;
			//       Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
			//         (NativeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothBatchMetaDataBuffer,
			//         MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//       Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashSet<unsigned int>::GetEnumerator(
			//         (UnsafeParallelHashSet_1_T_Enumerator_System_UInt32_ *)&v35,
			//         (UnsafeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothNodeDataBuffer,
			//         MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::GetEnumerator);
			//       data = v35;
			//       ex = 0LL;
			//       p_data = &data;
			//       while ( Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashMapData::MoveNext(
			//                 data.m_Enumerator.m_Buffer,
			//                 &data.m_Enumerator.m_BucketIndex,
			//                 &data.m_Enumerator.m_NextIndex,
			//                 &data.m_Enumerator.m_Index,
			//                 0LL) )
			//       {
			//         Current = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
			//                     &data,
			//                     MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
			//         v9 = Current;
			//         v37 = Current;
			//         if ( v7 >= 4 )
			//           break;
			//         if ( Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue(
			//                (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupMeta_Internal_ *)&v3[1].fields.needClearGPUBuffer,
			//                Current,
			//                (GpuClothManager_ClothGroupMeta_Internal *)&item,
			//                MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::TryGetValue)
			//           && Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::TryGetValue(
			//                (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_ClothGroupData_Internal_ *)&v3[1].fields.m_characterMesh,
			//                v9,
			//                &v47,
			//                MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::TryGetValue) )
			//         {
			//           m_DeprecatedAllocator = item.clothBatchCacheMapUploadData.m_DeprecatedAllocator;
			//           memset(&value, 0, sizeof(value));
			//           TotalClothNodeNum = HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothNodeNum((ClothGroupMeta *)&item, 0LL);
			//           value.clothNodeDataMap.x = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
			//                                        (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.clearBufferData.clothBatchCacheMapBuffer,
			//                                        MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothNodeData>::get_Length);
			//           value.clothNodeDataMap.y = value.clothNodeDataMap.x + TotalClothNodeNum;
			//           value.clothNodeDataMap.z = *(_DWORD *)&m_DeprecatedAllocator << 9;
			//           value.clothNodeDataMap.w = (*(_DWORD *)&m_DeprecatedAllocator << 9) + TotalClothNodeNum;
			//           if ( value.clothNodeDataMap.x + TotalClothNodeNum > 680 )
			//             break;
			//           *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.clearBufferData.clothBatchCacheMapBuffer;
			//           HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothNodeData>(
			//             (NativeList_1_HG_Rendering_Runtime_ClothNodeData_ *)&v35,
			//             v48,
			//             v49,
			//             0,
			//             TotalClothNodeNum,
			//             MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothNodeData>);
			//           TotalClothBatchNum = HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchNum(
			//                                  (ClothGroupMeta *)&item,
			//                                  0LL);
			//           value.clothBatchMetaDataMap.x = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
			//                                             (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.gameplayDt,
			//                                             MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::get_Length);
			//           value.clothBatchMetaDataMap.y = (TotalClothBatchNum + 1) / 2 + value.clothBatchMetaDataMap.x;
			//           value.clothBatchMetaDataMap.z = 4 * *(_DWORD *)&m_DeprecatedAllocator;
			//           value.clothBatchMetaDataMap.w = 4 * *(_DWORD *)&m_DeprecatedAllocator + (TotalClothBatchNum + 1) / 2;
			//           *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.gameplayDt;
			//           HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>(
			//             (NativeList_1_Unity_Mathematics_int4_ *)&v35,
			//             v50,
			//             v51,
			//             0,
			//             (TotalClothBatchNum + 1) / 2,
			//             MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>);
			//           TotalClothBatchCacheMapNum = HG::Rendering::Runtime::ClothGroupMeta::GetTotalClothBatchCacheMapNum(
			//                                          (ClothGroupMeta *)&item,
			//                                          0LL);
			//           value.clothBatchCacheDataMap.x = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
			//                                              (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.windTime,
			//                                              MethodInfo::Unity::Collections::NativeList<Unity::Mathematics::int4>::get_Length);
			//           value.clothBatchCacheDataMap.y = (TotalClothBatchCacheMapNum + 1) / 2 + value.clothBatchCacheDataMap.x;
			//           value.clothBatchCacheDataMap.z = *(_DWORD *)&m_DeprecatedAllocator << 6;
			//           value.clothBatchCacheDataMap.w = (*(_DWORD *)&m_DeprecatedAllocator << 6)
			//                                          + (TotalClothBatchCacheMapNum + 1) / 2;
			//           if ( value.clothBatchCacheDataMap.y > 128 )
			//             break;
			//           *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.windTime;
			//           HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>(
			//             (NativeList_1_Unity_Mathematics_int4_ *)&v35,
			//             v52,
			//             v53,
			//             0,
			//             (TotalClothBatchCacheMapNum + 1) / 2,
			//             MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<Unity::Mathematics::int4>);
			//           for ( i = 0; i < *(int *)&item.isValid; ++i )
			//           {
			//             v15 = *((_DWORD *)&item.uploadDataMap.m_DeprecatedAllocator + i);
			//             Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::get_Item(
			//               &v42,
			//               (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v3[1].fields.clothConstData.packedDeltaT.z,
			//               v15,
			//               MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::get_Item);
			//             v43 = *(_QWORD *)&v42.isDataReady;
			//             LOBYTE(v43) = 1;
			//             *(_QWORD *)&v44.isDataReady = v43;
			//             v44.isSingleSkeleton = v42.isSingleSkeleton;
			//             Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::set_Item(
			//               (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v3[1].fields.clothConstData.packedDeltaT.z,
			//               v15,
			//               &v44,
			//               MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::set_Item);
			//           }
			//           Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Add(
			//             (NativeList_1_HG_Rendering_Runtime_ClothGroupUploadDataMap_ *)&v3[1].fields.clearBufferData.eleNum.y,
			//             &value,
			//             MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothGroupUploadDataMap>::Add);
			//           v7 = ++v56;
			//           v9 = v37;
			//         }
			//         Unity::Collections::NativeParallelHashSet<unsigned int>::Add(
			//           (NativeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothBatchMetaDataBuffer,
			//           v9,
			//           MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Add);
			//       }
			//       v35.m_Enumerator.m_Buffer = (UnsafeParallelHashMapData *)v3[1].fields.renderData.clothBatchMetaDataBuffer;
			//       *(_QWORD *)&v35.m_Enumerator.m_Index = 0xFFFFFFFFLL;
			//       *(_QWORD *)&v35.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
			//       *(_OWORD *)&data.m_Enumerator.m_Buffer = *(_OWORD *)&v35.m_Enumerator.m_Buffer;
			//       *(_QWORD *)&data.m_Enumerator.m_NextIndex = 0xFFFFFFFFLL;
			//       ex = 0LL;
			//       p_data = &data;
			//       try
			//       {
			//         while ( Unity::Collections::LowLevel::Unsafe::UnsafeParallelHashMapData::MoveNext(
			//                   data.m_Enumerator.m_Buffer,
			//                   &data.m_Enumerator.m_BucketIndex,
			//                   &data.m_Enumerator.m_NextIndex,
			//                   &data.m_Enumerator.m_Index,
			//                   0LL) )
			//         {
			//           v16 = Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current(
			//                   &data,
			//                   MethodInfo::Unity::Collections::NativeParallelHashSet_1_T_::Enumerator<unsigned int>::get_Current);
			//           Unity::Collections::NativeParallelHashSet<unsigned int>::Remove(
			//             (NativeParallelHashSet_1_System_UInt32_ *)&v3[1].fields.renderData.clothNodeDataBuffer,
			//             v16,
			//             MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Remove);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v45 )
			//       {
			//         ex = v45.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v6 = 1;
			//         v3 = this;
			//         v4 = retstr;
			//         v5 = v41;
			//       }
			//       if ( LOBYTE(v3[1].fields.renderData.clothSkeletonDataBuffer) )
			//       {
			//         *(_OWORD *)&v35.m_Enumerator.m_Buffer = *(_OWORD *)&v3[1].fields.clearBufferData.clothNodeDataBuffer;
			//         HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>(
			//           (NativeList_1_HG_Rendering_Runtime_ClothMetaData_ *)&v35,
			//           *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&v3[1].fields.clothConstData.clothParam1.z,
			//           MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>);
			//         LOBYTE(v3[1].fields.renderData.clothSkeletonDataBuffer) = 0;
			//       }
			//       *(_QWORD *)&v5[1].fields.m_runtimeClothNum = *(_QWORD *)&v3.fields.shouldStep;
			//       v17 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v18 = (((unsigned __int64)&v5[1].fields.m_runtimeClothNum >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v18 + 36190]);
			//         do
			//           v19 = qword_18D6405E0[v18 + 36190];
			//         while ( v19 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v18 + 36190],
			//                          v19 | (1LL << (((unsigned __int64)&v5[1].fields.m_runtimeClothNum >> 12) & 0x3F)),
			//                          v19) );
			//         v17 = dword_18D8E43F8;
			//       }
			//       v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_Buffer = *(UnsafeParallelHashMapData **)&v3.fields.gameplayDt;
			//       if ( v17 )
			//       {
			//         v20 = (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v20 + 36190]);
			//         do
			//           v21 = qword_18D6405E0[v20 + 36190];
			//         while ( v21 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v20 + 36190],
			//                          v21 | (1LL << (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData >> 12) & 0x3F)),
			//                          v21) );
			//         v17 = dword_18D8E43F8;
			//       }
			//       *(_QWORD *)&v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel.Index = *(_QWORD *)&v3.fields.windTime;
			//       if ( v17 )
			//       {
			//         v22 = (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v22 + 36190]);
			//         do
			//           v23 = qword_18D6405E0[v22 + 36190];
			//         while ( v23 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v22 + 36190],
			//                          v23 | (1LL << (((unsigned __int64)&v5[1].fields.m_clothHashToRuntimeClothData.m_HashMapData.m_AllocatorLabel >> 12) & 0x3F)),
			//                          v23) );
			//         v17 = dword_18D8E43F8;
			//       }
			//       v5[1].fields.m_runtimeClothMetaArray = (DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ *)v3.fields.windNoiseUV;
			//       if ( v17 )
			//       {
			//         v24 = (((unsigned __int64)&v5[1].fields.m_runtimeClothMetaArray >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//         do
			//           v25 = qword_18D6405E0[v24 + 36190];
			//         while ( v25 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v24 + 36190],
			//                          v25 | (1LL << (((unsigned __int64)&v5[1].fields.m_runtimeClothMetaArray >> 12) & 0x3F)),
			//                          v25) );
			//         v17 = dword_18D8E43F8;
			//       }
			//       *(_QWORD *)&v5[1].fields.m_isForcedRefresh = *(_QWORD *)&v3.fields.m_runtimeClothNum;
			//       if ( v17 )
			//       {
			//         v26 = (((unsigned __int64)&v5[1].fields.m_isForcedRefresh >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v26 + 36190]);
			//         do
			//           v27 = qword_18D6405E0[v26 + 36190];
			//         while ( v27 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v26 + 36190],
			//                          v27 | (1LL << (((unsigned __int64)&v5[1].fields.m_isForcedRefresh >> 12) & 0x3F)),
			//                          v27) );
			//       }
			//       if ( Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
			//              (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v3[1].fields.clearBufferData.clothNodeDataBuffer,
			//              MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::ClothMetaData>::get_Length) <= 0 )
			//         v6 = v56 > 0;
			//       v5[1].fields.clearBufferData.shouldClear = v6;
			//     }
			//     *(_OWORD *)&v4.isValid = *(_OWORD *)&v3[1].fields.clearBufferData.shouldClear;
			//     *(_OWORD *)&v4.uploadDataMap.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.clearBufferData.eleNum.w;
			//     *(_OWORD *)&v4.clothMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.clearBufferData.clothBatchMetaDataBuffer;
			//     *(_OWORD *)&v4.clothNodeUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.isStreamingMode;
			//     *(_OWORD *)&v4.clothBatchMetaUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.shouldStep;
			//     *(_OWORD *)&v4.clothBatchCacheMapUploadData.m_DeprecatedAllocator.Index = *(_OWORD *)&v3[1].fields.windNoiseUV.x;
			//     m_clothHashToRuntimeClothData = v3[1].fields.m_clothHashToRuntimeClothData;
			//     v29 = *(_OWORD *)&v3[1].fields.m_runtimeClothMetaArray;
			//   }
			//   *(NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v4.clothNodeDataBuffer = m_clothHashToRuntimeClothData;
			//   *(_OWORD *)&v4.clothBatchCacheMapBuffer = v29;
			//   return v4;
			// }
			// 
			return null;
		}

		internal ComputeBuffer GetSkeletonBuffer()
		{
			return null;
		}

		internal void FlipSkeletonFlag()
		{
			// // Void FlipSkeletonFlag()
			// void HG::Rendering::Runtime::GpuClothManager::FlipSkeletonFlag(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1172, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1172, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z) )
			//   {
			//     *((float *)&this[1].monitor + 1) = 1.0 - *((float *)&this[1].monitor + 1);
			//   }
			// }
			// 
		}

		internal bool IsClothSkeletonValid()
		{
			// // Boolean IsClothSkeletonValid()
			// bool HG::Rendering::Runtime::GpuClothManager::IsClothSkeletonValid(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1167, 0LL) )
			//     return (bool)this[1].monitor;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1167, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		internal bool IsClothSkeletonFlipped()
		{
			// // Boolean IsClothSkeletonFlipped()
			// bool HG::Rendering::Runtime::GpuClothManager::IsClothSkeletonFlipped(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1173, 0LL) )
			//     return *((float *)&this[1].monitor + 1) != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1173, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		internal bool ShouldStep()
		{
			// // Boolean ShouldStep()
			// bool HG::Rendering::Runtime::GpuClothManager::ShouldStep(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1174, 0LL) )
			//     return LOBYTE(this[1].fields.CHARACTER_POSITION_OFFSET.z);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1174, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::GpuClothManager::Dispose(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919CEF )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothGroupUploadDataMap>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothMetaData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothNodeData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>);
			//     byte_18D919CEF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1175, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1175, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::GpuClothManager::ResetStreamingResource(this, 0LL);
			//     HG::Rendering::Runtime::GpuClothManager::ResetGpuResource(this, 0LL);
			//     HG::Rendering::Runtime::GpuClothManager::ResetCpuData(this, 0LL);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>(
			//       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.clothConstData.packedDeltaT.z,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>(
			//       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.m_characterMesh,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>(
			//       (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&this[1].fields.needClearGPUBuffer,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
			//       (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.clothBatchCacheMapBuffer,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
			//       (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
			//       (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData.clothNodeDataBuffer,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>(
			//       (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData.clothBatchMetaDataBuffer,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<unsigned int>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothGroupUploadDataMap>(
			//       (NativeList_1_HG_Rendering_Runtime_ClothGroupUploadDataMap_ *)&this[1].fields.clearBufferData.eleNum.y,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothGroupUploadDataMap>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothMetaData>(
			//       (NativeList_1_HG_Rendering_Runtime_ClothMetaData_ *)&this[1].fields.clearBufferData.clothNodeDataBuffer,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothMetaData>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothNodeData>(
			//       (NativeList_1_HG_Rendering_Runtime_ClothNodeData_ *)&this[1].fields.clearBufferData.clothBatchCacheMapBuffer,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<HG::Rendering::Runtime::ClothNodeData>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>(
			//       (NativeList_1_Unity_Mathematics_int4_ *)&this[1].fields.gameplayDt,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>);
			//     HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>(
			//       (NativeList_1_Unity_Mathematics_int4_ *)&this[1].fields.windTime,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::RecycleNativeDataStructs<Unity::Mathematics::int4>);
			//   }
			// }
			// 
		}

		internal void ResetCpuData()
		{
			// // Void ResetCpuData()
			// void HG::Rendering::Runtime::GpuClothManager::ResetCpuData(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1153, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1153, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HIDWORD(this[1].monitor) = 0;
			//   }
			// }
			// 
		}

		internal void ResetStreamingResource()
		{
			// // Void ResetStreamingResource()
			// void HG::Rendering::Runtime::GpuClothManager::ResetStreamingResource(GpuClothManager *this, MethodInfo *method)
			// {
			//   ComputeBuffer *clothBatchMetaDataBuffer; // rcx
			//   ComputeBuffer *clothMetaDataBuffer; // rdx
			//   __int64 v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919CF0 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::Clear);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//     byte_18D919CF0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1154, 0LL) )
			//   {
			//     this[1].fields.clothConstData.packedDeltaT.x = 0.0;
			//     this[1].fields.clothConstData.packedDeltaT.y = 0.0;
			//     Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int2,unsigned char>::Clear(
			//       (NativeParallelHashMap_2_Unity_Mathematics_int2_System_Byte_ *)&this[1].fields.clothConstData.packedDeltaT.z,
			//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Clear);
			//     Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int2,unsigned char>::Clear(
			//       (NativeParallelHashMap_2_Unity_Mathematics_int2_System_Byte_ *)&this[1].fields.needClearGPUBuffer,
			//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Clear);
			//     clothBatchMetaDataBuffer = 0LL;
			//     do
			//     {
			//       clothMetaDataBuffer = this[1].fields.clothMetaDataBuffer;
			//       if ( !clothMetaDataBuffer )
			//         goto LABEL_15;
			//       if ( (unsigned int)clothBatchMetaDataBuffer >= LODWORD(clothMetaDataBuffer[1].klass) )
			//         sub_180070270(clothBatchMetaDataBuffer, clothMetaDataBuffer);
			//       v5 = (int)clothBatchMetaDataBuffer;
			//       clothBatchMetaDataBuffer = (ComputeBuffer *)(unsigned int)((_DWORD)clothBatchMetaDataBuffer + 1);
			//       *((_DWORD *)&clothMetaDataBuffer[1].monitor + v5) = 1;
			//     }
			//     while ( (int)clothBatchMetaDataBuffer < 50 );
			//     clothBatchMetaDataBuffer = *(ComputeBuffer **)&this[1].fields.clothConstData.clothParam1.z;
			//     if ( clothBatchMetaDataBuffer )
			//     {
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)clothBatchMetaDataBuffer,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::Clear);
			//       LOBYTE(this[1].fields.clothConstData.colliderInfoArray.FixedElementField) = 0;
			//       Unity::Collections::NativeParallelHashMap<Unity::Mathematics::int2,unsigned char>::Clear(
			//         (NativeParallelHashMap_2_Unity_Mathematics_int2_System_Byte_ *)&this[1].fields.m_characterMesh,
			//         MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::Clear);
			//       clothBatchMetaDataBuffer = this[1].fields.clothBatchMetaDataBuffer;
			//       if ( clothBatchMetaDataBuffer )
			//       {
			//         Beyond::IndexedHashSet<unsigned int>::Clear(
			//           (IndexedHashSet_1_System_UInt32_ *)clothBatchMetaDataBuffer,
			//           MethodInfo::Beyond::IndexedHashSet<unsigned int>::Clear);
			//         Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
			//           (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.clothBatchCacheMapBuffer,
			//           MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//         Unity::Collections::NativeParallelHashSet<unsigned int>::Clear(
			//           (NativeParallelHashSet_1_System_UInt32_ *)&this[1].fields.renderData,
			//           MethodInfo::Unity::Collections::NativeParallelHashSet<unsigned int>::Clear);
			//         clothBatchMetaDataBuffer = *(ComputeBuffer **)&this[1].fields.renderData.clothConstData.packedDeltaT.z;
			//         if ( clothBatchMetaDataBuffer )
			//         {
			//           UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//             (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)clothBatchMetaDataBuffer,
			//             MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
			//           clothBatchMetaDataBuffer = *(ComputeBuffer **)&this[1].fields.renderData.clothConstData.clothParam1.x;
			//           if ( clothBatchMetaDataBuffer )
			//           {
			//             UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)clothBatchMetaDataBuffer,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<unsigned int>::Clear);
			//             this[1].fields.renderData.clothConstData.clothParam1.z = 0.0;
			//             this[1].fields.renderData.clothConstData.clothParam1.w = 0.0;
			//             this[1].fields.renderData.clothConstData.colliderInfoArray.FixedElementField = 0.0;
			//             *((_DWORD *)&this[1].fields.renderData.clothConstData + 9) = 0;
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(clothBatchMetaDataBuffer, clothMetaDataBuffer);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1154, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void ResetGpuResource()
		{
			// // Void ResetGpuResource()
			// void HG::Rendering::Runtime::GpuClothManager::ResetGpuResource(GpuClothManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ComputeBuffer *windNoiseUV; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1176, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1176, 0LL);
			//     if ( !Patch )
			//       goto LABEL_23;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( *(_QWORD *)&this.fields.gameplayDt
			//       && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this.fields.gameplayDt, 0LL) )
			//     {
			//       windNoiseUV = *(ComputeBuffer **)&this.fields.gameplayDt;
			//       if ( !windNoiseUV )
			//         goto LABEL_23;
			//       UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
			//     }
			//     if ( *(_QWORD *)&this.fields.shouldStep
			//       && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this.fields.shouldStep, 0LL) )
			//     {
			//       windNoiseUV = *(ComputeBuffer **)&this.fields.shouldStep;
			//       if ( !windNoiseUV )
			//         goto LABEL_23;
			//       UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
			//     }
			//     if ( *(_QWORD *)&this.fields.windTime
			//       && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this.fields.windTime, 0LL) )
			//     {
			//       windNoiseUV = *(ComputeBuffer **)&this.fields.windTime;
			//       if ( !windNoiseUV )
			//         goto LABEL_23;
			//       UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
			//     }
			//     if ( *(_QWORD *)&this.fields.windNoiseUV
			//       && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this.fields.windNoiseUV, 0LL) )
			//     {
			//       windNoiseUV = (ComputeBuffer *)this.fields.windNoiseUV;
			//       if ( !windNoiseUV )
			//         goto LABEL_23;
			//       UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
			//     }
			//     if ( *(_QWORD *)&this.fields.m_runtimeClothNum
			//       && UnityEngine::ComputeBuffer::IsValid(*(ComputeBuffer **)&this.fields.m_runtimeClothNum, 0LL) )
			//     {
			//       windNoiseUV = *(ComputeBuffer **)&this.fields.m_runtimeClothNum;
			//       if ( windNoiseUV )
			//       {
			//         UnityEngine::ComputeBuffer::Dispose(windNoiseUV, 0LL);
			//         return;
			//       }
			// LABEL_23:
			//       sub_180B536AC(windNoiseUV, v3);
			//     }
			//   }
			// }
			// 
		}

		private void _SetCharacterProxyMesh(Mesh characterProxyMesh)
		{
			// // Void _SetCharacterProxyMesh(Mesh)
			// void HG::Rendering::Runtime::GpuClothManager::_SetCharacterProxyMesh(
			//         GpuClothManager *this,
			//         Mesh *characterProxyMesh,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __m128 *bounds; // rax
			//   float v11; // xmm6_4
			//   float v12; // xmm1_4
			//   float v13; // xmm6_4
			//   float v14; // xmm7_4
			//   float v15; // xmm7_4
			//   int32_t v16; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v18; // [rsp+20h] [rbp-58h] BYREF
			//   Bounds v19; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1141, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1141, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)characterProxyMesh,
			//         0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v9, v8);
			//   }
			//   this.fields.clearBufferData.clothBatchMetaDataBuffer = (ComputeBuffer *)characterProxyMesh;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.clearBufferData.clothBatchMetaDataBuffer,
			//     v5,
			//     v6,
			//     v7,
			//     *(String__Array **)&v18.x,
			//     *(String **)&v18.z,
			//     *(MethodInfo **)&v19.m_Center.x);
			//   if ( !characterProxyMesh )
			//     goto LABEL_10;
			//   bounds = (__m128 *)UnityEngine::Mesh::get_bounds(&v19, characterProxyMesh, 0LL);
			//   v11 = _mm_shuffle_ps(*bounds, *bounds, 255).m128_f32[0];
			//   v12 = _mm_shuffle_ps((__m128)bounds[1].m128_u64[0], (__m128)bounds[1].m128_u64[0], 85).m128_f32[0];
			//   *(_QWORD *)&v19.m_Extents.y = bounds[1].m128_u64[0];
			//   if ( v11 <= v12 )
			//     v11 = v12;
			//   v13 = v11 * 0.75;
			//   *(float *)&this.fields.clearBufferData.clothBatchCacheMapBuffer = v13;
			//   v14 = 0.1;
			//   if ( (float)(v19.m_Extents.y - v13) >= 0.1 )
			//     v14 = v19.m_Extents.y - v13;
			//   v15 = v14 * 0.69999999;
			//   v16 = 0;
			//   *((float *)&this.fields.clearBufferData.clothBatchCacheMapBuffer + 1) = v15;
			//   do
			//   {
			//     v18.x = v13;
			//     v18.y = v15;
			//     *(_QWORD *)&v18.z = 0LL;
			//     HG::Rendering::Runtime::ClothConstData::SetVec4(&this.fields.clothConstData, v16 + 2, &v18, 0LL);
			//     *(Vector4 *)&v19.m_Center.x = this.fields.INVALID_POSITION;
			//     HG::Rendering::Runtime::ClothConstData::SetVec4(&this.fields.clothConstData, v16, (Vector4 *)&v19, 0LL);
			//     v16 += 3;
			//   }
			//   while ( v16 < 12 );
			// }
			// 
		}

		private void _UpdateRuntimeBuffer(int cellIdx, ref GpuClothManager.ClothGroupData_Internal clothGroupData)
		{
			// // Void _UpdateRuntimeBuffer(Int32, GpuClothManager+ClothGroupData_Internal ByRef)
			// void HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeBuffer(
			//         GpuClothManager *this,
			//         int32_t cellIdx,
			//         GpuClothManager_ClothGroupData_Internal *clothGroupData,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ *v8; // rcx
			//   __int64 v9; // rax
			//   int v10; // ebp
			//   int v11; // eax
			//   int32_t v12; // edi
			//   ClothMetaData *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int4 v15; // [rsp+30h] [rbp-28h]
			// 
			//   if ( !byte_18D919CF1 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_size);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>);
			//     byte_18D919CF1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1149, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1149, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_426(Patch, (Object *)this, cellIdx, clothGroupData, 0LL);
			//   }
			//   else
			//   {
			//     v9 = *(_QWORD *)&this[1].fields.clothConstData.clothParam1.z;
			//     if ( !v9 )
			//       goto LABEL_10;
			//     v10 = *(_DWORD *)(v9 + 24);
			//     HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>(
			//       *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z,
			//       clothGroupData.groupClothBatchCacheBytes,
			//       clothGroupData.groupClothBatchCacheBytesSize,
			//       MethodInfo::HG::Rendering::Runtime::GpuClothUtils::ResizeAndCopy<HG::Rendering::Runtime::ClothMetaData>);
			//     v15.x = cellIdx << 9;
			//     v11 = 8 * cellIdx;
			//     v15.z = cellIdx << 7;
			//     v12 = 0;
			//     v15.y = v11;
			//     v15.w = clothGroupData.clothGroupMeta.clothGroupHash;
			//     if ( clothGroupData.clothGroupMeta.clothNum > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         v8 = *(DynamicArray_1_HG_Rendering_Runtime_ClothMetaData_ **)&this[1].fields.clothConstData.clothParam1.z;
			//         if ( !v8 )
			//           break;
			//         Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item(
			//                  v8,
			//                  v12 + v10,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_Item);
			//         ++v12;
			//         Item.groupOffset = v15;
			//         if ( v12 >= clothGroupData.clothGroupMeta.clothNum )
			//           goto LABEL_8;
			//       }
			// LABEL_10:
			//       sub_180B536AC(v8, v7);
			//     }
			// LABEL_8:
			//     LOBYTE(this[1].fields.renderData.clothSkeletonDataBuffer) = 1;
			//   }
			// }
			// 
		}

		private unsafe int _UpdateRuntimeGroupMeta(ref ClothGroupMeta clothGroupMeta, byte* clothMetaBytes)
		{
			// // Int32 _UpdateRuntimeGroupMeta(ClothGroupMeta ByRef, Byte*)
			// int32_t HG::Rendering::Runtime::GpuClothManager::_UpdateRuntimeGroupMeta(
			//         GpuClothManager *this,
			//         ClothGroupMeta *clothGroupMeta,
			//         uint8_t *clothMetaBytes,
			//         MethodInfo *method)
			// {
			//   int32_t v4; // ebx
			//   GpuClothManager *v6; // rdi
			//   ComputeBuffer *clothMetaDataBuffer; // rcx
			//   int32_t v8; // r12d
			//   unsigned __int64 v9; // rdx
			//   int v10; // eax
			//   int32_t v11; // r13d
			//   int v12; // r14d
			//   NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *p_z; // rdi
			//   ClothGroupMeta *v14; // r15
			//   float v15; // xmm1_4
			//   uint32_t FixedElementField; // edx
			//   __int128 v17; // xmm0
			//   int v18; // eax
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm2
			//   __int128 v21; // xmm3
			//   __int128 v22; // xmm4
			//   __int128 v23; // xmm5
			//   __int64 v24; // r8
			//   int v25; // ecx
			//   __int64 clothGroupHash; // rdx
			//   __int64 v28; // [rsp+28h] [rbp-E0h]
			//   GpuClothManager_RuntimeClothData_Internal v29; // [rsp+38h] [rbp-D0h] BYREF
			//   __int128 v30; // [rsp+48h] [rbp-C0h] BYREF
			//   __int128 v31; // [rsp+58h] [rbp-B0h]
			//   __int128 v32; // [rsp+68h] [rbp-A0h]
			//   __int128 v33; // [rsp+78h] [rbp-90h]
			//   __int128 v34; // [rsp+88h] [rbp-80h]
			//   __int128 v35; // [rsp+98h] [rbp-70h] BYREF
			//   int v36; // [rsp+A8h] [rbp-60h]
			//   _BYTE v37[80]; // [rsp+B8h] [rbp-50h] BYREF
			//   __int128 v38; // [rsp+108h] [rbp+0h]
			//   int v39; // [rsp+118h] [rbp+10h]
			// 
			//   v4 = 0;
			//   v6 = this;
			//   if ( !byte_18D919CF2 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::ClothMetaData>::get_size);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Add);
			//     byte_18D919CF2 = 1;
			//   }
			//   clothMetaDataBuffer = v6[1].fields.clothMetaDataBuffer;
			//   v8 = -1;
			//   v9 = 0LL;
			//   if ( !clothMetaDataBuffer )
			//     goto LABEL_22;
			//   while ( (int)v9 < SLODWORD(clothMetaDataBuffer[1].klass) )
			//   {
			//     if ( (unsigned int)v9 >= LODWORD(clothMetaDataBuffer[1].klass) )
			//       sub_180070270(clothMetaDataBuffer, v9);
			//     if ( *((_DWORD *)&clothMetaDataBuffer[1].monitor + (int)v9) != -1 )
			//     {
			//       v8 = v9;
			//       *((_DWORD *)&clothMetaDataBuffer[1].monitor + (int)v9) = -1;
			//       break;
			//     }
			//     v9 = (unsigned int)(v9 + 1);
			//   }
			//   v10 = clothGroupMeta.clothNum + LODWORD(v6[1].fields.clothConstData.packedDeltaT.x);
			//   v11 = 0;
			//   ++LODWORD(v6[1].fields.clothConstData.packedDeltaT.y);
			//   v12 = v8 << 9;
			//   LODWORD(v6[1].fields.clothConstData.packedDeltaT.x) = v10;
			//   if ( clothGroupMeta.clothNum > 0 )
			//   {
			//     p_z = (NativeParallelHashMap_2_System_UInt32_HG_Rendering_Runtime_GpuClothManager_RuntimeClothData_Internal_ *)&v6[1].fields.clothConstData.packedDeltaT.z;
			//     v14 = clothGroupMeta + 1;
			//     do
			//     {
			//       LODWORD(v28) = 0;
			//       if ( v14.clothNum <= 256 )
			//         v15 = 0.0;
			//       else
			//         v15 = 1.0;
			//       FixedElementField = v14[-1].clothHashes.FixedElementField;
			//       *((float *)&v28 + 1) = (float)v12;
			//       *(_QWORD *)&v29.isDataReady = v28;
			//       v29.isSingleSkeleton = v15;
			//       Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Add(
			//         p_z,
			//         FixedElementField,
			//         &v29,
			//         MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::RuntimeClothData_Internal>::Add);
			//       v12 += v14.clothNum;
			//       ++v11;
			//       v14 = (ClothGroupMeta *)((char *)v14 + 4);
			//     }
			//     while ( v11 < clothGroupMeta.clothNum );
			//     v6 = this;
			//   }
			//   sub_1802F01E0(v37, 0LL, 100LL);
			//   v17 = *(_OWORD *)&clothGroupMeta.clothNum;
			//   v18 = v39;
			//   v19 = *(_OWORD *)&clothGroupMeta.clothHashes.FixedElementField;
			//   LODWORD(v38) = v8;
			//   v20 = *(_OWORD *)&clothGroupMeta[1].clothNum;
			//   v36 = v39;
			//   v21 = *(_OWORD *)&clothGroupMeta[1].clothHashes.FixedElementField;
			//   v22 = *(_OWORD *)&clothGroupMeta[2].clothNum;
			//   v23 = v38;
			//   v30 = v17;
			//   v31 = v19;
			//   v32 = v20;
			//   v33 = v21;
			//   v34 = v22;
			//   v35 = v38;
			//   if ( clothGroupMeta.clothNum > 0 )
			//   {
			//     v24 = *(_QWORD *)&v6[1].fields.clothConstData.clothParam1.z;
			//     v9 = (unsigned __int64)&v35 + 4;
			//     if ( v24 )
			//     {
			//       do
			//       {
			//         v25 = v4 + *(_DWORD *)(v24 + 24);
			//         ++v4;
			//         *(_DWORD *)v9 = v25;
			//         v9 += 4LL;
			//       }
			//       while ( v4 < clothGroupMeta.clothNum );
			//       v18 = v36;
			//       v23 = v35;
			//       v22 = v34;
			//       v21 = v33;
			//       v20 = v32;
			//       v19 = v31;
			//       v17 = v30;
			//       goto LABEL_21;
			//     }
			// LABEL_22:
			//     sub_180B536AC(clothMetaDataBuffer, v9);
			//   }
			// LABEL_21:
			//   clothGroupHash = clothGroupMeta.clothGroupHash;
			//   v30 = v17;
			//   v31 = v19;
			//   v32 = v20;
			//   v33 = v21;
			//   v34 = v22;
			//   v35 = v23;
			//   v36 = v18;
			//   sub_180638A34(
			//     &v6[1].fields.needClearGPUBuffer,
			//     clothGroupHash,
			//     &v30,
			//     MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal>::Add);
			//   return v8;
			// }
			// 
			return 0;
		}

		private void _InitStreamingGpuBuffer()
		{
			// // Void _InitStreamingGpuBuffer()
			// void HG::Rendering::Runtime::GpuClothManager::_InitStreamingGpuBuffer(GpuClothManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1155, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1155, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
			//       (ComputeBuffer **)&this.fields.shouldStep,
			//       176,
			//       200,
			//       0LL);
			//     HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
			//       (ComputeBuffer **)&this.fields.gameplayDt,
			//       192,
			//       25600,
			//       0LL);
			//     HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer((ComputeBuffer **)&this.fields.windTime, 16, 200, 0LL);
			//     HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
			//       (ComputeBuffer **)&this.fields.windNoiseUV,
			//       16,
			//       3200,
			//       0LL);
			//     HG::Rendering::Runtime::GpuClothUtils::ResizeComputeBuffer(
			//       (ComputeBuffer **)&this.fields.m_runtimeClothNum,
			//       96,
			//       25600,
			//       0LL);
			//     this.fields.isStreamingMode = 1;
			//   }
			// }
			// 
		}

		public static void PipelineUpdateV2(Transform centerTransform)
		{
			// // Void PipelineUpdateV2(Transform)
			// void HG::Rendering::Runtime::GpuClothManager::PipelineUpdateV2(Transform *centerTransform, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGEnvironmentPhase *s_interpolatedPhase; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   void (__fastcall *v8)(__int64 *); // rax
			//   __int64 v9; // rdx
			//   void (__fastcall *v10)(Transform *, unsigned __int64 *); // rax
			//   unsigned __int64 v11; // xmm0_8
			//   int v12; // eax
			//   void (__fastcall *v13)(unsigned __int64 *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rax
			//   __int64 v16; // rax
			//   __int64 v17; // rax
			//   unsigned __int64 v18; // [rsp+20h] [rbp-38h] BYREF
			//   int v19; // [rsp+28h] [rbp-30h]
			//   __int64 v20; // [rsp+30h] [rbp-28h] BYREF
			//   float z; // [rsp+38h] [rbp-20h]
			//   unsigned __int64 v22; // [rsp+40h] [rbp-18h] BYREF
			//   int v23; // [rsp+48h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDBFE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBFE = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_35;
			//   if ( wrapperArray.max_length.size > 640 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x280 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !*(_QWORD *)&v3[13]._1.static_fields_size )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(640, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//           (ILFixDynamicMethodWrapper_37 *)Patch,
			//           (Object *)centerTransform,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_35:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//   s_interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
			//   if ( !s_interpolatedPhase )
			//     sub_180B536AC(v7, v6);
			//   v20 = *(_QWORD *)&s_interpolatedPhase.fields.windConfig.direction.x;
			//   z = s_interpolatedPhase.fields.windConfig.direction.z;
			//   v8 = (void (__fastcall *)(__int64 *))qword_18D8F59E0;
			//   if ( !qword_18D8F59E0 )
			//   {
			//     v8 = (void (__fastcall *)(__int64 *))il2cpp_resolve_icall_0(
			//                                            "UnityEngine.HyperGryph.HGGpuClothManagerV2::SetWindDirection_Injected(UnityEngine.Vector3&)");
			//     if ( !v8 )
			//     {
			//       v15 = sub_1802DBBE8("UnityEngine.HyperGryph.HGGpuClothManagerV2::SetWindDirection_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v15, 0LL);
			//     }
			//     qword_18D8F59E0 = (__int64)v8;
			//   }
			//   v8(&v20);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v9);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v9);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !centerTransform )
			//     goto LABEL_29;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v9);
			//   if ( centerTransform.fields._._.m_CachedPtr )
			//   {
			//     v18 = 0LL;
			//     v19 = 0;
			//     v10 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18D8F52E0;
			//     if ( !qword_18D8F52E0 )
			//     {
			//       v10 = (void (__fastcall *)(Transform *, unsigned __int64 *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       if ( !v10 )
			//       {
			//         v16 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v16, 0LL);
			//       }
			//       qword_18D8F52E0 = (__int64)v10;
			//     }
			//     v10(centerTransform, &v18);
			//     v11 = v18;
			//     v12 = v19;
			//   }
			//   else
			//   {
			// LABEL_29:
			//     v12 = _mm_cvtsi128_si32((__m128i)0LL);
			//     v11 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   }
			//   v23 = v12;
			//   v13 = (void (__fastcall *)(unsigned __int64 *))qword_18D8F59E8;
			//   v22 = v11;
			//   if ( !qword_18D8F59E8 )
			//   {
			//     v13 = (void (__fastcall *)(unsigned __int64 *))il2cpp_resolve_icall_0(
			//                                                      "UnityEngine.HyperGryph.HGGpuClothManagerV2::SetPlayerCenter_Injecte"
			//                                                      "d(UnityEngine.Vector3&)");
			//     if ( !v13 )
			//     {
			//       v17 = sub_1802DBBE8("UnityEngine.HyperGryph.HGGpuClothManagerV2::SetPlayerCenter_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v17, 0LL);
			//     }
			//     qword_18D8F59E8 = (__int64)v13;
			//   }
			//   v13(&v22);
			// }
			// 
		}

		public const int MAX_ANCHOR_NUM = 2;

		public const int MAX_NEIGHBOR_NUM = 8;

		public const int MAX_CLOTH_NEIGHBOR_NUM = 128;

		public const int CLOTH_BATCH_SIZE = 256;

		public const int MAX_COLLIDER_NUM = 4;

		public const int MAX_RUNTIME_CLOTH_GROUP_NUM = 50;

		internal readonly Vector4 CHARACTER_POSITION_OFFSET;

		internal readonly Vector4 INVALID_POSITION;

		internal ClothConstData clothConstData;

		private Mesh m_characterMesh;

		private float m_capsuleRadius;

		private float m_capsuleHeight;

		internal bool needClearGPUBuffer;

		internal ComputeBuffer clothNodeDataBuffer;

		internal ComputeBuffer clothMetaDataBuffer;

		internal ComputeBuffer clothBatchMetaDataBuffer;

		internal ComputeBuffer clothBatchCacheMapBuffer;

		internal ComputeBuffer clothSkeletonDataBuffer;

		internal GpuClothRenderData renderData;

		internal GpuClothClearBufferData clearBufferData;

		internal bool isStreamingMode;

		internal float skeletonFlipped;

		internal const float PHYSICS_DELTA_TIME = 0.023333333f;

		internal float gameplayDt;

		internal float cumulativeTime;

		internal bool shouldStep;

		internal float loopNum;

		internal float windTime;

		internal float windSpeed;

		internal Vector2 windNoiseUV;

		private int m_runtimeClothNum;

		private int m_runtimeClothGroupNum;

		private NativeParallelHashMap<uint, GpuClothManager.RuntimeClothData_Internal> m_clothHashToRuntimeClothData;

		private DynamicArray<ClothMetaData> m_runtimeClothMetaArray;

		private bool m_isForcedRefresh;

		private NativeParallelHashMap<uint, GpuClothManager.ClothGroupData_Internal> m_registedClothGroupData;

		private NativeParallelHashMap<uint, GpuClothManager.ClothGroupMeta_Internal> m_activatedGroupHashToGroupMeta;

		private int[] m_availableCellIdx;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static GpuClothManager.ClothActivateComparer s_clothActiveComparer;

		private IndexedHashSet<uint> m_shouldActivatedGroupHash;

		private NativeParallelHashSet<uint> m_activatedGroupHash;

		private NativeParallelHashSet<uint> m_lastActivatedGroupHash;

		private DynamicArray<uint> m_pendingActivateGroupHash;

		private DynamicArray<uint> m_pendingDeactivateGroupHash;

		private Vector2 m_lastPlayerCenterXZ;

		private Vector2 m_playerCenterXZ;

		private const float CLOTH_DIRTY_DISTANCE = 32f;

		private NativeParallelHashSet<uint> m_groupHashNeedToUpload;

		private NativeParallelHashSet<uint> m_groupHashUploaded;

		private bool m_isClothMetaBufferDirty;

		internal GpuClothGroupUploadData clothGroupUploadData;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 100)]
		private struct ClothGroupMeta_Internal
		{
			public void FindAndSetClothMetaIdx(int oldIdx, int newIdx)
			{
				// // Void FindAndSetClothMetaIdx(Int32, Int32)
				// void HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx(
				//         GpuClothManager_ClothGroupMeta_Internal *this,
				//         int32_t oldIdx,
				//         int32_t newIdx,
				//         MethodInfo *method)
				// {
				//   __int64 clothNum; // r8
				//   int v8; // eax
				//   __int64 v9; // rdx
				//   uint32_t *p_clothGroupHash; // rcx
				//   __int64 v11; // rax
				//   ArgumentOutOfRangeException *v12; // rax
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   ArgumentOutOfRangeException *v15; // rbx
				//   __int64 v16; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1147, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1147, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_424(Patch, this, oldIdx, newIdx, 0LL);
				//       return;
				//     }
				// LABEL_10:
				//     sub_180B536AC(v14, v13);
				//   }
				//   clothNum = this.clothGroupMeta.clothNum;
				//   v8 = 0;
				//   if ( clothNum <= 0 )
				//   {
				// LABEL_6:
				//     v11 = sub_18000F7E0(&TypeInfo::System::ArgumentOutOfRangeException);
				//     v12 = (ArgumentOutOfRangeException *)sub_180004920(v11);
				//     v15 = v12;
				//     if ( v12 )
				//     {
				//       System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v12, 0LL);
				//       v16 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::GpuClothManager::ClothGroupMeta_Internal::FindAndSetClothMetaIdx);
				//       sub_18000F7C0(v15, v16);
				//     }
				//     goto LABEL_10;
				//   }
				//   v9 = 0LL;
				//   p_clothGroupHash = &this[2].clothGroupMeta.clothGroupHash;
				//   while ( *p_clothGroupHash != oldIdx )
				//   {
				//     ++v8;
				//     ++v9;
				//     ++p_clothGroupHash;
				//     if ( v9 >= clothNum )
				//       goto LABEL_6;
				//   }
				//   *(&this[2].clothGroupMeta.clothGroupHash + v8) = newIdx;
				// }
				// 
			}

			public ClothGroupMeta clothGroupMeta;

			public int cellIdx;

			[FixedBuffer(typeof(int), 4)]
			public GpuClothManager.ClothGroupMeta_Internal.<clothMetaIdx>e__FixedBuffer clothMetaIdx;

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
			public struct <clothMetaIdx>e__FixedBuffer
			{
				public int FixedElementField;
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 144)]
		private struct ClothGroupData_Internal
		{
			public void CopyFromClothGroupData(in ClothGroupData groupData)
			{
				// // Void CopyFromClothGroupData(ClothGroupData ByRef)
				// void HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::CopyFromClothGroupData(
				//         GpuClothManager_ClothGroupData_Internal *this,
				//         ClothGroupData *groupData,
				//         MethodInfo *method)
				// {
				//   __int128 v5; // xmm1
				//   Span_1_Byte_ groupClothMetaBytes; // xmm0
				//   Span_1_Byte_ groupClothNodeBytes; // xmm1
				//   Span_1_Byte_ groupClothBatchMetaBytes; // xmm0
				//   MissionAcceptMode_EnterAreaInfo_MissionArea *PinnableReference; // rax
				//   int64_t length; // rcx
				//   Void *v11; // rbx
				//   uint8_t *v12; // rax
				//   int64_t groupClothBatchCacheBytesSize; // r8
				//   MissionAcceptMode_EnterAreaInfo_MissionArea *v14; // rax
				//   __int64 x_low; // rcx
				//   Void *v16; // rbx
				//   Void *v17; // rax
				//   int64_t v18; // r8
				//   MissionAcceptMode_EnterAreaInfo_MissionArea *v19; // rax
				//   int64_t FixedElementField; // rcx
				//   Void *v21; // rbx
				//   Void *v22; // rax
				//   int64_t v23; // r8
				//   MissionAcceptMode_EnterAreaInfo_MissionArea *v24; // rax
				//   int64_t v25; // rcx
				//   Void *v26; // rbx
				//   uint8_t *v27; // rax
				//   int64_t groupClothMetaBytesSize; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v30; // rdx
				//   __int64 v31; // rcx
				//   ClothGroupMeta v32; // [rsp+20h] [rbp-58h] BYREF
				//   Span_1_Byte_ v33; // [rsp+40h] [rbp-38h]
				//   Span_1_Byte_ v34; // [rsp+50h] [rbp-28h]
				//   Span_1_Byte_ v35; // [rsp+60h] [rbp-18h]
				// 
				//   if ( !byte_18D919CF3 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Span<unsigned char>::GetPinnableReference);
				//     sub_18003C530(&MethodInfo::System::Span<unsigned char>::get_Length);
				//     byte_18D919CF3 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1157, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1157, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v31, v30);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_429(Patch, this, groupData, 0LL);
				//   }
				//   else
				//   {
				//     v5 = *(_OWORD *)&groupData.clothGroupMeta.clothHashes.FixedElementField;
				//     *(_OWORD *)&v32.clothNum = *(_OWORD *)&groupData.clothGroupMeta.clothNum;
				//     groupClothMetaBytes = groupData.groupClothMetaBytes;
				//     *(_OWORD *)&v32.clothHashes.FixedElementField = v5;
				//     groupClothNodeBytes = groupData.groupClothNodeBytes;
				//     v33 = groupClothMetaBytes;
				//     groupClothBatchMetaBytes = groupData.groupClothBatchMetaBytes;
				//     v34 = groupClothNodeBytes;
				//     v35 = groupClothBatchMetaBytes;
				//     HG::Rendering::Runtime::ClothGroupMeta::CopyFromClothGroupMeta(&this.clothGroupMeta, &v32, 0LL);
				//     PinnableReference = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
				//                           (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData.groupClothBatchCacheBytes,
				//                           MethodInfo::System::Span<unsigned char>::GetPinnableReference);
				//     length = groupData.groupClothBatchCacheBytes._length;
				//     this.groupClothBatchCacheBytesSize = length;
				//     v11 = (Void *)PinnableReference;
				//     v12 = (uint8_t *)Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(
				//                        length,
				//                        0,
				//                        Allocator__Enum_Persistent,
				//                        0LL);
				//     groupClothBatchCacheBytesSize = this.groupClothBatchCacheBytesSize;
				//     this.groupClothBatchCacheBytes = v12;
				//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v12, v11, groupClothBatchCacheBytesSize, 0LL);
				//     v14 = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
				//             (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData[1],
				//             MethodInfo::System::Span<unsigned char>::GetPinnableReference);
				//     x_low = SLODWORD(groupData[1].clothGroupMeta.groupWorldPosXZ.x);
				//     LODWORD(this[1].clothGroupMeta.groupWorldPosXZ.x) = x_low;
				//     v16 = (Void *)v14;
				//     v17 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(x_low, 0, Allocator__Enum_Persistent, 0LL);
				//     v18 = SLODWORD(this[1].clothGroupMeta.groupWorldPosXZ.x);
				//     *(_QWORD *)&this[1].clothGroupMeta.clothNum = v17;
				//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v17, v16, v18, 0LL);
				//     v19 = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
				//             (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData[1].clothGroupMeta.clothHashes,
				//             MethodInfo::System::Span<unsigned char>::GetPinnableReference);
				//     FixedElementField = groupData[1].clothGroupMeta.clothBatchNum.FixedElementField;
				//     this[1].clothGroupMeta.clothBatchNum.FixedElementField = FixedElementField;
				//     v21 = (Void *)v19;
				//     v22 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(
				//             FixedElementField,
				//             0,
				//             Allocator__Enum_Persistent,
				//             0LL);
				//     v23 = this[1].clothGroupMeta.clothBatchNum.FixedElementField;
				//     *(_QWORD *)&this[1].clothGroupMeta.clothHashes.FixedElementField = v22;
				//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v22, v21, v23, 0LL);
				//     v24 = System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::GetPinnableReference(
				//             (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&groupData[1].groupClothMetaBytes,
				//             MethodInfo::System::Span<unsigned char>::GetPinnableReference);
				//     v25 = groupData[1].groupClothMetaBytes._length;
				//     this[1].groupClothMetaBytesSize = v25;
				//     v26 = (Void *)v24;
				//     v27 = (uint8_t *)Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(
				//                        v25,
				//                        0,
				//                        Allocator__Enum_Persistent,
				//                        0LL);
				//     groupClothMetaBytesSize = this[1].groupClothMetaBytesSize;
				//     this[1].groupClothMetaBytes = v27;
				//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v27, v26, groupClothMetaBytesSize, 0LL);
				//   }
				// }
				// 
			}

			public void Reset()
			{
				// // Void Reset()
				// void HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal::Reset(
				//         GpuClothManager_ClothGroupData_Internal *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1161, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1161, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_431(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     if ( this.groupClothBatchCacheBytes )
				//     {
				//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
				//         (Void *)this.groupClothBatchCacheBytes,
				//         Allocator__Enum_Persistent,
				//         0LL);
				//       this.groupClothBatchCacheBytes = 0LL;
				//     }
				//     this.groupClothBatchCacheBytesSize = 0;
				//     if ( *(_QWORD *)&this[1].clothGroupMeta.clothNum )
				//     {
				//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
				//         *(Void **)&this[1].clothGroupMeta.clothNum,
				//         Allocator__Enum_Persistent,
				//         0LL);
				//       *(_QWORD *)&this[1].clothGroupMeta.clothNum = 0LL;
				//     }
				//     this[1].clothGroupMeta.groupWorldPosXZ.x = 0.0;
				//     if ( *(_QWORD *)&this[1].clothGroupMeta.clothHashes.FixedElementField )
				//     {
				//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
				//         *(Void **)&this[1].clothGroupMeta.clothHashes.FixedElementField,
				//         Allocator__Enum_Persistent,
				//         0LL);
				//       *(_QWORD *)&this[1].clothGroupMeta.clothHashes.FixedElementField = 0LL;
				//     }
				//     this[1].clothGroupMeta.clothBatchNum.FixedElementField = 0;
				//     if ( this[1].groupClothMetaBytes )
				//     {
				//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
				//         (Void *)this[1].groupClothMetaBytes,
				//         Allocator__Enum_Persistent,
				//         0LL);
				//       this[1].groupClothMetaBytes = 0LL;
				//     }
				//     this[1].groupClothMetaBytesSize = 0;
				//   }
				// }
				// 
			}

			public ClothGroupMeta clothGroupMeta;

			public unsafe byte* groupClothMetaBytes;

			public int groupClothMetaBytesSize;

			public unsafe byte* groupClothNodeBytes;

			public int groupClothNodeBytesSize;

			public unsafe byte* groupClothBatchMetaBytes;

			public int groupClothBatchMetaBytesSize;

			public unsafe byte* groupClothBatchCacheBytes;

			public int groupClothBatchCacheBytesSize;
		}

		private class ClothActivateComparer : IComparer<uint>
		{
			public ClothActivateComparer()
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

			public int Compare(uint a, uint b)
			{
				// // Int32 Compare(UInt32, UInt32)
				// int32_t HG::Rendering::Runtime::GpuClothManager::ClothActivateComparer::Compare(
				//         GpuClothManager_ClothActivateComparer *this,
				//         uint32_t a,
				//         uint32_t b,
				//         MethodInfo *method)
				// {
				//   int32_t v7; // edi
				//   __m128 x_low; // xmm6
				//   __m128 y_low; // xmm7
				//   double v10; // xmm0_8
				//   __m128 v11; // xmm6
				//   float v12; // xmm8_4
				//   __m128 v13; // xmm7
				//   double v14; // xmm0_8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v17; // rdx
				//   __int64 v18; // rcx
				//   __int64 v19; // [rsp+30h] [rbp-D8h] BYREF
				//   GpuClothManager_ClothGroupData_Internal v20[2]; // [rsp+38h] [rbp-D0h] BYREF
				// 
				//   v7 = 1;
				//   if ( !byte_18D919CF4 )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
				//     byte_18D919CF4 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1177, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1177, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v18, v17);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
				//              (ILFixDynamicMethodWrapper_14 *)Patch,
				//              (Object *)this,
				//              (SocketOptionLevel__Enum)a,
				//              (SocketOptionName__Enum)b,
				//              0LL);
				//   }
				//   else
				//   {
				//     x_low = (__m128)LODWORD(this.fields.playerCenterXZ.x);
				//     y_low = (__m128)LODWORD(this.fields.playerCenterXZ.y);
				//     Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
				//       v20,
				//       this.fields.registedClothGroupData,
				//       a,
				//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
				//     v19 = sub_18473B264(
				//             _mm_unpacklo_ps(x_low, y_low).m128_u64[0],
				//             _mm_unpacklo_ps(
				//               (__m128)LODWORD(v20[0].clothGroupMeta.groupWorldPosXZ.x),
				//               (__m128)LODWORD(v20[0].clothGroupMeta.groupWorldPosXZ.y)).m128_u64[0]);
				//     v10 = sub_182413570(&v19);
				//     v11 = (__m128)LODWORD(this.fields.playerCenterXZ.x);
				//     v12 = *(float *)&v10;
				//     v13 = (__m128)LODWORD(this.fields.playerCenterXZ.y);
				//     Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item(
				//       v20,
				//       this.fields.registedClothGroupData,
				//       b,
				//       MethodInfo::Unity::Collections::NativeParallelHashMap<unsigned int,HG::Rendering::Runtime::GpuClothManager::ClothGroupData_Internal>::get_Item);
				//     v19 = sub_18473B264(
				//             _mm_unpacklo_ps(v11, v13).m128_u64[0],
				//             _mm_unpacklo_ps(
				//               (__m128)LODWORD(v20[0].clothGroupMeta.groupWorldPosXZ.x),
				//               (__m128)LODWORD(v20[0].clothGroupMeta.groupWorldPosXZ.y)).m128_u64[0]);
				//     v14 = sub_182413570(&v19);
				//     if ( *(float *)&v14 > v12 )
				//       return -1;
				//     return v7;
				//   }
				// }
				// 
				return 0;
			}

			public Vector2 playerCenterXZ;

			public unsafe NativeParallelHashMap<uint, GpuClothManager.ClothGroupData_Internal>* registedClothGroupData;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		private struct RuntimeClothData_Internal
		{
			public bool isDataReady;

			public float skeletonOffset;

			public float isSingleSkeleton;
		}
	}
}
