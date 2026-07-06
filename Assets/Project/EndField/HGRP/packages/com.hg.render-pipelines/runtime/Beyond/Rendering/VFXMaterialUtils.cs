using System;
using IFix.Core;
using UnityEngine;

namespace Beyond.Rendering
{
	public static class VFXMaterialUtils
	{
		public static void ResetRenderer(Renderer renderer)
		{
			// // Void ResetRenderer(Renderer)
			// void Beyond::Rendering::VFXMaterialUtils::ResetRenderer(Renderer *renderer, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   void (__fastcall *v5)(Renderer *, _QWORD); // rax
			//   void (__fastcall *v6)(Renderer *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rax
			//   __int64 v9; // rax
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
			//   if ( wrapperArray.max_length.size <= 0 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( !LODWORD(v3._0.namespaze) )
			//     sub_180070270(v3, wrapperArray);
			//   if ( v3._0.byval_arg.data.dummy )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(0, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)renderer, 0LL);
			//       return;
			//     }
			//     goto LABEL_11;
			//   }
			// LABEL_7:
			//   if ( !renderer )
			//     goto LABEL_11;
			//   v5 = (void (__fastcall *)(Renderer *, _QWORD))qword_18D8F4650;
			//   if ( !qword_18D8F4650 )
			//   {
			//     v5 = (void (__fastcall *)(Renderer *, _QWORD))il2cpp_resolve_icall_0("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
			//     if ( !v5 )
			//     {
			//       v8 = sub_1802DBBE8("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
			//       sub_18000F750(v8, 0LL);
			//     }
			//     qword_18D8F4650 = (__int64)v5;
			//   }
			//   v5(renderer, 0LL);
			//   v6 = (void (__fastcall *)(Renderer *))qword_18D8F4658;
			//   if ( !qword_18D8F4658 )
			//   {
			//     v6 = (void (__fastcall *)(Renderer *))il2cpp_resolve_icall_0("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
			//     if ( !v6 )
			//     {
			//       v9 = sub_1802DBBE8("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
			//       sub_18000F750(v9, 0LL);
			//     }
			//     qword_18D8F4658 = (__int64)v6;
			//   }
			//   v6(renderer);
			// }
			// 
		}

		public static void SetVFXAlpha(Renderer renderer, float targetAlpha, float alphaIntensityValue)
		{
			// // Void SetVFXAlpha(Renderer, Single, Single)
			// void Beyond::Rendering::VFXMaterialUtils::SetVFXAlpha(
			//         Renderer *renderer,
			//         float targetAlpha,
			//         float alphaIntensityValue,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float CurvedMaterialAlpha; // xmm0_4
			//   void (__fastcall *v9)(Renderer *, bool); // rax
			//   void (__fastcall *v10)(Renderer *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rax
			//   __int64 v13; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v4);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size <= 1 )
			//     goto LABEL_7;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			// LABEL_11:
			//     sub_180B536AC(v6, wrapperArray);
			//   if ( LODWORD(v6._0.namespaze) <= 1 )
			//     sub_180070270(v6, wrapperArray);
			//   if ( *((_QWORD *)&v6._0.byval_arg + 1) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(Patch, (Object *)renderer, targetAlpha, alphaIntensityValue, 0LL);
			//       return;
			//     }
			//     goto LABEL_11;
			//   }
			// LABEL_7:
			//   CurvedMaterialAlpha = Beyond::Rendering::VFXMaterialUtils::GetCurvedMaterialAlpha(
			//                           alphaIntensityValue,
			//                           targetAlpha,
			//                           0LL);
			//   if ( !renderer )
			//     goto LABEL_11;
			//   v9 = (void (__fastcall *)(Renderer *, bool))qword_18D8F4650;
			//   if ( !qword_18D8F4650 )
			//   {
			//     v9 = (void (__fastcall *)(Renderer *, bool))il2cpp_resolve_icall_0("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
			//     if ( !v9 )
			//     {
			//       v12 = sub_1802DBBE8("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
			//       sub_18000F750(v12, 0LL);
			//     }
			//     qword_18D8F4650 = (__int64)v9;
			//   }
			//   v9(renderer, CurvedMaterialAlpha < 0.95);
			//   v10 = (void (__fastcall *)(Renderer *))qword_18D8F4658;
			//   if ( !qword_18D8F4658 )
			//   {
			//     v10 = (void (__fastcall *)(Renderer *))il2cpp_resolve_icall_0("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
			//     if ( !v10 )
			//     {
			//       v13 = sub_1802DBBE8("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
			//       sub_18000F750(v13, 0LL);
			//     }
			//     qword_18D8F4658 = (__int64)v10;
			//   }
			//   v10(renderer);
			// }
			// 
		}

