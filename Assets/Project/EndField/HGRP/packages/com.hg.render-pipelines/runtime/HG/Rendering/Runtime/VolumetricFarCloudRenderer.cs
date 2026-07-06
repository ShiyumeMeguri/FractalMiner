using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class VolumetricFarCloudRenderer
	{
		public VolumetricFarCloudRenderer()
		{
			// // VolumetricFarCloudRenderer()
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::VolumetricFarCloudRenderer(
			//         VolumetricFarCloudRenderer *this,
			//         MethodInfo *method)
			// {
			//   int32_t v2; // r8d
			//   MethodInfo *v3; // r9
			//   Vector3 *Vector; // rax
			//   float z; // ecx
			//   Animator *v7; // rdx
			//   int32_t v8; // r8d
			//   MethodInfo *v9; // r9
			//   Vector3 *v10; // rax
			//   float v11; // ecx
			//   Animator *v12; // rdx
			//   int32_t v13; // r8d
			//   MethodInfo *v14; // r9
			//   Vector3 *v15; // rax
			//   float v16; // ecx
			//   __int64 v17; // r8
			//   __int64 v18; // r9
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   __int64 v22; // r8
			//   __int64 v23; // r9
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   __int64 v27; // r8
			//   __int64 v28; // r9
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   __int64 v32; // r8
			//   __int64 v33; // r9
			//   HGRenderPathBase_HGRenderPathResources *v34; // rdx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   HGCamera *v36; // r9
			//   Animator *v37; // rdx
			//   int32_t v38; // r8d
			//   MethodInfo *v39; // r9
			//   Vector3 *v40; // rax
			//   float v41; // ecx
			//   Animator *v42; // rdx
			//   int32_t v43; // r8d
			//   MethodInfo *v44; // r9
			//   Vector3 *v45; // rax
			//   float v46; // ecx
			//   Animator *v47; // rdx
			//   int32_t v48; // r8d
			//   MethodInfo *v49; // r9
			//   Vector3 *v50; // rax
			//   float v51; // ecx
			//   MethodInfo *v52; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v53; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D9197A3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT);
			//     byte_18D9197A3 = 1;
			//   }
			//   Vector = UnityEngine::Animator::GetVector((Vector3 *)&v52, (Animator *)method, v2, v3);
			//   z = Vector.z;
			//   *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x = *(_QWORD *)&Vector.x;
			//   this.fields.m_BakedFarCloudCenter.z = z;
			//   v10 = UnityEngine::Animator::GetVector((Vector3 *)&v52, v7, v8, v9);
			//   v11 = v10.z;
			//   *(_QWORD *)&this.fields.m_BakedFarCloudLastCenter.x = *(_QWORD *)&v10.x;
			//   this.fields.m_BakedFarCloudLastCenter.z = v11;
			//   v15 = UnityEngine::Animator::GetVector((Vector3 *)&v52, v12, v13, v14);
			//   v16 = v15.z;
			//   *(_QWORD *)&this.fields.m_BakedFarCloudLastLastCenter.x = *(_QWORD *)&v15.x;
			//   this.fields.m_BakedFarCloudLastLastCenter.z = v16;
			//   this.fields.m_FarCloudComposeColors = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_0(
			//                                                                           TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
			//                                                                           2LL,
			//                                                                           v17,
			//                                                                           v18);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_FarCloudComposeColors, v19, v20, v21, v52, v53);
			//   this.fields.m_FarCloudComposeDepths = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_0(
			//                                                                           TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
			//                                                                           2LL,
			//                                                                           v22,
			//                                                                           v23);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_FarCloudComposeDepths, v24, v25, v26, v52, v53);
			//   this.fields.m_FarCloudTAAColors = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_0(
			//                                                                       TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
			//                                                                       2LL,
			//                                                                       v27,
			//                                                                       v28);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_FarCloudTAAColors, v29, v30, v31, v52, v53);
			//   this.fields.m_FarCloudTAADepths = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_0(
			//                                                                       TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
			//                                                                       2LL,
			//                                                                       v32,
			//                                                                       v33);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_FarCloudTAADepths, v34, v35, v36, v52, v53);
			//   v40 = UnityEngine::Animator::GetVector((Vector3 *)&v52, v37, v38, v39);
			//   v41 = v40.z;
			//   *(_QWORD *)&this.fields.semicircularForward.x = *(_QWORD *)&v40.x;
			//   this.fields.semicircularForward.z = v41;
			//   v45 = UnityEngine::Animator::GetVector((Vector3 *)&v52, v42, v43, v44);
			//   v46 = v45.z;
			//   *(_QWORD *)&this.fields.semicircularRight.x = *(_QWORD *)&v45.x;
			//   this.fields.semicircularRight.z = v46;
			//   v50 = UnityEngine::Animator::GetVector((Vector3 *)&v52, v47, v48, v49);
			//   v51 = v50.z;
			//   *(_QWORD *)&this.fields.semicircularUp.x = *(_QWORD *)&v50.x;
			//   this.fields.semicircularUp.z = v51;
			//   this.fields.slicingCount.x = 1.0;
			//   this.fields.slicingCount.y = 1.0;
			// }
			// 
		}

		public void MarkUsed()
		{
			// // Void MarkUsed()
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::MarkUsed(VolumetricFarCloudRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4416, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4416, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.lastAccessFrame = UnityEngine::Time::get_frameCount(0LL);
			//   }
			// }
			// 
		}

		public bool CanBeReleased()
		{
			// // Boolean CanBeReleased()
			// bool HG::Rendering::Runtime::VolumetricFarCloudRenderer::CanBeReleased(
			//         VolumetricFarCloudRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4396, 0LL) )
			//     return UnityEngine::Time::get_frameCount(0LL) - this.fields.lastAccessFrame > 5;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4396, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void Initialize()
		{
		}

		public void Release()
		{
		}

		private void ReleaseFarCloudRTs(bool full)
		{
			// // Void ReleaseFarCloudRTs(Boolean)
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::ReleaseFarCloudRTs(
			//         VolumetricFarCloudRenderer *this,
			//         bool full,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   VolumetricPipelineRT__Array *m_FarCloudComposeDepths; // rcx
			//   int i; // esi
			//   VolumetricPipelineRT__Array *m_FarCloudComposeColors; // rbp
			//   VolumetricPipelineRT **v9; // rax
			//   VolumetricPipelineRT **v10; // rax
			//   VolumetricPipelineRT **v11; // rax
			//   VolumetricPipelineRT **v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91979E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D91979E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4398, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4398, 0LL);
			//     if ( !Patch )
			// LABEL_12:
			//       sub_180B536AC(m_FarCloudComposeDepths, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, full, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 2; ++i )
			//     {
			//       m_FarCloudComposeColors = this.fields.m_FarCloudComposeColors;
			//       if ( !m_FarCloudComposeColors )
			//         goto LABEL_12;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v9 = (VolumetricPipelineRT **)sub_180002B90(m_FarCloudComposeColors, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v9, full, 0LL);
			//       m_FarCloudComposeDepths = this.fields.m_FarCloudComposeDepths;
			//       if ( !m_FarCloudComposeDepths )
			//         goto LABEL_12;
			//       v10 = (VolumetricPipelineRT **)sub_180002B90(m_FarCloudComposeDepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v10, full, 0LL);
			//       m_FarCloudComposeDepths = this.fields.m_FarCloudTAAColors;
			//       if ( !m_FarCloudComposeDepths )
			//         goto LABEL_12;
			//       v11 = (VolumetricPipelineRT **)sub_180002B90(m_FarCloudComposeDepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v11, full, 0LL);
			//       m_FarCloudComposeDepths = this.fields.m_FarCloudTAADepths;
			//       if ( !m_FarCloudComposeDepths )
			//         goto LABEL_12;
			//       v12 = (VolumetricPipelineRT **)sub_180002B90(m_FarCloudComposeDepths, i);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v12, full, 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FarCloudPanoramicColorRT, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FarCloudPanoramicDepthRT, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FarCloudDrawColorRT, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FarCloudDrawDepthRT, full, 0LL);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this.fields.m_FarCloudEmptySkipRT, full, 0LL);
			//   }
			// }
			// 
		}

		public void PostRender()
		{
			// // Void PostRender()
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::PostRender(
			//         VolumetricFarCloudRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4441, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4441, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricFarCloudRenderer::ReleaseFarCloudRTs(this, 0, 0LL);
			//   }
			// }
			// 
		}

		public void UpdatePanoramicRT(HGCamera hgCamera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, HGVolumetricCloudSettingParameters volumetricParameters, bool force)
		{
			// // Void UpdatePanoramicRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, HGVolumetricCloudSettingParameters, Boolean)
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdatePanoramicRT(
			//         VolumetricFarCloudRenderer *this,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         Material *cloudMat,
			//         MaterialPropertyBlock *propertyBlock,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   Animator *v12; // rdx
			//   void *m_FarCloudPanoramicColorRT; // rcx
			//   Int32Enum__Enum v14; // edi
			//   Int32Enum__Enum v15; // ebx
			//   RenderTexture *RT; // rax
			//   RenderTexture *v17; // r15
			//   Texture *v18; // rdi
			//   Component *camera; // rbx
			//   int32_t v20; // r8d
			//   MethodInfo *v21; // r9
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   MethodInfo *v24; // r9
			//   float z; // ebx
			//   __int64 v26; // xmm6_8
			//   float v27; // eax
			//   Vector3 *v28; // rax
			//   __int64 v29; // xmm3_8
			//   double v30; // xmm0_8
			//   float v31; // xmm7_4
			//   Animator *v32; // rdx
			//   int32_t v33; // r8d
			//   MethodInfo *v34; // r9
			//   MethodInfo *v35; // r8
			//   Vector4 *v36; // rax
			//   int32_t v37; // r10d
			//   MaterialPropertyBlock *v38; // rcx
			//   Vector3 *Vector; // rax
			//   __int64 v40; // xmm1_8
			//   float v41; // eax
			//   Vector4 v42; // xmm0
			//   MethodInfo *v43; // rdx
			//   Vector2 v44; // rax
			//   MaterialPropertyBlock *m_propertyBlock; // rbx
			//   __m128 y_low; // xmm6
			//   bool v47; // cc
			//   VolumetricShaderIDs__StaticFields *static_fields; // rax
			//   int32_t FarCloudMarchRangeLocal; // edi
			//   Vector4 *v50; // rax
			//   MethodInfo *v51; // r8
			//   Vector4 *v52; // rax
			//   MaterialPropertyBlock *v53; // r10
			//   int32_t v54; // r11d
			//   MethodInfo *v55; // r8
			//   Vector4 *v56; // rax
			//   MaterialPropertyBlock *v57; // r10
			//   int32_t v58; // r11d
			//   int v59; // edi
			//   int v60; // ebx
			//   int v61; // eax
			//   float FloatImpl; // xmm0_4
			//   MaterialPropertyBlock *v63; // rbx
			//   float v64; // xmm6_4
			//   VolumetricShaderIDs__StaticFields *v65; // rcx
			//   int32_t FlowSpeedScale; // edi
			//   double v67; // xmm0_8
			//   float v68; // xmm7_4
			//   float v69; // xmm0_4
			//   MaterialPropertyBlock *v70; // rbx
			//   int32_t FlowTime; // edi
			//   float time; // xmm0_4
			//   int v73; // eax
			//   MethodInfo *v74; // r8
			//   Vector3 v75; // [rsp+58h] [rbp-49h] BYREF
			//   Vector3 m_BakedFarCloudCenter; // [rsp+68h] [rbp-39h] BYREF
			//   Vector3 depthRT; // [rsp+78h] [rbp-29h] BYREF
			//   Vector4 v78; // [rsp+88h] [rbp-19h] BYREF
			// 
			//   if ( !byte_18D91979F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&off_18D51FB90);
			//     sub_18003C530(&off_18D51FBA8);
			//     byte_18D91979F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4434, 0LL) )
			//   {
			//     if ( volumetricParameters )
			//     {
			//       v14 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//               (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.panoramicSizeX,
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       v15 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//               (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.panoramicSizeY,
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//         (String *)"m_FarCloudPanoramicColorRT",
			//         &this.fields.m_FarCloudPanoramicColorRT,
			//         v14,
			//         v15,
			//         RTLifeCycle__Enum_Persist,
			//         RenderTextureFormat__Enum_ARGBHalf,
			//         0,
			//         0LL);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//         (String *)"m_FarCloudPanoramicDepthRT",
			//         &this.fields.m_FarCloudPanoramicDepthRT,
			//         v14,
			//         v15,
			//         RTLifeCycle__Enum_Persist,
			//         RenderTextureFormat__Enum_RHalf,
			//         0,
			//         0LL);
			//       m_FarCloudPanoramicColorRT = this.fields.m_FarCloudPanoramicColorRT;
			//       if ( m_FarCloudPanoramicColorRT )
			//       {
			//         RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                (VolumetricPipelineRT *)m_FarCloudPanoramicColorRT,
			//                0LL);
			//         m_FarCloudPanoramicColorRT = this.fields.m_FarCloudPanoramicDepthRT;
			//         v17 = RT;
			//         if ( m_FarCloudPanoramicColorRT )
			//         {
			//           *(_QWORD *)&depthRT.x = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                     (VolumetricPipelineRT *)m_FarCloudPanoramicColorRT,
			//                                     0LL);
			//           v18 = *(Texture **)&depthRT.x;
			//           if ( hgCamera )
			//           {
			//             camera = (Component *)hgCamera.fields.camera;
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Implicit((Object_1 *)camera, 0LL) )
			//             {
			//               if ( !camera )
			//                 goto LABEL_36;
			//               transform = UnityEngine::Component::get_transform(camera, 0LL);
			//               if ( !transform )
			//                 goto LABEL_36;
			//               position = UnityEngine::Transform::get_position(&m_BakedFarCloudCenter, transform, 0LL);
			//             }
			//             else
			//             {
			//               position = UnityEngine::Animator::GetVector(&m_BakedFarCloudCenter, v12, v20, v21);
			//             }
			//             z = position.z;
			//             v26 = *(_QWORD *)&position.x;
			//             v27 = this.fields.m_BakedFarCloudCenter.z;
			//             *(_QWORD *)&m_BakedFarCloudCenter.x = *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x;
			//             m_BakedFarCloudCenter.z = v27;
			//             *(_QWORD *)&v75.x = v26;
			//             v75.z = z;
			//             v28 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v78, &v75, &m_BakedFarCloudCenter, v24);
			//             v29 = *(_QWORD *)&v28.x;
			//             *(float *)&v28 = v28.z;
			//             *(_QWORD *)&m_BakedFarCloudCenter.x = v29;
			//             LODWORD(m_BakedFarCloudCenter.z) = (_DWORD)v28;
			//             v30 = sub_18238EFA0(&m_BakedFarCloudCenter);
			//             v31 = *(float *)&v30;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//             m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//             if ( cloudMat )
			//             {
			//               if ( UnityEngine::Material::GetFloatImpl(cloudMat, *((_DWORD *)m_FarCloudPanoramicColorRT + 152), 0LL) < v31
			//                 || force )
			//               {
			//                 Vector = UnityEngine::Animator::GetVector((Vector3 *)&v78, v32, v33, v34);
			//                 *(_QWORD *)&m_BakedFarCloudCenter.x = *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x;
			//                 *(_QWORD *)&v75.x = *(_QWORD *)&Vector.x;
			//                 if ( (float)((float)((float)((float)(m_BakedFarCloudCenter.y - v75.y)
			//                                            * (float)(m_BakedFarCloudCenter.y - v75.y))
			//                                    + (float)((float)(m_BakedFarCloudCenter.x - v75.x)
			//                                            * (float)(m_BakedFarCloudCenter.x - v75.x)))
			//                            + (float)((float)(this.fields.m_BakedFarCloudCenter.z - Vector.z)
			//                                    * (float)(this.fields.m_BakedFarCloudCenter.z - Vector.z))) >= 9.9999994e-11 )
			//                 {
			//                   v40 = *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x;
			//                   v41 = this.fields.m_BakedFarCloudCenter.z;
			//                 }
			//                 else
			//                 {
			//                   v40 = v26;
			//                   v41 = z;
			//                 }
			//                 *(_QWORD *)&this.fields.m_BakedFarCloudLastCenter.x = v40;
			//                 this.fields.m_BakedFarCloudLastCenter.z = v41;
			//                 m_FarCloudPanoramicColorRT = this.fields.m_propertyBlock;
			//                 *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x = v26;
			//                 this.fields.m_BakedFarCloudCenter.z = z;
			//                 if ( m_FarCloudPanoramicColorRT )
			//                 {
			//                   UnityEngine::MaterialPropertyBlock::CopyFrom(
			//                     (MaterialPropertyBlock *)m_FarCloudPanoramicColorRT,
			//                     propertyBlock,
			//                     0LL);
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                   m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                   if ( propertyBlock )
			//                   {
			//                     v42 = *UnityEngine::MaterialPropertyBlock::GetVector(
			//                              &v78,
			//                              propertyBlock,
			//                              *((_DWORD *)m_FarCloudPanoramicColorRT + 42),
			//                              0LL);
			//                     v78 = v42;
			//                     v44 = UnityEngine::Vector4::op_Implicit(&v78, v43);
			//                     m_propertyBlock = this.fields.m_propertyBlock;
			//                     *(Vector2 *)&v75.x = v44;
			//                     y_low = (__m128)LODWORD(v44.y);
			//                     v47 = v44.y <= 0.0;
			//                     static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                     FarCloudMarchRangeLocal = static_fields._FarCloudMarchRangeLocal;
			//                     if ( v47 )
			//                       y_low = 0LL;
			//                     v42.x = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
			//                               propertyBlock,
			//                               static_fields._InvGlobalScale,
			//                               0LL)
			//                           * 10000.0;
			//                     v50 = (Vector4 *)sub_1825A3980(&v78, _mm_unpacklo_ps(y_low, (__m128)v42).m128_u64[0]);
			//                     if ( m_propertyBlock )
			//                     {
			//                       v78 = *v50;
			//                       UnityEngine::MaterialPropertyBlock::SetVector(m_propertyBlock, FarCloudMarchRangeLocal, &v78, 0LL);
			//                       m_BakedFarCloudCenter = this.fields.m_BakedFarCloudCenter;
			//                       v52 = UnityEngine::Vector4::op_Implicit(&v78, &m_BakedFarCloudCenter, v51);
			//                       if ( v53 )
			//                       {
			//                         v78 = *v52;
			//                         UnityEngine::MaterialPropertyBlock::SetVector(v53, v54, &v78, 0LL);
			//                         m_BakedFarCloudCenter = this.fields.m_BakedFarCloudLastCenter;
			//                         v56 = UnityEngine::Vector4::op_Implicit(&v78, &m_BakedFarCloudCenter, v55);
			//                         if ( v57 )
			//                         {
			//                           v78 = *v56;
			//                           UnityEngine::MaterialPropertyBlock::SetVector(v57, v58, &v78, 0LL);
			//                           *(_QWORD *)&m_BakedFarCloudCenter.x = this.fields.m_propertyBlock;
			//                           m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           v75.x = *((float *)m_FarCloudPanoramicColorRT + 158);
			//                           if ( v17 )
			//                           {
			//                             v59 = sub_18003ED00(5LL);
			//                             v60 = sub_18003ED00(7LL);
			//                             v61 = sub_18003ED00(5LL);
			//                             v78.x = (float)v59;
			//                             v78.z = 1.0 / (float)v61;
			//                             v78.y = (float)v60;
			//                             v78.w = 1.0 / (float)(int)sub_18003ED00(7LL);
			//                             if ( *(_QWORD *)&m_BakedFarCloudCenter.x )
			//                             {
			//                               UnityEngine::MaterialPropertyBlock::SetVector(
			//                                 *(MaterialPropertyBlock **)&m_BakedFarCloudCenter.x,
			//                                 SLODWORD(v75.x),
			//                                 &v78,
			//                                 0LL);
			//                               FloatImpl = UnityEngine::Material::GetFloatImpl(
			//                                             cloudMat,
			//                                             TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FlowTimeScale,
			//                                             0LL);
			//                               v63 = this.fields.m_propertyBlock;
			//                               v64 = FloatImpl;
			//                               v65 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                               FlowSpeedScale = v65._FlowSpeedScale;
			//                               v78 = *UnityEngine::Material::GetVector(&v78, cloudMat, v65._WindSpeed, 0LL);
			//                               v67 = sub_184D04040(&v78);
			//                               v68 = *(float *)&v67;
			//                               v69 = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
			//                                       propertyBlock,
			//                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._GlobalScale,
			//                                       0LL);
			//                               if ( v63 )
			//                               {
			//                                 UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                   v63,
			//                                   FlowSpeedScale,
			//                                   (float)((float)(v69 * v68) * 0.050000001) / v64,
			//                                   0LL);
			//                                 v70 = this.fields.m_propertyBlock;
			//                                 FlowTime = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FlowTime;
			//                                 time = UnityEngine::Time::get_time(0LL);
			//                                 if ( v70 )
			//                                 {
			//                                   UnityEngine::MaterialPropertyBlock::SetFloatImpl(v70, FlowTime, time * v64, 0LL);
			//                                   UnityEngine::Material::GetInt(
			//                                     cloudMat,
			//                                     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PanoramicMarchStepNumEdit,
			//                                     0LL);
			//                                   HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                     volumetricParameters.fields.farCloudMarchStepScale,
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                   v73 = sub_1826E82D0();
			//                                   v12 = (Animator *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                   m_FarCloudPanoramicColorRT = this.fields.m_propertyBlock;
			//                                   if ( m_FarCloudPanoramicColorRT )
			//                                   {
			//                                     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                       (MaterialPropertyBlock *)m_FarCloudPanoramicColorRT,
			//                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._PanoramicMarchStepNum,
			//                                       (float)v73,
			//                                       0LL);
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                     HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//                                       cmd,
			//                                       v17,
			//                                       *(RenderTexture **)&depthRT.x,
			//                                       RenderBufferLoadAction__Enum_DontCare,
			//                                       RenderBufferStoreAction__Enum_Store,
			//                                       0LL);
			//                                     HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
			//                                       cmd,
			//                                       cloudMat,
			//                                       this.fields.m_propertyBlock,
			//                                       5,
			//                                       0,
			//                                       0LL);
			//                                     UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                       propertyBlock,
			//                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudColor,
			//                                       (Texture *)v17,
			//                                       0LL);
			//                                     UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                       propertyBlock,
			//                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudDepth,
			//                                       *(Texture **)&depthRT.x,
			//                                       0LL);
			//                                     depthRT = this.fields.m_BakedFarCloudCenter;
			//                                     v36 = UnityEngine::Vector4::op_Implicit(&v78, &depthRT, v74);
			//                                     v38 = propertyBlock;
			//                                     goto LABEL_18;
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
			//               else
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                 m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                 if ( propertyBlock )
			//                 {
			//                   UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                     propertyBlock,
			//                     *((_DWORD *)m_FarCloudPanoramicColorRT + 203),
			//                     (Texture *)v17,
			//                     0LL);
			//                   UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                     propertyBlock,
			//                     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudDepth,
			//                     v18,
			//                     0LL);
			//                   depthRT = this.fields.m_BakedFarCloudCenter;
			//                   v36 = UnityEngine::Vector4::op_Implicit(&v78, &depthRT, v35);
			//                   v38 = propertyBlock;
			// LABEL_18:
			//                   v78 = *v36;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(v38, v37, &v78, 0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_36:
			//     sub_180B536AC(m_FarCloudPanoramicColorRT, v12);
			//   }
			//   m_FarCloudPanoramicColorRT = IFix::WrappersManagerImpl::GetPatch(4434, 0LL);
			//   if ( !m_FarCloudPanoramicColorRT )
			//     goto LABEL_36;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1274(
			//     (ILFixDynamicMethodWrapper_2 *)m_FarCloudPanoramicColorRT,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     (Object *)cmd,
			//     (Object *)cloudMat,
			//     (Object *)propertyBlock,
			//     (Object *)volumetricParameters,
			//     force,
			//     0LL);
			// }
			// 
		}

		private void UpdateDynamicFarCloudRT(HGCamera hgCamera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, int farCloudSize, HGVolumetricCloudSettingParameters volumetricParameters, [MetadataOffset(Offset = "0x01F91D67")] bool force = false, [MetadataOffset(Offset = "0x01F91D68")] bool axisChanged = false)
		{
			// // Void UpdateDynamicFarCloudRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, Int32, HGVolumetricCloudSettingParameters, Boolean, Boolean)
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateDynamicFarCloudRT(
			//         VolumetricFarCloudRenderer *this,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         Material *cloudMat,
			//         MaterialPropertyBlock *propertyBlock,
			//         int32_t farCloudSize,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         bool force,
			//         bool axisChanged,
			//         MethodInfo *method)
			// {
			//   Material *v10; // r15
			//   CommandBuffer *v11; // r12
			//   unsigned __int64 static_fields; // rdx
			//   VolumetricPipelineRT *m_propertyBlock; // rcx
			//   Component *camera; // rbx
			//   int x; // eax
			//   int v18; // ecx
			//   int32_t slicingIndex; // esi
			//   int32_t v20; // r8d
			//   MethodInfo *v21; // r9
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // edi
			//   __int64 v25; // xmm6_8
			//   int32_t v26; // r8d
			//   MethodInfo *v27; // r9
			//   float time; // xmm12_4
			//   Vector3 *Vector; // rax
			//   Animator *v30; // rdx
			//   int32_t v31; // r8d
			//   MethodInfo *v32; // r9
			//   __int64 v33; // xmm1_8
			//   float v34; // eax
			//   Vector3 *v35; // rax
			//   float v36; // xmm4_4
			//   __int64 v37; // xmm1_8
			//   float v38; // eax
			//   float m_BakedFarCloudTime; // xmm0_4
			//   float m_BakedFarCloudLastTime; // xmm0_4
			//   float v41; // xmm0_4
			//   Int32Enum__Enum v42; // ebx
			//   SettingParameter_1_System_Boolean_ *farCloudEnableTAA; // rcx
			//   unsigned int v44; // esi
			//   Vector4 v45; // xmm0
			//   MethodInfo *v46; // rdx
			//   Vector2 v47; // rax
			//   MaterialPropertyBlock *v48; // r14
			//   _OWORD *v49; // rax
			//   MethodInfo *v50; // r8
			//   Vector4 *v51; // rax
			//   MaterialPropertyBlock *v52; // r10
			//   int32_t v53; // r11d
			//   MaterialPropertyBlock *v54; // r14
			//   Matrix4x4 *Matrix; // rax
			//   float v56; // xmm1_4
			//   float v57; // xmm8_4
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   Vector4 *v61; // rax
			//   MethodInfo *v62; // r8
			//   Vector4 *v63; // rax
			//   MaterialPropertyBlock *v64; // r10
			//   int32_t v65; // r11d
			//   MaterialPropertyBlock *v66; // r10
			//   int32_t dimension_k__BackingField; // edx
			//   _OWORD *v68; // rax
			//   MaterialPropertyBlock *v69; // r10
			//   int32_t v70; // r11d
			//   float FloatImpl; // xmm10_4
			//   float v72; // xmm0_4
			//   float v73; // xmm6_4
			//   float deltaTime; // xmm13_4
			//   MethodInfo *v75; // r9
			//   MethodInfo *v76; // r9
			//   MethodInfo *v77; // r9
			//   MethodInfo *v78; // r8
			//   Vector3 *v79; // rax
			//   void *v80; // xmm7_8
			//   float v81; // ebx
			//   MethodInfo *v82; // r9
			//   MethodInfo *v83; // r9
			//   MethodInfo *v84; // r9
			//   MethodInfo *v85; // r8
			//   Vector3 *v86; // rax
			//   void *v87; // xmm11_8
			//   MethodInfo *v88; // r9
			//   MethodInfo *v89; // r9
			//   MethodInfo *v90; // r9
			//   MethodInfo *v91; // r8
			//   Vector3 *v92; // rax
			//   void *v93; // xmm6_8
			//   MethodInfo *v94; // r8
			//   Vector4 *v95; // rax
			//   MaterialPropertyBlock *v96; // r10
			//   int32_t v97; // r11d
			//   MethodInfo *v98; // r8
			//   Vector4 *v99; // rax
			//   MaterialPropertyBlock *v100; // r10
			//   int32_t v101; // r11d
			//   MethodInfo *v102; // r8
			//   Vector4 *v103; // rax
			//   MaterialPropertyBlock *v104; // r10
			//   int32_t v105; // r11d
			//   float v106; // xmm6_4
			//   MaterialPropertyBlock *v107; // rbx
			//   int v108; // eax
			//   MaterialPropertyBlock *v109; // rbx
			//   MaterialPropertyBlock *v110; // rbx
			//   __m128i v111; // xmm2
			//   int32_t FarCloudPixelSubOffset; // edx
			//   int v113; // r8d
			//   Shader *v114; // rbx
			//   String *v115; // r8
			//   __int64 v116; // rdx
			//   __int64 v117; // rcx
			//   int32_t v118; // ebx
			//   Shader *v119; // rax
			//   String *v120; // r8
			//   Shader *v121; // rax
			//   String *v122; // r8
			//   Shader *v123; // rax
			//   String *v124; // r8
			//   Shader *shader; // rbx
			//   String *s_FarCloudFramingCheckerboard; // r8
			//   __int64 v127; // rdx
			//   __int64 v128; // rcx
			//   Shader *v129; // rax
			//   String *s_FarCloudFramingQuarter; // r8
			//   Shader *v131; // rax
			//   String *s_FarCloudFraming4x2; // r8
			//   Shader *v133; // rax
			//   String *s_FarCloudFraming4x4; // r8
			//   int i; // ebx
			//   VolumetricPipelineRT **v136; // rax
			//   VolumetricPipelineRT **v137; // rax
			//   bool v138; // al
			//   VolumetricPipelineRT **v139; // rax
			//   VolumetricPipelineRT **v140; // rax
			//   bool v141; // al
			//   float v142; // xmm6_4
			//   float v143; // xmm7_4
			//   double v144; // xmm1_8
			//   System::Math *v145; // rcx
			//   int32_t v146; // ebx
			//   double v147; // xmm1_8
			//   System::Math *v148; // rcx
			//   RenderTextureFormat__Enum format; // eax
			//   _DWORD *p_InvPartialVPMatrix; // rdx
			//   VolumetricPipelineRT *m_FarCloudEmptySkipRT; // rcx
			//   RenderTexture *RT; // rax
			//   RenderTexture *v153; // rbx
			//   unsigned int v154; // edi
			//   int v155; // ebx
			//   int v156; // eax
			//   __m128i v157; // xmm0
			//   Texture *v158; // rdi
			//   __m128 v159; // xmm1
			//   _OWORD *v160; // rax
			//   MaterialPropertyBlock *v161; // r10
			//   int32_t v162; // r11d
			//   __m128 v163; // xmm1
			//   __m128 v164; // xmm2
			//   _OWORD *v165; // rax
			//   MaterialPropertyBlock *v166; // r10
			//   int32_t v167; // r11d
			//   Shader *v168; // rbx
			//   String *s_FarCloudSlicingReproject; // r8
			//   RenderTexture *v170; // rax
			//   RenderTexture *v171; // rax
			//   RenderTexture *v172; // rax
			//   __int64 v173; // rbx
			//   RenderTexture *v174; // rax
			//   RenderTexture *v175; // rax
			//   RenderTexture *v176; // rax
			//   RenderTexture *v177; // rax
			//   RenderTexture *v178; // r14
			//   RenderTexture *v179; // rdi
			//   MaterialPropertyBlock *v180; // rbx
			//   VolumetricPipelineRT__Array *v181; // r8
			//   Texture *v182; // rax
			//   VolumetricPipelineRT__Array *v183; // r8
			//   MaterialPropertyBlock *v184; // rbx
			//   Texture *v185; // rax
			//   MaterialPropertyBlock *v186; // rbx
			//   __m128i v187; // xmm0
			//   int32_t v188; // edx
			//   int m_KeywordSpace; // esi
			//   signed int v190; // ebx
			//   int v191; // edi
			//   int v192; // r15d
			//   int v193; // r12d
			//   signed int v194; // r14d
			//   int v195; // esi
			//   int v196; // ebx
			//   int v197; // edi
			//   int v198; // eax
			//   __m128i v199; // xmm1
			//   __int64 v200; // rdx
			//   __int64 v201; // rcx
			//   MaterialPropertyBlock *v202; // rbx
			//   MaterialPropertyBlock *v203; // rbx
			//   bool v204; // cc
			//   int32_t v205; // eax
			//   float v206; // xmm0_4
			//   MaterialPropertyBlock *v207; // rbx
			//   MaterialPropertyBlock *v208; // rbx
			//   int32_t v209; // r14d
			//   bool v210; // al
			//   VolumetricPipelineRT__Array *v211; // rdx
			//   VolumetricPipelineRT *v212; // rcx
			//   Shader *v213; // rbx
			//   String *v214; // r8
			//   RenderTexture *v215; // rax
			//   RenderTexture *v216; // r14
			//   RenderTexture *v217; // rbx
			//   MaterialPropertyBlock *v218; // rbx
			//   RenderTexture *v219; // rax
			//   Texture *v220; // r14
			//   MaterialPropertyBlock *v221; // rbx
			//   int32_t v222; // esi
			//   MaterialPropertyBlock *v223; // rbx
			//   VolumetricPipelineRT__Array *m_FarCloudTAAColors; // r8
			//   MaterialPropertyBlock *v225; // rsi
			//   int32_t depthStencilFormat_k__BackingField; // r14d
			//   __int64 v227; // rbx
			//   Texture *v228; // rax
			//   VolumetricPipelineRT__Array *m_FarCloudTAADepths; // r8
			//   MaterialPropertyBlock *v230; // rsi
			//   int32_t v231; // r14d
			//   Texture *v232; // rax
			//   MaterialPropertyBlock *v233; // rsi
			//   int32_t FarCloudTAACubicSample; // r14d
			//   bool v235; // al
			//   RenderTexture *v236; // rax
			//   RenderTexture *v237; // rdi
			//   RenderTexture *v238; // rbx
			//   MaterialPropertyBlock *v239; // rbx
			//   Shader *v240; // rbx
			//   String *v241; // r8
			//   Shader *v242; // rax
			//   String *v243; // r8
			//   Shader *v244; // rax
			//   String *v245; // r8
			//   Shader *v246; // rax
			//   String *v247; // r8
			//   Shader *v248; // rax
			//   String *s_FarCloudFramingComposeInPass; // r8
			//   MaterialPropertyBlock *v250; // rbx
			//   __m128i si128; // xmm0
			//   VolumetricShaderIDs__StaticFields *v252; // rcx
			//   __int64 FarCloudSlicingUVRescale; // rdx
			//   MaterialPropertyBlock *v254; // rbx
			//   int32_t width_k__BackingField; // r14d
			//   MaterialPropertyBlock *v256; // rbx
			//   VolumetricPipelineRT__Array *m_FarCloudComposeColors; // r8
			//   int32_t volumeDepth_k__BackingField; // r14d
			//   Texture *v259; // rax
			//   VolumetricPipelineRT__Array *m_FarCloudComposeDepths; // r8
			//   MaterialPropertyBlock *v261; // rbx
			//   int32_t mipCount_k__BackingField; // r14d
			//   Texture *v263; // rax
			//   MaterialPropertyBlock *v264; // rbx
			//   int32_t FarCloudReconstructCubicSample; // r14d
			//   bool v266; // al
			//   RenderTexture *v267; // rax
			//   RenderTexture *v268; // rdi
			//   RenderTexture *v269; // rbx
			//   MethodInfo *v270; // rdx
			//   MaterialPropertyBlock *v271; // rbx
			//   Texture *v272; // rax
			//   RenderTargetIdentifier *v273; // rax
			//   __int64 v274; // xmm8_8
			//   __int128 v275; // xmm6
			//   __int128 v276; // xmm7
			//   Texture *v277; // rax
			//   RenderTargetIdentifier *v278; // rax
			//   __int128 v279; // xmm1
			//   __int64 v280; // rdx
			//   VolumetricPipelineRT *v281; // rcx
			//   Texture *v282; // rax
			//   RenderTargetIdentifier *v283; // rax
			//   __int64 v284; // xmm8_8
			//   __int128 v285; // xmm6
			//   __int128 v286; // xmm7
			//   Texture *v287; // rax
			//   RenderTargetIdentifier *v288; // rax
			//   __int128 v289; // xmm1
			//   int32_t v290; // ebx
			//   VolumetricPipelineRT__Array *v291; // rax
			//   Texture *v292; // rax
			//   RenderTargetIdentifier *v293; // rax
			//   __int64 v294; // xmm8_8
			//   __int128 v295; // xmm6
			//   __int128 v296; // xmm7
			//   Texture *v297; // rax
			//   RenderTargetIdentifier *v298; // rax
			//   __int128 v299; // xmm1
			//   __int64 v300; // rdx
			//   VolumetricPipelineRT *v301; // rcx
			//   VolumetricPipelineRT__Array *v302; // rax
			//   Texture *v303; // rax
			//   RenderTargetIdentifier *v304; // rax
			//   __int64 v305; // xmm8_8
			//   __int128 v306; // xmm6
			//   __int128 v307; // xmm7
			//   Texture *v308; // rax
			//   RenderTargetIdentifier *v309; // rax
			//   __int128 v310; // xmm1
			//   int v311; // edi
			//   int32_t FarCloudEmptySkipRT; // esi
			//   Texture *v313; // rax
			//   MethodInfo *v314; // r8
			//   int32_t v315; // r10d
			//   MethodInfo *v316; // r8
			//   int32_t v317; // r10d
			//   float v318; // xmm2_4
			//   float v319; // xmm12_4
			//   Shader *v320; // rbx
			//   String *v321; // r8
			//   bool v322; // [rsp+68h] [rbp-A0h]
			//   LocalKeyword v323; // [rsp+78h] [rbp-90h] BYREF
			//   bool value; // [rsp+98h] [rbp-70h]
			//   LocalKeyword v325; // [rsp+A8h] [rbp-60h] BYREF
			//   int32_t height[2]; // [rsp+C8h] [rbp-40h]
			//   int32_t name; // [rsp+D0h] [rbp-38h]
			//   LocalKeyword keyword; // [rsp+D8h] [rbp-30h] BYREF
			//   int32_t width[2]; // [rsp+F0h] [rbp-18h]
			//   RenderTargetIdentifier v330; // [rsp+F8h] [rbp-10h] BYREF
			//   int v331; // [rsp+128h] [rbp+20h]
			//   RenderTexture *colorRT; // [rsp+130h] [rbp+28h]
			//   int32_t v333; // [rsp+138h] [rbp+30h]
			//   int32_t y; // [rsp+13Ch] [rbp+34h]
			//   int32_t v335; // [rsp+140h] [rbp+38h]
			//   LocalKeyword v336; // [rsp+148h] [rbp+40h] BYREF
			//   unsigned int v337; // [rsp+168h] [rbp+60h]
			//   LocalKeyword v338; // [rsp+170h] [rbp+68h] BYREF
			//   Matrix4x4 v339; // [rsp+188h] [rbp+80h] BYREF
			//   int32_t v340; // [rsp+1C8h] [rbp+C0h]
			//   LocalKeyword depthRT; // [rsp+1D0h] [rbp+C8h] BYREF
			//   Matrix4x4 v342; // [rsp+1E8h] [rbp+E0h] BYREF
			//   LocalKeyword v343; // [rsp+228h] [rbp+120h] BYREF
			// 
			//   v10 = cloudMat;
			//   v11 = cmd;
			//   if ( !byte_18D9197A0 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFarCloudFramingQuality>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     sub_18003C530(&off_18D51F880);
			//     sub_18003C530(&off_18D51F898);
			//     sub_18003C530(&off_18D51F8B0);
			//     sub_18003C530(&off_18D51F7F0);
			//     sub_18003C530(&off_18D51F808);
			//     sub_18003C530(&off_18D51F830);
			//     sub_18003C530(&off_18D51F840);
			//     byte_18D9197A0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4439, 0LL) )
			//   {
			//     if ( !hgCamera )
			//       goto LABEL_260;
			//     camera = (Component *)hgCamera.fields.camera;
			//     x = (int)this.fields.slicingCount.x;
			//     y = (int)this.fields.slicingCount.y;
			//     v18 = x * y;
			//     LODWORD(v338.m_SpaceInfo.m_KeywordSpace) = x;
			//     v331 = x * y;
			//     value = x * y > 1;
			//     if ( force )
			//       this.fields.slicingIndex = v18 - 1;
			//     v335 = v18 - 1;
			//     slicingIndex = this.fields.slicingIndex;
			//     v340 = slicingIndex;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)camera, 0LL) )
			//     {
			//       if ( !camera )
			//         goto LABEL_260;
			//       transform = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !transform )
			//         goto LABEL_260;
			//       position = UnityEngine::Transform::get_position((Vector3 *)&v325, transform, 0LL);
			//     }
			//     else
			//     {
			//       position = UnityEngine::Animator::GetVector((Vector3 *)&v325, (Animator *)static_fields, v20, v21);
			//     }
			//     z = position.z;
			//     v25 = *(_QWORD *)&position.x;
			//     time = UnityEngine::Time::get_time(0LL);
			//     if ( !slicingIndex )
			//     {
			//       Vector = UnityEngine::Animator::GetVector((Vector3 *)&depthRT, (Animator *)static_fields, v26, v27);
			//       v325.m_SpaceInfo.m_KeywordSpace = *(void **)&this.fields.m_BakedFarCloudCenter.x;
			//       v336.m_SpaceInfo.m_KeywordSpace = *(void **)&Vector.x;
			//       if ( (float)((float)((float)((float)(*((float *)&v325.m_SpaceInfo.m_KeywordSpace + 1)
			//                                          - *((float *)&v336.m_SpaceInfo.m_KeywordSpace + 1))
			//                                  * (float)(*((float *)&v325.m_SpaceInfo.m_KeywordSpace + 1)
			//                                          - *((float *)&v336.m_SpaceInfo.m_KeywordSpace + 1)))
			//                          + (float)((float)(*(float *)&v325.m_SpaceInfo.m_KeywordSpace
			//                                          - *(float *)&v336.m_SpaceInfo.m_KeywordSpace)
			//                                  * (float)(*(float *)&v325.m_SpaceInfo.m_KeywordSpace
			//                                          - *(float *)&v336.m_SpaceInfo.m_KeywordSpace)))
			//                  + (float)((float)(this.fields.m_BakedFarCloudCenter.z - Vector.z)
			//                          * (float)(this.fields.m_BakedFarCloudCenter.z - Vector.z))) >= 9.9999994e-11 )
			//       {
			//         v33 = *(_QWORD *)&this.fields.m_BakedFarCloudLastCenter.x;
			//         v34 = this.fields.m_BakedFarCloudLastCenter.z;
			//       }
			//       else
			//       {
			//         v33 = v25;
			//         v34 = z;
			//       }
			//       *(_QWORD *)&this.fields.m_BakedFarCloudLastLastCenter.x = v33;
			//       this.fields.m_BakedFarCloudLastLastCenter.z = v34;
			//       v35 = UnityEngine::Animator::GetVector((Vector3 *)&depthRT, v30, v31, v32);
			//       v325.m_SpaceInfo.m_KeywordSpace = *(void **)&this.fields.m_BakedFarCloudCenter.x;
			//       v336.m_SpaceInfo.m_KeywordSpace = *(void **)&v35.x;
			//       if ( v36 <= (float)((float)((float)((float)(*((float *)&v325.m_SpaceInfo.m_KeywordSpace + 1)
			//                                                 - *((float *)&v336.m_SpaceInfo.m_KeywordSpace + 1))
			//                                         * (float)(*((float *)&v325.m_SpaceInfo.m_KeywordSpace + 1)
			//                                                 - *((float *)&v336.m_SpaceInfo.m_KeywordSpace + 1)))
			//                                 + (float)((float)(*(float *)&v325.m_SpaceInfo.m_KeywordSpace
			//                                                 - *(float *)&v336.m_SpaceInfo.m_KeywordSpace)
			//                                         * (float)(*(float *)&v325.m_SpaceInfo.m_KeywordSpace
			//                                                 - *(float *)&v336.m_SpaceInfo.m_KeywordSpace)))
			//                         + (float)((float)(this.fields.m_BakedFarCloudCenter.z - v35.z)
			//                                 * (float)(this.fields.m_BakedFarCloudCenter.z - v35.z))) )
			//       {
			//         v37 = *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x;
			//         v38 = this.fields.m_BakedFarCloudCenter.z;
			//       }
			//       else
			//       {
			//         v37 = v25;
			//         v38 = z;
			//       }
			//       *(_QWORD *)&this.fields.m_BakedFarCloudLastCenter.x = v37;
			//       this.fields.m_BakedFarCloudLastCenter.z = v38;
			//       m_BakedFarCloudTime = this.fields.m_BakedFarCloudTime;
			//       *(_QWORD *)&this.fields.m_BakedFarCloudCenter.x = v25;
			//       this.fields.m_BakedFarCloudCenter.z = z;
			//       if ( m_BakedFarCloudTime == 0.0 )
			//         m_BakedFarCloudLastTime = time;
			//       else
			//         m_BakedFarCloudLastTime = this.fields.m_BakedFarCloudLastTime;
			//       this.fields.m_BakedFarCloudLastLastTime = m_BakedFarCloudLastTime;
			//       if ( this.fields.m_BakedFarCloudTime == 0.0 )
			//         v41 = time;
			//       else
			//         v41 = this.fields.m_BakedFarCloudTime;
			//       this.fields.m_BakedFarCloudLastTime = v41;
			//       ++this.fields.m_FrameIndex;
			//       this.fields.m_BakedFarCloudTime = time;
			//     }
			//     if ( !volumetricParameters )
			//       goto LABEL_260;
			//     v42 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.farCloudFramingLevel,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFarCloudFramingQuality>::op_Implicit);
			//     farCloudEnableTAA = volumetricParameters.fields.farCloudEnableTAA;
			//     name = v42;
			//     v322 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              farCloudEnableTAA,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     if ( v42 )
			//     {
			//       LODWORD(colorRT) = 1;
			//       static_fields = (unsigned int)(this.fields.m_FrameIndex >> 31);
			//       LODWORD(static_fields) = this.fields.m_FrameIndex % 2;
			//       v44 = static_fields;
			//     }
			//     else
			//     {
			//       LODWORD(colorRT) = 0;
			//       v44 = 0;
			//     }
			//     v337 = v44;
			//     if ( v322 )
			//     {
			//       static_fields = (unsigned int)(this.fields.m_FrameIndex >> 31);
			//       LODWORD(static_fields) = this.fields.m_FrameIndex % 2;
			//       v333 = static_fields;
			//     }
			//     else
			//     {
			//       v333 = 0;
			//     }
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     if ( !m_propertyBlock )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::CopyFrom((MaterialPropertyBlock *)m_propertyBlock, propertyBlock, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !propertyBlock )
			//       goto LABEL_260;
			//     v45 = *UnityEngine::MaterialPropertyBlock::GetVector(
			//              (Vector4 *)&v330,
			//              propertyBlock,
			//              m_propertyBlock[1].fields.Desc._memoryless_k__BackingField,
			//              0LL);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = v45;
			//     v47 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v323, v46);
			//     v48 = this.fields.m_propertyBlock;
			//     v325.m_SpaceInfo.m_KeywordSpace = (void *)v47;
			//     height[0] = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudMarchRangeLocal;
			//     v45.x = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
			//               propertyBlock,
			//               TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvGlobalScale,
			//               0LL)
			//           * 10000.0;
			//     v49 = (_OWORD *)sub_1825A3980(
			//                       &v330,
			//                       _mm_unpacklo_ps((__m128)HIDWORD(v325.m_SpaceInfo.m_KeywordSpace), (__m128)v45).m128_u64[0]);
			//     if ( !v48 )
			//       goto LABEL_260;
			//     *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *v49;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v48, height[0], (Vector4 *)&v323, 0LL);
			//     v325.m_SpaceInfo.m_KeywordSpace = *(void **)&this.fields.m_BakedFarCloudCenter.x;
			//     *(float *)&v325.m_Name = this.fields.m_BakedFarCloudCenter.z;
			//     v51 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v330, (Vector3 *)&v325, v50);
			//     if ( !v52 )
			//       goto LABEL_260;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *v51;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v52, v53, (Vector4 *)&v323, 0LL);
			//     v54 = this.fields.m_propertyBlock;
			//     height[0] = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudCenterLocal;
			//     Matrix = UnityEngine::MaterialPropertyBlock::GetMatrix(
			//                &v342,
			//                propertyBlock,
			//                TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._BoxWorldToLocal,
			//                0LL);
			//     v56 = this.fields.m_BakedFarCloudCenter.y;
			//     v57 = 1.0;
			//     *(float *)&v325.m_SpaceInfo.m_KeywordSpace = this.fields.m_BakedFarCloudCenter.x;
			//     *(float *)&v325.m_Name = this.fields.m_BakedFarCloudCenter.z;
			//     *((float *)&v325.m_SpaceInfo.m_KeywordSpace + 1) = v56;
			//     v58 = *(_OWORD *)&Matrix.m00;
			//     HIDWORD(v325.m_Name) = 1065353216;
			//     *(_OWORD *)&v339.m00 = v58;
			//     v59 = *(_OWORD *)&Matrix.m02;
			//     *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v325.m_SpaceInfo.m_KeywordSpace;
			//     v60 = *(_OWORD *)&Matrix.m01;
			//     *(_OWORD *)&v339.m02 = v59;
			//     *(_OWORD *)&v339.m01 = v60;
			//     *(_OWORD *)&v339.m03 = *(_OWORD *)&Matrix.m03;
			//     v61 = UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v330, &v339, (Vector4 *)&v323, 0LL);
			//     if ( !v54 )
			//       goto LABEL_260;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *v61;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v54, height[0], (Vector4 *)&v323, 0LL);
			//     v325.m_SpaceInfo.m_KeywordSpace = *(void **)&this.fields.m_BakedFarCloudLastCenter.x;
			//     *(float *)&v325.m_Name = this.fields.m_BakedFarCloudLastCenter.z;
			//     v63 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v330, (Vector3 *)&v325, v62);
			//     if ( !v64 )
			//       goto LABEL_260;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *v63;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v64, v65, (Vector4 *)&v323, 0LL);
			//     v66 = this.fields.m_propertyBlock;
			//     m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     *(float *)&v325.m_SpaceInfo.m_KeywordSpace = (float)farCloudSize;
			//     *((float *)&v325.m_SpaceInfo.m_KeywordSpace + 1) = (float)farCloudSize;
			//     *(float *)&v325.m_Name = 1.0 / (float)farCloudSize;
			//     *((float *)&v325.m_Name + 1) = *(float *)&v325.m_Name;
			//     if ( !v66 )
			//       goto LABEL_260;
			//     dimension_k__BackingField = m_propertyBlock[6].fields.Desc._dimension_k__BackingField;
			//     *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v325.m_SpaceInfo.m_KeywordSpace;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v66, dimension_k__BackingField, (Vector4 *)&v323, 0LL);
			//     v68 = (_OWORD *)sub_1825A3980(&v330, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//     if ( !v69 )
			//       goto LABEL_260;
			//     *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *v68;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v69, v70, (Vector4 *)&v323, 0LL);
			//     FloatImpl = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
			//                   propertyBlock,
			//                   TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._GlobalScale,
			//                   0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !v10 )
			//       goto LABEL_260;
			//     v72 = UnityEngine::Material::GetFloatImpl(v10, HIDWORD(m_propertyBlock[1].klass), 0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     v73 = FloatImpl / v72;
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_propertyBlock )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       (MaterialPropertyBlock *)m_propertyBlock,
			//       *(_DWORD *)(static_fields + 600),
			//       v73,
			//       0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_propertyBlock )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       (MaterialPropertyBlock *)m_propertyBlock,
			//       *(_DWORD *)(static_fields + 604),
			//       1.0 / v73,
			//       0LL);
			//     deltaTime = UnityEngine::Time::get_deltaTime(0LL);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Material::GetVector(
			//                                                       (Vector4 *)&v330,
			//                                                       v10,
			//                                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WindSpeed,
			//                                                       0LL);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       FloatImpl,
			//                                                       v75);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       deltaTime,
			//                                                       v76);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       0.050000001,
			//                                                       v77);
			//     v79 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v325, (Vector4 *)&v323, v78);
			//     v80 = *(void **)&v79.x;
			//     v81 = v79.z;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Material::GetVector(
			//                                                       (Vector4 *)&v330,
			//                                                       v10,
			//                                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WindSpeed2,
			//                                                       0LL);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       FloatImpl,
			//                                                       v82);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       deltaTime,
			//                                                       v83);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       0.050000001,
			//                                                       v84);
			//     v86 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v325, (Vector4 *)&v323, v85);
			//     v87 = *(void **)&v86.x;
			//     height[0] = LODWORD(v86.z);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Material::GetVector(
			//                                                       (Vector4 *)&v330,
			//                                                       v10,
			//                                                       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WindSpeed3,
			//                                                       0LL);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       FloatImpl,
			//                                                       v88);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       deltaTime,
			//                                                       v89);
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
			//                                                       (Vector4 *)&v330,
			//                                                       (Vector4 *)&v323,
			//                                                       0.050000001,
			//                                                       v90);
			//     v92 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v325, (Vector4 *)&v323, v91);
			//     v93 = *(void **)&v92.x;
			//     width[0] = LODWORD(v92.z);
			//     v325.m_SpaceInfo.m_KeywordSpace = v80;
			//     *(float *)&v325.m_Name = v81;
			//     v95 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v330, (Vector3 *)&v325, v94);
			//     if ( !v96 )
			//       goto LABEL_260;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *v95;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v96, v97, (Vector4 *)&v323, 0LL);
			//     v325.m_SpaceInfo.m_KeywordSpace = v87;
			//     LODWORD(v325.m_Name) = height[0];
			//     v99 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v330, (Vector3 *)&v325, v98);
			//     if ( !v100 )
			//       goto LABEL_260;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *v99;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v100, v101, (Vector4 *)&v323, 0LL);
			//     v325.m_SpaceInfo.m_KeywordSpace = v93;
			//     LODWORD(v325.m_Name) = width[0];
			//     v103 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v330, (Vector3 *)&v325, v102);
			//     if ( !v104 )
			//       goto LABEL_260;
			//     *(Vector4 *)&v323.m_SpaceInfo.m_KeywordSpace = *v103;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v104, v105, (Vector4 *)&v323, 0LL);
			//     if ( this.fields.m_BakedFarCloudTime == 0.0 || v331 <= 1 )
			//       v106 = 1.0;
			//     else
			//       v106 = (float)(this.fields.m_BakedFarCloudTime - this.fields.m_BakedFarCloudLastTime) / deltaTime;
			//     v107 = this.fields.m_propertyBlock;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !v107 )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(v107, *(_DWORD *)(static_fields + 840), v106, 0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_propertyBlock
			//       || (UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//             (MaterialPropertyBlock *)m_propertyBlock,
			//             *(_DWORD *)(static_fields + 732),
			//             (float)(this.fields.m_FrameIndex % 8),
			//             0LL),
			//           UnityEngine::Material::GetInt(
			//             v10,
			//             TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudMarchStepNumEdit,
			//             0LL),
			//           HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//             volumetricParameters.fields.farCloudMarchStepScale,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit),
			//           v108 = sub_1826E82D0(),
			//           static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs,
			//           (m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock) == 0LL) )
			//     {
			// LABEL_260:
			//       sub_180B536AC(m_propertyBlock, static_fields);
			//     }
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       (MaterialPropertyBlock *)m_propertyBlock,
			//       TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudMarchStepNum,
			//       (float)v108,
			//       0LL);
			//     width[0] = farCloudSize;
			//     height[0] = farCloudSize;
			//     if ( !(_DWORD)colorRT || axisChanged )
			//     {
			//       shader = UnityEngine::Material::get_shader(v10, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//       s_FarCloudFramingCheckerboard = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingCheckerboard;
			//       memset(&v330, 0, 24);
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//         (LocalKeyword *)&v330,
			//         shader,
			//         s_FarCloudFramingCheckerboard,
			//         0LL);
			//       *(_QWORD *)&keyword.m_Index = v330.m_BufferPointer;
			//       *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v330.m_Type;
			//       if ( !v11 )
			//         sub_180B536AC(v128, v127);
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//       v129 = UnityEngine::Material::get_shader(v10, 0LL);
			//       s_FarCloudFramingQuarter = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingQuarter;
			//       memset(&v323, 0, sizeof(v323));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v323, v129, s_FarCloudFramingQuarter, 0LL);
			//       keyword = v323;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//       v131 = UnityEngine::Material::get_shader(v10, 0LL);
			//       s_FarCloudFraming4x2 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFraming4x2;
			//       memset(&v325, 0, sizeof(v325));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v325, v131, s_FarCloudFraming4x2, 0LL);
			//       keyword = v325;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//       v133 = UnityEngine::Material::get_shader(v10, 0LL);
			//       s_FarCloudFraming4x4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFraming4x4;
			//       memset(&v336, 0, sizeof(v336));
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v336, v133, s_FarCloudFraming4x4, 0LL);
			//       keyword = v336;
			//       UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//       goto LABEL_80;
			//     }
			//     v109 = this.fields.m_propertyBlock;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     m_propertyBlock = (VolumetricPipelineRT *)*(unsigned int *)(static_fields + 736);
			//     if ( !v109 )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       v109,
			//       (int32_t)m_propertyBlock,
			//       (float)(this.fields.m_FrameIndex % 16),
			//       0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_propertyBlock )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       (MaterialPropertyBlock *)m_propertyBlock,
			//       *(_DWORD *)(static_fields + 740),
			//       (float)(this.fields.m_FrameIndex % 32),
			//       0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_propertyBlock )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       (MaterialPropertyBlock *)m_propertyBlock,
			//       *(_DWORD *)(static_fields + 744),
			//       (float)(this.fields.m_FrameIndex % 64),
			//       0LL);
			//     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_propertyBlock )
			//       goto LABEL_260;
			//     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//       (MaterialPropertyBlock *)m_propertyBlock,
			//       *(_DWORD *)(static_fields + 748),
			//       (float)(this.fields.m_FrameIndex % 128),
			//       0LL);
			//     switch ( name )
			//     {
			//       case 1:
			//         v110 = this.fields.m_propertyBlock;
			//         width[0] = farCloudSize / 2;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         m_propertyBlock = (VolumetricPipelineRT *)*(unsigned int *)(static_fields + 752);
			//         if ( !v110 )
			//           goto LABEL_260;
			//         v113 = 2;
			//         break;
			//       case 2:
			//         v110 = this.fields.m_propertyBlock;
			//         width[0] = farCloudSize / 2;
			//         height[0] = farCloudSize / 2;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         m_propertyBlock = (VolumetricPipelineRT *)*(unsigned int *)(static_fields + 752);
			//         if ( !v110 )
			//           goto LABEL_260;
			//         v113 = 4;
			//         break;
			//       case 3:
			//         v110 = this.fields.m_propertyBlock;
			//         width[0] = farCloudSize / 4;
			//         height[0] = farCloudSize / 2;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         m_propertyBlock = (VolumetricPipelineRT *)*(unsigned int *)(static_fields + 752);
			//         if ( !v110 )
			//           goto LABEL_260;
			//         v113 = 8;
			//         break;
			//       case 4:
			//         v110 = this.fields.m_propertyBlock;
			//         width[0] = farCloudSize / 4;
			//         height[0] = farCloudSize / 4;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//         if ( !v110 )
			//           goto LABEL_260;
			//         v111 = _mm_cvtsi32_si128(this.fields.m_FrameIndex % 16);
			//         FarCloudPixelSubOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudPixelSubOffset;
			// LABEL_73:
			//         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//           v110,
			//           FarCloudPixelSubOffset,
			//           _mm_cvtepi32_ps(v111).m128_f32[0],
			//           0LL);
			//         goto LABEL_74;
			//       default:
			// LABEL_74:
			//         v114 = UnityEngine::Material::get_shader(v10, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         v115 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingCheckerboard;
			//         memset(&v330, 0, 24);
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v330, v114, v115, 0LL);
			//         *(_QWORD *)&keyword.m_Index = v330.m_BufferPointer;
			//         *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v330.m_Type;
			//         if ( !v11 )
			//           sub_180B536AC(v117, v116);
			//         v118 = name;
			//         UnityEngine::Rendering::CommandBuffer::SetKeyword(v11, v10, &keyword, name == 1, 0LL);
			//         v119 = UnityEngine::Material::get_shader(v10, 0LL);
			//         v120 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingQuarter;
			//         memset(&v323, 0, sizeof(v323));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v323, v119, v120, 0LL);
			//         keyword = v323;
			//         UnityEngine::Rendering::CommandBuffer::SetKeyword(v11, v10, &keyword, v118 == 2, 0LL);
			//         v121 = UnityEngine::Material::get_shader(v10, 0LL);
			//         v122 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFraming4x2;
			//         memset(&v325, 0, sizeof(v325));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v325, v121, v122, 0LL);
			//         keyword = v325;
			//         UnityEngine::Rendering::CommandBuffer::SetKeyword(v11, v10, &keyword, v118 == 3, 0LL);
			//         v123 = UnityEngine::Material::get_shader(v10, 0LL);
			//         v124 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFraming4x4;
			//         memset(&v336, 0, sizeof(v336));
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v336, v123, v124, 0LL);
			//         keyword = v336;
			//         UnityEngine::Rendering::CommandBuffer::SetKeyword(v11, v10, &keyword, v118 == 4, 0LL);
			// LABEL_80:
			//         for ( i = 0; i < 2; ++i )
			//         {
			//           v325.m_SpaceInfo.m_KeywordSpace = this.fields.m_FarCloudComposeColors;
			//           if ( !v325.m_SpaceInfo.m_KeywordSpace )
			//             goto LABEL_260;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           v136 = (VolumetricPipelineRT **)sub_180002B90(v325.m_SpaceInfo.m_KeywordSpace, i);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//             (String *)"m_FarCloudComposeColors",
			//             v136,
			//             farCloudSize,
			//             farCloudSize,
			//             RTLifeCycle__Enum_Persist,
			//             RenderTextureFormat__Enum_ARGBHalf,
			//             0,
			//             0LL);
			//           m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeDepths;
			//           if ( !m_propertyBlock )
			//             goto LABEL_260;
			//           v137 = (VolumetricPipelineRT **)sub_180002B90(m_propertyBlock, i);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//             (String *)"m_FarCloudComposeDepths",
			//             v137,
			//             farCloudSize,
			//             farCloudSize,
			//             RTLifeCycle__Enum_Persist,
			//             RenderTextureFormat__Enum_RHalf,
			//             0,
			//             0LL);
			//           m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//           if ( !m_propertyBlock )
			//             goto LABEL_260;
			//           if ( (unsigned int)i >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//             goto LABEL_258;
			//           m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                     + i);
			//           if ( !m_propertyBlock )
			//             goto LABEL_260;
			//           v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//           v138 = UnityEngine::SystemInfo::SupportsCubicFilter(0LL);
			//           if ( v138 )
			//             v138 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                      volumetricParameters.fields.farCloudFramingCubicSample,
			//                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           m_propertyBlock = (VolumetricPipelineRT *)v325.m_SpaceInfo.m_KeywordSpace;
			//           if ( !v325.m_SpaceInfo.m_KeywordSpace )
			//             goto LABEL_260;
			//           UnityEngine::Texture::set_cubicSample((Texture *)v325.m_SpaceInfo.m_KeywordSpace, v138, 0LL);
			//           v325.m_SpaceInfo.m_KeywordSpace = this.fields.m_FarCloudTAAColors;
			//           if ( !v325.m_SpaceInfo.m_KeywordSpace )
			//             goto LABEL_260;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           v139 = (VolumetricPipelineRT **)sub_180002B90(v325.m_SpaceInfo.m_KeywordSpace, i);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//             (String *)"m_FarCloudTAAColors",
			//             v139,
			//             farCloudSize,
			//             farCloudSize,
			//             RTLifeCycle__Enum_Persist,
			//             RenderTextureFormat__Enum_ARGBHalf,
			//             0,
			//             0LL);
			//           m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAADepths;
			//           if ( !m_propertyBlock )
			//             goto LABEL_260;
			//           v140 = (VolumetricPipelineRT **)sub_180002B90(m_propertyBlock, i);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//             (String *)"m_FarCloudTAADepths",
			//             v140,
			//             farCloudSize,
			//             farCloudSize,
			//             RTLifeCycle__Enum_Persist,
			//             RenderTextureFormat__Enum_RHalf,
			//             0,
			//             0LL);
			//           m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAAColors;
			//           if ( !m_propertyBlock )
			//             goto LABEL_260;
			//           if ( (unsigned int)i >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//             goto LABEL_258;
			//           m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                     + i);
			//           if ( !m_propertyBlock )
			//             goto LABEL_260;
			//           v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//           v141 = UnityEngine::SystemInfo::SupportsCubicFilter(0LL);
			//           if ( v141 )
			//             v141 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                      volumetricParameters.fields.farCloudTAACubicSample,
			//                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           m_propertyBlock = (VolumetricPipelineRT *)v325.m_SpaceInfo.m_KeywordSpace;
			//           if ( !v325.m_SpaceInfo.m_KeywordSpace )
			//             goto LABEL_260;
			//           UnityEngine::Texture::set_cubicSample((Texture *)v325.m_SpaceInfo.m_KeywordSpace, v141, 0LL);
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//           (String *)"m_FarCloudDrawColorRT",
			//           &this.fields.m_FarCloudDrawColorRT,
			//           width[0],
			//           height[0],
			//           RTLifeCycle__Enum_Persist,
			//           RenderTextureFormat__Enum_ARGBHalf,
			//           0,
			//           0LL);
			//         HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//           (String *)"m_FarCloudDrawDepthRT",
			//           &this.fields.m_FarCloudDrawDepthRT,
			//           width[0],
			//           height[0],
			//           RTLifeCycle__Enum_Persist,
			//           RenderTextureFormat__Enum_RHalf,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         v142 = UnityEngine::Material::GetFloatImpl(
			//                  v10,
			//                  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudEmptySkipRTScale,
			//                  0LL);
			//         v143 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                  volumetricParameters.fields.farCloudEmptySkipSizeScale,
			//                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
			//              * v142;
			//         sub_180002C70(TypeInfo::System::Math);
			//         *(_QWORD *)&v144 = COERCE_UNSIGNED_INT((float)farCloudSize);
			//         *(float *)&v144 = *(float *)&v144 * v143;
			//         System::Math::Ceiling(v145, v144);
			//         v146 = (int)*(float *)&v144;
			//         *(_QWORD *)&v147 = COERCE_UNSIGNED_INT((float)farCloudSize);
			//         LODWORD(colorRT) = v146;
			//         *(float *)&v147 = *(float *)&v147 * v143;
			//         System::Math::Ceiling(v148, v147);
			//         height[0] = (int)*(float *)&v147;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         format = RenderTextureFormat__Enum_ARGBHalf;
			//         if ( v331 <= 1 )
			//           format = RenderTextureFormat__Enum_RGHalf;
			//         HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
			//           (String *)"m_FarCloudEmptySkipRT",
			//           &this.fields.m_FarCloudEmptySkipRT,
			//           v146,
			//           (int)*(float *)&v147,
			//           RTLifeCycle__Enum_Persist,
			//           format,
			//           0,
			//           0LL);
			//         m_FarCloudEmptySkipRT = this.fields.m_FarCloudEmptySkipRT;
			//         if ( m_FarCloudEmptySkipRT )
			//         {
			//           RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FarCloudEmptySkipRT, 0LL);
			//           m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this.fields.m_emptySkipPropertyBlock;
			//           v153 = RT;
			//           *(_QWORD *)width = RT;
			//           if ( m_FarCloudEmptySkipRT )
			//           {
			//             UnityEngine::MaterialPropertyBlock::CopyFrom(
			//               (MaterialPropertyBlock *)m_FarCloudEmptySkipRT,
			//               this.fields.m_propertyBlock,
			//               0LL);
			//             v325.m_SpaceInfo.m_KeywordSpace = this.fields.m_emptySkipPropertyBlock;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//             m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//             p_InvPartialVPMatrix = &TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvPartialVPMatrix;
			//             name = p_InvPartialVPMatrix[195];
			//             if ( v153 )
			//             {
			//               v154 = sub_18003ED00(5LL);
			//               v155 = sub_18003ED00(7LL);
			//               v156 = sub_18003ED00(5LL);
			//               v157 = _mm_cvtsi32_si128(v154);
			//               v158 = *(Texture **)width;
			//               LODWORD(v336.m_SpaceInfo.m_KeywordSpace) = _mm_cvtepi32_ps(v157).m128_u32[0];
			//               *((float *)&v336.m_SpaceInfo.m_KeywordSpace + 1) = (float)v155;
			//               *(float *)&v336.m_Name = 1.0 / (float)v156;
			//               *((float *)&v336.m_Name + 1) = 1.0 / (float)(int)sub_18003ED00(7LL);
			//               if ( v325.m_SpaceInfo.m_KeywordSpace )
			//               {
			//                 *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v336.m_SpaceInfo.m_KeywordSpace;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                   (MaterialPropertyBlock *)v325.m_SpaceInfo.m_KeywordSpace,
			//                   name,
			//                   (Vector4 *)&v323,
			//                   0LL);
			//                 v159 = (__m128)0x3F800000u;
			//                 v159.m128_f32[0] = 1.0 / (float)((float)farCloudSize * v143);
			//                 v160 = (_OWORD *)sub_1825A3980(&v330, _mm_unpacklo_ps(v159, v159).m128_u64[0]);
			//                 if ( v161 )
			//                 {
			//                   *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *v160;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(v161, v162, (Vector4 *)&v323, 0LL);
			//                   v163 = (__m128)COERCE_UNSIGNED_INT((float)(int)colorRT);
			//                   v164 = (__m128)COERCE_UNSIGNED_INT((float)height[0]);
			//                   v163.m128_f32[0] = v163.m128_f32[0] / (float)((float)farCloudSize * v143);
			//                   v164.m128_f32[0] = v164.m128_f32[0] / (float)((float)farCloudSize * v143);
			//                   v165 = (_OWORD *)sub_1825A3980(&v330, _mm_unpacklo_ps(v163, v164).m128_u64[0]);
			//                   if ( v166 )
			//                   {
			//                     *(_OWORD *)&v323.m_SpaceInfo.m_KeywordSpace = *v165;
			//                     UnityEngine::MaterialPropertyBlock::SetVector(v166, v167, (Vector4 *)&v323, 0LL);
			//                     v168 = UnityEngine::Material::get_shader(v10, 0LL);
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                     s_FarCloudSlicingReproject = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudSlicingReproject;
			//                     memset(&v343, 0, sizeof(v343));
			//                     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v343, v168, s_FarCloudSlicingReproject, 0LL);
			//                     keyword = v343;
			//                     UnityEngine::Rendering::CommandBuffer::SetKeyword(v11, v10, &keyword, value, 0LL);
			//                     HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(v11, (RenderTexture *)v158, 0LL);
			//                     HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
			//                       v11,
			//                       v10,
			//                       this.fields.m_emptySkipPropertyBlock,
			//                       11,
			//                       0,
			//                       0LL);
			//                     m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//                     p_InvPartialVPMatrix = &TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvPartialVPMatrix;
			//                     if ( m_FarCloudEmptySkipRT )
			//                     {
			//                       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                         (MaterialPropertyBlock *)m_FarCloudEmptySkipRT,
			//                         p_InvPartialVPMatrix[196],
			//                         v158,
			//                         0LL);
			//                       m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//                       if ( m_FarCloudEmptySkipRT )
			//                       {
			//                         if ( v44 >= m_FarCloudEmptySkipRT.fields.Desc._width_k__BackingField )
			//                           goto LABEL_256;
			//                         m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)*((_QWORD *)&m_FarCloudEmptySkipRT.fields.Desc._msaaSamples_k__BackingField
			//                                                                         + (int)v44);
			//                         if ( !m_FarCloudEmptySkipRT )
			//                           goto LABEL_257;
			//                         v170 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FarCloudEmptySkipRT, 0LL);
			//                         p_InvPartialVPMatrix = this.fields.m_FarCloudComposeDepths;
			//                         *(_QWORD *)height = v170;
			//                         if ( !p_InvPartialVPMatrix )
			//                           goto LABEL_257;
			//                         if ( v44 >= p_InvPartialVPMatrix[6] )
			//                           goto LABEL_256;
			//                         m_FarCloudEmptySkipRT = *(VolumetricPipelineRT **)&p_InvPartialVPMatrix[2 * v44 + 8];
			//                         if ( !m_FarCloudEmptySkipRT )
			//                           goto LABEL_257;
			//                         v171 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FarCloudEmptySkipRT, 0LL);
			//                         p_InvPartialVPMatrix = this.fields.m_FarCloudComposeColors;
			//                         *(_QWORD *)width = v171;
			//                         if ( !p_InvPartialVPMatrix )
			//                           goto LABEL_257;
			//                         m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)(1 - v44);
			//                         if ( (unsigned int)m_FarCloudEmptySkipRT >= p_InvPartialVPMatrix[6] )
			//                           goto LABEL_256;
			//                         m_FarCloudEmptySkipRT = *(VolumetricPipelineRT **)&p_InvPartialVPMatrix[2
			//                                                                                               * (int)m_FarCloudEmptySkipRT
			//                                                                                               + 8];
			//                         if ( !m_FarCloudEmptySkipRT )
			//                           goto LABEL_257;
			//                         v172 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FarCloudEmptySkipRT, 0LL);
			//                         p_InvPartialVPMatrix = this.fields.m_FarCloudComposeDepths;
			//                         v336.m_SpaceInfo.m_KeywordSpace = v172;
			//                         if ( !p_InvPartialVPMatrix )
			//                           goto LABEL_257;
			//                         m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)(1 - v44);
			//                         if ( (unsigned int)m_FarCloudEmptySkipRT >= p_InvPartialVPMatrix[6] )
			// LABEL_256:
			//                           sub_180070270(m_FarCloudEmptySkipRT, p_InvPartialVPMatrix);
			//                         m_FarCloudEmptySkipRT = *(VolumetricPipelineRT **)&p_InvPartialVPMatrix[2
			//                                                                                               * (int)m_FarCloudEmptySkipRT
			//                                                                                               + 8];
			//                         if ( m_FarCloudEmptySkipRT )
			//                         {
			//                           v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                               m_FarCloudEmptySkipRT,
			//                                                               0LL);
			//                           if ( v322 )
			//                           {
			//                             m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAAColors;
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             v173 = v333;
			//                             if ( (unsigned int)v333 >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//                               goto LABEL_258;
			//                             m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                       + v333);
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             v174 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                             m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAADepths;
			//                             *(_QWORD *)height = v174;
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             if ( (unsigned int)v173 >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//                               goto LABEL_258;
			//                             m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                       + v173);
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             v175 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                             m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAAColors;
			//                             *(_QWORD *)width = v175;
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             if ( (unsigned int)(1 - v173) >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//                               goto LABEL_258;
			//                             m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                       + 1
			//                                                                       - (int)v173);
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             v176 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                             m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAADepths;
			//                             v336.m_SpaceInfo.m_KeywordSpace = v176;
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             if ( (unsigned int)(1 - v173) >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//                               goto LABEL_258;
			//                             m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                       + 1
			//                                                                       - (int)v173);
			//                             if ( !m_propertyBlock )
			//                               goto LABEL_260;
			//                             v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                                 m_propertyBlock,
			//                                                                 0LL);
			//                           }
			//                           if ( force )
			//                           {
			//                             v240 = UnityEngine::Material::get_shader(v10, 0LL);
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                             v241 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingQuarter;
			//                             memset(&v323, 0, sizeof(v323));
			//                             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v323, v240, v241, 0LL);
			//                             keyword = v323;
			//                             UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//                             v242 = UnityEngine::Material::get_shader(v10, 0LL);
			//                             v243 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingCheckerboard;
			//                             memset(&depthRT, 0, sizeof(depthRT));
			//                             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&depthRT, v242, v243, 0LL);
			//                             keyword = depthRT;
			//                             UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//                             v244 = UnityEngine::Material::get_shader(v10, 0LL);
			//                             v245 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFraming4x2;
			//                             memset(&v338, 0, sizeof(v338));
			//                             UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v338, v244, v245, 0LL);
			//                             keyword = v338;
			//                             UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//                             v246 = UnityEngine::Material::get_shader(v10, 0LL);
			//                             v247 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFraming4x4;
			//                             memset(&v342, 0, 24);
			//                             UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v342, v246, v247, 0LL);
			//                             *(_QWORD *)&keyword.m_Index = *(_QWORD *)&v342.m01;
			//                             *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v342.m00;
			//                             UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//                             v248 = UnityEngine::Material::get_shader(v10, 0LL);
			//                             s_FarCloudFramingComposeInPass = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingComposeInPass;
			//                             memset(&v339, 0, 24);
			//                             UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//                               (LocalKeyword *)&v339,
			//                               v248,
			//                               s_FarCloudFramingComposeInPass,
			//                               0LL);
			//                             *(_QWORD *)&keyword.m_Index = *(_QWORD *)&v339.m01;
			//                             *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v339.m00;
			//                             UnityEngine::Rendering::CommandBuffer::DisableKeyword(v11, v10, &keyword, 0LL);
			//                             v250 = this.fields.m_propertyBlock;
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                             si128 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//                             v252 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                             FarCloudSlicingUVRescale = (unsigned int)v252._FarCloudSlicingUVRescale;
			//                             if ( !v250 )
			//                               sub_180B536AC(v252, FarCloudSlicingUVRescale);
			//                             *(__m128i *)&v330.m_Type = si128;
			//                             UnityEngine::MaterialPropertyBlock::SetVector(
			//                               v250,
			//                               FarCloudSlicingUVRescale,
			//                               (Vector4 *)&v330,
			//                               0LL);
			//                             v254 = this.fields.m_propertyBlock;
			//                             m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                             width_k__BackingField = m_propertyBlock[8].fields.Desc._width_k__BackingField;
			//                             if ( this.fields.m_FrameIndex > 1 )
			//                               v57 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                       volumetricParameters.fields.farCloudFramingComposeRatio,
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                             if ( !v254 )
			//                               goto LABEL_260;
			//                             UnityEngine::MaterialPropertyBlock::SetFloatImpl(v254, width_k__BackingField, v57, 0LL);
			//                             v256 = this.fields.m_propertyBlock;
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                             m_FarCloudComposeColors = this.fields.m_FarCloudComposeColors;
			//                             m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                             volumeDepth_k__BackingField = m_propertyBlock[7].fields.Desc._volumeDepth_k__BackingField;
			//                             if ( !m_FarCloudComposeColors )
			//                               goto LABEL_260;
			//                             if ( 1 - v44 < m_FarCloudComposeColors.max_length.size )
			//                             {
			//                               m_propertyBlock = m_FarCloudComposeColors.vector[1 - v44];
			//                               if ( !m_propertyBlock )
			//                                 goto LABEL_260;
			//                               v259 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                   m_propertyBlock,
			//                                                   0LL);
			//                               if ( !v256 )
			//                                 goto LABEL_260;
			//                               UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                 v256,
			//                                 volumeDepth_k__BackingField,
			//                                 v259,
			//                                 0LL);
			//                               m_FarCloudComposeDepths = this.fields.m_FarCloudComposeDepths;
			//                               v261 = this.fields.m_propertyBlock;
			//                               m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                               mipCount_k__BackingField = m_propertyBlock[7].fields.Desc._mipCount_k__BackingField;
			//                               if ( !m_FarCloudComposeDepths )
			//                                 goto LABEL_260;
			//                               if ( 1 - v44 < m_FarCloudComposeDepths.max_length.size )
			//                               {
			//                                 m_propertyBlock = m_FarCloudComposeDepths.vector[1 - v44];
			//                                 if ( !m_propertyBlock )
			//                                   goto LABEL_260;
			//                                 v263 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                     m_propertyBlock,
			//                                                     0LL);
			//                                 if ( !v261 )
			//                                   goto LABEL_260;
			//                                 UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                   v261,
			//                                   mipCount_k__BackingField,
			//                                   v263,
			//                                   0LL);
			//                                 v264 = this.fields.m_propertyBlock;
			//                                 FarCloudReconstructCubicSample = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudReconstructCubicSample;
			//                                 v266 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                          volumetricParameters.fields.farCloudFramingCubicSample,
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                                 if ( !v264 )
			//                                   goto LABEL_260;
			//                                 UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                   v264,
			//                                   FarCloudReconstructCubicSample,
			//                                   (float)v266,
			//                                   0LL);
			//                                 m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//                                 if ( !m_propertyBlock )
			//                                   goto LABEL_260;
			//                                 if ( v44 < m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                 {
			//                                   m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                             + (int)v44);
			//                                   if ( !m_propertyBlock )
			//                                     goto LABEL_260;
			//                                   v267 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                                   static_fields = (unsigned __int64)this.fields.m_FarCloudComposeDepths;
			//                                   v268 = v267;
			//                                   if ( !static_fields )
			//                                     goto LABEL_260;
			//                                   if ( v44 < *(_DWORD *)(static_fields + 24) )
			//                                   {
			//                                     m_propertyBlock = *(VolumetricPipelineRT **)(static_fields + 8LL * (int)v44 + 32);
			//                                     if ( !m_propertyBlock )
			//                                       goto LABEL_260;
			//                                     v269 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                     HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//                                       v11,
			//                                       v268,
			//                                       v269,
			//                                       RenderBufferLoadAction__Enum_DontCare,
			//                                       RenderBufferStoreAction__Enum_Store,
			//                                       0LL);
			//                                     *(Quaternion *)&v330.m_Type = *UnityEngine::Quaternion::get_identity(
			//                                                                      (Quaternion *)&v330,
			//                                                                      v270);
			//                                     UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(
			//                                       v11,
			//                                       0,
			//                                       1,
			//                                       (Color *)&v330,
			//                                       0LL);
			//                                     v271 = this.fields.m_propertyBlock;
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                     HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(v11, v10, v271, 6, 0, 0LL);
			//                                     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//                                     if ( !m_propertyBlock )
			//                                       goto LABEL_260;
			//                                     if ( v44 < m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                     {
			//                                       m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                                 + (int)v44);
			//                                       if ( !m_propertyBlock )
			//                                         goto LABEL_260;
			//                                       v272 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                           m_propertyBlock,
			//                                                           0LL);
			//                                       v273 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                (RenderTargetIdentifier *)&v339,
			//                                                v272,
			//                                                0LL);
			//                                       m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//                                       v274 = *(_QWORD *)&v273.m_DepthSlice;
			//                                       v275 = *(_OWORD *)&v273.m_Type;
			//                                       v276 = *(_OWORD *)&v273.m_BufferPointer;
			//                                       if ( !m_propertyBlock )
			//                                         goto LABEL_260;
			//                                       if ( 1 - v44 < m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                       {
			//                                         m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                                   + (int)(1 - v44));
			//                                         if ( !m_propertyBlock )
			//                                           goto LABEL_260;
			//                                         v277 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                             m_propertyBlock,
			//                                                             0LL);
			//                                         v278 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                  (RenderTargetIdentifier *)&v342,
			//                                                  v277,
			//                                                  0LL);
			//                                         v279 = *(_OWORD *)&v278.m_BufferPointer;
			//                                         *(_OWORD *)&v339.m00 = *(_OWORD *)&v278.m_Type;
			//                                         *(_QWORD *)&v339.m02 = *(_QWORD *)&v278.m_DepthSlice;
			//                                         *(_OWORD *)&v339.m01 = v279;
			//                                         *(_OWORD *)&v342.m00 = v275;
			//                                         *(_OWORD *)&v342.m01 = v276;
			//                                         *(_QWORD *)&v342.m02 = v274;
			//                                         UnityEngine::Rendering::CommandBuffer::CopyTexture(
			//                                           v11,
			//                                           (RenderTargetIdentifier *)&v342,
			//                                           (RenderTargetIdentifier *)&v339,
			//                                           0LL);
			//                                         v281 = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeDepths;
			//                                         if ( !v281 )
			//                                           goto LABEL_255;
			//                                         if ( v44 >= v281.fields.Desc._width_k__BackingField )
			//                                           sub_180070270(v281, v280);
			//                                         v281 = (VolumetricPipelineRT *)*((_QWORD *)&v281.fields.Desc._msaaSamples_k__BackingField
			//                                                                        + (int)v44);
			//                                         if ( !v281 )
			// LABEL_255:
			//                                           sub_180B536AC(v281, v280);
			//                                         v282 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                             v281,
			//                                                             0LL);
			//                                         v283 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                  &v330,
			//                                                  v282,
			//                                                  0LL);
			//                                         m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeDepths;
			//                                         v284 = *(_QWORD *)&v283.m_DepthSlice;
			//                                         v285 = *(_OWORD *)&v283.m_Type;
			//                                         v286 = *(_OWORD *)&v283.m_BufferPointer;
			//                                         if ( !m_propertyBlock )
			//                                           goto LABEL_260;
			//                                         if ( 1 - v44 < m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                         {
			//                                           m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                                     + (int)(1 - v44));
			//                                           if ( !m_propertyBlock )
			//                                             goto LABEL_260;
			//                                           v287 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                               m_propertyBlock,
			//                                                               0LL);
			//                                           v288 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                    (RenderTargetIdentifier *)&v342,
			//                                                    v287,
			//                                                    0LL);
			//                                           v289 = *(_OWORD *)&v288.m_BufferPointer;
			//                                           *(_OWORD *)&v339.m00 = *(_OWORD *)&v288.m_Type;
			//                                           *(_QWORD *)&v339.m02 = *(_QWORD *)&v288.m_DepthSlice;
			//                                           *(_OWORD *)&v339.m01 = v289;
			//                                           *(_OWORD *)&v342.m00 = v285;
			//                                           *(_OWORD *)&v342.m01 = v286;
			//                                           *(_QWORD *)&v342.m02 = v284;
			//                                           UnityEngine::Rendering::CommandBuffer::CopyTexture(
			//                                             v11,
			//                                             (RenderTargetIdentifier *)&v342,
			//                                             (RenderTargetIdentifier *)&v339,
			//                                             0LL);
			//                                           if ( v322 )
			//                                           {
			//                                             v290 = 0;
			//                                             while ( 1 )
			//                                             {
			//                                               v291 = this.fields.m_FarCloudComposeColors;
			//                                               if ( !v291 )
			//                                                 goto LABEL_260;
			//                                               if ( v44 >= v291.max_length.size )
			//                                                 goto LABEL_258;
			//                                               m_propertyBlock = v291.vector[v44];
			//                                               if ( !m_propertyBlock )
			//                                                 goto LABEL_260;
			//                                               v292 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                                   m_propertyBlock,
			//                                                                   0LL);
			//                                               v293 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                        (RenderTargetIdentifier *)&v339,
			//                                                        v292,
			//                                                        0LL);
			//                                               m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAAColors;
			//                                               v294 = *(_QWORD *)&v293.m_DepthSlice;
			//                                               v295 = *(_OWORD *)&v293.m_Type;
			//                                               v296 = *(_OWORD *)&v293.m_BufferPointer;
			//                                               if ( !m_propertyBlock )
			//                                                 goto LABEL_260;
			//                                               if ( (unsigned int)v290 >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                                 goto LABEL_258;
			//                                               m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                                         + v290);
			//                                               if ( !m_propertyBlock )
			//                                                 goto LABEL_260;
			//                                               v297 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                                   m_propertyBlock,
			//                                                                   0LL);
			//                                               v298 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                        (RenderTargetIdentifier *)&v342,
			//                                                        v297,
			//                                                        0LL);
			//                                               v299 = *(_OWORD *)&v298.m_BufferPointer;
			//                                               *(_OWORD *)&v339.m00 = *(_OWORD *)&v298.m_Type;
			//                                               *(_QWORD *)&v339.m02 = *(_QWORD *)&v298.m_DepthSlice;
			//                                               *(_OWORD *)&v339.m01 = v299;
			//                                               *(_OWORD *)&v342.m00 = v295;
			//                                               *(_OWORD *)&v342.m01 = v296;
			//                                               *(_QWORD *)&v342.m02 = v294;
			//                                               UnityEngine::Rendering::CommandBuffer::CopyTexture(
			//                                                 v11,
			//                                                 (RenderTargetIdentifier *)&v342,
			//                                                 (RenderTargetIdentifier *)&v339,
			//                                                 0LL);
			//                                               v302 = this.fields.m_FarCloudComposeDepths;
			//                                               if ( !v302 )
			//                                                 goto LABEL_249;
			//                                               if ( v44 >= v302.max_length.size )
			//                                                 sub_180070270(v301, v300);
			//                                               v301 = v302.vector[v44];
			//                                               if ( !v301 )
			// LABEL_249:
			//                                                 sub_180B536AC(v301, v300);
			//                                               v303 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                                   v301,
			//                                                                   0LL);
			//                                               v304 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                        &v330,
			//                                                        v303,
			//                                                        0LL);
			//                                               m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAAColors;
			//                                               v305 = *(_QWORD *)&v304.m_DepthSlice;
			//                                               v306 = *(_OWORD *)&v304.m_Type;
			//                                               v307 = *(_OWORD *)&v304.m_BufferPointer;
			//                                               if ( !m_propertyBlock )
			//                                                 goto LABEL_260;
			//                                               if ( (unsigned int)v290 >= m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                                 goto LABEL_258;
			//                                               m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                                         + v290);
			//                                               if ( !m_propertyBlock )
			//                                                 goto LABEL_260;
			//                                               v308 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                                   m_propertyBlock,
			//                                                                   0LL);
			//                                               v309 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                                                        (RenderTargetIdentifier *)&v342,
			//                                                        v308,
			//                                                        0LL);
			//                                               v310 = *(_OWORD *)&v309.m_BufferPointer;
			//                                               *(_OWORD *)&v339.m00 = *(_OWORD *)&v309.m_Type;
			//                                               *(_QWORD *)&v339.m02 = *(_QWORD *)&v309.m_DepthSlice;
			//                                               *(_OWORD *)&v339.m01 = v310;
			//                                               *(_OWORD *)&v342.m00 = v306;
			//                                               *(_OWORD *)&v342.m01 = v307;
			//                                               *(_QWORD *)&v342.m02 = v305;
			//                                               UnityEngine::Rendering::CommandBuffer::CopyTexture(
			//                                                 v11,
			//                                                 (RenderTargetIdentifier *)&v342,
			//                                                 (RenderTargetIdentifier *)&v339,
			//                                                 0LL);
			//                                               if ( ++v290 >= 2 )
			//                                                 goto LABEL_250;
			//                                             }
			//                                           }
			//                                           goto LABEL_250;
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                             goto LABEL_258;
			//                           }
			//                           m_propertyBlock = this.fields.m_FarCloudDrawColorRT;
			//                           if ( !m_propertyBlock )
			//                             goto LABEL_260;
			//                           v177 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                           m_propertyBlock = this.fields.m_FarCloudDrawDepthRT;
			//                           v178 = v177;
			//                           colorRT = v177;
			//                           if ( !m_propertyBlock )
			//                             goto LABEL_260;
			//                           v179 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                           v180 = this.fields.m_propertyBlock;
			//                           depthRT.m_SpaceInfo.m_KeywordSpace = v179;
			//                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                           m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                           v181 = this.fields.m_FarCloudComposeColors;
			//                           static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           name = *(_DWORD *)(static_fields + 708);
			//                           if ( !v181 )
			//                             goto LABEL_260;
			//                           m_propertyBlock = (VolumetricPipelineRT *)(1 - v44);
			//                           if ( (unsigned int)m_propertyBlock >= v181.max_length.size )
			//                             goto LABEL_258;
			//                           m_propertyBlock = v181.vector[(int)m_propertyBlock];
			//                           if ( !m_propertyBlock )
			//                             goto LABEL_260;
			//                           v182 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                           if ( !v180 )
			//                             goto LABEL_260;
			//                           UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v180, name, v182, 0LL);
			//                           v183 = this.fields.m_FarCloudComposeDepths;
			//                           v184 = this.fields.m_propertyBlock;
			//                           m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           name = m_propertyBlock[7].fields.Desc._mipCount_k__BackingField;
			//                           if ( !v183 )
			//                             goto LABEL_260;
			//                           if ( 1 - v44 >= v183.max_length.size )
			//                             goto LABEL_258;
			//                           m_propertyBlock = v183.vector[1 - v44];
			//                           if ( !m_propertyBlock )
			//                             goto LABEL_260;
			//                           v185 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                           if ( !v184 )
			//                             goto LABEL_260;
			//                           UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v184, name, v185, 0LL);
			//                           if ( v331 > 1 )
			//                           {
			//                             if ( !v178 )
			//                               goto LABEL_260;
			//                             sub_18003ED00(5LL);
			//                             m_KeywordSpace = (int)v338.m_SpaceInfo.m_KeywordSpace;
			//                             v190 = sub_1826E82D0();
			//                             sub_18003ED00(7LL);
			//                             v191 = sub_1826E82D0();
			//                             v192 = v190 * (this.fields.slicingIndex % m_KeywordSpace);
			//                             v193 = v191 * (this.fields.slicingIndex / m_KeywordSpace);
			//                             v194 = sub_18003ED00(5LL) - v192;
			//                             if ( v190 < v194 )
			//                               v194 = v190;
			//                             v195 = sub_18003ED00(7LL) - v193;
			//                             if ( v191 < v195 )
			//                               v195 = v191;
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                             HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//                               cmd,
			//                               colorRT,
			//                               (RenderTexture *)depthRT.m_SpaceInfo.m_KeywordSpace,
			//                               RenderBufferLoadAction__Enum_Load,
			//                               RenderBufferStoreAction__Enum_Store,
			//                               0LL);
			//                             *(float *)&v338.m_SpaceInfo.m_KeywordSpace = (float)v192;
			//                             *((float *)&v338.m_SpaceInfo.m_KeywordSpace + 1) = (float)v193;
			//                             *(float *)&v338.m_Name = (float)v194;
			//                             *((float *)&v338.m_Name + 1) = (float)v195;
			//                             *(_OWORD *)&v330.m_Type = *(_OWORD *)&v338.m_SpaceInfo.m_KeywordSpace;
			//                             UnityEngine::Rendering::CommandBuffer::SetViewport(cmd, (Rect *)&v330, 0LL);
			//                             v338.m_SpaceInfo.m_KeywordSpace = this.fields.m_propertyBlock;
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                             y = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudSlicingUVRescale;
			//                             v196 = sub_18003ED00(5LL);
			//                             v197 = sub_18003ED00(7LL);
			//                             v198 = sub_18003ED00(5LL);
			//                             v199 = _mm_cvtsi32_si128(v194);
			//                             v178 = colorRT;
			//                             *(float *)&v323.m_SpaceInfo.m_KeywordSpace = _mm_cvtepi32_ps(v199).m128_f32[0] / (float)v196;
			//                             *((float *)&v323.m_SpaceInfo.m_KeywordSpace + 1) = (float)v195 / (float)v197;
			//                             *(float *)&v323.m_Name = (float)v192 / (float)v198;
			//                             *((float *)&v323.m_Name + 1) = (float)v193 / (float)(int)sub_18003ED00(7LL);
			//                             if ( !v338.m_SpaceInfo.m_KeywordSpace )
			//                               sub_180B536AC(v201, v200);
			//                             UnityEngine::MaterialPropertyBlock::SetVector(
			//                               (MaterialPropertyBlock *)v338.m_SpaceInfo.m_KeywordSpace,
			//                               y,
			//                               (Vector4 *)&v323,
			//                               0LL);
			//                             v44 = v337;
			//                             v10 = cloudMat;
			//                             v11 = cmd;
			//                           }
			//                           else
			//                           {
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                             HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//                               v11,
			//                               v178,
			//                               v179,
			//                               RenderBufferLoadAction__Enum_DontCare,
			//                               RenderBufferStoreAction__Enum_Store,
			//                               0LL);
			//                             v186 = this.fields.m_propertyBlock;
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                             v187 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//                             static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                             if ( !v186 )
			//                               goto LABEL_260;
			//                             v188 = *(_DWORD *)(static_fields + 796);
			//                             *(__m128i *)&v323.m_SpaceInfo.m_KeywordSpace = v187;
			//                             UnityEngine::MaterialPropertyBlock::SetVector(v186, v188, (Vector4 *)&v323, 0LL);
			//                           }
			//                           v202 = this.fields.m_propertyBlock;
			//                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                           HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(v11, v10, v202, 6, 0, 0LL);
			//                           if ( v340 != v335 )
			//                             goto LABEL_250;
			//                           v203 = this.fields.m_propertyBlock;
			//                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                           v204 = this.fields.m_FrameIndex <= 1;
			//                           m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           v205 = m_propertyBlock[8].fields.Desc._width_k__BackingField;
			//                           v335 = v205;
			//                           if ( v204 )
			//                           {
			//                             v206 = 1.0;
			//                           }
			//                           else
			//                           {
			//                             v206 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                      volumetricParameters.fields.farCloudFramingComposeRatio,
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                             v205 = v335;
			//                           }
			//                           if ( !v203 )
			//                             goto LABEL_260;
			//                           UnityEngine::MaterialPropertyBlock::SetFloatImpl(v203, v205, v206, 0LL);
			//                           v207 = this.fields.m_propertyBlock;
			//                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                           static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           if ( !v207 )
			//                             goto LABEL_260;
			//                           UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                             v207,
			//                             *(_DWORD *)(static_fields + 804),
			//                             (Texture *)v178,
			//                             0LL);
			//                           m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//                           static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           if ( !m_propertyBlock )
			//                             goto LABEL_260;
			//                           UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                             (MaterialPropertyBlock *)m_propertyBlock,
			//                             *(_DWORD *)(static_fields + 808),
			//                             (Texture *)depthRT.m_SpaceInfo.m_KeywordSpace,
			//                             0LL);
			//                           v208 = this.fields.m_propertyBlock;
			//                           v209 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudReconstructCubicSample;
			//                           v210 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                    volumetricParameters.fields.farCloudFramingCubicSample,
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                           if ( v208 )
			//                           {
			//                             UnityEngine::MaterialPropertyBlock::SetFloatImpl(v208, v209, (float)v210, 0LL);
			//                             v213 = UnityEngine::Material::get_shader(v10, 0LL);
			//                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                             v214 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudFramingComposeInPass;
			//                             memset(&v330, 0, 24);
			//                             UnityEngine::Rendering::LocalKeyword::LocalKeyword((LocalKeyword *)&v330, v213, v214, 0LL);
			//                             *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v330.m_Type;
			//                             *(_QWORD *)&keyword.m_Index = v330.m_BufferPointer;
			//                             UnityEngine::Rendering::CommandBuffer::SetKeyword(v11, v10, &keyword, axisChanged, 0LL);
			//                             v212 = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//                             if ( v212 )
			//                             {
			//                               if ( v44 >= v212.fields.Desc._width_k__BackingField )
			//                                 goto LABEL_197;
			//                               v212 = (VolumetricPipelineRT *)*((_QWORD *)&v212.fields.Desc._msaaSamples_k__BackingField
			//                                                              + (int)v44);
			//                               if ( !v212 )
			//                                 goto LABEL_198;
			//                               v215 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v212, 0LL);
			//                               v211 = this.fields.m_FarCloudComposeDepths;
			//                               v216 = v215;
			//                               if ( !v211 )
			//                                 goto LABEL_198;
			//                               if ( v44 >= v211.max_length.size )
			// LABEL_197:
			//                                 sub_180070270(v212, v211);
			//                               v212 = v211.vector[v44];
			//                               if ( v212 )
			//                               {
			//                                 v217 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v212, 0LL);
			//                                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                 HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//                                   v11,
			//                                   v216,
			//                                   v217,
			//                                   RenderBufferLoadAction__Enum_DontCare,
			//                                   RenderBufferStoreAction__Enum_Store,
			//                                   0LL);
			//                                 v218 = this.fields.m_propertyBlock;
			//                                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                 HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(v11, v10, v218, 7, 0, 0LL);
			//                                 m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudComposeColors;
			//                                 if ( !m_propertyBlock )
			//                                   goto LABEL_260;
			//                                 if ( v44 < m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                 {
			//                                   m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                             + (int)v44);
			//                                   if ( !m_propertyBlock )
			//                                     goto LABEL_260;
			//                                   v219 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
			//                                   static_fields = (unsigned __int64)this.fields.m_FarCloudComposeDepths;
			//                                   depthRT.m_SpaceInfo.m_KeywordSpace = v219;
			//                                   if ( !static_fields )
			//                                     goto LABEL_260;
			//                                   if ( v44 < *(_DWORD *)(static_fields + 24) )
			//                                   {
			//                                     m_propertyBlock = *(VolumetricPipelineRT **)(static_fields + 8LL * (int)v44 + 32);
			//                                     if ( !m_propertyBlock )
			//                                       goto LABEL_260;
			//                                     v220 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                         m_propertyBlock,
			//                                                         0LL);
			//                                     if ( !v322 )
			//                                     {
			// LABEL_250:
			//                                       v311 = v331;
			//                                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                                       if ( v311 <= 1 )
			//                                       {
			//                                         UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                           propertyBlock,
			//                                           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudColor,
			//                                           *(Texture **)height,
			//                                           0LL);
			//                                         UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                           propertyBlock,
			//                                           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudDepth,
			//                                           *(Texture **)width,
			//                                           0LL);
			// LABEL_254:
			//                                         v320 = UnityEngine::Material::get_shader(v10, 0LL);
			//                                         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//                                         v321 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields.s_FarCloudSlicingReproject;
			//                                         memset(&v339, 0, 24);
			//                                         UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//                                           (LocalKeyword *)&v339,
			//                                           v320,
			//                                           v321,
			//                                           0LL);
			//                                         *(_QWORD *)&keyword.m_Index = *(_QWORD *)&v339.m01;
			//                                         *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v339.m00;
			//                                         UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//                                           v11,
			//                                           v10,
			//                                           &keyword,
			//                                           value,
			//                                           0LL);
			//                                         this.fields.slicingIndex = (this.fields.slicingIndex + 1) % v311;
			//                                         return;
			//                                       }
			//                                       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                         propertyBlock,
			//                                         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudColor,
			//                                         (Texture *)v336.m_SpaceInfo.m_KeywordSpace,
			//                                         0LL);
			//                                       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                         propertyBlock,
			//                                         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudDepth,
			//                                         (Texture *)v325.m_SpaceInfo.m_KeywordSpace,
			//                                         0LL);
			//                                       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                         propertyBlock,
			//                                         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudColor2,
			//                                         *(Texture **)height,
			//                                         0LL);
			//                                       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                         propertyBlock,
			//                                         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudDepth2,
			//                                         *(Texture **)width,
			//                                         0LL);
			//                                       FarCloudEmptySkipRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudEmptySkipRT;
			//                                       m_propertyBlock = this.fields.m_FarCloudEmptySkipRT;
			//                                       if ( m_propertyBlock )
			//                                       {
			//                                         v313 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                             m_propertyBlock,
			//                                                             0LL);
			//                                         UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                           propertyBlock,
			//                                           FarCloudEmptySkipRT,
			//                                           v313,
			//                                           0LL);
			//                                         v325.m_SpaceInfo.m_KeywordSpace = *(void **)&this.fields.m_BakedFarCloudLastCenter.x;
			//                                         *(float *)&v325.m_Name = this.fields.m_BakedFarCloudLastCenter.z;
			//                                         *(Vector4 *)&v330.m_Type = *UnityEngine::Vector4::op_Implicit(
			//                                                                       (Vector4 *)&v330,
			//                                                                       (Vector3 *)&v325,
			//                                                                       v314);
			//                                         UnityEngine::MaterialPropertyBlock::SetVector(
			//                                           propertyBlock,
			//                                           v315,
			//                                           (Vector4 *)&v330,
			//                                           0LL);
			//                                         v325.m_SpaceInfo.m_KeywordSpace = *(void **)&this.fields.m_BakedFarCloudLastLastCenter.x;
			//                                         *(float *)&v325.m_Name = this.fields.m_BakedFarCloudLastLastCenter.z;
			//                                         *(Vector4 *)&v330.m_Type = *UnityEngine::Vector4::op_Implicit(
			//                                                                       (Vector4 *)&v330,
			//                                                                       (Vector3 *)&v325,
			//                                                                       v316);
			//                                         UnityEngine::MaterialPropertyBlock::SetVector(
			//                                           propertyBlock,
			//                                           v317,
			//                                           (Vector4 *)&v330,
			//                                           0LL);
			//                                         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                           propertyBlock,
			//                                           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudReprojectLerpRatio,
			//                                           (float)(this.fields.slicingIndex + 1) / (float)v311,
			//                                           0LL);
			//                                         v318 = time - this.fields.m_BakedFarCloudLastTime;
			//                                         v319 = time - this.fields.m_BakedFarCloudLastLastTime;
			//                                         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                           propertyBlock,
			//                                           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudReprojectDeltaTimeScale,
			//                                           v318 / deltaTime,
			//                                           0LL);
			//                                         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                           propertyBlock,
			//                                           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudReprojectDeltaTimeScale2,
			//                                           v319 / deltaTime,
			//                                           0LL);
			//                                         goto LABEL_254;
			//                                       }
			//                                       goto LABEL_260;
			//                                     }
			//                                     v221 = this.fields.m_propertyBlock;
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                                     m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                     v222 = *(_DWORD *)(static_fields + 800);
			//                                     if ( this.fields.m_FrameIndex > 1 )
			//                                       v57 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                               volumetricParameters.fields.farCloudTAABlendRatio,
			//                                               MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                     if ( !v221 )
			//                                       goto LABEL_260;
			//                                     UnityEngine::MaterialPropertyBlock::SetFloatImpl(v221, v222, v57, 0LL);
			//                                     v223 = this.fields.m_propertyBlock;
			//                                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                                     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                     if ( !v223 )
			//                                       goto LABEL_260;
			//                                     UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                       v223,
			//                                       *(_DWORD *)(static_fields + 716),
			//                                       (Texture *)depthRT.m_SpaceInfo.m_KeywordSpace,
			//                                       0LL);
			//                                     m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_propertyBlock;
			//                                     static_fields = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                     if ( !m_propertyBlock )
			//                                       goto LABEL_260;
			//                                     UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                       (MaterialPropertyBlock *)m_propertyBlock,
			//                                       *(_DWORD *)(static_fields + 720),
			//                                       v220,
			//                                       0LL);
			//                                     m_FarCloudTAAColors = this.fields.m_FarCloudTAAColors;
			//                                     v225 = this.fields.m_propertyBlock;
			//                                     m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                     depthStencilFormat_k__BackingField = m_propertyBlock[7].fields.Desc._depthStencilFormat_k__BackingField;
			//                                     if ( !m_FarCloudTAAColors )
			//                                       goto LABEL_260;
			//                                     v227 = v333;
			//                                     if ( (unsigned int)(1 - v333) < m_FarCloudTAAColors.max_length.size )
			//                                     {
			//                                       m_propertyBlock = m_FarCloudTAAColors.vector[1 - v333];
			//                                       if ( !m_propertyBlock )
			//                                         goto LABEL_260;
			//                                       v228 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                           m_propertyBlock,
			//                                                           0LL);
			//                                       if ( !v225 )
			//                                         goto LABEL_260;
			//                                       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                         v225,
			//                                         depthStencilFormat_k__BackingField,
			//                                         v228,
			//                                         0LL);
			//                                       m_FarCloudTAADepths = this.fields.m_FarCloudTAADepths;
			//                                       v230 = this.fields.m_propertyBlock;
			//                                       m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                       v231 = m_propertyBlock[7].fields.Desc._dimension_k__BackingField;
			//                                       if ( !m_FarCloudTAADepths )
			//                                         goto LABEL_260;
			//                                       if ( (unsigned int)(1 - v227) < m_FarCloudTAADepths.max_length.size )
			//                                       {
			//                                         m_propertyBlock = m_FarCloudTAADepths.vector[1 - (int)v227];
			//                                         if ( !m_propertyBlock )
			//                                           goto LABEL_260;
			//                                         v232 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                             m_propertyBlock,
			//                                                             0LL);
			//                                         if ( !v230 )
			//                                           goto LABEL_260;
			//                                         UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v230, v231, v232, 0LL);
			//                                         v233 = this.fields.m_propertyBlock;
			//                                         FarCloudTAACubicSample = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._FarCloudTAACubicSample;
			//                                         v235 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                                  volumetricParameters.fields.farCloudTAACubicSample,
			//                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//                                         if ( !v233 )
			//                                           goto LABEL_260;
			//                                         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                           v233,
			//                                           FarCloudTAACubicSample,
			//                                           (float)v235,
			//                                           0LL);
			//                                         m_propertyBlock = (VolumetricPipelineRT *)this.fields.m_FarCloudTAAColors;
			//                                         if ( !m_propertyBlock )
			//                                           goto LABEL_260;
			//                                         if ( (unsigned int)v227 < m_propertyBlock.fields.Desc._width_k__BackingField )
			//                                         {
			//                                           m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock.fields.Desc._msaaSamples_k__BackingField
			//                                                                                     + v227);
			//                                           if ( !m_propertyBlock )
			//                                             goto LABEL_260;
			//                                           v236 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                    m_propertyBlock,
			//                                                    0LL);
			//                                           static_fields = (unsigned __int64)this.fields.m_FarCloudTAADepths;
			//                                           v237 = v236;
			//                                           if ( !static_fields )
			//                                             goto LABEL_260;
			//                                           if ( (unsigned int)v227 < *(_DWORD *)(static_fields + 24) )
			//                                           {
			//                                             m_propertyBlock = *(VolumetricPipelineRT **)(static_fields + 8 * v227 + 32);
			//                                             if ( !m_propertyBlock )
			//                                               goto LABEL_260;
			//                                             v238 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			//                                                      m_propertyBlock,
			//                                                      0LL);
			//                                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                             HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			//                                               v11,
			//                                               v237,
			//                                               v238,
			//                                               RenderBufferLoadAction__Enum_DontCare,
			//                                               RenderBufferStoreAction__Enum_Store,
			//                                               0LL);
			//                                             v239 = this.fields.m_propertyBlock;
			//                                             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                                             HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
			//                                               v11,
			//                                               v10,
			//                                               v239,
			//                                               8,
			//                                               0,
			//                                               0LL);
			//                                             goto LABEL_250;
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			// LABEL_258:
			//                                 sub_180070270(m_propertyBlock, static_fields);
			//                               }
			//                             }
			//                           }
			// LABEL_198:
			//                           sub_180B536AC(v212, v211);
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			// LABEL_257:
			//         sub_180B536AC(m_FarCloudEmptySkipRT, p_InvPartialVPMatrix);
			//     }
			//     v111 = _mm_cvtsi32_si128(this.fields.m_FrameIndex % v113);
			//     FarCloudPixelSubOffset = (int)m_propertyBlock;
			//     goto LABEL_73;
			//   }
			//   m_propertyBlock = (VolumetricPipelineRT *)IFix::WrappersManagerImpl::GetPatch(4439, 0LL);
			//   if ( !m_propertyBlock )
			//     goto LABEL_260;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1275(
			//     (ILFixDynamicMethodWrapper_2 *)m_propertyBlock,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     (Object *)v11,
			//     (Object *)v10,
			//     (Object *)propertyBlock,
			//     farCloudSize,
			//     (Object *)volumetricParameters,
			//     force,
			//     axisChanged,
			//     0LL);
			// }
			// 
		}

		public void UpdateOctahedronRT(HGCamera camera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, HGVolumetricCloudSettingParameters volumetricParameters, [MetadataOffset(Offset = "0x01F91D69")] bool force = false)
		{
			// // Void UpdateOctahedronRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, HGVolumetricCloudSettingParameters, Boolean)
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateOctahedronRT(
			//         VolumetricFarCloudRenderer *this,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         Material *cloudMat,
			//         MaterialPropertyBlock *propertyBlock,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *static_fields; // rcx
			//   float v14; // xmm6_4
			//   float v15; // xmm2_4
			//   float FloatImpl; // xmm0_4
			//   Int32Enum__Enum v17; // eax
			//   float v18; // xmm6_4
			//   Int32Enum__Enum farCloudSize; // eax
			// 
			//   if ( !byte_18D9197A1 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9197A1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4438, 0LL) )
			//   {
			//     if ( volumetricParameters )
			//     {
			//       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              volumetricParameters.fields.octahedronEnableSlicing,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//       {
			//         v14 = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                             (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.octahedronSlicingCountX,
			//                             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//         v15 = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                             (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.octahedronSlicingCountY,
			//                             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       }
			//       else
			//       {
			//         v14 = 1.0;
			//         v15 = 1.0;
			//       }
			//       if ( (float)((float)((float)(this.fields.slicingCount.y - v15) * (float)(this.fields.slicingCount.y - v15))
			//                  + (float)((float)(this.fields.slicingCount.x - v14) * (float)(this.fields.slicingCount.x - v14))) >= 9.9999994e-11 )
			//       {
			//         this.fields.slicingIndex = 0;
			//         this.fields.slicingCount.x = v14;
			//         this.fields.slicingCount.y = v15;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       if ( cloudMat )
			//       {
			//         FloatImpl = UnityEngine::Material::GetFloatImpl(cloudMat, HIDWORD(static_fields[16].klass), 0LL);
			//         v17 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                 (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.octahedronSize,
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//         static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         v18 = 1.0 - (float)((float)(1.0 / (float)(int)v17) * (float)(FloatImpl + FloatImpl));
			//         if ( propertyBlock )
			//         {
			//           UnityEngine::MaterialPropertyBlock::SetFloatImpl(propertyBlock, HIDWORD(static_fields[16].monitor), v18, 0LL);
			//           UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//             propertyBlock,
			//             TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._OctahedronUVInvRescale,
			//             1.0 / v18,
			//             0LL);
			//           farCloudSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                            (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.octahedronSize,
			//                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//           HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateDynamicFarCloudRT(
			//             this,
			//             camera,
			//             cmd,
			//             cloudMat,
			//             propertyBlock,
			//             farCloudSize,
			//             volumetricParameters,
			//             force,
			//             0,
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(static_fields, v12);
			//   }
			//   static_fields = IFix::WrappersManagerImpl::GetPatch(4438, 0LL);
			//   if ( !static_fields )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1274(
			//     static_fields,
			//     (Object *)this,
			//     (Object *)camera,
			//     (Object *)cmd,
			//     (Object *)cloudMat,
			//     (Object *)propertyBlock,
			//     (Object *)volumetricParameters,
			//     force,
			//     0LL);
			// }
			// 
		}

		private bool IsDirectionOutside(Vector3 dir)
		{
			// // Boolean IsDirectionOutside(Vector3)
			// bool HG::Rendering::Runtime::VolumetricFarCloudRenderer::IsDirectionOutside(
			//         VolumetricFarCloudRenderer *this,
			//         Vector3 *dir,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // r8
			//   float v6; // eax
			//   __int64 v7; // xmm0_8
			//   float v8; // eax
			//   __int64 v9; // xmm3_8
			//   __int64 v10; // xmm1_8
			//   __int64 v11; // xmm0_8
			//   MethodInfo *v12; // r8
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   float v15; // xmm8_4
			//   MethodInfo *v16; // r8
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   float v19; // xmm2_4
			//   __int64 v21; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v24; // [rsp+20h] [rbp-60h] BYREF
			//   Vector3 v25; // [rsp+30h] [rbp-50h] BYREF
			//   Vector3 v26; // [rsp+40h] [rbp-40h] BYREF
			//   Vector3 v27[2]; // [rsp+50h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4463, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4463, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v21);
			//     z = dir.z;
			//     *(_QWORD *)&v27[0].x = *(_QWORD *)&dir.x;
			//     v27[0].z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(Patch, (Object *)this, v27, 0LL);
			//   }
			//   else
			//   {
			//     v6 = dir.z;
			//     *(_QWORD *)&v24.x = *(_QWORD *)&dir.x;
			//     v7 = *(_QWORD *)&this.fields.semicircularForward.x;
			//     v24.z = v6;
			//     v8 = this.fields.semicircularForward.z;
			//     *(_QWORD *)&v25.x = v7;
			//     v25.z = v8;
			//     UnityEngine::Vector3::Dot(&v25, &v24, v5);
			//     v9 = *(_QWORD *)&dir.x;
			//     v10 = *(_QWORD *)&this.fields.semicircularRight.x;
			//     v11 = *(_QWORD *)&this.fields.semicircularUp.x;
			//     v25.z = dir.z;
			//     v24.z = this.fields.semicircularRight.z;
			//     v26.z = dir.z;
			//     v27[0].z = this.fields.semicircularUp.z;
			//     *(_QWORD *)&v25.x = v9;
			//     *(_QWORD *)&v24.x = v10;
			//     *(_QWORD *)&v26.x = v9;
			//     *(_QWORD *)&v27[0].x = v11;
			//     UnityEngine::Vector3::Dot(&v24, &v25, v12);
			//     v15 = sub_1802E8DF0(v14, v13) * 57.29578;
			//     UnityEngine::Vector3::Dot(v27, &v26, v16);
			//     v19 = sub_1802E8DF0(v18, v17) * 57.29578;
			//     return v15 > 80.0 || v15 < -80.0 || v19 > 40.0 || v19 < -40.0;
			//   }
			// }
			// 
			return default(bool);
		}

		public void UpdateSemicircularRT(HGCamera hgCamera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, HGVolumetricCloudSettingParameters volumetricParameters, bool force)
		{
			// // Void UpdateSemicircularRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, HGVolumetricCloudSettingParameters, Boolean)
			// void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateSemicircularRT(
			//         VolumetricFarCloudRenderer *this,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         Material *cloudMat,
			//         MaterialPropertyBlock *propertyBlock,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   bool axisChanged; // r15
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Component *camera; // rdi
			//   Transform *transform; // rax
			//   Vector3 *forward; // rax
			//   __int64 v18; // xmm7_8
			//   float z; // r12d
			//   Transform *v20; // rax
			//   Vector3 *right; // rax
			//   float v22; // r14d
			//   __int64 v23; // xmm8_8
			//   Transform *v24; // rax
			//   Vector3 *up; // rax
			//   __int64 v26; // xmm9_8
			//   int32_t v27; // r8d
			//   MethodInfo *v28; // r9
			//   Vector3 *Vector; // rax
			//   float v30; // edx
			//   MethodInfo *v31; // r8
			//   Vector4 *v32; // rax
			//   int32_t v33; // r10d
			//   MethodInfo *v34; // r8
			//   int32_t v35; // r10d
			//   MethodInfo *v36; // r8
			//   int32_t v37; // r10d
			//   float fieldOfView; // xmm6_4
			//   float aspect; // xmm0_4
			//   float v40; // xmm6_4
			//   double v41; // xmm0_8
			//   MethodInfo *v42; // r8
			//   int32_t v43; // r10d
			//   MethodInfo *v44; // r8
			//   int32_t v45; // r10d
			//   MethodInfo *v46; // r8
			//   int32_t v47; // r10d
			//   Int32Enum__Enum farCloudSize; // eax
			//   float v49; // [rsp+5Ch] [rbp-65h]
			//   __int64 v50; // [rsp+68h] [rbp-59h] BYREF
			//   float v51; // [rsp+70h] [rbp-51h]
			//   Vector3 semicircularForward; // [rsp+78h] [rbp-49h] BYREF
			//   Vector4 v53[5]; // [rsp+88h] [rbp-39h] BYREF
			// 
			//   axisChanged = 1;
			//   if ( !byte_18D9197A2 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D9197A2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4440, 0LL) )
			//   {
			//     this.fields.slicingIndex = 0;
			//     this.fields.slicingCount.x = 1.0;
			//     this.fields.slicingCount.y = 1.0;
			//     if ( hgCamera )
			//     {
			//       camera = (Component *)hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         transform = UnityEngine::Component::get_transform((Component *)hgCamera.fields.camera, 0LL);
			//         if ( transform )
			//         {
			//           forward = UnityEngine::Transform::get_forward(&semicircularForward, transform, 0LL);
			//           v18 = *(_QWORD *)&forward.x;
			//           z = forward.z;
			//           v20 = UnityEngine::Component::get_transform(camera, 0LL);
			//           if ( v20 )
			//           {
			//             right = UnityEngine::Transform::get_right(&semicircularForward, v20, 0LL);
			//             v22 = right.z;
			//             v23 = *(_QWORD *)&right.x;
			//             v24 = UnityEngine::Component::get_transform(camera, 0LL);
			//             if ( v24 )
			//             {
			//               up = UnityEngine::Transform::get_up(&semicircularForward, v24, 0LL);
			//               v26 = *(_QWORD *)&up.x;
			//               v49 = up.z;
			//               Vector = UnityEngine::Animator::GetVector((Vector3 *)v53, (Animator *)LODWORD(v49), v27, v28);
			//               v50 = *(_QWORD *)&this.fields.semicircularForward.x;
			//               *(_QWORD *)&semicircularForward.x = *(_QWORD *)&Vector.x;
			//               if ( (float)((float)((float)((float)(*((float *)&v50 + 1) - semicircularForward.y)
			//                                          * (float)(*((float *)&v50 + 1) - semicircularForward.y))
			//                                  + (float)((float)(*(float *)&v50 - semicircularForward.x)
			//                                          * (float)(*(float *)&v50 - semicircularForward.x)))
			//                          + (float)((float)(this.fields.semicircularForward.z - Vector.z)
			//                                  * (float)(this.fields.semicircularForward.z - Vector.z))) < 9.9999994e-11 )
			//               {
			//                 *(_QWORD *)&this.fields.semicircularForward.x = v18;
			//                 *(_QWORD *)&this.fields.semicircularRight.x = v23;
			//                 *(_QWORD *)&this.fields.semicircularUp.x = v26;
			//                 this.fields.semicircularForward.z = z;
			//                 this.fields.semicircularRight.z = v22;
			//                 this.fields.semicircularUp.z = v30;
			//               }
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//               semicircularForward = this.fields.semicircularForward;
			//               v32 = UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v31);
			//               if ( propertyBlock )
			//               {
			//                 v53[0] = *v32;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v33, v53, 0LL);
			//                 semicircularForward = this.fields.semicircularRight;
			//                 v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v34);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v35, v53, 0LL);
			//                 semicircularForward = this.fields.semicircularUp;
			//                 v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v36);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v37, v53, 0LL);
			//                 fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)camera, 0LL);
			//                 aspect = UnityEngine::Camera::get_aspect((Camera *)camera, 0LL);
			//                 semicircularForward.z = this.fields.semicircularForward.z;
			//                 v50 = v18;
			//                 v51 = z;
			//                 v40 = 90.0 - (float)((float)(aspect * fieldOfView) * 0.5);
			//                 *(_QWORD *)&semicircularForward.x = *(_QWORD *)&this.fields.semicircularForward.x;
			//                 v41 = sub_182501E20(&v50, &semicircularForward);
			//                 if ( *(float *)&v41 <= (float)(v40 * 0.94999999) )
			//                 {
			//                   axisChanged = 0;
			//                 }
			//                 else
			//                 {
			//                   *(_QWORD *)&this.fields.semicircularRight.x = v23;
			//                   this.fields.semicircularRight.z = v22;
			//                   *(_QWORD *)&this.fields.semicircularForward.x = v18;
			//                   *(_QWORD *)&this.fields.semicircularUp.x = v26;
			//                   this.fields.semicircularUp.z = v49;
			//                   this.fields.semicircularForward.z = z;
			//                 }
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                 semicircularForward = this.fields.semicircularForward;
			//                 v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v42);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v43, v53, 0LL);
			//                 semicircularForward = this.fields.semicircularRight;
			//                 v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v44);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v45, v53, 0LL);
			//                 semicircularForward = this.fields.semicircularUp;
			//                 v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v46);
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v47, v53, 0LL);
			//                 if ( volumetricParameters )
			//                 {
			//                   farCloudSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                    (SettingParameter_1_System_Int32Enum_ *)volumetricParameters.fields.semicircularSize,
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                   HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateDynamicFarCloudRT(
			//                     this,
			//                     hgCamera,
			//                     cmd,
			//                     cloudMat,
			//                     propertyBlock,
			//                     farCloudSize,
			//                     volumetricParameters,
			//                     force,
			//                     axisChanged,
			//                     0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(Patch, v13);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4440, 0LL);
			//   if ( !Patch )
			//     goto LABEL_18;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1274(
			//     Patch,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     (Object *)cmd,
			//     (Object *)cloudMat,
			//     (Object *)propertyBlock,
			//     (Object *)volumetricParameters,
			//     force,
			//     0LL);
			// }
			// 
		}

		private Vector3 m_BakedFarCloudCenter;

		private Vector3 m_BakedFarCloudLastCenter;

		private Vector3 m_BakedFarCloudLastLastCenter;

		private VolumetricPipelineRT[] m_FarCloudComposeColors;

		private VolumetricPipelineRT[] m_FarCloudComposeDepths;

		private int m_FrameIndex;

		private VolumetricPipelineRT[] m_FarCloudTAAColors;

		private VolumetricPipelineRT[] m_FarCloudTAADepths;

		private VolumetricPipelineRT m_FarCloudPanoramicColorRT;

		private VolumetricPipelineRT m_FarCloudPanoramicDepthRT;

		private VolumetricPipelineRT m_FarCloudDrawColorRT;

		private VolumetricPipelineRT m_FarCloudDrawDepthRT;

		private VolumetricPipelineRT m_FarCloudEmptySkipRT;

		private Vector3 semicircularForward;

		private Vector3 semicircularRight;

		private Vector3 semicircularUp;

		private int slicingIndex;

		private Vector2 slicingCount;

		private float m_BakedFarCloudLastLastTime;

		private float m_BakedFarCloudLastTime;

		private float m_BakedFarCloudTime;

		private MaterialPropertyBlock m_propertyBlock;

		private MaterialPropertyBlock m_emptySkipPropertyBlock;

		private int lastAccessFrame;
	}
}
