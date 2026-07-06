using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(Camera))]
	public class HGDepthOfField : MonoBehaviour
	{
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool manualEnable
		{
			get
			{
				// // Boolean get_manualEnable()
				// bool HG::Rendering::Runtime::HGDepthOfField::get_manualEnable(HGDepthOfField *this, MethodInfo *method)
				// {
				//   if ( this.fields.hgDebugCommand )
				//     return this.fields.m_manualEnable;
				//   else
				//     return this.fields.enable;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_OnlyDeltaTime(Boolean)
				// void UnityEngine::Timeline::AnimationPlayableAsset::set_OnlyDeltaTime(
				//         AnimationPlayableAsset *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_OnlyDeltaTime = value;
				// }
				// 
			}
		}

		public HGDepthOfField()
		{
			// // HGDepthOfField()
			// void HG::Rendering::Runtime::HGDepthOfField::HGDepthOfField(HGDepthOfField *this, MethodInfo *method)
			// {
			//   this.fields.focusMode = 1;
			//   this.fields.scale = 1;
			//   this.fields.nearRadius = 1.0;
			//   this.fields.farRadius = 1.0;
			//   this.fields.temporalFactor = 0.5;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public HGDepthOfFieldData GetSerializeData()
		{
			// // HGDepthOfFieldData GetSerializeData()
			// HGDepthOfFieldData *HG::Rendering::Runtime::HGDepthOfField::GetSerializeData(HGDepthOfField *this, MethodInfo *method)
			// {
			//   unsigned int focusMode; // edi
			//   unsigned int type; // esi
			//   unsigned int scale; // ebp
			//   float nearFocusStart; // xmm6_4
			//   float nearFocusEnd; // xmm7_4
			//   float nearRadius; // xmm8_4
			//   float farFocusStart; // xmm9_4
			//   float farFocusEnd; // xmm10_4
			//   float farRadius; // xmm11_4
			//   float temporalFactor; // xmm12_4
			//   HGDepthOfFieldData *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   HGDepthOfFieldData *v16; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919457 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
			//     byte_18D919457 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2225, 0LL) )
			//   {
			//     focusMode = this.fields.focusMode;
			//     type = this.fields.type;
			//     scale = this.fields.scale;
			//     nearFocusStart = this.fields.nearFocusStart;
			//     nearFocusEnd = this.fields.nearFocusEnd;
			//     nearRadius = this.fields.nearRadius;
			//     farFocusStart = this.fields.farFocusStart;
			//     farFocusEnd = this.fields.farFocusEnd;
			//     farRadius = this.fields.farRadius;
			//     temporalFactor = this.fields.temporalFactor;
			//     v13 = (HGDepthOfFieldData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
			//     v16 = v13;
			//     if ( v13 )
			//     {
			//       HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(
			//         v13,
			//         (HGDepthOfFieldFocusMode__Enum)focusMode,
			//         (HGDepthOfFieldType__Enum)type,
			//         (HGDepthOfFieldScale__Enum)scale,
			//         nearFocusStart,
			//         nearFocusEnd,
			//         nearRadius,
			//         farFocusStart,
			//         farFocusEnd,
			//         farRadius,
			//         temporalFactor,
			//         0LL);
			//       return v16;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v15, v14);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2225, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_811(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void SetSerializeData(HGDepthOfFieldData data)
		{
			// // Void SetSerializeData(HGDepthOfFieldData)
			// void HG::Rendering::Runtime::HGDepthOfField::SetSerializeData(
			//         HGDepthOfField *this,
			//         HGDepthOfFieldData *data,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2226, 0LL) )
			//   {
			//     if ( data )
			//     {
			//       this.fields.type = data.fields.type;
			//       this.fields.nearFocusStart = data.fields.nearFocusStart;
			//       this.fields.nearFocusEnd = data.fields.nearFocusEnd;
			//       this.fields.nearRadius = data.fields.nearRadius;
			//       this.fields.farFocusStart = data.fields.farFocusStart;
			//       this.fields.farFocusEnd = data.fields.farFocusEnd;
			//       this.fields.farRadius = data.fields.farRadius;
			//       this.fields.temporalFactor = data.fields.temporalFactor;
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2226, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)data,
			//     0LL);
			// }
			// 
		}

		public HGDepthOfFieldData GetDefaultFieldData()
		{
			// // HGDepthOfFieldData GetDefaultFieldData()
			// HGDepthOfFieldData *HG::Rendering::Runtime::HGDepthOfField::GetDefaultFieldData(
			//         HGDepthOfField *this,
			//         MethodInfo *method)
			// {
			//   HGDepthOfFieldData *result; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919458 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
			//     byte_18D919458 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2227, 0LL) )
			//   {
			//     result = (HGDepthOfFieldData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
			//     if ( result )
			//     {
			//       result.fields.type = 0;
			//       result.fields.nearFocusStart = 0.0;
			//       result.fields.nearFocusEnd = 0.0;
			//       result.fields.farFocusStart = 0.0;
			//       result.fields.farFocusEnd = 0.0;
			//       result.fields.nearRadius = 1.0;
			//       result.fields.farRadius = 1.0;
			//       result.fields.mode = 1;
			//       result.fields.scale = 1;
			//       result.fields.temporalFactor = 0.5;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2227, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_811(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void ToReset()
		{
			// // Void ToReset()
			// void HG::Rendering::Runtime::HGDepthOfField::ToReset(HGDepthOfField *this, MethodInfo *method)
			// {
			//   HGDepthOfFieldData *DefaultFieldData; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2228, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2228, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.enable = 0;
			//     DefaultFieldData = HG::Rendering::Runtime::HGDepthOfField::GetDefaultFieldData(this, 0LL);
			//     HG::Rendering::Runtime::HGDepthOfField::SetSerializeData(this, DefaultFieldData, 0LL);
			//   }
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGDepthOfField::IsActive(HGDepthOfField *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool m_manualEnable; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 1000 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x3E8 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[21]._0.events )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1000, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     }
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.fields.hgDebugCommand )
			//     m_manualEnable = this.fields.m_manualEnable;
			//   else
			//     m_manualEnable = this.fields.enable;
			//   return m_manualEnable
			//       && (HG::Rendering::Runtime::HGDepthOfField::IsNearFocusActive(this, 0LL)
			//        || HG::Rendering::Runtime::HGDepthOfField::IsFarFocusActive(this, 0LL))
			//       && UnityEngine::SystemInfo::SupportsComputeShaders(0LL);
			// }
			// 
			return default(bool);
		}

		public bool IsNearFocusActive()
		{
			// // Boolean IsNearFocusActive()
			// bool HG::Rendering::Runtime::HGDepthOfField::IsNearFocusActive(HGDepthOfField *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1001, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1001, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.focusMode == 1 )
			//     {
			//       if ( this.fields.nearFocusEnd > this.fields.nearFocusStart )
			//         return this.fields.nearRadius > 0.0;
			//     }
			//     else if ( !this.fields.focusMode )
			//     {
			//       return this.fields.nearRadius > 0.0;
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public bool IsFarFocusActive()
		{
			// // Boolean IsFarFocusActive()
			// bool HG::Rendering::Runtime::HGDepthOfField::IsFarFocusActive(HGDepthOfField *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1002, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1002, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.focusMode == 1 )
			//     {
			//       if ( this.fields.farFocusEnd > this.fields.farFocusStart )
			//         return this.fields.farRadius > 0.0;
			//     }
			//     else if ( !this.fields.focusMode )
			//     {
			//       return this.fields.farRadius > 0.0;
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public bool enable;

		public HGDepthOfFieldFocusMode focusMode;

		public HGDepthOfFieldScale scale;

		public HGDepthOfFieldType type;

		[Min(0f)]
		public float nearFocusStart;

		[Min(0f)]
		public float nearFocusEnd;

		[Min(0f)]
		public float nearRadius;

		[Min(0f)]
		public float farFocusStart;

		[Min(0f)]
		public float farFocusEnd;

		[Min(0f)]
		public float farRadius;

		[Min(0f)]
		public float focusRange;

		[Min(0.1f)]
		public float temporalFactor;

		public bool hgDebugCommand;

		private bool m_manualEnable;
	}
}
