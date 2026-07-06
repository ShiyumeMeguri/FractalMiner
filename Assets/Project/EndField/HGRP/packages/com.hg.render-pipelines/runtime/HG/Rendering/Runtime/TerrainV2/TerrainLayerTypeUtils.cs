using System;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime.TerrainV2
{
	public static class TerrainLayerTypeUtils
	{
		public static bool HasTerrainSimpleSubsurface()
		{
			// // Boolean HasTerrainSimpleSubsurface()
			// bool HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::HasTerrainSimpleSubsurface(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *terrainSimpleSubsurface; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool v4; // bl
			//   HGRenderPipelineSettingHub *instance; // rax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   bool v7; // di
			//   struct HGGraphicsFeatureManager__Class *v8; // rax
			//   __int128 *v9; // rax
			//   __int128 *v10; // rcx
			//   __int64 v11; // rdx
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v22[272]; // [rsp+20h] [rbp-228h] BYREF
			//   _BYTE v23[272]; // [rsp+130h] [rbp-118h] BYREF
			// 
			//   if ( !byte_18D8EDC1D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     byte_18D8EDC1D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   terrainSimpleSubsurface = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v1);
			//     terrainSimpleSubsurface = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = terrainSimpleSubsurface.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_20;
			//   if ( wrapperArray.max_length.size <= 998 )
			//     goto LABEL_9;
			//   if ( !terrainSimpleSubsurface._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(terrainSimpleSubsurface, wrapperArray);
			//     terrainSimpleSubsurface = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   terrainSimpleSubsurface = (struct ILFixDynamicMethodWrapper_2__Class *)terrainSimpleSubsurface.static_fields.wrapperArray;
			//   if ( !terrainSimpleSubsurface )
			// LABEL_20:
			//     sub_180B536AC(terrainSimpleSubsurface, wrapperArray);
			//   if ( LODWORD(terrainSimpleSubsurface._0.namespaze) <= 0x3E6 )
			//     sub_180070270(terrainSimpleSubsurface, wrapperArray);
			//   if ( terrainSimpleSubsurface[21]._0.klass )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(998, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//     goto LABEL_20;
			//   }
			// LABEL_9:
			//   v4 = 0;
			//   instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_20;
			//   m_impl = instance.fields.m_impl;
			//   if ( !m_impl )
			//     goto LABEL_20;
			//   v7 = m_impl.fields._currentDeviceType_k__BackingField == 1;
			//   v8 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, wrapperArray);
			//     v8 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   }
			//   terrainSimpleSubsurface = (struct ILFixDynamicMethodWrapper_2__Class *)v8.static_fields.terrainSimpleSubsurface;
			//   if ( !terrainSimpleSubsurface )
			//     goto LABEL_20;
			//   if ( LOBYTE(terrainSimpleSubsurface._0.name) && !v7 )
			//   {
			//     v9 = (__int128 *)sub_182C50540(v23);
			//     v10 = (__int128 *)v22;
			//     v11 = 2LL;
			//     do
			//     {
			//       v10 += 8;
			//       v12 = *v9;
			//       v13 = v9[1];
			//       v9 += 8;
			//       *(v10 - 8) = v12;
			//       v14 = *(v9 - 6);
			//       *(v10 - 7) = v13;
			//       v15 = *(v9 - 5);
			//       *(v10 - 6) = v14;
			//       v16 = *(v9 - 4);
			//       *(v10 - 5) = v15;
			//       v17 = *(v9 - 3);
			//       *(v10 - 4) = v16;
			//       v18 = *(v9 - 2);
			//       *(v10 - 3) = v17;
			//       v19 = *(v9 - 1);
			//       *(v10 - 2) = v18;
			//       *(v10 - 1) = v19;
			//       --v11;
			//     }
			//     while ( v11 );
			//     *v10 = *v9;
			//     return v22[48];
			//   }
			//   return v4;
			// }
			// 
			return default(bool);
		}

		public unsafe static HGTerrainLayerTypeData* GetNativeLayerTypeData()
		{
			// // HGTerrainLayerTypeData* GetNativeLayerTypeData()
			// HGTerrainLayerTypeData *HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::GetNativeLayerTypeData(
			//         MethodInfo *method)
			// {
			//   __int64 (__fastcall *v1)(__int64); // rax
			//   HGTerrainLayerTypeData *v2; // rax
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGTerrainLayerTypeData *v5; // rbx
			//   Color *v6; // rax
			//   TerrainLayerTypeData *v7; // rcx
			//   __int64 v8; // rdx
			//   Color v9; // xmm0
			//   HGTerrainLayerTypeData *result; // rax
			//   __int64 v11; // rax
			//   TerrainLayerTypeData v12; // [rsp+20h] [rbp-228h] BYREF
			//   _BYTE v13[272]; // [rsp+130h] [rbp-118h] BYREF
			// 
			//   sub_1802F01E0(&v12, 0LL, 272LL);
			//   v1 = (__int64 (__fastcall *)(__int64))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v1 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_0(
			//                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//     if ( !v1 )
			//     {
			//       v11 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v11, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v1;
			//   }
			//   v2 = (HGTerrainLayerTypeData *)v1(400LL);
			//   v5 = v2;
			//   if ( !v2 )
			//     sub_180B536AC(v4, v3);
			//   v2.m_bHasLayerTypeData = 0;
			//   v6 = (Color *)sub_182C50540(v13);
			//   v7 = &v12;
			//   v8 = 2LL;
			//   do
			//   {
			//     v7 = (TerrainLayerTypeData *)((char *)v7 + 128);
			//     v9 = *v6;
			//     v6 += 8;
			//     v7[-1]._fakeVolumeData._Params._FakeVolumeScatterExtinction = v9;
			//     v7[-1]._fakeVolumeData._Params._FakeVolumeScatterAlbedo = v6[-7];
			//     *(Color *)&v7[-1]._fakeVolumeData._Params._FakeRefractionHeightScale = v6[-6];
			//     *(Color *)&v7[-1]._fakeVolumeData._Params._FakeDustDepth = v6[-5];
			//     *(Color *)&v7[-1]._fakeVolumeData._Params._FakeDustFlowSpeed.w = v6[-4];
			//     *(Color *)&v7[-1]._fakeVolumeData._Params._FakeDustTint.a = v6[-3];
			//     *(Color *)&v7[-1]._fakeVolumeData._FakeVolumeMask = v6[-2];
			//     *(Color *)&v7[-1]._fakeShadowData._FakeShadowStrength = v6[-1];
			//     --v8;
			//   }
			//   while ( v8 );
			//   *(Color *)&v7._glintData._EnableFakeGlint = *v6;
			//   HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::PrepareTerrainDataCPP(&v12, v5, 0LL);
			//   result = v5;
			//   v5.m_bHasLayerTypeData = 1;
			//   return result;
			// }
			// 
			return null;
		}
	}
}
