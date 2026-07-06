using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace HG.Rendering.Runtime
{
	public class UIImageBlurManager
	{
		public UIImageBlurManager()
		{
			// // UIImageBlurManager()
			// void HG::Rendering::Runtime::UIImageBlurManager::UIImageBlurManager(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   struct HGShaderIDs__Class *v3; // rax
			// 
			//   if ( !byte_18D8EDBA5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D8EDBA5 = 1;
			//   }
			//   v3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs, method);
			//     v3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   }
			//   this.fields.m_uiImageBlurTexID = v3.static_fields._UIImageBlurTex;
			// }
			// 
		}

		public bool ShouldRenderUIImageBlur()
		{
			// // Boolean ShouldRenderUIImageBlur()
			// bool HG::Rendering::Runtime::UIImageBlurManager::ShouldRenderUIImageBlur(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object_1 *m_source; // rdi
			//   __int64 v10; // rdx
			//   Object_1 *m_target; // rbx
			// 
			//   if ( !byte_18D8EDBA4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBA4 = 1;
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 972 )
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
			//       if ( v7.max_length.size <= 0x3CCu )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v7[27].vector[0] )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(972, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     }
			// LABEL_11:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( !this.fields.m_shouldRenderUIBlurFlag )
			//     return 0;
			//   m_source = (Object_1 *)this.fields.m_source;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !UnityEngine::Object::op_Inequality(m_source, 0LL, 0LL) )
			//     return 0;
			//   m_target = (Object_1 *)this.fields.m_target;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v10);
			//   return UnityEngine::Object::op_Inequality(m_target, 0LL, 0LL);
			// }
			// 
			return default(bool);
		}

		public void CloseUIBlurPass()
		{
			// // Void CloseUIBlurPass()
			// void HG::Rendering::Runtime::UIImageBlurManager::CloseUIBlurPass(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(977, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(977, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_shouldRenderUIBlurFlag = 0;
			//   }
			// }
			// 
		}

		public bool OpenUIBlurPass(Texture src, RenderTexture dest, float scale, Rect rect)
		{
			// // Boolean OpenUIBlurPass(Texture, RenderTexture, Single, Rect)
			// bool HG::Rendering::Runtime::UIImageBlurManager::OpenUIBlurPass(
			//         UIImageBlurManager *this,
			//         Texture *src,
			//         RenderTexture *dest,
			//         float scale,
			//         Rect *rect,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   bool result; // al
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   MethodInfo *v18; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v19; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v20; // [rsp+28h] [rbp-40h]
			//   MethodInfo *v21; // [rsp+28h] [rbp-40h]
			//   Rect v22; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919770 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D520550);
			//     byte_18D919770 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3535, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3535, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v16);
			//     v22 = *rect;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1255(
			//              Patch,
			//              (Object *)this,
			//              (Object *)src,
			//              (Object *)dest,
			//              scale,
			//              &v22,
			//              0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)src, 0LL, 0LL)
			//       || (sub_180002C70(TypeInfo::UnityEngine::Object), UnityEngine::Object::op_Equality((Object_1 *)dest, 0LL, 0LL)) )
			//     {
			//       HG::Rendering::HGRPLogger::LogWarning((String *)"Src or Dest Texture is null. ", 0LL);
			//       return 0;
			//     }
			//     else
			//     {
			//       this.fields.m_shouldRenderUIBlurFlag = 1;
			//       this.fields.m_source = src;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_source, v9, v10, v11, v18, v20);
			//       this.fields.m_target = dest;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_target, v12, v13, v14, v19, v21);
			//       result = 1;
			//       this.fields.m_scale = scale;
			//       this.fields.m_rect = *rect;
			//     }
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public Texture GetSource()
		{
			// // Texture GetSource()
			// Texture *HG::Rendering::Runtime::UIImageBlurManager::GetSource(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(973, 0LL) )
			//     return this.fields.m_source;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(973, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_174(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public RenderTexture GetTarget()
		{
			// // RenderTexture GetTarget()
			// RenderTexture *HG::Rendering::Runtime::UIImageBlurManager::GetTarget(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(974, 0LL) )
			//     return this.fields.m_target;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(974, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_360(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public float GetScale()
		{
			// // Single GetScale()
			// float HG::Rendering::Runtime::UIImageBlurManager::GetScale(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(976, 0LL) )
			//     return this.fields.m_scale;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(976, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0f;
		}

		public Rect GetRect()
		{
			// // Rect GetRect()
			// Rect *HG::Rendering::Runtime::UIImageBlurManager::GetRect(
			//         Rect *__return_ptr retstr,
			//         UIImageBlurManager *this,
			//         MethodInfo *method)
			// {
			//   Rect m_rect; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Rect *result; // rax
			//   Rect v10; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(975, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(975, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     m_rect = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_258(&v10, Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_rect = this.fields.m_rect;
			//   }
			//   result = retstr;
			//   *retstr = m_rect;
			//   return result;
			// }
			// 
			return null;
		}

		public int GetUIImageBlurTexID()
		{
			// // Int32 GetUIImageBlurTexID()
			// int32_t HG::Rendering::Runtime::UIImageBlurManager::GetUIImageBlurTexID(UIImageBlurManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3536, 0LL) )
			//     return this.fields.m_uiImageBlurTexID;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3536, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0;
		}

		public GraphicsFormat GetUIImageBlurTexFormat()
		{
			// // GraphicsFormat GetUIImageBlurTexFormat()
			// GraphicsFormat__Enum HG::Rendering::Runtime::UIImageBlurManager::GetUIImageBlurTexFormat(
			//         UIImageBlurManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3537, 0LL) )
			//     return 8;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3537, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return (GraphicsFormat)GraphicsFormat.None;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<UIImageBlurManager> s_Instance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly UIImageBlurManager instance;

		private bool m_shouldRenderUIBlurFlag;

		private Texture m_source;

		private RenderTexture m_target;

		private float m_scale;

		private int m_uiImageBlurTexID;

		private Rect m_rect;
	}
}
