using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGInkManager
	{
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGInkManager instance
		{
			get
			{
				// // HGInkManager get_instance()
				// HGInkManager *HG::Rendering::Runtime::HGInkManager::get_instance(MethodInfo *method)
				// {
				//   HGInkManager *result; // rax
				// 
				//   result = (HGInkManager *)HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
				//   if ( result )
				//     return (HGInkManager *)result[3].fields.m_isCharacterSpeed;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public HGInkManager()
		{
		}

		public void UpdateInkConfig(HGInkSimulationConfig inkSImulationConfig)
		{
			// // Void UpdateInkConfig(HGInkSimulationConfig)
			// void HG::Rendering::Runtime::HGInkManager::UpdateInkConfig(
			//         HGInkManager *this,
			//         HGInkSimulationConfig *inkSImulationConfig,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __m128i v7; // xmm2
			//   __int64 v8; // xmm0_8
			//   bool v9; // cc
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // xmm1_8
			//   __int64 v12; // xmm1_8
			//   HGInkSimulationConfig v13; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8ED97B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED97B = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, inkSImulationConfig);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 764 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x2FC )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[16]._0.fields )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(764, 0LL);
			//       if ( Patch )
			//       {
			//         v11 = *(_QWORD *)&inkSImulationConfig.m_active;
			//         *(_OWORD *)&v13.influence = *(_OWORD *)&inkSImulationConfig.influence;
			//         *(_QWORD *)&v13.m_active = v11;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_289(Patch, (Object *)this, &v13, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_9:
			//   v7 = *(__m128i *)&inkSImulationConfig.influence;
			//   v8 = *(_QWORD *)&inkSImulationConfig.m_active;
			//   v9 = COERCE_FLOAT(*(_OWORD *)&inkSImulationConfig.influence) <= 0.0;
			//   *(_QWORD *)&v13.m_active = v8;
			//   if ( v9 )
			//     goto LABEL_10;
			//   *(_QWORD *)&v13.m_active = v8;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !UnityEngine::Object::op_Inequality((Object_1 *)_mm_srli_si128(v7, 8).m128i_i64[0], 0LL, 0LL) )
			//   {
			// LABEL_10:
			//     this.fields.enabledLastUpdate = 0;
			//   }
			//   else
			//   {
			//     v12 = *(_QWORD *)&inkSImulationConfig.m_active;
			//     *(_OWORD *)&v13.influence = *(_OWORD *)&inkSImulationConfig.influence;
			//     *(_QWORD *)&v13.m_active = v12;
			//     HG::Rendering::Runtime::HGInkManager::_SetToMaterial(this, &v13, 0LL);
			//     this.fields.enabledLastUpdate = 1;
			//   }
			// }
			// 
		}

		public void _UpdateInkParamsV2(int index, bool isCharacterGrounded, float isCharacterSpeed, bool isCharacterLanding, Vector4 characterForwardDir)
		{
			// // Void _UpdateInkParamsV2(Int32, Boolean, Single, Boolean, Vector4)
			// void HG::Rendering::Runtime::HGInkManager::_UpdateInkParamsV2(
			//         HGInkManager *this,
			//         int32_t index,
			//         bool isCharacterGrounded,
			//         float isCharacterSpeed,
			//         bool isCharacterLanding,
			//         Vector4 *characterForwardDir,
			//         MethodInfo *method)
			// {
			//   int v8; // edi
			//   __int64 v9; // rbx
			//   HGInkManager *instance; // rax
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *m_isCharacterGrounded; // rcx
			//   HGInkManager *v13; // rax
			//   HGInkManager *v14; // rax
			//   HGInkManager *v15; // rax
			//   Vector4 v16; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   v8 = isCharacterGrounded;
			//   v9 = index;
			//   if ( !byte_18D919402 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInkManager);
			//     byte_18D919402 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2008, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInkManager);
			//     instance = HG::Rendering::Runtime::HGInkManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)instance.fields.m_isCharacterGrounded;
			//       if ( m_isCharacterGrounded )
			//       {
			//         if ( (unsigned int)v9 >= m_isCharacterGrounded.fields.methodId )
			//           goto LABEL_16;
			//         *((float *)&m_isCharacterGrounded.fields.anonObj + v9) = (float)v8;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInkManager);
			//         v13 = HG::Rendering::Runtime::HGInkManager::get_instance(0LL);
			//         if ( !v13 )
			//           goto LABEL_18;
			//         m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)v13.fields.m_isCharacterSpeed;
			//         if ( !m_isCharacterGrounded )
			//           goto LABEL_18;
			//         if ( (unsigned int)v9 >= m_isCharacterGrounded.fields.methodId )
			//           goto LABEL_16;
			//         *((float *)&m_isCharacterGrounded.fields.anonObj + v9) = isCharacterSpeed;
			//         v14 = HG::Rendering::Runtime::HGInkManager::get_instance(0LL);
			//         if ( !v14 )
			//           goto LABEL_18;
			//         m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)v14.fields.m_isCharacterLanding;
			//         if ( !m_isCharacterGrounded )
			//           goto LABEL_18;
			//         if ( (unsigned int)v9 >= m_isCharacterGrounded.fields.methodId )
			// LABEL_16:
			//           sub_180070270(m_isCharacterGrounded, v11);
			//         *((float *)&m_isCharacterGrounded.fields.anonObj + v9) = (float)isCharacterLanding;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInkManager);
			//         v15 = HG::Rendering::Runtime::HGInkManager::get_instance(0LL);
			//         if ( v15 )
			//         {
			//           m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)v15.fields.m_isCharacterForwardDir;
			//           if ( m_isCharacterGrounded )
			//           {
			//             v16 = *characterForwardDir;
			//             sub_18004D910(m_isCharacterGrounded, v9, &v16);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(m_isCharacterGrounded, v11);
			//   }
			//   m_isCharacterGrounded = IFix::WrappersManagerImpl::GetPatch(2008, 0LL);
			//   if ( !m_isCharacterGrounded )
			//     goto LABEL_18;
			//   v16 = *characterForwardDir;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_770(
			//     m_isCharacterGrounded,
			//     (Object *)this,
			//     v9,
			//     v8,
			//     isCharacterSpeed,
			//     isCharacterLanding,
			//     &v16,
			//     0LL);
			// }
			// 
		}

		public void _SetToMaterial(HGInkSimulationConfig inkSImulationConfig)
		{
			// // Void _SetToMaterial(HGInkSimulationConfig)
			// void HG::Rendering::Runtime::HGInkManager::_SetToMaterial(
			//         HGInkManager *this,
			//         HGInkSimulationConfig *inkSImulationConfig,
			//         MethodInfo *method)
			// {
			//   __m128i v5; // xmm6
			//   Material *static_fields; // rcx
			//   Single__Array *m_isCharacterGrounded; // rax
			//   __int64 monitor_low; // rdx
			//   float v9; // xmm1_4
			//   float v10; // xmm2_4
			//   float v11; // xmm0_4
			//   __m128i v12; // xmm1
			//   Single__Array *m_isCharacterSpeed; // rax
			//   float v14; // xmm3_4
			//   float v15; // xmm2_4
			//   float v16; // xmm0_4
			//   __m128i v17; // xmm1
			//   Single__Array *m_isCharacterLanding; // rax
			//   float v19; // xmm3_4
			//   float v20; // xmm2_4
			//   float v21; // xmm0_4
			//   __m128i v22; // xmm6
			//   HGInkManager__StaticFields *v23; // rcx
			//   int32_t CHARACTER_DIR0; // esi
			//   __m128i v25; // xmm6
			//   HGInkManager__StaticFields *v26; // rcx
			//   int32_t CHARACTER_DIR1; // esi
			//   __m128i v28; // xmm6
			//   HGInkManager__StaticFields *v29; // rcx
			//   int32_t CHARACTER_DIR2; // esi
			//   __m128i v31; // xmm6
			//   int32_t CHARACTER_DIR3; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v34; // xmm1_8
			//   HGInkSimulationConfig v35; // [rsp+20h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919403 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInkManager);
			//     byte_18D919403 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(765, 0LL) )
			//   {
			//     v5 = *(__m128i *)&inkSImulationConfig.influence;
			//     *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInkManager);
			//     static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields;
			//     m_isCharacterGrounded = this.fields.m_isCharacterGrounded;
			//     monitor_low = LODWORD(static_fields.monitor);
			//     if ( !m_isCharacterGrounded )
			//       goto LABEL_30;
			//     if ( m_isCharacterGrounded.max_length.size >= 2u )
			//     {
			//       v9 = m_isCharacterGrounded.vector[1];
			//       if ( m_isCharacterGrounded.max_length.size > 2u )
			//       {
			//         v10 = m_isCharacterGrounded.vector[2];
			//         if ( m_isCharacterGrounded.max_length.size > 3u )
			//         {
			//           static_fields = (Material *)_mm_srli_si128(v5, 8).m128i_u64[0];
			//           v35.influence = m_isCharacterGrounded.vector[0];
			//           v11 = m_isCharacterGrounded.vector[3];
			//           *(float *)&v35.disableWaterInk = v9;
			//           v35.material = (Material *)__PAIR64__(LODWORD(v11), LODWORD(v10));
			//           if ( !static_fields )
			//             goto LABEL_30;
			//           UnityEngine::Material::SetVector(static_fields, monitor_low, (Vector4 *)&v35, 0LL);
			//           v12 = *(__m128i *)&inkSImulationConfig.influence;
			//           static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields;
			//           m_isCharacterSpeed = this.fields.m_isCharacterSpeed;
			//           *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//           monitor_low = HIDWORD(static_fields.monitor);
			//           if ( !m_isCharacterSpeed )
			//             goto LABEL_30;
			//           if ( m_isCharacterSpeed.max_length.size )
			//           {
			//             v14 = m_isCharacterSpeed.vector[0];
			//             if ( m_isCharacterSpeed.max_length.size > 1u )
			//             {
			//               v15 = m_isCharacterSpeed.vector[1];
			//               if ( m_isCharacterSpeed.max_length.size >= 4u )
			//               {
			//                 static_fields = (Material *)_mm_srli_si128(v12, 8).m128i_u64[0];
			//                 *(float *)&v35.material = m_isCharacterSpeed.vector[2];
			//                 v16 = m_isCharacterSpeed.vector[3];
			//                 v35.influence = v14;
			//                 *(float *)&v35.disableWaterInk = v15;
			//                 *((float *)&v35.material + 1) = v16;
			//                 if ( !static_fields )
			//                   goto LABEL_30;
			//                 UnityEngine::Material::SetVector(static_fields, monitor_low, (Vector4 *)&v35, 0LL);
			//                 v17 = *(__m128i *)&inkSImulationConfig.influence;
			//                 static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields;
			//                 m_isCharacterLanding = this.fields.m_isCharacterLanding;
			//                 *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//                 monitor_low = LODWORD(static_fields.fields._.m_CachedPtr);
			//                 if ( !m_isCharacterLanding )
			//                   goto LABEL_30;
			//                 if ( m_isCharacterLanding.max_length.size )
			//                 {
			//                   v19 = m_isCharacterLanding.vector[0];
			//                   if ( m_isCharacterLanding.max_length.size > 1u )
			//                   {
			//                     v20 = m_isCharacterLanding.vector[1];
			//                     if ( m_isCharacterLanding.max_length.size >= 4u )
			//                     {
			//                       static_fields = (Material *)_mm_srli_si128(v17, 8).m128i_u64[0];
			//                       *(float *)&v35.material = m_isCharacterLanding.vector[2];
			//                       v21 = m_isCharacterLanding.vector[3];
			//                       v35.influence = v19;
			//                       *(float *)&v35.disableWaterInk = v20;
			//                       *((float *)&v35.material + 1) = v21;
			//                       if ( static_fields )
			//                       {
			//                         UnityEngine::Material::SetVector(static_fields, monitor_low, (Vector4 *)&v35, 0LL);
			//                         v22 = *(__m128i *)&inkSImulationConfig.influence;
			//                         v23 = TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields;
			//                         *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//                         CHARACTER_DIR0 = v23.CHARACTER_DIR0;
			//                         static_fields = (Material *)this.fields.m_isCharacterForwardDir;
			//                         if ( static_fields )
			//                         {
			//                           sub_180037190(static_fields, &v35, 0LL);
			//                           static_fields = (Material *)_mm_srli_si128(v22, 8).m128i_u64[0];
			//                           if ( static_fields )
			//                           {
			//                             UnityEngine::Material::SetVector(static_fields, CHARACTER_DIR0, (Vector4 *)&v35, 0LL);
			//                             v25 = *(__m128i *)&inkSImulationConfig.influence;
			//                             v26 = TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields;
			//                             *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//                             CHARACTER_DIR1 = v26.CHARACTER_DIR1;
			//                             static_fields = (Material *)this.fields.m_isCharacterForwardDir;
			//                             if ( static_fields )
			//                             {
			//                               sub_180037190(static_fields, &v35, 1LL);
			//                               static_fields = (Material *)_mm_srli_si128(v25, 8).m128i_u64[0];
			//                               if ( static_fields )
			//                               {
			//                                 UnityEngine::Material::SetVector(static_fields, CHARACTER_DIR1, (Vector4 *)&v35, 0LL);
			//                                 v28 = *(__m128i *)&inkSImulationConfig.influence;
			//                                 v29 = TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields;
			//                                 *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//                                 CHARACTER_DIR2 = v29.CHARACTER_DIR2;
			//                                 static_fields = (Material *)this.fields.m_isCharacterForwardDir;
			//                                 if ( static_fields )
			//                                 {
			//                                   sub_180037190(static_fields, &v35, 2LL);
			//                                   static_fields = (Material *)_mm_srli_si128(v28, 8).m128i_u64[0];
			//                                   if ( static_fields )
			//                                   {
			//                                     UnityEngine::Material::SetVector(
			//                                       static_fields,
			//                                       CHARACTER_DIR2,
			//                                       (Vector4 *)&v35,
			//                                       0LL);
			//                                     v31 = *(__m128i *)&inkSImulationConfig.influence;
			//                                     *(_QWORD *)&v35.m_active = *(_QWORD *)&inkSImulationConfig.m_active;
			//                                     CHARACTER_DIR3 = TypeInfo::HG::Rendering::Runtime::HGInkManager.static_fields.CHARACTER_DIR3;
			//                                     static_fields = (Material *)this.fields.m_isCharacterForwardDir;
			//                                     if ( static_fields )
			//                                     {
			//                                       sub_180037190(static_fields, &v35, 3LL);
			//                                       static_fields = (Material *)_mm_srli_si128(v31, 8).m128i_u64[0];
			//                                       if ( static_fields )
			//                                       {
			//                                         UnityEngine::Material::SetVector(
			//                                           static_fields,
			//                                           CHARACTER_DIR3,
			//                                           (Vector4 *)&v35,
			//                                           0LL);
			//                                         return;
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			// LABEL_30:
			//                       sub_180B536AC(static_fields, monitor_low);
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//     sub_180070270(static_fields, monitor_low);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(765, 0LL);
			//   if ( !Patch )
			//     goto LABEL_30;
			//   v34 = *(_QWORD *)&inkSImulationConfig.m_active;
			//   *(_OWORD *)&v35.influence = *(_OWORD *)&inkSImulationConfig.influence;
			//   *(_QWORD *)&v35.m_active = v34;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_289(Patch, (Object *)this, &v35, 0LL);
			// }
			// 
		}

		public bool enabledLastUpdate;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int ANGLE_THRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		public static readonly int LANDING_EXTRA_THRESHOLD;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly int CHARACTER_ON_GROUNDS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		public static readonly int CHARACTER_SPEEDS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly int CHARACTER_LANDINGS;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		public static readonly int CHARACTER_DIR0;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		public static readonly int CHARACTER_DIR1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		public static readonly int CHARACTER_DIR2;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static readonly int CHARACTER_DIR3;

		private float[] m_isCharacterGrounded;

		private float[] m_isCharacterSpeed;

		private float[] m_isCharacterLanding;

		private Vector4[] m_isCharacterForwardDir;
	}
}
