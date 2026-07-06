using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class TAAUPassConstructor : IPassConstructor
	{
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x000025D0 File Offset: 0x000007D0
		private float historyWeight
		{
			get
			{
				// // Single GetLength()
				// float UnityEngine::Splines::NativeSpline::GetLength(NativeSpline *this, MethodInfo *method)
				// {
				//   return this.m_Length;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_baseline(Single)
				// void UnityEngine::TextCore::FaceInfo::set_baseline(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_Baseline = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001147 RID: 4423 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x000025D0 File Offset: 0x000007D0
		private float historyWeightInMotion
		{
			get
			{
				// // Single get_Width()
				// float HG::Rendering::HgMath::CellGrid2D<System::Object>::get_Width(
				//         CellGrid2D_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Width_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Width(Single)
				// void HG::Rendering::HgMath::CellGrid2D<System::Object>::set_Width(
				//         CellGrid2D_1_System_Object_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields._Width_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x000025D0 File Offset: 0x000007D0
		private float forceClampHistoryWeight
		{
			get
			{
				// // Single get_minRegionArea()
				// float UnityEngine::AI::NavMeshSurface::get_minRegionArea(NavMeshSurface *this, MethodInfo *method)
				// {
				//   return this.fields.m_MinRegionArea;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void SetEmptyElement(Single)
				// void MagicaCloth::FixedChunkNativeArray<float>::SetEmptyElement(
				//         FixedChunkNativeArray_1_System_Single_ *this,
				//         float empty,
				//         MethodInfo *method)
				// {
				//   this.fields.emptyElement = empty;
				// }
				// 
			}
		}

		// (get) Token: 0x0600114B RID: 4427 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x000025D0 File Offset: 0x000007D0
		private float forceClampHistoryWeightInMotion
		{
			get
			{
				// // Single get_currentTime()
				// float Slate::Cutscene::get_currentTime(Cutscene *this, MethodInfo *method)
				// {
				//   return this.fields._currentTime;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_tabWidth(Single)
				// void UnityEngine::TextCore::FaceInfo::set_tabWidth(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_TabWidth = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x000025D0 File Offset: 0x000007D0
		private float sharpenStrength
		{
			get
			{
				// // Single get_Width()
				// float HG::Rendering::HgMath::CellGrid3D<System::Object>::get_Width(
				//         CellGrid3D_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Width_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Width(Single)
				// void HG::Rendering::HgMath::CellGrid3D<System::Object>::set_Width(
				//         CellGrid3D_1_System_Object_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields._Width_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x000025D0 File Offset: 0x000007D0
		private float firstFrame
		{
			get
			{
				// // Single get_Height()
				// float HG::Rendering::HgMath::CellGrid3D<System::Object>::get_Height(
				//         CellGrid3D_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Height_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Height(Single)
				// void HG::Rendering::HgMath::CellGrid3D<System::Object>::set_Height(
				//         CellGrid3D_1_System_Object_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields._Height_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x000025D0 File Offset: 0x000007D0
		private float occlusionDepthDiff
		{
			get
			{
				// // Single get_defaultValue()
				// float UnityEngine::UIElements::TypedUxmlAttributeDescription<float>::get_defaultValue(
				//         TypedUxmlAttributeDescription_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_defaultValue(Single)
				// void UnityEngine::UIElements::TypedUxmlAttributeDescription<float>::set_defaultValue(
				//         TypedUxmlAttributeDescription_1_System_Single_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields._defaultValue_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001153 RID: 4435 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x000025D0 File Offset: 0x000007D0
		private float minMVConsideredDynamic
		{
			get
			{
				// // Single get_Pressure()
				// float PaintIn3D::P3dHitBetween::get_Pressure(P3dHitBetween *this, MethodInfo *method)
				// {
				//   return this.fields.pressure;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Pressure(Single)
				// void PaintIn3D::P3dHitBetween::set_Pressure(P3dHitBetween *this, float value, MethodInfo *method)
				// {
				//   this.fields.pressure = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001155 RID: 4437 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x000025D0 File Offset: 0x000007D0
		private float maxMVConsideredDynamic
		{
			get
			{
				// // Single Slate.ISubClipContainable.get_subClipOffset()
				// float Slate::ActionClips::PlayAudio::Slate_ISubClipContainable_get_subClipOffset(PlayAudio_1 *this, MethodInfo *method)
				// {
				//   return this.fields.clipOffset;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void Slate.ISubClipContainable.set_subClipOffset(Single)
				// void Slate::ActionClips::PlayAudio::Slate_ISubClipContainable_set_subClipOffset(
				//         PlayAudio_1 *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.clipOffset = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x000025D0 File Offset: 0x000007D0
		private float characterMotionSensitivity
		{
			get
			{
				// // Single get_voxelSize()
				// float UnityEngine::AI::NavMeshSurface::get_voxelSize(NavMeshSurface *this, MethodInfo *method)
				// {
				//   return this.fields.m_VoxelSize;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_voxelSize(Single)
				// void UnityEngine::AI::NavMeshSurface::set_voxelSize(NavMeshSurface *this, float value, MethodInfo *method)
				// {
				//   this.fields.m_VoxelSize = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001159 RID: 4441 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x000025D0 File Offset: 0x000007D0
		public float fastConvergeState
		{
			get
			{
				// // Single get_MainClipMixWeight()
				// float UnityEngine::Timeline::AnimationPlayableAsset::get_MainClipMixWeight(
				//         AnimationPlayableAsset *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_MainClipMixWeight;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_strikethroughThickness(Single)
				// void UnityEngine::TextCore::FaceInfo::set_strikethroughThickness(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_StrikethroughThickness = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600115B RID: 4443 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x000025D0 File Offset: 0x000007D0
		private float minMVConsideredDynamicChar
		{
			get
			{
				// // Single get_Opacity()
				// float PaintIn3D::P3dPaintFill::get_Opacity(P3dPaintFill *this, MethodInfo *method)
				// {
				//   return this.fields.opacity;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_startLifetime(Single)
				// void UnityEngine::ParticleSystem::Particle::set_startLifetime(
				//         ParticleSystem_Particle *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.m_Lifetime = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x000025D0 File Offset: 0x000007D0
		private float maxMVConsideredDynamicChar
		{
			get
			{
				// // Single get_Minimum()
				// float PaintIn3D::P3dPaintFill::get_Minimum(P3dPaintFill *this, MethodInfo *method)
				// {
				//   return this.fields.minimum;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Minimum(Single)
				// void PaintIn3D::P3dPaintFill::set_Minimum(P3dPaintFill *this, float value, MethodInfo *method)
				// {
				//   this.fields.minimum = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600115F RID: 4447 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x000025D0 File Offset: 0x000007D0
		private float fastConvergeHistoryWeight
		{
			get
			{
				// // Single get_verticalScrollbarSpacing()
				// float UnityEngine::UI::ScrollRect::get_verticalScrollbarSpacing(ScrollRect *this, MethodInfo *method)
				// {
				//   return this.fields.m_VerticalScrollbarSpacing;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_remainingLifetime(Single)
				// void UnityEngine::ParticleSystem::Particle::set_remainingLifetime(
				//         ParticleSystem_Particle *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   *(float *)&this.m_ParentRandomSeed = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001161 RID: 4449 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x000025D0 File Offset: 0x000007D0
		private float responsiveAAHistoryWeight
		{
			get
			{
				// // Single get_PeekAmount()
				// float SRDebugger::UI::MobileMenuController::get_PeekAmount(MobileMenuController *this, MethodInfo *method)
				// {
				//   return this.fields._peekAmount;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_strikethroughOffset(Single)
				// void UnityEngine::TextCore::FaceInfo::set_strikethroughOffset(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_StrikethroughOffset = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001163 RID: 4451 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x000025D0 File Offset: 0x000007D0
		private float inputSampleLumaWeight
		{
			get
			{
				// // Single get_Opacity()
				// float PaintIn3D::P3dPaintSphere::get_Opacity(P3dPaintSphere *this, MethodInfo *method)
				// {
				//   return this.fields.opacity;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Opacity(Single)
				// void PaintIn3D::P3dPaintSphere::set_Opacity(P3dPaintSphere *this, float value, MethodInfo *method)
				// {
				//   this.fields.opacity = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001165 RID: 4453 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x000025D0 File Offset: 0x000007D0
		private float taauScaleFactor
		{
			get
			{
				// // Single get_defaultValue()
				// float HG::Rendering::Runtime::SettingParameter<float>::get_defaultValue(
				//         SettingParameter_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_taauScaleFactor(Single)
				// void HG::Rendering::Runtime::TAAUPassConstructor::set_taauScaleFactor(
				//         TAAUPassConstructor *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2813, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2813, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, value, 0LL);
				//   }
				//   else
				//   {
				//     this.fields.m_constants.taauParameters0.x = value;
				//     this.fields.m_constants.taauParameters8.x = value;
				//     this.fields.m_constants.taauParameters0.y = 1.0 / value;
				//     this.fields.m_constants.taauParameters8.z = 1.0 / value;
				//     this.fields.m_constants.taauParameters8.y = value;
				//     this.fields.m_constants.taauParameters8.w = 1.0 / value;
				//   }
				// }
				// 
			}
		}

		// (get) Token: 0x06001167 RID: 4455 RVA: 0x000025F0 File Offset: 0x000007F0
		private float invScaleFactor
		{
			get
			{
				// // Single get_hintWeight()
				// float UnityEngine::Animations::Rigging::TwoBoneIKConstraintData::get_hintWeight(
				//         TwoBoneIKConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_HintWeight;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06001168 RID: 4456 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x000025D0 File Offset: 0x000007D0
		private float enableResponsiveTransparency
		{
			get
			{
				// // Single get_Angle()
				// float PaintIn3D::P3dPaintSphere::get_Angle(P3dPaintSphere *this, MethodInfo *method)
				// {
				//   return this.fields.angle;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Angle(Single)
				// void PaintIn3D::P3dPaintSphere::set_Angle(P3dPaintSphere *this, float value, MethodInfo *method)
				// {
				//   this.fields.angle = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x000025D0 File Offset: 0x000007D0
		private Vector4 LRSize
		{
			get
			{
				// // Vector4 get_LRSize()
				// Vector4 *HG::Rendering::Runtime::TAAUPassConstructor::get_LRSize(
				//         Vector4 *__return_ptr retstr,
				//         TAAUPassConstructor *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_constants.taauParameters6;
				//   return result;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_LRSize(Vector4)
				// void HG::Rendering::Runtime::TAAUPassConstructor::set_LRSize(
				//         TAAUPassConstructor *this,
				//         Vector4 *value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_constants.taauParameters6 = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600116C RID: 4460 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x000025D0 File Offset: 0x000007D0
		private Vector4 HRSize
		{
			get
			{
				// // Vector4 get_HRSize()
				// Vector4 *HG::Rendering::Runtime::TAAUPassConstructor::get_HRSize(
				//         Vector4 *__return_ptr retstr,
				//         TAAUPassConstructor *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_constants.taauParameters7;
				//   return result;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_HRSize(Vector4)
				// void HG::Rendering::Runtime::TAAUPassConstructor::set_HRSize(
				//         TAAUPassConstructor *this,
				//         Vector4 *value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_constants.taauParameters7 = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600116E RID: 4462 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x000025D0 File Offset: 0x000007D0
		private bool prevTAAUState
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_isRunning()
				// bool UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_isRunning(
				//         ValueAnimation_1_StyleValues_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isRunning_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_isRunning(Boolean)
				// void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_isRunning(
				//         ValueAnimation_1_StyleValues_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._isRunning_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001170 RID: 4464 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x000025D0 File Offset: 0x000007D0
		private float gaussianKernelStdDev
		{
			get
			{
				// // Single omZbIWJIrldcSvYlXrKUFlzMuTURA()
				// float iLhuYWDbmVJbwzFrmgpHjHIbandoA<System::Object>::omZbIWJIrldcSvYlXrKUFlzMuTURA(
				//         iLhuYWDbmVJbwzFrmgpHjHIbandoA_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NfxnViHTtvNRHOZQvFrczEXLFcPT;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_gaussianKernelStdDev(Single)
				// void HG::Rendering::Runtime::TAAUPassConstructor::set_gaussianKernelStdDev(
				//         TAAUPassConstructor *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D9195C7 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
				//     byte_18D9195C7 = 1;
				//   }
				//   this.fields.m_gaussianKernelStdDev = value;
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
				//   HG::Rendering::Runtime::TAAUPassConstructor::ComputeGaussianKernel(value, &this.fields.m_gaussianKernel, 0LL);
				// }
				// 
			}
		}

		internal TAAUPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // TAAUPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::TAAUPassConstructor::TAAUPassConstructor(
			//         TAAUPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   __int64 v15; // r8
			//   __int64 v16; // r9
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   Single__Array *m_gaussianKernel; // rcx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   __int64 v28; // r10
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGRenderPathBase_HGRenderPathResources *v34; // rdx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   __int64 v38; // r10
			//   TAAUPassConstructor_RTNames__Array *v39; // r10
			//   HGRenderPathBase_HGRenderPathResources *v40; // rdx
			//   PassConstructorID__Enum__Array *v41; // r8
			//   HGCamera *v42; // r9
			//   __int64 v43; // rdx
			//   float m_gaussianKernelStdDev; // xmm6_4
			//   float v45; // xmm2_4
			//   float v46; // xmm3_4
			//   float v47; // xmm1_4
			//   float v48; // xmm2_4
			//   float v49; // xmm3_4
			//   float v50; // xmm1_4
			//   Vector4 v51; // xmm1
			//   Vector4 v52; // xmm0
			//   Vector4 v53; // xmm1
			//   Vector4 v54; // xmm0
			//   Vector4 v55; // xmm1
			//   Vector4 v56; // xmm0
			//   Vector4 v57; // xmm1
			//   Vector4 v58; // xmm0
			//   Vector4 v59; // xmm1
			//   Vector4 v60; // xmm0
			//   _BYTE v61[24]; // [rsp+20h] [rbp-E0h] BYREF
			//   Vector4 si128; // [rsp+40h] [rbp-C0h]
			//   __m128i v63; // [rsp+50h] [rbp-B0h]
			//   __m128i v64; // [rsp+60h] [rbp-A0h]
			//   __m128i v65; // [rsp+70h] [rbp-90h]
			//   __m128i v66; // [rsp+80h] [rbp-80h]
			//   __m128i v67; // [rsp+90h] [rbp-70h]
			//   Vector4 v68; // [rsp+A0h] [rbp-60h]
			//   Vector4 v69; // [rsp+B0h] [rbp-50h]
			//   __m128i v70; // [rsp+C0h] [rbp-40h]
			//   Vector4 v71; // [rsp+D0h] [rbp-30h]
			//   Vector4 v72; // [rsp+E0h] [rbp-20h]
			//   Vector4 v73; // [rsp+F0h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDAC2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Material);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::RTNames);
			//     sub_18003C530(&TypeInfo::System::Single);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//     sub_18003C530(&off_18C8FCD28);
			//     sub_18003C530(&off_18C8FCD38);
			//     sub_18003C530(&off_18C8FCD48);
			//     sub_18003C530(&off_18C8FCD58);
			//     sub_18003C530(&off_18C8FCCF0);
			//     sub_18003C530(&off_18C8FCD08);
			//     byte_18D8EDAC2 = 1;
			//   }
			//   this.fields.m_gaussianKernel = (Single__Array *)il2cpp_array_new_specific_0(
			//                                                      TypeInfo::System::Single,
			//                                                      9LL,
			//                                                      resources,
			//                                                      method);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v7, v8, v9, *(MethodInfo **)v61, *(MethodInfo **)&v61[8]);
			//   this.fields.m_gaussianKernelStdDev = 1.0;
			//   this.fields.m_taauPassMaterials = (Material__Array *)il2cpp_array_new_specific_0(
			//                                                           TypeInfo::UnityEngine::Material,
			//                                                           4LL,
			//                                                           v10,
			//                                                           v11);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_taauPassMaterials,
			//     v12,
			//     v13,
			//     v14,
			//     *(MethodInfo **)v61,
			//     *(MethodInfo **)&v61[8]);
			//   il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor::RTNames, 2LL, v15, v16);
			//   *(_QWORD *)v61 = "DilatedDepth0";
			//   *(_OWORD *)&v61[8] = 0LL;
			//   ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *))sub_1800054D0)(
			//     (HGRenderPathScene *)v61,
			//     v17,
			//     v18,
			//     v19);
			//   *(_QWORD *)&v61[8] = "DilatedMV0";
			//   ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *, MethodInfo *))sub_1800054D0)(
			//     (HGRenderPathScene *)&v61[8],
			//     v20,
			//     v21,
			//     (HGCamera *)"DilatedMV0",
			//     *(MethodInfo **)v61);
			//   *(_QWORD *)&v61[16] = "TAAUResult0";
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&v61[16],
			//     v22,
			//     v23,
			//     (HGCamera *)"TAAUResult0",
			//     *(MethodInfo **)v61,
			//     *(MethodInfo **)&v61[8]);
			//   if ( !v28 )
			//     goto LABEL_19;
			//   if ( !*(_DWORD *)(v28 + 24) )
			//     goto LABEL_20;
			//   *(_OWORD *)(v28 + 32) = *(_OWORD *)v61;
			//   *(_QWORD *)(v28 + 48) = *(_QWORD *)&v61[16];
			//   sub_1800054D0((HGRenderPathScene *)(v28 + 32), v24, v26, v27, *(MethodInfo **)v61, *(MethodInfo **)&v61[8]);
			//   *(_QWORD *)v61 = "DilatedDepth1";
			//   *(_OWORD *)&v61[8] = 0LL;
			//   ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *))sub_1800054D0)(
			//     (HGRenderPathScene *)v61,
			//     v29,
			//     v30,
			//     v31);
			//   *(_QWORD *)&v61[8] = "DilatedMV1";
			//   ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *, MethodInfo *))sub_1800054D0)(
			//     (HGRenderPathScene *)&v61[8],
			//     v32,
			//     v33,
			//     (HGCamera *)"DilatedMV1",
			//     *(MethodInfo **)v61);
			//   *(_QWORD *)&v61[16] = "TAAUResult1";
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&v61[16],
			//     v34,
			//     v35,
			//     (HGCamera *)"TAAUResult1",
			//     *(MethodInfo **)v61,
			//     *(MethodInfo **)&v61[8]);
			//   if ( *(_DWORD *)(v38 + 24) <= 1u )
			// LABEL_20:
			//     sub_180070270(m_gaussianKernel, v24);
			//   *(_OWORD *)(v38 + 56) = *(_OWORD *)v61;
			//   *(_QWORD *)(v38 + 72) = *(_QWORD *)&v61[16];
			//   sub_1800054D0((HGRenderPathScene *)(v38 + 56), v24, v36, v37, *(MethodInfo **)v61, *(MethodInfo **)&v61[8]);
			//   this.fields.m_rtNames = v39;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_rtNames,
			//     v40,
			//     v41,
			//     v42,
			//     *(MethodInfo **)v61,
			//     *(MethodInfo **)&v61[8]);
			//   HG::Rendering::Runtime::TAAUPassConstructor::InitializeMaterials(
			//     this,
			//     materialCollector,
			//     resources.defaultResources,
			//     0LL);
			//   m_gaussianKernelStdDev = this.fields.m_gaussianKernelStdDev;
			//   if ( !TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor, v43);
			//   HG::Rendering::Runtime::TAAUPassConstructor::ComputeGaussianKernel(
			//     m_gaussianKernelStdDev,
			//     &this.fields.m_gaussianKernel,
			//     0LL);
			//   m_gaussianKernel = this.fields.m_gaussianKernel;
			//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
			//   v64 = _mm_load_si128((const __m128i *)&xmmword_18A357AF0);
			//   v63 = _mm_load_si128((const __m128i *)&xmmword_18A357AE0);
			//   v66 = _mm_load_si128((const __m128i *)&xmmword_18A357AC0);
			//   v65 = _mm_load_si128((const __m128i *)&xmmword_18A357AD0);
			//   v70 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//   v67 = _mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//   v68 = (Vector4)v67;
			//   v69 = (Vector4)v67;
			//   if ( !m_gaussianKernel )
			// LABEL_19:
			//     sub_180B536AC(m_gaussianKernel, v24);
			//   if ( !m_gaussianKernel.max_length.size )
			//     goto LABEL_20;
			//   v45 = m_gaussianKernel.vector[0];
			//   if ( m_gaussianKernel.max_length.size <= 1u )
			//     goto LABEL_20;
			//   v46 = m_gaussianKernel.vector[1];
			//   if ( m_gaussianKernel.max_length.size <= 2u )
			//     goto LABEL_20;
			//   v47 = m_gaussianKernel.vector[2];
			//   if ( m_gaussianKernel.max_length.size <= 3u )
			//     goto LABEL_20;
			//   v71.w = m_gaussianKernel.vector[3];
			//   *(_QWORD *)&v71.x = __PAIR64__(LODWORD(v46), LODWORD(v45));
			//   v71.z = v47;
			//   if ( m_gaussianKernel.max_length.size <= 4u )
			//     goto LABEL_20;
			//   v48 = m_gaussianKernel.vector[4];
			//   if ( m_gaussianKernel.max_length.size <= 5u )
			//     goto LABEL_20;
			//   v49 = m_gaussianKernel.vector[5];
			//   if ( m_gaussianKernel.max_length.size <= 6u )
			//     goto LABEL_20;
			//   v50 = m_gaussianKernel.vector[6];
			//   if ( m_gaussianKernel.max_length.size <= 7u )
			//     goto LABEL_20;
			//   v72.w = m_gaussianKernel.vector[7];
			//   *(_QWORD *)&v72.x = __PAIR64__(LODWORD(v49), LODWORD(v48));
			//   v72.z = v50;
			//   if ( m_gaussianKernel.max_length.size <= 8u )
			//     goto LABEL_20;
			//   v73.x = m_gaussianKernel.vector[8];
			//   *(_QWORD *)&v73.y = 0LL;
			//   v73.w = 0.0;
			//   v51 = (Vector4)v63;
			//   this.fields.m_constants.taauParameters0 = si128;
			//   v52 = (Vector4)v64;
			//   this.fields.m_constants.taauParameters1 = v51;
			//   v53 = (Vector4)v65;
			//   this.fields.m_constants.taauParameters2 = v52;
			//   v54 = (Vector4)v66;
			//   this.fields.m_constants.taauParameters3 = v53;
			//   v55 = (Vector4)v67;
			//   this.fields.m_constants.taauParameters4 = v54;
			//   v56 = v68;
			//   this.fields.m_constants.taauParameters5 = v55;
			//   v57 = (Vector4)v70;
			//   this.fields.m_constants.taauParameters6 = v56;
			//   this.fields.m_constants.taauParameters7 = v69;
			//   v58 = v71;
			//   this.fields.m_constants.taauParameters8 = v57;
			//   v59 = v72;
			//   this.fields.m_constants.kernelWeights0 = v58;
			//   v60 = v73;
			//   this.fields.m_constants.kernelWeights1 = v59;
			//   this.fields.m_constants.kernelWeights2 = v60;
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         TAAUPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2814, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2814, 0LL);
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
			// void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         TAAUPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2815, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2815, 0LL);
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
			// void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         TAAUPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *renderGraph; // rdi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195C8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503520);
			//     byte_18D9195C8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2816, 0LL) )
			//   {
			//     renderGraph = input.renderGraph;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyDilatedSceneDepth, 0LL) )
			//     {
			//       if ( !renderGraph )
			//         goto LABEL_11;
			//       this.fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                    &v9,
			//                                                    renderGraph,
			//                                                    &this.fields.m_historyDilatedSceneDepth,
			//                                                    1,
			//                                                    (String *)"TAAUPass",
			//                                                    0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyDilatedSceneMV, 0LL) )
			//       return;
			//     if ( renderGraph )
			//     {
			//       this.fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                 &v9,
			//                                                 renderGraph,
			//                                                 &this.fields.m_historyDilatedSceneMV,
			//                                                 1,
			//                                                 (String *)"TAAUPass",
			//                                                 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2816, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		internal void ConstructPass(ref TAAUPassConstructor.PassInput input, ref TAAUPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(TAAUPassConstructor+PassInput ByRef, TAAUPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::TAAUPassConstructor::ConstructPass(
			//         TAAUPassConstructor *this,
			//         TAAUPassConstructor_PassInput *input,
			//         TAAUPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   _BYTE v12[24]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195C9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9195C9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2817, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2817, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1028(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( input.enableTAAU )
			//     {
			//       HG::Rendering::Runtime::TAAUPassConstructor::PrepareParameters(this, input, renderGraph, 0LL);
			//       HG::Rendering::Runtime::TAAUPassConstructor::ConstructTAAUPasses(this, input, output, renderGraph, 0LL);
			//     }
			//     else
			//     {
			//       *output = (TAAUPassConstructor_PassOutput)input.sceneColor;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_historyDilatedSceneDepth = *(TextureHandle *)sub_182E7CCD0(v12);
			//       this.fields.m_historyDilatedSceneMV = *(TextureHandle *)sub_182E7CCD0(v12);
			//     }
			//     this.fields._prevTAAUState_k__BackingField = input.enableTAAU;
			//   }
			// }
			// 
		}

		private void InitializeMaterials(HGRenderPipelineMaterialCollector materialCollector, HGRenderPipelineRuntimeResources resource)
		{
			// // Void InitializeMaterials(HGRenderPipelineMaterialCollector, HGRenderPipelineRuntimeResources)
			// void HG::Rendering::Runtime::TAAUPassConstructor::InitializeMaterials(
			//         TAAUPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPipelineRuntimeResources *resource,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Material__Array *m_taauPassMaterials; // rax
			//   Object_1 *v10; // rbp
			//   Material__Array *v11; // rbp
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   Material *Material; // rax
			//   Material *v14; // r14
			//   Material__Array *v15; // rax
			//   Object_1 *v16; // rbp
			//   Material__Array *v17; // rbp
			//   HGRenderPipelineRuntimeResources_ShaderResources *v18; // rax
			//   Material *v19; // rax
			//   Material *v20; // r14
			//   Material__Array *v21; // rax
			//   Object_1 *v22; // rbp
			//   Material__Array *v23; // rbx
			//   HGRenderPipelineRuntimeResources_ShaderResources *v24; // rax
			//   Material *v25; // rax
			//   Material *v26; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDAC3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDAC3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2826, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2826, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)this,
			//         (Object *)materialCollector,
			//         (Object *)resource,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_35;
			//   }
			//   m_taauPassMaterials = this.fields.m_taauPassMaterials;
			//   if ( !m_taauPassMaterials )
			//     goto LABEL_35;
			//   if ( m_taauPassMaterials.max_length.size <= 1u )
			//     goto LABEL_36;
			//   v10 = (Object_1 *)m_taauPassMaterials.vector[1];
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//   if ( UnityEngine::Object::op_Equality(v10, 0LL, 0LL) )
			//   {
			//     v11 = this.fields.m_taauPassMaterials;
			//     if ( !resource )
			//       goto LABEL_35;
			//     shaders = resource.fields.shaders;
			//     if ( !shaders )
			//       goto LABEL_35;
			//     if ( !materialCollector )
			//       goto LABEL_35;
			//     Material = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                  materialCollector,
			//                  shaders.fields.taauMaskDilationPS,
			//                  0,
			//                  0LL);
			//     v14 = Material;
			//     if ( !v11 )
			//       goto LABEL_35;
			//     sub_180036D40(v11, Material);
			//     sub_18000FDA0(v11, 1LL, v14);
			//   }
			//   v15 = this.fields.m_taauPassMaterials;
			//   if ( !v15 )
			//     goto LABEL_35;
			//   if ( !v15.max_length.size )
			//     goto LABEL_36;
			//   v16 = (Object_1 *)v15.vector[0];
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//   if ( UnityEngine::Object::op_Equality(v16, 0LL, 0LL) )
			//   {
			//     v17 = this.fields.m_taauPassMaterials;
			//     if ( !resource )
			//       goto LABEL_35;
			//     v18 = resource.fields.shaders;
			//     if ( !v18 )
			//       goto LABEL_35;
			//     if ( !materialCollector )
			//       goto LABEL_35;
			//     v19 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//             materialCollector,
			//             v18.fields.taauDilationPS,
			//             0,
			//             0LL);
			//     v20 = v19;
			//     if ( !v17 )
			//       goto LABEL_35;
			//     sub_180036D40(v17, v19);
			//     sub_18000FDA0(v17, 0LL, v20);
			//   }
			//   v21 = this.fields.m_taauPassMaterials;
			//   if ( !v21 )
			//     goto LABEL_35;
			//   if ( v21.max_length.size <= 3u )
			// LABEL_36:
			//     sub_180070270(v8, v7);
			//   v22 = (Object_1 *)v21.vector[3];
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//   if ( UnityEngine::Object::op_Equality(v22, 0LL, 0LL) )
			//   {
			//     v23 = this.fields.m_taauPassMaterials;
			//     if ( resource )
			//     {
			//       v24 = resource.fields.shaders;
			//       if ( v24 )
			//       {
			//         if ( materialCollector )
			//         {
			//           v25 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                   materialCollector,
			//                   v24.fields.taauResolvePS,
			//                   0,
			//                   0LL);
			//           v26 = v25;
			//           if ( v23 )
			//           {
			//             sub_180036D40(v23, v25);
			//             sub_18000FDA0(v23, 3LL, v26);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_35:
			//     sub_180B536AC(v8, v7);
			//   }
			// }
			// 
		}

		private void PrepareParameters(ref TAAUPassConstructor.PassInput input, HGRenderGraph renderGraph)
		{
			// // Void PrepareParameters(TAAUPassConstructor+PassInput ByRef, HGRenderGraph)
			// void HG::Rendering::Runtime::TAAUPassConstructor::PrepareParameters(
			//         TAAUPassConstructor *this,
			//         TAAUPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   bool v7; // si
			//   void *static_fields; // rdx
			//   __int64 v9; // rcx
			//   float historyWeight; // xmm0_4
			//   float sharpenStrength4K; // xmm2_4
			//   HGRenderGraphContext *m_RenderGraphContext; // rax
			//   CommandBuffer *cmd; // rsi
			//   HGRenderGraphContext *v14; // r14
			//   CBHandle *v15; // rax
			//   __m128i v16; // xmm6
			//   Material__Array *m_taauPassMaterials; // rax
			//   Material *v18; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   CBHandle v20; // [rsp+30h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9195CA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9195CA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2819, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v7 = !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.historySceneColor, 0LL)
			//       || !this.fields._prevTAAUState_k__BackingField;
			//     if ( !input.quality )
			//     {
			//       if ( v7
			//         || (sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
			//             !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyDilatedSceneDepth, 0LL))
			//         || (sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
			//             !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyDilatedSceneMV, 0LL)) )
			//       {
			//         v7 = 1;
			//       }
			//     }
			//     HG::Rendering::Runtime::TAAUPassConstructor::set_taauScaleFactor(this, input.renderingScale, 0LL);
			//     if ( v7 )
			//       historyWeight = 0.0;
			//     else
			//       historyWeight = input.historyWeight;
			//     if ( this )
			//     {
			//       this.fields.m_constants.taauParameters0.z = historyWeight;
			//       this.fields.m_constants.taauParameters0.w = input.historyWeightInMotion;
			//       this.fields.m_constants.taauParameters4.x = input.fastConvergeHistoryWeight;
			//       this.fields.m_constants.taauParameters2.z = input.responsiveAAHistoryWeight;
			//       this.fields.m_constants.taauParameters3.y = input.minMVConsideredDynamic;
			//       this.fields.m_constants.taauParameters3.z = input.maxMVConsideredDynamic;
			//       this.fields.m_constants.taauParameters3.w = input.characterMotionSensitivity;
			//       this.fields.m_constants.taauParameters1.y = input.occlusionDepthDiff;
			//       this.fields.m_constants.taauParameters4.w = input.inputSampleLumaWeight;
			//       this.fields.m_constants.taauParameters2.w = (float)input.fastConvergeState;
			//       this.fields.m_constants.taauParameters5.x = input.enableResponsiveTransparency;
			//       this.fields.m_constants.taauParameters1.w = (float)v7;
			//       sharpenStrength4K = input.sharpenStrength4K;
			//       *(_QWORD *)&v20.bufferId = _mm_unpacklo_ps(
			//                                    (__m128)LODWORD(input.sharpenStrength1K),
			//                                    (__m128)LODWORD(input.sharpenStrength2K)).m128_u64[0];
			//       *(float *)&v20.size = sharpenStrength4K;
			//       this.fields.m_constants.taauParameters1.z = HG::Rendering::Runtime::TAAUPassConstructor::ComputeSharpenStrength(
			//                                                      this,
			//                                                      &input.screenSize,
			//                                                      (TAAUPassConstructor_SharpenStrengthParam *)&v20,
			//                                                      0LL);
			//       if ( renderGraph )
			//       {
			//         m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//         if ( m_RenderGraphContext )
			//         {
			//           cmd = m_RenderGraphContext.fields.cmd;
			//           *(float *)&v20.bufferId = (float)input.screenSize.m_X;
			//           *(float *)&v20.offset = (float)input.screenSize.m_Y;
			//           *(float *)&v20.size = 1.0 / (float)input.screenSize.m_X;
			//           *((float *)&v20.size + 1) = 1.0 / (float)input.screenSize.m_Y;
			//           this.fields.m_constants.taauParameters7 = *(Vector4 *)&v20.bufferId;
			//           *(float *)&v20.bufferId = (float)input.renderSize.m_X;
			//           *(float *)&v20.offset = (float)input.renderSize.m_Y;
			//           *(float *)&v20.size = 1.0 / *(float *)&v20.bufferId;
			//           *((float *)&v20.size + 1) = 1.0 / *(float *)&v20.offset;
			//           this.fields.m_constants.taauParameters6 = *(Vector4 *)&v20.bufferId;
			//           v14 = renderGraph.fields.m_RenderGraphContext;
			//           if ( v14 )
			//           {
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//             v15 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                     &v20,
			//                     &v14.fields.renderContext,
			//                     192,
			//                     0LL);
			//             v16 = *(__m128i *)&v15.bufferId;
			//             v20.ptr = v15.ptr;
			//             System::Buffer::MemoryCopy((Void *)&this.fields.m_constants, (Void *)v20.ptr, 192LL, 192LL, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( cmd )
			//             {
			//               UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//                 cmd,
			//                 _mm_cvtsi128_si32(v16),
			//                 *((_DWORD *)static_fields + 609),
			//                 _mm_cvtsi128_si32(_mm_srli_si128(v16, 4)),
			//                 192,
			//                 0LL);
			//               if ( input.quality != 1 )
			//                 return;
			//               m_taauPassMaterials = this.fields.m_taauPassMaterials;
			//               if ( m_taauPassMaterials )
			//               {
			//                 if ( m_taauPassMaterials.max_length.size <= 3u )
			//                   sub_180070270(v9, static_fields);
			//                 v18 = m_taauPassMaterials.vector[3];
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//                 static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//                 if ( v18 )
			//                 {
			//                   UnityEngine::Material::EnableKeyword(v18, *((String **)static_fields + 47), 0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_27:
			//     sub_180B536AC(v9, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2819, 0LL);
			//   if ( !Patch )
			//     goto LABEL_27;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1026(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
			// }
			// 
		}

		private void ConstructTAAUPasses(ref TAAUPassConstructor.PassInput input, ref TAAUPassConstructor.PassOutput output, HGRenderGraph renderGraph)
		{
			// // Void ConstructTAAUPasses(TAAUPassConstructor+PassInput ByRef, TAAUPassConstructor+PassOutput ByRef, HGRenderGraph)
			// void HG::Rendering::Runtime::TAAUPassConstructor::ConstructTAAUPasses(
			//         TAAUPassConstructor *this,
			//         TAAUPassConstructor_PassInput *input,
			//         TAAUPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2822, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2822, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1027(Patch, (Object *)this, input, output, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     if ( !input.quality )
			//     {
			//       HG::Rendering::Runtime::TAAUPassConstructor::ConstructDilationPass(this, input, renderGraph, 0LL);
			//       HG::Rendering::Runtime::TAAUPassConstructor::ConstructMaskDilationPass(this, input, renderGraph, 0LL);
			//     }
			//     HG::Rendering::Runtime::TAAUPassConstructor::ConstructResolvePass(this, input, output, renderGraph, 0LL);
			//   }
			// }
			// 
		}

		private void ConstructDilationPass(ref TAAUPassConstructor.PassInput input, HGRenderGraph renderGraph)
		{
			// // Void ConstructDilationPass(TAAUPassConstructor+PassInput ByRef, HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::TAAUPassConstructor::ConstructDilationPass(
			//         TAAUPassConstructor *this,
			//         TAAUPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int v10; // edi
			//   __int64 v11; // rdx
			//   TAAUPassConstructor_RTNames__Array *m_rtNames; // rcx
			//   unsigned __int64 v13; // r8
			//   signed __int64 v14; // rtt
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // r8
			//   __int64 v18; // r9
			//   __int64 v19; // rdx
			//   TAAUPassConstructor_RTNames__Array *v20; // rcx
			//   unsigned __int64 v21; // r8
			//   signed __int64 v22; // rtt
			//   Object *v23; // rdx
			//   Material__Array *m_taauPassMaterials; // rax
			//   Object__Class *v25; // rcx
			//   unsigned int v26; // edx
			//   unsigned __int64 v27; // r8
			//   char v28; // dl
			//   signed __int64 v29; // rtt
			//   __int64 v30; // rdx
			//   TAAUPassConstructor_RTNames__Array *v31; // rcx
			//   unsigned __int64 v32; // r8
			//   signed __int64 v33; // rtt
			//   Object *v34; // r15
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   TextureHandle v37; // xmm0
			//   __int64 v38; // rdx
			//   TAAUPassConstructor_RTNames__Array *v39; // rcx
			//   unsigned __int64 v40; // r8
			//   signed __int64 v41; // rtt
			//   Object *v42; // rbx
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   TextureHandle v45; // xmm0
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v61; // rdx
			//   __int64 v62; // rcx
			//   Object *v63; // [rsp+50h] [rbp-218h] BYREF
			//   __m128i si128; // [rsp+60h] [rbp-208h] BYREF
			//   TextureDesc v65; // [rsp+70h] [rbp-1F8h] BYREF
			//   HGRenderGraphBuilder v66; // [rsp+D0h] [rbp-198h] BYREF
			//   _QWORD v67[2]; // [rsp+F0h] [rbp-178h] BYREF
			//   TextureDesc v68; // [rsp+100h] [rbp-168h] BYREF
			//   HGRenderGraphBuilder v69; // [rsp+160h] [rbp-108h] BYREF
			//   TextureDesc v70; // [rsp+180h] [rbp-E8h] BYREF
			//   Il2CppExceptionWrapper *v71; // [rsp+1E0h] [rbp-88h] BYREF
			//   TextureDesc v72; // [rsp+1F0h] [rbp-78h] BYREF
			// 
			//   if ( !byte_18D9195CB )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D503520);
			//     sub_18003C530(&off_18D503550);
			//     byte_18D9195CB = 1;
			//   }
			//   v63 = 0LL;
			//   sub_1802F01E0(&v68, 0LL, 96LL);
			//   sub_1802F01E0(&v65, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2823, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2823, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v62, v61);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1026(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x4Eu,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v69,
			//       renderGraph,
			//       (String *)"TAAU Dilation Pass",
			//       &v63,
			//       v7,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
			//     v66 = v69;
			//     v67[0] = 0LL;
			//     v67[1] = &v66;
			//     try
			//     {
			//       v10 = input.renderPathFrameIndex % 2;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyDilatedSceneDepth, 0LL) )
			//       {
			//         sub_1802F01E0(&v70, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v70, input.renderSize, 0LL);
			//         v65 = v70;
			//         v65.colorFormat = 45;
			//         *(_WORD *)&v65.enableRandomWrite = 0;
			//         v65.autoGenerateMips = 0;
			//         m_rtNames = this.fields.m_rtNames;
			//         if ( !m_rtNames )
			//           sub_1802DC2C8(0LL, v11);
			//         v65.name = *(String **)sub_18037A2A0(m_rtNames, v10);
			//         if ( dword_18D8E43F8 )
			//         {
			//           v13 = (((unsigned __int64)&v65.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v13 + 36190]);
			//           do
			//             v14 = qword_18D6405E0[v13 + 36190];
			//           while ( v14 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v13 + 36190],
			//                            v14 | (1LL << (((unsigned __int64)&v65.name >> 12) & 0x3F)),
			//                            v14) );
			//         }
			//         v68 = v65;
			//         this.fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                      (TextureHandle *)&si128,
			//                                                      renderGraph,
			//                                                      &v68,
			//                                                      0LL);
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_historyDilatedSceneMV, 0LL) )
			//       {
			//         sub_1802F01E0(&v70, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v70, input.renderSize, 0LL);
			//         v65 = v70;
			//         v65.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                             renderGraph,
			//                             &input.sceneMV,
			//                             0LL).colorFormat;
			//         *(_WORD *)&v65.enableRandomWrite = 0;
			//         v65.autoGenerateMips = 0;
			//         v20 = this.fields.m_rtNames;
			//         if ( !v20 )
			//           sub_1802DC2C8(0LL, v19);
			//         v65.name = *(String **)(sub_18037A2A0(v20, v10) + 8);
			//         if ( dword_18D8E43F8 )
			//         {
			//           v21 = (((unsigned __int64)&v65.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v21 + 36190]);
			//           do
			//             v22 = qword_18D6405E0[v21 + 36190];
			//           while ( v22 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v21 + 36190],
			//                            v22 | (1LL << (((unsigned __int64)&v65.name >> 12) & 0x3F)),
			//                            v22) );
			//         }
			//         v68 = v65;
			//         this.fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                   (TextureHandle *)&si128,
			//                                                   renderGraph,
			//                                                   &v68,
			//                                                   0LL);
			//       }
			//       if ( !v63 )
			//         sub_1802DC2C8(v16, v15);
			//       v63[1] = (Object)input.sceneDepth;
			//       if ( !v63 )
			//         sub_1802DC2C8(v16, v15);
			//       v63[2] = (Object)input.sceneMV;
			//       if ( !v63 )
			//         sub_1802DC2C8(v16, v15);
			//       v63[5] = (Object)this.fields.m_historyDilatedSceneDepth;
			//       if ( !v63 )
			//         sub_1802DC2C8(v16, v15);
			//       v63[6] = (Object)this.fields.m_historyDilatedSceneMV;
			//       v23 = v63;
			//       m_taauPassMaterials = this.fields.m_taauPassMaterials;
			//       if ( !m_taauPassMaterials )
			//         sub_1802DC2C8(v16, v63);
			//       if ( !m_taauPassMaterials.max_length.size )
			//         sub_180070260(v16, v63, v17, v18);
			//       v25 = (Object__Class *)m_taauPassMaterials.vector[0];
			//       if ( !v63 )
			//         sub_1802DC2C8(v25, 0LL);
			//       v63[7].klass = v25;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v26 = ((unsigned __int64)&v23[7] >> 12) & 0x1FFFFF;
			//         v27 = (unsigned __int64)v26 >> 6;
			//         v28 = v26 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v27 + 36190]);
			//         do
			//           v29 = qword_18D6405E0[v27 + 36190];
			//         while ( v29 != _InterlockedCompareExchange64(&qword_18D6405E0[v27 + 36190], v29 | (1LL << v28), v29) );
			//       }
			//       sub_1802F01E0(&v70, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v70, input.renderSize, 0LL);
			//       v65 = v70;
			//       v65.colorFormat = 45;
			//       *(_WORD *)&v65.enableRandomWrite = 0;
			//       v65.autoGenerateMips = 0;
			//       v31 = this.fields.m_rtNames;
			//       if ( !v31 )
			//         sub_1802DC2C8(0LL, v30);
			//       v65.name = *(String **)sub_18037A2A0(v31, v10);
			//       if ( dword_18D8E43F8 )
			//       {
			//         v32 = (((unsigned __int64)&v65.name >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v32 + 36190]);
			//         do
			//           v33 = qword_18D6405E0[v32 + 36190];
			//         while ( v33 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v32 + 36190],
			//                          v33 | (1LL << (((unsigned __int64)&v65.name >> 12) & 0x3F)),
			//                          v33) );
			//       }
			//       v68 = v65;
			//       v34 = v63;
			//       v37 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                (TextureHandle *)&si128,
			//                renderGraph,
			//                &v68,
			//                0LL);
			//       if ( !v34 )
			//         sub_1802DC2C8(v36, v35);
			//       v34[3] = (Object)v37;
			//       sub_1802F01E0(&v72, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v72, input.renderSize, 0LL);
			//       v65 = v72;
			//       v65.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                           renderGraph,
			//                           &input.sceneMV,
			//                           0LL).colorFormat;
			//       *(_WORD *)&v65.enableRandomWrite = 0;
			//       v65.autoGenerateMips = 0;
			//       v39 = this.fields.m_rtNames;
			//       if ( !v39 )
			//         sub_1802DC2C8(0LL, v38);
			//       v65.name = *(String **)(sub_18037A2A0(v39, v10) + 8);
			//       if ( dword_18D8E43F8 )
			//       {
			//         v40 = (((unsigned __int64)&v65.name >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v40 + 36190]);
			//         do
			//           v41 = qword_18D6405E0[v40 + 36190];
			//         while ( v41 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v40 + 36190],
			//                          v41 | (1LL << (((unsigned __int64)&v65.name >> 12) & 0x3F)),
			//                          v41) );
			//       }
			//       v68 = v65;
			//       v42 = v63;
			//       v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                (TextureHandle *)&si128,
			//                renderGraph,
			//                &v68,
			//                0LL);
			//       if ( !v42 )
			//         sub_1802DC2C8(v44, v43);
			//       v42[4] = (Object)v45;
			//       if ( !v63 )
			//         sub_1802DC2C8(v44, v43);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         (TextureHandle *)&si128,
			//         &v66,
			//         (TextureHandle *)&v63[1],
			//         0LL);
			//       if ( !v63 )
			//         sub_1802DC2C8(v47, v46);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         (TextureHandle *)&si128,
			//         &v66,
			//         (TextureHandle *)&v63[2],
			//         0LL);
			//       if ( !v63 )
			//         sub_1802DC2C8(v49, v48);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//         (TextureHandle *)&si128,
			//         &v66,
			//         (TextureHandle *)&v63[5],
			//         0LL);
			//       if ( !v63 )
			//         sub_1802DC2C8(v51, v50);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
			//         (TextureHandle *)&si128,
			//         &v66,
			//         (TextureHandle *)&v63[6],
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v66, 0, 0LL);
			//       if ( !v63 )
			//         sub_1802DC2C8(v53, v52);
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v69,
			//         &v66,
			//         (TextureHandle *)&v63[3],
			//         0,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       if ( !v63 )
			//         sub_1802DC2C8(v55, v54);
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v69,
			//         &v66,
			//         (TextureHandle *)&v63[4],
			//         1,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       if ( HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::DepthRequiredIfMRT(&v66, 0LL) )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v69,
			//           &v66,
			//           &input.utilityDepth,
			//           DepthAccess__Enum_ReadWrite,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v66,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor.static_fields.s_dilationRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::DilationPassData>);
			//       if ( !v63 )
			//         sub_1802DC2C8(v57, v56);
			//       this.fields.m_historyDilatedSceneDepth = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                    (TextureHandle *)&v69,
			//                                                    renderGraph,
			//                                                    (TextureHandle *)&v63[3],
			//                                                    1,
			//                                                    (String *)"TAAUPass",
			//                                                    0LL);
			//       if ( !v63 )
			//         sub_1802DC2C8(v59, v58);
			//       this.fields.m_historyDilatedSceneMV = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                                                 (TextureHandle *)&v69,
			//                                                 renderGraph,
			//                                                 (TextureHandle *)&v63[4],
			//                                                 1,
			//                                                 (String *)"TAAUPass",
			//                                                 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v71 )
			//     {
			//       v67[0] = v71.ex;
			//     }
			//     sub_180222690(v67);
			//   }
			// }
			// 
		}

		private void ConstructMaskDilationPass(ref TAAUPassConstructor.PassInput input, HGRenderGraph renderGraph)
		{
			// // Void ConstructMaskDilationPass(TAAUPassConstructor+PassInput ByRef, HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::TAAUPassConstructor::ConstructMaskDilationPass(
			//         TAAUPassConstructor *this,
			//         TAAUPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rcx
			//   __int64 v11; // r8
			//   __int64 v12; // r9
			//   Object *v13; // rdx
			//   Material__Array *m_taauPassMaterials; // rax
			//   Object__Class *v15; // rcx
			//   unsigned int v16; // edx
			//   unsigned __int64 v17; // r8
			//   signed __int64 v18; // rtt
			//   int v19; // edi
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   int v22; // eax
			//   int32_t v23; // ebx
			//   Object *v24; // rbx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   TextureHandle v27; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   Object *v31; // [rsp+50h] [rbp-1A8h] BYREF
			//   _QWORD v32[3]; // [rsp+58h] [rbp-1A0h] BYREF
			//   __m128i si128; // [rsp+70h] [rbp-188h] BYREF
			//   HGRenderGraphBuilder v34; // [rsp+80h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v35; // [rsp+A0h] [rbp-158h] BYREF
			//   HGRenderGraphBuilder v36; // [rsp+A8h] [rbp-150h] BYREF
			//   __int128 v37; // [rsp+E0h] [rbp-118h]
			//   __int128 v38; // [rsp+F0h] [rbp-108h]
			//   TextureDesc v39; // [rsp+130h] [rbp-C8h] BYREF
			//   TextureDesc v40; // [rsp+190h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D9195CC )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//     sub_18003C530(&off_18D5033E8);
			//     byte_18D9195CC = 1;
			//   }
			//   v31 = 0LL;
			//   sub_1802F01E0(&v40, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2824, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2824, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v30, v29);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1026(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x4Fu,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v36,
			//       renderGraph,
			//       (String *)"TAAU Mask Dilation Pass",
			//       &v31,
			//       v7,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
			//     v34 = v36;
			//     v32[0] = 0LL;
			//     v32[1] = &v34;
			//     try
			//     {
			//       v13 = v31;
			//       m_taauPassMaterials = this.fields.m_taauPassMaterials;
			//       if ( !m_taauPassMaterials )
			//         sub_1802DC2C8(v10, v31);
			//       if ( m_taauPassMaterials.max_length.size <= 1u )
			//         sub_180070260(v10, v31, v11, v12);
			//       v15 = (Object__Class *)m_taauPassMaterials.vector[1];
			//       if ( !v31 )
			//         sub_1802DC2C8(v15, 0LL);
			//       v31[2].klass = v15;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v16 = ((unsigned __int64)&v13[2] >> 12) & 0x1FFFFF;
			//         v17 = (unsigned __int64)v16 >> 6;
			//         v13 = (Object *)(v16 & 0x3F);
			//         _m_prefetchw(&qword_18D6870D0[v17]);
			//         do
			//         {
			//           v15 = (Object__Class *)(qword_18D6870D0[v17] | (1LL << (char)v13));
			//           v18 = qword_18D6870D0[v17];
			//         }
			//         while ( v18 != _InterlockedCompareExchange64(&qword_18D6870D0[v17], (signed __int64)v15, v18) );
			//       }
			//       v19 = sub_1825C6750(v15, v13);
			//       v22 = sub_1825C6750(v21, v20);
			//       v23 = 4 * (v22 / 4 + (int)(float)((float)((float)(v22 % 4) * 0.25) + (float)((float)(v22 % 4) * 0.25)));
			//       sub_1802F01E0(&v39, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v39,
			//         4 * (v19 / 4 + (int)(float)((float)((float)(v19 % 4) * 0.25) + (float)((float)(v19 % 4) * 0.25))),
			//         v23,
			//         0LL);
			//       HIDWORD(v37) = v39.dimension;
			//       v38 = *(_OWORD *)&v39.enableRandomWrite;
			//       LODWORD(v37) = 5;
			//       LOWORD(v38) = 0;
			//       *(_QWORD *)((char *)&v37 + 4) = 0x100000001LL;
			//       *(_OWORD *)&v40.width = *(_OWORD *)&v39.width;
			//       *(_OWORD *)&v40.colorFormat = v37;
			//       *(_OWORD *)&v40.enableRandomWrite = v38;
			//       *(_OWORD *)&v40.bindTextureMS = *(_OWORD *)&v39.bindTextureMS;
			//       *(_OWORD *)&v40.fastMemoryDesc.inFastMemory = *(_OWORD *)&v39.fastMemoryDesc.inFastMemory;
			//       v40.clearColor = v39.clearColor;
			//       v24 = v31;
			//       v27 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                (TextureHandle *)&si128,
			//                renderGraph,
			//                &v40,
			//                0LL);
			//       if ( !v24 )
			//         sub_1802DC2C8(v26, v25);
			//       v24[1] = (Object)v27;
			//       if ( !v31 )
			//         sub_1802DC2C8(v26, v25);
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v36,
			//         &v34,
			//         (TextureHandle *)&v31[1],
			//         0,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v34, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v34,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor.static_fields.s_maskDilationRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::MaskDilationPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v35 )
			//     {
			//       v32[0] = v35.ex;
			//     }
			//     sub_180222690(v32);
			//   }
			// }
			// 
		}

		private void ConstructResolvePass(ref TAAUPassConstructor.PassInput input, ref TAAUPassConstructor.PassOutput output, HGRenderGraph renderGraph)
		{
			// // Void ConstructResolvePass(TAAUPassConstructor+PassInput ByRef, TAAUPassConstructor+PassOutput ByRef, HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::TAAUPassConstructor::ConstructResolvePass(
			//         TAAUPassConstructor *this,
			//         TAAUPassConstructor_PassInput *input,
			//         TAAUPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int v11; // edi
			//   int32_t colorFormat; // r12d
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   __int64 quality; // rcx
			//   __int64 v18; // rdx
			//   __int64 v19; // r8
			//   __int64 v20; // r9
			//   Object *v21; // rcx
			//   Material__Array *m_taauPassMaterials; // rax
			//   MonitorData *v23; // rdx
			//   unsigned __int64 v24; // r8
			//   signed __int64 v25; // rtt
			//   Object *v26; // r15
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   TextureHandle v29; // xmm0
			//   Object *v30; // r15
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   TextureHandle v33; // xmm0
			//   Object *v34; // r15
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   TextureHandle v37; // xmm0
			//   __int64 v38; // rdx
			//   TAAUPassConstructor_RTNames__Array *m_rtNames; // rcx
			//   unsigned __int64 v40; // r8
			//   signed __int64 v41; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   Object *v45; // [rsp+50h] [rbp-1D8h] BYREF
			//   __m128i si128; // [rsp+60h] [rbp-1C8h] BYREF
			//   TextureHandle v47; // [rsp+70h] [rbp-1B8h] BYREF
			//   _QWORD v48[2]; // [rsp+80h] [rbp-1A8h] BYREF
			//   HGRenderGraphBuilder v49; // [rsp+90h] [rbp-198h] BYREF
			//   TextureDesc v50; // [rsp+B0h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v51; // [rsp+110h] [rbp-118h] BYREF
			//   HGRenderGraphBuilder v52; // [rsp+118h] [rbp-110h] BYREF
			//   TextureDesc v53; // [rsp+140h] [rbp-E8h] BYREF
			//   TextureDesc v54; // [rsp+1A0h] [rbp-88h] BYREF
			// 
			//   if ( !byte_18D9195CD )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D5033F0);
			//     byte_18D9195CD = 1;
			//   }
			//   v45 = 0LL;
			//   sub_1802F01E0(&v54, 0LL, 96LL);
			//   sub_1802F01E0(&v50, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2825, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2825, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v44, v43);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1027(Patch, (Object *)this, input, output, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     v11 = input.renderPathFrameIndex % 2;
			//     if ( input.quality )
			//     {
			//       if ( !renderGraph )
			//         sub_180B536AC(v10, v9);
			//       colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                       renderGraph,
			//                       &input.sceneColor,
			//                       0LL).colorFormat;
			//     }
			//     else
			//     {
			//       colorFormat = 48;
			//     }
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x51u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v52,
			//       renderGraph,
			//       (String *)"TAAU Resolve Pass",
			//       &v45,
			//       v13,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>);
			//     v49 = v52;
			//     v48[0] = 0LL;
			//     v48[1] = &v49;
			//     try
			//     {
			//       quality = (unsigned int)input.quality;
			//       if ( !v45 )
			//         sub_1802DC2C8(quality, v16);
			//       LODWORD(v45[5].klass) = quality;
			//       if ( !v45 )
			//         sub_1802DC2C8(quality, v16);
			//       v45[4] = (Object)input.historySceneColor;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.historySceneColor, 0LL) )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//           (TextureHandle *)&si128,
			//           &v49,
			//           &input.historySceneColor,
			//           0LL);
			//       v21 = v45;
			//       m_taauPassMaterials = this.fields.m_taauPassMaterials;
			//       if ( !m_taauPassMaterials )
			//         sub_1802DC2C8(v45, v18);
			//       if ( m_taauPassMaterials.max_length.size <= 3u )
			//         sub_180070260(v45, v18, v19, v20);
			//       v23 = (MonitorData *)m_taauPassMaterials.vector[3];
			//       if ( !v45 )
			//         sub_1802DC2C8(0LL, v23);
			//       v45[5].monitor = v23;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v24 = (((unsigned __int64)&v21[5].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//         do
			//           v25 = qword_18D6405E0[v24 + 36190];
			//         while ( v25 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v24 + 36190],
			//                          v25 | (1LL << (((unsigned __int64)&v21[5].monitor >> 12) & 0x3F)),
			//                          v25) );
			//       }
			//       v26 = v45;
			//       v29 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&si128,
			//                &v49,
			//                &input.sceneColor,
			//                0LL);
			//       if ( !v26 )
			//         sub_1802DC2C8(v28, v27);
			//       v26[1] = (Object)v29;
			//       if ( input.quality == 1 )
			//       {
			//         v30 = v45;
			//         v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&si128,
			//                  &v49,
			//                  &input.sceneDepth,
			//                  0LL);
			//         if ( !v30 )
			//           sub_1802DC2C8(v32, v31);
			//         v30[2] = (Object)v33;
			//         v34 = v45;
			//         v37 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&si128,
			//                  &v49,
			//                  &input.sceneMV,
			//                  0LL);
			//         if ( !v34 )
			//           sub_1802DC2C8(v36, v35);
			//         v34[3] = (Object)v37;
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v49, 0, 0LL);
			//       sub_1802F01E0(&v53, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v53, input.screenSize, 0LL);
			//       v50 = v53;
			//       v50.colorFormat = colorFormat;
			//       *(_WORD *)&v50.enableRandomWrite = 0;
			//       v50.autoGenerateMips = 0;
			//       m_rtNames = this.fields.m_rtNames;
			//       if ( !m_rtNames )
			//         sub_1802DC2C8(0LL, v38);
			//       v50.name = *(String **)(sub_18037A2A0(m_rtNames, v11) + 16);
			//       if ( dword_18D8E43F8 )
			//       {
			//         v40 = (((unsigned __int64)&v50.name >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v40 + 36190]);
			//         do
			//           v41 = qword_18D6405E0[v40 + 36190];
			//         while ( v41 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v40 + 36190],
			//                          v41 | (1LL << (((unsigned __int64)&v50.name >> 12) & 0x3F)),
			//                          v41) );
			//       }
			//       v54 = v50;
			//       v47 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                (TextureHandle *)&si128,
			//                renderGraph,
			//                &v54,
			//                0LL);
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         (TextureHandle *)&v52,
			//         &v49,
			//         &v47,
			//         0,
			//         RenderBufferLoadAction__Enum_DontCare,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)&si128,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v49,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TAAUPassConstructor.static_fields.s_resolveRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TAAUPassConstructor::ResolvePassData>);
			//       output.currentSceneColor = v47;
			//     }
			//     catch ( Il2CppExceptionWrapper *v51 )
			//     {
			//       v48[0] = v51.ex;
			//     }
			//     sub_180222690(v48);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::TAAUPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         TAAUPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2827, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2827, 0LL);
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

		private float ComputeSharpenStrength(in Vector2Int screenSize, TAAUPassConstructor.SharpenStrengthParam param)
		{
			// // Single ComputeSharpenStrength(Vector2Int ByRef, TAAUPassConstructor+SharpenStrengthParam)
			// float HG::Rendering::Runtime::TAAUPassConstructor::ComputeSharpenStrength(
			//         TAAUPassConstructor *this,
			//         Vector2Int *screenSize,
			//         TAAUPassConstructor_SharpenStrengthParam *param,
			//         MethodInfo *method)
			// {
			//   Beyond::JobMathf *v7; // rcx
			//   float v8; // xmm1_4
			//   float sharpen2K; // xmm4_4
			//   float v10; // xmm0_4
			//   double v11; // xmm0_8
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float sharpen4K; // eax
			//   TAAUPassConstructor_SharpenStrengthParam v16; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2821, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2821, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     sharpen4K = param.sharpen4K;
			//     *(_QWORD *)&v16.sharpen1K = *(_QWORD *)&param.sharpen1K;
			//     v16.sharpen4K = sharpen4K;
			//     *(float *)&v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1025(Patch, (Object *)this, screenSize, &v16, 0LL);
			//   }
			//   else
			//   {
			//     v8 = 2560.0;
			//     if ( (float)screenSize.m_X < 2560.0 )
			//     {
			//       sharpen2K = param.sharpen2K;
			//       v10 = 1920.0;
			//     }
			//     else
			//     {
			//       sharpen2K = param.sharpen4K;
			//       v10 = 2560.0;
			//       v8 = 3840.0;
			//     }
			//     v11 = Beyond::JobMathf::ClampedLerp(
			//             v7,
			//             sharpen2K,
			//             fminf(1.0, fmaxf((float)screenSize.m_X - v10, 0.0) / (float)(v8 - v10)));
			//   }
			//   return *(float *)&v11;
			// }
			// 
			return 0f;
		}

		private static void ComputeGaussianKernel(float stdDev, ref float[] kernel)
		{
			// // Void ComputeGaussianKernel(Single, Single[] ByRef)
			// void HG::Rendering::Runtime::TAAUPassConstructor::ComputeGaussianKernel(
			//         float stdDev,
			//         Single__Array **kernel,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   Single__Array *v5; // rcx
			//   Single__Array *v6; // rdi
			//   float v7; // xmm6_4
			//   Single__Array *v8; // rdi
			//   Single__Array *v9; // rdi
			//   Single__Array *v10; // rdi
			//   Single__Array *v11; // rdi
			//   Single__Array *v12; // rdi
			//   Single__Array *v13; // rdi
			//   Single__Array *v14; // rdi
			//   Single__Array *v15; // rdi
			//   Single__Array *v16; // rax
			//   float v17; // xmm6_4
			//   float *v18; // rax
			//   float *v19; // rax
			//   float *v20; // rax
			//   float *v21; // rax
			//   float *v22; // rax
			//   float *v23; // rax
			//   float *v24; // rax
			//   float *v25; // rax
			//   float *v26; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2828, 0LL) )
			//   {
			//     v6 = *kernel;
			//     v7 = stdDev * stdDev;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( !v6.max_length.size )
			//       goto LABEL_34;
			//     v6.vector[0] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v8 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v8.max_length.size <= 1u )
			//       goto LABEL_34;
			//     v8.vector[1] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v9 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v9.max_length.size <= 2u )
			//       goto LABEL_34;
			//     v9.vector[2] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v10 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v10.max_length.size <= 3u )
			//       goto LABEL_34;
			//     v10.vector[3] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v11 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v11.max_length.size <= 4u )
			//       goto LABEL_34;
			//     v11.vector[4] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v12 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v12.max_length.size <= 5u )
			//       goto LABEL_34;
			//     v12.vector[5] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v13 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v13.max_length.size <= 6u )
			//       goto LABEL_34;
			//     v13.vector[6] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v14 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v14.max_length.size <= 7u )
			//       goto LABEL_34;
			//     v14.vector[7] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v15 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( v15.max_length.size <= 8u )
			//       goto LABEL_34;
			//     v15.vector[8] = sub_1802EA170() / (float)(v7 * 6.2831855);
			//     v16 = *kernel;
			//     if ( !*kernel )
			//       goto LABEL_33;
			//     if ( !v16.max_length.size || (v5 = *kernel, v16.max_length.size <= 8u) )
			// LABEL_34:
			//       sub_180070270(v5, v4);
			//     v17 = (float)((float)((float)((float)((float)((float)((float)((float)(v16.vector[0] + 0.0) + v16.vector[1])
			//                                                         + v16.vector[2])
			//                                                 + v16.vector[3])
			//                                         + v16.vector[4])
			//                                 + v16.vector[5])
			//                         + v16.vector[6])
			//                 + v16.vector[7])
			//         + v16.vector[8];
			//     if ( v16 )
			//     {
			//       v18 = (float *)sub_18003ECE0(v5, 0LL);
			//       *v18 = *v18 / v17;
			//       v5 = *kernel;
			//       if ( *kernel )
			//       {
			//         v19 = (float *)sub_18003ECE0(v5, 1LL);
			//         *v19 = *v19 / v17;
			//         v5 = *kernel;
			//         if ( *kernel )
			//         {
			//           v20 = (float *)sub_18003ECE0(v5, 2LL);
			//           *v20 = *v20 / v17;
			//           v5 = *kernel;
			//           if ( *kernel )
			//           {
			//             v21 = (float *)sub_18003ECE0(v5, 3LL);
			//             *v21 = *v21 / v17;
			//             v5 = *kernel;
			//             if ( *kernel )
			//             {
			//               v22 = (float *)sub_18003ECE0(v5, 4LL);
			//               *v22 = *v22 / v17;
			//               v5 = *kernel;
			//               if ( *kernel )
			//               {
			//                 v23 = (float *)sub_18003ECE0(v5, 5LL);
			//                 *v23 = *v23 / v17;
			//                 v5 = *kernel;
			//                 if ( *kernel )
			//                 {
			//                   v24 = (float *)sub_18003ECE0(v5, 6LL);
			//                   *v24 = *v24 / v17;
			//                   v5 = *kernel;
			//                   if ( *kernel )
			//                   {
			//                     v25 = (float *)sub_18003ECE0(v5, 7LL);
			//                     *v25 = *v25 / v17;
			//                     v5 = *kernel;
			//                     if ( *kernel )
			//                     {
			//                       v26 = (float *)sub_18003ECE0(v5, 8LL);
			//                       *v26 = *v26 / v17;
			//                       return;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_33:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2828, 0LL);
			//   if ( !Patch )
			//     goto LABEL_33;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1029(Patch, stdDev, kernel, 0LL);
			// }
			// 
		}

		private float[] m_gaussianKernel;

		private float m_gaussianKernelStdDev;

		private Material[] m_taauPassMaterials;

		private TAAUPassConstructor.TAAUConstants m_constants;

		private TextureHandle m_historyDilatedSceneDepth;

		private TextureHandle m_historyDilatedSceneMV;

		private TAAUPassConstructor.RTNames[] m_rtNames;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<TAAUPassConstructor.DilationPassData> s_dilationRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<TAAUPassConstructor.MaskDilationPassData> s_maskDilationRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<TAAUPassConstructor.ResolvePassData> s_resolveRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 168)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle utilityDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle historySceneColor;

			internal Vector2Int renderSize;

			internal Vector2Int screenSize;

			internal float renderingScale;

			internal float historyWeight;

			internal float historyWeightInMotion;

			internal float fastConvergeHistoryWeight;

			internal float responsiveAAHistoryWeight;

			internal float minMVConsideredDynamic;

			internal float maxMVConsideredDynamic;

			internal float characterMotionSensitivity;

			internal float occlusionDepthDiff;

			internal float inputSampleLumaWeight;

			internal float sharpenStrength1K;

			internal float sharpenStrength2K;

			internal float sharpenStrength4K;

			internal float enableResponsiveTransparency;

			internal TAAUQuality quality;

			internal int renderPathFrameIndex;

			internal bool enableTAAU;

			internal bool fastConvergeState;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle currentSceneColor;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 192)]
		private struct TAAUConstants
		{
			public Vector4 taauParameters0;

			public Vector4 taauParameters1;

			public Vector4 taauParameters2;

			public Vector4 taauParameters3;

			public Vector4 taauParameters4;

			public Vector4 taauParameters5;

			public Vector4 taauParameters6;

			public Vector4 taauParameters7;

			public Vector4 taauParameters8;

			public Vector4 kernelWeights0;

			public Vector4 kernelWeights1;

			public Vector4 kernelWeights2;
		}

		private class DilationPassData
		{
			public DilationPassData()
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

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle currDilatedSceneDepth;

			internal TextureHandle currDilatedSceneMV;

			internal TextureHandle historyDilatedSceneDepth;

			internal TextureHandle historyDilatedSceneMV;

			internal Material material;
		}

		private class MaskDilationPassData
		{
			public MaskDilationPassData()
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

			internal TextureHandle currDilatedMask;

			internal Material material;
		}

		private class ResolvePassData
		{
			public ResolvePassData()
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

			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle historySceneColor;

			internal TAAUQuality quality;

			internal Material material;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		private struct RTNames
		{
			internal string dilatedDepthRTName;

			internal string dilatedMVRTName;

			internal string taauResultRTName;
		}

		private enum TAAUPass
		{
			DilationDepthReprojection,
			MaskDilation,
			FlickerDetection,
			Resolve,
			Count
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		private struct SharpenStrengthParam
		{
			public float sharpen1K;

			public float sharpen2K;

			public float sharpen4K;
		}
	}
}
