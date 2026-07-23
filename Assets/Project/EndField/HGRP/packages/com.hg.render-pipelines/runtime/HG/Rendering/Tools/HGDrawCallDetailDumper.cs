using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Tools
{
	public class HGDrawCallDetailDumper // TypeDefIndex: 37404
	{
		// Fields
		internal static string[] s_drawCallRowTitles; // 0x00
	
		// Nested types
		public struct ParsedDrawCallTableContents // TypeDefIndex: 37399
		{
			// Fields
			public DrawCallRowContent[] rowContents; // 0x00
			public int totalTriCount; // 0x08
		}
	
		public struct DrawCallRowContent // TypeDefIndex: 37400
		{
			// Fields
			public int drawCallIndex; // 0x00
			public string objectName; // 0x08
			public int triangleCount; // 0x10
			public int instanceCount; // 0x14
			public int totalTriCount; // 0x18
			public float triCountPercentage; // 0x1C
			public string shaderName; // 0x20
			public string passName; // 0x28
			public string assetPath; // 0x30
			public string assetGuid; // 0x38
			public string vertKeywordNames; // 0x40
			public string fragKeywordNames; // 0x48
		}
	
		public struct DrawCallCameraInfo // TypeDefIndex: 37401
		{
			// Fields
			public string cameraName; // 0x00
			public Vector3 position; // 0x08
			public Vector3 direction; // 0x14
			public Vector3 up; // 0x20
			public float nearClipDistance; // 0x2C
			public float farClipDistance; // 0x30
			public float aspect; // 0x34
			public float verticalFoV; // 0x38
	
			// Methods
			public static DrawCallCameraInfo CreateDefault() => default; // 0x0000000189B25698-0x0000000189B257B8
			// HGDrawCallDetailDumper+DrawCallCameraInfo CreateDefault()
			HGDrawCallDetailDumper_DrawCallCameraInfo *HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallCameraInfo::CreateDefault(
			        HGDrawCallDetailDumper_DrawCallCameraInfo *__return_ptr retstr,
			        MethodInfo *method)
			{
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v3; // rdx
			  VolumetricRenderer_VolumetricBounds *v4; // r8
			  Int32__Array **v5; // r9
			  Animator *v6; // rdx
			  int32_t v7; // r8d
			  MethodInfo *v8; // r9
			  MethodInfo *v9; // rdx
			  MethodInfo *v10; // rdx
			  Vector3 *up; // rax
			  __int128 v12; // xmm1
			  __int128 v13; // xmm0
			  __int128 v14; // xmm1
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v16; // rdx
			  __int64 v17; // rcx
			  HGDrawCallDetailDumper_DrawCallCameraInfo *v18; // rax
			  __int128 v19; // xmm1
			  HGDrawCallDetailDumper_DrawCallCameraInfo *result; // rax
			  VolumetricRenderer_VolumetricRenderItem v21; // [rsp+20h] [rbp-39h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(14, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(14, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v17, v16);
			    v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			            (HGDrawCallDetailDumper_DrawCallCameraInfo *)&v21.meshFilter,
			            Patch,
			            0LL);
			    v19 = *(_OWORD *)&v18->position.z;
			    *(_OWORD *)&retstr->cameraName = *(_OWORD *)&v18->cameraName;
			    v13 = *(_OWORD *)&v18->up.x;
			    *(_OWORD *)&retstr->position.z = v19;
			    v14 = *(_OWORD *)&v18->farClipDistance;
			  }
			  else
			  {
			    sub_18033B9D0(&v21, 0LL, 64LL);
			    v21.Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)"";
			    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **))sub_18002D1B0)(
			      &v21,
			      v3,
			      v4,
			      v5);
			    *(Vector3 *)&v21.material = *UnityEngine::Animator::GetVector((Vector3 *)&v21.bPureBlit, v6, v7, v8);
			    v21.bounds.worldBounds.m_Center = *UnityEngine::Vector3::get_fwd((Vector3 *)&v21.bPureBlit, v9);
			    up = UnityEngine::Vector3::get_up((Vector3 *)&v21.bPureBlit, v10);
			    v12 = *(_OWORD *)&v21.bounds.enableBounds;
			    *(_OWORD *)&retstr->cameraName = *(_OWORD *)&v21.Callback;
			    v21.bounds.worldBounds.m_Extents = *up;
			    *(_DWORD *)&v21.bEnableFraming = 1008981770;
			    v13 = *(_OWORD *)&v21.bounds.worldBounds.m_Extents.x;
			    *(_QWORD *)&v21.SortingOrder = 0x3FE38E39447A0000LL;
			    v21.DistToCamera = 60.0;
			    *(_OWORD *)&retstr->position.z = v12;
			    v14 = *(_OWORD *)&v21.SortingOrder;
			  }
			  *(_OWORD *)&retstr->up.x = v13;
			  result = retstr;
			  *(_OWORD *)&retstr->farClipDistance = v14;
			  return result;
			}
			
		}
	
		// Constructors
		public HGDrawCallDetailDumper() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGDrawCallDetailDumper() {} // 0x0000000189B285D8-0x0000000189B28700
		// HGDrawCallDetailDumper()
		void HG::Rendering::Tools::HGDrawCallDetailDumper::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  String__Array *v4; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v5; // rdx
		  VolumetricRenderer_VolumetricBounds *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		  MethodInfo *v9; // [rsp+58h] [rbp+30h]
		  int32_t v10; // [rsp+60h] [rbp+38h]
		  int32_t v11; // [rsp+68h] [rbp+40h]
		  float v12; // [rsp+70h] [rbp+48h]
		  int32_t v13; // [rsp+78h] [rbp+50h]
		  bool v14; // [rsp+80h] [rbp+58h]
		  bool v15; // [rsp+88h] [rbp+60h]
		  MethodInfo *v16; // [rsp+90h] [rbp+68h]
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::System::String, 11LL);
		  v4 = (String__Array *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  sub_180005370(v1, 0LL, "DrawCall Index");
		  sub_180005370(v4, 1LL, "Object Name");
		  sub_180005370(v4, 2LL, "Triangle Count");
		  sub_180005370(v4, 3LL, "Instance Count");
		  sub_180005370(v4, 4LL, "Triangle*Instance");
		  sub_180005370(v4, 5LL, "Percentage");
		  sub_180005370(v4, 6LL, "Shader");
		  sub_180005370(v4, 7LL, "Pass");
		  sub_180005370(v4, 8LL, "Asset Path");
		  sub_180005370(v4, 9LL, "Vert Keywords");
		  sub_180005370(v4, 10LL, "Frag Keywords");
		  TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper->static_fields->s_drawCallRowTitles = v4;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper->static_fields,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14,
		    v15,
		    v16);
		}
		
	
		// Methods
		private static ParsedDrawCallTableContents ParseDrawCallContents(HGDrawCallDetailedStats[] stats, bool sortByTriangleCount = false /* Metadata: 0x02302D49 */) => default; // 0x0000000189B28390-0x0000000189B285D8
		// HGDrawCallDetailDumper+ParsedDrawCallTableContents ParseDrawCallContents(HGDrawCallDetailedStats[], Boolean)
		HGDrawCallDetailDumper_ParsedDrawCallTableContents *HG::Rendering::Tools::HGDrawCallDetailDumper::ParseDrawCallContents(
		        HGDrawCallDetailDumper_ParsedDrawCallTableContents *__return_ptr retstr,
		        HGDrawCallDetailedStats__Array *stats,
		        bool sortByTriangleCount,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t v9; // r12d
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v10; // rdx
		  VolumetricRenderer_VolumetricBounds *v11; // r8
		  Int32__Array **v12; // r9
		  HGDrawCallDetailDumper_DrawCallRowContent__Array *v13; // r15
		  int32_t i; // r14d
		  int v15; // ebx
		  int32_t j; // ebx
		  HGDrawCallDetailDumper_DrawCallRowContent *RowContent; // rax
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  Comparison_1_HG_Rendering_Tools_HGDrawCallDetailDumper_DrawCallRowContent_ *_9__4_0; // rbx
		  Object *v23; // rdi
		  Comparison_1_UnityEngine_UIElements_UIR_UIRenderDevice_AllocToUpdate_ *v24; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v25; // rdx
		  VolumetricRenderer_VolumetricBounds *v26; // r8
		  Int32__Array **v27; // r9
		  HGDrawCallDetailDumper_ParsedDrawCallTableContents v28; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGDrawCallDetailDumper_ParsedDrawCallTableContents *result; // rax
		  MethodInfo *v31; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v32; // [rsp+30h] [rbp-D8h]
		  HGDrawCallDetailDumper_ParsedDrawCallTableContents v33; // [rsp+38h] [rbp-D0h] BYREF
		  HGDrawCallDetailDumper_ParsedDrawCallTableContents v34; // [rsp+48h] [rbp-C0h] BYREF
		  __int128 v35; // [rsp+58h] [rbp-B0h]
		  HGDrawCallDetailedStats v36; // [rsp+68h] [rbp-A0h] BYREF
		  _OWORD v37[5]; // [rsp+88h] [rbp-80h] BYREF
		  HGDrawCallDetailDumper_DrawCallRowContent v38; // [rsp+D8h] [rbp-30h] BYREF
		
		  v33 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1, 0LL);
		    if ( Patch )
		    {
		      v28 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(&v34, Patch, (Object *)stats, sortByTriangleCount, 0LL);
		      goto LABEL_19;
		    }
		    goto LABEL_17;
		  }
		  if ( !stats )
		    goto LABEL_17;
		  v9 = 0;
		  v13 = (HGDrawCallDetailDumper_DrawCallRowContent__Array *)il2cpp_array_new_specific_1(
		                                                              TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent,
		                                                              (unsigned int)stats->max_length.size);
		  for ( i = 0; i < stats->max_length.size; ++i )
		  {
		    v15 = *(_DWORD *)(sub_18047BDE4(stats, i) + 8);
		    v9 += *(_DWORD *)(sub_18047BDE4(stats, i) + 12) * v15;
		  }
		  for ( j = 0; j < stats->max_length.size; ++j )
		  {
		    sub_18047F234(stats, &v34, j);
		    sub_1800036A0(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
		    *(HGDrawCallDetailDumper_ParsedDrawCallTableContents *)&v36.componentInstanceID = v34;
		    *(_OWORD *)&v36.shaderInstanceID = v35;
		    RowContent = HG::Rendering::Tools::HGDrawCallDetailDumper::GetRowContent(&v38, j, v9, &v36, 0LL);
		    if ( !v13 )
		      goto LABEL_17;
		    v18 = *(_OWORD *)&RowContent->triangleCount;
		    v37[0] = *(_OWORD *)&RowContent->drawCallIndex;
		    v19 = *(_OWORD *)&RowContent->shaderName;
		    v37[1] = v18;
		    v20 = *(_OWORD *)&RowContent->assetPath;
		    v37[2] = v19;
		    v21 = *(_OWORD *)&RowContent->vertKeywordNames;
		    v37[3] = v20;
		    v37[4] = v21;
		    sub_180688B38(v13, j, v37);
		  }
		  if ( !sortByTriangleCount )
		    goto LABEL_15;
		  sub_1800036A0(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
		  _9__4_0 = TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c->static_fields->__9__4_0;
		  if ( !_9__4_0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c);
		    v23 = (Object *)TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c->static_fields->__9;
		    v24 = (Comparison_1_UnityEngine_UIElements_UIR_UIRenderDevice_AllocToUpdate_ *)sub_18002C620(TypeInfo::System::Comparison<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>);
		    _9__4_0 = (Comparison_1_HG_Rendering_Tools_HGDrawCallDetailDumper_DrawCallRowContent_ *)v24;
		    if ( v24 )
		    {
		      System::Comparison<UnityEngine::UIElements::UIR::UIRenderDevice::AllocToUpdate>::Comparison(
		        v24,
		        v23,
		        MethodInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c::_ParseDrawCallContents_b__4_0,
		        0LL);
		      TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c->static_fields->__9__4_0 = _9__4_0;
		      sub_18002D1B0(
		        (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper::__c->static_fields->__9__4_0,
		        v25,
		        v26,
		        v27,
		        v31,
		        v32,
		        (int32_t)v33.rowContents,
		        v33.totalTriCount,
		        *(float *)&v34.rowContents,
		        v34.totalTriCount,
		        v35,
		        SBYTE8(v35),
		        *(MethodInfo **)&v36.componentInstanceID);
		      goto LABEL_14;
		    }
		LABEL_17:
		    sub_1800D8260(v8, v7);
		  }
		LABEL_14:
		  Beyond::CollectionExtensions::Sort<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>(
		    v13,
		    _9__4_0,
		    MethodInfo::Beyond::CollectionExtensions::Sort<HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallRowContent>);
		LABEL_15:
		  v33.rowContents = v13;
		  ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *))sub_18002D1B0)(
		    (VolumetricRenderer_VolumetricRenderItem *)&v33,
		    v10,
		    v11,
		    v12,
		    v31,
		    v32);
		  v33.totalTriCount = v9;
		  v28 = v33;
		LABEL_19:
		  result = retstr;
		  *retstr = v28;
		  return result;
		}
		
		private static DrawCallRowContent GetRowContent(int drawCallIndex, int totalTriCount, HGDrawCallDetailedStats stats) => default; // 0x0000000189B28070-0x0000000189B28390
		// HGDrawCallDetailDumper+DrawCallRowContent GetRowContent(Int32, Int32, HGDrawCallDetailedStats)
		HGDrawCallDetailDumper_DrawCallRowContent *HG::Rendering::Tools::HGDrawCallDetailDumper::GetRowContent(
		        HGDrawCallDetailDumper_DrawCallRowContent *__return_ptr retstr,
		        int32_t drawCallIndex,
		        int32_t totalTriCount,
		        HGDrawCallDetailedStats *stats,
		        MethodInfo *method)
		{
		  String *name; // r15
		  String *v10; // r13
		  __int64 v11; // rcx
		  Object_1 *v12; // r14
		  Object_1 *v13; // rcx
		  Object_1 *v14; // rsi
		  Object_1 *v15; // rcx
		  Object_1 *v16; // r12
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v17; // rdx
		  __int64 v18; // rcx
		  Object_1 *v19; // rcx
		  VolumetricRenderer_VolumetricBounds *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v23; // rdx
		  VolumetricRenderer_VolumetricBounds *v24; // r8
		  Int32__Array **v25; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v26; // rdx
		  VolumetricRenderer_VolumetricBounds *v27; // r8
		  Int32__Array **v28; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v29; // rdx
		  VolumetricRenderer_VolumetricBounds *v30; // r8
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v31; // rdx
		  VolumetricRenderer_VolumetricBounds *v32; // r8
		  Int32__Array **v33; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v34; // rdx
		  VolumetricRenderer_VolumetricBounds *v35; // r8
		  Int32__Array **v36; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v37; // rdx
		  VolumetricRenderer_VolumetricBounds *v38; // r8
		  __int64 v39; // r9
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v45; // xmm1
		  HGDrawCallDetailDumper_DrawCallRowContent *v46; // rax
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  HGDrawCallDetailDumper_DrawCallRowContent *result; // rax
		  MethodInfo *v50; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v51; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v52; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v53; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v54; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v55; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v56; // [rsp+28h] [rbp-C1h]
		  MethodInfo *v57; // [rsp+30h] [rbp-B9h]
		  HGDrawCallDetailedStats v58; // [rsp+38h] [rbp-B1h] BYREF
		  __int128 v59; // [rsp+58h] [rbp-91h] BYREF
		  __int128 v60; // [rsp+68h] [rbp-81h]
		  VolumetricRenderer_VolumetricRenderItem v61[2]; // [rsp+78h] [rbp-71h] BYREF
		  char v62; // [rsp+150h] [rbp+67h]
		
		  v62 = drawCallIndex;
		  sub_18033B9D0(&v59, 0LL, 80LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2, 0LL);
		    if ( Patch )
		    {
		      v45 = *(_OWORD *)&stats->shaderInstanceID;
		      *(_OWORD *)&v58.componentInstanceID = *(_OWORD *)&stats->componentInstanceID;
		      *(_OWORD *)&v58.shaderInstanceID = v45;
		      v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		              (HGDrawCallDetailDumper_DrawCallRowContent *)&v61[0].DistToCamera,
		              Patch,
		              drawCallIndex,
		              totalTriCount,
		              &v58,
		              0LL);
		      v47 = *(_OWORD *)&v46->triangleCount;
		      *(_OWORD *)&retstr->drawCallIndex = *(_OWORD *)&v46->drawCallIndex;
		      v48 = *(_OWORD *)&v46->shaderName;
		      *(_OWORD *)&retstr->triangleCount = v47;
		      v42 = *(_OWORD *)&v46->assetPath;
		      *(_OWORD *)&retstr->shaderName = v48;
		      v43 = *(_OWORD *)&v46->vertKeywordNames;
		      goto LABEL_28;
		    }
		    goto LABEL_26;
		  }
		  name = (String *)"Unknown";
		  v10 = (String *)"Unknown";
		  v11 = HIDWORD(*(_QWORD *)&stats->componentInstanceID);
		  *(_QWORD *)&v61[0].SortingOrder = "";
		  v12 = 0LL;
		  v13 = UnityEngine::Resources::InstanceIDToObject(v11, 0LL);
		  if ( v13 && (struct Mesh__Class *)v13->klass == TypeInfo::UnityEngine::Mesh )
		    v12 = v13;
		  v14 = 0LL;
		  v15 = UnityEngine::Resources::InstanceIDToObject(stats->shaderInstanceID, 0LL);
		  if ( v15 && (struct Shader__Class *)v15->klass == TypeInfo::UnityEngine::Shader )
		    v14 = v15;
		  v16 = UnityEngine::Resources::InstanceIDToObject(stats->componentInstanceID, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality(v12, 0LL, 0LL) )
		  {
		    if ( !v12 )
		      goto LABEL_26;
		    v19 = v12;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(v16, 0LL, 0LL) )
		      goto LABEL_15;
		    if ( !v16 )
		      goto LABEL_26;
		    v19 = v16;
		  }
		  name = UnityEngine::Object::get_name(v19, 0LL);
		LABEL_15:
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(v14, 0LL, 0LL) )
		    goto LABEL_18;
		  if ( !v14 )
		LABEL_26:
		    sub_1800D8260(v18, v17);
		  v10 = UnityEngine::Object::get_name(v14, 0LL);
		LABEL_18:
		  *((_QWORD *)&v59 + 1) = name;
		  ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t, float, int32_t, bool))sub_18002D1B0)(
		    (VolumetricRenderer_VolumetricRenderItem *)((char *)&v59 + 8),
		    v17,
		    v20,
		    v21,
		    v50,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v62);
		  v22 = *(_QWORD *)&stats->triCount;
		  *(_QWORD *)&v60 = __PAIR64__(HIDWORD(v22), _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&stats->triCount)));
		  LODWORD(v22) = stats->triCount * HIDWORD(v22);
		  v61[0].Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v10;
		  DWORD2(v60) = v22;
		  *((float *)&v60 + 3) = (float)(int)v22 / (float)totalTriCount;
		  sub_18002D1B0(
		    v61,
		    v23,
		    v24,
		    v25,
		    v51,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v59,
		    SBYTE8(v59),
		    (MethodInfo *)v60);
		  v61[0].material = (Material *)UnityEngine::HyperGryph::HGFastString::IndexToString(
		                                  HIDWORD(*(_QWORD *)&stats->shaderInstanceID),
		                                  0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&v61[0].material,
		    v26,
		    v27,
		    v28,
		    v52,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v59,
		    SBYTE8(v59),
		    (MethodInfo *)v60);
		  *(_QWORD *)&v61[0].bounds.enableBounds = "Unknown";
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&v61[0].bounds,
		    v29,
		    v30,
		    (Int32__Array **)"Unknown",
		    v53,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v59,
		    SBYTE8(v59),
		    (MethodInfo *)v60);
		  *(_QWORD *)&v61[0].bounds.worldBounds.m_Extents.x = UnityEngine::HyperGryph::HGFastString::IndexToString(
		                                                        stats->passVertKeywordsID,
		                                                        0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&v61[0].bounds.worldBounds.m_Extents,
		    v31,
		    v32,
		    v33,
		    v54,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v59,
		    SBYTE8(v59),
		    (MethodInfo *)v60);
		  *(_QWORD *)&v61[0].bounds.worldBounds.m_Extents.z = UnityEngine::HyperGryph::HGFastString::IndexToString(
		                                                        HIDWORD(*(_QWORD *)&stats->passVertKeywordsID),
		                                                        0LL);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&v61[0].bounds.worldBounds.m_Extents.z,
		    v34,
		    v35,
		    v36,
		    v55,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v59,
		    SBYTE8(v59),
		    (MethodInfo *)v60);
		  v39 = 0xFFFFFFFFLL;
		  if ( stats->passVertKeywordsID == -1 && HIDWORD(*(_QWORD *)&stats->passVertKeywordsID) != -1 )
		  {
		    *(_QWORD *)&v61[0].bounds.worldBounds.m_Extents.x = *(_QWORD *)&v61[0].bounds.worldBounds.m_Extents.z;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&v61[0].bounds.worldBounds.m_Extents,
		      v37,
		      v38,
		      (Int32__Array **)0xFFFFFFFFLL,
		      v56,
		      v57,
		      v58.componentInstanceID,
		      v58.triCount,
		      *(float *)&v58.shaderInstanceID,
		      v58.passVertKeywordsID,
		      v59,
		      SBYTE8(v59),
		      (MethodInfo *)v60);
		  }
		  if ( HIDWORD(*(_QWORD *)&stats->passVertKeywordsID) == (_DWORD)v39 && stats->passVertKeywordsID != -1 )
		  {
		    *(_QWORD *)&v61[0].bounds.worldBounds.m_Extents.z = *(_QWORD *)&v61[0].bounds.worldBounds.m_Extents.x;
		    sub_18002D1B0(
		      (VolumetricRenderer_VolumetricRenderItem *)&v61[0].bounds.worldBounds.m_Extents.z,
		      v37,
		      v38,
		      (Int32__Array **)v39,
		      v56,
		      v57,
		      v58.componentInstanceID,
		      v58.triCount,
		      *(float *)&v58.shaderInstanceID,
		      v58.passVertKeywordsID,
		      v59,
		      SBYTE8(v59),
		      (MethodInfo *)v60);
		  }
		  *(_QWORD *)&v61[0].bounds.worldBounds.m_Center.y = *(_QWORD *)&v61[0].SortingOrder;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&v61[0].bounds.worldBounds.m_Center.y,
		    v37,
		    v38,
		    (Int32__Array **)v39,
		    v56,
		    v57,
		    v58.componentInstanceID,
		    v58.triCount,
		    *(float *)&v58.shaderInstanceID,
		    v58.passVertKeywordsID,
		    v59,
		    SBYTE8(v59),
		    (MethodInfo *)v60);
		  v40 = v60;
		  *(_OWORD *)&retstr->drawCallIndex = v59;
		  v41 = *(_OWORD *)&v61[0].Callback;
		  *(_OWORD *)&retstr->triangleCount = v40;
		  v42 = *(_OWORD *)&v61[0].bounds.enableBounds;
		  *(_OWORD *)&retstr->shaderName = v41;
		  v43 = *(_OWORD *)&v61[0].bounds.worldBounds.m_Extents.x;
		LABEL_28:
		  result = retstr;
		  *(_OWORD *)&retstr->assetPath = v42;
		  *(_OWORD *)&retstr->vertKeywordNames = v43;
		  return result;
		}
		
		public static async Task<HGDrawCallDetailedStats[]> FetchRawDrawCallDetails() => default; // 0x0000000189B27FCC-0x0000000189B28070
		// Task`1[UnityEngine.HyperGryph.HGDrawCallDetailedStats[]] FetchRawDrawCallDetails()
		Task_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *HG::Rendering::Tools::HGDrawCallDetailDumper::FetchRawDrawCallDetails(
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v1; // rdx
		  VolumetricRenderer_VolumetricBounds *v2; // r8
		  Int32__Array **v3; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  MethodInfo *v8; // [rsp+20h] [rbp-48h]
		  MethodInfo *v9; // [rsp+28h] [rbp-40h]
		  HGDrawCallDetailDumper_FetchRawDrawCallDetails_d_6 stateMachine; // [rsp+38h] [rbp-30h] BYREF
		
		  *(_QWORD *)&stateMachine.__1__state = 0LL;
		  stateMachine.__u__1.m_task = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(8, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(8, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4(Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
		    memset(&stateMachine.__t__builder, 0, sizeof(stateMachine.__t__builder));
		    ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t))sub_18002D1B0)(
		      (VolumetricRenderer_VolumetricRenderItem *)&stateMachine.__t__builder,
		      v1,
		      v2,
		      v3,
		      v8,
		      v9,
		      0,
		      stateMachine.__1__state);
		    stateMachine.__1__state = -1;
		    System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::Start<HG::Rendering::Tools::HGDrawCallDetailDumper::_FetchRawDrawCallDetails_d__6>(
		      (AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder,
		      &stateMachine,
		      MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::Start<HG::Rendering::Tools::HGDrawCallDetailDumper::_FetchRawDrawCallDetails_d__6>);
		    return (Task_1_UnityEngine_HyperGryph_HGDrawCallDetailedStats_ *)System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::get_Task(
		                                                                       (AsyncTaskMethodBuilder_1_System_Object_ *)&stateMachine.__t__builder,
		                                                                       MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::get_Task);
		  }
		}
		
		public static ParsedDrawCallTableContents FetchDrawCallContents(HGDrawCallDetailedStats[] rawStats, bool ignoreTerrain = true /* Metadata: 0x02302D4A */, bool gbufferOnly = true /* Metadata: 0x02302D4B */) => default; // 0x0000000189B27D90-0x0000000189B27FCC
		public static void DumpCurrentDrawCallStatsToCSV(HGDrawCallDetailedStats[] rawStats, string filePath) {} // 0x0000000189B27920-0x0000000189B27D90
		// Void DumpCurrentDrawCallStatsToCSV(HGDrawCallDetailedStats[], String)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Tools::HGDrawCallDetailDumper::DumpCurrentDrawCallStatsToCSV(
		        HGDrawCallDetailedStats__Array *rawStats,
		        String *filePath,
		        MethodInfo *method)
		{
		  StreamWriter *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  StreamWriter *v8; // rbx
		  String *v9; // rax
		  __int64 v10; // rcx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  int32_t v14; // esi
		  HGDrawCallDetailDumper_DrawCallRowContent__Array *rowContents; // r14
		  String__Array *v16; // rbx
		  Object *v17; // rax
		  String *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  float v21; // rdi^4
		  Object *v22; // rax
		  String *v23; // rax
		  Object *v24; // rax
		  String *v25; // rax
		  Object *v26; // rax
		  String *v27; // rax
		  Object *v28; // rax
		  String *v29; // rax
		  String *v30; // rax
		  __int64 v31; // rcx
		  __int64 v32; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  StreamWriter *v36; // [rsp+20h] [rbp-98h] BYREF
		  _QWORD v37[2]; // [rsp+28h] [rbp-90h] BYREF
		  HGDrawCallDetailDumper_ParsedDrawCallTableContents v38; // [rsp+38h] [rbp-80h] BYREF
		  float v39; // [rsp+50h] [rbp-68h] BYREF
		  __int64 v40; // [rsp+58h] [rbp-60h]
		  float v41; // [rsp+60h] [rbp-58h]
		  float v42; // [rsp+64h] [rbp-54h]
		  float v43; // [rsp+68h] [rbp-50h]
		  float v44; // [rsp+6Ch] [rbp-4Ch]
		  __int64 v45; // [rsp+70h] [rbp-48h]
		  __int64 v46; // [rsp+78h] [rbp-40h]
		  __int64 v47; // [rsp+80h] [rbp-38h]
		  __int64 v48; // [rsp+90h] [rbp-28h]
		  __int64 v49; // [rsp+98h] [rbp-20h]
		  Il2CppExceptionWrapper *v50; // [rsp+A0h] [rbp-18h] BYREF
		  float v51; // [rsp+D8h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(12, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(12, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v35, v34);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)rawStats,
		      (Object *)filePath,
		      0LL);
		  }
		  else if ( rawStats )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
		    v38 = *HG::Rendering::Tools::HGDrawCallDetailDumper::ParseDrawCallContents(&v38, rawStats, 0, 0LL);
		    v5 = (StreamWriter *)sub_18002C620(TypeInfo::System::IO::StreamWriter);
		    v8 = v5;
		    if ( !v5 )
		      sub_1800D8260(v7, v6);
		    System::IO::StreamWriter::StreamWriter(v5, filePath, 0LL);
		    v36 = v8;
		    v37[0] = 0LL;
		    v37[1] = &v36;
		    try
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper);
		      v9 = System::String::Join(
		             0x2Cu,
		             TypeInfo::HG::Rendering::Tools::HGDrawCallDetailDumper->static_fields->s_drawCallRowTitles,
		             0LL);
		      if ( !v36 )
		        sub_1800D8250(v10, 0LL);
		      sub_180052100(19LL, v36, v9);
		      if ( !v36 )
		        sub_1800D8250(v11, 0LL);
		      sub_180003290(10LL, v36);
		      v14 = 0;
		      rowContents = v38.rowContents;
		      while ( 1 )
		      {
		        if ( !rowContents )
		          sub_1800D8250(v13, v12);
		        if ( v14 >= rowContents->max_length.size )
		          break;
		        sub_1805AF574(rowContents, &v39, v14);
		        v16 = (String__Array *)il2cpp_array_new_specific_1(TypeInfo::System::String, 16LL);
		        v51 = v39;
		        v17 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v51);
		        v18 = System::String::Format((String *)"{0},", v17, 0LL);
		        if ( !v16 )
		          sub_1800D8250(v20, v19);
		        sub_180005370(v16, 0LL, v18);
		        sub_180005370(v16, 1LL, v40);
		        sub_180005370(v16, 2LL, ",");
		        v21 = v42;
		        v51 = v41;
		        v22 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v51);
		        v23 = System::String::Format((String *)"{0},", v22, 0LL);
		        sub_180005370(v16, 3LL, v23);
		        v51 = v21;
		        v24 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v51);
		        v25 = System::String::Format((String *)"{0},", v24, 0LL);
		        sub_180005370(v16, 4LL, v25);
		        v51 = v43;
		        v26 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v51);
		        v27 = System::String::Format((String *)"{0},", v26, 0LL);
		        sub_180005370(v16, 5LL, v27);
		        v51 = v44 * 100.0;
		        v28 = (Object *)il2cpp_value_box_0(TypeInfo::System::Single, &v51);
		        v29 = System::String::Format((String *)"{0:F3}%,", v28, 0LL);
		        sub_180005370(v16, 6LL, v29);
		        sub_180005370(v16, 7LL, v45);
		        sub_180005370(v16, 8LL, ",");
		        sub_180005370(v16, 9LL, v46);
		        sub_180005370(v16, 10LL, ",");
		        sub_180005370(v16, 11LL, v47);
		        sub_180005370(v16, 12LL, ",");
		        sub_180005370(v16, 13LL, v48);
		        sub_180005370(v16, 14LL, ",");
		        sub_180005370(v16, 15LL, v49);
		        v30 = System::String::Concat(v16, 0LL);
		        if ( !v36 )
		          sub_1800D8250(v31, 0LL);
		        sub_180052100(19LL, v36, v30);
		        if ( !v36 )
		          sub_1800D8250(v32, 0LL);
		        sub_180003290(10LL, v36);
		        ++v14;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v50 )
		    {
		      v37[0] = v50->ex;
		    }
		    sub_1801F6A10(v37);
		  }
		  else
		  {
		    HG::Rendering::HGRPLogger::LogWarning((String *)"HGDrawCallDetailDumper: Failed to fetch stats!", 0LL);
		  }
		}
		
		public static DrawCallCameraInfo CreateCameraInfo(Camera cam) => default; // 0x0000000189B276DC-0x0000000189B27920
		// HGDrawCallDetailDumper+DrawCallCameraInfo CreateCameraInfo(Camera)
		HGDrawCallDetailDumper_DrawCallCameraInfo *HG::Rendering::Tools::HGDrawCallDetailDumper::CreateCameraInfo(
		        HGDrawCallDetailDumper_DrawCallCameraInfo *__return_ptr retstr,
		        Camera *cam,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v7; // rdx
		  VolumetricRenderer_VolumetricBounds *v8; // r8
		  Int32__Array **v9; // r9
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  MethodInfo *v14; // rdx
		  Vector3 *up; // rax
		  MethodInfo *v16; // xmm3_8
		  MethodInfo *v17; // rdx
		  Vector3 *fwd; // rax
		  MethodInfo *v19; // xmm3_8
		  MethodInfo *v20; // r8
		  Vector3 *v21; // rax
		  MethodInfo *v22; // xmm4_8
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGDrawCallDetailDumper_DrawCallCameraInfo *v27; // rax
		  __int128 v28; // xmm1
		  HGDrawCallDetailDumper_DrawCallCameraInfo *result; // rax
		  MethodInfo *v30; // [rsp+20h] [rbp-89h] BYREF
		  MethodInfo *v31; // [rsp+28h] [rbp-81h]
		  Vector3 v32; // [rsp+30h] [rbp-79h] BYREF
		  HGDrawCallDetailDumper_DrawCallCameraInfo v33; // [rsp+40h] [rbp-69h] BYREF
		  Matrix4x4 v34; // [rsp+80h] [rbp-29h] BYREF
		  Matrix4x4 v35; // [rsp+C0h] [rbp+17h] BYREF
		
		  sub_18033B9D0(&v33, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(13, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(13, 0LL);
		    if ( Patch )
		    {
		      v27 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9(
		              (HGDrawCallDetailDumper_DrawCallCameraInfo *)&v35,
		              Patch,
		              (Object *)cam,
		              0LL);
		      v28 = *(_OWORD *)&v27->position.z;
		      *(_OWORD *)&retstr->cameraName = *(_OWORD *)&v27->cameraName;
		      v24 = *(_OWORD *)&v27->up.x;
		      *(_OWORD *)&retstr->position.z = v28;
		      v25 = *(_OWORD *)&v27->farClipDistance;
		      goto LABEL_9;
		    }
		    goto LABEL_7;
		  }
		  v33 = *HG::Rendering::Tools::HGDrawCallDetailDumper::DrawCallCameraInfo::CreateDefault(
		           (HGDrawCallDetailDumper_DrawCallCameraInfo *)&v34,
		           0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality((Object_1 *)cam, 0LL, 0LL) )
		  {
		    if ( cam )
		    {
		      v33.cameraName = UnityEngine::Object::get_name((Object_1 *)cam, 0LL);
		      ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *, MethodInfo *, int32_t, int32_t))sub_18002D1B0)(
		        (VolumetricRenderer_VolumetricRenderItem *)&v33,
		        v7,
		        v8,
		        v9,
		        v30,
		        v31,
		        SLODWORD(v32.x),
		        SLODWORD(v32.z));
		      v33.nearClipDistance = UnityEngine::Camera::get_nearClipPlane(cam, 0LL);
		      v33.farClipDistance = UnityEngine::Camera::get_farClipPlane(cam, 0LL);
		      v33.aspect = UnityEngine::Camera::get_aspect(cam, 0LL);
		      v33.verticalFoV = UnityEngine::Camera::get_fieldOfView(cam, 0LL);
		      worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v35, cam, 0LL);
		      v11 = *(_OWORD *)&worldToCameraMatrix->m01;
		      *(_OWORD *)&v34.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		      v12 = *(_OWORD *)&worldToCameraMatrix->m02;
		      *(_OWORD *)&v34.m01 = v11;
		      v13 = *(_OWORD *)&worldToCameraMatrix->m03;
		      *(_OWORD *)&v34.m02 = v12;
		      *(_OWORD *)&v34.m03 = v13;
		      v33.position = *UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v30, &v34, 0LL);
		      up = UnityEngine::Vector3::get_up(&v32, v14);
		      v16 = *(MethodInfo **)&up->x;
		      *(float *)&up = up->z;
		      v30 = v16;
		      LODWORD(v31) = (_DWORD)up;
		      v33.up = *UnityEngine::Matrix4x4::MultiplyVector(&v32, &v34, (Vector3 *)&v30, 0LL);
		      fwd = UnityEngine::Vector3::get_fwd(&v32, v17);
		      v19 = *(MethodInfo **)&fwd->x;
		      *(float *)&fwd = fwd->z;
		      v30 = v19;
		      LODWORD(v31) = (_DWORD)fwd;
		      v21 = UnityEngine::Vector3::op_UnaryNegation(&v32, (Vector3 *)&v30, v20);
		      v22 = *(MethodInfo **)&v21->x;
		      *(float *)&v21 = v21->z;
		      v30 = v22;
		      LODWORD(v31) = (_DWORD)v21;
		      v33.direction = *UnityEngine::Matrix4x4::MultiplyVector(&v32, &v34, (Vector3 *)&v30, 0LL);
		      goto LABEL_5;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		LABEL_5:
		  v23 = *(_OWORD *)&v33.position.z;
		  *(_OWORD *)&retstr->cameraName = *(_OWORD *)&v33.cameraName;
		  v24 = *(_OWORD *)&v33.up.x;
		  *(_OWORD *)&retstr->position.z = v23;
		  v25 = *(_OWORD *)&v33.farClipDistance;
		LABEL_9:
		  *(_OWORD *)&retstr->up.x = v24;
		  result = retstr;
		  *(_OWORD *)&retstr->farClipDistance = v25;
		  return result;
		}
		
	}
}
