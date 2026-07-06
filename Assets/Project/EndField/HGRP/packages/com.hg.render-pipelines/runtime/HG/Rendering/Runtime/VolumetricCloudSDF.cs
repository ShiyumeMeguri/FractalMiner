using System;
using System.Collections.Generic;
using Beyond;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class VolumetricCloudSDF : VolumetricRenderObject, IVolumetricCloudVolume
	{
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000025D8 File Offset: 0x000007D8
		private bool IsCloudSdfAssetValid
		{
			get
			{
				// // Boolean get_IsCloudSdfAssetValid()
				// bool HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(VolumetricCloudSDF *this, MethodInfo *method)
				// {
				//   Object_1 *m_CloudAsset; // rbx
				//   bool result; // al
				//   __int64 v5; // rdx
				//   VolumetricSdfAsset *v6; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919771 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D919771 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(4349, 0LL) )
				//   {
				//     m_CloudAsset = (Object_1 *)this.fields.m_CloudAsset;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     result = UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL);
				//     if ( !result )
				//       return result;
				//     v6 = this.fields.m_CloudAsset;
				//     if ( v6 )
				//       return HG::Rendering::Runtime::VolumetricSdfAsset::get_IsValid(v6, 0LL);
				// LABEL_8:
				//     sub_180B536AC(v6, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4349, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001A52 RID: 6738 RVA: 0x000025D0 File Offset: 0x000007D0
		public BeyondPolyLineShape PolyLineShape
		{
			get
			{
				// // HEU_CookedDataEvent get_CookedDataEvent()
				// HEU_CookedDataEvent *HoudiniEngineUnity::HEU_HoudiniAsset::get_CookedDataEvent(
				//         HEU_HoudiniAsset *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._cookedDataEvent;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_indirectTouch(ButtonControl)
				// void UnityEngine::InputSystem::Controls::TouchControl::set_indirectTouch(
				//         TouchControl *this,
				//         ButtonControl *value,
				//         MethodInfo *method)
				// {
				//   HGCamera *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   *(_QWORD *)&this.fields._.m_UnprocessedCachedValue.position.y = value;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&this.fields._.m_UnprocessedCachedValue.position.y,
				//     (HGRenderPathBase_HGRenderPathResources *)value,
				//     (PassConstructorID__Enum__Array *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}
		}

		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00002608 File Offset: 0x00000808
		public int volumePriority
		{
			get
			{
				// // Int32 get_selectedIndex()
				// int32_t Beyond::UI::UIDropdown::get_selectedIndex(UIDropdown *this, MethodInfo *method)
				// {
				//   return this.fields._selectedIndex_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000025D8 File Offset: 0x000007D8
		private bool IsWindField
		{
			get
			{
				// // Boolean get_IsWindField()
				// bool HG::Rendering::Runtime::VolumetricCloudSDF::get_IsWindField(VolumetricCloudSDF *this, MethodInfo *method)
				// {
				//   Material *m_CloudMat; // rbx
				//   VolumetricShaderKeywords__StaticFields *static_fields; // rcx
				//   String *s_WindField; // rdx
				// 
				//   if ( !byte_18D91978C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
				//     byte_18D91978C = 1;
				//   }
				//   m_CloudMat = this.fields.m_CloudMat;
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
				//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
				//   s_WindField = static_fields.s_WindField;
				//   if ( !m_CloudMat )
				//     sub_180B536AC(static_fields, s_WindField);
				//   return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, s_WindField, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x000025D8 File Offset: 0x000007D8
		protected override bool HasVolumetricRenderItem
		{
			get
			{
				// // Boolean get_alwaysRebindOnRefresh()
				// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
				//         VerticalVirtualizationController_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 1;
				// }
				// 
				return default(bool);
			}
		}

		public VolumetricCloudSDF()
		{
			// // VolumetricCloudSDF()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::VolumetricCloudSDF(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   int32_t v2; // r8d
			//   MethodInfo *v3; // r9
			//   Vector3 *Vector; // rax
			//   float z; // ecx
			//   Animator *v7; // rdx
			//   int32_t v8; // r8d
			//   MethodInfo *v9; // r9
			//   Vector3 *v10; // rax
			//   float v11; // ecx
			//   Animator *v12; // rdx
			//   int32_t v13; // r8d
			//   MethodInfo *v14; // r9
			//   Vector3 *v15; // rax
			//   float v16; // ecx
			//   Animator *v17; // rdx
			//   int32_t v18; // r8d
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   float v21; // ecx
			//   Animator *v22; // rdx
			//   int32_t v23; // r8d
			//   MethodInfo *v24; // r9
			//   Vector3 *v25; // rax
			//   float v26; // ecx
			//   Animator *v27; // rdx
			//   int32_t v28; // r8d
			//   MethodInfo *v29; // r9
			//   Vector3 *v30; // rax
			//   float v31; // ecx
			//   VolumetricMSBake *v32; // rax
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   __int64 v34; // rcx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   HGCamera *v36; // r9
			//   Dictionary_2_System_Int32_System_Object_ *v37; // rax
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricFarCloudRenderer_ *v38; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   PassConstructorID__Enum__Array *v40; // r8
			//   HGCamera *v41; // r9
			//   MethodInfo *v42; // rdx
			//   Vector3 *one; // rax
			//   float v44; // ecx
			//   MethodInfo *v45; // rdx
			//   Vector3 *v46; // rax
			//   float v47; // ecx
			//   MethodInfo *v48; // rdx
			//   Vector3 *up; // rax
			//   float v50; // ecx
			//   _OWORD *v51; // rax
			//   __int128 v52; // xmm1
			//   __int128 v53; // xmm2
			//   __int128 v54; // xmm3
			//   _OWORD *v55; // rax
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm2
			//   __int128 v58; // xmm3
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v59; // rax
			//   List_1_HG_Rendering_Runtime_VolumetricWindFieldNode_ *v60; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v61; // rdx
			//   PassConstructorID__Enum__Array *v62; // r8
			//   HGCamera *v63; // r9
			//   Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *v64; // rax
			//   Dictionary_2_System_Int32_System_Boolean_ *v65; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v66; // rdx
			//   PassConstructorID__Enum__Array *v67; // r8
			//   HGCamera *v68; // r9
			//   Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *v69; // rax
			//   Dictionary_2_System_Int32_System_Boolean_ *v70; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v71; // rdx
			//   PassConstructorID__Enum__Array *v72; // r8
			//   HGCamera *v73; // r9
			//   Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *v74; // rax
			//   Dictionary_2_System_Int32_System_Boolean_ *v75; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v76; // rdx
			//   PassConstructorID__Enum__Array *v77; // r8
			//   HGCamera *v78; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v79; // rax
			//   List_1_UnityEngine_MeshRenderer_ *v80; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v81; // rdx
			//   PassConstructorID__Enum__Array *v82; // r8
			//   HGCamera *v83; // r9
			//   MethodInfo *v84; // [rsp+20h] [rbp-58h] BYREF
			//   MethodInfo *v85; // [rsp+28h] [rbp-50h]
			//   _BYTE v86[72]; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919796 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricMSBake);
			//     byte_18D919796 = 1;
			//   }
			//   Vector = UnityEngine::Animator::GetVector((Vector3 *)&v84, (Animator *)method, v2, v3);
			//   z = Vector.z;
			//   *(_QWORD *)&this.fields.m_WindPhase.x = *(_QWORD *)&Vector.x;
			//   this.fields.m_WindPhase.z = z;
			//   v10 = UnityEngine::Animator::GetVector((Vector3 *)&v84, v7, v8, v9);
			//   v11 = v10.z;
			//   *(_QWORD *)&this.fields.m_WindPhase2.x = *(_QWORD *)&v10.x;
			//   this.fields.m_WindPhase2.z = v11;
			//   v15 = UnityEngine::Animator::GetVector((Vector3 *)&v84, v12, v13, v14);
			//   v16 = v15.z;
			//   *(_QWORD *)&this.fields.m_WindPhase3.x = *(_QWORD *)&v15.x;
			//   this.fields.m_WindPhase3.z = v16;
			//   v20 = UnityEngine::Animator::GetVector((Vector3 *)&v84, v17, v18, v19);
			//   v21 = v20.z;
			//   *(_QWORD *)&this.fields.m_WindOffset.x = *(_QWORD *)&v20.x;
			//   this.fields.m_WindOffset.z = v21;
			//   v25 = UnityEngine::Animator::GetVector((Vector3 *)&v84, v22, v23, v24);
			//   v26 = v25.z;
			//   *(_QWORD *)&this.fields.m_WindOffset2.x = *(_QWORD *)&v25.x;
			//   this.fields.m_WindOffset2.z = v26;
			//   v30 = UnityEngine::Animator::GetVector((Vector3 *)&v84, v27, v28, v29);
			//   v31 = v30.z;
			//   *(_QWORD *)&this.fields.m_WindOffset3.x = *(_QWORD *)&v30.x;
			//   this.fields.m_WindOffset3.z = v31;
			//   *(_WORD *)&this.fields.m_DrawNear = 257;
			//   this.fields.m_msBakeSizeX = 16;
			//   this.fields.m_msBakeSizeY = 64;
			//   v32 = (VolumetricMSBake *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricMSBake);
			//   if ( !v32 )
			//     goto LABEL_11;
			//   this.fields.m_MSBaker = v32;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_MSBaker, v33, v35, v36, v84, v85);
			//   v37 = (Dictionary_2_System_Int32_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>);
			//   v38 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricFarCloudRenderer_ *)v37;
			//   if ( !v37 )
			//     goto LABEL_11;
			//   System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
			//     v37,
			//     MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Dictionary);
			//   this.fields.farRenderers = v38;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farRenderers, v39, v40, v41, v84, v85);
			//   one = UnityEngine::Vector3::get_one((Vector3 *)&v84, v42);
			//   v44 = one.z;
			//   *(_QWORD *)&this.fields.m_VoxelSize.x = *(_QWORD *)&one.x;
			//   this.fields.m_VoxelSize.z = v44;
			//   v46 = UnityEngine::Vector3::get_one((Vector3 *)&v84, v45);
			//   v47 = v46.z;
			//   *(_QWORD *)&this.fields.m_InvScale.x = *(_QWORD *)&v46.x;
			//   this.fields.m_InvScale.z = v47;
			//   up = UnityEngine::Vector3::get_up((Vector3 *)&v84, v48);
			//   v50 = up.z;
			//   *(_QWORD *)&this.fields.m_MainLightDirection.x = *(_QWORD *)&up.x;
			//   this.fields.m_MainLightDirection.z = v50;
			//   v51 = (_OWORD *)sub_182805160(v86);
			//   v52 = v51[1];
			//   v53 = v51[2];
			//   v54 = v51[3];
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m00 = *v51;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m01 = v52;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m02 = v53;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m03 = v54;
			//   v55 = (_OWORD *)sub_182805160(v86);
			//   v56 = v55[1];
			//   v57 = v55[2];
			//   v58 = v55[3];
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m00 = *v55;
			//   this.fields.m_OpticalDepthScale = 1.0;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m01 = v56;
			//   this.fields.m_InvOpticalDepthScale = 1.0;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m02 = v57;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m03 = v58;
			//   v59 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>);
			//   v60 = (List_1_HG_Rendering_Runtime_VolumetricWindFieldNode_ *)v59;
			//   if ( !v59 )
			//     goto LABEL_11;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v59,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::List);
			//   this.fields.m_WindFieldNodeList = v60;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_WindFieldNodeList, v61, v62, v63, v84, v85);
			//   v64 = (Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
			//   v65 = (Dictionary_2_System_Int32_System_Boolean_ *)v64;
			//   if ( !v64 )
			//     goto LABEL_11;
			//   System::Collections::Generic::Dictionary<int,Beyond::UI::UIText_RichTextAnalyzer::RichTextTag>::Dictionary(
			//     v64,
			//     MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary);
			//   this.fields._visibleStates = v65;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._visibleStates, v66, v67, v68, v84, v85);
			//   v69 = (Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
			//   v70 = (Dictionary_2_System_Int32_System_Boolean_ *)v69;
			//   if ( !v69 )
			//     goto LABEL_11;
			//   System::Collections::Generic::Dictionary<int,Beyond::UI::UIText_RichTextAnalyzer::RichTextTag>::Dictionary(
			//     v69,
			//     MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary);
			//   this.fields._loadingStates = v70;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._loadingStates, v71, v72, v73, v84, v85);
			//   v74 = (Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
			//   v75 = (Dictionary_2_System_Int32_System_Boolean_ *)v74;
			//   if ( !v74
			//     || (System::Collections::Generic::Dictionary<int,Beyond::UI::UIText_RichTextAnalyzer::RichTextTag>::Dictionary(
			//           v74,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary),
			//         this.fields._fadeInStates = v75,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields._fadeInStates, v76, v77, v78, v84, v85),
			//         v79 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>),
			//         (v80 = (List_1_UnityEngine_MeshRenderer_ *)v79) == 0LL) )
			//   {
			// LABEL_11:
			//     sub_180B536AC(v34, v33);
			//   }
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v79,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::List);
			//   this.fields._renderers = v80;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._renderers, v81, v82, v83, v84, v85);
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public void AddWindFieldNode(VolumetricWindFieldNode node)
		{
			// // Void AddWindFieldNode(VolumetricWindFieldNode)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::AddWindFieldNode(
			//         VolumetricCloudSDF *this,
			//         VolumetricWindFieldNode *node,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_WindFieldNodeList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919772 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::Add);
			//     byte_18D919772 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4357, 0LL) )
			//   {
			//     if ( !node )
			//       return;
			//     m_WindFieldNodeList = (List_1_System_Object_ *)this.fields.m_WindFieldNodeList;
			//     if ( m_WindFieldNodeList )
			//     {
			//       sub_1822AD140(m_WindFieldNodeList, (Object *)node);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_WindFieldNodeList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4357, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)node,
			//     0LL);
			// }
			// 
		}

		public void AddWindField(VolumetricWindField windField)
		{
			// // Void AddWindField(VolumetricWindField)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::AddWindField(
			//         VolumetricCloudSDF *this,
			//         VolumetricWindField *windField,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4358, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4358, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)windField,
			//       0LL);
			//   }
			//   else if ( this.fields.m_WindFieldManager )
			//   {
			//     HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
			//       this.fields.m_WindFieldManager,
			//       (IVolumetricWindField *)windField,
			//       0LL);
			//   }
			// }
			// 
		}

		public void RemoveWindField(VolumetricWindField windField)
		{
			// // Void RemoveWindField(VolumetricWindField)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::RemoveWindField(
			//         VolumetricCloudSDF *this,
			//         VolumetricWindField *windField,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4360, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4360, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)windField,
			//       0LL);
			//   }
			//   else if ( this.fields.m_WindFieldManager )
			//   {
			//     HG::Rendering::Runtime::VolumetricWindFieldManager::RemoveWindField(
			//       this.fields.m_WindFieldManager,
			//       (IVolumetricWindField *)windField,
			//       0LL);
			//   }
			// }
			// 
		}

		public bool Contains(Vector3 position)
		{
			// // Boolean Contains(Vector3)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::Contains(
			//         VolumetricCloudSDF *this,
			//         Vector3 *position,
			//         MethodInfo *method)
			// {
			//   float v5; // eax
			//   BeyondPolyLineShape *polyLineShape; // rcx
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v11[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4362, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4362, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v8);
			//     z = position.z;
			//     *(_QWORD *)&v11[0].x = *(_QWORD *)&position.x;
			//     v11[0].z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(Patch, (Object *)this, v11, 0LL);
			//   }
			//   else if ( this.fields.m_ForceVisible )
			//   {
			//     return 1;
			//   }
			//   else if ( this.fields._polyLineShape )
			//   {
			//     v5 = position.z;
			//     polyLineShape = this.fields._polyLineShape;
			//     *(_QWORD *)&v11[0].x = *(_QWORD *)&position.x;
			//     v11[0].z = v5;
			//     return Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(polyLineShape, v11, 0.1, 0LL) > 0.0;
			//   }
			//   else
			//   {
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public void UpdateVisibility(HGCamera camera, bool visible)
		{
			// // Void UpdateVisibility(HGCamera, Boolean)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateVisibility(
			//         VolumetricCloudSDF *this,
			//         HGCamera *camera,
			//         bool visible,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Object_1 *visibleStates; // rcx
			//   int32_t InstanceID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919773 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
			//     byte_18D919773 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4363, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       visibleStates = (Object_1 *)camera.fields.camera;
			//       if ( visibleStates )
			//       {
			//         InstanceID = UnityEngine::Object::GetInstanceID(visibleStates, 0LL);
			//         visibleStates = (Object_1 *)this.fields._visibleStates;
			//         if ( visibleStates )
			//         {
			//           System::Collections::Generic::Dictionary<int,bool>::set_Item(
			//             (Dictionary_2_System_Int32_System_Boolean_ *)visibleStates,
			//             InstanceID,
			//             visible,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(visibleStates, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4363, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
			//     (ILFixDynamicMethodWrapper_9 *)Patch,
			//     (Object *)this,
			//     (Object *)camera,
			//     visible,
			//     0LL);
			// }
			// 
		}

		public void FadeInVolume(HGCamera camera)
		{
			// // Void FadeInVolume(HGCamera)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::FadeInVolume(
			//         VolumetricCloudSDF *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Object_1 *fadeInStates; // rcx
			//   int32_t InstanceID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919774 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
			//     byte_18D919774 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4364, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       fadeInStates = (Object_1 *)camera.fields.camera;
			//       if ( fadeInStates )
			//       {
			//         InstanceID = UnityEngine::Object::GetInstanceID(fadeInStates, 0LL);
			//         fadeInStates = (Object_1 *)this.fields._fadeInStates;
			//         if ( fadeInStates )
			//         {
			//           System::Collections::Generic::Dictionary<int,bool>::set_Item(
			//             (Dictionary_2_System_Int32_System_Boolean_ *)fadeInStates,
			//             InstanceID,
			//             1,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(fadeInStates, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4364, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		private bool IsAnyVisibleInScene()
		{
			// // Boolean IsAnyVisibleInScene()
			// // Hidden C++ exception states: #wind=1
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyVisibleInScene(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Dictionary_2_System_Int32_System_Boolean_ *visibleStates; // rbx
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *v6; // rax
			//   bool v7; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Il2CppExceptionWrapper *v12; // [rsp+20h] [rbp-58h] BYREF
			//   _QWORD v13[4]; // [rsp+28h] [rbp-50h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ v14; // [rsp+48h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919775 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,bool>::get_Value);
			//     byte_18D919775 = 1;
			//   }
			//   memset(&v14, 0, sizeof(v14));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4365, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4365, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   visibleStates = this.fields._visibleStates;
			//   if ( !visibleStates )
			//     sub_180B536AC(v4, v3);
			//   v6 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *)sub_180833550(v13, visibleStates);
			//   v14 = *v6;
			//   v13[0] = 0LL;
			//   v13[1] = &v14;
			//   while ( 1 )
			//   {
			//     try
			//     {
			//       v7 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext(
			//              &v14,
			//              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     }
			//     catch ( Il2CppExceptionWrapper *v12 )
			//     {
			//       v13[0] = v12.ex;
			//       if ( v13[0] )
			//         sub_18000F780(v13[0]);
			//       return 0;
			//     }
			//     if ( !v7 )
			//       return 0;
			//     if ( v14._current.value )
			//       return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		private bool IsVisibleFromCamera(HGCamera camera)
		{
			// // Boolean IsVisibleFromCamera(HGCamera)
			// // Hidden C++ exception states: #wind=1
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(
			//         VolumetricCloudSDF *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object_1 *v7; // rbx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int32_t InstanceID; // edi
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *v11; // rax
			//   bool v12; // al
			//   __int64 v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   bool result; // al
			//   Il2CppExceptionWrapper *v18; // [rsp+20h] [rbp-58h] BYREF
			//   _QWORD v19[4]; // [rsp+28h] [rbp-50h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ v20; // [rsp+48h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919776 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,bool>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,bool>::get_Value);
			//     byte_18D919776 = 1;
			//   }
			//   memset(&v20, 0, sizeof(v20));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4366, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4366, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     LOBYTE(v13) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//                     (ILFixDynamicMethodWrapper_36 *)Patch,
			//                     (Object *)this,
			//                     (Object *)camera,
			//                     0LL);
			//     goto LABEL_26;
			//   }
			//   if ( !camera )
			//     sub_180B536AC(v6, v5);
			//   v7 = (Object_1 *)camera.fields.camera;
			//   if ( !v7 )
			//     sub_180B536AC(v6, v5);
			//   InstanceID = UnityEngine::Object::GetInstanceID(v7, 0LL);
			//   if ( !this.fields._visibleStates )
			//     sub_180B536AC(v9, v8);
			//   v11 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *)sub_180833550(
			//                                                                               v19,
			//                                                                               this.fields._visibleStates);
			//   v20 = *v11;
			//   v19[0] = 0LL;
			//   v19[1] = &v20;
			//   while ( 1 )
			//   {
			//     try
			//     {
			//       v12 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext(
			//               &v20,
			//               MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     }
			//     catch ( Il2CppExceptionWrapper *v18 )
			//     {
			//       v19[0] = v18.ex;
			//       if ( v19[0] )
			//         sub_18000F780(v19[0]);
			// LABEL_12:
			//       LOBYTE(v13) = 0;
			// LABEL_26:
			//       result = v13;
			//     }
			//     if ( !v12 )
			//       goto LABEL_12;
			//     if ( v20._current.key == InstanceID )
			//     {
			//       v13 = HIDWORD(*(_QWORD *)&v20._current);
			//       goto LABEL_26;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		private bool IsFadeInFromCamera(HGCamera camera)
		{
			// // Boolean IsFadeInFromCamera(HGCamera)
			// // Hidden C++ exception states: #wind=1
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFadeInFromCamera(
			//         VolumetricCloudSDF *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object_1 *v7; // rbx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int32_t InstanceID; // edi
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *v11; // rax
			//   bool v12; // al
			//   __int64 v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   bool result; // al
			//   Il2CppExceptionWrapper *v18; // [rsp+20h] [rbp-58h] BYREF
			//   _QWORD v19[4]; // [rsp+28h] [rbp-50h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ v20; // [rsp+48h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919777 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,bool>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,bool>::get_Value);
			//     byte_18D919777 = 1;
			//   }
			//   memset(&v20, 0, sizeof(v20));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4367, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4367, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     LOBYTE(v13) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//                     (ILFixDynamicMethodWrapper_36 *)Patch,
			//                     (Object *)this,
			//                     (Object *)camera,
			//                     0LL);
			//     goto LABEL_26;
			//   }
			//   if ( !camera )
			//     sub_180B536AC(v6, v5);
			//   v7 = (Object_1 *)camera.fields.camera;
			//   if ( !v7 )
			//     sub_180B536AC(v6, v5);
			//   InstanceID = UnityEngine::Object::GetInstanceID(v7, 0LL);
			//   if ( !this.fields._fadeInStates )
			//     sub_180B536AC(v9, v8);
			//   v11 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *)sub_180833550(
			//                                                                               v19,
			//                                                                               this.fields._fadeInStates);
			//   v20 = *v11;
			//   v19[0] = 0LL;
			//   v19[1] = &v20;
			//   while ( 1 )
			//   {
			//     try
			//     {
			//       v12 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext(
			//               &v20,
			//               MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     }
			//     catch ( Il2CppExceptionWrapper *v18 )
			//     {
			//       v19[0] = v18.ex;
			//       if ( v19[0] )
			//         sub_18000F780(v19[0]);
			// LABEL_12:
			//       LOBYTE(v13) = 0;
			// LABEL_26:
			//       result = v13;
			//     }
			//     if ( !v12 )
			//       goto LABEL_12;
			//     if ( v20._current.key == InstanceID )
			//     {
			//       v13 = HIDWORD(*(_QWORD *)&v20._current);
			//       goto LABEL_26;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		public void PrepareAssets(HGCamera camera)
		{
			// // Void PrepareAssets(HGCamera)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::PrepareAssets(
			//         VolumetricCloudSDF *this,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_CloudAsset; // rbx
			//   __int64 v6; // rdx
			//   Object_1 *loadingStates; // rcx
			//   int32_t InstanceID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919778 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919778 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4368, 0LL) )
			//   {
			//     m_CloudAsset = (Object_1 *)this.fields.m_CloudAsset;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
			//       return;
			//     if ( camera )
			//     {
			//       loadingStates = (Object_1 *)camera.fields.camera;
			//       if ( loadingStates )
			//       {
			//         InstanceID = UnityEngine::Object::GetInstanceID(loadingStates, 0LL);
			//         loadingStates = (Object_1 *)this.fields._loadingStates;
			//         if ( loadingStates )
			//         {
			//           System::Collections::Generic::Dictionary<int,bool>::set_Item(
			//             (Dictionary_2_System_Int32_System_Boolean_ *)loadingStates,
			//             InstanceID,
			//             1,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(loadingStates, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4368, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)camera,
			//     0LL);
			// }
			// 
		}

		private bool IsAnyLoadingInScene()
		{
			// // Boolean IsAnyLoadingInScene()
			// // Hidden C++ exception states: #wind=1
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyLoadingInScene(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Dictionary_2_System_Int32_System_Boolean_ *loadingStates; // rbx
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *v6; // rax
			//   bool v7; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Il2CppExceptionWrapper *v12; // [rsp+20h] [rbp-58h] BYREF
			//   _QWORD v13[4]; // [rsp+28h] [rbp-50h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ v14; // [rsp+48h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919779 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,bool>::get_Value);
			//     byte_18D919779 = 1;
			//   }
			//   memset(&v14, 0, sizeof(v14));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4369, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4369, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   loadingStates = this.fields._loadingStates;
			//   if ( !loadingStates )
			//     sub_180B536AC(v4, v3);
			//   v6 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *)sub_180833550(v13, loadingStates);
			//   v14 = *v6;
			//   v13[0] = 0LL;
			//   v13[1] = &v14;
			//   while ( 1 )
			//   {
			//     try
			//     {
			//       v7 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext(
			//              &v14,
			//              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
			//     }
			//     catch ( Il2CppExceptionWrapper *v12 )
			//     {
			//       v13[0] = v12.ex;
			//       if ( v13[0] )
			//         sub_18000F780(v13[0]);
			//       return 0;
			//     }
			//     if ( !v7 )
			//       return 0;
			//     if ( v14._current.value )
			//       return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		public bool LoadFinished()
		{
			// // Boolean LoadFinished()
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::LoadFinished(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   Object_1 *m_CloudAsset; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D91977A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91977A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4370, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4370, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_CloudAsset = (Object_1 *)this.fields.m_CloudAsset;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     return UnityEngine::Object::op_Equality(m_CloudAsset, 0LL, 0LL)
			//         || HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(this, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		private new void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::OnEnable(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   VolumetricCloudVolumeManager *volumetricCloudVolumeManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4371, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//     {
			// LABEL_6:
			//       HG::Rendering::Runtime::VolumetricRenderObject::OnEnable((VolumetricRenderObject *)this, 0LL);
			//       HG::Rendering::Runtime::VolumetricCloudSDF::Initialize(this, 0LL);
			//       return;
			//     }
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       volumetricCloudVolumeManager_k__BackingField = currentManagerContext.fields._volumetricCloudVolumeManager_k__BackingField;
			//       if ( volumetricCloudVolumeManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::VolumetricCloudVolumeManager::RegisterCloudVolume(
			//           volumetricCloudVolumeManager_k__BackingField,
			//           (IVolumetricCloudVolume *)this,
			//           0LL);
			//         goto LABEL_6;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(volumetricCloudVolumeManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4371, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void Initialize()
		{
			// // Void Initialize()
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::VolumetricCloudSDF::Initialize(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   VolumetricCloudSDF *v2; // rsi
			//   Animator *v3; // rdx
			//   int32_t v4; // r8d
			//   MethodInfo *v5; // r9
			//   Vector3 *Vector; // rax
			//   float z; // ecx
			//   __int64 v8; // xmm1_8
			//   Transform *transform; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   ArgumentNullException *v15; // rbx
			//   Component *RelativeTransformWithPath; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   GameObject *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   GameObject *v25; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v26; // rdx
			//   PassConstructorID__Enum__Array *v27; // r8
			//   HGCamera *v28; // r9
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   Transform *v31; // rbx
			//   Transform *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   Transform *v37; // rbx
			//   Animator *v38; // rdx
			//   int32_t v39; // r8d
			//   MethodInfo *v40; // r9
			//   Vector3 *v41; // rax
			//   __int64 v42; // xmm6_8
			//   float v43; // r14d
			//   MethodInfo *v44; // rdx
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   __m128i v47; // xmm7
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   Transform *v50; // rbx
			//   MethodInfo *v51; // rdx
			//   Vector3 *one; // rax
			//   __int64 v53; // rdx
			//   __int64 v54; // rcx
			//   float v55; // r14d
			//   GameObject *m_CloudObject; // rbx
			//   Object *v57; // rbx
			//   Mesh *CubeMesh; // rax
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   VolumetricWindFieldManager *v61; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   VolumetricWindFieldManager *v64; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v65; // rdx
			//   PassConstructorID__Enum__Array *v66; // r8
			//   HGCamera *v67; // r9
			//   __int64 v68; // rdx
			//   __int64 v69; // rcx
			//   Object__Array *v70; // r14
			//   int32_t i; // ebx
			//   __int64 v72; // rdx
			//   VolumetricWindFieldManager *m_WindFieldManager; // rcx
			//   struct MaterialPropertyBlock__Class *element_class; // rbx
			//   __int64 v75; // rax
			//   __int64 v76; // rdx
			//   __int64 instance_size; // rcx
			//   MaterialPropertyBlock *v78; // r14
			//   __int64 v79; // rdx
			//   __int64 v80; // rcx
			//   unsigned __int64 v81; // r8
			//   signed __int64 v82; // rtt
			//   struct MaterialPropertyBlock__Class *v83; // rbx
			//   __int64 v84; // rax
			//   __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   MaterialPropertyBlock *v87; // r15
			//   unsigned __int64 v88; // rcx
			//   signed __int64 v89; // rtt
			//   struct MaterialPropertyBlock__Class *v90; // rbx
			//   __int64 v91; // rax
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   MaterialPropertyBlock *v94; // r15
			//   unsigned __int64 v95; // r8
			//   signed __int64 v96; // rtt
			//   Object_1 *m_CloudMat; // rbx
			//   Material *v98; // rbx
			//   Material *v99; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v101; // rdx
			//   __int64 v102; // rcx
			//   String *v103; // rax
			//   __int64 v104; // rax
			//   MethodInfo *v105; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *v106; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *v107; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *v108; // [rsp+28h] [rbp-C0h]
			//   Il2CppExceptionWrapper *v109; // [rsp+30h] [rbp-B8h] BYREF
			//   Vector3 localPosition; // [rsp+40h] [rbp-A8h] BYREF
			//   Il2CppException *ex; // [rsp+50h] [rbp-98h] BYREF
			//   List_1_T_Enumerator_System_Object_ *v112; // [rsp+58h] [rbp-90h]
			//   List_1_T_Enumerator_System_Object_ localRotation; // [rsp+60h] [rbp-88h] BYREF
			//   List_1_T_Enumerator_System_Object_ v114; // [rsp+80h] [rbp-68h] BYREF
			//   __int64 *v116; // [rsp+100h] [rbp+18h] BYREF
			//   char v117; // [rsp+108h] [rbp+20h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D91977B )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponentsInChildren<HG::Rendering::Runtime::VolumetricWindField>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::get_Current);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricWindFieldManager);
			//     sub_18003C530(&off_18D5206F0);
			//     byte_18D91977B = 1;
			//   }
			//   memset(&v114, 0, sizeof(v114));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4375, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4375, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v102, v101);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     Vector = UnityEngine::Animator::GetVector((Vector3 *)&ex, v3, v4, v5);
			//     z = Vector.z;
			//     v8 = *(_QWORD *)&Vector.x;
			//     *(_QWORD *)&v2.fields.m_WindPhase3.x = *(_QWORD *)&Vector.x;
			//     v2.fields.m_WindPhase3.z = z;
			//     *(_QWORD *)&v2.fields.m_WindPhase2.x = v8;
			//     v2.fields.m_WindPhase2.z = z;
			//     *(_QWORD *)&v2.fields.m_WindPhase.x = v8;
			//     v2.fields.m_WindPhase.z = z;
			//     transform = UnityEngine::Component::get_transform((Component *)v2, 0LL);
			//     if ( !transform )
			//       sub_180B536AC(v11, v10);
			//     if ( !"Cloud Object" )
			//     {
			//       v12 = sub_18000F7E0(&TypeInfo::System::ArgumentNullException);
			//       v15 = (ArgumentNullException *)sub_180004920(v12);
			//       if ( !v15 )
			//         sub_180B536AC(v14, v13);
			//       v103 = (String *)sub_18000F7E0(&off_18D5D2510);
			//       System::ArgumentNullException::ArgumentNullException(v15, v103, 0LL);
			//       v104 = sub_18000F7E0(MethodInfo::UnityEngine::Transform::Find);
			//       sub_18000F7C0(v15, v104);
			//     }
			//     RelativeTransformWithPath = (Component *)UnityEngine::Transform::FindRelativeTransformWithPath(
			//                                                transform,
			//                                                (String *)"Cloud Object",
			//                                                0,
			//                                                0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)RelativeTransformWithPath, 0LL) )
			//     {
			//       if ( !RelativeTransformWithPath )
			//         sub_180B536AC(v18, v17);
			//       v2.fields.m_CloudObject = UnityEngine::Component::get_gameObject(RelativeTransformWithPath, 0LL);
			//       sub_1800054D0((HGRenderPathScene *)&v2.fields.m_CloudObject, v19, v20, v21, v105, v107);
			//     }
			//     else
			//     {
			//       v22 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//       v25 = v22;
			//       if ( !v22 )
			//         sub_180B536AC(v24, v23);
			//       UnityEngine::GameObject::GameObject(v22, (String *)"Cloud Object", 0LL);
			//       v2.fields.m_CloudObject = v25;
			//       sub_1800054D0((HGRenderPathScene *)&v2.fields.m_CloudObject, v26, v27, v28, v105, v107);
			//       if ( !v2.fields.m_CloudObject )
			//         sub_180B536AC(v30, v29);
			//       v31 = UnityEngine::GameObject::get_transform(v2.fields.m_CloudObject, 0LL);
			//       v32 = UnityEngine::Component::get_transform((Component *)v2, 0LL);
			//       if ( !v31 )
			//         sub_180B536AC(v34, v33);
			//       UnityEngine::Transform::set_parent(v31, v32, 0LL);
			//       if ( !v2.fields.m_CloudObject )
			//         sub_180B536AC(v36, v35);
			//       v37 = UnityEngine::GameObject::get_transform(v2.fields.m_CloudObject, 0LL);
			//       v41 = UnityEngine::Animator::GetVector((Vector3 *)&ex, v38, v39, v40);
			//       v42 = *(_QWORD *)&v41.x;
			//       v43 = v41.z;
			//       v47 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity((Quaternion *)&localRotation, v44));
			//       if ( !v37 )
			//         sub_180B536AC(v46, v45);
			//       *(__m128i *)&localRotation._list = v47;
			//       *(_QWORD *)&localPosition.x = v42;
			//       localPosition.z = v43;
			//       UnityEngine::Transform::SetLocalPositionAndRotation_Injected(
			//         v37,
			//         &localPosition,
			//         (Quaternion *)&localRotation,
			//         0LL);
			//       if ( !v2.fields.m_CloudObject )
			//         sub_180B536AC(v49, v48);
			//       v50 = UnityEngine::GameObject::get_transform(v2.fields.m_CloudObject, 0LL);
			//       one = UnityEngine::Vector3::get_one((Vector3 *)&ex, v51);
			//       v55 = one.z;
			//       if ( !v50 )
			//         sub_180B536AC(v54, v53);
			//       ex = *(Il2CppException **)&one.x;
			//       *(float *)&v112 = v55;
			//       UnityEngine::Transform::set_localScale(v50, (Vector3 *)&ex, 0LL);
			//       m_CloudObject = v2.fields.m_CloudObject;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v57 = HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<System::Object>(
			//               m_CloudObject,
			//               MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<UnityEngine::MeshFilter>);
			//       CubeMesh = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
			//       if ( !v57 )
			//         sub_180B536AC(v60, v59);
			//       UnityEngine::MeshFilter::set_sharedMesh((MeshFilter *)v57, CubeMesh, 0LL);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<System::Object>(
			//         v2.fields.m_CloudObject,
			//         MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<UnityEngine::MeshRenderer>);
			//     }
			//     v61 = (VolumetricWindFieldManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricWindFieldManager);
			//     v64 = v61;
			//     if ( !v61 )
			//       sub_180B536AC(v63, v62);
			//     HG::Rendering::Runtime::VolumetricWindFieldManager::VolumetricWindFieldManager(v61, 0LL);
			//     v2.fields.m_WindFieldManager = v64;
			//     sub_1800054D0((HGRenderPathScene *)&v2.fields.m_WindFieldManager, v65, v66, v67, v106, v108);
			//     v70 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
			//             (Component *)v2,
			//             MethodInfo::UnityEngine::Component::GetComponentsInChildren<HG::Rendering::Runtime::VolumetricWindField>);
			//     for ( i = 0; ; ++i )
			//     {
			//       if ( !v70 )
			//         sub_180B536AC(v69, v68);
			//       if ( i >= v70.max_length.size )
			//         break;
			//       if ( (unsigned int)i >= v70.max_length.size )
			//         sub_180070270(v69, v68);
			//       if ( !v2.fields.m_WindFieldManager )
			//         sub_180B536AC(v69, v68);
			//       HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
			//         v2.fields.m_WindFieldManager,
			//         (IVolumetricWindField *)v70.vector[i],
			//         0LL);
			//     }
			//     if ( !v2.fields.m_WindFieldNodeList )
			//       sub_180B536AC(v69, v68);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &localRotation,
			//       (List_1_System_Object_ *)v2.fields.m_WindFieldNodeList,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::GetEnumerator);
			//     v114 = localRotation;
			//     ex = 0LL;
			//     v112 = &v114;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v114,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::MoveNext) )
			//       {
			//         m_WindFieldManager = v2.fields.m_WindFieldManager;
			//         if ( !m_WindFieldManager )
			//           sub_1802DC2C8(0LL, v72);
			//         HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
			//           m_WindFieldManager,
			//           (IVolumetricWindField *)v114._current,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v109 )
			//     {
			//       ex = v109.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			//     }
			//     element_class = TypeInfo::UnityEngine::MaterialPropertyBlock;
			//     if ( ((__int64)TypeInfo::UnityEngine::MaterialPropertyBlock.vtable.Equals.methodPtr & 2) == 0 )
			//     {
			//       v116 = &qword_18CDB0B30;
			//       sub_1802924D0(&qword_18CDB0B30);
			//       sub_180060090(element_class, &v116);
			//       sub_180292530(v116);
			//     }
			//     if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//       element_class = (struct MaterialPropertyBlock__Class *)element_class._0.element_class;
			//     if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//     {
			//       instance_size = element_class._1.instance_size;
			//       if ( element_class._0.gc_desc )
			//         v75 = sub_180004F80(instance_size, element_class);
			//       else
			//         v75 = sub_180005D40(instance_size, element_class);
			//     }
			//     else
			//     {
			//       v75 = sub_180005FB0(element_class);
			//     }
			//     v78 = (MaterialPropertyBlock *)v75;
			//     if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//       sub_18002E8C0(v75, (unsigned int)sub_18007DC30, 0, (unsigned int)&v117, (__int64)&v116);
			//     if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//       sub_1802DAEC4(v78, element_class);
			//     il2cpp_runtime_class_init_0(element_class, v76);
			//     if ( !v78 )
			//       goto LABEL_115;
			//     v78.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//     v2.fields.m_propertyBlock = v78;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v81 = (((unsigned __int64)&v2.fields.m_propertyBlock >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v81 + 36190]);
			//       do
			//         v82 = qword_18D6405E0[v81 + 36190];
			//       while ( v82 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v81 + 36190],
			//                        v82 | (1LL << (((unsigned __int64)&v2.fields.m_propertyBlock >> 12) & 0x3F)),
			//                        v82) );
			//     }
			//     v83 = TypeInfo::UnityEngine::MaterialPropertyBlock;
			//     if ( ((__int64)TypeInfo::UnityEngine::MaterialPropertyBlock.vtable.Equals.methodPtr & 2) == 0 )
			//     {
			//       v116 = &qword_18CDB0B30;
			//       sub_1802924D0(&qword_18CDB0B30);
			//       sub_180060090(v83, &v116);
			//       sub_180292530(v116);
			//     }
			//     if ( v83._0.generic_class && ((__int64)v83.vtable.Equals.methodPtr & 8) != 0 )
			//       v83 = (struct MaterialPropertyBlock__Class *)v83._0.element_class;
			//     if ( ((__int64)v83.vtable.Equals.methodPtr & 0x20) != 0 )
			//     {
			//       v86 = v83._1.instance_size;
			//       if ( v83._0.gc_desc )
			//         v84 = sub_180004F80(v86, v83);
			//       else
			//         v84 = sub_180005D40(v86, v83);
			//     }
			//     else
			//     {
			//       v84 = sub_180005FB0(v83);
			//     }
			//     v87 = (MaterialPropertyBlock *)v84;
			//     if ( (BYTE1(v83.vtable.Equals.methodPtr) & 2) != 0 )
			//       sub_18002E8C0(v84, (unsigned int)sub_18007DC30, 0, (unsigned int)&v117, (__int64)&v116);
			//     if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//       sub_1802DAEC4(v87, v83);
			//     il2cpp_runtime_class_init_0(v83, v85);
			//     if ( !v87 )
			//       goto LABEL_115;
			//     v87.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//     v2.fields.m_composePropertyBlock = v87;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v88 = (((unsigned __int64)&v2.fields.m_composePropertyBlock >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v88 + 36190]);
			//       do
			//         v89 = qword_18D6405E0[v88 + 36190];
			//       while ( v89 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v88 + 36190],
			//                        v89 | (1LL << (((unsigned __int64)&v2.fields.m_composePropertyBlock >> 12) & 0x3F)),
			//                        v89) );
			//     }
			//     v90 = TypeInfo::UnityEngine::MaterialPropertyBlock;
			//     if ( ((__int64)TypeInfo::UnityEngine::MaterialPropertyBlock.vtable.Equals.methodPtr & 2) == 0 )
			//     {
			//       v116 = &qword_18CDB0B30;
			//       sub_1802924D0(&qword_18CDB0B30);
			//       sub_180060090(v90, &v116);
			//       sub_180292530(v116);
			//     }
			//     if ( v90._0.generic_class && ((__int64)v90.vtable.Equals.methodPtr & 8) != 0 )
			//       v90 = (struct MaterialPropertyBlock__Class *)v90._0.element_class;
			//     if ( ((__int64)v90.vtable.Equals.methodPtr & 0x20) != 0 )
			//     {
			//       v93 = v90._1.instance_size;
			//       if ( v90._0.gc_desc )
			//       {
			//         v91 = sub_180005220(v93, v90);
			//         _InterlockedIncrement64(&qword_18D8E51F8);
			//       }
			//       else
			//       {
			//         v91 = sub_180005D40(v93, v90);
			//       }
			//     }
			//     else
			//     {
			//       v91 = sub_180005FB0(v90);
			//     }
			//     v94 = (MaterialPropertyBlock *)v91;
			//     if ( (BYTE1(v90.vtable.Equals.methodPtr) & 2) != 0 )
			//       sub_18002E8C0(v91, (unsigned int)sub_18007DC30, 0, (unsigned int)&v117, (__int64)&v116);
			//     if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//       sub_1802DAEC4(v94, v90);
			//     il2cpp_runtime_class_init_0(v90, v92);
			//     if ( !v94 )
			//       goto LABEL_115;
			//     v94.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//     v2.fields.m_emptySkipPropertyBlock = v94;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v95 = (((unsigned __int64)&v2.fields.m_emptySkipPropertyBlock >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v95 + 36190]);
			//       do
			//         v96 = qword_18D6405E0[v95 + 36190];
			//       while ( v96 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v95 + 36190],
			//                        v96 | (1LL << (((unsigned __int64)&v2.fields.m_emptySkipPropertyBlock >> 12) & 0x3F)),
			//                        v96) );
			//     }
			//     m_CloudMat = (Object_1 *)v2.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     {
			//       v98 = v2.fields.m_CloudMat;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       if ( v98 )
			//       {
			//         UnityEngine::Material::SetFloatImpl(
			//           v98,
			//           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._Cull,
			//           (float)(2 - v2.fields.m_inside),
			//           0LL);
			//         v99 = v2.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         if ( v99 )
			//         {
			//           UnityEngine::Material::SetFloatImpl(
			//             v99,
			//             TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._ZTest,
			//             (float)(!v2.fields.m_inside ? 4 : 0),
			//             0LL);
			//           if ( UnityEngine::Application::get_isPlaying(0LL) )
			//             v2.fields.m_DrawNear = 1;
			//           HG::Rendering::Runtime::VolumetricCloudSDF::UpdateOnce(v2, 1, 0LL);
			//           return;
			//         }
			//       }
			// LABEL_115:
			//       sub_1802DC2C8(v80, v79);
			//     }
			//   }
			// }
			// 
		}

		private new void OnDisable()
		{
			// // Void OnDisable()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VolumetricCloudSDF::OnDisable(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   VolumetricCloudSDF *v2; // rdi
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 *v7; // rdx
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *farRenderers; // rcx
			//   unsigned __int64 v9; // r10
			//   signed __int64 v10; // rtt
			//   unsigned __int64 v11; // r10
			//   signed __int64 v12; // rtt
			//   unsigned __int64 v13; // r10
			//   signed __int64 v14; // rtt
			//   unsigned __int64 v15; // r8
			//   unsigned __int64 v16; // r9
			//   char v17; // r8
			//   signed __int64 v18; // rtt
			//   HGManagerContext *currentManagerContext; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   __int64 v23; // [rsp+0h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v24; // [rsp+20h] [rbp-78h] BYREF
			//   Il2CppException *ex; // [rsp+28h] [rbp-70h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v26; // [rsp+30h] [rbp-68h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v27; // [rsp+38h] [rbp-60h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v28; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D91977C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::Clear);
			//     byte_18D91977C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4394, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4394, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v22, v21);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricCloudSDF::ClearFrameStates(v2, 0LL);
			//     HG::Rendering::Runtime::VolumetricCloudSDF::ReleaseCloudAsset(v2, 0LL);
			//     if ( !v2.fields.m_MSBaker )
			//       sub_180B536AC(v4, v3);
			//     HG::Rendering::Runtime::VolumetricMSBake::Release(v2.fields.m_MSBaker, 0LL);
			//     if ( !v2.fields.farRenderers )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v28,
			//       (Dictionary_2_System_Object_System_Object_ *)v2.fields.farRenderers,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::GetEnumerator);
			//     v27 = v28;
			//     ex = 0LL;
			//     v26 = &v27;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v27,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::MoveNext) )
			//       {
			//         if ( !v27._current.value )
			//           sub_1802DC2C8(0LL, v7);
			//         HG::Rendering::Runtime::VolumetricFarCloudRenderer::Release(
			//           (VolumetricFarCloudRenderer *)v27._current.value,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v24 )
			//     {
			//       v7 = &v23;
			//       ex = v24.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			//     }
			//     farRenderers = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields.farRenderers;
			//     if ( !farRenderers )
			//       goto LABEL_37;
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//       farRenderers,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Clear);
			//     farRenderers = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields.m_WindFieldNodeList;
			//     if ( !farRenderers )
			//       goto LABEL_37;
			//     sub_1823B99D0(
			//       farRenderers,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::Clear);
			//     if ( v2.fields.m_WindFieldManager )
			//     {
			//       HG::Rendering::Runtime::VolumetricWindFieldManager::Release(v2.fields.m_WindFieldManager, 0LL);
			//       v2.fields.m_WindFieldManager = 0LL;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v9 = (((unsigned __int64)&v2.fields.m_WindFieldManager >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v9 + 36190]);
			//         do
			//           v10 = qword_18D6405E0[v9 + 36190];
			//         while ( v10 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v9 + 36190],
			//                          v10 | (1LL << (((unsigned __int64)&v2.fields.m_WindFieldManager >> 12) & 0x3F)),
			//                          v10) );
			//       }
			//     }
			//     v2.fields.m_propertyBlock = 0LL;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v11 = (((unsigned __int64)&v2.fields.m_propertyBlock >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v11 + 36190]);
			//       do
			//         v12 = qword_18D6405E0[v11 + 36190];
			//       while ( v12 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v11 + 36190],
			//                        v12 | (1LL << (((unsigned __int64)&v2.fields.m_propertyBlock >> 12) & 0x3F)),
			//                        v12) );
			//     }
			//     v2.fields.m_composePropertyBlock = 0LL;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v13 = (((unsigned __int64)&v2.fields.m_composePropertyBlock >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v13 + 36190]);
			//       do
			//         v14 = qword_18D6405E0[v13 + 36190];
			//       while ( v14 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v13 + 36190],
			//                        v14 | (1LL << (((unsigned __int64)&v2.fields.m_composePropertyBlock >> 12) & 0x3F)),
			//                        v14) );
			//     }
			//     v2.fields.m_emptySkipPropertyBlock = 0LL;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v15 = ((unsigned __int64)&v2.fields.m_emptySkipPropertyBlock >> 12) & 0x1FFFFF;
			//       v16 = v15 >> 6;
			//       v17 = v15 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v16 + 36190]);
			//       do
			//         v18 = qword_18D6405E0[v16 + 36190];
			//       while ( v18 != _InterlockedCompareExchange64(&qword_18D6405E0[v16 + 36190], v18 | (1LL << v17), v18) );
			//     }
			//     HG::Rendering::Runtime::VolumetricRenderObject::OnDisable((VolumetricRenderObject *)v2, 0LL);
			//     if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//     {
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( currentManagerContext )
			//       {
			//         farRenderers = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)currentManagerContext.fields._volumetricCloudVolumeManager_k__BackingField;
			//         if ( farRenderers )
			//         {
			//           HG::Rendering::Runtime::VolumetricCloudVolumeManager::UnregisterCloudVolume(
			//             (VolumetricCloudVolumeManager *)farRenderers,
			//             (IVolumetricCloudVolume *)v2,
			//             0LL);
			//           return;
			//         }
			//       }
			// LABEL_37:
			//       sub_1802DC2C8(farRenderers, v7);
			//     }
			//   }
			// }
			// 
		}

		private void Update()
		{
			// // Void Update()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::Update(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4409, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4409, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricCloudSDF::UpdateOnce(this, 0, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateOnce([MetadataOffset(Offset = "0x01F91D4F")] bool force = false)
		{
			// // Void UpdateOnce(Boolean)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateOnce(VolumetricCloudSDF *this, bool force, MethodInfo *method)
			// {
			//   bool v3; // r14
			//   VolumetricCloudSDF *v4; // rdi
			//   bool IsAnyVisibleInScene; // si
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 *v8; // rdx
			//   VolumetricWindFieldManager *m_WindFieldManager; // rcx
			//   Object_1 *m_CloudMat; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // [rsp+0h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-58h] BYREF
			//   List_1_T_Enumerator_System_Object_ v16; // [rsp+28h] [rbp-50h] BYREF
			//   List_1_T_Enumerator_System_Object_ v17; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   v3 = force;
			//   v4 = this;
			//   if ( !byte_18D91977D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91977D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4377, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4377, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)v4, v3, 0LL);
			//   }
			//   else
			//   {
			//     IsAnyVisibleInScene = HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyVisibleInScene(v4, 0LL);
			//     if ( IsAnyVisibleInScene | HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyLoadingInScene(v4, 0LL) )
			//       HG::Rendering::Runtime::VolumetricCloudSDF::LoadCloudAssetAsync(v4, 0LL);
			//     else
			//       HG::Rendering::Runtime::VolumetricCloudSDF::ReleaseCloudAsset(v4, 0LL);
			//     if ( !v4.fields.m_WindFieldNodeList )
			//       sub_180B536AC(v7, v6);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v16,
			//       (List_1_System_Object_ *)v4.fields.m_WindFieldNodeList,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::GetEnumerator);
			//     v17 = v16;
			//     v16._list = 0LL;
			//     *(_QWORD *)&v16._index = &v17;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v17,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::MoveNext) )
			//       {
			//         if ( !v17._current )
			//           sub_1802DC2C8(0LL, v8);
			//         HG::Rendering::Runtime::VolumetricWindFieldNode::Update((VolumetricWindFieldNode *)v17._current, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       v8 = &v14;
			//       v16._list = (List_1_System_Object_ *)v15.ex;
			//       if ( v16._list )
			//         sub_18000F780(v16._list);
			//       v3 = force;
			//       v4 = this;
			//     }
			//     m_WindFieldManager = v4.fields.m_WindFieldManager;
			//     if ( !m_WindFieldManager
			//       || (HG::Rendering::Runtime::VolumetricWindFieldManager::Tick(m_WindFieldManager, 0LL),
			//           (m_WindFieldManager = (VolumetricWindFieldManager *)v4.fields.m_propertyBlock) == 0LL) )
			//     {
			//       sub_1802DC2C8(m_WindFieldManager, v8);
			//     }
			//     UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)m_WindFieldManager, 1, 0LL);
			//     m_CloudMat = (Object_1 *)v4.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     {
			//       HG::Rendering::Runtime::VolumetricCloudSDF::UpdateViewMode(v4, 0LL);
			//       if ( v3 || IsAnyVisibleInScene )
			//         HG::Rendering::Runtime::VolumetricCloudSDF::UpdateMat(v4, 0LL);
			//     }
			//   }
			// }
			// 
		}

		private void LateUpdate()
		{
			// // Void LateUpdate()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::LateUpdate(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4410, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4410, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricCloudSDF::ClearFrameStates(this, 0LL);
			//   }
			// }
			// 
		}

		private void ClearFrameStates()
		{
			// // Void ClearFrameStates()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::VolumetricCloudSDF::ClearFrameStates(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   VolumetricCloudSDF *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   VolumetricCloudSDF__StaticFields *static_fields; // rcx
			//   List_1_System_Int32_ *farRenderersToDelete; // rdi
			//   __int64 v12; // rdx
			//   KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
			//   VolumetricFarCloudRenderer *v14; // rcx
			//   __int64 v15; // rdx
			//   List_1_System_Int32_ *v16; // rcx
			//   VolumetricCloudSDF__StaticFields *v17; // rcx
			//   __int64 v18; // rdx
			//   int32_t v19; // edi
			//   Dictionary_2_System_Int32_System_Object_ *farRenderers; // rcx
			//   Object *Item; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rdx
			//   Dictionary_2_System_Int32_System_Object_ *v25; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v29; // [rsp+20h] [rbp-98h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v30; // [rsp+48h] [rbp-70h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v31; // [rsp+60h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v32; // [rsp+88h] [rbp-30h] BYREF
			//   Il2CppExceptionWrapper *v33; // [rsp+90h] [rbp-28h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D91977E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
			//     byte_18D91977E = 1;
			//   }
			//   memset(&v30, 0, sizeof(v30));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4395, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4395, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v28, v27);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields._visibleStates )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//       (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields._visibleStates,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Clear);
			//     if ( !v2.fields._loadingStates )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//       (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields._loadingStates,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Clear);
			//     if ( !v2.fields._fadeInStates )
			//       sub_180B536AC(v8, v7);
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//       (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields._fadeInStates,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Clear);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF.static_fields;
			//     farRenderersToDelete = static_fields.farRenderersToDelete;
			//     if ( !static_fields.farRenderersToDelete )
			//       sub_180B536AC(static_fields, v9);
			//     ++farRenderersToDelete.fields._version;
			//     farRenderersToDelete.fields._size = 0;
			//     if ( !v2.fields.farRenderers )
			//       sub_180B536AC(static_fields, v9);
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v29,
			//       (Dictionary_2_System_Object_System_Object_ *)v2.fields.farRenderers,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::GetEnumerator);
			//     v31 = v29;
			//     v29._dictionary = 0LL;
			//     *(_QWORD *)&v29._version = &v31;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v31,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::MoveNext) )
			//       {
			//         current = v31._current;
			//         v14 = (VolumetricFarCloudRenderer *)_mm_srli_si128((__m128i)v31._current, 8).m128i_u64[0];
			//         if ( !v14 )
			//           sub_1802DC2C8(0LL, v12);
			//         if ( HG::Rendering::Runtime::VolumetricFarCloudRenderer::CanBeReleased(v14, 0LL) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
			//           v16 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF.static_fields.farRenderersToDelete;
			//           if ( !v16 )
			//             sub_1802DC2C8(0LL, v15);
			//           sub_18231EF50(v16, _mm_cvtsi128_si32((__m128i)current));
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v32 )
			//     {
			//       v29._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v32.ex;
			//       if ( v29._dictionary )
			//         sub_18000F780(v29._dictionary);
			//       v2 = this;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
			//     v17 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF.static_fields;
			//     if ( !v17.farRenderersToDelete )
			//       sub_1802DC2C8(v17, 0LL);
			//     System::Collections::Generic::List<int>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Int32_ *)&v29,
			//       v17.farRenderersToDelete,
			//       MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     *(_OWORD *)&v30._list = *(_OWORD *)&v29._dictionary;
			//     *(_QWORD *)&v30._current = *(_QWORD *)&v29._current.key;
			//     v29._dictionary = 0LL;
			//     *(_QWORD *)&v29._version = &v30;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v30,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         v19 = v30._current;
			//         farRenderers = (Dictionary_2_System_Int32_System_Object_ *)v2.fields.farRenderers;
			//         if ( !farRenderers )
			//           sub_1802DC2C8(0LL, v18);
			//         Item = System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
			//                  farRenderers,
			//                  v30._current,
			//                  MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Item);
			//         if ( !Item )
			//           sub_1802DC2C8(v23, v22);
			//         HG::Rendering::Runtime::VolumetricFarCloudRenderer::Release((VolumetricFarCloudRenderer *)Item, 0LL);
			//         v25 = (Dictionary_2_System_Int32_System_Object_ *)v2.fields.farRenderers;
			//         if ( !v25 )
			//           sub_1802DC2C8(0LL, v24);
			//         System::Collections::Generic::Dictionary<int,System::Object>::Remove(
			//           v25,
			//           v19,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Remove);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v33 )
			//     {
			//       v29._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v33.ex;
			//       if ( v29._dictionary )
			//         sub_18000F780(v29._dictionary);
			//     }
			//   }
			// }
			// 
		}

		private void LoadCloudAsset()
		{
			// // Void LoadCloudAsset()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::LoadCloudAsset(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   Object_1 *m_CloudAsset; // rbx
			//   __int64 v4; // rdx
			//   VolumetricSdfAsset *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91977F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91977F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4411, 0LL) )
			//   {
			//     m_CloudAsset = (Object_1 *)this.fields.m_CloudAsset;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
			//       return;
			//     v5 = this.fields.m_CloudAsset;
			//     if ( v5 )
			//     {
			//       HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssets(v5, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4411, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void LoadCloudAssetAsync()
		{
			// // Void LoadCloudAssetAsync()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::LoadCloudAssetAsync(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   Object_1 *m_CloudAsset; // rbx
			//   __int64 v4; // rdx
			//   VolumetricSdfAsset *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919780 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919780 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4378, 0LL) )
			//   {
			//     m_CloudAsset = (Object_1 *)this.fields.m_CloudAsset;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
			//       return;
			//     v5 = this.fields.m_CloudAsset;
			//     if ( v5 )
			//     {
			//       HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssetsAsync(v5, 0LL);
			//       v5 = this.fields.m_CloudAsset;
			//       if ( v5 )
			//       {
			//         HG::Rendering::Runtime::VolumetricSdfAsset::UpdateAssetLoading(v5, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4378, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void ReleaseCloudAsset()
		{
			// // Void ReleaseCloudAsset()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::ReleaseCloudAsset(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   Object_1 *m_CloudAsset; // rbx
			//   __int64 v4; // rdx
			//   VolumetricSdfAsset *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919781 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919781 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4382, 0LL) )
			//   {
			//     m_CloudAsset = (Object_1 *)this.fields.m_CloudAsset;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
			//       return;
			//     v5 = this.fields.m_CloudAsset;
			//     if ( v5 )
			//     {
			//       HG::Rendering::Runtime::VolumetricSdfAsset::UnloadAssets(v5, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4382, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private VolumetricFarCloudRenderer GetFarCloudRenderer(HGCamera hgCamera)
		{
			// // VolumetricFarCloudRenderer GetFarCloudRenderer(HGCamera)
			// VolumetricFarCloudRenderer *HG::Rendering::Runtime::VolumetricCloudSDF::GetFarCloudRenderer(
			//         VolumetricCloudSDF *this,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Object_1 *camera; // rcx
			//   int32_t InstanceID; // eax
			//   int32_t v8; // esi
			//   VolumetricFarCloudRenderer *v9; // rax
			//   Object *v10; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *value; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919782 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricFarCloudRenderer);
			//     byte_18D919782 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4414, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = (Object_1 *)hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         InstanceID = UnityEngine::Object::GetInstanceID(camera, 0LL);
			//         camera = (Object_1 *)this.fields.farRenderers;
			//         v8 = InstanceID;
			//         value = 0LL;
			//         if ( camera )
			//         {
			//           if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
			//                   (Dictionary_2_System_Int32_System_Object_ *)camera,
			//                   InstanceID,
			//                   &value,
			//                   MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::TryGetValue) )
			//           {
			//             v9 = (VolumetricFarCloudRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricFarCloudRenderer);
			//             v10 = (Object *)v9;
			//             if ( !v9 )
			//               goto LABEL_14;
			//             HG::Rendering::Runtime::VolumetricFarCloudRenderer::VolumetricFarCloudRenderer(v9, 0LL);
			//             value = v10;
			//             HG::Rendering::Runtime::VolumetricFarCloudRenderer::Initialize((VolumetricFarCloudRenderer *)v10, 0LL);
			//             camera = (Object_1 *)this.fields.farRenderers;
			//             if ( !camera )
			//               goto LABEL_14;
			//             System::Collections::Generic::Dictionary<int,System::Object>::Add(
			//               (Dictionary_2_System_Int32_System_Object_ *)camera,
			//               v8,
			//               value,
			//               MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Add);
			//           }
			//           camera = (Object_1 *)value;
			//           if ( value )
			//           {
			//             HG::Rendering::Runtime::VolumetricFarCloudRenderer::MarkUsed((VolumetricFarCloudRenderer *)value, 0LL);
			//             return (VolumetricFarCloudRenderer *)value;
			//           }
			//         }
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(camera, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4414, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1264(Patch, (Object *)this, (Object *)hgCamera, 0LL);
			// }
			// 
			return null;
		}

		protected override void PrepareVolumetricRenderingImpl(ref VolumetricRenderInputs inputs)
		{
			// // Void PrepareVolumetricRenderingImpl(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::PrepareVolumetricRenderingImpl(
			//         VolumetricCloudSDF *this,
			//         VolumetricRenderInputs *inputs,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_CloudMat; // rbx
			//   __int64 v6; // rcx
			//   HGRenderGraphContext *context; // rdx
			//   VolumetricFarCloudRenderer *FarCloudRenderer; // rbp
			//   Object_1 *v9; // rbx
			//   HGRenderGraphContext *v10; // r8
			//   HGRenderGraphContext *v11; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919783 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919783 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4417, 0LL) )
			//   {
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     {
			//       context = inputs.context;
			//       if ( !context )
			//         goto LABEL_14;
			//       HG::Rendering::Runtime::VolumetricCloudSDF::BakeMSTex(this, context.fields.cmd, this.fields.m_CloudMat, 0, 0LL);
			//     }
			//     FarCloudRenderer = HG::Rendering::Runtime::VolumetricCloudSDF::GetFarCloudRenderer(this, inputs.hgCamera, 0LL);
			//     v9 = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(v9, 0LL) )
			//     {
			//       v10 = inputs.context;
			//       if ( !v10 )
			//         goto LABEL_14;
			//       HG::Rendering::Runtime::VolumetricCloudSDF::UpdateEmptySkipRT(
			//         this,
			//         inputs.hgCamera,
			//         v10.fields.cmd,
			//         inputs.volumetricParameters,
			//         0LL);
			//       v11 = inputs.context;
			//       if ( !v11 )
			//         goto LABEL_14;
			//       HG::Rendering::Runtime::VolumetricCloudSDF::BakeFarCloud(
			//         this,
			//         FarCloudRenderer,
			//         inputs.hgCamera,
			//         v11.fields.cmd,
			//         inputs.volumetricParameters,
			//         0LL);
			//     }
			//     if ( FarCloudRenderer )
			//     {
			//       HG::Rendering::Runtime::VolumetricFarCloudRenderer::PostRender(FarCloudRenderer, 0LL);
			//       return;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v6, context);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4417, 0LL);
			//   if ( !Patch )
			//     goto LABEL_14;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1276(Patch, (Object *)this, inputs, 0LL);
			// }
			// 
		}

		private void UpdateViewMode()
		{
			// // Void UpdateViewMode()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateViewMode(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_UnityEngine_MeshRenderer_ *renderers; // rbx
			//   __int64 v6; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Il2CppExceptionWrapper *v10; // [rsp+20h] [rbp-48h] BYREF
			//   _QWORD v11[3]; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v12; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919784 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MeshRenderer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MeshRenderer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MeshRenderer>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::GetEnumerator);
			//     byte_18D919784 = 1;
			//   }
			//   memset(&v12, 0, sizeof(v12));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4388, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4388, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Component::GetComponentsInChildren<System::Object>(
			//       (Component *)this,
			//       (List_1_System_Object_ *)this.fields._renderers,
			//       MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshRenderer>);
			//     renderers = this.fields._renderers;
			//     if ( !renderers )
			//       sub_180B536AC(v4, v3);
			//     v12 = *(List_1_T_Enumerator_System_Object_ *)sub_18041DB38(v11, renderers);
			//     v11[0] = 0LL;
			//     v11[1] = &v12;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v12,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MeshRenderer>::MoveNext) )
			//       {
			//         if ( !v12._current )
			//           sub_1802DC2C8(0LL, v6);
			//         UnityEngine::Renderer::set_enabled((Renderer *)v12._current, 0, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v10 )
			//     {
			//       v11[0] = v10.ex;
			//       if ( v11[0] )
			//         sub_18000F780(v11[0]);
			//     }
			//   }
			// }
			// 
		}

		private void UpdateEmptySkipRT(HGCamera hgCamera, CommandBuffer cmd, HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Void UpdateEmptySkipRT(HGCamera, CommandBuffer, HGVolumetricCloudSettingParameters)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateEmptySkipRT(
			//         VolumetricCloudSDF *this,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   double v5; // xmm1_8
			//   void *static_fields; // rdx
			//   void *m_emptySkipPropertyBlock; // rcx
			//   Component *camera; // r14
			//   Object_1 *m_CloudMat; // rbx
			//   Material *v14; // rbx
			//   int32_t m_X; // r13d
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   Material *v17; // rsi
			//   unsigned __int64 v18; // rbx
			//   float FloatImpl; // xmm7_4
			//   float v20; // xmm6_4
			//   __m128 v21; // xmm9
			//   float v22; // xmm8_4
			//   System::Math *v23; // rcx
			//   double v24; // xmm1_8
			//   System::Math *v25; // rcx
			//   Material *v26; // rsi
			//   String *v27; // rdx
			//   bool IsKeywordEnabled; // al
			//   RenderTexture *TemporaryTexture; // rax
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   MaterialPropertyBlock *v32; // r15
			//   __int64 v33; // xmm6_8
			//   float z; // esi
			//   MethodInfo *v35; // r8
			//   Vector4 *v36; // rax
			//   int32_t v37; // r10d
			//   MaterialPropertyBlock *v38; // r15
			//   __int128 v39; // xmm1
			//   VolumetricShaderIDs__StaticFields *v40; // rcx
			//   float v41; // eax
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   Vector4 *v44; // rax
			//   __m128 v45; // xmm0
			//   float fieldOfView; // xmm6_4
			//   __m128 v47; // xmm7
			//   __int64 v48; // rax
			//   MaterialPropertyBlock *v49; // rsi
			//   __m128 v50; // xmm0
			//   VolumetricShaderIDs__StaticFields *v51; // rcx
			//   int32_t MainCameraFovTan; // r14d
			//   __int64 v53; // rdx
			//   __int64 v54; // r8
			//   __int64 v55; // r9
			//   __m128 v56; // xmm7
			//   __m128 y_low; // xmm0
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   __int64 v60; // r8
			//   __int64 v61; // r9
			//   Vector4 *v62; // rax
			//   MaterialPropertyBlock *v63; // rsi
			//   int v64; // eax
			//   int v65; // r15d
			//   int v66; // eax
			//   int v67; // r14d
			//   int v68; // eax
			//   __m128 v69; // xmm2
			//   Vector4 *v70; // rax
			//   MaterialPropertyBlock *v71; // r10
			//   int32_t v72; // r11d
			//   __m128 v73; // xmm1
			//   __m128 v74; // xmm2
			//   Vector4 *v75; // rax
			//   MaterialPropertyBlock *v76; // r10
			//   int32_t v77; // r11d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v79; // [rsp+38h] [rbp-D0h] BYREF
			//   RenderTexture *colorRT; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v81; // [rsp+58h] [rbp-B0h] BYREF
			//   int32_t v82; // [rsp+68h] [rbp-A0h]
			//   int v83; // [rsp+6Ch] [rbp-9Ch]
			//   __int64 v84; // [rsp+70h] [rbp-98h] BYREF
			//   RenderTextureDescriptor v85; // [rsp+80h] [rbp-88h] BYREF
			//   Matrix4x4 v86[2]; // [rsp+B8h] [rbp-50h] BYREF
			// 
			//   if ( !byte_18D919785 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D919785 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4424, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4424, 0LL);
			//     if ( !Patch )
			//       goto LABEL_28;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)cmd,
			//       (Object *)volumetricParameters,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       goto LABEL_28;
			//     camera = (Component *)hgCamera.fields.camera;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)camera, 0LL) )
			//     {
			//       m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//       {
			//         v14 = this.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//         if ( v14 )
			//         {
			//           if ( !UnityEngine::Material::IsKeywordEnabled(v14, *((String **)static_fields + 1), 0LL) )
			//             return;
			//           m_X = hgCamera.fields._sceneRTSize_k__BackingField.m_X;
			//           sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//           v17 = this.fields.m_CloudMat;
			//           v18 = HIDWORD(*(unsigned __int64 *)&sceneRTSize_k__BackingField);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           if ( v17 )
			//           {
			//             FloatImpl = UnityEngine::Material::GetFloatImpl(v17, *((_DWORD *)static_fields + 123), 0LL);
			//             if ( volumetricParameters )
			//             {
			//               v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                       volumetricParameters.fields.emptySkipSizeScale,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//               v21 = (__m128)0x3F800000u;
			//               v22 = (float)(1.0
			//                           / HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                               volumetricParameters.fields.downResRatio,
			//                               MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit))
			//                   * (float)(v20 * FloatImpl);
			//               sub_180002C70(TypeInfo::System::Math);
			//               System::Math::Ceiling(v23, v5);
			//               *(_QWORD *)&v24 = COERCE_UNSIGNED_INT((float)(int)v18);
			//               v83 = (int)(float)((float)m_X * v22);
			//               *(float *)&v24 = *(float *)&v24 * v22;
			//               System::Math::Ceiling(v25, v24);
			//               v26 = this.fields.m_CloudMat;
			//               v82 = (int)*(float *)&v24;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//               m_emptySkipPropertyBlock = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//               if ( v26 )
			//               {
			//                 v27 = (String *)*((_QWORD *)m_emptySkipPropertyBlock + 2);
			//                 memset(&v85._dimension_k__BackingField, 0, 20);
			//                 v85._dimension_k__BackingField = 2;
			//                 memset(&v85, 0, 32);
			//                 IsKeywordEnabled = UnityEngine::Material::IsKeywordEnabled(v26, v27, 0LL);
			//                 UnityEngine::RenderTextureDescriptor::set_colorFormat(
			//                   &v85,
			//                   (RenderTextureFormat__Enum)(IsKeywordEnabled
			//                                             ? RenderTextureFormat__Enum_ARGBHalf
			//                                             : RenderTextureFormat__Enum_RGHalf),
			//                   0LL);
			//                 v85._height_k__BackingField = v82;
			//                 v85._width_k__BackingField = (int)(float)((float)m_X * v22);
			//                 v85._volumeDepth_k__BackingField = 1;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                 LODWORD(v86[0].m03) = v85._memoryless_k__BackingField;
			//                 *(_OWORD *)&v86[0].m00 = *(_OWORD *)&v85._width_k__BackingField;
			//                 *(_OWORD *)&v86[0].m01 = *(_OWORD *)&v85._mipCount_k__BackingField;
			//                 *(_OWORD *)&v86[0].m02 = *(_OWORD *)&v85._dimension_k__BackingField;
			//                 TemporaryTexture = HG::Rendering::Runtime::VolumetricSDFUtils::GetTemporaryTexture(
			//                                      (RenderTextureDescriptor *)v86,
			//                                      0LL);
			//                 m_emptySkipPropertyBlock = this.fields.m_emptySkipPropertyBlock;
			//                 colorRT = TemporaryTexture;
			//                 if ( m_emptySkipPropertyBlock )
			//                 {
			//                   UnityEngine::MaterialPropertyBlock::CopyFrom(
			//                     (MaterialPropertyBlock *)m_emptySkipPropertyBlock,
			//                     this.fields.m_propertyBlock,
			//                     0LL);
			//                   if ( camera )
			//                   {
			//                     transform = UnityEngine::Component::get_transform(camera, 0LL);
			//                     if ( transform )
			//                     {
			//                       position = UnityEngine::Transform::get_position(&v81, transform, 0LL);
			//                       v32 = this.fields.m_emptySkipPropertyBlock;
			//                       z = position.z;
			//                       v84 = *(_QWORD *)&position.x;
			//                       v33 = v84;
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                       *(_QWORD *)&v81.x = v33;
			//                       v81.z = z;
			//                       v36 = UnityEngine::Vector4::op_Implicit(&v79, &v81, v35);
			//                       if ( v32 )
			//                       {
			//                         v79 = *v36;
			//                         UnityEngine::MaterialPropertyBlock::SetVector(v32, v37, &v79, 0LL);
			//                         v38 = this.fields.m_emptySkipPropertyBlock;
			//                         *(_QWORD *)&v79.x = v84;
			//                         v39 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m00;
			//                         v40 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                         v79.z = z;
			//                         v79.w = 1.0;
			//                         v41 = *(float *)&v40._MainCameraPosLocal;
			//                         *(_OWORD *)&v86[0].m00 = v39;
			//                         v42 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m02;
			//                         v81.x = v41;
			//                         v43 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m01;
			//                         *(_OWORD *)&v86[0].m02 = v42;
			//                         *(_OWORD *)&v86[0].m01 = v43;
			//                         *(_OWORD *)&v86[0].m03 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m03;
			//                         v44 = UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v84, v86, &v79, 0LL);
			//                         if ( v38 )
			//                         {
			//                           v79 = *v44;
			//                           v45 = (__m128)v79;
			//                           UnityEngine::MaterialPropertyBlock::SetVector(v38, SLODWORD(v81.x), &v79, 0LL);
			//                           fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)camera, 0LL);
			//                           v45.m128_f32[0] = UnityEngine::Camera::get_aspect((Camera *)camera, 0LL);
			//                           v47 = v45;
			//                           v47.m128_f32[0] = v45.m128_f32[0] * fieldOfView;
			//                           v45.m128_f32[0] = UnityEngine::Camera::get_fieldOfView((Camera *)camera, 0LL);
			//                           v48 = sub_182C9F010(_mm_unpacklo_ps(v47, v45).m128_u64[0]);
			//                           v49 = this.fields.m_emptySkipPropertyBlock;
			//                           *(_QWORD *)&v81.x = v48;
			//                           v50 = (__m128)(unsigned int)v48;
			//                           v51 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                           MainCameraFovTan = v51._MainCameraFovTan;
			//                           v50.m128_f32[0] = sub_1802ED290(v51, v53, v54, v55);
			//                           v56 = v50;
			//                           y_low = (__m128)LODWORD(v81.y);
			//                           y_low.m128_f32[0] = sub_1802ED290(v59, v58, v60, v61);
			//                           v62 = (Vector4 *)sub_1825A3980(&v79, _mm_unpacklo_ps(v56, y_low).m128_u64[0]);
			//                           if ( v49 )
			//                           {
			//                             v79 = *v62;
			//                             UnityEngine::MaterialPropertyBlock::SetVector(v49, MainCameraFovTan, &v79, 0LL);
			//                             static_fields = colorRT;
			//                             v63 = this.fields.m_emptySkipPropertyBlock;
			//                             m_emptySkipPropertyBlock = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                             v81.x = *((float *)m_emptySkipPropertyBlock + 128);
			//                             if ( colorRT )
			//                             {
			//                               v64 = sub_18003ED00(5LL);
			//                               static_fields = colorRT;
			//                               v65 = v64;
			//                               if ( colorRT )
			//                               {
			//                                 v66 = sub_18003ED00(7LL);
			//                                 static_fields = colorRT;
			//                                 v67 = v66;
			//                                 if ( colorRT )
			//                                 {
			//                                   v68 = sub_18003ED00(5LL);
			//                                   static_fields = colorRT;
			//                                   if ( colorRT )
			//                                   {
			//                                     v79.x = (float)v65;
			//                                     v79.y = (float)v67;
			//                                     v79.z = 1.0 / (float)v68;
			//                                     v79.w = 1.0 / (float)(int)sub_18003ED00(7LL);
			//                                     if ( v63 )
			//                                     {
			//                                       UnityEngine::MaterialPropertyBlock::SetVector(v63, SLODWORD(v81.x), &v79, 0LL);
			//                                       v69 = (__m128)0x3F800000u;
			//                                       v69.m128_f32[0] = 1.0 / (float)((float)m_X * v22);
			//                                       v21.m128_f32[0] = 1.0 / (float)((float)(int)v18 * v22);
			//                                       v70 = (Vector4 *)sub_1825A3980(&v79, _mm_unpacklo_ps(v69, v21).m128_u64[0]);
			//                                       if ( v71 )
			//                                       {
			//                                         v79 = *v70;
			//                                         UnityEngine::MaterialPropertyBlock::SetVector(v71, v72, &v79, 0LL);
			//                                         v73 = (__m128)COERCE_UNSIGNED_INT((float)v83);
			//                                         v74 = (__m128)COERCE_UNSIGNED_INT((float)v82);
			//                                         v73.m128_f32[0] = v73.m128_f32[0] / (float)((float)m_X * v22);
			//                                         v74.m128_f32[0] = v74.m128_f32[0] / (float)((float)(int)v18 * v22);
			//                                         v75 = (Vector4 *)sub_1825A3980(&v79, _mm_unpacklo_ps(v73, v74).m128_u64[0]);
			//                                         if ( v76 )
			//                                         {
			//                                           v79 = *v75;
			//                                           UnityEngine::MaterialPropertyBlock::SetVector(v76, v77, &v79, 0LL);
			//                                           HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(cmd, colorRT, 0LL);
			//                                           HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
			//                                             cmd,
			//                                             this.fields.m_CloudMat,
			//                                             this.fields.m_emptySkipPropertyBlock,
			//                                             9,
			//                                             0,
			//                                             0LL);
			//                                           m_emptySkipPropertyBlock = this.fields.m_propertyBlock;
			//                                           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                           if ( m_emptySkipPropertyBlock )
			//                                           {
			//                                             UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                                               (MaterialPropertyBlock *)m_emptySkipPropertyBlock,
			//                                               *((_DWORD *)static_fields + 129),
			//                                               (Texture *)colorRT,
			//                                               0LL);
			//                                             HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseTemporaryTexture(
			//                                               &colorRT,
			//                                               0LL);
			//                                             return;
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			// LABEL_28:
			//         sub_180B536AC(m_emptySkipPropertyBlock, static_fields);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void UpdateCloudParameters()
		{
			// // Void UpdateCloudParameters()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateCloudParameters(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   Object_1 *m_CloudMat; // rbx
			//   void *v4; // rdx
			//   void *m_CloudObject; // rcx
			//   Transform *transform; // rax
			//   Vector3 *localScale; // rax
			//   __int64 v8; // xmm6_8
			//   float z; // esi
			//   MethodInfo *v10; // rdx
			//   Vector3 *one; // rax
			//   float v12; // ecx
			//   float m_MaxExtent; // xmm1_4
			//   MethodInfo *v14; // r9
			//   Vector3 *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Transform *v18; // r9
			//   __int64 v19; // xmm0_8
			//   float v20; // eax
			//   VolumetricEncodedTexture *DensityTextureToUse; // rbx
			//   Texture *Texture; // rax
			//   Vector3 *TextureResolution; // rax
			//   __int64 v24; // xmm0_8
			//   Vector3 *v25; // rax
			//   __m128 z_low; // xmm1
			//   float y; // xmm2_4
			//   unsigned __int64 v28; // xmm0_8
			//   __m128 v29; // xmm1
			//   __m128 v30; // xmm0
			//   float v31; // xmm2_4
			//   Transform *v32; // rax
			//   Matrix4x4 *worldToLocalMatrix; // rax
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm2
			//   __int128 v36; // xmm3
			//   Transform *v37; // rax
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int64 v39; // rdx
			//   void *static_fields; // rcx
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm2
			//   __int128 v43; // xmm3
			//   Transform *v44; // rax
			//   float deltaTime; // xmm9_4
			//   Material *v46; // rbx
			//   MethodInfo *v47; // r8
			//   Vector3 *v48; // rax
			//   __int64 v49; // xmm12_8
			//   float v50; // r14d
			//   MethodInfo *v51; // r8
			//   Vector3 *v52; // rax
			//   __int64 v53; // xmm11_8
			//   float v54; // esi
			//   MethodInfo *v55; // r8
			//   Vector3 *v56; // rax
			//   __int64 v57; // xmm10_8
			//   float v58; // ebx
			//   float FloatImpl; // xmm0_4
			//   float v60; // xmm6_4
			//   MethodInfo *v61; // r9
			//   Vector3 *v62; // rax
			//   __int64 v63; // xmm3_8
			//   MethodInfo *v64; // r9
			//   Vector3 *v65; // rax
			//   __int64 v66; // xmm3_8
			//   MethodInfo *v67; // r9
			//   Vector3 *v68; // rax
			//   __int64 v69; // xmm0_8
			//   __int64 v70; // xmm3_8
			//   MethodInfo *v71; // r9
			//   Vector3 *v72; // rax
			//   Beyond::JobMathf *v73; // rcx
			//   Beyond::JobMathf *v74; // rcx
			//   Beyond::JobMathf *v75; // rcx
			//   MethodInfo *v76; // r9
			//   Vector3 *v77; // rax
			//   __int64 v78; // xmm3_8
			//   MethodInfo *v79; // r9
			//   Vector3 *v80; // rax
			//   __int64 v81; // xmm3_8
			//   MethodInfo *v82; // r9
			//   Vector3 *v83; // rax
			//   __int64 v84; // xmm3_8
			//   MethodInfo *v85; // r9
			//   Vector3 *v86; // rax
			//   Beyond::JobMathf *v87; // rcx
			//   Beyond::JobMathf *v88; // rcx
			//   Beyond::JobMathf *v89; // rcx
			//   MethodInfo *v90; // r9
			//   Vector3 *v91; // rax
			//   __int64 v92; // xmm3_8
			//   MethodInfo *v93; // r9
			//   Vector3 *v94; // rax
			//   __int64 v95; // xmm3_8
			//   MethodInfo *v96; // r9
			//   Vector3 *v97; // rax
			//   __int64 v98; // xmm3_8
			//   MethodInfo *v99; // r9
			//   Vector3 *v100; // rax
			//   Beyond::JobMathf *v101; // rcx
			//   Beyond::JobMathf *v102; // rcx
			//   Beyond::JobMathf *v103; // rcx
			//   float v104; // xmm2_4
			//   MethodInfo *v105; // r9
			//   Vector3 *v106; // rax
			//   __int64 v107; // xmm3_8
			//   MethodInfo *v108; // r9
			//   Vector3 *v109; // rax
			//   __int64 v110; // xmm3_8
			//   MethodInfo *v111; // r9
			//   Vector3 *v112; // rax
			//   float v113; // xmm2_4
			//   float v114; // ecx
			//   MethodInfo *v115; // r9
			//   Vector3 *v116; // rax
			//   __int64 v117; // xmm3_8
			//   MethodInfo *v118; // r9
			//   Vector3 *v119; // rax
			//   __int64 v120; // xmm3_8
			//   MethodInfo *v121; // r9
			//   Vector3 *v122; // rax
			//   float v123; // xmm2_4
			//   float v124; // ecx
			//   MethodInfo *v125; // r9
			//   Vector3 *v126; // rax
			//   __int64 v127; // xmm3_8
			//   MethodInfo *v128; // r9
			//   Vector3 *v129; // rax
			//   __int64 v130; // xmm3_8
			//   MethodInfo *v131; // r9
			//   Vector3 *v132; // rax
			//   float v133; // xmm9_4
			//   float v134; // ecx
			//   float v135; // xmm6_4
			//   float v136; // xmm7_4
			//   int v137; // xmm1_4
			//   float v138; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v140; // [rsp+28h] [rbp-99h] BYREF
			//   Vector3 v141; // [rsp+38h] [rbp-89h] BYREF
			//   Vector4 v142; // [rsp+48h] [rbp-79h] BYREF
			//   Matrix4x4 v143[2]; // [rsp+58h] [rbp-69h] BYREF
			//   int v144; // [rsp+138h] [rbp+77h] BYREF
			// 
			//   if ( !byte_18D919786 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D919786 = 1;
			//   }
			//   v144 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4390, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4390, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_29:
			//     sub_180B536AC(m_CloudObject, v4);
			//   }
			//   m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     return;
			//   m_CloudObject = this.fields.m_CloudObject;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   transform = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
			//   if ( !transform )
			//     goto LABEL_29;
			//   localScale = UnityEngine::Transform::get_localScale(&v141, transform, 0LL);
			//   v8 = *(_QWORD *)&localScale.x;
			//   z = localScale.z;
			//   *(_QWORD *)&v140.x = *(_QWORD *)&localScale.x;
			//   m_CloudObject = this.fields.m_CloudObject;
			//   this.fields.m_MaxExtent = fmaxf(v140.x, fmaxf(v140.y, z));
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
			//   one = UnityEngine::Vector3::get_one(&v141, v10);
			//   v12 = one.z;
			//   *(_QWORD *)&v140.x = *(_QWORD *)&one.x;
			//   m_MaxExtent = this.fields.m_MaxExtent;
			//   v140.z = v12;
			//   v15 = UnityEngine::Vector3::op_Multiply(&v141, m_MaxExtent, &v140, v14);
			//   if ( !v18 )
			//     sub_180B536AC(v17, v16);
			//   v19 = *(_QWORD *)&v15.x;
			//   v20 = v15.z;
			//   *(_QWORD *)&v140.x = v19;
			//   v140.z = v20;
			//   UnityEngine::Transform::set_localScale(v18, &v140, 0LL);
			//   DensityTextureToUse = this.fields.DensityTextureToUse;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//   Texture = HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(DensityTextureToUse, 0LL);
			//   TextureResolution = HG::Rendering::Runtime::VolumetricSDFUtils::GetTextureResolution(&v141, Texture, 0LL);
			//   v24 = *(_QWORD *)&TextureResolution.x;
			//   *(float *)&TextureResolution = TextureResolution.z;
			//   *(_QWORD *)&v140.x = v24;
			//   LODWORD(v140.z) = (_DWORD)TextureResolution;
			//   v25 = HG::Rendering::Runtime::VolumetricSDFUtils::VoxelSize(&v141, &v140, (float *)&v144, 0LL);
			//   m_CloudObject = this.fields.m_CloudObject;
			//   z_low = (__m128)LODWORD(v25.z);
			//   *(_QWORD *)&v140.x = *(_QWORD *)&v25.x;
			//   y = v140.y;
			//   v28 = _mm_unpacklo_ps((__m128)LODWORD(v140.x), z_low).m128_u64[0];
			//   v29 = (__m128)0x3F800000u;
			//   *(_QWORD *)&this.fields.m_VoxelSize.x = v28;
			//   v30 = (__m128)0x3F800000u;
			//   this.fields.m_VoxelSize.z = y;
			//   v30.m128_f32[0] = 1.0 / this.fields.m_VoxelSize.x;
			//   v29.m128_f32[0] = 1.0 / this.fields.m_VoxelSize.y;
			//   v31 = 1.0 / this.fields.m_VoxelSize.z;
			//   *(_QWORD *)&this.fields.m_InvScale.x = _mm_unpacklo_ps(v30, v29).m128_u64[0];
			//   this.fields.m_InvScale.z = v31;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   v32 = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
			//   if ( !v32 )
			//     goto LABEL_29;
			//   worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(v143, v32, 0LL);
			//   m_CloudObject = this.fields.m_CloudObject;
			//   v34 = *(_OWORD *)&worldToLocalMatrix.m01;
			//   v35 = *(_OWORD *)&worldToLocalMatrix.m02;
			//   v36 = *(_OWORD *)&worldToLocalMatrix.m03;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m00 = *(_OWORD *)&worldToLocalMatrix.m00;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m01 = v34;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m02 = v35;
			//   *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m03 = v36;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   v37 = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
			//   if ( !v37 )
			//     goto LABEL_29;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(v143, v37, 0LL);
			//   static_fields = this.fields.m_CloudObject;
			//   v41 = *(_OWORD *)&localToWorldMatrix.m01;
			//   v42 = *(_OWORD *)&localToWorldMatrix.m02;
			//   v43 = *(_OWORD *)&localToWorldMatrix.m03;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m00 = *(_OWORD *)&localToWorldMatrix.m00;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m01 = v41;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m02 = v42;
			//   *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m03 = v43;
			//   if ( !static_fields )
			//     goto LABEL_27;
			//   v44 = UnityEngine::GameObject::get_transform((GameObject *)static_fields, 0LL);
			//   if ( !v44
			//     || (*(_QWORD *)&v140.x = v8,
			//         v140.z = z,
			//         UnityEngine::Transform::set_localScale(v44, &v140, 0LL),
			//         deltaTime = UnityEngine::Time::get_deltaTime(0LL),
			//         v46 = this.fields.m_CloudMat,
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs),
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields,
			//         !v46) )
			//   {
			// LABEL_27:
			//     sub_180B536AC(static_fields, v39);
			//   }
			//   v142 = *UnityEngine::Material::GetVector(&v142, v46, *((_DWORD *)static_fields + 137), 0LL);
			//   v48 = UnityEngine::Vector4::op_Implicit(&v141, &v142, v47);
			//   v4 = this.fields.m_CloudMat;
			//   v49 = *(_QWORD *)&v48.x;
			//   v50 = v48.z;
			//   m_CloudObject = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !v4 )
			//     goto LABEL_29;
			//   v142 = *UnityEngine::Material::GetVector(&v142, (Material *)v4, *((_DWORD *)m_CloudObject + 138), 0LL);
			//   v52 = UnityEngine::Vector4::op_Implicit(&v141, &v142, v51);
			//   v4 = this.fields.m_CloudMat;
			//   v53 = *(_QWORD *)&v52.x;
			//   v54 = v52.z;
			//   m_CloudObject = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !v4 )
			//     goto LABEL_29;
			//   v142 = *UnityEngine::Material::GetVector(&v142, (Material *)v4, *((_DWORD *)m_CloudObject + 139), 0LL);
			//   v56 = UnityEngine::Vector4::op_Implicit(&v141, &v142, v55);
			//   m_CloudObject = this.fields.m_CloudMat;
			//   v57 = *(_QWORD *)&v56.x;
			//   v58 = v56.z;
			//   v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   FloatImpl = UnityEngine::Material::GetFloatImpl((Material *)m_CloudObject, *((_DWORD *)v4 + 25), 0LL);
			//   *(_QWORD *)&v140.x = v49;
			//   v140.z = v50;
			//   v60 = FloatImpl;
			//   v62 = UnityEngine::Vector3::op_Multiply(&v141, &v140, FloatImpl, v61);
			//   v63 = *(_QWORD *)&v62.x;
			//   *(float *)&v62 = v62.z;
			//   *(_QWORD *)&v140.x = v63;
			//   LODWORD(v140.z) = (_DWORD)v62;
			//   v65 = UnityEngine::Vector3::op_Multiply(&v141, &v140, deltaTime, v64);
			//   v66 = *(_QWORD *)&v65.x;
			//   *(float *)&v65 = v65.z;
			//   *(_QWORD *)&v140.x = v66;
			//   LODWORD(v140.z) = (_DWORD)v65;
			//   v68 = UnityEngine::Vector3::op_Multiply(&v141, &v140, 0.050000001, v67);
			//   v69 = *(_QWORD *)&this.fields.m_WindPhase.x;
			//   v70 = *(_QWORD *)&v68.x;
			//   v140.z = v68.z;
			//   v141.z = this.fields.m_WindPhase.z;
			//   *(_QWORD *)&v140.x = v70;
			//   *(_QWORD *)&v141.x = v69;
			//   v72 = UnityEngine::Vector3::op_Addition((Vector3 *)&v142, &v141, &v140, v71);
			//   v73 = (Beyond::JobMathf *)LODWORD(v72.z);
			//   *(_QWORD *)&this.fields.m_WindPhase.x = *(_QWORD *)&v72.x;
			//   LODWORD(this.fields.m_WindPhase.z) = (_DWORD)v73;
			//   *(float *)&v69 = this.fields.m_WindPhase.x;
			//   Beyond::JobMathf::Fmod(v73, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase.x) = v69;
			//   *(float *)&v69 = this.fields.m_WindPhase.y;
			//   Beyond::JobMathf::Fmod(v74, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase.y) = v69;
			//   *(float *)&v69 = this.fields.m_WindPhase.z;
			//   Beyond::JobMathf::Fmod(v75, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase.z) = v69;
			//   *(_QWORD *)&v141.x = v53;
			//   v141.z = v54;
			//   v77 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, v60, v76);
			//   v78 = *(_QWORD *)&v77.x;
			//   *(float *)&v77 = v77.z;
			//   *(_QWORD *)&v141.x = v78;
			//   LODWORD(v141.z) = (_DWORD)v77;
			//   v80 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, deltaTime, v79);
			//   v81 = *(_QWORD *)&v80.x;
			//   *(float *)&v80 = v80.z;
			//   *(_QWORD *)&v141.x = v81;
			//   LODWORD(v141.z) = (_DWORD)v80;
			//   v83 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, 0.050000001, v82);
			//   v84 = *(_QWORD *)&v83.x;
			//   *(float *)&v83 = v83.z;
			//   *(_QWORD *)&v141.x = v84;
			//   LODWORD(v141.z) = (_DWORD)v83;
			//   *(float *)&v83 = this.fields.m_WindPhase2.z;
			//   *(_QWORD *)&v140.x = *(_QWORD *)&this.fields.m_WindPhase2.x;
			//   LODWORD(v140.z) = (_DWORD)v83;
			//   v86 = UnityEngine::Vector3::op_Addition((Vector3 *)&v142, &v140, &v141, v85);
			//   v87 = (Beyond::JobMathf *)LODWORD(v86.z);
			//   *(_QWORD *)&this.fields.m_WindPhase2.x = *(_QWORD *)&v86.x;
			//   LODWORD(this.fields.m_WindPhase2.z) = (_DWORD)v87;
			//   *(float *)&v69 = this.fields.m_WindPhase2.x;
			//   Beyond::JobMathf::Fmod(v87, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase2.x) = v69;
			//   *(float *)&v69 = this.fields.m_WindPhase2.y;
			//   Beyond::JobMathf::Fmod(v88, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase2.y) = v69;
			//   *(float *)&v69 = this.fields.m_WindPhase2.z;
			//   Beyond::JobMathf::Fmod(v89, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase2.z) = v69;
			//   *(_QWORD *)&v141.x = v57;
			//   v141.z = v58;
			//   v91 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, v60, v90);
			//   v92 = *(_QWORD *)&v91.x;
			//   *(float *)&v91 = v91.z;
			//   *(_QWORD *)&v141.x = v92;
			//   LODWORD(v141.z) = (_DWORD)v91;
			//   v94 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, deltaTime, v93);
			//   v95 = *(_QWORD *)&v94.x;
			//   *(float *)&v94 = v94.z;
			//   *(_QWORD *)&v141.x = v95;
			//   LODWORD(v141.z) = (_DWORD)v94;
			//   v97 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, 0.050000001, v96);
			//   *(_QWORD *)&v140.x = *(_QWORD *)&this.fields.m_WindPhase3.x;
			//   v98 = *(_QWORD *)&v97.x;
			//   v141.z = v97.z;
			//   v140.z = this.fields.m_WindPhase3.z;
			//   *(_QWORD *)&v141.x = v98;
			//   v100 = UnityEngine::Vector3::op_Addition((Vector3 *)&v142, &v140, &v141, v99);
			//   v101 = (Beyond::JobMathf *)LODWORD(v100.z);
			//   *(_QWORD *)&this.fields.m_WindPhase3.x = *(_QWORD *)&v100.x;
			//   LODWORD(this.fields.m_WindPhase3.z) = (_DWORD)v101;
			//   *(float *)&v69 = this.fields.m_WindPhase3.x;
			//   Beyond::JobMathf::Fmod(v101, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase3.x) = v69;
			//   *(float *)&v69 = this.fields.m_WindPhase3.y;
			//   Beyond::JobMathf::Fmod(v102, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase3.y) = v69;
			//   *(float *)&v69 = this.fields.m_WindPhase3.z;
			//   Beyond::JobMathf::Fmod(v103, 1.0, 0.050000001);
			//   LODWORD(this.fields.m_WindPhase3.z) = v69;
			//   v104 = this.fields.m_MaxExtent;
			//   *(_QWORD *)&v141.x = v49;
			//   v141.z = v50;
			//   v106 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, v104, v105);
			//   v107 = *(_QWORD *)&v106.x;
			//   v141.z = v106.z;
			//   *(_QWORD *)&v141.x = v107;
			//   v109 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, deltaTime, v108);
			//   v110 = *(_QWORD *)&v109.x;
			//   *(float *)&v109 = v109.z;
			//   *(_QWORD *)&v141.x = v110;
			//   LODWORD(v141.z) = (_DWORD)v109;
			//   v112 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, 0.050000001, v111);
			//   v113 = this.fields.m_MaxExtent;
			//   *(_QWORD *)&v141.x = v53;
			//   v141.z = v54;
			//   v114 = v112.z;
			//   *(_QWORD *)&this.fields.m_WindOffset.x = *(_QWORD *)&v112.x;
			//   this.fields.m_WindOffset.z = v114;
			//   v116 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, v113, v115);
			//   v117 = *(_QWORD *)&v116.x;
			//   *(float *)&v116 = v116.z;
			//   *(_QWORD *)&v141.x = v117;
			//   LODWORD(v141.z) = (_DWORD)v116;
			//   v119 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, deltaTime, v118);
			//   v120 = *(_QWORD *)&v119.x;
			//   *(float *)&v119 = v119.z;
			//   *(_QWORD *)&v141.x = v120;
			//   LODWORD(v141.z) = (_DWORD)v119;
			//   v122 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, 0.050000001, v121);
			//   v123 = this.fields.m_MaxExtent;
			//   *(_QWORD *)&v141.x = v57;
			//   v141.z = v58;
			//   v124 = v122.z;
			//   *(_QWORD *)&this.fields.m_WindOffset2.x = *(_QWORD *)&v122.x;
			//   this.fields.m_WindOffset2.z = v124;
			//   v126 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, v123, v125);
			//   v127 = *(_QWORD *)&v126.x;
			//   *(float *)&v126 = v126.z;
			//   *(_QWORD *)&v141.x = v127;
			//   LODWORD(v141.z) = (_DWORD)v126;
			//   v129 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, deltaTime, v128);
			//   v130 = *(_QWORD *)&v129.x;
			//   *(float *)&v129 = v129.z;
			//   *(_QWORD *)&v141.x = v130;
			//   LODWORD(v141.z) = (_DWORD)v129;
			//   v132 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v142, &v141, 0.050000001, v131);
			//   v133 = this.fields.m_MaxExtent;
			//   v134 = v132.z;
			//   *(_QWORD *)&this.fields.m_WindOffset3.x = *(_QWORD *)&v132.x;
			//   this.fields.m_WindOffset3.z = v134;
			//   m_CloudObject = this.fields.m_CloudMat;
			//   v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   v135 = UnityEngine::Material::GetFloatImpl((Material *)m_CloudObject, *((_DWORD *)v4 + 52), 0LL);
			//   m_CloudObject = this.fields.m_CloudMat;
			//   v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   v136 = UnityEngine::Material::GetFloatImpl((Material *)m_CloudObject, *((_DWORD *)v4 + 37), 0LL);
			//   m_CloudObject = this.fields.m_CloudMat;
			//   v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !m_CloudObject )
			//     goto LABEL_29;
			//   *(float *)&v137 = 0.0099999998;
			//   v138 = UnityEngine::Material::GetFloatImpl((Material *)m_CloudObject, *((_DWORD *)v4 + 54), 0LL)
			//        * (float)((float)(v135 * v133) * v136);
			//   if ( v138 < 0.0099999998 || (*(float *)&v137 = 100.0, v138 > 100.0) )
			//     v138 = *(float *)&v137;
			//   this.fields.m_OpticalDepthScale = v138;
			//   this.fields.m_InvOpticalDepthScale = 1.0 / v138;
			// }
			// 
		}

		private void BakeMSTex(CommandBuffer cmd, Material material, [MetadataOffset(Offset = "0x01F91D50")] bool force = false)
		{
			// // Void BakeMSTex(CommandBuffer, Material, Boolean)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::BakeMSTex(
			//         VolumetricCloudSDF *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   VolumetricMSBake *m_MSBaker; // r12
			//   int32_t m_msBakeSizeX; // r13d
			//   Material *m_CloudMat; // rdi
			//   void *m_propertyBlock; // rcx
			//   Material *static_fields; // rdx
			//   float FloatImpl; // xmm0_4
			//   float v15; // xmm0_4
			//   float v16; // xmm0_4
			//   int32_t Int; // eax
			//   float v18; // xmm0_4
			//   float v19; // xmm0_4
			//   float v20; // xmm0_4
			//   Vector4 v21; // xmm2
			//   VolumetricMSBake *v22; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t m_msBakeSizeY; // [rsp+48h] [rbp-51h]
			//   Vector4 v25; // [rsp+50h] [rbp-49h] BYREF
			//   __int128 v26; // [rsp+60h] [rbp-39h]
			//   __int128 v27; // [rsp+70h] [rbp-29h]
			//   VolumetricMSBake_FMSArgs v28; // [rsp+98h] [rbp-1h] BYREF
			// 
			//   if ( !byte_18D919787 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D919787 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4418, 0LL) )
			//   {
			//     m_MSBaker = this.fields.m_MSBaker;
			//     m_msBakeSizeX = this.fields.m_msBakeSizeX;
			//     m_CloudMat = this.fields.m_CloudMat;
			//     m_msBakeSizeY = this.fields.m_msBakeSizeY;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( m_CloudMat )
			//     {
			//       FloatImpl = UnityEngine::Material::GetFloatImpl(m_CloudMat, HIDWORD(static_fields[11].monitor), 0LL);
			//       m_propertyBlock = this.fields.m_CloudMat;
			//       *(float *)&v26 = FloatImpl;
			//       static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       if ( m_propertyBlock )
			//       {
			//         v15 = UnityEngine::Material::GetFloatImpl(
			//                 (Material *)m_propertyBlock,
			//                 (int32_t)static_fields[11].fields._.m_CachedPtr,
			//                 0LL);
			//         m_propertyBlock = this.fields.m_CloudMat;
			//         *((float *)&v26 + 1) = v15;
			//         static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         if ( m_propertyBlock )
			//         {
			//           v16 = UnityEngine::Material::GetFloatImpl((Material *)m_propertyBlock, HIDWORD(static_fields[12].klass), 0LL);
			//           m_propertyBlock = this.fields.m_CloudMat;
			//           *((float *)&v26 + 2) = v16;
			//           static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           if ( m_propertyBlock )
			//           {
			//             Int = UnityEngine::Material::GetInt((Material *)m_propertyBlock, HIDWORD(static_fields[12].monitor), 0LL);
			//             m_propertyBlock = this.fields.m_CloudMat;
			//             HIDWORD(v26) = Int;
			//             static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//             if ( m_propertyBlock )
			//             {
			//               v18 = UnityEngine::Material::GetFloatImpl(
			//                       (Material *)m_propertyBlock,
			//                       (int32_t)static_fields[12].fields._.m_CachedPtr,
			//                       0LL);
			//               m_propertyBlock = this.fields.m_CloudMat;
			//               *(float *)&v27 = v18;
			//               static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//               if ( m_propertyBlock )
			//               {
			//                 v19 = UnityEngine::Material::GetFloatImpl(
			//                         (Material *)m_propertyBlock,
			//                         HIDWORD(static_fields[12].fields._.m_CachedPtr),
			//                         0LL);
			//                 m_propertyBlock = this.fields.m_CloudMat;
			//                 *((float *)&v27 + 1) = v19;
			//                 static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                 if ( m_propertyBlock )
			//                 {
			//                   v20 = UnityEngine::Material::GetFloatImpl(
			//                           (Material *)m_propertyBlock,
			//                           (int32_t)static_fields[13].klass,
			//                           0LL);
			//                   static_fields = this.fields.m_CloudMat;
			//                   *((float *)&v27 + 2) = v20;
			//                   m_propertyBlock = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                   HIDWORD(v27) = LODWORD(this.fields.m_OpticalDepthScale);
			//                   if ( static_fields )
			//                   {
			//                     v21 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Material::GetVector(
			//                                                                       &v25,
			//                                                                       static_fields,
			//                                                                       *((_DWORD *)m_propertyBlock + 84),
			//                                                                       0LL));
			//                     if ( m_MSBaker )
			//                     {
			//                       *(_OWORD *)&v28.m_Phase = v26;
			//                       *(_OWORD *)&v28.m_MssFactor = v27;
			//                       v28.m_EncodeParams = v21;
			//                       HG::Rendering::Runtime::VolumetricMSBake::BakeMSTexture(
			//                         m_MSBaker,
			//                         cmd,
			//                         m_msBakeSizeX,
			//                         m_msBakeSizeY,
			//                         &v28,
			//                         material,
			//                         force,
			//                         0LL);
			//                       v22 = this.fields.m_MSBaker;
			//                       m_propertyBlock = this.fields.m_propertyBlock;
			//                       static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                       if ( v22 )
			//                       {
			//                         if ( m_propertyBlock )
			//                         {
			//                           UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//                             (MaterialPropertyBlock *)m_propertyBlock,
			//                             (int32_t)static_fields[12].monitor,
			//                             (Texture *)v22.fields._msTexture,
			//                             0LL);
			//                           return;
			//                         }
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
			// LABEL_17:
			//     sub_180B536AC(m_propertyBlock, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4418, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(
			//     (ILFixDynamicMethodWrapper_13 *)Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     (Object *)material,
			//     force,
			//     0LL);
			// }
			// 
		}

		private void UpdateMat()
		{
			// // Void UpdateMat()
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateMat(VolumetricCloudSDF *this, MethodInfo *method)
			// {
			//   GameObject *m_CloudObject; // rdi
			//   int32_t RenderObjectLayer; // eax
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   __int64 v6; // rcx
			//   Animator *v7; // rdx
			//   int32_t v8; // r8d
			//   MethodInfo *v9; // r9
			//   Vector3 *Vector; // rax
			//   MethodInfo *v11; // xmm6_8
			//   float z; // edi
			//   MethodInfo *v13; // rdx
			//   Vector3 *one; // rax
			//   __int64 v15; // xmm7_8
			//   float v16; // esi
			//   MethodInfo *v17; // r9
			//   VolumetricSdfAsset *m_CloudAsset; // rax
			//   MethodInfo *v19; // xmm0_8
			//   float v20; // eax
			//   Vector3 *v21; // rax
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   VolumetricSdfAsset *v24; // rax
			//   VolumetricEncodedTexture__Array *SdfTexs; // rcx
			//   VolumetricEncodedTexture *v26; // rax
			//   PassConstructorID__Enum__Array *v27; // r8
			//   VolumetricSdfAsset *v28; // r9
			//   VolumetricEncodedTexture *v29; // rax
			//   PassConstructorID__Enum__Array *v30; // r8
			//   VolumetricSdfAsset *v31; // r9
			//   VolumetricEncodedTexture *v32; // rax
			//   GameObject *v33; // rcx
			//   Transform *transform; // rax
			//   Transform *v35; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v37; // [rsp+20h] [rbp-40h] BYREF
			//   MethodInfo *v38; // [rsp+28h] [rbp-38h]
			//   Vector3 v39; // [rsp+30h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919788 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919788 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4389, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4389, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_34;
			//   }
			//   m_CloudObject = this.fields.m_CloudObject;
			//   RenderObjectLayer = HG::Rendering::Runtime::VolumetricRenderObject::get_RenderObjectLayer(
			//                         (VolumetricRenderObject *)this,
			//                         0LL);
			//   if ( !m_CloudObject )
			//     goto LABEL_34;
			//   UnityEngine::GameObject::set_layer(m_CloudObject, RenderObjectLayer, 0LL);
			//   Vector = UnityEngine::Animator::GetVector(&v39, v7, v8, v9);
			//   v11 = *(MethodInfo **)&Vector.x;
			//   z = Vector.z;
			//   one = UnityEngine::Vector3::get_one(&v39, v13);
			//   v15 = *(_QWORD *)&one.x;
			//   v16 = one.z;
			//   if ( HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(this, 0LL) )
			//   {
			//     m_CloudAsset = this.fields.m_CloudAsset;
			//     if ( m_CloudAsset )
			//     {
			//       v11 = *(MethodInfo **)&m_CloudAsset.fields.VolumeBounds.m_Center.x;
			//       z = m_CloudAsset.fields.VolumeBounds.m_Center.z;
			//       v19 = *(MethodInfo **)&m_CloudAsset.fields.VolumeBounds.m_Extents.x;
			//       v20 = m_CloudAsset.fields.VolumeBounds.m_Extents.z;
			//       v37 = v19;
			//       *(float *)&v38 = v20;
			//       v21 = UnityEngine::Vector3::op_Multiply(&v39, (Vector3 *)&v37, 2.0, v17);
			//       v15 = *(_QWORD *)&v21.x;
			//       v16 = v21.z;
			//       sub_180002C70(TypeInfo::System::Math);
			//       v24 = this.fields.m_CloudAsset;
			//       if ( v24 )
			//       {
			//         if ( v24.fields.SdfTexs && (SdfTexs = v24.fields.SdfTexs, SdfTexs.max_length.value) )
			//         {
			//           if ( !SdfTexs.max_length.size )
			//             goto LABEL_23;
			//           v26 = SdfTexs.vector[0];
			//         }
			//         else
			//         {
			//           v26 = 0LL;
			//         }
			//         this.fields.DensityTextureToUse = v26;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.DensityTextureToUse, v5, v22, v23, v37, v38);
			//         v28 = this.fields.m_CloudAsset;
			//         if ( v28 )
			//         {
			//           if ( v28.fields.SdfTexs && (SdfTexs = v28.fields.SdfTexs, SdfTexs.max_length.size > 1) )
			//           {
			//             if ( SdfTexs.max_length.size <= 1u )
			//               goto LABEL_23;
			//             v29 = SdfTexs.vector[1];
			//           }
			//           else
			//           {
			//             v29 = 0LL;
			//           }
			//           this.fields.AdvancedTextureToUse = v29;
			//           sub_1800054D0((HGRenderPathScene *)&this.fields.AdvancedTextureToUse, v5, v27, (HGCamera *)v28, v37, v38);
			//           v31 = this.fields.m_CloudAsset;
			//           if ( v31 )
			//           {
			//             if ( v31.fields.SdfTexs && (SdfTexs = v31.fields.SdfTexs, SdfTexs.max_length.size > 2) )
			//             {
			//               if ( SdfTexs.max_length.size <= 2u )
			// LABEL_23:
			//                 sub_180070270(SdfTexs, v5);
			//               v32 = SdfTexs.vector[2];
			//             }
			//             else
			//             {
			//               v32 = 0LL;
			//             }
			//             this.fields.SHTextureToUse = v32;
			//             sub_1800054D0((HGRenderPathScene *)&this.fields.SHTextureToUse, v5, v30, (HGCamera *)v31, v37, v38);
			//             goto LABEL_27;
			//           }
			//         }
			//       }
			//     }
			// LABEL_34:
			//     sub_180B536AC(v6, v5);
			//   }
			// LABEL_27:
			//   v33 = this.fields.m_CloudObject;
			//   if ( !v33
			//     || (transform = UnityEngine::GameObject::get_transform(v33, 0LL)) == 0LL
			//     || (v37 = v11,
			//         *(float *)&v38 = z,
			//         UnityEngine::Transform::set_localPosition(transform, (Vector3 *)&v37, 0LL),
			//         (v33 = this.fields.m_CloudObject) == 0LL)
			//     || (v35 = UnityEngine::GameObject::get_transform(v33, 0LL)) == 0LL )
			//   {
			//     sub_180B536AC(v33, v5);
			//   }
			//   *(_QWORD *)&v39.x = v15;
			//   v39.z = v16;
			//   UnityEngine::Transform::set_localScale(v35, &v39, 0LL);
			//   HG::Rendering::Runtime::VolumetricCloudSDF::UpdateCloudParameters(this, 0LL);
			// }
			// 
		}

		private bool IsFarModePanoramic(HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Boolean IsFarModePanoramic(HGVolumetricCloudSettingParameters)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(
			//         VolumetricCloudSDF *this,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   VolumetricShaderKeywords__StaticFields *static_fields; // rdx
			//   __int64 v6; // rcx
			//   Material *m_CloudMat; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919789 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D919789 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4431, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4431, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)volumetricParameters,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( UnityEngine::Shader::get_globalMaximumLOD(0LL) != 600 )
			//     {
			//       if ( !volumetricParameters )
			//         goto LABEL_11;
			//       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              volumetricParameters.fields.enableFarCloud,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//       {
			//         m_CloudMat = this.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//         if ( m_CloudMat )
			//           return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields.s_FarModePanoramic, 0LL);
			// LABEL_11:
			//         sub_180B536AC(v6, static_fields);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private bool IsFarModeOctahedron(HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Boolean IsFarModeOctahedron(HGVolumetricCloudSettingParameters)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
			//         VolumetricCloudSDF *this,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   VolumetricShaderKeywords__StaticFields *static_fields; // rdx
			//   __int64 v6; // rcx
			//   Material *m_CloudMat; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91978A )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D91978A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4432, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4432, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)volumetricParameters,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( UnityEngine::Shader::get_globalMaximumLOD(0LL) != 600 )
			//     {
			//       if ( !volumetricParameters )
			//         goto LABEL_11;
			//       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              volumetricParameters.fields.enableFarCloud,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//       {
			//         m_CloudMat = this.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//         if ( m_CloudMat )
			//           return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields.s_FarModeOctahedron, 0LL);
			// LABEL_11:
			//         sub_180B536AC(v6, static_fields);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private bool IsFarModeSemicircular(HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Boolean IsFarModeSemicircular(HGVolumetricCloudSettingParameters)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
			//         VolumetricCloudSDF *this,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   VolumetricShaderKeywords__StaticFields *static_fields; // rdx
			//   __int64 v6; // rcx
			//   Material *m_CloudMat; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91978B )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     byte_18D91978B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4433, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4433, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)volumetricParameters,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( UnityEngine::Shader::get_globalMaximumLOD(0LL) != 600 )
			//     {
			//       if ( !volumetricParameters )
			//         goto LABEL_11;
			//       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              volumetricParameters.fields.enableFarCloud,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//       {
			//         m_CloudMat = this.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//         if ( m_CloudMat )
			//           return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields.s_FarModeSemicircular, 0LL);
			// LABEL_11:
			//         sub_180B536AC(v6, static_fields);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public void BakeFarCloud(VolumetricFarCloudRenderer farRenderer, HGCamera hgCamera, CommandBuffer cmd, HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Void BakeFarCloud(VolumetricFarCloudRenderer, HGCamera, CommandBuffer, HGVolumetricCloudSettingParameters)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::BakeFarCloud(
			//         VolumetricCloudSDF *this,
			//         VolumetricFarCloudRenderer *farRenderer,
			//         HGCamera *hgCamera,
			//         CommandBuffer *cmd,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_CloudMat; // rbx
			//   bool IsFadeInFromCamera; // r12
			//   bool IsFarModeOctahedron; // r15
			//   bool IsFarModeSemicircular; // al
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   bool v15; // r13
			//   MaterialPropertyBlock *m_propertyBlock; // r12
			//   MaterialPropertyBlock *propertyBlock; // rcx
			//   float v18; // xmm0_4
			//   MaterialPropertyBlock *v19; // r12
			//   float v20; // xmm0_4
			//   Material *v21; // r9
			//   bool force; // al
			//   bool v23; // al
			//   bool v24; // al
			//   bool v25; // [rsp+40h] [rbp-38h]
			//   bool IsFarModePanoramic; // [rsp+41h] [rbp-37h]
			//   int32_t name; // [rsp+44h] [rbp-34h]
			//   int32_t namea; // [rsp+44h] [rbp-34h]
			// 
			//   if ( !byte_18D91978D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D91978D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4430, 0LL) )
			//   {
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//       return;
			//     IsFadeInFromCamera = HG::Rendering::Runtime::VolumetricCloudSDF::IsFadeInFromCamera(this, hgCamera, 0LL);
			//     v25 = IsFadeInFromCamera;
			//     IsFarModePanoramic = HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(this, volumetricParameters, 0LL);
			//     IsFarModeOctahedron = HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
			//                             this,
			//                             volumetricParameters,
			//                             0LL);
			//     IsFarModeSemicircular = HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
			//                               this,
			//                               volumetricParameters,
			//                               0LL);
			//     static_fields = 0LL;
			//     v15 = IsFarModeSemicircular;
			//     if ( IsFarModePanoramic )
			//     {
			//       propertyBlock = this.fields.m_propertyBlock;
			//       if ( farRenderer )
			//       {
			//         v24 = IsFadeInFromCamera;
			//         if ( !this.fields.bLastPanoramic )
			//           v24 = 1;
			//         HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdatePanoramicRT(
			//           farRenderer,
			//           hgCamera,
			//           cmd,
			//           this.fields.m_CloudMat,
			//           propertyBlock,
			//           volumetricParameters,
			//           v24,
			//           0LL);
			//         goto LABEL_23;
			//       }
			//     }
			//     else
			//     {
			//       if ( !IsFarModeOctahedron && !IsFarModeSemicircular )
			//       {
			// LABEL_23:
			//         this.fields.bLastPanoramic = IsFarModePanoramic;
			//         this.fields.bLastOctahedron = IsFarModeOctahedron;
			//         this.fields.bLastSemicircular = v15;
			//         return;
			//       }
			//       m_propertyBlock = this.fields.m_propertyBlock;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       propertyBlock = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       name = static_fields._OctahedronHeightScale;
			//       if ( volumetricParameters )
			//       {
			//         v18 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                 volumetricParameters.fields.octahedronHeightScale,
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//         if ( m_propertyBlock )
			//         {
			//           UnityEngine::MaterialPropertyBlock::SetFloatImpl(m_propertyBlock, name, v18, 0LL);
			//           v19 = this.fields.m_propertyBlock;
			//           namea = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._SemicircularZScale;
			//           v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                   volumetricParameters.fields.semicircularZScale,
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//           if ( v19 )
			//           {
			//             UnityEngine::MaterialPropertyBlock::SetFloatImpl(v19, namea, v20, 0LL);
			//             v21 = this.fields.m_CloudMat;
			//             static_fields = 0LL;
			//             propertyBlock = this.fields.m_propertyBlock;
			//             if ( IsFarModeOctahedron )
			//             {
			//               if ( farRenderer )
			//               {
			//                 v23 = v25;
			//                 if ( !this.fields.bLastOctahedron )
			//                   v23 = 1;
			//                 HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateOctahedronRT(
			//                   farRenderer,
			//                   hgCamera,
			//                   cmd,
			//                   v21,
			//                   propertyBlock,
			//                   volumetricParameters,
			//                   v23,
			//                   0LL);
			//                 goto LABEL_23;
			//               }
			//             }
			//             else if ( farRenderer )
			//             {
			//               force = v25;
			//               if ( !this.fields.bLastSemicircular )
			//                 force = 1;
			//               HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateSemicircularRT(
			//                 farRenderer,
			//                 hgCamera,
			//                 cmd,
			//                 v21,
			//                 propertyBlock,
			//                 volumetricParameters,
			//                 force,
			//                 0LL);
			//               goto LABEL_23;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_25:
			//     sub_180B536AC(propertyBlock, static_fields);
			//   }
			//   propertyBlock = (MaterialPropertyBlock *)IFix::WrappersManagerImpl::GetPatch(4430, 0LL);
			//   if ( !propertyBlock )
			//     goto LABEL_25;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_18(
			//     (ILFixDynamicMethodWrapper_18 *)propertyBlock,
			//     (Object *)this,
			//     (Object *)farRenderer,
			//     (Object *)hgCamera,
			//     (Object *)cmd,
			//     (Object *)volumetricParameters,
			//     0LL);
			// }
			// 
		}

		private bool IsFarCloudRTValid(HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Boolean IsFarCloudRTValid(HGVolumetricCloudSettingParameters)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarCloudRTValid(
			//         VolumetricCloudSDF *this,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_CloudMat; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D91978E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91978E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4442, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4442, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)volumetricParameters,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     return UnityEngine::Object::op_Implicit(m_CloudMat, 0LL)
			//         && (HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(this, volumetricParameters, 0LL)
			//          || HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(this, volumetricParameters, 0LL)
			//          || HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(this, volumetricParameters, 0LL));
			//   }
			// }
			// 
			return default(bool);
		}

		public override bool OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext composeContext, out VolumetricRenderer.VolumetricRenderItem item)
		{
			// // Boolean OverrideFramingCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::OverrideFramingCompose(
			//         VolumetricCloudSDF *this,
			//         VolumetricRenderer_VolumetricComposeContext *composeContext,
			//         VolumetricRenderer_VolumetricRenderItem *item,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   Material *v9; // rcx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   __int64 v12; // r15
			//   HGVolumetricCloudSettingParameters *v13; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   Object_1 *m_CloudMat; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v19; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   Material *v27; // rbx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   Material *v30; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   Material *v35; // rcx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *FramingRendererCallback; // r13
			//   Material *v37; // rax
			//   char v38; // r15
			//   int32_t renderQueue; // ebx
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   HGRenderPathBase_HGRenderPathResources *v44; // rdx
			//   PassConstructorID__Enum__Array *v45; // r8
			//   HGCamera *v46; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
			//   MethodInfo *v49; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v50; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v51; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v52; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v53; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v54; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v55; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v56; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v57; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v58; // [rsp+30h] [rbp-D8h]
			//   _BYTE v59[64]; // [rsp+78h] [rbp-90h] BYREF
			//   Material *v60; // [rsp+B8h] [rbp-50h]
			//   VolumetricRenderer_VolumetricRenderItem v61; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D91978F )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass93_0::_OverrideFramingCompose_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass93_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D91978F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4443, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4443, 0LL);
			//     if ( !Patch )
			//       goto LABEL_28;
			//     volumetricSettings = composeContext.volumetricSettings;
			//     *(_OWORD *)v59 = *(_OWORD *)&composeContext.bEnableFraming;
			//     *(_QWORD *)&v59[16] = volumetricSettings;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1278(
			//              Patch,
			//              (Object *)this,
			//              (VolumetricRenderer_VolumetricComposeContext *)v59,
			//              item,
			//              0LL);
			//   }
			//   else
			//   {
			//     v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass93_0);
			//     v12 = v7;
			//     if ( !v7 )
			//       goto LABEL_28;
			//     *(_QWORD *)(v7 + 16) = this;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)(v7 + 16),
			//       (HGRenderPathBase_HGRenderPathResources *)static_fields,
			//       v10,
			//       v11,
			//       v49,
			//       v54);
			//     v13 = composeContext.volumetricSettings;
			//     *(_OWORD *)(v12 + 24) = *(_OWORD *)&composeContext.bEnableFraming;
			//     *(_QWORD *)(v12 + 40) = v13;
			//     sub_1800054D0((HGRenderPathScene *)(v12 + 32), v14, v15, v16, v50, v55);
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     {
			//       if ( !this.fields._._FramingRendererCallback )
			//       {
			//         v19 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_180004920(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//         v20 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v19;
			//         if ( !v19 )
			//           goto LABEL_28;
			//         System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
			//           v19,
			//           (Object *)v12,
			//           MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass93_0::_OverrideFramingCompose_b__0[0],
			//           0LL);
			//         this.fields._._FramingRendererCallback = v20;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields._._FramingRendererCallback, v21, v22, v23, v51, v56);
			//       }
			//       if ( this.fields.m_DrawFar
			//         && HG::Rendering::Runtime::VolumetricCloudSDF::IsFarCloudRTValid(
			//              this,
			//              *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//              0LL) )
			//       {
			//         sub_1802F01E0(item, 0LL, 88LL);
			//         if ( HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(
			//                this,
			//                *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//                0LL) )
			//         {
			//           item.Callback = this.fields._._FramingRendererCallback;
			//           sub_1800054D0((HGRenderPathScene *)item, v24, v25, v26, v51, v56);
			//           LOBYTE(v33) = *(_BYTE *)(v12 + 25);
			//           item.bEnableTAA = (char)v33;
			// LABEL_20:
			//           *(_WORD *)&item.bPureBlit = 256;
			//           item.material = this.fields.m_CloudMat;
			//           sub_1800054D0((HGRenderPathScene *)&item.material, v31, v32, v33, v52, v57);
			//           v9 = this.fields.m_CloudMat;
			//           if ( v9 )
			//           {
			//             item.RenderQueue = UnityEngine::Material::get_renderQueue(v9, 0LL);
			//             return 1;
			//           }
			// LABEL_28:
			//           sub_180B536AC(v9, static_fields);
			//         }
			//         if ( HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
			//                this,
			//                *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//                0LL)
			//           || HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
			//                this,
			//                *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//                0LL) )
			//         {
			//           v27 = this.fields.m_CloudMat;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           if ( !v27 )
			//             goto LABEL_28;
			//           if ( UnityEngine::Material::GetInt(v27, static_fields._FarCloudSSTAA, 0LL) > 0 || !*(_BYTE *)(v12 + 25) )
			//           {
			//             item.Callback = this.fields._._FramingRendererCallback;
			//             sub_1800054D0((HGRenderPathScene *)item, v18, v28, v29, v51, v56);
			//             v30 = this.fields.m_CloudMat;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//             static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//             if ( !v30 )
			//               goto LABEL_28;
			//             item.bEnableTAA = UnityEngine::Material::GetInt(v30, static_fields._FarCloudSSTAA, 0LL) > 0;
			//             goto LABEL_20;
			//           }
			//         }
			//       }
			//       v35 = this.fields.m_CloudMat;
			//       FramingRendererCallback = this.fields._._FramingRendererCallback;
			//       *(_QWORD *)&v59[16] = 0LL;
			//       v37 = *(Material **)(v12 + 32);
			//       v38 = *(_BYTE *)(v12 + 25);
			//       v60 = v37;
			//       memset(&v59[32], 0, 28);
			//       if ( !v35 )
			//         sub_180B536AC(0LL, v18);
			//       renderQueue = UnityEngine::Material::get_renderQueue(v35, 0LL);
			//       sub_1802F01E0(&v61, 0LL, 88LL);
			//       *(VolumetricRenderer_VolumetricBounds *)v59 = *(VolumetricRenderer_VolumetricBounds *)&v59[32];
			//       HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
			//         &v61,
			//         FramingRendererCallback,
			//         (VolumetricRenderer_VolumetricBounds *)v59,
			//         v60,
			//         0,
			//         v38,
			//         0,
			//         renderQueue,
			//         99999.0,
			//         0,
			//         1,
			//         0,
			//         0LL);
			//       v40 = *(_OWORD *)&v61.bounds.enableBounds;
			//       *(_OWORD *)&item.Callback = *(_OWORD *)&v61.Callback;
			//       v41 = *(_OWORD *)&v61.bounds.worldBounds.m_Extents.x;
			//       *(_OWORD *)&item.bounds.enableBounds = v40;
			//       v42 = *(_OWORD *)&v61.SortingOrder;
			//       *(_OWORD *)&item.bounds.worldBounds.m_Extents.x = v41;
			//       v43 = *(_OWORD *)&v61.bPureBlit;
			//       *(_OWORD *)&item.SortingOrder = v42;
			//       *(_QWORD *)&v42 = v61.meshFilter;
			//       *(_OWORD *)&item.bPureBlit = v43;
			//       item.meshFilter = (MeshFilter *)v42;
			//       sub_1800054D0((HGRenderPathScene *)item, v44, v45, v46, v53, v58);
			//       return 1;
			//     }
			//     sub_1802F01E0(item, 0LL, 88LL);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public override bool OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext composeContext, out VolumetricRenderer.VolumetricRenderItem item)
		{
			// // Boolean OverrideTemporalCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::OverrideTemporalCompose(
			//         VolumetricCloudSDF *this,
			//         VolumetricRenderer_VolumetricComposeContext *composeContext,
			//         VolumetricRenderer_VolumetricRenderItem *item,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rax
			//   VolumetricShaderIDs__StaticFields *static_fields; // rdx
			//   Material *v9; // rcx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   __int64 v12; // rsi
			//   HGVolumetricCloudSettingParameters *v13; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   Object_1 *m_CloudMat; // rbx
			//   __int64 v18; // rdx
			//   Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v19; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   Material *v24; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   HGRenderPathBase_HGRenderPathResources *v28; // rdx
			//   PassConstructorID__Enum__Array *v29; // r8
			//   HGCamera *v30; // r9
			//   int32_t v31; // eax
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   MeshFilter *meshFilter; // xmm1_8
			//   Material *v41; // rcx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *TemporalComposeCallBack; // r15
			//   Material *v43; // rsi
			//   int32_t renderQueue; // ebx
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
			//   MethodInfo *v50; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v51; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v52; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v53; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v54; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v55; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v56; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v57; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v58; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v59; // [rsp+28h] [rbp-D8h]
			//   _BYTE v60[64]; // [rsp+70h] [rbp-90h] BYREF
			//   _OWORD v61[3]; // [rsp+B0h] [rbp-50h] BYREF
			//   __int128 v62; // [rsp+E0h] [rbp-20h]
			//   __int128 v63; // [rsp+F0h] [rbp-10h]
			//   MeshFilter *v64; // [rsp+100h] [rbp+0h]
			//   VolumetricRenderer_VolumetricRenderItem v65; // [rsp+110h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D919790 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass94_0::_OverrideTemporalCompose_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass94_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D919790 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4446, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4446, 0LL);
			//     if ( !Patch )
			//       goto LABEL_23;
			//     volumetricSettings = composeContext.volumetricSettings;
			//     *(_OWORD *)v60 = *(_OWORD *)&composeContext.bEnableFraming;
			//     *(_QWORD *)&v60[16] = volumetricSettings;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1278(
			//              Patch,
			//              (Object *)this,
			//              (VolumetricRenderer_VolumetricComposeContext *)v60,
			//              item,
			//              0LL);
			//   }
			//   else
			//   {
			//     v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass94_0);
			//     v12 = v7;
			//     if ( !v7 )
			//       goto LABEL_23;
			//     *(_QWORD *)(v7 + 16) = this;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)(v7 + 16),
			//       (HGRenderPathBase_HGRenderPathResources *)static_fields,
			//       v10,
			//       v11,
			//       v50,
			//       v55);
			//     v13 = composeContext.volumetricSettings;
			//     *(_OWORD *)(v12 + 24) = *(_OWORD *)&composeContext.bEnableFraming;
			//     *(_QWORD *)(v12 + 40) = v13;
			//     sub_1800054D0((HGRenderPathScene *)(v12 + 32), v14, v15, v16, v51, v56);
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     {
			//       if ( !this.fields._._TemporalComposeCallBack )
			//       {
			//         v19 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_180004920(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//         v20 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v19;
			//         if ( !v19 )
			//           goto LABEL_23;
			//         System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
			//           v19,
			//           (Object *)v12,
			//           MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass94_0::_OverrideTemporalCompose_b__0[0],
			//           0LL);
			//         this.fields._._TemporalComposeCallBack = v20;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields._._TemporalComposeCallBack, v21, v22, v23, v52, v57);
			//       }
			//       if ( !this.fields.m_DrawFar
			//         || !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarCloudRTValid(
			//               this,
			//               *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//               0LL)
			//         || !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
			//               this,
			//               *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//               0LL)
			//         && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
			//               this,
			//               *(HGVolumetricCloudSettingParameters **)(v12 + 40),
			//               0LL) )
			//       {
			//         goto LABEL_18;
			//       }
			//       v24 = this.fields.m_CloudMat;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       if ( !v24 )
			//         goto LABEL_23;
			//       if ( UnityEngine::Material::GetInt(v24, static_fields._FarCloudSSTAA, 0LL) )
			//       {
			// LABEL_18:
			//         v41 = this.fields.m_CloudMat;
			//         TemporalComposeCallBack = this.fields._._TemporalComposeCallBack;
			//         v43 = *(Material **)(v12 + 32);
			//         *(_QWORD *)&v60[16] = 0LL;
			//         memset(&v60[32], 0, 28);
			//         if ( !v41 )
			//           sub_180B536AC(0LL, v18);
			//         renderQueue = UnityEngine::Material::get_renderQueue(v41, 0LL);
			//         sub_1802F01E0(&v65, 0LL, 88LL);
			//         *(VolumetricRenderer_VolumetricBounds *)v60 = *(VolumetricRenderer_VolumetricBounds *)&v60[32];
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
			//           &v65,
			//           TemporalComposeCallBack,
			//           (VolumetricRenderer_VolumetricBounds *)v60,
			//           v43,
			//           0,
			//           0,
			//           0,
			//           renderQueue,
			//           99999.0,
			//           0,
			//           1,
			//           0,
			//           0LL);
			//         v45 = *(_OWORD *)&v65.bounds.enableBounds;
			//         *(_OWORD *)&item.Callback = *(_OWORD *)&v65.Callback;
			//         v46 = *(_OWORD *)&v65.bounds.worldBounds.m_Extents.x;
			//         *(_OWORD *)&item.bounds.enableBounds = v45;
			//         v47 = *(_OWORD *)&v65.SortingOrder;
			//         *(_OWORD *)&item.bounds.worldBounds.m_Extents.x = v46;
			//         v38 = *(_OWORD *)&v65.bPureBlit;
			//         *(_OWORD *)&item.SortingOrder = v47;
			//         meshFilter = v65.meshFilter;
			//         goto LABEL_17;
			//       }
			//       sub_1802F01E0((char *)v61 + 8, 0LL, 80LL);
			//       *(_QWORD *)&v61[0] = this.fields._._TemporalComposeCallBack;
			//       sub_1800054D0((HGRenderPathScene *)v61, v25, v26, v27, v52, v57);
			//       *((_QWORD *)&v61[0] + 1) = this.fields.m_CloudMat;
			//       LOWORD(v63) = 256;
			//       sub_1800054D0((HGRenderPathScene *)((char *)v61 + 8), v28, v29, v30, v53, v58);
			//       v9 = this.fields.m_CloudMat;
			//       if ( v9 )
			//       {
			//         v31 = UnityEngine::Material::get_renderQueue(v9, 0LL);
			//         v35 = v61[1];
			//         *(_OWORD *)&item.Callback = v61[0];
			//         DWORD1(v62) = v31;
			//         v36 = v61[2];
			//         *(_OWORD *)&item.bounds.enableBounds = v35;
			//         v37 = v62;
			//         *(_OWORD *)&item.bounds.worldBounds.m_Extents.x = v36;
			//         v38 = v63;
			//         *(_OWORD *)&item.SortingOrder = v37;
			//         meshFilter = v64;
			// LABEL_17:
			//         *(_OWORD *)&item.bPureBlit = v38;
			//         item.meshFilter = meshFilter;
			//         sub_1800054D0((HGRenderPathScene *)item, v32, v33, v34, v54, v59);
			//         return 1;
			//       }
			// LABEL_23:
			//       sub_180B536AC(v9, static_fields);
			//     }
			//     sub_1802F01E0(item, 0LL, 88LL);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private void UpdateParametersFromPipeline(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // Void UpdateParametersFromPipeline(HGCamera, HGVolumetricCloudSettingParameters)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipeline(
			//         VolumetricCloudSDF *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   Material *static_fields; // rdx
			//   MaterialPropertyBlock *m_WindFieldManager; // rcx
			//   Camera *camera; // r12
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __m128 v12; // xmm9
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   MethodInfo *v16; // r8
			//   Vector3 *v17; // rax
			//   __int64 v18; // xmm10_8
			//   float z; // r13d
			//   MethodInfo *v20; // r9
			//   Vector3 *v21; // rax
			//   __int64 v22; // xmm8_8
			//   float v23; // edi
			//   MethodInfo *v24; // rdx
			//   Vector3 *one; // rax
			//   __int64 v26; // xmm6_8
			//   float v27; // ebx
			//   float v28; // xmm7_4
			//   MethodInfo *v29; // r9
			//   Vector3 *v30; // rax
			//   float v31; // xmm2_4
			//   __m128 x_low; // xmm0
			//   __m128 y_low; // xmm1
			//   MethodInfo *v34; // r9
			//   Vector3 *v35; // rax
			//   float v36; // xmm1_4
			//   bool v37; // al
			//   Material *m_CloudMat; // rbx
			//   Material *v39; // rbx
			//   MaterialPropertyBlock *m_propertyBlock; // rdi
			//   VolumetricEncodedTexture *DensityTextureToUse; // rbx
			//   MaterialPropertyBlock *v42; // rbx
			//   int32_t klass; // edx
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   int32_t klass_high; // edx
			//   __int128 v48; // xmm1
			//   MaterialPropertyBlock *v49; // rcx
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   MethodInfo *v52; // r8
			//   Vector4 *v53; // rax
			//   MaterialPropertyBlock *v54; // r10
			//   int32_t v55; // r11d
			//   MethodInfo *v56; // r8
			//   Vector4 *v57; // rax
			//   MaterialPropertyBlock *v58; // r10
			//   int32_t v59; // r11d
			//   MethodInfo *v60; // r8
			//   Vector4 *v61; // rax
			//   MaterialPropertyBlock *v62; // r10
			//   int32_t v63; // r11d
			//   MethodInfo *v64; // r8
			//   Vector4 *v65; // rax
			//   MaterialPropertyBlock *v66; // r10
			//   int32_t v67; // r11d
			//   MethodInfo *v68; // r8
			//   Vector4 *v69; // rax
			//   MaterialPropertyBlock *v70; // r10
			//   int32_t v71; // r11d
			//   Vector4 *Vector; // rax
			//   MaterialPropertyBlock *v73; // rbx
			//   float m_MaxExtent; // xmm8_4
			//   __m128 v75; // xmm6
			//   VolumetricShaderIDs__StaticFields *v76; // rax
			//   int32_t MsFalloffRangeRemap; // edi
			//   float v78; // xmm2_4
			//   float v79; // xmm6_4
			//   float FloatImpl; // xmm0_4
			//   float v81; // xmm6_4
			//   MethodInfo *v82; // r8
			//   Vector4 *v83; // rax
			//   MaterialPropertyBlock *v84; // r10
			//   int32_t v85; // r11d
			//   MethodInfo *v86; // r8
			//   Vector4 *v87; // rax
			//   MaterialPropertyBlock *v88; // r10
			//   int32_t v89; // r11d
			//   MethodInfo *v90; // r8
			//   Vector4 *v91; // rax
			//   MaterialPropertyBlock *v92; // r10
			//   int32_t v93; // r11d
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // r8
			//   Vector3 *updated; // rax
			//   __int64 v96; // xmm1_8
			//   MethodInfo *z_low; // r8
			//   Vector4 *v98; // rax
			//   MaterialPropertyBlock *v99; // r10
			//   int32_t v100; // r11d
			//   MethodInfo *v101; // r8
			//   Vector4 *v102; // rax
			//   MaterialPropertyBlock *v103; // r10
			//   int32_t v104; // r11d
			//   int v105; // eax
			//   int v106; // ebx
			//   int v107; // eax
			//   int v108; // ebx
			//   __m128 v109; // xmm0
			//   MaterialPropertyBlock *v110; // rbx
			//   int32_t DynamicStepRange; // edi
			//   __m128 v112; // xmm6
			//   Vector4 *v113; // rax
			//   MaterialPropertyBlock *v114; // rbx
			//   int32_t DynamicStepScale; // edi
			//   float v116; // xmm0_4
			//   MethodInfo *v117; // rdx
			//   __m128 v118; // xmm6
			//   __m128 v119; // xmm7
			//   MaterialPropertyBlock *v120; // rbx
			//   float v121; // xmm0_4
			//   Vector4 *v122; // rax
			//   int32_t v123; // r10d
			//   MaterialPropertyBlock *v124; // rbx
			//   int32_t WindFieldNum; // edi
			//   int32_t v126; // eax
			//   ComputeBuffer *WindFieldBuffer; // rax
			//   ComputeBuffer *v128; // rbx
			//   MaterialPropertyBlock *v129; // rdi
			//   int32_t m_CachedPtr; // r14d
			//   int32_t count; // r15d
			//   int32_t stride; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v134; // [rsp+38h] [rbp-99h] BYREF
			//   Vector4 v135; // [rsp+48h] [rbp-89h] BYREF
			//   Vector3 v136; // [rsp+58h] [rbp-79h] BYREF
			//   Vector3 v137; // [rsp+68h] [rbp-69h] BYREF
			//   Matrix4x4 v138[2]; // [rsp+78h] [rbp-59h] BYREF
			// 
			//   if ( !byte_18D919791 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&off_18D520368);
			//     sub_18003C530(&off_18D520378);
			//     sub_18003C530(&off_18D520388);
			//     sub_18003C530(&off_18D520338);
			//     byte_18D919791 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4449, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         transform = UnityEngine::Component::get_transform((Component *)hgCamera.fields.camera, 0LL);
			//         if ( transform )
			//         {
			//           position = UnityEngine::Transform::get_position((Vector3 *)&v135, transform, 0LL);
			//           v12 = (__m128)0x3F800000u;
			//           v134.w = 1.0;
			//           *(_QWORD *)&v136.x = *(_QWORD *)&position.x;
			//           *(_QWORD *)&v134.x = *(_QWORD *)&v136.x;
			//           v134.z = position.z;
			//           v13 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m01;
			//           *(_OWORD *)&v138[0].m00 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m00;
			//           v14 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m02;
			//           *(_OWORD *)&v138[0].m01 = v13;
			//           v15 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m03;
			//           *(_OWORD *)&v138[0].m02 = v14;
			//           *(_OWORD *)&v138[0].m03 = v15;
			//           v134 = *UnityEngine::Matrix4x4::op_Multiply(&v135, v138, &v134, 0LL);
			//           v17 = UnityEngine::Vector4::op_Implicit(&v137, &v134, v16);
			//           *(_QWORD *)&v136.x = *(_QWORD *)&this.fields.m_VoxelSize.x;
			//           v18 = *(_QWORD *)&v17.x;
			//           z = v17.z;
			//           *(float *)&v17 = this.fields.m_VoxelSize.z;
			//           *(_QWORD *)&v135.x = v18;
			//           LODWORD(v136.z) = (_DWORD)v17;
			//           v21 = UnityEngine::Vector3::op_Multiply(&v137, &v136, 0.5, v20);
			//           v22 = *(_QWORD *)&v21.x;
			//           v23 = v21.z;
			//           one = UnityEngine::Vector3::get_one(&v137, v24);
			//           v26 = *(_QWORD *)&one.x;
			//           v27 = one.z;
			//           v28 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//           sub_180002C70(TypeInfo::System::Math);
			//           *(_QWORD *)&v136.x = v26;
			//           *(float *)&v26 = this.fields.m_MaxExtent;
			//           v136.z = v27;
			//           *(float *)&v15 = System::Math::Max(v28, 1.0, 0LL);
			//           v30 = UnityEngine::Vector3::op_Multiply(&v137, &v136, *(float *)&v15, v29);
			//           v31 = v30.z;
			//           *(_QWORD *)&v136.x = *(_QWORD *)&v30.x;
			//           x_low = (__m128)LODWORD(v136.x);
			//           y_low = (__m128)LODWORD(v136.y);
			//           x_low.m128_f32[0] = v136.x / *(float *)&v26;
			//           y_low.m128_f32[0] = v136.y / *(float *)&v26;
			//           *(_QWORD *)&v136.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//           v136.z = v31 / *(float *)&v26;
			//           *(_QWORD *)&v137.x = v22;
			//           v137.z = v23;
			//           v35 = UnityEngine::Vector3::op_Addition((Vector3 *)&v134, &v137, &v136, v34);
			//           *(_QWORD *)&v137.x = *(_QWORD *)&v35.x;
			//           v37 = v137.x > v135.x
			//              && v137.y > v135.y
			//              && (v36 = v35.z, v36 > z)
			//              && v135.x > (float)-v137.x
			//              && v135.y > (float)-v137.y
			//              && z > (float)-v36;
			//           if ( this.fields.m_inside != v37 )
			//           {
			//             m_CloudMat = this.fields.m_CloudMat;
			//             this.fields.m_inside = v37;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//             LOBYTE(m_WindFieldManager) = this.fields.m_inside;
			//             static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//             if ( !m_CloudMat )
			//               goto LABEL_65;
			//             UnityEngine::Material::SetFloatImpl(
			//               m_CloudMat,
			//               (int32_t)static_fields.monitor,
			//               (float)(2 - ((_BYTE)m_WindFieldManager != 0)),
			//               0LL);
			//             v39 = this.fields.m_CloudMat;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//             static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//             if ( !v39 )
			//               goto LABEL_65;
			//             UnityEngine::Material::SetFloatImpl(
			//               v39,
			//               HIDWORD(static_fields.monitor),
			//               (float)(!this.fields.m_inside ? 4 : 0),
			//               0LL);
			//           }
			//           m_propertyBlock = this.fields.m_propertyBlock;
			//           DensityTextureToUse = this.fields.DensityTextureToUse;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//             m_propertyBlock,
			//             (String *)"_DensityTex",
			//             DensityTextureToUse,
			//             0LL);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//             this.fields.m_propertyBlock,
			//             (String *)"_AdvancedTex",
			//             this.fields.AdvancedTextureToUse,
			//             0LL);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//             this.fields.m_propertyBlock,
			//             (String *)"_WindFieldTex",
			//             this.fields.AdvancedTextureToUse,
			//             0LL);
			//           HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//             this.fields.m_propertyBlock,
			//             (String *)"_SHTex",
			//             this.fields.SHTextureToUse,
			//             0LL);
			//           v42 = this.fields.m_propertyBlock;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//           m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//           if ( v42 )
			//           {
			//             klass = (int32_t)m_WindFieldManager[2].klass;
			//             v44 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m01;
			//             *(_OWORD *)&v138[0].m00 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m00;
			//             v45 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m02;
			//             *(_OWORD *)&v138[0].m01 = v44;
			//             v46 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m03;
			//             *(_OWORD *)&v138[0].m02 = v45;
			//             *(_OWORD *)&v138[0].m03 = v46;
			//             UnityEngine::MaterialPropertyBlock::SetMatrix(v42, klass, v138, 0LL);
			//             m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//             if ( this.fields.m_propertyBlock )
			//             {
			//               klass_high = HIDWORD(m_WindFieldManager[2].klass);
			//               v48 = *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m01;
			//               v49 = this.fields.m_propertyBlock;
			//               *(_OWORD *)&v138[0].m00 = *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m00;
			//               v50 = *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m02;
			//               *(_OWORD *)&v138[0].m01 = v48;
			//               v51 = *(_OWORD *)&this.fields.m_CloudRenderLocalToWorld.m03;
			//               *(_OWORD *)&v138[0].m02 = v50;
			//               *(_OWORD *)&v138[0].m03 = v51;
			//               UnityEngine::MaterialPropertyBlock::SetMatrix(v49, klass_high, v138, 0LL);
			//               *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_VoxelSize.x;
			//               v135.z = this.fields.m_VoxelSize.z;
			//               v53 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v52);
			//               if ( v54 )
			//               {
			//                 v134 = *v53;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(v54, v55, &v134, 0LL);
			//                 *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_InvScale.x;
			//                 v135.z = this.fields.m_InvScale.z;
			//                 v57 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v56);
			//                 if ( v58 )
			//                 {
			//                   v134 = *v57;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(v58, v59, &v134, 0LL);
			//                   m_WindFieldManager = this.fields.m_propertyBlock;
			//                   static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                   if ( m_WindFieldManager )
			//                   {
			//                     UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                       m_WindFieldManager,
			//                       (int32_t)static_fields.fields._.m_CachedPtr,
			//                       this.fields.m_MaxExtent,
			//                       0LL);
			//                     m_WindFieldManager = this.fields.m_propertyBlock;
			//                     static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                     if ( m_WindFieldManager )
			//                     {
			//                       UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                         m_WindFieldManager,
			//                         HIDWORD(static_fields.fields._.m_CachedPtr),
			//                         1.0 / this.fields.m_MaxExtent,
			//                         0LL);
			//                       *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_WindPhase.x;
			//                       v135.z = this.fields.m_WindPhase.z;
			//                       v61 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v60);
			//                       if ( v62 )
			//                       {
			//                         v134 = *v61;
			//                         UnityEngine::MaterialPropertyBlock::SetVector(v62, v63, &v134, 0LL);
			//                         *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_WindPhase2.x;
			//                         v135.z = this.fields.m_WindPhase2.z;
			//                         v65 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v64);
			//                         if ( v66 )
			//                         {
			//                           v134 = *v65;
			//                           UnityEngine::MaterialPropertyBlock::SetVector(v66, v67, &v134, 0LL);
			//                           *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_WindPhase3.x;
			//                           v135.z = this.fields.m_WindPhase3.z;
			//                           v69 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v68);
			//                           if ( v70 )
			//                           {
			//                             v134 = *v69;
			//                             UnityEngine::MaterialPropertyBlock::SetVector(v70, v71, &v134, 0LL);
			//                             static_fields = this.fields.m_CloudMat;
			//                             m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                             if ( static_fields )
			//                             {
			//                               Vector = UnityEngine::Material::GetVector(
			//                                          &v134,
			//                                          static_fields,
			//                                          HIDWORD(m_WindFieldManager[13].klass),
			//                                          0LL);
			//                               static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                               m_WindFieldManager = (MaterialPropertyBlock *)this.fields.m_CloudMat;
			//                               v73 = this.fields.m_propertyBlock;
			//                               v75 = (__m128)_mm_loadu_si128((const __m128i *)Vector);
			//                               v76 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                               MsFalloffRangeRemap = v76._MsFalloffRangeRemap;
			//                               if ( m_WindFieldManager )
			//                               {
			//                                 v78 = _mm_shuffle_ps(v75, v75, 85).m128_f32[0] - v75.m128_f32[0];
			//                                 m_MaxExtent = this.fields.m_MaxExtent;
			//                                 v134.x = (float)(UnityEngine::Material::GetFloatImpl(
			//                                                    (Material *)m_WindFieldManager,
			//                                                    v76._Extinction,
			//                                                    0LL)
			//                                                * m_MaxExtent)
			//                                        / v78;
			//                                 v134.w = _mm_shuffle_ps(v75, v75, 170).m128_f32[0];
			//                                 v134.z = _mm_shuffle_ps(v75, v75, 255).m128_f32[0] - v134.w;
			//                                 v134.y = (float)-v75.m128_f32[0] / v78;
			//                                 if ( v73 )
			//                                 {
			//                                   UnityEngine::MaterialPropertyBlock::SetVector(v73, MsFalloffRangeRemap, &v134, 0LL);
			//                                   m_WindFieldManager = (MaterialPropertyBlock *)this.fields.m_CloudMat;
			//                                   v79 = this.fields.m_MaxExtent;
			//                                   static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                   if ( m_WindFieldManager )
			//                                   {
			//                                     FloatImpl = UnityEngine::Material::GetFloatImpl(
			//                                                   (Material *)m_WindFieldManager,
			//                                                   HIDWORD(static_fields[4].klass),
			//                                                   0LL);
			//                                     m_WindFieldManager = this.fields.m_propertyBlock;
			//                                     v81 = v79 / FloatImpl;
			//                                     static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                     if ( m_WindFieldManager )
			//                                     {
			//                                       UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                         m_WindFieldManager,
			//                                         (int32_t)static_fields[25].klass,
			//                                         v81,
			//                                         0LL);
			//                                       m_WindFieldManager = this.fields.m_propertyBlock;
			//                                       static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                       if ( m_WindFieldManager )
			//                                       {
			//                                         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                           m_WindFieldManager,
			//                                           HIDWORD(static_fields[25].klass),
			//                                           1.0 / v81,
			//                                           0LL);
			//                                         *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_WindOffset.x;
			//                                         v135.z = this.fields.m_WindOffset.z;
			//                                         v83 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v82);
			//                                         if ( v84 )
			//                                         {
			//                                           v134 = *v83;
			//                                           UnityEngine::MaterialPropertyBlock::SetVector(v84, v85, &v134, 0LL);
			//                                           *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_WindOffset2.x;
			//                                           v135.z = this.fields.m_WindOffset2.z;
			//                                           v87 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v86);
			//                                           if ( v88 )
			//                                           {
			//                                             v134 = *v87;
			//                                             UnityEngine::MaterialPropertyBlock::SetVector(v88, v89, &v134, 0LL);
			//                                             *(_QWORD *)&v135.x = *(_QWORD *)&this.fields.m_WindOffset3.x;
			//                                             v135.z = this.fields.m_WindOffset3.z;
			//                                             v91 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, v90);
			//                                             if ( v92 )
			//                                             {
			//                                               v134 = *v91;
			//                                               UnityEngine::MaterialPropertyBlock::SetVector(v92, v93, &v134, 0LL);
			//                                               m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//                                               if ( m_envVolumeCameraComponent )
			//                                               {
			//                                                 updated = HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
			//                                                             (Vector3 *)&v134,
			//                                                             this.fields.m_CloudMat,
			//                                                             m_envVolumeCameraComponent.fields.m_interpolatedPhase,
			//                                                             0LL);
			//                                                 v96 = *(_QWORD *)&updated.x;
			//                                                 z_low = (MethodInfo *)LODWORD(updated.z);
			//                                                 *(_QWORD *)&this.fields.m_MainLightDirection.x = *(_QWORD *)&updated.x;
			//                                                 LODWORD(this.fields.m_MainLightDirection.z) = (_DWORD)z_low;
			//                                                 *(_QWORD *)&v135.x = v96;
			//                                                 LODWORD(v135.z) = (_DWORD)z_low;
			//                                                 v98 = UnityEngine::Vector4::op_Implicit(&v134, (Vector3 *)&v135, z_low);
			//                                                 if ( v99 )
			//                                                 {
			//                                                   v134 = *v98;
			//                                                   UnityEngine::MaterialPropertyBlock::SetVector(v99, v100, &v134, 0LL);
			//                                                   *(_QWORD *)&v135.x = v18;
			//                                                   v135.z = z;
			//                                                   v102 = UnityEngine::Vector4::op_Implicit(
			//                                                            &v134,
			//                                                            (Vector3 *)&v135,
			//                                                            v101);
			//                                                   if ( v103 )
			//                                                   {
			//                                                     v134 = *v102;
			//                                                     UnityEngine::MaterialPropertyBlock::SetVector(
			//                                                       v103,
			//                                                       v104,
			//                                                       &v134,
			//                                                       0LL);
			//                                                     m_WindFieldManager = (MaterialPropertyBlock *)this.fields.m_CloudMat;
			//                                                     static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                                     if ( m_WindFieldManager )
			//                                                     {
			//                                                       UnityEngine::Material::GetInt(
			//                                                         (Material *)m_WindFieldManager,
			//                                                         HIDWORD(static_fields[7].monitor),
			//                                                         0LL);
			//                                                       if ( volumetricParameters )
			//                                                       {
			//                                                         HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                           volumetricParameters.fields.marchStepScale,
			//                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                                         v105 = sub_1826E82D0();
			//                                                         static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                                         v106 = v105;
			//                                                         m_WindFieldManager = this.fields.m_propertyBlock;
			//                                                         if ( m_WindFieldManager )
			//                                                         {
			//                                                           UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                             m_WindFieldManager,
			//                                                             TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._MarchStepNum,
			//                                                             (float)v105,
			//                                                             0LL);
			//                                                           static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                                           m_WindFieldManager = this.fields.m_propertyBlock;
			//                                                           if ( m_WindFieldManager )
			//                                                           {
			//                                                             UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                               m_WindFieldManager,
			//                                                               TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvMarchStepNum,
			//                                                               1.0 / (float)v106,
			//                                                               0LL);
			//                                                             m_WindFieldManager = (MaterialPropertyBlock *)this.fields.m_CloudMat;
			//                                                             static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                                             if ( m_WindFieldManager )
			//                                                             {
			//                                                               UnityEngine::Material::GetInt(
			//                                                                 (Material *)m_WindFieldManager,
			//                                                                 HIDWORD(static_fields[14].monitor),
			//                                                                 0LL);
			//                                                               HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                 volumetricParameters.fields.godRayStepScale,
			//                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                                               v107 = sub_1826E82D0();
			//                                                               static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                                               v108 = v107;
			//                                                               m_WindFieldManager = this.fields.m_propertyBlock;
			//                                                               if ( m_WindFieldManager )
			//                                                               {
			//                                                                 UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                                   m_WindFieldManager,
			//                                                                   TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._GodRayStepNum,
			//                                                                   (float)v107,
			//                                                                   0LL);
			//                                                                 static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                                                 m_WindFieldManager = this.fields.m_propertyBlock;
			//                                                                 if ( m_WindFieldManager )
			//                                                                 {
			//                                                                   v109 = (__m128)COERCE_UNSIGNED_INT((float)v108);
			//                                                                   UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                                     m_WindFieldManager,
			//                                                                     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvGodRayStepNum,
			//                                                                     1.0 / v109.m128_f32[0],
			//                                                                     0LL);
			//                                                                   v110 = this.fields.m_propertyBlock;
			//                                                                   DynamicStepRange = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DynamicStepRange;
			//                                                                   v109.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                                        volumetricParameters.fields.dynamicStepRange,
			//                                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                                                   v112 = v109;
			//                                                                   v12.m128_f32[0] = 1.0
			//                                                                                   / HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                                       volumetricParameters.fields.dynamicStepRange,
			//                                                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                                                   v113 = (Vector4 *)sub_1825A3980(
			//                                                                                       &v134,
			//                                                                                       _mm_unpacklo_ps(v112, v12).m128_u64[0]);
			//                                                                   if ( v110 )
			//                                                                   {
			//                                                                     v134 = *v113;
			//                                                                     UnityEngine::MaterialPropertyBlock::SetVector(
			//                                                                       v110,
			//                                                                       DynamicStepRange,
			//                                                                       &v134,
			//                                                                       0LL);
			//                                                                     v114 = this.fields.m_propertyBlock;
			//                                                                     DynamicStepScale = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._DynamicStepScale;
			//                                                                     v116 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                              volumetricParameters.fields.dynamicStepScale,
			//                                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//                                                                     if ( v114 )
			//                                                                     {
			//                                                                       UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                                         v114,
			//                                                                         DynamicStepScale,
			//                                                                         v116,
			//                                                                         0LL);
			//                                                                       static_fields = this.fields.m_CloudMat;
			//                                                                       m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                                                       if ( static_fields )
			//                                                                       {
			//                                                                         v134 = *UnityEngine::Material::GetVector(
			//                                                                                   &v134,
			//                                                                                   static_fields,
			//                                                                                   HIDWORD(m_WindFieldManager[6].fields.m_Ptr),
			//                                                                                   0LL);
			//                                                                         *(Vector2 *)&v136.x = UnityEngine::Vector4::op_Implicit(
			//                                                                                                 &v134,
			//                                                                                                 v117);
			//                                                                         v118 = (__m128)LODWORD(v136.x);
			//                                                                         v119 = (__m128)LODWORD(v136.y);
			//                                                                         if ( v136.x <= 0.0 )
			//                                                                           v118 = 0LL;
			//                                                                         if ( !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(
			//                                                                                 this,
			//                                                                                 volumetricParameters,
			//                                                                                 0LL)
			//                                                                           && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
			//                                                                                 this,
			//                                                                                 volumetricParameters,
			//                                                                                 0LL)
			//                                                                           && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
			//                                                                                 this,
			//                                                                                 volumetricParameters,
			//                                                                                 0LL) )
			//                                                                         {
			//                                                                           v119 = (__m128)0x461C4000u;
			//                                                                         }
			//                                                                         v120 = this.fields.m_propertyBlock;
			//                                                                         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//                                                                         v121 = this.fields.m_MaxExtent;
			//                                                                         v118.m128_f32[0] = v118.m128_f32[0] / v121;
			//                                                                         v119.m128_f32[0] = v119.m128_f32[0] / v121;
			//                                                                         v122 = (Vector4 *)sub_1825A3980(
			//                                                                                             &v134,
			//                                                                                             _mm_unpacklo_ps(v118, v119).m128_u64[0]);
			//                                                                         if ( v120 )
			//                                                                         {
			//                                                                           v134 = *v122;
			//                                                                           UnityEngine::MaterialPropertyBlock::SetVector(
			//                                                                             v120,
			//                                                                             v123,
			//                                                                             &v134,
			//                                                                             0LL);
			//                                                                           v124 = this.fields.m_propertyBlock;
			//                                                                           WindFieldNum = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WindFieldNum;
			//                                                                           m_WindFieldManager = (MaterialPropertyBlock *)this.fields.m_WindFieldManager;
			//                                                                           if ( m_WindFieldManager )
			//                                                                           {
			//                                                                             v126 = HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldNum(
			//                                                                                      (VolumetricWindFieldManager *)m_WindFieldManager,
			//                                                                                      0LL);
			//                                                                             if ( v124 )
			//                                                                             {
			//                                                                               UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                                                 v124,
			//                                                                                 WindFieldNum,
			//                                                                                 (float)v126,
			//                                                                                 0LL);
			//                                                                               m_WindFieldManager = (MaterialPropertyBlock *)this.fields.m_WindFieldManager;
			//                                                                               if ( m_WindFieldManager )
			//                                                                               {
			//                                                                                 WindFieldBuffer = HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldBuffer(
			//                                                                                                     (VolumetricWindFieldManager *)m_WindFieldManager,
			//                                                                                                     0LL);
			//                                                                                 m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//                                                                                 v128 = WindFieldBuffer;
			//                                                                                 v129 = this.fields.m_propertyBlock;
			//                                                                                 static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                                                                 m_CachedPtr = (int32_t)static_fields[24].fields._.m_CachedPtr;
			//                                                                                 if ( WindFieldBuffer )
			//                                                                                 {
			//                                                                                   count = UnityEngine::ComputeBuffer::get_count(
			//                                                                                             WindFieldBuffer,
			//                                                                                             0LL);
			//                                                                                   stride = UnityEngine::ComputeBuffer::get_stride(
			//                                                                                              v128,
			//                                                                                              0LL);
			//                                                                                   if ( v129 )
			//                                                                                   {
			//                                                                                     UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(
			//                                                                                       v129,
			//                                                                                       m_CachedPtr,
			//                                                                                       v128,
			//                                                                                       0,
			//                                                                                       count * stride,
			//                                                                                       0LL);
			//                                                                                     m_WindFieldManager = this.fields.m_propertyBlock;
			//                                                                                     static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                                                                     if ( m_WindFieldManager )
			//                                                                                     {
			//                                                                                       UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                                                         m_WindFieldManager,
			//                                                                                         (int32_t)static_fields[13].fields._.m_CachedPtr,
			//                                                                                         this.fields.m_OpticalDepthScale,
			//                                                                                         0LL);
			//                                                                                       m_WindFieldManager = this.fields.m_propertyBlock;
			//                                                                                       static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//                                                                                       if ( m_WindFieldManager )
			//                                                                                       {
			//                                                                                         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                                                                           m_WindFieldManager,
			//                                                                                           HIDWORD(static_fields[13].fields._.m_CachedPtr),
			//                                                                                           this.fields.m_InvOpticalDepthScale,
			//                                                                                           0LL);
			//                                                                                         return;
			//                                                                                       }
			//                                                                                     }
			//                                                                                   }
			//                                                                                 }
			//                                                                               }
			//                                                                             }
			//                                                                           }
			//                                                                         }
			//                                                                       }
			//                                                                     }
			//                                                                   }
			//                                                                 }
			//                                                               }
			//                                                             }
			//                                                           }
			//                                                         }
			//                                                       }
			//                                                     }
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
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
			// LABEL_65:
			//     sub_180B536AC(m_WindFieldManager, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4449, 0LL);
			//   if ( !Patch )
			//     goto LABEL_65;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)hgCamera,
			//     (Object *)volumetricParameters,
			//     0LL);
			// }
			// 
		}

		private unsafe void UpdateParametersFromPipelineCPP(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, HGVolumetricCloudDataCB* dataCB)
		{
			// // Void UpdateParametersFromPipelineCPP(HGCamera, HGVolumetricCloudSettingParameters, HGVolumetricCloudDataCB*)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipelineCPP(
			//         VolumetricCloudSDF *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         HGVolumetricCloudDataCB *dataCB,
			//         MethodInfo *method)
			// {
			//   HGCamera *v7; // r13
			//   VolumetricCloudSDF *v8; // rsi
			//   Camera *camera; // r12
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __m128 v12; // xmm9
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   MethodInfo *v16; // r8
			//   Vector3 *v17; // rax
			//   __int64 v18; // xmm10_8
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm8_8
			//   float v22; // edi
			//   MethodInfo *v23; // rdx
			//   Vector3 *one; // rax
			//   __int64 v25; // xmm6_8
			//   float v26; // ebx
			//   float v27; // xmm7_4
			//   MethodInfo *v28; // r9
			//   Vector3 *v29; // rax
			//   float v30; // xmm2_4
			//   __m128 x_low; // xmm0
			//   __m128 y_low; // xmm1
			//   MethodInfo *v33; // r9
			//   Vector3 *v34; // rax
			//   MethodInfo *v35; // r8
			//   float v36; // xmm1_4
			//   bool v37; // al
			//   Material *m_CloudMat; // rbx
			//   Material *v39; // rbx
			//   Object_1 *Tex; // rbx
			//   MaterialPropertyBlock *m_propertyBlock; // rbx
			//   VolumetricEncodedTexture *DensityTextureToUse; // rax
			//   VolumetricEncodedTexture *v43; // rbx
			//   Vector4 v44; // xmm0
			//   Object_1 *v45; // rbx
			//   MaterialPropertyBlock *v46; // rbx
			//   VolumetricEncodedTexture *AdvancedTextureToUse; // rax
			//   VolumetricEncodedTexture *v48; // rbx
			//   Vector4 v49; // xmm0
			//   VolumetricEncodedTexture *v50; // rax
			//   Object_1 *v51; // rbx
			//   MaterialPropertyBlock *v52; // rbx
			//   VolumetricEncodedTexture *SHTextureToUse; // rax
			//   VolumetricEncodedTexture *v54; // rbx
			//   Vector4 v55; // xmm0
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm2
			//   __int128 v58; // xmm3
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm2
			//   __int128 v61; // xmm3
			//   float v62; // eax
			//   float v63; // eax
			//   MethodInfo *v64; // r8
			//   float v65; // eax
			//   MethodInfo *v66; // r8
			//   float v67; // eax
			//   MethodInfo *v68; // r8
			//   float v69; // eax
			//   MethodInfo *v70; // r8
			//   Material *v71; // rbx
			//   Vector4 *Vector; // rax
			//   float m_MaxExtent; // xmm8_4
			//   __m128 v74; // xmm6
			//   float v75; // xmm2_4
			//   float v76; // xmm6_4
			//   float v77; // xmm6_4
			//   float v78; // eax
			//   MethodInfo *v79; // r8
			//   float v80; // eax
			//   MethodInfo *v81; // r8
			//   float v82; // eax
			//   MethodInfo *v83; // r8
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rbx
			//   Material *v85; // rdi
			//   HGEnvironmentPhase *m_interpolatedPhase; // rbx
			//   Vector3 *updated; // rax
			//   float v88; // ecx
			//   __int64 v89; // xmm1_8
			//   MethodInfo *v90; // r8
			//   Vector4 *v91; // rax
			//   MethodInfo *v92; // r8
			//   int32_t v93; // eax
			//   int32_t v94; // eax
			//   __m128 v95; // xmm0
			//   __m128 v96; // xmm6
			//   MethodInfo *v97; // rdx
			//   __m128 v98; // xmm6
			//   __m128 v99; // xmm7
			//   float v100; // xmm0_4
			//   ComputeBuffer *WindFieldBuffer; // rbx
			//   MaterialPropertyBlock *v102; // rdi
			//   float m21; // r12d
			//   int32_t count; // r15d
			//   int32_t stride; // eax
			//   Vector4 v106; // [rsp+38h] [rbp-A1h] BYREF
			//   Vector4 v107; // [rsp+48h] [rbp-91h] BYREF
			//   Vector3 v108; // [rsp+58h] [rbp-81h] BYREF
			//   Vector3 v109; // [rsp+68h] [rbp-71h] BYREF
			//   Matrix4x4 v110; // [rsp+78h] [rbp-61h] BYREF
			//   float z; // [rsp+140h] [rbp+67h]
			//   Vector2 v112; // [rsp+140h] [rbp+67h]
			// 
			//   v7 = hgCamera;
			//   v8 = this;
			//   if ( !byte_18D919792 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     byte_18D919792 = 1;
			//   }
			//   if ( !v7 )
			//     goto LABEL_57;
			//   camera = v7.fields.camera;
			//   if ( !camera )
			//     goto LABEL_57;
			//   transform = UnityEngine::Component::get_transform((Component *)v7.fields.camera, 0LL);
			//   if ( !transform )
			//     goto LABEL_57;
			//   position = UnityEngine::Transform::get_position((Vector3 *)&v107, transform, 0LL);
			//   v12 = (__m128)0x3F800000u;
			//   v106.w = 1.0;
			//   *(_QWORD *)&v108.x = *(_QWORD *)&position.x;
			//   *(_QWORD *)&v106.x = *(_QWORD *)&v108.x;
			//   v106.z = position.z;
			//   v13 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m01;
			//   *(_OWORD *)&v110.m00 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m00;
			//   v14 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m02;
			//   *(_OWORD *)&v110.m01 = v13;
			//   v15 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m03;
			//   *(_OWORD *)&v110.m02 = v14;
			//   *(_OWORD *)&v110.m03 = v15;
			//   v106 = *UnityEngine::Matrix4x4::op_Multiply(&v107, &v110, &v106, 0LL);
			//   v17 = UnityEngine::Vector4::op_Implicit(&v109, &v106, v16);
			//   *(_QWORD *)&v108.x = *(_QWORD *)&v8.fields.m_VoxelSize.x;
			//   v18 = *(_QWORD *)&v17.x;
			//   z = v17.z;
			//   v108.z = v8.fields.m_VoxelSize.z;
			//   *(_QWORD *)&v107.x = v18;
			//   v20 = UnityEngine::Vector3::op_Multiply(&v109, &v108, 0.5, v19);
			//   v21 = *(_QWORD *)&v20.x;
			//   v22 = v20.z;
			//   one = UnityEngine::Vector3::get_one(&v109, v23);
			//   v25 = *(_QWORD *)&one.x;
			//   v26 = one.z;
			//   v27 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//   sub_180002C70(TypeInfo::System::Math);
			//   *(_QWORD *)&v108.x = v25;
			//   *(float *)&v25 = v8.fields.m_MaxExtent;
			//   v108.z = v26;
			//   *(float *)&v15 = System::Math::Max(v27, 1.0, 0LL);
			//   v29 = UnityEngine::Vector3::op_Multiply(&v109, &v108, *(float *)&v15, v28);
			//   v30 = v29.z;
			//   *(_QWORD *)&v108.x = *(_QWORD *)&v29.x;
			//   x_low = (__m128)LODWORD(v108.x);
			//   y_low = (__m128)LODWORD(v108.y);
			//   x_low.m128_f32[0] = v108.x / *(float *)&v25;
			//   y_low.m128_f32[0] = v108.y / *(float *)&v25;
			//   *(_QWORD *)&v108.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//   v108.z = v30 / *(float *)&v25;
			//   *(_QWORD *)&v109.x = v21;
			//   v109.z = v22;
			//   v34 = UnityEngine::Vector3::op_Addition((Vector3 *)&v106, &v109, &v108, v33);
			//   *(_QWORD *)&v109.x = *(_QWORD *)&v34.x;
			//   v37 = v109.x > v107.x
			//      && v109.y > v107.y
			//      && (v36 = v34.z, v36 > z)
			//      && v107.x > (float)-v109.x
			//      && v107.y > (float)-v109.y
			//      && z > (float)-v36;
			//   if ( v8.fields.m_inside != v37 )
			//   {
			//     m_CloudMat = v8.fields.m_CloudMat;
			//     v8.fields.m_inside = v37;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     LOBYTE(this) = v8.fields.m_inside;
			//     hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !m_CloudMat )
			//       goto LABEL_57;
			//     UnityEngine::Material::SetFloatImpl(m_CloudMat, (int32_t)hgCamera.monitor, (float)(2 - ((_BYTE)this != 0)), 0LL);
			//     v39 = v8.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//     if ( !v39 )
			//       goto LABEL_57;
			//     UnityEngine::Material::SetFloatImpl(v39, HIDWORD(hgCamera.monitor), (float)(!v8.fields.m_inside ? 4 : 0), 0LL);
			//   }
			//   if ( v8.fields.DensityTextureToUse )
			//   {
			//     Tex = (Object_1 *)v8.fields.DensityTextureToUse.fields.Tex;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(Tex, 0LL) )
			//     {
			//       m_propertyBlock = v8.fields.m_propertyBlock;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       DensityTextureToUse = v8.fields.DensityTextureToUse;
			//       if ( !DensityTextureToUse )
			//         goto LABEL_57;
			//       if ( !m_propertyBlock )
			//         goto LABEL_57;
			//       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//         m_propertyBlock,
			//         LODWORD(hgCamera.fields.mainViewConstants.viewNoTransProjMatrix.m02),
			//         DensityTextureToUse.fields.Tex,
			//         0LL);
			//       v43 = v8.fields.DensityTextureToUse;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v44 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
			//                                                         &v106,
			//                                                         v43,
			//                                                         0LL));
			//       if ( !dataCB )
			//         goto LABEL_57;
			//       dataCB._DensityTex_RemapRangeBase = v44;
			//       dataCB._DensityTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
			//                                                                                         &v106,
			//                                                                                         v8.fields.DensityTextureToUse,
			//                                                                                         0LL));
			//     }
			//   }
			//   if ( v8.fields.AdvancedTextureToUse )
			//   {
			//     v45 = (Object_1 *)v8.fields.AdvancedTextureToUse.fields.Tex;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(v45, 0LL) )
			//     {
			//       v46 = v8.fields.m_propertyBlock;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       AdvancedTextureToUse = v8.fields.AdvancedTextureToUse;
			//       if ( !AdvancedTextureToUse )
			//         goto LABEL_57;
			//       if ( !v46 )
			//         goto LABEL_57;
			//       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//         v46,
			//         LODWORD(hgCamera.fields.mainViewConstants.viewNoTransProjMatrix.m12),
			//         AdvancedTextureToUse.fields.Tex,
			//         0LL);
			//       v48 = v8.fields.AdvancedTextureToUse;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v49 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
			//                                                         &v106,
			//                                                         v48,
			//                                                         0LL));
			//       if ( !dataCB )
			//         goto LABEL_57;
			//       dataCB._AdvancedTex_RemapRangeBase = v49;
			//       dataCB._AdvancedTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
			//                                                                                          &v106,
			//                                                                                          v8.fields.AdvancedTextureToUse,
			//                                                                                          0LL));
			//       this = (VolumetricCloudSDF *)v8.fields.m_propertyBlock;
			//       hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       v50 = v8.fields.AdvancedTextureToUse;
			//       if ( !v50 || !this )
			//         goto LABEL_57;
			//       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//         (MaterialPropertyBlock *)this,
			//         LODWORD(hgCamera.fields.mainViewConstants.invViewProjMatrix.m31),
			//         v50.fields.Tex,
			//         0LL);
			//       dataCB._WindFieldTex_RemapRangeBase = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
			//                                                                                          &v106,
			//                                                                                          v8.fields.AdvancedTextureToUse,
			//                                                                                          0LL));
			//       dataCB._WindFieldTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
			//                                                                                           &v106,
			//                                                                                           v8.fields.AdvancedTextureToUse,
			//                                                                                           0LL));
			//     }
			//   }
			//   if ( v8.fields.SHTextureToUse )
			//   {
			//     v51 = (Object_1 *)v8.fields.SHTextureToUse.fields.Tex;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(v51, 0LL) )
			//     {
			//       v52 = v8.fields.m_propertyBlock;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//       hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//       SHTextureToUse = v8.fields.SHTextureToUse;
			//       if ( !SHTextureToUse )
			//         goto LABEL_57;
			//       if ( !v52 )
			//         goto LABEL_57;
			//       UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
			//         v52,
			//         LODWORD(hgCamera.fields.mainViewConstants.viewNoTransProjMatrix.m22),
			//         SHTextureToUse.fields.Tex,
			//         0LL);
			//       v54 = v8.fields.SHTextureToUse;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v55 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
			//                                                         &v106,
			//                                                         v54,
			//                                                         0LL));
			//       if ( !dataCB )
			//         goto LABEL_57;
			//       dataCB._SHTex_RemapRangeBase = v55;
			//       dataCB._SHTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
			//                                                                                    &v106,
			//                                                                                    v8.fields.SHTextureToUse,
			//                                                                                    0LL));
			//     }
			//   }
			//   v56 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m01;
			//   v57 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m02;
			//   v58 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m03;
			//   if ( !dataCB )
			//     goto LABEL_57;
			//   *(_OWORD *)&dataCB._BoxWorldToLocal.m00 = *(_OWORD *)&v8.fields.m_CloudRenderWorldToLocal.m00;
			//   *(_OWORD *)&dataCB._BoxWorldToLocal.m01 = v56;
			//   *(_OWORD *)&dataCB._BoxWorldToLocal.m02 = v57;
			//   *(_OWORD *)&dataCB._BoxWorldToLocal.m03 = v58;
			//   v59 = *(_OWORD *)&v8.fields.m_CloudRenderLocalToWorld.m01;
			//   v60 = *(_OWORD *)&v8.fields.m_CloudRenderLocalToWorld.m02;
			//   v61 = *(_OWORD *)&v8.fields.m_CloudRenderLocalToWorld.m03;
			//   *(_OWORD *)&dataCB._BoxLocalToWorld.m00 = *(_OWORD *)&v8.fields.m_CloudRenderLocalToWorld.m00;
			//   *(_OWORD *)&dataCB._BoxLocalToWorld.m01 = v59;
			//   *(_OWORD *)&dataCB._BoxLocalToWorld.m02 = v60;
			//   *(_OWORD *)&dataCB._BoxLocalToWorld.m03 = v61;
			//   v62 = v8.fields.m_VoxelSize.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_VoxelSize.x;
			//   v107.z = v62;
			//   dataCB._VoxelSize = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                    &v106,
			//                                                                    (Vector3 *)&v107,
			//                                                                    v35));
			//   v63 = v8.fields.m_InvScale.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_InvScale.x;
			//   v107.z = v63;
			//   dataCB._InvScale = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                   &v106,
			//                                                                   (Vector3 *)&v107,
			//                                                                   v64));
			//   dataCB._GlobalScale = v8.fields.m_MaxExtent;
			//   dataCB._InvGlobalScale = 1.0 / v8.fields.m_MaxExtent;
			//   v65 = v8.fields.m_WindPhase.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_WindPhase.x;
			//   v107.z = v65;
			//   dataCB._WindPhase = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                    &v106,
			//                                                                    (Vector3 *)&v107,
			//                                                                    v66));
			//   v67 = v8.fields.m_WindPhase2.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_WindPhase2.x;
			//   v107.z = v67;
			//   dataCB._WindPhase2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                     &v106,
			//                                                                     (Vector3 *)&v107,
			//                                                                     v68));
			//   v69 = v8.fields.m_WindPhase3.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_WindPhase3.x;
			//   v107.z = v69;
			//   dataCB._WindPhase3 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                     &v106,
			//                                                                     (Vector3 *)&v107,
			//                                                                     v70));
			//   v71 = v8.fields.m_CloudMat;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   this = (VolumetricCloudSDF *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !v71 )
			//     goto LABEL_57;
			//   Vector = UnityEngine::Material::GetVector(&v106, v71, LODWORD(this.fields.m_CloudRenderLocalToWorld.m10), 0LL);
			//   this = (VolumetricCloudSDF *)v8.fields.m_CloudMat;
			//   v74 = (__m128)_mm_loadu_si128((const __m128i *)Vector);
			//   hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !this )
			//     goto LABEL_57;
			//   v75 = _mm_shuffle_ps(v74, v74, 85).m128_f32[0] - v74.m128_f32[0];
			//   m_MaxExtent = v8.fields.m_MaxExtent;
			//   v106.x = (float)(UnityEngine::Material::GetFloatImpl(
			//                      (Material *)this,
			//                      LODWORD(hgCamera.fields.mainViewConstants.viewMatrix.m31),
			//                      0LL)
			//                  * m_MaxExtent)
			//          / v75;
			//   v106.w = _mm_shuffle_ps(v74, v74, 170).m128_f32[0];
			//   v106.y = COERCE_FLOAT(v74.m128_i32[0] ^ 0x80000000) / v75;
			//   v106.z = _mm_shuffle_ps(v74, v74, 255).m128_f32[0] - v106.w;
			//   dataCB._MsFalloffRangeRemap = v106;
			//   this = (VolumetricCloudSDF *)v8.fields.m_CloudMat;
			//   hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !this )
			//     goto LABEL_57;
			//   v76 = v8.fields.m_MaxExtent;
			//   v77 = v76 / UnityEngine::Material::GetFloatImpl((Material *)this, HIDWORD(hgCamera.fields.camera), 0LL);
			//   dataCB._WindOffsetScale = v77;
			//   dataCB._InvWindOffsetScale = 1.0 / v77;
			//   v78 = v8.fields.m_WindOffset.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_WindOffset.x;
			//   v107.z = v78;
			//   dataCB._WindOffset = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                     &v106,
			//                                                                     (Vector3 *)&v107,
			//                                                                     v79));
			//   v80 = v8.fields.m_WindOffset2.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_WindOffset2.x;
			//   v107.z = v80;
			//   dataCB._WindOffset2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                      &v106,
			//                                                                      (Vector3 *)&v107,
			//                                                                      v81));
			//   v82 = v8.fields.m_WindOffset3.z;
			//   *(_QWORD *)&v107.x = *(_QWORD *)&v8.fields.m_WindOffset3.x;
			//   v107.z = v82;
			//   dataCB._WindOffset3 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                      &v106,
			//                                                                      (Vector3 *)&v107,
			//                                                                      v83));
			//   m_envVolumeCameraComponent = v7.fields.m_envVolumeCameraComponent;
			//   v85 = v8.fields.m_CloudMat;
			//   if ( !m_envVolumeCameraComponent )
			//     goto LABEL_57;
			//   m_interpolatedPhase = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//   updated = HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
			//               (Vector3 *)&v106,
			//               v85,
			//               m_interpolatedPhase,
			//               0LL);
			//   v88 = updated.z;
			//   v89 = *(_QWORD *)&updated.x;
			//   *(_QWORD *)&v8.fields.m_MainLightDirection.x = *(_QWORD *)&updated.x;
			//   v8.fields.m_MainLightDirection.z = v88;
			//   v107.z = v88;
			//   *(_QWORD *)&v107.x = v89;
			//   v91 = UnityEngine::Vector4::op_Implicit(&v106, (Vector3 *)&v107, v90);
			//   *(_QWORD *)&v107.x = v18;
			//   v107.z = z;
			//   dataCB._MainLightDirection = (Vector4)_mm_loadu_si128((const __m128i *)v91);
			//   dataCB._LocalRayOrigin = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
			//                                                                         &v106,
			//                                                                         (Vector3 *)&v107,
			//                                                                         v92));
			//   this = (VolumetricCloudSDF *)v8.fields.m_CloudMat;
			//   hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !this )
			//     goto LABEL_57;
			//   UnityEngine::Material::GetInt((Material *)this, LODWORD(hgCamera.fields.mainViewConstants.viewMatrix.m33), 0LL);
			//   if ( !volumetricParameters )
			//     goto LABEL_57;
			//   HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//     volumetricParameters.fields.marchStepScale,
			//     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v93 = sub_1826E82D0();
			//   dataCB._MarchStepNum = v93;
			//   dataCB._InvMarchStepNum = 1.0 / (float)v93;
			//   this = (VolumetricCloudSDF *)v8.fields.m_CloudMat;
			//   hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !this )
			//     goto LABEL_57;
			//   UnityEngine::Material::GetInt(
			//     (Material *)this,
			//     LODWORD(hgCamera.fields.mainViewConstants.nonJitteredProjMatrix.m12),
			//     0LL);
			//   HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//     volumetricParameters.fields.godRayStepScale,
			//     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v94 = sub_1826E82D0();
			//   dataCB._GodRayStepNum = v94;
			//   v95 = (__m128)COERCE_UNSIGNED_INT((float)v94);
			//   dataCB._InvGodRayStepNum = 1.0 / v95.m128_f32[0];
			//   v95.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                       volumetricParameters.fields.dynamicStepRange,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v96 = v95;
			//   v12.m128_f32[0] = 1.0
			//                   / HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                       volumetricParameters.fields.dynamicStepRange,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   dataCB._DynamicStepRange = (Vector4)_mm_loadu_si128((const __m128i *)sub_1825A3980(
			//                                                                           &v106,
			//                                                                           _mm_unpacklo_ps(v96, v12).m128_u64[0]));
			//   dataCB._DynamicStepScale = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                 volumetricParameters.fields.dynamicStepScale,
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   hgCamera = (HGCamera *)v8.fields.m_CloudMat;
			//   this = (VolumetricCloudSDF *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   if ( !hgCamera )
			//     goto LABEL_57;
			//   v106 = *UnityEngine::Material::GetVector(&v106, (Material *)hgCamera, LODWORD(this.fields.m_WindOffset3.z), 0LL);
			//   v112 = UnityEngine::Vector4::op_Implicit(&v106, v97);
			//   v98 = (__m128)LODWORD(v112.x);
			//   v99 = (__m128)LODWORD(v112.y);
			//   if ( v112.x <= 0.0 )
			//     v98 = 0LL;
			//   if ( !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(v8, volumetricParameters, 0LL)
			//     && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(v8, volumetricParameters, 0LL)
			//     && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(v8, volumetricParameters, 0LL) )
			//   {
			//     v99 = (__m128)0x461C4000u;
			//   }
			//   v100 = v8.fields.m_MaxExtent;
			//   v98.m128_f32[0] = v98.m128_f32[0] / v100;
			//   v99.m128_f32[0] = v99.m128_f32[0] / v100;
			//   dataCB._MarchRangeLocal = (Vector4)_mm_loadu_si128((const __m128i *)sub_1825A3980(
			//                                                                          &v106,
			//                                                                          _mm_unpacklo_ps(v98, v99).m128_u64[0]));
			//   this = (VolumetricCloudSDF *)v8.fields.m_WindFieldManager;
			//   if ( !this )
			//     goto LABEL_57;
			//   dataCB._WindFieldNum = HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldNum(
			//                             (VolumetricWindFieldManager *)this,
			//                             0LL);
			//   this = (VolumetricCloudSDF *)v8.fields.m_WindFieldManager;
			//   if ( !this )
			//     goto LABEL_57;
			//   WindFieldBuffer = HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldBuffer(
			//                       (VolumetricWindFieldManager *)this,
			//                       0LL);
			//   v102 = v8.fields.m_propertyBlock;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//   this = (VolumetricCloudSDF *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//   hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//   m21 = hgCamera.fields.mainViewConstants.invViewProjMatrix.m21;
			//   if ( !WindFieldBuffer
			//     || (count = UnityEngine::ComputeBuffer::get_count(WindFieldBuffer, 0LL),
			//         stride = UnityEngine::ComputeBuffer::get_stride(WindFieldBuffer, 0LL),
			//         !v102) )
			//   {
			// LABEL_57:
			//     sub_180B536AC(this, hgCamera);
			//   }
			//   UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(
			//     v102,
			//     SLODWORD(m21),
			//     WindFieldBuffer,
			//     0,
			//     count * stride,
			//     0LL);
			//   dataCB._OpticalDepthScale = v8.fields.m_OpticalDepthScale;
			//   dataCB._InvOpticalDepthScale = v8.fields.m_InvOpticalDepthScale;
			// }
			// 
		}

		protected override void CollectVolumetricRenderItemsImpl(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items)
		{
			// // Void CollectVolumetricRenderItemsImpl(HGCamera, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricCloudSDF::CollectVolumetricRenderItemsImpl(
			//         VolumetricCloudSDF *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *items,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rax
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   GameObject *m_CloudObject; // rcx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   __int64 v14; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   Object_1 *m_CloudMat; // rbx
			//   Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v19; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   Mesh *CubeMesh; // rax
			//   Mesh *v25; // rbx
			//   Transform *transform; // rax
			//   Material *v27; // rsi
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *CollectVolumetricRenderCallback; // rbx
			//   int32_t renderQueue; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *P3b; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *P3a; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v34; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v35; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v36; // [rsp+28h] [rbp-D8h]
			//   VolumetricRenderer_VolumetricBounds v37; // [rsp+70h] [rbp-90h] BYREF
			//   VolumetricRenderer_VolumetricBounds v38; // [rsp+90h] [rbp-70h] BYREF
			//   VolumetricRenderer_VolumetricRenderItem v39; // [rsp+B0h] [rbp-50h] BYREF
			//   VolumetricRenderer_VolumetricRenderItem v40; // [rsp+110h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D919793 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Add);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass97_0::_CollectVolumetricRenderItemsImpl_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass97_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919793 = 1;
			//   }
			//   *(_WORD *)(&v37.enableBounds + 1) = 0;
			//   *(&v37.enableBounds + 3) = 0;
			//   sub_1802F01E0(&v39, 0LL, 88LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(4455, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4455, 0LL);
			//     if ( !Patch )
			//       goto LABEL_19;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)volumetricParameters,
			//       (Object *)items,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = sub_180004920(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass97_0);
			//     v14 = v9;
			//     if ( !v9 )
			//       goto LABEL_19;
			//     *(_QWORD *)(v9 + 16) = this;
			//     sub_1800054D0((HGRenderPathScene *)(v9 + 16), v10, v12, v13, P3, v34);
			//     *(_QWORD *)(v14 + 24) = volumetricParameters;
			//     sub_1800054D0((HGRenderPathScene *)(v14 + 24), v15, v16, v17, P3b, v35);
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL)
			//       && HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(this, hgCamera, 0LL)
			//       && this.fields.m_MaxExtent != 0.0 )
			//     {
			//       HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipeline(
			//         this,
			//         hgCamera,
			//         *(HGVolumetricCloudSettingParameters **)(v14 + 24),
			//         0LL);
			//       if ( !this.fields._._CollectVolumetricRenderCallback )
			//       {
			//         v19 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_180004920(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
			//         v20 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v19;
			//         if ( !v19 )
			//           goto LABEL_19;
			//         System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
			//           v19,
			//           (Object *)v14,
			//           MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass97_0::_CollectVolumetricRenderItemsImpl_b__0,
			//           0LL);
			//         this.fields._._CollectVolumetricRenderCallback = v20;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields._._CollectVolumetricRenderCallback, v21, v22, v23, P3a, v36);
			//       }
			//       if ( !this.fields.m_DrawNear )
			//         return;
			//       v37.enableBounds = 0;
			//       *(_QWORD *)&v38.worldBounds.m_Extents.x = 0LL;
			//       memset(&v37.worldBounds, 0, sizeof(v37.worldBounds));
			//       if ( !this.fields.m_inside )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         CubeMesh = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
			//         m_CloudObject = this.fields.m_CloudObject;
			//         v25 = CubeMesh;
			//         if ( !m_CloudObject )
			//           goto LABEL_19;
			//         transform = UnityEngine::GameObject::get_transform(m_CloudObject, 0LL);
			//         v37.enableBounds = 1;
			//         v37.worldBounds = *HG::Rendering::Runtime::VolumetricSDFUtils::CalculateBounds(
			//                              (Bounds *)&v38,
			//                              v25,
			//                              transform,
			//                              0LL);
			//       }
			//       v27 = this.fields.m_CloudMat;
			//       CollectVolumetricRenderCallback = this.fields._._CollectVolumetricRenderCallback;
			//       m_CloudObject = (GameObject *)v27;
			//       if ( v27 )
			//       {
			//         renderQueue = UnityEngine::Material::get_renderQueue(v27, 0LL);
			//         v38 = v37;
			//         HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
			//           &v39,
			//           CollectVolumetricRenderCallback,
			//           &v38,
			//           v27,
			//           1,
			//           1,
			//           0,
			//           renderQueue,
			//           99999.0,
			//           0,
			//           1,
			//           0,
			//           0LL);
			//         v39.bFullScreen = this.fields.m_inside;
			//         if ( items )
			//         {
			//           v40 = v39;
			//           sub_180607108(
			//             items,
			//             &v40,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Add);
			//           return;
			//         }
			//       }
			// LABEL_19:
			//       sub_180B536AC(m_CloudObject, v10);
			//     }
			//   }
			// }
			// 
		}

		protected override void CollectVolumetricRenderItemsCPPImpl(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems)
		{
			// // Void CollectVolumetricRenderItemsCPPImpl(HGCamera, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricCloudSDF::CollectVolumetricRenderItemsCPPImpl(
			//         VolumetricCloudSDF *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *renderItems,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_CloudMat; // rbx
			//   Void *TempFromCSharp; // r12
			//   bool IsFadeInFromCamera; // si
			//   int32_t InstanceID; // eax
			//   Object_1 *v13; // rbx
			//   __int64 v14; // rdx
			//   GameObject *m_CloudObject; // rcx
			//   Material *v16; // rax
			//   void *m_CachedPtr; // rcx
			//   Object_1 *CubeMesh; // rbx
			//   Mesh *v19; // rax
			//   void *v20; // rax
			//   Transform *transform; // rax
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   MaterialPropertyBlock *m_propertyBlock; // rax
			//   __int128 v27; // xmm0
			//   int v28; // eax
			//   Mesh *v29; // rax
			//   Mesh *v30; // rbx
			//   Transform *v31; // rax
			//   int32_t renderQueue; // eax
			//   float m_OpticalDepthScale; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v35[28]; // [rsp+40h] [rbp-C8h]
			//   __int128 v36; // [rsp+68h] [rbp-A0h] BYREF
			//   __int128 v37; // [rsp+78h] [rbp-90h]
			//   __int128 v38; // [rsp+88h] [rbp-80h]
			//   __int128 v39; // [rsp+98h] [rbp-70h]
			//   __int128 v40; // [rsp+A8h] [rbp-60h]
			//   __int128 v41; // [rsp+B8h] [rbp-50h]
			//   __m256i v42; // [rsp+C8h] [rbp-40h]
			//   __int128 v43; // [rsp+E8h] [rbp-20h]
			//   __m256i v44; // [rsp+F8h] [rbp-10h]
			//   __int128 v45; // [rsp+118h] [rbp+10h]
			//   __int128 v46; // [rsp+128h] [rbp+20h]
			//   Bounds v47; // [rsp+138h] [rbp+30h] BYREF
			//   Matrix4x4 v48; // [rsp+150h] [rbp+48h] BYREF
			//   _OWORD v49[6]; // [rsp+198h] [rbp+90h] BYREF
			//   __m256i v50; // [rsp+1F8h] [rbp+F0h]
			//   __int128 v51; // [rsp+218h] [rbp+110h]
			//   __m256i v52; // [rsp+228h] [rbp+120h]
			//   __int128 v53; // [rsp+248h] [rbp+140h]
			//   __int128 v54; // [rsp+258h] [rbp+150h]
			// 
			//   if ( !byte_18D919794 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::Add);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919794 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4460, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4460, 0LL);
			//     if ( !Patch )
			//       goto LABEL_26;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (Object *)volumetricParameters,
			//       (Object *)renderItems,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL)
			//       && HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(this, hgCamera, 0LL)
			//       && this.fields.m_MaxExtent != 0.0 )
			//     {
			//       TempFromCSharp = (Void *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(1008LL, 0LL);
			//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemSet(TempFromCSharp, 0, 1008LL, 0LL);
			//       HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipelineCPP(
			//         this,
			//         hgCamera,
			//         volumetricParameters,
			//         (HGVolumetricCloudDataCB *)TempFromCSharp,
			//         0LL);
			//       IsFadeInFromCamera = HG::Rendering::Runtime::VolumetricCloudSDF::IsFadeInFromCamera(this, hgCamera, 0LL);
			//       if ( this.fields.m_DrawNear )
			//       {
			//         sub_1802F01E0(&v36, 0LL, 208LL);
			//         InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
			//         v13 = (Object_1 *)this.fields.m_CloudMat;
			//         LODWORD(v36) = InstanceID;
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Implicit(v13, 0LL) )
			//         {
			//           v16 = this.fields.m_CloudMat;
			//           if ( !v16 )
			//             goto LABEL_26;
			//           m_CachedPtr = v16.fields._.m_CachedPtr;
			//         }
			//         else
			//         {
			//           m_CachedPtr = 0LL;
			//         }
			//         *(_QWORD *)&v37 = 0LL;
			//         *((_QWORD *)&v36 + 1) = m_CachedPtr;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         CubeMesh = (Object_1 *)HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Implicit(CubeMesh, 0LL) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//           v19 = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
			//           if ( !v19 )
			//             goto LABEL_26;
			//           v20 = v19.fields._.m_CachedPtr;
			//         }
			//         else
			//         {
			//           v20 = 0LL;
			//         }
			//         m_CloudObject = this.fields.m_CloudObject;
			//         *((_QWORD *)&v37 + 1) = v20;
			//         if ( m_CloudObject )
			//         {
			//           transform = UnityEngine::GameObject::get_transform(m_CloudObject, 0LL);
			//           if ( transform )
			//           {
			//             localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v48, transform, 0LL);
			//             v23 = *(_OWORD *)&localToWorldMatrix.m01;
			//             v38 = *(_OWORD *)&localToWorldMatrix.m00;
			//             v24 = *(_OWORD *)&localToWorldMatrix.m02;
			//             v39 = v23;
			//             v25 = *(_OWORD *)&localToWorldMatrix.m03;
			//             m_propertyBlock = this.fields.m_propertyBlock;
			//             v40 = v24;
			//             v41 = v25;
			//             if ( m_propertyBlock )
			//             {
			//               v27 = 0LL;
			//               v42.m256i_i64[0] = (__int64)m_propertyBlock.fields.m_Ptr;
			//               v28 = 0;
			//               *(_DWORD *)v35 = 0;
			//               *(_QWORD *)&v35[16] = 0LL;
			//               if ( !this.fields.m_inside )
			//               {
			//                 v35[0] = 1;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//                 v29 = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
			//                 m_CloudObject = this.fields.m_CloudObject;
			//                 v30 = v29;
			//                 if ( !m_CloudObject )
			//                   goto LABEL_26;
			//                 v31 = UnityEngine::GameObject::get_transform(m_CloudObject, 0LL);
			//                 *(Bounds *)&v35[4] = *HG::Rendering::Runtime::VolumetricSDFUtils::CalculateBounds(&v47, v30, v31, 0LL);
			//                 v27 = *(_OWORD *)v35;
			//                 v28 = *(_DWORD *)&v35[24];
			//               }
			//               DWORD2(v43) = 0;
			//               m_CloudObject = (GameObject *)this.fields.m_CloudMat;
			//               LODWORD(v43) = v28;
			//               WORD2(v43) = 257;
			//               *(_OWORD *)&v42.m256i_u64[1] = v27;
			//               v42.m256i_i64[3] = *(_QWORD *)&v35[16];
			//               if ( m_CloudObject )
			//               {
			//                 renderQueue = UnityEngine::Material::get_renderQueue((Material *)m_CloudObject, 0LL);
			//                 m_OpticalDepthScale = this.fields.m_OpticalDepthScale;
			//                 HIDWORD(v43) = renderQueue;
			//                 v44.m256i_i8[9] = this.fields.m_inside;
			//                 *(__int64 *)((char *)&v44.m256i_i64[1] + 4) = *(_QWORD *)&this.fields.m_msBakeSizeX;
			//                 v44.m256i_i8[24] = this.fields.m_DrawFar;
			//                 *(float *)&v44.m256i_i32[5] = m_OpticalDepthScale;
			//                 v44.m256i_i64[0] = 1203982208LL;
			//                 v44.m256i_i8[8] = 1;
			//                 v44.m256i_i8[25] = IsFadeInFromCamera;
			//                 *(_QWORD *)&v45 = TempFromCSharp;
			//                 if ( renderItems )
			//                 {
			//                   v49[0] = v36;
			//                   v49[1] = v37;
			//                   v49[2] = v38;
			//                   v49[3] = v39;
			//                   v49[4] = v40;
			//                   v49[5] = v41;
			//                   v50 = v42;
			//                   v51 = v43;
			//                   v52 = v44;
			//                   v53 = v45;
			//                   v54 = v46;
			//                   sub_180607224(
			//                     renderItems,
			//                     v49,
			//                     MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::Add);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			// LABEL_26:
			//         sub_180B536AC(m_CloudObject, v14);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public override void OnUpdateVolumetricMaterial(CommandBuffer cmd, Material material, MaterialPropertyBlock propertyBlock)
		{
			// // Void OnUpdateVolumetricMaterial(CommandBuffer, Material, MaterialPropertyBlock)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::OnUpdateVolumetricMaterial(
			//         VolumetricCloudSDF *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MaterialPropertyBlock *propertyBlock,
			//         MethodInfo *method)
			// {
			//   Object_1 *m_CloudMat; // rbx
			//   Material *v10; // rbx
			//   VolumetricWindFieldManager *m_WindFieldManager; // rcx
			//   void *static_fields; // rdx
			//   Material *v13; // rbx
			//   MethodInfo *v14; // r8
			//   Vector4 *v15; // rax
			//   int32_t v16; // r10d
			//   int32_t WindLerpDistance; // ebx
			//   Vector4 *Vector; // rax
			//   MethodInfo *v19; // r8
			//   int32_t v20; // r10d
			//   MethodInfo *v21; // r8
			//   int32_t v22; // r10d
			//   MethodInfo *v23; // r8
			//   float m_MaxExtent; // xmm6_4
			//   Material *v25; // rbx
			//   float v26; // xmm6_4
			//   MethodInfo *v27; // r8
			//   int32_t v28; // r10d
			//   __int128 v29; // xmm1
			//   VolumetricShaderIDs__StaticFields *v30; // rcx
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   int32_t BoxWorldToLocal; // edx
			//   int32_t WindFieldNum; // ebx
			//   int32_t v35; // eax
			//   ComputeBuffer *WindFieldBuffer; // rax
			//   ComputeBuffer *v37; // rdi
			//   int32_t v38; // r14d
			//   int32_t count; // ebx
			//   int32_t stride; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v42; // [rsp+38h] [rbp-31h] BYREF
			//   Vector4 v43; // [rsp+48h] [rbp-21h] BYREF
			//   Matrix4x4 v44; // [rsp+58h] [rbp-11h] BYREF
			// 
			//   if ( !byte_18D919795 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//     sub_18003C530(&off_18D520378);
			//     byte_18D919795 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4461, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4461, 0LL);
			//     if ( !Patch )
			//       goto LABEL_22;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       (Object *)material,
			//       (Object *)propertyBlock,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(propertyBlock, (String *)"_WindFieldTex", 0LL, 0LL);
			//     m_CloudMat = (Object_1 *)this.fields.m_CloudMat;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Implicit((Object_1 *)material, 0LL) )
			//       {
			//         v10 = this.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//         if ( !v10 )
			//           goto LABEL_22;
			//         if ( !UnityEngine::Material::IsKeywordEnabled(v10, *((String **)static_fields + 14), 0LL) )
			//         {
			//           v13 = this.fields.m_CloudMat;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords.static_fields;
			//           if ( v13 )
			//           {
			//             if ( UnityEngine::Material::IsKeywordEnabled(v13, *((String **)static_fields + 15), 0LL) )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//               HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, material, 2, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//               m_WindFieldManager = (VolumetricWindFieldManager *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//               static_fields = this.fields.m_CloudMat;
			//               WindLerpDistance = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WindLerpDistance;
			//               if ( static_fields )
			//               {
			//                 Vector = UnityEngine::Material::GetVector(&v43, (Material *)static_fields, WindLerpDistance, 0LL);
			//                 if ( propertyBlock )
			//                 {
			//                   v42 = *Vector;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, WindLerpDistance, &v42, 0LL);
			//                   *(_QWORD *)&v42.x = *(_QWORD *)&this.fields.m_WindOffset.x;
			//                   v42.z = this.fields.m_WindOffset.z;
			//                   v42 = *UnityEngine::Vector4::op_Implicit(&v43, (Vector3 *)&v42, v19);
			//                   UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v20, &v42, 0LL);
			//                   *(_QWORD *)&v42.x = *(_QWORD *)&this.fields.m_WindOffset2.x;
			//                   v42.z = this.fields.m_WindOffset2.z;
			//                   v42 = *UnityEngine::Vector4::op_Implicit(&v43, (Vector3 *)&v42, v21);
			//                   UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v22, &v42, 0LL);
			//                   *(_QWORD *)&v42.x = *(_QWORD *)&this.fields.m_WindOffset3.x;
			//                   v42.z = this.fields.m_WindOffset3.z;
			//                   v15 = UnityEngine::Vector4::op_Implicit(&v43, (Vector3 *)&v42, v23);
			//                   goto LABEL_11;
			//                 }
			//               }
			//             }
			//             else
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//               HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, material, 1, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//               *(_QWORD *)&v42.x = *(_QWORD *)&this.fields.m_WindOffset.x;
			//               v42.z = this.fields.m_WindOffset.z;
			//               v15 = UnityEngine::Vector4::op_Implicit(&v43, (Vector3 *)&v42, v14);
			//               if ( propertyBlock )
			//               {
			// LABEL_11:
			//                 v42 = *v15;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v16, &v42, 0LL);
			//                 return;
			//               }
			//             }
			//           }
			// LABEL_22:
			//           sub_180B536AC(m_WindFieldManager, static_fields);
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, material, 3, 0LL);
			//         HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
			//           propertyBlock,
			//           (String *)"_WindFieldTex",
			//           this.fields.AdvancedTextureToUse,
			//           0LL);
			//         m_MaxExtent = this.fields.m_MaxExtent;
			//         v25 = this.fields.m_CloudMat;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         if ( !v25 )
			//           goto LABEL_22;
			//         v26 = m_MaxExtent / UnityEngine::Material::GetFloatImpl(v25, *((_DWORD *)static_fields + 25), 0LL);
			//         m_WindFieldManager = (VolumetricWindFieldManager *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         if ( !propertyBlock )
			//           goto LABEL_22;
			//         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//           propertyBlock,
			//           (int32_t)m_WindFieldManager[12].fields.windFieldDataList,
			//           v26,
			//           0LL);
			//         UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//           propertyBlock,
			//           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._InvWindOffsetScale,
			//           1.0 / v26,
			//           0LL);
			//         *(_QWORD *)&v42.x = *(_QWORD *)&this.fields.m_InvScale.x;
			//         v42.z = this.fields.m_InvScale.z;
			//         v42 = *UnityEngine::Vector4::op_Implicit(&v43, (Vector3 *)&v42, v27);
			//         UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v28, &v42, 0LL);
			//         v29 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m01;
			//         *(_OWORD *)&v44.m00 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m00;
			//         v30 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         v31 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m02;
			//         *(_OWORD *)&v44.m01 = v29;
			//         v32 = *(_OWORD *)&this.fields.m_CloudRenderWorldToLocal.m03;
			//         BoxWorldToLocal = v30._BoxWorldToLocal;
			//         *(_OWORD *)&v44.m02 = v31;
			//         *(_OWORD *)&v44.m03 = v32;
			//         UnityEngine::MaterialPropertyBlock::SetMatrix(propertyBlock, BoxWorldToLocal, &v44, 0LL);
			//         WindFieldNum = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields._WindFieldNum;
			//         m_WindFieldManager = this.fields.m_WindFieldManager;
			//         if ( !m_WindFieldManager )
			//           goto LABEL_22;
			//         v35 = HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldNum(m_WindFieldManager, 0LL);
			//         UnityEngine::MaterialPropertyBlock::SetFloatImpl(propertyBlock, WindFieldNum, (float)v35, 0LL);
			//         m_WindFieldManager = this.fields.m_WindFieldManager;
			//         if ( !m_WindFieldManager )
			//           goto LABEL_22;
			//         WindFieldBuffer = HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldBuffer(
			//                             m_WindFieldManager,
			//                             0LL);
			//         m_WindFieldManager = (VolumetricWindFieldManager *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
			//         v37 = WindFieldBuffer;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs.static_fields;
			//         v38 = *((_DWORD *)static_fields + 148);
			//         if ( !WindFieldBuffer )
			//           goto LABEL_22;
			//         count = UnityEngine::ComputeBuffer::get_count(WindFieldBuffer, 0LL);
			//         stride = UnityEngine::ComputeBuffer::get_stride(v37, 0LL);
			//         UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(propertyBlock, v38, v37, 0, count * stride, 0LL);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_PrepareVolumetricRenderingImpl(ref VolumetricRenderInputs P0)
		{
			// // Void <>iFixBaseProxy_PrepareVolumetricRenderingImpl(VolumetricRenderInputs ByRef)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_PrepareVolumetricRenderingImpl(
			//         VolumetricCloudSDF *this,
			//         VolumetricRenderInputs *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRenderingImpl(
			//     (VolumetricRenderObject *)this,
			//     P0,
			//     0LL);
			// }
			// 
		}

		public bool <>iFixBaseProxy_OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext P0, out VolumetricRenderer.VolumetricRenderItem P1)
		{
			// // Boolean <>iFixBaseProxy_OverrideFramingCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_OverrideFramingCompose(
			//         VolumetricCloudSDF *this,
			//         VolumetricRenderer_VolumetricComposeContext *P0,
			//         VolumetricRenderer_VolumetricRenderItem *P1,
			//         MethodInfo *method)
			// {
			//   HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
			//   VolumetricRenderer_VolumetricComposeContext v6; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   volumetricSettings = P0.volumetricSettings;
			//   *(_OWORD *)&v6.bEnableFraming = *(_OWORD *)&P0.bEnableFraming;
			//   v6.volumetricSettings = volumetricSettings;
			//   return HG::Rendering::Runtime::VolumetricRenderObject::OverrideFramingCompose(
			//            (VolumetricRenderObject *)this,
			//            &v6,
			//            P1,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public bool <>iFixBaseProxy_OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext P0, out VolumetricRenderer.VolumetricRenderItem P1)
		{
			// // Boolean <>iFixBaseProxy_OverrideTemporalCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
			// bool HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_OverrideTemporalCompose(
			//         VolumetricCloudSDF *this,
			//         VolumetricRenderer_VolumetricComposeContext *P0,
			//         VolumetricRenderer_VolumetricRenderItem *P1,
			//         MethodInfo *method)
			// {
			//   HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
			//   VolumetricRenderer_VolumetricComposeContext v6; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   volumetricSettings = P0.volumetricSettings;
			//   *(_OWORD *)&v6.bEnableFraming = *(_OWORD *)&P0.bEnableFraming;
			//   v6.volumetricSettings = volumetricSettings;
			//   return HG::Rendering::Runtime::VolumetricRenderObject::OverrideTemporalCompose(
			//            (VolumetricRenderObject *)this,
			//            &v6,
			//            P1,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_CollectVolumetricRenderItemsImpl(HGCamera P0, HGVolumetricCloudSettingParameters P1, List<VolumetricRenderer.VolumetricRenderItem> P2)
		{
			// // Void <>iFixBaseProxy_CollectVolumetricRenderItemsImpl(HGCamera, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_CollectVolumetricRenderItemsImpl(
			//         VolumetricCloudSDF *this,
			//         HGCamera *P0,
			//         HGVolumetricCloudSettingParameters *P1,
			//         List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *P2,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsImpl(
			//     (VolumetricRenderObject *)this,
			//     P0,
			//     P1,
			//     P2,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_CollectVolumetricRenderItemsCPPImpl(HGCamera P0, HGVolumetricCloudSettingParameters P1, List<HGVolumetricRenderItem> P2)
		{
			// // Void <>iFixBaseProxy_CollectVolumetricRenderItemsCPPImpl(HGCamera, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
			// void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_CollectVolumetricRenderItemsCPPImpl(
			//         VolumetricCloudSDF *this,
			//         HGCamera *P0,
			//         HGVolumetricCloudSettingParameters *P1,
			//         List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *P2,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsCPPImpl(
			//     (VolumetricRenderObject *)this,
			//     P0,
			//     P1,
			//     P2,
			//     0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnUpdateVolumetricMaterial(CommandBuffer P0, Material P1, MaterialPropertyBlock P2)
		{
			// // Void <>iFixBaseProxy_OnUpdateVolumetricMaterial(CommandBuffer, Material, MaterialPropertyBlock)
			// void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_OnUpdateVolumetricMaterial(
			//         VolumetricCloudSDF *this,
			//         CommandBuffer *P0,
			//         Material *P1,
			//         MaterialPropertyBlock *P2,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VolumetricRenderObject::OnUpdateVolumetricMaterial(
			//     (VolumetricRenderObject *)this,
			//     P0,
			//     P1,
			//     P2,
			//     0LL);
			// }
			// 
		}

		public Material m_CloudMat;

		public VolumetricSdfAsset m_CloudAsset;

		private VolumetricEncodedTexture DensityTextureToUse;

		private VolumetricEncodedTexture AdvancedTextureToUse;

		private VolumetricEncodedTexture SHTextureToUse;

		private Vector3 m_WindPhase;

		private Vector3 m_WindPhase2;

		private Vector3 m_WindPhase3;

		private Vector3 m_WindOffset;

		private Vector3 m_WindOffset2;

		private Vector3 m_WindOffset3;

		private GameObject m_CloudObject;

		public bool m_DrawNear;

		public bool m_DrawFar;

		public int m_msBakeSizeX;

		public int m_msBakeSizeY;

		private VolumetricMSBake m_MSBaker;

		private Dictionary<int, VolumetricFarCloudRenderer> farRenderers;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static List<int> farRenderersToDelete;

		private float m_MaxExtent;

		private Vector3 m_VoxelSize;

		private Vector3 m_InvScale;

		private Vector3 m_MainLightDirection;

		private Matrix4x4 m_CloudRenderWorldToLocal;

		private Matrix4x4 m_CloudRenderLocalToWorld;

		private float m_OpticalDepthScale;

		private float m_InvOpticalDepthScale;

		private bool m_inside;

		private MaterialPropertyBlock m_propertyBlock;

		private MaterialPropertyBlock m_composePropertyBlock;

		private MaterialPropertyBlock m_emptySkipPropertyBlock;

		private List<VolumetricWindFieldNode> m_WindFieldNodeList;

		private VolumetricWindFieldManager m_WindFieldManager;

		[SerializeField]
		private BeyondPolyLineShape _polyLineShape;

		public int m_VolumePriority;

		[NonSerialized]
		public bool m_ForceVisible;

		private Dictionary<int, bool> _visibleStates;

		private Dictionary<int, bool> _loadingStates;

		private Dictionary<int, bool> _fadeInStates;

		private Vector3 lastCameraPosition;

		private Quaternion lastCameraRotation;

		private List<MeshRenderer> _renderers;

		private const int DISABLE_FAR_CLOUD_SHADER_LOD = 600;

		private bool bLastPanoramic;

		private bool bLastOctahedron;

		private bool bLastSemicircular;

		public enum EViewMode
		{
			None,
			Mesh,
			SDF,
			Cloud
		}

		public enum ECompressMode
		{
			None,
			ASTC4x4,
			ASTC8x8
		}
	}
}
