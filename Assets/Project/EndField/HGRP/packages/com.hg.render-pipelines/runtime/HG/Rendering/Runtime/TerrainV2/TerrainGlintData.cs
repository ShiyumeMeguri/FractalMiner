using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 44)]
	public struct TerrainGlintData
	{
		public void SetupTerrainParams(HGRenderGraphContext context)
		{
			// // Void SetupTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainGlintData::SetupTerrainParams(
			//         TerrainGlintData *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   CommandBuffer *cmd; // rbp
			//   bool EnableFakeGlint; // bl
			//   String *s_FakeGlint; // rdi
			//   int32_t GlintColor; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Color value; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919D39 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D39 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4758, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4758, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1371(Patch, this, (Object *)context, 0LL);
			//   }
			//   else
			//   {
			//     if ( !context )
			//       goto LABEL_7;
			//     cmd = context.fields.cmd;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     EnableFakeGlint = this._EnableFakeGlint;
			//     s_FakeGlint = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_FakeGlint;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_FakeGlint, EnableFakeGlint, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     if ( !cmd )
			// LABEL_7:
			//       sub_180B536AC(static_fields, v5);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(cmd, static_fields._GlintStrength, this._GlintStrength, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintScale,
			//       this._GlintScale,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintThreshold,
			//       this._GlintThreshold,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintFadeDistance,
			//       this._GlintFadeDistance,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintTopBlendSmoothness,
			//       this._GlintTopBlendSmoothness,
			//       0LL);
			//     GlintColor = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintColor;
			//     value = this._GlintColor;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalColor_Injected(cmd, GlintColor, &value, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
			//       cmd,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._GlintTopBlendThreshold,
			//       this._GlintTopBlendThreshold,
			//       0LL);
			//   }
			// }
			// 
		}

		public static void ResetTerrainParams(HGRenderGraphContext context)
		{
			// // Void ResetTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainGlintData::ResetTerrainParams(
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   CommandBuffer *cmd; // rdi
			//   String *s_FakeGlint; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D3A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D3A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4759, 0LL) )
			//   {
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       s_FakeGlint = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_FakeGlint;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_FakeGlint, 0, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4759, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)context, 0LL);
			// }
			// 
		}

		public HGTerrainGlintData ToDataCPP()
		{
			// // HGTerrainGlintData ToDataCPP()
			// HGTerrainGlintData *HG::Rendering::Runtime::TerrainV2::TerrainGlintData::ToDataCPP(
			//         HGTerrainGlintData *__return_ptr retstr,
			//         TerrainGlintData *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int128 v7; // xmm0
			//   __m128i GlintColor; // xmm4
			//   float GlintTopBlendSmoothness; // xmm2_4
			//   float GlintTopBlendThreshold; // xmm3_4
			//   bool EnableFakeGlint; // al
			//   __m128 v12; // xmm0
			//   __m128 v13; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGTerrainGlintData *v16; // rax
			//   __int128 v17; // xmm1
			//   __int64 v18; // xmm0_8
			//   HGTerrainGlintData v19; // [rsp+20h] [rbp-38h] BYREF
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
			//   if ( wrapperArray.max_length.size > 4760 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x1298 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[101]._0.events )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4760, 0LL);
			//       if ( Patch )
			//       {
			//         v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1372(&v19, Patch, this, 0LL);
			//         v17 = *(_OWORD *)&v16.m_glintScale;
			//         *(_OWORD *)&retstr.m_enableFakeGlint = *(_OWORD *)&v16.m_enableFakeGlint;
			//         v18 = *(_QWORD *)&v16.m_glintColor.g;
			//         *(float *)&v16 = v16.m_glintColor.a;
			//         *(_OWORD *)&retstr.m_glintScale = v17;
			//         *(_QWORD *)&retstr.m_glintColor.g = v18;
			//         LODWORD(retstr.m_glintColor.a) = (_DWORD)v16;
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   v7 = *(_OWORD *)&this._GlintStrength;
			//   GlintColor = (__m128i)this._GlintColor;
			//   *(_WORD *)(&v19.m_enableFakeGlint + 1) = 0;
			//   GlintTopBlendSmoothness = this._GlintTopBlendSmoothness;
			//   GlintTopBlendThreshold = this._GlintTopBlendThreshold;
			//   *(_OWORD *)&v19.m_glintStrength = v7;
			//   *(&v19.m_enableFakeGlint + 3) = 0;
			//   EnableFakeGlint = this._EnableFakeGlint;
			//   v19.m_glintColor = (Color)GlintColor;
			//   v19.m_enableFakeGlint = EnableFakeGlint;
			//   v12 = _mm_shuffle_ps(*(__m128 *)&v19.m_enableFakeGlint, *(__m128 *)&v19.m_enableFakeGlint, 225);
			//   v12.m128_f32[0] = GlintTopBlendSmoothness;
			//   v13 = _mm_shuffle_ps(v12, v12, 198);
			//   v13.m128_f32[0] = GlintTopBlendThreshold;
			//   *(__m128 *)&retstr.m_enableFakeGlint = _mm_shuffle_ps(v13, v13, 201);
			//   *(_OWORD *)&retstr.m_glintScale = *(_OWORD *)&v19.m_glintScale;
			//   *(_QWORD *)&retstr.m_glintColor.g = *(_OWORD *)&GlintColor >> 32;
			//   LODWORD(retstr.m_glintColor.a) = _mm_cvtsi128_si32(_mm_srli_si128(GlintColor, 12));
			//   return retstr;
			// }
			// 
			return null;
		}

		public bool _EnableFakeGlint;

		public float _GlintTopBlendSmoothness;

		public float _GlintTopBlendThreshold;

		public float _GlintStrength;

		public float _GlintScale;

		public float _GlintThreshold;

		public float _GlintFadeDistance;

		public Color _GlintColor;
	}
}
