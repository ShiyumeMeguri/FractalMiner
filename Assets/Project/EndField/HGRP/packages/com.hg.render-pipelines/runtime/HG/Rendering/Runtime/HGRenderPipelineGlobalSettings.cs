using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, IVersionable<HGRenderPipelineGlobalSettings.Version>, IMigratableAsset
	{
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGRenderPipelineGlobalSettings instance
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x000025D0 File Offset: 0x000007D0
		internal VolumeProfile volumeProfile
		{
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
			set
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

		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGRenderPipelineRuntimeResources renderPipelineResources
		{
			get
			{
				// // StyleValues get_to()
				// StyleValues UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_to(
				//         ValueAnimation_1_StyleValues_ *this,
				//         MethodInfo *method)
				// {
				//   return (StyleValues)this.fields._to_k__BackingField.m_StyleValues;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000025D2 File Offset: 0x000007D2
		public string[] lightLayerNames
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x000025D2 File Offset: 0x000007D2
		public string[] prefixedLightLayerNames
		{
			get
			{
				// // String[] get_prefixedLightLayerNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedLightLayerNames(
				//         HGRenderPipelineGlobalSettings *this,
				//         MethodInfo *method)
				// {
				//   if ( this.fields.m_PrefixedLightLayerNames )
				//     return this.fields.m_PrefixedLightLayerNames;
				//   HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateRenderingLayerNames(this, 0LL);
				//   return this.fields.m_PrefixedLightLayerNames;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000025D2 File Offset: 0x000007D2
		private string[] renderingLayerNames
		{
			get
			{
				// // String[] get_renderingLayerNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerNames(
				//         HGRenderPipelineGlobalSettings *this,
				//         MethodInfo *method)
				// {
				//   if ( this.fields.m_RenderingLayerNames )
				//     return this.fields.m_RenderingLayerNames;
				//   HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateRenderingLayerNames(this, 0LL);
				//   return this.fields.m_RenderingLayerNames;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x000025D2 File Offset: 0x000007D2
		private string[] prefixedRenderingLayerNames
		{
			get
			{
				// // String[] get_prefixedRenderingLayerNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerNames(
				//         HGRenderPipelineGlobalSettings *this,
				//         MethodInfo *method)
				// {
				//   if ( this.fields.m_PrefixedRenderingLayerNames )
				//     return this.fields.m_PrefixedRenderingLayerNames;
				//   HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateRenderingLayerNames(this, 0LL);
				//   return this.fields.m_PrefixedRenderingLayerNames;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000025D2 File Offset: 0x000007D2
		public string[] renderingLayerMaskNames
		{
			get
			{
				// // String[] get_renderingLayerMaskNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerMaskNames(
				//         HGRenderPipelineGlobalSettings *this,
				//         MethodInfo *method)
				// {
				//   return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_renderingLayerNames(this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x000025D2 File Offset: 0x000007D2
		public string[] prefixedRenderingLayerMaskNames
		{
			get
			{
				// // String[] get_prefixedRenderingLayerMaskNames()
				// String__Array *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerMaskNames(
				//         HGRenderPipelineGlobalSettings *this,
				//         MethodInfo *method)
				// {
				//   return HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_prefixedRenderingLayerNames(this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGTAAUSettings desktopTAAUSettings
		{
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
		}

		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGTAAUSettings mobileTAAUSettings
		{
			get
			{
				// // Variable`1[Beyond.Gameplay.AI.AIEntity] get_varRef()
				// Variable_1_Beyond_Gameplay_AI_AIEntity_ *NodeCanvas::Framework::ExposedParameter<Beyond::Gameplay::AI::AIEntity>::get_varRef(
				//         ExposedParameter_1_Beyond_Gameplay_AI_AIEntity_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._varRef_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00002B30 File Offset: 0x00000D30
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x000025D0 File Offset: 0x000007D0
		private HGRenderPipelineGlobalSettings.Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGRenderPipelineGlobalSettings.Version>.version
		{
			get
			{
				// // P3dPaintable+ActivationType get_Activation()
				// P3dPaintable_ActivationType__Enum PaintIn3D::P3dPaintable::get_Activation(P3dPaintable *this, MethodInfo *method)
				// {
				//   return this.fields.activation;
				// }
				// 
				return HGRenderPipelineGlobalSettings.Version.First;
			}
			set
			{
				// // Void set_Activation(P3dPaintable+ActivationType)
				// void PaintIn3D::P3dPaintable::set_Activation(
				//         P3dPaintable *this,
				//         P3dPaintable_ActivationType__Enum value,
				//         MethodInfo *method)
				// {
				//   this.fields.activation = value;
				// }
				// 
			}
		}

		public HGRenderPipelineGlobalSettings()
		{
			// // HGRenderPipelineGlobalSettings()
			// void HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::HGRenderPipelineGlobalSettings(
			//         HGRenderPipelineGlobalSettings *this,
			//         MethodInfo *method)
			// {
			//   BitArray128 *v3; // rax
			//   uint64_t data1; // xmm0_8
			//   BitArray128 *v5; // rax
			//   uint64_t v6; // xmm0_8
			//   BitArray128 *v7; // rax
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   __int64 v9; // rcx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   uint64_t v12; // xmm0_8
			//   struct HGRenderPipelineGlobalSettings__Class *v13; // rax
			//   String__Array *k_DefaultLightLayerNames; // rax
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   String__Array *v17; // rax
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   String__Array *v20; // rax
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   String__Array *v23; // rax
			//   PassConstructorID__Enum__Array *v24; // r8
			//   HGCamera *v25; // r9
			//   String__Array *v26; // rax
			//   PassConstructorID__Enum__Array *v27; // r8
			//   HGCamera *v28; // r9
			//   String__Array *v29; // rax
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   String__Array *v32; // rax
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   String__Array *v35; // rax
			//   HGRenderPathBase_HGRenderPathResources *v36; // rdx
			//   PassConstructorID__Enum__Array *v37; // r8
			//   HGCamera *v38; // r9
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   PassConstructorID__Enum__Array *v40; // r8
			//   HGCamera *v41; // r9
			//   FrameSettings v42; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDA48 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::Version>);
			//     byte_18D8EDA48 = 1;
			//   }
			//   v3 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultCamera(&v42, 0LL);
			//   data1 = v3[1].data1;
			//   this.fields.m_RenderingPathDefaultCameraFrameSettings.bitDatas = *v3;
			//   *(_QWORD *)&this.fields.m_RenderingPathDefaultCameraFrameSettings.materialQuality = data1;
			//   v5 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultCustomOrBakeReflectionProbe(&v42, 0LL);
			//   v6 = v5[1].data1;
			//   this.fields.m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings.bitDatas = *v5;
			//   *(_QWORD *)&this.fields.m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings.materialQuality = v6;
			//   v7 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultRealtimeReflectionProbe(&v42, 0LL);
			//   v12 = v7[1].data1;
			//   this.fields.m_RenderingPathDefaultRealtimeReflectionFrameSettings.bitDatas = *v7;
			//   *(_QWORD *)&this.fields.m_RenderingPathDefaultRealtimeReflectionFrameSettings.materialQuality = v12;
			//   v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings, v8);
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   }
			//   k_DefaultLightLayerNames = v13.static_fields.k_DefaultLightLayerNames;
			//   if ( !k_DefaultLightLayerNames )
			// LABEL_6:
			//     sub_180B536AC(v9, v8);
			//   if ( !k_DefaultLightLayerNames.max_length.size )
			//     goto LABEL_23;
			//   this.fields.lightLayerName0 = k_DefaultLightLayerNames.vector[0];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName0,
			//     v8,
			//     v10,
			//     v11,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v16 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v17 )
			//     goto LABEL_6;
			//   if ( v17.max_length.size <= 1u )
			//     goto LABEL_23;
			//   this.fields.lightLayerName1 = v17.vector[1];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName1,
			//     v8,
			//     v15,
			//     v16,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v19 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v20 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v20 )
			//     goto LABEL_6;
			//   if ( v20.max_length.size <= 2u )
			//     goto LABEL_23;
			//   this.fields.lightLayerName2 = v20.vector[2];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName2,
			//     v8,
			//     v18,
			//     v19,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v22 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v23 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v23 )
			//     goto LABEL_6;
			//   if ( v23.max_length.size <= 3u )
			//     goto LABEL_23;
			//   this.fields.lightLayerName3 = v23.vector[3];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName3,
			//     v8,
			//     v21,
			//     v22,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v25 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v26 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v26 )
			//     goto LABEL_6;
			//   if ( v26.max_length.size <= 4u )
			//     goto LABEL_23;
			//   this.fields.lightLayerName4 = v26.vector[4];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName4,
			//     v8,
			//     v24,
			//     v25,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v28 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v29 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v29 )
			//     goto LABEL_6;
			//   if ( v29.max_length.size <= 5u )
			//     goto LABEL_23;
			//   this.fields.lightLayerName5 = v29.vector[5];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName5,
			//     v8,
			//     v27,
			//     v28,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v31 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v32 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v32 )
			//     goto LABEL_6;
			//   if ( v32.max_length.size <= 6u )
			//     goto LABEL_23;
			//   this.fields.lightLayerName6 = v32.vector[6];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName6,
			//     v8,
			//     v30,
			//     v31,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   v34 = (HGCamera *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//   v35 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields.k_DefaultLightLayerNames;
			//   if ( !v35 )
			//     goto LABEL_6;
			//   if ( v35.max_length.size <= 7u )
			// LABEL_23:
			//     sub_180070270(v9, v8);
			//   this.fields.lightLayerName7 = v35.vector[7];
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.lightLayerName7,
			//     v8,
			//     v33,
			//     v34,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   this.fields.m_desktopTAAUSettings = HG::Rendering::Runtime::HGTAAUSettings::DefaultTAAUSettings(0LL);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_desktopTAAUSettings,
			//     v36,
			//     v37,
			//     v38,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   this.fields.m_mobileTAAUSettings = HG::Rendering::Runtime::HGTAAUSettings::DefaultTAAUSettings(0LL);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_mobileTAAUSettings,
			//     v39,
			//     v40,
			//     v41,
			//     (MethodInfo *)v42.bitDatas.data1,
			//     (MethodInfo *)v42.bitDatas.data2);
			//   this.fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::Version>);
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public static void UpdateGraphicsSettings(HGRenderPipelineGlobalSettings newSettings)
		{
			// // Void UpdateGraphicsSettings(HGRenderPipelineGlobalSettings)
			// void HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::UpdateGraphicsSettings(
			//         HGRenderPipelineGlobalSettings *newSettings,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGRenderPipelineGlobalSettings__Class *v4; // rax
			//   Object_1 *cachedInstance; // rdi
			//   __int64 v6; // rdx
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   struct HGRenderPipelineGlobalSettings__Class *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   MethodInfo *v14; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v15; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDA46 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::GraphicsSettings::RegisterRenderPipelineSettings<HG::Rendering::Runtime::HGRenderPipeline>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::GraphicsSettings::UnregisterRenderPipelineSettings<HG::Rendering::Runtime::HGRenderPipeline>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDA46 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2480, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2480, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)newSettings, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//     }
			//     cachedInstance = (Object_1 *)v4.static_fields.cachedInstance;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)newSettings, cachedInstance, 0LL) )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//       if ( UnityEngine::Object::op_Inequality((Object_1 *)newSettings, 0LL, 0LL) )
			//         UnityEngine::Rendering::GraphicsSettings::RegisterRenderPipelineSettings<System::Object>(
			//           (RenderPipelineGlobalSettings *)newSettings,
			//           MethodInfo::UnityEngine::Rendering::GraphicsSettings::RegisterRenderPipelineSettings<HG::Rendering::Runtime::HGRenderPipeline>);
			//       else
			//         UnityEngine::Rendering::GraphicsSettings::UnregisterRenderPipelineSettings<System::Object>(MethodInfo::UnityEngine::Rendering::GraphicsSettings::UnregisterRenderPipelineSettings<HG::Rendering::Runtime::HGRenderPipeline>);
			//       v10 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings, v7);
			//         v10 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings;
			//       }
			//       v10.static_fields.cachedInstance = newSettings;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings.static_fields,
			//         v7,
			//         v8,
			//         v9,
			//         v14,
			//         v15);
			//     }
			//   }
			// }
			// 
		}

		internal Volume GetOrCreateDefaultVolume()
		{
			return null;
		}

		internal VolumeProfile GetOrCreateDefaultVolumeProfile()
		{
			// // VolumeProfile GetOrCreateDefaultVolumeProfile()
			// VolumeProfile *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetOrCreateDefaultVolumeProfile(
			//         HGRenderPipelineGlobalSettings *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(560, 0LL) )
			//     return this.fields.m_DefaultVolumeProfile;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(560, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_218(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		internal ref FrameSettings GetDefaultFrameSettings(FrameSettingsRenderType type)
		{
			// // FrameSettings& GetDefaultFrameSettings(FrameSettingsRenderType)
			// // local variable allocation has failed, the output may be wrong!
			// FrameSettings *HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings(
			//         HGRenderPipelineGlobalSettings *this,
			//         FrameSettingsRenderType__Enum type,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int32 v11; // ebx
			//   __int64 v12; // rax
			//   SystemException *v13; // rbx
			//   String *v14; // rax
			//   __int64 v15; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&type);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size <= 644 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   v9 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			// LABEL_9:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( v9.max_length.size <= 0x284u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( v9[18].klass )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(644, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_240(Patch, (Object *)this, type, 0LL);
			//   }
			// LABEL_7:
			//   if ( type == FrameSettingsRenderType__Enum_Camera )
			//     return &this.fields.m_RenderingPathDefaultCameraFrameSettings;
			//   v11 = type - 1;
			//   if ( !v11 )
			//     return &this.fields.m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings;
			//   if ( v11 != 1 )
			//   {
			//     v12 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//     v13 = (SystemException *)sub_180004920(v12);
			//     if ( v13 )
			//     {
			//       v14 = (String *)sub_18003C530(&off_18D4F7FD8);
			//       System::SystemException::SystemException(v13, v14, 0LL);
			//       v13.fields._._HResult = -2147024809;
			//       v15 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings);
			//       sub_18000F7C0(v13, v15);
			//     }
			//     goto LABEL_9;
			//   }
			//   return &this.fields.m_RenderingPathDefaultRealtimeReflectionFrameSettings;
			// }
			// 
			return null;
		}

		internal void UpdateRenderingLayerNames()
		{
		}

		internal void ResetRenderingLayerNames(bool lightLayers)
		{
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static HGRenderPipelineGlobalSettings cachedInstance;

		private Volume s_DefaultVolume;

		[SerializeField]
		[FormerlySerializedAs("m_VolumeProfileDefault")]
		private VolumeProfile m_DefaultVolumeProfile;

		[SerializeField]
		private FrameSettings m_RenderingPathDefaultCameraFrameSettings;

		[SerializeField]
		private FrameSettings m_RenderingPathDefaultBakedOrCustomReflectionFrameSettings;

		[SerializeField]
		private FrameSettings m_RenderingPathDefaultRealtimeReflectionFrameSettings;

		[SerializeField]
		private HGRenderPipelineRuntimeResources m_RenderPipelineResources;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly string[] k_DefaultLightLayerNames;

		public string lightLayerName0;

		public string lightLayerName1;

		public string lightLayerName2;

		public string lightLayerName3;

		public string lightLayerName4;

		public string lightLayerName5;

		public string lightLayerName6;

		public string lightLayerName7;

		[NonSerialized]
		private string[] m_LightLayerNames;

		[NonSerialized]
		private string[] m_PrefixedLightLayerNames;

		[NonSerialized]
		private string[] m_RenderingLayerNames;

		[NonSerialized]
		private string[] m_PrefixedRenderingLayerNames;

		[SerializeField]
		internal ShaderVariantLogLevel shaderVariantLogLevel;

		[SerializeField]
		internal LensAttenuationMode lensAttenuationMode;

		[SerializeField]
		internal bool rendererListCulling;

		[SerializeField]
		private HGTAAUSettings m_desktopTAAUSettings;

		[SerializeField]
		private HGTAAUSettings m_mobileTAAUSettings;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static HGRenderPipelineGlobalSettings.Version[] skipedStepWhenCreatedFromHGRPAsset;

		[SerializeField]
		private HGRenderPipelineGlobalSettings.Version m_Version;

		private enum Version
		{
			First,
			UpdateMSAA,
			UpdateLensFlare,
			MovedSupportRuntimeDebugDisplayToGlobalSettings
		}
	}
}