		[IDTag(1)]
		public static float GetCurvedMaterialAlpha(Material material, float targetAlpha)
		{
			// // Single GetCurvedMaterialAlpha(Material, Single)
			// float Beyond::Rendering::VFXMaterialUtils::GetCurvedMaterialAlpha(
			//         Material *material,
			//         float targetAlpha,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(
			//              (ILFixDynamicMethodWrapper_7 *)Patch,
			//              (Object *)material,
			//              targetAlpha,
			//              0LL);
			//   }
			//   else
			//   {
			//     v4 = Beyond::Rendering::VFXMaterialUtils::CalculateVFXMaterialColorIntensity(material, 0LL);
			//     return Beyond::Rendering::VFXMaterialUtils::GetCurvedMaterialAlpha(v4, targetAlpha, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		[IDTag(0)]
		public static float GetCurvedMaterialAlpha(float materialColorIntensity, float targetAlpha)
		{
			// // Single GetCurvedMaterialAlpha(Single, Single)
			// float Beyond::Rendering::VFXMaterialUtils::GetCurvedMaterialAlpha(
			//         float materialColorIntensity,
			//         float targetAlpha,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double v8; // xmm0_8
			//   float v9; // xmm3_4
			//   float v10; // xmm8_4
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
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size > 2 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 2 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5._0.this_arg.data.dummy )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(2, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//                  (ILFixDynamicMethodWrapper_3 *)Patch,
			//                  materialColorIntensity,
			//                  targetAlpha,
			//                  0LL);
			//     }
			// LABEL_16:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( materialColorIntensity == 1.0 )
			//     return targetAlpha;
			//   v8 = sub_1802EB1B0((_DWORD)v5, wrapperArray);
			//   v9 = 0.5 / *(float *)&v8;
			//   if ( targetAlpha > 0.5 )
			//     return (float)((float)((float)(2.0 - (float)((float)(0.5 / *(float *)&v8) * 4.0)) * targetAlpha) * targetAlpha)
			//          + (float)((float)((float)(v9 * 4.0) - 1.0) * targetAlpha);
			//   v10 = targetAlpha + targetAlpha;
			//   if ( (float)(targetAlpha + targetAlpha) < 0.0 )
			//   {
			//     v10 = 0.0;
			//   }
			//   else if ( v10 > 1.0 )
			//   {
			//     v10 = 1.0;
			//   }
			//   return (float)((float)(v9 - 0.0) * v10) + 0.0;
			// }
			// 
			return 0f;
		}

		public static float CalculateVFXMaterialColorIntensity(Material material)
		{
			// // Single CalculateVFXMaterialColorIntensity(Material)
			// float Beyond::Rendering::VFXMaterialUtils::CalculateVFXMaterialColorIntensity(Material *material, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (__fastcall *v5)(Material *); // rax
			//   __int64 v6; // rsi
			//   unsigned __int8 (__fastcall *v7)(__int64, const char *); // rax
			//   __int64 v8; // rdx
			//   struct VFXShaderIDs__Class *v9; // rax
			//   VFXShaderIDs__StaticFields *static_fields; // rax
			//   unsigned int s_TintColor; // edi
			//   void (__fastcall *v12)(Material *, _QWORD, Color *); // rax
			//   VFXShaderIDs__StaticFields *v13; // rcx
			//   double (__fastcall *v14)(Material *, _QWORD); // rax
			//   unsigned int s_TintColorIntensity; // edi
			//   double v16; // xmm0_8
			//   float v17; // xmm7_4
			//   double (__fastcall *v18)(Material *, _QWORD); // rax
			//   unsigned int s_ExpThreshold; // edi
			//   double v20; // xmm0_8
			//   float v21; // xmm8_4
			//   double (__fastcall *v22)(Material *, _QWORD); // rax
			//   unsigned int s_ExpIntensity; // edi
			//   double v24; // xmm0_8
			//   float v25; // xmm9_4
			//   MethodInfo *v26; // rdx
			//   float v27; // xmm6_4
			//   float (__fastcall *v28)(Material *, _QWORD); // rax
			//   unsigned int s_UseBlend; // edi
			//   __int64 v30; // rdx
			//   float v31; // xmm0_4
			//   float result; // xmm0_4
			//   struct VFXShaderIDs__Class *v33; // rax
			//   VFXShaderIDs__StaticFields *v34; // rax
			//   unsigned int s_BlendTint; // edi
			//   void (__fastcall *v36)(Material *, _QWORD, Color *); // rax
			//   MethodInfo *v37; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v39; // rax
			//   __int64 v40; // rax
			//   __int64 v41; // rax
			//   __int64 v42; // rax
			//   __int64 v43; // rax
			//   __int64 v44; // rax
			//   __int64 v45; // rax
			//   __int64 v46; // rax
			//   __int64 v47; // rax
			//   ArgumentNullException *v48; // rdi
			//   String *v49; // rbx
			//   String *v50; // rax
			//   __int64 v51; // rax
			//   Color v52; // [rsp+20h] [rbp-68h] BYREF
			//   Color v53; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8ED942 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     sub_18003C530(&off_18C94C660);
			//     byte_18D8ED942 = 1;
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
			//     goto LABEL_39;
			//   if ( wrapperArray.max_length.size <= 4 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_39:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 4 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( v3._0.element_class )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43(
			//                (ILFixDynamicMethodWrapper_16 *)Patch,
			//                (Object *)material,
			//                0LL);
			//     goto LABEL_39;
			//   }
			// LABEL_9:
			//   if ( !material )
			//     goto LABEL_39;
			//   v5 = (__int64 (__fastcall *)(Material *))qword_18D8F4708;
			//   if ( !qword_18D8F4708 )
			//   {
			//     v5 = (__int64 (__fastcall *)(Material *))il2cpp_resolve_icall_0("UnityEngine.Material::get_shader()");
			//     if ( !v5 )
			//     {
			//       v39 = sub_1802DBBE8("UnityEngine.Material::get_shader()");
			//       sub_18000F750(v39, 0LL);
			//     }
			//     qword_18D8F4708 = (__int64)v5;
			//   }
			//   v6 = v5(material);
			//   if ( !v6 )
			//     goto LABEL_39;
			//   if ( !byte_18D8F4EB3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EB3 = 1;
			//   }
			//   if ( !"HGRP/Effect/VFXBaseV2" )
			//   {
			//     v47 = sub_18003C530(&TypeInfo::System::ArgumentNullException);
			//     v48 = (ArgumentNullException *)sub_180004920(v47);
			//     if ( v48 )
			//     {
			//       v49 = (String *)sub_18003C530(&off_18D5D29F0);
			//       v50 = (String *)sub_18003C530(&off_18D5D29F8);
			//       System::ArgumentNullException::ArgumentNullException(v48, v50, v49, 0LL);
			//       v51 = sub_18003C530(&MethodInfo::UnityEngine::Object::CompareName);
			//       sub_18000F7C0(v48, v51);
			//     }
			//     goto LABEL_39;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   v7 = (unsigned __int8 (__fastcall *)(__int64, const char *))qword_18D8F4F40;
			//   if ( !qword_18D8F4F40 )
			//   {
			//     v7 = (unsigned __int8 (__fastcall *)(__int64, const char *))il2cpp_resolve_icall_0(
			//                                                                   "UnityEngine.Object::Internal_CompareName(UnityEngine.O"
			//                                                                   "bject,System.String)");
			//     if ( !v7 )
			//     {
			//       v40 = sub_1802DBBE8("UnityEngine.Object::Internal_CompareName(UnityEngine.Object,System.String)");
			//       sub_18000F750(v40, 0LL);
			//     }
			//     qword_18D8F4F40 = (__int64)v7;
			//   }
			//   if ( !v7(v6, "HGRP/Effect/VFXBaseV2") )
			//     return 1.0;
			//   v9 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXShaderIDs._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs, v8);
			//     v9 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
			//   }
			//   static_fields = v9.static_fields;
			//   v52 = 0LL;
			//   s_TintColor = static_fields.s_TintColor;
			//   v12 = (void (__fastcall *)(Material *, _QWORD, Color *))qword_18D8F47B0;
			//   if ( !qword_18D8F47B0 )
			//   {
			//     v12 = (void (__fastcall *)(Material *, _QWORD, Color *))il2cpp_resolve_icall_0(
			//                                                               "UnityEngine.Material::GetColorImpl_Injected(System.Int32,U"
			//                                                               "nityEngine.Color&)");
			//     if ( !v12 )
			//     {
			//       v41 = sub_1802DBBE8("UnityEngine.Material::GetColorImpl_Injected(System.Int32,UnityEngine.Color&)");
			//       sub_18000F750(v41, 0LL);
			//     }
			//     qword_18D8F47B0 = (__int64)v12;
			//   }
			//   v12(material, s_TintColor, &v52);
			//   v13 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields;
			//   v14 = (double (__fastcall *)(Material *, _QWORD))qword_18D8F4790;
			//   v53 = v52;
			//   s_TintColorIntensity = v13.s_TintColorIntensity;
			//   if ( !qword_18D8F4790 )
			//   {
			//     v14 = (double (__fastcall *)(Material *, _QWORD))il2cpp_resolve_icall_0("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//     if ( !v14 )
			//     {
			//       v42 = sub_1802DBBE8("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//       sub_18000F750(v42, 0LL);
			//     }
			//     qword_18D8F4790 = (__int64)v14;
			//   }
			//   v16 = v14(material, s_TintColorIntensity);
			//   v17 = *(float *)&v16;
			//   v18 = (double (__fastcall *)(Material *, _QWORD))qword_18D8F4790;
			//   s_ExpThreshold = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_ExpThreshold;
			//   if ( !qword_18D8F4790 )
			//   {
			//     v18 = (double (__fastcall *)(Material *, _QWORD))il2cpp_resolve_icall_0("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//     if ( !v18 )
			//     {
			//       v43 = sub_1802DBBE8("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//       sub_18000F750(v43, 0LL);
			//     }
			//     qword_18D8F4790 = (__int64)v18;
			//   }
			//   v20 = v18(material, s_ExpThreshold);
			//   v21 = *(float *)&v20;
			//   v22 = (double (__fastcall *)(Material *, _QWORD))qword_18D8F4790;
			//   s_ExpIntensity = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_ExpIntensity;
			//   if ( !qword_18D8F4790 )
			//   {
			//     v22 = (double (__fastcall *)(Material *, _QWORD))il2cpp_resolve_icall_0("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//     if ( !v22 )
			//     {
			//       v44 = sub_1802DBBE8("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//       sub_18000F750(v44, 0LL);
			//     }
			//     qword_18D8F4790 = (__int64)v22;
			//   }
			//   v24 = v22(material, s_ExpIntensity);
			//   v25 = *(float *)&v24;
			//   v27 = UnityEngine::Color::get_grayscale(&v53, v26) * v17;
			//   v28 = (float (__fastcall *)(Material *, _QWORD))qword_18D8F4790;
			//   s_UseBlend = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_UseBlend;
			//   if ( !qword_18D8F4790 )
			//   {
			//     v28 = (float (__fastcall *)(Material *, _QWORD))il2cpp_resolve_icall_0("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//     if ( !v28 )
			//     {
			//       v45 = sub_1802DBBE8("UnityEngine.Material::GetFloatImpl(System.Int32)");
			//       sub_18000F750(v45, 0LL);
			//     }
			//     qword_18D8F4790 = (__int64)v28;
			//   }
			//   if ( v28(material, s_UseBlend) == 1.0 )
			//   {
			//     v33 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXShaderIDs._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs, v30);
			//       v33 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
			//     }
			//     v34 = v33.static_fields;
			//     v52 = 0LL;
			//     s_BlendTint = v34.s_BlendTint;
			//     v36 = (void (__fastcall *)(Material *, _QWORD, Color *))qword_18D8F47B0;
			//     if ( !qword_18D8F47B0 )
			//     {
			//       v36 = (void (__fastcall *)(Material *, _QWORD, Color *))il2cpp_resolve_icall_0(
			//                                                                 "UnityEngine.Material::GetColorImpl_Injected(System.Int32"
			//                                                                 ",UnityEngine.Color&)");
			//       if ( !v36 )
			//       {
			//         v46 = sub_1802DBBE8("UnityEngine.Material::GetColorImpl_Injected(System.Int32,UnityEngine.Color&)");
			//         sub_18000F750(v46, 0LL);
			//       }
			//       qword_18D8F47B0 = (__int64)v36;
			//     }
			//     v36(material, s_BlendTint, &v52);
			//     v53 = v52;
			//     v27 = v27 + UnityEngine::Color::get_grayscale(&v53, v37);
			//   }
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v30);
			//   v31 = v27 - v21;
			//   if ( (float)(v27 - v21) < 0.0 )
			//     v31 = 0.0;
			//   result = (float)(v31 * v25) + v27;
			//   if ( result < 1.0 )
			//     return 1.0;
			//   return result;
			// }
			// 
			return 0f;
		}

