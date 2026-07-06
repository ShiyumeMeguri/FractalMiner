using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPathBase : IRenderGraphCallbackOwner
	{
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x000025D0 File Offset: 0x000007D0
		private TextureHandle intermediateBackBuffer
		{
			[CompilerGenerated]
			get
			{
				// // Guid get_Item1()
				// Guid *System::Tuple<System::Guid,System::Object>::get_Item1(
				//         Guid *__return_ptr retstr,
				//         Tuple_2_Guid_Object_ *this,
				//         MethodInfo *method)
				// {
				//   Guid *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_Item1;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_value(Vector4)
				// void ParadoxNotion::EventData<UnityEngine::Vector4>::set_value(
				//         EventData_1_UnityEngine_Vector4_ *this,
				//         Vector4 *value,
				//         MethodInfo *method)
				// {
				//   this._value_k__BackingField = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600125F RID: 4703 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle backBufferColor
		{
			[CompilerGenerated]
			protected get
			{
				// // ValueTuple`2[Object,Int32] get_Current()
				// ValueTuple_2_Object_Int32_ *System::Collections::Generic::SortedList_2_TKey_TValue_::SortedListValueEnumerator<int,System::ValueTuple<System::Object,int>>::get_Current(
				//         ValueTuple_2_Object_Int32_ *__return_ptr retstr,
				//         SortedList_2_TKey_TValue_SortedListValueEnumerator_System_Int32_System_ValueTuple_2_Object_Int32_ *this,
				//         MethodInfo *method)
				// {
				//   ValueTuple_2_Object_Int32_ *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields._currentValue;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_color(Color)
				// void UnityEngine::Tilemaps::Tile::set_color(Tile *this, Color *value, MethodInfo *method)
				// {
				//   this.fields.m_Color = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001261 RID: 4705 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected TextureHandle backBufferDepth
		{
			[CompilerGenerated]
			protected get
			{
				// // Color get_Color()
				// Color *CW::Common::CwDemoButtonBuilder::get_Color(
				//         Color *__return_ptr retstr,
				//         CwDemoButtonBuilder *this,
				//         MethodInfo *method)
				// {
				//   Color *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.color;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_dryColor(Color)
				// void UnityEngine::DetailPrototype::set_dryColor(DetailPrototype *this, Color *value, MethodInfo *method)
				// {
				//   this.fields.m_DryColor = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00002BA8 File Offset: 0x00000DA8
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected PassConstructorID firstBackbufferPass
		{
			[CompilerGenerated]
			protected get
			{
				// // Int32Enum get_defaultValue()
				// Int32Enum__Enum UnityEngine::UIElements::TypedUxmlAttributeDescription<System::Int32Enum>::get_defaultValue(
				//         TypedUxmlAttributeDescription_1_System_Int32Enum_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return (PassConstructorID)PassConstructorID.UIImageBlur;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_defaultValue(Int32Enum)
				// void UnityEngine::UIElements::TypedUxmlAttributeDescription<System::Int32Enum>::set_defaultValue(
				//         TypedUxmlAttributeDescription_1_System_Int32Enum_ *this,
				//         Int32Enum__Enum value,
				//         MethodInfo *method)
				// {
				//   this.fields._defaultValue_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x000025D0 File Offset: 0x000007D0
		internal int renderPathID
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_bindingId()
				// int32_t Beyond::Input::UIEvent<System::Object>::get_bindingId(UIEvent_1_System_Object_ *this, MethodInfo *method)
				// {
				//   return this.fields._bindingId_k__BackingField;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_bindingId(Int32)
				// void Beyond::Input::UIEvent<System::Object>::set_bindingId(
				//         UIEvent_1_System_Object_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._bindingId_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x000025D0 File Offset: 0x000007D0
		internal int renderPathFrameIndex
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_defaultArea()
				// int32_t UnityEngine::AI::NavMeshSurface::get_defaultArea(NavMeshSurface *this, MethodInfo *method)
				// {
				//   return this.fields.m_DefaultArea;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_flags(TileFlags)
				// void UnityEngine::Tilemaps::TileData::set_flags(TileData *this, TileFlags__Enum value, MethodInfo *method)
				// {
				//   this.m_Flags = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00002BC0 File Offset: 0x00000DC0
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected HGRenderPathInternal renderPath
		{
			[CompilerGenerated]
			protected get
			{
				// // Int32 get_optionIndex()
				// int32_t UnityEngine::Timeline::RuntimeClip::get_optionIndex(RuntimeClip *this, MethodInfo *method)
				// {
				//   return this.fields._optionIndex_k__BackingField;
				// }
				// 
				return (HGRenderPathInternal)HGRenderPathInternal.Forward;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_colliderType(Tile+ColliderType)
				// void UnityEngine::Tilemaps::TileData::set_colliderType(
				//         TileData *this,
				//         Tile_ColliderType__Enum value,
				//         MethodInfo *method)
				// {
				//   this.m_ColliderType = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00002BC0 File Offset: 0x00000DC0
		internal HGRenderPathInternal renderPathInternalEnum
		{
			get
			{
				// // Int32 get_optionIndex()
				// int32_t UnityEngine::Timeline::RuntimeClip::get_optionIndex(RuntimeClip *this, MethodInfo *method)
				// {
				//   return this.fields._optionIndex_k__BackingField;
				// }
				// 
				return (HGRenderPathInternal)HGRenderPathInternal.Forward;
			}
		}

		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000025D2 File Offset: 0x000007D2
		protected ref BasicTransformConstants basicTransformConstants
		{
			get
			{
				// // BasicTransformConstants& get_basicTransformConstants()
				// BasicTransformConstants *HG::Rendering::Runtime::HGRenderPathBase::get_basicTransformConstants(
				//         HGRenderPathBase *this,
				//         MethodInfo *method)
				// {
				//   return &this.fields.m_basicTransformConstants;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000025D2 File Offset: 0x000007D2
		protected ref ShaderVariablesGlobal shaderVariablesGlobal
		{
			get
			{
				// // ShaderVariablesGlobal& get_shaderVariablesGlobal()
				// ShaderVariablesGlobal *HG::Rendering::Runtime::HGRenderPathBase::get_shaderVariablesGlobal(
				//         HGRenderPathBase *this,
				//         MethodInfo *method)
				// {
				//   return &this.fields.m_shaderVariablesGlobal;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600126E RID: 4718 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x000025D0 File Offset: 0x000007D0
		private protected HGCamera camera
		{
			[CompilerGenerated]
			protected get
			{
				// // HGCamera get_camera()
				// HGCamera *HG::Rendering::Runtime::HGRenderPathBase::get_camera(HGRenderPathBase *this, MethodInfo *method)
				// {
				//   return *(HGCamera **)&this[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_camera(HGCamera)
				// void HG::Rendering::Runtime::HGRenderPathBase::set_camera(HGRenderPathBase *this, HGCamera *value, MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   *(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23,
				//     (OneofDescriptorProto *)value,
				//     (FileDescriptor *)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}
		}

		internal HGRenderPathBase(HGRenderPathBase.HGRenderPathResources resources, PassConstructorID[] passConstructorIDs, HGCamera camera, HGRenderPathInternal renderPath)
		{
			// // HGRenderPathBase(HGRenderPathBase+HGRenderPathResources, PassConstructorID[], HGCamera, HGRenderPathInternal)
			// void HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         PassConstructorID__Enum__Array *passConstructorIDs,
			//         HGCamera *camera,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineMaterialCollector *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGRenderPipelineMaterialCollector *v13; // rbx
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   __int64 v17; // r8
			//   __int64 v18; // r9
			//   Int32__Array *v19; // rdi
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v20; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v21; // rbx
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   OneofDescriptorProto *v25; // rdx
			//   __int64 v26; // rcx
			//   FileDescriptor *v27; // r8
			//   MessageDescriptor *v28; // r9
			//   int v29; // r15d
			//   int32_t v30; // ebx
			//   __int64 v31; // rdi
			//   HGRenderPipelineMaterialCollector *v32; // rcx
			//   List_1_System_Object_ *v33; // r14
			//   Object *v34; // rax
			//   HGRenderPathBase__StaticFields *static_fields; // rax
			//   int32_t v36; // r8d
			//   NativeArray_1_System_Int32_ v37; // [rsp+20h] [rbp-38h] BYREF
			//   MethodInfo *v38; // [rsp+30h] [rbp-28h]
			// 
			//   if ( !byte_18D8EDB08 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Fill<int>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathBase);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     byte_18D8EDB08 = 1;
			//   }
			//   v10 = (HGRenderPipelineMaterialCollector *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//   v13 = v10;
			//   if ( !v10
			//     || (HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::HGRenderPipelineMaterialCollector(v10, 0LL),
			//         *(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 = v13,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21,
			//           v14,
			//           v15,
			//           v16,
			//           (String__Array *)v37.m_Buffer,
			//           *(String **)&v37.m_Length,
			//           v38),
			//         v19 = (Int32__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 60LL, v17, v18),
			//         System::Array::Fill<int>(v19, -1, MethodInfo::System::Array::Fill<int>),
			//         !passConstructorIDs)
			//     || (v20 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>),
			//         (v21 = v20) == 0LL) )
			//   {
			// LABEL_14:
			//     sub_180B536AC(v12, v11);
			//   }
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v20,
			//     passConstructorIDs.max_length.size,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::List);
			//   *(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix,
			//     v22,
			//     v23,
			//     v24,
			//     (String__Array *)v37.m_Buffer,
			//     *(String **)&v37.m_Length,
			//     v38);
			//   v37 = 0LL;
			//   Unity::Collections::NativeArray<int>::NativeArray(
			//     &v37,
			//     v19,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//   v29 = 0;
			//   v30 = 0;
			//   *(NativeArray_1_System_Int32_ *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = v37;
			//   while ( v30 < passConstructorIDs.max_length.size )
			//   {
			//     if ( (unsigned int)v30 >= passConstructorIDs.max_length.size )
			//       sub_180070270(v26, v25);
			//     v31 = (int)passConstructorIDs.vector[v30];
			//     if ( *(_DWORD *)(*(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 + 4 * v31) == -1 )
			//     {
			//       v32 = *(HGRenderPipelineMaterialCollector **)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21;
			//       v33 = *(List_1_System_Object_ **)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//       v37 = (NativeArray_1_System_Int32_)*resources;
			//       v34 = (Object *)HG::Rendering::Runtime::PassConstructorFactory::Create(
			//                         v32,
			//                         (PassConstructorID__Enum)v31,
			//                         (HGRenderPathBase_HGRenderPathResources *)&v37,
			//                         0LL);
			//       if ( !v33 )
			//         goto LABEL_14;
			//       sub_1822AD140(v33, v34);
			//       *(_DWORD *)(*(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 + 4 * v31) = v29++;
			//     }
			//     ++v30;
			//   }
			//   *(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = camera;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23,
			//     v25,
			//     v27,
			//     v28,
			//     (String__Array *)v37.m_Buffer,
			//     *(String **)&v37.m_Length,
			//     v38);
			//   this.fields._renderPath_k__BackingField = renderPath;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderPathBase.static_fields;
			//   v36 = static_fields.s_createdCount++;
			//   this.fields._renderPathID_k__BackingField = v36;
			// }
			// 
		}

		private unsafe void HG.Rendering.RenderGraphModule.IRenderGraphCallbackOwner.OnRenderPassExecution(HGRenderGraph renderGraph, DynamicArray<AttachDesc> colorAttachments, object targetCamera, void* customPayload, bool renderPassIssued)
		{
			// // Void HG.Rendering.RenderGraphModule.IRenderGraphCallbackOwner.OnRenderPassExecution(HGRenderGraph, DynamicArray`1[HG.Rendering.RenderGraphModule.AttachDesc], Object, Void*, Boolean)
			// void HG::Rendering::Runtime::HGRenderPathBase::HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_OnRenderPassExecution(
			//         HGRenderPathBase *this,
			//         HGRenderGraph *renderGraph,
			//         DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *colorAttachments,
			//         Object *targetCamera,
			//         Void *customPayload,
			//         bool renderPassIssued,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v9; // r14
			//   HGRenderPathBase *v10; // rsi
			//   int v11; // ebx
			//   bool v12; // r12
			//   int32_t v13; // edi
			//   AttachDesc *Item; // rbx
			//   AttachDesc *v15; // rax
			//   __int64 v16; // rax
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   __int64 v19; // r15
			//   HGRenderGraphContext *m_RenderGraphContext; // rdi
			//   Matrix4x4 *v21; // rbx
			//   __int128 v22; // xmm1
			//   __m128i v23; // xmm2
			//   __int128 v24; // xmm0
			//   CBHandle *v25; // rax
			//   __int64 v26; // r14
			//   _OWORD *v27; // rcx
			//   __int64 v28; // rdx
			//   __int128 v29; // xmm0
			//   void *ptr; // xmm1_8
			//   _OWORD *p_m00; // rax
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   CommandBuffer *cmd; // r13
			//   CBHandle *v44; // rax
			//   _OWORD *v45; // rcx
			//   __int128 v46; // xmm0
			//   void *v47; // xmm1_8
			//   _OWORD *v48; // rax
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   uint32_t v60; // xmm7_4
			//   int v61; // xmm8_4
			//   unsigned __int32 v62; // eax
			//   float preTransform; // xmm9_4
			//   __int128 v64; // xmm6
			//   CommandBuffer *v65; // rbx
			//   __int64 v66; // rax
			//   Exception *v67; // rbx
			//   String *v68; // rax
			//   __int64 v69; // rax
			//   String__Array *size; // [rsp+20h] [rbp-E0h]
			//   String *v71; // [rsp+28h] [rbp-D8h]
			//   CBHandle v72; // [rsp+30h] [rbp-D0h] BYREF
			//   CBHandle offset_8; // [rsp+50h] [rbp-B0h] BYREF
			//   _BYTE v74[68]; // [rsp+70h] [rbp-90h] BYREF
			//   Nullable_1_UnityEngine_Matrix4x4_ pretransformMatrix; // [rsp+C0h] [rbp-40h] BYREF
			//   _BYTE v76[3784]; // [rsp+110h] [rbp+10h] BYREF
			// 
			//   v9 = renderGraph;
			//   v10 = this;
			//   v11 = 1;
			//   if ( !byte_18D919640 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Display);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_size);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::HGPassConstructorPayload>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::HGRenderPathConstants>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Matrix4x4>::Nullable);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919640 = 1;
			//   }
			//   if ( renderPassIssued )
			//   {
			//     v12 = 0;
			//     v13 = 0;
			//     if ( !colorAttachments )
			//       goto LABEL_44;
			//     while ( v13 < colorAttachments.fields._size_k__BackingField )
			//     {
			//       Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item(
			//                colorAttachments,
			//                v13,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&Item.textureHandle, 0LL) )
			//       {
			//         v15 = UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item(
			//                 colorAttachments,
			//                 v13,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
			//         if ( !v9 )
			//           goto LABEL_44;
			//         *(TextureHandle *)&v72.bufferId = v15.textureHandle;
			//         v12 = (v12 | HG::Rendering::RenderGraphModule::HGRenderGraph::IsBackBuffer(v9, (TextureHandle *)&v72, 0LL)) != 0;
			//       }
			//       v11 = 1;
			//       ++v13;
			//     }
			//     if ( !targetCamera )
			//       targetCamera = *(Object **)&v10[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//     v16 = sub_18003F5A0(targetCamera, TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     v19 = v16;
			//     if ( !v16 )
			//     {
			//       v66 = sub_18000F7E0(&TypeInfo::System::Exception);
			//       v67 = (Exception *)sub_180004920(v66);
			//       if ( v67 )
			//       {
			//         v68 = (String *)sub_18000F7E0(&off_18D50A200);
			//         System::Exception::Exception(v67, v68, 0LL);
			//         v69 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::HGRenderPathBase::HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_OnRenderPassExecution);
			//         sub_18000F7C0(v67, v69);
			//       }
			//       goto LABEL_44;
			//     }
			//     if ( !v9 )
			//       goto LABEL_44;
			//     m_RenderGraphContext = v9.fields.m_RenderGraphContext;
			//     if ( (HGCamera *)v16 != v10.fields.m_trackingCamera || v10.fields.m_trackingBackBufferState != v12 )
			//     {
			//       v10.fields.m_trackingCamera = (HGCamera *)v16;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&v10.fields.m_trackingCamera,
			//         (OneofDescriptorProto *)renderGraph,
			//         v17,
			//         v18,
			//         size,
			//         v71,
			//         *(MethodInfo **)&v72.bufferId);
			//       v10.fields.m_trackingBackBufferState = v12;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v21 = HG::Rendering::Runtime::HGUtils::GetPreTransformMatrix((Matrix4x4 *)&pretransformMatrix, v12, 0LL);
			//       sub_1802F01E0(v74, 0LL, 68LL);
			//       v22 = *(_OWORD *)&v21.m01;
			//       v23 = *(__m128i *)&v21.m03;
			//       *(_OWORD *)&v74[4] = *(_OWORD *)&v21.m00;
			//       v24 = *(_OWORD *)&v21.m02;
			//       v11 = 1;
			//       *(_OWORD *)&v74[20] = v22;
			//       v74[0] = 1;
			//       *(_OWORD *)&v74[36] = v24;
			//       *(__m128i *)&v74[52] = v23;
			//       *(_OWORD *)&pretransformMatrix.hasValue = *(_OWORD *)v74;
			//       *(_OWORD *)&pretransformMatrix.value.m30 = *(_OWORD *)&v74[16];
			//       *(_OWORD *)&pretransformMatrix.value.m31 = *(_OWORD *)&v74[32];
			//       *(_OWORD *)&pretransformMatrix.value.m32 = *(_OWORD *)&v74[48];
			//       LODWORD(pretransformMatrix.value.m33) = _mm_cvtsi128_si32(_mm_srli_si128(v23, 12));
			//       HG::Rendering::Runtime::HGCamera::PrepareBasicCameraTransforms(
			//         (HGCamera *)v19,
			//         &v10.fields.m_basicTransformConstants,
			//         &pretransformMatrix,
			//         0LL);
			//       if ( !m_RenderGraphContext )
			//         goto LABEL_44;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v25 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//               &v72,
			//               &m_RenderGraphContext.fields.renderContext,
			//               720,
			//               0LL);
			//       v26 = 5LL;
			//       v27 = v76;
			//       v28 = 5LL;
			//       v29 = *(_OWORD *)&v25.bufferId;
			//       ptr = v25.ptr;
			//       p_m00 = (_OWORD *)&v10.fields.m_basicTransformConstants._ViewMatrix.m00;
			//       *(_OWORD *)&offset_8.bufferId = v29;
			//       offset_8.ptr = ptr;
			//       do
			//       {
			//         v32 = p_m00[1];
			//         *v27 = *p_m00;
			//         v33 = p_m00[2];
			//         v27[1] = v32;
			//         v34 = p_m00[3];
			//         v27[2] = v33;
			//         v35 = p_m00[4];
			//         v27[3] = v34;
			//         v36 = p_m00[5];
			//         v27[4] = v35;
			//         v37 = p_m00[6];
			//         v27[5] = v36;
			//         v38 = p_m00[7];
			//         p_m00 += 8;
			//         v27[6] = v37;
			//         v27 += 8;
			//         *(v27 - 1) = v38;
			//         --v28;
			//       }
			//       while ( v28 );
			//       v39 = p_m00[1];
			//       *v27 = *p_m00;
			//       v40 = p_m00[2];
			//       v27[1] = v39;
			//       v41 = p_m00[3];
			//       v27[2] = v40;
			//       v42 = p_m00[4];
			//       v27[3] = v41;
			//       v27[4] = v42;
			//       sub_1808307F0(&offset_8, v76);
			//       cmd = m_RenderGraphContext.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !cmd )
			//         goto LABEL_44;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//         cmd,
			//         offset_8.bufferId,
			//         HIDWORD(renderGraph[3].fields.m_RendererLists),
			//         offset_8.offset,
			//         720,
			//         0LL);
			//       *(__m128i *)&v10.fields.m_shaderVariablesGlobal._GraphicsFeaturesGlobalParam0.z = _mm_loadu_si128((const __m128i *)(v19 + 104));
			//       v44 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//               &offset_8,
			//               &m_RenderGraphContext.fields.renderContext,
			//               4512,
			//               0LL);
			//       v45 = v76;
			//       v46 = *(_OWORD *)&v44.bufferId;
			//       v47 = v44.ptr;
			//       v48 = (_OWORD *)&v10.fields.m_basicTransformConstants._ViewMatrix.m00;
			//       *(_OWORD *)&v72.bufferId = v46;
			//       v72.ptr = v47;
			//       do
			//       {
			//         v49 = v48[1];
			//         *v45 = *v48;
			//         v50 = v48[2];
			//         v45[1] = v49;
			//         v51 = v48[3];
			//         v45[2] = v50;
			//         v52 = v48[4];
			//         v45[3] = v51;
			//         v53 = v48[5];
			//         v45[4] = v52;
			//         v54 = v48[6];
			//         v45[5] = v53;
			//         v55 = v48[7];
			//         v48 += 8;
			//         v45[6] = v54;
			//         v45 += 8;
			//         *(v45 - 1) = v55;
			//         --v26;
			//       }
			//       while ( v26 );
			//       v56 = v48[1];
			//       *v45 = *v48;
			//       v57 = v48[2];
			//       v45[1] = v56;
			//       v58 = v48[3];
			//       v45[2] = v57;
			//       v59 = v48[4];
			//       v45[3] = v58;
			//       v45[4] = v59;
			//       sub_1808307F0(&v72, v76);
			//       sub_1802EFB40(v76, &v10.fields.m_shaderVariablesGlobal, 3792LL);
			//       sub_180830890(&v72, v76);
			//       this = (HGRenderPathBase *)m_RenderGraphContext.fields.cmd;
			//       renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !this )
			//         goto LABEL_44;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//         (CommandBuffer *)this,
			//         v72.bufferId,
			//         (int32_t)renderGraph[3].fields.m_RendererLists,
			//         v72.offset,
			//         4512,
			//         0LL);
			//     }
			//     if ( !v12
			//       || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES2
			//       || UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_OpenGLES3 )
			//     {
			//       v61 = 0;
			//       v60 = 0;
			//     }
			//     else
			//     {
			//       v60 = 0;
			//       v61 = 0;
			//       if ( UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_OpenGLCore )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Display);
			//         v62 = UnityEngine::Display::get_preTransform(0LL) - 1;
			//         if ( !v62 || v62 == 2 )
			//           v60 = 1065353216;
			//         else
			//           v61 = 1065353216;
			//         sub_180002C70(TypeInfo::UnityEngine::Display);
			//         preTransform = (float)(int)UnityEngine::Display::get_preTransform(0LL);
			// LABEL_35:
			//         if ( m_RenderGraphContext )
			//         {
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           offset_8 = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                         &v72,
			//                         &m_RenderGraphContext.fields.renderContext,
			//                         32,
			//                         0LL);
			//           if ( customPayload )
			//           {
			//             if ( *(float *)&customPayload[4] != 0.0 )
			//               v11 = 0;
			//             v72.offset = v60;
			//             *(float *)&v72.bufferId = (float)v11;
			//             *(_QWORD *)&v72.size = __PAIR64__(LODWORD(preTransform), v61);
			//             v64 = *(_OWORD *)&v72.bufferId;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//             *(_OWORD *)&v72.bufferId = v64;
			//             sub_18031977C(&offset_8, &v72);
			//             *(_OWORD *)&v72.bufferId = *(_OWORD *)customPayload;
			//             sub_180319754(&offset_8, &v72);
			//             v65 = m_RenderGraphContext.fields.cmd;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             renderGraph = (HGRenderGraph *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( v65 )
			//             {
			//               UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//                 v65,
			//                 offset_8.bufferId,
			//                 (int32_t)renderGraph[3].fields.m_RenderPasses,
			//                 offset_8.offset,
			//                 32,
			//                 0LL);
			//               return;
			//             }
			//           }
			//         }
			// LABEL_44:
			//         sub_180B536AC(this, renderGraph);
			//       }
			//     }
			//     preTransform = 0.0;
			//     goto LABEL_35;
			//   }
			// }
			// 
		}

		protected virtual bool SkipRender(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Boolean SkipRender(HGRenderPathBase+HGRenderPathParams ByRef)
			// bool HG::Rendering::Runtime::HGRenderPathBase::SkipRender(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(1055, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1055, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(Patch, (Object *)this, renderPathParams, 0LL);
			//   }
			//   else
			//   {
			//     renderPathParams.skipRender = 0;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		protected virtual PassConstructorID GetDefaultFirstBackbufferPass()
		{
			// // PassConstructorID GetDefaultFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathBase::GetDefaultFirstBackbufferPass(
			//         HGRenderPathBase *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2957, 0LL) )
			//     return 52;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2957, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		protected virtual PassConstructorID FindFirstBackbufferPass()
		{
			// // PassConstructorID FindFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathBase::FindFirstBackbufferPass(
			//         HGRenderPathBase *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1067, 0LL) )
			//     return 52;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1067, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		protected virtual void UpdateShaderVariablesGlobal(HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd, ref ShaderVariablesGlobal shaderVariablesGlobal, ref ScriptableRenderContext context)
		{
			// // Void UpdateShaderVariablesGlobal(HGRenderPipeline, HGCamera, CommandBuffer, ShaderVariablesGlobal ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobal(
			//         HGRenderPathBase *this,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1060, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalVFX(this, shaderVariablesGlobal, camera, 0LL);
			//     if ( hgrp )
			//     {
			//       HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalWater(
			//         this,
			//         shaderVariablesGlobal,
			//         hgrp.fields._settingParameters_k__BackingField,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(Patch, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1060, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_384(
			//     Patch,
			//     (Object *)this,
			//     (Object *)hgrp,
			//     (Object *)camera,
			//     (Object *)cmd,
			//     shaderVariablesGlobal,
			//     context,
			//     0LL);
			// }
			// 
		}

		[IDTag(0)]
		protected virtual void OnPreRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1073, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1073, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			//   }
			// }
			// 
		}

		protected abstract void RenderInternal(ref HGRenderPathBase.HGRenderPathParams renderPathParams);

		[IDTag(0)]
		protected virtual void OnPostRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef)
			// void HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1079, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1079, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)this, renderPathParams, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateShaderVariablesIrradianceVolume(ref HGIrradianceVolumePipelineUpdateResult result, int curFrameIdx, HGCamera camera, CommandBuffer cmd)
		{
			// // Void UpdateShaderVariablesIrradianceVolume(HGIrradianceVolumePipelineUpdateResult ByRef, Int32, HGCamera, CommandBuffer)
			// void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolume(
			//         HGRenderPathBase *this,
			//         HGIrradianceVolumePipelineUpdateResult *result,
			//         int32_t curFrameIdx,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   int32_t IrradianceVolumeIndirectTexture; // ebx
			//   RenderTargetIdentifier *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Vector4 v14; // xmm1
			//   int32_t IrradianceVolumeAtlas0; // ebx
			//   RenderTargetIdentifier *v16; // rax
			//   Vector4 v17; // xmm1
			//   int32_t IrradianceVolumeAtlas1; // ebx
			//   RenderTargetIdentifier *v19; // rax
			//   Vector4 v20; // xmm1
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // r8
			//   HGSkyConfig *p_skyConfig; // rcx
			//   HGSkyConfig *v26; // rax
			//   char *v27; // rdx
			//   __int64 v28; // r9
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int64 v36; // r9
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int64 v41; // rax
			//   HGSkyConfig *v42; // rax
			//   _OWORD *v43; // rdx
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int64 v55; // rax
			//   _OWORD *v56; // rdx
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int64 v64; // rax
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm0
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm0
			//   float v70; // eax
			//   __int128 v71; // xmm1
			//   __int128 v72; // xmm2
			//   __int128 v73; // xmm3
			//   __int128 v74; // xmm4
			//   __int128 v75; // xmm5
			//   __int64 v76; // xmm6_8
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   __int128 v80; // xmm0
			//   __int128 v81; // xmm1
			//   __int128 v82; // xmm0
			//   __int128 v83; // xmm1
			//   __int64 v84; // rax
			//   __int128 v85; // xmm1
			//   __int128 v86; // xmm0
			//   __int128 v87; // xmm1
			//   __int128 v88; // xmm0
			//   SHCoefficientsL1 *CoefficientsL1; // rax
			//   Vector4 shAg; // xmm6
			//   Vector4 shAb; // xmm7
			//   MethodInfo *v92; // r9
			//   Vector4 *v93; // rax
			//   MethodInfo *v94; // r9
			//   float v95; // xmm5_4
			//   Vector4 *v96; // rax
			//   MethodInfo *v97; // r9
			//   float v98; // xmm5_4
			//   __int64 v99; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Vector4 shAr; // [rsp+48h] [rbp-C0h] BYREF
			//   SHCoefficientsL1 v102; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector4 v103; // [rsp+88h] [rbp-80h] BYREF
			//   RenderTargetIdentifier v104; // [rsp+98h] [rbp-70h] BYREF
			//   SphericalHarmonicsL2 v105; // [rsp+C8h] [rbp-40h] BYREF
			//   _BYTE v106[24]; // [rsp+138h] [rbp+30h] BYREF
			//   __int128 v107; // [rsp+150h] [rbp+48h]
			//   __int128 v108; // [rsp+160h] [rbp+58h]
			//   __int128 v109; // [rsp+170h] [rbp+68h]
			//   __int128 v110; // [rsp+180h] [rbp+78h]
			//   __int128 v111; // [rsp+190h] [rbp+88h]
			//   __int128 v112; // [rsp+1A0h] [rbp+98h]
			//   __int64 v113; // [rsp+1B0h] [rbp+A8h]
			//   float v114; // [rsp+1B8h] [rbp+B0h]
			//   __int128 v115; // [rsp+214h] [rbp+10Ch]
			//   __int128 v116; // [rsp+224h] [rbp+11Ch]
			//   __int128 v117; // [rsp+234h] [rbp+12Ch]
			//   __int128 v118; // [rsp+244h] [rbp+13Ch]
			//   __int128 v119; // [rsp+254h] [rbp+14Ch]
			//   __int128 v120; // [rsp+264h] [rbp+15Ch]
			//   __int64 v121; // [rsp+274h] [rbp+16Ch]
			//   float v122; // [rsp+27Ch] [rbp+174h]
			//   char v123; // [rsp+298h] [rbp+190h] BYREF
			//   float v124; // [rsp+2A8h] [rbp+1A0h]
			// 
			//   if ( !byte_18D919641 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919641 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1057, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1057, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v99);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_382(
			//       Patch,
			//       (Object *)this,
			//       result,
			//       curFrameIdx,
			//       (Object *)camera,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else
			//   {
			//     shAr.y = 0.0;
			//     *(_QWORD *)&shAr.z = 0LL;
			//     *(__m128i *)&this[1].fields._backBufferColor_k__BackingField.fallBackResource.m_Value = _mm_loadu_si128((const __m128i *)result);
			//     *(__m128i *)&this[1].fields._backBufferDepth_k__BackingField.fallBackResource.m_Value = _mm_loadu_si128((const __m128i *)&result.param1);
			//     shAr.x = (float)(curFrameIdx % 64);
			//     *(Vector4 *)&this[1].fields.m_trackingCamera = shAr;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     IrradianceVolumeIndirectTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeIndirectTexture;
			//     v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v104, result.indirectionTexture, 0LL);
			//     if ( !cmd )
			//       sub_180B536AC(v13, v12);
			//     v14 = *(Vector4 *)&v11.m_BufferPointer;
			//     v102.shAr = *(Vector4 *)&v11.m_Type;
			//     *(_QWORD *)&v102.shAb.x = *(_QWORD *)&v11.m_DepthSlice;
			//     v102.shAg = v14;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//       cmd,
			//       IrradianceVolumeIndirectTexture,
			//       (RenderTargetIdentifier *)&v102,
			//       0LL);
			//     IrradianceVolumeAtlas0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeAtlas0;
			//     v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v104, result.physicalTexture0, 0LL);
			//     v17 = *(Vector4 *)&v16.m_BufferPointer;
			//     v102.shAr = *(Vector4 *)&v16.m_Type;
			//     *(_QWORD *)&v102.shAb.x = *(_QWORD *)&v16.m_DepthSlice;
			//     v102.shAg = v17;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//       cmd,
			//       IrradianceVolumeAtlas0,
			//       (RenderTargetIdentifier *)&v102,
			//       0LL);
			//     IrradianceVolumeAtlas1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeAtlas1;
			//     v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v104, result.physicalTexture1, 0LL);
			//     v20 = *(Vector4 *)&v19.m_BufferPointer;
			//     v102.shAr = *(Vector4 *)&v19.m_Type;
			//     *(_QWORD *)&v102.shAb.x = *(_QWORD *)&v19.m_DepthSlice;
			//     v102.shAg = v20;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//       cmd,
			//       IrradianceVolumeAtlas1,
			//       (RenderTargetIdentifier *)&v102,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
			//     if ( !InterpolatedPhase )
			//       sub_180B536AC(v23, v22);
			//     v24 = 2LL;
			//     p_skyConfig = &InterpolatedPhase.fields.skyConfig;
			//     v26 = &InterpolatedPhase.fields.skyConfig;
			//     v27 = &v123;
			//     v28 = 2LL;
			//     do
			//     {
			//       v29 = *(_OWORD *)&v26.skyDirectIntensity;
			//       *(_OWORD *)v27 = *(_OWORD *)&v26.parentEnvPhaseGuid;
			//       v30 = *(_OWORD *)&v26.customIVDefaultSH.shr2;
			//       *((_OWORD *)v27 + 1) = v29;
			//       v31 = *(_OWORD *)&v26.customIVDefaultSH.shr6;
			//       *((_OWORD *)v27 + 2) = v30;
			//       v32 = *(_OWORD *)&v26.customIVDefaultSH.shg1;
			//       *((_OWORD *)v27 + 3) = v31;
			//       v33 = *(_OWORD *)&v26.customIVDefaultSH.shg5;
			//       *((_OWORD *)v27 + 4) = v32;
			//       v34 = *(_OWORD *)&v26.customIVDefaultSH.shb0;
			//       *((_OWORD *)v27 + 5) = v33;
			//       v35 = *(_OWORD *)&v26.customIVDefaultSH.shb4;
			//       v26 = (HGSkyConfig *)((char *)v26 + 128);
			//       *((_OWORD *)v27 + 6) = v34;
			//       v27 += 128;
			//       *((_OWORD *)v27 - 1) = v35;
			//       --v28;
			//     }
			//     while ( v28 );
			//     v36 = 2LL;
			//     v37 = *(_OWORD *)&v26.skyDirectIntensity;
			//     *(_OWORD *)v27 = *(_OWORD *)&v26.parentEnvPhaseGuid;
			//     v38 = *(_OWORD *)&v26.customIVDefaultSH.shr2;
			//     *((_OWORD *)v27 + 1) = v37;
			//     v39 = *(_OWORD *)&v26.customIVDefaultSH.shr6;
			//     *((_OWORD *)v27 + 2) = v38;
			//     v40 = *(_OWORD *)&v26.customIVDefaultSH.shg1;
			//     v41 = *(_QWORD *)&v26.customIVDefaultSH.shg5;
			//     *((_OWORD *)v27 + 3) = v39;
			//     *((_OWORD *)v27 + 4) = v40;
			//     *((_QWORD *)v27 + 10) = v41;
			//     v42 = p_skyConfig;
			//     v43 = v106;
			//     do
			//     {
			//       v44 = *(_OWORD *)&v42.skyDirectIntensity;
			//       *v43 = *(_OWORD *)&v42.parentEnvPhaseGuid;
			//       v45 = *(_OWORD *)&v42.customIVDefaultSH.shr2;
			//       v43[1] = v44;
			//       v46 = *(_OWORD *)&v42.customIVDefaultSH.shr6;
			//       v43[2] = v45;
			//       v47 = *(_OWORD *)&v42.customIVDefaultSH.shg1;
			//       v43[3] = v46;
			//       v48 = *(_OWORD *)&v42.customIVDefaultSH.shg5;
			//       v43[4] = v47;
			//       v49 = *(_OWORD *)&v42.customIVDefaultSH.shb0;
			//       v43[5] = v48;
			//       v50 = *(_OWORD *)&v42.customIVDefaultSH.shb4;
			//       v42 = (HGSkyConfig *)((char *)v42 + 128);
			//       v43[6] = v49;
			//       v43 += 8;
			//       *(v43 - 1) = v50;
			//       --v36;
			//     }
			//     while ( v36 );
			//     v51 = *(_OWORD *)&v42.skyDirectIntensity;
			//     *v43 = *(_OWORD *)&v42.parentEnvPhaseGuid;
			//     v52 = *(_OWORD *)&v42.customIVDefaultSH.shr2;
			//     v43[1] = v51;
			//     v53 = *(_OWORD *)&v42.customIVDefaultSH.shr6;
			//     v43[2] = v52;
			//     v54 = *(_OWORD *)&v42.customIVDefaultSH.shg1;
			//     v55 = *(_QWORD *)&v42.customIVDefaultSH.shg5;
			//     v43[3] = v53;
			//     v43[4] = v54;
			//     *((_QWORD *)v43 + 10) = v55;
			//     v56 = v106;
			//     if ( v106[20] )
			//     {
			//       do
			//       {
			//         v57 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//         *v56 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//         v58 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//         v56[1] = v57;
			//         v59 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//         v56[2] = v58;
			//         v60 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//         v56[3] = v59;
			//         v61 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//         v56[4] = v60;
			//         v62 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb0;
			//         v56[5] = v61;
			//         v63 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb4;
			//         p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//         v56[6] = v62;
			//         v56 += 8;
			//         *(v56 - 1) = v63;
			//         --v24;
			//       }
			//       while ( v24 );
			//       v64 = *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//       v65 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//       *v56 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//       v66 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//       v56[1] = v65;
			//       v67 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//       v56[2] = v66;
			//       v68 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//       v56[3] = v67;
			//       v56[4] = v68;
			//       *((_QWORD *)v56 + 10) = v64;
			//       v69 = v107;
			//       v70 = v114;
			//       v71 = v108;
			//       v72 = v109;
			//       v73 = v110;
			//       v74 = v111;
			//       v75 = v112;
			//       v76 = v113;
			//     }
			//     else
			//     {
			//       do
			//       {
			//         v77 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//         *v56 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//         v78 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//         v56[1] = v77;
			//         v79 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//         v56[2] = v78;
			//         v80 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//         v56[3] = v79;
			//         v81 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//         v56[4] = v80;
			//         v82 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb0;
			//         v56[5] = v81;
			//         v83 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shb4;
			//         p_skyConfig = (HGSkyConfig *)((char *)p_skyConfig + 128);
			//         v56[6] = v82;
			//         v56 += 8;
			//         *(v56 - 1) = v83;
			//         --v24;
			//       }
			//       while ( v24 );
			//       v84 = *(_QWORD *)&p_skyConfig.customIVDefaultSH.shg5;
			//       v85 = *(_OWORD *)&p_skyConfig.skyDirectIntensity;
			//       *v56 = *(_OWORD *)&p_skyConfig.parentEnvPhaseGuid;
			//       v86 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr2;
			//       v56[1] = v85;
			//       v87 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shr6;
			//       v56[2] = v86;
			//       v88 = *(_OWORD *)&p_skyConfig.customIVDefaultSH.shg1;
			//       v56[3] = v87;
			//       v56[4] = v88;
			//       *((_QWORD *)v56 + 10) = v84;
			//       v69 = v115;
			//       v70 = v122;
			//       v71 = v116;
			//       v72 = v117;
			//       v73 = v118;
			//       v74 = v119;
			//       v75 = v120;
			//       v76 = v121;
			//     }
			//     *(_OWORD *)&v105.shr0 = v69;
			//     *(_OWORD *)&v105.shr4 = v71;
			//     *(_OWORD *)&v105.shr8 = v72;
			//     *(_OWORD *)&v105.shg3 = v73;
			//     *(_OWORD *)&v105.shg7 = v74;
			//     *(_OWORD *)&v105.shb2 = v75;
			//     *(_QWORD *)&v105.shb6 = v76;
			//     v105.shb8 = v70;
			//     CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(&v102, &v105, 0LL);
			//     shAg = CoefficientsL1.shAg;
			//     shAb = CoefficientsL1.shAb;
			//     shAr = CoefficientsL1.shAr;
			//     v93 = UnityEngine::Vector4::op_Multiply(&v103, &shAr, v124, v92);
			//     shAr = shAg;
			//     *(__m128i *)&this[1].fields._renderPathFrameIndex_k__BackingField = _mm_loadu_si128((const __m128i *)v93);
			//     v96 = UnityEngine::Vector4::op_Multiply(&v103, &shAr, v95, v94);
			//     shAr = shAb;
			//     *(__m128i *)&this[1].fields.m_basicTransformConstants._ViewMatrix.m20 = _mm_loadu_si128((const __m128i *)v96);
			//     *(__m128i *)&this[1].fields.m_basicTransformConstants._ViewMatrix.m21 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(&v103, &shAr, v98, v97));
			//   }
			// }
			// 
		}

		private void UpdateShaderVariablesIrradianceVolumeV2(ref HGIrradianceVolumePipelineUpdateResultV2 result, int curFrameIdx, HGCamera camera, CommandBuffer cmd)
		{
			// // Void UpdateShaderVariablesIrradianceVolumeV2(HGIrradianceVolumePipelineUpdateResultV2 ByRef, Int32, HGCamera, CommandBuffer)
			// void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolumeV2(
			//         HGRenderPathBase *this,
			//         HGIrradianceVolumePipelineUpdateResultV2 *result,
			//         int32_t curFrameIdx,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   int32_t IrradianceVolumeClipmapTextureALod0; // ebx
			//   RenderTargetIdentifier *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int128 v14; // xmm1
			//   int32_t IrradianceVolumeClipmapTextureBLod0; // ebx
			//   RenderTargetIdentifier *v16; // rax
			//   __int128 v17; // xmm1
			//   int32_t IrradianceVolumeClipmapTextureALod1; // ebx
			//   RenderTargetIdentifier *v19; // rax
			//   __int128 v20; // xmm1
			//   int32_t IrradianceVolumeClipmapTextureBLod1; // ebx
			//   RenderTargetIdentifier *v22; // rax
			//   __int128 v23; // xmm1
			//   int32_t IrradianceVolumeClipmapTextureALod3; // ebx
			//   RenderTargetIdentifier *v25; // rax
			//   __int128 v26; // xmm1
			//   int32_t IrradianceVolumeClipmapTextureBLod3; // ebx
			//   RenderTargetIdentifier *v28; // rax
			//   __int128 v29; // xmm1
			//   __int64 v30; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v32; // [rsp+48h] [rbp-29h]
			//   RenderTargetIdentifier v33; // [rsp+58h] [rbp-19h] BYREF
			//   RenderTargetIdentifier v34; // [rsp+88h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919642 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919642 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1058, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1058, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v30);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(
			//       Patch,
			//       (Object *)this,
			//       result,
			//       curFrameIdx,
			//       (Object *)camera,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else
			//   {
			//     HIDWORD(v32) = 0;
			//     *(__m128i *)&this[1].fields.m_basicTransformConstants._ViewMatrix.m22 = _mm_loadu_si128((const __m128i *)result);
			//     *(__m128i *)&this[1].fields.m_basicTransformConstants._ViewMatrix.m23 = _mm_loadu_si128((const __m128i *)&result.param1);
			//     *(__m128i *)&this[1].fields.m_basicTransformConstants._InvViewMatrix.m20 = _mm_loadu_si128((const __m128i *)&result.param2);
			//     *(_QWORD *)&v32 = *(_QWORD *)&result.param3.x;
			//     *((float *)&v32 + 2) = (float)(curFrameIdx % 64);
			//     *(_OWORD *)&this[1].fields.m_basicTransformConstants._InvViewMatrix.m21 = v32;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     IrradianceVolumeClipmapTextureALod0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeClipmapTextureALod0;
			//     v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result.clipmapTextureALod0, 0LL);
			//     if ( !cmd )
			//       sub_180B536AC(v13, v12);
			//     v14 = *(_OWORD *)&v11.m_BufferPointer;
			//     *(_OWORD *)&v33.m_Type = *(_OWORD *)&v11.m_Type;
			//     *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v11.m_DepthSlice;
			//     *(_OWORD *)&v33.m_BufferPointer = v14;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureALod0, &v33, 0LL);
			//     IrradianceVolumeClipmapTextureBLod0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeClipmapTextureBLod0;
			//     v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result.clipmapTextureBLod0, 0LL);
			//     v17 = *(_OWORD *)&v16.m_BufferPointer;
			//     *(_OWORD *)&v33.m_Type = *(_OWORD *)&v16.m_Type;
			//     *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v16.m_DepthSlice;
			//     *(_OWORD *)&v33.m_BufferPointer = v17;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureBLod0, &v33, 0LL);
			//     IrradianceVolumeClipmapTextureALod1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeClipmapTextureALod1;
			//     v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result.clipmapTextureALod1, 0LL);
			//     v20 = *(_OWORD *)&v19.m_BufferPointer;
			//     *(_OWORD *)&v33.m_Type = *(_OWORD *)&v19.m_Type;
			//     *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v19.m_DepthSlice;
			//     *(_OWORD *)&v33.m_BufferPointer = v20;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureALod1, &v33, 0LL);
			//     IrradianceVolumeClipmapTextureBLod1 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeClipmapTextureBLod1;
			//     v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result.clipmapTextureBLod1, 0LL);
			//     v23 = *(_OWORD *)&v22.m_BufferPointer;
			//     *(_OWORD *)&v33.m_Type = *(_OWORD *)&v22.m_Type;
			//     *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v22.m_DepthSlice;
			//     *(_OWORD *)&v33.m_BufferPointer = v23;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureBLod1, &v33, 0LL);
			//     IrradianceVolumeClipmapTextureALod3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeClipmapTextureALod3;
			//     v25 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result.clipmapTextureALod3, 0LL);
			//     v26 = *(_OWORD *)&v25.m_BufferPointer;
			//     *(_OWORD *)&v33.m_Type = *(_OWORD *)&v25.m_Type;
			//     *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v25.m_DepthSlice;
			//     *(_OWORD *)&v33.m_BufferPointer = v26;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureALod3, &v33, 0LL);
			//     IrradianceVolumeClipmapTextureBLod3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._IrradianceVolumeClipmapTextureBLod3;
			//     v28 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v34, result.clipmapTextureBLod3, 0LL);
			//     v29 = *(_OWORD *)&v28.m_BufferPointer;
			//     *(_OWORD *)&v33.m_Type = *(_OWORD *)&v28.m_Type;
			//     *(_QWORD *)&v33.m_DepthSlice = *(_QWORD *)&v28.m_DepthSlice;
			//     *(_OWORD *)&v33.m_BufferPointer = v29;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, IrradianceVolumeClipmapTextureBLod3, &v33, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalCB(HGRenderPipeline hgrp, HGCamera camera, CommandBuffer cmd, ScriptableRenderContext context)
		{
			// // Void UpdateShaderVariablesGlobalCB(HGRenderPipeline, HGCamera, CommandBuffer, ScriptableRenderContext)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalCB(
			//         HGRenderPathBase *this,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *camera,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext context,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r15
			//   HGRenderPathBase *v9; // rsi
			//   Matrix4x4 *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rcx
			//   List_1_System_Object_ *v14; // rdx
			//   ShaderVariablesGlobal *p_m_shaderVariablesGlobal; // rdx
			//   _OWORD *p_m00; // rax
			//   _OWORD *v17; // rcx
			//   __int64 v18; // rbx
			//   __int64 v19; // rdx
			//   ShaderVariablesGlobal *v20; // rax
			//   _OWORD *v21; // rcx
			//   __int64 v22; // rdx
			//   __int64 v23; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   _OWORD *v25; // rax
			//   ShaderVariablesGlobal *v26; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   char v30; // [rsp+40h] [rbp-12B8h] BYREF
			//   CBHandle bufferId; // [rsp+48h] [rbp-12B0h] BYREF
			//   List_1_T_Enumerator_System_Object_ v32; // [rsp+60h] [rbp-1298h] BYREF
			//   Il2CppException *ex; // [rsp+78h] [rbp-1280h]
			//   char *v34; // [rsp+80h] [rbp-1278h]
			//   Il2CppExceptionWrapper *v35; // [rsp+88h] [rbp-1270h] BYREF
			//   Il2CppExceptionWrapper *v36; // [rsp+90h] [rbp-1268h] BYREF
			//   CBHandle v37; // [rsp+98h] [rbp-1260h] BYREF
			//   Matrix4x4 v38; // [rsp+B0h] [rbp-1248h] BYREF
			//   _BYTE v39[64]; // [rsp+F0h] [rbp-1208h] BYREF
			//   _BYTE v40[720]; // [rsp+130h] [rbp-11C8h] BYREF
			//   ShaderVariablesGlobal v41; // [rsp+400h] [rbp-EF8h] BYREF
			// 
			//   v6 = (Object *)cmd;
			//   v9 = this;
			//   if ( !byte_18D919643 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919643 = 1;
			//   }
			//   v30 = 0;
			//   memset(&v32, 0, sizeof(v32));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1059, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1059, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v29, v28);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_385(
			//       Patch,
			//       (Object *)v9,
			//       (Object *)hgrp,
			//       (Object *)camera,
			//       v6,
			//       context,
			//       0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x6Bu,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     ex = 0LL;
			//     v34 = &v30;
			//     try
			//     {
			//       v10 = (Matrix4x4 *)sub_182805160(v39);
			//       if ( !camera )
			//         sub_1802DC2C8(v12, v11);
			//       v38 = *v10;
			//       HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
			//         camera,
			//         &v9.fields.m_shaderVariablesGlobal,
			//         &v9.fields.m_basicTransformConstants,
			//         &v38,
			//         0LL);
			//       sub_180003EE0(v9.klass);
			//       ((void (__fastcall *)(HGRenderPathBase *, HGRenderPipeline *, HGCamera *, Object *, ShaderVariablesGlobal *, ScriptableRenderContext *, Il2CppMethodPointer))v9.klass.vtable.UpdateShaderVariablesGlobal.method)(
			//         v9,
			//         hgrp,
			//         camera,
			//         v6,
			//         &v9.fields.m_shaderVariablesGlobal,
			//         &context,
			//         v9.klass.vtable.OnPreRendering.methodPtr);
			//       v14 = *(List_1_System_Object_ **)&v9[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//       if ( !v14 )
			//         sub_1802DC2C8(v13, 0LL);
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Object_ *)&bufferId,
			//         v14,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
			//       v32 = (List_1_T_Enumerator_System_Object_)bufferId;
			//       *(_QWORD *)&bufferId.bufferId = 0LL;
			//       *(_QWORD *)&bufferId.size = &v32;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v32,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
			//         {
			//           p_m_shaderVariablesGlobal = &v9.fields.m_shaderVariablesGlobal;
			//           if ( !v32._current )
			//             sub_1802DC2C8(0LL, p_m_shaderVariablesGlobal);
			//           sub_1886475CC((WaterOnePassDeferredRenderingPass *)v32._current, p_m_shaderVariablesGlobal);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v35 )
			//       {
			//         *(Il2CppExceptionWrapper *)&bufferId.bufferId = (Il2CppExceptionWrapper)v35.ex;
			//         if ( *(_QWORD *)&bufferId.bufferId )
			//           sub_18000F780(*(_QWORD *)&bufferId.bufferId);
			//         v6 = (Object *)cmd;
			//         v9 = this;
			//       }
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       bufferId = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v37, &context, 720, 0LL);
			//       p_m00 = (_OWORD *)&v9.fields.m_basicTransformConstants._ViewMatrix.m00;
			//       v17 = v40;
			//       v18 = 5LL;
			//       v19 = 5LL;
			//       do
			//       {
			//         *v17 = *p_m00;
			//         v17[1] = p_m00[1];
			//         v17[2] = p_m00[2];
			//         v17[3] = p_m00[3];
			//         v17[4] = p_m00[4];
			//         v17[5] = p_m00[5];
			//         v17[6] = p_m00[6];
			//         v17 += 8;
			//         *(v17 - 1) = p_m00[7];
			//         p_m00 += 8;
			//         --v19;
			//       }
			//       while ( v19 );
			//       *v17 = *p_m00;
			//       v17[1] = p_m00[1];
			//       v17[2] = p_m00[2];
			//       v17[3] = p_m00[3];
			//       v17[4] = p_m00[4];
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v20 = &v41;
			//       v21 = v40;
			//       v22 = 5LL;
			//       do
			//       {
			//         *(_OWORD *)&v20._PrevViewProjMatrix.m00 = *v21;
			//         *(_OWORD *)&v20._PrevViewProjMatrix.m01 = v21[1];
			//         *(_OWORD *)&v20._PrevViewProjMatrix.m02 = v21[2];
			//         *(_OWORD *)&v20._PrevViewProjMatrix.m03 = v21[3];
			//         *(_OWORD *)&v20._PrevViewNoTransProjMatrix.m00 = v21[4];
			//         *(_OWORD *)&v20._PrevViewNoTransProjMatrix.m01 = v21[5];
			//         *(_OWORD *)&v20._PrevViewNoTransProjMatrix.m02 = v21[6];
			//         v20 = (ShaderVariablesGlobal *)((char *)v20 + 128);
			//         *(_OWORD *)&v20[-1]._VolumetricComposeParams.y = v21[7];
			//         v21 += 8;
			//         --v22;
			//       }
			//       while ( v22 );
			//       *(_OWORD *)&v20._PrevViewProjMatrix.m00 = *v21;
			//       *(_OWORD *)&v20._PrevViewProjMatrix.m01 = v21[1];
			//       *(_OWORD *)&v20._PrevViewProjMatrix.m02 = v21[2];
			//       *(_OWORD *)&v20._PrevViewProjMatrix.m03 = v21[3];
			//       *(_OWORD *)&v20._PrevViewNoTransProjMatrix.m00 = v21[4];
			//       HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>(
			//         &bufferId,
			//         (BasicTransformConstants *)&v41,
			//         0,
			//         MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !v6 )
			//         sub_1802DC2C8(static_fields, v23);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//         (CommandBuffer *)v6,
			//         bufferId.bufferId,
			//         static_fields._UIRenderingConstants,
			//         bufferId.offset,
			//         720,
			//         0LL);
			//       bufferId = *UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v37, &context, 4512, 0LL);
			//       v25 = (_OWORD *)&v9.fields.m_basicTransformConstants._ViewMatrix.m00;
			//       v26 = &v41;
			//       do
			//       {
			//         *(_OWORD *)&v26._PrevViewProjMatrix.m00 = *v25;
			//         *(_OWORD *)&v26._PrevViewProjMatrix.m01 = v25[1];
			//         *(_OWORD *)&v26._PrevViewProjMatrix.m02 = v25[2];
			//         *(_OWORD *)&v26._PrevViewProjMatrix.m03 = v25[3];
			//         *(_OWORD *)&v26._PrevViewNoTransProjMatrix.m00 = v25[4];
			//         *(_OWORD *)&v26._PrevViewNoTransProjMatrix.m01 = v25[5];
			//         *(_OWORD *)&v26._PrevViewNoTransProjMatrix.m02 = v25[6];
			//         v26 = (ShaderVariablesGlobal *)((char *)v26 + 128);
			//         *(_OWORD *)&v26[-1]._VolumetricComposeParams.y = v25[7];
			//         v25 += 8;
			//         --v18;
			//       }
			//       while ( v18 );
			//       *(_OWORD *)&v26._PrevViewProjMatrix.m00 = *v25;
			//       *(_OWORD *)&v26._PrevViewProjMatrix.m01 = v25[1];
			//       *(_OWORD *)&v26._PrevViewProjMatrix.m02 = v25[2];
			//       *(_OWORD *)&v26._PrevViewProjMatrix.m03 = v25[3];
			//       *(_OWORD *)&v26._PrevViewNoTransProjMatrix.m00 = v25[4];
			//       HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>(
			//         &bufferId,
			//         (BasicTransformConstants *)&v41,
			//         0,
			//         MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>);
			//       sub_1802EFB40(&v41, &v9.fields.m_shaderVariablesGlobal, 3792LL);
			//       HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>(
			//         &bufferId,
			//         &v41,
			//         720,
			//         MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>);
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//         (CommandBuffer *)v6,
			//         bufferId.bufferId,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._ShaderVariablesGlobal,
			//         bufferId.offset,
			//         4512,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v36 )
			//     {
			//       ex = v36.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		[IDTag(1)]
		private void OnPreRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams, bool skipRender)
		{
			// // Void OnPreRendering(HGRenderPathBase+HGRenderPathParams ByRef, Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         bool skipRender,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v7; // r9
			//   HGRenderPipeline *v8; // rbx
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   HGCamera **p_camera; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // r8
			//   HGCamera *v13; // r14
			//   bool IsUICamera; // al
			//   HGCamera *v15; // r12
			//   CommandBuffer *commandBuffer; // rdi
			//   void *m_Ptr; // rbx
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   Object_1 *targetTexture; // rbx
			//   bool v23; // di
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   GraphicsFormat__Enum graphicsFormat; // eax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   __int128 v37; // xmm9
			//   __int128 v38; // xmm10
			//   __int64 v39; // xmm11_8
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *v42; // rax
			//   TextureHandle Item2; // xmm2
			//   int32_t msaaSamples_k__BackingField; // edi
			//   MethodInfo *taauRTSize_k__BackingField; // rbx
			//   MessageDescriptor *containingType; // rbx
			//   OneofDescriptorProto *v47; // rdx
			//   FileDescriptor *v48; // r8
			//   MessageDescriptor *v49; // r9
			//   OneofDescriptorProto *v50; // rdx
			//   FileDescriptor *v51; // r8
			//   MessageDescriptor *v52; // r9
			//   OneofDescriptorProto *v53; // rdx
			//   FileDescriptor *v54; // r8
			//   MessageDescriptor *v55; // r9
			//   OneofDescriptorProto *v56; // rdx
			//   FileDescriptor *v57; // r8
			//   MessageDescriptor *v58; // r9
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   __int64 v61; // rax
			//   __int64 v62; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   String__Array *cmd; // [rsp+20h] [rbp-5A8h]
			//   String__Array *cmda; // [rsp+20h] [rbp-5A8h]
			//   String__Array *cmdb; // [rsp+20h] [rbp-5A8h]
			//   String__Array *cmdc; // [rsp+20h] [rbp-5A8h]
			//   String__Array *cmdd; // [rsp+20h] [rbp-5A8h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-5A0h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-5A0h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-5A0h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-5A0h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-5A0h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-5A0h]
			//   MethodInfo *v77; // [rsp+30h] [rbp-598h]
			//   MethodInfo *v78; // [rsp+30h] [rbp-598h]
			//   MethodInfo *v79; // [rsp+30h] [rbp-598h]
			//   MethodInfo *v80; // [rsp+30h] [rbp-598h]
			//   MethodInfo *v81; // [rsp+30h] [rbp-598h]
			//   RenderTargetIdentifier v82; // [rsp+50h] [rbp-578h] BYREF
			//   HGRenderPipeline *hgrp; // [rsp+80h] [rbp-548h]
			//   IList_1_Google_Protobuf_Reflection_FieldDescriptor_ **p_fields; // [rsp+88h] [rbp-540h]
			//   OneofDescriptor v85; // [rsp+90h] [rbp-538h] BYREF
			//   ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ v86; // [rsp+E0h] [rbp-4E8h] BYREF
			//   TextureDesc v87; // [rsp+100h] [rbp-4C8h] BYREF
			//   Il2CppExceptionWrapper *v88; // [rsp+160h] [rbp-468h] BYREF
			//   RenderTargetIdentifier v89; // [rsp+170h] [rbp-458h] BYREF
			//   PassEventInput input; // [rsp+1A0h] [rbp-428h] BYREF
			//   TextureDesc v91; // [rsp+1D0h] [rbp-3F8h] BYREF
			//   TextureDesc v92; // [rsp+230h] [rbp-398h] BYREF
			//   HGCamera *camera; // [rsp+290h] [rbp-338h] BYREF
			//   HGCamera *v94; // [rsp+298h] [rbp-330h]
			//   HGIrradianceVolumePipelineUpdateResult result; // [rsp+450h] [rbp-178h] BYREF
			//   HGIrradianceVolumePipelineUpdateResultV2 v96; // [rsp+4A8h] [rbp-120h] BYREF
			// 
			//   if ( !byte_18D919644 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919644 = 1;
			//   }
			//   sub_1802F01E0(&camera, 0LL, 680LL);
			//   memset(&v85.monitor, 0, 32);
			//   memset(&v85.fields.fields, 0, 24);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1056, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1056, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v65, v64);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_390(Patch, (Object *)this, renderPathParams, skipRender, 0LL);
			//   }
			//   else
			//   {
			//     v8 = renderPathParams.hgrp;
			//     hgrp = v8;
			//     p_renderRequest = &renderPathParams.renderRequest;
			//     p_camera = &camera;
			//     v11 = 5LL;
			//     v12 = 128LL;
			//     do
			//     {
			//       *(_OWORD *)p_camera = *(_OWORD *)&p_renderRequest.hgCamera;
			//       *((_OWORD *)p_camera + 1) = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//       *((_OWORD *)p_camera + 2) = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//       *((_OWORD *)p_camera + 3) = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//       *((_OWORD *)p_camera + 4) = *(_OWORD *)&p_renderRequest.target.face;
			//       *((_OWORD *)p_camera + 5) = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//       *((_OWORD *)p_camera + 6) = p_renderRequest.cullingResults.cullingResults;
			//       p_camera += 16;
			//       *((_OWORD *)p_camera - 1) = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//       p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//       --v11;
			//     }
			//     while ( v11 );
			//     *(_OWORD *)p_camera = *(_OWORD *)&p_renderRequest.hgCamera;
			//     *((_OWORD *)p_camera + 1) = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//     p_camera[4] = *(HGCamera **)&p_renderRequest.target.id.m_InstanceID;
			//     if ( !v8 )
			//       sub_180B536AC(p_camera, 0LL);
			//     v85.fields.containingType = (MessageDescriptor *)v8.fields.m_RenderGraph;
			//     v13 = camera;
			//     if ( !v94 || (IsUICamera = HG::Rendering::Runtime::HGCamera::IsUICamera(v94, 0LL), v15 = v94, !IsUICamera) )
			//       v15 = 0LL;
			//     commandBuffer = renderPathParams.renderGraphParams.commandBuffer;
			//     m_Ptr = renderPathParams.renderGraphParams.scriptableRenderContext.m_Ptr;
			//     this.fields.m_trackingCamera = v13;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_trackingCamera,
			//       (OneofDescriptorProto *)v11,
			//       (FileDescriptor *)v12,
			//       v7,
			//       cmd,
			//       (String *)methoda,
			//       v77);
			//     this.fields.m_trackingBackBufferState = 0;
			//     HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolume(
			//       this,
			//       &result,
			//       renderPathParams.renderGraphParams.currentFrameIndex,
			//       v13,
			//       commandBuffer,
			//       0LL);
			//     HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesIrradianceVolumeV2(
			//       this,
			//       &v96,
			//       renderPathParams.renderGraphParams.currentFrameIndex,
			//       v13,
			//       commandBuffer,
			//       0LL);
			//     HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalCB(
			//       this,
			//       hgrp,
			//       v13,
			//       commandBuffer,
			//       (ScriptableRenderContext)m_Ptr,
			//       0LL);
			//     if ( !v13 )
			//       sub_180B536AC(v19, v18);
			//     HG::Rendering::Runtime::HGCamera::OnRecordingBegin(v13, 0LL);
			//     if ( v15 )
			//       HG::Rendering::Runtime::HGCamera::OnRecordingBegin(v15, 0LL);
			//     if ( !v13.fields.camera )
			//       sub_180B536AC(v21, v20);
			//     targetTexture = (Object_1 *)UnityEngine::Camera::get_targetTexture(v13.fields.camera, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     v23 = UnityEngine::Object::op_Inequality(targetTexture, 0LL, 0LL);
			//     sub_1802F01E0(&v87, 0LL, 96LL);
			//     if ( v23 )
			//     {
			//       if ( !v13.fields.camera )
			//         sub_180B536AC(v25, v24);
			//       if ( !UnityEngine::Camera::get_targetTexture(v13.fields.camera, 0LL) )
			//         sub_180B536AC(v27, v26);
			//       v87.width = sub_18003ED00(5LL);
			//       if ( !v13.fields.camera )
			//         sub_180B536AC(v29, v28);
			//       if ( !UnityEngine::Camera::get_targetTexture(v13.fields.camera, 0LL) )
			//         sub_180B536AC(v31, v30);
			//       v87.height = sub_18003ED00(7LL);
			//       if ( !targetTexture )
			//         sub_180B536AC(v33, v32);
			//       graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)targetTexture, 0LL);
			//     }
			//     else
			//     {
			//       v87.width = UnityEngine::Screen::get_width(0LL);
			//       v87.height = UnityEngine::Screen::get_height(0LL);
			//       graphicsFormat = GraphicsFormat__Enum_R8G8B8A8_UNorm;
			//     }
			//     v87.colorFormat = graphicsFormat;
			//     v87.dimension = 2;
			//     v87.slices = 1;
			//     v87.msaaSamples = 1;
			//     v92 = v87;
			//     v91 = v87;
			//     if ( v23 )
			//     {
			//       if ( !targetTexture )
			//         sub_180B536AC(v36, v35);
			//       v91.colorFormat = UnityEngine::RenderTexture::get_depthStencilFormat((RenderTexture *)targetTexture, 0LL);
			//       memset(&v82, 0, sizeof(v82));
			//       v86.Item1 = (TextureHandle)*UnityEngine::RenderTexture::get_colorBuffer(
			//                                     (RenderBuffer *)&v86,
			//                                     (RenderTexture *)targetTexture,
			//                                     0LL);
			//       UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
			//         &v82,
			//         (RenderBuffer *)&v86,
			//         0,
			//         CubemapFace__Enum_Unknown,
			//         0,
			//         0LL);
			//       v37 = *(_OWORD *)&v82.m_Type;
			//       v38 = *(_OWORD *)&v82.m_BufferPointer;
			//       v39 = *(_QWORD *)&v82.m_DepthSlice;
			//       memset(&v82, 0, sizeof(v82));
			//       v86.Item1 = (TextureHandle)*UnityEngine::RenderTexture::get_depthBuffer(
			//                                     (RenderBuffer *)&v86,
			//                                     (RenderTexture *)targetTexture,
			//                                     0LL);
			//       UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
			//         &v82,
			//         (RenderBuffer *)&v86,
			//         0,
			//         CubemapFace__Enum_Unknown,
			//         0,
			//         0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v91.colorFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(
			//                           GraphicsFormat__Enum_D24_UNorm_S8_UInt,
			//                           0LL);
			//       *(_OWORD *)&v82.m_Type = 0xFFFFFFFF00000002uLL;
			//       v82.m_BufferPointer = 0LL;
			//       *(_QWORD *)&v82.m_MipLevel = 0xFFFFFFFF00000000uLL;
			//       v37 = 0xFFFFFFFF00000002uLL;
			//       v38 = *(_OWORD *)&v82.m_BufferPointer;
			//       v39 = 0LL;
			//       *(_QWORD *)&v82.m_InstanceID = 0LL;
			//       *(_QWORD *)&v82.m_DepthSlice = 0LL;
			//       v82.m_Type = 3;
			//       v82.m_BufferPointer = 0LL;
			//       *(_QWORD *)&v82.m_MipLevel = 0xFFFFFFFF00000000uLL;
			//     }
			//     if ( !v85.fields.containingType )
			//       sub_180B536AC(v41, v40);
			//     *(_OWORD *)&v89.m_Type = v37;
			//     *(_OWORD *)&v89.m_BufferPointer = v38;
			//     *(_QWORD *)&v89.m_DepthSlice = v39;
			//     v42 = HG::Rendering::RenderGraphModule::HGRenderGraph::ImportBackbuffer(
			//             &v86,
			//             (HGRenderGraph *)v85.fields.containingType,
			//             &v89,
			//             &v82,
			//             &v92,
			//             &v91,
			//             v23,
			//             0LL);
			//     Item2 = v42.Item2;
			//     this.fields._backBufferColor_k__BackingField = v42.Item1;
			//     this.fields._backBufferDepth_k__BackingField = Item2;
			//     this.fields._firstBackbufferPass_k__BackingField = sub_18003ED00(7LL);
			//     msaaSamples_k__BackingField = v13.fields._msaaSamples_k__BackingField;
			//     taauRTSize_k__BackingField = (MethodInfo *)v13.fields._taauRTSize_k__BackingField;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     methodb = taauRTSize_k__BackingField;
			//     containingType = v85.fields.containingType;
			//     this.fields._intermediateBackBuffer_k__BackingField = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
			//                                                               &v86.Item1,
			//                                                               (HGRenderGraph *)v85.fields.containingType,
			//                                                               v13,
			//                                                               msaaSamples_k__BackingField != 1,
			//                                                               GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//                                                               (Vector2Int)methodb,
			//                                                               0LL);
			//     sub_18005B3A0(9LL, this, renderPathParams);
			//     memset(&v85.monitor, 0, 32);
			//     v85.klass = (OneofDescriptor__Class *)v13;
			//     sub_1800054D0(&v85, v47, v48, v49, cmda, (String *)methodc, v78);
			//     v85.monitor = (MonitorData *)v15;
			//     sub_1800054D0((OneofDescriptor *)&v85.monitor, v50, v51, v52, cmdb, (String *)methodd, v79);
			//     *(_QWORD *)&v85.fields._._Index_k__BackingField = containingType;
			//     sub_1800054D0((OneofDescriptor *)&v85.fields, v53, v54, v55, cmdc, (String *)methode, v80);
			//     v85.fields._._FullName_k__BackingField = (String *)hgrp;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v85.fields._._FullName_k__BackingField,
			//       v56,
			//       v57,
			//       v58,
			//       cmdd,
			//       (String *)methodf,
			//       v81);
			//     LOBYTE(v85.fields._._File_k__BackingField) = skipRender;
			//     *(_OWORD *)&input.camera = *(_OWORD *)&v85.klass;
			//     *(_OWORD *)&input.renderGraph = *(_OWORD *)&v85.fields._._Index_k__BackingField;
			//     *(_QWORD *)&input.passSkipped = v85.fields._._File_k__BackingField;
			//     if ( !*(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 )
			//       sub_180B536AC(v60, v59);
			//     v61 = sub_180319248(&v86, *(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00);
			//     *(_OWORD *)&v85.fields.fields = *(_OWORD *)v61;
			//     v85.fields._Proto_k__BackingField = *(OneofDescriptorProto **)(v61 + 16);
			//     hgrp = 0LL;
			//     p_fields = &v85.fields.fields;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 (List_1_T_Enumerator_System_Object_ *)&v85.fields.fields,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
			//       {
			//         if ( !v85.fields._Proto_k__BackingField )
			//           sub_1802DC2C8(0LL, v62);
			//         sub_188647030((WaterOnePassDeferredRenderingPass *)v85.fields._Proto_k__BackingField, &input);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v88 )
			//     {
			//       hgrp = (HGRenderPipeline *)v88.ex;
			//       if ( hgrp )
			//         sub_18000F780(hgrp);
			//     }
			//   }
			// }
			// 
		}

		internal void Render(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void Render(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGRenderPathBase::Render(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v3; // rdi
			//   HGRenderPathBase *v4; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // rsi
			//   HGRenderGraph *m_RenderGraph; // rsi
			//   char v9; // r14
			//   HGCamera *renderPathInstance_k__BackingField; // rcx
			//   __int64 *v11; // rdx
			//   IPassConstructor *v12; // rsi
			//   __int64 v13; // rax
			//   char v14; // r15
			//   HGCamera *v15; // r12
			//   char has_parent; // al
			//   HGCamera *LightWeightCamera; // rax
			//   HGCamera *v18; // rsi
			//   HGRenderPathBase_HGRenderPathParams *v19; // rcx
			//   HGRenderPathBase_HGRenderPathParams *p_renderPathParamsa; // rdx
			//   __int64 v21; // rax
			//   int v22; // eax
			//   unsigned __int64 v23; // r9
			//   signed __int64 v24; // rtt
			//   unsigned __int64 v25; // r9
			//   signed __int64 v26; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   __int64 v30; // [rsp+0h] [rbp-378h] BYREF
			//   char v31; // [rsp+20h] [rbp-358h]
			//   Il2CppException *ex; // [rsp+28h] [rbp-350h]
			//   char *v33; // [rsp+30h] [rbp-348h]
			//   HGRenderGraph *v34; // [rsp+38h] [rbp-340h]
			//   IPassConstructor *pass; // [rsp+40h] [rbp-338h] BYREF
			//   Il2CppExceptionWrapper *v36; // [rsp+48h] [rbp-330h] BYREF
			//   Il2CppExceptionWrapper *v37; // [rsp+50h] [rbp-328h] BYREF
			//   Il2CppExceptionWrapper *v38; // [rsp+58h] [rbp-320h] BYREF
			//   HGRenderPathBase_HGRenderPathParams renderPathParamsa; // [rsp+60h] [rbp-318h] BYREF
			//   char v42; // [rsp+398h] [rbp+20h] BYREF
			// 
			//   v3 = renderPathParams;
			//   v4 = this;
			//   if ( !byte_18D919645 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//     byte_18D919645 = 1;
			//   }
			//   v42 = 0;
			//   pass = 0LL;
			//   sub_1802F01E0(&renderPathParamsa, 0LL, 752LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1054, 0LL) )
			//   {
			//     hgrp = v3.hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v34 = m_RenderGraph;
			//     sub_180003EE0(v4.klass);
			//     v9 = ((__int64 (__fastcall *)(HGRenderPathBase *, HGRenderPathBase_HGRenderPathParams *, Il2CppMethodPointer))v4.klass.vtable.SkipRender.method)(
			//            v4,
			//            v3,
			//            v4.klass.vtable.GetDefaultFirstBackbufferPass.methodPtr);
			//     v31 = v9;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
			//     ex = 0LL;
			//     v33 = &v42;
			//     try
			//     {
			//       HG::Rendering::Runtime::HGRenderPathBase::OnPreRendering(v4, v3, v9, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v36 )
			//     {
			//       v11 = &v30;
			//       ex = v36.ex;
			//       renderPathInstance_k__BackingField = (HGCamera *)ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       m_RenderGraph = v34;
			//       v9 = v31;
			//     }
			//     if ( m_RenderGraph )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::RegisterCallbackOwner(
			//         m_RenderGraph,
			//         (IRenderGraphCallbackOwner *)v4,
			//         0LL);
			//       if ( !v9 )
			//       {
			//         UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//           (Int32Enum__Enum)1u,
			//           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
			//         ex = 0LL;
			//         v33 = &v42;
			//         try
			//         {
			//           sub_18005B3A0(10LL, v4, v3);
			//         }
			//         catch ( Il2CppExceptionWrapper *v37 )
			//         {
			//           ex = v37.ex;
			//           if ( ex )
			//             sub_18000F780(ex);
			//           v3 = renderPathParams;
			//           v4 = this;
			//           v9 = v31;
			//         }
			//         goto LABEL_33;
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCallbackOwners(m_RenderGraph, 0LL);
			//       if ( HG::Rendering::Runtime::HGRenderPathBase::TryGetPassConstructor(
			//              v4,
			//              PassConstructorID__Enum_VolumetricFog,
			//              &pass,
			//              0LL) )
			//       {
			//         v12 = pass;
			//         v13 = *(_QWORD *)&v4[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//         if ( !v13 )
			//           goto LABEL_42;
			//         v14 = *(_BYTE *)(v13 + 1640);
			//         v15 = *(HGCamera **)&v4[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//         if ( !pass
			//           || !(unsigned __int8)il2cpp_class_has_parent(
			//                                  pass.klass,
			//                                  TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor)
			//           || !v12 )
			//         {
			//           goto LABEL_42;
			//         }
			//         has_parent = il2cpp_class_has_parent(v12.klass, TypeInfo::HG::Rendering::Runtime::VolumetricFogPassConstructor);
			//         HG::Rendering::Runtime::VolumetricFogPassConstructor::ConstructSkipRender(
			//           (VolumetricFogPassConstructor *)((unsigned __int64)v12 & -(__int64)(has_parent != 0)),
			//           v14,
			//           v15,
			//           0LL);
			//       }
			//       renderPathInstance_k__BackingField = *(HGCamera **)&v4[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//       if ( renderPathInstance_k__BackingField )
			//       {
			//         LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(
			//                               renderPathInstance_k__BackingField,
			//                               0LL);
			//         v18 = LightWeightCamera;
			//         if ( !LightWeightCamera )
			//           goto LABEL_33;
			//         renderPathInstance_k__BackingField = *(HGCamera **)&v4[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//         if ( renderPathInstance_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::HGCamera::TransferWaterMarkRTs(
			//             renderPathInstance_k__BackingField,
			//             LightWeightCamera,
			//             0LL);
			//           v19 = v3;
			//           p_renderPathParamsa = &renderPathParamsa;
			//           v21 = 5LL;
			//           do
			//           {
			//             *(_OWORD *)&p_renderPathParamsa.skipRender = *(_OWORD *)&v19.skipRender;
			//             *(_OWORD *)&p_renderPathParamsa.renderRequest.hgCamera = *(_OWORD *)&v19.renderRequest.hgCamera;
			//             *(_OWORD *)&p_renderPathParamsa.renderRequest.clearCameraSettings = *(_OWORD *)&v19.renderRequest.clearCameraSettings;
			//             *(_OWORD *)&p_renderPathParamsa.renderRequest.target.id.m_InstanceID = *(_OWORD *)&v19.renderRequest.target.id.m_InstanceID;
			//             *(_OWORD *)&p_renderPathParamsa.renderRequest.target.id.m_MipLevel = *(_OWORD *)&v19.renderRequest.target.id.m_MipLevel;
			//             *(_OWORD *)&p_renderPathParamsa.renderRequest.target.face = *(_OWORD *)&v19.renderRequest.target.face;
			//             *(_OWORD *)&p_renderPathParamsa.renderRequest.target.targetDepth = *(_OWORD *)&v19.renderRequest.target.targetDepth;
			//             p_renderPathParamsa = (HGRenderPathBase_HGRenderPathParams *)((char *)p_renderPathParamsa + 128);
			//             p_renderPathParamsa[-1].perFrameSetup = (HGRenderPathBase_PerFrameSetup)v19.renderRequest.cullingResults.cullingResults;
			//             v19 = (HGRenderPathBase_HGRenderPathParams *)((char *)v19 + 128);
			//             --v21;
			//           }
			//           while ( v21 );
			//           *(_OWORD *)&p_renderPathParamsa.skipRender = *(_OWORD *)&v19.skipRender;
			//           *(_OWORD *)&p_renderPathParamsa.renderRequest.hgCamera = *(_OWORD *)&v19.renderRequest.hgCamera;
			//           *(_OWORD *)&p_renderPathParamsa.renderRequest.clearCameraSettings = *(_OWORD *)&v19.renderRequest.clearCameraSettings;
			//           *(_OWORD *)&p_renderPathParamsa.renderRequest.target.id.m_InstanceID = *(_OWORD *)&v19.renderRequest.target.id.m_InstanceID;
			//           *(_OWORD *)&p_renderPathParamsa.renderRequest.target.id.m_MipLevel = *(_OWORD *)&v19.renderRequest.target.id.m_MipLevel;
			//           *(_OWORD *)&p_renderPathParamsa.renderRequest.target.face = *(_OWORD *)&v19.renderRequest.target.face;
			//           *(_OWORD *)&p_renderPathParamsa.renderRequest.target.targetDepth = *(_OWORD *)&v19.renderRequest.target.targetDepth;
			//           renderPathParamsa.renderRequest.hgCamera = v18;
			//           v22 = dword_18D8E43F8;
			//           v11 = qword_18D6405E0;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v23 = (((unsigned __int64)&renderPathParamsa.renderRequest >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v23 + 36190]);
			//             do
			//               v24 = qword_18D6405E0[v23 + 36190];
			//             while ( v24 != _InterlockedCompareExchange64(
			//                              &qword_18D6405E0[v23 + 36190],
			//                              v24 | (1LL << (((unsigned __int64)&renderPathParamsa.renderRequest >> 12) & 0x3F)),
			//                              v24) );
			//             v22 = dword_18D8E43F8;
			//           }
			//           renderPathParamsa.renderRequest.hgLWCamera = 0LL;
			//           if ( v22 )
			//           {
			//             v25 = (((unsigned __int64)&renderPathParamsa.renderRequest.hgLWCamera >> 12) & 0x1FFFFF) >> 6;
			//             _m_prefetchw(&qword_18D6405E0[v25 + 36190]);
			//             do
			//               v26 = qword_18D6405E0[v25 + 36190];
			//             while ( v26 != _InterlockedCompareExchange64(
			//                              &qword_18D6405E0[v25 + 36190],
			//                              v26 | (1LL << (((unsigned __int64)&renderPathParamsa.renderRequest.hgLWCamera >> 12) & 0x3F)),
			//                              v26) );
			//           }
			//           renderPathInstance_k__BackingField = (HGCamera *)v18.fields._renderPathInstance_k__BackingField;
			//           if ( renderPathInstance_k__BackingField )
			//           {
			//             HG::Rendering::Runtime::HGRenderPathBase::Render(
			//               (HGRenderPathBase *)renderPathInstance_k__BackingField,
			//               &renderPathParamsa,
			//               0LL);
			// LABEL_33:
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)2u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGRenderPathBase::RenderPathProfileScope>);
			//             ex = 0LL;
			//             v33 = &v42;
			//             try
			//             {
			//               HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering(v4, v3, v9, 0LL);
			//             }
			//             catch ( Il2CppExceptionWrapper *v38 )
			//             {
			//               ex = v38.ex;
			//               if ( ex )
			//                 sub_18000F780(ex);
			//             }
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_42:
			//     sub_1802DC2C8(renderPathInstance_k__BackingField, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1054, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v29, v28);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v4, v3, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		private void OnPostRendering(ref HGRenderPathBase.HGRenderPathParams renderPathParams, bool skipRender)
		{
			// // Void OnPostRendering(HGRenderPathBase+HGRenderPathParams ByRef, Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGRenderPathBase::OnPostRendering(
			//         HGRenderPathBase *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         bool skipRender,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v5; // rdi
			//   Object *v6; // r14
			//   MessageDescriptor *v7; // r9
			//   HGRenderPipeline *hgrp; // r15
			//   HGRenderPipeline_RenderRequest *p_renderRequest; // rax
			//   HGCamera **v10; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // r8
			//   HGRenderGraph *m_RenderGraph; // r13
			//   OneofDescriptor__Class *Proto_k__BackingField; // rsi
			//   MonitorData *v15; // rbx
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 v27; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   String__Array *v34; // [rsp+20h] [rbp-388h]
			//   String__Array *v35; // [rsp+20h] [rbp-388h]
			//   String__Array *v36; // [rsp+20h] [rbp-388h]
			//   String__Array *v37; // [rsp+20h] [rbp-388h]
			//   String *v38; // [rsp+28h] [rbp-380h]
			//   String *v39; // [rsp+28h] [rbp-380h]
			//   String *v40; // [rsp+28h] [rbp-380h]
			//   String *v41; // [rsp+28h] [rbp-380h]
			//   OneofDescriptor v42; // [rsp+30h] [rbp-378h] BYREF
			//   _QWORD v43[3]; // [rsp+80h] [rbp-328h] BYREF
			//   Il2CppExceptionWrapper *v44; // [rsp+98h] [rbp-310h] BYREF
			//   PassEventInput input; // [rsp+A0h] [rbp-308h] BYREF
			//   HGCamera *v46; // [rsp+D0h] [rbp-2D8h] BYREF
			//   HGCamera *v47; // [rsp+D8h] [rbp-2D0h]
			// 
			//   v5 = renderPathParams;
			//   v6 = (Object *)this;
			//   if ( !byte_18D919646 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
			//     byte_18D919646 = 1;
			//   }
			//   memset(&v42.fields.containingType, 0, 24);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1078, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1078, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v33, v32);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_390(Patch, v6, v5, skipRender, 0LL);
			//   }
			//   else
			//   {
			//     hgrp = v5.hgrp;
			//     p_renderRequest = &v5.renderRequest;
			//     v10 = &v46;
			//     v11 = 5LL;
			//     v12 = 128LL;
			//     do
			//     {
			//       *(_OWORD *)v10 = *(_OWORD *)&p_renderRequest.hgCamera;
			//       *((_OWORD *)v10 + 1) = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//       *((_OWORD *)v10 + 2) = *(_OWORD *)&p_renderRequest.target.id.m_InstanceID;
			//       *((_OWORD *)v10 + 3) = *(_OWORD *)&p_renderRequest.target.id.m_MipLevel;
			//       *((_OWORD *)v10 + 4) = *(_OWORD *)&p_renderRequest.target.face;
			//       *((_OWORD *)v10 + 5) = *(_OWORD *)&p_renderRequest.target.targetDepth;
			//       *((_OWORD *)v10 + 6) = p_renderRequest.cullingResults.cullingResults;
			//       v10 += 16;
			//       *((_OWORD *)v10 - 1) = *(_OWORD *)&p_renderRequest.cullingResults.customPassCullingResults.hasValue;
			//       p_renderRequest = (HGRenderPipeline_RenderRequest *)((char *)p_renderRequest + 128);
			//       --v11;
			//     }
			//     while ( v11 );
			//     *(_OWORD *)v10 = *(_OWORD *)&p_renderRequest.hgCamera;
			//     *((_OWORD *)v10 + 1) = *(_OWORD *)&p_renderRequest.clearCameraSettings;
			//     v10[4] = *(HGCamera **)&p_renderRequest.target.id.m_InstanceID;
			//     if ( !hgrp )
			//       sub_180B536AC(v10, 0LL);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     Proto_k__BackingField = (OneofDescriptor__Class *)v46;
			//     v42.fields._Proto_k__BackingField = (OneofDescriptorProto *)v46;
			//     v15 = (MonitorData *)v47;
			//     if ( !v47 || !HG::Rendering::Runtime::HGCamera::IsUICamera(v47, 0LL) )
			//       v15 = 0LL;
			//     *(_QWORD *)&v42.fields._IsSynthetic_k__BackingField = v15;
			//     memset(&v42.monitor, 0, 32);
			//     v42.klass = Proto_k__BackingField;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       &v42,
			//       (OneofDescriptorProto *)v11,
			//       (FileDescriptor *)v12,
			//       v7,
			//       v34,
			//       v38);
			//     v42.monitor = v15;
			//     sub_1800054D0((OneofDescriptor *)&v42.monitor, v16, v17, v18, v35, v39, (MethodInfo *)v42.klass);
			//     *(_QWORD *)&v42.fields._._Index_k__BackingField = m_RenderGraph;
			//     sub_1800054D0((OneofDescriptor *)&v42.fields, v19, v20, v21, v36, v40, (MethodInfo *)v42.klass);
			//     v42.fields._._FullName_k__BackingField = (String *)hgrp;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v42.fields._._FullName_k__BackingField,
			//       v22,
			//       v23,
			//       v24,
			//       v37,
			//       v41,
			//       (MethodInfo *)v42.klass);
			//     LOBYTE(v42.fields._._File_k__BackingField) = skipRender;
			//     *(_OWORD *)&input.camera = *(_OWORD *)&v42.klass;
			//     *(_OWORD *)&input.renderGraph = *(_OWORD *)&v42.fields._._Index_k__BackingField;
			//     *(_QWORD *)&input.passSkipped = v42.fields._._File_k__BackingField;
			//     if ( !v6[288].monitor )
			//       sub_180B536AC(v26, v25);
			//     v27 = sub_180319248(v43, v6[288].monitor);
			//     *(_OWORD *)&v42.fields.containingType = *(_OWORD *)v27;
			//     v42.fields.accessor = *(OneofAccessor **)(v27 + 16);
			//     v43[0] = 0LL;
			//     v43[1] = &v42.fields.containingType;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 (List_1_T_Enumerator_System_Object_ *)&v42.fields.containingType,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
			//       {
			//         if ( !v42.fields.accessor )
			//           sub_1802DC2C8(0LL, v28);
			//         sub_188646A94((WaterOnePassDeferredRenderingPass *)v42.fields.accessor, &input);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v44 )
			//     {
			//       v43[0] = v44.ex;
			//       if ( v43[0] )
			//         sub_18000F780(v43[0]);
			//       v5 = renderPathParams;
			//       v6 = (Object *)this;
			//       Proto_k__BackingField = (OneofDescriptor__Class *)v42.fields._Proto_k__BackingField;
			//       v15 = *(MonitorData **)&v42.fields._IsSynthetic_k__BackingField;
			//     }
			//     sub_18005B3A0(11LL, v6, v5);
			//     if ( !Proto_k__BackingField )
			//       sub_1802DC2C8(v30, v29);
			//     HG::Rendering::Runtime::HGCamera::OnRecordingEnd((HGCamera *)Proto_k__BackingField, 0LL);
			//     if ( v15 )
			//       HG::Rendering::Runtime::HGCamera::OnRecordingEnd((HGCamera *)v15, 0LL);
			//   }
			// }
			// 
		}

		internal void RecordAndExecute(HGRenderPipeline hgrp, in HGRenderPipeline.RenderRequest renderRequest, string executionName, int frameIndex, bool rendererListCulling, ScriptableRenderContext srp, CommandBuffer cmd)
		{
			// // Void RecordAndExecute(HGRenderPipeline, HGRenderPipeline+RenderRequest ByRef, String, Int32, Boolean, ScriptableRenderContext, CommandBuffer)
			// // Hidden C++ exception states: #wind=2 #try_helpers=1
			// void HG::Rendering::Runtime::HGRenderPathBase::RecordAndExecute(
			//         HGRenderPathBase *this,
			//         HGRenderPipeline *hgrp,
			//         HGRenderPipeline_RenderRequest *renderRequest,
			//         String *executionName,
			//         int32_t frameIndex,
			//         bool rendererListCulling,
			//         ScriptableRenderContext srp,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   __int128 v17; // xmm6
			//   __int128 v18; // xmm7
			//   FileDescriptor *File_k__BackingField; // xmm8_8
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   MonitorData **p_monitor; // rcx
			//   __int64 v27; // rsi
			//   __int64 v28; // rax
			//   OneofDescriptorProto *v29; // rdx
			//   FileDescriptor *v30; // r8
			//   MessageDescriptor *v31; // r9
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   __int64 v34; // rdx
			//   HGRenderPathBase_HGRenderPathParams *p_renderPathParams; // rax
			//   _OWORD *v36; // rcx
			//   HGRenderGraph *m_RenderGraph; // rcx
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rsi
			//   Object *P3; // [rsp+20h] [rbp-6E8h]
			//   Object *P3b; // [rsp+20h] [rbp-6E8h]
			//   Object *P3c; // [rsp+20h] [rbp-6E8h]
			//   Object *P3a; // [rsp+20h] [rbp-6E8h]
			//   Object *P3d; // [rsp+20h] [rbp-6E8h]
			//   String *P4; // [rsp+28h] [rbp-6E0h]
			//   String *P4b; // [rsp+28h] [rbp-6E0h]
			//   String *P4c; // [rsp+28h] [rbp-6E0h]
			//   String *P4a; // [rsp+28h] [rbp-6E0h]
			//   String *P4d; // [rsp+28h] [rbp-6E0h]
			//   MethodInfo *P5; // [rsp+30h] [rbp-6D8h]
			//   MethodInfo *P5b; // [rsp+30h] [rbp-6D8h]
			//   MethodInfo *P5c; // [rsp+30h] [rbp-6D8h]
			//   MethodInfo *P5a; // [rsp+30h] [rbp-6D8h]
			//   MethodInfo *P5d; // [rsp+30h] [rbp-6D8h]
			//   HGRenderPathBase_PerFrameSetup v56; // [rsp+50h] [rbp-6B8h] BYREF
			//   int v57; // [rsp+60h] [rbp-6A8h] BYREF
			//   HGRenderGraph *renderGraph; // [rsp+68h] [rbp-6A0h] BYREF
			//   OneofDescriptor v59; // [rsp+70h] [rbp-698h] BYREF
			//   HGRenderGraphParameters parameters; // [rsp+C0h] [rbp-648h] BYREF
			//   _BYTE v61[8]; // [rsp+F0h] [rbp-618h] BYREF
			//   OneofDescriptor v62[8]; // [rsp+F8h] [rbp-610h] BYREF
			//   _OWORD v63[2]; // [rsp+3A8h] [rbp-360h] BYREF
			//   FileDescriptor *v64; // [rsp+3C8h] [rbp-340h]
			//   HGRenderPathBase_PerFrameSetup v65; // [rsp+3D0h] [rbp-338h]
			//   HGRenderPathBase_HGRenderPathParams renderPathParams; // [rsp+3E0h] [rbp-328h] BYREF
			//   HGRenderPathBase *v67; // [rsp+710h] [rbp+8h] BYREF
			// 
			//   v67 = this;
			//   renderGraph = 0LL;
			//   v57 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1052, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1052, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v39, v38);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_392(
			//       Patch,
			//       (Object *)v67,
			//       (Object *)hgrp,
			//       renderRequest,
			//       (Object *)executionName,
			//       frameIndex,
			//       rendererListCulling,
			//       srp,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else
			//   {
			//     memset(&v59.fields, 0, 24);
			//     *(_OWORD *)&v59.klass = (unsigned __int64)executionName;
			//     sub_1800054D0(&v59, v12, v13, v14, (String__Array *)P3, P4, P5);
			//     LODWORD(v59.monitor) = frameIndex;
			//     BYTE4(v59.monitor) = rendererListCulling;
			//     *(_OWORD *)&v59.fields._._Index_k__BackingField = __PAIR128__((unsigned __int64)cmd, (unsigned __int64)srp.m_Ptr);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&v59.fields._._FullName_k__BackingField,
			//       v15,
			//       v16,
			//       (MessageDescriptor *)(unsigned int)frameIndex,
			//       (String__Array *)P3b,
			//       P4b,
			//       P5b);
			//     v59.fields._._File_k__BackingField = *(FileDescriptor **)&v67.fields._renderPathID_k__BackingField;
			//     v17 = *(_OWORD *)&v59.klass;
			//     *(_OWORD *)&parameters.executionName = *(_OWORD *)&v59.klass;
			//     v18 = *(_OWORD *)&v59.fields._._Index_k__BackingField;
			//     *(_OWORD *)&parameters.scriptableRenderContext.m_Ptr = *(_OWORD *)&v59.fields._._Index_k__BackingField;
			//     File_k__BackingField = v59.fields._._File_k__BackingField;
			//     *(_QWORD *)&parameters.executorID = v59.fields._._File_k__BackingField;
			//     sub_1802F01E0(v61, 0LL, 752LL);
			//     v62[0].klass = (OneofDescriptor__Class *)hgrp;
			//     sub_1800054D0(v62, v20, v21, v22, (String__Array *)P3c, P4c, P5c);
			//     p_monitor = &v62[0].monitor;
			//     v27 = 5LL;
			//     v28 = 5LL;
			//     do
			//     {
			//       *(_OWORD *)p_monitor = *(_OWORD *)&renderRequest.hgCamera;
			//       *((_OWORD *)p_monitor + 1) = *(_OWORD *)&renderRequest.clearCameraSettings;
			//       *((_OWORD *)p_monitor + 2) = *(_OWORD *)&renderRequest.target.id.m_InstanceID;
			//       *((_OWORD *)p_monitor + 3) = *(_OWORD *)&renderRequest.target.id.m_MipLevel;
			//       *((_OWORD *)p_monitor + 4) = *(_OWORD *)&renderRequest.target.face;
			//       *((_OWORD *)p_monitor + 5) = *(_OWORD *)&renderRequest.target.targetDepth;
			//       *((_OWORD *)p_monitor + 6) = renderRequest.cullingResults.cullingResults;
			//       p_monitor += 16;
			//       *((_OWORD *)p_monitor - 1) = *(_OWORD *)&renderRequest.cullingResults.customPassCullingResults.hasValue;
			//       renderRequest = (HGRenderPipeline_RenderRequest *)((char *)renderRequest + 128);
			//       --v28;
			//     }
			//     while ( v28 );
			//     *(_OWORD *)p_monitor = *(_OWORD *)&renderRequest.hgCamera;
			//     *((_OWORD *)p_monitor + 1) = *(_OWORD *)&renderRequest.clearCameraSettings;
			//     p_monitor[4] = *(MonitorData **)&renderRequest.target.id.m_InstanceID;
			//     sub_1800054D0((OneofDescriptor *)&v62[0].monitor, v23, v24, v25, (String__Array *)P3a, P4a, P5a);
			//     v63[0] = v17;
			//     v63[1] = v18;
			//     v64 = File_k__BackingField;
			//     sub_1800054D0((OneofDescriptor *)v63, v29, v30, v31, (String__Array *)P3d, P4d, P5d);
			//     if ( !hgrp )
			//       sub_180B536AC(v33, v32);
			//     v65 = *HG::Rendering::Runtime::HGRenderPathBase::PreparePerFrameSetup(
			//              &v56,
			//              hgrp.fields._settingParameters_k__BackingField,
			//              0LL);
			//     p_renderPathParams = &renderPathParams;
			//     v36 = v61;
			//     do
			//     {
			//       *(_OWORD *)&p_renderPathParams.skipRender = *v36;
			//       *(_OWORD *)&p_renderPathParams.renderRequest.hgCamera = v36[1];
			//       *(_OWORD *)&p_renderPathParams.renderRequest.clearCameraSettings = v36[2];
			//       *(_OWORD *)&p_renderPathParams.renderRequest.target.id.m_InstanceID = v36[3];
			//       *(_OWORD *)&p_renderPathParams.renderRequest.target.id.m_MipLevel = v36[4];
			//       *(_OWORD *)&p_renderPathParams.renderRequest.target.face = v36[5];
			//       *(_OWORD *)&p_renderPathParams.renderRequest.target.targetDepth = v36[6];
			//       p_renderPathParams = (HGRenderPathBase_HGRenderPathParams *)((char *)p_renderPathParams + 128);
			//       p_renderPathParams[-1].perFrameSetup = (HGRenderPathBase_PerFrameSetup)v36[7];
			//       v36 += 8;
			//       --v27;
			//     }
			//     while ( v27 );
			//     *(_OWORD *)&p_renderPathParams.skipRender = *v36;
			//     *(_OWORD *)&p_renderPathParams.renderRequest.hgCamera = v36[1];
			//     *(_OWORD *)&p_renderPathParams.renderRequest.clearCameraSettings = v36[2];
			//     *(_OWORD *)&p_renderPathParams.renderRequest.target.id.m_InstanceID = v36[3];
			//     *(_OWORD *)&p_renderPathParams.renderRequest.target.id.m_MipLevel = v36[4];
			//     *(_OWORD *)&p_renderPathParams.renderRequest.target.face = v36[5];
			//     *(_OWORD *)&p_renderPathParams.renderRequest.target.targetDepth = v36[6];
			//     *(_QWORD *)&v56.depthGraphicsFormat = &v67;
			//     v56.settingParametersCpp = (HGSettingParametersCpp *)&v57;
			//     v59.fields.containingType = 0LL;
			//     *(HGRenderPathBase_PerFrameSetup *)&v59.fields.fields = v56;
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     if ( !m_RenderGraph )
			//       sub_1802DC2C8(0LL, v34);
			//     renderGraph = HG::Rendering::RenderGraphModule::HGRenderGraph::RecordAndExecute(m_RenderGraph, &parameters, 0LL).renderGraph;
			//     *(_QWORD *)&v56.depthGraphicsFormat = 0LL;
			//     v56.settingParametersCpp = (HGSettingParametersCpp *)&renderGraph;
			//     try
			//     {
			//       HG::Rendering::Runtime::HGRenderPathBase::Render(v67, &renderPathParams, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *&v59.fields._Proto_k__BackingField )
			//     {
			//       *(_QWORD *)&v56.depthGraphicsFormat = v59.fields._Proto_k__BackingField.klass;
			//     }
			//     sub_180225730(&v56);
			//     sub_180226590(&v59.fields.containingType);
			//   }
			// }
			// 
		}

		protected virtual void OnSwitchRenderPath(HGRenderPathInternal prevRenderPath)
		{
			// // Void OnSwitchRenderPath(HGRenderPathInternal)
			// void HG::Rendering::Runtime::HGRenderPathBase::OnSwitchRenderPath(
			//         HGRenderPathBase *this,
			//         HGRenderPathInternal__Enum prevRenderPath,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2958, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2958, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       prevRenderPath,
			//       0LL);
			//   }
			// }
			// 
		}

		public static HGRenderPathBase.PerFrameSetup PreparePerFrameSetup(HGSettingParameters settingParameters)
		{
			// // HGRenderPathBase+PerFrameSetup PreparePerFrameSetup(HGSettingParameters)
			// HGRenderPathBase_PerFrameSetup *HG::Rendering::Runtime::HGRenderPathBase::PreparePerFrameSetup(
			//         HGRenderPathBase_PerFrameSetup *__return_ptr retstr,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   SettingParameter_1_System_Boolean_ *depthCombinedWithStencil_k__BackingField; // rdi
			//   struct MethodInfo *v8; // rsi
			//   Il2CppClass *klass; // rax
			//   SettingParameter_1_UnityEngine_Rendering_DepthBits_ *depthBitsGBuffer_k__BackingField; // rbx
			//   struct MethodInfo *v11; // rdi
			//   Il2CppClass *v12; // rax
			//   Il2CppClass *v13; // rcx
			//   int32_t paramValue_k__BackingField; // eax
			//   GraphicsFormat__Enum v15; // ecx
			//   HGRenderPathBase_PerFrameSetup v16; // xmm0
			//   HGRenderPathBase_PerFrameSetup *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rax
			//   Int32Enum__Enum v20; // eax
			//   __int64 v21; // rdx
			//   __int64 v22; // rax
			//   HGRenderPathBase_PerFrameSetup v23; // [rsp+20h] [rbp-28h] BYREF
			//   DepthBits__Enum depthBits; // [rsp+50h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D8EDB09 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
			//     byte_18D8EDB09 = 1;
			//   }
			//   depthBits = DepthBits__Enum_None;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_31;
			//   if ( wrapperArray.max_length.size > 815 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( !v5 )
			//       goto LABEL_31;
			//     if ( LODWORD(v5._0.namespaze) <= 0x32F )
			//       sub_180070270(v5, wrapperArray);
			//     if ( v5[17]._0.nestedTypes )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(815, 0LL);
			//       if ( Patch )
			//       {
			//         v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(&v23, Patch, (Object *)settingParameters, 0LL);
			//         goto LABEL_30;
			//       }
			//       goto LABEL_31;
			//     }
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_31;
			//   depthCombinedWithStencil_k__BackingField = settingParameters.fields._depthCombinedWithStencil_k__BackingField;
			//   v8 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !depthCombinedWithStencil_k__BackingField )
			//     goto LABEL_31;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v19 = sub_18010B520(v8.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v19 + 192) + 48LL))();
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v8.klass;
			//   if ( ((__int64)v5.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v5);
			//   if ( !depthCombinedWithStencil_k__BackingField.fields._paramValue_k__BackingField )
			//   {
			//     v20 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._depthBitsGBuffer_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
			//     if ( v20 == 16 )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v21);
			//       v15 = GraphicsFormat__Enum_D16_UNorm;
			//     }
			//     else if ( v20 == 24 )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v21);
			//       v15 = GraphicsFormat__Enum_D24_UNorm;
			//     }
			//     else
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v21);
			//       v15 = GraphicsFormat__Enum_D32_SFloat;
			//     }
			//     goto LABEL_29;
			//   }
			//   depthBitsGBuffer_k__BackingField = settingParameters.fields._depthBitsGBuffer_k__BackingField;
			//   v11 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit;
			//   if ( !depthBitsGBuffer_k__BackingField )
			// LABEL_31:
			//     sub_180B536AC(v5, wrapperArray);
			//   v12 = MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit.klass;
			//   if ( ((__int64)v12.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v12.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v22 = sub_18010B520(v11.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v22 + 192) + 48LL))();
			//   }
			//   v13 = v11.klass;
			//   if ( ((__int64)v13.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v13);
			//   paramValue_k__BackingField = depthBitsGBuffer_k__BackingField.fields._paramValue_k__BackingField;
			//   if ( paramValue_k__BackingField == 24 )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			//     v15 = GraphicsFormat__Enum_D24_UNorm_S8_UInt;
			//     goto LABEL_29;
			//   }
			//   if ( paramValue_k__BackingField != 32 )
			//   {
			//     if ( TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//       goto LABEL_28;
			//     goto LABEL_32;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			// LABEL_32:
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			// LABEL_28:
			//   v15 = GraphicsFormat__Enum_D32_SFloat_S8_UInt;
			// LABEL_29:
			//   v23.depthGraphicsFormat = HG::Rendering::Runtime::HGUtils::GetSupportedFormatForDepth(v15, &depthBits, 0LL);
			//   v23.depthBits = depthBits;
			//   v23.settingParametersCpp = 0LL;
			//   v16 = (HGRenderPathBase_PerFrameSetup)*(unsigned __int64 *)&v23.depthGraphicsFormat;
			// LABEL_30:
			//   result = retstr;
			//   *retstr = v16;
			//   return result;
			// }
			// 
			return default(HGRenderPathBase.PerFrameSetup);
		}

		public bool TryGetPassConstructor(PassConstructorID id, out IPassConstructor pass)
		{
			// // Boolean TryGetPassConstructor(PassConstructorID, IPassConstructor ByRef)
			// bool HG::Rendering::Runtime::HGRenderPathBase::TryGetPassConstructor(
			//         HGRenderPathBase *this,
			//         PassConstructorID__Enum id,
			//         IPassConstructor **pass,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rsi
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   OneofDescriptorProto *v9; // rdx
			//   List_1_System_Object_ *v10; // rcx
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v16; // [rsp+20h] [rbp-18h]
			//   String *v17; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v18; // [rsp+30h] [rbp-8h]
			// 
			//   v5 = (int)id;
			//   if ( !byte_18D919647 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::get_Item);
			//     byte_18D919647 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1074, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1074, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_391(
			//              Patch,
			//              (Object *)this,
			//              (PassConstructorID__Enum)v5,
			//              pass,
			//              0LL);
			//   }
			//   else
			//   {
			//     v9 = (OneofDescriptorProto *)*(unsigned int *)(*(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20
			//                                                  + 4 * v5);
			//     if ( (_DWORD)v9 != -1 )
			//     {
			//       v10 = *(List_1_System_Object_ **)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//       if ( v10 )
			//       {
			//         *pass = (IPassConstructor *)System::Collections::Generic::List<System::Object>::get_Item(
			//                                       v10,
			//                                       (int32_t)v9,
			//                                       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::get_Item);
			//         sub_1800054D0((OneofDescriptor *)pass, v11, v12, v13, v16, v17, v18);
			//         return 1;
			//       }
			// LABEL_9:
			//       sub_180B536AC(v10, v9);
			//     }
			//     *pass = 0LL;
			//     sub_1800054D0((OneofDescriptor *)pass, v9, v7, v8, v16, v17, v18);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		protected IPassConstructor GetPassConstructor(PassConstructorID id)
		{
			// // IPassConstructor GetPassConstructor(PassConstructorID)
			// IPassConstructor *HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//         HGRenderPathBase *this,
			//         PassConstructorID__Enum id,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdi
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *v6; // rcx
			//   __int64 v8; // rax
			//   __int64 v9; // r8
			//   __int64 v10; // r9
			//   String__Array *v11; // rsi
			//   __int64 v12; // rax
			//   String *v13; // rax
			//   __int64 v14; // rax
			//   int32_t renderPath_k__BackingField; // edi
			//   String *v16; // rax
			//   __int64 v17; // rax
			//   __int64 v18; // r8
			//   String *v19; // rdi
			//   __int64 v20; // rax
			//   Exception *v21; // rax
			//   Exception *v22; // rbx
			//   __int64 v23; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Enum v25; // [rsp+20h] [rbp-28h] BYREF
			//   int32_t v26; // [rsp+30h] [rbp-18h]
			// 
			//   v4 = (int)id;
			//   if ( !byte_18D8EDB0A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::get_Item);
			//     byte_18D8EDB0A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2959, 0LL) )
			//   {
			//     v5 = *(unsigned int *)(*(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20
			//                          + 4 * v4);
			//     if ( (_DWORD)v5 == -1 )
			//     {
			//       v8 = sub_18003C530(&TypeInfo::System::String);
			//       v11 = (String__Array *)il2cpp_array_new_specific_0(v8, 6LL, v9, v10);
			//       if ( v11 )
			//       {
			//         v12 = sub_18003C530(&off_18D50A418);
			//         sub_1800046C0(v11, 0LL, v12);
			//         v25.klass = (Enum__Class *)sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
			//         v25.monitor = (MonitorData *)-1LL;
			//         v26 = v4;
			//         v13 = System::Enum::ToString(&v25, 0LL);
			//         sub_1800046C0(v11, 1LL, v13);
			//         v14 = sub_18003C530(&off_18D50A3C0);
			//         sub_1800046C0(v11, 2LL, v14);
			//         renderPath_k__BackingField = this.fields._renderPath_k__BackingField;
			//         v25.klass = (Enum__Class *)sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathInternal);
			//         v25.monitor = (MonitorData *)-1LL;
			//         v26 = renderPath_k__BackingField;
			//         v16 = System::Enum::ToString(&v25, 0LL);
			//         sub_1800046C0(v11, 3LL, v16);
			//         v17 = sub_18003C530(&off_18D50A3F0);
			//         sub_1800046C0(v11, 4LL, v17);
			//         v18 = *(_QWORD *)&this[1].fields.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//         if ( v18 )
			//         {
			//           sub_1800046C0(v11, 5LL, *(_QWORD *)(v18 + 16));
			//           v19 = System::String::Concat(v11, 0LL);
			//           v20 = sub_18003C530(&TypeInfo::System::Exception);
			//           v21 = (Exception *)sub_180004920(v20);
			//           v22 = v21;
			//           if ( v21 )
			//           {
			//             System::Exception::Exception(v21, v19, 0LL);
			//             v23 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor);
			//             sub_18000F7C0(v22, v23);
			//           }
			//         }
			//       }
			//     }
			//     else
			//     {
			//       v6 = *(List_1_System_Object_ **)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//       if ( v6 )
			//         return (IPassConstructor *)System::Collections::Generic::List<System::Object>::get_Item(
			//                                      v6,
			//                                      v5,
			//                                      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::get_Item);
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2959, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1063(Patch, (Object *)this, (PassConstructorID__Enum)v4, 0LL);
			// }
			// 
			return null;
		}

		private void UpdateShaderVariablesGlobalVFX(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void UpdateShaderVariablesGlobalVFX(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalVFX(
			//         HGRenderPathBase *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm2_4
			//   HGVFXManager *instance; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Vector3 *PlayerPosition; // rax
			//   float w; // xmm7_4
			//   __int64 v13; // xmm6_8
			//   float z; // ebx
			//   Beyond::JobMathf *v15; // rcx
			//   Vector4 *v16; // rax
			//   float v17; // xmm3_4
			//   float y; // xmm2_4
			//   float x; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float v21; // [rsp+28h] [rbp-19h]
			//   float saturation; // [rsp+38h] [rbp-9h] BYREF
			//   Vector3 value; // [rsp+40h] [rbp-1h] BYREF
			//   Vector3 v24; // [rsp+58h] [rbp+17h] BYREF
			//   Vector4 v25[3]; // [rsp+68h] [rbp+27h] BYREF
			// 
			//   if ( !byte_18D919648 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919648 = 1;
			//   }
			//   saturation = 0.0;
			//   *(_QWORD *)&value.x = 0LL;
			//   value.z = 0.0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1061, 0LL) )
			//   {
			//     instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::HGVFXManager::GetSceneColorAdjustmentParams(instance, &value, &saturation, 0LL);
			//       PlayerPosition = HG::Rendering::Runtime::HGVFXManager::GetPlayerPosition(&v24, 0LL);
			//       w = cb._GraphicsFeaturesGlobalParam1.w;
			//       v13 = *(_QWORD *)&PlayerPosition.x;
			//       z = PlayerPosition.z;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       *(_QWORD *)&v24.x = v13;
			//       v24.z = z;
			//       Beyond::JobMathf::Fmod(v15, 1024.0, v4);
			//       v16 = HG::Rendering::Runtime::HGUtils::PackVector4(v25, &v24, w, 0LL);
			//       v17 = value.z;
			//       y = value.y;
			//       v21 = saturation;
			//       x = value.x;
			//       *(__m128i *)&cb._RainWetnessGlobalParam0.y = _mm_loadu_si128((const __m128i *)v16);
			//       *(__m128i *)&cb._RainWetnessGlobalParam1.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                                        v25,
			//                                                                                        x,
			//                                                                                        y,
			//                                                                                        v17,
			//                                                                                        v21,
			//                                                                                        0LL));
			//       *(__m128i *)&cb._RainWetnessGlobalParam2.y = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGVFXManager::GetAnchorWaveBright(
			//                                                                                        v25,
			//                                                                                        0LL));
			//       *(__m128i *)&cb._AtmosphereFogParams4.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGVFXManager::GetPlayerHeights(
			//                                                                                     v25,
			//                                                                                     0LL));
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1061, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			// }
			// 
		}

		private void UpdateShaderVariablesGlobalWater(ref ShaderVariablesGlobal cb, HGSettingParameters settingParameters)
		{
			// // Void UpdateShaderVariablesGlobalWater(ShaderVariablesGlobal ByRef, HGSettingParameters)
			// void HG::Rendering::Runtime::HGRenderPathBase::UpdateShaderVariablesGlobalWater(
			//         HGRenderPathBase *this,
			//         ShaderVariablesGlobal *cb,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   float v9; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v11; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D919649 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::WaterSettings);
			//     byte_18D919649 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1062, 0LL) )
			//   {
			//     if ( settingParameters )
			//     {
			//       v9 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//              settingParameters.fields._waterPrepassTextureSize_k__BackingField,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       v11.z = 1.0 / v9;
			//       v11.x = v9;
			//       v11.y = v9;
			//       v11.w = 1.0 / v9;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::WaterSettings);
			//       TypeInfo::HG::Rendering::Runtime::WaterSettings.static_fields.prepassTextureSize = v11;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1062, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)settingParameters, 0LL);
			// }
			// 
		}

		internal virtual void Dispose(HGRenderGraph renderGraph)
		{
			// // Void Dispose(HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGRenderPathBase::Dispose(
			//         HGRenderPathBase *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase *v4; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   struct MethodInfo *v12; // rdi
			//   Il2CppClass *klass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // rax
			//   ProtocolViolationException *v18; // rbx
			//   String *v19; // rax
			//   Il2CppExceptionWrapper *v20; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v21; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v22; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D8EDB0B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     byte_18D8EDB0B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(513, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(513, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)v4,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !renderGraph )
			//       sub_180B536AC(v6, v5);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::ReleaseAllPreservedTextures(
			//       renderGraph,
			//       v4.fields._renderPathID_k__BackingField,
			//       0LL);
			//     if ( !*(_QWORD *)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 )
			//       sub_180B536AC(v8, v7);
			//     HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::ClearMaterials(
			//       *(HGRenderPipelineMaterialCollector **)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21,
			//       0LL);
			//     if ( !*(_QWORD *)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 )
			//       sub_180B536AC(v10, v9);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v21,
			//       *(List_1_System_Object_ **)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IPassConstructor>::GetEnumerator);
			//     v22 = v21;
			//     v21._list = 0LL;
			//     *(_QWORD *)&v21._index = &v22;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v22,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IPassConstructor>::MoveNext) )
			//       {
			//         if ( !v22._current )
			//           sub_1802DC2C8(0LL, v11);
			//         sub_182D12920((WaterOnePassDeferredRenderingPass *)v22._current, renderGraph);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v20 )
			//     {
			//       v21._list = (List_1_System_Object_ *)v20.ex;
			//       if ( v21._list )
			//         sub_18000F780(v21._list);
			//       v4 = this;
			//     }
			//     v12 = MethodInfo::Unity::Collections::NativeArray<int>::Dispose;
			//     klass = MethodInfo::Unity::Collections::NativeArray<int>::Dispose.klass;
			//     if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(klass);
			//     if ( *(_QWORD *)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 )
			//     {
			//       if ( !LODWORD(v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11) )
			//       {
			//         v17 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//         v18 = (ProtocolViolationException *)sub_18004C870(v17);
			//         sub_180002BF0(v18);
			//         v19 = (String *)sub_18000F7E0(&off_18D5DE980);
			//         System::Net::ProtocolViolationException::ProtocolViolationException(v18, v19, 0LL);
			//         sub_18000F7C0(v18, v12);
			//       }
			//       if ( SLODWORD(v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11) > 1 )
			//       {
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::FreeTracked(
			//           *(Void **)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20,
			//           LODWORD(v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11),
			//           0LL);
			//         v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m11 = 0.0;
			//       }
			//       *(_QWORD *)&v4[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = 0LL;
			//     }
			//   }
			// }
			// 
		}

		protected TextureHandle GetBackbufferOrIntermediate(PassConstructorID pass)
		{
			// // TextureHandle GetBackbufferOrIntermediate(PassConstructorID)
			// TextureHandle *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderPathBase *this,
			//         PassConstructorID__Enum pass,
			//         MethodInfo *method)
			// {
			//   TextureHandle *result; // rax
			//   TextureHandle intermediateBackBuffer_k__BackingField; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2961, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2961, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     intermediateBackBuffer_k__BackingField = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1064(
			//                                                 &v12,
			//                                                 Patch,
			//                                                 (Object *)this,
			//                                                 pass,
			//                                                 0LL);
			//     result = retstr;
			//   }
			//   else
			//   {
			//     result = retstr;
			//     if ( (int)pass < this.fields._firstBackbufferPass_k__BackingField )
			//       intermediateBackBuffer_k__BackingField = this.fields._intermediateBackBuffer_k__BackingField;
			//     else
			//       intermediateBackBuffer_k__BackingField = this.fields._backBufferColor_k__BackingField;
			//   }
			//   *retstr = intermediateBackBuffer_k__BackingField;
			//   return result;
			// }
			// 
			return null;
		}

		internal static HGRenderPathBase CreateRenderPath(HGRenderPathInternal renderPath, HGRenderPathBase.HGRenderPathResources resources, HGCamera camera)
		{
			// // HGRenderPathBase CreateRenderPath(HGRenderPathInternal, HGRenderPathBase+HGRenderPathResources, HGCamera)
			// HGRenderPathBase *HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
			//         HGRenderPathInternal__Enum renderPath,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   unsigned __int32 v7; // ebx
			//   HGRenderPathUI *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   HGRenderPathBase *v11; // rbx
			//   HGRenderPathDefaultDeferred *v13; // rax
			//   HGRenderPathBase *v14; // rbx
			//   unsigned __int32 v15; // ebx
			//   HGRenderPath3DUI *v16; // rax
			//   HGRenderPathBase *v17; // rbx
			//   HGRenderPathDefaultDeferred *v18; // rax
			//   HGRenderPathBase *v19; // rbx
			//   HGRenderPathOnePassDeferred *v20; // rax
			//   HGRenderPathBase *v21; // rbx
			//   HGRenderPathForward *v22; // rax
			//   HGRenderPathBase *v23; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRenderPathBase_HGRenderPathResources v25; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB0C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPath3DUI);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathDefaultDeferred);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathForward);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathOnePassDeferred);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPathUI);
			//     byte_18D8EDB0C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(662, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(662, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     v25 = *resources;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_249(Patch, renderPath, &v25, (Object *)camera, 0LL);
			//   }
			//   else if ( renderPath == HGRenderPathInternal__Enum_DefaultDeferred )
			//   {
			//     v13 = (HGRenderPathDefaultDeferred *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPathDefaultDeferred);
			//     v14 = (HGRenderPathBase *)v13;
			//     if ( !v13 )
			//       goto LABEL_11;
			//     v25 = *resources;
			//     HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(
			//       v13,
			//       &v25,
			//       camera,
			//       HGRenderPathInternal__Enum_DefaultDeferred,
			//       0LL);
			//     return v14;
			//   }
			//   else if ( renderPath )
			//   {
			//     v7 = renderPath - 1;
			//     if ( !v7 )
			//     {
			//       v8 = (HGRenderPathUI *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPathUI);
			//       v11 = (HGRenderPathBase *)v8;
			//       if ( v8 )
			//       {
			//         v25 = *resources;
			//         HG::Rendering::Runtime::HGRenderPathUI::HGRenderPathUI(v8, &v25, camera, 0LL);
			//         return v11;
			//       }
			// LABEL_11:
			//       sub_180B536AC(v10, v9);
			//     }
			//     v15 = v7 - 1;
			//     if ( v15 )
			//     {
			//       if ( v15 == 2 )
			//       {
			//         v20 = (HGRenderPathOnePassDeferred *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPathOnePassDeferred);
			//         v21 = (HGRenderPathBase *)v20;
			//         if ( !v20 )
			//           goto LABEL_11;
			//         v25 = *resources;
			//         HG::Rendering::Runtime::HGRenderPathOnePassDeferred::HGRenderPathOnePassDeferred(
			//           v20,
			//           &v25,
			//           camera,
			//           HGRenderPathInternal__Enum_OnePassDeferredSubpass,
			//           0LL);
			//         return v21;
			//       }
			//       else
			//       {
			//         v18 = (HGRenderPathDefaultDeferred *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPathDefaultDeferred);
			//         v19 = (HGRenderPathBase *)v18;
			//         if ( !v18 )
			//           goto LABEL_11;
			//         v25 = *resources;
			//         HG::Rendering::Runtime::HGRenderPathDefaultDeferred::HGRenderPathDefaultDeferred(v18, &v25, camera, 0LL);
			//         return v19;
			//       }
			//     }
			//     else
			//     {
			//       v16 = (HGRenderPath3DUI *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPath3DUI);
			//       v17 = (HGRenderPathBase *)v16;
			//       if ( !v16 )
			//         goto LABEL_11;
			//       v25 = *resources;
			//       HG::Rendering::Runtime::HGRenderPath3DUI::HGRenderPath3DUI(v16, &v25, camera, 0LL);
			//       return v17;
			//     }
			//   }
			//   else
			//   {
			//     v22 = (HGRenderPathForward *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPathForward);
			//     v23 = (HGRenderPathBase *)v22;
			//     if ( !v22 )
			//       goto LABEL_11;
			//     v25 = *resources;
			//     HG::Rendering::Runtime::HGRenderPathForward::HGRenderPathForward(v22, &v25, camera, 0LL);
			//     return v23;
			//   }
			// }
			// 
			return null;
		}

		private HGCamera m_trackingCamera;

		private bool m_trackingBackBufferState;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int s_createdCount;

		private BasicTransformConstants m_basicTransformConstants;

		private ShaderVariablesGlobal m_shaderVariablesGlobal;

		private List<IPassConstructor> m_passConstructors;

		private NativeArray<int> m_passConstructorMapping;

		internal HGRenderPipelineMaterialCollector m_materialCollector;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PerFrameSetup
		{
			internal GraphicsFormat depthGraphicsFormat;

			internal DepthBits depthBits;

			public unsafe HGSettingParametersCpp* settingParametersCpp;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct HGRenderPathParams
		{
			internal bool skipRender;

			internal HGRenderPipeline hgrp;

			internal HGRenderPipeline.RenderRequest renderRequest;

			internal HGRenderGraphParameters renderGraphParams;

			internal HGRenderPathBase.PerFrameSetup perFrameSetup;
		}

		internal enum RenderPathProfileScope
		{
			PreRendering,
			Rendering,
			PostRendering,
			Count
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct HGRenderPathResources
		{
			public HGRenderPathResources(HGRenderPipeline hgrp)
			{
			}

			public HGRenderPipelineRuntimeResources defaultResources;

			public HGSettingParameters settingParameters;
		}
	}
}
