using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Rain;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPathScene : HGRenderPathBase // TypeDefIndex: 38528
	{
		// Fields
		private UIImageBlurPassConstructor m_uiImageBlurPassConstructor; // 0x1268
		private LightShaftApplyPassConstructor m_lightShaftApplyPassConstructor; // 0x1270
		private ParafinPassConstructor m_parafinPassConstructor; // 0x1278
		private DepthOfFieldPassConstructor m_depthOfFieldPassConstructor; // 0x1280
		private MotionBlurPassConstructor m_motionBlurPassConstructor; // 0x1288
		private TransparentAfterDOFPassConstructor m_tranparentAfterDOFPassConstructor; // 0x1290
		private TAAUPassConstructor m_taauPassConstructor; // 0x1298
		private MetalFXTemporalPassConstructor m_metalFXTemporalPassConstructor; // 0x12A0
		private LensFlarePassConstructor m_lensFlarePassConstructor; // 0x12A8
		private PostProcessPassConstructor m_postProcessPassConstructor; // 0x12B0
		private MetalFXSpatialPassConstructor m_metalFXSpatialConstructor; // 0x12B8
		private UIPassConstructor m_uiPassConstructor; // 0x12C0
		private MultiblurPassConstructor m_multiblurPassConstructor; // 0x12C8
		private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor; // 0x12D0
		private SetFinalTargetPassConstructor m_setFinalTargetPassConstructor; // 0x12D8
		protected ShadowResult shadowResult; // 0x1338
		protected LightShaftPassConstructor.PassOutput lightShaftResult; // 0x1374
		protected uint m_forwardTransparentAfterDOFECSList; // 0x1388
		private static readonly RenderFunc<ShaderVariableOverrideData> s_overrideShaderVariablesGlobalFunc; // 0x00
	
		// Properties
		protected TextureHandle sceneColor { get; set; } // 0x0000000184DA18B0-0x0000000184DA18C0 0x0000000184DA1910-0x0000000184DA1920
		// TextureHandle get_sceneColor()
		TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneColor(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathScene *this,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		
		  result = retstr;
		  *retstr = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		  return result;
		}
		

		// Void set_sceneColor(TextureHandle)
		void HG::Rendering::Runtime::HGRenderPathScene::set_sceneColor(
		        HGRenderPathScene *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = *value;
		}
		
		protected TextureHandle sceneDepth { get; private set; } // 0x0000000184DA18D0-0x0000000184DA18E0 0x0000000184DA1930-0x0000000184DA1940
		// TextureHandle get_sceneDepth()
		TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneDepth(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathScene *this,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		
		  result = retstr;
		  *retstr = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		  return result;
		}
		

		// Void set_sceneDepth(TextureHandle)
		void HG::Rendering::Runtime::HGRenderPathScene::set_sceneDepth(
		        HGRenderPathScene *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00 = *value;
		}
		
		protected TextureHandle sceneMV { get; private set; } // 0x0000000184DA18E0-0x0000000184DA18F0 0x0000000184DA1940-0x0000000184DA1950
		// TextureHandle get_sceneMV()
		TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneMV(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathScene *this,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		
		  result = retstr;
		  *retstr = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		  return result;
		}
		

		// Void set_sceneMV(TextureHandle)
		void HG::Rendering::Runtime::HGRenderPathScene::set_sceneMV(
		        HGRenderPathScene *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = *value;
		}
		
		protected TextureHandle sceneDepthCopied { get; private set; } // 0x0000000184DA18C0-0x0000000184DA18D0 0x0000000184DA1920-0x0000000184DA1930
		// TextureHandle get_sceneDepthCopied()
		TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_sceneDepthCopied(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathScene *this,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		
		  result = retstr;
		  *retstr = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		  return result;
		}
		

		// Void set_sceneDepthCopied(TextureHandle)
		void HG::Rendering::Runtime::HGRenderPathScene::set_sceneDepthCopied(
		        HGRenderPathScene *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02 = *value;
		}
		
		protected HGCamera uiCamera { get; private set; } // 0x0000000184DA18F0-0x0000000184DA1900 0x0000000189C04440-0x0000000189C04574
		// HGCamera get_uiCamera()
		HGCamera *HG::Rendering::Runtime::HGRenderPathScene::get_uiCamera(HGRenderPathScene *this, MethodInfo *method)
		{
		  return *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		}
		

		// Void set_uiCamera(HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::set_uiCamera(
		        HGRenderPathScene *this,
		        HGCamera *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 = value;
		  sub_18002D1B0(
		    (HGRenderPathOnePassDeferred *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03,
		    (HGRenderPathBase_HGRenderPathResources *)value,
		    (HGCamera *)method,
		    v3,
		    v4);
		}
		
		protected TextureHandle historySceneColor { get; private set; } // 0x0000000184DA18A0-0x0000000184DA18B0 0x0000000184DA1900-0x0000000184DA1910
		// TextureHandle get_historySceneColor()
		TextureHandle *HG::Rendering::Runtime::HGRenderPathScene::get_historySceneColor(
		        TextureHandle *__return_ptr retstr,
		        HGRenderPathScene *this,
		        MethodInfo *method)
		{
		  TextureHandle *result; // rax
		
		  result = retstr;
		  *retstr = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		  return result;
		}
		

		// Void set_historySceneColor(TextureHandle)
		void HG::Rendering::Runtime::HGRenderPathScene::set_historySceneColor(
		        HGRenderPathScene *this,
		        TextureHandle *value,
		        MethodInfo *method)
		{
		  *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = *value;
		}
		
	
		// Nested types
		protected enum OtherPassScope // TypeDefIndex: 38525
		{
			PrepareData = 0,
			UpdateShaderVariablesGlobal = 1,
			RenderEditorPrimitives = 2,
			WaterSector = 3,
			WaterInteraction = 4,
			WaterPrepass = 5,
			WaterRendering = 6
		}
	
		private class ShaderVariableOverrideData // TypeDefIndex: 38526
		{
			// Fields
			public HGCamera camera; // 0x10
			public HGCamera targetCamera; // 0x18
			public bool renderToBackBuffer; // 0x20
			public bool useScreenSize; // 0x21
			public BasicTransformConstants basicTransformConstants; // 0x24
			public ShaderVariablesGlobal shaderVariablesGlobal; // 0x544
			public UIShaderVariablesGlobal uiShaderVariablesGlobal; // 0x11C4
			public TextureHandle backbufferColor; // 0x1204
	
			// Constructors
			public ShaderVariableOverrideData() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		// Constructors
		protected HGRenderPathScene() {} // Dummy constructor
		internal HGRenderPathScene(HGRenderPathResources resources, PassConstructorID[] passConstructorIDs, HGCamera camera, HGRenderPathInternal renderPath) {} // 0x0000000182ED94E0-0x0000000182ED9920
		// HGRenderPathScene(HGRenderPathBase+HGRenderPathResources, PassConstructorID[], HGCamera, HGRenderPathInternal)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGRenderPathScene::HGRenderPathScene(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        PassConstructorID__Enum__Array *passConstructorIDs,
		        HGCamera *camera,
		        HGRenderPathInternal__Enum renderPath,
		        MethodInfo *method)
		{
		  IPassConstructor *PassConstructor; // rbx
		  HGRenderPathBase_HGRenderPathResources *v8; // rdx
		  PassConstructorID__Enum__Array *v9; // r8
		  Int32__Array **v10; // r9
		  IPassConstructor *v11; // rbx
		  HGRenderPathBase_HGRenderPathResources *v12; // rdx
		  PassConstructorID__Enum__Array *v13; // r8
		  Int32__Array **v14; // r9
		  IPassConstructor *v15; // rbx
		  HGRenderPathBase_HGRenderPathResources *v16; // rdx
		  PassConstructorID__Enum__Array *v17; // r8
		  Int32__Array **v18; // r9
		  IPassConstructor *v19; // rbx
		  HGRenderPathBase_HGRenderPathResources *v20; // rdx
		  PassConstructorID__Enum__Array *v21; // r8
		  Int32__Array **v22; // r9
		  IPassConstructor *v23; // rbx
		  HGRenderPathBase_HGRenderPathResources *v24; // rdx
		  PassConstructorID__Enum__Array *v25; // r8
		  Int32__Array **v26; // r9
		  IPassConstructor *v27; // rbx
		  HGRenderPathBase_HGRenderPathResources *v28; // rdx
		  PassConstructorID__Enum__Array *v29; // r8
		  Int32__Array **v30; // r9
		  IPassConstructor *v31; // rbx
		  HGRenderPathBase_HGRenderPathResources *v32; // rdx
		  PassConstructorID__Enum__Array *v33; // r8
		  Int32__Array **v34; // r9
		  IPassConstructor *v35; // rbx
		  HGRenderPathBase_HGRenderPathResources *v36; // rdx
		  PassConstructorID__Enum__Array *v37; // r8
		  Int32__Array **v38; // r9
		  IPassConstructor *v39; // rbx
		  HGRenderPathBase_HGRenderPathResources *v40; // rdx
		  PassConstructorID__Enum__Array *v41; // r8
		  Int32__Array **v42; // r9
		  IPassConstructor *v43; // rbx
		  HGRenderPathBase_HGRenderPathResources *v44; // rdx
		  PassConstructorID__Enum__Array *v45; // r8
		  Int32__Array **v46; // r9
		  IPassConstructor *v47; // rbx
		  HGRenderPathBase_HGRenderPathResources *v48; // rdx
		  PassConstructorID__Enum__Array *v49; // r8
		  Int32__Array **v50; // r9
		  IPassConstructor *v51; // rbx
		  HGRenderPathBase_HGRenderPathResources *v52; // rdx
		  PassConstructorID__Enum__Array *v53; // r8
		  Int32__Array **v54; // r9
		  IPassConstructor *v55; // rbx
		  HGRenderPathBase_HGRenderPathResources *v56; // rdx
		  PassConstructorID__Enum__Array *v57; // r8
		  Int32__Array **v58; // r9
		  IPassConstructor *v59; // rbx
		  HGRenderPathBase_HGRenderPathResources *v60; // rdx
		  PassConstructorID__Enum__Array *v61; // r8
		  Int32__Array **v62; // r9
		  IPassConstructor *v63; // rbx
		  HGRenderPathBase_HGRenderPathResources *v64; // rdx
		  PassConstructorID__Enum__Array *v65; // r8
		  Int32__Array **v66; // r9
		  MethodInfo *v67; // [rsp+20h] [rbp-28h]
		  MethodInfo *v68; // [rsp+20h] [rbp-28h]
		  MethodInfo *v69; // [rsp+20h] [rbp-28h]
		  MethodInfo *v70; // [rsp+20h] [rbp-28h]
		  MethodInfo *v71; // [rsp+20h] [rbp-28h]
		  MethodInfo *v72; // [rsp+20h] [rbp-28h]
		  MethodInfo *v73; // [rsp+20h] [rbp-28h]
		  MethodInfo *v74; // [rsp+20h] [rbp-28h]
		  MethodInfo *v75; // [rsp+20h] [rbp-28h]
		  MethodInfo *v76; // [rsp+20h] [rbp-28h]
		  MethodInfo *v77; // [rsp+20h] [rbp-28h]
		  MethodInfo *v78; // [rsp+20h] [rbp-28h]
		  MethodInfo *v79; // [rsp+20h] [rbp-28h]
		  MethodInfo *v80; // [rsp+20h] [rbp-28h]
		  MethodInfo *v81; // [rsp+28h] [rbp-20h]
		  MethodInfo *v82; // [rsp+28h] [rbp-20h]
		  MethodInfo *v83; // [rsp+28h] [rbp-20h]
		  MethodInfo *v84; // [rsp+28h] [rbp-20h]
		  MethodInfo *v85; // [rsp+28h] [rbp-20h]
		  MethodInfo *v86; // [rsp+28h] [rbp-20h]
		  MethodInfo *v87; // [rsp+28h] [rbp-20h]
		  MethodInfo *v88; // [rsp+28h] [rbp-20h]
		  MethodInfo *v89; // [rsp+28h] [rbp-20h]
		  MethodInfo *v90; // [rsp+28h] [rbp-20h]
		  MethodInfo *v91; // [rsp+28h] [rbp-20h]
		  MethodInfo *v92; // [rsp+28h] [rbp-20h]
		  MethodInfo *v93; // [rsp+28h] [rbp-20h]
		  MethodInfo *v94; // [rsp+28h] [rbp-20h]
		  HGRenderPathBase_HGRenderPathResources v95; // [rsp+30h] [rbp-18h] BYREF
		
		  v95 = *resources;
		  this[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21 = NAN;
		  HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
		    (HGRenderPathBase *)this,
		    &v95,
		    passConstructorIDs,
		    camera,
		    renderPath,
		    0LL);
		  PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                      (HGRenderPathBase *)this,
		                      PassConstructorID__Enum_UIImageBlur,
		                      0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m23 = sub_180005050(
		                                                                                     PassConstructor,
		                                                                                     TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		  sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4712), v8, v9, v10, v67, v81);
		  v11 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_LightShaftApply,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00 = sub_180005050(
		                                                                                            v11,
		                                                                                            TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
		  sub_180005050(v11, TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4720), v12, v13, v14, v68, v82);
		  v15 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Parafin,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20 = sub_180005050(
		                                                                                            v15,
		                                                                                            TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
		  sub_180005050(v15, TypeInfo::HG::Rendering::Runtime::ParafinPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4728), v16, v17, v18, v69, v83);
		  v19 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_DepthOfField,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m01 = sub_180005050(
		                                                                                            v19,
		                                                                                            TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
		  sub_180005050(v19, TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4736), v20, v21, v22, v70, v84);
		  v23 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_MotionBlur,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m21 = sub_180005050(
		                                                                                            v23,
		                                                                                            TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
		  sub_180005050(v23, TypeInfo::HG::Rendering::Runtime::MotionBlurPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4744), v24, v25, v26, v71, v85);
		  v27 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TransparentAfterDOF,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m02 = sub_180005050(
		                                                                                            v27,
		                                                                                            TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
		  sub_180005050(v27, TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4752), v28, v29, v30, v72, v86);
		  v31 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_TAAU,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m22 = sub_180005050(
		                                                                                            v31,
		                                                                                            TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		  sub_180005050(v31, TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4760), v32, v33, v34, v73, v87);
		  v35 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_MetalFXTemporal,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m03 = sub_180005050(
		                                                                                            v35,
		                                                                                            TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
		  sub_180005050(v35, TypeInfo::HG::Rendering::Runtime::MetalFXTemporalPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4768), v36, v37, v38, v74, v88);
		  v39 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_LensFlare,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m23 = sub_180005050(
		                                                                                            v39,
		                                                                                            TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		  sub_180005050(v39, TypeInfo::HG::Rendering::Runtime::LensFlarePassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4776), v40, v41, v42, v75, v89);
		  v43 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_UberPost,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00 = sub_180005050(
		                                                                                                v43,
		                                                                                                TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
		  sub_180005050(v43, TypeInfo::HG::Rendering::Runtime::PostProcessPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4784), v44, v45, v46, v76, v90);
		  v47 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_MetalFXSpatial,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m20 = sub_180005050(
		                                                                                                v47,
		                                                                                                TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
		  sub_180005050(v47, TypeInfo::HG::Rendering::Runtime::MetalFXSpatialPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4792), v48, v49, v50, v77, v91);
		  v51 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_UI,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m01 = sub_180005050(
		                                                                                                v51,
		                                                                                                TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		  sub_180005050(v51, TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4800), v52, v53, v54, v78, v92);
		  v55 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_Multiblur,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21 = sub_180005050(
		                                                                                                v55,
		                                                                                                TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		  sub_180005050(v55, TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4808), v56, v57, v58, v79, v93);
		  v59 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_ScreenSpaceOverlay,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02 = sub_180005050(
		                                                                                                v59,
		                                                                                                TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		  sub_180005050(v59, TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4816), v60, v61, v62, v80, v94);
		  v63 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		          (HGRenderPathBase *)this,
		          PassConstructorID__Enum_SetFinalTarget,
		          0LL);
		  *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m22 = sub_180005050(
		                                                                                                v63,
		                                                                                                TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
		  sub_180005050(v63, TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
		  sub_18002D1B0((HGRenderPathScene *)((char *)this + 4824), v64, v65, v66, *(MethodInfo **)&renderPath, method);
		}
		
		static HGRenderPathScene() {} // 0x0000000184D2CD60-0x0000000184D2CDF0
		// HGRenderPathScene()
		void HG::Rendering::Runtime::HGRenderPathScene::cctor(MethodInfo *method)
		{
		  struct HGRenderPathScene_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_HGRenderPathScene_ShaderVariableOverrideData_ *v6; // rbx
		  HGRenderPathBase_HGRenderPathResources *v7; // rdx
		  PassConstructorID__Enum__Array *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		  MethodInfo *v11; // [rsp+58h] [rbp+30h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGRenderPathScene::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGRenderPathScene::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_HGRenderPathScene_ShaderVariableOverrideData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::HGRenderPathScene::__c::__cctor_b__78_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::HGRenderPathScene->static_fields->s_overrideShaderVariablesGlobalFunc = v6;
		  sub_18002D1B0(
		    (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGRenderPathScene->static_fields,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11);
		}
		
	
		// Methods
		protected override bool SkipRender(ref HGRenderPathParams renderPathParams) => default; // 0x0000000189C028A4-0x0000000189C0291C
		// Boolean SkipRender(HGRenderPathBase+HGRenderPathParams ByRef)
		bool HG::Rendering::Runtime::HGRenderPathScene::SkipRender(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Camera *v6; // rcx
		  __int64 v7; // rax
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3618, 0LL) )
		  {
		    v7 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    if ( v7 )
		    {
		      v6 = *(Camera **)(v7 + 96);
		      if ( v6 )
		      {
		        result = UnityEngine::Camera::get_cullingMask(v6, 0LL) == 0;
		        renderPathParams->skipRender = result;
		        return result;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3618, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_446(Patch, (Object *)this, renderPathParams, 0LL);
		}
		
		protected override void UpdateShaderVariablesGlobal(HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd, ref ShaderVariablesGlobal shaderVariablesGlobal, ref ScriptableRenderContext context) {} // 0x0000000189C03FB4-0x0000000189C04298
		// Void UpdateShaderVariablesGlobal(HGRenderPipeline, HGCamera, CommandBuffer, ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobal(
		        HGRenderPathScene *this,
		        HGRenderPipeline *hgrp,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        ScriptableRenderContext *context,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *erosionBlend_k__BackingField; // rcx
		  HGSettingParameters *settingParameters_k__BackingField; // r15
		  HGRainRenderer *s_rainRenderer; // rax
		  RainCommonPreSettingParam *CurrentPresettingParams; // rax
		  float v16; // xmm0_4
		  float v17; // xmm1_4
		  float v18; // xmm0_4
		  float v19; // xmm3_4
		  Vector4 v20; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3619, 0LL) )
		  {
		    HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobal(
		      (HGRenderPathBase *)this,
		      hgrp,
		      camera,
		      cmd,
		      shaderVariablesGlobal,
		      context,
		      0LL);
		    if ( hgrp )
		    {
		      settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		      HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		      HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalMaterialStylizer(
		        this,
		        shaderVariablesGlobal,
		        camera,
		        0LL);
		      HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalEnvironment(
		        this,
		        shaderVariablesGlobal,
		        camera,
		        0LL);
		      HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCloudShadow(
		        this,
		        shaderVariablesGlobal,
		        camera,
		        0LL);
		      HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGraphFeaturesGlobalParam0(
		        this,
		        shaderVariablesGlobal,
		        camera,
		        settingParameters_k__BackingField,
		        0LL);
		      if ( settingParameters_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalAtmosphere(
		          this,
		          shaderVariablesGlobal,
		          camera,
		          cmd,
		          settingParameters_k__BackingField->fields._atmosphereParams_k__BackingField,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		        if ( s_rainRenderer )
		        {
		          CurrentPresettingParams = HG::Rendering::Runtime::HGRainRenderer::GetCurrentPresettingParams(
		                                      s_rainRenderer,
		                                      0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCharacter(
		            this,
		            shaderVariablesGlobal,
		            camera,
		            cmd,
		            CurrentPresettingParams,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWind(
		            this,
		            shaderVariablesGlobal,
		            camera,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWaterInteraction(
		            this,
		            shaderVariablesGlobal,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalRainAndWetness(
		            this,
		            shaderVariablesGlobal,
		            context,
		            camera,
		            cmd,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalVerticalOcclusionMap(
		            this,
		            shaderVariablesGlobal,
		            camera,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateWaterWetnessMaskParam(
		            this,
		            shaderVariablesGlobal,
		            camera,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageOccluder(
		            this,
		            shaderVariablesGlobal,
		            0LL);
		          HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageInteract(
		            this,
		            shaderVariablesGlobal,
		            0LL);
		          erosionBlend_k__BackingField = (ILFixDynamicMethodWrapper_2 *)settingParameters_k__BackingField->fields._erosionBlend_k__BackingField;
		          if ( erosionBlend_k__BackingField )
		          {
		            v16 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                    (SettingParameter_1_System_Boolean_ *)erosionBlend_k__BackingField->fields.virtualMachine,
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		                ? 1.0
		                : 0.0;
		            shaderVariablesGlobal[1].unity_OrthoParams.x = v16;
		            if ( camera )
		            {
		              shaderVariablesGlobal->_ScreenSize = (Vector4)_mm_loadu_si128((const __m128i *)&camera->fields._sceneRTSizeParam_k__BackingField);
		              shaderVariablesGlobal->_BackBufferSize = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGCamera::get_finalRTSizeParam(
		                                                                                                   &v20,
		                                                                                                   camera,
		                                                                                                   0LL));
		              LODWORD(v17) = _mm_loadu_si128((const __m128i *)&camera->fields._sceneRTSizeParam_k__BackingField).m128i_u32[0];
		              v18 = camera->fields._sceneRTSizeParam_k__BackingField.z + 1.0;
		              v19 = camera->fields._sceneRTSizeParam_k__BackingField.w + 1.0;
		              v20.y = camera->fields._sceneRTSizeParam_k__BackingField.y;
		              v20.x = v17;
		              v20.z = v18;
		              v20.w = v19;
		              shaderVariablesGlobal->_ScreenParams = v20;
		              shaderVariablesGlobal->_WindMotorParams0.FixedElementField = *(float *)_mm_loadu_si128((const __m128i *)&camera->fields._sceneRTSizeParam_k__BackingField).m128i_i32
		                                                                         / camera->fields._sceneRTSizeParam_k__BackingField.y;
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(erosionBlend_k__BackingField, v11);
		  }
		  erosionBlend_k__BackingField = IFix::WrappersManagerImpl::GetPatch(3619, 0LL);
		  if ( !erosionBlend_k__BackingField )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_450(
		    erosionBlend_k__BackingField,
		    (Object *)this,
		    (Object *)hgrp,
		    (Object *)camera,
		    (Object *)cmd,
		    shaderVariablesGlobal,
		    context,
		    0LL);
		}
		
		protected override void OnPreRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BFE1B0-0x0000000189BFF33C
		// Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::OnPreRendering(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  char *textures; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r12
		  HGRenderGraph *renderGraph; // r15
		  GraphicsFormat__Enum ColorBufferFormat; // eax
		  HGRenderPathBase_HGRenderPathResources *v10; // rdx
		  PassConstructorID__Enum__Array *v11; // r8
		  Int32__Array **v12; // r9
		  HGCamera *v13; // r13
		  bool msaaEnabled; // al
		  Vector2Int *v15; // rbx
		  bool v16; // si
		  Vector2Int v17; // rbx
		  TextureHandle *v18; // rax
		  bool clearDepth; // al
		  Vector2Int *v20; // r9
		  TextureHandle *nullHandle; // rax
		  Vector2Int *v22; // rbx
		  Vector2Int v23; // rbx
		  CommandBuffer *commandBuffer; // rdi
		  int32_t GlintPatternTexture; // ebx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  RenderTargetIdentifier *v27; // rax
		  HGRenderPipelineRuntimeResources_TextureResources *v28; // rdx
		  __int64 v29; // rcx
		  __int128 v30; // xmm1
		  int32_t PerlinNoiseTex; // ebx
		  HGRenderPipelineRuntimeResources *v32; // rax
		  RenderTargetIdentifier *v33; // rax
		  __int128 v34; // xmm1
		  int32_t SnowDetailNormalTex; // ebx
		  HGRenderPipelineRuntimeResources *v36; // rax
		  HGRenderPipelineRuntimeResources_TextureResources *v37; // rdx
		  __int64 v38; // rcx
		  RenderTargetIdentifier *v39; // rax
		  __int128 v40; // xmm1
		  __int64 v41; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  int32_t VerticalOcclusionMap; // ebx
		  HGRenderGraphDefaultResources *v44; // rax
		  RTHandle *defaultShadowTextureRTHandle; // rax
		  RenderTargetIdentifier *v46; // rax
		  __int128 v47; // xmm1
		  HGRenderPipelineAsset *asset; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  HGRenderPipelineRuntimeResources *renderPipelineResources; // rax
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rsi
		  Object_1 *rainPresettingAsset; // rsi
		  int32_t v54; // ebx
		  HGRenderGraphDefaultResources *v55; // rax
		  TextureHandle v56; // xmm6
		  RenderTargetIdentifier *v57; // rax
		  __int128 v58; // xmm1
		  int32_t v59; // ebx
		  HGRenderGraphDefaultResources *v60; // rax
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  RenderTargetIdentifier *v63; // rax
		  __int128 v64; // xmm1
		  int32_t v65; // ebx
		  Texture *v66; // rax
		  RenderTargetIdentifier *v67; // rax
		  __int128 v68; // xmm1
		  int32_t v69; // ebx
		  HGRenderGraphDefaultResources *v70; // rax
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  RenderTargetIdentifier *v73; // rax
		  __int128 v74; // xmm1
		  int32_t v75; // ebx
		  HGRenderGraphDefaultResources *v76; // rax
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  RenderTargetIdentifier *v79; // rax
		  __int128 v80; // xmm1
		  int32_t v81; // ebx
		  HGRenderGraphDefaultResources *v82; // rax
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  RenderTargetIdentifier *v85; // rax
		  __int128 v86; // xmm1
		  int32_t CharacterRainFaceDropletTex; // ebx
		  HGRenderGraphDefaultResources *v88; // rax
		  __int64 v89; // rdx
		  __int64 v90; // rcx
		  RenderTargetIdentifier *v91; // rax
		  RenderTargetIdentifier *v92; // r8
		  __int128 v93; // xmm1
		  Object_1__Class *klass; // rbx
		  Object_1 *v95; // rbx
		  int32_t VerticalFlowTexture; // ebx
		  HGRenderGraphDefaultResources *v97; // rax
		  TextureHandle blackTexture_k__BackingField; // xmm6
		  RenderTargetIdentifier *v99; // rax
		  __int128 v100; // xmm1
		  Object_1__Class *v101; // rbx
		  Object_1 *genericContainerHandle; // rbx
		  int32_t RippleTexture; // ebx
		  HGRenderGraphDefaultResources *v104; // rax
		  TextureHandle v105; // xmm6
		  RenderTargetIdentifier *v106; // rax
		  __int128 v107; // xmm1
		  Object_1__Class *v108; // rbx
		  Object_1 *v109; // rbx
		  int32_t RainOcclusionSampleNoise; // ebx
		  Texture *blackTexture3D; // rdx
		  RenderTargetIdentifier *v112; // rax
		  __int128 v113; // xmm1
		  Object_1__Class *v114; // rbx
		  Object_1 *methodPtr; // rbx
		  int32_t CharacterRainEffectTex; // ebx
		  HGRenderGraphDefaultResources *v117; // rax
		  TextureHandle v118; // xmm6
		  RenderTargetIdentifier *v119; // rax
		  __int128 v120; // xmm1
		  Object_1__Class *v121; // rbx
		  Object_1 *v122; // rbx
		  int32_t CharacterRainStreakTex; // ebx
		  HGRenderGraphDefaultResources *v124; // rax
		  TextureHandle v125; // xmm6
		  RenderTargetIdentifier *v126; // rax
		  __int128 v127; // xmm1
		  Object_1__Class *v128; // rbx
		  Object_1 *v129; // rbx
		  int32_t CharacterRainFaceDripTex; // ebx
		  HGRenderGraphDefaultResources *v131; // rax
		  TextureHandle v132; // xmm6
		  RenderTargetIdentifier *v133; // rax
		  __int128 v134; // xmm1
		  Object_1__Class *v135; // rbx
		  Object_1 *v136; // rbx
		  HGRenderGraphDefaultResources *v137; // rax
		  TextureHandle v138; // xmm6
		  RenderTargetIdentifier *v139; // rax
		  __int128 v140; // xmm1
		  HGRenderPipelineAsset *v141; // rax
		  HGRenderPipelineRuntimeResources *v142; // rax
		  HGRenderPipelineRuntimeResources_AssetResources *v143; // rsi
		  Object_1 *snowPresettingAsset; // rsi
		  Object_1__Class *v145; // rbx
		  Object_1 *element_class; // rbx
		  int32_t CharacterSnowEffectTex; // ebx
		  RenderTargetIdentifier *v148; // rax
		  HGRenderGraphDefaultResources *v149; // rax
		  TextureHandle v150; // xmm6
		  __int128 v151; // xmm1
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGCharacterVolume *m_hgCharacterVolume; // rbx
		  int32_t v154; // esi
		  Texture *v155; // rax
		  RenderTargetIdentifier *v156; // rax
		  int32_t v157; // edx
		  __int128 v158; // xmm1
		  int32_t CharMaxCubemap; // ebx
		  Texture *blackCubeTexture; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v162; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v163; // [rsp+30h] [rbp-D8h]
		  TextureHandle v164; // [rsp+48h] [rbp-C0h] BYREF
		  RenderTargetIdentifier v165; // [rsp+58h] [rbp-B0h] BYREF
		  RenderTargetIdentifier v166; // [rsp+88h] [rbp-80h] BYREF
		  RenderTargetIdentifier v167; // [rsp+B8h] [rbp-50h] BYREF
		  TextureDesc v168; // [rsp+E8h] [rbp-20h] BYREF
		  TextureDesc v169; // [rsp+148h] [rbp+40h] BYREF
		  GraphicsFormat__Enum v170; // [rsp+200h] [rbp+F8h]
		
		  sub_18033B9D0(&v169, 0LL, 96LL);
		  sub_18033B9D0(&v168, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3575, 0LL) )
		  {
		    HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering((HGRenderPathBase *)this, renderPathParams, 0LL);
		    hgrp = renderPathParams->hgrp;
		    if ( !hgrp )
		      goto LABEL_107;
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(renderPathParams->hgrp, 0LL);
		    ColorBufferFormat = HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferFormat(
		                          hgrp,
		                          *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		                          0LL);
		    v6 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    v170 = ColorBufferFormat;
		    if ( !v6 )
		      goto LABEL_107;
		    *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera((HGCamera *)v6, 0LL);
		    sub_18002D1B0((HGRenderPathScene *)((char *)this + 4896), v10, v11, v12, v162, v163);
		    v13 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    v6 = (__int64)v13;
		    if ( !v13 )
		      goto LABEL_107;
		    msaaEnabled = HG::Rendering::Runtime::HGCamera::get_msaaEnabled(v13, 0LL);
		    v15 = *(Vector2Int **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    v16 = msaaEnabled;
		    if ( !v15 )
		      goto LABEL_107;
		    v17 = v15[6];
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v18 = HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(&v164, renderGraph, v13, v16, v170, v17, 0LL);
		    v6 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = *v18;
		    if ( !v6 )
		      goto LABEL_107;
		    clearDepth = HG::Rendering::Runtime::HGCamera::get_clearDepth((HGCamera *)v6, 0LL);
		    v20 = *(Vector2Int **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    if ( !v20 )
		      goto LABEL_107;
		    *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(&v164, renderGraph, clearDepth, (MSAASamples__Enum)v20[209].m_X, (DepthBits__Enum)renderPathParams->perFrameSetup.depthBits, (GraphicsFormat__Enum)renderPathParams->perFrameSetup.depthGraphicsFormat, v20[6], 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v164, 0LL);
		    v6 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = *nullHandle;
		    if ( !v6 )
		      goto LABEL_107;
		    if ( HG::Rendering::Runtime::HGCamera::get_enableMV((HGCamera *)v6, 0LL) )
		    {
		      textures = *(char **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !textures )
		        goto LABEL_107;
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v168, *(Vector2Int *)(textures + 48), 0LL);
		      v6 = 1LL;
		      v168.fastMemoryDesc.residencyFraction = 1.0;
		      *(_QWORD *)&v164.handle._type_k__BackingField = 1LL;
		      v164.handle.m_Value = 1;
		      *(ResourceHandle *)&v168.fastMemoryDesc.inFastMemory = v164.handle;
		      v168.slices = 1;
		      v168.colorFormat = 75;
		      v168.dimension = 2;
		      v168.msaaSamples = 1;
		      v169 = v168;
		      v168.clearColor = (Color)_mm_load_si128((const __m128i *)&xmmword_18DC80F80);
		      if ( !renderGraph )
		        goto LABEL_107;
		      *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v164, renderGraph, &v169, 0LL);
		    }
		    v22 = *(Vector2Int **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    if ( !v22 )
		      goto LABEL_107;
		    v23 = v22[6];
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(&v164, renderGraph, v23, 0LL);
		    commandBuffer = renderPathParams->renderGraphParams.commandBuffer;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    GlintPatternTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_GlintPatternTexture;
		    defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		    if ( !defaultResources )
		      goto LABEL_107;
		    textures = (char *)defaultResources->fields.textures;
		    if ( !textures )
		      goto LABEL_107;
		    v27 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v165, *((Texture **)textures + 8), 0LL);
		    if ( !commandBuffer )
		      goto LABEL_105;
		    v30 = *(_OWORD *)&v27->m_BufferPointer;
		    *(_OWORD *)&v166.m_Type = *(_OWORD *)&v27->m_Type;
		    *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v27->m_DepthSlice;
		    *(_OWORD *)&v166.m_BufferPointer = v30;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, GlintPatternTexture, &v166, 0LL);
		    PerlinNoiseTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PerlinNoiseTex;
		    v32 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		    if ( !v32 || (v28 = v32->fields.textures) == 0LL )
		LABEL_105:
		      sub_1800D8260(v29, v28);
		    v33 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v165, (Texture *)v28->fields.PerlinNoiseTex, 0LL);
		    v34 = *(_OWORD *)&v33->m_BufferPointer;
		    *(_OWORD *)&v166.m_Type = *(_OWORD *)&v33->m_Type;
		    *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v33->m_DepthSlice;
		    *(_OWORD *)&v166.m_BufferPointer = v34;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, PerlinNoiseTex, &v166, 0LL);
		    SnowDetailNormalTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SnowDetailNormalTex;
		    v36 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
		    if ( !v36 || (v37 = v36->fields.textures) == 0LL )
		      sub_1800D8260(v38, v37);
		    v39 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		            &v165,
		            (Texture *)v37->fields.SnowDetailNormal,
		            0LL);
		    v40 = *(_OWORD *)&v39->m_BufferPointer;
		    *(_OWORD *)&v166.m_Type = *(_OWORD *)&v39->m_Type;
		    *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v39->m_DepthSlice;
		    *(_OWORD *)&v166.m_BufferPointer = v40;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, SnowDetailNormalTex, &v166, 0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    VerticalOcclusionMap = static_fields->_VerticalOcclusionMap;
		    if ( !renderGraph
		      || (v44 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL)) == 0LL )
		    {
		      sub_1800D8260(static_fields, v41);
		    }
		    defaultShadowTextureRTHandle = HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::get_defaultShadowTextureRTHandle(
		                                     v44,
		                                     0LL);
		    v46 = UnityEngine::Rendering::RTHandle::op_Implicit(&v165, defaultShadowTextureRTHandle, 0LL);
		    v47 = *(_OWORD *)&v46->m_BufferPointer;
		    *(_OWORD *)&v166.m_Type = *(_OWORD *)&v46->m_Type;
		    *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v46->m_DepthSlice;
		    *(_OWORD *)&v166.m_BufferPointer = v47;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, VerticalOcclusionMap, &v166, 0LL);
		    asset = HG::Rendering::Runtime::HGRenderPipeline::get_asset(hgrp, 0LL);
		    if ( !asset
		      || (renderPipelineResources = HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderPipelineResources(
		                                      asset,
		                                      0LL)) == 0LL
		      || (assets = renderPipelineResources->fields.assets) == 0LL )
		    {
		      sub_1800D8260(v50, v49);
		    }
		    rainPresettingAsset = (Object_1 *)assets->fields.rainPresettingAsset;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(rainPresettingAsset, 0LL, 0LL) )
		    {
		      if ( !rainPresettingAsset )
		        goto LABEL_107;
		      klass = rainPresettingAsset[1].klass;
		      if ( !klass )
		        goto LABEL_107;
		      v95 = *(Object_1 **)&klass->_1.initializationExceptionGCHandle;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(v95, 0LL, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        VerticalFlowTexture = *(_DWORD *)(v6 + 3320);
		        if ( !textures )
		          goto LABEL_107;
		        v99 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 27), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        VerticalFlowTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFlowTexture;
		        v97 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v97 )
		          goto LABEL_107;
		        blackTexture_k__BackingField = v97->fields._blackTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v164 = blackTexture_k__BackingField;
		        v99 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		      }
		      v100 = *(_OWORD *)&v99->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v99->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v99->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v100;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, VerticalFlowTexture, &v165, 0LL);
		      v101 = rainPresettingAsset[1].klass;
		      if ( !v101 )
		        goto LABEL_107;
		      genericContainerHandle = (Object_1 *)v101->_1.genericContainerHandle;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(genericContainerHandle, 0LL, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        RippleTexture = *(_DWORD *)(v6 + 3324);
		        if ( !textures )
		          goto LABEL_107;
		        v106 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 30), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        RippleTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RippleTexture;
		        v104 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v104 )
		          goto LABEL_107;
		        v105 = v104->fields._blackTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v164 = v105;
		        v106 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		      }
		      v107 = *(_OWORD *)&v106->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v106->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v106->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v107;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, RippleTexture, &v165, 0LL);
		      v108 = rainPresettingAsset[1].klass;
		      if ( !v108 )
		        goto LABEL_107;
		      v109 = *(Object_1 **)&v108->_1.naturalAligment;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(v109, 0LL, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        RainOcclusionSampleNoise = *(_DWORD *)(v6 + 3316);
		        if ( !textures )
		          goto LABEL_107;
		        blackTexture3D = (Texture *)*((_QWORD *)textures + 38);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        RainOcclusionSampleNoise = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainOcclusionSampleNoise;
		        blackTexture3D = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		      }
		      v112 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, blackTexture3D, 0LL);
		      v113 = *(_OWORD *)&v112->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v112->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v112->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v113;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, RainOcclusionSampleNoise, &v165, 0LL);
		      v114 = rainPresettingAsset[1].klass;
		      if ( !v114 )
		        goto LABEL_107;
		      methodPtr = (Object_1 *)v114->vtable.Finalize.methodPtr;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(0LL, methodPtr, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        CharacterRainEffectTex = *(_DWORD *)(v6 + 532);
		        if ( !textures )
		          goto LABEL_107;
		        v119 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 41), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        CharacterRainEffectTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainEffectTex;
		        v117 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v117 )
		          goto LABEL_107;
		        v118 = v117->fields._blackTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v164 = v118;
		        v119 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		      }
		      v120 = *(_OWORD *)&v119->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v119->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v119->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v120;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainEffectTex, &v165, 0LL);
		      v121 = rainPresettingAsset[1].klass;
		      if ( !v121 )
		        goto LABEL_107;
		      v122 = (Object_1 *)v121->vtable.Finalize.method;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(0LL, v122, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        CharacterRainStreakTex = *(_DWORD *)(v6 + 536);
		        if ( !textures )
		          goto LABEL_107;
		        v126 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 42), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        CharacterRainStreakTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainStreakTex;
		        v124 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v124 )
		          goto LABEL_107;
		        v125 = v124->fields._blackTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v164 = v125;
		        v126 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		      }
		      v127 = *(_OWORD *)&v126->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v126->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v126->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v127;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainStreakTex, &v165, 0LL);
		      v128 = rainPresettingAsset[1].klass;
		      if ( !v128 )
		        goto LABEL_107;
		      v129 = (Object_1 *)v128->vtable.GetHashCode.methodPtr;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(0LL, v129, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        CharacterRainFaceDripTex = *(_DWORD *)(v6 + 540);
		        if ( !textures )
		          goto LABEL_107;
		        v133 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 43), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        CharacterRainFaceDripTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainFaceDripTex;
		        v131 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v131 )
		          goto LABEL_107;
		        v132 = v131->fields._blackTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v164 = v132;
		        v133 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		      }
		      v134 = *(_OWORD *)&v133->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v133->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v133->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v134;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainFaceDripTex, &v165, 0LL);
		      v135 = rainPresettingAsset[1].klass;
		      if ( !v135 )
		        goto LABEL_107;
		      v136 = (Object_1 *)v135->vtable.GetHashCode.method;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(0LL, v136, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        textures = (char *)rainPresettingAsset[1].klass;
		        v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        CharacterRainFaceDropletTex = *(_DWORD *)(v6 + 544);
		        if ( !textures )
		          goto LABEL_107;
		        v139 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 44), 0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        CharacterRainFaceDropletTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainFaceDropletTex;
		        v137 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v137 )
		          goto LABEL_107;
		        v138 = v137->fields._blackTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        v164 = v138;
		        v139 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		      }
		      v92 = &v165;
		      v140 = *(_OWORD *)&v139->m_BufferPointer;
		      *(_OWORD *)&v165.m_Type = *(_OWORD *)&v139->m_Type;
		      *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v139->m_DepthSlice;
		      *(_OWORD *)&v165.m_BufferPointer = v140;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      v54 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VerticalFlowTexture;
		      v55 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v55 )
		        goto LABEL_107;
		      v56 = v55->fields._blackTexture_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v164 = v56;
		      v57 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v165, &v164, 0LL);
		      v58 = *(_OWORD *)&v57->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v57->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v57->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v58;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v54, &v166, 0LL);
		      v59 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RippleTexture;
		      v60 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v60 )
		        sub_1800D8260(v62, v61);
		      v164 = v60->fields._blackTexture_k__BackingField;
		      v63 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v165, &v164, 0LL);
		      v64 = *(_OWORD *)&v63->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v63->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v63->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v64;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v59, &v166, 0LL);
		      v65 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_RainOcclusionSampleNoise;
		      v66 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
		      v67 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v165, v66, 0LL);
		      v68 = *(_OWORD *)&v67->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v67->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v67->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v68;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v65, &v166, 0LL);
		      v69 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainEffectTex;
		      v70 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v70 )
		        sub_1800D8260(v72, v71);
		      v164 = v70->fields._blackTexture_k__BackingField;
		      v73 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v165, &v164, 0LL);
		      v74 = *(_OWORD *)&v73->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v73->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v73->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v74;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v69, &v166, 0LL);
		      v75 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainStreakTex;
		      v76 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v76 )
		        sub_1800D8260(v78, v77);
		      v164 = v76->fields._blackTexture_k__BackingField;
		      v79 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v165, &v164, 0LL);
		      v80 = *(_OWORD *)&v79->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v79->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v79->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v80;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v75, &v166, 0LL);
		      v81 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainFaceDripTex;
		      v82 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v82 )
		        sub_1800D8260(v84, v83);
		      v164 = v82->fields._blackTexture_k__BackingField;
		      v85 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v165, &v164, 0LL);
		      v86 = *(_OWORD *)&v85->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v85->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v85->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v86;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v81, &v166, 0LL);
		      CharacterRainFaceDropletTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterRainFaceDropletTex;
		      v88 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v88 )
		        sub_1800D8260(v90, v89);
		      v164 = v88->fields._blackTexture_k__BackingField;
		      v91 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v165, &v164, 0LL);
		      v92 = &v166;
		      v93 = *(_OWORD *)&v91->m_BufferPointer;
		      *(_OWORD *)&v166.m_Type = *(_OWORD *)&v91->m_Type;
		      *(_QWORD *)&v166.m_DepthSlice = *(_QWORD *)&v91->m_DepthSlice;
		      *(_OWORD *)&v166.m_BufferPointer = v93;
		    }
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterRainFaceDropletTex, v92, 0LL);
		    v141 = HG::Rendering::Runtime::HGRenderPipeline::get_asset(hgrp, 0LL);
		    if ( v141 )
		    {
		      v142 = HG::Rendering::Runtime::HGRenderPipelineAsset::get_renderPipelineResources(v141, 0LL);
		      if ( v142 )
		      {
		        v143 = v142->fields.assets;
		        if ( v143 )
		        {
		          snowPresettingAsset = (Object_1 *)v143->fields.snowPresettingAsset;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Inequality(snowPresettingAsset, 0LL, 0LL) )
		            goto LABEL_91;
		          if ( !snowPresettingAsset )
		            goto LABEL_107;
		          v145 = snowPresettingAsset[1].klass;
		          if ( !v145 )
		            goto LABEL_107;
		          element_class = (Object_1 *)v145->_0.element_class;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality(0LL, element_class, 0LL) )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            textures = (char *)snowPresettingAsset[1].klass;
		            v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            CharacterSnowEffectTex = *(_DWORD *)(v6 + 548);
		            if ( !textures )
		              goto LABEL_107;
		            v148 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, *((Texture **)textures + 8), 0LL);
		          }
		          else
		          {
		LABEL_91:
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            CharacterSnowEffectTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharacterSnowEffectTex;
		            v149 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		            if ( !v149 )
		              goto LABEL_107;
		            v150 = v149->fields._blackTexture_k__BackingField;
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		            v164 = v150;
		            v148 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v167, &v164, 0LL);
		          }
		          v151 = *(_OWORD *)&v148->m_BufferPointer;
		          *(_OWORD *)&v165.m_Type = *(_OWORD *)&v148->m_Type;
		          *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v148->m_DepthSlice;
		          *(_OWORD *)&v165.m_BufferPointer = v151;
		          UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, CharacterSnowEffectTex, &v165, 0LL);
		          v6 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		          if ( v6 )
		          {
		            volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData((HGCamera *)v6, 0LL);
		            if ( volumeComponentsData )
		            {
		              m_hgCharacterVolume = volumeComponentsData->fields.m_hgCharacterVolume;
		              sub_1800036A0(TypeInfo::UnityEngine::Object);
		              if ( !UnityEngine::Object::op_Inequality((Object_1 *)m_hgCharacterVolume, 0LL, 0LL) )
		                goto LABEL_101;
		              if ( !m_hgCharacterVolume )
		                goto LABEL_107;
		              if ( !UnityEngine::Rendering::VolumeParameter<System::Object>::op_Inequality(
		                      (VolumeParameter_1_System_Object_ *)m_hgCharacterVolume->fields.charMaxCubemap,
		                      0LL,
		                      MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Texture>::op_Inequality) )
		              {
		LABEL_101:
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                CharMaxCubemap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CharMaxCubemap;
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		                blackCubeTexture = (Texture *)UnityEngine::Rendering::CoreUtils::get_blackCubeTexture(0LL);
		                v156 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, blackCubeTexture, 0LL);
		                v157 = CharMaxCubemap;
		                goto LABEL_100;
		              }
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              textures = (char *)m_hgCharacterVolume->fields.charMaxCubemap;
		              v6 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              v154 = *(_DWORD *)(v6 + 524);
		              if ( textures )
		              {
		                v155 = (Texture *)sub_1800460A0(10LL, textures);
		                v156 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v167, v155, 0LL);
		                v157 = v154;
		LABEL_100:
		                v158 = *(_OWORD *)&v156->m_BufferPointer;
		                *(_OWORD *)&v165.m_Type = *(_OWORD *)&v156->m_Type;
		                *(_QWORD *)&v165.m_DepthSlice = *(_QWORD *)&v156->m_DepthSlice;
		                *(_OWORD *)&v165.m_BufferPointer = v158;
		                UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(commandBuffer, v157, &v165, 0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_107:
		    sub_1800D8260(v6, textures);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3575, 0LL);
		  if ( !Patch )
		    goto LABEL_107;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		}
		
		protected override PassConstructorID FindFirstBackbufferPass() => default; // 0x0000000189BFDDC8-0x0000000189BFE0B8
		// PassConstructorID FindFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathScene::FindFirstBackbufferPass(
		        HGRenderPathScene *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  HGCamera *v4; // rdx
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *RTForExtraction; // rax
		  __m128i v6; // xmm6
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *v7; // rax
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v8; // xmm8
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v9; // xmm1
		  __m128i v10; // xmm7
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v12; // rdi
		  List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v13; // r14
		  _BOOL8 v14; // r15
		  unsigned __int64 v15; // xmm6_8
		  _BOOL8 v16; // rsi
		  _BOOL8 v17; // rax
		  BOOL v18; // r14d
		  PassConstructorID__Enum v19; // eax
		  PassConstructorID__Enum v20; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v23; // [rsp+20h] [rbp-60h] BYREF
		  Nullable_1_Beyond_Gameplay_Core_Skill_InterruptContext_ v24[2]; // [rsp+30h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3636, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3636, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_51;
		  }
		  v4 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		  if ( !v4 )
		    goto LABEL_51;
		  RTForExtraction = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
		                      &v23,
		                      v4,
		                      RTExtractionType__Enum_SceneColorPS,
		                      0LL);
		  v4 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		  v6 = *(__m128i *)RTForExtraction;
		  if ( !v4 )
		    goto LABEL_51;
		  v7 = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(&v23, v4, RTExtractionType__Enum_FinalResult, 0LL);
		  v4 = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		  v8 = *v7;
		  if ( v4 )
		  {
		    v9 = *HG::Rendering::Runtime::HGCamera::GetRTForExtraction(&v23, v4, RTExtractionType__Enum_FinalResult, 0LL);
		    memset(v24, 0, 24);
		    v23 = v9;
		    System::Nullable<UnityEngine::InputSystem::InputAction::CallbackContext>::Nullable(
		      (Nullable_1_UnityEngine_InputSystem_InputAction_CallbackContext_ *)v24,
		      (InputAction_CallbackContext *)&v23,
		      MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::Nullable);
		    v10 = *(__m128i *)&v24[0].hasValue;
		  }
		  else
		  {
		    v10 = 0LL;
		    v24[0].value.nextSkillId = 0LL;
		  }
		  v3 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		  *(__m128i *)&v24[0].hasValue = v10;
		  if ( !v3 )
		    goto LABEL_51;
		  InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs((HGCamera *)v3, 0LL);
		  v3 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		  v12 = InplaceWaterMarkRTs;
		  v13 = v3 ? HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs((HGCamera *)v3, 0LL) : 0LL;
		  if ( *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03
		    && *(int *)(*(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 + 2424LL) > 0 )
		  {
		    LODWORD(v14) = 1;
		  }
		  else
		  {
		    if ( !*(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01 )
		      goto LABEL_51;
		    v14 = *(_DWORD *)(*(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01 + 2424LL) > 0;
		  }
		  if ( !v6.m128i_i64[0] )
		    goto LABEL_51;
		  if ( *(int *)(v6.m128i_i64[0] + 32) > 0 )
		    goto LABEL_26;
		  v15 = _mm_srli_si128(v6, 8).m128i_u64[0];
		  if ( !v15 )
		    goto LABEL_51;
		  if ( *(int *)(v15 + 32) > 0 )
		    goto LABEL_26;
		  if ( !v8.Item1 )
		    goto LABEL_51;
		  if ( v8.Item1->fields._count > 0 )
		  {
		LABEL_26:
		    LODWORD(v16) = 1;
		  }
		  else if ( *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 )
		  {
		    LODWORD(v16) = 0;
		  }
		  else
		  {
		    if ( !v12 )
		      goto LABEL_51;
		    v16 = v12->fields._size > 0;
		  }
		  LOBYTE(v3) = 0;
		  if ( (unsigned __int8)_mm_cvtsi128_si32(v10) )
		  {
		    System::Nullable<Beyond::Gameplay::Core::Skill::InterruptContext>::get_Value(
		      (Skill_InterruptContext *)&v23,
		      v24,
		      MethodInfo::System::Nullable<System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>>::get_Value);
		    if ( !v23.Item1 )
		      goto LABEL_51;
		    if ( v23.Item1->fields._count <= 0 )
		    {
		      if ( !v23.Item2 )
		        goto LABEL_51;
		      LOBYTE(v3) = v23.Item2->fields._count > 0;
		    }
		    else
		    {
		      v3 = 1LL;
		    }
		  }
		  if ( v13 )
		  {
		    v3 = (unsigned __int8)v3;
		    if ( v13->fields._size > 0 )
		      v3 = 1LL;
		  }
		  if ( *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 )
		  {
		    if ( !v12 )
		      goto LABEL_51;
		    v17 = v12->fields._size > 0;
		  }
		  else
		  {
		    LODWORD(v17) = 0;
		  }
		  v18 = v17 | (unsigned __int8)v3;
		  v19 = (unsigned int)sub_180002F70(6LL, this);
		  v3 = *(_QWORD *)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		  v20 = v19;
		  if ( !v3 )
		LABEL_51:
		    sub_1800D8260(v3, v4);
		  if ( HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler((HGCamera *)v3, 0LL) )
		    v20 = PassConstructorID__Enum_UI;
		  if ( v16 )
		    v20 = PassConstructorID__Enum_UI;
		  if ( v14 )
		    v20 = PassConstructorID__Enum_ScreenSpaceOverlay;
		  if ( v18 )
		    return 60;
		  return v20;
		}
		
		protected override void OnPostRendering(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BFE0B8-0x0000000189BFE1B0
		// Void OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::OnPostRendering(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderPipeline *hgrp; // rcx
		  HGRenderGraph *renderGraph; // rsi
		  TextureHandle v8; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+30h] [rbp-28h] BYREF
		  TextureHandle v11; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3638, 0LL) )
		  {
		    hgrp = renderPathParams->hgrp;
		    if ( hgrp )
		    {
		      renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		      if ( renderPathParams->skipRender )
		        v8 = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		      else
		        v8 = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      v10 = v8;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v10, 0LL) )
		        goto LABEL_9;
		      if ( renderGraph )
		      {
		        *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23 = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(&v11, renderGraph, &v10, 1, (String *)"historySceneColor", 0LL);
		LABEL_9:
		        HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering((HGRenderPathBase *)this, renderPathParams, 0LL);
		        return;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(hgrp, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3638, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		}
		
		protected override void RenderInternal(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BFFA30-0x0000000189BFFEB0
		// Void RenderInternal(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGRenderPathScene::RenderInternal(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v3; // r13
		  HGRenderPathScene *v4; // r15
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGCamera *hgrp; // r12
		  HGRenderGraph *v8; // rdi
		  HGCamera *m_Ptr; // rbx
		  unsigned __int64 v10; // rdx
		  UIImageBlurManager *instance; // rax
		  unsigned __int64 v12; // r8
		  signed __int64 v13; // rtt
		  UIImageBlurPassConstructor *v14; // rcx
		  __int64 *v15; // rdx
		  Il2CppException *v16; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rsi
		  Shader *blitPS; // rsi
		  void *ptr; // rdi
		  HGCamera *v21; // rsi
		  HGRenderPipelineRuntimeResources *v22; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *v23; // r8
		  HGRenderGraph *v24; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // [rsp+0h] [rbp-D8h] BYREF
		  UIImageBlurPassConstructor_PassOutput output; // [rsp+40h] [rbp-98h] BYREF
		  HGCamera *uiCamera; // [rsp+48h] [rbp-90h]
		  Il2CppException *ex; // [rsp+50h] [rbp-88h]
		  char *v32; // [rsp+58h] [rbp-80h]
		  UIImageBlurManager *v33; // [rsp+60h] [rbp-78h] BYREF
		  HGRenderGraph *renderGraph; // [rsp+68h] [rbp-70h]
		  HGCamera *v35; // [rsp+70h] [rbp-68h]
		  UIImageBlurPassConstructor_PassInput input; // [rsp+78h] [rbp-60h] BYREF
		  CommandBuffer *cmd; // [rsp+80h] [rbp-58h]
		  Il2CppExceptionWrapper *v38; // [rsp+90h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v39; // [rsp+98h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v40; // [rsp+A0h] [rbp-38h] BYREF
		  char v43; // [rsp+F8h] [rbp+20h] BYREF
		
		  v3 = renderPathParams;
		  v4 = this;
		  v43 = 0;
		  input.uiImageBlurMgr = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3640, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3640, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, v3, 0LL);
		  }
		  else
		  {
		    hgrp = (HGCamera *)v3->hgrp;
		    v35 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    v8 = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph((HGRenderPipeline *)hgrp, 0LL);
		    renderGraph = v8;
		    m_Ptr = (HGCamera *)v3->renderGraphParams.scriptableRenderContext.m_Ptr;
		    uiCamera = m_Ptr;
		    cmd = v3->renderGraphParams.commandBuffer;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v32 = &v43;
		    try
		    {
		      v33 = 0LL;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
		      instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager->static_fields->instance;
		      v33 = instance;
		      if ( dword_18F35FD08 )
		      {
		        v12 = (((unsigned __int64)&v33 >> 12) & 0x1FFFFF) >> 6;
		        v10 = ((unsigned __int64)&v33 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F103690[v12]);
		        do
		          v13 = qword_18F103690[v12];
		        while ( v13 != _InterlockedCompareExchange64(&qword_18F103690[v12], v13 | (1LL << v10), v13) );
		        instance = v33;
		      }
		      input.uiImageBlurMgr = instance;
		      output = 0;
		      v14 = *(UIImageBlurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m23;
		      if ( !v14 )
		        sub_1800D8250(0LL, v10);
		      HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
		        v14,
		        &input,
		        &output,
		        v8,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v38 )
		    {
		      v15 = &v28;
		      ex = v38->ex;
		      v16 = ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v35;
		      m_Ptr = uiCamera;
		    }
		    v35 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    uiCamera = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		    if ( !hgrp )
		      goto LABEL_31;
		    defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources((HGRenderPipeline *)hgrp, 0LL);
		    if ( !defaultResources )
		      goto LABEL_31;
		    shaders = defaultResources->fields.shaders;
		    if ( !shaders )
		      goto LABEL_31;
		    blitPS = shaders->fields.blitPS;
		    ptr = v3->renderRequest.cullingResults.cullingResults.ptr;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(v35, uiCamera, blitPS, ptr, renderGraph, v3, 0LL);
		    v21 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    uiCamera = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		    v22 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources((HGRenderPipeline *)hgrp, 0LL);
		    if ( !v22 || (v23 = v22->fields.shaders) == 0LL )
		LABEL_31:
		      sub_1800D8250(v16, v15);
		    v24 = renderGraph;
		    HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
		      v21,
		      uiCamera,
		      v23->fields.blitPS,
		      v3->renderRequest.cullingResults.cullingResults.ptr,
		      renderGraph,
		      v3,
		      0LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		    ex = 0LL;
		    v32 = &v43;
		    try
		    {
		      HG::Rendering::Runtime::HGRenderPathScene::PrepareData(
		        v4,
		        (ScriptableRenderContext)m_Ptr,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        cmd,
		        (HGRenderPipeline *)hgrp,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v39 )
		    {
		      ex = v39->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		      v24 = renderGraph;
		    }
		    sub_180073530(14LL, v4, v3);
		    HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase1(v4, v3, 0LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)1u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathScene::OtherPassScope>);
		    ex = 0LL;
		    v32 = &v43;
		    try
		    {
		      HG::Rendering::Runtime::HGRenderPathScene::OverrideShaderVariablesGlobal(
		        v4,
		        v24,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        1,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v40 )
		    {
		      ex = v40->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v3 = renderPathParams;
		      v4 = this;
		    }
		    HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase2(v4, v3, 0LL);
		    HG::Rendering::Runtime::HGRenderPathScene::RenderEditorPrimitives(v4, v3, 0LL);
		  }
		}
		
		internal override void Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CB0360-0x0000000184CB03A0
		// Void Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::HGRenderPathScene::Dispose(
		        HGRenderPathScene *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3606, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3606, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGRenderPathBase::Dispose((HGRenderPathBase *)this, renderGraph, 0LL);
		  }
		}
		
		protected abstract void RenderScene(ref HGRenderPathParams renderPathParams);
		private void PrepareKeywords(ScriptableRenderContext srp, HGCamera camera, CommandBuffer cmd, HGRenderPipeline hgrp) {} // 0x0000000189BFF7B8-0x0000000189BFF8C4
		// Void PrepareKeywords(ScriptableRenderContext, HGCamera, CommandBuffer, HGRenderPipeline)
		void HG::Rendering::Runtime::HGRenderPathScene::PrepareKeywords(
		        HGRenderPathScene *this,
		        ScriptableRenderContext srp,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  bool enableMV; // al
		  bool v12; // al
		  ScriptableRenderContext P1; // [rsp+58h] [rbp+10h] BYREF
		
		  P1.m_Ptr = srp.m_Ptr;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3642, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		    if ( camera )
		    {
		      enableMV = HG::Rendering::Runtime::HGCamera::get_enableMV(camera, 0LL);
		      if ( cmd )
		      {
		        UnityEngine::Rendering::CommandBuffer::SetKeyword(
		          cmd,
		          &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_MVKeyword,
		          enableMV,
		          0LL);
		        v12 = HG::Rendering::Runtime::HGCamera::get_enableMV(camera, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetKeyword(
		          cmd,
		          &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_PerObjectMVKeyword,
		          v12,
		          0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBufferNoCopy(&P1, cmd, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(Patch, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3642, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_618(
		    Patch,
		    (Object *)this,
		    P1,
		    (Object *)camera,
		    (Object *)cmd,
		    (Object *)hgrp,
		    0LL);
		}
		
		private void PrepareData(ScriptableRenderContext srp, HGCamera camera, CommandBuffer cmd, HGRenderPipeline hgrp) {} // 0x0000000189BFF6C0-0x0000000189BFF7B8
		// Void PrepareData(ScriptableRenderContext, HGCamera, CommandBuffer, HGRenderPipeline)
		void HG::Rendering::Runtime::HGRenderPathScene::PrepareData(
		        HGRenderPathScene *this,
		        ScriptableRenderContext srp,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        HGRenderPipeline *hgrp,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  SettingParameter_1_System_Boolean_ *transientGBuffer_k__BackingField; // rcx
		  bool ssrEnable; // al
		  HGSettingParameters *settingParameters_k__BackingField; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3641, 0LL) )
		  {
		    HG::Rendering::Runtime::HGRenderPathScene::PrepareKeywords(this, srp, camera, cmd, hgrp, 0LL);
		    if ( camera )
		    {
		      ssrEnable = HG::Rendering::Runtime::HGCamera::get_ssrEnable(camera, 0LL);
		      if ( hgrp )
		      {
		        if ( !ssrEnable )
		        {
		LABEL_8:
		          HG::Rendering::Runtime::HGRenderPipeline::PreparePCMultiscattering(hgrp, cmd, 0LL);
		          return;
		        }
		        settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		        if ( settingParameters_k__BackingField )
		        {
		          transientGBuffer_k__BackingField = settingParameters_k__BackingField->fields._transientGBuffer_k__BackingField;
		          if ( transientGBuffer_k__BackingField )
		          {
		            HG::Rendering::Runtime::SettingParameter<bool>::Override(
		              transientGBuffer_k__BackingField,
		              0,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::Override);
		            goto LABEL_8;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(transientGBuffer_k__BackingField, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3641, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_618(
		    Patch,
		    (Object *)this,
		    srp,
		    (Object *)camera,
		    (Object *)cmd,
		    (Object *)hgrp,
		    0LL);
		}
		
		protected virtual void RenderPostProcessPhase1(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BFFEB0-0x0000000189C00AD0
		// Void RenderPostProcessPhase1(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase1(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v3; // r13
		  HGRenderPathScene *v4; // rdi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r15
		  HGRenderGraph *renderGraph; // r14
		  HGSettingParameters *settingParameters_k__BackingField; // rsi
		  __int64 v10; // rdx
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  LightShaftApplyPassConstructor *v13; // rcx
		  BOOL m_enableCompatibilityMode; // eax
		  __int128 v15; // xmm1
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // rdx
		  DepthOfFieldPassConstructor *v19; // rcx
		  unsigned __int64 v20; // rdx
		  TextureHandle v21; // xmm1
		  TextureHandle v22; // xmm0
		  TextureHandle v23; // xmm2
		  unsigned __int64 v24; // r8
		  signed __int64 v25; // rtt
		  MotionBlurPassConstructor *v26; // rcx
		  __int64 monitor; // rdx
		  HGCamera *handle; // rcx
		  HGCamera *v29; // rax
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  unsigned __int64 v31; // r8
		  signed __int64 v32; // rtt
		  HGCamera_VolumeComponentsData *v33; // rax
		  Object_1 *m_horizontalBlur; // rsi
		  PostProcessPassConstructor *v35; // r15
		  HGCamera *v36; // r12
		  ParafinPassConstructor_PassOutput v37; // xmm7
		  double v38; // xmm0_8
		  float v39; // xmm9_4
		  double v40; // xmm0_8
		  float v41; // xmm8_4
		  char v42; // r13
		  Vector2 v43; // xmm6_8
		  double v44; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  __int64 v48; // [rsp+0h] [rbp-3B8h] BYREF
		  LightShaftApplyPassConstructor_PassOutput output; // [rsp+60h] [rbp-358h] BYREF
		  HGCamera *hgCamera; // [rsp+68h] [rbp-350h]
		  LensFlarePassConstructor_PassInput v51; // [rsp+70h] [rbp-348h] BYREF
		  HGRenderPipeline *v52; // [rsp+88h] [rbp-330h]
		  HGRenderGraph *v53; // [rsp+90h] [rbp-328h]
		  HGSettingParameters *v54; // [rsp+98h] [rbp-320h]
		  ParafinPassConstructor_PassOutput v55; // [rsp+A0h] [rbp-318h] BYREF
		  __int128 v56; // [rsp+B0h] [rbp-308h]
		  uint32_t v57; // [rsp+C0h] [rbp-2F8h]
		  void *m_Ptr; // [rsp+D0h] [rbp-2E8h]
		  DepthOfFieldPassConstructor_PassInput input; // [rsp+E0h] [rbp-2D8h] BYREF
		  MotionBlurPassConstructor_PassOutput v60; // [rsp+120h] [rbp-298h] BYREF
		  TextureHandle v61; // [rsp+130h] [rbp-288h]
		  TextureHandle v62; // [rsp+140h] [rbp-278h]
		  TextureHandle v63; // [rsp+150h] [rbp-268h]
		  HGSettingParameters *v64; // [rsp+160h] [rbp-258h] BYREF
		  DepthOfFieldPassConstructor_PassOutput v65; // [rsp+168h] [rbp-250h] BYREF
		  MotionBlurPassConstructor_PassInput v66; // [rsp+178h] [rbp-240h] BYREF
		  Il2CppExceptionWrapper *v67; // [rsp+1B0h] [rbp-208h] BYREF
		  Il2CppExceptionWrapper *v68; // [rsp+1B8h] [rbp-200h] BYREF
		  Il2CppExceptionWrapper *v69; // [rsp+1C0h] [rbp-1F8h] BYREF
		  Il2CppExceptionWrapper *v70; // [rsp+1C8h] [rbp-1F0h] BYREF
		  TransparentAfterDOFPassConstructor_PassInput v71; // [rsp+1D0h] [rbp-1E8h] BYREF
		  DepthOfFieldPassConstructor_PassInput v72; // [rsp+270h] [rbp-148h] BYREF
		  TransparentAfterDOFPassConstructor_PassInput v73; // [rsp+2B0h] [rbp-108h] BYREF
		  char v76; // [rsp+3D8h] [rbp+20h] BYREF
		
		  v3 = renderPathParams;
		  v4 = this;
		  v76 = 0;
		  sub_18033B9D0(&v72, 0LL, 64LL);
		  v65 = 0LL;
		  memset(&v66, 0, sizeof(v66));
		  v60 = 0LL;
		  sub_18033B9D0(&v73, 0LL, 160LL);
		  sub_18033B9D0(&v71, 0LL, 160LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3644, 0LL) )
		  {
		    hgrp = v3->hgrp;
		    v52 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v53 = renderGraph;
		    m_Ptr = v3->renderGraphParams.scriptableRenderContext.m_Ptr;
		    settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		    v54 = settingParameters_k__BackingField;
		    hgCamera = v3->renderRequest.hgCamera;
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x2Bu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v51.sceneColor.handle = 0LL;
		    v51.sceneColor.fallBackResource = (ResourceHandle)&v76;
		    try
		    {
		      v55 = 0LL;
		      v56 = 0LL;
		      v57 = 0;
		      v11 = *(_OWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      v12 = *(_OWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m10;
		      LOBYTE(v57) = LOBYTE(v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m11);
		      *(_OWORD *)&input.quality = v11;
		      *(_OWORD *)&input.motionVectorTexture.fallBackResource.m_Value = v12;
		      input.sceneColor.fallBackResource.m_Value = (unsigned __int8)v57;
		      output = 0;
		      v13 = *(LightShaftApplyPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m00;
		      if ( !v13 )
		        sub_1800D8250(0LL, v10);
		      HG::Rendering::Runtime::LightShaftApplyPassConstructor::ConstructPass(
		        v13,
		        (LightShaftApplyPassConstructor_PassInput *)&input,
		        &output,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v67 )
		    {
		      v51.sceneColor.handle = (ResourceHandle)v67->ex;
		      if ( v51.sceneColor.handle )
		        sub_18007E1E0(*(_QWORD *)&v51.sceneColor.handle);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v52;
		      renderGraph = v53;
		      settingParameters_k__BackingField = v54;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x2Du,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v51.sceneColor.handle = 0LL;
		    v51.sceneColor.fallBackResource = (ResourceHandle)&v76;
		    try
		    {
		      v55 = 0LL;
		      v56 = 0LL;
		      v57 = 0;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		      if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_useCutsceneEffsectShader )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		        m_enableCompatibilityMode = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_enableCompatibilityMode;
		      }
		      else
		      {
		        m_enableCompatibilityMode = 0;
		      }
		      LOBYTE(v57) = m_enableCompatibilityMode;
		      v15 = *(_OWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      *(_OWORD *)&input.quality = *(_OWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      *(_OWORD *)&input.motionVectorTexture.fallBackResource.m_Value = v15;
		      input.sceneColor.fallBackResource.m_Value = v57;
		      v55 = 0LL;
		      if ( *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20 )
		      {
		        HG::Rendering::Runtime::ParafinPassConstructor::ConstructPass(
		          *(ParafinPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m20,
		          (ParafinPassConstructor_PassInput *)&input,
		          &v55,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		          0LL);
		        *(ParafinPassConstructor_PassOutput *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = v55;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v68 )
		    {
		      v51.sceneColor.handle = (ResourceHandle)v68->ex;
		      if ( v51.sceneColor.handle )
		        sub_18007E1E0(*(_QWORD *)&v51.sceneColor.handle);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v52;
		      renderGraph = v53;
		      settingParameters_k__BackingField = v54;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x2Eu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v51.sceneColor.handle = 0LL;
		    v51.sceneColor.fallBackResource = (ResourceHandle)&v76;
		    try
		    {
		      sub_18033B9D0(&input, 0LL, 64LL);
		      if ( !settingParameters_k__BackingField )
		        sub_1800D8250(v17, v16);
		      input.quality = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                        (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField->fields._depthOfFieldQuality_k__BackingField,
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::HGDepthOfFieldQuality>::op_Implicit);
		      input.depthOfFieldMaxRadius = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                      settingParameters_k__BackingField->fields._depthOfFieldMaxRadius_k__BackingField,
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      input.sceneColor = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      input.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      input.motionVectorTexture = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		      input.renderContext.m_Ptr = m_Ptr;
		      v72 = input;
		      v19 = *(DepthOfFieldPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m01;
		      if ( !v19 )
		        sub_1800D8250(0LL, v18);
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructPass(
		        v19,
		        &v72,
		        &v65,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        0LL);
		      *(DepthOfFieldPassConstructor_PassOutput *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = v65;
		    }
		    catch ( Il2CppExceptionWrapper *v69 )
		    {
		      v51.sceneColor.handle = (ResourceHandle)v69->ex;
		      if ( v51.sceneColor.handle )
		        sub_18007E1E0(*(_QWORD *)&v51.sceneColor.handle);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v52;
		      renderGraph = v53;
		      settingParameters_k__BackingField = v54;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x2Fu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v51.sceneColor.handle = 0LL;
		    v51.sceneColor.fallBackResource = (ResourceHandle)&v76;
		    try
		    {
		      v21 = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      v61 = v21;
		      v22 = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      v62 = v22;
		      v23 = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		      v63 = v23;
		      v64 = settingParameters_k__BackingField;
		      if ( dword_18F35FD08 )
		      {
		        v24 = (((unsigned __int64)&v64 >> 12) & 0x1FFFFF) >> 6;
		        v20 = ((unsigned __int64)&v64 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v24 + 36190]);
		        do
		          v25 = qword_18F0BCBA0[v24 + 36190];
		        while ( v25 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v24 + 36190], v25 | (1LL << v20), v25) );
		        v23 = v63;
		        v22 = v62;
		        v21 = v61;
		      }
		      v66.sceneColor = v21;
		      v66.sceneDepth = v22;
		      v66.sceneMV = v23;
		      v66.settingParameters = v64;
		      v60 = 0LL;
		      v26 = *(MotionBlurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m21;
		      if ( !v26 )
		        sub_1800D8250(0LL, v20);
		      HG::Rendering::Runtime::MotionBlurPassConstructor::ConstructPass(
		        v26,
		        &v66,
		        &v60,
		        renderGraph,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        0LL);
		      *(MotionBlurPassConstructor_PassOutput *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = v60;
		    }
		    catch ( Il2CppExceptionWrapper *v70 )
		    {
		      monitor = (__int64)&v48;
		      v51.sceneColor.handle = (ResourceHandle)v70->ex;
		      handle = (HGCamera *)v51.sceneColor.handle;
		      if ( v51.sceneColor.handle )
		        sub_18007E1E0(*(_QWORD *)&v51.sceneColor.handle);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v52;
		      renderGraph = v53;
		      settingParameters_k__BackingField = v54;
		      v29 = hgCamera;
		LABEL_32:
		      if ( !v29 )
		        goto LABEL_71;
		      if ( HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(v29, 0LL) )
		      {
		        sub_18033B9D0(&v71, 0LL, 160LL);
		        handle = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		        if ( !handle )
		          goto LABEL_71;
		        volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(handle, 0LL);
		        if ( !volumeComponentsData )
		          goto LABEL_71;
		        handle = (HGCamera *)volumeComponentsData->fields.m_hgCharacterVolume;
		        if ( !handle )
		          goto LABEL_71;
		        v71.characterOutlineEnabled = HG::Rendering::Runtime::HGCharacterVolume::GetCharOutlinePassEnableState(
		                                        (HGCharacterVolume *)handle,
		                                        0LL);
		        v71.forwardTransparentAfterDOFECSList = LODWORD(v4[1].fields._.m_basicTransformConstants._PrevNonJitteredInvViewProjMatrix.m21);
		        v71.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		        v71.screenCullingRatio = hgCamera->fields.screenCullingRatio;
		        v71.screenCullingRatioDistance = hgCamera->fields.screenRatioCullingDistance;
		        v71.bakedLightConfig = HG::Rendering::Runtime::HGRenderPipeline::get_bakedLightingConfig(hgrp, 0LL);
		        v71.shadowResult = *(ShadowResult *)&v4[1].fields._.m_basicTransformConstants._PrevInvViewProjMatrix.m20;
		        v71.cullingResults = v3->renderRequest.cullingResults.cullingResults;
		        v71.sceneColor = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		        v71.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		        v71.sceneMV = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		        v71.hgrp = hgrp;
		        if ( dword_18F35FD08 )
		        {
		          v31 = (((unsigned __int64)&v71.hgrp >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v31 + 36190]);
		          do
		            v32 = qword_18F0BCBA0[v31 + 36190];
		          while ( v32 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v31 + 36190],
		                           v32 | (1LL << (((unsigned __int64)&v71.hgrp >> 12) & 0x3F)),
		                           v32) );
		        }
		        v73 = v71;
		        monitor = 128LL;
		        v55 = 0LL;
		        handle = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m02;
		        if ( !handle )
		          goto LABEL_71;
		        HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::ConstructPass(
		          (TransparentAfterDOFPassConstructor *)handle,
		          &v73,
		          (TransparentAfterDOFPassConstructor_PassOutput *)&v55,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		          0LL);
		        *(ParafinPassConstructor_PassOutput *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = v55;
		      }
		      if ( !settingParameters_k__BackingField )
		        goto LABEL_71;
		      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             settingParameters_k__BackingField->fields._lensFlareEnabled_k__BackingField,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		      {
		        v55 = 0LL;
		        *(_QWORD *)&v56 = 0LL;
		        v51.sceneColor = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		        v51.debugFullscreenBuffer = 0LL;
		        output = 0;
		        handle = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m23;
		        if ( !handle )
		          goto LABEL_71;
		        HG::Rendering::Runtime::LensFlarePassConstructor::ConstructPass(
		          (LensFlarePassConstructor *)handle,
		          &v51,
		          (LensFlarePassConstructor_PassOutput *)&output,
		          renderGraph,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		          0LL);
		      }
		      handle = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( handle )
		      {
		        v33 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(handle, 0LL);
		        if ( v33 )
		        {
		          m_horizontalBlur = (Object_1 *)v33->fields.m_horizontalBlur;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( !UnityEngine::Object::op_Inequality(m_horizontalBlur, 0LL, 0LL) )
		            return;
		          if ( m_horizontalBlur )
		          {
		            if ( !HG::Rendering::Runtime::HGHorizontalBlur::IsActive((HGHorizontalBlur *)m_horizontalBlur, 0LL) )
		              return;
		            v35 = *(PostProcessPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00;
		            v36 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		            v37 = *(ParafinPassConstructor_PassOutput *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		            monitor = (__int64)m_horizontalBlur[2].monitor;
		            if ( monitor )
		            {
		              v38 = sub_1800057D0(10LL, monitor);
		              v39 = *(float *)&v38;
		              monitor = (__int64)m_horizontalBlur[2].fields.m_CachedPtr;
		              if ( monitor )
		              {
		                output = (LightShaftApplyPassConstructor_PassOutput)sub_180006280(10LL, monitor);
		                monitor = (__int64)m_horizontalBlur[3].klass;
		                if ( monitor )
		                {
		                  v40 = sub_1800057D0(10LL, monitor);
		                  v41 = *(float *)&v40;
		                  monitor = (__int64)m_horizontalBlur[3].monitor;
		                  if ( monitor )
		                  {
		                    v42 = sub_180006280(10LL, monitor);
		                    monitor = (__int64)m_horizontalBlur[3].fields.m_CachedPtr;
		                    if ( monitor )
		                    {
		                      v43 = (Vector2)sub_180041350(10LL);
		                      monitor = (__int64)m_horizontalBlur[4].klass;
		                      if ( monitor )
		                      {
		                        v44 = sub_1800057D0(10LL, monitor);
		                        if ( v35 )
		                        {
		                          v55 = v37;
		                          *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = *HG::Rendering::Runtime::PostProcessPassConstructor::HorizontalBlurPassPreTAAU(&v51.sceneColor, v35, renderGraph, v36, &v55.sceneColor, v39, *(_BYTE *)&output, v41, v42, v43, *(float *)&v44, 0LL);
		                          return;
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_71:
		      sub_1800D8250(handle, monitor);
		    }
		    v29 = hgCamera;
		    goto LABEL_32;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3644, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v47, v46);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)v4, v3, 0LL);
		}
		
		protected virtual void RenderPostProcessPhase2(ref HGRenderPathParams renderPathParams) {} // 0x0000000189C00AD0-0x0000000189C02720
		// Void RenderPostProcessPhase2(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGRenderPathScene::RenderPostProcessPhase2(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathParams *v3; // rdi
		  HGRenderPathScene *v4; // r14
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipeline *hgrp; // r15
		  HGRenderGraph *renderGraph; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGRenderGraph *v11; // r12
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGSettingParameters *P5; // r13
		  CullingResults cullingResults; // xmm13
		  HGCamera *v16; // rbx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Object_1 *additionalCameraData; // rbx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  HGAdditionalCameraData *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  Vector2Int *v27; // rax
		  Vector2Int *v28; // rax
		  HGCamera *v29; // rbx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  __int64 v32; // rdx
		  HGCamera *v33; // rcx
		  HGCamera *v34; // rcx
		  Object_1 *v35; // rbx
		  __int64 v36; // rdx
		  HGCamera *v37; // rcx
		  HGCamera *v38; // rcx
		  HGAdditionalCameraData *v39; // rbx
		  __int64 v40; // rdx
		  double v41; // xmm0_8
		  HGCamera *v42; // rcx
		  HGAdditionalCameraData *v43; // rax
		  __int64 v44; // rcx
		  float materialMipBias; // xmm6_4
		  TAAUPassConstructor *v46; // rcx
		  __int128 v47; // xmm6
		  HGCamera *v48; // rbx
		  unsigned __int64 v49; // rdx
		  signed __int64 v50; // rcx
		  Rect v51; // xmm12
		  unsigned __int64 v52; // r8
		  signed __int64 v53; // rtt
		  bool v54; // al
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  __int64 v59; // rbx
		  __int64 v60; // rdi
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  __int64 v63; // rcx
		  HGCamera_VolumeComponentsData *v64; // rdx
		  ILFixDynamicMethodWrapper_2 *v65; // rax
		  __int64 v66; // rdx
		  __int64 v67; // rcx
		  int v68; // ecx
		  unsigned __int64 v69; // r9
		  signed __int64 v70; // rtt
		  unsigned __int64 v71; // r9
		  signed __int64 v72; // rtt
		  unsigned __int64 v73; // r9
		  signed __int64 v74; // rtt
		  unsigned __int64 v75; // r9
		  signed __int64 v76; // rtt
		  unsigned __int64 v77; // r9
		  signed __int64 v78; // rtt
		  unsigned __int64 v79; // r9
		  signed __int64 v80; // rtt
		  unsigned __int64 v81; // r9
		  signed __int64 v82; // rtt
		  unsigned __int64 v83; // r9
		  signed __int64 v84; // rtt
		  unsigned __int64 v85; // r8
		  signed __int64 v86; // rtt
		  TextureHandle sceneColor; // xmm6
		  __int64 v88; // rdx
		  HGSharpen *v89; // rcx
		  __int64 v90; // rdx
		  HGFisheyeEffect *v91; // rcx
		  TextureHandle sceneDepth; // xmm7
		  bool v93; // al
		  TextureHandle v94; // xmm10
		  TextureHandle sceneMV; // xmm8
		  TextureHandle v96; // xmm11
		  int32_t v97; // r8d
		  TextureHandle v98; // xmm9
		  TextureHandle target; // xmm8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v101; // rdx
		  __int64 v102; // rcx
		  TextureHandle frostedGlassRT; // xmm6
		  HGCamera *v104; // rbx
		  __int64 *v105; // rdx
		  HGCamera *v106; // rcx
		  bool enableMetalFXSpatialScaler; // di
		  HGCamera *v108; // rbx
		  char v109; // al
		  HGCamera *v110; // rbx
		  bool v111; // al
		  char v112; // bl
		  TextureHandle v113; // xmm7
		  TextureHandle v114; // xmm6
		  HGRenderPipeline *v115; // rdi
		  unsigned __int64 v116; // r8
		  signed __int64 v117; // rtt
		  __int64 v118; // rdx
		  __int64 v119; // rcx
		  __int64 v120; // rdx
		  UIPassConstructor *v121; // rcx
		  __int64 v122; // rdx
		  __int64 v123; // rcx
		  ComposablePass *v124; // rcx
		  __int64 v125; // rax
		  TextureHandle v126; // xmm6
		  unsigned __int64 v127; // r9
		  signed __int64 v128; // rtt
		  __int64 v129; // rdx
		  MultiblurPassConstructor *v130; // rcx
		  TextureHandle backBufferColor_k__BackingField; // xmm7
		  unsigned __int64 v132; // rdx
		  TextureHandle v133; // xmm6
		  TextureHandle v134; // xmm0
		  unsigned __int64 v135; // r8
		  signed __int64 v136; // rtt
		  ScreenSpaceOverlayPassConstructor *v137; // rcx
		  IPassConstructor *PassConstructor; // rbx
		  ComposablePass *v139; // rdi
		  __int64 v140; // rdx
		  __int64 v141; // rcx
		  ComposablePass *v142; // rax
		  HGCamera *v143; // rbx
		  TextureHandle v144; // xmm7
		  ILFixDynamicMethodWrapper_2 *v145; // rax
		  __int64 v146; // rdx
		  __int64 v147; // rcx
		  __int64 v148; // [rsp+0h] [rbp-5E8h] BYREF
		  _BYTE v149[16]; // [rsp+70h] [rbp-578h] BYREF
		  TextureHandle v150; // [rsp+80h] [rbp-568h] BYREF
		  TextureHandle v151[2]; // [rsp+90h] [rbp-558h] BYREF
		  TextureHandle v152; // [rsp+B0h] [rbp-538h] BYREF
		  HGFisheyeEffect *v153; // [rsp+C0h] [rbp-528h]
		  TextureHandle v154; // [rsp+D0h] [rbp-518h] BYREF
		  HGCamera *hgCamera; // [rsp+E0h] [rbp-508h]
		  TAAUPassConstructor_PassOutput output; // [rsp+E8h] [rbp-500h] BYREF
		  HGRenderPipeline *v157; // [rsp+F8h] [rbp-4F0h]
		  Rect v158; // [rsp+100h] [rbp-4E8h] BYREF
		  HGRenderGraph *v159; // [rsp+110h] [rbp-4D8h]
		  HGSettingParameters *settingParameters_k__BackingField; // [rsp+118h] [rbp-4D0h]
		  _QWORD v161[9]; // [rsp+120h] [rbp-4C8h] BYREF
		  TextureHandle v162; // [rsp+168h] [rbp-480h]
		  HGCamera *v163; // [rsp+178h] [rbp-470h] BYREF
		  PostProcessPassConstructor_PassOutput P2; // [rsp+180h] [rbp-468h] BYREF
		  UIPassConstructor_PassInput v165; // [rsp+1A0h] [rbp-448h] BYREF
		  ScreenSpaceOverlayPassConstructor_PassInput v166; // [rsp+1F0h] [rbp-3F8h] BYREF
		  PostProcessPassConstructor_PassInput v167; // [rsp+210h] [rbp-3D8h] BYREF
		  CullingResults v168; // [rsp+290h] [rbp-358h]
		  TAAUPassConstructor_PassInput v169; // [rsp+2A0h] [rbp-348h] BYREF
		  MultiblurPassConstructor_PassInput v170; // [rsp+350h] [rbp-298h] BYREF
		  PostProcessPassConstructor_PassInput P1; // [rsp+390h] [rbp-258h] BYREF
		  Il2CppExceptionWrapper *v172; // [rsp+410h] [rbp-1D8h] BYREF
		  Il2CppExceptionWrapper *v173; // [rsp+418h] [rbp-1D0h] BYREF
		  Il2CppExceptionWrapper *v174; // [rsp+420h] [rbp-1C8h] BYREF
		  UIPassConstructor_PassInput v175; // [rsp+430h] [rbp-1B8h] BYREF
		  TAAUPassConstructor_PassInput input; // [rsp+480h] [rbp-168h] BYREF
		  Material *v179; // [rsp+608h] [rbp+20h] BYREF
		
		  v3 = renderPathParams;
		  v4 = this;
		  v158 = 0LL;
		  v149[0] = 0;
		  sub_18033B9D0(&input, 0LL, 164LL);
		  sub_18033B9D0(&P1, 0LL, 128LL);
		  memset(&P2, 0, sizeof(P2));
		  sub_18033B9D0(&v167, 0LL, 128LL);
		  sub_18033B9D0(&v175, 0LL, 80LL);
		  sub_18033B9D0(&v165, 0LL, 80LL);
		  memset(&v170, 0, sizeof(v170));
		  memset(&v161[2], 0, 56);
		  memset(&v166, 0, sizeof(v166));
		  v162 = 0LL;
		  v163 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3648, 0LL) )
		  {
		    hgrp = v3->hgrp;
		    v157 = hgrp;
		    if ( !hgrp )
		      sub_1800D8260(v6, v5);
		    renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		    v11 = renderGraph;
		    v159 = renderGraph;
		    if ( !renderGraph )
		      sub_1800D8260(v10, v9);
		    if ( !HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL) )
		      sub_1800D8260(v13, v12);
		    settingParameters_k__BackingField = hgrp->fields._settingParameters_k__BackingField;
		    P5 = settingParameters_k__BackingField;
		    cullingResults = v3->renderRequest.cullingResults.cullingResults;
		    v168 = cullingResults;
		    hgCamera = v3->renderRequest.hgCamera;
		    v16 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    HG::Rendering::Runtime::HGUtils::GetRenderingScale(v16, settingParameters_k__BackingField, 0LL);
		    if ( !*(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01 )
		      sub_1800D8260(v18, v17);
		    additionalCameraData = (Object_1 *)HG::Rendering::Runtime::HGCamera::get_additionalCameraData(
		                                         *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		                                         0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(additionalCameraData, 0LL) )
		    {
		      if ( !*(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01 )
		        sub_1800D8260(v21, v20);
		      v22 = HG::Rendering::Runtime::HGCamera::get_additionalCameraData(
		              *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		              0LL);
		      if ( !v22 )
		        sub_1800D8260(v24, v23);
		      v22->fields.materialMipBias = 0.0;
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x31u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    v151[0].handle = 0LL;
		    v151[0].fallBackResource = (ResourceHandle)v149;
		    try
		    {
		      sub_18033B9D0(&v169, 0LL, 164LL);
		      v169.sceneColor = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      v169.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      v169.utilityDepth = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m02;
		      v169.sceneMV = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		      v169.historySceneColor = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m23;
		      v27 = *(Vector2Int **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !v27 )
		        sub_1800D8250(v26, v25);
		      v169.screenSize = v27[3];
		      v28 = *(Vector2Int **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !v28 )
		        sub_1800D8250(v26, v25);
		      v169.renderSize = v28[6];
		      v29 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v169.renderingScale = HG::Rendering::Runtime::HGUtils::GetRenderingScale(v29, P5, 0LL);
		      if ( !P5 )
		        sub_1800D8250(v31, v30);
		      v169.historyWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                             P5->fields._historyWeight_k__BackingField,
		                             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.historyWeightInMotion = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                     P5->fields._historyWeightInMotion_k__BackingField,
		                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.fastConvergeHistoryWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                         P5->fields._fastConvergeHistoryWeight_k__BackingField,
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.responsiveAAHistoryWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                         P5->fields._responsiveAAWeight_k__BackingField,
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.minMVConsideredDynamic = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                      P5->fields._minMotion_k__BackingField,
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.maxMVConsideredDynamic = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                      P5->fields._maxMotion_k__BackingField,
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.characterMotionSensitivity = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                          P5->fields._characterMotionSensitivity_k__BackingField,
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.occlusionDepthDiff = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                  P5->fields._occlusionDepthDiff_k__BackingField,
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.inputSampleLumaWeight = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                     P5->fields._inputLumaWeight_k__BackingField,
		                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.sharpenStrength1K = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                 P5->fields._sharpenStrength1K_k__BackingField,
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.sharpenStrength2K = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                 P5->fields._sharpenStrength2K_k__BackingField,
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.sharpenStrength4K = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                 P5->fields._sharpenStrength4K_k__BackingField,
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      v169.quality = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                       (SettingParameter_1_System_Int32Enum_ *)P5->fields._taauQuality_k__BackingField,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
		      v33 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !v33 )
		        sub_1800D8250(0LL, v32);
		      v169.enableTAAU = HG::Rendering::Runtime::HGCamera::get_enableTAAU(v33, 0LL);
		      v169.enableResponsiveTransparency = hgrp->fields._enableResponsiveTransparency_k__BackingField;
		      v169.fastConvergeState = hgrp->fields._fastConvergeState_k__BackingField;
		      v169.renderPathFrameIndex = v4->fields._._renderPathFrameIndex_k__BackingField;
		      input = v169;
		      output = 0LL;
		      v34 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !v34 )
		        sub_1800D8250(0LL, 128LL);
		      v35 = (Object_1 *)HG::Rendering::Runtime::HGCamera::get_additionalCameraData(v34, 0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Implicit(v35, 0LL) )
		      {
		        v37 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		        if ( !v37 )
		          sub_1800D8250(0LL, v36);
		        if ( HG::Rendering::Runtime::HGCamera::get_enableTAAU(v37, 0LL) )
		        {
		          v38 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		          if ( !v38 )
		            sub_1800D8250(0LL, v36);
		          v39 = HG::Rendering::Runtime::HGCamera::get_additionalCameraData(v38, 0LL);
		          v41 = sub_182F114D0();
		          v42 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		          if ( !v42 )
		            sub_1800D8250(0LL, v40);
		          v43 = HG::Rendering::Runtime::HGCamera::get_additionalCameraData(v42, 0LL);
		          if ( !v43 )
		            sub_1800D8250(v44, v36);
		          materialMipBias = *(float *)&v41 - 1.0;
		          if ( v43->fields.materialMipBias <= (float)(*(float *)&v41 - 1.0) )
		            materialMipBias = v43->fields.materialMipBias;
		          if ( !v39 )
		            sub_1800D8250(v44, v36);
		          v39->fields.materialMipBias = materialMipBias;
		        }
		      }
		      v46 = *(TAAUPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevViewNoTransProjMatrix.m22;
		      if ( !v46 )
		        sub_1800D8250(0LL, v36);
		      HG::Rendering::Runtime::TAAUPassConstructor::ConstructPass(
		        v46,
		        &input,
		        &output,
		        v11,
		        *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		        0LL);
		      *(TAAUPassConstructor_PassOutput *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03 = output;
		      hgrp->fields._fastConvergeState_k__BackingField = 0;
		    }
		    catch ( Il2CppExceptionWrapper *v172 )
		    {
		      v151[0].handle = (ResourceHandle)v172->ex;
		      if ( v151[0].handle )
		        sub_18007E1E0(*(_QWORD *)&v151[0].handle);
		      v3 = renderPathParams;
		      v4 = this;
		      hgrp = v157;
		      v11 = v159;
		      P5 = settingParameters_k__BackingField;
		      cullingResults = v168;
		    }
		    v47 = *(_OWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		    v48 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    *(_OWORD *)v161 = v47;
		    HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		      RTExtractionType__Enum_SceneColorLS,
		      (TextureHandle *)v161,
		      v48,
		      v11,
		      0LL);
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x34u,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    output.currentSceneColor.handle = 0LL;
		    output.currentSceneColor.fallBackResource = (ResourceHandle)v149;
		    try
		    {
		      v51 = (Rect)*HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                     &v150,
		                     (HGRenderPathBase *)v4,
		                     PassConstructorID__Enum_UberPost,
		                     0LL);
		      v158 = v51;
		      v167.sceneColor = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m03;
		      v167.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      v167.sceneMV = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m01;
		      v167.target = (TextureHandle)v51;
		      v167.hgrp = hgrp;
		      if ( dword_18F35FD08 )
		      {
		        v52 = (((unsigned __int64)&v167.hgrp >> 12) & 0x1FFFFF) >> 6;
		        v49 = ((unsigned __int64)&v167.hgrp >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v52 + 36190]);
		        do
		        {
		          v50 = qword_18F0BCBA0[v52 + 36190] | (1LL << v49);
		          v53 = qword_18F0BCBA0[v52 + 36190];
		        }
		        while ( v53 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v52 + 36190], v50, v53) );
		      }
		      v167.cullingResults = cullingResults;
		      if ( !P5 )
		        sub_1800D8250(v50, v49);
		      v167.taauQuality = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                           (SettingParameter_1_System_Int32Enum_ *)P5->fields._taauQuality_k__BackingField,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
		      v167.depthBits = v3->perFrameSetup.depthBits;
		      v167.depthFormat = v3->perFrameSetup.depthGraphicsFormat;
		      v167.renderPath = v4->fields._._renderPath_k__BackingField;
		      if ( *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 )
		        v54 = HG::Rendering::Runtime::HGCamera::get_renderPath(
		                *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03,
		                0LL) == HGRenderPath__Enum_UI3D;
		      else
		        v54 = 0;
		      v167.render3DUI = v54;
		      v167.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v157, 0LL);
		      if ( !hgCamera )
		        sub_1800D8250(v56, v55);
		      *(_QWORD *)&v167.screenCullingRatio = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		      v167.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		      P1 = v167;
		      memset(&P2, 0, sizeof(P2));
		      v59 = *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00;
		      v60 = *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !v59 )
		        sub_1800D8250(v58, v57);
		      *(_OWORD *)v161 = 0LL;
		      if ( IFix::WrappersManagerImpl::IsPatched(2946, 0LL) )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(2946, 0LL);
		        if ( !Patch )
		          sub_1800D8250(v102, v101);
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1096(
		          Patch,
		          (Object *)v59,
		          &P1,
		          &P2,
		          (Object *)v11,
		          (Object *)v60,
		          (Object *)P5,
		          0LL);
		      }
		      else
		      {
		        if ( !v60 )
		          sub_1800D8250(v62, v61);
		        if ( IFix::WrappersManagerImpl::IsPatched(783, 0LL) )
		        {
		          v65 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		          if ( !v65 )
		            sub_1800D8250(v67, v66);
		          v64 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v65, (Object *)v60, 0LL);
		        }
		        else
		        {
		          v64 = *(HGCamera_VolumeComponentsData **)(v60 + 2504);
		        }
		        if ( !v64 )
		          sub_1800D8250(v63, 0LL);
		        *(_QWORD *)(v59 + 552) = v64->fields.m_bloom;
		        v68 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v69 = (((unsigned __int64)(v59 + 552) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v69 + 36190]);
		          do
		            v70 = qword_18F0BCBA0[v69 + 36190];
		          while ( v70 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v69 + 36190],
		                           v70 | (1LL << (((unsigned __int64)(v59 + 552) >> 12) & 0x3F)),
		                           v70) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 560) = v64->fields.m_vignette;
		        if ( v68 )
		        {
		          v71 = (((unsigned __int64)(v59 + 560) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v71 + 36190]);
		          do
		            v72 = qword_18F0BCBA0[v71 + 36190];
		          while ( v72 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v71 + 36190],
		                           v72 | (1LL << (((unsigned __int64)(v59 + 560) >> 12) & 0x3F)),
		                           v72) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 568) = v64->fields.m_hgVignette;
		        if ( v68 )
		        {
		          v73 = (((unsigned __int64)(v59 + 568) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v73 + 36190]);
		          do
		            v74 = qword_18F0BCBA0[v73 + 36190];
		          while ( v74 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v73 + 36190],
		                           v74 | (1LL << (((unsigned __int64)(v59 + 568) >> 12) & 0x3F)),
		                           v74) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 576) = v64->fields.m_hgDirtyLens;
		        if ( v68 )
		        {
		          v75 = (((unsigned __int64)(v59 + 576) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v75 + 36190]);
		          do
		            v76 = qword_18F0BCBA0[v75 + 36190];
		          while ( v76 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v75 + 36190],
		                           v76 | (1LL << (((unsigned __int64)(v59 + 576) >> 12) & 0x3F)),
		                           v76) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 584) = v64->fields.m_sharpen;
		        if ( v68 )
		        {
		          v77 = (((unsigned __int64)(v59 + 584) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v77 + 36190]);
		          do
		            v78 = qword_18F0BCBA0[v77 + 36190];
		          while ( v78 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v77 + 36190],
		                           v78 | (1LL << (((unsigned __int64)(v59 + 584) >> 12) & 0x3F)),
		                           v78) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 592) = v64->fields.m_radialBlur;
		        if ( v68 )
		        {
		          v79 = (((unsigned __int64)(v59 + 592) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v79 + 36190]);
		          do
		            v80 = qword_18F0BCBA0[v79 + 36190];
		          while ( v80 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v79 + 36190],
		                           v80 | (1LL << (((unsigned __int64)(v59 + 592) >> 12) & 0x3F)),
		                           v80) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 600) = v64->fields.m_bwFlash;
		        if ( v68 )
		        {
		          v81 = (((unsigned __int64)(v59 + 600) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v81 + 36190]);
		          do
		            v82 = qword_18F0BCBA0[v81 + 36190];
		          while ( v82 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v81 + 36190],
		                           v82 | (1LL << (((unsigned __int64)(v59 + 600) >> 12) & 0x3F)),
		                           v82) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 608) = v64->fields.m_fisheyeEffect;
		        if ( v68 )
		        {
		          v83 = (((unsigned __int64)(v59 + 608) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v83 + 36190]);
		          do
		            v84 = qword_18F0BCBA0[v83 + 36190];
		          while ( v84 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v83 + 36190],
		                           v84 | (1LL << (((unsigned __int64)(v59 + 608) >> 12) & 0x3F)),
		                           v84) );
		          v68 = dword_18F35FD08;
		        }
		        *(_QWORD *)(v59 + 616) = v64->fields.m_chromaticAbberation;
		        if ( v68 )
		        {
		          v85 = (((unsigned __int64)(v59 + 616) >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v85 + 36190]);
		          do
		            v86 = qword_18F0BCBA0[v85 + 36190];
		          while ( v86 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v85 + 36190],
		                           v86 | (1LL << (((unsigned __int64)(v59 + 616) >> 12) & 0x3F)),
		                           v86) );
		        }
		        *(_BYTE *)(v59 + 626) = P1.render3DUI;
		        sceneColor = P1.sceneColor;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        if ( HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess((HGCamera *)v60, 0LL) )
		        {
		          v89 = *(HGSharpen **)(v59 + 584);
		          if ( !v89 )
		            sub_1800D8250(0LL, v88);
		          if ( HG::Rendering::Runtime::HGSharpen::IsActive(v89, 0LL)
		            && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                 P5->fields._sharpenEnabled_k__BackingField,
		                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		          {
		            v154.handle = *(ResourceHandle *)(v59 + 584);
		            v179 = *(Material **)(v59 + 56);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		            v151[0] = sceneColor;
		            sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::SharpenPass(
		                            &v150,
		                            v11,
		                            (HGCamera *)v60,
		                            v151,
		                            *(HGSharpen **)&v154.handle,
		                            v179,
		                            0LL);
		          }
		          v91 = *(HGFisheyeEffect **)(v59 + 608);
		          if ( !v91 )
		            sub_1800D8250(0LL, v90);
		          if ( HG::Rendering::Runtime::HGFisheyeEffect::IsActive(v91, 0LL) )
		          {
		            v93 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                    P5->fields._fisheyeEffectEnabled_k__BackingField,
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		            sceneDepth = P1.sceneDepth;
		            if ( v93 )
		            {
		              v153 = *(HGFisheyeEffect **)(v59 + 608);
		              v154.handle = *(ResourceHandle *)(v59 + 32);
		              v179 = *(Material **)(v59 + 40);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		              v151[0] = sceneDepth;
		              v152 = sceneColor;
		              sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::FisheyeEffectPass(
		                              &v150,
		                              P5,
		                              v11,
		                              (HGCamera *)v60,
		                              v153,
		                              *(Material **)&v154.handle,
		                              v179,
		                              &v152,
		                              v151,
		                              (TextureHandle *)v161,
		                              0LL);
		              sceneDepth = *(TextureHandle *)v161;
		            }
		          }
		          else
		          {
		            sceneDepth = P1.sceneDepth;
		          }
		          LODWORD(v153) = *(_DWORD *)(v59 + 544);
		          LODWORD(v179) = *(_DWORD *)(v59 + 548);
		          v154.handle = *(ResourceHandle *)(v59 + 48);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          v94 = *HG::Rendering::Runtime::UberPostPassUtils::ColorGradingPass(
		                   &v150,
		                   v11,
		                   (HGCamera *)v60,
		                   (int32_t)v153,
		                   (GraphicsFormat__Enum)v179,
		                   *(Material **)&v154.handle,
		                   (UberPostPassUtils_CachedColorGradingData *)(v59 + 176),
		                   (RTHandle **)(v59 + 168),
		                   0LL);
		          if ( *(_BYTE *)(v59 + 624) )
		            LODWORD(v179) = 1;
		          else
		            LODWORD(v179) = *(unsigned __int8 *)(v59 + 626);
		          v151[0].handle = *(ResourceHandle *)(v59 + 552);
		          sceneMV = P1.sceneMV;
		          v154.handle.m_Value = P1.taauQuality;
		          LODWORD(v153) = P1.renderPath;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		          v152 = sceneMV;
		          v150 = sceneColor;
		          v96 = *HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
		                   v151,
		                   v11,
		                   (HGCamera *)v60,
		                   P5,
		                   *(Bloom **)&v151[0].handle,
		                   (_DWORD)v179 != 0,
		                   &v150,
		                   &v152,
		                   (TAAUQuality__Enum)v154.handle.m_Value,
		                   (HGRenderPathInternal__Enum)v153,
		                   (UberPostPassUtils_BloomPSMaterials *)(v59 + 136),
		                   (Vector4 *)(v59 + 120),
		                   0LL);
		          v97 = *(_DWORD *)(v59 + 544);
		          v150 = v94;
		          v152 = sceneColor;
		          v98 = *HG::Rendering::Runtime::UberPostPassUtils::FrostedGlassPass(
		                   v151,
		                   v11,
		                   (HGCamera *)v60,
		                   P5,
		                   &v152,
		                   &v150,
		                   v97,
		                   (UberPostPassUtils_FrostedGlassPSMaterials *)(v59 + 104),
		                   (RTHandle__Array **)(v59 + 88),
		                   (Vector2Int__Array **)(v59 + 96),
		                   0LL);
		          v150 = sceneColor;
		          HG::Rendering::Runtime::UberPostPassUtils::ExecuteAutoExposure(v11, &v150, (HGCamera *)v60, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		          if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_useCutsceneEffsectShader )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
		            if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect->static_fields->m_enableCompatibilityMode )
		            {
		              target = P1.target;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		              v150 = sceneColor;
		              v152 = sceneDepth;
		              v151[0] = target;
		              sceneColor = *HG::Rendering::Runtime::UberPostPassUtils::CutsceneEffectPass(
		                              &v154,
		                              P5,
		                              v11,
		                              (HGCamera *)v60,
		                              v151,
		                              &v152,
		                              &v150,
		                              0LL);
		            }
		          }
		          v150 = v96;
		          v152 = v94;
		          v151[0] = sceneColor;
		          HG::Rendering::Runtime::PostProcessPassConstructor::UberPass(
		            &v154,
		            (PostProcessPassConstructor *)v59,
		            &P1,
		            P5,
		            v11,
		            (HGCamera *)v60,
		            v151,
		            &v152,
		            &v150,
		            0LL);
		          *(_BYTE *)(v60 + 2458) = *(_BYTE *)(v60 + 2457);
		          *(_BYTE *)(v60 + 2457) = 0;
		          P2.frostedGlassRT = v98;
		        }
		        else
		        {
		          v151[0] = sceneColor;
		          v154 = P1.target;
		          HG::Rendering::Runtime::PostProcessPassConstructor::FinalPass(
		            (PostProcessPassConstructor *)v59,
		            v11,
		            (HGCamera *)v60,
		            &v154,
		            v151,
		            0LL);
		        }
		      }
		      frostedGlassRT = P2.frostedGlassRT;
		      v104 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v150 = frostedGlassRT;
		      HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		        RTExtractionType__Enum_BlurredSceneColorPS,
		        &v150,
		        v104,
		        v11,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v173 )
		    {
		      v105 = &v148;
		      output.currentSceneColor.handle = (ResourceHandle)v173->ex;
		      if ( output.currentSceneColor.handle )
		        sub_18007E1E0(*(_QWORD *)&output.currentSceneColor.handle);
		      v4 = this;
		      v11 = v159;
		      P5 = settingParameters_k__BackingField;
		      cullingResults = v168;
		      v51 = v158;
		    }
		    v106 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    if ( !v106 )
		      sub_1800D8250(0LL, v105);
		    enableMetalFXSpatialScaler = HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler(v106, 0LL);
		    v108 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    v150 = (TextureHandle)v51;
		    LOBYTE(v108) = HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		                     RTExtractionType__Enum_SceneColorPS,
		                     &v150,
		                     v108,
		                     v11,
		                     0LL);
		    v150 = (TextureHandle)v51;
		    v109 = enableMetalFXSpatialScaler | (unsigned __int8)v108 | HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
		                                                                  RTExtractionType__Enum_FinalResult,
		                                                                  &v150,
		                                                                  *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		                                                                  v11,
		                                                                  0LL);
		    LOBYTE(v179) = v109;
		    if ( *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 )
		    {
		      v112 = v109;
		      if ( !v109 )
		        goto LABEL_112;
		    }
		    else
		    {
		      v110 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v150 = (TextureHandle)v51;
		      v111 = HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(&v150, v110, v11, 0LL);
		      if ( !((unsigned __int8)v179 | v111) )
		      {
		        v112 = 0;
		        goto LABEL_112;
		      }
		      v112 = 1;
		    }
		    v113 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		              &v150,
		              (HGRenderPathBase *)v4,
		              PassConstructorID__Enum_UI,
		              0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		    v150 = 0LL;
		    v152 = v113;
		    v158 = v51;
		    HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		      v11,
		      (TextureHandle *)&v158,
		      &v152,
		      1,
		      -1,
		      1,
		      (Rect *)&v150,
		      0,
		      0LL);
		LABEL_112:
		    if ( *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03 )
		    {
		      UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		        (Int32Enum__Enum)0x37u,
		        MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		      output.currentSceneColor.handle = 0LL;
		      output.currentSceneColor.fallBackResource = (ResourceHandle)v149;
		      try
		      {
		        v114 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                  &v150,
		                  (HGRenderPathBase *)v4,
		                  PassConstructorID__Enum_UI,
		                  0LL);
		        sub_18033B9D0(&v165, 0LL, 80LL);
		        v165.target = v114;
		        v165.sceneDepth = *(TextureHandle *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		        v115 = v157;
		        v165.hgrp = v157;
		        if ( dword_18F35FD08 )
		        {
		          v116 = (((unsigned __int64)&v165.hgrp >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v116 + 36190]);
		          do
		            v117 = qword_18F0BCBA0[v116 + 36190];
		          while ( v117 != _InterlockedCompareExchange64(
		                            &qword_18F0BCBA0[v116 + 36190],
		                            v117 | (1LL << (((unsigned __int64)&v165.hgrp >> 12) & 0x3F)),
		                            v117) );
		        }
		        v165.cullingResults = cullingResults;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v165.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_2D_LAYER.m_Mask;
		        v165.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v115, 0LL);
		        if ( !hgCamera )
		          sub_1800D8250(v119, v118);
		        *(_QWORD *)&v165.screenCullingRatio = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		        v165.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		        v175 = v165;
		        LOBYTE(v179) = 0;
		        v121 = *(UIPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m01;
		        if ( !v121 )
		          sub_1800D8250(0LL, v120);
		        HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
		          v121,
		          &v175,
		          (UIPassConstructor_PassOutput *)&v179,
		          v11,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03,
		          P5,
		          0LL);
		        if ( !v112 )
		        {
		          v124 = *(ComposablePass **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m00;
		          if ( !v124 )
		            sub_1800D8250(0LL, v122);
		          HG::Rendering::Runtime::ComposablePass::SetChildPass(
		            v124,
		            v11,
		            *(ComposablePass **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m01,
		            0LL);
		        }
		        v125 = *(_QWORD *)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		        if ( !v125 )
		          sub_1800D8250(v123, v122);
		        if ( *(int *)(v125 + 2424) > 0 )
		        {
		          v126 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                    &v150,
		                    (HGRenderPathBase *)v4,
		                    PassConstructorID__Enum_Multiblur,
		                    0LL);
		          memset(&v161[5], 0, 32);
		          *(TextureHandle *)&v161[2] = v126;
		          v161[4] = v115;
		          if ( dword_18F35FD08 )
		          {
		            v127 = (((unsigned __int64)&v161[4] >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F0BCBA0[v127 + 36190]);
		            do
		              v128 = qword_18F0BCBA0[v127 + 36190];
		            while ( v128 != _InterlockedCompareExchange64(
		                              &qword_18F0BCBA0[v127 + 36190],
		                              v128 | (1LL << (((unsigned __int64)&v161[4] >> 12) & 0x3F)),
		                              v128) );
		          }
		          *(CullingResults *)&v161[5] = cullingResults;
		          v161[7] = *(_QWORD *)&hgCamera->fields.screenCullingRatio;
		          LODWORD(v161[8]) = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
		          v170 = *(MultiblurPassConstructor_PassInput *)&v161[2];
		          LOBYTE(v179) = 0;
		          v130 = *(MultiblurPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m21;
		          if ( !v130 )
		            sub_1800D8250(0LL, v129);
		          HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
		            v130,
		            &v170,
		            (MultiblurPassConstructor_PassOutput *)&v179,
		            v11,
		            *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03,
		            P5,
		            0LL);
		          if ( v4->fields._._firstBackbufferPass_k__BackingField == 57 )
		          {
		            backBufferColor_k__BackingField = v4->fields._._backBufferColor_k__BackingField;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		            v150 = 0LL;
		            v152 = backBufferColor_k__BackingField;
		            v158 = (Rect)v126;
		            HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		              v11,
		              (TextureHandle *)&v158,
		              &v152,
		              0,
		              -1,
		              1,
		              (Rect *)&v150,
		              0,
		              0LL);
		          }
		        }
		        v133 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
		                  &v150,
		                  (HGRenderPathBase *)v4,
		                  PassConstructorID__Enum_ScreenSpaceOverlay,
		                  0LL);
		        v134 = v133;
		        v162 = v133;
		        v163 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		        if ( dword_18F35FD08 )
		        {
		          v135 = (((unsigned __int64)&v163 >> 12) & 0x1FFFFF) >> 6;
		          v132 = ((unsigned __int64)&v163 >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v135 + 36190]);
		          do
		            v136 = qword_18F0BCBA0[v135 + 36190];
		          while ( v136 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v135 + 36190], v136 | (1LL << v132), v136) );
		          v134 = v162;
		        }
		        v166.target = v134;
		        v166.camera = v163;
		        LOBYTE(v179) = 0;
		        v137 = *(ScreenSpaceOverlayPassConstructor **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02;
		        if ( !v137 )
		          sub_1800D8250(0LL, v132);
		        HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
		          v137,
		          &v166,
		          (ScreenSpaceOverlayPassConstructor_PassOutput *)&v179,
		          v11,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03,
		          P5,
		          0LL);
		        if ( v4->fields._._firstBackbufferPass_k__BackingField < 57 )
		        {
		          PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
		                              (HGRenderPathBase *)v4,
		                              (PassConstructorID__Enum)v4->fields._._firstBackbufferPass_k__BackingField,
		                              0LL);
		          v139 = *(ComposablePass **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m02;
		          if ( !sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass) )
		            sub_1800D8250(v141, v140);
		          v142 = (ComposablePass *)sub_180005050(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass);
		          HG::Rendering::Runtime::ComposablePass::SetChildPass(v142, v11, v139, 0LL);
		        }
		        v143 = *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m03;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v150 = v133;
		        HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(RTExtractionType__Enum_FinalResult, &v150, v143, v11, 0LL);
		        v150 = v133;
		        HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
		          &v150,
		          *(HGCamera **)&v4[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01,
		          v11,
		          0LL);
		        if ( v4->fields._._firstBackbufferPass_k__BackingField > 57 )
		        {
		          v144 = v4->fields._._backBufferColor_k__BackingField;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
		          v150 = 0LL;
		          v152 = v144;
		          v158 = (Rect)v133;
		          HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
		            v11,
		            (TextureHandle *)&v158,
		            &v152,
		            0,
		            -1,
		            1,
		            (Rect *)&v150,
		            0,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v174 )
		      {
		        output.currentSceneColor.handle = (ResourceHandle)v174->ex;
		        if ( output.currentSceneColor.handle )
		          sub_18007E1E0(*(_QWORD *)&output.currentSceneColor.handle);
		      }
		    }
		    return;
		  }
		  v145 = IFix::WrappersManagerImpl::GetPatch(3648, 0LL);
		  if ( !v145 )
		    sub_1800D8260(v147, v146);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(v145, (Object *)v4, v3, 0LL);
		}
		
		protected virtual void RenderEditorPrimitives(ref HGRenderPathParams renderPathParams) {} // 0x0000000189BFF8C4-0x0000000189BFFA30
		// Void RenderEditorPrimitives(HGRenderPathBase+HGRenderPathParams ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRenderPathScene::RenderEditorPrimitives(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *renderPathParams,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  TextureHandle backBufferColor_k__BackingField; // xmm2
		  TextureHandle backBufferDepth_k__BackingField; // xmm3
		  SetFinalTargetPassConstructor *v8; // rdi
		  HGRenderPipeline *hgrp; // rcx
		  HGRenderGraph *renderGraph; // rax
		  __int64 v11; // rdx
		  HGCamera *camera; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  SetFinalTargetPassConstructor_PassOutput output; // [rsp+30h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v17; // [rsp+38h] [rbp-60h] BYREF
		  Il2CppException *ex; // [rsp+40h] [rbp-58h]
		  char *v19; // [rsp+48h] [rbp-50h]
		  SetFinalTargetPassConstructor_PassInput input; // [rsp+50h] [rbp-48h] BYREF
		  char v21; // [rsp+B8h] [rbp+20h] BYREF
		
		  v21 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3661, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3661, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_457(Patch, (Object *)this, renderPathParams, 0LL);
		  }
		  else
		  {
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0x3Bu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
		    ex = 0LL;
		    v19 = &v21;
		    try
		    {
		      sub_18033B9D0(&input, 0LL, 64LL);
		      backBufferColor_k__BackingField = this->fields._._backBufferColor_k__BackingField;
		      backBufferDepth_k__BackingField = this->fields._._backBufferDepth_k__BackingField;
		      input.sceneDepth = *(TextureHandle *)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewNoTransProjMatrix.m00;
		      input.backBufferColor = backBufferColor_k__BackingField;
		      input.backBufferDepth = backBufferDepth_k__BackingField;
		      output = 0;
		      v8 = *(SetFinalTargetPassConstructor **)&this[1].fields._.m_basicTransformConstants._PrevNonJitteredViewProjMatrix.m22;
		      hgrp = renderPathParams->hgrp;
		      if ( !hgrp )
		        sub_1800D8250(0LL, v5);
		      renderGraph = HG::Rendering::Runtime::HGRenderPipeline::get_renderGraph(hgrp, 0LL);
		      camera = *(HGCamera **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      if ( !v8 )
		        sub_1800D8250(camera, v11);
		      HG::Rendering::Runtime::SetFinalTargetPassConstructor::ConstructPass(
		        v8,
		        &input,
		        &output,
		        renderGraph,
		        camera,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      ex = v17->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private void UpdateShaderVariablesGlobalMaterialStylizer(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189C03524-0x0000000189C03874
		// Void UpdateShaderVariablesGlobalMaterialStylizer(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalMaterialStylizer(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  void *monitor; // rdx
		  __int64 v8; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  Object_1 *m_sceneColorStylizer; // rbx
		  Object_1__Class *klass; // rsi
		  __int64 v12; // rax
		  void *m_CachedPtr; // r8
		  Vector4 *v14; // rax
		  void *v15; // r8
		  Vector4 *v16; // rax
		  double v17; // xmm0_8
		  float v18; // xmm10_4
		  double v19; // xmm0_8
		  unsigned int v20; // xmm9_4
		  double v21; // xmm0_8
		  float v22; // xmm8_4
		  double v23; // xmm0_8
		  Object_1__Class *v24; // r8
		  float v25; // xmm7_4
		  Vector4 *v26; // rax
		  double v27; // xmm0_8
		  float v28; // xmm6_4
		  double v29; // xmm0_8
		  double v30; // xmm0_8
		  double v31; // xmm0_8
		  MethodInfo *v32; // r8
		  MethodInfo *v33; // r8
		  __m128i v34; // xmm1
		  MethodInfo *v35; // r8
		  Color *v36; // rax
		  __m128i v37; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v39; // [rsp+38h] [rbp-49h]
		  Vector4 v40; // [rsp+40h] [rbp-41h]
		  Color v41; // [rsp+50h] [rbp-31h] BYREF
		  Vector4 v42; // [rsp+68h] [rbp-19h] BYREF
		  Vector4 v43; // [rsp+78h] [rbp-9h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3620, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		      if ( volumeComponentsData )
		      {
		        m_sceneColorStylizer = (Object_1 *)volumeComponentsData->fields.m_sceneColorStylizer;
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( !UnityEngine::Object::op_Inequality(m_sceneColorStylizer, 0LL, 0LL) )
		        {
		          *(__m128i *)&cb->_IVV2Param0.y = _mm_load_si128((const __m128i *)&xmmword_18DC813E0);
		          *(_OWORD *)&cb->_IVV2Param1.y = 0LL;
		          *(_OWORD *)&cb->_IVV2Param2.y = 0LL;
		          return;
		        }
		        if ( m_sceneColorStylizer )
		        {
		          monitor = m_sceneColorStylizer[2].monitor;
		          klass = m_sceneColorStylizer[2].klass;
		          if ( monitor )
		          {
		            v12 = sub_180041350(10LL);
		            m_CachedPtr = m_sceneColorStylizer[4].fields.m_CachedPtr;
		            v39 = v12;
		            if ( m_CachedPtr )
		            {
		              v14 = (Vector4 *)sub_180032E40(&v43, 10LL, m_CachedPtr);
		              v15 = m_sceneColorStylizer[2].fields.m_CachedPtr;
		              v42 = *v14;
		              if ( v15 )
		              {
		                v16 = (Vector4 *)sub_180032E40(&v43, 10LL, v15);
		                monitor = m_sceneColorStylizer[3].klass;
		                v43 = *v16;
		                if ( monitor )
		                {
		                  v17 = sub_1800057D0(10LL, monitor);
		                  monitor = m_sceneColorStylizer[3].monitor;
		                  v18 = *(float *)&v17;
		                  if ( monitor )
		                  {
		                    v19 = sub_1800057D0(10LL, monitor);
		                    monitor = m_sceneColorStylizer[3].fields.m_CachedPtr;
		                    v20 = LODWORD(v19);
		                    if ( monitor )
		                    {
		                      v21 = sub_1800057D0(10LL, monitor);
		                      monitor = m_sceneColorStylizer[5].klass;
		                      v22 = *(float *)&v21;
		                      if ( monitor )
		                      {
		                        v23 = sub_1800057D0(10LL, monitor);
		                        v24 = m_sceneColorStylizer[4].klass;
		                        v25 = *(float *)&v23;
		                        if ( v24 )
		                        {
		                          v26 = (Vector4 *)sub_180032E40(&v41, 10LL, v24);
		                          monitor = m_sceneColorStylizer[4].monitor;
		                          v40 = *v26;
		                          if ( monitor )
		                          {
		                            v27 = sub_1800057D0(10LL, monitor);
		                            v28 = *(float *)&v27;
		                            if ( klass )
		                            {
		                              v29 = sub_1800057D0(10LL, klass);
		                              v42.w = *(float *)&v29 * v42.w;
		                              v30 = sub_1800057D0(10LL, klass);
		                              v43.w = *(float *)&v30 * v43.w;
		                              v31 = sub_1800057D0(10LL, klass);
		                              v40.w = *(float *)&v31 * v40.w;
		                              v40.x = v40.x * v28;
		                              v40.y = v40.y * v28;
		                              v40.z = v40.z * v28;
		                              *(_QWORD *)&v41.r = v39;
		                              v41.b = v25;
		                              v41.a = v22;
		                              *(Color *)&cb->_IVV2Param0.y = v41;
		                              *(__m128i *)&cb->_IVV2Param1.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                                  &v41,
		                                                                                                  &v42,
		                                                                                                  v32));
		                              v34 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                       (Color *)&v42,
		                                                                       &v43,
		                                                                       v33));
		                              v43 = v40;
		                              *(__m128i *)&cb->_IVV2Param3.y = v34;
		                              v36 = UnityEngine::Color::op_Implicit((Color *)&v42, &v43, v35);
		                              v41.a = 0.0;
		                              v41.r = v18;
		                              v37 = _mm_loadu_si128((const __m128i *)v36);
		                              *(_QWORD *)&v41.g = v20;
		                              *(__m128i *)&cb->_WaterInteractionParams0.y = v37;
		                              *(Color *)&cb->_WaterInteractionParams1.y = v41;
		                              return;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_19:
		    sub_1800D8260(v8, monitor);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3620, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalEnvironment(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189C03380-0x0000000189C03434
		// Void UpdateShaderVariablesGlobalEnvironment(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalEnvironment(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v11; // [rsp+30h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3621, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    if ( InterpolatedPhase )
		    {
		      *(_QWORD *)&v11 = *(_QWORD *)&InterpolatedPhase->fields.lightConfig.indirectDiffuseFactor;
		      *((_QWORD *)&v11 + 1) = 1065353216LL;
		      *(_OWORD *)&cb->_WindMotorCount.z = v11;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3621, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalCloudShadow(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189C032E0-0x0000000189C03380
		// Void UpdateShaderVariablesGlobalCloudShadow(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCloudShadow(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGSkyRenderer *s_skyRenderer; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3622, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    s_skyRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(0LL);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    if ( s_skyRenderer )
		    {
		      HG::Rendering::Runtime::HGSkyRenderer::SetupShaderVariablesGlobalCloudShadow(
		        s_skyRenderer,
		        cb,
		        InterpolatedPhase,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3622, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		}
		
		private void UpdateShaderVariablesGraphFeaturesGlobalParam0(ref ShaderVariablesGlobal cb, HGCamera hgCamera, HGSettingParameters settingParameters) {} // 0x0000000189C04298-0x0000000189C0438C
		// Void UpdateShaderVariablesGraphFeaturesGlobalParam0(ShaderVariablesGlobal ByRef, HGCamera, HGSettingParameters)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGraphFeaturesGlobalParam0(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3623, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      cb->_LastWindGlobalParams0.z = (float)HG::Rendering::Runtime::HGCamera::get_aoEnable(hgCamera, 0LL);
		      cb->_LastWindGlobalParams0.w = (float)HG::Rendering::Runtime::HGCamera::get_ssrEnable(hgCamera, 0LL);
		      cb->_LastWindMotorParams0.FixedElementField = 1.0;
		      cb->_LastWindMotorParams1.FixedElementField = 1.0;
		      if ( settingParameters )
		      {
		        cb->_LastWindMotorParams3.FixedElementField = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                                                    (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._reflectionProbeMaxSampleMip_k__BackingField,
		                                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3623, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_584(
		    Patch,
		    (Object *)this,
		    cb,
		    (Object *)hgCamera,
		    (Object *)settingParameters,
		    0LL);
		}
		
		public static bool ShouldRenderAtmosphereFog(HGCamera hgCamera) => default; // 0x00000001832517B0-0x00000001832518B0
		// Boolean ShouldRenderAtmosphereFog(HGCamera)
		bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderAtmosphereFog(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *camera; // rdi
		  __int64 (__fastcall *v6)(Camera *); // rax
		  int v7; // eax
		  struct HGAtmosphereRenderer__Class *v8; // rcx
		  int v9; // edi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_16;
		  if ( wrapperArray->max_length.size <= 953 )
		    goto LABEL_30;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_16;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3B9 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[20]._0.events )
		  {
		LABEL_30:
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		      {
		        v6 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		        if ( !qword_18F36F120 )
		        {
		          v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cullingMask()");
		          if ( !v6 )
		          {
		            v13 = sub_1802EE1B8("UnityEngine.Camera::get_cullingMask()");
		            sub_18007E1B0(v13, 0LL);
		          }
		          qword_18F36F120 = (__int64)v6;
		        }
		        v7 = v6(camera);
		        v8 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
		        v9 = v7;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		          v8 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
		        }
		        if ( !_bittest(&v9, v8->static_fields->FOG_LAYER & 0x1F) )
		          return 0;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		        if ( InterpolatedPhase )
		          return InterpolatedPhase->fields.fogConfig.enable;
		      }
		    }
		LABEL_16:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(953, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)hgCamera, 0LL);
		}
		
		public static bool ShouldRenderHeightFog(HGCamera hgCamera) => default; // 0x00000001832518B0-0x0000000183251A40
		// Boolean ShouldRenderHeightFog(HGCamera)
		bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFog(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *s_settingParameters; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *camera; // rdi
		  __int64 (__fastcall *v6)(Camera *); // rax
		  int v7; // eax
		  struct HGAtmosphereRenderer__Class *v8; // rcx
		  int v9; // edi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rdi
		  struct HGVolumetricFogRenderer__Class *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rax
		  HGEnvironmentPhase *v16; // rax
		
		  s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = s_settingParameters->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( wrapperArray->max_length.size > 954 )
		  {
		    if ( !s_settingParameters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(s_settingParameters);
		      s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)s_settingParameters->static_fields->wrapperArray;
		    if ( !s_settingParameters )
		      goto LABEL_23;
		    if ( LODWORD(s_settingParameters->_0.namespaze) <= 0x3BA )
		      sub_1800D2AB0(s_settingParameters, wrapperArray);
		    if ( s_settingParameters[20]._0.properties )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(954, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)hgCamera,
		                 0LL);
		      goto LABEL_23;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_23;
		  camera = hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_23;
		  v6 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		  if ( !qword_18F36F120 )
		  {
		    v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cullingMask()");
		    if ( !v6 )
		    {
		      v15 = sub_1802EE1B8("UnityEngine.Camera::get_cullingMask()");
		      sub_18007E1B0(v15, 0LL);
		    }
		    qword_18F36F120 = (__int64)v6;
		  }
		  v7 = v6(camera);
		  v8 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
		  v9 = v7;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    v8 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
		  }
		  if ( !_bittest(&v9, v8->static_fields->FOG_LAYER & 0x1F) )
		    return 0;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_23;
		  p_volumetricFogConfig = &InterpolatedPhase->fields.volumetricFogConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		  if ( !HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(p_volumetricFogConfig, 0LL) )
		    goto LABEL_35;
		  v13 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		    v13 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
		  }
		  s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)v13->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		LABEL_23:
		    sub_1800D8260(s_settingParameters, wrapperArray);
		  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         (SettingParameter_1_System_Boolean_ *)s_settingParameters->_0.name,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    return 1;
		  }
		LABEL_35:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  v16 = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !v16 )
		    goto LABEL_23;
		  return v16->fields.heightFogConfig.enable;
		}
		
		public static bool ShouldRenderHeightFogDirectionalInscattering(HGCamera hgCamera) => default; // 0x0000000189C02720-0x0000000189C028A4
		// Boolean ShouldRenderHeightFogDirectionalInscattering(HGCamera)
		bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFogDirectionalInscattering(
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  void *camera; // rcx
		  int32_t cullingMask; // ebx
		  HGEnvironmentPhase *InterpolatedPhase; // rbx
		  MethodInfo *v7; // rdx
		  Quaternion v8; // xmm1
		  Quaternion v10; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v12; // [rsp+20h] [rbp-28h] BYREF
		  Quaternion heightFogDirectionalInscattering; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3663, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		      {
		        cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)camera, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		        if ( !_bittest(
		                &cullingMask,
		                TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->static_fields->FOG_LAYER & 0x1F) )
		          return 0;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		        if ( InterpolatedPhase )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		          if ( !HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(
		                  &InterpolatedPhase->fields.volumetricFogConfig,
		                  0LL) )
		            goto LABEL_11;
		          v8 = *UnityEngine::Quaternion::get_identity(&heightFogDirectionalInscattering, v7);
		          heightFogDirectionalInscattering = (Quaternion)InterpolatedPhase->fields.volumetricFogConfig.heightFogDirectionalInscattering;
		          v12 = (Color)v8;
		          if ( (unsigned __int8)sub_182FA61B0(&heightFogDirectionalInscattering, &v12) )
		            goto LABEL_11;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		          camera = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		          if ( camera )
		          {
		            if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                   *((SettingParameter_1_System_Boolean_ **)camera + 2),
		                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		            {
		              return 1;
		            }
		LABEL_11:
		            if ( InterpolatedPhase->fields.heightFogConfig.enable )
		            {
		              v10 = *UnityEngine::Quaternion::get_identity(&heightFogDirectionalInscattering, v7);
		              v12 = InterpolatedPhase->fields.heightFogConfig.heightFogDirectionalInscattering;
		              heightFogDirectionalInscattering = v10;
		              return sub_182FA61B0(&v12, &heightFogDirectionalInscattering) ^ 1;
		            }
		            return 0;
		          }
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(camera, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3663, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)hgCamera, 0LL);
		}
		
		public static bool ShouldRenderVolumetricFog(HGCamera hgCamera) => default; // 0x0000000183251A40-0x0000000183251C10
		// Boolean ShouldRenderVolumetricFog(HGCamera)
		bool HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderVolumetricFog(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *s_settingParameters; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *camera; // rdi
		  unsigned __int8 (__fastcall *v6)(Camera *); // rax
		  Camera *v7; // rdi
		  __int64 (__fastcall *v8)(Camera *); // rax
		  int v9; // eax
		  struct HGAtmosphereRenderer__Class *v10; // rcx
		  int v11; // edi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  HGVolumetricFogConfig *p_volumetricFogConfig; // rbx
		  struct HGVolumetricFogRenderer__Class *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rax
		  __int64 v18; // rax
		
		  s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = s_settingParameters->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_28;
		  if ( wrapperArray->max_length.size <= 958 )
		    goto LABEL_45;
		  if ( !s_settingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(s_settingParameters);
		    s_settingParameters = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)s_settingParameters->static_fields->wrapperArray;
		  if ( !s_settingParameters )
		    goto LABEL_28;
		  if ( LODWORD(s_settingParameters->_0.namespaze) <= 0x3BE )
		    sub_1800D2AB0(s_settingParameters, wrapperArray);
		  if ( !s_settingParameters[20].interfaceOffsets )
		  {
		LABEL_45:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		    if ( !HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL) )
		      return 0;
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		      {
		        v6 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F100;
		        if ( !qword_18F36F100 )
		        {
		          v6 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_orthographic()");
		          if ( !v6 )
		          {
		            v17 = sub_1802EE1B8("UnityEngine.Camera::get_orthographic()");
		            sub_18007E1B0(v17, 0LL);
		          }
		          qword_18F36F100 = (__int64)v6;
		        }
		        if ( v6(camera) )
		          return 0;
		        v7 = hgCamera->fields.camera;
		        if ( v7 )
		        {
		          v8 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		          if ( !qword_18F36F120 )
		          {
		            v8 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cullingMask()");
		            if ( !v8 )
		            {
		              v18 = sub_1802EE1B8("UnityEngine.Camera::get_cullingMask()");
		              sub_18007E1B0(v18, 0LL);
		            }
		            qword_18F36F120 = (__int64)v8;
		          }
		          v9 = v8(v7);
		          v10 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
		          v11 = v9;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		            v10 = TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer;
		          }
		          if ( !_bittest(&v11, v10->static_fields->FOG_LAYER & 0x1F) )
		            return 0;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		          InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		          if ( InterpolatedPhase )
		          {
		            p_volumetricFogConfig = &InterpolatedPhase->fields.volumetricFogConfig;
		            if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		            if ( !HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(p_volumetricFogConfig, 0LL) )
		              return 0;
		            v15 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
		            if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		              v15 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer;
		            }
		            s_settingParameters = (struct ILFixDynamicMethodWrapper_2__Class *)v15->static_fields->s_settingParameters;
		            if ( s_settingParameters )
		              return HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                       (SettingParameter_1_System_Boolean_ *)s_settingParameters->_0.name,
		                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          }
		        }
		      }
		    }
		LABEL_28:
		    sub_1800D8260(s_settingParameters, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(958, 0LL);
		  if ( !Patch )
		    goto LABEL_28;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)hgCamera, 0LL);
		}
		
		public static bool ShouldBakeFogLut(HGCamera hgCamera) => default; // 0x0000000183DBB750-0x0000000183DBB820
		// Boolean ShouldBakeFogLut(HGCamera)
		bool HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(HGCamera *hgCamera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  _DWORD *wrapperArray; // rdx
		  Object *instance; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rax
		  Object__Class *klass; // rax
		  int32_t namespaze; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_14;
		  if ( (int)wrapperArray[6] > 959 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_14;
		    if ( wrapperArray[6] <= 0x3BFu )
		      goto LABEL_29;
		    if ( *((_QWORD *)wrapperArray + 963) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(959, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)hgCamera,
		                 0LL);
		      goto LABEL_14;
		    }
		  }
		  instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_14;
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields;
		  v3 = *(struct ILFixDynamicMethodWrapper_2__Class **)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_14;
		  if ( SLODWORD(v3->_0.namespaze) <= 672 )
		    goto LABEL_10;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_14:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x2A0 )
		LABEL_29:
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[14]._0.properties )
		  {
		    v11 = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		    if ( v11 )
		    {
		      namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v11, instance, 0LL);
		      goto LABEL_12;
		    }
		    goto LABEL_14;
		  }
		LABEL_10:
		  klass = instance[1].klass;
		  if ( !klass )
		    goto LABEL_14;
		  namespaze = (int32_t)klass->_0.namespaze;
		LABEL_12:
		  if ( namespaze != 1
		    || !UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE, 0LL) )
		  {
		    return 0;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		  if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderAtmosphereFog(hgCamera, 0LL) )
		    return 1;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPathScene->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		  return HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFog(hgCamera, 0LL);
		}
		
		internal void UpdateShaderVariablesGlobalAtmosphere(ref ShaderVariablesGlobal cb, HGCamera hgCamera, CommandBuffer cmd, HGAtmosphereSettingParameters atmosphereParams) {} // 0x0000000189C0294C-0x0000000189C02B68
		// Void UpdateShaderVariablesGlobalAtmosphere(ShaderVariablesGlobal ByRef, HGCamera, CommandBuffer, HGAtmosphereSettingParameters)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalAtmosphere(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        HGAtmosphereSettingParameters *atmosphereParams,
		        MethodInfo *method)
		{
		  HGAtmosphereRenderer *s_atmosphereRenderer; // rsi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGAtmosphereRenderer *v14; // rax
		  HGVolumetricFogRenderer *s_volumetricFogRenderer; // rax
		  HGAtmosphereRenderer *v16; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3625, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		    if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderAtmosphereFog(hgCamera, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_atmosphereRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(0LL);
		      InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		      if ( !s_atmosphereRenderer )
		        goto LABEL_19;
		      HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalAtmosphereFog(
		        s_atmosphereRenderer,
		        cb,
		        hgCamera,
		        InterpolatedPhase,
		        0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalAtmosphereFog(cb, 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		    if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderHeightFog(hgCamera, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      v14 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(0LL);
		      if ( !v14 )
		        goto LABEL_19;
		      HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalHeightFog(v14, cb, hgCamera, 0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalHeightFog(cb, 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		    if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldRenderVolumetricFog(hgCamera, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_volumetricFogRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_volumetricFogRenderer(0LL);
		      if ( !s_volumetricFogRenderer )
		        goto LABEL_19;
		      HG::Rendering::Runtime::HGVolumetricFogRenderer::SetupShaderVariablesGlobalVolumetricFog(
		        s_volumetricFogRenderer,
		        cb,
		        hgCamera,
		        0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		      HG::Rendering::Runtime::HGVolumetricFogRenderer::ResetShaderVariablesGlobalVolumetricFog(cb, 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		    if ( !HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(hgCamera, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		      HG::Rendering::Runtime::HGAtmosphereRenderer::ResetShaderVariablesGlobalBakeFogLut(cb, 0LL);
		      return;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    v16 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(0LL);
		    if ( v16 )
		    {
		      HG::Rendering::Runtime::HGAtmosphereRenderer::SetupShaderVariablesGlobalBakeFogLut(
		        v16,
		        cb,
		        hgCamera,
		        atmosphereParams,
		        0LL);
		      return;
		    }
		LABEL_19:
		    sub_1800D8260(Patch, v12);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3625, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(
		    Patch,
		    (Object *)this,
		    cb,
		    (Object *)hgCamera,
		    (Object *)cmd,
		    (Object *)atmosphereParams,
		    0LL);
		}
		
		private void UpdateShaderVariablesGlobalCharacter(ref ShaderVariablesGlobal cb, HGCamera hgCamera, CommandBuffer cmd, RainCommonPreSettingParam rainRes) {} // 0x0000000189C02B68-0x0000000189C032E0
		// Void UpdateShaderVariablesGlobalCharacter(ShaderVariablesGlobal ByRef, HGCamera, CommandBuffer, RainCommonPreSettingParam)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalCharacter(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        RainCommonPreSettingParam *rainRes,
		        MethodInfo *method)
		{
		  MethodInfo *charMainLightControl; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGCharacterVolume *m_hgCharacterVolume; // rbx
		  float v14; // xmm6_4
		  float v15; // xmm0_4
		  double v16; // xmm0_8
		  double v17; // xmm0_8
		  double v18; // xmm0_8
		  float v19; // xmm0_4
		  int v20; // eax
		  float v21; // xmm0_4
		  float v22; // xmm0_4
		  MethodInfo *v23; // r8
		  MethodInfo *v24; // r8
		  ColorParameter *charSkinMainLightOverrideColor; // rax
		  ColorParameter *charMainLightOverrideColor; // r8
		  MethodInfo *v27; // r8
		  ColorParameter *v28; // r8
		  MethodInfo *v29; // r8
		  Vector4Parameter *charGlobalAmbientParam0; // r8
		  Vector4Parameter *charGlobalAmbientParam1; // r8
		  ColorParameter *charAutoRimColor; // r8
		  Quaternion *identity; // rax
		  MethodInfo *v34; // r8
		  double v35; // xmm0_8
		  double v36; // xmm0_8
		  Vector3 *CharAutoRimVector; // rax
		  __int64 v38; // xmm0_8
		  MethodInfo *v39; // r8
		  double v40; // xmm0_8
		  double v41; // xmm0_8
		  Transform *transform; // rax
		  Vector3 *CharLightVector; // rax
		  __int64 v44; // xmm0_8
		  MethodInfo *v45; // r8
		  double v46; // xmm0_8
		  ClampedFloatParameter *charMainLightRangeBias; // rax
		  float v48; // xmm0_4
		  ColorParameter *v49; // rax
		  float v50; // xmm0_4
		  float v51; // xmm0_4
		  float v52; // xmm0_4
		  double v53; // xmm0_8
		  double v54; // xmm0_8
		  double v55; // xmm0_8
		  double v56; // xmm0_8
		  ColorParameter *charFaceRimColor; // r8
		  Quaternion *v58; // rax
		  MethodInfo *v59; // r8
		  double v60; // xmm0_8
		  double v61; // xmm0_8
		  Vector3 *CharFaceRimVector; // rax
		  __int64 v63; // xmm0_8
		  MethodInfo *v64; // r8
		  float v65; // xmm0_4
		  double v66; // xmm0_8
		  double v67; // xmm0_8
		  Color v68; // [rsp+40h] [rbp-30h] BYREF
		  Color v69; // [rsp+50h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3626, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3626, 0LL);
		    if ( !Patch )
		      goto LABEL_84;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(
		      Patch,
		      (Object *)this,
		      cb,
		      (Object *)hgCamera,
		      (Object *)cmd,
		      (Object *)rainRes,
		      0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      goto LABEL_84;
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		    if ( !volumeComponentsData )
		      goto LABEL_84;
		    m_hgCharacterVolume = volumeComponentsData->fields.m_hgCharacterVolume;
		    if ( !m_hgCharacterVolume )
		      goto LABEL_84;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charMainLightControl;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v14 = 1.0;
		    v15 = (unsigned __int8)sub_180006280(10LL, charMainLightControl) ? 1.0 : 0.0;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charMainLightMultiplier;
		    cb->_RainWetnessGlobalParam4.y = v15;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v16 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charEnvLightMultiplier;
		    cb->_RainWetnessGlobalParam4.z = *(float *)&v16;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v17 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charEnvShadowMultiplier;
		    cb->_RainWetnessGlobalParam4.w = *(float *)&v17;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v18 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charLightDialogMode;
		    cb->_RainWetnessGlobalParam5.x = *(float *)&v18;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v19 = (unsigned __int8)sub_180006280(10LL, charMainLightControl) ? 1.0 : 0.0;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charShadowTintControl;
		    cb->_RainWetnessGlobalParam5.y = v19;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v20 = sub_180002F70(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charIgnoreMainLightShadow;
		    cb->_RainWetnessGlobalParam5.z = (float)v20;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v21 = (unsigned __int8)sub_180006280(10LL, charMainLightControl) ? 1.0 : 0.0;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charMainLightMode;
		    cb->_RainWetnessGlobalParam5.w = v21;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v22 = (unsigned int)sub_180002F70(10LL, charMainLightControl) ? 1.0 : 0.0;
		    cb->_RainWetnessGlobalParam6.x = v22;
		    v69 = *HG::Rendering::Runtime::HGCharacterVolume::GetShadowTintColor(&v69, m_hgCharacterVolume, 0LL);
		    *(__m128i *)&cb->_RainWetnessGlobalParam6.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                     &v68,
		                                                                                     (Vector4 *)&v69,
		                                                                                     v23));
		    v69 = *HG::Rendering::Runtime::HGCharacterVolume::GetSkinShadowTintColor(&v69, m_hgCharacterVolume, 0LL);
		    *(__m128i *)&cb->_RainWetnessGlobalParam7.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                     &v68,
		                                                                                     (Vector4 *)&v69,
		                                                                                     v24));
		    charSkinMainLightOverrideColor = m_hgCharacterVolume->fields.charSkinMainLightOverrideColor;
		    if ( !charSkinMainLightOverrideColor )
		      goto LABEL_84;
		    if ( charSkinMainLightOverrideColor->fields._._.overrideState )
		    {
		      charMainLightOverrideColor = m_hgCharacterVolume->fields.charSkinMainLightOverrideColor;
		    }
		    else
		    {
		      charMainLightOverrideColor = m_hgCharacterVolume->fields.charMainLightOverrideColor;
		      if ( !charMainLightOverrideColor )
		        goto LABEL_84;
		    }
		    v69 = (Color)_mm_loadu_si128((const __m128i *)sub_180032E40(&v69, 10LL, charMainLightOverrideColor));
		    *(__m128i *)&cb->_RainWetnessGlobalParam8.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                     &v68,
		                                                                                     (Vector4 *)&v69,
		                                                                                     v27));
		    v28 = m_hgCharacterVolume->fields.charMainLightOverrideColor;
		    if ( !v28 )
		      goto LABEL_84;
		    v69 = *(Color *)sub_180032E40(&v69, 10LL, v28);
		    *(__m128i *)&cb->_RainWetnessGlobalParam9.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                     &v68,
		                                                                                     (Vector4 *)&v69,
		                                                                                     v29));
		    charGlobalAmbientParam0 = m_hgCharacterVolume->fields.charGlobalAmbientParam0;
		    if ( !charGlobalAmbientParam0 )
		      goto LABEL_84;
		    *(__m128i *)&cb->_RainWetnessGlobalParam10.y = _mm_loadu_si128((const __m128i *)sub_180032E40(
		                                                                                      &v69,
		                                                                                      10LL,
		                                                                                      charGlobalAmbientParam0));
		    charGlobalAmbientParam1 = m_hgCharacterVolume->fields.charGlobalAmbientParam1;
		    if ( !charGlobalAmbientParam1 )
		      goto LABEL_84;
		    *(__m128i *)&cb->_VerticalOcclusionMapParam0.y = _mm_loadu_si128((const __m128i *)sub_180032E40(
		                                                                                        &v69,
		                                                                                        10LL,
		                                                                                        charGlobalAmbientParam1));
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charAutoRimEnable;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    if ( (unsigned __int8)sub_180006280(10LL, charMainLightControl) )
		    {
		      charAutoRimColor = m_hgCharacterVolume->fields.charAutoRimColor;
		      if ( !charAutoRimColor )
		        goto LABEL_84;
		      identity = (Quaternion *)sub_180032E40(&v69, 10LL, charAutoRimColor);
		    }
		    else
		    {
		      identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v69, charMainLightControl);
		    }
		    v69 = (Color)_mm_loadu_si128((const __m128i *)identity);
		    *(__m128i *)&cb->_WaterWetnessMaskParam0.y = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                    &v68,
		                                                                                    (Vector4 *)&v69,
		                                                                                    v34));
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charAutoRimIntensity;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v35 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charAutoRimDir;
		    cb->_GpuClothParams.x = *(float *)&v35;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v36 = sub_1800057D0(10LL, charMainLightControl);
		    CharAutoRimVector = HG::Rendering::Runtime::HGCharacterVolume::GetCharAutoRimVector(
		                          (Vector3 *)&v69,
		                          m_hgCharacterVolume,
		                          *(float *)&v36,
		                          0LL);
		    v38 = *(_QWORD *)&CharAutoRimVector->x;
		    *(float *)&CharAutoRimVector = CharAutoRimVector->z;
		    *(_QWORD *)&v68.r = v38;
		    LODWORD(v68.b) = (_DWORD)CharAutoRimVector;
		    *(__m128i *)&cb->_GpuClothParams.y = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                            (Vector4 *)&v69,
		                                                                            (Vector3 *)&v68,
		                                                                            v39));
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charAutoRimAlbedo;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v40 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charAutoRimWidth;
		    cb->_GpuClothParams.w = *(float *)&v40;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v41 = sub_1800057D0(10LL, charMainLightControl);
		    cb->_FoliageOccluderParams0.x = *(float *)&v41;
		    Patch = (ILFixDynamicMethodWrapper_2 *)hgCamera->fields.camera;
		    if ( !Patch )
		      goto LABEL_84;
		    transform = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
		    CharLightVector = HG::Rendering::Runtime::HGCharacterVolume::GetCharLightVector(
		                        (Vector3 *)&v69,
		                        m_hgCharacterVolume,
		                        transform,
		                        0LL);
		    v44 = *(_QWORD *)&CharLightVector->x;
		    *(float *)&CharLightVector = CharLightVector->z;
		    *(_QWORD *)&v68.r = v44;
		    LODWORD(v68.b) = (_DWORD)CharLightVector;
		    *(__m128i *)&cb->_FoliageOccluderCameraPosParam.y = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                                           (Vector4 *)&v69,
		                                                                                           (Vector3 *)&v68,
		                                                                                           v45));
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charMainLightRangeBias;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v46 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightRangeBias = m_hgCharacterVolume->fields.charMainLightRangeBias;
		    cb->_InteractRaftParams0.x = *(float *)&v46;
		    if ( !charMainLightRangeBias )
		      goto LABEL_84;
		    v48 = charMainLightRangeBias->fields._._._.overrideState ? 1.0 : 0.0;
		    v49 = m_hgCharacterVolume->fields.charMainLightOverrideColor;
		    cb->_InteractRaftParams0.y = v48;
		    if ( !v49 )
		      goto LABEL_84;
		    v50 = v49->fields._._.overrideState ? 1.0 : 0.0;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charIgnoreSceneAdditionalLights;
		    cb->_InteractRaftParams0.z = v50;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v51 = (unsigned __int8)sub_180006280(10LL, charMainLightControl) ? 0.0 : 1.0;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charIgnoreSceneEnv;
		    cb->_InteractRaftParams0.w = v51;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v52 = (unsigned __int8)sub_180006280(10LL, charMainLightControl) ? 1.0 : 0.0;
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charEyeBaseLightMultiplier;
		    cb->_InteractRaftParams1.x = v52;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v53 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charEyeHighlightMultiplier;
		    cb->_InteractRaftParams1.y = *(float *)&v53;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v54 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charEyeScatteringMultiplier;
		    cb->_InteractRaftParams1.z = *(float *)&v54;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v55 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charMainLightSpecularMultiplier;
		    cb->_InteractRaftParams1.w = *(float *)&v55;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v56 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charFaceRimEnable;
		    cb->_FakePlanarReflectionViewProjMatrix.m00 = *(float *)&v56;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    if ( (unsigned __int8)sub_180006280(10LL, charMainLightControl) )
		    {
		      charFaceRimColor = m_hgCharacterVolume->fields.charFaceRimColor;
		      if ( !charFaceRimColor )
		        goto LABEL_84;
		      v58 = (Quaternion *)sub_180032E40(&v69, 10LL, charFaceRimColor);
		    }
		    else
		    {
		      v58 = UnityEngine::Quaternion::get_identity((Quaternion *)&v69, charMainLightControl);
		    }
		    v69 = (Color)_mm_loadu_si128((const __m128i *)v58);
		    *(__m128i *)&cb->_FakePlanarReflectionViewProjMatrix.m10 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                                  &v68,
		                                                                                                  (Vector4 *)&v69,
		                                                                                                  v59));
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charFaceRimIntensity;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v60 = sub_1800057D0(10LL, charMainLightControl);
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charFaceRimDir;
		    cb->_FakePlanarReflectionViewProjMatrix.m01 = *(float *)&v60;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    v61 = sub_1800057D0(10LL, charMainLightControl);
		    CharFaceRimVector = HG::Rendering::Runtime::HGCharacterVolume::GetCharFaceRimVector(
		                          (Vector3 *)&v69,
		                          m_hgCharacterVolume,
		                          *(float *)&v61,
		                          0LL);
		    v63 = *(_QWORD *)&CharFaceRimVector->x;
		    *(float *)&CharFaceRimVector = CharFaceRimVector->z;
		    *(_QWORD *)&v68.r = v63;
		    LODWORD(v68.b) = (_DWORD)CharFaceRimVector;
		    *(__m128i *)&cb->_FakePlanarReflectionViewProjMatrix.m11 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                                                  (Vector4 *)&v69,
		                                                                                                  (Vector3 *)&v68,
		                                                                                                  v64));
		    charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charAutoRimMode;
		    if ( !charMainLightControl )
		      goto LABEL_84;
		    if ( (unsigned __int8)sub_180006280(10LL, charMainLightControl) )
		      v65 = 1.0;
		    else
		      v65 = 0.0;
		    cb->_FakePlanarReflectionViewProjMatrix.m02 = v65;
		    if ( rainRes )
		    {
		      if ( !HG::Rendering::Runtime::HGCharacterVolume::GetRainEffectPreviewEnabled(m_hgCharacterVolume, 0LL) )
		        v14 = 0.0;
		      cb->_FoliageOccluderParams0.y = v14;
		      cb->_FoliageOccluderParams0.z = HG::Rendering::Runtime::HGCharacterVolume::GetPackedEnvironmentEffectIntensity(
		                                        m_hgCharacterVolume,
		                                        0LL);
		      if ( HG::Rendering::Runtime::HGCharacterVolume::GetRainEffectPreviewEnabled(m_hgCharacterVolume, 0LL) )
		      {
		        charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charRainEffectTextureTiling;
		        if ( !charMainLightControl )
		          goto LABEL_84;
		        v66 = sub_1800057D0(10LL, charMainLightControl);
		      }
		      else
		      {
		        *(float *)&v66 = rainRes->fields.characterRainTextureTiling;
		      }
		      charMainLightControl = (MethodInfo *)m_hgCharacterVolume->fields.charWetEffectPreviewWorldHeight;
		      cb->_FoliageOccluderParams0.w = *(float *)&v66;
		      if ( charMainLightControl )
		      {
		        v67 = sub_1800057D0(10LL, charMainLightControl);
		        cb->_FoliageOccluderCameraPosParam.x = *(float *)&v67;
		        return;
		      }
		LABEL_84:
		      sub_1800D8260(Patch, charMainLightControl);
		    }
		  }
		}
		
		private void UpdateShaderVariablesGlobalWind(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189C03E80-0x0000000189C03FB4
		// Void UpdateShaderVariablesGlobalWind(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWind(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v8; // rdx
		  Object_1 *camera; // rcx
		  HGWindManager *windManager_k__BackingField; // rdi
		  int32_t InstanceID; // eax
		  int32_t v12; // ebp
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // r14d
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v18; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v19[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3627, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      windManager_k__BackingField = currentManagerContext->fields._windManager_k__BackingField;
		      if ( hgCamera )
		      {
		        camera = (Object_1 *)hgCamera->fields.camera;
		        if ( camera )
		        {
		          InstanceID = UnityEngine::Object::GetInstanceID(camera, 0LL);
		          camera = (Object_1 *)hgCamera->fields.camera;
		          v12 = InstanceID;
		          if ( camera )
		          {
		            transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		            if ( transform )
		            {
		              position = UnityEngine::Transform::get_position(v19, transform, 0LL);
		              z = position->z;
		              *(_QWORD *)&v18.x = *(_QWORD *)&position->x;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		              InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		              if ( windManager_k__BackingField )
		              {
		                v18.z = z;
		                HG::Rendering::Runtime::HGWindManager::SetupShaderVariablesGlobalWind(
		                  windManager_k__BackingField,
		                  cb,
		                  v12,
		                  &v18,
		                  InterpolatedPhase,
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(camera, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3627, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalFoliageInteract(ref ShaderVariablesGlobal cb) {} // 0x0000000189C03434-0x0000000189C034AC
		// Void UpdateShaderVariablesGlobalFoliageInteract(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageInteract(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3633, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      foliageInteractiveManager_k__BackingField = currentManagerContext->fields._foliageInteractiveManager_k__BackingField;
		      if ( foliageInteractiveManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGFoliageInteractiveManager::SetupShaderVariablesGlobalFoliageInteract(
		          foliageInteractiveManager_k__BackingField,
		          cb,
		          0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(foliageInteractiveManager_k__BackingField, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3633, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalRainAndWetness(ref ShaderVariablesGlobal cb, ref ScriptableRenderContext context, HGCamera hgCamera, CommandBuffer cmd) {} // 0x0000000189C03874-0x0000000189C03C6C
		// Void UpdateShaderVariablesGlobalRainAndWetness(ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef, HGCamera, CommandBuffer)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalRainAndWetness(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        ScriptableRenderContext *context,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  HGRainRenderer *s_rainRenderer; // rax
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *rainWetnessGlobalParams; // rcx
		  __int64 v13; // r9
		  CommandBuffer *v14; // rbx
		  GlobalKeyword *p_s_RainWetnessHighQuality; // rdx
		  bool enableWetnessHighQuality; // r8
		  __int64 v17; // r9
		  __int64 v18; // r9
		  __int64 v19; // r9
		  __int64 v20; // r9
		  __int64 v21; // r9
		  __int64 v22; // r9
		  __int64 v23; // r9
		  __int64 v24; // r9
		  __int64 v25; // r9
		  __int64 v26; // r9
		  bool success; // [rsp+40h] [rbp-20h] BYREF
		  RainWetnessGlobalProps *outProps; // [rsp+48h] [rbp-18h] BYREF
		  __int128 v29; // [rsp+50h] [rbp-10h] BYREF
		
		  outProps = 0LL;
		  success = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3629, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		    if ( hgCamera && s_rainRenderer )
		    {
		      HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessShaderVariables(
		        s_rainRenderer,
		        hgCamera,
		        context,
		        hgCamera->fields.verticalOcclusionMapManager,
		        &outProps,
		        &success,
		        0LL);
		      if ( success )
		      {
		        if ( outProps )
		        {
		          rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps->fields.rainWetnessGlobalParams;
		          if ( rainWetnessGlobalParams )
		          {
		            sub_180002990(rainWetnessGlobalParams, &v29, 0LL, v13);
		            rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		            *(_OWORD *)&cb[1]._BinningBufferOffsets.m_Z = v29;
		            if ( rainWetnessGlobalParams )
		            {
		              rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		              if ( rainWetnessGlobalParams )
		              {
		                sub_180002990(rainWetnessGlobalParams, &v29, 1LL, v17);
		                rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                *(_OWORD *)&cb[1]._EnvironmentGlobalParams0.z = v29;
		                if ( rainWetnessGlobalParams )
		                {
		                  rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                  if ( rainWetnessGlobalParams )
		                  {
		                    sub_180002990(rainWetnessGlobalParams, &v29, 2LL, v18);
		                    rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                    *(_OWORD *)&cb[1]._GraphicsFeaturesGlobalParam0.z = v29;
		                    if ( rainWetnessGlobalParams )
		                    {
		                      rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                      if ( rainWetnessGlobalParams )
		                      {
		                        sub_180002990(rainWetnessGlobalParams, &v29, 3LL, v19);
		                        rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                        *(_OWORD *)&cb[1]._GraphicsFeaturesGlobalParam1.z = v29;
		                        if ( rainWetnessGlobalParams )
		                        {
		                          rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                          if ( rainWetnessGlobalParams )
		                          {
		                            sub_180002990(rainWetnessGlobalParams, &v29, 4LL, v20);
		                            rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                            *(_OWORD *)&cb[1]._WindGlobalParams0.z = v29;
		                            if ( rainWetnessGlobalParams )
		                            {
		                              rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                              if ( rainWetnessGlobalParams )
		                              {
		                                sub_180002990(rainWetnessGlobalParams, &v29, 5LL, v21);
		                                rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                                *(_OWORD *)&cb[1]._WindGlobalParams2.z = v29;
		                                if ( rainWetnessGlobalParams )
		                                {
		                                  rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                                  if ( rainWetnessGlobalParams )
		                                  {
		                                    sub_180002990(rainWetnessGlobalParams, &v29, 6LL, v22);
		                                    rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                                    *(_OWORD *)&cb[1]._CharacterPositionParams0.z = v29;
		                                    if ( rainWetnessGlobalParams )
		                                    {
		                                      rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                                      if ( rainWetnessGlobalParams )
		                                      {
		                                        sub_180002990(rainWetnessGlobalParams, &v29, 7LL, v23);
		                                        rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                                        *(_OWORD *)&cb[1]._CharacterPositionParams1.z = v29;
		                                        if ( rainWetnessGlobalParams )
		                                        {
		                                          rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                                          if ( rainWetnessGlobalParams )
		                                          {
		                                            sub_180002990(rainWetnessGlobalParams, &v29, 8LL, v24);
		                                            rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                                            *(_OWORD *)&cb[1]._CharacterPositionParams2.z = v29;
		                                            if ( rainWetnessGlobalParams )
		                                            {
		                                              rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                                              if ( rainWetnessGlobalParams )
		                                              {
		                                                sub_180002990(rainWetnessGlobalParams, &v29, 9LL, v25);
		                                                rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)outProps;
		                                                *(_OWORD *)&cb[1]._CharacterPositionParams3.z = v29;
		                                                if ( rainWetnessGlobalParams )
		                                                {
		                                                  rainWetnessGlobalParams = (ILFixDynamicMethodWrapper_2 *)rainWetnessGlobalParams->fields.virtualMachine;
		                                                  if ( rainWetnessGlobalParams )
		                                                  {
		                                                    sub_180002990(rainWetnessGlobalParams, &v29, 10LL, v26);
		                                                    *(_OWORD *)&cb[1]._CharacterHeightParams.z = v29;
		                                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		                                                    if ( outProps )
		                                                    {
		                                                      v14 = cmd;
		                                                      if ( cmd )
		                                                      {
		                                                        UnityEngine::Rendering::CommandBuffer::SetKeyword(
		                                                          cmd,
		                                                          &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableWetness,
		                                                          outProps->fields.enableWetness,
		                                                          0LL);
		                                                        if ( outProps )
		                                                        {
		                                                          enableWetnessHighQuality = outProps->fields.enableWetnessHighQuality;
		                                                          p_s_RainWetnessHighQuality = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RainWetnessHighQuality;
		                                                          goto LABEL_33;
		                                                        }
		                                                      }
		                                                    }
		                                                  }
		                                                }
		                                              }
		                                            }
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		        v14 = cmd;
		        if ( cmd )
		        {
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_EnableWetness,
		            0,
		            0LL);
		          p_s_RainWetnessHighQuality = &TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_RainWetnessHighQuality;
		          enableWetnessHighQuality = 0;
		LABEL_33:
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            v14,
		            p_s_RainWetnessHighQuality,
		            enableWetnessHighQuality,
		            0LL);
		          return;
		        }
		      }
		    }
		LABEL_35:
		    sub_1800D8260(rainWetnessGlobalParams, v11);
		  }
		  rainWetnessGlobalParams = IFix::WrappersManagerImpl::GetPatch(3629, 0LL);
		  if ( !rainWetnessGlobalParams )
		    goto LABEL_35;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1277(
		    rainWetnessGlobalParams,
		    (Object *)this,
		    cb,
		    context,
		    (Object *)hgCamera,
		    (Object *)cmd,
		    0LL);
		}
		
		private void UpdateShaderVariablesGlobalVerticalOcclusionMap(ref ShaderVariablesGlobal cb, HGCamera camera) {} // 0x0000000189C03C6C-0x0000000189C03D10
		// Void UpdateShaderVariablesGlobalVerticalOcclusionMap(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalVerticalOcclusionMap(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  bool enabled; // [rsp+30h] [rbp-28h] BYREF
		  Vector4 param; // [rsp+38h] [rbp-20h] BYREF
		
		  enabled = 0;
		  param = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3630, 0LL) )
		  {
		    if ( camera )
		    {
		      verticalOcclusionMapManager = camera->fields.verticalOcclusionMapManager;
		      if ( verticalOcclusionMapManager )
		      {
		        HG::Rendering::Runtime::HGVerticalOcclusionMapManager::GetVerticalOcclusionMapShaderVariables(
		          verticalOcclusionMapManager,
		          &param,
		          &enabled,
		          0LL);
		        *(Vector4 *)&cb[1]._WindMotorParams2.FixedElementField = param;
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(verticalOcclusionMapManager, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3630, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)camera, 0LL);
		}
		
		private void UpdateShaderVariablesGlobalFoliageOccluder(ref ShaderVariablesGlobal cb) {} // 0x0000000189C034AC-0x0000000189C03524
		// Void UpdateShaderVariablesGlobalFoliageOccluder(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalFoliageOccluder(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  HGFoliageOccluderManager *foliageOccluderManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3632, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      foliageOccluderManager_k__BackingField = currentManagerContext->fields._foliageOccluderManager_k__BackingField;
		      if ( foliageOccluderManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGFoliageOccluderManager::SetShaderVariablesGlobalFoliageOccluder(
		          foliageOccluderManager_k__BackingField,
		          cb,
		          0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(foliageOccluderManager_k__BackingField, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3632, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		}
		
		private void UpdateWaterWetnessMaskParam(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189C0438C-0x0000000189C04440
		// Void UpdateWaterWetnessMaskParam(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateWaterWetnessMaskParam(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float v9; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v11; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3631, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3631, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !hgCamera )
		    goto LABEL_8;
		  if ( hgCamera->fields.useWetnessMask )
		    v9 = 1.0;
		  else
		    v9 = 0.0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(__m128i *)&cb[1]._WindMotorCount.z = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                            &v11,
		                                                                            v9,
		                                                                            0LL));
		}
		
		private void OverrideShaderVariablesGlobal(HGRenderGraph renderGraph, HGCamera targetCamera, bool useScreenSize) {} // 0x0000000189BFF33C-0x0000000189BFF6C0
		// Void OverrideShaderVariablesGlobal(HGRenderGraph, HGCamera, Boolean)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGRenderPathScene::OverrideShaderVariablesGlobal(
		        HGRenderPathScene *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *targetCamera,
		        bool useScreenSize,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  Object *v12; // rcx
		  int v13; // eax
		  unsigned __int64 v14; // r9
		  unsigned __int64 v15; // r8
		  signed __int64 v16; // rtt
		  Object *v17; // r8
		  unsigned int v18; // r8d
		  unsigned __int64 v19; // r9
		  char v20; // r8
		  signed __int64 v21; // rtt
		  Object *v22; // rcx
		  Object *v23; // rdi
		  BasicTransformConstants *basicTransformConstants; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  Object *v27; // rdi
		  ShaderVariablesGlobal *shaderVariablesGlobal; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  Object *v33; // rdi
		  UIShaderVariablesGlobal *uiShaderVariablesGlobal; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  Vector4 ProjectionParams; // xmm1
		  Vector4 ScreenParams; // xmm2
		  Vector4 ZBufferParams; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  Object *v43; // [rsp+30h] [rbp-CE8h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+40h] [rbp-CD8h] BYREF
		  HGRenderGraphBuilder v45; // [rsp+60h] [rbp-CB8h] BYREF
		  Il2CppExceptionWrapper *v46; // [rsp+80h] [rbp-C98h] BYREF
		  _BYTE v47[3200]; // [rsp+90h] [rbp-C88h] BYREF
		
		  v43 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3647, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3647, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v42, v41);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(
		      (ILFixDynamicMethodWrapper_13 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)targetCamera,
		      useScreenSize,
		      0LL);
		  }
		  else
		  {
		    if ( !renderGraph )
		      sub_1800D8260(v10, v9);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v44,
		      renderGraph,
		      (String *)"UpdateShaderVariablesGlobal",
		      &v43,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
		    v45 = v44;
		    v44.m_RenderPass = 0LL;
		    v44.m_Resources = (HGRenderGraphResourceRegistry *)&v45;
		    try
		    {
		      v12 = v43;
		      if ( !v43 )
		        sub_1800D8250(0LL, v11);
		      v43[1].klass = *(Object__Class **)&this[1].fields._.m_basicTransformConstants._PrevViewProjMatrix.m01;
		      v13 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v14 = (((unsigned __int64)&v12[1] >> 12) & 0x1FFFFF) >> 6;
		        v15 = ((unsigned __int64)&v12[1] >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v14 + 36190]);
		        do
		        {
		          v12 = (Object *)(qword_18F0BCBA0[v14 + 36190] | (1LL << v15));
		          v16 = qword_18F0BCBA0[v14 + 36190];
		        }
		        while ( v16 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v14 + 36190], (signed __int64)v12, v16) );
		        v13 = dword_18F35FD08;
		      }
		      v17 = v43;
		      if ( !v43 )
		        sub_1800D8250(v12, qword_18F0BCBA0);
		      v43[1].monitor = (MonitorData *)targetCamera;
		      if ( v13 )
		      {
		        v18 = ((unsigned __int64)&v17[1].monitor >> 12) & 0x1FFFFF;
		        v19 = (unsigned __int64)v18 >> 6;
		        v20 = v18 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		        do
		          v21 = qword_18F0BCBA0[v19 + 36190];
		        while ( v21 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v21 | (1LL << v20), v21) );
		      }
		      v22 = v43;
		      if ( !v43 )
		        sub_1800D8250(0LL, qword_18F0BCBA0);
		      LOBYTE(v43[2].klass) = this->fields._._firstBackbufferPass_k__BackingField == 52;
		      if ( !v43 )
		        sub_1800D8250(v22, qword_18F0BCBA0);
		      BYTE1(v43[2].klass) = useScreenSize;
		      v23 = v43;
		      basicTransformConstants = HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(
		                                  (HGRenderPathBase *)this,
		                                  0LL);
		      sub_18033B330(v47, basicTransformConstants, 1312LL);
		      if ( !v23 )
		        sub_1800D8250(v26, v25);
		      sub_18033B330((char *)&v23[2].klass + 4, v47, 1312LL);
		      v27 = v43;
		      shaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
		                                (HGRenderPathBase *)this,
		                                0LL);
		      sub_18033B330(v47, shaderVariablesGlobal, 3200LL);
		      if ( !v27 )
		        sub_1800D8250(v30, v29);
		      sub_18033B330((char *)&v27[84].klass + 4, v47, 3200LL);
		      if ( !v43 )
		        sub_1800D8250(v32, v31);
		      *(TextureHandle *)((char *)v43 + 4612) = this->fields._._backBufferColor_k__BackingField;
		      v33 = v43;
		      uiShaderVariablesGlobal = HG::Rendering::Runtime::HGRenderPathBase::get_uiShaderVariablesGlobal(
		                                  (HGRenderPathBase *)this,
		                                  0LL);
		      ProjectionParams = uiShaderVariablesGlobal->_ProjectionParams;
		      ScreenParams = uiShaderVariablesGlobal->_ScreenParams;
		      ZBufferParams = uiShaderVariablesGlobal->_ZBufferParams;
		      if ( !v33 )
		        sub_1800D8250(v36, v35);
		      *(Vector4 *)((char *)v33 + 4548) = uiShaderVariablesGlobal->_Time;
		      *(Vector4 *)((char *)&v33[285] + 4) = ProjectionParams;
		      *(Vector4 *)((char *)&v33[286] + 4) = ScreenParams;
		      *(Vector4 *)((char *)&v33[287] + 4) = ZBufferParams;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v45, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v45,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGRenderPathScene->static_fields->s_overrideShaderVariablesGlobalFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGRenderPathScene::ShaderVariableOverrideData>);
		    }
		    catch ( Il2CppExceptionWrapper *v46 )
		    {
		      v44.m_RenderPass = (HGRenderGraphPass *)v46->ex;
		    }
		    sub_180268AE0(&v44);
		  }
		}
		
		private void UpdateShaderVariablesGlobalWaterInteraction(ref ShaderVariablesGlobal cb) {} // 0x0000000189C03D10-0x0000000189C03E80
		// Void UpdateShaderVariablesGlobalWaterInteraction(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::UpdateShaderVariablesGlobalWaterInteraction(
		        HGRenderPathScene *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  HGWaterManager *waterManager_k__BackingField; // rcx
		  float TerrainRippleOpacity; // xmm6_4
		  HGManagerContext *v9; // rax
		  HGManagerContext *v10; // rax
		  HGManagerContext *v11; // rax
		  float TerrainRippleNormalStrength; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v14; // [rsp+30h] [rbp-28h] BYREF
		  Vector2 CenterPosition; // [rsp+78h] [rbp+20h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3628, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		      if ( waterManager_k__BackingField )
		      {
		        TerrainRippleOpacity = HG::Rendering::Runtime::HGWaterManager::GetTerrainRippleOpacity(
		                                 waterManager_k__BackingField,
		                                 0LL);
		        v9 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		        if ( v9 )
		        {
		          waterManager_k__BackingField = v9->fields._waterManager_k__BackingField;
		          if ( waterManager_k__BackingField )
		          {
		            *(Vector2 *)&v14.x = HG::Rendering::Runtime::HGWaterManager::get_CenterPosition(
		                                   waterManager_k__BackingField,
		                                   0LL);
		            v10 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		            if ( v10 )
		            {
		              waterManager_k__BackingField = v10->fields._waterManager_k__BackingField;
		              if ( waterManager_k__BackingField )
		              {
		                CenterPosition = HG::Rendering::Runtime::HGWaterManager::get_CenterPosition(
		                                   waterManager_k__BackingField,
		                                   0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                *(__m128i *)&cb[1]._ProbeExposureScale = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                            &v14,
		                                                                                            32.0,
		                                                                                            TerrainRippleOpacity,
		                                                                                            v14.x,
		                                                                                            CenterPosition.y,
		                                                                                            0LL));
		                v11 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		                if ( v11 )
		                {
		                  waterManager_k__BackingField = v11->fields._waterManager_k__BackingField;
		                  if ( waterManager_k__BackingField )
		                  {
		                    TerrainRippleNormalStrength = HG::Rendering::Runtime::HGWaterManager::get_TerrainRippleNormalStrength(
		                                                    waterManager_k__BackingField,
		                                                    0LL);
		                    *(__m128i *)&cb[1]._ExposureWithMiscParams.z = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(&v14, 0.03125, TerrainRippleNormalStrength, 0.0, 0.0, 0LL));
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(waterManager_k__BackingField, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3628, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		}
		
		public void __iFixBaseProxy_OnPreRendering(ref HGRenderPathParams P0) {} // 0x0000000189C0292C-0x0000000189C02934
		// Void <>iFixBaseProxy_OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_OnPreRendering(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering((HGRenderPathBase *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_Dispose(HGRenderGraph P0) {} // 0x0000000189C0291C-0x0000000189C02924
		// Void <>iFixBaseProxy_Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_Dispose(
		        HGRenderPathScene *this,
		        HGRenderGraph *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathBase::Dispose((HGRenderPathBase *)this, P0, 0LL);
		}
		
		public bool __iFixBaseProxy_SkipRender(ref HGRenderPathParams P0) => default; // 0x0000000189C02934-0x0000000189C0293C
		// Boolean <>iFixBaseProxy_SkipRender(HGRenderPathBase+HGRenderPathParams ByRef)
		bool HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_SkipRender(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *P0,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::HGRenderPathBase::SkipRender((HGRenderPathBase *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_UpdateShaderVariablesGlobal(HGRenderPipeline P0, HGCamera P1, CommandBuffer P2, ref ShaderVariablesGlobal P3, ref ScriptableRenderContext P4) {} // 0x0000000189C0293C-0x0000000189C0294C
		// Void <>iFixBaseProxy_UpdateShaderVariablesGlobal(HGRenderPipeline, HGCamera, CommandBuffer, ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_UpdateShaderVariablesGlobal(
		        HGRenderPathScene *this,
		        HGRenderPipeline *P0,
		        HGCamera *P1,
		        CommandBuffer *P2,
		        ShaderVariablesGlobal *P3,
		        ScriptableRenderContext *P4,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobal(
		    (HGRenderPathBase *)this,
		    P0,
		    P1,
		    P2,
		    P3,
		    P4,
		    0LL);
		}
		
		public PassConstructorID __iFixBaseProxy_FindFirstBackbufferPass() => default; // 0x0000000189BF05A8-0x0000000189BF05B0
		// PassConstructorID <>iFixBaseProxy_FindFirstBackbufferPass()
		PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::__iFixBaseProxy_FindFirstBackbufferPass(
		        HGRenderPathUI *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::HGRenderPathBase::FindFirstBackbufferPass((HGRenderPathBase *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnPostRendering(ref HGRenderPathParams P0) {} // 0x0000000189C02924-0x0000000189C0292C
		// Void <>iFixBaseProxy_OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef)
		void HG::Rendering::Runtime::HGRenderPathScene::__iFixBaseProxy_OnPostRendering(
		        HGRenderPathScene *this,
		        HGRenderPathBase_HGRenderPathParams *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering((HGRenderPathBase *)this, P0, 0LL);
		}
		
	}
}
