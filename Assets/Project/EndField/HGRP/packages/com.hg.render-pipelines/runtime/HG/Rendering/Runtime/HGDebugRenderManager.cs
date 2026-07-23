using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public sealed class HGDebugRenderManager // TypeDefIndex: 38106
	{
		// Fields
		private static bool s_enableLightPixelDebugger; // 0x00
		private static bool s_enableShadowDirectionDebug; // 0x01
		private static Light s_shadowDirectionDebugLight; // 0x08
		private static Vector3 selectedDebugLightWorldPoint; // 0x10
		private static bool selectedDebugLightWorldPointValid; // 0x1C
		private static Material lineMaterial; // 0x20
		private const int LIGHT_PIXEL_DEBUGGER_WINDOW_ID = 783229733; // Metadata: 0x023038C3
		private Vector2 m_lightPixelDebuggerWindowRectPercentage; // 0x10
		private Rect m_lightPixelDebuggerWindowRect; // 0x18
		private static bool s_lightPixelSelectionMode; // 0x28
		private static LightPixelDebugInfo s_lightPixelDebugInfo; // 0x30
		private static RaycastHit[] s_raycastResults; // 0x38
	
		// Nested types
		private class LightPixelDebugInfo // TypeDefIndex: 38104
		{
			// Fields
			public Light dirLight; // 0x10
			public List<Light> localLights; // 0x18
	
			// Constructors
			public LightPixelDebugInfo() {} // 0x00000001841E1670-0x00000001841E1680
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
		public HGDebugRenderManager() {} // 0x0000000184DA1790-0x0000000184DA17B0
		// HGDebugRenderManager()
		void HG::Rendering::Runtime::HGDebugRenderManager::HGDebugRenderManager(HGDebugRenderManager *this, MethodInfo *method)
		{
		  this->fields.m_lightPixelDebuggerWindowRect = (Rect)_mm_load_si128((const __m128i *)&xmmword_18DA45BB0);
		  this->fields.m_lightPixelDebuggerWindowRectPercentage.x = -1.0;
		  this->fields.m_lightPixelDebuggerWindowRectPercentage.y = -1.0;
		}
		
		static HGDebugRenderManager() {} // 0x0000000189B79F40-0x0000000189B7A070
		// HGDebugRenderManager()
		void HG::Rendering::Runtime::HGDebugRenderManager::cctor(MethodInfo *method)
		{
		  PropertyInfo_1 *v1; // r8
		  Int32__Array **v2; // r9
		  __int64 i; // rdx
		  Vector3__StaticFields *static_fields; // rcx
		  PropertyInfo_1 *z_low; // r8
		  HGDebugRenderManager__StaticFields *v6; // rdx
		  Material *v7; // r10
		  Int32__Array **v8; // r9
		  Int32__Array **v9; // r9
		  HGDebugRenderManager_LightPixelDebugInfo *v10; // r10
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  __int64 v13; // rax
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+50h] [rbp+28h]
		
		  for ( i = 0LL; i < 2; ++i )
		    *(&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableLightPixelDebugger + i) = 0;
		  TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight = 0LL;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight,
		    (Type *)i,
		    v1,
		    v2,
		    v17);
		  static_fields = TypeInfo::UnityEngine::Vector3->static_fields;
		  z_low = (PropertyInfo_1 *)LODWORD(static_fields->negativeInfinityVector.z);
		  v6 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		  *(_QWORD *)&v6->selectedDebugLightWorldPoint.x = *(_QWORD *)&static_fields->negativeInfinityVector.x;
		  LODWORD(v6->selectedDebugLightWorldPoint.z) = (_DWORD)z_low;
		  TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPointValid = (char)v7;
		  TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial = v7;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial,
		    (Type *)v6,
		    z_low,
		    v8,
		    v18);
		  v9 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		  TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelSelectionMode = (char)v10;
		  TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo = v10;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo,
		    v11,
		    v12,
		    v9,
		    v19);
		  v13 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::RaycastHit, 32LL);
		  v14 = (Type *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		  v14[2].monitor = (MonitorData *)v13;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_raycastResults,
		    v14,
		    v15,
		    v16,
		    v20);
		}
		
	
		// Methods
		private static void DrawScreenSpaceDot(Camera cam, Vector3 worldPos, float sizePx, UnityEngine.Color color) {} // 0x0000000189B77C38-0x0000000189B77E1C
		// Void DrawScreenSpaceDot(Camera, Vector3, Single, Color)
		void HG::Rendering::Runtime::HGDebugRenderManager::DrawScreenSpaceDot(
		        Camera *cam,
		        Vector3 *worldPos,
		        float sizePx,
		        Color *color,
		        MethodInfo *method)
		{
		  __int64 v8; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 *v11; // rax
		  bool v12; // cf
		  float pixelWidth; // xmm6_4
		  int32_t pixelHeight; // eax
		  float v15; // xmm9_4
		  float v16; // xmm8_4
		  float v17; // xmm7_4
		  float v18; // xmm6_4
		  Color v19; // xmm0
		  __int64 v20; // xmm1_8
		  Vector3 v21; // [rsp+38h] [rbp-31h] BYREF
		  Color v22[7]; // [rsp+48h] [rbp-21h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2847, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2847, 0LL);
		    if ( Patch )
		    {
		      v19 = *color;
		      v20 = *(_QWORD *)&worldPos->x;
		      v21.z = worldPos->z;
		      v22[0] = v19;
		      *(_QWORD *)&v21.x = v20;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1038(Patch, (Object *)cam, &v21, sizePx, v22, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(Patch, v8);
		  }
		  if ( !cam )
		    goto LABEL_6;
		  z = worldPos->z;
		  *(_QWORD *)&v21.x = *(_QWORD *)&worldPos->x;
		  v21.z = z;
		  v11 = UnityEngine::Camera::WorldToScreenPoint((Vector3 *)v22, cam, &v21, 0LL);
		  v12 = v11->z > 0.0;
		  *(_QWORD *)&v21.x = *(_QWORD *)&v11->x;
		  if ( v12 )
		  {
		    pixelWidth = (float)UnityEngine::Camera::get_pixelWidth(cam, 0LL);
		    pixelHeight = UnityEngine::Camera::get_pixelHeight(cam, 0LL);
		    v15 = (float)(v21.x - (float)(sizePx * 0.5)) / pixelWidth;
		    v16 = (float)(v21.x + (float)(sizePx * 0.5)) / pixelWidth;
		    v17 = (float)(v21.y + (float)(sizePx * 0.5)) / (float)pixelHeight;
		    v18 = (float)(v21.y - (float)(sizePx * 0.5)) / (float)pixelHeight;
		    v22[0] = *color;
		    UnityEngine::GL::Color(v22, 0LL);
		    UnityEngine::GL::Vertex3(v15, v18, 0.0, 0LL);
		    UnityEngine::GL::Vertex3(v16, v18, 0.0, 0LL);
		    UnityEngine::GL::Vertex3(v16, v17, 0.0, 0LL);
		    UnityEngine::GL::Vertex3(v15, v17, 0.0, 0LL);
		  }
		}
		
		private static Vector3 GetIntersectionPt(Camera cam, Vector3 worldA, Vector3 worldB) => default; // 0x0000000189B77E7C-0x0000000189B780F4
		// Vector3 GetIntersectionPt(Camera, Vector3, Vector3)
		Vector3 *HG::Rendering::Runtime::HGDebugRenderManager::GetIntersectionPt(
		        Vector3 *__return_ptr retstr,
		        Camera *cam,
		        Vector3 *worldA,
		        Vector3 *worldB,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v10; // rcx
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  Vector3 *v15; // rax
		  __int64 v16; // xmm7_8
		  float z; // edi
		  Vector3 *v18; // rax
		  __int64 v19; // xmm6_8
		  float v20; // ebx
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  float v23; // xmm4_4
		  __int64 v24; // xmm3_8
		  float v25; // xmm5_4
		  MethodInfo *v26; // r9
		  Vector3 *v27; // rax
		  MethodInfo *v28; // r9
		  Vector3 *v29; // rax
		  __int64 v30; // xmm6_8
		  float v31; // ebx
		  Matrix4x4 *inverse; // rax
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  Vector3 *v36; // rax
		  Vector3 *v37; // rax
		  __int64 v38; // xmm0_8
		  __int64 v39; // xmm0_8
		  float v40; // eax
		  Vector3 v42; // [rsp+38h] [rbp-81h] BYREF
		  Vector3 v43; // [rsp+48h] [rbp-71h] BYREF
		  Vector3 v44; // [rsp+58h] [rbp-61h] BYREF
		  Matrix4x4 v45; // [rsp+68h] [rbp-51h] BYREF
		  Matrix4x4 v46; // [rsp+A8h] [rbp-11h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2848, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2848, 0LL);
		    if ( Patch )
		    {
		      v38 = *(_QWORD *)&worldB->x;
		      v42.z = worldB->z;
		      v43.z = worldA->z;
		      *(_QWORD *)&v42.x = v38;
		      *(_QWORD *)&v43.x = *(_QWORD *)&worldA->x;
		      v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1039(&v44, Patch, (Object *)cam, &v43, &v42, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v10, Patch);
		  }
		  if ( !cam )
		    goto LABEL_5;
		  worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v46, cam, 0LL);
		  v12 = *(_OWORD *)&worldToCameraMatrix->m01;
		  *(_OWORD *)&v45.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		  v13 = *(_OWORD *)&worldToCameraMatrix->m02;
		  *(_OWORD *)&v45.m01 = v12;
		  v14 = *(_OWORD *)&worldToCameraMatrix->m03;
		  *(float *)&worldToCameraMatrix = worldA->z;
		  *(_OWORD *)&v45.m02 = v13;
		  *(_QWORD *)&v43.x = *(_QWORD *)&worldA->x;
		  *(_OWORD *)&v45.m03 = v14;
		  LODWORD(v43.z) = (_DWORD)worldToCameraMatrix;
		  v15 = UnityEngine::Matrix4x4::MultiplyPoint(&v42, &v45, &v43, 0LL);
		  *(_QWORD *)&v43.x = *(_QWORD *)&worldB->x;
		  v16 = *(_QWORD *)&v15->x;
		  z = v15->z;
		  v43.z = worldB->z;
		  v18 = UnityEngine::Matrix4x4::MultiplyPoint(&v42, &v45, &v43, 0LL);
		  v19 = *(_QWORD *)&v18->x;
		  v20 = v18->z;
		  UnityEngine::Camera::get_nearClipPlane(cam, 0LL);
		  *(_QWORD *)&v43.x = v16;
		  v43.z = z;
		  *(_QWORD *)&v42.x = v19;
		  v42.z = v20;
		  v22 = UnityEngine::Vector3::op_Subtraction(&v44, &v42, &v43, v21);
		  v24 = *(_QWORD *)&v22->x;
		  *(float *)&v22 = v22->z;
		  *(_QWORD *)&v42.x = v24;
		  LODWORD(v42.z) = (_DWORD)v22;
		  v27 = UnityEngine::Vector3::op_Multiply(&v44, v25 / (float)(v20 - v23), &v42, v26);
		  *(_QWORD *)&v43.x = v16;
		  v43.z = z;
		  *(_QWORD *)&v14 = *(_QWORD *)&v27->x;
		  *(float *)&v27 = v27->z;
		  *(_QWORD *)&v42.x = v14;
		  LODWORD(v42.z) = (_DWORD)v27;
		  v29 = UnityEngine::Vector3::op_Addition(&v44, &v43, &v42, v28);
		  v30 = *(_QWORD *)&v29->x;
		  v31 = v29->z;
		  inverse = UnityEngine::Matrix4x4::get_inverse(&v46, &v45, 0LL);
		  v33 = *(_OWORD *)&inverse->m01;
		  *(_OWORD *)&v45.m00 = *(_OWORD *)&inverse->m00;
		  v34 = *(_OWORD *)&inverse->m02;
		  *(_OWORD *)&v45.m01 = v33;
		  v35 = *(_OWORD *)&inverse->m03;
		  *(_OWORD *)&v45.m02 = v34;
		  *(_OWORD *)&v45.m03 = v35;
		  *(_QWORD *)&v42.x = v30;
		  v42.z = v31;
		  v36 = UnityEngine::Matrix4x4::MultiplyPoint(&v44, &v45, &v42, 0LL);
		  *(_QWORD *)&v34 = *(_QWORD *)&v36->x;
		  *(float *)&v36 = v36->z;
		  *(_QWORD *)&v42.x = v34;
		  LODWORD(v42.z) = (_DWORD)v36;
		  v37 = UnityEngine::Camera::WorldToScreenPoint(&v44, cam, &v42, 0LL);
		LABEL_7:
		  v39 = *(_QWORD *)&v37->x;
		  v40 = v37->z;
		  *(_QWORD *)&retstr->x = v39;
		  retstr->z = v40;
		  return retstr;
		}
		
		private static void DrawLineSegment(Camera cam, Vector3 worldA, Vector3 worldB, float widthPx, UnityEngine.Color color) {} // 0x0000000189B777C0-0x0000000189B77C38
		// Void DrawLineSegment(Camera, Vector3, Vector3, Single, Color)
		void HG::Rendering::Runtime::HGDebugRenderManager::DrawLineSegment(
		        Camera *cam,
		        Vector3 *worldA,
		        Vector3 *worldB,
		        float widthPx,
		        Color *color,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 *v12; // rax
		  __int64 v13; // xmm0_8
		  float v14; // ebx
		  Vector3 *v15; // rax
		  __m128 x_low; // xmm7
		  __m128 y_low; // xmm10
		  float v18; // xmm6_4
		  __m128 v19; // xmm11
		  __m128 v20; // xmm12
		  float v21; // eax
		  __int64 v22; // xmm0_8
		  float v23; // eax
		  Vector3 *IntersectionPt; // rax
		  __int64 v25; // xmm0_8
		  MethodInfo *v26; // rdx
		  float v27; // eax
		  __int64 v28; // xmm0_8
		  float v29; // eax
		  Vector3 *v30; // rax
		  __int64 v31; // xmm0_8
		  MethodInfo *v32; // rdx
		  __m128 v33; // xmm6
		  Vector2 v34; // xmm7_8
		  __int64 v35; // rax
		  Vector2 v36; // rdx
		  Vector2 v37; // r8
		  int32_t v38; // r9d
		  Vector2 v39; // xmm3_8
		  Vector2 v40; // r8
		  Vector2 v41; // r9
		  Vector2 v42; // r8
		  Vector2 v43; // r9
		  __m128 v44; // xmm6
		  __m128 v45; // xmm1
		  int32_t pixelWidth; // eax
		  __m128 v47; // xmm6
		  int32_t pixelHeight; // eax
		  __m128 v49; // xmm1
		  int32_t v50; // eax
		  __m128 v51; // xmm6
		  int32_t v52; // eax
		  __m128 v53; // xmm1
		  int32_t v54; // eax
		  __m128 v55; // xmm6
		  int32_t v56; // eax
		  __m128 v57; // xmm1
		  Color v58; // xmm0
		  Vector3 v59; // [rsp+48h] [rbp-79h] BYREF
		  Vector3 v60; // [rsp+58h] [rbp-69h] BYREF
		  Vector3 v61; // [rsp+68h] [rbp-59h] BYREF
		  Vector4 v62; // [rsp+78h] [rbp-49h] BYREF
		  Color v63[8]; // [rsp+88h] [rbp-39h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2849, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2849, 0LL);
		    if ( Patch )
		    {
		      *(_QWORD *)&v62.x = *(_QWORD *)&worldB->x;
		      v58 = *color;
		      v62.z = worldB->z;
		      v61.z = worldA->z;
		      v63[0] = v58;
		      *(_QWORD *)&v61.x = *(_QWORD *)&worldA->x;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1040(Patch, (Object *)cam, &v61, (Vector3 *)&v62, widthPx, v63, 0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(Patch, v9);
		  }
		  if ( !cam )
		    goto LABEL_10;
		  z = worldA->z;
		  *(_QWORD *)&v62.x = *(_QWORD *)&worldA->x;
		  v62.z = z;
		  v12 = UnityEngine::Camera::WorldToScreenPoint(&v60, cam, (Vector3 *)&v62, 0LL);
		  v13 = *(_QWORD *)&v12->x;
		  v14 = v12->z;
		  *(float *)&v12 = worldB->z;
		  *(_QWORD *)&v61.x = v13;
		  *(_QWORD *)&v62.x = *(_QWORD *)&worldB->x;
		  LODWORD(v62.z) = (_DWORD)v12;
		  v15 = UnityEngine::Camera::WorldToScreenPoint(&v60, cam, (Vector3 *)&v62, 0LL);
		  x_low = (__m128)LODWORD(v61.x);
		  y_low = (__m128)LODWORD(v61.y);
		  v18 = v15->z;
		  *(_QWORD *)&v62.x = *(_QWORD *)&v15->x;
		  v19 = (__m128)LODWORD(v62.x);
		  v20 = (__m128)LODWORD(v62.y);
		  if ( v14 <= 0.0 )
		  {
		    if ( v18 <= 0.0 )
		      return;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v21 = worldB->z;
		    *(_QWORD *)&v62.x = *(_QWORD *)&worldB->x;
		    v22 = *(_QWORD *)&worldA->x;
		    v62.z = v21;
		    v23 = worldA->z;
		    *(_QWORD *)&v61.x = v22;
		    v61.z = v23;
		    IntersectionPt = HG::Rendering::Runtime::HGDebugRenderManager::GetIntersectionPt(
		                       &v60,
		                       cam,
		                       &v61,
		                       (Vector3 *)&v62,
		                       0LL);
		    v25 = *(_QWORD *)&IntersectionPt->x;
		    *(float *)&IntersectionPt = IntersectionPt->z;
		    *(_QWORD *)&v62.x = v25;
		    LODWORD(v62.z) = (_DWORD)IntersectionPt;
		    *(Vector2 *)&v59.x = UnityEngine::Vector4::op_Implicit(&v62, v26);
		    x_low = (__m128)LODWORD(v59.x);
		    y_low = (__m128)LODWORD(v59.y);
		  }
		  if ( v18 <= 0.0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v27 = worldB->z;
		    *(_QWORD *)&v62.x = *(_QWORD *)&worldB->x;
		    v28 = *(_QWORD *)&worldA->x;
		    v62.z = v27;
		    v29 = worldA->z;
		    *(_QWORD *)&v61.x = v28;
		    v61.z = v29;
		    v30 = HG::Rendering::Runtime::HGDebugRenderManager::GetIntersectionPt(&v60, cam, &v61, (Vector3 *)&v62, 0LL);
		    v31 = *(_QWORD *)&v30->x;
		    *(float *)&v30 = v30->z;
		    *(_QWORD *)&v62.x = v31;
		    LODWORD(v62.z) = (_DWORD)v30;
		    *(Vector2 *)&v59.x = UnityEngine::Vector4::op_Implicit(&v62, v32);
		    v19 = (__m128)LODWORD(v59.x);
		    v20 = (__m128)LODWORD(v59.y);
		  }
		  v33 = x_low;
		  v34 = (Vector2)_mm_unpacklo_ps(v19, v20).m128_u64[0];
		  v33.m128_u64[0] = _mm_unpacklo_ps(v33, y_low).m128_u64[0];
		  *(_QWORD *)&v62.x = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(v34, v33.m128_u64[0]);
		  v35 = sub_182FA2990(&v62);
		  v39 = sub_1858CACF0(
		          _mm_unpacklo_ps(_mm_xor_ps((__m128)HIDWORD(v35), (__m128)xmmword_18B9591F0), (__m128)(unsigned int)v35).m128_u64[0],
		          v36,
		          v37,
		          v38);
		  *(Vector2 *)&v59.x = sub_1853DF234(*(Vector2 *)v33.m128_f32, v39, v40, v41);
		  *(_QWORD *)&v60.x = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(v33.m128_u64[0], v39);
		  *(_QWORD *)&v61.x = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(v34, v39);
		  *(Vector2 *)&v62.x = sub_1853DF234(v34, v39, v42, v43);
		  v63[0] = *color;
		  UnityEngine::GL::Color(v63, 0LL);
		  v44 = (__m128)LODWORD(v59.x);
		  v44.m128_f32[0] = v59.x / (float)UnityEngine::Camera::get_pixelWidth(cam, 0LL);
		  v45 = (__m128)LODWORD(v59.y);
		  v59.z = 0.0;
		  v45.m128_f32[0] = v59.y / (float)UnityEngine::Camera::get_pixelHeight(cam, 0LL);
		  *(_QWORD *)&v59.x = _mm_unpacklo_ps(v44, v45).m128_u64[0];
		  UnityEngine::GL::Vertex(&v59, 0LL);
		  pixelWidth = UnityEngine::Camera::get_pixelWidth(cam, 0LL);
		  v47 = (__m128)LODWORD(v60.x);
		  v47.m128_f32[0] = v60.x / (float)pixelWidth;
		  pixelHeight = UnityEngine::Camera::get_pixelHeight(cam, 0LL);
		  v49 = (__m128)LODWORD(v60.y);
		  v60.z = 0.0;
		  v49.m128_f32[0] = v60.y / (float)pixelHeight;
		  *(_QWORD *)&v60.x = _mm_unpacklo_ps(v47, v49).m128_u64[0];
		  UnityEngine::GL::Vertex(&v60, 0LL);
		  v50 = UnityEngine::Camera::get_pixelWidth(cam, 0LL);
		  v51 = (__m128)LODWORD(v61.x);
		  v51.m128_f32[0] = v61.x / (float)v50;
		  v52 = UnityEngine::Camera::get_pixelHeight(cam, 0LL);
		  v53 = (__m128)LODWORD(v61.y);
		  v61.z = 0.0;
		  v53.m128_f32[0] = v61.y / (float)v52;
		  *(_QWORD *)&v61.x = _mm_unpacklo_ps(v51, v53).m128_u64[0];
		  UnityEngine::GL::Vertex(&v61, 0LL);
		  v54 = UnityEngine::Camera::get_pixelWidth(cam, 0LL);
		  v55 = (__m128)LODWORD(v62.x);
		  v55.m128_f32[0] = v62.x / (float)v54;
		  v56 = UnityEngine::Camera::get_pixelHeight(cam, 0LL);
		  v57 = (__m128)LODWORD(v62.y);
		  v62.z = 0.0;
		  v57.m128_f32[0] = v62.y / (float)v56;
		  *(_QWORD *)&v62.x = _mm_unpacklo_ps(v55, v57).m128_u64[0];
		  UnityEngine::GL::Vertex((Vector3 *)&v62, 0LL);
		}
		
		private static Vector2 GUIPosToScreenPos(Camera cam, Vector2 guiPos) => default; // 0x0000000189B77E1C-0x0000000189B77E7C
		// Vector2 GUIPosToScreenPos(Camera, Vector2)
		Vector2 HG::Rendering::Runtime::HGDebugRenderManager::GUIPosToScreenPos(
		        Camera *cam,
		        Vector2 guiPos,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2850, 0LL) )
		    return guiPos;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2850, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1041(Patch, (Object *)cam, guiPos, 0LL);
		}
		
		private static bool HasWallComponent(GameObject go) => default; // 0x0000000189B783FC-0x0000000189B784F4
		// Boolean HasWallComponent(GameObject)
		bool HG::Rendering::Runtime::HGDebugRenderManager::HasWallComponent(GameObject *go, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Object__Array *v5; // rdi
		  int32_t v6; // ebx
		  ShaderSample *v7; // rsi
		  Type *ClassType; // rax
		  String *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2851, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2851, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)go, 0LL);
		LABEL_15:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !go )
		    goto LABEL_15;
		  v5 = UnityEngine::GameObject::GetComponents<System::Object>(
		         go,
		         MethodInfo::UnityEngine::GameObject::GetComponents<UnityEngine::Component>);
		  v6 = 0;
		  if ( !v5 )
		    goto LABEL_15;
		  while ( v6 < v5->max_length.size )
		  {
		    if ( (unsigned int)v6 >= v5->max_length.size )
		      sub_1800D2AB0(v4, v3);
		    v7 = (ShaderSample *)v5->vector[v6];
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)v7, 0LL, 0LL) )
		    {
		      if ( !v7 )
		        goto LABEL_15;
		      ClassType = USD::NET::Unity::ShaderSample::GetClassType(v7, 0LL);
		      if ( !ClassType )
		        goto LABEL_15;
		      v9 = (String *)sub_180032CB0(8LL, ClassType);
		      if ( System::String::Equals(v9, (String *)"BoxColliderWall", 0LL) )
		        return 1;
		    }
		    ++v6;
		  }
		  return 0;
		}
		
		private static bool RaycastIgnoreAirwall(Vector3 p, Vector3 dir, float maxDistance, out Vector3 hitPos) {
			hitPos = default;
			return default;
		} // 0x0000000189B79C6C-0x0000000189B79F40
		// Boolean RaycastIgnoreAirwall(Vector3, Vector3, Single, Vector3 ByRef)
		bool HG::Rendering::Runtime::HGDebugRenderManager::RaycastIgnoreAirwall(
		        Vector3 *p,
		        Vector3 *dir,
		        float maxDistance,
		        Vector3 *hitPos,
		        MethodInfo *method)
		{
		  HGDebugRenderManager__StaticFields *static_fields; // rcx
		  __int64 v9; // xmm0_8
		  RaycastHit__Array *s_raycastResults; // r8
		  float v11; // eax
		  int32_t v12; // esi
		  int32_t v13; // edi
		  __m128i v14; // xmm6
		  float v15; // xmm8_4
		  Animator *v16; // rdx
		  int32_t v17; // r8d
		  MethodInfo *v18; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  RaycastHit__Array *v20; // rax
		  int32_t size; // eax
		  __m128i v22; // xmm10
		  __m128 v23; // xmm7
		  __int128 v24; // xmm11
		  __int128 v25; // xmm12
		  ECSColliderResultProxy *colliderProxy; // rax
		  __int64 v27; // xmm1_8
		  Vector3 *Vector; // rax
		  __int64 v29; // xmm0_8
		  float v30; // ecx
		  bool result; // al
		  float z; // eax
		  void *v33; // xmm0_8
		  float v34; // eax
		  ECSColliderResultProxy v35; // [rsp+40h] [rbp-C8h] BYREF
		  __int64 v36; // [rsp+58h] [rbp-B0h]
		  ECSColliderResultProxy v37; // [rsp+68h] [rbp-A0h] BYREF
		  RaycastHit v38; // [rsp+88h] [rbp-80h] BYREF
		  RaycastHit v39; // [rsp+C8h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2852, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2852, 0LL);
		    if ( !Patch )
		LABEL_17:
		      sub_1800D8260(Patch, v16);
		    z = dir->z;
		    *(_QWORD *)&v35.m_EcsId = *(_QWORD *)&dir->x;
		    v33 = *(void **)&p->x;
		    *(float *)&v35.m_Collider = z;
		    v34 = p->z;
		    v37.m_Actor = v33;
		    *(float *)&v37.m_EcsId = v34;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1042(
		             Patch,
		             (Vector3 *)&v37,
		             (Vector3 *)&v35.m_EcsId,
		             maxDistance,
		             hitPos,
		             0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v37.m_Actor = *(void **)&dir->x;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		    v9 = *(_QWORD *)&p->x;
		    v37.m_EcsId = LODWORD(dir->z);
		    s_raycastResults = static_fields->s_raycastResults;
		    v11 = p->z;
		    *(_QWORD *)&v35.m_EcsId = v9;
		    *(float *)&v35.m_Collider = v11;
		    v12 = UnityEngine::Physics::RaycastNonAlloc(
		            (Vector3 *)&v35.m_EcsId,
		            (Vector3 *)&v37,
		            s_raycastResults,
		            maxDistance,
		            -5,
		            QueryTriggerInteraction__Enum_Ignore,
		            0LL);
		    sub_18033B9D0(&v38, 0LL, 64LL);
		    v13 = 0;
		    v14 = *(__m128i *)&v38.m_Point.x;
		    v38.m_Distance = 3.4028235e38;
		    *(_OWORD *)&v39.m_Normal.y = *(_OWORD *)&v38.m_Normal.y;
		    v15 = 3.4028235e38;
		    *(_OWORD *)&v39.m_EcsId = *(_OWORD *)&v38.m_EcsId;
		    *(_OWORD *)&v39.m_UV.x = *(_OWORD *)&v38.m_UV.x;
		    while ( 1 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		      v20 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_raycastResults;
		      if ( !v20 )
		        goto LABEL_17;
		      size = v20->max_length.size;
		      if ( v12 < size )
		        size = v12;
		      if ( v13 >= size )
		        break;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_raycastResults;
		      if ( !Patch )
		        goto LABEL_17;
		      sub_180031960(Patch, &v39, v13);
		      v22 = *(__m128i *)&v39.m_Point.x;
		      v23 = *(__m128 *)&v39.m_Normal.y;
		      v24 = *(_OWORD *)&v39.m_UV.x;
		      v25 = *(_OWORD *)&v39.m_EcsId;
		      v38 = v39;
		      if ( !UnityEngine::RaycastHit::get_IsECSCollider(&v38, 0LL)
		        || (colliderProxy = UnityEngine::RaycastHit::get_colliderProxy(&v37, &v38, 0LL),
		            v27 = *(_QWORD *)&colliderProxy->m_Collider,
		            *(_OWORD *)&v35.m_EcsId = *(_OWORD *)&colliderProxy->m_Actor,
		            v36 = v27,
		            sub_1800036A0(TypeInfo::UnityEngine::ECSColliderResultProxy),
		            (UnityEngine::ECSColliderResultProxy::get_colliderOptions((ECSColliderResultProxy *)&v35.m_EcsId, 0LL) & 0x80808) == 0) )
		      {
		        if ( v15 > _mm_shuffle_ps(v23, v23, 255).m128_f32[0] )
		        {
		          *(_OWORD *)&v39.m_UV.x = v24;
		          LODWORD(v15) = _mm_shuffle_ps(v23, v23, 255).m128_u32[0];
		          v14 = v22;
		          *(_OWORD *)&v39.m_EcsId = v25;
		        }
		      }
		      ++v13;
		    }
		    if ( maxDistance > v15 )
		    {
		      *(_QWORD *)&hitPos->x = v14.m128i_i64[0];
		      result = 1;
		      LODWORD(hitPos->z) = _mm_cvtsi128_si32(_mm_srli_si128(v14, 8));
		    }
		    else
		    {
		      Vector = UnityEngine::Animator::GetVector((Vector3 *)&v35.m_EcsId, v16, v17, v18);
		      v29 = *(_QWORD *)&Vector->x;
		      v30 = Vector->z;
		      result = 0;
		      *(_QWORD *)&hitPos->x = v29;
		      hitPos->z = v30;
		    }
		  }
		  return result;
		}
		
		private static bool IsPointInLightShape(Light l, Vector3 point) => default; // 0x0000000189B784F4-0x0000000189B7876C
		// Boolean IsPointInLightShape(Light, Vector3)
		bool HG::Rendering::Runtime::HGDebugRenderManager::IsPointInLightShape(Light *l, Vector3 *point, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Vector3 *cullingBoxRelativePosition; // rax
		  float v8; // ebx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v11; // xmm0_8
		  MethodInfo *v12; // r9
		  Vector3 *v13; // rax
		  float v14; // esi
		  Vector3 *cullingBoxHalfExtents; // rax
		  float v16; // edi
		  Vector3 *cullingBoxOrientation; // rax
		  float v18; // ebx
		  float v19; // eax
		  LightType__Enum type; // eax
		  float v21; // eax
		  float v23; // eax
		  float z; // eax
		  Vector3 v25; // [rsp+30h] [rbp-40h] BYREF
		  Vector3 v26; // [rsp+40h] [rbp-30h] BYREF
		  Vector3 v27; // [rsp+50h] [rbp-20h] BYREF
		  Vector3 v28; // [rsp+60h] [rbp-10h] BYREF
		  __int64 v29; // [rsp+A8h] [rbp+38h]
		  __int64 v30; // [rsp+A8h] [rbp+38h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2853, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2853, 0LL);
		    if ( Patch )
		    {
		      z = point->z;
		      *(_QWORD *)&v28.x = *(_QWORD *)&point->x;
		      v28.z = z;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)l, &v28, 0LL);
		    }
		    goto LABEL_15;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality((Object_1 *)l, 0LL, 0LL) )
		    return 0;
		  if ( !l )
		LABEL_15:
		    sub_1800D8260(Patch, v5);
		  if ( !UnityEngine::Behaviour::get_enabled((Behaviour *)l, 0LL) )
		    return 0;
		  if ( UnityEngine::Light::get_enableOBBCullingBox(l, 0LL) )
		  {
		    cullingBoxRelativePosition = UnityEngine::Light::get_cullingBoxRelativePosition(&v28, l, 0LL);
		    v8 = cullingBoxRelativePosition->z;
		    v29 = *(_QWORD *)&cullingBoxRelativePosition->x;
		    transform = UnityEngine::Component::get_transform((Component *)l, 0LL);
		    if ( transform )
		    {
		      position = UnityEngine::Transform::get_position(&v28, transform, 0LL);
		      v25.z = v8;
		      v11 = *(_QWORD *)&position->x;
		      *(float *)&position = position->z;
		      *(_QWORD *)&v26.x = v11;
		      *(_QWORD *)&v25.x = v29;
		      LODWORD(v26.z) = (_DWORD)position;
		      v13 = UnityEngine::Vector3::op_Addition(&v28, &v25, &v26, v12);
		      v14 = v13->z;
		      *(_QWORD *)&v26.x = *(_QWORD *)&v13->x;
		      cullingBoxHalfExtents = UnityEngine::Light::get_cullingBoxHalfExtents(&v28, l, 0LL);
		      v16 = cullingBoxHalfExtents->z;
		      *(_QWORD *)&v25.x = *(_QWORD *)&cullingBoxHalfExtents->x;
		      cullingBoxOrientation = UnityEngine::Light::get_cullingBoxOrientation(&v28, l, 0LL);
		      v18 = cullingBoxOrientation->z;
		      v30 = *(_QWORD *)&cullingBoxOrientation->x;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      v19 = point->z;
		      *(_QWORD *)&v27.x = *(_QWORD *)&point->x;
		      *(_QWORD *)&v28.x = v30;
		      v27.z = v19;
		      v28.z = v18;
		      v25.z = v16;
		      v26.z = v14;
		      if ( HG::Rendering::Runtime::HGDebugRenderManager::IsPointInOBB(&v26, &v25, &v28, &v27, 0LL) )
		        goto LABEL_8;
		      return 0;
		    }
		    goto LABEL_15;
		  }
		LABEL_8:
		  type = UnityEngine::Light::get_type(l, 0LL);
		  if ( type == LightType__Enum_Spot )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v21 = point->z;
		    *(_QWORD *)&v28.x = *(_QWORD *)&point->x;
		    v28.z = v21;
		    return HG::Rendering::Runtime::HGDebugRenderManager::IsPointInSpotLight(l, &v28, 0LL);
		  }
		  if ( type != LightType__Enum_Point )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::LogWarning((Object *)"Unexpected Light Type", 0LL);
		    return 0;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		  v23 = point->z;
		  *(_QWORD *)&v28.x = *(_QWORD *)&point->x;
		  v28.z = v23;
		  return HG::Rendering::Runtime::HGDebugRenderManager::IsPointInPointLight(l, &v28, 0LL);
		}
		
		private static bool IsPointInOBB(Vector3 obbPos, Vector3 obbHalfExtents, Vector3 obbEulerAngles, Vector3 point) => default; // 0x0000000189B7876C-0x0000000189B78920
		// Boolean IsPointInOBB(Vector3, Vector3, Vector3, Vector3)
		bool HG::Rendering::Runtime::HGDebugRenderManager::IsPointInOBB(
		        Vector3 *obbPos,
		        Vector3 *obbHalfExtents,
		        Vector3 *obbEulerAngles,
		        Vector3 *point,
		        MethodInfo *method)
		{
		  __int64 v9; // r8
		  __int64 v10; // r9
		  float v11; // eax
		  MethodInfo *v12; // rax
		  __int64 v13; // xmm0_8
		  float v14; // ecx
		  __int64 v15; // xmm0_8
		  Vector3 *v16; // rax
		  Quaternion *v17; // r9
		  Quaternion v18; // xmm0
		  __int64 v19; // xmm3_8
		  Vector3 *v20; // rax
		  __int32 v21; // xmm2_4
		  __int64 v23; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v25; // xmm0_8
		  float z; // eax
		  __int64 v27; // xmm0_8
		  float v28; // eax
		  __int64 v29; // xmm0_8
		  float v30; // eax
		  __int64 v31; // xmm0_8
		  Vector3 v32; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 v33; // [rsp+40h] [rbp-40h] BYREF
		  Quaternion v34; // [rsp+50h] [rbp-30h] BYREF
		  Vector3 v35; // [rsp+60h] [rbp-20h] BYREF
		  Quaternion v36; // [rsp+70h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2854, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2854, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v23);
		    v25 = *(_QWORD *)&point->x;
		    v33.z = point->z;
		    z = obbEulerAngles->z;
		    *(_QWORD *)&v33.x = v25;
		    v27 = *(_QWORD *)&obbEulerAngles->x;
		    v32.z = z;
		    v28 = obbHalfExtents->z;
		    *(_QWORD *)&v32.x = v27;
		    v29 = *(_QWORD *)&obbHalfExtents->x;
		    v34.z = v28;
		    v30 = obbPos->z;
		    *(_QWORD *)&v34.x = v29;
		    v31 = *(_QWORD *)&obbPos->x;
		    v35.z = v30;
		    *(_QWORD *)&v35.x = v31;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_164(Patch, &v35, (Vector3 *)&v34, &v32, &v33, 0LL);
		  }
		  else
		  {
		    v11 = obbEulerAngles->z;
		    *(_QWORD *)&v32.x = *(_QWORD *)&obbEulerAngles->x;
		    v32.z = v11;
		    v34 = *(Quaternion *)sub_182FA5910(&v35, &v32, v9, v10);
		    v12 = (MethodInfo *)UnityEngine::Quaternion::Inverse(&v36, &v34, 0LL);
		    v13 = *(_QWORD *)&obbPos->x;
		    v32.z = obbPos->z;
		    v14 = point->z;
		    *(_QWORD *)&v32.x = v13;
		    v15 = *(_QWORD *)&point->x;
		    v33.z = v14;
		    *(_QWORD *)&v33.x = v15;
		    v16 = UnityEngine::Vector3::op_Subtraction(&v35, &v33, &v32, v12);
		    v18 = *v17;
		    v19 = *(_QWORD *)&v16->x;
		    *(float *)&v16 = v16->z;
		    *(_QWORD *)&v33.x = v19;
		    LODWORD(v33.z) = (_DWORD)v16;
		    v34 = v18;
		    v20 = UnityEngine::Quaternion::op_Multiply(&v35, &v34, &v33, 0LL);
		    COERCE_FLOAT(v21 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		    *(_QWORD *)&v33.x = *(_QWORD *)&v20->x;
		    return obbHalfExtents->x >= COERCE_FLOAT(LODWORD(v33.x) & v21)
		        && obbHalfExtents->y >= COERCE_FLOAT(LODWORD(v33.y) & v21)
		        && obbHalfExtents->z >= COERCE_FLOAT(LODWORD(v20->z) & v21);
		  }
		}
		
		private static bool IsPointInPointLight(Light l, Vector3 point) => default; // 0x0000000189B78920-0x0000000189B78A44
		// Boolean IsPointInPointLight(Light, Vector3)
		bool HG::Rendering::Runtime::HGDebugRenderManager::IsPointInPointLight(Light *l, Vector3 *point, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v9; // xmm0_8
		  __int64 v10; // xmm0_8
		  MethodInfo *v11; // r9
		  Vector3 *v12; // rax
		  __int64 v13; // xmm3_8
		  float range; // xmm7_4
		  MethodInfo *v15; // rdx
		  float sqrMagnitude; // xmm6_4
		  float z; // eax
		  Vector3 v19; // [rsp+20h] [rbp-50h] BYREF
		  Vector3 v20; // [rsp+30h] [rbp-40h] BYREF
		  Vector3 v21; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2855, 0LL) )
		  {
		    if ( l )
		    {
		      transform = UnityEngine::Component::get_transform((Component *)l, 0LL);
		      if ( transform )
		      {
		        position = UnityEngine::Transform::get_position(&v20, transform, 0LL);
		        v9 = *(_QWORD *)&position->x;
		        *(float *)&position = position->z;
		        *(_QWORD *)&v19.x = v9;
		        v10 = *(_QWORD *)&point->x;
		        LODWORD(v19.z) = (_DWORD)position;
		        *(float *)&position = point->z;
		        *(_QWORD *)&v20.x = v10;
		        LODWORD(v20.z) = (_DWORD)position;
		        v12 = UnityEngine::Vector3::op_Subtraction(&v21, &v20, &v19, v11);
		        v13 = *(_QWORD *)&v12->x;
		        *(float *)&v12 = v12->z;
		        *(_QWORD *)&v20.x = v13;
		        LODWORD(v20.z) = (_DWORD)v12;
		        range = UnityEngine::Light::get_range(l, 0LL);
		        sqrMagnitude = UnityEngine::Vector3::get_sqrMagnitude(&v20, v15);
		        return (float)(UnityEngine::Light::get_range(l, 0LL) * range) >= sqrMagnitude;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(Patch, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2855, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  z = point->z;
		  *(_QWORD *)&v20.x = *(_QWORD *)&point->x;
		  v20.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)l, &v20, 0LL);
		}
		
		private static bool IsPointInSpotLight(Light l, Vector3 point) => default; // 0x0000000189B78A44-0x0000000189B78BD0
		// Boolean IsPointInSpotLight(Light, Vector3)
		bool HG::Rendering::Runtime::HGDebugRenderManager::IsPointInSpotLight(Light *l, Vector3 *point, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Transform *transform; // rax
		  Transform *v8; // rsi
		  Vector3 *position; // rax
		  __int64 v10; // xmm0_8
		  float v11; // ecx
		  __int64 v12; // xmm0_8
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  float v15; // ebx
		  __int64 v16; // xmm3_8
		  Vector3 *forward; // rax
		  __int64 v18; // xmm0_8
		  MethodInfo *v19; // r8
		  float v20; // xmm6_4
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // r8
		  __int64 v24; // r9
		  float v25; // xmm3_4
		  MethodInfo *v26; // rdx
		  float z; // eax
		  Vector3 v29; // [rsp+20h] [rbp-50h] BYREF
		  Vector3 v30; // [rsp+30h] [rbp-40h] BYREF
		  Vector3 v31; // [rsp+40h] [rbp-30h] BYREF
		  Vector3 v32; // [rsp+50h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2856, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2856, 0LL);
		    if ( Patch )
		    {
		      z = point->z;
		      *(_QWORD *)&v31.x = *(_QWORD *)&point->x;
		      v31.z = z;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)l, &v31, 0LL);
		    }
		LABEL_9:
		    sub_1800D8260(Patch, v5);
		  }
		  if ( !l )
		    goto LABEL_9;
		  transform = UnityEngine::Component::get_transform((Component *)l, 0LL);
		  v8 = transform;
		  if ( !transform )
		    goto LABEL_9;
		  position = UnityEngine::Transform::get_position(&v31, transform, 0LL);
		  v10 = *(_QWORD *)&position->x;
		  v11 = position->z;
		  *(float *)&position = point->z;
		  *(_QWORD *)&v29.x = v10;
		  v12 = *(_QWORD *)&point->x;
		  v29.z = v11;
		  *(_QWORD *)&v30.x = v12;
		  LODWORD(v30.z) = (_DWORD)position;
		  v14 = UnityEngine::Vector3::op_Subtraction(&v32, &v30, &v29, v13);
		  v16 = *(_QWORD *)&v14->x;
		  v31.z = v14->z;
		  v15 = v31.z;
		  *(_QWORD *)&v31.x = v16;
		  forward = UnityEngine::Transform::get_forward(&v32, v8, 0LL);
		  *(_QWORD *)&v29.x = v16;
		  v29.z = v15;
		  v18 = *(_QWORD *)&forward->x;
		  *(float *)&forward = forward->z;
		  *(_QWORD *)&v30.x = v18;
		  LODWORD(v30.z) = (_DWORD)forward;
		  v20 = UnityEngine::Vector3::Dot(&v29, &v30, v19);
		  if ( v20 <= 0.0 || v20 > UnityEngine::Light::get_range(l, 0LL) )
		    return 0;
		  UnityEngine::Light::get_spotAngle(l, 0LL);
		  v25 = sub_180338A80(v22, v21, v23, v24) * v20;
		  return (float)(v25 * v25) >= (float)(UnityEngine::Vector3::get_sqrMagnitude(&v31, v26) - (float)(v20 * v20));
		}
		
		private static LightPixelDebugInfo GetLightPixelDebugInfo(Vector3 targetPosition) => default; // 0x0000000189B780F4-0x0000000189B783FC
		// HGDebugRenderManager+LightPixelDebugInfo GetLightPixelDebugInfo(Vector3)
		HGDebugRenderManager_LightPixelDebugInfo *HG::Rendering::Runtime::HGDebugRenderManager::GetLightPixelDebugInfo(
		        Vector3 *targetPosition,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_System_Object_ *Patch; // rcx
		  __int64 v5; // rdi
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v9; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rbx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  Object__Array *v14; // r14
		  int32_t v15; // esi
		  Component *v16; // rbx
		  Transform *transform; // rax
		  __int64 v18; // xmm0_8
		  Vector3 *position; // rax
		  __int64 v20; // xmm0_8
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  __int64 v23; // xmm3_8
		  double v24; // xmm0_8
		  float v25; // xmm6_4
		  float z; // eax
		  List_1_System_Object_ *v27; // rsi
		  Comparison_1_UnityEngine_Light_ *_9__23_0; // rbx
		  Object *v29; // r14
		  Comparison_1_Object_ *v30; // rax
		  PropertyInfo_1 *static_fields; // r8
		  Type *v32; // rdx
		  Int32__Array **v33; // r9
		  float v35; // eax
		  Vector3 v36; // [rsp+28h] [rbp-29h] BYREF
		  Vector3 v37; // [rsp+38h] [rbp-19h] BYREF
		  __int64 v38; // [rsp+48h] [rbp-9h] BYREF
		  int v39; // [rsp+50h] [rbp-1h]
		  Vector3 v40; // [rsp+58h] [rbp+7h] BYREF
		  Vector3 v41; // [rsp+68h] [rbp+17h] BYREF
		  Vector3 v42[2]; // [rsp+78h] [rbp+27h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2857, 0LL) )
		  {
		    v5 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::LightPixelDebugInfo);
		    if ( v5 )
		    {
		      *(_QWORD *)(v5 + 16) = UnityEngine::Light::GetSunSourceLight(0LL);
		      sub_18002D1B0((SingleFieldAccessor *)(v5 + 16), v6, v7, v8, *(MethodInfo **)&v36.x);
		      v9 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Light>);
		      v10 = v9;
		      if ( v9 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v9,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::List);
		        *(_QWORD *)(v5 + 24) = v10;
		        sub_18002D1B0((SingleFieldAccessor *)(v5 + 24), v11, v12, v13, *(MethodInfo **)&v36.x);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        v14 = UnityEngine::Object::FindObjectsOfType<System::Object>(MethodInfo::UnityEngine::Object::FindObjectsOfType<UnityEngine::Light>);
		        v15 = 0;
		        if ( v14 )
		        {
		          while ( v15 < v14->max_length.size )
		          {
		            if ( (unsigned int)v15 >= v14->max_length.size )
		              sub_1800D2AB0(Patch, v3);
		            v16 = (Component *)v14->vector[v15];
		            if ( !v16 )
		              goto LABEL_26;
		            if ( UnityEngine::Light::get_type((Light *)v14->vector[v15], 0LL) == LightType__Enum_Spot
		              || UnityEngine::Light::get_type((Light *)v16, 0LL) == LightType__Enum_Point )
		            {
		              transform = UnityEngine::Component::get_transform(v16, 0LL);
		              if ( !transform )
		                goto LABEL_26;
		              v18 = *(_QWORD *)&targetPosition->x;
		              v36.z = targetPosition->z;
		              *(_QWORD *)&v36.x = v18;
		              position = UnityEngine::Transform::get_position(&v41, transform, 0LL);
		              v20 = *(_QWORD *)&position->x;
		              *(float *)&position = position->z;
		              *(_QWORD *)&v37.x = v20;
		              LODWORD(v37.z) = (_DWORD)position;
		              v22 = UnityEngine::Vector3::op_Subtraction(v42, &v37, &v36, v21);
		              v23 = *(_QWORD *)&v22->x;
		              *(float *)&v22 = v22->z;
		              v38 = v23;
		              v39 = (int)v22;
		              v24 = sub_182FAE390(&v38);
		              v25 = *(float *)&v24;
		              if ( (!UnityEngine::Light::get_useCullingDistance((Light *)v16, 0LL)
		                 || *(float *)&v24 <= UnityEngine::Light::get_cullingDistance((Light *)v16, 0LL))
		                && (!UnityEngine::Light::get_useFarDistanceShow((Light *)v16, 0LL)
		                 || UnityEngine::Light::get_farDistanceShowDistance((Light *)v16, 0LL) <= v25) )
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                z = targetPosition->z;
		                *(_QWORD *)&v40.x = *(_QWORD *)&targetPosition->x;
		                v40.z = z;
		                if ( HG::Rendering::Runtime::HGDebugRenderManager::IsPointInLightShape((Light *)v16, &v40, 0LL) )
		                {
		                  Patch = *(List_1_System_Object_ **)(v5 + 24);
		                  if ( !Patch )
		                    goto LABEL_26;
		                  sub_182F01190(Patch, (Object *)v16);
		                }
		              }
		            }
		            ++v15;
		          }
		          v27 = *(List_1_System_Object_ **)(v5 + 24);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c);
		          Patch = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c;
		          _9__23_0 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c->static_fields->__9__23_0;
		          if ( !_9__23_0 )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c);
		            v29 = (Object *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c->static_fields->__9;
		            v30 = (Comparison_1_Object_ *)sub_18002C620(TypeInfo::System::Comparison<UnityEngine::Light>);
		            _9__23_0 = (Comparison_1_UnityEngine_Light_ *)v30;
		            if ( !v30 )
		              goto LABEL_26;
		            System::Comparison<System::Object>::Comparison(
		              v30,
		              v29,
		              MethodInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c::_GetLightPixelDebugInfo_b__23_0,
		              0LL);
		            static_fields = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c->static_fields;
		            static_fields->monitor = (MonitorData *)_9__23_0;
		            sub_18002D1B0(
		              (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager::__c->static_fields->__9__23_0,
		              v32,
		              static_fields,
		              v33,
		              *(MethodInfo **)&v36.x);
		          }
		          if ( v27 )
		          {
		            System::Collections::Generic::List<System::Object>::Sort(
		              v27,
		              (Comparison_1_Object_ *)_9__23_0,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::Sort);
		            return (HGDebugRenderManager_LightPixelDebugInfo *)v5;
		          }
		        }
		      }
		    }
		LABEL_26:
		    sub_1800D8260(Patch, v3);
		  }
		  Patch = (List_1_System_Object_ *)IFix::WrappersManagerImpl::GetPatch(2857, 0LL);
		  if ( !Patch )
		    goto LABEL_26;
		  v35 = targetPosition->z;
		  *(_QWORD *)&v40.x = *(_QWORD *)&targetPosition->x;
		  v40.z = v35;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1044((ILFixDynamicMethodWrapper_2 *)Patch, &v40, 0LL);
		}
		
		public void DrawLightPixelDebugGUI(Camera camera) {} // 0x0000000189B76934-0x0000000189B777C0
		// Void DrawLightPixelDebugGUI(Camera)
		void HG::Rendering::Runtime::HGDebugRenderManager::DrawLightPixelDebugGUI(
		        HGDebugRenderManager *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  Event *s_Current; // rdi
		  _QWORD *p_image; // rdx
		  Object_1 *static_fields; // rcx
		  Vector2 mousePosition; // xmm6_8
		  Vector2 v9; // rax
		  __int64 v10; // rax
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  Ray *v13; // rax
		  __int64 v14; // xmm0_8
		  Vector3__StaticFields *v15; // rcx
		  __int64 v16; // xmm6_8
		  float z; // ebx
		  HGDebugRenderManager__StaticFields *v18; // rcx
		  HGDebugRenderManager__StaticFields *v19; // rcx
		  float v20; // eax
		  struct HGDebugRenderManager__Class *v21; // rcx
		  HGDebugRenderManager__StaticFields *v22; // rax
		  __int64 v23; // xmm0_8
		  HGDebugRenderManager_LightPixelDebugInfo *LightPixelDebugInfo; // rax
		  HGDebugRenderManager_LightPixelDebugInfo *v25; // rbx
		  Type *v26; // rdx
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  float v29; // xmm9_4
		  float v30; // xmm0_4
		  HGDebugRenderManager__StaticFields *v31; // rax
		  float v32; // r15d
		  __int64 v33; // xmm12_8
		  Object_1 *lineMaterial; // rbx
		  __m128 v35; // xmm13
		  __m128 v36; // xmm14
		  __m128 v37; // xmm15
		  Shader *v38; // rdi
		  Material *v39; // rax
		  MonitorData *v40; // rbx
		  Type *v41; // rdx
		  PropertyInfo_1 *v42; // r8
		  Int32__Array **v43; // r9
		  Material *v44; // rbx
		  int32_t v45; // eax
		  Material *v46; // rbx
		  int32_t v47; // eax
		  __int64 v48; // rdx
		  Material *v49; // rcx
		  int32_t pixelWidth; // eax
		  MethodInfo *v51; // rdx
		  __m128i v52; // xmm6
		  MethodInfo *v53; // rdx
		  Color *red; // rax
		  __m128i v55; // xmm0
		  Object_1 *s_shadowDirectionDebugLight; // rbx
		  Object_1__Class *klass; // rbx
		  Object_1 *name; // rbx
		  HGDebugRenderManager__StaticFields *v59; // rax
		  HGDebugRenderManager_LightPixelDebugInfo *s_lightPixelDebugInfo; // rbx
		  Object_1 *v61; // rdi
		  Object_1 *dirLight; // rbx
		  Transform *transform; // rax
		  Vector3 *forward; // rax
		  __int64 v65; // xmm7_8
		  float v66; // edi
		  MethodInfo *v67; // r9
		  Vector3 *v68; // rax
		  __int64 v69; // xmm3_8
		  MethodInfo *v70; // r9
		  Vector3 *v71; // rax
		  __int64 v72; // xmm6_8
		  float v73; // ebx
		  MethodInfo *v74; // rdx
		  __m128i v75; // xmm6
		  __int64 v76; // xmm0_8
		  float v77; // eax
		  HGDebugRenderManager__StaticFields *v78; // rax
		  Transform *v79; // rax
		  Vector3 *position; // rax
		  __int64 v81; // xmm8_8
		  float v82; // edi
		  MethodInfo *v83; // r9
		  Vector3 *v84; // rax
		  __int64 v85; // xmm3_8
		  __int64 v86; // rax
		  __int64 v87; // xmm7_8
		  float v88; // ebx
		  MethodInfo *v89; // r9
		  Vector3 *v90; // rax
		  __int64 v91; // xmm3_8
		  double v92; // xmm0_8
		  MethodInfo *v93; // rdx
		  Color *cyan; // rax
		  MethodInfo *v95; // rdx
		  Color *yellow; // rax
		  __int64 v97; // rdx
		  __m128i v98; // xmm6
		  float scaledPixelWidth; // xmm7_4
		  float scaledPixelHeight; // xmm6_4
		  __m128i v101; // xmm8
		  UnityAction_1_System_Int32Enum_ *v102; // rax
		  GUI_WindowFunction *v103; // rbx
		  float m_XMin; // xmm0_4
		  float m_YMin; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v107; // [rsp+20h] [rbp-E0h]
		  Ray v108; // [rsp+30h] [rbp-D0h] BYREF
		  Rect pixelRect; // [rsp+50h] [rbp-B0h] BYREF
		  _BYTE v110[24]; // [rsp+60h] [rbp-A0h] BYREF
		  Vector3 v111; // [rsp+80h] [rbp-80h] BYREF
		  float v112; // [rsp+90h] [rbp-70h]
		  float v113; // [rsp+94h] [rbp-6Ch]
		  __m128i v114; // [rsp+98h] [rbp-68h] BYREF
		  Vector3 v115[15]; // [rsp+A8h] [rbp-58h] BYREF
		
		  v114.m128i_i64[0] = 0LL;
		  v114.m128i_i32[2] = 0;
		  *(_QWORD *)&v111.x = 0LL;
		  v111.z = 0.0;
		  *(_QWORD *)&v115[0].x = 0LL;
		  v115[0].z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2861, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2861, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        0LL);
		      return;
		    }
		    goto LABEL_75;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableLightPixelDebugger )
		    return;
		  s_Current = TypeInfo::UnityEngine::Event->static_fields->s_Current;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		  static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		  if ( !LOBYTE(static_fields[1].fields.m_CachedPtr) )
		    goto LABEL_12;
		  if ( !s_Current )
		    goto LABEL_75;
		  mousePosition = UnityEngine::Event::get_mousePosition(s_Current, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		  v9 = HG::Rendering::Runtime::HGDebugRenderManager::GUIPosToScreenPos(camera, mousePosition, 0LL);
		  v10 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_186351688)(&v108, v9);
		  if ( !camera )
		    goto LABEL_75;
		  v11 = *(_QWORD *)v10;
		  v12 = *(float *)(v10 + 8);
		  *(_QWORD *)&pixelRect.m_XMin = v11;
		  pixelRect.m_Width = v12;
		  v13 = UnityEngine::Camera::ScreenPointToRay(&v108, camera, (Vector3 *)&pixelRect, 0LL);
		  v14 = *(_QWORD *)&v13->m_Direction.y;
		  *(_OWORD *)v110 = *(_OWORD *)&v13->m_Origin.x;
		  *(_QWORD *)&v110[16] = v14;
		  *(_QWORD *)&v108.m_Origin.x = *(_QWORD *)v110;
		  LODWORD(v108.m_Origin.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)v110, 8));
		  *(_QWORD *)&pixelRect.m_XMin = *(_QWORD *)&v110[12];
		  pixelRect.m_Width = *((float *)&v14 + 1);
		  if ( HG::Rendering::Runtime::HGDebugRenderManager::RaycastIgnoreAirwall(
		         &v108.m_Origin,
		         (Vector3 *)&pixelRect,
		         10000.0,
		         (Vector3 *)&v114,
		         0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v19 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		    v20 = *(float *)&v114.m128i_i32[2];
		    *(_QWORD *)&v19->selectedDebugLightWorldPoint.x = v114.m128i_i64[0];
		    v19->selectedDebugLightWorldPoint.z = v20;
		    TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPointValid = 1;
		  }
		  else
		  {
		    v15 = TypeInfo::UnityEngine::Vector3->static_fields;
		    v16 = *(_QWORD *)&v15->negativeInfinityVector.x;
		    z = v15->negativeInfinityVector.z;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v18 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		    *(_QWORD *)&v18->selectedDebugLightWorldPoint.x = v16;
		    v18->selectedDebugLightWorldPoint.z = z;
		    TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPointValid = 0;
		  }
		  if ( UnityEngine::Event::get_type(s_Current, 0LL) == EventType__Enum_1_MouseDown )
		  {
		    if ( !UnityEngine::Event::get_button(s_Current, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelSelectionMode = 0;
		      UnityEngine::Event::Use(s_Current, 0LL);
		      return;
		    }
		LABEL_12:
		    if ( !s_Current )
		      goto LABEL_75;
		  }
		  if ( UnityEngine::Event::get_type(s_Current, 0LL) == EventType__Enum_1_Repaint )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelSelectionMode )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      v21 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		      if ( TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPointValid )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        v22 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		        v23 = *(_QWORD *)&v22->selectedDebugLightWorldPoint.x;
		        *(float *)&v22 = v22->selectedDebugLightWorldPoint.z;
		        *(_QWORD *)&v108.m_Origin.x = v23;
		        LODWORD(v108.m_Origin.z) = (_DWORD)v22;
		        LightPixelDebugInfo = HG::Rendering::Runtime::HGDebugRenderManager::GetLightPixelDebugInfo(&v108.m_Origin, 0LL);
		        v21 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		        v25 = LightPixelDebugInfo;
		      }
		      else
		      {
		        v25 = 0LL;
		      }
		      sub_1800036A0(v21);
		      TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo = v25;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo,
		        v26,
		        v27,
		        v28,
		        v107);
		    }
		  }
		  if ( this->fields.m_lightPixelDebuggerWindowRectPercentage.x < 0.0 )
		  {
		    this->fields.m_lightPixelDebuggerWindowRectPercentage.x = 0.25;
		    this->fields.m_lightPixelDebuggerWindowRectPercentage.y = 0.60000002;
		  }
		  v29 = (float)UnityEngine::Screen::get_width(0LL) / 1920.0;
		  v30 = (float)UnityEngine::Screen::get_height(0LL) / 1080.0;
		  if ( v30 <= v29 )
		    v29 = v30;
		  if ( v29 >= 0.75 )
		    v29 = 0.75;
		  if ( UnityEngine::Event::get_type(s_Current, 0LL) == EventType__Enum_1_Repaint )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		    if ( TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPointValid )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      v31 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		      v32 = v31->selectedDebugLightWorldPoint.z;
		      v33 = *(_QWORD *)&v31->selectedDebugLightWorldPoint.x;
		      lineMaterial = (Object_1 *)v31->lineMaterial;
		      *(_QWORD *)&v108.m_Origin.x = v33;
		      v35 = (__m128)(unsigned int)v33;
		      v36 = (__m128)(unsigned int)v33;
		      v37 = (__m128)HIDWORD(v33);
		      v113 = v32 - 0.5;
		      v112 = v32 + 0.5;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Equality(lineMaterial, 0LL, 0LL) )
		      {
		        v38 = UnityEngine::Shader::Find((String *)"Hidden/Internal-Colored", 0LL);
		        v39 = (Material *)sub_18002C620(TypeInfo::UnityEngine::Material);
		        v40 = (MonitorData *)v39;
		        if ( !v39 )
		          goto LABEL_75;
		        UnityEngine::Material::Material(v39, v38, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        v41 = (Type *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		        v41[1].monitor = v40;
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial,
		          v41,
		          v42,
		          v43,
		          v107);
		        static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial;
		        if ( !static_fields )
		          goto LABEL_75;
		        UnityEngine::Object::set_hideFlags(static_fields, HideFlags__Enum_HideAndDontSave, 0LL);
		        v44 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial;
		        v45 = UnityEngine::Shader::PropertyToID((String *)"_Cull", 0LL);
		        if ( !v44 )
		          goto LABEL_75;
		        UnityEngine::Material::SetFloatImpl(v44, v45, 0.0, 0LL);
		        v46 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial;
		        v47 = UnityEngine::Shader::PropertyToID((String *)"_ZWrite", 0LL);
		        if ( !v46 )
		          goto LABEL_75;
		        UnityEngine::Material::SetFloatImpl(v46, v47, 0.0, 0LL);
		      }
		      UnityEngine::GL::PushMatrix(0LL);
		      if ( !camera )
		        goto LABEL_62;
		      pixelWidth = UnityEngine::Camera::get_pixelWidth(camera, 0LL);
		      *(_QWORD *)&v108.m_Origin.x = 0LL;
		      v108.m_Origin.z = (float)pixelWidth;
		      v108.m_Direction.x = (float)UnityEngine::Camera::get_pixelHeight(camera, 0LL);
		      pixelRect = *(Rect *)&v108.m_Origin.x;
		      UnityEngine::GL::Viewport_Injected(&pixelRect, 0LL);
		      UnityEngine::GL::LoadOrtho(0LL);
		      UnityEngine::GL::Begin(7, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      v49 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->lineMaterial;
		      if ( !v49 )
		LABEL_62:
		        sub_1800D8260(v49, v48);
		      UnityEngine::Material::SetPass(v49, 0, 0LL);
		      v52 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_cyan((Color *)v110, v51));
		      red = UnityEngine::Color::get_red((Color *)&v108, v53);
		      v35.m128_f32[0] = *(float *)&v33 - 0.5;
		      *(_QWORD *)&pixelRect.m_XMin = _mm_unpacklo_ps(v35, (__m128)HIDWORD(v33)).m128_u64[0];
		      v55 = _mm_loadu_si128((const __m128i *)red);
		      v108.m_Origin.z = v32;
		      v114 = v55;
		      pixelRect.m_Width = v32;
		      *(__m128i *)v110 = v52;
		      v36.m128_f32[0] = *(float *)&v33 + 0.5;
		      *(_QWORD *)&v108.m_Origin.x = _mm_unpacklo_ps(v36, (__m128)HIDWORD(v33)).m128_u64[0];
		      HG::Rendering::Runtime::HGDebugRenderManager::DrawLineSegment(
		        camera,
		        (Vector3 *)&pixelRect,
		        &v108.m_Origin,
		        v29 * 5.0,
		        (Color *)v110,
		        0LL);
		      *(_QWORD *)&v108.m_Origin.x = _mm_unpacklo_ps(
		                                      (__m128)(unsigned int)v33,
		                                      (__m128)COERCE_UNSIGNED_INT(*((float *)&v33 + 1) + 0.5)).m128_u64[0];
		      *(__m128i *)v110 = v52;
		      v108.m_Origin.z = v32;
		      v37.m128_f32[0] = *((float *)&v33 + 1) - 0.5;
		      *(_QWORD *)&pixelRect.m_XMin = _mm_unpacklo_ps((__m128)(unsigned int)v33, v37).m128_u64[0];
		      pixelRect.m_Width = v32;
		      HG::Rendering::Runtime::HGDebugRenderManager::DrawLineSegment(
		        camera,
		        (Vector3 *)&pixelRect,
		        &v108.m_Origin,
		        v29 * 5.0,
		        (Color *)v110,
		        0LL);
		      v108.m_Origin.z = v112;
		      *(_QWORD *)&v108.m_Origin.x = _mm_unpacklo_ps((__m128)(unsigned int)v33, (__m128)HIDWORD(v33)).m128_u64[0];
		      *(_QWORD *)&pixelRect.m_XMin = *(_QWORD *)&v108.m_Origin.x;
		      pixelRect.m_Width = v113;
		      *(__m128i *)v110 = v52;
		      HG::Rendering::Runtime::HGDebugRenderManager::DrawLineSegment(
		        camera,
		        (Vector3 *)&pixelRect,
		        &v108.m_Origin,
		        v29 * 5.0,
		        (Color *)v110,
		        0LL);
		      static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug )
		        goto LABEL_58;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo )
		        goto LABEL_58;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      s_shadowDirectionDebugLight = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Inequality(s_shadowDirectionDebugLight, 0LL, 0LL) )
		        goto LABEL_57;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		      klass = static_fields[2].klass;
		      if ( !klass )
		        goto LABEL_75;
		      name = (Object_1 *)klass->_0.name;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Inequality(name, 0LL, 0LL) )
		        goto LABEL_47;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      p_image = &TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->_0.image;
		      v59 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		      s_lightPixelDebugInfo = v59->s_lightPixelDebugInfo;
		      v61 = (Object_1 *)v59->s_shadowDirectionDebugLight;
		      if ( !s_lightPixelDebugInfo )
		        goto LABEL_75;
		      dirLight = (Object_1 *)s_lightPixelDebugInfo->fields.dirLight;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Equality(v61, dirLight, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo;
		        if ( static_fields )
		        {
		          static_fields = (Object_1 *)static_fields->fields.m_CachedPtr;
		          if ( static_fields )
		          {
		            transform = UnityEngine::Component::get_transform((Component *)static_fields, 0LL);
		            if ( transform )
		            {
		              forward = UnityEngine::Transform::get_forward((Vector3 *)&pixelRect, transform, 0LL);
		              v66 = forward->z;
		              *(_QWORD *)&v108.m_Origin.x = *(_QWORD *)&forward->x;
		              v65 = *(_QWORD *)&v108.m_Origin.x;
		              v108.m_Origin.z = v66;
		              v68 = UnityEngine::Vector3::op_Multiply((Vector3 *)&pixelRect, &v108.m_Origin, 1000.0, v67);
		              v69 = *(_QWORD *)&v68->x;
		              *(float *)&v68 = v68->z;
		              *(_QWORD *)&v108.m_Origin.x = v69;
		              LODWORD(v108.m_Origin.z) = (_DWORD)v68;
		              *(_QWORD *)&pixelRect.m_XMin = v33;
		              pixelRect.m_Width = v32;
		              v71 = UnityEngine::Vector3::op_Subtraction(v115, (Vector3 *)&pixelRect, &v108.m_Origin, v70);
		              *(_QWORD *)&pixelRect.m_XMin = v33;
		              v72 = *(_QWORD *)&v71->x;
		              v73 = v71->z;
		              *(__m128i *)v110 = v114;
		              *(_QWORD *)&v108.m_Origin.x = v72;
		              v108.m_Origin.z = v73;
		              pixelRect.m_Width = v32;
		              HG::Rendering::Runtime::HGDebugRenderManager::DrawLineSegment(
		                camera,
		                (Vector3 *)&pixelRect,
		                &v108.m_Origin,
		                v29 * 5.0,
		                (Color *)v110,
		                0LL);
		              *(_QWORD *)&v108.m_Origin.x = v65;
		              v108.m_Origin.z = v66;
		              *(_QWORD *)&pixelRect.m_XMin = v72;
		              pixelRect.m_Width = v73;
		              if ( HG::Rendering::Runtime::HGDebugRenderManager::RaycastIgnoreAirwall(
		                     (Vector3 *)&pixelRect,
		                     &v108.m_Origin,
		                     1000.0,
		                     &v111,
		                     0LL) )
		              {
		                v75 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_green((Color *)v110, v74));
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                v76 = *(_QWORD *)&v111.x;
		                v77 = v111.z;
		LABEL_56:
		                *(__m128i *)v110 = v75;
		                *(_QWORD *)&v108.m_Origin.x = v76;
		                v108.m_Origin.z = v77;
		                HG::Rendering::Runtime::HGDebugRenderManager::DrawScreenSpaceDot(
		                  camera,
		                  &v108.m_Origin,
		                  v29 * 20.0,
		                  (Color *)v110,
		                  0LL);
		                goto LABEL_57;
		              }
		              goto LABEL_57;
		            }
		          }
		        }
		      }
		      else
		      {
		LABEL_47:
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		        p_image = &TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo->klass;
		        if ( !p_image )
		          goto LABEL_75;
		        if ( !p_image[3] )
		          goto LABEL_58;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        p_image = &TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->_0.image;
		        v78 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		        static_fields = (Object_1 *)v78->s_lightPixelDebugInfo;
		        if ( static_fields )
		        {
		          static_fields = (Object_1 *)static_fields[1].klass;
		          if ( static_fields )
		          {
		            if ( !System::Collections::Generic::List<System::Object>::Contains(
		                    (List_1_System_Object_ *)static_fields,
		                    (Object *)v78->s_shadowDirectionDebugLight,
		                    MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::Contains) )
		              goto LABEL_57;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		            static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight;
		            if ( static_fields )
		            {
		              v79 = UnityEngine::Component::get_transform((Component *)static_fields, 0LL);
		              if ( v79 )
		              {
		                position = UnityEngine::Transform::get_position((Vector3 *)&pixelRect, v79, 0LL);
		                v82 = position->z;
		                *(_QWORD *)&v108.m_Origin.x = *(_QWORD *)&position->x;
		                v81 = *(_QWORD *)&v108.m_Origin.x;
		                v108.m_Origin.z = v82;
		                *(_QWORD *)&pixelRect.m_XMin = v33;
		                pixelRect.m_Width = v32;
		                v84 = UnityEngine::Vector3::op_Subtraction(&v111, (Vector3 *)&pixelRect, &v108.m_Origin, v83);
		                v85 = *(_QWORD *)&v84->x;
		                *(float *)&v84 = v84->z;
		                *(_QWORD *)&v108.m_Origin.x = v85;
		                LODWORD(v108.m_Origin.z) = (_DWORD)v84;
		                v86 = sub_182FAE420(&pixelRect, &v108);
		                *(_QWORD *)&v108.m_Origin.x = v81;
		                v108.m_Origin.z = v82;
		                v87 = *(_QWORD *)v86;
		                v88 = *(float *)(v86 + 8);
		                *(_QWORD *)&pixelRect.m_XMin = v33;
		                pixelRect.m_Width = v32;
		                v90 = UnityEngine::Vector3::op_Subtraction(&v111, (Vector3 *)&pixelRect, &v108.m_Origin, v89);
		                v91 = *(_QWORD *)&v90->x;
		                *(float *)&v90 = v90->z;
		                *(_QWORD *)&v108.m_Origin.x = v91;
		                LODWORD(v108.m_Origin.z) = (_DWORD)v90;
		                v92 = sub_182FAE390(&v108);
		                cyan = UnityEngine::Color::get_cyan((Color *)v110, v93);
		                *(_QWORD *)&v108.m_Origin.x = v81;
		                v108.m_Origin.z = v82;
		                *(Color *)v110 = *cyan;
		                HG::Rendering::Runtime::HGDebugRenderManager::DrawScreenSpaceDot(
		                  camera,
		                  &v108.m_Origin,
		                  v29 * 20.0,
		                  (Color *)v110,
		                  0LL);
		                *(_QWORD *)&v108.m_Origin.x = v81;
		                *(__m128i *)v110 = v114;
		                v108.m_Origin.z = v82;
		                *(_QWORD *)&pixelRect.m_XMin = v33;
		                pixelRect.m_Width = v32;
		                HG::Rendering::Runtime::HGDebugRenderManager::DrawLineSegment(
		                  camera,
		                  (Vector3 *)&pixelRect,
		                  &v108.m_Origin,
		                  v29 * 5.0,
		                  (Color *)v110,
		                  0LL);
		                *(_QWORD *)&v108.m_Origin.x = v87;
		                v108.m_Origin.z = v88;
		                *(_QWORD *)&pixelRect.m_XMin = v81;
		                pixelRect.m_Width = v82;
		                if ( HG::Rendering::Runtime::HGDebugRenderManager::RaycastIgnoreAirwall(
		                       (Vector3 *)&pixelRect,
		                       &v108.m_Origin,
		                       *(float *)&v92,
		                       v115,
		                       0LL) )
		                {
		                  v75 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_green((Color *)v110, v95));
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                  v76 = *(_QWORD *)&v115[0].x;
		                  v77 = v115[0].z;
		                  goto LABEL_56;
		                }
		LABEL_57:
		                static_fields = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		LABEL_58:
		                sub_1800036A0(static_fields);
		                if ( TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelSelectionMode )
		                  yellow = UnityEngine::Color::get_yellow(
		                             (Color *)v110,
		                             (MethodInfo *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                else
		                  yellow = UnityEngine::Color::get_red(
		                             (Color *)v110,
		                             (MethodInfo *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                v98 = _mm_loadu_si128((const __m128i *)yellow);
		                sub_1800036A0(v97);
		                *(__m128i *)v110 = v98;
		                *(_QWORD *)&v108.m_Origin.x = v33;
		                v108.m_Origin.z = v32;
		                HG::Rendering::Runtime::HGDebugRenderManager::DrawScreenSpaceDot(
		                  camera,
		                  &v108.m_Origin,
		                  v29 * 20.0,
		                  (Color *)v110,
		                  0LL);
		                UnityEngine::GL::End(0LL);
		                UnityEngine::GL::PopMatrix(0LL);
		                goto LABEL_64;
		              }
		            }
		          }
		        }
		      }
		LABEL_75:
		      sub_1800D8260(static_fields, p_image);
		    }
		  }
		  if ( !camera )
		    goto LABEL_75;
		LABEL_64:
		  scaledPixelWidth = (float)UnityEngine::Camera::get_scaledPixelWidth(camera, 0LL);
		  scaledPixelHeight = (float)UnityEngine::Camera::get_scaledPixelHeight(camera, 0LL);
		  this->fields.m_lightPixelDebuggerWindowRect.m_XMin = scaledPixelWidth
		                                                     * this->fields.m_lightPixelDebuggerWindowRectPercentage.x;
		  this->fields.m_lightPixelDebuggerWindowRect.m_YMin = scaledPixelHeight
		                                                     * this->fields.m_lightPixelDebuggerWindowRectPercentage.y;
		  this->fields.m_lightPixelDebuggerWindowRect.m_Width = v29 * 400.0;
		  this->fields.m_lightPixelDebuggerWindowRect.m_Height = v29 * 450.0;
		  v101 = _mm_loadu_si128((const __m128i *)&this->fields.m_lightPixelDebuggerWindowRect);
		  v102 = (UnityAction_1_System_Int32Enum_ *)sub_18002C620(TypeInfo::UnityEngine::GUI::WindowFunction);
		  v103 = (GUI_WindowFunction *)v102;
		  if ( !v102 )
		    goto LABEL_75;
		  UnityEngine::Events::UnityAction<System::Int32Enum>::UnityAction(
		    v102,
		    0LL,
		    MethodInfo::HG::Rendering::Runtime::HGDebugRenderManager::LightPixelDebuggerWindowFunc,
		    0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::GUI);
		  *(__m128i *)v110 = v101;
		  this->fields.m_lightPixelDebuggerWindowRect = (Rect)_mm_loadu_si128((const __m128i *)UnityEngine::GUI::Window(
		                                                                                         (Rect *)&v108,
		                                                                                         783229733,
		                                                                                         (Rect *)v110,
		                                                                                         v103,
		                                                                                         (String *)"Light&Shadow Pixel Debugger",
		                                                                                         0LL));
		  m_XMin = this->fields.m_lightPixelDebuggerWindowRect.m_XMin;
		  if ( m_XMin < 0.0 )
		  {
		    m_XMin = 0.0;
		  }
		  else if ( m_XMin > (float)(scaledPixelWidth - this->fields.m_lightPixelDebuggerWindowRect.m_Width) )
		  {
		    m_XMin = scaledPixelWidth - this->fields.m_lightPixelDebuggerWindowRect.m_Width;
		  }
		  this->fields.m_lightPixelDebuggerWindowRect.m_XMin = m_XMin;
		  m_YMin = this->fields.m_lightPixelDebuggerWindowRect.m_YMin;
		  if ( m_YMin < 0.0 )
		  {
		    m_YMin = 0.0;
		  }
		  else if ( m_YMin > (float)(scaledPixelHeight - this->fields.m_lightPixelDebuggerWindowRect.m_Height) )
		  {
		    m_YMin = scaledPixelHeight - this->fields.m_lightPixelDebuggerWindowRect.m_Height;
		  }
		  this->fields.m_lightPixelDebuggerWindowRect.m_YMin = m_YMin;
		  this->fields.m_lightPixelDebuggerWindowRectPercentage.x = this->fields.m_lightPixelDebuggerWindowRect.m_XMin
		                                                          / scaledPixelWidth;
		  this->fields.m_lightPixelDebuggerWindowRectPercentage.y = this->fields.m_lightPixelDebuggerWindowRect.m_YMin
		                                                          / scaledPixelHeight;
		}
		
		private static void LightPixelDebuggerWindowFunc(int id) {} // 0x0000000189B78BD0-0x0000000189B79C6C
		// Void LightPixelDebuggerWindowFunc(Int32)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGDebugRenderManager::LightPixelDebuggerWindowFunc(int32_t id, MethodInfo *method)
		{
		  __m128i v3; // xmm8
		  float v4; // xmm0_4
		  float v5; // xmm8_4
		  GUISkin *skin; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  GUIStyle *m_toggle; // rsi
		  GUIStyle *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  GUIStyle *v13; // rbx
		  GUISkin *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  GUIStyle *m_label; // rbx
		  GUIStyle *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  GUIStyle *v21; // r14
		  GUISkin *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  GUIStyle *m_button; // rbx
		  GUIStyle *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  GUIStyle *v29; // r15
		  GUISkin *v30; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  GUIStyle *v33; // rbx
		  GUIStyle *v34; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  GUIStyle *v37; // rsi
		  GUIStyleState *normal; // rbx
		  MethodInfo *v39; // rdx
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  __m128i v42; // xmm6
		  GUIStyleState *hover; // rbx
		  MethodInfo *v44; // rdx
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __m128i v47; // xmm6
		  GUIStyleState *active; // rbx
		  MethodInfo *v49; // rdx
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  __m128i v52; // xmm6
		  GUIStyleState *focused; // rbx
		  MethodInfo *v54; // rdx
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __m128i v57; // xmm6
		  struct HGDebugRenderManager__Class *v58; // rcx
		  bool s_enableShadowDirectionDebug; // bl
		  Type *v60; // rdx
		  PropertyInfo_1 *v61; // r8
		  Int32__Array **v62; // r9
		  String *v63; // rax
		  String *v64; // rbx
		  String *v65; // rax
		  String *v66; // r12
		  String *v67; // rax
		  String *v68; // r13
		  __m128 v69; // xmm6
		  float v70; // xmm7_4
		  HGDebugRenderManager__StaticFields *static_fields; // rcx
		  float v72; // xmm9_4
		  __int64 v73; // rdx
		  HGDebugRenderManager__StaticFields *v74; // rcx
		  HGDebugRenderManager_LightPixelDebugInfo *s_lightPixelDebugInfo; // rbx
		  Object_1 *dirLight; // rbx
		  float v77; // xmm9_4
		  __int64 v78; // rdx
		  HGDebugRenderManager__StaticFields *v79; // rcx
		  HGDebugRenderManager_LightPixelDebugInfo *v80; // rbx
		  Object_1 *v81; // rbx
		  String *name; // r14
		  Color v83; // xmm6
		  __int64 v84; // rdx
		  HGDebugRenderManager__StaticFields *v85; // rax
		  Object_1 *s_shadowDirectionDebugLight; // r12
		  HGDebugRenderManager_LightPixelDebugInfo *v87; // rbx
		  Object_1 *v88; // rbx
		  bool v89; // al
		  GUIStyle *v90; // rbx
		  struct HGDebugRenderManager__Class *v91; // rcx
		  __int64 v92; // rcx
		  PropertyInfo_1 *v93; // r8
		  Int32__Array **v94; // r9
		  Type *v95; // rdx
		  HGDebugRenderManager__StaticFields *v96; // rax
		  HGDebugRenderManager_LightPixelDebugInfo *v97; // rbx
		  __int64 v98; // rdx
		  HGDebugRenderManager_LightPixelDebugInfo *v99; // rbx
		  float v100; // xmm9_4
		  __int64 v101; // rdx
		  HGDebugRenderManager__StaticFields *v102; // rcx
		  HGDebugRenderManager_LightPixelDebugInfo *v103; // rbx
		  List_1_UnityEngine_Light_ *localLights; // rbx
		  Object *v105; // rax
		  String *v106; // rbx
		  __int64 v107; // rdx
		  HGDebugRenderManager__StaticFields *v108; // rcx
		  HGDebugRenderManager_LightPixelDebugInfo *v109; // rbx
		  List_1_System_UInt64_ *v110; // rbx
		  __int64 v111; // rdx
		  __int64 v112; // rcx
		  Object *current; // rbx
		  Transform *transform; // rax
		  __int64 v115; // rdx
		  __int64 v116; // rcx
		  Vector3 *position; // rax
		  float z; // r14d
		  HGDebugRenderManager__StaticFields *v119; // rcx
		  float v120; // xmm2_4
		  __m128 v121; // xmm1
		  __m128 v122; // xmm0
		  __int64 v123; // rdx
		  __int64 v124; // rcx
		  double v125; // xmm0_8
		  Object *v126; // r14
		  Object *v127; // rax
		  String *v128; // r12
		  Color v129; // xmm6
		  Object_1 *v130; // r14
		  bool v131; // al
		  GUIStyle *v132; // r14
		  Light *v133; // r14
		  unsigned __int64 v134; // r8
		  unsigned __int64 v135; // rdx
		  signed __int64 v136; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v138; // rdx
		  __int64 v139; // rcx
		  Color v140; // [rsp+20h] [rbp-158h] BYREF
		  Color v141; // [rsp+30h] [rbp-148h] BYREF
		  unsigned int result; // [rsp+40h] [rbp-138h] BYREF
		  Color v143; // [rsp+48h] [rbp-130h] BYREF
		  List_1_T_Enumerator_System_Object_ v144; // [rsp+60h] [rbp-118h] BYREF
		  List_1_T_Enumerator_System_Object_ v145; // [rsp+80h] [rbp-F8h] BYREF
		  __int64 v146; // [rsp+98h] [rbp-E0h]
		  __int64 v147; // [rsp+B0h] [rbp-C8h]
		  unsigned __int64 v148; // [rsp+C0h] [rbp-B8h] BYREF
		  float v149; // [rsp+C8h] [rbp-B0h]
		  Il2CppExceptionWrapper *v150; // [rsp+D0h] [rbp-A8h] BYREF
		  Color v151; // [rsp+E0h] [rbp-98h] BYREF
		  unsigned int size; // [rsp+190h] [rbp+18h] BYREF
		  float v153; // [rsp+198h] [rbp+20h] BYREF
		
		  result = 0;
		  size = 0;
		  v153 = 0.0;
		  memset(&v145, 0, sizeof(v145));
		  if ( !IFix::WrappersManagerImpl::IsPatched(2862, 0LL) )
		  {
		    v3 = _mm_cvtsi32_si128(UnityEngine::Screen::get_width(0LL));
		    v4 = (float)UnityEngine::Screen::get_height(0LL) / 1080.0;
		    v5 = _mm_cvtepi32_ps(v3).m128_f32[0] / 1920.0;
		    if ( v4 <= v5 )
		      v5 = v4;
		    if ( v5 >= 0.75 )
		      v5 = 0.75;
		    *(_QWORD *)&v140.r = 0LL;
		    v140.b = 1000.0;
		    v140.a = v5 * 24.0;
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    v151 = v140;
		    UnityEngine::GUI::DragWindow((Rect *)&v151, 0LL);
		    skin = UnityEngine::GUI::get_skin(0LL);
		    if ( !skin )
		      sub_1800D8260(v8, v7);
		    m_toggle = skin->fields.m_toggle;
		    v10 = (GUIStyle *)sub_18002C620(TypeInfo::UnityEngine::GUIStyle);
		    v13 = v10;
		    if ( !v10 )
		      sub_1800D8260(v12, v11);
		    UnityEngine::GUIStyle::GUIStyle(v10, m_toggle, 0LL);
		    UnityEngine::GUIStyle::set_fontSize(v13, (int)(float)(v5 * 18.0), 0LL);
		    v14 = UnityEngine::GUI::get_skin(0LL);
		    if ( !v14 )
		      sub_1800D8260(v16, v15);
		    m_label = v14->fields.m_label;
		    v18 = (GUIStyle *)sub_18002C620(TypeInfo::UnityEngine::GUIStyle);
		    v21 = v18;
		    if ( !v18 )
		      sub_1800D8260(v20, v19);
		    UnityEngine::GUIStyle::GUIStyle(v18, m_label, 0LL);
		    UnityEngine::GUIStyle::set_fontSize(v21, (int)(float)(v5 * 18.0), 0LL);
		    v22 = UnityEngine::GUI::get_skin(0LL);
		    if ( !v22 )
		      sub_1800D8260(v24, v23);
		    m_button = v22->fields.m_button;
		    v26 = (GUIStyle *)sub_18002C620(TypeInfo::UnityEngine::GUIStyle);
		    v29 = v26;
		    if ( !v26 )
		      sub_1800D8260(v28, v27);
		    UnityEngine::GUIStyle::GUIStyle(v26, m_button, 0LL);
		    UnityEngine::GUIStyle::set_fontSize(v29, (int)(float)(v5 * 16.0), 0LL);
		    v30 = UnityEngine::GUI::get_skin(0LL);
		    if ( !v30 )
		      sub_1800D8260(v32, v31);
		    v33 = v30->fields.m_button;
		    v34 = (GUIStyle *)sub_18002C620(TypeInfo::UnityEngine::GUIStyle);
		    v37 = v34;
		    if ( !v34 )
		      sub_1800D8260(v36, v35);
		    UnityEngine::GUIStyle::GUIStyle(v34, v33, 0LL);
		    UnityEngine::GUIStyle::set_fontSize(v37, (int)(float)(v5 * 16.0), 0LL);
		    normal = UnityEngine::GUIStyle::get_normal(v37, 0LL);
		    v42 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_green((Color *)&v144, v39));
		    if ( !normal )
		      sub_1800D8260(v41, v40);
		    v141 = (Color)v42;
		    UnityEngine::GUIStyleState::set_textColor(normal, &v141, 0LL);
		    hover = UnityEngine::GUIStyle::get_hover(v37, 0LL);
		    v47 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_green((Color *)&v144, v44));
		    if ( !hover )
		      sub_1800D8260(v46, v45);
		    v140 = (Color)v47;
		    UnityEngine::GUIStyleState::set_textColor(hover, &v140, 0LL);
		    active = UnityEngine::GUIStyle::get_active(v37, 0LL);
		    v52 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_green((Color *)&v144, v49));
		    if ( !active )
		      sub_1800D8260(v51, v50);
		    v141 = (Color)v52;
		    UnityEngine::GUIStyleState::set_textColor(active, &v141, 0LL);
		    focused = UnityEngine::GUIStyle::get_focused(v37, 0LL);
		    v57 = _mm_loadu_si128((const __m128i *)UnityEngine::Color::get_green((Color *)&v144, v54));
		    if ( !focused )
		      sub_1800D8260(v56, v55);
		    v140 = (Color)v57;
		    UnityEngine::GUIStyleState::set_textColor(focused, &v140, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v58 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		    if ( TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelSelectionMode )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::GUI);
		      UnityEngine::GUI::set_enabled(0, 0LL);
		      v58 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		    }
		    v140.r = 0.0;
		    v140.g = v5 * 30.0;
		    v140.b = v5 * 400.0;
		    v140.a = v5 * 24.0;
		    sub_1800036A0(v58);
		    s_enableShadowDirectionDebug = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug;
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    v141 = v140;
		    TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug = UnityEngine::GUI::Toggle((Rect *)&v141, s_enableShadowDirectionDebug, (String *)"开启阴影Debug", 0LL);
		    v140.r = 0.0;
		    v140.g = (float)(v5 * 30.0) + (float)(v5 * 24.0);
		    v140.b = v5 * 400.0;
		    v140.a = v5 * 24.0;
		    v141 = v140;
		    if ( UnityEngine::GUI::Button((Rect *)&v141, (String *)"进入选择模式", 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelSelectionMode = 1;
		      TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo = 0LL;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo,
		        v60,
		        v61,
		        v62,
		        *(MethodInfo **)&v140.r);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPointValid )
		      goto LABEL_65;
		    v140.r = 0.0;
		    v140.g = (float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 160.0;
		    v140.a = v5 * 24.0;
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    v141 = v140;
		    UnityEngine::GUI::Label((Rect *)&v141, (String *)"当前选中点坐标:", v21, 0LL);
		    v140.r = 0.0;
		    v140.g = (float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 20.0;
		    v140.a = v5 * 24.0;
		    v141 = v140;
		    UnityEngine::GUI::Label((Rect *)&v141, (String *)"X", 0LL);
		    UnityEngine::GUI::set_changed(0, 0LL);
		    v140.r = v5 * 20.0;
		    v140.g = (float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 110.0;
		    v140.a = v5 * 24.0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v63 = System::Single::ToString(
		            (Single *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPoint,
		            (String *)"F2",
		            0LL);
		    v141 = v140;
		    v64 = UnityEngine::GUI::TextField((Rect *)&v141, v63, 0LL);
		    v140.r = v5 * 130.0;
		    v140.g = (float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 20.0;
		    v140.a = v5 * 24.0;
		    v141 = v140;
		    UnityEngine::GUI::Label((Rect *)&v141, (String *)"Y", 0LL);
		    v140.r = v5 * 150.0;
		    v140.g = (float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 110.0;
		    v140.a = v5 * 24.0;
		    v65 = System::Single::ToString(
		            (Single *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPoint.y,
		            (String *)"F2",
		            0LL);
		    v141 = v140;
		    v66 = UnityEngine::GUI::TextField((Rect *)&v141, v65, 0LL);
		    v140.r = v5 * 260.0;
		    v140.g = (float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 20.0;
		    v140.a = v5 * 24.0;
		    v141 = v140;
		    UnityEngine::GUI::Label((Rect *)&v141, (String *)"Z", 0LL);
		    v140.r = v5 * 280.0;
		    v140.g = (float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0);
		    v140.b = v5 * 110.0;
		    v140.a = v5 * 24.0;
		    v67 = System::Single::ToString(
		            (Single *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->selectedDebugLightWorldPoint.z,
		            (String *)"F2",
		            0LL);
		    v141 = v140;
		    v68 = UnityEngine::GUI::TextField((Rect *)&v141, v67, 0LL);
		    if ( UnityEngine::GUI::get_changed(0LL)
		      && System::Single::TryParse(v64, (float *)&result, 0LL)
		      && System::Single::TryParse(v66, (float *)&size, 0LL)
		      && System::Single::TryParse(v68, &v153, 0LL) )
		    {
		      v69 = (__m128)size;
		      v70 = v153;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		      *(_QWORD *)&static_fields->selectedDebugLightWorldPoint.x = _mm_unpacklo_ps((__m128)result, v69).m128_u64[0];
		      static_fields->selectedDebugLightWorldPoint.z = v70;
		    }
		    v72 = (float)((float)((float)((float)(v5 * 30.0) + (float)(v5 * 24.0)) + (float)(v5 * 24.0)) + (float)(v5 * 24.0))
		        + (float)(v5 * 30.0);
		    v140.r = 0.0;
		    v140.g = v72;
		    v140.b = v5 * 400.0;
		    v140.a = v5 * 24.0;
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    v141 = v140;
		    UnityEngine::GUI::Label((Rect *)&v141, (String *)"对当前点存在影响的灯光:", v21, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo )
		      goto LABEL_65;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		    v74 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		    s_lightPixelDebugInfo = v74->s_lightPixelDebugInfo;
		    if ( !s_lightPixelDebugInfo )
		      sub_1800D8260(v74, v73);
		    dirLight = (Object_1 *)s_lightPixelDebugInfo->fields.dirLight;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(dirLight, 0LL, 0LL) )
		    {
		      v77 = v72 + (float)(v5 * 24.0);
		      v140.r = 0.0;
		      v140.g = v77;
		      v140.b = v5 * 400.0;
		      v140.a = v5 * 24.0;
		      sub_1800036A0(TypeInfo::UnityEngine::GUI);
		      v141 = v140;
		      UnityEngine::GUI::Label((Rect *)&v141, (String *)"平行光", 0LL);
		      v72 = v77 + (float)(v5 * 24.0);
		      v143.r = 0.0;
		      v143.g = v72;
		      v143.b = v5 * 400.0;
		      v143.a = v5 * 24.0;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      v79 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		      v80 = v79->s_lightPixelDebugInfo;
		      if ( !v80 )
		        sub_1800D8260(v79, v78);
		      v81 = (Object_1 *)v80->fields.dirLight;
		      if ( !v81 )
		        sub_1800D8260(v79, v78);
		      name = UnityEngine::Object::get_name(v81, 0LL);
		      v83 = v143;
		      if ( !name )
		        name = (String *)"";
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug )
		        goto LABEL_38;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		      v85 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		      s_shadowDirectionDebugLight = (Object_1 *)v85->s_shadowDirectionDebugLight;
		      v87 = v85->s_lightPixelDebugInfo;
		      if ( !v87 )
		        sub_1800D8260(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager, v84);
		      v88 = (Object_1 *)v87->fields.dirLight;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      v89 = UnityEngine::Object::op_Equality(s_shadowDirectionDebugLight, v88, 0LL);
		      v90 = v37;
		      if ( !v89 )
		LABEL_38:
		        v90 = v29;
		      sub_1800036A0(TypeInfo::UnityEngine::GUI);
		      v141 = v83;
		      if ( UnityEngine::GUI::Button((Rect *)&v141, name, v90, 0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        v91 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug )
		        {
		LABEL_44:
		          sub_1800036A0(v91);
		          v99 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_lightPixelDebugInfo;
		          if ( !v99 )
		            sub_1800D8260(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager, v98);
		          if ( v99->fields.localLights )
		          {
		            v100 = v72 + (float)(v5 * 24.0);
		            v140.r = 0.0;
		            v140.g = v100;
		            v140.b = v5 * 400.0;
		            v140.a = v5 * 24.0;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		            v102 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		            v103 = v102->s_lightPixelDebugInfo;
		            if ( !v103 )
		              sub_1800D8260(v102, v101);
		            localLights = v103->fields.localLights;
		            if ( !localLights )
		              sub_1800D8260(v102, v101);
		            size = localLights->fields._size;
		            v105 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &size);
		            v106 = System::String::Format((String *)"局部光源 (共{0}盏)", v105, 0LL);
		            sub_1800036A0(TypeInfo::UnityEngine::GUI);
		            v141 = v140;
		            UnityEngine::GUI::Label((Rect *)&v141, v106, 0LL);
		            v108 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		            v109 = v108->s_lightPixelDebugInfo;
		            if ( !v109 )
		              sub_1800D8260(v108, v107);
		            v110 = (List_1_System_UInt64_ *)v109->fields.localLights;
		            if ( !v110 )
		              sub_1800D8260(v108, v107);
		            System::Collections::Generic::List<unsigned long>::GetEnumerator(
		              (List_1_T_Enumerator_System_UInt64_ *)&v144,
		              v110,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::GetEnumerator);
		            v145 = v144;
		            *(_QWORD *)&v141.r = 0LL;
		            *(_QWORD *)&v141.b = &v145;
		            try
		            {
		              while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                        &v145,
		                        MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Light>::MoveNext) )
		              {
		                current = v145._current;
		                if ( !v145._current )
		                  sub_1800D8250(v112, v111);
		                transform = UnityEngine::Component::get_transform((Component *)v145._current, 0LL);
		                if ( !transform )
		                  sub_1800D8250(v116, v115);
		                position = UnityEngine::Transform::get_position((Vector3 *)&v143, transform, 0LL);
		                v146 = *(_QWORD *)&position->x;
		                z = position->z;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                v119 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		                v147 = *(_QWORD *)&v119->selectedDebugLightWorldPoint.x;
		                v120 = z - v119->selectedDebugLightWorldPoint.z;
		                v121 = (__m128)HIDWORD(v146);
		                v121.m128_f32[0] = *((float *)&v146 + 1) - *((float *)&v147 + 1);
		                v122 = (__m128)(unsigned int)v146;
		                v122.m128_f32[0] = *(float *)&v146 - *(float *)&v147;
		                v148 = _mm_unpacklo_ps(v122, v121).m128_u64[0];
		                v149 = v120;
		                v125 = sub_182FAE390(&v148);
		                v100 = v100 + (float)(v5 * 24.0);
		                v140.r = 0.0;
		                v140.g = v100;
		                v140.b = v5 * 400.0;
		                v140.a = v5 * 24.0;
		                if ( !current )
		                  sub_1800D8250(v124, v123);
		                v126 = (Object *)UnityEngine::Object::get_name((Object_1 *)current, 0LL);
		                size = LODWORD(v125);
		                v127 = (Object *)il2cpp_value_box_0(TypeInfo::System::Single, &size);
		                v128 = System::String::Format((String *)"{0} <{1:F2}>", v126, v127, 0LL);
		                v129 = v140;
		                if ( !TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug
		                  || (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager),
		                      v130 = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight,
		                      sub_1800036A0(TypeInfo::UnityEngine::Object),
		                      v131 = UnityEngine::Object::op_Equality(v130, (Object_1 *)current, 0LL),
		                      v132 = v37,
		                      !v131) )
		                {
		                  v132 = v29;
		                }
		                sub_1800036A0(TypeInfo::UnityEngine::GUI);
		                *(Color *)&v144._list = v129;
		                if ( UnityEngine::GUI::Button((Rect *)&v144, v128, v132, 0LL) )
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                  if ( TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_enableShadowDirectionDebug )
		                  {
		                    v133 = (Light *)((unsigned __int64)current & -(__int64)(UnityEngine::Light::get_shadows(
		                                                                              (Light *)current,
		                                                                              0LL) != LightShadows__Enum_None));
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		                    TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight = v133;
		                    if ( dword_18F35FD08 )
		                    {
		                      v134 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight >> 12) & 0x1FFFFF) >> 6;
		                      v135 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight >> 12) & 0x3F;
		                      _m_prefetchw(&qword_18F103690[v134]);
		                      do
		                        v136 = qword_18F103690[v134];
		                      while ( v136 != _InterlockedCompareExchange64(&qword_18F103690[v134], v136 | (1LL << v135), v136) );
		                    }
		                  }
		                }
		              }
		            }
		            catch ( Il2CppExceptionWrapper *v150 )
		            {
		              *(Il2CppExceptionWrapper *)&v141.r = (Il2CppExceptionWrapper)v150->ex;
		              if ( *(_QWORD *)&v141.r )
		                sub_18007E1E0(*(_QWORD *)&v141.r);
		            }
		          }
		LABEL_65:
		          sub_1800036A0(TypeInfo::UnityEngine::GUI);
		          UnityEngine::GUI::set_enabled(1, 0LL);
		          return;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        v95 = (Type *)TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		        v96 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields;
		        v97 = v96->s_lightPixelDebugInfo;
		        if ( !v97 )
		          sub_1800D8260(v92, TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager);
		        v96->s_shadowDirectionDebugLight = v97->fields.dirLight;
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager->static_fields->s_shadowDirectionDebugLight,
		          v95,
		          v93,
		          v94,
		          *(MethodInfo **)&v140.r);
		      }
		    }
		    v91 = TypeInfo::HG::Rendering::Runtime::HGDebugRenderManager;
		    goto LABEL_44;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2862, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v139, v138);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_30 *)Patch, id, 0LL);
		}
		
	}
}
