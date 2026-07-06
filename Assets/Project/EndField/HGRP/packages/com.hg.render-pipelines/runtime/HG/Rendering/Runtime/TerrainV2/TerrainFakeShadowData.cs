using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
	public struct TerrainFakeShadowData
	{
		public void SetupTerrainParams(HGRenderGraphContext context)
		{
			// // Void SetupTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::SetupTerrainParams(
			//         TerrainFakeShadowData *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   CommandBuffer *cmd; // rbp
			//   bool EnableFakeShadow; // bl
			//   String *s_FakeShadow; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D3F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D3F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4767, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       EnableFakeShadow = this._EnableFakeShadow;
			//       s_FakeShadow = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_FakeShadow;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_FakeShadow, EnableFakeShadow, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( cmd )
			//       {
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//           cmd,
			//           static_fields._FakeShadowPenumbra,
			//           this._FakeShadowPenumbra,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//           cmd,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FakeShadowStrength,
			//           this._FakeShadowStrength,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//           cmd,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FakeShadowMarchSteps,
			//           this._FakeShadowMarchSteps,
			//           0LL);
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//           cmd,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._FakeShadowDistanceLerp,
			//           this._FakeShadowDistanceLerp,
			//           0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(static_fields, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4767, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1377(Patch, this, (Object *)context, 0LL);
			// }
			// 
		}

		public static void ResetTerrainParams(HGRenderGraphContext context)
		{
			// // Void ResetTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::ResetTerrainParams(
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   CommandBuffer *cmd; // rdi
			//   String *s_FakeShadow; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D40 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D40 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4768, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       s_FakeShadow = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_FakeShadow;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_FakeShadow, 0, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4768, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)context, 0LL);
			// }
			// 
		}

		public HGTerrainFakeShadowData ToDataCPP()
		{
			// // HGTerrainFakeShadowData ToDataCPP()
			// HGTerrainFakeShadowData *HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::ToDataCPP(
			//         HGTerrainFakeShadowData *__return_ptr retstr,
			//         TerrainFakeShadowData *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float FakeShadowPenumbra; // xmm0_4
			//   float FakeShadowStrength; // xmm1_4
			//   float FakeShadowMarchSteps; // xmm2_4
			//   float FakeShadowDistanceLerp; // xmm4_4
			//   __m128 v11; // xmm3
			//   __m128 v12; // xmm3
			//   __m128 v13; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGTerrainFakeShadowData *v16; // rax
			//   __int128 v17; // xmm0
			//   HGTerrainFakeShadowData v18; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 4769 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x12A1 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[101]._1.unity_user_data )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4769, 0LL);
			//       if ( Patch )
			//       {
			//         v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1378(&v18, Patch, this, 0LL);
			//         v17 = *(_OWORD *)&v16.m_enableFakeShadow;
			//         *(float *)&v16 = v16.m_fakeShadowDistanceLerp;
			//         *(_OWORD *)&retstr.m_enableFakeShadow = v17;
			//         LODWORD(retstr.m_fakeShadowDistanceLerp) = (_DWORD)v16;
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   FakeShadowPenumbra = this._FakeShadowPenumbra;
			//   FakeShadowStrength = this._FakeShadowStrength;
			//   FakeShadowMarchSteps = this._FakeShadowMarchSteps;
			//   FakeShadowDistanceLerp = this._FakeShadowDistanceLerp;
			//   *(_WORD *)(&v18.m_enableFakeShadow + 1) = 0;
			//   *(&v18.m_enableFakeShadow + 3) = 0;
			//   v18.m_enableFakeShadow = this._EnableFakeShadow;
			//   v11 = _mm_shuffle_ps(*(__m128 *)&v18.m_enableFakeShadow, *(__m128 *)&v18.m_enableFakeShadow, 225);
			//   v11.m128_f32[0] = FakeShadowPenumbra;
			//   v12 = _mm_shuffle_ps(v11, v11, 198);
			//   v12.m128_f32[0] = FakeShadowStrength;
			//   v13 = _mm_shuffle_ps(v12, v12, 39);
			//   v13.m128_f32[0] = FakeShadowMarchSteps;
			//   *(__m128 *)&retstr.m_enableFakeShadow = _mm_shuffle_ps(v13, v13, 57);
			//   retstr.m_fakeShadowDistanceLerp = FakeShadowDistanceLerp;
			//   return retstr;
			// }
			// 
			return null;
		}

		public bool _EnableFakeShadow;

		public float _FakeShadowPenumbra;

		public float _FakeShadowStrength;

		public float _FakeShadowMarchSteps;

		public float _FakeShadowDistanceLerp;
	}
}
