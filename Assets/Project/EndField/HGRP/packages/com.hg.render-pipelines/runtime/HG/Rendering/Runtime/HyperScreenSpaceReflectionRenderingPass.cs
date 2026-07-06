using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class HyperScreenSpaceReflectionRenderingPass : IPassConstructor
	{
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle ssrLightingTexture
		{
			get
			{
				// // AnimationClipPlayable get_playable()
				// AnimationClipPlayable *Beyond::Playables::SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_::PlayableNode<System::Object,UnityEngine::Animations::AnimationClipPlayable,UnityEngine::Animations::AnimationMixerPlayable,UnityEngine::Animations::AnimationPlayableOutput>::get_playable(
				//         AnimationClipPlayable *__return_ptr retstr,
				//         SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_PlayableNode_System_Object_UnityEngine_Animations_AnimationClipPlayable_UnityEngine_Animations_AnimationMixerPlayable_UnityEngine_Animations_AnimationPlayableOutput_ *this,
				//         MethodInfo *method)
				// {
				//   AnimationClipPlayable *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields._playable_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600110A RID: 4362 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle ssrFadenessTexture
		{
			get
			{
				// // NpcProxyOverrideEnvTalk+EnvTalkStruct get_value()
				// NpcProxyOverrideEnvTalk_EnvTalkStruct *Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Actions::NpcProxyOverrideEnvTalk::EnvTalkStruct>::get_value(
				//         NpcProxyOverrideEnvTalk_EnvTalkStruct *__return_ptr retstr,
				//         ParamVariable_1_Beyond_Gameplay_Actions_NpcProxyOverrideEnvTalk_EnvTalkStruct_ *this,
				//         MethodInfo *method)
				// {
				//   NpcProxyOverrideEnvTalk_EnvTalkStruct *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_value;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public HyperScreenSpaceReflectionRenderingPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // HyperScreenSpaceReflectionRenderingPass(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HyperScreenSpaceReflectionRenderingPass(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   __int64 v9; // rcx
			//   MaterialPropertyBlock *v10; // rbp
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   __int64 v14; // rdx
			//   Texture2D *blackTexture; // rbp
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *v22; // rax
			//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
			//   PassConstructorID__Enum__Array *v24; // r8
			//   HGCamera *v25; // r9
			//   MethodInfo *v26; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v27; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v28; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v29; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDAB5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDAB5 = 1;
			//   }
			//   *(_WORD *)&this.fields.m_firstFrame = 257;
			//   this.fields.m_previousRenderSize = (Vector2Int)sub_182E7BD70(this, materialCollector, resources);
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, v7);
			//   this.fields.m_ssrLightingTexture = *(TextureHandle *)sub_182E7CCD0(&v26);
			//   this.fields.m_ssrFadenessTexture = *(TextureHandle *)sub_182E7CCD0(&v26);
			//   v10 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//   if ( !v10 )
			//     goto LABEL_14;
			//   v10.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.m_transparentMBP = v10;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_transparentMBP, v11, v12, v13, v26, v27);
			//   blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RTHandles._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RTHandles, v14);
			//   this.fields.m_defaultTexutre = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)blackTexture, 0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_defaultTexutre, v16, v17, v18, v26, v27);
			//   if ( !resources.defaultResources
			//     || (shaders = resources.defaultResources.fields.shaders) == 0LL
			//     || (this.fields.m_computeShader = shaders.fields.screenSpaceReflectionCS,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_computeShader, v8, v19, v20, v26, v27),
			//         !resources.defaultResources)
			//     || (v22 = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector )
			//   {
			// LABEL_14:
			//     sub_180B536AC(v9, v8);
			//   }
			//   this.fields.m_pixelShader = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                  materialCollector,
			//                                  v22.fields.screenSpaceReflectionPS,
			//                                  0,
			//                                  0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_pixelShader, v23, v24, v25, v28, v29);
			// }
			// 
		}

		public bool ShouldRender(ref HyperScreenSpaceReflectionRenderingPass.PassInput input, HGCamera hgCamera)
		{
			// // Boolean ShouldRender(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HGCamera)
			// bool HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRender(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HyperScreenSpaceReflectionRenderingPass_PassInput *input,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9195B3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9195B3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2782, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2782, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1017(Patch, (Object *)this, input, (Object *)hgCamera, 0LL);
			// LABEL_11:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_11;
			//   if ( !HG::Rendering::Runtime::HGCamera::get_ssrEnable(hgCamera, 0LL) )
			//     return 0;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.previousSceneColorTexture, 0LL) )
			//     return 0;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.previousSceneDepthPyramidTexture, 0LL) )
			//     return 0;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   return HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.currentSceneDepthPyramidTexture, 0LL);
			// }
			// 
			return default(bool);
		}

		private void PreparePassData(ref HyperScreenSpaceReflectionRenderingPass.PassInput input, HGCamera hgCamera, HyperScreenSpaceReflectionRenderingPass.PassData passData, [MetadataOffset(Offset = "0x01F9189D")] bool wetnessEnabled = false)
		{
			// // Void PreparePassData(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HGCamera, HyperScreenSpaceReflectionRenderingPass+PassData, Boolean)
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PreparePassData(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HyperScreenSpaceReflectionRenderingPass_PassInput *input,
			//         HGCamera *hgCamera,
			//         HyperScreenSpaceReflectionRenderingPass_PassData *passData,
			//         bool wetnessEnabled,
			//         MethodInfo *method)
			// {
			//   BOOL useWetnessMask; // r14d
			//   VirtualMachine *virtualMachine; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   float v15; // xmm0_4
			//   HGCamera_VolumeComponentsData *v16; // rax
			//   float v17; // xmm10_4
			//   ScreenSpaceReflectionVolume *m_hgssrVolume; // rax
			//   float v19; // xmm0_4
			//   HGCamera_VolumeComponentsData *v20; // rax
			//   float v21; // xmm7_4
			//   ScreenSpaceReflectionVolume *v22; // rax
			//   float v23; // xmm0_4
			//   HGCamera_VolumeComponentsData *v24; // rax
			//   float v25; // xmm6_4
			//   ScreenSpaceReflectionVolume *v26; // rax
			//   float v27; // xmm0_4
			//   HGCamera_VolumeComponentsData *v28; // rax
			//   float v29; // xmm9_4
			//   ScreenSpaceReflectionVolume *v30; // rax
			//   float v31; // xmm8_4
			//   char v32; // dl
			//   __int64 v33; // rcx
			//   int v34; // r8d
			//   int v35; // eax
			//   int32_t v36; // r12d
			//   Vector3Int *v37; // r8
			//   ITilemap *v38; // r9
			//   int32_t m_frameIndex; // eax
			//   __m128i v40; // xmm2
			//   uint32_t v41; // xmm0_4
			//   float m_Y; // xmm1_4
			//   uint32_t v43; // xmm0_4
			//   __m128i v44; // xmm1
			//   unsigned int v45; // edx
			//   int v46; // eax
			//   TileBase *v47; // rdx
			//   __int64 v48; // rt2
			//   bool v49; // zf
			//   uint32_t v50; // xmm2_4
			//   __m128i v51; // xmm2
			//   __m128i v52; // xmm1
			//   float v53; // xmm6_4
			//   float v54; // xmm0_4
			//   TileBase *v55; // rdx
			//   Vector3Int *v56; // r8
			//   ITilemap *v57; // r9
			//   TileBase *v58; // rdx
			//   Vector3Int *v59; // r8
			//   ITilemap *v60; // r9
			//   TileBase *v61; // rdx
			//   Vector3Int *v62; // r8
			//   ITilemap *v63; // r9
			//   Vector4 v64; // xmm1
			//   Vector4 v65; // xmm0
			//   Vector4 v66; // xmm1
			//   Vector4 v67; // xmm0
			//   Vector4 v68; // xmm1
			//   Vector4 v69; // xmm0
			//   Vector4 v70; // xmm1
			//   Vector4 v71; // xmm0
			//   Vector4 v72; // xmm1
			//   CBHandle *v73; // rax
			//   HGRenderPathBase_HGRenderPathResources *v74; // rdx
			//   PassConstructorID__Enum__Array *v75; // r8
			//   HGCamera *v76; // r9
			//   MethodInfo *P3; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3a; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3b; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3c; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P3d; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *P4; // [rsp+30h] [rbp-D8h]
			//   CBHandle v83; // [rsp+48h] [rbp-C0h] BYREF
			//   _QWORD v84[3]; // [rsp+60h] [rbp-A8h] BYREF
			//   Vector4 v85; // [rsp+78h] [rbp-90h]
			//   Vector4 v86; // [rsp+88h] [rbp-80h]
			//   Vector4 v87; // [rsp+98h] [rbp-70h]
			//   Vector4 v88; // [rsp+A8h] [rbp-60h]
			//   Vector4 v89; // [rsp+B8h] [rbp-50h]
			//   TileAnimationData v90; // [rsp+C8h] [rbp-40h]
			//   TileAnimationData v91; // [rsp+D8h] [rbp-30h]
			//   TileAnimationData v92; // [rsp+E8h] [rbp-20h]
			//   TileAnimationData v93; // [rsp+F8h] [rbp-10h]
			//   _OWORD source[15]; // [rsp+108h] [rbp+0h] BYREF
			// 
			//   useWetnessMask = 1;
			//   if ( !byte_18D9195B4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D9195B4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2783, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2783, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1018(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         (Object *)hgCamera,
			//         (Object *)passData,
			//         wetnessEnabled,
			//         0LL);
			//       return;
			//     }
			// LABEL_31:
			//     sub_180B536AC(Patch, virtualMachine);
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_31;
			//   m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//   sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_31;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)m_volumeComponentsData.fields.m_hgssrVolume;
			//   if ( !Patch )
			//     goto LABEL_31;
			//   virtualMachine = Patch[1].fields.virtualMachine;
			//   if ( !virtualMachine )
			//     goto LABEL_31;
			//   v15 = sub_18003F9B0(10LL, virtualMachine);
			//   v16 = hgCamera.fields.m_volumeComponentsData;
			//   v17 = v15;
			//   if ( !v16 )
			//     goto LABEL_31;
			//   m_hgssrVolume = v16.fields.m_hgssrVolume;
			//   if ( !m_hgssrVolume )
			//     goto LABEL_31;
			//   virtualMachine = (VirtualMachine *)m_hgssrVolume.fields.fadenessOnDepth;
			//   if ( !virtualMachine )
			//     goto LABEL_31;
			//   v19 = sub_18003F9B0(10LL, virtualMachine);
			//   v20 = hgCamera.fields.m_volumeComponentsData;
			//   v21 = v19;
			//   if ( !v20 )
			//     goto LABEL_31;
			//   v22 = v20.fields.m_hgssrVolume;
			//   if ( !v22 )
			//     goto LABEL_31;
			//   virtualMachine = (VirtualMachine *)v22.fields.fadenessOnDepthFactor;
			//   if ( !virtualMachine )
			//     goto LABEL_31;
			//   v23 = sub_18003F9B0(10LL, virtualMachine);
			//   v24 = hgCamera.fields.m_volumeComponentsData;
			//   v25 = v23;
			//   if ( !v24 )
			//     goto LABEL_31;
			//   v26 = v24.fields.m_hgssrVolume;
			//   if ( !v26 )
			//     goto LABEL_31;
			//   virtualMachine = (VirtualMachine *)v26.fields.fadenessOnMirrorMul;
			//   if ( !virtualMachine )
			//     goto LABEL_31;
			//   v27 = sub_18003F9B0(10LL, virtualMachine);
			//   v28 = hgCamera.fields.m_volumeComponentsData;
			//   v29 = v27;
			//   if ( !v28 )
			//     goto LABEL_31;
			//   v30 = v28.fields.m_hgssrVolume;
			//   if ( !v30 )
			//     goto LABEL_31;
			//   virtualMachine = (VirtualMachine *)v30.fields.fadenessOnMirrorAdd;
			//   if ( !virtualMachine )
			//     goto LABEL_31;
			//   v31 = sub_18003F9B0(10LL, virtualMachine);
			//   if ( !passData )
			//     goto LABEL_31;
			//   sub_1802EAFE0();
			//   v35 = sub_182592070(v33, v32, v34) + 1;
			//   v36 = 7;
			//   if ( v35 < 7 )
			//     v36 = v35;
			//   passData.fields.maxMipCount = v36;
			//   sub_1802F01E0(&v84[1], 0LL, 160LL);
			//   m_frameIndex = this.fields.m_frameIndex;
			//   v40 = _mm_cvtsi32_si128(passData.fields.ssrRenderSize.m_X);
			//   *(float *)&v41 = (float)passData.fields.ssrRenderSize.m_X;
			//   *(float *)&v83.offset = (float)passData.fields.ssrRenderSize.m_Y;
			//   m_Y = (float)passData.fields.ssrRenderSize.m_Y;
			//   v83.bufferId = v41;
			//   *(float *)&v43 = 1.0 / _mm_cvtepi32_ps(v40).m128_f32[0];
			//   *(_QWORD *)&v85.y = __PAIR64__(LODWORD(v29), LODWORD(v17));
			//   *(float *)v40.m128i_i32 = 1.0 / m_Y;
			//   v44 = _mm_cvtsi32_si128(m_frameIndex);
			//   *(&v83.size + 1) = v40.m128i_i32[0];
			//   v83.size = v43;
			//   v45 = (m_frameIndex % 4) >> 31;
			//   m_frameIndex %= 4;
			//   v47 = (TileBase *)v45;
			//   v48 = __SPAIR64__(v45, m_frameIndex) % 2;
			//   v46 = __SPAIR64__(v45, m_frameIndex) / 2;
			//   LODWORD(v47) = v48;
			//   v49 = !this.fields.m_firstFrame;
			//   v50 = 0;
			//   LODWORD(v85.x) = _mm_cvtepi32_ps(v44).m128_u32[0];
			//   v85.w = v31;
			//   *(_OWORD *)&v84[1] = *(_OWORD *)&v83.bufferId;
			//   if ( !v49 )
			//     v50 = 1065353216;
			//   *(&v83.size + 1) = 0;
			//   *(_QWORD *)&v87.z = 0LL;
			//   v83.size = v50;
			//   v51 = _mm_cvtsi32_si128(input.ssrRayMarchingSampleCount);
			//   *(float *)&v83.offset = (float)(int)v47;
			//   v52 = _mm_cvtsi32_si128(input.ssrRayMarchingSampleCount);
			//   *(float *)&v83.bufferId = (float)v46;
			//   v86 = *(Vector4 *)&v83.bufferId;
			//   v53 = v25 * v21;
			//   v87.y = 1.0 / _mm_cvtepi32_ps(v52).m128_f32[0];
			//   v54 = 0.0099999998;
			//   LODWORD(v87.x) = _mm_cvtepi32_ps(v51).m128_u32[0];
			//   if ( v53 >= 0.0099999998 )
			//     v54 = v53;
			//   *(_QWORD *)&v88.z = 0LL;
			//   v89.x = 0.0;
			//   *(_QWORD *)&v89.z = 0LL;
			//   v88.y = 1.0 / v54;
			//   v88.x = v21;
			//   v89.y = (float)(v36 - 1);
			//   v90 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v83, v47, v37, v38, P3);
			//   v91 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v83, v55, v56, v57, P3a);
			//   v92 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v83, v58, v59, v60, P3b);
			//   v93 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v83, v61, v62, v63, P3c);
			//   source[0] = *(_OWORD *)&v84[1];
			//   source[1] = v85;
			//   source[2] = v86;
			//   source[3] = v87;
			//   source[4] = v88;
			//   source[5] = v89;
			//   source[6] = v90;
			//   source[7] = v91;
			//   source[8] = v92;
			//   v64 = v85;
			//   source[9] = v93;
			//   passData.fields.cbData.param0 = *(Vector4 *)&v84[1];
			//   v65 = v86;
			//   passData.fields.cbData.param1 = v64;
			//   v66 = v87;
			//   passData.fields.cbData.param2 = v65;
			//   v67 = v88;
			//   passData.fields.cbData.param3 = v66;
			//   v68 = v89;
			//   passData.fields.cbData.param4 = v67;
			//   v69 = (Vector4)v90;
			//   passData.fields.cbData.param5 = v68;
			//   v70 = (Vector4)v91;
			//   passData.fields.cbData.param6 = v69;
			//   v71 = (Vector4)v92;
			//   passData.fields.cbData.param7 = v70;
			//   v72 = (Vector4)v93;
			//   passData.fields.cbData.previousColorPyramidRenderSize = v71;
			//   passData.fields.cbData.currentColorPyramidRenderSize = v72;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   v73 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v83, &input.renderContext, 160, 0LL);
			//   *(_QWORD *)&v71.x = v73.ptr;
			//   *(_OWORD *)&passData.fields.cbHandle.bufferId = *(_OWORD *)&v73.bufferId;
			//   passData.fields.cbHandle.ptr = *(void **)&v71.x;
			//   Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//     (Void *)passData.fields.cbHandle.ptr,
			//     (Void *)source,
			//     160LL,
			//     0LL);
			//   passData.fields.firstFrame = this.fields.m_firstFrame;
			//   passData.fields.renderSize = sceneRTSize_k__BackingField;
			//   passData.fields.computeShader = this.fields.m_computeShader;
			//   sub_1800054D0((HGRenderPathScene *)&passData.fields.computeShader, v74, v75, v76, P3d, P4);
			//   if ( !wetnessEnabled )
			//     useWetnessMask = hgCamera.fields.useWetnessMask;
			//   passData.fields.ssrRenderWetness = useWetnessMask;
			// }
			// 
		}

		internal void Render(ref HyperScreenSpaceReflectionRenderingPass.PassInput input, ref HyperScreenSpaceReflectionRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera, [MetadataOffset(Offset = "0x01F9189E")] bool enableWetness = false)
		{
			// // Void Render(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HyperScreenSpaceReflectionRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera, Boolean)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::Render(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HyperScreenSpaceReflectionRenderingPass_PassInput *input,
			//         HyperScreenSpaceReflectionRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         bool enableWetness,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Vector2Int sceneRTSize_k__BackingField; // rcx
			//   __int64 v17; // rdx
			//   Object *v18; // rbx
			//   HGSettingParameters *settingParameters; // rcx
			//   bool v20; // al
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   Object *v23; // rbx
			//   HGSettingParameters *v24; // rcx
			//   bool v25; // al
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   AttributeCollection *instance; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   __int64 v31; // rdx
			//   Object *v32; // rdi
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   Vector2Int v35; // rbx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   ScreenSpaceReflectionVolume *m_hgssrVolume; // rsi
			//   ClampedFloatParameter *fadenessOnScreen; // rsi
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   double v41; // xmm0_8
			//   int32_t v42; // xmm11_4
			//   HGCamera_VolumeComponentsData *v43; // rax
			//   ScreenSpaceReflectionVolume *v44; // rsi
			//   FloatParameter *fadenessOnDepth; // rsi
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   double v48; // xmm0_8
			//   float v49; // xmm9_4
			//   HGCamera_VolumeComponentsData *v50; // rax
			//   ScreenSpaceReflectionVolume *v51; // rsi
			//   ClampedFloatParameter *fadenessOnDepthFactor; // rsi
			//   __int64 v53; // rdx
			//   __int64 v54; // rcx
			//   double v55; // xmm0_8
			//   float v56; // xmm7_4
			//   HGCamera_VolumeComponentsData *v57; // rax
			//   ScreenSpaceReflectionVolume *v58; // rsi
			//   FloatParameter *fadenessOnMirrorMul; // rsi
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   double v62; // xmm0_8
			//   int32_t v63; // xmm10_4
			//   HGCamera_VolumeComponentsData *v64; // rax
			//   ScreenSpaceReflectionVolume *v65; // rsi
			//   FloatParameter *fadenessOnMirrorAdd; // rsi
			//   __int64 v67; // rdx
			//   __int64 v68; // rcx
			//   double v69; // xmm0_8
			//   int32_t v70; // xmm8_4
			//   __int64 v71; // rcx
			//   int v72; // r8d
			//   int v73; // eax
			//   int32_t v74; // esi
			//   int32_t v75; // xmm3_4
			//   uint32_t v76; // xmm2_4
			//   int32_t m_frameIndex; // eax
			//   int v78; // eax
			//   int v79; // edx
			//   unsigned int v80; // xmm2_4
			//   int32_t v81; // xmm1_4
			//   int32_t v82; // xmm6_4
			//   Vector3Int *v83; // r8
			//   ITilemap *v84; // r9
			//   Vector3Int *v85; // r8
			//   ITilemap *v86; // r9
			//   Vector3Int *v87; // r8
			//   ITilemap *v88; // r9
			//   Vector3Int *v89; // r8
			//   ITilemap *v90; // r9
			//   CBHandle *ConstantBuffer; // rax
			//   Object__Class *ptr; // xmm0_8
			//   Object__Class *klass; // rsi
			//   void (__fastcall *v94)(Object__Class *, TextureDesc *, __int64); // rax
			//   unsigned __int64 v95; // r8
			//   signed __int64 v96; // rtt
			//   BOOL useWetnessMask; // eax
			//   __int64 v98; // rdx
			//   ILFixDynamicMethodWrapper_2 *v99; // rcx
			//   Object *v100; // rbx
			//   __int64 v101; // rdx
			//   __int64 v102; // rcx
			//   TextureHandle v103; // xmm0
			//   Object *v104; // rbx
			//   __int64 v105; // rdx
			//   __int64 v106; // rcx
			//   TextureHandle v107; // xmm0
			//   Object *v108; // rbx
			//   __int64 v109; // rdx
			//   __int64 v110; // rcx
			//   TextureHandle v111; // xmm0
			//   Object *v112; // rbx
			//   __int64 v113; // rdx
			//   __int64 v114; // rcx
			//   TextureHandle v115; // xmm0
			//   Object *v116; // rbx
			//   __int64 v117; // rdx
			//   __int64 v118; // rcx
			//   TextureHandle v119; // xmm0
			//   Object *v120; // rbx
			//   __int64 v121; // rdx
			//   __int64 v122; // rcx
			//   TextureHandle v123; // xmm0
			//   Object *v124; // rbx
			//   __int64 v125; // rdx
			//   __int64 v126; // rcx
			//   TextureHandle v127; // xmm0
			//   Object *v128; // rbx
			//   TextureHandle *v129; // rax
			//   __int64 v130; // rdx
			//   __int64 v131; // rcx
			//   int32_t v132; // edi
			//   int32_t v133; // ebx
			//   __int128 v134; // xmm2
			//   __int128 v135; // xmm3
			//   Color v136; // xmm4
			//   unsigned __int64 v137; // r8
			//   signed __int64 v138; // rtt
			//   Object *v139; // rbx
			//   __int64 v140; // rdx
			//   __int64 v141; // rcx
			//   TextureHandle v142; // xmm0
			//   Vector2Int v143; // rbx
			//   __int128 v144; // xmm2
			//   __int128 v145; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v147; // r8
			//   signed __int64 v148; // rtt
			//   Object *v149; // rbx
			//   __int64 v150; // rdx
			//   __int64 v151; // rcx
			//   TextureHandle v152; // xmm0
			//   int32_t v153; // edi
			//   int32_t klass_high; // ebx
			//   __int128 v155; // xmm2
			//   __int128 v156; // xmm3
			//   Color v157; // xmm4
			//   unsigned __int64 v158; // r8
			//   signed __int64 v159; // rtt
			//   Object *v160; // rbx
			//   TextureHandle v161; // xmm0
			//   int32_t v162; // edi
			//   int32_t v163; // ebx
			//   __int128 v164; // xmm2
			//   __int128 v165; // xmm3
			//   Color v166; // xmm4
			//   unsigned __int64 v167; // r8
			//   signed __int64 v168; // rtt
			//   Object *v169; // rbx
			//   __int64 v170; // rdx
			//   __int64 v171; // rcx
			//   TextureHandle v172; // xmm0
			//   int32_t v173; // edi
			//   int32_t v174; // ebx
			//   __int128 v175; // xmm2
			//   __int128 v176; // xmm3
			//   Color v177; // xmm4
			//   unsigned __int64 v178; // r8
			//   signed __int64 v179; // rtt
			//   Object *v180; // rbx
			//   __int64 v181; // rdx
			//   __int64 v182; // rcx
			//   TextureHandle v183; // xmm0
			//   int32_t v184; // edi
			//   int32_t v185; // ebx
			//   __int128 v186; // xmm2
			//   __int128 v187; // xmm3
			//   Color v188; // xmm4
			//   unsigned __int64 v189; // r8
			//   signed __int64 v190; // rtt
			//   Object *v191; // rbx
			//   __int64 v192; // rdx
			//   __int64 v193; // rcx
			//   TextureHandle v194; // xmm0
			//   Object *v195; // rbx
			//   __int64 v196; // rdx
			//   __int64 v197; // rcx
			//   TextureHandle v198; // xmm0
			//   Object *v199; // rbx
			//   int32_t v200; // edi
			//   int32_t v201; // ebx
			//   __int128 v202; // xmm2
			//   __int128 v203; // xmm3
			//   Color v204; // xmm4
			//   unsigned __int64 v205; // r8
			//   signed __int64 v206; // rtt
			//   Object *v207; // rbx
			//   __int64 v208; // rdx
			//   __int64 v209; // rcx
			//   TextureHandle v210; // xmm0
			//   int32_t v211; // edi
			//   int32_t v212; // ebx
			//   __int128 v213; // xmm2
			//   __int128 v214; // xmm3
			//   Color v215; // xmm4
			//   unsigned __int64 v216; // r8
			//   signed __int64 v217; // rtt
			//   Object *v218; // rbx
			//   __int64 v219; // rdx
			//   __int64 v220; // rcx
			//   TextureHandle v221; // xmm0
			//   Vector2Int v222; // rbx
			//   __int128 v223; // xmm2
			//   __int128 v224; // xmm3
			//   Color v225; // xmm4
			//   unsigned __int64 v226; // r8
			//   signed __int64 v227; // rtt
			//   Object *v228; // rbx
			//   __int64 v229; // rdx
			//   __int64 v230; // rcx
			//   TextureHandle v231; // xmm0
			//   Object *v232; // rbx
			//   __int64 v233; // rdx
			//   __int64 v234; // rcx
			//   TextureHandle v235; // xmm0
			//   __int64 v236; // rdx
			//   __int64 v237; // rcx
			//   TextureHandle v238; // xmm0
			//   Object *v239; // rbx
			//   TextureHandle v240; // xmm0
			//   int32_t v241; // edi
			//   int32_t v242; // ebx
			//   __int128 v243; // xmm2
			//   __int128 v244; // xmm3
			//   Color v245; // xmm4
			//   unsigned __int64 v246; // r8
			//   signed __int64 v247; // rtt
			//   int32_t v248; // edi
			//   int32_t v249; // ebx
			//   __int128 v250; // xmm2
			//   __int128 v251; // xmm3
			//   Color v252; // xmm4
			//   unsigned __int64 v253; // r8
			//   signed __int64 v254; // rtt
			//   Object *v255; // rbx
			//   __int64 v256; // rdx
			//   __int64 v257; // rcx
			//   TextureHandle v258; // xmm0
			//   TextureHandle v259; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v261; // rdx
			//   __int64 v262; // rcx
			//   __int64 v263; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-798h]
			//   MethodInfo *P3a; // [rsp+20h] [rbp-798h]
			//   MethodInfo *P3b; // [rsp+20h] [rbp-798h]
			//   MethodInfo *P3c; // [rsp+20h] [rbp-798h]
			//   Object *v268; // [rsp+40h] [rbp-778h] BYREF
			//   TextureHandle v269; // [rsp+48h] [rbp-770h] BYREF
			//   __int128 v270; // [rsp+60h] [rbp-758h] BYREF
			//   __int128 v271; // [rsp+70h] [rbp-748h]
			//   __int128 v272; // [rsp+80h] [rbp-738h]
			//   __int128 v273; // [rsp+90h] [rbp-728h] BYREF
			//   __int128 v274; // [rsp+A0h] [rbp-718h]
			//   Color v275; // [rsp+B0h] [rbp-708h]
			//   HGRenderGraphBuilder v276; // [rsp+C0h] [rbp-6F8h] BYREF
			//   HGRenderGraphBuilder v277; // [rsp+E0h] [rbp-6D8h] BYREF
			//   TextureDesc v278; // [rsp+100h] [rbp-6B8h] BYREF
			//   TileAnimationData v279; // [rsp+160h] [rbp-658h]
			//   TileAnimationData v280; // [rsp+170h] [rbp-648h]
			//   TileAnimationData v281; // [rsp+180h] [rbp-638h]
			//   TileAnimationData v282; // [rsp+190h] [rbp-628h]
			//   _QWORD v283[2]; // [rsp+1A0h] [rbp-618h] BYREF
			//   TextureDesc v284; // [rsp+1B0h] [rbp-608h] BYREF
			//   TextureDesc v285; // [rsp+210h] [rbp-5A8h] BYREF
			//   TextureDesc v286; // [rsp+280h] [rbp-538h] BYREF
			//   TextureDesc v287; // [rsp+2E0h] [rbp-4D8h] BYREF
			//   TextureDesc v288; // [rsp+340h] [rbp-478h] BYREF
			//   TextureDesc v289; // [rsp+3A0h] [rbp-418h] BYREF
			//   TextureDesc v290; // [rsp+400h] [rbp-3B8h] BYREF
			//   TextureDesc v291; // [rsp+460h] [rbp-358h] BYREF
			//   TextureDesc v292; // [rsp+4C0h] [rbp-2F8h] BYREF
			//   TextureDesc v293; // [rsp+520h] [rbp-298h] BYREF
			//   TextureDesc v294; // [rsp+580h] [rbp-238h] BYREF
			//   TextureDesc v295; // [rsp+5E0h] [rbp-1D8h] BYREF
			//   TextureDesc v296; // [rsp+640h] [rbp-178h] BYREF
			//   TextureDesc v297; // [rsp+6A0h] [rbp-118h] BYREF
			//   TileAnimationData v298; // [rsp+700h] [rbp-B8h]
			//   TileAnimationData v299; // [rsp+710h] [rbp-A8h]
			//   TileAnimationData v300; // [rsp+720h] [rbp-98h]
			//   TileAnimationData v301; // [rsp+730h] [rbp-88h]
			// 
			//   if ( !byte_18D9195B5 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D5008C0);
			//     sub_18003C530(&off_18D500860);
			//     sub_18003C530(&off_18D500870);
			//     sub_18003C530(&off_18D500878);
			//     sub_18003C530(&off_18D500888);
			//     sub_18003C530(&off_18D5008F8);
			//     sub_18003C530(&off_18D500900);
			//     sub_18003C530(&off_18D500908);
			//     sub_18003C530(&off_18D500918);
			//     byte_18D9195B5 = 1;
			//   }
			//   v268 = 0LL;
			//   sub_1802F01E0(&v290, 0LL, 96LL);
			//   sub_1802F01E0(&v291, 0LL, 96LL);
			//   sub_1802F01E0(&v286, 0LL, 96LL);
			//   sub_1802F01E0(&v288, 0LL, 96LL);
			//   sub_1802F01E0(&v289, 0LL, 96LL);
			//   sub_1802F01E0(&v270, 0LL, 96LL);
			//   sub_1802F01E0(&v287, 0LL, 96LL);
			//   sub_1802F01E0(&v292, 0LL, 96LL);
			//   sub_1802F01E0(&v294, 0LL, 96LL);
			//   sub_1802F01E0(&v293, 0LL, 96LL);
			//   sub_1802F01E0(&v295, 0LL, 96LL);
			//   sub_1802F01E0(&v296, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2784, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2784, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v262, v261);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1019(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       enableWetness,
			//       0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRender(this, input, hgCamera, 0LL) )
			//   {
			//     this.fields.m_shouldRender = 1;
			//     if ( !hgCamera )
			//       sub_180B536AC(v12, v11);
			//     if ( hgCamera.fields.prevTransformReset )
			//       this.fields.m_firstFrame = 1;
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x55u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v276,
			//       renderGraph,
			//       (String *)"Screen Space Reflection",
			//       &v268,
			//       v13,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
			//     v277 = v276;
			//     v283[0] = 0LL;
			//     v283[1] = &v277;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v277, 0, 0LL);
			//     sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//     v269.handle.m_Value = sceneRTSize_k__BackingField.m_X / 2;
			//     v17 = (unsigned int)(sceneRTSize_k__BackingField.m_Y >> 31);
			//     v269.handle._type_k__BackingField = sceneRTSize_k__BackingField.m_Y / 2;
			//     if ( !v268 )
			//       sub_1802DC2C8(0LL, v17);
			//     v268[2].klass = (Object__Class *)v269.handle;
			//     v18 = v268;
			//     settingParameters = input.settingParameters;
			//     if ( !settingParameters )
			//       sub_1802DC2C8(0LL, v17);
			//     v20 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//             settingParameters.fields._ssrV2Upsample_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     if ( !v18 )
			//       sub_1802DC2C8(v22, v21);
			//     BYTE1(v18[1].klass) = v20;
			//     v23 = v268;
			//     v24 = input.settingParameters;
			//     if ( !v24 )
			//       sub_1802DC2C8(0LL, v21);
			//     v25 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//             v24.fields._ssrImportanceSample_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     if ( !v23 )
			//       sub_1802DC2C8(v27, v26);
			//     BYTE2(v23[1].klass) = v25;
			//     instance = (AttributeCollection *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//     if ( !instance )
			//       sub_1802DC2C8(v30, v29);
			//     if ( System::ComponentModel::AttributeCollection::get_Count(instance, 0LL) == 4 )
			//     {
			//       if ( !v268 )
			//         sub_1802DC2C8(0LL, v31);
			//       v268[2].klass = (Object__Class *)hgCamera.fields._sceneRTSize_k__BackingField;
			//     }
			//     v32 = v268;
			//     if ( !byte_18D9195B4 )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       byte_18D9195B4 = 1;
			//     }
			//     if ( IFix::WrappersManagerImpl::IsPatched(2783, 0LL) )
			//     {
			//       v99 = IFix::WrappersManagerImpl::GetPatch(2783, 0LL);
			//       if ( !v99 )
			//         sub_1802DC2C8(0LL, v98);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1018(
			//         v99,
			//         (Object *)this,
			//         input,
			//         (Object *)hgCamera,
			//         v32,
			//         enableWetness,
			//         0LL);
			//     }
			//     else
			//     {
			//       v35 = hgCamera.fields._sceneRTSize_k__BackingField;
			//       m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//       if ( !m_volumeComponentsData )
			//         sub_1802DC2C8(v34, v33);
			//       m_hgssrVolume = m_volumeComponentsData.fields.m_hgssrVolume;
			//       if ( !m_hgssrVolume )
			//         sub_1802DC2C8(v34, v33);
			//       fadenessOnScreen = m_hgssrVolume.fields.fadenessOnScreen;
			//       if ( !fadenessOnScreen )
			//         sub_1802DC2C8(v34, v33);
			//       sub_180003EE0(fadenessOnScreen.klass);
			//       v41 = ((double (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))fadenessOnScreen.klass.vtable.get_value.method)(
			//               fadenessOnScreen,
			//               fadenessOnScreen.klass.vtable.set_value.methodPtr);
			//       v42 = LODWORD(v41);
			//       v43 = hgCamera.fields.m_volumeComponentsData;
			//       if ( !v43 )
			//         sub_1802DC2C8(v40, v39);
			//       v44 = v43.fields.m_hgssrVolume;
			//       if ( !v44 )
			//         sub_1802DC2C8(v40, v39);
			//       fadenessOnDepth = v44.fields.fadenessOnDepth;
			//       if ( !fadenessOnDepth )
			//         sub_1802DC2C8(v40, v39);
			//       sub_180003EE0(fadenessOnDepth.klass);
			//       v48 = ((double (__fastcall *)(FloatParameter *, Il2CppMethodPointer))fadenessOnDepth.klass.vtable.get_value.method)(
			//               fadenessOnDepth,
			//               fadenessOnDepth.klass.vtable.set_value.methodPtr);
			//       v49 = *(float *)&v48;
			//       v50 = hgCamera.fields.m_volumeComponentsData;
			//       if ( !v50 )
			//         sub_1802DC2C8(v47, v46);
			//       v51 = v50.fields.m_hgssrVolume;
			//       if ( !v51 )
			//         sub_1802DC2C8(v47, v46);
			//       fadenessOnDepthFactor = v51.fields.fadenessOnDepthFactor;
			//       if ( !fadenessOnDepthFactor )
			//         sub_1802DC2C8(v47, v46);
			//       sub_180003EE0(fadenessOnDepthFactor.klass);
			//       v55 = ((double (__fastcall *)(ClampedFloatParameter *, Il2CppMethodPointer))fadenessOnDepthFactor.klass.vtable.get_value.method)(
			//               fadenessOnDepthFactor,
			//               fadenessOnDepthFactor.klass.vtable.set_value.methodPtr);
			//       v56 = *(float *)&v55;
			//       v57 = hgCamera.fields.m_volumeComponentsData;
			//       if ( !v57 )
			//         sub_1802DC2C8(v54, v53);
			//       v58 = v57.fields.m_hgssrVolume;
			//       if ( !v58 )
			//         sub_1802DC2C8(v54, v53);
			//       fadenessOnMirrorMul = v58.fields.fadenessOnMirrorMul;
			//       if ( !fadenessOnMirrorMul )
			//         sub_1802DC2C8(v54, v53);
			//       sub_180003EE0(fadenessOnMirrorMul.klass);
			//       v62 = ((double (__fastcall *)(FloatParameter *, Il2CppMethodPointer))fadenessOnMirrorMul.klass.vtable.get_value.method)(
			//               fadenessOnMirrorMul,
			//               fadenessOnMirrorMul.klass.vtable.set_value.methodPtr);
			//       v63 = LODWORD(v62);
			//       v64 = hgCamera.fields.m_volumeComponentsData;
			//       if ( !v64 )
			//         sub_1802DC2C8(v61, v60);
			//       v65 = v64.fields.m_hgssrVolume;
			//       if ( !v65 )
			//         sub_1802DC2C8(v61, v60);
			//       fadenessOnMirrorAdd = v65.fields.fadenessOnMirrorAdd;
			//       if ( !fadenessOnMirrorAdd )
			//         sub_1802DC2C8(v61, v60);
			//       sub_180003EE0(fadenessOnMirrorAdd.klass);
			//       v69 = ((double (__fastcall *)(FloatParameter *, Il2CppMethodPointer))fadenessOnMirrorAdd.klass.vtable.get_value.method)(
			//               fadenessOnMirrorAdd,
			//               fadenessOnMirrorAdd.klass.vtable.set_value.methodPtr);
			//       v70 = LODWORD(v69);
			//       if ( !v32 )
			//         sub_1802DC2C8(v68, v67);
			//       UnityEngine::Mathf::Min((int32_t)v32[2].klass, HIDWORD(v32[2].klass), 0LL);
			//       sub_1802EAFE0();
			//       v73 = sub_182592070(v71, 0, v72);
			//       v74 = UnityEngine::Mathf::Min(v73 + 1, 7, 0LL);
			//       HIDWORD(v32[1].klass) = v74;
			//       sub_1802F01E0(&v278, 0LL, 160LL);
			//       *(float *)&v75 = 1.0 / (float)SHIDWORD(v32[2].klass);
			//       *(float *)&v76 = 1.0 / (float)SLODWORD(v32[2].klass);
			//       *(float *)&v269.handle.m_Value = (float)SLODWORD(v32[2].klass);
			//       *(float *)&v269.handle._type_k__BackingField = (float)SHIDWORD(v32[2].klass);
			//       v269.fallBackResource.m_Value = v76;
			//       v269.fallBackResource._type_k__BackingField = v75;
			//       *(TextureHandle *)&v278.width = v269;
			//       m_frameIndex = this.fields.m_frameIndex;
			//       *(float *)&v278.colorFormat = (float)m_frameIndex;
			//       v278.filterMode = v42;
			//       v278.wrapMode = v63;
			//       v278.dimension = v70;
			//       m_frameIndex %= 4;
			//       v79 = m_frameIndex % 2;
			//       v78 = m_frameIndex / 2;
			//       if ( this.fields.m_firstFrame )
			//         v80 = 1065353216;
			//       else
			//         v80 = 0;
			//       *(float *)&v269.handle.m_Value = (float)v78;
			//       *(float *)&v269.handle._type_k__BackingField = (float)v79;
			//       v269.fallBackResource = (ResourceHandle)v80;
			//       *(TextureHandle *)&v278.enableRandomWrite = v269;
			//       *(float *)&v81 = 1.0 / (float)input.ssrRayMarchingSampleCount;
			//       *(float *)&v278.bindTextureMS = (float)input.ssrRayMarchingSampleCount;
			//       v278.memoryless = v81;
			//       v278.name = 0LL;
			//       *(float *)&v82 = 1.0 / UnityEngine::Mathf::Max(0.0099999998, v56 * v49, 0LL);
			//       *(float *)&v278.fastMemoryDesc.inFastMemory = v49;
			//       v278.fastMemoryDesc.flags = v82;
			//       v278.fastMemoryDesc.residencyFraction = 0.0;
			//       *(_DWORD *)&v278.fallBackToBlackTexture = 0;
			//       v278.clearColor.r = 0.0;
			//       v278.clearColor.g = (float)(v74 - 1);
			//       v278.clearColor.b = 0.0;
			//       v278.clearColor.a = 0.0;
			//       v279 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v269, 0LL, v83, v84, P3);
			//       v280 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v269, 0LL, v85, v86, P3a);
			//       v281 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v269, 0LL, v87, v88, P3b);
			//       v282 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v269, 0LL, v89, v90, P3c);
			//       v297 = v278;
			//       v298 = v279;
			//       v299 = v280;
			//       v300 = v281;
			//       v301 = v282;
			//       *(TextureDesc *)&v32[3].klass = v278;
			//       v32[9] = (Object)v279;
			//       v32[10] = (Object)v280;
			//       v32[11] = (Object)v281;
			//       v32[12] = (Object)v282;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                          (CBHandle *)&v276,
			//                          &input.renderContext,
			//                          160,
			//                          0LL);
			//       ptr = (Object__Class *)ConstantBuffer.ptr;
			//       v32[13] = *(Object *)&ConstantBuffer.bufferId;
			//       v32[14].klass = ptr;
			//       klass = v32[14].klass;
			//       v94 = (void (__fastcall *)(Object__Class *, TextureDesc *, __int64))qword_18D8F3FE0;
			//       if ( !qword_18D8F3FE0 )
			//       {
			//         v94 = (void (__fastcall *)(Object__Class *, TextureDesc *, __int64))il2cpp_resolve_icall_0(
			//                                                                               "Unity.Collections.LowLevel.Unsafe.UnsafeUt"
			//                                                                               "ility::MemCpy(System.Void*,System.Void*,System.Int64)");
			//         if ( !v94 )
			//         {
			//           v263 = sub_1802DBBE8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpy(System.Void*,System.Void*,System.Int64)");
			//           sub_18000F750(v263, 0LL);
			//         }
			//         qword_18D8F3FE0 = (__int64)v94;
			//       }
			//       v94(klass, &v297, 160LL);
			//       LOBYTE(v32[1].klass) = this.fields.m_firstFrame;
			//       v32[1].monitor = (MonitorData *)v35;
			//       v32[37].monitor = (MonitorData *)this.fields.m_computeShader;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v95 = (((unsigned __int64)&v32[37].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v95 + 36190]);
			//         do
			//           v96 = qword_18D6405E0[v95 + 36190];
			//         while ( v96 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v95 + 36190],
			//                          v96 | (1LL << (((unsigned __int64)&v32[37].monitor >> 12) & 0x3F)),
			//                          v96) );
			//       }
			//       useWetnessMask = 1;
			//       if ( !enableWetness )
			//         useWetnessMask = hgCamera.fields.useWetnessMask;
			//       LOBYTE(v32[38].klass) = useWetnessMask;
			//     }
			//     v100 = v268;
			//     v103 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.previousSceneColorTexture,
			//               0LL);
			//     if ( !v100 )
			//       sub_1802DC2C8(v102, v101);
			//     *(TextureHandle *)&v100[14].monitor = v103;
			//     v104 = v268;
			//     v107 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.previousSceneDepthPyramidTexture,
			//               0LL);
			//     if ( !v104 )
			//       sub_1802DC2C8(v106, v105);
			//     *(TextureHandle *)&v104[15].monitor = v107;
			//     v108 = v268;
			//     v111 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.currentSceneDepthTexture,
			//               0LL);
			//     if ( !v108 )
			//       sub_1802DC2C8(v110, v109);
			//     *(TextureHandle *)&v108[17].monitor = v111;
			//     v112 = v268;
			//     v115 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.currentSceneDepthPyramidTexture,
			//               0LL);
			//     if ( !v112 )
			//       sub_1802DC2C8(v114, v113);
			//     *(TextureHandle *)&v112[18].monitor = v115;
			//     v116 = v268;
			//     v119 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.gbufferNormalRoughenssTexture,
			//               0LL);
			//     if ( !v116 )
			//       sub_1802DC2C8(v118, v117);
			//     *(TextureHandle *)&v116[19].monitor = v119;
			//     v120 = v268;
			//     v123 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.normalRoughnessTexture,
			//               0LL);
			//     if ( !v120 )
			//       sub_1802DC2C8(v122, v121);
			//     *(TextureHandle *)&v120[20].monitor = v123;
			//     v124 = v268;
			//     v127 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//               &v269,
			//               &v277,
			//               &input.motionVectorTexture,
			//               0LL);
			//     if ( !v124 )
			//       sub_1802DC2C8(v126, v125);
			//     *(TextureHandle *)&v124[21].monitor = v127;
			//     v128 = v268;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.waterWetnessMaskTexture, 0LL) )
			//     {
			//       v129 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                &v269,
			//                &v277,
			//                &input.waterWetnessMaskTexture,
			//                0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v129 = (TextureHandle *)sub_182E7CCD0(&v269);
			//     }
			//     if ( !v128 )
			//       sub_1802DC2C8(v131, v130);
			//     *(Object *)((char *)v128 + 360) = *(Object *)v129;
			//     if ( !v268 )
			//       sub_1802DC2C8(v131, v130);
			//     if ( BYTE1(v268[1].klass) )
			//     {
			//       v143 = hgCamera.fields._sceneRTSize_k__BackingField;
			//       sub_1802F01E0(&v284, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v284,
			//         hgCamera.fields._sceneRTSize_k__BackingField.m_X,
			//         v143.m_Y,
			//         0LL);
			//       v144 = *(_OWORD *)&v284.width;
			//       v270 = *(_OWORD *)&v284.width;
			//       v271 = *(_OWORD *)&v284.colorFormat;
			//       v272 = *(_OWORD *)&v284.enableRandomWrite;
			//       *(_QWORD *)&v273 = *(_QWORD *)&v284.bindTextureMS;
			//       v145 = *(_OWORD *)&v284.fastMemoryDesc.inFastMemory;
			//       v274 = *(_OWORD *)&v284.fastMemoryDesc.inFastMemory;
			//       clearColor = v284.clearColor;
			//       v275 = v284.clearColor;
			//       *((_QWORD *)&v273 + 1) = "Screen Space Reflection Ray Marching Color Texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v147 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v147 + 36190]);
			//         do
			//           v148 = qword_18D6405E0[v147 + 36190];
			//         while ( v148 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v147 + 36190],
			//                           v148 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                           v148) );
			//         clearColor = v275;
			//         v145 = v274;
			//         v144 = v270;
			//       }
			//       LODWORD(v271) = 74;
			//       LOBYTE(v272) = 1;
			//       *(_OWORD *)&v288.width = v144;
			//       *(_OWORD *)&v288.colorFormat = v271;
			//       *(_OWORD *)&v288.enableRandomWrite = v272;
			//       *(_OWORD *)&v288.bindTextureMS = v273;
			//       *(_OWORD *)&v288.fastMemoryDesc.inFastMemory = v145;
			//       v288.clearColor = clearColor;
			//       v149 = v268;
			//       v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                 (TextureHandle *)&v276,
			//                 renderGraph,
			//                 &v288,
			//                 0LL);
			//       v152 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &v269,
			//                 0LL);
			//       if ( !v149 )
			//         sub_1802DC2C8(v151, v150);
			//       *(TextureHandle *)&v149[23].monitor = v152;
			//       if ( !v268 )
			//         sub_1802DC2C8(v151, v150);
			//       v153 = (int32_t)v268[2].klass;
			//       klass_high = HIDWORD(v268[2].klass);
			//       sub_1802F01E0(&v285, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v285, v153, klass_high, 0LL);
			//       v155 = *(_OWORD *)&v285.width;
			//       v270 = *(_OWORD *)&v285.width;
			//       v271 = *(_OWORD *)&v285.colorFormat;
			//       v272 = *(_OWORD *)&v285.enableRandomWrite;
			//       *(_QWORD *)&v273 = *(_QWORD *)&v285.bindTextureMS;
			//       v156 = *(_OWORD *)&v285.fastMemoryDesc.inFastMemory;
			//       v274 = *(_OWORD *)&v285.fastMemoryDesc.inFastMemory;
			//       v157 = v285.clearColor;
			//       v275 = v285.clearColor;
			//       *((_QWORD *)&v273 + 1) = "Screen Space Reflection Ray Marching Hit UV Texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v158 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v158 + 36190]);
			//         do
			//           v159 = qword_18D6405E0[v158 + 36190];
			//         while ( v159 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v158 + 36190],
			//                           v159 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                           v159) );
			//         v157 = v275;
			//         v156 = v274;
			//         v155 = v270;
			//       }
			//       LODWORD(v271) = 22;
			//       LOBYTE(v272) = 1;
			//       *(_OWORD *)&v289.width = v155;
			//       *(_OWORD *)&v289.colorFormat = v271;
			//       *(_OWORD *)&v289.enableRandomWrite = v272;
			//       *(_OWORD *)&v289.bindTextureMS = v273;
			//       *(_OWORD *)&v289.fastMemoryDesc.inFastMemory = v156;
			//       v289.clearColor = v157;
			//       v160 = v268;
			//       v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                 (TextureHandle *)&v276,
			//                 renderGraph,
			//                 &v289,
			//                 0LL);
			//       v161 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &v269,
			//                 0LL);
			//       if ( !v160 )
			//         sub_1802DC2C8(v141, v140);
			//       *(TextureHandle *)&v160[24].monitor = v161;
			//     }
			//     else
			//     {
			//       v132 = (int32_t)v268[2].klass;
			//       v133 = HIDWORD(v268[2].klass);
			//       sub_1802F01E0(&v284, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v284, v132, v133, 0LL);
			//       v134 = *(_OWORD *)&v284.width;
			//       v270 = *(_OWORD *)&v284.width;
			//       v271 = *(_OWORD *)&v284.colorFormat;
			//       v272 = *(_OWORD *)&v284.enableRandomWrite;
			//       *(_QWORD *)&v273 = *(_QWORD *)&v284.bindTextureMS;
			//       v135 = *(_OWORD *)&v284.fastMemoryDesc.inFastMemory;
			//       v274 = *(_OWORD *)&v284.fastMemoryDesc.inFastMemory;
			//       v136 = v284.clearColor;
			//       v275 = v284.clearColor;
			//       *((_QWORD *)&v273 + 1) = "Screen Space Reflection Ray Marching Color Texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v137 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v137 + 36190]);
			//         do
			//           v138 = qword_18D6405E0[v137 + 36190];
			//         while ( v138 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v137 + 36190],
			//                           v138 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                           v138) );
			//         v136 = v275;
			//         v135 = v274;
			//         v134 = v270;
			//       }
			//       LODWORD(v271) = 74;
			//       LOBYTE(v272) = 1;
			//       *(_OWORD *)&v287.width = v134;
			//       *(_OWORD *)&v287.colorFormat = v271;
			//       *(_OWORD *)&v287.enableRandomWrite = v272;
			//       *(_OWORD *)&v287.bindTextureMS = v273;
			//       *(_OWORD *)&v287.fastMemoryDesc.inFastMemory = v135;
			//       v287.clearColor = v136;
			//       v139 = v268;
			//       v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v269, renderGraph, &v287, 0LL);
			//       v142 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &v269,
			//                 0LL);
			//       if ( !v139 )
			//         sub_1802DC2C8(v141, v140);
			//       *(TextureHandle *)&v139[23].monitor = v142;
			//     }
			//     if ( !v268 )
			//       sub_1802DC2C8(v141, v140);
			//     v162 = (int32_t)v268[2].klass;
			//     v163 = HIDWORD(v268[2].klass);
			//     sub_1802F01E0(&v285, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v285, v162, v163, 0LL);
			//     v164 = *(_OWORD *)&v285.width;
			//     v270 = *(_OWORD *)&v285.width;
			//     v271 = *(_OWORD *)&v285.colorFormat;
			//     v272 = *(_OWORD *)&v285.enableRandomWrite;
			//     *(_QWORD *)&v273 = *(_QWORD *)&v285.bindTextureMS;
			//     v165 = *(_OWORD *)&v285.fastMemoryDesc.inFastMemory;
			//     v274 = *(_OWORD *)&v285.fastMemoryDesc.inFastMemory;
			//     v166 = v285.clearColor;
			//     v275 = v285.clearColor;
			//     *((_QWORD *)&v273 + 1) = "Screen Space Reflection Filter Weight Texture";
			//     if ( dword_18D8E43F8 )
			//     {
			//       v167 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v167 + 36190]);
			//       do
			//         v168 = qword_18D6405E0[v167 + 36190];
			//       while ( v168 != _InterlockedCompareExchange64(
			//                         &qword_18D6405E0[v167 + 36190],
			//                         v168 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                         v168) );
			//       v166 = v275;
			//       v165 = v274;
			//       v164 = v270;
			//     }
			//     LODWORD(v271) = 22;
			//     LOBYTE(v272) = 1;
			//     *(_OWORD *)&v290.width = v164;
			//     *(_OWORD *)&v290.colorFormat = v271;
			//     *(_OWORD *)&v290.enableRandomWrite = v272;
			//     *(_OWORD *)&v290.bindTextureMS = v273;
			//     *(_OWORD *)&v290.fastMemoryDesc.inFastMemory = v165;
			//     v290.clearColor = v166;
			//     v169 = v268;
			//     v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//               (TextureHandle *)&v276,
			//               renderGraph,
			//               &v290,
			//               0LL);
			//     v172 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//               (TextureHandle *)&v276,
			//               &v277,
			//               &v269,
			//               0LL);
			//     if ( !v169 )
			//       sub_1802DC2C8(v171, v170);
			//     *(TextureHandle *)&v169[25].monitor = v172;
			//     if ( !v268 )
			//       sub_1802DC2C8(v171, v170);
			//     v173 = (int32_t)v268[2].klass;
			//     v174 = HIDWORD(v268[2].klass);
			//     sub_1802F01E0(&v284, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v284, v173, v174, 0LL);
			//     v175 = *(_OWORD *)&v284.width;
			//     v270 = *(_OWORD *)&v284.width;
			//     v271 = *(_OWORD *)&v284.colorFormat;
			//     v272 = *(_OWORD *)&v284.enableRandomWrite;
			//     *(_QWORD *)&v273 = *(_QWORD *)&v284.bindTextureMS;
			//     v176 = *(_OWORD *)&v284.fastMemoryDesc.inFastMemory;
			//     v274 = *(_OWORD *)&v284.fastMemoryDesc.inFastMemory;
			//     v177 = v284.clearColor;
			//     v275 = v284.clearColor;
			//     *((_QWORD *)&v273 + 1) = "Screen Space Reflection Fadeness Texture";
			//     if ( dword_18D8E43F8 )
			//     {
			//       v178 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v178 + 36190]);
			//       do
			//         v179 = qword_18D6405E0[v178 + 36190];
			//       while ( v179 != _InterlockedCompareExchange64(
			//                         &qword_18D6405E0[v178 + 36190],
			//                         v179 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                         v179) );
			//       v177 = v275;
			//       v176 = v274;
			//       v175 = v270;
			//     }
			//     LODWORD(v271) = 5;
			//     LOBYTE(v272) = 1;
			//     *(_OWORD *)&v291.width = v175;
			//     *(_OWORD *)&v291.colorFormat = v271;
			//     *(_OWORD *)&v291.enableRandomWrite = v272;
			//     *(_OWORD *)&v291.bindTextureMS = v273;
			//     *(_OWORD *)&v291.fastMemoryDesc.inFastMemory = v176;
			//     v291.clearColor = v177;
			//     v180 = v268;
			//     v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//               (TextureHandle *)&v276,
			//               renderGraph,
			//               &v291,
			//               0LL);
			//     v183 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//               (TextureHandle *)&v276,
			//               &v277,
			//               &v269,
			//               0LL);
			//     if ( !v180 )
			//       sub_1802DC2C8(v182, v181);
			//     *(TextureHandle *)&v180[26].monitor = v183;
			//     if ( !v268 )
			//       sub_1802DC2C8(v182, v181);
			//     v184 = (int32_t)v268[2].klass;
			//     v185 = HIDWORD(v268[2].klass);
			//     sub_1802F01E0(&v297, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v297, v184, v185, 0LL);
			//     v186 = *(_OWORD *)&v297.width;
			//     v270 = *(_OWORD *)&v297.width;
			//     v271 = *(_OWORD *)&v297.colorFormat;
			//     v272 = *(_OWORD *)&v297.enableRandomWrite;
			//     *(_QWORD *)&v273 = *(_QWORD *)&v297.bindTextureMS;
			//     v187 = *(_OWORD *)&v297.fastMemoryDesc.inFastMemory;
			//     v274 = *(_OWORD *)&v297.fastMemoryDesc.inFastMemory;
			//     v188 = v297.clearColor;
			//     v275 = v297.clearColor;
			//     *((_QWORD *)&v273 + 1) = "Screen Space Reflection Fadeness Resolve Texture";
			//     if ( dword_18D8E43F8 )
			//     {
			//       v189 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v189 + 36190]);
			//       do
			//         v190 = qword_18D6405E0[v189 + 36190];
			//       while ( v190 != _InterlockedCompareExchange64(
			//                         &qword_18D6405E0[v189 + 36190],
			//                         v190 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                         v190) );
			//       v188 = v275;
			//       v187 = v274;
			//       v186 = v270;
			//     }
			//     LODWORD(v271) = 5;
			//     LOBYTE(v272) = 1;
			//     *(_OWORD *)&v286.width = v186;
			//     *(_OWORD *)&v286.colorFormat = v271;
			//     *(_OWORD *)&v286.enableRandomWrite = v272;
			//     *(_OWORD *)&v286.bindTextureMS = v273;
			//     *(_OWORD *)&v286.fastMemoryDesc.inFastMemory = v187;
			//     v286.clearColor = v188;
			//     v191 = v268;
			//     v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//               (TextureHandle *)&v276,
			//               renderGraph,
			//               &v286,
			//               0LL);
			//     v194 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//               (TextureHandle *)&v276,
			//               &v277,
			//               &v269,
			//               0LL);
			//     if ( !v191 )
			//       sub_1802DC2C8(v193, v192);
			//     *(TextureHandle *)&v191[27].monitor = v194;
			//     v195 = v268;
			//     v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//               (TextureHandle *)&v276,
			//               renderGraph,
			//               &v286,
			//               0LL);
			//     v198 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//               (TextureHandle *)&v276,
			//               &v277,
			//               &v269,
			//               0LL);
			//     if ( !v195 )
			//       sub_1802DC2C8(v197, v196);
			//     *(TextureHandle *)&v195[28].monitor = v198;
			//     v199 = v268;
			//     if ( !v268 )
			//       sub_1802DC2C8(v197, v196);
			//     this.fields.m_ssrFadenessTexture = *(TextureHandle *)((char *)v268 + 440);
			//     v200 = (int32_t)v199[2].klass;
			//     v201 = HIDWORD(v199[2].klass);
			//     sub_1802F01E0(&v278, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v278, v200, v201, 0LL);
			//     v202 = *(_OWORD *)&v278.width;
			//     v270 = *(_OWORD *)&v278.width;
			//     v271 = *(_OWORD *)&v278.colorFormat;
			//     v272 = *(_OWORD *)&v278.enableRandomWrite;
			//     *(_QWORD *)&v273 = *(_QWORD *)&v278.bindTextureMS;
			//     v203 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//     v274 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//     v204 = v278.clearColor;
			//     v275 = v278.clearColor;
			//     *((_QWORD *)&v273 + 1) = "Screen Space Reflection Current Fadeness Texture";
			//     if ( dword_18D8E43F8 )
			//     {
			//       v205 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v205 + 36190]);
			//       do
			//         v206 = qword_18D6405E0[v205 + 36190];
			//       while ( v206 != _InterlockedCompareExchange64(
			//                         &qword_18D6405E0[v205 + 36190],
			//                         v206 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                         v206) );
			//       v204 = v275;
			//       v203 = v274;
			//       v202 = v270;
			//     }
			//     LODWORD(v271) = 5;
			//     LOWORD(v272) = 257;
			//     BYTE2(v272) = 0;
			//     *(_OWORD *)&v292.width = v202;
			//     *(_OWORD *)&v292.colorFormat = v271;
			//     *(_OWORD *)&v292.enableRandomWrite = v272;
			//     *(_OWORD *)&v292.bindTextureMS = v273;
			//     *(_OWORD *)&v292.fastMemoryDesc.inFastMemory = v203;
			//     v292.clearColor = v204;
			//     v207 = v268;
			//     v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//               (TextureHandle *)&v276,
			//               renderGraph,
			//               &v292,
			//               0LL);
			//     v210 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//               (TextureHandle *)&v276,
			//               &v277,
			//               &v269,
			//               0LL);
			//     if ( !v207 )
			//       sub_1802DC2C8(v209, v208);
			//     *(TextureHandle *)&v207[30].monitor = v210;
			//     if ( !v268 )
			//       sub_1802DC2C8(v209, v208);
			//     if ( BYTE1(v268[1].klass) )
			//     {
			//       v222 = hgCamera.fields._sceneRTSize_k__BackingField;
			//       sub_1802F01E0(&v278, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v278,
			//         hgCamera.fields._sceneRTSize_k__BackingField.m_X,
			//         v222.m_Y,
			//         0LL);
			//       v223 = *(_OWORD *)&v278.width;
			//       v270 = *(_OWORD *)&v278.width;
			//       v271 = *(_OWORD *)&v278.colorFormat;
			//       v272 = *(_OWORD *)&v278.enableRandomWrite;
			//       *(_QWORD *)&v273 = *(_QWORD *)&v278.bindTextureMS;
			//       v224 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//       v274 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//       v225 = v278.clearColor;
			//       v275 = v278.clearColor;
			//       *((_QWORD *)&v273 + 1) = "Screen Space Reflection Temporal Texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v226 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v226 + 36190]);
			//         do
			//           v227 = qword_18D6405E0[v226 + 36190];
			//         while ( v227 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v226 + 36190],
			//                           v227 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                           v227) );
			//         v225 = v275;
			//         v224 = v274;
			//         v223 = v270;
			//       }
			//       LODWORD(v271) = 74;
			//       LOBYTE(v272) = 1;
			//       *(_OWORD *)&v294.width = v223;
			//       *(_OWORD *)&v294.colorFormat = v271;
			//       *(_OWORD *)&v294.enableRandomWrite = v272;
			//       *(_OWORD *)&v294.bindTextureMS = v273;
			//       *(_OWORD *)&v294.fastMemoryDesc.inFastMemory = v224;
			//       v294.clearColor = v225;
			//       v218 = v268;
			//       v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                 (TextureHandle *)&v276,
			//                 renderGraph,
			//                 &v294,
			//                 0LL);
			//       v221 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &v269,
			//                 0LL);
			//       if ( !v218 )
			//         sub_1802DC2C8(v220, v219);
			//     }
			//     else
			//     {
			//       v211 = (int32_t)v268[2].klass;
			//       v212 = HIDWORD(v268[2].klass);
			//       sub_1802F01E0(&v278, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v278, v211, v212, 0LL);
			//       v213 = *(_OWORD *)&v278.width;
			//       v270 = *(_OWORD *)&v278.width;
			//       v271 = *(_OWORD *)&v278.colorFormat;
			//       v272 = *(_OWORD *)&v278.enableRandomWrite;
			//       *(_QWORD *)&v273 = *(_QWORD *)&v278.bindTextureMS;
			//       v214 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//       v274 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//       v215 = v278.clearColor;
			//       v275 = v278.clearColor;
			//       *((_QWORD *)&v273 + 1) = "Screen Space Reflection Temporal Texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v216 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v216 + 36190]);
			//         do
			//           v217 = qword_18D6405E0[v216 + 36190];
			//         while ( v217 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v216 + 36190],
			//                           v217 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                           v217) );
			//         v215 = v275;
			//         v214 = v274;
			//         v213 = v270;
			//       }
			//       LODWORD(v271) = 74;
			//       LOWORD(v272) = 257;
			//       BYTE2(v272) = 0;
			//       *(_OWORD *)&v293.width = v213;
			//       *(_OWORD *)&v293.colorFormat = v271;
			//       *(_OWORD *)&v293.enableRandomWrite = v272;
			//       *(_OWORD *)&v293.bindTextureMS = v273;
			//       *(_OWORD *)&v293.fastMemoryDesc.inFastMemory = v214;
			//       v293.clearColor = v215;
			//       v218 = v268;
			//       v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                 (TextureHandle *)&v276,
			//                 renderGraph,
			//                 &v293,
			//                 0LL);
			//       v221 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &v269,
			//                 0LL);
			//       if ( !v218 )
			//         sub_1802DC2C8(v220, v219);
			//     }
			//     *(TextureHandle *)&v218[32].monitor = v221;
			//     v228 = v268;
			//     if ( !v268 )
			//       sub_1802DC2C8(v220, v219);
			//     this.fields.m_currentFadenessTexture = *(TextureHandle *)((char *)v268 + 488);
			//     this.fields.m_currentTemporalColorTexture = *(TextureHandle *)((char *)v228 + 520);
			//     if ( this.fields.m_firstFrame )
			//     {
			//       v238 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 (TextureHandle *)&v228[26].monitor,
			//                 0LL);
			//       if ( !v228 )
			//         sub_1802DC2C8(v237, v236);
			//       *(TextureHandle *)&v228[29].monitor = v238;
			//       v232 = v268;
			//       if ( !v268 )
			//         sub_1802DC2C8(v237, v236);
			//       v235 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 (TextureHandle *)&v268[23].monitor,
			//                 0LL);
			//     }
			//     else
			//     {
			//       v231 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &this.fields.m_previousFadenessTexture,
			//                 0LL);
			//       if ( !v228 )
			//         sub_1802DC2C8(v230, v229);
			//       *(TextureHandle *)&v228[29].monitor = v231;
			//       v232 = v268;
			//       v235 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &this.fields.m_previousTemporalColorTexture,
			//                 0LL);
			//       if ( !v232 )
			//         sub_1802DC2C8(v234, v233);
			//     }
			//     *(TextureHandle *)&v232[31].monitor = v235;
			//     v239 = v268;
			//     if ( !v268 )
			//       sub_1802DC2C8(v234, v233);
			//     if ( BYTE1(v268[1].klass) )
			//     {
			//       v241 = (int32_t)v268[2].klass;
			//       v242 = HIDWORD(v268[2].klass);
			//       sub_1802F01E0(&v278, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v278, v241, v242, 0LL);
			//       v243 = *(_OWORD *)&v278.width;
			//       v270 = *(_OWORD *)&v278.width;
			//       v271 = *(_OWORD *)&v278.colorFormat;
			//       v272 = *(_OWORD *)&v278.enableRandomWrite;
			//       *(_QWORD *)&v273 = *(_QWORD *)&v278.bindTextureMS;
			//       v244 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//       v274 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//       v245 = v278.clearColor;
			//       v275 = v278.clearColor;
			//       *((_QWORD *)&v273 + 1) = "Screen Space Reflection Temporal Texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v246 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v246 + 36190]);
			//         do
			//           v247 = qword_18D6405E0[v246 + 36190];
			//         while ( v247 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v246 + 36190],
			//                           v247 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                           v247) );
			//         v245 = v275;
			//         v244 = v274;
			//         v243 = v270;
			//       }
			//       LODWORD(v271) = 74;
			//       LOWORD(v272) = 257;
			//       BYTE2(v272) = 0;
			//       *(_OWORD *)&v295.width = v243;
			//       *(_OWORD *)&v295.colorFormat = v271;
			//       *(_OWORD *)&v295.enableRandomWrite = v272;
			//       *(_OWORD *)&v295.bindTextureMS = v273;
			//       *(_OWORD *)&v295.fastMemoryDesc.inFastMemory = v244;
			//       v295.clearColor = v245;
			//       v239 = v268;
			//       v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                 (TextureHandle *)&v276,
			//                 renderGraph,
			//                 &v295,
			//                 0LL);
			//       v240 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                 (TextureHandle *)&v276,
			//                 &v277,
			//                 &v269,
			//                 0LL);
			//       if ( !v239 )
			//         sub_1802DC2C8(v234, v233);
			//     }
			//     else
			//     {
			//       v240 = *(TextureHandle *)&v268[32].monitor;
			//     }
			//     *(TextureHandle *)&v239[33].monitor = v240;
			//     if ( !v268 )
			//       sub_1802DC2C8(v234, v233);
			//     v248 = (int32_t)v268[2].klass;
			//     v249 = HIDWORD(v268[2].klass);
			//     sub_1802F01E0(&v278, 0LL, 96LL);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v278, v248, v249, 0LL);
			//     v250 = *(_OWORD *)&v278.width;
			//     v270 = *(_OWORD *)&v278.width;
			//     v271 = *(_OWORD *)&v278.colorFormat;
			//     v272 = *(_OWORD *)&v278.enableRandomWrite;
			//     *(_QWORD *)&v273 = *(_QWORD *)&v278.bindTextureMS;
			//     v251 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//     v274 = *(_OWORD *)&v278.fastMemoryDesc.inFastMemory;
			//     v252 = v278.clearColor;
			//     v275 = v278.clearColor;
			//     *((_QWORD *)&v273 + 1) = "Screen Space Reflection Color Resolve Texture";
			//     if ( dword_18D8E43F8 )
			//     {
			//       v253 = ((((unsigned __int64)&v273 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v253 + 36190]);
			//       do
			//         v254 = qword_18D6405E0[v253 + 36190];
			//       while ( v254 != _InterlockedCompareExchange64(
			//                         &qword_18D6405E0[v253 + 36190],
			//                         v254 | (1LL << ((((unsigned __int64)&v273 + 8) >> 12) & 0x3F)),
			//                         v254) );
			//       v252 = v275;
			//       v251 = v274;
			//       v250 = v270;
			//     }
			//     LODWORD(v271) = 74;
			//     LOBYTE(v272) = 1;
			//     *(_OWORD *)&v296.width = v250;
			//     *(_OWORD *)&v296.colorFormat = v271;
			//     *(_OWORD *)&v296.enableRandomWrite = v272;
			//     *(_OWORD *)&v296.bindTextureMS = v273;
			//     *(_OWORD *)&v296.fastMemoryDesc.inFastMemory = v251;
			//     v296.clearColor = v252;
			//     v255 = v268;
			//     v269 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//               (TextureHandle *)&v276,
			//               renderGraph,
			//               &v296,
			//               0LL);
			//     v258 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//               (TextureHandle *)&v276,
			//               &v277,
			//               &v269,
			//               0LL);
			//     if ( !v255 )
			//       sub_1802DC2C8(v257, v256);
			//     *(TextureHandle *)&v255[34].monitor = v258;
			//     if ( !v268 )
			//       sub_1802DC2C8(v257, v256);
			//     if ( BYTE1(v268[1].klass) )
			//       v259 = *(TextureHandle *)&v268[23].monitor;
			//     else
			//       v259 = *(TextureHandle *)&v268[34].monitor;
			//     this.fields.m_ssrLightingTexture = v259;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//       &v277,
			//       (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass.static_fields.s_RenderFunc,
			//       0LL,
			//       0,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::PassData>);
			//     sub_180222690(v283);
			//   }
			//   else
			//   {
			//     this.fields.m_shouldRender = 0;
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     this.fields.m_ssrLightingTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                            (TextureHandle *)&v276,
			//                                            renderGraph,
			//                                            this.fields.m_defaultTexutre,
			//                                            0LL);
			//     this.fields.m_ssrFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                            (TextureHandle *)&v276,
			//                                            renderGraph,
			//                                            this.fields.m_defaultTexutre,
			//                                            0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     this.fields.m_currentFadenessTexture = *(TextureHandle *)sub_182E7CCD0(&v276);
			//     this.fields.m_currentTemporalColorTexture = *(TextureHandle *)sub_182E7CCD0(&v276);
			//   }
			// }
			// 
		}

		public bool ShouldRenderTBuffer(HGCamera hgCamera)
		{
			// // Boolean ShouldRenderTBuffer(HGCamera)
			// bool HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::ShouldRenderTBuffer(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2787, 0LL) )
			//   {
			//     if ( hgCamera )
			//       return HG::Rendering::Runtime::HGCamera::get_ssrEnable(hgCamera, 0LL);
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2787, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)hgCamera,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal void RenderTBuffer(ref HyperScreenSpaceReflectionRenderingPass.PassInput input, ref HyperScreenSpaceReflectionRenderingPass.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void RenderTBuffer(HyperScreenSpaceReflectionRenderingPass+PassInput ByRef, HyperScreenSpaceReflectionRenderingPass+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::RenderTBuffer(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HyperScreenSpaceReflectionRenderingPass_PassInput *input,
			//         HyperScreenSpaceReflectionRenderingPass_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   bool v10; // zf
			//   TextureHandle normalRoughnessTextureCopy; // xmm0
			//   TextureHandle currentSceneDepthTexture; // xmm0
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   __int64 forwardReflectionECSList; // rcx
			//   Object *v18; // rdi
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   TextureHandle v21; // xmm0
			//   Object *v22; // rdi
			//   __int64 v23; // rdx
			//   TextureHandle v24; // xmm0
			//   Object *v25; // rdx
			//   unsigned int v26; // edx
			//   unsigned __int64 v27; // r8
			//   char v28; // dl
			//   signed __int64 v29; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   Object *v33; // [rsp+50h] [rbp-B8h] BYREF
			//   __m128i si128; // [rsp+60h] [rbp-A8h] BYREF
			//   _QWORD v35[2]; // [rsp+70h] [rbp-98h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+80h] [rbp-88h] BYREF
			//   HGRenderGraphBuilder v37; // [rsp+A0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v38; // [rsp+C0h] [rbp-48h] BYREF
			//   TextureHandle v39; // [rsp+D0h] [rbp-38h] BYREF
			//   TextureHandle v40; // [rsp+E0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9195B6 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5008F8);
			//     byte_18D9195B6 = 1;
			//   }
			//   v33 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2788, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2788, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v32, v31);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1020(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = !input.needCopyGBufferAndDepth;
			//     if ( input.needCopyGBufferAndDepth )
			//       normalRoughnessTextureCopy = input.normalRoughnessTextureCopy;
			//     else
			//       normalRoughnessTextureCopy = input.normalRoughnessTexture;
			//     v39 = normalRoughnessTextureCopy;
			//     if ( v10 )
			//       currentSceneDepthTexture = input.currentSceneDepthTexture;
			//     else
			//       currentSceneDepthTexture = input.currentSceneDepthTextureCopy;
			//     v40 = currentSceneDepthTexture;
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x5Eu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v37,
			//       renderGraph,
			//       (String *)"Screen Space Reflection",
			//       &v33,
			//       v13,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>);
			//     v36 = v37;
			//     v35[0] = 0LL;
			//     v35[1] = &v36;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v36, 0, 0LL);
			//       forwardReflectionECSList = input.forwardReflectionECSList;
			//       if ( !v33 )
			//         sub_1802DC2C8(forwardReflectionECSList, v16);
			//       HIDWORD(v33[1].klass) = forwardReflectionECSList;
			//       LOBYTE(forwardReflectionECSList) = input.needCopyGBufferAndDepth;
			//       if ( !v33 )
			//         sub_1802DC2C8(forwardReflectionECSList, v16);
			//       LOBYTE(v33[1].klass) = forwardReflectionECSList;
			//       if ( input.needCopyGBufferAndDepth )
			//       {
			//         v18 = v33;
			//         v21 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&si128,
			//                  &v36,
			//                  &input.normalRoughnessTexture,
			//                  0LL);
			//         if ( !v18 )
			//           sub_1802DC2C8(v20, v19);
			//         *(TextureHandle *)&v18[1].monitor = v21;
			//         v22 = v33;
			//         v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&si128,
			//                  &v36,
			//                  &input.currentSceneDepthTexture,
			//                  0LL);
			//         if ( !v22 )
			//           sub_1802DC2C8(forwardReflectionECSList, v23);
			//         *(TextureHandle *)&v22[2].monitor = v24;
			//       }
			//       v25 = v33;
			//       if ( !v33 )
			//         sub_1802DC2C8(forwardReflectionECSList, 0LL);
			//       v33[3].monitor = (MonitorData *)this.fields.m_transparentMBP;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v26 = ((unsigned __int64)&v25[3].monitor >> 12) & 0x1FFFFF;
			//         v27 = (unsigned __int64)v26 >> 6;
			//         v28 = v26 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v27]);
			//         do
			//           v29 = qword_18D6870D0[v27];
			//         while ( v29 != _InterlockedCompareExchange64(&qword_18D6870D0[v27], v29 | (1LL << v28), v29) );
			//       }
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v37,
			//         &v36,
			//         &v39,
			//         0,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&v37,
			//         &v36,
			//         &v40,
			//         DepthAccess__Enum_Write,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         1.0,
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v36,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass.static_fields.s_RenderTransparentFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::TransparentPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v38 )
			//     {
			//       v35[0] = v38.ex;
			//     }
			//     sub_180222690(v35);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2789, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2789, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2790, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2790, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   bool v5; // si
			//   __int64 v6; // rcx
			//   TextureHandle *v7; // rax
			//   HGRenderGraph *renderGraph; // rdx
			//   TextureHandle *v9; // rax
			//   TextureHandle *v10; // rax
			//   int32_t v11; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v5 = 1;
			//   if ( !byte_18D9195B7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D500920);
			//     byte_18D9195B7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2791, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2791, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//       return;
			//     }
			//     goto LABEL_23;
			//   }
			//   if ( input.passSkipped )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     this.fields.m_currentFadenessTexture = *(TextureHandle *)sub_182E7CCD0(&v13);
			//     this.fields.m_currentTemporalColorTexture = *(TextureHandle *)sub_182E7CCD0(&v13);
			//     this.fields.m_currentDeferredTemporalColorTexture = *(TextureHandle *)sub_182E7CCD0(&v13);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currentFadenessTexture, 0LL) )
			//   {
			//     renderGraph = input.renderGraph;
			//     if ( !renderGraph )
			//       goto LABEL_23;
			//     v7 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//            &v13,
			//            renderGraph,
			//            &this.fields.m_currentFadenessTexture,
			//            1,
			//            (String *)"SSRPass",
			//            0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v7 = (TextureHandle *)sub_182E7CCD0(&v13);
			//   }
			//   this.fields.m_previousFadenessTexture = *v7;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currentTemporalColorTexture, 0LL) )
			//   {
			//     renderGraph = input.renderGraph;
			//     if ( !renderGraph )
			//       goto LABEL_23;
			//     v9 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//            &v13,
			//            renderGraph,
			//            &this.fields.m_currentTemporalColorTexture,
			//            1,
			//            (String *)"SSRPass",
			//            0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v9 = (TextureHandle *)sub_182E7CCD0(&v13);
			//   }
			//   this.fields.m_previousTemporalColorTexture = *v9;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
			//          &this.fields.m_currentDeferredTemporalColorTexture,
			//          0LL) )
			//   {
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       v10 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//               &v13,
			//               renderGraph,
			//               &this.fields.m_currentDeferredTemporalColorTexture,
			//               1,
			//               (String *)"SSRPass",
			//               0LL);
			//       goto LABEL_18;
			//     }
			// LABEL_23:
			//     sub_180B536AC(v6, renderGraph);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   v10 = (TextureHandle *)sub_182E7CCD0(&v13);
			// LABEL_18:
			//   this.fields.m_previousDeferredTemporalColorTexture = *v10;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currentTemporalColorTexture, 0LL) )
			//   {
			//     v11 = (this.fields.m_frameIndex + 1) % 64;
			//     v5 = 0;
			//   }
			//   else
			//   {
			//     v11 = 0;
			//   }
			//   this.fields.m_firstFrame = v5;
			//   this.fields.m_frameIndex = v11;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   this.fields.m_deferredFirstFrame = !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
			//                                          &this.fields.m_currentDeferredTemporalColorTexture,
			//                                          0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::HyperScreenSpaceReflectionRenderingPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         HyperScreenSpaceReflectionRenderingPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2792, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2792, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		private bool m_shouldRender;

		private bool m_shouldDeferredRender;

		private bool m_firstFrame;

		private bool m_deferredFirstFrame;

		private int m_frameIndex;

		private Vector2Int m_previousRenderSize;

		private TextureHandle m_previousFadenessTexture;

		private TextureHandle m_currentFadenessTexture;

		private TextureHandle m_previousTemporalColorTexture;

		private TextureHandle m_currentTemporalColorTexture;

		private TextureHandle m_previousDeferredTemporalColorTexture;

		private TextureHandle m_currentDeferredTemporalColorTexture;

		private TextureHandle m_ssrLightingTexture;

		private TextureHandle m_ssrFadenessTexture;

		private RTHandle m_defaultTexutre;

		private ComputeShader m_computeShader;

		private Material m_pixelShader;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<HyperScreenSpaceReflectionRenderingPass.PassData> s_RenderFunc;

		private long m_impl;

		private MaterialPropertyBlock m_transparentMBP;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<HyperScreenSpaceReflectionRenderingPass.TransparentPassData> s_RenderTransparentFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal bool needCopyGBufferAndDepth;

			internal int ssrRayMarchingSampleCount;

			internal uint forwardReflectionECSList;

			internal TextureHandle previousSceneColorTexture;

			internal TextureHandle previousSceneDepthPyramidTexture;

			internal TextureHandle currentSceneColorTexture;

			internal TextureHandle currentSceneDepthTexture;

			internal TextureHandle currentSceneDepthTextureCopy;

			internal TextureHandle currentSceneDepthPyramidTexture;

			internal TextureHandle gbufferNormalRoughenssTexture;

			internal TextureHandle normalRoughnessTexture;

			internal TextureHandle normalRoughnessTextureCopy;

			internal TextureHandle motionVectorTexture;

			internal TextureHandle waterWetnessMaskTexture;

			internal ScriptableRenderContext renderContext;

			internal HGSettingParameters settingParameters;
		}

		internal struct PassOutput
		{
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 160)]
		public struct ScreenSpaceReflectionData
		{
			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 param3;

			public Vector4 param4;

			public Vector4 param5;

			public Vector4 param6;

			public Vector4 param7;

			public Vector4 previousColorPyramidRenderSize;

			public Vector4 currentColorPyramidRenderSize;
		}

		private class PassData
		{
			public PassData()
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

			public bool firstFrame;

			public bool upsample;

			public bool importanceSample;

			public int maxMipCount;

			public Vector2Int renderSize;

			public Vector2Int ssrRenderSize;

			public Vector2Int temporalRenderSize;

			public HyperScreenSpaceReflectionRenderingPass.ScreenSpaceReflectionData cbData;

			public CBHandle cbHandle;

			public TextureHandle previousSceneColorTexture;

			public TextureHandle previousSceneDepthPyramidTexture;

			public TextureHandle currentSceneColorTexture;

			public TextureHandle currentSceneDepthTexture;

			public TextureHandle currentSceneDepthPyramidTexture;

			public TextureHandle gbufferNormalRoughenssTexture;

			public TextureHandle normalRoughnessTexture;

			public TextureHandle motionVectorTexture;

			public TextureHandle waterWetnessMaskTexture;

			public TextureHandle rayMarchingColorTexture;

			public TextureHandle rayMarchingHitUVTexture;

			public TextureHandle filterWeightTexture;

			public TextureHandle fadenessTexture;

			public TextureHandle fadenessBlurTexture0;

			public TextureHandle fadenessBlurTexture1;

			public TextureHandle previousFadenessTexture;

			public TextureHandle currentFadenessTexture;

			public TextureHandle previousTemporalColorTexture;

			public TextureHandle currentTemporalColorTexture;

			public TextureHandle currentColorPyramidTexture;

			public TextureHandle currentColorResolveTexture;

			public TextureHandle currentColorUpsampleTexture;

			public TextureHandle sampleSceneColorTexture;

			public ComputeShader computeShader;

			public bool ssrRenderWetness;
		}

		private class TransparentPassData
		{
			public TransparentPassData()
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

			public bool needCopyGBufferAndDepth;

			public uint forwardReflectionECSList;

			public TextureHandle normalRoughnessTexture;

			public TextureHandle currentSceneDepthTexture;

			public MaterialPropertyBlock transparentMBP;
		}
	}
}
