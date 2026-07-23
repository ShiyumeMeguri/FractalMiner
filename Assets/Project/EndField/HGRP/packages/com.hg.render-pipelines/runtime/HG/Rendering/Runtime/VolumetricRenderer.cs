using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricRenderer // TypeDefIndex: 38749
	{
		// Fields
		private bool m_EnableFraming; // 0x10
		private bool m_EnableTAA; // 0x11
		private bool m_CanMergeTAAPass; // 0x12
		private bool m_BeforeTAANeedDepthTest; // 0x13
		private bool m_AfterTAANeedDepthTest; // 0x14
		private List<VolumetricRenderNode> m_RenderNodes; // 0x18
		private Dictionary<EVolumetricStage, VolumetricRenderStage> m_RenderStages; // 0x20
		private EVolumetricState m_VolumetricState; // 0x28
		private float m_VolumetricFadeRatio; // 0x2C
		private Material m_VolumetricMat; // 0x30
		private MaterialPropertyBlock m_PropertyBlock; // 0x38
		private Vector3 PrevCameraPos; // 0x40
		private Vector3 PrevCameraForward; // 0x4C
		private int m_RenderWidth; // 0x5C
		private int m_RenderHeight; // 0x60
		private int m_FramingWidth; // 0x64
		private int m_FramingHeight; // 0x68
		private int m_ReconstructIndex; // 0x6C
		private int m_TAAIndex; // 0x70
		private VolumetricPipelineRT[] m_MinMaxWorldDepths; // 0x78
		private VolumetricPipelineRT m_DepthForTest; // 0x80
		private VolumetricPipelineRT m_FramingColor; // 0x88
		private VolumetricPipelineRT m_FramingDepth; // 0x90
		private VolumetricPipelineRT[] m_ReconstructColors; // 0x98
		private VolumetricPipelineRT[] m_ReconstructDepths; // 0xA0
		private VolumetricPipelineRT m_ComposeColor; // 0xA8
		private VolumetricPipelineRT m_ComposeDepth; // 0xB0
		private VolumetricPipelineRT[] m_TAAColors; // 0xB8
		private VolumetricPipelineRT[] m_TAADepths; // 0xC0
		private int m_RTIndex; // 0xC8
		private Vector4 m_DownscaledScreenParams; // 0xCC
		private Vector2 m_NDCRescaleParams; // 0xDC
		private List<VolumetricRenderNode> renderNodePool; // 0xE8
		private int renderNodePoolIndex; // 0xF0
		private Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> framingCompose; // 0xF8
		private Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> temporalCompose; // 0x100
		private List<VolumetricRenderItem> _itemCache; // 0x108
	
		// Properties
		public bool enableFraming { get => default; } // 0x0000000189C5D97C-0x0000000189C5D9C8 
		// Boolean get_enableFraming()
		bool HG::Rendering::Runtime::VolumetricRenderer::get_enableFraming(VolumetricRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5141, 0LL) )
		    return this->fields.m_EnableFraming;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5141, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool IsFadeOut { get => default; } // 0x0000000189C5D8C4-0x0000000189C5D914 
		// Boolean get_IsFadeOut()
		bool HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeOut(VolumetricRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5142, 0LL) )
		    return this->fields.m_VolumetricState == 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5142, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool IsFadeIn { get => default; } // 0x0000000189C5D874-0x0000000189C5D8C4 
		// Boolean get_IsFadeIn()
		bool HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeIn(VolumetricRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5143, 0LL) )
		    return this->fields.m_VolumetricState == 2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5143, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool IsFading { get => default; } // 0x0000000189C5D914-0x0000000189C5D97C 
		// Boolean get_IsFading()
		bool HG::Rendering::Runtime::VolumetricRenderer::get_IsFading(VolumetricRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5144, 0LL) )
		    return HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeOut(this, 0LL)
		        || HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeIn(this, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(5144, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public int DrawFrameCount { get; private set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		// Int32 get_defaultArea()
		int32_t UnityEngine::AI::NavMeshSurface::get_defaultArea(NavMeshSurface *this, MethodInfo *method)
		{
		  return this->fields.m_DefaultArea;
		}
		

		// Void set_flags(TileFlags)
		void UnityEngine::Tilemaps::TileData::set_flags(TileData *this, TileFlags__Enum value, MethodInfo *method)
		{
		  this->m_Flags = value;
		}
		
	
		// Nested types
		public struct VolumetricCallbackContext // TypeDefIndex: 38735
		{
			// Fields
			public CommandBuffer Cmd; // 0x00
			public bool bFirstInPass; // 0x08
			public bool bEnableDownScale; // 0x09
			public bool bEnableFraming; // 0x0A
			public bool bEnableTAA; // 0x0B
			public EVolumetricStage Stage; // 0x0C
			public VolumetricPipelineRT SrcColor; // 0x10
			public VolumetricPipelineRT SrcDepths; // 0x18
			public VolumetricPipelineRT DstColor; // 0x20
			public VolumetricPipelineRT DstDepths; // 0x28
			public MeshFilter meshFilter; // 0x30
			public MeshRenderer meshRenderer; // 0x38
			public Material MSBakeMaterial; // 0x40
		}
	
		public struct VolumetricComposeContext // TypeDefIndex: 38736
		{
			// Fields
			public bool bEnableFraming; // 0x00
			public bool bEnableTAA; // 0x01
			public Material volumetricComposeMaterial; // 0x08
			public HGVolumetricCloudSettingParameters volumetricSettings; // 0x10
		}
	
		public struct VolumetricBounds // TypeDefIndex: 38737
		{
			// Fields
			public bool enableBounds; // 0x00
			public Bounds worldBounds; // 0x04
	
			// Constructors
			public VolumetricBounds(bool _enable, Bounds _worldBounds = default) {
				enableBounds = default;
				worldBounds = default;
			} // 0x0000000184DA1E20-0x0000000184DA1E40
			// VolumetricRenderer+VolumetricBounds(Boolean, Bounds)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricBounds::VolumetricBounds(
			        VolumetricRenderer_VolumetricBounds *this,
			        bool _enable,
			        Bounds *_worldBounds,
			        MethodInfo *method)
			{
			  __int128 v4; // xmm0
			  __int64 v5; // xmm1_8
			
			  v4 = *(_OWORD *)&_worldBounds->m_Center.x;
			  this->enableBounds = _enable;
			  v5 = *(_QWORD *)&_worldBounds->m_Extents.y;
			  *(_OWORD *)&this->worldBounds.m_Center.x = v4;
			  *(_QWORD *)&this->worldBounds.m_Extents.y = v5;
			}
			
		}
	
		public struct VolumetricRenderItem // TypeDefIndex: 38738
		{
			// Fields
			public Action<VolumetricCallbackContext> Callback; // 0x00
			public Material material; // 0x08
			public VolumetricBounds bounds; // 0x10
			public bool bEnableFraming; // 0x2C
			public bool bEnableTAA; // 0x2D
			public int SortingOrder; // 0x30
			public int RenderQueue; // 0x34
			public float DistToCamera; // 0x38
			public int ComposePriority; // 0x3C
			public bool bPureBlit; // 0x40
			public bool bFullScreen; // 0x41
			public MeshRenderer meshRenderer; // 0x48
			public MeshFilter meshFilter; // 0x50
	
			// Constructors
			public VolumetricRenderItem(Action<VolumetricCallbackContext> _callback, VolumetricBounds _bounds, Material _material = null, bool _enableFraming = false /* Metadata: 0x023040D7 */, bool _enableTAA = false /* Metadata: 0x023040D8 */, int _sortingOrder = 0 /* Metadata: 0x023040D9 */, int _renderQueue = 3000 /* Metadata: 0x023040DA */, float _distToCamera = 99999f /* Metadata: 0x023040DC */, int _composePriority = 0 /* Metadata: 0x023040E0 */, bool _pureBlit = true /* Metadata: 0x023040E1 */, bool _fullScreen = false /* Metadata: 0x023040E2 */) {
				Callback = default;
				material = default;
				bounds = default;
				bEnableFraming = default;
				bEnableTAA = default;
				SortingOrder = default;
				RenderQueue = default;
				DistToCamera = default;
				ComposePriority = default;
				bPureBlit = default;
				bFullScreen = default;
				meshRenderer = default;
				meshFilter = default;
			} // 0x0000000189C54950-0x0000000189C549F8
	
			// Methods
			public bool CheckVisibility(Camera camera) => default; // 0x0000000189C54780-0x0000000189C54950
			// Boolean CheckVisibility(Camera)
			bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::CheckVisibility(
			        VolumetricRenderer_VolumetricRenderItem *this,
			        Camera *camera,
			        MethodInfo *method)
			{
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  Plane__Array *v8; // rsi
			  float fieldOfView; // xmm7_4
			  float aspect; // xmm6_4
			  float v11; // xmm0_4
			  Matrix4x4 *v12; // rax
			  __int128 v13; // xmm6
			  __int128 v14; // xmm7
			  __int128 v15; // xmm8
			  __int128 v16; // xmm9
			  Matrix4x4 *worldToCameraMatrix; // rax
			  __int128 v18; // xmm1
			  __int128 v19; // xmm0
			  __int128 v20; // xmm1
			  Matrix4x4 *v21; // rax
			  __int128 v22; // xmm1
			  __int128 v23; // xmm0
			  __int128 v24; // xmm1
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  Matrix4x4 v26; // [rsp+38h] [rbp-D0h] BYREF
			  Bounds v27; // [rsp+78h] [rbp-90h] BYREF
			  Matrix4x4 v28; // [rsp+98h] [rbp-70h] BYREF
			  Matrix4x4 v29[2]; // [rsp+D8h] [rbp-30h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5155, 0LL) )
			  {
			    if ( !this->bounds.enableBounds )
			      return 1;
			    v8 = (Plane__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
			    if ( camera )
			    {
			      fieldOfView = UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			      aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
			      v11 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			      v12 = UnityEngine::Matrix4x4::Perspective(&v28, fieldOfView, aspect, v11, 10000.0, 0LL);
			      v13 = *(_OWORD *)&v12->m00;
			      v14 = *(_OWORD *)&v12->m01;
			      v15 = *(_OWORD *)&v12->m02;
			      v16 = *(_OWORD *)&v12->m03;
			      worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v28, camera, 0LL);
			      v18 = *(_OWORD *)&worldToCameraMatrix->m01;
			      *(_OWORD *)&v26.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
			      v19 = *(_OWORD *)&worldToCameraMatrix->m02;
			      *(_OWORD *)&v26.m01 = v18;
			      v20 = *(_OWORD *)&worldToCameraMatrix->m03;
			      *(_OWORD *)&v26.m02 = v19;
			      *(_OWORD *)&v26.m03 = v20;
			      *(_OWORD *)&v28.m00 = v13;
			      *(_OWORD *)&v28.m01 = v14;
			      *(_OWORD *)&v28.m02 = v15;
			      *(_OWORD *)&v28.m03 = v16;
			      v21 = UnityEngine::Matrix4x4::op_Multiply(v29, &v28, &v26, 0LL);
			      v22 = *(_OWORD *)&v21->m01;
			      *(_OWORD *)&v26.m00 = *(_OWORD *)&v21->m00;
			      v23 = *(_OWORD *)&v21->m02;
			      *(_OWORD *)&v26.m01 = v22;
			      v24 = *(_OWORD *)&v21->m03;
			      *(_OWORD *)&v26.m02 = v23;
			      *(_OWORD *)&v26.m03 = v24;
			      UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v26, v8, 0LL);
			      *(_QWORD *)&v24 = *(_QWORD *)&this->bounds.worldBounds.m_Extents.y;
			      *(_OWORD *)&v27.m_Center.x = *(_OWORD *)&this->bounds.worldBounds.m_Center.x;
			      *(_QWORD *)&v27.m_Extents.y = v24;
			      return UnityEngine::GeometryUtility::TestPlanesAABB(v8, &v27, 0LL);
			    }
			LABEL_7:
			    sub_1800D8260(v7, v6);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(5155, 0LL);
			  if ( !Patch )
			    goto LABEL_7;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1498(Patch, this, (Object *)camera, 0LL);
			}
			
		}
	
		private class VolumetricRenderNode // TypeDefIndex: 38739
		{
			// Fields
			private VolumetricRenderItem? item; // 0x10
			private bool bAdded; // 0x70
			private bool bProcessed; // 0x71
			private int index; // 0x74
	
			// Properties
			public Action<VolumetricCallbackContext> Callback { get => default; } // 0x0000000189C54EC8-0x0000000189C54F44 
			// Action`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricCallbackContext] get_Callback()
			Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_Callback(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5210, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5210, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1508(Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.Callback;
			  }
			  else
			  {
			    return 0LL;
			  }
			}
			
			public Material material { get => default; } // 0x0000000189C55358-0x0000000189C553D4 
			// Material get_material()
			Material *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5160, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5160, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_641(Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.material;
			  }
			  else
			  {
			    return 0LL;
			  }
			}
			
			public MeshFilter meshFilter { get => default; } // 0x0000000189C553D4-0x0000000189C55450 
			// MeshFilter get_meshFilter()
			MeshFilter *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshFilter(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5211, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5211, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_929(Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.meshFilter;
			  }
			  else
			  {
			    return 0LL;
			  }
			}
			
			public MeshRenderer meshRenderer { get => default; } // 0x0000000189C55450-0x0000000189C554CC 
			// MeshRenderer get_meshRenderer()
			MeshRenderer *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshRenderer(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5212, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5212, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_928(Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.meshRenderer;
			  }
			  else
			  {
			    return 0LL;
			  }
			}
			
			public VolumetricBounds bounds { get => default; } // 0x0000000189C55284-0x0000000189C55358 
			// VolumetricRenderer+VolumetricBounds get_bounds()
			VolumetricRenderer_VolumetricBounds *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bounds(
			        VolumetricRenderer_VolumetricBounds *__return_ptr retstr,
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  __int128 v5; // xmm0
			  float z; // eax
			  __int64 v7; // xmm1_8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  VolumetricRenderer_VolumetricBounds *v11; // rax
			  VolumetricRenderer_VolumetricBounds v13; // [rsp+20h] [rbp-88h] BYREF
			  VolumetricRenderer_VolumetricRenderItem v14; // [rsp+40h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5213, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5213, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1509(&v13, Patch, (Object *)this, 0LL);
			    v5 = *(_OWORD *)&v11->enableBounds;
			    v7 = *(_QWORD *)&v11->worldBounds.m_Extents.x;
			    z = v11->worldBounds.m_Extents.z;
			    goto LABEL_8;
			  }
			  if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v14,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    v5 = *(_OWORD *)&v14.bounds.enableBounds;
			    z = v14.bounds.worldBounds.m_Extents.z;
			    v7 = *(_QWORD *)&v14.bounds.worldBounds.m_Extents.x;
			LABEL_8:
			    *(_OWORD *)&retstr->enableBounds = v5;
			    *(_QWORD *)&retstr->worldBounds.m_Extents.x = v7;
			    retstr->worldBounds.m_Extents.z = z;
			    return retstr;
			  }
			  *(_QWORD *)&v13.worldBounds.m_Extents.x = 0LL;
			  *(_WORD *)(&retstr->enableBounds + 1) = 0;
			  *(&retstr->enableBounds + 3) = 0;
			  *(_OWORD *)&retstr->worldBounds.m_Center.x = 0LL;
			  retstr->enableBounds = 0;
			  *(_QWORD *)&retstr->worldBounds.m_Extents.y = *(_QWORD *)&v13.worldBounds.m_Extents.x;
			  return retstr;
			}
			
			public bool bEnableFraming { get => default; } // 0x0000000189C55110-0x0000000189C5518C 
			// Boolean get_bEnableFraming()
			bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableFraming(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  result = IFix::WrappersManagerImpl::IsPatched(5158, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5158, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.bEnableFraming;
			  }
			  return result;
			}
			
			public bool bEnableTAA { get => default; } // 0x0000000189C5518C-0x0000000189C55208 
			// Boolean get_bEnableTAA()
			bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableTAA(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  result = IFix::WrappersManagerImpl::IsPatched(5159, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5159, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.bEnableTAA;
			  }
			  return result;
			}
			
			public int SortingOrder { get => default; } // 0x0000000189C55094-0x0000000189C55110 
			// Int32 get_SortingOrder()
			int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5169, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5169, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.SortingOrder;
			  }
			  else
			  {
			    return 0;
			  }
			}
			
			public int RenderQueue { get => default; } // 0x0000000189C55014-0x0000000189C55094 
			// Int32 get_RenderQueue()
			int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5170, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5170, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.RenderQueue;
			  }
			  else
			  {
			    return 3000;
			  }
			}
			
			public float DistToCamera { get => default; } // 0x0000000189C54F44-0x0000000189C54FC8 
			// Single get_DistToCamera()
			float HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5171, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5171, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.DistToCamera;
			  }
			  else
			  {
			    return 99999.0;
			  }
			}
			
			public bool bFullScreen { get => default; } // 0x0000000189C55208-0x0000000189C55284 
			// Boolean get_bFullScreen()
			bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  VolumetricRenderer_VolumetricRenderItem v7; // [rsp+20h] [rbp-68h] BYREF
			
			  result = IFix::WrappersManagerImpl::IsPatched(5185, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5185, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			  }
			  else if ( this->fields.item.hasValue )
			  {
			    System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value(
			      &v7,
			      &this->fields.item,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Value);
			    return v7.bFullScreen;
			  }
			  return result;
			}
			
			public IVolumetricRenderObject RenderObject { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
			// String get_propertyPath()
			String *NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::get_propertyPath(
			        Variable_1_UnityEngine_ContactPoint2D_ *this,
			        MethodInfo *method)
			{
			  return this->fields._propertyPath;
			}
			

			// Void set_propertyPath(String)
			void NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::set_propertyPath(
			        Variable_1_UnityEngine_ContactPoint2D_ *this,
			        String *value,
			        MethodInfo *method)
			{
			  Int32__Array **v3; // r9
			  MethodInfo *v4; // [rsp+28h] [rbp+28h]
			  bool v5; // [rsp+30h] [rbp+30h]
			  int32_t v6; // [rsp+38h] [rbp+38h]
			  int32_t v7; // [rsp+40h] [rbp+40h]
			  float v8; // [rsp+48h] [rbp+48h]
			  int32_t v9; // [rsp+50h] [rbp+50h]
			  bool v10; // [rsp+58h] [rbp+58h]
			  bool v11; // [rsp+60h] [rbp+60h]
			  MethodInfo *v12; // [rsp+68h] [rbp+68h]
			
			  this->fields._propertyPath = value;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)&this->fields._propertyPath,
			    (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)value,
			    (VolumetricRenderer_VolumetricBounds *)method,
			    v3,
			    v4,
			    v5,
			    v6,
			    v7,
			    v8,
			    v9,
			    v10,
			    v11,
			    v12);
			}
			
			public bool bComposePass { get; set; } // 0x0000000184D8D1F0-0x0000000184D8D200 0x0000000184D8D200-0x0000000184D8D210
			// Boolean get_variableBind()
			bool Beyond::Gameplay::Actions::Param<UnityEngine::Quaternion>::get_variableBind(
			        Param_1_UnityEngine_Quaternion_ *this,
			        MethodInfo *method)
			{
			  return this->fields.m_variableBind;
			}
			

			// Void set_variableBind(Boolean)
			void Beyond::Gameplay::Actions::Param<UnityEngine::Quaternion>::set_variableBind(
			        Param_1_UnityEngine_Quaternion_ *this,
			        bool value,
			        MethodInfo *method)
			{
			  this->fields.m_variableBind = value;
			}
			
			public bool IsAdded { get => default; } // 0x0000000189C54FC8-0x0000000189C55014 
			// Boolean get_IsAdded()
			bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_IsAdded(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5208, 0LL) )
			    return this->fields.bAdded;
			  Patch = IFix::WrappersManagerImpl::GetPatch(5208, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			}
			
	
			// Constructors
			public VolumetricRenderNode() {} // 0x0000000184DA1E40-0x0000000184DA1E50
			// VolumetricRenderer+VolumetricRenderNode()
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::VolumetricRenderNode(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  this->fields.index = -1;
			}
			
	
			// Methods
			public void SetRenderItem(VolumetricRenderItem _item) {} // 0x0000000189C54D98-0x0000000189C54EC8
			// Void SetRenderItem(VolumetricRenderer+VolumetricRenderItem)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        VolumetricRenderer_VolumetricRenderItem *_item,
			        MethodInfo *method)
			{
			  __int128 v5; // xmm1
			  __int128 v6; // xmm0
			  __int128 v7; // xmm1
			  __int128 v8; // xmm0
			  __int128 v9; // xmm1
			  __int128 v10; // xmm0
			  __int128 v11; // xmm1
			  __int128 v12; // xmm0
			  __int128 v13; // xmm1
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rdx
			  VolumetricRenderer_VolumetricBounds *v15; // r8
			  Int32__Array **v16; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v18; // rdx
			  __int64 v19; // rcx
			  __int128 v20; // xmm1
			  __int128 v21; // xmm0
			  __int128 v22; // xmm1
			  __int128 v23; // xmm0
			  VolumetricRenderer_VolumetricRenderItem v24; // [rsp+20h] [rbp-69h] BYREF
			  _OWORD v25[6]; // [rsp+80h] [rbp-9h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5156, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5156, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v19, v18);
			    v20 = *(_OWORD *)&_item->bounds.enableBounds;
			    *(_OWORD *)&v24.Callback = *(_OWORD *)&_item->Callback;
			    v21 = *(_OWORD *)&_item->bounds.worldBounds.m_Extents.x;
			    *(_OWORD *)&v24.bounds.enableBounds = v20;
			    v22 = *(_OWORD *)&_item->SortingOrder;
			    *(_OWORD *)&v24.bounds.worldBounds.m_Extents.x = v21;
			    v23 = *(_OWORD *)&_item->bPureBlit;
			    *(_OWORD *)&v24.SortingOrder = v22;
			    *(_QWORD *)&v22 = _item->meshFilter;
			    *(_OWORD *)&v24.bPureBlit = v23;
			    v24.meshFilter = (MeshFilter *)v22;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1499(Patch, (Object *)this, &v24, 0LL);
			  }
			  else
			  {
			    sub_18033B9D0(v25, 0LL, 96LL);
			    v5 = *(_OWORD *)&_item->bounds.enableBounds;
			    *(_OWORD *)&v24.Callback = *(_OWORD *)&_item->Callback;
			    v6 = *(_OWORD *)&_item->bounds.worldBounds.m_Extents.x;
			    *(_OWORD *)&v24.bounds.enableBounds = v5;
			    v7 = *(_OWORD *)&_item->SortingOrder;
			    *(_OWORD *)&v24.bounds.worldBounds.m_Extents.x = v6;
			    v8 = *(_OWORD *)&_item->bPureBlit;
			    *(_OWORD *)&v24.SortingOrder = v7;
			    *(_QWORD *)&v7 = _item->meshFilter;
			    *(_OWORD *)&v24.bPureBlit = v8;
			    v24.meshFilter = (MeshFilter *)v7;
			    sub_1806B9E88(
			      v25,
			      &v24,
			      MethodInfo::System::Nullable<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Nullable);
			    v9 = v25[1];
			    *(_OWORD *)&this->fields.item.hasValue = v25[0];
			    v10 = v25[2];
			    *(_OWORD *)&this->fields.item.value.material = v9;
			    v11 = v25[3];
			    *(_OWORD *)&this->fields.item.value.bounds.worldBounds.m_Center.y = v10;
			    v12 = v25[4];
			    *(_OWORD *)&this->fields.item.value.bounds.worldBounds.m_Extents.z = v11;
			    v13 = v25[5];
			    *(_OWORD *)&this->fields.item.value.DistToCamera = v12;
			    *(_OWORD *)&this->fields.item.value.meshRenderer = v13;
			    sub_18002D1B0(
			      &this->fields.item.value,
			      v14,
			      v15,
			      v16,
			      (MethodInfo *)v24.Callback,
			      (bool)v24.material,
			      *(int32_t *)&v24.bounds.enableBounds,
			      SLODWORD(v24.bounds.worldBounds.m_Center.y),
			      v24.bounds.worldBounds.m_Extents.x,
			      SLODWORD(v24.bounds.worldBounds.m_Extents.z),
			      v24.SortingOrder,
			      SLOBYTE(v24.DistToCamera),
			      *(MethodInfo **)&v24.bPureBlit);
			  }
			}
			
			public void SetIndex(int _index) {} // 0x0000000189C54D40-0x0000000189C54D98
			// Void SetIndex(Int32)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetIndex(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        int32_t _index,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5172, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5172, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, _index, 0LL);
			  }
			  else
			  {
			    this->fields.index = _index;
			  }
			}
			
			public void MarkAdd() {} // 0x0000000189C549F8-0x0000000189C54A48
			// Void MarkAdd()
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::MarkAdd(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5179, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5179, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    this->fields.bAdded = 1;
			  }
			}
			
			public void Reset() {} // 0x0000000189C54CDC-0x0000000189C54D40
			// Void Reset()
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Reset(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5147, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5147, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    sub_18033B9D0(&this->fields, 0LL, 96LL);
			    *(_WORD *)&this->fields.bAdded = 0;
			    this->fields.index = -1;
			  }
			}
			
			public void Process(VolumetricCallbackContext context) {} // 0x0000000189C54BB8-0x0000000189C54CDC
			// Void Process(VolumetricRenderer+VolumetricCallbackContext)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
			        VolumetricRenderer_VolumetricRenderNode *this,
			        VolumetricRenderer_VolumetricCallbackContext *context,
			        MethodInfo *method)
			{
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v5; // rdx
			  VolumetricRenderer_VolumetricBounds *v6; // r8
			  Int32__Array **v7; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
			  VolumetricRenderer_VolumetricBounds *v9; // r8
			  Int32__Array **v10; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *Callback; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  __int128 v14; // xmm1
			  __int128 v15; // xmm0
			  __int128 v16; // xmm1
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int128 v18; // xmm1
			  __int128 v19; // xmm0
			  __int128 v20; // xmm1
			  VolumetricRenderer_VolumetricCallbackContext v21; // [rsp+20h] [rbp-50h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5214, 0LL) )
			  {
			    if ( this->fields.bProcessed )
			      return;
			    if ( !HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_Callback(this, 0LL) )
			      goto LABEL_6;
			    context->meshFilter = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshFilter(this, 0LL);
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&context->meshFilter,
			      v5,
			      v6,
			      v7,
			      (MethodInfo *)v21.Cmd,
			      v21.bFirstInPass,
			      (int32_t)v21.SrcColor,
			      (int32_t)v21.SrcDepths,
			      *(float *)&v21.DstColor,
			      (int32_t)v21.DstDepths,
			      (bool)v21.meshFilter,
			      (bool)v21.meshRenderer,
			      (MethodInfo *)v21.MSBakeMaterial);
			    context->meshRenderer = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_meshRenderer(
			                              this,
			                              0LL);
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&context->meshRenderer,
			      v8,
			      v9,
			      v10,
			      (MethodInfo *)v21.Cmd,
			      v21.bFirstInPass,
			      (int32_t)v21.SrcColor,
			      (int32_t)v21.SrcDepths,
			      *(float *)&v21.DstColor,
			      (int32_t)v21.DstDepths,
			      (bool)v21.meshFilter,
			      (bool)v21.meshRenderer,
			      (MethodInfo *)v21.MSBakeMaterial);
			    Callback = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_Callback(this, 0LL);
			    if ( Callback )
			    {
			      v14 = *(_OWORD *)&context->SrcColor;
			      *(_OWORD *)&v21.Cmd = *(_OWORD *)&context->Cmd;
			      v15 = *(_OWORD *)&context->DstColor;
			      *(_OWORD *)&v21.SrcColor = v14;
			      v16 = *(_OWORD *)&context->meshFilter;
			      *(_OWORD *)&v21.DstColor = v15;
			      v21.MSBakeMaterial = context->MSBakeMaterial;
			      *(_OWORD *)&v21.meshFilter = v16;
			      System::Func<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL,UnityEngine::Vector2>::Invoke(
			        (Func_2_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_UnityEngine_Vector2_ *)Callback,
			        (prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL *)&v21,
			        0LL);
			LABEL_6:
			      this->fields.bProcessed = 1;
			      return;
			    }
			LABEL_8:
			    sub_1800D8260(v13, v12);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(5214, 0LL);
			  if ( !Patch )
			    goto LABEL_8;
			  v18 = *(_OWORD *)&context->SrcColor;
			  *(_OWORD *)&v21.Cmd = *(_OWORD *)&context->Cmd;
			  v19 = *(_OWORD *)&context->DstColor;
			  *(_OWORD *)&v21.SrcColor = v18;
			  v20 = *(_OWORD *)&context->meshFilter;
			  *(_OWORD *)&v21.DstColor = v19;
			  v21.MSBakeMaterial = context->MSBakeMaterial;
			  *(_OWORD *)&v21.meshFilter = v20;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1510(Patch, (Object *)this, &v21, 0LL);
			}
			
			public static int NodeCompare(VolumetricRenderNode l, VolumetricRenderNode r) => default; // 0x0000000189C54A48-0x0000000189C54BB8
			// Int32 NodeCompare(VolumetricRenderer+VolumetricRenderNode, VolumetricRenderer+VolumetricRenderNode)
			int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare(
			        VolumetricRenderer_VolumetricRenderNode *l,
			        VolumetricRenderer_VolumetricRenderNode *r,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  int32_t SortingOrder; // ebx
			  int32_t RenderQueue; // ebx
			  float DistToCamera; // xmm6_4
			  float v10; // xmm0_4
			  __int32 v11; // xmm1_4
			  int32_t result; // eax
			  float v13; // xmm6_4
			  float v14; // xmm0_4
			  int32_t v15; // ebx
			  int32_t v16; // eax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5168, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5168, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
			               (ILFixDynamicMethodWrapper_17 *)Patch,
			               (Object *)l,
			               (Object *)r,
			               0LL);
			LABEL_15:
			    sub_1800D8260(v6, v5);
			  }
			  if ( !l )
			    goto LABEL_15;
			  SortingOrder = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(l, 0LL);
			  if ( !r )
			    goto LABEL_15;
			  if ( SortingOrder != HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(r, 0LL) )
			  {
			    v15 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(l, 0LL);
			    v16 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_SortingOrder(r, 0LL);
			    return v15 - v16;
			  }
			  RenderQueue = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(l, 0LL);
			  if ( RenderQueue != HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(r, 0LL) )
			  {
			    v15 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(l, 0LL);
			    v16 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_RenderQueue(r, 0LL);
			    return v15 - v16;
			  }
			  DistToCamera = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(l, 0LL);
			  v10 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(r, 0LL);
			  COERCE_FLOAT(v11 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
			  if ( fmaxf(
			         fmaxf(COERCE_FLOAT(LODWORD(DistToCamera) & v11), COERCE_FLOAT(LODWORD(v10) & v11)) * 0.000001,
			         TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(v10 - DistToCamera) & v11) )
			    return l->fields.index - r->fields.index;
			  v13 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(l, 0LL);
			  v14 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_DistToCamera(r, 0LL);
			  result = 1;
			  if ( v13 > v14 )
			    return -1;
			  return result;
			}
			
		}
	
		private abstract class VolumetricRenderStage // TypeDefIndex: 38740
		{
			// Fields
			protected EVolumetricStage stage; // 0x10
			protected VolumetricRenderer renderer; // 0x18
			protected List<VolumetricRenderNode> renderNodes; // 0x28
	
			// Properties
			public bool Enabled { get; private set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
			// Boolean get_autoTriggerEvent()
			bool Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_autoTriggerEvent(
			        ValueWatcher_1_System_Object_ *this,
			        MethodInfo *method)
			{
			  return this->fields.jfwTQnAbUjPonSNJeDchTULdikzO;
			}
			

			// Void set_autoTriggerEvent(Boolean)
			void Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::set_autoTriggerEvent(
			        ValueWatcher_1_System_Object_ *this,
			        bool value,
			        MethodInfo *method)
			{
			  this->fields.jfwTQnAbUjPonSNJeDchTULdikzO = value;
			}
			
			public List<VolumetricRenderNode> RenderNodes { get; } // 0x0000000189C55D58-0x0000000189C55DA8 
			// List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderNode] get_RenderNodes()
			List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5181, 0LL) )
			    return this->fields.renderNodes;
			  Patch = IFix::WrappersManagerImpl::GetPatch(5181, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1501(Patch, (Object *)this, 0LL);
			}
			
	
			// Constructors
			protected VolumetricRenderStage() {} // Dummy constructor
			public VolumetricRenderStage(EVolumetricStage inStage) {} // 0x000000018451E4F0-0x000000018451E550
	
			// Methods
			public void Reset() {} // 0x0000000189C55C14-0x0000000189C55C74
			// Void Reset()
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodes; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5175, 0LL) )
			  {
			    renderNodes = this->fields.renderNodes;
			    this->fields._Enabled_k__BackingField = 0;
			    if ( renderNodes )
			    {
			      sub_183127A90(
			        renderNodes,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Clear);
			      return;
			    }
			LABEL_5:
			    sub_1800D8260(renderNodes, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(5175, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			public void SetEnable() {} // 0x0000000189C55C74-0x0000000189C55CC4
			// Void SetEnable()
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SetEnable(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5177, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5177, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    this->fields._Enabled_k__BackingField = 1;
			  }
			}
			
			public void AddRenderNode(VolumetricRenderNode node) {} // 0x0000000189C55A70-0x0000000189C55AF0
			// Void AddRenderNode(VolumetricRenderer+VolumetricRenderNode)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        VolumetricRenderer_VolumetricRenderNode *node,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  List_1_System_Object_ *renderNodes; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5178, 0LL) )
			  {
			    renderNodes = (List_1_System_Object_ *)this->fields.renderNodes;
			    this->fields._Enabled_k__BackingField = 1;
			    if ( renderNodes )
			    {
			      sub_182F01190(renderNodes, (Object *)node);
			      if ( node )
			      {
			        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::MarkAdd(node, 0LL);
			        return;
			      }
			    }
			LABEL_6:
			    sub_1800D8260(renderNodes, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(5178, 0LL);
			  if ( !Patch )
			    goto LABEL_6;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			    (ILFixDynamicMethodWrapper_39 *)Patch,
			    (Object *)this,
			    (Object *)node,
			    0LL);
			}
			
			public void SortNodes() {} // 0x0000000189C55CC4-0x0000000189C55D58
			// Void SortNodes()
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SortNodes(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        MethodInfo *method)
			{
			  List_1_System_Object_ *renderNodes; // rdi
			  Comparison_1_Object_ *v4; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  Comparison_1_Object_ *v7; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5200, 0LL) )
			  {
			    renderNodes = (List_1_System_Object_ *)this->fields.renderNodes;
			    v4 = (Comparison_1_Object_ *)sub_18002C620(TypeInfo::System::Comparison<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
			    v7 = v4;
			    if ( v4 )
			    {
			      System::Comparison<System::Object>::Comparison(
			        v4,
			        0LL,
			        MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare,
			        0LL);
			      if ( renderNodes )
			      {
			        System::Collections::Generic::List<System::Object>::Sort(
			          renderNodes,
			          v7,
			          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Sort);
			        return;
			      }
			    }
			LABEL_6:
			    sub_1800D8260(v6, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(5200, 0LL);
			  if ( !Patch )
			    goto LABEL_6;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			protected virtual void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT) {} // 0x0000000189C55AF0-0x0000000189C55B68
			// Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        VolumetricRenderInputs *inputs,
			        VolumetricPipelineRT **colorRT,
			        VolumetricPipelineRT **depthsRT,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v10; // rdx
			  __int64 v11; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5206, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5206, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v11, v10);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1507(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
			  }
			}
			
			public void Process(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT) {} // 0x0000000189C55B68-0x0000000189C55C14
			// Void Process(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
			        VolumetricRenderer_VolumetricRenderStage *this,
			        VolumetricRenderInputs *inputs,
			        VolumetricPipelineRT **colorRT,
			        VolumetricPipelineRT **depthsRT,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v10; // rdx
			  __int64 v11; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5205, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5205, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v11, v10);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1507(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
			  }
			  else if ( this->fields._Enabled_k__BackingField )
			  {
			    sub_1800049A0(this->klass);
			    ((void (__fastcall *)(VolumetricRenderer_VolumetricRenderStage *, VolumetricRenderInputs *, VolumetricPipelineRT **, VolumetricPipelineRT **, const Il2CppImage *))this->klass->vtable.ProcessImpl.method)(
			      this,
			      inputs,
			      colorRT,
			      depthsRT,
			      this->klass[1]._0.image);
			  }
			}
			
		}
	
		private class FramingStage : VolumetricRenderStage // TypeDefIndex: 38741
		{
			// Constructors
			public FramingStage() {} // Dummy constructor
			public FramingStage(VolumetricRenderer inRenderer, EVolumetricStage inStage) {} // 0x000000018451E550-0x000000018451E590
			// VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderer *inRenderer,
			        EVolumetricStage__Enum inStage,
			        MethodInfo *method)
			{
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
			  VolumetricRenderer_VolumetricBounds *v7; // r8
			  Int32__Array **v8; // r9
			  MethodInfo *v9; // [rsp+50h] [rbp+28h]
			  bool v10; // [rsp+58h] [rbp+30h]
			  int32_t v11; // [rsp+60h] [rbp+38h]
			  int32_t v12; // [rsp+68h] [rbp+40h]
			  float v13; // [rsp+70h] [rbp+48h]
			  int32_t v14; // [rsp+78h] [rbp+50h]
			  bool v15; // [rsp+80h] [rbp+58h]
			  bool v16; // [rsp+88h] [rbp+60h]
			  MethodInfo *v17; // [rsp+90h] [rbp+68h]
			
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    inStage,
			    0LL);
			  this->fields._.renderer = inRenderer;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)&this->fields._.renderer,
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
			    v16,
			    v17);
			}
			
	
			// Methods
			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT) {} // 0x0000000189C50E0C-0x0000000189C51830
			// Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::FramingStage::ProcessImpl(
			        VolumetricRenderer_FramingStage *this,
			        VolumetricRenderInputs *inputs,
			        VolumetricPipelineRT **colorRT,
			        VolumetricPipelineRT **depthsRT,
			        MethodInfo *method)
			{
			  MethodInfo *v9; // rdx
			  unsigned int *m_VolumetricMat; // rcx
			  HGRenderGraphContext *context; // r14
			  VolumetricRenderer *renderer; // rsi
			  CommandBuffer *cmd; // r14
			  VolumetricRenderer *v14; // rax
			  __int64 m_RTIndex; // rsi
			  VolumetricPipelineRT__Array *m_ReconstructColors; // r12
			  VolumetricPipelineRT__Array *m_ReconstructDepths; // r15
			  VolumetricRenderer *v18; // rax
			  VolumetricPipelineRT *m_FramingDepth; // rbx
			  RenderTexture *RT; // rbx
			  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodes; // rax
			  Object *Item; // rax
			  Quaternion *identity; // rax
			  int32_t i; // ebx
			  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v25; // rax
			  Object *v26; // rax
			  Material *material; // rax
			  char v28; // al
			  __int64 v29; // rbx
			  EFramingQuality__Enum v30; // ebx
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v31; // rdx
			  VolumetricRenderer_VolumetricBounds *v32; // r8
			  Int32__Array **v33; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v34; // rdx
			  bool v35; // cl
			  HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
			  VolumetricRenderer_VolumetricBounds *v37; // r8
			  Int32__Array **v38; // r9
			  VolumetricRenderer *v39; // rax
			  VolumetricRenderer *v40; // rax
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v41; // rdx
			  VolumetricRenderer_VolumetricBounds *v42; // r8
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v43; // rdx
			  VolumetricRenderer_VolumetricBounds *v44; // r8
			  Int32__Array **v45; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v46; // rdx
			  VolumetricRenderer_VolumetricBounds *v47; // r8
			  Int32__Array **v48; // r9
			  int32_t v49; // r8d
			  int32_t ReconstructComposeRatio; // ebx
			  float v51; // xmm0_4
			  int32_t ReconstructCurrentColor; // ebx
			  Texture *v53; // rax
			  RenderTargetIdentifier *v54; // rax
			  __int128 v55; // xmm1
			  int32_t ReconstructCurrentDepth; // ebx
			  Texture *v57; // rax
			  RenderTargetIdentifier *v58; // rax
			  __int128 v59; // xmm1
			  __int64 v60; // rdx
			  VolumetricShaderIDs__StaticFields *static_fields; // rcx
			  int32_t ReconstructHistoryColor; // ebx
			  Texture *v63; // rax
			  RenderTargetIdentifier *v64; // rax
			  __int128 v65; // xmm1
			  __int64 v66; // rdx
			  VolumetricShaderIDs__StaticFields *v67; // rcx
			  int32_t ReconstructHistoryDepth; // ebx
			  Texture *v69; // rax
			  RenderTargetIdentifier *v70; // rax
			  __int128 v71; // xmm1
			  __int64 v72; // rdx
			  VolumetricPipelineRT *v73; // rcx
			  VolumetricRenderer *v74; // rax
			  HGVolumetricCloudSettingParameters *v75; // rax
			  SettingParameter_1_EFramingQuality_ *framingLevel; // rbx
			  EFramingQuality__Enum paramValue_k__BackingField; // ebx
			  Material *v78; // r13
			  __int64 v79; // rcx
			  RenderTexture *v80; // rbx
			  RenderTexture *v81; // rax
			  MethodInfo *v82; // r8
			  VolumetricRenderer *v83; // rax
			  MaterialPropertyBlock *v84; // xmm0_8
			  float z; // eax
			  int32_t v86; // r10d
			  __int64 v87; // rdx
			  MethodInfo *v88; // r8
			  VolumetricRenderer *v89; // rax
			  MaterialPropertyBlock *v90; // xmm0_8
			  float v91; // eax
			  int32_t v92; // r10d
			  __int64 v93; // rdx
			  VolumetricShaderIDs__StaticFields *v94; // rcx
			  int32_t ReconstructColor; // ebx
			  VolumetricPipelineRT *v96; // rcx
			  Texture *v97; // rax
			  RenderTargetIdentifier *v98; // rax
			  __int128 v99; // xmm1
			  __int64 v100; // rdx
			  VolumetricShaderIDs__StaticFields *v101; // rcx
			  int32_t ReconstructDepth; // ebx
			  VolumetricPipelineRT *v103; // rcx
			  Texture *v104; // rax
			  RenderTargetIdentifier *v105; // rax
			  __int128 v106; // xmm1
			  __int64 v107; // rdx
			  VolumetricShaderIDs__StaticFields *v108; // rcx
			  int32_t VolumetricComposeColor; // ebx
			  VolumetricPipelineRT *v110; // rcx
			  Texture *v111; // rax
			  RenderTargetIdentifier *v112; // rax
			  __int128 v113; // xmm1
			  __int64 v114; // rdx
			  VolumetricShaderIDs__StaticFields *v115; // rcx
			  int32_t VolumetricComposeDepth; // ebx
			  VolumetricPipelineRT *v117; // rcx
			  Texture *v118; // rax
			  RenderTargetIdentifier *v119; // rax
			  __int128 v120; // xmm1
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v121; // rdx
			  __int64 v122; // rcx
			  VolumetricRenderer_VolumetricBounds *v123; // r8
			  Int32__Array **v124; // r9
			  VolumetricRenderer_VolumetricBounds *v125; // r8
			  Int32__Array **v126; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *backface; // [rsp+20h] [rbp-E0h]
			  MethodInfo *backfacea; // [rsp+20h] [rbp-E0h]
			  MethodInfo *backfaced; // [rsp+20h] [rbp-E0h]
			  MethodInfo *backfacee; // [rsp+20h] [rbp-E0h]
			  MethodInfo *backfacef; // [rsp+20h] [rbp-E0h]
			  MethodInfo *backfaceb; // [rsp+20h] [rbp-E0h]
			  MethodInfo *backfacec; // [rsp+20h] [rbp-E0h]
			  bool v135; // [rsp+28h] [rbp-D8h]
			  bool v136; // [rsp+28h] [rbp-D8h]
			  bool v137; // [rsp+28h] [rbp-D8h]
			  bool v138; // [rsp+28h] [rbp-D8h]
			  bool v139; // [rsp+28h] [rbp-D8h]
			  bool v140; // [rsp+28h] [rbp-D8h]
			  bool v141; // [rsp+28h] [rbp-D8h]
			  int32_t enable; // [rsp+30h] [rbp-D0h]
			  int32_t enablea; // [rsp+30h] [rbp-D0h]
			  int32_t enablec; // [rsp+30h] [rbp-D0h]
			  int32_t enabled; // [rsp+30h] [rbp-D0h]
			  int32_t enablee; // [rsp+30h] [rbp-D0h]
			  int32_t enableb; // [rsp+30h] [rbp-D0h]
			  int32_t v148; // [rsp+38h] [rbp-C8h]
			  int32_t v149; // [rsp+38h] [rbp-C8h]
			  int32_t v150; // [rsp+38h] [rbp-C8h]
			  int32_t v151; // [rsp+38h] [rbp-C8h]
			  int32_t v152; // [rsp+38h] [rbp-C8h]
			  int32_t v153; // [rsp+38h] [rbp-C8h]
			  RenderTargetIdentifier v154; // [rsp+40h] [rbp-C0h] BYREF
			  RenderTexture *colorRTa; // [rsp+70h] [rbp-90h]
			  MaterialPropertyBlock *propertyBlock[2]; // [rsp+80h] [rbp-80h] BYREF
			  Material *mat[2]; // [rsp+90h] [rbp-70h] BYREF
			  VolumetricPipelineRT *v158; // [rsp+A0h] [rbp-60h]
			  VolumetricPipelineRT *v159; // [rsp+A8h] [rbp-58h]
			  Vector4 value; // [rsp+B0h] [rbp-50h] BYREF
			  VolumetricRenderer_VolumetricCallbackContext v161; // [rsp+C0h] [rbp-40h] BYREF
			  VolumetricRenderer_VolumetricCallbackContext v162; // [rsp+110h] [rbp+10h] BYREF
			
			  sub_18033B9D0(&v161, 0LL, 72LL);
			  if ( IFix::WrappersManagerImpl::IsPatched(5215, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5215, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1507(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
			      return;
			    }
			    goto LABEL_82;
			  }
			  context = inputs->context;
			  if ( !context )
			    goto LABEL_82;
			  renderer = this->fields._.renderer;
			  cmd = context->fields.cmd;
			  if ( !renderer )
			    goto LABEL_82;
			  v14 = this->fields._.renderer;
			  m_RTIndex = renderer->fields.m_RTIndex;
			  m_ReconstructColors = v14->fields.m_ReconstructColors;
			  if ( !v14 )
			    goto LABEL_82;
			  m_VolumetricMat = (unsigned int *)v14->fields.m_VolumetricMat;
			  m_ReconstructDepths = v14->fields.m_ReconstructDepths;
			  propertyBlock[0] = v14->fields.m_PropertyBlock;
			  v18 = this->fields._.renderer;
			  *(_QWORD *)&value.x = m_VolumetricMat;
			  if ( !v18 )
			    goto LABEL_82;
			  m_VolumetricMat = (unsigned int *)v18->fields.m_FramingColor;
			  m_FramingDepth = v18->fields.m_FramingDepth;
			  v158 = (VolumetricPipelineRT *)m_VolumetricMat;
			  v159 = m_FramingDepth;
			  if ( !m_VolumetricMat )
			    goto LABEL_82;
			  colorRTa = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)m_VolumetricMat, 0LL);
			  if ( !m_FramingDepth )
			    goto LABEL_82;
			  RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FramingDepth, 0LL);
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			  HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			    cmd,
			    colorRTa,
			    RT,
			    RenderBufferLoadAction__Enum_DontCare,
			    RenderBufferStoreAction__Enum_Store,
			    0LL);
			  renderNodes = this->fields._.renderNodes;
			  if ( !renderNodes )
			    goto LABEL_82;
			  if ( renderNodes->fields._size < 1 )
			    goto LABEL_13;
			  Item = System::Collections::Generic::List<System::Object>::get_Item(
			           (List_1_System_Object_ *)this->fields._.renderNodes,
			           0,
			           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			  if ( !Item )
			    goto LABEL_82;
			  if ( HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
			         (VolumetricRenderer_VolumetricRenderNode *)Item,
			         0LL) )
			  {
			    BYTE1(enable) = 1;
			  }
			  else
			  {
			LABEL_13:
			    BYTE1(enable) = 0;
			    identity = UnityEngine::Quaternion::get_identity((Quaternion *)mat, v9);
			    if ( !cmd )
			      goto LABEL_82;
			    *(Quaternion *)mat = *identity;
			    UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(cmd, 0, 1, (Color *)mat, 0LL);
			  }
			  for ( i = 0; ; i = (_DWORD)colorRTa + 1 )
			  {
			    LODWORD(colorRTa) = i;
			    v25 = this->fields._.renderNodes;
			    if ( !v25 )
			      goto LABEL_82;
			    if ( i >= v25->fields._size )
			      break;
			    v26 = System::Collections::Generic::List<System::Object>::get_Item(
			            (List_1_System_Object_ *)this->fields._.renderNodes,
			            i,
			            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			    if ( !v26 )
			      goto LABEL_82;
			    material = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
			                 (VolumetricRenderer_VolumetricRenderNode *)v26,
			                 0LL);
			    m_VolumetricMat = (unsigned int *)this->fields._.renderer;
			    mat[0] = material;
			    if ( !m_VolumetricMat )
			      goto LABEL_82;
			    v28 = *((_BYTE *)m_VolumetricMat + 16);
			    m_VolumetricMat = (unsigned int *)inputs->volumetricParameters;
			    LOBYTE(enable) = v28;
			    if ( !m_VolumetricMat )
			      goto LABEL_82;
			    v29 = *((_QWORD *)m_VolumetricMat + 6);
			    if ( !v29 )
			      goto LABEL_82;
			    v30 = *(_DWORD *)(v29 + 40);
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			    HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(cmd, mat[0], enable, v30, 0LL);
			    m_VolumetricMat = (unsigned int *)this->fields._.renderNodes;
			    if ( !m_VolumetricMat )
			      goto LABEL_82;
			    mat[0] = (Material *)System::Collections::Generic::List<System::Object>::get_Item(
			                           (List_1_System_Object_ *)m_VolumetricMat,
			                           (int32_t)colorRTa,
			                           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			    sub_18033B9D0(&v161, 0LL, 72LL);
			    v161.Cmd = cmd;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v161,
			      v31,
			      v32,
			      v33,
			      backface,
			      v135,
			      enable,
			      v148,
			      *(float *)&v154.m_Type,
			      v154.m_InstanceID,
			      (bool)v154.m_BufferPointer,
			      v154.m_MipLevel,
			      *(MethodInfo **)&v154.m_DepthSlice);
			    if ( BYTE1(enablea) )
			      v35 = (_DWORD)colorRTa == 0;
			    else
			      v35 = 0;
			    v161.bFirstInPass = v35;
			    volumetricParameters = inputs->volumetricParameters;
			    if ( !volumetricParameters )
			      goto LABEL_31;
			    v161.bEnableDownScale = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			                              volumetricParameters->fields.enableDownRes,
			                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			    v39 = this->fields._.renderer;
			    if ( !v39 )
			      goto LABEL_31;
			    v161.bEnableFraming = v39->fields.m_EnableFraming;
			    v40 = this->fields._.renderer;
			    if ( !v40 )
			      goto LABEL_31;
			    v161.bEnableTAA = v40->fields.m_EnableTAA;
			    v161.Stage = this->fields._.stage;
			    v161.SrcColor = *colorRT;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v161.SrcColor,
			      v34,
			      v37,
			      v38,
			      backfacea,
			      v136,
			      enablea,
			      v149,
			      *(float *)&v154.m_Type,
			      v154.m_InstanceID,
			      (bool)v154.m_BufferPointer,
			      v154.m_MipLevel,
			      *(MethodInfo **)&v154.m_DepthSlice);
			    v161.SrcDepths = *depthsRT;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v161.SrcDepths,
			      v41,
			      v42,
			      (Int32__Array **)v161.SrcDepths,
			      backfaced,
			      v137,
			      enablec,
			      v150,
			      *(float *)&v154.m_Type,
			      v154.m_InstanceID,
			      (bool)v154.m_BufferPointer,
			      v154.m_MipLevel,
			      *(MethodInfo **)&v154.m_DepthSlice);
			    v161.DstColor = v158;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v161.DstColor,
			      v43,
			      v44,
			      v45,
			      backfacee,
			      v138,
			      enabled,
			      v151,
			      *(float *)&v154.m_Type,
			      v154.m_InstanceID,
			      (bool)v154.m_BufferPointer,
			      v154.m_MipLevel,
			      *(MethodInfo **)&v154.m_DepthSlice);
			    v161.DstDepths = v159;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v161.DstDepths,
			      v46,
			      v47,
			      v48,
			      backfacef,
			      v139,
			      enablee,
			      v152,
			      *(float *)&v154.m_Type,
			      v154.m_InstanceID,
			      (bool)v154.m_BufferPointer,
			      v154.m_MipLevel,
			      *(MethodInfo **)&v154.m_DepthSlice);
			    if ( !mat[0] )
			LABEL_31:
			      sub_1800D8260(volumetricParameters, v34);
			    v162 = v161;
			    HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
			      (VolumetricRenderer_VolumetricRenderNode *)mat[0],
			      &v162,
			      0LL);
			  }
			  m_VolumetricMat = (unsigned int *)inputs->volumetricParameters;
			  if ( !m_VolumetricMat )
			    goto LABEL_82;
			  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			         *((SettingParameter_1_System_Boolean_ **)m_VolumetricMat + 8),
			         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			  {
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			    m_VolumetricMat = (unsigned int *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			    v9 = (MethodInfo *)m_VolumetricMat[234];
			    if ( !cmd )
			      goto LABEL_82;
			    v49 = 1;
			  }
			  else
			  {
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			    m_VolumetricMat = (unsigned int *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			    v9 = (MethodInfo *)m_VolumetricMat[234];
			    if ( !cmd )
			      goto LABEL_82;
			    v49 = 0;
			  }
			  UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, (int32_t)v9, v49, 0LL);
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			  ReconstructComposeRatio = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructComposeRatio;
			  m_VolumetricMat = (unsigned int *)inputs->volumetricParameters;
			  if ( !m_VolumetricMat )
			LABEL_82:
			    sub_1800D8260(m_VolumetricMat, v9);
			  v51 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			          *((SettingParameter_1_System_Single_ **)m_VolumetricMat + 7),
			          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			  UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, ReconstructComposeRatio, v51, 0LL);
			  ReconstructCurrentColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructCurrentColor;
			  v53 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v158, 0LL);
			  v54 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v53, 0LL);
			  v55 = *(_OWORD *)&v54->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v54->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v54->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v55;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructCurrentColor, &v154, 0LL);
			  ReconstructCurrentDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_ReconstructCurrentDepth;
			  v57 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v159, 0LL);
			  v58 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v57, 0LL);
			  v59 = *(_OWORD *)&v58->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v58->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v58->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v59;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructCurrentDepth, &v154, 0LL);
			  static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  ReconstructHistoryColor = static_fields->_ReconstructHistoryColor;
			  if ( !m_ReconstructColors )
			    goto LABEL_80;
			  if ( (unsigned int)(1 - m_RTIndex) >= m_ReconstructColors->max_length.size )
			    sub_1800D2AB0(static_fields, v60);
			  static_fields = (VolumetricShaderIDs__StaticFields *)m_ReconstructColors->vector[1 - (int)m_RTIndex];
			  if ( !static_fields )
			LABEL_80:
			    sub_1800D8260(static_fields, v60);
			  v63 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)static_fields, 0LL);
			  v64 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v63, 0LL);
			  v65 = *(_OWORD *)&v64->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v64->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v64->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v65;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructHistoryColor, &v154, 0LL);
			  v67 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  ReconstructHistoryDepth = v67->_ReconstructHistoryDepth;
			  if ( !m_ReconstructDepths )
			    goto LABEL_79;
			  if ( (unsigned int)(1 - m_RTIndex) >= m_ReconstructDepths->max_length.size )
			    sub_1800D2AB0(v67, v66);
			  v67 = (VolumetricShaderIDs__StaticFields *)m_ReconstructDepths->vector[1 - (int)m_RTIndex];
			  if ( !v67 )
			LABEL_79:
			    sub_1800D8260(v67, v66);
			  v69 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)v67, 0LL);
			  v70 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v69, 0LL);
			  v71 = *(_OWORD *)&v70->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v70->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v70->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v71;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructHistoryDepth, &v154, 0LL);
			  v74 = this->fields._.renderer;
			  if ( !v74 )
			    goto LABEL_78;
			  LOBYTE(enable) = v74->fields.m_EnableFraming;
			  v75 = inputs->volumetricParameters;
			  if ( !v75 )
			    goto LABEL_78;
			  framingLevel = v75->fields.framingLevel;
			  if ( !framingLevel )
			    goto LABEL_78;
			  paramValue_k__BackingField = framingLevel->fields._paramValue_k__BackingField;
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			  v78 = *(Material **)&value.x;
			  HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
			    cmd,
			    *(Material **)&value.x,
			    enable,
			    paramValue_k__BackingField,
			    0LL);
			  if ( (unsigned int)m_RTIndex >= m_ReconstructColors->max_length.size )
			    goto LABEL_77;
			  v73 = m_ReconstructColors->vector[m_RTIndex];
			  if ( !v73 )
			    goto LABEL_78;
			  v80 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v73, 0LL);
			  if ( (unsigned int)m_RTIndex >= m_ReconstructDepths->max_length.size )
			LABEL_77:
			    sub_1800D2AB0(v79, v72);
			  v73 = m_ReconstructDepths->vector[m_RTIndex];
			  if ( !v73
			    || (v81 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v73, 0LL),
			        HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			          cmd,
			          v80,
			          v81,
			          RenderBufferLoadAction__Enum_DontCare,
			          RenderBufferStoreAction__Enum_Store,
			          0LL),
			        HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, v78, propertyBlock[0], 1, 0, 0LL),
			        v73 = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields,
			        (v83 = this->fields._.renderer) == 0LL) )
			  {
			LABEL_78:
			    sub_1800D8260(v73, v72);
			  }
			  v84 = *(MaterialPropertyBlock **)&v83->fields.PrevCameraPos.x;
			  z = v83->fields.PrevCameraPos.z;
			  propertyBlock[0] = v84;
			  *(float *)&propertyBlock[1] = z;
			  value = *UnityEngine::Vector4::op_Implicit(&value, (Vector3 *)propertyBlock, v82);
			  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v86, &value, 0LL);
			  v89 = this->fields._.renderer;
			  if ( !v89 )
			    sub_1800D8260(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields, v87);
			  v90 = *(MaterialPropertyBlock **)&v89->fields.PrevCameraForward.x;
			  v91 = v89->fields.PrevCameraForward.z;
			  propertyBlock[0] = v90;
			  *(float *)&propertyBlock[1] = v91;
			  *(Vector4 *)propertyBlock = *UnityEngine::Vector4::op_Implicit(&value, (Vector3 *)propertyBlock, v88);
			  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v92, (Vector4 *)propertyBlock, 0LL);
			  v94 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  ReconstructColor = v94->_ReconstructColor;
			  if ( (unsigned int)m_RTIndex >= m_ReconstructColors->max_length.size )
			    sub_1800D2AB0(v94, v93);
			  v96 = m_ReconstructColors->vector[m_RTIndex];
			  if ( !v96 )
			    sub_1800D8260(0LL, v93);
			  v97 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v96, 0LL);
			  v98 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v97, 0LL);
			  v99 = *(_OWORD *)&v98->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v98->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v98->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v99;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructColor, &v154, 0LL);
			  v101 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  ReconstructDepth = v101->_ReconstructDepth;
			  if ( (unsigned int)m_RTIndex >= m_ReconstructDepths->max_length.size )
			    sub_1800D2AB0(v101, v100);
			  v103 = m_ReconstructDepths->vector[m_RTIndex];
			  if ( !v103 )
			    sub_1800D8260(0LL, v100);
			  v104 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v103, 0LL);
			  v105 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v104, 0LL);
			  v106 = *(_OWORD *)&v105->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v105->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v105->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v106;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, ReconstructDepth, &v154, 0LL);
			  v108 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  VolumetricComposeColor = v108->_VolumetricComposeColor;
			  if ( (unsigned int)m_RTIndex >= m_ReconstructColors->max_length.size )
			    sub_1800D2AB0(v108, v107);
			  v110 = m_ReconstructColors->vector[m_RTIndex];
			  if ( !v110 )
			    sub_1800D8260(0LL, v107);
			  v111 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v110, 0LL);
			  v112 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v111, 0LL);
			  v113 = *(_OWORD *)&v112->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v112->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v112->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v113;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v154, 0LL);
			  v115 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  VolumetricComposeDepth = v115->_VolumetricComposeDepth;
			  if ( (unsigned int)m_RTIndex >= m_ReconstructDepths->max_length.size )
			    sub_1800D2AB0(v115, v114);
			  v117 = m_ReconstructDepths->vector[m_RTIndex];
			  if ( !v117 )
			    sub_1800D8260(0LL, v114);
			  v118 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v117, 0LL);
			  v119 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v162, v118, 0LL);
			  v120 = *(_OWORD *)&v119->m_BufferPointer;
			  *(_OWORD *)&v154.m_Type = *(_OWORD *)&v119->m_Type;
			  *(_QWORD *)&v154.m_DepthSlice = *(_QWORD *)&v119->m_DepthSlice;
			  *(_OWORD *)&v154.m_BufferPointer = v120;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v154, 0LL);
			  HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
			    cmd,
			    v78,
			    0,
			    EFramingQuality__Enum_Checkerboard,
			    0LL);
			  if ( (unsigned int)m_RTIndex >= m_ReconstructColors->max_length.size
			    || (*colorRT = m_ReconstructColors->vector[m_RTIndex],
			        sub_18002D1B0(
			          (VolumetricRenderer_VolumetricRenderItem *)colorRT,
			          v121,
			          v123,
			          v124,
			          backfaceb,
			          v140,
			          enable,
			          v148,
			          *(float *)&v154.m_Type,
			          v154.m_InstanceID,
			          (bool)v154.m_BufferPointer,
			          v154.m_MipLevel,
			          *(MethodInfo **)&v154.m_DepthSlice),
			        (unsigned int)m_RTIndex >= m_ReconstructDepths->max_length.size) )
			  {
			    sub_1800D2AB0(v122, v121);
			  }
			  *depthsRT = m_ReconstructDepths->vector[m_RTIndex];
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)depthsRT,
			    v121,
			    v125,
			    v126,
			    backfacec,
			    v141,
			    enableb,
			    v153,
			    *(float *)&v154.m_Type,
			    v154.m_InstanceID,
			    (bool)v154.m_BufferPointer,
			    v154.m_MipLevel,
			    *(MethodInfo **)&v154.m_DepthSlice);
			}
			
			public void __iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2) {} // 0x0000000189C51830-0x0000000189C51840
			// Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderInputs *P0,
			        VolumetricPipelineRT **P1,
			        VolumetricPipelineRT **P2,
			        MethodInfo *method)
			{
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    P0,
			    P1,
			    P2,
			    0LL);
			}
			
		}
	
		private class GeneralComposeStage : VolumetricRenderStage // TypeDefIndex: 38742
		{
			// Constructors
			public GeneralComposeStage() {} // Dummy constructor
			public GeneralComposeStage(VolumetricRenderer inRenderer, EVolumetricStage inStage) {} // 0x000000018451E550-0x000000018451E590
			// VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderer *inRenderer,
			        EVolumetricStage__Enum inStage,
			        MethodInfo *method)
			{
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
			  VolumetricRenderer_VolumetricBounds *v7; // r8
			  Int32__Array **v8; // r9
			  MethodInfo *v9; // [rsp+50h] [rbp+28h]
			  bool v10; // [rsp+58h] [rbp+30h]
			  int32_t v11; // [rsp+60h] [rbp+38h]
			  int32_t v12; // [rsp+68h] [rbp+40h]
			  float v13; // [rsp+70h] [rbp+48h]
			  int32_t v14; // [rsp+78h] [rbp+50h]
			  bool v15; // [rsp+80h] [rbp+58h]
			  bool v16; // [rsp+88h] [rbp+60h]
			  MethodInfo *v17; // [rsp+90h] [rbp+68h]
			
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    inStage,
			    0LL);
			  this->fields._.renderer = inRenderer;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)&this->fields._.renderer,
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
			    v16,
			    v17);
			}
			
	
			// Methods
			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT) {} // 0x0000000189C51840-0x0000000189C52124
			// Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::GeneralComposeStage::ProcessImpl(
			        VolumetricRenderer_GeneralComposeStage *this,
			        VolumetricRenderInputs *inputs,
			        VolumetricPipelineRT **colorRT,
			        VolumetricPipelineRT **depthsRT,
			        MethodInfo *method)
			{
			  MethodInfo *v9; // rdx
			  void *volumetricParameters; // rcx
			  VolumetricRenderer *renderer; // rax
			  HGRenderGraphContext *context; // r13
			  VolumetricRenderer *v13; // rsi
			  CommandBuffer *cmd; // r13
			  VolumetricPipelineRT *m_ComposeColor; // rsi
			  VolumetricPipelineRT *m_ComposeDepth; // r15
			  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodes; // rax
			  Object *Item; // rax
			  RenderTexture *RT; // r12
			  RenderTexture *v20; // rbx
			  VolumetricRenderer *v21; // rax
			  Texture *v22; // rax
			  __int128 v23; // xmm6
			  __int128 v24; // xmm7
			  __int64 v25; // xmm8_8
			  TextureHandle sceneDepth; // xmm6
			  RenderTargetIdentifier *v27; // rax
			  RenderTexture *v28; // r12
			  RenderTexture *v29; // rbx
			  RenderTexture *v30; // rdx
			  VolumetricRenderer *v31; // rax
			  Texture *v32; // rax
			  RenderTexture *v33; // r12
			  RenderTexture *v34; // rbx
			  VolumetricRenderer *v35; // rax
			  VolumetricRenderer *v36; // rax
			  Texture *v37; // rax
			  TextureHandle v38; // xmm6
			  RenderTargetIdentifier *v39; // rax
			  bool v40; // r12
			  Quaternion *identity; // rax
			  int32_t i; // r12d
			  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v43; // rax
			  List_1_System_Object_ *v44; // rcx
			  Object *v45; // rax
			  Material *v46; // rax
			  Object *v47; // rax
			  Material *v48; // rax
			  Shader *shader; // rbx
			  String *s_DisableDepthWrite; // r8
			  Object *v51; // rbx
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v52; // rdx
			  VolumetricRenderer_VolumetricBounds *v53; // r8
			  Int32__Array **v54; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v55; // rdx
			  bool v56; // cl
			  HGVolumetricCloudSettingParameters *v57; // rcx
			  VolumetricRenderer_VolumetricBounds *v58; // r8
			  Int32__Array **v59; // r9
			  VolumetricRenderer *v60; // rax
			  VolumetricRenderer *v61; // rax
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v62; // rdx
			  VolumetricRenderer_VolumetricBounds *v63; // r8
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v64; // rdx
			  VolumetricRenderer_VolumetricBounds *v65; // r8
			  Int32__Array **v66; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v67; // rdx
			  VolumetricRenderer_VolumetricBounds *v68; // r8
			  Int32__Array **v69; // r9
			  int32_t VolumetricComposeColor; // ebx
			  Texture *v71; // rax
			  RenderTargetIdentifier *v72; // rax
			  __int64 v73; // rdx
			  __int64 v74; // rcx
			  __int128 v75; // xmm1
			  int32_t VolumetricComposeDepth; // ebx
			  Texture *v77; // rax
			  RenderTargetIdentifier *v78; // rax
			  __int128 v79; // xmm1
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v80; // rdx
			  VolumetricRenderer_VolumetricBounds *v81; // r8
			  Int32__Array **v82; // r9
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v83; // rdx
			  VolumetricRenderer_VolumetricBounds *v84; // r8
			  Int32__Array **v85; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  VolumetricPipelineRT **P3; // [rsp+20h] [rbp-E0h]
			  VolumetricPipelineRT **P3a; // [rsp+20h] [rbp-E0h]
			  VolumetricPipelineRT **P3b; // [rsp+20h] [rbp-E0h]
			  VolumetricPipelineRT **P3c; // [rsp+20h] [rbp-E0h]
			  VolumetricPipelineRT **P3d; // [rsp+20h] [rbp-E0h]
			  VolumetricPipelineRT **P3e; // [rsp+20h] [rbp-E0h]
			  bool v93; // [rsp+28h] [rbp-D8h]
			  RenderBufferStoreAction__Enum v94; // [rsp+28h] [rbp-D8h]
			  bool v95; // [rsp+28h] [rbp-D8h]
			  bool v96; // [rsp+28h] [rbp-D8h]
			  bool v97; // [rsp+28h] [rbp-D8h]
			  bool v98; // [rsp+28h] [rbp-D8h]
			  bool v99; // [rsp+28h] [rbp-D8h]
			  int32_t v100; // [rsp+30h] [rbp-D0h]
			  int32_t v101; // [rsp+30h] [rbp-D0h]
			  int32_t v102; // [rsp+30h] [rbp-D0h]
			  int32_t v103; // [rsp+30h] [rbp-D0h]
			  int32_t v104; // [rsp+30h] [rbp-D0h]
			  int32_t v105; // [rsp+30h] [rbp-D0h]
			  int32_t v106; // [rsp+38h] [rbp-C8h]
			  int32_t v107; // [rsp+38h] [rbp-C8h]
			  int32_t v108; // [rsp+38h] [rbp-C8h]
			  int32_t v109; // [rsp+38h] [rbp-C8h]
			  int32_t v110; // [rsp+38h] [rbp-C8h]
			  int32_t v111; // [rsp+38h] [rbp-C8h]
			  float v112; // [rsp+40h] [rbp-C0h]
			  float v113; // [rsp+40h] [rbp-C0h]
			  float v114; // [rsp+40h] [rbp-C0h]
			  float v115; // [rsp+40h] [rbp-C0h]
			  float v116; // [rsp+40h] [rbp-C0h]
			  float v117; // [rsp+40h] [rbp-C0h]
			  int32_t v118; // [rsp+48h] [rbp-B8h]
			  int32_t v119; // [rsp+48h] [rbp-B8h]
			  int32_t v120; // [rsp+48h] [rbp-B8h]
			  int32_t v121; // [rsp+48h] [rbp-B8h]
			  int32_t v122; // [rsp+48h] [rbp-B8h]
			  int32_t v123; // [rsp+48h] [rbp-B8h]
			  RenderTargetIdentifier v124; // [rsp+50h] [rbp-B0h] BYREF
			  Material *material[2]; // [rsp+80h] [rbp-80h] BYREF
			  VolumetricRenderer_VolumetricCallbackContext v126; // [rsp+90h] [rbp-70h] BYREF
			  VolumetricRenderer_VolumetricCallbackContext v127; // [rsp+E0h] [rbp-20h] BYREF
			
			  memset(&v124, 0, sizeof(v124));
			  sub_18033B9D0(&v126, 0LL, 72LL);
			  if ( IFix::WrappersManagerImpl::IsPatched(5216, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5216, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1507(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
			      return;
			    }
			    goto LABEL_83;
			  }
			  if ( this->fields._.stage == 1 )
			  {
			    renderer = this->fields._.renderer;
			    if ( !renderer )
			      goto LABEL_83;
			    if ( renderer->fields.m_CanMergeTAAPass )
			      return;
			  }
			  context = inputs->context;
			  if ( !context
			    || (v13 = this->fields._.renderer, cmd = context->fields.cmd, !v13)
			    || (m_ComposeColor = v13->fields.m_ComposeColor,
			        m_ComposeDepth = this->fields._.renderer->fields.m_ComposeDepth,
			        (renderNodes = this->fields._.renderNodes) == 0LL) )
			  {
			LABEL_83:
			    sub_1800D8260(volumetricParameters, v9);
			  }
			  if ( renderNodes->fields._size >= 1 )
			  {
			    Item = System::Collections::Generic::List<System::Object>::get_Item(
			             (List_1_System_Object_ *)this->fields._.renderNodes,
			             0,
			             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			    if ( !Item )
			      goto LABEL_83;
			    LOBYTE(v112) = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
			                     (VolumetricRenderer_VolumetricRenderNode *)Item,
			                     0LL);
			  }
			  else
			  {
			    LOBYTE(v112) = 0;
			  }
			  if ( this->fields._.stage != 3 )
			  {
			    volumetricParameters = this->fields._.renderer;
			    if ( !volumetricParameters )
			      goto LABEL_83;
			    if ( !*((_BYTE *)volumetricParameters + 19) )
			    {
			LABEL_15:
			      if ( !m_ComposeColor )
			        goto LABEL_83;
			      RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
			      if ( !m_ComposeDepth )
			        goto LABEL_83;
			      v20 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
			      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			      HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			        cmd,
			        RT,
			        v20,
			        RenderBufferLoadAction__Enum_DontCare,
			        RenderBufferStoreAction__Enum_Store,
			        0LL);
			      goto LABEL_50;
			    }
			    volumetricParameters = inputs->volumetricParameters;
			    if ( !volumetricParameters )
			      goto LABEL_83;
			    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			           *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
			           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			    {
			      v21 = this->fields._.renderer;
			      if ( !v21 )
			        goto LABEL_83;
			      volumetricParameters = v21->fields.m_DepthForTest;
			      if ( !volumetricParameters )
			        goto LABEL_83;
			      v22 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			                         (VolumetricPipelineRT *)volumetricParameters,
			                         0LL);
			      memset(&v124, 0, sizeof(v124));
			      UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(&v124, v22, 0LL);
			      v23 = *(_OWORD *)&v124.m_Type;
			      v24 = *(_OWORD *)&v124.m_BufferPointer;
			      v25 = *(_QWORD *)&v124.m_DepthSlice;
			    }
			    else
			    {
			      sceneDepth = inputs->sceneDepth;
			      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			      *(TextureHandle *)material = sceneDepth;
			      v27 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v124, (TextureHandle *)material, 0LL);
			      v23 = *(_OWORD *)&v27->m_Type;
			      v24 = *(_OWORD *)&v27->m_BufferPointer;
			      v25 = *(_QWORD *)&v27->m_DepthSlice;
			    }
			    if ( !m_ComposeColor )
			      goto LABEL_83;
			    v28 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
			    if ( !m_ComposeDepth )
			      goto LABEL_83;
			    v29 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			    v30 = v28;
			    v94 = RenderBufferStoreAction__Enum_Store;
			LABEL_49:
			    *(_OWORD *)&v124.m_Type = v23;
			    *(_OWORD *)&v124.m_BufferPointer = v24;
			    *(_QWORD *)&v124.m_DepthSlice = v25;
			    HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetsWithDepth(
			      cmd,
			      v30,
			      v29,
			      &v124,
			      RenderBufferLoadAction__Enum_Load,
			      v94,
			      0LL);
			    goto LABEL_50;
			  }
			  volumetricParameters = inputs->volumetricParameters;
			  if ( !volumetricParameters )
			    goto LABEL_83;
			  if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			          *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
			          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			    goto LABEL_37;
			  volumetricParameters = inputs->volumetricParameters;
			  if ( !volumetricParameters )
			    goto LABEL_83;
			  if ( HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			         *((SettingParameter_1_System_Int32Enum_ **)volumetricParameters + 4),
			         MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::op_Implicit) )
			  {
			LABEL_37:
			    v35 = this->fields._.renderer;
			    if ( !v35 )
			      goto LABEL_83;
			    if ( !v35->fields.m_AfterTAANeedDepthTest )
			      goto LABEL_15;
			    volumetricParameters = inputs->volumetricParameters;
			    if ( !volumetricParameters )
			      goto LABEL_83;
			    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			           *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
			           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			    {
			      v36 = this->fields._.renderer;
			      if ( !v36 )
			        goto LABEL_83;
			      volumetricParameters = v36->fields.m_DepthForTest;
			      if ( !volumetricParameters )
			        goto LABEL_83;
			      v37 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			                         (VolumetricPipelineRT *)volumetricParameters,
			                         0LL);
			      memset(&v124, 0, sizeof(v124));
			      UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(&v124, v37, 0LL);
			      v23 = *(_OWORD *)&v124.m_Type;
			      v24 = *(_OWORD *)&v124.m_BufferPointer;
			      v25 = *(_QWORD *)&v124.m_DepthSlice;
			    }
			    else
			    {
			      v38 = inputs->sceneDepth;
			      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			      *(TextureHandle *)material = v38;
			      v39 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v124, (TextureHandle *)material, 0LL);
			      v23 = *(_OWORD *)&v39->m_Type;
			      v24 = *(_OWORD *)&v39->m_BufferPointer;
			      v25 = *(_QWORD *)&v39->m_DepthSlice;
			    }
			    volumetricParameters = inputs->volumetricParameters;
			    if ( !volumetricParameters )
			      goto LABEL_83;
			    v40 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			            *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
			            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			    if ( !m_ComposeColor )
			      goto LABEL_83;
			    material[0] = (Material *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
			    if ( !m_ComposeDepth )
			      goto LABEL_83;
			    v29 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			    v30 = (RenderTexture *)material[0];
			    v94 = v40 ? RenderBufferStoreAction__Enum_DontCare : RenderBufferStoreAction__Enum_Store;
			    goto LABEL_49;
			  }
			  v31 = this->fields._.renderer;
			  if ( !v31 )
			    goto LABEL_83;
			  if ( !v31->fields.m_AfterTAANeedDepthTest )
			    goto LABEL_15;
			  volumetricParameters = v31->fields.m_DepthForTest;
			  if ( !volumetricParameters )
			    goto LABEL_83;
			  v32 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			                     (VolumetricPipelineRT *)volumetricParameters,
			                     0LL);
			  UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(&v124, v32, 0LL);
			  if ( !m_ComposeColor )
			    goto LABEL_83;
			  v33 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
			  if ( !m_ComposeDepth )
			    goto LABEL_83;
			  v34 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			  *(_OWORD *)&v127.Cmd = *(_OWORD *)&v124.m_Type;
			  v127.DstColor = *(VolumetricPipelineRT **)&v124.m_DepthSlice;
			  *(_OWORD *)&v127.SrcColor = *(_OWORD *)&v124.m_BufferPointer;
			  HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetsWithDepth(
			    cmd,
			    v33,
			    v34,
			    (RenderTargetIdentifier *)&v127,
			    RenderBufferLoadAction__Enum_Load,
			    RenderBufferStoreAction__Enum_DontCare,
			    0LL);
			LABEL_50:
			  if ( LOBYTE(v112) )
			    goto LABEL_53;
			  identity = UnityEngine::Quaternion::get_identity((Quaternion *)material, v9);
			  if ( !cmd )
			    goto LABEL_83;
			  *(Quaternion *)material = *identity;
			  UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(cmd, 0, 1, (Color *)material, 0LL);
			LABEL_53:
			  for ( i = 0; ; ++i )
			  {
			    v43 = this->fields._.renderNodes;
			    if ( !v43 )
			      goto LABEL_83;
			    if ( i >= v43->fields._size )
			      break;
			    if ( this->fields._.stage == 3 )
			    {
			      volumetricParameters = inputs->volumetricParameters;
			      if ( !volumetricParameters )
			        goto LABEL_83;
			      if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			              *((SettingParameter_1_System_Boolean_ **)volumetricParameters + 2),
			              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			        goto LABEL_61;
			      volumetricParameters = inputs->volumetricParameters;
			      if ( !volumetricParameters )
			        goto LABEL_83;
			      if ( HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			             *((SettingParameter_1_System_Int32Enum_ **)volumetricParameters + 4),
			             MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EDownResFilter>::op_Implicit) )
			      {
			LABEL_61:
			        v44 = (List_1_System_Object_ *)this->fields._.renderNodes;
			        if ( !v44 )
			          goto LABEL_77;
			        v45 = System::Collections::Generic::List<System::Object>::get_Item(
			                v44,
			                i,
			                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			        if ( !v45 )
			          goto LABEL_77;
			        v46 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
			                (VolumetricRenderer_VolumetricRenderNode *)v45,
			                0LL);
			        v44 = (List_1_System_Object_ *)this->fields._.renderNodes;
			        material[0] = v46;
			        if ( !v44 )
			          goto LABEL_77;
			        v47 = System::Collections::Generic::List<System::Object>::get_Item(
			                v44,
			                i,
			                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			        if ( !v47 )
			          goto LABEL_77;
			        v48 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
			                (VolumetricRenderer_VolumetricRenderNode *)v47,
			                0LL);
			        if ( !v48
			          || (shader = UnityEngine::Material::get_shader(v48, 0LL),
			              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
			              s_DisableDepthWrite = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DisableDepthWrite,
			              memset(&v127, 0, 24),
			              UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			                (LocalKeyword *)&v127,
			                shader,
			                s_DisableDepthWrite,
			                0LL),
			              v124.m_BufferPointer = v127.SrcColor,
			              *(_OWORD *)&v124.m_Type = *(_OWORD *)&v127.Cmd,
			              !cmd) )
			        {
			LABEL_77:
			          sub_1800D8260(v44, v9);
			        }
			        UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, material[0], (LocalKeyword *)&v124, 0LL);
			      }
			    }
			    volumetricParameters = this->fields._.renderNodes;
			    if ( !volumetricParameters )
			      goto LABEL_83;
			    v51 = System::Collections::Generic::List<System::Object>::get_Item(
			            (List_1_System_Object_ *)volumetricParameters,
			            i,
			            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			    sub_18033B9D0(&v126, 0LL, 72LL);
			    v126.Cmd = cmd;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v126,
			      v52,
			      v53,
			      v54,
			      (MethodInfo *)P3,
			      v93,
			      v100,
			      v106,
			      v112,
			      v118,
			      v124.m_Type,
			      v124.m_InstanceID,
			      (MethodInfo *)v124.m_BufferPointer);
			    if ( LOBYTE(v113) )
			      v56 = i == 0;
			    else
			      v56 = 0;
			    v126.bFirstInPass = v56;
			    v57 = inputs->volumetricParameters;
			    if ( !v57 )
			      goto LABEL_78;
			    v126.bEnableDownScale = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			                              v57->fields.enableDownRes,
			                              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			    v60 = this->fields._.renderer;
			    if ( !v60 )
			      goto LABEL_78;
			    v126.bEnableFraming = v60->fields.m_EnableFraming;
			    v61 = this->fields._.renderer;
			    if ( !v61 )
			      goto LABEL_78;
			    v126.bEnableTAA = v61->fields.m_EnableTAA;
			    v126.Stage = this->fields._.stage;
			    v126.SrcColor = *colorRT;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v126.SrcColor,
			      v55,
			      v58,
			      v59,
			      (MethodInfo *)P3a,
			      v95,
			      v101,
			      v107,
			      v113,
			      v119,
			      v124.m_Type,
			      v124.m_InstanceID,
			      (MethodInfo *)v124.m_BufferPointer);
			    v126.SrcDepths = *depthsRT;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v126.SrcDepths,
			      v62,
			      v63,
			      (Int32__Array **)v126.SrcDepths,
			      (MethodInfo *)P3b,
			      v96,
			      v102,
			      v108,
			      v114,
			      v120,
			      v124.m_Type,
			      v124.m_InstanceID,
			      (MethodInfo *)v124.m_BufferPointer);
			    v126.DstColor = m_ComposeColor;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v126.DstColor,
			      v64,
			      v65,
			      v66,
			      (MethodInfo *)P3c,
			      v97,
			      v103,
			      v109,
			      v115,
			      v121,
			      v124.m_Type,
			      v124.m_InstanceID,
			      (MethodInfo *)v124.m_BufferPointer);
			    v126.DstDepths = m_ComposeDepth;
			    sub_18002D1B0(
			      (VolumetricRenderer_VolumetricRenderItem *)&v126.DstDepths,
			      v67,
			      v68,
			      v69,
			      (MethodInfo *)P3d,
			      v98,
			      v104,
			      v110,
			      v116,
			      v122,
			      v124.m_Type,
			      v124.m_InstanceID,
			      (MethodInfo *)v124.m_BufferPointer);
			    if ( !v51 )
			LABEL_78:
			      sub_1800D8260(v57, v55);
			    v127 = v126;
			    HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
			      (VolumetricRenderer_VolumetricRenderNode *)v51,
			      &v127,
			      0LL);
			  }
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			  VolumetricComposeColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeColor;
			  v71 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeColor, 0LL);
			  v72 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v127, v71, 0LL);
			  if ( !cmd )
			    sub_1800D8260(v74, v73);
			  v75 = *(_OWORD *)&v72->m_BufferPointer;
			  *(_OWORD *)&v124.m_Type = *(_OWORD *)&v72->m_Type;
			  *(_QWORD *)&v124.m_DepthSlice = *(_QWORD *)&v72->m_DepthSlice;
			  *(_OWORD *)&v124.m_BufferPointer = v75;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v124, 0LL);
			  VolumetricComposeDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeDepth;
			  v77 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_ComposeDepth, 0LL);
			  v78 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v127, v77, 0LL);
			  v79 = *(_OWORD *)&v78->m_BufferPointer;
			  *(_OWORD *)&v124.m_Type = *(_OWORD *)&v78->m_Type;
			  *(_QWORD *)&v124.m_DepthSlice = *(_QWORD *)&v78->m_DepthSlice;
			  *(_OWORD *)&v124.m_BufferPointer = v79;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v124, 0LL);
			  *colorRT = m_ComposeColor;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)colorRT,
			    v80,
			    v81,
			    v82,
			    (MethodInfo *)P3,
			    v93,
			    v100,
			    v106,
			    v112,
			    v118,
			    v124.m_Type,
			    v124.m_InstanceID,
			    (MethodInfo *)v124.m_BufferPointer);
			  *depthsRT = m_ComposeDepth;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)depthsRT,
			    v83,
			    v84,
			    v85,
			    (MethodInfo *)P3e,
			    v99,
			    v105,
			    v111,
			    v117,
			    v123,
			    v124.m_Type,
			    v124.m_InstanceID,
			    (MethodInfo *)v124.m_BufferPointer);
			}
			
			public void __iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2) {} // 0x0000000189C51830-0x0000000189C51840
			// Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderInputs *P0,
			        VolumetricPipelineRT **P1,
			        VolumetricPipelineRT **P2,
			        MethodInfo *method)
			{
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    P0,
			    P1,
			    P2,
			    0LL);
			}
			
		}
	
		private class TemporalStage : VolumetricRenderStage // TypeDefIndex: 38743
		{
			// Constructors
			public TemporalStage() {} // Dummy constructor
			public TemporalStage(VolumetricRenderer inRenderer, EVolumetricStage inStage) {} // 0x000000018451E550-0x000000018451E590
			// VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderer *inRenderer,
			        EVolumetricStage__Enum inStage,
			        MethodInfo *method)
			{
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
			  VolumetricRenderer_VolumetricBounds *v7; // r8
			  Int32__Array **v8; // r9
			  MethodInfo *v9; // [rsp+50h] [rbp+28h]
			  bool v10; // [rsp+58h] [rbp+30h]
			  int32_t v11; // [rsp+60h] [rbp+38h]
			  int32_t v12; // [rsp+68h] [rbp+40h]
			  float v13; // [rsp+70h] [rbp+48h]
			  int32_t v14; // [rsp+78h] [rbp+50h]
			  bool v15; // [rsp+80h] [rbp+58h]
			  bool v16; // [rsp+88h] [rbp+60h]
			  MethodInfo *v17; // [rsp+90h] [rbp+68h]
			
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    inStage,
			    0LL);
			  this->fields._.renderer = inRenderer;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)&this->fields._.renderer,
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
			    v16,
			    v17);
			}
			
	
			// Methods
			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT) {} // 0x0000000189C523D4-0x0000000189C52CD8
			// Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::TemporalStage::ProcessImpl(
			        VolumetricRenderer_TemporalStage *this,
			        VolumetricRenderInputs *inputs,
			        VolumetricPipelineRT **colorRT,
			        VolumetricPipelineRT **depthsRT,
			        MethodInfo *method)
			{
			  __int64 v9; // rdx
			  SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
			  HGRenderGraphContext *context; // r14
			  VolumetricRenderer *renderer; // rdi
			  CommandBuffer *cmd; // r14
			  VolumetricRenderer *v14; // rax
			  __int64 m_RTIndex; // rdi
			  VolumetricPipelineRT__Array *m_TAAColors; // r12
			  VolumetricPipelineRT__Array *m_TAADepths; // r15
			  VolumetricRenderer *v18; // rax
			  int32_t v19; // r8d
			  int32_t v20; // ebx
			  Texture *RT; // rax
			  RenderTargetIdentifier *v22; // rax
			  __int128 v23; // xmm1
			  __int64 v24; // rdx
			  VolumetricPipelineRT *static_fields; // rcx
			  int32_t graphicsFormat; // ebx
			  Texture *v27; // rax
			  RenderTargetIdentifier *v28; // rax
			  __int128 v29; // xmm1
			  __int64 v30; // rcx
			  HGVolumetricCloudSettingParameters *v31; // rcx
			  RenderTexture *v32; // rbx
			  int32_t TAAInvalidDepthBlendRatio; // ebx
			  float v34; // xmm0_4
			  VolumetricRenderer *v35; // rax
			  VolumetricRenderer_VolumetricRenderItem *v36; // rbx
			  int32_t TAACurrentColor; // r13d
			  Texture *v38; // rax
			  RenderTargetIdentifier *v39; // rax
			  __int128 v40; // xmm1
			  __int64 v41; // rdx
			  VolumetricRenderer_VolumetricRenderItem *v42; // r13
			  Texture *v43; // rax
			  RenderTargetIdentifier *v44; // rax
			  __int128 v45; // xmm1
			  Object *Item; // rax
			  List_1_System_Object_ *RenderNodes; // rax
			  Object *v48; // rax
			  VolumetricRenderer_VolumetricRenderNode *v49; // rbx
			  Material *material; // rax
			  bool v51; // al
			  bool v52; // bl
			  MethodInfo *v53; // rdx
			  char v54; // bl
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v55; // rdx
			  SettingParameter_1_System_Boolean_ **v56; // rcx
			  float FloatImpl; // xmm0_4
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v58; // rdx
			  VolumetricRenderer_VolumetricBounds *v59; // r8
			  Int32__Array **v60; // r9
			  VolumetricRenderer_VolumetricBounds *v61; // r8
			  Int32__Array **v62; // r9
			  VolumetricRenderer *v63; // rax
			  VolumetricRenderer *v64; // rax
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v65; // rdx
			  VolumetricRenderer_VolumetricBounds *v66; // r8
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v67; // rdx
			  __int64 v68; // rcx
			  VolumetricRenderer_VolumetricBounds *v69; // r8
			  Int32__Array **v70; // r9
			  VolumetricRenderer_VolumetricBounds *v71; // r8
			  Int32__Array **v72; // r9
			  MethodInfo *v73; // r8
			  VolumetricRenderer *v74; // rax
			  __int64 v75; // xmm0_8
			  float z; // eax
			  int32_t v77; // r10d
			  __int64 v78; // rdx
			  MethodInfo *v79; // r8
			  VolumetricRenderer *v80; // rax
			  __int64 v81; // xmm0_8
			  float v82; // eax
			  int32_t v83; // r10d
			  __int64 v84; // rdx
			  VolumetricShaderIDs__StaticFields *v85; // rcx
			  int32_t VolumetricComposeColor; // esi
			  VolumetricPipelineRT *v87; // rcx
			  Texture *v88; // rax
			  RenderTargetIdentifier *v89; // rax
			  __int128 v90; // xmm1
			  __int64 v91; // rdx
			  VolumetricShaderIDs__StaticFields *v92; // rcx
			  int32_t VolumetricComposeDepth; // esi
			  VolumetricPipelineRT *v94; // rcx
			  Texture *v95; // rax
			  RenderTargetIdentifier *v96; // rax
			  __int128 v97; // xmm1
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v98; // rdx
			  __int64 v99; // rcx
			  VolumetricRenderer_VolumetricBounds *v100; // r8
			  Int32__Array **v101; // r9
			  VolumetricRenderer_VolumetricBounds *v102; // r8
			  Int32__Array **v103; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *backface; // [rsp+28h] [rbp-E0h]
			  MethodInfo *backfacea; // [rsp+28h] [rbp-E0h]
			  MethodInfo *backfaceb; // [rsp+28h] [rbp-E0h]
			  MethodInfo *backfacef; // [rsp+28h] [rbp-E0h]
			  MethodInfo *backfacec; // [rsp+28h] [rbp-E0h]
			  MethodInfo *backfaced; // [rsp+28h] [rbp-E0h]
			  MethodInfo *backfacee; // [rsp+28h] [rbp-E0h]
			  bool v112; // [rsp+30h] [rbp-D8h]
			  bool v113; // [rsp+30h] [rbp-D8h]
			  bool v114; // [rsp+30h] [rbp-D8h]
			  bool v115; // [rsp+30h] [rbp-D8h]
			  bool v116; // [rsp+30h] [rbp-D8h]
			  bool v117; // [rsp+30h] [rbp-D8h]
			  bool v118; // [rsp+30h] [rbp-D8h]
			  int32_t enableMV; // [rsp+38h] [rbp-D0h]
			  int32_t enableMVa; // [rsp+38h] [rbp-D0h]
			  int32_t enableMVe; // [rsp+38h] [rbp-D0h]
			  int32_t enableMVb; // [rsp+38h] [rbp-D0h]
			  int32_t enableMVc; // [rsp+38h] [rbp-D0h]
			  int32_t enableMVd; // [rsp+38h] [rbp-D0h]
			  RenderTexture *colorRTa; // [rsp+40h] [rbp-C8h]
			  Vector4 colorRT_8; // [rsp+48h] [rbp-C0h] BYREF
			  Vector4 value_8; // [rsp+58h] [rbp-B0h] BYREF
			  RenderTargetIdentifier v128; // [rsp+68h] [rbp-A0h] BYREF
			  Material *mat; // [rsp+98h] [rbp-70h]
			  VolumetricRenderer_VolumetricCallbackContext v130; // [rsp+A8h] [rbp-60h] BYREF
			  VolumetricRenderer_VolumetricCallbackContext v131; // [rsp+F8h] [rbp-10h] BYREF
			
			  sub_18033B9D0(&v130, 0LL, 72LL);
			  if ( IFix::WrappersManagerImpl::IsPatched(5218, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5218, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1507(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
			      return;
			    }
			    goto LABEL_67;
			  }
			  context = inputs->context;
			  if ( !context )
			    goto LABEL_67;
			  renderer = this->fields._.renderer;
			  cmd = context->fields.cmd;
			  if ( !renderer )
			    goto LABEL_67;
			  v14 = this->fields._.renderer;
			  m_RTIndex = renderer->fields.m_RTIndex;
			  m_TAAColors = v14->fields.m_TAAColors;
			  if ( !v14 )
			    goto LABEL_67;
			  m_TAADepths = v14->fields.m_TAADepths;
			  mat = v14->fields.m_VolumetricMat;
			  v18 = this->fields._.renderer;
			  if ( !v18 )
			    goto LABEL_67;
			  volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs->volumetricParameters;
			  *(_QWORD *)&colorRT_8.x = v18->fields.m_PropertyBlock;
			  if ( !volumetricParameters )
			    goto LABEL_67;
			  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			         volumetricParameters[14],
			         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			  {
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			    volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			    v9 = *((unsigned int *)volumetricParameters + 241);
			    if ( !cmd )
			      goto LABEL_67;
			    v19 = 1;
			  }
			  else
			  {
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			    volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			    v9 = *((unsigned int *)volumetricParameters + 241);
			    if ( !cmd )
			      goto LABEL_67;
			    v19 = 0;
			  }
			  UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, v9, v19, 0LL);
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			  volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  v20 = *((_DWORD *)volumetricParameters + 244);
			  if ( !m_TAAColors )
			    goto LABEL_67;
			  if ( (unsigned int)(1 - m_RTIndex) >= m_TAAColors->max_length.size )
			    sub_1800D2AB0(volumetricParameters, v9);
			  volumetricParameters = (SettingParameter_1_System_Boolean_ **)m_TAAColors->vector[1 - (int)m_RTIndex];
			  if ( !volumetricParameters )
			LABEL_67:
			    sub_1800D8260(volumetricParameters, v9);
			  RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			                    (VolumetricPipelineRT *)volumetricParameters,
			                    0LL);
			  v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v131, RT, 0LL);
			  v23 = *(_OWORD *)&v22->m_BufferPointer;
			  *(_OWORD *)&v128.m_Type = *(_OWORD *)&v22->m_Type;
			  *(_QWORD *)&v128.m_DepthSlice = *(_QWORD *)&v22->m_DepthSlice;
			  *(_OWORD *)&v128.m_BufferPointer = v23;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v20, &v128, 0LL);
			  static_fields = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  graphicsFormat = static_fields[9].fields.Desc._graphicsFormat;
			  if ( !m_TAADepths )
			    goto LABEL_65;
			  if ( (unsigned int)(1 - m_RTIndex) >= m_TAADepths->max_length.size )
			    sub_1800D2AB0(static_fields, v24);
			  static_fields = m_TAADepths->vector[1 - (int)m_RTIndex];
			  if ( !static_fields )
			LABEL_65:
			    sub_1800D8260(static_fields, v24);
			  v27 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(static_fields, 0LL);
			  v28 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v131, v27, 0LL);
			  v29 = *(_OWORD *)&v28->m_BufferPointer;
			  *(_OWORD *)&v128.m_Type = *(_OWORD *)&v28->m_Type;
			  *(_QWORD *)&v128.m_DepthSlice = *(_QWORD *)&v28->m_DepthSlice;
			  *(_OWORD *)&v128.m_BufferPointer = v29;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, graphicsFormat, &v128, 0LL);
			  if ( (unsigned int)m_RTIndex >= m_TAAColors->max_length.size )
			    goto LABEL_64;
			  v31 = (HGVolumetricCloudSettingParameters *)m_TAAColors->vector[m_RTIndex];
			  if ( !v31 )
			    goto LABEL_63;
			  colorRTa = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)v31, 0LL);
			  if ( (unsigned int)m_RTIndex >= m_TAADepths->max_length.size )
			LABEL_64:
			    sub_1800D2AB0(v30, v9);
			  v31 = (HGVolumetricCloudSettingParameters *)m_TAADepths->vector[m_RTIndex];
			  if ( !v31 )
			    goto LABEL_63;
			  v32 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)v31, 0LL);
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			  HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
			    cmd,
			    colorRTa,
			    v32,
			    RenderBufferLoadAction__Enum_DontCare,
			    RenderBufferStoreAction__Enum_Store,
			    0LL);
			  TAAInvalidDepthBlendRatio = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAAInvalidDepthBlendRatio;
			  v31 = inputs->volumetricParameters;
			  if ( !v31
			    || (v34 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			                v31->fields.invalidDepthBlendRatio,
			                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit),
			        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, TAAInvalidDepthBlendRatio, v34, 0LL),
			        (v35 = this->fields._.renderer) == 0LL) )
			  {
			LABEL_63:
			    sub_1800D8260(v31, v9);
			  }
			  if ( v35->fields.m_CanMergeTAAPass )
			  {
			    volumetricParameters = (SettingParameter_1_System_Boolean_ **)v35->fields.m_RenderStages;
			    if ( volumetricParameters )
			    {
			      Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			               (Dictionary_2_System_Int32Enum_System_Object_ *)volumetricParameters,
			               (Int32Enum__Enum)1u,
			               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
			      if ( Item )
			      {
			        RenderNodes = (List_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
			                                                 (VolumetricRenderer_VolumetricRenderStage *)Item,
			                                                 0LL);
			        if ( RenderNodes )
			        {
			          v48 = System::Collections::Generic::List<System::Object>::get_Item(
			                  RenderNodes,
			                  0,
			                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
			          *(_QWORD *)&value_8.x = v48;
			          v49 = (VolumetricRenderer_VolumetricRenderNode *)v48;
			          if ( v48 )
			          {
			            BYTE1(enableMV) = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bFullScreen(
			                                (VolumetricRenderer_VolumetricRenderNode *)v48,
			                                0LL);
			            material = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(v49, 0LL);
			            volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs->volumetricParameters;
			            *(_QWORD *)&colorRT_8.x = material;
			            if ( volumetricParameters )
			            {
			              v51 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			                      volumetricParameters[15],
			                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			              volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs->volumetricParameters;
			              LOBYTE(enableMV) = v51;
			              if ( volumetricParameters )
			              {
			                v52 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			                        volumetricParameters[16],
			                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			                HG::Rendering::Runtime::VolumetricSDFUtils::UpdateTemporalKeywords(
			                  cmd,
			                  *(Material **)&colorRT_8.x,
			                  enableMV,
			                  v52,
			                  0LL);
			                v54 = BYTE1(enableMV);
			                if ( !BYTE1(enableMV) )
			                {
			                  colorRT_8 = (Vector4)*UnityEngine::Quaternion::get_identity((Quaternion *)&colorRT_8, v53);
			                  UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(cmd, 0, 1, (Color *)&colorRT_8, 0LL);
			                }
			                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			                LODWORD(colorRTa) = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAABlendRatio;
			                v56 = (SettingParameter_1_System_Boolean_ **)mat;
			                if ( !mat )
			                  goto LABEL_62;
			                FloatImpl = UnityEngine::Material::GetFloatImpl(
			                              mat,
			                              TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAABlendRatio,
			                              0LL);
			                UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, (int32_t)colorRTa, FloatImpl, 0LL);
			                v130.Cmd = cmd;
			                sub_18002D1B0(
			                  (VolumetricRenderer_VolumetricRenderItem *)&v130,
			                  v58,
			                  v59,
			                  v60,
			                  backfacea,
			                  v112,
			                  enableMV,
			                  (int32_t)colorRTa,
			                  colorRT_8.x,
			                  SLODWORD(colorRT_8.z),
			                  SLOBYTE(value_8.x),
			                  SLOBYTE(value_8.z),
			                  *(MethodInfo **)&v128.m_Type);
			                v56 = (SettingParameter_1_System_Boolean_ **)inputs->volumetricParameters;
			                v130.bFirstInPass = v54;
			                if ( !v56
			                  || (v130.bEnableDownScale = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			                                                v56[2],
			                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit),
			                      (v63 = this->fields._.renderer) == 0LL)
			                  || (v130.bEnableFraming = v63->fields.m_EnableFraming, (v64 = this->fields._.renderer) == 0LL) )
			                {
			LABEL_62:
			                  sub_1800D8260(v56, v55);
			                }
			                v36 = (VolumetricRenderer_VolumetricRenderItem *)colorRT;
			                v130.bEnableTAA = v64->fields.m_EnableTAA;
			                v130.Stage = this->fields._.stage;
			                v130.SrcColor = *colorRT;
			                sub_18002D1B0(
			                  (VolumetricRenderer_VolumetricRenderItem *)&v130.SrcColor,
			                  v55,
			                  v61,
			                  v62,
			                  backfaceb,
			                  v114,
			                  enableMVa,
			                  (int32_t)colorRTa,
			                  colorRT_8.x,
			                  SLODWORD(colorRT_8.z),
			                  SLOBYTE(value_8.x),
			                  SLOBYTE(value_8.z),
			                  *(MethodInfo **)&v128.m_Type);
			                v42 = (VolumetricRenderer_VolumetricRenderItem *)depthsRT;
			                v130.SrcDepths = *depthsRT;
			                sub_18002D1B0(
			                  (VolumetricRenderer_VolumetricRenderItem *)&v130.SrcDepths,
			                  v65,
			                  v66,
			                  (Int32__Array **)v130.SrcDepths,
			                  backfacef,
			                  v115,
			                  enableMVe,
			                  (int32_t)colorRTa,
			                  colorRT_8.x,
			                  SLODWORD(colorRT_8.z),
			                  SLOBYTE(value_8.x),
			                  SLOBYTE(value_8.z),
			                  *(MethodInfo **)&v128.m_Type);
			                if ( (unsigned int)m_RTIndex >= m_TAAColors->max_length.size
			                  || (v130.DstColor = m_TAAColors->vector[m_RTIndex],
			                      sub_18002D1B0(
			                        (VolumetricRenderer_VolumetricRenderItem *)&v130.DstColor,
			                        v67,
			                        v69,
			                        v70,
			                        backfacec,
			                        v116,
			                        enableMVb,
			                        (int32_t)colorRTa,
			                        colorRT_8.x,
			                        SLODWORD(colorRT_8.z),
			                        SLOBYTE(value_8.x),
			                        SLOBYTE(value_8.z),
			                        *(MethodInfo **)&v128.m_Type),
			                      (unsigned int)m_RTIndex >= m_TAADepths->max_length.size) )
			                {
			                  sub_1800D2AB0(v68, v67);
			                }
			                v130.DstDepths = m_TAADepths->vector[m_RTIndex];
			                sub_18002D1B0(
			                  (VolumetricRenderer_VolumetricRenderItem *)&v130.DstDepths,
			                  v67,
			                  v71,
			                  v72,
			                  backfaced,
			                  v117,
			                  enableMVc,
			                  (int32_t)colorRTa,
			                  colorRT_8.x,
			                  SLODWORD(colorRT_8.z),
			                  SLOBYTE(value_8.x),
			                  SLOBYTE(value_8.z),
			                  *(MethodInfo **)&v128.m_Type);
			                v131 = v130;
			                HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Process(
			                  *(VolumetricRenderer_VolumetricRenderNode **)&value_8.x,
			                  &v131,
			                  0LL);
			                goto LABEL_46;
			              }
			            }
			          }
			        }
			      }
			    }
			    goto LABEL_67;
			  }
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			  v36 = (VolumetricRenderer_VolumetricRenderItem *)colorRT;
			  TAACurrentColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAACurrentColor;
			  volumetricParameters = (SettingParameter_1_System_Boolean_ **)*colorRT;
			  if ( !*colorRT )
			    goto LABEL_67;
			  v38 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			                     (VolumetricPipelineRT *)volumetricParameters,
			                     0LL);
			  v39 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v131, v38, 0LL);
			  v40 = *(_OWORD *)&v39->m_BufferPointer;
			  *(_OWORD *)&v128.m_Type = *(_OWORD *)&v39->m_Type;
			  *(_QWORD *)&v128.m_DepthSlice = *(_QWORD *)&v39->m_DepthSlice;
			  *(_OWORD *)&v128.m_BufferPointer = v40;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, TAACurrentColor, &v128, 0LL);
			  v42 = (VolumetricRenderer_VolumetricRenderItem *)depthsRT;
			  LODWORD(colorRTa) = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_TAACurrentDepth;
			  if ( !*depthsRT )
			    sub_1800D8260(0LL, v41);
			  v43 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(*depthsRT, 0LL);
			  v44 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v131, v43, 0LL);
			  v45 = *(_OWORD *)&v44->m_BufferPointer;
			  *(_OWORD *)&v128.m_Type = *(_OWORD *)&v44->m_Type;
			  *(_QWORD *)&v128.m_DepthSlice = *(_QWORD *)&v44->m_DepthSlice;
			  *(_OWORD *)&v128.m_BufferPointer = v45;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, (int32_t)colorRTa, &v128, 0LL);
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			  HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, mat, *(MaterialPropertyBlock **)&colorRT_8.x, 2, 0, 0LL);
			LABEL_46:
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			  volumetricParameters = (SettingParameter_1_System_Boolean_ **)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  v74 = this->fields._.renderer;
			  if ( !v74 )
			    goto LABEL_67;
			  v75 = *(_QWORD *)&v74->fields.PrevCameraPos.x;
			  z = v74->fields.PrevCameraPos.z;
			  *(_QWORD *)&value_8.x = v75;
			  value_8.z = z;
			  colorRT_8 = *UnityEngine::Vector4::op_Implicit(&colorRT_8, (Vector3 *)&value_8, v73);
			  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v77, &colorRT_8, 0LL);
			  v80 = this->fields._.renderer;
			  if ( !v80 )
			    sub_1800D8260(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields, v78);
			  v81 = *(_QWORD *)&v80->fields.PrevCameraForward.x;
			  v82 = v80->fields.PrevCameraForward.z;
			  *(_QWORD *)&value_8.x = v81;
			  value_8.z = v82;
			  value_8 = *UnityEngine::Vector4::op_Implicit(&colorRT_8, (Vector3 *)&value_8, v79);
			  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v83, &value_8, 0LL);
			  v85 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  VolumetricComposeColor = v85->_VolumetricComposeColor;
			  if ( (unsigned int)m_RTIndex >= m_TAAColors->max_length.size )
			    sub_1800D2AB0(v85, v84);
			  v87 = m_TAAColors->vector[m_RTIndex];
			  if ( !v87 )
			    sub_1800D8260(0LL, v84);
			  v88 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v87, 0LL);
			  v89 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v131, v88, 0LL);
			  v90 = *(_OWORD *)&v89->m_BufferPointer;
			  *(_OWORD *)&v128.m_Type = *(_OWORD *)&v89->m_Type;
			  *(_QWORD *)&v128.m_DepthSlice = *(_QWORD *)&v89->m_DepthSlice;
			  *(_OWORD *)&v128.m_BufferPointer = v90;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v128, 0LL);
			  v92 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			  VolumetricComposeDepth = v92->_VolumetricComposeDepth;
			  if ( (unsigned int)m_RTIndex >= m_TAADepths->max_length.size )
			    sub_1800D2AB0(v92, v91);
			  v94 = m_TAADepths->vector[m_RTIndex];
			  if ( !v94 )
			    sub_1800D8260(0LL, v91);
			  v95 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v94, 0LL);
			  v96 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit((RenderTargetIdentifier *)&v131, v95, 0LL);
			  v97 = *(_OWORD *)&v96->m_BufferPointer;
			  *(_OWORD *)&v128.m_Type = *(_OWORD *)&v96->m_Type;
			  *(_QWORD *)&v128.m_DepthSlice = *(_QWORD *)&v96->m_DepthSlice;
			  *(_OWORD *)&v128.m_BufferPointer = v97;
			  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v128, 0LL);
			  if ( (unsigned int)m_RTIndex >= m_TAAColors->max_length.size
			    || (v36->Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)m_TAAColors->vector[m_RTIndex],
			        sub_18002D1B0(
			          v36,
			          v98,
			          v100,
			          v101,
			          backface,
			          v113,
			          enableMV,
			          (int32_t)colorRTa,
			          colorRT_8.x,
			          SLODWORD(colorRT_8.z),
			          SLOBYTE(value_8.x),
			          SLOBYTE(value_8.z),
			          *(MethodInfo **)&v128.m_Type),
			        (unsigned int)m_RTIndex >= m_TAADepths->max_length.size) )
			  {
			    sub_1800D2AB0(v99, v98);
			  }
			  v42->Callback = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)m_TAADepths->vector[m_RTIndex];
			  sub_18002D1B0(
			    v42,
			    v98,
			    v102,
			    v103,
			    backfacee,
			    v118,
			    enableMVd,
			    (int32_t)colorRTa,
			    colorRT_8.x,
			    SLODWORD(colorRT_8.z),
			    SLOBYTE(value_8.x),
			    SLOBYTE(value_8.z),
			    *(MethodInfo **)&v128.m_Type);
			}
			
			public void __iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2) {} // 0x0000000189C51830-0x0000000189C51840
			// Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderInputs *P0,
			        VolumetricPipelineRT **P1,
			        VolumetricPipelineRT **P2,
			        MethodInfo *method)
			{
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    P0,
			    P1,
			    P2,
			    0LL);
			}
			
		}
	
		private class SceneComposeStage : VolumetricRenderStage // TypeDefIndex: 38744
		{
			// Constructors
			public SceneComposeStage() {} // Dummy constructor
			public SceneComposeStage(VolumetricRenderer inRenderer, EVolumetricStage inStage) {} // 0x000000018451E550-0x000000018451E590
			// VolumetricRenderer+SceneComposeStage(VolumetricRenderer, EVolumetricStage)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::SceneComposeStage(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderer *inRenderer,
			        EVolumetricStage__Enum inStage,
			        MethodInfo *method)
			{
			  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v6; // rdx
			  VolumetricRenderer_VolumetricBounds *v7; // r8
			  Int32__Array **v8; // r9
			  MethodInfo *v9; // [rsp+50h] [rbp+28h]
			  bool v10; // [rsp+58h] [rbp+30h]
			  int32_t v11; // [rsp+60h] [rbp+38h]
			  int32_t v12; // [rsp+68h] [rbp+40h]
			  float v13; // [rsp+70h] [rbp+48h]
			  int32_t v14; // [rsp+78h] [rbp+50h]
			  bool v15; // [rsp+80h] [rbp+58h]
			  bool v16; // [rsp+88h] [rbp+60h]
			  MethodInfo *v17; // [rsp+90h] [rbp+68h]
			
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::VolumetricRenderStage(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    inStage,
			    0LL);
			  this->fields._.renderer = inRenderer;
			  sub_18002D1B0(
			    (VolumetricRenderer_VolumetricRenderItem *)&this->fields._.renderer,
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
			    v16,
			    v17);
			}
			
	
			// Methods
			protected override void ProcessImpl(ref VolumetricRenderInputs inputs, ref VolumetricPipelineRT colorRT, ref VolumetricPipelineRT depthsRT) {} // 0x0000000189C52124-0x0000000189C523D4
			// Void ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::ProcessImpl(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderInputs *inputs,
			        VolumetricPipelineRT **colorRT,
			        VolumetricPipelineRT **depthsRT,
			        MethodInfo *method)
			{
			  VolumetricShaderIDs__StaticFields *static_fields; // rdx
			  SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
			  HGRenderGraphContext *context; // rdi
			  CommandBuffer *cmd; // rdi
			  BOOL v13; // r13d
			  int32_t VolumetricColor; // r12d
			  Texture *RT; // rax
			  RenderTargetIdentifier *v16; // rax
			  __int64 v17; // rdx
			  VolumetricPipelineRT *v18; // rcx
			  __int128 v19; // xmm1
			  int32_t VolumetricDepth; // esi
			  Texture *v21; // rax
			  RenderTargetIdentifier *v22; // rax
			  __int128 v23; // xmm1
			  TextureHandle sceneColor; // xmm6
			  Texture *v25; // rax
			  RenderTargetIdentifier *v26; // rax
			  __int128 v27; // xmm7
			  __int128 v28; // xmm8
			  Texture *v29; // rax
			  RenderTargetIdentifier *v30; // rax
			  __int128 v31; // xmm1
			  __int64 v32; // xmm0_8
			  VolumetricRenderer *renderer; // rbx
			  Material *m_VolumetricMat; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  TextureHandle sceneDepth; // [rsp+48h] [rbp-71h] BYREF
			  RenderTargetIdentifier v37; // [rsp+58h] [rbp-61h] BYREF
			  RenderTargetIdentifier v38[2]; // [rsp+88h] [rbp-31h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5220, 0LL) )
			  {
			    context = inputs->context;
			    if ( context )
			    {
			      volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs->volumetricParameters;
			      cmd = context->fields.cmd;
			      if ( volumetricParameters )
			      {
			        v13 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			                volumetricParameters[2],
			                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
			        volumetricParameters = (SettingParameter_1_System_Boolean_ **)*colorRT;
			        VolumetricColor = static_fields->_VolumetricColor;
			        if ( *colorRT )
			        {
			          RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
			                            (VolumetricPipelineRT *)volumetricParameters,
			                            0LL);
			          v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, RT, 0LL);
			          if ( !cmd
			            || (v19 = *(_OWORD *)&v16->m_BufferPointer,
			                *(_OWORD *)&v37.m_Type = *(_OWORD *)&v16->m_Type,
			                *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v16->m_DepthSlice,
			                *(_OWORD *)&v37.m_BufferPointer = v19,
			                UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricColor, &v37, 0LL),
			                VolumetricDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricDepth,
			                (v18 = *depthsRT) == 0LL) )
			          {
			            sub_1800D8260(v18, v17);
			          }
			          v21 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v18, 0LL);
			          v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, v21, 0LL);
			          v23 = *(_OWORD *)&v22->m_BufferPointer;
			          *(_OWORD *)&v37.m_Type = *(_OWORD *)&v22->m_Type;
			          *(_QWORD *)&v37.m_DepthSlice = *(_QWORD *)&v22->m_DepthSlice;
			          *(_OWORD *)&v37.m_BufferPointer = v23;
			          UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricDepth, &v37, 0LL);
			          sceneColor = inputs->sceneColor;
			          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			          sceneDepth = sceneColor;
			          v25 = (Texture *)HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&sceneDepth, 0LL);
			          v26 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, v25, 0LL);
			          v27 = *(_OWORD *)&v26->m_Type;
			          v28 = *(_OWORD *)&v26->m_BufferPointer;
			          sceneColor.handle = *(ResourceHandle *)&v26->m_DepthSlice;
			          sceneDepth = inputs->sceneDepth;
			          v29 = (Texture *)HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&sceneDepth, 0LL);
			          v30 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v38, v29, 0LL);
			          v31 = *(_OWORD *)&v30->m_BufferPointer;
			          *(_OWORD *)&v37.m_Type = *(_OWORD *)&v30->m_Type;
			          v32 = *(_QWORD *)&v30->m_DepthSlice;
			          *(_OWORD *)&v37.m_BufferPointer = v31;
			          *(_QWORD *)&v37.m_DepthSlice = v32;
			          *(_OWORD *)&v38[0].m_Type = v27;
			          *(_OWORD *)&v38[0].m_BufferPointer = v28;
			          *(ResourceHandle *)&v38[0].m_DepthSlice = sceneColor.handle;
			          UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			            cmd,
			            v38,
			            RenderBufferLoadAction__Enum_Load,
			            RenderBufferStoreAction__Enum_Store,
			            &v37,
			            RenderBufferLoadAction__Enum_Load,
			            RenderBufferStoreAction__Enum_Store,
			            0LL);
			          renderer = this->fields._.renderer;
			          if ( renderer )
			          {
			            m_VolumetricMat = renderer->fields.m_VolumetricMat;
			            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			            HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, m_VolumetricMat, !v13 + 3, 0, 0LL);
			            return;
			          }
			        }
			      }
			    }
			LABEL_11:
			    sub_1800D8260(volumetricParameters, static_fields);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(5220, 0LL);
			  if ( !Patch )
			    goto LABEL_11;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1507(Patch, (Object *)this, inputs, colorRT, depthsRT, 0LL);
			}
			
			public void __iFixBaseProxy_ProcessImpl(ref VolumetricRenderInputs P0, ref VolumetricPipelineRT P1, ref VolumetricPipelineRT P2) {} // 0x0000000189C51830-0x0000000189C51840
			// Void <>iFixBaseProxy_ProcessImpl(VolumetricRenderInputs ByRef, VolumetricPipelineRT ByRef, VolumetricPipelineRT ByRef)
			void HG::Rendering::Runtime::VolumetricRenderer::SceneComposeStage::__iFixBaseProxy_ProcessImpl(
			        VolumetricRenderer_SceneComposeStage *this,
			        VolumetricRenderInputs *P0,
			        VolumetricPipelineRT **P1,
			        VolumetricPipelineRT **P2,
			        MethodInfo *method)
			{
			  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::ProcessImpl(
			    (VolumetricRenderer_VolumetricRenderStage *)this,
			    P0,
			    P1,
			    P2,
			    0LL);
			}
			
		}
	
		private class VolumetricStageComparer : IEqualityComparer<EVolumetricStage> // TypeDefIndex: 38745
		{
			// Constructors
			public VolumetricStageComparer() {} // 0x00000001841E1670-0x00000001841E1680
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
			
	
			// Methods
			public bool Equals(EVolumetricStage x, EVolumetricStage y) => default; // 0x0000000189C622E4-0x0000000189C62350
			// Boolean Equals(EVolumetricStage, EVolumetricStage)
			bool HG::Rendering::Runtime::VolumetricRenderer::VolumetricStageComparer::Equals(
			        VolumetricRenderer_VolumetricStageComparer *this,
			        EVolumetricStage__Enum x,
			        EVolumetricStage__Enum y,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5221, 0LL) )
			    return x == y;
			  Patch = IFix::WrappersManagerImpl::GetPatch(5221, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v10, v9);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_10 *)Patch, (Object *)this, x, y, 0LL);
			}
			
			public int GetHashCode(EVolumetricStage obj) => default; // 0x0000000184A1DE00-0x0000000184A1DE30
			// Int32 GetHashCode(EVolumetricStage)
			int32_t HG::Rendering::Runtime::VolumetricRenderer::VolumetricStageComparer::GetHashCode(
			        VolumetricRenderer_VolumetricStageComparer *this,
			        EVolumetricStage__Enum obj,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(5222, 0LL) )
			    return obj;
			  Patch = IFix::WrappersManagerImpl::GetPatch(5222, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v8, v7);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, obj, 0LL);
			}
			
		}
	
		// Constructors
		public VolumetricRenderer() {} // Dummy constructor
		public VolumetricRenderer(Material volumetricMaterial) {} // 0x000000018451E050-0x000000018451E4F0
	
		// Methods
		private void ResetRenderNodePool() {} // 0x0000000189C58BD8-0x0000000189C58C28
		// Void ResetRenderNodePool()
		void HG::Rendering::Runtime::VolumetricRenderer::ResetRenderNodePool(VolumetricRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5145, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5145, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.renderNodePoolIndex = 0;
		  }
		}
		
		private VolumetricRenderNode GetRenderNodeFromPool() => default; // 0x0000000189C56BE0-0x0000000189C56CAC
		// VolumetricRenderer+VolumetricRenderNode GetRenderNodeFromPool()
		VolumetricRenderer_VolumetricRenderNode *HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(
		        VolumetricRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *renderNodePool; // rax
		  List_1_System_Object_ *renderNodePoolIndex; // rcx
		  List_1_System_Object_ *v6; // rdi
		  __int64 v7; // rax
		  Object *Item; // rax
		  VolumetricRenderer_VolumetricRenderNode *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5146, 0LL) )
		  {
		    renderNodePool = this->fields.renderNodePool;
		    renderNodePoolIndex = (List_1_System_Object_ *)(unsigned int)this->fields.renderNodePoolIndex;
		    if ( !renderNodePool )
		      goto LABEL_10;
		    if ( (int)renderNodePoolIndex >= renderNodePool->fields._size )
		    {
		      v6 = (List_1_System_Object_ *)this->fields.renderNodePool;
		      v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode);
		      if ( !v7 )
		        goto LABEL_10;
		      *(_DWORD *)(v7 + 116) = -1;
		      sub_182F01190(v6, (Object *)v7);
		    }
		    v3 = (unsigned int)this->fields.renderNodePoolIndex;
		    renderNodePoolIndex = (List_1_System_Object_ *)this->fields.renderNodePool;
		    this->fields.renderNodePoolIndex = v3 + 1;
		    if ( renderNodePoolIndex )
		    {
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               renderNodePoolIndex,
		               v3,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
		      v9 = (VolumetricRenderer_VolumetricRenderNode *)Item;
		      if ( Item )
		      {
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::Reset(
		          (VolumetricRenderer_VolumetricRenderNode *)Item,
		          0LL);
		        return v9;
		      }
		    }
		LABEL_10:
		    sub_1800D8260(renderNodePoolIndex, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5146, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1497(Patch, (Object *)this, 0LL);
		}
		
		public void Release() {} // 0x000000018451E000-0x000000018451E050
		// Void Release()
		void HG::Rendering::Runtime::VolumetricRenderer::Release(VolumetricRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderStage_ *m_RenderStages; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3456, 0LL) )
		  {
		    HG::Rendering::Runtime::VolumetricRenderer::ReleaseVolumetricRTs(this, 1, 0LL);
		    m_RenderStages = this->fields.m_RenderStages;
		    if ( m_RenderStages )
		    {
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		        (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)m_RenderStages,
		        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::Clear);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_RenderStages, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3456, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void UpdateCloudFadeParameters(CommandBuffer cmd) {} // 0x0000000189C58EB0-0x0000000189C5901C
		// Void UpdateCloudFadeParameters(CommandBuffer)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateCloudFadeParameters(
		        VolumetricRenderer *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  Material *m_VolumetricMat; // rdi
		  VolumetricShaderIDs__StaticFields *v6; // rcx
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  Material *v8; // rbx
		  int32_t CloudFadeRatio; // ebx
		  double v10; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5148, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeOut(this, 0LL) )
		      HG::Rendering::Runtime::VolumetricRenderer::get_IsFadeIn(this, 0LL);
		    m_VolumetricMat = this->fields.m_VolumetricMat;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    if ( m_VolumetricMat )
		    {
		      if ( UnityEngine::Material::HasProperty(m_VolumetricMat, static_fields->_CloudFadeSpeedPow, 0LL) )
		      {
		        v8 = this->fields.m_VolumetricMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        if ( !v8 )
		          goto LABEL_11;
		        UnityEngine::Material::GetFloatImpl(v8, static_fields->_CloudFadeSpeedPow, 0LL);
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      v6 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      CloudFadeRatio = v6->_CloudFadeRatio;
		      if ( cmd )
		      {
		        v10 = sub_1803369A0();
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, CloudFadeRatio, *(float *)&v10, 0LL);
		        return;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v6, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5148, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)cmd,
		    0LL);
		}
		
		public void Render(ref VolumetricRenderInputs inputs) {} // 0x0000000189C587FC-0x0000000189C58BD8
		// Void Render(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::Render(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Component *camera; // rcx
		  HGRenderGraphContext *context; // r14
		  CommandBuffer *cmd; // r14
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // ecx
		  Transform *v12; // rax
		  Vector3 *forward; // rax
		  float v14; // ecx
		  int32_t VolumetricComposeColor; // ebx
		  Texture *blackTexture; // rax
		  RenderTargetIdentifier *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int128 v20; // xmm1
		  int32_t VolumetricComposeDepth; // ebx
		  Texture *v22; // rax
		  RenderTargetIdentifier *v23; // rax
		  __int128 v24; // xmm1
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v26; // rdx
		  VolumetricCloudVolumeManager *volumetricCloudVolumeManager_k__BackingField; // rcx
		  ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ FadeRatioAndState; // rax
		  Object_1 *m_VolumetricMat; // rbx
		  int32_t v30; // r10d
		  Vector4 sceneDepthToSample; // xmm6
		  int32_t CameraDepthTexture; // ebx
		  RenderTargetIdentifier *v33; // rax
		  __int128 v34; // xmm1
		  Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderStage_ *m_RenderStages; // rcx
		  HGCamera *hgCamera; // rdx
		  HGRenderGraphContext *v37; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 value; // [rsp+28h] [rbp-39h] BYREF
		  RenderTargetIdentifier v40; // [rsp+38h] [rbp-29h] BYREF
		  RenderTargetIdentifier v41; // [rsp+68h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5149, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5149, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		      return;
		    }
		LABEL_28:
		    sub_1800D8260(camera, v5);
		  }
		  context = inputs->context;
		  if ( !context )
		    goto LABEL_28;
		  cmd = context->fields.cmd;
		  if ( !inputs->hgCamera )
		    goto LABEL_28;
		  camera = (Component *)inputs->hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_28;
		  transform = UnityEngine::Component::get_transform(camera, 0LL);
		  if ( !transform )
		    goto LABEL_28;
		  position = UnityEngine::Transform::get_position((Vector3 *)&value, transform, 0LL);
		  z = position->z;
		  *(_QWORD *)&this->fields.PrevCameraPos.x = *(_QWORD *)&position->x;
		  this->fields.PrevCameraPos.z = z;
		  camera = (Component *)inputs->hgCamera;
		  if ( !inputs->hgCamera )
		    goto LABEL_28;
		  camera = (Component *)camera[4].klass;
		  if ( !camera )
		    goto LABEL_28;
		  v12 = UnityEngine::Component::get_transform(camera, 0LL);
		  if ( !v12 )
		    goto LABEL_28;
		  forward = UnityEngine::Transform::get_forward((Vector3 *)&value, v12, 0LL);
		  v14 = forward->z;
		  *(_QWORD *)&this->fields.PrevCameraForward.x = *(_QWORD *)&forward->x;
		  this->fields.PrevCameraForward.z = v14;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  VolumetricComposeColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeColor;
		  blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  v17 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v41, blackTexture, 0LL);
		  if ( !cmd )
		    sub_1800D8260(v19, v18);
		  v20 = *(_OWORD *)&v17->m_BufferPointer;
		  *(_OWORD *)&v40.m_Type = *(_OWORD *)&v17->m_Type;
		  *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v17->m_DepthSlice;
		  *(_OWORD *)&v40.m_BufferPointer = v20;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeColor, &v40, 0LL);
		  VolumetricComposeDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_VolumetricComposeDepth;
		  v22 = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  v23 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v41, v22, 0LL);
		  v24 = *(_OWORD *)&v23->m_BufferPointer;
		  *(_OWORD *)&v40.m_Type = *(_OWORD *)&v23->m_Type;
		  *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v23->m_DepthSlice;
		  *(_OWORD *)&v40.m_BufferPointer = v24;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, VolumetricComposeDepth, &v40, 0LL);
		  currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		  if ( !currentManagerContext
		    || (volumetricCloudVolumeManager_k__BackingField = currentManagerContext->fields._volumetricCloudVolumeManager_k__BackingField) == 0LL )
		  {
		    sub_1800D8260(volumetricCloudVolumeManager_k__BackingField, v26);
		  }
		  FadeRatioAndState = HG::Rendering::Runtime::VolumetricCloudVolumeManager::GetFadeRatioAndState(
		                        volumetricCloudVolumeManager_k__BackingField,
		                        inputs->hgCamera,
		                        0LL);
		  m_VolumetricMat = (Object_1 *)this->fields.m_VolumetricMat;
		  *(ValueTuple_2_HG_Rendering_Runtime_EVolumetricState_Single_ *)&this->fields.m_VolumetricState = FadeRatioAndState;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality(m_VolumetricMat, 0LL, 0LL)
		    && (inputs->volumetricRenderObjects && inputs->volumetricRenderObjects->fields._size
		     || this->fields.m_VolumetricState) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    value = *(Vector4 *)sub_183240A00(&value, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v30, &value, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    sceneDepthToSample = (Vector4)inputs->sceneDepthToSample;
		    CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraDepthTexture;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    value = sceneDepthToSample;
		    v33 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v41, (TextureHandle *)&value, 0LL);
		    v34 = *(_OWORD *)&v33->m_BufferPointer;
		    *(_OWORD *)&v40.m_Type = *(_OWORD *)&v33->m_Type;
		    *(_QWORD *)&v40.m_DepthSlice = *(_QWORD *)&v33->m_DepthSlice;
		    *(_OWORD *)&v40.m_BufferPointer = v34;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, CameraDepthTexture, &v40, 0LL);
		    hgCamera = inputs->hgCamera;
		    if ( !inputs->hgCamera
		      || (v37 = inputs->context) == 0LL
		      || (HG::Rendering::Runtime::VolumetricRenderer::UpdateCamera(this, hgCamera->fields.camera, v37->fields.cmd, 0LL),
		          (m_RenderStages = this->fields.m_RenderStages) == 0LL) )
		    {
		      sub_1800D8260(m_RenderStages, hgCamera);
		    }
		    if ( m_RenderStages->fields._count - m_RenderStages->fields._freeCount > 0 )
		      HG::Rendering::Runtime::VolumetricRenderer::UpdateRenderStageAndDraw(this, inputs, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(
		      cmd,
		      &TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ComposeVolumetric,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(
		      cmd,
		      &TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ComposeVolumetric,
		      0LL);
		  }
		  HG::Rendering::Runtime::VolumetricRenderer::ReleaseVolumetricRTs(this, 0, 0LL);
		}
		
		private void UpdateCamera(Camera camera, CommandBuffer cmd) {} // 0x0000000189C58C28-0x0000000189C58EB0
		// Void UpdateCamera(Camera, CommandBuffer)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateCamera(
		        VolumetricRenderer *this,
		        Camera *camera,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // edi
		  Matrix4x4 *nonJitteredProjectionMatrix; // rax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Matrix4x4 *v21; // rbx
		  Matrix4x4 *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Matrix4x4 *v30; // rax
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  int32_t InvPartialVPMatrix; // ebx
		  Matrix4x4 *inverse; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  __int128 v38; // xmm1
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v42; // [rsp+30h] [rbp-D0h] BYREF
		  Matrix4x4 v43; // [rsp+40h] [rbp-C0h] BYREF
		  Matrix4x4 value; // [rsp+80h] [rbp-80h] BYREF
		  __int128 v45; // [rsp+C0h] [rbp-40h] BYREF
		  Matrix4x4 v46; // [rsp+D0h] [rbp-30h] BYREF
		  __int128 v47; // [rsp+110h] [rbp+10h]
		  __int128 v48; // [rsp+120h] [rbp+20h]
		  __int128 v49; // [rsp+130h] [rbp+30h]
		  Matrix4x4 v50; // [rsp+140h] [rbp+40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5150, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5150, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        (Object *)cmd,
		        0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !camera )
		    goto LABEL_8;
		  transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		  if ( !transform )
		    goto LABEL_8;
		  position = UnityEngine::Transform::get_position((Vector3 *)&v45, transform, 0LL);
		  z = position->z;
		  *(_QWORD *)&v42.x = *(_QWORD *)&position->x;
		  nonJitteredProjectionMatrix = UnityEngine::Camera::get_nonJitteredProjectionMatrix(&value, camera, 0LL);
		  v13 = *(_OWORD *)&nonJitteredProjectionMatrix->m01;
		  *(_OWORD *)&v43.m00 = *(_OWORD *)&nonJitteredProjectionMatrix->m00;
		  v14 = *(_OWORD *)&nonJitteredProjectionMatrix->m02;
		  *(_OWORD *)&v43.m01 = v13;
		  v15 = *(_OWORD *)&nonJitteredProjectionMatrix->m03;
		  *(_OWORD *)&v43.m02 = v14;
		  *(_OWORD *)&v43.m03 = v15;
		  GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&value, &v43, 1, 0LL);
		  v45 = *(_OWORD *)&GPUProjectionMatrix->m00;
		  v47 = *(_OWORD *)&GPUProjectionMatrix->m01;
		  v48 = *(_OWORD *)&GPUProjectionMatrix->m02;
		  v49 = *(_OWORD *)&GPUProjectionMatrix->m03;
		  worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&value, camera, 0LL);
		  v18 = *(_OWORD *)&worldToCameraMatrix->m01;
		  *(_OWORD *)&v43.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		  v19 = *(_OWORD *)&worldToCameraMatrix->m02;
		  *(_OWORD *)&v43.m01 = v18;
		  v20 = *(_OWORD *)&worldToCameraMatrix->m03;
		  *(_OWORD *)&v43.m02 = v19;
		  *(_OWORD *)&v43.m03 = v20;
		  *(_OWORD *)&v46.m00 = v45;
		  *(_OWORD *)&v46.m01 = v47;
		  *(_OWORD *)&v46.m02 = v48;
		  *(_OWORD *)&v46.m03 = v49;
		  v42.z = z;
		  v21 = UnityEngine::Matrix4x4::op_Multiply(&v50, &v46, &v43, 0LL);
		  v22 = UnityEngine::Matrix4x4::Translate(&value, &v42, 0LL);
		  v23 = *(_OWORD *)&v22->m01;
		  *(_OWORD *)&v43.m00 = *(_OWORD *)&v22->m00;
		  v24 = *(_OWORD *)&v22->m02;
		  *(_OWORD *)&v43.m01 = v23;
		  v25 = *(_OWORD *)&v22->m03;
		  *(_OWORD *)&v43.m02 = v24;
		  v26 = *(_OWORD *)&v21->m00;
		  *(_OWORD *)&v43.m03 = v25;
		  v27 = *(_OWORD *)&v21->m01;
		  *(_OWORD *)&value.m00 = v26;
		  v28 = *(_OWORD *)&v21->m02;
		  *(_OWORD *)&value.m01 = v27;
		  v29 = *(_OWORD *)&v21->m03;
		  *(_OWORD *)&value.m02 = v28;
		  *(_OWORD *)&value.m03 = v29;
		  v30 = UnityEngine::Matrix4x4::op_Multiply(&v50, &value, &v43, 0LL);
		  v31 = *(_OWORD *)&v30->m01;
		  *(_OWORD *)&v46.m00 = *(_OWORD *)&v30->m00;
		  v32 = *(_OWORD *)&v30->m02;
		  *(_OWORD *)&v46.m01 = v31;
		  v33 = *(_OWORD *)&v30->m03;
		  *(_OWORD *)&v46.m02 = v32;
		  *(_OWORD *)&v46.m03 = v33;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  InvPartialVPMatrix = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvPartialVPMatrix;
		  inverse = UnityEngine::Matrix4x4::get_inverse(&v50, &v46, 0LL);
		  if ( !cmd )
		    sub_1800D8260(v37, v36);
		  v38 = *(_OWORD *)&inverse->m01;
		  *(_OWORD *)&value.m00 = *(_OWORD *)&inverse->m00;
		  v39 = *(_OWORD *)&inverse->m02;
		  *(_OWORD *)&value.m01 = v38;
		  v40 = *(_OWORD *)&inverse->m03;
		  *(_OWORD *)&value.m02 = v39;
		  *(_OWORD *)&value.m03 = v40;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalMatrix_Injected(cmd, InvPartialVPMatrix, &value, 0LL);
		}
		
		private void DisableAllStages() {} // 0x0000000189C55FFC-0x0000000189C56128
		// Void DisableAllStages()
		void HG::Rendering::Runtime::VolumetricRenderer::DisableAllStages(VolumetricRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderStage_ *m_RenderStages; // rcx
		  Object *Item; // rax
		  Object *v6; // rax
		  Object *v7; // rax
		  Object *v8; // rax
		  Object *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5174, 0LL) )
		  {
		    m_RenderStages = this->fields.m_RenderStages;
		    if ( m_RenderStages )
		    {
		      Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		               (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
		               (Int32Enum__Enum)0,
		               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( Item )
		      {
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
		          (VolumetricRenderer_VolumetricRenderStage *)Item,
		          0LL);
		        m_RenderStages = this->fields.m_RenderStages;
		        if ( m_RenderStages )
		        {
		          v6 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                 (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
		                 (Int32Enum__Enum)1u,
		                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		          if ( v6 )
		          {
		            HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
		              (VolumetricRenderer_VolumetricRenderStage *)v6,
		              0LL);
		            m_RenderStages = this->fields.m_RenderStages;
		            if ( m_RenderStages )
		            {
		              v7 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                     (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
		                     (Int32Enum__Enum)2u,
		                     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		              if ( v7 )
		              {
		                HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
		                  (VolumetricRenderer_VolumetricRenderStage *)v7,
		                  0LL);
		                m_RenderStages = this->fields.m_RenderStages;
		                if ( m_RenderStages )
		                {
		                  v8 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                         (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
		                         (Int32Enum__Enum)3u,
		                         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		                  if ( v8 )
		                  {
		                    HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
		                      (VolumetricRenderer_VolumetricRenderStage *)v8,
		                      0LL);
		                    m_RenderStages = this->fields.m_RenderStages;
		                    if ( m_RenderStages )
		                    {
		                      v9 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                             (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
		                             (Int32Enum__Enum)4u,
		                             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		                      if ( v9 )
		                      {
		                        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Reset(
		                          (VolumetricRenderer_VolumetricRenderStage *)v9,
		                          0LL);
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
		LABEL_14:
		    sub_1800D8260(m_RenderStages, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5174, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private VolumetricRenderItem GetDefaultFramingComposeItem(Material composeMaterial) => default; // 0x0000000189C5686C-0x0000000189C56A2C
		// VolumetricRenderer+VolumetricRenderItem GetDefaultFramingComposeItem(Material)
		VolumetricRenderer_VolumetricRenderItem *HG::Rendering::Runtime::VolumetricRenderer::GetDefaultFramingComposeItem(
		        VolumetricRenderer_VolumetricRenderItem *__return_ptr retstr,
		        VolumetricRenderer *this,
		        Material *composeMaterial,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  __int64 v9; // rcx
		  VolumetricRenderer_VolumetricBounds *v10; // r8
		  Int32__Array **v11; // r9
		  Object *v12; // rdi
		  Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v13; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // r14
		  Material *klass; // rdi
		  bool m_EnableTAA; // bl
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v19; // [rsp+28h] [rbp-E0h]
		  bool v20; // [rsp+30h] [rbp-D8h]
		  int32_t v21; // [rsp+38h] [rbp-D0h]
		  int32_t v22; // [rsp+40h] [rbp-C8h]
		  float v23; // [rsp+48h] [rbp-C0h]
		  int32_t v24; // [rsp+50h] [rbp-B8h]
		  bool v25; // [rsp+58h] [rbp-B0h]
		  bool v26; // [rsp+60h] [rbp-A8h]
		  MethodInfo *v27; // [rsp+68h] [rbp-A0h]
		  _BYTE v28[28]; // [rsp+70h] [rbp-98h] BYREF
		  VolumetricRenderer_VolumetricBounds v29; // [rsp+98h] [rbp-70h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v30; // [rsp+B8h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5191, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5191, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1505(
		                   &v30,
		                   Patch,
		                   (Object *)this,
		                   (Object *)composeMaterial,
		                   0LL);
		      return retstr;
		    }
		LABEL_6:
		    sub_1800D8260(v9, v8);
		  }
		  v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass65_0);
		  v12 = (Object *)v7;
		  if ( !v7 )
		    goto LABEL_6;
		  *(_QWORD *)(v7 + 16) = composeMaterial;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)(v7 + 16),
		    v8,
		    v10,
		    v11,
		    v19,
		    v20,
		    v21,
		    v22,
		    v23,
		    v24,
		    v25,
		    v26,
		    v27);
		  v13 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_18002C620(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
		  v14 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v13;
		  if ( !v13 )
		    goto LABEL_6;
		  System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
		    v13,
		    v12,
		    MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass65_0::_GetDefaultFramingComposeItem_b__0,
		    0LL);
		  klass = (Material *)v12[1].klass;
		  m_EnableTAA = this->fields.m_EnableTAA;
		  memset(&v28[8], 0, 20);
		  sub_18033B9D0(retstr, 0LL, 88LL);
		  *(_OWORD *)&v29.enableBounds = *(_OWORD *)&v28[8];
		  *(_QWORD *)&v29.worldBounds.m_Extents.x = 0LL;
		  v29.worldBounds.m_Extents.z = 0.0;
		  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
		    retstr,
		    v14,
		    &v29,
		    klass,
		    0,
		    m_EnableTAA,
		    -99999,
		    3000,
		    99999.0,
		    -1,
		    1,
		    1,
		    0LL);
		  return retstr;
		}
		
		private VolumetricRenderItem GetDefaultTemporalComposeItem(Material composeMaterial) => default; // 0x0000000189C56A2C-0x0000000189C56BE0
		// VolumetricRenderer+VolumetricRenderItem GetDefaultTemporalComposeItem(Material)
		VolumetricRenderer_VolumetricRenderItem *HG::Rendering::Runtime::VolumetricRenderer::GetDefaultTemporalComposeItem(
		        VolumetricRenderer_VolumetricRenderItem *__return_ptr retstr,
		        VolumetricRenderer *this,
		        Material *composeMaterial,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  __int64 v9; // rcx
		  VolumetricRenderer_VolumetricBounds *v10; // r8
		  Int32__Array **v11; // r9
		  Object *v12; // rbx
		  Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v13; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rsi
		  Material *klass; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v18; // [rsp+28h] [rbp-E0h]
		  bool v19; // [rsp+30h] [rbp-D8h]
		  int32_t v20; // [rsp+38h] [rbp-D0h]
		  int32_t v21; // [rsp+40h] [rbp-C8h]
		  float v22; // [rsp+48h] [rbp-C0h]
		  int32_t v23; // [rsp+50h] [rbp-B8h]
		  bool v24; // [rsp+58h] [rbp-B0h]
		  bool v25; // [rsp+60h] [rbp-A8h]
		  MethodInfo *v26; // [rsp+68h] [rbp-A0h]
		  _BYTE v27[28]; // [rsp+70h] [rbp-98h] BYREF
		  VolumetricRenderer_VolumetricBounds v28; // [rsp+98h] [rbp-70h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v29; // [rsp+B8h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5197, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5197, 0LL);
		    if ( Patch )
		    {
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1505(
		                   &v29,
		                   Patch,
		                   (Object *)this,
		                   (Object *)composeMaterial,
		                   0LL);
		      return retstr;
		    }
		LABEL_6:
		    sub_1800D8260(v9, v8);
		  }
		  v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass66_0);
		  v12 = (Object *)v7;
		  if ( !v7 )
		    goto LABEL_6;
		  *(_QWORD *)(v7 + 16) = composeMaterial;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)(v7 + 16),
		    v8,
		    v10,
		    v11,
		    v18,
		    v19,
		    v20,
		    v21,
		    v22,
		    v23,
		    v24,
		    v25,
		    v26);
		  v13 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_18002C620(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
		  v14 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v13;
		  if ( !v13 )
		    goto LABEL_6;
		  System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
		    v13,
		    v12,
		    MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c__DisplayClass66_0::_GetDefaultTemporalComposeItem_b__0,
		    0LL);
		  klass = (Material *)v12[1].klass;
		  memset(&v27[8], 0, 20);
		  sub_18033B9D0(retstr, 0LL, 88LL);
		  *(_OWORD *)&v28.enableBounds = *(_OWORD *)&v27[8];
		  *(_QWORD *)&v28.worldBounds.m_Extents.x = 0LL;
		  v28.worldBounds.m_Extents.z = 0.0;
		  HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
		    retstr,
		    v14,
		    &v28,
		    klass,
		    0,
		    0,
		    -99999,
		    3000,
		    99999.0,
		    -1,
		    1,
		    1,
		    0LL);
		  return retstr;
		}
		
		private void AddToComposeCache(Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> composeCache, EVolumetricStage stage, IVolumetricRenderObject obj) {} // 0x0000000189C55DA8-0x0000000189C55EC0
		// Void AddToComposeCache(Dictionary`2[HG.Rendering.Runtime.EVolumetricStage,List`1[HG.Rendering.Runtime.IVolumetricRenderObject]], EVolumetricStage, IVolumetricRenderObject)
		void HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		        VolumetricRenderer *this,
		        Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *composeCache,
		        EVolumetricStage__Enum stage,
		        IVolumetricRenderObject *obj,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Object *v10; // rcx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v11; // rax
		  Object *v12; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *value; // [rsp+30h] [rbp-18h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5190, 0LL) )
		  {
		    if ( !composeCache )
		      goto LABEL_11;
		    if ( !System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::TryGetValue(
		            (Dictionary_2_System_Int32Enum_System_Object_ *)composeCache,
		            (Int32Enum__Enum)stage,
		            &value,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::TryGetValue) )
		    {
		      v11 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>);
		      v12 = (Object *)v11;
		      if ( !v11 )
		        goto LABEL_11;
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v11,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::List);
		      value = v12;
		      System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Add(
		        (Dictionary_2_System_Int32Enum_System_Object_ *)composeCache,
		        (Int32Enum__Enum)stage,
		        v12,
		        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::Add);
		    }
		    v10 = value;
		    if ( value )
		    {
		      if ( System::Collections::Generic::List<System::Object>::Contains(
		             (List_1_System_Object_ *)value,
		             (Object *)obj,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Contains) )
		      {
		        return;
		      }
		      v10 = value;
		      if ( value )
		      {
		        sub_182F01190((List_1_System_Object_ *)value, (Object *)obj);
		        return;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5190, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_30(
		    (ILFixDynamicMethodWrapper_9 *)Patch,
		    (Object *)this,
		    (Object *)composeCache,
		    stage,
		    (Object *)obj,
		    0LL);
		}
		
		private void ClearComposeCache(Dictionary<EVolumetricStage, List<IVolumetricRenderObject>> composeCache) {} // 0x0000000189C55EC0-0x0000000189C55FFC
		// Void ClearComposeCache(Dictionary`2[HG.Rendering.Runtime.EVolumetricStage,List`1[HG.Rendering.Runtime.IVolumetricRenderObject]])
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VolumetricRenderer::ClearComposeCache(
		        VolumetricRenderer *this,
		        Dictionary_2_HG_Rendering_Runtime_EVolumetricStage_List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *composeCache,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Il2CppExceptionWrapper *v11; // [rsp+20h] [rbp-78h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-70h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v13; // [rsp+30h] [rbp-68h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v14; // [rsp+38h] [rbp-60h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v15; // [rsp+60h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5188, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5188, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)composeCache,
		      0LL);
		  }
		  else
		  {
		    if ( !composeCache )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v15,
		      (Dictionary_2_System_UInt64_System_Object_ *)composeCache,
		      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
		    v14 = v15;
		    ex = 0LL;
		    v13 = &v14;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v14,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext) )
		      {
		        if ( !v14._current.value )
		          sub_1800D8250(0LL, v7);
		        sub_183127A90(
		          v14._current.value,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Clear);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v11 )
		    {
		      ex = v11->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		private void ProcessFramingCompose(ref VolumetricRenderInputs inputs) {} // 0x0000000189C56FC8-0x0000000189C57C18
		// Void ProcessFramingCompose(VolumetricRenderInputs ByRef)
		// Hidden C++ exception states: #wind=6
		void HG::Rendering::Runtime::VolumetricRenderer::ProcessFramingCompose(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  VolumetricRenderer *v3; // rdi
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Object *Item; // rax
		  Dictionary_2_System_UInt64_System_Object_ *framingCompose; // rdx
		  Dictionary_2_System_Int32Enum_System_Object_ *m_RenderStages; // rcx
		  Object *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *RenderNodes; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // rcx
		  Object *v16; // rax
		  List_1_System_UInt64_ *v17; // rax
		  __int64 v18; // rdx
		  Object *v19; // rax
		  List_1_System_UInt64_ *v20; // rax
		  __int64 v21; // rcx
		  Object *v22; // rax
		  List_1_System_UInt64_ *v23; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
		  unsigned __int64 v28; // xmm0_8
		  VolumetricRenderer_VolumetricRenderItem *DefaultFramingComposeItem; // rax
		  __int64 v30; // rcx
		  __int128 v31; // xmm9
		  __int128 v32; // xmm10
		  __int128 v33; // xmm11
		  __m128i v34; // xmm7
		  __m128i v35; // xmm8
		  MeshFilter *meshFilter; // xmm12_8
		  Object *v37; // r12
		  List_1_System_UInt64_ *v38; // rdx
		  int32_t v39; // r14d
		  _BYTE *v40; // rdx
		  Object *v41; // rsi
		  unsigned __int64 v42; // rdx
		  unsigned __int64 v43; // r8
		  signed __int64 v44; // rtt
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
		  unsigned __int64 v46; // r8
		  signed __int64 v47; // rtt
		  int v48; // edx
		  char v49; // al
		  Dictionary_2_System_Int32Enum_System_Object_ *v50; // rcx
		  Int32Enum__Enum v51; // r14d
		  Object *v52; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  VolumetricRenderer_VolumetricRenderNode *RenderNodeFromPool; // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  VolumetricRenderer_VolumetricRenderNode *v58; // rsi
		  __int64 v59; // rdx
		  unsigned __int64 v60; // r9
		  signed __int64 v61; // rtt
		  Dictionary_2_System_Int32Enum_System_Object_ *v62; // rcx
		  Object *v63; // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  _BYTE v69[32]; // [rsp+0h] [rbp-318h] BYREF
		  VolumetricRenderer_VolumetricComposeContext v70; // [rsp+30h] [rbp-2E8h] BYREF
		  List_1_T_Enumerator_System_Object_ v71; // [rsp+50h] [rbp-2C8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v72; // [rsp+70h] [rbp-2A8h] BYREF
		  __int128 v73; // [rsp+A0h] [rbp-278h] BYREF
		  HGVolumetricCloudSettingParameters *v74; // [rsp+B0h] [rbp-268h] BYREF
		  List_1_T_Enumerator_System_Object_ v75; // [rsp+B8h] [rbp-260h] BYREF
		  Il2CppException *ex; // [rsp+D0h] [rbp-248h]
		  List_1_T_Enumerator_System_Object_ *v77; // [rsp+D8h] [rbp-240h]
		  Il2CppException *v78; // [rsp+E0h] [rbp-238h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v79; // [rsp+E8h] [rbp-230h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v80; // [rsp+F0h] [rbp-228h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v81; // [rsp+120h] [rbp-1F8h]
		  Int32Enum__Enum key[4]; // [rsp+180h] [rbp-198h]
		  Il2CppExceptionWrapper *v83; // [rsp+190h] [rbp-188h] BYREF
		  Il2CppExceptionWrapper *v84; // [rsp+198h] [rbp-180h] BYREF
		  Il2CppExceptionWrapper *v85; // [rsp+1A0h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v86; // [rsp+1A8h] [rbp-170h] BYREF
		  Il2CppExceptionWrapper *v87; // [rsp+1B0h] [rbp-168h] BYREF
		  Il2CppExceptionWrapper *v88; // [rsp+1B8h] [rbp-160h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v89; // [rsp+1C0h] [rbp-158h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v90[2]; // [rsp+220h] [rbp-F8h] BYREF
		  Object *v93; // [rsp+338h] [rbp+20h]
		
		  v3 = this;
		  memset(&v71, 0, sizeof(v71));
		  memset(&v80, 0, sizeof(v80));
		  memset(&v75, 0, sizeof(v75));
		  sub_18033B9D0(&v89, 0LL, 88LL);
		  v73 = 0LL;
		  v74 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5187, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5187, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v68, v67);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)v3, inputs, 0LL);
		    return;
		  }
		  HG::Rendering::Runtime::VolumetricRenderer::ClearComposeCache(v3, v3->fields.framingCompose, 0LL);
		  if ( !v3->fields.m_RenderStages )
		    sub_1800D8260(v5, v4);
		  Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		           (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages,
		           (Int32Enum__Enum)0,
		           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		  if ( !Item )
		    sub_1800D8260(m_RenderStages, framingCompose);
		  if ( LOBYTE(Item[2].klass) )
		  {
		    if ( !v3->fields.m_EnableTAA )
		      goto LABEL_24;
		    if ( !v3->fields.m_RenderStages )
		      sub_1800D8260(m_RenderStages, framingCompose);
		    v9 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		           (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages,
		           (Int32Enum__Enum)0,
		           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		    if ( !v9 )
		      sub_1800D8260(v11, v10);
		    RenderNodes = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                    (VolumetricRenderer_VolumetricRenderStage *)v9,
		                    0LL);
		    if ( !RenderNodes )
		      sub_1800D8260(v14, v13);
		    v71 = *(List_1_T_Enumerator_System_Object_ *)sub_1808B28A0(&v72, RenderNodes);
		    *(_QWORD *)&v70.bEnableFraming = 0LL;
		    v70.volumetricComposeMaterial = (Material *)&v71;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v71,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		      {
		        if ( !v71._current )
		          sub_1800D8250(v15, framingCompose);
		        HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		          v3,
		          v3->fields.framingCompose,
		          EVolumetricStage__Enum_BeforeTemporal,
		          (IVolumetricRenderObject *)v71._current[7].monitor,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v83 )
		    {
		      framingCompose = (Dictionary_2_System_UInt64_System_Object_ *)v69;
		      *(Il2CppExceptionWrapper *)&v70.bEnableFraming = (Il2CppExceptionWrapper)v83->ex;
		      if ( *(_QWORD *)&v70.bEnableFraming )
		        sub_18007E1E0(*(_QWORD *)&v70.bEnableFraming);
		      v3 = this;
		    }
		    m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages;
		    if ( !m_RenderStages )
		      goto LABEL_111;
		    v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		            m_RenderStages,
		            (Int32Enum__Enum)1u,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		    if ( !v16 )
		      goto LABEL_111;
		    v17 = (List_1_System_UInt64_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                     (VolumetricRenderer_VolumetricRenderStage *)v16,
		                                     0LL);
		    if ( !v17 )
		      goto LABEL_111;
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v72,
		      v17,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
		    *(_OWORD *)&v71._list = *(_OWORD *)&v72._dictionary;
		    v71._current = *(Object **)&v72._current.key;
		    *(_QWORD *)&v70.bEnableFraming = 0LL;
		    v70.volumetricComposeMaterial = (Material *)&v71;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v71,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		      {
		        if ( !v71._current )
		          sub_1800D8250(m_RenderStages, v18);
		        HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		          v3,
		          v3->fields.framingCompose,
		          EVolumetricStage__Enum_BeforeTemporal,
		          (IVolumetricRenderObject *)v71._current[7].monitor,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v84 )
		    {
		      framingCompose = (Dictionary_2_System_UInt64_System_Object_ *)v69;
		      *(Il2CppExceptionWrapper *)&v70.bEnableFraming = (Il2CppExceptionWrapper)v84->ex;
		      if ( *(_QWORD *)&v70.bEnableFraming )
		        sub_18007E1E0(*(_QWORD *)&v70.bEnableFraming);
		      v3 = this;
		LABEL_24:
		      m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages;
		      if ( m_RenderStages )
		      {
		        v19 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                m_RenderStages,
		                (Int32Enum__Enum)0,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( v19 )
		        {
		          v20 = (List_1_System_UInt64_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                           (VolumetricRenderer_VolumetricRenderStage *)v19,
		                                           0LL);
		          if ( v20 )
		          {
		            System::Collections::Generic::List<unsigned long>::GetEnumerator(
		              (List_1_T_Enumerator_System_UInt64_ *)&v72,
		              v20,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
		            *(_OWORD *)&v71._list = *(_OWORD *)&v72._dictionary;
		            v71._current = *(Object **)&v72._current.key;
		            *(_QWORD *)&v70.bEnableFraming = 0LL;
		            v70.volumetricComposeMaterial = (Material *)&v71;
		            try
		            {
		              while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                        &v71,
		                        MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		              {
		                if ( !v71._current )
		                  sub_1800D8250(v21, framingCompose);
		                HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		                  v3,
		                  v3->fields.framingCompose,
		                  EVolumetricStage__Enum_AfterTemporal,
		                  (IVolumetricRenderObject *)v71._current[7].monitor,
		                  0LL);
		              }
		            }
		            catch ( Il2CppExceptionWrapper *v85 )
		            {
		              framingCompose = (Dictionary_2_System_UInt64_System_Object_ *)v69;
		              *(Il2CppExceptionWrapper *)&v70.bEnableFraming = (Il2CppExceptionWrapper)v85->ex;
		              if ( *(_QWORD *)&v70.bEnableFraming )
		                sub_18007E1E0(*(_QWORD *)&v70.bEnableFraming);
		              v3 = this;
		            }
		            m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages;
		            if ( m_RenderStages )
		            {
		              v22 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                      m_RenderStages,
		                      (Int32Enum__Enum)3u,
		                      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		              if ( v22 )
		              {
		                v23 = (List_1_System_UInt64_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                                 (VolumetricRenderer_VolumetricRenderStage *)v22,
		                                                 0LL);
		                if ( v23 )
		                {
		                  System::Collections::Generic::List<unsigned long>::GetEnumerator(
		                    (List_1_T_Enumerator_System_UInt64_ *)&v72,
		                    v23,
		                    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
		                  *(_OWORD *)&v71._list = *(_OWORD *)&v72._dictionary;
		                  v71._current = *(Object **)&v72._current.key;
		                  *(_QWORD *)&v70.bEnableFraming = 0LL;
		                  v70.volumetricComposeMaterial = (Material *)&v71;
		                  try
		                  {
		                    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                              &v71,
		                              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		                    {
		                      if ( !v71._current )
		                        sub_1800D8250(m_RenderStages, v24);
		                      HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		                        v3,
		                        v3->fields.framingCompose,
		                        EVolumetricStage__Enum_AfterTemporal,
		                        (IVolumetricRenderObject *)v71._current[7].monitor,
		                        0LL);
		                    }
		                  }
		                  catch ( Il2CppExceptionWrapper *v86 )
		                  {
		                    *(Il2CppExceptionWrapper *)&v70.bEnableFraming = (Il2CppExceptionWrapper)v86->ex;
		                    m_RenderStages = *(Dictionary_2_System_Int32Enum_System_Object_ **)&v70.bEnableFraming;
		                    if ( *(_QWORD *)&v70.bEnableFraming )
		                      sub_18007E1E0(*(_QWORD *)&v70.bEnableFraming);
		                    v3 = this;
		                  }
		                  goto LABEL_42;
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_111:
		      sub_1800D8250(m_RenderStages, framingCompose);
		    }
		  }
		LABEL_42:
		  framingCompose = (Dictionary_2_System_UInt64_System_Object_ *)v3->fields.framingCompose;
		  if ( !framingCompose )
		    goto LABEL_111;
		  System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		    (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v72,
		    framingCompose,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
		  v80 = v72;
		  v78 = 0LL;
		  v79 = &v80;
		  try
		  {
		    while ( 1 )
		    {
		      do
		      {
		        if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v80,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext) )
		          return;
		        current = v80._current;
		        *(KeyValuePair_2_System_Int32Enum_System_Object_ *)key = v80._current;
		        v28 = _mm_srli_si128((__m128i)v80._current, 8).m128i_u64[0];
		        if ( !v28 )
		          sub_1800D8250(v26, v25);
		      }
		      while ( !*(_DWORD *)(v28 + 24) );
		      DefaultFramingComposeItem = HG::Rendering::Runtime::VolumetricRenderer::GetDefaultFramingComposeItem(
		                                    v90,
		                                    v3,
		                                    inputs->volumetricComposeMaterial,
		                                    0LL);
		      v31 = *(_OWORD *)&DefaultFramingComposeItem->Callback;
		      *(_OWORD *)&v81.Callback = *(_OWORD *)&DefaultFramingComposeItem->Callback;
		      v32 = *(_OWORD *)&DefaultFramingComposeItem->bounds.enableBounds;
		      *(_OWORD *)&v81.bounds.enableBounds = v32;
		      v33 = *(_OWORD *)&DefaultFramingComposeItem->bounds.worldBounds.m_Extents.x;
		      *(_OWORD *)&v81.bounds.worldBounds.m_Extents.x = v33;
		      v34 = *(__m128i *)&DefaultFramingComposeItem->SortingOrder;
		      *(__m128i *)&v81.SortingOrder = v34;
		      v35 = *(__m128i *)&DefaultFramingComposeItem->bPureBlit;
		      *(__m128i *)&v81.bPureBlit = v35;
		      meshFilter = DefaultFramingComposeItem->meshFilter;
		      v81.meshFilter = meshFilter;
		      v37 = 0LL;
		      v93 = 0LL;
		      v38 = (List_1_System_UInt64_ *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
		      if ( !v38 )
		        sub_1800D8250(v30, 0LL);
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v72,
		        v38,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
		      *(_OWORD *)&v75._list = *(_OWORD *)&v72._dictionary;
		      v75._current = *(Object **)&v72._current.key;
		      ex = 0LL;
		      v77 = &v75;
		      try
		      {
		LABEL_49:
		        v39 = _mm_cvtsi128_si32(_mm_srli_si128(v34, 12));
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v75,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		        {
		          v41 = v75._current;
		          if ( v75._current )
		          {
		            v73 = 0LL;
		            v74 = 0LL;
		            LOWORD(v73) = *(_WORD *)&v3->fields.m_EnableFraming;
		            *((_QWORD *)&v73 + 1) = inputs->volumetricComposeMaterial;
		            v42 = (unsigned int)dword_18F35FD08;
		            if ( dword_18F35FD08 )
		            {
		              v43 = ((((unsigned __int64)&v73 + 8) >> 12) & 0x1FFFFF) >> 6;
		              _m_prefetchw(&qword_18F0BCBA0[v43 + 36190]);
		              do
		                v44 = qword_18F0BCBA0[v43 + 36190];
		              while ( v44 != _InterlockedCompareExchange64(
		                               &qword_18F0BCBA0[v43 + 36190],
		                               v44 | (1LL << ((((unsigned __int64)&v73 + 8) >> 12) & 0x3F)),
		                               v44) );
		              v42 = (unsigned int)dword_18F35FD08;
		            }
		            volumetricParameters = inputs->volumetricParameters;
		            v74 = volumetricParameters;
		            if ( (_DWORD)v42 )
		            {
		              v46 = (((unsigned __int64)&v74 >> 12) & 0x1FFFFF) >> 6;
		              v42 = ((unsigned __int64)&v74 >> 12) & 0x3F;
		              _m_prefetchw(&qword_18F0BCBA0[v46 + 36190]);
		              do
		                v47 = qword_18F0BCBA0[v46 + 36190];
		              while ( v47 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v46 + 36190], v47 | (1LL << v42), v47) );
		              volumetricParameters = v74;
		            }
		            if ( !v41 )
		              sub_1800D8250(volumetricParameters, v42);
		            LOWORD(v72._dictionary) = v73;
		            *(_DWORD *)((char *)&v72._dictionary + 2) = *(_DWORD *)((char *)&v73 + 2);
		            HIWORD(v72._dictionary) = WORD3(v73);
		            *(_QWORD *)&v72._version = *((_QWORD *)&v73 + 1);
		            *(_QWORD *)&v72._current.key = volumetricParameters;
		            v48 = *(_DWORD *)&v41->klass->_1.method_count - 3434;
		            *(_OWORD *)&v70.bEnableFraming = *(_OWORD *)&v72._dictionary;
		            v70.volumetricSettings = volumetricParameters;
		            if ( v48 )
		              v49 = v48 == 1
		                  ? HG::Rendering::Runtime::VolumetricCloudSDF::OverrideFramingCompose(
		                      (VolumetricCloudSDF *)v41,
		                      &v70,
		                      &v89,
		                      0LL)
		                  : sub_1808B27CC(4, v48, (_DWORD)v41, (unsigned int)&v70, (__int64)&v89);
		            else
		              v49 = HG::Rendering::Runtime::VolumetricRenderObject::OverrideFramingCompose(
		                      (VolumetricRenderObject *)v41,
		                      &v70,
		                      &v89,
		                      0LL);
		            if ( v49 && v89.ComposePriority > v39 )
		            {
		              v31 = *(_OWORD *)&v89.Callback;
		              v81 = v89;
		              v32 = *(_OWORD *)&v89.bounds.enableBounds;
		              v33 = *(_OWORD *)&v89.bounds.worldBounds.m_Extents.x;
		              v34 = *(__m128i *)&v89.SortingOrder;
		              v35 = *(__m128i *)&v89.bPureBlit;
		              meshFilter = v89.meshFilter;
		              v37 = v41;
		              v93 = v41;
		              goto LABEL_49;
		            }
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v87 )
		      {
		        v40 = v69;
		        ex = v87->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v3 = this;
		        meshFilter = v81.meshFilter;
		        v35 = *(__m128i *)&v81.bPureBlit;
		        v34 = *(__m128i *)&v81.SortingOrder;
		        v33 = *(_OWORD *)&v81.bounds.worldBounds.m_Extents.x;
		        v32 = *(_OWORD *)&v81.bounds.enableBounds;
		        v31 = *(_OWORD *)&v81.Callback;
		        v37 = v93;
		      }
		      if ( !(unsigned __int8)_mm_cvtsi128_si32(v35) )
		        break;
		      v50 = (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages;
		      if ( !v50 )
		        sub_1800D8250(0LL, v40);
		      v51 = key[0];
		      v52 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		              v50,
		              key[0],
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( !v52 )
		        sub_1800D8250(v54, v53);
		      if ( LOBYTE(v52[2].klass) )
		      {
		LABEL_77:
		        RenderNodeFromPool = HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(v3, 0LL);
		        v58 = RenderNodeFromPool;
		        if ( !RenderNodeFromPool )
		          sub_1800D8250(v57, v56);
		        *(_OWORD *)&v90[0].Callback = v31;
		        *(_OWORD *)&v90[0].bounds.enableBounds = v32;
		        *(_OWORD *)&v90[0].bounds.worldBounds.m_Extents.x = v33;
		        *(__m128i *)&v90[0].SortingOrder = v34;
		        *(__m128i *)&v90[0].bPureBlit = v35;
		        v90[0].meshFilter = meshFilter;
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(RenderNodeFromPool, v90, 0LL);
		        v58->fields._RenderObject_k__BackingField = (IVolumetricRenderObject *)v37;
		        if ( dword_18F35FD08 )
		        {
		          v60 = (((unsigned __int64)&v58->fields._RenderObject_k__BackingField >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v60 + 36190]);
		          do
		            v61 = qword_18F0BCBA0[v60 + 36190];
		          while ( v61 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v60 + 36190],
		                           v61 | (1LL << (((unsigned __int64)&v58->fields._RenderObject_k__BackingField >> 12) & 0x3F)),
		                           v61) );
		        }
		        v58->fields._bComposePass_k__BackingField = 1;
		        v62 = (Dictionary_2_System_Int32Enum_System_Object_ *)v3->fields.m_RenderStages;
		        if ( !v62 )
		          sub_1800D8250(0LL, v59);
		        v63 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                v62,
		                v51,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( !v63 )
		          sub_1800D8250(v65, v64);
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
		          (VolumetricRenderer_VolumetricRenderStage *)v63,
		          v58,
		          0LL);
		      }
		    }
		    v51 = key[0];
		    goto LABEL_77;
		  }
		  catch ( Il2CppExceptionWrapper *v88 )
		  {
		    v78 = v88->ex;
		    if ( v78 )
		      sub_18007E1E0(v78);
		  }
		}
		
		private void ProcessTemporalCompose(ref VolumetricRenderInputs inputs) {} // 0x0000000189C57CFC-0x0000000189C587FC
		// Void ProcessTemporalCompose(VolumetricRenderInputs ByRef)
		// Hidden C++ exception states: #wind=5
		void HG::Rendering::Runtime::VolumetricRenderer::ProcessTemporalCompose(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  VolumetricRenderInputs *v3; // r15
		  VolumetricRenderer *v4; // rbx
		  __int64 v5; // rdx
		  Dictionary_2_System_Int32Enum_System_Object_ *m_RenderStages; // rcx
		  Object *Item; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *RenderNodes; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Dictionary_2_System_UInt64_System_Object_ *temporalCompose; // rdx
		  __int64 v14; // rcx
		  Object *v15; // rax
		  List_1_System_UInt64_ *v16; // rax
		  __int64 v17; // rcx
		  Object *v18; // rax
		  List_1_System_UInt64_ *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
		  unsigned __int64 v24; // xmm0_8
		  VolumetricRenderer_VolumetricRenderItem *DefaultTemporalComposeItem; // rax
		  __int64 v26; // rcx
		  __int128 v27; // xmm9
		  __int128 v28; // xmm10
		  __int128 v29; // xmm11
		  __m128i v30; // xmm7
		  __m128i v31; // xmm8
		  MeshFilter *meshFilter; // xmm12_8
		  Object *v33; // r12
		  List_1_System_UInt64_ *v34; // rdx
		  int32_t v35; // esi
		  unsigned __int64 v36; // rdx
		  Object *v37; // rdi
		  int v38; // eax
		  unsigned __int64 v39; // r8
		  signed __int64 v40; // rtt
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
		  unsigned __int64 v42; // r8
		  signed __int64 v43; // rtt
		  int v44; // edx
		  char v45; // al
		  Dictionary_2_System_Int32Enum_System_Object_ *v46; // rcx
		  Int32Enum__Enum v47; // esi
		  Object *v48; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  VolumetricRenderer_VolumetricRenderNode *RenderNodeFromPool; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  VolumetricRenderer_VolumetricRenderNode *v54; // rdi
		  __int64 v55; // rdx
		  unsigned __int64 v56; // r9
		  signed __int64 v57; // rtt
		  Dictionary_2_System_Int32Enum_System_Object_ *v58; // rcx
		  Object *v59; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  _BYTE v65[32]; // [rsp+0h] [rbp-308h] BYREF
		  VolumetricRenderer_VolumetricComposeContext v66; // [rsp+30h] [rbp-2D8h] BYREF
		  List_1_T_Enumerator_System_Object_ v67; // [rsp+50h] [rbp-2B8h] BYREF
		  __int128 v68; // [rsp+68h] [rbp-2A0h] BYREF
		  HGVolumetricCloudSettingParameters *v69; // [rsp+78h] [rbp-290h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v70; // [rsp+80h] [rbp-288h] BYREF
		  List_1_T_Enumerator_System_Object_ v71; // [rsp+B0h] [rbp-258h] BYREF
		  Il2CppException *ex; // [rsp+C8h] [rbp-240h]
		  List_1_T_Enumerator_System_Object_ *v73; // [rsp+D0h] [rbp-238h]
		  Il2CppException *v74; // [rsp+D8h] [rbp-230h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v75; // [rsp+E0h] [rbp-228h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v76; // [rsp+E8h] [rbp-220h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v77; // [rsp+110h] [rbp-1F8h]
		  Int32Enum__Enum key[4]; // [rsp+170h] [rbp-198h]
		  Il2CppExceptionWrapper *v79; // [rsp+180h] [rbp-188h] BYREF
		  Il2CppExceptionWrapper *v80; // [rsp+188h] [rbp-180h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+190h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v82; // [rsp+198h] [rbp-170h] BYREF
		  Il2CppExceptionWrapper *v83; // [rsp+1A0h] [rbp-168h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v84; // [rsp+1B0h] [rbp-158h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v85[2]; // [rsp+210h] [rbp-F8h] BYREF
		  Object *v88; // [rsp+328h] [rbp+20h]
		
		  v3 = inputs;
		  v4 = this;
		  memset(&v67, 0, sizeof(v67));
		  memset(&v76, 0, sizeof(v76));
		  memset(&v71, 0, sizeof(v71));
		  sub_18033B9D0(&v84, 0LL, 88LL);
		  v68 = 0LL;
		  v69 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5196, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5196, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v64, v63);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)v4, v3, 0LL);
		    return;
		  }
		  HG::Rendering::Runtime::VolumetricRenderer::ClearComposeCache(v4, v4->fields.temporalCompose, 0LL);
		  if ( v4->fields.m_EnableTAA )
		  {
		    if ( !v4->fields.m_RenderStages )
		      sub_1800D8260(m_RenderStages, v5);
		    Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		             (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages,
		             (Int32Enum__Enum)0,
		             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		    if ( !Item )
		      sub_1800D8260(v9, v8);
		    RenderNodes = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                    (VolumetricRenderer_VolumetricRenderStage *)Item,
		                    0LL);
		    if ( !RenderNodes )
		      sub_1800D8260(v12, v11);
		    v67 = *(List_1_T_Enumerator_System_Object_ *)sub_1808B28A0(&v70, RenderNodes);
		    *(_QWORD *)&v66.bEnableFraming = 0LL;
		    v66.volumetricComposeMaterial = (Material *)&v67;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v67,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		      {
		        if ( !v67._current )
		          sub_1800D8250(v14, temporalCompose);
		        HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		          v4,
		          v4->fields.temporalCompose,
		          EVolumetricStage__Enum_AfterTemporal,
		          (IVolumetricRenderObject *)v67._current[7].monitor,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v79 )
		    {
		      temporalCompose = (Dictionary_2_System_UInt64_System_Object_ *)v65;
		      *(Il2CppExceptionWrapper *)&v66.bEnableFraming = (Il2CppExceptionWrapper)v79->ex;
		      if ( *(_QWORD *)&v66.bEnableFraming )
		        sub_18007E1E0(*(_QWORD *)&v66.bEnableFraming);
		      v3 = inputs;
		      v4 = this;
		    }
		    m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		    if ( !m_RenderStages )
		      goto LABEL_95;
		    v15 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		            m_RenderStages,
		            (Int32Enum__Enum)1u,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		    if ( !v15 )
		      goto LABEL_95;
		    v16 = (List_1_System_UInt64_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                     (VolumetricRenderer_VolumetricRenderStage *)v15,
		                                     0LL);
		    if ( !v16 )
		      goto LABEL_95;
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v70,
		      v16,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
		    *(_OWORD *)&v67._list = *(_OWORD *)&v70._dictionary;
		    v67._current = *(Object **)&v70._current.key;
		    *(_QWORD *)&v66.bEnableFraming = 0LL;
		    v66.volumetricComposeMaterial = (Material *)&v67;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v67,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		      {
		        if ( !v67._current )
		          sub_1800D8250(v17, temporalCompose);
		        HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		          v4,
		          v4->fields.temporalCompose,
		          EVolumetricStage__Enum_AfterTemporal,
		          (IVolumetricRenderObject *)v67._current[7].monitor,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v80 )
		    {
		      temporalCompose = (Dictionary_2_System_UInt64_System_Object_ *)v65;
		      *(Il2CppExceptionWrapper *)&v66.bEnableFraming = (Il2CppExceptionWrapper)v80->ex;
		      if ( *(_QWORD *)&v66.bEnableFraming )
		        sub_18007E1E0(*(_QWORD *)&v66.bEnableFraming);
		      v3 = inputs;
		      v4 = this;
		    }
		    m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		    if ( !m_RenderStages
		      || (v18 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                  m_RenderStages,
		                  (Int32Enum__Enum)3u,
		                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item)) == 0LL
		      || (v19 = (List_1_System_UInt64_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                           (VolumetricRenderer_VolumetricRenderStage *)v18,
		                                           0LL)) == 0LL )
		    {
		LABEL_95:
		      sub_1800D8250(m_RenderStages, temporalCompose);
		    }
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v70,
		      v19,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
		    *(_OWORD *)&v67._list = *(_OWORD *)&v70._dictionary;
		    v67._current = *(Object **)&v70._current.key;
		    *(_QWORD *)&v66.bEnableFraming = 0LL;
		    v66.volumetricComposeMaterial = (Material *)&v67;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v67,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		      {
		        if ( !v67._current )
		          sub_1800D8250(m_RenderStages, v20);
		        HG::Rendering::Runtime::VolumetricRenderer::AddToComposeCache(
		          v4,
		          v4->fields.temporalCompose,
		          EVolumetricStage__Enum_AfterTemporal,
		          (IVolumetricRenderObject *)v67._current[7].monitor,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v81 )
		    {
		      *(Il2CppExceptionWrapper *)&v66.bEnableFraming = (Il2CppExceptionWrapper)v81->ex;
		      m_RenderStages = *(Dictionary_2_System_Int32Enum_System_Object_ **)&v66.bEnableFraming;
		      if ( *(_QWORD *)&v66.bEnableFraming )
		        sub_18007E1E0(*(_QWORD *)&v66.bEnableFraming);
		      v3 = inputs;
		      v4 = this;
		    }
		  }
		  temporalCompose = (Dictionary_2_System_UInt64_System_Object_ *)v4->fields.temporalCompose;
		  if ( !temporalCompose )
		    goto LABEL_95;
		  System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		    (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v70,
		    temporalCompose,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::GetEnumerator);
		  v76 = v70;
		  v74 = 0LL;
		  v75 = &v76;
		  try
		  {
		    while ( 1 )
		    {
		      do
		      {
		        if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v76,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>>::MoveNext) )
		          return;
		        current = v76._current;
		        *(KeyValuePair_2_System_Int32Enum_System_Object_ *)key = v76._current;
		        v24 = _mm_srli_si128((__m128i)v76._current, 8).m128i_u64[0];
		        if ( !v24 )
		          sub_1800D8250(v22, v21);
		      }
		      while ( !*(_DWORD *)(v24 + 24) );
		      DefaultTemporalComposeItem = HG::Rendering::Runtime::VolumetricRenderer::GetDefaultTemporalComposeItem(
		                                     v85,
		                                     v4,
		                                     v3->volumetricComposeMaterial,
		                                     0LL);
		      v27 = *(_OWORD *)&DefaultTemporalComposeItem->Callback;
		      *(_OWORD *)&v77.Callback = *(_OWORD *)&DefaultTemporalComposeItem->Callback;
		      v28 = *(_OWORD *)&DefaultTemporalComposeItem->bounds.enableBounds;
		      *(_OWORD *)&v77.bounds.enableBounds = v28;
		      v29 = *(_OWORD *)&DefaultTemporalComposeItem->bounds.worldBounds.m_Extents.x;
		      *(_OWORD *)&v77.bounds.worldBounds.m_Extents.x = v29;
		      v30 = *(__m128i *)&DefaultTemporalComposeItem->SortingOrder;
		      *(__m128i *)&v77.SortingOrder = v30;
		      v31 = *(__m128i *)&DefaultTemporalComposeItem->bPureBlit;
		      *(__m128i *)&v77.bPureBlit = v31;
		      meshFilter = DefaultTemporalComposeItem->meshFilter;
		      v77.meshFilter = meshFilter;
		      v33 = 0LL;
		      v88 = 0LL;
		      v34 = (List_1_System_UInt64_ *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
		      if ( !v34 )
		        sub_1800D8250(v26, 0LL);
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v70,
		        v34,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
		      *(_OWORD *)&v71._list = *(_OWORD *)&v70._dictionary;
		      v71._current = *(Object **)&v70._current.key;
		      ex = 0LL;
		      v73 = &v71;
		      try
		      {
		LABEL_37:
		        v35 = _mm_cvtsi128_si32(_mm_srli_si128(v30, 12));
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v71,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		        {
		          v37 = v71._current;
		          if ( v71._current )
		          {
		            v68 = 0LL;
		            v69 = 0LL;
		            LOWORD(v68) = *(_WORD *)&v4->fields.m_EnableFraming;
		            *((_QWORD *)&v68 + 1) = v3->volumetricComposeMaterial;
		            v38 = dword_18F35FD08;
		            if ( dword_18F35FD08 )
		            {
		              v39 = ((((unsigned __int64)&v68 + 8) >> 12) & 0x1FFFFF) >> 6;
		              v36 = (((unsigned __int64)&v68 + 8) >> 12) & 0x3F;
		              _m_prefetchw(&qword_18F0BCBA0[v39 + 36190]);
		              do
		                v40 = qword_18F0BCBA0[v39 + 36190];
		              while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v39 + 36190], v40 | (1LL << v36), v40) );
		              v38 = dword_18F35FD08;
		            }
		            volumetricParameters = v3->volumetricParameters;
		            v69 = volumetricParameters;
		            if ( v38 )
		            {
		              v42 = (((unsigned __int64)&v69 >> 12) & 0x1FFFFF) >> 6;
		              v36 = ((unsigned __int64)&v69 >> 12) & 0x3F;
		              _m_prefetchw(&qword_18F0BCBA0[v42 + 36190]);
		              do
		                v43 = qword_18F0BCBA0[v42 + 36190];
		              while ( v43 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v42 + 36190], v43 | (1LL << v36), v43) );
		              volumetricParameters = v69;
		            }
		            if ( !v37 )
		              sub_1800D8250(volumetricParameters, v36);
		            LOWORD(v70._dictionary) = v68;
		            *(_DWORD *)((char *)&v70._dictionary + 2) = *(_DWORD *)((char *)&v68 + 2);
		            HIWORD(v70._dictionary) = WORD3(v68);
		            *(_QWORD *)&v70._version = *((_QWORD *)&v68 + 1);
		            *(_QWORD *)&v70._current.key = volumetricParameters;
		            v44 = *(_DWORD *)&v37->klass->_1.method_count - 3434;
		            *(_OWORD *)&v66.bEnableFraming = *(_OWORD *)&v70._dictionary;
		            v66.volumetricSettings = volumetricParameters;
		            if ( v44 )
		              v45 = v44 == 1
		                  ? HG::Rendering::Runtime::VolumetricCloudSDF::OverrideTemporalCompose(
		                      (VolumetricCloudSDF *)v37,
		                      &v66,
		                      &v84,
		                      0LL)
		                  : sub_1808B27CC(5, v44, (_DWORD)v37, (unsigned int)&v66, (__int64)&v84);
		            else
		              v45 = HG::Rendering::Runtime::VolumetricRenderObject::OverrideTemporalCompose(
		                      (VolumetricRenderObject *)v37,
		                      &v66,
		                      &v84,
		                      0LL);
		            if ( v45 && v84.ComposePriority > v35 )
		            {
		              v27 = *(_OWORD *)&v84.Callback;
		              v77 = v84;
		              v28 = *(_OWORD *)&v84.bounds.enableBounds;
		              v29 = *(_OWORD *)&v84.bounds.worldBounds.m_Extents.x;
		              v30 = *(__m128i *)&v84.SortingOrder;
		              v31 = *(__m128i *)&v84.bPureBlit;
		              meshFilter = v84.meshFilter;
		              v33 = v37;
		              v88 = v37;
		              goto LABEL_37;
		            }
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v82 )
		      {
		        v36 = (unsigned __int64)v65;
		        ex = v82->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v3 = inputs;
		        v4 = this;
		        meshFilter = v77.meshFilter;
		        v31 = *(__m128i *)&v77.bPureBlit;
		        v30 = *(__m128i *)&v77.SortingOrder;
		        v29 = *(_OWORD *)&v77.bounds.worldBounds.m_Extents.x;
		        v28 = *(_OWORD *)&v77.bounds.enableBounds;
		        v27 = *(_OWORD *)&v77.Callback;
		        v33 = v88;
		      }
		      if ( !(unsigned __int8)_mm_cvtsi128_si32(v31) )
		        break;
		      v46 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		      if ( !v46 )
		        sub_1800D8250(0LL, v36);
		      v47 = key[0];
		      v48 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		              v46,
		              key[0],
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( !v48 )
		        sub_1800D8250(v50, v49);
		      if ( LOBYTE(v48[2].klass) )
		      {
		LABEL_65:
		        RenderNodeFromPool = HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(v4, 0LL);
		        v54 = RenderNodeFromPool;
		        if ( !RenderNodeFromPool )
		          sub_1800D8250(v53, v52);
		        *(_OWORD *)&v85[0].Callback = v27;
		        *(_OWORD *)&v85[0].bounds.enableBounds = v28;
		        *(_OWORD *)&v85[0].bounds.worldBounds.m_Extents.x = v29;
		        *(__m128i *)&v85[0].SortingOrder = v30;
		        *(__m128i *)&v85[0].bPureBlit = v31;
		        v85[0].meshFilter = meshFilter;
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(RenderNodeFromPool, v85, 0LL);
		        v54->fields._RenderObject_k__BackingField = (IVolumetricRenderObject *)v33;
		        if ( dword_18F35FD08 )
		        {
		          v56 = (((unsigned __int64)&v54->fields._RenderObject_k__BackingField >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v56 + 36190]);
		          do
		            v57 = qword_18F0BCBA0[v56 + 36190];
		          while ( v57 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v56 + 36190],
		                           v57 | (1LL << (((unsigned __int64)&v54->fields._RenderObject_k__BackingField >> 12) & 0x3F)),
		                           v57) );
		        }
		        v54->fields._bComposePass_k__BackingField = 1;
		        v58 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		        if ( !v58 )
		          sub_1800D8250(0LL, v55);
		        v59 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                v58,
		                v47,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( !v59 )
		          sub_1800D8250(v61, v60);
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
		          (VolumetricRenderer_VolumetricRenderStage *)v59,
		          v54,
		          0LL);
		      }
		    }
		    v47 = key[0];
		    goto LABEL_65;
		  }
		  catch ( Il2CppExceptionWrapper *v83 )
		  {
		    v74 = v83->ex;
		    if ( v74 )
		      sub_18007E1E0(v74);
		  }
		}
		
		private bool HasOffScreenPassBefore(VolumetricRenderNode target) => default; // 0x0000000189C56E7C-0x0000000189C56FC8
		// Boolean HasOffScreenPassBefore(VolumetricRenderer+VolumetricRenderNode)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		bool HG::Rendering::Runtime::VolumetricRenderer::HasOffScreenPassBefore(
		        VolumetricRenderer *this,
		        VolumetricRenderer_VolumetricRenderNode *target,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  char v7; // bl
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *m_RenderNodes; // rdi
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  _QWORD v14[3]; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v15; // [rsp+40h] [rbp-28h] BYREF
		
		  memset(&v15, 0, sizeof(v15));
		  if ( IFix::WrappersManagerImpl::IsPatched(5207, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5207, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)target,
		             0LL);
		  }
		  else
		  {
		    v7 = 0;
		    m_RenderNodes = this->fields.m_RenderNodes;
		    if ( !m_RenderNodes )
		      sub_1800D8260(v6, v5);
		    v15 = *(List_1_T_Enumerator_System_Object_ *)sub_1808B28A0(v14, m_RenderNodes);
		    v14[0] = 0LL;
		    v14[1] = &v15;
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v15,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext)
		         && target != (VolumetricRenderer_VolumetricRenderNode *)v15._current )
		    {
		      if ( !v15._current )
		        sub_1800D8250(0LL, v9);
		      v7 |= HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_IsAdded(
		              (VolumetricRenderer_VolumetricRenderNode *)v15._current,
		              0LL);
		    }
		    return v7;
		  }
		}
		
		private void ProcessPassMerge(ref VolumetricRenderInputs inputs) {} // 0x0000000189C57C18-0x0000000189C57CFC
		// Void ProcessPassMerge(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::ProcessPassMerge(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  bool v6; // bl
		  void *m_RenderStages; // rcx
		  Object *Item; // rax
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *RenderNodes; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5201, 0LL) )
		  {
		    m_RenderStages = this->fields.m_RenderStages;
		    if ( m_RenderStages )
		    {
		      Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		               (Dictionary_2_System_Int32Enum_System_Object_ *)m_RenderStages,
		               (Int32Enum__Enum)1u,
		               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( Item )
		      {
		        RenderNodes = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                        (VolumetricRenderer_VolumetricRenderStage *)Item,
		                        0LL);
		        if ( RenderNodes )
		        {
		          if ( RenderNodes->fields._size != 1 || !this->fields.m_EnableTAA )
		            goto LABEL_11;
		          m_RenderStages = inputs->volumetricParameters;
		          if ( m_RenderStages )
		          {
		            if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                   *((SettingParameter_1_System_Boolean_ **)m_RenderStages + 17),
		                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		            {
		LABEL_11:
		              this->fields.m_CanMergeTAAPass = v6;
		              return;
		            }
		            m_RenderStages = inputs->volumetricParameters;
		            if ( m_RenderStages )
		            {
		              v6 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                      *((SettingParameter_1_System_Boolean_ **)m_RenderStages + 18),
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              goto LABEL_11;
		            }
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(m_RenderStages, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5201, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		}
		
		private void UpdateVolumetricRenderPipeline(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5D19C-0x0000000189C5D874
		// Void UpdateVolumetricRenderPipeline(VolumetricRenderInputs ByRef)
		// Hidden C++ exception states: #wind=2 #try_helpers=1
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRenderPipeline(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  VolumetricRenderInputs *v3; // r13
		  VolumetricRenderer *v4; // rdi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object *Item; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Dictionary_2_System_UInt64_System_Object_ *v10; // rdx
		  Dictionary_2_System_Int32Enum_System_Object_ *v11; // rcx
		  Object *current; // rsi
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Dictionary_2_System_Int32Enum_System_Object_ *m_RenderStages; // rcx
		  Object *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Dictionary_2_System_Int32Enum_System_Object_ *v19; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  bool bEnableTAA; // al
		  __int64 v23; // rdx
		  Dictionary_2_System_Int32Enum_System_Object_ *v24; // rcx
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *m_RenderNodes; // rax
		  Object *v30; // rax
		  Object *v31; // rax
		  bool v32; // al
		  Object *v33; // rax
		  IEnumerable_1_System_Object_ *RenderNodes; // r15
		  Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *_9__75_0; // r14
		  Object *v36; // rsi
		  Func_2_Object_Boolean_ *v37; // rax
		  unsigned __int64 v38; // r8
		  unsigned __int64 v39; // rdx
		  signed __int64 v40; // rtt
		  Object *v41; // rax
		  bool v42; // al
		  Object *v43; // rax
		  IEnumerable_1_System_Object_ *v44; // r12
		  Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *_9__75_1; // r14
		  Object *v46; // r15
		  Func_2_Object_Boolean_ *v47; // rax
		  unsigned __int64 v48; // r9
		  unsigned __int64 v49; // r8
		  signed __int64 v50; // rtt
		  __int64 v51; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v55; // [rsp+20h] [rbp-A8h] BYREF
		  List_1_T_Enumerator_System_Object_ v56; // [rsp+48h] [rbp-80h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v57; // [rsp+60h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v58; // [rsp+90h] [rbp-38h] BYREF
		
		  v3 = inputs;
		  v4 = this;
		  memset(&v56, 0, sizeof(v56));
		  memset(&v57, 0, sizeof(v57));
		  if ( !IFix::WrappersManagerImpl::IsPatched(5173, 0LL) )
		  {
		    HG::Rendering::Runtime::VolumetricRenderer::DisableAllStages(v4, 0LL);
		    if ( v4->fields.m_EnableTAA )
		    {
		      if ( !v4->fields.m_RenderStages )
		        sub_1800D8260(v6, v5);
		      Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		               (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages,
		               (Int32Enum__Enum)2u,
		               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( !Item )
		        sub_1800D8260(v9, v8);
		      HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SetEnable(
		        (VolumetricRenderer_VolumetricRenderStage *)Item,
		        0LL);
		    }
		    if ( !v4->fields.m_RenderNodes )
		      sub_1800D8260(v6, v5);
		    v56 = *(List_1_T_Enumerator_System_Object_ *)sub_1808B28A0(&v55, v4->fields.m_RenderNodes);
		    v55._dictionary = 0LL;
		    *(_QWORD *)&v55._version = &v56;
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v56,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		    {
		      current = v56._current;
		      if ( !v56._current )
		        sub_1800D8250(v11, v10);
		      if ( HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableFraming(
		             (VolumetricRenderer_VolumetricRenderNode *)v56._current,
		             0LL)
		        && v4->fields.m_EnableFraming )
		      {
		        m_RenderStages = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		        if ( !m_RenderStages )
		          sub_1800D8250(0LL, v13);
		        v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                m_RenderStages,
		                (Int32Enum__Enum)0,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( !v16 )
		          sub_1800D8250(v18, v17);
		      }
		      else if ( v4->fields.m_EnableTAA )
		      {
		        if ( !current )
		          sub_1800D8250(v14, v13);
		        bEnableTAA = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableTAA(
		                       (VolumetricRenderer_VolumetricRenderNode *)current,
		                       0LL);
		        v24 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		        if ( bEnableTAA )
		        {
		          if ( !v24 )
		            sub_1800D8250(0LL, v23);
		          v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                  v24,
		                  (Int32Enum__Enum)1u,
		                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		          if ( !v16 )
		            sub_1800D8250(v28, v27);
		        }
		        else
		        {
		          if ( !v24 )
		            sub_1800D8250(0LL, v23);
		          v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                  v24,
		                  (Int32Enum__Enum)3u,
		                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		          if ( !v16 )
		            sub_1800D8250(v26, v25);
		        }
		      }
		      else
		      {
		        v19 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		        if ( !v19 )
		          sub_1800D8250(0LL, v13);
		        v16 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                v19,
		                (Int32Enum__Enum)3u,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( !v16 )
		          sub_1800D8250(v21, v20);
		      }
		      HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::AddRenderNode(
		        (VolumetricRenderer_VolumetricRenderStage *)v16,
		        (VolumetricRenderer_VolumetricRenderNode *)current,
		        0LL);
		    }
		    m_RenderNodes = v4->fields.m_RenderNodes;
		    if ( m_RenderNodes )
		    {
		      if ( m_RenderNodes->fields._size > 0 )
		      {
		        v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		        if ( !v11 )
		          goto LABEL_81;
		        v30 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                v11,
		                (Int32Enum__Enum)4u,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( !v30 )
		          goto LABEL_81;
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SetEnable(
		          (VolumetricRenderer_VolumetricRenderStage *)v30,
		          0LL);
		      }
		      v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		      if ( v11 )
		      {
		        v31 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                v11,
		                (Int32Enum__Enum)1u,
		                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		        if ( v31 )
		        {
		          if ( LOBYTE(v31[2].klass) )
		          {
		            v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		            if ( !v11 )
		              goto LABEL_81;
		            v33 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                    v11,
		                    (Int32Enum__Enum)1u,
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		            if ( !v33 )
		              goto LABEL_81;
		            RenderNodes = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                                            (VolumetricRenderer_VolumetricRenderStage *)v33,
		                                                            0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
		            _9__75_0 = TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_0;
		            if ( !_9__75_0 )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
		              v36 = (Object *)TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9;
		              v37 = (Func_2_Object_Boolean_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode,bool>);
		              _9__75_0 = (Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *)v37;
		              if ( !v37 )
		                goto LABEL_81;
		              System::Func<System::Object,bool>::Func(
		                v37,
		                v36,
		                MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c::_UpdateVolumetricRenderPipeline_b__75_0,
		                0LL);
		              TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_0 = _9__75_0;
		              if ( dword_18F35FD08 )
		              {
		                v38 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_0 >> 12) & 0x1FFFFF) >> 6;
		                v39 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_0 >> 12) & 0x3F;
		                _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		                do
		                  v40 = qword_18F0BCBA0[v38 + 36190];
		                while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v38 + 36190], v40 | (1LL << v39), v40) );
		              }
		            }
		            v32 = System::Linq::Enumerable::Any<System::Object>(
		                    RenderNodes,
		                    (Func_2_Object_Boolean_ *)_9__75_0,
		                    MethodInfo::System::Linq::Enumerable::Any<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
		          }
		          else
		          {
		            v32 = 0;
		          }
		          v4->fields.m_BeforeTAANeedDepthTest = v32;
		          v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		          if ( v11 )
		          {
		            v41 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                    v11,
		                    (Int32Enum__Enum)3u,
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		            if ( v41 )
		            {
		              if ( LOBYTE(v41[2].klass) )
		              {
		                v11 = (Dictionary_2_System_Int32Enum_System_Object_ *)v4->fields.m_RenderStages;
		                if ( !v11 )
		                  goto LABEL_81;
		                v43 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                        v11,
		                        (Int32Enum__Enum)3u,
		                        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		                if ( !v43 )
		                  goto LABEL_81;
		                v44 = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::get_RenderNodes(
		                                                        (VolumetricRenderer_VolumetricRenderStage *)v43,
		                                                        0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
		                _9__75_1 = TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_1;
		                if ( !_9__75_1 )
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c);
		                  v46 = (Object *)TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9;
		                  v47 = (Func_2_Object_Boolean_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode,bool>);
		                  _9__75_1 = (Func_2_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_Boolean_ *)v47;
		                  if ( !v47 )
		                    goto LABEL_81;
		                  System::Func<System::Object,bool>::Func(
		                    v47,
		                    v46,
		                    MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::__c::_UpdateVolumetricRenderPipeline_b__75_1,
		                    0LL);
		                  TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_1 = _9__75_1;
		                  if ( dword_18F35FD08 )
		                  {
		                    v48 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_1 >> 12) & 0x1FFFFF) >> 6;
		                    v49 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::VolumetricRenderer::__c->static_fields->__9__75_1 >> 12) & 0x3F;
		                    _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		                    do
		                      v50 = qword_18F0BCBA0[v48 + 36190];
		                    while ( v50 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v48 + 36190], v50 | (1LL << v49), v50) );
		                  }
		                }
		                v42 = System::Linq::Enumerable::Any<System::Object>(
		                        v44,
		                        (Func_2_Object_Boolean_ *)_9__75_1,
		                        MethodInfo::System::Linq::Enumerable::Any<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
		              }
		              else
		              {
		                v42 = 0;
		              }
		              v4->fields.m_AfterTAANeedDepthTest = v42;
		              HG::Rendering::Runtime::VolumetricRenderer::ProcessFramingCompose(v4, v3, 0LL);
		              HG::Rendering::Runtime::VolumetricRenderer::ProcessTemporalCompose(v4, v3, 0LL);
		              v10 = (Dictionary_2_System_UInt64_System_Object_ *)v4->fields.m_RenderStages;
		              if ( v10 )
		              {
		                System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		                  (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v55,
		                  v10,
		                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::GetEnumerator);
		                v57 = v55;
		                v55._dictionary = 0LL;
		                *(_QWORD *)&v55._version = &v57;
		                try
		                {
		                  while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                            &v57,
		                            MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::MoveNext) )
		                  {
		                    if ( !v57._current.value )
		                      sub_1800D8250(0LL, v51);
		                    HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::SortNodes(
		                      (VolumetricRenderer_VolumetricRenderStage *)v57._current.value,
		                      0LL);
		                  }
		                }
		                catch ( Il2CppExceptionWrapper *v58 )
		                {
		                  v55._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v58->ex;
		                  if ( v55._dictionary )
		                    sub_18007E1E0(v55._dictionary);
		                  v3 = inputs;
		                  v4 = this;
		                }
		                HG::Rendering::Runtime::VolumetricRenderer::ProcessPassMerge(v4, v3, 0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_81:
		    sub_1800D8250(v11, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5173, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v54, v53);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)v4, v3, 0LL);
		}
		
		private void UpdateVolumetricCameraVP(HGCamera hgCamera, HGRenderGraphContext context) {} // 0x0000000189C5C810-0x0000000189C5CBE8
		// Void UpdateVolumetricCameraVP(HGCamera, HGRenderGraphContext)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricCameraVP(
		        VolumetricRenderer *this,
		        HGCamera *hgCamera,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  __int64 v8; // rcx
		  Camera *camera; // rdi
		  float v10; // xmm11_4
		  float fieldOfView; // xmm6_4
		  float aspect; // xmm0_4
		  Matrix4x4 *v13; // rax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v18; // xmm6
		  __int128 v19; // xmm7
		  __int128 v20; // xmm8
		  __int128 v21; // xmm9
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  float v26; // xmm15_4
		  double v27; // xmm0_8
		  float v28; // xmm15_4
		  float v29; // xmm6_4
		  float v30; // xmm7_4
		  __int128 v31; // xmm6
		  CBHandle *ConstantBuffer; // rax
		  void *ptr; // xmm1_8
		  CommandBuffer *cmd; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t offset_8[4]; // [rsp+38h] [rbp-D0h] BYREF
		  void *v37; // [rsp+48h] [rbp-C0h]
		  float v38; // [rsp+50h] [rbp-B8h]
		  Matrix4x4 v39; // [rsp+58h] [rbp-B0h] BYREF
		  Matrix4x4 v40; // [rsp+98h] [rbp-70h] BYREF
		  Matrix4x4 v41; // [rsp+F8h] [rbp-10h]
		  _OWORD v42[2]; // [rsp+138h] [rbp+30h] BYREF
		  Matrix4x4 v43; // [rsp+158h] [rbp+50h]
		  CBHandle v44[7]; // [rsp+198h] [rbp+90h] BYREF
		
		  *(_QWORD *)&offset_8[2] = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5154, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		      {
		        v10 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		        fieldOfView = UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		        aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
		        v13 = UnityEngine::Matrix4x4::Perspective(&v40, fieldOfView, aspect, v10, 10000.0, 0LL);
		        v14 = *(_OWORD *)&v13->m01;
		        *(_OWORD *)&v39.m00 = *(_OWORD *)&v13->m00;
		        v15 = *(_OWORD *)&v13->m02;
		        *(_OWORD *)&v39.m01 = v14;
		        v16 = *(_OWORD *)&v13->m03;
		        *(_OWORD *)&v39.m02 = v15;
		        *(_OWORD *)&v39.m03 = v16;
		        GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v40, &v39, 1, 0LL);
		        v18 = *(_OWORD *)&GPUProjectionMatrix->m00;
		        v19 = *(_OWORD *)&GPUProjectionMatrix->m01;
		        v20 = *(_OWORD *)&GPUProjectionMatrix->m02;
		        v21 = *(_OWORD *)&GPUProjectionMatrix->m03;
		        worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v40, camera, 0LL);
		        v23 = *(_OWORD *)&worldToCameraMatrix->m01;
		        *(_OWORD *)&v39.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		        v24 = *(_OWORD *)&worldToCameraMatrix->m02;
		        *(_OWORD *)&v39.m01 = v23;
		        v25 = *(_OWORD *)&worldToCameraMatrix->m03;
		        *(_OWORD *)&v39.m02 = v24;
		        *(_OWORD *)&v39.m03 = v25;
		        *(_OWORD *)&v40.m00 = v18;
		        *(_OWORD *)&v40.m01 = v19;
		        *(_OWORD *)&v40.m02 = v20;
		        *(_OWORD *)&v40.m03 = v21;
		        v41 = *UnityEngine::Matrix4x4::op_Multiply((Matrix4x4 *)v42, &v40, &v39, 0LL);
		        *(double *)&v24 = sub_1803367D0();
		        v26 = *(float *)&v24;
		        v27 = sub_1803367D0();
		        v38 = 1.0 / (float)(v26 - *(float *)&v27);
		        v28 = v26 - *(float *)&v27;
		        *(float *)&offset_8[1] = 10000.0 / v10;
		        v29 = 1.0 - (float)(10000.0 / v10);
		        *(float *)offset_8 = v29;
		        v30 = v29 / 10000.0;
		        *(float *)&offset_8[3] = (float)(10000.0 / v10) / 10000.0;
		        *(float *)&offset_8[2] = v29 / 10000.0;
		        if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
		        {
		          *(float *)offset_8 = -v29;
		          *(float *)&offset_8[2] = -v30;
		          *(float *)&offset_8[1] = (float)(10000.0 / v10) + v29;
		          *(float *)&offset_8[3] = (float)((float)(10000.0 / v10) / 10000.0) + v30;
		        }
		        v40.m01 = v38;
		        v40.m11 = (float)-*(float *)&v27 / v28;
		        v40.m21 = v28;
		        v40.m31 = *(float *)&v27;
		        v31 = *(_OWORD *)offset_8;
		        if ( context )
		        {
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                             v44,
		                             &context->fields.renderContext,
		                             96,
		                             0LL);
		          ptr = ConstantBuffer->ptr;
		          *(_OWORD *)offset_8 = *(_OWORD *)&ConstantBuffer->bufferId;
		          v37 = ptr;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          v42[1] = *(_OWORD *)&v40.m01;
		          v43 = v41;
		          v42[0] = v31;
		          sub_1808B2484(offset_8, v42);
		          cmd = context->fields.cmd;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		          if ( cmd )
		          {
		            UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		              cmd,
		              offset_8[0],
		              static_fields->_VolumetricComposeCB,
		              offset_8[1],
		              offset_8[2],
		              0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v8, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5154, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    (Object *)context,
		    0LL);
		}
		
		private void UpdateRenderStageAndDraw(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5AE74-0x0000000189C5C140
		// Void UpdateRenderStageAndDraw(VolumetricRenderInputs ByRef)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateRenderStageAndDraw(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  VolumetricRenderInputs *v3; // r14
		  VolumetricRenderer *v4; // rsi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGCamera *hgCamera; // r15
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rdx
		  unsigned __int64 m_KeywordSpace; // rcx
		  Object *current; // rbx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *itemCache; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  HGRenderGraphContext *context; // r8
		  __int64 m_Ptr; // r8
		  HGVolumetricCloudSettingParameters *volumetricParameters; // r9
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  int32_t i; // r13d
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *v22; // rax
		  bool bEnableFraming; // r15
		  HGVolumetricCloudSettingParameters *v24; // rcx
		  __int64 v25; // rdx
		  bool bEnableTAA; // r15
		  HGVolumetricCloudSettingParameters *v27; // rcx
		  VolumetricRenderer_VolumetricRenderNode *RenderNodeFromPool; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  Object *v31; // r15
		  unsigned __int64 v32; // rdx
		  signed __int64 v33; // rtt
		  List_1_System_Object_ *m_RenderNodes; // rcx
		  List_1_System_UInt64_ *v35; // rdx
		  __int64 v36; // rcx
		  Object *v37; // rbx
		  bool m_EnableFraming; // r15
		  bool m_EnableTAA; // r15
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  HGRenderGraphContext *v42; // rax
		  CommandBuffer *cmd; // r15
		  Material *material; // r13
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  HGRenderGraphContext *v47; // rax
		  CommandBuffer *v48; // r15
		  Material *v49; // rax
		  bool v50; // bl
		  bool v51; // bl
		  HGRenderGraphContext *v52; // r13
		  CommandBuffer *v53; // r13
		  int32_t DrawFrameCount_k__BackingField; // ebx
		  void (__fastcall *v55)(CommandBuffer *, _QWORD, _QWORD); // rax
		  unsigned int FrameCountMod16; // ecx
		  int32_t v57; // ebx
		  void (__fastcall *v58)(CommandBuffer *, _QWORD, _QWORD); // rax
		  unsigned int FrameCountMod32; // ecx
		  int32_t v60; // ebx
		  void (__fastcall *v61)(CommandBuffer *, _QWORD, _QWORD); // rax
		  HGVolumetricCloudSettingParameters *v62; // rax
		  unsigned int PixelSubOffset; // ecx
		  int32_t v64; // ebx
		  void (__fastcall *v65)(CommandBuffer *, _QWORD, _QWORD); // rax
		  signed int v66; // ebx
		  unsigned int v67; // ebx
		  int32_t v68; // ebx
		  Material *v69; // rbx
		  float (__fastcall *v70)(Material *, _QWORD); // rax
		  Material *v71; // rbx
		  float (__fastcall *v72)(Material *, _QWORD); // rax
		  unsigned int v73; // ebx
		  void (__fastcall *v74)(CommandBuffer *, _QWORD, _QWORD); // rax
		  bool v75; // al
		  __int64 v76; // rdx
		  Material *v77; // r15
		  Shader *v78; // rbx
		  String *v79; // r8
		  Shader *v80; // rbx
		  String *v81; // r8
		  bool v82; // al
		  __int64 v83; // rdx
		  Material *v84; // r15
		  Shader *v85; // rbx
		  String *v86; // r8
		  Shader *v87; // rbx
		  String *v88; // r8
		  bool v89; // al
		  __int64 v90; // rdx
		  Material *v91; // r15
		  Shader *v92; // rbx
		  String *v93; // r8
		  Shader *v94; // rbx
		  String *v95; // r8
		  bool v96; // al
		  __int64 v97; // rdx
		  Material *v98; // r15
		  Shader *v99; // rbx
		  String *v100; // r8
		  LocalKeyword *p_keyword; // r8
		  Material *v102; // rdx
		  Shader *v103; // rbx
		  String *v104; // r8
		  Material *m_VolumetricMat; // r15
		  Material *v106; // rcx
		  Shader *shader; // rbx
		  String *s_ReconstructEnableMotionVector; // r8
		  Material *v109; // rbx
		  Shader *v110; // rax
		  String *s_ReconstructEnableDepthOpt; // r8
		  Material *v112; // rbx
		  Shader *v113; // rax
		  String *s_ReconstructEnableColorAABB; // r8
		  Material *v115; // rbx
		  Shader *v116; // rax
		  String *s_ReconstructEnableNeighborAvg; // r8
		  ILFixDynamicMethodWrapper_2 *v118; // rax
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v119; // rax
		  List_1_System_Object_ *v120; // r15
		  Comparison_1_Object_ *v121; // rax
		  Comparison_1_Object_ *v122; // rbx
		  unsigned int v123; // ebx
		  Object *Item; // rax
		  List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderNode_ *v125; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v127; // rdx
		  __int64 v128; // rcx
		  __int64 v129; // rax
		  __int64 v130; // rax
		  __int64 v131; // rax
		  __int64 v132; // [rsp+0h] [rbp-228h] BYREF
		  LocalKeyword v133; // [rsp+40h] [rbp-1E8h] BYREF
		  LocalKeyword keyword; // [rsp+60h] [rbp-1C8h] BYREF
		  HGCamera *v135; // [rsp+80h] [rbp-1A8h]
		  VolumetricRenderer *v136; // [rsp+88h] [rbp-1A0h]
		  LocalKeyword v137; // [rsp+90h] [rbp-198h] BYREF
		  List_1_T_Enumerator_System_Object_ v138; // [rsp+B0h] [rbp-178h] BYREF
		  List_1_T_Enumerator_System_Object_ v139; // [rsp+C8h] [rbp-160h] BYREF
		  Camera *camera; // [rsp+E0h] [rbp-148h]
		  LocalKeyword v141; // [rsp+E8h] [rbp-140h] BYREF
		  LocalKeyword v142; // [rsp+100h] [rbp-128h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v143; // [rsp+120h] [rbp-108h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v144; // [rsp+180h] [rbp-A8h] BYREF
		  Il2CppExceptionWrapper *v145; // [rsp+1E8h] [rbp-40h] BYREF
		  Il2CppExceptionWrapper *v146; // [rsp+1F0h] [rbp-38h] BYREF
		  char v149; // [rsp+248h] [rbp+20h]
		  int32_t FrameCountMod8; // [rsp+248h] [rbp+20h]
		  unsigned int v151; // [rsp+248h] [rbp+20h]
		  unsigned int v152; // [rsp+248h] [rbp+20h]
		  unsigned int v153; // [rsp+248h] [rbp+20h]
		  unsigned int v154; // [rsp+248h] [rbp+20h]
		  unsigned int DebugPixelOffset; // [rsp+248h] [rbp+20h]
		  unsigned int PixelOffsetTest; // [rsp+248h] [rbp+20h]
		
		  v3 = inputs;
		  v4 = this;
		  v136 = this;
		  memset(&v138, 0, sizeof(v138));
		  sub_18033B9D0(&v143, 0LL, 88LL);
		  memset(&v139, 0, sizeof(v139));
		  if ( IFix::WrappersManagerImpl::IsPatched(5151, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5151, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v128, v127);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)v4, v3, 0LL);
		    return;
		  }
		  hgCamera = v3->hgCamera;
		  v135 = hgCamera;
		  if ( !hgCamera )
		    sub_1800D8260(v6, v5);
		  camera = hgCamera->fields.camera;
		  *(_WORD *)&v4->fields.m_EnableFraming = 0;
		  ++v4->fields._DrawFrameCount_k__BackingField;
		  if ( !v4->fields.m_RenderNodes )
		    sub_1800D8260(v6, v5);
		  sub_183127A90(
		    v4->fields.m_RenderNodes,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Clear);
		  HG::Rendering::Runtime::VolumetricRenderer::ResetRenderNodePool(v4, 0LL);
		  HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricCameraVP(v4, hgCamera, v3->context, 0LL);
		  if ( !v3->volumetricRenderObjects )
		    sub_1800D8260(v9, v8);
		  v138 = *(List_1_T_Enumerator_System_Object_ *)sub_180364F58(&v137, v3->volumetricRenderObjects);
		  v133.m_SpaceInfo.m_KeywordSpace = 0LL;
		  v133.m_Name = (String *)&v138;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v138,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		    {
		      current = v138._current;
		      itemCache = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v4->fields._itemCache;
		      if ( !itemCache )
		        sub_1800D8250(0LL, v10);
		      System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		        itemCache,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Clear);
		      context = v3->context;
		      if ( !context )
		        sub_1800D8250(v15, v14);
		      m_Ptr = (__int64)context->fields.renderContext.m_Ptr;
		      volumetricParameters = v3->volumetricParameters;
		      if ( !current )
		        sub_1800D8250(v15, v14);
		      if ( *(_DWORD *)&current->klass->_1.method_count == 3434 || *(_DWORD *)&current->klass->_1.method_count == 3435 )
		        HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItems(
		          (VolumetricRenderObject *)current,
		          hgCamera,
		          (ScriptableRenderContext)m_Ptr,
		          volumetricParameters,
		          v4->fields._itemCache,
		          0LL);
		      else
		        sub_1808B264C(
		          current->klass,
		          *(_DWORD *)&current->klass->_1.method_count - 3434,
		          (_DWORD)current,
		          (_DWORD)hgCamera,
		          m_Ptr,
		          (__int64)volumetricParameters,
		          (__int64)v4->fields._itemCache);
		      v149 = 0;
		      for ( i = 0; ; ++i )
		      {
		        v22 = v4->fields._itemCache;
		        if ( !v22 )
		          sub_1800D8250(v20, v19);
		        if ( i >= v22->fields._size )
		          break;
		        System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Item(
		          &v144,
		          v4->fields._itemCache,
		          i,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::get_Item);
		        v143 = v144;
		        if ( HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::CheckVisibility(&v143, camera, 0LL) )
		        {
		          v149 = 1;
		          bEnableFraming = v143.bEnableFraming;
		          v24 = v3->volumetricParameters;
		          if ( !v24 )
		            sub_1800D8250(0LL, v19);
		          v143.bEnableFraming = bEnableFraming & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                                   v24->fields.enableFraming,
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          bEnableTAA = v143.bEnableTAA;
		          v27 = v3->volumetricParameters;
		          if ( !v27 )
		            sub_1800D8250(0LL, v25);
		          v143.bEnableTAA = bEnableTAA & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                           v27->fields.enableTAA,
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          RenderNodeFromPool = HG::Rendering::Runtime::VolumetricRenderer::GetRenderNodeFromPool(v4, 0LL);
		          v31 = (Object *)RenderNodeFromPool;
		          if ( !RenderNodeFromPool )
		            sub_1800D8250(v30, v29);
		          v144 = v143;
		          HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetRenderItem(
		            RenderNodeFromPool,
		            &v144,
		            0LL);
		          v31[7].monitor = (MonitorData *)current;
		          if ( dword_18F35FD08 )
		          {
		            v32 = (((unsigned __int64)&v31[7].monitor >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F103690[v32]);
		            do
		              v33 = qword_18F103690[v32];
		            while ( v33 != _InterlockedCompareExchange64(
		                             &qword_18F103690[v32],
		                             v33 | (1LL << (((unsigned __int64)&v31[7].monitor >> 12) & 0x3F)),
		                             v33) );
		          }
		          m_RenderNodes = (List_1_System_Object_ *)v4->fields.m_RenderNodes;
		          if ( !m_RenderNodes )
		            sub_1800D8250(0LL, v32);
		          sub_182F01190(m_RenderNodes, v31);
		        }
		      }
		      hgCamera = v135;
		      if ( v149 )
		      {
		        if ( *(_DWORD *)&current->klass->_1.method_count == 3434 || *(_DWORD *)&current->klass->_1.method_count == 3435 )
		          HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRendering(
		            (VolumetricRenderObject *)current,
		            v3,
		            0LL);
		        else
		          sub_1808B24D8(1LL, (unsigned int)(*(_DWORD *)&current->klass->_1.method_count - 3434), current, v3);
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v145 )
		  {
		    v133.m_SpaceInfo.m_KeywordSpace = v145->ex;
		    m_KeywordSpace = (unsigned __int64)v133.m_SpaceInfo.m_KeywordSpace;
		    if ( v133.m_SpaceInfo.m_KeywordSpace )
		      sub_18007E1E0(v133.m_SpaceInfo.m_KeywordSpace);
		    v3 = inputs;
		    v4 = this;
		  }
		  v35 = (List_1_System_UInt64_ *)v4->fields.m_RenderNodes;
		  if ( !v35 )
		    goto LABEL_157;
		  System::Collections::Generic::List<unsigned long>::GetEnumerator(
		    (List_1_T_Enumerator_System_UInt64_ *)&keyword,
		    v35,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::GetEnumerator);
		  v139 = (List_1_T_Enumerator_System_Object_)keyword;
		  v133.m_SpaceInfo.m_KeywordSpace = 0LL;
		  v133.m_Name = (String *)&v139;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v139,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::MoveNext) )
		    {
		      v37 = v139._current;
		      if ( !v139._current )
		        sub_1800D8250(v36, v35);
		      m_EnableFraming = v4->fields.m_EnableFraming;
		      v4->fields.m_EnableFraming = (m_EnableFraming | HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableFraming(
		                                                        (VolumetricRenderer_VolumetricRenderNode *)v139._current,
		                                                        0LL)) != 0;
		      m_EnableTAA = v4->fields.m_EnableTAA;
		      v4->fields.m_EnableTAA = (m_EnableTAA | HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_bEnableTAA(
		                                                (VolumetricRenderer_VolumetricRenderNode *)v37,
		                                                0LL)) != 0;
		      v42 = v3->context;
		      if ( !v42 )
		        sub_1800D8250(v41, v40);
		      cmd = v42->fields.cmd;
		      material = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
		                   (VolumetricRenderer_VolumetricRenderNode *)v37,
		                   0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      HG::Rendering::Runtime::VolumetricSDFUtils::UpdateFramingKeywords(
		        cmd,
		        material,
		        0,
		        EFramingQuality__Enum_Checkerboard,
		        0LL);
		      v47 = v3->context;
		      if ( !v47 )
		        sub_1800D8250(v46, v45);
		      v48 = v47->fields.cmd;
		      v49 = HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::get_material(
		              (VolumetricRenderer_VolumetricRenderNode *)v37,
		              0LL);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ResetTemporalKeywords(v48, v49, 0LL);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v146 )
		  {
		    v35 = (List_1_System_UInt64_ *)&v132;
		    v133.m_SpaceInfo.m_KeywordSpace = v146->ex;
		    if ( v133.m_SpaceInfo.m_KeywordSpace )
		      sub_18007E1E0(v133.m_SpaceInfo.m_KeywordSpace);
		    v3 = inputs;
		    v4 = this;
		  }
		  m_KeywordSpace = (unsigned __int64)v3->volumetricParameters;
		  if ( !m_KeywordSpace )
		    goto LABEL_157;
		  v50 = v4->fields.m_EnableFraming;
		  v4->fields.m_EnableFraming = v50 & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                       *(SettingParameter_1_System_Boolean_ **)(m_KeywordSpace + 40),
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  m_KeywordSpace = (unsigned __int64)v3->volumetricParameters;
		  if ( !m_KeywordSpace )
		    goto LABEL_157;
		  v51 = v4->fields.m_EnableTAA;
		  v4->fields.m_EnableTAA = v51 & HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                   *(SettingParameter_1_System_Boolean_ **)(m_KeywordSpace + 104),
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v35 = (List_1_System_UInt64_ *)v3->context;
		  if ( !v35 )
		    goto LABEL_157;
		  HG::Rendering::Runtime::VolumetricRenderer::UpdateCloudFadeParameters(v4, *(CommandBuffer **)&v35->fields._size, 0LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(5163, 0LL) )
		  {
		    v52 = v3->context;
		    if ( !v52 )
		      goto LABEL_157;
		    v53 = v52->fields.cmd;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    m_KeywordSpace = (unsigned int)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod8;
		    FrameCountMod8 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod8;
		    DrawFrameCount_k__BackingField = v4->fields._DrawFrameCount_k__BackingField;
		    if ( !v53 )
		      goto LABEL_157;
		    v55 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18F3AB418;
		    if ( !qword_18F3AB418 )
		    {
		      v55 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Rendering.CommandBuffer::SetGlobalInt(Sy"
		                                                                    "stem.Int32,System.Int32)");
		      if ( !v55 )
		      {
		        v129 = sub_1802EE1B8("UnityEngine.Rendering.CommandBuffer::SetGlobalInt(System.Int32,System.Int32)");
		        sub_18007E1B0(v129, 0LL);
		      }
		      qword_18F3AB418 = (__int64)v55;
		      LODWORD(m_KeywordSpace) = FrameCountMod8;
		    }
		    v55(v53, (unsigned int)m_KeywordSpace, (unsigned int)(DrawFrameCount_k__BackingField % 8));
		    FrameCountMod16 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod16;
		    v151 = FrameCountMod16;
		    v57 = v4->fields._DrawFrameCount_k__BackingField;
		    v58 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18F3AB418;
		    if ( !qword_18F3AB418 )
		    {
		      v58 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Rendering.CommandBuffer::SetGlobalInt(Sy"
		                                                                    "stem.Int32,System.Int32)");
		      if ( !v58 )
		      {
		        v130 = sub_1802EE1B8("UnityEngine.Rendering.CommandBuffer::SetGlobalInt(System.Int32,System.Int32)");
		        sub_18007E1B0(v130, 0LL);
		      }
		      qword_18F3AB418 = (__int64)v58;
		      FrameCountMod16 = v151;
		    }
		    v58(v53, FrameCountMod16, (unsigned int)(v57 % 16));
		    FrameCountMod32 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod32;
		    v152 = FrameCountMod32;
		    v60 = v4->fields._DrawFrameCount_k__BackingField;
		    v61 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18F3AB418;
		    if ( !qword_18F3AB418 )
		    {
		      v61 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Rendering.CommandBuffer::SetGlobalInt(Sy"
		                                                                    "stem.Int32,System.Int32)");
		      if ( !v61 )
		      {
		        v131 = sub_1802EE1B8("UnityEngine.Rendering.CommandBuffer::SetGlobalInt(System.Int32,System.Int32)");
		        sub_18007E1B0(v131, 0LL);
		      }
		      qword_18F3AB418 = (__int64)v61;
		      FrameCountMod32 = v152;
		    }
		    v61(v53, FrameCountMod32, (unsigned int)(v60 % 32));
		    if ( !v4->fields.m_EnableFraming )
		    {
		      m_VolumetricMat = v4->fields.m_VolumetricMat;
		      v106 = m_VolumetricMat;
		      if ( !m_VolumetricMat )
		        goto LABEL_156;
		      shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		      s_ReconstructEnableMotionVector = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableMotionVector;
		      memset(&v133, 0, sizeof(v133));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, shader, s_ReconstructEnableMotionVector, 0LL);
		      v137 = v133;
		      UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, m_VolumetricMat, &v137, 0LL);
		      v109 = v4->fields.m_VolumetricMat;
		      v106 = v109;
		      if ( !v109 )
		        goto LABEL_156;
		      v110 = UnityEngine::Material::get_shader(v109, 0LL);
		      s_ReconstructEnableDepthOpt = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableDepthOpt;
		      memset(&v141, 0, sizeof(v141));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v141, v110, s_ReconstructEnableDepthOpt, 0LL);
		      v137 = v141;
		      UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, v109, &v137, 0LL);
		      v112 = v4->fields.m_VolumetricMat;
		      v106 = v112;
		      if ( !v112 )
		        goto LABEL_156;
		      v113 = UnityEngine::Material::get_shader(v112, 0LL);
		      s_ReconstructEnableColorAABB = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableColorAABB;
		      memset(&v142, 0, sizeof(v142));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v142, v113, s_ReconstructEnableColorAABB, 0LL);
		      v137 = v142;
		      UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, v112, &v137, 0LL);
		      v115 = v4->fields.m_VolumetricMat;
		      v106 = v115;
		      if ( !v115 )
		LABEL_156:
		        sub_1800D8250(v106, v35);
		      v116 = UnityEngine::Material::get_shader(v115, 0LL);
		      s_ReconstructEnableNeighborAvg = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableNeighborAvg;
		      memset(&keyword, 0, sizeof(keyword));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&keyword, v116, s_ReconstructEnableNeighborAvg, 0LL);
		      v137 = keyword;
		      p_keyword = &v137;
		      v102 = v115;
		LABEL_112:
		      UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, v102, p_keyword, 0LL);
		      goto LABEL_115;
		    }
		    v62 = v3->volumetricParameters;
		    if ( !v62 )
		      goto LABEL_157;
		    m_KeywordSpace = (unsigned __int64)v62->fields.framingLevel;
		    if ( !m_KeywordSpace )
		      goto LABEL_157;
		    if ( *(_DWORD *)(m_KeywordSpace + 40) )
		    {
		      if ( *(_DWORD *)(m_KeywordSpace + 40) != 1 )
		        goto LABEL_73;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      PixelSubOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelSubOffset;
		      v154 = PixelSubOffset;
		      v68 = v4->fields._DrawFrameCount_k__BackingField;
		      v65 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18F3AB418;
		      if ( !qword_18F3AB418 )
		      {
		        v65 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))sub_180059EA0(
		                                                                      "UnityEngine.Rendering.CommandBuffer::SetGlobalInt("
		                                                                      "System.Int32,System.Int32)");
		        qword_18F3AB418 = (__int64)v65;
		        PixelSubOffset = v154;
		      }
		      v66 = v68 & 0x80000003;
		      if ( v66 >= 0 )
		      {
		LABEL_72:
		        v65(v53, PixelSubOffset, (unsigned int)v66);
		LABEL_73:
		        v69 = v4->fields.m_VolumetricMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        if ( !v69 )
		          goto LABEL_157;
		        DebugPixelOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DebugPixelOffset;
		        v70 = (float (__fastcall *)(Material *, _QWORD))qword_18F36F698;
		        if ( !qword_18F36F698 )
		        {
		          v70 = (float (__fastcall *)(Material *, _QWORD))sub_180059EA0("UnityEngine.Material::GetFloatImpl(System.Int32)");
		          qword_18F36F698 = (__int64)v70;
		        }
		        if ( (int)v70(v69, DebugPixelOffset) )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		          m_KeywordSpace = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		          LODWORD(v135) = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelSubOffset;
		          v71 = v4->fields.m_VolumetricMat;
		          if ( !v71 )
		            goto LABEL_157;
		          PixelOffsetTest = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelOffsetTest;
		          v72 = (float (__fastcall *)(Material *, _QWORD))qword_18F36F698;
		          if ( !qword_18F36F698 )
		          {
		            v72 = (float (__fastcall *)(Material *, _QWORD))sub_180059EA0("UnityEngine.Material::GetFloatImpl(System.Int32)");
		            qword_18F36F698 = (__int64)v72;
		          }
		          v73 = (int)v72(v71, PixelOffsetTest);
		          v74 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18F3AB418;
		          if ( !qword_18F3AB418 )
		          {
		            v74 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))sub_180059EA0(
		                                                                          "UnityEngine.Rendering.CommandBuffer::SetGlobal"
		                                                                          "Int(System.Int32,System.Int32)");
		            qword_18F3AB418 = (__int64)v74;
		          }
		          v74(v53, (unsigned int)v135, v73);
		        }
		        m_KeywordSpace = (unsigned __int64)v3->volumetricParameters;
		        if ( m_KeywordSpace )
		        {
		          v75 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                  *(SettingParameter_1_System_Boolean_ **)(m_KeywordSpace + 72),
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          v77 = v136->fields.m_VolumetricMat;
		          if ( v75 )
		          {
		            if ( !v77 )
		              sub_1800D8250(0LL, v76);
		            v80 = UnityEngine::Material::get_shader(v77, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		            v81 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableMotionVector;
		            memset(&v133, 0, sizeof(v133));
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v80, v81, 0LL);
		            keyword = v133;
		            UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v53, v77, &keyword, 0LL);
		          }
		          else
		          {
		            if ( !v77 )
		              sub_1800D8250(0LL, v76);
		            v78 = UnityEngine::Material::get_shader(v77, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		            v79 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableMotionVector;
		            memset(&v133, 0, sizeof(v133));
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v78, v79, 0LL);
		            keyword = v133;
		            UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, v77, &keyword, 0LL);
		          }
		          m_KeywordSpace = (unsigned __int64)v3->volumetricParameters;
		          if ( m_KeywordSpace )
		          {
		            v82 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                    *(SettingParameter_1_System_Boolean_ **)(m_KeywordSpace + 80),
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		            v84 = v136->fields.m_VolumetricMat;
		            if ( v82 )
		            {
		              if ( !v84 )
		                sub_1800D8250(0LL, v83);
		              v87 = UnityEngine::Material::get_shader(v84, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		              v88 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableDepthOpt;
		              memset(&v133, 0, sizeof(v133));
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v87, v88, 0LL);
		              keyword = v133;
		              UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v53, v84, &keyword, 0LL);
		            }
		            else
		            {
		              if ( !v84 )
		                sub_1800D8250(0LL, v83);
		              v85 = UnityEngine::Material::get_shader(v84, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		              v86 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableDepthOpt;
		              memset(&v133, 0, sizeof(v133));
		              UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v85, v86, 0LL);
		              keyword = v133;
		              UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, v84, &keyword, 0LL);
		            }
		            m_KeywordSpace = (unsigned __int64)v3->volumetricParameters;
		            if ( m_KeywordSpace )
		            {
		              v89 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                      *(SettingParameter_1_System_Boolean_ **)(m_KeywordSpace + 88),
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              v91 = v136->fields.m_VolumetricMat;
		              if ( v89 )
		              {
		                if ( !v91 )
		                  sub_1800D8250(0LL, v90);
		                v94 = UnityEngine::Material::get_shader(v91, 0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                v95 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableColorAABB;
		                memset(&v133, 0, sizeof(v133));
		                UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v94, v95, 0LL);
		                keyword = v133;
		                UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v53, v91, &keyword, 0LL);
		              }
		              else
		              {
		                if ( !v91 )
		                  sub_1800D8250(0LL, v90);
		                v92 = UnityEngine::Material::get_shader(v91, 0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                v93 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableColorAABB;
		                memset(&v133, 0, sizeof(v133));
		                UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v92, v93, 0LL);
		                keyword = v133;
		                UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(v53, v91, &keyword, 0LL);
		              }
		              m_KeywordSpace = (unsigned __int64)v3->volumetricParameters;
		              if ( m_KeywordSpace )
		              {
		                v96 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                        *(SettingParameter_1_System_Boolean_ **)(m_KeywordSpace + 96),
		                        MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                v98 = v136->fields.m_VolumetricMat;
		                if ( v96 )
		                {
		                  if ( !v98 )
		                    sub_1800D8250(0LL, v97);
		                  v103 = UnityEngine::Material::get_shader(v98, 0LL);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                  v104 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableNeighborAvg;
		                  memset(&v133, 0, sizeof(v133));
		                  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v103, v104, 0LL);
		                  keyword = v133;
		                  UnityEngine::Rendering::CommandBuffer::EnableMaterialKeyword_Injected(v53, v98, &keyword, 0LL);
		                  goto LABEL_115;
		                }
		                if ( !v98 )
		                  sub_1800D8250(0LL, v97);
		                v99 = UnityEngine::Material::get_shader(v98, 0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                v100 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableNeighborAvg;
		                memset(&v133, 0, sizeof(v133));
		                UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v133, v99, v100, 0LL);
		                keyword = v133;
		                p_keyword = &keyword;
		                v102 = v98;
		                goto LABEL_112;
		              }
		            }
		          }
		        }
		LABEL_157:
		        sub_1800D8250(m_KeywordSpace, v35);
		      }
		      v67 = ((_BYTE)v66 - 1) | 0xFFFFFFFC;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      PixelSubOffset = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelSubOffset;
		      v153 = PixelSubOffset;
		      v64 = v4->fields._DrawFrameCount_k__BackingField;
		      v65 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))qword_18F3AB418;
		      if ( !qword_18F3AB418 )
		      {
		        v65 = (void (__fastcall *)(CommandBuffer *, _QWORD, _QWORD))sub_180059EA0(
		                                                                      "UnityEngine.Rendering.CommandBuffer::SetGlobalInt("
		                                                                      "System.Int32,System.Int32)");
		        qword_18F3AB418 = (__int64)v65;
		        PixelSubOffset = v153;
		      }
		      v66 = v64 & 0x80000001;
		      if ( v66 >= 0 )
		        goto LABEL_72;
		      v67 = ((_BYTE)v66 - 1) | 0xFFFFFFFE;
		    }
		    v66 = v67 + 1;
		    goto LABEL_72;
		  }
		  v118 = IFix::WrappersManagerImpl::GetPatch(5163, 0LL);
		  if ( !v118 )
		    goto LABEL_157;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(v118, (Object *)v4, v3, 0LL);
		LABEL_115:
		  HG::Rendering::Runtime::VolumetricRenderer::UpdateTAARender(v4, v3, 0LL);
		  HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResRender(v4, v3, 0LL);
		  HG::Rendering::Runtime::VolumetricRenderer::GetVolumetricRenderRTSize(v4, v3, 0LL);
		  HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRTs(v4, v3, 0LL);
		  v119 = v4->fields.m_RenderNodes;
		  if ( !v119 )
		    goto LABEL_157;
		  if ( v119->fields._size <= 0 )
		    return;
		  v120 = (List_1_System_Object_ *)v4->fields.m_RenderNodes;
		  v121 = (Comparison_1_Object_ *)sub_18002C620(TypeInfo::System::Comparison<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>);
		  v122 = v121;
		  if ( !v121 )
		    goto LABEL_157;
		  System::Comparison<System::Object>::Comparison(
		    v121,
		    0LL,
		    MethodInfo::HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::NodeCompare,
		    0LL);
		  System::Collections::Generic::List<System::Object>::Sort(
		    v120,
		    v122,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::Sort);
		  v123 = 0;
		  for ( m_KeywordSpace = 0LL; ; m_KeywordSpace = v123 )
		  {
		    v125 = v4->fields.m_RenderNodes;
		    if ( !v125 )
		      goto LABEL_157;
		    if ( (int)m_KeywordSpace >= v125->fields._size )
		      break;
		    m_KeywordSpace = (unsigned __int64)v4->fields.m_RenderNodes;
		    if ( !m_KeywordSpace )
		      goto LABEL_157;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             (List_1_System_Object_ *)m_KeywordSpace,
		             v123,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode>::get_Item);
		    if ( !Item )
		      goto LABEL_157;
		    HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderNode::SetIndex(
		      (VolumetricRenderer_VolumetricRenderNode *)Item,
		      v123++,
		      0LL);
		  }
		  HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRenderPipeline(v4, v3, 0LL);
		  HG::Rendering::Runtime::VolumetricRenderer::DrawVolumetric(v4, v3, 0LL);
		}
		
		private void UpdateDownResParameters(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5901C-0x0000000189C596F0
		// Void UpdateDownResParameters(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResParameters(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  SettingParameter_1_System_Boolean_ **volumetricParameters; // rcx
		  HGRenderGraphContext *context; // rsi
		  CommandBuffer *cmd; // rsi
		  Vector4 *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  int32_t v12; // r10d
		  TextureHandle sceneDepthToSample; // xmm6
		  int32_t WorldDepthTex; // ebx
		  RenderTargetIdentifier *v15; // rax
		  __int128 v16; // xmm1
		  VolumetricShaderIDs__StaticFields *static_fields; // rcx
		  int32_t HistoryWorldDepthTex; // ebx
		  RenderTargetIdentifier *v19; // rax
		  __int128 v20; // xmm1
		  int32_t DownscaleScreenParams; // edx
		  Vector4 *v22; // rax
		  __int64 v23; // rdx
		  HGVolumetricCloudSettingParameters *v24; // rcx
		  int32_t v25; // r10d
		  Vector4 m_DownscaledScreenParams; // xmm1
		  MethodInfo *v27; // r9
		  Vector4 *v28; // rax
		  int32_t v29; // edx
		  __int64 v30; // rax
		  RenderTexture *v31; // rbx
		  Material *m_VolumetricMat; // r14
		  VolumetricPipelineRT *m_MinMaxWorldDepths; // rcx
		  Shader *shader; // rbx
		  String *s_EnableDepthForTest; // r8
		  __int64 m_RTIndex; // rax
		  Texture *RT; // rax
		  RenderTargetIdentifier *v38; // rax
		  __int64 v39; // xmm11_8
		  __int128 v40; // xmm9
		  __int128 v41; // xmm10
		  Texture *v42; // rax
		  RenderTargetIdentifier *v43; // rax
		  __int128 v44; // xmm7
		  __int128 v45; // xmm8
		  __int64 v46; // xmm6_8
		  Material *v47; // rbx
		  __int64 v48; // rdx
		  Material *v49; // r14
		  VolumetricPipelineRT *v50; // rcx
		  Shader *v51; // rbx
		  String *v52; // r8
		  __int64 v53; // rax
		  int32_t v54; // ebx
		  Texture *v55; // rax
		  RenderTargetIdentifier *v56; // rax
		  __int128 v57; // xmm1
		  __int64 v58; // rdx
		  int32_t v59; // ebx
		  VolumetricPipelineRT *v60; // rcx
		  int v61; // eax
		  Texture *v62; // rax
		  RenderTargetIdentifier *v63; // rax
		  __int128 v64; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 value_8; // [rsp+38h] [rbp-D0h] BYREF
		  LocalKeyword v67; // [rsp+48h] [rbp-C0h] BYREF
		  RenderTargetIdentifier v68; // [rsp+68h] [rbp-A0h] BYREF
		  RenderTargetIdentifier keyword; // [rsp+98h] [rbp-70h] BYREF
		  RenderTargetIdentifier v70[3]; // [rsp+C8h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5203, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5203, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		      return;
		    }
		    goto LABEL_39;
		  }
		  context = inputs->context;
		  if ( !context )
		    goto LABEL_39;
		  volumetricParameters = (SettingParameter_1_System_Boolean_ **)inputs->volumetricParameters;
		  cmd = context->fields.cmd;
		  if ( !volumetricParameters )
		    goto LABEL_39;
		  if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          volumetricParameters[2],
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    v9 = (Vector4 *)sub_183240A00(&v67, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		    if ( !cmd )
		      sub_1800D8260(v11, v10);
		    value_8 = *v9;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v12, &value_8, 0LL);
		    sceneDepthToSample = inputs->sceneDepthToSample;
		    WorldDepthTex = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WorldDepthTex;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    value_8 = (Vector4)sceneDepthToSample;
		    v15 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v68, (TextureHandle *)&value_8, 0LL);
		    v16 = *(_OWORD *)&v15->m_BufferPointer;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v15->m_Type;
		    *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v15->m_DepthSlice;
		    *(_OWORD *)&keyword.m_BufferPointer = v16;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, WorldDepthTex, &keyword, 0LL);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    value_8 = (Vector4)inputs->historySceneDepth;
		    HistoryWorldDepthTex = static_fields->_HistoryWorldDepthTex;
		    v19 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v68, (TextureHandle *)&value_8, 0LL);
		    v20 = *(_OWORD *)&v19->m_BufferPointer;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v19->m_Type;
		    *(_QWORD *)&keyword.m_DepthSlice = *(_QWORD *)&v19->m_DepthSlice;
		    *(_OWORD *)&keyword.m_BufferPointer = v20;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HistoryWorldDepthTex, &keyword, 0LL);
		    DownscaleScreenParams = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DownscaleScreenParams;
		    value_8 = this->fields.m_DownscaledScreenParams;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, DownscaleScreenParams, &value_8, 0LL);
		    return;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  v22 = (Vector4 *)sub_183240A00(
		                     &v67,
		                     _mm_unpacklo_ps(
		                       (__m128)LODWORD(this->fields.m_NDCRescaleParams.x),
		                       (__m128)LODWORD(this->fields.m_NDCRescaleParams.y)).m128_u64[0]);
		  if ( !cmd
		    || (value_8 = *v22,
		        UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v25, &value_8, 0LL),
		        (v24 = inputs->volumetricParameters) == 0LL) )
		  {
		    sub_1800D8260(v24, v23);
		  }
		  value_8.z = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                v24->fields.downResRatio,
		                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  value_8.x = 1.0 / value_8.z;
		  m_DownscaledScreenParams = this->fields.m_DownscaledScreenParams;
		  value_8.y = 1.0 / value_8.z;
		  value_8.w = value_8.z;
		  *(Vector4 *)&v67.m_SpaceInfo.m_KeywordSpace = m_DownscaledScreenParams;
		  v28 = UnityEngine::Vector4::Scale((Vector4 *)&keyword, (Vector4 *)&v67, &value_8, v27);
		  v29 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DownscaleScreenParams;
		  *(Vector4 *)&v67.m_SpaceInfo.m_KeywordSpace = *v28;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v29, (Vector4 *)&v67, 0LL);
		  if ( this->fields.m_BeforeTAANeedDepthTest || this->fields.m_AfterTAANeedDepthTest )
		  {
		    m_VolumetricMat = this->fields.m_VolumetricMat;
		    m_MinMaxWorldDepths = (VolumetricPipelineRT *)m_VolumetricMat;
		    if ( !m_VolumetricMat )
		      goto LABEL_36;
		    shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    s_EnableDepthForTest = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableDepthForTest;
		    memset(&v67, 0, sizeof(v67));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v67, shader, s_EnableDepthForTest, 0LL);
		    keyword.m_BufferPointer = *(void **)&v67.m_Index;
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v67.m_SpaceInfo.m_KeywordSpace;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, m_VolumetricMat, (LocalKeyword *)&keyword, 0LL);
		    m_MinMaxWorldDepths = (VolumetricPipelineRT *)this->fields.m_MinMaxWorldDepths;
		    m_RTIndex = this->fields.m_RTIndex;
		    if ( !m_MinMaxWorldDepths )
		      goto LABEL_36;
		    if ( (unsigned int)m_RTIndex >= m_MinMaxWorldDepths->fields.Desc._width_k__BackingField )
		      sub_1800D2AB0(m_MinMaxWorldDepths, v5);
		    m_MinMaxWorldDepths = (VolumetricPipelineRT *)*((_QWORD *)&m_MinMaxWorldDepths->fields.Desc._msaaSamples_k__BackingField
		                                                  + m_RTIndex);
		    if ( !m_MinMaxWorldDepths
		      || (RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_MinMaxWorldDepths, 0LL),
		          v38 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v68, RT, 0LL),
		          m_MinMaxWorldDepths = this->fields.m_DepthForTest,
		          v39 = *(_QWORD *)&v38->m_DepthSlice,
		          v40 = *(_OWORD *)&v38->m_Type,
		          v41 = *(_OWORD *)&v38->m_BufferPointer,
		          !m_MinMaxWorldDepths) )
		    {
		LABEL_36:
		      sub_1800D8260(m_MinMaxWorldDepths, v5);
		    }
		    v42 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_MinMaxWorldDepths, 0LL);
		    v43 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v68, v42, 0LL);
		    v44 = *(_OWORD *)&v43->m_Type;
		    v45 = *(_OWORD *)&v43->m_BufferPointer;
		    v46 = *(_QWORD *)&v43->m_DepthSlice;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    *(_OWORD *)&v70[0].m_Type = v44;
		    *(_OWORD *)&v70[0].m_BufferPointer = v45;
		    *(_QWORD *)&v70[0].m_DepthSlice = v46;
		    *(_OWORD *)&v68.m_Type = v40;
		    *(_OWORD *)&v68.m_BufferPointer = v41;
		    *(_QWORD *)&v68.m_DepthSlice = v39;
		    HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargetWithDepth(
		      cmd,
		      &v68,
		      v70,
		      RenderBufferLoadAction__Enum_DontCare,
		      RenderBufferStoreAction__Enum_Store,
		      0LL);
		    goto LABEL_24;
		  }
		  volumetricParameters = (SettingParameter_1_System_Boolean_ **)this->fields.m_MinMaxWorldDepths;
		  v30 = this->fields.m_RTIndex;
		  if ( !volumetricParameters )
		    goto LABEL_39;
		  if ( (unsigned int)v30 >= *((_DWORD *)volumetricParameters + 6) )
		    sub_1800D2AB0(volumetricParameters, v5);
		  volumetricParameters = (SettingParameter_1_System_Boolean_ **)volumetricParameters[v30 + 4];
		  if ( !volumetricParameters )
		LABEL_39:
		    sub_1800D8260(volumetricParameters, v5);
		  v31 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)volumetricParameters, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		  HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(cmd, v31, 0LL);
		LABEL_24:
		  v47 = this->fields.m_VolumetricMat;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		  HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, v47, 0, 0, 0LL);
		  v49 = this->fields.m_VolumetricMat;
		  v50 = (VolumetricPipelineRT *)v49;
		  if ( !v49 )
		    goto LABEL_35;
		  v51 = UnityEngine::Material::get_shader(v49, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		  v52 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableDepthForTest;
		  memset(&v67, 0, sizeof(v67));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v67, v51, v52, 0LL);
		  keyword.m_BufferPointer = *(void **)&v67.m_Index;
		  *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v67.m_SpaceInfo.m_KeywordSpace;
		  UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v49, (LocalKeyword *)&keyword, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  v53 = this->fields.m_RTIndex;
		  v54 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WorldDepthTex;
		  v50 = (VolumetricPipelineRT *)this->fields.m_MinMaxWorldDepths;
		  if ( !v50 )
		    goto LABEL_35;
		  if ( (unsigned int)v53 >= v50->fields.Desc._width_k__BackingField )
		    sub_1800D2AB0(v50, v48);
		  v50 = (VolumetricPipelineRT *)*((_QWORD *)&v50->fields.Desc._msaaSamples_k__BackingField + v53);
		  if ( !v50 )
		LABEL_35:
		    sub_1800D8260(v50, v48);
		  v55 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v50, 0LL);
		  v56 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v70, v55, 0LL);
		  v57 = *(_OWORD *)&v56->m_BufferPointer;
		  *(_OWORD *)&v68.m_Type = *(_OWORD *)&v56->m_Type;
		  *(_QWORD *)&v68.m_DepthSlice = *(_QWORD *)&v56->m_DepthSlice;
		  *(_OWORD *)&v68.m_BufferPointer = v57;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v54, &v68, 0LL);
		  v59 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_HistoryWorldDepthTex;
		  v60 = (VolumetricPipelineRT *)this->fields.m_MinMaxWorldDepths;
		  if ( !v60 )
		    goto LABEL_34;
		  v61 = 1 - this->fields.m_RTIndex;
		  if ( (unsigned int)v61 >= v60->fields.Desc._width_k__BackingField )
		    sub_1800D2AB0(v60, v58);
		  v60 = (VolumetricPipelineRT *)*((_QWORD *)&v60->fields.Desc._msaaSamples_k__BackingField + v61);
		  if ( !v60 )
		LABEL_34:
		    sub_1800D8260(v60, v58);
		  v62 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v60, 0LL);
		  v63 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v70, v62, 0LL);
		  v64 = *(_OWORD *)&v63->m_BufferPointer;
		  *(_OWORD *)&v68.m_Type = *(_OWORD *)&v63->m_Type;
		  *(_QWORD *)&v68.m_DepthSlice = *(_QWORD *)&v63->m_DepthSlice;
		  *(_OWORD *)&v68.m_BufferPointer = v64;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v59, &v68, 0LL);
		}
		
		private void UpdateDownResRender(ref VolumetricRenderInputs inputs) {} // 0x0000000189C596F0-0x0000000189C5A630
		// Void UpdateDownResRender(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResRender(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
		  HGRenderGraphContext *context; // rsi
		  CommandBuffer *cmd; // rsi
		  bool v9; // al
		  __int64 v10; // rdx
		  Material *m_VolumetricMat; // r15
		  HGVolumetricCloudSettingParameters *v12; // rcx
		  Shader *v13; // rbx
		  String *v14; // r8
		  __m128 v15; // xmm0
		  __m128 v16; // xmm6
		  int v17; // eax
		  __int64 v18; // rdx
		  Material *v19; // r15
		  Material *v20; // rcx
		  Shader *v21; // rbx
		  String *v22; // r8
		  Material *v23; // rbx
		  Shader *v24; // rax
		  String *v25; // r8
		  Material *v26; // r15
		  Material *v27; // rcx
		  Shader *v28; // rbx
		  String *v29; // r8
		  Material *v30; // rbx
		  Material *v31; // r15
		  Shader *v32; // rbx
		  String *v33; // r8
		  Shader *v34; // rax
		  String *v35; // r8
		  __m128 v36; // xmm1
		  int32_t v37; // r10d
		  __int64 v38; // rdx
		  HGVolumetricCloudSettingParameters *downResFilter; // rcx
		  int enableFraming; // ecx
		  int v41; // ecx
		  int v42; // ecx
		  Material *v43; // r14
		  Material *v44; // rcx
		  Shader *v45; // rbx
		  String *v46; // r8
		  Material *v47; // rbx
		  Shader *v48; // rax
		  String *v49; // r8
		  Material *v50; // rbx
		  Shader *v51; // rax
		  String *v52; // r8
		  Material *v53; // rbx
		  Shader *v54; // rax
		  String *v55; // r8
		  __int128 v56; // xmm0
		  __int64 v57; // xmm1_8
		  Material *v58; // r14
		  Material *v59; // rcx
		  Shader *v60; // rbx
		  String *v61; // r8
		  Material *v62; // rbx
		  Shader *v63; // rax
		  String *v64; // r8
		  Material *v65; // rbx
		  Shader *v66; // rax
		  String *v67; // r8
		  Material *v68; // r14
		  Shader *v69; // rbx
		  String *v70; // r8
		  Material *v71; // rbx
		  Shader *v72; // rax
		  String *v73; // r8
		  Material *v74; // rbx
		  Shader *v75; // rax
		  String *v76; // r8
		  Shader *v77; // rax
		  String *v78; // r8
		  Material *v79; // r14
		  Material *v80; // rcx
		  Shader *v81; // rbx
		  String *v82; // r8
		  Material *v83; // rbx
		  Shader *v84; // rax
		  String *v85; // r8
		  Material *v86; // rbx
		  Shader *v87; // rax
		  String *v88; // r8
		  Material *v89; // rbx
		  Shader *v90; // rax
		  String *v91; // r8
		  Shader *shader; // rbx
		  String *s_EnableDownscale; // r8
		  Material *v94; // rbx
		  Shader *v95; // rax
		  String *s_DownscaleTriple; // r8
		  Material *v97; // rbx
		  Shader *v98; // rax
		  String *s_DownscaleQuarter; // r8
		  Material *v100; // rbx
		  Shader *v101; // rax
		  String *s_UpscaleBilateral; // r8
		  Material *v103; // rbx
		  Shader *v104; // rax
		  String *s_UpscaleNearest; // r8
		  Material *v106; // rbx
		  Shader *v107; // rax
		  String *s_UpscaleNoisy; // r8
		  Material *v109; // rbx
		  Shader *v110; // rax
		  String *s_EnableMinMaxDepth; // r8
		  int32_t v112; // r10d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LocalKeyword keyword_8; // [rsp+28h] [rbp-E0h] BYREF
		  LocalKeyword v115; // [rsp+48h] [rbp-C0h] BYREF
		  LocalKeyword v116; // [rsp+68h] [rbp-A0h] BYREF
		  LocalKeyword v117; // [rsp+80h] [rbp-88h] BYREF
		  LocalKeyword v118; // [rsp+98h] [rbp-70h] BYREF
		  LocalKeyword v119; // [rsp+B0h] [rbp-58h] BYREF
		  LocalKeyword v120; // [rsp+C8h] [rbp-40h] BYREF
		  LocalKeyword v121; // [rsp+E0h] [rbp-28h] BYREF
		  LocalKeyword v122; // [rsp+F8h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5165, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5165, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		      return;
		    }
		LABEL_65:
		    sub_1800D8260(volumetricParameters, v5);
		  }
		  context = inputs->context;
		  if ( !context )
		    goto LABEL_65;
		  volumetricParameters = inputs->volumetricParameters;
		  cmd = context->fields.cmd;
		  if ( !volumetricParameters )
		    goto LABEL_65;
		  v9 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         volumetricParameters->fields.enableDownRes,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  m_VolumetricMat = this->fields.m_VolumetricMat;
		  v12 = (HGVolumetricCloudSettingParameters *)m_VolumetricMat;
		  if ( !v9 )
		  {
		    if ( !m_VolumetricMat )
		      goto LABEL_63;
		    shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    s_EnableDownscale = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableDownscale;
		    memset(&v118, 0, sizeof(v118));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, shader, s_EnableDownscale, 0LL);
		    keyword_8 = v118;
		    if ( !cmd )
		      goto LABEL_63;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, m_VolumetricMat, &keyword_8, 0LL);
		    v94 = this->fields.m_VolumetricMat;
		    v12 = (HGVolumetricCloudSettingParameters *)v94;
		    if ( !v94 )
		      goto LABEL_63;
		    v95 = UnityEngine::Material::get_shader(v94, 0LL);
		    s_DownscaleTriple = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleTriple;
		    memset(&v117, 0, sizeof(v117));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v95, s_DownscaleTriple, 0LL);
		    keyword_8 = v117;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v94, &keyword_8, 0LL);
		    v97 = this->fields.m_VolumetricMat;
		    v12 = (HGVolumetricCloudSettingParameters *)v97;
		    if ( !v97 )
		      goto LABEL_63;
		    v98 = UnityEngine::Material::get_shader(v97, 0LL);
		    s_DownscaleQuarter = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleQuarter;
		    memset(&v116, 0, sizeof(v116));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v98, s_DownscaleQuarter, 0LL);
		    keyword_8 = v116;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v97, &keyword_8, 0LL);
		    v100 = this->fields.m_VolumetricMat;
		    v12 = (HGVolumetricCloudSettingParameters *)v100;
		    if ( !v100 )
		      goto LABEL_63;
		    v101 = UnityEngine::Material::get_shader(v100, 0LL);
		    s_UpscaleBilateral = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleBilateral;
		    memset(&v119, 0, sizeof(v119));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v119, v101, s_UpscaleBilateral, 0LL);
		    keyword_8 = v119;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v100, &keyword_8, 0LL);
		    v103 = this->fields.m_VolumetricMat;
		    v12 = (HGVolumetricCloudSettingParameters *)v103;
		    if ( !v103 )
		      goto LABEL_63;
		    v104 = UnityEngine::Material::get_shader(v103, 0LL);
		    s_UpscaleNearest = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNearest;
		    memset(&v120, 0, sizeof(v120));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v120, v104, s_UpscaleNearest, 0LL);
		    keyword_8 = v120;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v103, &keyword_8, 0LL);
		    v106 = this->fields.m_VolumetricMat;
		    v12 = (HGVolumetricCloudSettingParameters *)v106;
		    if ( !v106 )
		      goto LABEL_63;
		    v107 = UnityEngine::Material::get_shader(v106, 0LL);
		    s_UpscaleNoisy = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNoisy;
		    memset(&v121, 0, sizeof(v121));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v121, v107, s_UpscaleNoisy, 0LL);
		    keyword_8 = v121;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v106, &keyword_8, 0LL);
		    v109 = this->fields.m_VolumetricMat;
		    v12 = (HGVolumetricCloudSettingParameters *)v109;
		    if ( !v109 )
		LABEL_63:
		      sub_1800D8260(v12, v10);
		    v110 = UnityEngine::Material::get_shader(v109, 0LL);
		    s_EnableMinMaxDepth = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableMinMaxDepth;
		    memset(&v122, 0, sizeof(v122));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v122, v110, s_EnableMinMaxDepth, 0LL);
		    keyword_8 = v122;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v109, &keyword_8, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    *(_OWORD *)&v115.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)sub_183240A00(
		                                                               &v115,
		                                                               _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v112, (Vector4 *)&v115, 0LL);
		    return;
		  }
		  if ( !m_VolumetricMat )
		    goto LABEL_53;
		  v13 = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		  v14 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableDownscale;
		  memset(&v115, 0, sizeof(v115));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v13, v14, 0LL);
		  keyword_8 = v115;
		  v15 = *(__m128 *)&v115.m_SpaceInfo.m_KeywordSpace;
		  if ( !cmd
		    || (UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, m_VolumetricMat, &keyword_8, 0LL),
		        (v12 = inputs->volumetricParameters) == 0LL) )
		  {
		LABEL_53:
		    sub_1800D8260(v12, v10);
		  }
		  v15.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                      v12->fields.downResRatio,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v16 = v15;
		  v17 = sub_1832DBD50();
		  if ( v17 == 2 )
		  {
		    v31 = this->fields.m_VolumetricMat;
		    v27 = v31;
		    if ( !v31 )
		      goto LABEL_52;
		    v32 = UnityEngine::Material::get_shader(v31, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v33 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleTriple;
		    memset(&v116, 0, sizeof(v116));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v32, v33, 0LL);
		    keyword_8 = v116;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v31, &keyword_8, 0LL);
		    v30 = this->fields.m_VolumetricMat;
		    v27 = v30;
		    if ( !v30 )
		LABEL_52:
		      sub_1800D8260(v27, v18);
		  }
		  else
		  {
		    if ( v17 != 3 )
		    {
		      if ( v17 == 4 )
		      {
		        v19 = this->fields.m_VolumetricMat;
		        v20 = v19;
		        if ( !v19 )
		          goto LABEL_14;
		        v21 = UnityEngine::Material::get_shader(v19, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        v22 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleTriple;
		        memset(&v115, 0, sizeof(v115));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v21, v22, 0LL);
		        keyword_8 = v115;
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v19, &keyword_8, 0LL);
		        v23 = this->fields.m_VolumetricMat;
		        v20 = v23;
		        if ( !v23 )
		LABEL_14:
		          sub_1800D8260(v20, v18);
		        v24 = UnityEngine::Material::get_shader(v23, 0LL);
		        v25 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleQuarter;
		        memset(&v116, 0, sizeof(v116));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v24, v25, 0LL);
		        keyword_8 = v116;
		        UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v23, &keyword_8, 0LL);
		      }
		      goto LABEL_21;
		    }
		    v26 = this->fields.m_VolumetricMat;
		    v27 = v26;
		    if ( !v26 )
		      goto LABEL_17;
		    v28 = UnityEngine::Material::get_shader(v26, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v29 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleTriple;
		    memset(&v116, 0, sizeof(v116));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v28, v29, 0LL);
		    keyword_8 = v116;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v26, &keyword_8, 0LL);
		    v30 = this->fields.m_VolumetricMat;
		    v27 = v30;
		    if ( !v30 )
		LABEL_17:
		      sub_1800D8260(v27, v18);
		  }
		  v34 = UnityEngine::Material::get_shader(v27, 0LL);
		  v35 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_DownscaleQuarter;
		  memset(&v115, 0, sizeof(v115));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v34, v35, 0LL);
		  keyword_8 = v115;
		  UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v30, &keyword_8, 0LL);
		LABEL_21:
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  v36 = (__m128)0x3F800000u;
		  v36.m128_f32[0] = 1.0 / v16.m128_f32[0];
		  *(_OWORD *)&v115.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)sub_183240A00(&v115, _mm_unpacklo_ps(v16, v36).m128_u64[0]);
		  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, v37, (Vector4 *)&v115, 0LL);
		  downResFilter = inputs->volumetricParameters;
		  if ( !downResFilter
		    || (downResFilter = (HGVolumetricCloudSettingParameters *)downResFilter->fields.downResFilter) == 0LL )
		  {
		    sub_1800D8260(downResFilter, v38);
		  }
		  enableFraming = (int)downResFilter->fields.enableFraming;
		  if ( enableFraming )
		  {
		    v41 = enableFraming - 1;
		    if ( v41 )
		    {
		      v42 = v41 - 1;
		      if ( v42 )
		      {
		        if ( v42 != 1 )
		          return;
		        v43 = this->fields.m_VolumetricMat;
		        v44 = v43;
		        if ( !v43 )
		          goto LABEL_32;
		        v45 = UnityEngine::Material::get_shader(v43, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        v46 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleBilateral;
		        memset(&v116, 0, sizeof(v116));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v45, v46, 0LL);
		        keyword_8 = v116;
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v43, &keyword_8, 0LL);
		        v47 = this->fields.m_VolumetricMat;
		        v44 = v47;
		        if ( !v47 )
		          goto LABEL_32;
		        v48 = UnityEngine::Material::get_shader(v47, 0LL);
		        v49 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNearest;
		        memset(&v115, 0, sizeof(v115));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v48, v49, 0LL);
		        keyword_8 = v115;
		        UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v47, &keyword_8, 0LL);
		        v50 = this->fields.m_VolumetricMat;
		        v44 = v50;
		        if ( !v50 )
		          goto LABEL_32;
		        v51 = UnityEngine::Material::get_shader(v50, 0LL);
		        v52 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNoisy;
		        memset(&v117, 0, sizeof(v117));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v51, v52, 0LL);
		        keyword_8 = v117;
		        UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v50, &keyword_8, 0LL);
		        v53 = this->fields.m_VolumetricMat;
		        v44 = v53;
		        if ( !v53 )
		LABEL_32:
		          sub_1800D8260(v44, v38);
		        v54 = UnityEngine::Material::get_shader(v53, 0LL);
		        v55 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableMinMaxDepth;
		        memset(&v118, 0, sizeof(v118));
		        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v54, v55, 0LL);
		        v56 = *(_OWORD *)&v118.m_SpaceInfo.m_KeywordSpace;
		        v57 = *(_QWORD *)&v118.m_Index;
		        goto LABEL_43;
		      }
		      v58 = this->fields.m_VolumetricMat;
		      v59 = v58;
		      if ( !v58 )
		        goto LABEL_37;
		      v60 = UnityEngine::Material::get_shader(v58, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		      v61 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleBilateral;
		      memset(&v118, 0, sizeof(v118));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v60, v61, 0LL);
		      keyword_8 = v118;
		      UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v58, &keyword_8, 0LL);
		      v62 = this->fields.m_VolumetricMat;
		      v59 = v62;
		      if ( !v62 )
		        goto LABEL_37;
		      v63 = UnityEngine::Material::get_shader(v62, 0LL);
		      v64 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNearest;
		      memset(&v117, 0, sizeof(v117));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v63, v64, 0LL);
		      keyword_8 = v117;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v62, &keyword_8, 0LL);
		      v65 = this->fields.m_VolumetricMat;
		      v59 = v65;
		      if ( !v65 )
		        goto LABEL_37;
		      v66 = UnityEngine::Material::get_shader(v65, 0LL);
		      v67 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNoisy;
		      memset(&v116, 0, sizeof(v116));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v66, v67, 0LL);
		      keyword_8 = v116;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v65, &keyword_8, 0LL);
		      v53 = this->fields.m_VolumetricMat;
		      v59 = v53;
		      if ( !v53 )
		LABEL_37:
		        sub_1800D8260(v59, v38);
		    }
		    else
		    {
		      v68 = this->fields.m_VolumetricMat;
		      v59 = v68;
		      if ( !v68 )
		        goto LABEL_44;
		      v69 = UnityEngine::Material::get_shader(v68, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		      v70 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleBilateral;
		      memset(&v118, 0, sizeof(v118));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v69, v70, 0LL);
		      keyword_8 = v118;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v68, &keyword_8, 0LL);
		      v71 = this->fields.m_VolumetricMat;
		      v59 = v71;
		      if ( !v71 )
		        goto LABEL_44;
		      v72 = UnityEngine::Material::get_shader(v71, 0LL);
		      v73 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNearest;
		      memset(&v117, 0, sizeof(v117));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v72, v73, 0LL);
		      keyword_8 = v117;
		      UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v71, &keyword_8, 0LL);
		      v74 = this->fields.m_VolumetricMat;
		      v59 = v74;
		      if ( !v74 )
		        goto LABEL_44;
		      v75 = UnityEngine::Material::get_shader(v74, 0LL);
		      v76 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNoisy;
		      memset(&v116, 0, sizeof(v116));
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v75, v76, 0LL);
		      keyword_8 = v116;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v74, &keyword_8, 0LL);
		      v53 = this->fields.m_VolumetricMat;
		      v59 = v53;
		      if ( !v53 )
		LABEL_44:
		        sub_1800D8260(v59, v38);
		    }
		    v77 = UnityEngine::Material::get_shader(v59, 0LL);
		    v78 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableMinMaxDepth;
		    memset(&v115, 0, sizeof(v115));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v77, v78, 0LL);
		    v56 = *(_OWORD *)&v115.m_SpaceInfo.m_KeywordSpace;
		    v57 = *(_QWORD *)&v115.m_Index;
		LABEL_43:
		    *(_QWORD *)&keyword_8.m_Index = v57;
		    *(_OWORD *)&keyword_8.m_SpaceInfo.m_KeywordSpace = v56;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v53, &keyword_8, 0LL);
		    return;
		  }
		  v79 = this->fields.m_VolumetricMat;
		  v80 = v79;
		  if ( !v79 )
		    goto LABEL_50;
		  v81 = UnityEngine::Material::get_shader(v79, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		  v82 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleBilateral;
		  memset(&v118, 0, sizeof(v118));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v118, v81, v82, 0LL);
		  keyword_8 = v118;
		  UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v79, &keyword_8, 0LL);
		  v83 = this->fields.m_VolumetricMat;
		  v80 = v83;
		  if ( !v83 )
		    goto LABEL_50;
		  v84 = UnityEngine::Material::get_shader(v83, 0LL);
		  v85 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNearest;
		  memset(&v117, 0, sizeof(v117));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v117, v84, v85, 0LL);
		  keyword_8 = v117;
		  UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v83, &keyword_8, 0LL);
		  v86 = this->fields.m_VolumetricMat;
		  v80 = v86;
		  if ( !v86 )
		    goto LABEL_50;
		  v87 = UnityEngine::Material::get_shader(v86, 0LL);
		  v88 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_UpscaleNoisy;
		  memset(&v116, 0, sizeof(v116));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v116, v87, v88, 0LL);
		  keyword_8 = v116;
		  UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v86, &keyword_8, 0LL);
		  v89 = this->fields.m_VolumetricMat;
		  v80 = v89;
		  if ( !v89 )
		LABEL_50:
		    sub_1800D8260(v80, v38);
		  v90 = UnityEngine::Material::get_shader(v89, 0LL);
		  v91 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_EnableMinMaxDepth;
		  memset(&v115, 0, sizeof(v115));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v115, v90, v91, 0LL);
		  keyword_8 = v115;
		  UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v89, &keyword_8, 0LL);
		}
		
		private void UpdateFramingRender(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5A630-0x0000000189C5AE74
		// Void UpdateFramingRender(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateFramingRender(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  VolumetricShaderIDs__StaticFields *v5; // rdx
		  void *static_fields; // rcx
		  HGRenderGraphContext *context; // rsi
		  CommandBuffer *cmd; // rsi
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rax
		  int v10; // r8d
		  Material *v11; // rbx
		  VolumetricShaderIDs__StaticFields *v12; // rax
		  int32_t PixelSubOffset; // ebx
		  int32_t Int; // eax
		  bool v15; // al
		  __int64 v16; // rdx
		  Material *v17; // r15
		  Shader *v18; // rbx
		  String *v19; // r8
		  Shader *v20; // rbx
		  String *v21; // r8
		  bool v22; // al
		  __int64 v23; // rdx
		  Material *v24; // r15
		  Shader *v25; // rbx
		  String *v26; // r8
		  Shader *v27; // rbx
		  String *v28; // r8
		  bool v29; // al
		  __int64 v30; // rdx
		  Material *v31; // r15
		  Shader *v32; // rbx
		  String *v33; // r8
		  Shader *v34; // rbx
		  String *v35; // r8
		  bool v36; // al
		  __int64 v37; // rdx
		  Material *v38; // r14
		  Shader *v39; // rbx
		  String *v40; // r8
		  __int128 v41; // xmm0
		  Material *v42; // rdx
		  __int64 v43; // xmm1_8
		  Shader *v44; // rbx
		  String *v45; // r8
		  Material *m_VolumetricMat; // r14
		  Material *v47; // rcx
		  Shader *shader; // rbx
		  String *s_ReconstructEnableMotionVector; // r8
		  Material *v50; // rbx
		  Shader *v51; // rax
		  String *s_ReconstructEnableDepthOpt; // r8
		  Material *v53; // rbx
		  Shader *v54; // rax
		  String *s_ReconstructEnableColorAABB; // r8
		  Material *v56; // rbx
		  Shader *v57; // rax
		  String *s_ReconstructEnableNeighborAvg; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LocalKeyword v60; // [rsp+28h] [rbp-39h] BYREF
		  LocalKeyword keyword; // [rsp+40h] [rbp-21h] BYREF
		  LocalKeyword v62; // [rsp+58h] [rbp-9h] BYREF
		  LocalKeyword v63; // [rsp+70h] [rbp+Fh] BYREF
		  LocalKeyword v64; // [rsp+88h] [rbp+27h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5163, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5163, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		      return;
		    }
		    goto LABEL_56;
		  }
		  context = inputs->context;
		  if ( !context )
		    goto LABEL_56;
		  cmd = context->fields.cmd;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !cmd )
		    goto LABEL_56;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		    cmd,
		    *((_DWORD *)static_fields + 263),
		    this->fields._DrawFrameCount_k__BackingField % 8,
		    0LL);
		  UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		    cmd,
		    TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod16,
		    this->fields._DrawFrameCount_k__BackingField % 16,
		    0LL);
		  UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		    cmd,
		    TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FrameCountMod32,
		    this->fields._DrawFrameCount_k__BackingField % 32,
		    0LL);
		  if ( !this->fields.m_EnableFraming )
		  {
		    m_VolumetricMat = this->fields.m_VolumetricMat;
		    v47 = m_VolumetricMat;
		    if ( !m_VolumetricMat )
		      goto LABEL_54;
		    shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    s_ReconstructEnableMotionVector = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableMotionVector;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, shader, s_ReconstructEnableMotionVector, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, m_VolumetricMat, &keyword, 0LL);
		    v50 = this->fields.m_VolumetricMat;
		    v47 = v50;
		    if ( !v50 )
		      goto LABEL_54;
		    v51 = UnityEngine::Material::get_shader(v50, 0LL);
		    s_ReconstructEnableDepthOpt = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableDepthOpt;
		    memset(&v62, 0, sizeof(v62));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v62, v51, s_ReconstructEnableDepthOpt, 0LL);
		    keyword = v62;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v50, &keyword, 0LL);
		    v53 = this->fields.m_VolumetricMat;
		    v47 = v53;
		    if ( !v53 )
		      goto LABEL_54;
		    v54 = UnityEngine::Material::get_shader(v53, 0LL);
		    s_ReconstructEnableColorAABB = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableColorAABB;
		    memset(&v63, 0, sizeof(v63));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v63, v54, s_ReconstructEnableColorAABB, 0LL);
		    keyword = v63;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v53, &keyword, 0LL);
		    v56 = this->fields.m_VolumetricMat;
		    v47 = v56;
		    if ( !v56 )
		LABEL_54:
		      sub_1800D8260(v47, v5);
		    v57 = UnityEngine::Material::get_shader(v56, 0LL);
		    s_ReconstructEnableNeighborAvg = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableNeighborAvg;
		    memset(&v64, 0, sizeof(v64));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v64, v57, s_ReconstructEnableNeighborAvg, 0LL);
		    v41 = *(_OWORD *)&v64.m_SpaceInfo.m_KeywordSpace;
		    v42 = v56;
		    v43 = *(_QWORD *)&v64.m_Index;
		    goto LABEL_53;
		  }
		  volumetricParameters = inputs->volumetricParameters;
		  if ( !volumetricParameters )
		    goto LABEL_56;
		  static_fields = volumetricParameters->fields.framingLevel;
		  if ( !static_fields )
		    goto LABEL_56;
		  if ( *((_DWORD *)static_fields + 10) )
		  {
		    if ( *((_DWORD *)static_fields + 10) != 1 )
		      goto LABEL_12;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    v10 = 4;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    v10 = 2;
		  }
		  UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		    cmd,
		    TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PixelSubOffset,
		    this->fields._DrawFrameCount_k__BackingField % v10,
		    0LL);
		LABEL_12:
		  v11 = this->fields.m_VolumetricMat;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  v5 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !v11 )
		    goto LABEL_56;
		  if ( UnityEngine::Material::GetInt(v11, v5->_DebugPixelOffset, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    static_fields = this->fields.m_VolumetricMat;
		    v12 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    PixelSubOffset = v12->_PixelSubOffset;
		    if ( !static_fields )
		      goto LABEL_56;
		    Int = UnityEngine::Material::GetInt((Material *)static_fields, v12->_PixelOffsetTest, 0LL);
		    UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, PixelSubOffset, Int, 0LL);
		  }
		  static_fields = inputs->volumetricParameters;
		  if ( !static_fields )
		    goto LABEL_56;
		  v15 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          *((SettingParameter_1_System_Boolean_ **)static_fields + 9),
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v17 = this->fields.m_VolumetricMat;
		  if ( v15 )
		  {
		    if ( !v17 )
		      sub_1800D8260(0LL, v16);
		    v20 = UnityEngine::Material::get_shader(v17, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v21 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableMotionVector;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v20, v21, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v17, &keyword, 0LL);
		  }
		  else
		  {
		    if ( !v17 )
		      sub_1800D8260(0LL, v16);
		    v18 = UnityEngine::Material::get_shader(v17, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v19 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableMotionVector;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v18, v19, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v17, &keyword, 0LL);
		  }
		  static_fields = inputs->volumetricParameters;
		  if ( !static_fields )
		    goto LABEL_56;
		  v22 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          *((SettingParameter_1_System_Boolean_ **)static_fields + 10),
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v24 = this->fields.m_VolumetricMat;
		  if ( v22 )
		  {
		    if ( !v24 )
		      sub_1800D8260(0LL, v23);
		    v27 = UnityEngine::Material::get_shader(v24, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v28 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableDepthOpt;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v27, v28, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v24, &keyword, 0LL);
		  }
		  else
		  {
		    if ( !v24 )
		      sub_1800D8260(0LL, v23);
		    v25 = UnityEngine::Material::get_shader(v24, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v26 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableDepthOpt;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v25, v26, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v24, &keyword, 0LL);
		  }
		  static_fields = inputs->volumetricParameters;
		  if ( !static_fields )
		    goto LABEL_56;
		  v29 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          *((SettingParameter_1_System_Boolean_ **)static_fields + 11),
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v31 = this->fields.m_VolumetricMat;
		  if ( v29 )
		  {
		    if ( !v31 )
		      sub_1800D8260(0LL, v30);
		    v34 = UnityEngine::Material::get_shader(v31, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v35 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableColorAABB;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v34, v35, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v31, &keyword, 0LL);
		  }
		  else
		  {
		    if ( !v31 )
		      sub_1800D8260(0LL, v30);
		    v32 = UnityEngine::Material::get_shader(v31, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v33 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableColorAABB;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v32, v33, 0LL);
		    keyword = v60;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v31, &keyword, 0LL);
		  }
		  static_fields = inputs->volumetricParameters;
		  if ( !static_fields )
		LABEL_56:
		    sub_1800D8260(static_fields, v5);
		  v36 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          *((SettingParameter_1_System_Boolean_ **)static_fields + 12),
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v38 = this->fields.m_VolumetricMat;
		  if ( !v36 )
		  {
		    if ( !v38 )
		      sub_1800D8260(0LL, v37);
		    v39 = UnityEngine::Material::get_shader(v38, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v40 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableNeighborAvg;
		    memset(&v60, 0, sizeof(v60));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v39, v40, 0LL);
		    v41 = *(_OWORD *)&v60.m_SpaceInfo.m_KeywordSpace;
		    v42 = v38;
		    v43 = *(_QWORD *)&v60.m_Index;
		LABEL_53:
		    *(_QWORD *)&keyword.m_Index = v43;
		    *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v41;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v42, &keyword, 0LL);
		    return;
		  }
		  if ( !v38 )
		    sub_1800D8260(0LL, v37);
		  v44 = UnityEngine::Material::get_shader(v38, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		  v45 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_ReconstructEnableNeighborAvg;
		  memset(&v60, 0, sizeof(v60));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v60, v44, v45, 0LL);
		  keyword = v60;
		  UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v38, &keyword, 0LL);
		}
		
		private void UpdateTAARender(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5C140-0x0000000189C5C810
		// Void UpdateTAARender(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateTAARender(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
		  HGRenderGraphContext *context; // rsi
		  CommandBuffer *cmd; // rsi
		  bool v9; // al
		  __int64 v10; // rdx
		  Material *v11; // r15
		  Material *v12; // rcx
		  Shader *v13; // rbx
		  String *v14; // r8
		  Shader *v15; // rbx
		  String *v16; // r8
		  bool v17; // al
		  __int64 v18; // rdx
		  Material *v19; // r15
		  Shader *v20; // rbx
		  String *v21; // r8
		  Shader *v22; // rbx
		  String *v23; // r8
		  bool v24; // al
		  __int64 v25; // rdx
		  Material *v26; // r15
		  Shader *v27; // rbx
		  String *v28; // r8
		  Shader *v29; // rbx
		  String *v30; // r8
		  bool v31; // al
		  __int64 v32; // rdx
		  Material *v33; // r14
		  Shader *v34; // rbx
		  String *v35; // r8
		  __int128 v36; // xmm0
		  Material *v37; // rdx
		  __int64 v38; // xmm1_8
		  Shader *v39; // rbx
		  String *v40; // r8
		  Material *m_VolumetricMat; // r14
		  Material *v42; // rcx
		  Shader *shader; // rbx
		  String *s_TAAEnableMotionVector; // r8
		  Material *v45; // rbx
		  Shader *v46; // rax
		  String *s_TAAEnableDepthOpt; // r8
		  Material *v48; // rbx
		  Shader *v49; // rax
		  String *s_TAAEnableColorAABB; // r8
		  Material *v51; // rbx
		  Shader *v52; // rax
		  String *s_TAAEnableNeighborAvg; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LocalKeyword v55; // [rsp+28h] [rbp-39h] BYREF
		  LocalKeyword keyword; // [rsp+40h] [rbp-21h] BYREF
		  LocalKeyword v57; // [rsp+58h] [rbp-9h] BYREF
		  LocalKeyword v58; // [rsp+70h] [rbp+Fh] BYREF
		  LocalKeyword v59; // [rsp+88h] [rbp+27h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5164, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5164, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		      return;
		    }
		LABEL_47:
		    sub_1800D8260(volumetricParameters, v5);
		  }
		  context = inputs->context;
		  if ( !context )
		    goto LABEL_47;
		  cmd = context->fields.cmd;
		  if ( !this->fields.m_EnableTAA )
		  {
		    m_VolumetricMat = this->fields.m_VolumetricMat;
		    v42 = m_VolumetricMat;
		    if ( !m_VolumetricMat )
		      goto LABEL_45;
		    shader = UnityEngine::Material::get_shader(m_VolumetricMat, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    s_TAAEnableMotionVector = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableMotionVector;
		    memset(&v55, 0, sizeof(v55));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, shader, s_TAAEnableMotionVector, 0LL);
		    keyword = v55;
		    if ( !cmd )
		      goto LABEL_45;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, m_VolumetricMat, &keyword, 0LL);
		    v45 = this->fields.m_VolumetricMat;
		    v42 = v45;
		    if ( !v45 )
		      goto LABEL_45;
		    v46 = UnityEngine::Material::get_shader(v45, 0LL);
		    s_TAAEnableDepthOpt = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableDepthOpt;
		    memset(&v57, 0, sizeof(v57));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v57, v46, s_TAAEnableDepthOpt, 0LL);
		    keyword = v57;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v45, &keyword, 0LL);
		    v48 = this->fields.m_VolumetricMat;
		    v42 = v48;
		    if ( !v48 )
		      goto LABEL_45;
		    v49 = UnityEngine::Material::get_shader(v48, 0LL);
		    s_TAAEnableColorAABB = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableColorAABB;
		    memset(&v58, 0, sizeof(v58));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v58, v49, s_TAAEnableColorAABB, 0LL);
		    keyword = v58;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v48, &keyword, 0LL);
		    v51 = this->fields.m_VolumetricMat;
		    v42 = v51;
		    if ( !v51 )
		LABEL_45:
		      sub_1800D8260(v42, v5);
		    v52 = UnityEngine::Material::get_shader(v51, 0LL);
		    s_TAAEnableNeighborAvg = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableNeighborAvg;
		    memset(&v59, 0, sizeof(v59));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v59, v52, s_TAAEnableNeighborAvg, 0LL);
		    v36 = *(_OWORD *)&v59.m_SpaceInfo.m_KeywordSpace;
		    v37 = v51;
		    v38 = *(_QWORD *)&v59.m_Index;
		    goto LABEL_44;
		  }
		  volumetricParameters = inputs->volumetricParameters;
		  if ( !volumetricParameters )
		    goto LABEL_47;
		  v9 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         volumetricParameters->fields.enableTAAMotionVector,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v11 = this->fields.m_VolumetricMat;
		  v12 = v11;
		  if ( v9 )
		  {
		    if ( !v11
		      || (v15 = UnityEngine::Material::get_shader(v11, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		          v16 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableMotionVector,
		          memset(&v55, 0, sizeof(v55)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v15, v16, 0LL),
		          keyword = v55,
		          !cmd) )
		    {
		      sub_1800D8260(v12, v10);
		    }
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v11, &keyword, 0LL);
		  }
		  else
		  {
		    if ( !v11
		      || (v13 = UnityEngine::Material::get_shader(v11, 0LL),
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords),
		          v14 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableMotionVector,
		          memset(&v55, 0, sizeof(v55)),
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v13, v14, 0LL),
		          keyword = v55,
		          !cmd) )
		    {
		      sub_1800D8260(v12, v10);
		    }
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v11, &keyword, 0LL);
		  }
		  volumetricParameters = inputs->volumetricParameters;
		  if ( !volumetricParameters )
		    goto LABEL_47;
		  v17 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          volumetricParameters->fields.enableTAADepthOpt,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v19 = this->fields.m_VolumetricMat;
		  if ( v17 )
		  {
		    if ( !v19 )
		      sub_1800D8260(0LL, v18);
		    v22 = UnityEngine::Material::get_shader(v19, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v23 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableDepthOpt;
		    memset(&v55, 0, sizeof(v55));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v22, v23, 0LL);
		    keyword = v55;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v19, &keyword, 0LL);
		  }
		  else
		  {
		    if ( !v19 )
		      sub_1800D8260(0LL, v18);
		    v20 = UnityEngine::Material::get_shader(v19, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v21 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableDepthOpt;
		    memset(&v55, 0, sizeof(v55));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v20, v21, 0LL);
		    keyword = v55;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v19, &keyword, 0LL);
		  }
		  volumetricParameters = inputs->volumetricParameters;
		  if ( !volumetricParameters )
		    goto LABEL_47;
		  v24 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          volumetricParameters->fields.enableTAAColorAABB,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v26 = this->fields.m_VolumetricMat;
		  if ( v24 )
		  {
		    if ( !v26 )
		      sub_1800D8260(0LL, v25);
		    v29 = UnityEngine::Material::get_shader(v26, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v30 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableColorAABB;
		    memset(&v55, 0, sizeof(v55));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v29, v30, 0LL);
		    keyword = v55;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v26, &keyword, 0LL);
		  }
		  else
		  {
		    if ( !v26 )
		      sub_1800D8260(0LL, v25);
		    v27 = UnityEngine::Material::get_shader(v26, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v28 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableColorAABB;
		    memset(&v55, 0, sizeof(v55));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v27, v28, 0LL);
		    keyword = v55;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v26, &keyword, 0LL);
		  }
		  volumetricParameters = inputs->volumetricParameters;
		  if ( !volumetricParameters )
		    goto LABEL_47;
		  v31 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          volumetricParameters->fields.enableTAANeighborAvg,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v33 = this->fields.m_VolumetricMat;
		  if ( !v31 )
		  {
		    if ( !v33 )
		      sub_1800D8260(0LL, v32);
		    v34 = UnityEngine::Material::get_shader(v33, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    v35 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableNeighborAvg;
		    memset(&v55, 0, sizeof(v55));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v34, v35, 0LL);
		    v36 = *(_OWORD *)&v55.m_SpaceInfo.m_KeywordSpace;
		    v37 = v33;
		    v38 = *(_QWORD *)&v55.m_Index;
		LABEL_44:
		    *(_QWORD *)&keyword.m_Index = v38;
		    *(_OWORD *)&keyword.m_SpaceInfo.m_KeywordSpace = v36;
		    UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, v37, &keyword, 0LL);
		    return;
		  }
		  if ( !v33 )
		    sub_1800D8260(0LL, v32);
		  v39 = UnityEngine::Material::get_shader(v33, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		  v40 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_TAAEnableNeighborAvg;
		  memset(&v55, 0, sizeof(v55));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v55, v39, v40, 0LL);
		  keyword = v55;
		  UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, v33, &keyword, 0LL);
		}
		
		private void GetVolumetricRenderRTSize(ref VolumetricRenderInputs inputs) {} // 0x0000000189C56CAC-0x0000000189C56E7C
		// Void GetVolumetricRenderRTSize(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::GetVolumetricRenderRTSize(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rcx
		  HGCamera *hgCamera; // rdi
		  int32_t m_X; // ebp
		  __int64 v9; // rdi
		  float v10; // xmm6_4
		  int32_t v11; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v13; // [rsp+20h] [rbp-28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5166, 0LL) )
		  {
		    hgCamera = inputs->hgCamera;
		    this->fields.m_RenderWidth = 0;
		    this->fields.m_RenderHeight = 0;
		    if ( hgCamera )
		    {
		      m_X = hgCamera->fields._sceneRTSize_k__BackingField.m_X;
		      v9 = HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField);
		      this->fields.m_RenderHeight = v9;
		      this->fields.m_RenderWidth = m_X;
		      this->fields.m_NDCRescaleParams.x = 1.0;
		      this->fields.m_NDCRescaleParams.y = 1.0;
		      volumetricParameters = inputs->volumetricParameters;
		      if ( volumetricParameters )
		      {
		        if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                volumetricParameters->fields.enableDownRes,
		                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		        {
		LABEL_7:
		          v13.x = (float)(1.0 / (float)this->fields.m_RenderWidth) * (float)m_X;
		          v13.y = (float)(1.0 / (float)this->fields.m_RenderHeight) * (float)(int)v9;
		          v13.z = 1.0 / (float)m_X;
		          v13.w = 1.0 / (float)(int)v9;
		          this->fields.m_DownscaledScreenParams = v13;
		          return;
		        }
		        volumetricParameters = inputs->volumetricParameters;
		        if ( volumetricParameters )
		        {
		          v10 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                  volumetricParameters->fields.downResRatio,
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          this->fields.m_RenderWidth = sub_1832DBD50();
		          v11 = sub_1832DBD50();
		          this->fields.m_RenderHeight = v11;
		          this->fields.m_NDCRescaleParams.x = (float)((float)this->fields.m_RenderWidth * v10) / (float)m_X;
		          this->fields.m_NDCRescaleParams.y = (float)((float)v11 * v10) / (float)(int)v9;
		          goto LABEL_7;
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(volumetricParameters, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5166, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		}
		
		private void UpdateVolumetricRTs(ref VolumetricRenderInputs inputs) {} // 0x0000000189C5CBE8-0x0000000189C5D19C
		// Void UpdateVolumetricRTs(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricRenderer::UpdateVolumetricRTs(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  void *m_TAADepths; // rcx
		  HGRenderGraphContext *context; // rax
		  CommandBuffer *cmd; // r13
		  int i; // r14d
		  VolumetricPipelineRT__Array *m_TAAColors; // r12
		  int32_t m_RenderWidth; // edi
		  int32_t m_RenderHeight; // ebx
		  VolumetricPipelineRT **v13; // rax
		  int32_t v14; // edi
		  int32_t v15; // ebx
		  VolumetricPipelineRT **v16; // rax
		  Texture *RT; // rbx
		  bool v18; // al
		  VolumetricPipelineRT__Array *m_ReconstructColors; // r12
		  int32_t v20; // edi
		  int32_t v21; // ebx
		  VolumetricPipelineRT **v22; // rax
		  int32_t v23; // edi
		  int32_t v24; // ebx
		  VolumetricPipelineRT **v25; // rax
		  Texture *v26; // rbx
		  bool v27; // al
		  VolumetricPipelineRT__Array *m_MinMaxWorldDepths; // r12
		  int32_t v29; // edi
		  int32_t v30; // ebx
		  VolumetricPipelineRT **v31; // rax
		  int32_t v32; // edi
		  int32_t v33; // ebx
		  HGVolumetricCloudSettingParameters *volumetricParameters; // rax
		  int32_t m_FramingWidth; // edi
		  int32_t m_FramingHeight; // ebx
		  VolumetricShaderIDs__StaticFields *static_fields; // rcx
		  __int64 RTRes; // rdx
		  int32_t FramingRes; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v41; // [rsp+40h] [rbp-40h]
		  Vector4 value; // [rsp+50h] [rbp-30h] BYREF
		  Vector4 v43; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5167, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5167, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		      return;
		    }
		    goto LABEL_38;
		  }
		  context = inputs->context;
		  if ( !context )
		    goto LABEL_38;
		  cmd = context->fields.cmd;
		  for ( i = 0; i < 2; ++i )
		  {
		    m_TAAColors = this->fields.m_TAAColors;
		    if ( !m_TAAColors )
		      goto LABEL_38;
		    m_RenderWidth = this->fields.m_RenderWidth;
		    m_RenderHeight = this->fields.m_RenderHeight;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    v13 = (VolumetricPipelineRT **)sub_1800036C0(m_TAAColors, i);
		    HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		      (String *)"m_TAAColors",
		      v13,
		      m_RenderWidth,
		      m_RenderHeight,
		      RTLifeCycle__Enum_Persist,
		      RenderTextureFormat__Enum_ARGBHalf,
		      0,
		      0LL);
		    m_TAADepths = this->fields.m_TAADepths;
		    if ( !m_TAADepths )
		      goto LABEL_38;
		    v14 = this->fields.m_RenderWidth;
		    v15 = this->fields.m_RenderHeight;
		    v16 = (VolumetricPipelineRT **)sub_1800036C0(m_TAADepths, i);
		    HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		      (String *)"m_TAADepths",
		      v16,
		      v14,
		      v15,
		      RTLifeCycle__Enum_Persist,
		      RenderTextureFormat__Enum_RHalf,
		      0,
		      0LL);
		    m_TAADepths = this->fields.m_TAAColors;
		    if ( !m_TAADepths )
		      goto LABEL_38;
		    if ( (unsigned int)i >= *((_DWORD *)m_TAADepths + 6) )
		      goto LABEL_36;
		    m_TAADepths = (void *)*((_QWORD *)m_TAADepths + i + 4);
		    if ( !m_TAADepths )
		      goto LABEL_38;
		    RT = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)m_TAADepths, 0LL);
		    if ( UnityEngine::SystemInfo::SupportsCubicFilter(0LL) )
		    {
		      m_TAADepths = inputs->volumetricParameters;
		      if ( !m_TAADepths )
		        goto LABEL_38;
		      v18 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              *((SettingParameter_1_System_Boolean_ **)m_TAADepths + 14),
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    else
		    {
		      v18 = 0;
		    }
		    if ( !RT )
		      goto LABEL_38;
		    UnityEngine::Texture::set_cubicSample(RT, v18, 0LL);
		    m_ReconstructColors = this->fields.m_ReconstructColors;
		    if ( !m_ReconstructColors )
		      goto LABEL_38;
		    v20 = this->fields.m_RenderWidth;
		    v21 = this->fields.m_RenderHeight;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    v22 = (VolumetricPipelineRT **)sub_1800036C0(m_ReconstructColors, i);
		    HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		      (String *)"m_ReconstructColors",
		      v22,
		      v20,
		      v21,
		      RTLifeCycle__Enum_Persist,
		      RenderTextureFormat__Enum_ARGBHalf,
		      0,
		      0LL);
		    m_TAADepths = this->fields.m_ReconstructDepths;
		    if ( !m_TAADepths )
		      goto LABEL_38;
		    v23 = this->fields.m_RenderWidth;
		    v24 = this->fields.m_RenderHeight;
		    v25 = (VolumetricPipelineRT **)sub_1800036C0(m_TAADepths, i);
		    HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		      (String *)"m_ReconstructDepths",
		      v25,
		      v23,
		      v24,
		      RTLifeCycle__Enum_Persist,
		      RenderTextureFormat__Enum_RHalf,
		      0,
		      0LL);
		    m_TAADepths = this->fields.m_ReconstructColors;
		    if ( !m_TAADepths )
		      goto LABEL_38;
		    if ( (unsigned int)i >= *((_DWORD *)m_TAADepths + 6) )
		LABEL_36:
		      sub_1800D2AB0(m_TAADepths, v5);
		    m_TAADepths = (void *)*((_QWORD *)m_TAADepths + i + 4);
		    if ( !m_TAADepths )
		      goto LABEL_38;
		    v26 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT((VolumetricPipelineRT *)m_TAADepths, 0LL);
		    if ( UnityEngine::SystemInfo::SupportsCubicFilter(0LL) )
		    {
		      m_TAADepths = inputs->volumetricParameters;
		      if ( !m_TAADepths )
		        goto LABEL_38;
		      v27 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              *((SettingParameter_1_System_Boolean_ **)m_TAADepths + 8),
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    else
		    {
		      v27 = 0;
		    }
		    if ( !v26 )
		      goto LABEL_38;
		    UnityEngine::Texture::set_cubicSample(v26, v27, 0LL);
		    m_MinMaxWorldDepths = this->fields.m_MinMaxWorldDepths;
		    if ( !m_MinMaxWorldDepths )
		      goto LABEL_38;
		    v29 = this->fields.m_RenderWidth;
		    v30 = this->fields.m_RenderHeight;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    v31 = (VolumetricPipelineRT **)sub_1800036C0(m_MinMaxWorldDepths, i);
		    HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		      (String *)"m_MinMaxWorldDepths",
		      v31,
		      v29,
		      v30,
		      RTLifeCycle__Enum_Persist,
		      RenderTextureFormat__Enum_RFloat,
		      0,
		      0LL);
		  }
		  v32 = this->fields.m_RenderWidth;
		  v33 = this->fields.m_RenderHeight;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		  HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		    (String *)"m_DepthForTest",
		    &this->fields.m_DepthForTest,
		    v32,
		    v33,
		    RTLifeCycle__Enum_Transient,
		    RenderTextureFormat__Enum_Depth,
		    0,
		    0LL);
		  HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		    (String *)"m_ComposeColor",
		    &this->fields.m_ComposeColor,
		    this->fields.m_RenderWidth,
		    this->fields.m_RenderHeight,
		    RTLifeCycle__Enum_Persist,
		    RenderTextureFormat__Enum_ARGBHalf,
		    0,
		    0LL);
		  HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		    (String *)"m_ComposeDepth",
		    &this->fields.m_ComposeDepth,
		    this->fields.m_RenderWidth,
		    this->fields.m_RenderHeight,
		    RTLifeCycle__Enum_Persist,
		    RenderTextureFormat__Enum_RHalf,
		    0,
		    0LL);
		  this->fields.m_FramingWidth = this->fields.m_RenderWidth;
		  this->fields.m_FramingHeight = this->fields.m_RenderHeight;
		  if ( !this->fields.m_EnableFraming )
		    goto LABEL_33;
		  volumetricParameters = inputs->volumetricParameters;
		  if ( !volumetricParameters || (m_TAADepths = volumetricParameters->fields.framingLevel) == 0LL )
		LABEL_38:
		    sub_1800D8260(m_TAADepths, v5);
		  if ( *((_DWORD *)m_TAADepths + 10) )
		  {
		    if ( *((_DWORD *)m_TAADepths + 10) == 1 )
		    {
		      this->fields.m_FramingWidth = (this->fields.m_RenderWidth + 1) / 2;
		      this->fields.m_FramingHeight = (this->fields.m_RenderHeight + 1) / 2;
		    }
		  }
		  else
		  {
		    this->fields.m_FramingWidth = (this->fields.m_RenderWidth + 1) / 2;
		  }
		LABEL_33:
		  m_FramingWidth = this->fields.m_FramingWidth;
		  m_FramingHeight = this->fields.m_FramingHeight;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		  HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		    (String *)"m_FramingColor",
		    &this->fields.m_FramingColor,
		    m_FramingWidth,
		    m_FramingHeight,
		    RTLifeCycle__Enum_Transient,
		    RenderTextureFormat__Enum_ARGBHalf,
		    0,
		    0LL);
		  HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		    (String *)"m_FramingDepth",
		    &this->fields.m_FramingDepth,
		    this->fields.m_FramingWidth,
		    this->fields.m_FramingHeight,
		    RTLifeCycle__Enum_Transient,
		    RenderTextureFormat__Enum_RGHalf,
		    0,
		    0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  RTRes = (unsigned int)static_fields->_RTRes;
		  if ( !cmd )
		    sub_1800D8260(static_fields, RTRes);
		  v41.w = 1.0 / (float)this->fields.m_RenderHeight;
		  v41.z = 1.0 / (float)this->fields.m_RenderWidth;
		  v41.x = (float)this->fields.m_RenderWidth;
		  v41.y = (float)this->fields.m_RenderHeight;
		  value = v41;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, RTRes, &value, 0LL);
		  FramingRes = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FramingRes;
		  v41.z = 1.0 / (float)this->fields.m_FramingWidth;
		  v41.w = 1.0 / (float)this->fields.m_FramingHeight;
		  v41.x = (float)this->fields.m_FramingWidth;
		  v41.y = (float)this->fields.m_FramingHeight;
		  v43 = v41;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, FramingRes, &v43, 0LL);
		}
		
		private void ReleaseVolumetricRTs(bool full) {} // 0x000000018451E590-0x000000018451E730
		// Void ReleaseVolumetricRTs(Boolean)
		void HG::Rendering::Runtime::VolumetricRenderer::ReleaseVolumetricRTs(
		        VolumetricRenderer *this,
		        bool full,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  VolumetricPipelineRT__Array *m_TAADepths; // rcx
		  int i; // edi
		  VolumetricPipelineRT__Array *m_TAAColors; // rbp
		  VolumetricPipelineRT **v9; // rax
		  VolumetricPipelineRT **v10; // rax
		  VolumetricPipelineRT **v11; // rax
		  VolumetricPipelineRT **v12; // rax
		  VolumetricPipelineRT **v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3457, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3457, 0LL);
		    if ( !Patch )
		LABEL_4:
		      sub_1800D8260(m_TAADepths, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, full, 0LL);
		  }
		  else
		  {
		    for ( i = 0; i < 2; ++i )
		    {
		      m_TAAColors = this->fields.m_TAAColors;
		      if ( !m_TAAColors )
		        goto LABEL_4;
		      if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v9 = (VolumetricPipelineRT **)sub_1800036C0(m_TAAColors, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v9, full, 0LL);
		      m_TAADepths = this->fields.m_TAADepths;
		      if ( !m_TAADepths )
		        goto LABEL_4;
		      v10 = (VolumetricPipelineRT **)sub_1800036C0(m_TAADepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v10, full, 0LL);
		      m_TAADepths = this->fields.m_ReconstructColors;
		      if ( !m_TAADepths )
		        goto LABEL_4;
		      v11 = (VolumetricPipelineRT **)sub_1800036C0(m_TAADepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v11, full, 0LL);
		      m_TAADepths = this->fields.m_ReconstructDepths;
		      if ( !m_TAADepths )
		        goto LABEL_4;
		      v12 = (VolumetricPipelineRT **)sub_1800036C0(m_TAADepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v12, full, 0LL);
		      m_TAADepths = this->fields.m_MinMaxWorldDepths;
		      if ( !m_TAADepths )
		        goto LABEL_4;
		      v13 = (VolumetricPipelineRT **)sub_1800036C0(m_TAADepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v13, full, 0LL);
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_DepthForTest, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_ComposeColor, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_ComposeDepth, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FramingColor, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FramingDepth, full, 0LL);
		  }
		}
		
		public void DumpRTStats() {} // 0x0000000189C566D8-0x0000000189C5686C
		// Void DumpRTStats()
		void HG::Rendering::Runtime::VolumetricRenderer::DumpRTStats(VolumetricRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  int i; // edi
		  VolumetricPipelineRT__Array *m_TAAColors; // rbx
		  Object *v7; // rbx
		  VolumetricPipelineRT__Array *m_TAADepths; // rax
		  VolumetricPipelineRT__Array *m_ReconstructColors; // rax
		  VolumetricPipelineRT__Array *m_ReconstructDepths; // rax
		  VolumetricPipelineRT__Array *m_MinMaxWorldDepths; // rax
		  Object *m_DepthForTest; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5209, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5209, 0LL);
		    if ( !Patch )
		LABEL_17:
		      sub_1800D8260(v4, v3);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    for ( i = 0; i < 2; ++i )
		    {
		      m_TAAColors = this->fields.m_TAAColors;
		      if ( !m_TAAColors )
		        goto LABEL_17;
		      if ( (unsigned int)i >= m_TAAColors->max_length.size )
		        goto LABEL_15;
		      v7 = (Object *)m_TAAColors->vector[i];
		      sub_1800036A0(TypeInfo::UnityEngine::Debug);
		      UnityEngine::Debug::Log(v7, 0LL);
		      m_TAADepths = this->fields.m_TAADepths;
		      if ( !m_TAADepths )
		        goto LABEL_17;
		      if ( (unsigned int)i >= m_TAADepths->max_length.size )
		        goto LABEL_15;
		      UnityEngine::Debug::Log((Object *)m_TAADepths->vector[i], 0LL);
		      m_ReconstructColors = this->fields.m_ReconstructColors;
		      if ( !m_ReconstructColors )
		        goto LABEL_17;
		      if ( (unsigned int)i >= m_ReconstructColors->max_length.size )
		        goto LABEL_15;
		      UnityEngine::Debug::Log((Object *)m_ReconstructColors->vector[i], 0LL);
		      m_ReconstructDepths = this->fields.m_ReconstructDepths;
		      if ( !m_ReconstructDepths )
		        goto LABEL_17;
		      if ( (unsigned int)i >= m_ReconstructDepths->max_length.size )
		        goto LABEL_15;
		      UnityEngine::Debug::Log((Object *)m_ReconstructDepths->vector[i], 0LL);
		      m_MinMaxWorldDepths = this->fields.m_MinMaxWorldDepths;
		      if ( !m_MinMaxWorldDepths )
		        goto LABEL_17;
		      if ( (unsigned int)i >= m_MinMaxWorldDepths->max_length.size )
		LABEL_15:
		        sub_1800D2AB0(v4, v3);
		      UnityEngine::Debug::Log((Object *)m_MinMaxWorldDepths->vector[i], 0LL);
		    }
		    m_DepthForTest = (Object *)this->fields.m_DepthForTest;
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::Log(m_DepthForTest, 0LL);
		    UnityEngine::Debug::Log((Object *)this->fields.m_ComposeColor, 0LL);
		    UnityEngine::Debug::Log((Object *)this->fields.m_ComposeDepth, 0LL);
		    UnityEngine::Debug::Log((Object *)this->fields.m_FramingColor, 0LL);
		    UnityEngine::Debug::Log((Object *)this->fields.m_FramingDepth, 0LL);
		  }
		}
		
		private void DrawVolumetric(ref VolumetricRenderInputs inputs) {} // 0x0000000189C56128-0x0000000189C566D8
		// Void DrawVolumetric(VolumetricRenderInputs ByRef)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::VolumetricRenderer::DrawVolumetric(
		        VolumetricRenderer *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  VolumetricRenderInputs *v3; // rsi
		  VolumetricRenderer *v4; // r14
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderGraphContext *context; // r15
		  CommandBuffer *cmd; // r15
		  Material *m_VolumetricMat; // rbx
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  List_1_System_UInt64_ *list; // rcx
		  HGRenderGraphContext *v14; // r8
		  __int64 m_Ptr; // r8
		  Material *v16; // r9
		  MaterialPropertyBlock *propertyBlock; // r11
		  List_1_System_UInt64_ *volumetricRenderObjects; // rdx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Object *Item; // rax
		  Object *v22; // rax
		  Object *v23; // rax
		  Object *v24; // rax
		  Object *v25; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  VolumetricPipelineRT *colorRT; // [rsp+40h] [rbp-78h] BYREF
		  List_1_T_Enumerator_System_Object_ v32; // [rsp+48h] [rbp-70h] BYREF
		  List_1_T_Enumerator_System_Object_ v33; // [rsp+60h] [rbp-58h] BYREF
		  CommandBuffer *v34; // [rsp+78h] [rbp-40h]
		  Il2CppExceptionWrapper *v35; // [rsp+80h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v36; // [rsp+88h] [rbp-30h] BYREF
		  Il2CppExceptionWrapper *v37; // [rsp+90h] [rbp-28h] BYREF
		  VolumetricPipelineRT *depthsRT; // [rsp+D8h] [rbp+20h] BYREF
		
		  v3 = inputs;
		  v4 = this;
		  memset(&v33, 0, sizeof(v33));
		  colorRT = 0LL;
		  depthsRT = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5202, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5202, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v30, v29);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)v4, v3, 0LL);
		  }
		  else
		  {
		    context = v3->context;
		    if ( !context )
		      sub_1800D8260(v6, v5);
		    cmd = context->fields.cmd;
		    v34 = cmd;
		    m_VolumetricMat = v4->fields.m_VolumetricMat;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, m_VolumetricMat, 0, 0LL);
		    if ( !v3->volumetricRenderObjects )
		      sub_1800D8260(v11, v10);
		    v33 = *(List_1_T_Enumerator_System_Object_ *)sub_180364F58(&v32, v3->volumetricRenderObjects);
		    v32._list = 0LL;
		    *(_QWORD *)&v32._index = &v33;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v33,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		      {
		        v14 = v3->context;
		        if ( !v14 )
		          sub_1800D8250(list, v12);
		        m_Ptr = (__int64)v14->fields.renderContext.m_Ptr;
		        v16 = v4->fields.m_VolumetricMat;
		        propertyBlock = v4->fields.m_PropertyBlock;
		        if ( !v33._current )
		          sub_1800D8250(list, v12);
		        if ( *(_DWORD *)&v33._current->klass->_1.method_count == 3434 )
		        {
		          HG::Rendering::Runtime::VolumetricRenderObject::OnUpdateVolumetricMaterial(
		            (VolumetricRenderObject *)v33._current,
		            cmd,
		            (ScriptableRenderContext)m_Ptr,
		            v16,
		            propertyBlock,
		            0LL);
		        }
		        else if ( *(_DWORD *)&v33._current->klass->_1.method_count == 3435 )
		        {
		          HG::Rendering::Runtime::VolumetricCloudSDF::OnUpdateVolumetricMaterial(
		            (VolumetricCloudSDF *)v33._current,
		            cmd,
		            (ScriptableRenderContext)m_Ptr,
		            v16,
		            propertyBlock,
		            0LL);
		        }
		        else
		        {
		          sub_1808B258C(
		            v33._current->klass,
		            *(_DWORD *)&v33._current->klass->_1.method_count - 3434,
		            v33._current,
		            (_DWORD)cmd,
		            m_Ptr,
		            (__int64)v16,
		            (__int64)v4->fields.m_PropertyBlock);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v35 )
		    {
		      v32._list = (List_1_System_Object_ *)v35->ex;
		      list = (List_1_System_UInt64_ *)v32._list;
		      if ( v32._list )
		        sub_18007E1E0(v32._list);
		      v3 = inputs;
		      v4 = this;
		      cmd = v34;
		    }
		    if ( cmd )
		    {
		      volumetricRenderObjects = (List_1_System_UInt64_ *)v3->volumetricRenderObjects;
		      if ( !volumetricRenderObjects )
		        goto LABEL_59;
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v32,
		        volumetricRenderObjects,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
		      v33 = v32;
		      v32._list = 0LL;
		      *(_QWORD *)&v32._index = &v33;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v33,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		        {
		          if ( !v33._current )
		            sub_1800D8250(v20, v19);
		          if ( *(_DWORD *)&v33._current->klass->_1.method_count == 3434
		            || *(_DWORD *)&v33._current->klass->_1.method_count == 3435 )
		          {
		            HG::Rendering::Runtime::VolumetricRenderObject::PreVolumetricRendering(
		              (VolumetricRenderObject *)v33._current,
		              v3,
		              0LL);
		          }
		          else
		          {
		            sub_1808B24D8(
		              2LL,
		              (unsigned int)(*(_DWORD *)&v33._current->klass->_1.method_count - 3434),
		              v33._current,
		              v3);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v36 )
		      {
		        v32._list = (List_1_System_Object_ *)v36->ex;
		        if ( v32._list )
		          sub_18007E1E0(v32._list);
		        v3 = inputs;
		        v4 = this;
		      }
		      HG::Rendering::Runtime::VolumetricRenderer::UpdateDownResParameters(v4, v3, 0LL);
		      colorRT = 0LL;
		      depthsRT = 0LL;
		      list = (List_1_System_UInt64_ *)v4->fields.m_RenderStages;
		      if ( !list )
		        goto LABEL_59;
		      Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		               (Dictionary_2_System_Int32Enum_System_Object_ *)list,
		               (Int32Enum__Enum)0,
		               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( !Item )
		        goto LABEL_59;
		      HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
		        (VolumetricRenderer_VolumetricRenderStage *)Item,
		        v3,
		        &colorRT,
		        &depthsRT,
		        0LL);
		      list = (List_1_System_UInt64_ *)v4->fields.m_RenderStages;
		      if ( !list )
		        goto LABEL_59;
		      v22 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		              (Dictionary_2_System_Int32Enum_System_Object_ *)list,
		              (Int32Enum__Enum)1u,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( !v22 )
		        goto LABEL_59;
		      HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
		        (VolumetricRenderer_VolumetricRenderStage *)v22,
		        v3,
		        &colorRT,
		        &depthsRT,
		        0LL);
		      list = (List_1_System_UInt64_ *)v4->fields.m_RenderStages;
		      if ( !list )
		        goto LABEL_59;
		      v23 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		              (Dictionary_2_System_Int32Enum_System_Object_ *)list,
		              (Int32Enum__Enum)2u,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item);
		      if ( !v23 )
		        goto LABEL_59;
		      HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
		        (VolumetricRenderer_VolumetricRenderStage *)v23,
		        v3,
		        &colorRT,
		        &depthsRT,
		        0LL);
		      list = (List_1_System_UInt64_ *)v4->fields.m_RenderStages;
		      if ( !list
		        || (v24 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                    (Dictionary_2_System_Int32Enum_System_Object_ *)list,
		                    (Int32Enum__Enum)3u,
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item)) == 0LL
		        || (HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
		              (VolumetricRenderer_VolumetricRenderStage *)v24,
		              v3,
		              &colorRT,
		              &depthsRT,
		              0LL),
		            (list = (List_1_System_UInt64_ *)v4->fields.m_RenderStages) == 0LL)
		        || (v25 = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                    (Dictionary_2_System_Int32Enum_System_Object_ *)list,
		                    (Int32Enum__Enum)4u,
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::EVolumetricStage,HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage>::get_Item)) == 0LL
		        || (HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderStage::Process(
		              (VolumetricRenderer_VolumetricRenderStage *)v25,
		              v3,
		              &colorRT,
		              &depthsRT,
		              0LL),
		            (volumetricRenderObjects = (List_1_System_UInt64_ *)v3->volumetricRenderObjects) == 0LL) )
		      {
		LABEL_59:
		        sub_1800D8250(list, volumetricRenderObjects);
		      }
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v32,
		        volumetricRenderObjects,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
		      v33 = v32;
		      v32._list = 0LL;
		      *(_QWORD *)&v32._index = &v33;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v33,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
		        {
		          if ( !v33._current )
		            sub_1800D8250(v27, v26);
		          if ( *(_DWORD *)&v33._current->klass->_1.method_count == 3434
		            || *(_DWORD *)&v33._current->klass->_1.method_count == 3435 )
		          {
		            HG::Rendering::Runtime::VolumetricRenderObject::PostVolumetricRendering(
		              (VolumetricRenderObject *)v33._current,
		              v3,
		              0LL);
		          }
		          else
		          {
		            sub_1808B24D8(
		              3LL,
		              (unsigned int)(*(_DWORD *)&v33._current->klass->_1.method_count - 3434),
		              v33._current,
		              v3);
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v37 )
		      {
		        v32._list = (List_1_System_Object_ *)v37->ex;
		        if ( v32._list )
		          sub_18007E1E0(v32._list);
		        v4 = this;
		      }
		      v4->fields.m_RTIndex = 1 - v4->fields.m_RTIndex;
		    }
		  }
		}
		
		public static HGVolumetricQualitySettings PrepareQualitySettingsCPP(HGVolumetricCloudSettingParameters volumetricParameters) => default; // 0x000000018350E650-0x000000018350F810
		// HGVolumetricQualitySettings PrepareQualitySettingsCPP(HGVolumetricCloudSettingParameters)
		HGVolumetricQualitySettings *HG::Rendering::Runtime::VolumetricRenderer::PrepareQualitySettingsCPP(
		        HGVolumetricQualitySettings *__return_ptr retstr,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  bool v7; // r14
		  SettingParameter_1_System_Boolean_ *enableDownRes; // rdi
		  struct MethodInfo *v9; // rsi
		  Il2CppClass *klass; // rax
		  bool paramValue_k__BackingField; // al
		  SettingParameter_1_System_Single_ *downResRatio; // rsi
		  struct MethodInfo *v13; // rdi
		  Il2CppClass *v14; // rax
		  SettingParameter_1_EDownResFilter_ *downResFilter; // rax
		  SettingParameter_1_System_Boolean_ *enableFraming; // rsi
		  struct MethodInfo *v17; // rdi
		  Il2CppClass *v18; // rax
		  SettingParameter_1_EFramingQuality_ *framingLevel; // rax
		  SettingParameter_1_System_Single_ *framingComposeRatio; // rdi
		  struct MethodInfo *v21; // rsi
		  Il2CppClass *v22; // rax
		  bool v23; // al
		  SettingParameter_1_System_Boolean_ *enableFramingMotionVector; // rsi
		  struct MethodInfo *v25; // rdi
		  Il2CppClass *v26; // rax
		  bool v27; // al
		  SettingParameter_1_System_Boolean_ *enableFramingDepthOpt; // rsi
		  struct MethodInfo *v29; // rdi
		  Il2CppClass *v30; // rax
		  bool v31; // al
		  SettingParameter_1_System_Boolean_ *enableFramingColorAABB; // rsi
		  struct MethodInfo *v33; // rdi
		  Il2CppClass *v34; // rax
		  bool v35; // al
		  SettingParameter_1_System_Boolean_ *enableFramingNeighborAvg; // rsi
		  struct MethodInfo *v37; // rdi
		  Il2CppClass *v38; // rax
		  bool v39; // al
		  __int128 v40; // xmm0
		  SettingParameter_1_System_Boolean_ *enableTAA; // rsi
		  struct MethodInfo *v42; // rdi
		  Il2CppClass *v43; // rax
		  bool v44; // al
		  SettingParameter_1_System_Boolean_ *enableTAAMotionVector; // rsi
		  struct MethodInfo *v46; // rdi
		  Il2CppClass *v47; // rax
		  bool v48; // al
		  SettingParameter_1_System_Boolean_ *enableTAADepthOpt; // rsi
		  struct MethodInfo *v50; // rdi
		  Il2CppClass *v51; // rax
		  bool v52; // al
		  SettingParameter_1_System_Boolean_ *enableTAAColorAABB; // rsi
		  struct MethodInfo *v54; // rdi
		  Il2CppClass *v55; // rax
		  bool v56; // al
		  SettingParameter_1_System_Boolean_ *enableTAANeighborAvg; // rsi
		  struct MethodInfo *v58; // rdi
		  Il2CppClass *v59; // rax
		  bool v60; // al
		  SettingParameter_1_System_Single_ *invalidDepthBlendRatio; // rsi
		  struct MethodInfo *v62; // rdi
		  Il2CppClass *v63; // rax
		  float v64; // xmm1_4
		  SettingParameter_1_System_Single_ *marchStepScale; // rsi
		  struct MethodInfo *v66; // rdi
		  Il2CppClass *v67; // rax
		  float v68; // xmm0_4
		  SettingParameter_1_System_Single_ *godRayStepScale; // rsi
		  struct MethodInfo *v70; // rdi
		  Il2CppClass *v71; // rax
		  float v72; // xmm0_4
		  SettingParameter_1_System_Single_ *emptySkipSizeScale; // rsi
		  struct MethodInfo *v74; // rdi
		  Il2CppClass *v75; // rax
		  float v76; // xmm0_4
		  SettingParameter_1_System_Single_ *dynamicStepRange; // rsi
		  struct MethodInfo *v78; // rdi
		  Il2CppClass *v79; // rax
		  float v80; // xmm0_4
		  SettingParameter_1_System_Single_ *dynamicStepScale; // rsi
		  struct MethodInfo *v82; // rdi
		  Il2CppClass *v83; // rax
		  float v84; // xmm0_4
		  SettingParameter_1_System_Boolean_ *enableFarCloud; // rsi
		  struct MethodInfo *v86; // rdi
		  Il2CppClass *v87; // rax
		  bool v88; // al
		  SettingParameter_1_System_Int32_ *panoramicSizeX; // rsi
		  struct MethodInfo *v90; // rdi
		  Il2CppClass *v91; // rax
		  int32_t v92; // eax
		  SettingParameter_1_System_Int32_ *panoramicSizeY; // rsi
		  struct MethodInfo *v94; // rdi
		  Il2CppClass *v95; // rax
		  int32_t v96; // eax
		  SettingParameter_1_System_Int32_ *octahedronSize; // rsi
		  struct MethodInfo *v98; // rdi
		  Il2CppClass *v99; // rax
		  int32_t v100; // eax
		  SettingParameter_1_System_Single_ *octahedronHeightScale; // rsi
		  struct MethodInfo *v102; // rdi
		  Il2CppClass *v103; // rax
		  float v104; // xmm0_4
		  SettingParameter_1_System_Boolean_ *octahedronEnableSlicing; // rsi
		  struct MethodInfo *v106; // rdi
		  Il2CppClass *v107; // rax
		  bool v108; // al
		  SettingParameter_1_System_Int32_ *octahedronSlicingCountX; // rsi
		  struct MethodInfo *v110; // rdi
		  Il2CppClass *v111; // rax
		  int32_t v112; // eax
		  SettingParameter_1_System_Int32_ *octahedronSlicingCountY; // rsi
		  struct MethodInfo *v114; // rdi
		  Il2CppClass *v115; // rax
		  int32_t v116; // eax
		  SettingParameter_1_System_Int32_ *semicircularSize; // rsi
		  struct MethodInfo *v118; // rdi
		  Il2CppClass *v119; // rax
		  int32_t v120; // eax
		  SettingParameter_1_System_Single_ *semicircularZScale; // rsi
		  struct MethodInfo *v122; // rdi
		  Il2CppClass *v123; // rax
		  SettingParameter_1_EFarCloudFramingQuality_ *farCloudFramingLevel; // rax
		  SettingParameter_1_System_Single_ *farCloudFramingComposeRatio; // rdi
		  struct MethodInfo *v126; // rsi
		  Il2CppClass *v127; // rax
		  bool v128; // al
		  SettingParameter_1_System_Boolean_ *farCloudEnableTAA; // rsi
		  struct MethodInfo *v130; // rdi
		  Il2CppClass *v131; // rax
		  bool v132; // al
		  SettingParameter_1_System_Single_ *farCloudTAABlendRatio; // rdi
		  struct MethodInfo *v134; // rsi
		  Il2CppClass *v135; // rax
		  bool v136; // al
		  SettingParameter_1_System_Single_ *farCloudMarchStepScale; // rsi
		  struct MethodInfo *v138; // rdi
		  Il2CppClass *v139; // rax
		  __m128 paramValue_k__BackingField_low; // xmm7
		  SettingParameter_1_System_Single_ *farCloudFullUpdateMarchStepScale; // rsi
		  struct MethodInfo *v142; // rdi
		  Il2CppClass *v143; // rax
		  SettingParameter_1_System_Single_ *farCloudEmptySkipSizeScale; // rbx
		  __m128 v145; // xmm6
		  struct MethodInfo *v146; // rdi
		  Il2CppClass *v147; // rax
		  Il2CppClass *v148; // rcx
		  float v149; // xmm2_4
		  __int128 v150; // xmm0
		  __int128 v151; // xmm1
		  __int128 v152; // xmm0
		  __int128 v153; // xmm1
		  __int128 v154; // xmm0
		  __int64 v155; // xmm0_8
		  HGVolumetricQualitySettings *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGVolumetricQualitySettings *v158; // rax
		  __int128 v159; // xmm1
		  __int128 v160; // xmm0
		  __int128 v161; // xmm1
		  __int128 v162; // xmm0
		  __int128 v163; // xmm1
		  __int128 v164; // xmm0
		  __int128 v165; // xmm1
		  __int64 v166; // rax
		  __int64 v167; // rdx
		  __int64 v168; // rax
		  __int64 v169; // rax
		  __int64 v170; // rdx
		  __int64 v171; // r8
		  __int64 v172; // rax
		  __int64 v173; // rax
		  __int64 v174; // rax
		  __int64 v175; // rax
		  __int64 v176; // rax
		  __int64 v177; // rax
		  __int64 v178; // rax
		  __int64 v179; // rax
		  __int64 v180; // rax
		  __int64 v181; // rax
		  __int64 v182; // rax
		  __int64 v183; // rax
		  __int64 v184; // rax
		  __int64 v185; // rax
		  __int64 v186; // rax
		  __int64 v187; // rax
		  __int64 v188; // rax
		  __int64 v189; // rax
		  __int64 v190; // rax
		  __int64 v191; // rax
		  __int64 v192; // rax
		  __int64 v193; // rax
		  __int64 v194; // rax
		  __int64 v195; // rax
		  __int64 v196; // rax
		  __int64 v197; // rax
		  __int64 v198; // rax
		  __int64 v199; // rax
		  __int64 v200; // rax
		  __int64 v201; // rax
		  __int64 v202; // rax
		  __int64 v203; // rax
		  __int128 v204; // [rsp+20h] [rbp-E0h]
		  int v205; // [rsp+30h] [rbp-D0h]
		  __int128 v206; // [rsp+40h] [rbp-C0h]
		  __int128 v207; // [rsp+50h] [rbp-B0h]
		  __int128 v208; // [rsp+60h] [rbp-A0h]
		  __int128 v209; // [rsp+70h] [rbp-90h]
		  __int128 v210; // [rsp+80h] [rbp-80h]
		  HGVolumetricQualitySettings v211; // [rsp+A0h] [rbp-60h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_264;
		  if ( wrapperArray->max_length.size <= 1154 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_264:
		    sub_1800D8260(v5, wrapperArray);
		  if ( LODWORD(v5->_0.namespaze) <= 0x482 )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( v5[24]._1.genericContainerHandle )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1154, 0LL);
		    if ( Patch )
		    {
		      v158 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_435(&v211, Patch, (Object *)volumetricParameters, 0LL);
		      v159 = *(_OWORD *)&v158->framingQualityPack.framingLevel;
		      *(_OWORD *)&retstr->downResQualityPack.enableDownRes = *(_OWORD *)&v158->downResQualityPack.enableDownRes;
		      v160 = *(_OWORD *)&v158->taaQualityPack.enableTAA;
		      *(_OWORD *)&retstr->framingQualityPack.framingLevel = v159;
		      v161 = *(_OWORD *)&v158->cloudQualityPack.godRayStepScale;
		      *(_OWORD *)&retstr->taaQualityPack.enableTAA = v160;
		      v162 = *(_OWORD *)&v158->cloudQualityPack.enableFarCloud;
		      *(_OWORD *)&retstr->cloudQualityPack.godRayStepScale = v161;
		      v163 = *(_OWORD *)&v158->cloudQualityPack.octahedronHeightScale;
		      *(_OWORD *)&retstr->cloudQualityPack.enableFarCloud = v162;
		      v164 = *(_OWORD *)&v158->cloudQualityPack.semicircularSize;
		      *(_OWORD *)&retstr->cloudQualityPack.octahedronHeightScale = v163;
		      v165 = *(_OWORD *)&v158->cloudQualityPack.farCloudFramingCubicSample;
		      *(_OWORD *)&retstr->cloudQualityPack.semicircularSize = v164;
		      v155 = *(_QWORD *)&v158->cloudQualityPack.farCloudFullUpdateMarchStepScale;
		      *(_OWORD *)&retstr->cloudQualityPack.farCloudFramingCubicSample = v165;
		      goto LABEL_263;
		    }
		    goto LABEL_264;
		  }
		LABEL_5:
		  v7 = UnityEngine::SystemInfo::SupportsCubicFilter(0LL);
		  LODWORD(v204) = 0;
		  if ( !volumetricParameters )
		    goto LABEL_264;
		  enableDownRes = volumetricParameters->fields.enableDownRes;
		  v9 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !enableDownRes )
		    goto LABEL_264;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v166 = sub_18011C4C0(v9->klass);
		    (**(void (__fastcall ***)(_QWORD, __int64))(*(_QWORD *)(v166 + 192) + 48LL))(*(_QWORD *)(v166 + 192), v167);
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v9->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  paramValue_k__BackingField = enableDownRes->fields._paramValue_k__BackingField;
		  downResRatio = volumetricParameters->fields.downResRatio;
		  v13 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  LOBYTE(v204) = paramValue_k__BackingField;
		  if ( !downResRatio )
		    goto LABEL_264;
		  v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v14->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v14->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v168 = sub_18011C4C0(v13->klass);
		    (**(void (***)(void))(*(_QWORD *)(v168 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v13->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  downResFilter = volumetricParameters->fields.downResFilter;
		  DWORD1(v204) = LODWORD(downResRatio->fields._paramValue_k__BackingField);
		  if ( !downResFilter )
		    goto LABEL_264;
		  enableFraming = volumetricParameters->fields.enableFraming;
		  v17 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  v211.downResQualityPack.downResFilter = downResFilter->fields._paramValue_k__BackingField;
		  *(_QWORD *)&v211.downResQualityPack.enableDownRes = v204;
		  v205 = 0;
		  LODWORD(v204) = 0;
		  if ( !enableFraming )
		    goto LABEL_264;
		  v18 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v18->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v18->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v169 = sub_18011C4C0(v17->klass);
		    (**(void (__fastcall ***)(_QWORD, __int64, __int64))(*(_QWORD *)(v169 + 192) + 48LL))(
		      *(_QWORD *)(v169 + 192),
		      v170,
		      v171);
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v17->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  LOBYTE(v204) = enableFraming->fields._paramValue_k__BackingField;
		  framingLevel = volumetricParameters->fields.framingLevel;
		  if ( !framingLevel )
		    goto LABEL_264;
		  framingComposeRatio = volumetricParameters->fields.framingComposeRatio;
		  v21 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  DWORD1(v204) = framingLevel->fields._paramValue_k__BackingField;
		  if ( !framingComposeRatio )
		    goto LABEL_264;
		  v22 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v22->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v22->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v172 = sub_18011C4C0(v21->klass);
		    (**(void (***)(void))(*(_QWORD *)(v172 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v21->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  DWORD2(v204) = LODWORD(framingComposeRatio->fields._paramValue_k__BackingField);
		  v23 = v7
		     && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          volumetricParameters->fields.enableFramingCubicSample,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  enableFramingMotionVector = volumetricParameters->fields.enableFramingMotionVector;
		  v25 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE12(v204) = v23;
		  if ( !enableFramingMotionVector )
		    goto LABEL_264;
		  v26 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v26->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v26->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v173 = sub_18011C4C0(v25->klass);
		    (**(void (***)(void))(*(_QWORD *)(v173 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v25->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v27 = enableFramingMotionVector->fields._paramValue_k__BackingField;
		  enableFramingDepthOpt = volumetricParameters->fields.enableFramingDepthOpt;
		  v29 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE13(v204) = v27;
		  if ( !enableFramingDepthOpt )
		    goto LABEL_264;
		  v30 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v30->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v30->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v174 = sub_18011C4C0(v29->klass);
		    (**(void (***)(void))(*(_QWORD *)(v174 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v29->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v31 = enableFramingDepthOpt->fields._paramValue_k__BackingField;
		  enableFramingColorAABB = volumetricParameters->fields.enableFramingColorAABB;
		  v33 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE14(v204) = v31;
		  if ( !enableFramingColorAABB )
		    goto LABEL_264;
		  v34 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v34->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v34->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v175 = sub_18011C4C0(v33->klass);
		    (**(void (***)(void))(*(_QWORD *)(v175 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v33->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v35 = enableFramingColorAABB->fields._paramValue_k__BackingField;
		  enableFramingNeighborAvg = volumetricParameters->fields.enableFramingNeighborAvg;
		  v37 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  HIBYTE(v204) = v35;
		  if ( !enableFramingNeighborAvg )
		    goto LABEL_264;
		  v38 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v38->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v38->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v176 = sub_18011C4C0(v37->klass);
		    (**(void (***)(void))(*(_QWORD *)(v176 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v37->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v39 = enableFramingNeighborAvg->fields._paramValue_k__BackingField;
		  v40 = v204;
		  enableTAA = volumetricParameters->fields.enableTAA;
		  v42 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  LOBYTE(v205) = v39;
		  *(_DWORD *)&v211.framingQualityPack.enableFramingNeighborAvg = v205;
		  WORD3(v204) = 0;
		  *(_OWORD *)&v211.framingQualityPack.enableFraming = v40;
		  if ( !enableTAA )
		    goto LABEL_264;
		  v43 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v43->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v43->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v177 = sub_18011C4C0(v42->klass);
		    (**(void (***)(void))(*(_QWORD *)(v177 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v42->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  LOBYTE(v204) = enableTAA->fields._paramValue_k__BackingField;
		  v44 = v7
		     && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          volumetricParameters->fields.enableTAACubicSample,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  enableTAAMotionVector = volumetricParameters->fields.enableTAAMotionVector;
		  v46 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE1(v204) = v44;
		  if ( !enableTAAMotionVector )
		    goto LABEL_264;
		  v47 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v47->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v47->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v178 = sub_18011C4C0(v46->klass);
		    (**(void (***)(void))(*(_QWORD *)(v178 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v46->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v48 = enableTAAMotionVector->fields._paramValue_k__BackingField;
		  enableTAADepthOpt = volumetricParameters->fields.enableTAADepthOpt;
		  v50 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE2(v204) = v48;
		  if ( !enableTAADepthOpt )
		    goto LABEL_264;
		  v51 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v51->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v51->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v179 = sub_18011C4C0(v50->klass);
		    (**(void (***)(void))(*(_QWORD *)(v179 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v50->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v52 = enableTAADepthOpt->fields._paramValue_k__BackingField;
		  enableTAAColorAABB = volumetricParameters->fields.enableTAAColorAABB;
		  v54 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE3(v204) = v52;
		  if ( !enableTAAColorAABB )
		    goto LABEL_264;
		  v55 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v55->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v55->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v180 = sub_18011C4C0(v54->klass);
		    (**(void (***)(void))(*(_QWORD *)(v180 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v54->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v56 = enableTAAColorAABB->fields._paramValue_k__BackingField;
		  enableTAANeighborAvg = volumetricParameters->fields.enableTAANeighborAvg;
		  v58 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE4(v204) = v56;
		  if ( !enableTAANeighborAvg )
		    goto LABEL_264;
		  v59 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v59->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v59->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v181 = sub_18011C4C0(v58->klass);
		    (**(void (***)(void))(*(_QWORD *)(v181 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v58->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v60 = enableTAANeighborAvg->fields._paramValue_k__BackingField;
		  invalidDepthBlendRatio = volumetricParameters->fields.invalidDepthBlendRatio;
		  v62 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  BYTE5(v204) = v60;
		  if ( !invalidDepthBlendRatio )
		    goto LABEL_264;
		  v63 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v63->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v63->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v182 = sub_18011C4C0(v62->klass);
		    (**(void (***)(void))(*(_QWORD *)(v182 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v62->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v64 = invalidDepthBlendRatio->fields._paramValue_k__BackingField;
		  marchStepScale = volumetricParameters->fields.marchStepScale;
		  v66 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  *(_QWORD *)&v211.taaQualityPack.enableTAA = v204;
		  v211.taaQualityPack.invalidDepthBlendRatio = v64;
		  DWORD1(v207) = 0;
		  v208 = 0LL;
		  v210 = 0LL;
		  if ( !marchStepScale )
		    goto LABEL_264;
		  v67 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v67->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v67->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v183 = sub_18011C4C0(v66->klass);
		    (**(void (***)(void))(*(_QWORD *)(v183 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v66->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v68 = marchStepScale->fields._paramValue_k__BackingField;
		  godRayStepScale = volumetricParameters->fields.godRayStepScale;
		  v70 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  *(float *)&v206 = v68;
		  if ( !godRayStepScale )
		    goto LABEL_264;
		  v71 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v71->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v71->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v184 = sub_18011C4C0(v70->klass);
		    (**(void (***)(void))(*(_QWORD *)(v184 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v70->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v72 = godRayStepScale->fields._paramValue_k__BackingField;
		  emptySkipSizeScale = volumetricParameters->fields.emptySkipSizeScale;
		  v74 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  *((float *)&v206 + 1) = v72;
		  if ( !emptySkipSizeScale )
		    goto LABEL_264;
		  v75 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v75->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v75->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v185 = sub_18011C4C0(v74->klass);
		    (**(void (***)(void))(*(_QWORD *)(v185 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v74->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v76 = emptySkipSizeScale->fields._paramValue_k__BackingField;
		  dynamicStepRange = volumetricParameters->fields.dynamicStepRange;
		  v78 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  *((float *)&v206 + 2) = v76;
		  if ( !dynamicStepRange )
		    goto LABEL_264;
		  v79 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v79->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v79->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v186 = sub_18011C4C0(v78->klass);
		    (**(void (***)(void))(*(_QWORD *)(v186 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v78->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v80 = dynamicStepRange->fields._paramValue_k__BackingField;
		  dynamicStepScale = volumetricParameters->fields.dynamicStepScale;
		  v82 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  *((float *)&v206 + 3) = v80;
		  if ( !dynamicStepScale )
		    goto LABEL_264;
		  v83 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v83->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v83->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v187 = sub_18011C4C0(v82->klass);
		    (**(void (***)(void))(*(_QWORD *)(v187 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v82->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v84 = dynamicStepScale->fields._paramValue_k__BackingField;
		  enableFarCloud = volumetricParameters->fields.enableFarCloud;
		  v86 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  *(float *)&v207 = v84;
		  if ( !enableFarCloud )
		    goto LABEL_264;
		  v87 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v87->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v87->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v188 = sub_18011C4C0(v86->klass);
		    (**(void (***)(void))(*(_QWORD *)(v188 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v86->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v88 = enableFarCloud->fields._paramValue_k__BackingField;
		  panoramicSizeX = volumetricParameters->fields.panoramicSizeX;
		  v90 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  BYTE4(v207) = v88;
		  if ( !panoramicSizeX )
		    goto LABEL_264;
		  v91 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v91->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v91->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v189 = sub_18011C4C0(v90->klass);
		    (**(void (***)(void))(*(_QWORD *)(v189 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v90->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v92 = panoramicSizeX->fields._paramValue_k__BackingField;
		  panoramicSizeY = volumetricParameters->fields.panoramicSizeY;
		  v94 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  DWORD2(v207) = v92;
		  if ( !panoramicSizeY )
		    goto LABEL_264;
		  v95 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v95->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v95->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v190 = sub_18011C4C0(v94->klass);
		    (**(void (***)(void))(*(_QWORD *)(v190 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v94->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v96 = panoramicSizeY->fields._paramValue_k__BackingField;
		  octahedronSize = volumetricParameters->fields.octahedronSize;
		  v98 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  HIDWORD(v207) = v96;
		  if ( !octahedronSize )
		    goto LABEL_264;
		  v99 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v99->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v99->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v191 = sub_18011C4C0(v98->klass);
		    (**(void (***)(void))(*(_QWORD *)(v191 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v98->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v100 = octahedronSize->fields._paramValue_k__BackingField;
		  octahedronHeightScale = volumetricParameters->fields.octahedronHeightScale;
		  v102 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  LODWORD(v208) = v100;
		  if ( !octahedronHeightScale )
		    goto LABEL_264;
		  v103 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v103->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v103->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v192 = sub_18011C4C0(v102->klass);
		    (**(void (***)(void))(*(_QWORD *)(v192 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v102->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v104 = octahedronHeightScale->fields._paramValue_k__BackingField;
		  octahedronEnableSlicing = volumetricParameters->fields.octahedronEnableSlicing;
		  v106 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  *((float *)&v208 + 1) = v104;
		  if ( !octahedronEnableSlicing )
		    goto LABEL_264;
		  v107 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v107->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v107->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v193 = sub_18011C4C0(v106->klass);
		    (**(void (***)(void))(*(_QWORD *)(v193 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v106->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v108 = octahedronEnableSlicing->fields._paramValue_k__BackingField;
		  octahedronSlicingCountX = volumetricParameters->fields.octahedronSlicingCountX;
		  v110 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  BYTE8(v208) = v108;
		  if ( !octahedronSlicingCountX )
		    goto LABEL_264;
		  v111 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v111->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v111->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v194 = sub_18011C4C0(v110->klass);
		    (**(void (***)(void))(*(_QWORD *)(v194 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v110->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v112 = octahedronSlicingCountX->fields._paramValue_k__BackingField;
		  octahedronSlicingCountY = volumetricParameters->fields.octahedronSlicingCountY;
		  v114 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  HIDWORD(v208) = v112;
		  if ( !octahedronSlicingCountY )
		    goto LABEL_264;
		  v115 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v115->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v115->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v195 = sub_18011C4C0(v114->klass);
		    (**(void (***)(void))(*(_QWORD *)(v195 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v114->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v116 = octahedronSlicingCountY->fields._paramValue_k__BackingField;
		  semicircularSize = volumetricParameters->fields.semicircularSize;
		  v118 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
		  LODWORD(v209) = v116;
		  if ( !semicircularSize )
		    goto LABEL_264;
		  v119 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass;
		  if ( ((__int64)v119->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v119->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v196 = sub_18011C4C0(v118->klass);
		    (**(void (***)(void))(*(_QWORD *)(v196 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v118->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v120 = semicircularSize->fields._paramValue_k__BackingField;
		  semicircularZScale = volumetricParameters->fields.semicircularZScale;
		  v122 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  DWORD1(v209) = v120;
		  if ( !semicircularZScale )
		    goto LABEL_264;
		  v123 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v123->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v123->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v197 = sub_18011C4C0(v122->klass);
		    (**(void (***)(void))(*(_QWORD *)(v197 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v122->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  farCloudFramingLevel = volumetricParameters->fields.farCloudFramingLevel;
		  DWORD2(v209) = LODWORD(semicircularZScale->fields._paramValue_k__BackingField);
		  if ( !farCloudFramingLevel )
		    goto LABEL_264;
		  farCloudFramingComposeRatio = volumetricParameters->fields.farCloudFramingComposeRatio;
		  v126 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  HIDWORD(v209) = farCloudFramingLevel->fields._paramValue_k__BackingField;
		  if ( !farCloudFramingComposeRatio )
		    goto LABEL_264;
		  v127 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v127->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v127->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v198 = sub_18011C4C0(v126->klass);
		    (**(void (***)(void))(*(_QWORD *)(v198 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v126->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  *(float *)&v210 = farCloudFramingComposeRatio->fields._paramValue_k__BackingField;
		  v128 = v7
		      && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           volumetricParameters->fields.farCloudFramingCubicSample,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  farCloudEnableTAA = volumetricParameters->fields.farCloudEnableTAA;
		  v130 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  BYTE4(v210) = v128;
		  if ( !farCloudEnableTAA )
		    goto LABEL_264;
		  v131 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)v131->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v131->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v199 = sub_18011C4C0(v130->klass);
		    (**(void (***)(void))(*(_QWORD *)(v199 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v130->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  v132 = farCloudEnableTAA->fields._paramValue_k__BackingField;
		  farCloudTAABlendRatio = volumetricParameters->fields.farCloudTAABlendRatio;
		  v134 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  BYTE5(v210) = v132;
		  if ( !farCloudTAABlendRatio )
		    goto LABEL_264;
		  v135 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v135->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v135->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v200 = sub_18011C4C0(v134->klass);
		    (**(void (***)(void))(*(_QWORD *)(v200 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v134->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  DWORD2(v210) = LODWORD(farCloudTAABlendRatio->fields._paramValue_k__BackingField);
		  v136 = v7
		      && HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           volumetricParameters->fields.farCloudTAACubicSample,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  farCloudMarchStepScale = volumetricParameters->fields.farCloudMarchStepScale;
		  v138 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  BYTE12(v210) = v136;
		  if ( !farCloudMarchStepScale )
		    goto LABEL_264;
		  v139 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v139->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v139->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v201 = sub_18011C4C0(v138->klass);
		    (**(void (***)(void))(*(_QWORD *)(v201 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v138->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  paramValue_k__BackingField_low = (__m128)LODWORD(farCloudMarchStepScale->fields._paramValue_k__BackingField);
		  farCloudFullUpdateMarchStepScale = volumetricParameters->fields.farCloudFullUpdateMarchStepScale;
		  v142 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !farCloudFullUpdateMarchStepScale )
		    goto LABEL_264;
		  v143 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v143->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v143->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v202 = sub_18011C4C0(v142->klass);
		    (**(void (***)(void))(*(_QWORD *)(v202 + 192) + 48LL))();
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v142->klass;
		  if ( ((__int64)v5->vtable.Equals.methodPtr & 1) == 0 )
		    sub_1800360B0(v5, wrapperArray);
		  farCloudEmptySkipSizeScale = volumetricParameters->fields.farCloudEmptySkipSizeScale;
		  v145 = (__m128)LODWORD(farCloudFullUpdateMarchStepScale->fields._paramValue_k__BackingField);
		  v146 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit;
		  if ( !farCloudEmptySkipSizeScale )
		    goto LABEL_264;
		  v147 = MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass;
		  if ( ((__int64)v147->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit->klass, wrapperArray);
		  if ( !*((_QWORD *)v147->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v203 = sub_18011C4C0(v146->klass);
		    (**(void (***)(void))(*(_QWORD *)(v203 + 192) + 48LL))();
		  }
		  v148 = v146->klass;
		  if ( ((__int64)v148->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v148, wrapperArray);
		  v149 = farCloudEmptySkipSizeScale->fields._paramValue_k__BackingField;
		  *(_OWORD *)&v211.cloudQualityPack.marchStepScale = v206;
		  *(_OWORD *)&v211.cloudQualityPack.octahedronSize = v208;
		  *(_OWORD *)&v211.cloudQualityPack.dynamicStepScale = v207;
		  *(_OWORD *)&v211.cloudQualityPack.farCloudFramingComposeRatio = v210;
		  *(_OWORD *)&retstr->downResQualityPack.enableDownRes = *(_OWORD *)&v211.downResQualityPack.enableDownRes;
		  v150 = *(_OWORD *)&v211.taaQualityPack.enableTAA;
		  *(_OWORD *)&v211.cloudQualityPack.octahedronSlicingCountY = v209;
		  *(_OWORD *)&retstr->framingQualityPack.framingLevel = *(_OWORD *)&v211.framingQualityPack.framingLevel;
		  v151 = *(_OWORD *)&v211.cloudQualityPack.godRayStepScale;
		  *(_OWORD *)&retstr->taaQualityPack.enableTAA = v150;
		  v152 = *(_OWORD *)&v211.cloudQualityPack.enableFarCloud;
		  *(_OWORD *)&retstr->cloudQualityPack.godRayStepScale = v151;
		  v153 = *(_OWORD *)&v211.cloudQualityPack.octahedronHeightScale;
		  *(_OWORD *)&retstr->cloudQualityPack.enableFarCloud = v152;
		  v154 = *(_OWORD *)&v211.cloudQualityPack.semicircularSize;
		  *(_OWORD *)&retstr->cloudQualityPack.octahedronHeightScale = v153;
		  *(_OWORD *)&retstr->cloudQualityPack.semicircularSize = v154;
		  *(_QWORD *)&v211.cloudQualityPack.farCloudMarchStepScale = _mm_unpacklo_ps(paramValue_k__BackingField_low, v145).m128_u64[0];
		  v211.cloudQualityPack.farCloudEmptySkipSizeScale = v149;
		  v155 = *(_QWORD *)&v211.cloudQualityPack.farCloudFullUpdateMarchStepScale;
		  *(_OWORD *)&retstr->cloudQualityPack.farCloudFramingCubicSample = *(_OWORD *)&v211.cloudQualityPack.farCloudFramingCubicSample;
		LABEL_263:
		  result = retstr;
		  *(_QWORD *)&retstr->cloudQualityPack.farCloudFullUpdateMarchStepScale = v155;
		  return result;
		}
		
	}
}
