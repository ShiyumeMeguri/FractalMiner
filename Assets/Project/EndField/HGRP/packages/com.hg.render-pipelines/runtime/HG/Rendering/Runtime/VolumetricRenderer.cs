using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class VolumetricRenderer
	{
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool enableFraming
		{
			get
			{
				// // Boolean get_changed()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_changed(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NiVDAueHECEJqGCNLxcjNXRtPmUC;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsFadeOut
		{
			get
			{
				// // Boolean sgWgTpbidIkybxqOOwCeneonHeaZ()
				// bool Rewired::Utils::Classes::Data::SerializedObject::sgWgTpbidIkybxqOOwCeneonHeaZ(
				//         SerializedObject *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.LoPcJcoVSgzNaVhAmncnBlYfcjyEA == 1;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsFadeIn
		{
			get
			{
				// // Boolean get_IsFadeIn()
				// bool HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeIn(VolumetricRenderer *this, MethodInfo *method)
				// {
				//   return this.fields.m_VolumetricState == 2;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsFading
		{
			get
			{
				// // Boolean get_IsFading()
				// bool HG::Rendering::Runtime::VolumetricRenderer::get_IsFading(VolumetricRenderer *this, MethodInfo *method)
				// {
				//   return this.fields.m_VolumetricState == 1 || this.fields.m_VolumetricState == 2;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x000025D0 File Offset: 0x000007D0
		public int DrawFrameCount
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_rolloverSize()
				// int32_t TMPro::TMP_TextProcessingStack<TMPro::MaterialReference>::get_rolloverSize(
				//         TMP_TextProcessingStack_1_MaterialReference_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_RolloverSize;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_rolloverSize(Int32)
				// void TMPro::TMP_TextProcessingStack<TMPro::MaterialReference>::set_rolloverSize(
				//         TMP_TextProcessingStack_1_MaterialReference_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.m_RolloverSize = value;
				// }
				// 
			}
		}

		public VolumetricRenderer(Material volumetricMaterial)
		{
		}

		private void ResetRenderNodePool()
		{
			// // Void ResetRenderNodePool()
			// void HG::Rendering::Runtime::VolumetricRenderer::ResetRenderNodePool(VolumetricRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4474, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4474, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.renderNodePoolIndex = 0;
			//   }
			// }
			// 
		}

		private VolumetricRenderer.VolumetricRenderNode GetRenderNodeFromPool()
		{
			// // VolumetricRenderer+VolumetricRenderNode GetRenderNodeFromPool()
			// VolumetricRenderer_VolumetricRenderNode *HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(
			//         VolumetricRenderer *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodePool; // rax
			//   List_1_System_Object_ *renderNodePoolIndex; // rcx
			//   List_1_System_Object_ *v6; // rdi
			//   __int64 v7; // rax
			//   Object *Item; // rax
			//   VolumetricRenderer_VolumetricRenderNode *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197B8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode);
			//     byte_18D9197B8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4475, 0LL) )
			//   {
			//     renderNodePool = this.fields.renderNodePool;
			//     renderNodePoolIndex = (List_1_System_Object_ *)(unsigned int)this.fields.renderNodePoolIndex;
			//     if ( !renderNodePool )
			//       goto LABEL_12;
			//     if ( (int)renderNodePoolIndex >= renderNodePool.fields._size )
			//     {
			//       v6 = (List_1_System_Object_ *)this.fields.renderNodePool;
			//       v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode);
			//       if ( !v7 )
			//         goto LABEL_12;
			//       *(_DWORD *)(v7 + 116) = -1;
			//       sub_1822AD140(v6, (Object *)v7);
			//     }
			//     v3 = (unsigned int)this.fields.renderNodePoolIndex;
			//     renderNodePoolIndex = (List_1_System_Object_ *)this.fields.renderNodePool;
			//     this.fields.renderNodePoolIndex = v3 + 1;
			//     if ( renderNodePoolIndex )
			//     {
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                renderNodePoolIndex,
			//                v3,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			//       v9 = (VolumetricRenderer_VolumetricRenderNode *)Item;
			//       if ( Item )
			//       {
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Reset(
			//           (VolumetricRenderer_VolumetricRenderNode *)Item,
			//           0LL);
			//         return v9;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(renderNodePoolIndex, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4475, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1286(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VolumetricRenderer::Release(VolumetricRenderer *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *m_RenderStages; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBB1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::Clear);
			//     byte_18D8EDBB1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2874, 0LL) )
			//   {
			//     HG::Rendering::Runtime::VolumetricRenderer::ReleaseVolumetricRTs(this, 1, 0LL);
			//     m_RenderStages = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_RenderStages;
			//     if ( m_RenderStages )
			//     {
			//       System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//         m_RenderStages,
			//         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::Clear);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_RenderStages, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2874, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void UpdateCloudFadeParameters(CommandBuffer cmd)
		{
			// // Void UpdateCloudFadeParameters(CommandBuffer)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateCloudFadeParameters(
			//         VolumetricRenderer *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   Material *m_VolumetricMat; // rsi
			//   VolumetricShaderIDs__StaticFields *v6; // rcx
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   Material *v8; // rbx
			//   int32_t CloudFadeRatio; // ebx
			//   double v10; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197B9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9197B9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4477, 0LL) )
			//   {
			//     m_VolumetricMat = this.fields.m_VolumetricMat;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_VolumetricMat )
			//       goto LABEL_11;
			//     if ( UnityEngine::Material::HasProperty(m_VolumetricMat, static_fields._CloudFadeSpeedPow, 0LL) )
			//     {
			//       v8 = this.fields.m_VolumetricMat;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       if ( !v8 )
			//         goto LABEL_11;
			//       UnityEngine::Material::GetFloatImpl(v8, static_fields._CloudFadeSpeedPow, 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     v6 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     CloudFadeRatio = v6._CloudFadeRatio;
			//     if ( cmd )
			//     {
			//       v10 = sub_1802EB1B0((_DWORD)v6, static_fields);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, CloudFadeRatio, *(float *)&v10, 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v6, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4477, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     0LL);
			// }
			// 
		}

		public void Render(ref VolumetricRenderInputs inputs)
		{
			// // Void Render(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::Render(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Component *klass; // rcx
			//   HGRenderGraphContext *context; // r14
			//   CommandBuffer *cmd; // r14
			//   int32_t VolumetricComposeColor; // ebx
			//   Texture2D *blackTexture; // rax
			//   RenderTargetIdentifier *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int128 v14; // xmm1
			//   int32_t VolumetricComposeDepth; // ebx
			//   Texture2D *v16; // rax
			//   RenderTargetIdentifier *v17; // rax
			//   __int128 v18; // xmm1
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v20; // rdx
			//   VolumetricCloudVolumeManager *volumetricCloudVolumeManager_k__BackingField; // rcx
			//   ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ FadeRatioAndState; // rax
			//   Object_1 *m_VolumetricMat; // rbx
			//   int32_t v24; // r10d
			//   Vector4 sceneDepthToSample; // xmm6
			//   int32_t CameraDepthTexture; // ebx
			//   RenderTargetIdentifier *v27; // rax
			//   __int128 v28; // xmm1
			//   Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderStage_ *m_RenderStages; // rcx
			//   HGCamera *hgCamera; // rdx
			//   HGRenderGraphContext *v31; // r8
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 value; // [rsp+28h] [rbp-39h] BYREF
			//   RenderTargetIdentifier v37; // [rsp+38h] [rbp-29h] BYREF
			//   RenderTargetIdentifier v38; // [rsp+68h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D9197BA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Count);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Count);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D9197BA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4478, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4478, 0LL);
			//     if ( !Patch )
			//       goto LABEL_26;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//   }
			//   else
			//   {
			//     context = inputs.context;
			//     if ( !context )
			//       goto LABEL_26;
			//     cmd = context.fields.cmd;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     VolumetricComposeColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._VolumetricComposeColor;
			//     blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//     v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v38, (Texture *)blackTexture, 0LL);
			//     if ( !cmd )
			//       sub_180B536AC(v13, v12);
			//     v14 = *(_OWORD *)&v11.m_BufferPointer;
			//     *(_OWORD *)&v37.m_Type = *(_OWORD *)&v11.m_Type;
			//     *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v11.m_DepthSlice;
			//     *(_OWORD *)&v37.m_BufferPointer = v14;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v37, 0LL);
			//     VolumetricComposeDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._VolumetricComposeDepth;
			//     v16 = UnityEngine::Texture2D::get_blackTexture(0LL);
			//     v17 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v38, (Texture *)v16, 0LL);
			//     v18 = *(_OWORD *)&v17.m_BufferPointer;
			//     *(_OWORD *)&v37.m_Type = *(_OWORD *)&v17.m_Type;
			//     *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v17.m_DepthSlice;
			//     *(_OWORD *)&v37.m_BufferPointer = v18;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v37, 0LL);
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !currentManagerContext
			//       || (volumetricCloudVolumeManager_k__BackingField = currentManagerContext.fields._volumetricCloudVolumeManager_k__BackingField) == 0LL )
			//     {
			//       sub_180B536AC(volumetricCloudVolumeManager_k__BackingField, v20);
			//     }
			//     FadeRatioAndState = HG::Rendering::Runtime::VolumetricCloudVolumeManager::GetFadeRatioAndState(
			//                           volumetricCloudVolumeManager_k__BackingField,
			//                           inputs.hgCamera,
			//                           0LL);
			//     m_VolumetricMat = (Object_1 *)this.fields.m_VolumetricMat;
			//     *(ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ *)&this.fields.m_VolumetricState = FadeRatioAndState;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality(m_VolumetricMat, 0LL, 0LL)
			//       && (inputs.volumetricRenderObjects && inputs.volumetricRenderObjects.fields._size
			//        || this.fields.m_VolumetricState) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       value = *(Vector4 *)sub_1825A3980(&value, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v24, &value, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       sceneDepthToSample = (Vector4)inputs.sceneDepthToSample;
			//       CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CameraDepthTexture;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       value = sceneDepthToSample;
			//       v27 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v38, (TextureHandle *)&value, 0LL);
			//       v28 = *(_OWORD *)&v27.m_BufferPointer;
			//       *(_OWORD *)&v37.m_Type = *(_OWORD *)&v27.m_Type;
			//       *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v27.m_DepthSlice;
			//       *(_OWORD *)&v37.m_BufferPointer = v28;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, CameraDepthTexture, &v37, 0LL);
			//       hgCamera = inputs.hgCamera;
			//       if ( !inputs.hgCamera
			//         || (v31 = inputs.context) == 0LL
			//         || (HG::Rendering::Runtime::VolumetricRenderer::UpdateCamera(
			//               this,
			//               hgCamera.fields.camera,
			//               v31.fields.cmd,
			//               0LL),
			//             (m_RenderStages = this.fields.m_RenderStages) == 0LL) )
			//       {
			//         sub_180B536AC(m_RenderStages, hgCamera);
			//       }
			//       if ( m_RenderStages.fields._count - m_RenderStages.fields._freeCount > 0 )
			//         HG::Rendering::Runtime::VolumetricRenderer::UpdateRenderStageAndDraw(this, inputs, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//       UnityEngine::Rendering::CommandBuffer::EnableKeyword(
			//         cmd,
			//         &TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ComposeVolumetric,
			//         0LL);
			//       klass = (Component *)inputs.hgCamera;
			//       if ( inputs.hgCamera )
			//       {
			//         klass = (Component *)klass[4].klass;
			//         if ( klass )
			//         {
			//           transform = UnityEngine::Component::get_transform(klass, 0LL);
			//           if ( transform )
			//           {
			//             position = UnityEngine::Transform::get_position((Vector3 *)&value, transform, 0LL);
			//             z = position.z;
			//             *(_QWORD *)&this.fields.PrevCameraPos.x = *(_QWORD *)&position.x;
			//             this.fields.PrevCameraPos.z = z;
			//             HG::Rendering::Runtime::VolumetricRenderer::ReleaseVolumetricRTs(this, 0, 0LL);
			//             return;
			//           }
			//         }
			//       }
			// LABEL_26:
			//       sub_180B536AC(klass, v5);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(
			//       cmd,
			//       &TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ComposeVolumetric,
			//       0LL);
			//   }
			// }
			// 
		}

		private void UpdateCamera(Camera camera, CommandBuffer cmd)
		{
			// // Void UpdateCamera(Camera, CommandBuffer)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateCamera(
			//         VolumetricRenderer *this,
			//         Camera *camera,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // edi
			//   Matrix4x4 *nonJitteredProjectionMatrix; // rax
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   Matrix4x4 *v21; // rbx
			//   Matrix4x4 *v22; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   Matrix4x4 *v30; // rax
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   int32_t InvPartialVPMatrix; // ebx
			//   Matrix4x4 *inverse; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v42; // [rsp+30h] [rbp-D0h] BYREF
			//   Matrix4x4 v43; // [rsp+40h] [rbp-C0h] BYREF
			//   Matrix4x4 value; // [rsp+80h] [rbp-80h] BYREF
			//   __int128 v45; // [rsp+C0h] [rbp-40h] BYREF
			//   Matrix4x4 v46; // [rsp+D0h] [rbp-30h] BYREF
			//   __int128 v47; // [rsp+110h] [rbp+10h]
			//   __int128 v48; // [rsp+120h] [rbp+20h]
			//   __int128 v49; // [rsp+130h] [rbp+30h]
			//   Matrix4x4 v50; // [rsp+140h] [rbp+40h] BYREF
			// 
			//   if ( !byte_18D9197BB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9197BB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4479, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4479, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)this,
			//         (Object *)camera,
			//         (Object *)cmd,
			//         0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !camera )
			//     goto LABEL_10;
			//   transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//   if ( !transform )
			//     goto LABEL_10;
			//   position = UnityEngine::Transform::get_position((Vector3 *)&v45, transform, 0LL);
			//   z = position.z;
			//   *(_QWORD *)&v42.x = *(_QWORD *)&position.x;
			//   nonJitteredProjectionMatrix = UnityEngine::Camera::get_nonJitteredProjectionMatrix(&value, camera, 0LL);
			//   v13 = *(_OWORD *)&nonJitteredProjectionMatrix.m01;
			//   *(_OWORD *)&v43.m00 = *(_OWORD *)&nonJitteredProjectionMatrix.m00;
			//   v14 = *(_OWORD *)&nonJitteredProjectionMatrix.m02;
			//   *(_OWORD *)&v43.m01 = v13;
			//   v15 = *(_OWORD *)&nonJitteredProjectionMatrix.m03;
			//   *(_OWORD *)&v43.m02 = v14;
			//   *(_OWORD *)&v43.m03 = v15;
			//   GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&value, &v43, 1, 0LL);
			//   v45 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//   v47 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//   v48 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//   v49 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//   worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&value, camera, 0LL);
			//   v18 = *(_OWORD *)&worldToCameraMatrix.m01;
			//   *(_OWORD *)&v43.m00 = *(_OWORD *)&worldToCameraMatrix.m00;
			//   v19 = *(_OWORD *)&worldToCameraMatrix.m02;
			//   *(_OWORD *)&v43.m01 = v18;
			//   v20 = *(_OWORD *)&worldToCameraMatrix.m03;
			//   *(_OWORD *)&v43.m02 = v19;
			//   *(_OWORD *)&v43.m03 = v20;
			//   *(_OWORD *)&v46.m00 = v45;
			//   *(_OWORD *)&v46.m01 = v47;
			//   *(_OWORD *)&v46.m02 = v48;
			//   *(_OWORD *)&v46.m03 = v49;
			//   v42.z = z;
			//   v21 = UnityEngine::Matrix4x4::op_Multiply(&v50, &v46, &v43, 0LL);
			//   v22 = UnityEngine::Matrix4x4::Translate(&value, &v42, 0LL);
			//   v23 = *(_OWORD *)&v22.m01;
			//   *(_OWORD *)&v43.m00 = *(_OWORD *)&v22.m00;
			//   v24 = *(_OWORD *)&v22.m02;
			//   *(_OWORD *)&v43.m01 = v23;
			//   v25 = *(_OWORD *)&v22.m03;
			//   *(_OWORD *)&v43.m02 = v24;
			//   v26 = *(_OWORD *)&v21.m00;
			//   *(_OWORD *)&v43.m03 = v25;
			//   v27 = *(_OWORD *)&v21.m01;
			//   *(_OWORD *)&value.m00 = v26;
			//   v28 = *(_OWORD *)&v21.m02;
			//   *(_OWORD *)&value.m01 = v27;
			//   v29 = *(_OWORD *)&v21.m03;
			//   *(_OWORD *)&value.m02 = v28;
			//   *(_OWORD *)&value.m03 = v29;
			//   v30 = UnityEngine::Matrix4x4::op_Multiply(&v50, &value, &v43, 0LL);
			//   v31 = *(_OWORD *)&v30.m01;
			//   *(_OWORD *)&v46.m00 = *(_OWORD *)&v30.m00;
			//   v32 = *(_OWORD *)&v30.m02;
			//   *(_OWORD *)&v46.m01 = v31;
			//   v33 = *(_OWORD *)&v30.m03;
			//   *(_OWORD *)&v46.m02 = v32;
			//   *(_OWORD *)&v46.m03 = v33;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   InvPartialVPMatrix = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvPartialVPMatrix;
			//   inverse = UnityEngine::Matrix4x4::get_inverse(&v50, &v46, 0LL);
			//   if ( !cmd )
			//     sub_180B536AC(v37, v36);
			//   v38 = *(_OWORD *)&inverse.m01;
			//   *(_OWORD *)&value.m00 = *(_OWORD *)&inverse.m00;
			//   v39 = *(_OWORD *)&inverse.m02;
			//   *(_OWORD *)&value.m01 = v38;
			//   v40 = *(_OWORD *)&inverse.m03;
			//   *(_OWORD *)&value.m02 = v39;
			//   *(_OWORD *)&value.m03 = v40;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InvPartialVPMatrix, &value, 0LL);
			// }
			// 
		}

		private void DisableAllStages()
		{
			// // Void DisableAllStages()
			// void HG::Rendering::Runtime::VolumetricRenderer::DisableAllStages(VolumetricRenderer *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderStage_ *m_RenderStages; // rcx
			//   Object *Item; // rax
			//   Object *v6; // rax
			//   Object *v7; // rax
			//   Object *v8; // rax
			//   Object *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197BC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     byte_18D9197BC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4503, 0LL) )
			//   {
			//     m_RenderStages = this.fields.m_RenderStages;
			//     if ( m_RenderStages )
			//     {
			//       Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                (Int32Enum__Enum)0,
			//                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( Item )
			//       {
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
			//           (VolumetricRenderer_VolumetricRenderStage *)Item,
			//           0LL);
			//         m_RenderStages = this.fields.m_RenderStages;
			//         if ( m_RenderStages )
			//         {
			//           v6 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                  (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                  (Int32Enum__Enum)1u,
			//                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//           if ( v6 )
			//           {
			//             HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
			//               (VolumetricRenderer_VolumetricRenderStage *)v6,
			//               0LL);
			//             m_RenderStages = this.fields.m_RenderStages;
			//             if ( m_RenderStages )
			//             {
			//               v7 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                      (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                      (Int32Enum__Enum)2u,
			//                      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//               if ( v7 )
			//               {
			//                 HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
			//                   (VolumetricRenderer_VolumetricRenderStage *)v7,
			//                   0LL);
			//                 m_RenderStages = this.fields.m_RenderStages;
			//                 if ( m_RenderStages )
			//                 {
			//                   v8 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                          (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                          (Int32Enum__Enum)3u,
			//                          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//                   if ( v8 )
			//                   {
			//                     HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
			//                       (VolumetricRenderer_VolumetricRenderStage *)v8,
			//                       0LL);
			//                     m_RenderStages = this.fields.m_RenderStages;
			//                     if ( m_RenderStages )
			//                     {
			//                       v9 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                              (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                              (Int32Enum__Enum)4u,
			//                              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//                       if ( v9 )
			//                       {
			//                         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
			//                           (VolumetricRenderer_VolumetricRenderStage *)v9,
			//                           0LL);
			//                         return;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(m_RenderStages, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4503, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private VolumetricRenderer.VolumetricRenderItem GetDefaultFramingComposeItem(Material composeMaterial)
		{
			// // VolumetricRenderer+VolumetricRenderItem GetDefaultFramingComposeItem(Material)
			// VolumetricRenderer_VolumetricRenderItem *HG::Rendering::Runtime::VolumetricRenderer::GetDefaultFramingComposeItem(
			//         VolumetricRenderer_VolumetricRenderItem *__return_ptr retstr,
			//         VolumetricRenderer *this,
			//         Material *composeMaterial,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   __int64 v9; // rcx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   Object *v12; // rdi
			//   Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v13; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // r14
			//   Material *klass; // rdi
			//   bool m_EnableTAA; // bl
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v19; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v20; // [rsp+30h] [rbp-D8h]
			//   _BYTE v21[28]; // [rsp+70h] [rbp-98h] BYREF
			//   VolumetricRenderer_VolumetricBounds v22; // [rsp+98h] [rbp-70h] BYREF
			//   VolumetricRenderer_VolumetricRenderItem v23; // [rsp+B8h] [rbp-50h] BYREF
			// 
			//   if ( !byte_18D9197BD )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass64_0::_GetDefaultFramingComposeItem_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass64_0);
			//     byte_18D9197BD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4520, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4520, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1294(
			//                    &v23,
			//                    Patch,
			//                    (Object *)this,
			//                    (Object *)composeMaterial,
			//                    0LL);
			//       return retstr;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass64_0);
			//   v12 = (Object *)v7;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   *(_QWORD *)(v7 + 16) = composeMaterial;
			//   sub_1800054D0((HGRenderPathScene *)(v7 + 16), v8, v10, v11, v19, v20);
			//   v13 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_180004920(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//   v14 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v13;
			//   if ( !v13 )
			//     goto LABEL_8;
			//   System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
			//     v13,
			//     v12,
			//     MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass64_0::_GetDefaultFramingComposeItem_b__0[0],
			//     0LL);
			//   klass = (Material *)v12[1].klass;
			//   m_EnableTAA = this.fields.m_EnableTAA;
			//   memset(&v21[8], 0, 20);
			//   sub_1802F01E0(retstr, 0LL, 88LL);
			//   *(_OWORD *)&v22.enableBounds = *(_OWORD *)&v21[8];
			//   *(_QWORD *)&v22.worldBounds.m_Extents.x = 0LL;
			//   v22.worldBounds.m_Extents.z = 0.0;
			//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
			//     retstr,
			//     v14,
			//     &v22,
			//     klass,
			//     0,
			//     m_EnableTAA,
			//     -99999,
			//     3000,
			//     99999.0,
			//     -1,
			//     1,
			//     1,
			//     0LL);
			//   return retstr;
			// }
			// 
			return default(VolumetricRenderer.VolumetricRenderItem);
		}

		private VolumetricRenderer.VolumetricRenderItem GetDefaultTemporalComposeItem(Material composeMaterial)
		{
			// // VolumetricRenderer+VolumetricRenderItem GetDefaultTemporalComposeItem(Material)
			// VolumetricRenderer_VolumetricRenderItem *HG::Rendering::Runtime::VolumetricRenderer::GetDefaultTemporalComposeItem(
			//         VolumetricRenderer_VolumetricRenderItem *__return_ptr retstr,
			//         VolumetricRenderer *this,
			//         Material *composeMaterial,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   __int64 v9; // rcx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   Object *v12; // rbx
			//   Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v13; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rsi
			//   Material *klass; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v18; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v19; // [rsp+30h] [rbp-D8h]
			//   _BYTE v20[28]; // [rsp+70h] [rbp-98h] BYREF
			//   VolumetricRenderer_VolumetricBounds v21; // [rsp+98h] [rbp-70h] BYREF
			//   VolumetricRenderer_VolumetricRenderItem v22; // [rsp+B8h] [rbp-50h] BYREF
			// 
			//   if ( !byte_18D9197BE )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass65_0::_GetDefaultTemporalComposeItem_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass65_0);
			//     byte_18D9197BE = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4526, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4526, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1294(
			//                    &v22,
			//                    Patch,
			//                    (Object *)this,
			//                    (Object *)composeMaterial,
			//                    0LL);
			//       return retstr;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass65_0);
			//   v12 = (Object *)v7;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   *(_QWORD *)(v7 + 16) = composeMaterial;
			//   sub_1800054D0((HGRenderPathScene *)(v7 + 16), v8, v10, v11, v18, v19);
			//   v13 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_180004920(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//   v14 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v13;
			//   if ( !v13 )
			//     goto LABEL_8;
			//   System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
			//     v13,
			//     v12,
			//     MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass65_0::_GetDefaultTemporalComposeItem_b__0[0],
			//     0LL);
			//   klass = (Material *)v12[1].klass;
			//   memset(&v20[8], 0, 20);
			//   sub_1802F01E0(retstr, 0LL, 88LL);
			//   *(_OWORD *)&v21.enableBounds = *(_OWORD *)&v20[8];
			//   *(_QWORD *)&v21.worldBounds.m_Extents.x = 0LL;
			//   v21.worldBounds.m_Extents.z = 0.0;
			//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
			//     retstr,
			//     v14,
			//     &v21,
			//     klass,
			//     0,
			//     0,
			//     -99999,
			//     3000,
			//     99999.0,
			//     -1,
			//     1,
			//     1,
			//     0LL);
			//   return retstr;
			// }
			// 
			return default(VolumetricRenderer.VolumetricRenderItem);
		}

		private void AddToComposeCache(Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> composeCache, EVolumetricStage stage, IVolumetricRenderObject obj)
		{
			// // Void AddToComposeCache(Dictionary`2[HG.Rendering.Runtime.EVolumetricStage,List`1[HG.Rendering.Runtime.IVolumetricRenderObject]], EVolumetricStage, IVolumetricRenderObject)
			// void HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//         VolumetricRenderer *this,
			//         Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *composeCache,
			//         EVolumetricStage__Enum stage,
			//         IVolumetricRenderObject *obj,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   Object *v10; // rcx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v11; // rax
			//   Object *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *value; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9197BF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>);
			//     byte_18D9197BF = 1;
			//   }
			//   value = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4519, 0LL) )
			//   {
			//     if ( !composeCache )
			//       goto LABEL_13;
			//     if ( !System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::TryGetValue(
			//             (Dictionary_2_System_Int32Enum_System_Object_ *)composeCache,
			//             (Int32Enum__Enum)stage,
			//             &value,
			//             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::TryGetValue) )
			//     {
			//       v11 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>);
			//       v12 = (Object *)v11;
			//       if ( !v11 )
			//         goto LABEL_13;
			//       System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//         v11,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::List);
			//       value = v12;
			//       System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Add(
			//         (Dictionary_2_System_Int32Enum_System_Object_ *)composeCache,
			//         (Int32Enum__Enum)stage,
			//         v12,
			//         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::Add);
			//     }
			//     v10 = value;
			//     if ( value )
			//     {
			//       if ( System::Collections::Generic::List<System::Object>::Contains(
			//              (List_1_System_Object_ *)value,
			//              (Object *)obj,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Contains) )
			//       {
			//         return;
			//       }
			//       v10 = value;
			//       if ( value )
			//       {
			//         sub_1822AD140((List_1_System_Object_ *)value, (Object *)obj);
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4519, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_326(
			//     (ILFixDynamicMethodWrapper_3 *)Patch,
			//     (Object *)this,
			//     (Object *)composeCache,
			//     (Formatting__Enum)stage,
			//     (Object *)obj,
			//     0LL);
			// }
			// 
		}

		private void ClearComposeCache(Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> composeCache)
		{
			// // Void ClearComposeCache(Dictionary`2[HG.Rendering.Runtime.EVolumetricStage,List`1[HG.Rendering.Runtime.IVolumetricRenderObject]])
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VolumetricRenderer::ClearComposeCache(
			//         VolumetricRenderer *this,
			//         Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *composeCache,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Il2CppExceptionWrapper *v11; // [rsp+20h] [rbp-78h] BYREF
			//   Il2CppException *ex; // [rsp+28h] [rbp-70h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v13; // [rsp+30h] [rbp-68h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v14; // [rsp+38h] [rbp-60h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v15; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9197C0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Clear);
			//     byte_18D9197C0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4517, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4517, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)composeCache,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !composeCache )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::Dictionary<unsigned long,float>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Single_ *)&v15,
			//       (Dictionary_2_System_UInt64_System_Single_ *)composeCache,
			//       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
			//     v14 = v15;
			//     ex = 0LL;
			//     v13 = &v14;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v14,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext) )
			//       {
			//         if ( !v14._current.value )
			//           sub_1802DC2C8(0LL, v7);
			//         sub_1823B99D0(
			//           v14._current.value,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Clear);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v11 )
			//     {
			//       ex = v11.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private void ProcessFramingCompose(ref VolumetricRenderInputs inputs)
		{
			// // Void ProcessFramingCompose(VolumetricRenderInputs ByRef)
			// // Hidden C++ exception states: #wind=6
			// void HG::Rendering::Runtime::VolumetricRenderer::ProcessFramingCompose(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   VolumetricRenderer *v3; // rdi
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Object *Item; // rax
			//   Dictionary_2_System_UInt64_System_Single_ *framingCompose; // rdx
			//   List_1_System_Object_ *m_RenderStages; // rcx
			//   Object *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *RenderNodes; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // rcx
			//   Object *v16; // rax
			//   List_1_System_Object_ *v17; // rax
			//   __int64 v18; // rdx
			//   Object *v19; // rax
			//   List_1_System_Object_ *v20; // rax
			//   __int64 v21; // rcx
			//   Object *v22; // rax
			//   List_1_System_Object_ *v23; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
			//   unsigned __int64 v28; // xmm0_8
			//   VolumetricRenderer_VolumetricRenderItem *DefaultFramingComposeItem; // rax
			//   __int64 v30; // rcx
			//   __int128 v31; // xmm9
			//   __int128 v32; // xmm10
			//   __int128 v33; // xmm11
			//   __m128i v34; // xmm7
			//   __m128i v35; // xmm8
			//   MeshFilter *meshFilter; // xmm12_8
			//   Object *v37; // r12
			//   List_1_System_Object_ *v38; // rdx
			//   int v39; // r15d
			//   _BYTE *v40; // rdx
			//   Object *v41; // rsi
			//   unsigned __int64 v42; // rdx
			//   unsigned __int64 v43; // r8
			//   signed __int64 v44; // rtt
			//   signed __int64 volumetricParameters; // rcx
			//   unsigned __int64 v46; // r8
			//   signed __int64 v47; // rtt
			//   Dictionary_2_System_Int32Enum_System_Object_ *v48; // rcx
			//   Int32Enum__Enum list; // r15d
			//   Object *v50; // rax
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   VolumetricRenderer_VolumetricRenderNode *RenderNodeFromPool; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   VolumetricRenderer_VolumetricRenderNode *v56; // rsi
			//   __int64 v57; // rdx
			//   unsigned __int64 v58; // r9
			//   signed __int64 v59; // rtt
			//   Dictionary_2_System_Int32Enum_System_Object_ *v60; // rcx
			//   Object *v61; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v65; // rdx
			//   __int64 v66; // rcx
			//   _BYTE v67[32]; // [rsp+0h] [rbp-308h] BYREF
			//   List_1_T_Enumerator_System_Object_ v68; // [rsp+30h] [rbp-2D8h] BYREF
			//   List_1_T_Enumerator_System_Object_ v69; // [rsp+48h] [rbp-2C0h] BYREF
			//   List_1_T_Enumerator_System_Object_ key; // [rsp+60h] [rbp-2A8h] BYREF
			//   __int128 v71; // [rsp+78h] [rbp-290h] BYREF
			//   uint64_t v72; // [rsp+88h] [rbp-280h] BYREF
			//   List_1_T_Enumerator_System_Object_ v73; // [rsp+90h] [rbp-278h] BYREF
			//   Il2CppException *ex; // [rsp+A8h] [rbp-260h]
			//   List_1_T_Enumerator_System_Object_ *v75; // [rsp+B0h] [rbp-258h]
			//   Il2CppException *v76; // [rsp+B8h] [rbp-250h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v77; // [rsp+C0h] [rbp-248h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v78; // [rsp+C8h] [rbp-240h] BYREF
			//   __int128 v79; // [rsp+F0h] [rbp-218h]
			//   __int128 v80; // [rsp+100h] [rbp-208h]
			//   __int128 v81; // [rsp+110h] [rbp-1F8h]
			//   __m128i v82; // [rsp+120h] [rbp-1E8h]
			//   __m128i v83; // [rsp+130h] [rbp-1D8h]
			//   MeshFilter *v84; // [rsp+140h] [rbp-1C8h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v85; // [rsp+150h] [rbp-1B8h] BYREF
			//   Il2CppExceptionWrapper *v86; // [rsp+180h] [rbp-188h] BYREF
			//   Il2CppExceptionWrapper *v87; // [rsp+188h] [rbp-180h] BYREF
			//   Il2CppExceptionWrapper *v88; // [rsp+190h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v89; // [rsp+198h] [rbp-170h] BYREF
			//   Il2CppExceptionWrapper *v90; // [rsp+1A0h] [rbp-168h] BYREF
			//   Il2CppExceptionWrapper *v91; // [rsp+1A8h] [rbp-160h] BYREF
			//   __int128 v92; // [rsp+1B0h] [rbp-158h] BYREF
			//   __int128 v93; // [rsp+1C0h] [rbp-148h]
			//   __int128 v94; // [rsp+1D0h] [rbp-138h]
			//   __m128i v95; // [rsp+1E0h] [rbp-128h]
			//   __m128i v96; // [rsp+1F0h] [rbp-118h]
			//   MeshFilter *v97; // [rsp+200h] [rbp-108h]
			//   VolumetricRenderer_VolumetricRenderItem v98[2]; // [rsp+210h] [rbp-F8h] BYREF
			//   Object *v101; // [rsp+328h] [rbp+20h]
			// 
			//   v3 = this;
			//   if ( !byte_18D9197C1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Count);
			//     byte_18D9197C1 = 1;
			//   }
			//   memset(&v68, 0, sizeof(v68));
			//   memset(&v78, 0, sizeof(v78));
			//   memset(&v73, 0, sizeof(v73));
			//   sub_1802F01E0(&v92, 0LL, 88LL);
			//   v71 = 0LL;
			//   v72 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4516, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4516, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v66, v65);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)v3, inputs, 0LL);
			//     return;
			//   }
			//   HG::Rendering::Runtime::VolumetricRenderer::ClearComposeCache(v3, v3.fields.framingCompose, 0LL);
			//   if ( !v3.fields.m_RenderStages )
			//     sub_180B536AC(v5, v4);
			//   Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//            (Dictionary_2_System_Int32Enum_System_Object_ *)v3.fields.m_RenderStages,
			//            (Int32Enum__Enum)0,
			//            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//   if ( !Item )
			//     sub_180B536AC(m_RenderStages, framingCompose);
			//   if ( LOBYTE(Item[2].klass) )
			//   {
			//     if ( !v3.fields.m_EnableTAA )
			//       goto LABEL_26;
			//     if ( !v3.fields.m_RenderStages )
			//       sub_180B536AC(m_RenderStages, framingCompose);
			//     v9 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//            (Dictionary_2_System_Int32Enum_System_Object_ *)v3.fields.m_RenderStages,
			//            (Int32Enum__Enum)0,
			//            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     if ( !v9 )
			//       sub_180B536AC(v11, v10);
			//     RenderNodes = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                     (VolumetricRenderer_VolumetricRenderStage *)v9,
			//                     0LL);
			//     if ( !RenderNodes )
			//       sub_180B536AC(v14, v13);
			//     v68 = *(List_1_T_Enumerator_System_Object_ *)sub_180833B0C(&v85, RenderNodes);
			//     v69._list = 0LL;
			//     *(_QWORD *)&v69._index = &v68;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v68,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//       {
			//         if ( !v68._current )
			//           sub_1802DC2C8(v15, framingCompose);
			//         HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//           v3,
			//           v3.fields.framingCompose,
			//           EVolumetricStage__Enum_BeforeTemporal,
			//           (IVolumetricRenderObject *)v68._current[7].monitor,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v86 )
			//     {
			//       framingCompose = (Dictionary_2_System_UInt64_System_Single_ *)v67;
			//       v69._list = (List_1_System_Object_ *)v86.ex;
			//       if ( v69._list )
			//         sub_18000F780(v69._list);
			//       v3 = this;
			//     }
			//     m_RenderStages = (List_1_System_Object_ *)v3.fields.m_RenderStages;
			//     if ( !m_RenderStages )
			//       goto LABEL_107;
			//     v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//             (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//             (Int32Enum__Enum)1u,
			//             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     if ( !v16 )
			//       goto LABEL_107;
			//     v17 = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                      (VolumetricRenderer_VolumetricRenderStage *)v16,
			//                                      0LL);
			//     if ( !v17 )
			//       goto LABEL_107;
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &key,
			//       v17,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     v68 = key;
			//     v69._list = 0LL;
			//     *(_QWORD *)&v69._index = &v68;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v68,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//       {
			//         if ( !v68._current )
			//           sub_1802DC2C8(m_RenderStages, v18);
			//         HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//           v3,
			//           v3.fields.framingCompose,
			//           EVolumetricStage__Enum_BeforeTemporal,
			//           (IVolumetricRenderObject *)v68._current[7].monitor,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v87 )
			//     {
			//       framingCompose = (Dictionary_2_System_UInt64_System_Single_ *)v67;
			//       v69._list = (List_1_System_Object_ *)v87.ex;
			//       if ( v69._list )
			//         sub_18000F780(v69._list);
			//       v3 = this;
			// LABEL_26:
			//       m_RenderStages = (List_1_System_Object_ *)v3.fields.m_RenderStages;
			//       if ( m_RenderStages )
			//       {
			//         v19 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                 (Int32Enum__Enum)0,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( v19 )
			//         {
			//           v20 = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                            (VolumetricRenderer_VolumetricRenderStage *)v19,
			//                                            0LL);
			//           if ( v20 )
			//           {
			//             System::Collections::Generic::List<System::Object>::GetEnumerator(
			//               &key,
			//               v20,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//             v68 = key;
			//             v69._list = 0LL;
			//             *(_QWORD *)&v69._index = &v68;
			//             try
			//             {
			//               while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                         &v68,
			//                         MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//               {
			//                 if ( !v68._current )
			//                   sub_1802DC2C8(v21, framingCompose);
			//                 HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//                   v3,
			//                   v3.fields.framingCompose,
			//                   EVolumetricStage__Enum_AfterTemporal,
			//                   (IVolumetricRenderObject *)v68._current[7].monitor,
			//                   0LL);
			//               }
			//             }
			//             catch ( Il2CppExceptionWrapper *v88 )
			//             {
			//               framingCompose = (Dictionary_2_System_UInt64_System_Single_ *)v67;
			//               v69._list = (List_1_System_Object_ *)v88.ex;
			//               if ( v69._list )
			//                 sub_18000F780(v69._list);
			//               v3 = this;
			//             }
			//             m_RenderStages = (List_1_System_Object_ *)v3.fields.m_RenderStages;
			//             if ( m_RenderStages )
			//             {
			//               v22 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                       (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                       (Int32Enum__Enum)3u,
			//                       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//               if ( v22 )
			//               {
			//                 v23 = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                                  (VolumetricRenderer_VolumetricRenderStage *)v22,
			//                                                  0LL);
			//                 if ( v23 )
			//                 {
			//                   System::Collections::Generic::List<System::Object>::GetEnumerator(
			//                     &key,
			//                     v23,
			//                     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//                   v68 = key;
			//                   v69._list = 0LL;
			//                   *(_QWORD *)&v69._index = &v68;
			//                   try
			//                   {
			//                     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                               &v68,
			//                               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//                     {
			//                       if ( !v68._current )
			//                         sub_1802DC2C8(m_RenderStages, v24);
			//                       HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//                         v3,
			//                         v3.fields.framingCompose,
			//                         EVolumetricStage__Enum_AfterTemporal,
			//                         (IVolumetricRenderObject *)v68._current[7].monitor,
			//                         0LL);
			//                     }
			//                   }
			//                   catch ( Il2CppExceptionWrapper *v89 )
			//                   {
			//                     v69._list = (List_1_System_Object_ *)v89.ex;
			//                     m_RenderStages = v69._list;
			//                     if ( v69._list )
			//                       sub_18000F780(v69._list);
			//                     v3 = this;
			//                   }
			//                   goto LABEL_44;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_107:
			//       sub_1802DC2C8(m_RenderStages, framingCompose);
			//     }
			//   }
			// LABEL_44:
			//   framingCompose = (Dictionary_2_System_UInt64_System_Single_ *)v3.fields.framingCompose;
			//   if ( !framingCompose )
			//     goto LABEL_107;
			//   System::Collections::Generic::Dictionary<unsigned long,float>::GetEnumerator(
			//     (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Single_ *)&v85,
			//     framingCompose,
			//     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
			//   v78 = v85;
			//   v76 = 0LL;
			//   v77 = &v78;
			//   try
			//   {
			//     while ( 1 )
			//     {
			//       do
			//       {
			//         if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v78,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext) )
			//           return;
			//         current = v78._current;
			//         *(KeyValuePair_2_System_Int32Enum_System_Object_ *)&key._list = v78._current;
			//         v28 = _mm_srli_si128((__m128i)v78._current, 8).m128i_u64[0];
			//         if ( !v28 )
			//           sub_1802DC2C8(v26, v25);
			//       }
			//       while ( !*(_DWORD *)(v28 + 24) );
			//       DefaultFramingComposeItem = HG::Rendering::Runtime::VolumetricRenderer::GetDefaultFramingComposeItem(
			//                                     v98,
			//                                     v3,
			//                                     inputs.volumetricComposeMaterial,
			//                                     0LL);
			//       v31 = *(_OWORD *)&DefaultFramingComposeItem.Callback;
			//       v79 = *(_OWORD *)&DefaultFramingComposeItem.Callback;
			//       v32 = *(_OWORD *)&DefaultFramingComposeItem.bounds.enableBounds;
			//       v80 = v32;
			//       v33 = *(_OWORD *)&DefaultFramingComposeItem.bounds.worldBounds.m_Extents.x;
			//       v81 = v33;
			//       v34 = *(__m128i *)&DefaultFramingComposeItem.SortingOrder;
			//       v82 = v34;
			//       v35 = *(__m128i *)&DefaultFramingComposeItem.bPureBlit;
			//       v83 = v35;
			//       meshFilter = DefaultFramingComposeItem.meshFilter;
			//       v84 = meshFilter;
			//       v37 = 0LL;
			//       v101 = 0LL;
			//       v38 = (List_1_System_Object_ *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
			//       if ( !v38 )
			//         sub_1802DC2C8(v30, 0LL);
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         &v69,
			//         v38,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//       v73 = v69;
			//       ex = 0LL;
			//       v75 = &v73;
			//       try
			//       {
			// LABEL_51:
			//         v39 = _mm_cvtsi128_si32(_mm_srli_si128(v34, 12));
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v73,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//         {
			//           v41 = v73._current;
			//           if ( v73._current )
			//           {
			//             v71 = 0LL;
			//             v72 = 0LL;
			//             LOWORD(v71) = *(_WORD *)&v3.fields.m_EnableFraming;
			//             *((_QWORD *)&v71 + 1) = inputs.volumetricComposeMaterial;
			//             v42 = (unsigned int)dword_18D8E43F8;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v43 = ((((unsigned __int64)&v71 + 8) >> 12) & 0x1FFFFF) >> 6;
			//               _m_prefetchw(&qword_18D6405E0[v43 + 36190]);
			//               do
			//                 v44 = qword_18D6405E0[v43 + 36190];
			//               while ( v44 != _InterlockedCompareExchange64(
			//                                &qword_18D6405E0[v43 + 36190],
			//                                v44 | (1LL << ((((unsigned __int64)&v71 + 8) >> 12) & 0x3F)),
			//                                v44) );
			//               v42 = (unsigned int)dword_18D8E43F8;
			//             }
			//             volumetricParameters = (signed __int64)inputs.volumetricParameters;
			//             v72 = volumetricParameters;
			//             if ( (_DWORD)v42 )
			//             {
			//               v46 = (((unsigned __int64)&v72 >> 12) & 0x1FFFFF) >> 6;
			//               v42 = ((unsigned __int64)&v72 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v46 + 36190]);
			//               do
			//               {
			//                 volumetricParameters = qword_18D6405E0[v46 + 36190] | (1LL << v42);
			//                 v47 = qword_18D6405E0[v46 + 36190];
			//               }
			//               while ( v47 != _InterlockedCompareExchange64(&qword_18D6405E0[v46 + 36190], volumetricParameters, v47) );
			//             }
			//             if ( !v41 )
			//               sub_1802DC2C8(volumetricParameters, v42);
			//             *(_OWORD *)&v85._dictionary = v71;
			//             *(_QWORD *)&v85._current.key = v72;
			//             if ( (unsigned __int8)sub_1886C0F04(v41, &v85, &v92) )
			//             {
			//               if ( v95.m128i_i32[3] > v39 )
			//               {
			//                 v31 = v92;
			//                 v79 = v92;
			//                 v32 = v93;
			//                 v80 = v93;
			//                 v33 = v94;
			//                 v81 = v94;
			//                 v34 = v95;
			//                 v82 = v95;
			//                 v35 = v96;
			//                 v83 = v96;
			//                 meshFilter = v97;
			//                 v84 = v97;
			//                 v37 = v41;
			//                 v101 = v41;
			//                 goto LABEL_51;
			//               }
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v90 )
			//       {
			//         v40 = v67;
			//         ex = v90.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v3 = this;
			//         meshFilter = v84;
			//         v35 = v83;
			//         v34 = v82;
			//         v33 = v81;
			//         v32 = v80;
			//         v31 = v79;
			//         v37 = v101;
			//       }
			//       if ( !(unsigned __int8)_mm_cvtsi128_si32(v35) )
			//         break;
			//       v48 = (Dictionary_2_System_Int32Enum_System_Object_ *)v3.fields.m_RenderStages;
			//       if ( !v48 )
			//         sub_1802DC2C8(0LL, v40);
			//       list = (Int32Enum__Enum)key._list;
			//       v50 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//               v48,
			//               (Int32Enum__Enum)key._list,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( !v50 )
			//         sub_1802DC2C8(v52, v51);
			//       if ( LOBYTE(v50[2].klass) )
			//       {
			// LABEL_73:
			//         RenderNodeFromPool = HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(v3, 0LL);
			//         v56 = RenderNodeFromPool;
			//         if ( !RenderNodeFromPool )
			//           sub_1802DC2C8(v55, v54);
			//         *(_OWORD *)&v98[0].Callback = v31;
			//         *(_OWORD *)&v98[0].bounds.enableBounds = v32;
			//         *(_OWORD *)&v98[0].bounds.worldBounds.m_Extents.x = v33;
			//         *(__m128i *)&v98[0].SortingOrder = v34;
			//         *(__m128i *)&v98[0].bPureBlit = v35;
			//         v98[0].meshFilter = meshFilter;
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(RenderNodeFromPool, v98, 0LL);
			//         v56.fields._RenderObject_k__BackingField = (IVolumetricRenderObject *)v37;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v58 = (((unsigned __int64)&v56.fields._RenderObject_k__BackingField >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v58 + 36190]);
			//           do
			//             v59 = qword_18D6405E0[v58 + 36190];
			//           while ( v59 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v58 + 36190],
			//                            v59 | (1LL << (((unsigned __int64)&v56.fields._RenderObject_k__BackingField >> 12) & 0x3F)),
			//                            v59) );
			//         }
			//         v56.fields._bComposePass_k__BackingField = 1;
			//         v60 = (Dictionary_2_System_Int32Enum_System_Object_ *)v3.fields.m_RenderStages;
			//         if ( !v60 )
			//           sub_1802DC2C8(0LL, v57);
			//         v61 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 v60,
			//                 list,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v61 )
			//           sub_1802DC2C8(v63, v62);
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
			//           (VolumetricRenderer_VolumetricRenderStage *)v61,
			//           v56,
			//           0LL);
			//       }
			//     }
			//     list = (Int32Enum__Enum)key._list;
			//     goto LABEL_73;
			//   }
			//   catch ( Il2CppExceptionWrapper *v91 )
			//   {
			//     v76 = v91.ex;
			//     if ( v76 )
			//       sub_18000F780(v76);
			//   }
			// }
			// 
		}

		private void ProcessTemporalCompose(ref VolumetricRenderInputs inputs)
		{
			// // Void ProcessTemporalCompose(VolumetricRenderInputs ByRef)
			// // Hidden C++ exception states: #wind=5
			// void HG::Rendering::Runtime::VolumetricRenderer::ProcessTemporalCompose(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   VolumetricRenderInputs *v3; // r14
			//   VolumetricRenderer *v4; // rdi
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_RenderStages; // rcx
			//   Object *Item; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *RenderNodes; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Dictionary_2_System_UInt64_System_Single_ *temporalCompose; // rdx
			//   __int64 v14; // rcx
			//   Object *v15; // rax
			//   List_1_System_Object_ *v16; // rax
			//   __int64 v17; // rcx
			//   Object *v18; // rax
			//   List_1_System_Object_ *v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
			//   unsigned __int64 v24; // xmm0_8
			//   VolumetricRenderer_VolumetricRenderItem *DefaultTemporalComposeItem; // rax
			//   __int64 v26; // rcx
			//   __int128 v27; // xmm9
			//   __int128 v28; // xmm10
			//   __int128 v29; // xmm11
			//   __m128i v30; // xmm7
			//   __m128i v31; // xmm8
			//   MeshFilter *meshFilter; // xmm12_8
			//   Object *v33; // r13
			//   List_1_System_Object_ *v34; // rdx
			//   int v35; // r12d
			//   unsigned __int64 v36; // rdx
			//   Object *v37; // rsi
			//   signed __int64 v38; // rcx
			//   unsigned __int64 v39; // r8
			//   signed __int64 v40; // rtt
			//   unsigned __int64 v41; // r8
			//   signed __int64 v42; // rtt
			//   Dictionary_2_System_Int32Enum_System_Object_ *v43; // rcx
			//   Int32Enum__Enum list; // r12d
			//   Object *v45; // rax
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   VolumetricRenderer_VolumetricRenderNode *RenderNodeFromPool; // rax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   VolumetricRenderer_VolumetricRenderNode *v51; // rsi
			//   __int64 v52; // rdx
			//   unsigned __int64 v53; // r9
			//   signed __int64 v54; // rtt
			//   Dictionary_2_System_Int32Enum_System_Object_ *v55; // rcx
			//   Object *v56; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   _BYTE v62[32]; // [rsp+0h] [rbp-308h] BYREF
			//   List_1_T_Enumerator_System_Object_ v63; // [rsp+30h] [rbp-2D8h] BYREF
			//   List_1_T_Enumerator_System_Object_ v64; // [rsp+48h] [rbp-2C0h] BYREF
			//   __int128 v65; // [rsp+60h] [rbp-2A8h] BYREF
			//   uint64_t volumetricParameters; // [rsp+70h] [rbp-298h] BYREF
			//   List_1_T_Enumerator_System_Object_ key; // [rsp+78h] [rbp-290h] BYREF
			//   List_1_T_Enumerator_System_Object_ v68; // [rsp+90h] [rbp-278h] BYREF
			//   Il2CppException *ex; // [rsp+A8h] [rbp-260h]
			//   List_1_T_Enumerator_System_Object_ *v70; // [rsp+B0h] [rbp-258h]
			//   Il2CppException *v71; // [rsp+B8h] [rbp-250h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v72; // [rsp+C0h] [rbp-248h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v73; // [rsp+C8h] [rbp-240h] BYREF
			//   __int128 v74; // [rsp+F0h] [rbp-218h]
			//   __int128 v75; // [rsp+100h] [rbp-208h]
			//   __int128 v76; // [rsp+110h] [rbp-1F8h]
			//   __m128i v77; // [rsp+120h] [rbp-1E8h]
			//   __m128i v78; // [rsp+130h] [rbp-1D8h]
			//   MeshFilter *v79; // [rsp+140h] [rbp-1C8h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v80; // [rsp+150h] [rbp-1B8h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+180h] [rbp-188h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+188h] [rbp-180h] BYREF
			//   Il2CppExceptionWrapper *v83; // [rsp+190h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v84; // [rsp+198h] [rbp-170h] BYREF
			//   Il2CppExceptionWrapper *v85; // [rsp+1A0h] [rbp-168h] BYREF
			//   __int128 v86; // [rsp+1B0h] [rbp-158h] BYREF
			//   __int128 v87; // [rsp+1C0h] [rbp-148h]
			//   __int128 v88; // [rsp+1D0h] [rbp-138h]
			//   __m128i v89; // [rsp+1E0h] [rbp-128h]
			//   __m128i v90; // [rsp+1F0h] [rbp-118h]
			//   MeshFilter *v91; // [rsp+200h] [rbp-108h]
			//   VolumetricRenderer_VolumetricRenderItem v92[2]; // [rsp+210h] [rbp-F8h] BYREF
			//   Object *v95; // [rsp+328h] [rbp+20h]
			// 
			//   v3 = inputs;
			//   v4 = this;
			//   if ( !byte_18D9197C2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Count);
			//     byte_18D9197C2 = 1;
			//   }
			//   memset(&v64, 0, sizeof(v64));
			//   memset(&v73, 0, sizeof(v73));
			//   memset(&v68, 0, sizeof(v68));
			//   sub_1802F01E0(&v86, 0LL, 88LL);
			//   v65 = 0LL;
			//   volumetricParameters = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4525, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4525, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v61, v60);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)v4, v3, 0LL);
			//     return;
			//   }
			//   HG::Rendering::Runtime::VolumetricRenderer::ClearComposeCache(v4, v4.fields.temporalCompose, 0LL);
			//   if ( v4.fields.m_EnableTAA )
			//   {
			//     if ( !v4.fields.m_RenderStages )
			//       sub_180B536AC(m_RenderStages, v5);
			//     Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//              (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages,
			//              (Int32Enum__Enum)0,
			//              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     if ( !Item )
			//       sub_180B536AC(v9, v8);
			//     RenderNodes = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                     (VolumetricRenderer_VolumetricRenderStage *)Item,
			//                     0LL);
			//     if ( !RenderNodes )
			//       sub_180B536AC(v12, v11);
			//     v64 = *(List_1_T_Enumerator_System_Object_ *)sub_180833B0C(&v80, RenderNodes);
			//     v63._list = 0LL;
			//     *(_QWORD *)&v63._index = &v64;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v64,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//       {
			//         if ( !v64._current )
			//           sub_1802DC2C8(v14, temporalCompose);
			//         HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//           v4,
			//           v4.fields.temporalCompose,
			//           EVolumetricStage__Enum_AfterTemporal,
			//           (IVolumetricRenderObject *)v64._current[7].monitor,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v81 )
			//     {
			//       temporalCompose = (Dictionary_2_System_UInt64_System_Single_ *)v62;
			//       v63._list = (List_1_System_Object_ *)v81.ex;
			//       if ( v63._list )
			//         sub_18000F780(v63._list);
			//       v3 = inputs;
			//       v4 = this;
			//     }
			//     m_RenderStages = (List_1_System_Object_ *)v4.fields.m_RenderStages;
			//     if ( !m_RenderStages )
			//       goto LABEL_91;
			//     v15 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//             (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//             (Int32Enum__Enum)1u,
			//             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     if ( !v15 )
			//       goto LABEL_91;
			//     v16 = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                      (VolumetricRenderer_VolumetricRenderStage *)v15,
			//                                      0LL);
			//     if ( !v16 )
			//       goto LABEL_91;
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &key,
			//       v16,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     v64 = key;
			//     v63._list = 0LL;
			//     *(_QWORD *)&v63._index = &v64;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v64,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//       {
			//         if ( !v64._current )
			//           sub_1802DC2C8(v17, temporalCompose);
			//         HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//           v4,
			//           v4.fields.temporalCompose,
			//           EVolumetricStage__Enum_AfterTemporal,
			//           (IVolumetricRenderObject *)v64._current[7].monitor,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v82 )
			//     {
			//       temporalCompose = (Dictionary_2_System_UInt64_System_Single_ *)v62;
			//       v63._list = (List_1_System_Object_ *)v82.ex;
			//       if ( v63._list )
			//         sub_18000F780(v63._list);
			//       v3 = inputs;
			//       v4 = this;
			//     }
			//     m_RenderStages = (List_1_System_Object_ *)v4.fields.m_RenderStages;
			//     if ( !m_RenderStages
			//       || (v18 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                   (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                   (Int32Enum__Enum)3u,
			//                   MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item)) == 0LL
			//       || (v19 = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                            (VolumetricRenderer_VolumetricRenderStage *)v18,
			//                                            0LL)) == 0LL )
			//     {
			// LABEL_91:
			//       sub_1802DC2C8(m_RenderStages, temporalCompose);
			//     }
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &key,
			//       v19,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     v64 = key;
			//     v63._list = 0LL;
			//     *(_QWORD *)&v63._index = &v64;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v64,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//       {
			//         if ( !v64._current )
			//           sub_1802DC2C8(m_RenderStages, v20);
			//         HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
			//           v4,
			//           v4.fields.temporalCompose,
			//           EVolumetricStage__Enum_AfterTemporal,
			//           (IVolumetricRenderObject *)v64._current[7].monitor,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v83 )
			//     {
			//       v63._list = (List_1_System_Object_ *)v83.ex;
			//       m_RenderStages = v63._list;
			//       if ( v63._list )
			//         sub_18000F780(v63._list);
			//       v3 = inputs;
			//       v4 = this;
			//     }
			//   }
			//   temporalCompose = (Dictionary_2_System_UInt64_System_Single_ *)v4.fields.temporalCompose;
			//   if ( !temporalCompose )
			//     goto LABEL_91;
			//   System::Collections::Generic::Dictionary<unsigned long,float>::GetEnumerator(
			//     (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Single_ *)&v80,
			//     temporalCompose,
			//     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
			//   v73 = v80;
			//   v71 = 0LL;
			//   v72 = &v73;
			//   try
			//   {
			//     while ( 1 )
			//     {
			//       do
			//       {
			//         if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v73,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext) )
			//           return;
			//         current = v73._current;
			//         *(KeyValuePair_2_System_Int32Enum_System_Object_ *)&key._list = v73._current;
			//         v24 = _mm_srli_si128((__m128i)v73._current, 8).m128i_u64[0];
			//         if ( !v24 )
			//           sub_1802DC2C8(v22, v21);
			//       }
			//       while ( !*(_DWORD *)(v24 + 24) );
			//       DefaultTemporalComposeItem = HG::Rendering::Runtime::VolumetricRenderer::GetDefaultTemporalComposeItem(
			//                                      v92,
			//                                      v4,
			//                                      v3.volumetricComposeMaterial,
			//                                      0LL);
			//       v27 = *(_OWORD *)&DefaultTemporalComposeItem.Callback;
			//       v74 = *(_OWORD *)&DefaultTemporalComposeItem.Callback;
			//       v28 = *(_OWORD *)&DefaultTemporalComposeItem.bounds.enableBounds;
			//       v75 = v28;
			//       v29 = *(_OWORD *)&DefaultTemporalComposeItem.bounds.worldBounds.m_Extents.x;
			//       v76 = v29;
			//       v30 = *(__m128i *)&DefaultTemporalComposeItem.SortingOrder;
			//       v77 = v30;
			//       v31 = *(__m128i *)&DefaultTemporalComposeItem.bPureBlit;
			//       v78 = v31;
			//       meshFilter = DefaultTemporalComposeItem.meshFilter;
			//       v79 = meshFilter;
			//       v33 = 0LL;
			//       v95 = 0LL;
			//       v34 = (List_1_System_Object_ *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
			//       if ( !v34 )
			//         sub_1802DC2C8(v26, 0LL);
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         &v63,
			//         v34,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//       v68 = v63;
			//       ex = 0LL;
			//       v70 = &v68;
			//       try
			//       {
			// LABEL_39:
			//         v35 = _mm_cvtsi128_si32(_mm_srli_si128(v30, 12));
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v68,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//         {
			//           v37 = v68._current;
			//           if ( v68._current )
			//           {
			//             v65 = 0LL;
			//             volumetricParameters = 0LL;
			//             LOWORD(v65) = *(_WORD *)&v4.fields.m_EnableFraming;
			//             *((_QWORD *)&v65 + 1) = v3.volumetricComposeMaterial;
			//             v38 = (unsigned int)dword_18D8E43F8;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v39 = ((((unsigned __int64)&v65 + 8) >> 12) & 0x1FFFFF) >> 6;
			//               v36 = (((unsigned __int64)&v65 + 8) >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v39 + 36190]);
			//               do
			//                 v40 = qword_18D6405E0[v39 + 36190];
			//               while ( v40 != _InterlockedCompareExchange64(&qword_18D6405E0[v39 + 36190], v40 | (1LL << v36), v40) );
			//               v38 = (unsigned int)dword_18D8E43F8;
			//             }
			//             volumetricParameters = (uint64_t)v3.volumetricParameters;
			//             if ( (_DWORD)v38 )
			//             {
			//               v41 = (((unsigned __int64)&volumetricParameters >> 12) & 0x1FFFFF) >> 6;
			//               v36 = ((unsigned __int64)&volumetricParameters >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v41 + 36190]);
			//               do
			//               {
			//                 v38 = qword_18D6405E0[v41 + 36190] | (1LL << v36);
			//                 v42 = qword_18D6405E0[v41 + 36190];
			//               }
			//               while ( v42 != _InterlockedCompareExchange64(&qword_18D6405E0[v41 + 36190], v38, v42) );
			//             }
			//             if ( !v37 )
			//               sub_1802DC2C8(v38, v36);
			//             *(_OWORD *)&v80._dictionary = v65;
			//             *(_QWORD *)&v80._current.key = volumetricParameters;
			//             if ( (unsigned __int8)sub_1886C0FB4(v37, &v80, &v86) )
			//             {
			//               if ( v89.m128i_i32[3] > v35 )
			//               {
			//                 v27 = v86;
			//                 v74 = v86;
			//                 v28 = v87;
			//                 v75 = v87;
			//                 v29 = v88;
			//                 v76 = v88;
			//                 v30 = v89;
			//                 v77 = v89;
			//                 v31 = v90;
			//                 v78 = v90;
			//                 meshFilter = v91;
			//                 v79 = v91;
			//                 v33 = v37;
			//                 v95 = v37;
			//                 goto LABEL_39;
			//               }
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v84 )
			//       {
			//         v36 = (unsigned __int64)v62;
			//         ex = v84.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v3 = inputs;
			//         v4 = this;
			//         meshFilter = v79;
			//         v31 = v78;
			//         v30 = v77;
			//         v29 = v76;
			//         v28 = v75;
			//         v27 = v74;
			//         v33 = v95;
			//       }
			//       if ( !(unsigned __int8)_mm_cvtsi128_si32(v31) )
			//         break;
			//       v43 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//       if ( !v43 )
			//         sub_1802DC2C8(0LL, v36);
			//       list = (Int32Enum__Enum)key._list;
			//       v45 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//               v43,
			//               (Int32Enum__Enum)key._list,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( !v45 )
			//         sub_1802DC2C8(v47, v46);
			//       if ( LOBYTE(v45[2].klass) )
			//       {
			// LABEL_61:
			//         RenderNodeFromPool = HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(v4, 0LL);
			//         v51 = RenderNodeFromPool;
			//         if ( !RenderNodeFromPool )
			//           sub_1802DC2C8(v50, v49);
			//         *(_OWORD *)&v92[0].Callback = v27;
			//         *(_OWORD *)&v92[0].bounds.enableBounds = v28;
			//         *(_OWORD *)&v92[0].bounds.worldBounds.m_Extents.x = v29;
			//         *(__m128i *)&v92[0].SortingOrder = v30;
			//         *(__m128i *)&v92[0].bPureBlit = v31;
			//         v92[0].meshFilter = meshFilter;
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(RenderNodeFromPool, v92, 0LL);
			//         v51.fields._RenderObject_k__BackingField = (IVolumetricRenderObject *)v33;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v53 = (((unsigned __int64)&v51.fields._RenderObject_k__BackingField >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v53 + 36190]);
			//           do
			//             v54 = qword_18D6405E0[v53 + 36190];
			//           while ( v54 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v53 + 36190],
			//                            v54 | (1LL << (((unsigned __int64)&v51.fields._RenderObject_k__BackingField >> 12) & 0x3F)),
			//                            v54) );
			//         }
			//         v51.fields._bComposePass_k__BackingField = 1;
			//         v55 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( !v55 )
			//           sub_1802DC2C8(0LL, v52);
			//         v56 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 v55,
			//                 list,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v56 )
			//           sub_1802DC2C8(v58, v57);
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
			//           (VolumetricRenderer_VolumetricRenderStage *)v56,
			//           v51,
			//           0LL);
			//       }
			//     }
			//     list = (Int32Enum__Enum)key._list;
			//     goto LABEL_61;
			//   }
			//   catch ( Il2CppExceptionWrapper *v85 )
			//   {
			//     v71 = v85.ex;
			//     if ( v71 )
			//       sub_18000F780(v71);
			//   }
			// }
			// 
		}

		private bool HasOffScreenPassBefore(VolumetricRenderer.VolumetricRenderNode target)
		{
			// // Boolean HasOffScreenPassBefore(VolumetricRenderer+VolumetricRenderNode)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// bool HG::Rendering::Runtime::VolumetricRenderer::HasOffScreenPassBefore(
			//         VolumetricRenderer *this,
			//         VolumetricRenderer_VolumetricRenderNode *target,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   bool v7; // bl
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *m_RenderNodes; // rdi
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   _QWORD v15[3]; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v16; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9197C3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     byte_18D9197C3 = 1;
			//   }
			//   memset(&v16, 0, sizeof(v16));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4536, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4536, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)target,
			//              0LL);
			//   }
			//   else
			//   {
			//     v7 = 0;
			//     m_RenderNodes = this.fields.m_RenderNodes;
			//     if ( !m_RenderNodes )
			//       sub_180B536AC(v6, v5);
			//     v16 = *(List_1_T_Enumerator_System_Object_ *)sub_180833B0C(v15, m_RenderNodes);
			//     v15[0] = 0LL;
			//     v15[1] = &v16;
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v16,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext)
			//          && target != (VolumetricRenderer_VolumetricRenderNode *)v16._current )
			//     {
			//       if ( !v16._current )
			//         sub_1802DC2C8(v10, v9);
			//       v7 = (LOBYTE(v16._current[7].klass) | v7) != 0;
			//     }
			//     return v7;
			//   }
			// }
			// 
			return default(bool);
		}

		private void ProcessPassMerge(ref VolumetricRenderInputs inputs)
		{
			// // Void ProcessPassMerge(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::ProcessPassMerge(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   bool v3; // bl
			//   __int64 v6; // rdx
			//   void *m_RenderStages; // rcx
			//   Object *Item; // rax
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *RenderNodes; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v3 = 0;
			//   if ( !byte_18D9197C4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Count);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D9197C4 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4530, 0LL) )
			//   {
			//     m_RenderStages = this.fields.m_RenderStages;
			//     if ( m_RenderStages )
			//     {
			//       Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
			//                (Int32Enum__Enum)1u,
			//                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( Item )
			//       {
			//         RenderNodes = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                         (VolumetricRenderer_VolumetricRenderStage *)Item,
			//                         0LL);
			//         if ( RenderNodes )
			//         {
			//           if ( RenderNodes.fields._size != 1 || !this.fields.m_EnableTAA )
			//             goto LABEL_13;
			//           m_RenderStages = inputs.volumetricParameters;
			//           if ( m_RenderStages )
			//           {
			//             if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    *((SettingParameter_1_System_Boolean_ **)m_RenderStages + 17),
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//             {
			// LABEL_13:
			//               this.fields.m_CanMergeTAAPass = v3;
			//               return;
			//             }
			//             m_RenderStages = inputs.volumetricParameters;
			//             if ( m_RenderStages )
			//             {
			//               v3 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                       *((SettingParameter_1_System_Boolean_ **)m_RenderStages + 18),
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//               goto LABEL_13;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(m_RenderStages, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4530, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			// }
			// 
		}

		private void UpdateVolumetricRenderPipeline(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateVolumetricRenderPipeline(VolumetricRenderInputs ByRef)
			// // Hidden C++ exception states: #wind=4 #try_helpers=1
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRenderPipeline(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   VolumetricRenderer *v4; // rdi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object *Item; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Dictionary_2_System_UInt64_System_Single_ *v10; // rdx
			//   Dictionary_2_System_Int32Enum_System_Object_ *v11; // rcx
			//   Object *current; // rsi
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Dictionary_2_System_Int32Enum_System_Object_ *m_RenderStages; // rcx
			//   Object *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Dictionary_2_System_Int32Enum_System_Object_ *v19; // rcx
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   bool bEnableTAA; // al
			//   __int64 v23; // rdx
			//   Dictionary_2_System_Int32Enum_System_Object_ *v24; // rcx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *m_RenderNodes; // rax
			//   Object *v30; // rax
			//   Object *v31; // rax
			//   bool v32; // al
			//   Object *v33; // rax
			//   IEnumerable_1_System_Object_ *RenderNodes; // r12
			//   Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *_9__74_0; // rsi
			//   Object *v36; // r14
			//   Func_2_Object_Boolean_ *v37; // rax
			//   unsigned __int64 v38; // r8
			//   unsigned __int64 v39; // rdx
			//   signed __int64 v40; // rtt
			//   Object *v41; // rax
			//   bool v42; // al
			//   Object *v43; // rax
			//   IEnumerable_1_System_Object_ *v44; // r13
			//   Func_2_Object_Boolean_ *_9__74_1; // r14
			//   Object *v46; // r12
			//   struct Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean___Class *element_class; // rsi
			//   __int64 v48; // rax
			//   __int64 v49; // rdx
			//   __int64 instance_size; // rcx
			//   unsigned __int64 v51; // r8
			//   unsigned __int64 v52; // rdx
			//   signed __int64 v53; // rtt
			//   VolumetricRenderInputs *v54; // rsi
			//   __int64 v55; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v59; // [rsp+30h] [rbp-A8h] BYREF
			//   List_1_T_Enumerator_System_Object_ v60; // [rsp+58h] [rbp-80h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v61; // [rsp+70h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v62; // [rsp+A0h] [rbp-38h] BYREF
			//   __int64 *v65; // [rsp+F8h] [rbp+20h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D9197C5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Any<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Current);
			//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode,bool>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Count);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c::_UpdateVolumetricRenderPipeline_b__74_0);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c::_UpdateVolumetricRenderPipeline_b__74_1);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
			//     byte_18D9197C5 = 1;
			//   }
			//   memset(&v60, 0, sizeof(v60));
			//   memset(&v61, 0, sizeof(v61));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4502, 0LL) )
			//   {
			//     HG::Rendering::Runtime::VolumetricRenderer::DisableAllStages(v4, 0LL);
			//     if ( v4.fields.m_EnableTAA )
			//     {
			//       if ( !v4.fields.m_RenderStages )
			//         sub_180B536AC(v6, v5);
			//       Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages,
			//                (Int32Enum__Enum)2u,
			//                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( !Item )
			//         sub_180B536AC(v9, v8);
			//       HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SetEnable(
			//         (VolumetricRenderer_VolumetricRenderStage *)Item,
			//         0LL);
			//     }
			//     if ( !v4.fields.m_RenderNodes )
			//       sub_180B536AC(v6, v5);
			//     v60 = *(List_1_T_Enumerator_System_Object_ *)sub_180833B0C(&v59, v4.fields.m_RenderNodes);
			//     v59._dictionary = 0LL;
			//     *(_QWORD *)&v59._version = &v60;
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v60,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//     {
			//       current = v60._current;
			//       if ( !v60._current )
			//         sub_1802DC2C8(v11, v10);
			//       if ( HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableFraming(
			//              (VolumetricRenderer_VolumetricRenderNode *)v60._current,
			//              0LL)
			//         && v4.fields.m_EnableFraming )
			//       {
			//         m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( !m_RenderStages )
			//           sub_1802DC2C8(0LL, v13);
			//         v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 m_RenderStages,
			//                 (Int32Enum__Enum)0,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v16 )
			//           sub_1802DC2C8(v18, v17);
			//       }
			//       else if ( v4.fields.m_EnableTAA )
			//       {
			//         if ( !current )
			//           sub_1802DC2C8(v14, v13);
			//         bEnableTAA = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableTAA(
			//                        (VolumetricRenderer_VolumetricRenderNode *)current,
			//                        0LL);
			//         v24 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( bEnableTAA )
			//         {
			//           if ( !v24 )
			//             sub_1802DC2C8(0LL, v23);
			//           v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                   v24,
			//                   (Int32Enum__Enum)1u,
			//                   MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//           if ( !v16 )
			//             sub_1802DC2C8(v28, v27);
			//         }
			//         else
			//         {
			//           if ( !v24 )
			//             sub_1802DC2C8(0LL, v23);
			//           v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                   v24,
			//                   (Int32Enum__Enum)3u,
			//                   MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//           if ( !v16 )
			//             sub_1802DC2C8(v26, v25);
			//         }
			//       }
			//       else
			//       {
			//         v19 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( !v19 )
			//           sub_1802DC2C8(0LL, v13);
			//         v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 v19,
			//                 (Int32Enum__Enum)3u,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v16 )
			//           sub_1802DC2C8(v21, v20);
			//       }
			//       HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
			//         (VolumetricRenderer_VolumetricRenderStage *)v16,
			//         (VolumetricRenderer_VolumetricRenderNode *)current,
			//         0LL);
			//     }
			//     m_RenderNodes = v4.fields.m_RenderNodes;
			//     if ( m_RenderNodes )
			//     {
			//       if ( m_RenderNodes.fields._size > 0 )
			//       {
			//         v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( !v11 )
			//           goto LABEL_97;
			//         v30 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 v11,
			//                 (Int32Enum__Enum)4u,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v30 )
			//           goto LABEL_97;
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SetEnable(
			//           (VolumetricRenderer_VolumetricRenderStage *)v30,
			//           0LL);
			//       }
			//       v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//       if ( !v11 )
			//         goto LABEL_97;
			//       v31 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//               v11,
			//               (Int32Enum__Enum)1u,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( !v31 )
			//         goto LABEL_97;
			//       if ( LOBYTE(v31[2].klass) )
			//       {
			//         v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( !v11 )
			//           goto LABEL_97;
			//         v33 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 v11,
			//                 (Int32Enum__Enum)1u,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v33 )
			//           goto LABEL_97;
			//         RenderNodes = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                                         (VolumetricRenderer_VolumetricRenderStage *)v33,
			//                                                         0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
			//         _9__74_0 = TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_0;
			//         if ( !_9__74_0 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
			//           v36 = (Object *)TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9;
			//           v37 = (Func_2_Object_Boolean_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode,bool>);
			//           _9__74_0 = (Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *)v37;
			//           if ( !v37 )
			//             goto LABEL_97;
			//           System::Func<System::Object,bool>::Func(
			//             v37,
			//             v36,
			//             MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c::_UpdateVolumetricRenderPipeline_b__74_0[0],
			//             0LL);
			//           TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_0 = _9__74_0;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v38 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_0 >> 12) & 0x1FFFFF) >> 6;
			//             v39 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_0 >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v38 + 36190]);
			//             do
			//               v40 = qword_18D6405E0[v38 + 36190];
			//             while ( v40 != _InterlockedCompareExchange64(&qword_18D6405E0[v38 + 36190], v40 | (1LL << v39), v40) );
			//           }
			//         }
			//         v32 = System::Linq::Enumerable::Any<System::Object>(
			//                 RenderNodes,
			//                 (Func_2_Object_Boolean_ *)_9__74_0,
			//                 MethodInfo::System::Linq::Enumerable::Any<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
			//       }
			//       else
			//       {
			//         v32 = 0;
			//       }
			//       v4.fields.m_BeforeTAANeedDepthTest = v32;
			//       v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//       if ( !v11 )
			//         goto LABEL_97;
			//       v41 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//               v11,
			//               (Int32Enum__Enum)3u,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//       if ( !v41 )
			//         goto LABEL_97;
			//       if ( LOBYTE(v41[2].klass) )
			//       {
			//         v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4.fields.m_RenderStages;
			//         if ( !v11 )
			//           goto LABEL_97;
			//         v43 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                 v11,
			//                 (Int32Enum__Enum)3u,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( !v43 )
			//           goto LABEL_97;
			//         v44 = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			//                                                 (VolumetricRenderer_VolumetricRenderStage *)v43,
			//                                                 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
			//         _9__74_1 = (Func_2_Object_Boolean_ *)TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_1;
			//         if ( !_9__74_1 )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
			//           v46 = (Object *)TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9;
			//           element_class = TypeInfo::System::Func<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode,bool>;
			//           if ( ((__int64)TypeInfo::System::Func<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode,bool>.vtable.Equals.methodPtr & 2) == 0 )
			//           {
			//             v65 = &qword_18CDB0B30;
			//             sub_1802924D0(&qword_18CDB0B30);
			//             sub_180060090(element_class, &v65);
			//             sub_180292530(v65);
			//           }
			//           if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//             element_class = (struct Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean___Class *)element_class._0.element_class;
			//           if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//           {
			//             instance_size = element_class._1.instance_size;
			//             if ( element_class._0.gc_desc )
			//               v48 = sub_180004F80(instance_size, element_class);
			//             else
			//               v48 = sub_180005D40(instance_size, element_class);
			//           }
			//           else
			//           {
			//             v48 = sub_180005FB0(element_class);
			//           }
			//           _9__74_1 = (Func_2_Object_Boolean_ *)v48;
			//           if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//             sub_18002E8C0(v48, (unsigned int)sub_18007DC30, 0, (unsigned int)&v59, (__int64)&v65);
			//           if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//             sub_1802DAEC4(_9__74_1, element_class);
			//           il2cpp_runtime_class_init_0(element_class, v49);
			//           if ( !_9__74_1 )
			//             goto LABEL_97;
			//           System::Func<System::Object,bool>::Func(
			//             _9__74_1,
			//             v46,
			//             MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c::_UpdateVolumetricRenderPipeline_b__74_1[0],
			//             0LL);
			//           TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_1 = (Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *)_9__74_1;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v51 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_1 >> 12) & 0x1FFFFF) >> 6;
			//             v52 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c.static_fields.__9__74_1 >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v51 + 36190]);
			//             do
			//               v53 = qword_18D6405E0[v51 + 36190];
			//             while ( v53 != _InterlockedCompareExchange64(&qword_18D6405E0[v51 + 36190], v53 | (1LL << v52), v53) );
			//           }
			//         }
			//         v42 = System::Linq::Enumerable::Any<System::Object>(
			//                 v44,
			//                 _9__74_1,
			//                 MethodInfo::System::Linq::Enumerable::Any<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
			//       }
			//       else
			//       {
			//         v42 = 0;
			//       }
			//       v4.fields.m_AfterTAANeedDepthTest = v42;
			//       v54 = inputs;
			//       HG::Rendering::Runtime::VolumetricRenderer::ProcessFramingCompose(v4, inputs, 0LL);
			//       HG::Rendering::Runtime::VolumetricRenderer::ProcessTemporalCompose(v4, inputs, 0LL);
			//       v10 = (Dictionary_2_System_UInt64_System_Single_ *)v4.fields.m_RenderStages;
			//       if ( v10 )
			//       {
			//         System::Collections::Generic::Dictionary<unsigned long,float>::GetEnumerator(
			//           (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Single_ *)&v59,
			//           v10,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::GetEnumerator);
			//         v61 = v59;
			//         v59._dictionary = 0LL;
			//         *(_QWORD *)&v59._version = &v61;
			//         try
			//         {
			//           while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                     &v61,
			//                     MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::MoveNext) )
			//           {
			//             if ( !v61._current.value )
			//               sub_1802DC2C8(0LL, v55);
			//             HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SortNodes(
			//               (VolumetricRenderer_VolumetricRenderStage *)v61._current.value,
			//               0LL);
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v62 )
			//         {
			//           v59._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v62.ex;
			//           if ( v59._dictionary )
			//             sub_18000F780(v59._dictionary);
			//           v4 = this;
			//           v54 = inputs;
			//         }
			//         HG::Rendering::Runtime::VolumetricRenderer::ProcessPassMerge(v4, v54, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_97:
			//     sub_1802DC2C8(v11, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4502, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v58, v57);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)v4, inputs, 0LL);
			// }
			// 
		}

		private void UpdateVolumetricCameraVP(HGCamera hgCamera, HGRenderGraphContext context)
		{
			// // Void UpdateVolumetricCameraVP(HGCamera, HGRenderGraphContext)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricCameraVP(
			//         VolumetricRenderer *this,
			//         HGCamera *hgCamera,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   __int64 v8; // rcx
			//   Camera *camera; // rdi
			//   float v10; // xmm11_4
			//   float fieldOfView; // xmm6_4
			//   float aspect; // xmm0_4
			//   Matrix4x4 *v13; // rax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v18; // xmm6
			//   __int128 v19; // xmm7
			//   __int128 v20; // xmm8
			//   __int128 v21; // xmm9
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   float v26; // xmm15_4
			//   double v27; // xmm0_8
			//   float v28; // xmm15_4
			//   float v29; // xmm6_4
			//   float v30; // xmm7_4
			//   __int128 v31; // xmm6
			//   CBHandle *ConstantBuffer; // rax
			//   void *ptr; // xmm1_8
			//   CommandBuffer *cmd; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t offset_8[4]; // [rsp+38h] [rbp-D0h] BYREF
			//   void *v37; // [rsp+48h] [rbp-C0h]
			//   float v38; // [rsp+50h] [rbp-B8h]
			//   Matrix4x4 v39; // [rsp+58h] [rbp-B0h] BYREF
			//   Matrix4x4 v40; // [rsp+98h] [rbp-70h] BYREF
			//   Matrix4x4 v41; // [rsp+F8h] [rbp-10h]
			//   _OWORD v42[2]; // [rsp+138h] [rbp+30h] BYREF
			//   Matrix4x4 v43; // [rsp+158h] [rbp+50h]
			//   CBHandle v44[7]; // [rsp+198h] [rbp+90h] BYREF
			// 
			//   if ( !byte_18D9197C6 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGVolumetricComposeData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9197C6 = 1;
			//   }
			//   *(_QWORD *)&offset_8[2] = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4483, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         v10 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//         fieldOfView = UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//         aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
			//         v13 = UnityEngine::Matrix4x4::Perspective(&v40, fieldOfView, aspect, v10, 10000.0, 0LL);
			//         v14 = *(_OWORD *)&v13.m01;
			//         *(_OWORD *)&v39.m00 = *(_OWORD *)&v13.m00;
			//         v15 = *(_OWORD *)&v13.m02;
			//         *(_OWORD *)&v39.m01 = v14;
			//         v16 = *(_OWORD *)&v13.m03;
			//         *(_OWORD *)&v39.m02 = v15;
			//         *(_OWORD *)&v39.m03 = v16;
			//         GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v40, &v39, 1, 0LL);
			//         v18 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//         v19 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//         v20 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//         v21 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//         worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v40, camera, 0LL);
			//         v23 = *(_OWORD *)&worldToCameraMatrix.m01;
			//         *(_OWORD *)&v39.m00 = *(_OWORD *)&worldToCameraMatrix.m00;
			//         v24 = *(_OWORD *)&worldToCameraMatrix.m02;
			//         *(_OWORD *)&v39.m01 = v23;
			//         v25 = *(_OWORD *)&worldToCameraMatrix.m03;
			//         *(_OWORD *)&v39.m02 = v24;
			//         *(_OWORD *)&v39.m03 = v25;
			//         *(_OWORD *)&v40.m00 = v18;
			//         *(_OWORD *)&v40.m01 = v19;
			//         *(_OWORD *)&v40.m02 = v20;
			//         *(_OWORD *)&v40.m03 = v21;
			//         v41 = *UnityEngine::Matrix4x4::op_Multiply((Matrix4x4 *)v42, &v40, &v39, 0LL);
			//         *(double *)&v24 = sub_1802EAFE0();
			//         v26 = *(float *)&v24;
			//         v27 = sub_1802EAFE0();
			//         v38 = 1.0 / (float)(v26 - *(float *)&v27);
			//         v28 = v26 - *(float *)&v27;
			//         *(float *)&offset_8[1] = 10000.0 / v10;
			//         v29 = 1.0 - (float)(10000.0 / v10);
			//         *(float *)offset_8 = v29;
			//         v30 = v29 / 10000.0;
			//         *(float *)&offset_8[3] = (float)(10000.0 / v10) / 10000.0;
			//         *(float *)&offset_8[2] = v29 / 10000.0;
			//         if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
			//         {
			//           *(float *)offset_8 = -v29;
			//           *(float *)&offset_8[2] = -v30;
			//           *(float *)&offset_8[1] = (float)(10000.0 / v10) + v29;
			//           *(float *)&offset_8[3] = (float)((float)(10000.0 / v10) / 10000.0) + v30;
			//         }
			//         v40.m01 = v38;
			//         v40.m11 = (float)-*(float *)&v27 / v28;
			//         v40.m21 = v28;
			//         v40.m31 = *(float *)&v27;
			//         v31 = *(_OWORD *)offset_8;
			//         if ( context )
			//         {
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                              v44,
			//                              &context.fields.renderContext,
			//                              96,
			//                              0LL);
			//           ptr = ConstantBuffer.ptr;
			//           *(_OWORD *)offset_8 = *(_OWORD *)&ConstantBuffer.bufferId;
			//           v37 = ptr;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           v42[1] = *(_OWORD *)&v40.m01;
			//           v43 = v41;
			//           v42[0] = v31;
			//           sub_180833708(offset_8, v42);
			//           cmd = context.fields.cmd;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           if ( cmd )
			//           {
			//             UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//               cmd,
			//               offset_8[0],
			//               static_fields._VolumetricComposeCB,
			//               offset_8[1],
			//               offset_8[2],
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v8, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4483, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     (Object *)context,
			//     0LL);
			// }
			// 
		}

		private void UpdateRenderStageAndDraw(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateRenderStageAndDraw(VolumetricRenderInputs ByRef)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateRenderStageAndDraw(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   VolumetricRenderInputs *v3; // r14
			//   VolumetricRenderer *v4; // rsi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGCamera *hgCamera; // r13
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rdx
			//   SettingParameter_1_System_Boolean_ **m_KeywordSpace; // rcx
			//   Object *current; // rbx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *itemCache; // rcx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // r15
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *v17; // r12
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   char v20; // r13
			//   int32_t i; // r12d
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *v22; // rax
			//   bool bEnableFraming; // r15
			//   HGVolumetricCloudSettingParameters *v24; // rcx
			//   __int64 v25; // rdx
			//   bool bEnableTAA; // r15
			//   HGVolumetricCloudSettingParameters *v27; // rcx
			//   VolumetricRenderer_VolumetricRenderNode *RenderNodeFromPool; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   Object *v31; // r15
			//   unsigned __int64 v32; // rdx
			//   signed __int64 v33; // rtt
			//   List_1_System_Object_ *m_RenderNodes; // rcx
			//   bool v35; // zf
			//   List_1_System_Object_ *v36; // rdx
			//   __int64 v37; // rcx
			//   Object *v38; // rbx
			//   bool m_EnableFraming; // r15
			//   bool m_EnableTAA; // r15
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   HGRenderGraphContext *context; // rax
			//   CommandBuffer *cmd; // r15
			//   Material *material; // r12
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   HGRenderGraphContext *v48; // rax
			//   CommandBuffer *v49; // r15
			//   Material *v50; // rax
			//   bool v51; // bl
			//   bool v52; // bl
			//   HGRenderGraphContext *v53; // r12
			//   CommandBuffer *v54; // r12
			//   unsigned int v55; // r13d
			//   int32_t DrawFrameCount_k__BackingField; // ebx
			//   void (__fastcall *v57)(CommandBuffer *, _QWORD, _QWORD); // rax
			//   unsigned int FrameCountMod16; // r13d
			//   int32_t v59; // ebx
			//   void (__fastcall *v60)(CommandBuffer *, _QWORD, _QWORD); // rax
			//   unsigned int FrameCountMod32; // r13d
			//   int32_t v62; // ebx
			//   void (__fastcall *v63)(CommandBuffer *, _QWORD, _QWORD); // rax
			//   HGVolumetricCloudSettingParameters *v64; // rax
			//   unsigned int PixelSubOffset; // r13d
			//   int32_t v66; // ebx
			//   void (__fastcall *v67)(CommandBuffer *, _QWORD, _QWORD); // rax
			//   signed int v68; // ebx
			//   unsigned int v69; // ebx
			//   int32_t v70; // ebx
			//   Material *v71; // rbx
			//   unsigned int DebugPixelOffset; // r13d
			//   float (__fastcall *v73)(Material *, _QWORD); // rax
			//   VolumetricShaderIDs__StaticFields *static_fields; // rax
			//   unsigned int v75; // r13d
			//   Material *v76; // rbx
			//   float (__fastcall *v77)(Material *, _QWORD); // rax
			//   unsigned int v78; // ebx
			//   void (__fastcall *v79)(CommandBuffer *, _QWORD, _QWORD); // rax
			//   bool v80; // al
			//   __int64 v81; // rdx
			//   VolumetricRenderer *v82; // r13
			//   Material *v83; // r15
			//   Shader *v84; // rbx
			//   String *v85; // r8
			//   Shader *v86; // rbx
			//   String *v87; // r8
			//   bool v88; // al
			//   __int64 v89; // rdx
			//   Material *v90; // r15
			//   Shader *v91; // rbx
			//   String *v92; // r8
			//   Shader *v93; // rbx
			//   String *v94; // r8
			//   bool v95; // al
			//   __int64 v96; // rdx
			//   Material *v97; // r15
			//   Shader *v98; // rbx
			//   String *v99; // r8
			//   Shader *v100; // rbx
			//   String *v101; // r8
			//   bool v102; // al
			//   __int64 v103; // rdx
			//   Material *v104; // r15
			//   Shader *v105; // rbx
			//   String *v106; // r8
			//   LocalKeyword *p_keyword; // r8
			//   Material *v108; // rdx
			//   Shader *v109; // rbx
			//   String *v110; // r8
			//   Material *m_VolumetricMat; // r15
			//   Material *v112; // rcx
			//   Shader *shader; // rbx
			//   String *s_ReconstructEnableMotionVector; // r8
			//   Material *v115; // rbx
			//   Shader *v116; // rax
			//   String *s_ReconstructEnableDepthOpt; // r8
			//   Material *v118; // rbx
			//   Shader *v119; // rax
			//   String *s_ReconstructEnableColorAABB; // r8
			//   Material *v121; // rbx
			//   Shader *v122; // rax
			//   String *s_ReconstructEnableNeighborAvg; // r8
			//   ILFixDynamicMethodWrapper_2 *v124; // rax
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v125; // rax
			//   List_1_System_Object_ *v126; // r15
			//   Comparison_1_Object_ *v127; // rax
			//   Comparison_1_Object_ *v128; // rbx
			//   unsigned int v129; // ebx
			//   Object *Item; // rax
			//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v131; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v133; // rdx
			//   __int64 v134; // rcx
			//   __int64 v135; // rax
			//   __int64 v136; // rax
			//   __int64 v137; // rax
			//   __int64 v138; // [rsp+0h] [rbp-208h] BYREF
			//   LocalKeyword v139; // [rsp+30h] [rbp-1D8h] BYREF
			//   LocalKeyword keyword; // [rsp+50h] [rbp-1B8h] BYREF
			//   LocalKeyword v141; // [rsp+70h] [rbp-198h] BYREF
			//   List_1_T_Enumerator_System_Object_ v142; // [rsp+90h] [rbp-178h] BYREF
			//   List_1_T_Enumerator_System_Object_ v143; // [rsp+A8h] [rbp-160h] BYREF
			//   Camera *camera; // [rsp+C0h] [rbp-148h]
			//   VolumetricRenderer *v145; // [rsp+C8h] [rbp-140h]
			//   LocalKeyword v146; // [rsp+D0h] [rbp-138h] BYREF
			//   LocalKeyword v147; // [rsp+E8h] [rbp-120h] BYREF
			//   VolumetricRenderer_VolumetricRenderItem v148; // [rsp+100h] [rbp-108h] BYREF
			//   VolumetricRenderer_VolumetricRenderItem v149; // [rsp+160h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v150; // [rsp+1C8h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v151; // [rsp+1D0h] [rbp-38h] BYREF
			//   HGCamera *v154; // [rsp+228h] [rbp+20h]
			//   unsigned int PixelOffsetTest; // [rsp+228h] [rbp+20h]
			// 
			//   v3 = inputs;
			//   v4 = this;
			//   v145 = this;
			//   if ( !byte_18D9197C7 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Sort);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D9197C7 = 1;
			//   }
			//   memset(&v142, 0, sizeof(v142));
			//   sub_1802F01E0(&v148, 0LL, 88LL);
			//   memset(&v143, 0, sizeof(v143));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4480, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4480, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v134, v133);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)v4, v3, 0LL);
			//     return;
			//   }
			//   hgCamera = v3.hgCamera;
			//   v154 = v3.hgCamera;
			//   if ( !v3.hgCamera )
			//     sub_180B536AC(v6, v5);
			//   camera = hgCamera.fields.camera;
			//   *(_WORD *)&v4.fields.m_EnableFraming = 0;
			//   ++v4.fields._DrawFrameCount_k__BackingField;
			//   if ( !v4.fields.m_RenderNodes )
			//     sub_180B536AC(v6, v5);
			//   sub_1823B99D0(
			//     v4.fields.m_RenderNodes,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Clear);
			//   HG::Rendering::Runtime::VolumetricRenderer::ResetRenderNodePool(v4, 0LL);
			//   HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricCameraVP(v4, hgCamera, v3.context, 0LL);
			//   if ( !v3.volumetricRenderObjects )
			//     sub_180B536AC(v9, v8);
			//   v142 = *(List_1_T_Enumerator_System_Object_ *)sub_18031B324(&v141, v3.volumetricRenderObjects);
			//   v139.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   v139.m_Name = (String *)&v142;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v142,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//     {
			//       current = v142._current;
			//       itemCache = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v4.fields._itemCache;
			//       if ( !itemCache )
			//         sub_1802DC2C8(0LL, v10);
			//       System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//         itemCache,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Clear);
			//       volumetricParameters = v3.volumetricParameters;
			//       v17 = v4.fields._itemCache;
			//       if ( !current )
			//         sub_1802DC2C8(v15, v14);
			//       if ( !byte_18D91981E )
			//       {
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IVolumetricRenderObject);
			//         byte_18D91981E = 1;
			//       }
			//       if ( *(_DWORD *)&current.klass._1.method_count == 3218 || *(_DWORD *)&current.klass._1.method_count == 3219 )
			//         HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItems(
			//           (VolumetricRenderObject *)current,
			//           hgCamera,
			//           volumetricParameters,
			//           v17,
			//           0LL);
			//       else
			//         sub_1808338C8(
			//           current.klass,
			//           *(_DWORD *)&current.klass._1.method_count - 3218,
			//           (_DWORD)current,
			//           (_DWORD)hgCamera,
			//           (__int64)volumetricParameters,
			//           (__int64)v17);
			//       v20 = 0;
			//       for ( i = 0; ; ++i )
			//       {
			//         v22 = v4.fields._itemCache;
			//         if ( !v22 )
			//           sub_1802DC2C8(v19, v18);
			//         if ( i >= v22.fields._size )
			//           break;
			//         System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Item(
			//           &v149,
			//           v4.fields._itemCache,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Item);
			//         v148 = v149;
			//         if ( HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::CheckVisibility(&v148, camera, 0LL) )
			//         {
			//           v20 = 1;
			//           bEnableFraming = v148.bEnableFraming;
			//           v24 = v3.volumetricParameters;
			//           if ( !v24 )
			//             sub_1802DC2C8(0LL, v18);
			//           v148.bEnableFraming = bEnableFraming & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                                    v24.fields.enableFraming,
			//                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           bEnableTAA = v148.bEnableTAA;
			//           v27 = v3.volumetricParameters;
			//           if ( !v27 )
			//             sub_1802DC2C8(0LL, v25);
			//           v148.bEnableTAA = bEnableTAA & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                            v27.fields.enableTAA,
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           RenderNodeFromPool = HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(v4, 0LL);
			//           v31 = (Object *)RenderNodeFromPool;
			//           if ( !RenderNodeFromPool )
			//             sub_1802DC2C8(v30, v29);
			//           v149 = v148;
			//           HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(
			//             RenderNodeFromPool,
			//             &v149,
			//             0LL);
			//           v31[7].monitor = (MonitorData *)current;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v32 = (((unsigned __int64)&v31[7].monitor >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6870D0[v32]);
			//             do
			//               v33 = qword_18D6870D0[v32];
			//             while ( v33 != _InterlockedCompareExchange64(
			//                              &qword_18D6870D0[v32],
			//                              v33 | (1LL << (((unsigned __int64)&v31[7].monitor >> 12) & 0x3F)),
			//                              v33) );
			//           }
			//           m_RenderNodes = (List_1_System_Object_ *)v4.fields.m_RenderNodes;
			//           if ( !m_RenderNodes )
			//             sub_1802DC2C8(0LL, v32);
			//           sub_1822AD140(m_RenderNodes, v31);
			//         }
			//       }
			//       v35 = v20 == 0;
			//       hgCamera = v154;
			//       if ( !v35 )
			//       {
			//         if ( !byte_18D91981F )
			//         {
			//           sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IVolumetricRenderObject);
			//           byte_18D91981F = 1;
			//         }
			//         if ( *(_DWORD *)&current.klass._1.method_count == 3218 || *(_DWORD *)&current.klass._1.method_count == 3219 )
			//           HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRendering(
			//             (VolumetricRenderObject *)current,
			//             v3,
			//             0LL);
			//         else
			//           sub_18083375C(1LL, (unsigned int)(*(_DWORD *)&current.klass._1.method_count - 3218), current, v3);
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v150 )
			//   {
			//     v139.m_SpaceInfo.m_KeywordSpace = v150.ex;
			//     m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v139.m_SpaceInfo.m_KeywordSpace;
			//     if ( v139.m_SpaceInfo.m_KeywordSpace )
			//       sub_18000F780(v139.m_SpaceInfo.m_KeywordSpace);
			//     v3 = inputs;
			//     v4 = this;
			//   }
			//   v36 = (List_1_System_Object_ *)v4.fields.m_RenderNodes;
			//   if ( !v36 )
			//     goto LABEL_163;
			//   System::Collections::Generic::List<System::Object>::GetEnumerator(
			//     (List_1_T_Enumerator_System_Object_ *)&keyword,
			//     v36,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
			//   v143 = (List_1_T_Enumerator_System_Object_)keyword;
			//   v139.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   v139.m_Name = (String *)&v143;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v143,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
			//     {
			//       v38 = v143._current;
			//       if ( !v143._current )
			//         sub_1802DC2C8(v37, v36);
			//       m_EnableFraming = v4.fields.m_EnableFraming;
			//       v4.fields.m_EnableFraming = (m_EnableFraming | HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableFraming(
			//                                                         (VolumetricRenderer_VolumetricRenderNode *)v143._current,
			//                                                         0LL)) != 0;
			//       m_EnableTAA = v4.fields.m_EnableTAA;
			//       v4.fields.m_EnableTAA = (m_EnableTAA | HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableTAA(
			//                                                 (VolumetricRenderer_VolumetricRenderNode *)v38,
			//                                                 0LL)) != 0;
			//       context = v3.context;
			//       if ( !context )
			//         sub_1802DC2C8(v42, v41);
			//       cmd = context.fields.cmd;
			//       material = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
			//                    (VolumetricRenderer_VolumetricRenderNode *)v38,
			//                    0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
			//         cmd,
			//         material,
			//         0,
			//         EFramingQuality__Enum_Checkerboard,
			//         0LL);
			//       v48 = v3.context;
			//       if ( !v48 )
			//         sub_1802DC2C8(v47, v46);
			//       v49 = v48.fields.cmd;
			//       v50 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
			//               (VolumetricRenderer_VolumetricRenderNode *)v38,
			//               0LL);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ResetTemporalKeywords(v49, v50, 0LL);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v151 )
			//   {
			//     v36 = (List_1_System_Object_ *)&v138;
			//     v139.m_SpaceInfo.m_KeywordSpace = v151.ex;
			//     if ( v139.m_SpaceInfo.m_KeywordSpace )
			//       sub_18000F780(v139.m_SpaceInfo.m_KeywordSpace);
			//     v3 = inputs;
			//     v4 = this;
			//   }
			//   m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//   if ( !m_KeywordSpace )
			//     goto LABEL_163;
			//   v51 = v4.fields.m_EnableFraming;
			//   v4.fields.m_EnableFraming = v51 & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                        m_KeywordSpace[5],
			//                                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//   if ( !m_KeywordSpace )
			//     goto LABEL_163;
			//   v52 = v4.fields.m_EnableTAA;
			//   v4.fields.m_EnableTAA = v52 & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                    m_KeywordSpace[13],
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v36 = (List_1_System_Object_ *)v3.context;
			//   if ( !v36 )
			//     goto LABEL_163;
			//   HG::Rendering::Runtime::VolumetricRenderer::UpdateCloudFadeParameters(v4, *(CommandBuffer **)&v36.fields._size, 0LL);
			//   if ( !byte_18D9197CA )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFramingQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D9197CA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4492, 0LL) )
			//   {
			//     v53 = v3.context;
			//     if ( !v53 )
			//       goto LABEL_163;
			//     v54 = v53.fields.cmd;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     v55 = *((_DWORD *)m_KeywordSpace + 262);
			//     DrawFrameCount_k__BackingField = v4.fields._DrawFrameCount_k__BackingField;
			//     if ( !v54 )
			//       goto LABEL_163;
			//     v57 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18D92FBC0;
			//     if ( !qword_18D92FBC0 )
			//     {
			//       v57 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Rendering.CommandBuffer::SetGlobalInt(Sy"
			//                                                                     "stem.Int32,System.Int32)");
			//       if ( !v57 )
			//       {
			//         v135 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::SetGlobalInt(System.Int32,System.Int32)");
			//         sub_18000F750(v135, 0LL);
			//       }
			//       qword_18D92FBC0 = (__int64)v57;
			//     }
			//     v57(v54, v55, (unsigned int)(DrawFrameCount_k__BackingField % 8));
			//     FrameCountMod16 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FrameCountMod16;
			//     v59 = v4.fields._DrawFrameCount_k__BackingField;
			//     v60 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18D92FBC0;
			//     if ( !qword_18D92FBC0 )
			//     {
			//       v60 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Rendering.CommandBuffer::SetGlobalInt(Sy"
			//                                                                     "stem.Int32,System.Int32)");
			//       if ( !v60 )
			//       {
			//         v136 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::SetGlobalInt(System.Int32,System.Int32)");
			//         sub_18000F750(v136, 0LL);
			//       }
			//       qword_18D92FBC0 = (__int64)v60;
			//     }
			//     v60(v54, FrameCountMod16, (unsigned int)(v59 % 16));
			//     FrameCountMod32 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FrameCountMod32;
			//     v62 = v4.fields._DrawFrameCount_k__BackingField;
			//     v63 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18D92FBC0;
			//     if ( !qword_18D92FBC0 )
			//     {
			//       v63 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Rendering.CommandBuffer::SetGlobalInt(Sy"
			//                                                                     "stem.Int32,System.Int32)");
			//       if ( !v63 )
			//       {
			//         v137 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::SetGlobalInt(System.Int32,System.Int32)");
			//         sub_18000F750(v137, 0LL);
			//       }
			//       qword_18D92FBC0 = (__int64)v63;
			//     }
			//     v63(v54, FrameCountMod32, (unsigned int)(v62 % 32));
			//     if ( !v4.fields.m_EnableFraming )
			//     {
			//       m_VolumetricMat = v4.fields.m_VolumetricMat;
			//       v112 = m_VolumetricMat;
			//       if ( !m_VolumetricMat )
			//         goto LABEL_162;
			//       shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//       s_ReconstructEnableMotionVector = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableMotionVector;
			//       memset(&v139, 0, sizeof(v139));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, shader, s_ReconstructEnableMotionVector, 0LL);
			//       v141 = v139;
			//       UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, m_VolumetricMat, &v141, 0LL);
			//       v115 = v4.fields.m_VolumetricMat;
			//       v112 = v115;
			//       if ( !v115 )
			//         goto LABEL_162;
			//       v116 = UnityEngine::Material::get_shader(v115, 0LL);
			//       s_ReconstructEnableDepthOpt = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableDepthOpt;
			//       memset(&v146, 0, sizeof(v146));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v146, v116, s_ReconstructEnableDepthOpt, 0LL);
			//       v141 = v146;
			//       UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, v115, &v141, 0LL);
			//       v118 = v4.fields.m_VolumetricMat;
			//       v112 = v118;
			//       if ( !v118 )
			//         goto LABEL_162;
			//       v119 = UnityEngine::Material::get_shader(v118, 0LL);
			//       s_ReconstructEnableColorAABB = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableColorAABB;
			//       memset(&v147, 0, sizeof(v147));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v147, v119, s_ReconstructEnableColorAABB, 0LL);
			//       v141 = v147;
			//       UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, v118, &v141, 0LL);
			//       v121 = v4.fields.m_VolumetricMat;
			//       v112 = v121;
			//       if ( !v121 )
			// LABEL_162:
			//         sub_1802DC2C8(v112, v36);
			//       v122 = UnityEngine::Material::get_shader(v121, 0LL);
			//       s_ReconstructEnableNeighborAvg = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableNeighborAvg;
			//       memset(&keyword, 0, sizeof(keyword));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&keyword, v122, s_ReconstructEnableNeighborAvg, 0LL);
			//       v141 = keyword;
			//       p_keyword = &v141;
			//       v108 = v121;
			// LABEL_119:
			//       UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, v108, p_keyword, 0LL);
			//       goto LABEL_122;
			//     }
			//     v64 = v3.volumetricParameters;
			//     if ( !v64 )
			//       goto LABEL_163;
			//     m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v64.fields.framingLevel;
			//     if ( !m_KeywordSpace )
			//       goto LABEL_163;
			//     if ( *((_DWORD *)m_KeywordSpace + 10) )
			//     {
			//       if ( *((_DWORD *)m_KeywordSpace + 10) != 1 )
			//         goto LABEL_80;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       PixelSubOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PixelSubOffset;
			//       v70 = v4.fields._DrawFrameCount_k__BackingField;
			//       v67 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18D92FBC0;
			//       if ( !qword_18D92FBC0 )
			//       {
			//         v67 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))sub_180017470(
			//                                                                       "UnityEngine.Rendering.CommandBuffer::SetGlobalInt("
			//                                                                       "System.Int32,System.Int32)");
			//         qword_18D92FBC0 = (__int64)v67;
			//       }
			//       v68 = v70 & 0x80000003;
			//       if ( v68 >= 0 )
			//       {
			// LABEL_79:
			//         v67(v54, PixelSubOffset, (unsigned int)v68);
			// LABEL_80:
			//         v71 = v4.fields.m_VolumetricMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         if ( !v71 )
			//           goto LABEL_163;
			//         DebugPixelOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DebugPixelOffset;
			//         v73 = (float (__fastcall *)(Material *, _QWORD))qword_18D8F4790;
			//         if ( !qword_18D8F4790 )
			//         {
			//           v73 = (float (__fastcall *)(Material *, _QWORD))sub_180017470("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//           qword_18D8F4790 = (__int64)v73;
			//         }
			//         if ( (int)v73(v71, DebugPixelOffset) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           v75 = static_fields._PixelSubOffset;
			//           v76 = v4.fields.m_VolumetricMat;
			//           if ( !v76 )
			//             goto LABEL_163;
			//           PixelOffsetTest = static_fields._PixelOffsetTest;
			//           v77 = (float (__fastcall *)(Material *, _QWORD))qword_18D8F4790;
			//           if ( !qword_18D8F4790 )
			//           {
			//             v77 = (float (__fastcall *)(Material *, _QWORD))sub_180017470("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//             qword_18D8F4790 = (__int64)v77;
			//           }
			//           v78 = (int)v77(v76, PixelOffsetTest);
			//           v79 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18D92FBC0;
			//           if ( !qword_18D92FBC0 )
			//           {
			//             v79 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))sub_180017470(
			//                                                                           "UnityEngine.Rendering.CommandBuffer::SetGlobal"
			//                                                                           "Int(System.Int32,System.Int32)");
			//             qword_18D92FBC0 = (__int64)v79;
			//           }
			//           v79(v54, v75, v78);
			//         }
			//         m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//         if ( m_KeywordSpace )
			//         {
			//           v80 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                   m_KeywordSpace[9],
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           v82 = v145;
			//           v83 = v145.fields.m_VolumetricMat;
			//           if ( v80 )
			//           {
			//             if ( !v83 )
			//               sub_1802DC2C8(0LL, v81);
			//             v86 = UnityEngine::Material::get_shader(v83, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//             v87 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableMotionVector;
			//             memset(&v139, 0, sizeof(v139));
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v86, v87, 0LL);
			//             keyword = v139;
			//             UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v54, v83, &keyword, 0LL);
			//           }
			//           else
			//           {
			//             if ( !v83 )
			//               sub_1802DC2C8(0LL, v81);
			//             v84 = UnityEngine::Material::get_shader(v83, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//             v85 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableMotionVector;
			//             memset(&v139, 0, sizeof(v139));
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v84, v85, 0LL);
			//             keyword = v139;
			//             UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, v83, &keyword, 0LL);
			//           }
			//           m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//           if ( m_KeywordSpace )
			//           {
			//             v88 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                     m_KeywordSpace[10],
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//             v90 = v82.fields.m_VolumetricMat;
			//             if ( v88 )
			//             {
			//               if ( !v90 )
			//                 sub_1802DC2C8(0LL, v89);
			//               v93 = UnityEngine::Material::get_shader(v90, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//               v94 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableDepthOpt;
			//               memset(&v139, 0, sizeof(v139));
			//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v93, v94, 0LL);
			//               keyword = v139;
			//               UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v54, v90, &keyword, 0LL);
			//             }
			//             else
			//             {
			//               if ( !v90 )
			//                 sub_1802DC2C8(0LL, v89);
			//               v91 = UnityEngine::Material::get_shader(v90, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//               v92 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableDepthOpt;
			//               memset(&v139, 0, sizeof(v139));
			//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v91, v92, 0LL);
			//               keyword = v139;
			//               UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, v90, &keyword, 0LL);
			//             }
			//             m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//             if ( m_KeywordSpace )
			//             {
			//               v95 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                       m_KeywordSpace[11],
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//               v97 = v82.fields.m_VolumetricMat;
			//               if ( v95 )
			//               {
			//                 if ( !v97 )
			//                   sub_1802DC2C8(0LL, v96);
			//                 v100 = UnityEngine::Material::get_shader(v97, 0LL);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                 v101 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableColorAABB;
			//                 memset(&v139, 0, sizeof(v139));
			//                 UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v100, v101, 0LL);
			//                 keyword = v139;
			//                 UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v54, v97, &keyword, 0LL);
			//               }
			//               else
			//               {
			//                 if ( !v97 )
			//                   sub_1802DC2C8(0LL, v96);
			//                 v98 = UnityEngine::Material::get_shader(v97, 0LL);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                 v99 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableColorAABB;
			//                 memset(&v139, 0, sizeof(v139));
			//                 UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v98, v99, 0LL);
			//                 keyword = v139;
			//                 UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v54, v97, &keyword, 0LL);
			//               }
			//               m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//               if ( m_KeywordSpace )
			//               {
			//                 v102 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                          m_KeywordSpace[12],
			//                          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                 v104 = v82.fields.m_VolumetricMat;
			//                 if ( v102 )
			//                 {
			//                   if ( !v104 )
			//                     sub_1802DC2C8(0LL, v103);
			//                   v109 = UnityEngine::Material::get_shader(v104, 0LL);
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                   v110 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableNeighborAvg;
			//                   memset(&v139, 0, sizeof(v139));
			//                   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v109, v110, 0LL);
			//                   keyword = v139;
			//                   UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v54, v104, &keyword, 0LL);
			//                   goto LABEL_122;
			//                 }
			//                 if ( !v104 )
			//                   sub_1802DC2C8(0LL, v103);
			//                 v105 = UnityEngine::Material::get_shader(v104, 0LL);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                 v106 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableNeighborAvg;
			//                 memset(&v139, 0, sizeof(v139));
			//                 UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v139, v105, v106, 0LL);
			//                 keyword = v139;
			//                 p_keyword = &keyword;
			//                 v108 = v104;
			//                 goto LABEL_119;
			//               }
			//             }
			//           }
			//         }
			// LABEL_163:
			//         sub_1802DC2C8(m_KeywordSpace, v36);
			//       }
			//       v69 = ((_BYTE)v68 - 1) | 0xFFFFFFFC;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       PixelSubOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PixelSubOffset;
			//       v66 = v4.fields._DrawFrameCount_k__BackingField;
			//       v67 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18D92FBC0;
			//       if ( !qword_18D92FBC0 )
			//       {
			//         v67 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))sub_180017470(
			//                                                                       "UnityEngine.Rendering.CommandBuffer::SetGlobalInt("
			//                                                                       "System.Int32,System.Int32)");
			//         qword_18D92FBC0 = (__int64)v67;
			//       }
			//       v68 = v66 & 0x80000001;
			//       if ( v68 >= 0 )
			//         goto LABEL_79;
			//       v69 = ((_BYTE)v68 - 1) | 0xFFFFFFFE;
			//     }
			//     v68 = v69 + 1;
			//     goto LABEL_79;
			//   }
			//   v124 = IFix::WrappersManagerImpl::GetPatch(4492, 0LL);
			//   if ( !v124 )
			//     goto LABEL_163;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(v124, (Object *)v4, v3, 0LL);
			// LABEL_122:
			//   HG::Rendering::Runtime::VolumetricRenderer::UpdateTAARender(v4, v3, 0LL);
			//   HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResRender(v4, v3, 0LL);
			//   HG::Rendering::Runtime::VolumetricRenderer::GetVolumetricRenderRTSize(v4, v3, 0LL);
			//   HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRTs(v4, v3, 0LL);
			//   v125 = v4.fields.m_RenderNodes;
			//   if ( !v125 )
			//     goto LABEL_163;
			//   if ( v125.fields._size <= 0 )
			//     return;
			//   v126 = (List_1_System_Object_ *)v4.fields.m_RenderNodes;
			//   v127 = (Comparison_1_Object_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
			//   v128 = v127;
			//   if ( !v127 )
			//     goto LABEL_163;
			//   System::Comparison<System::Object>::Comparison(
			//     v127,
			//     0LL,
			//     MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare,
			//     0LL);
			//   System::Collections::Generic::List<System::Object>::Sort(
			//     v126,
			//     v128,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Sort);
			//   v129 = 0;
			//   for ( m_KeywordSpace = 0LL; ; m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v129 )
			//   {
			//     v131 = v4.fields.m_RenderNodes;
			//     if ( !v131 )
			//       goto LABEL_163;
			//     if ( (int)m_KeywordSpace >= v131.fields._size )
			//       break;
			//     m_KeywordSpace = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RenderNodes;
			//     if ( !m_KeywordSpace )
			//       goto LABEL_163;
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              (List_1_System_Object_ *)m_KeywordSpace,
			//              v129,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			//     if ( !Item )
			//       goto LABEL_163;
			//     HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetIndex(
			//       (VolumetricRenderer_VolumetricRenderNode *)Item,
			//       v129++,
			//       0LL);
			//   }
			//   HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRenderPipeline(v4, v3, 0LL);
			//   HG::Rendering::Runtime::VolumetricRenderer::DrawVolumetric(v4, v3, 0LL);
			// }
			// 
		}

		private void UpdateDownResParameters(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateDownResParameters(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResParameters(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
			//   HGRenderGraphContext *context; // rsi
			//   CommandBuffer *cmd; // rsi
			//   Vector4 *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   int32_t v12; // r10d
			//   TextureHandle sceneDepthToSample; // xmm6
			//   int32_t WorldDepthTex; // ebx
			//   RenderTargetIdentifier *v15; // rax
			//   __int128 v16; // xmm1
			//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
			//   int32_t HistoryWorldDepthTex; // ebx
			//   RenderTargetIdentifier *v19; // rax
			//   __int128 v20; // xmm1
			//   int32_t DownscaleScreenParams; // edx
			//   Vector4 *v22; // rax
			//   __int64 v23; // rdx
			//   HGVolumetricCloudSettingParameters *v24; // rcx
			//   int32_t v25; // r10d
			//   Vector4 m_DownscaledScreenParams; // xmm1
			//   MethodInfo *v27; // r9
			//   Vector4 *v28; // rax
			//   int32_t v29; // edx
			//   __int64 v30; // rax
			//   RenderTexture *v31; // rbx
			//   Material *m_VolumetricMat; // r15
			//   VolumetricPipelineRT *m_MinMaxWorldDepths; // rcx
			//   Shader *shader; // rbx
			//   String *s_EnableDepthForTest; // r8
			//   __int64 m_RTIndex; // rax
			//   Texture *RT; // rax
			//   RenderTargetIdentifier *v38; // rax
			//   __int64 v39; // xmm11_8
			//   __int128 v40; // xmm9
			//   __int128 v41; // xmm10
			//   Texture *v42; // rax
			//   RenderTargetIdentifier *v43; // rax
			//   __int128 v44; // xmm7
			//   __int128 v45; // xmm8
			//   __int64 v46; // xmm6_8
			//   Material *v47; // rbx
			//   __int64 v48; // rdx
			//   Material *v49; // r15
			//   VolumetricPipelineRT *v50; // rcx
			//   Shader *v51; // rbx
			//   String *v52; // r8
			//   __int64 v53; // rax
			//   int32_t v54; // ebx
			//   Texture *v55; // rax
			//   RenderTargetIdentifier *v56; // rax
			//   __int128 v57; // xmm1
			//   __int64 v58; // rdx
			//   int32_t v59; // ebx
			//   VolumetricPipelineRT *v60; // rcx
			//   int v61; // r14d
			//   Texture *v62; // rax
			//   RenderTargetIdentifier *v63; // rax
			//   __int128 v64; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 value_8; // [rsp+38h] [rbp-D0h] BYREF
			//   LocalKeyword v67; // [rsp+48h] [rbp-C0h] BYREF
			//   RenderTargetIdentifier v68; // [rsp+68h] [rbp-A0h] BYREF
			//   RenderTargetIdentifier keyword; // [rsp+98h] [rbp-70h] BYREF
			//   RenderTargetIdentifier v70[3]; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D9197C8 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D9197C8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4532, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4532, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//       return;
			//     }
			//     goto LABEL_41;
			//   }
			//   context = inputs.context;
			//   if ( !context )
			//     goto LABEL_41;
			//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs.volumetricParameters;
			//   cmd = context.fields.cmd;
			//   if ( !volumetricParameters )
			//     goto LABEL_41;
			//   if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           volumetricParameters[2],
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     v9 = (Vector4 *)sub_1825A3980(&v67, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//     if ( !cmd )
			//       sub_180B536AC(v11, v10);
			//     value_8 = *v9;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v12, &value_8, 0LL);
			//     sceneDepthToSample = inputs.sceneDepthToSample;
			//     WorldDepthTex = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WorldDepthTex;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     value_8 = (Vector4)sceneDepthToSample;
			//     v15 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v68, (TextureHandle *)&value_8, 0LL);
			//     v16 = *(_OWORD *)&v15.m_BufferPointer;
			//     *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v15.m_Type;
			//     *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v15.m_DepthSlice;
			//     *(_OWORD *)&keyword.m_BufferPointer = v16;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, WorldDepthTex, &keyword, 0LL);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     value_8 = (Vector4)inputs.historySceneDepth;
			//     HistoryWorldDepthTex = static_fields._HistoryWorldDepthTex;
			//     v19 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v68, (TextureHandle *)&value_8, 0LL);
			//     v20 = *(_OWORD *)&v19.m_BufferPointer;
			//     *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v19.m_Type;
			//     *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v19.m_DepthSlice;
			//     *(_OWORD *)&keyword.m_BufferPointer = v20;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HistoryWorldDepthTex, &keyword, 0LL);
			//     DownscaleScreenParams = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DownscaleScreenParams;
			//     value_8 = this.fields.m_DownscaledScreenParams;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, DownscaleScreenParams, &value_8, 0LL);
			//     return;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   v22 = (Vector4 *)sub_1825A3980(
			//                      &v67,
			//                      _mm_unpacklo_ps(
			//                        (__m128)LODWORD(this.fields.m_NDCRescaleParams.x),
			//                        (__m128)LODWORD(this.fields.m_NDCRescaleParams.y)).m128_u64[0]);
			//   if ( !cmd
			//     || (value_8 = *v22,
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v25, &value_8, 0LL),
			//         (v24 = inputs.volumetricParameters) == 0LL) )
			//   {
			//     sub_180B536AC(v24, v23);
			//   }
			//   value_8.z = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                 v24.fields.downResRatio,
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   value_8.x = 1.0 / value_8.z;
			//   m_DownscaledScreenParams = this.fields.m_DownscaledScreenParams;
			//   value_8.y = 1.0 / value_8.z;
			//   value_8.w = value_8.z;
			//   *(Vector4 *)&v67.m_SpaceInfo.m_KeywordSpace = m_DownscaledScreenParams;
			//   v28 = UnityEngine::Vector4::Scale((Vector4 *)&keyword, (Vector4 *)&v67, &value_8, v27);
			//   v29 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DownscaleScreenParams;
			//   *(Vector4 *)&v67.m_SpaceInfo.m_KeywordSpace = *v28;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v29, (Vector4 *)&v67, 0LL);
			//   if ( this.fields.m_BeforeTAANeedDepthTest || this.fields.m_AfterTAANeedDepthTest )
			//   {
			//     m_VolumetricMat = this.fields.m_VolumetricMat;
			//     m_MinMaxWorldDepths = (VolumetricPipelineRT *)m_VolumetricMat;
			//     if ( !m_VolumetricMat )
			//       goto LABEL_38;
			//     shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     s_EnableDepthForTest = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableDepthForTest;
			//     memset(&v67, 0, sizeof(v67));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v67, shader, s_EnableDepthForTest, 0LL);
			//     keyword.m_BufferPointer = *(void **)&v67.m_Index;
			//     *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v67.m_SpaceInfo.m_KeywordSpace;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, m_VolumetricMat, (LocalKeyword *)&keyword, 0LL);
			//     m_MinMaxWorldDepths = (VolumetricPipelineRT *)this.fields.m_MinMaxWorldDepths;
			//     m_RTIndex = this.fields.m_RTIndex;
			//     if ( !m_MinMaxWorldDepths )
			//       goto LABEL_38;
			//     if ( (unsigned int)m_RTIndex >= m_MinMaxWorldDepths.fields.Desc._width_k__BackingField )
			//       sub_180070270(m_MinMaxWorldDepths, v5);
			//     m_MinMaxWorldDepths = (VolumetricPipelineRT *)*((_QWORD *)&m_MinMaxWorldDepths.fields.Desc._msaaSamples_k__BackingField
			//                                                   + m_RTIndex);
			//     if ( !m_MinMaxWorldDepths
			//       || (RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_MinMaxWorldDepths, 0LL),
			//           v38 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v68, RT, 0LL),
			//           m_MinMaxWorldDepths = this.fields.m_DepthForTest,
			//           v39 = *(_QWORD *)&v38.m_DepthSlice,
			//           v40 = *(_OWORD *)&v38.m_Type,
			//           v41 = *(_OWORD *)&v38.m_BufferPointer,
			//           !m_MinMaxWorldDepths) )
			//     {
			// LABEL_38:
			//       sub_180B536AC(m_MinMaxWorldDepths, v5);
			//     }
			//     v42 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_MinMaxWorldDepths, 0LL);
			//     v43 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v68, v42, 0LL);
			//     v44 = *(_OWORD *)&v43.m_Type;
			//     v45 = *(_OWORD *)&v43.m_BufferPointer;
			//     v46 = *(_QWORD *)&v43.m_DepthSlice;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     *(_OWORD *)&v70[0].m_Type = v44;
			//     *(_OWORD *)&v70[0].m_BufferPointer = v45;
			//     *(_QWORD *)&v70[0].m_DepthSlice = v46;
			//     *(_OWORD *)&v68.m_Type = v40;
			//     *(_OWORD *)&v68.m_BufferPointer = v41;
			//     *(_QWORD *)&v68.m_DepthSlice = v39;
			//     HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetWithDepth(
			//       cmd,
			//       &v68,
			//       v70,
			//       RenderBufferLoadAction__Enum_DontCare,
			//       RenderBufferStoreAction__Enum_Store,
			//       0LL);
			//     goto LABEL_26;
			//   }
			//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)this.fields.m_MinMaxWorldDepths;
			//   v30 = this.fields.m_RTIndex;
			//   if ( !volumetricParameters )
			//     goto LABEL_41;
			//   if ( (unsigned int)v30 >= *((_DWORD *)volumetricParameters + 6) )
			//     sub_180070270(volumetricParameters, v5);
			//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)volumetricParameters[v30 + 4];
			//   if ( !volumetricParameters )
			// LABEL_41:
			//     sub_180B536AC(volumetricParameters, v5);
			//   v31 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)volumetricParameters, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(cmd, v31, 0LL);
			// LABEL_26:
			//   v47 = this.fields.m_VolumetricMat;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, v47, 0, 0, 0LL);
			//   v49 = this.fields.m_VolumetricMat;
			//   v50 = (VolumetricPipelineRT *)v49;
			//   if ( !v49 )
			//     goto LABEL_37;
			//   v51 = UnityEngine::Material::get_shader(v49, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//   v52 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableDepthForTest;
			//   memset(&v67, 0, sizeof(v67));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v67, v51, v52, 0LL);
			//   keyword.m_BufferPointer = *(void **)&v67.m_Index;
			//   *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v67.m_SpaceInfo.m_KeywordSpace;
			//   UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v49, (LocalKeyword *)&keyword, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   v53 = this.fields.m_RTIndex;
			//   v54 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WorldDepthTex;
			//   v50 = (VolumetricPipelineRT *)this.fields.m_MinMaxWorldDepths;
			//   if ( !v50 )
			//     goto LABEL_37;
			//   if ( (unsigned int)v53 >= v50.fields.Desc._width_k__BackingField )
			//     sub_180070270(v50, v48);
			//   v50 = (VolumetricPipelineRT *)*((_QWORD *)&v50.fields.Desc._msaaSamples_k__BackingField + v53);
			//   if ( !v50 )
			// LABEL_37:
			//     sub_180B536AC(v50, v48);
			//   v55 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v50, 0LL);
			//   v56 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v70, v55, 0LL);
			//   v57 = *(_OWORD *)&v56.m_BufferPointer;
			//   *(_OWORD *)&v68.m_Type = *(_OWORD *)&v56.m_Type;
			//   *(_QWORD *)&v68.m_DepthSlice = *(_QWORD *)&v56.m_DepthSlice;
			//   *(_OWORD *)&v68.m_BufferPointer = v57;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v54, &v68, 0LL);
			//   v59 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._HistoryWorldDepthTex;
			//   v60 = (VolumetricPipelineRT *)this.fields.m_MinMaxWorldDepths;
			//   if ( !v60 )
			//     goto LABEL_36;
			//   v61 = 1 - this.fields.m_RTIndex;
			//   if ( (unsigned int)v61 >= v60.fields.Desc._width_k__BackingField )
			//     sub_180070270(v60, v58);
			//   v60 = (VolumetricPipelineRT *)*((_QWORD *)&v60.fields.Desc._msaaSamples_k__BackingField + v61);
			//   if ( !v60 )
			// LABEL_36:
			//     sub_180B536AC(v60, v58);
			//   v62 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v60, 0LL);
			//   v63 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v70, v62, 0LL);
			//   v64 = *(_OWORD *)&v63.m_BufferPointer;
			//   *(_OWORD *)&v68.m_Type = *(_OWORD *)&v63.m_Type;
			//   *(_QWORD *)&v68.m_DepthSlice = *(_QWORD *)&v63.m_DepthSlice;
			//   *(_OWORD *)&v68.m_BufferPointer = v64;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v59, &v68, 0LL);
			// }
			// 
		}

		private void UpdateDownResRender(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateDownResRender(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResRender(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
			//   HGRenderGraphContext *context; // rsi
			//   CommandBuffer *cmd; // rsi
			//   bool v9; // al
			//   __int64 v10; // rdx
			//   Material *m_VolumetricMat; // r15
			//   HGVolumetricCloudSettingParameters *v12; // rcx
			//   Shader *v13; // rbx
			//   String *v14; // r8
			//   __m128 v15; // xmm0
			//   __m128 v16; // xmm6
			//   int v17; // eax
			//   __int64 v18; // rdx
			//   Material *v19; // r15
			//   Material *v20; // rcx
			//   Shader *v21; // rbx
			//   String *v22; // r8
			//   Material *v23; // rbx
			//   Shader *v24; // rax
			//   String *v25; // r8
			//   Material *v26; // r15
			//   Material *v27; // rcx
			//   Shader *v28; // rbx
			//   String *v29; // r8
			//   Material *v30; // rbx
			//   Material *v31; // r15
			//   Shader *v32; // rbx
			//   String *v33; // r8
			//   Shader *v34; // rax
			//   String *v35; // r8
			//   __m128 v36; // xmm1
			//   int32_t v37; // r10d
			//   __int64 v38; // rdx
			//   HGVolumetricCloudSettingParameters *downResFilter; // rcx
			//   int enableFraming; // ecx
			//   int v41; // ecx
			//   int v42; // ecx
			//   Material *v43; // r14
			//   Material *v44; // rcx
			//   Shader *v45; // rbx
			//   String *v46; // r8
			//   Material *v47; // rbx
			//   Shader *v48; // rax
			//   String *v49; // r8
			//   Material *v50; // rbx
			//   Shader *v51; // rax
			//   String *v52; // r8
			//   Material *v53; // rbx
			//   Shader *v54; // rax
			//   String *v55; // r8
			//   __int128 v56; // xmm0
			//   __int64 v57; // xmm1_8
			//   Material *v58; // r14
			//   Material *v59; // rcx
			//   Shader *v60; // rbx
			//   String *v61; // r8
			//   Material *v62; // rbx
			//   Shader *v63; // rax
			//   String *v64; // r8
			//   Material *v65; // rbx
			//   Shader *v66; // rax
			//   String *v67; // r8
			//   Material *v68; // r14
			//   Shader *v69; // rbx
			//   String *v70; // r8
			//   Material *v71; // rbx
			//   Shader *v72; // rax
			//   String *v73; // r8
			//   Material *v74; // rbx
			//   Shader *v75; // rax
			//   String *v76; // r8
			//   Shader *v77; // rax
			//   String *v78; // r8
			//   Material *v79; // r14
			//   Material *v80; // rcx
			//   Shader *v81; // rbx
			//   String *v82; // r8
			//   Material *v83; // rbx
			//   Shader *v84; // rax
			//   String *v85; // r8
			//   Material *v86; // rbx
			//   Shader *v87; // rax
			//   String *v88; // r8
			//   Material *v89; // rbx
			//   Shader *v90; // rax
			//   String *v91; // r8
			//   Shader *shader; // rbx
			//   String *s_EnableDownscale; // r8
			//   Material *v94; // rbx
			//   Shader *v95; // rax
			//   String *s_DownscaleTriple; // r8
			//   Material *v97; // rbx
			//   Shader *v98; // rax
			//   String *s_DownscaleQuarter; // r8
			//   Material *v100; // rbx
			//   Shader *v101; // rax
			//   String *s_UpscaleBilateral; // r8
			//   Material *v103; // rbx
			//   Shader *v104; // rax
			//   String *s_UpscaleNearest; // r8
			//   Material *v106; // rbx
			//   Shader *v107; // rax
			//   String *s_UpscaleNoisy; // r8
			//   Material *v109; // rbx
			//   Shader *v110; // rax
			//   String *s_EnableMinMaxDepth; // r8
			//   int32_t v112; // r10d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LocalKeyword keyword_8; // [rsp+28h] [rbp-E0h] BYREF
			//   LocalKeyword v115; // [rsp+48h] [rbp-C0h] BYREF
			//   LocalKeyword v116; // [rsp+68h] [rbp-A0h] BYREF
			//   LocalKeyword v117; // [rsp+80h] [rbp-88h] BYREF
			//   LocalKeyword v118; // [rsp+98h] [rbp-70h] BYREF
			//   LocalKeyword v119; // [rsp+B0h] [rbp-58h] BYREF
			//   LocalKeyword v120; // [rsp+C8h] [rbp-40h] BYREF
			//   LocalKeyword v121; // [rsp+E0h] [rbp-28h] BYREF
			//   LocalKeyword v122; // [rsp+F8h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D9197C9 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D9197C9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4494, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4494, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//       return;
			//     }
			// LABEL_67:
			//     sub_180B536AC(volumetricParameters, v5);
			//   }
			//   context = inputs.context;
			//   if ( !context )
			//     goto LABEL_67;
			//   volumetricParameters = inputs.volumetricParameters;
			//   cmd = context.fields.cmd;
			//   if ( !volumetricParameters )
			//     goto LABEL_67;
			//   v9 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//          volumetricParameters.fields.enableDownRes,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   m_VolumetricMat = this.fields.m_VolumetricMat;
			//   v12 = (HGVolumetricCloudSettingParameters *)m_VolumetricMat;
			//   if ( !v9 )
			//   {
			//     if ( !m_VolumetricMat )
			//       goto LABEL_65;
			//     shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     s_EnableDownscale = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableDownscale;
			//     memset(&v118, 0, sizeof(v118));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, shader, s_EnableDownscale, 0LL);
			//     keyword_8 = v118;
			//     if ( !cmd )
			//       goto LABEL_65;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, m_VolumetricMat, &keyword_8, 0LL);
			//     v94 = this.fields.m_VolumetricMat;
			//     v12 = (HGVolumetricCloudSettingParameters *)v94;
			//     if ( !v94 )
			//       goto LABEL_65;
			//     v95 = UnityEngine::Material::get_shader(v94, 0LL);
			//     s_DownscaleTriple = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleTriple;
			//     memset(&v117, 0, sizeof(v117));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v95, s_DownscaleTriple, 0LL);
			//     keyword_8 = v117;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v94, &keyword_8, 0LL);
			//     v97 = this.fields.m_VolumetricMat;
			//     v12 = (HGVolumetricCloudSettingParameters *)v97;
			//     if ( !v97 )
			//       goto LABEL_65;
			//     v98 = UnityEngine::Material::get_shader(v97, 0LL);
			//     s_DownscaleQuarter = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleQuarter;
			//     memset(&v116, 0, sizeof(v116));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v98, s_DownscaleQuarter, 0LL);
			//     keyword_8 = v116;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v97, &keyword_8, 0LL);
			//     v100 = this.fields.m_VolumetricMat;
			//     v12 = (HGVolumetricCloudSettingParameters *)v100;
			//     if ( !v100 )
			//       goto LABEL_65;
			//     v101 = UnityEngine::Material::get_shader(v100, 0LL);
			//     s_UpscaleBilateral = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleBilateral;
			//     memset(&v119, 0, sizeof(v119));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v119, v101, s_UpscaleBilateral, 0LL);
			//     keyword_8 = v119;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v100, &keyword_8, 0LL);
			//     v103 = this.fields.m_VolumetricMat;
			//     v12 = (HGVolumetricCloudSettingParameters *)v103;
			//     if ( !v103 )
			//       goto LABEL_65;
			//     v104 = UnityEngine::Material::get_shader(v103, 0LL);
			//     s_UpscaleNearest = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNearest;
			//     memset(&v120, 0, sizeof(v120));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v120, v104, s_UpscaleNearest, 0LL);
			//     keyword_8 = v120;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v103, &keyword_8, 0LL);
			//     v106 = this.fields.m_VolumetricMat;
			//     v12 = (HGVolumetricCloudSettingParameters *)v106;
			//     if ( !v106 )
			//       goto LABEL_65;
			//     v107 = UnityEngine::Material::get_shader(v106, 0LL);
			//     s_UpscaleNoisy = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNoisy;
			//     memset(&v121, 0, sizeof(v121));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v121, v107, s_UpscaleNoisy, 0LL);
			//     keyword_8 = v121;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v106, &keyword_8, 0LL);
			//     v109 = this.fields.m_VolumetricMat;
			//     v12 = (HGVolumetricCloudSettingParameters *)v109;
			//     if ( !v109 )
			// LABEL_65:
			//       sub_180B536AC(v12, v10);
			//     v110 = UnityEngine::Material::get_shader(v109, 0LL);
			//     s_EnableMinMaxDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableMinMaxDepth;
			//     memset(&v122, 0, sizeof(v122));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v122, v110, s_EnableMinMaxDepth, 0LL);
			//     keyword_8 = v122;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v109, &keyword_8, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     *(_OWORD *)&v115.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)sub_1825A3980(
			//                                                                &v115,
			//                                                                _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v112, (Vector4 *)&v115, 0LL);
			//     return;
			//   }
			//   if ( !m_VolumetricMat )
			//     goto LABEL_55;
			//   v13 = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//   v14 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableDownscale;
			//   memset(&v115, 0, sizeof(v115));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v13, v14, 0LL);
			//   keyword_8 = v115;
			//   v15 = *(__m128 *)&v115.m_SpaceInfo.m_KeywordSpace;
			//   if ( !cmd
			//     || (UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, m_VolumetricMat, &keyword_8, 0LL),
			//         (v12 = inputs.volumetricParameters) == 0LL) )
			//   {
			// LABEL_55:
			//     sub_180B536AC(v12, v10);
			//   }
			//   v15.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                       v12.fields.downResRatio,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v16 = v15;
			//   v17 = sub_1826E82D0();
			//   if ( v17 == 2 )
			//   {
			//     v31 = this.fields.m_VolumetricMat;
			//     v27 = v31;
			//     if ( !v31 )
			//       goto LABEL_54;
			//     v32 = UnityEngine::Material::get_shader(v31, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v33 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleTriple;
			//     memset(&v116, 0, sizeof(v116));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v32, v33, 0LL);
			//     keyword_8 = v116;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v31, &keyword_8, 0LL);
			//     v30 = this.fields.m_VolumetricMat;
			//     v27 = v30;
			//     if ( !v30 )
			// LABEL_54:
			//       sub_180B536AC(v27, v18);
			//   }
			//   else
			//   {
			//     if ( v17 != 3 )
			//     {
			//       if ( v17 == 4 )
			//       {
			//         v19 = this.fields.m_VolumetricMat;
			//         v20 = v19;
			//         if ( !v19 )
			//           goto LABEL_16;
			//         v21 = UnityEngine::Material::get_shader(v19, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         v22 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleTriple;
			//         memset(&v115, 0, sizeof(v115));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v21, v22, 0LL);
			//         keyword_8 = v115;
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v19, &keyword_8, 0LL);
			//         v23 = this.fields.m_VolumetricMat;
			//         v20 = v23;
			//         if ( !v23 )
			// LABEL_16:
			//           sub_180B536AC(v20, v18);
			//         v24 = UnityEngine::Material::get_shader(v23, 0LL);
			//         v25 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleQuarter;
			//         memset(&v116, 0, sizeof(v116));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v24, v25, 0LL);
			//         keyword_8 = v116;
			//         UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v23, &keyword_8, 0LL);
			//       }
			//       goto LABEL_23;
			//     }
			//     v26 = this.fields.m_VolumetricMat;
			//     v27 = v26;
			//     if ( !v26 )
			//       goto LABEL_19;
			//     v28 = UnityEngine::Material::get_shader(v26, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v29 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleTriple;
			//     memset(&v116, 0, sizeof(v116));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v28, v29, 0LL);
			//     keyword_8 = v116;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v26, &keyword_8, 0LL);
			//     v30 = this.fields.m_VolumetricMat;
			//     v27 = v30;
			//     if ( !v30 )
			// LABEL_19:
			//       sub_180B536AC(v27, v18);
			//   }
			//   v34 = UnityEngine::Material::get_shader(v27, 0LL);
			//   v35 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DownscaleQuarter;
			//   memset(&v115, 0, sizeof(v115));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v34, v35, 0LL);
			//   keyword_8 = v115;
			//   UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v30, &keyword_8, 0LL);
			// LABEL_23:
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   v36 = (__m128)0x3F800000u;
			//   v36.m128_f32[0] = 1.0 / v16.m128_f32[0];
			//   *(_OWORD *)&v115.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)sub_1825A3980(&v115, _mm_unpacklo_ps(v16, v36).m128_u64[0]);
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v37, (Vector4 *)&v115, 0LL);
			//   downResFilter = inputs.volumetricParameters;
			//   if ( !downResFilter
			//     || (downResFilter = (HGVolumetricCloudSettingParameters *)downResFilter.fields.downResFilter) == 0LL )
			//   {
			//     sub_180B536AC(downResFilter, v38);
			//   }
			//   enableFraming = (int)downResFilter.fields.enableFraming;
			//   if ( enableFraming )
			//   {
			//     v41 = enableFraming - 1;
			//     if ( v41 )
			//     {
			//       v42 = v41 - 1;
			//       if ( v42 )
			//       {
			//         if ( v42 != 1 )
			//           return;
			//         v43 = this.fields.m_VolumetricMat;
			//         v44 = v43;
			//         if ( !v43 )
			//           goto LABEL_34;
			//         v45 = UnityEngine::Material::get_shader(v43, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         v46 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleBilateral;
			//         memset(&v116, 0, sizeof(v116));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v45, v46, 0LL);
			//         keyword_8 = v116;
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v43, &keyword_8, 0LL);
			//         v47 = this.fields.m_VolumetricMat;
			//         v44 = v47;
			//         if ( !v47 )
			//           goto LABEL_34;
			//         v48 = UnityEngine::Material::get_shader(v47, 0LL);
			//         v49 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNearest;
			//         memset(&v115, 0, sizeof(v115));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v48, v49, 0LL);
			//         keyword_8 = v115;
			//         UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v47, &keyword_8, 0LL);
			//         v50 = this.fields.m_VolumetricMat;
			//         v44 = v50;
			//         if ( !v50 )
			//           goto LABEL_34;
			//         v51 = UnityEngine::Material::get_shader(v50, 0LL);
			//         v52 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNoisy;
			//         memset(&v117, 0, sizeof(v117));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v51, v52, 0LL);
			//         keyword_8 = v117;
			//         UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v50, &keyword_8, 0LL);
			//         v53 = this.fields.m_VolumetricMat;
			//         v44 = v53;
			//         if ( !v53 )
			// LABEL_34:
			//           sub_180B536AC(v44, v38);
			//         v54 = UnityEngine::Material::get_shader(v53, 0LL);
			//         v55 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableMinMaxDepth;
			//         memset(&v118, 0, sizeof(v118));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v54, v55, 0LL);
			//         v56 = *(_OWORD *)&v118.m_SpaceInfo.m_KeywordSpace;
			//         v57 = *(_QWORD *)&v118.m_Index;
			//         goto LABEL_45;
			//       }
			//       v58 = this.fields.m_VolumetricMat;
			//       v59 = v58;
			//       if ( !v58 )
			//         goto LABEL_39;
			//       v60 = UnityEngine::Material::get_shader(v58, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//       v61 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleBilateral;
			//       memset(&v118, 0, sizeof(v118));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v60, v61, 0LL);
			//       keyword_8 = v118;
			//       UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v58, &keyword_8, 0LL);
			//       v62 = this.fields.m_VolumetricMat;
			//       v59 = v62;
			//       if ( !v62 )
			//         goto LABEL_39;
			//       v63 = UnityEngine::Material::get_shader(v62, 0LL);
			//       v64 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNearest;
			//       memset(&v117, 0, sizeof(v117));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v63, v64, 0LL);
			//       keyword_8 = v117;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v62, &keyword_8, 0LL);
			//       v65 = this.fields.m_VolumetricMat;
			//       v59 = v65;
			//       if ( !v65 )
			//         goto LABEL_39;
			//       v66 = UnityEngine::Material::get_shader(v65, 0LL);
			//       v67 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNoisy;
			//       memset(&v116, 0, sizeof(v116));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v66, v67, 0LL);
			//       keyword_8 = v116;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v65, &keyword_8, 0LL);
			//       v53 = this.fields.m_VolumetricMat;
			//       v59 = v53;
			//       if ( !v53 )
			// LABEL_39:
			//         sub_180B536AC(v59, v38);
			//     }
			//     else
			//     {
			//       v68 = this.fields.m_VolumetricMat;
			//       v59 = v68;
			//       if ( !v68 )
			//         goto LABEL_46;
			//       v69 = UnityEngine::Material::get_shader(v68, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//       v70 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleBilateral;
			//       memset(&v118, 0, sizeof(v118));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v69, v70, 0LL);
			//       keyword_8 = v118;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v68, &keyword_8, 0LL);
			//       v71 = this.fields.m_VolumetricMat;
			//       v59 = v71;
			//       if ( !v71 )
			//         goto LABEL_46;
			//       v72 = UnityEngine::Material::get_shader(v71, 0LL);
			//       v73 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNearest;
			//       memset(&v117, 0, sizeof(v117));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v72, v73, 0LL);
			//       keyword_8 = v117;
			//       UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v71, &keyword_8, 0LL);
			//       v74 = this.fields.m_VolumetricMat;
			//       v59 = v74;
			//       if ( !v74 )
			//         goto LABEL_46;
			//       v75 = UnityEngine::Material::get_shader(v74, 0LL);
			//       v76 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNoisy;
			//       memset(&v116, 0, sizeof(v116));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v75, v76, 0LL);
			//       keyword_8 = v116;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v74, &keyword_8, 0LL);
			//       v53 = this.fields.m_VolumetricMat;
			//       v59 = v53;
			//       if ( !v53 )
			// LABEL_46:
			//         sub_180B536AC(v59, v38);
			//     }
			//     v77 = UnityEngine::Material::get_shader(v59, 0LL);
			//     v78 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableMinMaxDepth;
			//     memset(&v115, 0, sizeof(v115));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v77, v78, 0LL);
			//     v56 = *(_OWORD *)&v115.m_SpaceInfo.m_KeywordSpace;
			//     v57 = *(_QWORD *)&v115.m_Index;
			// LABEL_45:
			//     *(_QWORD *)&keyword_8.m_Index = v57;
			//     *(_OWORD *)&keyword_8.m_SpaceInfo.m_KeywordSpace = v56;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v53, &keyword_8, 0LL);
			//     return;
			//   }
			//   v79 = this.fields.m_VolumetricMat;
			//   v80 = v79;
			//   if ( !v79 )
			//     goto LABEL_52;
			//   v81 = UnityEngine::Material::get_shader(v79, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//   v82 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleBilateral;
			//   memset(&v118, 0, sizeof(v118));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v81, v82, 0LL);
			//   keyword_8 = v118;
			//   UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v79, &keyword_8, 0LL);
			//   v83 = this.fields.m_VolumetricMat;
			//   v80 = v83;
			//   if ( !v83 )
			//     goto LABEL_52;
			//   v84 = UnityEngine::Material::get_shader(v83, 0LL);
			//   v85 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNearest;
			//   memset(&v117, 0, sizeof(v117));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v84, v85, 0LL);
			//   keyword_8 = v117;
			//   UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v83, &keyword_8, 0LL);
			//   v86 = this.fields.m_VolumetricMat;
			//   v80 = v86;
			//   if ( !v86 )
			//     goto LABEL_52;
			//   v87 = UnityEngine::Material::get_shader(v86, 0LL);
			//   v88 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_UpscaleNoisy;
			//   memset(&v116, 0, sizeof(v116));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v87, v88, 0LL);
			//   keyword_8 = v116;
			//   UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v86, &keyword_8, 0LL);
			//   v89 = this.fields.m_VolumetricMat;
			//   v80 = v89;
			//   if ( !v89 )
			// LABEL_52:
			//     sub_180B536AC(v80, v38);
			//   v90 = UnityEngine::Material::get_shader(v89, 0LL);
			//   v91 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableMinMaxDepth;
			//   memset(&v115, 0, sizeof(v115));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v90, v91, 0LL);
			//   keyword_8 = v115;
			//   UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v89, &keyword_8, 0LL);
			// }
			// 
		}

		private void UpdateFramingRender(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateFramingRender(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateFramingRender(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   VolumetricShaderIDs__StaticFields *v5; // rdx
			//   void *static_fields; // rcx
			//   HGRenderGraphContext *context; // rsi
			//   CommandBuffer *cmd; // rsi
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // rax
			//   int v10; // r8d
			//   Material *v11; // rbx
			//   VolumetricShaderIDs__StaticFields *v12; // rax
			//   int32_t PixelSubOffset; // ebx
			//   int32_t Int; // eax
			//   bool v15; // al
			//   __int64 v16; // rdx
			//   Material *v17; // r15
			//   Shader *v18; // rbx
			//   String *v19; // r8
			//   Shader *v20; // rbx
			//   String *v21; // r8
			//   bool v22; // al
			//   __int64 v23; // rdx
			//   Material *v24; // r15
			//   Shader *v25; // rbx
			//   String *v26; // r8
			//   Shader *v27; // rbx
			//   String *v28; // r8
			//   bool v29; // al
			//   __int64 v30; // rdx
			//   Material *v31; // r15
			//   Shader *v32; // rbx
			//   String *v33; // r8
			//   Shader *v34; // rbx
			//   String *v35; // r8
			//   bool v36; // al
			//   __int64 v37; // rdx
			//   Material *v38; // r14
			//   Shader *v39; // rbx
			//   String *v40; // r8
			//   __int128 v41; // xmm0
			//   Material *v42; // rdx
			//   __int64 v43; // xmm1_8
			//   Shader *v44; // rbx
			//   String *v45; // r8
			//   Material *m_VolumetricMat; // r14
			//   Material *v47; // rcx
			//   Shader *shader; // rbx
			//   String *s_ReconstructEnableMotionVector; // r8
			//   Material *v50; // rbx
			//   Shader *v51; // rax
			//   String *s_ReconstructEnableDepthOpt; // r8
			//   Material *v53; // rbx
			//   Shader *v54; // rax
			//   String *s_ReconstructEnableColorAABB; // r8
			//   Material *v56; // rbx
			//   Shader *v57; // rax
			//   String *s_ReconstructEnableNeighborAvg; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LocalKeyword v60; // [rsp+28h] [rbp-39h] BYREF
			//   LocalKeyword keyword; // [rsp+40h] [rbp-21h] BYREF
			//   LocalKeyword v62; // [rsp+58h] [rbp-9h] BYREF
			//   LocalKeyword v63; // [rsp+70h] [rbp+Fh] BYREF
			//   LocalKeyword v64; // [rsp+88h] [rbp+27h] BYREF
			// 
			//   if ( !byte_18D9197CA )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFramingQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D9197CA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4492, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4492, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//       return;
			//     }
			//     goto LABEL_58;
			//   }
			//   context = inputs.context;
			//   if ( !context )
			//     goto LABEL_58;
			//   cmd = context.fields.cmd;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !cmd )
			//     goto LABEL_58;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
			//     cmd,
			//     *((_DWORD *)static_fields + 262),
			//     this.fields._DrawFrameCount_k__BackingField % 8,
			//     0LL);
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
			//     cmd,
			//     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FrameCountMod16,
			//     this.fields._DrawFrameCount_k__BackingField % 16,
			//     0LL);
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
			//     cmd,
			//     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FrameCountMod32,
			//     this.fields._DrawFrameCount_k__BackingField % 32,
			//     0LL);
			//   if ( !this.fields.m_EnableFraming )
			//   {
			//     m_VolumetricMat = this.fields.m_VolumetricMat;
			//     v47 = m_VolumetricMat;
			//     if ( !m_VolumetricMat )
			//       goto LABEL_56;
			//     shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     s_ReconstructEnableMotionVector = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableMotionVector;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, shader, s_ReconstructEnableMotionVector, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, m_VolumetricMat, &keyword, 0LL);
			//     v50 = this.fields.m_VolumetricMat;
			//     v47 = v50;
			//     if ( !v50 )
			//       goto LABEL_56;
			//     v51 = UnityEngine::Material::get_shader(v50, 0LL);
			//     s_ReconstructEnableDepthOpt = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableDepthOpt;
			//     memset(&v62, 0, sizeof(v62));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v62, v51, s_ReconstructEnableDepthOpt, 0LL);
			//     keyword = v62;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v50, &keyword, 0LL);
			//     v53 = this.fields.m_VolumetricMat;
			//     v47 = v53;
			//     if ( !v53 )
			//       goto LABEL_56;
			//     v54 = UnityEngine::Material::get_shader(v53, 0LL);
			//     s_ReconstructEnableColorAABB = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableColorAABB;
			//     memset(&v63, 0, sizeof(v63));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v63, v54, s_ReconstructEnableColorAABB, 0LL);
			//     keyword = v63;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v53, &keyword, 0LL);
			//     v56 = this.fields.m_VolumetricMat;
			//     v47 = v56;
			//     if ( !v56 )
			// LABEL_56:
			//       sub_180B536AC(v47, v5);
			//     v57 = UnityEngine::Material::get_shader(v56, 0LL);
			//     s_ReconstructEnableNeighborAvg = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableNeighborAvg;
			//     memset(&v64, 0, sizeof(v64));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v64, v57, s_ReconstructEnableNeighborAvg, 0LL);
			//     v41 = *(_OWORD *)&v64.m_SpaceInfo.m_KeywordSpace;
			//     v42 = v56;
			//     v43 = *(_QWORD *)&v64.m_Index;
			//     goto LABEL_55;
			//   }
			//   volumetricParameters = inputs.volumetricParameters;
			//   if ( !volumetricParameters )
			//     goto LABEL_58;
			//   static_fields = volumetricParameters.fields.framingLevel;
			//   if ( !static_fields )
			//     goto LABEL_58;
			//   if ( *((_DWORD *)static_fields + 10) )
			//   {
			//     if ( *((_DWORD *)static_fields + 10) != 1 )
			//       goto LABEL_14;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     v10 = 4;
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     v10 = 2;
			//   }
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
			//     cmd,
			//     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PixelSubOffset,
			//     this.fields._DrawFrameCount_k__BackingField % v10,
			//     0LL);
			// LABEL_14:
			//   v11 = this.fields.m_VolumetricMat;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   v5 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !v11 )
			//     goto LABEL_58;
			//   if ( UnityEngine::Material::GetInt(v11, v5._DebugPixelOffset, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     static_fields = this.fields.m_VolumetricMat;
			//     v12 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     PixelSubOffset = v12._PixelSubOffset;
			//     if ( !static_fields )
			//       goto LABEL_58;
			//     Int = UnityEngine::Material::GetInt((Material *)static_fields, v12._PixelOffsetTest, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, PixelSubOffset, Int, 0LL);
			//   }
			//   static_fields = inputs.volumetricParameters;
			//   if ( !static_fields )
			//     goto LABEL_58;
			//   v15 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           *((SettingParameter_1_System_Boolean_ **)static_fields + 9),
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v17 = this.fields.m_VolumetricMat;
			//   if ( v15 )
			//   {
			//     if ( !v17 )
			//       sub_180B536AC(0LL, v16);
			//     v20 = UnityEngine::Material::get_shader(v17, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v21 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableMotionVector;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v20, v21, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v17, &keyword, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v17 )
			//       sub_180B536AC(0LL, v16);
			//     v18 = UnityEngine::Material::get_shader(v17, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v19 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableMotionVector;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v18, v19, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v17, &keyword, 0LL);
			//   }
			//   static_fields = inputs.volumetricParameters;
			//   if ( !static_fields )
			//     goto LABEL_58;
			//   v22 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           *((SettingParameter_1_System_Boolean_ **)static_fields + 10),
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v24 = this.fields.m_VolumetricMat;
			//   if ( v22 )
			//   {
			//     if ( !v24 )
			//       sub_180B536AC(0LL, v23);
			//     v27 = UnityEngine::Material::get_shader(v24, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v28 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableDepthOpt;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v27, v28, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v24, &keyword, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v24 )
			//       sub_180B536AC(0LL, v23);
			//     v25 = UnityEngine::Material::get_shader(v24, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v26 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableDepthOpt;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v25, v26, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v24, &keyword, 0LL);
			//   }
			//   static_fields = inputs.volumetricParameters;
			//   if ( !static_fields )
			//     goto LABEL_58;
			//   v29 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           *((SettingParameter_1_System_Boolean_ **)static_fields + 11),
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v31 = this.fields.m_VolumetricMat;
			//   if ( v29 )
			//   {
			//     if ( !v31 )
			//       sub_180B536AC(0LL, v30);
			//     v34 = UnityEngine::Material::get_shader(v31, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v35 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableColorAABB;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v34, v35, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v31, &keyword, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v31 )
			//       sub_180B536AC(0LL, v30);
			//     v32 = UnityEngine::Material::get_shader(v31, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v33 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableColorAABB;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v32, v33, 0LL);
			//     keyword = v60;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v31, &keyword, 0LL);
			//   }
			//   static_fields = inputs.volumetricParameters;
			//   if ( !static_fields )
			// LABEL_58:
			//     sub_180B536AC(static_fields, v5);
			//   v36 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           *((SettingParameter_1_System_Boolean_ **)static_fields + 12),
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v38 = this.fields.m_VolumetricMat;
			//   if ( !v36 )
			//   {
			//     if ( !v38 )
			//       sub_180B536AC(0LL, v37);
			//     v39 = UnityEngine::Material::get_shader(v38, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v40 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableNeighborAvg;
			//     memset(&v60, 0, sizeof(v60));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v39, v40, 0LL);
			//     v41 = *(_OWORD *)&v60.m_SpaceInfo.m_KeywordSpace;
			//     v42 = v38;
			//     v43 = *(_QWORD *)&v60.m_Index;
			// LABEL_55:
			//     *(_QWORD *)&keyword.m_Index = v43;
			//     *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v41;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v42, &keyword, 0LL);
			//     return;
			//   }
			//   if ( !v38 )
			//     sub_180B536AC(0LL, v37);
			//   v44 = UnityEngine::Material::get_shader(v38, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//   v45 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_ReconstructEnableNeighborAvg;
			//   memset(&v60, 0, sizeof(v60));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v44, v45, 0LL);
			//   keyword = v60;
			//   UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v38, &keyword, 0LL);
			// }
			// 
		}

		private void UpdateTAARender(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateTAARender(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateTAARender(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
			//   HGRenderGraphContext *context; // rsi
			//   CommandBuffer *cmd; // rsi
			//   bool v9; // al
			//   __int64 v10; // rdx
			//   Material *v11; // r15
			//   Material *v12; // rcx
			//   Shader *v13; // rbx
			//   String *v14; // r8
			//   Shader *v15; // rbx
			//   String *v16; // r8
			//   bool v17; // al
			//   __int64 v18; // rdx
			//   Material *v19; // r15
			//   Shader *v20; // rbx
			//   String *v21; // r8
			//   Shader *v22; // rbx
			//   String *v23; // r8
			//   bool v24; // al
			//   __int64 v25; // rdx
			//   Material *v26; // r15
			//   Shader *v27; // rbx
			//   String *v28; // r8
			//   Shader *v29; // rbx
			//   String *v30; // r8
			//   bool v31; // al
			//   __int64 v32; // rdx
			//   Material *v33; // r14
			//   Shader *v34; // rbx
			//   String *v35; // r8
			//   __int128 v36; // xmm0
			//   Material *v37; // rdx
			//   __int64 v38; // xmm1_8
			//   Shader *v39; // rbx
			//   String *v40; // r8
			//   Material *m_VolumetricMat; // r14
			//   Material *v42; // rcx
			//   Shader *shader; // rbx
			//   String *s_TAAEnableMotionVector; // r8
			//   Material *v45; // rbx
			//   Shader *v46; // rax
			//   String *s_TAAEnableDepthOpt; // r8
			//   Material *v48; // rbx
			//   Shader *v49; // rax
			//   String *s_TAAEnableColorAABB; // r8
			//   Material *v51; // rbx
			//   Shader *v52; // rax
			//   String *s_TAAEnableNeighborAvg; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LocalKeyword v55; // [rsp+28h] [rbp-39h] BYREF
			//   LocalKeyword keyword; // [rsp+40h] [rbp-21h] BYREF
			//   LocalKeyword v57; // [rsp+58h] [rbp-9h] BYREF
			//   LocalKeyword v58; // [rsp+70h] [rbp+Fh] BYREF
			//   LocalKeyword v59; // [rsp+88h] [rbp+27h] BYREF
			// 
			//   if ( !byte_18D9197CB )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D9197CB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4493, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4493, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//       return;
			//     }
			// LABEL_49:
			//     sub_180B536AC(volumetricParameters, v5);
			//   }
			//   context = inputs.context;
			//   if ( !context )
			//     goto LABEL_49;
			//   cmd = context.fields.cmd;
			//   if ( !this.fields.m_EnableTAA )
			//   {
			//     m_VolumetricMat = this.fields.m_VolumetricMat;
			//     v42 = m_VolumetricMat;
			//     if ( !m_VolumetricMat )
			//       goto LABEL_47;
			//     shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     s_TAAEnableMotionVector = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableMotionVector;
			//     memset(&v55, 0, sizeof(v55));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, shader, s_TAAEnableMotionVector, 0LL);
			//     keyword = v55;
			//     if ( !cmd )
			//       goto LABEL_47;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, m_VolumetricMat, &keyword, 0LL);
			//     v45 = this.fields.m_VolumetricMat;
			//     v42 = v45;
			//     if ( !v45 )
			//       goto LABEL_47;
			//     v46 = UnityEngine::Material::get_shader(v45, 0LL);
			//     s_TAAEnableDepthOpt = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableDepthOpt;
			//     memset(&v57, 0, sizeof(v57));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v57, v46, s_TAAEnableDepthOpt, 0LL);
			//     keyword = v57;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v45, &keyword, 0LL);
			//     v48 = this.fields.m_VolumetricMat;
			//     v42 = v48;
			//     if ( !v48 )
			//       goto LABEL_47;
			//     v49 = UnityEngine::Material::get_shader(v48, 0LL);
			//     s_TAAEnableColorAABB = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableColorAABB;
			//     memset(&v58, 0, sizeof(v58));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v58, v49, s_TAAEnableColorAABB, 0LL);
			//     keyword = v58;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v48, &keyword, 0LL);
			//     v51 = this.fields.m_VolumetricMat;
			//     v42 = v51;
			//     if ( !v51 )
			// LABEL_47:
			//       sub_180B536AC(v42, v5);
			//     v52 = UnityEngine::Material::get_shader(v51, 0LL);
			//     s_TAAEnableNeighborAvg = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableNeighborAvg;
			//     memset(&v59, 0, sizeof(v59));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v59, v52, s_TAAEnableNeighborAvg, 0LL);
			//     v36 = *(_OWORD *)&v59.m_SpaceInfo.m_KeywordSpace;
			//     v37 = v51;
			//     v38 = *(_QWORD *)&v59.m_Index;
			//     goto LABEL_46;
			//   }
			//   volumetricParameters = inputs.volumetricParameters;
			//   if ( !volumetricParameters )
			//     goto LABEL_49;
			//   v9 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//          volumetricParameters.fields.enableTAAMotionVector,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v11 = this.fields.m_VolumetricMat;
			//   v12 = v11;
			//   if ( v9 )
			//   {
			//     if ( !v11
			//       || (v15 = UnityEngine::Material::get_shader(v11, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//           v16 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableMotionVector,
			//           memset(&v55, 0, sizeof(v55)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v15, v16, 0LL),
			//           keyword = v55,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v12, v10);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v11, &keyword, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v11
			//       || (v13 = UnityEngine::Material::get_shader(v11, 0LL),
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			//           v14 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableMotionVector,
			//           memset(&v55, 0, sizeof(v55)),
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v13, v14, 0LL),
			//           keyword = v55,
			//           !cmd) )
			//     {
			//       sub_180B536AC(v12, v10);
			//     }
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v11, &keyword, 0LL);
			//   }
			//   volumetricParameters = inputs.volumetricParameters;
			//   if ( !volumetricParameters )
			//     goto LABEL_49;
			//   v17 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           volumetricParameters.fields.enableTAADepthOpt,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v19 = this.fields.m_VolumetricMat;
			//   if ( v17 )
			//   {
			//     if ( !v19 )
			//       sub_180B536AC(0LL, v18);
			//     v22 = UnityEngine::Material::get_shader(v19, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v23 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableDepthOpt;
			//     memset(&v55, 0, sizeof(v55));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v22, v23, 0LL);
			//     keyword = v55;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v19, &keyword, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v19 )
			//       sub_180B536AC(0LL, v18);
			//     v20 = UnityEngine::Material::get_shader(v19, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v21 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableDepthOpt;
			//     memset(&v55, 0, sizeof(v55));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v20, v21, 0LL);
			//     keyword = v55;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v19, &keyword, 0LL);
			//   }
			//   volumetricParameters = inputs.volumetricParameters;
			//   if ( !volumetricParameters )
			//     goto LABEL_49;
			//   v24 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           volumetricParameters.fields.enableTAAColorAABB,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v26 = this.fields.m_VolumetricMat;
			//   if ( v24 )
			//   {
			//     if ( !v26 )
			//       sub_180B536AC(0LL, v25);
			//     v29 = UnityEngine::Material::get_shader(v26, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v30 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableColorAABB;
			//     memset(&v55, 0, sizeof(v55));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v29, v30, 0LL);
			//     keyword = v55;
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v26, &keyword, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v26 )
			//       sub_180B536AC(0LL, v25);
			//     v27 = UnityEngine::Material::get_shader(v26, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v28 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableColorAABB;
			//     memset(&v55, 0, sizeof(v55));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v27, v28, 0LL);
			//     keyword = v55;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v26, &keyword, 0LL);
			//   }
			//   volumetricParameters = inputs.volumetricParameters;
			//   if ( !volumetricParameters )
			//     goto LABEL_49;
			//   v31 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           volumetricParameters.fields.enableTAANeighborAvg,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v33 = this.fields.m_VolumetricMat;
			//   if ( !v31 )
			//   {
			//     if ( !v33 )
			//       sub_180B536AC(0LL, v32);
			//     v34 = UnityEngine::Material::get_shader(v33, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     v35 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableNeighborAvg;
			//     memset(&v55, 0, sizeof(v55));
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v34, v35, 0LL);
			//     v36 = *(_OWORD *)&v55.m_SpaceInfo.m_KeywordSpace;
			//     v37 = v33;
			//     v38 = *(_QWORD *)&v55.m_Index;
			// LABEL_46:
			//     *(_QWORD *)&keyword.m_Index = v38;
			//     *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v36;
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v37, &keyword, 0LL);
			//     return;
			//   }
			//   if ( !v33 )
			//     sub_180B536AC(0LL, v32);
			//   v39 = UnityEngine::Material::get_shader(v33, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//   v40 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_TAAEnableNeighborAvg;
			//   memset(&v55, 0, sizeof(v55));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v39, v40, 0LL);
			//   keyword = v55;
			//   UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v33, &keyword, 0LL);
			// }
			// 
		}

		private void GetVolumetricRenderRTSize(ref VolumetricRenderInputs inputs)
		{
			// // Void GetVolumetricRenderRTSize(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::GetVolumetricRenderRTSize(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
			//   HGCamera *hgCamera; // rsi
			//   int32_t m_X; // ebp
			//   __int64 v9; // rsi
			//   float v10; // xmm6_4
			//   int32_t v11; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v13; // [rsp+20h] [rbp-28h]
			// 
			//   if ( !byte_18D9197CC )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D9197CC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4495, 0LL) )
			//   {
			//     hgCamera = inputs.hgCamera;
			//     this.fields.m_RenderWidth = 0;
			//     this.fields.m_RenderHeight = 0;
			//     if ( hgCamera )
			//     {
			//       m_X = hgCamera.fields._sceneRTSize_k__BackingField.m_X;
			//       v9 = HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField);
			//       this.fields.m_RenderHeight = v9;
			//       this.fields.m_RenderWidth = m_X;
			//       this.fields.m_NDCRescaleParams.x = 1.0;
			//       this.fields.m_NDCRescaleParams.y = 1.0;
			//       volumetricParameters = inputs.volumetricParameters;
			//       if ( volumetricParameters )
			//       {
			//         if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                 volumetricParameters.fields.enableDownRes,
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//         {
			// LABEL_9:
			//           v13.x = (float)(1.0 / (float)this.fields.m_RenderWidth) * (float)m_X;
			//           v13.y = (float)(1.0 / (float)this.fields.m_RenderHeight) * (float)(int)v9;
			//           v13.z = 1.0 / (float)m_X;
			//           v13.w = 1.0 / (float)(int)v9;
			//           this.fields.m_DownscaledScreenParams = v13;
			//           return;
			//         }
			//         volumetricParameters = inputs.volumetricParameters;
			//         if ( volumetricParameters )
			//         {
			//           v10 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                   volumetricParameters.fields.downResRatio,
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//           this.fields.m_RenderWidth = sub_1826E82D0();
			//           v11 = sub_1826E82D0();
			//           this.fields.m_RenderHeight = v11;
			//           this.fields.m_NDCRescaleParams.x = (float)((float)this.fields.m_RenderWidth * v10) / (float)m_X;
			//           this.fields.m_NDCRescaleParams.y = (float)((float)v11 * v10) / (float)(int)v9;
			//           goto LABEL_9;
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(volumetricParameters, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4495, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			// }
			// 
		}

		private void UpdateVolumetricRTs(ref VolumetricRenderInputs inputs)
		{
			// // Void UpdateVolumetricRTs(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRTs(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *m_TAADepths; // rcx
			//   HGRenderGraphContext *context; // rax
			//   CommandBuffer *cmd; // r13
			//   int i; // r14d
			//   VolumetricPipelineRT__Array *m_TAAColors; // r12
			//   int32_t m_RenderWidth; // edi
			//   int32_t m_RenderHeight; // ebx
			//   VolumetricPipelineRT **v13; // rax
			//   int32_t v14; // edi
			//   int32_t v15; // ebx
			//   VolumetricPipelineRT **v16; // rax
			//   Texture *RT; // rbx
			//   bool v18; // al
			//   VolumetricPipelineRT__Array *m_ReconstructColors; // r12
			//   int32_t v20; // edi
			//   int32_t v21; // ebx
			//   VolumetricPipelineRT **v22; // rax
			//   int32_t v23; // edi
			//   int32_t v24; // ebx
			//   VolumetricPipelineRT **v25; // rax
			//   Texture *v26; // rbx
			//   bool v27; // al
			//   VolumetricPipelineRT__Array *m_MinMaxWorldDepths; // r12
			//   int32_t v29; // edi
			//   int32_t v30; // ebx
			//   VolumetricPipelineRT **v31; // rax
			//   int32_t v32; // edi
			//   int32_t v33; // ebx
			//   HGVolumetricCloudSettingParameters *volumetricParameters; // rax
			//   int32_t m_FramingWidth; // edi
			//   int32_t m_FramingHeight; // ebx
			//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
			//   __int64 RTRes; // rdx
			//   int32_t FramingRes; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v41; // [rsp+40h] [rbp-40h]
			//   Vector4 value; // [rsp+50h] [rbp-30h] BYREF
			//   Vector4 v43; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D9197CD )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFramingQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&off_18D521BE0);
			//     sub_18003C530(&off_18D521BA8);
			//     sub_18003C530(&off_18D521BB8);
			//     sub_18003C530(&off_18D521BC8);
			//     sub_18003C530(&off_18D521BD8);
			//     sub_18003C530(&off_18D521C10);
			//     sub_18003C530(&off_18D521C18);
			//     sub_18003C530(&off_18D521C20);
			//     sub_18003C530(&off_18D521C30);
			//     sub_18003C530(&off_18D521BF0);
			//     byte_18D9197CD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4496, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4496, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			//       return;
			//     }
			//     goto LABEL_40;
			//   }
			//   context = inputs.context;
			//   if ( !context )
			//     goto LABEL_40;
			//   cmd = context.fields.cmd;
			//   for ( i = 0; i < 2; ++i )
			//   {
			//     m_TAAColors = this.fields.m_TAAColors;
			//     if ( !m_TAAColors )
			//       goto LABEL_40;
			//     m_RenderWidth = this.fields.m_RenderWidth;
			//     m_RenderHeight = this.fields.m_RenderHeight;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     v13 = (VolumetricPipelineRT **)sub_180002B90(m_TAAColors, i);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//       (String *)"m_TAAColors",
			//       v13,
			//       m_RenderWidth,
			//       m_RenderHeight,
			//       RTLifeCycle__Enum_Persist,
			//       RenderTextureFormat__Enum_ARGBHalf,
			//       0,
			//       0LL);
			//     m_TAADepths = this.fields.m_TAADepths;
			//     if ( !m_TAADepths )
			//       goto LABEL_40;
			//     v14 = this.fields.m_RenderWidth;
			//     v15 = this.fields.m_RenderHeight;
			//     v16 = (VolumetricPipelineRT **)sub_180002B90(m_TAADepths, i);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//       (String *)"m_TAADepths",
			//       v16,
			//       v14,
			//       v15,
			//       RTLifeCycle__Enum_Persist,
			//       RenderTextureFormat__Enum_RHalf,
			//       0,
			//       0LL);
			//     m_TAADepths = this.fields.m_TAAColors;
			//     if ( !m_TAADepths )
			//       goto LABEL_40;
			//     if ( (unsigned int)i >= *((_DWORD *)m_TAADepths + 6) )
			//       goto LABEL_38;
			//     m_TAADepths = (void *)*((_QWORD *)m_TAADepths + i + 4);
			//     if ( !m_TAADepths )
			//       goto LABEL_40;
			//     RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)m_TAADepths, 0LL);
			//     if ( UnityEngine::SystemInfo::SupportsCubicFilter(0LL) )
			//     {
			//       m_TAADepths = inputs.volumetricParameters;
			//       if ( !m_TAADepths )
			//         goto LABEL_40;
			//       v18 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//               *((SettingParameter_1_System_Boolean_ **)m_TAADepths + 14),
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     }
			//     else
			//     {
			//       v18 = 0;
			//     }
			//     if ( !RT )
			//       goto LABEL_40;
			//     UnityEngine::Texture::set_cubicSample(RT, v18, 0LL);
			//     m_ReconstructColors = this.fields.m_ReconstructColors;
			//     if ( !m_ReconstructColors )
			//       goto LABEL_40;
			//     v20 = this.fields.m_RenderWidth;
			//     v21 = this.fields.m_RenderHeight;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     v22 = (VolumetricPipelineRT **)sub_180002B90(m_ReconstructColors, i);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//       (String *)"m_ReconstructColors",
			//       v22,
			//       v20,
			//       v21,
			//       RTLifeCycle__Enum_Persist,
			//       RenderTextureFormat__Enum_ARGBHalf,
			//       0,
			//       0LL);
			//     m_TAADepths = this.fields.m_ReconstructDepths;
			//     if ( !m_TAADepths )
			//       goto LABEL_40;
			//     v23 = this.fields.m_RenderWidth;
			//     v24 = this.fields.m_RenderHeight;
			//     v25 = (VolumetricPipelineRT **)sub_180002B90(m_TAADepths, i);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//       (String *)"m_ReconstructDepths",
			//       v25,
			//       v23,
			//       v24,
			//       RTLifeCycle__Enum_Persist,
			//       RenderTextureFormat__Enum_RHalf,
			//       0,
			//       0LL);
			//     m_TAADepths = this.fields.m_ReconstructColors;
			//     if ( !m_TAADepths )
			//       goto LABEL_40;
			//     if ( (unsigned int)i >= *((_DWORD *)m_TAADepths + 6) )
			// LABEL_38:
			//       sub_180070270(m_TAADepths, v5);
			//     m_TAADepths = (void *)*((_QWORD *)m_TAADepths + i + 4);
			//     if ( !m_TAADepths )
			//       goto LABEL_40;
			//     v26 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)m_TAADepths, 0LL);
			//     if ( UnityEngine::SystemInfo::SupportsCubicFilter(0LL) )
			//     {
			//       m_TAADepths = inputs.volumetricParameters;
			//       if ( !m_TAADepths )
			//         goto LABEL_40;
			//       v27 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//               *((SettingParameter_1_System_Boolean_ **)m_TAADepths + 8),
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     }
			//     else
			//     {
			//       v27 = 0;
			//     }
			//     if ( !v26 )
			//       goto LABEL_40;
			//     UnityEngine::Texture::set_cubicSample(v26, v27, 0LL);
			//     m_MinMaxWorldDepths = this.fields.m_MinMaxWorldDepths;
			//     if ( !m_MinMaxWorldDepths )
			//       goto LABEL_40;
			//     v29 = this.fields.m_RenderWidth;
			//     v30 = this.fields.m_RenderHeight;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     v31 = (VolumetricPipelineRT **)sub_180002B90(m_MinMaxWorldDepths, i);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//       (String *)"m_MinMaxWorldDepths",
			//       v31,
			//       v29,
			//       v30,
			//       RTLifeCycle__Enum_Persist,
			//       RenderTextureFormat__Enum_RFloat,
			//       0,
			//       0LL);
			//   }
			//   v32 = this.fields.m_RenderWidth;
			//   v33 = this.fields.m_RenderHeight;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//     (String *)"m_DepthForTest",
			//     &this.fields.m_DepthForTest,
			//     v32,
			//     v33,
			//     RTLifeCycle__Enum_Transient,
			//     RenderTextureFormat__Enum_Depth,
			//     0,
			//     0LL);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//     (String *)"m_ComposeColor",
			//     &this.fields.m_ComposeColor,
			//     this.fields.m_RenderWidth,
			//     this.fields.m_RenderHeight,
			//     RTLifeCycle__Enum_Persist,
			//     RenderTextureFormat__Enum_ARGBHalf,
			//     0,
			//     0LL);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//     (String *)"m_ComposeDepth",
			//     &this.fields.m_ComposeDepth,
			//     this.fields.m_RenderWidth,
			//     this.fields.m_RenderHeight,
			//     RTLifeCycle__Enum_Persist,
			//     RenderTextureFormat__Enum_RHalf,
			//     0,
			//     0LL);
			//   this.fields.m_FramingWidth = this.fields.m_RenderWidth;
			//   this.fields.m_FramingHeight = this.fields.m_RenderHeight;
			//   if ( !this.fields.m_EnableFraming )
			//     goto LABEL_35;
			//   volumetricParameters = inputs.volumetricParameters;
			//   if ( !volumetricParameters || (m_TAADepths = volumetricParameters.fields.framingLevel) == 0LL )
			// LABEL_40:
			//     sub_180B536AC(m_TAADepths, v5);
			//   if ( *((_DWORD *)m_TAADepths + 10) )
			//   {
			//     if ( *((_DWORD *)m_TAADepths + 10) == 1 )
			//     {
			//       this.fields.m_FramingWidth = (this.fields.m_RenderWidth + 1) / 2;
			//       this.fields.m_FramingHeight = (this.fields.m_RenderHeight + 1) / 2;
			//     }
			//   }
			//   else
			//   {
			//     this.fields.m_FramingWidth = (this.fields.m_RenderWidth + 1) / 2;
			//   }
			// LABEL_35:
			//   m_FramingWidth = this.fields.m_FramingWidth;
			//   m_FramingHeight = this.fields.m_FramingHeight;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//     (String *)"m_FramingColor",
			//     &this.fields.m_FramingColor,
			//     m_FramingWidth,
			//     m_FramingHeight,
			//     RTLifeCycle__Enum_Transient,
			//     RenderTextureFormat__Enum_ARGBHalf,
			//     0,
			//     0LL);
			//   HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//     (String *)"m_FramingDepth",
			//     &this.fields.m_FramingDepth,
			//     this.fields.m_FramingWidth,
			//     this.fields.m_FramingHeight,
			//     RTLifeCycle__Enum_Transient,
			//     RenderTextureFormat__Enum_RGHalf,
			//     0,
			//     0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   RTRes = (unsigned int)static_fields._RTRes;
			//   if ( !cmd )
			//     sub_180B536AC(static_fields, RTRes);
			//   v41.w = 1.0 / (float)this.fields.m_RenderHeight;
			//   v41.z = 1.0 / (float)this.fields.m_RenderWidth;
			//   v41.x = (float)this.fields.m_RenderWidth;
			//   v41.y = (float)this.fields.m_RenderHeight;
			//   value = v41;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, RTRes, &value, 0LL);
			//   FramingRes = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FramingRes;
			//   v41.z = 1.0 / (float)this.fields.m_FramingWidth;
			//   v41.w = 1.0 / (float)this.fields.m_FramingHeight;
			//   v41.x = (float)this.fields.m_FramingWidth;
			//   v41.y = (float)this.fields.m_FramingHeight;
			//   v43 = v41;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, FramingRes, &v43, 0LL);
			// }
			// 
		}

		private void ReleaseVolumetricRTs(bool full)
		{
			// // Void ReleaseVolumetricRTs(Boolean)
			// void HG::Rendering::Runtime::VolumetricRenderer::ReleaseVolumetricRTs(
			//         VolumetricRenderer *this,
			//         bool full,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   VolumetricPipelineRT__Array *m_TAADepths; // rcx
			//   int i; // edi
			//   VolumetricPipelineRT__Array *m_TAAColors; // rbp
			//   VolumetricPipelineRT **v9; // rax
			//   VolumetricPipelineRT **v10; // rax
			//   VolumetricPipelineRT **v11; // rax
			//   VolumetricPipelineRT **v12; // rax
			//   VolumetricPipelineRT **v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBB2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D8EDBB2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2875, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2875, 0LL);
			//     if ( !Patch )
			// LABEL_16:
			//       sub_180B536AC(m_TAADepths, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, full, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 2; ++i )
			//     {
			//       m_TAAColors = this.fields.m_TAAColors;
			//       if ( !m_TAAColors )
			//         goto LABEL_16;
			//       if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils, v5);
			//       v9 = (VolumetricPipelineRT **)sub_180002B90(m_TAAColors, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v9, full, 0LL);
			//       m_TAADepths = this.fields.m_TAADepths;
			//       if ( !m_TAADepths )
			//         goto LABEL_16;
			//       v10 = (VolumetricPipelineRT **)sub_180002B90(m_TAADepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v10, full, 0LL);
			//       m_TAADepths = this.fields.m_ReconstructColors;
			//       if ( !m_TAADepths )
			//         goto LABEL_16;
			//       v11 = (VolumetricPipelineRT **)sub_180002B90(m_TAADepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v11, full, 0LL);
			//       m_TAADepths = this.fields.m_ReconstructDepths;
			//       if ( !m_TAADepths )
			//         goto LABEL_16;
			//       v12 = (VolumetricPipelineRT **)sub_180002B90(m_TAADepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v12, full, 0LL);
			//       m_TAADepths = this.fields.m_MinMaxWorldDepths;
			//       if ( !m_TAADepths )
			//         goto LABEL_16;
			//       v13 = (VolumetricPipelineRT **)sub_180002B90(m_TAADepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v13, full, 0LL);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils, v5);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_DepthForTest, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_ComposeColor, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_ComposeDepth, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FramingColor, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FramingDepth, full, 0LL);
			//   }
			// }
			// 
		}

		public void DumpRTStats()
		{
			// // Void DumpRTStats()
			// void HG::Rendering::Runtime::VolumetricRenderer::DumpRTStats(VolumetricRenderer *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int i; // edi
			//   VolumetricPipelineRT__Array *m_TAAColors; // rbx
			//   Object *v7; // rbx
			//   VolumetricPipelineRT__Array *m_TAADepths; // rax
			//   VolumetricPipelineRT__Array *m_ReconstructColors; // rax
			//   VolumetricPipelineRT__Array *m_ReconstructDepths; // rax
			//   VolumetricPipelineRT__Array *m_MinMaxWorldDepths; // rax
			//   Object *m_DepthForTest; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197CE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     byte_18D9197CE = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4537, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4537, 0LL);
			//     if ( !Patch )
			// LABEL_19:
			//       sub_180B536AC(v4, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 2; ++i )
			//     {
			//       m_TAAColors = this.fields.m_TAAColors;
			//       if ( !m_TAAColors )
			//         goto LABEL_19;
			//       if ( (unsigned int)i >= m_TAAColors.max_length.size )
			//         goto LABEL_17;
			//       v7 = (Object *)m_TAAColors.vector[i];
			//       sub_180002C70(TypeInfo::UnityEngine::Debug);
			//       UnityEngine::Debug::Log(v7, 0LL);
			//       m_TAADepths = this.fields.m_TAADepths;
			//       if ( !m_TAADepths )
			//         goto LABEL_19;
			//       if ( (unsigned int)i >= m_TAADepths.max_length.size )
			//         goto LABEL_17;
			//       UnityEngine::Debug::Log((Object *)m_TAADepths.vector[i], 0LL);
			//       m_ReconstructColors = this.fields.m_ReconstructColors;
			//       if ( !m_ReconstructColors )
			//         goto LABEL_19;
			//       if ( (unsigned int)i >= m_ReconstructColors.max_length.size )
			//         goto LABEL_17;
			//       UnityEngine::Debug::Log((Object *)m_ReconstructColors.vector[i], 0LL);
			//       m_ReconstructDepths = this.fields.m_ReconstructDepths;
			//       if ( !m_ReconstructDepths )
			//         goto LABEL_19;
			//       if ( (unsigned int)i >= m_ReconstructDepths.max_length.size )
			//         goto LABEL_17;
			//       UnityEngine::Debug::Log((Object *)m_ReconstructDepths.vector[i], 0LL);
			//       m_MinMaxWorldDepths = this.fields.m_MinMaxWorldDepths;
			//       if ( !m_MinMaxWorldDepths )
			//         goto LABEL_19;
			//       if ( (unsigned int)i >= m_MinMaxWorldDepths.max_length.size )
			// LABEL_17:
			//         sub_180070270(v4, v3);
			//       UnityEngine::Debug::Log((Object *)m_MinMaxWorldDepths.vector[i], 0LL);
			//     }
			//     m_DepthForTest = (Object *)this.fields.m_DepthForTest;
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     UnityEngine::Debug::Log(m_DepthForTest, 0LL);
			//     UnityEngine::Debug::Log((Object *)this.fields.m_ComposeColor, 0LL);
			//     UnityEngine::Debug::Log((Object *)this.fields.m_ComposeDepth, 0LL);
			//     UnityEngine::Debug::Log((Object *)this.fields.m_FramingColor, 0LL);
			//     UnityEngine::Debug::Log((Object *)this.fields.m_FramingDepth, 0LL);
			//   }
			// }
			// 
		}

		private void DrawVolumetric(ref VolumetricRenderInputs inputs)
		{
			// // Void DrawVolumetric(VolumetricRenderInputs ByRef)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::VolumetricRenderer::DrawVolumetric(
			//         VolumetricRenderer *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   VolumetricRenderInputs *v3; // r14
			//   VolumetricRenderer *v4; // rsi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderGraphContext *context; // r12
			//   CommandBuffer *cmd; // r12
			//   Material *m_VolumetricMat; // rbx
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
			//   List_1_System_Object_ *volumetricRenderObjects; // rdx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   Object *current; // rbx
			//   HGRenderGraphContext *v18; // r12
			//   CommandBuffer *v19; // r12
			//   unsigned int v20; // ebx
			//   Vector2 one; // rax
			//   _OWORD *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   void (__fastcall *v25)(CommandBuffer *, _QWORD, RenderTargetIdentifier *); // rax
			//   unsigned int v26; // ebx
			//   TextureHandle sceneDepthToSample; // xmm6
			//   void (__fastcall *v28)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64); // rax
			//   unsigned int v29; // ebx
			//   void (__fastcall *v30)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64); // rax
			//   unsigned int v31; // ebx
			//   void (__fastcall *v32)(CommandBuffer *, _QWORD, RenderTargetIdentifier *); // rax
			//   unsigned int NDCRescaleRatio; // ebx
			//   _OWORD *v34; // rax
			//   __int64 v35; // rdx
			//   HGVolumetricCloudSettingParameters *v36; // rcx
			//   void (__fastcall *v37)(CommandBuffer *, _QWORD, RenderTargetIdentifier *); // rax
			//   float v38; // xmm0_4
			//   Vector4 *v39; // rax
			//   unsigned int DownscaleScreenParams; // ebx
			//   void (__fastcall *v41)(CommandBuffer *, _QWORD, RenderTargetIdentifier *); // rax
			//   __int64 v42; // r8
			//   __int64 v43; // r9
			//   VolumetricPipelineRT__Array *v44; // rax
			//   VolumetricPipelineRT *v45; // rbx
			//   RenderTexture *rt; // rbx
			//   Material *v47; // r13
			//   Material *v48; // rcx
			//   Shader *shader; // rbx
			//   String *s_EnableDepthForTest; // r8
			//   __int64 v51; // r8
			//   __int64 v52; // r9
			//   VolumetricPipelineRT__Array *m_MinMaxWorldDepths; // rbx
			//   __int64 m_RTIndex; // rax
			//   VolumetricPipelineRT *v55; // rbx
			//   RenderTargetIdentifier *v56; // rax
			//   __int128 v57; // xmm9
			//   __int128 v58; // xmm10
			//   __int64 v59; // xmm11_8
			//   VolumetricPipelineRT *m_DepthForTest; // rbx
			//   RenderTargetIdentifier *v61; // rax
			//   __int128 v62; // xmm7
			//   __int128 v63; // xmm8
			//   __int64 v64; // xmm6_8
			//   Material *v65; // rbx
			//   __int64 v66; // rdx
			//   Material *v67; // r13
			//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
			//   Shader *v69; // rbx
			//   String *v70; // r8
			//   __int64 v71; // r8
			//   __int64 v72; // r9
			//   unsigned int WorldDepthTex; // r13d
			//   VolumetricPipelineRT__Array *v74; // rbx
			//   __int64 v75; // rax
			//   VolumetricPipelineRT *v76; // rbx
			//   void (__fastcall *v77)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64); // rax
			//   __int64 v78; // rdx
			//   __int64 v79; // r8
			//   __int64 v80; // r9
			//   unsigned int HistoryWorldDepthTex; // r13d
			//   VolumetricPipelineRT__Array *v82; // rcx
			//   int v83; // eax
			//   VolumetricPipelineRT *v84; // rbx
			//   void (__fastcall *v85)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64); // rax
			//   ILFixDynamicMethodWrapper_2 *v86; // rax
			//   Object *Item; // rax
			//   Object *v88; // rax
			//   Object *v89; // rax
			//   Object *v90; // rax
			//   Object *v91; // rax
			//   __int64 v92; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v94; // rdx
			//   __int64 v95; // rcx
			//   __int64 v96; // rax
			//   __int64 v97; // rax
			//   RenderTargetIdentifier keyword; // [rsp+30h] [rbp-178h] BYREF
			//   VolumetricPipelineRT *colorRT; // [rsp+60h] [rbp-148h] BYREF
			//   List_1_T_Enumerator_System_Object_ v100; // [rsp+68h] [rbp-140h] BYREF
			//   Vector4 m_DownscaledScreenParams; // [rsp+80h] [rbp-128h] BYREF
			//   RenderTargetIdentifier v102; // [rsp+90h] [rbp-118h] BYREF
			//   RenderTargetIdentifier v103; // [rsp+C0h] [rbp-E8h] BYREF
			//   Il2CppExceptionWrapper *v104; // [rsp+F0h] [rbp-B8h] BYREF
			//   Il2CppExceptionWrapper *v105; // [rsp+F8h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v106; // [rsp+100h] [rbp-A8h] BYREF
			//   VolumetricPipelineRT *depthsRT; // [rsp+1C8h] [rbp+20h] BYREF
			// 
			//   v3 = inputs;
			//   v4 = this;
			//   if ( !byte_18D9197CF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D9197CF = 1;
			//   }
			//   memset(&v100, 0, sizeof(v100));
			//   colorRT = 0LL;
			//   depthsRT = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4531, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4531, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v95, v94);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)v4, v3, 0LL);
			//   }
			//   else
			//   {
			//     context = v3.context;
			//     if ( !context )
			//       sub_180B536AC(v6, v5);
			//     cmd = context.fields.cmd;
			//     *(_QWORD *)&m_DownscaledScreenParams.x = cmd;
			//     m_VolumetricMat = v4.fields.m_VolumetricMat;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, m_VolumetricMat, 0, 0LL);
			//     if ( !v3.volumetricRenderObjects )
			//       sub_180B536AC(v11, v10);
			//     v100 = *(List_1_T_Enumerator_System_Object_ *)sub_18031B324(&v102, v3.volumetricRenderObjects);
			//     *(_QWORD *)&keyword.m_Type = 0LL;
			//     *(_QWORD *)&keyword.m_InstanceID = &v100;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v100,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//       {
			//         if ( !v100._current )
			//           sub_1802DC2C8(0LL, v12);
			//         sub_1886C0E50(
			//           (VolumetricRenderObject *)v100._current,
			//           cmd,
			//           v4.fields.m_VolumetricMat,
			//           v4.fields.m_PropertyBlock);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v104 )
			//     {
			//       *(Il2CppExceptionWrapper *)&keyword.m_Type = (Il2CppExceptionWrapper)v104.ex;
			//       volumetricParameters = *(SettingParameter_1_System_Boolean_ ***)&keyword.m_Type;
			//       if ( *(_QWORD *)&keyword.m_Type )
			//         sub_18000F780(*(_QWORD *)&keyword.m_Type);
			//       v3 = inputs;
			//       v4 = this;
			//       cmd = *(CommandBuffer **)&m_DownscaledScreenParams.x;
			//     }
			//     if ( cmd )
			//     {
			//       volumetricRenderObjects = (List_1_System_Object_ *)v3.volumetricRenderObjects;
			//       if ( !volumetricRenderObjects )
			//         goto LABEL_115;
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Object_ *)&v102,
			//         volumetricRenderObjects,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//       v100 = *(List_1_T_Enumerator_System_Object_ *)&v102.m_Type;
			//       *(_QWORD *)&keyword.m_Type = 0LL;
			//       *(_QWORD *)&keyword.m_InstanceID = &v100;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v100,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//         {
			//           current = v100._current;
			//           if ( !v100._current )
			//             sub_1802DC2C8(v16, v15);
			//           if ( !byte_18D919821 )
			//           {
			//             sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IVolumetricRenderObject);
			//             byte_18D919821 = 1;
			//           }
			//           if ( *(_DWORD *)&current.klass._1.method_count == 3218
			//             || *(_DWORD *)&current.klass._1.method_count == 3219 )
			//           {
			//             HG::Rendering::Runtime::VolumetricRenderObject::PreVolumetricRendering(
			//               (VolumetricRenderObject *)current,
			//               v3,
			//               0LL);
			//           }
			//           else
			//           {
			//             sub_18083375C(2LL, (unsigned int)(*(_DWORD *)&current.klass._1.method_count - 3218), current, v3);
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v105 )
			//       {
			//         *(Il2CppExceptionWrapper *)&keyword.m_Type = (Il2CppExceptionWrapper)v105.ex;
			//         if ( *(_QWORD *)&keyword.m_Type )
			//           sub_18000F780(*(_QWORD *)&keyword.m_Type);
			//         v3 = inputs;
			//         v4 = this;
			//       }
			//       if ( !byte_18D9197C8 )
			//       {
			//         sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//         sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//         sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         byte_18D9197C8 = 1;
			//       }
			//       if ( IFix::WrappersManagerImpl::IsPatched(4532, 0LL) )
			//       {
			//         v86 = IFix::WrappersManagerImpl::GetPatch(4532, 0LL);
			//         if ( !v86 )
			//           goto LABEL_115;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(v86, (Object *)v4, v3, 0LL);
			//       }
			//       else
			//       {
			//         v18 = v3.context;
			//         if ( !v18 )
			//           goto LABEL_115;
			//         v19 = v18.fields.cmd;
			//         volumetricParameters = (SettingParameter_1_System_Boolean_ **)v3.volumetricParameters;
			//         if ( !volumetricParameters )
			//           goto LABEL_115;
			//         if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                volumetricParameters[2],
			//                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           NDCRescaleRatio = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._NDCRescaleRatio;
			//           v34 = (_OWORD *)sub_1825A3980(
			//                             &m_DownscaledScreenParams,
			//                             _mm_unpacklo_ps(
			//                               (__m128)LODWORD(v4.fields.m_NDCRescaleParams.x),
			//                               (__m128)LODWORD(v4.fields.m_NDCRescaleParams.y)).m128_u64[0]);
			//           if ( !v19 )
			//             goto LABEL_112;
			//           *(_OWORD *)&keyword.m_Type = *v34;
			//           v37 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))qword_18D92FCE8;
			//           if ( !qword_18D92FCE8 )
			//           {
			//             v37 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))il2cpp_resolve_icall_0(
			//                                                                                             "UnityEngine.Rendering.Comman"
			//                                                                                             "dBuffer::SetGlobalVector_Inj"
			//                                                                                             "ected(System.Int32,UnityEngine.Vector4&)");
			//             if ( !v37 )
			//             {
			//               v96 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::SetGlobalVector_Injected(System.Int32,UnityEngine.Vector4&)");
			//               sub_18000F750(v96, 0LL);
			//             }
			//             qword_18D92FCE8 = (__int64)v37;
			//           }
			//           v37(v19, NDCRescaleRatio, &keyword);
			//           v36 = v3.volumetricParameters;
			//           if ( !v36 )
			// LABEL_112:
			//             sub_1802DC2C8(v36, v35);
			//           v38 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                   v36.fields.downResRatio,
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//           m_DownscaledScreenParams.x = 1.0 / v38;
			//           m_DownscaledScreenParams.y = 1.0 / v38;
			//           m_DownscaledScreenParams.z = v38;
			//           m_DownscaledScreenParams.w = v38;
			//           *(Vector4 *)&keyword.m_Type = m_DownscaledScreenParams;
			//           m_DownscaledScreenParams = v4.fields.m_DownscaledScreenParams;
			//           v39 = UnityEngine::Vector4::Scale((Vector4 *)&v102, &m_DownscaledScreenParams, (Vector4 *)&keyword, 0LL);
			//           DownscaleScreenParams = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DownscaleScreenParams;
			//           *(Vector4 *)&keyword.m_Type = *v39;
			//           v41 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))qword_18D92FCE8;
			//           if ( !qword_18D92FCE8 )
			//           {
			//             v41 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))il2cpp_resolve_icall_0(
			//                                                                                             "UnityEngine.Rendering.Comman"
			//                                                                                             "dBuffer::SetGlobalVector_Inj"
			//                                                                                             "ected(System.Int32,UnityEngine.Vector4&)");
			//             if ( !v41 )
			//             {
			//               v97 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::SetGlobalVector_Injected(System.Int32,UnityEngine.Vector4&)");
			//               sub_18000F750(v97, 0LL);
			//             }
			//             qword_18D92FCE8 = (__int64)v41;
			//           }
			//           v41(v19, DownscaleScreenParams, &keyword);
			//           if ( v4.fields.m_BeforeTAANeedDepthTest || v4.fields.m_AfterTAANeedDepthTest )
			//           {
			//             v47 = v4.fields.m_VolumetricMat;
			//             v48 = v47;
			//             if ( !v47 )
			//               goto LABEL_111;
			//             shader = UnityEngine::Material::get_shader(v47, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//             s_EnableDepthForTest = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableDepthForTest;
			//             memset(&v102, 0, 24);
			//             UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v102, shader, s_EnableDepthForTest, 0LL);
			//             *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v102.m_Type;
			//             keyword.m_BufferPointer = v102.m_BufferPointer;
			//             UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(
			//               v19,
			//               v47,
			//               (LocalKeyword *)&keyword,
			//               0LL);
			//             m_MinMaxWorldDepths = v4.fields.m_MinMaxWorldDepths;
			//             m_RTIndex = v4.fields.m_RTIndex;
			//             if ( !m_MinMaxWorldDepths )
			//               goto LABEL_111;
			//             if ( (unsigned int)m_RTIndex >= m_MinMaxWorldDepths.max_length.size )
			//               sub_180070260(v48, volumetricRenderObjects, v51, v52);
			//             v55 = m_MinMaxWorldDepths.vector[m_RTIndex];
			//             if ( !v55
			//               || (HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(v55, 0LL),
			//                   v56 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                           &v103,
			//                           (Texture *)v55.fields.rt,
			//                           0LL),
			//                   v57 = *(_OWORD *)&v56.m_Type,
			//                   v58 = *(_OWORD *)&v56.m_BufferPointer,
			//                   v59 = *(_QWORD *)&v56.m_DepthSlice,
			//                   (m_DepthForTest = v4.fields.m_DepthForTest) == 0LL) )
			//             {
			// LABEL_111:
			//               sub_1802DC2C8(v48, volumetricRenderObjects);
			//             }
			//             HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(v4.fields.m_DepthForTest, 0LL);
			//             v61 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                     &v103,
			//                     (Texture *)m_DepthForTest.fields.rt,
			//                     0LL);
			//             v62 = *(_OWORD *)&v61.m_Type;
			//             v63 = *(_OWORD *)&v61.m_BufferPointer;
			//             v64 = *(_QWORD *)&v61.m_DepthSlice;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//             *(_OWORD *)&keyword.m_Type = v62;
			//             *(_OWORD *)&keyword.m_BufferPointer = v63;
			//             *(_QWORD *)&keyword.m_DepthSlice = v64;
			//             *(_OWORD *)&v103.m_Type = v57;
			//             *(_OWORD *)&v103.m_BufferPointer = v58;
			//             *(_QWORD *)&v103.m_DepthSlice = v59;
			//             HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetWithDepth(
			//               v19,
			//               &v103,
			//               &keyword,
			//               RenderBufferLoadAction__Enum_DontCare,
			//               RenderBufferStoreAction__Enum_Store,
			//               0LL);
			//           }
			//           else
			//           {
			//             v44 = v4.fields.m_MinMaxWorldDepths;
			//             volumetricParameters = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RTIndex;
			//             if ( !v44 )
			//               goto LABEL_115;
			//             if ( (unsigned int)volumetricParameters >= v44.max_length.size )
			//               sub_180070260(volumetricParameters, volumetricRenderObjects, v42, v43);
			//             v45 = v44.vector[(_QWORD)volumetricParameters];
			//             if ( !v45 )
			//               goto LABEL_115;
			//             HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(v44.vector[(_QWORD)volumetricParameters], 0LL);
			//             rt = v45.fields.rt;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//             HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(v19, rt, 0LL);
			//           }
			//           v65 = v4.fields.m_VolumetricMat;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(v19, v65, 0, 0, 0LL);
			//           v67 = v4.fields.m_VolumetricMat;
			//           static_fields = (VolumetricShaderIDs__StaticFields *)v67;
			//           if ( !v67 )
			//             goto LABEL_110;
			//           v69 = UnityEngine::Material::get_shader(v67, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//           v70 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_EnableDepthForTest;
			//           memset(&v102, 0, 24);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v102, v69, v70, 0LL);
			//           *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v102.m_Type;
			//           keyword.m_BufferPointer = v102.m_BufferPointer;
			//           UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
			//             v19,
			//             v67,
			//             (LocalKeyword *)&keyword,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           WorldDepthTex = static_fields._WorldDepthTex;
			//           v74 = v4.fields.m_MinMaxWorldDepths;
			//           v75 = v4.fields.m_RTIndex;
			//           if ( !v74 )
			//             goto LABEL_110;
			//           if ( (unsigned int)v75 >= v74.max_length.size )
			//             sub_180070260(static_fields, v66, v71, v72);
			//           v76 = v74.vector[v75];
			//           if ( !v76 )
			// LABEL_110:
			//             sub_1802DC2C8(static_fields, v66);
			//           HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(v76, 0LL);
			//           v103 = *UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&keyword, (Texture *)v76.fields.rt, 0LL);
			//           v77 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))qword_18D92FBF8;
			//           if ( !qword_18D92FBF8 )
			//           {
			//             v77 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))sub_180017470("UnityEngine.Rendering.CommandBuffer::SetGlobalTexture_Impl(System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,UnityEngine.Rendering.RenderTextureSubElement)");
			//             qword_18D92FBF8 = (__int64)v77;
			//           }
			//           v77(v19, WorldDepthTex, &v103, 3LL);
			//           HistoryWorldDepthTex = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._HistoryWorldDepthTex;
			//           v82 = v4.fields.m_MinMaxWorldDepths;
			//           if ( !v82 )
			//             goto LABEL_109;
			//           v83 = 1 - v4.fields.m_RTIndex;
			//           if ( (unsigned int)v83 >= v82.max_length.size )
			//             sub_180070260(v82, v78, v79, v80);
			//           v84 = v82.vector[v83];
			//           if ( !v84 )
			// LABEL_109:
			//             sub_1802DC2C8(v82, v78);
			//           HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(v84, 0LL);
			//           v103 = *UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&keyword, (Texture *)v84.fields.rt, 0LL);
			//           v85 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))qword_18D92FBF8;
			//           if ( !qword_18D92FBF8 )
			//           {
			//             v85 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))sub_180017470("UnityEngine.Rendering.CommandBuffer::SetGlobalTexture_Impl(System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,UnityEngine.Rendering.RenderTextureSubElement)");
			//             qword_18D92FBF8 = (__int64)v85;
			//           }
			//           v85(v19, HistoryWorldDepthTex, &v103, 3LL);
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           v20 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._NDCRescaleRatio;
			//           one = UnityEngine::Vector2::get_one(0LL);
			//           v22 = (_OWORD *)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1825A3980)(&m_DownscaledScreenParams, one);
			//           if ( !v19 )
			//             sub_1802DC2C8(v24, v23);
			//           *(_OWORD *)&keyword.m_Type = *v22;
			//           v25 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))qword_18D92FCE8;
			//           if ( !qword_18D92FCE8 )
			//           {
			//             v25 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))sub_180017470(
			//                                                                                             "UnityEngine.Rendering.Comman"
			//                                                                                             "dBuffer::SetGlobalVector_Inj"
			//                                                                                             "ected(System.Int32,UnityEngine.Vector4&)");
			//             qword_18D92FCE8 = (__int64)v25;
			//           }
			//           v25(v19, v20, &keyword);
			//           v26 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WorldDepthTex;
			//           sceneDepthToSample = v3.sceneDepthToSample;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           *(TextureHandle *)&keyword.m_Type = sceneDepthToSample;
			//           v102 = *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v103, (TextureHandle *)&keyword, 0LL);
			//           v28 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))qword_18D92FBF8;
			//           if ( !qword_18D92FBF8 )
			//           {
			//             v28 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))sub_180017470("UnityEngine.Rendering.CommandBuffer::SetGlobalTexture_Impl(System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,UnityEngine.Rendering.RenderTextureSubElement)");
			//             qword_18D92FBF8 = (__int64)v28;
			//           }
			//           v28(v19, v26, &v102, 3LL);
			//           v29 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._HistoryWorldDepthTex;
			//           *(TextureHandle *)&keyword.m_Type = v3.historySceneDepth;
			//           v102 = *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v103, (TextureHandle *)&keyword, 0LL);
			//           v30 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))qword_18D92FBF8;
			//           if ( !qword_18D92FBF8 )
			//           {
			//             v30 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *, __int64))sub_180017470("UnityEngine.Rendering.CommandBuffer::SetGlobalTexture_Impl(System.Int32,UnityEngine.Rendering.RenderTargetIdentifier&,UnityEngine.Rendering.RenderTextureSubElement)");
			//             qword_18D92FBF8 = (__int64)v30;
			//           }
			//           v30(v19, v29, &v102, 3LL);
			//           v31 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DownscaleScreenParams;
			//           *(Vector4 *)&keyword.m_Type = v4.fields.m_DownscaledScreenParams;
			//           v32 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))qword_18D92FCE8;
			//           if ( !qword_18D92FCE8 )
			//           {
			//             v32 = (void (__fastcall *)(CommandBuffer *, _QWORD, RenderTargetIdentifier *))sub_180017470(
			//                                                                                             "UnityEngine.Rendering.Comman"
			//                                                                                             "dBuffer::SetGlobalVector_Inj"
			//                                                                                             "ected(System.Int32,UnityEngine.Vector4&)");
			//             qword_18D92FCE8 = (__int64)v32;
			//           }
			//           v32(v19, v31, &keyword);
			//         }
			//       }
			//       colorRT = 0LL;
			//       depthsRT = 0LL;
			//       volumetricParameters = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RenderStages;
			//       if ( volumetricParameters )
			//       {
			//         Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                  (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
			//                  (Int32Enum__Enum)0,
			//                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//         if ( Item )
			//         {
			//           HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
			//             (VolumetricRenderer_VolumetricRenderStage *)Item,
			//             v3,
			//             &colorRT,
			//             &depthsRT,
			//             0LL);
			//           volumetricParameters = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RenderStages;
			//           if ( volumetricParameters )
			//           {
			//             v88 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                     (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
			//                     (Int32Enum__Enum)1u,
			//                     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//             if ( v88 )
			//             {
			//               HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
			//                 (VolumetricRenderer_VolumetricRenderStage *)v88,
			//                 v3,
			//                 &colorRT,
			//                 &depthsRT,
			//                 0LL);
			//               volumetricParameters = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RenderStages;
			//               if ( volumetricParameters )
			//               {
			//                 v89 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                         (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
			//                         (Int32Enum__Enum)2u,
			//                         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//                 if ( v89 )
			//                 {
			//                   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
			//                     (VolumetricRenderer_VolumetricRenderStage *)v89,
			//                     v3,
			//                     &colorRT,
			//                     &depthsRT,
			//                     0LL);
			//                   volumetricParameters = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RenderStages;
			//                   if ( volumetricParameters )
			//                   {
			//                     v90 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                             (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
			//                             (Int32Enum__Enum)3u,
			//                             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//                     if ( v90 )
			//                     {
			//                       HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
			//                         (VolumetricRenderer_VolumetricRenderStage *)v90,
			//                         v3,
			//                         &colorRT,
			//                         &depthsRT,
			//                         0LL);
			//                       volumetricParameters = (SettingParameter_1_System_Boolean_ **)v4.fields.m_RenderStages;
			//                       if ( volumetricParameters )
			//                       {
			//                         v91 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			//                                 (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
			//                                 (Int32Enum__Enum)4u,
			//                                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			//                         if ( v91 )
			//                         {
			//                           HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
			//                             (VolumetricRenderer_VolumetricRenderStage *)v91,
			//                             v3,
			//                             &colorRT,
			//                             &depthsRT,
			//                             0LL);
			//                           volumetricRenderObjects = (List_1_System_Object_ *)v3.volumetricRenderObjects;
			//                           if ( volumetricRenderObjects )
			//                           {
			//                             System::Collections::Generic::List<System::Object>::GetEnumerator(
			//                               (List_1_T_Enumerator_System_Object_ *)&v102,
			//                               volumetricRenderObjects,
			//                               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//                             v100 = *(List_1_T_Enumerator_System_Object_ *)&v102.m_Type;
			//                             *(_QWORD *)&keyword.m_Type = 0LL;
			//                             *(_QWORD *)&keyword.m_InstanceID = &v100;
			//                             try
			//                             {
			//                               while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                                         &v100,
			//                                         MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//                               {
			//                                 if ( !v100._current )
			//                                   sub_1802DC2C8(0LL, v92);
			//                                 sub_1886C1064((VolumetricRenderObject *)v100._current, v3);
			//                               }
			//                             }
			//                             catch ( Il2CppExceptionWrapper *v106 )
			//                             {
			//                               *(Il2CppExceptionWrapper *)&keyword.m_Type = (Il2CppExceptionWrapper)v106.ex;
			//                               if ( *(_QWORD *)&keyword.m_Type )
			//                                 sub_18000F780(*(_QWORD *)&keyword.m_Type);
			//                               v4 = this;
			//                             }
			//                             v4.fields.m_RTIndex = 1 - v4.fields.m_RTIndex;
			//                             return;
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_115:
			//       sub_1802DC2C8(volumetricParameters, volumetricRenderObjects);
			//     }
			//   }
			// }
			// 
		}

		public static HGVolumetricQualitySettings PrepareQualitySettingsCPP(HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // HGVolumetricQualitySettings PrepareQualitySettingsCPP(HGVolumetricCloudSettingParameters)
			// HGVolumetricQualitySettings *HG::Rendering::Runtime::VolumetricRenderer::PrepareQualitySettingsCPP(
			//         HGVolumetricQualitySettings *__return_ptr retstr,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool v7; // r14
			//   SettingParameter_1_System_Boolean_ *enableDownRes; // rdi
			//   struct MethodInfo *v9; // rsi
			//   Il2CppClass *klass; // rax
			//   bool paramValue_k__BackingField; // al
			//   SettingParameter_1_System_Single_ *downResRatio; // rsi
			//   struct MethodInfo *v13; // rdi
			//   Il2CppClass *v14; // rax
			//   SettingParameter_1_EDownResFilter_ *downResFilter; // rax
			//   SettingParameter_1_System_Boolean_ *enableFraming; // rsi
			//   struct MethodInfo *v17; // rdi
			//   Il2CppClass *v18; // rax
			//   SettingParameter_1_EFramingQuality_ *framingLevel; // rax
			//   SettingParameter_1_System_Single_ *framingComposeRatio; // rdi
			//   struct MethodInfo *v21; // rsi
			//   Il2CppClass *v22; // rax
			//   bool v23; // al
			//   SettingParameter_1_System_Boolean_ *enableFramingMotionVector; // rsi
			//   struct MethodInfo *v25; // rdi
			//   Il2CppClass *v26; // rax
			//   bool v27; // al
			//   SettingParameter_1_System_Boolean_ *enableFramingDepthOpt; // rsi
			//   struct MethodInfo *v29; // rdi
			//   Il2CppClass *v30; // rax
			//   bool v31; // al
			//   SettingParameter_1_System_Boolean_ *enableFramingColorAABB; // rsi
			//   struct MethodInfo *v33; // rdi
			//   Il2CppClass *v34; // rax
			//   bool v35; // al
			//   SettingParameter_1_System_Boolean_ *enableFramingNeighborAvg; // rsi
			//   struct MethodInfo *v37; // rdi
			//   Il2CppClass *v38; // rax
			//   bool v39; // al
			//   __int128 v40; // xmm0
			//   SettingParameter_1_System_Boolean_ *enableTAA; // rsi
			//   struct MethodInfo *v42; // rdi
			//   Il2CppClass *v43; // rax
			//   bool v44; // al
			//   SettingParameter_1_System_Boolean_ *enableTAAMotionVector; // rsi
			//   struct MethodInfo *v46; // rdi
			//   Il2CppClass *v47; // rax
			//   bool v48; // al
			//   SettingParameter_1_System_Boolean_ *enableTAADepthOpt; // rsi
			//   struct MethodInfo *v50; // rdi
			//   Il2CppClass *v51; // rax
			//   bool v52; // al
			//   SettingParameter_1_System_Boolean_ *enableTAAColorAABB; // rsi
			//   struct MethodInfo *v54; // rdi
			//   Il2CppClass *v55; // rax
			//   bool v56; // al
			//   SettingParameter_1_System_Boolean_ *enableTAANeighborAvg; // rsi
			//   struct MethodInfo *v58; // rdi
			//   Il2CppClass *v59; // rax
			//   bool v60; // al
			//   SettingParameter_1_System_Single_ *invalidDepthBlendRatio; // rsi
			//   struct MethodInfo *v62; // rdi
			//   Il2CppClass *v63; // rax
			//   float v64; // xmm1_4
			//   SettingParameter_1_System_Single_ *marchStepScale; // rsi
			//   struct MethodInfo *v66; // rdi
			//   Il2CppClass *v67; // rax
			//   float v68; // xmm0_4
			//   SettingParameter_1_System_Single_ *godRayStepScale; // rsi
			//   struct MethodInfo *v70; // rdi
			//   Il2CppClass *v71; // rax
			//   float v72; // xmm0_4
			//   SettingParameter_1_System_Single_ *emptySkipSizeScale; // rsi
			//   struct MethodInfo *v74; // rdi
			//   Il2CppClass *v75; // rax
			//   float v76; // xmm0_4
			//   SettingParameter_1_System_Single_ *dynamicStepRange; // rsi
			//   struct MethodInfo *v78; // rdi
			//   Il2CppClass *v79; // rax
			//   float v80; // xmm0_4
			//   SettingParameter_1_System_Single_ *dynamicStepScale; // rsi
			//   struct MethodInfo *v82; // rdi
			//   Il2CppClass *v83; // rax
			//   float v84; // xmm0_4
			//   SettingParameter_1_System_Boolean_ *enableFarCloud; // rsi
			//   struct MethodInfo *v86; // rdi
			//   Il2CppClass *v87; // rax
			//   bool v88; // al
			//   SettingParameter_1_System_Int32_ *panoramicSizeX; // rsi
			//   struct MethodInfo *v90; // rdi
			//   Il2CppClass *v91; // rax
			//   int32_t v92; // eax
			//   SettingParameter_1_System_Int32_ *panoramicSizeY; // rsi
			//   struct MethodInfo *v94; // rdi
			//   Il2CppClass *v95; // rax
			//   int32_t v96; // eax
			//   SettingParameter_1_System_Int32_ *octahedronSize; // rsi
			//   struct MethodInfo *v98; // rdi
			//   Il2CppClass *v99; // rax
			//   int32_t v100; // eax
			//   SettingParameter_1_System_Single_ *octahedronHeightScale; // rsi
			//   struct MethodInfo *v102; // rdi
			//   Il2CppClass *v103; // rax
			//   float v104; // xmm0_4
			//   SettingParameter_1_System_Boolean_ *octahedronEnableSlicing; // rsi
			//   struct MethodInfo *v106; // rdi
			//   Il2CppClass *v107; // rax
			//   bool v108; // al
			//   SettingParameter_1_System_Int32_ *octahedronSlicingCountX; // rsi
			//   struct MethodInfo *v110; // rdi
			//   Il2CppClass *v111; // rax
			//   int32_t v112; // eax
			//   SettingParameter_1_System_Int32_ *octahedronSlicingCountY; // rsi
			//   struct MethodInfo *v114; // rdi
			//   Il2CppClass *v115; // rax
			//   int32_t v116; // eax
			//   SettingParameter_1_System_Int32_ *semicircularSize; // rsi
			//   struct MethodInfo *v118; // rdi
			//   Il2CppClass *v119; // rax
			//   int32_t v120; // eax
			//   SettingParameter_1_System_Single_ *semicircularZScale; // rsi
			//   struct MethodInfo *v122; // rdi
			//   Il2CppClass *v123; // rax
			//   SettingParameter_1_EFarCloudFramingQuality_ *farCloudFramingLevel; // rax
			//   SettingParameter_1_System_Single_ *farCloudFramingComposeRatio; // rdi
			//   struct MethodInfo *v126; // rsi
			//   Il2CppClass *v127; // rax
			//   bool v128; // al
			//   SettingParameter_1_System_Boolean_ *farCloudEnableTAA; // rsi
			//   struct MethodInfo *v130; // rdi
			//   Il2CppClass *v131; // rax
			//   bool v132; // al
			//   SettingParameter_1_System_Single_ *farCloudTAABlendRatio; // rdi
			//   struct MethodInfo *v134; // rsi
			//   Il2CppClass *v135; // rax
			//   bool v136; // al
			//   SettingParameter_1_System_Single_ *farCloudMarchStepScale; // rsi
			//   struct MethodInfo *v138; // rdi
			//   Il2CppClass *v139; // rax
			//   SettingParameter_1_System_Single_ *v140; // rbx
			//   struct MethodInfo *v141; // rdi
			//   Il2CppClass *v142; // rax
			//   Il2CppClass *v143; // rcx
			//   float v144; // xmm2_4
			//   __m128 v145; // xmm1
			//   __int128 v146; // xmm0
			//   float farCloudEmptySkipSizeScale; // eax
			//   __int128 v148; // xmm1
			//   __int128 v149; // xmm0
			//   __int128 v150; // xmm1
			//   __int128 v151; // xmm0
			//   __int128 v152; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGVolumetricQualitySettings *v155; // rax
			//   __int128 v156; // xmm1
			//   __int128 v157; // xmm0
			//   __int128 v158; // xmm1
			//   __int128 v159; // xmm0
			//   __int128 v160; // xmm1
			//   __int128 v161; // xmm0
			//   __int128 v162; // xmm1
			//   __int64 v163; // rax
			//   __int64 v164; // rdx
			//   __int64 v165; // rax
			//   __int64 v166; // rax
			//   __int64 v167; // rdx
			//   __int64 v168; // r8
			//   __int64 v169; // rax
			//   __int64 v170; // rax
			//   __int64 v171; // rax
			//   __int64 v172; // rax
			//   __int64 v173; // rax
			//   __int64 v174; // rax
			//   __int64 v175; // rax
			//   __int64 v176; // rax
			//   __int64 v177; // rax
			//   __int64 v178; // rax
			//   __int64 v179; // rax
			//   __int64 v180; // rax
			//   __int64 v181; // rax
			//   __int64 v182; // rax
			//   __int64 v183; // rax
			//   __int64 v184; // rax
			//   __int64 v185; // rax
			//   __int64 v186; // rax
			//   __int64 v187; // rax
			//   __int64 v188; // rax
			//   __int64 v189; // rax
			//   __int64 v190; // rax
			//   __int64 v191; // rax
			//   __int64 v192; // rax
			//   __int64 v193; // rax
			//   __int64 v194; // rax
			//   __int64 v195; // rax
			//   __int64 v196; // rax
			//   __int64 v197; // rax
			//   __int64 v198; // rax
			//   __int64 v199; // rax
			//   __int128 v200; // [rsp+20h] [rbp-E0h]
			//   int v201; // [rsp+30h] [rbp-D0h]
			//   __int128 v202; // [rsp+40h] [rbp-C0h]
			//   __int128 v203; // [rsp+50h] [rbp-B0h]
			//   __int128 v204; // [rsp+60h] [rbp-A0h]
			//   __int128 v205; // [rsp+70h] [rbp-90h]
			//   __int128 v206; // [rsp+80h] [rbp-80h]
			//   unsigned __int64 v207; // [rsp+90h] [rbp-70h]
			//   HGVolumetricQualitySettings v208; // [rsp+A0h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D8EDBB3 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFramingQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFarCloudFramingQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D8EDBB3 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, volumetricParameters);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_261;
			//   if ( wrapperArray.max_length.size <= 1032 )
			//     goto LABEL_9;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_261:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x408 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[22]._0.name )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1032, 0LL);
			//     if ( Patch )
			//     {
			//       v155 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_371(&v208, Patch, (Object *)volumetricParameters, 0LL);
			//       v156 = *(_OWORD *)&v155.framingQualityPack.framingLevel;
			//       *(_OWORD *)&retstr.downResQualityPack.enableDownRes = *(_OWORD *)&v155.downResQualityPack.enableDownRes;
			//       v157 = *(_OWORD *)&v155.taaQualityPack.enableTAA;
			//       *(_OWORD *)&retstr.framingQualityPack.framingLevel = v156;
			//       v158 = *(_OWORD *)&v155.cloudQualityPack.godRayStepScale;
			//       *(_OWORD *)&retstr.taaQualityPack.enableTAA = v157;
			//       v159 = *(_OWORD *)&v155.cloudQualityPack.enableFarCloud;
			//       *(_OWORD *)&retstr.cloudQualityPack.godRayStepScale = v158;
			//       v160 = *(_OWORD *)&v155.cloudQualityPack.octahedronHeightScale;
			//       *(_OWORD *)&retstr.cloudQualityPack.enableFarCloud = v159;
			//       v161 = *(_OWORD *)&v155.cloudQualityPack.semicircularSize;
			//       *(_OWORD *)&retstr.cloudQualityPack.octahedronHeightScale = v160;
			//       v162 = *(_OWORD *)&v155.cloudQualityPack.farCloudFramingCubicSample;
			//       farCloudEmptySkipSizeScale = v155.cloudQualityPack.farCloudEmptySkipSizeScale;
			//       *(_OWORD *)&retstr.cloudQualityPack.semicircularSize = v161;
			//       *(_OWORD *)&retstr.cloudQualityPack.farCloudFramingCubicSample = v162;
			//       goto LABEL_260;
			//     }
			//     goto LABEL_261;
			//   }
			// LABEL_9:
			//   v7 = UnityEngine::SystemInfo::SupportsCubicFilter(0LL);
			//   LODWORD(v200) = 0;
			//   if ( !volumetricParameters )
			//     goto LABEL_261;
			//   enableDownRes = volumetricParameters.fields.enableDownRes;
			//   v9 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !enableDownRes )
			//     goto LABEL_261;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v163 = sub_18010B520(v9.klass);
			//     (**(void (__fastcall ***)(_QWORD, __int64))(*(_QWORD *)(v163 + 192) + 48LL))(*(_QWORD *)(v163 + 192), v164);
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   paramValue_k__BackingField = enableDownRes.fields._paramValue_k__BackingField;
			//   downResRatio = volumetricParameters.fields.downResRatio;
			//   v13 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   LOBYTE(v200) = paramValue_k__BackingField;
			//   if ( !downResRatio )
			//     goto LABEL_261;
			//   v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v14.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v14.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v165 = sub_18010B520(v13.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v165 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v13.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   downResFilter = volumetricParameters.fields.downResFilter;
			//   DWORD1(v200) = LODWORD(downResRatio.fields._paramValue_k__BackingField);
			//   if ( !downResFilter )
			//     goto LABEL_261;
			//   enableFraming = volumetricParameters.fields.enableFraming;
			//   v17 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   v208.downResQualityPack.downResFilter = downResFilter.fields._paramValue_k__BackingField;
			//   *(_QWORD *)&v208.downResQualityPack.enableDownRes = v200;
			//   v201 = 0;
			//   LODWORD(v200) = 0;
			//   if ( !enableFraming )
			//     goto LABEL_261;
			//   v18 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v18.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v18.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v166 = sub_18010B520(v17.klass);
			//     (**(void (__fastcall ***)(_QWORD, __int64, __int64))(*(_QWORD *)(v166 + 192) + 48LL))(
			//       *(_QWORD *)(v166 + 192),
			//       v167,
			//       v168);
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v17.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   LOBYTE(v200) = enableFraming.fields._paramValue_k__BackingField;
			//   framingLevel = volumetricParameters.fields.framingLevel;
			//   if ( !framingLevel )
			//     goto LABEL_261;
			//   framingComposeRatio = volumetricParameters.fields.framingComposeRatio;
			//   v21 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   DWORD1(v200) = framingLevel.fields._paramValue_k__BackingField;
			//   if ( !framingComposeRatio )
			//     goto LABEL_261;
			//   v22 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v22.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v22.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v169 = sub_18010B520(v21.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v169 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v21.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   DWORD2(v200) = LODWORD(framingComposeRatio.fields._paramValue_k__BackingField);
			//   v23 = v7
			//      && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           volumetricParameters.fields.enableFramingCubicSample,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   enableFramingMotionVector = volumetricParameters.fields.enableFramingMotionVector;
			//   v25 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE12(v200) = v23;
			//   if ( !enableFramingMotionVector )
			//     goto LABEL_261;
			//   v26 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v26.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v26.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v170 = sub_18010B520(v25.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v170 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v25.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v27 = enableFramingMotionVector.fields._paramValue_k__BackingField;
			//   enableFramingDepthOpt = volumetricParameters.fields.enableFramingDepthOpt;
			//   v29 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE13(v200) = v27;
			//   if ( !enableFramingDepthOpt )
			//     goto LABEL_261;
			//   v30 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v30.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v30.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v171 = sub_18010B520(v29.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v171 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v29.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v31 = enableFramingDepthOpt.fields._paramValue_k__BackingField;
			//   enableFramingColorAABB = volumetricParameters.fields.enableFramingColorAABB;
			//   v33 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE14(v200) = v31;
			//   if ( !enableFramingColorAABB )
			//     goto LABEL_261;
			//   v34 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v34.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v34.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v172 = sub_18010B520(v33.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v172 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v33.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v35 = enableFramingColorAABB.fields._paramValue_k__BackingField;
			//   enableFramingNeighborAvg = volumetricParameters.fields.enableFramingNeighborAvg;
			//   v37 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   HIBYTE(v200) = v35;
			//   if ( !enableFramingNeighborAvg )
			//     goto LABEL_261;
			//   v38 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v38.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v38.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v173 = sub_18010B520(v37.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v173 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v37.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v39 = enableFramingNeighborAvg.fields._paramValue_k__BackingField;
			//   v40 = v200;
			//   enableTAA = volumetricParameters.fields.enableTAA;
			//   v42 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   LOBYTE(v201) = v39;
			//   *(_DWORD *)&v208.framingQualityPack.enableFramingNeighborAvg = v201;
			//   WORD3(v200) = 0;
			//   *(_OWORD *)&v208.framingQualityPack.enableFraming = v40;
			//   if ( !enableTAA )
			//     goto LABEL_261;
			//   v43 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v43.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v43.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v174 = sub_18010B520(v42.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v174 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v42.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   LOBYTE(v200) = enableTAA.fields._paramValue_k__BackingField;
			//   v44 = v7
			//      && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           volumetricParameters.fields.enableTAACubicSample,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   enableTAAMotionVector = volumetricParameters.fields.enableTAAMotionVector;
			//   v46 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE1(v200) = v44;
			//   if ( !enableTAAMotionVector )
			//     goto LABEL_261;
			//   v47 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v47.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v47.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v175 = sub_18010B520(v46.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v175 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v46.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v48 = enableTAAMotionVector.fields._paramValue_k__BackingField;
			//   enableTAADepthOpt = volumetricParameters.fields.enableTAADepthOpt;
			//   v50 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE2(v200) = v48;
			//   if ( !enableTAADepthOpt )
			//     goto LABEL_261;
			//   v51 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v51.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v51.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v176 = sub_18010B520(v50.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v176 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v50.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v52 = enableTAADepthOpt.fields._paramValue_k__BackingField;
			//   enableTAAColorAABB = volumetricParameters.fields.enableTAAColorAABB;
			//   v54 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE3(v200) = v52;
			//   if ( !enableTAAColorAABB )
			//     goto LABEL_261;
			//   v55 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v55.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v55.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v177 = sub_18010B520(v54.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v177 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v54.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v56 = enableTAAColorAABB.fields._paramValue_k__BackingField;
			//   enableTAANeighborAvg = volumetricParameters.fields.enableTAANeighborAvg;
			//   v58 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE4(v200) = v56;
			//   if ( !enableTAANeighborAvg )
			//     goto LABEL_261;
			//   v59 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v59.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v59.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v178 = sub_18010B520(v58.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v178 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v58.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v60 = enableTAANeighborAvg.fields._paramValue_k__BackingField;
			//   invalidDepthBlendRatio = volumetricParameters.fields.invalidDepthBlendRatio;
			//   v62 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   BYTE5(v200) = v60;
			//   if ( !invalidDepthBlendRatio )
			//     goto LABEL_261;
			//   v63 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v63.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v63.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v179 = sub_18010B520(v62.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v179 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v62.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v64 = invalidDepthBlendRatio.fields._paramValue_k__BackingField;
			//   marchStepScale = volumetricParameters.fields.marchStepScale;
			//   v66 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   *(_QWORD *)&v208.taaQualityPack.enableTAA = v200;
			//   v208.taaQualityPack.invalidDepthBlendRatio = v64;
			//   HIDWORD(v207) = 0;
			//   DWORD1(v203) = 0;
			//   v204 = 0LL;
			//   v206 = 0LL;
			//   if ( !marchStepScale )
			//     goto LABEL_261;
			//   v67 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v67.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v67.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v180 = sub_18010B520(v66.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v180 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v66.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v68 = marchStepScale.fields._paramValue_k__BackingField;
			//   godRayStepScale = volumetricParameters.fields.godRayStepScale;
			//   v70 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   *(float *)&v202 = v68;
			//   if ( !godRayStepScale )
			//     goto LABEL_261;
			//   v71 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v71.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v71.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v181 = sub_18010B520(v70.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v181 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v70.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v72 = godRayStepScale.fields._paramValue_k__BackingField;
			//   emptySkipSizeScale = volumetricParameters.fields.emptySkipSizeScale;
			//   v74 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   *((float *)&v202 + 1) = v72;
			//   if ( !emptySkipSizeScale )
			//     goto LABEL_261;
			//   v75 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v75.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v75.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v182 = sub_18010B520(v74.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v182 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v74.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v76 = emptySkipSizeScale.fields._paramValue_k__BackingField;
			//   dynamicStepRange = volumetricParameters.fields.dynamicStepRange;
			//   v78 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   *((float *)&v202 + 2) = v76;
			//   if ( !dynamicStepRange )
			//     goto LABEL_261;
			//   v79 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v79.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v79.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v183 = sub_18010B520(v78.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v183 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v78.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v80 = dynamicStepRange.fields._paramValue_k__BackingField;
			//   dynamicStepScale = volumetricParameters.fields.dynamicStepScale;
			//   v82 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   *((float *)&v202 + 3) = v80;
			//   if ( !dynamicStepScale )
			//     goto LABEL_261;
			//   v83 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v83.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v83.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v184 = sub_18010B520(v82.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v184 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v82.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v84 = dynamicStepScale.fields._paramValue_k__BackingField;
			//   enableFarCloud = volumetricParameters.fields.enableFarCloud;
			//   v86 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   *(float *)&v203 = v84;
			//   if ( !enableFarCloud )
			//     goto LABEL_261;
			//   v87 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v87.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v87.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v185 = sub_18010B520(v86.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v185 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v86.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v88 = enableFarCloud.fields._paramValue_k__BackingField;
			//   panoramicSizeX = volumetricParameters.fields.panoramicSizeX;
			//   v90 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   BYTE4(v203) = v88;
			//   if ( !panoramicSizeX )
			//     goto LABEL_261;
			//   v91 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v91.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v91.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v186 = sub_18010B520(v90.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v186 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v90.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v92 = panoramicSizeX.fields._paramValue_k__BackingField;
			//   panoramicSizeY = volumetricParameters.fields.panoramicSizeY;
			//   v94 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   DWORD2(v203) = v92;
			//   if ( !panoramicSizeY )
			//     goto LABEL_261;
			//   v95 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v95.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v95.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v187 = sub_18010B520(v94.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v187 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v94.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v96 = panoramicSizeY.fields._paramValue_k__BackingField;
			//   octahedronSize = volumetricParameters.fields.octahedronSize;
			//   v98 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   HIDWORD(v203) = v96;
			//   if ( !octahedronSize )
			//     goto LABEL_261;
			//   v99 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v99.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v99.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v188 = sub_18010B520(v98.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v188 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v98.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v100 = octahedronSize.fields._paramValue_k__BackingField;
			//   octahedronHeightScale = volumetricParameters.fields.octahedronHeightScale;
			//   v102 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   LODWORD(v204) = v100;
			//   if ( !octahedronHeightScale )
			//     goto LABEL_261;
			//   v103 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v103.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v103.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v189 = sub_18010B520(v102.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v189 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v102.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v104 = octahedronHeightScale.fields._paramValue_k__BackingField;
			//   octahedronEnableSlicing = volumetricParameters.fields.octahedronEnableSlicing;
			//   v106 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   *((float *)&v204 + 1) = v104;
			//   if ( !octahedronEnableSlicing )
			//     goto LABEL_261;
			//   v107 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v107.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v107.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v190 = sub_18010B520(v106.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v190 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v106.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v108 = octahedronEnableSlicing.fields._paramValue_k__BackingField;
			//   octahedronSlicingCountX = volumetricParameters.fields.octahedronSlicingCountX;
			//   v110 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   BYTE8(v204) = v108;
			//   if ( !octahedronSlicingCountX )
			//     goto LABEL_261;
			//   v111 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v111.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v111.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v191 = sub_18010B520(v110.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v191 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v110.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v112 = octahedronSlicingCountX.fields._paramValue_k__BackingField;
			//   octahedronSlicingCountY = volumetricParameters.fields.octahedronSlicingCountY;
			//   v114 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   HIDWORD(v204) = v112;
			//   if ( !octahedronSlicingCountY )
			//     goto LABEL_261;
			//   v115 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v115.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v115.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v192 = sub_18010B520(v114.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v192 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v114.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v116 = octahedronSlicingCountY.fields._paramValue_k__BackingField;
			//   semicircularSize = volumetricParameters.fields.semicircularSize;
			//   v118 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   LODWORD(v205) = v116;
			//   if ( !semicircularSize )
			//     goto LABEL_261;
			//   v119 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v119.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v119.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v193 = sub_18010B520(v118.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v193 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v118.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v120 = semicircularSize.fields._paramValue_k__BackingField;
			//   semicircularZScale = volumetricParameters.fields.semicircularZScale;
			//   v122 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   DWORD1(v205) = v120;
			//   if ( !semicircularZScale )
			//     goto LABEL_261;
			//   v123 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v123.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v123.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v194 = sub_18010B520(v122.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v194 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v122.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   farCloudFramingLevel = volumetricParameters.fields.farCloudFramingLevel;
			//   DWORD2(v205) = LODWORD(semicircularZScale.fields._paramValue_k__BackingField);
			//   if ( !farCloudFramingLevel )
			//     goto LABEL_261;
			//   farCloudFramingComposeRatio = volumetricParameters.fields.farCloudFramingComposeRatio;
			//   v126 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   HIDWORD(v205) = farCloudFramingLevel.fields._paramValue_k__BackingField;
			//   if ( !farCloudFramingComposeRatio )
			//     goto LABEL_261;
			//   v127 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v127.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v127.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v195 = sub_18010B520(v126.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v195 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v126.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   *(float *)&v206 = farCloudFramingComposeRatio.fields._paramValue_k__BackingField;
			//   v128 = v7
			//       && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            volumetricParameters.fields.farCloudFramingCubicSample,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   farCloudEnableTAA = volumetricParameters.fields.farCloudEnableTAA;
			//   v130 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   BYTE4(v206) = v128;
			//   if ( !farCloudEnableTAA )
			//     goto LABEL_261;
			//   v131 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)v131.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v131.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v196 = sub_18010B520(v130.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v196 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v130.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v132 = farCloudEnableTAA.fields._paramValue_k__BackingField;
			//   farCloudTAABlendRatio = volumetricParameters.fields.farCloudTAABlendRatio;
			//   v134 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   BYTE5(v206) = v132;
			//   if ( !farCloudTAABlendRatio )
			//     goto LABEL_261;
			//   v135 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v135.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v135.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v197 = sub_18010B520(v134.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v197 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v134.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   DWORD2(v206) = LODWORD(farCloudTAABlendRatio.fields._paramValue_k__BackingField);
			//   v136 = v7
			//       && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            volumetricParameters.fields.farCloudTAACubicSample,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   farCloudMarchStepScale = volumetricParameters.fields.farCloudMarchStepScale;
			//   v138 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   BYTE12(v206) = v136;
			//   if ( !farCloudMarchStepScale )
			//     goto LABEL_261;
			//   v139 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v139.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v139.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v198 = sub_18010B520(v138.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v198 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v138.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   v140 = volumetricParameters.fields.farCloudEmptySkipSizeScale;
			//   v141 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
			//   *(float *)&v207 = farCloudMarchStepScale.fields._paramValue_k__BackingField;
			//   if ( !v140 )
			//     goto LABEL_261;
			//   v142 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass;
			//   if ( ((__int64)v142.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v142.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v199 = sub_18010B520(v141.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v199 + 192) + 48LL))();
			//   }
			//   v143 = v141.klass;
			//   if ( ((__int64)v143.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v143);
			//   v144 = v140.fields._paramValue_k__BackingField;
			//   *(_OWORD *)&v208.cloudQualityPack.dynamicStepScale = v203;
			//   *(_OWORD *)&v208.cloudQualityPack.octahedronSlicingCountY = v205;
			//   *(_OWORD *)&v208.cloudQualityPack.marchStepScale = v202;
			//   v145 = _mm_shuffle_ps((__m128)v207, (__m128)v207, 225);
			//   *(_OWORD *)&v208.cloudQualityPack.octahedronSize = v204;
			//   v145.m128_f32[0] = v144;
			//   *(_OWORD *)&v208.cloudQualityPack.farCloudFramingComposeRatio = v206;
			//   *(_OWORD *)&retstr.downResQualityPack.enableDownRes = *(_OWORD *)&v208.downResQualityPack.enableDownRes;
			//   v146 = *(_OWORD *)&v208.taaQualityPack.enableTAA;
			//   *(_QWORD *)&v208.cloudQualityPack.farCloudMarchStepScale = _mm_shuffle_ps(v145, v145, 225).m128_u64[0];
			//   farCloudEmptySkipSizeScale = v208.cloudQualityPack.farCloudEmptySkipSizeScale;
			//   *(_OWORD *)&retstr.framingQualityPack.framingLevel = *(_OWORD *)&v208.framingQualityPack.framingLevel;
			//   v148 = *(_OWORD *)&v208.cloudQualityPack.godRayStepScale;
			//   *(_OWORD *)&retstr.taaQualityPack.enableTAA = v146;
			//   v149 = *(_OWORD *)&v208.cloudQualityPack.enableFarCloud;
			//   *(_OWORD *)&retstr.cloudQualityPack.godRayStepScale = v148;
			//   v150 = *(_OWORD *)&v208.cloudQualityPack.octahedronHeightScale;
			//   *(_OWORD *)&retstr.cloudQualityPack.enableFarCloud = v149;
			//   v151 = *(_OWORD *)&v208.cloudQualityPack.semicircularSize;
			//   *(_OWORD *)&retstr.cloudQualityPack.octahedronHeightScale = v150;
			//   v152 = *(_OWORD *)&v208.cloudQualityPack.farCloudFramingCubicSample;
			//   *(_OWORD *)&retstr.cloudQualityPack.semicircularSize = v151;
			//   *(_OWORD *)&retstr.cloudQualityPack.farCloudFramingCubicSample = v152;
			// LABEL_260:
			//   retstr.cloudQualityPack.farCloudEmptySkipSizeScale = farCloudEmptySkipSizeScale;
			//   return retstr;
			// }
			// 
			return null;
		}

		private bool m_EnableFraming;

		private bool m_EnableTAA;

		private bool m_CanMergeTAAPass;

		private bool m_BeforeTAANeedDepthTest;

		private bool m_AfterTAANeedDepthTest;

		private List<VolumetricRenderer.VolumetricRenderNode> m_RenderNodes;

		private Dictionary<EVolumetricStage, VolumetricRenderer.VolumetricRenderStage> m_RenderStages;

		private EVolumetricState m_VolumetricState;

		private float m_VolumetricFadeRatio;

		private Material m_VolumetricMat;

		private MaterialPropertyBlock m_PropertyBlock;

		private Vector3 PrevCameraPos;

		private int m_RenderWidth;

		private int m_RenderHeight;

		private int m_FramingWidth;

		private int m_FramingHeight;

		private int m_ReconstructIndex;

		private int m_TAAIndex;

		private VolumetricPipelineRT[] m_MinMaxWorldDepths;

		private VolumetricPipelineRT m_DepthForTest;

		private VolumetricPipelineRT m_FramingColor;

		private VolumetricPipelineRT m_FramingDepth;

		private VolumetricPipelineRT[] m_ReconstructColors;

		private VolumetricPipelineRT[] m_ReconstructDepths;

		private VolumetricPipelineRT m_ComposeColor;

		private VolumetricPipelineRT m_ComposeDepth;

		private VolumetricPipelineRT[] m_TAAColors;

		private VolumetricPipelineRT[] m_TAADepths;

		private int m_RTIndex;

		private Vector4 m_DownscaledScreenParams;

		private Vector2 m_NDCRescaleParams;

		private List<VolumetricRenderer.VolumetricRenderNode> renderNodePool;

		private int renderNodePoolIndex;

		private Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> framingCompose;

		private Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> temporalCompose;

		private List<VolumetricRenderer.VolumetricRenderItem> _itemCache;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct VolumetricCallbackContext
		{
			public CommandBuffer Cmd;

			public bool bFirstInPass;

			public bool bEnableDownScale;

			public bool bEnableFraming;

			public bool bEnableTAA;

			public EVolumetricStage Stage;

			public VolumetricPipelineRT SrcColor;

			public VolumetricPipelineRT SrcDepths;

			public VolumetricPipelineRT DstColor;

			public VolumetricPipelineRT DstDepths;

			public MeshFilter meshFilter;

			public MeshRenderer meshRenderer;

			public Material MSBakeMaterial;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct VolumetricComposeContext
		{
			public bool bEnableFraming;

			public bool bEnableTAA;

			public Material volumetricComposeMaterial;

			public HGVolumetricCloudSettingParameters volumetricSettings;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28)]
		public struct VolumetricBounds
		{
			public VolumetricBounds(bool _enable, Bounds _worldBounds = null)
			{
				// // VolumetricRenderer+VolumetricBounds(Boolean, Bounds)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricBounds::VolumetricBounds(
				//         VolumetricRenderer_VolumetricBounds *this,
				//         bool _enable,
				//         Bounds *_worldBounds,
				//         MethodInfo *method)
				// {
				//   __int128 v4; // xmm0
				//   __int64 v5; // xmm1_8
				// 
				//   v4 = *(_OWORD *)&_worldBounds.m_Center.x;
				//   this.enableBounds = _enable;
				//   v5 = *(_QWORD *)&_worldBounds.m_Extents.y;
				//   *(_OWORD *)&this.worldBounds.m_Center.x = v4;
				//   *(_QWORD *)&this.worldBounds.m_Extents.y = v5;
				// }
				// 
			}

			public bool enableBounds;

			public Bounds worldBounds;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct VolumetricRenderItem
		{
			public VolumetricRenderItem(Action<VolumetricRenderer.VolumetricCallbackContext> _callback, VolumetricRenderer.VolumetricBounds _bounds, Material _material = null, [MetadataOffset(Offset = "0x01F91D78")] bool _enableFraming = false, [MetadataOffset(Offset = "0x01F91D79")] bool _enableTAA = false, [MetadataOffset(Offset = "0x01F91D7A")] int _sortingOrder = 0, [MetadataOffset(Offset = "0x01F91D7B")] int _renderQueue = 3000, [MetadataOffset(Offset = "0x01F91D7D")] float _distToCamera = 99999f, [MetadataOffset(Offset = "0x01F91D81")] int _composePriority = 0, [MetadataOffset(Offset = "0x01F91D82")] bool _pureBlit = true, [MetadataOffset(Offset = "0x01F91D83")] bool _fullScreen = false)
			{
			}

			public bool CheckVisibility(Camera camera)
			{
				// // Boolean CheckVisibility(Camera)
				// bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::CheckVisibility(
				//         VolumetricRenderer_VolumetricRenderItem *this,
				//         Camera *camera,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // r8
				//   __int64 v6; // r9
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				//   Plane__Array *v10; // rsi
				//   float fieldOfView; // xmm7_4
				//   float aspect; // xmm6_4
				//   float v13; // xmm0_4
				//   Matrix4x4 *v14; // rax
				//   __int128 v15; // xmm6
				//   __int128 v16; // xmm7
				//   __int128 v17; // xmm8
				//   __int128 v18; // xmm9
				//   Matrix4x4 *worldToCameraMatrix; // rax
				//   __int128 v20; // xmm1
				//   __int128 v21; // xmm0
				//   __int128 v22; // xmm1
				//   Matrix4x4 *v23; // rax
				//   __int128 v24; // xmm1
				//   __int128 v25; // xmm0
				//   __int128 v26; // xmm1
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Matrix4x4 v28; // [rsp+38h] [rbp-D0h] BYREF
				//   Bounds v29; // [rsp+78h] [rbp-90h] BYREF
				//   Matrix4x4 v30; // [rsp+98h] [rbp-70h] BYREF
				//   Matrix4x4 v31[2]; // [rsp+D8h] [rbp-30h] BYREF
				// 
				//   if ( !byte_18D9197D0 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Plane);
				//     byte_18D9197D0 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4484, 0LL) )
				//   {
				//     if ( !this.bounds.enableBounds )
				//       return 1;
				//     v10 = (Plane__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Plane, 6LL, v5, v6);
				//     if ( camera )
				//     {
				//       fieldOfView = UnityEngine::Camera::get_fieldOfView(camera, 0LL);
				//       aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
				//       v13 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
				//       v14 = UnityEngine::Matrix4x4::Perspective(&v30, fieldOfView, aspect, v13, 10000.0, 0LL);
				//       v15 = *(_OWORD *)&v14.m00;
				//       v16 = *(_OWORD *)&v14.m01;
				//       v17 = *(_OWORD *)&v14.m02;
				//       v18 = *(_OWORD *)&v14.m03;
				//       worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v30, camera, 0LL);
				//       v20 = *(_OWORD *)&worldToCameraMatrix.m01;
				//       *(_OWORD *)&v28.m00 = *(_OWORD *)&worldToCameraMatrix.m00;
				//       v21 = *(_OWORD *)&worldToCameraMatrix.m02;
				//       *(_OWORD *)&v28.m01 = v20;
				//       v22 = *(_OWORD *)&worldToCameraMatrix.m03;
				//       *(_OWORD *)&v28.m02 = v21;
				//       *(_OWORD *)&v28.m03 = v22;
				//       *(_OWORD *)&v30.m00 = v15;
				//       *(_OWORD *)&v30.m01 = v16;
				//       *(_OWORD *)&v30.m02 = v17;
				//       *(_OWORD *)&v30.m03 = v18;
				//       v23 = UnityEngine::Matrix4x4::op_Multiply(v31, &v30, &v28, 0LL);
				//       v24 = *(_OWORD *)&v23.m01;
				//       *(_OWORD *)&v28.m00 = *(_OWORD *)&v23.m00;
				//       v25 = *(_OWORD *)&v23.m02;
				//       *(_OWORD *)&v28.m01 = v24;
				//       v26 = *(_OWORD *)&v23.m03;
				//       *(_OWORD *)&v28.m02 = v25;
				//       *(_OWORD *)&v28.m03 = v26;
				//       UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v28, v10, 0LL);
				//       *(_QWORD *)&v26 = *(_QWORD *)&this.bounds.worldBounds.m_Extents.y;
				//       *(_OWORD *)&v29.m_Center.x = *(_OWORD *)&this.bounds.worldBounds.m_Center.x;
				//       *(_QWORD *)&v29.m_Extents.y = v26;
				//       return UnityEngine::GeometryUtility::TestPlanesAABB(v10, &v29, 0LL);
				//     }
				// LABEL_9:
				//     sub_180B536AC(v9, v8);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4484, 0LL);
				//   if ( !Patch )
				//     goto LABEL_9;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1287(Patch, this, (Object *)camera, 0LL);
				// }
				// 
				return default(bool);
			}

			public Action<VolumetricRenderer.VolumetricCallbackContext> Callback;

			public Material material;

			public VolumetricRenderer.VolumetricBounds bounds;

			public bool bEnableFraming;

			public bool bEnableTAA;

			public int SortingOrder;

			public int RenderQueue;

			public float DistToCamera;

			public int ComposePriority;

			public bool bPureBlit;

			public bool bFullScreen;

			public MeshRenderer meshRenderer;

			public MeshFilter meshFilter;
		}

		private class VolumetricRenderNode
		{
			// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000025D2 File Offset: 0x000007D2
			public Action<VolumetricRenderer.VolumetricCallbackContext> Callback
			{
				get
				{
					// // Action`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricCallbackContext] get_Callback()
					// Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_Callback(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D1 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D1 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4538, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4538, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1297(Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.Callback;
					//   }
					//   else
					//   {
					//     return 0LL;
					//   }
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x000025D2 File Offset: 0x000007D2
			public Material material
			{
				get
				{
					// // Material get_material()
					// Material *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D2 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D2 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4489, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4489, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_685(Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.material;
					//   }
					//   else
					//   {
					//     return 0LL;
					//   }
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000025D2 File Offset: 0x000007D2
			public MeshFilter meshFilter
			{
				get
				{
					// // MeshFilter get_meshFilter()
					// MeshFilter *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshFilter(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D3 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D3 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4539, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4539, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1298(Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.meshFilter;
					//   }
					//   else
					//   {
					//     return 0LL;
					//   }
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x000025D2 File Offset: 0x000007D2
			public MeshRenderer meshRenderer
			{
				get
				{
					// // MeshRenderer get_meshRenderer()
					// MeshRenderer *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshRenderer(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D4 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D4 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4540, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4540, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1299(Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.meshRenderer;
					//   }
					//   else
					//   {
					//     return 0LL;
					//   }
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x00002D88 File Offset: 0x00000F88
			public VolumetricRenderer.VolumetricBounds bounds
			{
				get
				{
					// // VolumetricRenderer+VolumetricBounds get_bounds()
					// VolumetricRenderer_VolumetricBounds *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bounds(
					//         VolumetricRenderer_VolumetricBounds *__return_ptr retstr,
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   __int128 v5; // xmm0
					//   float z; // eax
					//   __int64 v7; // xmm1_8
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v9; // rdx
					//   __int64 v10; // rcx
					//   VolumetricRenderer_VolumetricBounds *v11; // rax
					//   VolumetricRenderer_VolumetricBounds v13; // [rsp+20h] [rbp-88h] BYREF
					//   VolumetricRenderer_VolumetricRenderItem v14; // [rsp+40h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D5 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D5 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4541, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4541, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v10, v9);
					//     v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1300(&v13, Patch, (Object *)this, 0LL);
					//     v5 = *(_OWORD *)&v11.enableBounds;
					//     v7 = *(_QWORD *)&v11.worldBounds.m_Extents.x;
					//     z = v11.worldBounds.m_Extents.z;
					//     goto LABEL_10;
					//   }
					//   if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v14,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     v5 = *(_OWORD *)&v14.bounds.enableBounds;
					//     z = v14.bounds.worldBounds.m_Extents.z;
					//     v7 = *(_QWORD *)&v14.bounds.worldBounds.m_Extents.x;
					// LABEL_10:
					//     *(_OWORD *)&retstr.enableBounds = v5;
					//     *(_QWORD *)&retstr.worldBounds.m_Extents.x = v7;
					//     retstr.worldBounds.m_Extents.z = z;
					//     return retstr;
					//   }
					//   *(_QWORD *)&v13.worldBounds.m_Extents.x = 0LL;
					//   *(_WORD *)(&retstr.enableBounds + 1) = 0;
					//   *(&retstr.enableBounds + 3) = 0;
					//   *(_OWORD *)&retstr.worldBounds.m_Center.x = 0LL;
					//   retstr.enableBounds = 0;
					//   *(_QWORD *)&retstr.worldBounds.m_Extents.y = *(_QWORD *)&v13.worldBounds.m_Extents.x;
					//   return retstr;
					// }
					// 
					return default(VolumetricRenderer.VolumetricBounds);
				}
			}

			// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x000025D8 File Offset: 0x000007D8
			public bool bEnableFraming
			{
				get
				{
					// // Boolean get_bEnableFraming()
					// bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableFraming(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   bool result; // al
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D6 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D6 = 1;
					//   }
					//   result = IFix::WrappersManagerImpl::IsPatched(4487, 0LL);
					//   if ( result )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4487, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.bEnableFraming;
					//   }
					//   return result;
					// }
					// 
					return default(bool);
				}
			}

			// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000025D8 File Offset: 0x000007D8
			public bool bEnableTAA
			{
				get
				{
					// // Boolean get_bEnableTAA()
					// bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableTAA(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   bool result; // al
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D7 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D7 = 1;
					//   }
					//   result = IFix::WrappersManagerImpl::IsPatched(4488, 0LL);
					//   if ( result )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4488, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.bEnableTAA;
					//   }
					//   return result;
					// }
					// 
					return default(bool);
				}
			}

			// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00002608 File Offset: 0x00000808
			public int SortingOrder
			{
				get
				{
					// // Int32 get_SortingOrder()
					// int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D8 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D8 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4498, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4498, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.SortingOrder;
					//   }
					//   else
					//   {
					//     return 0;
					//   }
					// }
					// 
					return 0;
				}
			}

			// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00002608 File Offset: 0x00000808
			public int RenderQueue
			{
				get
				{
					// // Int32 get_RenderQueue()
					// int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197D9 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197D9 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4499, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4499, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.RenderQueue;
					//   }
					//   else
					//   {
					//     return 3000;
					//   }
					// }
					// 
					return 0;
				}
			}

			// (get) Token: 0x06001AFB RID: 6907 RVA: 0x000025F0 File Offset: 0x000007F0
			public float DistToCamera
			{
				get
				{
					// // Single get_DistToCamera()
					// float HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197DA )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197DA = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(4500, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4500, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.DistToCamera;
					//   }
					//   else
					//   {
					//     return 99999.0;
					//   }
					// }
					// 
					return 0f;
				}
			}

			// (get) Token: 0x06001AFC RID: 6908 RVA: 0x000025D8 File Offset: 0x000007D8
			public bool bFullScreen
			{
				get
				{
					// // Boolean get_bFullScreen()
					// bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
					//         VolumetricRenderer_VolumetricRenderNode *this,
					//         MethodInfo *method)
					// {
					//   bool result; // al
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
					// 
					//   if ( !byte_18D9197DB )
					//   {
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_HasValue);
					//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     byte_18D9197DB = 1;
					//   }
					//   result = IFix::WrappersManagerImpl::IsPatched(4514, 0LL);
					//   if ( result )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4514, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
					//   }
					//   else if ( this.fields.item.hasValue )
					//   {
					//     System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
					//       &v7,
					//       &this.fields.item,
					//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
					//     return v7.bFullScreen;
					//   }
					//   return result;
					// }
					// 
					return default(bool);
				}
			}

			// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000025D2 File Offset: 0x000007D2
			// (set) Token: 0x06001AFE RID: 6910 RVA: 0x000025D0 File Offset: 0x000007D0
			public IVolumetricRenderObject RenderObject
			{
				[CompilerGenerated]
				get
				{
					// // String get_propertyPath()
					// String *NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::get_propertyPath(
					//         Variable_1_UnityEngine_ContactPoint2D_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields._propertyPath;
					// }
					// 
					return null;
				}
				[CompilerGenerated]
				set
				{
					// // Void set_propertyPath(String)
					// void NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::set_propertyPath(
					//         Variable_1_UnityEngine_ContactPoint2D_ *this,
					//         String *value,
					//         MethodInfo *method)
					// {
					//   Material *v3; // r9
					//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
					//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
					//   int32_t v6; // [rsp+38h] [rbp+38h]
					//   int32_t v7; // [rsp+40h] [rbp+40h]
					//   float v8; // [rsp+48h] [rbp+48h]
					//   int32_t v9; // [rsp+50h] [rbp+50h]
					//   bool v10; // [rsp+58h] [rbp+58h]
					//   bool v11; // [rsp+60h] [rbp+60h]
					//   MethodInfo *v12; // [rsp+68h] [rbp+68h]
					// 
					//   this.fields._propertyPath = value;
					//   sub_1800054D0(
					//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields._propertyPath,
					//     (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)value,
					//     (VolumetricRenderer_VolumetricBounds *)method,
					//     v3,
					//     v4,
					//     v5,
					//     v6,
					//     v7,
					//     v8,
					//     v9,
					//     v10,
					//     v11,
					//     v12);
					// }
					// 
				}
			}

			// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x06001B00 RID: 6912 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool bComposePass
			{
				[CompilerGenerated]
				get
				{
					// // Boolean get_variableBind()
					// bool Beyond::Gameplay::Actions::Param<Beyond::Gameplay::AI::Config::NpcBehaviorTag>::get_variableBind(
					//         Param_1_Beyond_Gameplay_AI_Config_NpcBehaviorTag_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields.m_variableBind;
					// }
					// 
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
					// // Void set_variableBind(Boolean)
					// void Beyond::Gameplay::Actions::Param<Beyond::Gameplay::AI::Config::NpcBehaviorTag>::set_variableBind(
					//         Param_1_Beyond_Gameplay_AI_Config_NpcBehaviorTag_ *this,
					//         bool value,
					//         MethodInfo *method)
					// {
					//   this.fields.m_variableBind = value;
					// }
					// 
				}
			}

			// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000025D8 File Offset: 0x000007D8
			public bool IsAdded
			{
				get
				{
					// // Boolean get_exists()
					// bool FlowCanvas::Nodes::TryGetValue<UnityEngine::RaycastHit>::get_exists(
					//         TryGetValue_1_UnityEngine_RaycastHit_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields._exists_k__BackingField;
					// }
					// 
					return default(bool);
				}
			}

			public VolumetricRenderNode()
			{
				// // VolumetricRenderer+VolumetricRenderNode()
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::VolumetricRenderNode(
				//         VolumetricRenderer_VolumetricRenderNode *this,
				//         MethodInfo *method)
				// {
				//   this.fields.index = -1;
				// }
				// 
			}

			public void SetRenderItem(VolumetricRenderer.VolumetricRenderItem _item)
			{
				// // Void SetRenderItem(VolumetricRenderer+VolumetricRenderItem)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(
				//         VolumetricRenderer_VolumetricRenderNode *this,
				//         VolumetricRenderer_VolumetricRenderItem *_item,
				//         MethodInfo *method)
				// {
				//   __int128 v5; // xmm1
				//   __int128 v6; // xmm0
				//   __int128 v7; // xmm1
				//   __int128 v8; // xmm0
				//   __int128 v9; // xmm1
				//   __int128 v10; // xmm0
				//   __int128 v11; // xmm1
				//   __int128 v12; // xmm0
				//   __int128 v13; // xmm1
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rdx
				//   VolumetricRenderer_VolumetricBounds *v15; // r8
				//   Material *v16; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v18; // rdx
				//   __int64 v19; // rcx
				//   __int128 v20; // xmm1
				//   __int128 v21; // xmm0
				//   __int128 v22; // xmm1
				//   __int128 v23; // xmm0
				//   VolumetricRenderer_VolumetricRenderItem v24; // [rsp+20h] [rbp-69h] BYREF
				//   _OWORD v25[6]; // [rsp+80h] [rbp-9h] BYREF
				// 
				//   if ( !byte_18D9197DC )
				//   {
				//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Nullable);
				//     byte_18D9197DC = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(4485, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4485, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v19, v18);
				//     v20 = *(_OWORD *)&_item.bounds.enableBounds;
				//     *(_OWORD *)&v24.Callback = *(_OWORD *)&_item.Callback;
				//     v21 = *(_OWORD *)&_item.bounds.worldBounds.m_Extents.x;
				//     *(_OWORD *)&v24.bounds.enableBounds = v20;
				//     v22 = *(_OWORD *)&_item.SortingOrder;
				//     *(_OWORD *)&v24.bounds.worldBounds.m_Extents.x = v21;
				//     v23 = *(_OWORD *)&_item.bPureBlit;
				//     *(_OWORD *)&v24.SortingOrder = v22;
				//     *(_QWORD *)&v22 = _item.meshFilter;
				//     *(_OWORD *)&v24.bPureBlit = v23;
				//     v24.meshFilter = (MeshFilter *)v22;
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1288(Patch, (Object *)this, &v24, 0LL);
				//   }
				//   else
				//   {
				//     sub_1802F01E0(v25, 0LL, 96LL);
				//     v5 = *(_OWORD *)&_item.bounds.enableBounds;
				//     *(_OWORD *)&v24.Callback = *(_OWORD *)&_item.Callback;
				//     v6 = *(_OWORD *)&_item.bounds.worldBounds.m_Extents.x;
				//     *(_OWORD *)&v24.bounds.enableBounds = v5;
				//     v7 = *(_OWORD *)&_item.SortingOrder;
				//     *(_OWORD *)&v24.bounds.worldBounds.m_Extents.x = v6;
				//     v8 = *(_OWORD *)&_item.bPureBlit;
				//     *(_OWORD *)&v24.SortingOrder = v7;
				//     *(_QWORD *)&v7 = _item.meshFilter;
				//     *(_OWORD *)&v24.bPureBlit = v8;
				//     v24.meshFilter = (MeshFilter *)v7;
				//     sub_180642CC4(
				//       v25,
				//       &v24,
				//       MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Nullable);
				//     v9 = v25[1];
				//     *(_OWORD *)&this.fields.item.hasValue = v25[0];
				//     v10 = v25[2];
				//     *(_OWORD *)&this.fields.item.value.material = v9;
				//     v11 = v25[3];
				//     *(_OWORD *)&this.fields.item.value.bounds.worldBounds.m_Center.y = v10;
				//     v12 = v25[4];
				//     *(_OWORD *)&this.fields.item.value.bounds.worldBounds.m_Extents.z = v11;
				//     v13 = v25[5];
				//     *(_OWORD *)&this.fields.item.value.DistToCamera = v12;
				//     *(_OWORD *)&this.fields.item.value.meshRenderer = v13;
				//     sub_1800054D0(
				//       &this.fields.item.value,
				//       v14,
				//       v15,
				//       v16,
				//       (MethodInfo *)v24.Callback,
				//       (MethodInfo *)v24.material,
				//       *(int32_t *)&v24.bounds.enableBounds,
				//       SLODWORD(v24.bounds.worldBounds.m_Center.y),
				//       v24.bounds.worldBounds.m_Extents.x,
				//       SLODWORD(v24.bounds.worldBounds.m_Extents.z),
				//       v24.SortingOrder,
				//       SLOBYTE(v24.DistToCamera),
				//       *(MethodInfo **)&v24.bPureBlit);
				//   }
				// }
				// 
			}

			public void SetIndex(int _index)
			{
				// // Void SetIndex(Int32)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetIndex(
				//         VolumetricRenderer_VolumetricRenderNode *this,
				//         int32_t _index,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4501, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4501, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, _index, 0LL);
				//   }
				//   else
				//   {
				//     this.fields.index = _index;
				//   }
				// }
				// 
			}

			public void MarkAdd()
			{
				// // Void MarkAdd()
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::MarkAdd(
				//         VolumetricRenderer_VolumetricRenderNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4508, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4508, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     this.fields.bAdded = 1;
				//   }
				// }
				// 
			}

			public void Reset()
			{
				// // Void Reset()
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Reset(
				//         VolumetricRenderer_VolumetricRenderNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4476, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4476, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     sub_1802F01E0(&this.fields, 0LL, 96LL);
				//     *(_WORD *)&this.fields.bAdded = 0;
				//     this.fields.index = -1;
				//   }
				// }
				// 
			}

			public void Process(VolumetricRenderer.VolumetricCallbackContext context)
			{
				// // Void Process(VolumetricRenderer+VolumetricCallbackContext)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
				//         VolumetricRenderer_VolumetricRenderNode *this,
				//         VolumetricRenderer_VolumetricCallbackContext *context,
				//         MethodInfo *method)
				// {
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v5; // rdx
				//   VolumetricRenderer_VolumetricBounds *v6; // r8
				//   Material *v7; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
				//   VolumetricRenderer_VolumetricBounds *v9; // r8
				//   Material *v10; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *Callback; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   __int128 v14; // xmm1
				//   __int128 v15; // xmm0
				//   __int128 v16; // xmm1
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int128 v18; // xmm1
				//   __int128 v19; // xmm0
				//   __int128 v20; // xmm1
				//   VolumetricRenderer_VolumetricCallbackContext v21; // [rsp+20h] [rbp-50h] BYREF
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4542, 0LL) )
				//   {
				//     if ( this.fields.bProcessed )
				//       return;
				//     if ( !HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_Callback(this, 0LL) )
				//       goto LABEL_6;
				//     context.meshFilter = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshFilter(this, 0LL);
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&context.meshFilter,
				//       v5,
				//       v6,
				//       v7,
				//       (MethodInfo *)v21.Cmd,
				//       *(MethodInfo **)&v21.bFirstInPass,
				//       (int32_t)v21.SrcColor,
				//       (int32_t)v21.SrcDepths,
				//       *(float *)&v21.DstColor,
				//       (int32_t)v21.DstDepths,
				//       (bool)v21.meshFilter,
				//       (bool)v21.meshRenderer,
				//       (MethodInfo *)v21.MSBakeMaterial);
				//     context.meshRenderer = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshRenderer(
				//                               this,
				//                               0LL);
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&context.meshRenderer,
				//       v8,
				//       v9,
				//       v10,
				//       (MethodInfo *)v21.Cmd,
				//       *(MethodInfo **)&v21.bFirstInPass,
				//       (int32_t)v21.SrcColor,
				//       (int32_t)v21.SrcDepths,
				//       *(float *)&v21.DstColor,
				//       (int32_t)v21.DstDepths,
				//       (bool)v21.meshFilter,
				//       (bool)v21.meshRenderer,
				//       (MethodInfo *)v21.MSBakeMaterial);
				//     Callback = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_Callback(this, 0LL);
				//     if ( Callback )
				//     {
				//       v14 = *(_OWORD *)&context.SrcColor;
				//       *(_OWORD *)&v21.Cmd = *(_OWORD *)&context.Cmd;
				//       v15 = *(_OWORD *)&context.DstColor;
				//       *(_OWORD *)&v21.SrcColor = v14;
				//       v16 = *(_OWORD *)&context.meshFilter;
				//       *(_OWORD *)&v21.DstColor = v15;
				//       v21.MSBakeMaterial = context.MSBakeMaterial;
				//       *(_OWORD *)&v21.meshFilter = v16;
				//       System::Func<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL,UnityEngine::Vector2>::Invoke(
				//         (Func_2_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_UnityEngine_Vector2_ *)Callback,
				//         (prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL *)&v21,
				//         0LL);
				// LABEL_6:
				//       this.fields.bProcessed = 1;
				//       return;
				//     }
				// LABEL_8:
				//     sub_180B536AC(v13, v12);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4542, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   v18 = *(_OWORD *)&context.SrcColor;
				//   *(_OWORD *)&v21.Cmd = *(_OWORD *)&context.Cmd;
				//   v19 = *(_OWORD *)&context.DstColor;
				//   *(_OWORD *)&v21.SrcColor = v18;
				//   v20 = *(_OWORD *)&context.meshFilter;
				//   *(_OWORD *)&v21.DstColor = v19;
				//   v21.MSBakeMaterial = context.MSBakeMaterial;
				//   *(_OWORD *)&v21.meshFilter = v20;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1301(Patch, (Object *)this, &v21, 0LL);
				// }
				// 
			}

			public static int NodeCompare(VolumetricRenderer.VolumetricRenderNode l, VolumetricRenderer.VolumetricRenderNode r)
			{
				// // Int32 NodeCompare(VolumetricRenderer+VolumetricRenderNode, VolumetricRenderer+VolumetricRenderNode)
				// int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare(
				//         VolumetricRenderer_VolumetricRenderNode *l,
				//         VolumetricRenderer_VolumetricRenderNode *r,
				//         MethodInfo *method)
				// {
				//   float v3; // xmm2_4
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   int32_t SortingOrder; // ebx
				//   int32_t RenderQueue; // ebx
				//   float DistToCamera; // xmm1_4
				//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v11; // rcx
				//   int32_t result; // eax
				//   float v13; // xmm6_4
				//   float v14; // xmm0_4
				//   int32_t v15; // ebx
				//   int32_t v16; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4497, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4497, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
				//                (ILFixDynamicMethodWrapper_17 *)Patch,
				//                (Object *)l,
				//                (Object *)r,
				//                0LL);
				// LABEL_15:
				//     sub_180B536AC(v7, v6);
				//   }
				//   if ( !l )
				//     goto LABEL_15;
				//   SortingOrder = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(l, 0LL);
				//   if ( !r )
				//     goto LABEL_15;
				//   if ( SortingOrder != HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(r, 0LL) )
				//   {
				//     v15 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(l, 0LL);
				//     v16 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(r, 0LL);
				//     return v15 - v16;
				//   }
				//   RenderQueue = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(l, 0LL);
				//   if ( RenderQueue != HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(r, 0LL) )
				//   {
				//     v15 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(l, 0LL);
				//     v16 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(r, 0LL);
				//     return v15 - v16;
				//   }
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(l, 0LL);
				//   DistToCamera = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(r, 0LL);
				//   if ( (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
				//                           v11,
				//                           DistToCamera,
				//                           v3) )
				//     return l.fields.index - r.fields.index;
				//   v13 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(l, 0LL);
				//   v14 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(r, 0LL);
				//   result = 1;
				//   if ( v13 > v14 )
				//     return -1;
				//   return result;
				// }
				// 
				return 0;
			}

			private Nullable<VolumetricRenderer.VolumetricRenderItem> item;

			private bool bAdded;

			private bool bProcessed;

			private int index;
		}

		private abstract class VolumetricRenderStage
		{
			// (get) Token: 0x06001B09 RID: 6921 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x06001B0A RID: 6922 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool Enabled
			{
				[CompilerGenerated]
				get
				{
					// // Boolean get_autoTriggerEvent()
					// bool Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_autoTriggerEvent(
					//         ValueWatcher_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields.jfwTQnAbUjPonSNJeDchTULdikzO;
					// }
					// 
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
					// // Void set_autoTriggerEvent(Boolean)
					// void Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::set_autoTriggerEvent(
					//         ValueWatcher_1_System_Object_ *this,
					//         bool value,
					//         MethodInfo *method)
					// {
					//   this.fields.jfwTQnAbUjPonSNJeDchTULdikzO = value;
					// }
					// 
				}
			}

			// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000025D2 File Offset: 0x000007D2
			public List<VolumetricRenderer.VolumetricRenderNode> RenderNodes
			{
				get
				{
					// // List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderNode] get_RenderNodes()
					// List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
					//         VolumetricRenderer_VolumetricRenderStage *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					// 
					//   if ( !IFix::WrappersManagerImpl::IsPatched(4510, 0LL) )
					//     return this.fields.renderNodes;
					//   Patch = IFix::WrappersManagerImpl::GetPatch(4510, 0LL);
					//   if ( !Patch )
					//     sub_180B536AC(v6, v5);
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1290(Patch, (Object *)this, 0LL);
					// }
					// 
					return null;
				}
			}

			public VolumetricRenderStage(EVolumetricStage inStage)
			{
			}

			public void Reset()
			{
				// // Void Reset()
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
				//         VolumetricRenderer_VolumetricRenderStage *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodes; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9197DD )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Clear);
				//     byte_18D9197DD = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4504, 0LL) )
				//   {
				//     renderNodes = this.fields.renderNodes;
				//     this.fields._Enabled_k__BackingField = 0;
				//     if ( renderNodes )
				//     {
				//       sub_1823B99D0(
				//         renderNodes,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Clear);
				//       return;
				//     }
				// LABEL_7:
				//     sub_180B536AC(renderNodes, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4504, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			public void SetEnable()
			{
				// // Void SetEnable()
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SetEnable(
				//         VolumetricRenderer_VolumetricRenderStage *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4506, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4506, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     this.fields._Enabled_k__BackingField = 1;
				//   }
				// }
				// 
			}

			public void AddRenderNode(VolumetricRenderer.VolumetricRenderNode node)
			{
				// // Void AddRenderNode(VolumetricRenderer+VolumetricRenderNode)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
				//         VolumetricRenderer_VolumetricRenderStage *this,
				//         VolumetricRenderer_VolumetricRenderNode *node,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   List_1_System_Object_ *renderNodes; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9197DE )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Add);
				//     byte_18D9197DE = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4507, 0LL) )
				//   {
				//     renderNodes = (List_1_System_Object_ *)this.fields.renderNodes;
				//     this.fields._Enabled_k__BackingField = 1;
				//     if ( renderNodes )
				//     {
				//       sub_1822AD140(renderNodes, (Object *)node);
				//       if ( node )
				//       {
				//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::MarkAdd(node, 0LL);
				//         return;
				//       }
				//     }
				// LABEL_8:
				//     sub_180B536AC(renderNodes, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4507, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//     (ILFixDynamicMethodWrapper_37 *)Patch,
				//     (Object *)this,
				//     (Object *)node,
				//     0LL);
				// }
				// 
			}

			public void SortNodes()
			{
				// // Void SortNodes()
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SortNodes(
				//         VolumetricRenderer_VolumetricRenderStage *this,
				//         MethodInfo *method)
				// {
				//   List_1_System_Object_ *renderNodes; // rdi
				//   Comparison_1_Object_ *v4; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   Comparison_1_Object_ *v7; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9197DF )
				//   {
				//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Sort);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare);
				//     byte_18D9197DF = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4529, 0LL) )
				//   {
				//     renderNodes = (List_1_System_Object_ *)this.fields.renderNodes;
				//     v4 = (Comparison_1_Object_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
				//     v7 = v4;
				//     if ( v4 )
				//     {
				//       System::Comparison<System::Object>::Comparison(
				//         v4,
				//         0LL,
				//         MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare,
				//         0LL);
				//       if ( renderNodes )
				//       {
				//         System::Collections::Generic::List<System::Object>::Sort(
				//           renderNodes,
				//           v7,
				//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Sort);
				//         return;
				//       }
				//     }
				// LABEL_8:
				//     sub_180B536AC(v6, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4529, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			protected virtual void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT)
			{
				// // Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
				//         VolumetricRenderer_VolumetricRenderStage *this,
				//         VolumetricRenderInputs *inputs,
				//         VolumetricPipelineRT **colorRT,
				//         VolumetricPipelineRT **depthsRT,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4535, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4535, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
				//   }
				// }
				// 
			}

			public void Process(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT)
			{
				// // Void Process(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
				//         VolumetricRenderer_VolumetricRenderStage *this,
				//         VolumetricRenderInputs *inputs,
				//         VolumetricPipelineRT **colorRT,
				//         VolumetricPipelineRT **depthsRT,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4534, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4534, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
				//   }
				//   else if ( this.fields._Enabled_k__BackingField )
				//   {
				//     sub_180003EE0(this.klass);
				//     ((void (__fastcall *)(VolumetricRenderer_VolumetricRenderStage *, VolumetricRenderInputs *, VolumetricPipelineRT **, VolumetricPipelineRT **, const Il2CppImage *))this.klass.vtable.ProcessImpl.method)(
				//       this,
				//       inputs,
				//       colorRT,
				//       depthsRT,
				//       this.klass[1]._0.image);
				//   }
				// }
				// 
			}

			protected EVolumetricStage stage;

			protected VolumetricRenderer renderer;

			protected List<VolumetricRenderer.VolumetricRenderNode> renderNodes;
		}

		private class FramingStage : VolumetricRenderer.VolumetricRenderStage
		{
			public FramingStage(VolumetricRenderer inRenderer, EVolumetricStage inStage)
			{
				// // VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderer *inRenderer,
				//         EVolumetricStage__Enum inStage,
				//         MethodInfo *method)
				// {
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
				//   VolumetricRenderer_VolumetricBounds *v7; // r8
				//   Material *v8; // r9
				//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
				//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
				//   int32_t v11; // [rsp+60h] [rbp+38h]
				//   int32_t v12; // [rsp+68h] [rbp+40h]
				//   float v13; // [rsp+70h] [rbp+48h]
				//   int32_t v14; // [rsp+78h] [rbp+50h]
				//   bool v15; // [rsp+80h] [rbp+58h]
				//   bool v16; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v17; // [rsp+90h] [rbp+68h]
				// 
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     inStage,
				//     0LL);
				//   this.fields._.renderer = inRenderer;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields._.renderer,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15,
				//     v16,
				//     v17);
				// }
				// 
			}

			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT)
			{
				// // Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::FramingStage::ProcessImpl(
				//         VolumetricRenderer_FramingStage *this,
				//         VolumetricRenderInputs *inputs,
				//         VolumetricPipelineRT **colorRT,
				//         VolumetricPipelineRT **depthsRT,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v9; // rdx
				//   unsigned int *m_VolumetricMat; // rcx
				//   HGRenderGraphContext *context; // r14
				//   VolumetricRenderer *renderer; // rdi
				//   CommandBuffer *cmd; // r14
				//   VolumetricRenderer *v14; // rax
				//   __int64 m_RTIndex; // rdi
				//   VolumetricPipelineRT__Array *m_ReconstructColors; // r12
				//   VolumetricPipelineRT__Array *m_ReconstructDepths; // r15
				//   VolumetricRenderer *v18; // rax
				//   VolumetricPipelineRT *m_FramingDepth; // rbx
				//   RenderTexture *RT; // rbx
				//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodes; // rax
				//   Object *Item; // rax
				//   Quaternion *identity; // rax
				//   int32_t i; // ebx
				//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v25; // rax
				//   Object *v26; // rax
				//   Material *material; // rax
				//   char v28; // al
				//   __int64 v29; // rbx
				//   EFramingQuality__Enum v30; // ebx
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v31; // rdx
				//   VolumetricRenderer_VolumetricBounds *v32; // r8
				//   Material *v33; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v34; // rdx
				//   bool v35; // cl
				//   HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
				//   VolumetricRenderer_VolumetricBounds *v37; // r8
				//   Material *v38; // r9
				//   VolumetricRenderer *v39; // rax
				//   VolumetricRenderer *v40; // rax
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v41; // rdx
				//   VolumetricRenderer_VolumetricBounds *v42; // r8
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v43; // rdx
				//   VolumetricRenderer_VolumetricBounds *v44; // r8
				//   Material *v45; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v46; // rdx
				//   VolumetricRenderer_VolumetricBounds *v47; // r8
				//   Material *v48; // r9
				//   int32_t v49; // r8d
				//   int32_t ReconstructComposeRatio; // ebx
				//   float v51; // xmm0_4
				//   int32_t ReconstructCurrentColor; // ebx
				//   Texture *v53; // rax
				//   RenderTargetIdentifier *v54; // rax
				//   __int128 v55; // xmm1
				//   int32_t ReconstructCurrentDepth; // ebx
				//   Texture *v57; // rax
				//   RenderTargetIdentifier *v58; // rax
				//   __int128 v59; // xmm1
				//   __int64 v60; // rdx
				//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
				//   int32_t ReconstructHistoryColor; // ebx
				//   Texture *v63; // rax
				//   RenderTargetIdentifier *v64; // rax
				//   __int128 v65; // xmm1
				//   __int64 v66; // rdx
				//   VolumetricShaderIDs__StaticFields *v67; // rcx
				//   int32_t ReconstructHistoryDepth; // ebx
				//   Texture *v69; // rax
				//   RenderTargetIdentifier *v70; // rax
				//   __int128 v71; // xmm1
				//   __int64 v72; // rdx
				//   VolumetricPipelineRT *v73; // rcx
				//   VolumetricRenderer *v74; // rax
				//   bool m_EnableFraming; // si
				//   HGVolumetricCloudSettingParameters *v76; // rax
				//   SettingParameter_1_EFramingQuality_ *framingLevel; // rbx
				//   EFramingQuality__Enum paramValue_k__BackingField; // ebx
				//   bool v79; // r8
				//   MeshFilter *meshFilter; // rsi
				//   VolumetricShaderIDs__StaticFields *v81; // rcx
				//   RenderTexture *v82; // rbx
				//   RenderTexture *v83; // rax
				//   int32_t ReconstructColor; // ebx
				//   Texture *v85; // rax
				//   RenderTargetIdentifier *v86; // rax
				//   __int128 v87; // xmm1
				//   __int64 v88; // rdx
				//   VolumetricShaderIDs__StaticFields *v89; // rcx
				//   int32_t ReconstructDepth; // ebx
				//   VolumetricPipelineRT *v91; // rcx
				//   Texture *v92; // rax
				//   RenderTargetIdentifier *v93; // rax
				//   __int128 v94; // xmm1
				//   __int64 v95; // rdx
				//   VolumetricShaderIDs__StaticFields *v96; // rcx
				//   int32_t VolumetricComposeColor; // ebx
				//   VolumetricPipelineRT *v98; // rcx
				//   Texture *v99; // rax
				//   RenderTargetIdentifier *v100; // rax
				//   __int128 v101; // xmm1
				//   __int64 v102; // rdx
				//   VolumetricShaderIDs__StaticFields *v103; // rcx
				//   int32_t VolumetricComposeDepth; // ebx
				//   VolumetricPipelineRT *v105; // rcx
				//   Texture *v106; // rax
				//   RenderTargetIdentifier *v107; // rax
				//   __int128 v108; // xmm1
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v109; // rdx
				//   __int64 v110; // rcx
				//   VolumetricRenderer_VolumetricBounds *v111; // r8
				//   Material *v112; // r9
				//   VolumetricRenderer_VolumetricBounds *v113; // r8
				//   Material *v114; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *storeAction; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *storeActiona; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *storeActiond; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *storeActione; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *storeActionf; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *storeActionb; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *storeActionc; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *v123; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v124; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v125; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v126; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v127; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v128; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v129; // [rsp+28h] [rbp-D8h]
				//   int32_t v130; // [rsp+30h] [rbp-D0h]
				//   int32_t v131; // [rsp+30h] [rbp-D0h]
				//   int32_t v132; // [rsp+30h] [rbp-D0h]
				//   int32_t v133; // [rsp+30h] [rbp-D0h]
				//   int32_t v134; // [rsp+30h] [rbp-D0h]
				//   int32_t v135; // [rsp+30h] [rbp-D0h]
				//   int32_t v136; // [rsp+38h] [rbp-C8h]
				//   int32_t v137; // [rsp+38h] [rbp-C8h]
				//   int32_t v138; // [rsp+38h] [rbp-C8h]
				//   int32_t v139; // [rsp+38h] [rbp-C8h]
				//   int32_t v140; // [rsp+38h] [rbp-C8h]
				//   int32_t v141; // [rsp+38h] [rbp-C8h]
				//   RenderTargetIdentifier v142; // [rsp+40h] [rbp-C0h] BYREF
				//   RenderTexture *colorRTa; // [rsp+70h] [rbp-90h]
				//   Material *mat[2]; // [rsp+80h] [rbp-80h] BYREF
				//   VolumetricPipelineRT *v145; // [rsp+90h] [rbp-70h]
				//   VolumetricPipelineRT *v146; // [rsp+98h] [rbp-68h]
				//   VolumetricRenderer_VolumetricRenderItem v147; // [rsp+A0h] [rbp-60h] BYREF
				//   MaterialPropertyBlock *propertyBlock; // [rsp+F8h] [rbp-8h]
				//   VolumetricRenderer_VolumetricCallbackContext v149; // [rsp+100h] [rbp+0h] BYREF
				// 
				//   if ( !byte_18D9197E0 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFramingQuality>::get_paramValue);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     byte_18D9197E0 = 1;
				//   }
				//   sub_1802F01E0(&v147, 0LL, 72LL);
				//   if ( IFix::WrappersManagerImpl::IsPatched(4543, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4543, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
				//       return;
				//     }
				//     goto LABEL_79;
				//   }
				//   context = inputs.context;
				//   if ( !context )
				//     goto LABEL_79;
				//   renderer = this.fields._.renderer;
				//   cmd = context.fields.cmd;
				//   if ( !renderer )
				//     goto LABEL_79;
				//   v14 = this.fields._.renderer;
				//   m_RTIndex = renderer.fields.m_RTIndex;
				//   m_ReconstructColors = v14.fields.m_ReconstructColors;
				//   if ( !v14 )
				//     goto LABEL_79;
				//   m_VolumetricMat = (unsigned int *)v14.fields.m_VolumetricMat;
				//   m_ReconstructDepths = v14.fields.m_ReconstructDepths;
				//   propertyBlock = v14.fields.m_PropertyBlock;
				//   v18 = this.fields._.renderer;
				//   v147.meshFilter = (MeshFilter *)m_VolumetricMat;
				//   if ( !v18 )
				//     goto LABEL_79;
				//   m_VolumetricMat = (unsigned int *)v18.fields.m_FramingColor;
				//   m_FramingDepth = v18.fields.m_FramingDepth;
				//   v145 = (VolumetricPipelineRT *)m_VolumetricMat;
				//   v146 = m_FramingDepth;
				//   if ( !m_VolumetricMat )
				//     goto LABEL_79;
				//   colorRTa = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)m_VolumetricMat, 0LL);
				//   if ( !m_FramingDepth )
				//     goto LABEL_79;
				//   RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FramingDepth, 0LL);
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//   HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
				//     cmd,
				//     colorRTa,
				//     RT,
				//     RenderBufferLoadAction__Enum_DontCare,
				//     RenderBufferStoreAction__Enum_Store,
				//     0LL);
				//   renderNodes = this.fields._.renderNodes;
				//   if ( !renderNodes )
				//     goto LABEL_79;
				//   if ( renderNodes.fields._size < 1 )
				//     goto LABEL_15;
				//   Item = System::Collections::Generic::List<System::Object>::get_Item(
				//            (List_1_System_Object_ *)this.fields._.renderNodes,
				//            0,
				//            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//   if ( !Item )
				//     goto LABEL_79;
				//   if ( HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
				//          (VolumetricRenderer_VolumetricRenderNode *)Item,
				//          0LL) )
				//   {
				//     LOBYTE(v130) = 1;
				//   }
				//   else
				//   {
				// LABEL_15:
				//     LOBYTE(v130) = 0;
				//     identity = UnityEngine::Quaternion::get_identity((Quaternion *)mat, v9);
				//     if ( !cmd )
				//       goto LABEL_79;
				//     *(Quaternion *)mat = *identity;
				//     UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(cmd, 0, 1, (Color *)mat, 0LL);
				//   }
				//   for ( i = 0; ; i = (_DWORD)colorRTa + 1 )
				//   {
				//     LODWORD(colorRTa) = i;
				//     v25 = this.fields._.renderNodes;
				//     if ( !v25 )
				//       goto LABEL_79;
				//     if ( i >= v25.fields._size )
				//       break;
				//     v26 = System::Collections::Generic::List<System::Object>::get_Item(
				//             (List_1_System_Object_ *)this.fields._.renderNodes,
				//             i,
				//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     if ( !v26 )
				//       goto LABEL_79;
				//     material = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
				//                  (VolumetricRenderer_VolumetricRenderNode *)v26,
				//                  0LL);
				//     m_VolumetricMat = (unsigned int *)this.fields._.renderer;
				//     mat[0] = material;
				//     if ( !m_VolumetricMat )
				//       goto LABEL_79;
				//     v28 = *((_BYTE *)m_VolumetricMat + 16);
				//     m_VolumetricMat = (unsigned int *)inputs.volumetricParameters;
				//     BYTE1(v130) = v28;
				//     if ( !m_VolumetricMat )
				//       goto LABEL_79;
				//     v29 = *((_QWORD *)m_VolumetricMat + 6);
				//     if ( !v29 )
				//       goto LABEL_79;
				//     v30 = *(_DWORD *)(v29 + 40);
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(cmd, mat[0], SBYTE1(v130), v30, 0LL);
				//     m_VolumetricMat = (unsigned int *)this.fields._.renderNodes;
				//     if ( !m_VolumetricMat )
				//       goto LABEL_79;
				//     mat[0] = (Material *)System::Collections::Generic::List<System::Object>::get_Item(
				//                            (List_1_System_Object_ *)m_VolumetricMat,
				//                            (int32_t)colorRTa,
				//                            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     sub_1802F01E0(&v147, 0LL, 72LL);
				//     v147.Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)cmd;
				//     sub_1800054D0(
				//       &v147,
				//       v31,
				//       v32,
				//       v33,
				//       storeAction,
				//       v123,
				//       v130,
				//       v136,
				//       *(float *)&v142.m_Type,
				//       v142.m_InstanceID,
				//       (bool)v142.m_BufferPointer,
				//       v142.m_MipLevel,
				//       *(MethodInfo **)&v142.m_DepthSlice);
				//     if ( (_BYTE)v131 )
				//       v35 = (_DWORD)colorRTa == 0;
				//     else
				//       v35 = 0;
				//     LOBYTE(v147.material) = v35;
				//     volumetricParameters = inputs.volumetricParameters;
				//     if ( !volumetricParameters )
				//       goto LABEL_33;
				//     BYTE1(v147.material) = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//                              volumetricParameters.fields.enableDownRes,
				//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     v39 = this.fields._.renderer;
				//     if ( !v39 )
				//       goto LABEL_33;
				//     BYTE2(v147.material) = v39.fields.m_EnableFraming;
				//     v40 = this.fields._.renderer;
				//     if ( !v40 )
				//       goto LABEL_33;
				//     BYTE3(v147.material) = v40.fields.m_EnableTAA;
				//     HIDWORD(v147.material) = this.fields._.stage;
				//     *(_QWORD *)&v147.bounds.enableBounds = *colorRT;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v147.bounds,
				//       v34,
				//       v37,
				//       v38,
				//       storeActiona,
				//       v124,
				//       v131,
				//       v137,
				//       *(float *)&v142.m_Type,
				//       v142.m_InstanceID,
				//       (bool)v142.m_BufferPointer,
				//       v142.m_MipLevel,
				//       *(MethodInfo **)&v142.m_DepthSlice);
				//     *(_QWORD *)&v147.bounds.worldBounds.m_Center.y = *depthsRT;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v147.bounds.worldBounds.m_Center.y,
				//       v41,
				//       v42,
				//       *(Material **)&v147.bounds.worldBounds.m_Center.y,
				//       storeActiond,
				//       v125,
				//       v132,
				//       v138,
				//       *(float *)&v142.m_Type,
				//       v142.m_InstanceID,
				//       (bool)v142.m_BufferPointer,
				//       v142.m_MipLevel,
				//       *(MethodInfo **)&v142.m_DepthSlice);
				//     *(_QWORD *)&v147.bounds.worldBounds.m_Extents.x = v145;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v147.bounds.worldBounds.m_Extents,
				//       v43,
				//       v44,
				//       v45,
				//       storeActione,
				//       v126,
				//       v133,
				//       v139,
				//       *(float *)&v142.m_Type,
				//       v142.m_InstanceID,
				//       (bool)v142.m_BufferPointer,
				//       v142.m_MipLevel,
				//       *(MethodInfo **)&v142.m_DepthSlice);
				//     *(_QWORD *)&v147.bounds.worldBounds.m_Extents.z = v146;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v147.bounds.worldBounds.m_Extents.z,
				//       v46,
				//       v47,
				//       v48,
				//       storeActionf,
				//       v127,
				//       v134,
				//       v140,
				//       *(float *)&v142.m_Type,
				//       v142.m_InstanceID,
				//       (bool)v142.m_BufferPointer,
				//       v142.m_MipLevel,
				//       *(MethodInfo **)&v142.m_DepthSlice);
				//     if ( !mat[0] )
				// LABEL_33:
				//       sub_180B536AC(volumetricParameters, v34);
				//     *(_OWORD *)&v149.Cmd = *(_OWORD *)&v147.Callback;
				//     *(_OWORD *)&v149.DstColor = *(_OWORD *)&v147.bounds.worldBounds.m_Extents.x;
				//     *(_OWORD *)&v149.SrcColor = *(_OWORD *)&v147.bounds.enableBounds;
				//     v149.MSBakeMaterial = *(Material **)&v147.bPureBlit;
				//     *(_OWORD *)&v149.meshFilter = *(_OWORD *)&v147.SortingOrder;
				//     HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
				//       (VolumetricRenderer_VolumetricRenderNode *)mat[0],
				//       &v149,
				//       0LL);
				//   }
				//   m_VolumetricMat = (unsigned int *)inputs.volumetricParameters;
				//   if ( !m_VolumetricMat )
				//     goto LABEL_79;
				//   if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//          *((SettingParameter_1_System_Boolean_ **)m_VolumetricMat + 8),
				//          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     m_VolumetricMat = (unsigned int *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//     v9 = (MethodInfo *)m_VolumetricMat[234];
				//     if ( !cmd )
				//       goto LABEL_79;
				//     v49 = 1;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     m_VolumetricMat = (unsigned int *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//     v9 = (MethodInfo *)m_VolumetricMat[234];
				//     if ( !cmd )
				//       goto LABEL_79;
				//     v49 = 0;
				//   }
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, (int32_t)v9, v49, 0LL);
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//   ReconstructComposeRatio = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._ReconstructComposeRatio;
				//   m_VolumetricMat = (unsigned int *)inputs.volumetricParameters;
				//   if ( !m_VolumetricMat )
				// LABEL_79:
				//     sub_180B536AC(m_VolumetricMat, v9);
				//   v51 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
				//           *((SettingParameter_1_System_Single_ **)m_VolumetricMat + 7),
				//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, ReconstructComposeRatio, v51, 0LL);
				//   ReconstructCurrentColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._ReconstructCurrentColor;
				//   v53 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v145, 0LL);
				//   v54 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v53, 0LL);
				//   v55 = *(_OWORD *)&v54.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v54.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v54.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v55;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructCurrentColor, &v142, 0LL);
				//   ReconstructCurrentDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._ReconstructCurrentDepth;
				//   v57 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v146, 0LL);
				//   v58 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v57, 0LL);
				//   v59 = *(_OWORD *)&v58.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v58.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v58.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v59;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructCurrentDepth, &v142, 0LL);
				//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   ReconstructHistoryColor = static_fields._ReconstructHistoryColor;
				//   if ( !m_ReconstructColors )
				//     goto LABEL_77;
				//   if ( (unsigned int)(1 - m_RTIndex) >= m_ReconstructColors.max_length.size )
				//     sub_180070270(static_fields, v60);
				//   static_fields = (VolumetricShaderIDs__StaticFields *)m_ReconstructColors.vector[1 - (int)m_RTIndex];
				//   if ( !static_fields )
				// LABEL_77:
				//     sub_180B536AC(static_fields, v60);
				//   v63 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)static_fields, 0LL);
				//   v64 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v63, 0LL);
				//   v65 = *(_OWORD *)&v64.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v64.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v64.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v65;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructHistoryColor, &v142, 0LL);
				//   v67 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   ReconstructHistoryDepth = v67._ReconstructHistoryDepth;
				//   if ( !m_ReconstructDepths )
				//     goto LABEL_76;
				//   if ( (unsigned int)(1 - m_RTIndex) >= m_ReconstructDepths.max_length.size )
				//     sub_180070270(v67, v66);
				//   v67 = (VolumetricShaderIDs__StaticFields *)m_ReconstructDepths.vector[1 - (int)m_RTIndex];
				//   if ( !v67 )
				// LABEL_76:
				//     sub_180B536AC(v67, v66);
				//   v69 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)v67, 0LL);
				//   v70 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v69, 0LL);
				//   v71 = *(_OWORD *)&v70.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v70.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v70.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v71;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructHistoryDepth, &v142, 0LL);
				//   v74 = this.fields._.renderer;
				//   if ( !v74 )
				//     goto LABEL_75;
				//   m_EnableFraming = v74.fields.m_EnableFraming;
				//   v76 = inputs.volumetricParameters;
				//   if ( !v76 )
				//     goto LABEL_75;
				//   framingLevel = v76.fields.framingLevel;
				//   if ( !framingLevel )
				//     goto LABEL_75;
				//   paramValue_k__BackingField = framingLevel.fields._paramValue_k__BackingField;
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//   v79 = m_EnableFraming;
				//   meshFilter = v147.meshFilter;
				//   HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
				//     cmd,
				//     (Material *)v147.meshFilter,
				//     v79,
				//     paramValue_k__BackingField,
				//     0LL);
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructColors.max_length.size )
				//     goto LABEL_74;
				//   v73 = m_ReconstructColors.vector[m_RTIndex];
				//   if ( !v73 )
				//     goto LABEL_75;
				//   v82 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v73, 0LL);
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructDepths.max_length.size )
				//     goto LABEL_74;
				//   v73 = m_ReconstructDepths.vector[m_RTIndex];
				//   if ( !v73 )
				//     goto LABEL_75;
				//   v83 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v73, 0LL);
				//   HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
				//     cmd,
				//     v82,
				//     v83,
				//     RenderBufferLoadAction__Enum_DontCare,
				//     RenderBufferStoreAction__Enum_Store,
				//     0LL);
				//   HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, (Material *)meshFilter, propertyBlock, 1, 0, 0LL);
				//   v81 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   ReconstructColor = v81._ReconstructColor;
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructColors.max_length.size )
				// LABEL_74:
				//     sub_180070270(v81, v72);
				//   v73 = m_ReconstructColors.vector[m_RTIndex];
				//   if ( !v73 )
				// LABEL_75:
				//     sub_180B536AC(v73, v72);
				//   v85 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v73, 0LL);
				//   v86 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v85, 0LL);
				//   v87 = *(_OWORD *)&v86.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v86.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v86.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v87;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructColor, &v142, 0LL);
				//   v89 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   ReconstructDepth = v89._ReconstructDepth;
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructDepths.max_length.size )
				//     sub_180070270(v89, v88);
				//   v91 = m_ReconstructDepths.vector[m_RTIndex];
				//   if ( !v91 )
				//     sub_180B536AC(0LL, v88);
				//   v92 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v91, 0LL);
				//   v93 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v92, 0LL);
				//   v94 = *(_OWORD *)&v93.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v93.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v93.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v94;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructDepth, &v142, 0LL);
				//   v96 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   VolumetricComposeColor = v96._VolumetricComposeColor;
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructColors.max_length.size )
				//     sub_180070270(v96, v95);
				//   v98 = m_ReconstructColors.vector[m_RTIndex];
				//   if ( !v98 )
				//     sub_180B536AC(0LL, v95);
				//   v99 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v98, 0LL);
				//   v100 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v99, 0LL);
				//   v101 = *(_OWORD *)&v100.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v100.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v100.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v101;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v142, 0LL);
				//   v103 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   VolumetricComposeDepth = v103._VolumetricComposeDepth;
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructDepths.max_length.size )
				//     sub_180070270(v103, v102);
				//   v105 = m_ReconstructDepths.vector[m_RTIndex];
				//   if ( !v105 )
				//     sub_180B536AC(0LL, v102);
				//   v106 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v105, 0LL);
				//   v107 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v149, v106, 0LL);
				//   v108 = *(_OWORD *)&v107.m_BufferPointer;
				//   *(_OWORD *)&v142.m_Type = *(_OWORD *)&v107.m_Type;
				//   *(_QWORD *)&v142.m_DepthSlice = *(_QWORD *)&v107.m_DepthSlice;
				//   *(_OWORD *)&v142.m_BufferPointer = v108;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v142, 0LL);
				//   HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
				//     cmd,
				//     (Material *)meshFilter,
				//     0,
				//     EFramingQuality__Enum_Checkerboard,
				//     0LL);
				//   if ( (unsigned int)m_RTIndex >= m_ReconstructColors.max_length.size
				//     || (*colorRT = m_ReconstructColors.vector[m_RTIndex],
				//         sub_1800054D0(
				//           (VolumetricRenderer_VolumetricRenderItem *)colorRT,
				//           v109,
				//           v111,
				//           v112,
				//           storeActionb,
				//           v128,
				//           v130,
				//           v136,
				//           *(float *)&v142.m_Type,
				//           v142.m_InstanceID,
				//           (bool)v142.m_BufferPointer,
				//           v142.m_MipLevel,
				//           *(MethodInfo **)&v142.m_DepthSlice),
				//         (unsigned int)m_RTIndex >= m_ReconstructDepths.max_length.size) )
				//   {
				//     sub_180070270(v110, v109);
				//   }
				//   *depthsRT = m_ReconstructDepths.vector[m_RTIndex];
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)depthsRT,
				//     v109,
				//     v113,
				//     v114,
				//     storeActionc,
				//     v129,
				//     v135,
				//     v141,
				//     *(float *)&v142.m_Type,
				//     v142.m_InstanceID,
				//     (bool)v142.m_BufferPointer,
				//     v142.m_MipLevel,
				//     *(MethodInfo **)&v142.m_DepthSlice);
				// }
				// 
			}

			public void <>iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2)
			{
				// // Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderInputs *P0,
				//         VolumetricPipelineRT **P1,
				//         VolumetricPipelineRT **P2,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     P0,
				//     P1,
				//     P2,
				//     0LL);
				// }
				// 
			}
		}

		private class GeneralComposeStage : VolumetricRenderer.VolumetricRenderStage
		{
			public GeneralComposeStage(VolumetricRenderer inRenderer, EVolumetricStage inStage)
			{
				// // VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderer *inRenderer,
				//         EVolumetricStage__Enum inStage,
				//         MethodInfo *method)
				// {
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
				//   VolumetricRenderer_VolumetricBounds *v7; // r8
				//   Material *v8; // r9
				//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
				//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
				//   int32_t v11; // [rsp+60h] [rbp+38h]
				//   int32_t v12; // [rsp+68h] [rbp+40h]
				//   float v13; // [rsp+70h] [rbp+48h]
				//   int32_t v14; // [rsp+78h] [rbp+50h]
				//   bool v15; // [rsp+80h] [rbp+58h]
				//   bool v16; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v17; // [rsp+90h] [rbp+68h]
				// 
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     inStage,
				//     0LL);
				//   this.fields._.renderer = inRenderer;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields._.renderer,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15,
				//     v16,
				//     v17);
				// }
				// 
			}

			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT)
			{
				// // Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::GeneralComposeStage::ProcessImpl(
				//         VolumetricRenderer_GeneralComposeStage *this,
				//         VolumetricRenderInputs *inputs,
				//         VolumetricPipelineRT **colorRT,
				//         VolumetricPipelineRT **depthsRT,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v9; // rdx
				//   void *volumetricParameters; // rcx
				//   VolumetricRenderer *renderer; // rax
				//   HGRenderGraphContext *context; // r13
				//   VolumetricRenderer *v13; // rsi
				//   CommandBuffer *cmd; // r13
				//   VolumetricPipelineRT *m_ComposeColor; // rsi
				//   VolumetricPipelineRT *m_ComposeDepth; // r15
				//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodes; // rax
				//   Object *Item; // rax
				//   RenderTexture *RT; // r12
				//   RenderTexture *v20; // rbx
				//   VolumetricRenderer *v21; // rax
				//   Texture *v22; // rax
				//   __int128 v23; // xmm6
				//   __int128 v24; // xmm7
				//   __int64 v25; // xmm8_8
				//   TextureHandle sceneDepth; // xmm6
				//   RenderTargetIdentifier *v27; // rax
				//   RenderTexture *v28; // r12
				//   RenderTexture *v29; // rbx
				//   RenderTexture *v30; // rdx
				//   VolumetricRenderer *v31; // rax
				//   Texture *v32; // rax
				//   RenderTexture *v33; // r12
				//   RenderTexture *v34; // rbx
				//   VolumetricRenderer *v35; // rax
				//   VolumetricRenderer *v36; // rax
				//   Texture *v37; // rax
				//   TextureHandle v38; // xmm6
				//   RenderTargetIdentifier *v39; // rax
				//   bool v40; // r12
				//   Quaternion *identity; // rax
				//   int32_t i; // r12d
				//   List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v43; // rax
				//   List_1_System_Object_ *v44; // rcx
				//   Object *v45; // rax
				//   Material *v46; // rax
				//   Object *v47; // rax
				//   Material *v48; // rax
				//   Shader *shader; // rbx
				//   String *s_DisableDepthWrite; // r8
				//   Object *v51; // rbx
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v52; // rdx
				//   VolumetricRenderer_VolumetricBounds *v53; // r8
				//   Material *v54; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v55; // rdx
				//   bool v56; // cl
				//   HGVolumetricCloudSettingParameters *v57; // rcx
				//   VolumetricRenderer_VolumetricBounds *v58; // r8
				//   Material *v59; // r9
				//   VolumetricRenderer *v60; // rax
				//   VolumetricRenderer *v61; // rax
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v62; // rdx
				//   VolumetricRenderer_VolumetricBounds *v63; // r8
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v64; // rdx
				//   VolumetricRenderer_VolumetricBounds *v65; // r8
				//   Material *v66; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v67; // rdx
				//   VolumetricRenderer_VolumetricBounds *v68; // r8
				//   Material *v69; // r9
				//   int32_t VolumetricComposeColor; // ebx
				//   Texture *v71; // rax
				//   RenderTargetIdentifier *v72; // rax
				//   __int64 v73; // rdx
				//   __int64 v74; // rcx
				//   __int128 v75; // xmm1
				//   int32_t VolumetricComposeDepth; // ebx
				//   Texture *v77; // rax
				//   RenderTargetIdentifier *v78; // rax
				//   __int128 v79; // xmm1
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v80; // rdx
				//   VolumetricRenderer_VolumetricBounds *v81; // r8
				//   Material *v82; // r9
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v83; // rdx
				//   VolumetricRenderer_VolumetricBounds *v84; // r8
				//   Material *v85; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   VolumetricPipelineRT **P3; // [rsp+20h] [rbp-E0h]
				//   VolumetricPipelineRT **P3a; // [rsp+20h] [rbp-E0h]
				//   VolumetricPipelineRT **P3b; // [rsp+20h] [rbp-E0h]
				//   VolumetricPipelineRT **P3c; // [rsp+20h] [rbp-E0h]
				//   VolumetricPipelineRT **P3d; // [rsp+20h] [rbp-E0h]
				//   VolumetricPipelineRT **P3e; // [rsp+20h] [rbp-E0h]
				//   MethodInfo *v93; // [rsp+28h] [rbp-D8h]
				//   RenderBufferStoreAction__Enum v94; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v95; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v96; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v97; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v98; // [rsp+28h] [rbp-D8h]
				//   MethodInfo *v99; // [rsp+28h] [rbp-D8h]
				//   int32_t v100; // [rsp+30h] [rbp-D0h]
				//   int32_t v101; // [rsp+30h] [rbp-D0h]
				//   int32_t v102; // [rsp+30h] [rbp-D0h]
				//   int32_t v103; // [rsp+30h] [rbp-D0h]
				//   int32_t v104; // [rsp+30h] [rbp-D0h]
				//   int32_t v105; // [rsp+30h] [rbp-D0h]
				//   int32_t v106; // [rsp+38h] [rbp-C8h]
				//   int32_t v107; // [rsp+38h] [rbp-C8h]
				//   int32_t v108; // [rsp+38h] [rbp-C8h]
				//   int32_t v109; // [rsp+38h] [rbp-C8h]
				//   int32_t v110; // [rsp+38h] [rbp-C8h]
				//   int32_t v111; // [rsp+38h] [rbp-C8h]
				//   float v112; // [rsp+40h] [rbp-C0h]
				//   float v113; // [rsp+40h] [rbp-C0h]
				//   float v114; // [rsp+40h] [rbp-C0h]
				//   float v115; // [rsp+40h] [rbp-C0h]
				//   float v116; // [rsp+40h] [rbp-C0h]
				//   float v117; // [rsp+40h] [rbp-C0h]
				//   int32_t v118; // [rsp+48h] [rbp-B8h]
				//   int32_t v119; // [rsp+48h] [rbp-B8h]
				//   int32_t v120; // [rsp+48h] [rbp-B8h]
				//   int32_t v121; // [rsp+48h] [rbp-B8h]
				//   int32_t v122; // [rsp+48h] [rbp-B8h]
				//   int32_t v123; // [rsp+48h] [rbp-B8h]
				//   RenderTargetIdentifier v124; // [rsp+50h] [rbp-B0h] BYREF
				//   Material *material[2]; // [rsp+80h] [rbp-80h] BYREF
				//   VolumetricRenderer_VolumetricCallbackContext v126; // [rsp+90h] [rbp-70h] BYREF
				//   VolumetricRenderer_VolumetricCallbackContext v127; // [rsp+E0h] [rbp-20h] BYREF
				// 
				//   if ( !byte_18D9197E1 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::op_Implicit);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
				//     byte_18D9197E1 = 1;
				//   }
				//   memset(&v124, 0, sizeof(v124));
				//   sub_1802F01E0(&v126, 0LL, 72LL);
				//   if ( IFix::WrappersManagerImpl::IsPatched(4544, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4544, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
				//       return;
				//     }
				//     goto LABEL_85;
				//   }
				//   if ( this.fields._.stage == 1 )
				//   {
				//     renderer = this.fields._.renderer;
				//     if ( !renderer )
				//       goto LABEL_85;
				//     if ( renderer.fields.m_CanMergeTAAPass )
				//       return;
				//   }
				//   context = inputs.context;
				//   if ( !context
				//     || (v13 = this.fields._.renderer, cmd = context.fields.cmd, !v13)
				//     || (m_ComposeColor = v13.fields.m_ComposeColor,
				//         m_ComposeDepth = this.fields._.renderer.fields.m_ComposeDepth,
				//         (renderNodes = this.fields._.renderNodes) == 0LL) )
				//   {
				// LABEL_85:
				//     sub_180B536AC(volumetricParameters, v9);
				//   }
				//   if ( renderNodes.fields._size >= 1 )
				//   {
				//     Item = System::Collections::Generic::List<System::Object>::get_Item(
				//              (List_1_System_Object_ *)this.fields._.renderNodes,
				//              0,
				//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     if ( !Item )
				//       goto LABEL_85;
				//     LOBYTE(v112) = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
				//                      (VolumetricRenderer_VolumetricRenderNode *)Item,
				//                      0LL);
				//   }
				//   else
				//   {
				//     LOBYTE(v112) = 0;
				//   }
				//   if ( this.fields._.stage != 3 )
				//   {
				//     volumetricParameters = this.fields._.renderer;
				//     if ( !volumetricParameters )
				//       goto LABEL_85;
				//     if ( !*((_BYTE *)volumetricParameters + 19) )
				//     {
				// LABEL_17:
				//       if ( !m_ComposeColor )
				//         goto LABEL_85;
				//       RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
				//       if ( !m_ComposeDepth )
				//         goto LABEL_85;
				//       v20 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//       HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
				//         cmd,
				//         RT,
				//         v20,
				//         RenderBufferLoadAction__Enum_DontCare,
				//         RenderBufferStoreAction__Enum_Store,
				//         0LL);
				//       goto LABEL_52;
				//     }
				//     volumetricParameters = inputs.volumetricParameters;
				//     if ( !volumetricParameters )
				//       goto LABEL_85;
				//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//            *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
				//     {
				//       v21 = this.fields._.renderer;
				//       if ( !v21 )
				//         goto LABEL_85;
				//       volumetricParameters = v21.fields.m_DepthForTest;
				//       if ( !volumetricParameters )
				//         goto LABEL_85;
				//       v22 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
				//                          (VolumetricPipelineRT *)volumetricParameters,
				//                          0LL);
				//       memset(&v124, 0, sizeof(v124));
				//       UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(&v124, v22, 0LL);
				//       v23 = *(_OWORD *)&v124.m_Type;
				//       v24 = *(_OWORD *)&v124.m_BufferPointer;
				//       v25 = *(_QWORD *)&v124.m_DepthSlice;
				//     }
				//     else
				//     {
				//       sceneDepth = inputs.sceneDepth;
				//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//       *(TextureHandle *)material = sceneDepth;
				//       v27 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v124, (TextureHandle *)material, 0LL);
				//       v23 = *(_OWORD *)&v27.m_Type;
				//       v24 = *(_OWORD *)&v27.m_BufferPointer;
				//       v25 = *(_QWORD *)&v27.m_DepthSlice;
				//     }
				//     if ( !m_ComposeColor )
				//       goto LABEL_85;
				//     v28 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
				//     if ( !m_ComposeDepth )
				//       goto LABEL_85;
				//     v29 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     v30 = v28;
				//     v94 = RenderBufferStoreAction__Enum_Store;
				// LABEL_51:
				//     *(_OWORD *)&v124.m_Type = v23;
				//     *(_OWORD *)&v124.m_BufferPointer = v24;
				//     *(_QWORD *)&v124.m_DepthSlice = v25;
				//     HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetsWithDepth(
				//       cmd,
				//       v30,
				//       v29,
				//       &v124,
				//       RenderBufferLoadAction__Enum_Load,
				//       v94,
				//       0LL);
				//     goto LABEL_52;
				//   }
				//   volumetricParameters = inputs.volumetricParameters;
				//   if ( !volumetricParameters )
				//     goto LABEL_85;
				//   if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//           *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
				//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
				//     goto LABEL_39;
				//   volumetricParameters = inputs.volumetricParameters;
				//   if ( !volumetricParameters )
				//     goto LABEL_85;
				//   if ( HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//          *((SettingParameter_1_System_Int32Enum_ **)volumetricParameters + 4),
				//          MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::op_Implicit) )
				//   {
				// LABEL_39:
				//     v35 = this.fields._.renderer;
				//     if ( !v35 )
				//       goto LABEL_85;
				//     if ( !v35.fields.m_AfterTAANeedDepthTest )
				//       goto LABEL_17;
				//     volumetricParameters = inputs.volumetricParameters;
				//     if ( !volumetricParameters )
				//       goto LABEL_85;
				//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//            *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
				//     {
				//       v36 = this.fields._.renderer;
				//       if ( !v36 )
				//         goto LABEL_85;
				//       volumetricParameters = v36.fields.m_DepthForTest;
				//       if ( !volumetricParameters )
				//         goto LABEL_85;
				//       v37 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
				//                          (VolumetricPipelineRT *)volumetricParameters,
				//                          0LL);
				//       memset(&v124, 0, sizeof(v124));
				//       UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(&v124, v37, 0LL);
				//       v23 = *(_OWORD *)&v124.m_Type;
				//       v24 = *(_OWORD *)&v124.m_BufferPointer;
				//       v25 = *(_QWORD *)&v124.m_DepthSlice;
				//     }
				//     else
				//     {
				//       v38 = inputs.sceneDepth;
				//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//       *(TextureHandle *)material = v38;
				//       v39 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v124, (TextureHandle *)material, 0LL);
				//       v23 = *(_OWORD *)&v39.m_Type;
				//       v24 = *(_OWORD *)&v39.m_BufferPointer;
				//       v25 = *(_QWORD *)&v39.m_DepthSlice;
				//     }
				//     volumetricParameters = inputs.volumetricParameters;
				//     if ( !volumetricParameters )
				//       goto LABEL_85;
				//     v40 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//             *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
				//             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     if ( !m_ComposeColor )
				//       goto LABEL_85;
				//     material[0] = (Material *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
				//     if ( !m_ComposeDepth )
				//       goto LABEL_85;
				//     v29 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     v30 = (RenderTexture *)material[0];
				//     v94 = v40 ? RenderBufferStoreAction__Enum_DontCare : RenderBufferStoreAction__Enum_Store;
				//     goto LABEL_51;
				//   }
				//   v31 = this.fields._.renderer;
				//   if ( !v31 )
				//     goto LABEL_85;
				//   if ( !v31.fields.m_AfterTAANeedDepthTest )
				//     goto LABEL_17;
				//   volumetricParameters = v31.fields.m_DepthForTest;
				//   if ( !volumetricParameters )
				//     goto LABEL_85;
				//   v32 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
				//                      (VolumetricPipelineRT *)volumetricParameters,
				//                      0LL);
				//   UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(&v124, v32, 0LL);
				//   if ( !m_ComposeColor )
				//     goto LABEL_85;
				//   v33 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
				//   if ( !m_ComposeDepth )
				//     goto LABEL_85;
				//   v34 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//   *(_OWORD *)&v127.Cmd = *(_OWORD *)&v124.m_Type;
				//   v127.DstColor = *(VolumetricPipelineRT **)&v124.m_DepthSlice;
				//   *(_OWORD *)&v127.SrcColor = *(_OWORD *)&v124.m_BufferPointer;
				//   HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetsWithDepth(
				//     cmd,
				//     v33,
				//     v34,
				//     (RenderTargetIdentifier *)&v127,
				//     RenderBufferLoadAction__Enum_Load,
				//     RenderBufferStoreAction__Enum_DontCare,
				//     0LL);
				// LABEL_52:
				//   if ( LOBYTE(v112) )
				//     goto LABEL_55;
				//   identity = UnityEngine::Quaternion::get_identity((Quaternion *)material, v9);
				//   if ( !cmd )
				//     goto LABEL_85;
				//   *(Quaternion *)material = *identity;
				//   UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(cmd, 0, 1, (Color *)material, 0LL);
				// LABEL_55:
				//   for ( i = 0; ; ++i )
				//   {
				//     v43 = this.fields._.renderNodes;
				//     if ( !v43 )
				//       goto LABEL_85;
				//     if ( i >= v43.fields._size )
				//       break;
				//     if ( this.fields._.stage == 3 )
				//     {
				//       volumetricParameters = inputs.volumetricParameters;
				//       if ( !volumetricParameters )
				//         goto LABEL_85;
				//       if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//               *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
				//               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
				//         goto LABEL_63;
				//       volumetricParameters = inputs.volumetricParameters;
				//       if ( !volumetricParameters )
				//         goto LABEL_85;
				//       if ( HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//              *((SettingParameter_1_System_Int32Enum_ **)volumetricParameters + 4),
				//              MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::op_Implicit) )
				//       {
				// LABEL_63:
				//         v44 = (List_1_System_Object_ *)this.fields._.renderNodes;
				//         if ( !v44 )
				//           goto LABEL_79;
				//         v45 = System::Collections::Generic::List<System::Object>::get_Item(
				//                 v44,
				//                 i,
				//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//         if ( !v45 )
				//           goto LABEL_79;
				//         v46 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
				//                 (VolumetricRenderer_VolumetricRenderNode *)v45,
				//                 0LL);
				//         v44 = (List_1_System_Object_ *)this.fields._.renderNodes;
				//         material[0] = v46;
				//         if ( !v44 )
				//           goto LABEL_79;
				//         v47 = System::Collections::Generic::List<System::Object>::get_Item(
				//                 v44,
				//                 i,
				//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//         if ( !v47 )
				//           goto LABEL_79;
				//         v48 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
				//                 (VolumetricRenderer_VolumetricRenderNode *)v47,
				//                 0LL);
				//         if ( !v48
				//           || (shader = UnityEngine::Material::get_shader(v48, 0LL),
				//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
				//               s_DisableDepthWrite = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_DisableDepthWrite,
				//               memset(&v127, 0, 24),
				//               UnityEngine::Rendering::LocalKeyword::LocalKeyword(
				//                 (LocalKeyword *)&v127,
				//                 shader,
				//                 s_DisableDepthWrite,
				//                 0LL),
				//               v124.m_BufferPointer = v127.SrcColor,
				//               *(_OWORD *)&v124.m_Type = *(_OWORD *)&v127.Cmd,
				//               !cmd) )
				//         {
				// LABEL_79:
				//           sub_180B536AC(v44, v9);
				//         }
				//         UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, material[0], (LocalKeyword *)&v124, 0LL);
				//       }
				//     }
				//     volumetricParameters = this.fields._.renderNodes;
				//     if ( !volumetricParameters )
				//       goto LABEL_85;
				//     v51 = System::Collections::Generic::List<System::Object>::get_Item(
				//             (List_1_System_Object_ *)volumetricParameters,
				//             i,
				//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     sub_1802F01E0(&v126, 0LL, 72LL);
				//     v126.Cmd = cmd;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v126,
				//       v52,
				//       v53,
				//       v54,
				//       (MethodInfo *)P3,
				//       v93,
				//       v100,
				//       v106,
				//       v112,
				//       v118,
				//       v124.m_Type,
				//       v124.m_InstanceID,
				//       (MethodInfo *)v124.m_BufferPointer);
				//     if ( LOBYTE(v113) )
				//       v56 = i == 0;
				//     else
				//       v56 = 0;
				//     v126.bFirstInPass = v56;
				//     v57 = inputs.volumetricParameters;
				//     if ( !v57 )
				//       goto LABEL_80;
				//     v126.bEnableDownScale = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//                               v57.fields.enableDownRes,
				//                               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     v60 = this.fields._.renderer;
				//     if ( !v60 )
				//       goto LABEL_80;
				//     v126.bEnableFraming = v60.fields.m_EnableFraming;
				//     v61 = this.fields._.renderer;
				//     if ( !v61 )
				//       goto LABEL_80;
				//     v126.bEnableTAA = v61.fields.m_EnableTAA;
				//     v126.Stage = this.fields._.stage;
				//     v126.SrcColor = *colorRT;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v126.SrcColor,
				//       v55,
				//       v58,
				//       v59,
				//       (MethodInfo *)P3a,
				//       v95,
				//       v101,
				//       v107,
				//       v113,
				//       v119,
				//       v124.m_Type,
				//       v124.m_InstanceID,
				//       (MethodInfo *)v124.m_BufferPointer);
				//     v126.SrcDepths = *depthsRT;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v126.SrcDepths,
				//       v62,
				//       v63,
				//       (Material *)v126.SrcDepths,
				//       (MethodInfo *)P3b,
				//       v96,
				//       v102,
				//       v108,
				//       v114,
				//       v120,
				//       v124.m_Type,
				//       v124.m_InstanceID,
				//       (MethodInfo *)v124.m_BufferPointer);
				//     v126.DstColor = m_ComposeColor;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v126.DstColor,
				//       v64,
				//       v65,
				//       v66,
				//       (MethodInfo *)P3c,
				//       v97,
				//       v103,
				//       v109,
				//       v115,
				//       v121,
				//       v124.m_Type,
				//       v124.m_InstanceID,
				//       (MethodInfo *)v124.m_BufferPointer);
				//     v126.DstDepths = m_ComposeDepth;
				//     sub_1800054D0(
				//       (VolumetricRenderer_VolumetricRenderItem *)&v126.DstDepths,
				//       v67,
				//       v68,
				//       v69,
				//       (MethodInfo *)P3d,
				//       v98,
				//       v104,
				//       v110,
				//       v116,
				//       v122,
				//       v124.m_Type,
				//       v124.m_InstanceID,
				//       (MethodInfo *)v124.m_BufferPointer);
				//     if ( !v51 )
				// LABEL_80:
				//       sub_180B536AC(v57, v55);
				//     v127 = v126;
				//     HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
				//       (VolumetricRenderer_VolumetricRenderNode *)v51,
				//       &v127,
				//       0LL);
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//   VolumetricComposeColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._VolumetricComposeColor;
				//   v71 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
				//   v72 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v127, v71, 0LL);
				//   if ( !cmd )
				//     sub_180B536AC(v74, v73);
				//   v75 = *(_OWORD *)&v72.m_BufferPointer;
				//   *(_OWORD *)&v124.m_Type = *(_OWORD *)&v72.m_Type;
				//   *(_QWORD *)&v124.m_DepthSlice = *(_QWORD *)&v72.m_DepthSlice;
				//   *(_OWORD *)&v124.m_BufferPointer = v75;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v124, 0LL);
				//   VolumetricComposeDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._VolumetricComposeDepth;
				//   v77 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
				//   v78 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v127, v77, 0LL);
				//   v79 = *(_OWORD *)&v78.m_BufferPointer;
				//   *(_OWORD *)&v124.m_Type = *(_OWORD *)&v78.m_Type;
				//   *(_QWORD *)&v124.m_DepthSlice = *(_QWORD *)&v78.m_DepthSlice;
				//   *(_OWORD *)&v124.m_BufferPointer = v79;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v124, 0LL);
				//   *colorRT = m_ComposeColor;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)colorRT,
				//     v80,
				//     v81,
				//     v82,
				//     (MethodInfo *)P3,
				//     v93,
				//     v100,
				//     v106,
				//     v112,
				//     v118,
				//     v124.m_Type,
				//     v124.m_InstanceID,
				//     (MethodInfo *)v124.m_BufferPointer);
				//   *depthsRT = m_ComposeDepth;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)depthsRT,
				//     v83,
				//     v84,
				//     v85,
				//     (MethodInfo *)P3e,
				//     v99,
				//     v105,
				//     v111,
				//     v117,
				//     v123,
				//     v124.m_Type,
				//     v124.m_InstanceID,
				//     (MethodInfo *)v124.m_BufferPointer);
				// }
				// 
			}

			public void <>iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2)
			{
				// // Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderInputs *P0,
				//         VolumetricPipelineRT **P1,
				//         VolumetricPipelineRT **P2,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     P0,
				//     P1,
				//     P2,
				//     0LL);
				// }
				// 
			}
		}

		private class TemporalStage : VolumetricRenderer.VolumetricRenderStage
		{
			public TemporalStage(VolumetricRenderer inRenderer, EVolumetricStage inStage)
			{
				// // VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderer *inRenderer,
				//         EVolumetricStage__Enum inStage,
				//         MethodInfo *method)
				// {
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
				//   VolumetricRenderer_VolumetricBounds *v7; // r8
				//   Material *v8; // r9
				//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
				//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
				//   int32_t v11; // [rsp+60h] [rbp+38h]
				//   int32_t v12; // [rsp+68h] [rbp+40h]
				//   float v13; // [rsp+70h] [rbp+48h]
				//   int32_t v14; // [rsp+78h] [rbp+50h]
				//   bool v15; // [rsp+80h] [rbp+58h]
				//   bool v16; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v17; // [rsp+90h] [rbp+68h]
				// 
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     inStage,
				//     0LL);
				//   this.fields._.renderer = inRenderer;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields._.renderer,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15,
				//     v16,
				//     v17);
				// }
				// 
			}

			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT)
			{
				// // Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::TemporalStage::ProcessImpl(
				//         VolumetricRenderer_TemporalStage *this,
				//         VolumetricRenderInputs *inputs,
				//         VolumetricPipelineRT **colorRT,
				//         VolumetricPipelineRT **depthsRT,
				//         MethodInfo *method)
				// {
				//   __int64 v9; // rdx
				//   SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
				//   HGRenderGraphContext *context; // r14
				//   VolumetricRenderer *renderer; // rdi
				//   CommandBuffer *cmd; // r14
				//   VolumetricRenderer *v14; // rax
				//   __int64 m_RTIndex; // rdi
				//   VolumetricPipelineRT__Array *m_TAAColors; // r12
				//   VolumetricPipelineRT__Array *m_TAADepths; // r15
				//   VolumetricRenderer *v18; // rax
				//   int32_t v19; // r8d
				//   int32_t v20; // ebx
				//   Texture *RT; // rax
				//   RenderTargetIdentifier *v22; // rax
				//   __int128 v23; // xmm1
				//   __int64 v24; // rdx
				//   VolumetricShaderIDs__StaticFields *static_fields; // rcx
				//   int32_t TAAHistoryDepth; // ebx
				//   Texture *v27; // rax
				//   RenderTargetIdentifier *v28; // rax
				//   __int128 v29; // xmm1
				//   __int64 v30; // rcx
				//   VolumetricPipelineRT *v31; // rcx
				//   RenderTexture *v32; // rbx
				//   VolumetricRenderer *v33; // rax
				//   VolumetricRenderer_VolumetricRenderItem *v34; // rbx
				//   int32_t TAACurrentColor; // r13d
				//   Texture *v36; // rax
				//   RenderTargetIdentifier *v37; // rax
				//   __int128 v38; // xmm1
				//   __int64 v39; // rdx
				//   VolumetricRenderer_VolumetricRenderItem *v40; // r13
				//   Texture *v41; // rax
				//   RenderTargetIdentifier *v42; // rax
				//   __int128 v43; // xmm1
				//   Object *Item; // rax
				//   List_1_System_Object_ *RenderNodes; // rax
				//   Object *v46; // rax
				//   VolumetricRenderer_VolumetricRenderNode *v47; // rbx
				//   Material *material; // rax
				//   bool v49; // al
				//   bool v50; // bl
				//   MethodInfo *v51; // rdx
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v52; // rdx
				//   void *meshFilter; // rcx
				//   int32_t TAABlendRatio; // ebx
				//   float FloatImpl; // xmm0_4
				//   int32_t TAAInvalidDepthBlendRatio; // ebx
				//   float v57; // xmm0_4
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v58; // rdx
				//   VolumetricRenderer_VolumetricBounds *v59; // r8
				//   Material *v60; // r9
				//   VolumetricRenderer_VolumetricBounds *v61; // r8
				//   Material *v62; // r9
				//   VolumetricRenderer *v63; // rax
				//   VolumetricRenderer *v64; // rax
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v65; // rdx
				//   VolumetricRenderer_VolumetricBounds *v66; // r8
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v67; // rdx
				//   __int64 v68; // rcx
				//   VolumetricRenderer_VolumetricBounds *v69; // r8
				//   Material *v70; // r9
				//   VolumetricRenderer_VolumetricBounds *v71; // r8
				//   Material *v72; // r9
				//   MethodInfo *v73; // r8
				//   VolumetricRenderer *v74; // rax
				//   __int64 v75; // xmm0_8
				//   float z; // eax
				//   int32_t v77; // r10d
				//   __int64 v78; // rdx
				//   VolumetricShaderIDs__StaticFields *v79; // rcx
				//   int32_t VolumetricComposeColor; // esi
				//   VolumetricPipelineRT *v81; // rcx
				//   Texture *v82; // rax
				//   RenderTargetIdentifier *v83; // rax
				//   __int128 v84; // xmm1
				//   __int64 v85; // rdx
				//   VolumetricShaderIDs__StaticFields *v86; // rcx
				//   int32_t VolumetricComposeDepth; // esi
				//   VolumetricPipelineRT *v88; // rcx
				//   Texture *v89; // rax
				//   RenderTargetIdentifier *v90; // rax
				//   __int128 v91; // xmm1
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v92; // rdx
				//   __int64 v93; // rcx
				//   VolumetricRenderer_VolumetricBounds *v94; // r8
				//   Material *v95; // r9
				//   VolumetricRenderer_VolumetricBounds *v96; // r8
				//   Material *v97; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *backface; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *backfacea; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *backfaceb; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *backfacef; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *backfacec; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *backfaced; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *backfacee; // [rsp+28h] [rbp-E0h]
				//   MethodInfo *v106; // [rsp+30h] [rbp-D8h]
				//   MethodInfo *v107; // [rsp+30h] [rbp-D8h]
				//   MethodInfo *v108; // [rsp+30h] [rbp-D8h]
				//   MethodInfo *v109; // [rsp+30h] [rbp-D8h]
				//   MethodInfo *v110; // [rsp+30h] [rbp-D8h]
				//   MethodInfo *v111; // [rsp+30h] [rbp-D8h]
				//   MethodInfo *v112; // [rsp+30h] [rbp-D8h]
				//   int32_t enableMV; // [rsp+38h] [rbp-D0h]
				//   int32_t enableMVa; // [rsp+38h] [rbp-D0h]
				//   int32_t enableMVe; // [rsp+38h] [rbp-D0h]
				//   int32_t enableMVb; // [rsp+38h] [rbp-D0h]
				//   int32_t enableMVc; // [rsp+38h] [rbp-D0h]
				//   int32_t enableMVd; // [rsp+38h] [rbp-D0h]
				//   RenderTexture *colorRTa; // [rsp+40h] [rbp-C8h]
				//   Vector4 colorRT_8; // [rsp+48h] [rbp-C0h] BYREF
				//   RenderTargetIdentifier v121; // [rsp+58h] [rbp-B0h] BYREF
				//   VolumetricRenderer_VolumetricRenderItem v122; // [rsp+88h] [rbp-80h] BYREF
				//   VolumetricRenderer_VolumetricCallbackContext v123; // [rsp+E8h] [rbp-20h] BYREF
				// 
				//   if ( !byte_18D9197E2 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     byte_18D9197E2 = 1;
				//   }
				//   sub_1802F01E0(&v122, 0LL, 72LL);
				//   if ( IFix::WrappersManagerImpl::IsPatched(4546, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4546, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
				//       return;
				//     }
				//     goto LABEL_67;
				//   }
				//   context = inputs.context;
				//   if ( !context )
				//     goto LABEL_67;
				//   renderer = this.fields._.renderer;
				//   cmd = context.fields.cmd;
				//   if ( !renderer )
				//     goto LABEL_67;
				//   v14 = this.fields._.renderer;
				//   m_RTIndex = renderer.fields.m_RTIndex;
				//   m_TAAColors = v14.fields.m_TAAColors;
				//   if ( !v14 )
				//     goto LABEL_67;
				//   m_TAADepths = v14.fields.m_TAADepths;
				//   v122.meshFilter = (MeshFilter *)v14.fields.m_VolumetricMat;
				//   v18 = this.fields._.renderer;
				//   if ( !v18 )
				//     goto LABEL_67;
				//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs.volumetricParameters;
				//   *(_QWORD *)&colorRT_8.x = v18.fields.m_PropertyBlock;
				//   if ( !volumetricParameters )
				//     goto LABEL_67;
				//   if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//          volumetricParameters[14],
				//          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//     v9 = *((unsigned int *)volumetricParameters + 241);
				//     if ( !cmd )
				//       goto LABEL_67;
				//     v19 = 1;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//     v9 = *((unsigned int *)volumetricParameters + 241);
				//     if ( !cmd )
				//       goto LABEL_67;
				//     v19 = 0;
				//   }
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, v9, v19, 0LL);
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   v20 = *((_DWORD *)volumetricParameters + 244);
				//   if ( !m_TAAColors )
				//     goto LABEL_67;
				//   if ( (unsigned int)(1 - m_RTIndex) >= m_TAAColors.max_length.size )
				//     sub_180070270(volumetricParameters, v9);
				//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)m_TAAColors.vector[1 - (int)m_RTIndex];
				//   if ( !volumetricParameters )
				// LABEL_67:
				//     sub_180B536AC(volumetricParameters, v9);
				//   RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
				//                     (VolumetricPipelineRT *)volumetricParameters,
				//                     0LL);
				//   v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v123, RT, 0LL);
				//   v23 = *(_OWORD *)&v22.m_BufferPointer;
				//   *(_OWORD *)&v121.m_Type = *(_OWORD *)&v22.m_Type;
				//   *(_QWORD *)&v121.m_DepthSlice = *(_QWORD *)&v22.m_DepthSlice;
				//   *(_OWORD *)&v121.m_BufferPointer = v23;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v20, &v121, 0LL);
				//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   TAAHistoryDepth = static_fields._TAAHistoryDepth;
				//   if ( !m_TAADepths )
				//     goto LABEL_65;
				//   if ( (unsigned int)(1 - m_RTIndex) >= m_TAADepths.max_length.size )
				//     sub_180070270(static_fields, v24);
				//   static_fields = (VolumetricShaderIDs__StaticFields *)m_TAADepths.vector[1 - (int)m_RTIndex];
				//   if ( !static_fields )
				// LABEL_65:
				//     sub_180B536AC(static_fields, v24);
				//   v27 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)static_fields, 0LL);
				//   v28 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v123, v27, 0LL);
				//   v29 = *(_OWORD *)&v28.m_BufferPointer;
				//   *(_OWORD *)&v121.m_Type = *(_OWORD *)&v28.m_Type;
				//   *(_QWORD *)&v121.m_DepthSlice = *(_QWORD *)&v28.m_DepthSlice;
				//   *(_OWORD *)&v121.m_BufferPointer = v29;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, TAAHistoryDepth, &v121, 0LL);
				//   if ( (unsigned int)m_RTIndex >= m_TAAColors.max_length.size )
				//     goto LABEL_64;
				//   v31 = m_TAAColors.vector[m_RTIndex];
				//   if ( !v31 )
				//     goto LABEL_63;
				//   colorRTa = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v31, 0LL);
				//   if ( (unsigned int)m_RTIndex >= m_TAADepths.max_length.size )
				// LABEL_64:
				//     sub_180070270(v30, v9);
				//   v31 = m_TAADepths.vector[m_RTIndex];
				//   if ( !v31
				//     || (v32 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v31, 0LL),
				//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils),
				//         HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
				//           cmd,
				//           colorRTa,
				//           v32,
				//           RenderBufferLoadAction__Enum_DontCare,
				//           RenderBufferStoreAction__Enum_Store,
				//           0LL),
				//         (v33 = this.fields._.renderer) == 0LL) )
				//   {
				// LABEL_63:
				//     sub_180B536AC(v31, v9);
				//   }
				//   if ( v33.fields.m_CanMergeTAAPass )
				//   {
				//     volumetricParameters = (SettingParameter_1_System_Boolean_ **)v33.fields.m_RenderStages;
				//     if ( volumetricParameters )
				//     {
				//       Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
				//                (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
				//                (Int32Enum__Enum)1u,
				//                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
				//       if ( Item )
				//       {
				//         RenderNodes = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
				//                                                  (VolumetricRenderer_VolumetricRenderStage *)Item,
				//                                                  0LL);
				//         if ( RenderNodes )
				//         {
				//           v46 = System::Collections::Generic::List<System::Object>::get_Item(
				//                   RenderNodes,
				//                   0,
				//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
				//           LODWORD(colorRTa) = (_DWORD)v46;
				//           v47 = (VolumetricRenderer_VolumetricRenderNode *)v46;
				//           if ( v46 )
				//           {
				//             LOBYTE(enableMV) = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
				//                                  (VolumetricRenderer_VolumetricRenderNode *)v46,
				//                                  0LL);
				//             material = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(v47, 0LL);
				//             volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs.volumetricParameters;
				//             *(_QWORD *)&colorRT_8.x = material;
				//             if ( volumetricParameters )
				//             {
				//               v49 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//                       volumetricParameters[15],
				//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//               volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs.volumetricParameters;
				//               BYTE1(enableMV) = v49;
				//               if ( volumetricParameters )
				//               {
				//                 v50 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//                         volumetricParameters[16],
				//                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//                 HG::Rendering::Runtime::VolumetricSDFUtils::UpdateTemporalKeywords(
				//                   cmd,
				//                   *(Material **)&colorRT_8.x,
				//                   SBYTE1(enableMV),
				//                   v50,
				//                   0LL);
				//                 if ( !(_BYTE)enableMV )
				//                 {
				//                   colorRT_8 = (Vector4)*UnityEngine::Quaternion::get_identity((Quaternion *)&colorRT_8, v51);
				//                   UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(cmd, 0, 1, (Color *)&colorRT_8, 0LL);
				//                 }
				//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//                 meshFilter = v122.meshFilter;
				//                 TAABlendRatio = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._TAABlendRatio;
				//                 if ( !v122.meshFilter )
				//                   goto LABEL_62;
				//                 FloatImpl = UnityEngine::Material::GetFloatImpl((Material *)v122.meshFilter, TAABlendRatio, 0LL);
				//                 UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, TAABlendRatio, FloatImpl, 0LL);
				//                 TAAInvalidDepthBlendRatio = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._TAAInvalidDepthBlendRatio;
				//                 meshFilter = inputs.volumetricParameters;
				//                 if ( !meshFilter )
				//                   goto LABEL_62;
				//                 v57 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
				//                         *((SettingParameter_1_System_Single_ **)meshFilter + 19),
				//                         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
				//                 UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, TAAInvalidDepthBlendRatio, v57, 0LL);
				//                 v122.Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)cmd;
				//                 sub_1800054D0(
				//                   &v122,
				//                   v58,
				//                   v59,
				//                   v60,
				//                   backfacea,
				//                   v106,
				//                   enableMV,
				//                   (int32_t)colorRTa,
				//                   colorRT_8.x,
				//                   SLODWORD(colorRT_8.z),
				//                   v121.m_Type,
				//                   v121.m_InstanceID,
				//                   (MethodInfo *)v121.m_BufferPointer);
				//                 meshFilter = inputs.volumetricParameters;
				//                 LOBYTE(v122.material) = enableMVa;
				//                 if ( !meshFilter
				//                   || (BYTE1(v122.material) = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//                                                *((SettingParameter_1_System_Boolean_ **)meshFilter + 2),
				//                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit),
				//                       (v63 = this.fields._.renderer) == 0LL)
				//                   || (BYTE2(v122.material) = v63.fields.m_EnableFraming, (v64 = this.fields._.renderer) == 0LL) )
				//                 {
				// LABEL_62:
				//                   sub_180B536AC(meshFilter, v52);
				//                 }
				//                 v34 = (VolumetricRenderer_VolumetricRenderItem *)colorRT;
				//                 BYTE3(v122.material) = v64.fields.m_EnableTAA;
				//                 HIDWORD(v122.material) = this.fields._.stage;
				//                 *(_QWORD *)&v122.bounds.enableBounds = *colorRT;
				//                 sub_1800054D0(
				//                   (VolumetricRenderer_VolumetricRenderItem *)&v122.bounds,
				//                   v52,
				//                   v61,
				//                   v62,
				//                   backfaceb,
				//                   v108,
				//                   enableMVa,
				//                   (int32_t)colorRTa,
				//                   colorRT_8.x,
				//                   SLODWORD(colorRT_8.z),
				//                   v121.m_Type,
				//                   v121.m_InstanceID,
				//                   (MethodInfo *)v121.m_BufferPointer);
				//                 v40 = (VolumetricRenderer_VolumetricRenderItem *)depthsRT;
				//                 *(_QWORD *)&v122.bounds.worldBounds.m_Center.y = *depthsRT;
				//                 sub_1800054D0(
				//                   (VolumetricRenderer_VolumetricRenderItem *)&v122.bounds.worldBounds.m_Center.y,
				//                   v65,
				//                   v66,
				//                   *(Material **)&v122.bounds.worldBounds.m_Center.y,
				//                   backfacef,
				//                   v109,
				//                   enableMVe,
				//                   (int32_t)colorRTa,
				//                   colorRT_8.x,
				//                   SLODWORD(colorRT_8.z),
				//                   v121.m_Type,
				//                   v121.m_InstanceID,
				//                   (MethodInfo *)v121.m_BufferPointer);
				//                 if ( (unsigned int)m_RTIndex >= m_TAAColors.max_length.size
				//                   || (*(_QWORD *)&v122.bounds.worldBounds.m_Extents.x = m_TAAColors.vector[m_RTIndex],
				//                       sub_1800054D0(
				//                         (VolumetricRenderer_VolumetricRenderItem *)&v122.bounds.worldBounds.m_Extents,
				//                         v67,
				//                         v69,
				//                         v70,
				//                         backfacec,
				//                         v110,
				//                         enableMVb,
				//                         (int32_t)colorRTa,
				//                         colorRT_8.x,
				//                         SLODWORD(colorRT_8.z),
				//                         v121.m_Type,
				//                         v121.m_InstanceID,
				//                         (MethodInfo *)v121.m_BufferPointer),
				//                       (unsigned int)m_RTIndex >= m_TAADepths.max_length.size) )
				//                 {
				//                   sub_180070270(v68, v67);
				//                 }
				//                 *(_QWORD *)&v122.bounds.worldBounds.m_Extents.z = m_TAADepths.vector[m_RTIndex];
				//                 sub_1800054D0(
				//                   (VolumetricRenderer_VolumetricRenderItem *)&v122.bounds.worldBounds.m_Extents.z,
				//                   v67,
				//                   v71,
				//                   v72,
				//                   backfaced,
				//                   v111,
				//                   enableMVc,
				//                   (int32_t)colorRTa,
				//                   colorRT_8.x,
				//                   SLODWORD(colorRT_8.z),
				//                   v121.m_Type,
				//                   v121.m_InstanceID,
				//                   (MethodInfo *)v121.m_BufferPointer);
				//                 *(_OWORD *)&v123.Cmd = *(_OWORD *)&v122.Callback;
				//                 *(_OWORD *)&v123.DstColor = *(_OWORD *)&v122.bounds.worldBounds.m_Extents.x;
				//                 *(_OWORD *)&v123.SrcColor = *(_OWORD *)&v122.bounds.enableBounds;
				//                 v123.MSBakeMaterial = *(Material **)&v122.bPureBlit;
				//                 *(_OWORD *)&v123.meshFilter = *(_OWORD *)&v122.SortingOrder;
				//                 HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
				//                   (VolumetricRenderer_VolumetricRenderNode *)colorRTa,
				//                   &v123,
				//                   0LL);
				//                 goto LABEL_48;
				//               }
				//             }
				//           }
				//         }
				//       }
				//     }
				//     goto LABEL_67;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//   v34 = (VolumetricRenderer_VolumetricRenderItem *)colorRT;
				//   TAACurrentColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._TAACurrentColor;
				//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)*colorRT;
				//   if ( !*colorRT )
				//     goto LABEL_67;
				//   v36 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
				//                      (VolumetricPipelineRT *)volumetricParameters,
				//                      0LL);
				//   v37 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v123, v36, 0LL);
				//   v38 = *(_OWORD *)&v37.m_BufferPointer;
				//   *(_OWORD *)&v121.m_Type = *(_OWORD *)&v37.m_Type;
				//   *(_QWORD *)&v121.m_DepthSlice = *(_QWORD *)&v37.m_DepthSlice;
				//   *(_OWORD *)&v121.m_BufferPointer = v38;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, TAACurrentColor, &v121, 0LL);
				//   v40 = (VolumetricRenderer_VolumetricRenderItem *)depthsRT;
				//   LODWORD(colorRTa) = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._TAACurrentDepth;
				//   if ( !*depthsRT )
				//     sub_180B536AC(0LL, v39);
				//   v41 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(*depthsRT, 0LL);
				//   v42 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v123, v41, 0LL);
				//   v43 = *(_OWORD *)&v42.m_BufferPointer;
				//   *(_OWORD *)&v121.m_Type = *(_OWORD *)&v42.m_Type;
				//   *(_QWORD *)&v121.m_DepthSlice = *(_QWORD *)&v42.m_DepthSlice;
				//   *(_OWORD *)&v121.m_BufferPointer = v43;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, (int32_t)colorRTa, &v121, 0LL);
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//   HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
				//     cmd,
				//     (Material *)v122.meshFilter,
				//     *(MaterialPropertyBlock **)&colorRT_8.x,
				//     2,
				//     0,
				//     0LL);
				// LABEL_48:
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//   volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   v74 = this.fields._.renderer;
				//   if ( !v74 )
				//     goto LABEL_67;
				//   v75 = *(_QWORD *)&v74.fields.PrevCameraPos.x;
				//   z = v74.fields.PrevCameraPos.z;
				//   *(_QWORD *)&colorRT_8.x = v75;
				//   colorRT_8.z = z;
				//   colorRT_8 = *UnityEngine::Vector4::op_Implicit((Vector4 *)&v122.meshFilter, (Vector3 *)&colorRT_8, v73);
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v77, &colorRT_8, 0LL);
				//   v79 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   VolumetricComposeColor = v79._VolumetricComposeColor;
				//   if ( (unsigned int)m_RTIndex >= m_TAAColors.max_length.size )
				//     sub_180070270(v79, v78);
				//   v81 = m_TAAColors.vector[m_RTIndex];
				//   if ( !v81 )
				//     sub_180B536AC(0LL, v78);
				//   v82 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v81, 0LL);
				//   v83 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v123, v82, 0LL);
				//   v84 = *(_OWORD *)&v83.m_BufferPointer;
				//   *(_OWORD *)&v121.m_Type = *(_OWORD *)&v83.m_Type;
				//   *(_QWORD *)&v121.m_DepthSlice = *(_QWORD *)&v83.m_DepthSlice;
				//   *(_OWORD *)&v121.m_BufferPointer = v84;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v121, 0LL);
				//   v86 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//   VolumetricComposeDepth = v86._VolumetricComposeDepth;
				//   if ( (unsigned int)m_RTIndex >= m_TAADepths.max_length.size )
				//     sub_180070270(v86, v85);
				//   v88 = m_TAADepths.vector[m_RTIndex];
				//   if ( !v88 )
				//     sub_180B536AC(0LL, v85);
				//   v89 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v88, 0LL);
				//   v90 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v123, v89, 0LL);
				//   v91 = *(_OWORD *)&v90.m_BufferPointer;
				//   *(_OWORD *)&v121.m_Type = *(_OWORD *)&v90.m_Type;
				//   *(_QWORD *)&v121.m_DepthSlice = *(_QWORD *)&v90.m_DepthSlice;
				//   *(_OWORD *)&v121.m_BufferPointer = v91;
				//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v121, 0LL);
				//   if ( (unsigned int)m_RTIndex >= m_TAAColors.max_length.size
				//     || (v34.Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)m_TAAColors.vector[m_RTIndex],
				//         sub_1800054D0(
				//           v34,
				//           v92,
				//           v94,
				//           v95,
				//           backface,
				//           v107,
				//           enableMV,
				//           (int32_t)colorRTa,
				//           colorRT_8.x,
				//           SLODWORD(colorRT_8.z),
				//           v121.m_Type,
				//           v121.m_InstanceID,
				//           (MethodInfo *)v121.m_BufferPointer),
				//         (unsigned int)m_RTIndex >= m_TAADepths.max_length.size) )
				//   {
				//     sub_180070270(v93, v92);
				//   }
				//   v40.Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)m_TAADepths.vector[m_RTIndex];
				//   sub_1800054D0(
				//     v40,
				//     v92,
				//     v96,
				//     v97,
				//     backfacee,
				//     v112,
				//     enableMVd,
				//     (int32_t)colorRTa,
				//     colorRT_8.x,
				//     SLODWORD(colorRT_8.z),
				//     v121.m_Type,
				//     v121.m_InstanceID,
				//     (MethodInfo *)v121.m_BufferPointer);
				// }
				// 
			}

			public void <>iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2)
			{
				// // Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderInputs *P0,
				//         VolumetricPipelineRT **P1,
				//         VolumetricPipelineRT **P2,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     P0,
				//     P1,
				//     P2,
				//     0LL);
				// }
				// 
			}
		}

		private class SceneComposeStage : VolumetricRenderer.VolumetricRenderStage
		{
			public SceneComposeStage(VolumetricRenderer inRenderer, EVolumetricStage inStage)
			{
				// // VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderer *inRenderer,
				//         EVolumetricStage__Enum inStage,
				//         MethodInfo *method)
				// {
				//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
				//   VolumetricRenderer_VolumetricBounds *v7; // r8
				//   Material *v8; // r9
				//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
				//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
				//   int32_t v11; // [rsp+60h] [rbp+38h]
				//   int32_t v12; // [rsp+68h] [rbp+40h]
				//   float v13; // [rsp+70h] [rbp+48h]
				//   int32_t v14; // [rsp+78h] [rbp+50h]
				//   bool v15; // [rsp+80h] [rbp+58h]
				//   bool v16; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v17; // [rsp+90h] [rbp+68h]
				// 
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     inStage,
				//     0LL);
				//   this.fields._.renderer = inRenderer;
				//   sub_1800054D0(
				//     (VolumetricRenderer_VolumetricRenderItem *)&this.fields._.renderer,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15,
				//     v16,
				//     v17);
				// }
				// 
			}

			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT)
			{
				// // Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::ProcessImpl(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderInputs *inputs,
				//         VolumetricPipelineRT **colorRT,
				//         VolumetricPipelineRT **depthsRT,
				//         MethodInfo *method)
				// {
				//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
				//   SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
				//   HGRenderGraphContext *context; // rdi
				//   CommandBuffer *cmd; // rdi
				//   BOOL v13; // r13d
				//   int32_t VolumetricColor; // r12d
				//   Texture *RT; // rax
				//   RenderTargetIdentifier *v16; // rax
				//   __int64 v17; // rdx
				//   VolumetricPipelineRT *v18; // rcx
				//   __int128 v19; // xmm1
				//   int32_t VolumetricDepth; // esi
				//   Texture *v21; // rax
				//   RenderTargetIdentifier *v22; // rax
				//   __int128 v23; // xmm1
				//   TextureHandle sceneColor; // xmm6
				//   Texture *v25; // rax
				//   RenderTargetIdentifier *v26; // rax
				//   __int128 v27; // xmm7
				//   __int128 v28; // xmm8
				//   Texture *v29; // rax
				//   RenderTargetIdentifier *v30; // rax
				//   __int128 v31; // xmm1
				//   __int64 v32; // xmm0_8
				//   VolumetricRenderer *renderer; // rbx
				//   Material *m_VolumetricMat; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   TextureHandle sceneDepth; // [rsp+48h] [rbp-71h] BYREF
				//   RenderTargetIdentifier v37; // [rsp+58h] [rbp-61h] BYREF
				//   RenderTargetIdentifier v38[2]; // [rsp+88h] [rbp-31h] BYREF
				// 
				//   if ( !byte_18D9197E3 )
				//   {
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//     byte_18D9197E3 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4548, 0LL) )
				//   {
				//     context = inputs.context;
				//     if ( context )
				//     {
				//       volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs.volumetricParameters;
				//       cmd = context.fields.cmd;
				//       if ( volumetricParameters )
				//       {
				//         v13 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
				//                 volumetricParameters[2],
				//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
				//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
				//         volumetricParameters = (SettingParameter_1_System_Boolean_ **)*colorRT;
				//         VolumetricColor = static_fields._VolumetricColor;
				//         if ( *colorRT )
				//         {
				//           RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
				//                             (VolumetricPipelineRT *)volumetricParameters,
				//                             0LL);
				//           v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, RT, 0LL);
				//           if ( !cmd
				//             || (v19 = *(_OWORD *)&v16.m_BufferPointer,
				//                 *(_OWORD *)&v37.m_Type = *(_OWORD *)&v16.m_Type,
				//                 *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v16.m_DepthSlice,
				//                 *(_OWORD *)&v37.m_BufferPointer = v19,
				//                 UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricColor, &v37, 0LL),
				//                 VolumetricDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._VolumetricDepth,
				//                 (v18 = *depthsRT) == 0LL) )
				//           {
				//             sub_180B536AC(v18, v17);
				//           }
				//           v21 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v18, 0LL);
				//           v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, v21, 0LL);
				//           v23 = *(_OWORD *)&v22.m_BufferPointer;
				//           *(_OWORD *)&v37.m_Type = *(_OWORD *)&v22.m_Type;
				//           *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v22.m_DepthSlice;
				//           *(_OWORD *)&v37.m_BufferPointer = v23;
				//           UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricDepth, &v37, 0LL);
				//           sceneColor = inputs.sceneColor;
				//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//           sceneDepth = sceneColor;
				//           v25 = (Texture *)HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&sceneDepth, 0LL);
				//           v26 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, v25, 0LL);
				//           v27 = *(_OWORD *)&v26.m_Type;
				//           v28 = *(_OWORD *)&v26.m_BufferPointer;
				//           sceneColor.handle = *(ResourceHandle *)&v26.m_DepthSlice;
				//           sceneDepth = inputs.sceneDepth;
				//           v29 = (Texture *)HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&sceneDepth, 0LL);
				//           v30 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, v29, 0LL);
				//           v31 = *(_OWORD *)&v30.m_BufferPointer;
				//           *(_OWORD *)&v37.m_Type = *(_OWORD *)&v30.m_Type;
				//           v32 = *(_QWORD *)&v30.m_DepthSlice;
				//           *(_OWORD *)&v37.m_BufferPointer = v31;
				//           *(_QWORD *)&v37.m_DepthSlice = v32;
				//           *(_OWORD *)&v38[0].m_Type = v27;
				//           *(_OWORD *)&v38[0].m_BufferPointer = v28;
				//           *(ResourceHandle *)&v38[0].m_DepthSlice = sceneColor.handle;
				//           UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
				//             cmd,
				//             v38,
				//             RenderBufferLoadAction__Enum_Load,
				//             RenderBufferStoreAction__Enum_Store,
				//             &v37,
				//             RenderBufferLoadAction__Enum_Load,
				//             RenderBufferStoreAction__Enum_Store,
				//             0LL);
				//           renderer = this.fields._.renderer;
				//           if ( renderer )
				//           {
				//             m_VolumetricMat = renderer.fields.m_VolumetricMat;
				//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
				//             HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, m_VolumetricMat, !v13 + 3, 0, 0LL);
				//             return;
				//           }
				//         }
				//       }
				//     }
				// LABEL_13:
				//     sub_180B536AC(volumetricParameters, static_fields);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4548, 0LL);
				//   if ( !Patch )
				//     goto LABEL_13;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
				// }
				// 
			}

			public void <>iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2)
			{
				// // Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
				// void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
				//         VolumetricRenderer_SceneComposeStage *this,
				//         VolumetricRenderInputs *P0,
				//         VolumetricPipelineRT **P1,
				//         VolumetricPipelineRT **P2,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
				//     (VolumetricRenderer_VolumetricRenderStage *)this,
				//     P0,
				//     P1,
				//     P2,
				//     0LL);
				// }
				// 
			}
		}

		private class VolumetricStageComparer : IEqualityComparer<EVolumetricStage>
		{
			public VolumetricStageComparer()
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

			public bool Equals(EVolumetricStage x, EVolumetricStage y)
			{
				// // Boolean Equals(EVolumetricStage, EVolumetricStage)
				// bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricStageComparer::Equals(
				//         VolumetricRenderer_VolumetricStageComparer *this,
				//         EVolumetricStage__Enum x,
				//         EVolumetricStage__Enum y,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4549, 0LL) )
				//     return x == y;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4549, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v10, v9);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_12 *)Patch, (Object *)this, x, y, 0LL);
				// }
				// 
				return default(bool);
			}

			public int GetHashCode(EVolumetricStage obj)
			{
				// // Int32 GetHashCode(EVolumetricStage)
				// int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricStageComparer::GetHashCode(
				//         VolumetricRenderer_VolumetricStageComparer *this,
				//         EVolumetricStage__Enum obj,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4550, 0LL) )
				//     return obj;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4550, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v8, v7);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, obj, 0LL);
				// }
				// 
				return 0;
			}
		}
	}
}
