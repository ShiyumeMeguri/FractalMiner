using System;
using System.Collections;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGWaterGlobalConfigData", menuName = "HGWater/HGWaterGlobalConfigData")]
	[Serializable]
	public class HGWaterGlobalConfigData : ScriptableObject
	{
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00002608 File Offset: 0x00000808
		public int safeSectorSize
		{
			get
			{
				// // Int32 get_safeSectorSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_safeSectorSize(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   int32_t result; // eax
				// 
				//   result = this.fields.sectorSize;
				//   if ( result < 128 )
				//     return 128;
				//   return result;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorXNum
		{
			get
			{
				// // Int32 get_sectorZNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorZNum(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   int32_t sectorSize; // r8d
				// 
				//   sectorSize = this.fields.sectorSize;
				//   if ( sectorSize < 128 )
				//     sectorSize = 128;
				//   return this.fields.mapSize / sectorSize;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorZNum
		{
			get
			{
				// // Int32 get_sectorZNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorZNum(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   int32_t sectorSize; // r8d
				// 
				//   sectorSize = this.fields.sectorSize;
				//   if ( sectorSize < 128 )
				//     sectorSize = 128;
				//   return this.fields.mapSize / sectorSize;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorNum
		{
			get
			{
				// // Int32 get_sectorNum()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorNum(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   int32_t mapSize; // eax
				//   int32_t v3; // r8d
				//   int32_t sectorSize; // r9d
				//   int v5; // r9d
				// 
				//   mapSize = this.fields.mapSize;
				//   v3 = 128;
				//   sectorSize = this.fields.sectorSize;
				//   if ( sectorSize < 128 )
				//   {
				//     v5 = mapSize / 128;
				//   }
				//   else
				//   {
				//     v3 = this.fields.sectorSize;
				//     v5 = mapSize / sectorSize;
				//   }
				//   return v5 * (this.fields.mapSize / v3);
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00002608 File Offset: 0x00000808
		public int halfMapSize
		{
			get
			{
				// // Int32 get_halfMapSize()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_halfMapSize(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.mapSize / 2;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorCoordsMin
		{
			get
			{
				// // Int32 get_sectorCoordsMin()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   int32_t sectorSize; // r8d
				//   int v3; // eax
				//   bool v4; // zf
				//   int v5; // eax
				// 
				//   sectorSize = this.fields.sectorSize;
				//   v3 = this.fields.mapSize / 2;
				//   v4 = sectorSize == 128;
				//   if ( sectorSize < 128 )
				//   {
				//     sectorSize = 128;
				//     v4 = 1;
				//   }
				//   if ( v4 )
				//     v5 = v3 / 128;
				//   else
				//     v5 = v3 / sectorSize;
				//   return -v5;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00002608 File Offset: 0x00000808
		public int sectorCoordsMax
		{
			get
			{
				// // Int32 get_sectorCoordsMax()
				// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   int v2; // eax
				//   int v3; // eax
				// 
				//   v2 = this.fields.mapSize / 2;
				//   if ( this.fields.sectorSize == 128 )
				//     v3 = v2 / 128;
				//   else
				//     v3 = v2 / this.fields.sectorSize;
				//   return v3 - 1;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector2 sceneCenterOffsetSector
		{
			get
			{
				// // Vector2 get_sceneCenterOffsetSector()
				// Vector2 HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sceneCenterOffsetSector(
				//         HGWaterGlobalConfigData *this,
				//         MethodInfo *method)
				// {
				//   __m128 x_low; // xmm1
				//   __m128 y_low; // xmm2
				//   float sectorSize; // xmm0_4
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(4669, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4669, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v9, v8);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1341(Patch, (Object *)this, 0LL);
				//   }
				//   else if ( this.fields.sectorSize > 0 )
				//   {
				//     x_low = (__m128)LODWORD(this.fields.sceneCenterOffset.x);
				//     y_low = (__m128)LODWORD(this.fields.sceneCenterOffset.y);
				//     sectorSize = (float)this.fields.sectorSize;
				//     x_low.m128_f32[0] = x_low.m128_f32[0] / sectorSize;
				//     y_low.m128_f32[0] = y_low.m128_f32[0] / sectorSize;
				//     return (Vector2)_mm_unpacklo_ps(x_low, y_low).m128_u64[0];
				//   }
				//   else
				//   {
				//     return (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   }
				// }
				// 
				return null;
			}
		}

		public HGWaterGlobalConfigData()
		{
		}

		public void InitDefaultSectorData()
		{
			// // Void InitDefaultSectorData()
			// void HG::Rendering::Runtime::HGWaterGlobalConfigData::InitDefaultSectorData(
			//         HGWaterGlobalConfigData *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4670, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4670, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		public void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGWaterGlobalConfigData::OnEnable(HGWaterGlobalConfigData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4671, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4671, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateConfig(this, 0, 0LL);
			//   }
			// }
			// 
		}

		public void UpdateConfig([MetadataOffset(Offset = "0x01F92135")] bool forceUpdate = false)
		{
			// // Void UpdateConfig(Boolean)
			// void HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateConfig(
			//         HGWaterGlobalConfigData *this,
			//         bool forceUpdate,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4672, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4672, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       forceUpdate,
			//       0LL);
			//   }
			// }
			// 
		}

		public ValueTuple<int, int> GetSectorCoords(Vector3 pos)
		{
			// // ValueTuple`2[Int32,Int32] GetSectorCoords(Vector3)
			// ValueTuple_2_Int32_Int32_ HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorCoords(
			//         HGWaterGlobalConfigData *this,
			//         Vector3 *pos,
			//         MethodInfo *method)
			// {
			//   char v5; // dl
			//   __int64 v6; // rcx
			//   int v7; // r8d
			//   char v8; // dl
			//   __int64 v9; // rcx
			//   int v10; // r8d
			//   __int64 v12; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v15; // [rsp+20h] [rbp-28h] BYREF
			//   ValueTuple_2_Int32_Int32_ v16; // [rsp+68h] [rbp+20h]
			// 
			//   if ( !byte_18D8EDBD1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int>::ValueTuple);
			//     byte_18D8EDBD1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(948, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(948, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v12);
			//     z = pos.z;
			//     *(_QWORD *)&v15.x = *(_QWORD *)&pos.x;
			//     v15.z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(Patch, (Object *)this, &v15, 0LL);
			//   }
			//   else
			//   {
			//     pos.x = pos.x - this.fields.sceneCenterOffset.x;
			//     v16.Item1 = sub_182592070(v6, v5, v7);
			//     v16.Item2 = sub_182592070(v9, v8, v10);
			//     return v16;
			//   }
			// }
			// 
			return null;
		}

		public int GetSectorIndex(int coordX, int coordZ)
		{
			// // Int32 GetSectorIndex(Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGWaterGlobalConfigData::GetSectorIndex(
			//         HGWaterGlobalConfigData *this,
			//         int32_t coordX,
			//         int32_t coordZ,
			//         MethodInfo *method)
			// {
			//   int32_t sectorCoordsMin; // ebx
			//   int32_t v8; // eax
			//   int32_t sectorSize; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2890, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2890, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//              (ILFixDynamicMethodWrapper_14 *)Patch,
			//              (Object *)this,
			//              (SocketOptionLevel__Enum)coordX,
			//              (SocketOptionName__Enum)coordZ,
			//              0LL);
			//   }
			//   else if ( coordX < HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL)
			//          || coordX > HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(this, 0LL)
			//          || coordZ < HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL)
			//          || coordZ > HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMax(this, 0LL) )
			//   {
			//     return -1;
			//   }
			//   else
			//   {
			//     sectorCoordsMin = HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL);
			//     v8 = HG::Rendering::Runtime::HGWaterGlobalConfigData::get_sectorCoordsMin(this, 0LL);
			//     sectorSize = this.fields.sectorSize;
			//     if ( sectorSize < 128 )
			//       sectorSize = 128;
			//     return coordZ + (coordX - v8) * (this.fields.mapSize / sectorSize) - sectorCoordsMin;
			//   }
			// }
			// 
			return 0;
		}

		public void UpdateHGWaterConfigs()
		{
			// // Void UpdateHGWaterConfigs()
			// void HG::Rendering::Runtime::HGWaterGlobalConfigData::UpdateHGWaterConfigs(
			//         HGWaterGlobalConfigData *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGWaterConfig__Array *v4; // rcx
			//   unsigned int i; // ebx
			//   HGWaterConfig__Array *hgWaterConfigs; // rax
			//   Object_1 *v7; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBD2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBD2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4666, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4666, 0LL);
			//     if ( !Patch )
			//       goto LABEL_18;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.hgWaterConfigs )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       hgWaterConfigs = this.fields.hgWaterConfigs;
			//       if ( !hgWaterConfigs )
			//         break;
			//       if ( (signed int)i >= hgWaterConfigs.max_length.size )
			//         return;
			//       v4 = this.fields.hgWaterConfigs;
			//       if ( i >= hgWaterConfigs.max_length.size )
			//         goto LABEL_19;
			//       v7 = (Object_1 *)v4.vector[i];
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//       if ( UnityEngine::Object::op_Inequality(v7, 0LL, 0LL) )
			//       {
			//         v4 = this.fields.hgWaterConfigs;
			//         if ( !v4 )
			//           break;
			//         if ( i >= v4.max_length.size )
			// LABEL_19:
			//           sub_180070270(v4, v3);
			//         v4 = (HGWaterConfig__Array *)v4.vector[i];
			//         if ( !v4 )
			//           break;
			//         HG::Rendering::Runtime::HGWaterConfig::UpdateConfig((HGWaterConfig *)v4, 0LL);
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(v4, v3);
			//   }
			// }
			// 
		}

		public const int INVALID_SECTOR_INDEX = -1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static IEnumerable mapSizeList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static IEnumerable sectorSizeList;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static IEnumerable flowmapPrecisionList;

		[SerializeField]
		public string scenePath;

		[SerializeField]
		public Vector2 sceneCenterOffset;

		[SerializeField]
		public bool useSectorData;

		[SerializeField]
		public string[] sectorDataPaths;

		[SerializeField]
		public long[] sectorDataAssetHashes;

		[SerializeField]
		public bool[] sectorDataExists;

		[SerializeField]
		public int mapSize;

		[SerializeField]
		public int sectorSize;

		[SerializeField]
		[Header("flowmap精度")]
		public float flowmapPrecision;

		[SerializeField]
		[Range(1f, 4f)]
		public int lodNum;

		[SerializeField]
		[Range(16f, 32f)]
		public int meshNumPerLOD;

		[Range(1f, 8f)]
		[SerializeField]
		public int meshSize;

		[SerializeField]
		[Min(32f)]
		public int heightMapXZ;

		[SerializeField]
		[Min(32f)]
		public int heightMapY;

		[Range(0f, 1f)]
		[SerializeField]
		public float heightMapOffset;

		[SerializeField]
		[Header("水体配置列表")]
		public HGWaterConfig[] hgWaterConfigs;

		[SerializeField]
		[Header("全局流向贴图")]
		public Texture2D flowMap;

		[SerializeField]
		[Header("焦散贴图")]
		public Texture2D causticMap;

		[Header("雨滴波纹贴图")]
		[SerializeField]
		public Texture2D rainMap;

		[SerializeField]
		[Header("法线贴图列表")]
		public Texture2DArray normalMapArray;
	}
}
