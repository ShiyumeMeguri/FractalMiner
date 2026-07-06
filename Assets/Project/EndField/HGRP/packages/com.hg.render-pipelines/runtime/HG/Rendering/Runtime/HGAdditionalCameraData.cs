using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class HGAdditionalCameraData : MonoBehaviour, IFrameSettingsHistoryContainer, IDebugData, IAdditionalData, IVersionable<HGAdditionalCameraData.Version>
	{
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool hasCustomRender
		{
			get
			{
				// // Boolean get_hasCustomRender()
				// bool HG::Rendering::Runtime::HGAdditionalCameraData::get_hasCustomRender(
				//         HGAdditionalCameraData *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.customRender != 0LL;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000025D2 File Offset: 0x000007D2
		public ref FrameSettings renderingPathCustomFrameSettings
		{
			get
			{
				// // FrameSettings& get_renderingPathCustomFrameSettings()
				// FrameSettings *HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(
				//         HGAdditionalCameraData *this,
				//         MethodInfo *method)
				// {
				//   return &this.fields.m_RenderingPathCustomFrameSettings;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x000025D8 File Offset: 0x000007D8
		private bool HG.Rendering.Runtime.IFrameSettingsHistoryContainer.hasCustomFrameSettings
		{
			get
			{
				// // Boolean get_Writable()
				// bool Newtonsoft::Json::Serialization::JsonProperty::get_Writable(JsonProperty *this, MethodInfo *method)
				// {
				//   return this.fields._Writable_k__BackingField;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x000025D2 File Offset: 0x000007D2
		private FrameSettingsOverrideMask HG.Rendering.Runtime.IFrameSettingsHistoryContainer.frameSettingsMask
		{
			get
			{
				// // FrameSettingsOverrideMask HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_frameSettingsMask()
				// FrameSettingsOverrideMask *HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_frameSettingsMask(
				//         FrameSettingsOverrideMask *__return_ptr retstr,
				//         HGAdditionalCameraData *this,
				//         MethodInfo *method)
				// {
				//   FrameSettingsOverrideMask *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.renderingPathCustomFrameSettingsOverrideMask;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x000025D2 File Offset: 0x000007D2
		private FrameSettings HG.Rendering.Runtime.IFrameSettingsHistoryContainer.frameSettings
		{
			get
			{
				// // InputActionProperty get_backButtonAction()
				// InputActionProperty *UnityEngine::InputSystem::UI::VirtualMouseInput::get_backButtonAction(
				//         InputActionProperty *__return_ptr retstr,
				//         VirtualMouseInput *this,
				//         MethodInfo *method)
				// {
				//   InputActionProperty *result; // rax
				//   InputActionReference *m_Reference; // xmm1_8
				// 
				//   result = retstr;
				//   m_Reference = this.fields.m_BackButtonAction.m_Reference;
				//   *(_OWORD *)&retstr.m_UseReference = *(_OWORD *)&this.fields.m_BackButtonAction.m_UseReference;
				//   retstr.m_Reference = m_Reference;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x000025D0 File Offset: 0x000007D0
		private FrameSettingsHistory HG.Rendering.Runtime.IFrameSettingsHistoryContainer.frameSettingsHistory
		{
			get
			{
				// // FrameSettingsHistory HG.Rendering.Runtime.IFrameSettingsHistoryContainer.get_frameSettingsHistory()
				// FrameSettingsHistory *HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_frameSettingsHistory(
				//         FrameSettingsHistory *__return_ptr retstr,
				//         HGAdditionalCameraData *this,
				//         MethodInfo *method)
				// {
				//   FrameSettingsHistory *result; // rax
				//   __int128 v4; // xmm1
				//   FrameSettingsOverrideMask customMask; // xmm0
				//   BitArray128 bitDatas; // xmm1
				//   __int128 v7; // xmm0
				//   __int128 v8; // xmm1
				// 
				//   result = retstr;
				//   v4 = *(_OWORD *)&this.fields.m_RenderingPathHistory.overridden.bitDatas.data2;
				//   *(_OWORD *)&retstr.defaultType = *(_OWORD *)&this.fields.m_RenderingPathHistory.defaultType;
				//   customMask = this.fields.m_RenderingPathHistory.customMask;
				//   *(_OWORD *)&retstr.overridden.bitDatas.data2 = v4;
				//   bitDatas = this.fields.m_RenderingPathHistory.sanitazed.bitDatas;
				//   retstr.customMask = customMask;
				//   v7 = *(_OWORD *)&this.fields.m_RenderingPathHistory.sanitazed.materialQuality;
				//   retstr.sanitazed.bitDatas = bitDatas;
				//   v8 = *(_OWORD *)&this.fields.m_RenderingPathHistory.debug.bitDatas.data2;
				//   *(_OWORD *)&retstr.sanitazed.materialQuality = v7;
				//   *(_QWORD *)&v7 = *(_QWORD *)&this.fields.m_RenderingPathHistory.hasDebug;
				//   *(_OWORD *)&retstr.debug.bitDatas.data2 = v8;
				//   *(_QWORD *)&retstr.hasDebug = v7;
				//   return result;
				// }
				// 
				return null;
			}
			set
			{
				// // Void HG.Rendering.Runtime.IFrameSettingsHistoryContainer.set_frameSettingsHistory(FrameSettingsHistory)
				// void HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_set_frameSettingsHistory(
				//         HGAdditionalCameraData *this,
				//         FrameSettingsHistory *value,
				//         MethodInfo *method)
				// {
				//   __int128 v3; // xmm1
				//   FrameSettingsOverrideMask customMask; // xmm0
				//   BitArray128 bitDatas; // xmm1
				//   __int128 v6; // xmm0
				//   __int128 v7; // xmm1
				// 
				//   v3 = *(_OWORD *)&value.overridden.bitDatas.data2;
				//   *(_OWORD *)&this.fields.m_RenderingPathHistory.defaultType = *(_OWORD *)&value.defaultType;
				//   customMask = value.customMask;
				//   *(_OWORD *)&this.fields.m_RenderingPathHistory.overridden.bitDatas.data2 = v3;
				//   bitDatas = value.sanitazed.bitDatas;
				//   this.fields.m_RenderingPathHistory.customMask = customMask;
				//   v6 = *(_OWORD *)&value.sanitazed.materialQuality;
				//   this.fields.m_RenderingPathHistory.sanitazed.bitDatas = bitDatas;
				//   v7 = *(_OWORD *)&value.debug.bitDatas.data2;
				//   *(_OWORD *)&this.fields.m_RenderingPathHistory.sanitazed.materialQuality = v6;
				//   *(_QWORD *)&v6 = *(_QWORD *)&value.hasDebug;
				//   *(_OWORD *)&this.fields.m_RenderingPathHistory.debug.bitDatas.data2 = v7;
				//   *(_QWORD *)&this.fields.m_RenderingPathHistory.hasDebug = v6;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000025D2 File Offset: 0x000007D2
		private string HG.Rendering.Runtime.IFrameSettingsHistoryContainer.panelName
		{
			get
			{
				// // MeshGenerationContext get_meshGenerationContext()
				// MeshGenerationContext *UnityEngine::UIElements::UIR::Implementation::UIRStylePainter::get_meshGenerationContext(
				//         UIRStylePainter *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._meshGenerationContext_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool isEditorCameraPreview
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_isEditorCameraPreview()
				// bool HG::Rendering::Runtime::HGAdditionalCameraData::get_isEditorCameraPreview(
				//         HGAdditionalCameraData *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isEditorCameraPreview_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			internal set
			{
				// // Void set_isEditorCameraPreview(Boolean)
				// void HG::Rendering::Runtime::HGAdditionalCameraData::set_isEditorCameraPreview(
				//         HGAdditionalCameraData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._isEditorCameraPreview_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002A10 File Offset: 0x00000C10
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x000025D0 File Offset: 0x000007D0
		private HGAdditionalCameraData.Version HG.Rendering.Runtime.IVersionable<HG.Rendering.Runtime.HGAdditionalCameraData.Version>.version
		{
			get
			{
				// // Int32 get_touchId()
				// int32_t UnityEngine::InputSystem::UI::ExtendedPointerEventData::get_touchId(
				//         ExtendedPointerEventData *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._touchId_k__BackingField;
				// }
				// 
				return HGAdditionalCameraData.Version.None;
			}
			set
			{
				// // Void set_touchId(Int32)
				// void UnityEngine::InputSystem::UI::ExtendedPointerEventData::set_touchId(
				//         ExtendedPointerEventData *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._touchId_k__BackingField = value;
				// }
				// 
			}
		}

		// (add) Token: 0x06000D22 RID: 3362 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06000D23 RID: 3363 RVA: 0x000025D0 File Offset: 0x000007D0
		public event Action<ScriptableRenderContext, HGCamera> customRender
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// (add) Token: 0x06000D24 RID: 3364 RVA: 0x000025D0 File Offset: 0x000007D0
		// (remove) Token: 0x06000D25 RID: 3365 RVA: 0x000025D0 File Offset: 0x000007D0
		public event HGAdditionalCameraData.RequestAccessDelegate requestGraphicsBuffer
		{
			[CompilerGenerated]
			add
			{
				// // Void add_requestGraphicsBuffer(HGAdditionalCameraData+RequestAccessDelegate)
				// void HG::Rendering::Runtime::HGAdditionalCameraData::add_requestGraphicsBuffer(
				//         HGAdditionalCameraData *this,
				//         HGAdditionalCameraData_RequestAccessDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *requestGraphicsBuffer; // rdi
				//   Delegate *v6; // rbp
				//   Delegate *v7; // rax
				// 
				//   if ( !byte_18D91948B )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::RequestAccessDelegate);
				//     byte_18D91948B = 1;
				//   }
				//   requestGraphicsBuffer = (Delegate *)this.fields.requestGraphicsBuffer;
				//   do
				//   {
				//     v6 = requestGraphicsBuffer;
				//     v7 = System::Delegate::Combine(requestGraphicsBuffer, (Delegate *)value, 0LL);
				//     if ( v7 )
				//     {
				//       if ( (struct HGAdditionalCameraData_RequestAccessDelegate__Class *)v7.klass != TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::RequestAccessDelegate )
				//         sub_1802DC21C(v7, TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::RequestAccessDelegate);
				//     }
				//     requestGraphicsBuffer = (Delegate *)sub_180011DB0(&this.fields.requestGraphicsBuffer, v7, requestGraphicsBuffer);
				//   }
				//   while ( requestGraphicsBuffer != v6 );
				// }
				// 
			}
			[CompilerGenerated]
			remove
			{
				// // Void remove_requestGraphicsBuffer(HGAdditionalCameraData+RequestAccessDelegate)
				// void HG::Rendering::Runtime::HGAdditionalCameraData::remove_requestGraphicsBuffer(
				//         HGAdditionalCameraData *this,
				//         HGAdditionalCameraData_RequestAccessDelegate *value,
				//         MethodInfo *method)
				// {
				//   Delegate *requestGraphicsBuffer; // rdi
				//   Delegate *v6; // rbp
				//   Delegate *v7; // rax
				// 
				//   if ( !byte_18D91948C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::RequestAccessDelegate);
				//     byte_18D91948C = 1;
				//   }
				//   requestGraphicsBuffer = (Delegate *)this.fields.requestGraphicsBuffer;
				//   do
				//   {
				//     v6 = requestGraphicsBuffer;
				//     v7 = System::Delegate::Remove(requestGraphicsBuffer, (Delegate *)value, 0LL);
				//     if ( v7 )
				//     {
				//       if ( (struct HGAdditionalCameraData_RequestAccessDelegate__Class *)v7.klass != TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::RequestAccessDelegate )
				//         sub_1802DC21C(v7, TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::RequestAccessDelegate);
				//     }
				//     requestGraphicsBuffer = (Delegate *)sub_180011DB0(&this.fields.requestGraphicsBuffer, v7, requestGraphicsBuffer);
				//   }
				//   while ( requestGraphicsBuffer != v6 );
				// }
				// 
			}
		}

		public HGAdditionalCameraData()
		{
			// // HGAdditionalCameraData()
			// void HG::Rendering::Runtime::HGAdditionalCameraData::HGAdditionalCameraData(
			//         HGAdditionalCameraData *this,
			//         MethodInfo *method)
			// {
			//   Vector3Int *v2; // r8
			//   ITilemap *v3; // r9
			//   Color v5; // xmm1
			//   HGPhysicalCamera *Defaults; // rax
			//   __int128 v7; // xmm0
			//   float m_Anamorphism; // ecx
			//   __int128 v9; // xmm1
			//   BitArray128 *v10; // rax
			//   HGAdditionalCameraData_NonObliqueProjectionGetter *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   HGAdditionalCameraData_NonObliqueProjectionGetter *v14; // rdi
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   _BYTE v18[100]; // [rsp+20h] [rbp-A8h] BYREF
			//   HGPhysicalCamera v19; // [rsp+90h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8ED9F2 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::GeometryUtils::CalculateProjectionMatrix);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGAdditionalCameraData::Version>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::NonObliqueProjectionGetter);
			//     byte_18D8ED9F2 = 1;
			//   }
			//   v5 = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                  (TileAnimationData *)&v19,
			//                  (TileBase *)method,
			//                  v2,
			//                  v3,
			//                  *(MethodInfo **)v18);
			//   this.fields.clearDepth = 1;
			//   this.fields.backgroundColorHDR = v5;
			//   this.fields.volumeLayerMask.m_Mask = -1;
			//   this.fields.hgRenderPath = 3;
			//   Defaults = HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults(&v19, 0LL);
			//   v7 = *(_OWORD *)&Defaults.m_Iso;
			//   m_Anamorphism = Defaults.m_Anamorphism;
			//   v9 = *(_OWORD *)&Defaults.m_BladeCount;
			//   this.fields.cullingFOVValue = 50.0;
			//   *(_OWORD *)&this.fields.physicalParameters.m_Iso = v7;
			//   *(_OWORD *)&this.fields.physicalParameters.m_BladeCount = v9;
			//   this.fields.physicalParameters.m_Anamorphism = m_Anamorphism;
			//   this.fields.probeLayerMask.m_Mask = -1;
			//   this.fields.probeCustomFixedExposure = 1.0;
			//   this.fields.deExposureMultiplier = 1.0;
			//   v10 = (BitArray128 *)HG::Rendering::Runtime::FrameSettings::NewDefaultCamera((FrameSettings *)&v19, 0LL);
			//   *(_QWORD *)&v7 = v10[1].data1;
			//   this.fields.m_RenderingPathCustomFrameSettings.bitDatas = *v10;
			//   memset(v18, 0, sizeof(v18));
			//   *(_QWORD *)&this.fields.m_RenderingPathCustomFrameSettings.materialQuality = v7;
			//   *(_OWORD *)&this.fields.m_RenderingPathHistory.defaultType = *(_OWORD *)v18;
			//   *(_OWORD *)&this.fields.m_RenderingPathHistory.overridden.bitDatas.data2 = *(_OWORD *)&v18[16];
			//   this.fields.m_RenderingPathHistory.customMask = *(FrameSettingsOverrideMask *)&v18[32];
			//   this.fields.m_RenderingPathHistory.sanitazed.bitDatas = *(BitArray128 *)&v18[48];
			//   *(_OWORD *)&this.fields.m_RenderingPathHistory.sanitazed.materialQuality = *(_OWORD *)&v18[64];
			//   *(_OWORD *)&this.fields.m_RenderingPathHistory.debug.bitDatas.data2 = *(_OWORD *)&v18[80];
			//   *(_QWORD *)&this.fields.m_RenderingPathHistory.hasDebug = 0LL;
			//   v11 = (HGAdditionalCameraData_NonObliqueProjectionGetter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData::NonObliqueProjectionGetter);
			//   v14 = v11;
			//   if ( !v11 )
			//     sub_180B536AC(v13, v12);
			//   HG::Rendering::Runtime::HGAdditionalCameraData::NonObliqueProjectionGetter::NonObliqueProjectionGetter(
			//     v11,
			//     0LL,
			//     MethodInfo::HG::Rendering::Runtime::GeometryUtils::CalculateProjectionMatrix,
			//     0LL);
			//   this.fields.nonObliqueProjectionGetter = v14;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.nonObliqueProjectionGetter,
			//     v15,
			//     v16,
			//     v17,
			//     *(String__Array **)v18,
			//     *(String **)&v18[8],
			//     *(MethodInfo **)&v18[16]);
			//   this.fields.m_Version = HG::Rendering::Runtime::MigrationDescription::LastVersion<System::Int32Enum>(MethodInfo::HG::Rendering::Runtime::MigrationDescription::LastVersion<HG::Rendering::Runtime::HGAdditionalCameraData::Version>);
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private Action UnityEngine.Rendering.IDebugData.GetReset()
		{
			// // Action UnityEngine.Rendering.IDebugData.GetReset()
			// Action *HG::Rendering::Runtime::HGAdditionalCameraData::UnityEngine_Rendering_IDebugData_GetReset(
			//         HGAdditionalCameraData *this,
			//         MethodInfo *method)
			// {
			//   Action *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91948D )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::_UnityEngine_Rendering_IDebugData_GetReset_b__56_0);
			//     byte_18D91948D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2292, 0LL) )
			//   {
			//     v3 = (Action *)sub_180004920(TypeInfo::System::Action);
			//     v6 = v3;
			//     if ( v3 )
			//     {
			//       System::Action::Action(
			//         v3,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::HGAdditionalCameraData::_UnityEngine_Rendering_IDebugData_GetReset_b__56_0,
			//         0LL);
			//       return v6;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2292, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_829(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void CopyTo(HGAdditionalCameraData data)
		{
		}

		public Matrix4x4 GetNonObliqueProjection(Camera camera)
		{
			// // Matrix4x4 GetNonObliqueProjection(Camera)
			// Matrix4x4 *HG::Rendering::Runtime::HGAdditionalCameraData::GetNonObliqueProjection(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGAdditionalCameraData *this,
			//         Camera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rcx
			//   HGAdditionalCameraData_NonObliqueProjectionGetter *nonObliqueProjectionGetter; // rdx
			//   Matrix4x4 *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   Matrix4x4 *result; // rax
			//   Matrix4x4 v15; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2296, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2296, 0LL);
			//     if ( Patch )
			//     {
			//       v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_830(&v15, Patch, (Object *)this, (Object *)camera, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, nonObliqueProjectionGetter);
			//   }
			//   nonObliqueProjectionGetter = this.fields.nonObliqueProjectionGetter;
			//   if ( !nonObliqueProjectionGetter )
			//     goto LABEL_5;
			//   v9 = (Matrix4x4 *)((__int64 (__fastcall *)(Matrix4x4 *, void *, Camera *, void *))nonObliqueProjectionGetter.fields._._.invoke_impl)(
			//                       &v15,
			//                       nonObliqueProjectionGetter.fields._._.method_code,
			//                       camera,
			//                       nonObliqueProjectionGetter.fields._._.method);
			// LABEL_7:
			//   v11 = *(_OWORD *)&v9.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v9.m00;
			//   v12 = *(_OWORD *)&v9.m02;
			//   *(_OWORD *)&retstr.m01 = v11;
			//   v13 = *(_OWORD *)&v9.m03;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v12;
			//   *(_OWORD *)&retstr.m03 = v13;
			//   return result;
			// }
			// 
			return null;
		}

		private void RegisterDebug()
		{
		}

		private void UnRegisterDebug()
		{
			// // Void UnRegisterDebug()
			// void HG::Rendering::Runtime::HGAdditionalCameraData::UnRegisterDebug(HGAdditionalCameraData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2298, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2298, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_IsDebugRegistered )
			//   {
			//     this.fields.m_IsDebugRegistered = 0;
			//   }
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGAdditionalCameraData::OnEnable(HGAdditionalCameraData *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Camera *m_Camera; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9F0 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::TryGetComponent<UnityEngine::Camera>);
			//     byte_18D8ED9F0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2299, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2299, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( UnityEngine::Component::TryGetComponent<System::Object>(
			//               (Component *)this,
			//               (Object **)&this.fields.m_Camera,
			//               MethodInfo::UnityEngine::Component::TryGetComponent<UnityEngine::Camera>) )
			//   {
			//     m_Camera = this.fields.m_Camera;
			//     if ( m_Camera )
			//     {
			//       UnityEngine::Camera::set_allowMSAA(m_Camera, 0, 0LL);
			//       m_Camera = this.fields.m_Camera;
			//       if ( m_Camera )
			//       {
			//         UnityEngine::Camera::set_allowHDR(m_Camera, 0, 0LL);
			//         HG::Rendering::Runtime::HGAdditionalCameraData::RegisterDebug(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_Camera, v3);
			//   }
			// }
			// 
		}

		private void UpdateDebugCameraName()
		{
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGAdditionalCameraData::OnDisable(HGAdditionalCameraData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2302, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2302, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGAdditionalCameraData::UnRegisterDebug(this, 0LL);
			//   }
			// }
			// 
		}

		internal static void InitDefaultHGAdditionalCameraData(HGAdditionalCameraData cameraData)
		{
			// // Void InitDefaultHGAdditionalCameraData(HGAdditionalCameraData)
			// void HG::Rendering::Runtime::HGAdditionalCameraData::InitDefaultHGAdditionalCameraData(
			//         HGAdditionalCameraData *cameraData,
			//         MethodInfo *method)
			// {
			//   int32_t v2; // ebx
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   GameObject *gameObject; // rax
			//   Object *v7; // rax
			//   Camera *v8; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v2 = 0;
			//   if ( !byte_18D91948F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Camera>);
			//     byte_18D91948F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2303, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2303, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)cameraData, 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v5, v4);
			//   }
			//   if ( !cameraData )
			//     goto LABEL_11;
			//   gameObject = UnityEngine::Component::get_gameObject((Component *)cameraData, 0LL);
			//   if ( !gameObject )
			//     goto LABEL_11;
			//   v7 = UnityEngine::GameObject::GetComponent<System::Object>(
			//          gameObject,
			//          MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Camera>);
			//   v8 = (Camera *)v7;
			//   if ( !v7 )
			//     goto LABEL_11;
			//   cameraData.fields.clearDepth = UnityEngine::Camera::get_clearFlags((Camera *)v7, 0LL) != CameraClearFlags__Enum_Nothing;
			//   if ( UnityEngine::Camera::get_clearFlags(v8, 0LL) != CameraClearFlags__Enum_Skybox )
			//   {
			//     LOBYTE(v2) = UnityEngine::Camera::get_clearFlags(v8, 0LL) != CameraClearFlags__Enum_Color;
			//     ++v2;
			//   }
			//   cameraData.fields.clearColorMode = v2;
			// }
			// 
		}

		internal void ExecuteCustomRender(ScriptableRenderContext renderContext, HGCamera hgCamera)
		{
			// // Void ExecuteCustomRender(ScriptableRenderContext, HGCamera)
			// void HG::Rendering::Runtime::HGAdditionalCameraData::ExecuteCustomRender(
			//         HGAdditionalCameraData *this,
			//         ScriptableRenderContext renderContext,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2304, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2304, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, renderContext, (Object *)hgCamera, 0LL);
			//   }
			//   else if ( this.fields.customRender )
			//   {
			//     sub_18233AF20(this.fields.customRender, renderContext.m_Ptr, hgCamera, 0LL);
			//   }
			// }
			// 
		}

		internal HGAdditionalCameraData.BufferAccessType GetBufferAccess()
		{
			// // HGAdditionalCameraData+BufferAccessType GetBufferAccess()
			// HGAdditionalCameraData_BufferAccessType__Enum HG::Rendering::Runtime::HGAdditionalCameraData::GetBufferAccess(
			//         HGAdditionalCameraData *this,
			//         MethodInfo *method)
			// {
			//   HGAdditionalCameraData_BufferAccessType__Enum v3; // ebx
			//   HGAdditionalCameraData_RequestAccessDelegate *requestGraphicsBuffer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   HGAdditionalCameraData_BufferAccessType__Enum v9; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2305, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2305, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     requestGraphicsBuffer = this.fields.requestGraphicsBuffer;
			//     v9 = 0;
			//     if ( requestGraphicsBuffer )
			//     {
			//       ((void (__fastcall *)(void *, HGAdditionalCameraData_BufferAccessType__Enum *, void *))requestGraphicsBuffer.fields._._.invoke_impl)(
			//         requestGraphicsBuffer.fields._._.method_code,
			//         &v9,
			//         requestGraphicsBuffer.fields._._.method);
			//       return v9;
			//     }
			//     return v3;
			//   }
			// }
			// 
			return (HGAdditionalCameraData.BufferAccessType)0;
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::HGAdditionalCameraData::Awake(HGAdditionalCameraData *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGAdditionalCameraData__Class *v4; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   MigrationDescription_2_System_Int32Enum_System_Object_ v8; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8ED9F1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MigrationDescription<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>::Migrate);
			//     byte_18D8ED9F1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2306, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2306, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGAdditionalCameraData;
			//     }
			//     v8.Steps = (MigrationStep_2_System_Int32Enum_System_Object___Array *)v4.static_fields.k_Migration.Steps;
			//     HG::Rendering::Runtime::MigrationDescription<System::Int32Enum,System::Object>::Migrate(
			//       &v8,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::Runtime::MigrationDescription<HG::Rendering::Runtime::HGAdditionalCameraData::Version,HG::Rendering::Runtime::HGAdditionalCameraData>::Migrate);
			//   }
			// }
			// 
		}

		[ExcludeCopy]
		private Camera m_Camera;

		public HGAdditionalCameraData.ClearColorMode clearColorMode;

		[ColorUsage(true, true)]
		public Color backgroundColorHDR;

		public bool clearDepth;

		public bool enableAlpha;

		[Tooltip("LayerMask HGRP uses for Volume interpolation for this Camera.")]
		public LayerMask volumeLayerMask;

		public Transform volumeAnchorOverride;

		public HGAdditionalCameraData.AntialiasingMode antialiasing;

		public HGRenderPath hgRenderPath;

		[ValueCopy]
		public HGPhysicalCamera physicalParameters;

		public HGAdditionalCameraData.FlipYMode flipYMode;

		[Tooltip("If the fov value for culling should get override.")]
		public bool overrideCullingFOV;

		public float cullingFOVValue;

		[Tooltip("Skips rendering settings to directly render in fullscreen (Useful for video).")]
		public bool fullscreenPassthrough;

		[Tooltip("Allows dynamic resolution on buffers linked to this camera.")]
		public bool allowDynamicResolution;

		[Tooltip("Allows you to override the default settings for this camera.")]
		public bool customRenderingSettings;

		public bool invertFaceCulling;

		public LayerMask probeLayerMask;

		public bool hasPersistentHistory;

		public float materialMipBias;

		internal float probeCustomFixedExposure;

		[ExcludeCopy]
		internal float deExposureMultiplier;

		[SerializeField]
		[FormerlySerializedAs("renderingPathCustomFrameSettings")]
		private FrameSettings m_RenderingPathCustomFrameSettings;

		public FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask;

		public FrameSettingsRenderType defaultFrameSettings;

		[ExcludeCopy]
		private FrameSettingsHistory m_RenderingPathHistory;

		[ExcludeCopy]
		internal ProfilingSampler profilingSampler;

		[ExcludeCopy]
		private bool m_IsDebugRegistered;

		[ExcludeCopy]
		private string m_CameraRegisterName;

		[ExcludeCopy]
		public HGAdditionalCameraData.NonObliqueProjectionGetter nonObliqueProjectionGetter;

		[ExcludeCopy]
		[SerializeField]
		[FormerlySerializedAs("version")]
		private HGAdditionalCameraData.Version m_Version;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly MigrationDescription<HGAdditionalCameraData.Version, HGAdditionalCameraData> k_Migration;

		[SerializeField]
		[Obsolete("For Data Migration")]
		[ExcludeCopy]
		[FormerlySerializedAs("renderingPath")]
		private int m_ObsoleteRenderingPath;

		[FormerlySerializedAs("serializedFrameSettings")]
		[FormerlySerializedAs("m_FrameSettings")]
		[ExcludeCopy]
		[SerializeField]
		private ObsoleteFrameSettings m_ObsoleteFrameSettings;

		public enum FlipYMode
		{
			Automatic,
			ForceFlipY
		}

		[Flags]
		public enum BufferAccessType
		{
			Depth = 1,
			Normal = 2,
			Color = 4
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		public struct BufferAccess
		{
			internal void Reset()
			{
				// // Void Reset()
				// void HG::Rendering::Runtime::HGAdditionalCameraData::BufferAccess::Reset(
				//         HGAdditionalCameraData_BufferAccess *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2307, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2307, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_832(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     this.bufferAccess = 0;
				//   }
				// }
				// 
			}

			public void RequestAccess(HGAdditionalCameraData.BufferAccessType flags)
			{
				// // Void RequestAccess(HGAdditionalCameraData+BufferAccessType)
				// void HG::Rendering::Runtime::HGAdditionalCameraData::BufferAccess::RequestAccess(
				//         HGAdditionalCameraData_BufferAccess *this,
				//         HGAdditionalCameraData_BufferAccessType__Enum flags,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2308, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2308, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_833(Patch, this, flags, 0LL);
				//   }
				//   else
				//   {
				//     this.bufferAccess |= flags;
				//   }
				// }
				// 
			}

			internal HGAdditionalCameraData.BufferAccessType bufferAccess;
		}

		// (Invoke) Token: 0x06000D38 RID: 3384
		public delegate Matrix4x4 NonObliqueProjectionGetter(Camera camera);

		public enum ClearColorMode
		{
			Sky,
			Color,
			None
		}

		[Flags]
		public enum AntialiasingMode
		{
			[InspectorName("No Anti-aliasing")]
			None = 0,
			[InspectorName("Fast Approximate Anti-aliasing (FXAA)")]
			[Obsolete]
			FastApproximateAntialiasing = 1,
			[InspectorName("Temporal Anti-aliasing (TAA)")]
			TemporalAntialiasing = 2,
			[InspectorName("MetalFX Spatial (Metal Only)")]
			MetalFXSpatial = 4,
			[InspectorName("MetalFX Temporal (Metal Only)")]
			MetalFXTemporal = 8,
			[InspectorName("Temporal Anti-aliasing + MetalFX Spatial (Metal Only)")]
			TemporalAntialiasingWithMetalFXSpatial = 6,
			[InspectorName("MetalFX Temporal + MetalFX Spatial (Metal Only)")]
			MetalFXTemporalWithMetalFXSpatial = 12,
			[InspectorName("PSSR (PS5 Pro)")]
			PSSR = 16,
			[InspectorName("DLSS (Nvidia Only)")]
			DLSS = 32,
			[InspectorName("FSR3")]
			FSR3 = 64
		}

		public enum SMAAQualityLevel
		{
			Low,
			Medium,
			High
		}

		public enum TAAQualityLevel
		{
			Low,
			Medium,
			High
		}

		// (Invoke) Token: 0x06000D3C RID: 3388
		public delegate void RequestAccessDelegate(ref HGAdditionalCameraData.BufferAccess bufferAccess);

		protected enum Version
		{
			None,
			First,
			SeparatePassThrough,
			UpgradingFrameSettingsToStruct,
			AddAfterPostProcessFrameSetting,
			AddFrameSettingSpecularLighting,
			AddReflectionSettings,
			AddCustomPostprocessAndCustomPass,
			UpdateMSAA
		}
	}
}
