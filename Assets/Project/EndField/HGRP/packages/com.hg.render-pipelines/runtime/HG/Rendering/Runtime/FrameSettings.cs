using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[DebuggerTypeProxy(typeof(FrameSettings.FrameSettingsDebugView))]
	[DebuggerDisplay("{bitDatas.humanizedData}")]
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	public struct FrameSettings
	{
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00002968 File Offset: 0x00000B68
		public ulong Data1
		{
			get
			{
				// // UIntPtr ReadUnaligned[UIntPtr](Byte ByRef)
				// void *System::Runtime::CompilerServices::Unsafe::ReadUnaligned<void *>(uint8_t *source, MethodInfo *method)
				// {
				//   return *(void **)source;
				// }
				// 
				return 0UL;
			}
		}

		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00002968 File Offset: 0x00000B68
		public ulong Data2
		{
			get
			{
				// // Object get_data()
				// Object *UnityEngine::UIElements::TreeViewItemData<System::Object>::get_data(
				//         TreeViewItemData_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_Data;
				// }
				// 
				return 0UL;
			}
		}

		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00002C08 File Offset: 0x00000E08
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x000025D0 File Offset: 0x000007D0
		public LitShaderMode litShaderMode
		{
			get
			{
				// // LitShaderMode get_litShaderMode()
				// LitShaderMode__Enum HG::Rendering::Runtime::FrameSettings::get_litShaderMode(FrameSettings *this, MethodInfo *method)
				// {
				//   return UnityEngine::Rendering::BitArrayUtilities::Get128(0, this.bitDatas.data1, this.bitDatas.data2, 0LL);
				// }
				// 
				return (LitShaderMode)LitShaderMode.Forward;
			}
			set
			{
				// // Void set_litShaderMode(LitShaderMode)
				// void HG::Rendering::Runtime::FrameSettings::set_litShaderMode(
				//         FrameSettings *this,
				//         LitShaderMode__Enum value,
				//         MethodInfo *method)
				// {
				//   uint64_t data1; // rax
				//   uint64_t v4; // rax
				// 
				//   data1 = this.bitDatas.data1;
				//   if ( value == LitShaderMode__Enum_Deferred )
				//     v4 = data1 | 1;
				//   else
				//     v4 = data1 & 0xFFFFFFFFFFFFFFFEuLL;
				//   this.bitDatas.data1 = v4;
				// }
				// 
			}
		}

		internal static FrameSettings NewDefaultCamera()
		{
			// // FrameSettings NewDefaultCamera()
			// FrameSettings *HG::Rendering::Runtime::FrameSettings::NewDefaultCamera(
			//         FrameSettings *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // r8
			//   __int64 v4; // r9
			//   Array *v5; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   BitArray128 *v10; // rax
			//   uint64_t data1; // xmm1_8
			//   BitArray128 v12; // [rsp+20h] [rbp-38h] BYREF
			//   FrameSettings v13; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDB20 )
			//   {
			//     sub_18003C530(&77A2EB460A3818E210E2F840DDA09B2C807220E7A60104E92E0DDEFEC1B387EC_Field);
			//     sub_18003C530(&TypeInfo::System::UInt32);
			//     byte_18D8EDB20 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3069, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3069, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = (BitArray128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1074(&v13, Patch, 0LL);
			//     data1 = v10[1].data1;
			//     retstr.bitDatas = *v10;
			//     *(_QWORD *)&retstr.materialQuality = data1;
			//   }
			//   else
			//   {
			//     *(_QWORD *)&v13.materialQuality = 0LL;
			//     v5 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::UInt32, 18LL, v3, v4);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v5,
			//       77A2EB460A3818E210E2F840DDA09B2C807220E7A60104E92E0DDEFEC1B387EC_Field,
			//       0LL);
			//     v12 = 0LL;
			//     UnityEngine::Rendering::BitArray128::BitArray128(&v12, (IEnumerable_1_System_UInt32_ *)v5, 0LL);
			//     retstr.bitDatas = v12;
			//     *(_QWORD *)&retstr.materialQuality = *(_QWORD *)&v13.materialQuality;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		internal static FrameSettings NewDefaultRealtimeReflectionProbe()
		{
			// // FrameSettings NewDefaultRealtimeReflectionProbe()
			// FrameSettings *HG::Rendering::Runtime::FrameSettings::NewDefaultRealtimeReflectionProbe(
			//         FrameSettings *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // r8
			//   __int64 v4; // r9
			//   Array *v5; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   BitArray128 *v10; // rax
			//   uint64_t data1; // xmm1_8
			//   BitArray128 v12; // [rsp+20h] [rbp-38h] BYREF
			//   FrameSettings v13; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDB21 )
			//   {
			//     sub_18003C530(&DD57B6A9816D1DE2228F42CF6225F4F4C257A77DA881CBB6958B859986C6AF92_Field);
			//     sub_18003C530(&TypeInfo::System::UInt32);
			//     byte_18D8EDB21 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3070, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3070, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = (BitArray128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1074(&v13, Patch, 0LL);
			//     data1 = v10[1].data1;
			//     retstr.bitDatas = *v10;
			//     *(_QWORD *)&retstr.materialQuality = data1;
			//   }
			//   else
			//   {
			//     *(_QWORD *)&v13.materialQuality = 0LL;
			//     v5 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::UInt32, 10LL, v3, v4);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v5,
			//       DD57B6A9816D1DE2228F42CF6225F4F4C257A77DA881CBB6958B859986C6AF92_Field,
			//       0LL);
			//     v12 = 0LL;
			//     UnityEngine::Rendering::BitArray128::BitArray128(&v12, (IEnumerable_1_System_UInt32_ *)v5, 0LL);
			//     retstr.bitDatas = v12;
			//     *(_QWORD *)&retstr.materialQuality = *(_QWORD *)&v13.materialQuality;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		internal static FrameSettings NewDefaultCustomOrBakeReflectionProbe()
		{
			// // FrameSettings NewDefaultCustomOrBakeReflectionProbe()
			// FrameSettings *HG::Rendering::Runtime::FrameSettings::NewDefaultCustomOrBakeReflectionProbe(
			//         FrameSettings *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // r8
			//   __int64 v4; // r9
			//   Array *v5; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   BitArray128 *v10; // rax
			//   uint64_t data1; // xmm1_8
			//   BitArray128 v12; // [rsp+20h] [rbp-38h] BYREF
			//   FrameSettings v13; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDB22 )
			//   {
			//     sub_18003C530(&E4124068B388CAE09971E522698B949597FCE871A01FA3D95EEAEC672859F2A2_Field);
			//     sub_18003C530(&TypeInfo::System::UInt32);
			//     byte_18D8EDB22 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3071, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3071, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = (BitArray128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1074(&v13, Patch, 0LL);
			//     data1 = v10[1].data1;
			//     retstr.bitDatas = *v10;
			//     *(_QWORD *)&retstr.materialQuality = data1;
			//   }
			//   else
			//   {
			//     *(_QWORD *)&v13.materialQuality = 0LL;
			//     v5 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::UInt32, 12LL, v3, v4);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v5,
			//       E4124068B388CAE09971E522698B949597FCE871A01FA3D95EEAEC672859F2A2_Field,
			//       0LL);
			//     v12 = 0LL;
			//     UnityEngine::Rendering::BitArray128::BitArray128(&v12, (IEnumerable_1_System_UInt32_ *)v5, 0LL);
			//     retstr.bitDatas = v12;
			//     *(_QWORD *)&retstr.materialQuality = *(_QWORD *)&v13.materialQuality;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public bool IsEnabled(FrameSettingsField field)
		{
			// // Boolean IsEnabled(FrameSettingsField)
			// // local variable allocation has failed, the output may be wrong!
			// bool HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//         FrameSettings *this,
			//         FrameSettingsField__Enum field,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v7; // rax
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
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&field);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 679 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x2A7 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[14]._1.typeHierarchy )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(679, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_256(Patch, this, field, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   v7 = 1LL << (field & 0x3F);
			//   if ( (unsigned int)field >= 0x40 )
			//     return (v7 & this.bitDatas.data2) != 0;
			//   else
			//     return (v7 & this.bitDatas.data1) != 0;
			// }
			// 
			return default(bool);
		}

		public void SetEnabled(FrameSettingsField field, bool value)
		{
			// // Void SetEnabled(FrameSettingsField, Boolean)
			// void HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//         FrameSettings *this,
			//         FrameSettingsField__Enum field,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3072, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3072, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1075(Patch, this, field, value, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Rendering::BitArray128::set_Item(&this.bitDatas, field, value, 0LL);
			//   }
			// }
			// 
		}

		internal static void Override(ref FrameSettings overriddenFrameSettings, FrameSettings overridingFrameSettings, FrameSettingsOverrideMask frameSettingsOverideMask)
		{
			// // Void Override(FrameSettings ByRef, FrameSettings, FrameSettingsOverrideMask)
			// void HG::Rendering::Runtime::FrameSettings::Override(
			//         FrameSettings *overriddenFrameSettings,
			//         FrameSettings *overridingFrameSettings,
			//         FrameSettingsOverrideMask *frameSettingsOverideMask,
			//         MethodInfo *method)
			// {
			//   FrameSettingsOverrideMask v7; // xmm1
			//   BitArray128 v8; // xmm2
			//   uint64_t data2; // rax
			//   uint64_t v10; // rcx
			//   BitArray128 v11; // xmm0
			//   BitArray128 *v12; // rax
			//   bool v13; // zf
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   BitArray128 bitDatas; // xmm1
			//   BitArray128 v18; // [rsp+38h] [rbp-9h] BYREF
			//   BitArray128 v19; // [rsp+48h] [rbp+7h] BYREF
			//   BitArray128 v20; // [rsp+58h] [rbp+17h] BYREF
			//   BitArray128 mask; // [rsp+68h] [rbp+27h] BYREF
			//   FrameSettings v22; // [rsp+78h] [rbp+37h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(646, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(646, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     bitDatas = overridingFrameSettings.bitDatas;
			//     mask = frameSettingsOverideMask.mask;
			//     *(_QWORD *)&v22.materialQuality = *(_QWORD *)&overridingFrameSettings.materialQuality;
			//     v22.bitDatas = bitDatas;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_241(
			//       Patch,
			//       overriddenFrameSettings,
			//       &v22,
			//       (FrameSettingsOverrideMask *)&mask,
			//       0LL);
			//   }
			//   else
			//   {
			//     v7 = *frameSettingsOverideMask;
			//     v8 = overridingFrameSettings.bitDatas;
			//     data2 = frameSettingsOverideMask.mask.data2;
			//     v10 = ~frameSettingsOverideMask.mask.data1;
			//     *(_QWORD *)&v22.materialQuality = *(_QWORD *)&overridingFrameSettings.materialQuality;
			//     v11 = overriddenFrameSettings.bitDatas;
			//     v18.data1 = v10;
			//     v18.data2 = ~data2;
			//     v20 = v7.mask;
			//     v19 = v11;
			//     mask = v8;
			//     v19 = *UnityEngine::Rendering::BitArray128::op_BitwiseAnd(&v22.bitDatas, &v18, &v19, 0LL);
			//     mask = *UnityEngine::Rendering::BitArray128::op_BitwiseAnd(&v22.bitDatas, &mask, &v20, 0LL);
			//     v12 = UnityEngine::Rendering::BitArray128::op_BitwiseOr(&v22.bitDatas, &mask, &v19, 0LL);
			//     v13 = (frameSettingsOverideMask.mask.data2 & 4) == 0;
			//     overriddenFrameSettings.bitDatas = *v12;
			//     if ( !v13 )
			//     {
			//       *(_QWORD *)&v22.materialQuality = *(_QWORD *)&overridingFrameSettings.materialQuality;
			//       overriddenFrameSettings.materialQuality = v22.materialQuality;
			//     }
			//   }
			// }
			// 
		}

		internal static void Sanitize(ref FrameSettings sanitizedFrameSettings, Camera camera, in RenderPipelineSettings renderPipelineSettings)
		{
			// // Void Sanitize(FrameSettings ByRef, Camera, RenderPipelineSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::Sanitize(
			//         FrameSettings *sanitizedFrameSettings,
			//         Camera *camera,
			//         RenderPipelineSettings *renderPipelineSettings,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   unsigned int (__fastcall *v9)(Camera *, ILFixDynamicMethodWrapper_2__Array *, RenderPipelineSettings *, MethodInfo *); // rax
			//   bool v10; // si
			//   void (__fastcall *v11)(Camera *, Matrix4x4 *); // rax
			//   __int64 v12; // rdx
			//   __int128 v13; // xmm6
			//   __int128 v14; // xmm7
			//   __int128 v15; // xmm8
			//   __int128 v16; // xmm9
			//   __int64 v17; // rdx
			//   char v18; // di
			//   struct ILFixDynamicMethodWrapper_2__Class *v19; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v20; // rdx
			//   unsigned int (__fastcall *v21)(Camera *); // rax
			//   bool v22; // cl
			//   uint64_t v23; // rax
			//   unsigned __int64 v24; // rax
			//   unsigned __int64 v25; // rax
			//   unsigned __int64 v26; // rax
			//   unsigned __int64 v27; // rax
			//   bool v28; // r8
			//   unsigned __int64 v29; // rax
			//   char v30; // r8
			//   bool v31; // r9
			//   unsigned __int64 v32; // rax
			//   unsigned __int64 v33; // rax
			//   unsigned __int64 v34; // rax
			//   uint64_t v35; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v37; // rax
			//   __int64 v38; // rax
			//   ILFixDynamicMethodWrapper_2 *v39; // rax
			//   ILFixDynamicMethodWrapper_2 *v40; // rax
			//   __int64 v41; // rax
			//   __int64 v42; // rdx
			//   Object *v43; // rbx
			//   Object *component; // [rsp+38h] [rbp-71h] BYREF
			//   Matrix4x4 v45; // [rsp+40h] [rbp-69h] BYREF
			//   Matrix4x4 v46; // [rsp+80h] [rbp-29h] BYREF
			// 
			//   if ( !byte_18D8EDB23 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDB23 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_64;
			//   if ( wrapperArray.max_length.size > 647 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v7.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_64;
			//     if ( wrapperArray.max_length.size <= 0x287u )
			//       goto LABEL_86;
			//     if ( wrapperArray[18].max_length.value )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(647, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_242(
			//           Patch,
			//           sanitizedFrameSettings,
			//           (Object *)camera,
			//           renderPipelineSettings,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_64;
			//     }
			//   }
			//   if ( !camera )
			//     goto LABEL_64;
			//   v9 = (unsigned int (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, RenderPipelineSettings *, MethodInfo *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v9 = (unsigned int (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, RenderPipelineSettings *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v9 )
			//     {
			//       v37 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v37, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v9;
			//   }
			//   v10 = v9(camera, wrapperArray, renderPipelineSettings, method) == 16;
			//   v11 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18D8F42F0;
			//   memset(&v46, 0, sizeof(v46));
			//   if ( !qword_18D8F42F0 )
			//   {
			//     v11 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v11 )
			//     {
			//       v38 = sub_1802DBBE8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v38, 0LL);
			//     }
			//     qword_18D8F42F0 = (__int64)v11;
			//   }
			//   v11(camera, &v46);
			//   v13 = *(_OWORD *)&v46.m00;
			//   v14 = *(_OWORD *)&v46.m01;
			//   v15 = *(_OWORD *)&v46.m02;
			//   v16 = *(_OWORD *)&v46.m03;
			//   v45 = v46;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v12);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_64;
			//   if ( wrapperArray.max_length.size <= 396 )
			//     goto LABEL_18;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			// LABEL_64:
			//     sub_180B536AC(v7, wrapperArray);
			//   if ( LODWORD(v7._0.namespaze) <= 0x18C )
			// LABEL_86:
			//     sub_180070270(v7, wrapperArray);
			//   if ( v7[8].rgctx_data )
			//   {
			//     v39 = IFix::WrappersManagerImpl::GetPatch(396, 0LL);
			//     if ( v39 )
			//     {
			//       *(_OWORD *)&v45.m00 = v13;
			//       *(_OWORD *)&v45.m01 = v14;
			//       *(_OWORD *)&v45.m02 = v15;
			//       *(_OWORD *)&v45.m03 = v16;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_190(v39, &v45, 0LL);
			//       goto LABEL_20;
			//     }
			//     goto LABEL_64;
			//   }
			// LABEL_18:
			//   if ( UnityEngine::Matrix4x4::get_Item(&v45, 2, 0LL) == 0.0 )
			//     UnityEngine::Matrix4x4::get_Item(&v45, 6, 0LL);
			// LABEL_20:
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v17);
			//   if ( !byte_18D8EDB2A )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB2A = 1;
			//   }
			//   v18 = 0;
			//   component = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v17);
			//     v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v20 = v19.static_fields.wrapperArray;
			//   if ( !v20 )
			//     goto LABEL_65;
			//   if ( v20.max_length.size > 648 )
			//   {
			//     if ( !v19._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v19, v20);
			//       v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v19 = (struct ILFixDynamicMethodWrapper_2__Class *)v19.static_fields.wrapperArray;
			//     if ( !v19 )
			//       goto LABEL_65;
			//     if ( LODWORD(v19._0.namespaze) <= 0x288 )
			//       sub_180070270(v19, v20);
			//     if ( v19[13].vtable.Finalize.methodPtr )
			//     {
			//       v40 = IFix::WrappersManagerImpl::GetPatch(648, 0LL);
			//       if ( v40 )
			//       {
			//         v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v40, (Object *)camera, 0LL);
			//         goto LABEL_33;
			//       }
			// LABEL_65:
			//       sub_180B536AC(v19, v20);
			//     }
			//   }
			//   v21 = (unsigned int (__fastcall *)(Camera *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v21 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v21 )
			//     {
			//       v41 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v41, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v21;
			//   }
			//   if ( v21(camera) == 4 )
			//   {
			//     UnityEngine::Component::TryGetComponent<System::Object>(
			//       (Component *)camera,
			//       &component,
			//       MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     v43 = component;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v42);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)v43, 0LL, 0LL) )
			//     {
			//       v22 = 1;
			//       goto LABEL_33;
			//     }
			//     if ( component )
			//     {
			//       v22 = LOBYTE(component[22].klass) == 0;
			//       goto LABEL_33;
			//     }
			//     goto LABEL_65;
			//   }
			//   v22 = 0;
			// LABEL_33:
			//   if ( (sanitizedFrameSettings.bitDatas.data1 & 0x100000) != 0 && !v22 )
			//     v23 = sanitizedFrameSettings.bitDatas.data1 | 0x100001;
			//   else
			//     v23 = sanitizedFrameSettings.bitDatas.data1 & 0xFFFFFFFFFFEFFFFEuLL | 1;
			//   if ( (v23 & 0x200000) != 0 && !v22 )
			//     v24 = v23 | 0x200000;
			//   else
			//     v24 = v23 & 0xFFFFFFFFFFDFFFFFuLL;
			//   if ( (v24 & 0x800000) != 0 && !v22 )
			//     v25 = v24 | 0x800000;
			//   else
			//     v25 = v24 & 0xFFFFFFFFFF7FFFFFuLL;
			//   if ( (v25 & 0x400000) != 0 && !v22 )
			//     v26 = v25 | 0x400000;
			//   else
			//     v26 = v25 & 0xFFFFFFFFFFBFFFFFuLL;
			//   if ( (v26 & 0x40000000) != 0 && !v22 )
			//     v27 = v26 | 0x40000000;
			//   else
			//     v27 = v26 & 0xFFFFFFFFBFFFFFFFuLL;
			//   v28 = !v10 && !v22;
			//   if ( (v27 & 0x8000) != 0 && v28 )
			//     v29 = v27 | 0x8000;
			//   else
			//     v29 = v27 & 0xFFFFFFFFFFFF7FFFuLL;
			//   v30 = 1;
			//   v31 = !v22 && (v29 & 8) != 0;
			//   if ( (v29 & 0x100) != 0 && v31 )
			//     v32 = v29 | 0x100;
			//   else
			//     v32 = v29 & 0xFFFFFFFFFFFFFEFFuLL;
			//   if ( (v32 & 0x1000) != 0 && !v22 )
			//     v33 = v32 | 0x1000;
			//   else
			//     v33 = v32 & 0xFFFFFFFFFFFFEFFFuLL;
			//   if ( !v22 )
			//   {
			//     if ( (v33 & 8) == 0 )
			//       v30 = 0;
			//     v18 = v30;
			//   }
			//   if ( (((v33 & 0x200) != 0) & (unsigned __int8)v18) != 0 )
			//     v34 = v33 | 0x200;
			//   else
			//     v34 = v33 & 0xFFFFFFFFFFFFFDFFuLL;
			//   if ( (v34 & 8) != 0 && (v34 & 0x40000) != 0 )
			//     v35 = v34 | 0x40000;
			//   else
			//     v35 = v34 & 0xFFFFFFFFFFFBFFFFuLL;
			//   sanitizedFrameSettings.bitDatas.data1 = v35;
			// }
			// 
		}

		[IDTag(1)]
		internal static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, HGAdditionalCameraData additionalData, HGRenderPipelineAsset hgrpAsset)
		{
			// // Void AggregateFrameSettings(FrameSettings ByRef, Camera, HGAdditionalCameraData, HGRenderPipelineAsset)
			// void HG::Rendering::Runtime::FrameSettings::AggregateFrameSettings(
			//         FrameSettings *aggregatedFrameSettings,
			//         Camera *camera,
			//         HGAdditionalCameraData *additionalData,
			//         HGRenderPipelineAsset *hgrpAsset,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGRenderPipelineGlobalSettings *instance; // rax
			//   Object *v12; // r14
			//   unsigned int defaultFrameSettings; // r15d
			//   FrameSettings *p_monitor; // r14
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int64 v21; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v23; // rax
			//   FrameSettings *v24; // rax
			//   unsigned int v25; // r15d
			//   __int64 v26; // rax
			//   SystemException *v27; // rbx
			//   String *v28; // rax
			//   __int64 v29; // rax
			//   ILFixDynamicMethodWrapper_2 *v30; // rax
			//   BitArray128 bitDatas; // xmm1
			//   RenderPipelineSettings renderPipelineSettings; // [rsp+40h] [rbp-B8h] BYREF
			//   FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // [rsp+B0h] [rbp-48h] BYREF
			//   FrameSettings v34; // [rsp+C0h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDB24 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
			//     byte_18D8EDB24 = 1;
			//   }
			//   memset(&renderPipelineSettings, 0, sizeof(renderPipelineSettings));
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( wrapperArray.max_length.size > 652 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v9.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_46;
			//     if ( wrapperArray.max_length.size <= 0x28Cu )
			//       goto LABEL_75;
			//     if ( wrapperArray[18].vector[4] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(652, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_246(
			//           Patch,
			//           aggregatedFrameSettings,
			//           (Object *)camera,
			//           (Object *)additionalData,
			//           (Object *)hgrpAsset,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_46;
			//     }
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings, wrapperArray);
			//   instance = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
			//   v12 = (Object *)instance;
			//   if ( additionalData )
			//     defaultFrameSettings = additionalData.fields.defaultFrameSettings;
			//   else
			//     defaultFrameSettings = 0;
			//   if ( !instance )
			//     goto LABEL_46;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( wrapperArray.max_length.size <= 644 )
			//     goto LABEL_20;
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( wrapperArray.max_length.size <= 0x284u )
			//     goto LABEL_75;
			//   if ( wrapperArray[18].klass )
			//   {
			//     v23 = IFix::WrappersManagerImpl::GetPatch(644, 0LL);
			//     if ( !v23 )
			//       goto LABEL_46;
			//     v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_240(
			//             v23,
			//             v12,
			//             (FrameSettingsRenderType__Enum)defaultFrameSettings,
			//             0LL);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     p_monitor = v24;
			//   }
			//   else
			//   {
			// LABEL_20:
			//     if ( defaultFrameSettings )
			//     {
			//       v25 = defaultFrameSettings - 1;
			//       if ( v25 )
			//       {
			//         if ( v25 != 1 )
			//         {
			//           v26 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//           v27 = (SystemException *)sub_180004920(v26);
			//           if ( v27 )
			//           {
			//             v28 = (String *)sub_18003C530(&off_18D4F7FD8);
			//             System::SystemException::SystemException(v27, v28, 0LL);
			//             v27.fields._._HResult = -2147024809;
			//             v29 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings);
			//             sub_18000F7C0(v27, v29);
			//           }
			//           goto LABEL_46;
			//         }
			//         p_monitor = (FrameSettings *)&v12[5].monitor;
			//       }
			//       else
			//       {
			//         p_monitor = (FrameSettings *)&v12[4];
			//       }
			//     }
			//     else
			//     {
			//       p_monitor = (FrameSettings *)&v12[2].monitor;
			//     }
			//   }
			//   if ( !hgrpAsset )
			//     goto LABEL_46;
			//   v15 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness;
			//   *(_OWORD *)&renderPipelineSettings.colorBufferFormat = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.colorBufferFormat;
			//   v16 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage;
			//   *(_OWORD *)&renderPipelineSettings.dynamicResolutionSettings.DLSSSharpness = v15;
			//   v17 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0;
			//   *(_OWORD *)&renderPipelineSettings.dynamicResolutionSettings.forcedPercentage = v16;
			//   v18 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2;
			//   *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName0 = v17;
			//   v19 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
			//   *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName2 = v18;
			//   v20 = *(_OWORD *)&hgrpAsset.fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6;
			//   *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName4 = v19;
			//   *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName6 = v20;
			//   if ( !byte_18D8EDB25 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDB25 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( wrapperArray.max_length.size > 653 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//     if ( !v9 )
			//       goto LABEL_46;
			//     if ( LODWORD(v9._0.namespaze) > 0x28D )
			//     {
			//       if ( !v9[13].vtable.ToString.method )
			//         goto LABEL_31;
			//       v30 = IFix::WrappersManagerImpl::GetPatch(653, 0LL);
			//       if ( v30 )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_244(
			//           v30,
			//           aggregatedFrameSettings,
			//           (Object *)camera,
			//           (Object *)additionalData,
			//           p_monitor,
			//           &renderPipelineSettings,
			//           0LL);
			//         return;
			//       }
			// LABEL_46:
			//       sub_180B536AC(v9, wrapperArray);
			//     }
			// LABEL_75:
			//     sub_180070270(v9, wrapperArray);
			//   }
			// LABEL_31:
			//   v21 = *(_QWORD *)&p_monitor.materialQuality;
			//   aggregatedFrameSettings.bitDatas = p_monitor.bitDatas;
			//   *(_QWORD *)&aggregatedFrameSettings.materialQuality = v21;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( additionalData )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( additionalData.fields._._._._.m_CachedPtr )
			//     {
			//       if ( additionalData.fields.customRenderingSettings )
			//       {
			//         bitDatas = additionalData.fields.m_RenderingPathCustomFrameSettings.bitDatas;
			//         renderingPathCustomFrameSettingsOverrideMask = additionalData.fields.renderingPathCustomFrameSettingsOverrideMask;
			//         *(_QWORD *)&v34.materialQuality = *(_QWORD *)&additionalData.fields.m_RenderingPathCustomFrameSettings.materialQuality;
			//         v34.bitDatas = bitDatas;
			//         HG::Rendering::Runtime::FrameSettings::Override(
			//           aggregatedFrameSettings,
			//           &v34,
			//           &renderingPathCustomFrameSettingsOverrideMask,
			//           0LL);
			//       }
			//     }
			//   }
			//   HG::Rendering::Runtime::FrameSettings::Sanitize(aggregatedFrameSettings, camera, &renderPipelineSettings, 0LL);
			// }
			// 
		}

		[IDTag(0)]
		internal static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, HGAdditionalCameraData additionalData, ref FrameSettings defaultFrameSettings, in RenderPipelineSettings supportedFeatures)
		{
			// // Void AggregateFrameSettings(FrameSettings ByRef, Camera, HGAdditionalCameraData, FrameSettings ByRef, RenderPipelineSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::AggregateFrameSettings(
			//         FrameSettings *aggregatedFrameSettings,
			//         Camera *camera,
			//         HGAdditionalCameraData *additionalData,
			//         FrameSettings *defaultFrameSettings,
			//         RenderPipelineSettings *supportedFeatures,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v10; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v12; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   BitArray128 bitDatas; // xmm1
			//   FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // [rsp+40h] [rbp-38h] BYREF
			//   FrameSettings v16; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDB25 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB25 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, camera);
			//     v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v10.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_24;
			//   if ( wrapperArray.max_length.size > 653 )
			//   {
			//     if ( !v10._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v10, wrapperArray);
			//       v10 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v10 = (struct ILFixDynamicMethodWrapper_2__Class *)v10.static_fields.wrapperArray;
			//     if ( v10 )
			//     {
			//       if ( LODWORD(v10._0.namespaze) <= 0x28D )
			//         sub_180070270(v10, wrapperArray);
			//       if ( !v10[13].vtable.ToString.method )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(653, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_244(
			//           Patch,
			//           aggregatedFrameSettings,
			//           (Object *)camera,
			//           (Object *)additionalData,
			//           defaultFrameSettings,
			//           supportedFeatures,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_24:
			//     sub_180B536AC(v10, wrapperArray);
			//   }
			// LABEL_9:
			//   v12 = *(_QWORD *)&defaultFrameSettings.materialQuality;
			//   aggregatedFrameSettings.bitDatas = defaultFrameSettings.bitDatas;
			//   *(_QWORD *)&aggregatedFrameSettings.materialQuality = v12;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( additionalData )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( additionalData.fields._._._._.m_CachedPtr )
			//     {
			//       if ( additionalData.fields.customRenderingSettings )
			//       {
			//         bitDatas = additionalData.fields.m_RenderingPathCustomFrameSettings.bitDatas;
			//         renderingPathCustomFrameSettingsOverrideMask = additionalData.fields.renderingPathCustomFrameSettingsOverrideMask;
			//         *(_QWORD *)&v16.materialQuality = *(_QWORD *)&additionalData.fields.m_RenderingPathCustomFrameSettings.materialQuality;
			//         v16.bitDatas = bitDatas;
			//         HG::Rendering::Runtime::FrameSettings::Override(
			//           aggregatedFrameSettings,
			//           &v16,
			//           &renderingPathCustomFrameSettingsOverrideMask,
			//           0LL);
			//       }
			//     }
			//   }
			//   HG::Rendering::Runtime::FrameSettings::Sanitize(aggregatedFrameSettings, camera, supportedFeatures, 0LL);
			// }
			// 
		}

		public static bool operator ==(FrameSettings a, FrameSettings b)
		{
			// // Boolean op_Equality(FrameSettings, FrameSettings)
			// bool HG::Rendering::Runtime::FrameSettings::op_Equality(FrameSettings *a, FrameSettings *b, MethodInfo *method)
			// {
			//   BitArray128 v5; // xmm2
			//   BitArray128 v6; // xmm1
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // xmm1_8
			//   BitArray128 bitDatas; // xmm0
			//   __int64 v13; // xmm1_8
			//   FrameSettings v14; // [rsp+20h] [rbp-40h] BYREF
			//   FrameSettings v15; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(651, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(651, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     v11 = *(_QWORD *)&b.materialQuality;
			//     v15.bitDatas = b.bitDatas;
			//     bitDatas = a.bitDatas;
			//     *(_QWORD *)&v15.materialQuality = v11;
			//     v13 = *(_QWORD *)&a.materialQuality;
			//     v14.bitDatas = bitDatas;
			//     *(_QWORD *)&v14.materialQuality = v13;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_243(Patch, &v14, &v15, 0LL);
			//   }
			//   else
			//   {
			//     v5 = a.bitDatas;
			//     v6 = b.bitDatas;
			//     *(_QWORD *)&v15.materialQuality = *(_QWORD *)&a.materialQuality;
			//     *(_QWORD *)&v15.materialQuality = *(_QWORD *)&b.materialQuality;
			//     v14.bitDatas = v6;
			//     v15.bitDatas = v5;
			//     result = UnityEngine::XR::MeshId::Equals((MeshId *)&v15, (MeshId *)&v14, 0LL);
			//     if ( result )
			//     {
			//       *(_QWORD *)&v14.materialQuality = *(_QWORD *)&a.materialQuality;
			//       return v14.materialQuality == (unsigned int)*(_QWORD *)&b.materialQuality;
			//     }
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public static bool operator !=(FrameSettings a, FrameSettings b)
		{
			// // Boolean op_Inequality(FrameSettings, FrameSettings)
			// bool HG::Rendering::Runtime::FrameSettings::op_Inequality(FrameSettings *a, FrameSettings *b, MethodInfo *method)
			// {
			//   __int64 v5; // xmm1_8
			//   BitArray128 v6; // xmm0
			//   __int64 v7; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // xmm1_8
			//   BitArray128 bitDatas; // xmm0
			//   __int64 v14; // xmm1_8
			//   FrameSettings v15; // [rsp+20h] [rbp-40h] BYREF
			//   FrameSettings v16; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(650, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(650, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = *(_QWORD *)&b.materialQuality;
			//     v16.bitDatas = b.bitDatas;
			//     bitDatas = a.bitDatas;
			//     *(_QWORD *)&v16.materialQuality = v12;
			//     v14 = *(_QWORD *)&a.materialQuality;
			//     v15.bitDatas = bitDatas;
			//     *(_QWORD *)&v15.materialQuality = v14;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_243(Patch, &v15, &v16, 0LL);
			//   }
			//   else
			//   {
			//     v5 = *(_QWORD *)&b.materialQuality;
			//     v15.bitDatas = b.bitDatas;
			//     v6 = a.bitDatas;
			//     *(_QWORD *)&v15.materialQuality = v5;
			//     v7 = *(_QWORD *)&a.materialQuality;
			//     v16.bitDatas = v6;
			//     *(_QWORD *)&v16.materialQuality = v7;
			//     return !HG::Rendering::Runtime::FrameSettings::op_Equality(&v16, &v15, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			// // Boolean Equals(Object)
			// bool HG::Rendering::Runtime::FrameSettings::Equals(FrameSettings *this, Object *obj, MethodInfo *method)
			// {
			//   __int64 v5; // r8
			//   Object *v6; // rax
			//   __int64 v7; // r8
			//   Object *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Object o1; // [rsp+20h] [rbp-28h] BYREF
			//   int32_t materialQuality; // [rsp+30h] [rbp-18h]
			//   int v15; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D91966F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BitArray128);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MaterialQuality);
			//     byte_18D91966F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3073, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3073, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1076(Patch, this, obj, 0LL);
			//   }
			//   else if ( obj
			//          && (struct FrameSettings__Class *)obj.klass == TypeInfo::HG::Rendering::Runtime::FrameSettings
			//          && (o1 = *(Object *)sub_18004A160(obj),
			//              v6 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Rendering::BitArray128, &o1, v5),
			//              UnityEngine::Rendering::BitArray128::Equals(&this.bitDatas, v6, 0LL)) )
			//   {
			//     v15 = *(_DWORD *)(sub_18004A160(obj) + 16);
			//     v8 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Rendering::MaterialQuality, &v15, v7);
			//     o1.monitor = (MonitorData *)-1LL;
			//     o1.klass = (Object__Class *)TypeInfo::UnityEngine::Rendering::MaterialQuality;
			//     materialQuality = this.materialQuality;
			//     return System::ValueType::DefaultEquals(&o1, v8, 0LL);
			//   }
			//   else
			//   {
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public override int GetHashCode()
		{
			// // Int32 GetHashCode()
			// int32_t HG::Rendering::Runtime::FrameSettings::GetHashCode(FrameSettings *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3074, 0LL) )
			//     return -1521134295 * (LODWORD(this.bitDatas.data2) ^ HIDWORD(this.bitDatas.data2))
			//          - 2087829359 * (LODWORD(this.bitDatas.data1) ^ HIDWORD(this.bitDatas.data1))
			//          + this.materialQuality
			//          + 197728996;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3074, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1077(Patch, this, 0LL);
			// }
			// 
			return 0;
		}

		internal static void MigrateFromClassVersion(ref ObsoleteFrameSettings oldFrameSettingsFormat, ref FrameSettings newFrameSettingsFormat, ref FrameSettingsOverrideMask newFrameSettingsOverrideMask)
		{
			// // Void MigrateFromClassVersion(ObsoleteFrameSettings ByRef, FrameSettings ByRef, FrameSettingsOverrideMask ByRef)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::FrameSettings::MigrateFromClassVersion(
			//         ObsoleteFrameSettings **oldFrameSettingsFormat,
			//         FrameSettings *newFrameSettingsFormat,
			//         FrameSettingsOverrideMask *newFrameSettingsOverrideMask,
			//         MethodInfo *method)
			// {
			//   LitShaderMode__Enum v7; // edx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   struct Il2CppType *v30; // rbx
			//   Type *TypeFromHandle; // rbx
			//   Array *Values; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   __int64 v39; // rax
			//   int v40; // ebx
			//   uint64_t v41; // rax
			//   String *v42; // rbx
			//   String *v43; // rax
			//   String *v44; // rsi
			//   __int64 v45; // rax
			//   InvalidEnumArgumentException *v46; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   InvalidEnumArgumentException *v49; // rbx
			//   unsigned int v50; // esi
			//   unsigned __int64 v51; // rdx
			//   char v52; // si
			//   signed __int64 v53; // rtt
			//   __int64 v54; // rax
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   InvalidEnumArgumentException *v57; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   __int64 v61; // rax
			//   String *v62; // rax
			//   __int64 v63; // rax
			//   IEnumerator *Enumerator; // [rsp+30h] [rbp-68h] BYREF
			//   __int64 v65; // [rsp+38h] [rbp-60h] BYREF
			//   Enum v66; // [rsp+48h] [rbp-50h] BYREF
			//   int v67; // [rsp+58h] [rbp-40h]
			//   __int64 v68; // [rsp+60h] [rbp-38h]
			//   Enum v69; // [rsp+68h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919670 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Enum);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::ObsoleteFrameSettingsOverrides);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ObsoleteFrameSettingsOverrides);
			//     sub_18003C530(&TypeInfo::System::Type);
			//     byte_18D919670 = 1;
			//   }
			//   v65 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3075, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3075, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v60, v59);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1078(
			//       Patch,
			//       oldFrameSettingsFormat,
			//       newFrameSettingsFormat,
			//       newFrameSettingsOverrideMask,
			//       0LL);
			//   }
			//   else if ( *oldFrameSettingsFormat )
			//   {
			//     if ( (*oldFrameSettingsFormat).fields.shaderLitMode )
			//     {
			//       if ( (*oldFrameSettingsFormat).fields.shaderLitMode != 1 )
			//       {
			//         v54 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//         v57 = (InvalidEnumArgumentException *)sub_180004920(v54);
			//         if ( !v57 )
			//           sub_180B536AC(v56, v55);
			//         v62 = (String *)sub_18000F7E0(&off_18D50D4C0);
			//         System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v57, v62, 0LL);
			//         v63 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::FrameSettings::MigrateFromClassVersion);
			//         sub_18000F7C0(v57, v63);
			//       }
			//       v7 = LitShaderMode__Enum_Deferred;
			//     }
			//     else
			//     {
			//       v7 = LitShaderMode__Enum_Forward;
			//     }
			//     HG::Rendering::Runtime::FrameSettings::set_litShaderMode(newFrameSettingsFormat, v7, 0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_ShadowMaps,
			//       (*oldFrameSettingsFormat).fields.enableShadow,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v11, v10);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_Shadowmask,
			//       (*oldFrameSettingsFormat).fields.enableShadowMask,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v13, v12);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_LightLayers,
			//       (*oldFrameSettingsFormat).fields.enableLightLayers,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_DepthPrepassWithDeferredRendering,
			//       (*oldFrameSettingsFormat).fields.enableDepthPrepassWithDeferredRendering,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v17, v16);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_TransparentPrepass,
			//       (*oldFrameSettingsFormat).fields.enableTransparentPrepass,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v19, v18);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_Decals,
			//       (*oldFrameSettingsFormat).fields.enableDecals,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v21, v20);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_Refraction,
			//       (*oldFrameSettingsFormat).fields.enableRoughRefraction,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v23, v22);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_TransparentPostpass,
			//       (*oldFrameSettingsFormat).fields.enableTransparentPostpass,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v25, v24);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_Postprocess,
			//       (*oldFrameSettingsFormat).fields.enablePostprocess,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v27, v26);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_OpaqueObjects,
			//       (*oldFrameSettingsFormat).fields.enableOpaqueObjects,
			//       0LL);
			//     if ( !*oldFrameSettingsFormat )
			//       sub_180B536AC(v29, v28);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       newFrameSettingsFormat,
			//       FrameSettingsField__Enum_TransparentObjects,
			//       (*oldFrameSettingsFormat).fields.enableTransparentObjects,
			//       0LL);
			//     *newFrameSettingsOverrideMask = 0LL;
			//     v30 = TypeRef::HG::Rendering::Runtime::ObsoleteFrameSettingsOverrides;
			//     sub_180002C70(TypeInfo::System::Type);
			//     TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v30, 0LL);
			//     sub_180002C70(TypeInfo::System::Enum);
			//     Values = System::Enum::GetValues(TypeFromHandle, 0LL);
			//     if ( !Values )
			//       sub_180B536AC(v34, v33);
			//     Enumerator = System::Array::GetEnumerator(Values, 0LL);
			//     v66.klass = (Enum__Class *)&Enumerator;
			//     v66.monitor = (MonitorData *)&v65;
			//     v68 = 0LL;
			//     v69 = v66;
			//     while ( 1 )
			//     {
			//       if ( !Enumerator )
			//         sub_1802DC2C8(v36, v35);
			//       if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//         break;
			//       if ( !Enumerator )
			//         sub_1802DC2C8(v38, v37);
			//       v39 = sub_1800513A0(1LL, TypeInfo::System::Collections::IEnumerator, Enumerator);
			//       v40 = *(_DWORD *)sub_18004A160(v39);
			//       if ( !*oldFrameSettingsFormat )
			//         sub_1802DC2C8(v36, v35);
			//       if ( (v40 & (*oldFrameSettingsFormat).fields.overrides) > 0 )
			//       {
			//         if ( v40 <= 0x20000 )
			//         {
			//           if ( v40 <= 1024 )
			//           {
			//             switch ( v40 )
			//             {
			//               case 1:
			//                 v41 = newFrameSettingsOverrideMask.mask.data1 | 0x100000;
			//                 break;
			//               case 4:
			//                 v41 = newFrameSettingsOverrideMask.mask.data1 | 0x400000;
			//                 break;
			//               case 1024:
			//                 v41 = newFrameSettingsOverrideMask.mask.data1 | 0x40000000;
			//                 break;
			//               default:
			// LABEL_55:
			//                 v66.klass = (Enum__Class *)sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ObsoleteFrameSettingsOverrides);
			//                 v66.monitor = (MonitorData *)-1LL;
			//                 v67 = v40;
			//                 v42 = System::Enum::ToString(&v66, 0LL);
			//                 v43 = (String *)sub_18003C530(&off_18D50D2A0);
			//                 v44 = System::String::Concat(v43, v42, 0LL);
			//                 v45 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//                 v46 = (InvalidEnumArgumentException *)sub_180004920(v45);
			//                 v49 = v46;
			//                 if ( v46 )
			//                 {
			//                   System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v46, v44, 0LL);
			//                   v61 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings::MigrateFromClassVersion);
			//                   sub_18000F7C0(v49, v61);
			//                 }
			//                 sub_1802DC2C8(v48, v47);
			//             }
			//           }
			//           else
			//           {
			//             switch ( v40 )
			//             {
			//               case 0x2000:
			//                 v41 = newFrameSettingsOverrideMask.mask.data1 | 0x100;
			//                 break;
			//               case 0x4000:
			//                 v41 = newFrameSettingsOverrideMask.mask.data1 | 0x200;
			//                 break;
			//               case 0x20000:
			//                 v41 = newFrameSettingsOverrideMask.mask.data1 | 0x1000;
			//                 break;
			//               default:
			//                 goto LABEL_55;
			//             }
			//           }
			//         }
			//         else if ( v40 <= 0x200000 )
			//         {
			//           switch ( v40 )
			//           {
			//             case 0x40000:
			//               v41 = newFrameSettingsOverrideMask.mask.data1 | 0x2000;
			//               break;
			//             case 0x100000:
			//               v41 = newFrameSettingsOverrideMask.mask.data1 | 0x8000;
			//               break;
			//             case 0x200000:
			//               v41 = newFrameSettingsOverrideMask.mask.data1 | 1;
			//               break;
			//             default:
			//               goto LABEL_55;
			//           }
			//         }
			//         else
			//         {
			//           switch ( v40 )
			//           {
			//             case 0x400000:
			//               v41 = newFrameSettingsOverrideMask.mask.data1 | 2;
			//               break;
			//             case 0x1000000:
			//               v41 = newFrameSettingsOverrideMask.mask.data1 | 4;
			//               break;
			//             case 0x2000000:
			//               v41 = newFrameSettingsOverrideMask.mask.data1 | 8;
			//               break;
			//             default:
			//               goto LABEL_55;
			//           }
			//         }
			//         newFrameSettingsOverrideMask.mask.data1 = v41;
			//       }
			//     }
			//     sub_180B5A040(&v69);
			//     *oldFrameSettingsFormat = 0LL;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v50 = ((unsigned __int64)oldFrameSettingsFormat >> 12) & 0x1FFFFF;
			//       v51 = (unsigned __int64)v50 >> 6;
			//       v52 = v50 & 0x3F;
			//       _m_prefetchw(&qword_18D6870D0[v51]);
			//       do
			//         v53 = qword_18D6870D0[v51];
			//       while ( v53 != _InterlockedCompareExchange64(&qword_18D6870D0[v51], v53 | (1LL << v52), v53) );
			//     }
			//   }
			// }
			// 
		}

		internal static void MigrateToCustomPostprocessAndCustomPass(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToCustomPostprocessAndCustomPass(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToCustomPostprocessAndCustomPass(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3076, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3076, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToAfterPostprocess(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToAfterPostprocess(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToAfterPostprocess(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3077, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3077, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToDefaultReflectionSettings(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToDefaultReflectionSettings(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToDefaultReflectionSettings(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3078, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3078, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToNoReflectionRealtimeSettings(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToNoReflectionRealtimeSettings(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToNoReflectionRealtimeSettings(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3079, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3079, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToNoReflectionSettings(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToNoReflectionSettings(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToNoReflectionSettings(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3080, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3080, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToPostProcess(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToPostProcess(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToPostProcess(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3081, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3081, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(cameraFrameSettings, FrameSettingsField__Enum_Bloom, 1, 0LL);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(cameraFrameSettings, FrameSettingsField__Enum_Vignette, 1, 0LL);
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(
			//       cameraFrameSettings,
			//       FrameSettingsField__Enum_ColorGrading,
			//       1,
			//       0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToLensFlare(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToLensFlare(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToLensFlare(FrameSettings *cameraFrameSettings, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3082, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3082, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToDirectSpecularLighting(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToDirectSpecularLighting(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToDirectSpecularLighting(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3083, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3083, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToNoDirectSpecularLighting(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToNoDirectSpecularLighting(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToNoDirectSpecularLighting(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3084, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3084, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateToSeparateColorGradingAndTonemapping(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateToSeparateColorGradingAndTonemapping(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateToSeparateColorGradingAndTonemapping(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3085, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3085, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::FrameSettings::SetEnabled(cameraFrameSettings, FrameSettingsField__Enum_Tonemapping, 1, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateSubsurfaceParams(ref FrameSettings fs, bool previouslyHighQuality)
		{
			// // Void MigrateSubsurfaceParams(FrameSettings ByRef, Boolean)
			// void HG::Rendering::Runtime::FrameSettings::MigrateSubsurfaceParams(
			//         FrameSettings *fs,
			//         bool previouslyHighQuality,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3086, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3086, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1080(Patch, fs, previouslyHighQuality, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateRoughDistortion(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateRoughDistortion(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateRoughDistortion(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3087, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3087, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		internal static void MigrateVirtualTexturing(ref FrameSettings cameraFrameSettings)
		{
			// // Void MigrateVirtualTexturing(FrameSettings ByRef)
			// void HG::Rendering::Runtime::FrameSettings::MigrateVirtualTexturing(
			//         FrameSettings *cameraFrameSettings,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3088, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3088, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1079(Patch, cameraFrameSettings, 0LL);
			//   }
			// }
			// 
		}

		public bool <>iFixBaseProxy_Equals(object P0)
		{
			// // Boolean <>iFixBaseProxy_Equals(Object)
			// bool HG::Rendering::Runtime::FrameSettings::__iFixBaseProxy_Equals(FrameSettings *this, Object *P0, MethodInfo *method)
			// {
			//   __int64 v5; // xmm1_8
			//   Object *v6; // rax
			//   BitArray128 bitDatas; // [rsp+20h] [rbp-28h] BYREF
			//   __int64 v9; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D919671 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings);
			//     byte_18D919671 = 1;
			//   }
			//   v5 = *(_QWORD *)&this.materialQuality;
			//   bitDatas = this.bitDatas;
			//   v9 = v5;
			//   v6 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::FrameSettings, &bitDatas, method);
			//   return System::ValueType::DefaultEquals(v6, P0, 0LL);
			// }
			// 
			return default(bool);
		}

		public int <>iFixBaseProxy_GetHashCode()
		{
			// // Int32 <>iFixBaseProxy_GetHashCode()
			// int32_t HG::Rendering::Runtime::FrameSettings::__iFixBaseProxy_GetHashCode(FrameSettings *this, MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int64 v4; // xmm1_8
			//   ValueType *v5; // rax
			//   BitArray128 bitDatas; // [rsp+20h] [rbp-28h] BYREF
			//   __int64 v8; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D919672 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings);
			//     byte_18D919672 = 1;
			//   }
			//   v4 = *(_QWORD *)&this.materialQuality;
			//   bitDatas = this.bitDatas;
			//   v8 = v4;
			//   v5 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::FrameSettings, &bitDatas, v2);
			//   return System::ValueType::GetHashCode(v5, 0LL);
			// }
			// 
			return 0;
		}

		[SerializeField]
		private BitArray128 bitDatas;

		public MaterialQuality materialQuality;

		[DebuggerDisplay("{m_Value}", Name = "{m_Label,nq}")]
		internal class DebuggerEntry
		{
			public DebuggerEntry(string label, object value)
			{
			}

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string m_Label;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private object m_Value;
		}

		[DebuggerDisplay("", Name = "{m_GroupName,nq}")]
		internal class DebuggerGroup
		{
			public DebuggerGroup(string groupName, FrameSettings.DebuggerEntry[] entries)
			{
			}

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string m_GroupName;

			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public FrameSettings.DebuggerEntry[] m_Entries;
		}

		internal class FrameSettingsDebugView
		{
			// (get) Token: 0x06001312 RID: 4882 RVA: 0x000025D2 File Offset: 0x000007D2
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public FrameSettings.DebuggerGroup[] Keys
			{
				get
				{
					// // FrameSettings+DebuggerGroup[] get_Keys()
					// // Hidden C++ exception states: #wind=7
					// FrameSettings_DebuggerGroup__Array *HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::get_Keys(
					//         FrameSettings_FrameSettingsDebugView *this,
					//         MethodInfo *method)
					// {
					//   struct Il2CppType *v3; // rbx
					//   Type *TypeFromHandle; // rbx
					//   Array *Values; // rax
					//   __int64 v6; // rdx
					//   __int64 v7; // rcx
					//   Dictionary_2_System_Int32Enum_System_Object_ *v8; // rax
					//   __int64 v9; // rdx
					//   __int64 v10; // rcx
					//   Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *v11; // r14
					//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v12; // rax
					//   __int64 v13; // rdx
					//   __int64 v14; // rcx
					//   IObservable_1_Object_ *v15; // r13
					//   Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *EnumNameMap; // rsi
					//   Type *v17; // r12
					//   IEnumerable_1_System_Int32Enum_ *v18; // rax
					//   __int64 v19; // rdx
					//   __int64 v20; // rcx
					//   Func_2_Object_Boolean_ *v21; // r15
					//   __int64 v22; // rdx
					//   __int64 v23; // rcx
					//   Dictionary_2_TKey_TValue_ValueCollection_System_UInt64_System_Int32_ *Keys; // rax
					//   __int64 v25; // rdx
					//   __int64 v26; // rcx
					//   __int64 *v27; // rdx
					//   Func_2_Object_Boolean_ *v28; // rcx
					//   unsigned int currentKey; // ebx
					//   Object *Item; // rax
					//   __int64 v31; // rdx
					//   __int64 v32; // rcx
					//   MemberInfo_1 *v33; // rax
					//   Object *v34; // rax
					//   __int64 v35; // rdx
					//   __int64 v36; // rcx
					//   __int64 v37; // rdx
					//   __int64 v38; // rcx
					//   IEnumerable_1_System_Object_ *v39; // r15
					//   Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Boolean_ *_9__4_0; // rbx
					//   Object *v41; // rsi
					//   Func_2_Object_Boolean_ *v42; // rax
					//   unsigned __int64 v43; // r8
					//   unsigned __int64 v44; // rdx
					//   signed __int64 v45; // rtt
					//   IEnumerable_1_System_Object_ *v46; // r12
					//   Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *_9__4_1; // rbx
					//   Object *v48; // r15
					//   Func_2_Object_Int32_ *v49; // rax
					//   unsigned __int64 v50; // r9
					//   unsigned __int64 v51; // r8
					//   signed __int64 v52; // rtt
					//   IEnumerable_1_System_Int32_ *v53; // rax
					//   IEnumerable_1_System_Int32_ *v54; // rax
					//   __int64 v55; // rdx
					//   __int64 v56; // rcx
					//   __int64 v57; // rdx
					//   __int64 v58; // rcx
					//   __int64 v59; // rbx
					//   __int64 v60; // rdx
					//   __int64 v61; // r8
					//   __int64 v62; // r9
					//   String__Array *foldoutNames; // rax
					//   __int64 v64; // rcx
					//   Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *v65; // rax
					//   __int64 v66; // rdx
					//   __int64 v67; // rcx
					//   Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *_9__4_5; // rbx
					//   Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *v69; // rax
					//   __int64 v70; // rdx
					//   __int64 v71; // rcx
					//   unsigned __int64 v72; // r9
					//   unsigned __int64 v73; // r8
					//   signed __int64 v74; // rtt
					//   Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *v75; // rax
					//   __int64 v76; // rdx
					//   __int64 v77; // rcx
					//   Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *v78; // rbx
					//   IEnumerable_1_System_Object_ *v79; // rax
					//   struct FrameSettings_DebuggerGroup__Class *element_class; // rbx
					//   __int64 v81; // rax
					//   __int64 v82; // rdx
					//   __int64 instance_size; // rcx
					//   WhereObservable_1_System_Object_ *v84; // r15
					//   __int64 v85; // rdx
					//   __int64 v86; // rcx
					//   __int64 v87; // rdx
					//   __int64 v88; // rcx
					//   Func_2_HG_Rendering_Runtime_FrameSettingsField_Boolean_ *_9__4_2; // r14
					//   struct Func_2_HG_Rendering_Runtime_FrameSettingsField_Boolean___Class *v90; // rbx
					//   __int64 v91; // rax
					//   __int64 v92; // rdx
					//   __int64 v93; // rcx
					//   unsigned __int64 v94; // r9
					//   unsigned __int64 v95; // r8
					//   signed __int64 v96; // rtt
					//   struct Func_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettings_DebuggerEntry___Class *v97; // rbx
					//   struct Func_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettings_DebuggerEntry___Class **v98; // rax
					//   __int64 v99; // rdx
					//   __int64 v100; // rcx
					//   __int64 v101; // rdx
					//   GenericDelegateCallerGen_int_FStructSize8Delegate_2_System_Int32_Beyond_Reflection_StructSizeGen_FStructSize8_ *v102; // r14
					//   IEnumerable_1_System_Object_ *v103; // rax
					//   struct FrameSettings_DebuggerGroup__Class *v104; // rbx
					//   __int64 v105; // rcx
					//   __int64 v106; // rdx
					//   struct FrameSettings_DebuggerGroup__Class **v107; // rax
					//   __int64 v108; // rdx
					//   WhereObservable_1_System_Object_ *v109; // r14
					//   char *v110; // rcx
					//   __int64 v111; // r8
					//   char *v112; // rax
					//   unsigned __int64 v113; // r8
					//   __int64 v114; // rax
					//   __int64 v115; // r8
					//   __int64 v116; // r9
					//   __int64 v117; // rbx
					//   __int64 v118; // r8
					//   Func_2_Object_Boolean_ *v119; // r15
					//   WhereObservable_1_System_Object_ *v120; // rax
					//   WhereObservable_1_System_Object_ *v121; // r14
					//   __int64 v122; // rdx
					//   __int64 v123; // rcx
					//   __int64 v124; // r8
					//   __int64 v125; // r9
					//   unsigned __int64 v126; // r8
					//   signed __int64 v127; // rtt
					//   WhereObservable_1_System_Object_ *v128; // rax
					//   Object *v129; // rsi
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v132; // rdx
					//   __int64 v133; // rcx
					//   __int64 v134; // [rsp+0h] [rbp-E8h] BYREF
					//   __int64 (__fastcall *v135)(_QWORD, _QWORD); // [rsp+28h] [rbp-C0h]
					//   Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *predicate; // [rsp+30h] [rbp-B8h]
					//   Func_2_Object_Boolean_ *v137; // [rsp+38h] [rbp-B0h] BYREF
					//   IObservable_1_Object_ *v138; // [rsp+40h] [rbp-A8h]
					//   IObservable_1_Object_ *v139; // [rsp+48h] [rbp-A0h]
					//   IEnumerable_1_KeyValuePair_2_System_Int32Enum_System_Object_ *source; // [rsp+50h] [rbp-98h] BYREF
					//   char v141[8]; // [rsp+58h] [rbp-90h] BYREF
					//   Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v142; // [rsp+60h] [rbp-88h] BYREF
					//   char v143[8]; // [rsp+78h] [rbp-70h] BYREF
					//   Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v144; // [rsp+80h] [rbp-68h] BYREF
					//   Il2CppExceptionWrapper *v145; // [rsp+98h] [rbp-50h] BYREF
					//   Il2CppExceptionWrapper *v146; // [rsp+A0h] [rbp-48h] BYREF
					//   IEnumerable_1_System_Int32Enum_ *v148; // [rsp+100h] [rbp+18h] BYREF
					//   __int64 v149; // [rsp+108h] [rbp+20h] BYREF
					// 
					//   if ( !byte_18D919673 )
					//   {
					//     sub_18003C530(&MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerEntry);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerEntry);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::Dictionary);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Item);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Item);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Keys);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Values);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::set_Item);
					//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
					//     sub_18003C530(&TypeInfo::System::Enum);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Distinct<int>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::FrameSettingsFieldAttribute,int>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Where<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Where<HG::Rendering::Runtime::FrameSettingsField>);
					//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<HG::Rendering::Runtime::FrameSettingsField,System::String>::Dispose);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<HG::Rendering::Runtime::FrameSettingsField,System::String>::MoveNext);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Current);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::_get_Keys_b__4_3);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::_get_Keys_b__4_6);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
					//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::FrameSettingsField);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
					//     sub_18003C530(&TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//     sub_18003C530(&TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
					//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,bool>);
					//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsFieldAttribute,bool>);
					//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsFieldAttribute,int>);
					//     sub_18003C530(&TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,bool>);
					//     sub_18003C530(&TypeInfo::System::IDisposable);
					//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerable<int>);
					//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<int>);
					//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<HG::Rendering::Runtime::FrameSettingsField,System::String>::GetEnumerator);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>::Add);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::Add);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::ToArray);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>::List);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::List);
					//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>);
					//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>);
					//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MaterialQuality);
					//     sub_18003C530(&TypeInfo::System::Type);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_0);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_1);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_2);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_5);
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c__DisplayClass4_0::_get_Keys_b__4);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c__DisplayClass4_0);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//     sub_18003C530(&off_18D50D798);
					//     sub_18003C530(&off_18D50D7A0);
					//     sub_18003C530(&off_18D50D7A8);
					//     byte_18D919673 = 1;
					//   }
					//   v149 = 0LL;
					//   if ( !IFix::WrappersManagerImpl::IsPatched(3089, 0LL) )
					//   {
					//     v3 = TypeRef::HG::Rendering::Runtime::FrameSettingsField;
					//     sub_180002C70(TypeInfo::System::Type);
					//     TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v3, 0LL);
					//     sub_180002C70(TypeInfo::System::Enum);
					//     Values = System::Enum::GetValues(TypeFromHandle, 0LL);
					//     if ( !Values )
					//       sub_180B536AC(v7, v6);
					//     System::Array::get_Length(Values, 0LL);
					//     v8 = (Dictionary_2_System_Int32Enum_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
					//     v11 = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)v8;
					//     if ( !v8 )
					//       sub_180B536AC(v10, v9);
					//     System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Dictionary(
					//       v8,
					//       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::Dictionary);
					//     predicate = v11;
					//     v12 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>);
					//     v15 = (IObservable_1_Object_ *)v12;
					//     if ( !v12 )
					//       sub_180B536AC(v14, v13);
					//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
					//       v12,
					//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::List);
					//     v139 = v15;
					//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
					//     EnumNameMap = HG::Rendering::Runtime::FrameSettingsFieldAttribute::GetEnumNameMap(0LL);
					//     v17 = System::Type::GetTypeFromHandle((RuntimeTypeHandle)TypeRef::HG::Rendering::Runtime::FrameSettingsField, 0LL);
					//     v18 = (IEnumerable_1_System_Int32Enum_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>);
					//     v21 = (Func_2_Object_Boolean_ *)v18;
					//     v148 = v18;
					//     if ( !v18 )
					//       sub_180B536AC(v20, v19);
					//     System::Collections::Generic::List<unsigned long>::List(
					//       (List_1_System_UInt64_ *)v18,
					//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>::List);
					//     v137 = v21;
					//     if ( !EnumNameMap )
					//       sub_180B536AC(v23, v22);
					//     Keys = (Dictionary_2_TKey_TValue_ValueCollection_System_UInt64_System_Int32_ *)System::Collections::Generic::Dictionary<UnityEngine::InputSystem::Utilities::InternedString,UnityEngine::InputSystem::Layouts::InputControlLayout_Collection::PrecompiledLayout>::get_Keys(
					//                                                                                      (Dictionary_2_UnityEngine_InputSystem_Utilities_InternedString_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_PrecompiledLayout_ *)EnumNameMap,
					//                                                                                      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Keys);
					//     if ( !Keys )
					//       sub_180B536AC(v26, v25);
					//     System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<unsigned long,int>::GetEnumerator(
					//       (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_System_UInt64_System_Int32_ *)&v142,
					//       Keys,
					//       MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<HG::Rendering::Runtime::FrameSettingsField,System::String>::GetEnumerator);
					//     v144 = v142;
					//     v142._dictionary = 0LL;
					//     *(_QWORD *)&v142._index = &v144;
					//     try
					//     {
					//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
					//                 &v144,
					//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<HG::Rendering::Runtime::FrameSettingsField,System::String>::MoveNext) )
					//       {
					//         currentKey = v144._currentKey;
					//         Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
					//                  (Dictionary_2_System_Int32Enum_System_Object_ *)EnumNameMap,
					//                  (Int32Enum__Enum)v144._currentKey,
					//                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Item);
					//         if ( !v17 )
					//           sub_1802DC2C8(v32, v31);
					//         v33 = (MemberInfo_1 *)sub_180055F60(v32, v17, Item, 28LL);
					//         v34 = System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::Object>(
					//                 v33,
					//                 MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
					//         if ( !v11 )
					//           sub_1802DC2C8(v36, v35);
					//         System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::set_Item(
					//           (Dictionary_2_System_Int32Enum_System_Object_ *)v11,
					//           (Int32Enum__Enum)currentKey,
					//           v34,
					//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::set_Item);
					//         if ( !System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
					//                 (Dictionary_2_System_Int32Enum_System_Object_ *)v11,
					//                 (Int32Enum__Enum)currentKey,
					//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Item) )
					//         {
					//           if ( !v21 )
					//             sub_1802DC2C8(v38, v37);
					//           sub_1826AA8C0((List_1_System_UInt32_ *)v21, currentKey);
					//         }
					//       }
					//     }
					//     catch ( Il2CppExceptionWrapper *v145 )
					//     {
					//       v27 = &v134;
					//       v142._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v145.ex;
					//       if ( v142._dictionary )
					//         sub_18000F780(v142._dictionary);
					//       v11 = predicate;
					//       v15 = v139;
					//       v28 = v137;
					//       v148 = (IEnumerable_1_System_Int32Enum_ *)v137;
					//     }
					//     if ( v11 )
					//     {
					//       v39 = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Values(
					//                                               (Dictionary_2_System_UInt64_System_Object_ *)v11,
					//                                               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Values);
					//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//       _9__4_0 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_0;
					//       if ( !_9__4_0 )
					//       {
					//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//         v41 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9;
					//         v42 = (Func_2_Object_Boolean_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsFieldAttribute,bool>);
					//         _9__4_0 = (Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Boolean_ *)v42;
					//         if ( !v42 )
					//           goto LABEL_163;
					//         System::Func<System::Object,bool>::Func(
					//           v42,
					//           v41,
					//           MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_0,
					//           0LL);
					//         TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_0 = _9__4_0;
					//         if ( dword_18D8E43F8 )
					//         {
					//           v43 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_0 >> 12) & 0x1FFFFF) >> 6;
					//           v44 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_0 >> 12) & 0x3F;
					//           _m_prefetchw(&qword_18D6405E0[v43 + 36190]);
					//           do
					//             v45 = qword_18D6405E0[v43 + 36190];
					//           while ( v45 != _InterlockedCompareExchange64(&qword_18D6405E0[v43 + 36190], v45 | (1LL << v44), v45) );
					//         }
					//       }
					//       v46 = System::Linq::Enumerable::Where<System::Object>(
					//               v39,
					//               (Func_2_Object_Boolean_ *)_9__4_0,
					//               MethodInfo::System::Linq::Enumerable::Where<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
					//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//       _9__4_1 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_1;
					//       if ( !_9__4_1 )
					//       {
					//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//         v48 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9;
					//         v49 = (Func_2_Object_Int32_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsFieldAttribute,int>);
					//         _9__4_1 = (Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *)v49;
					//         if ( !v49 )
					//           goto LABEL_163;
					//         System::Func<System::Object,int>::Func(
					//           v49,
					//           v48,
					//           MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_1,
					//           0LL);
					//         TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_1 = _9__4_1;
					//         if ( dword_18D8E43F8 )
					//         {
					//           v50 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_1 >> 12) & 0x1FFFFF) >> 6;
					//           v51 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_1 >> 12) & 0x3F;
					//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
					//           do
					//             v52 = qword_18D6405E0[v50 + 36190];
					//           while ( v52 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v52 | (1LL << v51), v52) );
					//         }
					//       }
					//       v53 = (IEnumerable_1_System_Int32_ *)System::Linq::Enumerable::Select<UnityEngine::RaycastHit2D,float>(
					//                                              (IEnumerable_1_UnityEngine_RaycastHit2D_ *)v46,
					//                                              (Func_2_UnityEngine_RaycastHit2D_Single_ *)_9__4_1,
					//                                              MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::FrameSettingsFieldAttribute,int>);
					//       v54 = System::Linq::Enumerable::Distinct<int>(v53, MethodInfo::System::Linq::Enumerable::Distinct<int>);
					//       if ( v54 )
					//       {
					//         v149 = sub_1800513A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<int>, v54);
					//         v142._dictionary = 0LL;
					//         *(_QWORD *)&v142._index = &v149;
					//         try
					//         {
					//           while ( 1 )
					//           {
					//             if ( !v149 )
					//               sub_1802DC2C8(v56, v55);
					//             if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
					//               goto LABEL_172;
					//             v59 = sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c__DisplayClass4_0);
					//             if ( !v59 )
					//               sub_1802DC2C8(v58, v57);
					//             if ( !v149 )
					//               sub_1802DC2C8(v58, v57);
					//             *(_DWORD *)(v59 + 16) = sub_1800432D0(0LL, TypeInfo::System::Collections::Generic::IEnumerator<int>, v149);
					//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
					//             foldoutNames = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory.static_fields.foldoutNames;
					//             v64 = *(int *)(v59 + 16);
					//             if ( !foldoutNames )
					//               sub_1802DC2C8(v64, v60);
					//             if ( (unsigned int)v64 >= foldoutNames.max_length.size )
					//               sub_180070260(v64, v60, v61, v62);
					//             v138 = (IObservable_1_Object_ *)foldoutNames.vector[v64];
					//             v65 = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)sub_180004920(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,bool>);
					//             predicate = v65;
					//             if ( !v65 )
					//               sub_1802DC2C8(v67, v66);
					//             System::Predicate<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile>::Predicate(
					//               (Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)v65,
					//               (Object *)v59,
					//               MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c__DisplayClass4_0::_get_Keys_b__4,
					//               0LL);
					//             source = (IEnumerable_1_KeyValuePair_2_System_Int32Enum_System_Object_ *)System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>(
					//                                                                                        (IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *)v11,
					//                                                                                        predicate,
					//                                                                                        MethodInfo::System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
					//             if ( source )
					//             {
					//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//               _9__4_5 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_5;
					//               if ( !_9__4_5 )
					//               {
					//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//                 predicate = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9;
					//                 v69 = (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *)sub_180004920(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
					//                 _9__4_5 = (Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *)v69;
					//                 if ( !v69 )
					//                   sub_1802DC2C8(v71, v70);
					//                 System::Func<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Int32Enum>::Func(
					//                   v69,
					//                   (Object *)predicate,
					//                   MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_5,
					//                   0LL);
					//                 TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_5 = _9__4_5;
					//                 if ( dword_18D8E43F8 )
					//                 {
					//                   v72 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_5 >> 12) & 0x1FFFFF) >> 6;
					//                   v73 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_5 >> 12) & 0x3F;
					//                   _m_prefetchw(&qword_18D6405E0[v72 + 36190]);
					//                   do
					//                     v74 = qword_18D6405E0[v72 + 36190];
					//                   while ( v74 != _InterlockedCompareExchange64(&qword_18D6405E0[v72 + 36190], v74 | (1LL << v73), v74) );
					//                 }
					//               }
					//               predicate = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<System::Int32Enum,System::Object>,int>(source, (Func_2_System_Collections_Generic_KeyValuePair_2_System_Int32Enum_System_Object_Int32_ *)_9__4_5, MethodInfo::System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
					//               v75 = (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *)sub_180004920(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//               v78 = v75;
					//               if ( !v75 )
					//                 sub_1802DC2C8(v77, v76);
					//               System::Func<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Object>::Func(
					//                 v75,
					//                 (Object *)this,
					//                 MethodInfo::HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::_get_Keys_b__4_6,
					//                 0LL);
					//               v79 = System::Linq::Enumerable::Select<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Object>(
					//                       (IEnumerable_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)predicate,
					//                       v78,
					//                       MethodInfo::System::Linq::Enumerable::Select<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//               predicate = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)System::Linq::Enumerable::ToArray<System::Object>(v79, MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//             }
					//             else
					//             {
					//               predicate = 0LL;
					//             }
					//             element_class = TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup;
					//             if ( ((__int64)TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup.vtable.Equals.methodPtr & 2) == 0 )
					//             {
					//               source = (IEnumerable_1_KeyValuePair_2_System_Int32Enum_System_Object_ *)&qword_18CDB0B30;
					//               sub_1802924D0(&qword_18CDB0B30);
					//               sub_180060090(element_class, &source);
					//               sub_180292530(source);
					//             }
					//             if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
					//               element_class = (struct FrameSettings_DebuggerGroup__Class *)element_class._0.element_class;
					//             if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) == 0 )
					//               break;
					//             instance_size = element_class._1.instance_size;
					//             if ( element_class._0.gc_desc )
					//             {
					//               v81 = sub_180004F80(instance_size, element_class);
					//               goto LABEL_57;
					//             }
					//             v84 = (WhereObservable_1_System_Object_ *)sub_180005D40(instance_size, element_class);
					// LABEL_59:
					//             if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
					//             {
					//               v135 = mono_thread_suspend_all_other_threads;
					//               sub_18002E8C0((_DWORD)v84, (unsigned int)sub_18007DC30, 0, (unsigned int)v141, (__int64)v143);
					//             }
					//             if ( (dword_18D8F6F50 & 0x80u) != 0 )
					//               sub_1802DAEC4(v84, element_class);
					//             il2cpp_runtime_class_init_0(element_class, v82);
					//             if ( !v84 )
					//               sub_1802DC2C8(v86, v85);
					//             UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
					//               v84,
					//               v138,
					//               (Func_2_Object_Boolean_ *)predicate,
					//               0LL);
					//             if ( !v15 )
					//               sub_1802DC2C8(v88, v87);
					//             sub_1822AD140((List_1_System_Object_ *)v15, (Object *)v84);
					//           }
					//           v81 = sub_180005FB0(element_class);
					// LABEL_57:
					//           v84 = (WhereObservable_1_System_Object_ *)v81;
					//           goto LABEL_59;
					//         }
					//         catch ( Il2CppExceptionWrapper *v146 )
					//         {
					//           v142._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v146.ex;
					//           sub_1801E4D90(&v142);
					//           v15 = v139;
					//           v148 = (IEnumerable_1_System_Int32Enum_ *)v137;
					//           goto LABEL_67;
					//         }
					// LABEL_172:
					//         sub_1801E4D90(&v142);
					// LABEL_67:
					//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//         _9__4_2 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_2;
					//         v139 = (IObservable_1_Object_ *)"Bits without attribute";
					//         if ( !_9__4_2 )
					//         {
					//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
					//           v138 = (IObservable_1_Object_ *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9;
					//           v90 = TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,bool>;
					//           if ( ((__int64)TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,bool>.vtable.Equals.methodPtr & 2) == 0 )
					//           {
					//             v137 = (Func_2_Object_Boolean_ *)&qword_18CDB0B30;
					//             sub_1802924D0(&qword_18CDB0B30);
					//             sub_180060090(v90, &v137);
					//             sub_180292530(v137);
					//           }
					//           if ( v90._0.generic_class && ((__int64)v90.vtable.Equals.methodPtr & 8) != 0 )
					//             v90 = (struct Func_2_HG_Rendering_Runtime_FrameSettingsField_Boolean___Class *)v90._0.element_class;
					//           if ( ((__int64)v90.vtable.Equals.methodPtr & 0x20) != 0 )
					//           {
					//             v93 = v90._1.instance_size;
					//             if ( v90._0.gc_desc )
					//             {
					//               v91 = sub_180005220(v93, v90);
					//               _InterlockedIncrement64(&qword_18D8E51F8);
					//             }
					//             else
					//             {
					//               v91 = sub_180005D40(v93, v90);
					//             }
					//           }
					//           else
					//           {
					//             v91 = sub_180005FB0(v90);
					//           }
					//           _9__4_2 = (Func_2_HG_Rendering_Runtime_FrameSettingsField_Boolean_ *)v91;
					//           if ( (BYTE1(v90.vtable.Equals.methodPtr) & 2) != 0 )
					//           {
					//             v135 = mono_thread_suspend_all_other_threads;
					//             sub_18002E8C0(v91, (unsigned int)sub_18007DC30, 0, (unsigned int)v143, (__int64)v141);
					//           }
					//           if ( (dword_18D8F6F50 & 0x80u) != 0 )
					//             sub_1802DAEC4(_9__4_2, v90);
					//           il2cpp_runtime_class_init_0(v90, v92);
					//           if ( !_9__4_2 )
					//             goto LABEL_163;
					//           System::Predicate<int>::Predicate(
					//             (Predicate_1_Int32_ *)_9__4_2,
					//             (Object *)v138,
					//             MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_2,
					//             0LL);
					//           TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_2 = _9__4_2;
					//           if ( dword_18D8E43F8 )
					//           {
					//             v94 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_2 >> 12) & 0x1FFFFF) >> 6;
					//             v95 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c.static_fields.__9__4_2 >> 12) & 0x3F;
					//             _m_prefetchw(&qword_18D6405E0[v94 + 36190]);
					//             do
					//               v96 = qword_18D6405E0[v94 + 36190];
					//             while ( v96 != _InterlockedCompareExchange64(&qword_18D6405E0[v94 + 36190], v96 | (1LL << v95), v96) );
					//           }
					//         }
					//         v138 = (IObservable_1_Object_ *)System::Linq::Enumerable::Where<System::Int32Enum>(
					//                                           v148,
					//                                           (Func_2_Int32Enum_Boolean_ *)_9__4_2,
					//                                           MethodInfo::System::Linq::Enumerable::Where<HG::Rendering::Runtime::FrameSettingsField>);
					//         if ( v138 )
					//         {
					//           v97 = TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>;
					//           if ( ((__int64)TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>.vtable.Equals.methodPtr & 2) == 0 )
					//           {
					//             v148 = (IEnumerable_1_System_Int32Enum_ *)&qword_18CDB0B30;
					//             sub_1802924D0(&qword_18CDB0B30);
					//             sub_180060090(v97, &v148);
					//             sub_180292530(v148);
					//           }
					//           if ( v97._0.generic_class && ((__int64)v97.vtable.Equals.methodPtr & 8) != 0 )
					//             v97 = (struct Func_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettings_DebuggerEntry___Class *)v97._0.element_class;
					//           if ( ((__int64)v97.vtable.Equals.methodPtr & 0x20) != 0 )
					//           {
					//             v100 = v97._1.instance_size;
					//             if ( v97._0.gc_desc )
					//             {
					//               v98 = (struct Func_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettings_DebuggerEntry___Class **)sub_180005220(v100, v97);
					//             }
					//             else
					//             {
					//               v101 = 1LL;
					//               if ( dword_18D8E43FC == 1 )
					//                 v101 = 4LL;
					//               v98 = (struct Func_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettings_DebuggerEntry___Class **)sub_18002D3D0(v100, v101);
					//               *v98 = v97;
					//             }
					//             _InterlockedIncrement64(&qword_18D8E51F8);
					//           }
					//           else
					//           {
					//             v98 = (struct Func_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettings_DebuggerEntry___Class **)sub_180005FB0(v97);
					//           }
					//           v102 = (GenericDelegateCallerGen_int_FStructSize8Delegate_2_System_Int32_Beyond_Reflection_StructSizeGen_FStructSize8_ *)v98;
					//           if ( (BYTE1(v97.vtable.Equals.methodPtr) & 2) != 0 )
					//           {
					//             v135 = mono_thread_suspend_all_other_threads;
					//             sub_18002E8C0((_DWORD)v98, (unsigned int)sub_18007DC30, 0, (unsigned int)v141, (__int64)&v148);
					//           }
					//           if ( (dword_18D8F6F50 & 0x80u) != 0 )
					//             sub_1802DAEC4(v102, v97);
					//           il2cpp_runtime_class_init_0(v97, v99);
					//           if ( !v102 )
					//             goto LABEL_163;
					//           Beyond::Reflection::GenericDelegateCallerGen::int_FStructSize8Delegate<int,Beyond::Reflection::StructSizeGen::FStructSize8>::int_FStructSize8Delegate(
					//             v102,
					//             (Object *)this,
					//             MethodInfo::HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::_get_Keys_b__4_3,
					//             0LL);
					//           v103 = System::Linq::Enumerable::Select<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Object>(
					//                    (IEnumerable_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)v138,
					//                    (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *)v102,
					//                    MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//           v137 = (Func_2_Object_Boolean_ *)System::Linq::Enumerable::ToArray<System::Object>(
					//                                              v103,
					//                                              MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
					//         }
					//         else
					//         {
					//           v137 = 0LL;
					//         }
					//         v104 = TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup;
					//         if ( ((__int64)TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup.vtable.Equals.methodPtr & 2) == 0 )
					//         {
					//           v148 = (IEnumerable_1_System_Int32Enum_ *)&qword_18CDB0B30;
					//           sub_1802924D0(&qword_18CDB0B30);
					//           sub_180060090(v104, &v148);
					//           sub_180292530(v148);
					//         }
					//         if ( v104._0.generic_class && ((__int64)v104.vtable.Equals.methodPtr & 8) != 0 )
					//           v104 = (struct FrameSettings_DebuggerGroup__Class *)v104._0.element_class;
					//         v105 = v104._1.instance_size;
					//         if ( ((__int64)v104.vtable.Equals.methodPtr & 0x20) != 0 )
					//         {
					//           if ( v104._0.gc_desc )
					//             v114 = sub_180004F80(v105, v104);
					//           else
					//             v114 = sub_180005D40(v105, v104);
					//           v109 = (WhereObservable_1_System_Object_ *)v114;
					//         }
					//         else
					//         {
					//           v106 = 0LL;
					//           if ( dword_18D8E43FC == 1 )
					//             v106 = 3LL;
					//           v107 = (struct FrameSettings_DebuggerGroup__Class **)sub_18002D3D0(v105, v106);
					//           v109 = (WhereObservable_1_System_Object_ *)v107;
					//           *v107 = v104;
					//           v107[1] = 0LL;
					//           v110 = (char *)(v107 + 2);
					//           v111 = v104._1.instance_size;
					//           if ( v104._1.instance_size >= 0x80 )
					//           {
					//             sub_1802F01E0(v110, 0LL, v111 - 16);
					//           }
					//           else
					//           {
					//             v112 = (char *)v107 + v111;
					//             v113 = (unsigned __int64)(v112 - v110 + 7) >> 3;
					//             if ( v110 > v112 )
					//               v113 = 0LL;
					//             if ( v113 )
					//               sub_1802F01E0(v110, 0LL, 8 * v113);
					//           }
					//           _InterlockedIncrement64(&qword_18D8E51F8);
					//         }
					//         if ( (BYTE1(v104.vtable.Equals.methodPtr) & 2) != 0 )
					//         {
					//           v135 = mono_thread_suspend_all_other_threads;
					//           sub_18002E8C0((_DWORD)v109, (unsigned int)sub_18007DC30, 0, (unsigned int)v141, (__int64)&v148);
					//         }
					//         if ( (dword_18D8F6F50 & 0x80u) != 0 )
					//           sub_1802DAEC4(v109, v104);
					//         il2cpp_runtime_class_init_0(v104, v108);
					//         if ( v109 )
					//         {
					//           UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(v109, v139, v137, 0LL);
					//           if ( v15 )
					//           {
					//             sub_1822AD140((List_1_System_Object_ *)v15, (Object *)v109);
					//             v117 = il2cpp_array_new_specific_0(
					//                      TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerEntry,
					//                      1LL,
					//                      v115,
					//                      v116);
					//             LODWORD(v148) = this.fields.m_FrameSettings.materialQuality;
					//             v119 = (Func_2_Object_Boolean_ *)il2cpp_value_box_0(
					//                                                TypeInfo::UnityEngine::Rendering::MaterialQuality,
					//                                                &v148,
					//                                                v118);
					//             v120 = (WhereObservable_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerEntry);
					//             v121 = v120;
					//             if ( v120 )
					//             {
					//               UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
					//                 v120,
					//                 (IObservable_1_Object_ *)"materialQuality",
					//                 v119,
					//                 0LL);
					//               if ( v117 )
					//               {
					//                 sub_180036D40(v117, v121);
					//                 if ( !*(_DWORD *)(v117 + 24) )
					//                   sub_180070260(v123, v122, v124, v125);
					//                 *(_QWORD *)(v117 + 32) = v121;
					//                 if ( dword_18D8E43F8 )
					//                 {
					//                   v126 = (((unsigned __int64)(v117 + 32) >> 12) & 0x1FFFFF) >> 6;
					//                   _m_prefetchw(&qword_18D6405E0[v126 + 36190]);
					//                   do
					//                     v127 = qword_18D6405E0[v126 + 36190];
					//                   while ( v127 != _InterlockedCompareExchange64(
					//                                     &qword_18D6405E0[v126 + 36190],
					//                                     v127 | (1LL << (((unsigned __int64)(v117 + 32) >> 12) & 0x3F)),
					//                                     v127) );
					//                 }
					//                 v128 = (WhereObservable_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup);
					//                 v129 = (Object *)v128;
					//                 if ( v128 )
					//                 {
					//                   UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
					//                     v128,
					//                     (IObservable_1_Object_ *)"Non Bit data",
					//                     (Func_2_Object_Boolean_ *)v117,
					//                     0LL);
					//                   sub_1822AD140((List_1_System_Object_ *)v15, v129);
					//                   return (FrameSettings_DebuggerGroup__Array *)System::Collections::Generic::List<System::Object>::ToArray(
					//                                                                  (List_1_System_Object_ *)v15,
					//                                                                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::ToArray);
					//                 }
					//               }
					//             }
					//           }
					//         }
					//       }
					//     }
					// LABEL_163:
					//     sub_1802DC2C8(v28, v27);
					//   }
					//   Patch = IFix::WrappersManagerImpl::GetPatch(3089, 0LL);
					//   if ( !Patch )
					//     sub_180B536AC(v133, v132);
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1088(Patch, (Object *)this, 0LL);
					// }
					// 
					return null;
				}
			}

			public FrameSettingsDebugView(FrameSettings frameSettings)
			{
				// // Void set_value(Ray)
				// void ParadoxNotion::EventData<UnityEngine::Ray>::set_value(
				//         EventData_1_UnityEngine_Ray_ *this,
				//         Ray *value,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // xmm1_8
				// 
				//   v3 = *(_QWORD *)&value.m_Direction.y;
				//   *(_OWORD *)&this._value_k__BackingField.m_Origin.x = *(_OWORD *)&value.m_Origin.x;
				//   *(_QWORD *)&this._value_k__BackingField.m_Direction.y = v3;
				// }
				// 
			}

			private const int numberOfNonBitValues = 2;

			private FrameSettings m_FrameSettings;
		}
	}
}
