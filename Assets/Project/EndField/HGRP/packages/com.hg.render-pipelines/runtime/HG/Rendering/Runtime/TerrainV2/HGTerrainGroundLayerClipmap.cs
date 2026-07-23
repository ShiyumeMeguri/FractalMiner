using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	internal class HGTerrainGroundLayerClipmap // TypeDefIndex: 38824
	{
		// Fields
		private Vector3 curCenter; // 0x10
		private float extent; // 0x1C
		private bool bDirty; // 0x20
		private uint layerIndex; // 0x24
		private static readonly RenderFunc<GroundLayerPassData> s_groundLayerFunc; // 0x00
	
		// Constructors
		public HGTerrainGroundLayerClipmap() {} // 0x0000000182ED8280-0x0000000182ED82A0
		// HGTerrainGroundLayerClipmap()
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::HGTerrainGroundLayerClipmap(
		        HGTerrainGroundLayerClipmap *this,
		        MethodInfo *method)
		{
		  this->fields.extent = 10.0;
		  *(_QWORD *)&this->fields.curCenter.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.curCenter.z = 0.0;
		}
		
		static HGTerrainGroundLayerClipmap() {} // 0x0000000184D2CCD0-0x0000000184D2CD60
		// HGTerrainGroundLayerClipmap()
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::cctor(MethodInfo *method)
		{
		  struct HGTerrainGroundLayerClipmap_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_TerrainV2_GroundLayerPassData_ *v6; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v7; // rdx
		  VolumetricRenderer_VolumetricBounds *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		  MethodInfo *v11; // [rsp+58h] [rbp+30h]
		  int32_t v12; // [rsp+60h] [rbp+38h]
		  int32_t v13; // [rsp+68h] [rbp+40h]
		  float v14; // [rsp+70h] [rbp+48h]
		  int32_t v15; // [rsp+78h] [rbp+50h]
		  bool v16; // [rsp+80h] [rbp+58h]
		  bool v17; // [rsp+88h] [rbp+60h]
		  MethodInfo *v18; // [rsp+90h] [rbp+68h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TerrainV2::GroundLayerPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_TerrainV2_GroundLayerPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::__c::__cctor_b__11_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap->static_fields->s_groundLayerFunc = v6;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap->static_fields,
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
		    v17,
		    v18);
		}
		
	
		// Methods
		public void Initialize(float _extent, uint _layerIndex) {} // 0x0000000182ED82A0-0x0000000182ED82F0
		// Void Initialize(Single, UInt32)
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Initialize(
		        HGTerrainGroundLayerClipmap *this,
		        float _extent,
		        uint32_t _layerIndex,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5456, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5456, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1579(Patch, (Object *)this, _extent, _layerIndex, 0LL);
		  }
		  else
		  {
		    this->fields.extent = _extent;
		    this->fields.layerIndex = _layerIndex;
		  }
		}
		
		public void Release() {} // 0x0000000189C79468-0x0000000189C794AC
		// Void Release()
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Release(
		        HGTerrainGroundLayerClipmap *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2282, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2282, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public void GetTerrainDeformParams(out Vector4 params0, out Vector4 params1) {
			params0 = default;
			params1 = default;
		} // 0x0000000189C7934C-0x0000000189C79468
		// Void GetTerrainDeformParams(Vector4 ByRef, Vector4 ByRef)
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::GetTerrainDeformParams(
		        HGTerrainGroundLayerClipmap *this,
		        Vector4 *params0,
		        Vector4 *params1,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v10; // [rsp+30h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3412, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3412, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1232(Patch, (Object *)this, params0, params1, 0LL);
		  }
		  else
		  {
		    v10.x = this->fields.extent;
		    v10.y = v10.x;
		    v10.z = this->fields.curCenter.x - (float)(v10.x * 0.5);
		    v10.w = this->fields.curCenter.z - (float)(v10.x * 0.5);
		    *params0 = v10;
		    v10.x = 1.0 / this->fields.extent;
		    v10.y = v10.x;
		    v10.z = (float)((float)-this->fields.curCenter.x / this->fields.extent) + 0.5;
		    v10.w = (float)((float)-this->fields.curCenter.z / this->fields.extent) + 0.5;
		    *params1 = v10;
		  }
		}
		
		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera, GroundLayerRTs rts) {} // 0x0000000189C794AC-0x0000000189C79990
		// Void Render(HGRenderGraph, HGCamera, GroundLayerRTs)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::Render(
		        HGTerrainGroundLayerClipmap *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        GroundLayerRTs *rts,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object *v12; // rdx
		  Object__Class **static_fields; // rcx
		  unsigned int v14; // edx
		  unsigned __int64 v15; // r8
		  char v16; // dl
		  signed __int64 v17; // rtt
		  Object *v18; // rsi
		  __int128 v19; // xmm2
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  TextureHandle v22; // xmm0
		  Object *v23; // rsi
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  TextureHandle v26; // xmm0
		  Object *v27; // rsi
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  TextureHandle v30; // xmm0
		  Object *v31; // rsi
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  TextureHandle v34; // xmm0
		  Object *v35; // rsi
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  TextureHandle v38; // xmm0
		  __int64 v39; // rdx
		  __int64 layerIndex; // rcx
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rsi
		  Object *v44; // [rsp+40h] [rbp-A8h] BYREF
		  TextureHandle v45; // [rsp+48h] [rbp-A0h] BYREF
		  GroundLayerRTs v46; // [rsp+60h] [rbp-88h] BYREF
		  _QWORD v47[2]; // [rsp+90h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v48; // [rsp+A0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v49; // [rsp+C0h] [rbp-28h] BYREF
		  Vector4 params1; // [rsp+C8h] [rbp-20h] BYREF
		
		  v44 = 0LL;
		  params1 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3423, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3423, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v42, v41);
		    v46 = *rts;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1236(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      &v46,
		      0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x10u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      (HGRenderGraphBuilder *)&v46,
		      renderGraph,
		      (String *)"TerrainGroundLayer",
		      &v44,
		      v9,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainV2::GroundLayerPassData>);
		    *(_OWORD *)&v48.m_RenderPass = *(_OWORD *)&v46.groundLayerBaseRT;
		    *(_OWORD *)&v48.m_RenderGraph = *(_OWORD *)&v46.groundLayerWetRT;
		    v47[0] = 0LL;
		    v47[1] = &v48;
		    try
		    {
		      v12 = v44;
		      static_fields = (Object__Class **)TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager->static_fields;
		      if ( !v44 )
		        sub_1800D8250(static_fields, 0LL);
		      v44[1].klass = *static_fields;
		      if ( dword_18F35FD08 )
		      {
		        v14 = ((unsigned __int64)&v12[1] >> 12) & 0x1FFFFF;
		        v15 = (unsigned __int64)v14 >> 6;
		        v16 = v14 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v15]);
		        do
		          v17 = qword_18F103690[v15];
		        while ( v17 != _InterlockedCompareExchange64(&qword_18F103690[v15], v17 | (1LL << v16), v17) );
		      }
		      v18 = v44;
		      v19 = *(_OWORD *)&rts->groundLayerBaseRT;
		      *(_OWORD *)&v46.groundLayerWetRT = *(_OWORD *)&rts->groundLayerWetRT;
		      v46.defaultRT = rts->defaultRT;
		      v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(&v45, renderGraph, (RTHandle *)v19, 0LL);
		      v22 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               (TextureHandle *)&v46,
		               &v48,
		               &v45,
		               0LL);
		      if ( !v18 )
		        sub_1800D8250(v21, v20);
		      *(TextureHandle *)&v18[1].monitor = v22;
		      v23 = v44;
		      *(_OWORD *)&v46.groundLayerWetRT = *(_OWORD *)&rts->groundLayerWetRT;
		      v46.defaultRT = rts->defaultRT;
		      v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               (TextureHandle *)&v46,
		               renderGraph,
		               rts->groundLayerNormalRT,
		               0LL);
		      v26 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               (TextureHandle *)&v46,
		               &v48,
		               &v45,
		               0LL);
		      if ( !v23 )
		        sub_1800D8250(v25, v24);
		      *(TextureHandle *)&v23[2].monitor = v26;
		      v27 = v44;
		      *(_OWORD *)&v46.groundLayerBaseRT = *(_OWORD *)&rts->groundLayerBaseRT;
		      v46.defaultRT = rts->defaultRT;
		      v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               (TextureHandle *)&v46,
		               renderGraph,
		               rts->groundLayerWetRT,
		               0LL);
		      v30 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               (TextureHandle *)&v46,
		               &v48,
		               &v45,
		               0LL);
		      if ( !v27 )
		        sub_1800D8250(v29, v28);
		      *(TextureHandle *)&v27[3].monitor = v30;
		      v31 = v44;
		      *(_OWORD *)&v46.groundLayerBaseRT = *(_OWORD *)&rts->groundLayerBaseRT;
		      v46.defaultRT = rts->defaultRT;
		      v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               (TextureHandle *)&v46,
		               renderGraph,
		               rts->groundLayerHeightRT,
		               0LL);
		      v34 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               (TextureHandle *)&v46,
		               &v48,
		               &v45,
		               0LL);
		      if ( !v31 )
		        sub_1800D8250(v33, v32);
		      *(TextureHandle *)&v31[4].monitor = v34;
		      v35 = v44;
		      v46 = *rts;
		      v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               (TextureHandle *)&v46,
		               renderGraph,
		               v46.defaultRT,
		               0LL);
		      v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v46, &v48, &v45, 0LL);
		      if ( !v35 )
		        sub_1800D8250(v37, v36);
		      *(TextureHandle *)&v35[5].monitor = v38;
		      if ( !v44 )
		        sub_1800D8250(v37, 0LL);
		      HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::GetTerrainDeformParams(
		        this,
		        (Vector4 *)((char *)&v44[6].monitor + 4),
		        &params1,
		        0LL);
		      layerIndex = this->fields.layerIndex;
		      if ( !v44 )
		        sub_1800D8250(layerIndex, v39);
		      HIDWORD(v44[7].monitor) = layerIndex;
		      LOBYTE(layerIndex) = this->fields.bDirty;
		      if ( !v44 )
		        sub_1800D8250(layerIndex, v39);
		      LOBYTE(v44[6].monitor) = layerIndex;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v48, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v48,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap->static_fields->s_groundLayerFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainV2::GroundLayerPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v49 )
		    {
		      v47[0] = v49->ex;
		    }
		    sub_180268AE0(v47);
		  }
		}
		
		public void SetPlayerCenter(Vector3 position) {} // 0x0000000183339D80-0x0000000183339F40
		// Void SetPlayerCenter(Vector3)
		void HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayerClipmap::SetPlayerCenter(
		        HGTerrainGroundLayerClipmap *this,
		        Vector3 *position,
		        MethodInfo *method)
		{
		  MethodInfo *v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  float z; // eax
		  __int64 v9; // xmm0_8
		  float v10; // eax
		  Vector3 *v11; // rax
		  System::MathF *v12; // rcx
		  float v13; // xmm4_4
		  float v14; // xmm1_4
		  __m128 x_low; // xmm0
		  float v16; // xmm8_4
		  __m128 v17; // xmm7
		  __m128 y_low; // xmm0
		  System::MathF *v19; // rcx
		  __m128 v20; // xmm6
		  System::MathF *v21; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v23; // xmm0_8
		  Vector3 v24; // [rsp+20h] [rbp-68h] BYREF
		  Vector3 v25; // [rsp+30h] [rbp-58h] BYREF
		  Vector3 v26; // [rsp+40h] [rbp-48h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 4053 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0xFD5 )
		        sub_1800D2AB0(v6, position);
		      if ( !v6[86]._0.klass )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(4053, 0LL);
		      if ( Patch )
		      {
		        v23 = *(_QWORD *)&position->x;
		        v24.z = position->z;
		        *(_QWORD *)&v24.x = v23;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, &v24, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v6, position);
		  }
		LABEL_5:
		  z = this->fields.curCenter.z;
		  *(_QWORD *)&v24.x = *(_QWORD *)&this->fields.curCenter.x;
		  v9 = *(_QWORD *)&position->x;
		  v24.z = z;
		  v10 = position->z;
		  *(_QWORD *)&v25.x = v9;
		  this->fields.bDirty = 0;
		  v25.z = v10;
		  v11 = UnityEngine::Vector3::op_Subtraction(&v26, &v25, &v24, v3);
		  v13 = this->fields.extent * 0.1;
		  *(_QWORD *)&v24.x = *(_QWORD *)&v11->x;
		  v14 = 0.0;
		  if ( (float)((float)((float)((float)(this->fields.curCenter.y - 0.0) * (float)(this->fields.curCenter.y - 0.0))
		                     + (float)((float)(COERCE_FLOAT(*(_QWORD *)&this->fields.curCenter.x) - 0.0)
		                             * (float)(COERCE_FLOAT(*(_QWORD *)&this->fields.curCenter.x) - 0.0)))
		             + (float)((float)(this->fields.curCenter.z - 0.0) * (float)(this->fields.curCenter.z - 0.0))) < 9.9999994e-11
		    || (v14 = *(float *)_mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32,
		        COERCE_FLOAT(LODWORD(v24.x) & LODWORD(v14)) > v13)
		    || COERCE_FLOAT(LODWORD(v24.y) & LODWORD(v14)) > v13 )
		  {
		    x_low = (__m128)LODWORD(position->x);
		    v16 = this->fields.extent * 0.0009765625;
		    x_low.m128_f32[0] = x_low.m128_f32[0] / v16;
		    System::MathF::Floor(v12, v14);
		    v17 = x_low;
		    y_low = (__m128)LODWORD(position->y);
		    y_low.m128_f32[0] = y_low.m128_f32[0] / v16;
		    v17.m128_f32[0] = v17.m128_f32[0] * v16;
		    System::MathF::Floor(v19, v14);
		    v20 = y_low;
		    y_low.m128_f32[0] = position->z / v16;
		    v20.m128_f32[0] = v20.m128_f32[0] * v16;
		    System::MathF::Floor(v21, v14);
		    *(_QWORD *)&this->fields.curCenter.x = _mm_unpacklo_ps(v17, v20).m128_u64[0];
		    this->fields.bDirty = 1;
		    this->fields.curCenter.z = y_low.m128_f32[0] * v16;
		  }
		}
		
	}
}
