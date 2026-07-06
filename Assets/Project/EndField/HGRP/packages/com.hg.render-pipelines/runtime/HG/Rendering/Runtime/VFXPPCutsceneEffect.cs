using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[AddComponentMenu("VFXPPCutsceneEffect")]
	public class VFXPPCutsceneEffect : VFXPPComponent
	{
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // XmlNodeType get_NodeType()
				// XmlNodeType__Enum System::Xml::Linq::XDocument::get_NodeType(XDocument *this, MethodInfo *method)
				// {
				//   return 9;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool cutsceneEffectMaterialValid
		{
			get
			{
				// // Boolean get_cutsceneEffectMaterialValid()
				// bool HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectMaterialValid(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct VFXPPCutsceneEffect__Class *v2; // rax
				// 
				//   if ( !byte_18D91941C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
				//     byte_18D91941C = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
				//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
				//   }
				//   return v2.static_fields.m_useCutsceneEffsectShader;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000025D2 File Offset: 0x000007D2
		public static MaterialPropertyBlock cutsceneEffectPropertyBlock
		{
			get
			{
				return null;
			}
		}

		public VFXPPCutsceneEffect()
		{
		}

		public override void SetData(VFXPPData data)
		{
		}

		public override VFXPPData GetData()
		{
			return null;
		}

		private void OnEffectListChanged()
		{
			// // Void OnEffectListChanged()
			// void HG::Rendering::Runtime::VFXPPCutsceneEffect::OnEffectListChanged(VFXPPCutsceneEffect *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *effectList; // rax
			//   __int64 v6; // r8
			//   Object *v7; // rax
			//   List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *v8; // rdi
			//   int32_t size; // ebx
			//   MethodInfo *v10; // rdx
			//   Color *red; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m256i v13; // [rsp+20h] [rbp-E0h] BYREF
			//   __int128 v14; // [rsp+40h] [rbp-C0h]
			//   __int128 v15; // [rsp+50h] [rbp-B0h]
			//   __int128 v16; // [rsp+60h] [rbp-A0h]
			//   VFXPPCutsceneEffect_CutsceneEffectCfg v17; // [rsp+70h] [rbp-90h] BYREF
			//   Object o1; // [rsp+C0h] [rbp-40h] BYREF
			//   VFXPPCutsceneEffect_CutsceneEffectCfg v19; // [rsp+D0h] [rbp-30h]
			//   __m256i v20; // [rsp+120h] [rbp+20h] BYREF
			//   __int128 v21; // [rsp+140h] [rbp+40h]
			//   __int128 v22; // [rsp+150h] [rbp+50h]
			//   __int128 v23; // [rsp+160h] [rbp+60h]
			//   Color v24; // [rsp+170h] [rbp+70h] BYREF
			// 
			//   if ( !byte_18D91941F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::set_Item);
			//     byte_18D91941F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2074, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2074, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     effectList = this.fields.effectList;
			//     if ( !effectList )
			//       goto LABEL_10;
			//     if ( effectList.fields._size > 0 )
			//     {
			//       System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item(
			//         &v17,
			//         this.fields.effectList,
			//         effectList.fields._size - 1,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item);
			//       sub_1802F01E0(&v13, 0LL, 80LL);
			//       v20 = v13;
			//       v21 = v14;
			//       v23 = v16;
			//       v22 = v15;
			//       v7 = (Object *)il2cpp_value_box_0(
			//                        TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg,
			//                        &v20,
			//                        v6);
			//       o1.monitor = (MonitorData *)-1LL;
			//       v19 = v17;
			//       o1.klass = (Object__Class *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg;
			//       if ( System::ValueType::DefaultEquals(&o1, v7, 0LL) )
			//       {
			//         v8 = this.fields.effectList;
			//         if ( v8 )
			//         {
			//           size = v8.fields._size;
			//           sub_1802F01E0(&v13, 0LL, 80LL);
			//           red = UnityEngine::Color::get_red(&v24, v10);
			//           *(_QWORD *)&v15 = 0x3F8CCCCD00000000LL;
			//           HIDWORD(v16) = 0;
			//           *(Color *)&v13.m256i_u64[1] = *red;
			//           v13.m256i_i64[3] = 1065353216LL;
			//           *(_OWORD *)&v17.option = *(_OWORD *)v13.m256i_i8;
			//           *(_OWORD *)&v17.color.b = *(_OWORD *)&v13.m256i_u64[2];
			//           DWORD2(v15) = 1056964608;
			//           BYTE12(v15) = 0;
			//           *(_QWORD *)&v16 = 0x3E8F5C293F666666LL;
			//           BYTE8(v16) = 0;
			//           *(_OWORD *)&v17.rotation = v15;
			//           *(_OWORD *)&v17.depthFadePosition = v16;
			//           *(__m128i *)&v17.leftFadeRange = _mm_load_si128((const __m128i *)&xmmword_18C370F30);
			//           sub_180618A34(
			//             v8,
			//             (unsigned int)(size - 1),
			//             &v17,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::set_Item);
			//           return;
			//         }
			// LABEL_10:
			//         sub_180B536AC(v4, v3);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::VFXPPCutsceneEffect::Awake(VFXPPCutsceneEffect *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct VFXPPCutsceneEffect__Class *v4; // rax
			//   VFXPPCutsceneEffect__StaticFields *static_fields; // rcx
			//   List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *effectList; // rdx
			//   struct VFXPPCutsceneEffect__Class *v7; // rcx
			//   Object_1 *m_baseMaterial; // rdi
			//   Component *transform; // rax
			//   GameObject *gameObject; // rax
			//   struct VFXPPCutsceneEffect__Class *v11; // rax
			//   struct VFXPPCutsceneEffect__Class *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED98A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Count);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     byte_18D8ED98A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2075, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2075, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_21;
			//   }
			//   v4 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, v3);
			//     v4 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//   }
			//   v4.static_fields.m_useCutsceneEffsectShader = 0;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields;
			//   static_fields.m_enableCompatibilityMode = 0;
			//   effectList = this.fields.effectList;
			//   if ( !effectList )
			//     goto LABEL_21;
			//   TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount = effectList.fields._size;
			//   v7 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//   if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount )
			//   {
			//     m_baseMaterial = (Object_1 *)this.fields.m_baseMaterial;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, effectList);
			//     if ( !UnityEngine::Object::op_Inequality(m_baseMaterial, 0LL, 0LL)
			//       || !UnityEngine::Behaviour::get_enabled((Behaviour *)this, 0LL) )
			//     {
			// LABEL_25:
			//       v7 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//       goto LABEL_26;
			//     }
			//     transform = (Component *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( transform )
			//     {
			//       gameObject = UnityEngine::Component::get_gameObject(transform, 0LL);
			//       if ( gameObject )
			//       {
			//         if ( UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
			//         {
			//           v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//           if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, effectList);
			//             v11 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//           }
			//           v11.static_fields.m_useCutsceneEffsectShader = 1;
			//           v12 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//           if ( this.fields.enableCompatibilityMode )
			//           {
			//             if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, effectList);
			//               v12 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//             }
			//             v12.static_fields.m_enableCompatibilityMode = 1;
			//           }
			//           else
			//           {
			//             if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, effectList);
			//               v12 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//             }
			//             v12.static_fields.m_enableCompatibilityMode = 0;
			//           }
			//           return;
			//         }
			//         goto LABEL_25;
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(static_fields, effectList);
			//   }
			// LABEL_26:
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, effectList);
			//     v7 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//   }
			//   v7.static_fields.m_useCutsceneEffsectShader = 0;
			// }
			// 
		}

		public override VFXPPData GetDefaultData()
		{
			return null;
		}

		protected override VFXPPData _GetLerpData(float value)
		{
			// // VFXPPData _GetLerpData(Single)
			// VFXPPData *HG::Rendering::Runtime::VFXPPCutsceneEffect::_GetLerpData(
			//         VFXPPCutsceneEffect *this,
			//         float value,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2077, 0LL) )
			//     return this.fields._.m_targetData;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2077, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v7, v6);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_774(Patch, (Object *)this, value, 0LL);
			// }
			// 
			return null;
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCutsceneEffect::Apply(
			//         VFXPPCutsceneEffect *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   _QWORD *p_m_useCutsceneEffsectShader; // rcx
			//   List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *effectList; // rdx
			//   struct VFXPPCutsceneEffect__Class *v8; // rcx
			//   Object_1 *m_baseMaterial; // rbx
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   __int64 v12; // rax
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   int32_t v16; // r14d
			//   struct VFXPPCutsceneEffect__Class *v17; // rcx
			//   Material *v18; // r15
			//   Material__Array *v19; // rdi
			//   Material *v20; // rax
			//   Material *v21; // rbx
			//   VFXPPCutsceneEffect__StaticFields *static_fields; // rax
			//   Material__Array *runtimeMaterial; // r8
			//   int32_t i; // edi
			//   __int64 v25; // rbx
			//   Object_1 *v26; // rbx
			//   __int64 v27; // rbx
			//   Object_1 *v28; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   __int64 v32; // r8
			//   __int64 v33; // rax
			//   HGRenderPathBase_HGRenderPathResources *v34; // rdx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   HGCamera *v36; // r9
			//   int32_t v37; // r14d
			//   struct VFXPPCutsceneEffect__Class *v38; // rcx
			//   Material *v39; // r15
			//   Material__Array *v40; // rdi
			//   Material *v41; // rax
			//   Material *v42; // rbx
			//   Component *v43; // rax
			//   GameObject *gameObject; // rax
			//   MaterialPropertyBlock *cutsceneEffectPropertyBlock; // rax
			//   int32_t v46; // edi
			//   struct VFXPPCutsceneEffect__Class *v47; // rcx
			//   __int64 v48; // rbx
			//   Object_1 *v49; // rbx
			//   Material__Array *v50; // r14
			//   Material *v51; // rbx
			//   Material *v52; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   VFXPPCutsceneEffect_CutsceneEffectCfg cutsceneEffectCfg; // [rsp+28h] [rbp-59h] BYREF
			//   VFXPPCutsceneEffect_CutsceneEffectCfg v55; // [rsp+78h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D919421 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Material);
			//     sub_18003C530(&TypeInfo::UnityEngine::Material);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     byte_18D919421 = 1;
			//   }
			//   sub_1802F01E0(&cutsceneEffectCfg, 0LL, 80LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2078, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2078, 0LL);
			//     if ( !Patch )
			//       goto LABEL_57;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//     return;
			//   }
			//   transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
			//     return;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//   p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader;
			//   *(_BYTE *)p_m_useCutsceneEffsectShader = 0;
			//   effectList = this.fields.effectList;
			//   if ( !effectList )
			//     goto LABEL_57;
			//   TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount = effectList.fields._size;
			//   v8 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//   if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount )
			//   {
			//     m_baseMaterial = (Object_1 *)this.fields.m_baseMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(m_baseMaterial, 0LL, 0LL)
			//       && UnityEngine::Behaviour::get_enabled((Behaviour *)this, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader = 1;
			//       if ( this.fields.enableCompatibilityMode )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_enableCompatibilityMode = 1;
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_enableCompatibilityMode = 0;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//       if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._0.image;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields;
			//         runtimeMaterial = static_fields.runtimeMaterial;
			//         if ( !runtimeMaterial )
			//           goto LABEL_57;
			//         if ( runtimeMaterial.max_length.size != static_fields.effectListCount )
			//         {
			//           for ( i = 0; ; ++i )
			//           {
			//             sub_180002C70(p_m_useCutsceneEffsectShader);
			//             p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._0.image;
			//             effectList = (List_1_HG_Rendering_Runtime_VFXPPCutsceneEffect_CutsceneEffectCfg_ *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial;
			//             if ( !effectList )
			//               goto LABEL_57;
			//             if ( i >= effectList.fields._size )
			//               break;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//             p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader;
			//             v25 = p_m_useCutsceneEffsectShader[3];
			//             if ( !v25 )
			//               goto LABEL_57;
			//             if ( (unsigned int)i >= *(_DWORD *)(v25 + 24) )
			//               goto LABEL_55;
			//             v26 = *(Object_1 **)(v25 + 8LL * i + 32);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Inequality(v26, 0LL, 0LL) )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//               p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader;
			//               v27 = p_m_useCutsceneEffsectShader[3];
			//               if ( !v27 )
			//                 goto LABEL_57;
			//               if ( (unsigned int)i >= *(_DWORD *)(v27 + 24) )
			// LABEL_55:
			//                 sub_180070270(p_m_useCutsceneEffsectShader, effectList);
			//               v28 = *(Object_1 **)(v27 + 8LL * i + 32);
			//               sub_180002C70(TypeInfo::UnityEngine::Object);
			//               UnityEngine::Object::DestroyImmediate(v28, 0LL);
			//               p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial.klass;
			//               if ( !p_m_useCutsceneEffsectShader )
			//                 goto LABEL_57;
			//               sub_18000FDA0(p_m_useCutsceneEffsectShader, i, 0LL);
			//             }
			//             p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._0.image;
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//           TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial = 0LL;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial,
			//             v29,
			//             v30,
			//             v31,
			//             *(MethodInfo **)&cutsceneEffectCfg.option,
			//             *(MethodInfo **)&cutsceneEffectCfg.color.r);
			//           v33 = il2cpp_array_new_specific_0(
			//                   TypeInfo::UnityEngine::Material,
			//                   (unsigned int)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount,
			//                   v32,
			//                   TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//           v34 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields;
			//           v34[1].settingParameters = (HGSettingParameters *)v33;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial,
			//             v34,
			//             v35,
			//             v36,
			//             *(MethodInfo **)&cutsceneEffectCfg.option,
			//             *(MethodInfo **)&cutsceneEffectCfg.color.r);
			//           v37 = 0;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//           v38 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//           if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount > 0 )
			//           {
			//             while ( 1 )
			//             {
			//               sub_180002C70(v38);
			//               v39 = this.fields.m_baseMaterial;
			//               v40 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial;
			//               v41 = (Material *)sub_180004920(TypeInfo::UnityEngine::Material);
			//               v42 = v41;
			//               if ( !v41 )
			//                 break;
			//               UnityEngine::Material::Material(v41, v39, 0LL);
			//               if ( !v40 )
			//                 break;
			//               sub_180036D40(v40, v42);
			//               sub_18000FDA0(v40, v37++, v42);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//               v38 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//               if ( v37 >= TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount )
			//                 goto LABEL_38;
			//             }
			// LABEL_57:
			//             sub_180B536AC(p_m_useCutsceneEffsectShader, effectList);
			//           }
			//         }
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         v12 = il2cpp_array_new_specific_0(
			//                 TypeInfo::UnityEngine::Material,
			//                 (unsigned int)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount,
			//                 v10,
			//                 v11);
			//         v13 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields;
			//         v13[1].settingParameters = (HGSettingParameters *)v12;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial,
			//           v13,
			//           v14,
			//           v15,
			//           *(MethodInfo **)&cutsceneEffectCfg.option,
			//           *(MethodInfo **)&cutsceneEffectCfg.color.r);
			//         v16 = 0;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         v17 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//         if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount > 0 )
			//         {
			//           while ( 1 )
			//           {
			//             sub_180002C70(v17);
			//             v18 = this.fields.m_baseMaterial;
			//             v19 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial;
			//             v20 = (Material *)sub_180004920(TypeInfo::UnityEngine::Material);
			//             v21 = v20;
			//             if ( !v20 )
			//               goto LABEL_57;
			//             UnityEngine::Material::Material(v20, v18, 0LL);
			//             if ( !v19 )
			//               goto LABEL_57;
			//             sub_180036D40(v19, v21);
			//             sub_18000FDA0(v19, v16++, v21);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//             v17 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//             if ( v16 >= TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount )
			//               goto LABEL_38;
			//           }
			//         }
			//       }
			//       goto LABEL_38;
			//     }
			//     v8 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//   }
			//   sub_180002C70(v8);
			//   TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader = 0;
			// LABEL_38:
			//   v43 = (Component *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !v43 )
			//     goto LABEL_57;
			//   gameObject = UnityEngine::Component::get_gameObject(v43, 0LL);
			//   if ( !gameObject )
			//     goto LABEL_57;
			//   if ( !UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader = 0;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//   if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader )
			//   {
			//     v46 = 0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     v47 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//     if ( TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         sub_180002C70(v47);
			//         p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader;
			//         v48 = p_m_useCutsceneEffsectShader[3];
			//         if ( !v48 )
			//           goto LABEL_57;
			//         if ( (unsigned int)v46 >= *(_DWORD *)(v48 + 24) )
			//           goto LABEL_55;
			//         v49 = *(Object_1 **)(v48 + 8LL * v46 + 32);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Inequality(v49, 0LL, 0LL) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//           p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._0.image;
			//           v50 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.runtimeMaterial;
			//           if ( !v50 )
			//             goto LABEL_57;
			//           if ( (unsigned int)v46 >= v50.max_length.size )
			//             goto LABEL_55;
			//           effectList = this.fields.effectList;
			//           v51 = v50.vector[v46];
			//           if ( !effectList )
			//             goto LABEL_57;
			//           System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item(
			//             &v55,
			//             effectList,
			//             v46,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg>::get_Item);
			//           cutsceneEffectCfg = v55;
			//           v52 = HG::Rendering::Runtime::VFXPPCutsceneEffect::SetMaterial(this, v51, &cutsceneEffectCfg, 0LL);
			//           sub_180036D40(v50, v52);
			//           sub_18000FDA0(v50, v46, v52);
			//         }
			//         ++v46;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//         v47 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//         if ( v46 >= TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.effectListCount )
			//           return;
			//       }
			//     }
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     cutsceneEffectPropertyBlock = HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectPropertyBlock(0LL);
			//     if ( !cutsceneEffectPropertyBlock )
			//       goto LABEL_57;
			//     UnityEngine::MaterialPropertyBlock::Clear(cutsceneEffectPropertyBlock, 1, 0LL);
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPCutsceneEffect::ResetByVolumeProfile(
			//         VFXPPCutsceneEffect *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   struct VFXPPCutsceneEffect__Class *v6; // rax
			//   MaterialPropertyBlock *cutsceneEffectPropertyBlock; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED98B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     byte_18D8ED98B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2080, 0LL) )
			//   {
			//     v6 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, v5);
			//       v6 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//     }
			//     v6.static_fields.m_useCutsceneEffsectShader = 0;
			//     cutsceneEffectPropertyBlock = HG::Rendering::Runtime::VFXPPCutsceneEffect::get_cutsceneEffectPropertyBlock(0LL);
			//     if ( cutsceneEffectPropertyBlock )
			//     {
			//       UnityEngine::MaterialPropertyBlock::Clear(cutsceneEffectPropertyBlock, 1, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2080, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)volumeProfile,
			//     0LL);
			// }
			// 
		}

		protected override void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::VFXPPCutsceneEffect::OnStop(VFXPPCutsceneEffect *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct VFXPPCutsceneEffect__Class *v4; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D8ED98C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     byte_18D8ED98C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2081, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2081, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VFXPPComponent::OnStop((VFXPPComponent *)this, 0LL);
			//     v4 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect;
			//     }
			//     v4.static_fields.m_useCutsceneEffsectShader = 0;
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_enableCompatibilityMode = 0;
			//   }
			// }
			// 
		}

		public Material SetMaterial(Material material, in VFXPPCutsceneEffect.CutsceneEffectCfg cutsceneEffectCfg)
		{
			// // Material SetMaterial(Material, VFXPPCutsceneEffect+CutsceneEffectCfg ByRef)
			// Material *HG::Rendering::Runtime::VFXPPCutsceneEffect::SetMaterial(
			//         VFXPPCutsceneEffect *this,
			//         Material *material,
			//         VFXPPCutsceneEffect_CutsceneEffectCfg *cutsceneEffectCfg,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   _QWORD *p_m_useCutsceneEffsectShader; // rcx
			//   __int64 v9; // rax
			//   int32_t v10; // edx
			//   float yScale; // xmm1_4
			//   VFXPPCutsceneEffect_ShaderConstants__StaticFields *static_fields; // rcx
			//   Shader *v13; // rax
			//   Shader *shader; // rax
			//   float v15; // xmm2_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color color; // [rsp+30h] [rbp-40h] BYREF
			//   LocalKeyword keyword; // [rsp+40h] [rbp-30h] BYREF
			//   LocalKeyword v20; // [rsp+58h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919422 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//     sub_18003C530(&off_18D4E4A08);
			//     byte_18D919422 = 1;
			//   }
			//   memset(&v20, 0, sizeof(v20));
			//   memset(&keyword, 0, sizeof(keyword));
			//   if ( IFix::WrappersManagerImpl::IsPatched(2079, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2079, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_779(
			//                Patch,
			//                (Object *)this,
			//                (Object *)material,
			//                cutsceneEffectCfg,
			//                0LL);
			// LABEL_24:
			//     sub_180B536AC(p_m_useCutsceneEffsectShader, v7);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect);
			//   p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect.static_fields.m_useCutsceneEffsectShader;
			//   v9 = p_m_useCutsceneEffsectShader[3];
			//   if ( !v9 )
			//     goto LABEL_24;
			//   if ( !*(_QWORD *)(v9 + 24) )
			//     return 0LL;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality((Object_1 *)material, 0LL, 0LL) )
			//     return 0LL;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//   p_m_useCutsceneEffsectShader = &TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._BaseColor;
			//   if ( !material )
			//     goto LABEL_24;
			//   v10 = *(_DWORD *)p_m_useCutsceneEffsectShader;
			//   color = cutsceneEffectCfg.color;
			//   UnityEngine::Material::SetColor(material, v10, &color, 0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._LightRange1,
			//     cutsceneEffectCfg.para1,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._LightRange2,
			//     cutsceneEffectCfg.para2,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._XOffset,
			//     cutsceneEffectCfg.xOffset,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._YOffset,
			//     cutsceneEffectCfg.yOffset,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._LeftFadeRange,
			//     cutsceneEffectCfg.leftFadeRange,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._RightFadeRange,
			//     cutsceneEffectCfg.rightFadeRange,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._Ration,
			//     cutsceneEffectCfg.rotation,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._ShapeOption,
			//     (float)cutsceneEffectCfg.shapeOption,
			//     0LL);
			//   if ( !cutsceneEffectCfg.option )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._ColorOption,
			//       0.0,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._LightIntensity,
			//       this.fields.lightIntensity,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._SrcBlend,
			//       1.0,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._DstBlend,
			//       1.0,
			//       0LL);
			//   }
			//   if ( cutsceneEffectCfg.option == 1 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._ColorOption,
			//       1.0,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._DarkIntensity,
			//       this.fields.darkIntensity,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._SrcBlend,
			//       2.0,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._DstBlend,
			//       0.0,
			//       0LL);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._TotalXOffset,
			//     this.fields.totalXOffset,
			//     0LL);
			//   UnityEngine::Material::SetFloatImpl(
			//     material,
			//     TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._TotalYOffset,
			//     this.fields.totalYOffset,
			//     0LL);
			//   yScale = cutsceneEffectCfg.yScale;
			//   color.r = cutsceneEffectCfg.xScale;
			//   color.g = yScale;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields;
			//   *(_QWORD *)&color.b = 0x3F8000003F800000LL;
			//   UnityEngine::Material::SetVector(material, static_fields._Scale, (Vector4 *)&color, 0LL);
			//   if ( cutsceneEffectCfg.useDepthFade )
			//   {
			//     if ( !UnityEngine::Material::IsKeywordEnabled(material, (String *)"_ENABLE_DEPTH_FADE", 0LL) )
			//     {
			//       shader = UnityEngine::Material::get_shader(material, 0LL);
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v20, shader, (String *)"_ENABLE_DEPTH_FADE", 0LL);
			//       UnityEngine::Material::SetKeyword(material, &v20, 1, 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._NearFadeIntensity,
			//       cutsceneEffectCfg.nearFadeIntensity,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._DepthFadePosition,
			//       cutsceneEffectCfg.depthFadePosition,
			//       0LL);
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._DepthFadeRange,
			//       cutsceneEffectCfg.depthFadeRange,
			//       0LL);
			//     if ( cutsceneEffectCfg.useInvertFade )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//       v15 = 1.0;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants);
			//       v15 = 0.0;
			//     }
			//     UnityEngine::Material::SetFloatImpl(
			//       material,
			//       TypeInfo::HG::Rendering::Runtime::VFXPPCutsceneEffect::ShaderConstants.static_fields._UseInvertFade,
			//       v15,
			//       0LL);
			//   }
			//   else if ( UnityEngine::Material::IsKeywordEnabled(material, (String *)"_ENABLE_DEPTH_FADE", 0LL) )
			//   {
			//     v13 = UnityEngine::Material::get_shader(material, 0LL);
			//     UnityEngine::Rendering::LocalKeyword::LocalKeyword(&keyword, v13, (String *)"_ENABLE_DEPTH_FADE", 0LL);
			//     UnityEngine::Material::SetKeyword(material, &keyword, 0, 0LL);
			//   }
			//   return material;
			// }
			// 
			return null;
		}

		public void <>iFixBaseProxy_SetData(VFXPPData P0)
		{
			// // Void <>iFixBaseProxy_SetData(VFXPPData)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_SetData(
			//         VFXPPVignette *this,
			//         VFXPPData *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::SetData((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public VFXPPData <>iFixBaseProxy_GetData()
		{
			// // VFXPPData <>iFixBaseProxy_GetData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetData(VFXPPVignette *this, MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::GetData((VFXPPComponent *)this, 0LL);
			// }
			// 
			return null;
		}

		public VFXPPData <>iFixBaseProxy_GetDefaultData()
		{
			// // VFXPPData <>iFixBaseProxy_GetDefaultData()
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetDefaultData(
			//         VFXPPVignette *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::GetDefaultData((VFXPPComponent *)this, 0LL);
			// }
			// 
			return null;
		}

		public VFXPPData <>iFixBaseProxy__GetLerpData(float P0)
		{
			// // VFXPPData <>iFixBaseProxy__GetLerpData(Single)
			// VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy__GetLerpData(
			//         VFXPPVignette *this,
			//         float P0,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::_GetLerpData((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
			return null;
		}

		public void <>iFixBaseProxy_Apply(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public new void <>iFixBaseProxy_OnStop()
		{
			// // Void <>iFixBaseProxy_OnStop()
			// void HG::Rendering::Runtime::VFXPPCutsceneEffect::__iFixBaseProxy_OnStop(VFXPPCutsceneEffect *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::OnStop((VFXPPComponent *)this, 0LL);
			// }
			// 
		}

		[Range(-2f, 2f)]
		public float totalXOffset;

		[Range(-2f, 2f)]
		public float totalYOffset;

		[Space(10f)]
		[Range(0f, 1f)]
		public float lightIntensity;

		[Range(0f, 1f)]
		public float darkIntensity;

		public bool enableCompatibilityMode;

		public List<VFXPPCutsceneEffect.CutsceneEffectCfg> effectList;

		private Renderer m_renderer;

		private const string SHADER_CUTSCENE_EFFECT = "HGRP/CutsceneEffect";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static bool m_useCutsceneEffsectShader;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x01")]
		public static bool m_enableCompatibilityMode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static MaterialPropertyBlock s_materialPropertyBlock;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static int effectListCount;

		[SerializeField]
		[HideInInspector]
		private Material m_baseMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static Material[] runtimeMaterial;

		private static class ShaderConstants
		{
			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly int _BaseColor;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
			public static readonly int _ShapeOption;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
			public static readonly int _LightRange1;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
			public static readonly int _LightRange2;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
			public static readonly int _LeftFadeRange;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
			public static readonly int _RightFadeRange;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
			public static readonly int _XOffset;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
			public static readonly int _YOffset;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
			public static readonly int _Ration;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
			public static readonly int _Scale;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
			public static readonly int _LightIntensity;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
			public static readonly int _DarkIntensity;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
			public static readonly int _TotalXOffset;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
			public static readonly int _TotalYOffset;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
			public static readonly int _SrcBlend;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C")]
			public static readonly int _DstBlend;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
			public static readonly int _EnableDepthFade;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
			public static readonly int _DepthFadePosition;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
			public static readonly int _NearFadeIntensity;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
			public static readonly int _UseInvertFade;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
			public static readonly int _DepthFadeRange;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x54")]
			public static readonly int _ColorOption;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
		public struct CutsceneEffectCfg
		{
			private void SetUp()
			{
				// // Void SetUp()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetUp(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2082, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2082, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para2 = 0.0;
				//     this.xOffset = 0.0;
				//     this.rotation = 0.0;
				//     this.para1 = 1.0;
				//     this.yOffset = 0.25;
				//     this.xScale = 1.1;
				//     this.yScale = 0.5;
				//   }
				// }
				// 
			}

			private void SetDown()
			{
				// // Void SetDown()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetDown(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2083, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2083, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para1 = 0.0;
				//     this.xOffset = 0.0;
				//     this.rotation = 0.0;
				//     this.para2 = 1.0;
				//     this.yOffset = -0.25;
				//     this.xScale = 1.1;
				//     this.yScale = 0.5;
				//   }
				// }
				// 
			}

			private void SetLeft()
			{
				// // Void SetLeft()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetLeft(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2084, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2084, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para2 = 0.0;
				//     this.yOffset = 0.0;
				//     this.para1 = 1.0;
				//     this.xScale = 1.0;
				//     this.yScale = 1.0;
				//     this.xOffset = -0.27000001;
				//     this.rotation = 90.0;
				//   }
				// }
				// 
			}

			private void SetRight()
			{
				// // Void SetRight()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetRight(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2085, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2085, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para1 = 0.0;
				//     this.yOffset = 0.0;
				//     this.para2 = 1.0;
				//     this.xScale = 1.0;
				//     this.yScale = 1.0;
				//     this.xOffset = 0.27000001;
				//     this.rotation = 90.0;
				//   }
				// }
				// 
			}

			private void SetLeftUp()
			{
				// // Void SetLeftUp()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetLeftUp(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2086, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2086, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para2 = 0.0;
				//     this.para1 = 1.0;
				//     this.xOffset = -0.44999999;
				//     this.yOffset = 0.25999999;
				//     this.rotation = 45.0;
				//     this.xScale = 1.1;
				//     this.yScale = 0.5;
				//   }
				// }
				// 
			}

			private void SetLeftDown()
			{
				// // Void SetLeftDown()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetLeftDown(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2087, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2087, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para1 = 0.0;
				//     this.para2 = 1.0;
				//     this.xOffset = -0.44999999;
				//     this.yOffset = -0.25999999;
				//     this.rotation = -45.0;
				//     this.xScale = 1.1;
				//     this.yScale = 0.5;
				//   }
				// }
				// 
			}

			private void SetRightUp()
			{
				// // Void SetRightUp()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetRightUp(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2088, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2088, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para2 = 0.0;
				//     this.para1 = 1.0;
				//     this.xOffset = 0.44999999;
				//     this.yOffset = 0.25999999;
				//     this.rotation = -45.0;
				//     this.xScale = 1.1;
				//     this.yScale = 0.5;
				//   }
				// }
				// 
			}

			private void SetRightDown()
			{
				// // Void SetRightDown()
				// void HG::Rendering::Runtime::VFXPPCutsceneEffect::CutsceneEffectCfg::SetRightDown(
				//         VFXPPCutsceneEffect_CutsceneEffectCfg *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2089, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2089, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.para1 = 0.0;
				//     this.para2 = 1.0;
				//     this.xOffset = 0.44999999;
				//     this.yOffset = -0.25999999;
				//     this.rotation = 45.0;
				//     this.xScale = 1.1;
				//     this.yScale = 0.5;
				//   }
				// }
				// 
			}

			public VFXPPCutsceneEffect.CutsceneEffectCfg.Options option;

			public VFXPPCutsceneEffect.CutsceneEffectCfg.ShapeOptions shapeOption;

			[ColorUsage(true, true)]
			public Color color;

			[Range(0f, 1f)]
			public float para1;

			[Range(0f, 1f)]
			public float para2;

			[Range(0f, 0.5f)]
			public float leftFadeRange;

			[Range(0f, 0.5f)]
			public float rightFadeRange;

			[Space(10f)]
			[Range(-1f, 1f)]
			public float xOffset;

			[Range(-1f, 1f)]
			public float yOffset;

			[Range(-90f, 90f)]
			public float rotation;

			[Range(0.01f, 3f)]
			public float xScale;

			[Range(0.01f, 3f)]
			public float yScale;

			[Space(10f)]
			public bool useDepthFade;

			public float depthFadePosition;

			[Range(0f, 1f)]
			public float nearFadeIntensity;

			public bool useInvertFade;

			[Range(0f, 2f)]
			public float depthFadeRange;

			public enum Options
			{
				Light,
				Dark
			}

			public enum ShapeOptions
			{
				Squad,
				Circle
			}
		}
	}
}
