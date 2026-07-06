using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class VolumetricPipelineRT
	{
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000025D2 File Offset: 0x000007D2
		public RenderTexture RT
		{
			get
			{
				// // RenderTexture get_RT()
				// RenderTexture *HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(VolumetricPipelineRT *this, MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(this, 0LL);
				//   return this.fields.rt;
				// }
				// 
				return null;
			}
		}

		public VolumetricPipelineRT(string name, RTLifeCycle life)
		{
		}

		public void Create(int width, int height, RenderTextureFormat format, [MetadataOffset(Offset = "0x01F91E03")] bool enableMipmap = false)
		{
			// // Void Create(Int32, Int32, RenderTextureFormat, Boolean)
			// void HG::Rendering::Runtime::VolumetricPipelineRT::Create(
			//         VolumetricPipelineRT *this,
			//         int32_t width,
			//         int32_t height,
			//         RenderTextureFormat__Enum format,
			//         bool enableMipmap,
			//         MethodInfo *method)
			// {
			//   int32_t v10; // edx
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   RenderTextureDescriptor v16; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   memset(&v16, 0, sizeof(v16));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4436, 0LL) )
			//   {
			//     UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(&v16, width, height, format, 0LL);
			//     v16._dimension_k__BackingField = 2;
			//     UnityEngine::RenderTextureDescriptor::set_colorFormat(&v16, format, 0LL);
			//     v10 = 24;
			//     if ( format != RenderTextureFormat__Enum_Depth )
			//       v10 = 0;
			//     UnityEngine::RenderTextureDescriptor::set_depthBufferBits(&v16, v10, 0LL);
			//     v16._volumeDepth_k__BackingField = 1;
			//     UnityEngine::RenderTextureDescriptor::set_useMipMap(&v16, enableMipmap, 0LL);
			//     if ( this )
			//     {
			//       memoryless_k__BackingField = v16._memoryless_k__BackingField;
			//       v14 = *(_OWORD *)&v16._mipCount_k__BackingField;
			//       *(_OWORD *)&this.fields.Desc._width_k__BackingField = *(_OWORD *)&v16._width_k__BackingField;
			//       v15 = *(_OWORD *)&v16._dimension_k__BackingField;
			//       *(_OWORD *)&this.fields.Desc._mipCount_k__BackingField = v14;
			//       *(_OWORD *)&this.fields.Desc._dimension_k__BackingField = v15;
			//       this.fields.Desc._memoryless_k__BackingField = memoryless_k__BackingField;
			//       this.fields.bUsed = 0;
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4436, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1271(Patch, (Object *)this, width, height, format, enableMipmap, 0LL);
			// }
			// 
		}

		public void Release(bool full)
		{
			// // Void Release(Boolean)
			// void HG::Rendering::Runtime::VolumetricPipelineRT::Release(VolumetricPipelineRT *this, bool full, MethodInfo *method)
			// {
			//   BOOL v4; // edi
			//   int v5; // eax
			//   __int64 v6; // rax
			//   NotImplementedException *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   NotImplementedException *v10; // rbx
			//   __int64 v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = full;
			//   if ( !byte_18D919816 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919816 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2877, 0LL) )
			//   {
			//     v5 = v4;
			//     if ( this.fields.lifeCycle != 2 )
			//       v5 = 1;
			//     if ( !v5 && this.fields.bUsed )
			//       goto LABEL_14;
			//     if ( !this.fields.lifeCycle )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseTemporaryTexture(&this.fields.rt, 0LL);
			//       goto LABEL_14;
			//     }
			//     if ( this.fields.lifeCycle != 1 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseRenderTexture(&this.fields.rt, 0LL);
			// LABEL_14:
			//       this.fields.bUsed = 0;
			//       return;
			//     }
			//     v6 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
			//     v7 = (NotImplementedException *)sub_180004920(v6);
			//     v10 = v7;
			//     if ( v7 )
			//     {
			//       System::NotImplementedException::NotImplementedException(v7, 0LL);
			//       v11 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VolumetricPipelineRT::Release);
			//       sub_18000F7C0(v10, v11);
			//     }
			// LABEL_16:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2877, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, v4, 0LL);
			// }
			// 
		}

		private void CreateIfNeeded()
		{
			// // Void CreateIfNeeded()
			// void HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded(VolumetricPipelineRT *this, MethodInfo *method)
			// {
			//   int32_t memoryless_k__BackingField; // ebx
			//   __int64 v4; // rdx
			//   RenderTexture *rt; // rbx
			//   __int64 v6; // rax
			//   NotImplementedException *v7; // rax
			//   Texture *v8; // rcx
			//   NotImplementedException *v9; // rbx
			//   __int64 v10; // rax
			//   int32_t v11; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v16; // [rsp+20h] [rbp-78h]
			//   __int128 v17; // [rsp+20h] [rbp-78h]
			//   __int128 v18; // [rsp+30h] [rbp-68h]
			//   __int128 v19; // [rsp+30h] [rbp-68h]
			//   __int128 v20; // [rsp+40h] [rbp-58h]
			//   __int128 v21; // [rsp+40h] [rbp-58h]
			//   RenderTextureDescriptor v22; // [rsp+50h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919817 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//     byte_18D919817 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4635, 0LL) )
			//   {
			//     if ( this.fields.bUsed )
			//       return;
			//     if ( this.fields.lifeCycle )
			//     {
			//       if ( this.fields.lifeCycle == 1 )
			//       {
			//         v6 = sub_18000F7E0(&TypeInfo::System::NotImplementedException);
			//         v7 = (NotImplementedException *)sub_180004920(v6);
			//         v9 = v7;
			//         if ( v7 )
			//         {
			//           System::NotImplementedException::NotImplementedException(v7, 0LL);
			//           v10 = sub_18000F7E0(MethodInfo::HG::Rendering::Runtime::VolumetricPipelineRT::CreateIfNeeded);
			//           sub_18000F7C0(v9, v10);
			//         }
			//         goto LABEL_15;
			//       }
			//       memoryless_k__BackingField = this.fields.Desc._memoryless_k__BackingField;
			//       v16 = *(_OWORD *)&this.fields.Desc._width_k__BackingField;
			//       v18 = *(_OWORD *)&this.fields.Desc._mipCount_k__BackingField;
			//       v20 = *(_OWORD *)&this.fields.Desc._dimension_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v22._memoryless_k__BackingField = memoryless_k__BackingField;
			//       *(_OWORD *)&v22._width_k__BackingField = v16;
			//       *(_OWORD *)&v22._mipCount_k__BackingField = v18;
			//       *(_OWORD *)&v22._dimension_k__BackingField = v20;
			//       if ( HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded(&this.fields.rt, &v22, 0LL) )
			//       {
			//         rt = this.fields.rt;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//         HG::Rendering::Runtime::VolumetricSDFUtils::ClearRenderTarget(rt, 0LL);
			//       }
			//     }
			//     else
			//     {
			//       v11 = this.fields.Desc._memoryless_k__BackingField;
			//       v21 = *(_OWORD *)&this.fields.Desc._width_k__BackingField;
			//       v19 = *(_OWORD *)&this.fields.Desc._mipCount_k__BackingField;
			//       v17 = *(_OWORD *)&this.fields.Desc._dimension_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
			//       v22._memoryless_k__BackingField = v11;
			//       *(_OWORD *)&v22._width_k__BackingField = v21;
			//       *(_OWORD *)&v22._mipCount_k__BackingField = v19;
			//       *(_OWORD *)&v22._dimension_k__BackingField = v17;
			//       this.fields.rt = HG::Rendering::Runtime::VolumetricSDFUtils::GetTemporaryTexture(&v22, 0LL);
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.rt, v12, v13, v14, (MethodInfo *)v17, *((MethodInfo **)&v17 + 1));
			//     }
			//     v8 = (Texture *)this.fields.rt;
			//     if ( v8 )
			//     {
			//       UnityEngine::Texture::set_filterMode(v8, FilterMode__Enum_Bilinear, 0LL);
			//       this.fields.bUsed = 1;
			//       return;
			//     }
			// LABEL_15:
			//     sub_180B536AC(v8, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4635, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void MarkUsed()
		{
			// // Void MarkUsed()
			// void HG::Rendering::Runtime::VolumetricPipelineRT::MarkUsed(VolumetricPipelineRT *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4636, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4636, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.bUsed = 1;
			//   }
			// }
			// 
		}

		public override string ToString()
		{
			// // String ToString()
			// String *HG::Rendering::Runtime::VolumetricPipelineRT::ToString(VolumetricPipelineRT *this, MethodInfo *method)
			// {
			//   __int64 v3; // r8
			//   Object *Name; // rbx
			//   Object *v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   bool bUsed; // [rsp+50h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919818 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Boolean);
			//     sub_18003C530(&off_18D521898);
			//     byte_18D919818 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4637, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4637, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Name = (Object *)this.fields.Name;
			//     bUsed = this.fields.bUsed;
			//     v5 = (Object *)il2cpp_value_box_0(TypeInfo::System::Boolean, &bUsed, v3);
			//     return System::String::Format((String *)"Name:{0}, Used:{1}, rt:{2}", Name, v5, (Object *)this.fields.rt, 0LL);
			//   }
			// }
			// 
			return null;
		}

		public string <>iFixBaseProxy_ToString()
		{
			// // String ObjectToString()
			// String *IFix::Core::AnonymousStorey::ObjectToString(AnonymousStorey *this, MethodInfo *method)
			// {
			//   return System::Object::ToString((Object *)this, 0LL);
			// }
			// 
			return null;
		}

		private string Name;

		private RenderTextureDescriptor Desc;

		private RTLifeCycle lifeCycle;

		private bool bUsed;

		private RenderTexture rt;
	}
}
