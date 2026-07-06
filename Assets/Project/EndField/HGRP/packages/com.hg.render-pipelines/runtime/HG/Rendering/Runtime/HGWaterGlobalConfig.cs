using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGWaterGlobalConfig : MonoBehaviour
	{
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x000025D2 File Offset: 0x000007D2
		public string scenePath
		{
			get
			{
				// // String get_scenePath()
				// String *HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   HGWaterGlobalConfigData *data; // rax
				//   String *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBB8 )
				//   {
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D8EDBB8 = 1;
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
				//     goto LABEL_12;
				//   if ( wrapperArray.max_length.size > 1961 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( v3 )
				//     {
				//       if ( LODWORD(v3._0.namespaze) <= 0x7A9 )
				//         sub_180070270(v3, wrapperArray);
				//       if ( !*(_QWORD *)&v3[41]._1.naturalAligment )
				//         goto LABEL_9;
				//       Patch = IFix::WrappersManagerImpl::GetPatch(1961, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
				//     }
				// LABEL_12:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				// LABEL_9:
				//   data = this.fields.data;
				//   if ( !data )
				//     return (String *)"";
				//   result = data.fields.scenePath;
				//   if ( !result )
				//     return (String *)"";
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector2 sceneCenterOffset
		{
			get
			{
				// // Vector2 get_sceneCenterOffset()
				// Vector2 HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffset(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   HGWaterGlobalConfigData *data; // rax
				// 
				//   data = this.fields.data;
				//   if ( data )
				//     return (Vector2)_mm_unpacklo_ps(
				//                       (__m128)LODWORD(data.fields.sceneCenterOffset.x),
				//                       (__m128)LODWORD(data.fields.sceneCenterOffset.y)).m128_u64[0];
				//   else
				//     return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector2 sceneCenterOffsetSector
		{
			get
			{
				// // Vector2 get_sceneCenterOffsetSector()
				// Vector2 HG::Rendering::Runtime::HGWaterGlobalConfig::get_sceneCenterOffsetSector(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   HGWaterGlobalConfigData *data; // rcx
				// 
				//   data = this.fields.data;
				//   if ( data )
				//     return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sceneCenterOffsetSector(data, 0LL);
				//   else
				//     return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x000025D2 File Offset: 0x000007D2
		public string[] sectorDataPaths
		{
			get
			{
				// // String[] get_sectorDataPaths()
				// String__Array *HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataPaths(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   HGWaterGlobalConfigData *data; // rax
				//   String__Array *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2897, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2897, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_909(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = this.fields.data;
				//     if ( !data )
				//       return this.fields.m_defaultSectorDataPaths;
				//     result = data.fields.sectorDataPaths;
				//     if ( !result )
				//       return this.fields.m_defaultSectorDataPaths;
				//   }
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000025D2 File Offset: 0x000007D2
		public long[] sectorDataAssetHashes
		{
			get
			{
				// // Int64[] get_sectorDataAssetHashes()
				// Int64__Array *HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataAssetHashes(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   HGWaterGlobalConfigData *data; // rax
				//   Int64__Array *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1965, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1965, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_760(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = this.fields.data;
				//     if ( !data )
				//       return this.fields.m_defaultSectorDataAssetHashes;
				//     result = data.fields.sectorDataAssetHashes;
				//     if ( !result )
				//       return this.fields.m_defaultSectorDataAssetHashes;
				//   }
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000025D2 File Offset: 0x000007D2
		public bool[] sectorDataExists
		{
			get
			{
				// // Boolean[] get_sectorDataExists()
				// Boolean__Array *HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorDataExists(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   HGWaterGlobalConfigData *data; // rax
				//   Boolean__Array *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1966, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1966, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_761(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = this.fields.data;
				//     if ( !data )
				//       return this.fields.m_defaultSectorDataExists;
				//     result = data.fields.sectorDataExists;
				//     if ( !result )
				//       return this.fields.m_defaultSectorDataExists;
				//   }
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00002608 File Offset: 0x00000808
		public int mapSize
		{
			get
			{
				// // Int32 get_mapSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   HGWaterGlobalConfigData *data; // rax
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
				//     goto LABEL_9;
				//   if ( wrapperArray.max_length.size > 946 )
				//   {
				//     if ( !v3._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(v3, wrapperArray);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
				//     if ( v3 )
				//     {
				//       if ( LODWORD(v3._0.namespaze) <= 0x3B2 )
				//         sub_180070270(v3, wrapperArray);
				//       if ( !v3[20]._0.declaringType )
				//         goto LABEL_7;
				//       Patch = IFix::WrappersManagerImpl::GetPatch(946, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				//     }
				// LABEL_9:
				//     sub_180B536AC(v3, wrapperArray);
				//   }
				// LABEL_7:
				//   data = this.fields.data;
				//   if ( data )
				//     return data.fields.mapSize;
				//   else
				//     return 2048;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorSize
		{
			get
			{
				// // Int32 get_sectorSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Object_1 *data; // rdi
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGWaterGlobalConfigData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBB9 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBB9 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(947, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(947, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v7 = this.fields.data;
				//       if ( v7 )
				//         return v7.fields.sectorSize;
				// LABEL_9:
				//       sub_180B536AC(v6, v5);
				//     }
				//     return 128;
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorXNum
		{
			get
			{
				// // Int32 get_sectorXNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorXNum(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   Object_1 *data; // rbx
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGWaterGlobalConfigData *v6; // rax
				//   int32_t sectorSize; // ecx
				//   int32_t v8; // eax
				//   int32_t mapSize; // ebx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919834 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D919834 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1963, 0LL) )
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       mapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(this, 0LL);
				//       sectorSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL);
				//       v8 = mapSize;
				//       return v8 / sectorSize;
				//     }
				//     v6 = this.fields.data;
				//     if ( v6 )
				//     {
				//       sectorSize = v6.fields.sectorSize;
				//       if ( sectorSize < 128 )
				//         sectorSize = 128;
				//       v8 = v6.fields.mapSize;
				//       return v8 / sectorSize;
				//     }
				// LABEL_12:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1963, 0LL);
				//   if ( !Patch )
				//     goto LABEL_12;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorZNum
		{
			get
			{
				// // Int32 get_sectorZNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorZNum(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   Object_1 *data; // rbx
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGWaterGlobalConfigData *v6; // rax
				//   int32_t sectorSize; // ecx
				//   int32_t v8; // eax
				//   int32_t mapSize; // ebx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919835 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D919835 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1964, 0LL) )
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       mapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(this, 0LL);
				//       sectorSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL);
				//       v8 = mapSize;
				//       return v8 / sectorSize;
				//     }
				//     v6 = this.fields.data;
				//     if ( v6 )
				//     {
				//       sectorSize = v6.fields.sectorSize;
				//       if ( sectorSize < 128 )
				//         sectorSize = 128;
				//       v8 = v6.fields.mapSize;
				//       return v8 / sectorSize;
				//     }
				// LABEL_12:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1964, 0LL);
				//   if ( !Patch )
				//     goto LABEL_12;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorNum
		{
			get
			{
				// // Int32 get_sectorNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorNum(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   void *v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   int v6; // eax
				//   int v7; // r8d
				//   int v8; // r9d
				//   int v9; // r9d
				//   int32_t sectorXNum; // ebx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBBA )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBBA = 1;
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
				//   v4 = **((_QWORD **)v3 + 23);
				//   if ( !v4 )
				//     goto LABEL_27;
				//   if ( *(int *)(v4 + 24) > 1962 )
				//   {
				//     if ( !*((_DWORD *)v3 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v3, v4);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (void *)**((_QWORD **)v3 + 23);
				//     if ( !v3 )
				//       goto LABEL_27;
				//     if ( *((_DWORD *)v3 + 6) <= 0x7AAu )
				//       sub_180070270(v3, v4);
				//     if ( *((_QWORD *)v3 + 1966) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(1962, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// LABEL_27:
				//       sub_180B536AC(v3, v4);
				//     }
				//   }
				//   data = this.fields.data;
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
				//   if ( !data )
				//     goto LABEL_25;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//   if ( !data.fields._._.m_CachedPtr )
				//   {
				// LABEL_25:
				//     sectorXNum = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorXNum(this, 0LL);
				//     return sectorXNum * HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorZNum(this, 0LL);
				//   }
				//   v3 = this.fields.data;
				//   if ( !v3 )
				//     goto LABEL_27;
				//   v6 = *((_DWORD *)v3 + 18);
				//   v7 = 128;
				//   v8 = *((_DWORD *)v3 + 19);
				//   if ( v8 < 128 )
				//   {
				//     v9 = v6 / 128;
				//   }
				//   else
				//   {
				//     v7 = *((_DWORD *)v3 + 19);
				//     v9 = v6 / v8;
				//   }
				//   return v9 * (*((_DWORD *)v3 + 18) / v7);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00002608 File Offset: 0x00000808
		public int halfMapSize
		{
			get
			{
				// // Int32 get_halfMapSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_halfMapSize(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   Object_1 *data; // rbx
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGWaterGlobalConfigData *v6; // rax
				//   int32_t mapSize; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919836 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D919836 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(945, 0LL) )
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( !UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       mapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_mapSize(this, 0LL);
				//       return mapSize / 2;
				//     }
				//     v6 = this.fields.data;
				//     if ( v6 )
				//     {
				//       mapSize = v6.fields.mapSize;
				//       return mapSize / 2;
				//     }
				// LABEL_10:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(945, 0LL);
				//   if ( !Patch )
				//     goto LABEL_10;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorCoordsMin
		{
			get
			{
				// // Int32 get_sectorCoordsMin()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMin(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   void *v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   int v6; // r8d
				//   int v7; // eax
				//   bool v8; // zf
				//   int32_t halfMapSize; // ebx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBBB )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBBB = 1;
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
				//   v4 = **((_QWORD **)v3 + 23);
				//   if ( !v4 )
				//     goto LABEL_27;
				//   if ( *(int *)(v4 + 24) > 949 )
				//   {
				//     if ( !*((_DWORD *)v3 + 56) )
				//     {
				//       il2cpp_runtime_class_init_0(v3, v4);
				//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//     }
				//     v3 = (void *)**((_QWORD **)v3 + 23);
				//     if ( !v3 )
				//       goto LABEL_27;
				//     if ( *((_DWORD *)v3 + 6) <= 0x3B5u )
				//       sub_180070270(v3, v4);
				//     if ( *((_QWORD *)v3 + 953) )
				//     {
				//       Patch = IFix::WrappersManagerImpl::GetPatch(949, 0LL);
				//       if ( Patch )
				//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// LABEL_27:
				//       sub_180B536AC(v3, v4);
				//     }
				//   }
				//   data = this.fields.data;
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
				//   if ( !data )
				//     goto LABEL_26;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//   if ( !data.fields._._.m_CachedPtr )
				//   {
				// LABEL_26:
				//     halfMapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_halfMapSize(this, 0LL);
				//     return -(halfMapSize / HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL));
				//   }
				//   v3 = this.fields.data;
				//   if ( !v3 )
				//     goto LABEL_27;
				//   v6 = *((_DWORD *)v3 + 19);
				//   v7 = *((_DWORD *)v3 + 18) / 2;
				//   v8 = v6 == 128;
				//   if ( v6 < 128 )
				//   {
				//     v6 = 128;
				//     v8 = 1;
				//   }
				//   if ( v8 )
				//     return v7 / -128;
				//   else
				//     return -(v7 / v6);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorCoordsMax
		{
			get
			{
				// // Int32 get_sectorCoordsMax()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Object_1 *data; // rdi
				//   __int64 v5; // rdx
				//   HGWaterGlobalConfigData *v6; // rcx
				//   int32_t halfMapSize; // edi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBBC )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBBC = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(944, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(944, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v6 = this.fields.data;
				//       if ( v6 )
				//         return HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(v6, 0LL);
				// LABEL_9:
				//       sub_180B536AC(v6, v5);
				//     }
				//     halfMapSize = HG::Rendering::Runtime::HGWaterGlobalConfig::get_halfMapSize(this, 0LL);
				//     return halfMapSize / HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorSize(this, 0LL) - 1;
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000025F0 File Offset: 0x000007F0
		public float flowmapPrecision
		{
			get
			{
				// // Single get_flowmapPrecision()
				// float HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowmapPrecision(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   Object_1 *data; // rbx
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HGWaterGlobalConfigData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919837 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D919837 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(4659, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4659, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v6 = this.fields.data;
				//       if ( v6 )
				//         return v6.fields.flowmapPrecision;
				// LABEL_9:
				//       sub_180B536AC(v5, v4);
				//     }
				//     return 0.5;
				//   }
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorTextureSize
		{
			get
			{
				// // Int32 get_sectorTextureSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorTextureSize(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBBD )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBBD = 1;
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
				//   if ( *(int *)(v4 + 24) <= 924 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_24;
				//   if ( *((_DWORD *)v3 + 6) <= 0x39Cu )
				//     sub_180070270(v3, v4);
				//   if ( !v3[928] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return 256;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return 256;
				//     v6 = this.fields.data;
				//     if ( v6 )
				//       return (int)(float)(128.0 / v6.fields.flowmapPrecision);
				// LABEL_24:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(924, 0LL);
				//   if ( !Patch )
				//     goto LABEL_24;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00002608 File Offset: 0x00000808
		public int lodNum
		{
			get
			{
				// // Int32 get_lodNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_lodNum(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Object_1 *data; // rdi
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGWaterGlobalConfigData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBBE )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBBE = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(952, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(952, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v7 = this.fields.data;
				//       if ( v7 )
				//         return v7.fields.lodNum;
				// LABEL_9:
				//       sub_180B536AC(v6, v5);
				//     }
				//     return 4;
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00002608 File Offset: 0x00000808
		public int meshNumPerLOD
		{
			get
			{
				// // Int32 get_meshNumPerLOD()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshNumPerLOD(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBBF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBBF = 1;
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
				//   if ( *(int *)(v4 + 24) <= 939 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_24;
				//   if ( *((_DWORD *)v3 + 6) <= 0x3ABu )
				//     sub_180070270(v3, v4);
				//   if ( !v3[943] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return 16;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return 16;
				//     v6 = this.fields.data;
				//     if ( v6 )
				//       return v6.fields.meshNumPerLOD;
				// LABEL_24:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(939, 0LL);
				//   if ( !Patch )
				//     goto LABEL_24;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00002608 File Offset: 0x00000808
		public int meshSize
		{
			get
			{
				// // Int32 get_meshSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshSize(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Object_1 *data; // rdi
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGWaterGlobalConfigData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC0 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC0 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(942, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(942, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v7 = this.fields.data;
				//       if ( v7 )
				//         return v7.fields.meshSize;
				// LABEL_9:
				//       sub_180B536AC(v6, v5);
				//     }
				//     return 1;
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00002608 File Offset: 0x00000808
		public int heightMapXZ
		{
			get
			{
				// // Int32 get_heightMapXZ()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapXZ(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Object_1 *data; // rdi
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGWaterGlobalConfigData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC1 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC1 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(934, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(934, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v7 = this.fields.data;
				//       if ( v7 )
				//         return v7.fields.heightMapXZ;
				// LABEL_9:
				//       sub_180B536AC(v6, v5);
				//     }
				//     return 128;
				//   }
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00002608 File Offset: 0x00000808
		public int heightMapY
		{
			get
			{
				// // Int32 get_heightMapY()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapY(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC2 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC2 = 1;
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
				//   if ( *(int *)(v4 + 24) <= 936 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_24;
				//   if ( *((_DWORD *)v3 + 6) <= 0x3A8u )
				//     sub_180070270(v3, v4);
				//   if ( !v3[940] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return 64;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return 64;
				//     v6 = this.fields.data;
				//     if ( v6 )
				//       return v6.fields.heightMapY;
				// LABEL_24:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(936, 0LL);
				//   if ( !Patch )
				//     goto LABEL_24;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x000025F0 File Offset: 0x000007F0
		public float heightMapOffset
		{
			get
			{
				// // Single get_heightMapOffset()
				// float HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapOffset(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   Object_1 *data; // rdi
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGWaterGlobalConfigData *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC3 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC3 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(935, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(935, 0LL);
				//     if ( !Patch )
				//       goto LABEL_9;
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     data = (Object_1 *)this.fields.data;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
				//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
				//     {
				//       v7 = this.fields.data;
				//       if ( v7 )
				//         return v7.fields.heightMapOffset;
				// LABEL_9:
				//       sub_180B536AC(v6, v5);
				//     }
				//     return 0.0;
				//   }
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000025D2 File Offset: 0x000007D2
		public Texture2D flowMap
		{
			get
			{
				// // Texture2D get_flowMap()
				// Texture2D *HG::Rendering::Runtime::HGWaterGlobalConfig::get_flowMap(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   Texture2D *flowMap; // rbx
				//   HGWaterGlobalConfigData *v8; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC4 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC4 = 1;
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
				//     goto LABEL_37;
				//   if ( *(int *)(v4 + 24) <= 953 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_37;
				//   if ( *((_DWORD *)v3 + 6) <= 0x3B9u )
				//     sub_180070270(v3, v4);
				//   if ( !v3[957] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v6 = this.fields.data;
				//     if ( !v6 )
				//       goto LABEL_37;
				//     flowMap = v6.fields.flowMap;
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
				//     if ( !flowMap )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !flowMap.fields._._.m_CachedPtr )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v8 = this.fields.data;
				//     if ( v8 )
				//       return v8.fields.flowMap;
				// LABEL_37:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(953, 0LL);
				//   if ( !Patch )
				//     goto LABEL_37;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_352(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000025D2 File Offset: 0x000007D2
		public Texture2D causticMap
		{
			get
			{
				// // Texture2D get_causticMap()
				// Texture2D *HG::Rendering::Runtime::HGWaterGlobalConfig::get_causticMap(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   Texture2D *causticMap; // rbx
				//   HGWaterGlobalConfigData *v8; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC5 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC5 = 1;
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
				//     goto LABEL_37;
				//   if ( *(int *)(v4 + 24) <= 955 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_37;
				//   if ( *((_DWORD *)v3 + 6) <= 0x3BBu )
				//     sub_180070270(v3, v4);
				//   if ( !v3[959] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v6 = this.fields.data;
				//     if ( !v6 )
				//       goto LABEL_37;
				//     causticMap = v6.fields.causticMap;
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
				//     if ( !causticMap )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !causticMap.fields._._.m_CachedPtr )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v8 = this.fields.data;
				//     if ( v8 )
				//       return v8.fields.causticMap;
				// LABEL_37:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(955, 0LL);
				//   if ( !Patch )
				//     goto LABEL_37;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_352(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000025D2 File Offset: 0x000007D2
		public Texture2D rainMap
		{
			get
			{
				// // Texture2D get_rainMap()
				// Texture2D *HG::Rendering::Runtime::HGWaterGlobalConfig::get_rainMap(HGWaterGlobalConfig *this, MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   Texture2D *rainMap; // rbx
				//   HGWaterGlobalConfigData *v8; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC6 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC6 = 1;
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
				//     goto LABEL_37;
				//   if ( *(int *)(v4 + 24) <= 956 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_37;
				//   if ( *((_DWORD *)v3 + 6) <= 0x3BCu )
				//     sub_180070270(v3, v4);
				//   if ( !v3[960] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v6 = this.fields.data;
				//     if ( !v6 )
				//       goto LABEL_37;
				//     rainMap = v6.fields.rainMap;
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
				//     if ( !rainMap )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !rainMap.fields._._.m_CachedPtr )
				//       return UnityEngine::Texture2D::get_blackTexture(0LL);
				//     v8 = this.fields.data;
				//     if ( v8 )
				//       return v8.fields.rainMap;
				// LABEL_37:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(956, 0LL);
				//   if ( !Patch )
				//     goto LABEL_37;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_352(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000025D2 File Offset: 0x000007D2
		public Texture2DArray normalMapArray
		{
			get
			{
				// // Texture2DArray get_normalMapArray()
				// Texture2DArray *HG::Rendering::Runtime::HGWaterGlobalConfig::get_normalMapArray(
				//         HGWaterGlobalConfig *this,
				//         MethodInfo *method)
				// {
				//   _QWORD **v3; // rcx
				//   __int64 v4; // rdx
				//   HGWaterGlobalConfigData *data; // rbx
				//   HGWaterGlobalConfigData *v6; // rax
				//   Texture2DArray *normalMapArray; // rbx
				//   HGWaterGlobalConfigData *v8; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDBC7 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8EDBC7 = 1;
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
				//     goto LABEL_37;
				//   if ( *(int *)(v4 + 24) <= 954 )
				//     goto LABEL_9;
				//   if ( !*((_DWORD *)v3 + 56) )
				//   {
				//     il2cpp_runtime_class_init_0(v3, v4);
				//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v3 = (_QWORD **)*v3[23];
				//   if ( !v3 )
				//     goto LABEL_37;
				//   if ( *((_DWORD *)v3 + 6) <= 0x3BAu )
				//     sub_180070270(v3, v4);
				//   if ( !v3[958] )
				//   {
				// LABEL_9:
				//     data = this.fields.data;
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
				//     if ( !data )
				//       return 0LL;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !data.fields._._.m_CachedPtr )
				//       return 0LL;
				//     v6 = this.fields.data;
				//     if ( !v6 )
				//       goto LABEL_37;
				//     normalMapArray = v6.fields.normalMapArray;
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
				//     if ( !normalMapArray )
				//       return 0LL;
				//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
				//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
				//     if ( !normalMapArray.fields._._.m_CachedPtr )
				//       return 0LL;
				//     v8 = this.fields.data;
				//     if ( v8 )
				//       return v8.fields.normalMapArray;
				// LABEL_37:
				//     sub_180B536AC(v3, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(954, 0LL);
				//   if ( !Patch )
				//     goto LABEL_37;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_353(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		public HGWaterGlobalConfig()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public int GetRealLODNum(HGSettingParameters settingParameters)
		{
			// // Int32 GetRealLODNum(HGSettingParameters)
			// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealLODNum(
			//         HGWaterGlobalConfig *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Int32Enum__Enum v7; // ebx
			//   int32_t result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBC8 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDBC8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(950, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(950, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
			//                (ILFixDynamicMethodWrapper_17 *)Patch,
			//                (Object *)this,
			//                (Object *)settingParameters,
			//                0LL);
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_7;
			//   v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterLODNumAdded_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   result = v7 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_lodNum(this, 0LL);
			//   if ( result < 1 )
			//     return 1;
			//   return result;
			// }
			// 
			return 0;
		}

		public int GetRealMeshNumPerLOD(HGSettingParameters settingParameters)
		{
			// // Int32 GetRealMeshNumPerLOD(HGSettingParameters)
			// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshNumPerLOD(
			//         HGWaterGlobalConfig *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Int32Enum__Enum v8; // ebx
			//   int32_t result; // eax
			//   ILFixDynamicMethodWrapper_2__Array *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBC9 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDBC9 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size <= 937 )
			//     goto LABEL_9;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   v10 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			// LABEL_12:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( v10.max_length.size <= 0x3A9u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( v10[26].vector[1] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(937, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
			//                (ILFixDynamicMethodWrapper_17 *)Patch,
			//                (Object *)this,
			//                (Object *)settingParameters,
			//                0LL);
			//     goto LABEL_12;
			//   }
			// LABEL_9:
			//   if ( !settingParameters )
			//     goto LABEL_12;
			//   v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterMeshNumPerLODAdded_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   result = v8 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshNumPerLOD(this, 0LL);
			//   if ( result < 1 )
			//     return 1;
			//   return result;
			// }
			// 
			return 0;
		}

		public int GetRealMeshSize(HGSettingParameters settingParameters)
		{
			// // Int32 GetRealMeshSize(HGSettingParameters)
			// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealMeshSize(
			//         HGWaterGlobalConfig *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Int32Enum__Enum v7; // ebx
			//   int32_t result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBCA )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDBCA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(940, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(940, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
			//                (ILFixDynamicMethodWrapper_17 *)Patch,
			//                (Object *)this,
			//                (Object *)settingParameters,
			//                0LL);
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_7;
			//   v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterMeshSizeAdded_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   result = v7 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_meshSize(this, 0LL);
			//   if ( result < 1 )
			//     return 1;
			//   return result;
			// }
			// 
			return 0;
		}

		public int GetRealHeightMapXZ(HGSettingParameters settingParameters)
		{
			// // Int32 GetRealHeightMapXZ(HGSettingParameters)
			// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetRealHeightMapXZ(
			//         HGWaterGlobalConfig *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Int32Enum__Enum v7; // ebx
			//   int32_t result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBCB )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8EDBCB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(932, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(932, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
			//                (ILFixDynamicMethodWrapper_17 *)Patch,
			//                (Object *)this,
			//                (Object *)settingParameters,
			//                0LL);
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_7;
			//   v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._waterHeightMapXZAdded_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   result = v7 + HG::Rendering::Runtime::HGWaterGlobalConfig::get_heightMapXZ(this, 0LL);
			//   if ( result < 1 )
			//     return 1;
			//   return result;
			// }
			// 
			return 0;
		}

		public bool ShouldRenderWater()
		{
			// // Boolean ShouldRenderWater()
			// bool HG::Rendering::Runtime::HGWaterGlobalConfig::ShouldRenderWater(HGWaterGlobalConfig *this, MethodInfo *method)
			// {
			//   _QWORD **v3; // rcx
			//   __int64 v4; // rdx
			//   HGWaterGlobalConfigData *data; // rbx
			//   HGWaterGlobalConfigData *v6; // rbx
			//   Texture2DArray *normalMapArray; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBCC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBCC = 1;
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
			//     goto LABEL_36;
			//   if ( *(int *)(v4 + 24) <= 922 )
			//     goto LABEL_9;
			//   if ( !*((_DWORD *)v3 + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(v3, v4);
			//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (_QWORD **)*v3[23];
			//   if ( !v3 )
			//     goto LABEL_36;
			//   if ( *((_DWORD *)v3 + 6) <= 0x39Au )
			//     sub_180070270(v3, v4);
			//   if ( !v3[926] )
			//   {
			// LABEL_9:
			//     data = this.fields.data;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( !byte_18D8F4EFA )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFA = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !data )
			//       return 0;
			//     v3 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( !data.fields._._.m_CachedPtr )
			//       return 0;
			//     v6 = this.fields.data;
			//     if ( v6 )
			//     {
			//       normalMapArray = v6.fields.normalMapArray;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( normalMapArray )
			//       {
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//         if ( normalMapArray.fields._._.m_CachedPtr )
			//           return 1;
			//       }
			//       return 0;
			//     }
			// LABEL_36:
			//     sub_180B536AC(v3, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(922, 0LL);
			//   if ( !Patch )
			//     goto LABEL_36;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void LogInfo()
		{
			// // Void LogInfo()
			// void HG::Rendering::Runtime::HGWaterGlobalConfig::LogInfo(HGWaterGlobalConfig *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Object_1 *data; // rdi
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGWaterGlobalConfigData *v7; // rax
			//   Object_1 *normalMapArray; // rdi
			//   Object *scenePath; // rdi
			//   Object_1 *v10; // rax
			//   Object *v11; // rax
			//   Object_1 *gameObject; // rax
			//   Object *name; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBCD )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,System::String,System::String>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,System::String>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C912920);
			//     sub_18003C530(&off_18C912928);
			//     sub_18003C530(&off_18C912930);
			//     byte_18D8EDBCD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4660, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4660, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v6, v5);
			//   }
			//   data = (Object_1 *)this.fields.data;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//   if ( UnityEngine::Object::op_Equality(data, 0LL, 0LL) )
			//   {
			//     gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     if ( gameObject )
			//     {
			//       name = (Object *)UnityEngine::Object::get_name(gameObject, 0LL);
			//       HG::Rendering::HGRPLogger::LogError<System::Object,System::Object>(
			//         (String *)"错误：不会绘制水，因为场景的HGWaterConfig({0})上的 data 为空，请尽快处理！如何处理可以参考文档（{1}）",
			//         name,
			//         (Object *)":)",
			//         MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,System::String>);
			//       return;
			//     }
			//     goto LABEL_12;
			//   }
			//   v7 = this.fields.data;
			//   if ( !v7 )
			//     goto LABEL_12;
			//   normalMapArray = (Object_1 *)v7.fields.normalMapArray;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( UnityEngine::Object::op_Equality(normalMapArray, 0LL, 0LL) )
			//   {
			//     scenePath = (Object *)HG::Rendering::Runtime::HGWaterGlobalConfig::get_scenePath(this, 0LL);
			//     v10 = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     if ( v10 )
			//     {
			//       v11 = (Object *)UnityEngine::Object::get_name(v10, 0LL);
			//       HG::Rendering::HGRPLogger::LogError<System::Object,System::Object,System::Object>(
			//         (String *)"错误：不会绘制水，因为场景({0})的HGWaterConfig({1})上的 normalMapArray 贴图为空，请尽快处理！如何处理可以参考文档（{2}）",
			//         scenePath,
			//         v11,
			//         (Object *)":)",
			//         MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String,System::String,System::String>);
			//       return;
			//     }
			//     goto LABEL_12;
			//   }
			// }
			// 
		}

		private void InitDefault()
		{
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGWaterGlobalConfig::OnEnable(HGWaterGlobalConfig *this, MethodInfo *method)
			// {
			//   HGManagerContext *ManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4662, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGWaterGlobalConfig::InitDefault(this, 0LL);
			//     HG::Rendering::Runtime::HGWaterGlobalConfig::LogInfo(this, 0LL);
			//     ManagerContext = HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(0LL);
			//     if ( ManagerContext )
			//     {
			//       waterManager_k__BackingField = ManagerContext.fields._waterManager_k__BackingField;
			//       if ( waterManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGWaterManager::AddWaterGlobalConfig(waterManager_k__BackingField, this, 0LL);
			//         HG::Rendering::Runtime::HGWaterGlobalConfig::UpdateHGWaterConfigs(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_5:
			//     sub_180B536AC(waterManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4662, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGWaterGlobalConfig::OnDisable(HGWaterGlobalConfig *this, MethodInfo *method)
			// {
			//   HGManagerContext *ManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGWaterManager *waterManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4667, 0LL) )
			//   {
			//     ManagerContext = HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(0LL);
			//     if ( ManagerContext )
			//     {
			//       waterManager_k__BackingField = ManagerContext.fields._waterManager_k__BackingField;
			//       if ( waterManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGWaterManager::RemoveWaterGlobalConfig(waterManager_k__BackingField, this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(waterManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4667, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public ValueTuple<int, int> GetSectorCoords(Vector3 pos)
		{
			// // ValueTuple`2[Int32,Int32] GetSectorCoords(Vector3)
			// ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorCoords(
			//         HGWaterGlobalConfig *this,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Object_1 *data; // rsi
			//   __int64 v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float v9; // eax
			//   float z; // eax
			//   Vector3 v12[2]; // [rsp+20h] [rbp-18h] BYREF
			//   ValueTuple_2_Int32_Int32_ v13; // [rsp+58h] [rbp+20h]
			// 
			//   if ( !byte_18D8EDBCF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     byte_18D8EDBCF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(943, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(943, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     z = pos.z;
			//     *(_QWORD *)&v12[0].x = *(_QWORD *)&pos.x;
			//     v12[0].z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(Patch, (Object *)this, v12, 0LL);
			//   }
			//   else
			//   {
			//     data = (Object_1 *)this.fields.data;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
			//     {
			//       Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.data;
			//       if ( Patch )
			//       {
			//         v9 = pos.z;
			//         *(_QWORD *)&v12[0].x = *(_QWORD *)&pos.x;
			//         v12[0].z = v9;
			//         return HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorCoords(
			//                  (HGWaterGlobalConfigData *)Patch,
			//                  v12,
			//                  0LL);
			//       }
			// LABEL_9:
			//       sub_180B536AC(Patch, v7);
			//     }
			//     v13.Item1 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(this, 0LL) + 100;
			//     v13.Item2 = HG::Rendering::Runtime::HGWaterGlobalConfig::get_sectorCoordsMax(this, 0LL) + 100;
			//     return v13;
			//   }
			// }
			// 
			return null;
		}

		public int GetSectorIndex(int coordX, int coordZ)
		{
			// // Int32 GetSectorIndex(Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGWaterGlobalConfig::GetSectorIndex(
			//         HGWaterGlobalConfig *this,
			//         int32_t coordX,
			//         int32_t coordZ,
			//         MethodInfo *method)
			// {
			//   Object_1 *data; // rbx
			//   __int64 v8; // rdx
			//   HGWaterGlobalConfigData *v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919838 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919838 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2889, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2889, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//              (ILFixDynamicMethodWrapper_14 *)Patch,
			//              (Object *)this,
			//              (SocketOptionLevel__Enum)coordX,
			//              (SocketOptionName__Enum)coordZ,
			//              0LL);
			//   }
			//   else
			//   {
			//     data = (Object_1 *)this.fields.data;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
			//     {
			//       v9 = this.fields.data;
			//       if ( v9 )
			//         return HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorIndex(v9, coordX, coordZ, 0LL);
			// LABEL_9:
			//       sub_180B536AC(v9, v8);
			//     }
			//     return -1;
			//   }
			// }
			// 
			return 0;
		}

		public void UpdateHGWaterConfigs()
		{
			// // Void UpdateHGWaterConfigs()
			// void HG::Rendering::Runtime::HGWaterGlobalConfig::UpdateHGWaterConfigs(HGWaterGlobalConfig *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Object_1 *data; // rdi
			//   __int64 v5; // rdx
			//   HGWaterGlobalConfigData *v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBD0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBD0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4665, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4665, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     data = (Object_1 *)this.fields.data;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( UnityEngine::Object::op_Inequality(data, 0LL, 0LL) )
			//     {
			//       v6 = this.fields.data;
			//       if ( v6 )
			//       {
			//         HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateHGWaterConfigs(v6, 0LL);
			//         return;
			//       }
			// LABEL_10:
			//       sub_180B536AC(v6, v5);
			//     }
			//   }
			// }
			// 
		}

		public const string DEFAULT_HG_WATER_CONFIG = "Packages/com.hg.render-pipelines/Resources/Water/DefaultHGWaterConfig.asset";

		public const string DEFAULT_HG_WATER_GLOBAL_CONFIG_DATA = "Packages/com.hg.render-pipelines/Resources/Water/DefaultHGWaterGlobalConfigData.asset";

		public const string DEFAULT_FLOW_MAP_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_default_flowmap01.tga";

		public const string DEFAULT_CAUSTIC_MAP_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_caustic_01.png";

		public const string DEFAULT_NORMAL_MAP_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_normal04_WN.tga";

		public const string DEFAULT_RAIN_MAP = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_rain_01_M.tga";

		public const string DEFAULT_NORMAL_MAP_ARRAY_PATH = "Packages/com.hg.render-pipelines/Resources/Water/Textures/T_water_normal_atalas_WN.tga";

		private const string DEFAULT_HELP_DOCUMENT = ":)";

		private string[] m_defaultSectorDataPaths;

		private long[] m_defaultSectorDataAssetHashes;

		private bool[] m_defaultSectorDataExists;

		[Header("新版配置")]
		public HGWaterGlobalConfigData data;
	}
}
