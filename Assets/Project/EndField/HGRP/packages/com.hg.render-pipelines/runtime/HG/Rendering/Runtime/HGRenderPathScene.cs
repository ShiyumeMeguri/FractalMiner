using System;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Rain;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPathScene : HGRenderPathBase
	{
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x000025D0 File Offset: 0x000007D0
		protected TextureHandle sceneColor
		{
			[CompilerGenerated]
			get
			{
				// // TextureHandle get_sceneColor()
				// TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneColor(
				//         TextureHandle *__return_ptr retstr,
				//         HGRenderPathScene *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_sceneColor(TextureHandle)
				// void HG::Rendering::Runtime::HGRenderPathScene::set_sceneColor(
				//         HGRenderPathScene *this,
				//         TextureHandle *value,
				//         MethodInfo *method)
				// {
				//   *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle sceneDepth
		{
			[CompilerGenerated]
			protected get
			{
				// // TextureHandle get_sceneDepth()
				// TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneDepth(
				//         TextureHandle *__return_ptr retstr,
				//         HGRenderPathScene *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_sceneDepth(TextureHandle)
				// void HG::Rendering::Runtime::HGRenderPathScene::set_sceneDepth(
				//         HGRenderPathScene *this,
				//         TextureHandle *value,
				//         MethodInfo *method)
				// {
				//   *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00 = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle sceneMV
		{
			[CompilerGenerated]
			protected get
			{
				// // TextureHandle get_sceneMV()
				// TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneMV(
				//         TextureHandle *__return_ptr retstr,
				//         HGRenderPathScene *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_sceneMV(TextureHandle)
				// void HG::Rendering::Runtime::HGRenderPathScene::set_sceneMV(
				//         HGRenderPathScene *this,
				//         TextureHandle *value,
				//         MethodInfo *method)
				// {
				//   *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01 = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle sceneDepthCopied
		{
			[CompilerGenerated]
			protected get
			{
				// // TextureHandle get_sceneDepthCopied()
				// TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneDepthCopied(
				//         TextureHandle *__return_ptr retstr,
				//         HGRenderPathScene *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_sceneDepthCopied(TextureHandle)
				// void HG::Rendering::Runtime::HGRenderPathScene::set_sceneDepthCopied(
				//         HGRenderPathScene *this,
				//         TextureHandle *value,
				//         MethodInfo *method)
				// {
				//   *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02 = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected HGCamera uiCamera
		{
			[CompilerGenerated]
			protected get
			{
				// // HGCamera get_uiCamera()
				// HGCamera *HG::Rendering::Runtime::HGRenderPathScene::get_uiCamera(HGRenderPathScene *this, MethodInfo *method)
				// {
				//   return *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_uiCamera(HGCamera)
				// void HG::Rendering::Runtime::HGRenderPathScene::set_uiCamera(
				//         HGRenderPathScene *this,
				//         HGCamera *value,
				//         MethodInfo *method)
				// {
				//   HGCamera *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				// 
				//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = value;
				//   sub_1800054D0(
				//     (HGRenderPathOnePassDeferred *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03,
				//     (HGRenderPathBase_HGRenderPathResources *)value,
				//     (HGCamera *)method,
				//     v3,
				//     v4);
				// }
				// 
			}
		}

		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle historySceneColor
		{
			[CompilerGenerated]
			protected get
			{
				// // TextureHandle get_historySceneColor()
				// TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_historySceneColor(
				//         TextureHandle *__return_ptr retstr,
				//         HGRenderPathScene *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_historySceneColor(TextureHandle)
				// void HG::Rendering::Runtime::HGRenderPathScene::set_historySceneColor(
				//         HGRenderPathScene *this,
				//         TextureHandle *value,
				//         MethodInfo *method)
				// {
				//   *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23 = *value;
				// }
				// 
			}
		}

		internal HGRenderPathScene(HGRenderPathBase.HGRenderPathResources resources, PassConstructorID[] passConstructorIDs, HGCamera camera, HGRenderPathInternal renderPath)
		{
			// // HGRenderPathScene(HGRenderPathBase+HGRenderPathResources, PassConstructorID[], HGCamera, HGRenderPathInternal)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGRenderPathScene::HGRenderPathScene(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         PassConstructorID__Enum__Array *passConstructorIDs,
			//         HGCamera *camera,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   IPassConstructor *PassConstructor; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   IPassConstructor *v14; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   IPassConstructor *v18; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   IPassConstructor *v22; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
			//   PassConstructorID__Enum__Array *v24; // r8
			//   HGCamera *v25; // r9
			//   IPassConstructor *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   IPassConstructor *v30; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   IPassConstructor *v34; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   IPassConstructor *v38; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   PassConstructorID__Enum__Array *v40; // r8
			//   HGCamera *v41; // r9
			//   IPassConstructor *v42; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v43; // rdx
			//   PassConstructorID__Enum__Array *v44; // r8
			//   HGCamera *v45; // r9
			//   IPassConstructor *v46; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   PassConstructorID__Enum__Array *v48; // r8
			//   HGCamera *v49; // r9
			//   IPassConstructor *v50; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v51; // rdx
			//   PassConstructorID__Enum__Array *v52; // r8
			//   HGCamera *v53; // r9
			//   IPassConstructor *v54; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v55; // rdx
			//   PassConstructorID__Enum__Array *v56; // r8
			//   HGCamera *v57; // r9
			//   IPassConstructor *v58; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v59; // rdx
			//   PassConstructorID__Enum__Array *v60; // r8
			//   HGCamera *v61; // r9
			//   IPassConstructor *v62; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v63; // rdx
			//   PassConstructorID__Enum__Array *v64; // r8
			//   HGCamera *v65; // r9
			//   IPassConstructor *v66; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v67; // rdx
			//   PassConstructorID__Enum__Array *v68; // r8
			//   HGCamera *v69; // r9
			//   MethodInfo *v70; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v71; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v72; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v73; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v74; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v75; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v76; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v77; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v78; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v79; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v80; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v81; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v82; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v83; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v84; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v85; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v86; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v87; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v88; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v89; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v90; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v91; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v92; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v93; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v94; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v95; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v96; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v97; // [rsp+28h] [rbp-20h]
			//   HGRenderPathBase_HGRenderPathResources v98; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB16 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//     byte_18D8EDB16 = 1;
			//   }
			//   v98 = *resources;
			//   this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 = NAN;
			//   HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
			//     (HGRenderPathBase *)this,
			//     &v98,
			//     passConstructorIDs,
			//     camera,
			//     renderPath,
			//     0LL);
			//   PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                       (HGRenderPathBase *)this,
			//                       PassConstructorID__Enum_UIImageBlur,
			//                       0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                    PassConstructor,
			//                                                                                    TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//   sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4648), v11, v12, v13, v70, v84);
			//   v14 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_LightShaftApply,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m00 = sub_18003F5A0(
			//                                                                                           v14,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//   sub_18003F5A0(v14, TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4656), v15, v16, v17, v71, v85);
			//   v18 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Parafin,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20 = sub_18003F5A0(
			//                                                                                           v18,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//   sub_18003F5A0(v18, TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4664), v19, v20, v21, v72, v86);
			//   v22 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_DepthOfField,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01 = sub_18003F5A0(
			//                                                                                           v22,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//   sub_18003F5A0(v22, TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4672), v23, v24, v25, v73, v87);
			//   v26 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_MotionBlur,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m21 = sub_18003F5A0(
			//                                                                                           v26,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
			//   sub_18003F5A0(v26, TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4680), v27, v28, v29, v74, v88);
			//   v30 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TransparentAfterDOF,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m02 = sub_18003F5A0(
			//                                                                                           v30,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//   sub_18003F5A0(v30, TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4688), v31, v32, v33, v75, v89);
			//   v34 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_TAAU,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m22 = sub_18003F5A0(
			//                                                                                           v34,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//   sub_18003F5A0(v34, TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4696), v35, v36, v37, v76, v90);
			//   v38 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_MetalFXTemporal,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m03 = sub_18003F5A0(
			//                                                                                           v38,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
			//   sub_18003F5A0(v38, TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4704), v39, v40, v41, v77, v91);
			//   v42 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_LensFlare,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m23 = sub_18003F5A0(
			//                                                                                           v42,
			//                                                                                           TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//   sub_18003F5A0(v42, TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4712), v43, v44, v45, v78, v92);
			//   v46 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_UberPost,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                               v46,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//   sub_18003F5A0(v46, TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4720), v47, v48, v49, v79, v93);
			//   v50 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_MetalFXSpatial,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                               v50,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//   sub_18003F5A0(v50, TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4728), v51, v52, v53, v80, v94);
			//   v54 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_UI,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                               v54,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//   sub_18003F5A0(v54, TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4736), v55, v56, v57, v81, v95);
			//   v58 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Multiblur,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                               v58,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//   sub_18003F5A0(v58, TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4744), v59, v60, v61, v82, v96);
			//   v62 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ScreenSpaceOverlay,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02 = sub_18003F5A0(
			//                                                                                               v62,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//   sub_18003F5A0(v62, TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4752), v63, v64, v65, v83, v97);
			//   v66 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_SetFinalTarget,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m22 = sub_18003F5A0(
			//                                                                                               v66,
			//                                                                                               TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//   sub_18003F5A0(v66, TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
			//   sub_1800054D0((HGRenderPathScene *)((char *)this + 4760), v67, v68, v69, *(MethodInfo **)&renderPath, method);
			// }
			// 
		}

		protected override bool SkipRender(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Boolean SkipRender(HGRenderPathBase+HGRenderPathParams ByRef)
			// bool HG::Rendering::Runtime::HGRenderPathScene::SkipRender(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Camera *v6; // rcx
			//   __int64 v7; // rax
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3017, 0LL) )
			//   {
			//     v7 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     if ( v7 )
			//     {
			//       v6 = *(Camera **)(v7 + 96);
			//       if ( v6 )
			//       {
			//         result = UnityEngine::Camera::get_cullingMask(v6, 0LL) == 0;
			//         renderPathParams.skipRender = result;
			//         return result;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3017, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(Patch, (Object *)this, renderPathParams, 0LL);
			// }
			// 
			return default(bool);
		}

		protected override void UpdateShaderVariablesGlobal(HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd, ref ShaderVariablesGlobal shaderVariablesGlobal, ref ScriptableRenderContext context)
		{
			// // Void UpdateShaderVariablesGlobal(HGRenderPipeline, HGCamera, CommandBuffer, ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobal(
			//         HGRenderPathScene *this,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *erosionBlend_k__BackingField; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rbp
			//   HGRainRenderer *s_rainRenderer; // rax
			//   RainCommonPreSettingParam *CurrentPresettingParams; // rax
			//   float v16; // xmm0_4
			//   float v17; // xmm1_4
			//   float y; // xmm2_4
			//   float v19; // xmm3_4
			//   Vector4 v20; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919658 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D919658 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3018, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobal(
			//       (HGRenderPathBase *)this,
			//       hgrp,
			//       camera,
			//       cmd,
			//       shaderVariablesGlobal,
			//       context,
			//       0LL);
			//     if ( hgrp )
			//     {
			//       settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//       HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalMaterialStylizer(
			//         this,
			//         shaderVariablesGlobal,
			//         camera,
			//         0LL);
			//       HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalEnvironment(
			//         this,
			//         shaderVariablesGlobal,
			//         camera,
			//         0LL);
			//       HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCloudShadow(
			//         this,
			//         shaderVariablesGlobal,
			//         camera,
			//         0LL);
			//       HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGraphFeaturesGlobalParam0(
			//         this,
			//         shaderVariablesGlobal,
			//         camera,
			//         settingParameters_k__BackingField,
			//         0LL);
			//       if ( settingParameters_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalAtmosphere(
			//           this,
			//           shaderVariablesGlobal,
			//           camera,
			//           cmd,
			//           settingParameters_k__BackingField.fields._atmosphereParams_k__BackingField,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//         s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//         if ( s_rainRenderer )
			//         {
			//           CurrentPresettingParams = HG::Rendering::Runtime::HGRainRenderer::GetCurrentPresettingParams(
			//                                       s_rainRenderer,
			//                                       0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCharacter(
			//             this,
			//             shaderVariablesGlobal,
			//             camera,
			//             cmd,
			//             CurrentPresettingParams,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWind(
			//             this,
			//             shaderVariablesGlobal,
			//             camera,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWaterInteraction(
			//             this,
			//             shaderVariablesGlobal,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalRainAndWetness(
			//             this,
			//             shaderVariablesGlobal,
			//             context,
			//             camera,
			//             cmd,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalVerticalOcclusionMap(
			//             this,
			//             shaderVariablesGlobal,
			//             camera,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateWaterWetnessMaskParam(
			//             this,
			//             shaderVariablesGlobal,
			//             camera,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageOccluder(
			//             this,
			//             shaderVariablesGlobal,
			//             0LL);
			//           HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageInteract(
			//             this,
			//             shaderVariablesGlobal,
			//             0LL);
			//           erosionBlend_k__BackingField = (ILFixDynamicMethodWrapper_2 *)settingParameters_k__BackingField.fields._erosionBlend_k__BackingField;
			//           if ( erosionBlend_k__BackingField )
			//           {
			//             v16 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                     (SettingParameter_1_System_Boolean_ *)erosionBlend_k__BackingField.fields.virtualMachine,
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//                 ? 1.0
			//                 : 0.0;
			//             shaderVariablesGlobal[1]._PrevViewNoTransProjMatrix.m00 = v16;
			//             if ( camera )
			//             {
			//               shaderVariablesGlobal._ScreenSize = (Vector4)_mm_loadu_si128((const __m128i *)&camera.fields._sceneRTSizeParam_k__BackingField);
			//               shaderVariablesGlobal._BackBufferSize = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGCamera::get_finalRTSizeParam(
			//                                                                                                    &v20,
			//                                                                                                    camera,
			//                                                                                                    0LL));
			//               LODWORD(v17) = _mm_loadu_si128((const __m128i *)&camera.fields._sceneRTSizeParam_k__BackingField).m128i_u32[0];
			//               y = camera.fields._sceneRTSizeParam_k__BackingField.y;
			//               v19 = camera.fields._sceneRTSizeParam_k__BackingField.w + 1.0;
			//               v20.z = camera.fields._sceneRTSizeParam_k__BackingField.z + 1.0;
			//               v20.x = v17;
			//               v20.y = y;
			//               v20.w = v19;
			//               shaderVariablesGlobal._ScreenParams = v20;
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(erosionBlend_k__BackingField, v11);
			//   }
			//   erosionBlend_k__BackingField = IFix::WrappersManagerImpl::GetPatch(3018, 0LL);
			//   if ( !erosionBlend_k__BackingField )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_384(
			//     erosionBlend_k__BackingField,
			//     (Object *)this,
			//     (Object *)hgrp,
			//     (Object *)camera,
			//     (Object *)cmd,
			//     shaderVariablesGlobal,
			//     context,
			//     0LL);
			// }
			// 
		}

		protected override void OnPreRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   Texture **textures; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // r13
			//   HGRenderGraph *m_RenderGraph; // r15
			//   GraphicsFormat__Enum ColorBufferFormat; // eax
			//   GraphicsFormat__Enum v10; // r12d
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   HGCamera *v14; // rax
			//   int32_t msaaSamples_k__BackingField; // edi
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   TextureHandle *v17; // rax
			//   bool clearDepth; // al
			//   Vector2Int *v19; // r9
			//   _OWORD *v20; // rax
			//   bool v21; // zf
			//   Vector2Int *v22; // rbx
			//   Vector2Int v23; // rbx
			//   CommandBuffer *commandBuffer; // rdi
			//   int32_t GlintPatternTexture; // ebx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   RenderTargetIdentifier *v27; // rax
			//   HGRenderPipelineRuntimeResources_TextureResources *v28; // rdx
			//   __int64 v29; // rcx
			//   __int128 v30; // xmm1
			//   int32_t PerlinNoiseTex; // ebx
			//   HGRenderPipelineRuntimeResources *v32; // rax
			//   RenderTargetIdentifier *v33; // rax
			//   __int128 v34; // xmm1
			//   int32_t SnowDetailNormalTex; // ebx
			//   HGRenderPipelineRuntimeResources *v36; // rax
			//   HGRenderPipelineRuntimeResources_TextureResources *v37; // rdx
			//   __int64 v38; // rcx
			//   RenderTargetIdentifier *v39; // rax
			//   __int128 v40; // xmm1
			//   HGRenderGraphDefaultResources *m_DefaultResources; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   int32_t VerticalOcclusionMap; // ebx
			//   RenderTargetIdentifier *v44; // rax
			//   __int128 v45; // xmm1
			//   __int64 v46; // rdx
			//   HGRenderPipelineAsset *m_Asset; // rcx
			//   HGRenderPipelineRuntimeResources *renderPipelineResources; // rax
			//   HGRenderPipelineRuntimeResources_AssetResources *assets; // rsi
			//   Object_1 *rainPresettingAsset; // rsi
			//   HGRenderGraphDefaultResources *v51; // rax
			//   int32_t v52; // ebx
			//   TextureHandle v53; // xmm6
			//   RenderTargetIdentifier *v54; // rax
			//   __int128 v55; // xmm1
			//   __int64 v56; // rdx
			//   HGShaderIDs__StaticFields *v57; // rcx
			//   HGRenderGraphDefaultResources *v58; // rax
			//   int32_t RippleTexture; // ebx
			//   RenderTargetIdentifier *v60; // rax
			//   __int128 v61; // xmm1
			//   int32_t v62; // ebx
			//   Texture *v63; // rax
			//   RenderTargetIdentifier *v64; // rax
			//   __int128 v65; // xmm1
			//   __int64 v66; // rdx
			//   HGShaderIDs__StaticFields *v67; // rcx
			//   HGRenderGraphDefaultResources *v68; // rax
			//   int32_t CharacterRainEffectTex; // ebx
			//   RenderTargetIdentifier *v70; // rax
			//   __int128 v71; // xmm1
			//   __int64 v72; // rdx
			//   HGShaderIDs__StaticFields *v73; // rcx
			//   HGRenderGraphDefaultResources *v74; // rax
			//   int32_t CharacterRainStreakTex; // ebx
			//   RenderTargetIdentifier *v76; // rax
			//   __int128 v77; // xmm1
			//   __int64 v78; // rdx
			//   HGShaderIDs__StaticFields *v79; // rcx
			//   HGRenderGraphDefaultResources *v80; // rax
			//   int32_t CharacterRainFaceDripTex; // ebx
			//   RenderTargetIdentifier *v82; // rax
			//   __int128 v83; // xmm1
			//   __int64 v84; // rdx
			//   HGShaderIDs__StaticFields *v85; // rcx
			//   HGRenderGraphDefaultResources *v86; // rax
			//   int32_t CharacterRainFaceDropletTex; // ebx
			//   RenderTargetIdentifier *v88; // rax
			//   RenderTargetIdentifier *v89; // r8
			//   __int128 v90; // xmm1
			//   Object_1__Class *klass; // rbx
			//   Object_1 *v92; // rbx
			//   HGRenderGraphDefaultResources *v93; // rax
			//   int32_t v94; // ebx
			//   TextureHandle blackTexture_k__BackingField; // xmm6
			//   RenderTargetIdentifier *v96; // rax
			//   __int128 v97; // xmm1
			//   Object_1__Class *v98; // rbx
			//   Object_1 *genericContainerHandle; // rbx
			//   HGRenderGraphDefaultResources *v100; // rax
			//   int32_t v101; // ebx
			//   TextureHandle v102; // xmm6
			//   RenderTargetIdentifier *v103; // rax
			//   __int128 v104; // xmm1
			//   Object_1__Class *v105; // rbx
			//   Object_1 *v106; // rbx
			//   int32_t RainOcclusionSampleNoise; // ebx
			//   Texture *blackTexture3D; // rdx
			//   RenderTargetIdentifier *v109; // rax
			//   __int128 v110; // xmm1
			//   Object_1__Class *v111; // rbx
			//   Object_1 *methodPtr; // rbx
			//   HGRenderGraphDefaultResources *v113; // rax
			//   int32_t v114; // ebx
			//   TextureHandle v115; // xmm6
			//   RenderTargetIdentifier *v116; // rax
			//   __int128 v117; // xmm1
			//   Object_1__Class *v118; // rbx
			//   Object_1 *v119; // rbx
			//   HGRenderGraphDefaultResources *v120; // rax
			//   int32_t v121; // ebx
			//   TextureHandle v122; // xmm6
			//   RenderTargetIdentifier *v123; // rax
			//   __int128 v124; // xmm1
			//   Object_1__Class *v125; // rbx
			//   Object_1 *v126; // rbx
			//   HGRenderGraphDefaultResources *v127; // rax
			//   int32_t v128; // ebx
			//   TextureHandle v129; // xmm6
			//   RenderTargetIdentifier *v130; // rax
			//   __int128 v131; // xmm1
			//   Object_1__Class *v132; // rbx
			//   Object_1 *v133; // rbx
			//   HGRenderGraphDefaultResources *v134; // rax
			//   TextureHandle v135; // xmm6
			//   RenderTargetIdentifier *v136; // rax
			//   __int128 v137; // xmm1
			//   HGRenderPipelineRuntimeResources *v138; // rax
			//   HGRenderPipelineRuntimeResources_AssetResources *v139; // rsi
			//   Object_1 *snowPresettingAsset; // rsi
			//   Object_1__Class *v141; // rbx
			//   Object_1 *element_class; // rbx
			//   int32_t v143; // ebx
			//   RenderTargetIdentifier *v144; // rax
			//   HGRenderGraphDefaultResources *v145; // rax
			//   TextureHandle v146; // xmm6
			//   __int128 v147; // xmm1
			//   __int64 v148; // rax
			//   __int64 v149; // rbx
			//   __int64 v150; // rbx
			//   int32_t v151; // esi
			//   Texture *v152; // rax
			//   RenderTargetIdentifier *v153; // rax
			//   int32_t v154; // edx
			//   __int128 v155; // xmm1
			//   int32_t CharMaxCubemap; // ebx
			//   Texture *blackCubeTexture; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v159; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v160; // [rsp+30h] [rbp-D8h]
			//   TextureHandle v161; // [rsp+48h] [rbp-C0h] BYREF
			//   RenderTargetIdentifier v162; // [rsp+58h] [rbp-B0h] BYREF
			//   RenderTargetIdentifier v163; // [rsp+88h] [rbp-80h] BYREF
			//   RenderTargetIdentifier v164; // [rsp+B8h] [rbp-50h] BYREF
			//   TextureDesc v165; // [rsp+E8h] [rbp-20h] BYREF
			//   TextureDesc v166; // [rsp+148h] [rbp+40h] BYREF
			//   HGCamera *v167; // [rsp+200h] [rbp+F8h]
			// 
			//   if ( !byte_18D919659 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Texture>::op_Inequality);
			//     byte_18D919659 = 1;
			//   }
			//   sub_1802F01E0(&v165, 0LL, 96LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2979, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering((HGRenderPathBase *)this, renderPathParams, 0LL);
			//     hgrp = renderPathParams.hgrp;
			//     if ( !hgrp )
			//       goto LABEL_104;
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     ColorBufferFormat = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
			//                           renderPathParams.hgrp,
			//                           *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//                           0LL);
			//     v6 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     v10 = ColorBufferFormat;
			//     if ( !v6 )
			//       goto LABEL_104;
			//     *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera((HGCamera *)v6, 0LL);
			//     sub_1800054D0((HGRenderPathScene *)((char *)this + 4832), v11, v12, v13, v159, v160);
			//     v14 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     v167 = v14;
			//     if ( !v14 )
			//       goto LABEL_104;
			//     msaaSamples_k__BackingField = v14.fields._msaaSamples_k__BackingField;
			//     sceneRTSize_k__BackingField = v14.fields._sceneRTSize_k__BackingField;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     v17 = HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
			//             &v161,
			//             m_RenderGraph,
			//             v167,
			//             msaaSamples_k__BackingField != 1,
			//             v10,
			//             sceneRTSize_k__BackingField,
			//             0LL);
			//     v6 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = *v17;
			//     if ( !v6 )
			//       goto LABEL_104;
			//     clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth((HGCamera *)v6, 0LL);
			//     v19 = *(Vector2Int **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     if ( !v19 )
			//       goto LABEL_104;
			//     *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(&v161, m_RenderGraph, clearDepth, (MSAASamples__Enum)v19[209].m_X, (DepthBits__Enum)renderPathParams.perFrameSetup.depthBits, (GraphicsFormat__Enum)renderPathParams.perFrameSetup.depthGraphicsFormat, v19[6], 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v20 = (_OWORD *)sub_182E7CCD0(&v161);
			//     v21 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01 == 0LL;
			//     *(_OWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01 = *v20;
			//     if ( v21 )
			//       goto LABEL_104;
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//       &v165,
			//       *(Vector2Int *)(*(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01 + 48LL),
			//       0LL);
			//     v6 = 1LL;
			//     v165.fastMemoryDesc.residencyFraction = 1.0;
			//     *(_QWORD *)&v161.handle._type_k__BackingField = 1LL;
			//     v161.handle.m_Value = 1;
			//     *(ResourceHandle *)&v165.fastMemoryDesc.inFastMemory = v161.handle;
			//     v165.slices = 1;
			//     v165.colorFormat = 75;
			//     v165.dimension = 2;
			//     v165.msaaSamples = 1;
			//     v166 = v165;
			//     v165.clearColor = (Color)_mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//     if ( !m_RenderGraph )
			//       goto LABEL_104;
			//     *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v161, m_RenderGraph, &v166, 0LL);
			//     v22 = *(Vector2Int **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     if ( !v22 )
			//       goto LABEL_104;
			//     v23 = v22[6];
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(&v161, m_RenderGraph, v23, 0LL);
			//     commandBuffer = renderPathParams.renderGraphParams.commandBuffer;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     GlintPatternTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintPatternTexture;
			//     defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//     if ( !defaultResources )
			//       goto LABEL_104;
			//     textures = (Texture **)defaultResources.fields.textures;
			//     if ( !textures )
			//       goto LABEL_104;
			//     v27 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v162, textures[7], 0LL);
			//     if ( !commandBuffer )
			//       goto LABEL_102;
			//     v30 = *(_OWORD *)&v27.m_BufferPointer;
			//     *(_OWORD *)&v163.m_Type = *(_OWORD *)&v27.m_Type;
			//     *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v27.m_DepthSlice;
			//     *(_OWORD *)&v163.m_BufferPointer = v30;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, GlintPatternTexture, &v163, 0LL);
			//     PerlinNoiseTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PerlinNoiseTex;
			//     v32 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//     if ( !v32 || (v28 = v32.fields.textures) == 0LL )
			// LABEL_102:
			//       sub_180B536AC(v29, v28);
			//     v33 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v162, (Texture *)v28.fields.PerlinNoiseTex, 0LL);
			//     v34 = *(_OWORD *)&v33.m_BufferPointer;
			//     *(_OWORD *)&v163.m_Type = *(_OWORD *)&v33.m_Type;
			//     *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v33.m_DepthSlice;
			//     *(_OWORD *)&v163.m_BufferPointer = v34;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, PerlinNoiseTex, &v163, 0LL);
			//     SnowDetailNormalTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SnowDetailNormalTex;
			//     v36 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//     if ( !v36 || (v37 = v36.fields.textures) == 0LL )
			//       sub_180B536AC(v38, v37);
			//     v39 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             &v162,
			//             (Texture *)v37.fields.SnowDetailNormal,
			//             0LL);
			//     v40 = *(_OWORD *)&v39.m_BufferPointer;
			//     *(_OWORD *)&v163.m_Type = *(_OWORD *)&v39.m_Type;
			//     *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v39.m_DepthSlice;
			//     *(_OWORD *)&v163.m_BufferPointer = v40;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, SnowDetailNormalTex, &v163, 0LL);
			//     m_DefaultResources = m_RenderGraph.fields.m_DefaultResources;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     VerticalOcclusionMap = static_fields._VerticalOcclusionMap;
			//     if ( !m_DefaultResources )
			//       sub_180B536AC(static_fields, 0LL);
			//     v44 = UnityEngine::Rendering::RTHandle::op_Implicit(&v162, m_DefaultResources.fields.m_ShadowTexture2D, 0LL);
			//     v45 = *(_OWORD *)&v44.m_BufferPointer;
			//     *(_OWORD *)&v163.m_Type = *(_OWORD *)&v44.m_Type;
			//     *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v44.m_DepthSlice;
			//     *(_OWORD *)&v163.m_BufferPointer = v45;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, VerticalOcclusionMap, &v163, 0LL);
			//     m_Asset = hgrp.fields.m_Asset;
			//     if ( !m_Asset
			//       || (renderPipelineResources = HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderPipelineResources(
			//                                       m_Asset,
			//                                       0LL)) == 0LL
			//       || (assets = renderPipelineResources.fields.assets) == 0LL )
			//     {
			//       sub_180B536AC(m_Asset, v46);
			//     }
			//     rainPresettingAsset = (Object_1 *)assets.fields.rainPresettingAsset;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(rainPresettingAsset, 0LL, 0LL) )
			//     {
			//       if ( !rainPresettingAsset )
			//         goto LABEL_104;
			//       klass = rainPresettingAsset[1].klass;
			//       if ( !klass )
			//         goto LABEL_104;
			//       v92 = *(Object_1 **)&klass._1.initializationExceptionGCHandle;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(v92, 0LL, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v94 = *(_DWORD *)(v6 + 3204);
			//         if ( !textures )
			//           goto LABEL_104;
			//         v96 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[27], 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v93 = m_RenderGraph.fields.m_DefaultResources;
			//         v94 = *(_DWORD *)(v6 + 3204);
			//         if ( !v93 )
			//           goto LABEL_104;
			//         blackTexture_k__BackingField = v93.fields._blackTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v161 = blackTexture_k__BackingField;
			//         v96 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//       }
			//       v97 = *(_OWORD *)&v96.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v96.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v96.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v97;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v94, &v162, 0LL);
			//       v98 = rainPresettingAsset[1].klass;
			//       if ( !v98 )
			//         goto LABEL_104;
			//       genericContainerHandle = (Object_1 *)v98._1.genericContainerHandle;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(genericContainerHandle, 0LL, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v101 = *(_DWORD *)(v6 + 3208);
			//         if ( !textures )
			//           goto LABEL_104;
			//         v103 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[30], 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v100 = m_RenderGraph.fields.m_DefaultResources;
			//         v101 = *(_DWORD *)(v6 + 3208);
			//         if ( !v100 )
			//           goto LABEL_104;
			//         v102 = v100.fields._blackTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v161 = v102;
			//         v103 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//       }
			//       v104 = *(_OWORD *)&v103.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v103.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v103.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v104;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v101, &v162, 0LL);
			//       v105 = rainPresettingAsset[1].klass;
			//       if ( !v105 )
			//         goto LABEL_104;
			//       v106 = *(Object_1 **)&v105._1.naturalAligment;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(v106, 0LL, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         RainOcclusionSampleNoise = *(_DWORD *)(v6 + 3200);
			//         if ( !textures )
			//           goto LABEL_104;
			//         blackTexture3D = textures[38];
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         RainOcclusionSampleNoise = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainOcclusionSampleNoise;
			//         blackTexture3D = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//       }
			//       v109 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, blackTexture3D, 0LL);
			//       v110 = *(_OWORD *)&v109.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v109.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v109.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v110;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, RainOcclusionSampleNoise, &v162, 0LL);
			//       v111 = rainPresettingAsset[1].klass;
			//       if ( !v111 )
			//         goto LABEL_104;
			//       methodPtr = (Object_1 *)v111.vtable.Finalize.methodPtr;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(0LL, methodPtr, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v114 = *(_DWORD *)(v6 + 516);
			//         if ( !textures )
			//           goto LABEL_104;
			//         v116 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[41], 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v113 = m_RenderGraph.fields.m_DefaultResources;
			//         v114 = *(_DWORD *)(v6 + 516);
			//         if ( !v113 )
			//           goto LABEL_104;
			//         v115 = v113.fields._blackTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v161 = v115;
			//         v116 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//       }
			//       v117 = *(_OWORD *)&v116.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v116.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v116.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v117;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v114, &v162, 0LL);
			//       v118 = rainPresettingAsset[1].klass;
			//       if ( !v118 )
			//         goto LABEL_104;
			//       v119 = (Object_1 *)v118.vtable.Finalize.method;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(0LL, v119, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v121 = *(_DWORD *)(v6 + 520);
			//         if ( !textures )
			//           goto LABEL_104;
			//         v123 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[42], 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v120 = m_RenderGraph.fields.m_DefaultResources;
			//         v121 = *(_DWORD *)(v6 + 520);
			//         if ( !v120 )
			//           goto LABEL_104;
			//         v122 = v120.fields._blackTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v161 = v122;
			//         v123 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//       }
			//       v124 = *(_OWORD *)&v123.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v123.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v123.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v124;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v121, &v162, 0LL);
			//       v125 = rainPresettingAsset[1].klass;
			//       if ( !v125 )
			//         goto LABEL_104;
			//       v126 = (Object_1 *)v125.vtable.GetHashCode.methodPtr;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(0LL, v126, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v128 = *(_DWORD *)(v6 + 524);
			//         if ( !textures )
			//           goto LABEL_104;
			//         v130 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[43], 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v127 = m_RenderGraph.fields.m_DefaultResources;
			//         v128 = *(_DWORD *)(v6 + 524);
			//         if ( !v127 )
			//           goto LABEL_104;
			//         v129 = v127.fields._blackTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v161 = v129;
			//         v130 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//       }
			//       v131 = *(_OWORD *)&v130.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v130.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v130.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v131;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v128, &v162, 0LL);
			//       v132 = rainPresettingAsset[1].klass;
			//       if ( !v132 )
			//         goto LABEL_104;
			//       v133 = (Object_1 *)v132.vtable.GetHashCode.method;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(0LL, v133, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         textures = (Texture **)rainPresettingAsset[1].klass;
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         CharacterRainFaceDropletTex = *(_DWORD *)(v6 + 528);
			//         if ( !textures )
			//           goto LABEL_104;
			//         v136 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[44], 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v134 = m_RenderGraph.fields.m_DefaultResources;
			//         CharacterRainFaceDropletTex = *(_DWORD *)(v6 + 528);
			//         if ( !v134 )
			//           goto LABEL_104;
			//         v135 = v134.fields._blackTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v161 = v135;
			//         v136 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//       }
			//       v89 = &v162;
			//       v137 = *(_OWORD *)&v136.m_BufferPointer;
			//       *(_OWORD *)&v162.m_Type = *(_OWORD *)&v136.m_Type;
			//       *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v136.m_DepthSlice;
			//       *(_OWORD *)&v162.m_BufferPointer = v137;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       v51 = m_RenderGraph.fields.m_DefaultResources;
			//       v52 = *(_DWORD *)(v6 + 3204);
			//       if ( !v51 )
			//         goto LABEL_104;
			//       v53 = v51.fields._blackTexture_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v161 = v53;
			//       v54 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v162, &v161, 0LL);
			//       v55 = *(_OWORD *)&v54.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v54.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v54.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v55;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v52, &v163, 0LL);
			//       v57 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       v58 = m_RenderGraph.fields.m_DefaultResources;
			//       RippleTexture = v57._RippleTexture;
			//       if ( !v58 )
			//         sub_180B536AC(v57, v56);
			//       v161 = v58.fields._blackTexture_k__BackingField;
			//       v60 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v162, &v161, 0LL);
			//       v61 = *(_OWORD *)&v60.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v60.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v60.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v61;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, RippleTexture, &v163, 0LL);
			//       v62 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._RainOcclusionSampleNoise;
			//       v63 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//       v64 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v162, v63, 0LL);
			//       v65 = *(_OWORD *)&v64.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v64.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v64.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v65;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v62, &v163, 0LL);
			//       v67 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       v68 = m_RenderGraph.fields.m_DefaultResources;
			//       CharacterRainEffectTex = v67._CharacterRainEffectTex;
			//       if ( !v68 )
			//         sub_180B536AC(v67, v66);
			//       v161 = v68.fields._blackTexture_k__BackingField;
			//       v70 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v162, &v161, 0LL);
			//       v71 = *(_OWORD *)&v70.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v70.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v70.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v71;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainEffectTex, &v163, 0LL);
			//       v73 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       v74 = m_RenderGraph.fields.m_DefaultResources;
			//       CharacterRainStreakTex = v73._CharacterRainStreakTex;
			//       if ( !v74 )
			//         sub_180B536AC(v73, v72);
			//       v161 = v74.fields._blackTexture_k__BackingField;
			//       v76 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v162, &v161, 0LL);
			//       v77 = *(_OWORD *)&v76.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v76.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v76.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v77;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainStreakTex, &v163, 0LL);
			//       v79 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       v80 = m_RenderGraph.fields.m_DefaultResources;
			//       CharacterRainFaceDripTex = v79._CharacterRainFaceDripTex;
			//       if ( !v80 )
			//         sub_180B536AC(v79, v78);
			//       v161 = v80.fields._blackTexture_k__BackingField;
			//       v82 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v162, &v161, 0LL);
			//       v83 = *(_OWORD *)&v82.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v82.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v82.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v83;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainFaceDripTex, &v163, 0LL);
			//       v85 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       v86 = m_RenderGraph.fields.m_DefaultResources;
			//       CharacterRainFaceDropletTex = v85._CharacterRainFaceDropletTex;
			//       if ( !v86 )
			//         sub_180B536AC(v85, v84);
			//       v161 = v86.fields._blackTexture_k__BackingField;
			//       v88 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v162, &v161, 0LL);
			//       v89 = &v163;
			//       v90 = *(_OWORD *)&v88.m_BufferPointer;
			//       *(_OWORD *)&v163.m_Type = *(_OWORD *)&v88.m_Type;
			//       *(_QWORD *)&v163.m_DepthSlice = *(_QWORD *)&v88.m_DepthSlice;
			//       *(_OWORD *)&v163.m_BufferPointer = v90;
			//     }
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainFaceDropletTex, v89, 0LL);
			//     v6 = (__int64)hgrp.fields.m_Asset;
			//     if ( v6 )
			//     {
			//       v138 = HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderPipelineResources(
			//                (HGRenderPipelineAsset *)v6,
			//                0LL);
			//       if ( v138 )
			//       {
			//         v139 = v138.fields.assets;
			//         if ( v139 )
			//         {
			//           snowPresettingAsset = (Object_1 *)v139.fields.snowPresettingAsset;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( !UnityEngine::Object::op_Inequality(snowPresettingAsset, 0LL, 0LL) )
			//             goto LABEL_89;
			//           if ( !snowPresettingAsset )
			//             goto LABEL_104;
			//           v141 = snowPresettingAsset[1].klass;
			//           if ( !v141 )
			//             goto LABEL_104;
			//           element_class = (Object_1 *)v141._0.element_class;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Inequality(0LL, element_class, 0LL) )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             textures = (Texture **)snowPresettingAsset[1].klass;
			//             v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             v143 = *(_DWORD *)(v6 + 532);
			//             if ( !textures )
			//               goto LABEL_104;
			//             v144 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, textures[8], 0LL);
			//           }
			//           else
			//           {
			// LABEL_89:
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             v145 = m_RenderGraph.fields.m_DefaultResources;
			//             v143 = *(_DWORD *)(v6 + 532);
			//             if ( !v145 )
			//               goto LABEL_104;
			//             v146 = v145.fields._blackTexture_k__BackingField;
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//             v161 = v146;
			//             v144 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v164, &v161, 0LL);
			//           }
			//           v147 = *(_OWORD *)&v144.m_BufferPointer;
			//           *(_OWORD *)&v162.m_Type = *(_OWORD *)&v144.m_Type;
			//           *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v144.m_DepthSlice;
			//           *(_OWORD *)&v162.m_BufferPointer = v147;
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v143, &v162, 0LL);
			//           v148 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//           if ( v148 )
			//           {
			//             v149 = *(_QWORD *)(v148 + 2504);
			//             if ( v149 )
			//             {
			//               v150 = *(_QWORD *)(v149 + 104);
			//               sub_180002C70(TypeInfo::UnityEngine::Object);
			//               if ( !UnityEngine::Object::op_Inequality((Object_1 *)v150, 0LL, 0LL) )
			//                 goto LABEL_99;
			//               if ( !v150 )
			//                 goto LABEL_104;
			//               if ( !UnityEngine::Rendering::VolumeParameter<System::Object>::op_Inequality(
			//                       *(VolumeParameter_1_System_Object_ **)(v150 + 48),
			//                       0LL,
			//                       MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Texture>::op_Inequality) )
			//               {
			// LABEL_99:
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 CharMaxCubemap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CharMaxCubemap;
			//                 sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//                 blackCubeTexture = (Texture *)UnityEngine::Rendering::CoreUtils::get_blackCubeTexture(0LL);
			//                 v153 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, blackCubeTexture, 0LL);
			//                 v154 = CharMaxCubemap;
			//                 goto LABEL_98;
			//               }
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               textures = *(Texture ***)(v150 + 48);
			//               v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               v151 = *(_DWORD *)(v6 + 508);
			//               if ( textures )
			//               {
			//                 v152 = (Texture *)sub_18004EF00(10LL, textures);
			//                 v153 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v164, v152, 0LL);
			//                 v154 = v151;
			// LABEL_98:
			//                 v155 = *(_OWORD *)&v153.m_BufferPointer;
			//                 *(_OWORD *)&v162.m_Type = *(_OWORD *)&v153.m_Type;
			//                 *(_QWORD *)&v162.m_DepthSlice = *(_QWORD *)&v153.m_DepthSlice;
			//                 *(_OWORD *)&v162.m_BufferPointer = v155;
			//                 UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v154, &v162, 0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_104:
			//     sub_180B536AC(v6, textures);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2979, 0LL);
			//   if ( !Patch )
			//     goto LABEL_104;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			// }
			// 
		}

		protected override PassConstructorID FindFirstBackbufferPass()
		{
			// // PassConstructorID FindFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathScene::FindFirstBackbufferPass(
			//         HGRenderPathScene *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   HGCamera *v4; // rdx
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *RTForExtraction; // rax
			//   __m128i v6; // xmm6
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *v7; // rax
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v8; // xmm8
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v9; // xmm1
			//   __m128i v10; // xmm7
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v12; // rdi
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v13; // r14
			//   _BOOL8 v14; // r15
			//   unsigned __int64 v15; // xmm6_8
			//   _BOOL8 v16; // rsi
			//   _BOOL8 v17; // rax
			//   BOOL v18; // r14d
			//   PassConstructorID__Enum v19; // eax
			//   PassConstructorID__Enum v20; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v23; // [rsp+20h] [rbp-60h] BYREF
			//   Nullable_1_Beyond_Gameplay_Core_Skill_InterruptContext_ v24[2]; // [rsp+30h] [rbp-50h] BYREF
			// 
			//   if ( !byte_18D91965A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::Nullable);
			//     sub_18003C530(&MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::get_Value);
			//     byte_18D91965A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3035, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3035, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_53;
			//   }
			//   v4 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//   if ( !v4 )
			//     goto LABEL_53;
			//   RTForExtraction = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
			//                       &v23,
			//                       v4,
			//                       RTExtractionType__Enum_SceneColorPS,
			//                       0LL);
			//   v4 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//   v6 = *(__m128i *)RTForExtraction;
			//   if ( !v4 )
			//     goto LABEL_53;
			//   v7 = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(&v23, v4, RTExtractionType__Enum_FinalResult, 0LL);
			//   v4 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//   v8 = *v7;
			//   if ( v4 )
			//   {
			//     v9 = *HG::Rendering::Runtime::HGCamera::GetRTForExtraction(&v23, v4, RTExtractionType__Enum_FinalResult, 0LL);
			//     memset(v24, 0, 24);
			//     v23 = v9;
			//     System::Nullable<UnityEngine::InputSystem::InputAction::CallbackContext>::Nullable(
			//       (Nullable_1_UnityEngine_InputSystem_InputAction_CallbackContext_ *)v24,
			//       (InputAction_CallbackContext *)&v23,
			//       MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::Nullable);
			//     v10 = *(__m128i *)&v24[0].hasValue;
			//   }
			//   else
			//   {
			//     v10 = 0LL;
			//     v24[0].value.nextSkillId = 0LL;
			//   }
			//   v3 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//   *(__m128i *)&v24[0].hasValue = v10;
			//   if ( !v3 )
			//     goto LABEL_53;
			//   InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs((HGCamera *)v3, 0LL);
			//   v3 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//   v12 = InplaceWaterMarkRTs;
			//   v13 = v3 ? HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs((HGCamera *)v3, 0LL) : 0LL;
			//   if ( *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03
			//     && *(int *)(*(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 + 2424LL) > 0 )
			//   {
			//     LODWORD(v14) = 1;
			//   }
			//   else
			//   {
			//     if ( !*(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01 )
			//       goto LABEL_53;
			//     v14 = *(_DWORD *)(*(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01 + 2424LL) > 0;
			//   }
			//   if ( !v6.m128i_i64[0] )
			//     goto LABEL_53;
			//   if ( *(int *)(v6.m128i_i64[0] + 32) > 0 )
			//     goto LABEL_28;
			//   v15 = _mm_srli_si128(v6, 8).m128i_u64[0];
			//   if ( !v15 )
			//     goto LABEL_53;
			//   if ( *(int *)(v15 + 32) > 0 )
			//     goto LABEL_28;
			//   if ( !v8.Item1 )
			//     goto LABEL_53;
			//   if ( v8.Item1.fields._count > 0 )
			//   {
			// LABEL_28:
			//     LODWORD(v16) = 1;
			//   }
			//   else if ( *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 )
			//   {
			//     LODWORD(v16) = 0;
			//   }
			//   else
			//   {
			//     if ( !v12 )
			//       goto LABEL_53;
			//     v16 = v12.fields._size > 0;
			//   }
			//   LOBYTE(v3) = 0;
			//   if ( (unsigned __int8)_mm_cvtsi128_si32(v10) )
			//   {
			//     System::Nullable<Beyond::Gameplay::Core::Skill::InterruptContext>::get_Value(
			//       (Skill_InterruptContext *)&v23,
			//       v24,
			//       MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::get_Value);
			//     if ( !v23.Item1 )
			//       goto LABEL_53;
			//     if ( v23.Item1.fields._count <= 0 )
			//     {
			//       if ( !v23.Item2 )
			//         goto LABEL_53;
			//       LOBYTE(v3) = v23.Item2.fields._count > 0;
			//     }
			//     else
			//     {
			//       v3 = 1LL;
			//     }
			//   }
			//   if ( v13 )
			//   {
			//     v3 = (unsigned __int8)v3;
			//     if ( v13.fields._size > 0 )
			//       v3 = 1LL;
			//   }
			//   if ( *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 )
			//   {
			//     if ( !v12 )
			//       goto LABEL_53;
			//     v17 = v12.fields._size > 0;
			//   }
			//   else
			//   {
			//     LODWORD(v17) = 0;
			//   }
			//   v18 = v17 | (unsigned __int8)v3;
			//   v19 = (unsigned int)sub_18003ED00(6LL);
			//   v3 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//   v20 = v19;
			//   if ( !v3 )
			// LABEL_53:
			//     sub_180B536AC(v3, v4);
			//   if ( HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler((HGCamera *)v3, 0LL) )
			//     v20 = PassConstructorID__Enum_UI;
			//   if ( v16 )
			//     v20 = PassConstructorID__Enum_UI;
			//   if ( v14 )
			//     v20 = PassConstructorID__Enum_ScreenSpaceOverlay;
			//   if ( v18 )
			//     return 60;
			//   return v20;
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		protected override void OnPostRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::OnPostRendering(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // rax
			//   HGRenderGraph *m_RenderGraph; // rsi
			//   TextureHandle v9; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v11; // [rsp+30h] [rbp-28h] BYREF
			//   TextureHandle v12; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91965B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D50D9A0);
			//     byte_18D91965B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3037, 0LL) )
			//   {
			//     hgrp = renderPathParams.hgrp;
			//     if ( hgrp )
			//     {
			//       m_RenderGraph = hgrp.fields.m_RenderGraph;
			//       if ( renderPathParams.skipRender )
			//         v9 = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23;
			//       else
			//         v9 = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       v11 = v9;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v11, 0LL) )
			//         goto LABEL_11;
			//       if ( m_RenderGraph )
			//       {
			//         *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23 = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(&v12, m_RenderGraph, &v11, 1, (String *)"historySceneColor", 0LL);
			// LABEL_11:
			//         HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering((HGRenderPathBase *)this, renderPathParams, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3037, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			// }
			// 
		}

		protected override void RenderInternal(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderInternal(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGRenderPathScene::RenderInternal(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v3; // r13
			//   HGRenderPathScene *v4; // r15
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGCamera *hgrp; // r12
			//   HGRenderGraph *v8; // rdi
			//   HGCamera *m_Ptr; // rbx
			//   unsigned __int64 v10; // rdx
			//   UIImageBlurManager *instance; // rax
			//   unsigned __int64 v12; // r8
			//   signed __int64 v13; // rtt
			//   UIImageBlurPassConstructor *v14; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rsi
			//   Shader *blitPS; // rsi
			//   void *ptr; // rdi
			//   HGCamera *v21; // rdi
			//   HGCamera *v22; // rsi
			//   HGRenderPipelineRuntimeResources *v23; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *v24; // r8
			//   HGRenderGraph *v25; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   UIImageBlurPassConstructor_PassOutput output; // [rsp+40h] [rbp-98h] BYREF
			//   HGRenderGraph *renderGraph; // [rsp+48h] [rbp-90h]
			//   Il2CppException *ex; // [rsp+50h] [rbp-88h]
			//   char *v32; // [rsp+58h] [rbp-80h]
			//   UIImageBlurManager *v33; // [rsp+60h] [rbp-78h] BYREF
			//   HGCamera *v34; // [rsp+68h] [rbp-70h]
			//   HGCamera *uiCamera; // [rsp+70h] [rbp-68h]
			//   UIImageBlurPassConstructor_PassInput input; // [rsp+78h] [rbp-60h] BYREF
			//   CommandBuffer *cmd; // [rsp+80h] [rbp-58h]
			//   Il2CppExceptionWrapper *v38; // [rsp+90h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v39; // [rsp+98h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v40; // [rsp+A0h] [rbp-38h] BYREF
			//   char v43; // [rsp+F8h] [rbp+20h] BYREF
			// 
			//   v3 = renderPathParams;
			//   v4 = this;
			//   if ( !byte_18D91965C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//     byte_18D91965C = 1;
			//   }
			//   v43 = 0;
			//   input.uiImageBlurMgr = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3039, 0LL) )
			//   {
			//     hgrp = (HGCamera *)v3.hgrp;
			//     v34 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     v8 = *(HGRenderGraph **)&hgrp.fields.mainViewConstants.nonJitteredProjMatrix.m01;
			//     renderGraph = v8;
			//     m_Ptr = (HGCamera *)v3.renderGraphParams.scriptableRenderContext.m_Ptr;
			//     uiCamera = m_Ptr;
			//     cmd = v3.renderGraphParams.commandBuffer;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v32 = &v43;
			//     try
			//     {
			//       v33 = 0LL;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//       instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//       v33 = instance;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v12 = (((unsigned __int64)&v33 >> 12) & 0x1FFFFF) >> 6;
			//         v10 = ((unsigned __int64)&v33 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v12]);
			//         do
			//           v13 = qword_18D6870D0[v12];
			//         while ( v13 != _InterlockedCompareExchange64(&qword_18D6870D0[v12], v13 | (1LL << v10), v13) );
			//         instance = v33;
			//       }
			//       input.uiImageBlurMgr = instance;
			//       output = 0;
			//       v14 = *(UIImageBlurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m23;
			//       if ( !v14 )
			//         sub_1802DC2C8(0LL, v10);
			//       HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
			//         v14,
			//         &input,
			//         &output,
			//         v8,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v38 )
			//     {
			//       ex = v38.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v34;
			//       m_Ptr = uiCamera;
			//     }
			//     v34 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     uiCamera = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//     defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources((HGRenderPipeline *)hgrp, 0LL);
			//     if ( !defaultResources )
			//       goto LABEL_33;
			//     shaders = defaultResources.fields.shaders;
			//     if ( !shaders )
			//       goto LABEL_33;
			//     blitPS = shaders.fields.blitPS;
			//     ptr = v3.renderRequest.cullingResults.cullingResults.ptr;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(v34, uiCamera, blitPS, ptr, renderGraph, v3, 0LL);
			//     v21 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     v22 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//     v23 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources((HGRenderPipeline *)hgrp, 0LL);
			//     if ( !v23 || (v24 = v23.fields.shaders) == 0LL )
			// LABEL_33:
			//       sub_1802DC2C8(v17, v16);
			//     HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
			//       v21,
			//       v22,
			//       v24.fields.blitPS,
			//       v3.renderRequest.cullingResults.cullingResults.ptr,
			//       renderGraph,
			//       v3,
			//       0LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     ex = 0LL;
			//     v32 = &v43;
			//     try
			//     {
			//       HG::Rendering::Runtime::HGRenderPathScene::PrepareData(
			//         v4,
			//         (ScriptableRenderContext)m_Ptr,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         cmd,
			//         (HGRenderPipeline *)hgrp,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v39 )
			//     {
			//       ex = v39.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       v25 = renderGraph;
			//       goto LABEL_22;
			//     }
			//     v25 = renderGraph;
			// LABEL_22:
			//     sub_18005B3A0(14LL, v4, v3);
			//     HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase1(v4, v3, 0LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)1u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
			//     ex = 0LL;
			//     v32 = &v43;
			//     try
			//     {
			//       HG::Rendering::Runtime::HGRenderPathScene::OverrideShaderVariablesGlobal(
			//         v4,
			//         v25,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         1,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v40 )
			//     {
			//       ex = v40.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//     }
			//     HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase2(v4, v3, 0LL);
			//     HG::Rendering::Runtime::HGRenderPathScene::RenderEditorPrimitives(v4, v3, 0LL);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3039, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v28, v27);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v4, v3, 0LL);
			// }
			// 
		}

		internal override void Dispose(HGRenderGraph renderGraph)
		{
			// // Void Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::HGRenderPathScene::Dispose(
			//         HGRenderPathScene *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3062, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3062, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGRenderPathBase::Dispose((HGRenderPathBase *)this, renderGraph, 0LL);
			//   }
			// }
			// 
		}

		protected abstract void RenderScene(ref HGRenderPathBase.HGRenderPathParams renderPathParams);

		private void PrepareKeywords(ScriptableRenderContext srp, HGCamera camera, CommandBuffer cmd, HGRenderPipeline hgrp)
		{
			// // Void PrepareKeywords(ScriptableRenderContext, HGCamera, CommandBuffer, HGRenderPipeline)
			// void HG::Rendering::Runtime::HGRenderPathScene::PrepareKeywords(
			//         HGRenderPathScene *this,
			//         ScriptableRenderContext srp,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   ScriptableRenderContext P1; // [rsp+58h] [rbp+10h] BYREF
			// 
			//   P1.m_Ptr = srp.m_Ptr;
			//   if ( !byte_18D91965D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D91965D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3041, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     if ( camera && cmd )
			//     {
			//       UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//         cmd,
			//         &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_MVKeyword,
			//         1,
			//         0LL);
			//       UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//         cmd,
			//         &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_PerObjectMVKeyword,
			//         1,
			//         0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBufferNoCopy(&P1, cmd, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(Patch, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3041, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_481(
			//     Patch,
			//     (Object *)this,
			//     P1,
			//     (Object *)camera,
			//     (Object *)cmd,
			//     (Object *)hgrp,
			//     0LL);
			// }
			// 
		}

		private void PrepareData(ScriptableRenderContext srp, HGCamera camera, CommandBuffer cmd, HGRenderPipeline hgrp)
		{
			// // Void PrepareData(ScriptableRenderContext, HGCamera, CommandBuffer, HGRenderPipeline)
			// void HG::Rendering::Runtime::HGRenderPathScene::PrepareData(
			//         HGRenderPathScene *this,
			//         ScriptableRenderContext srp,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   SettingParameter_1_System_Boolean_ *transientGBuffer_k__BackingField; // rcx
			//   bool ssrEnable; // al
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91965E )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::Override);
			//     byte_18D91965E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3040, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGRenderPathScene::PrepareKeywords(this, srp, camera, cmd, hgrp, 0LL);
			//     if ( camera )
			//     {
			//       ssrEnable = HG::Rendering::Runtime::HGCamera::get_ssrEnable(camera, 0LL);
			//       if ( hgrp )
			//       {
			//         if ( !ssrEnable )
			//         {
			// LABEL_10:
			//           HG::Rendering::Runtime::HGRenderPipeline::PreparePCMultiscattering(hgrp, cmd, 0LL);
			//           return;
			//         }
			//         settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//         if ( settingParameters_k__BackingField )
			//         {
			//           transientGBuffer_k__BackingField = settingParameters_k__BackingField.fields._transientGBuffer_k__BackingField;
			//           if ( transientGBuffer_k__BackingField )
			//           {
			//             HG::Rendering::Runtime::SettingParameter<bool>::Override(
			//               transientGBuffer_k__BackingField,
			//               0,
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::Override);
			//             goto LABEL_10;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(transientGBuffer_k__BackingField, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3040, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_481(
			//     Patch,
			//     (Object *)this,
			//     srp,
			//     (Object *)camera,
			//     (Object *)cmd,
			//     (Object *)hgrp,
			//     0LL);
			// }
			// 
		}

		protected virtual void RenderPostProcessPhase1(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderPostProcessPhase1(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase1(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v3; // r13
			//   HGRenderPathScene *v4; // rdi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // r12
			//   HGRenderGraph *m_RenderGraph; // r14
			//   HGSettingParameters *settingParameters_k__BackingField; // rsi
			//   __int64 v10; // rdx
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   LightShaftApplyPassConstructor *v13; // rcx
			//   BOOL m_enableCompatibilityMode; // eax
			//   __int128 v15; // xmm1
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // rdx
			//   DepthOfFieldPassConstructor *v19; // rcx
			//   unsigned __int64 v20; // rdx
			//   TextureHandle v21; // xmm1
			//   TextureHandle v22; // xmm0
			//   TextureHandle v23; // xmm2
			//   unsigned __int64 v24; // r8
			//   signed __int64 v25; // rtt
			//   MotionBlurPassConstructor *v26; // rcx
			//   __int64 v27; // rdx
			//   HGCharacterVolume *handle; // rcx
			//   HGCamera *v29; // rax
			//   __int64 v30; // rax
			//   __int64 v31; // rax
			//   unsigned __int64 v32; // r8
			//   signed __int64 v33; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   __int64 v37; // [rsp+0h] [rbp-338h] BYREF
			//   LightShaftApplyPassConstructor_PassOutput output; // [rsp+30h] [rbp-308h] BYREF
			//   HGCamera *hgCamera; // [rsp+38h] [rbp-300h]
			//   LensFlarePassConstructor_PassInput v40; // [rsp+40h] [rbp-2F8h] BYREF
			//   HGRenderPipeline *v41; // [rsp+58h] [rbp-2E0h]
			//   HGRenderGraph *v42; // [rsp+60h] [rbp-2D8h]
			//   HGSettingParameters *v43; // [rsp+68h] [rbp-2D0h]
			//   ParafinPassConstructor_PassOutput v44; // [rsp+70h] [rbp-2C8h] BYREF
			//   __int128 v45; // [rsp+80h] [rbp-2B8h]
			//   uint32_t v46; // [rsp+90h] [rbp-2A8h]
			//   void *m_Ptr; // [rsp+98h] [rbp-2A0h]
			//   DepthOfFieldPassConstructor_PassInput input; // [rsp+A0h] [rbp-298h] BYREF
			//   MotionBlurPassConstructor_PassOutput v49; // [rsp+E0h] [rbp-258h] BYREF
			//   TextureHandle v50; // [rsp+F0h] [rbp-248h]
			//   TextureHandle v51; // [rsp+100h] [rbp-238h]
			//   TextureHandle v52; // [rsp+110h] [rbp-228h]
			//   HGSettingParameters *v53; // [rsp+120h] [rbp-218h] BYREF
			//   DepthOfFieldPassConstructor_PassOutput v54; // [rsp+128h] [rbp-210h] BYREF
			//   MotionBlurPassConstructor_PassInput v55; // [rsp+138h] [rbp-200h] BYREF
			//   Il2CppExceptionWrapper *v56; // [rsp+170h] [rbp-1C8h] BYREF
			//   Il2CppExceptionWrapper *v57; // [rsp+178h] [rbp-1C0h] BYREF
			//   Il2CppExceptionWrapper *v58; // [rsp+180h] [rbp-1B8h] BYREF
			//   Il2CppExceptionWrapper *v59; // [rsp+188h] [rbp-1B0h] BYREF
			//   TransparentAfterDOFPassConstructor_PassInput v60; // [rsp+190h] [rbp-1A8h] BYREF
			//   DepthOfFieldPassConstructor_PassInput v61; // [rsp+230h] [rbp-108h] BYREF
			//   TransparentAfterDOFPassConstructor_PassInput v62; // [rsp+270h] [rbp-C8h] BYREF
			//   char v65; // [rsp+358h] [rbp+20h] BYREF
			// 
			//   v3 = renderPathParams;
			//   v4 = this;
			//   if ( !byte_18D91965F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::HGDepthOfFieldQuality>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     byte_18D91965F = 1;
			//   }
			//   v65 = 0;
			//   sub_1802F01E0(&v61, 0LL, 64LL);
			//   v54 = 0LL;
			//   memset(&v55, 0, sizeof(v55));
			//   v49 = 0LL;
			//   sub_1802F01E0(&v62, 0LL, 160LL);
			//   sub_1802F01E0(&v60, 0LL, 160LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3043, 0LL) )
			//   {
			//     hgrp = v3.hgrp;
			//     v41 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v42 = m_RenderGraph;
			//     m_Ptr = v3.renderGraphParams.scriptableRenderContext.m_Ptr;
			//     settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//     v43 = settingParameters_k__BackingField;
			//     hgCamera = v3.renderRequest.hgCamera;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x2Bu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v40.sceneColor.handle = 0LL;
			//     v40.sceneColor.fallBackResource = (ResourceHandle)&v65;
			//     try
			//     {
			//       v44 = 0LL;
			//       v45 = 0LL;
			//       v46 = 0;
			//       v11 = *(_OWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       v12 = *(_OWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m10;
			//       LOBYTE(v46) = LOBYTE(v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11);
			//       *(_OWORD *)&input.quality = v11;
			//       *(_OWORD *)&input.motionVectorTexture.fallBackResource.m_Value = v12;
			//       input.sceneColor.fallBackResource.m_Value = (unsigned __int8)v46;
			//       output = 0;
			//       v13 = *(LightShaftApplyPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m00;
			//       if ( !v13 )
			//         sub_1802DC2C8(0LL, v10);
			//       HG::Rendering::Runtime::LightShaftApplyPassConstructor::ConstructPass(
			//         v13,
			//         (LightShaftApplyPassConstructor_PassInput *)&input,
			//         &output,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v56 )
			//     {
			//       v40.sceneColor.handle = (ResourceHandle)v56.ex;
			//       if ( v40.sceneColor.handle )
			//         sub_18000F780(*(_QWORD *)&v40.sceneColor.handle);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v41;
			//       m_RenderGraph = v42;
			//       settingParameters_k__BackingField = v43;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x2Du,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v40.sceneColor.handle = 0LL;
			//     v40.sceneColor.fallBackResource = (ResourceHandle)&v65;
			//     try
			//     {
			//       v44 = 0LL;
			//       v45 = 0LL;
			//       v46 = 0;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//       if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         m_enableCompatibilityMode = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_enableCompatibilityMode;
			//       }
			//       else
			//       {
			//         m_enableCompatibilityMode = 0;
			//       }
			//       LOBYTE(v46) = m_enableCompatibilityMode;
			//       v15 = *(_OWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       *(_OWORD *)&input.quality = *(_OWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       *(_OWORD *)&input.motionVectorTexture.fallBackResource.m_Value = v15;
			//       input.sceneColor.fallBackResource.m_Value = v46;
			//       v44 = 0LL;
			//       if ( *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20 )
			//       {
			//         HG::Rendering::Runtime::ParafinPassConstructor::ConstructPass(
			//           *(ParafinPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m20,
			//           (ParafinPassConstructor_PassInput *)&input,
			//           &v44,
			//           m_RenderGraph,
			//           *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//           0LL);
			//         *(ParafinPassConstructor_PassOutput *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = v44;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v57 )
			//     {
			//       v40.sceneColor.handle = (ResourceHandle)v57.ex;
			//       if ( v40.sceneColor.handle )
			//         sub_18000F780(*(_QWORD *)&v40.sceneColor.handle);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v41;
			//       m_RenderGraph = v42;
			//       settingParameters_k__BackingField = v43;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x2Eu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v40.sceneColor.handle = 0LL;
			//     v40.sceneColor.fallBackResource = (ResourceHandle)&v65;
			//     try
			//     {
			//       sub_1802F01E0(&input, 0LL, 64LL);
			//       if ( !settingParameters_k__BackingField )
			//         sub_1802DC2C8(v17, v16);
			//       input.quality = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                         (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._depthOfFieldQuality_k__BackingField,
			//                         MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::HGDepthOfFieldQuality>::op_Implicit);
			//       input.depthOfFieldMaxRadius = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                       settingParameters_k__BackingField.fields._depthOfFieldMaxRadius_k__BackingField,
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       input.sceneColor = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       input.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       input.motionVectorTexture = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       input.renderContext.m_Ptr = m_Ptr;
			//       v61 = input;
			//       v19 = *(DepthOfFieldPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m01;
			//       if ( !v19 )
			//         sub_1802DC2C8(0LL, v18);
			//       HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructPass(
			//         v19,
			//         &v61,
			//         &v54,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         0LL);
			//       *(DepthOfFieldPassConstructor_PassOutput *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = v54;
			//     }
			//     catch ( Il2CppExceptionWrapper *v58 )
			//     {
			//       v40.sceneColor.handle = (ResourceHandle)v58.ex;
			//       if ( v40.sceneColor.handle )
			//         sub_18000F780(*(_QWORD *)&v40.sceneColor.handle);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v41;
			//       m_RenderGraph = v42;
			//       settingParameters_k__BackingField = v43;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x2Fu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v40.sceneColor.handle = 0LL;
			//     v40.sceneColor.fallBackResource = (ResourceHandle)&v65;
			//     try
			//     {
			//       v21 = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       v50 = v21;
			//       v22 = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       v51 = v22;
			//       v23 = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       v52 = v23;
			//       v53 = settingParameters_k__BackingField;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v24 = (((unsigned __int64)&v53 >> 12) & 0x1FFFFF) >> 6;
			//         v20 = ((unsigned __int64)&v53 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//         do
			//           v25 = qword_18D6405E0[v24 + 36190];
			//         while ( v25 != _InterlockedCompareExchange64(&qword_18D6405E0[v24 + 36190], v25 | (1LL << v20), v25) );
			//         v23 = v52;
			//         v22 = v51;
			//         v21 = v50;
			//       }
			//       v55.sceneColor = v21;
			//       v55.sceneDepth = v22;
			//       v55.sceneMV = v23;
			//       v55.settingParameters = v53;
			//       v49 = 0LL;
			//       v26 = *(MotionBlurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m21;
			//       if ( !v26 )
			//         sub_1802DC2C8(0LL, v20);
			//       HG::Rendering::Runtime::MotionBlurPassConstructor::ConstructPass(
			//         v26,
			//         &v55,
			//         &v49,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         0LL);
			//       *(MotionBlurPassConstructor_PassOutput *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = v49;
			//     }
			//     catch ( Il2CppExceptionWrapper *v59 )
			//     {
			//       v27 = (__int64)&v37;
			//       v40.sceneColor.handle = (ResourceHandle)v59.ex;
			//       handle = (HGCharacterVolume *)v40.sceneColor.handle;
			//       if ( v40.sceneColor.handle )
			//         sub_18000F780(*(_QWORD *)&v40.sceneColor.handle);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v41;
			//       m_RenderGraph = v42;
			//       settingParameters_k__BackingField = v43;
			//       v29 = hgCamera;
			// LABEL_34:
			//       if ( !v29 )
			//         goto LABEL_60;
			//       if ( HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(v29, 0LL) )
			//       {
			//         sub_1802F01E0(&v60, 0LL, 160LL);
			//         v30 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//         if ( !v30 )
			//           goto LABEL_60;
			//         v31 = *(_QWORD *)(v30 + 2504);
			//         if ( !v31 )
			//           goto LABEL_60;
			//         handle = *(HGCharacterVolume **)(v31 + 104);
			//         if ( !handle )
			//           goto LABEL_60;
			//         v60.characterOutlineEnabled = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
			//                                         handle,
			//                                         0LL);
			//         v60.forwardTransparentAfterDOFECSList = LODWORD(v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21);
			//         v60.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//         v60.screenCullingRatio = hgCamera.fields.screenCullingRatio;
			//         v60.screenCullingRatioDistance = hgCamera.fields.screenRatioCullingDistance;
			//         v60.bakedLightConfig = hgrp.fields.m_CurrentRendererConfigurationBakedLighting;
			//         v60.shadowResult = *(ShadowResult *)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m20;
			//         v60.cullingResults = v3.renderRequest.cullingResults.cullingResults;
			//         v60.sceneColor = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//         v60.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//         v60.sceneMV = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//         v60.hgrp = hgrp;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v32 = (((unsigned __int64)&v60.hgrp >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v32 + 36190]);
			//           do
			//             v33 = qword_18D6405E0[v32 + 36190];
			//           while ( v33 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v32 + 36190],
			//                            v33 | (1LL << (((unsigned __int64)&v60.hgrp >> 12) & 0x3F)),
			//                            v33) );
			//         }
			//         v62 = v60;
			//         v27 = 128LL;
			//         v44 = 0LL;
			//         handle = *(HGCharacterVolume **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m02;
			//         if ( !handle )
			//           goto LABEL_60;
			//         HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::ConstructPass(
			//           (TransparentAfterDOFPassConstructor *)handle,
			//           &v62,
			//           (TransparentAfterDOFPassConstructor_PassOutput *)&v44,
			//           m_RenderGraph,
			//           *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//           0LL);
			//         *(ParafinPassConstructor_PassOutput *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = v44;
			//       }
			//       if ( settingParameters_k__BackingField )
			//       {
			//         if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                 settingParameters_k__BackingField.fields._lensFlareEnabled_k__BackingField,
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//           return;
			//         *(_QWORD *)&v45 = 0LL;
			//         v40.sceneColor = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//         v40.debugFullscreenBuffer = 0LL;
			//         output = 0;
			//         handle = *(HGCharacterVolume **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m23;
			//         if ( handle )
			//         {
			//           HG::Rendering::Runtime::LensFlarePassConstructor::ConstructPass(
			//             (LensFlarePassConstructor *)handle,
			//             &v40,
			//             (LensFlarePassConstructor_PassOutput *)&output,
			//             m_RenderGraph,
			//             *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//             0LL);
			//           return;
			//         }
			//       }
			// LABEL_60:
			//       sub_1802DC2C8(handle, v27);
			//     }
			//     v29 = hgCamera;
			//     goto LABEL_34;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3043, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v36, v35);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v4, v3, 0LL);
			// }
			// 
		}

		protected virtual void RenderPostProcessPhase2(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderPostProcessPhase2(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase2(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v3; // rdi
			//   HGRenderPathScene *v4; // r14
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // r15
			//   HGRenderGraph *m_RenderGraph; // r12
			//   HGSettingParameters *P5; // r13
			//   CullingResults cullingResults; // xmm13
			//   HGCamera *v11; // rbx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   float RenderingScale; // xmm6_4
			//   __int64 v15; // rbx
			//   Object_1 *v16; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // rbx
			//   __int64 v20; // rbx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   Vector2Int *v23; // rax
			//   Vector2Int *v24; // rax
			//   HGCamera *v25; // rbx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   __int64 v30; // rax
			//   __int64 v31; // rbx
			//   Object_1 *v32; // rbx
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rax
			//   __int64 v36; // rbx
			//   __int64 v37; // rcx
			//   __int64 v38; // rax
			//   __int64 v39; // rcx
			//   float v40; // xmm0_4
			//   TAAUPassConstructor *v41; // rcx
			//   __int128 v42; // xmm6
			//   HGCamera *v43; // rbx
			//   unsigned __int64 v44; // rdx
			//   signed __int64 v45; // rcx
			//   Rect v46; // xmm12
			//   unsigned __int64 v47; // r8
			//   signed __int64 v48; // rtt
			//   __int64 v49; // rdx
			//   bool v50; // al
			//   __int64 v51; // rcx
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   __int64 v56; // rbx
			//   __int64 v57; // rdi
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   _QWORD *v60; // rdx
			//   int v61; // ecx
			//   unsigned __int64 v62; // r9
			//   signed __int64 v63; // rtt
			//   unsigned __int64 v64; // r9
			//   signed __int64 v65; // rtt
			//   unsigned __int64 v66; // r9
			//   signed __int64 v67; // rtt
			//   unsigned __int64 v68; // r9
			//   signed __int64 v69; // rtt
			//   unsigned __int64 v70; // r9
			//   signed __int64 v71; // rtt
			//   unsigned __int64 v72; // r9
			//   signed __int64 v73; // rtt
			//   unsigned __int64 v74; // r9
			//   signed __int64 v75; // rtt
			//   unsigned __int64 v76; // r9
			//   signed __int64 v77; // rtt
			//   unsigned __int64 v78; // r8
			//   signed __int64 v79; // rtt
			//   TextureHandle sceneColor; // xmm6
			//   __int64 v81; // rdx
			//   HGSharpen *v82; // rcx
			//   __int64 v83; // rdx
			//   HGFisheyeEffect *v84; // rcx
			//   TextureHandle sceneDepth; // xmm7
			//   bool v86; // al
			//   TextureHandle v87; // xmm10
			//   TextureHandle sceneMV; // xmm8
			//   TextureHandle v89; // xmm11
			//   int32_t v90; // r8d
			//   TextureHandle v91; // xmm9
			//   TextureHandle target; // xmm8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v94; // rdx
			//   __int64 v95; // rcx
			//   TextureHandle frostedGlassRT; // xmm6
			//   HGCamera *v97; // rbx
			//   __int64 *v98; // rdx
			//   HGCamera *v99; // rcx
			//   bool enableMetalFXSpatialScaler; // di
			//   HGCamera *v101; // rbx
			//   char v102; // al
			//   HGCamera *v103; // rbx
			//   bool v104; // al
			//   char v105; // bl
			//   TextureHandle v106; // xmm7
			//   TextureHandle v107; // xmm6
			//   unsigned __int64 v108; // r8
			//   signed __int64 v109; // rtt
			//   __int64 v110; // rdx
			//   __int64 v111; // rcx
			//   __int64 v112; // rdx
			//   UIPassConstructor *v113; // rcx
			//   __int64 v114; // rdx
			//   __int64 v115; // rcx
			//   ComposablePass *v116; // rcx
			//   __int64 v117; // rax
			//   TextureHandle v118; // xmm6
			//   unsigned __int64 v119; // r9
			//   signed __int64 v120; // rtt
			//   __int64 v121; // rdx
			//   MultiblurPassConstructor *v122; // rcx
			//   TextureHandle backBufferColor_k__BackingField; // xmm7
			//   unsigned __int64 v124; // rdx
			//   TextureHandle v125; // xmm6
			//   TextureHandle v126; // xmm0
			//   unsigned __int64 v127; // r8
			//   signed __int64 v128; // rtt
			//   ScreenSpaceOverlayPassConstructor *v129; // rcx
			//   IPassConstructor *PassConstructor; // rbx
			//   ComposablePass *v131; // rdi
			//   __int64 v132; // rdx
			//   __int64 v133; // rcx
			//   ComposablePass *v134; // rax
			//   HGCamera *v135; // rbx
			//   TextureHandle v136; // xmm7
			//   ILFixDynamicMethodWrapper_2 *v137; // rax
			//   __int64 v138; // rdx
			//   __int64 v139; // rcx
			//   __int64 v140; // [rsp+0h] [rbp-5E8h] BYREF
			//   _BYTE v141[16]; // [rsp+70h] [rbp-578h] BYREF
			//   TextureHandle v142; // [rsp+80h] [rbp-568h] BYREF
			//   TextureHandle v143[2]; // [rsp+90h] [rbp-558h] BYREF
			//   TextureHandle v144; // [rsp+B0h] [rbp-538h] BYREF
			//   HGRenderPipeline *v145; // [rsp+C0h] [rbp-528h]
			//   HGFisheyeEffect *v146; // [rsp+C8h] [rbp-520h]
			//   TextureHandle v147; // [rsp+D0h] [rbp-518h] BYREF
			//   HGCamera *hgCamera; // [rsp+E0h] [rbp-508h]
			//   TAAUPassConstructor_PassOutput output; // [rsp+E8h] [rbp-500h] BYREF
			//   Rect v150; // [rsp+100h] [rbp-4E8h] BYREF
			//   HGRenderGraph *v151; // [rsp+110h] [rbp-4D8h]
			//   HGSettingParameters *settingParameters_k__BackingField; // [rsp+118h] [rbp-4D0h]
			//   _QWORD v153[9]; // [rsp+120h] [rbp-4C8h] BYREF
			//   TextureHandle v154; // [rsp+168h] [rbp-480h]
			//   HGCamera *v155; // [rsp+178h] [rbp-470h] BYREF
			//   PostProcessPassConstructor_PassOutput P2; // [rsp+180h] [rbp-468h] BYREF
			//   UIPassConstructor_PassInput v157; // [rsp+1A0h] [rbp-448h] BYREF
			//   ScreenSpaceOverlayPassConstructor_PassInput v158; // [rsp+1F0h] [rbp-3F8h] BYREF
			//   PostProcessPassConstructor_PassInput v159; // [rsp+210h] [rbp-3D8h] BYREF
			//   CullingResults v160; // [rsp+290h] [rbp-358h]
			//   TAAUPassConstructor_PassInput v161; // [rsp+2A0h] [rbp-348h] BYREF
			//   MultiblurPassConstructor_PassInput v162; // [rsp+350h] [rbp-298h] BYREF
			//   PostProcessPassConstructor_PassInput P1; // [rsp+390h] [rbp-258h] BYREF
			//   Il2CppExceptionWrapper *v164; // [rsp+410h] [rbp-1D8h] BYREF
			//   Il2CppExceptionWrapper *v165; // [rsp+418h] [rbp-1D0h] BYREF
			//   Il2CppExceptionWrapper *v166; // [rsp+420h] [rbp-1C8h] BYREF
			//   UIPassConstructor_PassInput v167; // [rsp+430h] [rbp-1B8h] BYREF
			//   TAAUPassConstructor_PassInput input; // [rsp+480h] [rbp-168h] BYREF
			//   Material *v171; // [rsp+608h] [rbp+20h] BYREF
			// 
			//   v3 = renderPathParams;
			//   v4 = this;
			//   if ( !byte_18D919660 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ComposablePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D919660 = 1;
			//   }
			//   v150 = 0LL;
			//   v141[0] = 0;
			//   sub_1802F01E0(&input, 0LL, 164LL);
			//   sub_1802F01E0(&P1, 0LL, 128LL);
			//   memset(&P2, 0, sizeof(P2));
			//   sub_1802F01E0(&v159, 0LL, 128LL);
			//   sub_1802F01E0(&v167, 0LL, 80LL);
			//   sub_1802F01E0(&v157, 0LL, 80LL);
			//   memset(&v162, 0, sizeof(v162));
			//   memset(&v153[2], 0, 56);
			//   memset(&v158, 0, sizeof(v158));
			//   v154 = 0LL;
			//   v155 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3047, 0LL) )
			//   {
			//     hgrp = v3.hgrp;
			//     v145 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v151 = m_RenderGraph;
			//     if ( !m_RenderGraph )
			//       sub_180B536AC(v6, v5);
			//     if ( !m_RenderGraph.fields.m_RenderGraphContext )
			//       sub_180B536AC(v6, v5);
			//     settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//     P5 = settingParameters_k__BackingField;
			//     cullingResults = v3.renderRequest.cullingResults.cullingResults;
			//     v160 = cullingResults;
			//     hgCamera = v3.renderRequest.hgCamera;
			//     v11 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     RenderingScale = HG::Rendering::Runtime::HGUtils::GetRenderingScale(v11, settingParameters_k__BackingField, 0LL);
			//     v15 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     if ( !v15 )
			//       sub_180B536AC(v13, v12);
			//     v16 = *(Object_1 **)(v15 + 2752);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(v16, 0LL) )
			//     {
			//       v19 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       if ( !v19 )
			//         sub_180B536AC(v18, v17);
			//       v20 = *(_QWORD *)(v19 + 2752);
			//       if ( !v20 )
			//         sub_180B536AC(v18, v17);
			//       *(_DWORD *)(v20 + 160) = 0;
			//     }
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x31u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     v143[0].handle = 0LL;
			//     v143[0].fallBackResource = (ResourceHandle)v141;
			//     try
			//     {
			//       sub_1802F01E0(&v161, 0LL, 164LL);
			//       v161.sceneColor = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       v161.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       v161.utilityDepth = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m02;
			//       v161.sceneMV = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       v161.historySceneColor = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m23;
			//       v23 = *(Vector2Int **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       if ( !v23 )
			//         sub_1802DC2C8(v22, v21);
			//       v161.screenSize = v23[3];
			//       v24 = *(Vector2Int **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       if ( !v24 )
			//         sub_1802DC2C8(v22, v21);
			//       v161.renderSize = v24[6];
			//       v25 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v161.renderingScale = HG::Rendering::Runtime::HGUtils::GetRenderingScale(v25, P5, 0LL);
			//       if ( !P5 )
			//         sub_1802DC2C8(v27, v26);
			//       v161.historyWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                              P5.fields._historyWeight_k__BackingField,
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.historyWeightInMotion = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                      P5.fields._historyWeightInMotion_k__BackingField,
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.fastConvergeHistoryWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                          P5.fields._fastConvergeHistoryWeight_k__BackingField,
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.responsiveAAHistoryWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                          P5.fields._responsiveAAWeight_k__BackingField,
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.minMVConsideredDynamic = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                       P5.fields._minMotion_k__BackingField,
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.maxMVConsideredDynamic = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                       P5.fields._maxMotion_k__BackingField,
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.characterMotionSensitivity = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                           P5.fields._characterMotionSensitivity_k__BackingField,
			//                                           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.occlusionDepthDiff = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                   P5.fields._occlusionDepthDiff_k__BackingField,
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.inputSampleLumaWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                      P5.fields._inputLumaWeight_k__BackingField,
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.sharpenStrength1K = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                  P5.fields._sharpenStrength1K_k__BackingField,
			//                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.sharpenStrength2K = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                  P5.fields._sharpenStrength2K_k__BackingField,
			//                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.sharpenStrength4K = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                  P5.fields._sharpenStrength4K_k__BackingField,
			//                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v161.quality = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                        (SettingParameter_1_System_Int32Enum_ *)P5.fields._taauQuality_k__BackingField,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
			//       v30 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       if ( !v30 )
			//         sub_1802DC2C8(v29, v28);
			//       v161.enableTAAU = (*(_BYTE *)(v30 + 2412) & 2) != 0;
			//       v161.enableResponsiveTransparency = hgrp.fields._enableResponsiveTransparency_k__BackingField;
			//       v161.fastConvergeState = hgrp.fields._fastConvergeState_k__BackingField;
			//       v161.renderPathFrameIndex = v4.fields._._renderPathFrameIndex_k__BackingField;
			//       input = v161;
			//       output = 0LL;
			//       v31 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       if ( !v31 )
			//         sub_1802DC2C8(&input.occlusionDepthDiff, 128LL);
			//       v32 = *(Object_1 **)(v31 + 2752);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Implicit(v32, 0LL) )
			//       {
			//         v35 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//         if ( !v35 )
			//           sub_1802DC2C8(v34, v33);
			//         if ( (*(_BYTE *)(v35 + 2412) & 2) != 0 )
			//         {
			//           v36 = *(_QWORD *)(v35 + 2752);
			//           sub_182376F20();
			//           v38 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//           if ( !v38 )
			//             sub_1802DC2C8(v37, v33);
			//           v39 = *(_QWORD *)(v38 + 2752);
			//           if ( !v39 )
			//             sub_1802DC2C8(0LL, v33);
			//           v40 = RenderingScale - 1.0;
			//           if ( *(float *)(v39 + 160) <= (float)(RenderingScale - 1.0) )
			//             v40 = *(float *)(v39 + 160);
			//           if ( !v36 )
			//             sub_1802DC2C8(v39, v33);
			//           *(float *)(v36 + 160) = v40;
			//         }
			//       }
			//       v41 = *(TAAUPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewNoTransProjMatrix.m22;
			//       if ( !v41 )
			//         sub_1802DC2C8(0LL, v33);
			//       HG::Rendering::Runtime::TAAUPassConstructor::ConstructPass(
			//         v41,
			//         &input,
			//         &output,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         0LL);
			//       *(TAAUPassConstructor_PassOutput *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03 = output;
			//       hgrp.fields._fastConvergeState_k__BackingField = 0;
			//     }
			//     catch ( Il2CppExceptionWrapper *v164 )
			//     {
			//       v143[0].handle = (ResourceHandle)v164.ex;
			//       if ( v143[0].handle )
			//         sub_18000F780(*(_QWORD *)&v143[0].handle);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v145;
			//       m_RenderGraph = v151;
			//       P5 = settingParameters_k__BackingField;
			//       cullingResults = v160;
			//     }
			//     v42 = *(_OWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//     v43 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     *(_OWORD *)v153 = v42;
			//     HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//       RTExtractionType__Enum_SceneColorLS,
			//       (TextureHandle *)v153,
			//       v43,
			//       m_RenderGraph,
			//       0LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x34u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     output.currentSceneColor.handle = 0LL;
			//     output.currentSceneColor.fallBackResource = (ResourceHandle)v141;
			//     try
			//     {
			//       v46 = (Rect)*HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                      &v142,
			//                      (HGRenderPathBase *)v4,
			//                      PassConstructorID__Enum_UberPost,
			//                      0LL);
			//       v150 = v46;
			//       v159.sceneColor = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m03;
			//       v159.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       v159.sceneMV = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m01;
			//       v159.target = (TextureHandle)v46;
			//       v159.hgrp = hgrp;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v47 = (((unsigned __int64)&v159.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         v44 = ((unsigned __int64)&v159.hgrp >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v47 + 36190]);
			//         do
			//         {
			//           v45 = qword_18D6405E0[v47 + 36190] | (1LL << v44);
			//           v48 = qword_18D6405E0[v47 + 36190];
			//         }
			//         while ( v48 != _InterlockedCompareExchange64(&qword_18D6405E0[v47 + 36190], v45, v48) );
			//       }
			//       v159.cullingResults = cullingResults;
			//       if ( !P5 )
			//         sub_1802DC2C8(v45, v44);
			//       v159.taauQuality = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                            (SettingParameter_1_System_Int32Enum_ *)P5.fields._taauQuality_k__BackingField,
			//                            MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
			//       v159.depthBits = v3.perFrameSetup.depthBits;
			//       v159.depthFormat = v3.perFrameSetup.depthGraphicsFormat;
			//       v159.renderPath = v4.fields._._renderPath_k__BackingField;
			//       if ( *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 )
			//       {
			//         v51 = *(_QWORD *)(*(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03
			//                         + 2752LL);
			//         if ( !v51 )
			//           sub_1802DC2C8(0LL, v49);
			//         v50 = *(_DWORD *)(v51 + 76) == 2;
			//       }
			//       else
			//       {
			//         v50 = 0;
			//       }
			//       v159.render3DUI = v50;
			//       v159.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v145, 0LL);
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v53, v52);
			//       *(_QWORD *)&v159.screenCullingRatio = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//       v159.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//       P1 = v159;
			//       memset(&P2, 0, sizeof(P2));
			//       v56 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m00;
			//       v57 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       if ( !v56 )
			//         sub_1802DC2C8(v55, v54);
			//       if ( !byte_18D9194EE )
			//       {
			//         sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         byte_18D9194EE = 1;
			//       }
			//       *(_OWORD *)v153 = 0LL;
			//       if ( IFix::WrappersManagerImpl::IsPatched(2462, 0LL) )
			//       {
			//         Patch = IFix::WrappersManagerImpl::GetPatch(2462, 0LL);
			//         if ( !Patch )
			//           sub_1802DC2C8(v95, v94);
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_906(
			//           Patch,
			//           (Object *)v56,
			//           &P1,
			//           &P2,
			//           (Object *)m_RenderGraph,
			//           (Object *)v57,
			//           (Object *)P5,
			//           0LL);
			//       }
			//       else
			//       {
			//         if ( !v57 )
			//           sub_1802DC2C8(v59, v58);
			//         v60 = *(_QWORD **)(v57 + 2504);
			//         if ( !v60 )
			//           sub_1802DC2C8(v59, 0LL);
			//         *(_QWORD *)(v56 + 536) = v60[2];
			//         v61 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v62 = (((unsigned __int64)(v56 + 536) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v62 + 36190]);
			//           do
			//             v63 = qword_18D6405E0[v62 + 36190];
			//           while ( v63 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v62 + 36190],
			//                            v63 | (1LL << (((unsigned __int64)(v56 + 536) >> 12) & 0x3F)),
			//                            v63) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 544) = v60[3];
			//         if ( v61 )
			//         {
			//           v64 = (((unsigned __int64)(v56 + 544) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v64 + 36190]);
			//           do
			//             v65 = qword_18D6405E0[v64 + 36190];
			//           while ( v65 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v64 + 36190],
			//                            v65 | (1LL << (((unsigned __int64)(v56 + 544) >> 12) & 0x3F)),
			//                            v65) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 552) = v60[4];
			//         if ( v61 )
			//         {
			//           v66 = (((unsigned __int64)(v56 + 552) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v66 + 36190]);
			//           do
			//             v67 = qword_18D6405E0[v66 + 36190];
			//           while ( v67 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v66 + 36190],
			//                            v67 | (1LL << (((unsigned __int64)(v56 + 552) >> 12) & 0x3F)),
			//                            v67) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 560) = v60[5];
			//         if ( v61 )
			//         {
			//           v68 = (((unsigned __int64)(v56 + 560) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v68 + 36190]);
			//           do
			//             v69 = qword_18D6405E0[v68 + 36190];
			//           while ( v69 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v68 + 36190],
			//                            v69 | (1LL << (((unsigned __int64)(v56 + 560) >> 12) & 0x3F)),
			//                            v69) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 568) = v60[6];
			//         if ( v61 )
			//         {
			//           v70 = (((unsigned __int64)(v56 + 568) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v70 + 36190]);
			//           do
			//             v71 = qword_18D6405E0[v70 + 36190];
			//           while ( v71 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v70 + 36190],
			//                            v71 | (1LL << (((unsigned __int64)(v56 + 568) >> 12) & 0x3F)),
			//                            v71) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 576) = v60[7];
			//         if ( v61 )
			//         {
			//           v72 = (((unsigned __int64)(v56 + 576) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v72 + 36190]);
			//           do
			//             v73 = qword_18D6405E0[v72 + 36190];
			//           while ( v73 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v72 + 36190],
			//                            v73 | (1LL << (((unsigned __int64)(v56 + 576) >> 12) & 0x3F)),
			//                            v73) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 584) = v60[8];
			//         if ( v61 )
			//         {
			//           v74 = (((unsigned __int64)(v56 + 584) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v74 + 36190]);
			//           do
			//             v75 = qword_18D6405E0[v74 + 36190];
			//           while ( v75 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v74 + 36190],
			//                            v75 | (1LL << (((unsigned __int64)(v56 + 584) >> 12) & 0x3F)),
			//                            v75) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 592) = v60[9];
			//         if ( v61 )
			//         {
			//           v76 = (((unsigned __int64)(v56 + 592) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v76 + 36190]);
			//           do
			//             v77 = qword_18D6405E0[v76 + 36190];
			//           while ( v77 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v76 + 36190],
			//                            v77 | (1LL << (((unsigned __int64)(v56 + 592) >> 12) & 0x3F)),
			//                            v77) );
			//           v61 = dword_18D8E43F8;
			//         }
			//         *(_QWORD *)(v56 + 600) = v60[10];
			//         if ( v61 )
			//         {
			//           v78 = (((unsigned __int64)(v56 + 600) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v78 + 36190]);
			//           do
			//             v79 = qword_18D6405E0[v78 + 36190];
			//           while ( v79 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v78 + 36190],
			//                            v79 | (1LL << (((unsigned __int64)(v56 + 600) >> 12) & 0x3F)),
			//                            v79) );
			//         }
			//         *(_BYTE *)(v56 + 610) = P1.render3DUI;
			//         sceneColor = P1.sceneColor;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//         if ( HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess((HGCamera *)v57, 0LL) )
			//         {
			//           v82 = *(HGSharpen **)(v56 + 568);
			//           if ( !v82 )
			//             sub_1802DC2C8(0LL, v81);
			//           if ( HG::Rendering::Runtime::HGSharpen::IsActive(v82, 0LL)
			//             && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                  P5.fields._sharpenEnabled_k__BackingField,
			//                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//           {
			//             v147.handle = *(ResourceHandle *)(v56 + 568);
			//             v171 = *(Material **)(v56 + 56);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//             v143[0] = sceneColor;
			//             sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::SharpenPass(
			//                             &v142,
			//                             m_RenderGraph,
			//                             (HGCamera *)v57,
			//                             v143,
			//                             *(HGSharpen **)&v147.handle,
			//                             v171,
			//                             0LL);
			//           }
			//           v84 = *(HGFisheyeEffect **)(v56 + 592);
			//           if ( !v84 )
			//             sub_1802DC2C8(0LL, v83);
			//           if ( HG::Rendering::Runtime::HGFisheyeEffect::IsActive(v84, 0LL) )
			//           {
			//             v86 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                     P5.fields._fisheyeEffectEnabled_k__BackingField,
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//             sceneDepth = P1.sceneDepth;
			//             if ( v86 )
			//             {
			//               v146 = *(HGFisheyeEffect **)(v56 + 592);
			//               v147.handle = *(ResourceHandle *)(v56 + 32);
			//               v171 = *(Material **)(v56 + 40);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//               v143[0] = sceneDepth;
			//               v144 = sceneColor;
			//               sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectPass(
			//                               &v142,
			//                               P5,
			//                               m_RenderGraph,
			//                               (HGCamera *)v57,
			//                               v146,
			//                               *(Material **)&v147.handle,
			//                               v171,
			//                               &v144,
			//                               v143,
			//                               (TextureHandle *)v153,
			//                               0LL);
			//               sceneDepth = *(TextureHandle *)v153;
			//             }
			//           }
			//           else
			//           {
			//             sceneDepth = P1.sceneDepth;
			//           }
			//           LODWORD(v146) = *(_DWORD *)(v56 + 528);
			//           LODWORD(v171) = *(_DWORD *)(v56 + 532);
			//           v147.handle = *(ResourceHandle *)(v56 + 48);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//           v87 = *HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPass(
			//                    &v142,
			//                    m_RenderGraph,
			//                    (HGCamera *)v57,
			//                    (int32_t)v146,
			//                    (GraphicsFormat__Enum)v171,
			//                    *(Material **)&v147.handle,
			//                    (UberPostPassUtils_CachedColorGradingData *)(v56 + 160),
			//                    (RTHandle **)(v56 + 152),
			//                    0LL);
			//           if ( *(_BYTE *)(v56 + 608) )
			//             LODWORD(v171) = 1;
			//           else
			//             LODWORD(v171) = *(unsigned __int8 *)(v56 + 610);
			//           v143[0].handle = *(ResourceHandle *)(v56 + 536);
			//           sceneMV = P1.sceneMV;
			//           v147.handle.m_Value = P1.taauQuality;
			//           LODWORD(v146) = P1.renderPath;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//           v144 = sceneMV;
			//           v142 = sceneColor;
			//           v89 = *HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
			//                    v143,
			//                    m_RenderGraph,
			//                    (HGCamera *)v57,
			//                    P5,
			//                    *(Bloom **)&v143[0].handle,
			//                    (_DWORD)v171 != 0,
			//                    &v142,
			//                    &v144,
			//                    (TAAUQuality__Enum)v147.handle.m_Value,
			//                    (HGRenderPathInternal__Enum)v146,
			//                    (UberPostPassUtils_BloomPSMaterials *)(v56 + 120),
			//                    (Vector4 *)(v56 + 104),
			//                    0LL);
			//           v90 = *(_DWORD *)(v56 + 528);
			//           v142 = v87;
			//           v144 = sceneColor;
			//           v91 = *HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPass(
			//                    v143,
			//                    m_RenderGraph,
			//                    (HGCamera *)v57,
			//                    P5,
			//                    &v144,
			//                    &v142,
			//                    v90,
			//                    (UberPostPassUtils_FrostedGlassPSMaterials *)(v56 + 88),
			//                    (RTHandle__Array **)(v56 + 72),
			//                    (Vector2Int__Array **)(v56 + 80),
			//                    0LL);
			//           v142 = sceneColor;
			//           HG::Rendering::Runtime::UberPostPassUtils::ExecuteAutoExposure(m_RenderGraph, &v142, (HGCamera *)v57, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//           if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//             if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_enableCompatibilityMode )
			//             {
			//               target = P1.target;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//               v142 = sceneColor;
			//               v144 = sceneDepth;
			//               v143[0] = target;
			//               sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectPass(
			//                               &v147,
			//                               P5,
			//                               m_RenderGraph,
			//                               (HGCamera *)v57,
			//                               v143,
			//                               &v144,
			//                               &v142,
			//                               0LL);
			//             }
			//           }
			//           v142 = v89;
			//           v144 = v87;
			//           v143[0] = sceneColor;
			//           HG::Rendering::Runtime::PostProcessPassConstructor::UberPass(
			//             &v147,
			//             (PostProcessPassConstructor *)v56,
			//             &P1,
			//             P5,
			//             m_RenderGraph,
			//             (HGCamera *)v57,
			//             v143,
			//             &v144,
			//             &v142,
			//             0LL);
			//           *(_BYTE *)(v57 + 2458) = *(_BYTE *)(v57 + 2457);
			//           *(_BYTE *)(v57 + 2457) = 0;
			//           P2.frostedGlassRT = v91;
			//         }
			//         else
			//         {
			//           v143[0] = sceneColor;
			//           v147 = P1.target;
			//           HG::Rendering::Runtime::PostProcessPassConstructor::FinalPass(
			//             (PostProcessPassConstructor *)v56,
			//             m_RenderGraph,
			//             (HGCamera *)v57,
			//             &v147,
			//             v143,
			//             0LL);
			//         }
			//       }
			//       frostedGlassRT = P2.frostedGlassRT;
			//       v97 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v142 = frostedGlassRT;
			//       HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//         RTExtractionType__Enum_BlurredSceneColorPS,
			//         &v142,
			//         v97,
			//         m_RenderGraph,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v165 )
			//     {
			//       v98 = &v140;
			//       output.currentSceneColor.handle = (ResourceHandle)v165.ex;
			//       if ( output.currentSceneColor.handle )
			//         sub_18000F780(*(_QWORD *)&output.currentSceneColor.handle);
			//       v4 = this;
			//       m_RenderGraph = v151;
			//       P5 = settingParameters_k__BackingField;
			//       cullingResults = v160;
			//       v46 = v150;
			//     }
			//     v99 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     if ( !v99 )
			//       sub_1802DC2C8(0LL, v98);
			//     enableMetalFXSpatialScaler = HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler(v99, 0LL);
			//     v101 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v142 = (TextureHandle)v46;
			//     LOBYTE(v101) = HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//                      RTExtractionType__Enum_SceneColorPS,
			//                      &v142,
			//                      v101,
			//                      m_RenderGraph,
			//                      0LL);
			//     v142 = (TextureHandle)v46;
			//     v102 = enableMetalFXSpatialScaler | (unsigned __int8)v101 | HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//                                                                   RTExtractionType__Enum_FinalResult,
			//                                                                   &v142,
			//                                                                   *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//                                                                   m_RenderGraph,
			//                                                                   0LL);
			//     LOBYTE(v171) = v102;
			//     if ( *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 )
			//     {
			//       v105 = v102;
			//       if ( !v102 )
			//         goto LABEL_112;
			//     }
			//     else
			//     {
			//       v103 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v142 = (TextureHandle)v46;
			//       v104 = HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(&v142, v103, m_RenderGraph, 0LL);
			//       if ( !((unsigned __int8)v171 | v104) )
			//       {
			//         v105 = 0;
			//         goto LABEL_112;
			//       }
			//       v105 = 1;
			//     }
			//     v106 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//               &v142,
			//               (HGRenderPathBase *)v4,
			//               PassConstructorID__Enum_UI,
			//               0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     v142 = 0LL;
			//     v144 = v106;
			//     v150 = v46;
			//     HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//       m_RenderGraph,
			//       (TextureHandle *)&v150,
			//       &v144,
			//       1,
			//       -1,
			//       1,
			//       (Rect *)&v142,
			//       0,
			//       0LL);
			// LABEL_112:
			//     if ( *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03 )
			//     {
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)0x37u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//       output.currentSceneColor.handle = 0LL;
			//       output.currentSceneColor.fallBackResource = (ResourceHandle)v141;
			//       try
			//       {
			//         v107 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                   &v142,
			//                   (HGRenderPathBase *)v4,
			//                   PassConstructorID__Enum_UI,
			//                   0LL);
			//         sub_1802F01E0(&v157, 0LL, 80LL);
			//         v157.target = v107;
			//         v157.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//         v157.hgrp = v145;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v108 = (((unsigned __int64)&v157.hgrp >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v108 + 36190]);
			//           do
			//             v109 = qword_18D6405E0[v108 + 36190];
			//           while ( v109 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v108 + 36190],
			//                             v109 | (1LL << (((unsigned __int64)&v157.hgrp >> 12) & 0x3F)),
			//                             v109) );
			//         }
			//         v157.cullingResults = cullingResults;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v157.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_2D_LAYER.m_Mask;
			//         v157.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v145, 0LL);
			//         if ( !hgCamera )
			//           sub_1802DC2C8(v111, v110);
			//         *(_QWORD *)&v157.screenCullingRatio = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//         v157.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//         v167 = v157;
			//         LOBYTE(v171) = 0;
			//         v113 = *(UIPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m01;
			//         if ( !v113 )
			//           sub_1802DC2C8(0LL, v112);
			//         HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
			//           v113,
			//           &v167,
			//           (UIPassConstructor_PassOutput *)&v171,
			//           m_RenderGraph,
			//           *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03,
			//           P5,
			//           0LL);
			//         if ( !v105 )
			//         {
			//           v116 = *(ComposablePass **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m00;
			//           if ( !v116 )
			//             sub_1802DC2C8(0LL, v114);
			//           HG::Rendering::Runtime::ComposablePass::SetChildPass(
			//             v116,
			//             m_RenderGraph,
			//             *(ComposablePass **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m01,
			//             0LL);
			//         }
			//         v117 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//         if ( !v117 )
			//           sub_1802DC2C8(v115, v114);
			//         if ( *(int *)(v117 + 2424) > 0 )
			//         {
			//           v118 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                     &v142,
			//                     (HGRenderPathBase *)v4,
			//                     PassConstructorID__Enum_Multiblur,
			//                     0LL);
			//           memset(&v153[5], 0, 32);
			//           *(TextureHandle *)&v153[2] = v118;
			//           v153[4] = v145;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v119 = (((unsigned __int64)&v153[4] >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v119 + 36190]);
			//             do
			//               v120 = qword_18D6405E0[v119 + 36190];
			//             while ( v120 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v119 + 36190],
			//                               v120 | (1LL << (((unsigned __int64)&v153[4] >> 12) & 0x3F)),
			//                               v120) );
			//           }
			//           *(CullingResults *)&v153[5] = cullingResults;
			//           v153[7] = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//           LODWORD(v153[8]) = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//           v162 = *(MultiblurPassConstructor_PassInput *)&v153[2];
			//           LOBYTE(v171) = 0;
			//           v122 = *(MultiblurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m21;
			//           if ( !v122 )
			//             sub_1802DC2C8(0LL, v121);
			//           HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
			//             v122,
			//             &v162,
			//             (MultiblurPassConstructor_PassOutput *)&v171,
			//             m_RenderGraph,
			//             *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03,
			//             P5,
			//             0LL);
			//           if ( v4.fields._._firstBackbufferPass_k__BackingField == 57 )
			//           {
			//             backBufferColor_k__BackingField = v4.fields._._backBufferColor_k__BackingField;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//             v142 = 0LL;
			//             v144 = backBufferColor_k__BackingField;
			//             v150 = (Rect)v118;
			//             HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//               m_RenderGraph,
			//               (TextureHandle *)&v150,
			//               &v144,
			//               0,
			//               -1,
			//               1,
			//               (Rect *)&v142,
			//               0,
			//               0LL);
			//           }
			//         }
			//         v125 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                   &v142,
			//                   (HGRenderPathBase *)v4,
			//                   PassConstructorID__Enum_ScreenSpaceOverlay,
			//                   0LL);
			//         v126 = v125;
			//         v154 = v125;
			//         v155 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v127 = (((unsigned __int64)&v155 >> 12) & 0x1FFFFF) >> 6;
			//           v124 = ((unsigned __int64)&v155 >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v127 + 36190]);
			//           do
			//             v128 = qword_18D6405E0[v127 + 36190];
			//           while ( v128 != _InterlockedCompareExchange64(&qword_18D6405E0[v127 + 36190], v128 | (1LL << v124), v128) );
			//           v126 = v154;
			//         }
			//         v158.target = v126;
			//         v158.camera = v155;
			//         LOBYTE(v171) = 0;
			//         v129 = *(ScreenSpaceOverlayPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02;
			//         if ( !v129 )
			//           sub_1802DC2C8(0LL, v124);
			//         HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
			//           v129,
			//           &v158,
			//           (ScreenSpaceOverlayPassConstructor_PassOutput *)&v171,
			//           m_RenderGraph,
			//           *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03,
			//           P5,
			//           0LL);
			//         if ( v4.fields._._firstBackbufferPass_k__BackingField < 57 )
			//         {
			//           PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                               (HGRenderPathBase *)v4,
			//                               (PassConstructorID__Enum)v4.fields._._firstBackbufferPass_k__BackingField,
			//                               0LL);
			//           v131 = *(ComposablePass **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m02;
			//           if ( !sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass) )
			//             sub_1802DC2C8(v133, v132);
			//           v134 = (ComposablePass *)sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass);
			//           HG::Rendering::Runtime::ComposablePass::SetChildPass(v134, m_RenderGraph, v131, 0LL);
			//         }
			//         v135 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m03;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v142 = v125;
			//         HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//           RTExtractionType__Enum_FinalResult,
			//           &v142,
			//           v135,
			//           m_RenderGraph,
			//           0LL);
			//         v142 = v125;
			//         HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
			//           &v142,
			//           *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//           m_RenderGraph,
			//           0LL);
			//         if ( v4.fields._._firstBackbufferPass_k__BackingField > 57 )
			//         {
			//           v136 = v4.fields._._backBufferColor_k__BackingField;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//           v142 = 0LL;
			//           v144 = v136;
			//           v150 = (Rect)v125;
			//           HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//             m_RenderGraph,
			//             (TextureHandle *)&v150,
			//             &v144,
			//             0,
			//             -1,
			//             1,
			//             (Rect *)&v142,
			//             0,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v166 )
			//       {
			//         output.currentSceneColor.handle = (ResourceHandle)v166.ex;
			//         if ( output.currentSceneColor.handle )
			//           sub_18000F780(*(_QWORD *)&output.currentSceneColor.handle);
			//       }
			//     }
			//     return;
			//   }
			//   v137 = IFix::WrappersManagerImpl::GetPatch(3047, 0LL);
			//   if ( !v137 )
			//     sub_180B536AC(v139, v138);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(v137, (Object *)v4, v3, 0LL);
			// }
			// 
		}

		protected virtual void RenderEditorPrimitives(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderEditorPrimitives(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGRenderPathScene::RenderEditorPrimitives(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   TextureHandle backBufferColor_k__BackingField; // xmm2
			//   TextureHandle backBufferDepth_k__BackingField; // xmm3
			//   SetFinalTargetPassConstructor *v8; // rcx
			//   HGRenderPipeline *hgrp; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   SetFinalTargetPassConstructor_PassOutput output; // [rsp+30h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v14; // [rsp+38h] [rbp-60h] BYREF
			//   Il2CppException *ex; // [rsp+40h] [rbp-58h]
			//   char *v16; // [rsp+48h] [rbp-50h]
			//   SetFinalTargetPassConstructor_PassInput input; // [rsp+50h] [rbp-48h] BYREF
			//   char v18; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     byte_18D919661 = 1;
			//   }
			//   v18 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3060, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3060, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x3Bu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v16 = &v18;
			//     try
			//     {
			//       sub_1802F01E0(&input, 0LL, 64LL);
			//       backBufferColor_k__BackingField = this.fields._._backBufferColor_k__BackingField;
			//       backBufferDepth_k__BackingField = this.fields._._backBufferDepth_k__BackingField;
			//       input.sceneDepth = *(TextureHandle *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewNoTransProjMatrix.m00;
			//       input.backBufferColor = backBufferColor_k__BackingField;
			//       input.backBufferDepth = backBufferDepth_k__BackingField;
			//       output = 0;
			//       v8 = *(SetFinalTargetPassConstructor **)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredViewProjMatrix.m22;
			//       hgrp = renderPathParams.hgrp;
			//       if ( !hgrp )
			//         sub_1802DC2C8(v8, v5);
			//       if ( !v8 )
			//         sub_1802DC2C8(0LL, v5);
			//       HG::Rendering::Runtime::SetFinalTargetPassConstructor::ConstructPass(
			//         v8,
			//         &input,
			//         &output,
			//         hgrp.fields.m_RenderGraph,
			//         *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       ex = v14.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalMaterialStylizer(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void UpdateShaderVariablesGlobalMaterialStylizer(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalMaterialStylizer(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   void *monitor; // rdx
			//   __int64 v8; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
			//   Object_1 *m_sceneColorStylizer; // rbx
			//   Object_1__Class *klass; // rsi
			//   __int64 v12; // rax
			//   void *m_CachedPtr; // r8
			//   Vector4 *v14; // rax
			//   void *v15; // r8
			//   Vector4 *v16; // rax
			//   float v17; // xmm0_4
			//   float v18; // xmm10_4
			//   float v19; // xmm0_4
			//   float v20; // xmm9_4
			//   float v21; // xmm0_4
			//   float v22; // xmm8_4
			//   float v23; // xmm0_4
			//   Object_1__Class *v24; // r8
			//   float v25; // xmm7_4
			//   Vector4 *v26; // rax
			//   float v27; // xmm6_4
			//   float v28; // xmm0_4
			//   float v29; // xmm0_4
			//   MethodInfo *v30; // r8
			//   MethodInfo *v31; // r8
			//   __m128i v32; // xmm1
			//   MethodInfo *v33; // r8
			//   Color *v34; // rax
			//   __m128i v35; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v37; // [rsp+38h] [rbp-49h]
			//   Vector4 v38; // [rsp+40h] [rbp-41h]
			//   Color v39; // [rsp+50h] [rbp-31h] BYREF
			//   Vector4 v40; // [rsp+68h] [rbp-19h] BYREF
			//   Vector4 v41; // [rsp+78h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D919662 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919662 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3019, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//       if ( m_volumeComponentsData )
			//       {
			//         m_sceneColorStylizer = (Object_1 *)m_volumeComponentsData.fields.m_sceneColorStylizer;
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( !UnityEngine::Object::op_Inequality(m_sceneColorStylizer, 0LL, 0LL) )
			//         {
			//           *(__m128i *)&cb._IVV2Param0.y = _mm_load_si128((const __m128i *)&xmmword_18C371060);
			//           *(_OWORD *)&cb._IVV2Param1.y = 0LL;
			//           *(_OWORD *)&cb._IVV2Param2.y = 0LL;
			//           return;
			//         }
			//         if ( m_sceneColorStylizer )
			//         {
			//           monitor = m_sceneColorStylizer[2].monitor;
			//           klass = m_sceneColorStylizer[2].klass;
			//           if ( monitor )
			//           {
			//             v12 = sub_18004A780(10LL);
			//             m_CachedPtr = m_sceneColorStylizer[4].fields.m_CachedPtr;
			//             v37 = v12;
			//             if ( m_CachedPtr )
			//             {
			//               v14 = (Vector4 *)sub_180040AD0(&v41, 10LL, m_CachedPtr);
			//               v15 = m_sceneColorStylizer[2].fields.m_CachedPtr;
			//               v40 = *v14;
			//               if ( v15 )
			//               {
			//                 v16 = (Vector4 *)sub_180040AD0(&v41, 10LL, v15);
			//                 monitor = m_sceneColorStylizer[3].klass;
			//                 v41 = *v16;
			//                 if ( monitor )
			//                 {
			//                   v17 = sub_18003F9B0(10LL, monitor);
			//                   monitor = m_sceneColorStylizer[3].monitor;
			//                   v18 = v17;
			//                   if ( monitor )
			//                   {
			//                     v19 = sub_18003F9B0(10LL, monitor);
			//                     monitor = m_sceneColorStylizer[3].fields.m_CachedPtr;
			//                     v20 = v19;
			//                     if ( monitor )
			//                     {
			//                       v21 = sub_18003F9B0(10LL, monitor);
			//                       monitor = m_sceneColorStylizer[5].klass;
			//                       v22 = v21;
			//                       if ( monitor )
			//                       {
			//                         v23 = sub_18003F9B0(10LL, monitor);
			//                         v24 = m_sceneColorStylizer[4].klass;
			//                         v25 = v23;
			//                         if ( v24 )
			//                         {
			//                           v26 = (Vector4 *)sub_180040AD0(&v39, 10LL, v24);
			//                           monitor = m_sceneColorStylizer[4].monitor;
			//                           v38 = *v26;
			//                           if ( monitor )
			//                           {
			//                             v27 = sub_18003F9B0(10LL, monitor);
			//                             if ( klass )
			//                             {
			//                               v28 = sub_18003F9B0(10LL, klass);
			//                               v40.w = v28 * v40.w;
			//                               v29 = sub_18003F9B0(10LL, klass);
			//                               v41.w = v29 * v41.w;
			//                               v38.w = sub_18003F9B0(10LL, klass) * v38.w;
			//                               v38.x = v38.x * v27;
			//                               v38.y = v38.y * v27;
			//                               v38.z = v38.z * v27;
			//                               *(_QWORD *)&v39.r = v37;
			//                               v39.b = v25;
			//                               v39.a = v22;
			//                               *(Color *)&cb._IVV2Param0.y = v39;
			//                               *(__m128i *)&cb._IVV2Param1.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                                   &v39,
			//                                                                                                   &v40,
			//                                                                                                   v30));
			//                               v32 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                        (Color *)&v40,
			//                                                                        &v41,
			//                                                                        v31));
			//                               v41 = v38;
			//                               *(__m128i *)&cb._IVV2Param3.y = v32;
			//                               v34 = UnityEngine::Color::op_Implicit((Color *)&v40, &v41, v33);
			//                               v39.a = 0.0;
			//                               v39.r = v18;
			//                               v35 = _mm_loadu_si128((const __m128i *)v34);
			//                               *(_QWORD *)&v39.g = LODWORD(v20);
			//                               *(__m128i *)&cb._WaterInteractionParams0.y = v35;
			//                               *(Color *)&cb._WaterInteractionParams1.y = v39;
			//                               return;
			//                             }
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
			//     }
			// LABEL_21:
			//     sub_180B536AC(v8, monitor);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3019, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalEnvironment(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void UpdateShaderVariablesGlobalEnvironment(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalEnvironment(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v11; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D919663 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D919663 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3020, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//     if ( InterpolatedPhase )
			//     {
			//       *(_QWORD *)&v11 = *(_QWORD *)&InterpolatedPhase.fields.lightConfig.indirectDiffuseFactor;
			//       *((_QWORD *)&v11 + 1) = 1065353216LL;
			//       *(_OWORD *)&cb._WindMotorCount.z = v11;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3020, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalCloudShadow(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void UpdateShaderVariablesGlobalCloudShadow(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCloudShadow(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGSkyRenderer *s_skyRenderer; // rdi
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919664 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D919664 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3021, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     s_skyRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(0LL);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//     if ( s_skyRenderer )
			//     {
			//       HG::Rendering::Runtime::HGSkyRenderer::SetupShaderVariablesGlobalCloudShadow(
			//         s_skyRenderer,
			//         cb,
			//         InterpolatedPhase,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3021, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGraphFeaturesGlobalParam0(ref ShaderVariablesGlobal cb, HGCamera hgCamera, HGSettingParameters settingParameters)
		{
			// // Void UpdateShaderVariablesGraphFeaturesGlobalParam0(ShaderVariablesGlobal ByRef, HGCamera, HGSettingParameters)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGraphFeaturesGlobalParam0(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919665 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D919665 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3022, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       cb._LastWindGlobalParams0.z = (float)HG::Rendering::Runtime::HGCamera::get_aoEnable(hgCamera, 0LL);
			//       cb._LastWindGlobalParams0.w = (float)HG::Rendering::Runtime::HGCamera::get_ssrEnable(hgCamera, 0LL);
			//       cb._LastWindMotorParams0.FixedElementField = 1.0;
			//       cb._LastWindMotorParams1.FixedElementField = 1.0;
			//       if ( settingParameters )
			//       {
			//         cb._LastWindMotorParams3.FixedElementField = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                                                     (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._reflectionProbeMaxSampleMip_k__BackingField,
			//                                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3022, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_449(
			//     Patch,
			//     (Object *)this,
			//     cb,
			//     (Object *)hgCamera,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		public static bool ShouldRenderAtmosphereFog(HGCamera hgCamera)
		{
			// // Boolean ShouldRenderAtmosphereFog(HGCamera)
			// bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderAtmosphereFog(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v6)(Camera *); // rax
			//   int v7; // eax
			//   __int64 v8; // rdx
			//   struct HGAtmosphereRenderer__Class *v9; // rcx
			//   int v10; // edi
			//   __int64 v11; // rdx
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rax
			// 
			//   if ( !byte_18D8EDB17 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDB17 = 1;
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
			//   if ( wrapperArray.max_length.size <= 884 )
			//     goto LABEL_34;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_20;
			//   if ( LODWORD(v3._0.namespaze) <= 0x374 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[18].vtable.Finalize.method )
			//   {
			// LABEL_34:
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         v6 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//         if ( !qword_18D8F41E8 )
			//         {
			//           v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cullingMask()");
			//           if ( !v6 )
			//           {
			//             v15 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMask()");
			//             sub_18000F750(v15, 0LL);
			//           }
			//           qword_18D8F41E8 = (__int64)v6;
			//         }
			//         v7 = v6(camera);
			//         v9 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//         v10 = v7;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer, v8);
			//           v9 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//         }
			//         v11 = v9.static_fields.FOG_LAYER & 0x1F;
			//         if ( !_bittest(&v10, v11) )
			//           return 0;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v11);
			//         InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//         if ( InterpolatedPhase )
			//           return InterpolatedPhase.fields.fogConfig.enable;
			//       }
			//     }
			// LABEL_20:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(884, 0LL);
			//   if ( !Patch )
			//     goto LABEL_20;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)hgCamera, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool ShouldRenderHeightFog(HGCamera hgCamera)
		{
			// // Boolean ShouldRenderHeightFog(HGCamera)
			// bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFog(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *s_settingParameters; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v6)(Camera *); // rax
			//   int v7; // eax
			//   __int64 v8; // rdx
			//   struct HGAtmosphereRenderer__Class *v9; // rcx
			//   int v10; // edi
			//   __int64 v11; // rdx
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   HGVolumetricFogConfig *p_volumetricFogConfig; // rdi
			//   struct HGVolumetricFogRenderer__Class *v15; // rax
			//   HGEnvironmentPhase *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rax
			// 
			//   if ( !byte_18D8EDB18 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDB18 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = s_settingParameters.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_31;
			//   if ( wrapperArray.max_length.size <= 885 )
			//     goto LABEL_45;
			//   if ( !s_settingParameters._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(s_settingParameters, wrapperArray);
			//     s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)s_settingParameters.static_fields.wrapperArray;
			//   if ( !s_settingParameters )
			//     goto LABEL_31;
			//   if ( LODWORD(s_settingParameters._0.namespaze) <= 0x375 )
			//     sub_180070270(s_settingParameters, wrapperArray);
			//   if ( !s_settingParameters[18].vtable.GetHashCode.methodPtr )
			//   {
			// LABEL_45:
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         v6 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//         if ( !qword_18D8F41E8 )
			//         {
			//           v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cullingMask()");
			//           if ( !v6 )
			//           {
			//             v18 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMask()");
			//             sub_18000F750(v18, 0LL);
			//           }
			//           qword_18D8F41E8 = (__int64)v6;
			//         }
			//         v7 = v6(camera);
			//         v9 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//         v10 = v7;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer, v8);
			//           v9 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//         }
			//         v11 = v9.static_fields.FOG_LAYER & 0x1F;
			//         if ( !_bittest(&v10, v11) )
			//           return 0;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v11);
			//         InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//         if ( InterpolatedPhase )
			//         {
			//           p_volumetricFogConfig = &InterpolatedPhase.fields.volumetricFogConfig;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, wrapperArray);
			//           if ( HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(p_volumetricFogConfig, 0LL) )
			//           {
			//             v15 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, wrapperArray);
			//               v15 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//             }
			//             s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)v15.static_fields.s_settingParameters;
			//             if ( !s_settingParameters )
			//               goto LABEL_31;
			//             if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    (SettingParameter_1_System_Boolean_ *)s_settingParameters._0.name,
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//             {
			//               return 1;
			//             }
			//           }
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//           v16 = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//           if ( v16 )
			//             return v16.fields.heightFogConfig.enable;
			//         }
			//       }
			//     }
			// LABEL_31:
			//     sub_180B536AC(s_settingParameters, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(885, 0LL);
			//   if ( !Patch )
			//     goto LABEL_31;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)hgCamera, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool ShouldRenderHeightFogDirectionalInscattering(HGCamera hgCamera)
		{
			// // Boolean ShouldRenderHeightFogDirectionalInscattering(HGCamera)
			// bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFogDirectionalInscattering(
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v3; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v6)(Camera *); // rax
			//   int v7; // eax
			//   __int64 v8; // rdx
			//   struct HGAtmosphereRenderer__Class *v9; // rcx
			//   int v10; // edi
			//   __int64 v11; // rdx
			//   HGEnvironmentPhase *InterpolatedPhase; // rbx
			//   Quaternion v13; // xmm0
			//   MethodInfo *v14; // r8
			//   Color v15; // xmm3
			//   MethodInfo *v16; // r8
			//   __m128 *v17; // rax
			//   __m128 v18; // xmm5
			//   float v19; // xmm4_4
			//   float v20; // xmm1_4
			//   float v21; // xmm2_4
			//   Quaternion v22; // xmm0
			//   MethodInfo *v23; // r8
			//   Color v24; // xmm3
			//   MethodInfo *v25; // r8
			//   __m128 *v26; // rax
			//   __m128 v27; // xmm5
			//   float v28; // xmm4_4
			//   float v29; // xmm1_4
			//   float v30; // xmm2_4
			//   __int64 v32; // rax
			//   struct HGVolumetricFogRenderer__Class *v33; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v35; // [rsp+20h] [rbp-48h] BYREF
			//   Quaternion heightFogDirectionalInscattering; // [rsp+30h] [rbp-38h] BYREF
			//   Quaternion v37; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDB19 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDB19 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(888, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         v6 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//         if ( !qword_18D8F41E8 )
			//         {
			//           v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cullingMask()");
			//           if ( !v6 )
			//           {
			//             v32 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMask()");
			//             sub_18000F750(v32, 0LL);
			//           }
			//           qword_18D8F41E8 = (__int64)v6;
			//         }
			//         v7 = v6(camera);
			//         v9 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//         v10 = v7;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer, v8);
			//           v9 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//         }
			//         v11 = v9.static_fields.FOG_LAYER & 0x1F;
			//         if ( !_bittest(&v10, v11) )
			//           return 0;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v11);
			//         InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//         if ( InterpolatedPhase )
			//         {
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, v3);
			//           if ( !HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(
			//                   &InterpolatedPhase.fields.volumetricFogConfig,
			//                   0LL) )
			//             goto LABEL_19;
			//           v13 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v35, v3);
			//           heightFogDirectionalInscattering = (Quaternion)InterpolatedPhase.fields.volumetricFogConfig.heightFogDirectionalInscattering;
			//           v35 = (Color)v13;
			//           v15 = *UnityEngine::Color::op_Implicit((Color *)&v37, (Vector4 *)&v35, v14);
			//           v17 = (__m128 *)UnityEngine::Color::op_Implicit(
			//                             (Color *)&v37,
			//                             (Vector4 *)&heightFogDirectionalInscattering,
			//                             v16);
			//           v18 = *v17;
			//           v19 = _mm_shuffle_ps(v18, v18, 85).m128_f32[0] - _mm_shuffle_ps((__m128)v15, (__m128)v15, 85).m128_f32[0];
			//           v20 = _mm_shuffle_ps(*v17, *v17, 170).m128_f32[0];
			//           v13.x = _mm_shuffle_ps((__m128)v15, (__m128)v15, 170).m128_f32[0];
			//           v18.m128_f32[0] = _mm_shuffle_ps(v18, v18, 255).m128_f32[0];
			//           v21 = (float)(COERCE_FLOAT(*v17) - v15.r) * (float)(COERCE_FLOAT(*v17) - v15.r);
			//           v15.r = _mm_shuffle_ps((__m128)v15, (__m128)v15, 255).m128_f32[0];
			//           if ( (float)((float)((float)((float)(v19 * v19) + v21) + (float)((float)(v20 - v13.x) * (float)(v20 - v13.x)))
			//                      + (float)((float)(v18.m128_f32[0] - v15.r) * (float)(v18.m128_f32[0] - v15.r))) < 9.9999994e-11 )
			//           {
			// LABEL_19:
			//             if ( InterpolatedPhase.fields.heightFogConfig.enable )
			//             {
			//               v22 = *UnityEngine::Quaternion::get_identity(&v37, v3);
			//               v35 = InterpolatedPhase.fields.heightFogConfig.heightFogDirectionalInscattering;
			//               heightFogDirectionalInscattering = v22;
			//               v24 = *UnityEngine::Color::op_Implicit((Color *)&v37, (Vector4 *)&heightFogDirectionalInscattering, v23);
			//               v26 = (__m128 *)UnityEngine::Color::op_Implicit((Color *)&v37, (Vector4 *)&v35, v25);
			//               v27 = *v26;
			//               v28 = _mm_shuffle_ps(v27, v27, 85).m128_f32[0] - _mm_shuffle_ps((__m128)v24, (__m128)v24, 85).m128_f32[0];
			//               v29 = _mm_shuffle_ps(*v26, *v26, 170).m128_f32[0];
			//               v22.x = _mm_shuffle_ps((__m128)v24, (__m128)v24, 170).m128_f32[0];
			//               v27.m128_f32[0] = _mm_shuffle_ps(v27, v27, 255).m128_f32[0];
			//               v30 = (float)(COERCE_FLOAT(*v26) - v24.r) * (float)(COERCE_FLOAT(*v26) - v24.r);
			//               v24.r = _mm_shuffle_ps((__m128)v24, (__m128)v24, 255).m128_f32[0];
			//               return (float)((float)((float)((float)(v28 * v28) + v30)
			//                                    + (float)((float)(v29 - v22.x) * (float)(v29 - v22.x)))
			//                            + (float)((float)(v27.m128_f32[0] - v24.r) * (float)(v27.m128_f32[0] - v24.r))) >= 9.9999994e-11;
			//             }
			//             return 0;
			//           }
			//           v33 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, v3);
			//             v33 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//           }
			//           s_settingParameters = v33.static_fields.s_settingParameters;
			//           if ( s_settingParameters )
			//           {
			//             if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    s_settingParameters.fields.enableVolumetricFog,
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//             {
			//               return 1;
			//             }
			//             goto LABEL_19;
			//           }
			//         }
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(s_settingParameters, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(888, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)hgCamera, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool ShouldRenderVolumetricFog(HGCamera hgCamera)
		{
			// // Boolean ShouldRenderVolumetricFog(HGCamera)
			// bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderVolumetricFog(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *s_settingParameters; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Camera *camera; // rdi
			//   unsigned __int8 (__fastcall *v6)(Camera *); // rax
			//   Camera *v7; // rdi
			//   __int64 (__fastcall *v8)(Camera *); // rax
			//   int v9; // eax
			//   __int64 v10; // rdx
			//   struct HGAtmosphereRenderer__Class *v11; // rcx
			//   int v12; // edi
			//   __int64 v13; // rdx
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   HGVolumetricFogConfig *p_volumetricFogConfig; // rbx
			//   struct HGVolumetricFogRenderer__Class *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rax
			//   __int64 v20; // rax
			// 
			//   if ( !byte_18D8EDB1A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDB1A = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = s_settingParameters.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_32;
			//   if ( wrapperArray.max_length.size <= 886 )
			//     goto LABEL_49;
			//   if ( !s_settingParameters._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(s_settingParameters, wrapperArray);
			//     s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)s_settingParameters.static_fields.wrapperArray;
			//   if ( !s_settingParameters )
			//     goto LABEL_32;
			//   if ( LODWORD(s_settingParameters._0.namespaze) <= 0x376 )
			//     sub_180070270(s_settingParameters, wrapperArray);
			//   if ( !s_settingParameters[18].vtable.GetHashCode.method )
			//   {
			// LABEL_49:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, wrapperArray);
			//     if ( !HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL) )
			//       return 0;
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         v6 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F41C8;
			//         if ( !qword_18D8F41C8 )
			//         {
			//           v6 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//           if ( !v6 )
			//           {
			//             v19 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//             sub_18000F750(v19, 0LL);
			//           }
			//           qword_18D8F41C8 = (__int64)v6;
			//         }
			//         if ( v6(camera) )
			//           return 0;
			//         v7 = hgCamera.fields.camera;
			//         if ( v7 )
			//         {
			//           v8 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//           if ( !qword_18D8F41E8 )
			//           {
			//             v8 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cullingMask()");
			//             if ( !v8 )
			//             {
			//               v20 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMask()");
			//               sub_18000F750(v20, 0LL);
			//             }
			//             qword_18D8F41E8 = (__int64)v8;
			//           }
			//           v9 = v8(v7);
			//           v11 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//           v12 = v9;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer, v10);
			//             v11 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
			//           }
			//           v13 = v11.static_fields.FOG_LAYER & 0x1F;
			//           if ( !_bittest(&v12, v13) )
			//             return 0;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v13);
			//           InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//           if ( InterpolatedPhase )
			//           {
			//             p_volumetricFogConfig = &InterpolatedPhase.fields.volumetricFogConfig;
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, wrapperArray);
			//             if ( !HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(p_volumetricFogConfig, 0LL) )
			//               return 0;
			//             v17 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, wrapperArray);
			//               v17 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//             }
			//             s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)v17.static_fields.s_settingParameters;
			//             if ( s_settingParameters )
			//               return HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                        (SettingParameter_1_System_Boolean_ *)s_settingParameters._0.name,
			//                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           }
			//         }
			//       }
			//     }
			// LABEL_32:
			//     sub_180B536AC(s_settingParameters, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(886, 0LL);
			//   if ( !Patch )
			//     goto LABEL_32;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)hgCamera, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool ShouldBakeFogLut(HGCamera hgCamera)
		{
			// // Boolean ShouldBakeFogLut(HGCamera)
			// bool HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   SettingParameter_1_System_Int32Enum_ **static_fields; // rcx
			//   SettingParameter_1_System_Int32Enum_ *v5; // rdx
			//   __int64 v6; // rdx
			//   __int64 v8; // rdx
			//   struct HGVolumetricFogRenderer__Class *v9; // rax
			//   SettingParameter_1_System_Int32Enum_ *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB1B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDB1B = 1;
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
			//   static_fields = (SettingParameter_1_System_Int32Enum_ **)v3.static_fields;
			//   v5 = *static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_27;
			//   if ( SLODWORD(v5.fields._._paramName_k__BackingField) > 887 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, v5);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (SettingParameter_1_System_Int32Enum_ **)v3.static_fields;
			//     v10 = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_27;
			//     if ( LODWORD(v10.fields._._paramName_k__BackingField) <= 0x377 )
			//       sub_180070270(static_fields, v5);
			//     if ( v10[148].fields._._paramName_k__BackingField )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(887, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                  (ILFixDynamicMethodWrapper_27 *)Patch,
			//                  (Object *)hgCamera,
			//                  0LL);
			//       goto LABEL_27;
			//     }
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene, v5);
			//   if ( !HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderAtmosphereFog(hgCamera, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene, v6);
			//     if ( !HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFog(hgCamera, 0LL) )
			//       return 0;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene, v6);
			//   if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFogDirectionalInscattering(hgCamera, 0LL) )
			//     return 0;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene, v8);
			//   if ( !HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderVolumetricFog(hgCamera, 0LL) )
			//     return 1;
			//   v9 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, v5);
			//     v9 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
			//   }
			//   static_fields = (SettingParameter_1_System_Int32Enum_ **)v9.static_fields.s_settingParameters;
			//   if ( !static_fields )
			// LABEL_27:
			//     sub_180B536AC(static_fields, v5);
			//   return !HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             static_fields[4],
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			// }
			// 
			return default(bool);
		}

		internal void UpdateShaderVariablesGlobalAtmosphere(ref ShaderVariablesGlobal cb, HGCamera hgCamera, CommandBuffer cmd, HGAtmosphereSettingParameters atmosphereParams)
		{
			// // Void UpdateShaderVariablesGlobalAtmosphere(ShaderVariablesGlobal ByRef, HGCamera, CommandBuffer, HGAtmosphereSettingParameters)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalAtmosphere(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         HGAtmosphereSettingParameters *atmosphereParams,
			//         MethodInfo *method)
			// {
			//   HGAtmosphereRenderer *s_atmosphereRenderer; // rsi
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGAtmosphereRenderer *v14; // rax
			//   HGVolumetricFogRenderer *s_volumetricFogRenderer; // rax
			//   HGAtmosphereRenderer *v16; // rax
			// 
			//   if ( !byte_18D919666 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     byte_18D919666 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3024, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderAtmosphereFog(hgCamera, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//       s_atmosphereRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(0LL);
			//       InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//       if ( !s_atmosphereRenderer )
			//         goto LABEL_21;
			//       HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalAtmosphereFog(
			//         s_atmosphereRenderer,
			//         cb,
			//         hgCamera,
			//         InterpolatedPhase,
			//         0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//       HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalAtmosphereFog(cb, 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFog(hgCamera, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//       v14 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(0LL);
			//       if ( !v14 )
			//         goto LABEL_21;
			//       HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalHeightFog(v14, cb, hgCamera, 0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//       HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalHeightFog(cb, 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderVolumetricFog(hgCamera, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//       s_volumetricFogRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_volumetricFogRenderer(0LL);
			//       if ( !s_volumetricFogRenderer )
			//         goto LABEL_21;
			//       HG::Rendering::Runtime::HGVolumetricFogRenderer::SetupShaderVariablesGlobalVolumetricFog(
			//         s_volumetricFogRenderer,
			//         cb,
			//         hgCamera,
			//         0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//       HG::Rendering::Runtime::HGVolumetricFogRenderer::ResetShaderVariablesGlobalVolumetricFog(cb, 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     if ( !HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(hgCamera, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//       HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalBakeFogLut(cb, 0LL);
			//       return;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     v16 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(0LL);
			//     if ( v16 )
			//     {
			//       HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalBakeFogLut(
			//         v16,
			//         cb,
			//         hgCamera,
			//         atmosphereParams,
			//         0LL);
			//       return;
			//     }
			// LABEL_21:
			//     sub_180B536AC(Patch, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3024, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1071(
			//     Patch,
			//     (Object *)this,
			//     cb,
			//     (Object *)hgCamera,
			//     (Object *)cmd,
			//     (Object *)atmosphereParams,
			//     0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalCharacter(ref ShaderVariablesGlobal cb, HGCamera hgCamera, CommandBuffer cmd, RainCommonPreSettingParam rainRes)
		{
			// // Void UpdateShaderVariablesGlobalCharacter(ShaderVariablesGlobal ByRef, HGCamera, CommandBuffer, RainCommonPreSettingParam)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCharacter(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         RainCommonPreSettingParam *rainRes,
			//         MethodInfo *method)
			// {
			//   MethodInfo *charMainLightControl; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
			//   HGCharacterVolume *m_hgCharacterVolume; // rbx
			//   float v14; // xmm6_4
			//   float v15; // xmm0_4
			//   float v16; // xmm0_4
			//   float v17; // xmm0_4
			//   float v18; // xmm0_4
			//   float v19; // xmm0_4
			//   int v20; // eax
			//   float v21; // xmm0_4
			//   float v22; // xmm0_4
			//   MethodInfo *v23; // r8
			//   MethodInfo *v24; // r8
			//   ColorParameter *charSkinMainLightOverrideColor; // rax
			//   ColorParameter *charMainLightOverrideColor; // r8
			//   MethodInfo *v27; // r8
			//   ColorParameter *v28; // r8
			//   MethodInfo *v29; // r8
			//   Vector4Parameter *charGlobalAmbientParam0; // r8
			//   Vector4Parameter *charGlobalAmbientParam1; // r8
			//   ColorParameter *charAutoRimColor; // r8
			//   Quaternion *identity; // rax
			//   MethodInfo *v34; // r8
			//   float v35; // xmm0_4
			//   float v36; // xmm0_4
			//   Vector3 *CharAutoRimVector; // rax
			//   __int64 v38; // xmm0_8
			//   MethodInfo *v39; // r8
			//   float v40; // xmm0_4
			//   Transform *transform; // rax
			//   Vector3 *CharLightVector; // rax
			//   __int64 v43; // xmm0_8
			//   MethodInfo *v44; // r8
			//   float v45; // xmm0_4
			//   ClampedFloatParameter *charMainLightRangeBias; // rax
			//   float v47; // xmm0_4
			//   ColorParameter *v48; // rax
			//   float v49; // xmm0_4
			//   float v50; // xmm0_4
			//   float v51; // xmm0_4
			//   float v52; // xmm0_4
			//   float v53; // xmm0_4
			//   float v54; // xmm0_4
			//   float v55; // xmm0_4
			//   ColorParameter *charFaceRimColor; // r8
			//   Quaternion *v57; // rax
			//   MethodInfo *v58; // r8
			//   float v59; // xmm0_4
			//   float v60; // xmm0_4
			//   Vector3 *CharFaceRimVector; // rax
			//   __int64 v62; // xmm0_8
			//   MethodInfo *v63; // r8
			//   float v64; // xmm0_4
			//   float characterRainTextureTiling; // xmm0_4
			//   Color v66; // [rsp+40h] [rbp-30h] BYREF
			//   Color v67; // [rsp+50h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3025, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3025, 0LL);
			//     if ( !Patch )
			//       goto LABEL_84;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1071(
			//       Patch,
			//       (Object *)this,
			//       cb,
			//       (Object *)hgCamera,
			//       (Object *)cmd,
			//       (Object *)rainRes,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       goto LABEL_84;
			//     m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//     if ( !m_volumeComponentsData )
			//       goto LABEL_84;
			//     m_hgCharacterVolume = m_volumeComponentsData.fields.m_hgCharacterVolume;
			//     if ( !m_hgCharacterVolume )
			//       goto LABEL_84;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charMainLightControl;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v14 = 1.0;
			//     v15 = (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) ? 1.0 : 0.0;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charMainLightMultiplier;
			//     cb._RainWetnessGlobalParam4.y = v15;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v16 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charEnvLightMultiplier;
			//     cb._RainWetnessGlobalParam4.z = v16;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v17 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charEnvShadowMultiplier;
			//     cb._RainWetnessGlobalParam4.w = v17;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v18 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charLightDialogMode;
			//     cb._RainWetnessGlobalParam5.x = v18;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v19 = (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) ? 1.0 : 0.0;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charShadowTintControl;
			//     cb._RainWetnessGlobalParam5.y = v19;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v20 = sub_18003ED00(10LL);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charIgnoreMainLightShadow;
			//     cb._RainWetnessGlobalParam5.z = (float)v20;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v21 = (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) ? 1.0 : 0.0;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charMainLightMode;
			//     cb._RainWetnessGlobalParam5.w = v21;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v22 = (unsigned int)sub_18003ED00(10LL) ? 1.0 : 0.0;
			//     cb._RainWetnessGlobalParam6.x = v22;
			//     v67 = *HG::Rendering::Runtime::HGCharacterVolume::GetShadowTintColor(&v67, m_hgCharacterVolume, 0LL);
			//     *(__m128i *)&cb._RainWetnessGlobalParam6.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                      &v66,
			//                                                                                      (Vector4 *)&v67,
			//                                                                                      v23));
			//     v67 = *HG::Rendering::Runtime::HGCharacterVolume::GetSkinShadowTintColor(&v67, m_hgCharacterVolume, 0LL);
			//     *(__m128i *)&cb._RainWetnessGlobalParam7.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                      &v66,
			//                                                                                      (Vector4 *)&v67,
			//                                                                                      v24));
			//     charSkinMainLightOverrideColor = m_hgCharacterVolume.fields.charSkinMainLightOverrideColor;
			//     if ( !charSkinMainLightOverrideColor )
			//       goto LABEL_84;
			//     if ( charSkinMainLightOverrideColor.fields._._.overrideState )
			//     {
			//       charMainLightOverrideColor = m_hgCharacterVolume.fields.charSkinMainLightOverrideColor;
			//     }
			//     else
			//     {
			//       charMainLightOverrideColor = m_hgCharacterVolume.fields.charMainLightOverrideColor;
			//       if ( !charMainLightOverrideColor )
			//         goto LABEL_84;
			//     }
			//     v67 = (Color)_mm_loadu_si128((const __m128i *)sub_180040AD0(&v67, 10LL, charMainLightOverrideColor));
			//     *(__m128i *)&cb._RainWetnessGlobalParam8.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                      &v66,
			//                                                                                      (Vector4 *)&v67,
			//                                                                                      v27));
			//     v28 = m_hgCharacterVolume.fields.charMainLightOverrideColor;
			//     if ( !v28 )
			//       goto LABEL_84;
			//     v67 = *(Color *)sub_180040AD0(&v67, 10LL, v28);
			//     *(__m128i *)&cb._RainWetnessGlobalParam9.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                      &v66,
			//                                                                                      (Vector4 *)&v67,
			//                                                                                      v29));
			//     charGlobalAmbientParam0 = m_hgCharacterVolume.fields.charGlobalAmbientParam0;
			//     if ( !charGlobalAmbientParam0 )
			//       goto LABEL_84;
			//     *(__m128i *)&cb._RainWetnessGlobalParam10.y = _mm_loadu_si128((const __m128i *)sub_180040AD0(
			//                                                                                       &v67,
			//                                                                                       10LL,
			//                                                                                       charGlobalAmbientParam0));
			//     charGlobalAmbientParam1 = m_hgCharacterVolume.fields.charGlobalAmbientParam1;
			//     if ( !charGlobalAmbientParam1 )
			//       goto LABEL_84;
			//     *(__m128i *)&cb._VerticalOcclusionMapParam0.y = _mm_loadu_si128((const __m128i *)sub_180040AD0(
			//                                                                                         &v67,
			//                                                                                         10LL,
			//                                                                                         charGlobalAmbientParam1));
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charAutoRimEnable;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     if ( (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) )
			//     {
			//       charAutoRimColor = m_hgCharacterVolume.fields.charAutoRimColor;
			//       if ( !charAutoRimColor )
			//         goto LABEL_84;
			//       identity = (Quaternion *)sub_180040AD0(&v67, 10LL, charAutoRimColor);
			//     }
			//     else
			//     {
			//       identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v67, charMainLightControl);
			//     }
			//     v67 = (Color)_mm_loadu_si128((const __m128i *)identity);
			//     *(__m128i *)&cb._WaterWetnessMaskParam0.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                     &v66,
			//                                                                                     (Vector4 *)&v67,
			//                                                                                     v34));
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charAutoRimIntensity;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v35 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charAutoRimDir;
			//     cb._GpuClothParams.x = v35;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v36 = sub_18003F9B0(10LL, charMainLightControl);
			//     CharAutoRimVector = HG::Rendering::Runtime::HGCharacterVolume::GetCharAutoRimVector(
			//                           (Vector3 *)&v67,
			//                           m_hgCharacterVolume,
			//                           v36,
			//                           0LL);
			//     v38 = *(_QWORD *)&CharAutoRimVector.x;
			//     *(float *)&CharAutoRimVector = CharAutoRimVector.z;
			//     *(_QWORD *)&v66.r = v38;
			//     LODWORD(v66.b) = (_DWORD)CharAutoRimVector;
			//     *(__m128i *)&cb._GpuClothParams.y = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                             (Vector4 *)&v67,
			//                                                                             (Vector3 *)&v66,
			//                                                                             v39));
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charAutoRimAlbedo;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v40 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charAutoRimWidth;
			//     cb._GpuClothParams.w = v40;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     cb._FoliageOccluderParams0.x = sub_18003F9B0(10LL, charMainLightControl);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)hgCamera.fields.camera;
			//     if ( !Patch )
			//       goto LABEL_84;
			//     transform = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
			//     CharLightVector = HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVector(
			//                         (Vector3 *)&v67,
			//                         m_hgCharacterVolume,
			//                         transform,
			//                         0LL);
			//     v43 = *(_QWORD *)&CharLightVector.x;
			//     *(float *)&CharLightVector = CharLightVector.z;
			//     *(_QWORD *)&v66.r = v43;
			//     LODWORD(v66.b) = (_DWORD)CharLightVector;
			//     *(__m128i *)&cb._FoliageOccluderCameraPosParam.y = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                                            (Vector4 *)&v67,
			//                                                                                            (Vector3 *)&v66,
			//                                                                                            v44));
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charMainLightRangeBias;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v45 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightRangeBias = m_hgCharacterVolume.fields.charMainLightRangeBias;
			//     cb._InteractRaftParams0.x = v45;
			//     if ( !charMainLightRangeBias )
			//       goto LABEL_84;
			//     v47 = charMainLightRangeBias.fields._._._.overrideState ? 1.0 : 0.0;
			//     v48 = m_hgCharacterVolume.fields.charMainLightOverrideColor;
			//     cb._InteractRaftParams0.y = v47;
			//     if ( !v48 )
			//       goto LABEL_84;
			//     v49 = v48.fields._._.overrideState ? 1.0 : 0.0;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charIgnoreSceneAdditionalLights;
			//     cb._InteractRaftParams0.z = v49;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v50 = (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) ? 0.0 : 1.0;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charIgnoreSceneEnv;
			//     cb._InteractRaftParams0.w = v50;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v51 = (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) ? 1.0 : 0.0;
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charEyeBaseLightMultiplier;
			//     cb._InteractRaftParams1.x = v51;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v52 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charEyeHighlightMultiplier;
			//     cb._InteractRaftParams1.y = v52;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v53 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charEyeScatteringMultiplier;
			//     cb._InteractRaftParams1.z = v53;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v54 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charMainLightSpecularMultiplier;
			//     cb._InteractRaftParams1.w = v54;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v55 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charFaceRimEnable;
			//     cb._FakePlanarReflectionViewProjMatrix.m00 = v55;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     if ( (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) )
			//     {
			//       charFaceRimColor = m_hgCharacterVolume.fields.charFaceRimColor;
			//       if ( !charFaceRimColor )
			//         goto LABEL_84;
			//       v57 = (Quaternion *)sub_180040AD0(&v67, 10LL, charFaceRimColor);
			//     }
			//     else
			//     {
			//       v57 = UnityEngine::Quaternion::get_identity((Quaternion *)&v67, charMainLightControl);
			//     }
			//     v67 = (Color)_mm_loadu_si128((const __m128i *)v57);
			//     *(__m128i *)&cb._FakePlanarReflectionViewProjMatrix.m10 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                                   &v66,
			//                                                                                                   (Vector4 *)&v67,
			//                                                                                                   v58));
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charFaceRimIntensity;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v59 = sub_18003F9B0(10LL, charMainLightControl);
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charFaceRimDir;
			//     cb._FakePlanarReflectionViewProjMatrix.m01 = v59;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     v60 = sub_18003F9B0(10LL, charMainLightControl);
			//     CharFaceRimVector = HG::Rendering::Runtime::HGCharacterVolume::GetCharFaceRimVector(
			//                           (Vector3 *)&v67,
			//                           m_hgCharacterVolume,
			//                           v60,
			//                           0LL);
			//     v62 = *(_QWORD *)&CharFaceRimVector.x;
			//     *(float *)&CharFaceRimVector = CharFaceRimVector.z;
			//     *(_QWORD *)&v66.r = v62;
			//     LODWORD(v66.b) = (_DWORD)CharFaceRimVector;
			//     *(__m128i *)&cb._FakePlanarReflectionViewProjMatrix.m11 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                                                   (Vector4 *)&v67,
			//                                                                                                   (Vector3 *)&v66,
			//                                                                                                   v63));
			//     charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charAutoRimMode;
			//     if ( !charMainLightControl )
			//       goto LABEL_84;
			//     if ( (unsigned __int8)sub_1800023D0(10LL, charMainLightControl) )
			//       v64 = 1.0;
			//     else
			//       v64 = 0.0;
			//     cb._FakePlanarReflectionViewProjMatrix.m02 = v64;
			//     if ( rainRes )
			//     {
			//       if ( !HG::Rendering::Runtime::HGCharacterVolume::GetRainEffectPreviewEnabled(m_hgCharacterVolume, 0LL) )
			//         v14 = 0.0;
			//       cb._FoliageOccluderParams0.y = v14;
			//       cb._FoliageOccluderParams0.z = HG::Rendering::Runtime::HGCharacterVolume::GetPackedEnvironmentEffectIntensity(
			//                                         m_hgCharacterVolume,
			//                                         0LL);
			//       if ( HG::Rendering::Runtime::HGCharacterVolume::GetRainEffectPreviewEnabled(m_hgCharacterVolume, 0LL) )
			//       {
			//         charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charRainEffectTextureTiling;
			//         if ( !charMainLightControl )
			//           goto LABEL_84;
			//         characterRainTextureTiling = sub_18003F9B0(10LL, charMainLightControl);
			//       }
			//       else
			//       {
			//         characterRainTextureTiling = rainRes.fields.characterRainTextureTiling;
			//       }
			//       charMainLightControl = (MethodInfo *)m_hgCharacterVolume.fields.charWetEffectPreviewWorldHeight;
			//       cb._FoliageOccluderParams0.w = characterRainTextureTiling;
			//       if ( charMainLightControl )
			//       {
			//         cb._FoliageOccluderCameraPosParam.x = sub_18003F9B0(10LL, charMainLightControl);
			//         return;
			//       }
			// LABEL_84:
			//       sub_180B536AC(Patch, charMainLightControl);
			//     }
			//   }
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalWind(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void UpdateShaderVariablesGlobalWind(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWind(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v8; // rdx
			//   Object_1 *camera; // rcx
			//   HGWindManager *windManager_k__BackingField; // rsi
			//   int32_t InstanceID; // eax
			//   int32_t v12; // ebp
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // r14d
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v18; // [rsp+30h] [rbp-28h] BYREF
			//   Vector3 v19[2]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919667 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D919667 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3026, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       windManager_k__BackingField = currentManagerContext.fields._windManager_k__BackingField;
			//       if ( hgCamera )
			//       {
			//         camera = (Object_1 *)hgCamera.fields.camera;
			//         if ( camera )
			//         {
			//           InstanceID = UnityEngine::Object::GetInstanceID(camera, 0LL);
			//           camera = (Object_1 *)hgCamera.fields.camera;
			//           v12 = InstanceID;
			//           if ( camera )
			//           {
			//             transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//             if ( transform )
			//             {
			//               position = UnityEngine::Transform::get_position(v19, transform, 0LL);
			//               z = position.z;
			//               *(_QWORD *)&v18.x = *(_QWORD *)&position.x;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//               InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//               if ( windManager_k__BackingField )
			//               {
			//                 v18.z = z;
			//                 HG::Rendering::Runtime::HGWindManager::SetupShaderVariablesGlobalWind(
			//                   windManager_k__BackingField,
			//                   cb,
			//                   v12,
			//                   &v18,
			//                   InterpolatedPhase,
			//                   0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(camera, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3026, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalFoliageInteract(ref ShaderVariablesGlobal cb)
		{
			// // Void UpdateShaderVariablesGlobalFoliageInteract(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageInteract(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3032, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       foliageInteractiveManager_k__BackingField = currentManagerContext.fields._foliageInteractiveManager_k__BackingField;
			//       if ( foliageInteractiveManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGFoliageInteractiveManager::SetupShaderVariablesGlobalFoliageInteract(
			//           foliageInteractiveManager_k__BackingField,
			//           cb,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(foliageInteractiveManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3032, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalRainAndWetness(ref ShaderVariablesGlobal cb, ref ScriptableRenderContext context, HGCamera hgCamera, CommandBuffer cmd)
		{
			// // Void UpdateShaderVariablesGlobalRainAndWetness(ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef, HGCamera, CommandBuffer)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalRainAndWetness(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         ScriptableRenderContext *context,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   HGRainRenderer *s_rainRenderer; // rax
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *rainWetnessGlobalParams; // rcx
			//   CommandBuffer *v13; // rbx
			//   GlobalKeyword *p_s_RainWetnessHighQuality; // rdx
			//   bool enableWetnessHighQuality; // r8
			//   bool success; // [rsp+40h] [rbp-20h] BYREF
			//   RainWetnessGlobalProps *outProps; // [rsp+48h] [rbp-18h] BYREF
			//   __int128 v18; // [rsp+50h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919668 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919668 = 1;
			//   }
			//   outProps = 0LL;
			//   success = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3028, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//     if ( hgCamera && s_rainRenderer )
			//     {
			//       HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessShaderVariables(
			//         s_rainRenderer,
			//         hgCamera,
			//         context,
			//         hgCamera.fields.verticalOcclusionMapManager,
			//         &outProps,
			//         &success,
			//         0LL);
			//       if ( success )
			//       {
			//         if ( outProps )
			//         {
			//           rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps.fields.rainWetnessGlobalParams;
			//           if ( rainWetnessGlobalParams )
			//           {
			//             sub_180037190(rainWetnessGlobalParams, &v18, 0LL);
			//             rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//             *(_OWORD *)&cb[1]._PrevInvViewProjMatrix.m01 = v18;
			//             if ( rainWetnessGlobalParams )
			//             {
			//               rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//               if ( rainWetnessGlobalParams )
			//               {
			//                 sub_180037190(rainWetnessGlobalParams, &v18, 1LL);
			//                 rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                 *(_OWORD *)&cb[1]._PrevInvViewProjMatrix.m02 = v18;
			//                 if ( rainWetnessGlobalParams )
			//                 {
			//                   rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                   if ( rainWetnessGlobalParams )
			//                   {
			//                     sub_180037190(rainWetnessGlobalParams, &v18, 2LL);
			//                     rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                     *(_OWORD *)&cb[1]._PrevInvViewProjMatrix.m03 = v18;
			//                     if ( rainWetnessGlobalParams )
			//                     {
			//                       rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                       if ( rainWetnessGlobalParams )
			//                       {
			//                         sub_180037190(rainWetnessGlobalParams, &v18, 3LL);
			//                         rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                         *(_OWORD *)&cb[1]._PrevNonJitteredInvViewProjMatrix.m00 = v18;
			//                         if ( rainWetnessGlobalParams )
			//                         {
			//                           rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                           if ( rainWetnessGlobalParams )
			//                           {
			//                             sub_180037190(rainWetnessGlobalParams, &v18, 4LL);
			//                             rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                             *(_OWORD *)&cb[1]._PrevNonJitteredInvViewProjMatrix.m01 = v18;
			//                             if ( rainWetnessGlobalParams )
			//                             {
			//                               rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                               if ( rainWetnessGlobalParams )
			//                               {
			//                                 sub_180037190(rainWetnessGlobalParams, &v18, 5LL);
			//                                 rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                                 *(_OWORD *)&cb[1]._PrevNonJitteredInvViewProjMatrix.m02 = v18;
			//                                 if ( rainWetnessGlobalParams )
			//                                 {
			//                                   rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                                   if ( rainWetnessGlobalParams )
			//                                   {
			//                                     sub_180037190(rainWetnessGlobalParams, &v18, 6LL);
			//                                     rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                                     *(_OWORD *)&cb[1]._PrevNonJitteredInvViewProjMatrix.m03 = v18;
			//                                     if ( rainWetnessGlobalParams )
			//                                     {
			//                                       rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                                       if ( rainWetnessGlobalParams )
			//                                       {
			//                                         sub_180037190(rainWetnessGlobalParams, &v18, 7LL);
			//                                         rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                                         *(_OWORD *)&cb[1]._ReprojectionMatrix.m00 = v18;
			//                                         if ( rainWetnessGlobalParams )
			//                                         {
			//                                           rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                                           if ( rainWetnessGlobalParams )
			//                                           {
			//                                             sub_180037190(rainWetnessGlobalParams, &v18, 8LL);
			//                                             rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                                             *(_OWORD *)&cb[1]._ReprojectionMatrix.m01 = v18;
			//                                             if ( rainWetnessGlobalParams )
			//                                             {
			//                                               rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                                               if ( rainWetnessGlobalParams )
			//                                               {
			//                                                 sub_180037190(rainWetnessGlobalParams, &v18, 9LL);
			//                                                 rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
			//                                                 *(_OWORD *)&cb[1]._ReprojectionMatrix.m02 = v18;
			//                                                 if ( rainWetnessGlobalParams )
			//                                                 {
			//                                                   rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams.fields.virtualMachine;
			//                                                   if ( rainWetnessGlobalParams )
			//                                                   {
			//                                                     sub_180037190(rainWetnessGlobalParams, &v18, 10LL);
			//                                                     *(_OWORD *)&cb[1]._ReprojectionMatrix.m03 = v18;
			//                                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//                                                     if ( outProps )
			//                                                     {
			//                                                       v13 = cmd;
			//                                                       if ( cmd )
			//                                                       {
			//                                                         UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//                                                           cmd,
			//                                                           &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_EnableWetness,
			//                                                           outProps.fields.enableWetness,
			//                                                           0LL);
			//                                                         if ( outProps )
			//                                                         {
			//                                                           enableWetnessHighQuality = outProps.fields.enableWetnessHighQuality;
			//                                                           p_s_RainWetnessHighQuality = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_RainWetnessHighQuality;
			//                                                           goto LABEL_35;
			//                                                         }
			//                                                       }
			//                                                     }
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
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
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         v13 = cmd;
			//         if ( cmd )
			//         {
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_EnableWetness,
			//             0,
			//             0LL);
			//           p_s_RainWetnessHighQuality = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_RainWetnessHighQuality;
			//           enableWetnessHighQuality = 0;
			// LABEL_35:
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             v13,
			//             p_s_RainWetnessHighQuality,
			//             enableWetnessHighQuality,
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_37:
			//     sub_180B536AC(rainWetnessGlobalParams, v11);
			//   }
			//   rainWetnessGlobalParams = IFix::WrappersManagerImpl::GetPatch(3028, 0LL);
			//   if ( !rainWetnessGlobalParams )
			//     goto LABEL_37;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1072(
			//     rainWetnessGlobalParams,
			//     (Object *)this,
			//     cb,
			//     context,
			//     (Object *)hgCamera,
			//     (Object *)cmd,
			//     0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalVerticalOcclusionMap(ref ShaderVariablesGlobal cb, HGCamera camera)
		{
			// // Void UpdateShaderVariablesGlobalVerticalOcclusionMap(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalVerticalOcclusionMap(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   bool enabled; // [rsp+30h] [rbp-28h] BYREF
			//   Vector4 param; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   enabled = 0;
			//   param = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3029, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       verticalOcclusionMapManager = camera.fields.verticalOcclusionMapManager;
			//       if ( verticalOcclusionMapManager )
			//       {
			//         HG::Rendering::Runtime::HGVerticalOcclusionMapManager::GetVerticalOcclusionMapShaderVariables(
			//           verticalOcclusionMapManager,
			//           &param,
			//           &enabled,
			//           0LL);
			//         *(Vector4 *)&cb[1]._WiderFoVViewProjMatrix.m00 = param;
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(verticalOcclusionMapManager, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3029, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)camera, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalFoliageOccluder(ref ShaderVariablesGlobal cb)
		{
			// // Void UpdateShaderVariablesGlobalFoliageOccluder(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageOccluder(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   HGFoliageOccluderManager *foliageOccluderManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3031, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       foliageOccluderManager_k__BackingField = currentManagerContext.fields._foliageOccluderManager_k__BackingField;
			//       if ( foliageOccluderManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGFoliageOccluderManager::SetShaderVariablesGlobalFoliageOccluder(
			//           foliageOccluderManager_k__BackingField,
			//           cb,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(foliageOccluderManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3031, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		private void UpdateWaterWetnessMaskParam(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void UpdateWaterWetnessMaskParam(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateWaterWetnessMaskParam(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   float v9; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v11; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919669 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919669 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3030, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3030, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_10;
			//   if ( hgCamera.fields.useWetnessMask )
			//     v9 = 1.0;
			//   else
			//     v9 = 0.0;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   *(__m128i *)&cb[1]._WiderFoVViewProjMatrix.m01 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                                       &v11,
			//                                                                                       v9,
			//                                                                                       0LL));
			// }
			// 
		}

		private void OverrideShaderVariablesGlobal(HGRenderGraph renderGraph, HGCamera targetCamera, bool useScreenSize)
		{
			// // Void OverrideShaderVariablesGlobal(HGRenderGraph, HGCamera, Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGRenderPathScene::OverrideShaderVariablesGlobal(
			//         HGRenderPathScene *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *targetCamera,
			//         bool useScreenSize,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   Object *v12; // rcx
			//   int v13; // eax
			//   unsigned __int64 v14; // r9
			//   unsigned __int64 v15; // r8
			//   signed __int64 v16; // rtt
			//   Object *v17; // r8
			//   unsigned int v18; // r8d
			//   unsigned __int64 v19; // r9
			//   char v20; // r8
			//   signed __int64 v21; // rtt
			//   Object *v22; // rcx
			//   BasicTransformConstants *p_m_basicTransformConstants; // rax
			//   _OWORD *v24; // rcx
			//   __int64 v25; // rdx
			//   __int64 v26; // r8
			//   _OWORD *v27; // rax
			//   _OWORD *v28; // rcx
			//   __int64 v29; // rdx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   Object *v35; // [rsp+30h] [rbp-F38h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+40h] [rbp-F28h] BYREF
			//   HGRenderGraphBuilder v37; // [rsp+60h] [rbp-F08h] BYREF
			//   Il2CppExceptionWrapper *v38; // [rsp+80h] [rbp-EE8h] BYREF
			//   _BYTE v39[3792]; // [rsp+90h] [rbp-ED8h] BYREF
			// 
			//   if ( !byte_18D91966A )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//     sub_18003C530(&off_18D50DC38);
			//     byte_18D91966A = 1;
			//   }
			//   v35 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3046, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3046, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v34, v33);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(
			//       (ILFixDynamicMethodWrapper_13 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)targetCamera,
			//       useScreenSize,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !renderGraph )
			//       sub_180B536AC(v10, v9);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v36,
			//       renderGraph,
			//       (String *)"UpdateShaderVariablesGlobal",
			//       &v35,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
			//     v37 = v36;
			//     v36.m_RenderPass = 0LL;
			//     v36.m_Resources = (HGRenderGraphResourceRegistry *)&v37;
			//     try
			//     {
			//       v12 = v35;
			//       if ( !v35 )
			//         sub_1802DC2C8(0LL, v11);
			//       v35[1].klass = *(Object__Class **)&this[1].fields._.m_shaderVariablesGlobal._PrevViewProjMatrix.m01;
			//       v13 = dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v14 = (((unsigned __int64)&v12[1] >> 12) & 0x1FFFFF) >> 6;
			//         v15 = ((unsigned __int64)&v12[1] >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v14 + 36190]);
			//         do
			//         {
			//           v12 = (Object *)(qword_18D6405E0[v14 + 36190] | (1LL << v15));
			//           v16 = qword_18D6405E0[v14 + 36190];
			//         }
			//         while ( v16 != _InterlockedCompareExchange64(&qword_18D6405E0[v14 + 36190], (signed __int64)v12, v16) );
			//         v13 = dword_18D8E43F8;
			//       }
			//       v17 = v35;
			//       if ( !v35 )
			//         sub_1802DC2C8(v12, qword_18D6405E0);
			//       v35[1].monitor = (MonitorData *)targetCamera;
			//       if ( v13 )
			//       {
			//         v18 = ((unsigned __int64)&v17[1].monitor >> 12) & 0x1FFFFF;
			//         v19 = (unsigned __int64)v18 >> 6;
			//         v20 = v18 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v19 + 36190]);
			//         do
			//           v21 = qword_18D6405E0[v19 + 36190];
			//         while ( v21 != _InterlockedCompareExchange64(&qword_18D6405E0[v19 + 36190], v21 | (1LL << v20), v21) );
			//       }
			//       v22 = v35;
			//       if ( !v35 )
			//         sub_1802DC2C8(0LL, qword_18D6405E0);
			//       LOBYTE(v35[2].klass) = this.fields._._firstBackbufferPass_k__BackingField == 52;
			//       if ( !v35 )
			//         sub_1802DC2C8(v22, qword_18D6405E0);
			//       BYTE1(v35[2].klass) = useScreenSize;
			//       p_m_basicTransformConstants = &this.fields._.m_basicTransformConstants;
			//       v24 = v39;
			//       v25 = 5LL;
			//       v26 = 5LL;
			//       do
			//       {
			//         *v24 = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m00;
			//         v24[1] = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m01;
			//         v24[2] = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m02;
			//         v24[3] = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m03;
			//         v24[4] = *(_OWORD *)&p_m_basicTransformConstants._InvViewMatrix.m00;
			//         v24[5] = *(_OWORD *)&p_m_basicTransformConstants._InvViewMatrix.m01;
			//         v24[6] = *(_OWORD *)&p_m_basicTransformConstants._InvViewMatrix.m02;
			//         v24 += 8;
			//         *(v24 - 1) = *(_OWORD *)&p_m_basicTransformConstants._InvViewMatrix.m03;
			//         p_m_basicTransformConstants = (BasicTransformConstants *)((char *)p_m_basicTransformConstants + 128);
			//         --v26;
			//       }
			//       while ( v26 );
			//       *v24 = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m00;
			//       v24[1] = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m01;
			//       v24[2] = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m02;
			//       v24[3] = *(_OWORD *)&p_m_basicTransformConstants._ViewMatrix.m03;
			//       v24[4] = *(_OWORD *)&p_m_basicTransformConstants._InvViewMatrix.m00;
			//       if ( !v35 )
			//         sub_1802DC2C8(v24, 5LL);
			//       v27 = (_OWORD *)((char *)&v35[2].klass + 4);
			//       v28 = v39;
			//       do
			//       {
			//         *v27 = *v28;
			//         v27[1] = v28[1];
			//         v27[2] = v28[2];
			//         v27[3] = v28[3];
			//         v27[4] = v28[4];
			//         v27[5] = v28[5];
			//         v27[6] = v28[6];
			//         v27 += 8;
			//         *(v27 - 1) = v28[7];
			//         v28 += 8;
			//         --v25;
			//       }
			//       while ( v25 );
			//       *v27 = *v28;
			//       v27[1] = v28[1];
			//       v27[2] = v28[2];
			//       v27[3] = v28[3];
			//       v27[4] = v28[4];
			//       sub_1802EFB40(v39, &this.fields._.m_shaderVariablesGlobal, 3792LL);
			//       if ( !v35 )
			//         sub_1802DC2C8(0LL, v29);
			//       sub_1802EFB40((char *)&v35[47].klass + 4, v39, 3792LL);
			//       if ( !v35 )
			//         sub_1802DC2C8(v31, v30);
			//       *(TextureHandle *)((char *)v35 + 4548) = this.fields._._backBufferColor_k__BackingField;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v37, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v37,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGRenderPathScene.static_fields.s_overrideShaderVariablesGlobalFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v38 )
			//     {
			//       v36.m_RenderPass = (HGRenderGraphPass *)v38.ex;
			//     }
			//     sub_180222690(&v36);
			//   }
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalWaterInteraction(ref ShaderVariablesGlobal cb)
		{
			// // Void UpdateShaderVariablesGlobalWaterInteraction(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWaterInteraction(
			//         HGRenderPathScene *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   float TerrainRippleOpacity; // xmm8_4
			//   HGManagerContext *v9; // rax
			//   HGWaterManager *v10; // rax
			//   float x; // xmm7_4
			//   HGManagerContext *v12; // rax
			//   float y; // xmm6_4
			//   HGManagerContext *v14; // rax
			//   HGWaterManager *v15; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v17[2]; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D91966B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D91966B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3027, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//       if ( waterManager_k__BackingField )
			//       {
			//         TerrainRippleOpacity = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(
			//                                  waterManager_k__BackingField,
			//                                  0LL);
			//         v9 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//         if ( v9 )
			//         {
			//           v10 = v9.fields._waterManager_k__BackingField;
			//           if ( v10 )
			//           {
			//             x = v10.fields.m_centerRippleData.positionXZ.x;
			//             v12 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//             if ( v12 )
			//             {
			//               waterManager_k__BackingField = v12.fields._waterManager_k__BackingField;
			//               if ( waterManager_k__BackingField )
			//               {
			//                 y = waterManager_k__BackingField.fields.m_centerRippleData.positionXZ.y;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                 *(__m128i *)&cb[1]._PrevNonJitteredViewNoTransProjMatrix.m03 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(v17, 32.0, TerrainRippleOpacity, x, y, 0LL));
			//                 v14 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//                 if ( v14 )
			//                 {
			//                   v15 = v14.fields._waterManager_k__BackingField;
			//                   if ( v15 )
			//                   {
			//                     *(__m128i *)&cb[1]._PrevInvViewProjMatrix.m00 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(v17, 0.03125, v15.fields.m_terrainRippleNormalStrength, 0.0, 0.0, 0LL));
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(waterManager_k__BackingField, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3027, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnPreRendering(ref HGRenderPathBase.HGRenderPathParams P0)
		{
			// // Void <>iFixBaseProxy_OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_OnPreRendering(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering((HGRenderPathBase *)this, P0, 0LL);
			// }
			// 
		}

		public bool <>iFixBaseProxy_SkipRender(ref HGRenderPathBase.HGRenderPathParams P0)
		{
			// // Boolean <>iFixBaseProxy_SkipRender(HGRenderPathBase+HGRenderPathParams ByRef)
			// bool HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_SkipRender(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *P0,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::HGRenderPathBase::SkipRender((HGRenderPathBase *)this, P0, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_UpdateShaderVariablesGlobal(HGRenderPipeline P0, HGCamera P1, CommandBuffer P2, ref ShaderVariablesGlobal P3, ref ScriptableRenderContext P4)
		{
			// // Void <>iFixBaseProxy_UpdateShaderVariablesGlobal(HGRenderPipeline, HGCamera, CommandBuffer, ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_UpdateShaderVariablesGlobal(
			//         HGRenderPathScene *this,
			//         HGRenderPipeline *P0,
			//         HGCamera *P1,
			//         CommandBuffer *P2,
			//         ShaderVariablesGlobal *P3,
			//         ScriptableRenderContext *P4,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobal(
			//     (HGRenderPathBase *)this,
			//     P0,
			//     P1,
			//     P2,
			//     P3,
			//     P4,
			//     0LL);
			// }
			// 
		}

		public PassConstructorID <>iFixBaseProxy_FindFirstBackbufferPass()
		{
			// // PassConstructorID <>iFixBaseProxy_FindFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::__iFixBaseProxy_FindFirstBackbufferPass(
			//         HGRenderPathUI *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::HGRenderPathBase::FindFirstBackbufferPass((HGRenderPathBase *)this, 0LL);
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		public void <>iFixBaseProxy_OnPostRendering(ref HGRenderPathBase.HGRenderPathParams P0)
		{
			// // Void <>iFixBaseProxy_OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_OnPostRendering(
			//         HGRenderPathScene *this,
			//         HGRenderPathBase_HGRenderPathParams *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering((HGRenderPathBase *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose(HGRenderGraph P0)
		{
			// // Void <>iFixBaseProxy_Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_Dispose(
			//         HGRenderPathScene *this,
			//         HGRenderGraph *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::HGRenderPathBase::Dispose((HGRenderPathBase *)this, P0, 0LL);
			// }
			// 
		}

		private UIImageBlurPassConstructor m_uiImageBlurPassConstructor;

		private LightShaftApplyPassConstructor m_lightShaftApplyPassConstructor;

		private ParafinPassConstructor m_parafinPassConstructor;

		private DepthOfFieldPassConstructor m_depthOfFieldPassConstructor;

		private MotionBlurPassConstructor m_motionBlurPassConstructor;

		private TransparentAfterDOFPassConstructor m_tranparentAfterDOFPassConstructor;

		private TAAUPassConstructor m_taauPassConstructor;

		private MetalFXTemporalPassConstructor m_metalFXTemporalPassConstructor;

		private LensFlarePassConstructor m_lensFlarePassConstructor;

		private PostProcessPassConstructor m_postProcessPassConstructor;

		private MetalFXSpatialPassConstructor m_metalFXSpatialConstructor;

		private UIPassConstructor m_uiPassConstructor;

		private MultiblurPassConstructor m_multiblurPassConstructor;

		private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor;

		private SetFinalTargetPassConstructor m_setFinalTargetPassConstructor;

		protected ShadowResult shadowResult;

		protected LightShaftPassConstructor.PassOutput lightShaftResult;

		protected uint m_forwardTransparentAfterDOFECSList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<HGRenderPathScene.ShaderVariableOverrideData> s_overrideShaderVariablesGlobalFunc;

		protected enum OtherPassScope
		{
			PrepareData,
			UpdateShaderVariablesGlobal,
			RenderEditorPrimitives,
			WaterSector,
			WaterInteraction,
			WaterPrepass,
			WaterRendering
		}

		private class ShaderVariableOverrideData
		{
			public ShaderVariableOverrideData()
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

			public HGCamera camera;

			public HGCamera targetCamera;

			public bool renderToBackBuffer;

			public bool useScreenSize;

			public BasicTransformConstants basicTransformConstants;

			public ShaderVariablesGlobal shaderVariablesGlobal;

			public TextureHandle backbufferColor;
		}
	}
}
