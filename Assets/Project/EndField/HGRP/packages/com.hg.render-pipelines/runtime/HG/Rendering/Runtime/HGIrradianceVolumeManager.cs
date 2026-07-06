using System;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGIrradianceVolumeManager
	{
		public HGIrradianceVolumeManager()
		{
		}

		public long GetActiveIV()
		{
			// // Int64 GetActiveIV()
			// int64_t HG::Rendering::Runtime::HGIrradianceVolumeManager::GetActiveIV(
			//         HGIrradianceVolumeManager *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
			//   if ( wrapperArray.max_length.size > 986 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x3DA )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[21]._0.namespaze )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(986, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.fields.m_gachaIV )
			//     return this.fields.m_gachaIV;
			//   else
			//     return this.fields.m_defaultIV;
			// }
			// 
			return 0L;
		}

		public void PipelineUpdateV2(out HGIrradianceVolumePipelineUpdateResult result, ScriptableRenderContext renderContext, Camera primaryCamera, Transform currentPlayerCenter, ComputeShader ivBakeV2CS, ComputeShader ivIndirectV2CS)
		{
			// // Void PipelineUpdateV2(HGIrradianceVolumePipelineUpdateResult ByRef, ScriptableRenderContext, Camera, Transform, ComputeShader, ComputeShader)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::PipelineUpdateV2(
			//         HGIrradianceVolumeManager *this,
			//         HGIrradianceVolumePipelineUpdateResult *result,
			//         ScriptableRenderContext renderContext,
			//         Camera *primaryCamera,
			//         Transform *currentPlayerCenter,
			//         ComputeShader *ivBakeV2CS,
			//         ComputeShader *ivIndirectV2CS,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   void *irradianceVolumeV3; // rcx
			//   String *m_irradianceDataPathV3; // rdx
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   int v25; // r12d
			//   char v26; // di
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   OneofDescriptorProto *v29; // rdx
			//   FileDescriptor *v30; // r8
			//   MessageDescriptor *v31; // r9
			//   String *m_lastDataPathV2; // rcx
			//   String *m_irradianceDataPathV2; // rdx
			//   String *m_lastDataPathV3; // rcx
			//   Transform *v35; // rdi
			//   Transform *v36; // rsi
			//   int64_t m_gachaIV; // rsi
			//   void (__fastcall *v38)(Transform *, __int64 *); // rax
			//   void (__fastcall *v39)(int64_t, __int64 *); // rax
			//   CommandBuffer *v40; // rbx
			//   void (__fastcall *v41)(CommandBuffer *, const char *); // rax
			//   ComputeShader *v42; // rdi
			//   void *m_Ptr; // r15
			//   char *m_CachedPtr; // rdi
			//   int v45; // r14d
			//   ComputeShader *v46; // rdi
			//   char *v47; // rdi
			//   void (__fastcall *v48)(HGIrradianceVolumePipelineUpdateResult *, int64_t, void *, CommandBuffer *, int, int); // rax
			//   __int64 v49; // rdx
			//   void (__fastcall *v50)(ScriptableRenderContext *, CommandBuffer *); // rax
			//   __int64 v51; // rdx
			//   Camera *main; // rsi
			//   Camera *v53; // rdi
			//   __int64 (__fastcall *v54)(Camera *); // rax
			//   Transform *transform; // rax
			//   AttributeCollection *instance; // rax
			//   __m128i v57; // xmm0
			//   int v58; // edi
			//   int v59; // edx
			//   int v60; // r10d
			//   int v61; // r11d
			//   int v62; // r8d
			//   int v63; // r9d
			//   __int64 (__fastcall *v64)(_DWORD *); // rax
			//   struct HGGraphicsFeatureManager__Class *v65; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v67; // rax
			//   __int64 v68; // rax
			//   __int64 v69; // rax
			//   __int64 v70; // rax
			//   __int64 v71; // rax
			//   __int64 v72; // rax
			//   ObjectDisposedException *v73; // rbx
			//   String *v74; // rax
			//   __int64 v75; // rax
			//   Object *P3; // [rsp+20h] [rbp-E0h]
			//   Object *P3c; // [rsp+20h] [rbp-E0h]
			//   Object *P3d; // [rsp+20h] [rbp-E0h]
			//   Object *P3a; // [rsp+20h] [rbp-E0h]
			//   Object *P3e; // [rsp+20h] [rbp-E0h]
			//   Object *P3b; // [rsp+20h] [rbp-E0h]
			//   Object *P4; // [rsp+28h] [rbp-D8h]
			//   Object *P4c; // [rsp+28h] [rbp-D8h]
			//   Object *P4d; // [rsp+28h] [rbp-D8h]
			//   Object *P4a; // [rsp+28h] [rbp-D8h]
			//   Object *P4e; // [rsp+28h] [rbp-D8h]
			//   Object *P4b; // [rsp+28h] [rbp-D8h]
			//   MethodInfo *P5; // [rsp+30h] [rbp-D0h]
			//   MethodInfo *P5c; // [rsp+30h] [rbp-D0h]
			//   MethodInfo *P5d; // [rsp+30h] [rbp-D0h]
			//   MethodInfo *P5a; // [rsp+30h] [rbp-D0h]
			//   MethodInfo *P5e; // [rsp+30h] [rbp-D0h]
			//   MethodInfo *P5b; // [rsp+30h] [rbp-D0h]
			//   __int64 v94; // [rsp+50h] [rbp-B0h] BYREF
			//   int v95; // [rsp+58h] [rbp-A8h]
			//   _DWORD v96[5]; // [rsp+60h] [rbp-A0h] BYREF
			//   __int64 v97; // [rsp+74h] [rbp-8Ch]
			//   int v98; // [rsp+7Ch] [rbp-84h]
			//   __m128i si128; // [rsp+80h] [rbp-80h]
			//   int v100; // [rsp+90h] [rbp-70h]
			//   int v101; // [rsp+94h] [rbp-6Ch]
			//   int v102; // [rsp+98h] [rbp-68h]
			//   int v103; // [rsp+9Ch] [rbp-64h]
			//   int v104; // [rsp+A0h] [rbp-60h]
			//   __int64 v105; // [rsp+A4h] [rbp-5Ch]
			//   int v106; // [rsp+ACh] [rbp-54h]
			//   int v107; // [rsp+B0h] [rbp-50h]
			//   int v108; // [rsp+B4h] [rbp-4Ch]
			//   int v109; // [rsp+B8h] [rbp-48h]
			//   int v110; // [rsp+BCh] [rbp-44h]
			//   __m128i v111; // [rsp+C0h] [rbp-40h]
			//   int v112; // [rsp+D0h] [rbp-30h]
			//   int v113; // [rsp+D4h] [rbp-2Ch]
			//   int v114; // [rsp+D8h] [rbp-28h]
			//   int v115; // [rsp+DCh] [rbp-24h]
			//   int v116; // [rsp+E0h] [rbp-20h]
			//   int v117; // [rsp+E4h] [rbp-1Ch]
			//   int v118; // [rsp+E8h] [rbp-18h]
			//   int v119; // [rsp+ECh] [rbp-14h]
			//   int v120; // [rsp+F0h] [rbp-10h]
			//   int v121; // [rsp+F4h] [rbp-Ch]
			//   int v122; // [rsp+F8h] [rbp-8h]
			//   int v123; // [rsp+FCh] [rbp-4h]
			//   int v124; // [rsp+100h] [rbp+0h]
			//   int v125; // [rsp+104h] [rbp+4h]
			//   int v126; // [rsp+108h] [rbp+8h]
			//   int v127; // [rsp+10Ch] [rbp+Ch]
			//   int v128; // [rsp+110h] [rbp+10h]
			//   int v129; // [rsp+114h] [rbp+14h]
			//   int v130; // [rsp+118h] [rbp+18h]
			//   int v131; // [rsp+11Ch] [rbp+1Ch]
			//   __int64 v132; // [rsp+120h] [rbp+20h] BYREF
			//   int v133; // [rsp+128h] [rbp+28h]
			//   ScriptableRenderContext P2; // [rsp+170h] [rbp+70h] BYREF
			// 
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   if ( !byte_18D8EDCDB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGIrradianceVolumeQualitySettings);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D8EDCDB = 1;
			//   }
			//   sub_1802F01E0(v96, 0LL, 192LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   irradianceVolumeV3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v11);
			//     irradianceVolumeV3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_irradianceDataPathV3 = (String *)**((_QWORD **)irradianceVolumeV3 + 23);
			//   if ( !m_irradianceDataPathV3 )
			//     goto LABEL_126;
			//   if ( SLODWORD(m_irradianceDataPathV3[1].klass) > 634 )
			//   {
			//     if ( !*((_DWORD *)irradianceVolumeV3 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(irradianceVolumeV3, m_irradianceDataPathV3);
			//       irradianceVolumeV3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     irradianceVolumeV3 = (void *)**((_QWORD **)irradianceVolumeV3 + 23);
			//     if ( !irradianceVolumeV3 )
			//       goto LABEL_126;
			//     if ( *((_DWORD *)irradianceVolumeV3 + 6) <= 0x27Au )
			//       sub_180070270(irradianceVolumeV3, m_irradianceDataPathV3);
			//     if ( *((_QWORD *)irradianceVolumeV3 + 638) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(634, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_236(
			//           Patch,
			//           (Object *)this,
			//           result,
			//           P2,
			//           (Object *)primaryCamera,
			//           (Object *)currentPlayerCenter,
			//           (Object *)ivBakeV2CS,
			//           (Object *)ivIndirectV2CS,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_126;
			//     }
			//   }
			//   result.param0 = 0LL;
			//   result.param1 = 0LL;
			//   result.param2 = 0LL;
			//   result.param3 = 0LL;
			//   result.indirectionTexture = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0((OneofDescriptor *)&result.indirectionTexture, v14, v15, v16, (String__Array *)P3, (String *)P4, P5);
			//   result.physicalTexture0 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0((OneofDescriptor *)&result.physicalTexture0, v17, v18, v19, (String__Array *)P3c, (String *)P4c, P5c);
			//   result.physicalTexture1 = (Texture *)UnityEngine::Texture3D::get_blackTexture3D(0LL);
			//   sub_1800054D0((OneofDescriptor *)&result.physicalTexture1, v20, v21, v22, (String__Array *)P3d, (String *)P4d, P5d);
			//   v25 = 0;
			//   if ( this.fields.m_defaultIV )
			//   {
			//     if ( this.fields.m_gachaIV )
			//     {
			//       if ( this.fields.m_startGachaIV )
			//       {
			//         UnityEngine::HyperGryph::HGIrradianceVolume::SetMap(this.fields.m_gachaIV, this.fields.m_gachaDataPathV2, 0LL);
			//         UnityEngine::HyperGryph::HGIrradianceVolume::SetMapV3(
			//           this.fields.m_gachaIV,
			//           this.fields.m_gachaDataPathV3,
			//           0LL);
			//         this.fields.m_startGachaIV = 0;
			//       }
			//     }
			//     else
			//     {
			//       this.fields.m_irradianceDataPathV2 = (String *)"";
			//       v26 = 0;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_irradianceDataPathV2,
			//         (OneofDescriptorProto *)m_irradianceDataPathV3,
			//         v23,
			//         v24,
			//         (String__Array *)P3a,
			//         (String *)P4a,
			//         P5a);
			//       this.fields.m_irradianceDataPathV3 = (String *)"";
			//       sub_1800054D0(
			//         (OneofDescriptor *)&this.fields.m_irradianceDataPathV3,
			//         v27,
			//         v28,
			//         (MessageDescriptor *)"",
			//         (String__Array *)P3e,
			//         (String *)P4e,
			//         P5e);
			//       if ( this.fields.m_exportpathV2 )
			//       {
			//         this.fields.m_irradianceDataPathV2 = this.fields.m_exportpathV2;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_irradianceDataPathV2,
			//           v29,
			//           v30,
			//           v31,
			//           (String__Array *)P3b,
			//           (String *)P4b,
			//           P5b);
			//       }
			//       if ( this.fields.m_exportpathV3 )
			//       {
			//         this.fields.m_irradianceDataPathV3 = this.fields.m_exportpathV3;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_irradianceDataPathV3,
			//           v29,
			//           v30,
			//           v31,
			//           (String__Array *)P3b,
			//           (String *)P4b,
			//           P5b);
			//       }
			//       m_lastDataPathV2 = this.fields.m_lastDataPathV2;
			//       m_irradianceDataPathV2 = this.fields.m_irradianceDataPathV2;
			//       if ( m_lastDataPathV2 != m_irradianceDataPathV2
			//         && (!m_lastDataPathV2
			//          || !m_irradianceDataPathV2
			//          || m_lastDataPathV2.fields._stringLength != m_irradianceDataPathV2.fields._stringLength
			//          || !System::SpanHelpers::SequenceEqual(
			//                (uint8_t *)&m_lastDataPathV2.fields._firstChar,
			//                (uint8_t *)&m_irradianceDataPathV2.fields._firstChar,
			//                2LL * m_lastDataPathV2.fields._stringLength,
			//                0LL)) )
			//       {
			//         this.fields.m_lastDataPathV2 = this.fields.m_irradianceDataPathV2;
			//         v26 = 1;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_lastDataPathV2,
			//           (OneofDescriptorProto *)m_irradianceDataPathV2,
			//           v30,
			//           v31,
			//           (String__Array *)P3b,
			//           (String *)P4b,
			//           P5b);
			//       }
			//       m_lastDataPathV3 = this.fields.m_lastDataPathV3;
			//       m_irradianceDataPathV3 = this.fields.m_irradianceDataPathV3;
			//       if ( m_lastDataPathV3 == m_irradianceDataPathV3
			//         || m_lastDataPathV3
			//         && m_irradianceDataPathV3
			//         && m_lastDataPathV3.fields._stringLength == m_irradianceDataPathV3.fields._stringLength
			//         && System::SpanHelpers::SequenceEqual(
			//              (uint8_t *)&m_lastDataPathV3.fields._firstChar,
			//              (uint8_t *)&m_irradianceDataPathV3.fields._firstChar,
			//              2LL * m_lastDataPathV3.fields._stringLength,
			//              0LL) )
			//       {
			//         this.fields.m_endGachaIV = 0;
			//         if ( !v26 )
			//           goto LABEL_29;
			//       }
			//       else
			//       {
			//         this.fields.m_lastDataPathV3 = this.fields.m_irradianceDataPathV3;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_lastDataPathV3,
			//           (OneofDescriptorProto *)m_irradianceDataPathV3,
			//           v30,
			//           v31,
			//           (String__Array *)P3b,
			//           (String *)P4b,
			//           P5b);
			//         this.fields.m_endGachaIV = 0;
			//       }
			//       UnityEngine::HyperGryph::HGIrradianceVolume::SetMap(
			//         this.fields.m_defaultIV,
			//         this.fields.m_irradianceDataPathV2,
			//         0LL);
			//       UnityEngine::HyperGryph::HGIrradianceVolume::SetMapV3(
			//         this.fields.m_defaultIV,
			//         this.fields.m_irradianceDataPathV3,
			//         0LL);
			//     }
			//   }
			//   else
			//   {
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3573F0);
			//     v96[0] = 0;
			//     v96[1] = 128;
			//     v96[2] = 64;
			//     v96[3] = 64;
			//     v96[4] = 16;
			//     v97 = 0x400000LL;
			//     v98 = 1;
			//     v103 = 0x200000;
			//     v104 = 2097088;
			//     v105 = 64LL;
			//     v100 = 64;
			//     v101 = 2097216;
			//     v102 = 0x400000;
			//     v108 = 0x8000;
			//     v109 = 30720;
			//     v110 = 2048;
			//     v106 = 0x8000;
			//     v107 = 63488;
			//     instance = (AttributeCollection *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//     if ( !instance )
			//       goto LABEL_126;
			//     if ( System::ComponentModel::AttributeCollection::get_Count(instance, 0LL) == 4 )
			//     {
			//       v57 = _mm_load_si128((const __m128i *)&xmmword_18C370EE0);
			//       v112 = 1024;
			//       v113 = 1024;
			//     }
			//     else
			//     {
			//       v57 = _mm_load_si128((const __m128i *)&xmmword_18A357400);
			//       v112 = 4;
			//       v113 = 8;
			//     }
			//     v111 = v57;
			//     v114 = 0x100000;
			//     v115 = 8;
			//     v116 = 0x80000;
			//     v117 = 60;
			//     v118 = 128;
			//     v119 = 64;
			//     v120 = 128;
			//     if ( v96[0] == 1 )
			//     {
			//       v58 = 3932160;
			//       v59 = 6291456;
			//       v60 = 6553600;
			//       v61 = 12582912;
			//       v62 = 10485760;
			//       v63 = 23068672;
			//     }
			//     else
			//     {
			//       v58 = 7864320;
			//       v59 = 12582912;
			//       v60 = 13107200;
			//       v61 = 25165824;
			//       v62 = 20971520;
			//       v63 = 46137344;
			//     }
			//     if ( TypeInfo::HG::Rendering::Runtime::HGIrradianceVolumeQualitySettings.static_fields.enableIvLowMemory )
			//     {
			//       v131 = 1;
			//       v121 = v60;
			//       v122 = v61;
			//       v123 = v58;
			//     }
			//     else
			//     {
			//       v131 = 0;
			//       v121 = v62;
			//       v122 = v63;
			//       v123 = v59;
			//     }
			//     v64 = (__int64 (__fastcall *)(_DWORD *))qword_18D8F5AE8;
			//     v124 = 1095761920;
			//     v125 = 1112539136;
			//     v126 = 1125122048;
			//     v127 = 8;
			//     v128 = 96;
			//     v129 = 48;
			//     v130 = 96;
			//     if ( !qword_18D8F5AE8 )
			//     {
			//       v64 = (__int64 (__fastcall *)(_DWORD *))sub_180017470(
			//                                                 "UnityEngine.HyperGryph.HGIrradianceVolume::Create(UnityEngine.HyperGryph"
			//                                                 ".HGIrradianceVolumeConfig&)");
			//       qword_18D8F5AE8 = (__int64)v64;
			//     }
			//     this.fields.m_defaultIV = v64(v96);
			//     v65 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, m_irradianceDataPathV3);
			//       v65 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//     }
			//     irradianceVolumeV3 = v65.static_fields.irradianceVolumeV3;
			//     if ( !irradianceVolumeV3 )
			//       goto LABEL_126;
			//     UnityEngine::HyperGryph::HGIrradianceVolume::SetEnableV3(*((_BYTE *)irradianceVolumeV3 + 16), 0LL);
			//   }
			// LABEL_29:
			//   v35 = 0LL;
			//   if ( !this.fields.m_gachaIV )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV3);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV3);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     v36 = currentPlayerCenter;
			//     if ( currentPlayerCenter )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV3);
			//       if ( v36.fields._._.m_CachedPtr )
			//       {
			//         v35 = v36;
			//         goto LABEL_43;
			//       }
			//     }
			//   }
			//   main = UnityEngine::Camera::get_main(0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( main )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//     if ( main.fields._._._.m_CachedPtr )
			//     {
			//       v53 = UnityEngine::Camera::get_main(0LL);
			//       if ( !v53 )
			//         goto LABEL_126;
			//       v54 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v54 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Component::get_transform()");
			//         qword_18D8F4D40 = (__int64)v54;
			//       }
			//       transform = (Transform *)v54(v53);
			// LABEL_120:
			//       v35 = transform;
			//       goto LABEL_43;
			//     }
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v51);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)primaryCamera, 0LL, 0LL) )
			//   {
			//     if ( !primaryCamera )
			//       goto LABEL_126;
			//     transform = UnityEngine::Component::get_transform((Component *)primaryCamera, 0LL);
			//     goto LABEL_120;
			//   }
			// LABEL_43:
			//   if ( this.fields.m_gachaIV )
			//   {
			//     m_gachaIV = this.fields.m_gachaIV;
			//   }
			//   else
			//   {
			//     m_gachaIV = this.fields.m_defaultIV;
			//     if ( !m_gachaIV )
			//       return;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV3);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV3);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( v35 )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_irradianceDataPathV3);
			//     if ( v35.fields._._.m_CachedPtr )
			//     {
			//       v94 = 0LL;
			//       v95 = 0;
			//       v38 = (void (__fastcall *)(Transform *, __int64 *))qword_18D8F52E0;
			//       if ( !qword_18D8F52E0 )
			//       {
			//         v38 = (void (__fastcall *)(Transform *, __int64 *))il2cpp_resolve_icall_0(
			//                                                              "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         if ( !v38 )
			//         {
			//           v67 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           sub_18000F750(v67, 0LL);
			//         }
			//         qword_18D8F52E0 = (__int64)v38;
			//       }
			//       v38(v35, &v94);
			//       v133 = v95;
			//       v39 = (void (__fastcall *)(int64_t, __int64 *))qword_18D8F5B28;
			//       v132 = v94;
			//       if ( !qword_18D8F5B28 )
			//       {
			//         v39 = (void (__fastcall *)(int64_t, __int64 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.HyperGryph.HGIrradianceVolume::SetStreamingCenter_I"
			//                                                          "njected(System.Int64,UnityEngine.Vector3&)");
			//         if ( !v39 )
			//         {
			//           v68 = sub_1802DBBE8(
			//                   "UnityEngine.HyperGryph.HGIrradianceVolume::SetStreamingCenter_Injected(System.Int64,UnityEngine.Vector3&)");
			//           sub_18000F750(v68, 0LL);
			//         }
			//         qword_18D8F5B28 = (__int64)v39;
			//       }
			//       v39(m_gachaIV, &v132);
			//     }
			//   }
			//   if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CommandBufferPool, m_irradianceDataPathV3);
			//   if ( !byte_18D8F3605 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ObjectPool<UnityEngine::Rendering::CommandBuffer>::Get);
			//     byte_18D8F3605 = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Rendering::CommandBufferPool._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CommandBufferPool, m_irradianceDataPathV3);
			//   irradianceVolumeV3 = TypeInfo::UnityEngine::Rendering::CommandBufferPool.static_fields.s_BufferPool;
			//   if ( !irradianceVolumeV3 )
			//     goto LABEL_126;
			//   v40 = (CommandBuffer *)UnityEngine::Rendering::ObjectPool<System::Object>::Get(
			//                            (ObjectPool_1_System_Object__2 *)irradianceVolumeV3,
			//                            MethodInfo::UnityEngine::Rendering::ObjectPool<UnityEngine::Rendering::CommandBuffer>::Get);
			//   if ( !v40 )
			//     goto LABEL_126;
			//   v41 = (void (__fastcall *)(CommandBuffer *, const char *))qword_18D8F55D0;
			//   if ( !qword_18D8F55D0 )
			//   {
			//     v41 = (void (__fastcall *)(CommandBuffer *, const char *))il2cpp_resolve_icall_0(
			//                                                                 "UnityEngine.Rendering.CommandBuffer::set_name(System.String)");
			//     if ( !v41 )
			//     {
			//       v69 = sub_1802DBBE8("UnityEngine.Rendering.CommandBuffer::set_name(System.String)");
			//       sub_18000F750(v69, 0LL);
			//     }
			//     qword_18D8F55D0 = (__int64)v41;
			//   }
			//   v41(v40, "");
			//   irradianceVolumeV3 = TypeInfo::UnityEngine::Rendering::ScriptableRenderContext;
			//   if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, m_irradianceDataPathV3);
			//   v42 = ivBakeV2CS;
			//   m_Ptr = P2.m_Ptr;
			//   if ( !ivBakeV2CS )
			//     goto LABEL_126;
			//   if ( !byte_18D8F4EAC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAC = 1;
			//   }
			//   m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//   if ( v42.fields._.m_CachedPtr )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, TypeInfo::UnityEngine::Object);
			//       m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     }
			//     if ( **(_DWORD **)&m_irradianceDataPathV3[7].fields == -1 )
			//     {
			//       if ( !LODWORD(m_irradianceDataPathV3[9].monitor) )
			//         il2cpp_runtime_class_init_0(m_irradianceDataPathV3, m_irradianceDataPathV3);
			//       TypeInfo::UnityEngine::Object.static_fields.OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
			//       m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     }
			//     m_CachedPtr = (char *)v42.fields._.m_CachedPtr;
			//     if ( !LODWORD(m_irradianceDataPathV3[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(m_irradianceDataPathV3, m_irradianceDataPathV3);
			//       m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     }
			//     irradianceVolumeV3 = (void *)**(int **)&m_irradianceDataPathV3[7].fields;
			//     v45 = *(_DWORD *)&m_CachedPtr[(_QWORD)irradianceVolumeV3];
			//   }
			//   else
			//   {
			//     v45 = 0;
			//   }
			//   v46 = ivIndirectV2CS;
			//   if ( !ivIndirectV2CS )
			// LABEL_126:
			//     sub_180B536AC(irradianceVolumeV3, m_irradianceDataPathV3);
			//   if ( !byte_18D8F4EAC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     byte_18D8F4EAC = 1;
			//   }
			//   if ( v46.fields._.m_CachedPtr )
			//   {
			//     if ( !LODWORD(m_irradianceDataPathV3[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(m_irradianceDataPathV3, m_irradianceDataPathV3);
			//       m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     }
			//     if ( **(_DWORD **)&m_irradianceDataPathV3[7].fields == -1 )
			//     {
			//       if ( !LODWORD(m_irradianceDataPathV3[9].monitor) )
			//         il2cpp_runtime_class_init_0(m_irradianceDataPathV3, m_irradianceDataPathV3);
			//       TypeInfo::UnityEngine::Object.static_fields.OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
			//       m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     }
			//     v47 = (char *)v46.fields._.m_CachedPtr;
			//     if ( !LODWORD(m_irradianceDataPathV3[9].monitor) )
			//     {
			//       il2cpp_runtime_class_init_0(m_irradianceDataPathV3, m_irradianceDataPathV3);
			//       m_irradianceDataPathV3 = (String *)TypeInfo::UnityEngine::Object;
			//     }
			//     v25 = *(_DWORD *)&v47[**(int **)&m_irradianceDataPathV3[7].fields];
			//   }
			//   v48 = (void (__fastcall *)(HGIrradianceVolumePipelineUpdateResult *, int64_t, void *, CommandBuffer *, int, int))qword_18D8F5B20;
			//   if ( !qword_18D8F5B20 )
			//   {
			//     v48 = (void (__fastcall *)(HGIrradianceVolumePipelineUpdateResult *, int64_t, void *, CommandBuffer *, int, int))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGIrradianceVolume::PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelineUpdateResult&,System.Int64,System.IntPtr,UnityEngine.Rendering.CommandBuffer,System.Int32,System.Int32)");
			//     if ( !v48 )
			//     {
			//       v70 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGIrradianceVolume::PipelineUpdate(UnityEngine.HyperGryph.HGIrradianceVolumePipelin"
			//               "eUpdateResult&,System.Int64,System.IntPtr,UnityEngine.Rendering.CommandBuffer,System.Int32,System.Int32)");
			//       sub_18000F750(v70, 0LL);
			//     }
			//     qword_18D8F5B20 = (__int64)v48;
			//   }
			//   v48(result, m_gachaIV, m_Ptr, v40, v45, v25);
			//   if ( !byte_18D8F560F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D8F560F = 1;
			//   }
			//   if ( !v40.fields.m_Ptr )
			//   {
			//     v72 = sub_18003C530(&TypeInfo::System::ObjectDisposedException);
			//     v73 = (ObjectDisposedException *)sub_180004920(v72);
			//     if ( v73 )
			//     {
			//       v74 = (String *)sub_18003C530(&off_18D5D8FB0);
			//       System::ObjectDisposedException::ObjectDisposedException(v73, v74, 0LL);
			//       v75 = sub_18003C530(&MethodInfo::UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer);
			//       sub_18000F7C0(v73, v75);
			//     }
			//     goto LABEL_126;
			//   }
			//   if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, v49);
			//   if ( !byte_18D8F560B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D8F560B = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, v49);
			//   v50 = (void (__fastcall *)(ScriptableRenderContext *, CommandBuffer *))qword_18D8F5638;
			//   if ( !qword_18D8F5638 )
			//   {
			//     v50 = (void (__fastcall *)(ScriptableRenderContext *, CommandBuffer *))il2cpp_resolve_icall_0(
			//                                                                              "UnityEngine.Rendering.ScriptableRenderConte"
			//                                                                              "xt::ExecuteCommandBuffer_Internal_Injected("
			//                                                                              "UnityEngine.Rendering.ScriptableRenderConte"
			//                                                                              "xt&,UnityEngine.Rendering.CommandBuffer)");
			//     if ( !v50 )
			//     {
			//       v71 = sub_1802DBBE8(
			//               "UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBuffer_Internal_Injected(UnityEngine.Renderin"
			//               "g.ScriptableRenderContext&,UnityEngine.Rendering.CommandBuffer)");
			//       sub_18000F750(v71, 0LL);
			//     }
			//     qword_18D8F5638 = (__int64)v50;
			//   }
			//   v50(&P2, v40);
			//   UnityEngine::Rendering::CommandBufferPool::Release(v40, 0LL);
			// }
			// 
		}

		public void CreateGachaIV(string gachaDataPath)
		{
			// // Void CreateGachaIV(String)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::CreateGachaIV(
			//         HGIrradianceVolumeManager *this,
			//         String *gachaDataPath,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   _BYTE config[112]; // [rsp+28h] [rbp-69h] BYREF
			//   int v15; // [rsp+98h] [rbp+7h]
			//   int v16; // [rsp+9Ch] [rbp+Bh]
			//   int v17; // [rsp+A0h] [rbp+Fh]
			//   int v18; // [rsp+A4h] [rbp+13h]
			//   int v19; // [rsp+A8h] [rbp+17h]
			//   int v20; // [rsp+ACh] [rbp+1Bh]
			//   int v21; // [rsp+B0h] [rbp+1Fh]
			//   int v22; // [rsp+B4h] [rbp+23h]
			//   int v23; // [rsp+B8h] [rbp+27h]
			//   int v24; // [rsp+BCh] [rbp+2Bh]
			//   int v25; // [rsp+C0h] [rbp+2Fh]
			//   int v26; // [rsp+C4h] [rbp+33h]
			//   int v27; // [rsp+C8h] [rbp+37h]
			//   int v28; // [rsp+CCh] [rbp+3Bh]
			//   int v29; // [rsp+D0h] [rbp+3Fh]
			//   int v30; // [rsp+D4h] [rbp+43h]
			//   int v31; // [rsp+D8h] [rbp+47h]
			//   int v32; // [rsp+DCh] [rbp+4Bh]
			//   int v33; // [rsp+E0h] [rbp+4Fh]
			//   int v34; // [rsp+E4h] [rbp+53h]
			// 
			//   if ( !byte_18D919E1A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGIrradianceVolumeQualitySettings);
			//     sub_18003C530(&off_18C9B8388);
			//     sub_18003C530(&off_18C9B8378);
			//     byte_18D919E1A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1563, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1563, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)gachaDataPath,
			//       0LL);
			//   }
			//   else
			//   {
			//     *(__m128i *)&config[32] = _mm_load_si128((const __m128i *)&xmmword_18A3573F0);
			//     *(_QWORD *)config = 0x8000000000LL;
			//     *(_QWORD *)&config[8] = 0x2000000020LL;
			//     *(_QWORD *)&config[68] = 64LL;
			//     *(_DWORD *)&config[48] = 64;
			//     v21 = 64;
			//     *(_DWORD *)&config[16] = 16;
			//     *(_QWORD *)&config[20] = 0x40000LL;
			//     *(_DWORD *)&config[28] = 1;
			//     *(_DWORD *)&config[60] = 0x20000;
			//     *(_DWORD *)&config[64] = 131008;
			//     *(_DWORD *)&config[52] = 131136;
			//     *(_DWORD *)&config[56] = 0x40000;
			//     *(_DWORD *)&config[84] = 0x2000;
			//     *(_DWORD *)&config[88] = 8184;
			//     *(_DWORD *)&config[92] = 8;
			//     *(_DWORD *)&config[76] = 0x2000;
			//     *(_DWORD *)&config[80] = 16376;
			//     *(__m128i *)&config[96] = _mm_load_si128((const __m128i *)&xmmword_18A357400);
			//     v15 = 4;
			//     v16 = 8;
			//     v17 = 0x100000;
			//     v18 = 8;
			//     v19 = 0x80000;
			//     v20 = 60;
			//     v22 = 32;
			//     v23 = 128;
			//     if ( TypeInfo::HG::Rendering::Runtime::HGIrradianceVolumeQualitySettings.static_fields.enableIvLowMemory )
			//     {
			//       v34 = 1;
			//       v24 = 196608;
			//       v25 = 393216;
			//       v26 = 24576;
			//     }
			//     else
			//     {
			//       v34 = 0;
			//       v24 = 0x40000;
			//       v25 = 0x80000;
			//       v26 = 0x8000;
			//     }
			//     v27 = 1084227584;
			//     v31 = 96;
			//     v33 = 96;
			//     v28 = 1101004800;
			//     v29 = 1117782016;
			//     v30 = 8;
			//     v32 = 48;
			//     this.fields.m_gachaIV = UnityEngine::HyperGryph::HGIrradianceVolume::Create(
			//                                (HGIrradianceVolumeConfig *)config,
			//                                0LL);
			//     this.fields.m_startGachaIV = 1;
			//     this.fields.m_gachaDataPathV2 = System::String::Concat(gachaDataPath, (String *)"/[dev]index.bytes", 0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_gachaDataPathV2,
			//       v5,
			//       v6,
			//       v7,
			//       *(String__Array **)config,
			//       *(String **)&config[8],
			//       *(MethodInfo **)&config[16]);
			//     this.fields.m_gachaDataPathV3 = System::String::Concat(gachaDataPath, (String *)"/v3/index.bytes", 0LL);
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_gachaDataPathV3,
			//       v8,
			//       v9,
			//       v10,
			//       *(String__Array **)config,
			//       *(String **)&config[8],
			//       *(MethodInfo **)&config[16]);
			//   }
			// }
			// 
		}

		public void UpdateGachaIV(string gachaDataPath)
		{
		}

		public void DestroyGachaIV()
		{
		}

		public void ReloadCurrentSceneIrradianceVolume()
		{
			// // Void ReloadCurrentSceneIrradianceVolume()
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadCurrentSceneIrradianceVolume(
			//         HGIrradianceVolumeManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1566, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1566, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadIndexFileV2(this, this.fields.m_irradianceDataPathV2, 0LL);
			//     HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadIndexFileV3(this, this.fields.m_irradianceDataPathV3, 0LL);
			//   }
			// }
			// 
		}

		public void ReloadIndexFileV2(string rootPath)
		{
			// // Void ReloadIndexFileV2(String)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadIndexFileV2(
			//         HGIrradianceVolumeManager *this,
			//         String *rootPath,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1567, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1567, 0LL);
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
			//     UnityEngine::HyperGryph::HGIrradianceVolume::SetMap(this.fields.m_defaultIV, rootPath, 0LL);
			//   }
			// }
			// 
		}

		public void ReloadIndexFileV3(string rootPath)
		{
			// // Void ReloadIndexFileV3(String)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::ReloadIndexFileV3(
			//         HGIrradianceVolumeManager *this,
			//         String *rootPath,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1568, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1568, 0LL);
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
			//     UnityEngine::HyperGryph::HGIrradianceVolume::SetMapV3(this.fields.m_defaultIV, rootPath, 0LL);
			//   }
			// }
			// 
		}

		public void GetStateNameListV2(List<string> stateNameList)
		{
			// // Void GetStateNameListV2(List`1[System.String])
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::GetStateNameListV2(
			//         HGIrradianceVolumeManager *this,
			//         List_1_System_String_ *stateNameList,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   String__Array *ActiveSceneStateNames; // rdi
			//   Object__Array *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCDC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//     byte_18D8EDCDC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1569, 0LL) )
			//   {
			//     ActiveSceneStateNames = UnityEngine::HyperGryph::HGIrradianceVolume::GetActiveSceneStateNames(0LL);
			//     if ( stateNameList )
			//     {
			//       v8 = System::Collections::Generic::List<System::Object>::ToArray(
			//              (List_1_System_Object_ *)stateNameList,
			//              MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//       UnityEngine::HyperGryph::HGIrradianceVolume::SetSceneStateNames((String__Array *)v8, ActiveSceneStateNames, 0LL);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1569, 0LL);
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
		public void UpdateSceneStateMaskV2(uint mask)
		{
			// // Void UpdateSceneStateMaskV2(UInt32)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::UpdateSceneStateMaskV2(
			//         HGIrradianceVolumeManager *this,
			//         uint32_t mask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1570, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1570, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, mask, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolume::SetActiveSceneStateMask(mask, 0LL);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public void UpdateSceneStateMaskV2(List<string> stateMask)
		{
			// // Void UpdateSceneStateMaskV2(List`1[System.String])
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::UpdateSceneStateMaskV2(
			//         HGIrradianceVolumeManager *this,
			//         List_1_System_String_ *stateMask,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E1D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//     byte_18D919E1D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1571, 0LL) )
			//   {
			//     if ( stateMask )
			//     {
			//       v7 = System::Collections::Generic::List<System::Object>::ToArray(
			//              (List_1_System_Object_ *)stateMask,
			//              MethodInfo::System::Collections::Generic::List<System::String>::ToArray);
			//       UnityEngine::HyperGryph::HGIrradianceVolume::SetActiveSceneStateNames((String__Array *)v7, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1571, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)stateMask,
			//     0LL);
			// }
			// 
		}

		public void StreamingInNewMapV2(string indexRootPath)
		{
		}

		public void StreamingInCabin(string slotId, uint roomTypeId)
		{
			// // Void StreamingInCabin(String, UInt32)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::StreamingInCabin(
			//         HGIrradianceVolumeManager *this,
			//         String *slotId,
			//         uint32_t roomTypeId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1573, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1573, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65(
			//       (ILFixDynamicMethodWrapper_18 *)Patch,
			//       (Object *)this,
			//       (Object *)slotId,
			//       (LogType__Enum)roomTypeId,
			//       0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolume::StreamingInCabin(this.fields.m_defaultIV, slotId, roomTypeId, 0LL);
			//   }
			// }
			// 
		}

		public void StreamingOutCabin(string slotId)
		{
			// // Void StreamingOutCabin(String)
			// void HG::Rendering::Runtime::HGIrradianceVolumeManager::StreamingOutCabin(
			//         HGIrradianceVolumeManager *this,
			//         String *slotId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1574, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1574, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)slotId,
			//       0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::HyperGryph::HGIrradianceVolume::StreamingOutCabin(this.fields.m_defaultIV, slotId, 0LL);
			//   }
			// }
			// 
		}

		public void ReleaseV2()
		{
		}

		private const string GACHA_IV_PATH = "IrradianceVolume/gacha/index.bytes";

		private long m_defaultIV;

		private string m_lastDataPathV2;

		private string m_lastDataPathV3;

		private string m_irradianceDataPathV2;

		private string m_irradianceDataPathV3;

		private string m_exportpathV2;

		private string m_exportpathV3;

		private long m_gachaIV;

		private bool m_startGachaIV;

		private bool m_endGachaIV;

		private string m_gachaDataPathV2;

		private string m_gachaDataPathV3;
	}
}
