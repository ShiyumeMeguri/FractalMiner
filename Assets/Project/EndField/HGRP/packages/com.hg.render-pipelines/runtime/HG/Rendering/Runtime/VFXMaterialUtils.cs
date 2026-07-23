using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class VFXMaterialUtils // TypeDefIndex: 37973
	{
		// Nested types
		public enum VFXMaterialType // TypeDefIndex: 37972
		{
			VFX = 0,
			Character = 1,
			Lit = 2
		}
	
		// Methods
		public static void ResetRenderer(Renderer renderer) {} // 0x000000018339B890-0x000000018339B920
		// Void ResetRenderer(Renderer)
		void HG::Rendering::Runtime::VFXMaterialUtils::ResetRenderer(Renderer *renderer, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  void (__fastcall *v5)(Renderer *, _QWORD); // rax
		  void (__fastcall *v6)(Renderer *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rax
		  __int64 v9; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 2596 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0xA24 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[55]._0.klass )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2596, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)renderer, 0LL);
		      return;
		    }
		    goto LABEL_9;
		  }
		LABEL_5:
		  if ( !renderer )
		    goto LABEL_9;
		  v5 = (void (__fastcall *)(Renderer *, _QWORD))qword_18F36F550;
		  if ( !qword_18F36F550 )
		  {
		    v5 = (void (__fastcall *)(Renderer *, _QWORD))il2cpp_resolve_icall_1("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
		    if ( !v5 )
		    {
		      v8 = sub_1802EE1B8("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
		      sub_18007E1B0(v8, 0LL);
		    }
		    qword_18F36F550 = (__int64)v5;
		  }
		  v5(renderer, 0LL);
		  v6 = (void (__fastcall *)(Renderer *))qword_18F36F558;
		  if ( !qword_18F36F558 )
		  {
		    v6 = (void (__fastcall *)(Renderer *))il2cpp_resolve_icall_1("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
		    if ( !v6 )
		    {
		      v9 = sub_1802EE1B8("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
		      sub_18007E1B0(v9, 0LL);
		    }
		    qword_18F36F558 = (__int64)v6;
		  }
		  v6(renderer);
		}
		
		public static void SetVFXAlpha(Renderer renderer, float targetAlpha, float alphaIntensityValue) {} // 0x0000000183105220-0x0000000183105440
		// Void SetVFXAlpha(Renderer, Single, Single)
		void HG::Rendering::Runtime::VFXMaterialUtils::SetVFXAlpha(
		        Renderer *renderer,
		        float targetAlpha,
		        float alphaIntensityValue,
		        MethodInfo *method)
		{
		  __int64 v4; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  float v7; // xmm7_4
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  double v9; // xmm0_8
		  float v10; // xmm3_4
		  float v11; // xmm1_4
		  void (__fastcall *v12)(Renderer *, bool, __int64, MethodInfo *); // rax
		  void (__fastcall *v13)(Renderer *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		  __int64 v16; // rax
		  __int64 v17; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = targetAlpha;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray->max_length.size > 2597 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_22;
		    if ( wrapperArray->max_length.size <= 0xA25u )
		      goto LABEL_41;
		    if ( wrapperArray[72].vector[5] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2597, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_6(
		          (ILFixDynamicMethodWrapper_4 *)Patch,
		          (Object *)renderer,
		          targetAlpha,
		          alphaIntensityValue,
		          0LL);
		        return;
		      }
		      goto LABEL_22;
		    }
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray->max_length.size <= 2598 )
		    goto LABEL_9;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		LABEL_22:
		    sub_1800D8260(v6, wrapperArray);
		  if ( LODWORD(v6->_0.namespaze) <= 0xA26 )
		LABEL_41:
		    sub_1800D2AB0(v6, wrapperArray);
		  if ( v6[55]._0.events )
		  {
		    v15 = IFix::WrappersManagerImpl::GetPatch(2598, 0LL);
		    if ( v15 )
		    {
		      v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(v15, alphaIntensityValue, targetAlpha, 0LL);
		      goto LABEL_15;
		    }
		    goto LABEL_22;
		  }
		LABEL_9:
		  if ( alphaIntensityValue != 1.0 )
		  {
		    v9 = sub_1803369A0();
		    v10 = 0.5 / *(float *)&v9;
		    if ( targetAlpha > 0.5 )
		    {
		      v7 = (float)((float)((float)(2.0 - (float)(v10 * 4.0)) * targetAlpha) * targetAlpha)
		         + (float)((float)((float)(v10 * 4.0) - 1.0) * targetAlpha);
		    }
		    else
		    {
		      if ( (float)(targetAlpha + targetAlpha) < 0.0 )
		      {
		        v11 = 0.0;
		      }
		      else if ( (float)(targetAlpha + targetAlpha) > 1.0 )
		      {
		        v11 = 1.0;
		      }
		      else
		      {
		        v11 = targetAlpha + targetAlpha;
		      }
		      v7 = (float)((float)(v10 - 0.0) * v11) + 0.0;
		    }
		  }
		LABEL_15:
		  if ( !renderer )
		    goto LABEL_22;
		  v12 = (void (__fastcall *)(Renderer *, bool, __int64, MethodInfo *))qword_18F36F550;
		  if ( !qword_18F36F550 )
		  {
		    v12 = (void (__fastcall *)(Renderer *, bool, __int64, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                          "UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
		    if ( !v12 )
		    {
		      v16 = sub_1802EE1B8("UnityEngine.Renderer::set_enableManualDither(System.Boolean)");
		      sub_18007E1B0(v16, 0LL);
		    }
		    qword_18F36F550 = (__int64)v12;
		  }
		  v12(renderer, v7 < 0.95, v4, method);
		  v13 = (void (__fastcall *)(Renderer *))qword_18F36F558;
		  if ( !qword_18F36F558 )
		  {
		    v13 = (void (__fastcall *)(Renderer *))il2cpp_resolve_icall_1("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
		    if ( !v13 )
		    {
		      v17 = sub_1802EE1B8("UnityEngine.Renderer::set_manualDitherAlphaValue(System.Single)");
		      sub_18007E1B0(v17, 0LL);
		    }
		    qword_18F36F558 = (__int64)v13;
		  }
		  v13(renderer);
		}
		
		[IDTag(1)]
		public static float GetCurvedMaterialAlpha(Material material, float targetAlpha) => default; // 0x0000000189B5FC78-0x0000000189B5FCE4
		// Single GetCurvedMaterialAlpha(Material, Single)
		float HG::Rendering::Runtime::VFXMaterialUtils::GetCurvedMaterialAlpha(
		        Material *material,
		        float targetAlpha,
		        MethodInfo *method)
		{
		  float v4; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2599, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2599, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_111(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)material,
		             targetAlpha,
		             0LL);
		  }
		  else
		  {
		    v4 = HG::Rendering::Runtime::VFXMaterialUtils::CalculateVFXMaterialColorIntensity(material, 0LL);
		    return HG::Rendering::Runtime::VFXMaterialUtils::GetCurvedMaterialAlpha(v4, targetAlpha, 0LL);
		  }
		}
		
		[IDTag(0)]
		public static float GetCurvedMaterialAlpha(float materialColorIntensity, float targetAlpha) => default; // 0x00000001831054A0-0x00000001831055D0
		// Single GetCurvedMaterialAlpha(Single, Single)
		float HG::Rendering::Runtime::VFXMaterialUtils::GetCurvedMaterialAlpha(
		        float materialColorIntensity,
		        float targetAlpha,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  double v6; // xmm0_8
		  float v7; // xmm3_4
		  float v8; // xmm7_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 2598 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( wrapperArray )
		    {
		      if ( wrapperArray->max_length.size <= 0xA26u )
		        sub_1800D2AB0(wrapperArray, v3);
		      if ( !wrapperArray[72].vector[6] )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2598, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, materialColorIntensity, targetAlpha, 0LL);
		    }
		LABEL_15:
		    sub_1800D8260(wrapperArray, v3);
		  }
		LABEL_5:
		  if ( materialColorIntensity == 1.0 )
		    return targetAlpha;
		  v6 = sub_1803369A0();
		  v7 = 0.5 / *(float *)&v6;
		  if ( targetAlpha > 0.5 )
		    return (float)((float)((float)(2.0 - (float)(v7 * 4.0)) * targetAlpha) * targetAlpha)
		         + (float)((float)((float)(v7 * 4.0) - 1.0) * targetAlpha);
		  v8 = targetAlpha + targetAlpha;
		  if ( (float)(targetAlpha + targetAlpha) < 0.0 )
		  {
		    v8 = 0.0;
		  }
		  else if ( v8 > 1.0 )
		  {
		    v8 = 1.0;
		  }
		  return (float)((float)(v7 - 0.0) * v8) + 0.0;
		}
		
		public static float CalculateVFXMaterialColorIntensity(Material material) => default; // 0x000000018339F2B0-0x000000018339F6A0
		// Single CalculateVFXMaterialColorIntensity(Material)
		float HG::Rendering::Runtime::VFXMaterialUtils::CalculateVFXMaterialColorIntensity(
		        Material *material,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 (__fastcall *v5)(Material *); // rax
		  __int64 v6; // rsi
		  unsigned __int8 (__fastcall *v7)(__int64, const char *); // rax
		  struct VFXShaderIDs__Class *v8; // rax
		  VFXShaderIDs__StaticFields *static_fields; // rax
		  unsigned int s_TintColor; // edi
		  void (__fastcall *v11)(Material *, _QWORD, Color *); // rax
		  VFXShaderIDs__StaticFields *v12; // rcx
		  double (__fastcall *v13)(Material *, _QWORD); // rax
		  unsigned int s_TintColorIntensity; // edi
		  double v15; // xmm0_8
		  float v16; // xmm7_4
		  double (__fastcall *v17)(Material *, _QWORD); // rax
		  unsigned int s_ExpThreshold; // edi
		  double v19; // xmm0_8
		  float v20; // xmm8_4
		  double (__fastcall *v21)(Material *, _QWORD); // rax
		  unsigned int s_ExpIntensity; // edi
		  double v23; // xmm0_8
		  float v24; // xmm9_4
		  MethodInfo *v25; // rdx
		  float v26; // xmm6_4
		  float (__fastcall *v27)(Material *, _QWORD); // rax
		  unsigned int s_UseBlend; // edi
		  float v29; // xmm0_4
		  float result; // xmm0_4
		  struct VFXShaderIDs__Class *v31; // rax
		  VFXShaderIDs__StaticFields *v32; // rax
		  unsigned int s_BlendTint; // edi
		  void (__fastcall *v34)(Material *, _QWORD, Color *); // rax
		  MethodInfo *v35; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v37; // rax
		  __int64 v38; // rax
		  __int64 v39; // rax
		  ArgumentNullException *v40; // rdi
		  String *v41; // rbx
		  String *v42; // rax
		  __int64 v43; // rax
		  Color v44; // [rsp+20h] [rbp-68h] BYREF
		  Color v45; // [rsp+30h] [rbp-58h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_39;
		  if ( wrapperArray->max_length.size <= 2600 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_39:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0xA28 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( v3[55]._0.methods )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2600, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		               (ILFixDynamicMethodWrapper_15 *)Patch,
		               (Object *)material,
		               0LL);
		    goto LABEL_39;
		  }
		LABEL_5:
		  if ( !material )
		    goto LABEL_39;
		  v5 = (__int64 (__fastcall *)(Material *))qword_18F36F618;
		  if ( !qword_18F36F618 )
		  {
		    v5 = (__int64 (__fastcall *)(Material *))il2cpp_resolve_icall_1("UnityEngine.Material::get_shader()");
		    if ( !v5 )
		    {
		      v37 = sub_1802EE1B8("UnityEngine.Material::get_shader()");
		      sub_18007E1B0(v37, 0LL);
		    }
		    qword_18F36F618 = (__int64)v5;
		  }
		  v6 = v5(material);
		  if ( !v6 )
		    goto LABEL_39;
		  if ( !"HGRP/Effect/VFXBaseV2" )
		  {
		    v39 = sub_180035ED0(&TypeInfo::System::ArgumentNullException);
		    v40 = (ArgumentNullException *)sub_1800368D0(v39);
		    if ( v40 )
		    {
		      v41 = (String *)sub_180035ED0(&off_18E273480);
		      v42 = (String *)sub_180035ED0(&off_18E273488);
		      System::ArgumentNullException::ArgumentNullException(v40, v42, v41, 0LL);
		      v43 = sub_180035ED0(&MethodInfo::UnityEngine::Object::CompareName);
		      sub_18007E190(v40, v43);
		    }
		    goto LABEL_39;
		  }
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v7 = (unsigned __int8 (__fastcall *)(__int64, const char *))qword_18F36FD70;
		  if ( !qword_18F36FD70 )
		  {
		    v7 = (unsigned __int8 (__fastcall *)(__int64, const char *))il2cpp_resolve_icall_1(
		                                                                  "UnityEngine.Object::Internal_CompareName(UnityEngine.O"
		                                                                  "bject,System.String)");
		    if ( !v7 )
		    {
		      v38 = sub_1802EE1B8("UnityEngine.Object::Internal_CompareName(UnityEngine.Object,System.String)");
		      sub_18007E1B0(v38, 0LL);
		    }
		    qword_18F36FD70 = (__int64)v7;
		  }
		  if ( !v7(v6, "HGRP/Effect/VFXBaseV2") )
		    return 1.0;
		  v8 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
		  if ( !TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		    v8 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
		  }
		  static_fields = v8->static_fields;
		  v44 = 0LL;
		  s_TintColor = static_fields->s_TintColor;
		  v11 = (void (__fastcall *)(Material *, _QWORD, Color *))qword_18F36F6C0;
		  if ( !qword_18F36F6C0 )
		  {
		    v11 = (void (__fastcall *)(Material *, _QWORD, Color *))sub_180059EA0(
		                                                              "UnityEngine.Material::GetColorImpl_Injected(System.Int32,U"
		                                                              "nityEngine.Color&)");
		    qword_18F36F6C0 = (__int64)v11;
		  }
		  v11(material, s_TintColor, &v44);
		  v12 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields;
		  v13 = (double (__fastcall *)(Material *, _QWORD))qword_18F36F698;
		  v45 = v44;
		  s_TintColorIntensity = v12->s_TintColorIntensity;
		  if ( !qword_18F36F698 )
		  {
		    v13 = (double (__fastcall *)(Material *, _QWORD))sub_180059EA0("UnityEngine.Material::GetFloatImpl(System.Int32)");
		    qword_18F36F698 = (__int64)v13;
		  }
		  v15 = v13(material, s_TintColorIntensity);
		  v16 = *(float *)&v15;
		  v17 = (double (__fastcall *)(Material *, _QWORD))qword_18F36F698;
		  s_ExpThreshold = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ExpThreshold;
		  if ( !qword_18F36F698 )
		  {
		    v17 = (double (__fastcall *)(Material *, _QWORD))sub_180059EA0("UnityEngine.Material::GetFloatImpl(System.Int32)");
		    qword_18F36F698 = (__int64)v17;
		  }
		  v19 = v17(material, s_ExpThreshold);
		  v20 = *(float *)&v19;
		  v21 = (double (__fastcall *)(Material *, _QWORD))qword_18F36F698;
		  s_ExpIntensity = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ExpIntensity;
		  if ( !qword_18F36F698 )
		  {
		    v21 = (double (__fastcall *)(Material *, _QWORD))sub_180059EA0("UnityEngine.Material::GetFloatImpl(System.Int32)");
		    qword_18F36F698 = (__int64)v21;
		  }
		  v23 = v21(material, s_ExpIntensity);
		  v24 = *(float *)&v23;
		  v26 = UnityEngine::Color::get_grayscale(&v45, v25) * v16;
		  v27 = (float (__fastcall *)(Material *, _QWORD))qword_18F36F698;
		  s_UseBlend = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseBlend;
		  if ( !qword_18F36F698 )
		  {
		    v27 = (float (__fastcall *)(Material *, _QWORD))sub_180059EA0("UnityEngine.Material::GetFloatImpl(System.Int32)");
		    qword_18F36F698 = (__int64)v27;
		  }
		  if ( v27(material, s_UseBlend) == 1.0 )
		  {
		    v31 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
		    if ( !TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		      v31 = TypeInfo::HG::Rendering::Runtime::VFXShaderIDs;
		    }
		    v32 = v31->static_fields;
		    v44 = 0LL;
		    s_BlendTint = v32->s_BlendTint;
		    v34 = (void (__fastcall *)(Material *, _QWORD, Color *))qword_18F36F6C0;
		    if ( !qword_18F36F6C0 )
		    {
		      v34 = (void (__fastcall *)(Material *, _QWORD, Color *))sub_180059EA0(
		                                                                "UnityEngine.Material::GetColorImpl_Injected(System.Int32"
		                                                                ",UnityEngine.Color&)");
		      qword_18F36F6C0 = (__int64)v34;
		    }
		    v34(material, s_BlendTint, &v44);
		    v45 = v44;
		    v26 = v26 + UnityEngine::Color::get_grayscale(&v45, v35);
		  }
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  v29 = v26 - v20;
		  if ( (float)(v26 - v20) < 0.0 )
		    v29 = 0.0;
		  result = (float)(v29 * v24) + v26;
		  if ( result < 1.0 )
		    return 1.0;
		  return result;
		}
		
		public static float CalculateVFXMaterialColorMaxIntensity(Material material, out string log, out int featureCount) {
			log = default;
			featureCount = default;
			return default;
		} // 0x0000000189B5F58C-0x0000000189B5FC78
		// Single CalculateVFXMaterialColorMaxIntensity(Material, String ByRef, Int32 ByRef)
		float HG::Rendering::Runtime::VFXMaterialUtils::CalculateVFXMaterialColorMaxIntensity(
		        Material *material,
		        String **log,
		        int32_t *featureCount,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Object_1 *shader; // rax
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  StringBuilder *v13; // rax
		  StringBuilder *v14; // r14
		  float FloatImpl; // xmm11_4
		  float v16; // xmm12_4
		  float v17; // xmm10_4
		  MethodInfo *v18; // rdx
		  float grayscale; // xmm0_4
		  float v20; // xmm8_4
		  Object *v21; // rax
		  Color v22; // xmm7
		  Color v23; // xmm6
		  MethodInfo *v24; // rdx
		  float v25; // xmm3_4
		  MethodInfo *v26; // rdx
		  float v27; // xmm0_4
		  Object *v28; // rbx
		  Object *v29; // rax
		  MethodInfo *v30; // rdx
		  Color *v31; // rax
		  Object *v32; // rax
		  MethodInfo *v33; // rdx
		  Color *v34; // rax
		  Object *v35; // rax
		  MethodInfo *v36; // rdx
		  Color *v37; // rax
		  Object *v38; // rax
		  MethodInfo *v39; // rdx
		  Object *v40; // rax
		  Object *v41; // rax
		  HGRuntimeGrassQuery_Node *v42; // rdx
		  HGRuntimeGrassQuery_Node *v43; // r8
		  Int32__Array **v44; // r9
		  float v45; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v48; // [rsp+28h] [rbp-79h]
		  float v49; // [rsp+38h] [rbp-69h] BYREF
		  Color v50; // [rsp+40h] [rbp-61h] BYREF
		  Color v51; // [rsp+50h] [rbp-51h] BYREF
		  Color v52; // [rsp+60h] [rbp-41h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2601, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2601, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_964(Patch, (Object *)material, log, featureCount, 0LL);
		LABEL_22:
		    sub_1800D8260(v8, v7);
		  }
		  if ( !material )
		    goto LABEL_22;
		  shader = (Object_1 *)UnityEngine::Material::get_shader(material, 0LL);
		  if ( !shader )
		    goto LABEL_22;
		  if ( !UnityEngine::Object::CompareName(shader, (String *)"HGRP/Effect/VFXBaseV2", 0LL) )
		  {
		    *log = (String *)"非VFXBaseV2";
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)log, v10, v11, v12, v48);
		    *featureCount = 0;
		    return 1.0;
		  }
		  v13 = (StringBuilder *)sub_18002C620(TypeInfo::System::Text::StringBuilder);
		  v14 = v13;
		  if ( !v13 )
		    goto LABEL_22;
		  System::Text::StringBuilder::StringBuilder(v13, 0LL);
		  *featureCount = 0;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		  v50 = *UnityEngine::Material::GetColor(
		           &v51,
		           material,
		           TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_TintColor,
		           0LL);
		  FloatImpl = UnityEngine::Material::GetFloatImpl(
		                material,
		                TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_TintColorIntensity,
		                0LL);
		  v16 = UnityEngine::Material::GetFloatImpl(
		          material,
		          TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ExpThreshold,
		          0LL);
		  v17 = UnityEngine::Material::GetFloatImpl(
		          material,
		          TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ExpIntensity,
		          0LL);
		  grayscale = UnityEngine::Color::get_grayscale(&v50, v18);
		  v49 = FloatImpl;
		  v20 = grayscale * FloatImpl;
		  v21 = (Object *)il2cpp_value_box_0(TypeInfo::System::Single, &v49);
		  System::Text::StringBuilder::AppendFormat(v14, (String *)"TintColorIntensity:{0}\n", v21, 0LL);
		  if ( UnityEngine::Material::GetFloatImpl(
		         material,
		         TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseBright,
		         0LL) == 1.0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		    v50 = *UnityEngine::Material::GetColor(
		             &v51,
		             material,
		             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_BrightColor,
		             0LL);
		    v22 = (Color)_mm_loadu_si128((const __m128i *)sub_183C6CBA0(&v51, &v50));
		    v51 = v22;
		    v50 = *UnityEngine::Material::GetColor(
		             &v50,
		             material,
		             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ScanFillColor,
		             0LL);
		    v23 = (Color)_mm_loadu_si128((const __m128i *)sub_183C6CBA0(&v52, &v50));
		    v50 = v23;
		    v25 = UnityEngine::Color::get_grayscale(&v50, v24);
		    v27 = UnityEngine::Color::get_grayscale(&v51, v26);
		    v51 = v22;
		    v20 = v20 + (float)(v25 * v27);
		    v28 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Color, &v51);
		    v51 = v23;
		    v29 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Color, &v51);
		    System::Text::StringBuilder::AppendFormat(
		      v14,
		      (String *)"BrightColor(gamma后):{0},  ScanFillColor(gamma后):{1}\n, ",
		      v28,
		      v29,
		      0LL);
		    ++*featureCount;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		  if ( UnityEngine::Material::GetFloatImpl(
		         material,
		         TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseBlend,
		         0LL) == 1.0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		    v50 = *UnityEngine::Material::GetColor(
		             &v52,
		             material,
		             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_BlendTint,
		             0LL);
		    v51 = *(Color *)sub_183C6CBA0(&v52, &v50);
		    v20 = v20 + UnityEngine::Color::get_grayscale(&v51, v30);
		    v51 = *v31;
		    v32 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Color, &v51);
		    System::Text::StringBuilder::AppendFormat(v14, (String *)"BlendTint(gamma后):{0}\n", v32, 0LL);
		    ++*featureCount;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		  if ( UnityEngine::Material::GetFloatImpl(
		         material,
		         TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseDissolve,
		         0LL) == 1.0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		    v50 = *UnityEngine::Material::GetColor(
		             &v52,
		             material,
		             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveEmissiveColor,
		             0LL);
		    v51 = *(Color *)sub_183C6CBA0(&v52, &v50);
		    v20 = v20 + (float)(UnityEngine::Color::get_grayscale(&v51, v33) * FloatImpl);
		    v51 = *v34;
		    v35 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Color, &v51);
		    System::Text::StringBuilder::AppendFormat(v14, (String *)"DissolveEmissiveColor(gamma后):{0}\n", v35, 0LL);
		    ++*featureCount;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		  if ( UnityEngine::Material::GetFloatImpl(
		         material,
		         TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseFresnel,
		         0LL) == 1.0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		    v50 = *UnityEngine::Material::GetColor(
		             &v52,
		             material,
		             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_FresnelColor,
		             0LL);
		    v51 = *(Color *)sub_183C6CBA0(&v52, &v50);
		    v20 = fmaxf(UnityEngine::Color::get_grayscale(&v51, v36), v20);
		    v51 = *v37;
		    v38 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Color, &v51);
		    System::Text::StringBuilder::AppendFormat(v14, (String *)"fresnelColor(gamma后):{0}\n", v38, 0LL);
		    ++*featureCount;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		  if ( UnityEngine::Material::GetFloatImpl(
		         material,
		         TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseEdgeColor,
		         0LL) == 1.0 )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXShaderIDs);
		    v50 = *UnityEngine::Material::GetColor(
		             &v52,
		             material,
		             TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_EdgeColor,
		             0LL);
		    v50 = *(Color *)sub_183C6CBA0(&v52, &v50);
		    if ( UnityEngine::Material::GetFloatImpl(
		           material,
		           TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_EdgeColorMode,
		           0LL) > 0.5 )
		      v20 = v20 + UnityEngine::Color::get_grayscale(&v50, v39);
		    else
		      v20 = v20 * UnityEngine::Color::get_grayscale(&v50, v39);
		    v49 = v20;
		    v40 = (Object *)il2cpp_value_box_0(TypeInfo::System::Single, &v49);
		    System::Text::StringBuilder::AppendFormat(v14, (String *)"EdgeColor(gamma后):{0}\n", v40, 0LL);
		    ++*featureCount;
		  }
		  sub_1800036A0(TypeInfo::System::Math);
		  v49 = v17;
		  v41 = (Object *)il2cpp_value_box_0(TypeInfo::System::Single, &v49);
		  System::Text::StringBuilder::AppendFormat(v14, (String *)"expIntensity:{0}\n", v41, 0LL);
		  *log = (String *)sub_180032CB0(3LL, v14);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)log, v42, v43, v44, v48);
		  v45 = System::Math::Max(0.0, v20 - v16, 0LL);
		  return System::Math::Max(1.0, (float)(v45 * v17) + v20, 0LL);
		}
		
	}
}
