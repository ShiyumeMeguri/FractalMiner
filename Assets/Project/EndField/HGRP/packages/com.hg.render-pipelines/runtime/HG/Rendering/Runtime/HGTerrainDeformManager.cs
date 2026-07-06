using System;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.TerrainV2;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class HGTerrainDeformManager
	{
		public HGTerrainDeformManager()
		{
		}

		public static void InitStaticParams(ComputeShader terrainGroundLayerCS)
		{
			// // Void InitStaticParams(ComputeShader)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::InitStaticParams(
			//         ComputeShader *terrainGroundLayerCS,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDB6E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager);
			//     byte_18D8EDB6E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3421, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3421, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)terrainGroundLayerCS,
			//       0LL);
			//   }
			//   else
			//   {
			//     TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager.static_fields.s_groundLayerCS = terrainGroundLayerCS;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGTerrainDeformManager.static_fields,
			//       v3,
			//       v4,
			//       v5,
			//       v9,
			//       v10);
			//   }
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGTerrainDeformManager::Dispose(HGTerrainDeformManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGTerrainGroundLayer *terrainGroundLayer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1927, 0LL) )
			//   {
			//     terrainGroundLayer = this.fields.terrainGroundLayer;
			//     if ( terrainGroundLayer )
			//     {
			//       HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Release(terrainGroundLayer, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(terrainGroundLayer, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1927, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void Tick(float deltaTime)
		{
			// // Void Tick(Single)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::Tick(
			//         HGTerrainDeformManager *this,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float v7; // xmm6_4
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
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1946 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x79A )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[41].static_fields )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1946, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//           (ILFixDynamicMethodWrapper_20 *)Patch,
			//           (Object *)this,
			//           deltaTime,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   v7 = deltaTime + this.fields.m_remainDeltaTime;
			//   this.fields.deltaTime = 0.0;
			//   this.fields.m_remainDeltaTime = v7;
			//   if ( v7 >= 0.15000001 )
			//   {
			//     this.fields.deltaTime = 0.15000001;
			//     this.fields.m_remainDeltaTime = v7 - 0.15000001;
			//   }
			// }
			// 
		}

		public void UpdateDeformConfig(ref HGTerrainDeformConfig config)
		{
			// // Void UpdateDeformConfig(HGTerrainDeformConfig ByRef)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::UpdateDeformConfig(
			//         HGTerrainDeformManager *this,
			//         HGTerrainDeformConfig *config,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int v7; // eax
			//   void (__fastcall *v8)(unsigned __int64 *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rax
			//   unsigned __int64 v11; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, config);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 639 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x27F )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !*(_QWORD *)&v5[13]._1.element_size )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(639, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_238(Patch, (Object *)this, config, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   v7 = *(_DWORD *)&config.m_active;
			//   *(_QWORD *)&this.fields.deformConfig.deformGlobalStrength = *(_QWORD *)&config.deformGlobalStrength;
			//   *(_DWORD *)&this.fields.deformConfig.m_active = v7;
			//   v8 = (void (__fastcall *)(unsigned __int64 *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F5CB0;
			//   v11 = _mm_unpacklo_ps((__m128)LODWORD(config.deformGlobalStrength), (__m128)LODWORD(config.latency)).m128_u64[0];
			//   if ( !qword_18D8F5CB0 )
			//   {
			//     v8 = (void (__fastcall *)(unsigned __int64 *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGTerrainDeformManagerV2::UpdateDeformConfig_Injected(UnityEngine.HyperGryph.HGTerrainDeformConfigV2&)");
			//     if ( !v8 )
			//     {
			//       v10 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGTerrainDeformManagerV2::UpdateDeformConfig_Injected(UnityEngine.HyperGryph.HGTerr"
			//               "ainDeformConfigV2&)");
			//       sub_18000F750(v10, 0LL);
			//     }
			//     qword_18D8F5CB0 = (__int64)v8;
			//   }
			//   v8(&v11, wrapperArray, method);
			// }
			// 
		}

		public void GetTerrainDeformParams(ref ShaderVariablesGlobal cb)
		{
			// // Void GetTerrainDeformParams(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::GetTerrainDeformParams(
			//         HGTerrainDeformManager *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm0
			//   __int64 v6; // rdx
			//   HGTerrainGroundLayer *terrainGroundLayer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v9; // [rsp+20h] [rbp-18h]
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2830, 0LL) )
			//   {
			//     *(float *)&v9 = this.fields.deformConfig.deformGlobalStrength;
			//     DWORD1(v9) = 1015021568;
			//     *((float *)&v9 + 2) = (float)((float)-this.fields.curCenter.x * 0.015625) + 0.5;
			//     *((float *)&v9 + 3) = (float)((float)-this.fields.curCenter.z * 0.015625) + 0.5;
			//     v5 = v9;
			//     HIDWORD(v9) = 0;
			//     *(_OWORD *)&cb._FakeSphericalLightSource.y = v5;
			//     v6 = (unsigned int)(this.fields.subdWidth >> 31);
			//     LODWORD(v6) = this.fields.subdWidth % 2;
			//     *(Vector2 *)&v9 = this.fields.subdCenter;
			//     *((float *)&v9 + 2) = (float)(this.fields.subdWidth / 2);
			//     *(_OWORD *)&cb._VolumetricComposeParams.y = v9;
			//     terrainGroundLayer = this.fields.terrainGroundLayer;
			//     if ( terrainGroundLayer )
			//     {
			//       HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::GetTerrainDeformParams(terrainGroundLayer, cb, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(terrainGroundLayer, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2830, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		public void SetDeformCenter(Vector3 centerPosition)
		{
			// // Void SetDeformCenter(Vector3)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::SetDeformCenter(
			//         HGTerrainDeformManager *this,
			//         Vector3 *centerPosition,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Object_1 *main; // rbx
			//   __int64 v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 (__fastcall *v9)(Object_1 *); // rax
			//   __int64 v10; // rbx
			//   void (__fastcall *v11)(__int64, Vector3 *); // rax
			//   float z; // eax
			//   float v13; // eax
			//   __int64 v14; // rax
			//   __int64 v15; // rax
			//   float v16; // eax
			//   Vector3 v17[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB70 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB70 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3422, 0LL) )
			//   {
			//     main = (Object_1 *)UnityEngine::Camera::get_main(0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( !UnityEngine::Object::op_Inequality(main, 0LL, 0LL) )
			//       goto LABEL_12;
			//     if ( main )
			//     {
			//       v9 = (__int64 (__fastcall *)(Object_1 *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v9 = (__int64 (__fastcall *)(Object_1 *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//         if ( !v9 )
			//         {
			//           v14 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//           sub_18000F750(v14, 0LL);
			//         }
			//         qword_18D8F4D40 = (__int64)v9;
			//       }
			//       v10 = v9(main);
			//       if ( v10 )
			//       {
			//         *(_QWORD *)&v17[0].x = 0LL;
			//         v17[0].z = 0.0;
			//         v11 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//         if ( !qword_18D8F52E0 )
			//         {
			//           v11 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                            "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           if ( !v11 )
			//           {
			//             v15 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//             sub_18000F750(v15, 0LL);
			//           }
			//           qword_18D8F52E0 = (__int64)v11;
			//         }
			//         v11(v10, v17);
			//         z = v17[0].z;
			//         *(_QWORD *)&centerPosition.x = *(_QWORD *)&v17[0].x;
			//         centerPosition.z = z;
			// LABEL_12:
			//         v13 = centerPosition.z;
			//         *(_QWORD *)&v17[0].x = *(_QWORD *)&centerPosition.x;
			//         v17[0].z = v13;
			//         HG::Rendering::Runtime::HGTerrainDeformManager::SetPlayerCenter(this, v17, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(Patch, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3422, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   v16 = centerPosition.z;
			//   *(_QWORD *)&v17[0].x = *(_QWORD *)&centerPosition.x;
			//   v17[0].z = v16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, v17, 0LL);
			// }
			// 
		}

		public void SetPlayerCenter(Vector3 centerPosition)
		{
			// // Void SetPlayerCenter(Vector3)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::SetPlayerCenter(
			//         HGTerrainDeformManager *this,
			//         Vector3 *centerPosition,
			//         MethodInfo *method)
			// {
			//   float v3; // xmm1_4
			//   System::MathF *v6; // rcx
			//   float v7; // eax
			//   __m128 x_low; // xmm0
			//   __m128 v9; // xmm7
			//   __int128 y_low; // xmm0
			//   System::MathF *v11; // rcx
			//   __m128 v12; // xmm6
			//   System::MathF *v13; // rcx
			//   System::MathF *v14; // rcx
			//   System::MathF *v15; // rcx
			//   float v16; // xmm0_4
			//   __int64 (__fastcall *v17)(_QWORD); // rax
			//   int v18; // eax
			//   __int64 v19; // rdx
			//   int32_t v20; // ecx
			//   HGTerrainGroundLayer *terrainGroundLayer; // rcx
			//   float v22; // eax
			//   __int64 v23; // xmm0_8
			//   void (__fastcall *v24)(Vector3 *); // rax
			//   __int64 v25; // rax
			//   __int64 v26; // rax
			//   __int64 v27; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v30; // [rsp+20h] [rbp-58h] BYREF
			//   Vector3 v31; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3423, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3423, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v27);
			//     z = centerPosition.z;
			//     *(_QWORD *)&v31.x = *(_QWORD *)&centerPosition.x;
			//     v31.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, &v31, 0LL);
			//   }
			//   else
			//   {
			//     v7 = this.fields.curCenter.z;
			//     *(_QWORD *)&this.fields.prevCenter.x = *(_QWORD *)&this.fields.curCenter.x;
			//     x_low = (__m128)LODWORD(centerPosition.x);
			//     x_low.m128_f32[0] = x_low.m128_f32[0] / 6.25;
			//     this.fields.prevCenter.z = v7;
			//     System::MathF::Floor(v6, v3);
			//     v9 = x_low;
			//     y_low = LODWORD(centerPosition.y);
			//     *(float *)&y_low = *(float *)&y_low / 6.25;
			//     v9.m128_f32[0] = v9.m128_f32[0] * 6.25;
			//     System::MathF::Floor(v11, v3);
			//     v12 = (__m128)y_low;
			//     *(float *)&y_low = centerPosition.z / 6.25;
			//     v12.m128_f32[0] = v12.m128_f32[0] * 6.25;
			//     System::MathF::Floor(v13, v3);
			//     *(_QWORD *)&this.fields.curCenter.x = _mm_unpacklo_ps(v9, v12).m128_u64[0];
			//     this.fields.curCenter.z = *(float *)&y_low * 6.25;
			//     *(float *)&y_low = this.fields.curCenter.x;
			//     System::MathF::Floor(v14, v3);
			//     v12.m128_i32[0] = y_low;
			//     *(float *)&y_low = this.fields.curCenter.z;
			//     System::MathF::Floor(v15, v3);
			//     LODWORD(this.fields.subdCenter.y) = y_low;
			//     LODWORD(this.fields.subdCenter.x) = v12.m128_i32[0];
			//     v16 = sub_1801C2670();
			//     v17 = (__int64 (__fastcall *)(_QWORD))qword_18D8F4C60;
			//     if ( !qword_18D8F4C60 )
			//     {
			//       v17 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0("UnityEngine.Mathf::NextPowerOfTwo(System.Int32)");
			//       if ( !v17 )
			//       {
			//         v25 = sub_1802DBBE8("UnityEngine.Mathf::NextPowerOfTwo(System.Int32)");
			//         sub_18000F750(v25, 0LL);
			//       }
			//       qword_18D8F4C60 = (__int64)v17;
			//     }
			//     v18 = v17((unsigned int)(int)v16);
			//     v20 = 64;
			//     if ( v18 < 64 )
			//       v20 = v18;
			//     this.fields.subdWidth = v20;
			//     terrainGroundLayer = this.fields.terrainGroundLayer;
			//     if ( !terrainGroundLayer )
			//       sub_180B536AC(0LL, v19);
			//     v22 = centerPosition.z;
			//     *(_QWORD *)&v30.x = *(_QWORD *)&centerPosition.x;
			//     v30.z = v22;
			//     HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::SetPlayerCenter(terrainGroundLayer, &v30, 0LL);
			//     v23 = *(_QWORD *)&centerPosition.x;
			//     v31.z = centerPosition.z;
			//     v24 = (void (__fastcall *)(Vector3 *))qword_18D8F5CA8;
			//     *(_QWORD *)&v31.x = v23;
			//     if ( !qword_18D8F5CA8 )
			//     {
			//       v24 = (void (__fastcall *)(Vector3 *))il2cpp_resolve_icall_0(
			//                                               "UnityEngine.HyperGryph.HGTerrainDeformManagerV2::SetPlayerCenter_Injected("
			//                                               "UnityEngine.Vector3&)");
			//       if ( !v24 )
			//       {
			//         v26 = sub_1802DBBE8("UnityEngine.HyperGryph.HGTerrainDeformManagerV2::SetPlayerCenter_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v26, 0LL);
			//       }
			//       qword_18D8F5CA8 = (__int64)v24;
			//     }
			//     v24(&v31);
			//   }
			// }
			// 
		}

		public void RenderGroundLayer(HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void RenderGroundLayer(HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::HGTerrainDeformManager::RenderGroundLayer(
			//         HGTerrainDeformManager *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGTerrainGroundLayer *terrainGroundLayer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2840, 0LL) )
			//   {
			//     terrainGroundLayer = this.fields.terrainGroundLayer;
			//     if ( terrainGroundLayer )
			//     {
			//       HG::Rendering::Runtime::TerrainV2::HGTerrainGroundLayer::Render(terrainGroundLayer, renderGraph, hgCamera, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(terrainGroundLayer, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2840, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)renderGraph,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		internal TerrainDeformRenderData GetRenderData()
		{
			// // TerrainDeformRenderData GetRenderData()
			// TerrainDeformRenderData *HG::Rendering::Runtime::HGTerrainDeformManager::GetRenderData(
			//         TerrainDeformRenderData *__return_ptr retstr,
			//         HGTerrainDeformManager *this,
			//         MethodInfo *method)
			// {
			//   float z; // eax
			//   Vector4 v6; // xmm1
			//   Vector4 param2; // xmm0
			//   __int64 v8; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   TerrainDeformRenderData *v12; // rax
			//   Vector4 param1; // xmm1
			//   TerrainDeformRenderData v15; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2837, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2837, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1032(&v15, Patch, (Object *)this, 0LL);
			//     param1 = v12.constData.param1;
			//     retstr.constData.param0 = v12.constData.param0;
			//     param2 = v12.constData.param2;
			//     retstr.constData.param1 = param1;
			//     v8 = *(_QWORD *)&v12.curCenter.x;
			//     z = v12.curCenter.z;
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::TerrainDeformConstData::SetConstData(
			//       &this.fields.m_terrainDeformRenderData.constData,
			//       this,
			//       0LL);
			//     z = this.fields.curCenter.z;
			//     *(_QWORD *)&this.fields.m_terrainDeformRenderData.curCenter.x = *(_QWORD *)&this.fields.curCenter.x;
			//     this.fields.m_terrainDeformRenderData.curCenter.z = z;
			//     v6 = this.fields.m_terrainDeformRenderData.constData.param1;
			//     retstr.constData.param0 = this.fields.m_terrainDeformRenderData.constData.param0;
			//     param2 = this.fields.m_terrainDeformRenderData.constData.param2;
			//     retstr.constData.param1 = v6;
			//     v8 = *(_QWORD *)&this.fields.m_terrainDeformRenderData.curCenter.x;
			//   }
			//   retstr.constData.param2 = param2;
			//   *(_QWORD *)&retstr.curCenter.x = v8;
			//   retstr.curCenter.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public const int TEXTURE_SIZE = 1024;

		public const int HALF_EXTENT = 32;

		public const int HALF_DEPTH_RANGE = 32;

		public Vector3 prevCenter;

		public Vector3 curCenter;

		private float m_remainDeltaTime;

		public float deltaTime;

		private const int kMaxSubdWidth = 64;

		private Vector2 subdCenter;

		private int subdWidth;

		public HGTerrainDeformConfig deformConfig;

		private TerrainDeformRenderData m_terrainDeformRenderData;

		private HGTerrainGroundLayer terrainGroundLayer;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static ComputeShader s_groundLayerCS;
	}
}
