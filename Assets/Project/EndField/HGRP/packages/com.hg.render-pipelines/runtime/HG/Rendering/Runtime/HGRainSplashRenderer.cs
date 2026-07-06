using System;
using HG.Rendering.Runtime.Rain;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGRainSplashRenderer : HGBaseSubRainRenderer
	{
		public HGRainSplashRenderer()
		{
		}

		internal override void PrepareResources(RainCommonResources commonResources)
		{
		}

		internal override void UpdateData(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
			// void HG::Rendering::Runtime::HGRainSplashRenderer::UpdateData(
			//         HGRainSplashRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *rainSplashTexture; // rdx
			//   char *commonPresettingParam; // rcx
			//   HGRainSplashRenderer_RainSplashRenderParams *m_rainSplashRenderParams; // rax
			//   __m128i v11; // xmm0
			//   RainCommonRenderingParam *v12; // rax
			//   HGRainSplashRenderer_RainSplashRenderParams *v13; // rsi
			//   float v14; // xmm9_4
			//   float m_rainSplashTimeOffset; // xmm8_4
			//   __m128 x_low; // xmm6
			//   __m128 y_low; // xmm7
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   __m128i v20; // xmm0
			//   RainCommonPreSettingParam *v21; // rax
			//   RainCommonPreSettingParam *v22; // rax
			//   HGRainSplashRenderer_RainSplashRenderParams *v23; // rsi
			//   __m128i v24; // xmm0
			//   HGRainSplashRenderer_RainSplashRenderParams *v25; // rdi
			//   __m128i v26; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *P3; // [rsp+20h] [rbp-68h]
			//   String *v29; // [rsp+28h] [rbp-60h]
			//   Vector4 v30[3]; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919DB1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919DB1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1324, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGRainSplashRenderer::ShouldUpdateAndRender(this, 0LL) )
			//       return;
			//     if ( *rainCommonRenderingParam )
			//     {
			//       m_rainSplashRenderParams = this.fields.m_rainSplashRenderParams;
			//       this.fields.m_rainSplashTimeOffset = (float)(deltaTime * (*rainCommonRenderingParam).fields.rainSplashSpeed)
			//                                           + this.fields.m_rainSplashTimeOffset;
			//       commonPresettingParam = (char *)*rainCommonRenderingParam;
			//       if ( *rainCommonRenderingParam )
			//       {
			//         v11 = _mm_loadu_si128((const __m128i *)commonPresettingParam + 2);
			//         if ( m_rainSplashRenderParams )
			//         {
			//           m_rainSplashRenderParams.fields.color = (Color)v11;
			//           commonPresettingParam = (char *)this.fields.m_rainSplashRenderParams;
			//           if ( commonPresettingParam )
			//           {
			//             if ( *rainCommonRenderingParam )
			//             {
			//               *((_DWORD *)commonPresettingParam + 7) = LODWORD((*rainCommonRenderingParam).fields.rainSplashAlpha);
			//               v12 = *rainCommonRenderingParam;
			//               v13 = this.fields.m_rainSplashRenderParams;
			//               if ( *rainCommonRenderingParam )
			//               {
			//                 commonPresettingParam = (char *)v12.fields.commonPresettingParam;
			//                 if ( commonPresettingParam )
			//                 {
			//                   v14 = *((float *)commonPresettingParam + 69);
			//                   m_rainSplashTimeOffset = this.fields.m_rainSplashTimeOffset;
			//                   x_low = (__m128)LODWORD(v12.fields.rainSplashMinMaxSize.x);
			//                   y_low = (__m128)LODWORD(v12.fields.rainSplashMinMaxSize.y);
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                   v20 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                            v30,
			//                                                            v14,
			//                                                            m_rainSplashTimeOffset,
			//                                                            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
			//                                                            0LL));
			//                   if ( v13 )
			//                   {
			//                     v13.fields.rainParams = (Vector4)v20;
			//                     commonPresettingParam = (char *)this.fields.m_rainSplashRenderParams;
			//                     if ( *rainCommonRenderingParam )
			//                     {
			//                       v21 = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//                       if ( v21 )
			//                       {
			//                         rainSplashTexture = (OneofDescriptorProto *)v21.fields.rainSplashTexture;
			//                         if ( commonPresettingParam )
			//                         {
			//                           *((_QWORD *)commonPresettingParam + 6) = rainSplashTexture;
			//                           sub_1800054D0(
			//                             (OneofDescriptor *)(commonPresettingParam + 48),
			//                             rainSplashTexture,
			//                             v18,
			//                             v19,
			//                             P3,
			//                             v29,
			//                             *(MethodInfo **)&v30[0].x);
			//                           if ( *rainCommonRenderingParam )
			//                           {
			//                             v22 = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//                             if ( v22 )
			//                             {
			//                               v23 = this.fields.m_rainSplashRenderParams;
			//                               v24 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                        v30,
			//                                                                        (float)v22.fields.rainSplashTextureRowColumnCount,
			//                                                                        1.0
			//                                                                      / (float)v22.fields.rainSplashTextureRowColumnCount,
			//                                                                        1.0
			//                                                                      / (float)((float)v22.fields.rainSplashTextureRowColumnCount
			//                                                                              * (float)v22.fields.rainSplashTextureRowColumnCount),
			//                                                                        v22.fields.rainSplashYBias,
			//                                                                        0LL));
			//                               if ( v23 )
			//                               {
			//                                 v23.fields.rainSplashTextureScaleOffset = (Vector4)v24;
			//                                 v25 = this.fields.m_rainSplashRenderParams;
			//                                 if ( *rainCommonRenderingParam )
			//                                 {
			//                                   v26 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                            v30,
			//                                                                            (float)(*rainCommonRenderingParam).fields.rainSplashCount
			//                                                                          * 0.0009765625,
			//                                                                            (float)(*rainCommonRenderingParam).fields.cameraMask,
			//                                                                            (*rainCommonRenderingParam).fields.rainSplashLightingPercent,
			//                                                                            0LL));
			//                                   if ( v25 )
			//                                   {
			//                                     v25.fields.rainSplashExtraData = (Vector4)v26;
			//                                     return;
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
			//     }
			// LABEL_23:
			//     sub_180B536AC(commonPresettingParam, rainSplashTexture);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1324, 0LL);
			//   if ( !Patch )
			//     goto LABEL_23;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1381(
			//     Patch,
			//     (Object *)this,
			//     (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//     (Object *)hgCamera,
			//     deltaTime,
			//     0LL);
			// }
			// 
		}

		internal override void SetMaterialData(in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGRainSplashRenderer::SetMaterialData(
			//         HGRainSplashRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   void *static_fields; // rdx
			//   MaterialPropertyBlock *v8; // rcx
			//   Material *m_rainSplashMat; // rdi
			//   Material *v10; // rdi
			//   MaterialPropertyBlock *m_materialPropertyBlock; // rdi
			//   MethodInfo *v12; // r8
			//   HGRainSplashRenderer_RainSplashRenderParams *m_rainSplashRenderParams; // rax
			//   Color *v14; // rax
			//   int32_t v15; // r10d
			//   HGRainSplashRenderer_RainSplashRenderParams *v16; // rax
			//   int32_t v17; // edx
			//   HGRainSplashRenderer_RainSplashRenderParams *v18; // r8
			//   HGRainSplashRenderer_RainSplashRenderParams *v19; // rax
			//   int32_t v20; // edx
			//   HGRainSplashRenderer_RainSplashRenderParams *v21; // rax
			//   int32_t v22; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 color; // [rsp+30h] [rbp-28h] BYREF
			//   Color v25; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919DB2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     byte_18D919DB2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1326, 0LL) )
			//   {
			//     if ( !*rainCommonRenderingParam )
			//       goto LABEL_22;
			//     if ( (*rainCommonRenderingParam).fields.enableRainLighting
			//       && (*rainCommonRenderingParam).fields.rainSplashLightingPercent > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//     {
			//       m_rainSplashMat = this.fields.m_rainSplashMat;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//       if ( !m_rainSplashMat )
			//         goto LABEL_22;
			//       UnityEngine::Material::EnableKeyword(m_rainSplashMat, *((String **)static_fields + 1), 0LL);
			//     }
			//     else
			//     {
			//       v10 = this.fields.m_rainSplashMat;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//       if ( !v10 )
			//         goto LABEL_22;
			//       UnityEngine::Material::DisableKeyword(v10, *((String **)static_fields + 1), 0LL);
			//     }
			//     m_materialPropertyBlock = this.fields.m_materialPropertyBlock;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     v8 = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     m_rainSplashRenderParams = this.fields.m_rainSplashRenderParams;
			//     if ( m_rainSplashRenderParams )
			//     {
			//       color = (Vector4)m_rainSplashRenderParams.fields.color;
			//       v14 = UnityEngine::Color::op_Implicit(&v25, &color, v12);
			//       if ( m_materialPropertyBlock )
			//       {
			//         color = (Vector4)*v14;
			//         UnityEngine::MaterialPropertyBlock::SetVector(m_materialPropertyBlock, v15, &color, 0LL);
			//         v8 = this.fields.m_materialPropertyBlock;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v16 = this.fields.m_rainSplashRenderParams;
			//         if ( v16 )
			//         {
			//           if ( v8 )
			//           {
			//             v17 = *((_DWORD *)static_fields + 793);
			//             color = v16.fields.rainParams;
			//             UnityEngine::MaterialPropertyBlock::SetVector(v8, v17, &color, 0LL);
			//             v18 = this.fields.m_rainSplashRenderParams;
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( v18 )
			//             {
			//               HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//                 this.fields.m_materialPropertyBlock,
			//                 *((_DWORD *)static_fields + 789),
			//                 (Texture *)v18.fields.rainSplashTexture,
			//                 0LL);
			//               v8 = this.fields.m_materialPropertyBlock;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               v19 = this.fields.m_rainSplashRenderParams;
			//               if ( v19 )
			//               {
			//                 if ( v8 )
			//                 {
			//                   v20 = *((_DWORD *)static_fields + 790);
			//                   color = v19.fields.rainSplashTextureScaleOffset;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(v8, v20, &color, 0LL);
			//                   v8 = this.fields.m_materialPropertyBlock;
			//                   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                   v21 = this.fields.m_rainSplashRenderParams;
			//                   if ( v21 )
			//                   {
			//                     if ( v8 )
			//                     {
			//                       v22 = *((_DWORD *)static_fields + 792);
			//                       color = v21.fields.rainSplashExtraData;
			//                       UnityEngine::MaterialPropertyBlock::SetVector(v8, v22, &color, 0LL);
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
			// LABEL_22:
			//     sub_180B536AC(v8, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1326, 0LL);
			//   if ( !Patch )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_281(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
			// }
			// 
		}

		internal override void UpdateRendererObjs(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRainSplashRenderer::UpdateRendererObjs(
			//         HGRainSplashRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Renderer *m_rainSplashMr; // rcx
			//   __int64 v8; // rdx
			//   Transform *m_rainSplashObjTrans; // rdi
			//   char v10; // di
			//   Transform *v11; // rsi
			//   __int64 (__fastcall *v12)(Transform *, __int64, HGCamera *, MethodInfo *); // rax
			//   __int64 v13; // rsi
			//   unsigned __int8 (__fastcall *v14)(__int64); // rax
			//   MeshRenderer *v15; // rdi
			//   MeshRenderer *v16; // rdi
			//   MaterialPropertyBlock *m_materialPropertyBlock; // rbx
			//   void (__fastcall *v18)(MeshRenderer *, MaterialPropertyBlock *); // rax
			//   GameObject *v19; // rax
			//   Object_1 *v20; // rdi
			//   __int64 v21; // rdx
			//   struct HGBaseSubRainRenderer__Class *v22; // rax
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   OneofDescriptorProto *v26; // rdx
			//   FileDescriptor *v27; // r8
			//   MessageDescriptor *v28; // r9
			//   Object *v29; // rax
			//   Object_1 *camera; // r14
			//   Transform *transform; // rax
			//   Transform *v32; // r14
			//   Transform *v33; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   Transform *v36; // rdi
			//   void (__fastcall *v37)(Transform *, MethodInfo **); // rax
			//   GameObject *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v40; // rax
			//   __int64 v41; // rax
			//   __int64 v42; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-28h]
			//   String *v45; // [rsp+28h] [rbp-20h]
			//   String *v46; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v47; // [rsp+30h] [rbp-18h] BYREF
			//   int v48; // [rsp+38h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDC96 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C9B5C18);
			//     byte_18D8EDC96 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_rainSplashMr = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, rainCommonRenderingParam);
			//     m_rainSplashMr = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *(_QWORD *)m_rainSplashMr[7].fields._._.m_CachedPtr;
			//   if ( !v8 )
			//     goto LABEL_60;
			//   if ( *(int *)(v8 + 24) > 1327 )
			//   {
			//     if ( !LODWORD(m_rainSplashMr[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(m_rainSplashMr, v8);
			//       m_rainSplashMr = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_rainSplashMr = *(Renderer **)m_rainSplashMr[7].fields._._.m_CachedPtr;
			//     if ( !m_rainSplashMr )
			//       goto LABEL_60;
			//     if ( LODWORD(m_rainSplashMr[1].klass) <= 0x52F )
			//       sub_180070270(m_rainSplashMr, v8);
			//     if ( m_rainSplashMr[443].fields._._.m_CachedPtr )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1327, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//           Patch,
			//           (Object *)this,
			//           (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//           (Object *)hgCamera,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_60;
			//     }
			//   }
			//   m_rainSplashObjTrans = this.fields.m_rainSplashObjTrans;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !m_rainSplashObjTrans )
			//     goto LABEL_45;
			//   m_rainSplashMr = (Renderer *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !m_rainSplashObjTrans.fields._._.m_CachedPtr )
			//   {
			// LABEL_45:
			//     v19 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//     v20 = (Object_1 *)v19;
			//     if ( !v19 )
			//       goto LABEL_60;
			//     UnityEngine::GameObject::GameObject(v19, (String *)"!RAINSPLASHOBJ", 0LL);
			//     v22 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, v21);
			//       v22 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     }
			//     UnityEngine::Object::set_hideFlags(v20, v22.static_fields.RAIN_RSC_HIDE_FLAGS, 0LL);
			//     this.fields.m_rainSplashObjTrans = UnityEngine::GameObject::get_transform((GameObject *)v20, 0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_rainSplashObjTrans,
			//       v23,
			//       v24,
			//       v25,
			//       (String__Array *)methoda,
			//       v45,
			//       v47);
			//     this.fields.m_rainSplashMr = (MeshRenderer *)UnityEngine::GameObject::AddComponent<System::Object>(
			//                                                     (GameObject *)v20,
			//                                                     MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_rainSplashMr, v26, v27, v28, (String__Array *)methodb, v46, v47);
			//     v29 = UnityEngine::GameObject::AddComponent<System::Object>(
			//             (GameObject *)v20,
			//             MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     if ( !v29 )
			//       goto LABEL_60;
			//     UnityEngine::MeshFilter::set_sharedMesh((MeshFilter *)v29, this.fields.m_rainSplashMesh, 0LL);
			//     m_rainSplashMr = (Renderer *)this.fields.m_rainSplashMr;
			//     if ( !m_rainSplashMr )
			//       goto LABEL_60;
			//     UnityEngine::Renderer::SetMaterial(m_rainSplashMr, this.fields.m_rainSplashMat, 0LL);
			//     if ( hgCamera )
			//     {
			//       camera = (Object_1 *)hgCamera.fields.camera;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
			//       {
			//         transform = UnityEngine::GameObject::get_transform((GameObject *)v20, 0LL);
			//         m_rainSplashMr = (Renderer *)hgCamera.fields.camera;
			//         v32 = transform;
			//         if ( !m_rainSplashMr )
			//           goto LABEL_60;
			//         v33 = UnityEngine::Component::get_transform((Component *)m_rainSplashMr, 0LL);
			//         if ( !v32 )
			//           goto LABEL_60;
			//         UnityEngine::Transform::SetParent(v32, v33, 1, 0LL);
			//         v36 = UnityEngine::GameObject::get_transform((GameObject *)v20, 0LL);
			//         if ( !v36 )
			//           sub_180B536AC(v35, v34);
			//         v37 = (void (__fastcall *)(Transform *, MethodInfo **))qword_18D8F52F8;
			//         v47 = (MethodInfo *)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v48 = 1065353216;
			//         if ( !qword_18D8F52F8 )
			//         {
			//           v37 = (void (__fastcall *)(Transform *, MethodInfo **))sub_180017470(
			//                                                                    "UnityEngine.Transform::set_localPosition_Injected(Uni"
			//                                                                    "tyEngine.Vector3&)");
			//           qword_18D8F52F8 = (__int64)v37;
			//         }
			//         v37(v36, &v47);
			//       }
			//     }
			//   }
			//   if ( !*rainCommonRenderingParam )
			//     goto LABEL_60;
			//   v10 = (*rainCommonRenderingParam).fields.enable
			//      && HG::Rendering::Runtime::HGRainSplashRenderer::ShouldUpdateAndRender(this, 0LL);
			//   v11 = this.fields.m_rainSplashObjTrans;
			//   if ( !v11 )
			//     goto LABEL_60;
			//   v12 = (__int64 (__fastcall *)(Transform *, __int64, HGCamera *, MethodInfo *))qword_18D8F4D48;
			//   if ( !qword_18D8F4D48 )
			//   {
			//     v12 = (__int64 (__fastcall *)(Transform *, __int64, HGCamera *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                     "UnityEngine.Component::get_gameObject()");
			//     if ( !v12 )
			//     {
			//       v40 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//       sub_18000F750(v40, 0LL);
			//     }
			//     qword_18D8F4D48 = (__int64)v12;
			//   }
			//   v13 = v12(v11, v8, hgCamera, method);
			//   if ( !v13 )
			//     goto LABEL_60;
			//   v14 = (unsigned __int8 (__fastcall *)(__int64))qword_18D8F4E00;
			//   if ( !qword_18D8F4E00 )
			//   {
			//     v14 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.GameObject::get_activeSelf()");
			//     if ( !v14 )
			//     {
			//       v41 = sub_1802DBBE8("UnityEngine.GameObject::get_activeSelf()");
			//       sub_18000F750(v41, 0LL);
			//     }
			//     qword_18D8F4E00 = (__int64)v14;
			//   }
			//   if ( v14(v13) != v10 )
			//   {
			//     m_rainSplashMr = (Renderer *)this.fields.m_rainSplashObjTrans;
			//     if ( !m_rainSplashMr )
			//       goto LABEL_60;
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)m_rainSplashMr, 0LL);
			//     if ( !gameObject )
			//       goto LABEL_60;
			//     UnityEngine::GameObject::SetActive(gameObject, v10, 0LL);
			//   }
			//   v15 = this.fields.m_rainSplashMr;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v15 )
			//   {
			//     m_rainSplashMr = (Renderer *)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( v15.fields._._._.m_CachedPtr )
			//     {
			//       v16 = this.fields.m_rainSplashMr;
			//       m_materialPropertyBlock = this.fields.m_materialPropertyBlock;
			//       if ( v16 )
			//       {
			//         v18 = (void (__fastcall *)(MeshRenderer *, MaterialPropertyBlock *))qword_18D8F45B0;
			//         if ( !qword_18D8F45B0 )
			//         {
			//           v18 = (void (__fastcall *)(MeshRenderer *, MaterialPropertyBlock *))il2cpp_resolve_icall_0(
			//                                                                                 "UnityEngine.Renderer::Internal_SetProper"
			//                                                                                 "tyBlock(UnityEngine.MaterialPropertyBlock)");
			//           if ( !v18 )
			//           {
			//             v42 = sub_1802DBBE8("UnityEngine.Renderer::Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)");
			//             sub_18000F750(v42, 0LL);
			//           }
			//           qword_18D8F45B0 = (__int64)v18;
			//         }
			//         v18(v16, m_materialPropertyBlock);
			//         return;
			//       }
			// LABEL_60:
			//       sub_180B536AC(m_rainSplashMr, v8);
			//     }
			//   }
			// }
			// 
		}

		internal override void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGRainSplashRenderer::Dispose(HGRainSplashRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1328, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1328, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_rainSplashObjTrans,
			//       0LL);
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_rainSplashMat,
			//       0LL);
			//   }
			// }
			// 
		}

		internal bool CheckRuntimeResources()
		{
			// // Boolean CheckRuntimeResources()
			// bool HG::Rendering::Runtime::HGRainSplashRenderer::CheckRuntimeResources(
			//         HGRainSplashRenderer *this,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_rainSplashMesh; // rbx
			//   bool result; // al
			//   Object_1 *m_rainSplashMat; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919DB3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919DB3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1331, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1331, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_rainSplashMesh = (Object_1 *)this.fields.m_rainSplashMesh;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     result = UnityEngine::Object::op_Inequality(0LL, m_rainSplashMesh, 0LL);
			//     if ( result )
			//     {
			//       m_rainSplashMat = (Object_1 *)this.fields.m_rainSplashMat;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       return UnityEngine::Object::op_Inequality(0LL, m_rainSplashMat, 0LL);
			//     }
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		internal bool ShouldUpdateAndRender()
		{
			// // Boolean ShouldUpdateAndRender()
			// bool HG::Rendering::Runtime::HGRainSplashRenderer::ShouldUpdateAndRender(
			//         HGRainSplashRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1325, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1325, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_SetMaterialData(ref RainCommonRenderingParam P0, ref ScriptableRenderContext P1)
		{
			// // Void <>iFixBaseProxy_SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_SetMaterialData(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **P0,
			//         ScriptableRenderContext *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::SetMaterialData((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_UpdateRendererObjs(ref RainCommonRenderingParam P0, HGCamera P1)
		{
			// // Void <>iFixBaseProxy_UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_UpdateRendererObjs(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **P0,
			//         HGCamera *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::UpdateRendererObjs((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose()
		{
			// // Void <>iFixBaseProxy_Dispose()
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_Dispose(
			//         HGFarRainRenderer *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose((HGBaseSubRainRenderer *)this, 0LL);
			// }
			// 
		}

		private Mesh m_rainSplashMesh;

		private Shader m_rainSplashShader;

		private Material m_rainSplashMat;

		private Transform m_rainSplashObjTrans;

		private MeshRenderer m_rainSplashMr;

		private MaterialPropertyBlock m_materialPropertyBlock;

		private HGRainSplashRenderer.RainSplashRenderParams m_rainSplashRenderParams;

		private float m_rainSplashTimeOffset;

		internal class RainSplashRenderParams
		{
			public RainSplashRenderParams()
			{
				// // HGRainSplashRenderer+RainSplashRenderParams()
				// void HG::Rendering::Runtime::HGRainSplashRenderer::RainSplashRenderParams::RainSplashRenderParams(
				//         HGRainSplashRenderer_RainSplashRenderParams *this,
				//         MethodInfo *method)
				// {
				//   Vector3Int *v2; // r8
				//   ITilemap *v3; // r9
				//   TileBase *v5; // rdx
				//   Vector3Int *v6; // r8
				//   ITilemap *v7; // r9
				//   OneofDescriptorProto *v8; // rdx
				//   FileDescriptor *v9; // r8
				//   MessageDescriptor *v10; // r9
				//   TileAnimationData v11; // [rsp+20h] [rbp-18h] BYREF
				//   MethodInfo *v12; // [rsp+30h] [rbp-8h]
				// 
				//   this.fields.color = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                  &v11,
				//                                  (TileBase *)method,
				//                                  v2,
				//                                  v3,
				//                                  (MethodInfo *)v11.m_AnimatedSprites);
				//   this.fields.rainParams = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                         &v11,
				//                                         v5,
				//                                         v6,
				//                                         v7,
				//                                         (MethodInfo *)v11.m_AnimatedSprites);
				//   this.fields.rainSplashTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.rainSplashTexture,
				//     v8,
				//     v9,
				//     v10,
				//     (String__Array *)v11.m_AnimatedSprites,
				//     *(String **)&v11.m_AnimationSpeed,
				//     v12);
				//   this.fields.rainSplashTextureScaleOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
				//   this.fields.rainSplashExtraData = 0LL;
				// }
				// 
			}

			public Color color;

			public Vector4 rainParams;

			public Texture2D rainSplashTexture;

			public Vector4 rainSplashTextureScaleOffset;

			public Vector4 rainSplashExtraData;
		}
	}
}
