using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class SubsurfaceManager // TypeDefIndex: 38609
	{
		// Fields
		private const int NONE_SUBSURFACE_MATERIAL_INDEX = 0; // Metadata: 0x02303F42
		private const int MAX_SUBSURFACE_MATERIAL_COUNT = 63; // Metadata: 0x02303F43
		private Dictionary<int, int> instanceId2Index; // 0x10
		private SubsurfaceData[] dataList; // 0x18
	
		// Nested types
		internal struct SubsurfaceConstants // TypeDefIndex: 38608
		{
			// Fields
			public unsafe fixed /* 0x00000000-0x00000000 */ float _SubsurfaceParams[0]; // 0x00
		}
	
		// Constructors
		public SubsurfaceManager() {} // 0x0000000182ED8D20-0x0000000182ED8D90
		// SubsurfaceManager()
		void HG::Rendering::Runtime::SubsurfaceManager::SubsurfaceManager(SubsurfaceManager *this, MethodInfo *method)
		{
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_System_Int32_System_Int32_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,int>);
		  v6 = (Dictionary_2_System_Int32_System_Int32_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<int,int>::Dictionary);
		  this->fields.instanceId2Index = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v13);
		  this->fields.dataList = (SubsurfaceData__Array *)il2cpp_array_new_specific_1(
		                                                     TypeInfo::HG::Rendering::Runtime::SubsurfaceData,
		                                                     63LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.dataList, v10, v11, v12, v14);
		}
		
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterMaterialCallback() {} // 0x000000018485F9B0-0x000000018485FA50
		// Void RegisterMaterialCallback()
		void HG::Rendering::Runtime::SubsurfaceManager::RegisterMaterialCallback(MethodInfo *method)
		{
		  UnityAction_2_System_Int32_System_Boolean_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  UnityAction_2_System_Int32_System_Boolean_ *v4; // rbx
		  UnityAction_2_System_Int32_System_Boolean_ *v5; // rax
		  UnityAction_2_System_Int32_System_Boolean_ *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3911, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3911, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    v1 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_1800368D0(TypeInfo::UnityEngine::Events::UnityAction<int,bool>);
		    v4 = v1;
		    if ( !v1
		      || (UnityEngine::Events::UnityAction<int,bool>::UnityAction(
		            v1,
		            0LL,
		            MethodInfo::HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged,
		            0LL),
		          UnityEngine::HyperGryph::HGShadingStateSystem::remove_shadingStateChanged(v4, 0LL),
		          v5 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_1800368D0(TypeInfo::UnityEngine::Events::UnityAction<int,bool>),
		          (v6 = v5) == 0LL) )
		    {
		LABEL_4:
		      sub_1800D8260(v3, v2);
		    }
		    UnityEngine::Events::UnityAction<int,bool>::UnityAction(
		      v5,
		      0LL,
		      MethodInfo::HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged,
		      0LL);
		    UnityEngine::HyperGryph::HGShadingStateSystem::add_shadingStateChanged(v6, 0LL);
		    UnityEngine::HyperGryph::HGShadingStateSystem::FlushAllMaterialCallbacks(0LL);
		  }
		}
		
		private static void OnShadingStateChanged(int instanceId, bool state) {} // 0x0000000189C1B430-0x0000000189C1B4D4
		// Void OnShadingStateChanged(Int32, Boolean)
		void HG::Rendering::Runtime::SubsurfaceManager::OnShadingStateChanged(
		        int32_t instanceId,
		        bool state,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  SubsurfaceManager *subsurfaceManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3912, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3912, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34((ILFixDynamicMethodWrapper_18 *)Patch, instanceId, state, 0LL);
		  }
		  else
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      return;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !state )
		    {
		      if ( currentManagerContext )
		      {
		        subsurfaceManager_k__BackingField = currentManagerContext->fields._subsurfaceManager_k__BackingField;
		        if ( subsurfaceManager_k__BackingField )
		        {
		          HG::Rendering::Runtime::SubsurfaceManager::UnregisterSubsurfaceMaterial(
		            subsurfaceManager_k__BackingField,
		            instanceId,
		            0LL);
		          return;
		        }
		      }
		LABEL_11:
		      sub_1800D8260(subsurfaceManager_k__BackingField, v6);
		    }
		    if ( !currentManagerContext )
		      goto LABEL_11;
		    subsurfaceManager_k__BackingField = currentManagerContext->fields._subsurfaceManager_k__BackingField;
		    if ( !subsurfaceManager_k__BackingField )
		      goto LABEL_11;
		    HG::Rendering::Runtime::SubsurfaceManager::RegisterSubsurfaceMaterial(
		      subsurfaceManager_k__BackingField,
		      instanceId,
		      0LL);
		  }
		}
		
		public void RegisterSubsurfaceMaterial(int instanceId) {} // 0x0000000189C1B4D4-0x0000000189C1B764
		// Void RegisterSubsurfaceMaterial(Int32)
		void HG::Rendering::Runtime::SubsurfaceManager::RegisterSubsurfaceMaterial(
		        SubsurfaceManager *this,
		        int32_t instanceId,
		        MethodInfo *method)
		{
		  uint32_t MaterialHandle; // eax
		  Material *Material; // r14
		  __int64 v7; // rdx
		  Dictionary_2_System_Int32_System_Int32_ *instanceId2Index; // rcx
		  __int64 v9; // rsi
		  SubsurfaceData *v10; // rax
		  _DWORD *v11; // rax
		  int32_t v12; // ebx
		  SubsurfaceData *v13; // rax
		  __int64 v14; // rax
		  __int64 v15; // xmm1_8
		  int v16; // esi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SubsurfaceData data; // [rsp+20h] [rbp-38h] BYREF
		  int32_t value; // [rsp+78h] [rbp+20h] BYREF
		
		  value = 0;
		  memset(&data, 0, sizeof(data));
		  if ( IFix::WrappersManagerImpl::IsPatched(3914, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3914, 0LL);
		    if ( !Patch )
		      goto LABEL_38;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      instanceId,
		      0LL);
		  }
		  else
		  {
		    MaterialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(instanceId, 0LL);
		    if ( MaterialHandle )
		    {
		      Material = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterial(MaterialHandle, 0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Implicit((Object_1 *)Material, 0LL)
		        && HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceData(Material, &data, 0LL) )
		      {
		        instanceId2Index = this->fields.instanceId2Index;
		        if ( !instanceId2Index )
		          goto LABEL_38;
		        if ( System::Collections::Generic::Dictionary<int,int>::TryGetValue(
		               instanceId2Index,
		               instanceId,
		               &value,
		               MethodInfo::System::Collections::Generic::Dictionary<int,int>::TryGetValue) )
		        {
		          instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		          if ( !instanceId2Index )
		            goto LABEL_38;
		          v9 = value;
		          v10 = (SubsurfaceData *)sub_1803C0734(instanceId2Index, value);
		          if ( HG::Rendering::Runtime::SubsurfaceData::Equals(v10, &data, 0LL) )
		            goto LABEL_32;
		          instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		          if ( !instanceId2Index )
		            goto LABEL_38;
		          v11 = (_DWORD *)sub_1803C0734(instanceId2Index, v9);
		          --*v11;
		          instanceId2Index = this->fields.instanceId2Index;
		          if ( !instanceId2Index )
		            goto LABEL_38;
		          System::Collections::Generic::Dictionary<int,int>::Remove(
		            instanceId2Index,
		            instanceId,
		            MethodInfo::System::Collections::Generic::Dictionary<int,int>::Remove);
		        }
		        LODWORD(v9) = -1;
		        v12 = 0;
		        while ( 1 )
		        {
		          instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		          if ( !instanceId2Index )
		            goto LABEL_38;
		          if ( *(int *)sub_1803C0734(instanceId2Index, v12) > 0 )
		          {
		            instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		            if ( !instanceId2Index )
		              goto LABEL_38;
		            v13 = (SubsurfaceData *)sub_1803C0734(instanceId2Index, v12);
		            if ( HG::Rendering::Runtime::SubsurfaceData::Equals(v13, &data, 0LL) )
		              break;
		          }
		          if ( (_DWORD)v9 == -1 )
		          {
		            instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		            if ( !instanceId2Index )
		              goto LABEL_38;
		            if ( !*(_DWORD *)sub_1803C0734(instanceId2Index, v12) )
		              LODWORD(v9) = v12;
		          }
		          if ( ++v12 >= 63 )
		            goto LABEL_22;
		        }
		        if ( v12 == -1 )
		        {
		LABEL_22:
		          v12 = v9;
		          if ( (_DWORD)v9 == -1 )
		          {
		            HG::Rendering::HGRPLogger::LogError((String *)"Subsurface material exceed max count", 0LL);
		            goto LABEL_32;
		          }
		        }
		        else
		        {
		          LODWORD(v9) = v12;
		        }
		        instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		        if ( !instanceId2Index )
		          goto LABEL_38;
		        data.RefCount = *(_DWORD *)sub_1803C0734(instanceId2Index, v12) + 1;
		        instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		        if ( !instanceId2Index )
		          goto LABEL_38;
		        if ( (unsigned int)v12 >= LODWORD(instanceId2Index->fields._entries) )
		          sub_1800D2AB0(instanceId2Index, v7);
		        v14 = 3LL * v12;
		        v15 = *(_QWORD *)&data.SubsurfaceColor.a;
		        *(_OWORD *)(&instanceId2Index->fields._count + 2 * v14) = *(_OWORD *)&data.RefCount;
		        *((_QWORD *)&instanceId2Index->fields._comparer + v14) = v15;
		        instanceId2Index = this->fields.instanceId2Index;
		        if ( !instanceId2Index )
		          goto LABEL_38;
		        System::Collections::Generic::Dictionary<int,int>::Add(
		          instanceId2Index,
		          instanceId,
		          v12,
		          MethodInfo::System::Collections::Generic::Dictionary<int,int>::Add);
		LABEL_32:
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        if ( (_DWORD)v9 == -1 )
		          v16 = 0;
		        else
		          v16 = v9 + 1;
		        if ( Material )
		        {
		          UnityEngine::Material::SetFloatImpl(
		            Material,
		            TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceInt,
		            (float)v16,
		            0LL);
		          return;
		        }
		LABEL_38:
		        sub_1800D8260(instanceId2Index, v7);
		      }
		    }
		  }
		}
		
		public void UnregisterSubsurfaceMaterial(int instanceId) {} // 0x0000000189C1B764-0x0000000189C1B80C
		// Void UnregisterSubsurfaceMaterial(Int32)
		void HG::Rendering::Runtime::SubsurfaceManager::UnregisterSubsurfaceMaterial(
		        SubsurfaceManager *this,
		        int32_t instanceId,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_Int32_System_Int32_ *instanceId2Index; // rcx
		  _DWORD *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t value; // [rsp+48h] [rbp+20h] BYREF
		
		  value = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3915, 0LL) )
		  {
		    instanceId2Index = this->fields.instanceId2Index;
		    if ( instanceId2Index )
		    {
		      if ( !System::Collections::Generic::Dictionary<int,int>::TryGetValue(
		              instanceId2Index,
		              instanceId,
		              &value,
		              MethodInfo::System::Collections::Generic::Dictionary<int,int>::TryGetValue) )
		        return;
		      instanceId2Index = (Dictionary_2_System_Int32_System_Int32_ *)this->fields.dataList;
		      if ( instanceId2Index )
		      {
		        v7 = (_DWORD *)sub_1803C0734(instanceId2Index, value);
		        --*v7;
		        instanceId2Index = this->fields.instanceId2Index;
		        if ( instanceId2Index )
		        {
		          System::Collections::Generic::Dictionary<int,int>::Remove(
		            instanceId2Index,
		            instanceId,
		            MethodInfo::System::Collections::Generic::Dictionary<int,int>::Remove);
		          return;
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(instanceId2Index, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3915, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, instanceId, 0LL);
		}
		
		public void BindSubsurfaceData(HGRenderGraphContext context) {} // 0x0000000189C1B19C-0x0000000189C1B430
		// Void BindSubsurfaceData(HGRenderGraphContext)
		void HG::Rendering::Runtime::SubsurfaceManager::BindSubsurfaceData(
		        SubsurfaceManager *this,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  int v6; // ebx
		  float *v7; // rdi
		  SubsurfaceData__Array *dataList; // rcx
		  void *v9; // xmm1_8
		  int v10; // xmm1_4
		  float v11; // xmm0_4
		  int ptr_high; // xmm1_4
		  CBHandle *v13; // rax
		  void *ptr; // xmm1_8
		  __int64 v15; // rdx
		  _OWORD *v16; // rax
		  _OWORD *v17; // rcx
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  CommandBuffer *cmd; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int v33; // [rsp+30h] [rbp-D0h] BYREF
		  float v34[3]; // [rsp+34h] [rbp-CCh] BYREF
		  _BYTE offset[24]; // [rsp+40h] [rbp-C0h] BYREF
		  CBHandle v36; // [rsp+60h] [rbp-A0h] BYREF
		  _BYTE v37[4]; // [rsp+80h] [rbp-80h] BYREF
		  char v38; // [rsp+84h] [rbp-7Ch] BYREF
		  _BYTE v39[1008]; // [rsp+470h] [rbp+370h] BYREF
		  int v40; // [rsp+898h] [rbp+798h] BYREF
		
		  v33 = 0;
		  v34[0] = 0.0;
		  v40 = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3916, 0LL) )
		  {
		    sub_18033B9D0(v37, 0LL, 1008LL);
		    v6 = 0;
		    v7 = (float *)&v38;
		    do
		    {
		      dataList = this->fields.dataList;
		      if ( !dataList )
		        goto LABEL_15;
		      if ( (unsigned int)v6 >= dataList->max_length.size )
		        sub_1800D2AB0(dataList, static_fields);
		      static_fields = (HGShaderIDs__StaticFields *)(3LL * v6);
		      v9 = *(void **)&dataList->vector[v6].SubsurfaceColor.a;
		      *(_OWORD *)&v36.bufferId = *(_OWORD *)&dataList->vector[v6].RefCount;
		      v36.ptr = v9;
		      *(_QWORD *)&offset[16] = v9;
		      if ( _mm_cvtsi128_si32(*(__m128i *)&v36.bufferId) > 0 )
		      {
		        *(_OWORD *)offset = *(_OWORD *)&v36.bufferId;
		        *(_QWORD *)&offset[16] = v9;
		        *(_OWORD *)offset = *(_OWORD *)&offset[4];
		        UnityEngine::Color::RGBToHSV((Color *)offset, (float *)&v33, v34, (float *)&v40, 0LL);
		        v10 = v33;
		        *((_DWORD *)v7 - 1) = v40;
		        v11 = v34[0];
		        *(_DWORD *)v7 = v10;
		        ptr_high = HIDWORD(v36.ptr);
		        v7[1] = v11;
		        *((_DWORD *)v7 + 2) = ptr_high;
		      }
		      ++v6;
		      v7 += 4;
		    }
		    while ( v6 < 63 );
		    if ( context )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v13 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		              &v36,
		              &context->fields.renderContext,
		              1008,
		              0LL);
		      ptr = v13->ptr;
		      *(_OWORD *)offset = *(_OWORD *)&v13->bufferId;
		      *(_QWORD *)&offset[16] = ptr;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v15 = 7LL;
		      v16 = v39;
		      v17 = v37;
		      do
		      {
		        v18 = v17[1];
		        *v16 = *v17;
		        v19 = v17[2];
		        v16[1] = v18;
		        v20 = v17[3];
		        v16[2] = v19;
		        v21 = v17[4];
		        v16[3] = v20;
		        v22 = v17[5];
		        v16[4] = v21;
		        v23 = v17[6];
		        v16[5] = v22;
		        v24 = v17[7];
		        v17 += 8;
		        v16[6] = v23;
		        v16 += 8;
		        *(v16 - 1) = v24;
		        --v15;
		      }
		      while ( v15 );
		      v25 = v17[1];
		      *v16 = *v17;
		      v26 = v17[2];
		      v16[1] = v25;
		      v27 = v17[3];
		      v16[2] = v26;
		      v28 = v17[4];
		      v16[3] = v27;
		      v29 = v17[5];
		      v16[4] = v28;
		      v30 = v17[6];
		      v16[5] = v29;
		      v16[6] = v30;
		      sub_1808B0CD4(offset, v39, 128LL);
		      cmd = context->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( cmd )
		      {
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          cmd,
		          *(uint32_t *)offset,
		          static_fields->_SubsurfaceConstants,
		          *(int32_t *)&offset[4],
		          1008,
		          0LL);
		        return;
		      }
		    }
		LABEL_15:
		    sub_1800D8260(dataList, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3916, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)context,
		    0LL);
		}
		
	}
}
