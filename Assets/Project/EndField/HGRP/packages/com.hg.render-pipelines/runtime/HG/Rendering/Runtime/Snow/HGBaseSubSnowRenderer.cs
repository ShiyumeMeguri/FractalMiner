using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime.Snow
{
	public abstract class HGBaseSubSnowRenderer
	{
		protected HGBaseSubSnowRenderer()
		{
			// // HGBaseSubSnowRenderer()
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::HGBaseSubSnowRenderer(
			//         HGBaseSubSnowRenderer *this,
			//         MethodInfo *method)
			// {
			//   this.fields.enabled = 1;
			//   this.fields.snowRenderQueue = 3000;
			// }
			// 
		}

		internal abstract void PrepareResources(SnowCommonResources commonResources);

		internal abstract void UpdateData(in SnowCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime);

		internal virtual void PerFrameClear()
		{
			// // Void PerFrameClear()
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::PerFrameClear(
			//         HGBaseSubSnowRenderer *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rax
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
			//   if ( wrapperArray.max_length.size <= 632 )
			//     return;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v6 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( v6.max_length.size <= 0x278u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( v6[17].vector[20] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(632, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_8;
			//   }
			// }
			// 
		}

		internal virtual void SetMaterialData(in SnowCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(SnowCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::SetMaterialData(
			//         HGBaseSubSnowRenderer *this,
			//         SnowCommonRenderingParam **rainCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(757, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(757, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
			//   }
			// }
			// 
		}

		internal virtual void UpdateRendererObjs(in SnowCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(SnowCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::UpdateRendererObjs(
			//         HGBaseSubSnowRenderer *this,
			//         SnowCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(760, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(760, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//       Patch,
			//       (Object *)this,
			//       rainCommonRenderingParam,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			// }
			// 
		}

		internal virtual void Render(HGRenderGraphContext ctx, HGCamera hgCamera)
		{
			// // Void Render(HGRenderGraphContext, HGCamera)
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Render(
			//         HGBaseSubSnowRenderer *this,
			//         HGRenderGraphContext *ctx,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4773, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4773, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)ctx,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			// }
			// 
		}

		internal virtual bool IsDirty()
		{
			// // Boolean IsDirty()
			// bool HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::IsDirty(HGBaseSubSnowRenderer *this, MethodInfo *method)
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
			//   if ( wrapperArray.max_length.size <= 758 )
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
			//   if ( v7.max_length.size <= 0x2F6u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[21].vector[2] )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(758, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		internal virtual void ClearData()
		{
			// // Void ClearData()
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::ClearData(HGBaseSubSnowRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(759, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(759, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		internal virtual void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::Dispose(HGBaseSubSnowRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(497, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(497, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		protected void DisposeRendererObj(Transform objTrans)
		{
			// // Void DisposeRendererObj(Transform)
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::DisposeRendererObj(
			//         HGBaseSubSnowRenderer *this,
			//         Transform *objTrans,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rdx
			//   Object_1 *gameObject; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC1E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC1E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4774, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4774, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)objTrans,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_12;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)objTrans, 0LL, 0LL) )
			//   {
			//     if ( objTrans )
			//     {
			//       gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)objTrans, 0LL);
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       UnityEngine::Object::Destroy(gameObject, 0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v7, v6);
			//   }
			// }
			// 
		}

		protected void DisposeMaterial(Material mat)
		{
			// // Void DisposeMaterial(Material)
			// void HG::Rendering::Runtime::Snow::HGBaseSubSnowRenderer::DisposeMaterial(
			//         HGBaseSubSnowRenderer *this,
			//         Material *mat,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D8EDC1F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC1F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4775, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4775, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)mat,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)mat, 0LL, 0LL) )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//       UnityEngine::Object::Destroy((Object_1 *)mat, 0LL);
			//     }
			//   }
			// }
			// 
		}

		internal bool enabled;

		internal int snowRenderQueue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		protected static readonly HideFlags RSC_HIDE_FLAGS;
	}
}