		public static float CalculateVFXMaterialColorMaxIntensity(Material material, out string log, out int featureCount)
		{
			// // Single CalculateVFXMaterialColorMaxIntensity(Material, String ByRef, Int32 ByRef)
			// float Beyond::Rendering::VFXMaterialUtils::CalculateVFXMaterialColorMaxIntensity(
			//         Material *material,
			//         String **log,
			//         int32_t *featureCount,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Object_1 *shader; // rax
			//   OneofDescriptorProto *v10; // rdx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   Utf16ValueStringBuilder v13; // xmm0
			//   float FloatImpl; // xmm6_4
			//   float v15; // xmm11_4
			//   float v16; // xmm10_4
			//   MethodInfo *v17; // rdx
			//   float v18; // xmm8_4
			//   Color v19; // xmm7
			//   Color v20; // xmm6
			//   MethodInfo *v21; // rdx
			//   float grayscale; // xmm3_4
			//   MethodInfo *v23; // rdx
			//   Color v24; // xmm6
			//   MethodInfo *v25; // rdx
			//   Color v26; // xmm6
			//   MethodInfo *v27; // rdx
			//   Color v28; // xmm6
			//   MethodInfo *v29; // rdx
			//   MethodInfo *v30; // rdx
			//   OneofDescriptorProto *v31; // rdx
			//   FileDescriptor *v32; // r8
			//   MessageDescriptor *v33; // r9
			//   float v34; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v37; // [rsp+28h] [rbp-59h]
			//   String *v38; // [rsp+30h] [rbp-51h]
			//   Color v39; // [rsp+38h] [rbp-49h] BYREF
			//   Utf16ValueStringBuilder v40; // [rsp+48h] [rbp-39h] BYREF
			//   Color v41; // [rsp+58h] [rbp-29h] BYREF
			//   Color v42[7]; // [rsp+68h] [rbp-19h] BYREF
			// 
			//   if ( !byte_18D9192FC )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color,UnityEngine::Color>);
			//     sub_18003C530(&MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>);
			//     sub_18003C530(&MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>);
			//     sub_18003C530(&TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     sub_18003C530(&off_18C94C660);
			//     sub_18003C530(&off_18D584BF0);
			//     sub_18003C530(&off_18D584C20);
			//     sub_18003C530(&off_18D584C10);
			//     sub_18003C530(&off_18D584BC8);
			//     sub_18003C530(&off_18D584BB8);
			//     sub_18003C530(&off_18D584BE0);
			//     sub_18003C530(&off_18D584BD8);
			//     sub_18003C530(&off_18D584608);
			//     byte_18D9192FC = 1;
			//   }
			//   v40 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(5, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(5, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(Patch, (Object *)material, log, featureCount, 0LL);
			// LABEL_23:
			//     sub_180B536AC(v8, v7);
			//   }
			//   if ( !material )
			//     goto LABEL_23;
			//   shader = (Object_1 *)UnityEngine::Material::get_shader(material, 0LL);
			//   if ( !shader )
			//     goto LABEL_23;
			//   if ( UnityEngine::Object::CompareName(shader, (String *)"HGRP/Effect/VFXBaseV2", 0LL) )
			//   {
			//     v13 = *Beyond::StringUtils::CreateZStringBuilder((Utf16ValueStringBuilder *)&v41, 0LL);
			//     *featureCount = 0;
			//     v40 = v13;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     v39 = *UnityEngine::Material::GetColor(
			//              &v41,
			//              material,
			//              TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_TintColor,
			//              0LL);
			//     FloatImpl = UnityEngine::Material::GetFloatImpl(
			//                   material,
			//                   TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_TintColorIntensity,
			//                   0LL);
			//     v15 = UnityEngine::Material::GetFloatImpl(
			//             material,
			//             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_ExpThreshold,
			//             0LL);
			//     v16 = UnityEngine::Material::GetFloatImpl(
			//             material,
			//             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_ExpIntensity,
			//             0LL);
			//     v18 = UnityEngine::Color::get_grayscale(&v39, v17) * FloatImpl;
			//     sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//     Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>(
			//       &v40,
			//       (String *)"TintColorIntensity:{0}\n",
			//       FloatImpl,
			//       MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>);
			//     if ( UnityEngine::Material::GetFloatImpl(
			//            material,
			//            TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_UseBright,
			//            0LL) == 1.0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//       v39 = *UnityEngine::Material::GetColor(
			//                &v41,
			//                material,
			//                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_BrightColor,
			//                0LL);
			//       v19 = (Color)_mm_loadu_si128((const __m128i *)sub_182F8C840(&v41, &v39));
			//       v41 = v19;
			//       v39 = *UnityEngine::Material::GetColor(
			//                &v39,
			//                material,
			//                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_ScanFillColor,
			//                0LL);
			//       v20 = (Color)_mm_loadu_si128((const __m128i *)sub_182F8C840(v42, &v39));
			//       v39 = v20;
			//       grayscale = UnityEngine::Color::get_grayscale(&v39, v21);
			//       v18 = v18 + (float)(grayscale * UnityEngine::Color::get_grayscale(&v41, v23));
			//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//       v41 = v20;
			//       v39 = v19;
			//       sub_18044BCB0(
			//         (unsigned int)&v40,
			//         (unsigned int)"BrightColor(gamma后):{0},  ScanFillColor(gamma后):{1}\n, ",
			//         (unsigned int)&v39,
			//         (unsigned int)&v41,
			//         (__int64)MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color,UnityEngine::Color>);
			//       ++*featureCount;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     if ( UnityEngine::Material::GetFloatImpl(
			//            material,
			//            TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_UseBlend,
			//            0LL) == 1.0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//       v39 = *UnityEngine::Material::GetColor(
			//                v42,
			//                material,
			//                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_BlendTint,
			//                0LL);
			//       v24 = (Color)_mm_loadu_si128((const __m128i *)sub_182F8C840(v42, &v39));
			//       v41 = v24;
			//       v18 = v18 + UnityEngine::Color::get_grayscale(&v41, v25);
			//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//       v41 = v24;
			//       Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>(
			//         &v40,
			//         (String *)"BlendTint(gamma后):{0}\n",
			//         &v41,
			//         MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>);
			//       ++*featureCount;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     if ( UnityEngine::Material::GetFloatImpl(
			//            material,
			//            TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_UseDissolve,
			//            0LL) == 1.0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//       v39 = *UnityEngine::Material::GetColor(
			//                v42,
			//                material,
			//                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_DissolveEmissiveColor,
			//                0LL);
			//       v26 = (Color)_mm_loadu_si128((const __m128i *)sub_182F8C840(v42, &v39));
			//       v41 = v26;
			//       v18 = v18 + UnityEngine::Color::get_grayscale(&v41, v27);
			//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//       v41 = v26;
			//       Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>(
			//         &v40,
			//         (String *)"DissolveEmissiveColor(gamma后):{0}\n",
			//         &v41,
			//         MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>);
			//       ++*featureCount;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     if ( UnityEngine::Material::GetFloatImpl(
			//            material,
			//            TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_UseFresnel,
			//            0LL) == 1.0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//       v39 = *UnityEngine::Material::GetColor(
			//                v42,
			//                material,
			//                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_FresnelColor,
			//                0LL);
			//       v28 = (Color)_mm_loadu_si128((const __m128i *)sub_182F8C840(v42, &v39));
			//       v41 = v28;
			//       v18 = fmaxf(UnityEngine::Color::get_grayscale(&v41, v29), v18);
			//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//       v41 = v28;
			//       Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>(
			//         &v40,
			//         (String *)"fresnelColor(gamma后):{0}\n",
			//         &v41,
			//         MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<UnityEngine::Color>);
			//       ++*featureCount;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//     if ( UnityEngine::Material::GetFloatImpl(
			//            material,
			//            TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_UseEdgeColor,
			//            0LL) == 1.0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
			//       v39 = *UnityEngine::Material::GetColor(
			//                v42,
			//                material,
			//                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_EdgeColor,
			//                0LL);
			//       v39 = *(Color *)sub_182F8C840(v42, &v39);
			//       if ( UnityEngine::Material::GetFloatImpl(
			//              material,
			//              TypeInfo::HG::Rendering::Runtime::VFXShaderIDs.static_fields.s_EdgeColorMode,
			//              0LL) > 0.5 )
			//         v18 = v18 + UnityEngine::Color::get_grayscale(&v39, v30);
			//       else
			//         v18 = v18 * UnityEngine::Color::get_grayscale(&v39, v30);
			//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//       Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>(
			//         &v40,
			//         (String *)"EdgeColor(gamma后):{0}\n",
			//         v18,
			//         MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>);
			//       ++*featureCount;
			//     }
			//     sub_180002C70(TypeInfo::System::Math);
			//     sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			//     Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>(
			//       &v40,
			//       (String *)"expIntensity:{0}\n",
			//       v16,
			//       MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<float>);
			//     *log = Cysharp::Text::Utf16ValueStringBuilder::ToString(&v40, 0LL);
			//     sub_1800054D0((OneofDescriptor *)log, v31, v32, v33, v37, v38, *(MethodInfo **)&v39.r);
			//     sub_1823ABD90(&v40);
			//     v34 = System::Math::Max(0.0, v18 - v15, 0LL);
			//     return System::Math::Max(1.0, (float)(v34 * v16) + v18, 0LL);
			//   }
			//   else
			//   {
			//     *log = (String *)"非VFXBaseV2";
			//     sub_1800054D0((OneofDescriptor *)log, v10, v11, v12, v37, v38, *(MethodInfo **)&v39.r);
			//     *featureCount = 0;
			//     return 1.0;
			//   }
			// }
			// 
			return 0f;
		}

		public enum VFXMaterialType
		{
			VFX,
			Character,
			Lit
		}
	}
}
