using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGShadowConstantBufferUtils
	{
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000025D2 File Offset: 0x000007D2
		public static CBHandle ShadowBufferHandle
		{
			get
			{
				// // CBHandle get_ShadowBufferHandle()
				// CBHandle *HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_ShadowBufferHandle(
				//         CBHandle *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   HGShadowConstantBufferUtils__StaticFields *static_fields; // rdx
				//   CBHandle *result; // rax
				//   void *v5; // xmm1_8
				// 
				//   if ( !byte_18D919EAA )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EAA = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
				//   result = retstr;
				//   v5 = *(void **)&static_fields[29].shadowData._PunctualLightShadowParams.FixedElementField;
				//   *(_OWORD *)&retstr.bufferId = *(_OWORD *)&static_fields[29].shadowData._DirectionalShadowParams2.z;
				//   retstr.ptr = v5;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00002650 File Offset: 0x00000850
		public static uint shadowBufferID
		{
			get
			{
				// // UInt32 get_shadowBufferID()
				// uint32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferID(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGShadowConstantBufferUtils__Class *v2; // rax
				// 
				//   if ( !byte_18D919EAC )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EAC = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//   }
				//   return LODWORD(v2.static_fields[29].shadowData._DirectionalShadowParams2.z);
				// }
				// 
				return 0U;
			}
		}

		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00002608 File Offset: 0x00000808
		public static int shadowBufferOffset
		{
			get
			{
				// // Int32 get_shadowBufferOffset()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferOffset(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGShadowConstantBufferUtils__Class *v2; // rax
				// 
				//   if ( !byte_18D919EAD )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EAD = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//   }
				//   return LODWORD(v2.static_fields[29].shadowData._DirectionalShadowParams2.w);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00002608 File Offset: 0x00000808
		public static int csmSectionOffset
		{
			get
			{
				// // Int32 get_csmSectionOffset()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionOffset(MethodInfo *method)
				// {
				//   struct HGShadowConstantBufferUtils__Class *v1; // rcx
				//   struct Il2CppType *v2; // rbx
				//   Type *TypeFromHandle; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919EAE )
				//   {
				//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
				//     sub_18003C530(&TypeInfo::System::Type);
				//     sub_18003C530(&off_18D5F2DD0);
				//     byte_18D919EAE = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1863, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1863, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.x) == -1 )
				//     {
				//       v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
				//       sub_180002C70(TypeInfo::System::Type);
				//       TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
				//       sub_180002C70(TypeInfo::System::Runtime::InteropServices::Marshal);
				//       LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(TypeFromHandle, "_CSMWorldToShadow");
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//       LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.x) = (_DWORD)TypeFromHandle;
				//       v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     }
				//     sub_180002C70(v1);
				//     return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.x);
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00002608 File Offset: 0x00000808
		public static int punctualLightShadowSectionOffset
		{
			get
			{
				// // Int32 get_punctualLightShadowSectionOffset()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(MethodInfo *method)
				// {
				//   struct HGShadowConstantBufferUtils__Class *v1; // rcx
				//   struct Il2CppType *v2; // rbx
				//   Type *TypeFromHandle; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919EAF )
				//   {
				//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
				//     sub_18003C530(&TypeInfo::System::Type);
				//     sub_18003C530(&off_18D5F2DF0);
				//     byte_18D919EAF = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1864, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1864, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.y) == -1 )
				//     {
				//       v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
				//       sub_180002C70(TypeInfo::System::Type);
				//       TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
				//       sub_180002C70(TypeInfo::System::Runtime::InteropServices::Marshal);
				//       LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(
				//                                   TypeFromHandle,
				//                                   "_PunctualLightWorldToShadow");
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//       LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.y) = (_DWORD)TypeFromHandle;
				//       v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     }
				//     sub_180002C70(v1);
				//     return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.y);
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00002608 File Offset: 0x00000808
		public static int characterShadowSectionOffset
		{
			get
			{
				// // Int32 get_characterShadowSectionOffset()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(MethodInfo *method)
				// {
				//   struct HGShadowConstantBufferUtils__Class *v1; // rcx
				//   struct Il2CppType *v2; // rbx
				//   Type *TypeFromHandle; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919EB0 )
				//   {
				//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
				//     sub_18003C530(&TypeInfo::System::Type);
				//     sub_18003C530(&off_18D5F3040);
				//     byte_18D919EB0 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1865, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1865, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.z) == -1 )
				//     {
				//       v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
				//       sub_180002C70(TypeInfo::System::Type);
				//       TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
				//       sub_180002C70(TypeInfo::System::Runtime::InteropServices::Marshal);
				//       LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(
				//                                   TypeFromHandle,
				//                                   "_CharacterWorldToShadow");
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//       LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.z) = (_DWORD)TypeFromHandle;
				//       v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     }
				//     sub_180002C70(v1);
				//     return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.z);
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00002608 File Offset: 0x00000808
		public static int asmShadowSectionOffset
		{
			get
			{
				// // Int32 get_asmShadowSectionOffset()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(MethodInfo *method)
				// {
				//   struct HGShadowConstantBufferUtils__Class *v1; // rcx
				//   struct Il2CppType *v2; // rbx
				//   Type *TypeFromHandle; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919EB1 )
				//   {
				//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
				//     sub_18003C530(&TypeInfo::System::Type);
				//     sub_18003C530(&off_18D5F3080);
				//     byte_18D919EB1 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1866, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1866, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     if ( LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.w) == -1 )
				//     {
				//       v2 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
				//       sub_180002C70(TypeInfo::System::Type);
				//       TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v2, 0LL);
				//       sub_180002C70(TypeInfo::System::Runtime::InteropServices::Marshal);
				//       LODWORD(TypeFromHandle) = System::Runtime::InteropServices::Marshal::OffsetOf(
				//                                   TypeFromHandle,
				//                                   "_ASMWorldToShadowBaseMatrix");
				//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//       LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.w) = (_DWORD)TypeFromHandle;
				//       v1 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils;
				//     }
				//     sub_180002C70(v1);
				//     return LODWORD(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowTexelSize.w);
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00002608 File Offset: 0x00000808
		public static int shadowDataSize
		{
			get
			{
				// // Int32 get_shadowDataSize()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(MethodInfo *method)
				// {
				//   struct Il2CppType *v1; // rbx
				//   Type *TypeFromHandle; // rbx
				// 
				//   if ( !byte_18D919EB2 )
				//   {
				//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData);
				//     sub_18003C530(&TypeInfo::System::Runtime::InteropServices::Marshal);
				//     sub_18003C530(&TypeInfo::System::Type);
				//     byte_18D919EB2 = 1;
				//   }
				//   v1 = TypeRef::HG::Rendering::Runtime::HGShadowConstantBufferUtils::HGShadowConstantBufferData;
				//   sub_180002C70(TypeInfo::System::Type);
				//   TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v1, 0LL);
				//   sub_180002C70(TypeInfo::System::Runtime::InteropServices::Marshal);
				//   return sub_1800981B0(TypeFromHandle);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00002608 File Offset: 0x00000808
		public static int csmSectionSize
		{
			get
			{
				// // Int32 get_csmSectionSize()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionSize(MethodInfo *method)
				// {
				//   int32_t punctualLightShadowSectionOffset; // ebx
				// 
				//   if ( !byte_18D919EB3 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EB3 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//   punctualLightShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(0LL);
				//   return punctualLightShadowSectionOffset
				//        - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionOffset(0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00002608 File Offset: 0x00000808
		public static int punctualLightShadowSectionSize
		{
			get
			{
				// // Int32 get_punctualLightShadowSectionSize()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionSize(MethodInfo *method)
				// {
				//   int32_t characterShadowSectionOffset; // ebx
				// 
				//   if ( !byte_18D919EB4 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EB4 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//   characterShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(0LL);
				//   return characterShadowSectionOffset
				//        - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00002608 File Offset: 0x00000808
		public static int characterShadowSectionSize
		{
			get
			{
				// // Int32 get_characterShadowSectionSize()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionSize(MethodInfo *method)
				// {
				//   int32_t asmShadowSectionOffset; // ebx
				// 
				//   if ( !byte_18D919EB5 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EB5 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//   asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(0LL);
				//   return asmShadowSectionOffset
				//        - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00002608 File Offset: 0x00000808
		public static int asmSectionSize
		{
			get
			{
				// // Int32 get_asmSectionSize()
				// int32_t HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmSectionSize(MethodInfo *method)
				// {
				//   int32_t shadowDataSize; // ebx
				// 
				//   if ( !byte_18D919EB6 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//     byte_18D919EB6 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
				//   shadowDataSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
				//   return shadowDataSize - HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(0LL);
				// }
				// 
				return 0;
			}
		}

		public static void AllocateShadowBuffer(ScriptableRenderContext srpContext)
		{
			// // Void AllocateShadowBuffer(ScriptableRenderContext)
			// void HG::Rendering::Runtime::HGShadowConstantBufferUtils::AllocateShadowBuffer(
			//         ScriptableRenderContext srpContext,
			//         MethodInfo *method)
			// {
			//   int32_t shadowDataSize; // ebx
			//   CBHandle *v3; // rax
			//   void *ptr; // xmm0_8
			//   HGShadowConstantBufferUtils__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   CBHandle v9; // [rsp+20h] [rbp-28h] BYREF
			//   ScriptableRenderContext P0; // [rsp+50h] [rbp+8h] BYREF
			// 
			//   P0.m_Ptr = srpContext.m_Ptr;
			//   if ( !byte_18D919EAB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919EAB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1862, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1862, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_724(Patch, P0, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     shadowDataSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     v3 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v9, &P0, shadowDataSize, 0LL);
			//     ptr = v3.ptr;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//     *(_OWORD *)&static_fields[29].shadowData._DirectionalShadowParams2.z = *(_OWORD *)&v3.bufferId;
			//     *(_QWORD *)&static_fields[29].shadowData._PunctualLightShadowParams.FixedElementField = ptr;
			//   }
			// }
			// 
		}

		public static void SetGlobalConstantBuffer(HGShadowConstantBufferUtils.ShadowConstantBufferSection section, CommandBuffer cmd)
		{
			// // Void SetGlobalConstantBuffer(HGShadowConstantBufferUtils+ShadowConstantBufferSection, CommandBuffer)
			// void HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalConstantBuffer(
			//         HGShadowConstantBufferUtils_ShadowConstantBufferSection__Enum section,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   int32_t asmShadowSectionOffset; // edi
			//   unsigned __int32 v6; // ebx
			//   unsigned __int32 v7; // ebx
			//   int32_t v8; // ebx
			//   int32_t asmSectionSize; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			// 
			//   asmShadowSectionOffset = 0;
			//   if ( !byte_18D919EB7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     byte_18D919EB7 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1867, 0LL) )
			//   {
			//     if ( section )
			//     {
			//       v6 = section - 1;
			//       if ( v6 )
			//       {
			//         v7 = v6 - 1;
			//         if ( v7 )
			//         {
			//           if ( v7 != 1 )
			//           {
			//             v8 = 0;
			// LABEL_14:
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//             Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//               (Void *)(*(_QWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[29].shadowData._PunctualLightShadowParams.FixedElementField
			//                      + asmShadowSectionOffset),
			//               (Void *)TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields
			//             + asmShadowSectionOffset,
			//               v8,
			//               0LL);
			//             HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalShadowCB(cmd, 0LL);
			//             return;
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//           asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmShadowSectionOffset(0LL);
			//           asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_asmSectionSize(0LL);
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//           asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionOffset(0LL);
			//           asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_characterShadowSectionSize(0LL);
			//         }
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionOffset(0LL);
			//         asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_punctualLightShadowSectionSize(0LL);
			//       }
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//       asmShadowSectionOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionOffset(0LL);
			//       asmSectionSize = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_csmSectionSize(0LL);
			//     }
			//     v8 = asmSectionSize;
			//     goto LABEL_14;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1867, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v12, v11);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_20((ILFixDynamicMethodWrapper_20 *)Patch, section, (Object *)cmd, 0LL);
			// }
			// 
		}

		public static void SetGlobalShadowCB(CommandBuffer cmd)
		{
			// // Void SetGlobalShadowCB(CommandBuffer)
			// void HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalShadowCB(CommandBuffer *cmd, MethodInfo *method)
			// {
			//   uint32_t shadowBufferID; // edi
			//   int32_t ShadowData; // esi
			//   int32_t shadowBufferOffset; // ebp
			//   int32_t size; // eax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919EB8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     byte_18D919EB8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1868, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     shadowBufferID = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferID(0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     ShadowData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields.ShadowData;
			//     shadowBufferOffset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferOffset(0LL);
			//     size = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
			//     if ( cmd )
			//     {
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//         cmd,
			//         shadowBufferID,
			//         ShadowData,
			//         shadowBufferOffset,
			//         size,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1868, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)cmd, 0LL);
			// }
			// 
		}

		public static void SetGlobalShadowCBForComputeShader(CommandBuffer cmd, ComputeShader cs)
		{
			// // Void SetGlobalShadowCBForComputeShader(CommandBuffer, ComputeShader)
			// void HG::Rendering::Runtime::HGShadowConstantBufferUtils::SetGlobalShadowCBForComputeShader(
			//         CommandBuffer *cmd,
			//         ComputeShader *cs,
			//         MethodInfo *method)
			// {
			//   int32_t ShadowData; // esi
			//   uint32_t shadowBufferID; // ebp
			//   int32_t offset; // r14d
			//   int32_t size; // eax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919EB9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     byte_18D919EB9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1869, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     ShadowData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields.ShadowData;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     shadowBufferID = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferID(0LL);
			//     offset = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowBufferOffset(0LL);
			//     size = HG::Rendering::Runtime::HGShadowConstantBufferUtils::get_shadowDataSize(0LL);
			//     if ( cmd )
			//     {
			//       UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//         cmd,
			//         cs,
			//         ShadowData,
			//         shadowBufferID,
			//         offset,
			//         size,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v10, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1869, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)cmd, (Object *)cs, 0LL);
			// }
			// 
		}

		private const int MAX_CASCADE_COUNT = 4;

		private const int MAX_PUNCTUAL_LIGHT_SHADOW_CASTER_COUNT = 56;

		private const int MAX_CHARACTER_SHADOWMAP_COUNT = 15;

		private const int ASM_TILE_COUNT = 256;

		private const int FLOAT_COUNT_IN_MATRIX = 16;

		private const int FLOAT_COUNT_IN_VECTOR = 4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGShadowConstantBufferUtils.HGShadowConstantBufferData shadowData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CB0")]
		private static CBHandle s_shadowBufferHandle;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CC8")]
		private static int _CSMSectionOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CCC")]
		private static int _PunctualLightShadowSectionOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CD0")]
		private static int _CharacterShadowSectionOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2CD4")]
		private static int _ASMSectionOffset;

		public enum ShadowConstantBufferSection
		{
			CSM,
			PunctualLight,
			Character,
			ASM
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 11440)]
		public struct HGShadowConstantBufferData
		{
			[FixedBuffer(typeof(float), 80)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CSMWorldToShadow>e__FixedBuffer _CSMWorldToShadow;

			[FixedBuffer(typeof(float), 16)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CSMShadowSplitSpheres>e__FixedBuffer _CSMShadowSplitSpheres;

			[FixedBuffer(typeof(float), 16)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CSMShadowBiases>e__FixedBuffer _CSMShadowBiases;

			[FixedBuffer(typeof(float), 16)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CSMShadowAtlasParams>e__FixedBuffer _CSMShadowAtlasParams;

			public Vector4 _CSMShadowTexelSize;

			public Vector4 _CSMPenumbraSizes;

			public Vector4 _DirectionalShadowParams;

			public Vector4 _DirectionalShadowParams2;

			[FixedBuffer(typeof(float), 112)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_Paddings0>e__FixedBuffer _Paddings0;

			[FixedBuffer(typeof(float), 896)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_PunctualLightWorldToShadow>e__FixedBuffer _PunctualLightWorldToShadow;

			[FixedBuffer(typeof(float), 224)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_PunctualLightShadowParams>e__FixedBuffer _PunctualLightShadowParams;

			[FixedBuffer(typeof(float), 224)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_PunctualLightShadowParams2>e__FixedBuffer _PunctualLightShadowParams2;

			public Vector4 _PunctualLightShadowTexelSize;

			[FixedBuffer(typeof(float), 188)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_Paddings1>e__FixedBuffer _Paddings1;

			[FixedBuffer(typeof(float), 240)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CharacterWorldToShadow>e__FixedBuffer _CharacterWorldToShadow;

			[FixedBuffer(typeof(float), 60)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CharacterShadowBiases>e__FixedBuffer _CharacterShadowBiases;

			[FixedBuffer(typeof(float), 60)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CharacterShadowLightDir>e__FixedBuffer _CharacterShadowLightDir;

			[FixedBuffer(typeof(float), 60)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_CharacterShadowAtlasParams>e__FixedBuffer _CharacterShadowAtlasParams;

			public Vector4 _CharacterShadowTexelSize;

			public Vector4 _CharacterShadowParams;

			[FixedBuffer(typeof(float), 84)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_Paddings2>e__FixedBuffer _Paddings2;

			public Matrix4x4 _ASMWorldToShadowBaseMatrix;

			public Matrix4x4 _ASMIndirectWorldToShadow;

			public Vector4 _ASMParams;

			public Vector4 _ASMParams2;

			public Vector4 _ASMShadowTexelSize;

			[FixedBuffer(typeof(float), 512)]
			public HGShadowConstantBufferUtils.HGShadowConstantBufferData.<_ASMIndirectParams>e__FixedBuffer _ASMIndirectParams;

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 320)]
			public struct <_CSMWorldToShadow>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
			public struct <_CSMShadowSplitSpheres>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
			public struct <_CSMShadowBiases>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
			public struct <_CSMShadowAtlasParams>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 448)]
			public struct <_Paddings0>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 3584)]
			public struct <_PunctualLightWorldToShadow>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 896)]
			public struct <_PunctualLightShadowParams>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 896)]
			public struct <_PunctualLightShadowParams2>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 752)]
			public struct <_Paddings1>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 960)]
			public struct <_CharacterWorldToShadow>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 240)]
			public struct <_CharacterShadowBiases>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 240)]
			public struct <_CharacterShadowLightDir>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 240)]
			public struct <_CharacterShadowAtlasParams>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 336)]
			public struct <_Paddings2>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 2048)]
			public struct <_ASMIndirectParams>e__FixedBuffer
			{
				public float FixedElementField;
			}
		}
	}
}
