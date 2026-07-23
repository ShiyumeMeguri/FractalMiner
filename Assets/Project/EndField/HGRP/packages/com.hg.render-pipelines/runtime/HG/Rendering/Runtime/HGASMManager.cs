using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGASMManager // TypeDefIndex: 37822
	{
		// Fields
		private static Dictionary<Camera, HGASMManager> s_asmManagers; // 0x00
		private static Dictionary<Camera, HGASMManager> s_cachedASMManagers; // 0x08
		private static Dictionary<Camera, int> s_cameraLifetime; // 0x10
		private static List<Camera> s_toRemoveList; // 0x18
		private const int GRID_COUNT_X = 16; // Metadata: 0x02303175
		private const int GRID_COUNT_Y = 16; // Metadata: 0x02303176
		private static float s_asmCacheRadius; // 0x20
		private static float s_asmGridSize; // 0x24
		private static int s_asmTileResolution; // 0x28
		private static float s_asmUpdateAtlasDistance; // 0x2C
		private static int s_asmMaxTileRenderCountPerFrame; // 0x30
		private static bool s_forceUpdateAllTilesMode; // 0x34
		private static Material s_clearShadowMaterial; // 0x38
		private static float s_asmDepthBias; // 0x40
		private static float s_asmNormalBias; // 0x44
		private static float s_asmScreenSizeMinSquared; // 0x48
		private static uint s_asmManagerCullingMask; // 0x4C
		public static Vector2 s_lastUpdatedPosition; // 0x50
		private Vector3 m_cameraPosLightSpace; // 0x10
		private ASMTileManager m_asmTileManager; // 0x20
		private HGASMVirtualTextureAllocator m_vtAllocator; // 0x28
		private Matrix4x4[] m_worldToShadowMatrices; // 0x30
		private RTHandle m_asmShadowMapRT; // 0x38
		private Matrix4x4 m_lightToWorld; // 0x40
		private Vector3 m_lightDir; // 0x80
		private Quaternion m_lightRotation; // 0x8C
		private Vector3[] m_frustumCorners; // 0xA0
		private Vector3[] m_frustumCornersLightSpace; // 0xA8
		private readonly Vector2[] m_frustumVerts; // 0xB0
		private Vector3[] m_frustumCornersForIndirect; // 0xB8
		private Vector3[] m_frustumCornersLightSpaceForIndirect; // 0xC0
		private readonly Vector2[] m_frustumVertsForIndirect; // 0xC8
		private Vector2 m_lastPositionXZ; // 0xD0
		private Vector3 m_lastLightDir; // 0xD8
		private int m_startVTIdx; // 0xE4
		private ASMUpdateMode m_asmUpdateMode; // 0xE8
		private float m_asmCasterMinY; // 0xEC
		private float m_asmCasterMaxY; // 0xF0
		public bool shouldSwapManagers; // 0xF4
		internal HGASMManager m_friendASMManager; // 0xF8
		private ProfilerMarker m_samplerASMCreateTiles; // 0x100
		private ProfilerMarker m_samplerASMUpdateCachedTiles; // 0x108
		private ProfilerMarker m_samplerASMPreRenderTiles; // 0x110
		private static readonly RenderFunc<ASMShadowPassData> s_renderASMShadowPass; // 0x58
		private static readonly RenderFunc<ASMShadowPassData> s_setASMShadowDataPass; // 0x60
		private static readonly RenderFunc<ASMShadowPassData> s_skipASMPass; // 0x68
		private static Plane[] s_tempPlanes; // 0x70
	
		// Properties
		public static float asmCacheRadius { get => default; } // 0x0000000189D1B12C-0x0000000189D1B18C 
		// Single get_asmCacheRadius()
		float HG::Rendering::Runtime::HGASMManager::get_asmCacheRadius(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2063, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2063, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    return TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius;
		  }
		}
		
		public static float asmGridSize { get => default; } // 0x0000000189D1B18C-0x0000000189D1B1EC 
		// Single get_asmGridSize()
		float HG::Rendering::Runtime::HGASMManager::get_asmGridSize(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2064, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2064, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    return TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmGridSize;
		  }
		}
		
		public RTHandle ASMShadowMapRT { get => default; } // 0x0000000189D1B0DC-0x0000000189D1B12C 
		// RTHandle get_ASMShadowMapRT()
		RTHandle *HG::Rendering::Runtime::HGASMManager::get_ASMShadowMapRT(HGASMManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2069, 0LL) )
		    return this->fields.m_asmShadowMapRT;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2069, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_128(Patch, (Object *)this, 0LL);
		}
		
		public ASMTileManager asmTileManager { get => default; } // 0x0000000189D1B1EC-0x0000000189D1B23C 
		// ASMTileManager get_asmTileManager()
		ASMTileManager *HG::Rendering::Runtime::HGASMManager::get_asmTileManager(HGASMManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2070, 0LL) )
		    return this->fields.m_asmTileManager;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2070, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_832(Patch, (Object *)this, 0LL);
		}
		
		public Vector3[] frustumCornersLightSpace { get => default; } // 0x0000000189D1B2AC-0x0000000189D1B2FC 
		// Vector3[] get_frustumCornersLightSpace()
		Vector3__Array *HG::Rendering::Runtime::HGASMManager::get_frustumCornersLightSpace(
		        HGASMManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2071, 0LL) )
		    return this->fields.m_frustumCornersLightSpace;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2071, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_833(Patch, (Object *)this, 0LL);
		}
		
		public Vector3 cameraPosLightSpace { get => default; } // 0x0000000189D1B23C-0x0000000189D1B2AC 
		// Vector3 get_cameraPosLightSpace()
		Vector3 *HG::Rendering::Runtime::HGASMManager::get_cameraPosLightSpace(
		        Vector3 *__return_ptr retstr,
		        HGASMManager *this,
		        MethodInfo *method)
		{
		  __int64 v5; // xmm0_8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  Vector3 v12[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2072, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2072, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_368(v12, Patch, (Object *)this, 0LL);
		    v5 = *(_QWORD *)&v10->x;
		    z = v10->z;
		  }
		  else
		  {
		    v5 = *(_QWORD *)&this->fields.m_cameraPosLightSpace.x;
		    z = this->fields.m_cameraPosLightSpace.z;
		  }
		  *(_QWORD *)&retstr->x = v5;
		  retstr->z = z;
		  return retstr;
		}
		
	
		// Nested types
		public enum ASMUpdateMode // TypeDefIndex: 37819
		{
			Stop = 0,
			Slow = 1,
			Normal = 2,
			Extreme = 3
		}
	
		private class ASMShadowPassData // TypeDefIndex: 37820
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public HGRenderGraphDefaultResources defaultResources; // 0x18
			public TextureHandle asmShadowTexture; // 0x20
			public Matrix4x4 deviceProjectionYFlipMatrix; // 0x30
			public Matrix4x4 viewMatrix; // 0x70
			public Matrix4x4 cullingMatrix; // 0xB0
			public Vector2Int viewportMins; // 0xF0
			public Vector2Int viewportMaxs; // 0xF8
			public Material clearShadowMaterial; // 0x100
			public RendererList rendererList; // 0x108
			public uint ecsRendererList; // 0x118
			public uint ecsGrassList; // 0x11C
			public uint ecsTreeList; // 0x120
	
			// Constructors
			public ASMShadowPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public HGASMManager() {} // 0x0000000189D1AE9C-0x0000000189D1B0DC
		// HGASMManager()
		void HG::Rendering::Runtime::HGASMManager::HGASMManager(HGASMManager *this, MethodInfo *method)
		{
		  ASMTileManager *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ASMTileManager *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  HGASMVirtualTextureAllocator *v10; // rax
		  HGASMVirtualTextureAllocator *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  MethodInfo *v36; // r9
		  Vector2__StaticFields *static_fields; // rax
		  float y; // xmm1_4
		  Animator *v39; // rdx
		  int32_t v40; // r8d
		  Vector3 *Vector; // rax
		  float z; // ecx
		  MethodInfo *v43; // r8
		  void *m_Ptr; // rax
		  MethodInfo *v45; // r8
		  void *v46; // rax
		  MethodInfo *v47; // r8
		  Vector3 v48[2]; // [rsp+20h] [rbp-18h] BYREF
		  ProfilerMarker v49; // [rsp+50h] [rbp+18h] BYREF
		
		  v3 = (ASMTileManager *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::ASMTileManager);
		  v6 = v3;
		  if ( !v3
		    || (HG::Rendering::Runtime::ASMTileManager::ASMTileManager(v3, 0LL),
		        this->fields.m_asmTileManager = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_asmTileManager, v7, v8, v9, *(MethodInfo **)&v48[0].x),
		        v10 = (HGASMVirtualTextureAllocator *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGASMVirtualTextureAllocator),
		        (v11 = v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::Runtime::HGASMVirtualTextureAllocator::HGASMVirtualTextureAllocator(v10, 0LL);
		  this->fields.m_vtAllocator = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_vtAllocator, v12, v13, v14, *(MethodInfo **)&v48[0].x);
		  this->fields.m_worldToShadowMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_1(
		                                                               TypeInfo::UnityEngine::Matrix4x4,
		                                                               256LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_worldToShadowMatrices, v15, v16, v17, *(MethodInfo **)&v48[0].x);
		  this->fields.m_frustumCorners = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_frustumCorners, v18, v19, v20, *(MethodInfo **)&v48[0].x);
		  this->fields.m_frustumCornersLightSpace = (Vector3__Array *)il2cpp_array_new_specific_1(
		                                                                TypeInfo::UnityEngine::Vector3,
		                                                                4LL);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_frustumCornersLightSpace,
		    v21,
		    v22,
		    v23,
		    *(MethodInfo **)&v48[0].x);
		  this->fields.m_frustumVerts = (Vector2__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 5LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_frustumVerts, v24, v25, v26, *(MethodInfo **)&v48[0].x);
		  this->fields.m_frustumCornersForIndirect = (Vector3__Array *)il2cpp_array_new_specific_1(
		                                                                 TypeInfo::UnityEngine::Vector3,
		                                                                 4LL);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_frustumCornersForIndirect,
		    v27,
		    v28,
		    v29,
		    *(MethodInfo **)&v48[0].x);
		  this->fields.m_frustumCornersLightSpaceForIndirect = (Vector3__Array *)il2cpp_array_new_specific_1(
		                                                                           TypeInfo::UnityEngine::Vector3,
		                                                                           4LL);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_frustumCornersLightSpaceForIndirect,
		    v30,
		    v31,
		    v32,
		    *(MethodInfo **)&v48[0].x);
		  this->fields.m_frustumVertsForIndirect = (Vector2__Array *)il2cpp_array_new_specific_1(
		                                                               TypeInfo::UnityEngine::Vector2,
		                                                               5LL);
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_frustumVertsForIndirect,
		    v33,
		    v34,
		    v35,
		    *(MethodInfo **)&v48[0].x);
		  v36 = (MethodInfo *)TypeInfo::UnityEngine::Vector2;
		  static_fields = TypeInfo::UnityEngine::Vector2->static_fields;
		  y = static_fields->negativeInfinityVector.y;
		  this->fields.m_lastPositionXZ.x = static_fields->negativeInfinityVector.x;
		  this->fields.m_lastPositionXZ.y = y;
		  Vector = UnityEngine::Animator::GetVector(v48, v39, v40, v36);
		  v49.m_Ptr = 0LL;
		  z = Vector->z;
		  *(_QWORD *)&this->fields.m_lastLightDir.x = *(_QWORD *)&Vector->x;
		  this->fields.m_lastLightDir.z = z;
		  this->fields.m_asmUpdateMode = 2;
		  this->fields.m_asmCasterMinY = -500.0;
		  this->fields.m_asmCasterMaxY = 500.0;
		  Unity::Profiling::ProfilerMarker::ProfilerMarker(&v49, (String *)"ShadowMap.ASM.CreateTiles", v43);
		  m_Ptr = v49.m_Ptr;
		  v49.m_Ptr = 0LL;
		  this->fields.m_samplerASMCreateTiles.m_Ptr = m_Ptr;
		  Unity::Profiling::ProfilerMarker::ProfilerMarker(&v49, (String *)"ShadowMap.ASM.UpdateCachedTiles", v45);
		  v46 = v49.m_Ptr;
		  v49.m_Ptr = 0LL;
		  this->fields.m_samplerASMUpdateCachedTiles.m_Ptr = v46;
		  Unity::Profiling::ProfilerMarker::ProfilerMarker(&v49, (String *)"ShadowMap.ASM.PreRenderTiles", v47);
		  this->fields.m_samplerASMPreRenderTiles = v49;
		}
		
		static HGASMManager() {} // 0x0000000184847040-0x0000000184847420
		// HGASMManager()
		void HG::Rendering::Runtime::HGASMManager::cctor(MethodInfo *method)
		{
		  Dictionary_2_System_Object_System_Object_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Type__Class *v4; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Dictionary_2_System_Object_System_Object_ *v8; // rax
		  MonitorData *v9; // rbx
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v13; // rax
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v14; // rbx
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v18; // rax
		  Type__Class *v19; // rbx
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  Vector2__StaticFields *v23; // rcx
		  float x; // xmm0_4
		  float y; // xmm1_4
		  HGASMManager__StaticFields *v26; // rcx
		  struct HGASMManager_c__Class *v27; // rax
		  Object *v28; // rdi
		  RenderFunc_1_System_Object_ *v29; // rax
		  RenderFunc_1_System_Object_ *v30; // rbx
		  Type *v31; // rdx
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  Object *v34; // rdi
		  RenderFunc_1_System_Object_ *v35; // rax
		  Type__Class *v36; // rbx
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  Object *v40; // rdi
		  RenderFunc_1_System_Object_ *v41; // rax
		  MonitorData *v42; // rbx
		  Type *v43; // rdx
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  __int64 v46; // rax
		  Type *v47; // rdx
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **v49; // r9
		  MethodInfo *v50; // [rsp+20h] [rbp-8h]
		  MethodInfo *v51; // [rsp+20h] [rbp-8h]
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		  MethodInfo *v54; // [rsp+20h] [rbp-8h]
		  MethodInfo *v55; // [rsp+20h] [rbp-8h]
		  MethodInfo *v56; // [rsp+20h] [rbp-8h]
		  MethodInfo *v57; // [rsp+50h] [rbp+28h]
		
		  v1 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>);
		  v4 = (Type__Class *)v1;
		  if ( !v1 )
		    goto LABEL_2;
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v1,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Dictionary);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  static_fields->klass = v4;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields,
		    static_fields,
		    v6,
		    v7,
		    v50);
		  v8 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>);
		  v9 = (MonitorData *)v8;
		  if ( !v8 )
		    goto LABEL_2;
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v8,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Dictionary);
		  v10 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v10->monitor = v9;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers,
		    v10,
		    v11,
		    v12,
		    v51);
		  v13 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>);
		  v14 = v13;
		  if ( !v13 )
		    goto LABEL_2;
		  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
		    v13,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Dictionary);
		  v15 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v15->fields._impl.value = v14;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cameraLifetime,
		    v15,
		    v16,
		    v17,
		    v52);
		  v18 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Camera>);
		  v19 = (Type__Class *)v18;
		  if ( !v18 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v18,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::List);
		  v20 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v20[1].klass = v19;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_toRemoveList,
		    v20,
		    v21,
		    v22,
		    v53);
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius = 500.0;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmGridSize = 125.0;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmTileResolution = 256;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmUpdateAtlasDistance = 50.0;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmMaxTileRenderCountPerFrame = 8;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_forceUpdateAllTilesMode = 0;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmDepthBias = 2.0;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmNormalBias = 0.1;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmScreenSizeMinSquared = 0.1;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask = 0;
		  v23 = TypeInfo::UnityEngine::Vector2->static_fields;
		  x = v23->negativeInfinityVector.x;
		  y = v23->negativeInfinityVector.y;
		  v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v26->s_lastUpdatedPosition.x = x;
		  v26->s_lastUpdatedPosition.y = y;
		  v27 = TypeInfo::HG::Rendering::Runtime::HGASMManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager::__c);
		    v27 = TypeInfo::HG::Rendering::Runtime::HGASMManager::__c;
		  }
		  v28 = (Object *)v27->static_fields->__9;
		  v29 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
		  v30 = v29;
		  if ( !v29 )
		    goto LABEL_2;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v29,
		    v28,
		    MethodInfo::HG::Rendering::Runtime::HGASMManager::__c::__cctor_b__84_0,
		    0LL);
		  v31 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v31[3].fields._impl.value = v30;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_renderASMShadowPass,
		    v31,
		    v32,
		    v33,
		    v54);
		  v34 = (Object *)TypeInfo::HG::Rendering::Runtime::HGASMManager::__c->static_fields->__9;
		  v35 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
		  v36 = (Type__Class *)v35;
		  if ( !v35
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v35,
		          v34,
		          MethodInfo::HG::Rendering::Runtime::HGASMManager::__c::__cctor_b__84_1,
		          0LL),
		        v37 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields,
		        v37[4].klass = v36,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_setASMShadowDataPass,
		          v37,
		          v38,
		          v39,
		          v55),
		        v40 = (Object *)TypeInfo::HG::Rendering::Runtime::HGASMManager::__c->static_fields->__9,
		        v41 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>),
		        (v42 = (MonitorData *)v41) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v3, v2);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v41,
		    v40,
		    MethodInfo::HG::Rendering::Runtime::HGASMManager::__c::__cctor_b__84_2,
		    0LL);
		  v43 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v43[4].monitor = v42;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_skipASMPass,
		    v43,
		    v44,
		    v45,
		    v56);
		  v46 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  v47 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  v47[4].fields._impl.value = (void *)v46;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_tempPlanes,
		    v47,
		    v48,
		    v49,
		    v57);
		}
		
	
		// Methods
		public static HGASMManager GetASMManager(Camera camera) => default; // 0x0000000189D17890-0x0000000189D179E0
		// HGASMManager GetASMManager(Camera)
		HGASMManager *HG::Rendering::Runtime::HGASMManager::GetASMManager(Camera *camera, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_System_Object_System_Object_ *s_asmManagers; // rcx
		  HGASMManager *v5; // rax
		  HGASMManager *v6; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2059, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2059, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_829(Patch, (Object *)camera, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_asmManagers )
		      goto LABEL_11;
		    if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		            s_asmManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
		    {
		      v5 = (HGASMManager *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v6 = v5;
		      if ( v5 )
		      {
		        HG::Rendering::Runtime::HGASMManager::HGASMManager(v5, 0LL);
		        HG::Rendering::Runtime::HGASMManager::Initialize(v6, camera, 0LL, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		        s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		        if ( s_asmManagers )
		        {
		          System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		            s_asmManagers,
		            (Object *)camera,
		            (Object *)v6,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Add);
		          s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cameraLifetime;
		          if ( s_asmManagers )
		          {
		            System::Collections::Generic::Dictionary<System::Object,int>::Add(
		              (Dictionary_2_System_Object_System_Int32_ *)s_asmManagers,
		              (Object *)camera,
		              -1,
		              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Add);
		            return v6;
		          }
		        }
		      }
		LABEL_11:
		      sub_1800D8260(s_asmManagers, v3);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_asmManagers )
		      goto LABEL_11;
		    return (HGASMManager *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                             s_asmManagers,
		                             (Object *)camera,
		                             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		  }
		}
		
		public static HGASMManager GetCachedASMManager(Camera camera) => default; // 0x0000000189D1813C-0x0000000189D181F4
		// HGASMManager GetCachedASMManager(Camera)
		HGASMManager *HG::Rendering::Runtime::HGASMManager::GetCachedASMManager(Camera *camera, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_cachedASMManagers; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2060, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    s_cachedASMManagers = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers;
		    if ( s_cachedASMManagers )
		    {
		      if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		              (Dictionary_2_System_Object_System_Object_ *)s_cachedASMManagers,
		              (Object *)camera,
		              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
		        return 0LL;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      s_cachedASMManagers = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers;
		      if ( s_cachedASMManagers )
		        return (HGASMManager *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                                 (Dictionary_2_System_Object_System_Object_ *)s_cachedASMManagers,
		                                 (Object *)camera,
		                                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    }
		LABEL_8:
		    sub_1800D8260(s_cachedASMManagers, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2060, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_829(Patch, (Object *)camera, 0LL);
		}
		
		public static void SwapASMManager(Camera camera) {} // 0x0000000189D1A090-0x0000000189D1A654
		// Void SwapASMManager(Camera)
		void HG::Rendering::Runtime::HGASMManager::SwapASMManager(Camera *camera, MethodInfo *method)
		{
		  Type *v3; // rdx
		  Dictionary_2_System_Object_System_Object_ *s_cachedASMManagers; // rcx
		  HGASMManager__StaticFields *static_fields; // rax
		  Dictionary_2_System_Object_System_Object_ *s_asmManagers; // rbp
		  Dictionary_2_System_Object_System_Object_ *v7; // rdi
		  Object *Item; // r14
		  Object *v9; // rsi
		  Object *v10; // rax
		  Object *v11; // rdi
		  Object *v12; // rax
		  int klass_high; // xmm1_4
		  Object *v14; // rdi
		  Object *v15; // rax
		  Object *v16; // rdi
		  Object *v17; // rax
		  HGASMManager *v18; // rax
		  HGASMManager *v19; // rdi
		  Object *v20; // rax
		  Object *v21; // rax
		  float v22; // xmm1_4
		  Object *v23; // rax
		  Object *v24; // rax
		  MonitorData *monitor; // xmm0_8
		  float v26; // eax
		  HGASMManager__StaticFields *v27; // rax
		  Dictionary_2_System_Object_System_Object_ *v28; // rsi
		  Object *v29; // rax
		  Object *v30; // rdi
		  Object *v31; // rax
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  Object *v34; // rdi
		  Object *v35; // rax
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2061, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2061, 0LL);
		    if ( !Patch )
		      goto LABEL_42;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)camera, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		           s_cachedASMManagers,
		           (Object *)camera,
		           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		      s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)static_fields->s_asmManagers;
		      v7 = (Dictionary_2_System_Object_System_Object_ *)static_fields->s_cachedASMManagers;
		      s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)static_fields->s_asmManagers;
		      if ( static_fields->s_asmManagers )
		      {
		        Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                 s_cachedASMManagers,
		                 (Object *)camera,
		                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		        v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		        s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->monitor;
		        if ( s_cachedASMManagers )
		        {
		          v9 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                 s_cachedASMManagers,
		                 (Object *)camera,
		                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		          if ( v7 )
		          {
		            System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		              v7,
		              (Object *)camera,
		              Item,
		              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::set_Item);
		            System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		              s_asmManagers,
		              (Object *)camera,
		              v9,
		              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::set_Item);
		            s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		            if ( s_cachedASMManagers )
		            {
		              v10 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                      s_cachedASMManagers,
		                      (Object *)camera,
		                      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		              if ( v10 )
		              {
		                HG::Rendering::Runtime::HGASMManager::Initialize((HGASMManager *)v10, camera, 0LL, 0LL);
		                s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		                if ( s_cachedASMManagers )
		                {
		                  v11 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                          s_cachedASMManagers,
		                          (Object *)camera,
		                          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		                  v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		                  s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->monitor;
		                  if ( s_cachedASMManagers )
		                  {
		                    v12 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                            s_cachedASMManagers,
		                            (Object *)camera,
		                            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		                    if ( v12 )
		                    {
		                      klass_high = HIDWORD(v12[13].klass);
		                      if ( v11 )
		                      {
		                        LODWORD(v11[13].klass) = v12[13].klass;
		                        HIDWORD(v11[13].klass) = klass_high;
		                        s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		                        if ( s_cachedASMManagers )
		                        {
		                          v14 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                                  s_cachedASMManagers,
		                                  (Object *)camera,
		                                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		                          v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		                          s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->monitor;
		                          if ( s_cachedASMManagers )
		                          {
		                            v15 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                                    s_cachedASMManagers,
		                                    (Object *)camera,
		                                    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		                            if ( v15 )
		                            {
		                              s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)LODWORD(v15[14].monitor);
		                              if ( v14 )
		                              {
		                                LODWORD(v14[14].monitor) = (_DWORD)s_cachedASMManagers;
		                                s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		                                if ( s_cachedASMManagers )
		                                {
		                                  v16 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                                          s_cachedASMManagers,
		                                          (Object *)camera,
		                                          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		                                  v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		                                  s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->monitor;
		                                  if ( s_cachedASMManagers )
		                                  {
		                                    v17 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                                            s_cachedASMManagers,
		                                            (Object *)camera,
		                                            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		                                    if ( v17 )
		                                    {
		                                      s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)LODWORD(v17[14].klass);
		                                      if ( v16 )
		                                      {
		                                        v16[13].monitor = v17[13].monitor;
		                                        LODWORD(v16[14].klass) = (_DWORD)s_cachedASMManagers;
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
		            }
		          }
		        }
		      }
		LABEL_42:
		      sub_1800D8260(s_cachedASMManagers, v3);
		    }
		    v18 = (HGASMManager *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v19 = v18;
		    if ( !v18 )
		      goto LABEL_42;
		    HG::Rendering::Runtime::HGASMManager::HGASMManager(v18, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->klass;
		    if ( !v3->klass )
		      goto LABEL_42;
		    v20 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v20 )
		      goto LABEL_42;
		    HG::Rendering::Runtime::HGASMManager::Initialize(v19, camera, (RTHandle *)v20[3].monitor, 0LL);
		    HG::Rendering::Runtime::HGASMManager::SetStartVTIndex(v19, 128, 0LL);
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    v21 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v21 )
		      goto LABEL_42;
		    v22 = *((float *)&v21[13].klass + 1);
		    v19->fields.m_lastPositionXZ.x = *(float *)&v21[13].klass;
		    v19->fields.m_lastPositionXZ.y = v22;
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    v23 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v23 )
		      goto LABEL_42;
		    v19->fields.m_asmUpdateMode = (int32_t)v23[14].monitor;
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    v24 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v24;
		    if ( !v24 )
		      goto LABEL_42;
		    monitor = v24[13].monitor;
		    v26 = *(float *)&v24[14].klass;
		    *(_QWORD *)&v19->fields.m_lastLightDir.x = monitor;
		    v19->fields.m_lastLightDir.z = v26;
		    v27 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v27->s_asmManagers;
		    v28 = (Dictionary_2_System_Object_System_Object_ *)v27->s_cachedASMManagers;
		    if ( !v27->s_asmManagers )
		      goto LABEL_42;
		    v29 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v28 )
		      goto LABEL_42;
		    System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		      v28,
		      (Object *)camera,
		      v29,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::set_Item);
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		      s_cachedASMManagers,
		      (Object *)camera,
		      (Object *)v19,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::set_Item);
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    v30 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->monitor;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    v31 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v30 )
		      goto LABEL_42;
		    v30[15].monitor = (MonitorData *)v31;
		    sub_18002D1B0((SingleFieldAccessor *)&v30[15].monitor, v3, v32, v33, v39);
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers;
		    if ( !s_cachedASMManagers )
		      goto LABEL_42;
		    v34 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    v3 = (Type *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v3->klass;
		    if ( !v3->klass )
		      goto LABEL_42;
		    v35 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            s_cachedASMManagers,
		            (Object *)camera,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v34 )
		      goto LABEL_42;
		    v34[15].monitor = (MonitorData *)v35;
		    sub_18002D1B0((SingleFieldAccessor *)&v34[15].monitor, v3, v36, v37, v40);
		  }
		}
		
		public static void UpdateCameraLifetime(List<Camera> cameras, int frameCount) {} // 0x0000000183452C80-0x00000001834534C0
		// Void UpdateCameraLifetime(List`1[UnityEngine.Camera], Int32)
		// local variable allocation has failed, the output may be wrong!
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGASMManager::UpdateCameraLifetime(
		        List_1_UnityEngine_Camera_ *cameras,
		        int32_t frameCount,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  int32_t v4; // esi
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v8; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  _BYTE *v12; // rdx
		  List_1_UnityEngine_Camera_ *v13; // rcx
		  Object *current; // rbx
		  struct HGASMManager__Class *v15; // rax
		  Dictionary_2_System_Object_System_Int32_ *s_cameraLifetime; // rcx
		  __int64 v17; // rdx
		  struct HGASMManager__Class *v18; // rax
		  Dictionary_2_System_Object_System_Int32_ *v19; // rcx
		  struct HGASMManager__Class *v20; // rax
		  Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_asmManagers; // r9
		  __int64 *v22; // rdx
		  signed __int64 v23; // rcx
		  signed __int64 v24; // rtt
		  Object *key; // rbx
		  struct HGASMManager__Class *v26; // rax
		  Dictionary_2_System_Object_System_Int32_ *v27; // rcx
		  __int64 v28; // rdx
		  struct HGASMManager__Class *v29; // rax
		  Dictionary_2_System_Object_System_Int32_ *v30; // rcx
		  struct Object_1__Class *v31; // rcx
		  struct HGASMManager__Class *v32; // rax
		  List_1_System_Object_ *s_toRemoveList; // rcx
		  struct HGASMManager__Class *v34; // rax
		  List_1_UnityEngine_Camera_ *v35; // r9
		  __int64 *v36; // rdx
		  signed __int64 v37; // rtt
		  Object *v38; // rbx
		  struct HGASMManager__Class *v39; // rax
		  Dictionary_2_System_Object_System_Object_ *s_cachedASMManagers; // rcx
		  __int64 v41; // rdx
		  struct HGASMManager__Class *v42; // rax
		  Dictionary_2_System_Object_System_Object_ *v43; // rcx
		  Object *Item; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  __int64 v47; // rdx
		  Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *v48; // rcx
		  struct HGASMManager__Class *v49; // rax
		  Dictionary_2_System_Object_System_Object_ *v50; // rcx
		  __int64 v51; // rdx
		  struct HGASMManager__Class *v52; // rax
		  Dictionary_2_System_Object_System_Object_ *v53; // rcx
		  Object *v54; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdx
		  Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *v58; // rcx
		  struct HGASMManager__Class *v59; // rax
		  Dictionary_2_System_Object_System_Int32_ *v60; // rcx
		  __int64 v61; // rdx
		  struct HGASMManager__Class *v62; // rax
		  Dictionary_2_System_Object_System_Int32_ *v63; // rcx
		  struct HGASMManager__Class *v64; // rax
		  _BYTE v65[32]; // [rsp+0h] [rbp-B8h] BYREF
		  _BYTE v66[40]; // [rsp+20h] [rbp-98h] BYREF
		  List_1_T_Enumerator_System_Object_ v67; // [rsp+48h] [rbp-70h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v68; // [rsp+60h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v69; // [rsp+88h] [rbp-30h] BYREF
		  Il2CppExceptionWrapper *v70; // [rsp+90h] [rbp-28h] BYREF
		  Il2CppExceptionWrapper *v71; // [rsp+98h] [rbp-20h] BYREF
		
		  v4 = frameCount;
		  memset(&v68, 0, sizeof(v68));
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v6, *(_QWORD *)&frameCount);
		  if ( wrapperArray->max_length.size <= 670 )
		    goto LABEL_12;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = v6->static_fields->wrapperArray;
		  if ( !v8 )
		    sub_1800D8260(v6, *(_QWORD *)&frameCount);
		  if ( v8->max_length.size <= 0x29Eu )
		    sub_1800D2AB0(v6, *(_QWORD *)&frameCount);
		  if ( v8[18].vector[22] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(670, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)cameras, v4, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    if ( !cameras )
		      sub_1800D8260(v6, *(_QWORD *)&frameCount);
		    *(_OWORD *)&v66[8] = 0LL;
		    *(_QWORD *)v66 = cameras;
		    ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		      (SingleFieldAccessor *)v66,
		      *(Type **)&frameCount,
		      (PropertyInfo_1 *)method,
		      v3);
		    *(_DWORD *)&v66[8] = 0;
		    *(_DWORD *)&v66[12] = cameras->fields._version;
		    *(_QWORD *)&v66[16] = 0LL;
		    *(_OWORD *)&v67._list = *(_OWORD *)v66;
		    v67._current = 0LL;
		    *(_QWORD *)v66 = 0LL;
		    *(_QWORD *)&v66[8] = &v67;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v67,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
		      {
		        current = v67._current;
		        v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        s_cameraLifetime = (Dictionary_2_System_Object_System_Int32_ *)v15->static_fields->s_cameraLifetime;
		        if ( !s_cameraLifetime )
		          sub_1800D8250(0LL, v12);
		        if ( System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
		               s_cameraLifetime,
		               current,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::ContainsKey) )
		        {
		          v18 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		            v18 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          }
		          v19 = (Dictionary_2_System_Object_System_Int32_ *)v18->static_fields->s_cameraLifetime;
		          if ( !v19 )
		            sub_1800D8250(0LL, v17);
		          System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
		            v19,
		            current,
		            v4,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::set_Item);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v69 )
		    {
		      v12 = v65;
		      *(Il2CppExceptionWrapper *)v66 = (Il2CppExceptionWrapper)v69->ex;
		      v13 = *(List_1_UnityEngine_Camera_ **)v66;
		      if ( *(_QWORD *)v66 )
		        sub_18007E1E0(*(_QWORD *)v66);
		      v4 = frameCount;
		    }
		    v20 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v20 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    s_asmManagers = v20->static_fields->s_asmManagers;
		    if ( !s_asmManagers )
		      goto LABEL_94;
		    memset(&v66[8], 0, 32);
		    *(_QWORD *)v66 = s_asmManagers;
		    if ( dword_18F35FD08 )
		    {
		      v22 = &qword_18F0BCBA0[(((unsigned __int64)v66 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v22 + 36190);
		      do
		      {
		        v23 = v22[36190] | (1LL << (((unsigned __int64)v66 >> 12) & 0x3F));
		        v24 = v22[36190];
		      }
		      while ( v24 != _InterlockedCompareExchange64(v22 + 36190, v23, v24) );
		    }
		    *(_QWORD *)&v66[8] = (unsigned int)s_asmManagers->fields._version;
		    *(_DWORD *)&v66[32] = 2;
		    *(_OWORD *)&v66[16] = 0LL;
		    *(_OWORD *)&v68._dictionary = *(_OWORD *)v66;
		    v68._current = 0LL;
		    *(_QWORD *)&v68._getEnumeratorRetType = *(_QWORD *)&v66[32];
		    *(_QWORD *)v66 = 0LL;
		    *(_QWORD *)&v66[8] = &v68;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
		                &v68,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext) )
		      {
		        key = v68._current.key;
		        v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        v27 = (Dictionary_2_System_Object_System_Int32_ *)v26->static_fields->s_cameraLifetime;
		        if ( !v27 )
		          sub_1800D8250(0LL, v12);
		        if ( System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
		               v27,
		               key,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::get_Item) == -1 )
		          goto LABEL_135;
		        v29 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v29 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        v30 = (Dictionary_2_System_Object_System_Int32_ *)v29->static_fields->s_cameraLifetime;
		        if ( !v30 )
		          sub_1800D8250(0LL, v28);
		        if ( v4
		           - System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
		               v30,
		               key,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::get_Item) <= 16 )
		        {
		LABEL_135:
		          v31 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v31 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v31 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( key )
		          {
		            if ( !v31->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v31);
		            if ( key[1].klass )
		              continue;
		          }
		        }
		        v32 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v32 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        s_toRemoveList = (List_1_System_Object_ *)v32->static_fields->s_toRemoveList;
		        if ( !s_toRemoveList )
		          sub_1800D8250(0LL, v28);
		        sub_182F01190(s_toRemoveList, key);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v70 )
		    {
		      v12 = v65;
		      *(Il2CppExceptionWrapper *)v66 = (Il2CppExceptionWrapper)v70->ex;
		      v13 = *(List_1_UnityEngine_Camera_ **)v66;
		      if ( *(_QWORD *)v66 )
		        sub_18007E1E0(*(_QWORD *)v66);
		    }
		    v34 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v34 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    v35 = v34->static_fields->s_toRemoveList;
		    if ( !v35 )
		      goto LABEL_94;
		    *(_OWORD *)&v66[8] = 0LL;
		    *(_QWORD *)v66 = v35;
		    if ( dword_18F35FD08 )
		    {
		      v36 = &qword_18F0BCBA0[(((unsigned __int64)v66 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v36 + 36190);
		      do
		        v37 = v36[36190];
		      while ( v37 != _InterlockedCompareExchange64(
		                       v36 + 36190,
		                       v37 | (1LL << (((unsigned __int64)v66 >> 12) & 0x3F)),
		                       v37) );
		    }
		    *(_DWORD *)&v66[8] = 0;
		    *(_DWORD *)&v66[12] = v35->fields._version;
		    *(_QWORD *)&v66[16] = 0LL;
		    *(_OWORD *)&v67._list = *(_OWORD *)v66;
		    v67._current = 0LL;
		    *(_QWORD *)v66 = 0LL;
		    *(_QWORD *)&v66[8] = &v67;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v67,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
		      {
		        v38 = v67._current;
		        v39 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v39 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v39->static_fields->s_cachedASMManagers;
		        if ( !s_cachedASMManagers )
		          sub_1800D8250(0LL, v12);
		        if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		               s_cachedASMManagers,
		               v38,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
		        {
		          v42 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		            v42 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          }
		          v43 = (Dictionary_2_System_Object_System_Object_ *)v42->static_fields->s_cachedASMManagers;
		          if ( !v43 )
		            sub_1800D8250(0LL, v41);
		          Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                   v43,
		                   v38,
		                   MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		          if ( !Item )
		            sub_1800D8250(v46, v45);
		          HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)Item, 0LL);
		          v48 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers;
		          if ( !v48 )
		            sub_1800D8250(0LL, v47);
		          System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
		            (Dictionary_2_System_Object_System_Object_ *)v48,
		            v38,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
		        }
		        v49 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v49 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        v50 = (Dictionary_2_System_Object_System_Object_ *)v49->static_fields->s_asmManagers;
		        if ( !v50 )
		          sub_1800D8250(0LL, v41);
		        if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		               v50,
		               v38,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
		        {
		          v52 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		            v52 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          }
		          v53 = (Dictionary_2_System_Object_System_Object_ *)v52->static_fields->s_asmManagers;
		          if ( !v53 )
		            sub_1800D8250(0LL, v51);
		          v54 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                  v53,
		                  v38,
		                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		          if ( !v54 )
		            sub_1800D8250(v56, v55);
		          HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)v54, 0LL);
		          v58 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		          if ( !v58 )
		            sub_1800D8250(0LL, v57);
		          System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
		            (Dictionary_2_System_Object_System_Object_ *)v58,
		            v38,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
		        }
		        v59 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v59 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        v60 = (Dictionary_2_System_Object_System_Int32_ *)v59->static_fields->s_cameraLifetime;
		        if ( !v60 )
		          sub_1800D8250(0LL, v51);
		        if ( System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
		               v60,
		               v38,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::ContainsKey) )
		        {
		          v62 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		            v62 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		          }
		          v63 = (Dictionary_2_System_Object_System_Int32_ *)v62->static_fields->s_cameraLifetime;
		          if ( !v63 )
		            sub_1800D8250(0LL, v61);
		          System::Collections::Generic::Dictionary<System::Object,int>::Remove(
		            v63,
		            v38,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Remove);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v71 )
		    {
		      v12 = v65;
		      *(Il2CppExceptionWrapper *)v66 = (Il2CppExceptionWrapper)v71->ex;
		      if ( *(_QWORD *)v66 )
		        sub_18007E1E0(*(_QWORD *)v66);
		    }
		    v64 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v64 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    v13 = v64->static_fields->s_toRemoveList;
		    if ( !v13 )
		LABEL_94:
		      sub_1800D8250(v13, v12);
		    sub_183127A90(v13, MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Clear);
		  }
		}
		
		public static void CleanUpAllCameras() {} // 0x0000000184CAE590-0x0000000184CAE6A0
		// Void CleanUpAllCameras()
		void HG::Rendering::Runtime::HGASMManager::CleanUpAllCameras(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct HGASMManager__Class *v2; // rax
		  Dictionary_2_System_UInt64_System_Object_ *s_asmManagers; // rcx
		  IEnumerable_1_System_Object_ *Keys; // rax
		  Object__Array *v5; // rbx
		  int32_t v6; // edi
		  int32_t v7; // esi
		  struct HGASMManager__Class *v8; // rax
		  IEnumerable_1_System_Object_ *v9; // rax
		  Object__Array *v10; // rbx
		  Object *v11; // rbp
		  struct HGASMManager__Class *v12; // rax
		  Object *Item; // rax
		  Object *v14; // rsi
		  struct HGASMManager__Class *v15; // rax
		  Object *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(551, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(551, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(s_asmManagers, v1);
		  }
		  v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  }
		  s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v2->static_fields->s_asmManagers;
		  if ( !s_asmManagers )
		    goto LABEL_5;
		  Keys = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Keys(
		                                           s_asmManagers,
		                                           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Keys);
		  v5 = System::Linq::Enumerable::ToArray<System::Object>(
		         Keys,
		         MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::Camera>);
		  v6 = 0;
		  v7 = 0;
		  if ( !v5 )
		    goto LABEL_5;
		  while ( v7 < v5->max_length.size )
		  {
		    if ( (unsigned int)v7 >= v5->max_length.size )
		LABEL_29:
		      sub_1800D2AB0(s_asmManagers, v1);
		    v11 = v5->vector[v7];
		    v12 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v12 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v12->static_fields->s_asmManagers;
		    if ( !s_asmManagers )
		      goto LABEL_5;
		    Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		             (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
		             v11,
		             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !Item )
		      goto LABEL_5;
		    HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)Item, 0LL);
		    s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagers;
		    if ( !s_asmManagers )
		      goto LABEL_5;
		    System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
		      (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
		      v11,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
		    s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cameraLifetime;
		    if ( !s_asmManagers )
		      goto LABEL_5;
		    System::Collections::Generic::Dictionary<System::Object,int>::Remove(
		      (Dictionary_2_System_Object_System_Int32_ *)s_asmManagers,
		      v11,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Remove);
		    ++v7;
		  }
		  v8 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v8 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  }
		  s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v8->static_fields->s_cachedASMManagers;
		  if ( !s_asmManagers )
		    goto LABEL_5;
		  v9 = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Keys(
		                                         s_asmManagers,
		                                         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Keys);
		  v10 = System::Linq::Enumerable::ToArray<System::Object>(
		          v9,
		          MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::Camera>);
		  if ( !v10 )
		    goto LABEL_5;
		  while ( v6 < v10->max_length.size )
		  {
		    if ( (unsigned int)v6 >= v10->max_length.size )
		      goto LABEL_29;
		    v14 = v10->vector[v6];
		    v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v15->static_fields->s_cachedASMManagers;
		    if ( !s_asmManagers )
		      goto LABEL_5;
		    v16 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		            (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
		            v14,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
		    if ( !v16 )
		      goto LABEL_5;
		    HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)v16, 0LL);
		    s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_cachedASMManagers;
		    if ( !s_asmManagers )
		      goto LABEL_5;
		    System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
		      (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
		      v14,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
		    ++v6;
		  }
		}
		
		public static void InitStaticParams(Shader shadowClearShader, HGSettingParameters settingParameters) {} // 0x00000001838B23F0-0x00000001838B2950
		// Void InitStaticParams(Shader, HGSettingParameters)
		void HG::Rendering::Runtime::HGASMManager::InitStaticParams(
		        Shader *shadowClearShader,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Material *StaticMaterial; // rax
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  struct HGASMManager__Class *v9; // rcx
		  Material *v10; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Int32Enum__Enum v13; // edi
		  float v14; // xmm0_4
		  int v15; // xmm1_4
		  Int32Enum__Enum v16; // eax
		  float v17; // xmm0_4
		  float v18; // xmm0_4
		  float v19; // xmm6_4
		  uint32_t s_asmManagerCullingMask; // ebx
		  uint32_t v21; // ebx
		  uint32_t v22; // ebx
		  uint32_t v23; // ebx
		  struct HGASMManager__Class *v24; // rdx
		  uint32_t v25; // ebx
		  struct HGCamera__Class *v26; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v28; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2065, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2065, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)shadowClearShader,
		        (Object *)settingParameters,
		        0LL);
		      return;
		    }
		LABEL_23:
		    sub_1800D8260(v12, v11);
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		  StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                     shadowClearShader,
		                     0,
		                     0LL);
		  v9 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  v10 = StaticMaterial;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v9 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  }
		  v9->static_fields->s_clearShadowMaterial = v10;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_clearShadowMaterial,
		    v6,
		    v7,
		    v8,
		    v28);
		  if ( !settingParameters )
		    goto LABEL_23;
		  v13 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._asmShadowMapTileResolution_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmTileResolution = sub_18301DE80(v13, 64LL, 512LL);
		  v14 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmMaxDistance_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v15 = 1106247680;
		  if ( v14 < 30.0 || (v15 = 1157234688, v14 > 2000.0) )
		    v14 = *(float *)&v15;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius = v14;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmGridSize = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius
		                                                                               * 0.25;
		  v16 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._asmMaxTileRenderCountPerFrame_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmMaxTileRenderCountPerFrame = sub_18301DE80(
		                                                                                                     v16,
		                                                                                                     1LL,
		                                                                                                     128LL);
		  v17 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmDepthBias_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( v17 < 0.0 )
		  {
		    v17 = 0.0;
		  }
		  else if ( v17 > 8.0 )
		  {
		    v17 = 8.0;
		  }
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmDepthBias = v17;
		  v18 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmNormalBias_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( v18 < 0.0 )
		  {
		    v18 = 0.0;
		  }
		  else if ( v18 > 4.0 )
		  {
		    v18 = 4.0;
		  }
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmNormalBias = v18;
		  v19 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmScreenSizeMin_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmScreenSizeMinSquared = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                                               settingParameters->fields._asmScreenSizeMin_k__BackingField,
		                                                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
		                                                                                           * v19;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask = -1;
		  s_asmManagerCullingMask = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask = s_asmManagerCullingMask & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"UI", 0LL) & 0x1F));
		  v21 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask = v21 & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"UIModel", 0LL) & 0x1F));
		  v22 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask = v22 & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"Hide", 0LL) & 0x1F));
		  v23 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask = v23 & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"Gacha", 0LL) & 0x1F));
		  v24 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  v25 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmManagerCullingMask;
		  v26 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v24 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    v26 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		  }
		  v24->static_fields->s_asmManagerCullingMask = v25 & ~v26->static_fields->COMPOUND_CHARACTER_LAYER_MASK;
		}
		
		public static void ReinitializeSettingParams(HGSettingParameters settingParameters) {} // 0x00000001838B2AE0-0x00000001838B2D30
		// Void ReinitializeSettingParams(HGSettingParameters)
		void HG::Rendering::Runtime::HGASMManager::ReinitializeSettingParams(
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Int32Enum__Enum v5; // edi
		  int32_t v6; // eax
		  struct HGASMManager__Class *v7; // rcx
		  int32_t v8; // edi
		  float v9; // xmm0_4
		  int v10; // xmm1_4
		  Int32Enum__Enum v11; // eax
		  float v12; // xmm0_4
		  float v13; // xmm0_4
		  float v14; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(432, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(432, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)settingParameters,
		        0LL);
		      return;
		    }
		LABEL_19:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !settingParameters )
		    goto LABEL_19;
		  v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._asmShadowMapTileResolution_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  v6 = sub_18301DE80(v5, 64LL, 512LL);
		  v7 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  v8 = v6;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v7 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		  }
		  v7->static_fields->s_asmTileResolution = v8;
		  v9 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		         settingParameters->fields._asmMaxDistance_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v10 = 1106247680;
		  if ( v9 < 30.0 || (v10 = 1157234688, v9 > 2000.0) )
		    v9 = *(float *)&v10;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius = v9;
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmGridSize = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius
		                                                                               * 0.25;
		  v11 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._asmMaxTileRenderCountPerFrame_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmMaxTileRenderCountPerFrame = sub_18301DE80(
		                                                                                                     v11,
		                                                                                                     1LL,
		                                                                                                     128LL);
		  v12 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmDepthBias_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( v12 < 0.0 )
		  {
		    v12 = 0.0;
		  }
		  else if ( v12 > 8.0 )
		  {
		    v12 = 8.0;
		  }
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmDepthBias = v12;
		  v13 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmNormalBias_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( v13 < 0.0 )
		  {
		    v13 = 0.0;
		  }
		  else if ( v13 > 4.0 )
		  {
		    v13 = 4.0;
		  }
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmNormalBias = v13;
		  v14 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParameters->fields._asmScreenSizeMin_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmScreenSizeMinSquared = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                                               settingParameters->fields._asmScreenSizeMin_k__BackingField,
		                                                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
		                                                                                           * v14;
		  HG::Rendering::Runtime::HGASMManager::ForceRegenerateASM(0LL);
		}
		
		public static void ForceRegenerateASM() {} // 0x00000001838B2D30-0x00000001838B3250
		// Void ForceRegenerateASM()
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGASMManager::ForceRegenerateASM(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // rcx
		  struct HGCamera__Class *v3; // rax
		  HGCamera__StaticFields *static_fields; // rax
		  IEnumerable_1_System_Object_ *Values; // rax
		  List_1_System_Object_ *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Type *v9; // rdx
		  __int64 v10; // rcx
		  struct HGASMManager__Class *v11; // rax
		  Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_asmManagers; // r9
		  unsigned __int64 v13; // rdx
		  signed __int64 v14; // rcx
		  signed __int64 v15; // rtt
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  Object *key; // xmm6_8
		  unsigned __int64 v19; // xmm0_8
		  RTHandle *v20; // rcx
		  __m128 v21; // xmm7
		  struct HGASMManager__Class *v22; // rax
		  Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_cachedASMManagers; // r9
		  unsigned __int64 v24; // rdx
		  signed __int64 v25; // rtt
		  Type *v26; // rdx
		  __int64 v27; // rcx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Object *v30; // xmm6_8
		  unsigned __int64 v31; // xmm0_8
		  HGASMManager *v32; // rbx
		  RTHandle *v33; // rcx
		  __int64 v34; // rdx
		  struct HGASMManager__Class *v35; // rax
		  Dictionary_2_System_Object_System_Object_ *v36; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  _BYTE v40[32]; // [rsp+0h] [rbp-C8h] BYREF
		  _BYTE v41[40]; // [rsp+20h] [rbp-A8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v42; // [rsp+48h] [rbp-80h] BYREF
		  List_1_T_Enumerator_System_Object_ v43; // [rsp+70h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v44; // [rsp+88h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v45; // [rsp+90h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v46; // [rsp+98h] [rbp-30h] BYREF
		  Object *value; // [rsp+D8h] [rbp+10h] BYREF
		
		  memset(&v42, 0, sizeof(v42));
		  value = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(439, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v39, v38);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGCamera;
		    }
		    static_fields = v3->static_fields;
		    if ( !static_fields->s_Cameras )
		      sub_1800D8260(v2, v1);
		    Values = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,Beyond::ObjectPtr<System::Object>>::get_Values(
		                                               (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *)static_fields->s_Cameras,
		                                               MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Values);
		    v6 = System::Linq::Enumerable::ToList<System::Object>(
		           Values,
		           MethodInfo::System::Linq::Enumerable::ToList<HG::Rendering::Runtime::HGCamera>);
		    if ( !v6 )
		      sub_1800D8260(v8, v7);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)v41,
		      (List_1_System_UInt64_ *)v6,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCamera>::GetEnumerator);
		    v43 = *(List_1_T_Enumerator_System_Object_ *)v41;
		    *(_QWORD *)v41 = 0LL;
		    *(_QWORD *)&v41[8] = &v43;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v43,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCamera>::MoveNext) )
		      {
		        if ( !v43._current )
		          sub_1800D8250(v10, v9);
		        LOBYTE(v43._current[116].monitor) = 1;
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v44 )
		    {
		      v9 = (Type *)v40;
		      *(Il2CppExceptionWrapper *)v41 = (Il2CppExceptionWrapper)v44->ex;
		      v10 = *(_QWORD *)v41;
		      if ( *(_QWORD *)v41 )
		        sub_18007E1E0(*(_QWORD *)v41);
		    }
		    v11 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v11 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    s_asmManagers = v11->static_fields->s_asmManagers;
		    if ( !s_asmManagers )
		      goto LABEL_56;
		    memset(&v41[8], 0, 32);
		    *(_QWORD *)v41 = s_asmManagers;
		    if ( dword_18F35FD08 )
		    {
		      v13 = (((unsigned __int64)v41 >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v13 + 36190]);
		      do
		      {
		        v14 = qword_18F0BCBA0[v13 + 36190] | (1LL << (((unsigned __int64)v41 >> 12) & 0x3F));
		        v15 = qword_18F0BCBA0[v13 + 36190];
		      }
		      while ( v15 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v13 + 36190], v14, v15) );
		    }
		    *(_QWORD *)&v41[8] = (unsigned int)s_asmManagers->fields._version;
		    *(_DWORD *)&v41[32] = 2;
		    *(_OWORD *)&v41[16] = 0LL;
		    *(_OWORD *)&v42._dictionary = *(_OWORD *)v41;
		    v42._current = 0LL;
		    *(_QWORD *)&v42._getEnumeratorRetType = *(_QWORD *)&v41[32];
		    *(_QWORD *)v41 = 0LL;
		    *(_QWORD *)&v41[8] = &v42;
		    try
		    {
		      v21 = 0LL;
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
		                &v42,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext) )
		      {
		        key = v42._current.key;
		        v19 = _mm_srli_si128((__m128i)v42._current, 8).m128i_u64[0];
		        if ( !v19 )
		          sub_1800D8250(v10, v9);
		        v20 = *(RTHandle **)(v19 + 56);
		        if ( v20 )
		          UnityEngine::Rendering::RTHandle::Release(v20, 0LL);
		        *(_QWORD *)(v19 + 56) = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)(v19 + 56), v9, v16, v17, *(MethodInfo **)v41);
		        *(_QWORD *)(v19 + 216) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        *(_DWORD *)(v19 + 224) = 0;
		        HG::Rendering::Runtime::HGASMManager::Initialize((HGASMManager *)v19, (Camera *)key, 0LL, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v45 )
		    {
		      v9 = (Type *)v40;
		      *(Il2CppExceptionWrapper *)v41 = (Il2CppExceptionWrapper)v45->ex;
		      v10 = *(_QWORD *)v41;
		      if ( *(_QWORD *)v41 )
		        sub_18007E1E0(*(_QWORD *)v41);
		      v21 = 0LL;
		    }
		    v22 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v22 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    s_cachedASMManagers = v22->static_fields->s_cachedASMManagers;
		    if ( !s_cachedASMManagers )
		LABEL_56:
		      sub_1800D8250(v10, v9);
		    memset(&v41[8], 0, 32);
		    *(_QWORD *)v41 = s_cachedASMManagers;
		    if ( dword_18F35FD08 )
		    {
		      v24 = (((unsigned __int64)v41 >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v24 + 36190]);
		      do
		        v25 = qword_18F0BCBA0[v24 + 36190];
		      while ( v25 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v24 + 36190],
		                       v25 | (1LL << (((unsigned __int64)v41 >> 12) & 0x3F)),
		                       v25) );
		    }
		    *(_QWORD *)&v41[8] = (unsigned int)s_cachedASMManagers->fields._version;
		    *(_DWORD *)&v41[32] = 2;
		    *(_OWORD *)&v42._dictionary = *(_OWORD *)v41;
		    v42._current = 0LL;
		    *(_QWORD *)&v42._getEnumeratorRetType = *(_QWORD *)&v41[32];
		    *(_QWORD *)v41 = 0LL;
		    *(_QWORD *)&v41[8] = &v42;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
		                &v42,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext) )
		      {
		        v30 = v42._current.key;
		        v31 = _mm_srli_si128((__m128i)v42._current, 8).m128i_u64[0];
		        v32 = (HGASMManager *)v31;
		        if ( !v31 )
		          sub_1800D8250(v27, v26);
		        v33 = *(RTHandle **)(v31 + 56);
		        if ( v33 )
		          UnityEngine::Rendering::RTHandle::Release(v33, 0LL);
		        *(_QWORD *)(v31 + 56) = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)(v31 + 56), v26, v28, v29, *(MethodInfo **)v41);
		        *(_QWORD *)(v31 + 216) = _mm_unpacklo_ps(v21, v21).m128_u64[0];
		        *(_DWORD *)(v31 + 224) = v21.m128_i32[0];
		        v35 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		          v35 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		        }
		        v36 = (Dictionary_2_System_Object_System_Object_ *)v35->static_fields->s_asmManagers;
		        if ( !v36 )
		          sub_1800D8250(0LL, v34);
		        if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
		               v36,
		               v30,
		               &value,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::TryGetValue)
		          && value )
		        {
		          HG::Rendering::Runtime::HGASMManager::Initialize(v32, (Camera *)v30, (RTHandle *)value[3].monitor, 0LL);
		        }
		        else
		        {
		          HG::Rendering::Runtime::HGASMManager::Initialize(v32, (Camera *)v30, 0LL, 0LL);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v46 )
		    {
		      *(Il2CppExceptionWrapper *)v41 = (Il2CppExceptionWrapper)v46->ex;
		      if ( *(_QWORD *)v41 )
		        sub_18007E1E0(*(_QWORD *)v41);
		    }
		  }
		}
		
		public static void SetForceUpdateAllTilesMode(bool enabled) {} // 0x0000000183DDCFC0-0x0000000183DDD010
		// Void SetForceUpdateAllTilesMode(Boolean)
		void HG::Rendering::Runtime::HGASMManager::SetForceUpdateAllTilesMode(bool enabled, MethodInfo *method)
		{
		  struct HGASMManager__Class *v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2066, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2066, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_30 *)Patch, enabled, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
		    }
		    v3->static_fields->s_forceUpdateAllTilesMode = enabled;
		  }
		}
		
		[IDTag(1)]
		private static void GetASMShadowMatrixes(Vector2 lightSpaceMins, Vector2 lightSpaceMaxs, Vector3 lightDir, Quaternion lightRotation, Matrix4x4 oldLightToWorld, float zMin, float zMax, float minY, float maxY, out Matrix4x4 worldToLightMatrix, out Matrix4x4 projectionMatrix) {
			worldToLightMatrix = default;
			projectionMatrix = default;
		} // 0x0000000189D179E0-0x0000000189D17D4C
		// Void GetASMShadowMatrixes(Vector2, Vector2, Vector3, Quaternion, Matrix4x4, Single, Single, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
		        Vector2 lightSpaceMins,
		        Vector2 lightSpaceMaxs,
		        Vector3 *lightDir,
		        Quaternion *lightRotation,
		        Matrix4x4 *oldLightToWorld,
		        float zMin,
		        float zMax,
		        float minY,
		        float maxY,
		        Matrix4x4 *worldToLightMatrix,
		        Matrix4x4 *projectionMatrix,
		        MethodInfo *method)
		{
		  Vector2 v16; // r8
		  Vector2 v17; // r9
		  Vector2 v18; // rax
		  Vector2 v19; // rdx
		  Vector2 v20; // r8
		  int32_t v21; // r9d
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  MethodInfo *v24; // r8
		  Vector3 *v25; // rax
		  float z; // ecx
		  MethodInfo *v27; // r9
		  Vector3 *v28; // rax
		  __int64 v29; // rdx
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  __int64 v32; // xmm10_8
		  float v33; // ebx
		  Beyond::DampingMath *v34; // rcx
		  float v35; // xmm9_4
		  __m128 v36; // xmm7
		  __m128 v37; // xmm6
		  __int64 v38; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int128 v42; // xmm1
		  Quaternion v43; // xmm0
		  Vector3 v44; // [rsp+78h] [rbp-90h] BYREF
		  Vector4 v45; // [rsp+88h] [rbp-80h] BYREF
		  Vector4 v46; // [rsp+98h] [rbp-70h] BYREF
		  unsigned __int128 v47; // [rsp+A8h] [rbp-60h]
		  Quaternion v48; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v49[2]; // [rsp+C8h] [rbp-40h] BYREF
		
		  v47 = __PAIR128__(*(_QWORD *)&lightSpaceMins, *(_QWORD *)&lightSpaceMaxs);
		  if ( IFix::WrappersManagerImpl::IsPatched(2067, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2067, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v38);
		    v40 = *(_OWORD *)&oldLightToWorld->m01;
		    *(_OWORD *)&v49[0].m00 = *(_OWORD *)&oldLightToWorld->m00;
		    v41 = *(_OWORD *)&oldLightToWorld->m02;
		    *(_OWORD *)&v49[0].m01 = v40;
		    v42 = *(_OWORD *)&oldLightToWorld->m03;
		    v45.z = lightDir->z;
		    *(_OWORD *)&v49[0].m02 = v41;
		    v43 = *lightRotation;
		    *(_OWORD *)&v49[0].m03 = v42;
		    *(_QWORD *)&v42 = *(_QWORD *)&lightDir->x;
		    v48 = v43;
		    *(_QWORD *)&v45.x = v42;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_831(
		      Patch,
		      lightSpaceMins,
		      lightSpaceMaxs,
		      (Vector3 *)&v45,
		      &v48,
		      v49,
		      zMin,
		      zMax,
		      minY,
		      maxY,
		      worldToLightMatrix,
		      projectionMatrix,
		      0LL);
		  }
		  else
		  {
		    v18 = sub_1853DF234(lightSpaceMins, lightSpaceMaxs, v16, v17);
		    *(_QWORD *)&v45.z = 0x3F80000000000000LL;
		    *(Vector2 *)&v44.x = sub_1858CACF0(v18, v19, v20, v21);
		    v22 = *(_OWORD *)&oldLightToWorld->m00;
		    *(_QWORD *)&v45.x = *(_QWORD *)&v44.x;
		    *(_OWORD *)&v49[0].m00 = v22;
		    v23 = *(_OWORD *)&oldLightToWorld->m01;
		    *(_OWORD *)&v49[0].m02 = *(_OWORD *)&oldLightToWorld->m02;
		    *(_OWORD *)&v49[0].m01 = v23;
		    *(_OWORD *)&v49[0].m03 = *(_OWORD *)&oldLightToWorld->m03;
		    v46 = *UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v48, v49, &v45, 0LL);
		    v25 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v45, &v46, v24);
		    *(_QWORD *)&v46.x = *(_QWORD *)&lightDir->x;
		    z = v25->z;
		    *(_QWORD *)&v44.x = *(_QWORD *)&v25->x;
		    v44.z = z;
		    v46.z = lightDir->z;
		    v28 = UnityEngine::Vector3::op_Multiply(&v44, (float)(maxY - v44.y) / lightDir->y, (Vector3 *)&v46, v27);
		    *(_QWORD *)&v23 = *(_QWORD *)v29;
		    *(_QWORD *)&v22 = *(_QWORD *)&v28->x;
		    v46.z = v28->z;
		    LODWORD(v28) = *(_DWORD *)(v29 + 8);
		    *(_QWORD *)&v46.x = v22;
		    *(_QWORD *)&v44.x = v23;
		    LODWORD(v44.z) = (_DWORD)v28;
		    v31 = UnityEngine::Vector3::op_Addition((Vector3 *)&v45, &v44, (Vector3 *)&v46, v30);
		    v32 = *(_QWORD *)&v31->x;
		    v33 = v31->z;
		    *(float *)&v23 = (float)(*(float *)sub_182F3F6C0(&v45, lightRotation) / 180.0) * 3.1415927;
		    Beyond::DampingMath::sinf(v34, *(float *)&v22);
		    v35 = (float)(maxY - minY) / fabs(*(float *)&v23);
		    if ( v35 < 100.0 )
		    {
		      v35 = 100.0;
		    }
		    else if ( v35 > 100000.0 )
		    {
		      v35 = 100000.0;
		    }
		    v36 = (__m128)HIDWORD(v47);
		    v37 = (__m128)DWORD1(v47);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v48 = *lightRotation;
		    *(_QWORD *)&v44.x = _mm_unpacklo_ps((__m128)(unsigned int)v47, v37).m128_u64[0];
		    *(_QWORD *)&v45.x = _mm_unpacklo_ps((__m128)DWORD2(v47), v36).m128_u64[0];
		    v44.z = v35;
		    v45.z = zMin;
		    *(_QWORD *)&v46.x = v32;
		    v46.z = v33;
		    HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
		      (Vector3 *)&v45,
		      &v44,
		      (Vector3 *)&v46,
		      &v48,
		      worldToLightMatrix,
		      projectionMatrix,
		      0LL);
		  }
		}
		
		[IDTag(0)]
		private static void GetASMShadowMatrixes(Vector3 mins, Vector3 maxs, Vector3 lightPos, Quaternion lightRotation, out Matrix4x4 worldToLightMatrix, out Matrix4x4 projectionMatrix) {
			worldToLightMatrix = default;
			projectionMatrix = default;
		} // 0x0000000189D17D4C-0x0000000189D180EC
		// Void GetASMShadowMatrixes(Vector3, Vector3, Vector3, Quaternion, Matrix4x4 ByRef, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
		        Vector3 *mins,
		        Vector3 *maxs,
		        Vector3 *lightPos,
		        Quaternion *lightRotation,
		        Matrix4x4 *worldToLightMatrix,
		        Matrix4x4 *projectionMatrix,
		        MethodInfo *method)
		{
		  float z; // eax
		  float3 *xyz; // rax
		  __int64 v13; // xmm7_8
		  float v14; // edi
		  __int64 v15; // rax
		  __int64 v16; // xmm0_8
		  MethodInfo *v17; // r8
		  float3 *v18; // rax
		  __int64 v19; // xmm6_8
		  float v20; // ebx
		  __int64 v21; // rax
		  __int64 v22; // xmm0_8
		  Vector4 *AsVector4; // rax
		  float4x4 *v24; // rax
		  float4 c1; // xmm1
		  float4 c2; // xmm0
		  float4 c3; // xmm1
		  Matrix4x4 *v28; // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm2
		  __int128 v31; // xmm3
		  int v32; // edx
		  int v33; // r8d
		  int v34; // r9d
		  __int64 v35; // rax
		  float4 v36; // xmm1
		  float4 v37; // xmm0
		  float4 v38; // xmm1
		  Matrix4x4 *v39; // rax
		  __int64 v40; // rcx
		  __int128 v41; // xmm1
		  __int128 v42; // xmm2
		  __int128 v43; // xmm3
		  float *p_m10; // rax
		  __int64 v45; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Quaternion v47; // xmm0
		  __int64 v48; // xmm1_8
		  float4 v49; // [rsp+48h] [rbp-C0h] BYREF
		  Vector4 v50; // [rsp+58h] [rbp-B0h] BYREF
		  Vector4 v51; // [rsp+68h] [rbp-A0h] BYREF
		  Quaternion v52; // [rsp+78h] [rbp-90h] BYREF
		  float4x4 v53; // [rsp+88h] [rbp-80h] BYREF
		  float4x4 v54; // [rsp+C8h] [rbp-40h] BYREF
		
		  sub_18033B9D0(&v54, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2068, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2068, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v45);
		    v47 = *lightRotation;
		    v51.z = lightPos->z;
		    v48 = *(_QWORD *)&lightPos->x;
		    v49.z = maxs->z;
		    v50.z = mins->z;
		    v52 = v47;
		    *(_QWORD *)&v49.x = *(_QWORD *)&maxs->x;
		    *(_QWORD *)&v47.x = *(_QWORD *)&mins->x;
		    *(_QWORD *)&v51.x = v48;
		    *(_QWORD *)&v50.x = *(_QWORD *)&v47.x;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_830(
		      Patch,
		      (Vector3 *)&v50,
		      (Vector3 *)&v49,
		      (Vector3 *)&v51,
		      &v52,
		      worldToLightMatrix,
		      projectionMatrix,
		      0LL);
		  }
		  else
		  {
		    z = lightPos->z;
		    *(_QWORD *)&v49.x = *(_QWORD *)&lightPos->x;
		    v49.z = z;
		    xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v50, &v49, 0LL);
		    v13 = *(_QWORD *)&xyz->x;
		    v14 = xyz->z;
		    v50 = (Vector4)*lightRotation;
		    v51 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		             (Vector4 *)&v52,
		             (CinemachineSmoothPath_Waypoint *)&v50,
		             0LL);
		    v15 = sub_185F0E3A0(&v50, &v51);
		    v16 = *(_QWORD *)v15;
		    LODWORD(v15) = *(_DWORD *)(v15 + 8);
		    *(_QWORD *)&v49.x = v16;
		    LODWORD(v49.z) = v15;
		    v18 = Unity::Mathematics::float3::op_UnaryNegation((float3 *)&v50, (float3 *)&v49, v17);
		    v19 = *(_QWORD *)&v18->x;
		    v20 = v18->z;
		    v50 = (Vector4)*lightRotation;
		    v49.z = 0.0;
		    *(_QWORD *)&v49.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		    v51 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		             (Vector4 *)&v52,
		             (CinemachineSmoothPath_Waypoint *)&v50,
		             0LL);
		    v21 = sub_182FACF20(&v50, &v51, &v49);
		    *(_QWORD *)&v51.x = v19;
		    v51.z = v20;
		    v22 = *(_QWORD *)v21;
		    LODWORD(v21) = *(_DWORD *)(v21 + 8);
		    *(_QWORD *)&v49.x = v22;
		    LODWORD(v49.z) = v21;
		    v50 = (Vector4)*Unity::Mathematics::quaternion::LookRotationSafe(
		                      (quaternion *)&v52,
		                      (float3 *)&v51,
		                      (float3 *)&v49,
		                      0LL);
		    AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                  (Vector4 *)&v52,
		                  (CinemachineSmoothPath_Waypoint *)&v50,
		                  0LL);
		    *(_QWORD *)&v51.x = v13;
		    v51.z = v14;
		    v50 = *AsVector4;
		    v50 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		             (Vector4 *)&v52,
		             (CinemachineSmoothPath_Waypoint *)&v50,
		             0LL);
		    Unity::Mathematics::float4x4::float4x4(&v54, (quaternion *)&v50, (float3 *)&v51, 0LL);
		    v53 = v54;
		    v24 = Unity::Mathematics::math::inverse(&v54, &v53, 0LL);
		    c1 = v24->c1;
		    v53.c0 = v24->c0;
		    c2 = v24->c2;
		    v53.c1 = c1;
		    c3 = v24->c3;
		    v53.c2 = c2;
		    v53.c3 = c3;
		    v28 = Unity::Mathematics::float4x4::op_Implicit((Matrix4x4 *)&v54, &v53, 0LL);
		    v29 = *(_OWORD *)&v28->m01;
		    v30 = *(_OWORD *)&v28->m02;
		    v31 = *(_OWORD *)&v28->m03;
		    *(_OWORD *)&worldToLightMatrix->m00 = *(_OWORD *)&v28->m00;
		    c2.x = maxs->z;
		    *(_OWORD *)&worldToLightMatrix->m01 = v29;
		    *(_OWORD *)&worldToLightMatrix->m02 = v30;
		    *(_OWORD *)&worldToLightMatrix->m03 = v31;
		    v35 = sub_1833A3CB0((unsigned int)&v54, v32, v33, v34, LODWORD(c2.x));
		    v36 = *(float4 *)(v35 + 16);
		    v53.c0 = *(float4 *)v35;
		    v37 = *(float4 *)(v35 + 32);
		    v53.c1 = v36;
		    v38 = *(float4 *)(v35 + 48);
		    v53.c2 = v37;
		    v53.c3 = v38;
		    v39 = Unity::Mathematics::float4x4::op_Implicit((Matrix4x4 *)&v54, &v53, 0LL);
		    v40 = 4LL;
		    v41 = *(_OWORD *)&v39->m01;
		    v42 = *(_OWORD *)&v39->m02;
		    v43 = *(_OWORD *)&v39->m03;
		    *(_OWORD *)&projectionMatrix->m00 = *(_OWORD *)&v39->m00;
		    *(_OWORD *)&projectionMatrix->m01 = v41;
		    *(_OWORD *)&projectionMatrix->m02 = v42;
		    *(_OWORD *)&projectionMatrix->m03 = v43;
		    p_m10 = &projectionMatrix->m10;
		    do
		    {
		      *p_m10 = -*p_m10;
		      p_m10 += 4;
		      --v40;
		    }
		    while ( v40 );
		  }
		}
		
		public void SetASMUpdateMode(ASMUpdateMode mode) {} // 0x0000000189D19670-0x0000000189D196CC
		// Void SetASMUpdateMode(HGASMManager+ASMUpdateMode)
		void HG::Rendering::Runtime::HGASMManager::SetASMUpdateMode(
		        HGASMManager *this,
		        HGASMManager_ASMUpdateMode__Enum mode,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2073, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2073, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, mode, 0LL);
		  }
		  else
		  {
		    this->fields.m_asmUpdateMode = mode;
		  }
		}
		
		public ASMUpdateMode GetASMUpdateMode() => default; // 0x0000000189D180EC-0x0000000189D1813C
		// HGASMManager+ASMUpdateMode GetASMUpdateMode()
		HGASMManager_ASMUpdateMode__Enum HG::Rendering::Runtime::HGASMManager::GetASMUpdateMode(
		        HGASMManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2074, 0LL) )
		    return this->fields.m_asmUpdateMode;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2074, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetStartVTIndex(int startVTIndex) {} // 0x0000000189D19E3C-0x0000000189D19E98
		// Void SetStartVTIndex(Int32)
		void HG::Rendering::Runtime::HGASMManager::SetStartVTIndex(
		        HGASMManager *this,
		        int32_t startVTIndex,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2062, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2062, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      startVTIndex,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_startVTIdx = startVTIndex;
		  }
		}
		
		public void Initialize(Camera camera, RTHandle existingRT = null) {} // 0x0000000189D181F4-0x0000000189D18418
		// Void Initialize(Camera, RTHandle)
		void HG::Rendering::Runtime::HGASMManager::Initialize(
		        HGASMManager *this,
		        Camera *camera,
		        RTHandle *existingRT,
		        MethodInfo *method)
		{
		  HGASMVirtualTextureAllocator *m_vtAllocator; // r14
		  ASMTileManager *m_asmTileManager; // rcx
		  HGASMManager__StaticFields *static_fields; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  HGCamera *v12; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  float asmCasterMinY; // xmm2_4
		  int32_t s_asmTileResolution; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *colorFormat; // [rsp+20h] [rbp-100h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(440, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(440, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        (Object *)existingRT,
		        0LL);
		      return;
		    }
		    goto LABEL_13;
		  }
		  m_vtAllocator = this->fields.m_vtAllocator;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		  if ( !m_vtAllocator )
		    goto LABEL_13;
		  HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(
		    m_vtAllocator,
		    static_fields->s_asmTileResolution,
		    0LL);
		  m_asmTileManager = this->fields.m_asmTileManager;
		  if ( !m_asmTileManager )
		    goto LABEL_13;
		  HG::Rendering::Runtime::ASMTileManager::Initialize(m_asmTileManager, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality((Object_1 *)camera, 0LL, 0LL) )
		    goto LABEL_7;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v12 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v12, 0LL);
		  if ( !InterpolatedPhase )
		LABEL_13:
		    sub_1800D8260(m_asmTileManager, static_fields);
		  asmCasterMinY = InterpolatedPhase->fields.shadowConfig.asmCasterMinY;
		  LODWORD(this->fields.m_asmCasterMaxY) = _mm_shuffle_ps(
		                                            *(__m128 *)&InterpolatedPhase->fields.shadowConfig.csmShadowSoftness,
		                                            *(__m128 *)&InterpolatedPhase->fields.shadowConfig.csmShadowSoftness,
		                                            170).m128_u32[0];
		  this->fields.m_asmCasterMinY = asmCasterMinY;
		LABEL_7:
		  if ( !this->fields.m_asmShadowMapRT )
		  {
		    if ( existingRT )
		    {
		      this->fields.m_asmShadowMapRT = existingRT;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      s_asmTileResolution = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmTileResolution;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_asmShadowMapRT = UnityEngine::Rendering::RTHandles::Alloc(
		                                        16 * s_asmTileResolution,
		                                        16 * s_asmTileResolution,
		                                        1,
		                                        DepthBits__Enum_Depth16,
		                                        GraphicsFormat__Enum_R8G8B8A8_SRGB,
		                                        FilterMode__Enum_Point,
		                                        TextureWrapMode__Enum_Clamp,
		                                        TextureDimension__Enum_Tex2D,
		                                        0,
		                                        0,
		                                        0,
		                                        1,
		                                        1,
		                                        0.0,
		                                        MSAASamples__Enum_None,
		                                        0,
		                                        RenderTextureMemoryless__Enum_None,
		                                        (String *)"ASM Shadowmap",
		                                        0LL);
		    }
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_asmShadowMapRT, (Type *)static_fields, v10, v11, colorFormat);
		  }
		}
		
		public void UpdateFrustumVerts(Camera camera, Vector3 cameraPos) {} // 0x0000000189D1A654-0x0000000189D1AE9C
		// Void UpdateFrustumVerts(Camera, Vector3)
		void HG::Rendering::Runtime::HGASMManager::UpdateFrustumVerts(
		        HGASMManager *this,
		        Camera *camera,
		        Vector3 *cameraPos,
		        MethodInfo *method)
		{
		  Matrix4x4 *inverse; // rax
		  __int64 v8; // rdx
		  ASMTileManager *m_asmTileManager; // rcx
		  __int128 v10; // xmm10
		  __int128 v11; // xmm11
		  __int128 v12; // xmm12
		  __int128 v13; // xmm13
		  float v14; // xmm9_4
		  int32_t pixelWidth; // ebx
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // r8
		  __int64 v19; // r9
		  float v20; // xmm0_4
		  float pixelHeight; // xmm1_4
		  float v22; // xmm6_4
		  Beyond::DampingMath *v23; // rcx
		  __m128i si128; // xmm8
		  HGASMManager__StaticFields *static_fields; // rbx
		  Beyond::DampingMath *v26; // rcx
		  float v27; // xmm7_4
		  Beyond::DampingMath *v28; // rcx
		  float v29; // xmm7_4
		  __m128i v30; // xmm6
		  float farClipPlane; // xmm0_4
		  float y; // xmm1_4
		  MethodInfo *v33; // r8
		  Vector3 *v34; // rax
		  float z; // ecx
		  Transform *transform; // rax
		  MethodInfo *localRotation; // rax
		  Vector3 *one; // rax
		  Vector4 *v39; // rdx
		  Vector4 v40; // xmm0
		  __int64 v41; // xmm1_8
		  float v42; // ecx
		  __int64 v43; // xmm1_8
		  Matrix4x4 *v44; // rax
		  float v45; // xmm1_4
		  __int128 v46; // xmm7
		  __int128 v47; // xmm8
		  __int128 v48; // xmm9
		  __int128 v49; // xmm14
		  Vector2__Array *m_frustumVerts; // rax
		  Vector2__Array *m_frustumVertsForIndirect; // rax
		  float v52; // xmm1_4
		  int v53; // ebx
		  Vector3__Array *v54; // rsi
		  unsigned int *v55; // rax
		  unsigned int v56; // xmm6_4
		  __int64 v57; // rax
		  __int64 v58; // rax
		  MethodInfo *v59; // r8
		  Vector3 *v60; // rax
		  __int64 v61; // xmm3_8
		  Vector3__Array *m_frustumCornersLightSpace; // rsi
		  unsigned int *v63; // rax
		  unsigned int v64; // xmm6_4
		  __int64 v65; // rax
		  __int64 v66; // rax
		  MethodInfo *v67; // r8
		  Vector3 *v68; // rax
		  __int64 v69; // xmm0_8
		  float v70; // eax
		  Vector2__Array *v71; // rsi
		  float *v72; // rax
		  float v73; // xmm6_4
		  float v74; // xmm0_4
		  __int64 v75; // rax
		  Vector3__Array *v76; // rsi
		  unsigned int *v77; // rax
		  unsigned int v78; // xmm6_4
		  __int64 v79; // rax
		  __int64 v80; // rax
		  MethodInfo *v81; // r8
		  Vector3 *v82; // rax
		  __int64 v83; // xmm3_8
		  Vector3__Array *m_frustumCornersLightSpaceForIndirect; // rsi
		  float *v85; // rax
		  float v86; // xmm6_4
		  __int64 v87; // rax
		  float v88; // xmm0_4
		  __int64 v89; // rax
		  MethodInfo *v90; // r8
		  Vector3 *v91; // rax
		  __int64 v92; // xmm0_8
		  float v93; // eax
		  Vector2__Array *v94; // rsi
		  float *v95; // rax
		  float v96; // xmm6_4
		  float v97; // xmm0_4
		  __int64 v98; // rax
		  float v99; // eax
		  Vector3__Array *m_frustumCorners; // [rsp+28h] [rbp-E0h]
		  Vector3__Array *m_frustumCornersForIndirect; // [rsp+28h] [rbp-E0h]
		  Vector4 v102; // [rsp+38h] [rbp-D0h] BYREF
		  Vector4 v103; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v104; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v105; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v106; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v107; // [rsp+88h] [rbp-80h] BYREF
		  Vector4 v108; // [rsp+C8h] [rbp-40h] BYREF
		  Vector4 v109; // [rsp+D8h] [rbp-30h]
		  Vector4 v110; // [rsp+E8h] [rbp-20h]
		  Vector4 v111; // [rsp+F8h] [rbp-10h]
		  __int64 v112; // [rsp+108h] [rbp+0h] BYREF
		  int v113; // [rsp+110h] [rbp+8h]
		  Vector3 v114; // [rsp+118h] [rbp+10h] BYREF
		  Vector3 v115; // [rsp+128h] [rbp+20h] BYREF
		  Vector3 v116; // [rsp+138h] [rbp+30h] BYREF
		  Vector4 v117; // [rsp+148h] [rbp+40h] BYREF
		  Vector4 v118; // [rsp+158h] [rbp+50h] BYREF
		  Vector4 v119; // [rsp+168h] [rbp+60h] BYREF
		  Vector4 v120; // [rsp+178h] [rbp+70h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2075, 0LL) )
		  {
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v107, &this->fields.m_lightToWorld, 0LL);
		    v10 = *(_OWORD *)&inverse->m00;
		    v11 = *(_OWORD *)&inverse->m01;
		    v12 = *(_OWORD *)&inverse->m02;
		    v13 = *(_OWORD *)&inverse->m03;
		    if ( camera )
		    {
		      v14 = (float)(UnityEngine::Camera::get_fieldOfView(camera, 0LL) * 0.5) / 180.0;
		      UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		      pixelWidth = UnityEngine::Camera::get_pixelWidth(camera, 0LL);
		      v20 = sub_180338A80(v17, v16, v18, v19);
		      pixelHeight = (float)UnityEngine::Camera::get_pixelHeight(camera, 0LL);
		      v22 = (float)(v20 * (float)pixelWidth) / pixelHeight;
		      Beyond::DampingMath::fast_atan(v23, pixelHeight);
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		      Beyond::DampingMath::cosf(v26, pixelHeight);
		      v27 = v14 * 3.1415927;
		      Beyond::DampingMath::cosf(v28, pixelHeight);
		      if ( v22 <= (float)(v14 * 3.1415927) )
		        v27 = v22;
		      v29 = v27 * static_fields->s_asmCacheRadius;
		      m_frustumCorners = this->fields.m_frustumCorners;
		      v103 = (Vector4)si128;
		      UnityEngine::Camera::CalculateFrustumCorners(
		        camera,
		        (Rect *)&v103,
		        v29,
		        Camera_MonoOrStereoscopicEye__Enum_Mono,
		        m_frustumCorners,
		        0LL);
		      v30 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		      farClipPlane = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
		      m_frustumCornersForIndirect = this->fields.m_frustumCornersForIndirect;
		      v103 = (Vector4)v30;
		      UnityEngine::Camera::CalculateFrustumCorners(
		        camera,
		        (Rect *)&v103,
		        farClipPlane,
		        Camera_MonoOrStereoscopicEye__Enum_Mono,
		        m_frustumCornersForIndirect,
		        0LL);
		      y = cameraPos->y;
		      v108.x = cameraPos->x;
		      v108.z = cameraPos->z;
		      v108.y = y;
		      v108.w = 1.0;
		      *(_OWORD *)&v107.m00 = v10;
		      v103 = v108;
		      *(_OWORD *)&v107.m01 = v11;
		      *(_OWORD *)&v107.m02 = v12;
		      *(_OWORD *)&v107.m03 = v13;
		      v103 = *UnityEngine::Matrix4x4::op_Multiply(&v102, &v107, &v103, 0LL);
		      v34 = UnityEngine::Vector4::op_Implicit(&v104, &v103, v33);
		      z = v34->z;
		      *(_QWORD *)&this->fields.m_cameraPosLightSpace.x = *(_QWORD *)&v34->x;
		      this->fields.m_cameraPosLightSpace.z = z;
		      transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		      if ( transform )
		      {
		        localRotation = (MethodInfo *)UnityEngine::Transform::get_localRotation((Quaternion *)&v102, transform, 0LL);
		        one = UnityEngine::Vector3::get_one(&v104, localRotation);
		        v40 = *v39;
		        v41 = *(_QWORD *)&one->x;
		        v42 = one->z;
		        *(float *)&one = cameraPos->z;
		        *(_QWORD *)&v105.x = v41;
		        v43 = *(_QWORD *)&cameraPos->x;
		        v105.z = v42;
		        *(_QWORD *)&v106.x = v43;
		        v103 = v40;
		        LODWORD(v106.z) = (_DWORD)one;
		        v44 = UnityEngine::Matrix4x4::TRS(&v107, &v106, (Quaternion *)&v103, &v105, 0LL);
		        v45 = this->fields.m_cameraPosLightSpace.y;
		        v46 = *(_OWORD *)&v44->m00;
		        v47 = *(_OWORD *)&v44->m01;
		        v48 = *(_OWORD *)&v44->m02;
		        v49 = *(_OWORD *)&v44->m03;
		        m_frustumVerts = this->fields.m_frustumVerts;
		        if ( m_frustumVerts )
		        {
		          if ( !m_frustumVerts->max_length.size )
		            goto LABEL_36;
		          m_frustumVerts->vector[0].x = this->fields.m_cameraPosLightSpace.x;
		          m_frustumVerts->vector[0].y = v45;
		          m_frustumVertsForIndirect = this->fields.m_frustumVertsForIndirect;
		          v52 = this->fields.m_cameraPosLightSpace.y;
		          if ( !m_frustumVertsForIndirect )
		            goto LABEL_38;
		          if ( !m_frustumVertsForIndirect->max_length.size )
		LABEL_36:
		            sub_1800D2AB0(m_asmTileManager, v8);
		          m_frustumVertsForIndirect->vector[0].x = this->fields.m_cameraPosLightSpace.x;
		          v53 = 0;
		          m_frustumVertsForIndirect->vector[0].y = v52;
		          do
		          {
		            v54 = this->fields.m_frustumCorners;
		            m_asmTileManager = (ASMTileManager *)v54;
		            if ( !v54 )
		              goto LABEL_38;
		            v55 = (unsigned int *)sub_180002E90(v54, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCorners;
		            v56 = *v55;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v57 = sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCorners;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            *(_QWORD *)&v109.x = __PAIR64__(*(_DWORD *)(v57 + 4), v56);
		            v58 = sub_180002E90(m_asmTileManager, v53);
		            v109.w = 1.0;
		            *(_OWORD *)&v107.m00 = v46;
		            *(_OWORD *)&v107.m01 = v47;
		            v109.z = *(float *)(v58 + 8);
		            *(_OWORD *)&v107.m02 = v48;
		            v102 = v109;
		            *(_OWORD *)&v107.m03 = v49;
		            v102 = *UnityEngine::Matrix4x4::op_Multiply(&v117, &v107, &v102, 0LL);
		            v60 = UnityEngine::Vector4::op_Implicit(&v114, &v102, v59);
		            v61 = *(_QWORD *)&v60->x;
		            *(float *)&v60 = v60->z;
		            *(_QWORD *)&v106.x = v61;
		            LODWORD(v106.z) = (_DWORD)v60;
		            sub_180049BD0(v54, v53, &v106);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCorners;
		            m_frustumCornersLightSpace = this->fields.m_frustumCornersLightSpace;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v63 = (unsigned int *)sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCorners;
		            v64 = *v63;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v65 = sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCorners;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            *(_QWORD *)&v110.x = __PAIR64__(*(_DWORD *)(v65 + 4), v64);
		            v66 = sub_180002E90(m_asmTileManager, v53);
		            v110.w = 1.0;
		            *(_OWORD *)&v107.m00 = v10;
		            *(_OWORD *)&v107.m01 = v11;
		            v110.z = *(float *)(v66 + 8);
		            *(_OWORD *)&v107.m02 = v12;
		            v102 = v110;
		            *(_OWORD *)&v107.m03 = v13;
		            v102 = *UnityEngine::Matrix4x4::op_Multiply(&v118, &v107, &v102, 0LL);
		            v68 = UnityEngine::Vector4::op_Implicit(&v115, &v102, v67);
		            if ( !m_frustumCornersLightSpace )
		              goto LABEL_38;
		            v69 = *(_QWORD *)&v68->x;
		            v70 = v68->z;
		            *(_QWORD *)&v105.x = v69;
		            v105.z = v70;
		            sub_180049BD0(m_frustumCornersLightSpace, v53, &v105);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersLightSpace;
		            v71 = this->fields.m_frustumVerts;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v72 = (float *)sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersLightSpace;
		            v73 = *v72;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v74 = *(float *)(sub_180002E90(m_asmTileManager, v53) + 4);
		            if ( !v71 )
		              goto LABEL_38;
		            v75 = v53 + 1LL;
		            if ( (unsigned int)v75 >= v71->max_length.size )
		              goto LABEL_36;
		            v71->vector[v75].x = v73;
		            v71->vector[v75].y = v74;
		            v76 = this->fields.m_frustumCornersForIndirect;
		            m_asmTileManager = (ASMTileManager *)v76;
		            if ( !v76 )
		              goto LABEL_38;
		            v77 = (unsigned int *)sub_180002E90(v76, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersForIndirect;
		            v78 = *v77;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v79 = sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersForIndirect;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            *(_QWORD *)&v111.x = __PAIR64__(*(_DWORD *)(v79 + 4), v78);
		            v80 = sub_180002E90(m_asmTileManager, v53);
		            v111.w = 1.0;
		            *(_OWORD *)&v107.m00 = v46;
		            *(_OWORD *)&v107.m01 = v47;
		            v111.z = *(float *)(v80 + 8);
		            *(_OWORD *)&v107.m02 = v48;
		            v102 = v111;
		            *(_OWORD *)&v107.m03 = v49;
		            v102 = *UnityEngine::Matrix4x4::op_Multiply(&v119, &v107, &v102, 0LL);
		            v82 = UnityEngine::Vector4::op_Implicit(&v116, &v102, v81);
		            v83 = *(_QWORD *)&v82->x;
		            *(float *)&v82 = v82->z;
		            v112 = v83;
		            v113 = (int)v82;
		            sub_180049BD0(v76, v53, &v112);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersForIndirect;
		            m_frustumCornersLightSpaceForIndirect = this->fields.m_frustumCornersLightSpaceForIndirect;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v85 = (float *)sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersForIndirect;
		            v86 = *v85;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v87 = sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersForIndirect;
		            v88 = *(float *)(v87 + 4);
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v103.x = v86;
		            v103.y = v88;
		            v89 = sub_180002E90(m_asmTileManager, v53);
		            v103.w = 1.0;
		            *(_OWORD *)&v107.m00 = v10;
		            *(_OWORD *)&v107.m01 = v11;
		            v103.z = *(float *)(v89 + 8);
		            *(_OWORD *)&v107.m02 = v12;
		            v102 = v103;
		            *(_OWORD *)&v107.m03 = v13;
		            v102 = *UnityEngine::Matrix4x4::op_Multiply(&v120, &v107, &v102, 0LL);
		            v91 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v108, &v102, v90);
		            if ( !m_frustumCornersLightSpaceForIndirect )
		              goto LABEL_38;
		            v92 = *(_QWORD *)&v91->x;
		            v93 = v91->z;
		            *(_QWORD *)&v104.x = v92;
		            v104.z = v93;
		            sub_180049BD0(m_frustumCornersLightSpaceForIndirect, v53, &v104);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersLightSpaceForIndirect;
		            v94 = this->fields.m_frustumVertsForIndirect;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v95 = (float *)sub_180002E90(m_asmTileManager, v53);
		            m_asmTileManager = (ASMTileManager *)this->fields.m_frustumCornersLightSpaceForIndirect;
		            v96 = *v95;
		            if ( !m_asmTileManager )
		              goto LABEL_38;
		            v97 = *(float *)(sub_180002E90(m_asmTileManager, v53) + 4);
		            if ( !v94 )
		              goto LABEL_38;
		            v98 = v53 + 1LL;
		            if ( (unsigned int)v98 >= v94->max_length.size )
		              goto LABEL_36;
		            ++v53;
		            v94->vector[v98].x = v96;
		            v94->vector[v98].y = v97;
		          }
		          while ( v53 < 4 );
		          m_asmTileManager = this->fields.m_asmTileManager;
		          if ( m_asmTileManager )
		          {
		            HG::Rendering::Runtime::ASMTileManager::SetFrustumVerts(
		              m_asmTileManager,
		              this->fields.m_frustumVerts,
		              this->fields.m_frustumVertsForIndirect,
		              0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_38:
		    sub_1800D8260(m_asmTileManager, v8);
		  }
		  m_asmTileManager = (ASMTileManager *)IFix::WrappersManagerImpl::GetPatch(2075, 0LL);
		  if ( !m_asmTileManager )
		    goto LABEL_38;
		  v99 = cameraPos->z;
		  *(_QWORD *)&v104.x = *(_QWORD *)&cameraPos->x;
		  v104.z = v99;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_836(
		    (ILFixDynamicMethodWrapper_2 *)m_asmTileManager,
		    (Object *)this,
		    (Object *)camera,
		    &v104,
		    0LL);
		}
		
		public void BeginFrame(HGCamera hgCamera, HGSettingParameters settingParams) {} // 0x0000000189D16EB4-0x0000000189D177D4
		// Void BeginFrame(HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGASMManager::BeginFrame(
		        HGASMManager *this,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParams,
		        MethodInfo *method)
		{
		  HGASMManager *v6; // rbx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Component *camera; // r13
		  Object_1 *SunSourceLight; // r14
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  bool v16; // r15
		  HGEnvironmentVolumeCameraComponent *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  HGEnvironmentPhase *interpolatedPhase; // rsi
		  Transform *transform; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  Transform *v26; // r14
		  __m128i v27; // xmm7
		  __int128 v28; // xmm8
		  __int128 v29; // xmm9
		  __int128 v30; // xmm10
		  __int128 v31; // xmm11
		  __int64 v32; // xmm0_8
		  unsigned int z_low; // eax
		  MethodInfo *v34; // rdx
		  Animator *v35; // rdx
		  int32_t v36; // r8d
		  MethodInfo *v37; // r9
		  Matrix4x4 *v38; // rax
		  Vector3 *forward; // rax
		  __m128i v40; // xmm3
		  unsigned __int64 v41; // xmm6_8
		  int v42; // r15d
		  HGASMVirtualTextureAllocator *m_vtAllocator; // rsi
		  __int64 v44; // rcx
		  HGASMManager__StaticFields *static_fields; // rdx
		  int32_t s_asmMaxTileRenderCountPerFrame; // esi
		  HGASMManager *m_friendASMManager; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  HGASMManager *v50; // r14
		  HGASMVirtualTextureAllocator *v51; // r14
		  __int64 v52; // rcx
		  HGASMManager__StaticFields *v53; // rdx
		  HGASMManager *v54; // r14
		  HGASMManager *v55; // r14
		  HGASMManager *v56; // r14
		  float y; // xmm7_4
		  Transform *v58; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  Vector3 *position; // rax
		  __int64 v62; // xmm8_8
		  float z; // r14d
		  HGASMManager__StaticFields *v64; // rcx
		  __m128 x_low; // xmm6
		  __m128 y_low; // xmm7
		  Vector2 v67; // rax
		  double v68; // xmm0_8
		  int32_t m_asmUpdateMode; // eax
		  MethodInfo *v70; // rdx
		  ProfilerMarker_AutoScope v71; // rdx
		  ASMTileManager *v72; // rsi
		  Vector2__Array *m_frustumVerts; // rcx
		  __int64 v74; // rcx
		  MethodInfo *v75; // rdx
		  ProfilerMarker_AutoScope v76; // rdx
		  ASMTileManager *v77; // rsi
		  Vector2__Array *v78; // rcx
		  __int64 v79; // rcx
		  HGASMManager__StaticFields *v80; // rdx
		  MethodInfo *v81; // rdx
		  ProfilerMarker_AutoScope v82; // rdx
		  ASMTileManager *v83; // rsi
		  HGASMVirtualTextureAllocator *v84; // r14
		  Vector2__Array *v85; // rcx
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  __int64 v88; // rdx
		  HGASMVirtualTextureAllocator *v89; // rcx
		  ASMTileManager *m_asmTileManager; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v92; // rdx
		  __int64 v93; // rcx
		  Vector3 centerPoint; // [rsp+30h] [rbp-138h] BYREF
		  Il2CppException *ex; // [rsp+40h] [rbp-128h] BYREF
		  _QWORD *v96; // [rsp+48h] [rbp-120h]
		  _QWORD v97[2]; // [rsp+50h] [rbp-118h] BYREF
		  Vector3 maxRenderCount; // [rsp+60h] [rbp-108h] BYREF
		  __m128i v99; // [rsp+70h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v100; // [rsp+80h] [rbp-E8h] BYREF
		  Il2CppExceptionWrapper *v101; // [rsp+88h] [rbp-E0h] BYREF
		  Il2CppExceptionWrapper *v102; // [rsp+90h] [rbp-D8h] BYREF
		  Matrix4x4 v103[2]; // [rsp+98h] [rbp-D0h] BYREF
		
		  v6 = this;
		  centerPoint.x = 0.0;
		  centerPoint.y = 0.0;
		  centerPoint.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2076, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2076, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v93, v92);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)v6,
		      (Object *)hgCamera,
		      (Object *)settingParams,
		      0LL);
		    return;
		  }
		  if ( !hgCamera )
		    sub_1800D8260(v8, v7);
		  camera = (Component *)hgCamera->fields.camera;
		  SunSourceLight = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit(SunSourceLight, 0LL) )
		  {
		    m_asmTileManager = v6->fields.m_asmTileManager;
		    if ( !m_asmTileManager )
		      sub_1800D8260(v12, v11);
		    goto LABEL_58;
		  }
		  envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		  if ( !envVolumeCameraComponent )
		    sub_1800D8260(v15, v14);
		  v16 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		          envVolumeCameraComponent,
		          (Light *)SunSourceLight,
		          0LL);
		  v17 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		  if ( !v17 )
		    sub_1800D8260(v19, v18);
		  interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v17, 0LL);
		  if ( !interpolatedPhase )
		    sub_1800D8260(v21, v20);
		  if ( !SunSourceLight )
		    sub_1800D8260(v21, v20);
		  transform = UnityEngine::Component::get_transform((Component *)SunSourceLight, 0LL);
		  v26 = transform;
		  if ( v16 )
		  {
		    v27 = _mm_loadu_si128((const __m128i *)&interpolatedPhase->fields.lightConfig.rotationDirect);
		    v28 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m00;
		    v29 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m01;
		    v30 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m02;
		    v31 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m03;
		    v32 = *(_QWORD *)&interpolatedPhase->fields.lightConfig.forwardDirect.x;
		    z_low = LODWORD(interpolatedPhase->fields.lightConfig.forwardDirect.z);
		  }
		  else
		  {
		    if ( !transform )
		      sub_1800D8260(v25, v24);
		    v27 = _mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_rotation((Quaternion *)&v99, transform, 0LL));
		    centerPoint = *UnityEngine::Vector3::get_one(&maxRenderCount, v34);
		    v99 = v27;
		    maxRenderCount = *UnityEngine::Animator::GetVector((Vector3 *)&ex, v35, v36, v37);
		    v38 = UnityEngine::Matrix4x4::TRS(v103, &maxRenderCount, (Quaternion *)&v99, &centerPoint, 0LL);
		    v28 = *(_OWORD *)&v38->m00;
		    v29 = *(_OWORD *)&v38->m01;
		    v30 = *(_OWORD *)&v38->m02;
		    v31 = *(_OWORD *)&v38->m03;
		    forward = UnityEngine::Transform::get_forward((Vector3 *)&ex, v26, 0LL);
		    v32 = *(_QWORD *)&forward->x;
		    z_low = LODWORD(forward->z);
		  }
		  *(_QWORD *)&centerPoint.x = v32;
		  v40 = _mm_cvtsi32_si128(z_low);
		  v41 = _mm_unpacklo_ps((__m128)(unsigned int)v32, (__m128)HIDWORD(v32)).m128_u64[0];
		  *(_QWORD *)&v6->fields.m_lightDir.x = v41;
		  v42 = _mm_cvtsi128_si32(v40);
		  LODWORD(v6->fields.m_lightDir.z) = v42;
		  if ( fabs(*((float *)&v32 + 1)) < 0.0099999998 )
		  {
		    m_asmTileManager = v6->fields.m_asmTileManager;
		    if ( !m_asmTileManager )
		      sub_1800D8260(v25, v24);
		LABEL_58:
		    HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(m_asmTileManager, 0LL);
		    return;
		  }
		  v6->fields.m_lightRotation = (Quaternion)v27;
		  *(_OWORD *)&v6->fields.m_lightToWorld.m00 = v28;
		  *(_OWORD *)&v6->fields.m_lightToWorld.m01 = v29;
		  *(_OWORD *)&v6->fields.m_lightToWorld.m02 = v30;
		  *(_OWORD *)&v6->fields.m_lightToWorld.m03 = v31;
		  *(_QWORD *)&centerPoint.x = *(_QWORD *)&v6->fields.m_lastLightDir.x;
		  if ( (float)((float)((float)(*(float *)v40.m128i_i32 - v6->fields.m_lastLightDir.z)
		                     * (float)(*(float *)v40.m128i_i32 - v6->fields.m_lastLightDir.z))
		             + (float)((float)((float)(*(float *)&v32 - centerPoint.x) * (float)(*(float *)&v32 - centerPoint.x))
		                     + (float)((float)(*((float *)&v32 + 1) - centerPoint.y)
		                             * (float)(*((float *)&v32 + 1) - centerPoint.y)))) < 9.9999994e-11 )
		  {
		    s_asmMaxTileRenderCountPerFrame = 1;
		  }
		  else
		  {
		    if ( !v6->fields.m_asmTileManager )
		      sub_1800D8260(v25, v24);
		    HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(v6->fields.m_asmTileManager, 0LL);
		    m_vtAllocator = v6->fields.m_vtAllocator;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    if ( !m_vtAllocator )
		      sub_1800D8260(v44, static_fields);
		    HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(
		      m_vtAllocator,
		      static_fields->s_asmTileResolution,
		      0LL);
		    *(_QWORD *)&v6->fields.m_lastLightDir.x = v41;
		    LODWORD(v6->fields.m_lastLightDir.z) = v42;
		    s_asmMaxTileRenderCountPerFrame = 1;
		    if ( v6->fields.m_asmUpdateMode <= 1u )
		      v6->fields.m_asmUpdateMode = 2;
		    if ( v6->fields.m_friendASMManager )
		    {
		      m_friendASMManager = v6->fields.m_friendASMManager;
		      if ( !m_friendASMManager->fields.m_asmTileManager )
		        sub_1800D8260(v25, v24);
		      HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(m_friendASMManager->fields.m_asmTileManager, 0LL);
		      v50 = v6->fields.m_friendASMManager;
		      if ( !v50 )
		        sub_1800D8260(v49, v48);
		      v51 = v50->fields.m_vtAllocator;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      v53 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		      if ( !v51 )
		        sub_1800D8260(v52, v53);
		      HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(v51, v53->s_asmTileResolution, 0LL);
		      v54 = v6->fields.m_friendASMManager;
		      if ( !v54 )
		        sub_1800D8260(v25, v24);
		      *(_QWORD *)&v54->fields.m_lastLightDir.x = v41;
		      LODWORD(v54->fields.m_lastLightDir.z) = v42;
		      v55 = v6->fields.m_friendASMManager;
		      if ( !v55 )
		        sub_1800D8260(v25, v24);
		      v55->fields.m_asmUpdateMode = v6->fields.m_asmUpdateMode;
		      v56 = v6->fields.m_friendASMManager;
		      y = v6->fields.m_lastPositionXZ.y;
		      if ( !v56 )
		        sub_1800D8260(v25, v24);
		      v56->fields.m_lastPositionXZ.x = v6->fields.m_lastPositionXZ.x;
		      v56->fields.m_lastPositionXZ.y = y;
		    }
		  }
		  if ( !camera )
		    sub_1800D8260(v25, v24);
		  v58 = UnityEngine::Component::get_transform(camera, 0LL);
		  if ( !v58 )
		    sub_1800D8260(v60, v59);
		  position = UnityEngine::Transform::get_position((Vector3 *)&ex, v58, 0LL);
		  v62 = *(_QWORD *)&position->x;
		  z = position->z;
		  if ( !v6->fields.m_asmUpdateMode || fabs(v6->fields.m_lightDir.y) < 0.0099999998 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v64 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    x_low = (__m128)LODWORD(v64->s_lastUpdatedPosition.x);
		    y_low = (__m128)LODWORD(v64->s_lastUpdatedPosition.y);
		    *(_QWORD *)&centerPoint.x = v62;
		    centerPoint.z = z;
		    v67 = HG::Rendering::Runtime::VectorSwizzleUtils::xz(&centerPoint, 0LL);
		    *(_QWORD *)&maxRenderCount.x = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(
		                                     _mm_unpacklo_ps(x_low, y_low).m128_u64[0],
		                                     v67);
		    v68 = sub_182FA2AF0(&maxRenderCount);
		    if ( *(float *)&v68 <= TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmUpdateAtlasDistance )
		      return;
		    v6->fields.m_asmUpdateMode = 1;
		  }
		  *(_QWORD *)&centerPoint.x = v62;
		  centerPoint.z = z;
		  HG::Rendering::Runtime::HGASMManager::UpdateFrustumVerts(v6, (Camera *)camera, &centerPoint, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		  m_asmUpdateMode = v6->fields.m_asmUpdateMode;
		  if ( m_asmUpdateMode != 1 )
		  {
		    s_asmMaxTileRenderCountPerFrame = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmMaxTileRenderCountPerFrame;
		    if ( m_asmUpdateMode == 3 )
		      s_asmMaxTileRenderCountPerFrame = 128;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		  if ( TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_forceUpdateAllTilesMode )
		    s_asmMaxTileRenderCountPerFrame = 128;
		  LODWORD(maxRenderCount.x) = s_asmMaxTileRenderCountPerFrame;
		  v97[0] = Unity::Profiling::ProfilerMarker::Auto(&v6->fields.m_samplerASMCreateTiles, v70).m_Ptr;
		  ex = 0LL;
		  v96 = v97;
		  try
		  {
		    v72 = v6->fields.m_asmTileManager;
		    m_frustumVerts = v6->fields.m_frustumVerts;
		    if ( !m_frustumVerts )
		      sub_1800D8250(0LL, v71.m_Ptr);
		    sub_1800473A0(m_frustumVerts, &centerPoint, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    if ( !v72 )
		      sub_1800D8250(v74, TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    HG::Rendering::Runtime::ASMTileManager::CreateTilesThisFrame(
		      v72,
		      *(Vector2 *)&centerPoint.x,
		      TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius,
		      TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmGridSize,
		      0LL);
		  }
		  catch ( Il2CppExceptionWrapper *v100 )
		  {
		    ex = v100->ex;
		    sub_180205890(&ex);
		    v6 = this;
		    goto LABEL_43;
		  }
		  sub_180205890(&ex);
		LABEL_43:
		  v97[0] = Unity::Profiling::ProfilerMarker::Auto(&v6->fields.m_samplerASMUpdateCachedTiles, v75).m_Ptr;
		  ex = 0LL;
		  v96 = v97;
		  try
		  {
		    v77 = v6->fields.m_asmTileManager;
		    v78 = v6->fields.m_frustumVerts;
		    if ( !v78 )
		      sub_1800D8250(0LL, v76.m_Ptr);
		    sub_1800473A0(v78, &centerPoint, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    v80 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    if ( !v77 )
		      sub_1800D8250(v79, v80);
		    HG::Rendering::Runtime::ASMTileManager::UpdateCachedTiles(
		      v77,
		      *(Vector2 *)&centerPoint.x,
		      v80->s_asmCacheRadius,
		      0LL);
		  }
		  catch ( Il2CppExceptionWrapper *v101 )
		  {
		    ex = v101->ex;
		    sub_180205890(&ex);
		    v6 = this;
		    goto LABEL_48;
		  }
		  sub_180205890(&ex);
		LABEL_48:
		  v97[0] = Unity::Profiling::ProfilerMarker::Auto(&v6->fields.m_samplerASMPreRenderTiles, v81).m_Ptr;
		  ex = 0LL;
		  v96 = v97;
		  try
		  {
		    v83 = v6->fields.m_asmTileManager;
		    v84 = v6->fields.m_vtAllocator;
		    v85 = v6->fields.m_frustumVerts;
		    if ( !v85 )
		      sub_1800D8250(0LL, v82.m_Ptr);
		    sub_1800473A0(v85, &centerPoint, 0LL);
		    if ( !v83 )
		      sub_1800D8250(v87, v86);
		    HG::Rendering::Runtime::ASMTileManager::PreRenderTiles(
		      v83,
		      v84,
		      *(Vector2 *)&centerPoint.x,
		      SLODWORD(maxRenderCount.x),
		      v6->fields.m_startVTIdx,
		      0LL);
		  }
		  catch ( Il2CppExceptionWrapper *v102 )
		  {
		    ex = v102->ex;
		    sub_180205890(&ex);
		    v6 = this;
		    goto LABEL_53;
		  }
		  sub_180205890(&ex);
		LABEL_53:
		  v89 = v6->fields.m_vtAllocator;
		  if ( !v89 )
		    sub_1800D8250(0LL, v88);
		  HG::Rendering::Runtime::HGASMVirtualTextureAllocator::VisitTilesThisFrame(
		    v89,
		    v6->fields.m_asmTileManager,
		    v6->fields.m_startVTIdx,
		    0LL);
		}
		
		internal void Render(HGRenderGraph renderGraph, ScriptableRenderContext renderContext, HGCamera hgCamera) {} // 0x0000000189D18418-0x0000000189D19670
		// Void Render(HGRenderGraph, ScriptableRenderContext, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGASMManager::Render(
		        HGASMManager *this,
		        HGRenderGraph *renderGraph,
		        ScriptableRenderContext renderContext,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGCamera *v5; // rsi
		  HGASMManager *v7; // r15
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int32_t TilesForRender; // eax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int32_t v13; // r13d
		  ASMTile *Tile; // r8
		  __m128 v15; // xmm0
		  __int128 v16; // xmm1
		  int vtIndex; // eax
		  Matrix4x4__StaticFields *static_fields; // rax
		  __m128 v19; // xmm4
		  __int64 v20; // xmm6_8
		  Vector2 v21; // r8
		  Vector2 v22; // rdx
		  int32_t v23; // r9d
		  Vector2 v24; // rax
		  __m128 v25; // xmm4
		  __m128 v26; // xmm5
		  Vector2 v27; // xmm15_8
		  Vector2 v28; // r8
		  Vector2 v29; // rdx
		  int32_t v30; // r9d
		  Vector2 v31; // rax
		  __m128 v32; // xmm4
		  __m128 v33; // xmm5
		  Vector2 v34; // r8
		  Vector2 v35; // r9
		  Vector2 v36; // xmm14_8
		  __int64 v37; // xmm13_8
		  float z; // ebx
		  __m128i v39; // xmm11
		  __int128 v40; // xmm6
		  __int128 v41; // xmm7
		  __int128 v42; // xmm8
		  __int128 v43; // xmm9
		  float m_asmCasterMinY; // xmm12_4
		  float m_asmCasterMaxY; // xmm10_4
		  __int128 v46; // xmm6
		  __int128 v47; // xmm11
		  __int128 v48; // xmm12
		  __int128 v49; // xmm13
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  HGASMVirtualTextureAllocator_ASMVTData *VTData; // rax
		  Matrix4x4__Array *m_worldToShadowMatrices; // rbx
		  __int128 v55; // xmm7
		  __int128 v56; // xmm8
		  __int128 v57; // xmm9
		  __int128 v58; // xmm10
		  Matrix4x4 *ShadowTransform; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  __int128 v62; // xmm14
		  __int128 v63; // xmm15
		  __int128 v64; // xmm0
		  __int128 v65; // xmm1
		  RendererList nullRendererList; // xmm15
		  Matrix4x4 *v67; // rax
		  __int128 v68; // xmm11
		  __int128 v69; // xmm12
		  __int128 v70; // xmm13
		  __int128 v71; // xmm14
		  HGASMManager__StaticFields *v72; // rdx
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  int32_t v75; // ebx
		  __int64 v76; // r12
		  __int64 v77; // rdx
		  __int64 v78; // r9
		  HGASMManager__StaticFields *v79; // rcx
		  CullingResults v80; // xmm6
		  __int64 v81; // rbx
		  Void *m_Buffer; // r12
		  __int64 v83; // r15
		  __int64 v84; // rdx
		  __int64 v85; // r9
		  HGASMManager__StaticFields *v86; // rcx
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  Camera *camera; // rbx
		  uint64_t SceneCullingMaskFromCamera; // rbx
		  HGASMManager__StaticFields *v91; // rcx
		  uint32_t s_asmManagerCullingMask; // r9d
		  float s_asmScreenSizeMinSquared; // xmm1_4
		  ProfilingSampler *v94; // rax
		  __int64 v95; // rdx
		  __int64 v96; // rcx
		  TextureHandle *v97; // rbx
		  __int64 v98; // rdx
		  __int64 v99; // rcx
		  TextureHandle v100; // xmm0
		  __int64 v101; // rbx
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  unsigned __int64 v103; // rdx
		  __int64 v104; // rcx
		  __int64 v105; // rcx
		  unsigned __int64 v106; // r8
		  signed __int64 v107; // rtt
		  _OWORD *v108; // rax
		  _OWORD *v109; // rax
		  _OWORD *v110; // rax
		  __int64 v111; // rdx
		  unsigned int v112; // edx
		  unsigned __int64 v113; // r8
		  char v114; // dl
		  signed __int64 v115; // rtt
		  __int64 v116; // rbx
		  unsigned __int64 v117; // rdx
		  signed __int64 v118; // rcx
		  unsigned __int64 v119; // r8
		  signed __int64 v120; // rtt
		  __int64 v121; // rcx
		  __int64 v122; // rcx
		  __int64 v123; // rcx
		  Transform *transform; // rax
		  __int64 v125; // rdx
		  __int64 v126; // rcx
		  Vector2 v127; // xmm6_8
		  __int64 v128; // rdx
		  double v129; // xmm0_8
		  HGASMManager__StaticFields *v130; // rcx
		  Transform *v131; // rax
		  __int64 v132; // rdx
		  __int64 v133; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v135; // rdx
		  __int64 v136; // rcx
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-C08h]
		  __int64 v138; // [rsp+60h] [rbp-BC8h] BYREF
		  unsigned int RendererList; // [rsp+68h] [rbp-BC0h]
		  __int64 v140; // [rsp+70h] [rbp-BB8h] BYREF
		  ShaderTagId v141; // [rsp+78h] [rbp-BB0h] BYREF
		  int32_t v142; // [rsp+7Ch] [rbp-BACh]
		  Vector3 v143; // [rsp+80h] [rbp-BA8h] BYREF
		  Matrix4x4 v144; // [rsp+90h] [rbp-B98h] BYREF
		  uint32_t v145; // [rsp+D0h] [rbp-B58h]
		  __int128 v146; // [rsp+D8h] [rbp-B50h]
		  Matrix4x4 v147; // [rsp+F0h] [rbp-B38h] BYREF
		  _QWORD v148[2]; // [rsp+130h] [rbp-AF8h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v149; // [rsp+140h] [rbp-AE8h] BYREF
		  HGRenderGraphBuilder v150; // [rsp+150h] [rbp-AD8h] BYREF
		  NativeArray_1_System_Int32_ tilesForRenderThisFrame; // [rsp+170h] [rbp-AB8h] BYREF
		  LODCrossFadeConfig lodCrossFadeConfig; // [rsp+180h] [rbp-AA8h] BYREF
		  Matrix4x4 v153; // [rsp+1C0h] [rbp-A68h] BYREF
		  Matrix4x4 identityMatrix; // [rsp+200h] [rbp-A28h] BYREF
		  _BYTE v155[20]; // [rsp+250h] [rbp-9D8h]
		  __int128 v156; // [rsp+268h] [rbp-9C0h]
		  Il2CppExceptionWrapper *v157; // [rsp+278h] [rbp-9B0h] BYREF
		  __int128 v158; // [rsp+280h] [rbp-9A8h] BYREF
		  __int128 v159; // [rsp+290h] [rbp-998h] BYREF
		  __int128 v160; // [rsp+2A0h] [rbp-988h]
		  __int128 v161; // [rsp+2B0h] [rbp-978h]
		  __int128 v162; // [rsp+2C0h] [rbp-968h]
		  TextureHandle v163; // [rsp+2D0h] [rbp-958h] BYREF
		  TextureHandle v164; // [rsp+2E0h] [rbp-948h] BYREF
		  CullingResults v165; // [rsp+2F0h] [rbp-938h] BYREF
		  RendererList v166; // [rsp+300h] [rbp-928h] BYREF
		  Matrix4x4 v167; // [rsp+310h] [rbp-918h] BYREF
		  RendererListDesc v168; // [rsp+350h] [rbp-8D8h] BYREF
		  RendererListDesc v169; // [rsp+430h] [rbp-7F8h] BYREF
		  ScriptableCullingParameters cullingParameters; // [rsp+510h] [rbp-718h] BYREF
		  ScriptableRenderContext P2; // [rsp+C40h] [rbp+18h] BYREF
		  HGCamera *v174; // [rsp+C48h] [rbp+20h]
		
		  v174 = hgCamera;
		  P2.m_Ptr = renderContext.m_Ptr;
		  v5 = hgCamera;
		  v7 = this;
		  tilesForRenderThisFrame = 0LL;
		  v149 = 0LL;
		  memset(&lodCrossFadeConfig, 0, sizeof(lodCrossFadeConfig));
		  sub_18033B9D0(&cullingParameters, 0LL, 1592LL);
		  v141.m_Id = 0;
		  sub_18033B9D0(&v168, 0LL, 224LL);
		  memset(&v150, 0, sizeof(v150));
		  v138 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2078, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2078, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v136, v135);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_236(Patch, (Object *)v7, (Object *)renderGraph, P2, (Object *)v5, 0LL);
		  }
		  else
		  {
		    v7->fields.shouldSwapManagers = 0;
		    if ( v7->fields.m_asmUpdateMode )
		    {
		      if ( !v7->fields.m_asmTileManager )
		        sub_1800D8260(v9, v8);
		      TilesForRender = HG::Rendering::Runtime::ASMTileManager::GetTilesForRender(
		                         v7->fields.m_asmTileManager,
		                         &tilesForRenderThisFrame,
		                         0LL);
		      LODWORD(v140) = TilesForRender;
		      if ( TilesForRender )
		      {
		        v13 = 0;
		        v142 = 0;
		        while ( v13 < TilesForRender )
		        {
		          if ( !v7->fields.m_asmTileManager )
		            sub_1800D8260(v13, v11);
		          Tile = HG::Rendering::Runtime::ASMTileManager::GetTile(
		                   (ASMTile *)&v147,
		                   v7->fields.m_asmTileManager,
		                   *(_DWORD *)&tilesForRenderThisFrame.m_Buffer[4 * v13],
		                   0LL);
		          v15 = *(__m128 *)&Tile->mins.x;
		          *(__m128 *)&v144.m00 = v15;
		          v16 = *(_OWORD *)&Tile->tileCoords.m_X;
		          *(_OWORD *)&v144.m01 = v16;
		          vtIndex = Tile->vtIndex;
		          RendererList = vtIndex;
		          *(__m128 *)&v144.m00 = v15;
		          *(_OWORD *)&v144.m01 = v16;
		          if ( vtIndex >= 0 )
		          {
		            *(__m128 *)&v144.m00 = v15;
		            *(_OWORD *)&v144.m01 = v16;
		            if ( vtIndex < 256 )
		            {
		              static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		              identityMatrix = static_fields->identityMatrix;
		              v153 = static_fields->identityMatrix;
		              v19 = *(__m128 *)&Tile->mins.x;
		              *(_OWORD *)&v144.m01 = *(_OWORD *)&Tile->tileCoords.m_X;
		              LODWORD(v144.m02) = Tile->vtIndex;
		              v20 = sub_1858CAD18(
		                      _mm_unpacklo_ps(_mm_shuffle_ps(v19, v19, 170), _mm_shuffle_ps(v19, v19, 255)).m128_u64[0],
		                      _mm_unpacklo_ps(
		                        *(__m128 *)&Tile->mins.x,
		                        _mm_shuffle_ps(*(__m128 *)&Tile->mins.x, *(__m128 *)&Tile->mins.x, 85)).m128_u64[0]);
		              *(_OWORD *)&v144.m01 = *(_OWORD *)(*(_QWORD *)&v21 + 16LL);
		              v144.m02 = *(float *)(*(_QWORD *)&v21 + 32LL);
		              v24 = sub_1858CACF0(v20, v22, v21, v23);
		              v27 = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(
		                               _mm_unpacklo_ps(v26, v25).m128_u64[0],
		                               v24);
		              *(_OWORD *)&v144.m01 = *(_OWORD *)(*(_QWORD *)&v28 + 16LL);
		              v144.m02 = *(float *)(*(_QWORD *)&v28 + 32LL);
		              v31 = sub_1858CACF0(v20, v29, v28, v30);
		              v36 = sub_1853DF234((Vector2)*(_OWORD *)&_mm_unpacklo_ps(v32, v33), v31, v34, v35);
		              v37 = *(_QWORD *)&v7->fields.m_lightDir.x;
		              z = v7->fields.m_lightDir.z;
		              v39 = _mm_loadu_si128((const __m128i *)&v7->fields.m_lightRotation);
		              v40 = *(_OWORD *)&v7->fields.m_lightToWorld.m00;
		              v41 = *(_OWORD *)&v7->fields.m_lightToWorld.m01;
		              v42 = *(_OWORD *)&v7->fields.m_lightToWorld.m02;
		              v43 = *(_OWORD *)&v7->fields.m_lightToWorld.m03;
		              m_asmCasterMinY = v7->fields.m_asmCasterMinY;
		              m_asmCasterMaxY = v7->fields.m_asmCasterMaxY;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		              *(_OWORD *)&v147.m00 = v40;
		              *(_OWORD *)&v147.m01 = v41;
		              *(_OWORD *)&v147.m02 = v42;
		              *(_OWORD *)&v147.m03 = v43;
		              *(__m128i *)&v144.m00 = v39;
		              *(_QWORD *)&v143.x = v37;
		              v143.z = z;
		              HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
		                v27,
		                v36,
		                &v143,
		                (Quaternion *)&v144,
		                &v147,
		                0.1,
		                1000.0,
		                m_asmCasterMinY,
		                m_asmCasterMaxY,
		                &identityMatrix,
		                &v153,
		                0LL);
		              v46 = *(_OWORD *)&v153.m00;
		              v147 = v153;
		              v47 = *(_OWORD *)&v153.m01;
		              v48 = *(_OWORD *)&v153.m02;
		              v49 = *(_OWORD *)&v153.m03;
		              GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v144, &v147, 1, 0LL);
		              v160 = *(_OWORD *)&GPUProjectionMatrix->m00;
		              v161 = *(_OWORD *)&GPUProjectionMatrix->m01;
		              v162 = *(_OWORD *)&GPUProjectionMatrix->m02;
		              v156 = *(_OWORD *)&GPUProjectionMatrix->m03;
		              if ( !v7->fields.m_vtAllocator )
		                sub_1800D8260(v52, v51);
		              VTData = HG::Rendering::Runtime::HGASMVirtualTextureAllocator::GetVTData(
		                         (HGASMVirtualTextureAllocator_ASMVTData *)&v147,
		                         v7->fields.m_vtAllocator,
		                         RendererList,
		                         0LL);
		              *(_OWORD *)v155 = *(_OWORD *)&VTData->uvMaxs.y;
		              *(_DWORD *)&v155[16] = VTData->pixelMaxs.m_Y;
		              m_worldToShadowMatrices = v7->fields.m_worldToShadowMatrices;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		              v55 = *(_OWORD *)&identityMatrix.m00;
		              v147 = identityMatrix;
		              v56 = *(_OWORD *)&identityMatrix.m01;
		              v57 = *(_OWORD *)&identityMatrix.m02;
		              v58 = *(_OWORD *)&identityMatrix.m03;
		              *(_OWORD *)&v144.m00 = v46;
		              *(_OWORD *)&v144.m01 = v47;
		              *(_OWORD *)&v144.m02 = v48;
		              *(_OWORD *)&v144.m03 = v49;
		              ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v167, &v144, &v147, 0LL);
		              v62 = *(_OWORD *)&ShadowTransform->m00;
		              v63 = *(_OWORD *)&ShadowTransform->m01;
		              v64 = *(_OWORD *)&ShadowTransform->m02;
		              *(_OWORD *)&v144.m00 = v64;
		              v65 = *(_OWORD *)&ShadowTransform->m03;
		              v146 = v65;
		              if ( !m_worldToShadowMatrices )
		                sub_1800D8260(v61, v60);
		              *(_OWORD *)&v147.m00 = v62;
		              *(_OWORD *)&v147.m01 = v63;
		              *(_OWORD *)&v147.m02 = v64;
		              *(_OWORD *)&v147.m03 = v65;
		              sub_180041540(m_worldToShadowMatrices, (int)RendererList, &v147);
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		              nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList->static_fields->nullRendererList;
		              *(_OWORD *)&v147.m00 = v55;
		              *(_OWORD *)&v147.m01 = v56;
		              *(_OWORD *)&v147.m02 = v57;
		              *(_OWORD *)&v147.m03 = v58;
		              *(_OWORD *)&v144.m00 = v46;
		              *(_OWORD *)&v144.m01 = v47;
		              *(_OWORD *)&v144.m02 = v48;
		              *(_OWORD *)&v144.m03 = v49;
		              v67 = UnityEngine::Matrix4x4::op_Multiply(&v167, &v144, &v147, 0LL);
		              v68 = *(_OWORD *)&v67->m00;
		              v69 = *(_OWORD *)&v67->m01;
		              v70 = *(_OWORD *)&v67->m02;
		              v71 = *(_OWORD *)&v67->m03;
		              v72 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		              *(_OWORD *)&v147.m00 = *(_OWORD *)&v67->m00;
		              *(_OWORD *)&v147.m01 = v69;
		              *(_OWORD *)&v147.m02 = v70;
		              *(_OWORD *)&v147.m03 = v71;
		              UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v147, v72->s_tempPlanes, 0LL);
		              if ( !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
		              {
		                if ( !v5 )
		                  sub_1800D8260(v74, v73);
		                if ( !v5->fields.camera )
		                  sub_1800D8260(v74, v73);
		                UnityEngine::Camera::TryGetCullingParameters(v5->fields.camera, &cullingParameters, 0LL);
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		                *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v68;
		                *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v69;
		                *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v70;
		                *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v71;
		                UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 1, 0LL);
		                cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
		                v75 = 0;
		                v76 = 0LL;
		                do
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		                  v79 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		                  if ( !v79->s_tempPlanes )
		                    sub_1800D8260(v79, v77);
		                  sub_180002990(v79->s_tempPlanes, &v158, v76, v78);
		                  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		                  *(_OWORD *)&v144.m00 = v158;
		                  UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
		                    &cullingParameters,
		                    v75++,
		                    (Plane *)&v144,
		                    0LL);
		                  ++v76;
		                }
		                while ( v75 < 6 );
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                v80 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(&v165, &P2, &cullingParameters, 0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		                UnityEngine::Rendering::ShaderTagId::ShaderTagId(
		                  &v141,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		                  0LL);
		                *(CullingResults *)&v144.m00 = v80;
		                UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
		                  &v168,
		                  v141,
		                  (CullingResults *)&v144,
		                  v5->fields.camera,
		                  0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		                v168.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque;
		                v168.sortingCriteria = 59;
		                v168.rendererConfiguration = 6144;
		                v169 = v168;
		                nullRendererList = *UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
		                                      &v166,
		                                      &P2,
		                                      &v169,
		                                      0LL);
		              }
		              Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		                &v149,
		                6,
		                Allocator__Enum_Temp,
		                NativeArrayOptions__Enum_ClearMemory,
		                MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		              v81 = 0LL;
		              m_Buffer = v149.m_Buffer;
		              v83 = 6LL;
		              do
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		                v86 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		                if ( !v86->s_tempPlanes )
		                  sub_1800D8260(v86, v84);
		                sub_180002990(v86->s_tempPlanes, &v159, v81, v85);
		                *(_OWORD *)m_Buffer = v159;
		                ++v81;
		                m_Buffer += 16;
		                --v83;
		              }
		              while ( v83 );
		              v7 = this;
		              if ( !v5 )
		                sub_1800D8260(v88, v87);
		              lodCrossFadeConfig = v5->fields.lodCrossFadeConfig;
		              lodCrossFadeConfig.enableDither = 0;
		              camera = v5->fields.camera;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(camera, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		              v91 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		              s_asmManagerCullingMask = v91->s_asmManagerCullingMask;
		              s_asmScreenSizeMinSquared = v91->s_asmScreenSizeMinSquared;
		              *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v144.m00 = v149;
		              LODWORD(SceneCullingMaskFromCamera) = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
		                                                      (NativeArray_1_UnityEngine_Plane_ *)&v144,
		                                                      0,
		                                                      SceneCullingMaskFromCamera,
		                                                      s_asmManagerCullingMask,
		                                                      0x4000002u,
		                                                      0x4000002u,
		                                                      &lodCrossFadeConfig,
		                                                      s_asmScreenSizeMinSquared,
		                                                      CameraType__Enum_Shadow,
		                                                      0LL);
		              UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		              LOWORD(globalKeywords) = 0;
		              RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                               SceneCullingMaskFromCamera,
		                               HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
		                               HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
		                               HGShaderLightMode__Enum_ShadowCaster,
		                               globalKeywords,
		                               P2.m_Ptr,
		                               0,
		                               0,
		                               0xFFFFFFFF,
		                               0,
		                               0,
		                               0LL);
		              v145 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                       SceneCullingMaskFromCamera,
		                       HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
		                       HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
		                       HGShaderLightMode__Enum_ShadowCaster,
		                       P2.m_Ptr,
		                       0,
		                       0LL);
		              LODWORD(v146) = UnityEngine::HyperGryph::HGTreeRender::CreateRendererList(
		                                SceneCullingMaskFromCamera,
		                                HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
		                                HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
		                                HGShaderLightMode__Enum_ShadowCaster,
		                                P2.m_Ptr,
		                                0,
		                                0LL);
		              v94 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                      (Int32Enum__Enum)0x80u,
		                      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		              if ( !renderGraph )
		                sub_1800D8260(v96, v95);
		              v150 = *(HGRenderGraphBuilder *)sub_1808B59DC(
		                                                (unsigned int)&v144,
		                                                (_DWORD)renderGraph,
		                                                (unsigned int)"Render ASM Shadow Map",
		                                                (unsigned int)&v138,
		                                                (__int64)v94,
		                                                1,
		                                                3);
		              v148[0] = 0LL;
		              v148[1] = &v150;
		              try
		              {
		                v97 = (TextureHandle *)v138;
		                v100 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                          &v163,
		                          renderGraph,
		                          this->fields.m_asmShadowMapRT,
		                          0LL);
		                if ( !v97 )
		                  sub_1800D8250(v99, v98);
		                v97[2] = v100;
		                v101 = v138;
		                defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(
		                                     renderGraph,
		                                     0LL);
		                if ( !v101 )
		                  sub_1800D8250(v104, v103);
		                *(_QWORD *)(v101 + 24) = defaultResources;
		                v105 = (unsigned int)dword_18F35FD08;
		                if ( dword_18F35FD08 )
		                {
		                  v106 = (((unsigned __int64)(v101 + 24) >> 12) & 0x1FFFFF) >> 6;
		                  v103 = ((unsigned __int64)(v101 + 24) >> 12) & 0x3F;
		                  _m_prefetchw(&qword_18F0BCBA0[v106 + 36190]);
		                  do
		                    v107 = qword_18F0BCBA0[v106 + 36190];
		                  while ( v107 != _InterlockedCompareExchange64(
		                                    &qword_18F0BCBA0[v106 + 36190],
		                                    v107 | (1LL << v103),
		                                    v107) );
		                  v105 = (unsigned int)dword_18F35FD08;
		                }
		                v108 = (_OWORD *)v138;
		                if ( !v138 )
		                  sub_1800D8250(v105, v103);
		                *(_OWORD *)(v138 + 48) = v160;
		                v108[4] = v161;
		                v108[5] = v162;
		                v108[6] = v156;
		                v109 = (_OWORD *)v138;
		                if ( !v138 )
		                  sub_1800D8250(v105, v103);
		                *(_OWORD *)(v138 + 112) = v55;
		                v109[8] = v56;
		                v109[9] = v57;
		                v109[10] = v58;
		                v110 = (_OWORD *)v138;
		                if ( !v138 )
		                  sub_1800D8250(v105, v103);
		                *(_OWORD *)(v138 + 176) = v68;
		                v110[12] = v69;
		                v110[13] = v70;
		                v110[14] = v71;
		                if ( !v138 )
		                  sub_1800D8250(v105, 0LL);
		                *(_QWORD *)(v138 + 240) = *(_QWORD *)&v155[4];
		                if ( !v138 )
		                  sub_1800D8250(v105, 0LL);
		                *(_QWORD *)(v138 + 248) = *(_QWORD *)&v155[12];
		                v111 = v138;
		                if ( !v138 )
		                  sub_1800D8250(v105, 0LL);
		                *(_QWORD *)(v138 + 16) = v5;
		                if ( (_DWORD)v105 )
		                {
		                  v112 = ((unsigned __int64)(v111 + 16) >> 12) & 0x1FFFFF;
		                  v113 = (unsigned __int64)v112 >> 6;
		                  v114 = v112 & 0x3F;
		                  _m_prefetchw(&qword_18F0BCBA0[v113 + 36190]);
		                  do
		                    v115 = qword_18F0BCBA0[v113 + 36190];
		                  while ( v115 != _InterlockedCompareExchange64(
		                                    &qword_18F0BCBA0[v113 + 36190],
		                                    v115 | (1LL << v114),
		                                    v115) );
		                }
		                v116 = v138;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		                v118 = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		                if ( !v116 )
		                  sub_1800D8250(v118, v117);
		                *(_QWORD *)(v116 + 256) = *(_QWORD *)(v118 + 56);
		                if ( dword_18F35FD08 )
		                {
		                  v119 = (((unsigned __int64)(v116 + 256) >> 12) & 0x1FFFFF) >> 6;
		                  v117 = ((unsigned __int64)(v116 + 256) >> 12) & 0x3F;
		                  _m_prefetchw(&qword_18F0BCBA0[v119 + 36190]);
		                  do
		                  {
		                    v118 = qword_18F0BCBA0[v119 + 36190] | (1LL << v117);
		                    v120 = qword_18F0BCBA0[v119 + 36190];
		                  }
		                  while ( v120 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v119 + 36190], v118, v120) );
		                }
		                if ( !v138 )
		                  sub_1800D8250(v118, v117);
		                *(RendererList *)(v138 + 264) = nullRendererList;
		                if ( !v138 )
		                  sub_1800D8250(v118, v117);
		                v121 = RendererList;
		                *(_DWORD *)(v138 + 280) = RendererList;
		                if ( !v138 )
		                  sub_1800D8250(v121, v117);
		                v122 = v145;
		                *(_DWORD *)(v138 + 284) = v145;
		                if ( !v138 )
		                  sub_1800D8250(v122, v117);
		                v123 = (unsigned int)v146;
		                *(_DWORD *)(v138 + 288) = v146;
		                if ( !v138 )
		                  sub_1800D8250(v123, v117);
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                  &v164,
		                  &v150,
		                  (TextureHandle *)(v138 + 32),
		                  DepthAccess__Enum_Write,
		                  RenderBufferLoadAction__Enum_Load,
		                  RenderBufferStoreAction__Enum_Store,
		                  0.0,
		                  0,
		                  0,
		                  0LL);
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v150, 0, 0LL);
		                HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                  &v150,
		                  (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_renderASMShadowPass,
		                  0LL,
		                  0,
		                  MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
		              }
		              catch ( Il2CppExceptionWrapper *v157 )
		              {
		                v148[0] = v157->ex;
		                sub_180268AE0(v148);
		                v5 = v174;
		                v7 = this;
		                v13 = v142;
		                goto LABEL_51;
		              }
		              sub_180268AE0(v148);
		            }
		          }
		LABEL_51:
		          v142 = ++v13;
		          TilesForRender = v140;
		        }
		      }
		      else
		      {
		        if ( !v5 )
		          sub_1800D8260(v12, v11);
		        if ( !v5->fields.camera )
		          sub_1800D8260(v12, v11);
		        transform = UnityEngine::Component::get_transform((Component *)v5->fields.camera, 0LL);
		        if ( !transform )
		          sub_1800D8260(v126, v125);
		        v143 = *UnityEngine::Transform::get_position((Vector3 *)&v144, transform, 0LL);
		        v127 = HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v143, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		        v140 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(
		                 v127,
		                 _mm_unpacklo_ps(
		                   (__m128)LODWORD(TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_lastUpdatedPosition.x),
		                   (__m128)LODWORD(TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_lastUpdatedPosition.y)).m128_u64[0]);
		        v129 = sub_182FA2AF0(&v140);
		        v130 = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		        if ( v130->s_asmUpdateAtlasDistance > *(float *)&v129 )
		          v7->fields.m_asmUpdateMode = 0;
		        if ( !v5->fields.camera )
		          sub_1800D8260(v130, v128);
		        v131 = UnityEngine::Component::get_transform((Component *)v5->fields.camera, 0LL);
		        if ( !v131 )
		          sub_1800D8260(v133, v132);
		        v143 = *UnityEngine::Transform::get_position((Vector3 *)&v144, v131, 0LL);
		        v140 = (__int64)HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v143, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		        TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_lastUpdatedPosition = (Vector2)v140;
		        v7->fields.shouldSwapManagers = 1;
		      }
		    }
		  }
		}
		
		internal void SetCachedData(HGRenderGraph renderGraph) {} // 0x0000000189D196CC-0x0000000189D19E3C
		// Void SetCachedData(HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGASMManager::SetCachedData(
		        HGASMManager *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ASMTileManager *m_asmTileManager; // rbx
		  __int64 v6; // rdx
		  HGASMManager__StaticFields *static_fields; // rax
		  float v8; // xmm6_4
		  float v9; // xmm7_4
		  float v10; // xmm1_4
		  Vector2 v11; // xmm15_8
		  Vector2 v12; // xmm14_8
		  __int64 v13; // xmm13_8
		  float z; // ebx
		  __m128i v15; // xmm11
		  __int128 v16; // xmm6
		  __int128 v17; // xmm7
		  __int128 v18; // xmm8
		  __int128 v19; // xmm9
		  float m_asmCasterMinY; // xmm12_4
		  float m_asmCasterMaxY; // xmm10_4
		  Matrix4x4 *ShadowTransform; // rax
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm2
		  __int128 v26; // xmm3
		  Matrix4x4__StaticFields *v27; // rcx
		  HGShadowConstantBufferUtils__StaticFields *v28; // rcx
		  __int128 v29; // xmm1
		  __int128 v30; // xmm2
		  __int128 v31; // xmm3
		  HGShadowConstantBufferUtils__StaticFields *v32; // rcx
		  ProfilingSampler *v33; // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  TextureHandle *v36; // rbx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  TextureHandle v39; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  __int128 v43; // [rsp+70h] [rbp-248h] BYREF
		  int32_t indirectHeight; // [rsp+80h] [rbp-238h] BYREF
		  float v45; // [rsp+84h] [rbp-234h]
		  float v46; // [rsp+88h] [rbp-230h]
		  __int64 v47; // [rsp+8Ch] [rbp-22Ch]
		  Vector2 indexRegionMins; // [rsp+98h] [rbp-220h] BYREF
		  Vector2 indexRegionMaxs; // [rsp+A0h] [rbp-218h] BYREF
		  TextureHandle *v50; // [rsp+A8h] [rbp-210h] BYREF
		  HGRenderGraphBuilder v51; // [rsp+B0h] [rbp-208h] BYREF
		  Matrix4x4 v52; // [rsp+D0h] [rbp-1E8h] BYREF
		  Matrix4x4 v53; // [rsp+110h] [rbp-1A8h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+150h] [rbp-168h] BYREF
		  Quaternion v55[2]; // [rsp+160h] [rbp-158h] BYREF
		  Matrix4x4 v56; // [rsp+180h] [rbp-138h] BYREF
		  Matrix4x4 baseWorldToShadowMatrix; // [rsp+1C0h] [rbp-F8h] BYREF
		  int32_t indirectWidth; // [rsp+2D8h] [rbp+20h] BYREF
		
		  indexRegionMins = 0LL;
		  indexRegionMaxs = 0LL;
		  indirectWidth = 0;
		  indirectHeight = 0;
		  sub_18033B9D0(&baseWorldToShadowMatrix, 0LL, 64LL);
		  sub_18033B9D0(&v56, 0LL, 64LL);
		  sub_18033B9D0(&v52, 0LL, 64LL);
		  memset(&v51, 0, sizeof(v51));
		  v50 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2080, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2080, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v42, v41);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    m_asmTileManager = this->fields.m_asmTileManager;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		    if ( !m_asmTileManager )
		      sub_1800D8260(TypeInfo::HG::Rendering::Runtime::HGASMManager, v6);
		    HG::Rendering::Runtime::ASMTileManager::GenerateIndirectData(
		      m_asmTileManager,
		      TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmGridSize,
		      this->fields.m_startVTIdx,
		      16,
		      16,
		      TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_asmCacheRadius,
		      &this->fields.m_worldToShadowMatrices,
		      &baseWorldToShadowMatrix,
		      &indexRegionMins,
		      &indexRegionMaxs,
		      &indirectWidth,
		      &indirectHeight,
		      0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields;
		    v8 = (float)(16 * static_fields->s_asmTileResolution);
		    v45 = v8;
		    v9 = (float)(16 * static_fields->s_asmTileResolution);
		    v46 = v9;
		    v10 = (float)(static_fields->s_asmGridSize + static_fields->s_asmGridSize)
		        / (float)static_fields->s_asmTileResolution;
		    *(float *)&v47 = (float)(static_fields->s_asmDepthBias * v10) * 1.5;
		    *((float *)&v47 + 1) = (float)(static_fields->s_asmNormalBias * v10) * 1.5;
		    if ( fabs(this->fields.m_lightDir.y) < 0.0099999998 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      v27 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		      v23 = *(_OWORD *)&v27->identityMatrix.m00;
		      v24 = *(_OWORD *)&v27->identityMatrix.m01;
		      v25 = *(_OWORD *)&v27->identityMatrix.m02;
		      v26 = *(_OWORD *)&v27->identityMatrix.m03;
		    }
		    else
		    {
		      v11 = indexRegionMins;
		      v12 = indexRegionMaxs;
		      v13 = *(_QWORD *)&this->fields.m_lightDir.x;
		      z = this->fields.m_lightDir.z;
		      v15 = _mm_loadu_si128((const __m128i *)&this->fields.m_lightRotation);
		      v16 = *(_OWORD *)&this->fields.m_lightToWorld.m00;
		      v17 = *(_OWORD *)&this->fields.m_lightToWorld.m01;
		      v18 = *(_OWORD *)&this->fields.m_lightToWorld.m02;
		      v19 = *(_OWORD *)&this->fields.m_lightToWorld.m03;
		      m_asmCasterMinY = this->fields.m_asmCasterMinY;
		      m_asmCasterMaxY = this->fields.m_asmCasterMaxY;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      *(_OWORD *)&v53.m00 = v16;
		      *(_OWORD *)&v53.m01 = v17;
		      *(_OWORD *)&v53.m02 = v18;
		      *(_OWORD *)&v53.m03 = v19;
		      v55[0] = (Quaternion)v15;
		      *(_QWORD *)&v43 = v13;
		      *((float *)&v43 + 2) = z;
		      HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
		        v11,
		        v12,
		        (Vector3 *)&v43,
		        v55,
		        &v53,
		        0.1,
		        1000.0,
		        m_asmCasterMinY,
		        m_asmCasterMaxY,
		        &v52,
		        &v56,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		      v53 = v52;
		      v52 = v56;
		      ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v56, &v52, &v53, 0LL);
		      v23 = *(_OWORD *)&ShadowTransform->m00;
		      v24 = *(_OWORD *)&ShadowTransform->m01;
		      v25 = *(_OWORD *)&ShadowTransform->m02;
		      v26 = *(_OWORD *)&ShadowTransform->m03;
		      v8 = v45;
		      v9 = v46;
		    }
		    v28 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		    *(_OWORD *)&v28[22].shadowData._ASMIndirectWorldToShadow.m23 = v23;
		    *(_OWORD *)&v28[22].shadowData._ASMParams.z = v24;
		    *(_OWORD *)&v28[22].shadowData._ASMParams2.z = v25;
		    *(_OWORD *)&v28[22].shadowData._ASMShadowTexelSize.z = v26;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v29 = *(_OWORD *)&baseWorldToShadowMatrix.m01;
		    v30 = *(_OWORD *)&baseWorldToShadowMatrix.m02;
		    v31 = *(_OWORD *)&baseWorldToShadowMatrix.m03;
		    v32 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		    *(_OWORD *)&v32[22].shadowData._ASMWorldToShadowBaseMatrix.m23 = *(_OWORD *)&baseWorldToShadowMatrix.m00;
		    *(_OWORD *)&v32[22].shadowData._ASMIndirectWorldToShadow.m20 = v29;
		    *(_OWORD *)&v32[22].shadowData._ASMIndirectWorldToShadow.m21 = v30;
		    *(_OWORD *)&v32[22].shadowData._ASMIndirectWorldToShadow.m22 = v31;
		    *(_QWORD *)&v43 = v47;
		    *((_QWORD *)&v43 + 1) = 0x3D8000003D800000LL;
		    *(_OWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[22].s_shadowBufferHandle.bufferId = v43;
		    *(float *)&v43 = (float)this->fields.m_startVTIdx;
		    *((float *)&v43 + 1) = (float)indirectWidth;
		    *((_QWORD *)&v43 + 1) = COERCE_UNSIGNED_INT((float)indirectHeight);
		    *(_OWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[22].s_shadowBufferHandle.ptr = v43;
		    *(float *)&v43 = 1.0 / v8;
		    *((float *)&v43 + 1) = 1.0 / v9;
		    *((_QWORD *)&v43 + 1) = __PAIR64__(LODWORD(v9), LODWORD(v8));
		    *(_OWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[22]._CharacterShadowSectionOffset = v43;
		    v33 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x80u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v35, v34);
		    v51 = *(HGRenderGraphBuilder *)sub_1808B59DC(
		                                     (unsigned int)v55,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"Set Cached ASM Shadow Map Data",
		                                     (unsigned int)&v50,
		                                     (__int64)v33,
		                                     1,
		                                     0);
		    *(_QWORD *)&v43 = 0LL;
		    *((_QWORD *)&v43 + 1) = &v51;
		    try
		    {
		      v36 = v50;
		      v39 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               (TextureHandle *)v55,
		               renderGraph,
		               this->fields.m_asmShadowMapRT,
		               0LL);
		      if ( !v36 )
		        sub_1800D8250(v38, v37);
		      v36[2] = v39;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v51, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v51,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_setASMShadowDataPass,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v54 )
		    {
		      *(Il2CppExceptionWrapper *)&v43 = (Il2CppExceptionWrapper)v54->ex;
		    }
		    sub_180268AE0(&v43);
		  }
		}
		
		internal void SkipRenderASM(HGRenderGraph renderGraph) {} // 0x0000000189D19E98-0x0000000189D1A090
		// Void SkipRenderASM(HGRenderGraph)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGASMManager::SkipRenderASM(
		        HGASMManager *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ProfilingSampler *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdi
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  unsigned __int64 v12; // r8
		  signed __int64 v13; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Il2CppExceptionWrapper *v17; // [rsp+48h] [rbp-50h] BYREF
		  _QWORD v18[4]; // [rsp+50h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v19; // [rsp+70h] [rbp-28h] BYREF
		  __int64 v20; // [rsp+B8h] [rbp+20h] BYREF
		
		  memset(&v19, 0, sizeof(v19));
		  v20 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2081, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2081, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    v5 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x80u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v7, v6);
		    v19 = *(HGRenderGraphBuilder *)sub_1808B59DC(
		                                     (unsigned int)v18,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"Skip Render ASM",
		                                     (unsigned int)&v20,
		                                     (__int64)v5,
		                                     0,
		                                     3);
		    v18[0] = 0LL;
		    v18[1] = &v19;
		    try
		    {
		      v8 = v20;
		      defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !v8 )
		        sub_1800D8250(v11, v10);
		      *(_QWORD *)(v8 + 24) = defaultResources;
		      if ( dword_18F35FD08 )
		      {
		        v12 = (((unsigned __int64)(v8 + 24) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F103690[v12]);
		        do
		          v13 = qword_18F103690[v12];
		        while ( v13 != _InterlockedCompareExchange64(
		                         &qword_18F103690[v12],
		                         v13 | (1LL << (((unsigned __int64)(v8 + 24) >> 12) & 0x3F)),
		                         v13) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v19, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGASMManager);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v19,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager->static_fields->s_skipASMPass,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      v18[0] = v17->ex;
		    }
		    sub_180268AE0(v18);
		  }
		}
		
		public void EndFrame() {} // 0x0000000189D1784C-0x0000000189D17890
		// Void EndFrame()
		void HG::Rendering::Runtime::HGASMManager::EndFrame(HGASMManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2082, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2082, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public void Dispose() {} // 0x0000000189D177D4-0x0000000189D1784C
		// Void Dispose()
		void HG::Rendering::Runtime::HGASMManager::Dispose(HGASMManager *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  RTHandle *m_asmShadowMapRT; // rcx
		  __int64 v7; // rdx
		  ASMTileManager *m_asmTileManager; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(552, 0LL) )
		  {
		    m_asmShadowMapRT = this->fields.m_asmShadowMapRT;
		    if ( m_asmShadowMapRT )
		      UnityEngine::Rendering::RTHandle::Release(m_asmShadowMapRT, 0LL);
		    this->fields.m_asmShadowMapRT = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_asmShadowMapRT, v3, v4, v5, v10);
		    m_asmTileManager = this->fields.m_asmTileManager;
		    if ( m_asmTileManager )
		    {
		      HG::Rendering::Runtime::ASMTileManager::Dispose(m_asmTileManager, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_asmTileManager, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(552, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
