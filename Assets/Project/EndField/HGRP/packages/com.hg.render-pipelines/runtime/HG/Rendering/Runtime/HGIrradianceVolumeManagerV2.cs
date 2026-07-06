using System;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGIrradianceVolumeManagerV2
	{
		public HGIrradianceVolumeManagerV2()
		{
		}

		public void PipelineUpdateV2(out HGIrradianceVolumePipelineUpdateResultV2 result, ScriptableRenderContext renderContext, Camera primaryCamera, Transform currentPlayerCenter, ComputeShader ivBakeV2CS, ComputeShader ivClipmapUpdateCS)
		{
			// // Void PipelineUpdateV2(HGIrradianceVolumePipelineUpdateResultV2 ByRef, ScriptableRenderContext, Camera, Transform, ComputeShader, ComputeShader)
			// // Hidden C++ exception states: #wind=13
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::PipelineUpdateV2(
			//         HGIrradianceVolumeManagerV2 *this,
			//         HGIrradianceVolumePipelineUpdateResultV2 *result,
			//         ScriptableRenderContext renderContext,
			//         Camera *primaryCamera,
			//         Transform *currentPlayerCenter,
			//         ComputeShader *ivBakeV2CS,
			//         ComputeShader *ivClipmapUpdateCS,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v14; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // r14
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   MessageDescriptor *v23; // r9
			//   OneofDescriptorProto *v24; // rdx
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   OneofDescriptorProto *v30; // rdx
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   OneofDescriptorProto *v33; // rdx
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   OneofDescriptorProto *v36; // rdx
			//   FileDescriptor *v37; // r8
			//   MessageDescriptor *v38; // r9
			//   OneofDescriptorProto *v39; // rdx
			//   FileDescriptor *v40; // r8
			//   MessageDescriptor *v41; // r9
			//   String *m_lastDataPathV2; // r8
			//   String *m_irradianceDataPathV2; // rdx
			//   int32_t stringLength; // eax
			//   __int64 (__fastcall *v45)(_DWORD *); // rax
			//   Transform *v46; // r15
			//   Transform *v47; // rbx
			//   __int64 v48; // rdx
			//   Object_1 *main; // rbx
			//   __int64 v50; // rdx
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   Transform *transform; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   Camera *v56; // rbx
			//   __int64 (__fastcall *v57)(Camera *); // rax
			//   unsigned __int64 v58; // xmm7_8
			//   float z; // r13d
			//   __int64 v60; // rdx
			//   Camera *v61; // rbx
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   Camera *v64; // rbx
			//   __int64 (__fastcall *v65)(Camera *); // rax
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   __int64 v68; // rbx
			//   void (__fastcall *v69)(__int64, Quaternion *); // rax
			//   Vector3 *forward; // rax
			//   __int64 v71; // rdx
			//   __int64 v72; // rcx
			//   Transform *v73; // rax
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   int64_t m_defaultIV; // rdi
			//   struct HGGraphicsFeatureManager__Class *v77; // rax
			//   HGGraphicsFeatureSwitch *irradianceVolumeV2; // rbx
			//   __int64 v79; // rdx
			//   __int64 v80; // rdx
			//   __int64 v81; // rcx
			//   __int64 v82; // rdx
			//   struct ScriptableRenderContext__Class *v83; // rdi
			//   void *m_Ptr; // rbx
			//   __int64 v85; // rdx
			//   int32_t InstanceID; // edi
			//   int32_t v87; // eax
			//   unsigned int v88; // eax
			//   __int64 v89; // rax
			//   const char *v90; // rax
			//   __int64 v91; // rbx
			//   __int64 v92; // r9
			//   __int64 v93; // rax
			//   OneofDescriptorProto *v94; // rdx
			//   FileDescriptor *v95; // r8
			//   __int64 v96; // r9
			//   uint32_t v97; // eax
			//   bool v98; // cl
			//   struct ScriptableRenderContext__Class *v99; // rdi
			//   CommandBuffer *v100; // rdi
			//   il2cpp_baselib *v101; // rcx
			//   struct CommandBufferPool__Class *v102; // r15
			//   __int64 CurrentThreadId; // rbx
			//   __int64 v104; // rax
			//   int v105; // r15d
			//   const char *v106; // r8
			//   __int64 v107; // rbx
			//   _QWORD *v108; // r9
			//   __int64 v109; // rax
			//   OneofDescriptorProto *v110; // rdx
			//   FileDescriptor *v111; // r8
			//   __int64 v112; // r9
			//   uint32_t v113; // eax
			//   bool v114; // cl
			//   unsigned int v115; // eax
			//   unsigned int v116; // ebx
			//   __int64 v117; // rcx
			//   __int64 v118; // r15
			//   unsigned int v119; // eax
			//   unsigned int v120; // eax
			//   unsigned int v121; // ebx
			//   __int64 v122; // rcx
			//   __int64 v123; // rdi
			//   unsigned int v124; // eax
			//   il2cpp_array_size_t v125; // rdx
			//   struct CommandBufferPool__Class *parent; // rbx
			//   __int64 i; // r10
			//   __int64 v128; // rcx
			//   char v129; // al
			//   const char *v130; // r8
			//   CommandBuffer *v131; // rbx
			//   _QWORD *v132; // r9
			//   __int64 v133; // rax
			//   OneofDescriptorProto *v134; // rdx
			//   FileDescriptor *v135; // r8
			//   __int64 v136; // r9
			//   uint32_t v137; // eax
			//   bool v138; // cl
			//   __int64 v139; // rax
			//   __int64 v140; // rax
			//   __int64 v141; // rax
			//   __int64 v142; // rax
			//   __int64 target_0; // rax
			//   __int64 v144; // rax
			//   Object *P3; // [rsp+20h] [rbp-288h]
			//   Object *P3c; // [rsp+20h] [rbp-288h]
			//   Object *P3d; // [rsp+20h] [rbp-288h]
			//   Object *P3e; // [rsp+20h] [rbp-288h]
			//   Object *P3f; // [rsp+20h] [rbp-288h]
			//   Object *P3g; // [rsp+20h] [rbp-288h]
			//   Object *P3a; // [rsp+20h] [rbp-288h]
			//   Object *P3b; // [rsp+20h] [rbp-288h]
			//   Object *P4; // [rsp+28h] [rbp-280h]
			//   Object *P4c; // [rsp+28h] [rbp-280h]
			//   Object *P4d; // [rsp+28h] [rbp-280h]
			//   Object *P4e; // [rsp+28h] [rbp-280h]
			//   Object *P4f; // [rsp+28h] [rbp-280h]
			//   Object *P4g; // [rsp+28h] [rbp-280h]
			//   Object *P4a; // [rsp+28h] [rbp-280h]
			//   Object *P4b; // [rsp+28h] [rbp-280h]
			//   MethodInfo *P5; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5c; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5d; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5e; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5f; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5g; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5a; // [rsp+30h] [rbp-278h]
			//   MethodInfo *P5b; // [rsp+30h] [rbp-278h]
			//   unsigned __int8 v169; // [rsp+50h] [rbp-258h] BYREF
			//   Vector3 cameraForwardDir; // [rsp+60h] [rbp-248h] BYREF
			//   unsigned int v171; // [rsp+70h] [rbp-238h]
			//   Vector3 center; // [rsp+80h] [rbp-228h] BYREF
			//   CommandBuffer *cmd; // [rsp+90h] [rbp-218h] BYREF
			//   Quaternion v174; // [rsp+A0h] [rbp-208h] BYREF
			//   unsigned __int64 v175; // [rsp+B8h] [rbp-1F0h]
			//   Vector3 id; // [rsp+C0h] [rbp-1E8h] BYREF
			//   _QWORD v177[3]; // [rsp+D0h] [rbp-1D8h] BYREF
			//   unsigned __int64 v178; // [rsp+E8h] [rbp-1C0h]
			//   _DWORD v179[4]; // [rsp+F0h] [rbp-1B8h] BYREF
			//   __m128i si128; // [rsp+100h] [rbp-1A8h]
			//   __m128i v181; // [rsp+110h] [rbp-198h]
			//   __m128i v182; // [rsp+120h] [rbp-188h]
			//   int v183; // [rsp+130h] [rbp-178h]
			//   int v184; // [rsp+134h] [rbp-174h]
			//   int v185; // [rsp+138h] [rbp-170h]
			//   int v186; // [rsp+13Ch] [rbp-16Ch]
			//   int v187; // [rsp+140h] [rbp-168h]
			//   int v188; // [rsp+144h] [rbp-164h]
			//   int v189; // [rsp+148h] [rbp-160h]
			//   int v190; // [rsp+14Ch] [rbp-15Ch]
			//   int v191; // [rsp+150h] [rbp-158h]
			//   int v192; // [rsp+154h] [rbp-154h]
			//   int v193; // [rsp+158h] [rbp-150h]
			//   int v194; // [rsp+15Ch] [rbp-14Ch]
			//   __int64 v195; // [rsp+160h] [rbp-148h]
			//   int v196; // [rsp+168h] [rbp-140h]
			//   int v197; // [rsp+16Ch] [rbp-13Ch]
			//   __m128i v198; // [rsp+170h] [rbp-138h]
			//   __m128i v199; // [rsp+180h] [rbp-128h]
			//   __int64 v200; // [rsp+190h] [rbp-118h]
			//   int v201; // [rsp+198h] [rbp-110h]
			//   int v202; // [rsp+19Ch] [rbp-10Ch]
			//   int v203; // [rsp+1A0h] [rbp-108h]
			//   __int64 v204; // [rsp+1A4h] [rbp-104h]
			//   int v205; // [rsp+1ACh] [rbp-FCh]
			//   int v206; // [rsp+1B0h] [rbp-F8h]
			//   int v207; // [rsp+1B4h] [rbp-F4h]
			//   int v208; // [rsp+1B8h] [rbp-F0h]
			//   __int64 v209; // [rsp+1BCh] [rbp-ECh]
			//   int v210; // [rsp+1C4h] [rbp-E4h]
			//   int v211; // [rsp+1C8h] [rbp-E0h]
			//   int v212; // [rsp+1CCh] [rbp-DCh]
			//   int v213; // [rsp+1D0h] [rbp-D8h]
			//   __int64 v214; // [rsp+1D4h] [rbp-D4h]
			//   int v215; // [rsp+1DCh] [rbp-CCh]
			//   int v216; // [rsp+1E0h] [rbp-C8h]
			//   int v217; // [rsp+1E4h] [rbp-C4h]
			//   int v218; // [rsp+1E8h] [rbp-C0h]
			//   __int64 v219; // [rsp+1ECh] [rbp-BCh]
			//   int v220; // [rsp+1F4h] [rbp-B4h]
			//   int v221; // [rsp+1F8h] [rbp-B0h]
			//   int v222; // [rsp+1FCh] [rbp-ACh]
			//   int v223; // [rsp+200h] [rbp-A8h]
			//   int v224; // [rsp+204h] [rbp-A4h]
			//   int v225; // [rsp+208h] [rbp-A0h]
			//   int v226; // [rsp+20Ch] [rbp-9Ch]
			//   int v227; // [rsp+210h] [rbp-98h]
			//   int v228; // [rsp+214h] [rbp-94h]
			//   int v229; // [rsp+218h] [rbp-90h]
			//   int v230; // [rsp+21Ch] [rbp-8Ch]
			//   int v231; // [rsp+220h] [rbp-88h]
			//   int v232; // [rsp+224h] [rbp-84h]
			//   Il2CppExceptionWrapper *v233; // [rsp+230h] [rbp-78h] BYREF
			//   _BYTE v234[72]; // [rsp+238h] [rbp-70h] BYREF
			//   ScriptableRenderContext P2; // [rsp+2C0h] [rbp+18h] BYREF
			// 
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   v171 = 0;
			//   if ( !byte_18D8EDCDF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D8EDCDF = 1;
			//   }
			//   sub_1802F01E0(v179, 0LL, 312LL);
			//   v169 = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v11);
			//     v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v12.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v12, v11);
			//   if ( wrapperArray.max_length.size > 635 )
			//   {
			//     if ( !v12._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v12, v11);
			//       v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v14 = v12.static_fields.wrapperArray;
			//     if ( !v14 )
			//       sub_180B536AC(v12, v11);
			//     if ( v14.max_length.size <= 0x27Bu )
			//       sub_180070270(v12, v11);
			//     if ( v14[17].vector[23] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(635, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v16, v15);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_237(
			//         Patch,
			//         (Object *)this,
			//         result,
			//         P2,
			//         (Object *)primaryCamera,
			//         (Object *)currentPlayerCenter,
			//         (Object *)ivBakeV2CS,
			//         (Object *)ivClipmapUpdateCS,
			//         0LL);
			//       return;
			//     }
			//   }
			//   result.param0 = 0LL;
			//   result.param1 = 0LL;
			//   result.param2 = 0LL;
			//   result.param3 = 0LL;
			//   result.clipmapTextureALod0 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0((OneofDescriptor *)&result.clipmapTextureALod0, v18, v19, v20, (String__Array *)P3, (String *)P4, P5);
			//   result.clipmapTextureBLod0 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&result.clipmapTextureBLod0,
			//     v21,
			//     v22,
			//     v23,
			//     (String__Array *)P3c,
			//     (String *)P4c,
			//     P5c);
			//   result.clipmapTextureALod1 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&result.clipmapTextureALod1,
			//     v24,
			//     v25,
			//     v26,
			//     (String__Array *)P3d,
			//     (String *)P4d,
			//     P5d);
			//   result.clipmapTextureBLod1 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&result.clipmapTextureBLod1,
			//     v27,
			//     v28,
			//     v29,
			//     (String__Array *)P3e,
			//     (String *)P4e,
			//     P5e);
			//   result.clipmapTextureALod3 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&result.clipmapTextureALod3,
			//     v30,
			//     v31,
			//     v32,
			//     (String__Array *)P3f,
			//     (String *)P4f,
			//     P5f);
			//   result.clipmapTextureBLod3 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&result.clipmapTextureBLod3,
			//     v33,
			//     v34,
			//     v35,
			//     (String__Array *)P3g,
			//     (String *)P4g,
			//     P5g);
			//   if ( this.fields.m_defaultIV )
			//   {
			//     this.fields.m_irradianceDataPathV2 = (String *)"";
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_irradianceDataPathV2,
			//       v36,
			//       v37,
			//       v38,
			//       (String__Array *)P3a,
			//       (String *)P4a,
			//       P5a);
			//     if ( this.fields.m_exportpathV2 )
			//     {
			//       this.fields.m_irradianceDataPathV2 = this.fields.m_exportpathV2;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_irradianceDataPathV2,
			//         v39,
			//         v40,
			//         v41,
			//         (String__Array *)P3a,
			//         (String *)P4a,
			//         P5a);
			//     }
			//     m_lastDataPathV2 = this.fields.m_lastDataPathV2;
			//     m_irradianceDataPathV2 = this.fields.m_irradianceDataPathV2;
			//     if ( m_lastDataPathV2 != m_irradianceDataPathV2 )
			//     {
			//       if ( !m_lastDataPathV2
			//         || !m_irradianceDataPathV2
			//         || (stringLength = m_lastDataPathV2.fields._stringLength,
			//             stringLength != m_irradianceDataPathV2.fields._stringLength)
			//         || !System::SpanHelpers::SequenceEqual(
			//               (uint8_t *)&m_lastDataPathV2.fields._firstChar,
			//               (uint8_t *)&m_irradianceDataPathV2.fields._firstChar,
			//               2LL * stringLength,
			//               0LL) )
			//       {
			//         this.fields.m_lastDataPathV2 = this.fields.m_irradianceDataPathV2;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_lastDataPathV2,
			//           (OneofDescriptorProto *)m_irradianceDataPathV2,
			//           (FileDescriptor *)m_lastDataPathV2,
			//           v41,
			//           (String__Array *)P3a,
			//           (String *)P4a,
			//           P5a);
			//         UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetMap(
			//           this.fields.m_defaultIV,
			//           this.fields.m_irradianceDataPathV2,
			//           0LL);
			//       }
			//     }
			//   }
			//   else
			//   {
			//     v179[0] = 0;
			//     v179[1] = 128;
			//     v179[2] = 64;
			//     v179[3] = 128;
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18C370EB0);
			//     v181 = _mm_load_si128((const __m128i *)&xmmword_18C370EA0);
			//     v182 = _mm_load_si128((const __m128i *)&xmmword_18C370E80);
			//     v183 = 6;
			//     v184 = 27;
			//     v188 = 8;
			//     v189 = 64;
			//     v190 = 128;
			//     v185 = 8;
			//     v186 = 128;
			//     v187 = 128;
			//     v191 = 5;
			//     v192 = 13;
			//     v193 = 2048;
			//     v194 = 52;
			//     v195 = 288LL;
			//     v196 = 1;
			//     v197 = 3;
			//     v198 = _mm_load_si128((const __m128i *)&xmmword_18C370E70);
			//     v199 = _mm_load_si128((const __m128i *)&xmmword_18C370E90);
			//     v200 = 17LL;
			//     v203 = 144;
			//     v204 = 144LL;
			//     v201 = 144;
			//     v202 = 288;
			//     v208 = 9216;
			//     v209 = 9216LL;
			//     v205 = 0;
			//     v206 = 9216;
			//     v207 = 18432;
			//     v213 = 256;
			//     v214 = 256LL;
			//     v210 = 0;
			//     v211 = 256;
			//     v212 = 512;
			//     v218 = 256;
			//     v219 = 256LL;
			//     v215 = 0;
			//     v216 = 256;
			//     v217 = 512;
			//     v220 = 0x100000;
			//     v221 = 0x100000;
			//     v222 = 0x100000;
			//     v223 = 4;
			//     v224 = 4;
			//     v225 = 8;
			//     v226 = 8;
			//     v227 = 80;
			//     v228 = 40;
			//     v229 = 80;
			//     v230 = 1098907648;
			//     v231 = 1115684864;
			//     v232 = 1132462080;
			//     v45 = (__int64 (__fastcall *)(_DWORD *))qword_18D8F5B30;
			//     if ( !qword_18D8F5B30 )
			//     {
			//       v45 = (__int64 (__fastcall *)(_DWORD *))il2cpp_resolve_icall_0(
			//                                                 "UnityEngine.HyperGryph.HGIrradianceVolumeV2::Create(UnityEngine.HyperGry"
			//                                                 "ph.HGIrradianceVolumeConfigV2&)");
			//       if ( !v45 )
			//       {
			//         v140 = sub_1802DBBE8(
			//                  "UnityEngine.HyperGryph.HGIrradianceVolumeV2::Create(UnityEngine.HyperGryph.HGIrradianceVolumeConfigV2&)");
			//         sub_18000F750(v140, 0LL);
			//       }
			//       qword_18D8F5B30 = (__int64)v45;
			//     }
			//     this.fields.m_defaultIV = v45(v179);
			//   }
			//   v46 = 0LL;
			//   if ( !this.fields.m_gachaIV )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV2);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV2);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     v47 = currentPlayerCenter;
			//     if ( currentPlayerCenter )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV2);
			//       if ( v47.fields._._.m_CachedPtr )
			//       {
			//         v46 = v47;
			//         goto LABEL_60;
			//       }
			//     }
			//   }
			//   main = (Object_1 *)UnityEngine::Camera::get_main(0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v48);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v48);
			//   if ( !UnityEngine::Object::CompareBaseObjects(main, 0LL, 0LL) )
			//   {
			//     v56 = UnityEngine::Camera::get_main(0LL);
			//     if ( !v56 )
			//       sub_180B536AC(v55, v54);
			//     v57 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v57 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Component::get_transform()");
			//       qword_18D8F4D40 = (__int64)v57;
			//     }
			//     transform = (Transform *)v57(v56);
			//     goto LABEL_59;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v50);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)primaryCamera, 0LL, 0LL) )
			//   {
			//     if ( !primaryCamera )
			//       sub_180B536AC(v52, v51);
			//     transform = UnityEngine::Component::get_transform((Component *)primaryCamera, 0LL);
			// LABEL_59:
			//     v46 = transform;
			//   }
			// LABEL_60:
			//   v58 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   z = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)0LL));
			//   v61 = UnityEngine::Camera::get_main(0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v61 )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//     if ( v61.fields._._._.m_CachedPtr )
			//     {
			//       v64 = UnityEngine::Camera::get_main(0LL);
			//       if ( !v64 )
			//         sub_180B536AC(v63, v62);
			//       v65 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v65 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//         if ( !v65 )
			//         {
			//           v141 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//           sub_18000F750(v141, 0LL);
			//         }
			//         qword_18D8F4D40 = (__int64)v65;
			//       }
			//       v68 = v65(v64);
			//       if ( !v68 )
			//         sub_180B536AC(v67, v66);
			//       v174 = 0LL;
			//       v69 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
			//       if ( !qword_18D8F5300 )
			//       {
			//         v69 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//         if ( !v69 )
			//         {
			//           v142 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//           sub_18000F750(v142, 0LL);
			//         }
			//         qword_18D8F5300 = (__int64)v69;
			//       }
			//       v69(v68, &v174);
			//       *(_QWORD *)&center.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//       center.z = 1.0;
			//       forward = UnityEngine::Quaternion::op_Multiply(&id, &v174, &center, 0LL);
			// LABEL_87:
			//       z = forward.z;
			//       v58 = *(_QWORD *)&forward.x;
			//       goto LABEL_88;
			//     }
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v60);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)primaryCamera, 0LL, 0LL) )
			//   {
			//     if ( !primaryCamera )
			//       sub_180B536AC(v72, v71);
			//     v73 = UnityEngine::Component::get_transform((Component *)primaryCamera, 0LL);
			//     if ( !v73 )
			//       sub_180B536AC(v75, v74);
			//     forward = UnityEngine::Transform::get_forward(&center, v73, 0LL);
			//     goto LABEL_87;
			//   }
			// LABEL_88:
			//   m_defaultIV = this.fields.m_defaultIV;
			//   *(_QWORD *)&id.x = m_defaultIV;
			//   v77 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, v71);
			//     v77 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   }
			//   irradianceVolumeV2 = v77.static_fields.irradianceVolumeV2;
			//   if ( !irradianceVolumeV2 )
			//     sub_180B536AC(v72, v71);
			//   if ( irradianceVolumeV2.fields.m_defaultValue )
			//   {
			//     if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CommandBufferPool, v71);
			//     cmd = UnityEngine::Rendering::CommandBufferPool::Get((String *)"", 0LL);
			//     if ( m_defaultIV )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v79);
			//       if ( UnityEngine::Object::op_Inequality((Object_1 *)v46, 0LL, 0LL) )
			//       {
			//         if ( !v46 )
			//           sub_180B536AC(v81, v80);
			//         center = *UnityEngine::Transform::get_position(&cameraForwardDir, v46, 0LL);
			//         UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetStreamingCenter_Injected(m_defaultIV, &center, 0LL);
			//         *(_QWORD *)&cameraForwardDir.x = v58;
			//         cameraForwardDir.z = z;
			//         UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetCameraForwardDirection_Injected(
			//           m_defaultIV,
			//           &cameraForwardDir,
			//           0LL);
			//       }
			//       UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//         (Int32Enum__Enum)0xC1u,
			//         MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       *(_QWORD *)&v174.x = 0LL;
			//       *(_QWORD *)&v174.z = &v169;
			//       try
			//       {
			//         v83 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
			//         if ( TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//           goto LABEL_104;
			//         sub_1802924D0(&qword_18CDBFAA0);
			//         if ( _InterlockedCompareExchange((volatile signed __int32 *)&v83._1.cctor_finished_or_no_cctor, 1, 1) == 1 )
			//         {
			//           sub_180292530(&qword_18CDBFAA0);
			// LABEL_104:
			//           m_Ptr = P2.m_Ptr;
			//           if ( !ivBakeV2CS )
			//             sub_1802DC2C8(0LL, v82);
			//           InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)ivBakeV2CS, 0LL);
			//           if ( !ivClipmapUpdateCS )
			//             sub_1802DC2C8(0LL, v85);
			//           v87 = UnityEngine::Object::GetInstanceID((Object_1 *)ivClipmapUpdateCS, 0LL);
			//           UnityEngine::HyperGryph::HGIrradianceVolumeV2::PipelineUpdate(
			//             result,
			//             *(int64_t *)&id.x,
			//             m_Ptr,
			//             cmd,
			//             InstanceID,
			//             v87,
			//             0LL);
			//           goto LABEL_243;
			//         }
			//         if ( _InterlockedCompareExchange((volatile signed __int32 *)&v83._1.cctor_started, 1, 1) == 1 )
			//         {
			//           sub_180292530(&qword_18CDBFAA0);
			//           v88 = ((__int64 (*)(void))GetCurrentThreadId)();
			//           if ( v88 == _InterlockedCompareExchange64((volatile signed __int64 *)&v83._1.cctor_thread, v88, v88) )
			//             goto LABEL_104;
			//           while ( _InterlockedCompareExchange((volatile signed __int32 *)&v83._1.cctor_finished_or_no_cctor, 1, 1) != 1
			//                && !_InterlockedCompareExchange(
			//                      (volatile signed __int32 *)&v83._1.initializationExceptionGCHandle,
			//                      0,
			//                      0) )
			//             sub_18006E120(1LL, 0LL);
			//         }
			//         else
			//         {
			//           _InterlockedExchange64(
			//             (volatile __int64 *)&v83._1.cctor_thread,
			//             (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
			//           _InterlockedExchange((volatile __int32 *)&v83._1.cctor_started, 1);
			//           sub_180292530(&qword_18CDBFAA0);
			//           *(_QWORD *)&cameraForwardDir.x = 0LL;
			//           if ( (BYTE1(v83.vtable.Equals.methodPtr) & 4) != 0 )
			//           {
			//             v89 = sub_180039210((_DWORD)v83, (unsigned int)".cctor", -1, 2048, 0LL);
			//             if ( v89 )
			//               il2cpp_runtime_invoke_0(v89, 0LL, 0LL, &cameraForwardDir);
			//           }
			//           _InterlockedExchange64((volatile __int64 *)&v83._1.cctor_thread, 0LL);
			//           if ( *(_QWORD *)&cameraForwardDir.x )
			//           {
			//             sub_180007B40(v177);
			//             v171 = 1;
			//             sub_1800179B0(v177, &v83._0.byval_arg, 0LL, 0LL);
			//             v90 = (const char *)sub_180006C00(v177);
			//             sub_180016840(v234, "The type initializer for '%s' threw an exception.", v90);
			//             v171 = 0;
			//             sub_180006B90(v177);
			//             v91 = *(_QWORD *)&cameraForwardDir.x;
			//             v92 = sub_180006C00(v234);
			//             v93 = il2cpp_exception_from_name_msg_0(qword_18D8E4510, "System", "TypeInitializationException", v92);
			//             v96 = v93;
			//             if ( v91 )
			//             {
			//               *(_QWORD *)(v93 + 40) = v91;
			//               sub_1800054D0(
			//                 (OneofDescriptor *)(v93 + 40),
			//                 v94,
			//                 v95,
			//                 (MessageDescriptor *)v93,
			//                 (String__Array *)P3a,
			//                 (String *)P4a,
			//                 P5a);
			//             }
			//             v97 = sub_1802DC930(&qword_18CDBF7F0, v96, 0LL);
			//             v83._1.initializationExceptionGCHandle = v97;
			//             v98 = ((__int64)v83.vtable.Equals.methodPtr & 2) != 0 && !v97;
			//             LOBYTE(v83.vtable.Equals.methodPtr) = v98 | (__int64)v83.vtable.Equals.methodPtr & 0xFE;
			//             sub_180006B90(v234);
			//           }
			//           else
			//           {
			//             _InterlockedExchange((volatile __int32 *)&v83._1.cctor_finished_or_no_cctor, 1);
			//           }
			//         }
			//         if ( v83._1.initializationExceptionGCHandle )
			//         {
			//           target_0 = mono_gchandle_get_target_0(v83._1.initializationExceptionGCHandle);
			//           sub_18000F750(target_0, 0LL);
			//         }
			//         goto LABEL_104;
			//       }
			//       catch ( Il2CppExceptionWrapper *v233 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v174.x = (Il2CppExceptionWrapper)v233.ex;
			//         if ( *(_QWORD *)&v174.x )
			//           sub_18000F780(*(_QWORD *)&v174.x);
			//       }
			// LABEL_243:
			//       v99 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
			//       if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//       {
			//         sub_1802924D0(&qword_18CDBFAA0);
			//         if ( _InterlockedCompareExchange((volatile signed __int32 *)&v99._1.cctor_finished_or_no_cctor, 1, 1) == 1 )
			//         {
			//           sub_180292530(&qword_18CDBFAA0);
			//           goto LABEL_130;
			//         }
			//         if ( _InterlockedCompareExchange((volatile signed __int32 *)&v99._1.cctor_started, 1, 1) == 1 )
			//         {
			//           sub_180292530(&qword_18CDBFAA0);
			//           v115 = ((__int64 (*)(void))GetCurrentThreadId)();
			//           if ( v115 == _InterlockedCompareExchange64((volatile signed __int64 *)&v99._1.cctor_thread, v115, v115) )
			//             goto LABEL_130;
			//           while ( _InterlockedCompareExchange((volatile signed __int32 *)&v99._1.cctor_finished_or_no_cctor, 1, 1) != 1
			//                && !_InterlockedCompareExchange(
			//                      (volatile signed __int32 *)&v99._1.initializationExceptionGCHandle,
			//                      0,
			//                      0) )
			//           {
			//             v116 = 1;
			//             v117 = qword_18D8F6E48;
			//             while ( 1 )
			//             {
			//               if ( !v117 )
			//                 QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18D8F6E48);
			//               QueryPerformanceCounter((LARGE_INTEGER *)&id);
			//               v118 = 1000LL * *(_QWORD *)&id.x / qword_18D8F6E48;
			//               if ( (unsigned int)((__int64 (__fastcall *)(_QWORD, _QWORD))SleepEx)(v116, 0LL) != 192 )
			//                 break;
			//               if ( !qword_18D8F6E48 )
			//                 QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18D8F6E48);
			//               QueryPerformanceCounter((LARGE_INTEGER *)&center);
			//               v117 = qword_18D8F6E48;
			//               v119 = 1000LL * *(_QWORD *)&center.x / qword_18D8F6E48 - v118;
			//               if ( v119 >= v116 )
			//                 break;
			//               v116 -= v119;
			//             }
			//           }
			//         }
			//         else
			//         {
			//           _InterlockedExchange64(
			//             (volatile __int64 *)&v99._1.cctor_thread,
			//             (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
			//           _InterlockedExchange((volatile __int32 *)&v99._1.cctor_started, 1);
			//           sub_180292530(&qword_18CDBFAA0);
			//           *(_QWORD *)&cameraForwardDir.x = 0LL;
			//           if ( (BYTE1(v99.vtable.Equals.methodPtr) & 4) != 0 )
			//           {
			//             v104 = sub_180039210((_DWORD)v99, (unsigned int)".cctor", -1, 2048, 0LL);
			//             if ( v104 )
			//               il2cpp_runtime_invoke_0(v104, 0LL, 0LL, &cameraForwardDir);
			//           }
			//           _InterlockedExchange64((volatile __int64 *)&v99._1.cctor_thread, 0LL);
			//           if ( *(_QWORD *)&cameraForwardDir.x )
			//           {
			//             il2cpp_array_new_0((Il2CppClass *)&v174, (il2cpp_array_size_t)v169);
			//             sub_180007B60(&v174);
			//             v105 = v171 | 2;
			//             v171 |= 2u;
			//             sub_1800179B0(&v174, &v99._0.byval_arg, 0LL, 0LL);
			//             v106 = (const char *)&v174;
			//             if ( v175 > 0xF )
			//               v106 = *(const char **)&v174.x;
			//             sub_180016840(v177, "The type initializer for '%s' threw an exception.", v106);
			//             v171 = v105 & 0xFFFFFFFD;
			//             sub_180006B90(&v174);
			//             v107 = *(_QWORD *)&cameraForwardDir.x;
			//             v108 = v177;
			//             if ( v178 > 0xF )
			//               v108 = (_QWORD *)v177[0];
			//             v109 = il2cpp_exception_from_name_msg_0(qword_18D8E4510, "System", "TypeInitializationException", v108);
			//             v112 = v109;
			//             if ( v107 )
			//             {
			//               *(_QWORD *)(v109 + 40) = v107;
			//               sub_1800054D0(
			//                 (OneofDescriptor *)(v109 + 40),
			//                 v110,
			//                 v111,
			//                 (MessageDescriptor *)v109,
			//                 (String__Array *)P3b,
			//                 (String *)P4b,
			//                 P5b);
			//             }
			//             v113 = sub_1802DC930(&qword_18CDBF7F0, v112, 0LL);
			//             v99._1.initializationExceptionGCHandle = v113;
			//             v114 = ((__int64)v99.vtable.Equals.methodPtr & 2) != 0 && !v113;
			//             LOBYTE(v99.vtable.Equals.methodPtr) = v114 | (__int64)v99.vtable.Equals.methodPtr & 0xFE;
			//             sub_180006B90(v177);
			//           }
			//           else
			//           {
			//             _InterlockedExchange((volatile __int32 *)&v99._1.cctor_finished_or_no_cctor, 1);
			//           }
			//         }
			//         if ( v99._1.initializationExceptionGCHandle )
			//         {
			//           v144 = mono_gchandle_get_target_0(v99._1.initializationExceptionGCHandle);
			//           sub_18000F750(v144, 0LL);
			//         }
			//       }
			// LABEL_130:
			//       v100 = cmd;
			//       UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P2, cmd, 0LL);
			//       v102 = TypeInfo::UnityEngine::Rendering::CommandBufferPool;
			//       if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool._1.cctor_finished_or_no_cctor )
			//       {
			//         CurrentThreadId = il2cpp_baselib::Baselib_Thread_GetCurrentThreadId(v101);
			//         if ( CurrentThreadId == qword_18CDBFAE8 )
			//         {
			//           ++dword_18CDBFAF0;
			//         }
			//         else
			//         {
			//           sub_1802924B0(&qword_18CDBFAA0);
			//           qword_18CDBFAE8 = CurrentThreadId;
			//           dword_18CDBFAF0 = 1;
			//         }
			//         if ( _InterlockedCompareExchange((volatile signed __int32 *)&v102._1.cctor_finished_or_no_cctor, 1, 1) == 1 )
			//         {
			//           if ( dword_18CDBFAF0 > 0 )
			//           {
			//             if ( dword_18CDBFAF0 == 1 )
			//             {
			//               qword_18CDBFAE8 = 0LL;
			//               dword_18CDBFAF0 = 0;
			//               sub_18010B970(&qword_18CDBFAA0, 1LL);
			//             }
			//             else
			//             {
			//               --dword_18CDBFAF0;
			//             }
			//           }
			//         }
			//         else
			//         {
			//           if ( _InterlockedCompareExchange((volatile signed __int32 *)&v102._1.cctor_started, 1, 1) == 1 )
			//           {
			//             if ( dword_18CDBFAF0 > 0 )
			//             {
			//               if ( dword_18CDBFAF0 == 1 )
			//               {
			//                 qword_18CDBFAE8 = 0LL;
			//                 dword_18CDBFAF0 = 0;
			//                 sub_18010B970(&qword_18CDBFAA0, 1LL);
			//               }
			//               else
			//               {
			//                 --dword_18CDBFAF0;
			//               }
			//             }
			//             v120 = ((__int64 (*)(void))GetCurrentThreadId)();
			//             if ( v120 == _InterlockedCompareExchange64((volatile signed __int64 *)&v102._1.cctor_thread, v120, v120) )
			//               goto LABEL_168;
			//             while ( _InterlockedCompareExchange((volatile signed __int32 *)&v102._1.cctor_finished_or_no_cctor, 1, 1) != 1
			//                  && !_InterlockedCompareExchange(
			//                        (volatile signed __int32 *)&v102._1.initializationExceptionGCHandle,
			//                        0,
			//                        0) )
			//             {
			//               v121 = 1;
			//               v122 = qword_18D8F6E48;
			//               while ( 1 )
			//               {
			//                 if ( !v122 )
			//                   QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18D8F6E48);
			//                 QueryPerformanceCounter((LARGE_INTEGER *)&center);
			//                 v123 = 1000LL * *(_QWORD *)&center.x / qword_18D8F6E48;
			//                 if ( (unsigned int)((__int64 (__fastcall *)(_QWORD, _QWORD))SleepEx)(v121, 0LL) != 192 )
			//                   break;
			//                 if ( !qword_18D8F6E48 )
			//                   QueryPerformanceFrequency((LARGE_INTEGER *)&qword_18D8F6E48);
			//                 QueryPerformanceCounter((LARGE_INTEGER *)&id);
			//                 v122 = qword_18D8F6E48;
			//                 v124 = 1000LL * *(_QWORD *)&id.x / qword_18D8F6E48 - v123;
			//                 if ( v124 >= v121 )
			//                   break;
			//                 v121 -= v124;
			//               }
			//             }
			//             v100 = cmd;
			//           }
			//           else
			//           {
			//             _InterlockedExchange64(
			//               (volatile __int64 *)&v102._1.cctor_thread,
			//               (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
			//             _InterlockedExchange((volatile __int32 *)&v102._1.cctor_started, 1);
			//             if ( dword_18CDBFAF0 > 0 )
			//             {
			//               if ( dword_18CDBFAF0 == 1 )
			//               {
			//                 qword_18CDBFAE8 = 0LL;
			//                 dword_18CDBFAF0 = 0;
			//                 sub_18010B970(&qword_18CDBFAA0, 1LL);
			//               }
			//               else
			//               {
			//                 --dword_18CDBFAF0;
			//               }
			//             }
			//             cmd = 0LL;
			//             if ( (BYTE1(v102.vtable.Equals.methodPtr) & 4) != 0 )
			//             {
			//               parent = v102;
			//               if ( ((__int64)v102.vtable.Equals.methodPtr & 2) == 0 )
			//               {
			//                 *(_QWORD *)&cameraForwardDir.x = &qword_18CDB0B30;
			//                 sub_1802924D0(&qword_18CDB0B30);
			//                 sub_180060090(v102, &cameraForwardDir);
			//                 sub_180292530(*(_QWORD *)&cameraForwardDir.x);
			//               }
			//               do
			//               {
			//                 *(_QWORD *)&cameraForwardDir.x = 0LL;
			//                 for ( i = mono_class_get_methods_0(parent, &cameraForwardDir);
			//                       i;
			//                       i = mono_class_get_methods_0(parent, &cameraForwardDir) )
			//                 {
			//                   if ( **(_BYTE **)(i + 24) == 46 && (*(_WORD *)(i + 76) & 0x800) != 0 )
			//                   {
			//                     v128 = 0LL;
			//                     v125 = *(il2cpp_array_size_t *)(i + 24);
			//                     while ( 1 )
			//                     {
			//                       v129 = aCctor[v128++];
			//                       if ( v129 != *(_BYTE *)(v125.value + v128 - 1) )
			//                         break;
			//                       if ( v128 == 7 )
			//                         goto LABEL_203;
			//                     }
			//                   }
			//                 }
			//                 parent = (struct CommandBufferPool__Class *)parent._0.parent;
			//               }
			//               while ( parent );
			//               i = 0LL;
			// LABEL_203:
			//               if ( i )
			//                 il2cpp_runtime_invoke_0(i, 0LL, 0LL, &cmd);
			//             }
			//             _InterlockedExchange64((volatile __int64 *)&v102._1.cctor_thread, 0LL);
			//             if ( cmd )
			//             {
			//               il2cpp_array_new_0((Il2CppClass *)&v174, v125);
			//               sub_180007B60(&v174);
			//               v171 |= 4u;
			//               sub_1800179B0(&v174, &v102._0.byval_arg, 0LL, 0LL);
			//               v130 = (const char *)&v174;
			//               if ( v175 > 0xF )
			//                 v130 = *(const char **)&v174.x;
			//               sub_180016840(v177, "The type initializer for '%s' threw an exception.", v130);
			//               sub_180006B90(&v174);
			//               v131 = cmd;
			//               v132 = v177;
			//               if ( v178 > 0xF )
			//                 v132 = (_QWORD *)v177[0];
			//               v133 = il2cpp_exception_from_name_msg_0(qword_18D8E4510, "System", "TypeInitializationException", v132);
			//               v136 = v133;
			//               if ( v131 )
			//               {
			//                 *(_QWORD *)(v133 + 40) = v131;
			//                 sub_1800054D0(
			//                   (OneofDescriptor *)(v133 + 40),
			//                   v134,
			//                   v135,
			//                   (MessageDescriptor *)v133,
			//                   (String__Array *)P3b,
			//                   (String *)P4b,
			//                   P5b);
			//               }
			//               v137 = sub_1802DC930(&qword_18CDBF7F0, v136, 0LL);
			//               v102._1.initializationExceptionGCHandle = v137;
			//               v138 = ((__int64)v102.vtable.Equals.methodPtr & 2) != 0 && !v137;
			//               LOBYTE(v102.vtable.Equals.methodPtr) = v138 | (__int64)v102.vtable.Equals.methodPtr & 0xFE;
			//               sub_180006B90(v177);
			//             }
			//             else
			//             {
			//               _InterlockedExchange((volatile __int32 *)&v102._1.cctor_finished_or_no_cctor, 1);
			//             }
			//           }
			//           if ( v102._1.initializationExceptionGCHandle )
			//           {
			//             v139 = mono_gchandle_get_target_0(v102._1.initializationExceptionGCHandle);
			//             sub_18000F750(v139, 0LL);
			//           }
			//         }
			//       }
			// LABEL_168:
			//       UnityEngine::Rendering::CommandBufferPool::Release(v100, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public void ReloadIndexFileV2(string rootPath)
		{
			// // Void ReloadIndexFileV2(String)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ReloadIndexFileV2(
			//         HGIrradianceVolumeManagerV2 *this,
			//         String *rootPath,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1576, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1576, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)rootPath,
			//       0LL);
			//   }
			//   else if ( this.fields.m_defaultIV )
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetMap(this.fields.m_defaultIV, rootPath, 0LL);
			//   }
			// }
			// 
		}

		public void GetStateNameListV2(List<string> stateNameList)
		{
			// // Void GetStateNameListV2(List`1[System.String])
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::GetStateNameListV2(
			//         HGIrradianceVolumeManagerV2 *this,
			//         List_1_System_String_ *stateNameList,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   String__Array *ActiveSceneStateNames; // rdi
			//   Object__Array *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCE0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//     byte_18D8EDCE0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1577, 0LL) )
			//   {
			//     ActiveSceneStateNames = UnityEngine::HyperGryph::HGIrradianceVolumeV2::GetActiveSceneStateNames(0LL);
			//     if ( stateNameList )
			//     {
			//       v8 = System::Collections::Generic::List<System::Object>::ToArray(
			//              (List_1_System_Object_ *)stateNameList,
			//              MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//       UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetSceneStateNames((String__Array *)v8, ActiveSceneStateNames, 0LL);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1577, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)stateNameList,
			//     0LL);
			// }
			// 
		}

		[IDTag(0)]
		public void UpdateSceneStateMaskV2(uint stateMask)
		{
			// // Void UpdateSceneStateMaskV2(UInt32)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::UpdateSceneStateMaskV2(
			//         HGIrradianceVolumeManagerV2 *this,
			//         uint32_t stateMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1578, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1578, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, stateMask, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetActiveSceneStateMask(stateMask, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public void UpdateSceneStateMaskV2(List<string> curSceneStateMask)
		{
			// // Void UpdateSceneStateMaskV2(List`1[System.String])
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::UpdateSceneStateMaskV2(
			//         HGIrradianceVolumeManagerV2 *this,
			//         List_1_System_String_ *curSceneStateMask,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E1F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//     byte_18D919E1F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1579, 0LL) )
			//   {
			//     if ( curSceneStateMask )
			//     {
			//       v7 = System::Collections::Generic::List<System::Object>::ToArray(
			//              (List_1_System_Object_ *)curSceneStateMask,
			//              MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//       UnityEngine::HyperGryph::HGIrradianceVolumeV2::SetActiveSceneStateNames((String__Array *)v7, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1579, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)curSceneStateMask,
			//     0LL);
			// }
			// 
		}

		public void StreamingInCabin(long slotId, uint roomTypeId)
		{
			// // Void StreamingInCabin(Int64, UInt32)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingInCabin(
			//         HGIrradianceVolumeManagerV2 *this,
			//         int64_t slotId,
			//         uint32_t roomTypeId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1580, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1580, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_18(
			//       (ILFixDynamicMethodWrapper_17 *)Patch,
			//       (Object *)this,
			//       slotId,
			//       roomTypeId,
			//       0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolumeV2::StreamingInCabin(this.fields.m_defaultIV, slotId, roomTypeId, 0LL);
			//   }
			// }
			// 
		}

		public void StreamingOutCabin(long slotId)
		{
			// // Void StreamingOutCabin(Int64)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingOutCabin(
			//         HGIrradianceVolumeManagerV2 *this,
			//         int64_t slotId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1581, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1581, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69((ILFixDynamicMethodWrapper_14 *)Patch, (Object *)this, slotId, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolumeV2::StreamingOutCabin(this.fields.m_defaultIV, slotId, 0LL);
			//   }
			// }
			// 
		}

		public void StreamingInCabinV3(string slotId, uint roomTypeId)
		{
			// // Void StreamingInCabinV3(String, UInt32)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingInCabinV3(
			//         HGIrradianceVolumeManagerV2 *this,
			//         String *slotId,
			//         uint32_t roomTypeId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1582, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1582, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(
			//       (ILFixDynamicMethodWrapper_18 *)Patch,
			//       (Object *)this,
			//       (Object *)slotId,
			//       (LogType__Enum)roomTypeId,
			//       0LL);
			//   }
			// }
			// 
		}

		public void StreamingOutCabinV3(string slotId)
		{
			// // Void StreamingOutCabinV3(String)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::StreamingOutCabinV3(
			//         HGIrradianceVolumeManagerV2 *this,
			//         String *slotId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1583, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1583, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)slotId,
			//       0LL);
			//   }
			// }
			// 
		}

		public void StreamingInNewMapV2(string indexRootPath)
		{
		}

		public void ReleaseV2()
		{
			// // Void ReleaseV2()
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ReleaseV2(
			//         HGIrradianceVolumeManagerV2 *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   FileDescriptor *v4; // r8
			//   MessageDescriptor *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   String__Array *v9; // [rsp+50h] [rbp+28h]
			//   String *v10; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v11; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D919E20 )
			//   {
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D919E20 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1585, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1585, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_defaultIV )
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolumeV2::Destroy(this.fields.m_defaultIV, 0LL);
			//     this.fields.m_defaultIV = 0LL;
			//     this.fields.m_lastDataPathV2 = (String *)"";
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_lastDataPathV2, v3, v4, v5, v9, v10, v11);
			//   }
			// }
			// 
		}

		public void ToggleDebugUpdateClipmap(bool debugClipmap)
		{
			// // Void ToggleDebugUpdateClipmap(Boolean)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ToggleDebugUpdateClipmap(
			//         HGIrradianceVolumeManagerV2 *this,
			//         bool debugClipmap,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1586, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1586, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       debugClipmap,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_debugClipmap = debugClipmap;
			//   }
			// }
			// 
		}

		public void ToggleDebugUpdateClipmapLod0(bool debugClipmapLod0)
		{
			// // Void ToggleDebugUpdateClipmapLod0(Boolean)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManagerV2::ToggleDebugUpdateClipmapLod0(
			//         HGIrradianceVolumeManagerV2 *this,
			//         bool debugClipmapLod0,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1587, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1587, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       debugClipmapLod0,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_debugClipmapLod0 = debugClipmapLod0;
			//   }
			// }
			// 
		}

		private const string GACHA_IV_PATH = "IrradianceVolume/gacha/index.bytes";

		private long m_defaultIV;

		private string m_lastDataPathV2;

		private string m_irradianceDataPathV2;

		private string m_exportpathV2;

		private long m_gachaIV;

		private bool m_startGachaIV;

		private bool m_endGachaIV;

		private string m_gachaDataPathV2;

		private bool m_debugClipmap;

		private bool m_debugClipmapLod0;

		private Vector3 m_debugPos;

		private int m_debugFrameCount;
	}
}
