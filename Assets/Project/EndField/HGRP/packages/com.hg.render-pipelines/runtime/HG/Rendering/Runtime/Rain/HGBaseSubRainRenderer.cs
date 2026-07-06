using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime.Rain
{
	public abstract class HGBaseSubRainRenderer
	{
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x000025D2 File Offset: 0x000007D2
		internal virtual HGRainParams[] RainParamsArray
		{
			get
			{
				// // HGRainParams[] get_RainParamsArray()
				// HGRainParams__Array *__noreturn HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::get_RainParamsArray(
				//         HGBaseSubRainRenderer *this,
				//         MethodInfo *method)
				// {
				//   __int64 v2; // rax
				//   NotImplementedException *v3; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   NotImplementedException *v6; // rbx
				//   __int64 v7; // rax
				// 
				//   v2 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
				//   v3 = (NotImplementedException *)sub_180004920(v2);
				//   v6 = v3;
				//   if ( !v3 )
				//     sub_180B536AC(v5, v4);
				//   System::NotImplementedException::NotImplementedException(v3, 0LL);
				//   v7 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::get_RainParamsArray);
				//   sub_18000F7C0(v6, v7);
				// }
				// 
				return null;
			}
		}

		protected HGBaseSubRainRenderer()
		{
			// // HGBaseSubRainRenderer()
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::HGBaseSubRainRenderer(
			//         HGBaseSubRainRenderer *this,
			//         MethodInfo *method)
			// {
			//   this.fields.enabled = 1;
			//   this.fields.rainRenderQueue = 3000;
			// }
			// 
		}

		internal abstract void PrepareResources(RainCommonResources commonResources);

		internal abstract void UpdateData(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime);

		internal virtual void PerFrameClear()
		{
			// // Void PerFrameClear()
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::PerFrameClear(
			//         HGBaseSubRainRenderer *this,
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
			//   if ( wrapperArray.max_length.size <= 624 )
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
			//   if ( v6.max_length.size <= 0x270u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( v6[17].vector[12] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(624, 0LL);
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

		internal virtual void SetMaterialData(in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::SetMaterialData(
			//         HGBaseSubRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(741, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(741, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_281(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
			//   }
			// }
			// 
		}

		internal virtual void UpdateRendererObjs(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::UpdateRendererObjs(
			//         HGBaseSubRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(744, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(744, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//       Patch,
			//       (Object *)this,
			//       (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			// }
			// 
		}

		internal virtual void Render(HGRenderGraphContext ctx, HGCamera hgCamera)
		{
			// // Void Render(HGRenderGraphContext, HGCamera)
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Render(
			//         HGBaseSubRainRenderer *this,
			//         HGRenderGraphContext *ctx,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4791, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4791, 0LL);
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
			// bool HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::IsDirty(HGBaseSubRainRenderer *this, MethodInfo *method)
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
			//   if ( wrapperArray.max_length.size <= 742 )
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
			//   if ( v7.max_length.size <= 0x2E6u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[20].vector[22] )
			//     return 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(742, 0LL);
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
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::ClearData(HGBaseSubRainRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(743, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(743, 0LL);
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
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose(HGBaseSubRainRenderer *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(494, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(494, 0LL);
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
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//         HGBaseSubRainRenderer *this,
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
			//   if ( !byte_18D8EDC2E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC2E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1329, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1329, 0LL);
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
			// void HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//         HGBaseSubRainRenderer *this,
			//         Material *mat,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D8EDC2F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC2F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1330, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1330, 0LL);
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

		internal HGRainRenderer.RainDropsType rainDropsType;

		internal bool enabled;

		internal int rainRenderQueue;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		protected static readonly HideFlags RAIN_RSC_HIDE_FLAGS;
	}
}
