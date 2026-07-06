using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[DebuggerDisplay("({camera.name})")]
	public class HGCamera
	{
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x000025D0 File Offset: 0x000007D0
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
			private set
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

		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x000025D0 File Offset: 0x000007D0
		internal Vector2Int taauRTSize
		{
			[CompilerGenerated]
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
				//         HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return (Object *)this.fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_value(Vector2)
				// void UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector2>::set_value(
				//         VolumeParameter_1_UnityEngine_Vector2_ *this,
				//         Vector2 value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Value = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x000025D0 File Offset: 0x000007D0
		internal Vector4 taauRTSizeParam
		{
			[CompilerGenerated]
			get
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

		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x000025D0 File Offset: 0x000007D0
		internal Vector2Int sceneRTSize
		{
			[CompilerGenerated]
			get
			{
				// // IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
				// IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
				//         aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_AreaMax(Vector2)
				// void HG::Rendering::HgMath::CellGrid2D<System::Object>::set_AreaMax(
				//         CellGrid2D_1_System_Object_ *this,
				//         Vector2 value,
				//         MethodInfo *method)
				// {
				//   this.fields._AreaMax_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x000025D0 File Offset: 0x000007D0
		internal Vector4 sceneRTSizeParam
		{
			[CompilerGenerated]
			get
			{
				// // Nullable`1[Int64] get_To()
				// Nullable_1_Int64_ *System::Net::Http::Headers::ContentRangeHeaderValue::get_To(
				//         Nullable_1_Int64_ *__return_ptr retstr,
				//         ContentRangeHeaderValue *this,
				//         MethodInfo *method)
				// {
				//   Nullable_1_Int64_ *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields._To_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // BBParameter`1[UnityEngine.Vector4](Vector4)
				// void NodeCanvas::Framework::BBParameter<UnityEngine::Vector4>::BBParameter(
				//         BBParameter_1_UnityEngine_Vector4_ *this,
				//         Vector4 *value,
				//         MethodInfo *method)
				// {
				//   this.fields._value = *value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector2Int finalRTSize
		{
			get
			{
				// // Vector2Int get_finalRTSize()
				// Vector2Int HG::Rendering::Runtime::HGCamera::get_finalRTSize(HGCamera *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
				//   if ( wrapperArray.max_length.size > 667 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( v3 )
				//     {
				//       if ( LODWORD(v3._0.namespaze) <= 0x29B )
				//         sub_180070270(v3, wrapperArray);
				//       if ( !v3[14]._0.typeMetadataHandle )
				//         goto LABEL_7;
				//       Patch = IFix::WrappersManagerImpl::GetPatch(667, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_251(Patch, (Object *)this, 0LL);
				//     }
				// LABEL_11:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				// LABEL_7:
				//   if ( this.fields.m_finalRTSize.m_X == -1 || this.fields.m_finalRTSize.m_Y == -1 )
				//     return this.fields._taauRTSize_k__BackingField;
				//   else
				//     return this.fields.m_finalRTSize;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_finalViewport(Vector2Int)
				// void UnityEngine::Rendering::DynamicResolutionHandler::set_finalViewport(
				//         DynamicResolutionHandler *this,
				//         Vector2Int value,
				//         MethodInfo *method)
				// {
				//   this.fields._finalViewport_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Vector4 finalRTSizeParam
		{
			get
			{
				// // Vector4 get_finalRTSizeParam()
				// Vector4 *HG::Rendering::Runtime::HGCamera::get_finalRTSizeParam(
				//         Vector4 *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   __m128i v7; // xmm2
				//   float m_X; // xmm0_4
				//   __m128i v9; // xmm1
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Vector4 taauRTSizeParam_k__BackingField; // xmm0
				//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = v5.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_11;
				//   if ( wrapperArray.max_length.size <= 821 )
				//     goto LABEL_7;
				//   if ( !v5._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v5, wrapperArray);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
				//   if ( !v5 )
				// LABEL_11:
				//     sub_180B536AC(v5, wrapperArray);
				//   if ( LODWORD(v5._0.namespaze) <= 0x335 )
				//     sub_180070270(v5, wrapperArray);
				//   if ( v5[17]._1.unity_user_data )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(821, 0LL);
				//     if ( Patch )
				//     {
				//       taauRTSizeParam_k__BackingField = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(
				//                                            &v13,
				//                                            Patch,
				//                                            (Object *)this,
				//                                            0LL);
				// LABEL_21:
				//       *retstr = taauRTSizeParam_k__BackingField;
				//       return retstr;
				//     }
				//     goto LABEL_11;
				//   }
				// LABEL_7:
				//   if ( this.fields.m_finalRTSize.m_X == -1 || this.fields.m_finalRTSize.m_Y == -1 )
				//   {
				//     taauRTSizeParam_k__BackingField = this.fields._taauRTSizeParam_k__BackingField;
				//     goto LABEL_21;
				//   }
				//   v7 = _mm_cvtsi32_si128(this.fields.m_finalRTSize.m_X);
				//   m_X = (float)this.fields.m_finalRTSize.m_X;
				//   retstr.y = (float)this.fields.m_finalRTSize.m_Y;
				//   v9 = _mm_cvtsi32_si128(this.fields.m_finalRTSize.m_Y);
				//   retstr.x = m_X;
				//   retstr.w = 1.0 / _mm_cvtepi32_ps(v9).m128_f32[0];
				//   retstr.z = 1.0 / _mm_cvtepi32_ps(v7).m128_f32[0];
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x000025D0 File Offset: 0x000007D0
		public int actualWidth
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_actualWidth()
				// int32_t HG::Rendering::Runtime::HGCamera::get_actualWidth(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._actualWidth_k__BackingField;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_actualWidth(Int32)
				// void HG::Rendering::Runtime::HGCamera::set_actualWidth(HGCamera *this, int32_t value, MethodInfo *method)
				// {
				//   this.fields._actualWidth_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x000025D0 File Offset: 0x000007D0
		public int actualHeight
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_actualHeight()
				// int32_t HG::Rendering::Runtime::HGCamera::get_actualHeight(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._actualHeight_k__BackingField;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_actualHeight(Int32)
				// void HG::Rendering::Runtime::HGCamera::set_actualHeight(HGCamera *this, int32_t value, MethodInfo *method)
				// {
				//   this.fields._actualHeight_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00002A40 File Offset: 0x00000C40
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x000025D0 File Offset: 0x000007D0
		public MSAASamples msaaSamples
		{
			[CompilerGenerated]
			get
			{
				// // MSAASamples get_msaaSamples()
				// MSAASamples__Enum HG::Rendering::Runtime::HGCamera::get_msaaSamples(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._msaaSamples_k__BackingField;
				// }
				// 
				return (MSAASamples)((MSAASamples)0);
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_msaaSamples(MSAASamples)
				// void HG::Rendering::Runtime::HGCamera::set_msaaSamples(HGCamera *this, MSAASamples__Enum value, MethodInfo *method)
				// {
				//   this.fields._msaaSamples_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool msaaEnabled
		{
			get
			{
				// // Boolean get_msaaEnabled()
				// bool HG::Rendering::Runtime::HGCamera::get_msaaEnabled(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._msaaSamples_k__BackingField != 1;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000025D0 File Offset: 0x000007D0
		public FrameSettings frameSettings
		{
			[CompilerGenerated]
			get
			{
				// // FrameSettings get_frameSettings()
				// FrameSettings *HG::Rendering::Runtime::HGCamera::get_frameSettings(
				//         FrameSettings *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   FrameSettings *result; // rax
				//   __int64 v4; // xmm1_8
				// 
				//   result = retstr;
				//   v4 = *(_QWORD *)&this.fields._frameSettings_k__BackingField.materialQuality;
				//   retstr.bitDatas = this.fields._frameSettings_k__BackingField.bitDatas;
				//   *(_QWORD *)&retstr.materialQuality = v4;
				//   return result;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_frameSettings(FrameSettings)
				// void HG::Rendering::Runtime::HGCamera::set_frameSettings(HGCamera *this, FrameSettings *value, MethodInfo *method)
				// {
				//   __int64 v3; // xmm1_8
				// 
				//   v3 = *(_QWORD *)&value.materialQuality;
				//   this.fields._frameSettings_k__BackingField.bitDatas = value.bitDatas;
				//   *(_QWORD *)&this.fields._frameSettings_k__BackingField.materialQuality = v3;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x000025D0 File Offset: 0x000007D0
		public VolumeStack volumeStack
		{
			[CompilerGenerated]
			get
			{
				// // VolumeStack get_volumeStack()
				// VolumeStack *HG::Rendering::Runtime::HGCamera::get_volumeStack(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._volumeStack_k__BackingField;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_volumeStack(VolumeStack)
				// void HG::Rendering::Runtime::HGCamera::set_volumeStack(HGCamera *this, VolumeStack *value, MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields._volumeStack_k__BackingField = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields._volumeStack_k__BackingField,
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

		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x000025D0 File Offset: 0x000007D0
		public static ExtractionDoneCallback extractionDoneCallback
		{
			[CompilerGenerated]
			get
			{
				// // ExtractionDoneCallback get_extractionDoneCallback()
				// ExtractionDoneCallback *HG::Rendering::Runtime::HGCamera::get_extractionDoneCallback(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGCamera__Class *v2; // rax
				// 
				//   if ( !byte_18D919492 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
				//     byte_18D919492 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGCamera;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGCamera;
				//   }
				//   return v2.static_fields._extractionDoneCallback_k__BackingField;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_extractionDoneCallback(ExtractionDoneCallback)
				// void HG::Rendering::Runtime::HGCamera::set_extractionDoneCallback(ExtractionDoneCallback *value, MethodInfo *method)
				// {
				//   OneofDescriptorProto *static_fields; // rdx
				//   FileDescriptor *v4; // r8
				//   MessageDescriptor *v5; // r9
				//   String__Array *v6; // [rsp+50h] [rbp+28h]
				//   String *v7; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v8; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D919493 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
				//     byte_18D919493 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
				//   static_fields = (OneofDescriptorProto *)TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields;
				//   static_fields.klass = (OneofDescriptorProto__Class *)value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields,
				//     static_fields,
				//     v4,
				//     v5,
				//     v6,
				//     v7,
				//     v8);
				// }
				// 
			}
		}

		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x000025D0 File Offset: 0x000007D0
		internal HGRenderPathBase renderPathInstance
		{
			[CompilerGenerated]
			get
			{
				// // TMP_Text get_linkedTextComponent()
				// TMP_Text *TMPro::TMP_Text::get_linkedTextComponent(TMP_Text *this, MethodInfo *method)
				// {
				//   return *(TMP_Text **)&this.fields.m_lineSpacing;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_renderPathInstance(HGRenderPathBase)
				// void HG::Rendering::Runtime::HGCamera::set_renderPathInstance(
				//         HGCamera *this,
				//         HGRenderPathBase *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields._renderPathInstance_k__BackingField = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields._renderPathInstance_k__BackingField,
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

		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGRenderPipelineMaterialCollector MaterialCollector
		{
			get
			{
				// // HGRenderPipelineMaterialCollector get_MaterialCollector()
				// HGRenderPipelineMaterialCollector *HG::Rendering::Runtime::HGCamera::get_MaterialCollector(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPathBase *renderPathInstance_k__BackingField; // rax
				// 
				//   renderPathInstance_k__BackingField = this.fields._renderPathInstance_k__BackingField;
				//   if ( !renderPathInstance_k__BackingField )
				//     sub_180B536AC(this, method);
				//   return *(HGRenderPipelineMaterialCollector **)&renderPathInstance_k__BackingField[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool ssrEnable
		{
			get
			{
				// // Boolean get_ssrEnable()
				// bool HG::Rendering::Runtime::HGCamera::get_ssrEnable(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 *static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   ScreenSpaceReflectionVolume *m_hgssrVolume; // rdi
				//   HGCamera_VolumeComponentsData *v7; // rax
				//   Object *v8; // rbx
				//   char v9; // al
				//   __int64 v10; // rdx
				//   HGRenderPipeline *currentPipeline; // rax
				//   HGSettingParameters *settingParameters_k__BackingField; // rax
				//   SettingParameter_1_System_Boolean_ *ssrEnable_k__BackingField; // rbx
				//   struct MethodInfo *v14; // rdi
				//   Il2CppClass *klass; // rax
				//   Il2CppClass *v16; // rcx
				//   __int64 v18; // rax
				//   ILFixDynamicMethodWrapper_2 *v19; // rax
				//   __int64 v20; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v22; // rax
				// 
				//   if ( !byte_18D8ED9FD )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
				//     byte_18D8ED9FD = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_48;
				//   if ( wrapperArray[6] <= 880 )
				//     goto LABEL_9;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v18 = *(_QWORD *)wrapperArray;
				//   if ( !*(_QWORD *)wrapperArray )
				//     goto LABEL_48;
				//   if ( *(_DWORD *)(v18 + 24) <= 0x370u )
				//     goto LABEL_63;
				//   if ( !*(_QWORD *)(v18 + 7072) )
				//   {
				// LABEL_9:
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( !m_volumeComponentsData )
				//       goto LABEL_48;
				//     m_hgssrVolume = m_volumeComponentsData.fields.m_hgssrVolume;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !byte_18D8F4EFA )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EFA = 1;
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !byte_18D8F4EAF )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EAF = 1;
				//     }
				//     if ( !m_hgssrVolume )
				//       return 0;
				//     static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !m_hgssrVolume.fields._._._.m_CachedPtr )
				//       return 0;
				//     v7 = this.fields.m_volumeComponentsData;
				//     if ( !v7 )
				//       goto LABEL_48;
				//     v8 = (Object *)v7.fields.m_hgssrVolume;
				//     if ( !v8 )
				//       goto LABEL_48;
				//     if ( !byte_18D8EDC37 )
				//     {
				//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//       byte_18D8EDC37 = 1;
				//     }
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//     if ( !wrapperArray )
				//       goto LABEL_48;
				//     if ( wrapperArray[6] <= 881 )
				//       goto LABEL_30;
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v20 = *static_fields;
				//     if ( !*static_fields )
				//       goto LABEL_48;
				//     if ( *(_DWORD *)(v20 + 24) > 0x371u )
				//     {
				//       if ( *(_QWORD *)(v20 + 7080) )
				//       {
				//         Patch = IFix::WrappersManagerImpl::GetPatch(881, 0LL);
				//         if ( !Patch )
				//           goto LABEL_48;
				//         v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, v8, 0LL);
				// LABEL_32:
				//         if ( v9 )
				//         {
				//           if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
				//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v10);
				//           currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
				//           if ( currentPipeline )
				//           {
				//             settingParameters_k__BackingField = currentPipeline.fields._settingParameters_k__BackingField;
				//             if ( settingParameters_k__BackingField )
				//             {
				//               ssrEnable_k__BackingField = settingParameters_k__BackingField.fields._ssrEnable_k__BackingField;
				//               v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
				//               if ( ssrEnable_k__BackingField )
				//               {
				//                 klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
				//                 if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
				//                   sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
				//                 if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
				//                 {
				//                   v22 = sub_18010B520(v14.klass);
				//                   (**(void (***)(void))(*(_QWORD *)(v22 + 192) + 48LL))();
				//                 }
				//                 v16 = v14.klass;
				//                 if ( ((__int64)v16.vtable[0].methodPtr & 1) == 0 )
				//                   sub_18003C700(v16);
				//                 return ssrEnable_k__BackingField.fields._paramValue_k__BackingField
				//                     && UnityEngine::SystemInfo::SupportsComputeShaders(0LL);
				//               }
				//             }
				//           }
				// LABEL_48:
				//           sub_180B536AC(static_fields, wrapperArray);
				//         }
				//         return 0;
				//       }
				// LABEL_30:
				//       wrapperArray = (int *)v8[3].klass;
				//       if ( !wrapperArray )
				//         goto LABEL_48;
				//       v9 = sub_1800023D0(10LL, wrapperArray);
				//       goto LABEL_32;
				//     }
				// LABEL_63:
				//     sub_180070270(static_fields, wrapperArray);
				//   }
				//   v19 = IFix::WrappersManagerImpl::GetPatch(880, 0LL);
				//   if ( !v19 )
				//     goto LABEL_48;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v19, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool aoEnable
		{
			get
			{
				// // Boolean get_aoEnable()
				// bool HG::Rendering::Runtime::HGCamera::get_aoEnable(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 *static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   GTAmbientOcclusion *m_GTAmbientOcclusion; // rdi
				//   HGCamera_VolumeComponentsData *v7; // rax
				//   Object *v8; // rbx
				//   char v9; // al
				//   __int64 v11; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rax
				//   ILFixDynamicMethodWrapper_2 *v14; // rax
				// 
				//   if ( !byte_18D8ED9FE )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8ED9FE = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   if ( wrapperArray[6] <= 987 )
				//     goto LABEL_9;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v11 = *(_QWORD *)wrapperArray;
				//   if ( !*(_QWORD *)wrapperArray )
				//     goto LABEL_34;
				//   if ( *(_DWORD *)(v11 + 24) <= 0x3DBu )
				//     goto LABEL_49;
				//   if ( *(_QWORD *)(v11 + 7928) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(987, 0LL);
				//     if ( !Patch )
				//       goto LABEL_34;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				// LABEL_9:
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( !m_volumeComponentsData )
				//       goto LABEL_34;
				//     m_GTAmbientOcclusion = m_volumeComponentsData.fields.m_GTAmbientOcclusion;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !byte_18D8F4EFA )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EFA = 1;
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//     if ( !byte_18D8F4EAF )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EAF = 1;
				//     }
				//     if ( m_GTAmbientOcclusion )
				//     {
				//       static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
				//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//       if ( m_GTAmbientOcclusion.fields._._._.m_CachedPtr )
				//       {
				//         v7 = this.fields.m_volumeComponentsData;
				//         if ( !v7 )
				//           goto LABEL_34;
				//         v8 = (Object *)v7.fields.m_GTAmbientOcclusion;
				//         if ( !v8 )
				//           goto LABEL_34;
				//         if ( !byte_18D8EDC37 )
				//         {
				//           sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//           byte_18D8EDC37 = 1;
				//         }
				//         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//         static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//         wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//         if ( !wrapperArray )
				//           goto LABEL_34;
				//         if ( wrapperArray[6] <= 988 )
				//           goto LABEL_30;
				//         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//         static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//         v13 = *static_fields;
				//         if ( !*static_fields )
				//           goto LABEL_34;
				//         if ( *(_DWORD *)(v13 + 24) > 0x3DCu )
				//         {
				//           if ( *(_QWORD *)(v13 + 7936) )
				//           {
				//             v14 = IFix::WrappersManagerImpl::GetPatch(988, 0LL);
				//             if ( v14 )
				//             {
				//               v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v14, v8, 0LL);
				//               return v9 != 0;
				//             }
				// LABEL_34:
				//             sub_180B536AC(static_fields, wrapperArray);
				//           }
				// LABEL_30:
				//           wrapperArray = (int *)v8[3].klass;
				//           if ( wrapperArray )
				//           {
				//             v9 = sub_1800023D0(10LL, wrapperArray);
				//             return v9 != 0;
				//           }
				//           goto LABEL_34;
				//         }
				// LABEL_49:
				//         sub_180070270(static_fields, wrapperArray);
				//       }
				//     }
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool fakePlanarReflectionEnable
		{
			get
			{
				// // Boolean get_fakePlanarReflectionEnable()
				// bool HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 *static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   OtherSettings *m_otherSettings; // rbx
				//   HGCamera_VolumeComponentsData *v7; // rax
				//   Object *v8; // rbx
				//   char v9; // al
				//   __int64 v11; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rax
				//   ILFixDynamicMethodWrapper_2 *v14; // rax
				//   HGCamera_VolumeComponentsData *v15; // rax
				// 
				//   if ( !byte_18D8ED9FF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8ED9FF = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   if ( wrapperArray[6] > 991 )
				//   {
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v11 = *(_QWORD *)wrapperArray;
				//     if ( !*(_QWORD *)wrapperArray )
				//       goto LABEL_34;
				//     if ( *(_DWORD *)(v11 + 24) <= 0x3DFu )
				//       goto LABEL_49;
				//     if ( *(_QWORD *)(v11 + 7960) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(991, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// LABEL_34:
				//       sub_180B536AC(static_fields, wrapperArray);
				//     }
				//   }
				//   m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//   if ( !m_volumeComponentsData )
				//     goto LABEL_34;
				//   m_otherSettings = m_volumeComponentsData.fields.m_otherSettings;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !byte_18D8F4EFA )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFA = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( !m_otherSettings )
				//     return 0;
				//   static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !m_otherSettings.fields._._._.m_CachedPtr )
				//     return 0;
				//   v7 = this.fields.m_volumeComponentsData;
				//   if ( !v7 )
				//     goto LABEL_34;
				//   v8 = (Object *)v7.fields.m_otherSettings;
				//   if ( !v8 )
				//     goto LABEL_34;
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   if ( wrapperArray[6] <= 992 )
				//     goto LABEL_30;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v13 = *static_fields;
				//   if ( !*static_fields )
				//     goto LABEL_34;
				//   if ( *(_DWORD *)(v13 + 24) <= 0x3E0u )
				// LABEL_49:
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !*(_QWORD *)(v13 + 7968) )
				//   {
				// LABEL_30:
				//     wrapperArray = (int *)v8[3].klass;
				//     if ( !wrapperArray )
				//       goto LABEL_34;
				//     v9 = sub_1800023D0(10LL, wrapperArray);
				//     goto LABEL_32;
				//   }
				//   v14 = IFix::WrappersManagerImpl::GetPatch(992, 0LL);
				//   if ( !v14 )
				//     goto LABEL_34;
				//   v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v14, v8, 0LL);
				// LABEL_32:
				//   if ( !v9 )
				//     return 0;
				//   v15 = this.fields.m_volumeComponentsData;
				//   if ( !v15 )
				//     goto LABEL_34;
				//   wrapperArray = (int *)v15.fields.m_otherSettings;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   wrapperArray = (int *)*((_QWORD *)wrapperArray + 7);
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   return (unsigned __int8)sub_1800023D0(10LL, wrapperArray) != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool fakePlanarRelectionDisableCharacterOutline
		{
			get
			{
				// // Boolean get_fakePlanarRelectionDisableCharacterOutline()
				// bool HG::Rendering::Runtime::HGCamera::get_fakePlanarRelectionDisableCharacterOutline(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   __int64 *static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   OtherSettings *m_otherSettings; // rbx
				//   HGCamera_VolumeComponentsData *v7; // rax
				//   Object *v8; // rbx
				//   char v9; // al
				//   __int64 v11; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rax
				//   ILFixDynamicMethodWrapper_2 *v14; // rax
				//   HGCamera_VolumeComponentsData *v15; // rax
				// 
				//   if ( !byte_18D8EDA00 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA00 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   if ( wrapperArray[6] > 994 )
				//   {
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v11 = *(_QWORD *)wrapperArray;
				//     if ( !*(_QWORD *)wrapperArray )
				//       goto LABEL_34;
				//     if ( *(_DWORD *)(v11 + 24) <= 0x3E2u )
				//       goto LABEL_49;
				//     if ( *(_QWORD *)(v11 + 7984) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(994, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// LABEL_34:
				//       sub_180B536AC(static_fields, wrapperArray);
				//     }
				//   }
				//   m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//   if ( !m_volumeComponentsData )
				//     goto LABEL_34;
				//   m_otherSettings = m_volumeComponentsData.fields.m_otherSettings;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !byte_18D8F4EFA )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFA = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( !m_otherSettings )
				//     return 0;
				//   static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !m_otherSettings.fields._._._.m_CachedPtr )
				//     return 0;
				//   v7 = this.fields.m_volumeComponentsData;
				//   if ( !v7 )
				//     goto LABEL_34;
				//   v8 = (Object *)v7.fields.m_otherSettings;
				//   if ( !v8 )
				//     goto LABEL_34;
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   if ( wrapperArray[6] <= 992 )
				//     goto LABEL_30;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//   v13 = *static_fields;
				//   if ( !*static_fields )
				//     goto LABEL_34;
				//   if ( *(_DWORD *)(v13 + 24) <= 0x3E0u )
				// LABEL_49:
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !*(_QWORD *)(v13 + 7968) )
				//   {
				// LABEL_30:
				//     wrapperArray = (int *)v8[3].klass;
				//     if ( !wrapperArray )
				//       goto LABEL_34;
				//     v9 = sub_1800023D0(10LL, wrapperArray);
				//     goto LABEL_32;
				//   }
				//   v14 = IFix::WrappersManagerImpl::GetPatch(992, 0LL);
				//   if ( !v14 )
				//     goto LABEL_34;
				//   v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v14, v8, 0LL);
				// LABEL_32:
				//   if ( !v9 )
				//     return 0;
				//   v15 = this.fields.m_volumeComponentsData;
				//   if ( !v15 )
				//     goto LABEL_34;
				//   wrapperArray = (int *)v15.fields.m_otherSettings;
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   wrapperArray = (int *)*((_QWORD *)wrapperArray + 8);
				//   if ( !wrapperArray )
				//     goto LABEL_34;
				//   return (unsigned __int8)sub_1800023D0(10LL, wrapperArray) != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Vector3 fakeReflectionProbeNormal
		{
			get
			{
				// // Vector3 get_fakeReflectionProbeNormal()
				// Vector3 *HG::Rendering::Runtime::HGCamera::get_fakeReflectionProbeNormal(
				//         Vector3 *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *m_otherSettings; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Vector3 *v9; // rax
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   Il2CppClass *castClass; // r8
				//   __int64 v12; // xmm0_8
				//   float z; // eax
				//   Vector3 v14[2]; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
				//     m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = m_otherSettings.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_10;
				//   if ( wrapperArray.max_length.size > 996 )
				//   {
				//     if ( !m_otherSettings._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(m_otherSettings, wrapperArray);
				//       m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     m_otherSettings = (struct ILFixDynamicMethodWrapper_2__Class *)m_otherSettings.static_fields.wrapperArray;
				//     if ( !m_otherSettings )
				//       goto LABEL_10;
				//     if ( LODWORD(m_otherSettings._0.namespaze) <= 0x3E4 )
				//       sub_180070270(m_otherSettings, wrapperArray);
				//     if ( m_otherSettings[21]._0.typeMetadataHandle )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(996, 0LL);
				//       if ( Patch )
				//       {
				//         v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(v14, Patch, (Object *)this, 0LL);
				// LABEL_23:
				//         v12 = *(_QWORD *)&v9.x;
				//         z = v9.z;
				//         *(_QWORD *)&retstr.x = v12;
				//         retstr.z = z;
				//         return retstr;
				//       }
				// LABEL_10:
				//       sub_180B536AC(m_otherSettings, wrapperArray);
				//     }
				//   }
				//   if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(this, 0LL) )
				//   {
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( m_volumeComponentsData )
				//     {
				//       m_otherSettings = (struct ILFixDynamicMethodWrapper_2__Class *)m_volumeComponentsData.fields.m_otherSettings;
				//       if ( m_otherSettings )
				//       {
				//         castClass = m_otherSettings._0.castClass;
				//         if ( castClass )
				//         {
				//           v9 = (Vector3 *)sub_180057F50(v14, 10LL, castClass);
				//           goto LABEL_23;
				//         }
				//       }
				//     }
				//     goto LABEL_10;
				//   }
				//   *(_QWORD *)&retstr.y = 1065353216LL;
				//   retstr.x = 0.0;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Vector3 fakeReflectionPlanePos
		{
			get
			{
				// // Vector3 get_fakeReflectionPlanePos()
				// Vector3 *HG::Rendering::Runtime::HGCamera::get_fakeReflectionPlanePos(
				//         Vector3 *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *m_otherSettings; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   float z; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Vector3 *v10; // rax
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   Il2CppClass *declaringType; // r8
				//   __int64 v13; // xmm0_8
				//   Vector3 v14[2]; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
				//     m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = m_otherSettings.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_10;
				//   if ( wrapperArray.max_length.size > 997 )
				//   {
				//     if ( !m_otherSettings._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(m_otherSettings, wrapperArray);
				//       m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     m_otherSettings = (struct ILFixDynamicMethodWrapper_2__Class *)m_otherSettings.static_fields.wrapperArray;
				//     if ( !m_otherSettings )
				//       goto LABEL_10;
				//     if ( LODWORD(m_otherSettings._0.namespaze) <= 0x3E5 )
				//       sub_180070270(m_otherSettings, wrapperArray);
				//     if ( m_otherSettings[21]._0.interopData )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(997, 0LL);
				//       if ( Patch )
				//       {
				//         v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(v14, Patch, (Object *)this, 0LL);
				// LABEL_23:
				//         v13 = *(_QWORD *)&v10.x;
				//         z = v10.z;
				//         *(_QWORD *)&retstr.x = v13;
				//         goto LABEL_9;
				//       }
				// LABEL_10:
				//       sub_180B536AC(m_otherSettings, wrapperArray);
				//     }
				//   }
				//   if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(this, 0LL) )
				//   {
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( m_volumeComponentsData )
				//     {
				//       m_otherSettings = (struct ILFixDynamicMethodWrapper_2__Class *)m_volumeComponentsData.fields.m_otherSettings;
				//       if ( m_otherSettings )
				//       {
				//         declaringType = m_otherSettings._0.declaringType;
				//         if ( declaringType )
				//         {
				//           v10 = (Vector3 *)sub_180057F50(v14, 10LL, declaringType);
				//           goto LABEL_23;
				//         }
				//       }
				//     }
				//     goto LABEL_10;
				//   }
				//   z = 0.0;
				//   *(_QWORD *)&retstr.x = 0LL;
				// LABEL_9:
				//   retstr.z = z;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float fakePlanarReflectionBlur
		{
			get
			{
				// // Single get_fakePlanarReflectionBlur()
				// float HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(HGCamera *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *m_otherSettings; // rcx
				//   int *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				// 
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = (int *)m_otherSettings.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_9;
				//   if ( wrapperArray[6] > 995 )
				//   {
				//     if ( !m_otherSettings._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(m_otherSettings, wrapperArray);
				//       m_otherSettings = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     m_otherSettings = (struct ILFixDynamicMethodWrapper_2__Class *)m_otherSettings.static_fields.wrapperArray;
				//     if ( !m_otherSettings )
				//       goto LABEL_9;
				//     if ( LODWORD(m_otherSettings._0.namespaze) <= 0x3E3 )
				//       sub_180070270(m_otherSettings, wrapperArray);
				//     if ( m_otherSettings[21]._0.generic_class )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(995, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
				//                  (ILFixDynamicMethodWrapper_16 *)Patch,
				//                  (Object *)this,
				//                  0LL);
				// LABEL_9:
				//       sub_180B536AC(m_otherSettings, wrapperArray);
				//     }
				//   }
				//   if ( !HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(this, 0LL) )
				//     return 0.0;
				//   m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//   if ( !m_volumeComponentsData )
				//     goto LABEL_9;
				//   m_otherSettings = (struct ILFixDynamicMethodWrapper_2__Class *)m_volumeComponentsData.fields.m_otherSettings;
				//   if ( !m_otherSettings )
				//     goto LABEL_9;
				//   wrapperArray = (int *)m_otherSettings._0.parent;
				//   if ( !wrapperArray )
				//     goto LABEL_9;
				//   return sub_18003F9B0(10LL, wrapperArray);
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableDepthOfField
		{
			get
			{
				// // Boolean get_enableDepthOfField()
				// bool HG::Rendering::Runtime::HGCamera::get_enableDepthOfField(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Camera *camera; // rcx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   HGDepthOfField *m_depthOfField; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D91949E )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D91949E = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2328, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2328, 0LL);
				//     if ( !Patch )
				//       goto LABEL_12;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( !m_volumeComponentsData )
				//       goto LABEL_12;
				//     m_depthOfField = m_volumeComponentsData.fields.m_depthOfField;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Equality((Object_1 *)m_depthOfField, 0LL, 0LL) )
				//     {
				//       if ( !m_depthOfField )
				//         goto LABEL_12;
				//       if ( HG::Rendering::Runtime::HGDepthOfField::IsActive(m_depthOfField, 0LL) )
				//       {
				//         camera = this.fields.camera;
				//         if ( camera )
				//           return UnityEngine::Camera::get_cameraType(camera, 0LL) == CameraType__Enum_Game;
				// LABEL_12:
				//         sub_180B536AC(camera, v3);
				//       }
				//     }
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableMotionBlur
		{
			get
			{
				// // Boolean get_enableMotionBlur()
				// bool HG::Rendering::Runtime::HGCamera::get_enableMotionBlur(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 *static_fields; // rcx
				//   int *wrapperArray; // rdx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
				//   HGMotionBlur *m_motionBlur; // rdi
				//   HGCamera_VolumeComponentsData *v7; // rax
				//   Object *v8; // rbx
				//   __int64 v10; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rax
				//   ILFixDynamicMethodWrapper_2 *v13; // rax
				// 
				//   if ( !byte_18D8EDA01 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA01 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_33;
				//   if ( wrapperArray[6] > 1003 )
				//   {
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v10 = *(_QWORD *)wrapperArray;
				//     if ( !*(_QWORD *)wrapperArray )
				//       goto LABEL_33;
				//     if ( *(_DWORD *)(v10 + 24) <= 0x3EBu )
				//       goto LABEL_48;
				//     if ( *(_QWORD *)(v10 + 8056) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(1003, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//       goto LABEL_33;
				//     }
				//   }
				//   m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//   if ( !m_volumeComponentsData )
				//     goto LABEL_33;
				//   m_motionBlur = m_volumeComponentsData.fields.m_motionBlur;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !byte_18D8F4EFA )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFA = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( !m_motionBlur )
				//     return 0;
				//   static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
				//   if ( !m_motionBlur.fields._._._.m_CachedPtr )
				//     return 0;
				//   v7 = this.fields.m_volumeComponentsData;
				//   if ( !v7 )
				//     goto LABEL_33;
				//   v8 = (Object *)v7.fields.m_motionBlur;
				//   if ( !v8 )
				//     goto LABEL_33;
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_33;
				//   if ( wrapperArray[6] > 1004 )
				//   {
				//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
				//     static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
				//     v12 = *static_fields;
				//     if ( !*static_fields )
				//       goto LABEL_33;
				//     if ( *(_DWORD *)(v12 + 24) > 0x3ECu )
				//     {
				//       if ( !*(_QWORD *)(v12 + 8064) )
				//         goto LABEL_30;
				//       v13 = IFix::WrappersManagerImpl::GetPatch(1004, 0LL);
				//       if ( v13 )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v13, v8, 0LL);
				// LABEL_33:
				//       sub_180B536AC(static_fields, wrapperArray);
				//     }
				// LABEL_48:
				//     sub_180070270(static_fields, wrapperArray);
				//   }
				// LABEL_30:
				//   wrapperArray = (int *)v8[3].klass;
				//   if ( !wrapperArray )
				//     goto LABEL_33;
				//   if ( !(unsigned __int8)sub_1800023D0(10LL, wrapperArray) )
				//     return 0;
				//   wrapperArray = (int *)v8[3].monitor;
				//   if ( !wrapperArray )
				//     goto LABEL_33;
				//   return sub_18003F9B0(10LL, wrapperArray) > 0.0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableTransparentAfterDOF
		{
			get
			{
				// // Boolean get_enableTransparentAfterDOF()
				// bool HG::Rendering::Runtime::HGCamera::get_enableTransparentAfterDOF(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Camera *camera; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2329, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2329, 0LL);
				//     if ( !Patch )
				//       goto LABEL_8;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     if ( !HG::Rendering::Runtime::HGCamera::get_enableDepthOfField(this, 0LL)
				//       && !HG::Rendering::Runtime::HGCamera::get_enableMotionBlur(this, 0LL) )
				//     {
				//       camera = this.fields.camera;
				//       if ( camera )
				//         return UnityEngine::Camera::get_cameraType(camera, 0LL) == CameraType__Enum_SceneView;
				// LABEL_8:
				//       sub_180B536AC(camera, v3);
				//     }
				//     return 1;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float rayTracingReflectionVolumeBlend
		{
			get
			{
				// // Single get_rayTracingReflectionVolumeBlend()
				// float HG::Rendering::Runtime::HGCamera::get_rayTracingReflectionVolumeBlend(HGCamera *this, MethodInfo *method)
				// {
				//   Object_1__Class *klass; // rdx
				//   __int64 v4; // rcx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
				//   Object_1 *m_rayTracingReflectionVolume; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA02 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA02 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1034, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1034, 0LL);
				//     if ( !Patch )
				//       goto LABEL_11;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( !m_volumeComponentsData )
				//       goto LABEL_11;
				//     m_rayTracingReflectionVolume = (Object_1 *)m_volumeComponentsData.fields.m_rayTracingReflectionVolume;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
				//     if ( !UnityEngine::Object::op_Equality(m_rayTracingReflectionVolume, 0LL, 0LL) )
				//     {
				//       if ( m_rayTracingReflectionVolume )
				//       {
				//         klass = m_rayTracingReflectionVolume[2].klass;
				//         if ( klass )
				//           return sub_18003F9B0(10LL, klass);
				//       }
				// LABEL_11:
				//       sub_180B536AC(v4, klass);
				//     }
				//     return 0.0;
				//   }
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00002A58 File Offset: 0x00000C58
		internal RayTracingReflectionMode rayTracingReflectionVolumeMode
		{
			get
			{
				// // RayTracingReflectionMode get_rayTracingReflectionVolumeMode()
				// RayTracingReflectionMode__Enum HG::Rendering::Runtime::HGCamera::get_rayTracingReflectionVolumeMode(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   RayTracingReflectionModeParameter *mode; // rdx
				//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
				//   RayTracingReflectionVolume *m_rayTracingReflectionVolume; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA03 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA03 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   mode = (RayTracingReflectionModeParameter *)*v3[23];
				//   if ( !mode )
				//     goto LABEL_25;
				//   if ( mode.fields._.m_Value <= 1035 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, mode);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_25;
				//   if ( *((_DWORD *)v3 + 6) <= 0x40Bu )
				//     sub_180070270(v3, mode);
				//   if ( !v3[1039] )
				//   {
				// LABEL_9:
				//     m_volumeComponentsData = this.fields.m_volumeComponentsData;
				//     if ( !m_volumeComponentsData )
				//       goto LABEL_25;
				//     m_rayTracingReflectionVolume = m_volumeComponentsData.fields.m_rayTracingReflectionVolume;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, mode);
				//     if ( !byte_18D8F4EFA )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EFA = 1;
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, mode);
				//     if ( !byte_18D8F4EAF )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EAF = 1;
				//     }
				//     if ( !m_rayTracingReflectionVolume )
				//       return 0;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, mode);
				//     if ( !m_rayTracingReflectionVolume.fields._._._.m_CachedPtr )
				//       return 0;
				//     mode = m_rayTracingReflectionVolume.fields.mode;
				//     if ( mode )
				//       return (unsigned int)sub_18003ED00(10LL);
				// LABEL_25:
				//     sub_180B536AC(v3, mode);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1035, 0LL);
				//   if ( !Patch )
				//     goto LABEL_25;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return (RayTracingReflectionMode)RayTracingReflectionMode.Hybrid;
			}
		}

		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Camera parentCamera
		{
			get
			{
				// // Camera get_parentCamera()
				// Camera *HG::Rendering::Runtime::HGCamera::get_parentCamera(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields.m_parentCamera;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool isLowResScaleHalf
		{
			get
			{
				// // Boolean get_isLowResScaleHalf()
				// bool HG::Rendering::Runtime::HGCamera::get_isLowResScaleHalf(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields.lowResScale == 0.5;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x000025D2 File Offset: 0x000007D2
		internal ref HGUtils.PackedMipChainInfo depthBufferMipChainInfo
		{
			get
			{
				// // HGUtils+PackedMipChainInfo& get_depthBufferMipChainInfo()
				// HGUtils_PackedMipChainInfo *HG::Rendering::Runtime::HGCamera::get_depthBufferMipChainInfo(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   return &this.fields.m_DepthBufferMipChainInfo;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Vector2Int depthMipChainSize
		{
			get
			{
				// // Vector2Int get_depthMipChainSize()
				// Vector2Int HG::Rendering::Runtime::HGCamera::get_depthMipChainSize(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields.m_DepthBufferMipChainInfo.textureSize;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x000025D0 File Offset: 0x000007D0
		internal float globalMipBias
		{
			[CompilerGenerated]
			get
			{
				// // Single get_globalMipBias()
				// float HG::Rendering::Runtime::HGCamera::get_globalMipBias(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._globalMipBias_k__BackingField;
				// }
				// 
				return 0f;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_globalMipBias(Single)
				// void HG::Rendering::Runtime::HGCamera::set_globalMipBias(HGCamera *this, float value, MethodInfo *method)
				// {
				//   this.fields._globalMipBias_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Matrix4x4 nonObliqueProjMatrix
		{
			get
			{
				// // Matrix4x4 get_nonObliqueProjMatrix()
				// Matrix4x4 *HG::Rendering::Runtime::HGCamera::get_nonObliqueProjMatrix(
				//         Matrix4x4 *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   Object_1 *m_AdditionalCameraData; // rbx
				//   __int64 v6; // rcx
				//   HGAdditionalCameraData *v7; // rdx
				//   Matrix4x4 *NonObliqueProjection; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int128 v10; // xmm1
				//   __int128 v11; // xmm0
				//   __int128 v12; // xmm1
				//   Matrix4x4 *result; // rax
				//   Matrix4x4 v14; // [rsp+20h] [rbp-48h] BYREF
				// 
				//   if ( !byte_18D91949F )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D91949F = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2331, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2331, 0LL);
				//     if ( Patch )
				//     {
				//       NonObliqueProjection = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_186(&v14, Patch, (Object *)this, 0LL);
				//       goto LABEL_11;
				//     }
				//     goto LABEL_9;
				//   }
				//   m_AdditionalCameraData = (Object_1 *)this.fields.m_AdditionalCameraData;
				//   sub_180002C70(TypeInfo::UnityEngine::Object);
				//   if ( !UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
				//   {
				//     NonObliqueProjection = HG::Rendering::Runtime::GeometryUtils::CalculateProjectionMatrix(
				//                              &v14,
				//                              this.fields.camera,
				//                              0LL);
				//     goto LABEL_11;
				//   }
				//   v7 = this.fields.m_AdditionalCameraData;
				//   if ( !v7 )
				// LABEL_9:
				//     sub_180B536AC(v6, v7);
				//   NonObliqueProjection = HG::Rendering::Runtime::HGAdditionalCameraData::GetNonObliqueProjection(
				//                            &v14,
				//                            v7,
				//                            this.fields.camera,
				//                            0LL);
				// LABEL_11:
				//   v10 = *(_OWORD *)&NonObliqueProjection.m01;
				//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&NonObliqueProjection.m00;
				//   v11 = *(_OWORD *)&NonObliqueProjection.m02;
				//   *(_OWORD *)&retstr.m01 = v10;
				//   v12 = *(_OWORD *)&NonObliqueProjection.m03;
				//   result = retstr;
				//   *(_OWORD *)&retstr.m02 = v11;
				//   *(_OWORD *)&retstr.m03 = v12;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x000025D0 File Offset: 0x000007D0
		internal bool isFirstFrame
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_isFirstFrame()
				// bool HG::Rendering::Runtime::HGCamera::get_isFirstFrame(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields._isFirstFrame_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_isFirstFrame(Boolean)
				// void HG::Rendering::Runtime::HGCamera::set_isFirstFrame(HGCamera *this, bool value, MethodInfo *method)
				// {
				//   this.fields._isFirstFrame_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool isMainGameView
		{
			get
			{
				// // Boolean get_isMainGameView()
				// bool HG::Rendering::Runtime::HGCamera::get_isMainGameView(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Camera *camera; // rcx
				//   Object_1 *targetTexture; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9194A0 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9194A0 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2332, 0LL) )
				//   {
				//     camera = this.fields.camera;
				//     if ( camera )
				//     {
				//       if ( UnityEngine::Camera::get_cameraType(camera, 0LL) != CameraType__Enum_Game )
				//         return 0;
				//       camera = this.fields.camera;
				//       if ( camera )
				//       {
				//         targetTexture = (Object_1 *)UnityEngine::Camera::get_targetTexture(camera, 0LL);
				//         sub_180002C70(TypeInfo::UnityEngine::Object);
				//         return UnityEngine::Object::op_Equality(targetTexture, 0LL, 0LL);
				//       }
				//     }
				// LABEL_10:
				//     sub_180B536AC(camera, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2332, 0LL);
				//   if ( !Patch )
				//     goto LABEL_10;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool canDoDynamicResolution
		{
			get
			{
				// // Boolean get_canDoDynamicResolution()
				// bool HG::Rendering::Runtime::HGCamera::get_canDoDynamicResolution(HGCamera *this, MethodInfo *method)
				// {
				//   Camera *camera; // rbx
				//   __int64 (__fastcall *v3)(Camera *, MethodInfo *); // rax
				//   int v4; // eax
				//   __int64 v5; // rax
				// 
				//   camera = this.fields.camera;
				//   if ( !camera )
				//     sub_180B536AC(this, method);
				//   v3 = (__int64 (__fastcall *)(Camera *, MethodInfo *))qword_18D8F4200;
				//   if ( !qword_18D8F4200 )
				//   {
				//     v3 = (__int64 (__fastcall *)(Camera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
				//     if ( !v3 )
				//     {
				//       v5 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
				//       sub_18000F750(v5, 0LL);
				//     }
				//     qword_18D8F4200 = (__int64)v3;
				//   }
				//   v4 = v3(camera, method);
				//   if ( v4 != 1 )
				//     LOBYTE(v4) = 0;
				//   return v4;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool clearDepth
		{
			get
			{
				// // Boolean get_clearDepth()
				// bool HG::Rendering::Runtime::HGCamera::get_clearDepth(HGCamera *this, MethodInfo *method)
				// {
				//   Object_1 *m_AdditionalCameraData; // rbx
				//   __int64 v4; // rdx
				//   Camera *camera; // rcx
				//   HGAdditionalCameraData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9194A1 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9194A1 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2333, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2333, 0LL);
				//     if ( !Patch )
				//       goto LABEL_10;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     m_AdditionalCameraData = (Object_1 *)this.fields.m_AdditionalCameraData;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
				//     {
				//       v6 = this.fields.m_AdditionalCameraData;
				//       if ( v6 )
				//         return v6.fields.clearDepth;
				// LABEL_10:
				//       sub_180B536AC(camera, v4);
				//     }
				//     camera = this.fields.camera;
				//     if ( !camera )
				//       goto LABEL_10;
				//     return UnityEngine::Camera::get_clearFlags(camera, 0LL) != CameraClearFlags__Enum_Nothing;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableAlpha
		{
			get
			{
				// // Boolean get_enableAlpha()
				// bool HG::Rendering::Runtime::HGCamera::get_enableAlpha(HGCamera *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rbx
				//   HGAdditionalCameraData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA04 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA04 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v4 = *v3[23];
				//   if ( !v4 )
				//     goto LABEL_24;
				//   if ( *(int *)(v4 + 24) <= 891 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_24;
				//   if ( *((_DWORD *)v3 + 6) <= 0x37Bu )
				//     sub_180070270(v3, v4);
				//   if ( !v3[895] )
				//   {
				// LABEL_9:
				//     m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !byte_18D8F4EFB )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EFB = 1;
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !byte_18D8F4EAF )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EAF = 1;
				//     }
				//     if ( !m_AdditionalCameraData )
				//       return 0;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !m_AdditionalCameraData.fields._._._._.m_CachedPtr )
				//       return 0;
				//     v6 = this.fields.m_AdditionalCameraData;
				//     if ( v6 )
				//       return v6.fields.enableAlpha;
				// LABEL_24:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(891, 0LL);
				//   if ( !Patch )
				//     goto LABEL_24;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00002A70 File Offset: 0x00000C70
		internal HGAdditionalCameraData.ClearColorMode clearColorMode
		{
			get
			{
				// // HGAdditionalCameraData+ClearColorMode get_clearColorMode()
				// HGAdditionalCameraData_ClearColorMode__Enum HG::Rendering::Runtime::HGCamera::get_clearColorMode(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   Camera *camera; // rcx
				//   __int64 v4; // rdx
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rdi
				//   HGAdditionalCameraData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA05 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA05 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v4 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
				//   if ( !v4 )
				//     goto LABEL_23;
				//   if ( *(int *)(v4 + 24) > 681 )
				//   {
				//     if ( !LODWORD(camera[9].monitor) )
				//     {
				//       il2cpp_runtime_class_init_0(camera, v4);
				//       camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     camera = *(Camera **)camera[7].fields._._._.m_CachedPtr;
				//     if ( !camera )
				//       goto LABEL_23;
				//     if ( LODWORD(camera[1].klass) <= 0x2A9 )
				//       sub_180070270(camera, v4);
				//     if ( camera[228].monitor )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(681, 0LL);
				//       if ( !Patch )
				//         goto LABEL_23;
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
				//     }
				//   }
				//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//   if ( !byte_18D8F4EFB )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFB = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( m_AdditionalCameraData )
				//   {
				//     camera = (Camera *)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( m_AdditionalCameraData.fields._._._._.m_CachedPtr )
				//     {
				//       v6 = this.fields.m_AdditionalCameraData;
				//       if ( v6 )
				//         return v6.fields.clearColorMode;
				// LABEL_23:
				//       sub_180B536AC(camera, v4);
				//     }
				//   }
				//   camera = this.fields.camera;
				//   if ( !camera )
				//     goto LABEL_23;
				//   if ( UnityEngine::Camera::get_clearFlags(camera, 0LL) == CameraClearFlags__Enum_Skybox )
				//     return 0;
				//   camera = this.fields.camera;
				//   if ( !camera )
				//     goto LABEL_23;
				//   return (UnityEngine::Camera::get_clearFlags(camera, 0LL) != CameraClearFlags__Enum_Color) + 1;
				// }
				// 
				return HGAdditionalCameraData.ClearColorMode.Sky;
			}
		}

		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Color backgroundColorHDR
		{
			get
			{
				// // Color get_backgroundColorHDR()
				// Color *HG::Rendering::Runtime::HGCamera::get_backgroundColorHDR(
				//         Color *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   void *v5; // rcx
				//   Camera *camera; // rdx
				//   Vector3Int *v7; // r8
				//   ITilemap *v8; // r9
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rsi
				//   HGAdditionalCameraData *v10; // rax
				//   Color backgroundColorHDR; // xmm0
				//   Color *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Color *TileAnimationDataNoRef; // rax
				//   Color v15; // [rsp+20h] [rbp-28h] BYREF
				//   TileAnimationData v16; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D8EDA06 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA06 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   camera = (Camera *)**((_QWORD **)v5 + 23);
				//   if ( !camera )
				//     goto LABEL_25;
				//   if ( SLODWORD(camera[1].klass) > 893 )
				//   {
				//     if ( !*((_DWORD *)v5 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v5, camera);
				//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v5 = (void *)**((_QWORD **)v5 + 23);
				//     if ( !v5 )
				//       goto LABEL_25;
				//     if ( *((_DWORD *)v5 + 6) <= 0x37Du )
				//       sub_180070270(v5, camera);
				//     if ( *((_QWORD *)v5 + 897) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(893, 0LL);
				//       if ( Patch )
				//       {
				//         TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_321(&v15, Patch, (Object *)this, 0LL);
				// LABEL_37:
				//         backgroundColorHDR = *TileAnimationDataNoRef;
				//         goto LABEL_24;
				//       }
				// LABEL_25:
				//       sub_180B536AC(v5, camera);
				//     }
				//   }
				//   if ( HG::Rendering::Runtime::HGCamera::get_clearColorMode(this, 0LL) == HGAdditionalCameraData_ClearColorMode__Enum_None )
				//   {
				//     TileAnimationDataNoRef = (Color *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                         &v16,
				//                                         (TileBase *)camera,
				//                                         v7,
				//                                         v8,
				//                                         *(MethodInfo **)&v15.r);
				//     goto LABEL_37;
				//   }
				//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, camera);
				//   if ( !byte_18D8F4EFB )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFB = 1;
				//   }
				//   v5 = TypeInfo::UnityEngine::Object;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, camera);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( !m_AdditionalCameraData )
				//     goto LABEL_34;
				//   v5 = TypeInfo::UnityEngine::Object;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, camera);
				//   if ( !m_AdditionalCameraData.fields._._._._.m_CachedPtr )
				//   {
				// LABEL_34:
				//     camera = this.fields.camera;
				//     if ( camera )
				//     {
				//       v15 = *UnityEngine::Camera::get_backgroundColor(&v15, camera, 0LL);
				//       TileAnimationDataNoRef = (Color *)sub_182F8C840(&v16, &v15);
				//       goto LABEL_37;
				//     }
				//     goto LABEL_25;
				//   }
				//   v10 = this.fields.m_AdditionalCameraData;
				//   if ( !v10 )
				//     goto LABEL_25;
				//   backgroundColorHDR = v10.fields.backgroundColorHDR;
				// LABEL_24:
				//   result = retstr;
				//   *retstr = backgroundColorHDR;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00002A88 File Offset: 0x00000C88
		internal HGAdditionalCameraData.FlipYMode flipYMode
		{
			get
			{
				// // HGAdditionalCameraData+FlipYMode get_flipYMode()
				// HGAdditionalCameraData_FlipYMode__Enum HG::Rendering::Runtime::HGCamera::get_flipYMode(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   Object_1 *m_AdditionalCameraData; // rbx
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGAdditionalCameraData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9194A2 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9194A2 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2334, 0LL) )
				//   {
				//     m_AdditionalCameraData = (Object_1 *)this.fields.m_AdditionalCameraData;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
				//       return 0;
				//     v7 = this.fields.m_AdditionalCameraData;
				//     if ( v7 )
				//       return v7.fields.flipYMode;
				// LABEL_9:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2334, 0LL);
				//   if ( !Patch )
				//     goto LABEL_9;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return HGAdditionalCameraData.FlipYMode.Automatic;
			}
		}

		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00002AA0 File Offset: 0x00000CA0
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x000025D0 File Offset: 0x000007D0
		public HGAdditionalCameraData.AntialiasingMode antialiasing
		{
			get
			{
				// // HGAdditionalCameraData+AntialiasingMode get_antialiasing()
				// HGAdditionalCameraData_AntialiasingMode__Enum HG::Rendering::Runtime::HGCamera::get_antialiasing(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_antialiasingMode;
				// }
				// 
				return HGAdditionalCameraData.AntialiasingMode.None;
			}
			set
			{
				// // Void set_antialiasing(HGAdditionalCameraData+AntialiasingMode)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGCamera::set_antialiasing(
				//         HGCamera *this,
				//         HGAdditionalCameraData_AntialiasingMode__Enum value,
				//         MethodInfo *method)
				// {
				//   _QWORD **v5; // rcx
				//   __int64 v6; // rdx
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rbx
				//   HGAdditionalCameraData *v8; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA07 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA07 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&value);
				//     v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v6 = *v5[23];
				//   if ( !v6 )
				//     goto LABEL_24;
				//   if ( *(int *)(v6 + 24) > 656 )
				//   {
				//     if ( !*((_DWORD *)v5 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v5, v6);
				//       v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v5 = (_QWORD **)*v5[23];
				//     if ( !v5 )
				//       goto LABEL_24;
				//     if ( *((_DWORD *)v5 + 6) <= 0x290u )
				//       sub_180070270(v5, v6);
				//     if ( v5[660] )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(656, 0LL);
				//       if ( Patch )
				//       {
				//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, value, 0LL);
				//         return;
				//       }
				//       goto LABEL_24;
				//     }
				//   }
				//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//   this.fields.m_antialiasingMode = value;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
				//   if ( !byte_18D8F4EAE )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAE = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( m_AdditionalCameraData )
				//   {
				//     v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
				//     if ( m_AdditionalCameraData.fields._._._._.m_CachedPtr )
				//     {
				//       v8 = this.fields.m_AdditionalCameraData;
				//       if ( v8 )
				//       {
				//         v8.fields.antialiasing = value;
				//         return;
				//       }
				// LABEL_24:
				//       sub_180B536AC(v5, v6);
				//     }
				//   }
				// }
				// 
			}
		}

		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00002AB8 File Offset: 0x00000CB8
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x000025D0 File Offset: 0x000007D0
		public HGRenderPath renderPath
		{
			get
			{
				// // HGRenderPath get_renderPath()
				// HGRenderPath__Enum HG::Rendering::Runtime::HGCamera::get_renderPath(HGCamera *this, MethodInfo *method)
				// {
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
				// 
				//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//   if ( !m_AdditionalCameraData )
				//     sub_180B536AC(this, method);
				//   return m_AdditionalCameraData.fields.hgRenderPath;
				// }
				// 
				return (HGRenderPath)HGRenderPath.Forward;
			}
			set
			{
				// // Void set_renderPath(HGRenderPath)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGCamera::set_renderPath(HGCamera *this, HGRenderPath__Enum value, MethodInfo *method)
				// {
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
				// 
				//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//   if ( !m_AdditionalCameraData )
				//     sub_180B536AC(this, *(_QWORD *)&value);
				//   m_AdditionalCameraData.fields.hgRenderPath = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableTAAU
		{
			get
			{
				// // Boolean get_enableTAAU()
				// bool HG::Rendering::Runtime::HGCamera::get_enableTAAU(HGCamera *this, MethodInfo *method)
				// {
				//   return (this.fields.m_antialiasingMode & 2) != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableMetalFXSpatialScaler
		{
			get
			{
				// // Boolean get_enableMetalFXSpatialScaler()
				// bool HG::Rendering::Runtime::HGCamera::get_enableMetalFXSpatialScaler(HGCamera *this, MethodInfo *method)
				// {
				//   bool result; // al
				// 
				//   result = UnityEngine::SystemInfo::SupportsMetalFXSpatialScaler(0LL);
				//   if ( result )
				//     return (this.fields.m_antialiasingMode & 4) != 0;
				//   return result;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableMetalFXTemporalScaler
		{
			get
			{
				// // Boolean get_enableMetalFXTemporalScaler()
				// bool HG::Rendering::Runtime::HGCamera::get_enableMetalFXTemporalScaler(HGCamera *this, MethodInfo *method)
				// {
				//   bool result; // al
				// 
				//   result = UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL);
				//   if ( result )
				//     return (this.fields.m_antialiasingMode & 8) != 0;
				//   return result;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enablePSSR
		{
			get
			{
				// // Boolean get_enablePSSR()
				// bool HG::Rendering::Runtime::HGCamera::get_enablePSSR(HGCamera *this, MethodInfo *method)
				// {
				//   return (this.fields.m_antialiasingMode & 0x10) != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableDLSS
		{
			get
			{
				// // Boolean get_enableDLSS()
				// bool HG::Rendering::Runtime::HGCamera::get_enableDLSS(HGCamera *this, MethodInfo *method)
				// {
				//   return (this.fields.m_antialiasingMode & 0x20) != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableFSR3
		{
			get
			{
				// // Boolean get_enableFSR3()
				// bool HG::Rendering::Runtime::HGCamera::get_enableFSR3(HGCamera *this, MethodInfo *method)
				// {
				//   return (this.fields.m_antialiasingMode & 0x40) != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool enableMV
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

		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool allowDynamicResolution
		{
			get
			{
				// // Boolean get_allowDynamicResolution()
				// bool HG::Rendering::Runtime::HGCamera::get_allowDynamicResolution(HGCamera *this, MethodInfo *method)
				// {
				//   Object_1 *m_AdditionalCameraData; // rbx
				//   bool result; // al
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGAdditionalCameraData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9194A4 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9194A4 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2349, 0LL) )
				//   {
				//     m_AdditionalCameraData = (Object_1 *)this.fields.m_AdditionalCameraData;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     result = UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL);
				//     if ( !result )
				//       return result;
				//     v7 = this.fields.m_AdditionalCameraData;
				//     if ( v7 )
				//       return v7.fields.allowDynamicResolution;
				// LABEL_8:
				//     sub_180B536AC(v6, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2349, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x000025D0 File Offset: 0x000007D0
		internal HGPhysicalCamera physicalParameters
		{
			[CompilerGenerated]
			get
			{
				// // HGPhysicalCamera get_physicalParameters()
				// HGPhysicalCamera *HG::Rendering::Runtime::HGCamera::get_physicalParameters(
				//         HGPhysicalCamera *__return_ptr retstr,
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   float m_Anamorphism; // eax
				//   __int128 v4; // xmm1
				// 
				//   m_Anamorphism = this.fields._physicalParameters_k__BackingField.m_Anamorphism;
				//   v4 = *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_BladeCount;
				//   *(_OWORD *)&retstr.m_Iso = *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_Iso;
				//   *(_OWORD *)&retstr.m_BladeCount = v4;
				//   retstr.m_Anamorphism = m_Anamorphism;
				//   return retstr;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_physicalParameters(HGPhysicalCamera)
				// void HG::Rendering::Runtime::HGCamera::set_physicalParameters(
				//         HGCamera *this,
				//         HGPhysicalCamera *value,
				//         MethodInfo *method)
				// {
				//   float m_Anamorphism; // eax
				//   __int128 v4; // xmm1
				// 
				//   m_Anamorphism = value.m_Anamorphism;
				//   v4 = *(_OWORD *)&value.m_BladeCount;
				//   *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&value.m_Iso;
				//   *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_BladeCount = v4;
				//   this.fields._physicalParameters_k__BackingField.m_Anamorphism = m_Anamorphism;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x000025D2 File Offset: 0x000007D2
		internal LayerMask probeLayerMask
		{
			get
			{
				// // LayerMask get_probeLayerMask()
				// LayerMask HG::Rendering::Runtime::HGCamera::get_probeLayerMask(HGCamera *this, MethodInfo *method)
				// {
				//   Object_1 *m_AdditionalCameraData; // rbx
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGAdditionalCameraData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9194A5 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9194A5 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2350, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2350, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_846(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     m_AdditionalCameraData = (Object_1 *)this.fields.m_AdditionalCameraData;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( UnityEngine::Object::op_Inequality(m_AdditionalCameraData, 0LL, 0LL) )
				//     {
				//       v6 = this.fields.m_AdditionalCameraData;
				//       if ( v6 )
				//         return (LayerMask)v6.fields.probeLayerMask.m_Mask;
				// LABEL_9:
				//       sub_180B536AC(v5, v4);
				//     }
				//     return (LayerMask)-1;
				//   }
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x000025F0 File Offset: 0x000007F0
		internal float probeRangeCompressionFactor
		{
			get
			{
				// // Single get_probeRangeCompressionFactor()
				// float HG::Rendering::Runtime::HGCamera::get_probeRangeCompressionFactor(HGCamera *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rbx
				//   HGAdditionalCameraData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA0D )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDA0D = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v4 = *v3[23];
				//   if ( !v4 )
				//     goto LABEL_24;
				//   if ( *(int *)(v4 + 24) <= 822 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_24;
				//   if ( *((_DWORD *)v3 + 6) <= 0x336u )
				//     sub_180070270(v3, v4);
				//   if ( !v3[826] )
				//   {
				// LABEL_9:
				//     m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !byte_18D8F4EFB )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EFB = 1;
				//     }
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !byte_18D8F4EAF )
				//     {
				//       sub_18003C530(&TypeInfo::UnityEngine::Object);
				//       byte_18D8F4EAF = 1;
				//     }
				//     if ( !m_AdditionalCameraData )
				//       return 1.0;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !m_AdditionalCameraData.fields._._._._.m_CachedPtr )
				//       return 1.0;
				//     v6 = this.fields.m_AdditionalCameraData;
				//     if ( v6 )
				//       return v6.fields.probeCustomFixedExposure;
				// LABEL_24:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(822, 0LL);
				//   if ( !Patch )
				//     goto LABEL_24;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00002AD0 File Offset: 0x00000CD0
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x000025D0 File Offset: 0x000007D0
		internal HGCamera.DynamicResolutionRequest DynResRequest
		{
			[CompilerGenerated]
			get
			{
				// // HGCamera+DynamicResolutionRequest get_DynResRequest()
				// HGCamera_DynamicResolutionRequest HG::Rendering::Runtime::HGCamera::get_DynResRequest(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._DynResRequest_k__BackingField;
				// }
				// 
				return default(HGCamera.DynamicResolutionRequest);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_DynResRequest(HGCamera+DynamicResolutionRequest)
				// void HG::Rendering::Runtime::HGCamera::set_DynResRequest(
				//         HGCamera *this,
				//         HGCamera_DynamicResolutionRequest value,
				//         MethodInfo *method)
				// {
				//   this.fields._DynResRequest_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGCamera.VolumeComponentsData volumeComponentsData
		{
			get
			{
				// // HGCamera+VolumeComponentsData get_volumeComponentsData()
				// HGCamera_VolumeComponentsData *HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_volumeComponentsData;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGEnvironmentVolumeCameraComponent envVolumeCameraComponent
		{
			get
			{
				// // HGEnvironmentVolumeCameraComponent get_envVolumeCameraComponent()
				// HGEnvironmentVolumeCameraComponent *HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(
				//         HGCamera *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_envVolumeCameraComponent;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000025D2 File Offset: 0x000007D2
		internal ProfilingSampler profilingSampler
		{
			get
			{
				// // ProfilingSampler get_profilingSampler()
				// ProfilingSampler *HG::Rendering::Runtime::HGCamera::get_profilingSampler(HGCamera *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
				//   ProfilingSampler *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA0E )
				//   {
				//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
				//     byte_18D8EDA0E = 1;
				//   }
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
				//     goto LABEL_13;
				//   if ( wrapperArray.max_length.size > 810 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( v3 )
				//     {
				//       if ( LODWORD(v3._0.namespaze) <= 0x32A )
				//         sub_180070270(v3, wrapperArray);
				//       if ( !v3[17]._0.klass )
				//         goto LABEL_9;
				//       Patch = IFix::WrappersManagerImpl::GetPatch(810, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_307(Patch, (Object *)this, 0LL);
				//     }
				// LABEL_13:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				// LABEL_9:
				//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
				//   if ( !m_AdditionalCameraData )
				//     return UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
				//              (Int32Enum__Enum)0x28u,
				//              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
				//   result = m_AdditionalCameraData.fields.profilingSampler;
				//   if ( !result )
				//     return UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
				//              (Int32Enum__Enum)0x28u,
				//              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00002650 File Offset: 0x00000850
		public uint screenCullingLayerMask
		{
			get
			{
				// // UInt32 get_screenCullingLayerMask()
				// uint32_t HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(HGCamera *this, MethodInfo *method)
				// {
				//   __int64 v2; // r8
				//   __int64 v3; // r9
				//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   __int64 v8; // rax
				//   String__Array *v9; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDA0F )
				//   {
				//     sub_18003C530(&TypeInfo::System::String);
				//     sub_18003C530(&off_18C9260B0);
				//     sub_18003C530(&off_18C8ED6B0);
				//     sub_18003C530(&off_18C955808);
				//     sub_18003C530(&off_18C9261D0);
				//     sub_18003C530(&off_18C8ED6C0);
				//     sub_18003C530(&off_18C957B70);
				//     sub_18003C530(&off_18C920E00);
				//     sub_18003C530(&off_18C957B90);
				//     sub_18003C530(&off_18C94ECD0);
				//     sub_18003C530(&off_18C933910);
				//     sub_18003C530(&off_18C922B80);
				//     sub_18003C530(&off_18C953600);
				//     sub_18003C530(&off_18C926478);
				//     sub_18003C530(&off_18C957B58);
				//     sub_18003C530(&off_18C8ED740);
				//     sub_18003C530(&off_18C957B48);
				//     sub_18003C530(&off_18C8ED758);
				//     byte_18D8EDA0F = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = v5.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     goto LABEL_13;
				//   if ( wrapperArray.max_length.size <= 895 )
				//     goto LABEL_24;
				//   if ( !v5._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v5, wrapperArray);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
				//   if ( !v5 )
				//     goto LABEL_13;
				//   if ( LODWORD(v5._0.namespaze) <= 0x37F )
				//     sub_180070270(v5, wrapperArray);
				//   if ( !v5[19]._0.this_arg.data.dummy )
				//   {
				// LABEL_24:
				//     if ( this.fields._screenCullingLayerMask )
				//       return this.fields._screenCullingLayerMask;
				//     v8 = il2cpp_array_new_specific_0(TypeInfo::System::String, 17LL, v2, v3);
				//     v9 = (String__Array *)v8;
				//     if ( v8 )
				//     {
				//       sub_1800046C0(v8, 0LL, "Default");
				//       sub_1800046C0(v9, 1LL, "TransparentFX");
				//       sub_1800046C0(v9, 2LL, "Ignore Raycast");
				//       sub_1800046C0(v9, 3LL, "Water");
				//       sub_1800046C0(v9, 4LL, "UI");
				//       sub_1800046C0(v9, 5LL, "Walkable");
				//       sub_1800046C0(v9, 6LL, "Climbable");
				//       sub_1800046C0(v9, 7LL, "Trigger");
				//       sub_1800046C0(v9, 8LL, "UIPP");
				//       sub_1800046C0(v9, 9LL, "UIModel");
				//       sub_1800046C0(v9, 10LL, "Building");
				//       sub_1800046C0(v9, 11LL, "UIInteract");
				//       sub_1800046C0(v9, 12LL, "WorldUI");
				//       sub_1800046C0(v9, 13LL, "Projectile");
				//       sub_1800046C0(v9, 14LL, "AbilityEntity");
				//       sub_1800046C0(v9, 15LL, "Terrain");
				//       sub_1800046C0(v9, 16LL, "IK");
				//       this.fields._screenCullingLayerMask = UnityEngine::LayerMask::GetMask(v9, 0LL);
				//       return this.fields._screenCullingLayerMask;
				//     }
				// LABEL_13:
				//     sub_180B536AC(v5, wrapperArray);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(895, 0LL);
				//   if ( !Patch )
				//     goto LABEL_13;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0U;
			}
		}

		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000025D2 File Offset: 0x000007D2
		internal HGAdditionalCameraData additionalCameraData
		{
			get
			{
				// // HGAdditionalCameraData get_additionalCameraData()
				// HGAdditionalCameraData *HG::Rendering::Runtime::HGCamera::get_additionalCameraData(HGCamera *this, MethodInfo *method)
				// {
				//   return this.fields.m_AdditionalCameraData;
				// }
				// 
				return null;
			}
		}

		internal HGCamera(Camera cam)
		{
			// // HGCamera(Camera)
			// void HG::Rendering::Runtime::HGCamera::HGCamera(HGCamera *this, Camera *cam, MethodInfo *method)
			// {
			//   Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v5; // rax
			//   OneofDescriptorProto *v6; // rdx
			//   Component *camera; // rcx
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *v8; // rbx
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   LowLevelList_1_System_Object_ *v12; // rax
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *v13; // rbx
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   __int64 v17; // rcx
			//   __m128 v18; // xmm2
			//   __m128 v19; // xmm2
			//   __int128 *v20; // rax
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm2
			//   __int128 v24; // xmm3
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v25; // rax
			//   List_1_System_Int32_ *v26; // rbx
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   HGPhysicalCamera *Defaults; // rax
			//   float m_Anamorphism; // ecx
			//   __int128 v32; // xmm1
			//   HGCamera_VolumeComponentsData *v33; // rax
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   HGEnvironmentVolumeCameraComponent *v36; // rax
			//   HGEnvironmentVolumeCameraComponent *v37; // rbx
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   __int128 *v41; // rax
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm2
			//   __int128 v45; // xmm3
			//   BufferedRTHandleSystem *v46; // rax
			//   BufferedRTHandleSystem *v47; // rbx
			//   OneofDescriptorProto *v48; // rdx
			//   FileDescriptor *v49; // r8
			//   MessageDescriptor *v50; // r9
			//   MaterialPropertyBlock *v51; // rbx
			//   OneofDescriptorProto *v52; // rdx
			//   FileDescriptor *v53; // r8
			//   MessageDescriptor *v54; // r9
			//   OneofDescriptorProto *v55; // rdx
			//   FileDescriptor *v56; // r8
			//   MessageDescriptor *v57; // r9
			//   OneofDescriptorProto *v58; // rdx
			//   FileDescriptor *v59; // r8
			//   MessageDescriptor *v60; // r9
			//   __int64 v61; // r8
			//   __int64 v62; // r9
			//   OneofDescriptorProto *v63; // rdx
			//   FileDescriptor *v64; // r8
			//   MessageDescriptor *v65; // r9
			//   __int64 v66; // r8
			//   __int64 v67; // r9
			//   OneofDescriptorProto *v68; // rdx
			//   FileDescriptor *v69; // r8
			//   MessageDescriptor *v70; // r9
			//   __int64 v71; // r8
			//   __int64 v72; // r9
			//   OneofDescriptorProto *v73; // rdx
			//   FileDescriptor *v74; // r8
			//   MessageDescriptor *v75; // r9
			//   __int64 v76; // rdx
			//   VolumeManager *instance; // rax
			//   OneofDescriptorProto *v78; // rdx
			//   FileDescriptor *v79; // r8
			//   MessageDescriptor *v80; // r9
			//   GameObject *gameObject; // rax
			//   __int64 v82; // r8
			//   __int64 v83; // r9
			//   __int128 v84; // xmm1
			//   __int128 v85; // xmm0
			//   OneofDescriptorProto *v86; // rdx
			//   FileDescriptor *v87; // r8
			//   MessageDescriptor *v88; // r9
			//   int i; // r14d
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rbx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v91; // rax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v92; // rsi
			//   FileDescriptor *v93; // r8
			//   MessageDescriptor *v94; // r9
			//   int j; // esi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v96; // rax
			//   List_1_System_Object_ *v97; // rbp
			//   HashSet_1_System_Object_ *v98; // rax
			//   Object *v99; // rbx
			//   HGShadowManager *v100; // rax
			//   HGShadowManager *v101; // rbx
			//   OneofDescriptorProto *v102; // rdx
			//   FileDescriptor *v103; // r8
			//   MessageDescriptor *v104; // r9
			//   HGLightCookieManager *v105; // rax
			//   HGLightCookieManager *v106; // rbx
			//   OneofDescriptorProto *v107; // rdx
			//   FileDescriptor *v108; // r8
			//   MessageDescriptor *v109; // r9
			//   __int64 v110; // rax
			//   FileDescriptor *v111; // r8
			//   MessageDescriptor *v112; // r9
			//   __int64 v113; // rdx
			//   Object_1 *parafinMesh; // rbx
			//   OneofDescriptorProto *v115; // rdx
			//   FileDescriptor *v116; // r8
			//   MessageDescriptor *v117; // r9
			//   GameObject *v118; // rax
			//   OneofDescriptorProto *v119; // rdx
			//   FileDescriptor *v120; // r8
			//   MessageDescriptor *v121; // r9
			//   String__Array *v122; // [rsp+20h] [rbp-78h]
			//   String__Array *v123; // [rsp+20h] [rbp-78h]
			//   __m128 v124; // [rsp+20h] [rbp-78h]
			//   String__Array *v125; // [rsp+20h] [rbp-78h]
			//   String__Array *v126; // [rsp+20h] [rbp-78h]
			//   String__Array *v127; // [rsp+20h] [rbp-78h]
			//   String__Array *v128; // [rsp+20h] [rbp-78h]
			//   String__Array *v129; // [rsp+20h] [rbp-78h]
			//   String__Array *v130; // [rsp+20h] [rbp-78h]
			//   String__Array *v131; // [rsp+20h] [rbp-78h]
			//   String__Array *v132; // [rsp+20h] [rbp-78h]
			//   String__Array *v133; // [rsp+20h] [rbp-78h]
			//   String__Array *v134; // [rsp+20h] [rbp-78h]
			//   String__Array *v135; // [rsp+20h] [rbp-78h]
			//   String__Array *v136; // [rsp+20h] [rbp-78h]
			//   String__Array *v137; // [rsp+20h] [rbp-78h]
			//   String__Array *v138; // [rsp+20h] [rbp-78h]
			//   String__Array *v139; // [rsp+20h] [rbp-78h]
			//   String *v140; // [rsp+28h] [rbp-70h]
			//   String *v141; // [rsp+28h] [rbp-70h]
			//   String *v142; // [rsp+28h] [rbp-70h]
			//   String *v143; // [rsp+28h] [rbp-70h]
			//   String *v144; // [rsp+28h] [rbp-70h]
			//   String *v145; // [rsp+28h] [rbp-70h]
			//   String *v146; // [rsp+28h] [rbp-70h]
			//   String *v147; // [rsp+28h] [rbp-70h]
			//   String *v148; // [rsp+28h] [rbp-70h]
			//   String *v149; // [rsp+28h] [rbp-70h]
			//   String *v150; // [rsp+28h] [rbp-70h]
			//   String *v151; // [rsp+28h] [rbp-70h]
			//   String *v152; // [rsp+28h] [rbp-70h]
			//   String *v153; // [rsp+28h] [rbp-70h]
			//   String *v154; // [rsp+28h] [rbp-70h]
			//   String *v155; // [rsp+28h] [rbp-70h]
			//   String *v156; // [rsp+28h] [rbp-70h]
			//   __m256i v157; // [rsp+30h] [rbp-68h] BYREF
			//   _BYTE v158[24]; // [rsp+50h] [rbp-48h]
			//   __int64 v159; // [rsp+A0h] [rbp+8h]
			// 
			//   if ( !byte_18D8EDA10 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BufferedRTHandleSystem);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::HashSet);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Plane);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector4);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera::VolumeComponentsData);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::VolumeManager);
			//     sub_18003C530(&off_18C8ED468);
			//     byte_18D8EDA10 = 1;
			//   }
			//   this.fields.autoExposureReadyForNextFetch = 1;
			//   this.fields.exposureTargetAdaptation = 1.0;
			//   this.fields.exposureAdaptation = 1.0;
			//   this.fields.waterCameraFoVInc = 20.0;
			//   this.fields.m_nextWaterMarkHandle = 1;
			//   this.fields.m_finalRTSize = (Vector2Int)-1LL;
			//   v5 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>);
			//   v8 = (Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *)v5;
			//   if ( !v5 )
			//     goto LABEL_37;
			//   System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
			//     v5,
			//     MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Dictionary);
			//   this.fields.m_waterMarkRTs = v8;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_waterMarkRTs,
			//     v9,
			//     v10,
			//     v11,
			//     v122,
			//     v140,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   v12 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>);
			//   v13 = (List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *)v12;
			//   if ( !v12 )
			//     goto LABEL_37;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v12,
			//     MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::List);
			//   this.fields.m_inplaceWaterMarkRTs = v13;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_inplaceWaterMarkRTs,
			//     v14,
			//     v15,
			//     v16,
			//     v123,
			//     v141,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.beforeCullingParams = 0LL;
			//   v159 = sub_184D03A3C(v17, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//   v124.m128_u64[0] = 0LL;
			//   v18 = _mm_shuffle_ps(v124, v124, 210);
			//   v18.m128_f32[0] = *(float *)&v159;
			//   v19 = _mm_shuffle_ps(v18, v18, 39);
			//   v19.m128_f32[0] = *((float *)&v159 + 1);
			//   this.fields.finalViewport = (Rect)_mm_shuffle_ps(v19, v19, 57);
			//   v20 = (__int128 *)sub_182805160(&v157);
			//   v21 = *v20;
			//   v22 = v20[1];
			//   v23 = v20[2];
			//   v24 = v20[3];
			//   this.fields.m_firstGetDoFComponent = 1;
			//   *(_OWORD *)&this.fields.frustumCornorsRay.m00 = v21;
			//   this.fields.lowResScale = 0.5;
			//   *(_OWORD *)&this.fields.frustumCornorsRay.m01 = v22;
			//   this.fields.m_PreviousClearColorMode = 2;
			//   *(_OWORD *)&this.fields.frustumCornorsRay.m02 = v23;
			//   this.fields.m_uiAfterBlurSortingOrder = 0x7FFF;
			//   *(_OWORD *)&this.fields.frustumCornorsRay.m03 = v24;
			//   v25 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//   v26 = (List_1_System_Int32_ *)v25;
			//   if ( !v25 )
			//     goto LABEL_37;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v25,
			//     MethodInfo::System::Collections::Generic::List<int>::List);
			//   this.fields.m_sortingOrdersToBlur = v26;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_sortingOrdersToBlur,
			//     v27,
			//     v28,
			//     v29,
			//     0LL,
			//     (String *)v124.m128_u64[1],
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.resetPostProcessingHistory = 1;
			//   Defaults = HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults((HGPhysicalCamera *)&v157, 0LL);
			//   m_Anamorphism = Defaults.m_Anamorphism;
			//   v32 = *(_OWORD *)&Defaults.m_BladeCount;
			//   *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&Defaults.m_Iso;
			//   *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_BladeCount = v32;
			//   this.fields._physicalParameters_k__BackingField.m_Anamorphism = m_Anamorphism;
			//   v33 = (HGCamera_VolumeComponentsData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCamera::VolumeComponentsData);
			//   if ( !v33 )
			//     goto LABEL_37;
			//   this.fields.m_volumeComponentsData = v33;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_volumeComponentsData,
			//     v6,
			//     v34,
			//     v35,
			//     v125,
			//     v142,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   v36 = (HGEnvironmentVolumeCameraComponent *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent);
			//   v37 = v36;
			//   if ( !v36 )
			//     goto LABEL_37;
			//   HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::HGEnvironmentVolumeCameraComponent(v36, 0LL);
			//   this.fields.m_envVolumeCameraComponent = v37;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_envVolumeCameraComponent,
			//     v38,
			//     v39,
			//     v40,
			//     v126,
			//     v143,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.screenCullingRatio = 0.0049999999;
			//   this.fields.screenRatioCullingDistance = 30.0;
			//   this.fields.cullingViewHandle = -1;
			//   *(_QWORD *)&this.fields.terrainCullViewHandle = -1LL;
			//   *(_QWORD *)&this.fields.waterProxyCullHandle = -1LL;
			//   v41 = (__int128 *)sub_182805160(&v157);
			//   v42 = *v41;
			//   v43 = v41[1];
			//   v44 = v41[2];
			//   v45 = v41[3];
			//   this.fields.reflectionProbeOctTextureArrayCount = 1;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m00 = v42;
			//   *(_QWORD *)&this.fields.rayTracingCullingViewHandle = -1LL;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m01 = v43;
			//   this.fields.overrideCsmMaxDistanceValue = 80.0;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m02 = v44;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m03 = v45;
			//   v46 = (BufferedRTHandleSystem *)sub_180004920(TypeInfo::UnityEngine::Rendering::BufferedRTHandleSystem);
			//   v47 = v46;
			//   if ( !v46 )
			//     goto LABEL_37;
			//   UnityEngine::Rendering::BufferedRTHandleSystem::BufferedRTHandleSystem(v46, 0LL);
			//   this.fields.m_HistoryRTSystem = v47;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_HistoryRTSystem,
			//     v48,
			//     v49,
			//     v50,
			//     v127,
			//     v144,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.m_RecorderTempRT = UnityEngine::Shader::PropertyToID((String *)"TempRecorder", 0LL);
			//   v51 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//   if ( !v51 )
			//     goto LABEL_37;
			//   v51.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.m_RecorderPropertyBlock = v51;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_RecorderPropertyBlock,
			//     v52,
			//     v53,
			//     v54,
			//     v128,
			//     v145,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.m_ForceJitterIdx = -1;
			//   this.fields._msaaSamples_k__BackingField = 1;
			//   this.fields.camera = cam;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.camera, v55, v56, v57, v129, v146, (MethodInfo *)v157.m256i_i64[0]);
			//   if ( !cam )
			//     goto LABEL_37;
			//   this.fields._name_k__BackingField = UnityEngine::Object::get_name((Object_1 *)cam, 0LL);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v58, v59, v60, v130, v147, (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.frustum = 0LL;
			//   this.fields.frustum.planes = (Plane__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Plane, 6LL, v61, v62);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.frustum, v63, v64, v65, v131, v148, (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.frustum.corners = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                                                      TypeInfo::UnityEngine::Vector3,
			//                                                      8LL,
			//                                                      v66,
			//                                                      v67);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.frustum.corners,
			//     v68,
			//     v69,
			//     v70,
			//     v132,
			//     v149,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   this.fields.frustumPlaneEquations = (Vector4__Array *)il2cpp_array_new_specific_0(
			//                                                            TypeInfo::UnityEngine::Vector4,
			//                                                            6LL,
			//                                                            v71,
			//                                                            v72);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.frustumPlaneEquations,
			//     v73,
			//     v74,
			//     v75,
			//     v133,
			//     v150,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   if ( !TypeInfo::UnityEngine::Rendering::VolumeManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::VolumeManager, v76);
			//   instance = UnityEngine::Rendering::VolumeManager::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_37;
			//   this.fields._volumeStack_k__BackingField = UnityEngine::Rendering::VolumeManager::CreateStack(instance, 0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields._volumeStack_k__BackingField,
			//     v78,
			//     v79,
			//     v80,
			//     v134,
			//     v151,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::Allocate(&this.fields.m_DepthBufferMipChainInfo, 0LL);
			//   camera = (Component *)this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_37;
			//   gameObject = UnityEngine::Component::get_gameObject(camera, 0LL);
			//   if ( !gameObject )
			//     goto LABEL_37;
			//   if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
			//           gameObject,
			//           (Object **)&this.fields.m_AdditionalCameraData,
			//           MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>) )
			//   {
			//     camera = (Component *)this.fields.camera;
			//     if ( !camera )
			//       goto LABEL_37;
			//     v118 = UnityEngine::Component::get_gameObject(camera, 0LL);
			//     if ( !v118 )
			//       goto LABEL_37;
			//     this.fields.m_AdditionalCameraData = (HGAdditionalCameraData *)UnityEngine::GameObject::AddComponent<System::Object>(
			//                                                                       v118,
			//                                                                       MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_AdditionalCameraData,
			//       v119,
			//       v120,
			//       v121,
			//       v135,
			//       v152,
			//       (MethodInfo *)v157.m256i_i64[0]);
			//   }
			//   *(_OWORD *)&v158[4] = 0LL;
			//   v157.m256i_i64[0] = 0LL;
			//   *(__m128i *)((char *)&v157.m256i_u64[1] + 4) = _mm_load_si128((const __m128i *)&xmmword_18A357E20);
			//   v157.m256i_i32[2] = 0;
			//   v157.m256i_i32[7] = 2139095039;
			//   v84 = *(_OWORD *)&v157.m256i_u64[2];
			//   *(_DWORD *)v158 = 2139095039;
			//   *(_OWORD *)&this.fields.lodCrossFadeConfig.cameraPosition.x = *(_OWORD *)v157.m256i_i8;
			//   *(_DWORD *)&v158[20] = 0;
			//   v85 = *(_OWORD *)v158;
			//   *(_OWORD *)&this.fields.lodCrossFadeConfig.c0.y = v84;
			//   *(_QWORD *)&v84 = *(_QWORD *)&v158[16];
			//   *(_OWORD *)&this.fields.lodCrossFadeConfig.c1.z = v85;
			//   *(_QWORD *)&this.fields.lodCrossFadeConfig.maxProjFactorSquared1 = v84;
			//   this.fields.m_rtExtractionLists = (List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *)il2cpp_array_new_specific_0(
			//                                                                                                   TypeInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>,
			//                                                                                                   2LL,
			//                                                                                                   v82,
			//                                                                                                   v83);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_rtExtractionLists,
			//     v86,
			//     v87,
			//     v88,
			//     v135,
			//     v152,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   for ( i = 0; i < 2; ++i )
			//   {
			//     m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//     v91 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>);
			//     v92 = v91;
			//     if ( !v91 )
			//       goto LABEL_37;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v91,
			//       MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::List);
			//     if ( !m_rtExtractionLists )
			//       goto LABEL_37;
			//     sub_180036D40(m_rtExtractionLists, v92);
			//     if ( (unsigned int)i >= m_rtExtractionLists.max_length.size )
			// LABEL_41:
			//       sub_180070270(camera, v6);
			//     m_rtExtractionLists.vector[i] = (List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *)v92;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&m_rtExtractionLists.vector[i],
			//       v6,
			//       v93,
			//       v94,
			//       v136,
			//       v153,
			//       (MethodInfo *)v157.m256i_i64[0]);
			//     for ( j = 0; j < 4; ++j )
			//     {
			//       v96 = this.fields.m_rtExtractionLists;
			//       if ( !v96 )
			//         goto LABEL_37;
			//       if ( (unsigned int)i >= v96.max_length.size )
			//         goto LABEL_41;
			//       v97 = (List_1_System_Object_ *)v96.vector[i];
			//       v98 = (HashSet_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>);
			//       v99 = (Object *)v98;
			//       if ( !v98 )
			//         goto LABEL_37;
			//       System::Collections::Generic::HashSet<System::Object>::HashSet(
			//         v98,
			//         MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::HashSet);
			//       if ( !v97 )
			//         goto LABEL_37;
			//       sub_1822AD140(v97, v99);
			//     }
			//   }
			//   v100 = (HGShadowManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//   v101 = v100;
			//   if ( !v100 )
			//     goto LABEL_37;
			//   HG::Rendering::Runtime::HGShadowManager::HGShadowManager(v100, 0LL);
			//   this.fields.shadowManager = v101;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.shadowManager,
			//     v102,
			//     v103,
			//     v104,
			//     v136,
			//     v153,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   v105 = (HGLightCookieManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//   v106 = v105;
			//   if ( !v105
			//     || (HG::Rendering::Runtime::HGLightCookieManager::HGLightCookieManager(v105, 0LL),
			//         this.fields.lightCookieManager = v106,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.lightCookieManager,
			//           v107,
			//           v108,
			//           v109,
			//           v137,
			//           v154,
			//           (MethodInfo *)v157.m256i_i64[0]),
			//         (v110 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager)) == 0) )
			//   {
			// LABEL_37:
			//     sub_180B536AC(camera, v6);
			//   }
			//   *(_DWORD *)(v110 + 24) = -1;
			//   *(_DWORD *)(v110 + 32) = 1065353216;
			//   *(_DWORD *)(v110 + 36) = 1;
			//   this.fields.verticalOcclusionMapManager = (HGVerticalOcclusionMapManager *)v110;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.verticalOcclusionMapManager,
			//     v6,
			//     v111,
			//     v112,
			//     v138,
			//     v155,
			//     (MethodInfo *)v157.m256i_i64[0]);
			//   parafinMesh = (Object_1 *)this.fields.parafinMesh;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v113);
			//   if ( UnityEngine::Object::op_Equality(parafinMesh, 0LL, 0LL) )
			//   {
			//     this.fields.parafinMesh = HG::Rendering::Runtime::HGCamera::CreateParafinTriangleMesh(this, 0.001, 0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.parafinMesh,
			//       v115,
			//       v116,
			//       v117,
			//       v139,
			//       v156,
			//       (MethodInfo *)v157.m256i_i64[0]);
			//     camera = (Component *)this.fields.parafinMesh;
			//     if ( camera )
			//     {
			//       UnityEngine::Mesh::UploadMeshData((Mesh *)camera, 1, 0LL);
			//       goto LABEL_36;
			//     }
			//     goto LABEL_37;
			//   }
			// LABEL_36:
			//   HG::Rendering::Runtime::HGCamera::InitializeVolumeComponentsData(this, 0LL);
			//   HG::Rendering::Runtime::HGCamera::Reset(this, 0LL);
			// }
			// 
		}

		public uint RegisterWaterMarkRTs(RTHandle srcRT, RTHandle dstRT, float heightScale)
		{
			// // UInt32 RegisterWaterMarkRTs(RTHandle, RTHandle, Single)
			// uint32_t HG::Rendering::Runtime::HGCamera::RegisterWaterMarkRTs(
			//         HGCamera *this,
			//         RTHandle *srcRT,
			//         RTHandle *dstRT,
			//         float heightScale,
			//         MethodInfo *method)
			// {
			//   uint32_t m_nextWaterMarkHandle; // ebx
			//   uint32_t v9; // eax
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rdi
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   ValueTuple_3_Object_Object_Single_ v17; // [rsp+30h] [rbp-58h] BYREF
			//   ValueTuple_3_Object_Object_Single_ v18; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919494 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Add);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//     byte_18D919494 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2309, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2309, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_834(
			//              Patch,
			//              (Object *)this,
			//              (Object *)srcRT,
			//              (Object *)dstRT,
			//              heightScale,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_nextWaterMarkHandle = this.fields.m_nextWaterMarkHandle;
			//     v9 = m_nextWaterMarkHandle + 1;
			//     this.fields.m_nextWaterMarkHandle = m_nextWaterMarkHandle + 1;
			//     if ( !m_nextWaterMarkHandle )
			//     {
			//       ++m_nextWaterMarkHandle;
			//       this.fields.m_nextWaterMarkHandle = v9 + 1;
			//     }
			//     m_waterMarkRTs = this.fields.m_waterMarkRTs;
			//     memset(&v17, 0, sizeof(v17));
			//     System::ValueTuple<System::Object,System::Object,float>::ValueTuple(
			//       &v17,
			//       (Object *)srcRT,
			//       (Object *)dstRT,
			//       heightScale,
			//       MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//     if ( !m_waterMarkRTs )
			//       sub_180B536AC(v12, v11);
			//     v18 = v17;
			//     sub_180830320(m_waterMarkRTs, m_nextWaterMarkHandle, &v18);
			//     return m_nextWaterMarkHandle;
			//   }
			// }
			// 
			return 0U;
		}

		public void UnregisterWaterMarkRTs(uint waterMarkHandle)
		{
			// // Void UnregisterWaterMarkRTs(UInt32)
			// void HG::Rendering::Runtime::HGCamera::UnregisterWaterMarkRTs(
			//         HGCamera *this,
			//         uint32_t waterMarkHandle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919495 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Remove);
			//     byte_18D919495 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2310, 0LL) )
			//   {
			//     m_waterMarkRTs = this.fields.m_waterMarkRTs;
			//     if ( m_waterMarkRTs )
			//     {
			//       System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Core::EntityManager_EntityDataStorage::HideByTypeParams>::Remove(
			//         (Dictionary_2_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ *)m_waterMarkRTs,
			//         waterMarkHandle,
			//         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Remove);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_waterMarkRTs, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2310, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//     (ILFixDynamicMethodWrapper_26 *)Patch,
			//     (Object *)this,
			//     waterMarkHandle,
			//     0LL);
			// }
			// 
		}

		public void RegisterInplaceWaterMarkRTs(RTHandle dstRT, float heightScale)
		{
			// // Void RegisterInplaceWaterMarkRTs(RTHandle, Single)
			// void HG::Rendering::Runtime::HGCamera::RegisterInplaceWaterMarkRTs(
			//         HGCamera *this,
			//         RTHandle *dstRT,
			//         float heightScale,
			//         MethodInfo *method)
			// {
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *m_inplaceWaterMarkRTs; // rbx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   ValueTuple_2_Object_Single_ v12; // [rsp+30h] [rbp-38h] BYREF
			//   ValueTuple_2_Object_Single_ v13; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919496 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Add);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//     byte_18D919496 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2311, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2311, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//       (ILFixDynamicMethodWrapper_9 *)Patch,
			//       (Object *)this,
			//       (Object *)dstRT,
			//       heightScale,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_inplaceWaterMarkRTs = this.fields.m_inplaceWaterMarkRTs;
			//     v12 = 0LL;
			//     System::ValueTuple<System::Object,float>::ValueTuple(
			//       &v12,
			//       (Object *)dstRT,
			//       heightScale,
			//       MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//     if ( !m_inplaceWaterMarkRTs )
			//       sub_180B536AC(v8, v7);
			//     v13 = v12;
			//     sub_180830370(m_inplaceWaterMarkRTs, &v13);
			//   }
			// }
			// 
		}

		public Dictionary<uint, ValueTuple<RTHandle, RTHandle, float>> GetWaterMarkRTs()
		{
			// // Dictionary`2[System.UInt32,System.ValueTuple`3[UnityEngine.Rendering.RTHandle,UnityEngine.Rendering.RTHandle,Single]] GetWaterMarkRTs()
			// Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *HG::Rendering::Runtime::HGCamera::GetWaterMarkRTs(
			//         HGCamera *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2312, 0LL) )
			//     return this.fields.m_waterMarkRTs;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2312, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_835(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public List<ValueTuple<RTHandle, float>> GetInplaceWaterMarkRTs()
		{
			// // List`1[System.ValueTuple`2[UnityEngine.Rendering.RTHandle,Single]] GetInplaceWaterMarkRTs()
			// List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(
			//         HGCamera *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2313, 0LL) )
			//     return this.fields.m_inplaceWaterMarkRTs;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2313, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_836(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void TransferWaterMarkRTs(HGCamera cam)
		{
			// // Void TransferWaterMarkRTs(HGCamera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGCamera::TransferWaterMarkRTs(HGCamera *this, HGCamera *cam, MethodInfo *method)
			// {
			//   HGCamera *v3; // rdi
			//   HGCamera *v4; // rsi
			//   unsigned __int64 v5; // rdx
			//   Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *v6; // rcx
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // r14
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_Object_Object_Single_ *v10; // r14
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *m_inplaceWaterMarkRTs; // rax
			//   signed __int64 v14; // rcx
			//   ObjectReflector_ReflectType_FieldInfo v15; // xmm0
			//   List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *v16; // r9
			//   unsigned __int64 v17; // r8
			//   signed __int64 v18; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   _BYTE v22[32]; // [rsp+0h] [rbp-158h] BYREF
			//   __int128 name; // [rsp+30h] [rbp-128h] BYREF
			//   ValueTuple_3_Object_Object_Single_ v24; // [rsp+40h] [rbp-118h] BYREF
			//   ValueTuple_3_Object_Object_Single_ v25; // [rsp+60h] [rbp-F8h] BYREF
			//   FacLineDrawer_LineData value; // [rsp+88h] [rbp-D0h] BYREF
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ v27; // [rsp+A0h] [rbp-B8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v28; // [rsp+C0h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v29; // [rsp+F8h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v30; // [rsp+100h] [rbp-58h] BYREF
			//   KeyValuePair_2_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ current; // [rsp+108h] [rbp-50h] BYREF
			//   uint32_t key; // [rsp+178h] [rbp+20h] BYREF
			// 
			//   v3 = cam;
			//   v4 = this;
			//   if ( !byte_18D919497 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//     byte_18D919497 = 1;
			//   }
			//   memset(&v28, 0, sizeof(v28));
			//   key = 0;
			//   memset(&value, 0, sizeof(value));
			//   memset(&v27, 0, sizeof(v27));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1077, 0LL) )
			//   {
			//     m_waterMarkRTs = v4.fields.m_waterMarkRTs;
			//     if ( !m_waterMarkRTs )
			//       sub_180B536AC(v6, v5);
			//     if ( m_waterMarkRTs.fields._count != m_waterMarkRTs.fields._freeCount )
			//     {
			//       if ( !v3 )
			//         sub_180B536AC(v6, v5);
			//       if ( !v3.fields.m_waterMarkRTs )
			//         sub_180B536AC(v6, v5);
			//       System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//         (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v3.fields.m_waterMarkRTs,
			//         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Clear);
			//       if ( !v4.fields.m_waterMarkRTs )
			//         sub_180B536AC(v9, v8);
			//       v28 = *(Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ *)sub_180830350(&current, v4.fields.m_waterMarkRTs);
			//       *(_QWORD *)&name = 0LL;
			//       *((_QWORD *)&name + 1) = &v28;
			//       try
			//       {
			//         while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
			//                   &v28,
			//                   MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//         {
			//           current = v28._current;
			//           System::Collections::Generic::KeyValuePair<unsigned int,Beyond::UI::FacLineDrawer::LineData>::Deconstruct(
			//             &current,
			//             &key,
			//             &value,
			//             MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
			//           v10 = (Dictionary_2_System_UInt32_System_ValueTuple_3_Object_Object_Single_ *)v3.fields.m_waterMarkRTs;
			//           memset(&v25, 0, sizeof(v25));
			//           System::ValueTuple<System::Object,System::Object,float>::ValueTuple(
			//             &v25,
			//             (Object *)value.start,
			//             (Object *)value.end,
			//             *(float *)&value.link,
			//             MethodInfo::System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>::ValueTuple);
			//           if ( !v10 )
			//             sub_1802DC2C8(v12, v11);
			//           v24 = v25;
			//           System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<System::Object,System::Object,float>>::Add(
			//             v10,
			//             key,
			//             &v24,
			//             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Add);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v29 )
			//       {
			//         v5 = (unsigned __int64)v22;
			//         *(Il2CppExceptionWrapper *)&name = (Il2CppExceptionWrapper)v29.ex;
			//         v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)name;
			//         if ( (_QWORD)name )
			//           sub_18000F780(name);
			//         v3 = cam;
			//         v4 = this;
			//       }
			//       if ( !v3 )
			//         goto LABEL_45;
			//       v3.fields.m_nextWaterMarkHandle = v4.fields.m_nextWaterMarkHandle;
			//       v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v4.fields.m_waterMarkRTs;
			//       if ( !v6 )
			//         goto LABEL_45;
			//       System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//         v6,
			//         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Clear);
			//     }
			//     m_inplaceWaterMarkRTs = v4.fields.m_inplaceWaterMarkRTs;
			//     if ( m_inplaceWaterMarkRTs )
			//     {
			//       if ( !m_inplaceWaterMarkRTs.fields._size )
			//         return;
			//       if ( v3 )
			//       {
			//         v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v3.fields.m_inplaceWaterMarkRTs;
			//         if ( v6 )
			//         {
			//           sub_18312A880(
			//             v6,
			//             MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Clear);
			//           v5 = (unsigned __int64)v4.fields.m_inplaceWaterMarkRTs;
			//           if ( v5 )
			//           {
			//             System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
			//               (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&current,
			//               (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v5,
			//               MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//             v27 = (List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_)current;
			//             v24.Item1 = 0LL;
			//             v24.Item2 = (Object *)&v27;
			//             try
			//             {
			//               while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::MoveNext(
			//                         &v27,
			//                         MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//               {
			//                 v15 = v27._current;
			//                 v16 = (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v3.fields.m_inplaceWaterMarkRTs;
			//                 name = (unsigned __int64)v27._current.name;
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v17 = (((unsigned __int64)&name >> 12) & 0x1FFFFF) >> 6;
			//                   v5 = ((unsigned __int64)&name >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6870D0[v17]);
			//                   do
			//                   {
			//                     v14 = qword_18D6870D0[v17] | (1LL << v5);
			//                     v18 = qword_18D6870D0[v17];
			//                   }
			//                   while ( v18 != _InterlockedCompareExchange64(&qword_18D6870D0[v17], v14, v18) );
			//                 }
			//                 DWORD2(name) = _mm_shuffle_ps((__m128)v15, (__m128)v15, 170).m128_u32[0];
			//                 if ( !v16 )
			//                   sub_1802DC2C8(v14, v5);
			//                 *(_OWORD *)&v25.Item1 = name;
			//                 System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::Add(
			//                   v16,
			//                   (ObjectReflector_ReflectType_FieldInfo *)&v25,
			//                   MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Add);
			//               }
			//             }
			//             catch ( Il2CppExceptionWrapper *v30 )
			//             {
			//               v5 = (unsigned __int64)v22;
			//               v24.Item1 = (Object *)v30.ex;
			//               if ( v24.Item1 )
			//                 sub_18000F780(v24.Item1);
			//               v4 = this;
			//             }
			//             v6 = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v4.fields.m_inplaceWaterMarkRTs;
			//             if ( v6 )
			//             {
			//               sub_18312A880(
			//                 v6,
			//                 MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Clear);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_45:
			//     sub_1802DC2C8(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1077, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v21, v20);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v4, (Object *)v3, 0LL);
			// }
			// 
		}

		public HGCamera.WaterMarkOutputCPP GetWaterMarkRTsCPP(ref int count)
		{
			// // HGCamera+WaterMarkOutputCPP GetWaterMarkRTsCPP(Int32 ByRef)
			// // Hidden C++ exception states: #wind=1
			// HGCamera_WaterMarkOutputCPP *HG::Rendering::Runtime::HGCamera::GetWaterMarkRTsCPP(
			//         HGCamera_WaterMarkOutputCPP *__return_ptr retstr,
			//         HGCamera *this,
			//         int32_t *count,
			//         MethodInfo *method)
			// {
			//   HGCamera_WaterMarkOutputCPP *v6; // r15
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGCamera_WaterMarkOutputCPP *v13; // rax
			//   __int128 v14; // xmm0
			//   float *heightScales; // xmm1_8
			//   Dictionary_2_System_UInt32_System_ValueTuple_3_UnityEngine_Rendering_RTHandle_UnityEngine_Rendering_RTHandle_Single_ *m_waterMarkRTs; // rdi
			//   int32_t v17; // eax
			//   _DWORD *v18; // rsi
			//   _DWORD *v19; // r12
			//   _DWORD *v20; // r13
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   __m128d v26; // xmm6
			//   struct MethodInfo *v27; // rdi
			//   Il2CppClass *klass; // rcx
			//   Il2CppClass *v29; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   int v32; // xmm6_4
			//   RenderTexture *v33; // rdi
			//   RenderTexture *v34; // rsi
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   __int64 v37; // r14
			//   int32_t InstanceID; // eax
			//   __int64 v39; // rdi
			//   HGCamera_WaterMarkOutputCPP *result; // rax
			//   String__Array *v41; // [rsp+20h] [rbp-118h]
			//   String *v42; // [rsp+28h] [rbp-110h]
			//   __int128 v43; // [rsp+30h] [rbp-108h] BYREF
			//   _DWORD *v44; // [rsp+40h] [rbp-F8h]
			//   _DWORD *TempFromCSharp; // [rsp+48h] [rbp-F0h]
			//   _DWORD *v46; // [rsp+50h] [rbp-E8h]
			//   _DWORD *v47; // [rsp+58h] [rbp-E0h]
			//   HGCamera_WaterMarkOutputCPP v48; // [rsp+60h] [rbp-D8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v49; // [rsp+78h] [rbp-C0h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_UI_FacLineDrawer_LineData_ v50; // [rsp+B0h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v51; // [rsp+E8h] [rbp-50h] BYREF
			// 
			//   v6 = retstr;
			//   if ( !byte_18D8ED9F5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct);
			//     byte_18D8ED9F5 = 1;
			//   }
			//   v43 = 0LL;
			//   v44 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, this);
			//   if ( wrapperArray.max_length.size <= 813 )
			//     goto LABEL_16;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = v7.static_fields.wrapperArray;
			//   if ( !v9 )
			//     sub_180B536AC(v7, this);
			//   if ( v9.max_length.size <= 0x32Du )
			//     sub_180070270(v7, this);
			//   if ( !v9[22].vector[21] )
			//   {
			// LABEL_16:
			//     m_waterMarkRTs = this.fields.m_waterMarkRTs;
			//     if ( !m_waterMarkRTs )
			//       sub_180B536AC(v7, this);
			//     v17 = m_waterMarkRTs.fields._count - m_waterMarkRTs.fields._freeCount;
			//     *count = v17;
			//     v18 = 0LL;
			//     v19 = 0LL;
			//     v20 = 0LL;
			//     if ( v17 <= 0 )
			//       goto LABEL_34;
			//     TempFromCSharp = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * v17, 0LL);
			//     v19 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * *count, 0LL);
			//     v46 = v19;
			//     v20 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * *count, 0LL);
			//     v47 = v20;
			//     *count = 0;
			//     if ( !this.fields.m_waterMarkRTs )
			//       sub_180B536AC(v22, v21);
			//     System::Collections::Generic::Dictionary<System::Text::RegularExpressions::Regex::CachedCodeEntryKey,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)&v49,
			//       (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)this.fields.m_waterMarkRTs,
			//       MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     v50 = v49;
			//     v48.srcRTs = 0LL;
			//     v48.dstRTs = (int32_t *)&v50;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,Beyond::UI::FacLineDrawer::LineData>::MoveNext(
			//                 &v50,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//       {
			//         *(_OWORD *)&v49._dictionary = *(_OWORD *)&v50._current.key;
			//         v26 = *(__m128d *)&v50._current.value.end;
			//         *(_OWORD *)&v49._current.key = *(_OWORD *)&v50._current.value.end;
			//         v27 = MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct;
			//         klass = MethodInfo::System::Collections::Generic::KeyValuePair<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Deconstruct.klass;
			//         if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//           sub_18003C700(klass);
			//         v29 = v27.klass;
			//         if ( ((__int64)v29.vtable[0].methodPtr & 1) == 0 )
			//           sub_18003C700(v29);
			//         v43 = *(_OWORD *)&v49._version;
			//         v44 = (_DWORD *)*(_OWORD *)&_mm_unpackhi_pd(v26, v26);
			//         ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//           (OneofDescriptor *)&v43,
			//           v23,
			//           v24,
			//           v25,
			//           v41,
			//           v42);
			//         v32 = (int)v44;
			//         if ( (_QWORD)v43 && *((_QWORD *)&v43 + 1) && *(float *)&v44 >= 1.0 )
			//         {
			//           v33 = *(RenderTexture **)(v43 + 16);
			//           v34 = *(RenderTexture **)(*((_QWORD *)&v43 + 1) + 16LL);
			//           if ( !v33 )
			//             sub_1802DC2C8(v31, v30);
			//           UnityEngine::RenderTexture::Create(v33, 0LL);
			//           if ( !v34 )
			//             sub_1802DC2C8(v36, v35);
			//           UnityEngine::RenderTexture::Create(v34, 0LL);
			//           v37 = *count;
			//           InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v33, 0LL);
			//           TempFromCSharp[v37] = InstanceID;
			//           v39 = *count;
			//           v19[v39] = UnityEngine::Object::GetInstanceID((Object_1 *)v34, 0LL);
			//           v20[(*count)++] = v32;
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v51 )
			//     {
			//       v48.srcRTs = (int32_t *)v51.ex;
			//       if ( v48.srcRTs )
			//         sub_18000F780(v48.srcRTs);
			//       v6 = retstr;
			//       v18 = TempFromCSharp;
			//       v19 = v46;
			//       v20 = v47;
			//       goto LABEL_34;
			//     }
			//     v18 = TempFromCSharp;
			// LABEL_34:
			//     *(_QWORD *)&v43 = v18;
			//     *((_QWORD *)&v43 + 1) = v19;
			//     v44 = v20;
			//     v14 = v43;
			//     heightScales = (float *)v20;
			//     goto LABEL_35;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(813, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v12, v11);
			//   v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_308(&v48, Patch, (Object *)this, count, 0LL);
			//   v14 = *(_OWORD *)&v13.srcRTs;
			//   heightScales = v13.heightScales;
			// LABEL_35:
			//   *(_OWORD *)&v6.srcRTs = v14;
			//   result = v6;
			//   v6.heightScales = heightScales;
			//   return result;
			// }
			// 
			return default(HGCamera.WaterMarkOutputCPP);
		}

		public HGCamera.InplaceWaterMarkOutputCPP GetInplaceWaterMarkRTsCPP(ref int count)
		{
			// // HGCamera+InplaceWaterMarkOutputCPP GetInplaceWaterMarkRTsCPP(Int32 ByRef)
			// // Hidden C++ exception states: #wind=1
			// HGCamera_InplaceWaterMarkOutputCPP *HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTsCPP(
			//         HGCamera_InplaceWaterMarkOutputCPP *__return_ptr retstr,
			//         HGCamera *this,
			//         int32_t *count,
			//         MethodInfo *method)
			// {
			//   HGCamera_InplaceWaterMarkOutputCPP *v6; // r12
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGCamera_InplaceWaterMarkOutputCPP v13; // xmm0
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *m_inplaceWaterMarkRTs; // rbx
			//   int32_t size; // eax
			//   List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *TempFromCSharp; // r14
			//   _DWORD *v17; // r15
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   int type; // xmm6_4
			//   RenderTexture *fields; // rbx
			//   __int64 v24; // rsi
			//   HGCamera_InplaceWaterMarkOutputCPP *result; // rax
			//   Il2CppExceptionWrapper *v26; // [rsp+40h] [rbp-A8h] BYREF
			//   Il2CppException *ex; // [rsp+48h] [rbp-A0h]
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *v28; // [rsp+50h] [rbp-98h]
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ v29; // [rsp+58h] [rbp-90h] BYREF
			//   List_1_T_Enumerator_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ v30; // [rsp+78h] [rbp-70h] BYREF
			// 
			//   v6 = retstr;
			//   if ( !byte_18D8ED9F6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     byte_18D8ED9F6 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, this);
			//   if ( wrapperArray.max_length.size <= 814 )
			//     goto LABEL_16;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = v7.static_fields.wrapperArray;
			//   if ( !v9 )
			//     sub_180B536AC(v7, this);
			//   if ( v9.max_length.size <= 0x32Eu )
			//     sub_180070270(v7, this);
			//   if ( v9[22].vector[22] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(814, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     v13 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_309(
			//              (HGCamera_InplaceWaterMarkOutputCPP *)&v29,
			//              Patch,
			//              (Object *)this,
			//              count,
			//              0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     m_inplaceWaterMarkRTs = this.fields.m_inplaceWaterMarkRTs;
			//     if ( !m_inplaceWaterMarkRTs )
			//       sub_180B536AC(v7, this);
			//     size = m_inplaceWaterMarkRTs.fields._size;
			//     *count = size;
			//     TempFromCSharp = 0LL;
			//     v17 = 0LL;
			//     if ( size > 0 )
			//     {
			//       TempFromCSharp = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * size, 0LL);
			//       v17 = UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(4 * *count, 0LL);
			//       *count = 0;
			//       if ( !this.fields.m_inplaceWaterMarkRTs )
			//         sub_180B536AC(v19, v18);
			//       System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
			//         (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&v29,
			//         (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this.fields.m_inplaceWaterMarkRTs,
			//         MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::GetEnumerator);
			//       v30 = v29;
			//       ex = 0LL;
			//       v28 = &v30;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::MoveNext(
			//                   &v30,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::MoveNext) )
			//         {
			//           v29._list = (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v30._current.name;
			//           type = (int)v30._current.type;
			//           if ( v30._current.name && *(float *)&v30._current.type >= 1.0 )
			//           {
			//             fields = (RenderTexture *)v30._current.name.fields;
			//             if ( !fields )
			//               sub_1802DC2C8(v21, v20);
			//             UnityEngine::RenderTexture::Create(fields, 0LL);
			//             v24 = *count;
			//             *((_DWORD *)&TempFromCSharp.klass + v24) = UnityEngine::Object::GetInstanceID((Object_1 *)fields, 0LL);
			//             v17[(*count)++] = type;
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v26 )
			//       {
			//         ex = v26.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v6 = retstr;
			//       }
			//     }
			//     v29._list = (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)TempFromCSharp;
			//     *(_QWORD *)&v29._index = v17;
			//     v13 = *(HGCamera_InplaceWaterMarkOutputCPP *)&v29._list;
			//   }
			//   result = v6;
			//   *v6 = v13;
			//   return result;
			// }
			// 
			return default(HGCamera.InplaceWaterMarkOutputCPP);
		}

		public void RegisterRTExtraction(RTExtractionType type, RTExtractionDuration duration, RTHandle rt)
		{
			// // Void RegisterRTExtraction(RTExtractionType, RTExtractionDuration, RTHandle)
			// void HG::Rendering::Runtime::HGCamera::RegisterRTExtraction(
			//         HGCamera *this,
			//         RTExtractionType__Enum type,
			//         RTExtractionDuration__Enum duration,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rbx
			//   __int64 v9; // rdx
			//   List_1_System_Object_ *v10; // rcx
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v6 = (int)duration;
			//   if ( !byte_18D8ED9F7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//     byte_18D8ED9F7 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2314, 0LL) )
			//   {
			//     m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//     if ( m_rtExtractionLists )
			//     {
			//       if ( (unsigned int)v6 >= m_rtExtractionLists.max_length.size )
			//         sub_180070270(v10, v9);
			//       v10 = (List_1_System_Object_ *)m_rtExtractionLists.vector[v6];
			//       if ( v10 )
			//       {
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  v10,
			//                  type,
			//                  MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//         if ( Item )
			//         {
			//           System::Collections::Generic::HashSet<System::Object>::Add(
			//             (HashSet_1_System_Object_ *)Item,
			//             (Object *)rt,
			//             MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Add);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2314, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_837(
			//     Patch,
			//     (Object *)this,
			//     type,
			//     (RTExtractionDuration__Enum)v6,
			//     (Object *)rt,
			//     0LL);
			// }
			// 
		}

		[Obsolete("UnRegisterRTExtraction with RTExtractionDuration is obsolete, use other version instead")]
		[IDTag(0)]
		public void UnRegisterRTExtraction(RTExtractionType type, RTExtractionDuration duration, RTHandle rt)
		{
			// // Void UnRegisterRTExtraction(RTExtractionType, RTExtractionDuration, RTHandle)
			// void HG::Rendering::Runtime::HGCamera::UnRegisterRTExtraction(
			//         HGCamera *this,
			//         RTExtractionType__Enum type,
			//         RTExtractionDuration__Enum duration,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rbx
			//   __int64 v9; // rdx
			//   List_1_System_Object_ *v10; // rcx
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v6 = (int)duration;
			//   if ( !byte_18D8ED9F8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//     byte_18D8ED9F8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2315, 0LL) )
			//   {
			//     m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//     if ( m_rtExtractionLists )
			//     {
			//       if ( (unsigned int)v6 >= m_rtExtractionLists.max_length.size )
			//         sub_180070270(v10, v9);
			//       v10 = (List_1_System_Object_ *)m_rtExtractionLists.vector[v6];
			//       if ( v10 )
			//       {
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  v10,
			//                  type,
			//                  MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//         if ( Item )
			//         {
			//           System::Collections::Generic::HashSet<System::Object>::Remove(
			//             (HashSet_1_System_Object_ *)Item,
			//             (Object *)rt,
			//             MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Remove);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2315, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_837(
			//     Patch,
			//     (Object *)this,
			//     type,
			//     (RTExtractionDuration__Enum)v6,
			//     (Object *)rt,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		public void UnRegisterRTExtraction(RTExtractionType type, RTHandle rt)
		{
			// // Void UnRegisterRTExtraction(RTExtractionType, RTHandle)
			// void HG::Rendering::Runtime::HGCamera::UnRegisterRTExtraction(
			//         HGCamera *this,
			//         RTExtractionType__Enum type,
			//         RTHandle *rt,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   List_1_System_Object_ *v8; // rcx
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919498 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//     byte_18D919498 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2316, 0LL) )
			//   {
			//     m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//     if ( m_rtExtractionLists )
			//     {
			//       if ( !m_rtExtractionLists.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = (List_1_System_Object_ *)m_rtExtractionLists.vector[0];
			//       if ( v8 )
			//       {
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  v8,
			//                  type,
			//                  MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//         if ( Item )
			//         {
			//           System::Collections::Generic::HashSet<System::Object>::Remove(
			//             (HashSet_1_System_Object_ *)Item,
			//             (Object *)rt,
			//             MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Remove);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2316, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
			//     (ILFixDynamicMethodWrapper_14 *)Patch,
			//     (Object *)this,
			//     (SCMessageID__Enum)type,
			//     (Object *)rt,
			//     0LL);
			// }
			// 
		}

		internal ValueTuple<HashSet<RTHandle>, HashSet<RTHandle>> GetRTForExtraction(RTExtractionType type)
		{
			// // ValueTuple`2[System.Collections.Generic.HashSet`1[UnityEngine.Rendering.RTHandle],System.Collections.Generic.HashSet`1[UnityEngine.Rendering.RTHandle]] GetRTForExtraction(RTExtractionType)
			// ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
			//         ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *__return_ptr retstr,
			//         HGCamera *this,
			//         RTExtractionType__Enum type,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   List_1_System_Object_ *klass; // rcx
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
			//   Object *Item; // rax
			//   Object *v11; // rbp
			//   Object *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919499 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::ValueTuple);
			//     byte_18D919499 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2317, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2317, 0LL);
			//     if ( Patch )
			//     {
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_839(&v15, Patch, (Object *)this, type, 0LL);
			//       return retstr;
			//     }
			//     goto LABEL_13;
			//   }
			//   m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//   if ( !m_rtExtractionLists )
			//     goto LABEL_13;
			//   if ( !m_rtExtractionLists.max_length.size )
			// LABEL_11:
			//     sub_180070270(klass, v7);
			//   klass = (List_1_System_Object_ *)m_rtExtractionLists.vector[0];
			//   if ( !klass
			//     || (Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  klass,
			//                  type,
			//                  MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item),
			//         klass = (List_1_System_Object_ *)this.fields.m_rtExtractionLists,
			//         v11 = Item,
			//         !klass) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(klass, v7);
			//   }
			//   if ( klass.fields._size <= 1u )
			//     goto LABEL_11;
			//   klass = (List_1_System_Object_ *)klass[1].klass;
			//   if ( !klass )
			//     goto LABEL_13;
			//   v12 = System::Collections::Generic::List<System::Object>::get_Item(
			//           klass,
			//           type,
			//           MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//   *retstr = 0LL;
			//   Rewired::Utils::Classes::Data::IndexedDictionary_2_TKey_TValue_::yzhVwnWVXpgEXQufmGiVcJkbjlTI<System::Object,System::Object>::yzhVwnWVXpgEXQufmGiVcJkbjlTI(
			//     (IndexedDictionary_2_TKey_TValue_yzhVwnWVXpgEXQufmGiVcJkbjlTI_System_Object_System_Object_ *)retstr,
			//     v11,
			//     v12,
			//     MethodInfo::System::ValueTuple<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>,System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::ValueTuple);
			//   return retstr;
			// }
			// 
			return null;
		}

		internal unsafe int* GetRTForExtractionCPP(RTExtractionType type, ref int count, HGCamera uiCamera = null)
		{
			// // Int32* GetRTForExtractionCPP(RTExtractionType, Int32 ByRef, HGCamera)
			// // local variable allocation has failed, the output may be wrong!
			// // Hidden C++ exception states: #wind=4
			// int32_t *HG::Rendering::Runtime::HGCamera::GetRTForExtractionCPP(
			//         HGCamera *this,
			//         RTExtractionType__Enum type,
			//         int32_t *count,
			//         HGCamera *uiCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rbx
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rdi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v8; // rdi
			//   HashSet_1_UnityEngine_Rendering_RTHandle___Array *items; // rdi
			//   HashSet_1_System_UInt64_ *v10; // r12
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v11; // rdi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v12; // rdi
			//   HashSet_1_UnityEngine_Rendering_RTHandle___Array *v13; // rdi
			//   HashSet_1_System_UInt64_ *v14; // r14
			//   HashSet_1_System_UInt64_ *v15; // r13
			//   HashSet_1_System_UInt64_ *v16; // r15
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v17; // rdi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v18; // rdi
			//   HashSet_1_UnityEngine_Rendering_RTHandle___Array *v19; // rdi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v20; // rdi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v21; // rdi
			//   HashSet_1_UnityEngine_Rendering_RTHandle___Array *v22; // rdi
			//   int32_t v23; // ecx
			//   int32_t *TempFromCSharp; // rbx
			//   __int64 *v26; // rdx
			//   HashSet_1_System_UInt64_ *set; // rcx
			//   Object__Class *klass; // rdi
			//   int32_t *v29; // rsi
			//   __int64 *v30; // rdx
			//   signed __int64 v31; // rtt
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   Object__Class *v34; // rdi
			//   void (__fastcall *v35)(Object__Class *); // rax
			//   int32_t *v36; // rsi
			//   __int64 *v37; // rdx
			//   signed __int64 v38; // rtt
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   Object__Class *v41; // rdi
			//   int32_t *v42; // rsi
			//   __int64 *v43; // rdx
			//   signed __int64 v44; // rtt
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   Object__Class *v47; // rdi
			//   void (__fastcall *v48)(Object__Class *); // rax
			//   int32_t *v49; // rsi
			//   __int64 v50; // rax
			//   __int64 v51; // rax
			//   __int64 v52; // [rsp+0h] [rbp-B8h] BYREF
			//   HashSet_1_T_Enumerator_System_Object_ v53; // [rsp+20h] [rbp-98h] BYREF
			//   HashSet_1_T_Enumerator_System_Object_ v54; // [rsp+38h] [rbp-80h] BYREF
			//   HashSet_1_System_UInt64_ *v55; // [rsp+50h] [rbp-68h]
			//   HashSet_1_System_UInt64_ *v56; // [rsp+58h] [rbp-60h]
			//   Il2CppExceptionWrapper *v57; // [rsp+60h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v58; // [rsp+68h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v59; // [rsp+70h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v60; // [rsp+78h] [rbp-40h] BYREF
			//   HashSet_1_System_UInt64_ *v61; // [rsp+C0h] [rbp+8h]
			//   int32_t *v63; // [rsp+D0h] [rbp+18h]
			//   int32_t *v65; // [rsp+D8h] [rbp+20h]
			// 
			//   v5 = (int)type;
			//   if ( !byte_18D8ED9F9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//     byte_18D8ED9F9 = 1;
			//   }
			//   m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//   if ( !m_rtExtractionLists )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( !m_rtExtractionLists.max_length.size )
			//     sub_180070270(this, *(_QWORD *)&type);
			//   v8 = m_rtExtractionLists.vector[0];
			//   if ( !v8 )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( (unsigned int)v5 >= v8.fields._size )
			//     System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//   items = v8.fields._items;
			//   if ( !items )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( (unsigned int)v5 >= items.max_length.size )
			//     sub_180070270(this, *(_QWORD *)&type);
			//   v10 = (HashSet_1_System_UInt64_ *)items.vector[v5];
			//   v11 = this.fields.m_rtExtractionLists;
			//   if ( !v11 )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( v11.max_length.size <= 1u )
			//     sub_180070270(this, *(_QWORD *)&type);
			//   v12 = v11.vector[1];
			//   if ( !v12 )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( (unsigned int)v5 >= v12.fields._size )
			//     System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//   v13 = v12.fields._items;
			//   if ( !v13 )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( (unsigned int)v5 >= v13.max_length.size )
			//     sub_180070270(this, *(_QWORD *)&type);
			//   v14 = (HashSet_1_System_UInt64_ *)v13.vector[v5];
			//   v56 = v14;
			//   v15 = 0LL;
			//   v55 = 0LL;
			//   v16 = 0LL;
			//   v61 = 0LL;
			//   if ( uiCamera )
			//   {
			//     v17 = uiCamera.fields.m_rtExtractionLists;
			//     if ( !v17 )
			//       sub_180B536AC(this, *(_QWORD *)&type);
			//     if ( !v17.max_length.size )
			//       sub_180070270(this, *(_QWORD *)&type);
			//     v18 = v17.vector[0];
			//     if ( !v18 )
			//       sub_180B536AC(this, *(_QWORD *)&type);
			//     if ( (unsigned int)v5 >= v18.fields._size )
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     v19 = v18.fields._items;
			//     if ( !v19 )
			//       sub_180B536AC(this, *(_QWORD *)&type);
			//     if ( (unsigned int)v5 >= v19.max_length.size )
			//       sub_180070270(this, *(_QWORD *)&type);
			//     v15 = (HashSet_1_System_UInt64_ *)v19.vector[v5];
			//     v55 = v15;
			//     v20 = uiCamera.fields.m_rtExtractionLists;
			//     if ( !v20 )
			//       sub_180B536AC(this, *(_QWORD *)&type);
			//     if ( v20.max_length.size <= 1u )
			//       sub_180070270(this, *(_QWORD *)&type);
			//     v21 = v20.vector[1];
			//     if ( !v21 )
			//       sub_180B536AC(this, *(_QWORD *)&type);
			//     if ( (unsigned int)v5 >= v21.fields._size )
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     v22 = v21.fields._items;
			//     if ( !v22 )
			//       sub_180B536AC(this, *(_QWORD *)&type);
			//     if ( (unsigned int)v5 >= v22.max_length.size )
			//       sub_180070270(this, *(_QWORD *)&type);
			//     v16 = (HashSet_1_System_UInt64_ *)v22.vector[v5];
			//     v61 = v16;
			//   }
			//   if ( !v10 )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   if ( !v14 )
			//     sub_180B536AC(this, *(_QWORD *)&type);
			//   v23 = v10.fields._count + v14.fields._count;
			//   *count = v23;
			//   if ( v15 )
			//     *count = v15.fields._count + v23;
			//   if ( v16 )
			//     *count += v16.fields._count;
			//   if ( *count <= 0 )
			//     return 0LL;
			//   TempFromCSharp = (int32_t *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(
			//                                 4 * *count,
			//                                 0LL);
			//   v65 = TempFromCSharp;
			//   v63 = TempFromCSharp;
			//   System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
			//     (HashSet_1_T_Enumerator_System_UInt64_ *)&v53,
			//     v10,
			//     MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::GetEnumerator);
			//   v54 = v53;
			//   v53._set = 0LL;
			//   *(_QWORD *)&v53._index = &v54;
			//   try
			//   {
			//     while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v54,
			//               MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
			//     {
			//       if ( v54._current )
			//       {
			//         klass = v54._current[1].klass;
			//         if ( !klass )
			//           sub_1802DC2C8(set, v26);
			//         UnityEngine::RenderTexture::Create((RenderTexture *)klass, 0LL);
			//         v29 = TempFromCSharp++;
			//         v65 = TempFromCSharp;
			//         *v29 = UnityEngine::Object::GetInstanceID((Object_1 *)klass, 0LL);
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v57 )
			//   {
			//     v26 = &v52;
			//     v53._set = (HashSet_1_System_Object_ *)v57.ex;
			//     set = (HashSet_1_System_UInt64_ *)v53._set;
			//     if ( v53._set )
			//       sub_18000F780(v53._set);
			//     v14 = v56;
			//     v15 = v55;
			//     v16 = v61;
			//     TempFromCSharp = v65;
			//   }
			//   if ( !v14 )
			//     sub_1802DC2C8(set, v26);
			//   *(_OWORD *)&v53._index = 0LL;
			//   v53._set = (HashSet_1_System_Object_ *)v14;
			//   if ( dword_18D8E43F8 )
			//   {
			//     v30 = &qword_18D6405E0[(((unsigned __int64)&v53 >> 12) & 0x1FFFFF) >> 6];
			//     _m_prefetchw(v30 + 36190);
			//     do
			//       v31 = v30[36190];
			//     while ( v31 != _InterlockedCompareExchange64(
			//                      v30 + 36190,
			//                      v31 | (1LL << (((unsigned __int64)&v53 >> 12) & 0x3F)),
			//                      v31) );
			//   }
			//   v53._index = 0;
			//   v53._version = v14.fields._version;
			//   v53._current = 0LL;
			//   *(_OWORD *)&v54._set = *(_OWORD *)&v53._set;
			//   v54._current = 0LL;
			//   v53._set = 0LL;
			//   *(_QWORD *)&v53._index = &v54;
			//   try
			//   {
			//     while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v54,
			//               MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
			//     {
			//       if ( v54._current )
			//       {
			//         v34 = v54._current[1].klass;
			//         if ( !v34 )
			//           sub_1802DC2C8(v33, v32);
			//         v35 = (void (__fastcall *)(Object__Class *))qword_18D8F4AF8;
			//         if ( !qword_18D8F4AF8 )
			//         {
			//           v35 = (void (__fastcall *)(Object__Class *))il2cpp_resolve_icall_0("UnityEngine.RenderTexture::Create()");
			//           if ( !v35 )
			//           {
			//             v50 = sub_1802DBBE8("UnityEngine.RenderTexture::Create()");
			//             sub_18000F750(v50, 0LL);
			//           }
			//           qword_18D8F4AF8 = (__int64)v35;
			//         }
			//         v35(v34);
			//         v36 = TempFromCSharp++;
			//         v65 = TempFromCSharp;
			//         *v36 = UnityEngine::Object::GetInstanceID((Object_1 *)v34, 0LL);
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v58 )
			//   {
			//     v53._set = (HashSet_1_System_Object_ *)v58.ex;
			//     if ( v53._set )
			//       sub_18000F780(v53._set);
			//     v15 = v55;
			//     v16 = v61;
			//     TempFromCSharp = v65;
			//   }
			//   if ( v15 )
			//   {
			//     *(_OWORD *)&v53._index = 0LL;
			//     v53._set = (HashSet_1_System_Object_ *)v15;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v37 = &qword_18D6405E0[(((unsigned __int64)&v53 >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw(v37 + 36190);
			//       do
			//         v38 = v37[36190];
			//       while ( v38 != _InterlockedCompareExchange64(
			//                        v37 + 36190,
			//                        v38 | (1LL << (((unsigned __int64)&v53 >> 12) & 0x3F)),
			//                        v38) );
			//     }
			//     v53._index = 0;
			//     v53._version = v15.fields._version;
			//     v53._current = 0LL;
			//     *(_OWORD *)&v54._set = *(_OWORD *)&v53._set;
			//     v54._current = 0LL;
			//     v53._set = 0LL;
			//     *(_QWORD *)&v53._index = &v54;
			//     try
			//     {
			//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v54,
			//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
			//       {
			//         if ( v54._current )
			//         {
			//           v41 = v54._current[1].klass;
			//           if ( !v41 )
			//             sub_1802DC2C8(v40, v39);
			//           UnityEngine::RenderTexture::Create((RenderTexture *)v41, 0LL);
			//           v42 = TempFromCSharp++;
			//           v65 = TempFromCSharp;
			//           *v42 = UnityEngine::Object::GetInstanceID((Object_1 *)v41, 0LL);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v59 )
			//     {
			//       v53._set = (HashSet_1_System_Object_ *)v59.ex;
			//       if ( v53._set )
			//         sub_18000F780(v53._set);
			//       v16 = v61;
			//       TempFromCSharp = v65;
			//     }
			//   }
			//   if ( v16 )
			//   {
			//     *(_OWORD *)&v53._index = 0LL;
			//     v53._set = (HashSet_1_System_Object_ *)v16;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v43 = &qword_18D6405E0[(((unsigned __int64)&v53 >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw(v43 + 36190);
			//       do
			//         v44 = v43[36190];
			//       while ( v44 != _InterlockedCompareExchange64(
			//                        v43 + 36190,
			//                        v44 | (1LL << (((unsigned __int64)&v53 >> 12) & 0x3F)),
			//                        v44) );
			//     }
			//     v53._index = 0;
			//     v53._version = v16.fields._version;
			//     v53._current = 0LL;
			//     *(_OWORD *)&v54._set = *(_OWORD *)&v53._set;
			//     v54._current = 0LL;
			//     v53._set = 0LL;
			//     *(_QWORD *)&v53._index = &v54;
			//     try
			//     {
			//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v54,
			//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<UnityEngine::Rendering::RTHandle>::MoveNext) )
			//       {
			//         if ( v54._current )
			//         {
			//           v47 = v54._current[1].klass;
			//           if ( !v47 )
			//             sub_1802DC2C8(v46, v45);
			//           v48 = (void (__fastcall *)(Object__Class *))qword_18D8F4AF8;
			//           if ( !qword_18D8F4AF8 )
			//           {
			//             v48 = (void (__fastcall *)(Object__Class *))il2cpp_resolve_icall_0("UnityEngine.RenderTexture::Create()");
			//             if ( !v48 )
			//             {
			//               v51 = sub_1802DBBE8("UnityEngine.RenderTexture::Create()");
			//               sub_18000F750(v51, 0LL);
			//             }
			//             qword_18D8F4AF8 = (__int64)v48;
			//           }
			//           v48(v47);
			//           v49 = TempFromCSharp++;
			//           *v49 = UnityEngine::Object::GetInstanceID((Object_1 *)v47, 0LL);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v60 )
			//     {
			//       v53._set = (HashSet_1_System_Object_ *)v60.ex;
			//       if ( v53._set )
			//         sub_18000F780(v53._set);
			//     }
			//   }
			//   return v63;
			// }
			// 
			return null;
		}

		private static void RTExtractionDone(HGCamera camera, RTHandle rt)
		{
			// // Void RTExtractionDone(HGCamera, RTHandle)
			// void HG::Rendering::Runtime::HGCamera::RTExtractionDone(HGCamera *camera, RTHandle *rt, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2318, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2318, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)camera,
			//       (Object *)rt,
			//       0LL);
			//   }
			// }
			// 
		}

		public static HGCamera GetOrCreate(Camera camera, [MetadataOffset(Offset = "0x01F9148A")] int xrMultipassId = 0)
		{
			// // HGCamera GetOrCreate(Camera, Int32)
			// // local variable allocation has failed, the output may be wrong!
			// HGCamera *HG::Rendering::Runtime::HGCamera::GetOrCreate(Camera *camera, int32_t xrMultipassId, MethodInfo *method)
			// {
			//   int32_t v3; // ebp
			//   signed __int64 v5; // rcx
			//   __int64 v6; // rbx
			//   __int64 v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   struct HGCamera__Class *v12; // rax
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *s_Cameras; // r10
			//   signed __int64 v14; // rtt
			//   HGCamera *v15; // rax
			//   __int64 *v16; // rdx
			//   signed __int64 v17; // rcx
			//   HGCamera *v18; // rbx
			//   unsigned int InstanceID; // esi
			//   __int64 (__fastcall *v20)(_QWORD); // rax
			//   InsertionBehavior__Enum v21; // r9d
			//   struct HGCamera__Class *v22; // rax
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v23; // rsi
			//   signed __int64 v24; // rtt
			//   struct MethodInfo *v25; // rbx
			//   Object *v26; // rdi
			//   ValueTuple_2_Object_Int32_ v27; // xmm6
			//   Il2CppClass *klass; // rax
			//   __int64 v29; // rax
			//   ValueTuple_2_Object_Int32_ v30; // [rsp+30h] [rbp-48h] BYREF
			//   ValueTuple_2_Object_Int32_ v31; // [rsp+40h] [rbp-38h] BYREF
			//   HGCamera *v32; // [rsp+98h] [rbp+20h] BYREF
			// 
			//   v3 = xrMultipassId;
			//   if ( !byte_18D8ED9FA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Camera,int>::ValueTuple);
			//     byte_18D8ED9FA = 1;
			//   }
			//   v32 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&xrMultipassId);
			//     v5 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = **(_QWORD **)(v5 + 184);
			//   if ( !v6 )
			//     sub_180B536AC(v5, *(_QWORD *)&xrMultipassId);
			//   if ( *(int *)(v6 + 24) <= 29 )
			//     goto LABEL_16;
			//   if ( !*(_DWORD *)(v5 + 224) )
			//   {
			//     il2cpp_runtime_class_init_0(v5, *(_QWORD *)&xrMultipassId);
			//     v5 = (signed __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = **(_QWORD **)(v5 + 184);
			//   if ( !v7 )
			//     sub_180B536AC(v5, *(_QWORD *)&xrMultipassId);
			//   if ( *(_DWORD *)(v7 + 24) <= 0x1Du )
			//     sub_180070270(v5, *(_QWORD *)&xrMultipassId);
			//   if ( *(_QWORD *)(v7 + 264) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(29, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(Patch, (Object *)camera, v3, 0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     v12 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, *(_QWORD *)&xrMultipassId);
			//       v12 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     s_Cameras = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v12.static_fields.s_Cameras;
			//     v31 = (ValueTuple_2_Object_Int32_)(unsigned __int64)camera;
			//     if ( dword_18D8E43F8 )
			//     {
			//       *(_QWORD *)&xrMultipassId = &qword_18D6405E0[(((unsigned __int64)&v31 >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw((const void *)(*(_QWORD *)&xrMultipassId + 289520LL));
			//       do
			//       {
			//         v5 = *(_QWORD *)(*(_QWORD *)&xrMultipassId + 289520LL) | (1LL << (((unsigned __int64)&v31 >> 12) & 0x3F));
			//         v14 = *(_QWORD *)(*(_QWORD *)&xrMultipassId + 289520LL);
			//       }
			//       while ( v14 != _InterlockedCompareExchange64(
			//                        (volatile signed __int64 *)(*(_QWORD *)&xrMultipassId + 289520LL),
			//                        v5,
			//                        v14) );
			//     }
			//     v31.Item2 = v3;
			//     if ( !s_Cameras )
			//       sub_1802DC2C8(v5, *(_QWORD *)&xrMultipassId);
			//     v30 = v31;
			//     if ( !System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
			//             s_Cameras,
			//             &v30,
			//             (Object **)&v32,
			//             MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
			//     {
			//       v15 = (HGCamera *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//       v18 = v15;
			//       if ( !v15 )
			//         goto LABEL_44;
			//       HG::Rendering::Runtime::HGCamera::HGCamera(v15, camera, 0LL);
			//       v32 = v18;
			//       if ( !camera )
			//         goto LABEL_44;
			//       InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
			//       v20 = (__int64 (__fastcall *)(_QWORD))qword_18D8F5518;
			//       if ( !qword_18D8F5518 )
			//       {
			//         v20 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0(
			//                                                 "UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
			//         if ( !v20 )
			//         {
			//           v29 = sub_1802DBBE8("UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
			//           sub_18000F750(v29, 0LL);
			//         }
			//         qword_18D8F5518 = (__int64)v20;
			//       }
			//       v18.fields.cullingViewUniqueID = v20(InstanceID);
			//       v22 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v16);
			//         v22 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//       }
			//       v23 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v22.static_fields.s_Cameras;
			//       v31 = (ValueTuple_2_Object_Int32_)(unsigned __int64)camera;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v16 = &qword_18D6405E0[(((unsigned __int64)&v31 >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(v16 + 36190);
			//         do
			//         {
			//           v17 = v16[36190] | (1LL << (((unsigned __int64)&v31 >> 12) & 0x3F));
			//           v24 = v16[36190];
			//         }
			//         while ( v24 != _InterlockedCompareExchange64(v16 + 36190, v17, v24) );
			//       }
			//       v31.Item2 = v3;
			//       if ( !v23 )
			// LABEL_44:
			//         sub_1802DC2C8(v17, v16);
			//       v25 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add;
			//       v26 = (Object *)v32;
			//       v27 = v31;
			//       if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add.klass.rgctx_data[24].rgctxDataDummy
			//             + 4) )
			//         (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add.klass.rgctx_data[24].rgctxDataDummy)();
			//       klass = v25.klass;
			//       LOBYTE(v21) = 2;
			//       v30 = v27;
			//       System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryInsert(
			//         v23,
			//         &v30,
			//         v26,
			//         v21,
			//         (MethodInfo *)klass.rgctx_data[24].rgctxDataDummy);
			//     }
			//     return v32;
			//   }
			// }
			// 
			return null;
		}

		public static HGCamera TryGet(Camera camera, [MetadataOffset(Offset = "0x01F9148B")] int xrMultipassId = 0)
		{
			// // HGCamera TryGet(Camera, Int32)
			// HGCamera *HG::Rendering::Runtime::HGCamera::TryGet(Camera *camera, int32_t xrMultipassId, MethodInfo *method)
			// {
			//   __int128 v4; // rdi
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v10; // r10
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   _BYTE v15[40]; // [rsp+20h] [rbp-28h] BYREF
			//   HGCamera *v16; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   *(_QWORD *)&v4 = camera;
			//   if ( !byte_18D8ED9FB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Camera,int>::ValueTuple);
			//     byte_18D8ED9FB = 1;
			//   }
			//   *((_QWORD *)&v4 + 1) = 0LL;
			//   v16 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2319, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2319, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(Patch, (Object *)v4, xrMultipassId, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v5);
			//     *(_OWORD *)v15 = v4;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *))sub_1800054D0)(
			//       (OneofDescriptor *)v15,
			//       v5,
			//       v6,
			//       v7);
			//     *(_DWORD *)&v15[8] = xrMultipassId;
			//     if ( !v10 )
			//       sub_180B536AC(v9, v8);
			//     *(_OWORD *)&v15[16] = *(_OWORD *)v15;
			//     if ( System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
			//            v10,
			//            (ValueTuple_2_Object_Int32_ *)&v15[16],
			//            (Object **)&v16,
			//            MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
			//     {
			//       return v16;
			//     }
			//     else
			//     {
			//       return 0LL;
			//     }
			//   }
			// }
			// 
			return null;
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::HGCamera::Reset(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2320, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2320, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._isFirstFrame_k__BackingField = 1;
			//     this.fields.cameraFrameCount = 0;
			//     this.fields.resetPostProcessingHistory = 1;
			//     this.fields.prevTransformReset = 1;
			//   }
			// }
			// 
		}

		public RTHandle GetPreviousFrameRT(int id)
		{
			// // RTHandle GetPreviousFrameRT(Int32)
			// RTHandle *HG::Rendering::Runtime::HGCamera::GetPreviousFrameRT(HGCamera *this, int32_t id, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2321, 0LL) )
			//   {
			//     m_HistoryRTSystem = this.fields.m_HistoryRTSystem;
			//     if ( m_HistoryRTSystem )
			//       return UnityEngine::Rendering::BufferedRTHandleSystem::GetFrameRT(m_HistoryRTSystem, id, 1, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_HistoryRTSystem, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2321, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_840(Patch, (Object *)this, id, 0LL);
			// }
			// 
			return null;
		}

		public RTHandle GetCurrentFrameRT(int id)
		{
			// // RTHandle GetCurrentFrameRT(Int32)
			// RTHandle *HG::Rendering::Runtime::HGCamera::GetCurrentFrameRT(HGCamera *this, int32_t id, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2322, 0LL) )
			//   {
			//     m_HistoryRTSystem = this.fields.m_HistoryRTSystem;
			//     if ( m_HistoryRTSystem )
			//       return UnityEngine::Rendering::BufferedRTHandleSystem::GetFrameRT(m_HistoryRTSystem, id, 0, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_HistoryRTSystem, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2322, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_840(Patch, (Object *)this, id, 0LL);
			// }
			// 
			return null;
		}

		public uint GetCameraFrameCount()
		{
			// // UInt32 GetCameraFrameCount()
			// uint32_t HG::Rendering::Runtime::HGCamera::GetCameraFrameCount(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 894 )
			//     return this.fields.cameraFrameCount;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x37Eu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[24].vector[30] )
			//     return this.fields.cameraFrameCount;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(894, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0U;
		}

		public void RequestDisableFrameGenTemporarily(bool disable)
		{
			// // Void RequestDisableFrameGenTemporarily(Boolean)
			// void HG::Rendering::Runtime::HGCamera::RequestDisableFrameGenTemporarily(
			//         HGCamera *this,
			//         bool disable,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2323, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2323, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, disable, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_DisableFrameGenTemporarily = disable;
			//   }
			// }
			// 
		}

		public bool ShouldDisableFrameGenTemporarily()
		{
			// // Boolean ShouldDisableFrameGenTemporarily()
			// bool HG::Rendering::Runtime::HGCamera::ShouldDisableFrameGenTemporarily(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 879 )
			//     return this.fields.m_DisableFrameGenTemporarily;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x36Fu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[24].vector[15] )
			//     return this.fields.m_DisableFrameGenTemporarily;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(879, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(0)]
		public static LayerMask RemoveWorldUILayer(LayerMask layerMask)
		{
			// // LayerMask RemoveWorldUILayer(LayerMask)
			// LayerMask HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(LayerMask layerMask, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91949A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D91949A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1048, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1048, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, layerMask, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     return (LayerMask)(layerMask.m_Mask & ~(1 << (TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.worldUILayerIndex & 0x1F)));
			//   }
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static uint RemoveWorldUILayer(uint layerMask)
		{
			// // UInt32 RemoveWorldUILayer(UInt32)
			// uint32_t HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(uint32_t layerMask, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91949B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D91949B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2324, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2324, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, layerMask, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     return layerMask & ~(1 << (TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.worldUILayerIndex & 0x1F));
			//   }
			// }
			// 
			return 0U;
		}

		[IDTag(0)]
		public static LayerMask AddWorldUILayer(LayerMask layerMask)
		{
			// // LayerMask AddWorldUILayer(LayerMask)
			// LayerMask HG::Rendering::Runtime::HGCamera::AddWorldUILayer(LayerMask layerMask, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91949C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D91949C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2325, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2325, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, layerMask, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     return (LayerMask)(layerMask.m_Mask | (1 << (TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.worldUILayerIndex & 0x1F)));
			//   }
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static uint AddWorldUILayer(uint layerMask)
		{
			// // UInt32 AddWorldUILayer(UInt32)
			// uint32_t HG::Rendering::Runtime::HGCamera::AddWorldUILayer(uint32_t layerMask, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91949D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D91949D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2326, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2326, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_71((ILFixDynamicMethodWrapper_17 *)Patch, layerMask, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     return layerMask | (1 << (TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.worldUILayerIndex & 0x1F));
			//   }
			// }
			// 
			return 0U;
		}

		private Mesh CreateParafinTriangleMesh(float zOffset)
		{
			// // Mesh CreateParafinTriangleMesh(Single)
			// Mesh *HG::Rendering::Runtime::HGCamera::CreateParafinTriangleMesh(HGCamera *this, float zOffset, MethodInfo *method)
			// {
			//   Mesh *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Mesh *v7; // rbp
			//   __int64 v8; // r8
			//   __int64 v9; // r9
			//   __int64 v10; // rax
			//   __int64 v11; // r8
			//   __int64 v12; // r9
			//   Vector3__Array *v13; // rsi
			//   __int64 v14; // rax
			//   __int64 v15; // r8
			//   __int64 v16; // r9
			//   Vector2__Array *v17; // rdi
			//   Array *v18; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9FC )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&B2CF02C10F1F309AC8FB52A3CCE888191E73C7E1C5A0D699CA4CBBE2C76F2C0F_Field);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18C8ED300);
			//     byte_18D8ED9FC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2327, 0LL) )
			//   {
			//     v4 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//     v7 = v4;
			//     if ( v4 )
			//     {
			//       UnityEngine::Mesh::Mesh(v4, 0LL);
			//       v10 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 4LL, v8, v9);
			//       v13 = (Vector3__Array *)v10;
			//       if ( v10 )
			//       {
			//         if ( !*(_DWORD *)(v10 + 24) )
			//           goto LABEL_17;
			//         *(_QWORD *)(v10 + 32) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
			//         *(float *)(v10 + 40) = zOffset;
			//         if ( *(_DWORD *)(v10 + 24) <= 1u )
			//           goto LABEL_17;
			//         *(_QWORD *)(v10 + 44) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//         *(float *)(v10 + 52) = zOffset;
			//         if ( *(_DWORD *)(v10 + 24) <= 2u )
			//           goto LABEL_17;
			//         *(_QWORD *)(v10 + 56) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0];
			//         *(float *)(v10 + 64) = zOffset;
			//         if ( *(_DWORD *)(v10 + 24) <= 3u )
			//           goto LABEL_17;
			//         *(_QWORD *)(v10 + 68) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0xBF800000).m128_u64[0];
			//         *(float *)(v10 + 76) = zOffset;
			//         v14 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector2, 4LL, v11, v12);
			//         v17 = (Vector2__Array *)v14;
			//         if ( v14 )
			//         {
			//           if ( *(_DWORD *)(v14 + 24) )
			//           {
			//             *(_QWORD *)(v14 + 32) = 0LL;
			//             if ( *(_DWORD *)(v14 + 24) > 1u )
			//             {
			//               *(_QWORD *)(v14 + 40) = 1065353216LL;
			//               if ( *(_DWORD *)(v14 + 24) > 2u )
			//               {
			//                 *(_DWORD *)(v14 + 48) = 0;
			//                 *(_DWORD *)(v14 + 52) = 1065353216;
			//                 if ( *(_DWORD *)(v14 + 24) > 3u )
			//                 {
			//                   *(_DWORD *)(v14 + 56) = 1065353216;
			//                   *(_DWORD *)(v14 + 60) = 1065353216;
			//                   v18 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 6LL, v15, v16);
			//                   System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//                     v18,
			//                     B2CF02C10F1F309AC8FB52A3CCE888191E73C7E1C5A0D699CA4CBBE2C76F2C0F_Field,
			//                     0LL);
			//                   UnityEngine::Mesh::set_vertices(v7, v13, 0LL);
			//                   UnityEngine::Mesh::set_triangles(v7, (Int32__Array *)v18, 0LL);
			//                   UnityEngine::Object::set_name((Object_1 *)v7, (String *)"ParafinTriangle", 0LL);
			//                   UnityEngine::Mesh::set_uv(v7, v17, 0LL);
			//                   UnityEngine::Mesh::RecalculateBounds(v7, MeshUpdateFlags__Enum_Default, 0LL);
			//                   return v7;
			//                 }
			//               }
			//             }
			//           }
			// LABEL_17:
			//           sub_180070270(v6, v5);
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2327, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_841(Patch, (Object *)this, zOffset, 0LL);
			// }
			// 
			return null;
		}

		internal void SetParentCamera(HGCamera parentHdCam, bool useGpuFetchedExposure, float fetchedGpuExposure)
		{
			// // Void SetParentCamera(HGCamera, Boolean, Single)
			// void HG::Rendering::Runtime::HGCamera::SetParentCamera(
			//         HGCamera *this,
			//         HGCamera *parentHdCam,
			//         bool useGpuFetchedExposure,
			//         float fetchedGpuExposure,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   String__Array *P3; // [rsp+20h] [rbp-28h]
			//   String *v15; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v16; // [rsp+30h] [rbp-18h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2330, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2330, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_842(
			//       Patch,
			//       (Object *)this,
			//       (Object *)parentHdCam,
			//       useGpuFetchedExposure,
			//       fetchedGpuExposure,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( parentHdCam )
			//       this.fields.m_parentCamera = parentHdCam.fields.camera;
			//     else
			//       this.fields.m_parentCamera = 0LL;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_parentCamera, v8, v9, v10, P3, v15, v16);
			//   }
			// }
			// 
		}

		public bool IsUICamera()
		{
			// // Boolean IsUICamera()
			// bool HG::Rendering::Runtime::HGCamera::IsUICamera(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
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
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size <= 727 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_12:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x2D7 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( v3[15]._1.unity_user_data )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(727, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_12;
			//   }
			// LABEL_7:
			//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_12;
			//   return m_AdditionalCameraData.fields.hgRenderPath == 1 || m_AdditionalCameraData.fields.hgRenderPath == 2;
			// }
			// 
			return default(bool);
		}

		public HGCamera GetLightWeightCamera()
		{
			// // HGCamera GetLightWeightCamera()
			// HGCamera *HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v5; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Camera *camera; // rbx
			//   __int64 (__fastcall *v11)(Camera *, MethodInfo *); // rax
			//   __int64 v12; // rdx
			//   Camera *v13; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v14; // rcx
			//   __int64 *v15; // rdx
			//   ILFixDynamicMethodWrapper_2 *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   HGCamera *v19; // r9
			//   signed __int64 static_fields; // rcx
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v21; // r10
			//   signed __int64 v22; // rtt
			//   HGCamera *v23; // rax
			//   __int64 *v24; // rdx
			//   signed __int64 v25; // rcx
			//   HGCamera *v26; // rdi
			//   unsigned int InstanceID; // esi
			//   __int64 (__fastcall *v28)(_QWORD); // rax
			//   InsertionBehavior__Enum v29; // r9d
			//   struct HGCamera__Class *v30; // rax
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *s_Cameras; // rdi
			//   signed __int64 v32; // rtt
			//   struct MethodInfo *v33; // rbx
			//   Object *v34; // rsi
			//   ValueTuple_2_Object_Int32_ v35; // xmm6
			//   Il2CppClass *klass; // rax
			//   bool v37; // zf
			//   __int64 *v38; // rdx
			//   signed __int64 v39; // rtt
			//   __int64 v40; // rax
			//   __int64 v41; // rax
			//   ValueTuple_2_Object_Int32_ v42; // [rsp+30h] [rbp-58h] BYREF
			//   ValueTuple_2_Object_Int32_ v43; // [rsp+40h] [rbp-48h] BYREF
			//   Object *v44; // [rsp+A0h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDA08 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDA08 = 1;
			//   }
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
			//     sub_180B536AC(v3, method);
			//   if ( wrapperArray.max_length.size > 675 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, method);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = v3.static_fields.wrapperArray;
			//     if ( !v5 )
			//       sub_180B536AC(v3, method);
			//     if ( v5.max_length.size <= 0x2A3u )
			//       sub_180070270(v3, method);
			//     if ( v5[18].vector[27] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(675, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v8, v7);
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)this, 0LL);
			//     }
			//   }
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     sub_180B536AC(v3, method);
			//   v11 = (__int64 (__fastcall *)(Camera *, MethodInfo *))qword_18D8F4280;
			//   if ( !qword_18D8F4280 )
			//   {
			//     v11 = (__int64 (__fastcall *)(Camera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Camera::GetLightWeightCamera()");
			//     if ( !v11 )
			//     {
			//       v40 = sub_1802DBBE8("UnityEngine.Camera::GetLightWeightCamera()");
			//       sub_18000F750(v40, 0LL);
			//     }
			//     qword_18D8F4280 = (__int64)v11;
			//   }
			//   v13 = (Camera *)v11(camera, method);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v12);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v12);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v13 )
			//     return 0LL;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v12);
			//   if ( !v13.fields._._._.m_CachedPtr )
			//     return 0LL;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v12);
			//   if ( !byte_18D8ED9FA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Camera,int>::ValueTuple);
			//     byte_18D8ED9FA = 1;
			//   }
			//   v44 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v12);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v15 = (__int64 *)v14.static_fields.wrapperArray;
			//   if ( !v15 )
			//     goto LABEL_87;
			//   if ( *((int *)v15 + 6) <= 29 )
			//   {
			// LABEL_49:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v15);
			//     static_fields = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields;
			//     v21 = *(Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ **)(static_fields + 16);
			//     v42 = (ValueTuple_2_Object_Int32_)(unsigned __int64)v13;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v15 = &qword_18D6405E0[(((unsigned __int64)&v42 >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw(v15 + 36190);
			//       do
			//       {
			//         static_fields = v15[36190] | (1LL << (((unsigned __int64)&v42 >> 12) & 0x3F));
			//         v22 = v15[36190];
			//       }
			//       while ( v22 != _InterlockedCompareExchange64(v15 + 36190, static_fields, v22) );
			//     }
			//     v42.Item2 = 0;
			//     if ( !v21 )
			//       sub_1802DC2C8(static_fields, v15);
			//     v43 = v42;
			//     if ( !System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
			//             v21,
			//             &v43,
			//             &v44,
			//             MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
			//     {
			//       v23 = (HGCamera *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//       v26 = v23;
			//       if ( !v23 )
			//         goto LABEL_84;
			//       HG::Rendering::Runtime::HGCamera::HGCamera(v23, v13, 0LL);
			//       v44 = (Object *)v26;
			//       InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v13, 0LL);
			//       v28 = (__int64 (__fastcall *)(_QWORD))qword_18D8F5518;
			//       if ( !qword_18D8F5518 )
			//       {
			//         v28 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0(
			//                                                 "UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
			//         if ( !v28 )
			//         {
			//           v41 = sub_1802DBBE8("UnityEngine.HyperGryph.HGCullingSystem::RegisterCullViewUniqueId(System.Int32)");
			//           sub_18000F750(v41, 0LL);
			//         }
			//         qword_18D8F5518 = (__int64)v28;
			//       }
			//       v26.fields.cullingViewUniqueID = v28(InstanceID);
			//       v30 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v24);
			//         v30 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//       }
			//       s_Cameras = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v30.static_fields.s_Cameras;
			//       v42 = (ValueTuple_2_Object_Int32_)(unsigned __int64)v13;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v24 = &qword_18D6405E0[(((unsigned __int64)&v42 >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(v24 + 36190);
			//         do
			//         {
			//           v25 = v24[36190] | (1LL << (((unsigned __int64)&v42 >> 12) & 0x3F));
			//           v32 = v24[36190];
			//         }
			//         while ( v32 != _InterlockedCompareExchange64(v24 + 36190, v25, v32) );
			//       }
			//       v42.Item2 = 0;
			//       if ( !s_Cameras )
			// LABEL_84:
			//         sub_1802DC2C8(v25, v24);
			//       v33 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add;
			//       v34 = v44;
			//       v35 = v42;
			//       if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add.klass.rgctx_data[24].rgctxDataDummy
			//             + 4) )
			//         (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Add.klass.rgctx_data[24].rgctxDataDummy)();
			//       klass = v33.klass;
			//       LOBYTE(v29) = 2;
			//       v43 = v35;
			//       System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryInsert(
			//         s_Cameras,
			//         &v43,
			//         v34,
			//         v29,
			//         (MethodInfo *)klass.rgctx_data[24].rgctxDataDummy);
			//     }
			//     v19 = (HGCamera *)v44;
			//     goto LABEL_70;
			//   }
			//   if ( !v14._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v14, v15);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v14 = (struct ILFixDynamicMethodWrapper_2__Class *)v14.static_fields.wrapperArray;
			//   if ( !v14 )
			// LABEL_87:
			//     sub_180B536AC(v14, v15);
			//   if ( LODWORD(v14._0.namespaze) <= 0x1D )
			//     sub_180070270(v14, v15);
			//   if ( !*(_QWORD *)&v14._1.static_fields_size )
			//     goto LABEL_49;
			//   v16 = IFix::WrappersManagerImpl::GetPatch(29, 0LL);
			//   if ( !v16 )
			//     goto LABEL_87;
			//   v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(v16, (Object *)v13, 0, 0LL);
			// LABEL_70:
			//   if ( !v19 )
			//     sub_1802DC2C8(v18, v17);
			//   v37 = dword_18D8E43F8 == 0;
			//   v19.fields.m_lwCameraAttached = this;
			//   if ( !v37 )
			//   {
			//     v38 = &qword_18D6405E0[(((unsigned __int64)&v19.fields.m_lwCameraAttached >> 12) & 0x1FFFFF) >> 6];
			//     _m_prefetchw(v38 + 36190);
			//     do
			//       v39 = v38[36190];
			//     while ( v39 != _InterlockedCompareExchange64(
			//                      v38 + 36190,
			//                      v39 | (1LL << (((unsigned __int64)&v19.fields.m_lwCameraAttached >> 12) & 0x3F)),
			//                      v39) );
			//   }
			//   return v19;
			// }
			// 
			return null;
		}

		public bool IsLightWeightCamera()
		{
			// // Boolean IsLightWeightCamera()
			// bool HG::Rendering::Runtime::HGCamera::IsLightWeightCamera(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2335, 0LL) )
			//     return this.fields.m_lwCameraAttached != 0LL;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2335, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void SetEnableUpdatingSceneFrostedGlass(bool enabled)
		{
			// // Void SetEnableUpdatingSceneFrostedGlass(Boolean)
			// void HG::Rendering::Runtime::HGCamera::SetEnableUpdatingSceneFrostedGlass(
			//         HGCamera *this,
			//         bool enabled,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2336, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2336, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, enabled, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.enableUpdatingSceneFrostedGlass = enabled;
			//   }
			// }
			// 
		}

		public void AddSortingOrder(int sortingOrder)
		{
			// // Void AddSortingOrder(Int32)
			// void HG::Rendering::Runtime::HGCamera::AddSortingOrder(HGCamera *this, int32_t sortingOrder, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Int32_ *m_sortingOrdersToBlur; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA09 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Sort);
			//     byte_18D8EDA09 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2337, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2337, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//         (ILFixDynamicMethodWrapper_26 *)Patch,
			//         (Object *)this,
			//         sortingOrder,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_10;
			//   }
			//   m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//   if ( !m_sortingOrdersToBlur )
			//     goto LABEL_10;
			//   if ( System::Collections::Generic::List<int>::Contains(
			//          m_sortingOrdersToBlur,
			//          sortingOrder,
			//          MethodInfo::System::Collections::Generic::List<int>::Contains) )
			//   {
			//     return;
			//   }
			//   m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//   if ( !m_sortingOrdersToBlur
			//     || (sub_18231EF50(m_sortingOrdersToBlur, sortingOrder),
			//         (m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur) == 0LL) )
			//   {
			// LABEL_10:
			//     sub_180B536AC(m_sortingOrdersToBlur, v5);
			//   }
			//   System::Collections::Generic::List<int>::Sort(
			//     m_sortingOrdersToBlur,
			//     MethodInfo::System::Collections::Generic::List<int>::Sort);
			// }
			// 
		}

		public void RemoveSortingOrder(int sortingOrder)
		{
			// // Void RemoveSortingOrder(Int32)
			// void HG::Rendering::Runtime::HGCamera::RemoveSortingOrder(HGCamera *this, int32_t sortingOrder, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Int32_ *m_sortingOrdersToBlur; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA0A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Remove);
			//     byte_18D8EDA0A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2338, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2338, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//         (ILFixDynamicMethodWrapper_26 *)Patch,
			//         (Object *)this,
			//         sortingOrder,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_9;
			//   }
			//   m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//   if ( !m_sortingOrdersToBlur )
			//     goto LABEL_9;
			//   if ( !System::Collections::Generic::List<int>::Contains(
			//           m_sortingOrdersToBlur,
			//           sortingOrder,
			//           MethodInfo::System::Collections::Generic::List<int>::Contains) )
			//     return;
			//   m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//   if ( !m_sortingOrdersToBlur )
			// LABEL_9:
			//     sub_180B536AC(m_sortingOrdersToBlur, v5);
			//   System::Collections::Generic::List<int>::Remove(
			//     m_sortingOrdersToBlur,
			//     sortingOrder,
			//     MethodInfo::System::Collections::Generic::List<int>::Remove);
			// }
			// 
		}

		public void SetRenderingScale(float scale)
		{
			// // Void SetRenderingScale(Single)
			// void HG::Rendering::Runtime::HGCamera::SetRenderingScale(HGCamera *this, float scale, MethodInfo *method)
			// {
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v5; // rdx
			//   SettingParameter_1_System_Single_ *renderingScale_k__BackingField; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   HGRenderPipeline *v8; // rax
			//   HGSettingParameters *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9194A3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Override);
			//     byte_18D9194A3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2339, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( currentPipeline )
			//     {
			//       settingParameters_k__BackingField = currentPipeline.fields._settingParameters_k__BackingField;
			//       if ( settingParameters_k__BackingField )
			//       {
			//         renderingScale_k__BackingField = settingParameters_k__BackingField.fields._renderingScale_k__BackingField;
			//         if ( renderingScale_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::SettingParameter<float>::Override(
			//             renderingScale_k__BackingField,
			//             scale,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Override);
			//           v8 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//           if ( v8 )
			//           {
			//             v9 = v8.fields._settingParameters_k__BackingField;
			//             if ( v9 )
			//             {
			//               renderingScale_k__BackingField = v9.fields._renderingScale_k__BackingField;
			//               if ( renderingScale_k__BackingField )
			//               {
			//                 HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
			//                   (HGRenderPipelineSettingHub_SettingParameterBase *)renderingScale_k__BackingField,
			//                   0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(renderingScale_k__BackingField, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2339, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, scale, 0LL);
			// }
			// 
		}

		public void SetDLSSSQuality(DLSSQuality quality)
		{
			// // Void SetDLSSSQuality(DLSSQuality)
			// void HG::Rendering::Runtime::HGCamera::SetDLSSSQuality(HGCamera *this, DLSSQuality__Enum quality, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v7; // rdx
			//   SettingParameter_1_System_Int32Enum_ *dlssQuality_k__BackingField; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   HGRenderPipeline *v10; // rax
			//   HGSettingParameters *v11; // rax
			//   HGRenderPipeline *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector2Int nonScaledViewport; // [rsp+48h] [rbp+20h]
			// 
			//   if ( !byte_18D8EDA0B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::Override);
			//     byte_18D8EDA0B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2340, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v5);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( currentPipeline )
			//     {
			//       settingParameters_k__BackingField = currentPipeline.fields._settingParameters_k__BackingField;
			//       if ( settingParameters_k__BackingField )
			//       {
			//         dlssQuality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._dlssQuality_k__BackingField;
			//         if ( dlssQuality_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::Override(
			//             dlssQuality_k__BackingField,
			//             (Int32Enum__Enum)quality,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::Override);
			//           v10 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//           if ( v10 )
			//           {
			//             v11 = v10.fields._settingParameters_k__BackingField;
			//             if ( v11 )
			//             {
			//               dlssQuality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)v11.fields._dlssQuality_k__BackingField;
			//               if ( dlssQuality_k__BackingField )
			//               {
			//                 HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
			//                   (HGRenderPipelineSettingHub_SettingParameterBase *)dlssQuality_k__BackingField,
			//                   0LL);
			//                 nonScaledViewport = *(Vector2Int *)&this.fields._actualWidth_k__BackingField;
			//                 v12 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//                 if ( v12 )
			//                 {
			//                   HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
			//                     this,
			//                     v12.fields._settingParameters_k__BackingField,
			//                     nonScaledViewport,
			//                     0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(dlssQuality_k__BackingField, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2340, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, quality, 0LL);
			// }
			// 
		}

		public void SetFSR3Quality(FSR3Quality quality)
		{
			// // Void SetFSR3Quality(FSR3Quality)
			// void HG::Rendering::Runtime::HGCamera::SetFSR3Quality(HGCamera *this, FSR3Quality__Enum quality, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v7; // rdx
			//   SettingParameter_1_System_Int32Enum_ *fsr3Quality_k__BackingField; // rcx
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   HGRenderPipeline *v10; // rax
			//   HGSettingParameters *v11; // rax
			//   HGRenderPipeline *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector2Int nonScaledViewport; // [rsp+48h] [rbp+20h]
			// 
			//   if ( !byte_18D8EDA0C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::Override);
			//     byte_18D8EDA0C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2341, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v5);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( currentPipeline )
			//     {
			//       settingParameters_k__BackingField = currentPipeline.fields._settingParameters_k__BackingField;
			//       if ( settingParameters_k__BackingField )
			//       {
			//         fsr3Quality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)settingParameters_k__BackingField.fields._fsr3Quality_k__BackingField;
			//         if ( fsr3Quality_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::Override(
			//             fsr3Quality_k__BackingField,
			//             (Int32Enum__Enum)quality,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::Override);
			//           v10 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//           if ( v10 )
			//           {
			//             v11 = v10.fields._settingParameters_k__BackingField;
			//             if ( v11 )
			//             {
			//               fsr3Quality_k__BackingField = (SettingParameter_1_System_Int32Enum_ *)v11.fields._fsr3Quality_k__BackingField;
			//               if ( fsr3Quality_k__BackingField )
			//               {
			//                 HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
			//                   (HGRenderPipelineSettingHub_SettingParameterBase *)fsr3Quality_k__BackingField,
			//                   0LL);
			//                 nonScaledViewport = *(Vector2Int *)&this.fields._actualWidth_k__BackingField;
			//                 v12 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//                 if ( v12 )
			//                 {
			//                   HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
			//                     this,
			//                     v12.fields._settingParameters_k__BackingField,
			//                     nonScaledViewport,
			//                     0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(fsr3Quality_k__BackingField, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2341, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, quality, 0LL);
			// }
			// 
		}

		public void ToggleTAAU()
		{
			// // Void ToggleTAAU()
			// void HG::Rendering::Runtime::HGCamera::ToggleTAAU(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2342, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2342, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 2
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasing
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		public void ToggleMetalFXSpatial()
		{
			// // Void ToggleMetalFXSpatial()
			// void HG::Rendering::Runtime::HGCamera::ToggleMetalFXSpatial(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2343, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2343, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 4
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXSpatial
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		public void ToggleMetalFXTemporal()
		{
			// // Void ToggleMetalFXTemporal()
			// void HG::Rendering::Runtime::HGCamera::ToggleMetalFXTemporal(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2344, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2344, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 8
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXTemporal
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		public void ToggleTAAUWithMetalFXSpatial()
		{
			// // Void ToggleTAAUWithMetalFXSpatial()
			// void HG::Rendering::Runtime::HGCamera::ToggleTAAUWithMetalFXSpatial(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2345, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2345, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 6
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasingWithMetalFXSpatial
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		public void ToggleMetalFXTemporalWithMetalFXSpatial()
		{
			// // Void ToggleMetalFXTemporalWithMetalFXSpatial()
			// void HG::Rendering::Runtime::HGCamera::ToggleMetalFXTemporalWithMetalFXSpatial(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2346, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2346, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 12
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_MetalFXTemporalWithMetalFXSpatial
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		public void ToggleFSR3()
		{
			// // Void ToggleFSR3()
			// void HG::Rendering::Runtime::HGCamera::ToggleFSR3(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2347, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2347, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 64
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_FSR3
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		public void ToggleDLSS()
		{
			// // Void ToggleDLSS()
			// void HG::Rendering::Runtime::HGCamera::ToggleDLSS(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2348, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2348, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGCamera::get_renderPath(this, 0LL) != HGRenderPath__Enum_UI )
			//   {
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//       this,
			//       this.fields.m_antialiasingMode != 32
			//     ? HGAdditionalCameraData_AntialiasingMode__Enum_DLSS
			//     : HGAdditionalCameraData_AntialiasingMode__Enum_None,
			//       0LL);
			//   }
			// }
			// 
		}

		internal void RequestDynamicResolution(bool cameraRequestedDynamicRes, DynamicResolutionHandler dynResHandler)
		{
			// // Void RequestDynamicResolution(Boolean, DynamicResolutionHandler)
			// void HG::Rendering::Runtime::HGCamera::RequestDynamicResolution(
			//         HGCamera *this,
			//         bool cameraRequestedDynamicRes,
			//         DynamicResolutionHandler *dynResHandler,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGCamera_DynamicResolutionRequest v10; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2351, 0LL) )
			//   {
			//     if ( dynResHandler )
			//     {
			//       v10.enabled = UnityEngine::Rendering::DynamicResolutionHandler::DynamicResolutionEnabled(dynResHandler, 0LL);
			//       v10.cameraRequested = cameraRequestedDynamicRes;
			//       v10.hardwareEnabled = UnityEngine::Rendering::DynamicResolutionHandler::HardwareDynamicResIsEnabled(
			//                               dynResHandler,
			//                               0LL);
			//       v10.filter = dynResHandler.fields._filter_k__BackingField;
			//       this.fields._DynResRequest_k__BackingField = v10;
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2351, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(
			//     (ILFixDynamicMethodWrapper_8 *)Patch,
			//     (Object *)this,
			//     cameraRequestedDynamicRes,
			//     (Object *)dynResHandler,
			//     0LL);
			// }
			// 
		}

		public uint GetCullingViewUniqueID()
		{
			// // UInt32 GetCullingViewUniqueID()
			// uint32_t HG::Rendering::Runtime::HGCamera::GetCullingViewUniqueID(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2353, 0LL) )
			//     return this.fields.cullingViewUniqueID;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2353, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0U;
		}

		public void ForceOverrideCsmDistance(float csmDistance)
		{
			// // Void ForceOverrideCsmDistance(Single)
			// void HG::Rendering::Runtime::HGCamera::ForceOverrideCsmDistance(HGCamera *this, float csmDistance, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2354, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2354, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       csmDistance,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.overrideCsmMaxDistanceValue = csmDistance;
			//     this.fields.overrideCsmShadowDistance = 1;
			//   }
			// }
			// 
		}

		public void ResetOverrideCsmDistance()
		{
			// // Void ResetOverrideCsmDistance()
			// void HG::Rendering::Runtime::HGCamera::ResetOverrideCsmDistance(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2355, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2355, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.overrideCsmShadowDistance = 0;
			//     this.fields.overrideCsmMaxDistanceValue = 80.0;
			//   }
			// }
			// 
		}

		internal bool RequiresCameraJitter()
		{
			// // Boolean RequiresCameraJitter()
			// bool HG::Rendering::Runtime::HGCamera::RequiresCameraJitter(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_14;
			//   if ( wrapperArray.max_length.size > 680 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v3.static_fields;
			//     v7 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v7.max_length.size <= 0x2A8u )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v7[19].klass )
			//         return (this.fields.m_antialiasingMode & 2) != 0
			//             || UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL) && (this.fields.m_antialiasingMode & 8) != 0
			//             || (this.fields.m_antialiasingMode & 0x10) != 0
			//             || (this.fields.m_antialiasingMode & 0x20) != 0
			//             || (this.fields.m_antialiasingMode & 0x40) != 0;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(680, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     }
			// LABEL_14:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   return (this.fields.m_antialiasingMode & 2) != 0
			//       || UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL) && (this.fields.m_antialiasingMode & 8) != 0
			//       || (this.fields.m_antialiasingMode & 0x10) != 0
			//       || (this.fields.m_antialiasingMode & 0x20) != 0
			//       || (this.fields.m_antialiasingMode & 0x40) != 0;
			// }
			// 
			return default(bool);
		}

		private void InitializeVolumeComponentsData()
		{
		}

		internal unsafe HGRenderPathBeforeCullingParamsCPP* BeforeCullingCPP(HGSettingParameters settingParameters, CustomDepthOnlyRequestManager customDepthOnlyRequestManager, long customDepthOnlyRequestMgrCPP)
		{
			// // HGRenderPathBeforeCullingParamsCPP* BeforeCullingCPP(HGSettingParameters, CustomDepthOnlyRequestManager, Int64)
			// HGRenderPathBeforeCullingParamsCPP *HG::Rendering::Runtime::HGCamera::BeforeCullingCPP(
			//         HGCamera *this,
			//         HGSettingParameters *settingParameters,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestManager,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   int64_t v5; // r15
			//   __int64 (__fastcall *v8)(__int64, HGSettingParameters *, CustomDepthOnlyRequestManager *); // rax
			//   __int64 v9; // rbx
			//   HGRenderPipelineSettingHub *instance; // rax
			//   char *klass; // rdx
			//   unsigned __int64 currentDeviceType_k__BackingField; // rcx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   struct HGCamera__Class *v14; // rax
			//   __int64 v15; // rdx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rdi
			//   Color *p_directColor; // rax
			//   __int64 v19; // rdx
			//   HGLightConfig *v20; // rcx
			//   Color v21; // xmm0
			//   Color v22; // xmm1
			//   Color v23; // xmm0
			//   Color v24; // xmm1
			//   Color v25; // xmm0
			//   Color v26; // xmm1
			//   Color v27; // xmm0
			//   Color v28; // xmm1
			//   Color v29; // xmm1
			//   Color v30; // xmm0
			//   Color v31; // xmm1
			//   Color v32; // xmm0
			//   Color v33; // xmm1
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   HGShadowConfigCPP *v39; // rax
			//   __int64 v40; // rdx
			//   bool v41; // zf
			//   __int64 (*v42)(void); // rax
			//   unsigned int v43; // edi
			//   __int64 (__fastcall *v44)(_QWORD, __int64); // rax
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
			//   __int64 v46; // rax
			//   int32_t count; // eax
			//   int v48; // r14d
			//   __int64 (__fastcall *v49)(__int64); // rax
			//   __int64 (__fastcall *v50)(_QWORD); // rax
			//   __int64 v51; // rbp
			//   __int64 (__fastcall *v52)(_QWORD); // rax
			//   unsigned int v53; // edi
			//   __int64 v54; // r13
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rdi
			//   int *v56; // rax
			//   Object *m_hgCharacterVolume; // rdi
			//   __int64 v58; // rax
			//   __int64 v59; // rax
			//   __int64 v60; // rbp
			//   char v61; // al
			//   __int64 v62; // rbp
			//   int v63; // eax
			//   struct HGCharacterQualitySettings__Class *v64; // rcx
			//   int v65; // r14d
			//   bool v66; // al
			//   __int64 v67; // rbp
			//   int32_t v68; // eax
			//   __int64 v69; // rbp
			//   int v70; // eax
			//   MonitorData *monitor; // r14
			//   __int64 v72; // rbp
			//   Vector2 (*v73)(PQSFilter *, MethodInfo *); // rax
			//   unsigned __int64 v74; // xmm1_8
			//   Object__Class *v75; // rdi
			//   __int64 v76; // rbp
			//   Vector2 (*nameToClassHashTable)(PQSFilter *, MethodInfo *); // rax
			//   unsigned __int64 v78; // xmm1_8
			//   Camera *camera; // rax
			//   int64_t renderPathInstanceCPP; // rbp
			//   void *m_CachedPtr; // rdi
			//   void (__fastcall *v82)(int64_t, __int64, void *, __int64, _QWORD); // rax
			//   __int64 v84; // r15
			//   __int64 v85; // r12
			//   List_1_HG_Rendering_Runtime_HGCharacterHelper_ *characterHelpers; // rax
			//   __int64 v87; // xmm0_8
			//   List_1_HG_Rendering_Runtime_HGCharacterHelper_ *v88; // rax
			//   HGCharacterHelper *v89; // rbp
			//   __int64 v90; // rdx
			//   __int16 ID; // bp
			//   uint32_t v92; // eax
			//   __int64 v93; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGEnvironmentPhase *s_interpolatedPhase; // rax
			//   __int64 v96; // rax
			//   __int64 v97; // rax
			//   __int64 v98; // rax
			//   __int64 v99; // rax
			//   __int64 v100; // rax
			//   ILFixDynamicMethodWrapper_2 *v101; // rax
			//   ILFixDynamicMethodWrapper_2 *v102; // rax
			//   ILFixDynamicMethodWrapper_2 *v103; // rax
			//   __int64 v104; // rax
			//   __int64 v105; // [rsp+30h] [rbp-218h]
			//   __int64 v106; // [rsp+38h] [rbp-210h]
			//   HGShadowConfig v107; // [rsp+40h] [rbp-208h] BYREF
			//   HGLightConfig v108; // [rsp+B0h] [rbp-198h] BYREF
			// 
			//   v5 = customDepthOnlyRequestMgrCPP;
			//   if ( !byte_18D8EDA12 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDA12 = 1;
			//   }
			//   v8 = (__int64 (__fastcall *)(__int64, HGSettingParameters *, CustomDepthOnlyRequestManager *))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v8 = (__int64 (__fastcall *)(__int64, HGSettingParameters *, CustomDepthOnlyRequestManager *))il2cpp_resolve_icall_0("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//     if ( !v8 )
			//     {
			//       v93 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v93, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v8;
			//   }
			//   v9 = v8(248LL, settingParameters, customDepthOnlyRequestManager);
			//   instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_137;
			//   m_impl = instance.fields.m_impl;
			//   if ( !m_impl )
			//     goto LABEL_137;
			//   currentDeviceType_k__BackingField = (unsigned int)m_impl.fields._currentDeviceType_k__BackingField;
			//   if ( !v9 )
			//     goto LABEL_137;
			//   *(_DWORD *)v9 = currentDeviceType_k__BackingField;
			//   *(Vector2Int *)(v9 + 4) = this.fields._sceneRTSize_k__BackingField;
			//   v14 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, klass);
			//     v14 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//   }
			//   *(_DWORD *)(v9 + 12) = v14.static_fields.COMPOUND_CHARACTER_LAYER_MASK;
			//   *(_QWORD *)(v9 + 16) = &this.fields.lodCrossFadeConfig;
			//   *(_QWORD *)(v9 + 32) = HG::Rendering::Runtime::HGUtilsCpp::ConvertSettingParamsToCpp(settingParameters, 0LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v15);
			//   if ( !byte_18D8EDC5D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC5D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v15);
			//     currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//   if ( !klass )
			//     goto LABEL_137;
			//   if ( *((int *)klass + 6) <= 439 )
			//     goto LABEL_19;
			//   if ( !*(_DWORD *)(currentDeviceType_k__BackingField + 224) )
			//   {
			//     il2cpp_runtime_class_init_0(currentDeviceType_k__BackingField, klass);
			//     currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//   if ( !klass )
			//     goto LABEL_137;
			//   if ( *((_DWORD *)klass + 6) <= 0x1B7u )
			//     goto LABEL_142;
			//   if ( *((_QWORD *)klass + 443) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
			//     if ( !Patch )
			//       goto LABEL_137;
			//     s_interpolatedPhase = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			// LABEL_19:
			//     m_envVolumeCameraComponent = this.fields.m_envVolumeCameraComponent;
			//     if ( !m_envVolumeCameraComponent )
			//       goto LABEL_137;
			//     if ( m_envVolumeCameraComponent.fields.m_useEnvVolumeInterpolatedPhase )
			//     {
			//       m_interpolatedPhase = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//       goto LABEL_22;
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, klass);
			//     s_interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
			//   }
			//   m_interpolatedPhase = s_interpolatedPhase;
			// LABEL_22:
			//   if ( !m_interpolatedPhase )
			//     goto LABEL_137;
			//   p_directColor = &m_interpolatedPhase.fields.lightConfig.directColor;
			//   v19 = 2LL;
			//   v20 = &v108;
			//   do
			//   {
			//     v20 = (HGLightConfig *)((char *)v20 + 128);
			//     v21 = *p_directColor;
			//     v22 = p_directColor[1];
			//     p_directColor += 8;
			//     *(Color *)&v20[-1].localToWorld.m12 = v21;
			//     v23 = p_directColor[-6];
			//     *(Color *)&v20[-1].localToWorld.m13 = v22;
			//     v24 = p_directColor[-5];
			//     *(Color *)&v20[-1].rotationAtmosphere.y = v23;
			//     v25 = p_directColor[-4];
			//     *(Color *)&v20[-1].rotationLightShaft.y = v24;
			//     v26 = p_directColor[-3];
			//     *(Color *)&v20[-1].rotationSunDisc.y = v25;
			//     v27 = p_directColor[-2];
			//     *(Color *)&v20[-1].rotationLensFlare.y = v26;
			//     v28 = p_directColor[-1];
			//     *(Color *)&v20[-1].rotationCloudShadow.y = v27;
			//     *(Color *)&v20[-1].rotationHeightFogDirectionalInscattering.y = v28;
			//     --v19;
			//   }
			//   while ( v19 );
			//   v29 = p_directColor[1];
			//   v20.directColor = *p_directColor;
			//   v30 = p_directColor[2];
			//   *(Color *)&v20.directColorMode = v29;
			//   v31 = p_directColor[3];
			//   *(Color *)&v20.directCustomColor.a = v30;
			//   v32 = p_directColor[4];
			//   *(Color *)&v20.directSpecularIntensity = v31;
			//   v33 = p_directColor[5];
			//   *(Color *)&v20.indirectDiffuseFactor = v32;
			//   *(Color *)&v20.atmospherePitchYaw.x = v33;
			//   *(_QWORD *)(v9 + 40) = HG::Rendering::Runtime::HGUtilsCpp::ConvertLightConfigToCpp(&v108, 0LL);
			//   v34 = *(_OWORD *)&m_interpolatedPhase.fields.shadowConfig.csmIntensity;
			//   *(_OWORD *)&v107.csmDepthBias = *(_OWORD *)&m_interpolatedPhase.fields.shadowConfig.csmDepthBias;
			//   v35 = *(_OWORD *)&m_interpolatedPhase.fields.shadowConfig.csmShadowSoftness;
			//   *(_OWORD *)&v107.csmIntensity = v34;
			//   v36 = *(_OWORD *)&m_interpolatedPhase.fields.shadowConfig.contactShadowSurfaceThickness;
			//   *(_OWORD *)&v107.csmShadowSoftness = v35;
			//   v37 = *(_OWORD *)&m_interpolatedPhase.fields.shadowConfig.overrideCsmFarDistance;
			//   *(_OWORD *)&v107.contactShadowSurfaceThickness = v36;
			//   v38 = *(_OWORD *)&m_interpolatedPhase.fields.shadowConfig.overrideCsmSpherePosition.z;
			//   *(_OWORD *)&v107.overrideCsmFarDistance = v37;
			//   *(_QWORD *)&v107.csmSimulatedAttenuation = *(_QWORD *)&m_interpolatedPhase.fields.shadowConfig.csmSimulatedAttenuation;
			//   *(_OWORD *)&v107.overrideCsmSpherePosition.z = v38;
			//   v39 = HG::Rendering::Runtime::HGUtilsCpp::ConvertShadowConfigToCpp(&v107, 0LL);
			//   v41 = byte_18D8F5550 == 0;
			//   *(_QWORD *)(v9 + 48) = v39;
			//   *(float *)(v9 + 56) = m_interpolatedPhase.fields.heightFogConfig.heightFogCullingFarClipPlane;
			//   *(_BYTE *)(v9 + 64) = this.fields.overrideCsmShadowDistance;
			//   *(float *)(v9 + 60) = this.fields.overrideCsmMaxDistanceValue;
			//   *(_BYTE *)(v9 + 65) = this.fields.enableShadowCulling;
			//   *(_BYTE *)(v9 + 66) = this.fields.regenerateAsmTriggerForCpp;
			//   if ( v41 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     byte_18D8F5550 = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Graphics._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Graphics, v40);
			//   v42 = (__int64 (*)(void))qword_18D8F4460;
			//   if ( !qword_18D8F4460 )
			//   {
			//     v42 = (__int64 (*)(void))il2cpp_resolve_icall_0("UnityEngine.Graphics::get_activeTier()");
			//     if ( !v42 )
			//     {
			//       v96 = sub_1802DBBE8("UnityEngine.Graphics::get_activeTier()");
			//       sub_18000F750(v96, 0LL);
			//     }
			//     qword_18D8F4460 = (__int64)v42;
			//   }
			//   v43 = v42();
			//   v44 = (__int64 (__fastcall *)(_QWORD, __int64))qword_18D8F5548;
			//   if ( !qword_18D8F5548 )
			//   {
			//     v44 = (__int64 (__fastcall *)(_QWORD, __int64))il2cpp_resolve_icall_0(
			//                                                      "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine"
			//                                                      ".Rendering.GraphicsTier,UnityEngine.Rendering.BuiltinShaderDefine)");
			//     if ( !v44 )
			//     {
			//       v97 = sub_1802DBBE8(
			//               "UnityEngine.Rendering.GraphicsSettings::HasShaderDefine(UnityEngine.Rendering.GraphicsTier,UnityEngine.Ren"
			//               "dering.BuiltinShaderDefine)");
			//       sub_18000F750(v97, 0LL);
			//     }
			//     qword_18D8F5548 = (__int64)v44;
			//   }
			//   *(_BYTE *)(v9 + 68) = v44(v43, 33LL);
			//   *(_BYTE *)(v9 + 70) = this.fields.prevTransformReset;
			//   *(_DWORD *)(v9 + 72) = this.fields.cullingViewUniqueID;
			//   *(_BYTE *)(v9 + 67) = 0;
			//   *(_BYTE *)(v9 + 71) = 0;
			//   *(_BYTE *)(v9 + 69) = 0;
			//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_137;
			//   currentDeviceType_k__BackingField = (unsigned __int64)this;
			//   if ( m_AdditionalCameraData.fields.hgRenderPath != 1 )
			//     currentDeviceType_k__BackingField = (unsigned __int64)HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(
			//                                                             this,
			//                                                             0LL);
			//   if ( currentDeviceType_k__BackingField )
			//   {
			//     *(_QWORD *)(v9 + 24) = currentDeviceType_k__BackingField + 2536;
			//     v46 = *(_QWORD *)(currentDeviceType_k__BackingField + 96);
			//     if ( !v46 )
			//       goto LABEL_137;
			//     v106 = *(_QWORD *)(v46 + 16);
			//   }
			//   else
			//   {
			//     *(_QWORD *)(v9 + 24) = 0LL;
			//     v106 = 0LL;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, klass);
			//   count = HG::Rendering::Runtime::HGCharacters::get_count(0LL);
			//   v48 = 15;
			//   if ( count < 15 )
			//     v48 = count;
			//   v49 = (__int64 (__fastcall *)(__int64))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v49 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_0(
			//                                              "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//     if ( !v49 )
			//     {
			//       v98 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v98, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v49;
			//   }
			//   *(_QWORD *)(v9 + 80) = v49(56LL);
			//   v50 = (__int64 (__fastcall *)(_QWORD))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v50 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0(
			//                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//     if ( !v50 )
			//     {
			//       v99 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v99, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v50;
			//   }
			//   v51 = v50(24 * v48);
			//   v105 = v51;
			//   v52 = (__int64 (__fastcall *)(_QWORD))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v52 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0(
			//                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//     if ( !v52 )
			//     {
			//       v100 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v100, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v52;
			//   }
			//   v53 = 0;
			//   v54 = v52(4 * v48);
			//   if ( v48 > 0 )
			//   {
			//     v84 = 0LL;
			//     v85 = v51;
			//     do
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, klass);
			//       characterHelpers = HG::Rendering::Runtime::HGCharacters::get_characterHelpers(0LL);
			//       if ( !characterHelpers )
			//         goto LABEL_137;
			//       if ( v53 >= characterHelpers.fields._size )
			//         goto LABEL_181;
			//       currentDeviceType_k__BackingField = (unsigned __int64)characterHelpers.fields._items;
			//       if ( !currentDeviceType_k__BackingField )
			//         goto LABEL_137;
			//       if ( v53 >= *(_DWORD *)(currentDeviceType_k__BackingField + 24) )
			//         goto LABEL_142;
			//       klass = *(char **)(currentDeviceType_k__BackingField + 8LL * (int)v53 + 32);
			//       if ( !klass )
			//         goto LABEL_137;
			//       v87 = *(_QWORD *)(klass + 92);
			//       *(_OWORD *)v85 = *(_OWORD *)(klass + 76);
			//       *(_QWORD *)(v85 + 16) = v87;
			//       v88 = HG::Rendering::Runtime::HGCharacters::get_characterHelpers(0LL);
			//       if ( !v88 )
			//         goto LABEL_137;
			//       if ( v53 >= v88.fields._size )
			// LABEL_181:
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       currentDeviceType_k__BackingField = (unsigned __int64)v88.fields._items;
			//       if ( !currentDeviceType_k__BackingField )
			//         goto LABEL_137;
			//       if ( v53 >= *(_DWORD *)(currentDeviceType_k__BackingField + 24) )
			//         goto LABEL_142;
			//       v89 = *(HGCharacterHelper **)(currentDeviceType_k__BackingField + 8LL * (int)v53 + 32);
			//       if ( !v89 )
			//         goto LABEL_137;
			//       if ( !byte_18D8EDB90 )
			//       {
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//         byte_18D8EDB90 = 1;
			//       }
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, klass);
			//       ID = HG::Rendering::Runtime::HGCharacters::QueryID(v89, 0LL);
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         byte_18D8EDC37 = 1;
			//       }
			//       currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v90);
			//         currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//       if ( !klass )
			//         goto LABEL_137;
			//       if ( *((int *)klass + 6) <= 1787 )
			//         goto LABEL_132;
			//       if ( !*(_DWORD *)(currentDeviceType_k__BackingField + 224) )
			//       {
			//         il2cpp_runtime_class_init_0(currentDeviceType_k__BackingField, klass);
			//         currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       currentDeviceType_k__BackingField = **(_QWORD **)(currentDeviceType_k__BackingField + 184);
			//       if ( !currentDeviceType_k__BackingField )
			//         goto LABEL_137;
			//       if ( *(_DWORD *)(currentDeviceType_k__BackingField + 24) <= 0x6FBu )
			//         goto LABEL_142;
			//       if ( *(_QWORD *)(currentDeviceType_k__BackingField + 14328) )
			//       {
			//         v101 = IFix::WrappersManagerImpl::GetPatch(1787, 0LL);
			//         if ( !v101 )
			//           goto LABEL_137;
			//         v92 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_694(v101, ID, 0LL);
			//       }
			//       else
			//       {
			// LABEL_132:
			//         if ( ID < 0 )
			//         {
			//           v92 = 0;
			//         }
			//         else
			//         {
			//           currentDeviceType_k__BackingField = ((_BYTE)ID + 8) & 0x1F;
			//           v92 = 1 << currentDeviceType_k__BackingField;
			//         }
			//       }
			//       *(_DWORD *)(v54 + 4 * v84) = v92;
			//       ++v53;
			//       ++v84;
			//       v85 += 24LL;
			//     }
			//     while ( v84 < v48 );
			//     v51 = v105;
			//     v5 = customDepthOnlyRequestMgrCPP;
			//   }
			//   m_volumeComponentsData = this.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_137;
			//   v56 = *(int **)(v9 + 80);
			//   m_hgCharacterVolume = (Object *)m_volumeComponentsData.fields.m_hgCharacterVolume;
			//   if ( !v56 )
			//     goto LABEL_137;
			//   *v56 = v48;
			//   v58 = *(_QWORD *)(v9 + 80);
			//   if ( !v58 )
			//     goto LABEL_137;
			//   *(_QWORD *)(v58 + 8) = v51;
			//   v59 = *(_QWORD *)(v9 + 80);
			//   if ( !v59 )
			//     goto LABEL_137;
			//   *(_QWORD *)(v59 + 16) = v54;
			//   v60 = *(_QWORD *)(v9 + 80);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !m_hgCharacterVolume )
			//     goto LABEL_136;
			//   currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( m_hgCharacterVolume[1].klass )
			//     v61 = 1;
			//   else
			// LABEL_136:
			//     v61 = 0;
			//   if ( !v60 )
			//     goto LABEL_137;
			//   v41 = byte_18D8F4EFB == 0;
			//   *(_BYTE *)(v60 + 24) = v61;
			//   if ( v41 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( m_hgCharacterVolume )
			//   {
			//     currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//     if ( m_hgCharacterVolume[1].klass )
			//     {
			//       v62 = *(_QWORD *)(v9 + 80);
			//       if ( !byte_18D8ED9CF )
			//       {
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
			//         byte_18D8ED9CF = 1;
			//       }
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         byte_18D8EDC37 = 1;
			//       }
			//       currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, klass);
			//         currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//       if ( !klass )
			//         goto LABEL_137;
			//       if ( *((int *)klass + 6) <= 719 )
			//         goto LABEL_81;
			//       if ( !*(_DWORD *)(currentDeviceType_k__BackingField + 224) )
			//       {
			//         il2cpp_runtime_class_init_0(currentDeviceType_k__BackingField, klass);
			//         currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//       if ( !klass )
			//         goto LABEL_137;
			//       if ( *((_DWORD *)klass + 6) <= 0x2CFu )
			//         goto LABEL_142;
			//       if ( *((_QWORD *)klass + 723) )
			//       {
			//         v102 = IFix::WrappersManagerImpl::GetPatch(719, 0LL);
			//         if ( !v102 )
			//           goto LABEL_137;
			//         v66 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                 (ILFixDynamicMethodWrapper_27 *)v102,
			//                 m_hgCharacterVolume,
			//                 0LL);
			//       }
			//       else
			//       {
			// LABEL_81:
			//         klass = (char *)m_hgCharacterVolume[27].klass;
			//         if ( !klass )
			//           goto LABEL_137;
			//         v63 = sub_18003ED00(10LL);
			//         v64 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//         v65 = v63;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings, klass);
			//           v64 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//         }
			//         currentDeviceType_k__BackingField = (unsigned __int64)v64.static_fields;
			//         v66 = *(_DWORD *)(currentDeviceType_k__BackingField + 4) >= v65;
			//       }
			//       if ( !v62 )
			//         goto LABEL_137;
			//       v41 = byte_18D8EDC37 == 0;
			//       *(_BYTE *)(v62 + 25) = v66;
			//       v67 = *(_QWORD *)(v9 + 80);
			//       if ( v41 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         byte_18D8EDC37 = 1;
			//       }
			//       currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, klass);
			//         currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//       if ( !klass )
			//         goto LABEL_137;
			//       if ( *((int *)klass + 6) <= 1785 )
			//         goto LABEL_92;
			//       if ( !*(_DWORD *)(currentDeviceType_k__BackingField + 224) )
			//       {
			//         il2cpp_runtime_class_init_0(currentDeviceType_k__BackingField, klass);
			//         currentDeviceType_k__BackingField = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       klass = **(char ***)(currentDeviceType_k__BackingField + 184);
			//       if ( !klass )
			//         goto LABEL_137;
			//       if ( *((_DWORD *)klass + 6) > 0x6F9u )
			//       {
			//         if ( *((_QWORD *)klass + 1789) )
			//         {
			//           v103 = IFix::WrappersManagerImpl::GetPatch(1785, 0LL);
			//           if ( !v103 )
			//             goto LABEL_137;
			//           v68 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(
			//                   (ILFixDynamicMethodWrapper_20 *)v103,
			//                   m_hgCharacterVolume,
			//                   0LL);
			//           goto LABEL_94;
			//         }
			// LABEL_92:
			//         klass = (char *)m_hgCharacterVolume[16].monitor;
			//         if ( !klass )
			//           goto LABEL_137;
			//         v68 = sub_18003ED00(10LL);
			// LABEL_94:
			//         if ( v67 )
			//         {
			//           *(_DWORD *)(v67 + 28) = v68;
			//           klass = (char *)m_hgCharacterVolume[12].klass;
			//           v69 = *(_QWORD *)(v9 + 80);
			//           if ( klass )
			//           {
			//             v70 = sub_18003ED00(10LL);
			//             if ( v69 )
			//             {
			//               *(_DWORD *)(v69 + 32) = v70;
			//               monitor = m_hgCharacterVolume[12].monitor;
			//               v72 = *(_QWORD *)(v9 + 80);
			//               if ( monitor )
			//               {
			//                 sub_180003EE0(*(_QWORD *)monitor);
			//                 klass = *(char **)monitor;
			//                 v73 = *(Vector2 (**)(PQSFilter *, MethodInfo *))(*(_QWORD *)monitor + 480LL);
			//                 v74 = v73 == Beyond::Gameplay::Core::PQSFilter::get_factorRange
			//                     ? _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]
			//                     : ((__int64 (__fastcall *)(MonitorData *, _QWORD))v73)(monitor, *((_QWORD *)klass + 61));
			//                 if ( v72 )
			//                 {
			//                   *(_QWORD *)(v72 + 44) = v74;
			//                   v75 = m_hgCharacterVolume[13].klass;
			//                   v76 = *(_QWORD *)(v9 + 80);
			//                   if ( v75 )
			//                   {
			//                     sub_180003EE0(v75._0.image);
			//                     klass = (char *)v75._0.image;
			//                     nameToClassHashTable = (Vector2 (*)(PQSFilter *, MethodInfo *))v75._0.image[6].nameToClassHashTable;
			//                     v78 = nameToClassHashTable == Beyond::Gameplay::Core::PQSFilter::get_factorRange
			//                         ? _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]
			//                         : ((__int64 (__fastcall *)(Object__Class *, _QWORD))nameToClassHashTable)(
			//                             v75,
			//                             *((_QWORD *)klass + 61));
			//                     if ( v76 )
			//                     {
			//                       *(_QWORD *)(v76 + 36) = v78;
			//                       goto LABEL_106;
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			// LABEL_137:
			//         sub_180B536AC(currentDeviceType_k__BackingField, klass);
			//       }
			// LABEL_142:
			//       sub_180070270(currentDeviceType_k__BackingField, klass);
			//     }
			//   }
			// LABEL_106:
			//   *(_QWORD *)(v9 + 96) = 0LL;
			//   *(_QWORD *)(v9 + 136) = v5;
			//   camera = this.fields.camera;
			//   renderPathInstanceCPP = this.fields.renderPathInstanceCPP;
			//   if ( !camera )
			//     goto LABEL_137;
			//   m_CachedPtr = camera.fields._._._.m_CachedPtr;
			//   v82 = (void (__fastcall *)(int64_t, __int64, void *, __int64, _QWORD))qword_18D8F5808;
			//   if ( !qword_18D8F5808 )
			//   {
			//     v82 = (void (__fastcall *)(int64_t, __int64, void *, __int64, _QWORD))il2cpp_resolve_icall_0(
			//                                                                             "UnityEngine.HyperGryphEngineCode.HGRenderGra"
			//                                                                             "phCPP::HGRenderPath_BeforeCulling(System.Int"
			//                                                                             "64,UnityEngine.HyperGryphEngineCode.HGRender"
			//                                                                             "PathBeforeCullingParamsCPP*,System.IntPtr,Sy"
			//                                                                             "stem.IntPtr,System.IntPtr)");
			//     if ( !v82 )
			//     {
			//       v104 = sub_1802DBBE8(
			//                "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::HGRenderPath_BeforeCulling(System.Int64,UnityEngine.Hy"
			//                "perGryphEngineCode.HGRenderPathBeforeCullingParamsCPP*,System.IntPtr,System.IntPtr,System.IntPtr)");
			//       sub_18000F750(v104, 0LL);
			//     }
			//     qword_18D8F5808 = (__int64)v82;
			//   }
			//   v82(renderPathInstanceCPP, v9, m_CachedPtr, v106, 0LL);
			//   return (HGRenderPathBeforeCullingParamsCPP *)v9;
			// }
			// 
			return null;
		}

		internal void DoECSCullingCPP(HGSettingParameters settingParameters, CustomDepthOnlyRequestManager customDepthOnlyRequestManager, long customDepthOnlyRequestMgrCPP)
		{
			// // Void DoECSCullingCPP(HGSettingParameters, CustomDepthOnlyRequestManager, Int64)
			// void HG::Rendering::Runtime::HGCamera::DoECSCullingCPP(
			//         HGCamera *this,
			//         HGSettingParameters *settingParameters,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestManager,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   void *beforeCullingParams; // rcx
			//   __int64 v10; // rdx
			//   HGRenderPathBeforeCullingParamsCPP *v11; // rax
			//   HGCamera *LightWeightCamera; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   beforeCullingParams = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     beforeCullingParams = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v10 = **((_QWORD **)beforeCullingParams + 23);
			//   if ( !v10 )
			//     goto LABEL_12;
			//   if ( *(int *)(v10 + 24) > 789 )
			//   {
			//     if ( !*((_DWORD *)beforeCullingParams + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(beforeCullingParams, v10);
			//       beforeCullingParams = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     beforeCullingParams = (void *)**((_QWORD **)beforeCullingParams + 23);
			//     if ( !beforeCullingParams )
			//       goto LABEL_12;
			//     if ( *((_DWORD *)beforeCullingParams + 6) <= 0x315u )
			//       sub_180070270(beforeCullingParams, v10);
			//     if ( *((_QWORD *)beforeCullingParams + 793) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(789, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_213(
			//           Patch,
			//           (Object *)this,
			//           (Object *)settingParameters,
			//           (Object *)customDepthOnlyRequestManager,
			//           customDepthOnlyRequestMgrCPP,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_12;
			//     }
			//   }
			//   v11 = HG::Rendering::Runtime::HGCamera::BeforeCullingCPP(
			//           this,
			//           settingParameters,
			//           customDepthOnlyRequestManager,
			//           customDepthOnlyRequestMgrCPP,
			//           0LL);
			//   this.fields.beforeCullingParams = v11;
			//   if ( !v11 )
			//     goto LABEL_12;
			//   this.fields.cullingViewHandle = v11.cullingViewHandle;
			//   LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
			//   if ( !LightWeightCamera )
			//     return;
			//   beforeCullingParams = this.fields.beforeCullingParams;
			//   if ( !beforeCullingParams )
			// LABEL_12:
			//     sub_180B536AC(beforeCullingParams, v10);
			//   LightWeightCamera.fields.cullingViewHandle = *((_DWORD *)beforeCullingParams + 55);
			// }
			// 
		}

		internal void DoECSCulling(HGSettingParameters settingParameters, ref HGRenderPipeline.HGCullingResults cullingResults)
		{
			// // Void DoECSCulling(HGSettingParameters, HGRenderPipeline+HGCullingResults ByRef)
			// void HG::Rendering::Runtime::HGCamera::DoECSCulling(
			//         HGCamera *this,
			//         HGSettingParameters *settingParameters,
			//         HGRenderPipeline_HGCullingResults *cullingResults,
			//         MethodInfo *method)
			// {
			//   Camera *camera; // rdx
			//   Object_1 *v8; // rcx
			//   Transform *transform; // rax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm7_8
			//   float v12; // esi
			//   Matrix4x4 *projectionMatrix; // rax
			//   float v14; // xmm6_4
			//   __m128 v15; // xmm6
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   float v18; // xmm6_4
			//   float v19; // eax
			//   float v20; // xmm6_4
			//   float v21; // xmm8_4
			//   float v22; // xmm6_4
			//   float v23; // xmm0_4
			//   float v24; // xmm7_4
			//   bool useOcclusionCulling; // si
			//   int32_t v26; // eax
			//   Camera *v27; // rbx
			//   uint64_t SceneCullingMaskFromCamera; // rax
			//   int32_t cullingMask; // eax
			//   unsigned int v30; // r14d
			//   int v31; // ebx
			//   int v32; // esi
			//   Transform *v33; // rax
			//   Vector3 *forward; // rax
			//   float fieldOfView; // xmm0_4
			//   float v36; // xmm9_4
			//   float aspect; // xmm0_4
			//   float v38; // xmm6_4
			//   float v39; // xmm0_4
			//   float farClipPlane; // xmm0_4
			//   __int64 (__fastcall *v41)(Matrix4x4 *, _QWORD, _QWORD, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, uint32_t, int, int, Vector3 *, JobHandle *, _DWORD, _DWORD); // rax
			//   HGCamera *LightWeightCamera; // rax
			//   HGCamera *v43; // r14
			//   Camera *v44; // rsi
			//   Transform *v45; // rax
			//   Vector3 *v46; // rax
			//   __int64 v47; // xmm6_8
			//   float v48; // ebx
			//   Matrix4x4 *v49; // rax
			//   __int128 v50; // xmm1
			//   float v51; // xmm2_4
			//   __int128 v52; // xmm0
			//   unsigned int v53; // r12d
			//   uint64_t v54; // r13
			//   CameraType__Enum v55; // esi
			//   __int64 (__fastcall *v56)(Matrix4x4 *, _QWORD, uint64_t, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, _DWORD, _DWORD, _DWORD, Vector3 *, JobHandle *, _DWORD, int); // rax
			//   uint32_t v57; // ebx
			//   Matrix4x4 *v58; // rax
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   Vector3 *v62; // rax
			//   __int64 v63; // xmm6_8
			//   float v64; // esi
			//   int32_t v65; // eax
			//   Camera *v66; // rbx
			//   uint64_t v67; // rax
			//   __int64 v68; // rdx
			//   Camera *v69; // rcx
			//   uint64_t v70; // rbx
			//   int32_t v71; // eax
			//   __int128 v72; // xmm1
			//   __int128 v73; // xmm0
			//   uint32_t v74; // eax
			//   uint32_t cullingViewHandle; // ebx
			//   Matrix4x4 *cameraToWorldMatrix; // rax
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   Vector3 *Position; // rax
			//   __int64 v81; // xmm6_8
			//   float z; // esi
			//   int32_t InstanceID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned int v85; // [rsp+88h] [rbp-80h]
			//   unsigned int v86; // [rsp+88h] [rbp-80h]
			//   Vector3 v87; // [rsp+98h] [rbp-70h] BYREF
			//   JobHandle v88; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v89; // [rsp+B8h] [rbp-50h] BYREF
			//   uint32_t cullingViewUniqueID; // [rsp+C8h] [rbp-40h]
			//   CameraType__Enum cameraType; // [rsp+CCh] [rbp-3Ch]
			//   Matrix4x4 v92; // [rsp+D8h] [rbp-30h] BYREF
			//   JobHandle v93; // [rsp+118h] [rbp+10h] BYREF
			//   Matrix4x4 v94[2]; // [rsp+128h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D9194A6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D9194A6 = 1;
			//   }
			//   *(_QWORD *)&v89.x = 0LL;
			//   v89.z = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(790, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(790, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_302(
			//         Patch,
			//         (Object *)this,
			//         (Object *)settingParameters,
			//         cullingResults,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_47;
			//   }
			//   if ( HG::Rendering::Runtime::HGCamera::IsUICamera(this, 0LL) )
			//   {
			//     camera = this.fields.camera;
			//     cullingViewHandle = this.fields.cullingViewHandle;
			//     if ( camera )
			//     {
			//       cameraToWorldMatrix = UnityEngine::Camera::get_cameraToWorldMatrix(v94, camera, 0LL);
			//       v77 = *(_OWORD *)&cameraToWorldMatrix.m01;
			//       *(_OWORD *)&v92.m00 = *(_OWORD *)&cameraToWorldMatrix.m00;
			//       v78 = *(_OWORD *)&cameraToWorldMatrix.m02;
			//       *(_OWORD *)&v92.m01 = v77;
			//       v79 = *(_OWORD *)&cameraToWorldMatrix.m03;
			//       *(_OWORD *)&v92.m02 = v78;
			//       *(_OWORD *)&v92.m03 = v79;
			//       Position = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v88, &v92, 0LL);
			//       v8 = (Object_1 *)this.fields.camera;
			//       v81 = *(_QWORD *)&Position.x;
			//       z = Position.z;
			//       if ( v8 )
			//       {
			//         InstanceID = UnityEngine::Object::GetInstanceID(v8, 0LL);
			//         *(_QWORD *)&v87.x = v81;
			//         v87.z = z;
			//         cullingResults.lightCullResult = *UnityEngine::HyperGryph::HGCullingSystem::CullLights(
			//                                              (LightCullResult *)&v88,
			//                                              cullingViewHandle,
			//                                              &v87,
			//                                              0x100u,
			//                                              InstanceID,
			//                                              0LL);
			//         return;
			//       }
			//     }
			//     goto LABEL_47;
			//   }
			//   this.fields.lodCrossFadeConfig.enableDither = 1;
			//   v8 = (Object_1 *)this.fields.camera;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   this.fields.lodCrossFadeConfig.isOrtho = UnityEngine::Camera::get_orthographic((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   transform = UnityEngine::Component::get_transform((Component *)v8, 0LL);
			//   if ( !transform )
			//     goto LABEL_47;
			//   v10 = UnityEngine::Transform::get_position(&v87, transform, 0LL);
			//   v11 = *(_QWORD *)&v10.x;
			//   v12 = v10.z;
			//   this.fields.lodCrossFadeConfig.enableDither &= !this.fields.prevTransformReset;
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_47;
			//   projectionMatrix = UnityEngine::Camera::get_projectionMatrix(v94, camera, 0LL);
			//   if ( this.fields.lodCrossFadeConfig.isOrtho )
			//   {
			//     v8 = (Object_1 *)this.fields.camera;
			//     if ( !v8 )
			//       goto LABEL_47;
			//     v14 = 1.0 / UnityEngine::Camera::get_orthographicSize((Camera *)v8, 0LL);
			//   }
			//   else
			//   {
			//     v15 = *(__m128 *)&projectionMatrix.m01;
			//     v16 = *(_OWORD *)&projectionMatrix.m03;
			//     *(_OWORD *)&v92.m00 = *(_OWORD *)&projectionMatrix.m00;
			//     v17 = *(_OWORD *)&projectionMatrix.m02;
			//     *(_OWORD *)&v92.m03 = v16;
			//     *(_OWORD *)&v92.m02 = v17;
			//     LODWORD(v14) = _mm_shuffle_ps(v15, v15, 85).m128_u32[0];
			//   }
			//   v18 = v14 * v14;
			//   if ( !this.fields.lodCrossFadeConfig.enableDither )
			//   {
			//     *(_QWORD *)&this.fields.lodCrossFadeConfig.c0.x = v11;
			//     this.fields.lodCrossFadeConfig.c0.z = v12;
			//     *(_QWORD *)&this.fields.lodCrossFadeConfig.c1.x = v11;
			//     this.fields.lodCrossFadeConfig.c1.z = v12;
			//     this.fields.lodCrossFadeConfig.maxProjFactorSquared0 = v18;
			// LABEL_17:
			//     this.fields.lodCrossFadeConfig.maxProjFactorSquared1 = v18;
			//     goto LABEL_18;
			//   }
			//   if ( UnityEngine::HyperGryph::HGLODStateSystem::IsCurrFrameTriggerTransition(0LL) )
			//   {
			//     v19 = this.fields.lodCrossFadeConfig.c1.z;
			//     *(_QWORD *)&this.fields.lodCrossFadeConfig.c0.x = *(_QWORD *)&this.fields.lodCrossFadeConfig.c1.x;
			//     this.fields.lodCrossFadeConfig.c0.z = v19;
			//     *(_QWORD *)&this.fields.lodCrossFadeConfig.c1.x = v11;
			//     this.fields.lodCrossFadeConfig.c1.z = v12;
			//     this.fields.lodCrossFadeConfig.maxProjFactorSquared0 = this.fields.lodCrossFadeConfig.maxProjFactorSquared1;
			//     goto LABEL_17;
			//   }
			// LABEL_18:
			//   *(_QWORD *)&this.fields.lodCrossFadeConfig.cameraPosition.x = v11;
			//   this.fields.lodCrossFadeConfig.cameraPosition.z = v12;
			//   this.fields.lodCrossFadeConfig.currMaxProjFactorSquared = v18;
			//   this.fields.lodCrossFadeConfig.fraction = UnityEngine::HyperGryph::HGLODStateSystem::GetLODTransitionFraction(0LL);
			//   if ( !settingParameters )
			//     goto LABEL_47;
			//   v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._cullingViewScreenSizeMin_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v21 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._cullingViewScreenSizeMin_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
			//       * v20;
			//   v22 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._ocScreenSizeMin_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v23 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._ocScreenSizeMin_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v8 = (Object_1 *)this.fields.camera;
			//   v24 = v23 * v22;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   useOcclusionCulling = UnityEngine::Camera::get_useOcclusionCulling((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   v26 = UnityEngine::Object::GetInstanceID(v8, 0LL);
			//   v27 = this.fields.camera;
			//   v85 = v26;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v27, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   *(_QWORD *)&v87.x = SceneCullingMaskFromCamera;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   v30 = cullingMask;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   cameraType = UnityEngine::Camera::get_cameraType((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   cullingViewUniqueID = this.fields.cullingViewUniqueID;
			//   v31 = useOcclusionCulling ? 0x140 : 0;
			//   v32 = useOcclusionCulling ? 0xA0 : 0;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   v33 = UnityEngine::Component::get_transform((Component *)v8, 0LL);
			//   if ( !v33 )
			//     goto LABEL_47;
			//   forward = UnityEngine::Transform::get_forward((Vector3 *)&v88, v33, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   v89 = *forward;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   v36 = fieldOfView;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   aspect = UnityEngine::Camera::get_aspect((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   v38 = aspect;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   v39 = UnityEngine::Camera::get_nearClipPlane((Camera *)v8, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   v88.jobGroup = __PAIR64__(LODWORD(v38), LODWORD(v36));
			//   *(float *)&v88.jobType = v39;
			//   farClipPlane = UnityEngine::Camera::get_farClipPlane((Camera *)v8, 0LL);
			//   v41 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, _QWORD, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, uint32_t, int, int, Vector3 *, JobHandle *, _DWORD, _DWORD))qword_18D92FA48;
			//   *((float *)&v88.jobType + 1) = farClipPlane;
			//   v93 = v88;
			//   if ( !qword_18D92FA48 )
			//   {
			//     v41 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, _QWORD, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, uint32_t, int, int, Vector3 *, JobHandle *, _DWORD, _DWORD))sub_180017470("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByMatrix(UnityEngine.Matrix4x4&,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
			//     qword_18D92FA48 = (__int64)v41;
			//   }
			//   this.fields.cullingViewHandle = v41(
			//                                      &this.fields.mainViewConstants.cullingMatrix,
			//                                      v85,
			//                                      *(_QWORD *)&v87.x,
			//                                      v30,
			//                                      0,
			//                                      0,
			//                                      &this.fields.lodCrossFadeConfig,
			//                                      LODWORD(v21),
			//                                      cameraType,
			//                                      cullingViewUniqueID,
			//                                      v31,
			//                                      v32,
			//                                      &v89,
			//                                      &v93,
			//                                      0,
			//                                      LODWORD(v24));
			//   LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
			//   v43 = LightWeightCamera;
			//   if ( LightWeightCamera )
			//   {
			//     v44 = LightWeightCamera.fields.camera;
			//     if ( v44 )
			//     {
			//       v45 = UnityEngine::Component::get_transform((Component *)LightWeightCamera.fields.camera, 0LL);
			//       if ( v45 )
			//       {
			//         v46 = UnityEngine::Transform::get_position((Vector3 *)&v88, v45, 0LL);
			//         v47 = *(_QWORD *)&v46.x;
			//         v48 = v46.z;
			//         v49 = UnityEngine::Camera::get_projectionMatrix(v94, v44, 0LL);
			//         v50 = *(_OWORD *)&v49.m03;
			//         v51 = _mm_shuffle_ps(*(__m128 *)&v49.m01, *(__m128 *)&v49.m01, 85).m128_f32[0];
			//         *(_OWORD *)&v92.m00 = *(_OWORD *)&v49.m00;
			//         v52 = *(_OWORD *)&v49.m02;
			//         v43.fields.lodCrossFadeConfig.enableDither = 0;
			//         v43.fields.lodCrossFadeConfig.currMaxProjFactorSquared = v51 * v51;
			//         *(_QWORD *)&v43.fields.lodCrossFadeConfig.cameraPosition.x = v47;
			//         v43.fields.lodCrossFadeConfig.cameraPosition.z = v48;
			//         *(_OWORD *)&v92.m02 = v52;
			//         *(_OWORD *)&v92.m03 = v50;
			//         v53 = UnityEngine::Object::GetInstanceID((Object_1 *)v44, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v54 = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v44, 0LL);
			//         v86 = UnityEngine::Camera::get_cullingMask(v44, 0LL);
			//         v55 = UnityEngine::Camera::get_cameraType(v44, 0LL);
			//         memset(&v89, 0, sizeof(v89));
			//         v56 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, uint64_t, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, _DWORD, _DWORD, _DWORD, Vector3 *, JobHandle *, _DWORD, int))qword_18D92FA48;
			//         v93 = 0LL;
			//         if ( !qword_18D92FA48 )
			//         {
			//           v56 = (__int64 (__fastcall *)(Matrix4x4 *, _QWORD, uint64_t, _QWORD, _DWORD, _DWORD, LODCrossFadeConfig *, _DWORD, CameraType__Enum, _DWORD, _DWORD, _DWORD, Vector3 *, JobHandle *, _DWORD, int))sub_180017470("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByMatrix(UnityEngine.Matrix4x4&,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
			//           qword_18D92FA48 = (__int64)v56;
			//         }
			//         v43.fields.cullingViewHandle = v56(
			//                                           &v43.fields.mainViewConstants.cullingMatrix,
			//                                           v53,
			//                                           v54,
			//                                           v86,
			//                                           0,
			//                                           0,
			//                                           &v43.fields.lodCrossFadeConfig,
			//                                           0,
			//                                           v55,
			//                                           0,
			//                                           0,
			//                                           0,
			//                                           &v89,
			//                                           &v93,
			//                                           0,
			//                                           1028443341);
			//         goto LABEL_37;
			//       }
			//     }
			// LABEL_47:
			//     sub_180B536AC(v8, camera);
			//   }
			// LABEL_37:
			//   camera = this.fields.camera;
			//   v57 = this.fields.cullingViewHandle;
			//   if ( !camera )
			//     goto LABEL_47;
			//   v58 = UnityEngine::Camera::get_cameraToWorldMatrix(v94, camera, 0LL);
			//   v59 = *(_OWORD *)&v58.m01;
			//   *(_OWORD *)&v92.m00 = *(_OWORD *)&v58.m00;
			//   v60 = *(_OWORD *)&v58.m02;
			//   *(_OWORD *)&v92.m01 = v59;
			//   v61 = *(_OWORD *)&v58.m03;
			//   *(_OWORD *)&v92.m02 = v60;
			//   *(_OWORD *)&v92.m03 = v61;
			//   v62 = UnityEngine::Matrix4x4::GetPosition((Vector3 *)&v88, &v92, 0LL);
			//   v8 = (Object_1 *)this.fields.camera;
			//   v63 = *(_QWORD *)&v62.x;
			//   v64 = v62.z;
			//   if ( !v8 )
			//     goto LABEL_47;
			//   v65 = UnityEngine::Object::GetInstanceID(v8, 0LL);
			//   *(_QWORD *)&v87.x = v63;
			//   v87.z = v64;
			//   cullingResults.lightCullResult = *UnityEngine::HyperGryph::HGCullingSystem::CullLights(
			//                                        (LightCullResult *)&v88,
			//                                        v57,
			//                                        &v87,
			//                                        0x100u,
			//                                        v65,
			//                                        0LL);
			//   UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//   this.fields.cullingJobHandle = *UnityEngine::HyperGryph::HGCullingSystem::GetCullingViewFence(
			//                                      &v88,
			//                                      this.fields.cullingViewHandle,
			//                                      0LL);
			//   if ( UnityEngine::SystemInfo::SupportsRayTracing(0LL) )
			//   {
			//     this.fields.lodCrossFadeConfig.enableDither = 0;
			//     this.fields.lodCrossFadeConfig.lodBias = 0x80;
			//     v66 = this.fields.camera;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     v67 = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v66, 0LL);
			//     v69 = this.fields.camera;
			//     v70 = v67;
			//     if ( !v69 )
			//       sub_180B536AC(0LL, v68);
			//     v71 = UnityEngine::Camera::get_cullingMask(v69, 0LL);
			//     v72 = *(_OWORD *)&this.fields.lodCrossFadeConfig.c0.y;
			//     *(_OWORD *)&v92.m00 = *(_OWORD *)&this.fields.lodCrossFadeConfig.cameraPosition.x;
			//     v73 = *(_OWORD *)&this.fields.lodCrossFadeConfig.c1.z;
			//     *(_OWORD *)&v92.m01 = v72;
			//     *(_QWORD *)&v72 = *(_QWORD *)&this.fields.lodCrossFadeConfig.maxProjFactorSquared1;
			//     *(_OWORD *)&v92.m02 = v73;
			//     *(_QWORD *)&v92.m03 = v72;
			//     v74 = UnityEngine::HyperGryph::HGRayTracingScene::AddCullViewHandle(
			//             v70,
			//             v71,
			//             0,
			//             0,
			//             (LODCrossFadeConfig *)&v92,
			//             v21,
			//             300.0,
			//             0LL);
			//     this.fields.rayTracingCullingViewHandle = v74;
			//     this.fields.lodCrossFadeConfig.lodBias = 0;
			//     this.fields.rayTracingTLASHandle = UnityEngine::HyperGryph::HGRayTracingScene::PrepareTLASCreationForCullView(
			//                                           v74,
			//                                           0LL);
			//   }
			// }
			// 
		}

		internal void DoTerrainCulling(ScriptableRenderContext renderContext, HGRenderPipeline pipeline)
		{
			// // Void DoTerrainCulling(ScriptableRenderContext, HGRenderPipeline)
			// void HG::Rendering::Runtime::HGCamera::DoTerrainCulling(
			//         HGCamera *this,
			//         ScriptableRenderContext renderContext,
			//         HGRenderPipeline *pipeline,
			//         MethodInfo *method)
			// {
			//   _QWORD **terrainLODFactor_k__BackingField; // rcx
			//   __int64 v8; // rdx
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
			//   HGSettingParameters *settingParameters_k__BackingField; // rax
			//   int v11; // eax
			//   Camera *camera; // r12
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   void (__fastcall *v14)(Camera *, __int128 *, HGRenderPipeline *, MethodInfo *); // rax
			//   Transform *currentPlayerCenter; // r15
			//   bool v16; // zf
			//   Transform *v17; // r15
			//   void (__fastcall *v18)(Transform *, __int64 *); // rax
			//   __int64 (__fastcall *v19)(Camera *, Vector2Int *, _OWORD *); // rax
			//   Vector2Int v20; // rbx
			//   Camera *v21; // r15
			//   void (__fastcall *v22)(Camera *, __int128 *); // rax
			//   Transform *v23; // r15
			//   Transform *v24; // r14
			//   void (__fastcall *v25)(Transform *, __int64 *); // rax
			//   __int64 (__fastcall *v26)(Camera *, Vector2Int *, _OWORD *); // rax
			//   Camera *v27; // r15
			//   __int64 (__fastcall *v28)(Camera *); // rax
			//   Camera *v29; // r14
			//   __int64 (__fastcall *v30)(Camera *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v32; // rax
			//   __int64 v33; // rax
			//   __int64 v34; // rax
			//   __int64 v35; // rax
			//   __int64 v36; // rax
			//   __int64 v37; // rax
			//   __int64 v38; // rax
			//   __int64 v39; // rax
			//   __int64 v40; // rax
			//   __int64 v41; // [rsp+50h] [rbp-B0h] BYREF
			//   int v42; // [rsp+58h] [rbp-A8h]
			//   int v43; // [rsp+60h] [rbp-A0h]
			//   Camera *v44; // [rsp+68h] [rbp-98h]
			//   Vector2Int v45; // [rsp+70h] [rbp-90h] BYREF
			//   __int128 v46; // [rsp+78h] [rbp-88h] BYREF
			//   __int128 v47; // [rsp+88h] [rbp-78h]
			//   __int128 v48; // [rsp+98h] [rbp-68h]
			//   __int128 v49; // [rsp+A8h] [rbp-58h]
			//   __int64 v50; // [rsp+C0h] [rbp-40h]
			//   int v51; // [rsp+C8h] [rbp-38h]
			//   __int64 v52; // [rsp+D0h] [rbp-30h]
			//   int v53; // [rsp+D8h] [rbp-28h]
			//   _OWORD v54[4]; // [rsp+E0h] [rbp-20h] BYREF
			//   _OWORD v55[4]; // [rsp+120h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDA13 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::get_paramValue);
			//     byte_18D8EDA13 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, renderContext.m_Ptr);
			//     terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *terrainLODFactor_k__BackingField[23];
			//   if ( !v8 )
			//     goto LABEL_74;
			//   if ( *(int *)(v8 + 24) > 795 )
			//   {
			//     if ( !*((_DWORD *)terrainLODFactor_k__BackingField + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(terrainLODFactor_k__BackingField, v8);
			//       terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v8 = *terrainLODFactor_k__BackingField[23];
			//     if ( !v8 )
			//       goto LABEL_74;
			//     if ( *(_DWORD *)(v8 + 24) <= 0x31Bu )
			//       goto LABEL_94;
			//     if ( *(_QWORD *)(v8 + 6392) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(795, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, renderContext, (Object *)pipeline, 0LL);
			//         return;
			//       }
			//       goto LABEL_74;
			//     }
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !*((_DWORD *)terrainLODFactor_k__BackingField + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainLODFactor_k__BackingField, v8);
			//     terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *terrainLODFactor_k__BackingField[23];
			//   if ( !v8 )
			//     goto LABEL_74;
			//   if ( *(int *)(v8 + 24) <= 727 )
			//     goto LABEL_15;
			//   if ( !*((_DWORD *)terrainLODFactor_k__BackingField + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(terrainLODFactor_k__BackingField, v8);
			//     terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   terrainLODFactor_k__BackingField = (_QWORD **)*terrainLODFactor_k__BackingField[23];
			//   if ( !terrainLODFactor_k__BackingField )
			//     goto LABEL_74;
			//   if ( *((_DWORD *)terrainLODFactor_k__BackingField + 6) <= 0x2D7u )
			// LABEL_94:
			//     sub_180070270(terrainLODFactor_k__BackingField, v8);
			//   if ( !terrainLODFactor_k__BackingField[731] )
			//   {
			// LABEL_15:
			//     m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
			//     if ( !m_AdditionalCameraData )
			//       goto LABEL_74;
			//     if ( m_AdditionalCameraData.fields.hgRenderPath == 1 || m_AdditionalCameraData.fields.hgRenderPath == 2 )
			//       return;
			//     goto LABEL_18;
			//   }
			//   v32 = IFix::WrappersManagerImpl::GetPatch(727, 0LL);
			//   if ( !v32 )
			//     goto LABEL_74;
			//   if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v32, (Object *)this, 0LL) )
			//     return;
			// LABEL_18:
			//   if ( !pipeline )
			//     goto LABEL_74;
			//   settingParameters_k__BackingField = pipeline.fields._settingParameters_k__BackingField;
			//   if ( !settingParameters_k__BackingField )
			//     goto LABEL_74;
			//   terrainLODFactor_k__BackingField = (_QWORD **)settingParameters_k__BackingField.fields._terrainLODFactor_k__BackingField;
			//   if ( !terrainLODFactor_k__BackingField )
			//     goto LABEL_74;
			//   v11 = *((_DWORD *)terrainLODFactor_k__BackingField + 10);
			//   terrainLODFactor_k__BackingField = 0LL;
			//   *(_QWORD *)&this.fields.vtFeedbackViewId = 0LL;
			//   v43 = v11;
			//   if ( !pipeline.fields.needRenderTerrain )
			//   {
			//     *(_QWORD *)&this.fields.terrainCullViewHandle = 0LL;
			//     return;
			//   }
			//   camera = this.fields.camera;
			//   sceneRTSize_k__BackingField = this.fields._sceneRTSize_k__BackingField;
			//   if ( !camera )
			//     goto LABEL_74;
			//   v14 = (void (__fastcall *)(Camera *, __int128 *, HGRenderPipeline *, MethodInfo *))qword_18D8F42B8;
			//   v46 = 0LL;
			//   v47 = 0LL;
			//   v48 = 0LL;
			//   v49 = 0LL;
			//   if ( !qword_18D8F42B8 )
			//   {
			//     v14 = (void (__fastcall *)(Camera *, __int128 *, HGRenderPipeline *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                          "UnityEngine.Camera::get_culling"
			//                                                                                          "Matrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v14 )
			//     {
			//       v33 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v33, 0LL);
			//     }
			//     qword_18D8F42B8 = (__int64)v14;
			//   }
			//   v14(camera, &v46, pipeline, method);
			//   if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, v8);
			//   currentPlayerCenter = pipeline.fields.currentPlayerCenter;
			//   v16 = TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor == 0;
			//   LODWORD(v44) = this.fields.vtFeedbackViewId;
			//   if ( v16 )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( currentPlayerCenter )
			//   {
			//     terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( currentPlayerCenter.fields._._.m_CachedPtr )
			//     {
			//       v17 = pipeline.fields.currentPlayerCenter;
			//       if ( !v17 )
			//         goto LABEL_74;
			//       v41 = 0LL;
			//       v42 = 0;
			//       v18 = (void (__fastcall *)(Transform *, __int64 *))qword_18D8F52E0;
			//       if ( qword_18D8F52E0 )
			//         goto LABEL_40;
			//       v18 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_0(
			//                                                            "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       if ( !v18 )
			//       {
			//         v34 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v34, 0LL);
			//       }
			// LABEL_103:
			//       qword_18D8F52E0 = (__int64)v18;
			//       goto LABEL_40;
			//     }
			//   }
			//   v27 = this.fields.camera;
			//   if ( !v27 )
			//     goto LABEL_74;
			//   v28 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v28 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Component::get_transform()");
			//     qword_18D8F4D40 = (__int64)v28;
			//   }
			//   v17 = (Transform *)v28(v27);
			//   if ( !v17 )
			//     goto LABEL_74;
			//   v41 = 0LL;
			//   v42 = 0;
			//   v18 = (void (__fastcall *)(Transform *, __int64 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v18 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v18 )
			//     {
			//       v35 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v35, 0LL);
			//     }
			//     goto LABEL_103;
			//   }
			// LABEL_40:
			//   v18(v17, &v41);
			//   v51 = v42;
			//   v19 = (__int64 (__fastcall *)(Camera *, Vector2Int *, _OWORD *))qword_18D8F5C90;
			//   v50 = v41;
			//   v54[1] = v47;
			//   v45 = sceneRTSize_k__BackingField;
			//   v54[0] = v46;
			//   v54[3] = v49;
			//   v54[2] = v48;
			//   if ( !qword_18D8F5C90 )
			//   {
			//     v19 = (__int64 (__fastcall *)(Camera *, Vector2Int *, _OWORD *))il2cpp_resolve_icall_0(
			//                                                                       "UnityEngine.HyperGryph.HGTerrainManager::CullTerra"
			//                                                                       "inAndUpdateVTFeedbackView_Injected(UnityEngine.Cam"
			//                                                                       "era,UnityEngine.Vector2Int&,UnityEngine.Matrix4x4&"
			//                                                                       ",System.Single,System.Boolean,System.IntPtr,System"
			//                                                                       ".UInt32,System.Int32,UnityEngine.Vector3&)");
			//     if ( !v19 )
			//     {
			//       v36 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGTerrainManager::CullTerrainAndUpdateVTFeedbackView_Injected(UnityEngine.Camera,Un"
			//               "ityEngine.Vector2Int&,UnityEngine.Matrix4x4&,System.Single,System.Boolean,System.IntPtr,System.UInt32,Syst"
			//               "em.Int32,UnityEngine.Vector3&)");
			//       sub_18000F750(v36, 0LL);
			//     }
			//     qword_18D8F5C90 = (__int64)v19;
			//   }
			//   this.fields.terrainCullViewHandle = v19(camera, &v45, v54);
			//   v20 = this.fields._sceneRTSize_k__BackingField;
			//   v44 = this.fields.camera;
			//   v21 = v44;
			//   if ( !v44 )
			//     goto LABEL_74;
			//   v22 = (void (__fastcall *)(Camera *, __int128 *))qword_18D8F42B8;
			//   v46 = 0LL;
			//   v47 = 0LL;
			//   v48 = 0LL;
			//   v49 = 0LL;
			//   if ( !qword_18D8F42B8 )
			//   {
			//     v22 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v22 )
			//     {
			//       v37 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v37, 0LL);
			//     }
			//     qword_18D8F42B8 = (__int64)v22;
			//   }
			//   v22(v21, &v46);
			//   if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, v8);
			//   v23 = pipeline.fields.currentPlayerCenter;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v23 )
			//     goto LABEL_68;
			//   terrainLODFactor_k__BackingField = (_QWORD **)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !v23.fields._._.m_CachedPtr )
			//   {
			// LABEL_68:
			//     v29 = this.fields.camera;
			//     if ( v29 )
			//     {
			//       v30 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v30 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Component::get_transform()");
			//         qword_18D8F4D40 = (__int64)v30;
			//       }
			//       v24 = (Transform *)v30(v29);
			//       if ( v24 )
			//       {
			//         v41 = 0LL;
			//         v42 = 0;
			//         v25 = (void (__fastcall *)(Transform *, __int64 *))qword_18D8F52E0;
			//         if ( qword_18D8F52E0 )
			//           goto LABEL_59;
			//         v25 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_0(
			//                                                              "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         if ( !v25 )
			//         {
			//           v39 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           sub_18000F750(v39, 0LL);
			//         }
			// LABEL_112:
			//         qword_18D8F52E0 = (__int64)v25;
			//         goto LABEL_59;
			//       }
			//     }
			// LABEL_74:
			//     sub_180B536AC(terrainLODFactor_k__BackingField, v8);
			//   }
			//   v24 = pipeline.fields.currentPlayerCenter;
			//   if ( !v24 )
			//     goto LABEL_74;
			//   v41 = 0LL;
			//   v42 = 0;
			//   v25 = (void (__fastcall *)(Transform *, __int64 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v25 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v25 )
			//     {
			//       v38 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v38, 0LL);
			//     }
			//     goto LABEL_112;
			//   }
			// LABEL_59:
			//   v25(v24, &v41);
			//   v53 = v42;
			//   v26 = (__int64 (__fastcall *)(Camera *, Vector2Int *, _OWORD *))qword_18D8F5CA0;
			//   v52 = v41;
			//   v55[1] = v47;
			//   v45 = v20;
			//   v55[0] = v46;
			//   v55[3] = v49;
			//   v55[2] = v48;
			//   if ( !qword_18D8F5CA0 )
			//   {
			//     v26 = (__int64 (__fastcall *)(Camera *, Vector2Int *, _OWORD *))il2cpp_resolve_icall_0(
			//                                                                       "UnityEngine.HyperGryph.HGEditorTerrainManager::Cul"
			//                                                                       "lTerrainAndUpdateVTFeedbackView_Injected(UnityEngi"
			//                                                                       "ne.Camera,UnityEngine.Vector2Int&,UnityEngine.Matr"
			//                                                                       "ix4x4&,System.Single,System.Boolean,System.IntPtr,"
			//                                                                       "System.UInt32,System.Int32,UnityEngine.Vector3&)");
			//     if ( !v26 )
			//     {
			//       v40 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGEditorTerrainManager::CullTerrainAndUpdateVTFeedbackView_Injected(UnityEngine.Cam"
			//               "era,UnityEngine.Vector2Int&,UnityEngine.Matrix4x4&,System.Single,System.Boolean,System.IntPtr,System.UInt3"
			//               "2,System.Int32,UnityEngine.Vector3&)");
			//       sub_18000F750(v40, 0LL);
			//     }
			//     qword_18D8F5CA0 = (__int64)v26;
			//   }
			//   this.fields.editorTerrainCullViewHandle = v26(v44, &v45, v55);
			// }
			// 
		}

		internal void DoWaterCulling(bool useAnchorSH)
		{
			// // Void DoWaterCulling(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGCamera::DoWaterCulling(HGCamera *this, bool useAnchorSH, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Camera *camera; // r14
			//   uint32_t cullingViewHandle; // r15d
			//   __int64 (__fastcall *v9)(Camera *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   __int64 v10; // r14
			//   void (__fastcall *v11)(__int64, __int64 *); // rax
			//   __int64 v12; // r9
			//   void (__fastcall *v13)(_QWORD, _OWORD *, __int64, __int64, uint32_t *, uint32_t *, char, __int64 *); // rax
			//   void (__fastcall *v14)(_QWORD, _OWORD *, uint32_t *, uint32_t *, int); // rax
			//   uint32_t v15; // edi
			//   __int128 v16; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rax
			//   __int64 v19; // rax
			//   __int64 v20; // rax
			//   __int64 v21; // rax
			//   int v22; // [rsp+20h] [rbp-118h]
			//   __int64 v23; // [rsp+40h] [rbp-F8h] BYREF
			//   int v24; // [rsp+48h] [rbp-F0h]
			//   __int64 v25; // [rsp+50h] [rbp-E8h] BYREF
			//   int v26; // [rsp+58h] [rbp-E0h]
			//   __int128 v27; // [rsp+60h] [rbp-D8h]
			//   __int128 v28; // [rsp+70h] [rbp-C8h]
			//   __int128 v29; // [rsp+80h] [rbp-B8h]
			//   __int128 v30; // [rsp+90h] [rbp-A8h]
			//   _OWORD v31[4]; // [rsp+A0h] [rbp-98h] BYREF
			//   _OWORD v32[4]; // [rsp+E0h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, useAnchorSH);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size > 798 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( !v5 )
			//       goto LABEL_16;
			//     if ( LODWORD(v5._0.namespaze) <= 0x31E )
			//       sub_180070270(v5, wrapperArray);
			//     if ( v5[17]._0.namespaze )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(798, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//           (ILFixDynamicMethodWrapper_28 *)Patch,
			//           (Object *)this,
			//           useAnchorSH,
			//           0LL);
			//         return;
			//       }
			// LABEL_16:
			//       sub_180B536AC(v5, wrapperArray);
			//     }
			//   }
			//   if ( this.fields.cullingViewHandle == -1 )
			//   {
			//     this.fields.waterProxyCullHandle = -1;
			//     this.fields.waterProxyVisibleCount = 0;
			//     this.fields.waterDecalVisibleCount = 0;
			//     this.fields.waterDecalCullHandle = -1;
			//     return;
			//   }
			//   camera = this.fields.camera;
			//   cullingViewHandle = this.fields.cullingViewHandle;
			//   v27 = *(_OWORD *)&this.fields.waterCullingMatrix.m00;
			//   v28 = *(_OWORD *)&this.fields.waterCullingMatrix.m01;
			//   v29 = *(_OWORD *)&this.fields.waterCullingMatrix.m02;
			//   v30 = *(_OWORD *)&this.fields.waterCullingMatrix.m03;
			//   if ( !camera )
			//     goto LABEL_16;
			//   v9 = (__int64 (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v9 = (__int64 (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                                  "UnityEngine.Component::get_transform()");
			//     if ( !v9 )
			//     {
			//       v18 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v18, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v9;
			//   }
			//   v10 = v9(camera, wrapperArray, method);
			//   if ( !v10 )
			//     goto LABEL_16;
			//   v23 = 0LL;
			//   v24 = 0;
			//   v11 = (void (__fastcall *)(__int64, __int64 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v11 = (void (__fastcall *)(__int64, __int64 *))il2cpp_resolve_icall_0(
			//                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v11 )
			//     {
			//       v19 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v19, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v11;
			//   }
			//   v11(v10, &v23);
			//   v25 = v23;
			//   v26 = v24;
			//   v13 = (void (__fastcall *)(_QWORD, _OWORD *, __int64, __int64, uint32_t *, uint32_t *, char, __int64 *))qword_18D8F5CD8;
			//   v31[0] = v27;
			//   v31[1] = v28;
			//   v31[2] = v29;
			//   v31[3] = v30;
			//   if ( !qword_18D8F5CD8 )
			//   {
			//     v13 = (void (__fastcall *)(_QWORD, _OWORD *, __int64, __int64, uint32_t *, uint32_t *, char, __int64 *))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGWaterRender::CullWaterProxy_Injected(System.UInt32,UnityEngine.Matrix4x4&,System.UInt32,System.Boolean,System.UInt32&,System.UInt32&,System.Boolean,UnityEngine.Vector3&)");
			//     if ( !v13 )
			//     {
			//       v20 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGWaterRender::CullWaterProxy_Injected(System.UInt32,UnityEngine.Matrix4x4&,System."
			//               "UInt32,System.Boolean,System.UInt32&,System.UInt32&,System.Boolean,UnityEngine.Vector3&)");
			//       sub_18000F750(v20, 0LL);
			//     }
			//     qword_18D8F5CD8 = (__int64)v13;
			//   }
			//   LOBYTE(v12) = 1;
			//   v13(
			//     cullingViewHandle,
			//     v31,
			//     3LL,
			//     v12,
			//     &this.fields.waterProxyVisibleCount,
			//     &this.fields.waterProxyCullHandle,
			//     1,
			//     &v25);
			//   v14 = (void (__fastcall *)(_QWORD, _OWORD *, uint32_t *, uint32_t *, int))qword_18D8F5CE0;
			//   v15 = this.fields.cullingViewHandle;
			//   v32[0] = *(_OWORD *)&this.fields.waterCullingMatrix.m00;
			//   v16 = *(_OWORD *)&this.fields.waterCullingMatrix.m02;
			//   v32[1] = *(_OWORD *)&this.fields.waterCullingMatrix.m01;
			//   v32[2] = v16;
			//   v32[3] = *(_OWORD *)&this.fields.waterCullingMatrix.m03;
			//   if ( !qword_18D8F5CE0 )
			//   {
			//     v14 = (void (__fastcall *)(_QWORD, _OWORD *, uint32_t *, uint32_t *, int))il2cpp_resolve_icall_0(
			//                                                                                 "UnityEngine.HyperGryph.HGWaterRender::Cu"
			//                                                                                 "llWaterDecals_Injected(System.UInt32,Uni"
			//                                                                                 "tyEngine.Matrix4x4&,System.UInt32&,Syste"
			//                                                                                 "m.UInt32&,System.Boolean)");
			//     if ( !v14 )
			//     {
			//       v21 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGWaterRender::CullWaterDecals_Injected(System.UInt32,UnityEngine.Matrix4x4&,System"
			//               ".UInt32&,System.UInt32&,System.Boolean)");
			//       sub_18000F750(v21, 0LL);
			//     }
			//     qword_18D8F5CE0 = (__int64)v14;
			//   }
			//   LOBYTE(v22) = useAnchorSH;
			//   v14(v15, v32, &this.fields.waterDecalVisibleCount, &this.fields.waterDecalCullHandle, v22);
			// }
			// 
		}

		internal void ReflectionProbeUpdate(int octTextureSize, int textureArrayCount, bool reflectionProbeUseRGBAHalf, bool renderGraphEnableCppRenderPath)
		{
			// // Void ReflectionProbeUpdate(Int32, Int32, Boolean, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGCamera::ReflectionProbeUpdate(
			//         HGCamera *this,
			//         int32_t octTextureSize,
			//         int32_t textureArrayCount,
			//         bool reflectionProbeUseRGBAHalf,
			//         bool renderGraphEnableCppRenderPath,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *QUALITY_VISIBLE_COUNT; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct ReflectionProbeBinningPassSetting__Class *v12; // rax
			//   int32_t v13; // eax
			//   int32_t v14; // esi
			//   bool v15; // al
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v17)(Camera *); // rax
			//   __int64 v18; // rdi
			//   void (__fastcall *v19)(__int64, __int64 *); // rax
			//   __int64 v20; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v21; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v22; // rdx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   uint32_t reflectionProbeViewHandle; // ebx
			//   void (__fastcall *v26)(_QWORD, __int64 *, __int64 *, _QWORD); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v28; // rax
			//   __int64 v29; // rax
			//   ILFixDynamicMethodWrapper_2 *v30; // rax
			//   __int64 v31; // rax
			//   __int64 v32; // [rsp+40h] [rbp-38h] BYREF
			//   int v33; // [rsp+48h] [rbp-30h]
			//   __int64 v34; // [rsp+50h] [rbp-28h] BYREF
			//   float z; // [rsp+58h] [rbp-20h]
			//   __int64 v36; // [rsp+60h] [rbp-18h] BYREF
			//   int v37; // [rsp+68h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDA14 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting);
			//     byte_18D8EDA14 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   QUALITY_VISIBLE_COUNT = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&octTextureSize);
			//     QUALITY_VISIBLE_COUNT = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = QUALITY_VISIBLE_COUNT.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_48;
			//   if ( wrapperArray.max_length.size <= 802 )
			//     goto LABEL_9;
			//   if ( !QUALITY_VISIBLE_COUNT._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(QUALITY_VISIBLE_COUNT, wrapperArray);
			//     QUALITY_VISIBLE_COUNT = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   QUALITY_VISIBLE_COUNT = (struct ILFixDynamicMethodWrapper_2__Class *)QUALITY_VISIBLE_COUNT.static_fields.wrapperArray;
			//   if ( !QUALITY_VISIBLE_COUNT )
			// LABEL_48:
			//     sub_180B536AC(QUALITY_VISIBLE_COUNT, wrapperArray);
			//   if ( LODWORD(QUALITY_VISIBLE_COUNT._0.namespaze) <= 0x322 )
			//     sub_180070270(QUALITY_VISIBLE_COUNT, wrapperArray);
			//   if ( *((_QWORD *)&QUALITY_VISIBLE_COUNT[17]._0.this_arg + 1) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(802, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_304(
			//         Patch,
			//         (Object *)this,
			//         octTextureSize,
			//         textureArrayCount,
			//         reflectionProbeUseRGBAHalf,
			//         renderGraphEnableCppRenderPath,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_48;
			//   }
			// LABEL_9:
			//   if ( !this.fields.reflectionProbeViewHandle )
			//     this.fields.reflectionProbeViewHandle = UnityEngine::HyperGryph::HGReflectionProbe::AddView(
			//                                                this.fields.camera,
			//                                                0LL);
			//   v12 = TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting;
			//   if ( !TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting, wrapperArray);
			//     v12 = TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassSetting;
			//   }
			//   QUALITY_VISIBLE_COUNT = (struct ILFixDynamicMethodWrapper_2__Class *)v12.static_fields.QUALITY_VISIBLE_COUNT;
			//   v13 = 32;
			//   if ( (int)QUALITY_VISIBLE_COUNT < 32 )
			//     v13 = (int)QUALITY_VISIBLE_COUNT;
			//   if ( textureArrayCount < 1 )
			//   {
			//     textureArrayCount = 1;
			//   }
			//   else if ( textureArrayCount > v13 )
			//   {
			//     textureArrayCount = v13;
			//   }
			//   if ( reflectionProbeUseRGBAHalf )
			//     v14 = 48;
			//   else
			//     v14 = 74;
			//   if ( octTextureSize == this.fields.reflectionProbeOctTextureSize
			//     && v14 == this.fields.reflectionProbeOctTextureFormat
			//     && this.fields.preivousEnableCppRenderPath == renderGraphEnableCppRenderPath
			//     && textureArrayCount == this.fields.reflectionProbeOctTextureArrayCount )
			//   {
			//     v15 = 0;
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGReflectionProbe::SetViewTextureArrayCount(
			//       this.fields.reflectionProbeViewHandle,
			//       textureArrayCount,
			//       0LL);
			//     UnityEngine::HyperGryph::HGReflectionProbe::ResetView(this.fields.reflectionProbeViewHandle, 0LL);
			//     v15 = 1;
			//     this.fields.reflectionProbeOctTextureSize = octTextureSize;
			//     this.fields.reflectionProbeOctTextureFormat = v14;
			//     this.fields.reflectionProbeOctTextureArrayCount = textureArrayCount;
			//   }
			//   this.fields.reflectionProbeReset = v15;
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_48;
			//   v17 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v17 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v17 )
			//     {
			//       v28 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v28, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v17;
			//   }
			//   v18 = v17(camera);
			//   if ( !v18 )
			//     goto LABEL_48;
			//   v32 = 0LL;
			//   v33 = 0;
			//   v19 = (void (__fastcall *)(__int64, __int64 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v19 = (void (__fastcall *)(__int64, __int64 *))il2cpp_resolve_icall_0(
			//                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v19 )
			//     {
			//       v29 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v29, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v19;
			//   }
			//   v19(v18, &v32);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v20);
			//   if ( !byte_18D8EDC5D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC5D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v21 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v20);
			//     v21 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v22 = v21.static_fields.wrapperArray;
			//   if ( !v22 )
			//     goto LABEL_47;
			//   if ( v22.max_length.size > 439 )
			//   {
			//     if ( !v21._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v21, v22);
			//       v21 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v21 = (struct ILFixDynamicMethodWrapper_2__Class *)v21.static_fields.wrapperArray;
			//     if ( v21 )
			//     {
			//       if ( LODWORD(v21._0.namespaze) <= 0x1B7 )
			//         sub_180070270(v21, v22);
			//       if ( !v21[9]._0.nestedTypes )
			//         goto LABEL_39;
			//       v30 = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
			//       if ( v30 )
			//       {
			//         m_interpolatedPhase = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(v30, (Object *)this, 0LL);
			//         goto LABEL_42;
			//       }
			//     }
			// LABEL_47:
			//     sub_180B536AC(v21, v22);
			//   }
			// LABEL_39:
			//   m_envVolumeCameraComponent = this.fields.m_envVolumeCameraComponent;
			//   if ( !m_envVolumeCameraComponent )
			//     goto LABEL_47;
			//   if ( m_envVolumeCameraComponent.fields.m_useEnvVolumeInterpolatedPhase )
			//   {
			//     m_interpolatedPhase = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v22);
			//     m_interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
			//   }
			// LABEL_42:
			//   if ( !m_interpolatedPhase )
			//     goto LABEL_47;
			//   reflectionProbeViewHandle = this.fields.reflectionProbeViewHandle;
			//   v34 = *(_QWORD *)&m_interpolatedPhase.fields.skyConfig.visibleBox.x;
			//   z = m_interpolatedPhase.fields.skyConfig.visibleBox.z;
			//   v37 = v33;
			//   v26 = (void (__fastcall *)(_QWORD, __int64 *, __int64 *, _QWORD))qword_18D8F5B80;
			//   v36 = v32;
			//   if ( !qword_18D8F5B80 )
			//   {
			//     v26 = (void (__fastcall *)(_QWORD, __int64 *, __int64 *, _QWORD))il2cpp_resolve_icall_0(
			//                                                                        "UnityEngine.HyperGryph.HGReflectionProbe::UpdateV"
			//                                                                        "iewPhase0_Injected(System.UInt32,UnityEngine.Vect"
			//                                                                        "or3&,UnityEngine.Vector3&,System.Boolean)");
			//     if ( !v26 )
			//     {
			//       v31 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGReflectionProbe::UpdateViewPhase0_Injected(System.UInt32,UnityEngine.Vector3&,Uni"
			//               "tyEngine.Vector3&,System.Boolean)");
			//       sub_18000F750(v31, 0LL);
			//     }
			//     qword_18D8F5B80 = (__int64)v26;
			//   }
			//   v26(reflectionProbeViewHandle, &v36, &v34, 0LL);
			// }
			// 
		}

		internal bool ShouldRenderWater()
		{
			// // Boolean ShouldRenderWater()
			// bool HG::Rendering::Runtime::HGCamera::ShouldRenderWater(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   HGWaterManager *static_fields; // rcx
			//   HGWaterManager__Class *klass; // rdx
			//   HGManagerContext *currentManagerContext; // rax
			//   bool v7; // di
			//   Camera *camera; // rbx
			//   __int64 (__fastcall *v9)(Camera *); // rax
			//   char v10; // al
			//   bool v11; // dl
			//   HGWaterManager__Class *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rax
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
			//   static_fields = (HGWaterManager *)v3.static_fields;
			//   klass = static_fields.klass;
			//   if ( !static_fields.klass )
			//     goto LABEL_17;
			//   if ( SLODWORD(klass._0.namespaze) <= 927 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, klass);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (HGWaterManager *)v3.static_fields;
			//   v13 = static_fields.klass;
			//   if ( !static_fields.klass )
			// LABEL_17:
			//     sub_180B536AC(static_fields, klass);
			//   if ( LODWORD(v13._0.namespaze) <= 0x39F )
			//     sub_180070270(static_fields, klass);
			//   if ( *(_QWORD *)&v13[19]._1.naturalAligment )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(927, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_17;
			//   }
			// LABEL_7:
			//   currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//   if ( !currentManagerContext )
			//     goto LABEL_17;
			//   static_fields = currentManagerContext.fields._waterManager_k__BackingField;
			//   if ( !static_fields )
			//     goto LABEL_17;
			//   v7 = HG::Rendering::Runtime::HGWaterManager::get_shouldRender(static_fields, 0LL)
			//     && this.fields.waterProxyVisibleCount != 0;
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_17;
			//   v9 = (__int64 (__fastcall *)(Camera *))qword_18D8F41C8;
			//   if ( !qword_18D8F41C8 )
			//   {
			//     v9 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//     if ( !v9 )
			//     {
			//       v15 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//       sub_18000F750(v15, 0LL);
			//     }
			//     qword_18D8F41C8 = (__int64)v9;
			//   }
			//   v10 = v9(camera);
			//   v11 = 0;
			//   if ( !v10 )
			//     return v7;
			//   return v11;
			// }
			// 
			return default(bool);
		}

		internal bool ShouldRenderWaterUnlit()
		{
			// // Boolean ShouldRenderWaterUnlit()
			// bool HG::Rendering::Runtime::HGCamera::ShouldRenderWaterUnlit(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 957 )
			//     return 0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x3BDu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[26].vector[21] )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(957, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		internal void Update(FrameSettings currentFrameSettings, HGRenderPipeline hgrp, [MetadataOffset(Offset = "0x01F9148C")] bool allocateHistoryBuffers = true)
		{
			// // Void Update(FrameSettings, HGRenderPipeline, Boolean)
			// void HG::Rendering::Runtime::HGCamera::Update(
			//         HGCamera *this,
			//         FrameSettings *currentFrameSettings,
			//         HGRenderPipeline *hgrp,
			//         bool allocateHistoryBuffers,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r13
			//   Object *v9; // r12
			//   __int64 monitor; // rcx
			//   Camera *v11; // rdx
			//   Camera *m_parentCamera; // rbx
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
			//   HGRenderPath__Enum hgRenderPath; // ebx
			//   __int64 v15; // rdx
			//   HGRenderPathInternal__Enum InternalRenderPath; // ebx
			//   struct ILFixDynamicMethodWrapper_2__Class *v17; // rcx
			//   HGRenderPathBase *wrapperArray; // rdx
			//   struct HGRenderPipeline__Class *v19; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v20; // rax
			//   Camera *camera; // rbx
			//   __int64 (__fastcall *v22)(Camera *); // rax
			//   Camera *v23; // r15
			//   HGCamera *v24; // r14
			//   HGCamera *v25; // rax
			//   HGAdditionalCameraData *v26; // rax
			//   HGRenderPath__Enum v27; // ebx
			//   __int64 v28; // rdx
			//   HGRenderPathInternal__Enum v29; // ebx
			//   struct ILFixDynamicMethodWrapper_2__Class *v30; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *renderPathInstance_k__BackingField; // rdx
			//   struct HGRenderPipeline__Class *v32; // rcx
			//   HGRenderPipeline_HGResolutionSettings *v33; // rax
			//   HGAdditionalCameraData *v34; // rbx
			//   HGAdditionalCameraData *v35; // rax
			//   float materialMipBias; // xmm0_4
			//   __int64 v37; // xmm1_8
			//   __int64 v38; // rdx
			//   bool v39; // zf
			//   Rect value; // xmm2
			//   __m128 v41; // xmm7
			//   __m128 v42; // xmm7
			//   __m128 v43; // xmm7
			//   __m128 v44; // xmm7
			//   float v45; // xmm6_4
			//   int32_t v46; // ecx
			//   int32_t m_Height; // ecx
			//   __int64 v48; // rax
			//   Vector2Int v49; // rdi
			//   Camera *v50; // rbx
			//   unsigned int (__fastcall *v51)(Camera *); // rax
			//   __int64 v52; // rax
			//   __int64 v53; // r13
			//   OneofDescriptor__Class *klass; // rbx
			//   float globalMipBias_k__BackingField; // xmm6_4
			//   __int64 v56; // r12
			//   float v57; // xmm1_4
			//   __int64 v58; // rax
			//   float lowResScale; // xmm6_4
			//   __int64 v60; // rbx
			//   float v61; // xmm0_4
			//   __int64 v62; // rdx
			//   HGSettingParameters *v63; // rbx
			//   int32_t actualHeight_k__BackingField; // eax
			//   __int64 klass_low; // rdx
			//   OneofDescriptor__Class *v66; // rax
			//   __m128 v67; // xmm4
			//   __m128 v68; // xmm4
			//   __m128 v69; // xmm4
			//   int32_t v70; // eax
			//   __int64 v71; // rdx
			//   __int64 v72; // rcx
			//   int32_t actualWidth_k__BackingField; // ebx
			//   int32_t v74; // eax
			//   int32_t v75; // ecx
			//   signed int v76; // ebx
			//   OneofDescriptor__Class *v77; // rax
			//   __m128 v78; // xmm4
			//   __m128 v79; // xmm4
			//   __m128 v80; // xmm4
			//   void (__fastcall *v81)(Camera *, OneofDescriptor__Fields *); // rax
			//   Vector4 taauRTSizeParam_k__BackingField; // xmm0
			//   Vector4 sceneRTSizeParam_k__BackingField; // xmm0
			//   void (__fastcall *v84)(Camera *, OneofDescriptor__Fields *); // rax
			//   __int64 v85; // rdx
			//   void (__fastcall *v86)(OneofDescriptor__Fields *, __int64, OneofDescriptor__Fields *); // rax
			//   void (__fastcall *v87)(Camera *, OneofDescriptor__Fields *); // rax
			//   void (__fastcall *v88)(Camera *, OneofDescriptor__Fields *); // rax
			//   __int128 v89; // xmm1
			//   __int128 v90; // xmm0
			//   __int128 v91; // xmm1
			//   void (__fastcall *v92)(OneofDescriptor__Fields *, OneofDescriptor__Fields *); // rax
			//   __int128 v93; // xmm6
			//   void (__fastcall *v94)(OneofDescriptor__Fields *, OneofDescriptor__Fields *); // rax
			//   __int128 v95; // xmm8
			//   __int128 v96; // xmm9
			//   __int128 v97; // xmm10
			//   __int128 v98; // xmm1
			//   __int128 v99; // xmm0
			//   __int128 v100; // xmm1
			//   void (__fastcall *v101)(Camera *, OneofDescriptor__Fields *); // rax
			//   __int128 v102; // xmm1
			//   __int128 v103; // xmm0
			//   __int128 v104; // xmm1
			//   void (__fastcall *v105)(OneofDescriptor__Fields *, OneofDescriptor__Fields *, OneofDescriptor__Fields *); // rax
			//   void (__fastcall *v106)(Matrix4x4 *, OneofDescriptor__Fields *, OneofDescriptor__Fields *); // rax
			//   __int128 v107; // xmm1
			//   __int128 v108; // xmm0
			//   __int128 v109; // xmm1
			//   void (__fastcall *v110)(OneofDescriptor__Fields *, OneofDescriptor__Fields *); // rax
			//   __int128 v111; // xmm1
			//   __int128 v112; // xmm0
			//   __int128 v113; // xmm1
			//   __int128 v114; // xmm1
			//   __int128 v115; // xmm1
			//   __int64 (__fastcall *v116)(Camera *); // rax
			//   __int128 v117; // xmm1
			//   __int128 v118; // xmm0
			//   __int128 v119; // xmm1
			//   __int128 v120; // xmm1
			//   __int128 v121; // xmm2
			//   __int128 v122; // xmm3
			//   __int128 v123; // xmm1
			//   __int128 v124; // xmm2
			//   __int128 v125; // xmm3
			//   __int128 v126; // xmm1
			//   __int128 v127; // xmm2
			//   __int128 v128; // xmm3
			//   __int64 v129; // rbx
			//   void (__fastcall *v130)(__int64, OneofDescriptor *); // rax
			//   float v131; // eax
			//   Matrix4x4 *HGCameraCullingMatrix; // rax
			//   __int128 v133; // xmm1
			//   __int128 v134; // xmm2
			//   __int128 v135; // xmm3
			//   __m128 v136; // xmm4
			//   __m128 v137; // xmm4
			//   __m128 v138; // xmm4
			//   __m128 v139; // xmm4
			//   int32_t v140; // eax
			//   bool v141; // cc
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   Object_1 *m_depthOfField; // rbx
			//   HGCamera_VolumeComponentsData *v144; // rbx
			//   Object_1 *v145; // rdi
			//   FileDescriptor *v146; // r8
			//   MessageDescriptor *v147; // r9
			//   OneofDescriptorProto *v148; // rdx
			//   FileDescriptor *v149; // r8
			//   MessageDescriptor *v150; // r9
			//   OneofDescriptorProto *v151; // rdx
			//   FileDescriptor *v152; // r8
			//   OneofDescriptorProto *v153; // rdx
			//   FileDescriptor *v154; // r8
			//   MessageDescriptor *v155; // r9
			//   OneofDescriptorProto *v156; // rdx
			//   FileDescriptor *v157; // r8
			//   MessageDescriptor *v158; // r9
			//   OneofDescriptorProto *v159; // rdx
			//   FileDescriptor *v160; // r8
			//   OneofDescriptorProto *v161; // rdx
			//   FileDescriptor *v162; // r8
			//   MessageDescriptor *v163; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v165; // xmm1_8
			//   HGAdditionalCameraData_AntialiasingMode__Enum v166; // edx
			//   ILFixDynamicMethodWrapper_2 *v167; // rax
			//   __int64 v168; // rax
			//   ILFixDynamicMethodWrapper_2 *v169; // rax
			//   ILFixDynamicMethodWrapper_2 *v170; // rax
			//   Rect v171; // xmm7
			//   Rect v172; // xmm9
			//   int32_t pixelWidth; // eax
			//   __m128 v174; // xmm7
			//   __m128 v175; // xmm7
			//   __int64 v176; // rax
			//   float v177; // xmm9_4
			//   float v178; // xmm0_4
			//   __int64 v179; // rax
			//   __int64 v180; // rax
			//   __int64 v181; // rax
			//   __int64 v182; // rax
			//   __int64 v183; // rax
			//   __int64 v184; // rax
			//   __int64 v185; // rax
			//   __int64 v186; // rax
			//   __int64 v187; // rax
			//   __int64 v188; // rax
			//   __int64 v189; // rax
			//   __int64 v190; // rax
			//   __int64 v191; // rax
			//   int v192; // edx
			//   int v193; // edx
			//   int v194; // edx
			//   int m_CachedPtr; // edx
			//   int v196; // edx
			//   int v197; // edx
			//   MethodInfo *methoda; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *methodd; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *methode; // [rsp+20h] [rbp-E0h]
			//   String *v203; // [rsp+28h] [rbp-D8h]
			//   String *v204; // [rsp+28h] [rbp-D8h]
			//   String *v205; // [rsp+28h] [rbp-D8h]
			//   String *v206; // [rsp+28h] [rbp-D8h]
			//   String *v207; // [rsp+28h] [rbp-D8h]
			//   OneofDescriptor size; // [rsp+30h] [rbp-D0h] BYREF
			//   Vector2Int viewportSize; // [rsp+80h] [rbp-80h]
			//   OneofDescriptor__Fields v210; // [rsp+88h] [rbp-78h] BYREF
			//   OneofDescriptor__Fields v211; // [rsp+D0h] [rbp-30h] BYREF
			//   FrameSettings v212; // [rsp+110h] [rbp+10h] BYREF
			//   OneofDescriptor__Fields v213; // [rsp+130h] [rbp+30h] BYREF
			//   Matrix4x4 fields; // [rsp+170h] [rbp+70h] BYREF
			//   OneofDescriptor__Fields v215; // [rsp+1B0h] [rbp+B0h] BYREF
			//   Matrix4x4 v216; // [rsp+1F0h] [rbp+F0h] BYREF
			// 
			//   v6 = (Object *)hgrp;
			//   if ( !byte_18D8EDA15 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGDepthOfField>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDA15 = 1;
			//   }
			//   v9 = 0LL;
			//   viewportSize = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   monitor = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, currentFrameSettings);
			//     monitor = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(Camera ***)(monitor + 184);
			//   if ( !v11 )
			//     goto LABEL_157;
			//   if ( SLODWORD(v11[1].klass) > 654 )
			//   {
			//     if ( !*(_DWORD *)(monitor + 224) )
			//     {
			//       il2cpp_runtime_class_init_0(monitor, v11);
			//       monitor = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v11 = **(Camera ***)(monitor + 184);
			//     if ( !v11 )
			//       goto LABEL_157;
			//     if ( LODWORD(v11[1].klass) <= 0x28E )
			//       goto LABEL_235;
			//     if ( v11[219].monitor )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(654, 0LL);
			//       if ( Patch )
			//       {
			//         v165 = *(_QWORD *)&currentFrameSettings.materialQuality;
			//         v212.bitDatas = currentFrameSettings.bitDatas;
			//         *(_QWORD *)&v212.materialQuality = v165;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(Patch, (Object *)this, &v212, v6, allocateHistoryBuffers, 0LL);
			//         return;
			//       }
			//       goto LABEL_157;
			//     }
			//   }
			//   m_parentCamera = this.fields.m_parentCamera;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   monitor = (__int64)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( m_parentCamera )
			//   {
			//     monitor = (__int64)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   }
			//   if ( this.fields.applyTableSettings && v6 )
			//   {
			//     monitor = (__int64)v6[21].monitor;
			//     if ( !monitor )
			//       goto LABEL_157;
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            *(SettingParameter_1_System_Boolean_ **)(monitor + 32),
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       HG::Rendering::Runtime::HGCamera::set_antialiasing(
			//         this,
			//         HGAdditionalCameraData_AntialiasingMode__Enum_TemporalAntialiasing,
			//         0LL);
			//     }
			//     monitor = (__int64)v6[21].monitor;
			//     if ( !monitor )
			//       goto LABEL_157;
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            *(SettingParameter_1_System_Boolean_ **)(monitor + 144),
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       v166 = HGAdditionalCameraData_AntialiasingMode__Enum_PSSR;
			//     }
			//     else
			//     {
			//       monitor = (__int64)v6[21].monitor;
			//       if ( !monitor )
			//         goto LABEL_157;
			//       if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//              *(SettingParameter_1_System_Boolean_ **)(monitor + 160),
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//       {
			//         v166 = HGAdditionalCameraData_AntialiasingMode__Enum_DLSS;
			//       }
			//       else
			//       {
			//         monitor = (__int64)v6[21].monitor;
			//         if ( !monitor )
			//           goto LABEL_157;
			//         if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                 *(SettingParameter_1_System_Boolean_ **)(monitor + 240),
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//           goto LABEL_185;
			//         v166 = HGAdditionalCameraData_AntialiasingMode__Enum_FSR3;
			//       }
			//     }
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(this, v166, 0LL);
			// LABEL_185:
			//     this.fields.applyTableSettings = 0;
			//   }
			//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_157;
			//   hgRenderPath = m_AdditionalCameraData.fields.hgRenderPath;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v11);
			//   InternalRenderPath = HG::Rendering::Runtime::HGUtils::GetInternalRenderPath(hgRenderPath, 0LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v15);
			//   size.monitor = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v15);
			//     v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (HGRenderPathBase *)v17.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_174;
			//   if ( (int)wrapperArray.fields._intermediateBackBuffer_k__BackingField.fallBackResource.m_Value <= 661 )
			//     goto LABEL_315;
			//   if ( !v17._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v17, wrapperArray);
			//     v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v17 = (struct ILFixDynamicMethodWrapper_2__Class *)v17.static_fields.wrapperArray;
			//   if ( !v17 )
			//     goto LABEL_174;
			//   if ( LODWORD(v17._0.namespaze) <= 0x295 )
			//     sub_180070270(v17, wrapperArray);
			//   if ( !*((_QWORD *)&v17[14]._0.this_arg + 1) )
			//   {
			// LABEL_315:
			//     if ( !this.fields._renderPathInstance_k__BackingField )
			//       goto LABEL_169;
			//     if ( this.fields._renderPathInstance_k__BackingField.fields._renderPath_k__BackingField == InternalRenderPath )
			//       goto LABEL_34;
			//     if ( this.fields._renderPathInstance_k__BackingField )
			//     {
			//       if ( this.fields.reflectionProbeViewHandle )
			//         UnityEngine::HyperGryph::HGReflectionProbe::ResetView(this.fields.reflectionProbeViewHandle, 0LL);
			//       wrapperArray = this.fields._renderPathInstance_k__BackingField;
			//       if ( v6 && wrapperArray )
			//       {
			//         sub_180078890(13LL, wrapperArray, v6[20].monitor);
			//         goto LABEL_170;
			//       }
			//     }
			//     else
			//     {
			// LABEL_169:
			//       if ( v6 )
			//       {
			// LABEL_170:
			//         size.klass = (OneofDescriptor__Class *)HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(
			//                                                  (HGRenderPipeline *)v6,
			//                                                  0LL);
			//         ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//           &size,
			//           v148,
			//           v149,
			//           v150,
			//           (String__Array *)methoda,
			//           v203);
			//         size.monitor = v6[21].monitor;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&size.monitor,
			//           v151,
			//           v152,
			//           (MessageDescriptor *)size.monitor,
			//           (String__Array *)methodb,
			//           v204,
			//           (MethodInfo *)size.klass);
			//         v212.bitDatas = *(BitArray128 *)&size.klass;
			//         this.fields._renderPathInstance_k__BackingField = HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
			//                                                              InternalRenderPath,
			//                                                              (HGRenderPathBase_HGRenderPathResources *)&v212,
			//                                                              this,
			//                                                              0LL);
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields._renderPathInstance_k__BackingField,
			//           v153,
			//           v154,
			//           v155,
			//           (String__Array *)methodc,
			//           v205,
			//           (MethodInfo *)size.klass);
			//         goto LABEL_34;
			//       }
			//     }
			// LABEL_174:
			//     sub_180B536AC(v17, wrapperArray);
			//   }
			//   v167 = IFix::WrappersManagerImpl::GetPatch(661, 0LL);
			//   if ( !v167 )
			//     goto LABEL_174;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
			//     (ILFixDynamicMethodWrapper_14 *)v167,
			//     (Object *)this,
			//     (SCMessageID__Enum)InternalRenderPath,
			//     v6,
			//     0LL);
			// LABEL_34:
			//   this.fields.cullingViewHandle = -1;
			//   v19 = TypeInfo::HG::Rendering::Runtime::HGRenderPipeline;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, wrapperArray);
			//   v20 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v19, wrapperArray);
			//   if ( !v20 )
			//     goto LABEL_157;
			//   HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::UpdateHGCameraPixelRect(v20, this, 0LL);
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_157;
			//   v22 = (__int64 (__fastcall *)(Camera *))qword_18D8F4280;
			//   if ( !qword_18D8F4280 )
			//   {
			//     v22 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::GetLightWeightCamera()");
			//     if ( !v22 )
			//     {
			//       v168 = sub_1802DBBE8("UnityEngine.Camera::GetLightWeightCamera()");
			//       sub_18000F750(v168, 0LL);
			//     }
			//     qword_18D8F4280 = (__int64)v22;
			//   }
			//   v23 = (Camera *)v22(camera);
			//   v24 = 0LL;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v23 )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//     if ( v23.fields._._._.m_CachedPtr )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v11);
			//       v25 = HG::Rendering::Runtime::HGCamera::GetOrCreate(v23, 0, 0LL);
			//       v24 = v25;
			//       if ( !v25 )
			//         goto LABEL_157;
			//       v26 = v25.fields.m_AdditionalCameraData;
			//       if ( !v26 )
			//         goto LABEL_157;
			//       v27 = v26.fields.hgRenderPath;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v11);
			//       v29 = HG::Rendering::Runtime::HGUtils::GetInternalRenderPath(v27, 0LL);
			//       size.monitor = 0LL;
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         byte_18D8EDC37 = 1;
			//       }
			//       v30 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v28);
			//         v30 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       renderPathInstance_k__BackingField = v30.static_fields.wrapperArray;
			//       if ( renderPathInstance_k__BackingField )
			//       {
			//         if ( renderPathInstance_k__BackingField.max_length.size <= 661 )
			//           goto LABEL_316;
			//         if ( !v30._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v30, renderPathInstance_k__BackingField);
			//           v30 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v30 = (struct ILFixDynamicMethodWrapper_2__Class *)v30.static_fields.wrapperArray;
			//         if ( !v30 )
			//           goto LABEL_173;
			//         if ( LODWORD(v30._0.namespaze) <= 0x295 )
			//           sub_180070270(v30, renderPathInstance_k__BackingField);
			//         if ( *((_QWORD *)&v30[14]._0.this_arg + 1) )
			//         {
			//           v169 = IFix::WrappersManagerImpl::GetPatch(661, 0LL);
			//           if ( v169 )
			//           {
			//             IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
			//               (ILFixDynamicMethodWrapper_14 *)v169,
			//               (Object *)v24,
			//               (SCMessageID__Enum)v29,
			//               v6,
			//               0LL);
			//             goto LABEL_65;
			//           }
			//         }
			//         else
			//         {
			// LABEL_316:
			//           if ( !v24.fields._renderPathInstance_k__BackingField )
			//             goto LABEL_171;
			//           if ( v24.fields._renderPathInstance_k__BackingField.fields._renderPath_k__BackingField == v29 )
			//           {
			// LABEL_65:
			//             this.fields.cullingViewHandle = -1;
			//             v32 = TypeInfo::HG::Rendering::Runtime::HGRenderPipeline;
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(
			//                 TypeInfo::HG::Rendering::Runtime::HGRenderPipeline,
			//                 renderPathInstance_k__BackingField);
			//             v33 = (HGRenderPipeline_HGResolutionSettings *)sub_18256BE70(v32, renderPathInstance_k__BackingField);
			//             if ( !v33 )
			//               goto LABEL_157;
			//             HG::Rendering::Runtime::HGRenderPipeline::HGResolutionSettings::UpdateHGCameraPixelRect(v33, v24, 0LL);
			//             goto LABEL_69;
			//           }
			//           if ( v24.fields._renderPathInstance_k__BackingField )
			//           {
			//             if ( v24.fields.reflectionProbeViewHandle )
			//               UnityEngine::HyperGryph::HGReflectionProbe::ResetView(v24.fields.reflectionProbeViewHandle, 0LL);
			//             renderPathInstance_k__BackingField = (ILFixDynamicMethodWrapper_2__Array *)v24.fields._renderPathInstance_k__BackingField;
			//             if ( v6 && renderPathInstance_k__BackingField )
			//             {
			//               sub_180078890(13LL, renderPathInstance_k__BackingField, v6[20].monitor);
			//               goto LABEL_172;
			//             }
			//           }
			//           else
			//           {
			// LABEL_171:
			//             if ( v6 )
			//             {
			// LABEL_172:
			//               size.klass = (OneofDescriptor__Class *)HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(
			//                                                        (HGRenderPipeline *)v6,
			//                                                        0LL);
			//               ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//                 &size,
			//                 v156,
			//                 v157,
			//                 v158,
			//                 (String__Array *)methoda,
			//                 v203);
			//               size.monitor = v6[21].monitor;
			//               sub_1800054D0(
			//                 (OneofDescriptor *)&size.monitor,
			//                 v159,
			//                 v160,
			//                 (MessageDescriptor *)size.monitor,
			//                 (String__Array *)methodd,
			//                 v206,
			//                 (MethodInfo *)size.klass);
			//               v212.bitDatas = *(BitArray128 *)&size.klass;
			//               v24.fields._renderPathInstance_k__BackingField = HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
			//                                                                   v29,
			//                                                                   (HGRenderPathBase_HGRenderPathResources *)&v212,
			//                                                                   v24,
			//                                                                   0LL);
			//               sub_1800054D0(
			//                 (OneofDescriptor *)&v24.fields._renderPathInstance_k__BackingField,
			//                 v161,
			//                 v162,
			//                 v163,
			//                 (String__Array *)methode,
			//                 v207,
			//                 (MethodInfo *)size.klass);
			//               goto LABEL_65;
			//             }
			//           }
			//         }
			//       }
			// LABEL_173:
			//       sub_180B536AC(v30, renderPathInstance_k__BackingField);
			//     }
			//   }
			// LABEL_69:
			//   v34 = this.fields.m_AdditionalCameraData;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v34 )
			//     goto LABEL_156;
			//   monitor = (__int64)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( v34.fields._._._._.m_CachedPtr )
			//   {
			//     v35 = this.fields.m_AdditionalCameraData;
			//     if ( !v35 )
			//       goto LABEL_157;
			//     materialMipBias = v35.fields.materialMipBias;
			//   }
			//   else
			//   {
			// LABEL_156:
			//     materialMipBias = 0.0;
			//   }
			//   this.fields._globalMipBias_k__BackingField = materialMipBias;
			//   HG::Rendering::Runtime::HGCamera::UpdateVolumeAndPhysicalParameters(this, 0LL);
			//   v37 = *(_QWORD *)&currentFrameSettings.materialQuality;
			//   this.fields._frameSettings_k__BackingField.bitDatas = currentFrameSettings.bitDatas;
			//   *(_QWORD *)&this.fields._frameSettings_k__BackingField.materialQuality = v37;
			//   HG::Rendering::Runtime::HGCamera::UpdateAntialiasing(this, 0LL);
			//   v39 = byte_18D8EDA25 == 0;
			//   this.fields.prevFinalViewport = this.fields.finalViewport;
			//   if ( v39 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rect>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rect>::get_Value);
			//     byte_18D8EDA25 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   monitor = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v38);
			//     monitor = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(Camera ***)(monitor + 184);
			//   if ( !v11 )
			//     goto LABEL_157;
			//   if ( SLODWORD(v11[1].klass) <= 682 )
			//     goto LABEL_91;
			//   if ( !*(_DWORD *)(monitor + 224) )
			//   {
			//     il2cpp_runtime_class_init_0(monitor, v11);
			//     monitor = (__int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   monitor = **(_QWORD **)(monitor + 184);
			//   if ( !monitor )
			//     goto LABEL_157;
			//   if ( *(_DWORD *)(monitor + 24) <= 0x2AAu )
			// LABEL_235:
			//     sub_180070270(monitor, v11);
			//   if ( *(_QWORD *)(monitor + 5488) )
			//   {
			//     v170 = IFix::WrappersManagerImpl::GetPatch(682, 0LL);
			//     if ( !v170 )
			//       goto LABEL_157;
			//     v44 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_258((Rect *)&v212, v170, (Object *)this, 0LL);
			//     goto LABEL_94;
			//   }
			// LABEL_91:
			//   if ( this.fields.overridePixelRect.hasValue )
			//   {
			//     value = this.fields.overridePixelRect.value;
			//     v41 = _mm_shuffle_ps((__m128)value, (__m128)value, 225);
			//     v41.m128_f32[0] = _mm_shuffle_ps((__m128)value, (__m128)value, 85).m128_f32[0];
			//     v42 = _mm_shuffle_ps(v41, v41, 198);
			//     v42.m128_f32[0] = _mm_shuffle_ps((__m128)value, (__m128)value, 170).m128_f32[0];
			//     v43 = _mm_shuffle_ps(v42, v42, 39);
			//     v43.m128_f32[0] = _mm_shuffle_ps((__m128)value, (__m128)value, 255).m128_f32[0];
			//   }
			//   else
			//   {
			//     v11 = this.fields.camera;
			//     if ( !v11 )
			//       goto LABEL_157;
			//     v171 = *UnityEngine::Camera::get_pixelRect((Rect *)&v212, v11, 0LL);
			//     v11 = this.fields.camera;
			//     if ( !v11 )
			//       goto LABEL_157;
			//     v172 = *UnityEngine::Camera::get_pixelRect((Rect *)&v212, v11, 0LL);
			//     monitor = (__int64)this.fields.camera;
			//     if ( !monitor )
			//       goto LABEL_157;
			//     pixelWidth = UnityEngine::Camera::get_pixelWidth((Camera *)monitor, 0LL);
			//     monitor = (__int64)this.fields.camera;
			//     if ( !monitor )
			//       goto LABEL_157;
			//     v174 = _mm_shuffle_ps((__m128)v171, (__m128)v171, 225);
			//     v174.m128_f32[0] = _mm_shuffle_ps((__m128)v172, (__m128)v172, 85).m128_f32[0];
			//     v175 = _mm_shuffle_ps(v174, v174, 198);
			//     v175.m128_f32[0] = (float)pixelWidth;
			//     v43 = _mm_shuffle_ps(v175, v175, 39);
			//     v43.m128_f32[0] = (float)UnityEngine::Camera::get_pixelHeight((Camera *)monitor, 0LL);
			//   }
			//   v44 = _mm_shuffle_ps(v43, v43, 57);
			//   *(__m128 *)&size.klass = v44;
			// LABEL_94:
			//   LODWORD(v45) = _mm_shuffle_ps(v44, v44, 170).m128_u32[0];
			//   this.fields.finalViewport = (Rect)v44;
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v11);
			//   v46 = 1;
			//   if ( (int)v45 >= 1 )
			//     v46 = (int)v45;
			//   this.fields._actualWidth_k__BackingField = v46;
			//   m_Height = 1;
			//   if ( (int)this.fields.finalViewport.m_Height >= 1 )
			//     m_Height = (int)this.fields.finalViewport.m_Height;
			//   this.fields._actualHeight_k__BackingField = m_Height;
			//   if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler, v11);
			//   v48 = sub_18256BBD0();
			//   LODWORD(size.klass) = (int)this.fields.finalViewport.m_Width;
			//   monitor = (unsigned int)(int)this.fields.finalViewport.m_Height;
			//   HIDWORD(size.klass) = (int)this.fields.finalViewport.m_Height;
			//   if ( !v48 )
			//     goto LABEL_157;
			//   *(_QWORD *)(v48 + 72) = size.klass;
			//   viewportSize = *(Vector2Int *)&this.fields._actualWidth_k__BackingField;
			//   v49 = viewportSize;
			//   HG::Rendering::Runtime::HGUtils::PackedMipChainInfo::ComputePackedMipChainInfo(
			//     &this.fields.m_DepthBufferMipChainInfo,
			//     viewportSize,
			//     0LL);
			//   v50 = this.fields.camera;
			//   this.fields.lowResScale = 0.5;
			//   if ( !v50 )
			//     goto LABEL_157;
			//   v51 = (unsigned int (__fastcall *)(Camera *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v51 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v51 )
			//     {
			//       v176 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v176, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v51;
			//   }
			//   if ( v51(v50) == 1 )
			//   {
			//     if ( !TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::DynamicResolutionHandler, v11);
			//     v52 = sub_18256BBD0();
			//     v53 = v52;
			//     LODWORD(size.klass) = this.fields._actualWidth_k__BackingField;
			//     monitor = (unsigned int)this.fields._actualHeight_k__BackingField;
			//     HIDWORD(size.klass) = this.fields._actualHeight_k__BackingField;
			//     if ( !v52 )
			//       goto LABEL_157;
			//     klass = size.klass;
			//     *(_QWORD *)(v52 + 60) = size.klass;
			//     if ( *(_BYTE *)(v52 + 16) && *(_BYTE *)(v52 + 33) )
			//     {
			//       klass = (OneofDescriptor__Class *)UnityEngine::Rendering::DynamicResolutionHandler::ApplyScalesOnSize(
			//                                           (DynamicResolutionHandler *)v52,
			//                                           (Vector2Int)klass,
			//                                           0LL);
			//       *(_QWORD *)(v53 + 52) = klass;
			//     }
			//     this.fields._actualWidth_k__BackingField = (int)klass;
			//     globalMipBias_k__BackingField = this.fields._globalMipBias_k__BackingField;
			//     this.fields._actualHeight_k__BackingField = HIDWORD(klass);
			//     v56 = sub_18256BBD0();
			//     if ( !v56 )
			//       goto LABEL_157;
			//     if ( !byte_18D8F360B )
			//     {
			//       sub_18003C530(&TypeInfo::System::Math);
			//       byte_18D8F360B = 1;
			//     }
			//     if ( *(_BYTE *)(v56 + 17) )
			//     {
			//       if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::System::Math, v11);
			//       v57 = System::Math::Log((double)(int)klass / (double)viewportSize.m_X, 2.0, 0LL);
			//     }
			//     else
			//     {
			//       v57 = 0.0;
			//     }
			//     this.fields._globalMipBias_k__BackingField = v57 + globalMipBias_k__BackingField;
			//     v58 = sub_18256BBD0();
			//     lowResScale = this.fields.lowResScale;
			//     v60 = v58;
			//     if ( !v58 )
			//       goto LABEL_157;
			//     if ( !byte_18D8F360D )
			//     {
			//       sub_18003C530(&TypeInfo::System::Math);
			//       byte_18D8F360D = 1;
			//     }
			//     if ( !*(_BYTE *)(v60 + 16) )
			//       goto LABEL_119;
			//     v177 = *(float *)(v60 + 116);
			//     if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Math, v11);
			//     v178 = System::Math::Min(v177 / 100.0, lowResScale, 0LL);
			//     if ( (float)(lowResScale * *(float *)(v60 + 28)) < v178 )
			//     {
			//       v61 = v178 / *(float *)(v60 + 28);
			//       if ( v61 < 0.0 )
			//       {
			//         v61 = 0.0;
			//       }
			//       else if ( v61 > 1.0 )
			//       {
			//         v61 = 1.0;
			//       }
			//     }
			//     else
			//     {
			// LABEL_119:
			//       v61 = lowResScale;
			//     }
			//     v6 = (Object *)hgrp;
			//     v9 = 0LL;
			//     this.fields.lowResScale = v61;
			//   }
			//   this.fields._msaaSamples_k__BackingField = 1;
			//   if ( !v6 )
			//     goto LABEL_157;
			//   HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(this, (HGSettingParameters *)v6[21].monitor, v49, 0LL);
			//   v63 = (HGSettingParameters *)v6[21].monitor;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v62);
			//   HG::Rendering::Runtime::HGUtils::GetRenderingScale(this, v63, 0LL);
			//   actualHeight_k__BackingField = this.fields._actualHeight_k__BackingField;
			//   LODWORD(size.klass) = this.fields._actualWidth_k__BackingField;
			//   klass_low = LODWORD(size.klass);
			//   HIDWORD(size.klass) = actualHeight_k__BackingField;
			//   v66 = size.klass;
			//   this.fields._taauRTSize_k__BackingField = (Vector2Int)size.klass;
			//   v67 = _mm_shuffle_ps(
			//           (__m128)COERCE_UNSIGNED_INT((float)(int)klass_low),
			//           (__m128)COERCE_UNSIGNED_INT((float)(int)klass_low),
			//           225);
			//   v67.m128_f32[0] = (float)SHIDWORD(v66);
			//   v68 = _mm_shuffle_ps(v67, v67, 198);
			//   v68.m128_f32[0] = 1.0 / (float)(int)klass_low;
			//   v69 = _mm_shuffle_ps(v68, v68, 39);
			//   v69.m128_f32[0] = 1.0 / (float)SHIDWORD(v66);
			//   *(__m128 *)&size.klass = _mm_shuffle_ps(v69, v69, 57);
			//   this.fields._taauRTSizeParam_k__BackingField = *(Vector4 *)&size.klass;
			//   v70 = sub_1825C6750((unsigned __int64)v66 >> 32, klass_low);
			//   actualWidth_k__BackingField = this.fields._actualWidth_k__BackingField;
			//   if ( v70 < actualWidth_k__BackingField )
			//     actualWidth_k__BackingField = v70;
			//   v74 = sub_1825C6750(v72, v71);
			//   v75 = this.fields._actualHeight_k__BackingField;
			//   if ( v74 < v75 )
			//     v75 = v74;
			//   v76 = actualWidth_k__BackingField & 0xFFFFFFFE;
			//   LODWORD(size.klass) = v76;
			//   HIDWORD(size.klass) = v75 & 0xFFFFFFFE;
			//   v77 = size.klass;
			//   this.fields._sceneRTSize_k__BackingField = (Vector2Int)size.klass;
			//   monitor = (unsigned __int64)v77 >> 32;
			//   v78 = _mm_shuffle_ps((__m128)COERCE_UNSIGNED_INT((float)v76), (__m128)COERCE_UNSIGNED_INT((float)v76), 225);
			//   v78.m128_f32[0] = (float)SHIDWORD(v77);
			//   v79 = _mm_shuffle_ps(v78, v78, 198);
			//   v79.m128_f32[0] = 1.0 / (float)v76;
			//   v80 = _mm_shuffle_ps(v79, v79, 39);
			//   v80.m128_f32[0] = 1.0 / (float)SHIDWORD(v77);
			//   *(__m128 *)&size.klass = _mm_shuffle_ps(v80, v80, 57);
			//   this.fields._sceneRTSizeParam_k__BackingField = *(Vector4 *)&size.klass;
			//   if ( v24 )
			//   {
			//     if ( !v23 )
			//       goto LABEL_157;
			//     v81 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))qword_18D8F42E8;
			//     memset(&size.fields, 0, sizeof(size.fields));
			//     if ( !qword_18D8F42E8 )
			//     {
			//       v81 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                         "UnityEngine.Camera::get_worldToCameraMatrix_Inje"
			//                                                                         "cted(UnityEngine.Matrix4x4&)");
			//       if ( !v81 )
			//       {
			//         v179 = sub_1802DBBE8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v179, 0LL);
			//       }
			//       qword_18D8F42E8 = (__int64)v81;
			//     }
			//     v81(v23, &size.fields);
			//     fields = (Matrix4x4)size.fields;
			//     UnityEngine::Matrix4x4::set_Item(&fields, 12, 0.0, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&fields, 13, 0.0, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&fields, 14, 0.0, 0LL);
			//     UnityEngine::Matrix4x4::set_Item(&fields, 15, 1.0, 0LL);
			//     v24.fields._taauRTSize_k__BackingField = this.fields._taauRTSize_k__BackingField;
			//     taauRTSizeParam_k__BackingField = this.fields._taauRTSizeParam_k__BackingField;
			//     *(_OWORD *)&size.fields._._Index_k__BackingField = 0LL;
			//     v24.fields._taauRTSizeParam_k__BackingField = taauRTSizeParam_k__BackingField;
			//     v24.fields._sceneRTSize_k__BackingField = this.fields._sceneRTSize_k__BackingField;
			//     sceneRTSizeParam_k__BackingField = this.fields._sceneRTSizeParam_k__BackingField;
			//     v84 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))qword_18D8F42F0;
			//     *(_OWORD *)&size.fields._._File_k__BackingField = 0LL;
			//     v24.fields._sceneRTSizeParam_k__BackingField = sceneRTSizeParam_k__BackingField;
			//     memset(&size.fields.fields, 0, 32);
			//     if ( !v84 )
			//     {
			//       v84 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                         "UnityEngine.Camera::get_projectionMatrix_Injecte"
			//                                                                         "d(UnityEngine.Matrix4x4&)");
			//       if ( !v84 )
			//       {
			//         v180 = sub_1802DBBE8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v180, 0LL);
			//       }
			//       qword_18D8F42F0 = (__int64)v84;
			//     }
			//     v84(v23, &size.fields);
			//     v86 = (void (__fastcall *)(OneofDescriptor__Fields *, __int64, OneofDescriptor__Fields *))qword_18D8F44A8;
			//     v211 = size.fields;
			//     memset(&v210, 0, sizeof(v210));
			//     if ( !qword_18D8F44A8 )
			//     {
			//       v86 = (void (__fastcall *)(OneofDescriptor__Fields *, __int64, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                                                   "UnityEngine.GL::GetGPU"
			//                                                                                                   "ProjectionMatrix_Injec"
			//                                                                                                   "ted(UnityEngine.Matrix"
			//                                                                                                   "4x4&,System.Boolean,Un"
			//                                                                                                   "ityEngine.Matrix4x4&)");
			//       if ( !v86 )
			//       {
			//         v181 = sub_1802DBBE8(
			//                  "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v181, 0LL);
			//       }
			//       qword_18D8F44A8 = (__int64)v86;
			//     }
			//     LOBYTE(v85) = 1;
			//     v86(&v211, v85, &v210);
			//     v87 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))qword_18D8F42E8;
			//     memset(&size.fields, 0, sizeof(size.fields));
			//     if ( !qword_18D8F42E8 )
			//     {
			//       v87 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                         "UnityEngine.Camera::get_worldToCameraMatrix_Inje"
			//                                                                         "cted(UnityEngine.Matrix4x4&)");
			//       if ( !v87 )
			//       {
			//         v182 = sub_1802DBBE8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v182, 0LL);
			//       }
			//       qword_18D8F42E8 = (__int64)v87;
			//     }
			//     v87(v23, &size.fields);
			//     v88 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))qword_18D8F42E8;
			//     v89 = *(_OWORD *)&size.fields._._File_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewMatrix.m00 = *(_OWORD *)&size.fields._._Index_k__BackingField;
			//     v90 = *(_OWORD *)&size.fields.fields;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewMatrix.m01 = v89;
			//     v91 = *(_OWORD *)&size.fields._Proto_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewMatrix.m02 = v90;
			//     memset(&v211, 0, sizeof(v211));
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewMatrix.m03 = v91;
			//     if ( !v88 )
			//     {
			//       v88 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                         "UnityEngine.Camera::get_worldToCameraMatrix_Inje"
			//                                                                         "cted(UnityEngine.Matrix4x4&)");
			//       if ( !v88 )
			//       {
			//         v183 = sub_1802DBBE8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v183, 0LL);
			//       }
			//       qword_18D8F42E8 = (__int64)v88;
			//     }
			//     v88(v23, &v211);
			//     v92 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *))qword_18D8F4BD0;
			//     v215 = v211;
			//     memset(&size.fields, 0, sizeof(size.fields));
			//     if ( !qword_18D8F4BD0 )
			//     {
			//       v92 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                                          "UnityEngine.Matrix4x4::Inverse_"
			//                                                                                          "Injected(UnityEngine.Matrix4x4&"
			//                                                                                          ",UnityEngine.Matrix4x4&)");
			//       if ( !v92 )
			//       {
			//         v184 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v184, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v92;
			//     }
			//     v92(&v215, &size.fields);
			//     v93 = *(_OWORD *)&v210._._Index_k__BackingField;
			//     v94 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *))qword_18D8F4BD0;
			//     v95 = *(_OWORD *)&v210._._File_k__BackingField;
			//     v213 = v210;
			//     v96 = *(_OWORD *)&v210.fields;
			//     v97 = *(_OWORD *)&v210._Proto_k__BackingField;
			//     v98 = *(_OWORD *)&size.fields._._File_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewMatrix.m00 = *(_OWORD *)&size.fields._._Index_k__BackingField;
			//     v99 = *(_OWORD *)&size.fields.fields;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewMatrix.m01 = v98;
			//     v100 = *(_OWORD *)&size.fields._Proto_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewMatrix.m02 = v99;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewMatrix.m03 = v100;
			//     *(_OWORD *)&v24.fields.mainViewConstants.projMatrix.m00 = v93;
			//     *(_OWORD *)&v24.fields.mainViewConstants.projMatrix.m01 = v95;
			//     *(_OWORD *)&v24.fields.mainViewConstants.projMatrix.m02 = v96;
			//     *(_OWORD *)&v24.fields.mainViewConstants.projMatrix.m03 = v97;
			//     memset(&v210, 0, sizeof(v210));
			//     if ( !v94 )
			//     {
			//       v94 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                                          "UnityEngine.Matrix4x4::Inverse_"
			//                                                                                          "Injected(UnityEngine.Matrix4x4&"
			//                                                                                          ",UnityEngine.Matrix4x4&)");
			//       if ( !v94 )
			//       {
			//         v185 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v185, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v94;
			//     }
			//     v94(&v213, &v210);
			//     v101 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))qword_18D8F42E8;
			//     v102 = *(_OWORD *)&v210._._File_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invProjMatrix.m00 = *(_OWORD *)&v210._._Index_k__BackingField;
			//     v103 = *(_OWORD *)&v210.fields;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invProjMatrix.m01 = v102;
			//     v104 = *(_OWORD *)&v210._Proto_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invProjMatrix.m02 = v103;
			//     memset(&v211, 0, sizeof(v211));
			//     *(_OWORD *)&v24.fields.mainViewConstants.invProjMatrix.m03 = v104;
			//     if ( !v101 )
			//     {
			//       v101 = (void (__fastcall *)(Camera *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Camera::get_worldToCameraMatrix_Inj"
			//                                                                          "ected(UnityEngine.Matrix4x4&)");
			//       if ( !v101 )
			//       {
			//         v186 = sub_1802DBBE8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v186, 0LL);
			//       }
			//       qword_18D8F42E8 = (__int64)v101;
			//     }
			//     v101(v23, &v211);
			//     v105 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *, OneofDescriptor__Fields *))qword_18D8F4BC0;
			//     *(_OWORD *)&v215._._Index_k__BackingField = v93;
			//     v213 = v211;
			//     *(_OWORD *)&v215._._File_k__BackingField = v95;
			//     *(_OWORD *)&v215.fields = v96;
			//     *(_OWORD *)&v215._Proto_k__BackingField = v97;
			//     memset(&v210, 0, sizeof(v210));
			//     if ( !qword_18D8F4BC0 )
			//     {
			//       v105 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v105 )
			//       {
			//         v187 = sub_1802DBBE8(
			//                  "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
			//                  "nityEngine.Matrix4x4&)");
			//         sub_18000F750(v187, 0LL);
			//       }
			//       qword_18D8F4BC0 = (__int64)v105;
			//     }
			//     v105(&v215, &v213, &v210);
			//     v106 = (void (__fastcall *)(Matrix4x4 *, OneofDescriptor__Fields *, OneofDescriptor__Fields *))qword_18D8F4BC0;
			//     *(_OWORD *)&v216.m00 = v93;
			//     *(_OWORD *)&v216.m01 = v95;
			//     *(_OWORD *)&v216.m02 = v96;
			//     *(_OWORD *)&v216.m03 = v97;
			//     v107 = *(_OWORD *)&v210._._File_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m00 = *(_OWORD *)&v210._._Index_k__BackingField;
			//     v108 = *(_OWORD *)&v210.fields;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m01 = v107;
			//     v109 = *(_OWORD *)&v210._Proto_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m02 = v108;
			//     *(_OWORD *)&size.fields._._Index_k__BackingField = *(_OWORD *)&fields.m00;
			//     *(_OWORD *)&size.fields.fields = *(_OWORD *)&fields.m02;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m03 = v109;
			//     *(_OWORD *)&size.fields._._File_k__BackingField = *(_OWORD *)&fields.m01;
			//     *(_OWORD *)&size.fields._Proto_k__BackingField = *(_OWORD *)&fields.m03;
			//     memset(&v211, 0, sizeof(v211));
			//     if ( !v106 )
			//     {
			//       v106 = (void (__fastcall *)(Matrix4x4 *, OneofDescriptor__Fields *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v106 )
			//       {
			//         v188 = sub_1802DBBE8(
			//                  "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
			//                  "nityEngine.Matrix4x4&)");
			//         sub_18000F750(v188, 0LL);
			//       }
			//       qword_18D8F4BC0 = (__int64)v106;
			//     }
			//     v106(&v216, &size.fields, &v211);
			//     v110 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *))qword_18D8F4BD0;
			//     v111 = *(_OWORD *)&v211._._File_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m00 = *(_OWORD *)&v211._._Index_k__BackingField;
			//     v112 = *(_OWORD *)&v211.fields;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m01 = v111;
			//     v113 = *(_OWORD *)&v211._Proto_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m02 = v112;
			//     *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m03 = v113;
			//     v114 = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m01;
			//     *(_OWORD *)&v213._._Index_k__BackingField = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m00;
			//     *(_OWORD *)&v213._._File_k__BackingField = v114;
			//     v115 = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m03;
			//     *(_OWORD *)&v213.fields = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m02;
			//     *(_OWORD *)&v213._Proto_k__BackingField = v115;
			//     memset(&v210, 0, sizeof(v210));
			//     if ( !v110 )
			//     {
			//       v110 = (void (__fastcall *)(OneofDescriptor__Fields *, OneofDescriptor__Fields *))il2cpp_resolve_icall_0(
			//                                                                                           "UnityEngine.Matrix4x4::Inverse"
			//                                                                                           "_Injected(UnityEngine.Matrix4x"
			//                                                                                           "4&,UnityEngine.Matrix4x4&)");
			//       if ( !v110 )
			//       {
			//         v189 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v189, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v110;
			//     }
			//     v110(&v213, &v210);
			//     v116 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//     v117 = *(_OWORD *)&v210._._File_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m00 = *(_OWORD *)&v210._._Index_k__BackingField;
			//     v118 = *(_OWORD *)&v210.fields;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m01 = v117;
			//     v119 = *(_OWORD *)&v210._Proto_k__BackingField;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m02 = v118;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m03 = v119;
			//     v120 = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m01;
			//     v121 = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m02;
			//     v122 = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m03;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewProjMatrix.m00 = *(_OWORD *)&v24.fields.mainViewConstants.viewProjMatrix.m00;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewProjMatrix.m01 = v120;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewProjMatrix.m02 = v121;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewProjMatrix.m03 = v122;
			//     v123 = *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m01;
			//     v124 = *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m02;
			//     v125 = *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m03;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m00 = *(_OWORD *)&v24.fields.mainViewConstants.viewNoTransProjMatrix.m00;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m01 = v123;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m02 = v124;
			//     *(_OWORD *)&v24.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m03 = v125;
			//     v126 = *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m01;
			//     v127 = *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m02;
			//     v128 = *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m03;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invNonJitteredViewProjMatrix.m00 = *(_OWORD *)&v24.fields.mainViewConstants.invViewProjMatrix.m00;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invNonJitteredViewProjMatrix.m01 = v126;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invNonJitteredViewProjMatrix.m02 = v127;
			//     *(_OWORD *)&v24.fields.mainViewConstants.invNonJitteredViewProjMatrix.m03 = v128;
			//     if ( !v116 )
			//     {
			//       v116 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//       if ( !v116 )
			//       {
			//         v190 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v190, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v116;
			//     }
			//     v129 = v116(v23);
			//     if ( !v129 )
			//       goto LABEL_157;
			//     size.klass = 0LL;
			//     LODWORD(size.monitor) = 0;
			//     v130 = (void (__fastcall *)(__int64, OneofDescriptor *))qword_18D8F52E0;
			//     if ( !qword_18D8F52E0 )
			//     {
			//       v130 = (void (__fastcall *)(__int64, OneofDescriptor *))il2cpp_resolve_icall_0(
			//                                                                 "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       if ( !v130 )
			//       {
			//         v191 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v191, 0LL);
			//       }
			//       qword_18D8F52E0 = (__int64)v130;
			//     }
			//     v130(v129, &size);
			//     v131 = *(float *)&size.monitor;
			//     *(_QWORD *)&v24.fields.mainViewConstants.worldSpaceCameraPos.x = size.klass;
			//     v24.fields.mainViewConstants.worldSpaceCameraPos.z = v131;
			//     HGCameraCullingMatrix = HG::Rendering::Runtime::HGCamera::GetHGCameraCullingMatrix(&v216, v24, 0LL);
			//     v133 = *(_OWORD *)&HGCameraCullingMatrix.m01;
			//     v134 = *(_OWORD *)&HGCameraCullingMatrix.m02;
			//     v135 = *(_OWORD *)&HGCameraCullingMatrix.m03;
			//     *(_OWORD *)&v24.fields.mainViewConstants.cullingMatrix.m00 = *(_OWORD *)&HGCameraCullingMatrix.m00;
			//     *(_OWORD *)&v24.fields.mainViewConstants.cullingMatrix.m01 = v133;
			//     *(_OWORD *)&v24.fields.mainViewConstants.cullingMatrix.m02 = v134;
			//     *(_OWORD *)&v24.fields.mainViewConstants.cullingMatrix.m03 = v135;
			//   }
			//   v136 = 0LL;
			//   v136.m128_f32[0] = (float)this.fields._taauRTSize_k__BackingField.m_X;
			//   monitor = 8LL;
			//   v137 = _mm_shuffle_ps(v136, v136, 225);
			//   v39 = (this.fields.m_antialiasingMode & 0x10) == 0;
			//   v137.m128_f32[0] = (float)(int)HIDWORD(*(_QWORD *)&this.fields._taauRTSize_k__BackingField);
			//   v138 = _mm_shuffle_ps(v137, v137, 198);
			//   v138.m128_f32[0] = (float)(1.0 / (float)this.fields._taauRTSize_k__BackingField.m_X) + 1.0;
			//   v139 = _mm_shuffle_ps(v138, v138, 39);
			//   v139.m128_f32[0] = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&this.fields._taauRTSize_k__BackingField)) + 1.0;
			//   this.fields.screenParams = (Vector4)_mm_shuffle_ps(v139, v139, 57);
			//   if ( !v39 )
			//     goto LABEL_312;
			//   if ( (this.fields.m_antialiasingMode & 0x20) != 0 )
			//   {
			//     v11 = (Camera *)v6[21].monitor;
			//     if ( !v11 )
			//       goto LABEL_157;
			//     v11 = (Camera *)v11[7].klass;
			//     if ( !v11 )
			//       goto LABEL_157;
			//     m_CachedPtr = (int)v11[1].fields._._._.m_CachedPtr;
			//     if ( !m_CachedPtr )
			//       goto LABEL_311;
			//     v196 = m_CachedPtr - 1;
			//     if ( v196 )
			//     {
			//       v197 = v196 - 1;
			//       if ( v197 )
			//       {
			//         if ( v197 == 1 )
			//           LODWORD(monitor) = 18;
			//       }
			//       else
			//       {
			//         LODWORD(monitor) = 24;
			//       }
			//       goto LABEL_148;
			//     }
			// LABEL_312:
			//     LODWORD(monitor) = 32;
			//     goto LABEL_148;
			//   }
			//   if ( (this.fields.m_antialiasingMode & 0x40) != 0 )
			//   {
			//     v11 = (Camera *)v6[21].monitor;
			//     if ( !v11 )
			//       goto LABEL_157;
			//     v11 = (Camera *)v11[10].fields._._._.m_CachedPtr;
			//     if ( !v11 )
			//       goto LABEL_157;
			//     v192 = (int)v11[1].fields._._._.m_CachedPtr;
			//     if ( v192 )
			//     {
			//       v193 = v192 - 1;
			//       if ( v193 )
			//       {
			//         v194 = v193 - 1;
			//         if ( v194 )
			//         {
			//           if ( v194 == 1 )
			//             LODWORD(monitor) = 18;
			//         }
			//         else
			//         {
			//           LODWORD(monitor) = 23;
			//         }
			//         goto LABEL_148;
			//       }
			//       goto LABEL_312;
			//     }
			// LABEL_311:
			//     LODWORD(monitor) = 72;
			//   }
			// LABEL_148:
			//   v140 = this.fields.taaFrameIndex + 1;
			//   this.fields.taaFrameIndex = v140;
			//   if ( v140 >= (int)monitor )
			//     this.fields.taaFrameIndex = 0;
			//   v141 = this.fields.m_ForceJitterIdx <= 0;
			//   this.fields.taaJitterPhaseCount = monitor;
			//   if ( !v141 )
			//     this.fields.taaFrameIndex = this.fields.m_ForceJitterIdx;
			//   HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(this, (HGRenderPipeline *)v6, 0LL);
			//   if ( !this.fields.m_firstGetDoFComponent )
			//     goto LABEL_153;
			//   m_volumeComponentsData = this.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_157;
			//   m_depthOfField = (Object_1 *)m_volumeComponentsData.fields.m_depthOfField;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !UnityEngine::Object::op_Equality(m_depthOfField, 0LL, 0LL) )
			//     goto LABEL_153;
			//   v144 = this.fields.m_volumeComponentsData;
			//   v145 = (Object_1 *)this.fields.camera;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( UnityEngine::Object::op_Inequality(v145, 0LL, 0LL) )
			//   {
			//     monitor = (__int64)this.fields.camera;
			//     if ( !monitor )
			//       goto LABEL_157;
			//     v9 = UnityEngine::Component::GetComponent<System::Object>(
			//            (Component *)monitor,
			//            MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGDepthOfField>);
			//   }
			//   if ( !v144 )
			// LABEL_157:
			//     sub_180B536AC(monitor, v11);
			//   v144.fields.m_depthOfField = (HGDepthOfField *)v9;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v144.fields.m_depthOfField,
			//     (OneofDescriptorProto *)v11,
			//     v146,
			//     v147,
			//     (String__Array *)methoda,
			//     v203,
			//     (MethodInfo *)size.klass);
			//   this.fields.m_firstGetDoFComponent = 0;
			// LABEL_153:
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v11);
			//   v39 = (this.fields._isFirstFrame_k__BackingField | HG::Rendering::Runtime::HGCamera::IsLargeCameraMovement(
			//                                                         &this.fields.mainViewConstants,
			//                                                         75.0,
			//                                                         5.0,
			//                                                         0LL)) == 0;
			//   this.fields._isFirstFrame_k__BackingField = 0;
			//   ++this.fields.cameraFrameCount;
			//   this.fields.prevTransformReset = !v39;
			// }
			// 
		}

		internal void BeginRender(CommandBuffer cmd)
		{
		}

		[IDTag(2)]
		internal void UpdateAllViewConstants(bool jitterProjectionMatrix, HGRenderPipeline hgrp)
		{
			// // Void UpdateAllViewConstants(Boolean, HGRenderPipeline)
			// void HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(
			//         HGCamera *this,
			//         bool jitterProjectionMatrix,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2357, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2357, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_138(
			//       (ILFixDynamicMethodWrapper_8 *)Patch,
			//       (Object *)this,
			//       jitterProjectionMatrix,
			//       (Object *)hgrp,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(this, jitterProjectionMatrix, 0, hgrp, 0LL);
			//   }
			// }
			// 
		}

		internal void GetPixelCoordToViewDirWS(Vector4 resolution, float aspect, ref Matrix4x4 transform)
		{
			// // Void GetPixelCoordToViewDirWS(Vector4, Single, Matrix4x4 ByRef)
			// void HG::Rendering::Runtime::HGCamera::GetPixelCoordToViewDirWS(
			//         HGCamera *this,
			//         Vector4 *resolution,
			//         float aspect,
			//         Matrix4x4 *transform,
			//         MethodInfo *method)
			// {
			//   Matrix4x4 *v8; // rax
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm2
			//   __int128 v11; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Vector4 v15; // [rsp+30h] [rbp-68h] BYREF
			//   Matrix4x4 v16; // [rsp+40h] [rbp-58h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2358, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2358, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     v15 = *resolution;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(Patch, (Object *)this, &v15, aspect, transform, 0LL);
			//   }
			//   else
			//   {
			//     v15 = *resolution;
			//     v8 = HG::Rendering::Runtime::HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
			//            &v16,
			//            this,
			//            &this.fields.mainViewConstants,
			//            &v15,
			//            aspect,
			//            0LL);
			//     v9 = *(_OWORD *)&v8.m01;
			//     v10 = *(_OWORD *)&v8.m02;
			//     v11 = *(_OWORD *)&v8.m03;
			//     *(_OWORD *)&transform.m00 = *(_OWORD *)&v8.m00;
			//     *(_OWORD *)&transform.m01 = v9;
			//     *(_OWORD *)&transform.m02 = v10;
			//     *(_OWORD *)&transform.m03 = v11;
			//   }
			// }
			// 
		}

		internal static void ClearAll(HGRenderGraph renderGraph, CustomDepthOnlyRequestManager customDepthOnlyRequestMgr, long customDepthOnlyRequestMgrCPP)
		{
			// // Void ClearAll(HGRenderGraph, CustomDepthOnlyRequestManager, Int64)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCamera::ClearAll(
			//         HGRenderGraph *renderGraph,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   __int64 v8; // rcx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   struct HGCamera__Class *v11; // rax
			//   Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *s_Cameras; // rbx
			//   __int64 *v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // r8
			//   __int64 v16; // r9
			//   Object *value; // rbx
			//   signed __int64 v18; // rcx
			//   __int64 v19; // rax
			//   __int64 v20; // rax
			//   __int64 v21; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v22; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   signed __int64 v24; // rcx
			//   __int64 v25; // rax
			//   __int64 v26; // rax
			//   __int64 v27; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v28; // rcx
			//   ILFixDynamicMethodWrapper_37 *v29; // rcx
			//   __int64 v30; // rdx
			//   BufferedRTHandleSystem *monitor; // rcx
			//   struct HGCamera__Class *v32; // rax
			//   List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *s_Cleanup; // rcx
			//   int32_t size; // r8d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int64 v38; // [rsp+0h] [rbp-C8h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-A8h]
			//   String *v40; // [rsp+28h] [rbp-A0h]
			//   _BYTE v41[48]; // [rsp+30h] [rbp-98h] BYREF
			//   Il2CppException *ex; // [rsp+60h] [rbp-68h]
			//   Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_Core_GameplayTag_System_Object_ *v43; // [rsp+68h] [rbp-60h]
			//   Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_Core_GameplayTag_System_Object_ v44; // [rsp+70h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v45; // [rsp+A0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDA16 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::Clear);
			//     byte_18D8EDA16 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(504, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(504, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v37, v36);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_92(
			//       (ILFixDynamicMethodWrapper_14 *)Patch,
			//       (Object *)renderGraph,
			//       (Object *)customDepthOnlyRequestMgr,
			//       customDepthOnlyRequestMgrCPP,
			//       0LL);
			//   }
			//   else
			//   {
			//     v11 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v7);
			//       v11 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     s_Cameras = v11.static_fields.s_Cameras;
			//     if ( !s_Cameras )
			//       sub_180B536AC(v8, v7);
			//     memset(&v41[8], 0, 40);
			//     *(_QWORD *)v41 = s_Cameras;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       (OneofDescriptor *)v41,
			//       v7,
			//       v9,
			//       v10,
			//       (String__Array *)methoda,
			//       v40);
			//     *(_QWORD *)&v41[8] = (unsigned int)s_Cameras.fields._version;
			//     *(_DWORD *)&v41[40] = 2;
			//     memset(&v41[16], 0, 24);
			//     *(_OWORD *)&v44._dictionary = *(_OWORD *)v41;
			//     v44._current.key = 0LL;
			//     *(_OWORD *)&v44._current.value = *(_OWORD *)&v41[32];
			//     ex = 0LL;
			//     v43 = &v44;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<Beyond::Gameplay::Core::GameplayTag,System::Object>::MoveNext(
			//                 &v44,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext) )
			//       {
			//         *(KeyValuePair_2_Beyond_Gameplay_Core_GameplayTag_System_Object_ *)v41 = v44._current;
			//         value = v44._current.value;
			//         if ( !v44._current.value )
			//           sub_1802DC2C8(v14, v13);
			//         if ( !byte_18D8EDC37 )
			//         {
			//           v18 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//           if ( (v18 & 1) != 0 )
			//           {
			//             v15 = ((unsigned int)v18 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v18 >> 29 )
			//             {
			//               case 1u:
			//                 v19 = sub_18003C670((unsigned int)v15);
			//                 goto LABEL_21;
			//               case 2u:
			//                 v19 = sub_18003C380((unsigned int)v15);
			//                 goto LABEL_21;
			//               case 3u:
			//               case 6u:
			//                 v19 = sub_1802DFAE0(v18);
			//                 goto LABEL_21;
			//               case 4u:
			//                 v19 = sub_1802DF920((unsigned int)v15);
			//                 goto LABEL_21;
			//               case 5u:
			//                 v19 = sub_1802DFBB0((unsigned int)v15);
			//                 goto LABEL_21;
			//               case 7u:
			//                 v20 = sub_1802DF920((unsigned int)v15);
			//                 v21 = sub_1802DF850(v20);
			//                 if ( v21 )
			//                   v19 = sub_1802DF970(*(unsigned int *)(v21 + 8));
			//                 else
			//                   v19 = 0LL;
			// LABEL_21:
			//                 if ( v19 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v19);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8EDC37 = 1;
			//         }
			//         v22 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v13);
			//           v22 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         wrapperArray = v22.static_fields.wrapperArray;
			//         if ( !wrapperArray )
			//           sub_1802DC2C8(v22, 0LL);
			//         if ( wrapperArray.max_length.size <= 505 )
			//           goto LABEL_53;
			//         if ( !v22._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(v22, wrapperArray);
			//           v22 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         wrapperArray = v22.static_fields.wrapperArray;
			//         if ( !wrapperArray )
			//           sub_1802DC2C8(v22, 0LL);
			//         if ( wrapperArray.max_length.size <= 0x1F9u )
			//           sub_180070260(v22, wrapperArray, v15, v16);
			//         if ( wrapperArray[14].vector[1] )
			//         {
			//           if ( !byte_18D919D50 )
			//           {
			//             v24 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v24 & 1) != 0 )
			//             {
			//               v15 = ((unsigned int)v24 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v24 >> 29 )
			//               {
			//                 case 1u:
			//                   v25 = sub_18003C670((unsigned int)v15);
			//                   goto LABEL_44;
			//                 case 2u:
			//                   v25 = sub_18003C380((unsigned int)v15);
			//                   goto LABEL_44;
			//                 case 3u:
			//                 case 6u:
			//                   v25 = sub_1802DFAE0(v24);
			//                   goto LABEL_44;
			//                 case 4u:
			//                   v25 = sub_1802DF920((unsigned int)v15);
			//                   goto LABEL_44;
			//                 case 5u:
			//                   v25 = sub_1802DFBB0((unsigned int)v15);
			//                   goto LABEL_44;
			//                 case 7u:
			//                   v26 = sub_1802DF920((unsigned int)v15);
			//                   v27 = sub_1802DF850(v26);
			//                   if ( v27 )
			//                     v25 = sub_1802DF970(*(unsigned int *)(v27 + 8));
			//                   else
			//                     v25 = 0LL;
			// LABEL_44:
			//                   if ( v25 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v25);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D919D50 = 1;
			//             v22 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           if ( !v22._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v22, wrapperArray);
			//             v22 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v28 = v22.static_fields.wrapperArray;
			//           if ( !v28 )
			//             sub_1802DC2C8(0LL, wrapperArray);
			//           if ( v28.max_length.size <= 0x1F9u )
			//             sub_180070260(v28, wrapperArray, v15, v16);
			//           v29 = (ILFixDynamicMethodWrapper_37 *)v28[14].vector[1];
			//           if ( !v29 )
			//             sub_1802DC2C8(0LL, wrapperArray);
			//           IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(v29, value, 0LL);
			//         }
			//         else
			//         {
			// LABEL_53:
			//           monitor = (BufferedRTHandleSystem *)value[172].monitor;
			//           if ( !monitor )
			//             sub_1802DC2C8(0LL, wrapperArray);
			//           UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseAll(monitor, 0LL);
			//         }
			//         if ( !*(_QWORD *)&v41[16] )
			//           sub_1802DC2C8(0LL, v30);
			//         HG::Rendering::Runtime::HGCamera::Dispose(
			//           *(HGCamera **)&v41[16],
			//           renderGraph,
			//           customDepthOnlyRequestMgr,
			//           customDepthOnlyRequestMgrCPP,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v45 )
			//     {
			//       v13 = &v38;
			//       ex = v45.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//     v32 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v13);
			//       v32 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     s_Cleanup = (List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *)v32.static_fields.s_Cameras;
			//     if ( !s_Cleanup
			//       || (System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RemoteFactoryVisual::ECSRangeVoxelInfo>::Clear(
			//             (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryVisual_ECSRangeVoxelInfo_ *)s_Cleanup,
			//             MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Clear),
			//           (s_Cleanup = TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.s_Cleanup) == 0LL) )
			//     {
			//       sub_1802DC2C8(s_Cleanup, v13);
			//     }
			//     ++s_Cleanup.fields._version;
			//     size = s_Cleanup.fields._size;
			//     s_Cleanup.fields._size = 0;
			//     if ( size > 0 )
			//       System::Array::Clear((Array *)s_Cleanup.fields._items, 0, size, 0LL);
			//   }
			// }
			// 
		}

		internal static void CleanUnused(HGRenderGraph renderGraph, CustomDepthOnlyRequestManager customDepthOnlyRequestMgr, long customDepthOnlyRequestMgrCPP)
		{
			// // Void CleanUnused(HGRenderGraph, CustomDepthOnlyRequestManager, Int64)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGCamera::CleanUnused(
			//         HGRenderGraph *renderGraph,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   int64_t v4; // r13
			//   HGRenderGraph *v6; // r12
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   struct HGCamera__Class *v13; // rax
			//   Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *s_Cameras; // rbx
			//   struct MethodInfo *v15; // rdi
			//   __int64 v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Dictionary_2_TKey_TValue_ValueCollection_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *v19; // rsi
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   Dictionary_2_TKey_TValue_KeyCollection_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *keys; // rbx
			//   Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *dictionary; // rbx
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   _BYTE *v27; // rdx
			//   OneofDescriptor__Class *v28; // rcx
			//   ValueTuple_2_Object_Int32_ currentKey; // xmm6
			//   struct HGCamera__Class *v30; // rax
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v31; // rdi
			//   struct MethodInfo *v32; // rbx
			//   int32_t Entry; // eax
			//   __int64 v34; // rcx
			//   __int64 v35; // r8
			//   __int64 v36; // r9
			//   __int64 *v37; // rdx
			//   Dictionary_2_TKey_TValue_Entry_System_ValueTuple_2_Object_Int32_System_Object___Array *entries; // rax
			//   Object *value; // rsi
			//   Object__Class *klass; // rdi
			//   unsigned int v41; // r8d
			//   __int64 v42; // rbx
			//   void (__fastcall __noreturn **v43)(); // rax
			//   unsigned int v44; // eax
			//   unsigned int v45; // r8d
			//   __int64 v46; // rax
			//   unsigned int *v47; // rdx
			//   signed __int64 v48; // r9
			//   char v49; // r8
			//   __int64 v50; // rtt
			//   __int64 v51; // rbx
			//   __int64 v52; // rax
			//   __int64 v53; // rbx
			//   _QWORD **v54; // rcx
			//   __int64 v55; // r8
			//   __int64 v56; // rax
			//   unsigned int v57; // r8d
			//   __int64 v58; // rbx
			//   void (__fastcall __noreturn **v59)(); // rax
			//   unsigned int v60; // eax
			//   unsigned int v61; // r8d
			//   __int64 v62; // rax
			//   unsigned int *v63; // rdx
			//   signed __int64 v64; // r9
			//   char v65; // r8
			//   __int64 v66; // rtt
			//   __int64 v67; // rbx
			//   __int64 v68; // rax
			//   __int64 v69; // rbx
			//   _QWORD **v70; // rcx
			//   __int64 v71; // r8
			//   __int64 v72; // rax
			//   struct Object_1__Class *v73; // rcx
			//   Object__Class *v74; // rbx
			//   unsigned int (__fastcall *v75)(Object__Class *); // rax
			//   Object__Class *v76; // rdi
			//   unsigned int v77; // r8d
			//   __int64 v78; // rbx
			//   void (__fastcall __noreturn **v79)(); // rax
			//   unsigned int v80; // eax
			//   unsigned int v81; // r8d
			//   __int64 v82; // rax
			//   unsigned int *v83; // rdx
			//   signed __int64 v84; // r9
			//   char v85; // r8
			//   __int64 v86; // rtt
			//   __int64 v87; // rbx
			//   __int64 v88; // rax
			//   __int64 v89; // rbx
			//   _QWORD **v90; // rcx
			//   __int64 v91; // r8
			//   __int64 v92; // rax
			//   signed __int64 v93; // rcx
			//   __int64 v94; // rbx
			//   __int64 v95; // rax
			//   unsigned int *v96; // rdx
			//   signed __int64 v97; // r9
			//   char v98; // r8
			//   __int64 v99; // rtt
			//   __int64 v100; // rax
			//   struct Object_1__Class *v101; // rcx
			//   Object__Class *v102; // rax
			//   int events_low; // edi
			//   Object_1 *v104; // rbx
			//   __int64 v105; // rdx
			//   __int64 v106; // rcx
			//   Object__Class *v107; // rbx
			//   unsigned __int8 (__fastcall *v108)(Object__Class *); // rax
			//   __int64 v109; // rcx
			//   Camera *v110; // rcx
			//   struct HGCamera__Class *v111; // rax
			//   List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *s_Cleanup; // rcx
			//   Object_1 *v113; // rbx
			//   __int64 v114; // rdx
			//   __int64 v115; // rcx
			//   Object__Class *v116; // rbx
			//   __int64 (__fastcall *v117)(Object__Class *); // rax
			//   __int64 v118; // rdx
			//   Object *v119; // rbx
			//   __int64 *v120; // rdx
			//   signed __int64 v121; // rcx
			//   struct HGCamera__Class *v122; // rax
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v123; // r10
			//   __int64 v124; // rtt
			//   __int64 v125; // rdx
			//   __int64 v126; // rdx
			//   __int64 v127; // rcx
			//   struct HGCamera__Class *v128; // rax
			//   List_1_System_ValueTuple_2_UnityEngine_Camera_Int32_ *v129; // r9
			//   __int64 *v130; // rdx
			//   __int64 v131; // rtt
			//   __int64 v132; // rcx
			//   ValueTuple_2_Object_Int32_ v133; // xmm6
			//   struct HGCamera__Class *v134; // rax
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *v135; // rdi
			//   struct MethodInfo *v136; // rbx
			//   int32_t v137; // eax
			//   __int64 v138; // rcx
			//   __int64 v139; // r8
			//   __int64 v140; // r9
			//   __int64 v141; // rdx
			//   Dictionary_2_TKey_TValue_Entry_System_ValueTuple_2_Object_Int32_System_Object___Array *v142; // rax
			//   HGCamera *v143; // rcx
			//   __int64 v144; // rdx
			//   Dictionary_2_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *v145; // rcx
			//   struct HGCamera__Class *v146; // rax
			//   int32_t namespaze; // r8d
			//   __int64 v148; // rax
			//   __int64 v149; // r8
			//   Object *v150; // rax
			//   __int64 v151; // rax
			//   __int64 v152; // rax
			//   __int64 v153; // rax
			//   __int64 v154; // rax
			//   __int64 v155; // r8
			//   Object *v156; // rax
			//   _BYTE v157[32]; // [rsp+0h] [rbp-148h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-128h]
			//   String *v159; // [rsp+28h] [rbp-120h]
			//   ValueTuple_2_Object_Int32_ v160; // [rsp+30h] [rbp-118h] BYREF
			//   ValueTuple_2_Object_Int32_ v161; // [rsp+40h] [rbp-108h] BYREF
			//   OneofDescriptor v162; // [rsp+50h] [rbp-F8h] BYREF
			//   int v163; // [rsp+A8h] [rbp-A0h] BYREF
			//   int v164; // [rsp+B8h] [rbp-90h] BYREF
			//   Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_ValueTuple_2_Object_Int32_System_Object_ v165; // [rsp+C8h] [rbp-80h] BYREF
			//   Il2CppExceptionWrapper *v166; // [rsp+E8h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v167; // [rsp+F0h] [rbp-58h] BYREF
			// 
			//   v4 = customDepthOnlyRequestMgrCPP;
			//   v6 = renderGraph;
			//   if ( !byte_18D8EDA17 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Keys);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<UnityEngine::Camera,int>::ValueTuple);
			//     byte_18D8EDA17 = 1;
			//   }
			//   memset(&v162.fields._._File_k__BackingField, 0, 40);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, customDepthOnlyRequestMgr);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, customDepthOnlyRequestMgr);
			//   if ( wrapperArray.max_length.size <= 556 )
			//     goto LABEL_16;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, customDepthOnlyRequestMgr);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = v7.static_fields.wrapperArray;
			//   if ( !v9 )
			//     sub_180B536AC(v7, customDepthOnlyRequestMgr);
			//   if ( v9.max_length.size <= 0x22Cu )
			//     sub_180070270(v7, customDepthOnlyRequestMgr);
			//   if ( v9[15].vector[16] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(556, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_92(
			//       (ILFixDynamicMethodWrapper_14 *)Patch,
			//       (Object *)v6,
			//       (Object *)customDepthOnlyRequestMgr,
			//       v4,
			//       0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, customDepthOnlyRequestMgr);
			//       v13 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     s_Cameras = v13.static_fields.s_Cameras;
			//     if ( !s_Cameras )
			//       sub_180B536AC(v7, customDepthOnlyRequestMgr);
			//     v15 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Keys;
			//     if ( !s_Cameras.fields._keys )
			//     {
			//       v16 = ((__int64 (__fastcall *)(_QWORD))sub_18010B520)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Keys.klass.rgctx_data[18].rgctxDataDummy);
			//       v19 = (Dictionary_2_TKey_TValue_ValueCollection_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *)sub_180004920(v16);
			//       if ( !v19 )
			//         sub_180B536AC(v18, v17);
			//       if ( !*((_QWORD *)v15.klass.rgctx_data[19].rgctxDataDummy + 4) )
			//         (*(void (**)(void))v15.klass.rgctx_data[19].rgctxDataDummy)();
			//       System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<Beyond::Gameplay::Core::WaterVolumePtr,Beyond::ObjectPtr<System::Object>>::ValueCollection(
			//         v19,
			//         (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_Beyond_ObjectPtr_1_System_Object_ *)s_Cameras,
			//         (MethodInfo *)v15.klass.rgctx_data[19].rgctxDataDummy);
			//       s_Cameras.fields._keys = (Dictionary_2_TKey_TValue_KeyCollection_System_ValueTuple_2_UnityEngine_Camera_Int32_HG_Rendering_Runtime_HGCamera_ *)v19;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&s_Cameras.fields._keys,
			//         v20,
			//         v21,
			//         v22,
			//         (String__Array *)methoda,
			//         v159,
			//         (MethodInfo *)v160.Item1);
			//     }
			//     keys = s_Cameras.fields._keys;
			//     if ( !keys )
			//       sub_180B536AC(v7, customDepthOnlyRequestMgr);
			//     dictionary = keys.fields._dictionary;
			//     memset(&v162.monitor, 0, 24);
			//     v162.klass = (OneofDescriptor__Class *)dictionary;
			//     sub_1800054D0(
			//       &v162,
			//       (OneofDescriptorProto *)customDepthOnlyRequestMgr,
			//       (FileDescriptor *)customDepthOnlyRequestMgrCPP,
			//       (MessageDescriptor *)method,
			//       (String__Array *)methoda,
			//       v159,
			//       (MethodInfo *)v160.Item1);
			//     if ( !dictionary )
			//       sub_180B536AC(v26, v25);
			//     HIDWORD(v162.monitor) = dictionary.fields._version;
			//     LODWORD(v162.monitor) = 0;
			//     *(_OWORD *)&v162.fields._._Index_k__BackingField = 0LL;
			//     *(_OWORD *)&v165._dictionary = *(_OWORD *)&v162.klass;
			//     v165._currentKey = 0LL;
			//     v162.klass = 0LL;
			//     v162.monitor = (MonitorData *)&v165;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<System::Object,int>,System::Object>::MoveNext(
			//                 &v165,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::MoveNext) )
			//       {
			//         currentKey = v165._currentKey;
			//         v30 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v27);
			//           v30 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//         }
			//         v31 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v30.static_fields.s_Cameras;
			//         if ( !v31 )
			//           sub_1802DC2C8(v28, v27);
			//         v32 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item;
			//         if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy
			//               + 4) )
			//           (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy)();
			//         v160 = currentKey;
			//         Entry = System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::FindEntry(
			//                   v31,
			//                   &v160,
			//                   (MethodInfo *)v32.klass.rgctx_data[22].rgctxDataDummy);
			//         v37 = (__int64 *)Entry;
			//         if ( Entry < 0 )
			//         {
			//           v161 = currentKey;
			//           v148 = sub_180313188(v32.klass.rgctx_data, 23LL);
			//           v150 = (Object *)il2cpp_value_box(v148, &v161, v149);
			//           System::ThrowHelper::ThrowKeyNotFoundException(v150, 0LL);
			//         }
			//         entries = v31.fields._entries;
			//         if ( !entries )
			//           sub_1802DC2C8(v34, v37);
			//         if ( (unsigned int)v37 >= entries.max_length.size )
			//           sub_180070260(v37, v37, v35, v36);
			//         value = entries.vector[(_QWORD)v37].value;
			//         if ( !value )
			//           sub_1802DC2C8(32LL * (_QWORD)v37, v37);
			//         klass = value[6].klass;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//         if ( !byte_18D8F4EFB )
			//         {
			//           v41 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//           if ( (v41 & 1) != 0 )
			//           {
			//             v42 = (v41 >> 1) & 0xFFFFFFF;
			//             switch ( v41 >> 29 )
			//             {
			//               case 1u:
			//                 v43 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v42);
			//                 goto LABEL_67;
			//               case 2u:
			//                 v43 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v42);
			//                 goto LABEL_67;
			//               case 3u:
			//               case 6u:
			//                 v44 = (v41 >> 1) & 0xFFFFFFF;
			//                 v45 = v41 >> 29;
			//                 if ( v45 )
			//                 {
			//                   if ( v45 == 3 )
			//                   {
			//                     v43 = (void (__fastcall __noreturn **)())sub_180039480(v44);
			//                     goto LABEL_67;
			//                   }
			//                   if ( v45 == 6 )
			//                   {
			//                     v46 = sub_1802DF9C0(v44);
			//                     v43 = (void (__fastcall __noreturn **)())sub_18005F4B0(v46, 0LL);
			//                     goto LABEL_67;
			//                   }
			//                 }
			//                 else if ( v44 == 1 )
			//                 {
			//                   v43 = off_18A2C5600;
			//                   goto LABEL_67;
			//                 }
			// LABEL_66:
			//                 v43 = 0LL;
			// LABEL_67:
			//                 if ( v43 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v43);
			//                 break;
			//               case 4u:
			//                 v43 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v42);
			//                 goto LABEL_67;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v42) )
			//                 {
			//                   v43 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v42);
			//                 }
			//                 else
			//                 {
			//                   v47 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v42);
			//                   v48 = il2cpp_string_new_len(qword_18D8E5198 + (int)v47[1] + *(int *)(qword_18D8E51A0 + 16), *v47);
			//                   v43 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v42),
			//                                                              v48,
			//                                                              0LL);
			//                   if ( !v43 )
			//                   {
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v37 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v42) >> 12) & 0x1FFFFF) >> 6];
			//                       v49 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v42) >> 12) & 0x3F;
			//                       _m_prefetchw(v37);
			//                       do
			//                         v50 = *v37;
			//                       while ( v50 != _InterlockedCompareExchange64(v37, *v37 | (1LL << v49), *v37) );
			//                     }
			//                     v43 = (void (__fastcall __noreturn **)())v48;
			//                   }
			//                 }
			//                 goto LABEL_67;
			//               case 7u:
			//                 v51 = sub_1802DF920((unsigned int)v42);
			//                 v52 = *(_QWORD *)(v51 + 16);
			//                 v53 = (v51 - *(_QWORD *)(v52 + 128)) >> 5;
			//                 if ( *(_BYTE *)(v52 + 42) == 21 )
			//                 {
			//                   v54 = *(_QWORD ***)(v52 + 96);
			//                   if ( *v54 )
			//                   {
			//                     v55 = **v54 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                     v52 = sub_180039550(v55 / 92 + v55);
			//                   }
			//                   else
			//                   {
			//                     v52 = 0LL;
			//                   }
			//                 }
			//                 *(_DWORD *)&v162.fields._IsSynthetic_k__BackingField = v53 + *(_DWORD *)(*(_QWORD *)(v52 + 104) + 32LL);
			//                 v56 = sub_1801B8ECC(
			//                         (unsigned int)&v162.fields._IsSynthetic_k__BackingField,
			//                         (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                         *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                         12,
			//                         (__int64)sub_1802C7760);
			//                 if ( !v56 )
			//                   goto LABEL_66;
			//                 v37 = (__int64 *)*(unsigned int *)(v56 + 8);
			//                 if ( (_DWORD)v37 == -1 )
			//                   goto LABEL_66;
			//                 v43 = (void (__fastcall __noreturn **)())((char *)v37 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                 goto LABEL_67;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8F4EFB = 1;
			//         }
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//         if ( !byte_18D8F4EAF )
			//         {
			//           v57 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//           if ( (v57 & 1) != 0 )
			//           {
			//             v58 = (v57 >> 1) & 0xFFFFFFF;
			//             switch ( v57 >> 29 )
			//             {
			//               case 1u:
			//                 v59 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v58);
			//                 goto LABEL_100;
			//               case 2u:
			//                 v59 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v58);
			//                 goto LABEL_100;
			//               case 3u:
			//               case 6u:
			//                 v60 = (v57 >> 1) & 0xFFFFFFF;
			//                 v61 = v57 >> 29;
			//                 if ( v61 )
			//                 {
			//                   if ( v61 == 3 )
			//                   {
			//                     v59 = (void (__fastcall __noreturn **)())sub_180039480(v60);
			//                     goto LABEL_100;
			//                   }
			//                   if ( v61 == 6 )
			//                   {
			//                     v62 = sub_1802DF9C0(v60);
			//                     v59 = (void (__fastcall __noreturn **)())sub_18005F4B0(v62, 0LL);
			//                     goto LABEL_100;
			//                   }
			//                 }
			//                 else if ( v60 == 1 )
			//                 {
			//                   v59 = off_18A2C5600;
			//                   goto LABEL_100;
			//                 }
			// LABEL_99:
			//                 v59 = 0LL;
			// LABEL_100:
			//                 if ( v59 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v59);
			//                 break;
			//               case 4u:
			//                 v59 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v58);
			//                 goto LABEL_100;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v58) )
			//                 {
			//                   v59 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v58);
			//                 }
			//                 else
			//                 {
			//                   v63 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v58);
			//                   v64 = il2cpp_string_new_len(qword_18D8E5198 + (int)v63[1] + *(int *)(qword_18D8E51A0 + 16), *v63);
			//                   v59 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v58),
			//                                                              v64,
			//                                                              0LL);
			//                   if ( !v59 )
			//                   {
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v37 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v58) >> 12) & 0x1FFFFF) >> 6];
			//                       v65 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v58) >> 12) & 0x3F;
			//                       _m_prefetchw(v37);
			//                       do
			//                         v66 = *v37;
			//                       while ( v66 != _InterlockedCompareExchange64(v37, *v37 | (1LL << v65), *v37) );
			//                     }
			//                     v59 = (void (__fastcall __noreturn **)())v64;
			//                   }
			//                 }
			//                 goto LABEL_100;
			//               case 7u:
			//                 v67 = sub_1802DF920((unsigned int)v58);
			//                 v68 = *(_QWORD *)(v67 + 16);
			//                 v69 = (v67 - *(_QWORD *)(v68 + 128)) >> 5;
			//                 if ( *(_BYTE *)(v68 + 42) == 21 )
			//                 {
			//                   v70 = *(_QWORD ***)(v68 + 96);
			//                   if ( *v70 )
			//                   {
			//                     v71 = **v70 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                     v68 = sub_180039550(v71 / 92 + v71);
			//                   }
			//                   else
			//                   {
			//                     v68 = 0LL;
			//                   }
			//                 }
			//                 v163 = v69 + *(_DWORD *)(*(_QWORD *)(v68 + 104) + 32LL);
			//                 v72 = sub_1801B8ECC(
			//                         (unsigned int)&v163,
			//                         (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                         *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                         12,
			//                         (__int64)sub_1802C7760);
			//                 if ( !v72 )
			//                   goto LABEL_99;
			//                 v37 = (__int64 *)*(unsigned int *)(v72 + 8);
			//                 if ( (_DWORD)v37 == -1 )
			//                   goto LABEL_99;
			//                 v59 = (void (__fastcall __noreturn **)())((char *)v37 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                 goto LABEL_100;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8F4EAF = 1;
			//         }
			//         if ( klass )
			//         {
			//           v73 = TypeInfo::UnityEngine::Object;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//           if ( klass._0.name )
			//           {
			//             v74 = value[6].klass;
			//             if ( !v74 )
			//               sub_1802DC2C8(v73, v37);
			//             v75 = (unsigned int (__fastcall *)(Object__Class *))qword_18D8F4200;
			//             if ( !qword_18D8F4200 )
			//             {
			//               v75 = (unsigned int (__fastcall *)(Object__Class *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//               if ( !v75 )
			//               {
			//                 v151 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//                 sub_18000F750(v151, 0LL);
			//               }
			//               qword_18D8F4200 = (__int64)v75;
			//             }
			//             if ( v75(v74) == 2 )
			//               continue;
			//           }
			//         }
			//         v76 = value[172].klass;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//         if ( !byte_18D8F4EFB )
			//         {
			//           v77 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//           if ( (v77 & 1) != 0 )
			//           {
			//             v78 = (v77 >> 1) & 0xFFFFFFF;
			//             switch ( v77 >> 29 )
			//             {
			//               case 1u:
			//                 v79 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v78);
			//                 goto LABEL_142;
			//               case 2u:
			//                 v79 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v78);
			//                 goto LABEL_142;
			//               case 3u:
			//               case 6u:
			//                 v80 = (v77 >> 1) & 0xFFFFFFF;
			//                 v81 = v77 >> 29;
			//                 if ( v81 )
			//                 {
			//                   if ( v81 == 3 )
			//                   {
			//                     v79 = (void (__fastcall __noreturn **)())sub_180039480(v80);
			//                     goto LABEL_142;
			//                   }
			//                   if ( v81 == 6 )
			//                   {
			//                     v82 = sub_1802DF9C0(v80);
			//                     v79 = (void (__fastcall __noreturn **)())sub_18005F4B0(v82, 0LL);
			//                     goto LABEL_142;
			//                   }
			//                 }
			//                 else if ( v80 == 1 )
			//                 {
			//                   v79 = off_18A2C5600;
			//                   goto LABEL_142;
			//                 }
			// LABEL_141:
			//                 v79 = 0LL;
			// LABEL_142:
			//                 if ( v79 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v79);
			//                 break;
			//               case 4u:
			//                 v79 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v78);
			//                 goto LABEL_142;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v78) )
			//                 {
			//                   v79 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v78);
			//                 }
			//                 else
			//                 {
			//                   v83 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v78);
			//                   v84 = il2cpp_string_new_len(qword_18D8E5198 + (int)v83[1] + *(int *)(qword_18D8E51A0 + 16), *v83);
			//                   v79 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v78),
			//                                                              v84,
			//                                                              0LL);
			//                   if ( !v79 )
			//                   {
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v37 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v78) >> 12) & 0x1FFFFF) >> 6];
			//                       v85 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v78) >> 12) & 0x3F;
			//                       _m_prefetchw(v37);
			//                       do
			//                         v86 = *v37;
			//                       while ( v86 != _InterlockedCompareExchange64(v37, *v37 | (1LL << v85), *v37) );
			//                     }
			//                     v79 = (void (__fastcall __noreturn **)())v84;
			//                   }
			//                 }
			//                 goto LABEL_142;
			//               case 7u:
			//                 v87 = sub_1802DF920((unsigned int)v78);
			//                 v88 = *(_QWORD *)(v87 + 16);
			//                 v89 = (v87 - *(_QWORD *)(v88 + 128)) >> 5;
			//                 if ( *(_BYTE *)(v88 + 42) == 21 )
			//                 {
			//                   v90 = *(_QWORD ***)(v88 + 96);
			//                   if ( *v90 )
			//                   {
			//                     v91 = **v90 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                     v88 = sub_180039550(v91 / 92 + v91);
			//                   }
			//                   else
			//                   {
			//                     v88 = 0LL;
			//                   }
			//                 }
			//                 v164 = v89 + *(_DWORD *)(*(_QWORD *)(v88 + 104) + 32LL);
			//                 v92 = sub_1801B8ECC(
			//                         (unsigned int)&v164,
			//                         (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                         *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                         12,
			//                         (__int64)sub_1802C7760);
			//                 if ( !v92 )
			//                   goto LABEL_141;
			//                 v37 = (__int64 *)*(unsigned int *)(v92 + 8);
			//                 if ( (_DWORD)v37 == -1 )
			//                   goto LABEL_141;
			//                 v79 = (void (__fastcall __noreturn **)())((char *)v37 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                 goto LABEL_142;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8F4EFB = 1;
			//         }
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//         if ( !byte_18D8F4EAF )
			//         {
			//           v93 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//           if ( (v93 & 1) != 0 )
			//           {
			//             v94 = ((unsigned int)v93 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v93 >> 29 )
			//             {
			//               case 1u:
			//                 v95 = sub_18003C670((unsigned int)v94);
			//                 goto LABEL_162;
			//               case 2u:
			//                 v95 = sub_18003C380((unsigned int)v94);
			//                 goto LABEL_162;
			//               case 3u:
			//               case 6u:
			//                 v95 = sub_1802DFAE0(v93);
			//                 goto LABEL_162;
			//               case 4u:
			//                 v95 = sub_1802DF920((unsigned int)v94);
			//                 goto LABEL_162;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v94) )
			//                 {
			//                   v95 = *(_QWORD *)(qword_18D8F6F98 + 8 * v94);
			//                 }
			//                 else
			//                 {
			//                   v96 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v94);
			//                   v97 = il2cpp_string_new_len(qword_18D8E5198 + (int)v96[1] + *(int *)(qword_18D8E51A0 + 16), *v96);
			//                   v95 = _InterlockedCompareExchange64((volatile signed __int64 *)(qword_18D8F6F98 + 8 * v94), v97, 0LL);
			//                   if ( !v95 )
			//                   {
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v37 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v94) >> 12) & 0x1FFFFF) >> 6];
			//                       v98 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v94) >> 12) & 0x3F;
			//                       _m_prefetchw(v37);
			//                       do
			//                         v99 = *v37;
			//                       while ( v99 != _InterlockedCompareExchange64(v37, *v37 | (1LL << v98), *v37) );
			//                     }
			//                     v95 = v97;
			//                   }
			//                 }
			//                 goto LABEL_162;
			//               case 7u:
			//                 v100 = sub_1802DF920((unsigned int)v94);
			//                 v95 = sub_18003D1A0(v100, &v160);
			// LABEL_162:
			//                 if ( v95 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, v95);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8F4EAF = 1;
			//         }
			//         if ( !v76 )
			//           goto LABEL_171;
			//         v101 = TypeInfo::UnityEngine::Object;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//         if ( v76._0.name )
			//         {
			//           v102 = value[172].klass;
			//           if ( !v102 )
			//             sub_1802DC2C8(v101, v37);
			//           events_low = LOBYTE(v102._0.events);
			//         }
			//         else
			//         {
			// LABEL_171:
			//           events_low = 0;
			//         }
			//         v104 = (Object_1 *)value[6].klass;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v37);
			//         if ( UnityEngine::Object::op_Equality(v104, 0LL, 0LL) )
			//           goto LABEL_184;
			//         v107 = value[6].klass;
			//         if ( !v107 )
			//           sub_1802DC2C8(v106, v105);
			//         v108 = (unsigned __int8 (__fastcall *)(Object__Class *))qword_18D8F4D38;
			//         if ( !qword_18D8F4D38 )
			//         {
			//           v108 = (unsigned __int8 (__fastcall *)(Object__Class *))il2cpp_resolve_icall_0("UnityEngine.Behaviour::get_isActiveAndEnabled()");
			//           if ( !v108 )
			//           {
			//             v152 = sub_1802DBBE8("UnityEngine.Behaviour::get_isActiveAndEnabled()");
			//             sub_18000F750(v152, 0LL);
			//           }
			//           qword_18D8F4D38 = (__int64)v108;
			//         }
			//         if ( !v108(v107) )
			//         {
			//           v110 = (Camera *)value[6].klass;
			//           if ( !v110 )
			//             sub_1802DC2C8(0LL, v105);
			//           if ( UnityEngine::Camera::get_cameraType(v110, 0LL) != CameraType__Enum_Preview
			//             && !events_low
			//             && !BYTE5(value[146].monitor) )
			//           {
			// LABEL_184:
			//             v111 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//             {
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v105);
			//               v111 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//             }
			//             s_Cleanup = v111.static_fields.s_Cleanup;
			//             if ( !s_Cleanup )
			//               sub_1802DC2C8(0LL, v105);
			//             v160 = currentKey;
			//             sub_1831EBA40(
			//               s_Cleanup,
			//               &v160,
			//               MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Camera,int>>::Add);
			//           }
			//         }
			//         if ( !v6 )
			//           sub_1802DC2C8(v109, v105);
			//         if ( v6.fields._enableCppRenderPath_k__BackingField )
			//         {
			//           v113 = (Object_1 *)value[6].klass;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v105);
			//           if ( UnityEngine::Object::op_Inequality(v113, 0LL, 0LL) )
			//           {
			//             v116 = value[6].klass;
			//             if ( !v116 )
			//               sub_1802DC2C8(v115, v114);
			//             v117 = (__int64 (__fastcall *)(Object__Class *))qword_18D8F4280;
			//             if ( !qword_18D8F4280 )
			//             {
			//               v117 = (__int64 (__fastcall *)(Object__Class *))il2cpp_resolve_icall_0("UnityEngine.Camera::GetLightWeightCamera()");
			//               if ( !v117 )
			//               {
			//                 v153 = sub_1802DBBE8("UnityEngine.Camera::GetLightWeightCamera()");
			//                 sub_18000F750(v153, 0LL);
			//               }
			//               qword_18D8F4280 = (__int64)v117;
			//             }
			//             v119 = (Object *)v117(v116);
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v118);
			//             if ( UnityEngine::Object::op_Inequality((Object_1 *)v119, 0LL, 0LL) )
			//             {
			//               v122 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//               if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//               {
			//                 il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v120);
			//                 v122 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//               }
			//               v123 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v122.static_fields.s_Cameras;
			//               *(_QWORD *)&v161.Item2 = 0LL;
			//               v161.Item1 = v119;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v120 = &qword_18D6870D0[(((unsigned __int64)&v161 >> 12) & 0x1FFFFF) >> 6];
			//                 _m_prefetchw(v120);
			//                 do
			//                 {
			//                   v121 = *v120 | (1LL << (((unsigned __int64)&v161 >> 12) & 0x3F));
			//                   v124 = *v120;
			//                 }
			//                 while ( v124 != _InterlockedCompareExchange64(v120, v121, *v120) );
			//               }
			//               v161.Item2 = 0;
			//               if ( !v123 )
			//                 sub_1802DC2C8(v121, v120);
			//               v160 = v161;
			//               if ( System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
			//                      v123,
			//                      &v160,
			//                      (Object **)&v162.fields._._File_k__BackingField,
			//                      MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::TryGetValue) )
			//               {
			//                 if ( !v162.fields._._File_k__BackingField )
			//                   sub_1802DC2C8(0LL, v125);
			//                 if ( v162.fields._._File_k__BackingField[17].fields._MessageTypes_k__BackingField )
			//                 {
			//                   UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::HGRenderPath_Destroy(
			//                     (int64_t)v162.fields._._File_k__BackingField[17].fields._MessageTypes_k__BackingField,
			//                     0LL);
			//                   if ( !v162.fields._._File_k__BackingField )
			//                     sub_1802DC2C8(v127, v126);
			//                   v162.fields._._File_k__BackingField[17].fields._MessageTypes_k__BackingField = 0LL;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v166 )
			//     {
			//       v27 = v157;
			//       v162.klass = (OneofDescriptor__Class *)v166.ex;
			//       v28 = v162.klass;
			//       if ( v162.klass )
			//         sub_18000F780(v162.klass);
			//       v4 = customDepthOnlyRequestMgrCPP;
			//       v6 = renderGraph;
			//     }
			//     v128 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v27);
			//       v128 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     v129 = v128.static_fields.s_Cleanup;
			//     if ( !v129 )
			//       goto LABEL_238;
			//     memset(&v162.monitor, 0, 24);
			//     v162.klass = (OneofDescriptor__Class *)v129;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v130 = (__int64 *)(0x180000000LL + 8 * ((((unsigned __int64)&v162 >> 12) & 0x1FFFFF) >> 6) + 224948432);
			//       _m_prefetchw(v130);
			//       do
			//         v131 = *v130;
			//       while ( v131 != _InterlockedCompareExchange64(
			//                         v130,
			//                         *v130 | (1LL << (((unsigned __int64)&v162 >> 12) & 0x3F)),
			//                         *v130) );
			//     }
			//     LODWORD(v162.monitor) = 0;
			//     HIDWORD(v162.monitor) = v129.fields._version;
			//     *(_OWORD *)&v162.fields.containingType = *(_OWORD *)&v162.klass;
			//     *(_OWORD *)&v162.fields.accessor = 0LL;
			//     v162.klass = 0LL;
			//     v162.monitor = (MonitorData *)&v162.fields.containingType;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,int>>::MoveNext(
			//                 (List_1_T_Enumerator_System_ValueTuple_2_Object_Int32_ *)&v162.fields.containingType,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<UnityEngine::Camera,int>>::MoveNext) )
			//       {
			//         v133 = *(ValueTuple_2_Object_Int32_ *)&v162.fields.accessor;
			//         v134 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v27);
			//           v134 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//         }
			//         v135 = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v134.static_fields.s_Cameras;
			//         if ( !v135 )
			//           sub_1802DC2C8(v132, v27);
			//         v136 = MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item;
			//         if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy
			//               + 4) )
			//           (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy)();
			//         v161 = v133;
			//         v137 = System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::FindEntry(
			//                  v135,
			//                  &v161,
			//                  (MethodInfo *)v136.klass.rgctx_data[22].rgctxDataDummy);
			//         v141 = v137;
			//         if ( v137 < 0 )
			//         {
			//           v161 = v133;
			//           v154 = sub_180313188(v136.klass.rgctx_data, 23LL);
			//           v156 = (Object *)il2cpp_value_box(v154, &v161, v155);
			//           System::ThrowHelper::ThrowKeyNotFoundException(v156, 0LL);
			//         }
			//         v142 = v135.fields._entries;
			//         if ( !v142 )
			//           sub_1802DC2C8(v138, v141);
			//         if ( (unsigned int)v141 >= v142.max_length.size )
			//           sub_180070260(v141, v141, v139, v140);
			//         v143 = (HGCamera *)v142.vector[v141].value;
			//         if ( !v143 )
			//           sub_1802DC2C8(0LL, v141);
			//         HG::Rendering::Runtime::HGCamera::Dispose(v143, v6, customDepthOnlyRequestMgr, v4, 0LL);
			//         v145 = TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.s_Cameras;
			//         if ( !v145 )
			//           sub_1802DC2C8(0LL, v144);
			//         v161 = v133;
			//         System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::Remove(
			//           (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v145,
			//           &v161,
			//           MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::Remove);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v167 )
			//     {
			//       v27 = v157;
			//       v162.klass = (OneofDescriptor__Class *)v167.ex;
			//       if ( v162.klass )
			//         sub_18000F780(v162.klass);
			//     }
			//     v146 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v27);
			//       v146 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     v28 = (OneofDescriptor__Class *)v146.static_fields.s_Cleanup;
			//     if ( !v28 )
			// LABEL_238:
			//       sub_1802DC2C8(v28, v27);
			//     ++HIDWORD(v28._0.namespaze);
			//     namespaze = (int32_t)v28._0.namespaze;
			//     LODWORD(v28._0.namespaze) = 0;
			//     if ( namespaze > 0 )
			//       System::Array::Clear((Array *)v28._0.name, 0, namespaze, 0LL);
			//   }
			// }
			// 
		}

		internal static bool IsLargeCameraMovement(in HGCamera.ViewConstants viewConstants, float cameraRotationThreshold, float cameraPositionThreshold)
		{
			// // Boolean IsLargeCameraMovement(HGCamera+ViewConstants ByRef, Single, Single)
			// bool HG::Rendering::Runtime::HGCamera::IsLargeCameraMovement(
			//         HGCamera_ViewConstants *viewConstants,
			//         float cameraRotationThreshold,
			//         float cameraPositionThreshold,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double v9; // xmm0_8
			//   __int128 v10; // xmm2
			//   __int128 v11; // xmm1
			//   float v12; // xmm11_4
			//   __int128 v13; // xmm2
			//   Vector4 v14; // xmm8
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   Vector4 *Column; // rax
			//   MethodInfo *v19; // r8
			//   __int128 v20; // xmm3
			//   __int128 v21; // xmm2
			//   float v22; // xmm9_4
			//   __int128 v23; // xmm1
			//   Vector4 v24; // xmm8
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   Vector4 *v28; // rax
			//   MethodInfo *v29; // r8
			//   __int128 v30; // xmm3
			//   __int128 v31; // xmm2
			//   float v32; // xmm12_4
			//   __int128 v33; // xmm1
			//   Vector4 v34; // xmm8
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   Vector4 v38; // xmm0
			//   float z; // eax
			//   float v40; // eax
			//   MethodInfo *v41; // r9
			//   Vector3 *v42; // rax
			//   MethodInfo *v43; // rdx
			//   MethodInfo *v44; // r8
			//   float sqrMagnitude; // xmm3_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v48; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector3 v49; // [rsp+48h] [rbp-C0h] BYREF
			//   Matrix4x4 v50; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector4 v51; // [rsp+98h] [rbp-70h] BYREF
			//   Vector3 v52; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v53; // [rsp+B8h] [rbp-50h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size > 715 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x2CB )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !v7[15]._0.interopData )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(715, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_271(
			//                  Patch,
			//                  viewConstants,
			//                  cameraRotationThreshold,
			//                  cameraPositionThreshold,
			//                  0LL);
			//     }
			// LABEL_12:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_7:
			//   v9 = Beyond::DampingMath::cosf();
			//   v10 = *(_OWORD *)&viewConstants.viewMatrix.m01;
			//   *(_OWORD *)&v50.m00 = *(_OWORD *)&viewConstants.viewMatrix.m00;
			//   v11 = *(_OWORD *)&viewConstants.viewMatrix.m02;
			//   *(_OWORD *)&v50.m01 = v10;
			//   v12 = *(float *)&v9;
			//   v13 = *(_OWORD *)&viewConstants.viewMatrix.m03;
			//   *(_OWORD *)&v50.m02 = v11;
			//   *(_OWORD *)&v50.m03 = v13;
			//   v14 = *UnityEngine::Matrix4x4::GetColumn(&v51, &v50, 0, 0LL);
			//   v15 = *(_OWORD *)&viewConstants.prevViewMatrix.m01;
			//   *(_OWORD *)&v50.m00 = *(_OWORD *)&viewConstants.prevViewMatrix.m00;
			//   v16 = *(_OWORD *)&viewConstants.prevViewMatrix.m02;
			//   *(_OWORD *)&v50.m01 = v15;
			//   v17 = *(_OWORD *)&viewConstants.prevViewMatrix.m03;
			//   *(_OWORD *)&v50.m02 = v16;
			//   *(_OWORD *)&v50.m03 = v17;
			//   Column = UnityEngine::Matrix4x4::GetColumn(&v51, &v50, 0, 0LL);
			//   LODWORD(v13) = _mm_shuffle_ps(*(__m128 *)Column, *(__m128 *)Column, 170).m128_u32[0];
			//   *(_QWORD *)&v49.x = _mm_unpacklo_ps(*(__m128 *)Column, _mm_shuffle_ps(*(__m128 *)Column, *(__m128 *)Column, 85)).m128_u64[0];
			//   LODWORD(v49.z) = v13;
			//   *(_QWORD *)&v48.x = _mm_unpacklo_ps((__m128)v14, _mm_shuffle_ps((__m128)v14, (__m128)v14, 85)).m128_u64[0];
			//   LODWORD(v48.z) = _mm_shuffle_ps((__m128)v14, (__m128)v14, 170).m128_u32[0];
			//   *(float *)&v16 = UnityEngine::Vector3::Dot(&v48, &v49, v19);
			//   v20 = *(_OWORD *)&viewConstants.viewMatrix.m00;
			//   v21 = *(_OWORD *)&viewConstants.viewMatrix.m02;
			//   *(_OWORD *)&v50.m01 = *(_OWORD *)&viewConstants.viewMatrix.m01;
			//   v22 = *(float *)&v16;
			//   v23 = *(_OWORD *)&viewConstants.viewMatrix.m03;
			//   *(_OWORD *)&v50.m00 = v20;
			//   *(_OWORD *)&v50.m03 = v23;
			//   *(_OWORD *)&v50.m02 = v21;
			//   v24 = *UnityEngine::Matrix4x4::GetColumn(&v51, &v50, 1, 0LL);
			//   v25 = *(_OWORD *)&viewConstants.prevViewMatrix.m01;
			//   *(_OWORD *)&v50.m00 = *(_OWORD *)&viewConstants.prevViewMatrix.m00;
			//   v26 = *(_OWORD *)&viewConstants.prevViewMatrix.m02;
			//   *(_OWORD *)&v50.m01 = v25;
			//   v27 = *(_OWORD *)&viewConstants.prevViewMatrix.m03;
			//   *(_OWORD *)&v50.m02 = v26;
			//   *(_OWORD *)&v50.m03 = v27;
			//   v28 = UnityEngine::Matrix4x4::GetColumn(&v51, &v50, 1, 0LL);
			//   LODWORD(v21) = _mm_shuffle_ps(*(__m128 *)v28, *(__m128 *)v28, 170).m128_u32[0];
			//   *(_QWORD *)&v48.x = _mm_unpacklo_ps(*(__m128 *)v28, _mm_shuffle_ps(*(__m128 *)v28, *(__m128 *)v28, 85)).m128_u64[0];
			//   LODWORD(v48.z) = v21;
			//   *(_QWORD *)&v49.x = _mm_unpacklo_ps((__m128)v24, _mm_shuffle_ps((__m128)v24, (__m128)v24, 85)).m128_u64[0];
			//   LODWORD(v49.z) = _mm_shuffle_ps((__m128)v24, (__m128)v24, 170).m128_u32[0];
			//   *(float *)&v26 = UnityEngine::Vector3::Dot(&v49, &v48, v29);
			//   v30 = *(_OWORD *)&viewConstants.viewMatrix.m00;
			//   v31 = *(_OWORD *)&viewConstants.viewMatrix.m02;
			//   *(_OWORD *)&v50.m01 = *(_OWORD *)&viewConstants.viewMatrix.m01;
			//   v32 = *(float *)&v26;
			//   v33 = *(_OWORD *)&viewConstants.viewMatrix.m03;
			//   *(_OWORD *)&v50.m00 = v30;
			//   *(_OWORD *)&v50.m03 = v33;
			//   *(_OWORD *)&v50.m02 = v31;
			//   v34 = *UnityEngine::Matrix4x4::GetColumn(&v51, &v50, 2, 0LL);
			//   v35 = *(_OWORD *)&viewConstants.prevViewMatrix.m01;
			//   *(_OWORD *)&v50.m00 = *(_OWORD *)&viewConstants.prevViewMatrix.m00;
			//   v36 = *(_OWORD *)&viewConstants.prevViewMatrix.m02;
			//   *(_OWORD *)&v50.m01 = v35;
			//   v37 = *(_OWORD *)&viewConstants.prevViewMatrix.m03;
			//   *(_OWORD *)&v50.m02 = v36;
			//   *(_OWORD *)&v50.m03 = v37;
			//   v38 = *UnityEngine::Matrix4x4::GetColumn(&v51, &v50, 2, 0LL);
			//   z = viewConstants.worldSpaceCameraPos.z;
			//   *(_QWORD *)&v52.x = _mm_unpacklo_ps((__m128)v38, _mm_shuffle_ps((__m128)v38, (__m128)v38, 85)).m128_u64[0];
			//   v48.z = z;
			//   v40 = viewConstants.prevWorldSpaceCameraPos.z;
			//   *(_QWORD *)&v53.x = _mm_unpacklo_ps((__m128)v34, _mm_shuffle_ps((__m128)v34, (__m128)v34, 85)).m128_u64[0];
			//   *(_QWORD *)&v48.x = *(_QWORD *)&viewConstants.worldSpaceCameraPos.x;
			//   *(_QWORD *)&v49.x = *(_QWORD *)&viewConstants.prevWorldSpaceCameraPos.x;
			//   LODWORD(v52.z) = _mm_shuffle_ps((__m128)v38, (__m128)v38, 170).m128_u32[0];
			//   LODWORD(v53.z) = _mm_shuffle_ps((__m128)v34, (__m128)v34, 170).m128_u32[0];
			//   v49.z = v40;
			//   v42 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v51, &v49, &v48, v41);
			//   *(_QWORD *)&v30 = *(_QWORD *)&v42.x;
			//   *(float *)&v42 = v42.z;
			//   *(_QWORD *)&v48.x = v30;
			//   LODWORD(v48.z) = (_DWORD)v42;
			//   sqrMagnitude = UnityEngine::Vector3::get_sqrMagnitude(&v48, v43);
			//   return v12 > v22
			//       || v12 > v32
			//       || v12 > UnityEngine::Vector3::Dot(&v53, &v52, v44)
			//       || sqrMagnitude > (float)(cameraPositionThreshold * cameraPositionThreshold);
			// }
			// 
			return default(bool);
		}

		internal void PrepareBasicCameraTransforms(ref BasicTransformConstants basicTransformConstants, in Nullable<Matrix4x4> pretransformMatrix)
		{
			// // Void PrepareBasicCameraTransforms(BasicTransformConstants ByRef, Nullable`1[UnityEngine.Matrix4x4] ByRef)
			// void HG::Rendering::Runtime::HGCamera::PrepareBasicCameraTransforms(
			//         HGCamera *this,
			//         BasicTransformConstants *basicTransformConstants,
			//         Nullable_1_UnityEngine_Matrix4x4_ *pretransformMatrix,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int128 v9; // xmm4
			//   __int128 v10; // xmm5
			//   __int128 v11; // xmm6
			//   Vector4 v12; // xmm7
			//   __int128 v13; // xmm0
			//   void (__fastcall *v14)(__int128 *, __int128 *, __int128 *, MethodInfo *); // rax
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm2
			//   __int128 v17; // xmm3
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm2
			//   __int128 v20; // xmm3
			//   __int128 v21; // xmm1
			//   Vector4 v22; // xmm1
			//   void (__fastcall *v23)(__int128 *, __int128 *, __int128 *); // rax
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm2
			//   __int128 v29; // xmm3
			//   __int128 v30; // xmm0
			//   Vector4 v31; // xmm1
			//   __int128 v32; // xmm1
			//   Vector4 v33; // xmm1
			//   void (__fastcall *v34)(__int128 *, __int128 *, __int128 *); // rax
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   Vector4 v40; // xmm1
			//   void (__fastcall *v41)(__int128 *, __int128 *, __int128 *); // rax
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm2
			//   __int128 v47; // xmm3
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   Vector4 v52; // xmm1
			//   void (__fastcall *v53)(__int128 *, __int128 *, __int128 *); // rax
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm0
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   Vector4 v59; // xmm1
			//   void (__fastcall *v60)(__int128 *, __int128 *); // rax
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm2
			//   __int128 v66; // xmm3
			//   __int128 v67; // xmm0
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm0
			//   __int128 v72; // xmm1
			//   float z; // eax
			//   MethodInfo *v74; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 *v76; // rax
			//   __int64 v77; // rax
			//   __int64 v78; // rax
			//   __int64 v79; // rax
			//   __int64 v80; // rax
			//   __int64 v81; // rax
			//   __int64 v82; // rax
			//   __int128 v83; // [rsp+30h] [rbp-D0h] BYREF
			//   Vector4 v84; // [rsp+40h] [rbp-C0h] BYREF
			//   __int128 v85; // [rsp+50h] [rbp-B0h]
			//   __int128 v86; // [rsp+60h] [rbp-A0h]
			//   __int128 v87; // [rsp+70h] [rbp-90h] BYREF
			//   __int128 v88; // [rsp+80h] [rbp-80h]
			//   __int128 v89; // [rsp+90h] [rbp-70h]
			//   __int128 v90; // [rsp+A0h] [rbp-60h]
			//   __int128 v91; // [rsp+B0h] [rbp-50h] BYREF
			//   __int128 v92; // [rsp+C0h] [rbp-40h]
			//   __int128 v93; // [rsp+D0h] [rbp-30h]
			//   __int128 v94; // [rsp+E0h] [rbp-20h]
			//   __int128 v95; // [rsp+F0h] [rbp-10h] BYREF
			//   __int128 v96; // [rsp+100h] [rbp+0h]
			//   __int128 v97; // [rsp+110h] [rbp+10h]
			//   Vector4 v98; // [rsp+120h] [rbp+20h]
			//   __int128 v99; // [rsp+130h] [rbp+30h] BYREF
			//   __int128 v100; // [rsp+140h] [rbp+40h]
			//   __int128 v101; // [rsp+150h] [rbp+50h]
			//   Vector4 v102; // [rsp+160h] [rbp+60h]
			//   __int128 v103; // [rsp+170h] [rbp+70h] BYREF
			//   __int128 v104; // [rsp+180h] [rbp+80h]
			//   __int128 v105; // [rsp+190h] [rbp+90h]
			//   Vector4 v106; // [rsp+1A0h] [rbp+A0h]
			//   __int128 v107; // [rsp+1B0h] [rbp+B0h] BYREF
			//   __int128 v108; // [rsp+1C0h] [rbp+C0h]
			//   __int128 v109; // [rsp+1D0h] [rbp+D0h]
			//   Vector4 v110; // [rsp+1E0h] [rbp+E0h]
			// 
			//   if ( !byte_18D8EDA18 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Matrix4x4>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Matrix4x4>::get_Value);
			//     byte_18D8EDA18 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, basicTransformConstants);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_18;
			//   if ( wrapperArray.max_length.size > 820 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x334 )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !v7[17]._1.typeHierarchy )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(820, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_311(
			//           Patch,
			//           (Object *)this,
			//           basicTransformConstants,
			//           pretransformMatrix,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( pretransformMatrix.hasValue )
			//   {
			//     v9 = *(_OWORD *)&pretransformMatrix.value.m00;
			//     v10 = *(_OWORD *)&pretransformMatrix.value.m01;
			//     v11 = *(_OWORD *)&pretransformMatrix.value.m02;
			//     v12 = *(Vector4 *)&pretransformMatrix.value.m03;
			//   }
			//   else
			//   {
			//     v76 = (__int128 *)sub_182805160(&v95);
			//     v9 = *v76;
			//     v10 = v76[1];
			//     v11 = v76[2];
			//     v12 = (Vector4)v76[3];
			//   }
			//   v84 = v12;
			//   v86 = v11;
			//   v85 = v10;
			//   v83 = v9;
			//   v13 = *(_OWORD *)&this.fields.mainViewConstants.viewMatrix.m00;
			//   v14 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *, MethodInfo *))qword_18D8F4BC0;
			//   v105 = v11;
			//   v106 = v12;
			//   v103 = v9;
			//   v104 = v10;
			//   v15 = *(_OWORD *)&this.fields.mainViewConstants.viewMatrix.m01;
			//   v16 = *(_OWORD *)&this.fields.mainViewConstants.viewMatrix.m02;
			//   v17 = *(_OWORD *)&this.fields.mainViewConstants.viewMatrix.m03;
			//   *(_OWORD *)&basicTransformConstants._ViewMatrix.m00 = v13;
			//   *(_OWORD *)&basicTransformConstants._ViewMatrix.m01 = v15;
			//   *(_OWORD *)&basicTransformConstants._ViewMatrix.m02 = v16;
			//   *(_OWORD *)&basicTransformConstants._ViewMatrix.m03 = v17;
			//   v18 = *(_OWORD *)&this.fields.mainViewConstants.invViewMatrix.m01;
			//   v19 = *(_OWORD *)&this.fields.mainViewConstants.invViewMatrix.m02;
			//   v20 = *(_OWORD *)&this.fields.mainViewConstants.invViewMatrix.m03;
			//   *(_OWORD *)&basicTransformConstants._InvViewMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.invViewMatrix.m00;
			//   *(_OWORD *)&basicTransformConstants._InvViewMatrix.m01 = v18;
			//   *(_OWORD *)&basicTransformConstants._InvViewMatrix.m02 = v19;
			//   *(_OWORD *)&basicTransformConstants._InvViewMatrix.m03 = v20;
			//   v21 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m01;
			//   v99 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m00;
			//   v100 = v21;
			//   v22 = *(Vector4 *)&this.fields.mainViewConstants.projMatrix.m03;
			//   v101 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m02;
			//   v102 = v22;
			//   v87 = 0LL;
			//   v88 = 0LL;
			//   v89 = 0LL;
			//   v90 = 0LL;
			//   if ( !v14 )
			//   {
			//     v14 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                    "UnityEngine.Matrix4x4::HGMultiplyMatr"
			//                                                                                    "ix4x4Fast_Injected(UnityEngine.Matrix"
			//                                                                                    "4x4&,UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v14 )
			//     {
			//       v77 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v77, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v14;
			//   }
			//   v14(&v103, &v99, &v87, method);
			//   v23 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18D8F4BC0;
			//   v24 = v88;
			//   *(_OWORD *)&basicTransformConstants._ProjMatrix.m00 = v87;
			//   v25 = v89;
			//   *(_OWORD *)&basicTransformConstants._ProjMatrix.m01 = v24;
			//   v26 = v90;
			//   *(_OWORD *)&basicTransformConstants._ProjMatrix.m02 = v25;
			//   *(_OWORD *)&basicTransformConstants._ProjMatrix.m03 = v26;
			//   v27 = *(_OWORD *)&this.fields.mainViewConstants.invProjMatrix.m01;
			//   v28 = *(_OWORD *)&this.fields.mainViewConstants.invProjMatrix.m02;
			//   v29 = *(_OWORD *)&this.fields.mainViewConstants.invProjMatrix.m03;
			//   *(_OWORD *)&basicTransformConstants._InvProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.invProjMatrix.m00;
			//   v30 = v83;
			//   *(_OWORD *)&basicTransformConstants._InvProjMatrix.m01 = v27;
			//   v95 = v30;
			//   v96 = v85;
			//   v97 = v86;
			//   v31 = v84;
			//   *(_OWORD *)&basicTransformConstants._InvProjMatrix.m02 = v28;
			//   v98 = v31;
			//   *(_OWORD *)&basicTransformConstants._InvProjMatrix.m03 = v29;
			//   v32 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m01;
			//   v107 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m00;
			//   v108 = v32;
			//   v33 = *(Vector4 *)&this.fields.mainViewConstants.viewProjMatrix.m03;
			//   v109 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m02;
			//   v110 = v33;
			//   v91 = 0LL;
			//   v92 = 0LL;
			//   v93 = 0LL;
			//   v94 = 0LL;
			//   if ( !v23 )
			//   {
			//     v23 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
			//                                                                      "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
			//                                                                      "UnityEngine.Matrix4x4&)");
			//     if ( !v23 )
			//     {
			//       v78 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v78, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v23;
			//   }
			//   v23(&v95, &v107, &v91);
			//   v34 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18D8F4BC0;
			//   v35 = v92;
			//   *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m00 = v91;
			//   v36 = v93;
			//   *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m01 = v35;
			//   v37 = v94;
			//   *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m02 = v36;
			//   v38 = v83;
			//   *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m03 = v37;
			//   v99 = v38;
			//   v39 = *(_OWORD *)&this.fields.mainViewConstants.viewNoTransProjMatrix.m01;
			//   v100 = v85;
			//   v104 = v39;
			//   v40 = *(Vector4 *)&this.fields.mainViewConstants.viewNoTransProjMatrix.m03;
			//   v101 = v86;
			//   v106 = v40;
			//   v102 = v84;
			//   v103 = *(_OWORD *)&this.fields.mainViewConstants.viewNoTransProjMatrix.m00;
			//   v105 = *(_OWORD *)&this.fields.mainViewConstants.viewNoTransProjMatrix.m02;
			//   v87 = 0LL;
			//   v88 = 0LL;
			//   v89 = 0LL;
			//   v90 = 0LL;
			//   if ( !v34 )
			//   {
			//     v34 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
			//                                                                      "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
			//                                                                      "UnityEngine.Matrix4x4&)");
			//     if ( !v34 )
			//     {
			//       v79 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v79, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v34;
			//   }
			//   v34(&v99, &v103, &v87);
			//   v41 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18D8F4BC0;
			//   v42 = v88;
			//   *(_OWORD *)&basicTransformConstants._ViewNoTransProjMatrix.m00 = v87;
			//   v43 = v89;
			//   *(_OWORD *)&basicTransformConstants._ViewNoTransProjMatrix.m01 = v42;
			//   v44 = v90;
			//   *(_OWORD *)&basicTransformConstants._ViewNoTransProjMatrix.m02 = v43;
			//   *(_OWORD *)&basicTransformConstants._ViewNoTransProjMatrix.m03 = v44;
			//   v45 = *(_OWORD *)&this.fields.mainViewConstants.invViewProjMatrix.m01;
			//   v46 = *(_OWORD *)&this.fields.mainViewConstants.invViewProjMatrix.m02;
			//   v47 = *(_OWORD *)&this.fields.mainViewConstants.invViewProjMatrix.m03;
			//   *(_OWORD *)&basicTransformConstants._InvViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.invViewProjMatrix.m00;
			//   v48 = v83;
			//   *(_OWORD *)&basicTransformConstants._InvViewProjMatrix.m01 = v45;
			//   v107 = v48;
			//   v49 = v85;
			//   *(_OWORD *)&basicTransformConstants._InvViewProjMatrix.m02 = v46;
			//   v108 = v49;
			//   v50 = v86;
			//   *(_OWORD *)&basicTransformConstants._InvViewProjMatrix.m03 = v47;
			//   v109 = v50;
			//   v51 = *(_OWORD *)&this.fields.mainViewConstants.nonJitteredViewProjMatrix.m01;
			//   v110 = v84;
			//   v96 = v51;
			//   v52 = *(Vector4 *)&this.fields.mainViewConstants.nonJitteredViewProjMatrix.m03;
			//   v95 = *(_OWORD *)&this.fields.mainViewConstants.nonJitteredViewProjMatrix.m00;
			//   v98 = v52;
			//   v97 = *(_OWORD *)&this.fields.mainViewConstants.nonJitteredViewProjMatrix.m02;
			//   v91 = 0LL;
			//   v92 = 0LL;
			//   v93 = 0LL;
			//   v94 = 0LL;
			//   if ( !v41 )
			//   {
			//     v41 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
			//                                                                      "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
			//                                                                      "UnityEngine.Matrix4x4&)");
			//     if ( !v41 )
			//     {
			//       v80 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v80, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v41;
			//   }
			//   v41(&v107, &v95, &v91);
			//   v53 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))qword_18D8F4BC0;
			//   v54 = v92;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewProjMatrix.m00 = v91;
			//   v55 = v93;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewProjMatrix.m01 = v54;
			//   v56 = v94;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewProjMatrix.m02 = v55;
			//   v57 = v83;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewProjMatrix.m03 = v56;
			//   v99 = v57;
			//   v58 = *(_OWORD *)&this.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m01;
			//   v100 = v85;
			//   v104 = v58;
			//   v59 = *(Vector4 *)&this.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m03;
			//   v101 = v86;
			//   v106 = v59;
			//   v102 = v84;
			//   v103 = *(_OWORD *)&this.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m00;
			//   v105 = *(_OWORD *)&this.fields.mainViewConstants.nonJitteredViewNoTransProjMatrix.m02;
			//   v87 = 0LL;
			//   v88 = 0LL;
			//   v89 = 0LL;
			//   v90 = 0LL;
			//   if ( !v53 )
			//   {
			//     v53 = (void (__fastcall *)(__int128 *, __int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
			//                                                                      "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
			//                                                                      "UnityEngine.Matrix4x4&)");
			//     if ( !v53 )
			//     {
			//       v81 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v81, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v53;
			//   }
			//   v53(&v99, &v103, &v87);
			//   v60 = (void (__fastcall *)(__int128 *, __int128 *))qword_18D8F4BD0;
			//   v61 = v88;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewNoTransProjMatrix.m00 = v87;
			//   v62 = v89;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01 = v61;
			//   v63 = v90;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewNoTransProjMatrix.m02 = v62;
			//   *(_OWORD *)&basicTransformConstants._NonJitteredViewNoTransProjMatrix.m03 = v63;
			//   v64 = *(_OWORD *)&this.fields.mainViewConstants.invNonJitteredViewProjMatrix.m01;
			//   v65 = *(_OWORD *)&this.fields.mainViewConstants.invNonJitteredViewProjMatrix.m02;
			//   v66 = *(_OWORD *)&this.fields.mainViewConstants.invNonJitteredViewProjMatrix.m03;
			//   *(_OWORD *)&basicTransformConstants._InvNonJitteredViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.invNonJitteredViewProjMatrix.m00;
			//   v67 = v83;
			//   *(_OWORD *)&basicTransformConstants._InvNonJitteredViewProjMatrix.m01 = v64;
			//   v95 = v67;
			//   v68 = v85;
			//   *(_OWORD *)&basicTransformConstants._InvNonJitteredViewProjMatrix.m02 = v65;
			//   v96 = v68;
			//   v69 = v86;
			//   *(_OWORD *)&basicTransformConstants._InvNonJitteredViewProjMatrix.m03 = v66;
			//   v97 = v69;
			//   v98 = v84;
			//   v91 = 0LL;
			//   v92 = 0LL;
			//   v93 = 0LL;
			//   v94 = 0LL;
			//   if ( !v60 )
			//   {
			//     v60 = (void (__fastcall *)(__int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,"
			//                                                          "UnityEngine.Matrix4x4&)");
			//     if ( !v60 )
			//     {
			//       v82 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v82, 0LL);
			//     }
			//     qword_18D8F4BD0 = (__int64)v60;
			//   }
			//   v60(&v95, &v91);
			//   v70 = v92;
			//   *(_OWORD *)&basicTransformConstants._InvPretransformMatrix.m00 = v91;
			//   v71 = v93;
			//   *(_OWORD *)&basicTransformConstants._InvPretransformMatrix.m01 = v70;
			//   v72 = v94;
			//   *(_OWORD *)&basicTransformConstants._InvPretransformMatrix.m02 = v71;
			//   *(_OWORD *)&basicTransformConstants._InvPretransformMatrix.m03 = v72;
			//   z = this.fields.mainViewConstants.worldSpaceCameraPos.z;
			//   *(_QWORD *)&v83 = *(_QWORD *)&this.fields.mainViewConstants.worldSpaceCameraPos.x;
			//   *((float *)&v83 + 2) = z;
			//   basicTransformConstants._WorldSpaceCameraPos_Internal = *UnityEngine::Vector4::op_Implicit(
			//                                                               &v84,
			//                                                               (Vector3 *)&v83,
			//                                                               v74);
			// }
			// 
		}

		[IDTag(1)]
		internal void UpdateShaderVariablesGlobalCB(ref ShaderVariablesGlobal cb, ref BasicTransformConstants basicTransformConstants, Matrix4x4 preTransform)
		{
			// // Void UpdateShaderVariablesGlobalCB(ShaderVariablesGlobal ByRef, BasicTransformConstants ByRef, Matrix4x4)
			// void HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
			//         HGCamera *this,
			//         ShaderVariablesGlobal *cb,
			//         BasicTransformConstants *basicTransformConstants,
			//         Matrix4x4 *preTransform,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   uint32_t cameraFrameCount; // eax
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   ILFixDynamicMethodWrapper_2__Array *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   Matrix4x4 v21; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v9.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 818 )
			//   {
			// LABEL_7:
			//     cameraFrameCount = this.fields.cameraFrameCount;
			//     v13 = *(_OWORD *)&preTransform.m01;
			//     *(_OWORD *)&v21.m00 = *(_OWORD *)&preTransform.m00;
			//     v14 = *(_OWORD *)&preTransform.m02;
			//     *(_OWORD *)&v21.m01 = v13;
			//     v15 = *(_OWORD *)&preTransform.m03;
			//     *(_OWORD *)&v21.m02 = v14;
			//     *(_OWORD *)&v21.m03 = v15;
			//     HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
			//       this,
			//       basicTransformConstants,
			//       cb,
			//       &v21,
			//       cameraFrameCount,
			//       0LL);
			//     return;
			//   }
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v9.static_fields;
			//   v16 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v16.max_length.size <= 0x332u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v16[22].vector[26] )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(818, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   v18 = *(_OWORD *)&preTransform.m01;
			//   *(_OWORD *)&v21.m00 = *(_OWORD *)&preTransform.m00;
			//   v19 = *(_OWORD *)&preTransform.m02;
			//   *(_OWORD *)&v21.m01 = v18;
			//   v20 = *(_OWORD *)&preTransform.m03;
			//   *(_OWORD *)&v21.m02 = v19;
			//   *(_OWORD *)&v21.m03 = v20;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_314(Patch, (Object *)this, cb, basicTransformConstants, &v21, 0LL);
			// }
			// 
		}

		[IDTag(0)]
		internal void UpdateShaderVariablesGlobalCB(ref BasicTransformConstants basicTransformConstants, ref ShaderVariablesGlobal cb, Matrix4x4 preTransform, uint frameCount)
		{
			// // Void UpdateShaderVariablesGlobalCB(BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef, Matrix4x4, UInt32)
			// void HG::Rendering::Runtime::HGCamera::UpdateShaderVariablesGlobalCB(
			//         HGCamera *this,
			//         BasicTransformConstants *basicTransformConstants,
			//         ShaderVariablesGlobal *cb,
			//         Matrix4x4 *preTransform,
			//         uint32_t frameCount,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v11; // rdx
			//   BitArray128 bitDatas; // xmm6
			//   __int64 v13; // xmm0_8
			//   bool v14; // al
			//   Camera *camera; // rsi
			//   unsigned int (__fastcall *v16)(Camera *); // rax
			//   unsigned __int8 v17; // r12
			//   __int128 v18; // xmm1
			//   __m128i v19; // xmm2
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm2
			//   __int128 v23; // xmm3
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm2
			//   __int128 v26; // xmm3
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm2
			//   __int128 v29; // xmm3
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm2
			//   __int128 v32; // xmm3
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm2
			//   __int128 v35; // xmm3
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm2
			//   __int128 v38; // xmm3
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm2
			//   __int128 v41; // xmm3
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm2
			//   __int128 v44; // xmm3
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm2
			//   __int128 v47; // xmm3
			//   Camera *v48; // rsi
			//   __int64 (__fastcall *v49)(Camera *); // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rsi
			//   MethodInfo *v52; // r8
			//   float z; // eax
			//   Vector4 *v54; // rax
			//   __int64 v55; // rdx
			//   bool v56; // zf
			//   __m128 v57; // xmm5
			//   __m128 v58; // xmm5
			//   __m128 v59; // xmm5
			//   __m128 v60; // xmm5
			//   __m128 v61; // xmm5
			//   __m128 v62; // xmm5
			//   __m128 v63; // xmm5
			//   __m128 v64; // xmm5
			//   __m128 v65; // xmm5
			//   __m128 v66; // xmm5
			//   int v67; // r10d
			//   __int64 v68; // r11
			//   __int64 i; // r9
			//   Vector4__Array *frustumPlaneEquations; // rax
			//   __int64 v71; // rax
			//   __m128 v72; // xmm2
			//   __m128 v73; // xmm2
			//   __m128 v74; // xmm2
			//   __m128 v75; // xmm2
			//   Vector4 taaJitter; // xmm0
			//   struct Math__Class *v77; // rcx
			//   float globalMipBias_k__BackingField; // xmm6_4
			//   __int64 v79; // rdx
			//   __m128 v80; // xmm0
			//   __m128 v81; // xmm15
			//   float gameplayTime; // xmm14_4
			//   __m128 v83; // xmm13
			//   __m128 v84; // xmm2
			//   float smoothDeltaTime; // xmm12_4
			//   __m128 v86; // xmm0
			//   __m128 v87; // xmm2
			//   __m128 v88; // xmm2
			//   __m128 v89; // xmm2
			//   __m128 v90; // xmm8
			//   float v91; // xmm7_4
			//   float v92; // xmm6_4
			//   __m128 v93; // xmm8
			//   __m128 v94; // xmm8
			//   __m128 v95; // xmm8
			//   __m128 v96; // xmm8
			//   float v97; // xmm6_4
			//   float v98; // xmm7_4
			//   __m128 v99; // xmm8
			//   __m128 v100; // xmm8
			//   __m128 v101; // xmm8
			//   __m128 v102; // xmm13
			//   __m128 v103; // xmm13
			//   __m128 v104; // xmm13
			//   float v105; // xmm6_4
			//   BitArray128 v106; // xmm7
			//   __m128 v107; // xmm15
			//   __m128 v108; // xmm15
			//   __m128 v109; // xmm15
			//   float v110; // xmm6_4
			//   __m128 v111; // xmm7
			//   __m128 v112; // xmm7
			//   __m128 v113; // xmm7
			//   float probeRangeCompressionFactor; // xmm0_4
			//   int klass; // xmm0_4
			//   __int128 v116; // xmm1
			//   __int128 v117; // xmm0
			//   __int128 v118; // xmm1
			//   ILFixDynamicMethodWrapper_2 *v119; // rax
			//   __int64 v120; // rax
			//   __int64 v121; // rax
			//   ILFixDynamicMethodWrapper_2 *v122; // rax
			//   Vector4 taauRTSizeParam_k__BackingField; // xmm2
			//   __m128 v124; // xmm5
			//   __m128 v125; // xmm5
			//   ILFixDynamicMethodWrapper_2 *v126; // rax
			//   Vector4 v127; // xmm2
			//   __m128 v128; // xmm5
			//   __m128 v129; // xmm5
			//   __int64 v130; // rax
			//   SystemException *v131; // rbx
			//   String *v132; // rax
			//   __int64 v133; // rax
			//   __m128 v134; // [rsp+40h] [rbp-C0h] BYREF
			//   float lastGameplayTime; // [rsp+50h] [rbp-B0h]
			//   FrameSettings P0; // [rsp+60h] [rbp-A0h] BYREF
			//   _BYTE v137[68]; // [rsp+80h] [rbp-80h] BYREF
			//   Nullable_1_UnityEngine_Matrix4x4_ pretransformMatrix; // [rsp+D0h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D8EDA19 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Matrix4x4>::Nullable);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDA19 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, basicTransformConstants);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//   if ( !v11 )
			//     goto LABEL_76;
			//   if ( *(int *)(v11 + 24) > 819 )
			//   {
			//     if ( !Patch[5].fields.methodId )
			//     {
			//       il2cpp_runtime_class_init_0(Patch, v11);
			//       Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//     if ( !v11 )
			//       goto LABEL_76;
			//     if ( *(_DWORD *)(v11 + 24) <= 0x333u )
			//       goto LABEL_77;
			//     if ( *(_QWORD *)(v11 + 6584) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(819, 0LL);
			//       if ( Patch )
			//       {
			//         v116 = *(_OWORD *)&preTransform.m01;
			//         *(_OWORD *)v137 = *(_OWORD *)&preTransform.m00;
			//         v117 = *(_OWORD *)&preTransform.m02;
			//         *(_OWORD *)&v137[16] = v116;
			//         v118 = *(_OWORD *)&preTransform.m03;
			//         *(_OWORD *)&v137[32] = v117;
			//         *(_OWORD *)&v137[48] = v118;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_313(
			//           Patch,
			//           (Object *)this,
			//           basicTransformConstants,
			//           cb,
			//           (Matrix4x4 *)v137,
			//           frameCount,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_76;
			//     }
			//   }
			//   bitDatas = this.fields._frameSettings_k__BackingField.bitDatas;
			//   v13 = *(_QWORD *)&this.fields._frameSettings_k__BackingField.materialQuality;
			//   P0.bitDatas = bitDatas;
			//   *(_QWORD *)&P0.materialQuality = v13;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !Patch[5].fields.methodId )
			//   {
			//     il2cpp_runtime_class_init_0(Patch, v11);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//   if ( !v11 )
			//     goto LABEL_76;
			//   if ( *(int *)(v11 + 24) <= 679 )
			//     goto LABEL_15;
			//   if ( !Patch[5].fields.methodId )
			//   {
			//     il2cpp_runtime_class_init_0(Patch, v11);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//   if ( !v11 )
			//     goto LABEL_76;
			//   if ( *(_DWORD *)(v11 + 24) <= 0x2A7u )
			//     goto LABEL_77;
			//   if ( *(_QWORD *)(v11 + 5464) )
			//   {
			//     v119 = IFix::WrappersManagerImpl::GetPatch(679, 0LL);
			//     if ( !v119 )
			//       goto LABEL_76;
			//     v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_256(v119, &P0, FrameSettingsField__Enum_Postprocess, 0LL);
			//   }
			//   else
			//   {
			// LABEL_15:
			//     v14 = (bitDatas.data1 & 0x8000) != 0LL;
			//   }
			//   if ( !v14 || this.fields.m_antialiasingMode != 2 )
			//     goto LABEL_75;
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_76;
			//   v16 = (unsigned int (__fastcall *)(Camera *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v16 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v16 )
			//     {
			//       v120 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v120, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v16;
			//   }
			//   if ( v16(camera) == 1 )
			//     v17 = 1;
			//   else
			// LABEL_75:
			//     v17 = 0;
			//   v18 = *(_OWORD *)&preTransform.m01;
			//   v19 = *(__m128i *)&preTransform.m03;
			//   memset(&v137[16], 0, 48);
			//   *(_OWORD *)v137 = 0LL;
			//   v137[0] = 1;
			//   v20 = *(_OWORD *)&preTransform.m00;
			//   *(_OWORD *)&v137[20] = v18;
			//   *(_OWORD *)&v137[4] = v20;
			//   *(_OWORD *)&v137[36] = *(_OWORD *)&preTransform.m02;
			//   *(__m128i *)&v137[52] = v19;
			//   *(_OWORD *)&pretransformMatrix.hasValue = *(_OWORD *)v137;
			//   *(_OWORD *)&pretransformMatrix.value.m30 = *(_OWORD *)&v137[16];
			//   *(_OWORD *)&pretransformMatrix.value.m31 = *(_OWORD *)&v137[32];
			//   *(_OWORD *)&pretransformMatrix.value.m32 = *(_OWORD *)&v137[48];
			//   LODWORD(pretransformMatrix.value.m33) = _mm_cvtsi128_si32(_mm_srli_si128(v19, 12));
			//   HG::Rendering::Runtime::HGCamera::PrepareBasicCameraTransforms(
			//     this,
			//     basicTransformConstants,
			//     &pretransformMatrix,
			//     0LL);
			//   v21 = *(_OWORD *)&this.fields.mainViewConstants.prevViewProjMatrix.m01;
			//   v22 = *(_OWORD *)&this.fields.mainViewConstants.prevViewProjMatrix.m02;
			//   v23 = *(_OWORD *)&this.fields.mainViewConstants.prevViewProjMatrix.m03;
			//   *(_OWORD *)&cb._PrevViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.prevViewProjMatrix.m00;
			//   *(_OWORD *)&cb._PrevViewProjMatrix.m01 = v21;
			//   *(_OWORD *)&cb._PrevViewProjMatrix.m02 = v22;
			//   *(_OWORD *)&cb._PrevViewProjMatrix.m03 = v23;
			//   v24 = *(_OWORD *)&this.fields.mainViewConstants.prevViewNoTransProjMatrix.m01;
			//   v25 = *(_OWORD *)&this.fields.mainViewConstants.prevViewNoTransProjMatrix.m02;
			//   v26 = *(_OWORD *)&this.fields.mainViewConstants.prevViewNoTransProjMatrix.m03;
			//   *(_OWORD *)&cb._PrevViewNoTransProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.prevViewNoTransProjMatrix.m00;
			//   *(_OWORD *)&cb._PrevViewNoTransProjMatrix.m01 = v24;
			//   *(_OWORD *)&cb._PrevViewNoTransProjMatrix.m02 = v25;
			//   *(_OWORD *)&cb._PrevViewNoTransProjMatrix.m03 = v26;
			//   v27 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewProjMatrix.m01;
			//   v28 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewProjMatrix.m02;
			//   v29 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewProjMatrix.m03;
			//   *(_OWORD *)&cb._PrevNonJitteredViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewProjMatrix.m00;
			//   *(_OWORD *)&cb._PrevNonJitteredViewProjMatrix.m01 = v27;
			//   *(_OWORD *)&cb._PrevNonJitteredViewProjMatrix.m02 = v28;
			//   *(_OWORD *)&cb._PrevNonJitteredViewProjMatrix.m03 = v29;
			//   v30 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m01;
			//   v31 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m02;
			//   v32 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m03;
			//   *(_OWORD *)&cb._PrevNonJitteredViewNoTransProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredViewNoTransProjMatrix.m00;
			//   *(_OWORD *)&cb._PrevNonJitteredViewNoTransProjMatrix.m01 = v30;
			//   *(_OWORD *)&cb._PrevNonJitteredViewNoTransProjMatrix.m02 = v31;
			//   *(_OWORD *)&cb._PrevNonJitteredViewNoTransProjMatrix.m03 = v32;
			//   v33 = *(_OWORD *)&this.fields.mainViewConstants.prevInvViewProjMatrix.m01;
			//   v34 = *(_OWORD *)&this.fields.mainViewConstants.prevInvViewProjMatrix.m02;
			//   v35 = *(_OWORD *)&this.fields.mainViewConstants.prevInvViewProjMatrix.m03;
			//   *(_OWORD *)&cb._PrevInvViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.prevInvViewProjMatrix.m00;
			//   *(_OWORD *)&cb._PrevInvViewProjMatrix.m01 = v33;
			//   *(_OWORD *)&cb._PrevInvViewProjMatrix.m02 = v34;
			//   *(_OWORD *)&cb._PrevInvViewProjMatrix.m03 = v35;
			//   v36 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m01;
			//   v37 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m02;
			//   v38 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m03;
			//   *(_OWORD *)&cb._PrevNonJitteredInvViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.prevNonJitteredInvViewProjMatrix.m00;
			//   *(_OWORD *)&cb._PrevNonJitteredInvViewProjMatrix.m01 = v36;
			//   *(_OWORD *)&cb._PrevNonJitteredInvViewProjMatrix.m02 = v37;
			//   *(_OWORD *)&cb._PrevNonJitteredInvViewProjMatrix.m03 = v38;
			//   v39 = *(_OWORD *)&this.fields.mainViewConstants.reprojectionMatrix.m01;
			//   v40 = *(_OWORD *)&this.fields.mainViewConstants.reprojectionMatrix.m02;
			//   v41 = *(_OWORD *)&this.fields.mainViewConstants.reprojectionMatrix.m03;
			//   *(_OWORD *)&cb._ReprojectionMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.reprojectionMatrix.m00;
			//   *(_OWORD *)&cb._ReprojectionMatrix.m01 = v39;
			//   *(_OWORD *)&cb._ReprojectionMatrix.m02 = v40;
			//   *(_OWORD *)&cb._ReprojectionMatrix.m03 = v41;
			//   v42 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVViewProjMatrix.m01;
			//   v43 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVViewProjMatrix.m02;
			//   v44 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVViewProjMatrix.m03;
			//   *(_OWORD *)&cb._WiderFoVViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVViewProjMatrix.m00;
			//   *(_OWORD *)&cb._WiderFoVViewProjMatrix.m01 = v42;
			//   *(_OWORD *)&cb._WiderFoVViewProjMatrix.m02 = v43;
			//   *(_OWORD *)&cb._WiderFoVViewProjMatrix.m03 = v44;
			//   v45 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVInvViewProjMatrix.m01;
			//   v46 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVInvViewProjMatrix.m02;
			//   v47 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVInvViewProjMatrix.m03;
			//   *(_OWORD *)&cb._WiderFoVInvViewProjMatrix.m00 = *(_OWORD *)&this.fields.mainViewConstants.widerFoVInvViewProjMatrix.m00;
			//   *(_OWORD *)&cb._WiderFoVInvViewProjMatrix.m01 = v45;
			//   *(_OWORD *)&cb._WiderFoVInvViewProjMatrix.m02 = v46;
			//   *(_OWORD *)&cb._WiderFoVInvViewProjMatrix.m03 = v47;
			//   v48 = this.fields.camera;
			//   if ( !v48 )
			//     goto LABEL_76;
			//   v49 = (__int64 (__fastcall *)(Camera *))qword_18D8F4280;
			//   if ( !qword_18D8F4280 )
			//   {
			//     v49 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::GetLightWeightCamera()");
			//     if ( !v49 )
			//     {
			//       v121 = sub_1802DBBE8("UnityEngine.Camera::GetLightWeightCamera()");
			//       sub_18000F750(v121, 0LL);
			//     }
			//     qword_18D8F4280 = (__int64)v49;
			//   }
			//   v51 = v49(v48);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v51 && !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//   z = this.fields.mainViewConstants.prevWorldSpaceCameraPos.z;
			//   v134.m128_u64[0] = *(_QWORD *)&this.fields.mainViewConstants.prevWorldSpaceCameraPos.x;
			//   v134.m128_f32[2] = z;
			//   v54 = UnityEngine::Vector4::op_Implicit((Vector4 *)&P0, (Vector3 *)&v134, v52);
			//   v56 = byte_18D8EDC37 == 0;
			//   cb._PrevCamPosRWS_Internal = *v54;
			//   cb._ZBufferParams = this.fields.zBufferParams;
			//   cb._ProjectionParams = this.fields.projectionParams;
			//   cb.unity_OrthoParams = this.fields.unity_OrthoParams;
			//   if ( v56 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v55);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//   if ( !v11 )
			//     goto LABEL_76;
			//   if ( *(int *)(v11 + 24) <= 821 )
			//     goto LABEL_41;
			//   if ( !Patch[5].fields.methodId )
			//   {
			//     il2cpp_runtime_class_init_0(Patch, v11);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   Patch = **(ILFixDynamicMethodWrapper_2 ***)&Patch[4].fields.methodId;
			//   if ( !Patch )
			//     goto LABEL_76;
			//   if ( Patch.fields.methodId <= 0x335u )
			//     goto LABEL_77;
			//   if ( Patch[165].klass )
			//   {
			//     v122 = IFix::WrappersManagerImpl::GetPatch(821, 0LL);
			//     if ( !v122 )
			//       goto LABEL_76;
			//     v61 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312((Vector4 *)&P0, v122, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			// LABEL_41:
			//     if ( this.fields.m_finalRTSize.m_X == -1 || this.fields.m_finalRTSize.m_Y == -1 )
			//     {
			//       taauRTSizeParam_k__BackingField = this.fields._taauRTSizeParam_k__BackingField;
			//       v124 = _mm_shuffle_ps((__m128)taauRTSizeParam_k__BackingField, (__m128)taauRTSizeParam_k__BackingField, 225);
			//       v124.m128_f32[0] = _mm_shuffle_ps(
			//                            (__m128)taauRTSizeParam_k__BackingField,
			//                            (__m128)taauRTSizeParam_k__BackingField,
			//                            85).m128_f32[0];
			//       v125 = _mm_shuffle_ps(v124, v124, 198);
			//       v125.m128_f32[0] = _mm_shuffle_ps(
			//                            (__m128)taauRTSizeParam_k__BackingField,
			//                            (__m128)taauRTSizeParam_k__BackingField,
			//                            170).m128_f32[0];
			//       v60 = _mm_shuffle_ps(v125, v125, 39);
			//       v60.m128_f32[0] = _mm_shuffle_ps(
			//                           (__m128)taauRTSizeParam_k__BackingField,
			//                           (__m128)taauRTSizeParam_k__BackingField,
			//                           255).m128_f32[0];
			//     }
			//     else
			//     {
			//       v57 = 0LL;
			//       v57.m128_f32[0] = (float)this.fields.m_finalRTSize.m_X;
			//       v58 = _mm_shuffle_ps(v57, v57, 225);
			//       v58.m128_f32[0] = (float)this.fields.m_finalRTSize.m_Y;
			//       v59 = _mm_shuffle_ps(v58, v58, 198);
			//       v59.m128_f32[0] = 1.0 / (float)this.fields.m_finalRTSize.m_X;
			//       v60 = _mm_shuffle_ps(v59, v59, 39);
			//       v60.m128_f32[0] = 1.0 / (float)this.fields.m_finalRTSize.m_Y;
			//     }
			//     v61 = _mm_shuffle_ps(v60, v60, 57);
			//     v134 = v61;
			//   }
			//   v56 = byte_18D8EDC37 == 0;
			//   cb._ScreenSize = (Vector4)v61;
			//   if ( v56 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v11);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//   if ( !v11 )
			//     goto LABEL_76;
			//   if ( *(int *)(v11 + 24) <= 821 )
			//     goto LABEL_51;
			//   if ( !Patch[5].fields.methodId )
			//   {
			//     il2cpp_runtime_class_init_0(Patch, v11);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = **(_QWORD **)&Patch[4].fields.methodId;
			//   if ( !v11 )
			// LABEL_76:
			//     sub_180B536AC(Patch, v11);
			//   if ( *(_DWORD *)(v11 + 24) <= 0x335u )
			// LABEL_77:
			//     sub_180070270(Patch, v11);
			//   if ( *(_QWORD *)(v11 + 6600) )
			//   {
			//     v126 = IFix::WrappersManagerImpl::GetPatch(821, 0LL);
			//     if ( !v126 )
			//       goto LABEL_76;
			//     v66 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312((Vector4 *)&P0, v126, (Object *)this, 0LL);
			//     goto LABEL_55;
			//   }
			// LABEL_51:
			//   if ( this.fields.m_finalRTSize.m_X == -1 || this.fields.m_finalRTSize.m_Y == -1 )
			//   {
			//     v127 = this.fields._taauRTSizeParam_k__BackingField;
			//     v128 = _mm_shuffle_ps((__m128)v127, (__m128)v127, 225);
			//     v128.m128_f32[0] = _mm_shuffle_ps((__m128)v127, (__m128)v127, 85).m128_f32[0];
			//     v129 = _mm_shuffle_ps(v128, v128, 198);
			//     v129.m128_f32[0] = _mm_shuffle_ps((__m128)v127, (__m128)v127, 170).m128_f32[0];
			//     v65 = _mm_shuffle_ps(v129, v129, 39);
			//     v65.m128_f32[0] = _mm_shuffle_ps((__m128)v127, (__m128)v127, 255).m128_f32[0];
			//   }
			//   else
			//   {
			//     v62 = 0LL;
			//     v62.m128_f32[0] = (float)this.fields.m_finalRTSize.m_X;
			//     v63 = _mm_shuffle_ps(v62, v62, 225);
			//     v63.m128_f32[0] = (float)this.fields.m_finalRTSize.m_Y;
			//     v64 = _mm_shuffle_ps(v63, v63, 198);
			//     v64.m128_f32[0] = 1.0 / (float)this.fields.m_finalRTSize.m_X;
			//     v65 = _mm_shuffle_ps(v64, v64, 39);
			//     v65.m128_f32[0] = 1.0 / (float)this.fields.m_finalRTSize.m_Y;
			//   }
			//   v66 = _mm_shuffle_ps(v65, v65, 57);
			//   v134 = v66;
			// LABEL_55:
			//   cb._BackBufferSize = (Vector4)v66;
			//   v67 = 0;
			//   v68 = 0LL;
			//   cb._ScreenParams = this.fields.screenParams;
			//   do
			//   {
			//     v11 = 0LL;
			//     for ( i = 0LL; ; ++i )
			//     {
			//       frustumPlaneEquations = this.fields.frustumPlaneEquations;
			//       if ( !frustumPlaneEquations )
			//         goto LABEL_76;
			//       if ( (unsigned int)v67 >= frustumPlaneEquations.max_length.size )
			//         goto LABEL_77;
			//       Patch = (ILFixDynamicMethodWrapper_2 *)&frustumPlaneEquations.vector[v67];
			//       if ( (_DWORD)v11 )
			//         break;
			//       klass = (int)Patch.klass;
			// LABEL_72:
			//       v11 = (unsigned int)(v11 + 1);
			//       *((_DWORD *)&cb._FrustumPlanes.FixedElementField + v68 + i) = klass;
			//     }
			//     if ( (_DWORD)v11 == 1 )
			//     {
			//       klass = HIDWORD(Patch.klass);
			//       goto LABEL_72;
			//     }
			//     if ( (_DWORD)v11 == 2 )
			//     {
			//       klass = (int)Patch.monitor;
			//       goto LABEL_72;
			//     }
			//     if ( (_DWORD)v11 != 3 )
			//     {
			//       v130 = sub_18003C530(&TypeInfo::System::IndexOutOfRangeException);
			//       v131 = (SystemException *)sub_180004920(v130);
			//       if ( v131 )
			//       {
			//         v132 = (String *)sub_18003C530(&off_18D627718);
			//         System::SystemException::SystemException(v131, v132, 0LL);
			//         v131.fields._._HResult = -2146233080;
			//         v133 = sub_18003C530(&MethodInfo::UnityEngine::Vector4::get_Item);
			//         sub_18000F7C0(v131, v133);
			//       }
			//       goto LABEL_76;
			//     }
			//     v71 = v68 + i;
			//     v68 += 4LL;
			//     *((_DWORD *)&cb._FrustumPlanes.FixedElementField + v71) = HIDWORD(Patch.monitor);
			//     ++v67;
			//   }
			//   while ( v67 < 6 );
			//   v72 = _mm_shuffle_ps(
			//           (__m128)LODWORD(this.fields.taaSharpenStrength),
			//           (__m128)LODWORD(this.fields.taaSharpenStrength),
			//           225);
			//   v72.m128_f32[0] = this.fields.screenParams.y / this.fields.screenParams.x;
			//   v73 = _mm_shuffle_ps(v72, v72, 198);
			//   v73.m128_f32[0] = (float)this.fields.taaFrameIndex;
			//   v74 = _mm_shuffle_ps(v73, v73, 39);
			//   v74.m128_f32[0] = (float)v17;
			//   v75 = _mm_shuffle_ps(v74, v74, 57);
			//   *(__m128 *)&cb._EnvironmentGlobalParams0.z = v75;
			//   taaJitter = this.fields.taaJitter;
			//   v134 = v75;
			//   *(Vector4 *)&cb._GraphicsFeaturesGlobalParam0.z = taaJitter;
			//   cb._CharacterPositionParams3.z = this.fields._globalMipBias_k__BackingField;
			//   v77 = TypeInfo::System::Math;
			//   globalMipBias_k__BackingField = this.fields._globalMipBias_k__BackingField;
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v11);
			//   System::Math::Pow((System::Math *)v77, globalMipBias_k__BackingField, *(double *)v75.m128_u64);
			//   *(unsigned __int64 *)((char *)v134.m128_u64 + 4) = 0LL;
			//   v134.m128_i32[3] = 0;
			//   v80 = (__m128)v134.m128_u32[0];
			//   cb._CharacterPositionParams3.w = 2.0;
			//   v80.m128_f32[0] = this.fields.exposureAdaptation;
			//   *(__m128 *)&cb._CharacterHeightParams.z = v80;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager._1.cctor_finished_or_no_cctor )
			//     *(double *)v80.m128_u64 = il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager, v79);
			//   v80.m128_f32[0] = HG::Rendering::Runtime::HGRPTimeManager::get_time(0LL);
			//   v81 = v80;
			//   LODWORD(P0.bitDatas.data1) = HG::Rendering::Runtime::HGRPTimeManager::get_lastTime(0LL);
			//   gameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//   lastGameplayTime = HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(0LL);
			//   v80.m128_f32[0] = UnityEngine::Time::get_deltaTime(0LL);
			//   v83 = v80;
			//   v84 = v81;
			//   smoothDeltaTime = UnityEngine::Time::get_smoothDeltaTime(0LL);
			//   v84.m128_f32[0] = v81.m128_f32[0] * 0.050000001;
			//   v86.m128_u64[1] = v81.m128_u64[1];
			//   v87 = _mm_shuffle_ps(v84, v84, 225);
			//   v87.m128_f32[0] = v81.m128_f32[0];
			//   v88 = _mm_shuffle_ps(v87, v87, 198);
			//   v88.m128_f32[0] = v81.m128_f32[0] + v81.m128_f32[0];
			//   v89 = _mm_shuffle_ps(v88, v88, 39);
			//   v89.m128_f32[0] = gameplayTime;
			//   *(__m128 *)&cb._GraphicsFeaturesGlobalParam1.z = _mm_shuffle_ps(v89, v89, 57);
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::sinf();
			//   v90 = v86;
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::sinf();
			//   v91 = v86.m128_f32[0];
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::sinf();
			//   v92 = v86.m128_f32[0];
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::sinf();
			//   v93 = _mm_shuffle_ps(v90, v90, 225);
			//   v93.m128_f32[0] = v91;
			//   v94 = _mm_shuffle_ps(v93, v93, 198);
			//   v94.m128_f32[0] = v92;
			//   v95 = _mm_shuffle_ps(v94, v94, 39);
			//   v95.m128_f32[0] = v86.m128_f32[0];
			//   v86.m128_u64[1] = v81.m128_u64[1];
			//   *(__m128 *)&cb._WindGlobalParams0.z = _mm_shuffle_ps(v95, v95, 57);
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::cosf();
			//   v96 = v86;
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::cosf();
			//   v97 = v86.m128_f32[0];
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::cosf();
			//   v98 = v86.m128_f32[0];
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::cosf();
			//   v99 = _mm_shuffle_ps(v96, v96, 225);
			//   v99.m128_f32[0] = v97;
			//   v100 = _mm_shuffle_ps(v99, v99, 198);
			//   v100.m128_f32[0] = v98;
			//   v101 = _mm_shuffle_ps(v100, v100, 39);
			//   v101.m128_f32[0] = v86.m128_f32[0];
			//   *(__m128 *)&cb._WindGlobalParams2.z = _mm_shuffle_ps(v101, v101, 57);
			//   v86.m128_f32[0] = 1.0 / v83.m128_f32[0];
			//   v102 = _mm_shuffle_ps(v83, v83, 225);
			//   v102.m128_f32[0] = v86.m128_f32[0];
			//   v103 = _mm_shuffle_ps(v102, v102, 198);
			//   v103.m128_f32[0] = smoothDeltaTime;
			//   v104 = _mm_shuffle_ps(v103, v103, 39);
			//   v104.m128_f32[0] = 1.0 / smoothDeltaTime;
			//   *(__m128 *)&cb._CharacterPositionParams0.z = _mm_shuffle_ps(v104, v104, 57);
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::sinf();
			//   v105 = v86.m128_f32[0];
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::cosf();
			//   v106 = P0.bitDatas;
			//   v107 = _mm_shuffle_ps(v81, v81, 225);
			//   v107.m128_f32[0] = v105;
			//   v108 = _mm_shuffle_ps(v107, v107, 198);
			//   v108.m128_f32[0] = v86.m128_f32[0];
			//   v109 = _mm_shuffle_ps(v108, v108, 39);
			//   v109.m128_f32[0] = gameplayTime;
			//   *(__m128 *)&cb._CharacterPositionParams1.z = _mm_shuffle_ps(v109, v109, 57);
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::sinf();
			//   v110 = v86.m128_f32[0];
			//   *(double *)v86.m128_u64 = Beyond::DampingMath::cosf();
			//   v111 = _mm_shuffle_ps((__m128)v106, (__m128)v106, 225);
			//   v111.m128_f32[0] = v110;
			//   LODWORD(cb._CharacterHeightParams.y) = frameCount;
			//   v112 = _mm_shuffle_ps(v111, v111, 198);
			//   v112.m128_f32[0] = v86.m128_f32[0];
			//   v113 = _mm_shuffle_ps(v112, v112, 39);
			//   v113.m128_f32[0] = lastGameplayTime;
			//   *(__m128 *)&cb._CharacterPositionParams2.z = _mm_shuffle_ps(v113, v113, 57);
			//   probeRangeCompressionFactor = HG::Rendering::Runtime::HGCamera::get_probeRangeCompressionFactor(this, 0LL);
			//   if ( probeRangeCompressionFactor <= 0.000001 )
			//     probeRangeCompressionFactor = 0.000001;
			//   cb._CharacterHeightParams.x = 1.0 / probeRangeCompressionFactor;
			// }
			// 
		}

		internal void ReleaseHistoryFrameRT(int id)
		{
			// // Void ReleaseHistoryFrameRT(Int32)
			// void HG::Rendering::Runtime::HGCamera::ReleaseHistoryFrameRT(HGCamera *this, int32_t id, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2359, 0LL) )
			//   {
			//     m_HistoryRTSystem = this.fields.m_HistoryRTSystem;
			//     if ( m_HistoryRTSystem )
			//     {
			//       UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseBuffer(m_HistoryRTSystem, id, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_HistoryRTSystem, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2359, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, id, 0LL);
			// }
			// 
		}

		private void UpdateAntialiasing()
		{
			// // Void UpdateAntialiasing()
			// void HG::Rendering::Runtime::HGCamera::UpdateAntialiasing(HGCamera *this, MethodInfo *method)
			// {
			//   __int64 *static_fields; // rcx
			//   HGAdditionalCameraData_AntialiasingMode__Enum *wrapperArray; // rdx
			//   int32_t m_antialiasingMode; // esi
			//   bool v6; // al
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rdi
			//   HGAdditionalCameraData_AntialiasingMode__Enum v8; // edx
			//   Camera *camera; // rdi
			//   void (__fastcall *v10)(Camera *, __int64); // rax
			//   int32_t m_PreviousClearColorMode; // edi
			//   TileBase *v12; // rdx
			//   Vector3Int *v13; // r8
			//   ITilemap *v14; // r9
			//   bool v15; // al
			//   __int64 v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rax
			//   ILFixDynamicMethodWrapper_2 *v19; // rax
			//   __int64 v20; // rax
			//   __int64 v21; // rax
			//   ILFixDynamicMethodWrapper_2 *v22; // rax
			//   BitArray128 bitDatas; // [rsp+20h] [rbp-38h] BYREF
			//   FrameSettings P0; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDA1A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDA1A = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   wrapperArray = (HGAdditionalCameraData_AntialiasingMode__Enum *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_55;
			//   if ( *((int *)wrapperArray + 6) > 677 )
			//   {
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     wrapperArray = (HGAdditionalCameraData_AntialiasingMode__Enum *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//     v16 = *(_QWORD *)wrapperArray;
			//     if ( !*(_QWORD *)wrapperArray )
			//       goto LABEL_55;
			//     if ( *(_DWORD *)(v16 + 24) <= 0x2A5u )
			//       goto LABEL_81;
			//     if ( *(_QWORD *)(v16 + 5448) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(677, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_55;
			//     }
			//   }
			//   m_antialiasingMode = this.fields.m_antialiasingMode;
			//   bitDatas = this.fields._frameSettings_k__BackingField.bitDatas;
			//   P0.bitDatas = bitDatas;
			//   *(_QWORD *)&P0.materialQuality = *(_QWORD *)&this.fields._frameSettings_k__BackingField.materialQuality;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   wrapperArray = (HGAdditionalCameraData_AntialiasingMode__Enum *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_55;
			//   if ( *((int *)wrapperArray + 6) <= 679 )
			//     goto LABEL_15;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//   wrapperArray = (HGAdditionalCameraData_AntialiasingMode__Enum *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//   v18 = *(_QWORD *)wrapperArray;
			//   if ( !*(_QWORD *)wrapperArray )
			//     goto LABEL_55;
			//   if ( *(_DWORD *)(v18 + 24) <= 0x2A7u )
			//     goto LABEL_81;
			//   if ( *(_QWORD *)(v18 + 5464) )
			//   {
			//     v19 = IFix::WrappersManagerImpl::GetPatch(679, 0LL);
			//     if ( !v19 )
			//       goto LABEL_55;
			//     v6 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_256(v19, &P0, FrameSettingsField__Enum_Postprocess, 0LL);
			//   }
			//   else
			//   {
			// LABEL_15:
			//     v6 = (bitDatas.data1 & 0x8000) != 0LL;
			//   }
			//   if ( !v6 )
			//   {
			//     v8 = HGAdditionalCameraData_AntialiasingMode__Enum_None;
			// LABEL_33:
			//     HG::Rendering::Runtime::HGCamera::set_antialiasing(this, v8, 0LL);
			//     goto LABEL_34;
			//   }
			//   if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, wrapperArray);
			//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( m_AdditionalCameraData )
			//   {
			//     static_fields = (__int64 *)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( m_AdditionalCameraData.fields._._._._.m_CachedPtr )
			//     {
			//       wrapperArray = (HGAdditionalCameraData_AntialiasingMode__Enum *)this.fields.m_AdditionalCameraData;
			//       if ( !wrapperArray )
			//         goto LABEL_55;
			//       v8 = *((_DWORD *)wrapperArray + 18);
			//       goto LABEL_33;
			//     }
			//   }
			// LABEL_34:
			//   if ( (this.fields.m_antialiasingMode & 0xA) != 0 )
			//   {
			//     camera = this.fields.camera;
			//     if ( !camera )
			//       goto LABEL_55;
			//     v10 = (void (__fastcall *)(Camera *, __int64))qword_18D8F4220;
			//     if ( !qword_18D8F4220 )
			//     {
			//       v10 = (void (__fastcall *)(Camera *, __int64))il2cpp_resolve_icall_0(
			//                                                       "UnityEngine.Camera::set_depthTextureMode(UnityEngine.DepthTextureMode)");
			//       if ( !v10 )
			//       {
			//         v20 = sub_1802DBBE8("UnityEngine.Camera::set_depthTextureMode(UnityEngine.DepthTextureMode)");
			//         sub_18000F750(v20, 0LL);
			//       }
			//       qword_18D8F4220 = (__int64)v10;
			//     }
			//     v10(camera, 5LL);
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   wrapperArray = (HGAdditionalCameraData_AntialiasingMode__Enum *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_55;
			//   if ( *((int *)wrapperArray + 6) <= 680 )
			//     goto LABEL_44;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//   static_fields = (__int64 *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//   v21 = *static_fields;
			//   if ( !*static_fields )
			// LABEL_55:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( *(_DWORD *)(v21 + 24) <= 0x2A8u )
			// LABEL_81:
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( *(_QWORD *)(v21 + 5472) )
			//   {
			//     v22 = IFix::WrappersManagerImpl::GetPatch(680, 0LL);
			//     if ( v22 )
			//     {
			//       v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v22, (Object *)this, 0LL);
			// LABEL_52:
			//       if ( !v15 )
			//       {
			//         this.fields.taaFrameIndex = 0;
			//         this.fields.taaJitter = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                              (TileAnimationData *)&bitDatas,
			//                                              v12,
			//                                              v13,
			//                                              v14,
			//                                              (MethodInfo *)bitDatas.data1);
			//       }
			//       goto LABEL_45;
			//     }
			//     goto LABEL_55;
			//   }
			// LABEL_44:
			//   if ( (this.fields.m_antialiasingMode & 2) == 0
			//     && (!UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL) || (this.fields.m_antialiasingMode & 8) == 0)
			//     && (this.fields.m_antialiasingMode & 0x10) == 0
			//     && (this.fields.m_antialiasingMode & 0x20) == 0 )
			//   {
			//     v15 = (this.fields.m_antialiasingMode & 0x40) != 0;
			//     goto LABEL_52;
			//   }
			// LABEL_45:
			//   if ( ((LOBYTE(this.fields.m_antialiasingMode) ^ (unsigned __int8)m_antialiasingMode) & 2) != 0
			//     || (m_PreviousClearColorMode = this.fields.m_PreviousClearColorMode,
			//         m_PreviousClearColorMode != HG::Rendering::Runtime::HGCamera::get_clearColorMode(this, 0LL)) )
			//   {
			//     this.fields.resetPostProcessingHistory = 1;
			//     this.fields.m_PreviousClearColorMode = HG::Rendering::Runtime::HGCamera::get_clearColorMode(this, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateRenderingScale(HGSettingParameters hgSetting, Vector2Int nonScaledViewport)
		{
			// // Void UpdateRenderingScale(HGSettingParameters, Vector2Int)
			// void HG::Rendering::Runtime::HGCamera::UpdateRenderingScale(
			//         HGCamera *this,
			//         HGSettingParameters *hgSetting,
			//         Vector2Int nonScaledViewport,
			//         MethodInfo *method)
			// {
			//   void *optimalRenderWidth; // rcx
			//   SettingParameter_1_UnityEngine_HyperGryphEngineCode_DLSSQuality_ *dlssQuality_k__BackingField; // rdx
			//   BOOL v9; // esi
			//   bool v10; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float FSR3RenderScale; // xmm0_4
			//   SettingParameter_1_System_Single_ *v13; // rax
			//   float v14; // xmm7_4
			//   struct MathF__Class *v15; // rcx
			//   float paramValue_k__BackingField; // xmm6_4
			//   SettingParameter_1_System_Single_ *renderingScale_k__BackingField; // rax
			//   DLSSOptimalSettings v18; // [rsp+50h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDA1B )
			//   {
			//     sub_18003C530(&TypeInfo::System::MathF);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Override);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::FSR3Quality>::get_paramValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::HyperGryphEngineCode::DLSSQuality>::get_paramValue);
			//     byte_18D8EDA1B = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   optimalRenderWidth = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgSetting);
			//     optimalRenderWidth = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   dlssQuality_k__BackingField = (SettingParameter_1_UnityEngine_HyperGryphEngineCode_DLSSQuality_ *)**((_QWORD **)optimalRenderWidth + 23);
			//   if ( !dlssQuality_k__BackingField )
			//     goto LABEL_16;
			//   if ( SLODWORD(dlssQuality_k__BackingField.fields._._paramName_k__BackingField) > 688 )
			//   {
			//     if ( !*((_DWORD *)optimalRenderWidth + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(optimalRenderWidth, dlssQuality_k__BackingField);
			//       optimalRenderWidth = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     optimalRenderWidth = (void *)**((_QWORD **)optimalRenderWidth + 23);
			//     if ( !optimalRenderWidth )
			//       goto LABEL_16;
			//     if ( *((_DWORD *)optimalRenderWidth + 6) <= 0x2B0u )
			//       sub_180070270(optimalRenderWidth, dlssQuality_k__BackingField);
			//     if ( *((_QWORD *)optimalRenderWidth + 692) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(688, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_260(
			//           Patch,
			//           (Object *)this,
			//           (Object *)hgSetting,
			//           nonScaledViewport,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_16;
			//     }
			//   }
			//   v9 = (this.fields.m_antialiasingMode & 0x20) != 0
			//     && UnityEngine::HyperGryph::HGDLSSUtil::IsStreamlineDLSSSupported(0LL);
			//   v10 = (this.fields.m_antialiasingMode & 0x40) != 0
			//      && UnityEngine::HyperGryphEngineCode::HGFSR3Util::IsFSR3Supported(0LL);
			//   if ( v9 )
			//   {
			//     if ( !hgSetting )
			//       goto LABEL_16;
			//     dlssQuality_k__BackingField = hgSetting.fields._dlssQuality_k__BackingField;
			//     if ( !dlssQuality_k__BackingField )
			//       goto LABEL_16;
			//     optimalRenderWidth = (void *)UnityEngine::HyperGryphEngineCode::DLSSOptimalSettings::GetDLSSOptimalSetting(
			//                                    &v18,
			//                                    (DLSSQuality__Enum)dlssQuality_k__BackingField.fields._paramValue_k__BackingField,
			//                                    nonScaledViewport,
			//                                    0LL).optimalRenderWidth;
			//     renderingScale_k__BackingField = hgSetting.fields._renderingScale_k__BackingField;
			//     v14 = (float)(int)optimalRenderWidth / (float)nonScaledViewport.m_X;
			//     if ( !renderingScale_k__BackingField )
			//       goto LABEL_16;
			//     v15 = TypeInfo::System::MathF;
			//     paramValue_k__BackingField = renderingScale_k__BackingField.fields._paramValue_k__BackingField;
			//     if ( !TypeInfo::System::MathF._1.cctor_finished_or_no_cctor )
			// LABEL_32:
			//       il2cpp_runtime_class_init_0(v15, dlssQuality_k__BackingField);
			//   }
			//   else
			//   {
			//     if ( !v10 )
			//       return;
			//     if ( !hgSetting
			//       || (optimalRenderWidth = hgSetting.fields._fsr3Quality_k__BackingField) == 0LL
			//       || (FSR3RenderScale = UnityEngine::HyperGryphEngineCode::HGFSR3Util::GetFSR3RenderScale(
			//                               *((FSR3Quality__Enum *)optimalRenderWidth + 10),
			//                               0LL),
			//           v13 = hgSetting.fields._renderingScale_k__BackingField,
			//           v14 = FSR3RenderScale,
			//           !v13) )
			//     {
			// LABEL_16:
			//       sub_180B536AC(optimalRenderWidth, dlssQuality_k__BackingField);
			//     }
			//     v15 = TypeInfo::System::MathF;
			//     paramValue_k__BackingField = v13.fields._paramValue_k__BackingField;
			//     if ( !TypeInfo::System::MathF._1.cctor_finished_or_no_cctor )
			//       goto LABEL_32;
			//   }
			//   if ( fabs(paramValue_k__BackingField - v14) > COERCE_FLOAT(1) )
			//   {
			//     optimalRenderWidth = hgSetting.fields._renderingScale_k__BackingField;
			//     if ( optimalRenderWidth )
			//     {
			//       HG::Rendering::Runtime::SettingParameter<float>::Override(
			//         (SettingParameter_1_System_Single_ *)optimalRenderWidth,
			//         v14,
			//         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::Override);
			//       optimalRenderWidth = hgSetting.fields._renderingScale_k__BackingField;
			//       if ( optimalRenderWidth )
			//       {
			//         HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
			//           (HGRenderPipelineSettingHub_SettingParameterBase *)optimalRenderWidth,
			//           0LL);
			//         return;
			//       }
			//     }
			//     goto LABEL_16;
			//   }
			// }
			// 
		}

		[IDTag(1)]
		private void UpdateAllViewConstants(HGRenderPipeline hgrp)
		{
			// // Void UpdateAllViewConstants(HGRenderPipeline)
			// void HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(
			//         HGCamera *this,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__StaticFields *wrapperArray; // rdx
			//   bool v8; // al
			//   ILFixDynamicMethodWrapper_2__Array *v9; // r8
			//   ILFixDynamicMethodWrapper_2 *v10; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgrp);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_21;
			//   if ( SLODWORD(wrapperArray[3].wrapperArray) <= 704 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields;
			//   v9 = wrapperArray.wrapperArray;
			//   if ( !wrapperArray.wrapperArray )
			//     goto LABEL_21;
			//   if ( v9.max_length.size <= 0x2C0u )
			//     goto LABEL_36;
			//   if ( !v9[19].vector[20] )
			//   {
			// LABEL_7:
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields.wrapperArray;
			//     if ( !static_fields.wrapperArray )
			//       goto LABEL_21;
			//     if ( SLODWORD(wrapperArray[3].wrapperArray) <= 680 )
			//       goto LABEL_13;
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     v11 = static_fields.wrapperArray;
			//     if ( !static_fields.wrapperArray )
			//       goto LABEL_21;
			//     if ( v11.max_length.size > 0x2A8u )
			//     {
			//       if ( !v11[19].klass )
			//       {
			// LABEL_13:
			//         v8 = (this.fields.m_antialiasingMode & 2) != 0
			//           || UnityEngine::SystemInfo::SupportsMetalFXTemporalScaler(0LL) && (this.fields.m_antialiasingMode & 8) != 0
			//           || (this.fields.m_antialiasingMode & 0x10) != 0
			//           || (this.fields.m_antialiasingMode & 0x20) != 0
			//           || (this.fields.m_antialiasingMode & 0x40) != 0;
			//         goto LABEL_15;
			//       }
			//       Patch = IFix::WrappersManagerImpl::GetPatch(680, 0LL);
			//       if ( Patch )
			//       {
			//         v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// LABEL_15:
			//         HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(this, v8, 1, hgrp, 0LL);
			//         return;
			//       }
			// LABEL_21:
			//       sub_180B536AC(static_fields, wrapperArray);
			//     }
			// LABEL_36:
			//     sub_180070270(static_fields, wrapperArray);
			//   }
			//   v10 = IFix::WrappersManagerImpl::GetPatch(704, 0LL);
			//   if ( !v10 )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)v10,
			//     (Object *)this,
			//     (Object *)hgrp,
			//     0LL);
			// }
			// 
		}

		[IDTag(0)]
		private void UpdateAllViewConstants(bool jitterProjectionMatrix, bool updatePreviousFrameConstants, HGRenderPipeline hgrp)
		{
			// // Void UpdateAllViewConstants(Boolean, Boolean, HGRenderPipeline)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGCamera::UpdateAllViewConstants(
			//         HGCamera *this,
			//         bool jitterProjectionMatrix,
			//         bool updatePreviousFrameConstants,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Camera *camera; // rdi
			//   void (__fastcall *v12)(Camera *, Matrix4x4 *); // rax
			//   Camera *v13; // rdi
			//   void (__fastcall *v14)(Camera *, Matrix4x4 *); // rax
			//   Camera *v15; // rdi
			//   void (__fastcall *v16)(Camera *, Matrix4x4 *); // rax
			//   Camera *v17; // rdi
			//   __int64 (__fastcall *v18)(Camera *); // rax
			//   __int64 v19; // rdi
			//   void (__fastcall *v20)(__int64, Vector3 *); // rax
			//   __int64 v21; // rdx
			//   Camera *v22; // rdi
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rax
			//   __int64 v28; // rax
			//   __int64 v29; // rax
			//   __int64 v30; // rax
			//   __int64 v31; // rax
			//   Object *P3; // [rsp+20h] [rbp-E0h]
			//   MethodInfo *v33; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *v34; // [rsp+30h] [rbp-D0h]
			//   Vector3 v35; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector3 v36; // [rsp+60h] [rbp-A0h] BYREF
			//   Matrix4x4 v37; // [rsp+70h] [rbp-90h] BYREF
			//   Matrix4x4 v38; // [rsp+B0h] [rbp-50h] BYREF
			//   Matrix4x4 v39; // [rsp+F0h] [rbp-10h] BYREF
			//   Matrix4x4 v40; // [rsp+130h] [rbp+30h] BYREF
			// 
			//   if ( !byte_18D8EDA1C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CameraCaptureBridge);
			//     byte_18D8EDA1C = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, jitterProjectionMatrix);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size <= 705 )
			//     goto LABEL_9;
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//   if ( !v9 )
			// LABEL_22:
			//     sub_180B536AC(v9, wrapperArray);
			//   if ( LODWORD(v9._0.namespaze) <= 0x2C1 )
			//     sub_180070270(v9, wrapperArray);
			//   if ( v9[15]._0.byval_arg.data.dummy )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(705, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_270(
			//         Patch,
			//         (Object *)this,
			//         jitterProjectionMatrix,
			//         updatePreviousFrameConstants,
			//         (Object *)hgrp,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_22;
			//   }
			// LABEL_9:
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_22;
			//   v12 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18D8F42F0;
			//   memset(&v39, 0, sizeof(v39));
			//   if ( !qword_18D8F42F0 )
			//   {
			//     v12 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v12 )
			//     {
			//       v27 = sub_1802DBBE8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v27, 0LL);
			//     }
			//     qword_18D8F42F0 = (__int64)v12;
			//   }
			//   v12(camera, &v39);
			//   v13 = this.fields.camera;
			//   if ( !v13 )
			//     goto LABEL_22;
			//   v14 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18D8F42E8;
			//   memset(&v38, 0, sizeof(v38));
			//   if ( !qword_18D8F42E8 )
			//   {
			//     v14 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v14 )
			//     {
			//       v28 = sub_1802DBBE8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v28, 0LL);
			//     }
			//     qword_18D8F42E8 = (__int64)v14;
			//   }
			//   v14(v13, &v38);
			//   v15 = this.fields.camera;
			//   if ( !v15 )
			//     goto LABEL_22;
			//   v16 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18D8F42E0;
			//   memset(&v37, 0, sizeof(v37));
			//   if ( !qword_18D8F42E0 )
			//   {
			//     v16 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Camera::get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v16 )
			//     {
			//       v29 = sub_1802DBBE8("UnityEngine.Camera::get_cameraToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v29, 0LL);
			//     }
			//     qword_18D8F42E0 = (__int64)v16;
			//   }
			//   v16(v15, &v37);
			//   v17 = this.fields.camera;
			//   if ( !v17 )
			//     goto LABEL_22;
			//   v18 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v18 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v18 )
			//     {
			//       v30 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v30, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v18;
			//   }
			//   v19 = v18(v17);
			//   if ( !v19 )
			//     goto LABEL_22;
			//   *(_QWORD *)&v35.x = 0LL;
			//   v35.z = 0.0;
			//   v20 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v20 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v20 )
			//     {
			//       v31 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v31, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v20;
			//   }
			//   v20(v19, &v35);
			//   v36 = v35;
			//   v40 = v37;
			//   v37 = v38;
			//   v38 = v39;
			//   HG::Rendering::Runtime::HGCamera::UpdateViewConstants(
			//     this,
			//     &this.fields.mainViewConstants,
			//     &v38,
			//     &v37,
			//     &v40,
			//     &v36,
			//     jitterProjectionMatrix,
			//     updatePreviousFrameConstants,
			//     hgrp,
			//     0LL);
			//   HG::Rendering::Runtime::HGCamera::UpdateFrustum(this, &this.fields.mainViewConstants, 0LL);
			//   v22 = this.fields.camera;
			//   if ( !TypeInfo::UnityEngine::Rendering::CameraCaptureBridge._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CameraCaptureBridge, v21);
			//   this.fields.m_RecorderCaptureActions = UnityEngine::Rendering::CameraCaptureBridge::GetCaptureActions(v22, 0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_RecorderCaptureActions,
			//     v23,
			//     v24,
			//     v25,
			//     (String__Array *)P3,
			//     (String *)v33,
			//     v34);
			// }
			// 
		}

		public static Matrix4x4 CalculateInvProjectionMatrix(in Matrix4x4 matrix)
		{
			// // Matrix4x4 CalculateInvProjectionMatrix(Matrix4x4 ByRef)
			// Matrix4x4 *HG::Rendering::Runtime::HGCamera::CalculateInvProjectionMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         Matrix4x4 *matrix,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float m12; // xmm6_4
			//   float v8; // xmm1_4
			//   Matrix4x4 *result; // rax
			//   float v10; // xmm6_4
			//   float v11; // xmm5_4
			//   float v12; // xmm3_4
			//   float v13; // xmm4_4
			//   __int128 m00_low; // xmm0
			//   __m128 v15; // xmm1
			//   __m128 v16; // xmm0
			//   __m128 v17; // xmm1
			//   __m128 v18; // xmm0
			//   __m128 v19; // xmm1
			//   __m128 v20; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 *v22; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   Matrix4x4 v26; // [rsp+20h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, matrix);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 709 )
			//   {
			// LABEL_7:
			//     m12 = matrix.m12;
			//     v8 = 1.0 / matrix.m00;
			//     *(_QWORD *)&v26.m30 = 0LL;
			//     *(_QWORD *)&v26.m10 = 0LL;
			//     memset(&v26.m21, 0, 20);
			//     result = retstr;
			//     v26.m23 = -1.0;
			//     v10 = m12 / matrix.m11;
			//     v11 = matrix.m02 / matrix.m00;
			//     v12 = 1.0 / matrix.m23;
			//     v13 = matrix.m22 / matrix.m23;
			//     m00_low = LODWORD(v26.m00);
			//     *(float *)&m00_low = v8;
			//     v15 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v26.m01, (__m128)*(unsigned __int64 *)&v26.m01, 225);
			//     v15.m128_f32[0] = 1.0 / matrix.m11;
			//     *(_OWORD *)&retstr.m00 = m00_low;
			//     v16 = *(__m128 *)&v26.m02;
			//     *(__m128 *)&retstr.m01 = _mm_shuffle_ps(v15, v15, 225);
			//     v17 = *(__m128 *)&v26.m03;
			//     v17.m128_f32[0] = v11;
			//     v18 = _mm_shuffle_ps(v16, v16, 147);
			//     v19 = _mm_shuffle_ps(v17, v17, 225);
			//     v18.m128_f32[0] = v12;
			//     v19.m128_f32[0] = v10;
			//     v20 = _mm_shuffle_ps(v19, v19, 135);
			//     v20.m128_f32[0] = v13;
			//     *(__m128 *)&retstr.m02 = _mm_shuffle_ps(v18, v18, 57);
			//     *(__m128 *)&retstr.m03 = _mm_shuffle_ps(v20, v20, 57);
			//     return result;
			//   }
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_8;
			//   if ( LODWORD(v5._0.namespaze) <= 0x2C5 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !v5[15]._0.element_class )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(709, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v5, wrapperArray);
			//   v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_263(&v26, Patch, matrix, 0LL);
			//   v23 = *(_OWORD *)&v22.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v22.m00;
			//   v24 = *(_OWORD *)&v22.m02;
			//   *(_OWORD *)&retstr.m01 = v23;
			//   v25 = *(_OWORD *)&v22.m03;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v24;
			//   *(_OWORD *)&retstr.m03 = v25;
			//   return result;
			// }
			// 
			return null;
		}

		private void UpdateViewConstants(ref HGCamera.ViewConstants viewConstants, Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Matrix4x4 invViewMatrix, Vector3 cameraPosition, bool jitterProjectionMatrix, bool updatePreviousFrameConstants, HGRenderPipeline hgrp)
		{
			// // Void UpdateViewConstants(HGCamera+ViewConstants ByRef, Matrix4x4, Matrix4x4, Matrix4x4, Vector3, Boolean, Boolean, HGRenderPipeline)
			// void HG::Rendering::Runtime::HGCamera::UpdateViewConstants(
			//         HGCamera *this,
			//         HGCamera_ViewConstants *viewConstants,
			//         Matrix4x4 *projMatrix,
			//         Matrix4x4 *viewMatrix,
			//         Matrix4x4 *invViewMatrix,
			//         Vector3 *cameraPosition,
			//         bool jitterProjectionMatrix,
			//         bool updatePreviousFrameConstants,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v14; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   Matrix4x4 *JitteredProjectionMatrix; // rax
			//   __int128 v21; // xmm2
			//   __int128 v22; // xmm3
			//   void (__fastcall *v23)(__int128 *, ILFixDynamicMethodWrapper_2__Array *, Matrix4x4 *); // rax
			//   __int64 v24; // rdx
			//   void (__fastcall *v25)(Matrix4x4 *, __int64, Matrix4x4 *); // rax
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm10
			//   __m128 v28; // xmm7
			//   __m128 v29; // xmm8
			//   __m128 v30; // xmm11
			//   __int128 v31; // xmm1
			//   void (__fastcall *v32)(__int128 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm14
			//   __int128 v35; // xmm15
			//   __int128 v36; // xmm6
			//   __int128 v37; // xmm13
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   void (__fastcall *v42)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   void (__fastcall *v43)(Matrix4x4 *, Matrix4x4 *, __int128 *); // rax
			//   __int128 v44; // xmm1
			//   float v45; // eax
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   __int128 v52; // xmm1
			//   __int128 v53; // xmm0
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm0
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm0
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm1
			//   Camera *camera; // r14
			//   unsigned __int8 (__fastcall *v73)(Camera *); // rax
			//   __int64 v74; // rdx
			//   __int128 m00_low; // xmm13
			//   float v76; // xmm0_4
			//   float v77; // xmm2_4
			//   float v78; // xmm5_4
			//   __m128 v79; // xmm3
			//   float v80; // xmm0_4
			//   float v81; // xmm1_4
			//   float v82; // xmm4_4
			//   __m128 v83; // xmm0
			//   __m128 v84; // xmm2
			//   __m128 v85; // xmm0
			//   __m128 v86; // xmm2
			//   __m128 v87; // xmm0
			//   __m128 v88; // xmm3
			//   __m128 v89; // xmm0
			//   __int128 v90; // xmm1
			//   void (__fastcall *v91)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v92; // xmm1
			//   __int128 v93; // xmm1
			//   __int128 v94; // xmm0
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm0
			//   Camera *v97; // r14
			//   unsigned __int8 (__fastcall *v98)(Camera *); // rax
			//   void (__fastcall *v99)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v100; // xmm1
			//   __int128 v101; // xmm1
			//   __int128 v102; // xmm1
			//   __int128 v103; // xmm1
			//   __int128 v104; // xmm0
			//   __int128 v105; // xmm1
			//   __int128 v106; // xmm2
			//   __int128 v107; // xmm3
			//   void (__fastcall *v108)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v109; // xmm0
			//   __int128 v110; // xmm1
			//   __int128 v111; // xmm1
			//   void (__fastcall *v112)(Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v113; // xmm1
			//   __int128 v114; // xmm0
			//   __int128 v115; // xmm1
			//   __int128 v116; // xmm0
			//   __int128 v117; // xmm1
			//   __int128 v118; // xmm1
			//   float v119; // eax
			//   __int128 v120; // xmm1
			//   __int128 v121; // xmm0
			//   __int128 v122; // xmm1
			//   Matrix4x4 *HGCameraCullingMatrix; // rax
			//   __int64 v124; // rdx
			//   __int128 v125; // xmm1
			//   __int128 v126; // xmm2
			//   __int128 v127; // xmm3
			//   float v128; // xmm7_4
			//   __int64 v129; // rax
			//   float m_X; // xmm1_4
			//   Matrix4x4 *v131; // rax
			//   __int128 v132; // xmm1
			//   __int128 v133; // xmm2
			//   __int128 v134; // xmm3
			//   void (__fastcall *v135)(Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v136; // xmm1
			//   __int128 v137; // xmm1
			//   void (__fastcall *v138)(Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v139; // xmm1
			//   __int128 v140; // xmm0
			//   __int128 v141; // xmm1
			//   __int128 v142; // xmm1
			//   __int128 v143; // xmm1
			//   void (__fastcall *v144)(Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v145; // xmm1
			//   __int128 v146; // xmm6
			//   __int128 v147; // xmm7
			//   __int128 v148; // xmm8
			//   __int128 v149; // xmm10
			//   __int128 v150; // xmm0
			//   __int128 v151; // xmm1
			//   __int128 v152; // xmm1
			//   __int128 v153; // xmm1
			//   void (__fastcall *v154)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v155; // xmm1
			//   __int128 v156; // xmm0
			//   __int128 v157; // xmm1
			//   Camera *v158; // rsi
			//   unsigned __int8 (__fastcall *v159)(Camera *); // rax
			//   Camera *v160; // rsi
			//   unsigned int (__fastcall *v161)(Camera *); // rax
			//   Camera *v162; // rsi
			//   __int64 (__fastcall *v163)(Camera *); // rax
			//   __int64 v164; // rsi
			//   void (__fastcall *v165)(__int64, Quaternion *); // rax
			//   Vector3 *v166; // rax
			//   Camera *v167; // rsi
			//   __int64 v168; // xmm7_8
			//   float v169; // r14d
			//   __int64 (__fastcall *v170)(Camera *); // rax
			//   __int64 v171; // rsi
			//   void (__fastcall *v172)(__int64, Quaternion *); // rax
			//   Camera *v173; // rsi
			//   void (__fastcall *v174)(Camera *); // rax
			//   MethodInfo *v175; // r8
			//   float v176; // xmm2_4
			//   MethodInfo *v177; // r9
			//   Vector3 *v178; // rax
			//   __int64 v179; // xmm3_8
			//   MethodInfo *v180; // r9
			//   Vector3 *v181; // rax
			//   __int64 v182; // xmm3_8
			//   Matrix4x4 *v183; // rax
			//   Camera *v184; // rsi
			//   __int128 v185; // xmm10
			//   __int128 v186; // xmm11
			//   __int128 v187; // xmm13
			//   __int128 v188; // xmm14
			//   void (__fastcall *v189)(Camera *); // rax
			//   Camera *v190; // rsi
			//   void (__fastcall *v191)(Camera *); // rax
			//   Camera *v192; // rsi
			//   void (__fastcall *v193)(Camera *); // rax
			//   void (__fastcall *v194)(Matrix4x4 *); // rax
			//   __int64 v195; // rdx
			//   void (__fastcall *v196)(Matrix4x4 *, __int64, Matrix4x4 *); // rax
			//   __int128 v197; // xmm15
			//   float m00; // xmm9_4
			//   void (__fastcall *v199)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __m128 v200; // xmm7
			//   __m128 v201; // xmm6
			//   __m128 v202; // xmm8
			//   void (__fastcall *v203)(Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v204; // xmm1
			//   __int128 v205; // xmm0
			//   __int128 v206; // xmm1
			//   __int64 v207; // rdx
			//   float v208; // xmm7_4
			//   float v209; // xmm8_4
			//   float v210; // xmm2_4
			//   __m128 v211; // xmm4
			//   float v212; // xmm12_4
			//   __m128 v213; // xmm5
			//   __m128 v214; // xmm4
			//   float v215; // xmm6_4
			//   __m128 v216; // xmm4
			//   __m128 v217; // xmm7
			//   __m128 v218; // xmm4
			//   __int128 v219; // xmm8
			//   __m128 v220; // xmm5
			//   __m128 v221; // xmm7
			//   void (__fastcall *v222)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   void (__fastcall *v223)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v224; // xmm1
			//   __int128 v225; // xmm0
			//   __int128 v226; // xmm1
			//   __int128 v227; // xmm0
			//   __int128 v228; // xmm1
			//   __int128 v229; // xmm0
			//   __int128 v230; // xmm1
			//   __int128 v231; // xmm1
			//   float v232; // eax
			//   __int128 v233; // xmm0
			//   __int128 v234; // xmm0
			//   __int128 v235; // xmm1
			//   __int128 v236; // xmm0
			//   __int128 v237; // xmm1
			//   __int128 v238; // xmm0
			//   __int128 v239; // xmm1
			//   Matrix4x4 *inverse; // rax
			//   __int128 v241; // xmm1
			//   __int128 v242; // xmm2
			//   __int128 v243; // xmm3
			//   __int128 v244; // xmm0
			//   __int128 v245; // xmm0
			//   __int128 v246; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // r10
			//   float z; // ecx
			//   __int128 v249; // xmm1
			//   __int128 v250; // xmm0
			//   __int128 v251; // xmm1
			//   __int128 v252; // xmm0
			//   __int128 v253; // xmm1
			//   __int128 v254; // xmm0
			//   __int128 v255; // xmm1
			//   __int128 v256; // xmm0
			//   __int128 v257; // xmm1
			//   __int128 v258; // xmm0
			//   __int128 v259; // xmm1
			//   __int64 v260; // rax
			//   __int64 v261; // rax
			//   __int64 v262; // rax
			//   __int64 v263; // rax
			//   __int64 v264; // rax
			//   __int64 v265; // rax
			//   Matrix4x4 *v266; // rax
			//   ILFixDynamicMethodWrapper_2 *v267; // rax
			//   Matrix4x4 *v268; // rax
			//   __int64 v269; // rax
			//   __int64 v270; // rax
			//   Matrix4x4 *v271; // rax
			//   __int64 v272; // rax
			//   __int64 v273; // rax
			//   __int64 v274; // rax
			//   ILFixDynamicMethodWrapper_2 *v275; // rax
			//   __int64 v276; // rax
			//   __int64 v277; // rax
			//   __int64 v278; // rax
			//   __int64 v279; // rax
			//   __int64 v280; // rax
			//   __int64 v281; // rax
			//   __int64 v282; // rax
			//   __int64 v283; // rax
			//   __int64 v284; // rax
			//   __int64 v285; // rax
			//   __int64 v286; // rax
			//   __int64 v287; // rax
			//   __int64 v288; // rax
			//   __int64 v289; // rax
			//   __int64 v290; // rax
			//   __int64 v291; // rax
			//   __int64 v292; // rax
			//   __int64 v293; // rax
			//   ILFixDynamicMethodWrapper_2 *v294; // rax
			//   Matrix4x4 *v295; // rax
			//   __int64 v296; // rax
			//   __int64 v297; // rax
			//   __int128 v298; // xmm1
			//   __int128 v299; // xmm2
			//   __int128 v300; // xmm3
			//   __int128 v301; // xmm0
			//   __int128 v302; // xmm1
			//   __int128 v303; // xmm0
			//   __int128 v304; // xmm1
			//   __int128 v305; // xmm0
			//   __int128 v306; // xmm1
			//   __int128 v307; // xmm0
			//   __int128 v308; // xmm1
			//   Matrix4x4 v309; // [rsp+60h] [rbp-A0h] BYREF
			//   Vector3 v310; // [rsp+A0h] [rbp-60h] BYREF
			//   Vector3 v311; // [rsp+B0h] [rbp-50h] BYREF
			//   Quaternion v312; // [rsp+C0h] [rbp-40h] BYREF
			//   Matrix4x4 v313; // [rsp+D0h] [rbp-30h] BYREF
			//   Matrix4x4 P0; // [rsp+110h] [rbp+10h] BYREF
			//   Matrix4x4 v315; // [rsp+150h] [rbp+50h] BYREF
			//   Matrix4x4 v316; // [rsp+190h] [rbp+90h] BYREF
			//   Matrix4x4 v317; // [rsp+1D0h] [rbp+D0h] BYREF
			//   Matrix4x4 v318; // [rsp+210h] [rbp+110h] BYREF
			//   Matrix4x4 v319; // [rsp+250h] [rbp+150h] BYREF
			//   __int128 v320; // [rsp+290h] [rbp+190h] BYREF
			//   __int128 v321; // [rsp+2A0h] [rbp+1A0h]
			//   __int128 v322; // [rsp+2B0h] [rbp+1B0h]
			//   __int128 v323; // [rsp+2C0h] [rbp+1C0h]
			//   Matrix4x4 v324; // [rsp+2D0h] [rbp+1D0h] BYREF
			//   Quaternion v325; // [rsp+310h] [rbp+210h] BYREF
			// 
			//   if ( !byte_18D8EDA1D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDA1D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, viewConstants);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v14.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_93;
			//   if ( wrapperArray.max_length.size > 706 )
			//   {
			//     if ( !v14._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v14, wrapperArray);
			//       v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v14.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_93;
			//     if ( wrapperArray.max_length.size <= 0x2C2u )
			//       goto LABEL_212;
			//     if ( wrapperArray[19].vector[22] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(706, 0LL);
			//       if ( Patch )
			//       {
			//         z = cameraPosition.z;
			//         *(_QWORD *)&v310.x = *(_QWORD *)&cameraPosition.x;
			//         v310.z = z;
			//         v249 = *(_OWORD *)&invViewMatrix.m01;
			//         *(_OWORD *)&v309.m00 = *(_OWORD *)&invViewMatrix.m00;
			//         v250 = *(_OWORD *)&invViewMatrix.m02;
			//         *(_OWORD *)&v309.m01 = v249;
			//         v251 = *(_OWORD *)&invViewMatrix.m03;
			//         *(_OWORD *)&v309.m02 = v250;
			//         v252 = *(_OWORD *)&viewMatrix.m00;
			//         *(_OWORD *)&v309.m03 = v251;
			//         v253 = *(_OWORD *)&viewMatrix.m01;
			//         *(_OWORD *)&P0.m00 = v252;
			//         v254 = *(_OWORD *)&viewMatrix.m02;
			//         *(_OWORD *)&P0.m01 = v253;
			//         v255 = *(_OWORD *)&viewMatrix.m03;
			//         *(_OWORD *)&P0.m02 = v254;
			//         v256 = *(_OWORD *)&projMatrix.m00;
			//         *(_OWORD *)&P0.m03 = v255;
			//         v257 = *(_OWORD *)&projMatrix.m01;
			//         *(_OWORD *)&v319.m00 = v256;
			//         v258 = *(_OWORD *)&projMatrix.m02;
			//         *(_OWORD *)&v319.m01 = v257;
			//         v259 = *(_OWORD *)&projMatrix.m03;
			//         *(_OWORD *)&v319.m02 = v258;
			//         *(_OWORD *)&v319.m03 = v259;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_268(
			//           Patch,
			//           (Object *)this,
			//           viewConstants,
			//           &v319,
			//           &P0,
			//           &v309,
			//           &v310,
			//           jitterProjectionMatrix,
			//           updatePreviousFrameConstants,
			//           (Object *)hgrp,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_93;
			//     }
			//   }
			//   v16 = *(_OWORD *)&projMatrix.m00;
			//   v17 = *(_OWORD *)&projMatrix.m01;
			//   if ( jitterProjectionMatrix )
			//   {
			//     *(_OWORD *)&v309.m00 = *(_OWORD *)&projMatrix.m00;
			//     v18 = *(_OWORD *)&projMatrix.m02;
			//     *(_OWORD *)&v309.m01 = v17;
			//     v19 = *(_OWORD *)&projMatrix.m03;
			//     *(_OWORD *)&v309.m02 = v18;
			//     *(_OWORD *)&v309.m03 = v19;
			//     JitteredProjectionMatrix = HG::Rendering::Runtime::HGCamera::GetJitteredProjectionMatrix(
			//                                  &v315,
			//                                  this,
			//                                  &v309,
			//                                  hgrp,
			//                                  0LL);
			//     v16 = *(_OWORD *)&JitteredProjectionMatrix.m00;
			//     v17 = *(_OWORD *)&JitteredProjectionMatrix.m01;
			//     v21 = *(_OWORD *)&JitteredProjectionMatrix.m02;
			//     v22 = *(_OWORD *)&JitteredProjectionMatrix.m03;
			//   }
			//   else
			//   {
			//     v21 = *(_OWORD *)&projMatrix.m02;
			//     v22 = *(_OWORD *)&projMatrix.m03;
			//   }
			//   v23 = (void (__fastcall *)(__int128 *, ILFixDynamicMethodWrapper_2__Array *, Matrix4x4 *))qword_18D8F44A8;
			//   v320 = v16;
			//   v321 = v17;
			//   v322 = v21;
			//   v323 = v22;
			//   memset(&v316, 0, sizeof(v316));
			//   if ( !qword_18D8F44A8 )
			//   {
			//     v23 = (void (__fastcall *)(__int128 *, ILFixDynamicMethodWrapper_2__Array *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                                 "UnityEngine.GL::GetGPUPr"
			//                                                                                                 "ojectionMatrix_Injected("
			//                                                                                                 "UnityEngine.Matrix4x4&,S"
			//                                                                                                 "ystem.Boolean,UnityEngine.Matrix4x4&)");
			//     if ( !v23 )
			//     {
			//       v260 = sub_1802DBBE8(
			//                "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v260, 0LL);
			//     }
			//     qword_18D8F44A8 = (__int64)v23;
			//   }
			//   LOBYTE(wrapperArray) = 1;
			//   v23(&v320, wrapperArray, &v316);
			//   v25 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))qword_18D8F44A8;
			//   v26 = *(_OWORD *)&projMatrix.m01;
			//   *(_OWORD *)&v313.m00 = *(_OWORD *)&projMatrix.m00;
			//   *(_OWORD *)&v313.m01 = v26;
			//   v27 = *(_OWORD *)&v316.m00;
			//   *(_OWORD *)&v313.m02 = *(_OWORD *)&projMatrix.m02;
			//   *(_OWORD *)&P0.m00 = *(_OWORD *)&v316.m00;
			//   v28 = *(__m128 *)&v316.m01;
			//   v29 = *(__m128 *)&v316.m02;
			//   *(_OWORD *)&P0.m01 = *(_OWORD *)&v316.m01;
			//   *(_OWORD *)&P0.m02 = *(_OWORD *)&v316.m02;
			//   v30 = *(__m128 *)&v316.m03;
			//   v31 = *(_OWORD *)&projMatrix.m03;
			//   *(_OWORD *)&P0.m03 = *(_OWORD *)&v316.m03;
			//   *(_OWORD *)&v313.m03 = v31;
			//   memset(&v319, 0, sizeof(v319));
			//   if ( !qword_18D8F44A8 )
			//   {
			//     v25 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.GL::GetGPUProjectionMatrix_Injected(Unit"
			//                                                                     "yEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
			//     if ( !v25 )
			//     {
			//       v261 = sub_1802DBBE8(
			//                "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v261, 0LL);
			//     }
			//     qword_18D8F44A8 = (__int64)v25;
			//   }
			//   LOBYTE(v24) = 1;
			//   v25(&v313, v24, &v319);
			//   v32 = (void (__fastcall *)(__int128 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   v33 = *(_OWORD *)&viewMatrix.m01;
			//   *(_OWORD *)&v316.m00 = *(_OWORD *)&viewMatrix.m00;
			//   *(_OWORD *)&v316.m01 = v33;
			//   v34 = *(_OWORD *)&v319.m00;
			//   *(_OWORD *)&v316.m02 = *(_OWORD *)&viewMatrix.m02;
			//   v320 = *(_OWORD *)&v319.m00;
			//   v35 = *(_OWORD *)&v319.m01;
			//   v36 = *(_OWORD *)&v319.m02;
			//   v321 = *(_OWORD *)&v319.m01;
			//   v322 = *(_OWORD *)&v319.m02;
			//   v37 = *(_OWORD *)&v319.m03;
			//   v38 = *(_OWORD *)&viewMatrix.m03;
			//   v323 = *(_OWORD *)&v319.m03;
			//   *(_OWORD *)&v316.m03 = v38;
			//   memset(&v309, 0, sizeof(v309));
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v32 = (void (__fastcall *)(__int128 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_In"
			//                                                                        "jected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4"
			//                                                                        "x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v32 )
			//     {
			//       v262 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v262, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v32;
			//   }
			//   v32(&v320, &v316, &v309);
			//   v39 = *(_OWORD *)&viewMatrix.m01;
			//   *(_OWORD *)&v313.m00 = *(_OWORD *)&viewMatrix.m00;
			//   v40 = *(_OWORD *)&viewMatrix.m02;
			//   *(_OWORD *)&v313.m01 = v39;
			//   v41 = *(_OWORD *)&viewMatrix.m03;
			//   *(_OWORD *)&v313.m02 = v40;
			//   *(_OWORD *)&v313.m03 = v41;
			//   UnityEngine::Matrix4x4::set_Item(&v313, 12, 0.0, 0LL);
			//   UnityEngine::Matrix4x4::set_Item(&v313, 13, 0.0, 0LL);
			//   UnityEngine::Matrix4x4::set_Item(&v313, 14, 0.0, 0LL);
			//   UnityEngine::Matrix4x4::set_Item(&v313, 15, 1.0, 0LL);
			//   v42 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   v324 = v313;
			//   *(_OWORD *)&v318.m00 = v34;
			//   *(_OWORD *)&v318.m01 = v35;
			//   *(_OWORD *)&v318.m02 = v36;
			//   *(_OWORD *)&v318.m03 = v37;
			//   memset(&v316, 0, sizeof(v316));
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v42 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_I"
			//                                                                         "njected(UnityEngine.Matrix4x4&,UnityEngine.Matri"
			//                                                                         "x4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v42 )
			//     {
			//       v263 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v263, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v42;
			//   }
			//   v42(&v318, &v324, &v316);
			//   v43 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))qword_18D8F4BC0;
			//   v317 = v313;
			//   *(_OWORD *)&v315.m00 = v27;
			//   *(__m128 *)&v315.m01 = v28;
			//   *(__m128 *)&v315.m02 = v29;
			//   *(__m128 *)&v315.m03 = v30;
			//   v320 = 0LL;
			//   v321 = 0LL;
			//   v322 = 0LL;
			//   v323 = 0LL;
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v43 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_In"
			//                                                                        "jected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4"
			//                                                                        "x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v43 )
			//     {
			//       v264 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v264, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v43;
			//   }
			//   v43(&v315, &v317, &v320);
			//   if ( updatePreviousFrameConstants )
			//   {
			//     if ( this.fields._isFirstFrame_k__BackingField )
			//     {
			//       v231 = *(_OWORD *)&viewMatrix.m01;
			//       v232 = cameraPosition.z;
			//       *(_QWORD *)&viewConstants.prevWorldSpaceCameraPos.x = *(_QWORD *)&cameraPosition.x;
			//       v233 = *(_OWORD *)&viewMatrix.m00;
			//       viewConstants.prevWorldSpaceCameraPos.z = v232;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m00 = v233;
			//       v234 = *(_OWORD *)&viewMatrix.m02;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m01 = v231;
			//       v235 = *(_OWORD *)&viewMatrix.m03;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m02 = v234;
			//       v236 = *(_OWORD *)&v309.m00;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m03 = v235;
			//       v237 = *(_OWORD *)&v309.m01;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m00 = v236;
			//       v238 = *(_OWORD *)&v309.m02;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m01 = v237;
			//       v239 = *(_OWORD *)&v309.m03;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m02 = v238;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m03 = v239;
			//       inverse = UnityEngine::Matrix4x4::get_inverse(&v318, &viewConstants.prevNonJitteredViewProjMatrix, 0LL);
			//       v241 = *(_OWORD *)&inverse.m01;
			//       v242 = *(_OWORD *)&inverse.m02;
			//       v243 = *(_OWORD *)&inverse.m03;
			//       *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m00 = *(_OWORD *)&inverse.m00;
			//       v244 = v320;
			//       *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m01 = v241;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m00 = v244;
			//       v245 = v321;
			//       *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m02 = v242;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m01 = v245;
			//       v246 = v322;
			//       *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m03 = v243;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m02 = v246;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m03 = v323;
			//       viewConstants.prevNonJitteredViewNoTransProjMatrix = v316;
			//     }
			//     else
			//     {
			//       v44 = *(_OWORD *)&viewConstants.viewMatrix.m01;
			//       v45 = viewConstants.worldSpaceCameraPos.z;
			//       *(_QWORD *)&viewConstants.prevWorldSpaceCameraPos.x = *(_QWORD *)&viewConstants.worldSpaceCameraPos.x;
			//       v46 = *(_OWORD *)&viewConstants.viewMatrix.m00;
			//       viewConstants.prevWorldSpaceCameraPos.z = v45;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m00 = v46;
			//       v47 = *(_OWORD *)&viewConstants.viewMatrix.m02;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m01 = v44;
			//       v48 = *(_OWORD *)&viewConstants.viewMatrix.m03;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m02 = v47;
			//       v49 = *(_OWORD *)&viewConstants.viewProjMatrix.m00;
			//       *(_OWORD *)&viewConstants.prevViewMatrix.m03 = v48;
			//       v50 = *(_OWORD *)&viewConstants.viewProjMatrix.m01;
			//       *(_OWORD *)&viewConstants.prevViewProjMatrix.m00 = v49;
			//       v51 = *(_OWORD *)&viewConstants.viewProjMatrix.m02;
			//       *(_OWORD *)&viewConstants.prevViewProjMatrix.m01 = v50;
			//       v52 = *(_OWORD *)&viewConstants.viewProjMatrix.m03;
			//       *(_OWORD *)&viewConstants.prevViewProjMatrix.m02 = v51;
			//       v53 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m00;
			//       *(_OWORD *)&viewConstants.prevViewProjMatrix.m03 = v52;
			//       v54 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m01;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m00 = v53;
			//       v55 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m02;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m01 = v54;
			//       v56 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m03;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m02 = v55;
			//       v57 = *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m00;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m03 = v56;
			//       v58 = *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m01;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m00 = v57;
			//       v59 = *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m02;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m01 = v58;
			//       v60 = *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m03;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m02 = v59;
			//       v61 = *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m00;
			//       *(_OWORD *)&viewConstants.prevViewNoTransProjMatrix.m03 = v60;
			//       v62 = *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m01;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewNoTransProjMatrix.m00 = v61;
			//       v63 = *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m02;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewNoTransProjMatrix.m01 = v62;
			//       v64 = *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m03;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewNoTransProjMatrix.m02 = v63;
			//       *(_OWORD *)&viewConstants.prevNonJitteredViewNoTransProjMatrix.m03 = v64;
			//     }
			//   }
			//   v65 = *(_OWORD *)&viewMatrix.m01;
			//   *(_OWORD *)&viewConstants.viewMatrix.m00 = *(_OWORD *)&viewMatrix.m00;
			//   v66 = *(_OWORD *)&viewMatrix.m02;
			//   *(_OWORD *)&viewConstants.viewMatrix.m01 = v65;
			//   v67 = *(_OWORD *)&viewMatrix.m03;
			//   *(_OWORD *)&viewConstants.viewMatrix.m02 = v66;
			//   v68 = *(_OWORD *)&invViewMatrix.m00;
			//   *(_OWORD *)&viewConstants.projMatrix.m00 = v27;
			//   *(_OWORD *)&viewConstants.invViewMatrix.m00 = v68;
			//   v69 = *(_OWORD *)&invViewMatrix.m02;
			//   *(_OWORD *)&viewConstants.nonJitteredProjMatrix.m00 = v34;
			//   *(_OWORD *)&viewConstants.viewMatrix.m03 = v67;
			//   v70 = *(_OWORD *)&invViewMatrix.m01;
			//   *(__m128 *)&viewConstants.projMatrix.m01 = v28;
			//   *(_OWORD *)&viewConstants.invViewMatrix.m01 = v70;
			//   v71 = *(_OWORD *)&invViewMatrix.m03;
			//   *(_OWORD *)&viewConstants.nonJitteredProjMatrix.m01 = v35;
			//   *(_OWORD *)&viewConstants.invViewMatrix.m02 = v69;
			//   *(__m128 *)&viewConstants.projMatrix.m02 = v29;
			//   *(_OWORD *)&viewConstants.nonJitteredProjMatrix.m02 = v36;
			//   *(_OWORD *)&viewConstants.invViewMatrix.m03 = v71;
			//   *(__m128 *)&viewConstants.projMatrix.m03 = v30;
			//   *(_OWORD *)&viewConstants.nonJitteredProjMatrix.m03 = v37;
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_93;
			//   v73 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F41C8;
			//   if ( !qword_18D8F41C8 )
			//   {
			//     v73 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//     if ( !v73 )
			//     {
			//       v265 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//       sub_18000F750(v265, 0LL);
			//     }
			//     qword_18D8F41C8 = (__int64)v73;
			//   }
			//   if ( v73(camera) )
			//   {
			//     v266 = UnityEngine::Matrix4x4::get_inverse(&v318, &P0, 0LL);
			//     m00_low = *(_OWORD *)&v266.m00;
			//     v88 = *(__m128 *)&v266.m01;
			//     v86 = *(__m128 *)&v266.m02;
			//     v89 = *(__m128 *)&v266.m03;
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v74);
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v74);
			//       v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v14.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_93;
			//     if ( wrapperArray.max_length.size <= 709 )
			//       goto LABEL_30;
			//     if ( !v14._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v14, wrapperArray);
			//       v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v14 = (struct ILFixDynamicMethodWrapper_2__Class *)v14.static_fields.wrapperArray;
			//     if ( !v14 )
			//       goto LABEL_93;
			//     if ( LODWORD(v14._0.namespaze) <= 0x2C5 )
			//       goto LABEL_212;
			//     if ( v14[15]._0.element_class )
			//     {
			//       v267 = IFix::WrappersManagerImpl::GetPatch(709, 0LL);
			//       if ( !v267 )
			//         goto LABEL_93;
			//       v268 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_263(&v318, v267, &P0, 0LL);
			//       v30 = *(__m128 *)&P0.m03;
			//       v29 = *(__m128 *)&P0.m02;
			//       v28 = *(__m128 *)&P0.m01;
			//       m00_low = *(_OWORD *)&v268.m00;
			//       v88 = *(__m128 *)&v268.m01;
			//       v86 = *(__m128 *)&v268.m02;
			//       v89 = *(__m128 *)&v268.m03;
			//       v27 = *(_OWORD *)&P0.m00;
			//     }
			//     else
			//     {
			// LABEL_30:
			//       v313.m01 = 0.0;
			//       v313.m23 = -1.0;
			//       *(_QWORD *)&v313.m02 = 0LL;
			//       v313.m22 = 0.0;
			//       m00_low = LODWORD(v313.m00);
			//       *(float *)&m00_low = 1.0 / *(float *)&v27;
			//       v76 = _mm_shuffle_ps(v28, v28, 85).m128_f32[0];
			//       v77 = 1.0 / v76;
			//       v78 = _mm_shuffle_ps(v29, v29, 85).m128_f32[0] / v76;
			//       v79 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v313.m01, (__m128)*(unsigned __int64 *)&v313.m01, 225);
			//       v80 = _mm_shuffle_ps(v30, v30, 170).m128_f32[0];
			//       v79.m128_f32[0] = v77;
			//       v81 = 1.0 / v80;
			//       v82 = _mm_shuffle_ps(v29, v29, 170).m128_f32[0] / v80;
			//       v83 = *(__m128 *)&v313.m03;
			//       v83.m128_f32[0] = v29.m128_f32[0] / *(float *)&v27;
			//       v84 = _mm_shuffle_ps(*(__m128 *)&v313.m02, *(__m128 *)&v313.m02, 147);
			//       v36 = *(_OWORD *)&v319.m02;
			//       v85 = _mm_shuffle_ps(v83, v83, 225);
			//       v84.m128_f32[0] = v81;
			//       v85.m128_f32[0] = v78;
			//       v86 = _mm_shuffle_ps(v84, v84, 57);
			//       v87 = _mm_shuffle_ps(v85, v85, 135);
			//       v87.m128_f32[0] = v82;
			//       v88 = _mm_shuffle_ps(v79, v79, 225);
			//       v89 = _mm_shuffle_ps(v87, v87, 57);
			//       *(__m128 *)&v313.m02 = v86;
			//       *(_OWORD *)&v313.m00 = m00_low;
			//       *(__m128 *)&v313.m01 = v88;
			//       *(__m128 *)&v313.m03 = v89;
			//     }
			//   }
			//   v90 = *(_OWORD *)&viewMatrix.m01;
			//   v91 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   *(_OWORD *)&v317.m00 = v27;
			//   *(_OWORD *)&v315.m01 = v90;
			//   *(__m128 *)&v317.m01 = v28;
			//   *(__m128 *)&v317.m02 = v29;
			//   *(__m128 *)&v317.m03 = v30;
			//   v92 = *(_OWORD *)&viewMatrix.m03;
			//   *(_OWORD *)&viewConstants.invProjMatrix.m00 = m00_low;
			//   *(_OWORD *)&v315.m03 = v92;
			//   *(__m128 *)&viewConstants.invProjMatrix.m01 = v88;
			//   *(__m128 *)&viewConstants.invProjMatrix.m02 = v86;
			//   *(__m128 *)&viewConstants.invProjMatrix.m03 = v89;
			//   *(_OWORD *)&v315.m00 = *(_OWORD *)&viewMatrix.m00;
			//   *(_OWORD *)&v315.m02 = *(_OWORD *)&viewMatrix.m02;
			//   memset(&v309, 0, sizeof(v309));
			//   if ( !v91 )
			//   {
			//     v91 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                         "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_I"
			//                                                                         "njected(UnityEngine.Matrix4x4&,UnityEngine.Matri"
			//                                                                         "x4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v91 )
			//     {
			//       v269 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v269, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v91;
			//   }
			//   v91(&v317, &v315, &v309);
			//   v93 = *(_OWORD *)&v309.m01;
			//   *(_OWORD *)&viewConstants.viewProjMatrix.m00 = *(_OWORD *)&v309.m00;
			//   v94 = *(_OWORD *)&v309.m02;
			//   *(_OWORD *)&viewConstants.viewProjMatrix.m01 = v93;
			//   v95 = *(_OWORD *)&v309.m03;
			//   *(_OWORD *)&viewConstants.viewProjMatrix.m02 = v94;
			//   v96 = v320;
			//   *(_OWORD *)&viewConstants.viewProjMatrix.m03 = v95;
			//   *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m00 = v96;
			//   *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m01 = v321;
			//   *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m02 = v322;
			//   *(_OWORD *)&viewConstants.viewNoTransProjMatrix.m03 = v323;
			//   v97 = this.fields.camera;
			//   if ( !v97 )
			//     goto LABEL_93;
			//   v98 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F41C8;
			//   if ( !qword_18D8F41C8 )
			//   {
			//     v98 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//     if ( !v98 )
			//     {
			//       v270 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//       sub_18000F750(v270, 0LL);
			//     }
			//     qword_18D8F41C8 = (__int64)v98;
			//   }
			//   if ( v98(v97) )
			//   {
			//     v271 = UnityEngine::Matrix4x4::get_inverse(&v315, &viewConstants.viewProjMatrix, 0LL);
			//     v104 = *(_OWORD *)&v271.m00;
			//     v105 = *(_OWORD *)&v271.m01;
			//     v106 = *(_OWORD *)&v271.m02;
			//     v107 = *(_OWORD *)&v271.m03;
			//   }
			//   else
			//   {
			//     v99 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//     v100 = *(_OWORD *)&viewConstants.invViewMatrix.m01;
			//     *(_OWORD *)&v317.m00 = *(_OWORD *)&viewConstants.invViewMatrix.m00;
			//     *(_OWORD *)&v317.m01 = v100;
			//     v101 = *(_OWORD *)&viewConstants.invViewMatrix.m03;
			//     *(_OWORD *)&v317.m02 = *(_OWORD *)&viewConstants.invViewMatrix.m02;
			//     *(_OWORD *)&v317.m03 = v101;
			//     v102 = *(_OWORD *)&viewConstants.invProjMatrix.m01;
			//     *(_OWORD *)&v315.m00 = *(_OWORD *)&viewConstants.invProjMatrix.m00;
			//     *(_OWORD *)&v315.m01 = v102;
			//     v103 = *(_OWORD *)&viewConstants.invProjMatrix.m03;
			//     *(_OWORD *)&v315.m02 = *(_OWORD *)&viewConstants.invProjMatrix.m02;
			//     *(_OWORD *)&v315.m03 = v103;
			//     memset(&v309, 0, sizeof(v309));
			//     if ( !qword_18D8F4BC0 )
			//     {
			//       v99 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                           "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast"
			//                                                                           "_Injected(UnityEngine.Matrix4x4&,UnityEngine.M"
			//                                                                           "atrix4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v99 )
			//       {
			//         v272 = sub_1802DBBE8(
			//                  "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
			//                  "nityEngine.Matrix4x4&)");
			//         sub_18000F750(v272, 0LL);
			//       }
			//       qword_18D8F4BC0 = (__int64)v99;
			//     }
			//     v99(&v317, &v315, &v309);
			//     v104 = *(_OWORD *)&v309.m00;
			//     v105 = *(_OWORD *)&v309.m01;
			//     v106 = *(_OWORD *)&v309.m02;
			//     v107 = *(_OWORD *)&v309.m03;
			//   }
			//   v108 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   *(_OWORD *)&v324.m00 = v34;
			//   *(_OWORD *)&v324.m01 = v35;
			//   *(_OWORD *)&v324.m02 = v36;
			//   *(_OWORD *)&viewConstants.invViewProjMatrix.m00 = v104;
			//   v109 = *(_OWORD *)&v319.m03;
			//   *(_OWORD *)&viewConstants.invViewProjMatrix.m01 = v105;
			//   *(_OWORD *)&v324.m03 = v109;
			//   v110 = *(_OWORD *)&viewMatrix.m01;
			//   *(_OWORD *)&v318.m00 = *(_OWORD *)&viewMatrix.m00;
			//   *(_OWORD *)&v318.m01 = v110;
			//   v111 = *(_OWORD *)&viewMatrix.m03;
			//   *(_OWORD *)&v318.m02 = *(_OWORD *)&viewMatrix.m02;
			//   *(_OWORD *)&v318.m03 = v111;
			//   *(_OWORD *)&viewConstants.invViewProjMatrix.m02 = v106;
			//   memset(&v319, 0, sizeof(v319));
			//   *(_OWORD *)&viewConstants.invViewProjMatrix.m03 = v107;
			//   if ( !v108 )
			//   {
			//     v108 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
			//                                                                          "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
			//                                                                          "rix4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v108 )
			//     {
			//       v273 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v273, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v108;
			//   }
			//   v108(&v324, &v318, &v319);
			//   v112 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18D8F4BD0;
			//   v113 = *(_OWORD *)&v319.m01;
			//   *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m00 = *(_OWORD *)&v319.m00;
			//   v114 = *(_OWORD *)&v319.m02;
			//   *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m01 = v113;
			//   v115 = *(_OWORD *)&v319.m03;
			//   *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m02 = v114;
			//   v116 = *(_OWORD *)&v316.m00;
			//   *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m03 = v115;
			//   v117 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m01;
			//   *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m00 = v116;
			//   *(_OWORD *)&v315.m01 = v117;
			//   v118 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m03;
			//   *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m01 = *(_OWORD *)&v316.m01;
			//   *(_OWORD *)&v315.m03 = v118;
			//   *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m02 = *(_OWORD *)&v316.m02;
			//   *(_OWORD *)&viewConstants.nonJitteredViewNoTransProjMatrix.m03 = *(_OWORD *)&v316.m03;
			//   *(_OWORD *)&v315.m00 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m00;
			//   *(_OWORD *)&v315.m02 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m02;
			//   memset(&v309, 0, sizeof(v309));
			//   if ( !v112 )
			//   {
			//     v112 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x"
			//                                                             "4&,UnityEngine.Matrix4x4&)");
			//     if ( !v112 )
			//     {
			//       v274 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v274, 0LL);
			//     }
			//     qword_18D8F4BD0 = (__int64)v112;
			//   }
			//   v112(&v315, &v309);
			//   v119 = cameraPosition.z;
			//   v120 = *(_OWORD *)&v309.m01;
			//   *(_OWORD *)&viewConstants.invNonJitteredViewProjMatrix.m00 = *(_OWORD *)&v309.m00;
			//   v121 = *(_OWORD *)&v309.m02;
			//   *(_OWORD *)&viewConstants.invNonJitteredViewProjMatrix.m01 = v120;
			//   v122 = *(_OWORD *)&v309.m03;
			//   *(_OWORD *)&viewConstants.invNonJitteredViewProjMatrix.m02 = v121;
			//   *(_QWORD *)&viewConstants.worldSpaceCameraPos.x = *(_QWORD *)&cameraPosition.x;
			//   viewConstants.worldSpaceCameraPos.z = v119;
			//   *(_OWORD *)&viewConstants.invNonJitteredViewProjMatrix.m03 = v122;
			//   *(_QWORD *)&viewConstants.worldSpaceCameraPosViewOffset.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   viewConstants.worldSpaceCameraPosViewOffset.z = 0.0;
			//   HGCameraCullingMatrix = HG::Rendering::Runtime::HGCamera::GetHGCameraCullingMatrix(&v315, this, 0LL);
			//   v125 = *(_OWORD *)&HGCameraCullingMatrix.m01;
			//   v126 = *(_OWORD *)&HGCameraCullingMatrix.m02;
			//   v127 = *(_OWORD *)&HGCameraCullingMatrix.m03;
			//   *(_OWORD *)&viewConstants.cullingMatrix.m00 = *(_OWORD *)&HGCameraCullingMatrix.m00;
			//   *(_OWORD *)&viewConstants.cullingMatrix.m01 = v125;
			//   *(_OWORD *)&viewConstants.cullingMatrix.m02 = v126;
			//   *(_OWORD *)&viewConstants.cullingMatrix.m03 = v127;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v124);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v124);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v14.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_93;
			//   if ( wrapperArray.max_length.size <= 710 )
			//     goto LABEL_47;
			//   if ( !v14._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v14, wrapperArray);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v14.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_93;
			//   if ( wrapperArray.max_length.size <= 0x2C6u )
			//     goto LABEL_212;
			//   if ( wrapperArray[19].vector[26] )
			//   {
			//     v275 = IFix::WrappersManagerImpl::GetPatch(710, 0LL);
			//     if ( !v275 )
			//       goto LABEL_93;
			//     v128 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_264(v275, &P0, 0LL);
			//   }
			//   else
			//   {
			// LABEL_47:
			//     v128 = (float)-_mm_shuffle_ps(v28, v28, 85).m128_f32[0] / *(float *)&v27;
			//   }
			//   v129 = HIDWORD(*(_QWORD *)&this.fields._sceneRTSize_k__BackingField);
			//   m_X = (float)this.fields._sceneRTSize_k__BackingField.m_X;
			//   *(_QWORD *)&v312.z = 0LL;
			//   v312.x = m_X;
			//   v312.y = (float)(int)v129;
			//   v131 = HG::Rendering::Runtime::HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
			//            &v324,
			//            this,
			//            viewConstants,
			//            (Vector4 *)&v312,
			//            v128,
			//            0LL);
			//   v132 = *(_OWORD *)&v131.m01;
			//   v133 = *(_OWORD *)&v131.m02;
			//   v134 = *(_OWORD *)&v131.m03;
			//   *(_OWORD *)&viewConstants.pixelCoordToViewDirWS.m00 = *(_OWORD *)&v131.m00;
			//   *(_OWORD *)&viewConstants.pixelCoordToViewDirWS.m01 = v132;
			//   *(_OWORD *)&viewConstants.pixelCoordToViewDirWS.m02 = v133;
			//   *(_OWORD *)&viewConstants.pixelCoordToViewDirWS.m03 = v134;
			//   if ( updatePreviousFrameConstants )
			//   {
			//     v135 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18D8F4BD0;
			//     v136 = *(_OWORD *)&viewConstants.prevViewProjMatrix.m01;
			//     *(_OWORD *)&v315.m00 = *(_OWORD *)&viewConstants.prevViewProjMatrix.m00;
			//     *(_OWORD *)&v315.m01 = v136;
			//     v137 = *(_OWORD *)&viewConstants.prevViewProjMatrix.m03;
			//     *(_OWORD *)&v315.m02 = *(_OWORD *)&viewConstants.prevViewProjMatrix.m02;
			//     *(_OWORD *)&v315.m03 = v137;
			//     memset(&v309, 0, sizeof(v309));
			//     if ( !qword_18D8F4BD0 )
			//     {
			//       v135 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                               "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
			//                                                               "4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v135 )
			//       {
			//         v276 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v276, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v135;
			//     }
			//     v135(&v315, &v309);
			//     v138 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18D8F4BD0;
			//     v139 = *(_OWORD *)&v309.m01;
			//     *(_OWORD *)&viewConstants.prevInvViewProjMatrix.m00 = *(_OWORD *)&v309.m00;
			//     v140 = *(_OWORD *)&v309.m02;
			//     *(_OWORD *)&viewConstants.prevInvViewProjMatrix.m01 = v139;
			//     v141 = *(_OWORD *)&v309.m03;
			//     *(_OWORD *)&viewConstants.prevInvViewProjMatrix.m02 = v140;
			//     *(_OWORD *)&viewConstants.prevInvViewProjMatrix.m03 = v141;
			//     v142 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m01;
			//     *(_OWORD *)&v317.m00 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m00;
			//     *(_OWORD *)&v317.m01 = v142;
			//     v143 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m03;
			//     *(_OWORD *)&v317.m02 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m02;
			//     *(_OWORD *)&v317.m03 = v143;
			//     memset(&P0, 0, sizeof(P0));
			//     if ( !v138 )
			//     {
			//       v138 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                               "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
			//                                                               "4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v138 )
			//       {
			//         v277 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v277, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v138;
			//     }
			//     v138(&v317, &P0);
			//     v144 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18D8F4BD0;
			//     v145 = *(_OWORD *)&P0.m01;
			//     v146 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m00;
			//     v147 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m01;
			//     v148 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m02;
			//     v149 = *(_OWORD *)&viewConstants.prevNonJitteredViewProjMatrix.m03;
			//     *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m00 = *(_OWORD *)&P0.m00;
			//     v150 = *(_OWORD *)&P0.m02;
			//     *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m01 = v145;
			//     v151 = *(_OWORD *)&P0.m03;
			//     *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m02 = v150;
			//     *(_OWORD *)&viewConstants.prevNonJitteredInvViewProjMatrix.m03 = v151;
			//     v152 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m01;
			//     *(_OWORD *)&v315.m00 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m00;
			//     *(_OWORD *)&v315.m01 = v152;
			//     v153 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m03;
			//     *(_OWORD *)&v315.m02 = *(_OWORD *)&viewConstants.nonJitteredViewProjMatrix.m02;
			//     *(_OWORD *)&v315.m03 = v153;
			//     memset(&v309, 0, sizeof(v309));
			//     if ( !v144 )
			//     {
			//       v144 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                               "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix"
			//                                                               "4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v144 )
			//       {
			//         v278 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//         sub_18000F750(v278, 0LL);
			//       }
			//       qword_18D8F4BD0 = (__int64)v144;
			//     }
			//     v144(&v315, &v309);
			//     v154 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//     *(_OWORD *)&v318.m00 = v146;
			//     v317 = v309;
			//     *(_OWORD *)&v318.m01 = v147;
			//     *(_OWORD *)&v318.m02 = v148;
			//     *(_OWORD *)&v318.m03 = v149;
			//     memset(&P0, 0, sizeof(P0));
			//     if ( !qword_18D8F4BC0 )
			//     {
			//       v154 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                            "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fas"
			//                                                                            "t_Injected(UnityEngine.Matrix4x4&,UnityEngine"
			//                                                                            ".Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       if ( !v154 )
			//       {
			//         v279 = sub_1802DBBE8(
			//                  "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,U"
			//                  "nityEngine.Matrix4x4&)");
			//         sub_18000F750(v279, 0LL);
			//       }
			//       qword_18D8F4BC0 = (__int64)v154;
			//     }
			//     v154(&v318, &v317, &P0);
			//     v155 = *(_OWORD *)&P0.m01;
			//     *(_OWORD *)&viewConstants.reprojectionMatrix.m00 = *(_OWORD *)&P0.m00;
			//     v156 = *(_OWORD *)&P0.m02;
			//     *(_OWORD *)&viewConstants.reprojectionMatrix.m01 = v155;
			//     v157 = *(_OWORD *)&P0.m03;
			//     *(_OWORD *)&viewConstants.reprojectionMatrix.m02 = v156;
			//     *(_OWORD *)&viewConstants.reprojectionMatrix.m03 = v157;
			//   }
			//   v158 = this.fields.camera;
			//   if ( !v158 )
			//     goto LABEL_93;
			//   v159 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F41C8;
			//   if ( !qword_18D8F41C8 )
			//   {
			//     v159 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//     if ( !v159 )
			//     {
			//       v280 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//       sub_18000F750(v280, 0LL);
			//     }
			//     qword_18D8F41C8 = (__int64)v159;
			//   }
			//   if ( v159(v158) )
			//     goto LABEL_219;
			//   v160 = this.fields.camera;
			//   if ( !v160 )
			//     goto LABEL_93;
			//   v161 = (unsigned int (__fastcall *)(Camera *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v161 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v161 )
			//     {
			//       v281 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v281, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v161;
			//   }
			//   if ( v161(v160) == 16 )
			//   {
			// LABEL_219:
			//     v298 = *(_OWORD *)&viewConstants.viewProjMatrix.m01;
			//     v299 = *(_OWORD *)&viewConstants.cullingMatrix.m02;
			//     v300 = *(_OWORD *)&viewConstants.cullingMatrix.m03;
			//     *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m00 = *(_OWORD *)&viewConstants.viewProjMatrix.m00;
			//     v301 = *(_OWORD *)&viewConstants.viewProjMatrix.m02;
			//     *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m01 = v298;
			//     v302 = *(_OWORD *)&viewConstants.viewProjMatrix.m03;
			//     *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m02 = v301;
			//     v303 = *(_OWORD *)&viewConstants.invViewProjMatrix.m00;
			//     *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m03 = v302;
			//     v304 = *(_OWORD *)&viewConstants.invViewProjMatrix.m01;
			//     *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m00 = v303;
			//     v305 = *(_OWORD *)&viewConstants.invViewProjMatrix.m02;
			//     *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m01 = v304;
			//     v306 = *(_OWORD *)&viewConstants.invViewProjMatrix.m03;
			//     *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m02 = v305;
			//     v307 = *(_OWORD *)&viewConstants.cullingMatrix.m00;
			//     *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m03 = v306;
			//     v308 = *(_OWORD *)&viewConstants.cullingMatrix.m01;
			//     *(_OWORD *)&this.fields.waterCullingMatrix.m00 = v307;
			//     *(_OWORD *)&this.fields.waterCullingMatrix.m01 = v308;
			//     *(_OWORD *)&this.fields.waterCullingMatrix.m02 = v299;
			//     *(_OWORD *)&this.fields.waterCullingMatrix.m03 = v300;
			//     return;
			//   }
			//   v162 = this.fields.camera;
			//   if ( !v162 )
			//     goto LABEL_93;
			//   v163 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v163 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v163 )
			//     {
			//       v282 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v282, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v163;
			//   }
			//   v164 = v163(v162);
			//   if ( !v164 )
			//     goto LABEL_93;
			//   v165 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
			//   v312 = 0LL;
			//   if ( !qword_18D8F5300 )
			//   {
			//     v165 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//     if ( !v165 )
			//     {
			//       v283 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//       sub_18000F750(v283, 0LL);
			//     }
			//     qword_18D8F5300 = (__int64)v165;
			//   }
			//   v165(v164, &v312);
			//   v310.z = 1.0;
			//   *(_QWORD *)&v310.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   v166 = UnityEngine::Quaternion::op_Multiply(&v311, &v312, &v310, 0LL);
			//   v167 = this.fields.camera;
			//   v168 = *(_QWORD *)&v166.x;
			//   v169 = v166.z;
			//   if ( !v167 )
			//     goto LABEL_93;
			//   v170 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v170 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v170 )
			//     {
			//       v284 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v284, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v170;
			//   }
			//   v171 = v170(v167);
			//   if ( !v171 )
			//     goto LABEL_93;
			//   v172 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
			//   v312 = 0LL;
			//   if ( !qword_18D8F5300 )
			//   {
			//     v172 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//     if ( !v172 )
			//     {
			//       v285 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//       sub_18000F750(v285, 0LL);
			//     }
			//     qword_18D8F5300 = (__int64)v172;
			//   }
			//   v172(v171, &v312);
			//   v173 = this.fields.camera;
			//   if ( !v173 )
			//     goto LABEL_93;
			//   v174 = (void (__fastcall *)(Camera *))qword_18D8F4198;
			//   if ( !qword_18D8F4198 )
			//   {
			//     v174 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_fieldOfView()");
			//     if ( !v174 )
			//     {
			//       v286 = sub_1802DBBE8("UnityEngine.Camera::get_fieldOfView()");
			//       sub_18000F750(v286, 0LL);
			//     }
			//     qword_18D8F4198 = (__int64)v174;
			//   }
			//   v174(v173);
			//   v310.z = 0.0;
			//   *(_QWORD *)&v310.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   *(_QWORD *)&v311.x = v168;
			//   v311.z = v169;
			//   v176 = (float)(1.0 - fabs(UnityEngine::Vector3::Dot(&v311, &v310, v175))) * this.fields.waterCameraPositionOffset;
			//   *(_QWORD *)&v311.x = v168;
			//   v311.z = v169;
			//   v178 = UnityEngine::Vector3::op_Multiply(&v310, &v311, v176, v177);
			//   v179 = *(_QWORD *)&v178.x;
			//   *(float *)&v178 = v178.z;
			//   *(_QWORD *)&v310.x = *(_QWORD *)&cameraPosition.x;
			//   LODWORD(v311.z) = (_DWORD)v178;
			//   *(float *)&v178 = cameraPosition.z;
			//   v325 = v312;
			//   *(_QWORD *)&v311.x = v179;
			//   LODWORD(v310.z) = (_DWORD)v178;
			//   v181 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v312, &v310, &v311, v180);
			//   v182 = *(_QWORD *)&v181.x;
			//   *(float *)&v181 = v181.z;
			//   *(_QWORD *)&v311.x = v182;
			//   LODWORD(v311.z) = (_DWORD)v181;
			//   v183 = HG::Rendering::Runtime::GeometryUtils::CalculateWorldToCameraMatrixRHS(&v315, &v311, &v325, 0LL);
			//   v184 = this.fields.camera;
			//   v185 = *(_OWORD *)&v183.m00;
			//   v186 = *(_OWORD *)&v183.m01;
			//   v187 = *(_OWORD *)&v183.m02;
			//   v188 = *(_OWORD *)&v183.m03;
			//   if ( !v184 )
			//     goto LABEL_93;
			//   v189 = (void (__fastcall *)(Camera *))qword_18D8F41E0;
			//   if ( !qword_18D8F41E0 )
			//   {
			//     v189 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_aspect()");
			//     if ( !v189 )
			//     {
			//       v287 = sub_1802DBBE8("UnityEngine.Camera::get_aspect()");
			//       sub_18000F750(v287, 0LL);
			//     }
			//     qword_18D8F41E0 = (__int64)v189;
			//   }
			//   v189(v184);
			//   v190 = this.fields.camera;
			//   if ( !v190 )
			//     goto LABEL_93;
			//   v191 = (void (__fastcall *)(Camera *))qword_18D8F4178;
			//   if ( !qword_18D8F4178 )
			//   {
			//     v191 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_nearClipPlane()");
			//     if ( !v191 )
			//     {
			//       v288 = sub_1802DBBE8("UnityEngine.Camera::get_nearClipPlane()");
			//       sub_18000F750(v288, 0LL);
			//     }
			//     qword_18D8F4178 = (__int64)v191;
			//   }
			//   v191(v190);
			//   v192 = this.fields.camera;
			//   if ( !v192 )
			//     goto LABEL_93;
			//   v193 = (void (__fastcall *)(Camera *))qword_18D8F4188;
			//   if ( !qword_18D8F4188 )
			//   {
			//     v193 = (void (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_farClipPlane()");
			//     if ( !v193 )
			//     {
			//       v289 = sub_1802DBBE8("UnityEngine.Camera::get_farClipPlane()");
			//       sub_18000F750(v289, 0LL);
			//     }
			//     qword_18D8F4188 = (__int64)v193;
			//   }
			//   memset(&v316, 0, sizeof(v316));
			//   v193(v192);
			//   v194 = (void (__fastcall *)(Matrix4x4 *))qword_18D8F4BE8;
			//   if ( !qword_18D8F4BE8 )
			//   {
			//     v194 = (void (__fastcall *)(Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                "UnityEngine.Matrix4x4::Perspective_Injected(System.Single,System.Single,S"
			//                                                "ystem.Single,System.Single,UnityEngine.Matrix4x4&)");
			//     if ( !v194 )
			//     {
			//       v290 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::Perspective_Injected(System.Single,System.Single,System.Single,System.Single,Unity"
			//                "Engine.Matrix4x4&)");
			//       sub_18000F750(v290, 0LL);
			//     }
			//     qword_18D8F4BE8 = (__int64)v194;
			//   }
			//   v194(&v316);
			//   v196 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))qword_18D8F44A8;
			//   v197 = *(_OWORD *)&v316.m00;
			//   v315 = v316;
			//   memset(&v309, 0, sizeof(v309));
			//   if ( !qword_18D8F44A8 )
			//   {
			//     v196 = (void (__fastcall *)(Matrix4x4 *, __int64, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.GL::GetGPUProjectionMatrix_Injected(Uni"
			//                                                                      "tyEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
			//     if ( !v196 )
			//     {
			//       v291 = sub_1802DBBE8(
			//                "UnityEngine.GL::GetGPUProjectionMatrix_Injected(UnityEngine.Matrix4x4&,System.Boolean,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v291, 0LL);
			//     }
			//     qword_18D8F44A8 = (__int64)v196;
			//   }
			//   LOBYTE(v195) = 1;
			//   v196(&v315, v195, &v309);
			//   m00 = v309.m00;
			//   v199 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   *(_OWORD *)&v317.m00 = v185;
			//   v324 = v309;
			//   v318 = v309;
			//   *(_OWORD *)&v317.m01 = v186;
			//   *(_OWORD *)&v317.m02 = v187;
			//   *(_OWORD *)&v317.m03 = v188;
			//   v200 = *(__m128 *)&v309.m01;
			//   v201 = *(__m128 *)&v309.m02;
			//   v202 = *(__m128 *)&v309.m03;
			//   memset(&P0, 0, sizeof(P0));
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v199 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
			//                                                                          "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
			//                                                                          "rix4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v199 )
			//     {
			//       v292 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v292, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v199;
			//   }
			//   v199(&v318, &v317, &P0);
			//   v203 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18D8F4BD0;
			//   *(_OWORD *)&v315.m00 = v185;
			//   *(_OWORD *)&v315.m01 = v186;
			//   *(_OWORD *)&v315.m02 = v187;
			//   *(_OWORD *)&v315.m03 = v188;
			//   v204 = *(_OWORD *)&P0.m01;
			//   *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m00 = *(_OWORD *)&P0.m00;
			//   v205 = *(_OWORD *)&P0.m02;
			//   *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m01 = v204;
			//   v206 = *(_OWORD *)&P0.m03;
			//   *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m02 = v205;
			//   memset(&v309, 0, sizeof(v309));
			//   *(_OWORD *)&viewConstants.widerFoVViewProjMatrix.m03 = v206;
			//   if ( !v203 )
			//   {
			//     v203 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x"
			//                                                             "4&,UnityEngine.Matrix4x4&)");
			//     if ( !v203 )
			//     {
			//       v293 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v293, 0LL);
			//     }
			//     qword_18D8F4BD0 = (__int64)v203;
			//   }
			//   v203(&v315, &v309);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v207);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v207);
			//     v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v14.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			// LABEL_93:
			//     sub_180B536AC(v14, wrapperArray);
			//   if ( wrapperArray.max_length.size > 709 )
			//   {
			//     if ( !v14._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v14, wrapperArray);
			//       v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v14 = (struct ILFixDynamicMethodWrapper_2__Class *)v14.static_fields.wrapperArray;
			//     if ( !v14 )
			//       goto LABEL_93;
			//     if ( LODWORD(v14._0.namespaze) > 0x2C5 )
			//     {
			//       if ( !v14[15]._0.element_class )
			//         goto LABEL_88;
			//       v294 = IFix::WrappersManagerImpl::GetPatch(709, 0LL);
			//       if ( v294 )
			//       {
			//         v295 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_263(&v319, v294, &v324, 0LL);
			//         v219 = *(_OWORD *)&v295.m00;
			//         v220 = *(__m128 *)&v295.m01;
			//         v221 = *(__m128 *)&v295.m02;
			//         v218 = *(__m128 *)&v295.m03;
			//         goto LABEL_89;
			//       }
			//       goto LABEL_93;
			//     }
			// LABEL_212:
			//     sub_180070270(v14, wrapperArray);
			//   }
			// LABEL_88:
			//   v208 = _mm_shuffle_ps(v200, v200, 85).m128_f32[0];
			//   v209 = _mm_shuffle_ps(v202, v202, 170).m128_f32[0];
			//   v210 = _mm_shuffle_ps(v201, v201, 85).m128_f32[0] / v208;
			//   *(_QWORD *)&v313.m30 = 0LL;
			//   v313.m23 = -1.0;
			//   memset(&v313.m21, 0, 20);
			//   *(_QWORD *)&v313.m10 = 0LL;
			//   v211 = *(__m128 *)&v313.m03;
			//   v212 = 1.0 / v209;
			//   v211.m128_f32[0] = v201.m128_f32[0] / m00;
			//   v213 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v313.m01, (__m128)*(unsigned __int64 *)&v313.m01, 225);
			//   v214 = _mm_shuffle_ps(v211, v211, 225);
			//   v213.m128_f32[0] = 1.0 / v208;
			//   v215 = _mm_shuffle_ps(v201, v201, 170).m128_f32[0] / v209;
			//   v219 = LODWORD(v313.m00);
			//   v214.m128_f32[0] = v210;
			//   v216 = _mm_shuffle_ps(v214, v214, 135);
			//   v217 = _mm_shuffle_ps(*(__m128 *)&v313.m02, *(__m128 *)&v313.m02, 147);
			//   v216.m128_f32[0] = v215;
			//   v217.m128_f32[0] = v212;
			//   v218 = _mm_shuffle_ps(v216, v216, 57);
			//   *(float *)&v219 = 1.0 / m00;
			//   v220 = _mm_shuffle_ps(v213, v213, 225);
			//   v221 = _mm_shuffle_ps(v217, v217, 57);
			// LABEL_89:
			//   v222 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   *(_OWORD *)&v317.m00 = v219;
			//   v318 = v309;
			//   *(__m128 *)&v317.m01 = v220;
			//   *(__m128 *)&v317.m02 = v221;
			//   *(__m128 *)&v317.m03 = v218;
			//   memset(&P0, 0, sizeof(P0));
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v222 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
			//                                                                          "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
			//                                                                          "rix4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v222 )
			//     {
			//       v296 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v296, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v222;
			//   }
			//   v222(&v318, &v317, &P0);
			//   v223 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//   *(_OWORD *)&v324.m00 = v197;
			//   *(_OWORD *)&v315.m00 = v185;
			//   *(_OWORD *)&v315.m01 = v186;
			//   *(_OWORD *)&v315.m02 = v187;
			//   *(_OWORD *)&v315.m03 = v188;
			//   v224 = *(_OWORD *)&P0.m01;
			//   *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m00 = *(_OWORD *)&P0.m00;
			//   v225 = *(_OWORD *)&P0.m02;
			//   *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m01 = v224;
			//   v226 = *(_OWORD *)&P0.m03;
			//   *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m02 = v225;
			//   v227 = *(_OWORD *)&v316.m01;
			//   *(_OWORD *)&viewConstants.widerFoVInvViewProjMatrix.m03 = v226;
			//   *(_OWORD *)&v324.m01 = v227;
			//   *(_OWORD *)&v324.m02 = *(_OWORD *)&v316.m02;
			//   *(_OWORD *)&v324.m03 = *(_OWORD *)&v316.m03;
			//   memset(&v309, 0, sizeof(v309));
			//   if ( !v223 )
			//   {
			//     v223 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_"
			//                                                                          "Injected(UnityEngine.Matrix4x4&,UnityEngine.Mat"
			//                                                                          "rix4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v223 )
			//     {
			//       v297 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v297, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v223;
			//   }
			//   v223(&v324, &v315, &v309);
			//   v228 = *(_OWORD *)&v309.m01;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m00 = *(_OWORD *)&v309.m00;
			//   v229 = *(_OWORD *)&v309.m02;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m01 = v228;
			//   v230 = *(_OWORD *)&v309.m03;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m02 = v229;
			//   *(_OWORD *)&this.fields.waterCullingMatrix.m03 = v230;
			// }
			// 
		}

		private void UpdateFrustum(in HGCamera.ViewConstants viewConstants)
		{
			// // Void UpdateFrustum(HGCamera+ViewConstants ByRef)
			// void HG::Rendering::Runtime::HGCamera::UpdateFrustum(
			//         HGCamera *this,
			//         HGCamera_ViewConstants *viewConstants,
			//         MethodInfo *method)
			// {
			//   void *planes; // rcx
			//   Vector4__Array *frustumPlaneEquations; // rdx
			//   Camera *camera; // rbx
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm1
			//   __m128 v10; // xmm6
			//   __m128 v11; // xmm8
			//   __m128 v12; // xmm7
			//   __m128 v13; // xmm12
			//   __int128 v14; // xmm13
			//   __int128 v15; // xmm14
			//   __int128 v16; // xmm15
			//   double (__fastcall *v17)(Camera *, Vector4__Array *, MethodInfo *); // rax
			//   double v18; // xmm0_8
			//   Camera *v19; // rbx
			//   float v20; // xmm10_4
			//   double (__fastcall *v21)(Camera *); // rax
			//   double v22; // xmm0_8
			//   float v23; // xmm9_4
			//   bool v24; // al
			//   float v25; // xmm2_4
			//   __m128 v26; // xmm0
			//   __m128 v27; // xmm0
			//   __m128 v28; // xmm0
			//   int v29; // r14d
			//   int v30; // eax
			//   __m128 v31; // xmm0
			//   __m128 v32; // xmm0
			//   __m128 v33; // xmm0
			//   __m128 v34; // xmm0
			//   Vector4 v35; // xmm0
			//   Camera *v36; // rbx
			//   unsigned __int8 (__fastcall *v37)(Camera *); // rax
			//   float v38; // xmm7_4
			//   Camera *v39; // rbx
			//   double (__fastcall *v40)(Camera *); // rax
			//   double v41; // xmm0_8
			//   Camera *v42; // rbx
			//   __int64 (__fastcall *v43)(Camera *); // rax
			//   char v44; // al
			//   int v45; // ebx
			//   __m128 v46; // xmm1
			//   __m128 v47; // xmm1
			//   __m128 v48; // xmm1
			//   Vector4 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   MethodInfo *v54; // r8
			//   __int64 v55; // rdx
			//   __int64 v56; // r8
			//   Vector4 v57; // xmm6
			//   struct Math__Class *v58; // rcx
			//   __m128 v59; // xmm7
			//   float v60; // xmm8_4
			//   __m128d v61; // xmm2
			//   double v62; // xmm0_8
			//   float v63; // xmm0_4
			//   float v64; // xmm8_4
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm0
			//   __int128 v67; // xmm1
			//   Vector4 v68; // xmm3
			//   float v69; // r8d
			//   float v70; // xmm2_4
			//   __int64 v71; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v73; // rax
			//   __int64 v74; // rax
			//   __m128 v75; // xmm4
			//   __m128 v76; // xmm4
			//   __m128 v77; // xmm4
			//   __m128 v78; // xmm4
			//   __int64 v79; // rax
			//   float orthographicSize; // xmm0_4
			//   __int64 v81; // rax
			//   __int64 v82; // rax
			//   __m128 v83; // [rsp+40h] [rbp-C0h] BYREF
			//   Vector4 v84; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector3 v85; // [rsp+60h] [rbp-A0h] BYREF
			//   Vector3 v86; // [rsp+70h] [rbp-90h] BYREF
			//   Matrix4x4 v87; // [rsp+80h] [rbp-80h] BYREF
			//   __int128 v88; // [rsp+C0h] [rbp-40h]
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   planes = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, viewConstants);
			//     planes = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   frustumPlaneEquations = (Vector4__Array *)**((_QWORD **)planes + 23);
			//   if ( !frustumPlaneEquations )
			//     goto LABEL_42;
			//   if ( frustumPlaneEquations.max_length.size <= 714 )
			//     goto LABEL_7;
			//   if ( !*((_DWORD *)planes + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(planes, frustumPlaneEquations);
			//     planes = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   frustumPlaneEquations = (Vector4__Array *)**((_QWORD **)planes + 23);
			//   if ( !frustumPlaneEquations )
			//     goto LABEL_42;
			//   if ( frustumPlaneEquations.max_length.size <= 0x2CAu )
			// LABEL_44:
			//     sub_180070270(planes, frustumPlaneEquations);
			//   if ( !*(_QWORD *)&frustumPlaneEquations[10].vector[17].x )
			//   {
			// LABEL_7:
			//     camera = this.fields.camera;
			//     v8 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m01;
			//     *(_OWORD *)&v87.m00 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m00;
			//     *(_OWORD *)&v87.m01 = v8;
			//     v9 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m03;
			//     *(_OWORD *)&v87.m02 = *(_OWORD *)&this.fields.mainViewConstants.projMatrix.m02;
			//     *(_OWORD *)&v87.m03 = v9;
			//     v10 = *(__m128 *)&this.fields.mainViewConstants.invProjMatrix.m00;
			//     v11 = *(__m128 *)&this.fields.mainViewConstants.invProjMatrix.m01;
			//     v12 = *(__m128 *)&this.fields.mainViewConstants.invProjMatrix.m02;
			//     v13 = *(__m128 *)&this.fields.mainViewConstants.invProjMatrix.m03;
			//     v14 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m00;
			//     v15 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m01;
			//     v16 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m02;
			//     v88 = *(_OWORD *)&this.fields.mainViewConstants.viewProjMatrix.m03;
			//     if ( camera )
			//     {
			//       v17 = (double (__fastcall *)(Camera *, Vector4__Array *, MethodInfo *))qword_18D8F4178;
			//       if ( !qword_18D8F4178 )
			//       {
			//         v17 = (double (__fastcall *)(Camera *, Vector4__Array *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                  "UnityEngine.Camera::get_nearClipPlane()");
			//         if ( !v17 )
			//         {
			//           v73 = sub_1802DBBE8("UnityEngine.Camera::get_nearClipPlane()");
			//           sub_18000F750(v73, 0LL);
			//         }
			//         qword_18D8F4178 = (__int64)v17;
			//       }
			//       v18 = v17(camera, frustumPlaneEquations, method);
			//       v19 = this.fields.camera;
			//       v20 = *(float *)&v18;
			//       if ( v19 )
			//       {
			//         v21 = (double (__fastcall *)(Camera *))qword_18D8F4188;
			//         if ( !qword_18D8F4188 )
			//         {
			//           v21 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_farClipPlane()");
			//           if ( !v21 )
			//           {
			//             v74 = sub_1802DBBE8("UnityEngine.Camera::get_farClipPlane()");
			//             sub_18000F750(v74, 0LL);
			//           }
			//           qword_18D8F4188 = (__int64)v21;
			//         }
			//         v22 = v21(v19);
			//         v23 = *(float *)&v22;
			//         *(float *)&v22 = UnityEngine::Matrix4x4::get_Item(&v87, 14, 0LL);
			//         v24 = (float)((float)((float)((float)((float)(_mm_shuffle_ps(v10, v10, 85).m128_f32[0] * 0.0)
			//                                             + _mm_shuffle_ps(v11, v11, 85).m128_f32[0])
			//                                     + (float)(_mm_shuffle_ps(v12, v12, 85).m128_f32[0] * 0.0))
			//                             + _mm_shuffle_ps(v13, v13, 85).m128_f32[0])
			//                     * (float)(1.0
			//                             / (float)((float)((float)((float)(_mm_shuffle_ps(v10, v10, 255).m128_f32[0] * 0.0)
			//                                                     + _mm_shuffle_ps(v11, v11, 255).m128_f32[0])
			//                                             + (float)(_mm_shuffle_ps(v12, v12, 255).m128_f32[0] * 0.0))
			//                                     + _mm_shuffle_ps(v13, v13, 255).m128_f32[0]))) < 0.0;
			//         v25 = 1.0 / v20;
			//         if ( (float)((float)(*(float *)&v22 / (float)(v23 * v20)) * (float)(v23 - v20)) <= 0.0 )
			//         {
			//           v75 = (__m128)0x3F800000u;
			//           v75.m128_f32[0] = 1.0 - (float)(v23 / v20);
			//           v76 = _mm_shuffle_ps(v75, v75, 225);
			//           v76.m128_f32[0] = v23 / v20;
			//           v77 = _mm_shuffle_ps(v76, v76, 198);
			//           v77.m128_f32[0] = (float)(1.0 / v23) - (float)(1.0 / v20);
			//           v78 = _mm_shuffle_ps(v77, v77, 39);
			//           v78.m128_f32[0] = v25;
			//           v83 = _mm_shuffle_ps(v78, v78, 57);
			//           this.fields.zBufferParams = (Vector4)v83;
			//         }
			//         else
			//         {
			//           v84.y = 1.0;
			//           v26 = (__m128)v84;
			//           v26.m128_f32[0] = (float)(v23 / v20) - 1.0;
			//           v27 = _mm_shuffle_ps(v26, v26, 210);
			//           v27.m128_f32[0] = v25 + (float)(-1.0 / v23);
			//           v28 = _mm_shuffle_ps(v27, v27, 39);
			//           v28.m128_f32[0] = 1.0 / v23;
			//           v84 = (Vector4)_mm_shuffle_ps(v28, v28, 57);
			//           this.fields.zBufferParams = v84;
			//         }
			//         v29 = 1;
			//         v30 = v24 ? -1 : 1;
			//         v31 = 0LL;
			//         v31.m128_f32[0] = (float)v30;
			//         v32 = _mm_shuffle_ps(v31, v31, 225);
			//         v32.m128_f32[0] = v20;
			//         v33 = _mm_shuffle_ps(v32, v32, 198);
			//         v33.m128_f32[0] = v23;
			//         v34 = _mm_shuffle_ps(v33, v33, 39);
			//         v34.m128_f32[0] = 1.0 / v23;
			//         v35 = (Vector4)_mm_shuffle_ps(v34, v34, 57);
			//         this.fields.projectionParams = v35;
			//         v36 = this.fields.camera;
			//         v83 = (__m128)v35;
			//         if ( v36 )
			//         {
			//           v37 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F41C8;
			//           if ( !qword_18D8F41C8 )
			//           {
			//             v37 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//             if ( !v37 )
			//             {
			//               v79 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//               sub_18000F750(v79, 0LL);
			//             }
			//             qword_18D8F41C8 = (__int64)v37;
			//           }
			//           if ( v37(v36) )
			//           {
			//             planes = this.fields.camera;
			//             if ( !planes )
			//               goto LABEL_42;
			//             orthographicSize = UnityEngine::Camera::get_orthographicSize((Camera *)planes, 0LL);
			//             v38 = orthographicSize + orthographicSize;
			//           }
			//           else
			//           {
			//             v38 = 0.0;
			//           }
			//           v39 = this.fields.camera;
			//           if ( v39 )
			//           {
			//             v40 = (double (__fastcall *)(Camera *))qword_18D8F41E0;
			//             if ( !qword_18D8F41E0 )
			//             {
			//               v40 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_aspect()");
			//               if ( !v40 )
			//               {
			//                 v81 = sub_1802DBBE8("UnityEngine.Camera::get_aspect()");
			//                 sub_18000F750(v81, 0LL);
			//               }
			//               qword_18D8F41E0 = (__int64)v40;
			//             }
			//             v41 = v40(v39);
			//             v42 = this.fields.camera;
			//             if ( v42 )
			//             {
			//               v43 = (__int64 (__fastcall *)(Camera *))qword_18D8F41C8;
			//               if ( !qword_18D8F41C8 )
			//               {
			//                 v43 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//                 if ( !v43 )
			//                 {
			//                   v82 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//                   sub_18000F750(v82, 0LL);
			//                 }
			//                 qword_18D8F41C8 = (__int64)v43;
			//               }
			//               v44 = v43(v42);
			//               v45 = 0;
			//               if ( !v44 )
			//                 v29 = 0;
			//               v84.z = 0.0;
			//               v46 = (__m128)v84;
			//               v46.m128_f32[0] = *(float *)&v41 * v38;
			//               v47 = _mm_shuffle_ps(v46, v46, 225);
			//               v47.m128_f32[0] = v38;
			//               v48 = _mm_shuffle_ps(v47, v47, 135);
			//               v48.m128_f32[0] = (float)v29;
			//               v49 = (Vector4)_mm_shuffle_ps(v48, v48, 57);
			//               this.fields.unity_OrthoParams = v49;
			//               v50 = *(_OWORD *)&viewConstants.invViewMatrix.m00;
			//               v84 = v49;
			//               v51 = *(_OWORD *)&viewConstants.invViewMatrix.m01;
			//               *(_OWORD *)&v87.m00 = v50;
			//               v52 = *(_OWORD *)&viewConstants.invViewMatrix.m02;
			//               *(_OWORD *)&v87.m01 = v51;
			//               v53 = *(_OWORD *)&viewConstants.invViewMatrix.m03;
			//               *(_OWORD *)&v87.m02 = v52;
			//               *(_OWORD *)&v87.m03 = v53;
			//               v83 = *(__m128 *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v83, &v87, 2, 0LL);
			//               v57 = *UnityEngine::Vector4::op_UnaryNegation(&v84, (Vector4 *)&v83, v54);
			//               if ( !byte_18D8E3A70 )
			//               {
			//                 sub_18003C530(&TypeInfo::System::Math);
			//                 byte_18D8E3A70 = 1;
			//               }
			//               v58 = TypeInfo::System::Math;
			//               if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::System::Math, v55);
			//               v59 = _mm_shuffle_ps((__m128)v57, (__m128)v57, 85);
			//               v61 = 0LL;
			//               v60 = _mm_shuffle_ps((__m128)v57, (__m128)v57, 170).m128_f32[0];
			//               v61.m128d_f64[0] = (float)((float)((float)(v59.m128_f32[0] * v59.m128_f32[0]) + (float)(v57.x * v57.x))
			//                                        + (float)(v60 * v60));
			//               if ( v61.m128d_f64[0] < 0.0 )
			//                 v62 = sub_1801C22C0(v58, v55, v56);
			//               else
			//                 *(_QWORD *)&v62 = *(_OWORD *)&_mm_sqrt_pd(v61);
			//               v63 = v62;
			//               if ( v63 <= 0.0000099999997 )
			//               {
			//                 v57 = 0LL;
			//                 v59 = 0LL;
			//                 v64 = 0.0;
			//               }
			//               else
			//               {
			//                 v57.x = v57.x / v63;
			//                 v59.m128_f32[0] = v59.m128_f32[0] / v63;
			//                 v64 = v60 / v63;
			//               }
			//               v65 = *(_OWORD *)&viewConstants.invViewMatrix.m01;
			//               *(_OWORD *)&v87.m00 = *(_OWORD *)&viewConstants.invViewMatrix.m00;
			//               v66 = *(_OWORD *)&viewConstants.invViewMatrix.m02;
			//               *(_OWORD *)&v87.m01 = v65;
			//               v67 = *(_OWORD *)&viewConstants.invViewMatrix.m03;
			//               *(_OWORD *)&v87.m02 = v66;
			//               *(_OWORD *)&v87.m03 = v67;
			//               v68 = *UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v83, &v87, 3, 0LL);
			//               *(_QWORD *)&v86.x = _mm_unpacklo_ps((__m128)v68, _mm_shuffle_ps((__m128)v68, (__m128)v68, 85)).m128_u64[0];
			//               *(_OWORD *)&v87.m03 = v88;
			//               v85.z = v64;
			//               LODWORD(v86.z) = _mm_shuffle_ps((__m128)v68, (__m128)v68, 170).m128_u32[0];
			//               *(_QWORD *)&v85.x = _mm_unpacklo_ps((__m128)v57, v59).m128_u64[0];
			//               *(_OWORD *)&v87.m00 = v14;
			//               *(_OWORD *)&v87.m01 = v15;
			//               *(_OWORD *)&v87.m02 = v16;
			//               HG::Rendering::Runtime::Frustum::Create(&this.fields.frustum, &v87, &v86, &v85, v20, v23, 0LL);
			//               while ( 1 )
			//               {
			//                 planes = this.fields.frustum.planes;
			//                 frustumPlaneEquations = this.fields.frustumPlaneEquations;
			//                 if ( !planes )
			//                   break;
			//                 if ( (unsigned int)v45 >= *((_DWORD *)planes + 6) )
			//                   goto LABEL_44;
			//                 *(_QWORD *)&v86.x = *((_QWORD *)planes + 2 * v45 + 4);
			//                 if ( (unsigned int)v45 >= *((_DWORD *)planes + 6) )
			//                   goto LABEL_44;
			//                 *(_QWORD *)&v85.x = *((_QWORD *)planes + 2 * v45 + 4);
			//                 if ( (unsigned int)v45 >= *((_DWORD *)planes + 6) )
			//                   goto LABEL_44;
			//                 v69 = *((float *)planes + 4 * v45 + 10);
			//                 v70 = *((float *)planes + 4 * v45 + 11);
			//                 if ( !frustumPlaneEquations )
			//                   break;
			//                 v83.m128_i32[0] = LODWORD(v86.x);
			//                 v83.m128_i32[1] = LODWORD(v85.y);
			//                 v83.m128_f32[3] = v70;
			//                 v83.m128_f32[2] = v69;
			//                 if ( (unsigned int)v45 >= frustumPlaneEquations.max_length.size )
			//                   goto LABEL_44;
			//                 v71 = v45++;
			//                 frustumPlaneEquations.vector[v71] = (Vector4)v83;
			//                 if ( v45 >= 6 )
			//                   return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_42:
			//     sub_180B536AC(planes, frustumPlaneEquations);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(714, 0LL);
			//   if ( !Patch )
			//     goto LABEL_42;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_269(Patch, (Object *)this, viewConstants, 0LL);
			// }
			// 
		}

		internal static int GetSceneViewLayerMaskFallback()
		{
			// // Int32 GetSceneViewLayerMaskFallback()
			// int32_t HG::Rendering::Runtime::HGCamera::GetSceneViewLayerMaskFallback(MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(672, 0LL) )
			//     return -1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v4, v3);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			// }
			// 
			return 0;
		}

		private void UpdateVolumeAndPhysicalParameters()
		{
			// // Void UpdateVolumeAndPhysicalParameters()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCamera::UpdateVolumeAndPhysicalParameters(HGCamera *this, MethodInfo *method)
			// {
			//   FileDescriptor *v2; // r8
			//   MessageDescriptor *v3; // r9
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rdi
			//   struct Object_1__Class *v15; // rcx
			//   HGAdditionalCameraData *v16; // rdi
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   void *v19; // rdi
			//   __int64 v20; // rdx
			//   Object_1 *main; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rcx
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   Object *v27; // rdi
			//   __int64 v28; // rcx
			//   __int128 v29; // xmm1
			//   float v30; // eax
			//   HGPhysicalCamera *Defaults; // rax
			//   __int128 v32; // xmm1
			//   float m_Anamorphism; // ecx
			//   Transform *volumeAnchor; // rdi
			//   struct Object_1__Class *v35; // rcx
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v37)(Camera *); // rax
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   __int64 v41; // rdx
			//   VolumeManager *instance; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   __int64 v45; // rdx
			//   HGCamera *LightWeightCamera; // rbx
			//   VolumeManager *v47; // rax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __int64 v50; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-68h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-68h]
			//   String *v53; // [rsp+28h] [rbp-60h]
			//   String *v54; // [rsp+28h] [rbp-60h]
			//   MethodInfo *v55; // [rsp+30h] [rbp-58h] BYREF
			//   Il2CppException *methodPointer; // [rsp+38h] [rbp-50h]
			//   char *v57; // [rsp+40h] [rbp-48h]
			//   HGPhysicalCamera v58; // [rsp+48h] [rbp-40h] BYREF
			//   char v59; // [rsp+A0h] [rbp+18h] BYREF
			//   Object *component; // [rsp+A8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDA1E )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::VolumeManager);
			//     byte_18D8EDA1E = 1;
			//   }
			//   component = 0LL;
			//   v59 = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v5, method);
			//   if ( wrapperArray.max_length.size > 670 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, method);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = v5.static_fields.wrapperArray;
			//     if ( !v7 )
			//       sub_180B536AC(v5, method);
			//     if ( v7.max_length.size <= 0x29Eu )
			//       sub_180070270(v5, method);
			//     if ( v7[18].vector[22] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(670, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v10, v9);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//   }
			//   this.fields.volumeAnchor = 0LL;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.volumeAnchor,
			//     (OneofDescriptorProto *)method,
			//     v2,
			//     v3,
			//     (String__Array *)methoda,
			//     v53,
			//     v55);
			//   this.fields.volumeLayerMask = -1;
			//   m_AdditionalCameraData = this.fields.m_AdditionalCameraData;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   v15 = TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_32;
			//   v15 = TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( m_AdditionalCameraData.fields._._._._.m_CachedPtr )
			//   {
			//     v16 = this.fields.m_AdditionalCameraData;
			//     if ( !v16 )
			//       sub_180B536AC(v15, v11);
			//     this.fields.volumeLayerMask = v16.fields.volumeLayerMask.m_Mask;
			//     this.fields.volumeAnchor = v16.fields.volumeAnchorOverride;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.volumeAnchor, v11, v12, v13, (String__Array *)methodb, v54, v55);
			//     v19 = this.fields.m_AdditionalCameraData;
			//     if ( !v19 )
			//       sub_180B536AC(v18, v17);
			//   }
			//   else
			//   {
			// LABEL_32:
			//     if ( !this.fields.camera )
			//       sub_180B536AC(v15, v11);
			//     if ( UnityEngine::Camera::get_cameraType(this.fields.camera, 0LL) != CameraType__Enum_SceneView )
			//       goto LABEL_45;
			//     main = (Object_1 *)UnityEngine::Camera::get_main(0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v20);
			//     if ( !UnityEngine::Object::op_Inequality(main, 0LL, 0LL) )
			//       goto LABEL_95;
			//     if ( !main )
			//       sub_180B536AC(v23, v22);
			//     if ( !UnityEngine::Component::TryGetComponent<System::Object>(
			//             (Component *)main,
			//             &component,
			//             MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>) )
			//     {
			// LABEL_95:
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v22);
			//       this.fields.volumeLayerMask = HG::Rendering::Runtime::HGCamera::GetSceneViewLayerMaskFallback(0LL);
			//       Defaults = HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults(&v58, 0LL);
			//       v32 = *(_OWORD *)&Defaults.m_BladeCount;
			//       m_Anamorphism = Defaults.m_Anamorphism;
			//       *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&Defaults.m_Iso;
			//       *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_BladeCount = v32;
			//       this.fields._physicalParameters_k__BackingField.m_Anamorphism = m_Anamorphism;
			//       goto LABEL_45;
			//     }
			//     v27 = component;
			//     if ( !component )
			//       sub_180B536AC(v24, v22);
			//     this.fields.volumeLayerMask = (int32_t)component[3].monitor;
			//     this.fields.volumeAnchor = (Transform *)v27[4].klass;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.volumeAnchor, v22, v25, v26, (String__Array *)methodb, v54, v55);
			//     v19 = component;
			//     if ( !component )
			//       sub_180B536AC(v28, v17);
			//   }
			//   v29 = *((_OWORD *)v19 + 6);
			//   v30 = *((float *)v19 + 28);
			//   *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_Iso = *((_OWORD *)v19 + 5);
			//   *(_OWORD *)&this.fields._physicalParameters_k__BackingField.m_BladeCount = v29;
			//   this.fields._physicalParameters_k__BackingField.m_Anamorphism = v30;
			// LABEL_45:
			//   volumeAnchor = this.fields.volumeAnchor;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   v35 = TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !volumeAnchor )
			//     goto LABEL_57;
			//   v35 = TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( !volumeAnchor.fields._._.m_CachedPtr )
			//   {
			// LABEL_57:
			//     camera = this.fields.camera;
			//     if ( !camera )
			//       sub_180B536AC(v35, v17);
			//     v37 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v37 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//       if ( !v37 )
			//       {
			//         v50 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v50, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v37;
			//     }
			//     this.fields.volumeAnchor = (Transform *)v37(camera);
			//     sub_1800054D0((OneofDescriptor *)&this.fields.volumeAnchor, v38, v39, v40, (String__Array *)methodb, v54, v55);
			//   }
			//   UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//     (Int32Enum__Enum)0x8Fu,
			//     MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//   methodPointer = 0LL;
			//   v57 = &v59;
			//   try
			//   {
			//     if ( !TypeInfo::UnityEngine::Rendering::VolumeManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::VolumeManager, v41);
			//     instance = UnityEngine::Rendering::VolumeManager::get_instance(0LL);
			//     if ( !instance )
			//       sub_1802DC2C8(v44, v43);
			//     UnityEngine::Rendering::VolumeManager::Update(
			//       instance,
			//       this.fields._volumeStack_k__BackingField,
			//       this.fields.volumeAnchor,
			//       (LayerMask)this.fields.volumeLayerMask,
			//       0LL);
			//     LightWeightCamera = HG::Rendering::Runtime::HGCamera::GetLightWeightCamera(this, 0LL);
			//     if ( LightWeightCamera )
			//     {
			//       if ( !TypeInfo::UnityEngine::Rendering::VolumeManager._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::VolumeManager, v45);
			//       v47 = UnityEngine::Rendering::VolumeManager::get_instance(0LL);
			//       if ( !v47 )
			//         sub_1802DC2C8(v49, v48);
			//       UnityEngine::Rendering::VolumeManager::Update(
			//         v47,
			//         LightWeightCamera.fields._volumeStack_k__BackingField,
			//         LightWeightCamera.fields.volumeAnchor,
			//         (LayerMask)LightWeightCamera.fields.volumeLayerMask,
			//         0LL);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v55 )
			//   {
			//     methodPointer = (Il2CppException *)v55.methodPointer;
			//     if ( methodPointer )
			//       sub_18000F780(methodPointer);
			//   }
			// }
			// 
		}

		internal Matrix4x4 GetJitteredProjectionMatrix(Matrix4x4 origProj, HGRenderPipeline hgrp)
		{
			// // Matrix4x4 GetJitteredProjectionMatrix(Matrix4x4, HGRenderPipeline)
			// Matrix4x4 *HG::Rendering::Runtime::HGCamera::GetJitteredProjectionMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGCamera *this,
			//         Matrix4x4 *origProj,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   __m128 v5; // xmm0
			//   Camera *planes; // rcx
			//   __int64 v11; // rdx
			//   Vector3Int *v12; // r8
			//   ITilemap *v13; // r9
			//   HGSettingParameters *settingParameters_k__BackingField; // rbx
			//   float v15; // xmm9_4
			//   float v16; // xmm7_4
			//   int v17; // eax
			//   __m128 v18; // xmm6
			//   float v19; // xmm1_4
			//   int v20; // edx
			//   float v21; // xmm0_4
			//   float v22; // xmm1_4
			//   int v23; // r8d
			//   float v24; // xmm0_4
			//   float v25; // xmm0_4
			//   float v26; // xmm7_4
			//   Camera *camera; // rbx
			//   __m128 v28; // xmm0
			//   __m128 v29; // xmm0
			//   __m128 v30; // xmm0
			//   unsigned __int8 (__fastcall *v31)(Camera *); // rax
			//   void (__fastcall *v32)(Matrix4x4 *, __m128 *); // rax
			//   __int64 v33; // rdx
			//   bool v34; // zf
			//   __int64 v35; // r8
			//   void (__fastcall *v36)(Matrix4x4 *, __int64, __int64); // rax
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm2
			//   __int128 v40; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   Matrix4x4 *v46; // rax
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   int v50; // ebx
			//   __int64 v51; // rax
			//   __int64 v52; // rax
			//   __int64 v53; // rax
			//   float orthographicSize; // xmm0_4
			//   float v55; // xmm11_4
			//   float aspect; // xmm0_4
			//   float v57; // xmm10_4
			//   float v58; // xmm0_4
			//   float v59; // xmm1_4
			//   float v60; // xmm7_4
			//   float v61; // xmm0_4
			//   float v62; // xmm8_4
			//   float farClipPlane; // xmm0_4
			//   Matrix4x4 *v64; // rax
			//   Vector4 v65; // xmm1
			//   __int128 v66; // xmm0
			//   MethodInfo *v67; // [rsp+20h] [rbp-E0h]
			//   __m128 taaJitter; // [rsp+40h] [rbp-C0h] BYREF
			//   __int64 v69; // [rsp+50h] [rbp-B0h]
			//   Matrix4x4 v70; // [rsp+60h] [rbp-A0h] BYREF
			//   __m128 v71; // [rsp+A0h] [rbp-60h] BYREF
			//   __int64 v72; // [rsp+B0h] [rbp-50h]
			//   Matrix4x4 v73; // [rsp+B8h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDA1F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D8EDA1F = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     *(double *)v5.m128_u64 = il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = *(_QWORD *)planes[7].fields._._._.m_CachedPtr;
			//   if ( !v11 )
			//     goto LABEL_30;
			//   if ( *(int *)(v11 + 24) > 707 )
			//   {
			//     if ( !LODWORD(planes[9].monitor) )
			//     {
			//       *(double *)v5.m128_u64 = il2cpp_runtime_class_init_0(planes, v11);
			//       planes = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     planes = *(Camera **)planes[7].fields._._._.m_CachedPtr;
			//     if ( !planes )
			//       goto LABEL_30;
			//     if ( LODWORD(planes[1].klass) <= 0x2C3 )
			//       sub_180070270(planes, v11);
			//     if ( planes[237].klass )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(707, 0LL);
			//       if ( !Patch )
			//         goto LABEL_30;
			//       v43 = *(_OWORD *)&origProj.m01;
			//       *(_OWORD *)&v70.m00 = *(_OWORD *)&origProj.m00;
			//       v44 = *(_OWORD *)&origProj.m02;
			//       *(_OWORD *)&v70.m01 = v43;
			//       v45 = *(_OWORD *)&origProj.m03;
			//       *(_OWORD *)&v70.m02 = v44;
			//       *(_OWORD *)&v70.m03 = v45;
			//       v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_262(&v73, Patch, (Object *)this, &v70, (Object *)hgrp, 0LL);
			//       v47 = *(_OWORD *)&v46.m01;
			//       *(_OWORD *)&retstr.m00 = *(_OWORD *)&v46.m00;
			//       v48 = *(_OWORD *)&v46.m02;
			//       *(_OWORD *)&retstr.m01 = v47;
			//       v49 = *(_OWORD *)&v46.m03;
			//       *(_OWORD *)&retstr.m02 = v48;
			// LABEL_57:
			//       *(_OWORD *)&retstr.m03 = v49;
			//       return retstr;
			//     }
			//   }
			//   if ( UnityEngine::FrameDebugger::get_enabled(0LL) )
			//   {
			//     v65 = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                       (TileAnimationData *)&taaJitter,
			//                       (TileBase *)v11,
			//                       v12,
			//                       v13,
			//                       v67);
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&origProj.m00;
			//     v66 = *(_OWORD *)&origProj.m02;
			//     this.fields.taaJitter = v65;
			//     *(_OWORD *)&retstr.m01 = *(_OWORD *)&origProj.m01;
			//     v49 = *(_OWORD *)&origProj.m03;
			//     *(_OWORD *)&retstr.m02 = v66;
			//     goto LABEL_57;
			//   }
			//   if ( !hgrp )
			//     goto LABEL_30;
			//   settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     *(double *)v5.m128_u64 = il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v11);
			//   v15 = 1.0 / HG::Rendering::Runtime::HGUtils::GetRenderingScale(this, settingParameters_k__BackingField, 0LL);
			//   if ( (this.fields.m_antialiasingMode & 0x10) != 0 )
			//   {
			//     v50 = this.fields.taaFrameIndex & 0x1F;
			//     v5.m128_f32[0] = UnityEngine::Rendering::HaltonSequence::Get(v50 + 1, 2, 0LL);
			//     v18 = v5;
			//     v18.m128_f32[0] = v5.m128_f32[0] - 0.5;
			//     v26 = 0.5 - UnityEngine::Rendering::HaltonSequence::Get(v50 + 1, 3, 0LL);
			//   }
			//   else
			//   {
			//     v16 = 0.0;
			//     v17 = (this.fields.taaFrameIndex & 0x3FF) + 1;
			//     v18 = 0LL;
			//     v19 = 0.5;
			//     do
			//     {
			//       v20 = v17 % 2;
			//       v17 /= 2;
			//       v21 = (float)v20 * v19;
			//       v19 = v19 * 0.5;
			//       v18.m128_f32[0] = v18.m128_f32[0] + v21;
			//     }
			//     while ( v17 > 0 );
			//     v18.m128_f32[0] = v18.m128_f32[0] - 0.5;
			//     v22 = 0.33333334;
			//     v23 = (this.fields.taaFrameIndex & 0x3FF) + 1;
			//     do
			//     {
			//       v11 = (unsigned int)(v23 / 3);
			//       planes = (Camera *)(unsigned int)(v23 % 3);
			//       LODWORD(v11) = (unsigned __int64)(1431655766LL * v23) >> 32;
			//       v24 = (float)(v23 % 3);
			//       v23 /= 3;
			//       v25 = v24 * v22;
			//       v22 = v22 / 3.0;
			//       v16 = v16 + v25;
			//     }
			//     while ( v23 > 0 );
			//     v26 = v16 - 0.5;
			//   }
			//   camera = this.fields.camera;
			//   v28 = _mm_shuffle_ps(v18, v18, 225);
			//   v28.m128_f32[0] = v26;
			//   v29 = _mm_shuffle_ps(v28, v28, 198);
			//   v29.m128_f32[0] = (float)(v18.m128_f32[0] / (float)this.fields._actualWidth_k__BackingField) * v15;
			//   v30 = _mm_shuffle_ps(v29, v29, 39);
			//   v30.m128_f32[0] = (float)(v26 / (float)this.fields._actualHeight_k__BackingField) * v15;
			//   taaJitter = _mm_shuffle_ps(v30, v30, 57);
			//   this.fields.taaJitter = (Vector4)taaJitter;
			//   if ( !camera )
			//     goto LABEL_30;
			//   v31 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F41C8;
			//   if ( !qword_18D8F41C8 )
			//   {
			//     v31 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_orthographic()");
			//     if ( !v31 )
			//     {
			//       v51 = sub_1802DBBE8("UnityEngine.Camera::get_orthographic()");
			//       sub_18000F750(v51, 0LL);
			//     }
			//     qword_18D8F41C8 = (__int64)v31;
			//   }
			//   if ( !v31(camera) )
			//   {
			//     v72 = 0LL;
			//     v32 = (void (__fastcall *)(Matrix4x4 *, __m128 *))qword_18D8F4BB8;
			//     v71 = 0LL;
			//     if ( !qword_18D8F4BB8 )
			//     {
			//       v32 = (void (__fastcall *)(Matrix4x4 *, __m128 *))il2cpp_resolve_icall_0(
			//                                                           "UnityEngine.Matrix4x4::DecomposeProjection_Injected(UnityEngin"
			//                                                           "e.Matrix4x4&,UnityEngine.FrustumPlanes&)");
			//       if ( !v32 )
			//       {
			//         v52 = sub_1802DBBE8("UnityEngine.Matrix4x4::DecomposeProjection_Injected(UnityEngine.Matrix4x4&,UnityEngine.FrustumPlanes&)");
			//         sub_18000F750(v52, 0LL);
			//       }
			//       qword_18D8F4BB8 = (__int64)v32;
			//     }
			//     v32(origProj, &v71);
			//     v34 = TypeInfo::System::Math._1.cctor_finished_or_no_cctor == 0;
			//     taaJitter = v71;
			//     v69 = v72;
			//     if ( v34 )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Math, v33);
			//     if ( !(unsigned __int8)sub_18272C380() )
			//       goto LABEL_26;
			//     planes = (Camera *)this.fields.frustum.planes;
			//     if ( planes )
			//     {
			//       sub_18003EB40(planes, 5LL);
			// LABEL_26:
			//       v36 = (void (__fastcall *)(Matrix4x4 *, __int64, __int64))qword_18D8F4BF8;
			//       memset(&v70, 0, sizeof(v70));
			//       if ( !qword_18D8F4BF8 )
			//       {
			//         v36 = (void (__fastcall *)(Matrix4x4 *, __int64, __int64))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Matrix4x4::Frustum_Injected(System.Singl"
			//                                                                     "e,System.Single,System.Single,System.Single,System.S"
			//                                                                     "ingle,System.Single,UnityEngine.Matrix4x4&)");
			//         if ( !v36 )
			//         {
			//           v53 = sub_1802DBBE8(
			//                   "UnityEngine.Matrix4x4::Frustum_Injected(System.Single,System.Single,System.Single,System.Single,System"
			//                   ".Single,System.Single,UnityEngine.Matrix4x4&)");
			//           sub_18000F750(v53, 0LL);
			//         }
			//         qword_18D8F4BF8 = (__int64)v36;
			//       }
			//       v36(&v70, v11, v35);
			//       v37 = *(_OWORD *)&v70.m00;
			//       v38 = *(_OWORD *)&v70.m01;
			//       v39 = *(_OWORD *)&v70.m02;
			//       v40 = *(_OWORD *)&v70.m03;
			//       goto LABEL_28;
			//     }
			// LABEL_30:
			//     sub_180B536AC(planes, v11);
			//   }
			//   planes = this.fields.camera;
			//   if ( !planes )
			//     goto LABEL_30;
			//   orthographicSize = UnityEngine::Camera::get_orthographicSize(planes, 0LL);
			//   planes = this.fields.camera;
			//   v55 = orthographicSize;
			//   if ( !planes )
			//     goto LABEL_30;
			//   aspect = UnityEngine::Camera::get_aspect(planes, 0LL);
			//   planes = this.fields.camera;
			//   v57 = aspect * v55;
			//   v58 = (float)this.fields._actualHeight_k__BackingField * 0.5;
			//   v59 = (float)this.fields._actualWidth_k__BackingField * 0.5;
			//   taaJitter = (__m128)this.fields.taaJitter;
			//   v60 = (float)((float)(v55 / v58) * v15) * taaJitter.m128_f32[1];
			//   if ( !planes )
			//     goto LABEL_30;
			//   v61 = UnityEngine::Camera::get_nearClipPlane(planes, 0LL);
			//   planes = this.fields.camera;
			//   v62 = v61;
			//   if ( !planes )
			//     goto LABEL_30;
			//   farClipPlane = UnityEngine::Camera::get_farClipPlane(planes, 0LL);
			//   v64 = UnityEngine::Matrix4x4::Ortho(
			//           &v73,
			//           (float)((float)((float)(v57 / v59) * v15) * taaJitter.m128_f32[0]) - v57,
			//           (float)((float)((float)(v57 / v59) * v15) * taaJitter.m128_f32[0]) + v57,
			//           v60 - v55,
			//           v60 + v55,
			//           v62,
			//           farClipPlane,
			//           0LL);
			//   v37 = *(_OWORD *)&v64.m00;
			//   v38 = *(_OWORD *)&v64.m01;
			//   v39 = *(_OWORD *)&v64.m02;
			//   v40 = *(_OWORD *)&v64.m03;
			// LABEL_28:
			//   *(_OWORD *)&retstr.m00 = v37;
			//   *(_OWORD *)&retstr.m01 = v38;
			//   *(_OWORD *)&retstr.m02 = v39;
			//   *(_OWORD *)&retstr.m03 = v40;
			//   return retstr;
			// }
			// 
			return null;
		}

		private Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(in HGCamera.ViewConstants viewConstants, Vector4 resolution, [MetadataOffset(Offset = "0x01F9148D")] float aspect = -1f)
		{
			// // Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(HGCamera+ViewConstants ByRef, Vector4, Single)
			// Matrix4x4 *HG::Rendering::Runtime::HGCamera::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGCamera *this,
			//         HGCamera_ViewConstants *viewConstants,
			//         Vector4 *resolution,
			//         float aspect,
			//         MethodInfo *method)
			// {
			//   Camera *camera; // rcx
			//   __int64 v11; // rdx
			//   Camera *v12; // rdi
			//   unsigned __int8 (__fastcall *v13)(Camera *); // rax
			//   float v14; // xmm3_4
			//   float v15; // xmm2_4
			//   void (__fastcall *v16)(__int128 *, __int128 *); // rax
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm1
			//   Matrix4x4 *v19; // rax
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   void (__fastcall *v24)(_OWORD *, __int128 *, __int128 *); // rax
			//   void (__fastcall *v25)(Matrix4x4 *, _OWORD *, Matrix4x4 *); // rax
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   Matrix4x4 *result; // rax
			//   bool v30; // al
			//   float GateFittedFieldOfView; // xmm0_4
			//   float v32; // xmm6_4
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   Beyond::DampingMath *v36; // rcx
			//   Vector2 GateFittedLensShift; // rax
			//   __int128 v38; // xmm8
			//   Vector2 v39; // xmm7_8
			//   __int128 v40; // xmm9
			//   __int128 v41; // xmm10
			//   __int128 v42; // xmm11
			//   __int64 v43; // rdx
			//   bool orthographic; // di
			//   Vector4 v45; // xmm0
			//   Matrix4x4 *v46; // rax
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v50; // rax
			//   __int64 v51; // rax
			//   __int64 v52; // rax
			//   __int64 v53; // rax
			//   __int64 v54; // rax
			//   Vector4 v55; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector4 v56; // [rsp+60h] [rbp-A0h] BYREF
			//   Matrix4x4 v57; // [rsp+70h] [rbp-90h] BYREF
			//   __int128 v58; // [rsp+B0h] [rbp-50h] BYREF
			//   __int128 v59; // [rsp+C0h] [rbp-40h]
			//   __int128 v60; // [rsp+D0h] [rbp-30h]
			//   __int128 v61; // [rsp+E0h] [rbp-20h]
			//   __int128 v62; // [rsp+F0h] [rbp-10h] BYREF
			//   __int128 v63; // [rsp+100h] [rbp+0h]
			//   __int128 v64; // [rsp+110h] [rbp+10h]
			//   __int128 v65; // [rsp+120h] [rbp+20h]
			//   __m128i si128; // [rsp+130h] [rbp+30h] BYREF
			//   __m128i v67; // [rsp+140h] [rbp+40h] BYREF
			//   Matrix4x4 v68; // [rsp+150h] [rbp+50h] BYREF
			//   _OWORD v69[4]; // [rsp+190h] [rbp+90h] BYREF
			//   _OWORD v70[4]; // [rsp+1D0h] [rbp+D0h] BYREF
			// 
			//   if ( !byte_18D8EDA20 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDA20 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
			//   if ( !v11 )
			//     goto LABEL_38;
			//   if ( *(int *)(v11 + 24) > 711 )
			//   {
			//     if ( !LODWORD(camera[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(camera, v11);
			//       camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v11 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
			//     if ( !v11 )
			//       goto LABEL_38;
			//     if ( *(_DWORD *)(v11 + 24) <= 0x2C7u )
			//       goto LABEL_57;
			//     if ( *(_QWORD *)(v11 + 5720) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(711, 0LL);
			//       if ( Patch )
			//       {
			//         v55 = *resolution;
			//         v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_267(
			//                 &v68,
			//                 Patch,
			//                 (Object *)this,
			//                 viewConstants,
			//                 &v55,
			//                 aspect,
			//                 0LL);
			// LABEL_37:
			//         v47 = *(_OWORD *)&v46.m01;
			//         *(_OWORD *)&retstr.m00 = *(_OWORD *)&v46.m00;
			//         v48 = *(_OWORD *)&v46.m02;
			//         *(_OWORD *)&retstr.m01 = v47;
			//         v28 = *(_OWORD *)&v46.m03;
			//         *(_OWORD *)&retstr.m02 = v48;
			//         goto LABEL_25;
			//       }
			// LABEL_38:
			//       sub_180B536AC(camera, v11);
			//     }
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v11);
			//     camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !LODWORD(camera[9].monitor) )
			//   {
			//     il2cpp_runtime_class_init_0(camera, v11);
			//     camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v11 = *(_QWORD *)camera[7].fields._._._.m_CachedPtr;
			//   if ( !v11 )
			//     goto LABEL_38;
			//   if ( *(int *)(v11 + 24) <= 712 )
			//     goto LABEL_17;
			//   if ( !LODWORD(camera[9].monitor) )
			//   {
			//     il2cpp_runtime_class_init_0(camera, v11);
			//     camera = (Camera *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   camera = *(Camera **)camera[7].fields._._._.m_CachedPtr;
			//   if ( !camera )
			//     goto LABEL_38;
			//   if ( LODWORD(camera[1].klass) <= 0x2C8 )
			// LABEL_57:
			//     sub_180070270(camera, v11);
			//   if ( camera[238].fields._._._.m_CachedPtr )
			//   {
			//     v50 = IFix::WrappersManagerImpl::GetPatch(712, 0LL);
			//     if ( !v50 )
			//       goto LABEL_38;
			//     v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_265(v50, &viewConstants.projMatrix, 0LL);
			//     goto LABEL_27;
			//   }
			// LABEL_17:
			//   if ( viewConstants.projMatrix.m02 != 0.0 )
			//     goto LABEL_18;
			//   v30 = viewConstants.projMatrix.m12 != 0.0;
			// LABEL_27:
			//   if ( !v30 )
			//   {
			// LABEL_28:
			//     camera = this.fields.camera;
			//     if ( camera )
			//     {
			//       GateFittedFieldOfView = UnityEngine::Camera::GetGateFittedFieldOfView(camera, 0LL);
			//       camera = this.fields.camera;
			//       v32 = GateFittedFieldOfView * 0.017453292;
			//       if ( camera )
			//       {
			//         if ( !UnityEngine::Camera::get_usePhysicalProperties(camera, 0LL) )
			//         {
			//           v33 = *(_OWORD *)&viewConstants.projMatrix.m01;
			//           *(_OWORD *)&v57.m00 = *(_OWORD *)&viewConstants.projMatrix.m00;
			//           v34 = *(_OWORD *)&viewConstants.projMatrix.m02;
			//           *(_OWORD *)&v57.m01 = v33;
			//           v35 = *(_OWORD *)&viewConstants.projMatrix.m03;
			//           *(_OWORD *)&v57.m02 = v34;
			//           *(_OWORD *)&v57.m03 = v35;
			//           *(float *)&v35 = -1.0 / UnityEngine::Matrix4x4::get_Item(&v57, 5, 0LL);
			//           Beyond::DampingMath::fast_atan(v36, *(float *)&v35);
			//           v32 = *(float *)&v35 + *(float *)&v35;
			//         }
			//         camera = this.fields.camera;
			//         if ( camera )
			//         {
			//           GateFittedLensShift = UnityEngine::Camera::GetGateFittedLensShift(camera, 0LL);
			//           camera = this.fields.camera;
			//           v38 = *(_OWORD *)&viewConstants.viewMatrix.m00;
			//           v39 = GateFittedLensShift;
			//           v40 = *(_OWORD *)&viewConstants.viewMatrix.m01;
			//           v41 = *(_OWORD *)&viewConstants.viewMatrix.m02;
			//           v42 = *(_OWORD *)&viewConstants.viewMatrix.m03;
			//           if ( camera )
			//           {
			//             orthographic = UnityEngine::Camera::get_orthographic(camera, 0LL);
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v43);
			//             v45 = *resolution;
			//             *(_OWORD *)&v57.m00 = v38;
			//             v55 = v45;
			//             *(_OWORD *)&v57.m01 = v40;
			//             *(_OWORD *)&v57.m02 = v41;
			//             *(_OWORD *)&v57.m03 = v42;
			//             v46 = HG::Rendering::Runtime::HGUtils::ComputePixelCoordToWorldSpaceViewDirectionMatrix(
			//                     &v68,
			//                     v32,
			//                     v39,
			//                     &v55,
			//                     &v57,
			//                     0,
			//                     aspect,
			//                     orthographic,
			//                     0LL);
			//             goto LABEL_37;
			//           }
			//         }
			//       }
			//     }
			//     goto LABEL_38;
			//   }
			// LABEL_18:
			//   v12 = this.fields.camera;
			//   if ( !v12 )
			//     goto LABEL_38;
			//   v13 = (unsigned __int8 (__fastcall *)(Camera *))qword_18D8F4228;
			//   if ( !qword_18D8F4228 )
			//   {
			//     v13 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_usePhysicalProperties()");
			//     if ( !v13 )
			//     {
			//       v51 = sub_1802DBBE8("UnityEngine.Camera::get_usePhysicalProperties()");
			//       sub_18000F750(v51, 0LL);
			//     }
			//     qword_18D8F4228 = (__int64)v13;
			//   }
			//   if ( v13(v12) )
			//     goto LABEL_28;
			//   v14 = resolution.z + resolution.z;
			//   v15 = resolution.w * -2.0;
			//   memset(&v57, 0, sizeof(v57));
			//   v56.x = 0.0;
			//   v56.z = 0.0;
			//   v56.w = 1.0;
			//   *(_QWORD *)&v55.y = 0LL;
			//   v55.x = v14;
			//   v56.y = v15;
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//   v67 = _mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//   v55.w = -1.0;
			//   UnityEngine::Matrix4x4::Matrix4x4(&v57, &v55, &v56, (Vector4 *)&v67, (Vector4 *)&si128, 0LL);
			//   v16 = (void (__fastcall *)(__int128 *, __int128 *))qword_18D8F4BD8;
			//   v17 = *(_OWORD *)&viewConstants.invViewProjMatrix.m01;
			//   v62 = *(_OWORD *)&viewConstants.invViewProjMatrix.m00;
			//   v63 = v17;
			//   v18 = *(_OWORD *)&viewConstants.invViewProjMatrix.m03;
			//   v64 = *(_OWORD *)&viewConstants.invViewProjMatrix.m02;
			//   v65 = v18;
			//   v58 = 0LL;
			//   v59 = 0LL;
			//   v60 = 0LL;
			//   v61 = 0LL;
			//   if ( !qword_18D8F4BD8 )
			//   {
			//     v16 = (void (__fastcall *)(__int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4"
			//                                                          "&,UnityEngine.Matrix4x4&)");
			//     if ( !v16 )
			//     {
			//       v52 = sub_1802DBBE8("UnityEngine.Matrix4x4::Transpose_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v52, 0LL);
			//     }
			//     qword_18D8F4BD8 = (__int64)v16;
			//   }
			//   v16(&v62, &v58);
			//   v56.z = -1.0;
			//   *(_QWORD *)&v56.x = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0];
			//   v19 = UnityEngine::Matrix4x4::Scale(&v68, (Vector3 *)&v56, 0LL);
			//   v69[0] = v58;
			//   v69[1] = v59;
			//   v69[2] = v60;
			//   v20 = *(_OWORD *)&v19.m00;
			//   v69[3] = v61;
			//   v21 = *(_OWORD *)&v19.m01;
			//   v62 = v20;
			//   v22 = *(_OWORD *)&v19.m02;
			//   v63 = v21;
			//   v23 = *(_OWORD *)&v19.m03;
			//   v24 = (void (__fastcall *)(_OWORD *, __int128 *, __int128 *))qword_18D8F4BC0;
			//   v64 = v22;
			//   v65 = v23;
			//   v58 = 0LL;
			//   v59 = 0LL;
			//   v60 = 0LL;
			//   v61 = 0LL;
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v24 = (void (__fastcall *)(_OWORD *, __int128 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                    "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inject"
			//                                                                    "ed(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//                                                                    "yEngine.Matrix4x4&)");
			//     if ( !v24 )
			//     {
			//       v53 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v53, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v24;
			//   }
			//   v24(v69, &v62, &v58);
			//   v25 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))qword_18D8F4BC0;
			//   v68 = v57;
			//   v70[0] = v58;
			//   v70[1] = v59;
			//   v70[2] = v60;
			//   v70[3] = v61;
			//   memset(&v57, 0, sizeof(v57));
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v25 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
			//                                                                      "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
			//                                                                      "UnityEngine.Matrix4x4&)");
			//     if ( !v25 )
			//     {
			//       v54 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v54, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v25;
			//   }
			//   v25(&v68, v70, &v57);
			//   v26 = *(_OWORD *)&v57.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v57.m00;
			//   v27 = *(_OWORD *)&v57.m02;
			//   *(_OWORD *)&retstr.m01 = v26;
			//   v28 = *(_OWORD *)&v57.m03;
			//   *(_OWORD *)&retstr.m02 = v27;
			// LABEL_25:
			//   result = retstr;
			//   *(_OWORD *)&retstr.m03 = v28;
			//   return result;
			// }
			// 
			return null;
		}

		private static void InitializeRenderPath(HGCamera camera, HGRenderPathInternal renderPathInternalEnum, HGRenderPipeline hgrp)
		{
			// // Void InitializeRenderPath(HGCamera, HGRenderPathInternal, HGRenderPipeline)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGCamera::InitializeRenderPath(
			//         HGCamera *camera,
			//         HGRenderPathInternal__Enum renderPathInternalEnum,
			//         HGRenderPipeline *hgrp,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   HGRenderPathBase *wrapperArray; // rdx
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methodc; // [rsp+20h] [rbp-38h]
			//   String *v21; // [rsp+28h] [rbp-30h]
			//   String *v22; // [rsp+28h] [rbp-30h]
			//   String *v23; // [rsp+28h] [rbp-30h]
			//   _BYTE v24[40]; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   *(_QWORD *)&v24[8] = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&renderPathInternalEnum);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (HGRenderPathBase *)v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( (int)wrapperArray.fields._intermediateBackBuffer_k__BackingField.fallBackResource.m_Value > 661 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( !v7 )
			//       goto LABEL_13;
			//     if ( LODWORD(v7._0.namespaze) <= 0x295 )
			//       sub_180070270(v7, wrapperArray);
			//     if ( *((_QWORD *)&v7[14]._0.this_arg + 1) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(661, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
			//           (ILFixDynamicMethodWrapper_14 *)Patch,
			//           (Object *)camera,
			//           (SCMessageID__Enum)renderPathInternalEnum,
			//           (Object *)hgrp,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_13;
			//     }
			//   }
			//   if ( !camera )
			//     goto LABEL_13;
			//   if ( !camera.fields._renderPathInstance_k__BackingField )
			//     goto LABEL_11;
			//   if ( camera.fields._renderPathInstance_k__BackingField.fields._renderPath_k__BackingField != renderPathInternalEnum )
			//   {
			//     if ( camera.fields._renderPathInstance_k__BackingField )
			//     {
			//       if ( camera.fields.reflectionProbeViewHandle )
			//         UnityEngine::HyperGryph::HGReflectionProbe::ResetView(camera.fields.reflectionProbeViewHandle, 0LL);
			//       wrapperArray = camera.fields._renderPathInstance_k__BackingField;
			//       if ( hgrp && wrapperArray )
			//       {
			//         sub_180078890(13LL, wrapperArray, hgrp.fields.m_RenderGraph);
			//         goto LABEL_12;
			//       }
			//       goto LABEL_13;
			//     }
			// LABEL_11:
			//     if ( hgrp )
			//     {
			// LABEL_12:
			//       *(_QWORD *)v24 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//       ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//         (OneofDescriptor *)v24,
			//         v9,
			//         v10,
			//         v11,
			//         (String__Array *)methoda,
			//         v21);
			//       *(_QWORD *)&v24[8] = hgrp.fields._settingParameters_k__BackingField;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&v24[8],
			//         v12,
			//         v13,
			//         *(MessageDescriptor **)&v24[8],
			//         (String__Array *)methodb,
			//         v22,
			//         *(MethodInfo **)v24);
			//       *(_OWORD *)&v24[16] = *(_OWORD *)v24;
			//       camera.fields._renderPathInstance_k__BackingField = HG::Rendering::Runtime::HGRenderPathBase::CreateRenderPath(
			//                                                              renderPathInternalEnum,
			//                                                              (HGRenderPathBase_HGRenderPathResources *)&v24[16],
			//                                                              camera,
			//                                                              0LL);
			//       sub_1800054D0(
			//         (OneofDescriptor *)&camera.fields._renderPathInstance_k__BackingField,
			//         v14,
			//         v15,
			//         v16,
			//         (String__Array *)methodc,
			//         v23,
			//         *(MethodInfo **)v24);
			//       return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// }
			// 
		}

		private void Dispose(HGRenderGraph renderGraph, CustomDepthOnlyRequestManager customDepthOnlyRequestMgr, long customDepthOnlyRequestMgrCPP)
		{
			// // Void Dispose(HGRenderGraph, CustomDepthOnlyRequestManager, Int64)
			// void HG::Rendering::Runtime::HGCamera::Dispose(
			//         HGCamera *this,
			//         HGRenderGraph *renderGraph,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   VolumeManager *instance; // rax
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle_ *v11; // rdx
			//   HGShadowManager *shadowManager; // rcx
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   BufferedRTHandleSystem *m_HistoryRTSystem; // rdi
			//   int32_t i; // edi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *m_rtExtractionLists; // rax
			//   int32_t j; // esi
			//   List_1_HashSet_1_UnityEngine_Rendering_RTHandle___Array *v20; // rax
			//   Object *Item; // rax
			//   __int64 v22; // rdx
			//   HGRainRenderer *s_rainRenderer; // rax
			//   HGSnowRenderer *s_snowRenderer; // rax
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   MessageDescriptor *v27; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *P3; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v30; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v31; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDA21 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::VolumeManager);
			//     byte_18D8EDA21 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(506, 0LL) )
			//   {
			//     if ( this.fields.verticalOcclusionMapManager )
			//       HG::Rendering::Runtime::HGVerticalOcclusionMapManager::Dispose(
			//         this.fields.verticalOcclusionMapManager,
			//         customDepthOnlyRequestMgr,
			//         customDepthOnlyRequestMgrCPP,
			//         0LL);
			//     if ( this.fields.reflectionProbeViewHandle )
			//       UnityEngine::HyperGryph::HGReflectionProbe::RemoveView(this.fields.reflectionProbeViewHandle, 0LL);
			//     if ( this.fields.renderPathInstanceCPP )
			//       UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::HGRenderPath_Destroy(this.fields.renderPathInstanceCPP, 0LL);
			//     if ( this.fields._renderPathInstance_k__BackingField )
			//       sub_180078890(13LL, this.fields._renderPathInstance_k__BackingField, renderGraph);
			//     if ( !TypeInfo::UnityEngine::Rendering::VolumeManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::VolumeManager, v9);
			//     instance = UnityEngine::Rendering::VolumeManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       UnityEngine::Rendering::VolumeManager::DestroyStack(instance, this.fields._volumeStack_k__BackingField, 0LL);
			//       if ( this.fields.m_HistoryRTSystem )
			//       {
			//         m_HistoryRTSystem = this.fields.m_HistoryRTSystem;
			//         if ( !m_HistoryRTSystem.fields.m_DisposedValue )
			//         {
			//           UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseAll(this.fields.m_HistoryRTSystem, 0LL);
			//           m_HistoryRTSystem.fields.m_DisposedValue = 1;
			//         }
			//         this.fields.m_HistoryRTSystem = 0LL;
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_HistoryRTSystem, v13, v14, v15, P3, (String *)v30, v31);
			//       }
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v13);
			//       HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//         &this.fields.volumetricIntegratedLightScatteringTexture,
			//         0LL);
			//       HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//         &this.fields.historyVolumetricLightScatteringTexture,
			//         0LL);
			//       HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&this.fields.atmosphereSkyViewLutTexture, 0LL);
			//       if ( this.fields.autoExposureHistogramBuffer )
			//       {
			//         UnityEngine::ComputeBuffer::Dispose(this.fields.autoExposureHistogramBuffer, 0LL);
			//         this.fields.autoExposureHistogramBuffer = 0LL;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.autoExposureHistogramBuffer,
			//           v25,
			//           v26,
			//           v27,
			//           P3,
			//           (String *)v30,
			//           v31);
			//       }
			//       for ( i = 0; ; ++i )
			//       {
			//         m_rtExtractionLists = this.fields.m_rtExtractionLists;
			//         if ( !m_rtExtractionLists )
			//           goto LABEL_41;
			//         if ( i >= m_rtExtractionLists.max_length.size )
			//           break;
			//         for ( j = 0; ; ++j )
			//         {
			//           v20 = this.fields.m_rtExtractionLists;
			//           if ( !v20 )
			//             goto LABEL_41;
			//           if ( (unsigned int)i >= v20.max_length.size )
			//             sub_180070270(shadowManager, v11);
			//           shadowManager = (HGShadowManager *)i;
			//           v11 = v20.vector[i];
			//           if ( !v11 )
			//             goto LABEL_41;
			//           if ( j >= v11.fields._size )
			//             break;
			//           Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                    (List_1_System_Object_ *)this.fields.m_rtExtractionLists.vector[i],
			//                    j,
			//                    MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Item);
			//           if ( !Item )
			//             goto LABEL_41;
			//           System::Collections::Generic::HashSet<UnityEngine::Vector3Int>::Clear(
			//             (HashSet_1_UnityEngine_Vector3Int_ *)Item,
			//             MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Clear);
			//         }
			//       }
			//       UnityEngine::HyperGryph::HGCullingSystem::UnregisterCullViewUniqueId(this.fields.cullingViewUniqueID, 0LL);
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v22);
			//       s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//       if ( s_rainRenderer )
			//       {
			//         HG::Rendering::Runtime::HGRainRenderer::DisposeSeq(s_rainRenderer, this, 0LL);
			//         s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
			//         if ( s_snowRenderer )
			//         {
			//           HG::Rendering::Runtime::HGSnowRenderer::DisposeSeq(s_snowRenderer, this, 0LL);
			//           shadowManager = this.fields.shadowManager;
			//           if ( shadowManager )
			//           {
			//             HG::Rendering::Runtime::HGShadowManager::Cleanup(shadowManager, 0LL);
			//             shadowManager = (HGShadowManager *)this.fields.lightCookieManager;
			//             if ( shadowManager )
			//             {
			//               HG::Rendering::Runtime::HGLightCookieManager::Dispose((HGLightCookieManager *)shadowManager, 0LL);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_41:
			//     sub_180B536AC(shadowManager, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(506, 0LL);
			//   if ( !Patch )
			//     goto LABEL_41;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_213(
			//     Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     (Object *)customDepthOnlyRequestMgr,
			//     customDepthOnlyRequestMgrCPP,
			//     0LL);
			// }
			// 
		}

		public int GetSortingOrdersToBlurCount()
		{
			// // Int32 GetSortingOrdersToBlurCount()
			// int32_t HG::Rendering::Runtime::HGCamera::GetSortingOrdersToBlurCount(HGCamera *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   List_1_System_Int32_ *m_sortingOrdersToBlur; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDA22 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     byte_18D8EDA22 = 1;
			//   }
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
			//   if ( wrapperArray.max_length.size <= 971 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_11;
			//   if ( LODWORD(v3._0.namespaze) <= 0x3CB )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*(_QWORD *)&v3[20]._1.token )
			//   {
			// LABEL_9:
			//     m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//     if ( m_sortingOrdersToBlur )
			//       return m_sortingOrdersToBlur.fields._size;
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(971, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public unsafe void ExtractSortingOrdersToBlurForCPP(int* dst, int count)
		{
			// // Void ExtractSortingOrdersToBlurForCPP(Int32*, Int32)
			// void HG::Rendering::Runtime::HGCamera::ExtractSortingOrdersToBlurForCPP(
			//         HGCamera *this,
			//         int32_t *dst,
			//         int32_t count,
			//         MethodInfo *method)
			// {
			//   int32_t *v5; // rsi
			//   int32_t i; // edi
			//   List_1_System_Int32_ *m_sortingOrdersToBlur; // rcx
			// 
			//   v5 = dst;
			//   if ( !byte_18D8EDA23 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     byte_18D8EDA23 = 1;
			//   }
			//   for ( i = 0; i < count; ++v5 )
			//   {
			//     m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//     if ( !m_sortingOrdersToBlur )
			//       sub_180B536AC(0LL, dst);
			//     *(RegexCharClass_SingleRange *)v5 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                                           (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_sortingOrdersToBlur,
			//                                           i++,
			//                                           MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//   }
			// }
			// 
		}

		internal void OnRecordingBegin()
		{
			// // Void OnRecordingBegin()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCamera::OnRecordingBegin(HGCamera *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_System_Int32_ *m_sortingOrdersToBlur; // rdi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   int v8; // edi
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Il2CppExceptionWrapper *v13; // [rsp+30h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Int32_ v14; // [rsp+38h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v15; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9194A8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     byte_18D9194A8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1063, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1063, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_sortingOrdersToBlur = this.fields.m_sortingOrdersToBlur;
			//     if ( !m_sortingOrdersToBlur )
			//       sub_180B536AC(v4, v3);
			//     *(_OWORD *)&v14._list = 0LL;
			//     Unity::Collections::NativeArray<int>::NativeArray(
			//       (NativeArray_1_System_Int32_ *)&v14,
			//       m_sortingOrdersToBlur.fields._size,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     this.fields.sortingOrdersToBlurInternal = *(NativeArray_1_System_Int32_ *)&v14._list;
			//     v8 = 0;
			//     if ( !this.fields.m_sortingOrdersToBlur )
			//       sub_180B536AC(v7, v6);
			//     System::Collections::Generic::List<int>::GetEnumerator(
			//       &v14,
			//       this.fields.m_sortingOrdersToBlur,
			//       MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     v15 = (List_1_T_Enumerator_System_UInt32_)v14;
			//     v14._list = 0LL;
			//     *(_QWORD *)&v14._index = &v15;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v15,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         v9 = v8++;
			//         *(_DWORD *)&this.fields.sortingOrdersToBlurInternal.m_Buffer[4 * v9] = v15._current;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v13 )
			//     {
			//       v14._list = (List_1_System_Int32_ *)v13.ex;
			//       if ( v14._list )
			//         sub_18000F780(v14._list);
			//     }
			//   }
			// }
			// 
		}

		internal void OnRecordingEnd()
		{
			// // Void OnRecordingEnd()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCamera::OnRecordingEnd(HGCamera *this, MethodInfo *method)
			// {
			//   FileDescriptor *v2; // r8
			//   MessageDescriptor *v3; // r9
			//   Object *v4; // rsi
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Object__Class *klass; // rbx
			//   __int64 v12; // rbx
			//   __int64 *v13; // rdx
			//   OneofDescriptor__Class *monitor; // rcx
			//   MessageDescriptor *containingType; // rbx
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // r8
			//   Object__Class *v19; // rbx
			//   int32_t klassIndex; // r14d
			//   const char *name; // r8
			//   int32_t namespaze; // r8d
			//   __int64 v23; // [rsp+0h] [rbp-78h] BYREF
			//   String__Array *v24; // [rsp+20h] [rbp-58h] BYREF
			//   OneofDescriptor v25; // [rsp+28h] [rbp-50h] BYREF
			// 
			//   v4 = (Object *)this;
			//   if ( !byte_18D8EDA24 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::ValueTuple<UnityEngine::Rendering::RTHandle,UnityEngine::Rendering::RTHandle,float>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::GetEnumerator);
			//     byte_18D8EDA24 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v5, method);
			//   if ( wrapperArray.max_length.size > 1036 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, method);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = v5.static_fields.wrapperArray;
			//     if ( !v7 )
			//       sub_180B536AC(v5, method);
			//     if ( v7.max_length.size <= 0x40Cu )
			//       sub_180070270(v5, method);
			//     if ( v7[28].vector[28] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1036, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v10, v9);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, v4, 0LL);
			//       return;
			//     }
			//   }
			//   klass = v4[110].klass;
			//   if ( !klass )
			//     sub_180B536AC(v5, method);
			//   if ( LODWORD(klass._0.namespaze) <= 1 )
			//     sub_180070270(v5, method);
			//   v12 = *((_QWORD *)&klass._0.byval_arg + 1);
			//   if ( !v12 )
			//     sub_180B536AC(v5, method);
			//   *(_OWORD *)&v25.monitor = 0LL;
			//   v25.klass = (OneofDescriptor__Class *)v12;
			//   ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//     &v25,
			//     (OneofDescriptorProto *)method,
			//     v2,
			//     v3,
			//     v24);
			//   LODWORD(v25.monitor) = 0;
			//   HIDWORD(v25.monitor) = *(_DWORD *)(v12 + 28);
			//   *(_QWORD *)&v25.fields._._Index_k__BackingField = 0LL;
			//   *(_OWORD *)&v25.fields._._FullName_k__BackingField = *(_OWORD *)&v25.klass;
			//   v25.fields.containingType = 0LL;
			//   v25.klass = 0LL;
			//   v25.monitor = (MonitorData *)&v25.fields._._FullName_k__BackingField;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               (List_1_T_Enumerator_System_Object_ *)&v25.fields._._FullName_k__BackingField,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>>::MoveNext) )
			//     {
			//       containingType = v25.fields.containingType;
			//       if ( !v25.fields.containingType )
			//         sub_1802DC2C8(monitor, v13);
			//       if ( SHIDWORD(v25.fields.containingType.fields._._File_k__BackingField) > 0 )
			//       {
			//         System::Array::Clear(
			//           (Array *)v25.fields.containingType.fields._._FullName_k__BackingField,
			//           0,
			//           HIDWORD(v25.fields.containingType.fields._._File_k__BackingField),
			//           0LL);
			//         v18 = *(_QWORD *)&containingType.fields._._Index_k__BackingField;
			//         if ( !v18 )
			//           sub_1802DC2C8(v17, v16);
			//         System::Array::Clear(*(Array **)&containingType.fields._._Index_k__BackingField, 0, *(_DWORD *)(v18 + 24), 0LL);
			//         containingType.fields._._File_k__BackingField = 0LL;
			//         LODWORD(containingType.fields.fieldsInDeclarationOrder) = -1;
			//       }
			//       ++LODWORD(containingType.fields.jsonFieldMap);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v24 )
			//   {
			//     v13 = &v23;
			//     v25.klass = (OneofDescriptor__Class *)v24.klass;
			//     monitor = v25.klass;
			//     if ( v25.klass )
			//       sub_18000F780(v25.klass);
			//     v4 = (Object *)this;
			//   }
			//   v19 = v4[111].klass;
			//   if ( !v19 )
			//     goto LABEL_36;
			//   klassIndex = v19._0.byval_arg.data.__klassIndex;
			//   if ( klassIndex > 0 )
			//   {
			//     name = v19._0.name;
			//     if ( !name )
			//       goto LABEL_36;
			//     System::Array::Clear((Array *)v19._0.name, 0, *((_DWORD *)name + 6), 0LL);
			//     v19._0.byval_arg.data.__klassIndex = 0;
			//     HIDWORD(v19._0.byval_arg.data.type) = -1;
			//     *((_DWORD *)&v19._0.byval_arg + 2) = 0;
			//     System::Array::Clear((Array *)v19._0.namespaze, 0, klassIndex, 0LL);
			//   }
			//   ++*((_DWORD *)&v19._0.byval_arg + 3);
			//   monitor = (OneofDescriptor__Class *)v4[111].monitor;
			//   if ( !monitor )
			// LABEL_36:
			//     sub_1802DC2C8(monitor, v13);
			//   ++HIDWORD(monitor._0.namespaze);
			//   namespaze = (int32_t)monitor._0.namespaze;
			//   LODWORD(monitor._0.namespaze) = 0;
			//   if ( namespaze > 0 )
			//     System::Array::Clear((Array *)monitor._0.name, 0, namespaze, 0LL);
			// }
			// 
		}

		private void ReleaseHistoryBuffer()
		{
			// // Void ReleaseHistoryBuffer()
			// void HG::Rendering::Runtime::HGCamera::ReleaseHistoryBuffer(HGCamera *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   BufferedRTHandleSystem *m_HistoryRTSystem; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(505, 0LL) )
			//   {
			//     m_HistoryRTSystem = this.fields.m_HistoryRTSystem;
			//     if ( m_HistoryRTSystem )
			//     {
			//       UnityEngine::Rendering::BufferedRTHandleSystem::ReleaseAll(m_HistoryRTSystem, 0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(m_HistoryRTSystem, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(505, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private Rect GetPixelRect()
		{
			// // Rect GetPixelRect()
			// Rect *HG::Rendering::Runtime::HGCamera::GetPixelRect(Rect *__return_ptr retstr, HGCamera *this, MethodInfo *method)
			// {
			//   void *v5; // rcx
			//   Camera *camera; // rdx
			//   Rect value; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Rect v10; // xmm7
			//   Rect v11; // xmm6
			//   int32_t pixelWidth; // eax
			//   int v13; // esi
			//   Rect v14; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDA25 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rect>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rect>::get_Value);
			//     byte_18D8EDA25 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   camera = (Camera *)**((_QWORD **)v5 + 23);
			//   if ( !camera )
			//     goto LABEL_13;
			//   if ( SLODWORD(camera[1].klass) > 682 )
			//   {
			//     if ( !*((_DWORD *)v5 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v5, camera);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (void *)**((_QWORD **)v5 + 23);
			//     if ( !v5 )
			//       goto LABEL_13;
			//     if ( *((_DWORD *)v5 + 6) <= 0x2AAu )
			//       sub_180070270(v5, camera);
			//     if ( *((_QWORD *)v5 + 686) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(682, 0LL);
			//       if ( Patch )
			//       {
			//         value = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_258(&v14, Patch, (Object *)this, 0LL);
			//         goto LABEL_11;
			//       }
			// LABEL_13:
			//       sub_180B536AC(v5, camera);
			//     }
			//   }
			//   if ( !this.fields.overridePixelRect.hasValue )
			//   {
			//     camera = this.fields.camera;
			//     if ( camera )
			//     {
			//       v10 = *UnityEngine::Camera::get_pixelRect(&v14, camera, 0LL);
			//       camera = this.fields.camera;
			//       if ( camera )
			//       {
			//         v11 = *UnityEngine::Camera::get_pixelRect(&v14, camera, 0LL);
			//         v5 = this.fields.camera;
			//         if ( v5 )
			//         {
			//           pixelWidth = UnityEngine::Camera::get_pixelWidth((Camera *)v5, 0LL);
			//           v5 = this.fields.camera;
			//           v13 = pixelWidth;
			//           if ( v5 )
			//           {
			//             retstr.m_Height = (float)UnityEngine::Camera::get_pixelHeight((Camera *)v5, 0LL);
			//             retstr.m_XMin = v10.m_XMin;
			//             LODWORD(retstr.m_YMin) = _mm_shuffle_ps((__m128)v11, (__m128)v11, 85).m128_u32[0];
			//             retstr.m_Width = (float)v13;
			//             return retstr;
			//           }
			//         }
			//       }
			//     }
			//     goto LABEL_13;
			//   }
			//   value = this.fields.overridePixelRect.value;
			// LABEL_11:
			//   *retstr = value;
			//   return retstr;
			// }
			// 
			return null;
		}

		internal BufferedRTHandleSystem GetHistoryRTHandleSystem()
		{
			// // BufferedRTHandleSystem GetHistoryRTHandleSystem()
			// BufferedRTHandleSystem *HG::Rendering::Runtime::HGCamera::GetHistoryRTHandleSystem(HGCamera *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2360, 0LL) )
			//     return this.fields.m_HistoryRTSystem;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2360, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_848(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		internal void BindHistoryRTHandleSystem(BufferedRTHandleSystem historyRTSystem)
		{
		}

		internal Matrix4x4 GetHGCameraCullingMatrix()
		{
			// // Matrix4x4 GetHGCameraCullingMatrix()
			// Matrix4x4 *HG::Rendering::Runtime::HGCamera::GetHGCameraCullingMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGCamera *this,
			//         MethodInfo *method)
			// {
			//   void *v5; // rcx
			//   Camera *v6; // rdx
			//   HGRenderPipelineSettingHub *instance; // rax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   float heightFogCullingFarClipPlane; // xmm6_4
			//   Camera *camera; // rdi
			//   float (__fastcall *v11)(Camera *); // rax
			//   Camera *v12; // rdi
			//   void (__fastcall *v13)(Camera *, Matrix4x4 *); // rax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   Matrix4x4 *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 *v19; // rax
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v21; // rax
			//   float fieldOfView; // xmm0_4
			//   float v23; // xmm8_4
			//   float aspect; // xmm0_4
			//   float v25; // xmm7_4
			//   float v26; // xmm0_4
			//   Matrix4x4 *v27; // rax
			//   __int128 v28; // xmm6
			//   __int128 v29; // xmm7
			//   __int128 v30; // xmm8
			//   __int128 v31; // xmm9
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int64 v38; // rax
			//   Matrix4x4 v39; // [rsp+30h] [rbp-108h] BYREF
			//   Matrix4x4 v40; // [rsp+70h] [rbp-C8h] BYREF
			//   Matrix4x4 v41; // [rsp+B0h] [rbp-88h] BYREF
			// 
			//   if ( !byte_18D8EDA26 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDA26 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (Camera *)**((_QWORD **)v5 + 23);
			//   if ( !v6 )
			//     goto LABEL_20;
			//   if ( SLODWORD(v6[1].klass) > 703 )
			//   {
			//     if ( !*((_DWORD *)v5 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v5, v6);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (void *)**((_QWORD **)v5 + 23);
			//     if ( !v5 )
			//       goto LABEL_20;
			//     if ( *((_DWORD *)v5 + 6) <= 0x2BFu )
			//       sub_180070270(v5, v6);
			//     if ( *((_QWORD *)v5 + 707) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
			//       if ( Patch )
			//       {
			//         v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_186(&v40, Patch, (Object *)this, 0LL);
			// LABEL_45:
			//         v36 = *(_OWORD *)&v19.m01;
			//         *(_OWORD *)&retstr.m00 = *(_OWORD *)&v19.m00;
			//         v37 = *(_OWORD *)&v19.m02;
			//         *(_OWORD *)&retstr.m01 = v36;
			//         v16 = *(_OWORD *)&v19.m03;
			//         *(_OWORD *)&retstr.m02 = v37;
			//         goto LABEL_19;
			//       }
			// LABEL_20:
			//       sub_180B536AC(v5, v6);
			//     }
			//   }
			//   instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_20;
			//   m_impl = instance.fields.m_impl;
			//   if ( !m_impl )
			//     goto LABEL_20;
			//   if ( m_impl.fields._currentDeviceType_k__BackingField == 1 )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v6);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(this, 0LL);
			//     if ( !InterpolatedPhase )
			//       goto LABEL_20;
			//     heightFogCullingFarClipPlane = InterpolatedPhase.fields.heightFogConfig.heightFogCullingFarClipPlane;
			//   }
			//   else
			//   {
			//     heightFogCullingFarClipPlane = 3.4028235e38;
			//   }
			//   camera = this.fields.camera;
			//   if ( !camera )
			//     goto LABEL_20;
			//   v11 = (float (__fastcall *)(Camera *))qword_18D8F4188;
			//   if ( !qword_18D8F4188 )
			//   {
			//     v11 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_farClipPlane()");
			//     if ( !v11 )
			//     {
			//       v21 = sub_1802DBBE8("UnityEngine.Camera::get_farClipPlane()");
			//       sub_18000F750(v21, 0LL);
			//     }
			//     qword_18D8F4188 = (__int64)v11;
			//   }
			//   if ( heightFogCullingFarClipPlane < v11(camera) )
			//   {
			//     v5 = this.fields.camera;
			//     if ( v5 )
			//     {
			//       if ( UnityEngine::Camera::get_orthographic((Camera *)v5, 0LL) )
			//         goto LABEL_16;
			//       v5 = this.fields.camera;
			//       if ( v5 )
			//       {
			//         fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)v5, 0LL);
			//         v5 = this.fields.camera;
			//         v23 = fieldOfView;
			//         if ( v5 )
			//         {
			//           aspect = UnityEngine::Camera::get_aspect((Camera *)v5, 0LL);
			//           v5 = this.fields.camera;
			//           v25 = aspect;
			//           if ( v5 )
			//           {
			//             v26 = UnityEngine::Camera::get_nearClipPlane((Camera *)v5, 0LL);
			//             v27 = UnityEngine::Matrix4x4::Perspective(&v40, v23, v25, v26, heightFogCullingFarClipPlane, 0LL);
			//             v6 = this.fields.camera;
			//             v28 = *(_OWORD *)&v27.m00;
			//             v29 = *(_OWORD *)&v27.m01;
			//             v30 = *(_OWORD *)&v27.m02;
			//             v31 = *(_OWORD *)&v27.m03;
			//             if ( v6 )
			//             {
			//               worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v40, v6, 0LL);
			//               v33 = *(_OWORD *)&worldToCameraMatrix.m01;
			//               *(_OWORD *)&v39.m00 = *(_OWORD *)&worldToCameraMatrix.m00;
			//               v34 = *(_OWORD *)&worldToCameraMatrix.m02;
			//               *(_OWORD *)&v39.m01 = v33;
			//               v35 = *(_OWORD *)&worldToCameraMatrix.m03;
			//               *(_OWORD *)&v39.m02 = v34;
			//               *(_OWORD *)&v39.m03 = v35;
			//               *(_OWORD *)&v40.m00 = v28;
			//               *(_OWORD *)&v40.m01 = v29;
			//               *(_OWORD *)&v40.m02 = v30;
			//               *(_OWORD *)&v40.m03 = v31;
			//               v19 = UnityEngine::Matrix4x4::op_Multiply(&v41, &v40, &v39, 0LL);
			//               goto LABEL_45;
			//             }
			//           }
			//         }
			//       }
			//     }
			//     goto LABEL_20;
			//   }
			// LABEL_16:
			//   v12 = this.fields.camera;
			//   if ( !v12 )
			//     goto LABEL_20;
			//   v13 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18D8F42B8;
			//   memset(&v39, 0, sizeof(v39));
			//   if ( !qword_18D8F42B8 )
			//   {
			//     v13 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v13 )
			//     {
			//       v38 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v38, 0LL);
			//     }
			//     qword_18D8F42B8 = (__int64)v13;
			//   }
			//   v13(v12, &v39);
			//   v14 = *(_OWORD *)&v39.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v39.m00;
			//   v15 = *(_OWORD *)&v39.m02;
			//   *(_OWORD *)&retstr.m01 = v14;
			//   v16 = *(_OWORD *)&v39.m03;
			//   *(_OWORD *)&retstr.m02 = v15;
			// LABEL_19:
			//   result = retstr;
			//   *(_OWORD *)&retstr.m03 = v16;
			//   return result;
			// }
			// 
			return null;
		}

		public void SetForceJitterPhaseIdx(int idx)
		{
			// // Void SetForceJitterPhaseIdx(Int32)
			// void HG::Rendering::Runtime::HGCamera::SetForceJitterPhaseIdx(HGCamera *this, int32_t idx, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2362, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2362, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, idx, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_ForceJitterIdx = idx;
			//   }
			// }
			// 
		}

		private Vector2Int m_finalRTSize;

		public Frustum frustum;

		public Camera camera;

		public Vector4 taaJitter;

		public HGCamera.ViewConstants mainViewConstants;

		public bool prevTransformReset;

		public Nullable<Rect> overridePixelRect;

		internal ComputeBuffer autoExposureHistogramBuffer;

		internal float[] autoExposureHistogramRes;

		internal bool autoExposureReadyForNextFetch;

		public float exposureTargetAdaptation;

		public float exposureAdaptation;

		public float waterCameraFoVInc;

		public float waterCameraPositionOffset;

		internal HGVerticalOcclusionMapManager verticalOcclusionMapManager;

		private List<HashSet<RTHandle>>[] m_rtExtractionLists;

		private uint m_nextWaterMarkHandle;

		private Dictionary<uint, ValueTuple<RTHandle, RTHandle, float>> m_waterMarkRTs;

		private List<ValueTuple<RTHandle, float>> m_inplaceWaterMarkRTs;

		internal bool previousFrameWasTAAUpsampled;

		private bool m_DisableFrameGenTemporarily;

		public long renderPathInstanceCPP;

		public unsafe HGRenderPathBeforeCullingParamsCPP* beforeCullingParams;

		public Material lutBuilder2DMaterialCPP;

		public Material uiImageBlurMatCPP;

		internal Material fishEyeEffectMaterialCPP;

		internal HGShadowManager shadowManager;

		internal HGLightCookieManager lightCookieManager;

		internal bool regenerateAsmTriggerForCpp;

		internal Vector4[] frustumPlaneEquations;

		internal int taaFrameIndex;

		internal float taaSharpenStrength;

		internal float taaHistorySharpening;

		internal float taaAntiFlicker;

		internal float taaMotionVectorRejection;

		internal float taaBaseBlendFactor;

		internal bool taaAntiRinging;

		internal int taaJitterPhaseCount;

		internal Vector4 zBufferParams;

		internal Vector4 unity_OrthoParams;

		internal Vector4 projectionParams;

		internal Vector4 screenParams;

		internal int volumeLayerMask;

		internal Transform volumeAnchor;

		internal Rect finalViewport;

		internal Rect prevFinalViewport;

		internal int colorPyramidHistoryMipCount;

		internal RenderTexture volumetricIntegratedLightScatteringTexture;

		internal RenderTexture historyVolumetricLightScatteringTexture;

		internal float historyVolumetricLightScatteringPreExposure;

		internal RenderTexture atmosphereSkyViewLutTexture;

		internal HGAtmosphereRenderer.AtmosphereLutConstants atmosphereLutConstants;

		internal const int PINGPONG_COUNT = 2;

		internal Matrix4x4 frustumCornorsRay;

		internal Mesh parafinMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly uint COMPOUND_CHARACTER_LAYER_MASK;

		private bool m_firstGetDoFComponent;

		internal uint cameraFrameCount;

		private Camera m_parentCamera;

		internal float lowResScale;

		internal bool realtimeReflectionProbe;

		internal bool isPersistent;

		internal HGUtils.PackedMipChainInfo m_DepthBufferMipChainInfo;

		private HGAdditionalCameraData.ClearColorMode m_PreviousClearColorMode;

		private HGAdditionalCameraData.AntialiasingMode m_antialiasingMode;

		internal NativeArray<int> sortingOrdersToBlurInternal;

		internal bool enableUpdatingSceneFrostedGlass;

		private short m_uiAfterBlurSortingOrder;

		private List<int> m_sortingOrdersToBlur;

		private HGCamera m_lwCameraAttached;

		public bool applyTableSettings;

		internal bool resetPostProcessingHistory;

		internal bool didResetPostProcessingHistoryInLastFrame;

		private HGCamera.VolumeComponentsData m_volumeComponentsData;

		public HGEnvironmentVolumeCameraComponent m_envVolumeCameraComponent;

		public float screenCullingRatio;

		public float screenRatioCullingDistance;

		private uint _screenCullingLayerMask;

		internal bool preivousEnableCppRenderPath;

		internal bool enableShadowCulling;

		internal LODCrossFadeConfig lodCrossFadeConfig;

		internal uint cullingViewHandle;

		internal JobHandle cullingJobHandle;

		internal int vtFeedbackViewId;

		internal int subdivisionHandle;

		internal uint terrainCullViewHandle;

		internal uint editorTerrainCullViewHandle;

		internal uint waterProxyVisibleCount;

		internal uint waterDecalVisibleCount;

		internal uint waterProxyCullHandle;

		internal uint waterDecalCullHandle;

		internal Matrix4x4 waterCullingMatrix;

		internal bool useWetnessMask;

		internal bool reflectionProbeReset;

		internal uint reflectionProbeViewHandle;

		internal int reflectionProbeOctTextureSize;

		internal int reflectionProbeOctTextureArrayCount;

		internal GraphicsFormat reflectionProbeOctTextureFormat;

		internal uint cullingViewUniqueID;

		internal uint rayTracingCullingViewHandle;

		internal uint rayTracingTLASHandle;

		internal bool overrideCsmShadowDistance;

		internal float overrideCsmMaxDistanceValue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static Dictionary<ValueTuple<Camera, int>, HGCamera> s_Cameras;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static List<ValueTuple<Camera, int>> s_Cleanup;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static int worldUILayerIndex;

		private HGAdditionalCameraData m_AdditionalCameraData;

		private BufferedRTHandleSystem m_HistoryRTSystem;

		private IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> m_RecorderCaptureActions;

		private int m_RecorderTempRT;

		private MaterialPropertyBlock m_RecorderPropertyBlock;

		private int m_ForceJitterIdx;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 1520)]
		public struct ViewConstants
		{
			public Matrix4x4 viewMatrix;

			public Matrix4x4 invViewMatrix;

			public Matrix4x4 projMatrix;

			public Matrix4x4 nonJitteredProjMatrix;

			public Matrix4x4 invProjMatrix;

			public Matrix4x4 viewProjMatrix;

			public Matrix4x4 viewNoTransProjMatrix;

			public Matrix4x4 invViewProjMatrix;

			public Matrix4x4 nonJitteredViewProjMatrix;

			public Matrix4x4 nonJitteredViewNoTransProjMatrix;

			public Matrix4x4 invNonJitteredViewProjMatrix;

			public Matrix4x4 prevViewMatrix;

			public Matrix4x4 prevViewProjMatrix;

			public Matrix4x4 prevViewNoTransProjMatrix;

			public Matrix4x4 prevNonJitteredViewProjMatrix;

			public Matrix4x4 prevNonJitteredViewNoTransProjMatrix;

			public Matrix4x4 prevInvViewProjMatrix;

			public Matrix4x4 prevNonJitteredInvViewProjMatrix;

			public Matrix4x4 reprojectionMatrix;

			public Matrix4x4 widerFoVViewProjMatrix;

			public Matrix4x4 widerFoVInvViewProjMatrix;

			public Matrix4x4 pixelCoordToViewDirWS;

			public Matrix4x4 cullingMatrix;

			public Vector3 worldSpaceCameraPos;

			internal float pad0;

			public Vector3 worldSpaceCameraPosViewOffset;

			internal float pad1;

			public Vector3 prevWorldSpaceCameraPos;

			internal float pad2;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		public struct WaterMarkOutputCPP
		{
			public unsafe int* srcRTs;

			public unsafe int* dstRTs;

			public unsafe float* heightScales;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct InplaceWaterMarkOutputCPP
		{
			public unsafe int* dstRTs;

			public unsafe float* heightScales;
		}

		internal enum HistoryEffectSlot
		{
			GlobalIllumination0,
			GlobalIllumination1,
			RayTracedReflections,
			VolumetricClouds,
			Count
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		internal struct HistoryEffectValidity
		{
			public int frameCount;

			public int flagMask;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct DynamicResolutionRequest
		{
			public bool enabled;

			public bool cameraRequested;

			public bool hardwareEnabled;

			public DynamicResUpscaleFilter filter;
		}

		public class VolumeComponentsData
		{
			public VolumeComponentsData()
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

			public Bloom m_bloom;

			public Vignette m_vignette;

			public HGVignette m_hgVignette;

			public HGDirtyLens m_hgDirtyLens;

			public HGSharpen m_sharpen;

			public HGRadialBlur m_radialBlur;

			public HGBWFlash m_bwFlash;

			public HGFisheyeEffect m_fisheyeEffect;

			public HGChromaticAbberation m_chromaticAbberation;

			public HGDepthOfField m_depthOfField;

			public HGMotionBlur m_motionBlur;

			public HGCharacterVolume m_hgCharacterVolume;

			public HGSceneColorStylizer m_sceneColorStylizer;

			public ScreenSpaceReflectionVolume m_hgssrVolume;

			public ScreenSpacePlanarReflectionVolume m_ssprVolume;

			public HGScanLine m_hgScanLine;

			public HGBlackBox m_hgBlackBox;

			public GTAmbientOcclusion m_GTAmbientOcclusion;

			public OtherSettings m_otherSettings;

			public RayTracingReflectionVolume m_rayTracingReflectionVolume;

			public HGAnamorphicStreaks m_anamorphicStreaks;
		}
	}
}
