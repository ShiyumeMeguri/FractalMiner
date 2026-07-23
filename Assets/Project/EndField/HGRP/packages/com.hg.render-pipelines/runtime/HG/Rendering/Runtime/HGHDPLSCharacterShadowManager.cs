using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGHDPLSCharacterShadowManager // TypeDefIndex: 37846
	{
		// Fields
		private const int kMaxRenderRequests = 32; // Metadata: 0x0230318A
		private const int kMaxScreenSpaceLights = 4; // Metadata: 0x0230318B
		private const int kMaxPunctualLightShadowCasters = 56; // Metadata: 0x0230318C
		private HDPLSCharacterShadowRenderRequest[] m_renderRequests; // 0x10
		private int m_renderRequestCount; // 0x18
		private static readonly RenderFunc<HDPLSCharacterShadowPassData> s_renderFunc; // 0x00
		private static readonly RenderFunc<HDPLSCharacterShadowPushDataPassData> s_pushDataRenderFunc; // 0x08
		private static Entity[] s_hdplsLightEntities; // 0x10
		private static int s_hdplsLightCount; // 0x18
		private static PreCulledPair[] s_preCulledPairs; // 0x20
		private static int s_preCulledPairCount; // 0x28
		private static readonly Plane[] s_frustumPlanes; // 0x30
		internal static TextureHandle s_hdplsAtlas; // 0x38
		internal static int[] s_screenSpaceShadowIndices; // 0x48
		private static Matrix4x4[] s_characterWorldToShadowMatrices; // 0x58
		private static Vector4[] s_plsParams; // 0x60
		private static uint[] s_punctualLightShadowHDCharacterIndices; // 0x68
		private static uint[] s_punctualLightShadowSSChannel; // 0x70
		private static Vector4[] s_screenSpaceLightPositions; // 0x78
		private static Vector4 s_plsGlobalParams; // 0x80
	
		// Properties
		internal static bool isActive { get; private set; } // 0x0000000189B42908-0x0000000189B4293C 0x0000000189B4293C-0x0000000189B42980
		// Boolean get_isActive()
		bool HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::get_isActive(MethodInfo *method)
		{
		  struct HGHDPLSCharacterShadowManager__Class *v1; // rax
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		  }
		  return v1->static_fields->_isActive_k__BackingField;
		}
		

		// Void set_isActive(Boolean)
		void HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::set_isActive(bool value, MethodInfo *method)
		{
		  if ( !TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		  TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->_isActive_k__BackingField = value;
		}
		
	
		// Nested types
		private struct HDPLSCharacterShadowRenderRequest // TypeDefIndex: 37841
		{
			// Fields
			public int characterIndex; // 0x00
			public int punctualLightShadowIndex; // 0x04
			public int visibleLightIndex; // 0x08
		}
	
		private class HDPLSCharacterShadowPassData // TypeDefIndex: 37842
		{
			// Fields
			public float shadowDepthBias; // 0x10
			public float shadowNormalBias; // 0x14
			public RectInt renderRegion; // 0x18
			public Matrix4x4 deviceProjYFlip; // 0x28
			public Matrix4x4 view; // 0x68
			public int characterIndex; // 0xA8
			public uint ecsShadowRendererList; // 0xAC
			public TextureHandle targetAtlas; // 0xB0
	
			// Constructors
			public HDPLSCharacterShadowPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class HDPLSCharacterShadowPushDataPassData // TypeDefIndex: 37843
		{
			// Fields
			public Matrix4x4[] characterWorldToShadowMatrices; // 0x10
			public Vector4[] plsParams; // 0x18
			public uint[] punctualLightShadowHDCharacterIndices; // 0x20
			public uint[] punctualLightShadowSSChannel; // 0x28
			public int[] screenSpaceShadowIndices; // 0x30
			public Vector4 atlasTexelSize; // 0x38
			public Vector4[] screenSpaceLightPositions; // 0x48
			public Vector4 globalParams; // 0x50
			public bool isActive; // 0x60
	
			// Constructors
			public HDPLSCharacterShadowPushDataPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private struct PreCulledPair // TypeDefIndex: 37844
		{
			// Fields
			public int visibleLightIndex; // 0x00
			public int characterIndex; // 0x04
		}
	
		// Constructors
		public HGHDPLSCharacterShadowManager() {} // 0x000000018434B640-0x000000018434B670
		// HGHDPLSCharacterShadowManager()
		void HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HGHDPLSCharacterShadowManager(
		        HGHDPLSCharacterShadowManager *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  MethodInfo *v6; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_renderRequests = (HGHDPLSCharacterShadowManager_HDPLSCharacterShadowRenderRequest__Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowRenderRequest, 32LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v6);
		}
		
		static HGHDPLSCharacterShadowManager() {} // 0x00000001848F7F20-0x00000001848F8260
		// HGHDPLSCharacterShadowManager()
		void HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::cctor(MethodInfo *method)
		{
		  struct HGHDPLSCharacterShadowManager_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Type__Class *v6; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // rax
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // rax
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  Array *v28; // rbx
		  Type *v29; // rdx
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **v31; // r9
		  __int64 v32; // rax
		  PropertyInfo_1 *v33; // r8
		  Type *v34; // rdx
		  Int32__Array **v35; // r9
		  __int64 v36; // rax
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  __int64 v40; // rax
		  PropertyInfo_1 *v41; // r8
		  Type *v42; // rdx
		  Int32__Array **v43; // r9
		  __int64 v44; // rax
		  PropertyInfo_1 *v45; // r8
		  Type *v46; // rdx
		  Int32__Array **v47; // r9
		  __int64 v48; // rax
		  Type *v49; // rdx
		  PropertyInfo_1 *v50; // r8
		  Int32__Array **v51; // r9
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		  MethodInfo *v54; // [rsp+20h] [rbp-8h]
		  MethodInfo *v55; // [rsp+20h] [rbp-8h]
		  MethodInfo *v56; // [rsp+20h] [rbp-8h]
		  MethodInfo *v57; // [rsp+20h] [rbp-8h]
		  MethodInfo *v58; // [rsp+20h] [rbp-8h]
		  MethodInfo *v59; // [rsp+20h] [rbp-8h]
		  MethodInfo *v60; // [rsp+20h] [rbp-8h]
		  MethodInfo *v61; // [rsp+20h] [rbp-8h]
		  MethodInfo *v62; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowPassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c::__cctor_b__33_0,
		          0LL),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v52),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowPushDataPassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::__c::__cctor_b__33_1,
		    0LL);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_pushDataRenderFunc,
		    v13,
		    v14,
		    v15,
		    v53);
		  v16 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity, 4LL);
		  v17 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v17->fields._impl.value = (void *)v16;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightEntities,
		    v17,
		    v18,
		    v19,
		    v54);
		  TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightCount = 0;
		  v20 = il2cpp_array_new_specific_1(
		          TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::PreCulledPair,
		          32LL);
		  v21 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v21[1].monitor = (MonitorData *)v20;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairs,
		    v21,
		    v22,
		    v23,
		    v55);
		  TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairCount = 0;
		  v24 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  v25 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v25[2].klass = (Type__Class *)v24;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_frustumPlanes,
		    v25,
		    v26,
		    v27,
		    v56);
		  v28 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 4LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v28,
		    5AC6A5945F16500911219129984BA8B387A06F24FE383CE4E81A73294065461B_Field,
		    0LL);
		  v29 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v29[3].klass = (Type__Class *)v28;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_screenSpaceShadowIndices,
		    v29,
		    v30,
		    v31,
		    v57);
		  v32 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, 32LL);
		  v33 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v33[5].monitor = (MonitorData *)v32;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_characterWorldToShadowMatrices,
		    v34,
		    v33,
		    v35,
		    v58);
		  v36 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 32LL);
		  v37 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v37[4].klass = (Type__Class *)v36;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_plsParams,
		    v37,
		    v38,
		    v39,
		    v59);
		  v40 = il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 56LL);
		  v41 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v41[6].monitor = (MonitorData *)v40;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_punctualLightShadowHDCharacterIndices,
		    v42,
		    v41,
		    v43,
		    v60);
		  v44 = il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 56LL);
		  v45 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v45[7].klass = (PropertyInfo_1__Class *)v44;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_punctualLightShadowSSChannel,
		    v46,
		    v45,
		    v47,
		    v61);
		  v48 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 4LL);
		  v49 = (Type *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  v49[5].klass = (Type__Class *)v48;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_screenSpaceLightPositions,
		    v49,
		    v50,
		    v51,
		    v62);
		}
		
	
		// Methods
		private static void GetShadowParamsFromCharacter(Bounds bounds, ref HGSharedLightData lightData, out Matrix4x4 localToWorldMatrix, out float spotAngle) {
			localToWorldMatrix = default;
			spotAngle = default;
		} // 0x0000000189B46974-0x0000000189B46C38
		// Void GetShadowParamsFromCharacter(Bounds, HGSharedLightData ByRef, Matrix4x4 ByRef, Single ByRef)
		void HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::GetShadowParamsFromCharacter(
		        Bounds *bounds,
		        HGSharedLightData *lightData,
		        Matrix4x4 *localToWorldMatrix,
		        float *spotAngle,
		        MethodInfo *method)
		{
		  Vector3 *worldPosition; // rax
		  __int64 v10; // xmm10_8
		  float z; // r15d
		  float v12; // xmm6_4
		  float v13; // eax
		  MethodInfo *v14; // r9
		  Vector3 *v15; // rax
		  __int64 v16; // xmm9_8
		  float v17; // edi
		  float v18; // xmm0_4
		  Quaternion *rotation; // rax
		  MethodInfo *v20; // rdx
		  __m128i v21; // xmm3
		  Vector3 *one; // rax
		  __int64 v23; // xmm1_8
		  Matrix4x4 *v24; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm2
		  __int128 v27; // xmm3
		  float v28; // xmm0_4
		  int v29; // xmm1_4
		  float v30; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  __int64 v34; // xmm1_8
		  Vector3 v35; // [rsp+38h] [rbp-D0h] BYREF
		  Vector3 v36; // [rsp+48h] [rbp-C0h] BYREF
		  Bounds v37; // [rsp+58h] [rbp-B0h] BYREF
		  Matrix4x4 v38; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v39[2]; // [rsp+B8h] [rbp-50h] BYREF
		
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2167, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2167, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v33, v32);
		    v34 = *(_QWORD *)&bounds->m_Extents.y;
		    *(_OWORD *)&v37.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
		    *(_QWORD *)&v37.m_Extents.y = v34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_866(Patch, &v37, lightData, localToWorldMatrix, spotAngle, 0LL);
		  }
		  else
		  {
		    worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(&v35, lightData, 0LL);
		    v10 = *(_QWORD *)&worldPosition->x;
		    z = worldPosition->z;
		    *(float *)&worldPosition = bounds->m_Extents.z;
		    *(_QWORD *)&v36.x = *(_QWORD *)&bounds->m_Extents.x;
		    LODWORD(v36.z) = (_DWORD)worldPosition;
		    v12 = sub_182F9FF00(&v36);
		    v13 = bounds->m_Center.z;
		    *(_QWORD *)&v35.x = *(_QWORD *)&bounds->m_Center.x;
		    *(_QWORD *)&v36.x = v10;
		    v36.z = z;
		    v35.z = v13;
		    v15 = UnityEngine::Vector3::op_Subtraction(&v37.m_Center, &v35, &v36, v14);
		    v16 = *(_QWORD *)&v15->x;
		    v17 = v15->z;
		    *(_QWORD *)&v35.x = *(_QWORD *)&v15->x;
		    v35.z = v17;
		    v18 = sub_182F9FF00(&v35);
		    if ( v18 <= 0.0000099999997 )
		    {
		      v38 = *UnityEngine::HGSharedLightData::get_localToWorldMatrix(v39, lightData, 0LL);
		      rotation = UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v37, &v38, 0LL);
		    }
		    else
		    {
		      *(_QWORD *)&v35.x = v16;
		      v35.z = v17;
		      rotation = UnityEngine::Quaternion::LookRotation((Quaternion *)&v37, &v35, 0LL);
		    }
		    v21 = _mm_loadu_si128((const __m128i *)rotation);
		    one = UnityEngine::Vector3::get_one(&v37.m_Center, v20);
		    *(_QWORD *)&v36.x = v10;
		    v36.z = z;
		    v23 = *(_QWORD *)&one->x;
		    *(float *)&one = one->z;
		    *(_QWORD *)&v35.x = v23;
		    LODWORD(v35.z) = (_DWORD)one;
		    *(__m128i *)&v37.m_Center.x = v21;
		    v24 = UnityEngine::Matrix4x4::TRS(v39, &v36, (Quaternion *)&v37, &v35, 0LL);
		    v25 = *(_OWORD *)&v24->m01;
		    v26 = *(_OWORD *)&v24->m02;
		    v27 = *(_OWORD *)&v24->m03;
		    *(_OWORD *)&localToWorldMatrix->m00 = *(_OWORD *)&v24->m00;
		    *(_OWORD *)&localToWorldMatrix->m01 = v25;
		    *(_OWORD *)&localToWorldMatrix->m02 = v26;
		    *(_OWORD *)&localToWorldMatrix->m03 = v27;
		    if ( v12 <= 0.000001 )
		    {
		      *spotAngle = 0.1;
		    }
		    else if ( (float)(v12 + 0.0000099999997) >= v18 )
		    {
		      *spotAngle = 179.89999;
		    }
		    else
		    {
		      v28 = sub_180334170();
		      *(float *)&v29 = 0.1;
		      v30 = (float)(v28 + v28) * 57.29578;
		      if ( v30 < 0.1 || (*(float *)&v29 = 179.89999, v30 > 179.89999) )
		        v30 = *(float *)&v29;
		      *spotAngle = v30;
		    }
		  }
		}
		
		internal static void ScanHDPLSCandidateLights(NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams) {} // 0x0000000189B46D2C-0x0000000189B4733C
		// Void ScanHDPLSCandidateLights(NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters)
		void HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::ScanHDPLSCandidateLights(
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParams,
		        MethodInfo *method)
		{
		  MonitorData *monitor; // rdx
		  Component *static_fields; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // edi
		  __int64 v12; // xmm10_8
		  int32_t hdplsRenderCount; // r14d
		  int v14; // r15d
		  Void *m_Buffer; // r12
		  int v16; // eax
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  int v25; // eax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  Vector3 *worldPosition; // rax
		  __int64 v35; // xmm0_8
		  MethodInfo *v36; // r9
		  Vector3 *v37; // rax
		  __int64 v38; // xmm3_8
		  float v39; // xmm7_4
		  float shadowCullDistance_Injected; // xmm6_4
		  float v41; // xmm0_4
		  int v42; // ebx
		  int32_t v43; // edi
		  List_1_System_Object_ *hdplsCharacterHelpers; // rax
		  Object *Item; // rax
		  Bounds *HDPLSBounds; // rax
		  __int128 v47; // xmm7
		  __int64 v48; // xmm6_8
		  Vector3 *v49; // rax
		  __int64 v50; // xmm7_8
		  MethodInfo *v51; // r8
		  Vector3 *v52; // rax
		  __int64 v53; // xmm8_8
		  float shadowFarPlane_Injected; // xmm9_4
		  float v55; // xmm6_4
		  Plane__Array *s_frustumPlanes; // rcx
		  Vector4 *v57; // rax
		  bool v58; // al
		  struct HGHDPLSCharacterShadowManager__Class *v59; // rcx
		  int v60; // r14d
		  HGHDPLSCharacterShadowManager__StaticFields *v61; // rax
		  Entity_1__Array *s_hdplsLightEntities; // rbx
		  __int64 s_hdplsLightCount; // rdi
		  Entity_1 Entity; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  float v66; // [rsp+48h] [rbp-C0h]
		  HGSharedLightData _unity_self; // [rsp+50h] [rbp-B8h] BYREF
		  float v68; // [rsp+58h] [rbp-B0h] BYREF
		  float v69; // [rsp+5Ch] [rbp-ACh]
		  float v70; // [rsp+60h] [rbp-A8h]
		  int32_t v71; // [rsp+64h] [rbp-A4h]
		  __int64 v72; // [rsp+68h] [rbp-A0h]
		  unsigned __int64 v73; // [rsp+70h] [rbp-98h]
		  Vector3 v74; // [rsp+78h] [rbp-90h] BYREF
		  Bounds v75; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v76; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v77; // [rsp+B8h] [rbp-50h] BYREF
		  __int64 v78; // [rsp+C8h] [rbp-40h] BYREF
		  int v79; // [rsp+D0h] [rbp-38h]
		  Vector3 v80; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v81; // [rsp+E8h] [rbp-20h] BYREF
		  Vector3 v82; // [rsp+F8h] [rbp-10h] BYREF
		  Vector3 v83; // [rsp+108h] [rbp+0h] BYREF
		  Vector3 v84; // [rsp+118h] [rbp+10h] BYREF
		  Vector4 v85; // [rsp+128h] [rbp+20h] BYREF
		  Matrix4x4 v86; // [rsp+138h] [rbp+30h] BYREF
		  __int128 v87; // [rsp+178h] [rbp+70h]
		  __int128 v88; // [rsp+188h] [rbp+80h]
		  __int128 v89; // [rsp+198h] [rbp+90h]
		  __int128 v90; // [rsp+1A8h] [rbp+A0h]
		  __int128 v91; // [rsp+1B8h] [rbp+B0h]
		  __int128 v92; // [rsp+1C8h] [rbp+C0h]
		  __int128 v93; // [rsp+1D8h] [rbp+D0h]
		  __int128 v94; // [rsp+1E8h] [rbp+E0h]
		  __int128 v95; // [rsp+1F8h] [rbp+F0h]
		  int v96; // [rsp+208h] [rbp+100h]
		  __int128 v97; // [rsp+218h] [rbp+110h]
		  __int128 v98; // [rsp+228h] [rbp+120h]
		  __int128 v99; // [rsp+238h] [rbp+130h]
		  __int128 v100; // [rsp+248h] [rbp+140h]
		  __int128 v101; // [rsp+258h] [rbp+150h]
		  __int128 v102; // [rsp+268h] [rbp+160h]
		  __int128 v103; // [rsp+278h] [rbp+170h]
		  __int128 v104; // [rsp+288h] [rbp+180h]
		  __int128 v105; // [rsp+298h] [rbp+190h]
		  int v106; // [rsp+2A8h] [rbp+1A0h]
		
		  _unity_self = 0LL;
		  sub_18033B9D0(&v86, 0LL, 64LL);
		  v68 = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2168, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2168, 0LL);
		    if ( Patch )
		    {
		      *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v75.m_Center.x = *visibleLights;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_867(
		        Patch,
		        (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v75,
		        (Object *)hgCamera,
		        (Object *)settingParams,
		        0LL);
		      return;
		    }
		LABEL_39:
		    sub_1800D8260(static_fields, monitor);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		  TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightCount = 0;
		  static_fields = (Component *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		  LODWORD(static_fields[1].fields._.m_CachedPtr) = 0;
		  if ( !hgCamera )
		    goto LABEL_39;
		  static_fields = (Component *)hgCamera->fields.camera;
		  if ( !static_fields )
		    goto LABEL_39;
		  transform = UnityEngine::Component::get_transform(static_fields, 0LL);
		  if ( !transform )
		    goto LABEL_39;
		  position = UnityEngine::Transform::get_position(&v74, transform, 0LL);
		  z = position->z;
		  v12 = *(_QWORD *)&position->x;
		  v66 = z;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  hdplsRenderCount = HG::Rendering::Runtime::HGCharacters::get_hdplsRenderCount(0LL);
		  v71 = hdplsRenderCount;
		  UnityEngine::GeometryUtility::CalculateFrustumPlanes(
		    hgCamera->fields.camera,
		    TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_frustumPlanes,
		    0LL);
		  v14 = 0;
		  if ( visibleLights->m_Length > 0 )
		  {
		    m_Buffer = visibleLights->m_Buffer;
		    LODWORD(v72) = visibleLights->m_Length;
		    do
		    {
		      v16 = *(_DWORD *)&m_Buffer[144];
		      v17 = *(_OWORD *)&m_Buffer[16];
		      v87 = *(_OWORD *)m_Buffer;
		      v18 = *(_OWORD *)&m_Buffer[32];
		      v88 = v17;
		      v19 = *(_OWORD *)&m_Buffer[48];
		      v89 = v18;
		      v20 = *(_OWORD *)&m_Buffer[64];
		      v90 = v19;
		      v21 = *(_OWORD *)&m_Buffer[80];
		      v91 = v20;
		      v22 = *(_OWORD *)&m_Buffer[96];
		      v92 = v21;
		      v23 = *(_OWORD *)&m_Buffer[112];
		      v93 = v22;
		      v24 = *(_OWORD *)&m_Buffer[128];
		      v94 = v23;
		      v95 = v24;
		      v96 = v16;
		      _unity_self = (HGSharedLightData)*((_QWORD *)&v24 + 1);
		      if ( UnityEngine::HGSharedLightData::get_enableHDCharacterShadow_Injected(&_unity_self, 0LL) )
		      {
		        v25 = *(_DWORD *)&m_Buffer[144];
		        v26 = *(_OWORD *)&m_Buffer[16];
		        v97 = *(_OWORD *)m_Buffer;
		        v27 = *(_OWORD *)&m_Buffer[32];
		        v98 = v26;
		        v28 = *(_OWORD *)&m_Buffer[48];
		        v99 = v27;
		        v29 = *(_OWORD *)&m_Buffer[64];
		        v100 = v28;
		        v30 = *(_OWORD *)&m_Buffer[80];
		        v101 = v29;
		        v31 = *(_OWORD *)&m_Buffer[96];
		        v102 = v30;
		        v32 = *(_OWORD *)&m_Buffer[112];
		        v103 = v31;
		        v33 = *(_OWORD *)&m_Buffer[128];
		        v104 = v32;
		        v105 = v33;
		        v106 = v25;
		        if ( !(_DWORD)v97 || UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&_unity_self, 0LL) )
		        {
		          *(_QWORD *)&v76.x = v12;
		          v76.z = z;
		          worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(&v81, &_unity_self, 0LL);
		          v35 = *(_QWORD *)&worldPosition->x;
		          *(float *)&worldPosition = worldPosition->z;
		          *(_QWORD *)&v77.x = v35;
		          LODWORD(v77.z) = (_DWORD)worldPosition;
		          v37 = UnityEngine::Vector3::op_Subtraction(&v82, &v77, &v76, v36);
		          v38 = *(_QWORD *)&v37->x;
		          *(float *)&v37 = v37->z;
		          v78 = v38;
		          v79 = (int)v37;
		          v39 = sub_182F9FF00(&v78);
		          shadowCullDistance_Injected = UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(
		                                          &_unity_self,
		                                          0LL);
		          if ( !settingParams )
		            goto LABEL_39;
		          v41 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                  settingParams->fields._punctualLightForceCullDistance_k__BackingField,
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          if ( v41 <= shadowCullDistance_Injected )
		            shadowCullDistance_Injected = v41;
		          if ( v39 < shadowCullDistance_Injected )
		          {
		            v42 = 0;
		            v43 = 0;
		            if ( hdplsRenderCount > 0 )
		            {
		              do
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		                hdplsCharacterHelpers = (List_1_System_Object_ *)HG::Rendering::Runtime::HGCharacters::get_hdplsCharacterHelpers(0LL);
		                if ( !hdplsCharacterHelpers )
		                  goto LABEL_39;
		                Item = System::Collections::Generic::List<System::Object>::get_Item(
		                         hdplsCharacterHelpers,
		                         v43,
		                         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		                if ( !Item )
		                  goto LABEL_39;
		                HDPLSBounds = HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSBounds(
		                                &v75,
		                                (HGCharacterHelper *)Item,
		                                hgCamera->fields.camera,
		                                0LL);
		                v47 = *(_OWORD *)&HDPLSBounds->m_Center.x;
		                v48 = *(_QWORD *)&HDPLSBounds->m_Extents.y;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		                *(_OWORD *)&v75.m_Center.x = v47;
		                *(_QWORD *)&v75.m_Extents.y = v48;
		                HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::GetShadowParamsFromCharacter(
		                  &v75,
		                  &_unity_self,
		                  &v86,
		                  &v68,
		                  0LL);
		                v49 = UnityEngine::HGSharedLightData::get_worldPosition(&v83, &_unity_self, 0LL);
		                v50 = *(_QWORD *)&v49->x;
		                v70 = v49->z;
		                *(Vector4 *)&v75.m_Center.x = *UnityEngine::Matrix4x4::GetColumn(&v85, &v86, 2, 0LL);
		                v52 = UnityEngine::Vector4::op_Implicit(&v84, (Vector4 *)&v75, v51);
		                v53 = *(_QWORD *)&v52->x;
		                v69 = v52->z;
		                shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		                v55 = (float)(v68 * 0.5) * 0.017453292;
		                s_frustumPlanes = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_frustumPlanes;
		                if ( s_frustumPlanes && s_frustumPlanes->max_length.size )
		                  v57 = (Vector4 *)sub_180002100(s_frustumPlanes, 0LL);
		                else
		                  v57 = 0LL;
		                v80.z = v69;
		                v74.z = v70;
		                *(_QWORD *)&v80.x = v53;
		                *(_QWORD *)&v74.x = v50;
		                v58 = UnityEngine::HyperGryph::HGCullingSystem::CullSpotLightPrecising(
		                        v57,
		                        6,
		                        &v74,
		                        &v80,
		                        shadowFarPlane_Injected,
		                        v55,
		                        0LL);
		                v59 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		                if ( v58 )
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		                  v59 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		                  v60 = v42
		                      + TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairCount;
		                  if ( v60 < 32 )
		                  {
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		                    v73 = __PAIR64__(v43, v14);
		                    static_fields = (Component *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		                    monitor = static_fields[1].monitor;
		                    if ( !monitor )
		                      goto LABEL_39;
		                    if ( (unsigned int)v60 >= *((_DWORD *)monitor + 6) )
		                      goto LABEL_37;
		                    *((_QWORD *)monitor + v60 + 4) = v73;
		                    v59 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		                  }
		                  hdplsRenderCount = v71;
		                  ++v42;
		                }
		                ++v43;
		              }
		              while ( v43 < hdplsRenderCount );
		              if ( v42 > 0 )
		              {
		                sub_1800036A0(v59);
		                if ( v42
		                   + TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairCount <= 32 )
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		                  if ( TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightCount < 4 )
		                  {
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		                    TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairCount += v42;
		                    v61 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		                    s_hdplsLightEntities = v61->s_hdplsLightEntities;
		                    s_hdplsLightCount = v61->s_hdplsLightCount;
		                    Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(_unity_self, 0LL);
		                    if ( !s_hdplsLightEntities )
		                      goto LABEL_39;
		                    if ( (unsigned int)s_hdplsLightCount >= s_hdplsLightEntities->max_length.size )
		LABEL_37:
		                      sub_1800D2AB0(static_fields, monitor);
		                    s_hdplsLightEntities->vector[s_hdplsLightCount] = Entity;
		                    ++TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightCount;
		                  }
		                }
		              }
		            }
		            z = v66;
		          }
		        }
		      }
		      ++v14;
		      m_Buffer += 148;
		    }
		    while ( v14 < (int)v72 );
		  }
		}
		
		internal static bool IsHDPLSLight(Entity entity) => default; // 0x0000000189B46C38-0x0000000189B46D2C
		// Boolean IsHDPLSLight(Entity)
		bool HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::IsHDPLSLight(Entity_1 entity, MethodInfo *method)
		{
		  int32_t v3; // edi
		  struct HGHDPLSCharacterShadowManager__Class *v4; // rcx
		  __int64 v5; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *static_fields; // rcx
		  Entity_1__Array *s_hdplsLightEntities; // rsi
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2173, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2173, 0LL);
		    if ( !Patch )
		LABEL_11:
		      sub_1800D8260(static_fields, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_868(Patch, entity, 0LL);
		  }
		  else
		  {
		    v3 = 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		    v4 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		    if ( TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightCount <= 0 )
		    {
		      return 0;
		    }
		    else
		    {
		      while ( 1 )
		      {
		        sub_1800036A0(v4);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		        s_hdplsLightEntities = static_fields->s_hdplsLightEntities;
		        if ( !s_hdplsLightEntities )
		          goto LABEL_11;
		        sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		        if ( (unsigned int)v3 >= s_hdplsLightEntities->max_length.size )
		          sub_1800D2AB0(v9, v8);
		        if ( UnityEngine::HyperGryph::ECS::Entity::Equals(&s_hdplsLightEntities->vector[v3], entity, 0LL) )
		          return 1;
		        ++v3;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		        v4 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager;
		        if ( v3 >= TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_hdplsLightCount )
		          return 0;
		      }
		    }
		  }
		}
		
		public unsafe void FrameSetup(HGRenderGraph renderGraph, HGSettingParameters settingParams, NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, int* punctualLightIndices, int punctualLightCount, bool screenSpaceShadowEnabled) {} // 0x0000000189B45104-0x0000000189B46974
		// Void FrameSetup(HGRenderGraph, HGSettingParameters, NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, Int32*, Int32, Boolean)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::FrameSetup(
		        HGHDPLSCharacterShadowManager *this,
		        HGRenderGraph *renderGraph,
		        HGSettingParameters *settingParams,
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        HGCamera *hgCamera,
		        int32_t *punctualLightIndices,
		        int32_t punctualLightCount,
		        bool screenSpaceShadowEnabled,
		        MethodInfo *method)
		{
		  HGHDPLSCharacterShadowManager *v9; // r15
		  int v10; // ebx
		  __int64 v11; // rsi
		  __int64 v12; // r13
		  __int64 v13; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *static_fields; // rcx
		  Int32__Array *s_screenSpaceShadowIndices; // r12
		  int v16; // ebx
		  HGSettingParameters *v17; // r13
		  __int64 v18; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *v19; // rcx
		  UInt32__Array *s_punctualLightShadowSSChannel; // r12
		  _QWORD *p_s_renderFunc; // rcx
		  __int64 v22; // r12
		  __int64 v23; // rdx
		  HGGraphicsFeatureManager__StaticFields *v24; // rcx
		  int v25; // esi
		  HGCamera *v26; // r12
		  HGShadowManager *shadowManager; // rbx
		  int32_t v28; // r12d
		  __int64 v29; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *v30; // rcx
		  HGHDPLSCharacterShadowManager_PreCulledPair__Array *s_preCulledPairs; // r13
		  HGHDPLSCharacterShadowManager_PreCulledPair v32; // rbx
		  Void *v33; // rdx
		  Entity_1 Entity; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  int32_t ShadowCacheIndexForCaster; // eax
		  __int64 v38; // rdx
		  __int64 v39; // r13
		  __int64 v40; // rcx
		  int v41; // r12d
		  HGHDPLSCharacterShadowManager__StaticFields *v42; // rcx
		  Int32__Array *v43; // rax
		  __int64 v44; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *v45; // rcx
		  Int32__Array *v46; // r12
		  HGHDPLSCharacterShadowManager__StaticFields *v47; // rcx
		  UInt32__Array *v48; // r12
		  Vector4__Array *s_screenSpaceLightPositions; // r12
		  float x; // xmm7_4
		  float y; // xmm6_4
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  float z; // xmm0_4
		  HGHDPLSCharacterShadowManager_HDPLSCharacterShadowRenderRequest__Array *m_renderRequests; // r12
		  __int64 m_renderRequestCount; // r13
		  __int64 v57; // rax
		  Int32Enum__Enum v58; // eax
		  int32_t v59; // esi
		  int32_t v60; // ebx
		  int v61; // r8d
		  Type *v62; // rdx
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **v64; // r9
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  TextureHandle v67; // xmm10
		  __int64 v68; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *v69; // rcx
		  int i; // ebx
		  HGHDPLSCharacterShadowManager_HDPLSCharacterShadowRenderRequest__Array *v71; // rcx
		  Void *v72; // rax
		  List_1_System_Object_ *hdplsCharacterHelpers; // rax
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  Object *Item; // rax
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  Bounds *HDPLSBounds; // rax
		  __int128 v80; // xmm7
		  __int64 v81; // xmm6_8
		  float shadowNearPlane_Injected; // xmm8_4
		  __int128 v83; // xmm14
		  __int128 v84; // xmm15
		  Matrix4x4 *ShadowTransform; // rax
		  __int128 v86; // xmm8
		  __int128 v87; // xmm11
		  __int128 v88; // xmm12
		  __int128 v89; // xmm13
		  __int64 v90; // rdx
		  __int64 v91; // rcx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v92; // xmm6
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  __int64 v95; // rdx
		  Component *camera; // rcx
		  Transform *transform; // rax
		  __int64 v98; // rdx
		  __int64 v99; // rcx
		  Vector3 *position; // rax
		  __int64 v101; // rdx
		  __int64 v102; // rcx
		  __int64 v103; // xmm7_8
		  __int64 v104; // rdx
		  __int64 v105; // rcx
		  void *v106; // rax
		  __int64 v107; // rdx
		  __int64 v108; // rcx
		  Object *v109; // rax
		  Object *v110; // rax
		  __int64 v111; // rdx
		  __int64 v112; // rcx
		  float v113; // xmm0_4
		  __int64 v114; // rdx
		  __int64 v115; // rcx
		  float v116; // xmm0_4
		  Object *v117; // rcx
		  ProfilingSampler *v118; // rdx
		  __int64 v119; // r8
		  __int64 v120; // r9
		  void *s_punctualLightShadowHDCharacterIndices; // rcx
		  _DWORD *v122; // rax
		  int32_t v123; // ebx
		  MethodInfo *v124; // rdx
		  __int64 v125; // rdx
		  __int64 v126; // rcx
		  Object *v127; // rbx
		  MethodInfo *v128; // rcx
		  bool isActive; // al
		  __int64 v130; // rdx
		  __int64 v131; // rcx
		  Object *v132; // rdx
		  HGHDPLSCharacterShadowManager__StaticFields *v133; // rcx
		  int v134; // r8d
		  unsigned __int64 v135; // r10
		  signed __int64 v136; // rtt
		  Object *v137; // r10
		  HGHDPLSCharacterShadowManager__StaticFields *v138; // rcx
		  unsigned __int64 v139; // r8
		  unsigned __int64 v140; // r10
		  char v141; // r8
		  signed __int64 v142; // rtt
		  Object *v143; // r10
		  HGHDPLSCharacterShadowManager__StaticFields *v144; // rcx
		  unsigned __int64 v145; // r8
		  unsigned __int64 v146; // r10
		  char v147; // r8
		  signed __int64 v148; // rtt
		  Object *v149; // r10
		  HGHDPLSCharacterShadowManager__StaticFields *v150; // rcx
		  unsigned __int64 v151; // r8
		  unsigned __int64 v152; // r10
		  char v153; // r8
		  signed __int64 v154; // rtt
		  Object *v155; // r10
		  HGHDPLSCharacterShadowManager__StaticFields *v156; // rcx
		  unsigned __int64 v157; // r8
		  unsigned __int64 v158; // r10
		  char v159; // r8
		  signed __int64 v160; // rtt
		  Object *v161; // r10
		  HGHDPLSCharacterShadowManager__StaticFields *v162; // rcx
		  unsigned __int64 v163; // r8
		  unsigned __int64 v164; // r9
		  char v165; // r8
		  signed __int64 v166; // rtt
		  HGHDPLSCharacterShadowManager__StaticFields *v167; // rcx
		  __m128i v168; // xmm0
		  MethodInfo *methoda; // [rsp+20h] [rbp-6A8h]
		  HGRenderKeyword__Enum v170; // [rsp+28h] [rbp-6A0h]
		  Object *v171; // [rsp+50h] [rbp-678h] BYREF
		  int v172; // [rsp+58h] [rbp-670h]
		  Object *v173; // [rsp+60h] [rbp-668h] BYREF
		  int32_t index[2]; // [rsp+68h] [rbp-660h]
		  int32_t visibleLightIndex; // [rsp+70h] [rbp-658h]
		  LightCaster v176; // [rsp+80h] [rbp-648h] BYREF
		  float v177; // [rsp+90h] [rbp-638h] BYREF
		  int v178; // [rsp+94h] [rbp-634h]
		  int v179; // [rsp+98h] [rbp-630h]
		  Object *v180; // [rsp+A0h] [rbp-628h]
		  int v181; // [rsp+A8h] [rbp-620h]
		  HGSharedLightData _unity_self; // [rsp+B0h] [rbp-618h] BYREF
		  Vector4 v183; // [rsp+B8h] [rbp-610h] BYREF
		  HGHDPLSCharacterShadowManager_PreCulledPair v184; // [rsp+C8h] [rbp-600h]
		  HGSharedLightData v185; // [rsp+D0h] [rbp-5F8h] BYREF
		  HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // [rsp+D8h] [rbp-5F0h]
		  Il2CppException *ex; // [rsp+E0h] [rbp-5E8h] BYREF
		  HGRenderGraphBuilder *v188; // [rsp+E8h] [rbp-5E0h]
		  Vector3 v189; // [rsp+F0h] [rbp-5D8h] BYREF
		  int v190; // [rsp+100h] [rbp-5C8h]
		  int32_t v191; // [rsp+104h] [rbp-5C4h]
		  int v192; // [rsp+108h] [rbp-5C0h]
		  int v193; // [rsp+10Ch] [rbp-5BCh]
		  int v194; // [rsp+110h] [rbp-5B8h]
		  LightCaster v195; // [rsp+120h] [rbp-5A8h] BYREF
		  __int128 v196; // [rsp+130h] [rbp-598h]
		  Bounds v197; // [rsp+140h] [rbp-588h] BYREF
		  Matrix4x4 v198; // [rsp+160h] [rbp-568h] BYREF
		  Vector3 v199; // [rsp+1A0h] [rbp-528h] BYREF
		  HGRenderGraphBuilder v200; // [rsp+1B0h] [rbp-518h] BYREF
		  HGRenderGraphBuilder v201; // [rsp+1D0h] [rbp-4F8h] BYREF
		  TextureDesc v202; // [rsp+1F0h] [rbp-4D8h] BYREF
		  Matrix4x4 v203; // [rsp+250h] [rbp-478h] BYREF
		  Il2CppExceptionWrapper *v204; // [rsp+290h] [rbp-438h] BYREF
		  Il2CppExceptionWrapper *v205; // [rsp+298h] [rbp-430h] BYREF
		  HGRenderGraphBuilder v206; // [rsp+2A0h] [rbp-428h] BYREF
		  __int128 v207; // [rsp+2C0h] [rbp-408h]
		  __int128 v208; // [rsp+2D0h] [rbp-3F8h]
		  __int128 v209; // [rsp+2E0h] [rbp-3E8h]
		  __int128 v210; // [rsp+2F0h] [rbp-3D8h]
		  Matrix4x4 v211; // [rsp+300h] [rbp-3C8h] BYREF
		  Matrix4x4 v212; // [rsp+340h] [rbp-388h] BYREF
		  Matrix4x4 v213; // [rsp+380h] [rbp-348h] BYREF
		  Matrix4x4 v214; // [rsp+3C0h] [rbp-308h] BYREF
		  TextureDesc v215; // [rsp+400h] [rbp-2C8h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v216; // [rsp+460h] [rbp-268h] BYREF
		  __int128 v217; // [rsp+470h] [rbp-258h]
		  __int128 v218; // [rsp+480h] [rbp-248h]
		  __int128 v219; // [rsp+490h] [rbp-238h]
		  __int128 v220; // [rsp+4A0h] [rbp-228h]
		  __int128 v221; // [rsp+4B0h] [rbp-218h]
		  __int128 v222; // [rsp+4C0h] [rbp-208h]
		  __int128 v223; // [rsp+4D0h] [rbp-1F8h]
		  __int128 v224; // [rsp+4E0h] [rbp-1E8h]
		  __int128 v225; // [rsp+4F0h] [rbp-1D8h]
		  int v226; // [rsp+500h] [rbp-1C8h]
		  Matrix4x4 v227; // [rsp+510h] [rbp-1B8h] BYREF
		  __int128 v228; // [rsp+550h] [rbp-178h]
		  __int128 v229; // [rsp+560h] [rbp-168h]
		  __int128 v230; // [rsp+570h] [rbp-158h]
		  __int128 v231; // [rsp+580h] [rbp-148h]
		  __int128 v232; // [rsp+590h] [rbp-138h]
		  __int128 v233; // [rsp+5A0h] [rbp-128h]
		  __int128 v234; // [rsp+5B0h] [rbp-118h]
		  __int128 v235; // [rsp+5C0h] [rbp-108h]
		  __int128 v236; // [rsp+5D0h] [rbp-F8h]
		  int v237; // [rsp+5E0h] [rbp-E8h]
		  int32_t v242; // [rsp+708h] [rbp+40h]
		  int v243; // [rsp+708h] [rbp+40h]
		
		  v9 = this;
		  v185 = 0LL;
		  *(_QWORD *)index = 0LL;
		  visibleLightIndex = 0;
		  sub_18033B9D0(&v215, 0LL, 96LL);
		  sub_18033B9D0(&v202, 0LL, 96LL);
		  _unity_self = 0LL;
		  sub_18033B9D0(&v212, 0LL, 64LL);
		  v177 = 0.0;
		  sub_18033B9D0(&v211, 0LL, 64LL);
		  sub_18033B9D0(&v213, 0LL, 64LL);
		  sub_18033B9D0(&v214, 0LL, 64LL);
		  v196 = 0LL;
		  memset(&v200, 0, sizeof(v200));
		  v173 = 0LL;
		  memset(&v201, 0, sizeof(v201));
		  v171 = 0LL;
		  v9->fields.m_renderRequestCount = 0;
		  v10 = 0;
		  v11 = 32LL;
		  v12 = 32LL;
		  do
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    s_screenSpaceShadowIndices = static_fields->s_screenSpaceShadowIndices;
		    if ( !s_screenSpaceShadowIndices )
		      sub_1800D8260(static_fields, v13);
		    if ( (unsigned int)v10 >= s_screenSpaceShadowIndices->max_length.size )
		      sub_1800D2AB0(static_fields, v13);
		    *(_DWORD *)((char *)&s_screenSpaceShadowIndices->klass + v12) = -1;
		    ++v10;
		    v12 += 4LL;
		  }
		  while ( v10 < 4 );
		  v16 = 0;
		  v17 = settingParams;
		  do
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		    v19 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    s_punctualLightShadowSSChannel = v19->s_punctualLightShadowSSChannel;
		    if ( !s_punctualLightShadowSSChannel )
		      sub_1800D8260(v19, v18);
		    if ( (unsigned int)v16 >= s_punctualLightShadowSSChannel->max_length.size )
		      sub_1800D2AB0(v19, v18);
		    *(_DWORD *)((char *)&s_punctualLightShadowSSChannel->klass + v11) = 0;
		    p_s_renderFunc = &TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_renderFunc;
		    v22 = p_s_renderFunc[13];
		    if ( !v22 )
		      sub_1800D8260(p_s_renderFunc, v18);
		    if ( (unsigned int)v16 >= *(_DWORD *)(v22 + 24) )
		      sub_1800D2AB0(p_s_renderFunc, v18);
		    *(_DWORD *)(v22 + v11) = 0;
		    ++v16;
		    v11 += 4LL;
		  }
		  while ( v16 < 56 );
		  if ( !screenSpaceShadowEnabled )
		    goto LABEL_45;
		  if ( !settingParams )
		    sub_1800D8260(p_s_renderFunc, v18);
		  if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          settingParams->fields._hdplsCharacterShadowEnabled_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    goto LABEL_45;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		  v24 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		  if ( !v24->hdplsCharacterShadow )
		    sub_1800D8260(v24, v23);
		  if ( !HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(v24->hdplsCharacterShadow, 0LL)
		    || (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters),
		        p_s_renderFunc = &TypeInfo::HG::Rendering::Runtime::HGCharacters->_0.image,
		        !TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->instance)
		    || (sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters),
		        HG::Rendering::Runtime::HGCharacters::get_hdplsRenderCount(0LL) < 1) )
		  {
		LABEL_45:
		    v26 = hgCamera;
		    goto LABEL_46;
		  }
		  v25 = 0;
		  v26 = hgCamera;
		  if ( !hgCamera )
		    sub_1800D8260(p_s_renderFunc, v18);
		  shadowManager = hgCamera->fields.shadowManager;
		  if ( !shadowManager )
		    sub_1800D8260(p_s_renderFunc, v18);
		  m_punctualLightShadowManagerV2 = shadowManager->fields.m_punctualLightShadowManagerV2;
		  v242 = 0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		  p_s_renderFunc = &TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->_0.image;
		  if ( TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairCount > 0 )
		  {
		    v28 = 0;
		    do
		    {
		      sub_1800036A0(p_s_renderFunc);
		      v30 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		      s_preCulledPairs = v30->s_preCulledPairs;
		      if ( !s_preCulledPairs )
		        sub_1800D8260(v30, v29);
		      if ( (unsigned int)v28 >= s_preCulledPairs->max_length.size )
		        sub_1800D2AB0(v30, v29);
		      v32 = s_preCulledPairs->vector[v28];
		      v184 = v32;
		      v33 = &visibleLights->m_Buffer[148 * v32.visibleLightIndex];
		      v217 = *(_OWORD *)v33;
		      v218 = *(_OWORD *)&v33[16];
		      v219 = *(_OWORD *)&v33[32];
		      v220 = *(_OWORD *)&v33[48];
		      v221 = *(_OWORD *)&v33[64];
		      v222 = *(_OWORD *)&v33[80];
		      v223 = *(_OWORD *)&v33[96];
		      v224 = *(_OWORD *)&v33[112];
		      v225 = *(_OWORD *)&v33[128];
		      v226 = *(_DWORD *)&v33[144];
		      v228 = *(_OWORD *)v33;
		      v229 = *(_OWORD *)&v33[16];
		      v230 = *(_OWORD *)&v33[32];
		      v231 = *(_OWORD *)&v33[48];
		      v232 = *(_OWORD *)&v33[64];
		      v233 = *(_OWORD *)&v33[80];
		      v234 = *(_OWORD *)&v33[96];
		      v235 = *(_OWORD *)&v33[112];
		      v236 = *(_OWORD *)&v33[128];
		      v237 = v226;
		      Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(
		                 *(HGSharedLightData *)((char *)&v236 + 8),
		                 0LL);
		      v176 = 0LL;
		      HG::Rendering::Runtime::LightCaster::LightCaster(&v176, Entity, 0, 0LL);
		      if ( !m_punctualLightShadowManagerV2 )
		        sub_1800D8260(v36, v35);
		      v195 = v176;
		      ShadowCacheIndexForCaster = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		                                    m_punctualLightShadowManagerV2,
		                                    &v195,
		                                    0LL);
		      v39 = ShadowCacheIndexForCaster;
		      if ( ShadowCacheIndexForCaster >= 0 )
		      {
		        v40 = *((_QWORD *)&v225 + 1);
		        v185 = (HGSharedLightData)*((_QWORD *)&v225 + 1);
		        v41 = 0;
		        if ( v25 <= 0 )
		          goto LABEL_33;
		        while ( 1 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		          v42 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		          v43 = v42->s_screenSpaceShadowIndices;
		          if ( !v43 )
		            sub_1800D8260(v42, v38);
		          v40 = v41;
		          if ( (unsigned int)v41 >= v43->max_length.size )
		            sub_1800D2AB0(v41, v38);
		          if ( v43->vector[v41] == (_DWORD)v39 )
		            break;
		          if ( ++v41 >= v25 )
		            goto LABEL_33;
		        }
		        if ( v41 < 0 )
		        {
		LABEL_33:
		          if ( v25 < 4 )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		            v45 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		            v46 = v45->s_screenSpaceShadowIndices;
		            if ( !v46 )
		              sub_1800D8260(v45, v44);
		            if ( (unsigned int)v25 >= v46->max_length.size )
		              sub_1800D2AB0(v45, v44);
		            v46->vector[v25] = v39;
		            v47 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		            v48 = v47->s_punctualLightShadowSSChannel;
		            if ( !v48 )
		              sub_1800D8260(v47, v44);
		            if ( (unsigned int)v39 >= v48->max_length.size )
		              sub_1800D2AB0(v47, v44);
		            v48->vector[v39] = v25 + 1;
		            s_screenSpaceLightPositions = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_screenSpaceLightPositions;
		            x = UnityEngine::HGSharedLightData::get_worldPosition(&v199, &v185, 0LL)->x;
		            y = UnityEngine::HGSharedLightData::get_worldPosition(&v189, &v185, 0LL)->y;
		            z = UnityEngine::HGSharedLightData::get_worldPosition((Vector3 *)&v198, &v185, 0LL)->z;
		            *(_QWORD *)&v183.x = __PAIR64__(LODWORD(y), LODWORD(x));
		            *(_QWORD *)&v183.z = LODWORD(z);
		            if ( !s_screenSpaceLightPositions )
		              sub_1800D8260(v53, v52);
		            v195 = (LightCaster)v183;
		            sub_18003FEF0(s_screenSpaceLightPositions, v25++, &v195);
		          }
		        }
		        index[0] = v184.characterIndex;
		        index[1] = v39;
		        m_renderRequests = v9->fields.m_renderRequests;
		        m_renderRequestCount = v9->fields.m_renderRequestCount;
		        if ( !m_renderRequests )
		          sub_1800D8260(v40, v38);
		        if ( (unsigned int)m_renderRequestCount >= m_renderRequests->max_length.size )
		          sub_1800D2AB0(v40, v38);
		        v57 = m_renderRequestCount;
		        *(_QWORD *)&m_renderRequests->vector[v57].characterIndex = *(_QWORD *)index;
		        m_renderRequests->vector[v57].visibleLightIndex = v32.visibleLightIndex;
		        ++v9->fields.m_renderRequestCount;
		        v28 = v242;
		      }
		      v242 = ++v28;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		      p_s_renderFunc = &TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->_0.image;
		    }
		    while ( v28 < TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_preCulledPairCount );
		    v17 = settingParams;
		    goto LABEL_45;
		  }
		LABEL_46:
		  if ( !v17 )
		    sub_1800D8260(p_s_renderFunc, v18);
		  v58 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)v17->fields._hdplsAtlasHeight_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v59 = 256;
		  if ( (int)v58 > 256 )
		    v59 = v58;
		  v191 = v59;
		  v60 = 2 * v59;
		  v184.visibleLightIndex = 2 * v59;
		  v183 = (Vector4)COERCE_UNSIGNED_INT(
		                    HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                      v17->fields._hdplsSoftness_k__BackingField,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit));
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		  TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_plsGlobalParams = v183;
		  if ( v9->fields.m_renderRequestCount > 0 )
		  {
		    v61 = v59 / 2;
		    if ( v9->fields.m_renderRequestCount > 8u )
		      v61 = v59 / 4;
		    v243 = v61;
		    v190 = v60 / v61;
		    v193 = v60 / v61;
		    v194 = v59 / v61;
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v202, v60, v59, 0LL);
		    v202.depthBufferBits = 16;
		    v202.colorFormat = 90;
		    v202.filterMode = 1;
		    v202.wrapMode = 1;
		    v202.isShadowMap = 1;
		    v202.dimension = 2;
		    v202.clearBuffer = 1;
		    v202.name = (String *)"HDCharacterPLShadowmap";
		    sub_18002D1B0((SingleFieldAccessor *)&v202.name, v62, v63, v64, methoda);
		    v215 = v202;
		    if ( !renderGraph )
		      sub_1800D8260(v66, v65);
		    v67 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		             (TextureHandle *)&v197,
		             renderGraph,
		             &v215,
		             0LL);
		    v195 = (LightCaster)v67;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		    v69 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    v69->s_hdplsAtlas = v67;
		    if ( !v26 )
		      sub_1800D8260(v69, v68);
		    m_punctualLightShadowManagerV2 = (HGPunctualLightShadowManagerV2 *)v26->fields.camera;
		    for ( i = 0; ; ++i )
		    {
		      v172 = i;
		      if ( i >= v9->fields.m_renderRequestCount )
		        break;
		      v71 = v9->fields.m_renderRequests;
		      if ( !v71 )
		        sub_1800D8260(0LL, v68);
		      if ( (unsigned int)i >= v71->max_length.size )
		        sub_1800D2AB0(v71, v68);
		      *(_QWORD *)index = *(_QWORD *)&v71->vector[i].characterIndex;
		      visibleLightIndex = v71->vector[i].visibleLightIndex;
		      v72 = &visibleLights->m_Buffer[148 * visibleLightIndex];
		      v217 = *(_OWORD *)v72;
		      v218 = *(_OWORD *)&v72[16];
		      v219 = *(_OWORD *)&v72[32];
		      v220 = *(_OWORD *)&v72[48];
		      v221 = *(_OWORD *)&v72[64];
		      v222 = *(_OWORD *)&v72[80];
		      v223 = *(_OWORD *)&v72[96];
		      v224 = *(_OWORD *)&v72[112];
		      v225 = *(_OWORD *)&v72[128];
		      v226 = *(_DWORD *)&v72[144];
		      _unity_self = (HGSharedLightData)*((_QWORD *)&v225 + 1);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      hdplsCharacterHelpers = (List_1_System_Object_ *)HG::Rendering::Runtime::HGCharacters::get_hdplsCharacterHelpers(0LL);
		      if ( !hdplsCharacterHelpers )
		        sub_1800D8260(v75, v74);
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               hdplsCharacterHelpers,
		               index[0],
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		      v180 = Item;
		      if ( !Item )
		        sub_1800D8260(v78, v77);
		      HDPLSBounds = HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSBounds(
		                      &v197,
		                      (HGCharacterHelper *)Item,
		                      (Camera *)m_punctualLightShadowManagerV2,
		                      0LL);
		      v80 = *(_OWORD *)&HDPLSBounds->m_Center.x;
		      v81 = *(_QWORD *)&HDPLSBounds->m_Extents.y;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		      *(_OWORD *)&v197.m_Center.x = v80;
		      *(_QWORD *)&v197.m_Extents.y = v81;
		      HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::GetShadowParamsFromCharacter(
		        &v197,
		        &_unity_self,
		        &v212,
		        &v177,
		        0LL);
		      shadowNearPlane_Injected = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
		      LODWORD(v80) = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		      LODWORD(v81) = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(&_unity_self, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		      v198 = v212;
		      HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		        &v203,
		        &v198,
		        v177,
		        shadowNearPlane_Injected,
		        *(float *)&v80,
		        *(float *)&v81,
		        &v211,
		        &v213,
		        &v214,
		        0LL);
		      v83 = *(_OWORD *)&v211.m00;
		      v198 = v211;
		      v84 = *(_OWORD *)&v211.m01;
		      v203 = v213;
		      ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v227, &v203, &v198, 0LL);
		      v86 = *(_OWORD *)&ShadowTransform->m00;
		      v207 = *(_OWORD *)&ShadowTransform->m00;
		      v87 = *(_OWORD *)&ShadowTransform->m01;
		      v208 = v87;
		      v88 = *(_OWORD *)&ShadowTransform->m02;
		      v209 = v88;
		      v89 = *(_OWORD *)&ShadowTransform->m03;
		      v210 = v89;
		      v90 = (unsigned int)(i >> 31);
		      LODWORD(v90) = i % v190;
		      v178 = i % v190;
		      v179 = i / v190;
		      v192 = i % v190;
		      v181 = i / v190;
		      v91 = (unsigned int)(v243 * (i % v190));
		      LODWORD(v196) = v243 * (i % v190);
		      DWORD1(v196) = v243 * (i / v190);
		      DWORD2(v196) = v243;
		      HIDWORD(v196) = v243;
		      if ( !v26 )
		        sub_1800D8260(v91, v90);
		      *(_QWORD *)&v198.m00 = v26->fields.camera;
		      if ( !v180 )
		        sub_1800D8260(v91, v90);
		      v92 = *HG::Rendering::Runtime::HGCharacterHelper::GetHDPLSShadowEntities(
		               &v216,
		               (HGCharacterHelper *)v180,
		               *(Camera **)&v198.m00,
		               0LL);
		      *(NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *)&v197.m_Center.x = v92;
		      *(_QWORD *)&v198.m00 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                               (Int32Enum__Enum)0x81u,
		                               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v94, v93);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        (HGRenderGraphBuilder *)&v198,
		        renderGraph,
		        (String *)"Render HDPLS Character ShadowMap",
		        &v173,
		        *(ProfilingSampler **)&v198.m00,
		        1,
		        ProfilingHGPass__Enum_Shadow,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowPassData>);
		      *(_OWORD *)&v200.m_RenderPass = *(_OWORD *)&v198.m00;
		      *(_OWORD *)&v200.m_RenderGraph = *(_OWORD *)&v198.m01;
		      ex = 0LL;
		      v188 = &v200;
		      try
		      {
		        *(_QWORD *)&v189.x = v173;
		        camera = (Component *)v26->fields.camera;
		        if ( !camera )
		          sub_1800D8250(0LL, v95);
		        transform = UnityEngine::Component::get_transform(camera, 0LL);
		        if ( !transform )
		          sub_1800D8250(v99, v98);
		        position = UnityEngine::Transform::get_position((Vector3 *)&v183, transform, 0LL);
		        v103 = *(_QWORD *)&position->x;
		        *(float *)&v180 = position->z;
		        if ( !renderGraph )
		          sub_1800D8250(v102, v101);
		        *(_QWORD *)&v198.m00 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		        if ( !*(_QWORD *)&v198.m00 )
		          sub_1800D8250(v105, v104);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        v106 = *(void **)(*(_QWORD *)&v198.m00 + 16LL);
		        *(_QWORD *)&v199.x = v103;
		        LODWORD(v199.z) = (_DWORD)v180;
		        *(NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *)&v198.m00 = v92;
		        LOWORD(v170) = 0;
		        v108 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererListFromEntities(
		                 (NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *)&v198,
		                 &v199,
		                 HGRenderFlags__Enum_None,
		                 HGRenderFlags__Enum_None,
		                 HGShaderLightMode__Enum_ShadowCaster,
		                 v170,
		                 v106,
		                 0xFFFFFFFF,
		                 0LL);
		        if ( !*(_QWORD *)&v189.x )
		          sub_1800D8250(v108, v107);
		        *(_DWORD *)(*(_QWORD *)&v189.x + 172LL) = v108;
		        if ( !v173 )
		          sub_1800D8250(v108, v107);
		        *(_OWORD *)&v173[1].monitor = v196;
		        v109 = v173;
		        if ( !v173 )
		          sub_1800D8250(v108, v107);
		        *(Object *)((char *)v173 + 40) = *(Object *)&v214.m00;
		        *(Object *)((char *)v109 + 56) = *(Object *)&v214.m01;
		        *(Object *)((char *)v109 + 72) = *(Object *)&v214.m02;
		        *(Object *)((char *)v109 + 88) = *(Object *)&v214.m03;
		        v110 = v173;
		        if ( !v173 )
		          sub_1800D8250(v108, v107);
		        *(_OWORD *)&v173[6].monitor = v83;
		        *(_OWORD *)&v110[7].monitor = v84;
		        *(Object *)((char *)v110 + 136) = *(Object *)&v211.m02;
		        *(Object *)((char *)v110 + 152) = *(Object *)&v211.m03;
		        *(_QWORD *)&v189.x = v173;
		        if ( !v17 )
		          sub_1800D8250(v108, v107);
		        v113 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                 v17->fields._hdplsDepthBias_k__BackingField,
		                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		        if ( !*(_QWORD *)&v189.x )
		          sub_1800D8250(v112, v111);
		        *(float *)(*(_QWORD *)&v189.x + 16LL) = v113;
		        *(_QWORD *)&v189.x = v173;
		        v116 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                 v17->fields._hdplsNormalBias_k__BackingField,
		                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		        if ( !*(_QWORD *)&v189.x )
		          sub_1800D8250(v115, v114);
		        *(float *)(*(_QWORD *)&v189.x + 20LL) = v116;
		        v117 = v173;
		        if ( !v173 )
		          sub_1800D8250(0LL, v114);
		        LODWORD(v173[10].monitor) = index[0];
		        if ( !v173 )
		          sub_1800D8250(v117, v114);
		        v173[11] = (Object)v67;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v206,
		          &v200,
		          (TextureHandle *)&v195,
		          DepthAccess__Enum_Write,
		          (RenderBufferLoadAction__Enum)(i == 0),
		          RenderBufferStoreAction__Enum_Store,
		          1.0,
		          0,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v200, 0, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v200,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_renderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v204 )
		      {
		        ex = v204->ex;
		        sub_180268AE0(&ex);
		        v9 = this;
		        v59 = v191;
		        i = v172;
		        v89 = v210;
		        v88 = v209;
		        v87 = v208;
		        v86 = v207;
		        v178 = v192;
		        v179 = v181;
		        v17 = settingParams;
		        v26 = hgCamera;
		        goto LABEL_79;
		      }
		      sub_180268AE0(&ex);
		LABEL_79:
		      Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose(
		        (NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ *)&v197,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		      s_punctualLightShadowHDCharacterIndices = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_punctualLightShadowHDCharacterIndices;
		      if ( !s_punctualLightShadowHDCharacterIndices )
		        goto LABEL_118;
		      v122 = (_DWORD *)sub_180002EB0(s_punctualLightShadowHDCharacterIndices, index[1], v119, v120);
		      *v122 |= 1 << (i & 0x1F);
		      v118 = (ProfilingSampler *)(unsigned int)v193;
		      s_punctualLightShadowHDCharacterIndices = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_plsParams;
		      *(float *)&v176.lightEntity.globalIndex = (float)v178 / (float)v193;
		      *(float *)&v176.lightEntity.version = (float)v179 / (float)v194;
		      *(float *)&v176.index = (float)(1.0 / (float)v193) + *(float *)&v176.lightEntity.globalIndex;
		      *(float *)&v176.m_cachedHashCode = (float)(1.0 / (float)v194) + *(float *)&v176.lightEntity.version;
		      if ( !s_punctualLightShadowHDCharacterIndices )
		        goto LABEL_118;
		      *(LightCaster *)&v197.m_Center.x = v176;
		      sub_18003FEF0(s_punctualLightShadowHDCharacterIndices, i, &v197);
		      s_punctualLightShadowHDCharacterIndices = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_characterWorldToShadowMatrices;
		      if ( !s_punctualLightShadowHDCharacterIndices )
		        goto LABEL_118;
		      *(_OWORD *)&v203.m00 = v86;
		      *(_OWORD *)&v203.m01 = v87;
		      *(_OWORD *)&v203.m02 = v88;
		      *(_OWORD *)&v203.m03 = v89;
		      sub_180041540(s_punctualLightShadowHDCharacterIndices, i, &v203);
		      v67 = (TextureHandle)v195;
		    }
		  }
		  v123 = v9->fields.m_renderRequestCount;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		  HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::set_isActive(v123 > 0, v124);
		  v118 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x82u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		  if ( !renderGraph )
		LABEL_118:
		    sub_1800D8250(s_punctualLightShadowHDCharacterIndices, v118);
		  HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		    &v206,
		    renderGraph,
		    (String *)"HDPLS Character Shadow Push Data",
		    &v171,
		    v118,
		    1,
		    ProfilingHGPass__Enum_Shadow,
		    MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowPushDataPassData>);
		  v201 = v206;
		  ex = 0LL;
		  v188 = &v201;
		  try
		  {
		    *(float *)&v176.lightEntity.globalIndex = 1.0 / (float)v184.visibleLightIndex;
		    *(float *)&v176.lightEntity.version = 1.0 / (float)v59;
		    *(float *)&v176.index = (float)v184.visibleLightIndex;
		    *(float *)&v176.m_cachedHashCode = (float)v59;
		    if ( !v171 )
		      sub_1800D8250(v126, v125);
		    *(LightCaster *)&v171[3].monitor = v176;
		    v127 = v171;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		    isActive = HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::get_isActive(v128);
		    if ( !v127 )
		      sub_1800D8250(v131, v130);
		    LOBYTE(v127[6].klass) = isActive;
		    v132 = v171;
		    v133 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    if ( !v171 )
		      sub_1800D8250(v133, 0LL);
		    v171[1].klass = (Object__Class *)v133->s_characterWorldToShadowMatrices;
		    v134 = dword_18F35FD08;
		    if ( dword_18F35FD08 )
		    {
		      v135 = (((unsigned __int64)&v132[1] >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v135 + 36190]);
		      do
		        v136 = qword_18F0BCBA0[v135 + 36190];
		      while ( v136 != _InterlockedCompareExchange64(
		                        &qword_18F0BCBA0[v135 + 36190],
		                        v136 | (1LL << (((unsigned __int64)&v132[1] >> 12) & 0x3F)),
		                        v136) );
		      v134 = dword_18F35FD08;
		    }
		    v137 = v171;
		    v138 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    if ( !v171 )
		      sub_1800D8250(v138, qword_18F0BCBA0);
		    v171[1].monitor = (MonitorData *)v138->s_plsParams;
		    if ( v134 )
		    {
		      v139 = ((unsigned __int64)&v137[1].monitor >> 12) & 0x1FFFFF;
		      v140 = v139 >> 6;
		      v141 = v139 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v140 + 36190]);
		      do
		        v142 = qword_18F0BCBA0[v140 + 36190];
		      while ( v142 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v140 + 36190], v142 | (1LL << v141), v142) );
		      v134 = dword_18F35FD08;
		    }
		    v143 = v171;
		    v144 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    if ( !v171 )
		      sub_1800D8250(v144, qword_18F0BCBA0);
		    v171[2].klass = (Object__Class *)v144->s_punctualLightShadowHDCharacterIndices;
		    if ( v134 )
		    {
		      v145 = ((unsigned __int64)&v143[2] >> 12) & 0x1FFFFF;
		      v146 = v145 >> 6;
		      v147 = v145 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v146 + 36190]);
		      do
		        v148 = qword_18F0BCBA0[v146 + 36190];
		      while ( v148 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v146 + 36190], v148 | (1LL << v147), v148) );
		      v134 = dword_18F35FD08;
		    }
		    v149 = v171;
		    v150 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    if ( !v171 )
		      sub_1800D8250(v150, qword_18F0BCBA0);
		    v171[2].monitor = (MonitorData *)v150->s_punctualLightShadowSSChannel;
		    if ( v134 )
		    {
		      v151 = ((unsigned __int64)&v149[2].monitor >> 12) & 0x1FFFFF;
		      v152 = v151 >> 6;
		      v153 = v151 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v152 + 36190]);
		      do
		        v154 = qword_18F0BCBA0[v152 + 36190];
		      while ( v154 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v152 + 36190], v154 | (1LL << v153), v154) );
		      v134 = dword_18F35FD08;
		    }
		    v155 = v171;
		    v156 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    if ( !v171 )
		      sub_1800D8250(v156, qword_18F0BCBA0);
		    v171[3].klass = (Object__Class *)v156->s_screenSpaceShadowIndices;
		    if ( v134 )
		    {
		      v157 = ((unsigned __int64)&v155[3] >> 12) & 0x1FFFFF;
		      v158 = v157 >> 6;
		      v159 = v157 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v158 + 36190]);
		      do
		        v160 = qword_18F0BCBA0[v158 + 36190];
		      while ( v160 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v158 + 36190], v160 | (1LL << v159), v160) );
		      v134 = dword_18F35FD08;
		    }
		    v161 = v171;
		    v162 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    if ( !v171 )
		      sub_1800D8250(v162, qword_18F0BCBA0);
		    v171[4].monitor = (MonitorData *)v162->s_screenSpaceLightPositions;
		    if ( v134 )
		    {
		      v163 = ((unsigned __int64)&v161[4].monitor >> 12) & 0x1FFFFF;
		      v164 = v163 >> 6;
		      v165 = v163 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v164 + 36190]);
		      do
		        v166 = qword_18F0BCBA0[v164 + 36190];
		      while ( v166 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v164 + 36190], v166 | (1LL << v165), v166) );
		    }
		    v167 = TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields;
		    v168 = _mm_loadu_si128((const __m128i *)&v167->s_plsGlobalParams);
		    if ( !v171 )
		      sub_1800D8250(v167, qword_18F0BCBA0);
		    v171[5] = (Object)v168;
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		      &v201,
		      (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager->static_fields->s_pushDataRenderFunc,
		      0LL,
		      0,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HDPLSCharacterShadowPushDataPassData>);
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v201, 0, 0LL);
		  }
		  catch ( Il2CppExceptionWrapper *v205 )
		  {
		    ex = v205->ex;
		  }
		  sub_180268AE0(&ex);
		}
		
	}
}
