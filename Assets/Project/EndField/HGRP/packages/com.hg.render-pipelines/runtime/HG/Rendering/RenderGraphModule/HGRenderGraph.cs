using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.RenderGraphModule
{
	public class HGRenderGraph
	{
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000025D0 File Offset: 0x000007D0
		public string name
		{
			[CompilerGenerated]
			get
			{
				// // Object <RegisterPorts>b__9_2()
				// Object *FlowCanvas::Nodes::CustomEvent<System::Object>::_RegisterPorts_b__9_2(
				//         CustomEvent_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.receivedValue;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_atlasTextures(Texture2D[])
				// void UnityEngine::TextCore::Text::FontAsset::set_atlasTextures(
				//         FontAsset *this,
				//         Texture2D__Array *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.m_AtlasTextures = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.m_AtlasTextures,
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

		// (get) Token: 0x06000146 RID: 326 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static bool requireDebugData
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_requireDebugData()
				// bool HG::Rendering::RenderGraphModule::HGRenderGraph::get_requireDebugData(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGRenderGraph__Class *v2; // rax
				// 
				//   if ( !byte_18D91931C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     byte_18D91931C = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
				//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph, v1);
				//     v2 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
				//   }
				//   return v2.static_fields._requireDebugData_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_requireDebugData(Boolean)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::set_requireDebugData(bool value, MethodInfo *method)
				// {
				//   struct HGRenderGraph__Class *v3; // rax
				// 
				//   if ( !byte_18D91931D )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     byte_18D91931D = 1;
				//   }
				//   v3 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
				//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph, method);
				//     v3 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
				//   }
				//   v3.static_fields._requireDebugData_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000148 RID: 328 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGRenderGraphDefaultResources defaultResources
		{
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
				//         Variable_1_UnityEngine_Vector2_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000149 RID: 329 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGRenderGraphContext HGContext
		{
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Keyframe>::get_propertyPath(
				//         Variable_1_UnityEngine_Keyframe_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600014A RID: 330 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGRenderGraphResourceRegistry resourceRegistry
		{
			get
			{
				// // Object get_Current()
				// Object *Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<System::Object>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600014B RID: 331 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool enableCppRenderPath
		{
			[CompilerGenerated]
			get
			{
				// // Boolean UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS()
				// bool UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS(
				//         PointerEventBase_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(Boolean)
				// void UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS(
				//         PointerEventBase_1_System_Object_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600014D RID: 333 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool enableSimpleUIRenderPath
		{
			[CompilerGenerated]
			get
			{
				// // Boolean UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer()
				// bool UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer(
				//         PointerEventBase_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(Boolean)
				// void UnityEngine::UIElements::PointerEventBase<System::Object>::UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer(
				//         PointerEventBase_1_System_Object_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField = value;
				// }
				// 
			}
		}

		// (add) Token: 0x0600014F RID: 335 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06000150 RID: 336 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static event HGRenderGraph.OnGraphRegisteredDelegate onGraphRegistered
		{
			[CompilerGenerated]
			add
			{
				// // Void add_onGraphRegistered(HGRenderGraph+OnGraphRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::add_onGraphRegistered(
				//         HGRenderGraph_OnGraphRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onGraphRegistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D919329 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     byte_18D919329 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onGraphRegistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphRegistered;
				//   do
				//   {
				//     v4 = onGraphRegistered;
				//     v5 = System::Delegate::Combine(onGraphRegistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnGraphRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onGraphRegistered = (Delegate *)sub_180011DB0(
				//                                       &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphRegistered,
				//                                       v6,
				//                                       onGraphRegistered);
				//   }
				//   while ( onGraphRegistered != v4 );
				// }
				// 
			}
			[CompilerGenerated]
			remove
			{
				// // Void remove_onGraphRegistered(HGRenderGraph+OnGraphRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::remove_onGraphRegistered(
				//         HGRenderGraph_OnGraphRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onGraphRegistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D91932A )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     byte_18D91932A = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onGraphRegistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphRegistered;
				//   do
				//   {
				//     v4 = onGraphRegistered;
				//     v5 = System::Delegate::Remove(onGraphRegistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnGraphRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onGraphRegistered = (Delegate *)sub_180011DB0(
				//                                       &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphRegistered,
				//                                       v6,
				//                                       onGraphRegistered);
				//   }
				//   while ( onGraphRegistered != v4 );
				// }
				// 
			}
		}

		// (add) Token: 0x06000151 RID: 337 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06000152 RID: 338 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static event HGRenderGraph.OnGraphRegisteredDelegate onGraphUnregistered
		{
			[CompilerGenerated]
			add
			{
				// // Void add_onGraphUnregistered(HGRenderGraph+OnGraphRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::add_onGraphUnregistered(
				//         HGRenderGraph_OnGraphRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onGraphUnregistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D91932B )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     byte_18D91932B = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onGraphUnregistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphUnregistered;
				//   do
				//   {
				//     v4 = onGraphUnregistered;
				//     v5 = System::Delegate::Combine(onGraphUnregistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnGraphRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onGraphUnregistered = (Delegate *)sub_180011DB0(
				//                                         &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphUnregistered,
				//                                         v6,
				//                                         onGraphUnregistered);
				//   }
				//   while ( onGraphUnregistered != v4 );
				// }
				// 
			}
			[CompilerGenerated]
			remove
			{
				// // Void remove_onGraphUnregistered(HGRenderGraph+OnGraphRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::remove_onGraphUnregistered(
				//         HGRenderGraph_OnGraphRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onGraphUnregistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D91932C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     byte_18D91932C = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onGraphUnregistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphUnregistered;
				//   do
				//   {
				//     v4 = onGraphUnregistered;
				//     v5 = System::Delegate::Remove(onGraphUnregistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnGraphRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnGraphRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onGraphUnregistered = (Delegate *)sub_180011DB0(
				//                                         &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphUnregistered,
				//                                         v6,
				//                                         onGraphUnregistered);
				//   }
				//   while ( onGraphUnregistered != v4 );
				// }
				// 
			}
		}

		// (add) Token: 0x06000153 RID: 339 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06000154 RID: 340 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static event HGRenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered
		{
			[CompilerGenerated]
			add
			{
				// // Void add_onExecutionRegistered(HGRenderGraph+OnExecutionRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::add_onExecutionRegistered(
				//         HGRenderGraph_OnExecutionRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onExecutionRegistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D91932D )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     byte_18D91932D = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onExecutionRegistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionRegistered;
				//   do
				//   {
				//     v4 = onExecutionRegistered;
				//     v5 = System::Delegate::Combine(onExecutionRegistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnExecutionRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onExecutionRegistered = (Delegate *)sub_180011DB0(
				//                                           &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionRegistered,
				//                                           v6,
				//                                           onExecutionRegistered);
				//   }
				//   while ( onExecutionRegistered != v4 );
				// }
				// 
			}
			[CompilerGenerated]
			remove
			{
				// // Void remove_onExecutionRegistered(HGRenderGraph+OnExecutionRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::remove_onExecutionRegistered(
				//         HGRenderGraph_OnExecutionRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onExecutionRegistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D91932E )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     byte_18D91932E = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onExecutionRegistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionRegistered;
				//   do
				//   {
				//     v4 = onExecutionRegistered;
				//     v5 = System::Delegate::Remove(onExecutionRegistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnExecutionRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onExecutionRegistered = (Delegate *)sub_180011DB0(
				//                                           &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionRegistered,
				//                                           v6,
				//                                           onExecutionRegistered);
				//   }
				//   while ( onExecutionRegistered != v4 );
				// }
				// 
			}
		}

		// (add) Token: 0x06000155 RID: 341 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06000156 RID: 342 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static event HGRenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered
		{
			[CompilerGenerated]
			add
			{
				// // Void add_onExecutionUnregistered(HGRenderGraph+OnExecutionRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::add_onExecutionUnregistered(
				//         HGRenderGraph_OnExecutionRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onExecutionUnregistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D91932F )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     byte_18D91932F = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onExecutionUnregistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionUnregistered;
				//   do
				//   {
				//     v4 = onExecutionUnregistered;
				//     v5 = System::Delegate::Combine(onExecutionUnregistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnExecutionRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onExecutionUnregistered = (Delegate *)sub_180011DB0(
				//                                             &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionUnregistered,
				//                                             v6,
				//                                             onExecutionUnregistered);
				//   }
				//   while ( onExecutionUnregistered != v4 );
				// }
				// 
			}
			[CompilerGenerated]
			remove
			{
				// // Void remove_onExecutionUnregistered(HGRenderGraph+OnExecutionRegisteredDelegate)
				// void HG::Rendering::RenderGraphModule::HGRenderGraph::remove_onExecutionUnregistered(
				//         HGRenderGraph_OnExecutionRegisteredDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *onExecutionUnregistered; // rdi
				//   Delegate *v4; // rbp
				//   Delegate *v5; // rax
				//   Delegate *v6; // rbx
				// 
				//   if ( !byte_18D919330 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     byte_18D919330 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   onExecutionUnregistered = (Delegate *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionUnregistered;
				//   do
				//   {
				//     v4 = onExecutionUnregistered;
				//     v5 = System::Delegate::Remove(onExecutionUnregistered, (Delegate *)value, 0LL);
				//     v6 = v5;
				//     if ( v5 )
				//     {
				//       if ( (struct HGRenderGraph_OnExecutionRegisteredDelegate__Class *)v5.klass != TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate )
				//         sub_1802DC21C(v5, TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::OnExecutionRegisteredDelegate);
				//     }
				//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     onExecutionUnregistered = (Delegate *)sub_180011DB0(
				//                                             &TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionUnregistered,
				//                                             v6,
				//                                             onExecutionUnregistered);
				//   }
				//   while ( onExecutionUnregistered != v4 );
				// }
				// 
			}
		}

		public HGRenderGraph([MetadataOffset(Offset = "0x01F909E0")] string name = "RenderGraph")
		{
		}

		public void Cleanup()
		{
			// // Void Cleanup()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::Cleanup(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   struct HGRenderGraph__Class *v5; // rax
			//   HGRenderGraph_OnGraphRegisteredDelegate *onGraphUnregistered; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED947 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraph>::Remove);
			//     byte_18D8ED947 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(121, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(121, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v3);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Cleanup(m_Resources, 0LL);
			//   m_Resources = (HGRenderGraphResourceRegistry *)this.fields.m_DefaultResources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::Cleanup(
			//     (HGRenderGraphDefaultResources *)m_Resources,
			//     0LL);
			//   v5 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph, v3);
			//     v5 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
			//   }
			//   m_Resources = (HGRenderGraphResourceRegistry *)v5.static_fields.s_RegisteredGraphs;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   System::Collections::Generic::List<System::Object>::Remove(
			//     (List_1_System_Object_ *)m_Resources,
			//     (Object *)this,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraph>::Remove);
			//   onGraphUnregistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onGraphUnregistered;
			//   if ( onGraphUnregistered )
			//     ((void (__fastcall *)(void *, HGRenderGraph *, void *))onGraphUnregistered.fields._._.invoke_impl)(
			//       onGraphUnregistered.fields._._.method_code,
			//       this,
			//       onGraphUnregistered.fields._._.method);
			// }
			// 
		}

		public void RegisterDebug(DebugUI.Panel panel = null)
		{
			// // Void RegisterDebug(DebugUI+Panel)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::RegisterDebug(
			//         HGRenderGraph *this,
			//         DebugUI_Panel *panel,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(125, 0LL) )
			//   {
			//     m_DebugParameters = this.fields.m_DebugParameters;
			//     if ( m_DebugParameters )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::RegisterDebug(
			//         m_DebugParameters,
			//         this.fields._name_k__BackingField,
			//         panel,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_DebugParameters, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(125, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)panel,
			//     0LL);
			// }
			// 
		}

		public void UnRegisterDebug()
		{
			// // Void UnRegisterDebug()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::UnRegisterDebug(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(127, 0LL) )
			//   {
			//     m_DebugParameters = this.fields.m_DebugParameters;
			//     if ( m_DebugParameters )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphDebugParams::UnRegisterDebug(
			//         m_DebugParameters,
			//         this.fields._name_k__BackingField,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_DebugParameters, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(127, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public static List<HGRenderGraph> GetRegisteredRenderGraphs()
		{
			// // List`1[HG.Rendering.RenderGraphModule.HGRenderGraph] GetRegisteredRenderGraphs()
			// List_1_HG_Rendering_RenderGraphModule_HGRenderGraph_ *HG::Rendering::RenderGraphModule::HGRenderGraph::GetRegisteredRenderGraphs(
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !byte_18D91931E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     byte_18D91931E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(128, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(128, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v4, v3);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_58(Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     return TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.s_RegisteredGraphs;
			//   }
			// }
			// 
			return null;
		}

		internal HGRenderGraphDebugData GetDebugData(string executionName)
		{
			// // HGRenderGraphDebugData GetDebugData(String)
			// HGRenderGraphDebugData *HG::Rendering::RenderGraphModule::HGRenderGraph::GetDebugData(
			//         HGRenderGraph *this,
			//         String *executionName,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_String_HG_Rendering_RenderGraphModule_HGRenderGraphDebugData_ *m_DebugData; // rcx
			//   bool v7; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *value; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91931F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::TryGetValue);
			//     byte_18D91931F = 1;
			//   }
			//   value = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(129, 0LL) )
			//   {
			//     m_DebugData = this.fields.m_DebugData;
			//     if ( m_DebugData )
			//     {
			//       v7 = System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
			//              (Dictionary_2_System_Object_System_Object_ *)m_DebugData,
			//              (Object *)executionName,
			//              &value,
			//              MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::TryGetValue);
			//       return (HGRenderGraphDebugData *)((unsigned __int64)value & -(__int64)v7);
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_DebugData, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(129, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59(Patch, (Object *)this, (Object *)executionName, 0LL);
			// }
			// 
			return null;
		}

		public void EndFrame()
		{
			// // Void EndFrame()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::EndFrame(HGRenderGraph *this, MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   __int64 v4; // rdx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rax
			//   HGRenderGraphDebugParams *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGRenderGraphDebugParams *v8; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_Resources = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     m_Resources = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = *(_QWORD *)m_Resources[2].monitor;
			//   if ( !v4 )
			//     goto LABEL_14;
			//   if ( *(int *)(v4 + 24) > 130 )
			//   {
			//     if ( !LODWORD(m_Resources[2].fields.m_FrameInformationLogger) )
			//     {
			//       il2cpp_runtime_class_init_0(m_Resources, v4);
			//       m_Resources = (HGRenderGraphResourceRegistry *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_Resources = *(HGRenderGraphResourceRegistry **)m_Resources[2].monitor;
			//     if ( !m_Resources )
			//       goto LABEL_14;
			//     if ( LODWORD(m_Resources.fields.m_RendererListResources) <= 0x82 )
			//       sub_180070270(m_Resources, v4);
			//     if ( m_Resources[12].fields.m_RenderGraphResources )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(130, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_14;
			//     }
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_14;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PurgeUnusedGraphicsResources(m_Resources, 0LL);
			//   m_DebugParameters = this.fields.m_DebugParameters;
			//   if ( !m_DebugParameters )
			//     goto LABEL_14;
			//   if ( m_DebugParameters.fields.logFrameInformation )
			//     m_DebugParameters.fields.logFrameInformation = 0;
			//   v6 = this.fields.m_DebugParameters;
			//   if ( !v6 )
			//     goto LABEL_14;
			//   if ( v6.fields.logResources )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::FlushLogs(m_Resources, 0LL);
			//       v8 = this.fields.m_DebugParameters;
			//       if ( v8 )
			//       {
			//         v8.fields.logResources = 0;
			//         return;
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(m_Resources, v4);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public TextureHandle ImportTexture(RTHandle rt)
		{
			// // TextureHandle ImportTexture(RTHandle)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   TextureHandle *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v11; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(134, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(134, 0LL);
			//     if ( Patch )
			//     {
			//       v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_61(&v13, Patch, (Object *)this, (Object *)rt, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, m_Resources);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(&v13, m_Resources, rt, 0LL);
			// LABEL_7:
			//   v11 = *v9;
			//   result = retstr;
			//   *retstr = v11;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public TextureHandle ImportTexture(RTHandle rt, int width, int height)
		{
			// // TextureHandle ImportTexture(RTHandle, Int32, Int32)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         RTHandle *rt,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   TextureHandle *v12; // rax
			//   TextureHandle v13; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v15; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(137, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(137, 0LL);
			//     if ( Patch )
			//     {
			//       v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_62(
			//               &v15,
			//               Patch,
			//               (Object *)this,
			//               (Object *)rt,
			//               width,
			//               height,
			//               0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v10, Patch);
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_Resources;
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v12 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportTexture(
			//           &v15,
			//           (HGRenderGraphResourceRegistry *)Patch,
			//           rt,
			//           width,
			//           height,
			//           0LL);
			// LABEL_7:
			//   v13 = *v12;
			//   result = retstr;
			//   *retstr = v13;
			//   return result;
			// }
			// 
			return null;
		}

		public TextureHandle ImportDepthbuffer(RTHandle rt)
		{
			// // TextureHandle ImportDepthbuffer(RTHandle)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportDepthbuffer(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   TextureHandle *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v11; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(139, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(139, 0LL);
			//     if ( Patch )
			//     {
			//       v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_61(&v13, Patch, (Object *)this, (Object *)rt, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, m_Resources);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportDepthbuffer(&v13, m_Resources, rt, 0LL);
			// LABEL_7:
			//   v11 = *v9;
			//   result = retstr;
			//   *retstr = v11;
			//   return result;
			// }
			// 
			return null;
		}

		public ValueTuple<TextureHandle, TextureHandle> ImportBackbuffer(RenderTargetIdentifier color, RenderTargetIdentifier depth, ref TextureDesc colorDesc, ref TextureDesc depthDesc, bool offScreen)
		{
			// // ValueTuple`2[HG.Rendering.RenderGraphModule.TextureHandle,HG.Rendering.RenderGraphModule.TextureHandle] ImportBackbuffer(RenderTargetIdentifier, RenderTargetIdentifier, TextureDesc ByRef, TextureDesc ByRef, Boolean)
			// ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportBackbuffer(
			//         ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         RenderTargetIdentifier *color,
			//         RenderTargetIdentifier *depth,
			//         TextureDesc *colorDesc,
			//         TextureDesc *depthDesc,
			//         bool offScreen,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int128 v14; // xmm1
			//   TextureHandle *v15; // rax
			//   TextureHandle v16; // xmm6
			//   __int128 v17; // xmm1
			//   TextureHandle v18; // xmm0
			//   int32_t m_DepthSlice; // eax
			//   TextureHandle v20; // xmm1
			//   __int128 v21; // xmm1
			//   __int64 v22; // xmm0_8
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ *v25; // rax
			//   TextureHandle Item2; // xmm1
			//   RenderTargetIdentifier v28; // [rsp+58h] [rbp-59h] BYREF
			//   RenderTargetIdentifier v29; // [rsp+88h] [rbp-29h] BYREF
			//   ValueTuple_2_HG_Rendering_RenderGraphModule_TextureHandle_HG_Rendering_RenderGraphModule_TextureHandle_ v30; // [rsp+B8h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919320 )
			//   {
			//     sub_18003C530(&MethodInfo::System::ValueTuple<HG::Rendering::RenderGraphModule::TextureHandle,HG::Rendering::RenderGraphModule::TextureHandle>::ValueTuple);
			//     byte_18D919320 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(141, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(141, 0LL);
			//     if ( Patch )
			//     {
			//       v21 = *(_OWORD *)&depth.m_BufferPointer;
			//       *(_OWORD *)&v28.m_Type = *(_OWORD *)&depth.m_Type;
			//       v22 = *(_QWORD *)&depth.m_DepthSlice;
			//       *(_OWORD *)&v28.m_BufferPointer = v21;
			//       v23 = *(_OWORD *)&color.m_Type;
			//       *(_QWORD *)&v28.m_DepthSlice = v22;
			//       v24 = *(_OWORD *)&color.m_BufferPointer;
			//       *(_OWORD *)&v29.m_Type = v23;
			//       *(_QWORD *)&v23 = *(_QWORD *)&color.m_DepthSlice;
			//       *(_OWORD *)&v29.m_BufferPointer = v24;
			//       *(_QWORD *)&v29.m_DepthSlice = v23;
			//       v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_64(
			//               &v30,
			//               Patch,
			//               (Object *)this,
			//               &v29,
			//               &v28,
			//               colorDesc,
			//               depthDesc,
			//               offScreen,
			//               0LL);
			//       Item2 = v25.Item2;
			//       retstr.Item1 = v25.Item1;
			//       retstr.Item2 = Item2;
			//       return retstr;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v12, Patch);
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_Resources;
			//   v29.m_DepthSlice = 0;
			//   if ( !Patch )
			//     goto LABEL_8;
			//   v14 = *(_OWORD *)&color.m_BufferPointer;
			//   *(_OWORD *)&v28.m_Type = *(_OWORD *)&color.m_Type;
			//   *(_QWORD *)&v28.m_DepthSlice = *(_QWORD *)&color.m_DepthSlice;
			//   *(_OWORD *)&v28.m_BufferPointer = v14;
			//   v15 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportBackbuffer(
			//           &v30.Item1,
			//           (HGRenderGraphResourceRegistry *)Patch,
			//           &v28,
			//           colorDesc,
			//           HGRenderGraphResourceRegistry_BackBufferType__Enum_Color,
			//           0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_Resources;
			//   v16 = *v15;
			//   if ( !Patch )
			//     goto LABEL_8;
			//   v17 = *(_OWORD *)&depth.m_BufferPointer;
			//   *(_OWORD *)&v28.m_Type = *(_OWORD *)&depth.m_Type;
			//   *(_QWORD *)&v28.m_DepthSlice = *(_QWORD *)&depth.m_DepthSlice;
			//   *(_OWORD *)&v28.m_BufferPointer = v17;
			//   v18 = *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportBackbuffer(
			//            &v30.Item1,
			//            (HGRenderGraphResourceRegistry *)Patch,
			//            &v28,
			//            depthDesc,
			//            HGRenderGraphResourceRegistry_BackBufferType__Enum_Depth,
			//            0LL);
			//   this.fields.m_backBufferInfo.color = v16;
			//   LOBYTE(v29.m_DepthSlice) = offScreen;
			//   m_DepthSlice = v29.m_DepthSlice;
			//   this.fields.m_backBufferInfo.depth = v18;
			//   *(_DWORD *)&this.fields.m_backBufferInfo.offScreen = m_DepthSlice;
			//   v20 = this.fields.m_backBufferInfo.depth;
			//   retstr.Item1 = this.fields.m_backBufferInfo.color;
			//   retstr.Item2 = v20;
			//   return retstr;
			// }
			// 
			return null;
		}

		public bool IsBackBuffer(TextureHandle rt)
		{
			// // Boolean IsBackBuffer(TextureHandle)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraph::IsBackBuffer(
			//         HGRenderGraph *this,
			//         TextureHandle *rt,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   TextureHandle v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919321 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919321 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(143, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(143, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v9 = *rt;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(Patch, (Object *)this, &v9, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     return LOWORD(rt.handle.m_Value) == LOWORD(this.fields.m_backBufferInfo.color.handle.m_Value)
			//         && !this.fields.m_backBufferInfo.offScreen;
			//   }
			// }
			// 
			return default(bool);
		}

		[IDTag(0)]
		public TextureHandle CreateTexture(ref TextureDesc desc)
		{
			// // TextureHandle CreateTexture(TextureDesc ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         TextureDesc *desc,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   TextureHandle *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v11; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(144, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(144, 0LL);
			//     if ( Patch )
			//     {
			//       v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_68(&v13, Patch, (Object *)this, desc, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, m_Resources);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(&v13, m_Resources, desc, -1, 0LL);
			// LABEL_7:
			//   v11 = *v9;
			//   result = retstr;
			//   *retstr = v11;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public TextureHandle CreateTexture(ref TextureHandle texture)
		{
			// // TextureHandle CreateTexture(TextureHandle ByRef)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rbp
			//   HGRenderGraphResourceRegistry *v9; // rcx
			//   TextureDesc *TextureResourceDescRef; // rax
			//   TextureHandle *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v13; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(147, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(147, 0LL);
			//     if ( Patch )
			//     {
			//       v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_70(&v15, Patch, (Object *)this, texture, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v9, v7);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   v9 = m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   TextureResourceDescRef = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
			//                              m_Resources,
			//                              &texture.handle,
			//                              0LL);
			//   v11 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
			//           &v15,
			//           m_Resources,
			//           TextureResourceDescRef,
			//           -1,
			//           0LL);
			// LABEL_7:
			//   v13 = *v11;
			//   result = retstr;
			//   *retstr = v13;
			//   return result;
			// }
			// 
			return null;
		}

		public void CreateTextureIfInvalid(ref TextureDesc desc, ref TextureHandle texture)
		{
			// // Void CreateTextureIfInvalid(TextureDesc ByRef, TextureHandle ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTextureIfInvalid(
			//         HGRenderGraph *this,
			//         TextureDesc *desc,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919322 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919322 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(149, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
			//       return;
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//     {
			//       *texture = *HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
			//                     &v10,
			//                     m_Resources,
			//                     desc,
			//                     -1,
			//                     0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v7, m_Resources);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(149, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_73(Patch, (Object *)this, desc, texture, 0LL);
			// }
			// 
		}

		public TextureDesc GetTextureDesc(in TextureHandle texture)
		{
			// // TextureDesc GetTextureDesc(TextureHandle ByRef)
			// TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
			//         TextureDesc *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   TextureDesc *TextureResourceDesc; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   Color clearColor; // xmm1
			//   TextureDesc *result; // rax
			//   TextureDesc v17; // [rsp+30h] [rbp-68h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(152, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(152, 0LL);
			//     if ( Patch )
			//     {
			//       TextureResourceDesc = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_75(&v17, Patch, (Object *)this, texture, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, m_Resources);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   TextureResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDesc(
			//                           &v17,
			//                           m_Resources,
			//                           &texture.handle,
			//                           0LL);
			// LABEL_7:
			//   v11 = *(_OWORD *)&TextureResourceDesc.colorFormat;
			//   *(_OWORD *)&retstr.width = *(_OWORD *)&TextureResourceDesc.width;
			//   v12 = *(_OWORD *)&TextureResourceDesc.enableRandomWrite;
			//   *(_OWORD *)&retstr.colorFormat = v11;
			//   v13 = *(_OWORD *)&TextureResourceDesc.bindTextureMS;
			//   *(_OWORD *)&retstr.enableRandomWrite = v12;
			//   v14 = *(_OWORD *)&TextureResourceDesc.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&retstr.bindTextureMS = v13;
			//   clearColor = TextureResourceDesc.clearColor;
			//   result = retstr;
			//   *(_OWORD *)&retstr.fastMemoryDesc.inFastMemory = v14;
			//   retstr.clearColor = clearColor;
			//   return result;
			// }
			// 
			return null;
		}

		public ref TextureDesc GetTextureDescRef(ref TextureHandle texture)
		{
			// // TextureDesc& GetTextureDescRef(TextureHandle ByRef)
			// TextureDesc *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//         HGRenderGraph *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(154, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//       return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
			//                m_Resources,
			//                &texture.handle,
			//                0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(154, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_76(Patch, (Object *)this, texture, 0LL);
			// }
			// 
			return null;
		}

		public TextureHandle PreserveTexture(ref TextureHandle texture, int frameCount, string info)
		{
			// // TextureHandle PreserveTexture(TextureHandle ByRef, Int32, String)
			// TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//         TextureHandle *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         TextureHandle *texture,
			//         int32_t frameCount,
			//         String *info,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGRenderGraphContext *m_RenderGraphContext; // rcx
			//   TextureHandle *v12; // rax
			//   TextureHandle v13; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v15; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(155, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(155, 0LL);
			//     if ( Patch )
			//     {
			//       v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_79(
			//               &v15,
			//               Patch,
			//               (Object *)this,
			//               texture,
			//               frameCount,
			//               (Object *)info,
			//               0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_RenderGraphContext, Patch);
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_Resources;
			//   m_RenderGraphContext = this.fields.m_RenderGraphContext;
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v12 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::PreserveTexture(
			//           &v15,
			//           (HGRenderGraphResourceRegistry *)Patch,
			//           texture,
			//           frameCount,
			//           m_RenderGraphContext,
			//           info,
			//           0LL);
			// LABEL_7:
			//   v13 = *v12;
			//   result = retstr;
			//   *retstr = v13;
			//   return result;
			// }
			// 
			return null;
		}

		public void ReleaseAllPreservedTextures(int executorID)
		{
			// // Void ReleaseAllPreservedTextures(Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ReleaseAllPreservedTextures(
			//         HGRenderGraph *this,
			//         int32_t executorID,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(162, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseAllPreservedResources(
			//         m_Resources,
			//         executorID,
			//         0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(162, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, executorID, 0LL);
			// }
			// 
		}

		internal bool TextureNeedsClear(TextureHandle texture)
		{
			// // Boolean TextureNeedsClear(TextureHandle)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraph::TextureNeedsClear(
			//         HGRenderGraph *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(164, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//       return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsClear(
			//                m_Resources,
			//                &texture.handle,
			//                0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(164, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v9 = *texture;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(Patch, (Object *)this, &v9, 0LL);
			// }
			// 
			return default(bool);
		}

		internal void MarkTextureNeedsClearFlag(TextureHandle texture, bool flag)
		{
			// // Void MarkTextureNeedsClearFlag(TextureHandle, Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::MarkTextureNeedsClearFlag(
			//         HGRenderGraph *this,
			//         TextureHandle *texture,
			//         bool flag,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(166, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::MarkTextureNeedsClearFlag(
			//         m_Resources,
			//         &texture.handle,
			//         flag,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(166, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   v10 = *texture;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81(Patch, (Object *)this, &v10, flag, 0LL);
			// }
			// 
		}

		public RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			// // RendererListHandle CreateRendererList(RendererListDesc ByRef)
			// RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//         HGRenderGraph *this,
			//         RendererListDesc *desc,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(168, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//       return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererList(m_Resources, desc, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(168, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_83(Patch, (Object *)this, desc, 0LL);
			// }
			// 
			return null;
		}

		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			// // ComputeBufferHandle ImportComputeBuffer(ComputeBuffer)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraph::ImportComputeBuffer(
			//         HGRenderGraph *this,
			//         ComputeBuffer *computeBuffer,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(171, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//       return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ImportComputeBuffer(
			//                m_Resources,
			//                computeBuffer,
			//                0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(171, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_84(Patch, (Object *)this, (Object *)computeBuffer, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc)
		{
			// // ComputeBufferHandle CreateComputeBuffer(ComputeBufferDesc ByRef)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//         HGRenderGraph *this,
			//         ComputeBufferDesc *desc,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(173, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//       return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
			//                m_Resources,
			//                desc,
			//                -1,
			//                0LL);
			// LABEL_5:
			//     sub_180B536AC(m_Resources, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(173, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_87(Patch, (Object *)this, desc, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer)
		{
			// // ComputeBufferHandle CreateComputeBuffer(ComputeBufferHandle ByRef)
			// ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraph::CreateComputeBuffer(
			//         HGRenderGraph *this,
			//         ComputeBufferHandle *computeBuffer,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rsi
			//   HGRenderGraphResourceRegistry *v7; // rdx
			//   ComputeBufferDesc *ComputeBufferResourceDesc; // rax
			//   String *name; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComputeBufferDesc desc; // [rsp+20h] [rbp-38h] BYREF
			//   ComputeBufferDesc v13; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(176, 0LL) )
			//   {
			//     m_Resources = this.fields.m_Resources;
			//     v7 = m_Resources;
			//     if ( m_Resources )
			//     {
			//       ComputeBufferResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
			//                                     &v13,
			//                                     m_Resources,
			//                                     &computeBuffer.handle,
			//                                     0LL);
			//       name = ComputeBufferResourceDesc.name;
			//       *(_OWORD *)&desc.count = *(_OWORD *)&ComputeBufferResourceDesc.count;
			//       desc.name = name;
			//       return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
			//                m_Resources,
			//                &desc,
			//                -1,
			//                0LL);
			//     }
			// LABEL_5:
			//     sub_180B536AC(v5, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(176, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(Patch, (Object *)this, computeBuffer, 0LL);
			// }
			// 
			return null;
		}

		public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer)
		{
			// // ComputeBufferDesc GetComputeBufferDesc(ComputeBufferHandle ByRef)
			// ComputeBufferDesc *HG::Rendering::RenderGraphModule::HGRenderGraph::GetComputeBufferDesc(
			//         ComputeBufferDesc *__return_ptr retstr,
			//         HGRenderGraph *this,
			//         ComputeBufferHandle *computeBuffer,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   ComputeBufferDesc *ComputeBufferResourceDesc; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v11; // xmm0
			//   String *name; // xmm1_8
			//   ComputeBufferDesc *result; // rax
			//   ComputeBufferDesc v14; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(178, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(178, 0LL);
			//     if ( Patch )
			//     {
			//       ComputeBufferResourceDesc = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_90(
			//                                     &v14,
			//                                     Patch,
			//                                     (Object *)this,
			//                                     computeBuffer,
			//                                     0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, m_Resources);
			//   }
			//   m_Resources = this.fields.m_Resources;
			//   if ( !m_Resources )
			//     goto LABEL_5;
			//   ComputeBufferResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
			//                                 &v14,
			//                                 m_Resources,
			//                                 &computeBuffer.handle,
			//                                 0LL);
			// LABEL_7:
			//   v11 = *(_OWORD *)&ComputeBufferResourceDesc.count;
			//   name = ComputeBufferResourceDesc.name;
			//   result = retstr;
			//   *(_OWORD *)&retstr.count = v11;
			//   retstr.name = name;
			//   return result;
			// }
			// 
			return null;
		}

		public HGRenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, [MetadataOffset(Offset = "0x01F909EC")] bool useNativeRenderpass = true, [MetadataOffset(Offset = "0x01F909ED")] ProfilingHGPass profilingHgPass = ProfilingHGPass.None) where PassData : class, new()
		{
			return null;
		}

		public HGRenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) where PassData : class, new()
		{
			return null;
		}

		internal void RegisterCallbackOwner(IRenderGraphCallbackOwner owner)
		{
			// // Void RegisterCallbackOwner(IRenderGraphCallbackOwner)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::RegisterCallbackOwner(
			//         HGRenderGraph *this,
			//         IRenderGraphCallbackOwner *owner,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_callbackOwner; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919323 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::Add);
			//     byte_18D919323 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(179, 0LL) )
			//   {
			//     m_callbackOwner = (List_1_System_Object_ *)this.fields.m_callbackOwner;
			//     if ( m_callbackOwner )
			//     {
			//       sub_1822AD140(m_callbackOwner, (Object *)owner);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_callbackOwner, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(179, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)owner,
			//     0LL);
			// }
			// 
		}

		internal unsafe void InvokeOwnerCallback(DynamicArray<AttachDesc> colorAttachments, object camera, void* customPayload, bool renderPassIssued)
		{
			// // Void InvokeOwnerCallback(DynamicArray`1[HG.Rendering.RenderGraphModule.AttachDesc], Object, Void*, Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::InvokeOwnerCallback(
			//         HGRenderGraph *this,
			//         DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *colorAttachments,
			//         Object *camera,
			//         Void *customPayload,
			//         bool renderPassIssued,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   Il2CppExceptionWrapper *v11; // [rsp+40h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v12; // [rsp+48h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v13; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919324 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::GetEnumerator);
			//     byte_18D919324 = 1;
			//   }
			//   if ( !this.fields.m_callbackOwner )
			//     sub_180B536AC(this, colorAttachments);
			//   System::Collections::Generic::List<System::Object>::GetEnumerator(
			//     &v12,
			//     (List_1_System_Object_ *)this.fields.m_callbackOwner,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::GetEnumerator);
			//   v13 = v12;
			//   v12._list = 0LL;
			//   *(_QWORD *)&v12._index = &v13;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v13,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::MoveNext) )
			//     {
			//       if ( !v13._current )
			//         sub_1802DC2C8(0LL, v10);
			//       sub_18859804C((HGRenderPathBase *)v13._current, this, colorAttachments, camera, customPayload, renderPassIssued);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v11 )
			//   {
			//     v12._list = (List_1_System_Object_ *)v11.ex;
			//     if ( v12._list )
			//       sub_18000F780(v12._list);
			//   }
			// }
			// 
		}

		public HGRenderGraphExecution RecordAndExecute(in HGRenderGraphParameters parameters)
		{
			// // HGRenderGraphExecution RecordAndExecute(HGRenderGraphParameters ByRef)
			// HGRenderGraphExecution HG::Rendering::RenderGraphModule::HGRenderGraph::RecordAndExecute(
			//         HGRenderGraph *this,
			//         HGRenderGraphParameters *parameters,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   int32_t executorID; // r8d
			//   OneofDescriptorProto *m_ExecutionCount; // rdx
			//   char *m_Resources; // rcx
			//   int32_t executorFrameIndex; // r9d
			//   HGRenderGraphDebugParams *m_DebugParameters; // rax
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   FileDescriptor *v15; // r8
			//   HGRenderGraphContext *m_RenderGraphContext; // r9
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   FileDescriptor *v19; // r8
			//   HGRenderGraphDebugParams *v20; // r9
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rdi
			//   int32_t Length; // eax
			//   int i; // edi
			//   List_1_System_Int32___Array *m_ImmediateModeResourceList; // rbp
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v25; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v26; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v29; // [rsp+20h] [rbp-18h]
			//   String__Array *v30; // [rsp+20h] [rbp-18h]
			//   String__Array *v31; // [rsp+20h] [rbp-18h]
			//   String__Array *v32; // [rsp+20h] [rbp-18h]
			//   String__Array *v33; // [rsp+20h] [rbp-18h]
			//   String *v34; // [rsp+28h] [rbp-10h]
			//   String *v35; // [rsp+28h] [rbp-10h]
			//   String *v36; // [rsp+28h] [rbp-10h]
			//   String *v37; // [rsp+28h] [rbp-10h]
			//   String *v38; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v39; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v40; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v41; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v42; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v43; // [rsp+30h] [rbp-8h]
			//   HGRenderGraph *v44; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919325 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_capacity);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     byte_18D919325 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(180, 0LL) )
			//   {
			//     this.fields.m_CurrentFrameIndex = parameters.currentFrameIndex;
			//     this.fields.m_CurrentExecutionName = parameters.executionName;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_CurrentExecutionName, v5, v6, v7, v29, v34, v39);
			//     executorID = parameters.executorID;
			//     m_ExecutionCount = (OneofDescriptorProto *)(unsigned int)this.fields.m_ExecutionCount;
			//     m_Resources = (char *)this.fields.m_Resources;
			//     this.fields.m_currentExecutorID = executorID;
			//     executorFrameIndex = parameters.executorFrameIndex;
			//     this.fields.m_currentExecutorFrameIndex = executorFrameIndex;
			//     this.fields.m_ExecutionCount = (_DWORD)m_ExecutionCount + 1;
			//     if ( m_Resources )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginRenderGraph(
			//         (HGRenderGraphResourceRegistry *)m_Resources,
			//         (int32_t)m_ExecutionCount,
			//         executorID,
			//         executorFrameIndex,
			//         0LL);
			//       m_DebugParameters = this.fields.m_DebugParameters;
			//       if ( m_DebugParameters )
			//       {
			//         if ( m_DebugParameters.fields.enableLogging )
			//         {
			//           m_Resources = (char *)this.fields.m_FrameInformationLogger;
			//           if ( !m_Resources )
			//             goto LABEL_32;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphLogger::Initialize(
			//             (HGRenderGraphLogger *)m_Resources,
			//             this.fields.m_CurrentExecutionName,
			//             0LL);
			//         }
			//         m_Resources = (char *)this.fields.m_DefaultResources;
			//         if ( m_Resources )
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphDefaultResources::InitializeForRendering(
			//             (HGRenderGraphDefaultResources *)m_Resources,
			//             this,
			//             0LL);
			//           m_Resources = (char *)this.fields.m_RenderGraphContext;
			//           if ( m_Resources )
			//           {
			//             *((_QWORD *)m_Resources + 3) = parameters.commandBuffer;
			//             sub_1800054D0((OneofDescriptor *)(m_Resources + 24), m_ExecutionCount, v13, v14, v30, v35, v40);
			//             m_RenderGraphContext = this.fields.m_RenderGraphContext;
			//             if ( m_RenderGraphContext )
			//             {
			//               m_RenderGraphContext.fields.renderContext.m_Ptr = parameters.scriptableRenderContext.m_Ptr;
			//               m_Resources = (char *)this.fields.m_RenderGraphContext;
			//               if ( m_Resources )
			//               {
			//                 *((_QWORD *)m_Resources + 4) = this.fields.m_RenderGraphPool;
			//                 sub_1800054D0(
			//                   (OneofDescriptor *)(m_Resources + 32),
			//                   m_ExecutionCount,
			//                   v15,
			//                   (MessageDescriptor *)m_RenderGraphContext,
			//                   v31,
			//                   v36,
			//                   v41);
			//                 m_Resources = (char *)this.fields.m_RenderGraphContext;
			//                 if ( m_Resources )
			//                 {
			//                   *((_QWORD *)m_Resources + 5) = this.fields.m_DefaultResources;
			//                   sub_1800054D0((OneofDescriptor *)(m_Resources + 40), m_ExecutionCount, v17, v18, v32, v37, v42);
			//                   v20 = this.fields.m_DebugParameters;
			//                   if ( v20 )
			//                   {
			//                     if ( !v20.fields.immediateMode )
			//                     {
			// LABEL_29:
			//                       v44 = this;
			//                       sub_1800054D0(
			//                         (OneofDescriptor *)&v44,
			//                         m_ExecutionCount,
			//                         v19,
			//                         (MessageDescriptor *)v20,
			//                         v33,
			//                         v38,
			//                         v43);
			//                       return (HGRenderGraphExecution)v44;
			//                     }
			//                     HG::Rendering::RenderGraphModule::HGRenderGraph::LogFrameInformation(this, 0LL);
			//                     m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//                     m_Resources = (char *)m_CompiledPassInfos;
			//                     if ( m_CompiledPassInfos )
			//                     {
			//                       Length = System::Threading::SparselyPopulatedArrayFragment<System::Object>::get_Length(
			//                                  (SparselyPopulatedArrayFragment_1_System_Object_ *)m_CompiledPassInfos,
			//                                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_capacity);
			//                       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
			//                         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledPassInfos,
			//                         Length,
			//                         0,
			//                         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
			//                       this.fields.m_CurrentImmediatePassIndex = 0;
			//                       for ( i = 0; i < 2; ++i )
			//                       {
			//                         m_Resources = (char *)this.fields.m_ImmediateModeResourceList;
			//                         if ( !m_Resources )
			//                           goto LABEL_32;
			//                         if ( (unsigned int)i >= *((_DWORD *)m_Resources + 6) )
			//                           goto LABEL_30;
			//                         if ( !*(_QWORD *)&m_Resources[8 * i + 32] )
			//                         {
			//                           m_ImmediateModeResourceList = this.fields.m_ImmediateModeResourceList;
			//                           v25 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//                           v26 = v25;
			//                           if ( !v25 )
			//                             goto LABEL_32;
			//                           System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//                             v25,
			//                             MethodInfo::System::Collections::Generic::List<int>::List);
			//                           sub_180036D40(m_ImmediateModeResourceList, v26);
			//                           sub_18000FDA0(m_ImmediateModeResourceList, i, v26);
			//                         }
			//                         m_Resources = (char *)this.fields.m_ImmediateModeResourceList;
			//                         if ( !m_Resources )
			//                           goto LABEL_32;
			//                         if ( (unsigned int)i >= *((_DWORD *)m_Resources + 6) )
			// LABEL_30:
			//                           sub_180070270(m_Resources, m_ExecutionCount);
			//                         m_Resources = *(char **)&m_Resources[8 * i + 32];
			//                         if ( !m_Resources )
			//                           goto LABEL_32;
			//                         ++*((_DWORD *)m_Resources + 7);
			//                         *((_DWORD *)m_Resources + 6) = 0;
			//                       }
			//                       m_Resources = (char *)this.fields.m_Resources;
			//                       if ( m_Resources )
			//                       {
			//                         HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginExecute(
			//                           (HGRenderGraphResourceRegistry *)m_Resources,
			//                           this.fields.m_CurrentFrameIndex,
			//                           0LL);
			//                         goto LABEL_29;
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
			// LABEL_32:
			//     sub_180B536AC(m_Resources, m_ExecutionCount);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(180, 0LL);
			//   if ( !Patch )
			//     goto LABEL_32;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_92(Patch, (Object *)this, parameters, 0LL);
			// }
			// 
			return null;
		}

		internal void Execute()
		{
			// // Void Execute()
			// // Hidden C++ exception states: #wind=1 #try_helpers=2
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::Execute(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v2; // rdx
			//   HGRenderGraphContext *m_RenderGraphContext; // rax
			//   HGRenderGraphDebugParams *m_DebugParameters; // rax
			//   __int64 v5; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   __int64 v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   ProtocolViolationException *v10; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   String *v14; // rax
			//   __int64 v15; // rax
			//   HGRenderGraph **v16; // [rsp+40h] [rbp-18h] BYREF
			//   HGRenderGraph *v17; // [rsp+60h] [rbp+8h] BYREF
			// 
			//   v17 = this;
			//   if ( IFix::WrappersManagerImpl::IsPatched(32, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(32, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v17, 0LL);
			//   }
			//   else
			//   {
			//     v17.fields.m_ExecutionExceptionWasRaised = 0;
			//     v16 = &v17;
			//     m_RenderGraphContext = v17.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext )
			//       sub_1802DC2C8(v17, v2);
			//     if ( !m_RenderGraphContext.fields.cmd )
			//     {
			//       v7 = sub_18003C530(&TypeInfo::System::InvalidOperationException);
			//       v10 = (ProtocolViolationException *)sub_180004920(v7);
			//       if ( v10 )
			//       {
			//         v14 = (String *)sub_18003C530(&off_18D583F98);
			//         System::Net::ProtocolViolationException::ProtocolViolationException(v10, v14, 0LL);
			//         v15 = sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::Execute);
			//         sub_18000F7C0(v10, v15);
			//       }
			//       sub_1802DC2C8(v9, v8);
			//     }
			//     m_DebugParameters = v17.fields.m_DebugParameters;
			//     if ( !m_DebugParameters )
			//       sub_1802DC2C8(v17, v2);
			//     if ( !m_DebugParameters.fields.immediateMode )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::LogFrameInformation(v17, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::CompileRenderGraph(v17, 0LL);
			//       m_Resources = v17.fields.m_Resources;
			//       if ( !m_Resources )
			//         sub_1802DC2C8(0LL, v5);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::BeginExecute(
			//         m_Resources,
			//         v17.fields.m_CurrentFrameIndex,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteRenderGraph(v17, 0LL);
			//     }
			//     sub_1821607A0(&v16);
			//   }
			// }
			// 
		}

		public void BeginProfilingSampler(ProfilingSampler sampler)
		{
			// // Void BeginProfilingSampler(ProfilingSampler)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::BeginProfilingSampler(
			//         HGRenderGraph *this,
			//         ProfilingSampler *sampler,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   __int64 v6; // rdx
			//   unsigned int v7; // edx
			//   unsigned __int64 v8; // r8
			//   char v9; // dl
			//   signed __int64 v10; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Il2CppExceptionWrapper *v14; // [rsp+48h] [rbp-50h] BYREF
			//   _QWORD v15[4]; // [rsp+50h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v16; // [rsp+70h] [rbp-28h] BYREF
			//   __int64 v17; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919326 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     sub_18003C530(&off_18D584020);
			//     byte_18D919326 = 1;
			//   }
			//   memset(&v16, 0, sizeof(v16));
			//   v17 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(198, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(198, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)sampler,
			//       0LL);
			//   }
			//   else
			//   {
			//     v16 = *(HGRenderGraphBuilder *)sub_18082E8F8(v15, this, "BeginProfile", &v17);
			//     v15[0] = 0LL;
			//     v15[1] = &v16;
			//     try
			//     {
			//       v6 = v17;
			//       if ( !v17 )
			//         sub_1802DC2C8(v5, 0LL);
			//       *(_QWORD *)(v17 + 16) = sampler;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v7 = ((unsigned __int64)(v6 + 16) >> 12) & 0x1FFFFF;
			//         v8 = (unsigned __int64)v7 >> 6;
			//         v9 = v7 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v8]);
			//         do
			//           v10 = qword_18D6870D0[v8];
			//         while ( v10 != _InterlockedCompareExchange64(&qword_18D6870D0[v8], v10 | (1LL << v9), v10) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v16, 0, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::GenerateDebugData(&v16, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v16,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.s_beginProfilingSamplerRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       v15[0] = v14.ex;
			//     }
			//     sub_180222690(v15);
			//   }
			// }
			// 
		}

		public void EndProfilingSampler(ProfilingSampler sampler)
		{
			// // Void EndProfilingSampler(ProfilingSampler)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::EndProfilingSampler(
			//         HGRenderGraph *this,
			//         ProfilingSampler *sampler,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   __int64 v6; // rdx
			//   unsigned int v7; // edx
			//   unsigned __int64 v8; // r8
			//   char v9; // dl
			//   signed __int64 v10; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Il2CppExceptionWrapper *v14; // [rsp+48h] [rbp-50h] BYREF
			//   _QWORD v15[4]; // [rsp+50h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v16; // [rsp+70h] [rbp-28h] BYREF
			//   __int64 v17; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919327 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     sub_18003C530(&off_18D583FE8);
			//     byte_18D919327 = 1;
			//   }
			//   memset(&v16, 0, sizeof(v16));
			//   v17 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(213, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(213, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)sampler,
			//       0LL);
			//   }
			//   else
			//   {
			//     v16 = *(HGRenderGraphBuilder *)sub_18082E8F8(v15, this, "EndProfile", &v17);
			//     v15[0] = 0LL;
			//     v15[1] = &v16;
			//     try
			//     {
			//       v6 = v17;
			//       if ( !v17 )
			//         sub_1802DC2C8(v5, 0LL);
			//       *(_QWORD *)(v17 + 16) = sampler;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v7 = ((unsigned __int64)(v6 + 16) >> 12) & 0x1FFFFF;
			//         v8 = (unsigned __int64)v7 >> 6;
			//         v9 = v7 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v8]);
			//         do
			//           v10 = qword_18D6870D0[v8];
			//         while ( v10 != _InterlockedCompareExchange64(&qword_18D6870D0[v8], v10 | (1LL << v9), v10) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v16, 0, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::GenerateDebugData(&v16, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v16,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.s_endProfilingSamplerRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::RenderGraphModule::HGRenderGraph::ProfilingScopePassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       v15[0] = v14.ex;
			//     }
			//     sub_180222690(v15);
			//   }
			// }
			// 
		}

		internal DynamicArray<HGRenderGraph.CompiledPassInfo> GetCompiledPassInfos()
		{
			// // DynamicArray`1[HG.Rendering.RenderGraphModule.HGRenderGraph+CompiledPassInfo] GetCompiledPassInfos()
			// DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *HG::Rendering::RenderGraphModule::HGRenderGraph::GetCompiledPassInfos(
			//         HGRenderGraph *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(214, 0LL) )
			//     return this.fields.m_CompiledPassInfos;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(214, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		internal void ClearCompiledGraph()
		{
			// // Void ClearCompiledGraph()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCompiledGraph(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   int i; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919328 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::Clear);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Clear);
			//     byte_18D919328 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(101, 0LL) )
			//   {
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::ClearRenderPasses(this, 0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCallbackOwners(this, 0LL);
			//     m_Resources = this.fields.m_Resources;
			//     if ( m_Resources )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::Clear(
			//         m_Resources,
			//         this.fields.m_ExecutionExceptionWasRaised,
			//         0LL);
			//       m_Resources = (HGRenderGraphResourceRegistry *)this.fields.m_RendererLists;
			//       if ( m_Resources )
			//       {
			//         ++HIDWORD(m_Resources.fields.m_RendererListResources);
			//         LODWORD(m_Resources.fields.m_RendererListResources) = 0;
			//         for ( i = 0; i < 2; ++i )
			//         {
			//           m_Resources = (HGRenderGraphResourceRegistry *)this.fields.m_CompiledResourcesInfos;
			//           if ( !m_Resources )
			//             goto LABEL_15;
			//           if ( (unsigned int)i >= LODWORD(m_Resources.fields.m_RendererListResources) )
			//             sub_180070270(m_Resources, v3);
			//           m_Resources = (HGRenderGraphResourceRegistry *)*((_QWORD *)&m_Resources.fields.m_RenderGraphDebug + i);
			//           if ( !m_Resources )
			//             goto LABEL_15;
			//           UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//             (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_Resources,
			//             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::Clear);
			//         }
			//         m_Resources = (HGRenderGraphResourceRegistry *)this.fields.m_CompiledPassInfos;
			//         if ( m_Resources )
			//         {
			//           UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Clear(
			//             (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_Resources,
			//             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Clear);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(m_Resources, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(101, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void InvalidateContext()
		{
		}

		internal void OnPassAdded(HGRenderGraphPass pass)
		{
			// // Void OnPassAdded(HGRenderGraphPass)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::OnPassAdded(
			//         HGRenderGraph *this,
			//         HGRenderGraphPass *pass,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(207, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(207, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)pass,
			//         0LL);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   m_DebugParameters = this.fields.m_DebugParameters;
			//   if ( !m_DebugParameters )
			//     goto LABEL_6;
			//   if ( m_DebugParameters.fields.immediateMode )
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::ExecutePassImmediatly(this, pass, 0LL);
			// }
			// 
		}

		private void InitResourceInfosData(DynamicArray<HGRenderGraph.CompiledResourceInfo> resourceInfos, int count)
		{
			// // Void InitResourceInfosData(DynamicArray`1[HG.Rendering.RenderGraphModule.HGRenderGraph+CompiledResourceInfo], Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::InitResourceInfosData(
			//         HGRenderGraph *this,
			//         DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *resourceInfos,
			//         int32_t count,
			//         MethodInfo *method)
			// {
			//   int32_t v4; // ebx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   HGRenderGraph_CompiledResourceInfo *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = 0;
			//   if ( !byte_18D919331 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::Resize);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_size);
			//     byte_18D919331 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(38, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(38, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(
			//         (ILFixDynamicMethodWrapper_16 *)Patch,
			//         (Object *)this,
			//         (Object *)resourceInfos,
			//         count,
			//         0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v9, v8);
			//   }
			//   if ( !resourceInfos )
			//     goto LABEL_9;
			//   UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
			//     (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)resourceInfos,
			//     count,
			//     0,
			//     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::Resize);
			//   while ( v4 < resourceInfos.fields._size_k__BackingField )
			//   {
			//     Item = (HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                                                    (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)resourceInfos,
			//                                                    v4,
			//                                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo::Reset(Item, 0LL);
			//     ++v4;
			//   }
			// }
			// 
		}

		private void InitializeCompilationData()
		{
			// // Void InitializeCompilationData()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::InitializeCompilationData(
			//         HGRenderGraph *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v6; // rdi
			//   int32_t TextureResourceCount; // eax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v8; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo_ *v9; // rdi
			//   int32_t ComputeBufferResourceCount; // eax
			//   List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *m_RenderPasses; // rax
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   RenderGraph_CompiledPassInfo *Item; // rax
			//   HGRenderGraph_CompiledPassInfo *v15; // rsi
			//   Object *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919332 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
			//     byte_18D919332 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(36, 0LL) )
			//   {
			//     m_CompiledResourcesInfos = this.fields.m_CompiledResourcesInfos;
			//     if ( !m_CompiledResourcesInfos )
			//       goto LABEL_19;
			//     if ( m_CompiledResourcesInfos.max_length.size )
			//     {
			//       m_Resources = this.fields.m_Resources;
			//       v6 = m_CompiledResourcesInfos.vector[0];
			//       if ( !m_Resources )
			//         goto LABEL_19;
			//       TextureResourceCount = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceCount(
			//                                m_Resources,
			//                                0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::InitResourceInfosData(this, v6, TextureResourceCount, 0LL);
			//       v8 = this.fields.m_CompiledResourcesInfos;
			//       if ( !v8 )
			//         goto LABEL_19;
			//       if ( v8.max_length.size > 1u )
			//       {
			//         m_Resources = this.fields.m_Resources;
			//         v9 = v8.vector[1];
			//         if ( m_Resources )
			//         {
			//           ComputeBufferResourceCount = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceCount(
			//                                          m_Resources,
			//                                          0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::InitResourceInfosData(
			//             this,
			//             v9,
			//             ComputeBufferResourceCount,
			//             0LL);
			//           m_RenderPasses = this.fields.m_RenderPasses;
			//           m_Resources = (HGRenderGraphResourceRegistry *)this.fields.m_CompiledPassInfos;
			//           if ( m_RenderPasses )
			//           {
			//             if ( m_Resources )
			//             {
			//               UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
			//                 (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_Resources,
			//                 m_RenderPasses.fields._size,
			//                 0,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
			//               for ( i = 0; ; ++i )
			//               {
			//                 m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//                 if ( !m_CompiledPassInfos )
			//                   break;
			//                 if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//                   return;
			//                 Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                          (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos,
			//                          i,
			//                          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//                 m_Resources = (HGRenderGraphResourceRegistry *)this.fields.m_RenderPasses;
			//                 v15 = (HGRenderGraph_CompiledPassInfo *)Item;
			//                 if ( !m_Resources )
			//                   break;
			//                 v16 = System::Collections::Generic::List<System::Object>::get_Item(
			//                         (List_1_System_Object_ *)m_Resources,
			//                         i,
			//                         MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
			//                 HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::Reset(
			//                   v15,
			//                   (HGRenderGraphPass *)v16,
			//                   0LL);
			//               }
			//             }
			//           }
			//         }
			// LABEL_19:
			//         sub_180B536AC(m_Resources, v3);
			//       }
			//     }
			//     sub_180070270(m_Resources, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(36, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void CountReferences()
		{
			// // Void CountReferences()
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CountReferences(HGRenderGraph *this, MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // r14
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v3; // rdx
			//   _QWORD *p_klass; // rcx
			//   int32_t i; // esi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   RenderGraph_CompiledPassInfo *Item; // r15
			//   int j; // edi
			//   unsigned int v9; // r13d
			//   List_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rbx
			//   __int64 v11; // rax
			//   __int64 v12; // r8
			//   __int64 v13; // r9
			//   UIInertiaViewPager_InertiaBlocker current; // rbx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rax
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v16; // r12
			//   int32_t v17; // eax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // rdx
			//   RenderGraph_CompiledResourceInfo *v21; // rbx
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   __int64 v23; // rdx
			//   List_1_System_Int32_ *consumers; // rcx
			//   RenderGraphPass__Class *klass; // rax
			//   __int64 v26; // rdx
			//   unsigned int v27; // r13d
			//   __int64 v28; // rcx
			//   UIInertiaViewPager_InertiaBlocker v29; // rbx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v30; // rax
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v31; // r12
			//   int32_t v32; // eax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rdx
			//   RenderGraph_CompiledResourceInfo *v36; // rbx
			//   HGRenderGraphResourceRegistry *v37; // rcx
			//   __int64 v38; // rdx
			//   UIInertiaViewPager_InertiaBlocker v39; // rbx
			//   int32_t v40; // eax
			//   __int64 v41; // rcx
			//   __int64 v42; // r9
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v43; // rdx
			//   __int64 size; // rcx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v45; // rcx
			//   __int64 v46; // rdx
			//   RenderGraph_CompiledResourceInfo *v47; // rbx
			//   List_1_System_Int32_ *v48; // rcx
			//   __int64 v49; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   _BYTE v53[32]; // [rsp+0h] [rbp-F8h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v54; // [rsp+20h] [rbp-D8h] BYREF
			//   int v55; // [rsp+38h] [rbp-C0h]
			//   int v56; // [rsp+3Ch] [rbp-BCh]
			//   unsigned int v57; // [rsp+40h] [rbp-B8h]
			//   unsigned int v58; // [rsp+44h] [rbp-B4h]
			//   RenderGraph_CompiledPassInfo *v59; // [rsp+48h] [rbp-B0h]
			//   ResourceHandle res; // [rsp+50h] [rbp-A8h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v61; // [rsp+60h] [rbp-98h] BYREF
			//   Il2CppException *ex; // [rsp+78h] [rbp-80h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v63; // [rsp+80h] [rbp-78h]
			//   Il2CppException *v64; // [rsp+88h] [rbp-70h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v65; // [rsp+90h] [rbp-68h]
			//   Il2CppException *v66; // [rsp+98h] [rbp-60h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v67; // [rsp+A0h] [rbp-58h]
			//   Il2CppExceptionWrapper *v68; // [rsp+A8h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v69; // [rsp+B0h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v70; // [rsp+B8h] [rbp-40h] BYREF
			//   int32_t v72; // [rsp+118h] [rbp+20h]
			// 
			//   v2 = this;
			//   if ( !byte_18D919333 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919333 = 1;
			//   }
			//   memset(&v54, 0, sizeof(v54));
			//   if ( IFix::WrappersManagerImpl::IsPatched(43, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(43, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v52, v51);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       v72 = i;
			//       m_CompiledPassInfos = v2.fields.m_CompiledPassInfos;
			//       if ( !m_CompiledPassInfos )
			// LABEL_79:
			//         sub_1802DC2C8(p_klass, v3);
			//       if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//         break;
			//       Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v2.fields.m_CompiledPassInfos,
			//                i,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//       v59 = Item;
			//       for ( j = 0; ; ++j )
			//       {
			//         v58 = j;
			//         v57 = j;
			//         v56 = j;
			//         v9 = j;
			//         v55 = j;
			//         if ( j >= 2 )
			//           break;
			//         if ( !Item.pass )
			//           sub_180B536AC(p_klass, v3);
			//         dependsOnRendererListList = Item.pass.fields.dependsOnRendererListList;
			//         if ( !dependsOnRendererListList )
			//           sub_180B536AC(p_klass, v3);
			//         if ( (unsigned int)j >= dependsOnRendererListList.fields._size )
			//           sub_180070270(p_klass, v3);
			//         v11 = *((_QWORD *)&dependsOnRendererListList.fields._syncRoot + j);
			//         if ( !v11 )
			//           sub_180B536AC(p_klass, v3);
			//         v54 = *(List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *)sub_18082EA30(&v61, v11);
			//         ex = 0LL;
			//         v63 = &v54;
			//         try
			//         {
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                     &v54,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//           {
			//             current = v54._current;
			//             res = (ResourceHandle)v54._current;
			//             m_CompiledResourcesInfos = v2.fields.m_CompiledResourcesInfos;
			//             if ( !m_CompiledResourcesInfos )
			//               sub_1802DC2C8(p_klass, v3);
			//             if ( (unsigned int)j >= m_CompiledResourcesInfos.max_length.size )
			//               sub_180070260(p_klass, v3, v12, v13);
			//             v16 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos.vector[j];
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//             v17 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//             if ( !v16 )
			//               sub_1802DC2C8(v19, v18);
			//             v21 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                     v16,
			//                     v17,
			//                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//             m_Resources = v2.fields.m_Resources;
			//             if ( !m_Resources )
			//               sub_1802DC2C8(0LL, v20);
			//             v21.imported = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
			//                               m_Resources,
			//                               &res,
			//                               0LL);
			//             consumers = v21.consumers;
			//             if ( !consumers )
			//               sub_1802DC2C8(0LL, v23);
			//             sub_18231EF50(consumers, i);
			//             ++v21.refCount;
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v68 )
			//         {
			//           v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v53;
			//           ex = v68.ex;
			//           p_klass = &ex.object.klass;
			//           if ( ex )
			//             sub_18000F780(ex);
			//           v2 = this;
			//           i = v72;
			//           Item = v59;
			//           v9 = v55;
			//         }
			//         if ( !Item.pass )
			//           goto LABEL_79;
			//         klass = Item.pass[1].klass;
			//         if ( !klass )
			//           goto LABEL_79;
			//         v26 = j;
			//         if ( v9 >= LODWORD(klass._0.namespaze) )
			//           goto LABEL_78;
			//         v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)&klass._0.byval_arg.data.dummy
			//                                                                               + j);
			//         if ( !v3 )
			//           goto LABEL_79;
			//         System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//           (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v61,
			//           v3,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//         v54 = v61;
			//         v64 = 0LL;
			//         v65 = &v54;
			//         try
			//         {
			//           v27 = v56;
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                     &v54,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//           {
			//             v29 = v54._current;
			//             res = (ResourceHandle)v54._current;
			//             v30 = v2.fields.m_CompiledResourcesInfos;
			//             if ( !v30 )
			//               sub_1802DC2C8(v28, v3);
			//             if ( v27 >= v30.max_length.size )
			//               sub_180070260(v28, v3, v12, v13);
			//             v31 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v30.vector[j];
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//             v32 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v29, 0LL);
			//             if ( !v31 )
			//               sub_1802DC2C8(v34, v33);
			//             v36 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                     v31,
			//                     v32,
			//                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//             v37 = v2.fields.m_Resources;
			//             if ( !v37 )
			//               sub_1802DC2C8(0LL, v35);
			//             v36.imported = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
			//                               v37,
			//                               &res,
			//                               0LL);
			//             if ( !v36.producers )
			//               sub_1802DC2C8(0LL, v38);
			//             sub_18231EF50(v36.producers, i);
			//             Item.hasSideEffect = v36.imported;
			//             ++Item.refCount;
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v69 )
			//         {
			//           v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v53;
			//           v64 = v69.ex;
			//           if ( v64 )
			//             sub_18000F780(v64);
			//           v2 = this;
			//           i = v72;
			//           Item = v59;
			//         }
			//         p_klass = &Item.pass.klass;
			//         if ( !Item.pass )
			//           goto LABEL_79;
			//         p_klass = (_QWORD *)p_klass[17];
			//         if ( !p_klass )
			//           goto LABEL_79;
			//         v26 = j;
			//         if ( v57 >= *((_DWORD *)p_klass + 6) )
			// LABEL_78:
			//           sub_180070260(p_klass, v26, v12, v13);
			//         v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)p_klass[j + 4];
			//         if ( !v3 )
			//           goto LABEL_79;
			//         System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//           (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v61,
			//           v3,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//         v54 = v61;
			//         v66 = 0LL;
			//         v67 = &v54;
			//         try
			//         {
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                     &v54,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//           {
			//             v39 = v54._current;
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//             v40 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v39, 0LL);
			//             v43 = v2.fields.m_CompiledResourcesInfos;
			//             if ( !v43 )
			//               sub_1802DC2C8(v41, 0LL);
			//             size = (unsigned int)v43.max_length.size;
			//             if ( v58 >= (unsigned int)size )
			//               sub_180070260(size, v43, j, v42);
			//             v45 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v43.vector[j];
			//             if ( !v45 )
			//               sub_1802DC2C8(0LL, v43);
			//             v47 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                     v45,
			//                     v40,
			//                     MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//             ++v47.refCount;
			//             v48 = v47.consumers;
			//             if ( !v48 )
			//               sub_1802DC2C8(0LL, v46);
			//             sub_18231EF50(v48, i);
			//             if ( !v47.producers )
			//               sub_1802DC2C8(0LL, v49);
			//             sub_18231EF50(v47.producers, i);
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v70 )
			//         {
			//           v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v53;
			//           v66 = v70.ex;
			//           p_klass = &v66.object.klass;
			//           if ( v66 )
			//             sub_18000F780(v66);
			//           v2 = this;
			//           i = v72;
			//           Item = v59;
			//         }
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void CullUnusedPasses()
		{
			// // Void CullUnusedPasses()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CullUnusedPasses(HGRenderGraph *this, MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // rsi
			//   __int64 *v3; // rdx
			//   Il2CppException *v4; // rcx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rbx
			//   int i; // r14d
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rbx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v8; // r15
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v9; // r12
			//   Stack_1_System_Int32_ *m_CullingStack; // rbx
			//   int32_t j; // ebx
			//   Stack_1_System_Int32_ *v12; // rax
			//   int32_t v13; // eax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   RenderGraph_CompiledResourceInfo *Item; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rcx
			//   HGRenderGraph_CompiledPassInfo *v20; // rax
			//   HGRenderGraph_CompiledPassInfo *v21; // rbx
			//   int v22; // ecx
			//   __int64 v23; // rdx
			//   __int64 v24; // r8
			//   __int64 v25; // r9
			//   List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceReadLists; // rcx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v27; // rdx
			//   UIInertiaViewPager_InertiaBlocker current; // rbx
			//   int32_t v29; // eax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   RenderGraph_CompiledResourceInfo *v32; // rax
			//   int v33; // ecx
			//   Stack_1_System_Int32_ *v34; // r13
			//   int32_t v35; // eax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   HGRenderGraphLogger *m_FrameInformationLogger; // rbx
			//   Object__Array *v39; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   __int64 v45; // [rsp+0h] [rbp-D8h] BYREF
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v46; // [rsp+28h] [rbp-B0h]
			//   List_1_T_Enumerator_System_UInt32_ v47; // [rsp+30h] [rbp-A8h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v48; // [rsp+48h] [rbp-90h] BYREF
			//   List_1_T_Enumerator_System_Int32_ v49; // [rsp+60h] [rbp-78h] BYREF
			//   Il2CppException *ex; // [rsp+78h] [rbp-60h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v51; // [rsp+80h] [rbp-58h]
			//   Il2CppException *v52; // [rsp+88h] [rbp-50h]
			//   List_1_T_Enumerator_System_UInt32_ *v53; // [rsp+90h] [rbp-48h]
			//   Il2CppExceptionWrapper *v54; // [rsp+98h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v55; // [rsp+A0h] [rbp-38h] BYREF
			//   int v57; // [rsp+F0h] [rbp+18h]
			//   unsigned int v58; // [rsp+F8h] [rbp+20h]
			// 
			//   v2 = this;
			//   if ( !byte_18D919334 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<int>::Pop);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<int>::Push);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<int>::get_Count);
			//     sub_18003C530(&off_18D5839C0);
			//     byte_18D919334 = 1;
			//   }
			//   memset(&v47, 0, sizeof(v47));
			//   memset(&v48, 0, sizeof(v48));
			//   if ( IFix::WrappersManagerImpl::IsPatched(49, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(49, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v44, v43);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     m_DebugParameters = v2.fields.m_DebugParameters;
			//     if ( !m_DebugParameters )
			//       sub_180B536AC(v4, v3);
			//     if ( m_DebugParameters.fields.disablePassCulling )
			//     {
			//       if ( m_DebugParameters.fields.enableLogging )
			//       {
			//         m_FrameInformationLogger = v2.fields.m_FrameInformationLogger;
			//         v39 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//         if ( !m_FrameInformationLogger )
			//           sub_180B536AC(v41, v40);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//           m_FrameInformationLogger,
			//           (String *)"- Pass Culling Disabled -\n",
			//           v39,
			//           0LL);
			//       }
			//     }
			//     else
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         v57 = i;
			//         v58 = i;
			//         if ( i >= 2 )
			//           break;
			//         m_CompiledResourcesInfos = v2.fields.m_CompiledResourcesInfos;
			//         if ( !m_CompiledResourcesInfos )
			//           sub_180B536AC(v4, v3);
			//         if ( (unsigned int)i >= m_CompiledResourcesInfos.max_length.size )
			//           sub_180070270(v4, v3);
			//         v8 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos.vector[i];
			//         v9 = v8;
			//         v46 = v8;
			//         m_CullingStack = v2.fields.m_CullingStack;
			//         if ( !m_CullingStack )
			//           sub_180B536AC(v4, v3);
			//         m_CullingStack.fields._size = 0;
			//         ++m_CullingStack.fields._version;
			//         for ( j = 0; ; ++j )
			//         {
			//           if ( !v8 )
			//             sub_180B536AC(v4, v3);
			//           if ( j >= v8.fields._size_k__BackingField )
			//             break;
			//           if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                   v8,
			//                   j,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item).refCount )
			//           {
			//             if ( !v2.fields.m_CullingStack )
			//               sub_180B536AC(v4, v3);
			//             System::Collections::Generic::Stack<int>::Push(
			//               v2.fields.m_CullingStack,
			//               j,
			//               MethodInfo::System::Collections::Generic::Stack<int>::Push);
			//           }
			//         }
			//         while ( 1 )
			//         {
			//           v12 = v2.fields.m_CullingStack;
			//           if ( !v12 )
			//             sub_1802DC2C8(v4, v3);
			//           if ( !v12.fields._size )
			//             break;
			//           v13 = System::Collections::Generic::Stack<int>::Pop(
			//                   v2.fields.m_CullingStack,
			//                   MethodInfo::System::Collections::Generic::Stack<int>::Pop);
			//           if ( !v9 )
			//             sub_180B536AC(v15, v14);
			//           Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                    v9,
			//                    v13,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//           *(_QWORD *)&v49._current = *(_QWORD *)&Item.refCount;
			//           if ( !Item.producers )
			//             sub_180B536AC(v18, v17);
			//           System::Collections::Generic::List<int>::GetEnumerator(
			//             &v49,
			//             Item.producers,
			//             MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//           v47 = (List_1_T_Enumerator_System_UInt32_)v49;
			//           v52 = 0LL;
			//           v53 = &v47;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                       &v47,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//             {
			//               m_CompiledPassInfos = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v2.fields.m_CompiledPassInfos;
			//               if ( !m_CompiledPassInfos )
			//                 sub_1802DC2C8(0LL, v3);
			//               v20 = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                                         m_CompiledPassInfos,
			//                                                         v47._current,
			//                                                         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//               v21 = v20;
			//               v22 = v20.refCount - 1;
			//               v20.refCount = v22;
			//               if ( !v22
			//                 && !v20.hasSideEffect
			//                 && HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::get_allowPassCulling(v20, 0LL) )
			//               {
			//                 v21.culled = 1;
			//                 if ( !v21.pass )
			//                   sub_1802DC2C8(0LL, v23);
			//                 resourceReadLists = v21.pass.fields.resourceReadLists;
			//                 if ( !resourceReadLists )
			//                   sub_1802DC2C8(0LL, v23);
			//                 if ( v58 >= resourceReadLists.max_length.size )
			//                   sub_180070260(resourceReadLists, i, v24, v25);
			//                 v27 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)resourceReadLists.vector[i];
			//                 if ( !v27 )
			//                   sub_1802DC2C8(resourceReadLists, 0LL);
			//                 System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//                   (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v49,
			//                   v27,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//                 v48 = (List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_)v49;
			//                 ex = 0LL;
			//                 v51 = &v48;
			//                 try
			//                 {
			//                   while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                             &v48,
			//                             MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//                   {
			//                     current = v48._current;
			//                     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//                     v29 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//                     if ( !v9 )
			//                       sub_1802DC2C8(v31, v30);
			//                     v32 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                             v9,
			//                             v29,
			//                             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//                     v33 = v32.refCount - 1;
			//                     v32.refCount = v33;
			//                     if ( !v33 )
			//                     {
			//                       v34 = v2.fields.m_CullingStack;
			//                       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//                       v35 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//                       if ( !v34 )
			//                         sub_1802DC2C8(v37, v36);
			//                       System::Collections::Generic::Stack<int>::Push(
			//                         v34,
			//                         v35,
			//                         MethodInfo::System::Collections::Generic::Stack<int>::Push);
			//                     }
			//                   }
			//                 }
			//                 catch ( Il2CppExceptionWrapper *v54 )
			//                 {
			//                   ex = v54.ex;
			//                   if ( ex )
			//                     sub_18000F780(ex);
			//                   v2 = this;
			//                   i = v57;
			//                   v9 = v46;
			//                 }
			//               }
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v55 )
			//           {
			//             v3 = &v45;
			//             v52 = v55.ex;
			//             v4 = v52;
			//             if ( v52 )
			//               sub_18000F780(v52);
			//             v2 = this;
			//             i = v57;
			//             v9 = v46;
			//           }
			//         }
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::LogCulledPasses(v2, 0LL);
			//     }
			//   }
			// }
			// 
		}

		internal bool CheckIfResBeenUpdated(ResourceHandle resource, int passIndex)
		{
			// // Boolean CheckIfResBeenUpdated(ResourceHandle, Int32)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraph::CheckIfResBeenUpdated(
			//         HGRenderGraph *this,
			//         ResourceHandle resource,
			//         int32_t passIndex,
			//         MethodInfo *method)
			// {
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rsi
			//   int32_t iType; // eax
			//   __int64 v10; // rdx
			//   List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *producers; // rcx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v12; // rsi
			//   int32_t v13; // eax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v14; // rsi
			//   int32_t v15; // eax
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v16; // rsi
			//   int32_t v17; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v20; // [rsp+58h] [rbp+10h] BYREF
			// 
			//   v20 = resource;
			//   if ( !byte_18D919335 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919335 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(215, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(215, 0LL);
			//     if ( !Patch )
			// LABEL_20:
			//       sub_180B536AC(producers, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(Patch, (Object *)this, resource, passIndex, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_CompiledResourcesInfos = this.fields.m_CompiledResourcesInfos;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//       iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v20, 0LL);
			//       if ( !m_CompiledResourcesInfos )
			//         goto LABEL_20;
			//       if ( (unsigned int)iType >= m_CompiledResourcesInfos.max_length.size )
			//         goto LABEL_18;
			//       v12 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos.vector[iType];
			//       v13 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(resource, 0LL);
			//       if ( !v12 )
			//         goto LABEL_20;
			//       producers = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                                                                                          v12,
			//                                                                                          v13,
			//                                                                                          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item).producers;
			//       if ( !producers )
			//         goto LABEL_20;
			//       if ( i >= producers.fields._size )
			//         break;
			//       v14 = this.fields.m_CompiledResourcesInfos;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//       v15 = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v20, 0LL);
			//       if ( !v14 )
			//         goto LABEL_20;
			//       if ( (unsigned int)v15 >= v14.max_length.size )
			// LABEL_18:
			//         sub_180070270(producers, v10);
			//       v16 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v14.vector[v15];
			//       v17 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(resource, 0LL);
			//       if ( !v16 )
			//         goto LABEL_20;
			//       producers = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                                                                                          v16,
			//                                                                                          v17,
			//                                                                                          MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item).producers;
			//       if ( !producers )
			//         goto LABEL_20;
			//       if ( *(_DWORD *)&System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                          producers,
			//                          i,
			//                          MethodInfo::System::Collections::Generic::List<int>::get_Item) < passIndex )
			//         return 1;
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		internal bool CheckIfResWillBeUsed(ResourceHandle resource, int passIndex)
		{
			// // Boolean CheckIfResWillBeUsed(ResourceHandle, Int32)
			// bool HG::Rendering::RenderGraphModule::HGRenderGraph::CheckIfResWillBeUsed(
			//         HGRenderGraph *this,
			//         ResourceHandle resource,
			//         int32_t passIndex,
			//         MethodInfo *method)
			// {
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rdi
			//   int32_t iType; // eax
			//   __int64 v9; // rdx
			//   List_1_System_Int32_ *consumers; // rcx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v11; // rdi
			//   int32_t v12; // eax
			//   RenderGraph_CompiledResourceInfo *Item; // rax
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v15; // rsi
			//   int32_t v16; // eax
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v17; // rsi
			//   int32_t v18; // eax
			//   int32_t j; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v20; // rsi
			//   int32_t v21; // eax
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v22; // rsi
			//   int32_t v23; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v26; // [rsp+30h] [rbp-48h]
			//   ResourceHandle v27; // [rsp+88h] [rbp+10h] BYREF
			// 
			//   v27 = resource;
			//   if ( !byte_18D919336 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919336 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(216, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(216, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(Patch, (Object *)this, resource, passIndex, 0LL);
			// LABEL_30:
			//     sub_180B536AC(consumers, v9);
			//   }
			//   m_CompiledResourcesInfos = this.fields.m_CompiledResourcesInfos;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//   iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v27, 0LL);
			//   if ( !m_CompiledResourcesInfos )
			//     goto LABEL_30;
			//   if ( (unsigned int)iType >= m_CompiledResourcesInfos.max_length.size )
			// LABEL_28:
			//     sub_180070270(consumers, v9);
			//   v11 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos.vector[iType];
			//   v12 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(resource, 0LL);
			//   if ( !v11 )
			//     goto LABEL_30;
			//   Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//            v11,
			//            v12,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//   v26 = *(_OWORD *)&Item.producers;
			//   if ( (unsigned __int8)BYTE4(*(_QWORD *)&Item.refCount) )
			//     return 1;
			//   for ( i = 0; ; ++i )
			//   {
			//     if ( !*((_QWORD *)&v26 + 1) )
			//       goto LABEL_30;
			//     if ( i >= *(_DWORD *)(*((_QWORD *)&v26 + 1) + 24LL) )
			//       break;
			//     v15 = this.fields.m_CompiledResourcesInfos;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     v16 = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v27, 0LL);
			//     if ( !v15 )
			//       goto LABEL_30;
			//     if ( (unsigned int)v16 >= v15.max_length.size )
			//       goto LABEL_28;
			//     v17 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v15.vector[v16];
			//     v18 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(resource, 0LL);
			//     if ( !v17 )
			//       goto LABEL_30;
			//     consumers = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                   v17,
			//                   v18,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item).consumers;
			//     if ( !consumers )
			//       goto LABEL_30;
			//     if ( *(_DWORD *)&System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                        (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)consumers,
			//                        i,
			//                        MethodInfo::System::Collections::Generic::List<int>::get_Item) > passIndex )
			//       return 1;
			//   }
			//   for ( j = 0; ; ++j )
			//   {
			//     if ( !(_QWORD)v26 )
			//       goto LABEL_30;
			//     if ( j >= *(_DWORD *)(v26 + 24) )
			//       break;
			//     v20 = this.fields.m_CompiledResourcesInfos;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     v21 = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v27, 0LL);
			//     if ( !v20 )
			//       goto LABEL_30;
			//     if ( (unsigned int)v21 >= v20.max_length.size )
			//       goto LABEL_28;
			//     v22 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v20.vector[v21];
			//     v23 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(resource, 0LL);
			//     if ( !v22 )
			//       goto LABEL_30;
			//     consumers = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                   v22,
			//                   v23,
			//                   MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item).producers;
			//     if ( !consumers )
			//       goto LABEL_30;
			//     if ( *(_DWORD *)&System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                        (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)consumers,
			//                        j,
			//                        MethodInfo::System::Collections::Generic::List<int>::get_Item) > passIndex )
			//       return 1;
			//   }
			//   return 0;
			// }
			// 
			return default(bool);
		}

		private void UpdatePassSynchronization(ref HGRenderGraph.CompiledPassInfo currentPassInfo, ref HGRenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex)
		{
			// // Void UpdatePassSynchronization(HGRenderGraph+CompiledPassInfo ByRef, HGRenderGraph+CompiledPassInfo ByRef, Int32, Int32, Int32 ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdatePassSynchronization(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledPassInfo *currentPassInfo,
			//         HGRenderGraph_CompiledPassInfo *producerPassInfo,
			//         int32_t currentPassIndex,
			//         int32_t lastProducer,
			//         int32_t *intLastSyncIndex,
			//         MethodInfo *method)
			// {
			//   bool v11; // zf
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(70, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(70, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
			//       Patch,
			//       (Object *)this,
			//       currentPassInfo,
			//       producerPassInfo,
			//       currentPassIndex,
			//       lastProducer,
			//       intLastSyncIndex,
			//       0LL);
			//   }
			//   else
			//   {
			//     currentPassInfo.syncToPassIndex = lastProducer;
			//     *intLastSyncIndex = lastProducer;
			//     v11 = producerPassInfo.syncFromPassIndex == -1;
			//     producerPassInfo.needGraphicsFence = 1;
			//     if ( v11 )
			//       producerPassInfo.syncFromPassIndex = currentPassIndex;
			//   }
			// }
			// 
		}

		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in HGRenderGraph.CompiledResourceInfo resource)
		{
			// // Void UpdateResourceSynchronization(Int32 ByRef, Int32 ByRef, Int32, HGRenderGraph+CompiledResourceInfo ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceSynchronization(
			//         HGRenderGraph *this,
			//         int32_t *lastGraphicsPipeSync,
			//         int32_t *lastComputePipeSync,
			//         int32_t currentPassIndex,
			//         HGRenderGraph_CompiledResourceInfo *resource,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   int32_t lastProducer; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   RenderGraph_CompiledPassInfo *Item; // rax
			//   HGRenderGraph_CompiledPassInfo *v14; // rbp
			//   RenderGraph_CompiledPassInfo *v15; // rax
			//   bool enableAsyncCompute; // cl
			//   HGRenderGraph_CompiledPassInfo *v17; // rax
			//   HGRenderGraph_CompiledPassInfo *v18; // rax
			// 
			//   if ( !byte_18D919337 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     byte_18D919337 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(68, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(68, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_38(
			//         Patch,
			//         (Object *)this,
			//         lastGraphicsPipeSync,
			//         lastComputePipeSync,
			//         currentPassIndex,
			//         resource,
			//         0LL);
			//       return;
			//     }
			// LABEL_17:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   lastProducer = HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestProducerIndex(
			//                    this,
			//                    currentPassIndex,
			//                    resource,
			//                    0LL);
			//   if ( lastProducer == -1 )
			//     return;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_CompiledPassInfos;
			//   if ( !Patch )
			//     goto LABEL_17;
			//   Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
			//            currentPassIndex,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_CompiledPassInfos;
			//   v14 = (HGRenderGraph_CompiledPassInfo *)Item;
			//   if ( !Patch )
			//     goto LABEL_17;
			//   v15 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//           (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
			//           lastProducer,
			//           MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//   enableAsyncCompute = v14.enableAsyncCompute;
			//   if ( v15.enableAsyncCompute == enableAsyncCompute )
			//     return;
			//   if ( enableAsyncCompute )
			//   {
			//     if ( lastProducer <= *lastGraphicsPipeSync )
			//       return;
			//     Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_CompiledPassInfos;
			//     if ( Patch )
			//     {
			//       v18 = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                                 (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
			//                                                 lastProducer,
			//                                                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::UpdatePassSynchronization(
			//         this,
			//         v14,
			//         v18,
			//         currentPassIndex,
			//         lastProducer,
			//         lastGraphicsPipeSync,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_17;
			//   }
			//   if ( lastProducer <= *lastComputePipeSync )
			//     return;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_CompiledPassInfos;
			//   if ( !Patch )
			//     goto LABEL_17;
			//   v17 = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                             (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)Patch,
			//                                             lastProducer,
			//                                             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//   HG::Rendering::RenderGraphModule::HGRenderGraph::UpdatePassSynchronization(
			//     this,
			//     v14,
			//     v17,
			//     currentPassIndex,
			//     lastProducer,
			//     lastComputePipeSync,
			//     0LL);
			// }
			// 
		}

		private int GetLatestProducerIndex(int passIndex, in HGRenderGraph.CompiledResourceInfo info)
		{
			// // Int32 GetLatestProducerIndex(Int32, HGRenderGraph+CompiledResourceInfo ByRef)
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestProducerIndex(
			//         HGRenderGraph *this,
			//         int32_t passIndex,
			//         HGRenderGraph_CompiledResourceInfo *info,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t current; // ebx
			//   List_1_System_Int32_ *producers; // rdi
			//   bool v11; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   int32_t v16; // [rsp+30h] [rbp-48h]
			//   Il2CppExceptionWrapper *v17; // [rsp+38h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v18; // [rsp+40h] [rbp-38h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v19; // [rsp+58h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919338 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     byte_18D919338 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(69, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(69, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_36(Patch, (Object *)this, passIndex, info, 0LL);
			//   }
			//   current = -1;
			//   v16 = -1;
			//   producers = info.producers;
			//   if ( !producers )
			//     sub_180B536AC(v8, v7);
			//   System::Collections::Generic::List<int>::GetEnumerator(
			//     (List_1_T_Enumerator_System_Int32_ *)&v18,
			//     producers,
			//     MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//   v19 = v18;
			//   v18._list = 0LL;
			//   *(_QWORD *)&v18._index = &v19;
			//   while ( 1 )
			//   {
			//     try
			//     {
			//       v11 = System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//               &v19,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     }
			//     catch ( Il2CppExceptionWrapper *v17 )
			//     {
			//       v18._list = (List_1_System_UInt32_ *)v17.ex;
			//       if ( v18._list )
			//         sub_18000F780(v18._list);
			//       return v16;
			//     }
			//     if ( !v11 || (int)v19._current >= passIndex )
			//       return current;
			//     current = v19._current;
			//     v16 = v19._current;
			//   }
			// }
			// 
			return 0;
		}

		private int GetLatestValidReadIndex(in HGRenderGraph.CompiledResourceInfo info)
		{
			// // Int32 GetLatestValidReadIndex(HGRenderGraph+CompiledResourceInfo ByRef)
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidReadIndex(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledResourceInfo *info,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_System_Int32_ *consumers; // rax
			//   int32_t size; // ebx
			//   List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v9; // rdi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rbp
			//   RegexCharClass_SingleRange Item; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919339 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     byte_18D919339 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(72, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(72, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_39(Patch, (Object *)this, info, 0LL);
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   consumers = info.consumers;
			//   if ( !consumers )
			//     goto LABEL_13;
			//   if ( consumers.fields._size )
			//   {
			//     size = consumers.fields._size;
			//     v9 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)consumers;
			//     while ( --size >= 0 )
			//     {
			//       m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//       Item = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                v9,
			//                size,
			//                MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       if ( !m_CompiledPassInfos )
			//         goto LABEL_13;
			//       if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//               *(_DWORD *)&Item,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled )
			//         return (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                           v9,
			//                           size,
			//                           MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     }
			//   }
			//   return -1;
			// }
			// 
			return 0;
		}

		private int GetFirstValidWriteIndex(in HGRenderGraph.CompiledResourceInfo info)
		{
			// // Int32 GetFirstValidWriteIndex(HGRenderGraph+CompiledResourceInfo ByRef)
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetFirstValidWriteIndex(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledResourceInfo *info,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *producers; // rdi
			//   int32_t i; // ebx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rbp
			//   RegexCharClass_SingleRange Item; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91933A )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     byte_18D91933A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(71, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(71, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_39(Patch, (Object *)this, info, 0LL);
			// LABEL_14:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !info.producers )
			//     goto LABEL_14;
			//   if ( info.producers.fields._size )
			//   {
			//     producers = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)info.producers;
			//     for ( i = 0; i < producers.fields._size; ++i )
			//     {
			//       m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//       Item = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                producers,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       if ( !m_CompiledPassInfos )
			//         goto LABEL_14;
			//       if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//               *(_DWORD *)&Item,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled )
			//         return (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                           producers,
			//                           i,
			//                           MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     }
			//   }
			//   return -1;
			// }
			// 
			return 0;
		}

		private int GetLatestValidWriteIndex(in HGRenderGraph.CompiledResourceInfo info)
		{
			// // Int32 GetLatestValidWriteIndex(HGRenderGraph+CompiledResourceInfo ByRef)
			// int32_t HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidWriteIndex(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledResourceInfo *info,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_System_Int32_ *producers; // rax
			//   int32_t size; // ebx
			//   List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v9; // rdi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rbp
			//   RegexCharClass_SingleRange Item; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91933B )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     byte_18D91933B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(73, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(73, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_39(Patch, (Object *)this, info, 0LL);
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   producers = info.producers;
			//   if ( !info.producers )
			//     goto LABEL_13;
			//   if ( producers.fields._size )
			//   {
			//     size = producers.fields._size;
			//     v9 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)producers;
			//     while ( --size >= 0 )
			//     {
			//       m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//       Item = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                v9,
			//                size,
			//                MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//       if ( !m_CompiledPassInfos )
			//         goto LABEL_13;
			//       if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//               *(_DWORD *)&Item,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled )
			//         return (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                           v9,
			//                           size,
			//                           MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     }
			//   }
			//   return -1;
			// }
			// 
			return 0;
		}

		private void CreateRendererLists()
		{
			// // Void CreateRendererLists()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererLists(HGRenderGraph *this, MethodInfo *method)
			// {
			//   RenderGraphPass *pass; // rdx
			//   List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *m_RendererLists; // rcx
			//   int32_t i; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   RenderGraph_CompiledPassInfo *Item; // rax
			//   HGRenderGraphContext *m_RenderGraphContext; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91933C )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::AddRange);
			//     byte_18D91933C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(56, 0LL) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//       if ( !m_CompiledPassInfos )
			//         goto LABEL_16;
			//       if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//         break;
			//       Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos,
			//                i,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//       if ( !Item.culled )
			//       {
			//         pass = Item.pass;
			//         if ( !Item.pass )
			//           goto LABEL_16;
			//         m_RendererLists = this.fields.m_RendererLists;
			//         if ( !m_RendererLists )
			//           goto LABEL_16;
			//         System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::AddRange(
			//           m_RendererLists,
			//           (IEnumerable_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)pass[1].fields._name_k__BackingField,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::AddRange);
			//       }
			//     }
			//     m_RenderGraphContext = this.fields.m_RenderGraphContext;
			//     m_RendererLists = (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)this.fields.m_Resources;
			//     if ( m_RenderGraphContext && m_RendererLists )
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererLists(
			//         (HGRenderGraphResourceRegistry *)m_RendererLists,
			//         this.fields.m_RendererLists,
			//         m_RenderGraphContext.fields.renderContext,
			//         1,
			//         0LL);
			//       return;
			//     }
			// LABEL_16:
			//     sub_180B536AC(m_RendererLists, pass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(56, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void UpdateResourceAllocationAndSynchronization()
		{
			// // Void UpdateResourceAllocationAndSynchronization()
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceAllocationAndSynchronization(
			//         HGRenderGraph *this,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // r15
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v3; // rdx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *producers; // rcx
			//   __int64 v5; // r8
			//   __int64 v6; // r9
			//   int32_t i; // r14d
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   HGRenderGraph *v9; // r13
			//   RenderGraph_CompiledPassInfo *Item; // r13
			//   int j; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rbx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v13; // r12
			//   List_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rbx
			//   __int64 v15; // rax
			//   UIInertiaViewPager_InertiaBlocker current; // rbx
			//   int32_t v17; // eax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   HGRenderGraph_CompiledResourceInfo *resource; // rax
			//   RenderGraphPass__Class *klass; // rax
			//   UIInertiaViewPager_InertiaBlocker v22; // rbx
			//   int32_t v23; // eax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   HGRenderGraph_CompiledResourceInfo *v26; // rax
			//   int32_t v27; // edi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v28; // rax
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v29; // rax
			//   __int64 v30; // rbx
			//   int32_t v31; // r14d
			//   int32_t v32; // eax
			//   int32_t LatestValidReadIndex; // ebx
			//   int32_t v34; // r12d
			//   RenderGraph_CompiledPassInfo *v35; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v36; // r9
			//   int32_t syncFromPassIndex; // r12d
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v38; // rax
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *v39; // rax
			//   List_1_System_Object_ *m_RenderPasses; // rbx
			//   MethodInfo *v41; // rax
			//   Object *v42; // rax
			//   String *v43; // rdi
			//   String *v44; // rbx
			//   String *v45; // rax
			//   String *v46; // r14
			//   __int64 v47; // rbx
			//   __int64 *v48; // rax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   __int64 v51; // rdx
			//   ProtocolViolationException *v52; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   __int64 v56; // rax
			//   _BYTE v57[32]; // [rsp+0h] [rbp-108h] BYREF
			//   __int64 (__fastcall *v58)(_QWORD, _QWORD); // [rsp+28h] [rbp-E0h]
			//   int32_t lastComputePipeSync; // [rsp+30h] [rbp-D8h] BYREF
			//   int32_t lastGraphicsPipeSync; // [rsp+34h] [rbp-D4h] BYREF
			//   unsigned int v61; // [rsp+38h] [rbp-D0h]
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v62; // [rsp+40h] [rbp-C8h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v63; // [rsp+48h] [rbp-C0h] BYREF
			//   HGRenderGraph_CompiledResourceInfo info; // [rsp+60h] [rbp-A8h] BYREF
			//   RenderGraph_CompiledPassInfo *v65; // [rsp+80h] [rbp-88h]
			//   HGRenderGraph *v66; // [rsp+88h] [rbp-80h]
			//   Il2CppException *ex; // [rsp+A0h] [rbp-68h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v68; // [rsp+A8h] [rbp-60h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v69; // [rsp+B0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v70; // [rsp+C8h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v71; // [rsp+D0h] [rbp-38h] BYREF
			//   __int64 *index; // [rsp+120h] [rbp+18h] BYREF
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *v74; // [rsp+128h] [rbp+20h] BYREF
			// 
			//   v2 = this;
			//   v66 = this;
			//   if ( !byte_18D91933D )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D91933D = 1;
			//   }
			//   memset(&v63, 0, sizeof(v63));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(67, 0LL) )
			//   {
			//     lastGraphicsPipeSync = -1;
			//     lastComputePipeSync = -1;
			//     for ( i = 0; ; ++i )
			//     {
			//       LODWORD(v74) = i;
			//       m_CompiledPassInfos = v2.fields.m_CompiledPassInfos;
			//       if ( !m_CompiledPassInfos )
			//         goto LABEL_112;
			//       v9 = v66;
			//       if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//         break;
			//       Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v66.fields.m_CompiledPassInfos,
			//                i,
			//                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//       v65 = Item;
			//       if ( !Item.culled )
			//       {
			//         for ( j = 0; ; ++j )
			//         {
			//           LODWORD(index) = j;
			//           v61 = j;
			//           if ( j >= 2 )
			//             break;
			//           m_CompiledResourcesInfos = v2.fields.m_CompiledResourcesInfos;
			//           if ( !m_CompiledResourcesInfos )
			//             sub_180B536AC(producers, v3);
			//           if ( (unsigned int)j >= m_CompiledResourcesInfos.max_length.size )
			//             sub_180070270(producers, v3);
			//           v13 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)m_CompiledResourcesInfos.vector[j];
			//           v62 = v13;
			//           if ( !Item.pass )
			//             sub_180B536AC(producers, v3);
			//           dependsOnRendererListList = Item.pass.fields.dependsOnRendererListList;
			//           if ( !dependsOnRendererListList )
			//             sub_180B536AC(producers, v3);
			//           if ( (unsigned int)j >= dependsOnRendererListList.fields._size )
			//             sub_180070270(producers, v3);
			//           v15 = *((_QWORD *)&dependsOnRendererListList.fields._syncRoot + j);
			//           if ( !v15 )
			//             sub_180B536AC(producers, v3);
			//           v63 = *(List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *)sub_18082EA30(&v69, v15);
			//           ex = 0LL;
			//           v68 = &v63;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                       &v63,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//             {
			//               current = v63._current;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//               v17 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//               if ( !v13 )
			//                 sub_1802DC2C8(v19, v18);
			//               resource = (HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                                                                  v13,
			//                                                                  v17,
			//                                                                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//               HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceSynchronization(
			//                 v2,
			//                 &lastGraphicsPipeSync,
			//                 &lastComputePipeSync,
			//                 i,
			//                 resource,
			//                 0LL);
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v70 )
			//           {
			//             v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v57;
			//             ex = v70.ex;
			//             producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)ex;
			//             if ( ex )
			//               sub_18000F780(ex);
			//             v2 = this;
			//             i = (int)v74;
			//             Item = v65;
			//             j = (int)index;
			//             v13 = v62;
			//           }
			//           if ( !Item.pass )
			//             goto LABEL_112;
			//           klass = Item.pass[1].klass;
			//           if ( !klass )
			//             goto LABEL_112;
			//           v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)j;
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v61;
			//           if ( v61 >= LODWORD(klass._0.namespaze) )
			//             goto LABEL_111;
			//           v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)&klass._0.byval_arg.data.dummy
			//                                                                                 + j);
			//           if ( !v3 )
			//             goto LABEL_112;
			//           System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//             (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v69,
			//             v3,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//           v63 = v69;
			//           info.producers = 0LL;
			//           info.consumers = (List_1_System_Int32_ *)&v63;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                       &v63,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//             {
			//               v22 = v63._current;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//               v23 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v22, 0LL);
			//               if ( !v13 )
			//                 sub_1802DC2C8(v25, v24);
			//               v26 = (HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                                                             v13,
			//                                                             v23,
			//                                                             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//               HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceSynchronization(
			//                 v2,
			//                 &lastGraphicsPipeSync,
			//                 &lastComputePipeSync,
			//                 i,
			//                 v26,
			//                 0LL);
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v71 )
			//           {
			//             v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v57;
			//             info.producers = (List_1_System_Int32_ *)v71.ex;
			//             producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)info.producers;
			//             if ( info.producers )
			//               sub_18000F780(info.producers);
			//             v2 = this;
			//             i = (int)v74;
			//             Item = v65;
			//             j = (int)index;
			//           }
			//         }
			//       }
			//     }
			//     v27 = 0;
			//     while ( 1 )
			//     {
			//       v28 = v2.fields.m_CompiledResourcesInfos;
			//       if ( !v28 )
			//         goto LABEL_112;
			//       producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v27;
			//       if ( (unsigned int)v27 >= v28.max_length.size )
			// LABEL_111:
			//         sub_180070260(producers, v3, v5, v6);
			//       v29 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v28.vector[v27];
			//       v62 = v29;
			//       v30 = v27;
			//       v31 = 0;
			//       if ( !v29 )
			// LABEL_112:
			//         sub_1802DC2C8(producers, v3);
			//       while ( v31 < v29.fields._size_k__BackingField )
			//       {
			//         info = *(HGRenderGraph_CompiledResourceInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                                                         v29,
			//                                                         v31,
			//                                                         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//         v32 = HG::Rendering::RenderGraphModule::HGRenderGraph::GetFirstValidWriteIndex(v2, &info, 0LL);
			//         LODWORD(index) = v32;
			//         if ( v32 != -1 )
			//         {
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos;
			//           if ( !producers )
			//             goto LABEL_112;
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(producers, v32, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).resourceCreateList;
			//           if ( !producers )
			//             goto LABEL_112;
			//           if ( (unsigned int)v27 >= producers.fields._size_k__BackingField )
			//             goto LABEL_111;
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)*((_QWORD *)&producers[1].klass + v30);
			//           if ( !producers )
			//             goto LABEL_112;
			//           sub_18231EF50((List_1_System_Int32_ *)producers, v31);
			//         }
			//         LatestValidReadIndex = HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidReadIndex(v2, &info, 0LL);
			//         v34 = HG::Rendering::RenderGraphModule::HGRenderGraph::GetLatestValidWriteIndex(v2, &info, 0LL);
			//         if ( (_DWORD)index == -1 )
			//         {
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)HIDWORD(*(_QWORD *)&info.refCount);
			//           if ( !info.imported )
			//             goto LABEL_74;
			//         }
			//         sub_180002C70(TypeInfo::System::Math);
			//         if ( v34 >= LatestValidReadIndex )
			//           LatestValidReadIndex = v34;
			//         if ( LatestValidReadIndex == -1 )
			//           goto LABEL_74;
			//         producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos;
			//         if ( !producers )
			//           goto LABEL_112;
			//         v35 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                 producers,
			//                 LatestValidReadIndex,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//         v36 = v9.fields.m_CompiledPassInfos;
			//         if ( v35.enableAsyncCompute )
			//         {
			//           if ( !v36 )
			//             goto LABEL_112;
			//           syncFromPassIndex = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                 (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos,
			//                                 LatestValidReadIndex,
			//                                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).syncFromPassIndex;
			//           LODWORD(index) = LatestValidReadIndex;
			//           if ( syncFromPassIndex == -1 )
			//           {
			//             LODWORD(index) = LatestValidReadIndex;
			//             do
			//             {
			//               v38 = v9.fields.m_CompiledPassInfos;
			//               if ( !v38 )
			//                 goto LABEL_112;
			//               if ( LatestValidReadIndex >= v38.fields._size_k__BackingField )
			//                 break;
			//               if ( UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                      (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos,
			//                      ++LatestValidReadIndex,
			//                      MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).enableAsyncCompute )
			//               {
			//                 producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos;
			//                 if ( !producers )
			//                   goto LABEL_112;
			//                 syncFromPassIndex = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                       producers,
			//                                       LatestValidReadIndex,
			//                                       MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).syncFromPassIndex;
			//               }
			//             }
			//             while ( syncFromPassIndex == -1 );
			//           }
			//           v74 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos;
			//           sub_180002C70(TypeInfo::System::Math);
			//           v3 = 0LL;
			//           if ( syncFromPassIndex - 1 > 0 )
			//             v3 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)(unsigned int)(syncFromPassIndex - 1);
			//           if ( !v74 )
			//             goto LABEL_112;
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(v74, (int32_t)v3, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).resourceReleaseList;
			//           if ( !producers )
			//             goto LABEL_112;
			//           if ( (unsigned int)v27 >= producers.fields._size_k__BackingField )
			//             goto LABEL_111;
			//           producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)*((_QWORD *)&producers[1].klass + v27);
			//           if ( !producers )
			//             goto LABEL_112;
			//           sub_18231EF50((List_1_System_Int32_ *)producers, v31);
			//           v39 = v9.fields.m_CompiledPassInfos;
			//           if ( !v39 )
			//             goto LABEL_112;
			//           if ( LatestValidReadIndex == v39.fields._size_k__BackingField )
			//           {
			//             m_RenderPasses = (List_1_System_Object_ *)v2.fields.m_RenderPasses;
			//             if ( m_RenderPasses )
			//             {
			//               v41 = (MethodInfo *)sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
			//               v42 = System::Collections::Generic::List<System::Object>::get_Item(m_RenderPasses, (int32_t)index, v41);
			//               if ( v42 )
			//               {
			//                 v43 = (String *)v42[1].klass;
			//                 v44 = (String *)sub_18003C530(&off_18D583830);
			//                 v45 = (String *)sub_18003C530(&off_18D583828);
			//                 v46 = System::String::Concat(v45, v43, v44, 0LL);
			//                 v47 = sub_18003C530(&TypeInfo::System::InvalidOperationException);
			//                 if ( (*(_BYTE *)(v47 + 312) & 2) == 0 )
			//                 {
			//                   index = &qword_18CDB0B30;
			//                   sub_1802924D0(&qword_18CDB0B30);
			//                   sub_180060090(v47, &index);
			//                   sub_180292530(index);
			//                 }
			//                 if ( *(_QWORD *)(v47 + 96) && (*(_BYTE *)(v47 + 312) & 8) != 0 )
			//                   v47 = *(_QWORD *)(v47 + 64);
			//                 if ( (*(_BYTE *)(v47 + 312) & 0x20) != 0 )
			//                 {
			//                   v50 = *(unsigned int *)(v47 + 248);
			//                   if ( *(_QWORD *)(v47 + 8) )
			//                   {
			//                     v48 = (__int64 *)sub_180005220(v50, v47);
			//                   }
			//                   else
			//                   {
			//                     v51 = 1LL;
			//                     if ( dword_18D8E43FC == 1 )
			//                       v51 = 4LL;
			//                     v48 = (__int64 *)sub_18002D3D0(v50, v51);
			//                     *v48 = v47;
			//                   }
			//                   _InterlockedIncrement64(&qword_18D8E51F8);
			//                 }
			//                 else
			//                 {
			//                   v48 = (__int64 *)sub_180005FB0(v47);
			//                 }
			//                 v52 = (ProtocolViolationException *)v48;
			//                 if ( (*(_BYTE *)(v47 + 313) & 2) != 0 )
			//                 {
			//                   v58 = mono_thread_suspend_all_other_threads;
			//                   sub_18002E8C0((_DWORD)v48, (unsigned int)sub_18007DC30, 0, (unsigned int)&v74, (__int64)&index);
			//                 }
			//                 if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//                   sub_1802DAEC4(v52, v47);
			//                 il2cpp_runtime_class_init_0(v47, v49);
			//                 if ( v52 )
			//                 {
			//                   System::Net::ProtocolViolationException::ProtocolViolationException(v52, v46, 0LL);
			//                   v56 = sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceAllocationAndSynchronization);
			//                   sub_18000F7C0(v52, v56);
			//                 }
			//               }
			//             }
			//             goto LABEL_112;
			//           }
			// LABEL_74:
			//           v30 = v27;
			//           goto LABEL_75;
			//         }
			//         if ( !v36 )
			//           goto LABEL_112;
			//         producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item((DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v9.fields.m_CompiledPassInfos, LatestValidReadIndex, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).resourceReleaseList;
			//         if ( !producers )
			//           goto LABEL_112;
			//         if ( (unsigned int)v27 >= producers.fields._size_k__BackingField )
			//           goto LABEL_111;
			//         v30 = v27;
			//         producers = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)*((_QWORD *)&producers[1].klass + v27);
			//         if ( !producers )
			//           goto LABEL_112;
			//         sub_18231EF50((List_1_System_Int32_ *)producers, v31);
			// LABEL_75:
			//         ++v31;
			//         v29 = v62;
			//       }
			//       if ( ++v27 >= 2 )
			//         return;
			//     }
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(67, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v55, v54);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			// }
			// 
		}

		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists)
		{
			// // Boolean AreRendererListsEmpty(List`1[HG.Rendering.RenderGraphModule.RendererListHandle])
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// bool HG::Rendering::RenderGraphModule::HGRenderGraph::AreRendererListsEmpty(
			//         HGRenderGraph *this,
			//         List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *rendererLists,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rcx
			//   HGRenderGraphResourceRegistry *m_Resources; // rdx
			//   RendererList *RendererList; // rax
			//   __int64 v10; // rdx
			//   HGRenderGraphContext *m_RenderGraphContext; // rcx
			//   ScriptableRenderContext *p_renderContext; // rsi
			//   RendererList v13; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   RendererList v18; // [rsp+40h] [rbp-58h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v19; // [rsp+50h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v20; // [rsp+68h] [rbp-30h] BYREF
			//   UIInertiaViewPager_InertiaBlocker current; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91933E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::get_Count);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D91933E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(64, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(64, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)rendererLists,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !rendererLists )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//       (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v19,
			//       (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)rendererLists,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
			//     v20 = v19;
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//               &v20,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext) )
			//     {
			//       current = v20._current;
			//       m_Resources = this.fields.m_Resources;
			//       if ( !m_Resources )
			//         sub_1802DC2C8(v7, 0LL);
			//       RendererList = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRendererList(
			//                        (RendererList *)&v19,
			//                        m_Resources,
			//                        (RendererListHandle *)&current,
			//                        0LL);
			//       m_RenderGraphContext = this.fields.m_RenderGraphContext;
			//       if ( !m_RenderGraphContext )
			//         sub_1802DC2C8(0LL, v10);
			//       p_renderContext = &m_RenderGraphContext.fields.renderContext;
			//       v13 = *RendererList;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v18 = v13;
			//       if ( UnityEngine::Rendering::ScriptableRenderContext::QueryRendererListStatus(p_renderContext, &v18, 0LL) == RendererListStatus__Enum_kRendererListPopulated )
			//         return 0;
			//     }
			//     return rendererLists.fields._size > 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private void TryCullPassAtIndex(int passIndex)
		{
			// // Void TryCullPassAtIndex(Int32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::TryCullPassAtIndex(
			//         HGRenderGraph *this,
			//         int32_t passIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rcx
			//   RenderGraph_CompiledPassInfo *Item; // rax
			//   RenderGraphPass *pass; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91933F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     byte_18D91933F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(61, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(61, 0LL);
			//     if ( !Patch )
			//       goto LABEL_17;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, passIndex, 0LL);
			//   }
			//   else
			//   {
			//     m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//     if ( !m_CompiledPassInfos )
			//       goto LABEL_17;
			//     Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//              (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//              passIndex,
			//              MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//     pass = Item.pass;
			//     if ( !m_CompiledPassInfos )
			//       goto LABEL_17;
			//     if ( UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//            (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//            passIndex,
			//            MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled )
			//       return;
			//     if ( !pass )
			//       goto LABEL_17;
			//     if ( BYTE1(pass.fields._depthBuffer_k__BackingField.handle.m_Value) && BYTE5(pass.fields.usedRendererListList) )
			//     {
			//       m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//       if ( !m_CompiledPassInfos )
			//         goto LABEL_17;
			//       if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//               passIndex,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).hasSideEffect
			//         && (HG::Rendering::RenderGraphModule::HGRenderGraph::AreRendererListsEmpty(
			//               this,
			//               (List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *)pass[1].fields._name_k__BackingField,
			//               0LL)
			//          || HG::Rendering::RenderGraphModule::HGRenderGraph::AreRendererListsEmpty(
			//               this,
			//               *(List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ **)&pass[1].fields._index_k__BackingField,
			//               0LL)) )
			//       {
			//         m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//         if ( m_CompiledPassInfos )
			//         {
			//           UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//             (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)m_CompiledPassInfos,
			//             passIndex,
			//             MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled = 1;
			//           return;
			//         }
			// LABEL_17:
			//         sub_180B536AC(m_CompiledPassInfos, v5);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void CullRendererLists()
		{
			// // Void CullRendererLists()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CullRendererLists(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *pass; // rcx
			//   int32_t i; // ebx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   RenderGraph_CompiledPassInfo__Array *m_Array; // rax
			//   __int64 v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919340 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::get_Count);
			//     byte_18D919340 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(60, 0LL) )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//       if ( !m_CompiledPassInfos )
			//         break;
			//       if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//         return;
			//       if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//               (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos,
			//               i,
			//               MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled )
			//       {
			//         pass = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos;
			//         if ( !pass )
			//           break;
			//         if ( !UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                 pass,
			//                 i,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).hasSideEffect )
			//         {
			//           pass = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos;
			//           if ( !pass )
			//             break;
			//           pass = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(pass, i, MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).pass;
			//           if ( !pass )
			//             break;
			//           m_Array = pass[4].fields.m_Array;
			//           if ( !m_Array )
			//             break;
			//           if ( m_Array.max_length.size > 0 )
			//             goto LABEL_16;
			//           v8 = *(_QWORD *)&pass[4].fields._size_k__BackingField;
			//           if ( !v8 )
			//             break;
			//           if ( *(int *)(v8 + 24) > 0 )
			// LABEL_16:
			//             HG::Rendering::RenderGraphModule::HGRenderGraph::TryCullPassAtIndex(this, i, 0LL);
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(pass, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(60, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void CompileRenderGraph()
		{
			// // Void CompileRenderGraph()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CompileRenderGraph(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Il2CppExceptionWrapper *v8; // [rsp+20h] [rbp-28h] BYREF
			//   Il2CppException *ex; // [rsp+28h] [rbp-20h]
			//   char *v10; // [rsp+30h] [rbp-18h]
			//   char v11; // [rsp+60h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919341 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//     byte_18D919341 = 1;
			//   }
			//   v11 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(35, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(35, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_RenderGraphContext )
			//       sub_180B536AC(v4, v3);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//     ex = 0LL;
			//     v10 = &v11;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::InitializeCompilationData(this, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::CountReferences(this, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::CullUnusedPasses(this, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererLists(this, 0LL);
			//       if ( this.fields.m_RendererListCulling )
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::CullRendererLists(this, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateResourceAllocationAndSynchronization(this, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::LogRendererListsCreation(this, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v8 )
			//     {
			//       ex = v8.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private ref HGRenderGraph.CompiledPassInfo CompilePassImmediatly(HGRenderGraphPass pass)
		{
			// // HGRenderGraph+CompiledPassInfo& CompilePassImmediatly(HGRenderGraphPass)
			// // Hidden C++ exception states: #wind=4
			// HGRenderGraph_CompiledPassInfo *HG::Rendering::RenderGraphModule::HGRenderGraph::CompilePassImmediatly(
			//         HGRenderGraph *this,
			//         HGRenderGraphPass *pass,
			//         MethodInfo *method)
			// {
			//   Object *v3; // r14
			//   HGRenderGraph *v4; // rdi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rbx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *v8; // rbx
			//   int32_t m_CurrentImmediatePassIndex; // esi
			//   HGRenderGraph_CompiledPassInfo *Item; // r15
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v11; // rdx
			//   HGRenderGraphResourceRegistry *v12; // rcx
			//   int i; // esi
			//   unsigned int v14; // r13d
			//   unsigned int v15; // r12d
			//   Object__Class *klass; // rbx
			//   __int64 v17; // rax
			//   __int64 v18; // r8
			//   __int64 v19; // r9
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   __int64 v23; // r8
			//   __int64 v24; // r9
			//   List_1_System_Int32___Array *resourceCreateList; // rax
			//   List_1_System_Int32_ *v26; // rbx
			//   int32_t v27; // eax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // r8
			//   __int64 v33; // r9
			//   List_1_System_Int32___Array *m_ImmediateModeResourceList; // rax
			//   List_1_System_Int32_ *v35; // rbx
			//   int32_t v36; // eax
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   MonitorData *monitor; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   UIInertiaViewPager_InertiaBlocker current; // rbx
			//   List_1_System_Int32___Array *v43; // rax
			//   List_1_System_Int32_ *v44; // r12
			//   int32_t v45; // eax
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __int64 v50; // r8
			//   __int64 v51; // r9
			//   List_1_System_Int32___Array *resourceReleaseList; // rax
			//   List_1_System_Int32_ *v53; // r12
			//   int32_t v54; // eax
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   HGRenderGraphResourceRegistry *v57; // rcx
			//   __int64 v58; // rdx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *m_RendererLists; // rcx
			//   ScriptableRenderContext *m_RenderGraphContext; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v63; // rdx
			//   __int64 v64; // rcx
			//   _BYTE v65[32]; // [rsp+0h] [rbp-128h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v66; // [rsp+30h] [rbp-F8h] BYREF
			//   HGRenderGraph_CompiledPassInfo *v67; // [rsp+48h] [rbp-E0h]
			//   int v68; // [rsp+50h] [rbp-D8h]
			//   unsigned int v69; // [rsp+58h] [rbp-D0h]
			//   unsigned int v70; // [rsp+5Ch] [rbp-CCh]
			//   ResourceHandle res; // [rsp+60h] [rbp-C8h] BYREF
			//   Il2CppException *v72; // [rsp+68h] [rbp-C0h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v73; // [rsp+70h] [rbp-B8h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v74; // [rsp+78h] [rbp-B0h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v75; // [rsp+98h] [rbp-90h] BYREF
			//   Il2CppException *ex; // [rsp+B0h] [rbp-78h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v77; // [rsp+B8h] [rbp-70h]
			//   Il2CppException *v78; // [rsp+C0h] [rbp-68h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v79; // [rsp+C8h] [rbp-60h]
			//   Il2CppExceptionWrapper *v80; // [rsp+D0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+D8h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+E0h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v83; // [rsp+E8h] [rbp-40h] BYREF
			//   RendererListHandle v86; // [rsp+148h] [rbp+20h] BYREF
			// 
			//   v3 = (Object *)pass;
			//   v4 = this;
			//   if ( !byte_18D919342 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919342 = 1;
			//   }
			//   memset(&v66, 0, sizeof(v66));
			//   memset(&v75, 0, sizeof(v75));
			//   if ( IFix::WrappersManagerImpl::IsPatched(209, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(209, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v64, v63);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_96(Patch, (Object *)v4, v3, 0LL);
			//   }
			//   else
			//   {
			//     m_CompiledPassInfos = v4.fields.m_CompiledPassInfos;
			//     if ( !m_CompiledPassInfos )
			//       sub_180B536AC(v6, v5);
			//     if ( v4.fields.m_CurrentImmediatePassIndex >= m_CompiledPassInfos.fields._size_k__BackingField )
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
			//         (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)v4.fields.m_CompiledPassInfos,
			//         2 * m_CompiledPassInfos.fields._size_k__BackingField,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::Resize);
			//     v8 = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v4.fields.m_CompiledPassInfos;
			//     m_CurrentImmediatePassIndex = v4.fields.m_CurrentImmediatePassIndex;
			//     v4.fields.m_CurrentImmediatePassIndex = m_CurrentImmediatePassIndex + 1;
			//     if ( !v8 )
			//       sub_180B536AC(v6, v5);
			//     Item = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                                v8,
			//                                                m_CurrentImmediatePassIndex,
			//                                                MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     v67 = Item;
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::Reset(Item, (HGRenderGraphPass *)v3, 0LL);
			//     Item.enableAsyncCompute = 0;
			//     for ( i = 0; ; ++i )
			//     {
			//       *(_DWORD *)&v86.m_IsValid = i;
			//       v70 = i;
			//       v14 = i;
			//       v68 = i;
			//       v69 = i;
			//       v15 = i;
			//       if ( i >= 2 )
			//         break;
			//       if ( !v3 )
			//         sub_180B536AC(v12, v11);
			//       klass = v3[8].klass;
			//       if ( !klass )
			//         sub_180B536AC(v12, v11);
			//       if ( (unsigned int)i >= LODWORD(klass._0.namespaze) )
			//         sub_180070270(v12, v11);
			//       v17 = *((_QWORD *)&klass._0.byval_arg.data.dummy + i);
			//       if ( !v17 )
			//         sub_180B536AC(v12, v11);
			//       v66 = *(List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *)sub_18082EA30(&v74, v17);
			//       ex = 0LL;
			//       v77 = &v66;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                   &v66,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//         {
			//           res = (ResourceHandle)v66._current;
			//           m_Resources = v4.fields.m_Resources;
			//           if ( !m_Resources )
			//             sub_1802DC2C8(0LL, v11);
			//           if ( !HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsGraphicsResourceCreated(
			//                   m_Resources,
			//                   &res,
			//                   0LL) )
			//           {
			//             resourceCreateList = Item.resourceCreateList;
			//             if ( !resourceCreateList )
			//               sub_1802DC2C8(v22, v21);
			//             if ( (unsigned int)i >= resourceCreateList.max_length.size )
			//               sub_180070260(v22, v21, v23, v24);
			//             v26 = resourceCreateList.vector[i];
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//             v27 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(res, 0LL);
			//             if ( !v26 )
			//               sub_1802DC2C8(v29, v28);
			//             sub_18231EF50(v26, v27);
			//             m_ImmediateModeResourceList = v4.fields.m_ImmediateModeResourceList;
			//             if ( !m_ImmediateModeResourceList )
			//               sub_1802DC2C8(v31, v30);
			//             if ( (unsigned int)i >= m_ImmediateModeResourceList.max_length.size )
			//               sub_180070260(v31, v30, v32, v33);
			//             v35 = m_ImmediateModeResourceList.vector[i];
			//             v36 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(res, 0LL);
			//             if ( !v35 )
			//               sub_1802DC2C8(v38, v37);
			//             sub_18231EF50(v35, v36);
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v80 )
			//       {
			//         v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v65;
			//         ex = v80.ex;
			//         v12 = (HGRenderGraphResourceRegistry *)ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v3 = (Object *)pass;
			//         v4 = this;
			//         Item = v67;
			//         i = *(_DWORD *)&v86.m_IsValid;
			//         v14 = v68;
			//         v15 = v68;
			//       }
			//       if ( !v3 )
			//         goto LABEL_93;
			//       monitor = v3[8].monitor;
			//       if ( !monitor )
			//         goto LABEL_93;
			//       v40 = i;
			//       if ( v15 >= *((_DWORD *)monitor + 6) )
			//         goto LABEL_89;
			//       v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)monitor + i + 4);
			//       if ( !v11 )
			//         goto LABEL_93;
			//       System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//         (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v74,
			//         v11,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//       v66 = v74;
			//       v78 = 0LL;
			//       v79 = &v66;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                   &v66,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//         {
			//           current = v66._current;
			//           v43 = Item.resourceCreateList;
			//           if ( !v43 )
			//             sub_1802DC2C8(v41, v11);
			//           if ( v69 >= v43.max_length.size )
			//             sub_180070260(v69, v11, v18, v19);
			//           v44 = v43.vector[i];
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//           v45 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//           if ( !v44 )
			//             sub_1802DC2C8(v47, v46);
			//           sub_18231EF50(v44, v45);
			//           resourceReleaseList = Item.resourceReleaseList;
			//           if ( !resourceReleaseList )
			//             sub_1802DC2C8(v49, v48);
			//           if ( v14 >= resourceReleaseList.max_length.size )
			//             sub_180070260(v49, v48, v50, v51);
			//           v53 = resourceReleaseList.vector[i];
			//           v54 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//           if ( !v53 )
			//             sub_1802DC2C8(v56, v55);
			//           sub_18231EF50(v53, v54);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v81 )
			//       {
			//         v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v65;
			//         v78 = v81.ex;
			//         if ( v78 )
			//           sub_18000F780(v78);
			//         v3 = (Object *)pass;
			//         v4 = this;
			//         Item = v67;
			//         i = *(_DWORD *)&v86.m_IsValid;
			//       }
			//       v12 = (HGRenderGraphResourceRegistry *)v3[7].monitor;
			//       if ( !v12 )
			//         goto LABEL_93;
			//       v40 = i;
			//       if ( v70 >= LODWORD(v12.fields.m_RendererListResources) )
			// LABEL_89:
			//         sub_180070260(v12, v40, v18, v19);
			//       v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)&v12.fields.m_RenderGraphDebug
			//                                                                              + i);
			//       if ( !v11 )
			//         goto LABEL_93;
			//       System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//         (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v74,
			//         v11,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//       v66 = v74;
			//       v72 = 0LL;
			//       v73 = &v66;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                   &v66,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//           ;
			//       }
			//       catch ( Il2CppExceptionWrapper *v82 )
			//       {
			//         v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v65;
			//         v72 = v82.ex;
			//         v12 = (HGRenderGraphResourceRegistry *)v72;
			//         if ( v72 )
			//           sub_18000F780(v72);
			//         v3 = (Object *)pass;
			//         v4 = this;
			//         Item = v67;
			//         i = *(_DWORD *)&v86.m_IsValid;
			//       }
			//     }
			//     if ( !v3 )
			//       goto LABEL_93;
			//     v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v3[9].klass;
			//     if ( !v11 )
			//       goto LABEL_93;
			//     System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//       (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v74,
			//       v11,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::GetEnumerator);
			//     v75 = v74;
			//     v72 = 0LL;
			//     v73 = &v75;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                 &v75,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::RendererListHandle>::MoveNext) )
			//       {
			//         v86 = (RendererListHandle)v75._current;
			//         v57 = v4.fields.m_Resources;
			//         if ( !v57 )
			//           sub_1802DC2C8(0LL, v11);
			//         if ( !HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRendererListCreated(v57, &v86, 0LL) )
			//         {
			//           m_RendererLists = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v4.fields.m_RendererLists;
			//           if ( !m_RendererLists )
			//             sub_1802DC2C8(0LL, v58);
			//           System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Add(
			//             m_RendererLists,
			//             (WorldSetting_MissionImportanceAndType)v86,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v83 )
			//     {
			//       v11 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v65;
			//       v72 = v83.ex;
			//       if ( v72 )
			//         sub_18000F780(v72);
			//       v4 = this;
			//       Item = v67;
			//     }
			//     v12 = v4.fields.m_Resources;
			//     m_RenderGraphContext = (ScriptableRenderContext *)v4.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext
			//       || !v12
			//       || (HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateRendererLists(
			//             v12,
			//             v4.fields.m_RendererLists,
			//             m_RenderGraphContext[2],
			//             0,
			//             0LL),
			//           (v12 = (HGRenderGraphResourceRegistry *)v4.fields.m_RendererLists) == 0LL) )
			//     {
			// LABEL_93:
			//       sub_1802DC2C8(v12, v11);
			//     }
			//     ++HIDWORD(v12.fields.m_RendererListResources);
			//     LODWORD(v12.fields.m_RendererListResources) = 0;
			//     return Item;
			//   }
			// }
			// 
			return null;
		}

		private void ExecutePassImmediatly(HGRenderGraphPass pass)
		{
			// // Void ExecutePassImmediatly(HGRenderGraphPass)
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ExecutePassImmediatly(
			//         HGRenderGraph *this,
			//         HGRenderGraphPass *pass,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph_CompiledPassInfo *v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(208, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(208, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)pass,
			//       0LL);
			//   }
			//   else
			//   {
			//     v5 = HG::Rendering::RenderGraphModule::HGRenderGraph::CompilePassImmediatly(this, pass, 0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass(
			//       this,
			//       v5,
			//       this.fields.m_CurrentImmediatePassIndex - 1,
			//       0LL);
			//   }
			// }
			// 
		}

		private void ExecuteCompiledPass(ref HGRenderGraph.CompiledPassInfo passInfo, int passIndex)
		{
			// // Void ExecuteCompiledPass(HGRenderGraph+CompiledPassInfo ByRef, Int32)
			// // Hidden C++ exception states: #wind=2 #try_helpers=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledPassInfo *passInfo,
			//         int32_t passIndex,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGRenderGraphPass *pass; // rbx
			//   Object *name_k__BackingField; // rbx
			//   String *v15; // rax
			//   String *v16; // rsi
			//   __int64 v17; // rax
			//   ProtocolViolationException *v18; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   ProtocolViolationException *v21; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int64 v25; // rax
			//   char v26; // [rsp+30h] [rbp-98h] BYREF
			//   HGRenderGraphLogIndent v27; // [rsp+38h] [rbp-90h] BYREF
			//   Il2CppException *ex; // [rsp+58h] [rbp-70h]
			//   char *v29; // [rsp+60h] [rbp-68h]
			//   HGRenderGraphLogIndent v30; // [rsp+68h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v31; // [rsp+80h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v32; // [rsp+88h] [rbp-40h] BYREF
			// 
			//   v26 = 0;
			//   memset(&v30, 0, sizeof(v30));
			//   if ( IFix::WrappersManagerImpl::IsPatched(77, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(77, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v24, v23);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(Patch, (Object *)this, passInfo, passIndex, 0LL);
			//   }
			//   else if ( !passInfo.culled )
			//   {
			//     if ( !passInfo.pass )
			//       sub_180B536AC(v8, v7);
			//     if ( !(unsigned __int8)sub_1800023D0(6LL, passInfo.pass) )
			//     {
			//       pass = passInfo.pass;
			//       if ( pass )
			//       {
			//         name_k__BackingField = (Object *)pass.fields._name_k__BackingField;
			//         v15 = (String *)sub_18000F7E0(&off_18D583BF8);
			//         v16 = System::String::Format(v15, name_k__BackingField, 0LL);
			//         v17 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//         v18 = (ProtocolViolationException *)sub_180004920(v17);
			//         v21 = v18;
			//         if ( !v18 )
			//           sub_180B536AC(v20, v19);
			//         System::Net::ProtocolViolationException::ProtocolViolationException(v18, v16, 0LL);
			//         v25 = sub_18000F7E0(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass);
			//         sub_18000F7C0(v21, v25);
			//       }
			//       sub_180B536AC(v10, v9);
			//     }
			//     if ( !this.fields.m_RenderGraphContext )
			//       sub_180B536AC(v10, v9);
			//     if ( !passInfo.pass )
			//       sub_180B536AC(v10, v9);
			//     try
			//     {
			//       ex = 0LL;
			//       v29 = &v26;
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::LogRenderPassBegin(this, passInfo, 0LL);
			//       memset(&v27, 0, sizeof(v27));
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
			//         &v27,
			//         this.fields.m_FrameInformationLogger,
			//         1,
			//         0LL);
			//       v30 = v27;
			//       *(_QWORD *)&v27.m_Indentation = 0LL;
			//       v27.m_Logger = (HGRenderGraphLogger *)&v30;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::PreRenderPassExecute(
			//           this,
			//           passInfo,
			//           this.fields.m_RenderGraphContext,
			//           0LL);
			//         if ( !passInfo.pass )
			//           sub_1802DC2C8(v12, v11);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphPass::Execute(passInfo.pass, this, 0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::PostRenderPassExecute(
			//           this,
			//           passInfo,
			//           this.fields.m_RenderGraphContext,
			//           0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v31 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v27.m_Indentation = (Il2CppExceptionWrapper)v31.ex;
			//       }
			//       sub_180223510(&v27);
			//     }
			//     catch ( Il2CppExceptionWrapper *v32 )
			//     {
			//       ex = v32.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private void ExecuteRenderGraph()
		{
			// // Void ExecuteRenderGraph()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteRenderGraph(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   HGRenderGraph_CompiledPassInfo *Item; // rax
			//   int32_t i; // edi
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Il2CppExceptionWrapper *v14; // [rsp+20h] [rbp-28h] BYREF
			//   Il2CppException *ex; // [rsp+28h] [rbp-20h]
			//   char *v16; // [rsp+30h] [rbp-18h]
			//   char v17; // [rsp+60h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919343 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//     byte_18D919343 = 1;
			//   }
			//   v17 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(76, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(76, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_RenderGraphContext )
			//       sub_180B536AC(v4, v3);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)1u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::RenderGraphModule::HGRenderGraphProfileId>);
			//     ex = 0LL;
			//     v16 = &v17;
			//     try
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//         if ( !m_CompiledPassInfos )
			//           sub_1802DC2C8(v6, v5);
			//         if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//           break;
			//         Item = (HGRenderGraph_CompiledPassInfo *)UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                                                    (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos,
			//                                                    i,
			//                                                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::ExecuteCompiledPass(this, Item, i, 0LL);
			//       }
			//       m_Resources = this.fields.m_Resources;
			//       if ( !m_Resources )
			//         sub_1802DC2C8(0LL, v5);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleaseUnusedPreservedResources(m_Resources, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       ex = v14.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private void PreRenderPassExecute(in HGRenderGraph.CompiledPassInfo passInfo, HGRenderGraphContext rgContext)
		{
			// // Void PreRenderPassExecute(HGRenderGraph+CompiledPassInfo ByRef, HGRenderGraphContext)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::PreRenderPassExecute(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledPassInfo *passInfo,
			//         HGRenderGraphContext *rgContext,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphContext *v4; // rsi
			//   HGRenderGraph_CompiledPassInfo *v5; // r14
			//   HGRenderGraph *v6; // r13
			//   OneofDescriptorProto *v7; // rdx
			//   __int64 v8; // rcx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   HGRenderGraphPass *pass; // r15
			//   unsigned __int64 v12; // rdx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *m_Ptr; // rcx
			//   int32_t i; // ebx
			//   List_1_System_Int32___Array *resourceCreateList; // r12
			//   List_1_System_Int32_ *v16; // r12
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   CommandBuffer *cmd; // rbx
			//   String *name_k__BackingField; // rbx
			//   CommandBuffer *v20; // rax
			//   CommandBuffer *v21; // rbx
			//   unsigned __int64 v22; // r8
			//   signed __int64 v23; // rtt
			//   CommandBuffer *v24; // rbx
			//   RenderGraph_CompiledPassInfo *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __int64 v29; // [rsp+0h] [rbp-B8h] BYREF
			//   String *name; // [rsp+20h] [rbp-98h]
			//   String *v31; // [rsp+28h] [rbp-90h]
			//   MethodInfo *v32; // [rsp+30h] [rbp-88h]
			//   HGRenderGraphPass *v33; // [rsp+38h] [rbp-80h]
			//   GraphicsFence fence; // [rsp+40h] [rbp-78h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v35; // [rsp+50h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v36; // [rsp+70h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v37; // [rsp+78h] [rbp-40h] BYREF
			// 
			//   v4 = rgContext;
			//   v5 = passInfo;
			//   v6 = this;
			//   if ( !byte_18D919344 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919344 = 1;
			//   }
			//   memset(&v35, 0, sizeof(v35));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(80, 0LL) )
			//   {
			//     pass = v5.pass;
			//     v33 = v5.pass;
			//     if ( !v4 )
			//       sub_180B536AC(v8, v7);
			//     v6.fields.m_PreviousCommandBuffer = v4.fields.cmd;
			//     sub_1800054D0((OneofDescriptor *)&v6.fields.m_PreviousCommandBuffer, v7, v9, v10, (String__Array *)name, v31, v32);
			//     for ( i = 0; ; ++i )
			//     {
			//       LODWORD(v32) = i;
			//       if ( i >= 2 )
			//         break;
			//       resourceCreateList = v5.resourceCreateList;
			//       if ( !resourceCreateList )
			//         sub_180B536AC(m_Ptr, v12);
			//       if ( (unsigned int)i >= resourceCreateList.max_length.size )
			//         sub_180070270(m_Ptr, v12);
			//       v16 = resourceCreateList.vector[i];
			//       if ( !v16 )
			//         sub_180B536AC(m_Ptr, v12);
			//       System::Collections::Generic::List<int>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Int32_ *)&v37,
			//         v16,
			//         MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//       v35 = v37;
			//       fence.m_Ptr = 0LL;
			//       *(_QWORD *)&fence.m_Version = &v35;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                   &v35,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//         {
			//           m_Resources = v6.fields.m_Resources;
			//           if ( !pass )
			//             sub_1802DC2C8(m_Resources, v12);
			//           if ( !m_Resources )
			//             sub_1802DC2C8(0LL, v12);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreatePooledResource(
			//             m_Resources,
			//             v4,
			//             i,
			//             v35._current,
			//             pass.fields._name_k__BackingField,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v36 )
			//       {
			//         v12 = (unsigned __int64)&v29;
			//         fence.m_Ptr = v36.ex;
			//         m_Ptr = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)fence.m_Ptr;
			//         if ( fence.m_Ptr )
			//           sub_18000F780(fence.m_Ptr);
			//         v4 = rgContext;
			//         v5 = passInfo;
			//         v6 = this;
			//         pass = v33;
			//         i = (int)v32;
			//       }
			//     }
			//     if ( v4 )
			//     {
			//       cmd = v4.fields.cmd;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBufferNoCopy(&v4.fields.renderContext, cmd, 0LL);
			//       if ( v5.enableAsyncCompute )
			//       {
			//         if ( !pass )
			//           goto LABEL_39;
			//         name_k__BackingField = pass.fields._name_k__BackingField;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//         v20 = UnityEngine::Rendering::CommandBufferPool::Get(name_k__BackingField, 0LL);
			//         v21 = v20;
			//         if ( !v20 )
			//           goto LABEL_39;
			//         UnityEngine::Rendering::CommandBuffer::SetExecutionFlags(
			//           v20,
			//           CommandBufferExecutionFlags__Enum_AsyncCompute,
			//           0LL);
			//         v4.fields.cmd = v21;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v22 = (((unsigned __int64)&v4.fields.cmd >> 12) & 0x1FFFFF) >> 6;
			//           v12 = ((unsigned __int64)&v4.fields.cmd >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6870D0[v22]);
			//           do
			//             v23 = qword_18D6870D0[v22];
			//           while ( v23 != _InterlockedCompareExchange64(&qword_18D6870D0[v22], v23 | (1LL << v12), v23) );
			//         }
			//       }
			//       if ( v5.syncToPassIndex == -1 )
			//         return;
			//       v24 = v4.fields.cmd;
			//       m_Ptr = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v6.fields.m_CompiledPassInfos;
			//       if ( m_Ptr )
			//       {
			//         Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                  m_Ptr,
			//                  v5.syncToPassIndex,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//         if ( v24 )
			//         {
			//           fence = Item.fence;
			//           UnityEngine::Rendering::CommandBuffer::WaitOnAsyncGraphicsFence(
			//             v24,
			//             &fence,
			//             SynchronisationStage__Enum_VertexProcessing,
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_39:
			//     sub_1802DC2C8(m_Ptr, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(80, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v28, v27);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(Patch, (Object *)v6, v5, (Object *)v4, 0LL);
			// }
			// 
		}

		private void PostRenderPassExecute(ref HGRenderGraph.CompiledPassInfo passInfo, HGRenderGraphContext rgContext)
		{
			// // Void PostRenderPassExecute(HGRenderGraph+CompiledPassInfo ByRef, HGRenderGraphContext)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::PostRenderPassExecute(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledPassInfo *passInfo,
			//         HGRenderGraphContext *rgContext,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphContext *v4; // rsi
			//   HGRenderGraph_CompiledPassInfo *v5; // r14
			//   HGRenderGraph *v6; // r13
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   CommandBuffer *cmd; // rbx
			//   CommandBuffer *v10; // rbx
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   String__Array **v14; // rdx
			//   void *m_Ptr; // rcx
			//   int32_t i; // ebx
			//   List_1_System_Int32___Array *resourceReleaseList; // r12
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   String__Array *v22[6]; // [rsp+0h] [rbp-B8h] BYREF
			//   MethodInfo *v23; // [rsp+30h] [rbp-88h]
			//   Il2CppExceptionWrapper *v24; // [rsp+40h] [rbp-78h] BYREF
			//   GraphicsFence v25; // [rsp+48h] [rbp-70h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v26; // [rsp+58h] [rbp-60h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v27; // [rsp+70h] [rbp-48h] BYREF
			// 
			//   v4 = rgContext;
			//   v5 = passInfo;
			//   v6 = this;
			//   if ( !byte_18D919345 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919345 = 1;
			//   }
			//   memset(&v26, 0, sizeof(v26));
			//   if ( IFix::WrappersManagerImpl::IsPatched(85, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(85, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, v20);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(Patch, (Object *)v6, v5, (Object *)v4, 0LL);
			//   }
			//   else
			//   {
			//     if ( v5.needGraphicsFence )
			//     {
			//       if ( !v4 )
			//         sub_180B536AC(v8, v7);
			//       if ( !v4.fields.cmd )
			//         sub_180B536AC(v8, v7);
			//       v5.fence = *UnityEngine::Rendering::CommandBuffer::CreateAsyncGraphicsFence(&v25, v4.fields.cmd, 0LL);
			//     }
			//     if ( v5.enableAsyncCompute )
			//     {
			//       if ( !v4 )
			//         sub_180B536AC(v8, v7);
			//       cmd = v4.fields.cmd;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBufferAsyncNoCopy(
			//         &v4.fields.renderContext,
			//         cmd,
			//         ComputeQueueType__Enum_Background,
			//         0LL);
			//       v10 = v4.fields.cmd;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//       UnityEngine::Rendering::CommandBufferPool::Release(v10, 0LL);
			//       v4.fields.cmd = v6.fields.m_PreviousCommandBuffer;
			//       sub_1800054D0((OneofDescriptor *)&v4.fields.cmd, v11, v12, v13, v22[4], (String *)v22[5], v23);
			//     }
			//     if ( !v6.fields.m_RenderGraphPool )
			//       sub_180B536AC(v8, v7);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::ReleaseAllTempAlloc(v6.fields.m_RenderGraphPool, 0LL);
			//     for ( i = 0; ; ++i )
			//     {
			//       LODWORD(v23) = i;
			//       if ( i >= 2 )
			//         break;
			//       resourceReleaseList = v5.resourceReleaseList;
			//       if ( !resourceReleaseList )
			//         sub_180B536AC(m_Ptr, v14);
			//       if ( (unsigned int)i >= resourceReleaseList.max_length.size )
			//         sub_180070270(m_Ptr, v14);
			//       if ( !resourceReleaseList.vector[i] )
			//         sub_180B536AC(m_Ptr, v14);
			//       System::Collections::Generic::List<int>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Int32_ *)&v27,
			//         resourceReleaseList.vector[i],
			//         MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//       v26 = v27;
			//       v25.m_Ptr = 0LL;
			//       *(_QWORD *)&v25.m_Version = &v26;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                   &v26,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//         {
			//           m_Resources = v6.fields.m_Resources;
			//           if ( !m_Resources )
			//             sub_1802DC2C8(0LL, v14);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePooledResource(
			//             m_Resources,
			//             v4,
			//             i,
			//             v26._current,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v24 )
			//       {
			//         v14 = v22;
			//         v25.m_Ptr = v24.ex;
			//         m_Ptr = v25.m_Ptr;
			//         if ( v25.m_Ptr )
			//           sub_18000F780(v25.m_Ptr);
			//         v4 = rgContext;
			//         v5 = passInfo;
			//         v6 = this;
			//         i = (int)v23;
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void ClearRenderPasses()
		{
			// // Void ClearRenderPasses()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ClearRenderPasses(HGRenderGraph *this, MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 *v5; // rdx
			//   __int64 v6; // rcx
			//   Object *current; // rdi
			//   HGRenderGraphObjectPool *m_RenderGraphPool; // rsi
			//   List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *m_RenderPasses; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // [rsp+0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v14; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v15; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v16; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919346 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::GetEnumerator);
			//     byte_18D919346 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(102, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(102, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields.m_RenderPasses )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v15,
			//       (List_1_System_Object_ *)v2.fields.m_RenderPasses,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::GetEnumerator);
			//     v16 = v15;
			//     v15._list = 0LL;
			//     *(_QWORD *)&v15._index = &v16;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v16,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::MoveNext) )
			//       {
			//         current = v16._current;
			//         m_RenderGraphPool = v2.fields.m_RenderGraphPool;
			//         if ( !v16._current )
			//           sub_1802DC2C8(v6, v5);
			//         sub_180003EE0(v16._current.klass);
			//         ((void (__fastcall *)(Object *, HGRenderGraphObjectPool *, void *))current.klass[1]._0.namespaze)(
			//           current,
			//           m_RenderGraphPool,
			//           current.klass[1]._0.byval_arg.data.dummy);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       v5 = &v13;
			//       v15._list = (List_1_System_Object_ *)v14.ex;
			//       if ( v15._list )
			//         sub_18000F780(v15._list);
			//       v2 = this;
			//     }
			//     m_RenderPasses = v2.fields.m_RenderPasses;
			//     if ( !m_RenderPasses )
			//       sub_1802DC2C8(0LL, v5);
			//     sub_1823B99D0(
			//       m_RenderPasses,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::Clear);
			//   }
			// }
			// 
		}

		internal void ClearCallbackOwners()
		{
			// // Void ClearCallbackOwners()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ClearCallbackOwners(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_HG_Rendering_RenderGraphModule_IRenderGraphCallbackOwner_ *m_callbackOwner; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919347 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::Clear);
			//     byte_18D919347 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(103, 0LL) )
			//   {
			//     m_callbackOwner = this.fields.m_callbackOwner;
			//     if ( m_callbackOwner )
			//     {
			//       sub_1823B99D0(
			//         m_callbackOwner,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::IRenderGraphCallbackOwner>::Clear);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_callbackOwner, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(103, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void ReleaseImmediateModeResources()
		{
			// // Void ReleaseImmediateModeResources()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::ReleaseImmediateModeResources(
			//         HGRenderGraph *this,
			//         MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // rdi
			//   __int64 *v3; // rdx
			//   Il2CppException *v4; // rcx
			//   int32_t i; // ebx
			//   List_1_System_Int32___Array *m_ImmediateModeResourceList; // r14
			//   HGRenderGraphResourceRegistry *m_Resources; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // [rsp+0h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v12; // [rsp+30h] [rbp-68h] BYREF
			//   Il2CppException *ex; // [rsp+38h] [rbp-60h]
			//   List_1_T_Enumerator_System_UInt32_ *v14; // [rsp+40h] [rbp-58h]
			//   List_1_T_Enumerator_System_UInt32_ v15; // [rsp+48h] [rbp-50h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v16; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919348 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     byte_18D919348 = 1;
			//   }
			//   memset(&v15, 0, sizeof(v15));
			//   if ( IFix::WrappersManagerImpl::IsPatched(100, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(100, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 2; ++i )
			//     {
			//       m_ImmediateModeResourceList = v2.fields.m_ImmediateModeResourceList;
			//       if ( !m_ImmediateModeResourceList )
			//         sub_180B536AC(v4, v3);
			//       if ( (unsigned int)i >= m_ImmediateModeResourceList.max_length.size )
			//         sub_180070270(v4, v3);
			//       if ( !m_ImmediateModeResourceList.vector[i] )
			//         sub_180B536AC(v4, v3);
			//       System::Collections::Generic::List<int>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Int32_ *)&v16,
			//         m_ImmediateModeResourceList.vector[i],
			//         MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//       v15 = v16;
			//       ex = 0LL;
			//       v14 = &v15;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                   &v15,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//         {
			//           m_Resources = v2.fields.m_Resources;
			//           if ( !m_Resources )
			//             sub_1802DC2C8(0LL, v3);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ReleasePooledResource(
			//             m_Resources,
			//             v2.fields.m_RenderGraphContext,
			//             i,
			//             v15._current,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v12 )
			//       {
			//         v3 = &v11;
			//         ex = v12.ex;
			//         v4 = ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v2 = this;
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void LogFrameInformation()
		{
			// // Void LogFrameInformation()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::LogFrameInformation(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rax
			//   HGRenderGraphLogger *m_FrameInformationLogger; // rdi
			//   String *v7; // rsi
			//   Object__Array *v8; // rax
			//   __int64 v9; // r8
			//   __int64 v10; // r9
			//   HGRenderGraphDebugParams *v11; // rax
			//   HGRenderGraphLogger *v12; // rsi
			//   __int64 v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // r8
			//   List_1_HG_Rendering_RenderGraphModule_HGRenderGraphPass_ *m_RenderPasses; // rcx
			//   Object__Array *v17; // rdi
			//   __int64 v18; // rax
			//   __int64 v19; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919349 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Count);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&off_18D583B18);
			//     sub_18003C530(&off_18D583B00);
			//     sub_18003C530(&off_18D583AA0);
			//     byte_18D919349 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(33, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(33, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_15:
			//     sub_180B536AC(v4, v3);
			//   }
			//   m_DebugParameters = this.fields.m_DebugParameters;
			//   if ( !m_DebugParameters )
			//     goto LABEL_15;
			//   if ( !m_DebugParameters.fields.enableLogging )
			//     return;
			//   m_FrameInformationLogger = this.fields.m_FrameInformationLogger;
			//   v7 = System::String::Concat(
			//          (String *)"==== Staring render graph frame for: ",
			//          this.fields.m_CurrentExecutionName,
			//          (String *)" ====",
			//          0LL);
			//   v8 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//   if ( !m_FrameInformationLogger )
			//     goto LABEL_15;
			//   HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(m_FrameInformationLogger, v7, v8, 0LL);
			//   v11 = this.fields.m_DebugParameters;
			//   if ( !v11 )
			//     goto LABEL_15;
			//   if ( !v11.fields.immediateMode )
			//   {
			//     v12 = this.fields.m_FrameInformationLogger;
			//     v13 = il2cpp_array_new_specific_0(TypeInfo::System::Object, 1LL, v9, v10);
			//     m_RenderPasses = this.fields.m_RenderPasses;
			//     v17 = (Object__Array *)v13;
			//     if ( !m_RenderPasses
			//       || (LODWORD(v21) = m_RenderPasses.fields._size,
			//           v18 = il2cpp_value_box(TypeInfo::System::Int32, &v21, v15),
			//           v19 = v18,
			//           !v17)
			//       || (sub_180036D40(v17, v18), sub_1800046C0(v17, 0LL, v19), !v12) )
			//     {
			//       sub_180B536AC(m_RenderPasses, v14);
			//     }
			//     HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//       v12,
			//       (String *)"Number of passes declared: {0}\n",
			//       v17,
			//       0LL);
			//   }
			// }
			// 
		}

		private void LogRendererListsCreation()
		{
			// // Void LogRendererListsCreation()
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::LogRendererListsCreation(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // r8
			//   __int64 v6; // r9
			//   HGRenderGraphDebugParams *m_DebugParameters; // rax
			//   HGRenderGraphLogger *m_FrameInformationLogger; // rsi
			//   __int64 v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // r8
			//   List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *m_RendererLists; // rcx
			//   Object__Array *v13; // rdi
			//   __int64 v14; // rax
			//   __int64 v15; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D91934A )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::get_Count);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&off_18D583AB0);
			//     byte_18D91934A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(74, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(74, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v4, v3);
			//   }
			//   m_DebugParameters = this.fields.m_DebugParameters;
			//   if ( !m_DebugParameters )
			//     goto LABEL_12;
			//   if ( m_DebugParameters.fields.enableLogging )
			//   {
			//     m_FrameInformationLogger = this.fields.m_FrameInformationLogger;
			//     v9 = il2cpp_array_new_specific_0(TypeInfo::System::Object, 1LL, v5, v6);
			//     m_RendererLists = this.fields.m_RendererLists;
			//     v13 = (Object__Array *)v9;
			//     if ( !m_RendererLists
			//       || (LODWORD(v17) = m_RendererLists.fields._size,
			//           v14 = il2cpp_value_box(TypeInfo::System::Int32, &v17, v11),
			//           v15 = v14,
			//           !v13)
			//       || (sub_180036D40(v13, v14), sub_1800046C0(v13, 0LL, v15), !m_FrameInformationLogger) )
			//     {
			//       sub_180B536AC(m_RendererLists, v10);
			//     }
			//     HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//       m_FrameInformationLogger,
			//       (String *)"Number of renderer lists created: {0}\n",
			//       v13,
			//       0LL);
			//   }
			// }
			// 
		}

		private void LogRenderPassBegin(in HGRenderGraph.CompiledPassInfo passInfo)
		{
			// // Void LogRenderPassBegin(HGRenderGraph+CompiledPassInfo ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::LogRenderPassBegin(
			//         HGRenderGraph *this,
			//         HGRenderGraph_CompiledPassInfo *passInfo,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // r8
			//   __int64 v8; // r9
			//   HGRenderGraphDebugParams *m_DebugParameters; // rbx
			//   HGRenderGraphPass *pass; // r14
			//   HGRenderGraphLogger *m_FrameInformationLogger; // r13
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Object__Array *v14; // rbx
			//   __int64 v15; // r8
			//   __int64 v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // r15
			//   const char *v20; // r15
			//   String *name_k__BackingField; // r14
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // r8
			//   __int64 v25; // r9
			//   HGRenderGraphLogger *v26; // rdi
			//   Object__Array *v27; // rbx
			//   __int64 v28; // r8
			//   __int64 v29; // rax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // rsi
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   Il2CppExceptionWrapper *v38; // [rsp+20h] [rbp-58h] BYREF
			//   _QWORD v39[2]; // [rsp+28h] [rbp-50h] BYREF
			//   HGRenderGraphLogIndent v40; // [rsp+38h] [rbp-40h] BYREF
			//   __int64 v41; // [rsp+98h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91934B )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&off_18D583B80);
			//     sub_18003C530(&off_18D583B70);
			//     sub_18003C530(&off_18D583B38);
			//     sub_18003C530(&off_18D583B28);
			//     byte_18D91934B = 1;
			//   }
			//   memset(&v40, 0, sizeof(v40));
			//   if ( IFix::WrappersManagerImpl::IsPatched(79, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(79, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v37, v36);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_40(Patch, (Object *)this, passInfo, 0LL);
			//   }
			//   else
			//   {
			//     m_DebugParameters = this.fields.m_DebugParameters;
			//     if ( !m_DebugParameters )
			//       sub_180B536AC(v6, v5);
			//     if ( m_DebugParameters.fields.enableLogging )
			//     {
			//       pass = passInfo.pass;
			//       m_FrameInformationLogger = this.fields.m_FrameInformationLogger;
			//       v14 = (Object__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Object, 3LL, v7, v8);
			//       if ( !pass )
			//         sub_180B536AC(v13, v12);
			//       LODWORD(v41) = pass.fields._index_k__BackingField;
			//       v16 = il2cpp_value_box(TypeInfo::System::Int32, &v41, v15);
			//       v19 = v16;
			//       if ( !v14 )
			//         sub_180B536AC(v18, v17);
			//       sub_180036D40(v14, v16);
			//       sub_1800046C0(v14, 0LL, v19);
			//       v20 = "Compute";
			//       if ( !pass.fields._enableAsyncCompute_k__BackingField )
			//         v20 = "Graphics";
			//       sub_180036D40(v14, v20);
			//       sub_1800046C0(v14, 1LL, v20);
			//       name_k__BackingField = pass.fields._name_k__BackingField;
			//       sub_180036D40(v14, name_k__BackingField);
			//       sub_1800046C0(v14, 2LL, name_k__BackingField);
			//       if ( !m_FrameInformationLogger )
			//         sub_180B536AC(v23, v22);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//         m_FrameInformationLogger,
			//         (String *)"[{0}][{1}] \"{2}\"",
			//         v14,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
			//         &v40,
			//         this.fields.m_FrameInformationLogger,
			//         1,
			//         0LL);
			//       v39[0] = 0LL;
			//       v39[1] = &v40;
			//       try
			//       {
			//         if ( passInfo.syncToPassIndex != -1 )
			//         {
			//           v26 = this.fields.m_FrameInformationLogger;
			//           v27 = (Object__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Object, 1LL, v24, v25);
			//           LODWORD(v41) = passInfo.syncToPassIndex;
			//           v29 = il2cpp_value_box_0(TypeInfo::System::Int32, &v41, v28);
			//           v32 = v29;
			//           if ( !v27 )
			//             sub_1802DC2C8(v31, v30);
			//           sub_180036D40(v27, v29);
			//           sub_1800046C0(v27, 0LL, v32);
			//           if ( !v26 )
			//             sub_1802DC2C8(v34, v33);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//             v26,
			//             (String *)"Synchronize with [{0}]",
			//             v27,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v38 )
			//       {
			//         v39[0] = v38.ex;
			//       }
			//       sub_180223510(v39);
			//     }
			//   }
			// }
			// 
		}

		private void LogCulledPasses()
		{
			// // Void LogCulledPasses()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::LogCulledPasses(HGRenderGraph *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGRenderGraphDebugParams *m_DebugParameters; // rdi
			//   HGRenderGraphLogger *m_FrameInformationLogger; // rdi
			//   Object__Array *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   List_1_System_Object_ *m_RenderPasses; // rcx
			//   Object *Item; // r14
			//   HGRenderGraphLogger *v15; // r12
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   Object__Array *v20; // rsi
			//   __int64 v21; // r8
			//   __int64 v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int64 v25; // r15
			//   Object__Class *klass; // r14
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   int32_t i; // edi
			//   HGRenderGraphLogger *v30; // rbx
			//   Object__Array *v31; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   Il2CppExceptionWrapper *v37; // [rsp+20h] [rbp-48h] BYREF
			//   _QWORD v38[2]; // [rsp+28h] [rbp-40h] BYREF
			//   HGRenderGraphLogIndent v39; // [rsp+38h] [rbp-30h] BYREF
			//   int monitor; // [rsp+80h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D91934C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Object);
			//     sub_18003C530(&off_18C907FF0);
			//     sub_18003C530(&off_18D5833B0);
			//     sub_18003C530(&off_18C907520);
			//     byte_18D91934C = 1;
			//   }
			//   memset(&v39, 0, sizeof(v39));
			//   if ( IFix::WrappersManagerImpl::IsPatched(50, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(50, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v36, v35);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_DebugParameters = this.fields.m_DebugParameters;
			//     if ( !m_DebugParameters )
			//       sub_180B536AC(v4, v3);
			//     if ( m_DebugParameters.fields.enableLogging )
			//     {
			//       m_FrameInformationLogger = this.fields.m_FrameInformationLogger;
			//       v7 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//       if ( !m_FrameInformationLogger )
			//         sub_180B536AC(v9, v8);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(
			//         m_FrameInformationLogger,
			//         (String *)"Pass Culling Report:",
			//         v7,
			//         0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphLogIndent::HGRenderGraphLogIndent(
			//         &v39,
			//         this.fields.m_FrameInformationLogger,
			//         1,
			//         0LL);
			//       v38[0] = 0LL;
			//       v38[1] = &v39;
			//       try
			//       {
			//         for ( i = 0; ; ++i )
			//         {
			//           m_CompiledPassInfos = this.fields.m_CompiledPassInfos;
			//           if ( !m_CompiledPassInfos )
			//             sub_1802DC2C8(v11, v10);
			//           if ( i >= m_CompiledPassInfos.fields._size_k__BackingField )
			//             break;
			//           if ( UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                  (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)this.fields.m_CompiledPassInfos,
			//                  i,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item).culled )
			//           {
			//             m_RenderPasses = (List_1_System_Object_ *)this.fields.m_RenderPasses;
			//             if ( !m_RenderPasses )
			//               sub_1802DC2C8(0LL, v10);
			//             Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                      m_RenderPasses,
			//                      i,
			//                      MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Item);
			//             v15 = this.fields.m_FrameInformationLogger;
			//             v20 = (Object__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Object, 2LL, v16, v17);
			//             if ( !Item )
			//               sub_1802DC2C8(v19, v18);
			//             monitor = (int)Item[1].monitor;
			//             v22 = il2cpp_value_box_0(TypeInfo::System::Int32, &monitor, v21);
			//             v25 = v22;
			//             if ( !v20 )
			//               sub_1802DC2C8(v24, v23);
			//             sub_180036D40(v20, v22);
			//             sub_1800046C0(v20, 0LL, v25);
			//             klass = Item[1].klass;
			//             sub_180036D40(v20, klass);
			//             sub_1800046C0(v20, 1LL, klass);
			//             if ( !v15 )
			//               sub_1802DC2C8(v28, v27);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(v15, (String *)"[{0}] {1}", v20, 0LL);
			//           }
			//         }
			//         v30 = this.fields.m_FrameInformationLogger;
			//         v31 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//         if ( !v30 )
			//           sub_1802DC2C8(v33, v32);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphLogger::LogLine(v30, (String *)"\n", v31, 0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v37 )
			//       {
			//         v38[0] = v37.ex;
			//       }
			//       sub_180223510(v38);
			//     }
			//   }
			// }
			// 
		}

		private ProfilingSampler GetDefaultProfilingSampler(string name)
		{
			// // ProfilingSampler GetDefaultProfilingSampler(String)
			// ProfilingSampler *HG::Rendering::RenderGraphModule::HGRenderGraph::GetDefaultProfilingSampler(
			//         HGRenderGraph *this,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_Int32_UnityEngine_Rendering_ProfilingSampler_ *m_DefaultProfilingSamplers; // rcx
			//   int32_t v7; // eax
			//   int32_t v8; // ebp
			//   ProfilingSampler *v9; // rax
			//   Object *v10; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *value; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91934D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::TryGetValue);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ProfilingSampler);
			//     byte_18D91934D = 1;
			//   }
			//   value = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(217, 0LL) )
			//   {
			//     if ( name )
			//     {
			//       v7 = sub_18003ED00(2LL);
			//       m_DefaultProfilingSamplers = this.fields.m_DefaultProfilingSamplers;
			//       v8 = v7;
			//       if ( m_DefaultProfilingSamplers )
			//       {
			//         if ( System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
			//                (Dictionary_2_System_Int32_System_Object_ *)m_DefaultProfilingSamplers,
			//                v7,
			//                &value,
			//                MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::TryGetValue) )
			//         {
			//           return (ProfilingSampler *)value;
			//         }
			//         v9 = (ProfilingSampler *)sub_180004920(TypeInfo::UnityEngine::Rendering::ProfilingSampler);
			//         v10 = (Object *)v9;
			//         if ( v9 )
			//         {
			//           UnityEngine::Rendering::ProfilingSampler::ProfilingSampler(v9, name, 0LL);
			//           m_DefaultProfilingSamplers = this.fields.m_DefaultProfilingSamplers;
			//           value = v10;
			//           if ( m_DefaultProfilingSamplers )
			//           {
			//             System::Collections::Generic::Dictionary<int,System::Object>::Add(
			//               (Dictionary_2_System_Int32_System_Object_ *)m_DefaultProfilingSamplers,
			//               v8,
			//               v10,
			//               MethodInfo::System::Collections::Generic::Dictionary<int,UnityEngine::Rendering::ProfilingSampler>::Add);
			//             return (ProfilingSampler *)value;
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_DefaultProfilingSamplers, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(217, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_100(Patch, (Object *)this, (Object *)name, 0LL);
			// }
			// 
			return null;
		}

		private void UpdateImportedResourceLifeTime(ref HGRenderGraphDebugData.ResourceDebugData data, List<int> passList)
		{
			// // Void UpdateImportedResourceLifeTime(HGRenderGraphDebugData+ResourceDebugData ByRef, List`1[System.Int32])
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateImportedResourceLifeTime(
			//         HGRenderGraph *this,
			//         HGRenderGraphDebugData_ResourceDebugData *data,
			//         List_1_System_Int32_ *passList,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t current; // edi
			//   int32_t creationPassIndex; // esi
			//   int32_t releasePassIndex; // esi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Il2CppExceptionWrapper *v15; // [rsp+30h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v16; // [rsp+38h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v17; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91934E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D91934E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(98, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(98, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_51(Patch, (Object *)this, data, (Object *)passList, 0LL);
			//   }
			//   else
			//   {
			//     if ( !passList )
			//       sub_180B536AC(v8, v7);
			//     System::Collections::Generic::List<int>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Int32_ *)&v16,
			//       passList,
			//       MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     v17 = v16;
			//     v16._list = 0LL;
			//     *(_QWORD *)&v16._index = &v17;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v17,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         current = v17._current;
			//         if ( data.creationPassIndex == -1 )
			//         {
			//           creationPassIndex = v17._current;
			//         }
			//         else
			//         {
			//           creationPassIndex = data.creationPassIndex;
			//           sub_180002C70(TypeInfo::System::Math);
			//           if ( creationPassIndex > current )
			//             creationPassIndex = current;
			//         }
			//         data.creationPassIndex = creationPassIndex;
			//         if ( data.releasePassIndex == -1 )
			//         {
			//           data.releasePassIndex = current;
			//         }
			//         else
			//         {
			//           releasePassIndex = data.releasePassIndex;
			//           sub_180002C70(TypeInfo::System::Math);
			//           if ( releasePassIndex < current )
			//             releasePassIndex = current;
			//           data.releasePassIndex = releasePassIndex;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       v16._list = (List_1_System_UInt32_ *)v15.ex;
			//       if ( v16._list )
			//         sub_18000F780(v16._list);
			//     }
			//   }
			// }
			// 
		}

		private void GenerateDebugData()
		{
			// // Void GenerateDebugData()
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::GenerateDebugData(HGRenderGraph *this, MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // r14
			//   __int64 v3; // rdx
			//   HGRenderGraph__StaticFields *static_fields; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderGraph_OnExecutionRegisteredDelegate *onExecutionRegistered; // rcx
			//   HGRenderGraphDebugData *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Object *v11; // rbx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v14; // rdx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *resourceCreateList; // rcx
			//   HGRenderGraphResourceType__Enum v16; // ebx
			//   __int64 v17; // r15
			//   int32_t i; // r12d
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *m_CompiledResourcesInfos; // rsi
			//   __int64 v20; // rsi
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledResourceInfo___Array *v21; // rsi
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *v22; // rsi
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   RenderGraph_CompiledResourceInfo *Item; // r13
			//   OneofDescriptorProto *v26; // rdx
			//   FileDescriptor *v27; // r8
			//   MessageDescriptor *v28; // r9
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   List_1_System_Int32_ *v31; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   List_1_System_Int32_ *v34; // rsi
			//   OneofDescriptorProto *v35; // rdx
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   IEnumerable_1_System_Int32_ *producers; // r13
			//   List_1_System_Int32_ *v39; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   List_1_System_Int32_ *v42; // rsi
			//   OneofDescriptorProto *v43; // rdx
			//   FileDescriptor *v44; // r8
			//   MessageDescriptor *v45; // r9
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   MonitorData *monitor; // rsi
			//   __int64 v49; // rsi
			//   int32_t j; // r12d
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_HGRenderGraph_CompiledPassInfo_ *m_CompiledPassInfos; // rax
			//   OneofDescriptorProto *v52; // rdx
			//   __int64 v53; // rcx
			//   FileDescriptor *v54; // r8
			//   MessageDescriptor *v55; // r9
			//   RenderGraph_CompiledPassInfo *v56; // r15
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   __int64 v59; // r8
			//   __int64 v60; // r9
			//   OneofDescriptorProto *v61; // rdx
			//   FileDescriptor *v62; // r8
			//   MessageDescriptor *v63; // r9
			//   __int64 v64; // r8
			//   __int64 v65; // r9
			//   OneofDescriptorProto *v66; // rdx
			//   FileDescriptor *v67; // r8
			//   MessageDescriptor *v68; // r9
			//   int k; // esi
			//   __int64 v70; // r13
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v71; // rax
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v74; // rbx
			//   __int64 v75; // rdx
			//   __int64 v76; // rcx
			//   __int64 v77; // r13
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v78; // rax
			//   __int64 v79; // rdx
			//   __int64 v80; // rcx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v81; // rbx
			//   __int64 v82; // rdx
			//   __int64 v83; // rcx
			//   __int64 v84; // rdx
			//   __int64 v85; // rcx
			//   List_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rbx
			//   __int64 v87; // rax
			//   __int64 v88; // r8
			//   __int64 v89; // r9
			//   List_1_System_Int32_ *v90; // r13
			//   UIInertiaViewPager_InertiaBlocker current; // rbx
			//   int32_t v92; // eax
			//   __int64 v93; // rdx
			//   __int64 v94; // rcx
			//   RenderGraphPass__Class *klass; // rax
			//   __int64 v96; // rdx
			//   __int64 v97; // rcx
			//   List_1_System_Int32_ *v98; // r13
			//   UIInertiaViewPager_InertiaBlocker v99; // rbx
			//   int32_t v100; // eax
			//   __int64 v101; // rdx
			//   __int64 v102; // rcx
			//   int32_t v103; // ebx
			//   MonitorData *v104; // rcx
			//   List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *v105; // rdx
			//   __int64 v106; // rdx
			//   __int64 v107; // r8
			//   __int64 v108; // r9
			//   MonitorData *v109; // rcx
			//   List_1_Beyond_StyledBlackboard_StyledDataPair_ *v110; // rcx
			//   __int64 v111; // r8
			//   __int64 v112; // r9
			//   int32_t v113; // ebx
			//   MonitorData *v114; // rcx
			//   List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *v115; // rdx
			//   __int64 v116; // rdx
			//   __int64 v117; // r8
			//   __int64 v118; // r9
			//   MonitorData *v119; // rcx
			//   List_1_Beyond_StyledBlackboard_StyledDataPair_ *v120; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v122; // rdx
			//   __int64 v123; // rcx
			//   _BYTE v124[32]; // [rsp+0h] [rbp-208h] BYREF
			//   Object *value; // [rsp+20h] [rbp-1E8h] BYREF
			//   String *v126; // [rsp+28h] [rbp-1E0h]
			//   IEnumerable_1_System_Int32_ *collection; // [rsp+30h] [rbp-1D8h]
			//   __int128 v128; // [rsp+38h] [rbp-1D0h] BYREF
			//   __int128 v129; // [rsp+48h] [rbp-1C0h] BYREF
			//   __int128 v130; // [rsp+60h] [rbp-1A8h] BYREF
			//   __int128 v131; // [rsp+70h] [rbp-198h]
			//   HGRenderGraphDebugData_ResourceDebugData v132; // [rsp+80h] [rbp-188h] BYREF
			//   HGRenderGraphDebugData_ResourceDebugData data; // [rsp+B0h] [rbp-158h] BYREF
			//   unsigned int v134; // [rsp+D8h] [rbp-130h]
			//   unsigned int v135; // [rsp+DCh] [rbp-12Ch]
			//   unsigned int v136; // [rsp+E0h] [rbp-128h]
			//   unsigned int v137; // [rsp+E4h] [rbp-124h]
			//   unsigned int v138; // [rsp+E8h] [rbp-120h]
			//   unsigned int v139; // [rsp+ECh] [rbp-11Ch]
			//   unsigned int v140; // [rsp+F0h] [rbp-118h]
			//   unsigned int v141; // [rsp+F4h] [rbp-114h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ v142; // [rsp+F8h] [rbp-110h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v143; // [rsp+110h] [rbp-F8h] BYREF
			//   __int128 v144; // [rsp+128h] [rbp-E0h]
			//   __int128 v145; // [rsp+138h] [rbp-D0h]
			//   Il2CppException *ex; // [rsp+148h] [rbp-C0h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v147; // [rsp+150h] [rbp-B8h]
			//   Il2CppException *v148; // [rsp+158h] [rbp-B0h]
			//   List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *v149; // [rsp+160h] [rbp-A8h]
			//   Il2CppExceptionWrapper *v150; // [rsp+168h] [rbp-A0h] BYREF
			//   Il2CppExceptionWrapper *v151; // [rsp+170h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v152; // [rsp+178h] [rbp-90h] BYREF
			//   Il2CppExceptionWrapper *v153; // [rsp+180h] [rbp-88h] BYREF
			//   __int128 v154; // [rsp+188h] [rbp-80h]
			//   __int128 v155; // [rsp+1C0h] [rbp-48h]
			//   int32_t v157; // [rsp+228h] [rbp+20h]
			// 
			//   v2 = this;
			//   if ( !byte_18D91934F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::TryGetValue);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_size);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_size);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugData);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::PassDebugData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::set_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D91934F = 1;
			//   }
			//   value = 0LL;
			//   memset(&data, 0, sizeof(data));
			//   v128 = 0LL;
			//   v129 = 0LL;
			//   memset(&v142, 0, sizeof(v142));
			//   memset(&v143, 0, sizeof(v143));
			//   if ( IFix::WrappersManagerImpl::IsPatched(91, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(91, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v123, v122);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else if ( !v2.fields.m_ExecutionExceptionWasRaised )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     if ( !byte_18D8ED949 )
			//     {
			//       sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//       byte_18D8ED949 = 1;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     static_fields = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields;
			//     if ( static_fields._requireDebugData_k__BackingField )
			//     {
			//       if ( !v2.fields.m_DebugData )
			//         sub_180B536AC(static_fields, v3);
			//       if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
			//               (Dictionary_2_System_Object_System_Object_ *)v2.fields.m_DebugData,
			//               (Object *)v2.fields.m_CurrentExecutionName,
			//               &value,
			//               MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::TryGetValue) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//         onExecutionRegistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionRegistered;
			//         if ( onExecutionRegistered )
			//           ((void (__fastcall *)(void *, HGRenderGraph *, String *, void *))onExecutionRegistered.fields._._.invoke_impl)(
			//             onExecutionRegistered.fields._._.method_code,
			//             v2,
			//             v2.fields.m_CurrentExecutionName,
			//             onExecutionRegistered.fields._._.method);
			//         v8 = (HGRenderGraphDebugData *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphDebugData);
			//         v11 = (Object *)v8;
			//         if ( !v8 )
			//           sub_180B536AC(v10, v9);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::HGRenderGraphDebugData(v8, 0LL);
			//         value = v11;
			//         if ( !v2.fields.m_DebugData )
			//           sub_180B536AC(v13, v12);
			//         System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
			//           (Dictionary_2_System_Object_System_Object_ *)v2.fields.m_DebugData,
			//           (Object *)v2.fields.m_CurrentExecutionName,
			//           v11,
			//           MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Add);
			//       }
			//       if ( !value )
			//         sub_180B536AC(v6, v5);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::Clear((HGRenderGraphDebugData *)value, 0LL);
			//       v16 = HGRenderGraphResourceType__Enum_Texture;
			//       v17 = 32LL;
			//       do
			//       {
			//         for ( i = 0; ; ++i )
			//         {
			//           m_CompiledResourcesInfos = v2.fields.m_CompiledResourcesInfos;
			//           if ( !m_CompiledResourcesInfos )
			//             sub_180B536AC(resourceCreateList, v14);
			//           if ( v16 >= m_CompiledResourcesInfos.max_length.size )
			//             sub_180070270(resourceCreateList, v14);
			//           v20 = *(__int64 *)((char *)&m_CompiledResourcesInfos.klass + v17);
			//           if ( !v20 )
			//             sub_180B536AC(resourceCreateList, v14);
			//           if ( i >= *(_DWORD *)(v20 + 24) )
			//             break;
			//           v21 = v2.fields.m_CompiledResourcesInfos;
			//           if ( !v21 )
			//             sub_180B536AC(resourceCreateList, v14);
			//           if ( v16 >= v21.max_length.size )
			//             sub_180070270(resourceCreateList, v14);
			//           v22 = *(DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ **)((char *)&v21.klass + v17);
			//           if ( !v22 )
			//             sub_180B536AC(resourceCreateList, v14);
			//           Item = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::get_Item(
			//                    v22,
			//                    i,
			//                    MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledResourceInfo>::get_Item);
			//           memset(&data, 0, sizeof(data));
			//           if ( !v2.fields.m_Resources )
			//             sub_180B536AC(v24, v23);
			//           data.name = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRenderGraphResourceName(
			//                         v2.fields.m_Resources,
			//                         v16,
			//                         i,
			//                         0LL);
			//           sub_1800054D0((OneofDescriptor *)&data, v26, v27, v28, (String__Array *)value, v126, (MethodInfo *)collection);
			//           if ( !v2.fields.m_Resources )
			//             sub_180B536AC(v30, v29);
			//           data.imported = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
			//                             v2.fields.m_Resources,
			//                             v16,
			//                             i,
			//                             0LL);
			//           data.creationPassIndex = -1;
			//           data.releasePassIndex = -1;
			//           collection = (IEnumerable_1_System_Int32_ *)Item.consumers;
			//           v31 = (List_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//           v34 = v31;
			//           if ( !v31 )
			//             sub_180B536AC(v33, v32);
			//           System::Collections::Generic::List<int>::List(
			//             v31,
			//             collection,
			//             MethodInfo::System::Collections::Generic::List<int>::List);
			//           data.consumerList = v34;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&data.consumerList,
			//             v35,
			//             v36,
			//             v37,
			//             (String__Array *)value,
			//             v126,
			//             (MethodInfo *)collection);
			//           producers = (IEnumerable_1_System_Int32_ *)Item.producers;
			//           v39 = (List_1_System_Int32_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//           v42 = v39;
			//           if ( !v39 )
			//             sub_180B536AC(v41, v40);
			//           System::Collections::Generic::List<int>::List(
			//             v39,
			//             producers,
			//             MethodInfo::System::Collections::Generic::List<int>::List);
			//           data.producerList = v42;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&data.producerList,
			//             v43,
			//             v44,
			//             v45,
			//             (String__Array *)value,
			//             v126,
			//             (MethodInfo *)collection);
			//           if ( data.imported )
			//           {
			//             HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateImportedResourceLifeTime(
			//               v2,
			//               &data,
			//               data.consumerList,
			//               0LL);
			//             HG::Rendering::RenderGraphModule::HGRenderGraph::UpdateImportedResourceLifeTime(
			//               v2,
			//               &data,
			//               data.producerList,
			//               0LL);
			//           }
			//           if ( !value )
			//             sub_180B536AC(v47, v46);
			//           monitor = value[1].monitor;
			//           if ( !monitor )
			//             sub_180B536AC(v47, v46);
			//           if ( v16 >= *((_DWORD *)monitor + 6) )
			//             sub_180070270(v47, v46);
			//           v49 = *(_QWORD *)((char *)monitor + v17);
			//           v145 = *(_OWORD *)&data.name;
			//           v144 = *(_OWORD *)&data.releasePassIndex;
			//           collection = (IEnumerable_1_System_Int32_ *)data.producerList;
			//           if ( !v49 )
			//             sub_180B536AC(v47, v46);
			//           v132 = data;
			//           sub_180430CF8(
			//             v49,
			//             &v132,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::Add);
			//         }
			//         ++v16;
			//         v17 += 8LL;
			//       }
			//       while ( (int)v16 < (int)HGRenderGraphResourceType__Enum_Count );
			//       for ( j = 0; ; ++j )
			//       {
			//         v157 = j;
			//         m_CompiledPassInfos = v2.fields.m_CompiledPassInfos;
			//         if ( !m_CompiledPassInfos )
			//           break;
			//         if ( j >= m_CompiledPassInfos.fields._size_k__BackingField )
			//           return;
			//         v56 = UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledPassInfo>::get_Item(
			//                 (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledPassInfo_ *)v2.fields.m_CompiledPassInfos,
			//                 j,
			//                 MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo>::get_Item);
			//         v126 = (String *)v56;
			//         v128 = 0LL;
			//         v129 = 0LL;
			//         if ( !v56.pass )
			//           sub_180B536AC(v53, v52);
			//         *(_QWORD *)&v128 = v56.pass.fields._name_k__BackingField;
			//         sub_1800054D0((OneofDescriptor *)&v128, v52, v54, v55, (String__Array *)value, v126, (MethodInfo *)collection);
			//         LOBYTE(v60) = v56.culled;
			//         BYTE8(v129) = v60;
			//         if ( !v56.pass )
			//           sub_180B536AC(v58, v57);
			//         BYTE9(v129) = BYTE4(v56.pass.fields.usedRendererListList);
			//         *((_QWORD *)&v128 + 1) = il2cpp_array_new_specific_0(
			//                                    TypeInfo::System::Collections::Generic::List<int>,
			//                                    2LL,
			//                                    v59,
			//                                    v60);
			//         sub_1800054D0(
			//           (OneofDescriptor *)((char *)&v128 + 8),
			//           v61,
			//           v62,
			//           v63,
			//           (String__Array *)value,
			//           v126,
			//           (MethodInfo *)collection);
			//         *(_QWORD *)&v129 = il2cpp_array_new_specific_0(TypeInfo::System::Collections::Generic::List<int>, 2LL, v64, v65);
			//         sub_1800054D0((OneofDescriptor *)&v129, v66, v67, v68, (String__Array *)value, v126, (MethodInfo *)collection);
			//         for ( k = 0; ; ++k )
			//         {
			//           v141 = k;
			//           v140 = k;
			//           v139 = k;
			//           v138 = k;
			//           v137 = k;
			//           v136 = k;
			//           v135 = k;
			//           v134 = k;
			//           if ( k >= 2 )
			//             break;
			//           v70 = *((_QWORD *)&v128 + 1);
			//           v71 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//           v74 = v71;
			//           if ( !v71 )
			//             sub_180B536AC(v73, v72);
			//           System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//             v71,
			//             MethodInfo::System::Collections::Generic::List<int>::List);
			//           if ( !v70 )
			//             sub_180B536AC(v76, v75);
			//           sub_180036D40(v70, v74);
			//           sub_18000FDA0(v70, k, v74);
			//           v77 = v129;
			//           v78 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//           v81 = v78;
			//           if ( !v78 )
			//             sub_180B536AC(v80, v79);
			//           System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//             v78,
			//             MethodInfo::System::Collections::Generic::List<int>::List);
			//           if ( !v77 )
			//             sub_180B536AC(v83, v82);
			//           sub_180036D40(v77, v81);
			//           sub_18000FDA0(v77, k, v81);
			//           if ( !v56.pass )
			//             sub_180B536AC(v85, v84);
			//           dependsOnRendererListList = v56.pass.fields.dependsOnRendererListList;
			//           if ( !dependsOnRendererListList )
			//             sub_180B536AC(v85, v84);
			//           if ( (unsigned int)k >= dependsOnRendererListList.fields._size )
			//             sub_180070270(v85, v84);
			//           v87 = *((_QWORD *)&dependsOnRendererListList.fields._syncRoot + k);
			//           if ( !v87 )
			//             sub_180B536AC(v85, v84);
			//           v142 = *(List_1_T_Enumerator_Beyond_UI_UIInertiaViewPager_InertiaBlocker_ *)sub_18082EA30(&v130, v87);
			//           ex = 0LL;
			//           v147 = &v142;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                       &v142,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//             {
			//               if ( !*((_QWORD *)&v128 + 1) )
			//                 sub_1802DC2C8(resourceCreateList, v14);
			//               if ( (unsigned int)k >= *(_DWORD *)(*((_QWORD *)&v128 + 1) + 24LL) )
			//                 sub_180070260(resourceCreateList, v14, v88, v89);
			//               v90 = *(List_1_System_Int32_ **)(*((_QWORD *)&v128 + 1) + 8LL * k + 32);
			//               current = v142._current;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//               v92 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)current, 0LL);
			//               if ( !v90 )
			//                 sub_1802DC2C8(v94, v93);
			//               sub_18231EF50(v90, v92);
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v150 )
			//           {
			//             v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v124;
			//             ex = v150.ex;
			//             resourceCreateList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)ex;
			//             if ( ex )
			//               sub_18000F780(ex);
			//             v2 = this;
			//             j = v157;
			//             v56 = (RenderGraph_CompiledPassInfo *)v126;
			//           }
			//           if ( !v56.pass )
			//             goto LABEL_169;
			//           klass = v56.pass[1].klass;
			//           if ( !klass )
			//             goto LABEL_169;
			//           v96 = k;
			//           resourceCreateList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v134;
			//           if ( v134 >= LODWORD(klass._0.namespaze) )
			//             goto LABEL_168;
			//           v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)&klass._0.byval_arg.data.dummy
			//                                                                                  + k);
			//           if ( !v14 )
			//             goto LABEL_169;
			//           System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::GetEnumerator(
			//             (List_1_T_Enumerator_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)&v130,
			//             v14,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::GetEnumerator);
			//           *(_OWORD *)&v142._list = v130;
			//           v142._current = (UIInertiaViewPager_InertiaBlocker)v131;
			//           v148 = 0LL;
			//           v149 = &v142;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::UI::UIInertiaViewPager::InertiaBlocker>::MoveNext(
			//                       &v142,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::ResourceHandle>::MoveNext) )
			//             {
			//               if ( !(_QWORD)v129 )
			//                 sub_1802DC2C8(v97, v14);
			//               if ( v135 >= *(_DWORD *)(v129 + 24) )
			//                 sub_180070260(v135, v14, v88, v89);
			//               v98 = *(List_1_System_Int32_ **)(v129 + 8LL * k + 32);
			//               v99 = v142._current;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//               v100 = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit((ResourceHandle)v99, 0LL);
			//               if ( !v98 )
			//                 sub_1802DC2C8(v102, v101);
			//               sub_18231EF50(v98, v100);
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v151 )
			//           {
			//             v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v124;
			//             v148 = v151.ex;
			//             if ( v148 )
			//               sub_18000F780(v148);
			//             v2 = this;
			//             j = v157;
			//             v56 = (RenderGraph_CompiledPassInfo *)v126;
			//           }
			//           resourceCreateList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v56.resourceCreateList;
			//           if ( !resourceCreateList )
			//             goto LABEL_169;
			//           v96 = k;
			//           if ( v136 >= resourceCreateList.fields._size )
			//             goto LABEL_168;
			//           v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)&resourceCreateList.fields._syncRoot
			//                                                                                  + k);
			//           if ( !v14 )
			//             goto LABEL_169;
			//           System::Collections::Generic::List<int>::GetEnumerator(
			//             (List_1_T_Enumerator_System_Int32_ *)&v130,
			//             (List_1_System_Int32_ *)v14,
			//             MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//           *(_OWORD *)&v143._list = v130;
			//           *(_QWORD *)&v143._current = v131;
			//           *(_QWORD *)&v144 = 0LL;
			//           *((_QWORD *)&v144 + 1) = &v143;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                       &v143,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//             {
			//               v103 = v143._current;
			//               if ( !value )
			//                 sub_1802DC2C8(0LL, v14);
			//               v104 = value[1].monitor;
			//               if ( !v104 )
			//                 sub_1802DC2C8(0LL, v14);
			//               if ( v137 >= *((_DWORD *)v104 + 6) )
			//                 sub_180070260(v104, k, v88, v89);
			//               v105 = (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)*((_QWORD *)v104 + k + 4);
			//               if ( !v105 )
			//                 sub_1802DC2C8(v104, 0LL);
			//               System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::get_Item(
			//                 (WeaponComponent_WeaponMountPointModifier *)&v132,
			//                 v105,
			//                 v143._current,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::get_Item);
			//               v154 = *(_OWORD *)&v132.name;
			//               if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v132.name, 8)) )
			//               {
			//                 HIDWORD(v154) = j;
			//                 if ( !value )
			//                   sub_1802DC2C8(0LL, v106);
			//                 v109 = value[1].monitor;
			//                 if ( !v109 )
			//                   sub_1802DC2C8(0LL, v106);
			//                 if ( v138 >= *((_DWORD *)v109 + 6) )
			//                   sub_180070260(v109, k, v107, v108);
			//                 v110 = (List_1_Beyond_StyledBlackboard_StyledDataPair_ *)*((_QWORD *)v109 + k + 4);
			//                 if ( !v110 )
			//                   sub_1802DC2C8(0LL, k);
			//                 *(_OWORD *)&v132.name = v154;
			//                 System::Collections::Generic::List<Beyond::StyledBlackboard::StyledDataPair>::set_Item(
			//                   v110,
			//                   v103,
			//                   (StyledBlackboard_StyledDataPair *)&v132,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::set_Item);
			//               }
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v152 )
			//           {
			//             v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v124;
			//             *(Il2CppExceptionWrapper *)&v144 = (Il2CppExceptionWrapper)v152.ex;
			//             if ( (_QWORD)v144 )
			//               sub_18000F780(v144);
			//             v2 = this;
			//             j = v157;
			//             v56 = (RenderGraph_CompiledPassInfo *)v126;
			//           }
			//           resourceCreateList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v56.resourceReleaseList;
			//           if ( !resourceCreateList )
			//             goto LABEL_169;
			//           v96 = k;
			//           if ( v139 >= resourceCreateList.fields._size )
			// LABEL_168:
			//             sub_180070260(resourceCreateList, v96, v88, v89);
			//           v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)*((_QWORD *)&resourceCreateList.fields._syncRoot
			//                                                                                  + k);
			//           if ( !v14 )
			//             goto LABEL_169;
			//           System::Collections::Generic::List<int>::GetEnumerator(
			//             (List_1_T_Enumerator_System_Int32_ *)&v130,
			//             (List_1_System_Int32_ *)v14,
			//             MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//           *(_OWORD *)&v143._list = v130;
			//           *(_QWORD *)&v143._current = v131;
			//           *(_QWORD *)&v145 = 0LL;
			//           *((_QWORD *)&v145 + 1) = &v143;
			//           try
			//           {
			//             while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                       &v143,
			//                       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//             {
			//               v113 = v143._current;
			//               if ( !value )
			//                 sub_1802DC2C8(0LL, v14);
			//               v114 = value[1].monitor;
			//               if ( !v114 )
			//                 sub_1802DC2C8(0LL, v14);
			//               if ( v140 >= *((_DWORD *)v114 + 6) )
			//                 sub_180070260(v114, k, v111, v112);
			//               v115 = (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)*((_QWORD *)v114 + k + 4);
			//               if ( !v115 )
			//                 sub_1802DC2C8(v114, 0LL);
			//               System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::get_Item(
			//                 (WeaponComponent_WeaponMountPointModifier *)&v132,
			//                 v115,
			//                 v143._current,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::get_Item);
			//               v155 = *(_OWORD *)&v132.releasePassIndex;
			//               if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v132.name, 8)) )
			//               {
			//                 LODWORD(v155) = j;
			//                 if ( !value )
			//                   sub_1802DC2C8(0LL, v116);
			//                 v119 = value[1].monitor;
			//                 if ( !v119 )
			//                   sub_1802DC2C8(0LL, v116);
			//                 if ( v141 >= *((_DWORD *)v119 + 6) )
			//                   sub_180070260(v119, k, v117, v118);
			//                 v120 = (List_1_Beyond_StyledBlackboard_StyledDataPair_ *)*((_QWORD *)v119 + k + 4);
			//                 if ( !v120 )
			//                   sub_1802DC2C8(0LL, k);
			//                 *(_OWORD *)&v132.releasePassIndex = v155;
			//                 System::Collections::Generic::List<Beyond::StyledBlackboard::StyledDataPair>::set_Item(
			//                   v120,
			//                   v113,
			//                   (StyledBlackboard_StyledDataPair *)&v132,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::ResourceDebugData>::set_Item);
			//               }
			//             }
			//           }
			//           catch ( Il2CppExceptionWrapper *v153 )
			//           {
			//             v14 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)v124;
			//             *(Il2CppExceptionWrapper *)&v145 = (Il2CppExceptionWrapper)v153.ex;
			//             resourceCreateList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v145;
			//             if ( (_QWORD)v145 )
			//               sub_18000F780(v145);
			//             v2 = this;
			//             j = v157;
			//             v56 = (RenderGraph_CompiledPassInfo *)v126;
			//           }
			//         }
			//         if ( !value )
			//           break;
			//         resourceCreateList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)value[1].klass;
			//         if ( !resourceCreateList )
			//           break;
			//         v130 = v128;
			//         v131 = v129;
			//         *(_OWORD *)&v132.name = v128;
			//         *(_OWORD *)&v132.releasePassIndex = v129;
			//         System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Add(
			//           resourceCreateList,
			//           (AbilitySystem_ComboController_MappingModifier_Handle *)&v132,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphDebugData::PassDebugData>::Add);
			//       }
			// LABEL_169:
			//       sub_1802DC2C8(resourceCreateList, v14);
			//     }
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::CleanupDebugData(v2, 0LL);
			//   }
			// }
			// 
		}

		private void CleanupDebugData()
		{
			// // Void CleanupDebugData()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraph::CleanupDebugData(HGRenderGraph *this, MethodInfo *method)
			// {
			//   HGRenderGraph *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 *v5; // rdx
			//   Object *key; // xmm6_8
			//   HGRenderGraph_OnExecutionRegisteredDelegate *onExecutionUnregistered; // rcx
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *m_DebugData; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // [rsp+0h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v13; // [rsp+20h] [rbp-88h] BYREF
			//   Il2CppException *ex; // [rsp+28h] [rbp-80h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v15; // [rsp+30h] [rbp-78h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v16; // [rsp+38h] [rbp-70h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v17; // [rsp+60h] [rbp-48h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919350 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::get_Key);
			//     byte_18D919350 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(93, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(93, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields.m_DebugData )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       &v17,
			//       (Dictionary_2_System_Object_System_Object_ *)v2.fields.m_DebugData,
			//       MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::GetEnumerator);
			//     v16 = v17;
			//     ex = 0LL;
			//     v15 = &v16;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//                 &v16,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::MoveNext) )
			//       {
			//         key = v16._current.key;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			//         onExecutionUnregistered = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.onExecutionUnregistered;
			//         if ( onExecutionUnregistered )
			//           ((void (__fastcall *)(void *, HGRenderGraph *, Object *, void *))onExecutionUnregistered.fields._._.invoke_impl)(
			//             onExecutionUnregistered.fields._._.method_code,
			//             v2,
			//             key,
			//             onExecutionUnregistered.fields._._.method);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v13 )
			//     {
			//       v5 = &v12;
			//       ex = v13.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			//     }
			//     m_DebugData = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields.m_DebugData;
			//     if ( !m_DebugData )
			//       sub_1802DC2C8(0LL, v5);
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//       m_DebugData,
			//       MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::RenderGraphModule::HGRenderGraphDebugData>::Clear);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int kMaxMRTCount;

		private HGRenderGraphResourceRegistry m_Resources;

		private HGRenderGraphObjectPool m_RenderGraphPool;

		private List<HGRenderGraphPass> m_RenderPasses;

		private List<RendererListHandle> m_RendererLists;

		private List<IRenderGraphCallbackOwner> m_callbackOwner;

		private HGRenderGraphDebugParams m_DebugParameters;

		private HGRenderGraphLogger m_FrameInformationLogger;

		private HGRenderGraphDefaultResources m_DefaultResources;

		private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers;

		private bool m_ExecutionExceptionWasRaised;

		private HGRenderGraphContext m_RenderGraphContext;

		private CommandBuffer m_PreviousCommandBuffer;

		private int m_CurrentImmediatePassIndex;

		private List<int>[] m_ImmediateModeResourceList;

		private HGRenderGraph.BackBufferInfo m_backBufferInfo;

		private DynamicArray<HGRenderGraph.CompiledResourceInfo>[] m_CompiledResourcesInfos;

		private DynamicArray<HGRenderGraph.CompiledPassInfo> m_CompiledPassInfos;

		private Stack<int> m_CullingStack;

		private int m_ExecutionCount;

		private int m_CurrentFrameIndex;

		private string m_CurrentExecutionName;

		private bool m_RendererListCulling;

		private int m_currentExecutorID;

		private int m_currentExecutorFrameIndex;

		private Dictionary<string, HGRenderGraphDebugData> m_DebugData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static List<HGRenderGraph> s_RegisteredGraphs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<HGRenderGraph.ProfilingScopePassData> s_beginProfilingSamplerRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<HGRenderGraph.ProfilingScopePassData> s_endProfilingSamplerRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct CompiledResourceInfo
		{
			public void Reset()
			{
			}

			public List<int> producers;

			public List<int> consumers;

			public int refCount;

			public bool imported;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 36)]
		private struct BackBufferInfo
		{
			internal TextureHandle color;

			internal TextureHandle depth;

			internal bool offScreen;
		}

		[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct CompiledPassInfo
		{
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x000025D8 File Offset: 0x000007D8
			public bool allowPassCulling
			{
				get
				{
					// // Boolean get_allowPassCulling()
					// bool HG::Rendering::RenderGraphModule::HGRenderGraph::CompiledPassInfo::get_allowPassCulling(
					//         HGRenderGraph_CompiledPassInfo *this,
					//         MethodInfo *method)
					// {
					//   if ( !this.pass )
					//     sub_180B536AC(this, method);
					//   return this.pass.fields._allowPassCulling_k__BackingField;
					// }
					// 
					return default(bool);
				}
			}

			public void Reset(HGRenderGraphPass pass)
			{
			}

			public HGRenderGraphPass pass;

			public List<int>[] resourceCreateList;

			public List<int>[] resourceReleaseList;

			public int refCount;

			public bool culled;

			public bool hasSideEffect;

			public int syncToPassIndex;

			public int syncFromPassIndex;

			public bool needGraphicsFence;

			public GraphicsFence fence;

			public bool enableAsyncCompute;
		}

		public class ExecuteHGRenderGraphV2PassData
		{
			public ExecuteHGRenderGraphV2PassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public long rg;

			public NativeList<long> importAs;

			public NativeList<TextureHandle> importBs;

			public NativeList<long> importBufferResourceHandles;

			public NativeList<ComputeBufferHandle> importBufferHandles;

			public HGRenderGraph renderGraph;

			public bool forceIssueRenderPass;
		}

		private class ProfilingScopePassData
		{
			public ProfilingScopePassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public ProfilingSampler sampler;
		}

		// (Invoke) Token: 0x060001A7 RID: 423
		internal delegate void OnGraphRegisteredDelegate(HGRenderGraph graph);

		// (Invoke) Token: 0x060001AB RID: 427
		internal delegate void OnExecutionRegisteredDelegate(HGRenderGraph graph, string executionName);
	}
}
