using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TerrainSubsurfaceData
	{
		public void SetupTerrainParams(HGRenderGraphContext context)
		{
			// // Void SetupTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::SetupTerrainParams(
			//         TerrainSubsurfaceData *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *static_fields; // rcx
			//   CommandBuffer *cmd; // r14
			//   AttributeCollection *instance; // rax
			//   bool v9; // r12
			//   __int64 v10; // rax
			//   bool UseSubsurfaceProfile; // bl
			//   String *s_SubsurfaceProfile; // r15
			//   bool v13; // bp
			//   CBHandle *v14; // rax
			//   __m128i v15; // xmm6
			//   HGManagerContext *currentManagerContext; // rax
			//   int32_t TerrainSubsurfaceProfileInt; // ecx
			//   int32_t v18; // ebx
			//   __int64 v19; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v21; // [rsp+30h] [rbp-68h]
			//   CBHandle v22; // [rsp+40h] [rbp-58h] BYREF
			//   int32_t ref; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919D3B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919D3B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4761, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       instance = (AttributeCollection *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//       if ( instance )
			//       {
			//         v9 = System::ComponentModel::AttributeCollection::get_Count(instance, 0LL) == 1;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         v10 = *((_QWORD *)static_fields + 54);
			//         if ( v10 )
			//         {
			//           if ( *(_BYTE *)(v10 + 16) )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//             UseSubsurfaceProfile = this._Params._UseSubsurfaceProfile;
			//             s_SubsurfaceProfile = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SubsurfaceProfile;
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//             v13 = UseSubsurfaceProfile && v9;
			//           }
			//           else
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//             v13 = this._Params._UseSubsurfaceProfile;
			//             s_SubsurfaceProfile = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SubsurfaceProfile;
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//           }
			//           UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_SubsurfaceProfile, v13, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//           if ( cmd )
			//           {
			//             UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//               cmd,
			//               *((_DWORD *)static_fields + 837),
			//               this._Params._SubsurfaceCurvatureScale,
			//               0LL);
			//             UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//               cmd,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SubsurfaceCurvatureOffset,
			//               this._Params._SubsurfaceCurvatureOffset,
			//               0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//             v14 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                     &v22,
			//                     &context.fields.renderContext,
			//                     16,
			//                     0LL);
			//             v15 = *(__m128i *)&v14.bufferId;
			//             v22.ptr = v14.ptr;
			//             if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//             {
			//               currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//               if ( !currentManagerContext )
			//                 goto LABEL_24;
			//               static_fields = currentManagerContext.fields._subsurfaceProfileManager_k__BackingField;
			//               if ( !static_fields )
			//                 goto LABEL_24;
			//               TerrainSubsurfaceProfileInt = HG::Rendering::Runtime::SubsurfaceProfileManager::GetTerrainSubsurfaceProfileInt(
			//                                               (SubsurfaceProfileManager *)static_fields,
			//                                               0LL);
			//             }
			//             else
			//             {
			//               TerrainSubsurfaceProfileInt = 0;
			//             }
			//             DWORD1(v21) = LODWORD(this._Params._SubsurfaceCurvatureScale);
			//             *((float *)&v21 + 3) = (float)TerrainSubsurfaceProfileInt;
			//             *(float *)&v21 = (float)this._Params._UseSubsurfaceProfile;
			//             DWORD2(v21) = LODWORD(this._Params._SubsurfaceCurvatureOffset);
			//             *(_OWORD *)v22.ptr = v21;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//               cmd,
			//               _mm_cvtsi128_si32(v15),
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._TerrainSubsurfaceConstants,
			//               _mm_cvtsi128_si32(_mm_srli_si128(v15, 4)),
			//               _mm_cvtsi128_si32(_mm_srli_si128(v15, 8)),
			//               0LL);
			//             v18 = 128;
			//             ref = 128;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//             v19 = *((_QWORD *)static_fields + 54);
			//             if ( v19 )
			//             {
			//               if ( *(_BYTE *)(v19 + 16) )
			//               {
			//                 if ( !v9 || !this._Params._UseSubsurfaceProfile )
			//                   goto LABEL_22;
			//               }
			//               else if ( !this._Params._UseSubsurfaceProfile )
			//               {
			// LABEL_22:
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
			//                   cmd,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._TerrainStencilRef,
			//                   v18,
			//                   0LL);
			//                 return;
			//               }
			//               HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
			//                 &ref,
			//                 2,
			//                 HGStencilUtils_HGStencilBitMask__Enum_DeferredShadingModel,
			//                 0LL);
			//               v18 = ref;
			//               goto LABEL_22;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(static_fields, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4761, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1373(Patch, this, (Object *)context, 0LL);
			// }
			// 
		}

		public static void ResetTerrainParams(HGRenderGraphContext context)
		{
			// // Void ResetTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ResetTerrainParams(
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   __int64 v4; // rcx
			//   CommandBuffer *cmd; // rdi
			//   String *s_SubsurfaceProfile; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D3C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D3C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4762, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       s_SubsurfaceProfile = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SubsurfaceProfile;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_SubsurfaceProfile, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( cmd )
			//       {
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, static_fields._TerrainStencilRef, 128, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v4, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4762, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)context, 0LL);
			// }
			// 
		}

		public HGTerrainSubsurfaceData ToDataCPP()
		{
			// // HGTerrainSubsurfaceData ToDataCPP()
			// HGTerrainSubsurfaceData *HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ToDataCPP(
			//         HGTerrainSubsurfaceData *__return_ptr retstr,
			//         TerrainSubsurfaceData *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *terrainSimpleSubsurface; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGRenderPipelineSettingHub *instance; // rax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   bool v9; // di
			//   struct HGGraphicsFeatureManager__Class *v10; // rax
			//   bool UseSubsurfaceProfile; // al
			//   bool v12; // al
			//   float SubsurfaceCurvatureOffset; // xmm1_4
			//   float SubsurfaceCurvatureScale; // xmm0_4
			//   int32_t m_terrainStencil; // eax
			//   __m128 v16; // xmm2
			//   __m128 v17; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGTerrainSubsurfaceData *v20; // rax
			//   __int128 v21; // xmm0
			//   HGTerrainSubsurfaceData v22; // [rsp+20h] [rbp-28h] BYREF
			//   int32_t ref; // [rsp+50h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D8EDC1B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     byte_18D8EDC1B = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainSimpleSubsurface = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     terrainSimpleSubsurface = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = terrainSimpleSubsurface.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_18;
			//   if ( wrapperArray.max_length.size <= 4763 )
			//     goto LABEL_9;
			//   if ( !terrainSimpleSubsurface._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(terrainSimpleSubsurface, wrapperArray);
			//     terrainSimpleSubsurface = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   terrainSimpleSubsurface = (struct ILFixDynamicMethodWrapper_2__Class *)terrainSimpleSubsurface.static_fields.wrapperArray;
			//   if ( !terrainSimpleSubsurface )
			// LABEL_18:
			//     sub_180B536AC(terrainSimpleSubsurface, wrapperArray);
			//   if ( LODWORD(terrainSimpleSubsurface._0.namespaze) <= 0x129B )
			//     sub_180070270(terrainSimpleSubsurface, wrapperArray);
			//   if ( terrainSimpleSubsurface[101]._0.nestedTypes )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4763, 0LL);
			//     if ( Patch )
			//     {
			//       v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1374(&v22, Patch, this, 0LL);
			//       v21 = *(_OWORD *)&v20.m_useSubsurfaceProfile;
			//       m_terrainStencil = v20.m_terrainStencil;
			//       *(_OWORD *)&retstr.m_useSubsurfaceProfile = v21;
			//       goto LABEL_17;
			//     }
			//     goto LABEL_18;
			//   }
			// LABEL_9:
			//   instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_18;
			//   m_impl = instance.fields.m_impl;
			//   if ( !m_impl )
			//     goto LABEL_18;
			//   v9 = m_impl.fields._currentDeviceType_k__BackingField == 1;
			//   v10 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   ref = 128;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, wrapperArray);
			//     v10 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   }
			//   terrainSimpleSubsurface = (struct ILFixDynamicMethodWrapper_2__Class *)v10.static_fields.terrainSimpleSubsurface;
			//   if ( !terrainSimpleSubsurface )
			//     goto LABEL_18;
			//   UseSubsurfaceProfile = this._Params._UseSubsurfaceProfile;
			//   if ( !LOBYTE(terrainSimpleSubsurface._0.name) )
			//   {
			//     v9 = this._Params._UseSubsurfaceProfile;
			//     if ( !UseSubsurfaceProfile )
			//       goto LABEL_16;
			// LABEL_28:
			//     HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
			//       &ref,
			//       2,
			//       HGStencilUtils_HGStencilBitMask__Enum_DeferredShadingModel,
			//       0LL);
			//     goto LABEL_16;
			//   }
			//   if ( UseSubsurfaceProfile && v9 )
			//     goto LABEL_28;
			// LABEL_16:
			//   v12 = this._Params._UseSubsurfaceProfile;
			//   SubsurfaceCurvatureOffset = this._Params._SubsurfaceCurvatureOffset;
			//   *(_OWORD *)&v22.m_useSubsurfaceProfile = 0LL;
			//   v22.m_useSubsurfaceProfile = v12;
			//   SubsurfaceCurvatureScale = this._Params._SubsurfaceCurvatureScale;
			//   m_terrainStencil = ref;
			//   v22.m_enableSubsurfaceProfileKeyword = v9;
			//   v16 = _mm_shuffle_ps(*(__m128 *)&v22.m_useSubsurfaceProfile, *(__m128 *)&v22.m_useSubsurfaceProfile, 225);
			//   v16.m128_f32[0] = SubsurfaceCurvatureScale;
			//   v17 = _mm_shuffle_ps(v16, v16, 198);
			//   v17.m128_f32[0] = SubsurfaceCurvatureOffset;
			//   *(__m128 *)&retstr.m_useSubsurfaceProfile = _mm_shuffle_ps(v17, v17, 201);
			// LABEL_17:
			//   retstr.m_terrainStencil = m_terrainStencil;
			//   return retstr;
			// }
			// 
			return null;
		}

		public TerrainSubsurfaceParams _Params;

		public HGSubsurfaceProfile _SubsurfaceProfile;

		public const int DEFAULT_TERRAIN_STENCIL_REF = 128;
	}
}
