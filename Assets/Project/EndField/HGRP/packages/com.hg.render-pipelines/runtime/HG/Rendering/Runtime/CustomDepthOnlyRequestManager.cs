using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class CustomDepthOnlyRequestManager // TypeDefIndex: 37912
	{
		// Fields
		private DynamicArray<SystemData> m_systems; // 0x10
		private int m_systemCount; // 0x18
	
		// Nested types
		public struct VSMSupport // TypeDefIndex: 37899
		{
			// Fields
			public int shaderID; // 0x00
		}
	
		public struct OptionalFeatures // TypeDefIndex: 37900
		{
			// Fields
			public VSMSupport? vsmSupport; // 0x00
		}
	
		public struct Request // TypeDefIndex: 37901
		{
			// Fields
			internal Vector3 rootPosition; // 0x00
			public Vector3 frustumSize; // 0x0C
			public Vector2Int rtSize; // 0x18
			public Vector2Int pageSize; // 0x20
			public DepthBits depthBits; // 0x28
			public GraphicsFormat format; // 0x2C
			public int depthRTShaderID; // 0x30
			public int transformCBShaderID; // 0x34
			public bool includeDynamicObjects; // 0x38
		}
	
		internal struct VSMData // TypeDefIndex: 37902
		{
			// Fields
			public TextureHandle vsmRT; // 0x00
			public int shaderID; // 0x10
		}
	
		internal struct OptionalData // TypeDefIndex: 37903
		{
			// Fields
			public VSMData? vsmData; // 0x00
		}
	
		private struct PageInfo // TypeDefIndex: 37904
		{
			// Fields
			public Vector2Int pageIndex; // 0x00
			public bool pageRoundIndex; // 0x08
		}
	
		private struct DepthRefreshParams // TypeDefIndex: 37905
		{
			// Fields
			public Vector4 params0; // 0x00
			public Vector4 params1; // 0x10
		}
	
		internal struct Transforms // TypeDefIndex: 37906
		{
			// Fields
			public Matrix4x4 transform; // 0x00
			public Vector4 uvScrollOffset; // 0x40
		}
	
		internal struct PerFrameData // TypeDefIndex: 37907
		{
			// Fields
			public RTHandle depthOnlyRT; // 0x00
			public float cameraHeight; // 0x08
		}
	
		private struct SystemData // TypeDefIndex: 37908
		{
			// Fields
			public Request request; // 0x00
			public OptionalData optionalData; // 0x3C
			public bool isValid; // 0x54
			public bool paused; // 0x55
			public Vector2Int pageCount; // 0x58
			public Vector2 frustumPageSize; // 0x60
			public Vector2 anchorPosition; // 0x68
			public List<int> ringIndices; // 0x70
			public List<Vector2Int> pageOrder; // 0x78
			public Queue<Vector2> invalidPages; // 0x80
			public int currPage; // 0x88
			public Vector3 currPosition; // 0x8C
			public Vector2Int rectCurrOffset; // 0x98
			public Vector2Int rectRootOffset; // 0xA0
			public Transforms transforms; // 0xA8
			public int currRTIndex; // 0xF8
			public PerFrameData[] perFrameData; // 0x100
		}
	
		internal struct RenderData // TypeDefIndex: 37909
		{
			// Fields
			public Matrix4x4 cullingViewProj; // 0x00
			public Matrix4x4 deviceViewProj; // 0x40
			public TextureHandle prevDepthOnlyRT; // 0x80
			public TextureHandle currDepthOnlyRT; // 0x90
			public CBHandle cameraHeightRefreshDataCB; // 0xA0
			public CBHandle transformCB; // 0xB8
			public Rect clearViewport0; // 0xD0
			public Rect clearViewport1; // 0xE0
			public Rect clearViewport2; // 0xF0
			public Rect clearViewport3; // 0x100
			public Rect pageViewport; // 0x110
			public Rect wholeViewport; // 0x120
			public int depthRTShaderID; // 0x130
			public int transformCBShaderID; // 0x134
			public bool includeDynamicObjects; // 0x138
			public bool isOrthographic; // 0x139
		}
	
		public struct Handle // TypeDefIndex: 37910
		{
			// Fields
			internal int index; // 0x00
		}
	
		// Constructors
		public CustomDepthOnlyRequestManager() {} // 0x0000000182EDA650-0x0000000182EDA6A0
		// CustomDepthOnlyRequestManager()
		void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CustomDepthOnlyRequestManager(
		        CustomDepthOnlyRequestManager *this,
		        MethodInfo *method)
		{
		  DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v3 = (DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>);
		  v6 = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::DynamicArray(
		    v3,
		    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::DynamicArray);
		  this->fields.m_systems = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v10);
		}
		
	
		// Methods
		private SystemData? CreateSystem(ref Request request) => default; // 0x0000000189B43F3C-0x0000000189B44664
		// Nullable`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+SystemData] CreateSystem(CustomDepthOnlyRequestManager+Request ByRef)
		Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateSystem(
		        Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *__return_ptr retstr,
		        CustomDepthOnlyRequestManager *this,
		        CustomDepthOnlyRequestManager_Request *request,
		        MethodInfo *method)
		{
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v5; // r14
		  LowLevelList_1_System_Object_ *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  List_1_UnityEngine_Vector2Int_ *v10; // rdi
		  __int64 v11; // r13
		  int v12; // r15d
		  int v13; // ebx
		  int v14; // r12d
		  List_1_UnityEngine_Vector2Int_ *v15; // r14
		  int i; // edi
		  double v17; // xmm1_8
		  GenericDelegateCallerGen_FStructSize8FStructSize8_intDelegate_3_Beyond_Gameplay_Factory_Core_Vector2IntData_Beyond_Gameplay_Factory_Core_Vector2IntData_System_Int32_ *v18; // rax
		  Comparison_1_UnityEngine_Vector2Int_ *v19; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v20; // rax
		  System::Math *v21; // rcx
		  float v22; // xmm7_4
		  float v23; // xmm1_4
		  System::Math *v24; // rcx
		  float v25; // xmm0_4
		  int v26; // r8d
		  __int64 v27; // r13
		  unsigned int v28; // ecx
		  int v29; // ebx
		  __int64 v30; // rdi
		  int v31; // eax
		  int v32; // edx
		  unsigned int v33; // r8d
		  SingleFieldAccessor__Class *v34; // r13
		  __int64 v35; // rbx
		  unsigned int v36; // r14d
		  __int64 v37; // rax
		  __int64 v38; // rcx
		  __int64 v39; // rdx
		  RTHandle *v40; // rbx
		  SingleFieldAccessor *v41; // rax
		  Type *v42; // rdx
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  RTHandle *v45; // rbx
		  SingleFieldAccessor *v46; // rax
		  Type *v47; // rdx
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **v49; // r9
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  float x; // xmm2_4
		  Type *v54; // rdx
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  Type *v57; // rdx
		  PropertyInfo_1 *v58; // r8
		  Int32__Array **v59; // r9
		  Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *v60; // rax
		  Func_2_Google_Protobuf_IMessage_Object_ *v61; // rsi
		  Type *v62; // rdx
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **v64; // r9
		  Type *v65; // rdx
		  PropertyInfo_1 *v66; // r8
		  Int32__Array **v67; // r9
		  _OWORD *v68; // rcx
		  __int64 v69; // rdx
		  _OWORD *v70; // rax
		  __int128 v71; // xmm1
		  __int128 v72; // xmm0
		  __int128 v73; // xmm1
		  __int128 v74; // xmm0
		  __int128 v75; // xmm1
		  __int128 v76; // xmm0
		  __int128 v77; // xmm1
		  struct MethodInfo *v78; // r8
		  _OWORD *p_hasValue; // rax
		  SingleFieldAccessor__Fields *p_fields; // rcx
		  __int128 v81; // xmm1
		  __int128 v82; // xmm0
		  __int128 v83; // xmm1
		  __int128 v84; // xmm0
		  FieldAccessorBase__Fields v85; // xmm1
		  __int128 v86; // xmm0
		  __int128 v87; // xmm1
		  __int64 v88; // rdi
		  __int128 v89; // xmm1
		  __int128 v90; // xmm0
		  __int128 v91; // xmm1
		  __int128 v92; // xmm0
		  FieldAccessorBase__Fields v93; // xmm1
		  __int128 v94; // xmm0
		  __int128 v95; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v97; // rax
		  __int64 v98; // rdi
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v99; // rcx
		  __int128 v100; // xmm1
		  __int128 v101; // xmm0
		  __int128 v102; // xmm1
		  __int128 v103; // xmm0
		  __int128 v104; // xmm1
		  __int128 v105; // xmm0
		  __int128 v106; // xmm1
		  MethodInfo *colorFormata; // [rsp+28h] [rbp-100h]
		  MethodInfo *colorFormatb; // [rsp+28h] [rbp-100h]
		  MethodInfo *colorFormatc; // [rsp+28h] [rbp-100h]
		  MethodInfo *colorFormatd; // [rsp+28h] [rbp-100h]
		  MethodInfo *colorFormat; // [rsp+28h] [rbp-100h]
		  MethodInfo *colorFormate; // [rsp+28h] [rbp-100h]
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v114; // [rsp+B0h] [rbp-78h]
		  __int64 v115; // [rsp+B8h] [rbp-70h]
		  MonitorData *v116; // [rsp+C0h] [rbp-68h]
		  _QWORD v117[2]; // [rsp+C8h] [rbp-60h] BYREF
		  _OWORD v118[3]; // [rsp+D8h] [rbp-50h] BYREF
		  __int64 v119; // [rsp+108h] [rbp-20h]
		  int v120; // [rsp+110h] [rbp-18h]
		  char v121; // [rsp+12Ch] [rbp+4h]
		  __int64 v122; // [rsp+130h] [rbp+8h]
		  float v123; // [rsp+138h] [rbp+10h]
		  float v124; // [rsp+13Ch] [rbp+14h]
		  SingleFieldAccessor v125[2]; // [rsp+148h] [rbp+20h] BYREF
		  SingleFieldAccessor v126[5]; // [rsp+1D8h] [rbp+B0h] BYREF
		  _BYTE v127[304]; // [rsp+2F8h] [rbp+1D0h] BYREF
		  SingleFieldAccessor__Class *v129; // [rsp+468h] [rbp+340h]
		
		  v5 = retstr;
		  if ( !IFix::WrappersManagerImpl::IsPatched(843, 0LL) )
		  {
		    if ( request->rtSize.m_X % request->pageSize.m_X || request->rtSize.m_Y % request->pageSize.m_Y )
		    {
		      sub_18033B9D0(&v126[0].fields, 0LL, 272LL);
		      v88 = 2LL;
		      p_fields = &v126[0].fields;
		      p_hasValue = &v5->hasValue;
		      do
		      {
		        v89 = *(_OWORD *)&p_fields->setValueDelegate;
		        *p_hasValue = p_fields->_;
		        v90 = *(_OWORD *)&p_fields->hasDelegate;
		        p_hasValue[1] = v89;
		        v91 = *(_OWORD *)&p_fields[1]._.descriptor;
		        p_hasValue[2] = v90;
		        v92 = *(_OWORD *)&p_fields[1].clearDelegate;
		        p_hasValue[3] = v91;
		        v93 = p_fields[2]._;
		        p_hasValue[4] = v92;
		        v94 = *(_OWORD *)&p_fields[2].setValueDelegate;
		        p_hasValue[5] = v93;
		        v95 = *(_OWORD *)&p_fields[2].hasDelegate;
		        p_fields = (SingleFieldAccessor__Fields *)((char *)p_fields + 128);
		        p_hasValue[6] = v94;
		        p_hasValue += 8;
		        *(p_hasValue - 1) = v95;
		        --v88;
		      }
		      while ( v88 );
		LABEL_34:
		      *p_hasValue = p_fields->_;
		      return v5;
		    }
		    v7 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>);
		    v116 = (MonitorData *)v7;
		    v10 = (List_1_UnityEngine_Vector2Int_ *)v7;
		    if ( v7 )
		    {
		      System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		        v7,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::List);
		      v11 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::__c__DisplayClass14_0);
		      if ( v11 )
		      {
		        v12 = request->rtSize.m_X / request->pageSize.m_X;
		        LODWORD(v115) = v12;
		        v13 = 0;
		        v14 = request->rtSize.m_Y / request->pageSize.m_Y;
		        HIDWORD(v115) = v14;
		        if ( v14 > 0 )
		        {
		          v15 = v10;
		          do
		          {
		            for ( i = 0; i < v12; ++i )
		              sub_183D76270(
		                v15,
		                __PAIR64__(v13, i),
		                MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::Add);
		            ++v13;
		          }
		          while ( v13 < v14 );
		          v5 = retstr;
		          v10 = (List_1_UnityEngine_Vector2Int_ *)v116;
		        }
		        *(_QWORD *)&v17 = COERCE_UNSIGNED_INT((float)v12);
		        *(float *)&v17 = (float)(*(float *)&v17 * 0.5) - 0.5;
		        *(_DWORD *)(v11 + 16) = LODWORD(v17);
		        *(float *)(v11 + 20) = (float)((float)v14 * 0.5) - 0.5;
		        v18 = (GenericDelegateCallerGen_FStructSize8FStructSize8_intDelegate_3_Beyond_Gameplay_Factory_Core_Vector2IntData_Beyond_Gameplay_Factory_Core_Vector2IntData_System_Int32_ *)sub_1800368D0(TypeInfo::System::Comparison<UnityEngine::Vector2Int>);
		        v19 = (Comparison_1_UnityEngine_Vector2Int_ *)v18;
		        if ( v18 )
		        {
		          Beyond::Reflection::GenericDelegateCallerGen::FStructSize8FStructSize8_intDelegate<Beyond::Gameplay::Factory::Core::Vector2IntData,Beyond::Gameplay::Factory::Core::Vector2IntData,int>::FStructSize8FStructSize8_intDelegate(
		            v18,
		            (Object *)v11,
		            MethodInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::__c__DisplayClass14_0::_CreateSystem_b__0,
		            0LL);
		          System::Collections::Generic::List<UnityEngine::Vector2Int>::Sort(
		            v10,
		            v19,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::Sort);
		          v20 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		          v114 = v20;
		          if ( v20 )
		          {
		            System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		              v20,
		              MethodInfo::System::Collections::Generic::List<int>::List);
		            sub_1800036A0(TypeInfo::System::Math);
		            System::Math::Ceiling(v21, v17);
		            v22 = (float)v12 * 0.5;
		            v23 = (float)v14 * 0.5;
		            System::Math::Ceiling(v24, COERCE_DOUBLE((unsigned __int64)LODWORD(v23)));
		            if ( v22 <= v23 )
		              v25 = v23;
		            else
		              v25 = (float)v12 * 0.5;
		            v26 = (int)v25;
		            if ( v23 <= v22 )
		              v22 = (float)v14 * 0.5;
		            LODWORD(v27) = (int)v22;
		            v28 = 0;
		            v29 = ((v26 & 1) == 0) + 1;
		            v30 = 2LL;
		            if ( (int)v22 > 0 )
		            {
		              v117[0] = (unsigned int)v27;
		              v27 = (unsigned int)v27;
		              do
		              {
		                sub_183081250(v114, v28, MethodInfo::System::Collections::Generic::List<int>::Add);
		                v28 = v29 * v29;
		                v29 += 2;
		                --v27;
		              }
		              while ( v27 );
		              v5 = retstr;
		              v26 = (int)v25;
		              LODWORD(v27) = (int)v22;
		            }
		            if ( (int)v27 >= v26 )
		            {
		              v34 = (SingleFieldAccessor__Class *)v114;
		            }
		            else
		            {
		              v32 = (int)v27 % 2;
		              v31 = (int)v27 / 2;
		              v33 = v26 - v27;
		              v34 = (SingleFieldAccessor__Class *)v114;
		              v35 = v33;
		              v36 = v32 + 4 * v31;
		              do
		              {
		                sub_183081250(v114, v28, MethodInfo::System::Collections::Generic::List<int>::Add);
		                v28 = v36;
		                --v35;
		              }
		              while ( v35 );
		              v5 = retstr;
		            }
		            v117[0] = 32 * v12;
		            v117[1] = 32 * v14;
		            il2cpp_array_new_full_1(
		              TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::PageInfo,
		              v117,
		              0LL);
		            ++this->fields.m_systemCount;
		            v37 = il2cpp_array_new_specific_1(
		                    TypeInfo::HG::Rendering::Runtime::CustomDepthOnlyRequestManager::PerFrameData,
		                    2LL);
		            v39 = 0LL;
		            v129 = (SingleFieldAccessor__Class *)v37;
		            if ( !v37 )
		              goto LABEL_35;
		            v40 = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                    request->rtSize.m_X,
		                    request->rtSize.m_Y,
		                    1,
		                    (DepthBits__Enum)request->depthBits,
		                    (GraphicsFormat__Enum)request->format,
		                    FilterMode__Enum_Point,
		                    TextureWrapMode__Enum_Repeat,
		                    TextureDimension__Enum_Tex2D,
		                    0,
		                    0,
		                    1,
		                    0,
		                    1,
		                    0.0,
		                    MSAASamples__Enum_None,
		                    0,
		                    RenderTextureMemoryless__Enum_None,
		                    (String *)"",
		                    0LL);
		            *(_QWORD *)sub_1803C0774(v129, 0LL) = v40;
		            v41 = (SingleFieldAccessor *)sub_1803C0774(v129, 0LL);
		            sub_18002D1B0(v41, v42, v43, v44, colorFormata);
		            v45 = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                    request->rtSize.m_X,
		                    request->rtSize.m_Y,
		                    1,
		                    (DepthBits__Enum)request->depthBits,
		                    (GraphicsFormat__Enum)request->format,
		                    FilterMode__Enum_Point,
		                    TextureWrapMode__Enum_Repeat,
		                    TextureDimension__Enum_Tex2D,
		                    0,
		                    0,
		                    1,
		                    0,
		                    1,
		                    0.0,
		                    MSAASamples__Enum_None,
		                    0,
		                    RenderTextureMemoryless__Enum_None,
		                    (String *)"",
		                    0LL);
		            *(_QWORD *)sub_1803C0774(v129, 1LL) = v45;
		            v46 = (SingleFieldAccessor *)sub_1803C0774(v129, 1LL);
		            sub_18002D1B0(v46, v47, v48, v49, colorFormatb);
		            sub_18033B9D0(v118, 0LL, 264LL);
		            v50 = *(_OWORD *)&request->rootPosition.x;
		            v51 = *(_OWORD *)&request->frustumSize.y;
		            v120 = *(_DWORD *)&request->includeDynamicObjects;
		            v118[0] = v50;
		            v52 = *(_OWORD *)&request->pageSize.m_X;
		            v121 = 1;
		            v118[1] = v51;
		            *(_QWORD *)&v51 = *(_QWORD *)&request->depthRTShaderID;
		            v118[2] = v52;
		            v119 = v51;
		            v122 = v115;
		            x = request->frustumSize.x;
		            v125[0].klass = v34;
		            *(float *)&v52 = request->frustumSize.y;
		            v123 = x / (float)v12;
		            v124 = *(float *)&v52 / (float)v14;
		            sub_18002D1B0(v125, v54, v55, v56, colorFormatc);
		            v125[0].monitor = v116;
		            sub_18002D1B0((SingleFieldAccessor *)&v125[0].monitor, v57, v58, v59, colorFormatd);
		            v60 = (Stack_1_System_Dynamic_BindingRestrictions_TestBuilder_AndNode_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>);
		            v61 = (Func_2_Google_Protobuf_IMessage_Object_ *)v60;
		            if ( !v60 )
		LABEL_35:
		              sub_1800D8260(v38, v39);
		            System::Collections::Generic::Stack<System::Dynamic::BindingRestrictions_TestBuilder::AndNode>::Stack(
		              v60,
		              MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Queue);
		            v125[0].fields._.getValueDelegate = v61;
		            sub_18002D1B0((SingleFieldAccessor *)&v125[0].fields, v62, v63, v64, colorFormat);
		            v126[0].klass = v129;
		            sub_18002D1B0(v126, v65, v66, v67, colorFormate);
		            sub_18033B9D0(&v126[0].fields, 0LL, 272LL);
		            v68 = v127;
		            v69 = 2LL;
		            v70 = v118;
		            do
		            {
		              v71 = v70[1];
		              *v68 = *v70;
		              v72 = v70[2];
		              v68[1] = v71;
		              v73 = v70[3];
		              v68[2] = v72;
		              v74 = v70[4];
		              v68[3] = v73;
		              v75 = v70[5];
		              v68[4] = v74;
		              v76 = v70[6];
		              v68[5] = v75;
		              v77 = v70[7];
		              v70 += 8;
		              v68[6] = v76;
		              v68 += 8;
		              *(v68 - 1) = v77;
		              --v69;
		            }
		            while ( v69 );
		            v78 = MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Nullable;
		            *(_QWORD *)v68 = *(_QWORD *)v70;
		            sub_1806BEA70(&v126[0].fields, v127, v78);
		            p_hasValue = &v5->hasValue;
		            p_fields = &v126[0].fields;
		            do
		            {
		              v81 = *(_OWORD *)&p_fields->setValueDelegate;
		              *p_hasValue = p_fields->_;
		              v82 = *(_OWORD *)&p_fields->hasDelegate;
		              p_hasValue[1] = v81;
		              v83 = *(_OWORD *)&p_fields[1]._.descriptor;
		              p_hasValue[2] = v82;
		              v84 = *(_OWORD *)&p_fields[1].clearDelegate;
		              p_hasValue[3] = v83;
		              v85 = p_fields[2]._;
		              p_hasValue[4] = v84;
		              v86 = *(_OWORD *)&p_fields[2].setValueDelegate;
		              p_hasValue[5] = v85;
		              v87 = *(_OWORD *)&p_fields[2].hasDelegate;
		              p_fields = (SingleFieldAccessor__Fields *)((char *)p_fields + 128);
		              p_hasValue[6] = v86;
		              p_hasValue += 8;
		              *(p_hasValue - 1) = v87;
		              --v30;
		            }
		            while ( v30 );
		            goto LABEL_34;
		          }
		        }
		      }
		    }
		LABEL_40:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(843, 0LL);
		  if ( !Patch )
		    goto LABEL_40;
		  v97 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_332(
		          (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)&v126[0].fields,
		          Patch,
		          (Object *)this,
		          request,
		          0LL);
		  v98 = 2LL;
		  v99 = v5;
		  do
		  {
		    v100 = *(_OWORD *)&v97->value.request.rootPosition.z;
		    *(_OWORD *)&v99->hasValue = *(_OWORD *)&v97->hasValue;
		    v101 = *(_OWORD *)&v97->value.request.rtSize.m_X;
		    *(_OWORD *)&v99->value.request.rootPosition.z = v100;
		    v102 = *(_OWORD *)&v97->value.request.depthBits;
		    *(_OWORD *)&v99->value.request.rtSize.m_X = v101;
		    v103 = *(_OWORD *)&v97->value.request.includeDynamicObjects;
		    *(_OWORD *)&v99->value.request.depthBits = v102;
		    v104 = *(_OWORD *)&v97->value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
		    *(_OWORD *)&v99->value.request.includeDynamicObjects = v103;
		    v105 = *(_OWORD *)&v97->value.pageCount.m_X;
		    *(_OWORD *)&v99->value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value = v104;
		    v106 = *(_OWORD *)&v97->value.anchorPosition.x;
		    v97 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v97 + 128);
		    *(_OWORD *)&v99->value.pageCount.m_X = v105;
		    v99 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v99 + 128);
		    *(_OWORD *)&v99[-1].value.currRTIndex = v106;
		    --v98;
		  }
		  while ( v98 );
		  *(_OWORD *)&v99->hasValue = *(_OWORD *)&v97->hasValue;
		  return v5;
		}
		
		private RenderData CreateRenderData(int index, HGRenderGraph renderGraph) => default; // 0x0000000189B42F48-0x0000000189B43F3C
		// CustomDepthOnlyRequestManager+RenderData CreateRenderData(Int32, HGRenderGraph)
		CustomDepthOnlyRequestManager_RenderData *HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateRenderData(
		        CustomDepthOnlyRequestManager_RenderData *__return_ptr retstr,
		        CustomDepthOnlyRequestManager *this,
		        int32_t index,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  unsigned __int64 v9; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rcx
		  CustomDepthOnlyRequestManager_SystemData *Item; // r13
		  __int64 v12; // r12
		  int v13; // ebx
		  int v14; // edi
		  Queue_1_UnityEngine_Vector2_ *invalidPages; // rax
		  unsigned __int32 v16; // xmm6_4
		  float x; // xmm2_4
		  float y; // xmm9_4
		  WorldSetting_MissionImportanceAndType v19; // rax
		  __int64 v20; // rax
		  __int64 v21; // rcx
		  Vector2Int v22; // rax
		  MethodInfo *v23; // rdx
		  Vector2 v24; // rax
		  Vector2 v25; // r8
		  Vector2 v26; // r9
		  Vector2 v27; // rax
		  float v28; // xmm10_4
		  float v29; // xmm11_4
		  float v30; // xmm6_4
		  MethodInfo *v31; // rdx
		  float v32; // xmm8_4
		  Beyond::JobMathf *v33; // rcx
		  Beyond::JobMathf *v34; // rcx
		  MethodInfo *v35; // rdx
		  int v36; // r14d
		  MethodInfo *v37; // rdx
		  int v38; // r15d
		  MethodInfo *v39; // rdx
		  int v40; // edi
		  MethodInfo *v41; // rdx
		  int v42; // esi
		  int32_t v43; // eax
		  int32_t m_X; // ebx
		  int32_t v45; // eax
		  int32_t m_Y; // edx
		  int v47; // r11d
		  int v48; // r8d
		  int v49; // r9d
		  int v50; // ecx
		  int v51; // edx
		  int v52; // edx
		  int v53; // r11d
		  int v54; // eax
		  float v55; // xmm0_4
		  int v56; // eax
		  float v57; // xmm0_4
		  float v58; // xmm15_4
		  Matrix4x4 *inverse; // rax
		  __int128 v60; // xmm10
		  __int128 v61; // xmm11
		  __int128 v62; // xmm12
		  __int128 v63; // xmm13
		  int v64; // edx
		  int v65; // r8d
		  int v66; // r9d
		  _OWORD *v67; // rax
		  __int128 v68; // xmm1
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  Matrix4x4 *v71; // rax
		  __int128 v72; // xmm6
		  __int128 v73; // xmm7
		  __int128 v74; // xmm8
		  __int128 v75; // xmm9
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v77; // xmm1
		  __int128 v78; // xmm0
		  __int128 v79; // xmm1
		  Matrix4x4 *v80; // rax
		  __int64 currRTIndex; // rdi
		  __int128 v82; // xmm12
		  __int128 v83; // xmm13
		  __int64 v84; // r14
		  __int64 v85; // rax
		  __int64 v86; // rax
		  HGRenderGraphContext *HGContext; // rsi
		  CBHandle *v88; // rax
		  Void *ptr; // xmm10_8
		  __int128 v90; // xmm11
		  float v91; // xmm1_4
		  Matrix4x4 *v92; // rax
		  __int128 v93; // xmm6
		  __int128 v94; // xmm7
		  __int128 v95; // xmm8
		  __int128 v96; // xmm9
		  int v97; // edx
		  int v98; // r8d
		  int v99; // r9d
		  _OWORD *v100; // rax
		  __int128 v101; // xmm1
		  __int128 v102; // xmm0
		  __int128 v103; // xmm1
		  Matrix4x4 *v104; // rax
		  __int128 v105; // xmm1
		  __int128 v106; // xmm0
		  __int128 v107; // xmm1
		  Matrix4x4 *v108; // rax
		  __int128 v109; // xmm1
		  __int128 v110; // xmm0
		  __int128 v111; // xmm1
		  Matrix4x4 *v112; // rax
		  __int128 v113; // xmm1
		  __int128 v114; // xmm2
		  __int128 v115; // xmm3
		  MethodInfo *v116; // rdx
		  Beyond::JobMathf *v117; // rcx
		  MethodInfo *v118; // rdx
		  Beyond::JobMathf *v119; // rcx
		  __int128 v120; // xmm1
		  __int128 v121; // xmm0
		  __int128 v122; // xmm1
		  Vector4 uvScrollOffset; // xmm0
		  HGRenderGraphContext *v124; // rax
		  CBHandle *v125; // rax
		  Void *v126; // xmm6_8
		  __int128 v127; // xmm7
		  RTHandle **v128; // rax
		  TextureHandle *v129; // rax
		  RTHandle **v130; // rax
		  TextureHandle *v131; // rax
		  TextureHandle v132; // xmm0
		  float v133; // xmm1_4
		  float v134; // xmm2_4
		  __m128i v135; // xmm0
		  CustomDepthOnlyRequestManager_RenderData *v136; // rcx
		  __m128i v137; // xmm1
		  CustomDepthOnlyRequestManager_RenderData *v138; // rax
		  __int128 v139; // xmm1
		  __int128 v140; // xmm0
		  __int128 v141; // xmm1
		  __int128 v142; // xmm0
		  __int128 v143; // xmm1
		  __int128 v144; // xmm0
		  __int128 v145; // xmm1
		  __int128 v146; // xmm1
		  __int128 v147; // xmm0
		  __int128 v148; // xmm1
		  CustomDepthOnlyRequestManager_RenderData *v149; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  CustomDepthOnlyRequestManager_RenderData *v151; // rax
		  CustomDepthOnlyRequestManager_RenderData *v152; // rcx
		  __int64 v153; // r12
		  __int128 v154; // xmm1
		  __int128 v155; // xmm0
		  __int128 v156; // xmm1
		  __int128 v157; // xmm0
		  __int128 v158; // xmm1
		  __int128 v159; // xmm0
		  __int128 v160; // xmm1
		  __int128 v161; // xmm1
		  __int128 v162; // xmm0
		  __int128 v163; // xmm1
		  int v164; // [rsp+38h] [rbp-D0h]
		  float v165; // [rsp+38h] [rbp-D0h]
		  Vector2 result; // [rsp+40h] [rbp-C8h] BYREF
		  float v167; // [rsp+48h] [rbp-C0h]
		  Vector4 v168; // [rsp+58h] [rbp-B0h] BYREF
		  float v169; // [rsp+68h] [rbp-A0h]
		  float v170; // [rsp+6Ch] [rbp-9Ch]
		  float v171; // [rsp+70h] [rbp-98h]
		  float v172; // [rsp+74h] [rbp-94h]
		  float v173; // [rsp+78h] [rbp-90h]
		  float v174; // [rsp+7Ch] [rbp-8Ch]
		  float v175; // [rsp+80h] [rbp-88h]
		  Vector2 v176; // [rsp+88h] [rbp-80h]
		  Matrix4x4 source; // [rsp+98h] [rbp-70h] BYREF
		  CBHandle v178; // [rsp+D8h] [rbp-30h] BYREF
		  __int64 v179; // [rsp+F8h] [rbp-10h]
		  Matrix4x4 v180; // [rsp+108h] [rbp+0h] BYREF
		  __m128i si128; // [rsp+148h] [rbp+40h] BYREF
		  TextureHandle v182; // [rsp+158h] [rbp+50h] BYREF
		  Matrix4x4 v183; // [rsp+168h] [rbp+60h] BYREF
		  Matrix4x4 v184; // [rsp+1A8h] [rbp+A0h] BYREF
		  Vector4 v185; // [rsp+1E8h] [rbp+E0h]
		  CustomDepthOnlyRequestManager_RenderData v186; // [rsp+1F8h] [rbp+F0h] BYREF
		  Matrix4x4 v187; // [rsp+338h] [rbp+230h]
		  __int128 v188; // [rsp+378h] [rbp+270h]
		  Matrix4x4 v189[3]; // [rsp+388h] [rbp+280h] BYREF
		
		  sub_18033B9D0(&v180, 0LL, 64LL);
		  sub_18033B9D0(v189, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2258, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2258, 0LL);
		    if ( !Patch )
		      goto LABEL_42;
		    v151 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_913(
		             &v186,
		             Patch,
		             (Object *)this,
		             index,
		             (Object *)renderGraph,
		             0LL);
		    v152 = retstr;
		    v153 = 2LL;
		    do
		    {
		      v154 = *(_OWORD *)&v151->cullingViewProj.m01;
		      *(_OWORD *)&v152->cullingViewProj.m00 = *(_OWORD *)&v151->cullingViewProj.m00;
		      v155 = *(_OWORD *)&v151->cullingViewProj.m02;
		      *(_OWORD *)&v152->cullingViewProj.m01 = v154;
		      v156 = *(_OWORD *)&v151->cullingViewProj.m03;
		      *(_OWORD *)&v152->cullingViewProj.m02 = v155;
		      v157 = *(_OWORD *)&v151->deviceViewProj.m00;
		      *(_OWORD *)&v152->cullingViewProj.m03 = v156;
		      v158 = *(_OWORD *)&v151->deviceViewProj.m01;
		      *(_OWORD *)&v152->deviceViewProj.m00 = v157;
		      v159 = *(_OWORD *)&v151->deviceViewProj.m02;
		      *(_OWORD *)&v152->deviceViewProj.m01 = v158;
		      v160 = *(_OWORD *)&v151->deviceViewProj.m03;
		      v151 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v151 + 128);
		      *(_OWORD *)&v152->deviceViewProj.m02 = v159;
		      v152 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v152 + 128);
		      *(_OWORD *)&v152[-1].depthRTShaderID = v160;
		      --v153;
		    }
		    while ( v153 );
		    v161 = *(_OWORD *)&v151->cullingViewProj.m01;
		    *(_OWORD *)&v152->cullingViewProj.m00 = *(_OWORD *)&v151->cullingViewProj.m00;
		    v162 = *(_OWORD *)&v151->cullingViewProj.m02;
		    *(_OWORD *)&v152->cullingViewProj.m01 = v161;
		    v163 = *(_OWORD *)&v151->cullingViewProj.m03;
		    v149 = retstr;
		    *(_OWORD *)&v152->cullingViewProj.m02 = v162;
		    *(_OWORD *)&v152->cullingViewProj.m03 = v163;
		  }
		  else
		  {
		    m_systems = this->fields.m_systems;
		    if ( !m_systems )
		      goto LABEL_42;
		    Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		             m_systems,
		             index,
		             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
		    v179 = *(_QWORD *)&Item->currPosition.x;
		    v12 = 2LL;
		    v13 = Item->pageCount.m_X / 2;
		    v167 = *(float *)&v13;
		    v9 = (unsigned int)(Item->pageCount.m_Y >> 31);
		    LODWORD(v9) = Item->pageCount.m_Y % 2;
		    v14 = Item->pageCount.m_Y / 2;
		    v164 = v14;
		    result = 0LL;
		    invalidPages = Item->invalidPages;
		    if ( !invalidPages )
		      goto LABEL_42;
		    if ( invalidPages->fields._size > 0 )
		    {
		      v16 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_u32[0];
		      while ( 1 )
		      {
		        m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->invalidPages;
		        if ( !m_systems )
		          goto LABEL_42;
		        if ( !System::Collections::Generic::Queue<UnityEngine::Vector2>::TryDequeue(
		                (Queue_1_UnityEngine_Vector2_ *)m_systems,
		                &result,
		                MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::TryDequeue) )
		          break;
		        x = result.x;
		        if ( (float)v13 > COERCE_FLOAT(COERCE_UNSIGNED_INT((float)Item->rectRootOffset.m_X - result.x) & v16) )
		        {
		          y = result.y;
		          if ( (float)v14 > COERCE_FLOAT(COERCE_UNSIGNED_INT((float)Item->rectRootOffset.m_Y - result.y) & v16) )
		            goto LABEL_14;
		        }
		      }
		    }
		    m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->pageOrder;
		    if ( !m_systems )
		      goto LABEL_42;
		    v19 = System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::get_Item(
		            (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)m_systems,
		            Item->currPage,
		            MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2Int>::get_Item);
		    v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_185EC333C)(*(_QWORD *)&Item->rectRootOffset, v19);
		    v21 = HIDWORD(*(_QWORD *)&Item->pageCount);
		    LODWORD(result.x) = (int)*(_QWORD *)&Item->pageCount / 2;
		    LODWORD(result.y) = (int)v21 / 2;
		    v176 = result;
		    v22 = (Vector2Int)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_185EC339C)(v20, result);
		    v24 = UnityEngine::Vector2Int::op_Implicit(v22, v23);
		    v27 = sub_1853DF234(v24, (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u), v25, v26);
		    m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->pageOrder;
		    result = v27;
		    x = v27.x;
		    y = v27.y;
		    if ( !m_systems )
		      goto LABEL_42;
		    v9 = (unsigned int)((Item->currPage + 1) >> 31);
		    LODWORD(v9) = (Item->currPage + 1) % m_systems->fields._size_k__BackingField;
		    Item->currPage = v9;
		LABEL_14:
		    v28 = (float)(x * Item->frustumPageSize.x) + Item->request.rootPosition.x;
		    v29 = (float)(y * Item->frustumPageSize.y) + Item->request.rootPosition.z;
		    v30 = UnityEngine::Mathf::Sign(x, (MethodInfo *)v9);
		    v32 = UnityEngine::Mathf::Sign(y, v31);
		    Beyond::JobMathf::Fmod(v33, (float)Item->pageCount.m_X, x);
		    Beyond::JobMathf::Fmod(v34, (float)Item->pageCount.m_Y, x);
		    LODWORD(v176.x) = (int)(float)((float)((float)((float)((float)((float)v13 * v30) + x) - (float)((float)v13 * v30))
		                                         - 0.5)
		                                 + (float)v13);
		    v170 = 0.0;
		    v171 = 0.0;
		    v174 = 0.0;
		    v175 = 0.0;
		    LODWORD(result.x) = (int)(float)((float)((float)((float)((float)((float)v14 * v32) + y) - (float)((float)v14 * v32))
		                                           - 0.5)
		                                   + (float)v14);
		    v36 = (int)UnityEngine::Mathf::Sign((float)Item->rectCurrOffset.m_X, v35);
		    v38 = (int)UnityEngine::Mathf::Sign((float)Item->rectCurrOffset.m_Y, v37);
		    v40 = (int)UnityEngine::Mathf::Sign((float)Item->rectRootOffset.m_X, v39);
		    v42 = (int)UnityEngine::Mathf::Sign((float)Item->rectRootOffset.m_Y, v41);
		    v43 = sub_1833FD1B0((unsigned int)Item->rectCurrOffset.m_X);
		    m_X = Item->pageCount.m_X;
		    if ( v43 < m_X )
		      m_X = v43;
		    v45 = sub_1833FD1B0((unsigned int)Item->rectCurrOffset.m_Y);
		    m_Y = Item->pageCount.m_Y;
		    if ( v45 < m_Y )
		      m_Y = v45;
		    v47 = (Item->rectRootOffset.m_X + LODWORD(v167) * v36 - v36 * m_X + LODWORD(v167) * v40) % Item->pageCount.m_X
		        - LODWORD(v167) * v40;
		    v48 = (Item->rectRootOffset.m_X + LODWORD(v167) * v36 + LODWORD(v167) * v40) % Item->pageCount.m_X
		        - LODWORD(v167) * v40;
		    v49 = (Item->rectRootOffset.m_Y + v164 * v38 - v38 * m_Y + v164 * v42) % Item->pageCount.m_Y - v164 * v42 + v164;
		    v50 = (Item->rectRootOffset.m_Y + v164 * v38 + v164 * v42) % Item->pageCount.m_Y - v164 * v42 + v164;
		    v51 = v48;
		    if ( v36 >= 0 )
		      v51 = (Item->rectRootOffset.m_X + LODWORD(v167) * v36 - v36 * m_X + LODWORD(v167) * v40) % Item->pageCount.m_X
		          - LODWORD(v167) * v40;
		    v52 = LODWORD(v167) + v51;
		    if ( v36 >= 0 )
		      v47 = v48;
		    v53 = LODWORD(v167) + v47;
		    if ( v38 < 0 )
		    {
		      v54 = v49;
		      v49 = (Item->rectRootOffset.m_Y + v164 * v38 + v164 * v42) % Item->pageCount.m_Y - v164 * v42 + v164;
		      v50 = v54;
		    }
		    v55 = (float)(Item->request.pageSize.m_X * v52);
		    v167 = v55;
		    if ( v52 > v53 )
		    {
		      v167 = v55;
		      v165 = (float)(Item->request.pageSize.m_X * (Item->pageCount.m_X - v52));
		      v169 = (float)Item->request.rtSize.m_Y;
		      v170 = (float)(Item->request.pageSize.m_X * v53);
		      v171 = (float)Item->request.rtSize.m_Y;
		    }
		    else
		    {
		      v165 = (float)(Item->request.pageSize.m_X * (v53 - v52));
		      v169 = (float)Item->request.rtSize.m_Y;
		    }
		    v56 = Item->request.pageSize.m_Y * v49;
		    v57 = (float)Item->request.rtSize.m_X;
		    v172 = v57;
		    v58 = (float)v56;
		    if ( v49 > v50 )
		    {
		      v172 = v57;
		      v173 = (float)(Item->request.pageSize.m_Y * (Item->pageCount.m_Y - v49));
		      v174 = (float)Item->request.rtSize.m_X;
		      v175 = (float)(Item->request.pageSize.m_Y * v50);
		    }
		    else
		    {
		      v173 = (float)(Item->request.pageSize.m_Y * (v50 - v49));
		    }
		    v168.y = *((float *)&v179 + 1);
		    v168.x = v28;
		    v168.z = v29;
		    v168.w = 1.0;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		    *(__m128i *)&source.m00 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		    *(__m128i *)&v178.bufferId = _mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		    UnityEngine::Matrix4x4::Matrix4x4(&v180, (Vector4 *)&v178, (Vector4 *)&source, (Vector4 *)&si128, &v168, 0LL);
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v183, &v180, 0LL);
		    v60 = *(_OWORD *)&inverse->m00;
		    v61 = *(_OWORD *)&inverse->m01;
		    v62 = *(_OWORD *)&inverse->m02;
		    v63 = *(_OWORD *)&inverse->m03;
		    v67 = (_OWORD *)sub_1833A3CB0((unsigned int)&v180, v64, v65, v66, Item->request.frustumSize.z * 0.5);
		    v68 = v67[1];
		    *(_OWORD *)&source.m00 = *v67;
		    v69 = v67[2];
		    *(_OWORD *)&source.m01 = v68;
		    v70 = v67[3];
		    *(_OWORD *)&source.m02 = v69;
		    *(_OWORD *)&source.m03 = v70;
		    v71 = Unity::Mathematics::float4x4::op_Implicit(&v180, (float4x4 *)&source, 0LL);
		    *(_OWORD *)&source.m00 = v60;
		    *(_OWORD *)&source.m01 = v61;
		    *(_OWORD *)&source.m02 = v62;
		    v72 = *(_OWORD *)&v71->m00;
		    v73 = *(_OWORD *)&v71->m01;
		    v74 = *(_OWORD *)&v71->m02;
		    v75 = *(_OWORD *)&v71->m03;
		    *(_OWORD *)&source.m03 = v63;
		    *(_OWORD *)&v183.m00 = v72;
		    *(_OWORD *)&v183.m01 = v73;
		    *(_OWORD *)&v183.m02 = v74;
		    *(_OWORD *)&v183.m03 = v75;
		    v187 = *UnityEngine::Matrix4x4::op_Multiply(&v180, &v183, &source, 0LL);
		    *(_OWORD *)&v183.m00 = v72;
		    *(_OWORD *)&v183.m01 = v73;
		    *(_OWORD *)&v183.m02 = v74;
		    *(_OWORD *)&v183.m03 = v75;
		    GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v184, &v183, 1, 0LL);
		    *(_OWORD *)&source.m00 = v60;
		    *(_OWORD *)&source.m01 = v61;
		    *(_OWORD *)&source.m02 = v62;
		    v77 = *(_OWORD *)&GPUProjectionMatrix->m01;
		    *(_OWORD *)&v180.m00 = *(_OWORD *)&GPUProjectionMatrix->m00;
		    v78 = *(_OWORD *)&GPUProjectionMatrix->m02;
		    *(_OWORD *)&v180.m01 = v77;
		    v79 = *(_OWORD *)&GPUProjectionMatrix->m03;
		    *(_OWORD *)&v180.m02 = v78;
		    *(_OWORD *)&v180.m03 = v79;
		    *(_OWORD *)&source.m03 = v63;
		    v80 = UnityEngine::Matrix4x4::op_Multiply(&v184, &v180, &source, 0LL);
		    currRTIndex = Item->currRTIndex;
		    m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->perFrameData;
		    v82 = *(_OWORD *)&v80->m00;
		    v83 = *(_OWORD *)&v80->m01;
		    v188 = *(_OWORD *)&v80->m02;
		    v9 = (unsigned int)(((int)currRTIndex + 1) >> 31);
		    LODWORD(v9) = ((int)currRTIndex + 1) % 2;
		    v182 = *(TextureHandle *)&v80->m03;
		    v84 = (int)v9;
		    Item->currRTIndex = v9;
		    if ( !m_systems )
		      goto LABEL_42;
		    v85 = sub_1803C0774(m_systems, currRTIndex);
		    source.m30 = 0.0;
		    *(_QWORD *)&source.m21 = 0LL;
		    *(_DWORD *)(v85 + 8) = HIDWORD(v179);
		    m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->perFrameData;
		    if ( !m_systems )
		      goto LABEL_42;
		    v86 = sub_1803C0774(m_systems, currRTIndex);
		    m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->perFrameData;
		    source.m00 = *(float *)(v86 + 8);
		    if ( !m_systems )
		      goto LABEL_42;
		    source.m10 = *(float *)(sub_1803C0774(m_systems, v84) + 8);
		    source.m20 = 1.0 / Item->request.frustumSize.z;
		    source.m01 = (float)(Item->rectCurrOffset.m_X / Item->request.pageSize.m_X);
		    v9 = (unsigned int)(Item->rectCurrOffset.m_Y >> 31);
		    LODWORD(v9) = Item->rectCurrOffset.m_Y % Item->request.pageSize.m_Y;
		    source.m11 = (float)-(Item->rectCurrOffset.m_Y / Item->request.pageSize.m_Y);
		    if ( !renderGraph )
		      goto LABEL_42;
		    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		    if ( !HGContext )
		      goto LABEL_42;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    v88 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		            &v178,
		            &HGContext->fields.renderContext,
		            32,
		            0LL);
		    ptr = (Void *)v88->ptr;
		    v90 = *(_OWORD *)&v88->bufferId;
		    v178.ptr = ptr;
		    System::Buffer::MemoryCopy((Void *)&source, ptr, 32LL, 32LL, 0LL);
		    v91 = Item->currPosition.y;
		    v168.x = Item->currPosition.x;
		    v168.z = Item->currPosition.z;
		    v168.y = v91;
		    v168.w = 1.0;
		    *(__m128i *)&source.m00 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		    *(Vector4 *)&v178.bufferId = v168;
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		    v168 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		    UnityEngine::Matrix4x4::Matrix4x4(v189, &v168, (Vector4 *)&si128, (Vector4 *)&source, (Vector4 *)&v178, 0LL);
		    v92 = UnityEngine::Matrix4x4::get_inverse(&v184, v189, 0LL);
		    v93 = *(_OWORD *)&v92->m00;
		    v94 = *(_OWORD *)&v92->m01;
		    v95 = *(_OWORD *)&v92->m02;
		    v96 = *(_OWORD *)&v92->m03;
		    v100 = (_OWORD *)sub_1833A3CB0((unsigned int)&v184, v97, v98, v99, Item->request.frustumSize.z * 0.5);
		    v101 = v100[1];
		    *(_OWORD *)&v180.m00 = *v100;
		    v102 = v100[2];
		    *(_OWORD *)&v180.m01 = v101;
		    v103 = v100[3];
		    *(_OWORD *)&v180.m02 = v102;
		    *(_OWORD *)&v180.m03 = v103;
		    v104 = Unity::Mathematics::float4x4::op_Implicit(&v184, (float4x4 *)&v180, 0LL);
		    v105 = *(_OWORD *)&v104->m01;
		    *(_OWORD *)&v180.m00 = *(_OWORD *)&v104->m00;
		    v106 = *(_OWORD *)&v104->m02;
		    *(_OWORD *)&v180.m01 = v105;
		    v107 = *(_OWORD *)&v104->m03;
		    *(_OWORD *)&v180.m02 = v106;
		    *(_OWORD *)&v180.m03 = v107;
		    v108 = UnityEngine::GL::GetGPUProjectionMatrix(&v184, &v180, 1, 0LL);
		    *(_OWORD *)&v183.m00 = v93;
		    *(_OWORD *)&v183.m01 = v94;
		    *(_OWORD *)&v183.m02 = v95;
		    v109 = *(_OWORD *)&v108->m01;
		    *(_OWORD *)&source.m00 = *(_OWORD *)&v108->m00;
		    v110 = *(_OWORD *)&v108->m02;
		    *(_OWORD *)&source.m01 = v109;
		    v111 = *(_OWORD *)&v108->m03;
		    *(_OWORD *)&source.m02 = v110;
		    *(_OWORD *)&source.m03 = v111;
		    *(_OWORD *)&v183.m03 = v96;
		    v112 = UnityEngine::Matrix4x4::op_Multiply(&v184, &source, &v183, 0LL);
		    v113 = *(_OWORD *)&v112->m01;
		    v114 = *(_OWORD *)&v112->m02;
		    v115 = *(_OWORD *)&v112->m03;
		    *(_OWORD *)&Item->transforms.transform.m00 = *(_OWORD *)&v112->m00;
		    *(_OWORD *)&Item->transforms.transform.m01 = v113;
		    *(_OWORD *)&Item->transforms.transform.m02 = v114;
		    *(_OWORD *)&Item->transforms.transform.m03 = v115;
		    *(float *)&v115 = (float)Item->rectRootOffset.m_X;
		    *(float *)&v114 = (float)Item->pageCount.m_X;
		    *(float *)&v93 = (float)(UnityEngine::Mathf::Sign(*(float *)&v115, v116) * *(float *)&v114) * 0.5;
		    Beyond::JobMathf::Fmod(v117, *(float *)&v114, *(float *)&v114);
		    Item->transforms.uvScrollOffset.x = (float)(*(float *)&v93 + *(float *)&v115) - *(float *)&v93;
		    *(float *)&v115 = (float)Item->rectRootOffset.m_Y;
		    *(float *)&v114 = (float)Item->pageCount.m_Y;
		    *(float *)&v93 = (float)(UnityEngine::Mathf::Sign(*(float *)&v115, v118) * *(float *)&v114) * 0.5;
		    Beyond::JobMathf::Fmod(v119, *(float *)&v114, *(float *)&v114);
		    Item->transforms.uvScrollOffset.y = (float)(*(float *)&v93 + *(float *)&v115) - *(float *)&v93;
		    Item->transforms.uvScrollOffset.x = Item->transforms.uvScrollOffset.x / (float)Item->pageCount.m_X;
		    Item->transforms.uvScrollOffset.y = Item->transforms.uvScrollOffset.y / (float)Item->pageCount.m_Y;
		    v120 = *(_OWORD *)&Item->transforms.transform.m01;
		    *(_OWORD *)&v184.m00 = *(_OWORD *)&Item->transforms.transform.m00;
		    v121 = *(_OWORD *)&Item->transforms.transform.m02;
		    *(_OWORD *)&v184.m01 = v120;
		    v122 = *(_OWORD *)&Item->transforms.transform.m03;
		    *(_OWORD *)&v184.m02 = v121;
		    uvScrollOffset = Item->transforms.uvScrollOffset;
		    *(_OWORD *)&v184.m03 = v122;
		    v185 = uvScrollOffset;
		    v124 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		    if ( !v124 )
		      goto LABEL_42;
		    v125 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		             &v178,
		             &v124->fields.renderContext,
		             80,
		             0LL);
		    v126 = (Void *)v125->ptr;
		    v127 = *(_OWORD *)&v125->bufferId;
		    v178.ptr = v126;
		    System::Buffer::MemoryCopy((Void *)&v184, v126, 80LL, 80LL, 0LL);
		    sub_18033B9D0(&v186, 0LL, 320LL);
		    m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->perFrameData;
		    *(_OWORD *)&v186.deviceViewProj.m00 = v82;
		    v186.cullingViewProj = v187;
		    *(_OWORD *)&v186.deviceViewProj.m01 = v83;
		    *(_OWORD *)&v186.deviceViewProj.m02 = v188;
		    *(TextureHandle *)&v186.deviceViewProj.m03 = v182;
		    if ( !m_systems
		      || (v128 = (RTHandle **)sub_1803C0774(m_systems, currRTIndex),
		          v129 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportDepthbuffer(&v182, renderGraph, *v128, 0LL),
		          m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)Item->perFrameData,
		          v186.prevDepthOnlyRT = *v129,
		          !m_systems) )
		    {
		LABEL_42:
		      sub_1800D8260(m_systems, v9);
		    }
		    v130 = (RTHandle **)sub_1803C0774(m_systems, v84);
		    v131 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportDepthbuffer(&v182, renderGraph, *v130, 0LL);
		    v186.clearViewport0.m_YMin = 0.0;
		    v186.clearViewport1.m_XMin = 0.0;
		    v132 = *v131;
		    LODWORD(v131) = Item->request.depthRTShaderID;
		    v186.clearViewport1.m_YMin = 0.0;
		    v186.clearViewport2.m_XMin = 0.0;
		    v186.clearViewport3.m_XMin = 0.0;
		    v186.clearViewport3.m_YMin = 0.0;
		    v186.currDepthOnlyRT = v132;
		    v186.depthRTShaderID = (int)v131;
		    LODWORD(v131) = Item->request.transformCBShaderID;
		    v186.clearViewport0.m_XMin = v167;
		    v186.clearViewport0.m_Height = v169;
		    v186.clearViewport0.m_Width = v165;
		    v186.clearViewport1.m_Width = v170;
		    v186.clearViewport1.m_Height = v171;
		    v186.clearViewport2.m_Width = v172;
		    v186.clearViewport2.m_Height = v173;
		    v186.transformCBShaderID = (int)v131;
		    LOBYTE(v131) = Item->request.includeDynamicObjects;
		    v186.clearViewport3.m_Width = v174;
		    v186.clearViewport2.m_YMin = v58;
		    v186.clearViewport3.m_Height = v175;
		    v186.includeDynamicObjects = (char)v131;
		    v186.isOrthographic = 1;
		    *(_OWORD *)&v186.transformCB.bufferId = v127;
		    v186.transformCB.ptr = v126;
		    *(_OWORD *)&v186.cameraHeightRefreshDataCB.bufferId = v90;
		    v186.cameraHeightRefreshDataCB.ptr = ptr;
		    v133 = (float)Item->request.pageSize.m_X;
		    v134 = (float)Item->request.pageSize.m_Y;
		    *(float *)&v132.handle.m_Value = (float)(Item->request.pageSize.m_Y * LODWORD(result.x));
		    v186.pageViewport.m_XMin = (float)(Item->request.pageSize.m_X * LODWORD(v176.x));
		    LODWORD(v186.pageViewport.m_YMin) = v132.handle.m_Value;
		    v186.pageViewport.m_Width = v133;
		    v186.pageViewport.m_Height = v134;
		    v135 = _mm_cvtsi32_si128(Item->request.rtSize.m_X);
		    v136 = &v186;
		    v137 = _mm_cvtsi32_si128(Item->request.rtSize.m_Y);
		    v186.wholeViewport.m_XMin = 0.0;
		    v186.wholeViewport.m_YMin = 0.0;
		    v138 = retstr;
		    LODWORD(v186.wholeViewport.m_Width) = _mm_cvtepi32_ps(v135).m128_u32[0];
		    LODWORD(v186.wholeViewport.m_Height) = _mm_cvtepi32_ps(v137).m128_u32[0];
		    do
		    {
		      v139 = *(_OWORD *)&v136->cullingViewProj.m01;
		      *(_OWORD *)&v138->cullingViewProj.m00 = *(_OWORD *)&v136->cullingViewProj.m00;
		      v140 = *(_OWORD *)&v136->cullingViewProj.m02;
		      *(_OWORD *)&v138->cullingViewProj.m01 = v139;
		      v141 = *(_OWORD *)&v136->cullingViewProj.m03;
		      *(_OWORD *)&v138->cullingViewProj.m02 = v140;
		      v142 = *(_OWORD *)&v136->deviceViewProj.m00;
		      *(_OWORD *)&v138->cullingViewProj.m03 = v141;
		      v143 = *(_OWORD *)&v136->deviceViewProj.m01;
		      *(_OWORD *)&v138->deviceViewProj.m00 = v142;
		      v144 = *(_OWORD *)&v136->deviceViewProj.m02;
		      *(_OWORD *)&v138->deviceViewProj.m01 = v143;
		      v145 = *(_OWORD *)&v136->deviceViewProj.m03;
		      v136 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v136 + 128);
		      *(_OWORD *)&v138->deviceViewProj.m02 = v144;
		      v138 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v138 + 128);
		      *(_OWORD *)&v138[-1].depthRTShaderID = v145;
		      --v12;
		    }
		    while ( v12 );
		    v146 = *(_OWORD *)&v136->cullingViewProj.m01;
		    *(_OWORD *)&v138->cullingViewProj.m00 = *(_OWORD *)&v136->cullingViewProj.m00;
		    v147 = *(_OWORD *)&v136->cullingViewProj.m02;
		    *(_OWORD *)&v138->cullingViewProj.m01 = v146;
		    v148 = *(_OWORD *)&v136->cullingViewProj.m03;
		    *(_OWORD *)&v138->cullingViewProj.m02 = v147;
		    *(_OWORD *)&v138->cullingViewProj.m03 = v148;
		    return retstr;
		  }
		  return v149;
		}
		
		public Handle? RequestCustomDepthOnlyPassV1(ref Request request) => default; // 0x0000000189B44664-0x0000000189B448FC
		// Nullable`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+Handle] RequestCustomDepthOnlyPassV1(CustomDepthOnlyRequestManager+Request ByRef)
		Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_Handle_ HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RequestCustomDepthOnlyPassV1(
		        CustomDepthOnlyRequestManager *this,
		        CustomDepthOnlyRequestManager_Request *request,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *p_value; // rcx
		  int32_t size_k__BackingField; // ebp
		  int32_t i; // edi
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v10; // rax
		  __int64 v11; // r14
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v19; // rax
		  CustomDepthOnlyRequestManager_SystemData *Item; // rdi
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  _OWORD *p_x; // rcx
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v25; // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v33; // rdi
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *v34; // rax
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ value; // [rsp+20h] [rbp-238h] BYREF
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ v45; // [rsp+130h] [rbp-128h] BYREF
		  Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_Handle_ v46; // [rsp+278h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(842, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(842, 0LL);
		    if ( !Patch )
		      goto LABEL_24;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, request, 0LL);
		  }
		  else
		  {
		    size_k__BackingField = -1;
		    for ( i = 0; ; ++i )
		    {
		      m_systems = this->fields.m_systems;
		      if ( !m_systems )
		        goto LABEL_24;
		      if ( i >= m_systems->fields._size_k__BackingField )
		        goto LABEL_8;
		      if ( !UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		              this->fields.m_systems,
		              i,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item)->isValid )
		        break;
		    }
		    size_k__BackingField = i;
		LABEL_8:
		    v10 = HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateSystem(&v45, this, request, 0LL);
		    v11 = 2LL;
		    p_value = &value;
		    v5 = 2LL;
		    do
		    {
		      v12 = *(_OWORD *)&v10->value.request.rootPosition.z;
		      *(_OWORD *)&p_value->hasValue = *(_OWORD *)&v10->hasValue;
		      v13 = *(_OWORD *)&v10->value.request.rtSize.m_X;
		      *(_OWORD *)&p_value->value.request.rootPosition.z = v12;
		      v14 = *(_OWORD *)&v10->value.request.depthBits;
		      *(_OWORD *)&p_value->value.request.rtSize.m_X = v13;
		      v15 = *(_OWORD *)&v10->value.request.includeDynamicObjects;
		      *(_OWORD *)&p_value->value.request.depthBits = v14;
		      v16 = *(_OWORD *)&v10->value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
		      *(_OWORD *)&p_value->value.request.includeDynamicObjects = v15;
		      v17 = *(_OWORD *)&v10->value.pageCount.m_X;
		      *(_OWORD *)&p_value->value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value = v16;
		      v18 = *(_OWORD *)&v10->value.anchorPosition.x;
		      v10 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v10 + 128);
		      *(_OWORD *)&p_value->value.pageCount.m_X = v17;
		      p_value = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)p_value + 128);
		      *(_OWORD *)&p_value[-1].value.currRTIndex = v18;
		      --v5;
		    }
		    while ( v5 );
		    *(_OWORD *)&p_value->hasValue = *(_OWORD *)&v10->hasValue;
		    if ( value.hasValue )
		    {
		      v19 = this->fields.m_systems;
		      if ( size_k__BackingField == -1 )
		      {
		        if ( v19 )
		        {
		          size_k__BackingField = v19->fields._size_k__BackingField;
		          v33 = this->fields.m_systems;
		          System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value(
		            (CustomDepthOnlyRequestManager_SystemData *)&v45,
		            &value,
		            MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value);
		          v5 = (__int64)&value;
		          v34 = &v45;
		          do
		          {
		            v35 = *(_OWORD *)&v34->value.request.rootPosition.z;
		            *(_OWORD *)v5 = *(_OWORD *)&v34->hasValue;
		            v36 = *(_OWORD *)&v34->value.request.rtSize.m_X;
		            *(_OWORD *)(v5 + 16) = v35;
		            v37 = *(_OWORD *)&v34->value.request.depthBits;
		            *(_OWORD *)(v5 + 32) = v36;
		            v38 = *(_OWORD *)&v34->value.request.includeDynamicObjects;
		            *(_OWORD *)(v5 + 48) = v37;
		            v39 = *(_OWORD *)&v34->value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
		            *(_OWORD *)(v5 + 64) = v38;
		            v40 = *(_OWORD *)&v34->value.pageCount.m_X;
		            *(_OWORD *)(v5 + 80) = v39;
		            v41 = *(_OWORD *)&v34->value.anchorPosition.x;
		            v34 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v34 + 128);
		            *(_OWORD *)(v5 + 96) = v40;
		            v5 += 128LL;
		            *(_OWORD *)(v5 - 16) = v41;
		            --v11;
		          }
		          while ( v11 );
		          *(_QWORD *)v5 = *(_QWORD *)&v34->hasValue;
		          if ( v33 )
		          {
		            UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Add(
		              v33,
		              (CustomDepthOnlyRequestManager_SystemData *)&value,
		              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::Add);
		LABEL_21:
		            *(_DWORD *)&v46.hasValue = 1;
		            v46.value.index = size_k__BackingField;
		            return v46;
		          }
		        }
		      }
		      else if ( v19 )
		      {
		        Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		                 this->fields.m_systems,
		                 size_k__BackingField,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
		        System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value(
		          (CustomDepthOnlyRequestManager_SystemData *)&v45,
		          &value,
		          MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Value);
		        p_x = (_OWORD *)&Item->request.rootPosition.x;
		        v25 = &v45;
		        do
		        {
		          v26 = *(_OWORD *)&v25->value.request.rootPosition.z;
		          *p_x = *(_OWORD *)&v25->hasValue;
		          v27 = *(_OWORD *)&v25->value.request.rtSize.m_X;
		          p_x[1] = v26;
		          v28 = *(_OWORD *)&v25->value.request.depthBits;
		          p_x[2] = v27;
		          v29 = *(_OWORD *)&v25->value.request.includeDynamicObjects;
		          p_x[3] = v28;
		          v30 = *(_OWORD *)&v25->value.optionalData.vsmData.value.vsmRT.fallBackResource.m_Value;
		          p_x[4] = v29;
		          v31 = *(_OWORD *)&v25->value.pageCount.m_X;
		          p_x[5] = v30;
		          v32 = *(_OWORD *)&v25->value.anchorPosition.x;
		          v25 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)((char *)v25 + 128);
		          p_x[6] = v31;
		          p_x += 8;
		          *(p_x - 1) = v32;
		          --v11;
		        }
		        while ( v11 );
		        *(_QWORD *)p_x = *(_QWORD *)&v25->hasValue;
		        sub_18002D1B0((SingleFieldAccessor *)&Item->ringIndices, v21, v22, v23, *(MethodInfo **)&value.hasValue);
		        goto LABEL_21;
		      }
		LABEL_24:
		      sub_1800D8260(p_value, v5);
		    }
		    return 0LL;
		  }
		}
		
		public void RemoveSystem(Handle handle) {} // 0x00000001849E4220-0x00000001849E4270
		// Void RemoveSystem(CustomDepthOnlyRequestManager+Handle)
		void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RemoveSystem(
		        CustomDepthOnlyRequestManager *this,
		        CustomDepthOnlyRequestManager_Handle handle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rcx
		  CustomDepthOnlyRequestManager_SystemData *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(536, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(this, handle, 0LL) )
		      return;
		    --this->fields.m_systemCount;
		    m_systems = this->fields.m_systems;
		    if ( m_systems )
		    {
		      m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		                                                                                                     m_systems,
		                                                                                                     handle.index,
		                                                                                                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item)->perFrameData;
		      if ( m_systems )
		      {
		        m_systems = *(DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ **)sub_1803C0774(m_systems, 0LL);
		        if ( m_systems )
		        {
		          UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_systems, 0LL);
		          m_systems = this->fields.m_systems;
		          if ( m_systems )
		          {
		            m_systems = (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(m_systems, handle.index, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item)->perFrameData;
		            if ( m_systems )
		            {
		              m_systems = *(DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ **)sub_1803C0774(m_systems, 1LL);
		              if ( m_systems )
		              {
		                UnityEngine::Rendering::RTHandle::Release((RTHandle *)m_systems, 0LL);
		                m_systems = this->fields.m_systems;
		                if ( m_systems )
		                {
		                  Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		                           m_systems,
		                           handle.index,
		                           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
		                  sub_18033B9D0(Item, 0LL, 264LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(m_systems, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(536, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_228(Patch, (Object *)this, handle, 0LL);
		}
		
		public bool IsValid(Handle handle) => default; // 0x00000001849E4270-0x00000001849E42C0
		// Boolean IsValid(CustomDepthOnlyRequestManager+Handle)
		bool HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(
		        CustomDepthOnlyRequestManager *this,
		        CustomDepthOnlyRequestManager_Handle handle,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(537, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(537, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(Patch, (Object *)this, handle, 0LL);
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  m_systems = this->fields.m_systems;
		  if ( !m_systems )
		    goto LABEL_5;
		  return handle.index < m_systems->fields._size_k__BackingField
		      && UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		           this->fields.m_systems,
		           handle.index,
		           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item)->isValid;
		}
		
		public void UpdateSystem(Handle handle, Vector3 position) {} // 0x0000000189B44BE4-0x0000000189B45104
		// Void UpdateSystem(CustomDepthOnlyRequestManager+Handle, Vector3)
		void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::UpdateSystem(
		        CustomDepthOnlyRequestManager *this,
		        CustomDepthOnlyRequestManager_Handle handle,
		        Vector3 *position,
		        MethodInfo *method)
		{
		  unsigned __int64 ringIndices; // rdx
		  unsigned __int64 m_systems; // rcx
		  CustomDepthOnlyRequestManager_SystemData *Item; // rsi
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  int v16; // r12d
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  MethodInfo *v19; // rdx
		  int v20; // r14d
		  MethodInfo *v21; // rdx
		  int v22; // ebp
		  int v23; // r13d
		  int v24; // eax
		  int v25; // r8d
		  Queue_1_UnityEngine_Vector2_ *invalidPages; // rax
		  __m128 v27; // xmm7
		  __m128 v28; // xmm6
		  float v29; // xmm9_4
		  int v30; // ebx
		  int v31; // edi
		  float v32; // xmm0_4
		  int v33; // eax
		  int v34; // ebp
		  float v35; // xmm10_4
		  __m128 v36; // xmm8
		  int m_Y; // r14d
		  int v38; // r13d
		  int v39; // r12d
		  __m128 v40; // xmm1
		  __m128 v41; // xmm8
		  int m_X; // r14d
		  int v43; // r13d
		  int v44; // r12d
		  __m128 v45; // xmm0
		  int32_t v46; // edx
		  float y; // eax
		  float z; // eax
		  int v49; // [rsp+30h] [rbp-B8h]
		  int v50; // [rsp+34h] [rbp-B4h]
		  int v51; // [rsp+38h] [rbp-B0h]
		  int v52; // [rsp+3Ch] [rbp-ACh]
		  unsigned int v53; // [rsp+40h] [rbp-A8h]
		  Vector2Int v54; // [rsp+48h] [rbp-A0h]
		  Vector3 v55; // [rsp+50h] [rbp-98h] BYREF
		  int v56; // [rsp+60h] [rbp-88h]
		
		  *(_QWORD *)&v55.x = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(849, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(this, handle, 0LL) )
		      return;
		    m_systems = (unsigned __int64)this->fields.m_systems;
		    if ( m_systems )
		    {
		      if ( UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		             (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)m_systems,
		             handle.index,
		             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item)->paused )
		        return;
		      m_systems = (unsigned __int64)this->fields.m_systems;
		      if ( m_systems )
		      {
		        Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		                 (DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *)m_systems,
		                 handle.index,
		                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
		        LODWORD(v55.x) = sub_182F3EA70(v11, v10);
		        LODWORD(v55.y) = sub_182F3EA70(v13, v12);
		        v16 = sub_182F3EA70(v15, v14);
		        v56 = v16;
		        v54.m_X = v16;
		        v54.m_Y = sub_182F3EA70(v18, v17);
		        v20 = (int)UnityEngine::Mathf::Sign((float)SLODWORD(v55.x), v19);
		        v49 = v20;
		        v22 = (int)UnityEngine::Mathf::Sign((float)SLODWORD(v55.y), v21);
		        v50 = v22;
		        v51 = sub_1833FD1B0(LODWORD(v55.x));
		        v23 = v51;
		        v24 = sub_1833FD1B0(LODWORD(v55.y));
		        ringIndices = (unsigned int)v24;
		        v53 = v24;
		        v25 = v24;
		        if ( v51 > v24 )
		          v25 = v51;
		        v52 = v25;
		        if ( v25 <= 0 )
		          goto LABEL_42;
		        m_systems = (unsigned int)Item->pageCount.m_X;
		        if ( (int)m_systems >= Item->pageCount.m_Y )
		          m_systems = (unsigned int)Item->pageCount.m_Y;
		        if ( v25 > (int)(float)((float)(int)m_systems * 0.5) )
		        {
		          ringIndices = (unsigned __int64)Item->ringIndices;
		          if ( ringIndices )
		          {
		            v46 = *(_DWORD *)(ringIndices + 24) - v25;
		            if ( v46 <= 0 )
		              v46 = 0;
		            Item->currPage = System::Collections::Generic::List<int>::get_Item(
		                               Item->ringIndices,
		                               v46,
		                               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		            goto LABEL_42;
		          }
		        }
		        else
		        {
		          invalidPages = Item->invalidPages;
		          if ( invalidPages )
		          {
		            if ( (double)invalidPages->fields._size <= (double)(Item->pageCount.m_X * Item->pageCount.m_Y) * 0.7 )
		            {
		              v27 = 0LL;
		              v27.m128_f32[0] = (float)((float)((float)((float)Item->pageCount.m_X * 0.5) - 0.5) * (float)v20)
		                              + (float)v16;
		              v28 = 0LL;
		              v28.m128_f32[0] = (float)((float)((float)((float)Item->pageCount.m_X * 0.5) - 0.5) * (float)v22)
		                              + (float)v54.m_Y;
		              v29 = (float)v16 - (float)((float)((float)((float)Item->pageCount.m_X * 0.5) - 0.5) * (float)v20);
		              v30 = 0;
		              v31 = v22 * (ringIndices - 1);
		              v32 = (float)v22;
		              v33 = v22;
		              v34 = v20 * (v51 - 1);
		              v35 = (float)v54.m_Y - (float)((float)((float)((float)Item->pageCount.m_X * 0.5) - 0.5) * v32);
		              do
		              {
		                if ( v30 < v23 )
		                {
		                  v36 = v27;
		                  m_Y = v30 - ringIndices + Item->pageCount.m_Y + 1;
		                  v38 = 0;
		                  if ( m_Y >= Item->pageCount.m_Y )
		                    m_Y = Item->pageCount.m_Y;
		                  if ( m_Y <= 0 )
		                  {
		                    v33 = v50;
		                  }
		                  else
		                  {
		                    v39 = 0;
		                    do
		                    {
		                      m_systems = (unsigned __int64)Item->invalidPages;
		                      v40 = (__m128)COERCE_UNSIGNED_INT((float)v39);
		                      v40.m128_f32[0] = v40.m128_f32[0] + v35;
		                      if ( !m_systems )
		                        goto LABEL_44;
		                      v36.m128_f32[0] = v27.m128_f32[0] - (float)v34;
		                      System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue(
		                        (Queue_1_UnityEngine_Vector2_ *)m_systems,
		                        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v36, v40),
		                        MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue);
		                      v33 = v50;
		                      ++v38;
		                      v39 += v50;
		                    }
		                    while ( v38 < m_Y );
		                    v25 = v52;
		                    ringIndices = v53;
		                  }
		                  v23 = v51;
		                  v20 = v49;
		                }
		                if ( v30 < (int)ringIndices )
		                {
		                  v41 = v28;
		                  m_X = v30 + Item->pageCount.m_X - v23 + 1;
		                  v43 = 0;
		                  if ( m_X >= Item->pageCount.m_X )
		                    m_X = Item->pageCount.m_X;
		                  if ( m_X > 0 )
		                  {
		                    v44 = 0;
		                    do
		                    {
		                      m_systems = (unsigned __int64)Item->invalidPages;
		                      v45 = (__m128)COERCE_UNSIGNED_INT((float)v44);
		                      v45.m128_f32[0] = v45.m128_f32[0] + v29;
		                      if ( !m_systems )
		                        goto LABEL_44;
		                      v41.m128_f32[0] = v28.m128_f32[0] - (float)v31;
		                      System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue(
		                        (Queue_1_UnityEngine_Vector2_ *)m_systems,
		                        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v45, v41),
		                        MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Enqueue);
		                      v44 += v49;
		                      ++v43;
		                    }
		                    while ( v43 < m_X );
		                    v25 = v52;
		                    ringIndices = v53;
		                  }
		                  v33 = v50;
		                  v20 = v49;
		                }
		                v23 = v51;
		                ++v30;
		                v34 -= v20;
		                v31 -= v33;
		              }
		              while ( v30 < v25 );
		              v16 = v56;
		              Item->currPage = 0;
		              goto LABEL_42;
		            }
		            m_systems = (unsigned __int64)Item->invalidPages;
		            Item->currPage = 0;
		            if ( m_systems )
		            {
		              System::Collections::Generic::Queue<Rewired::Platforms::XboxOne::XboxOneInputSource::LnyDTHuLkKGdjkrEtCSrpMBFdXrlA>::Clear(
		                (Queue_1_Rewired_Platforms_XboxOne_XboxOneInputSource_LnyDTHuLkKGdjkrEtCSrpMBFdXrlA_ *)m_systems,
		                MethodInfo::System::Collections::Generic::Queue<UnityEngine::Vector2>::Clear);
		LABEL_42:
		              Item->currPosition.x = (float)((float)v16 * Item->frustumPageSize.x) + Item->request.rootPosition.x;
		              y = position->y;
		              Item->currPosition.z = (float)((float)v54.m_Y * Item->frustumPageSize.y) + Item->request.rootPosition.z;
		              Item->currPosition.y = y;
		              Item->rectCurrOffset = *(Vector2Int *)&v55.x;
		              Item->rectRootOffset = v54;
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_44:
		    sub_1800D8260(m_systems, ringIndices);
		  }
		  m_systems = (unsigned __int64)IFix::WrappersManagerImpl::GetPatch(849, 0LL);
		  if ( !m_systems )
		    goto LABEL_44;
		  z = position->z;
		  *(_QWORD *)&v55.x = *(_QWORD *)&position->x;
		  v55.z = z;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_335(
		    (ILFixDynamicMethodWrapper_2 *)m_systems,
		    (Object *)this,
		    handle,
		    &v55,
		    0LL);
		}
		
		public void TogglePass(Handle handle, bool enable) {} // 0x0000000189B44B4C-0x0000000189B44BE4
		// Void TogglePass(CustomDepthOnlyRequestManager+Handle, Boolean)
		void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::TogglePass(
		        CustomDepthOnlyRequestManager *this,
		        CustomDepthOnlyRequestManager_Handle handle,
		        bool enable,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(848, 0LL) )
		  {
		    if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(this, handle, 0LL) )
		      return;
		    m_systems = this->fields.m_systems;
		    if ( m_systems )
		    {
		      UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		        m_systems,
		        handle.index,
		        MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item)->paused = !enable;
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(m_systems, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(848, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_334(Patch, (Object *)this, handle, enable, 0LL);
		}
		
		public void Dispose() {} // 0x0000000184CB03A0-0x0000000184CB03F0
		// Void Dispose()
		void HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Dispose(
		        CustomDepthOnlyRequestManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  CustomDepthOnlyRequestManager_Handle v5; // edi
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2259, 0LL) )
		  {
		    for ( v5.index = 0; ; ++v5.index )
		    {
		      m_systems = this->fields.m_systems;
		      if ( !m_systems )
		        break;
		      if ( v5.index >= m_systems->fields._size_k__BackingField )
		        return;
		      HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RemoveSystem(this, v5, 0LL);
		    }
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2259, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal NativeArray<RenderData> RetrieveAllSystemRenderData(HGRenderGraph renderGraph) => default; // 0x0000000189B448FC-0x0000000189B44B4C
		// NativeArray`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+RenderData] RetrieveAllSystemRenderData(HGRenderGraph)
		NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RetrieveAllSystemRenderData(
		        NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *__return_ptr retstr,
		        CustomDepthOnlyRequestManager *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  Void *v8; // rcx
		  Void *m_Buffer; // r13
		  int32_t v10; // ebp
		  int32_t v11; // edi
		  __int64 v12; // r12
		  DynamicArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_SystemData_ *m_systems; // rax
		  CustomDepthOnlyRequestManager_SystemData *Item; // rax
		  __int64 v15; // r14
		  CustomDepthOnlyRequestManager_RenderData *v16; // rax
		  _OWORD *v17; // rcx
		  __int64 v18; // rdx
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  _OWORD *v29; // rax
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v40; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ *result; // rax
		  NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v43; // [rsp+30h] [rbp-2C8h] BYREF
		  NativeArray_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_RenderData_ v44; // [rsp+40h] [rbp-2B8h] BYREF
		  _BYTE v45[320]; // [rsp+50h] [rbp-2A8h] BYREF
		  CustomDepthOnlyRequestManager_RenderData v46; // [rsp+190h] [rbp-168h] BYREF
		
		  v43 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2260, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2260, 0LL);
		    if ( !Patch )
		LABEL_15:
		      sub_1800D8260(v8, v7);
		    v40 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_914(&v44, Patch, (Object *)this, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::NativeArray(
		      &v43,
		      this->fields.m_systemCount,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::NativeArray);
		    m_Buffer = v43.m_Buffer;
		    v10 = 0;
		    v11 = 0;
		    v12 = 0LL;
		    while ( 1 )
		    {
		      m_systems = this->fields.m_systems;
		      if ( !m_systems )
		        goto LABEL_15;
		      if ( v11 >= m_systems->fields._size_k__BackingField )
		        break;
		      Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item(
		               this->fields.m_systems,
		               v11,
		               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::SystemData>::get_Item);
		      if ( Item->isValid && !Item->paused )
		      {
		        v15 = v12;
		        ++v10;
		        ++v12;
		        v16 = HG::Rendering::Runtime::CustomDepthOnlyRequestManager::CreateRenderData(&v46, this, v11, renderGraph, 0LL);
		        v17 = v45;
		        v18 = 2LL;
		        do
		        {
		          v19 = *(_OWORD *)&v16->cullingViewProj.m01;
		          *v17 = *(_OWORD *)&v16->cullingViewProj.m00;
		          v20 = *(_OWORD *)&v16->cullingViewProj.m02;
		          v17[1] = v19;
		          v21 = *(_OWORD *)&v16->cullingViewProj.m03;
		          v17[2] = v20;
		          v22 = *(_OWORD *)&v16->deviceViewProj.m00;
		          v17[3] = v21;
		          v23 = *(_OWORD *)&v16->deviceViewProj.m01;
		          v17[4] = v22;
		          v24 = *(_OWORD *)&v16->deviceViewProj.m02;
		          v17[5] = v23;
		          v25 = *(_OWORD *)&v16->deviceViewProj.m03;
		          v16 = (CustomDepthOnlyRequestManager_RenderData *)((char *)v16 + 128);
		          v17[6] = v24;
		          v17 += 8;
		          *(v17 - 1) = v25;
		          --v18;
		        }
		        while ( v18 );
		        v7 = 2LL;
		        v26 = *(_OWORD *)&v16->cullingViewProj.m01;
		        *v17 = *(_OWORD *)&v16->cullingViewProj.m00;
		        v27 = *(_OWORD *)&v16->cullingViewProj.m02;
		        v17[1] = v26;
		        v28 = *(_OWORD *)&v16->cullingViewProj.m03;
		        v29 = v45;
		        v17[2] = v27;
		        v17[3] = v28;
		        v8 = &m_Buffer[320 * v15];
		        do
		        {
		          v30 = v29[1];
		          *(_OWORD *)v8 = *v29;
		          v31 = v29[2];
		          *(_OWORD *)&v8[16] = v30;
		          v32 = v29[3];
		          *(_OWORD *)&v8[32] = v31;
		          v33 = v29[4];
		          *(_OWORD *)&v8[48] = v32;
		          v34 = v29[5];
		          *(_OWORD *)&v8[64] = v33;
		          v35 = v29[6];
		          *(_OWORD *)&v8[80] = v34;
		          v36 = v29[7];
		          v29 += 8;
		          *(_OWORD *)&v8[96] = v35;
		          v8 += 128;
		          *(_OWORD *)&v8[-16] = v36;
		          --v7;
		        }
		        while ( v7 );
		        v37 = v29[1];
		        *(_OWORD *)v8 = *v29;
		        v38 = v29[2];
		        *(_OWORD *)&v8[16] = v37;
		        v39 = v29[3];
		        *(_OWORD *)&v8[32] = v38;
		        *(_OWORD *)&v8[48] = v39;
		      }
		      ++v11;
		    }
		    Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::GetSubArray(
		      &v44,
		      &v43,
		      0,
		      v10,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RenderData>::GetSubArray);
		    v40 = v44;
		  }
		  result = retstr;
		  *retstr = v40;
		  return result;
		}
		
	}
}
