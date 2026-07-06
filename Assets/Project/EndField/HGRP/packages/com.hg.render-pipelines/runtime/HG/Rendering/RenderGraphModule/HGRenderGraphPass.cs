using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class HGRenderGraphPass
	{
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000025D0 File Offset: 0x000007D0
		public string name
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
			protected set
			{
				// // SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
				// void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
				//         SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
				//         SortedList_2_System_Object_System_Object_ *dictionary,
				//         MethodInfo *method)
				// {
				//   AlphaBlend *v3; // r9
				//   float v4; // xmm2_4
				//   MethodInfo *v5; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v6; // [rsp+30h] [rbp+30h]
				//   uint8_t v7; // [rsp+38h] [rbp+38h]
				//   MethodInfo *v8; // [rsp+40h] [rbp+40h]
				// 
				//   this.fields._dict = dictionary;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper *)&this.fields,
				//     (TemporaryAnimationMontage *)dictionary,
				//     v4,
				//     v3,
				//     v5,
				//     v6,
				//     v7,
				//     v8);
				// }
				// 
			}
		}

		// (get) Token: 0x06000214 RID: 532 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000025D0 File Offset: 0x000007D0
		public int index
		{
			[CompilerGenerated]
			get
			{
				// // LayerMask get_value()
				// LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
				//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
				//         MethodInfo *method)
				// {
				//   return (LayerMask)this.fields.m_Value.m_Mask;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_value(LayerMask)
				// void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
				//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
				//         LayerMask value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Value = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000216 RID: 534 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000025D0 File Offset: 0x000007D0
		public ProfilingSampler customSampler
		{
			[CompilerGenerated]
			get
			{
				// // Func`1[Single] get_getValueDelegate()
				// Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_getValueDelegate(Func`1[Single])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         Func_1_Single_ *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
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

		// (get) Token: 0x06000218 RID: 536 RVA: 0x000026F8 File Offset: 0x000008F8
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000025D0 File Offset: 0x000007D0
		public ProfilingHGPass profilingHgPass
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_Count()
				// int32_t TMPro::TMP_TextProcessingStack<TMPro::HighlightState>::get_Count(
				//         TMP_TextProcessingStack_1_HighlightState_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_RolloverSize;
				// }
				// 
				return (ProfilingHGPass)ProfilingHGPass.None;
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_countAll(Int32)
				// void TMPro::TMP_ObjectPool<System::Object>::set_countAll(
				//         TMP_ObjectPool_1_System_Object_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._countAll_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600021A RID: 538 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool enableAsyncCompute
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_Rotate()
				// bool CW::Common::CwFollow::get_Rotate(CwFollow *this, MethodInfo *method)
				// {
				//   return this.fields.rotate;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_Rotate(Boolean)
				// void CW::Common::CwFollow::set_Rotate(CwFollow *this, bool value, MethodInfo *method)
				// {
				//   this.fields.rotate = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600021C RID: 540 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool allowPassCulling
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_IgnoreZ()
				// bool CW::Common::CwFollow::get_IgnoreZ(CwFollow *this, MethodInfo *method)
				// {
				//   return this.fields.ignoreZ;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_IgnoreZ(Boolean)
				// void CW::Common::CwFollow::set_IgnoreZ(CwFollow *this, bool value, MethodInfo *method)
				// {
				//   this.fields.ignoreZ = value;
				// }
				// 
			}
		}

		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x0600021F RID: 543 RVA: 0x000025D0 File Offset: 0x000007D0
		public int refCount
		{
			[CompilerGenerated]
			get
			{
				// // P3dPaintableTexture+FilterType get_Filter()
				// P3dPaintableTexture_FilterType__Enum PaintIn3D::P3dPaintableTexture::get_Filter(
				//         P3dPaintableTexture *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.filter;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_Filter(P3dPaintableTexture+FilterType)
				// void PaintIn3D::P3dPaintableTexture::set_Filter(
				//         P3dPaintableTexture *this,
				//         P3dPaintableTexture_FilterType__Enum value,
				//         MethodInfo *method)
				// {
				//   this.fields.filter = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000220 RID: 544 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool generateDebugData
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_DiscardUnknownFields()
				// bool Google::Protobuf::ParserInternalState::get_DiscardUnknownFields(ParserInternalState *this, MethodInfo *method)
				// {
				//   return this._DiscardUnknownFields_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
				// // Void DblClickSnap(TextEditor+DblClickSnapping)
				// void UnityEngine::TextEditor::DblClickSnap(
				//         TextEditor *this,
				//         TextEditor_DblClickSnapping__Enum snapping,
				//         MethodInfo *method)
				// {
				//   this.fields.m_DblClickSnap = snapping;
				// }
				// 
			}
		}

		// (get) Token: 0x06000222 RID: 546 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000223 RID: 547 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool allowRendererListCulling
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_IsNotationDeclared()
				// bool System::Xml::Schema::SchemaElementDecl::get_IsNotationDeclared(SchemaElementDecl *this, MethodInfo *method)
				// {
				//   return this.fields.isNotationDeclared;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_IsNotationDeclared(Boolean)
				// void System::Xml::Schema::SchemaElementDecl::set_IsNotationDeclared(
				//         SchemaElementDecl *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.isNotationDeclared = value;
				// }
				// 
			}
		}

		public HGRenderGraphPass()
		{
		}

		public abstract void ExecuteAsChildPass(HGRenderGraph renderGraph);

		public abstract void Release(HGRenderGraphObjectPool pool);

		public abstract bool HasRenderFunc();

		protected abstract void ExecuteInternal(HGRenderGraph renderGraph);

		public virtual void Clear()
		{
		}

		public void AddResourceWrite(in ResourceHandle res)
		{
			// // Void AddResourceWrite(ResourceHandle ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(
			//         HGRenderGraphPass *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceWriteLists; // rbx
			//   int32_t iType; // eax
			//   __int64 v7; // rdx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919360 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919360 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(227, 0LL) )
			//   {
			//     resourceWriteLists = this.fields.resourceWriteLists;
			//     v10 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
			//     if ( resourceWriteLists )
			//     {
			//       if ( (unsigned int)iType >= resourceWriteLists.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)resourceWriteLists.vector[iType];
			//       if ( v8 )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Add(
			//           v8,
			//           (WorldSetting_MissionImportanceAndType)*res,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
			//         return;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(227, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_26(Patch, (Object *)this, res, 0LL);
			// }
			// 
		}

		public void AddResourceRead(in ResourceHandle res)
		{
			// // Void AddResourceRead(ResourceHandle ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(
			//         HGRenderGraphPass *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *resourceReadLists; // rbx
			//   int32_t iType; // eax
			//   __int64 v7; // rdx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919361 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919361 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(233, 0LL) )
			//   {
			//     resourceReadLists = this.fields.resourceReadLists;
			//     v10 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
			//     if ( resourceReadLists )
			//     {
			//       if ( (unsigned int)iType >= resourceReadLists.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)resourceReadLists.vector[iType];
			//       if ( v8 )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Add(
			//           v8,
			//           (WorldSetting_MissionImportanceAndType)*res,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
			//         return;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(233, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_26(Patch, (Object *)this, res, 0LL);
			// }
			// 
		}

		public void AddTransientResource(in ResourceHandle res)
		{
			// // Void AddTransientResource(ResourceHandle ByRef)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(
			//         HGRenderGraphPass *this,
			//         ResourceHandle *res,
			//         MethodInfo *method)
			// {
			//   List_1_HG_Rendering_RenderGraphModule_ResourceHandle___Array *transientResourceList; // rbx
			//   int32_t iType; // eax
			//   __int64 v7; // rdx
			//   List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ResourceHandle v10; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919362 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D919362 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(247, 0LL) )
			//   {
			//     transientResourceList = this.fields.transientResourceList;
			//     v10 = *res;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     iType = HG::Rendering::RenderGraphModule::ResourceHandle::get_iType(&v10, 0LL);
			//     if ( transientResourceList )
			//     {
			//       if ( (unsigned int)iType >= transientResourceList.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)transientResourceList.vector[iType];
			//       if ( v8 )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Add(
			//           v8,
			//           (WorldSetting_MissionImportanceAndType)*res,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::ResourceHandle>::Add);
			//         return;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(247, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_26(Patch, (Object *)this, res, 0LL);
			// }
			// 
		}

		public void UseRendererList(RendererListHandle rendererList)
		{
			// // Void UseRendererList(RendererListHandle)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::UseRendererList(
			//         HGRenderGraphPass *this,
			//         RendererListHandle rendererList,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *usedRendererListList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919363 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
			//     byte_18D919363 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(250, 0LL) )
			//   {
			//     usedRendererListList = this.fields.usedRendererListList;
			//     if ( usedRendererListList )
			//     {
			//       System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Add(
			//         (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)usedRendererListList,
			//         (WorldSetting_MissionImportanceAndType)rendererList,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(usedRendererListList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(250, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_121(Patch, (Object *)this, rendererList, 0LL);
			// }
			// 
		}

		public void DependsOnRendererList(RendererListHandle rendererList)
		{
			// // Void DependsOnRendererList(RendererListHandle)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::DependsOnRendererList(
			//         HGRenderGraphPass *this,
			//         RendererListHandle rendererList,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_HG_Rendering_RenderGraphModule_RendererListHandle_ *dependsOnRendererListList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919364 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
			//     byte_18D919364 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(276, 0LL) )
			//   {
			//     dependsOnRendererListList = this.fields.dependsOnRendererListList;
			//     if ( dependsOnRendererListList )
			//     {
			//       System::Collections::Generic::List<Beyond::Gameplay::WorldSetting::MissionImportanceAndType>::Add(
			//         (List_1_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_ *)dependsOnRendererListList,
			//         (WorldSetting_MissionImportanceAndType)rendererList,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::RendererListHandle>::Add);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(dependsOnRendererListList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(276, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_121(Patch, (Object *)this, rendererList, 0LL);
			// }
			// 
		}

		public void EnableAsyncCompute(bool value)
		{
			// // Void EnableAsyncCompute(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::EnableAsyncCompute(
			//         HGRenderGraphPass *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(258, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(258, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._enableAsyncCompute_k__BackingField = value;
			//   }
			// }
			// 
		}

		public void AllowPassCulling(bool value)
		{
			// // Void AllowPassCulling(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowPassCulling(
			//         HGRenderGraphPass *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(200, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(200, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._allowPassCulling_k__BackingField = value;
			//   }
			// }
			// 
		}

		public void AllowRendererListCulling(bool value)
		{
			// // Void AllowRendererListCulling(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowRendererListCulling(
			//         HGRenderGraphPass *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(261, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(261, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._allowRendererListCulling_k__BackingField = value;
			//   }
			// }
			// 
		}

		public void GenerateDebugData(bool value)
		{
			// // Void GenerateDebugData(Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::GenerateDebugData(
			//         HGRenderGraphPass *this,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(203, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(203, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._generateDebugData_k__BackingField = value;
			//   }
			// }
			// 
		}

		[IDTag(2)]
		public void SetColorAttachment(TextureHandle attachment, int index, uint depthSlice)
		{
			// // Void SetColorAttachment(TextureHandle, Int32, UInt32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//         HGRenderGraphPass *this,
			//         TextureHandle *attachment,
			//         int32_t index,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   TileBase *v9; // rdx
			//   Vector3Int *v10; // r8
			//   ITilemap *v11; // r9
			//   TileAnimationData v12; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   MethodInfo *v16; // [rsp+20h] [rbp-38h]
			//   TileAnimationData v17; // [rsp+30h] [rbp-28h] BYREF
			//   TextureHandle v18; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(224, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(224, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     v18 = *attachment;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_106(Patch, (Object *)this, &v18, index, depthSlice, 0LL);
			//   }
			//   else
			//   {
			//     v12 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)&v18, v9, v10, v11, v16);
			//     v18 = *attachment;
			//     v17 = v12;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//       this,
			//       &v18,
			//       index,
			//       (Color *)&v17,
			//       depthSlice,
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public void SetColorAttachment(TextureHandle attachment, int index, Color clearColor, uint depthSlice)
		{
			// // Void SetColorAttachment(TextureHandle, Int32, Color, UInt32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//         HGRenderGraphPass *this,
			//         TextureHandle *attachment,
			//         int32_t index,
			//         Color *clearColor,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   TextureHandle v10; // xmm1
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   TextureHandle v13; // xmm1
			//   Color v14; // [rsp+50h] [rbp-28h] BYREF
			//   TextureHandle v15; // [rsp+60h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(225, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(225, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v11);
			//     v13 = *attachment;
			//     v15 = (TextureHandle)*clearColor;
			//     v14 = (Color)v13;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_105(
			//       Patch,
			//       (Object *)this,
			//       (TextureHandle *)&v14,
			//       index,
			//       (Color *)&v15,
			//       depthSlice,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = *attachment;
			//     v14 = *clearColor;
			//     v15 = v10;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//       this,
			//       &v15,
			//       index,
			//       RenderBufferLoadAction__Enum_Load,
			//       RenderBufferStoreAction__Enum_Store,
			//       &v14,
			//       depthSlice,
			//       0,
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(3)]
		public void SetColorAttachment(TextureHandle attachment, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Color clearColor, uint depthSlice)
		{
			// // Void SetColorAttachment(TextureHandle, Int32, RenderBufferLoadAction, RenderBufferStoreAction, Color, UInt32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//         HGRenderGraphPass *this,
			//         TextureHandle *attachment,
			//         int32_t index,
			//         RenderBufferLoadAction__Enum loadAction,
			//         RenderBufferStoreAction__Enum storeAction,
			//         Color *clearColor,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   TextureHandle v12; // xmm1
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   TextureHandle v15; // xmm1
			//   Color v16; // [rsp+50h] [rbp-28h] BYREF
			//   TextureHandle v17; // [rsp+60h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(230, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(230, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v13);
			//     v15 = *attachment;
			//     v17 = (TextureHandle)*clearColor;
			//     v16 = (Color)v15;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_109(
			//       Patch,
			//       (Object *)this,
			//       (TextureHandle *)&v16,
			//       index,
			//       loadAction,
			//       storeAction,
			//       (Color *)&v17,
			//       depthSlice,
			//       0LL);
			//   }
			//   else
			//   {
			//     v12 = *attachment;
			//     v16 = *clearColor;
			//     v17 = v12;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//       this,
			//       &v17,
			//       index,
			//       loadAction,
			//       storeAction,
			//       &v16,
			//       depthSlice,
			//       1,
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		private void SetColorAttachment(TextureHandle attachment, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Color clearColor, uint depthSlice, bool manuallyOverride)
		{
			// // Void SetColorAttachment(TextureHandle, Int32, RenderBufferLoadAction, RenderBufferStoreAction, Color, UInt32, Boolean)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
			//         HGRenderGraphPass *this,
			//         TextureHandle *attachment,
			//         int32_t index,
			//         RenderBufferLoadAction__Enum loadAction,
			//         RenderBufferStoreAction__Enum storeAction,
			//         Color *clearColor,
			//         uint32_t depthSlice,
			//         bool manuallyOverride,
			//         MethodInfo *method)
			// {
			//   __int64 v13; // rdx
			//   DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *colorAttachments; // rcx
			//   TextureHandle v15; // xmm6
			//   Color v16; // xmm0
			//   AttachDesc *Item; // rax
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   TextureHandle v20; // xmm1
			//   Color v21; // [rsp+58h] [rbp-41h] BYREF
			//   TextureHandle v22; // [rsp+68h] [rbp-31h] BYREF
			//   __m256i v23; // [rsp+88h] [rbp-11h] BYREF
			//   __int64 v24; // [rsp+A8h] [rbp+Fh]
			// 
			//   if ( !byte_18D919365 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::Resize);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
			//     byte_18D919365 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(226, 0LL) )
			//   {
			//     colorAttachments = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this.fields.colorAttachments;
			//     if ( colorAttachments )
			//     {
			//       UnityEngine::Rendering::DynamicArray<UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraph::CompiledResourceInfo>::Resize(
			//         colorAttachments,
			//         index + 1,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::Resize);
			//       colorAttachments = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)this.fields.colorAttachments;
			//       if ( colorAttachments )
			//       {
			//         v15 = *attachment;
			//         v24 = 0LL;
			//         memset(&v23.m256i_u64[1], 0, 24);
			//         v23.m256i_i32[1] = storeAction;
			//         v23.m256i_i32[0] = loadAction;
			//         v16 = *clearColor;
			//         v23.m256i_i64[3] = depthSlice | 0x3F80000000000000LL;
			//         BYTE4(v24) = manuallyOverride;
			//         *(Color *)&v23.m256i_u64[1] = v16;
			//         Item = UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item(
			//                  (DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *)colorAttachments,
			//                  index,
			//                  MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_Item);
			//         v18 = *(_OWORD *)v23.m256i_i8;
			//         v19 = *(_OWORD *)&v23.m256i_u64[2];
			//         Item.textureHandle = v15;
			//         *(_OWORD *)&Item.loadAction = v18;
			//         *(_QWORD *)&v18 = v24;
			//         *(_OWORD *)&Item.clearColor.b = v19;
			//         *(_QWORD *)&Item.clearStencil = v18;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(this, &attachment.handle, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(colorAttachments, v13);
			//   }
			//   colorAttachments = (DynamicArray_1_UnityEngine_Experimental_Rendering_RenderGraphModule_RenderGraph_CompiledResourceInfo_ *)IFix::WrappersManagerImpl::GetPatch(226, 0LL);
			//   if ( !colorAttachments )
			//     goto LABEL_8;
			//   v20 = *attachment;
			//   v21 = *clearColor;
			//   v22 = v20;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_104(
			//     (ILFixDynamicMethodWrapper_2 *)colorAttachments,
			//     (Object *)this,
			//     &v22,
			//     index,
			//     loadAction,
			//     storeAction,
			//     &v21,
			//     depthSlice,
			//     manuallyOverride,
			//     0LL);
			// }
			// 
		}

		[IDTag(0)]
		public void SetDepthAttachment(TextureHandle depth, DepthAccess depthAccess, uint depthSlice)
		{
			// // Void SetDepthAttachment(TextureHandle, DepthAccess, UInt32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
			//         HGRenderGraphPass *this,
			//         TextureHandle *depth,
			//         DepthAccess__Enum depthAccess,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   TextureHandle v13; // [rsp+30h] [rbp-58h] BYREF
			//   __int128 v14; // [rsp+60h] [rbp-28h]
			//   __int64 v15; // [rsp+70h] [rbp-18h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(232, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(232, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     v13 = *depth;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_111(Patch, (Object *)this, &v13, depthAccess, depthSlice, 0LL);
			//   }
			//   else
			//   {
			//     v15 = 0LL;
			//     *(_OWORD *)&this.fields.depthAttachment.loadAction = 0LL;
			//     v14 = 0LL;
			//     DWORD2(v14) = depthSlice;
			//     v9 = v15;
			//     *(_OWORD *)&this.fields.depthAttachment.clearColor.b = v14;
			//     *(_QWORD *)&this.fields.depthAttachment.clearStencil = v9;
			//     this.fields.depthAttachment.textureHandle = *depth;
			//     this.fields.depthAttachment.depthSlice = depthSlice;
			//     if ( (depthAccess & 1) != 0 )
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(this, &depth.handle, 0LL);
			//     if ( (depthAccess & 2) != 0 )
			//       HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(this, &depth.handle, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public void SetDepthAttachment(TextureHandle depth, DepthAccess depthAccess, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, float clearDepth, byte clearStencil, uint depthSlice)
		{
			// // Void SetDepthAttachment(TextureHandle, DepthAccess, RenderBufferLoadAction, RenderBufferStoreAction, Single, Byte, UInt32)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
			//         HGRenderGraphPass *this,
			//         TextureHandle *depth,
			//         DepthAccess__Enum depthAccess,
			//         RenderBufferLoadAction__Enum loadAction,
			//         RenderBufferStoreAction__Enum storeAction,
			//         float clearDepth,
			//         uint8_t clearStencil,
			//         uint32_t depthSlice,
			//         MethodInfo *method)
			// {
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   TextureHandle v15; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(235, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(235, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v13);
			//     v15 = *depth;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_113(
			//       Patch,
			//       (Object *)this,
			//       &v15,
			//       depthAccess,
			//       loadAction,
			//       storeAction,
			//       clearDepth,
			//       clearStencil,
			//       depthSlice,
			//       0LL);
			//   }
			//   else
			//   {
			//     v15 = *depth;
			//     HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(this, &v15, depthAccess, depthSlice, 0LL);
			//     this.fields.depthAttachment.storeAction = storeAction;
			//     this.fields.depthAttachment.clearStencil = clearStencil;
			//     this.fields.depthAttachment.clearDepth = clearDepth;
			//     this.fields.depthAttachment.loadAction = loadAction;
			//     this.fields.depthAttachment.manuallyOverride = 1;
			//   }
			// }
			// 
		}

		internal abstract bool DepthRequiredIfMRT();

		protected bool NecessaryToIssueRenderPass()
		{
			// // Boolean NecessaryToIssueRenderPass()
			// bool HG::Rendering::RenderGraphModule::HGRenderGraphPass::NecessaryToIssueRenderPass(
			//         HGRenderGraphPass *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   DynamicArray_1_HG_Rendering_RenderGraphModule_AttachDesc_ *colorAttachments; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919366 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::DynamicArray<HG::Rendering::RenderGraphModule::AttachDesc>::get_size);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919366 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(277, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(277, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// LABEL_9:
			//     sub_180B536AC(colorAttachments, v3);
			//   }
			//   colorAttachments = this.fields.colorAttachments;
			//   if ( !colorAttachments )
			//     goto LABEL_9;
			//   if ( colorAttachments.fields._size_k__BackingField )
			//     return 1;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   return HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.depthAttachment.textureHandle, 0LL);
			// }
			// 
			return default(bool);
		}

		public void Execute(HGRenderGraph renderGraph)
		{
			// // Void Execute(HGRenderGraph)
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::Execute(
			//         HGRenderGraphPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(84, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(84, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else if ( !this.fields.m_parentPass )
			//   {
			//     sub_180078890(7LL, this, renderGraph);
			//   }
			// }
			// 
		}

		internal void AddChildPass(HGRenderGraphPass pass)
		{
		}

		protected void ExecuteChildPasses(HGRenderGraph renderGraph)
		{
			// // Void ExecuteChildPasses(HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::RenderGraphModule::HGRenderGraphPass::ExecuteChildPasses(
			//         HGRenderGraphPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_System_Object_ *m_childPasses; // rbx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Object *current; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Il2CppExceptionWrapper *v14; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v15; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v16; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919368 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::RenderGraphModule::HGRenderGraphPass>::GetEnumerator);
			//     byte_18D919368 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(278, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(278, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_childPasses = (List_1_System_Object_ *)this.fields.m_childPasses;
			//     if ( !m_childPasses )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v15,
			//       m_childPasses,
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
			//         if ( !v16._current )
			//           sub_1802DC2C8(v9, v8);
			//         sub_180078890(4LL, v16._current, renderGraph);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphPass::ExecuteChildPasses(
			//           (HGRenderGraphPass *)current,
			//           renderGraph,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       v15._list = (List_1_System_Object_ *)v14.ex;
			//       if ( v15._list )
			//         sub_18000F780(v15._list);
			//     }
			//   }
			// }
			// 
		}

		protected const int MAX_RENDER_FUNC_COUNT = 4;

		public AttachDesc depthAttachment;

		public DynamicArray<AttachDesc> colorAttachments;

		public List<ResourceHandle>[] resourceReadLists;

		public List<ResourceHandle>[] resourceWriteLists;

		public List<ResourceHandle>[] transientResourceList;

		public List<RendererListHandle> usedRendererListList;

		public List<RendererListHandle> dependsOnRendererListList;

		private List<HGRenderGraphPass> m_childPasses;

		private HGRenderGraphPass m_parentPass;
	}
}
