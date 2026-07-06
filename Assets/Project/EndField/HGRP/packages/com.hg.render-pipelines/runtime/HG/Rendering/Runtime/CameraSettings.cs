using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct CameraSettings
	{
		public static CameraSettings NewDefault()
		{
			// // CameraSettings NewDefault()
			// CameraSettings *HG::Rendering::Runtime::CameraSettings::NewDefault(
			//         CameraSettings *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   CameraSettings_BufferClearing *v4; // rax
			//   __int64 v5; // rdx
			//   CameraSettings_Culling v6; // xmm0
			//   __int64 v7; // rdx
			//   __int64 v8; // rdx
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   CameraSettings_Volumes v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 *p_m11; // rax
			//   FrameSettingsOverrideMask v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   CameraSettings_Culling v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   CameraSettings *result; // rax
			//   ILFixDynamicMethodWrapper_2 *v31; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   ILFixDynamicMethodWrapper_2 *v34; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   CameraSettings *v38; // rax
			//   __int128 v39; // xmm1
			//   FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   unsigned __int128 v45; // [rsp+20h] [rbp-E0h] BYREF
			//   FrameSettings v46; // [rsp+30h] [rbp-D0h] BYREF
			//   __m256i v47; // [rsp+50h] [rbp-B0h] BYREF
			//   FrameSettingsOverrideMask v48; // [rsp+70h] [rbp-90h]
			//   __int128 v49; // [rsp+80h] [rbp-80h]
			//   _BYTE v50[108]; // [rsp+90h] [rbp-70h] BYREF
			//   CameraSettings_Culling v51; // [rsp+100h] [rbp+0h]
			//   char v52; // [rsp+110h] [rbp+10h]
			//   int v53; // [rsp+114h] [rbp+14h]
			//   int v54; // [rsp+118h] [rbp+18h]
			//   int v55; // [rsp+120h] [rbp+20h]
			//   CameraSettings_Frustum v56; // [rsp+130h] [rbp+30h] BYREF
			//   CameraSettings v57; // [rsp+188h] [rbp+88h] BYREF
			// 
			//   if ( !byte_18D8EDB7A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::BufferClearing);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Culling);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes);
			//     byte_18D8EDB7A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3440, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3440, 0LL);
			//     if ( Patch )
			//     {
			//       v38 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1232(&v57, Patch, 0LL);
			//       v39 = *(_OWORD *)&v38.renderingPathCustomFrameSettings.bitDatas.data2;
			//       *(_OWORD *)&retstr.customRenderingSettings = *(_OWORD *)&v38.customRenderingSettings;
			//       renderingPathCustomFrameSettingsOverrideMask = v38.renderingPathCustomFrameSettingsOverrideMask;
			//       *(_OWORD *)&retstr.renderingPathCustomFrameSettings.bitDatas.data2 = v39;
			//       v41 = *(_OWORD *)&v38.bufferClearing.clearColorMode;
			//       retstr.renderingPathCustomFrameSettingsOverrideMask = renderingPathCustomFrameSettingsOverrideMask;
			//       v42 = *(_OWORD *)&v38.bufferClearing.backgroundColorHDR.a;
			//       *(_OWORD *)&retstr.bufferClearing.clearColorMode = v41;
			//       v43 = *(_OWORD *)&v38.volumes.anchorOverride;
			//       *(_OWORD *)&retstr.bufferClearing.backgroundColorHDR.a = v42;
			//       v44 = *(_OWORD *)&v38.frustum.farClipPlaneRaw;
			//       *(_OWORD *)&retstr.volumes.anchorOverride = v43;
			//       *(_OWORD *)&retstr.frustum.farClipPlaneRaw = v44;
			//       v23 = *(_OWORD *)&v38.frustum.projectionMatrix.m10;
			//       p_m11 = (__int128 *)&v38.frustum.projectionMatrix.m11;
			//       goto LABEL_17;
			//     }
			//     goto LABEL_25;
			//   }
			//   sub_1802F01E0(&v47, 0LL, 224LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::BufferClearing._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::CameraSettings::BufferClearing, v3);
			//   v4 = HG::Rendering::Runtime::CameraSettings::BufferClearing::NewDefault((CameraSettings_BufferClearing *)&v46, 0LL);
			//   v49 = *(_OWORD *)&v4.clearColorMode;
			//   *(_QWORD *)v50 = *(_QWORD *)&v4.backgroundColorHDR.a;
			//   if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::Culling._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::CameraSettings::Culling, v5);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3442, 0LL) )
			//   {
			//     v31 = IFix::WrappersManagerImpl::GetPatch(3442, 0LL);
			//     if ( v31 )
			//     {
			//       v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1229((CameraSettings_Culling *)&v45, v31, 0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_25:
			//     sub_180B536AC(v33, v32);
			//   }
			//   v45 = 0xFFFFFFFF00000001uLL;
			//   v6 = (CameraSettings_Culling)0xFFFFFFFF00000001uLL;
			// LABEL_10:
			//   v51 = v6;
			//   *(FrameSettings *)&v47.m256i_u64[1] = *HG::Rendering::Runtime::FrameSettings::NewDefaultCamera(&v46, 0LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum, v7);
			//   *(CameraSettings_Frustum *)&v50[24] = *HG::Rendering::Runtime::CameraSettings::Frustum::NewDefault(&v56, 0LL);
			//   v47.m256i_i8[0] = 0;
			//   if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes, v8);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3444, 0LL) )
			//   {
			//     v34 = IFix::WrappersManagerImpl::GetPatch(3444, 0LL);
			//     if ( !v34 )
			//       sub_180B536AC(v36, v35);
			//     v15 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1231((CameraSettings_Volumes *)&v46, v34, 0LL);
			//   }
			//   else
			//   {
			//     v45 = 0xFFFFFFFFuLL;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
			//       (OneofDescriptor *)((char *)&v45 + 8),
			//       v9,
			//       v10,
			//       v11,
			//       (String__Array *)0xFFFFFFFFLL);
			//     v15 = (CameraSettings_Volumes)v45;
			//   }
			//   *(CameraSettings_Volumes *)&v50[8] = v15;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&v50[16],
			//     v12,
			//     v13,
			//     v14,
			//     (String__Array *)v45,
			//     *((String **)&v45 + 1),
			//     (MethodInfo *)v46.bitDatas.data1);
			//   v53 = 0;
			//   v52 = 0;
			//   v54 = -1;
			//   v55 = 1065353216;
			//   v16 = *(_OWORD *)&v47.m256i_u64[2];
			//   p_m11 = (__int128 *)&v50[64];
			//   *(_OWORD *)&retstr.customRenderingSettings = *(_OWORD *)v47.m256i_i8;
			//   v18 = v48;
			//   *(_OWORD *)&retstr.renderingPathCustomFrameSettings.bitDatas.data2 = v16;
			//   v19 = v49;
			//   retstr.renderingPathCustomFrameSettingsOverrideMask = v18;
			//   v20 = *(_OWORD *)v50;
			//   *(_OWORD *)&retstr.bufferClearing.clearColorMode = v19;
			//   v21 = *(_OWORD *)&v50[16];
			//   *(_OWORD *)&retstr.bufferClearing.backgroundColorHDR.a = v20;
			//   v22 = *(_OWORD *)&v50[32];
			//   *(_OWORD *)&retstr.volumes.anchorOverride = v21;
			//   *(_OWORD *)&retstr.frustum.farClipPlaneRaw = v22;
			//   v23 = *(_OWORD *)&v50[48];
			// LABEL_17:
			//   v24 = *p_m11;
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m10 = v23;
			//   v25 = p_m11[1];
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m11 = v24;
			//   v26 = p_m11[2];
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m12 = v25;
			//   v27 = (CameraSettings_Culling)p_m11[3];
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m13 = v26;
			//   v28 = p_m11[4];
			//   retstr.culling = v27;
			//   v29 = p_m11[5];
			//   result = retstr;
			//   *(_OWORD *)&retstr.invertFaceCulling = v28;
			//   *(_OWORD *)&retstr.probeRangeCompressionFactor = v29;
			//   return result;
			// }
			// 
			return null;
		}

		public static CameraSettings From(HGCamera hgCamera)
		{
			// // CameraSettings From(HGCamera)
			// CameraSettings *HG::Rendering::Runtime::CameraSettings::From(
			//         CameraSettings *__return_ptr retstr,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   float v3; // xmm2_4
			//   __int64 v6; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   CameraSettings *v13; // rax
			//   __int128 v14; // xmm1
			//   FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm0
			//   FrameSettingsOverrideMask v22; // xmm1
			//   CameraSettings_Culling v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   CameraSettings *result; // rax
			//   struct CameraSettings__Class *v27; // rax
			//   __int64 p_defaultCameraSettingsNonAlloc; // rax
			//   __int128 v29; // xmm0
			//   Camera *camera; // rdi
			//   __int64 (__fastcall *v31)(Camera *); // rax
			//   int32_t v32; // eax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   Camera *v35; // rdi
			//   __int64 (__fastcall *v36)(Camera *); // rax
			//   char v37; // al
			//   __int64 v38; // rdx
			//   Object *v39; // rsi
			//   struct ILFixDynamicMethodWrapper_2__Class *v40; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v41; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v42; // rdi
			//   ILFixDynamicMethodWrapper_2 *v43; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   uint64_t v46; // rax
			//   Camera *v47; // rdi
			//   float (__fastcall *v48)(Camera *); // rax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   float v51; // xmm0_4
			//   Camera *v52; // rdi
			//   float (__fastcall *v53)(Camera *); // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   float v56; // xmm0_4
			//   Camera *v57; // rdi
			//   float (__fastcall *v58)(Camera *); // rax
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   float v61; // xmm0_4
			//   Camera *v62; // rdi
			//   float (__fastcall *v63)(Camera *); // rax
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   float v66; // xmm0_4
			//   Camera *v67; // rdi
			//   void (__fastcall *v68)(Camera *, __int128 *); // rax
			//   __int64 v69; // rdx
			//   __int64 v70; // rcx
			//   Component *v71; // rdi
			//   unsigned __int64 v72; // rdx
			//   Object *v73; // rcx
			//   FrameSettingsOverrideMask v74; // xmm0
			//   unsigned __int64 v75; // rdx
			//   signed __int64 v76; // rtt
			//   signed __int64 v77; // rtt
			//   Camera *v78; // rdi
			//   void (__fastcall *v79)(Camera *, __int128 *); // rax
			//   double (__fastcall *v80)(__int128 *); // rax
			//   double v81; // xmm0_8
			//   Camera *v82; // rdi
			//   void (__fastcall *v83)(Camera *, __int128 *); // rax
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v84; // rcx
			//   unsigned __int8 IsSame; // al
			//   Camera *v86; // rdi
			//   unsigned __int8 v87; // si
			//   void (__fastcall *v88)(Camera *, __int128 *); // rax
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v89; // rcx
			//   unsigned __int8 v90; // al
			//   bool v91; // r14
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v92; // rcx
			//   bool v93; // zf
			//   char v94; // al
			//   __int128 v95; // xmm1
			//   FrameSettingsOverrideMask v96; // xmm0
			//   __int128 v97; // xmm1
			//   __int128 v98; // xmm0
			//   __int128 v99; // xmm1
			//   __int128 v100; // xmm0
			//   __int128 v101; // xmm1
			//   __int128 v102; // xmm0
			//   __int128 v103; // xmm1
			//   __int128 v104; // xmm0
			//   CameraSettings_Culling v105; // xmm1
			//   __int128 v106; // xmm0
			//   __int128 v107; // xmm1
			//   __int64 v108; // rax
			//   __int64 v109; // rax
			//   __int64 v110; // rax
			//   __int64 v111; // rax
			//   __int64 v112; // rax
			//   __int64 v113; // rax
			//   __int64 v114; // rax
			//   __int64 v115; // rax
			//   __int64 v116; // rax
			//   __int64 v117; // rax
			//   __int64 v118; // rax
			//   __int128 v119; // [rsp+20h] [rbp-E0h] BYREF
			//   __int128 v120; // [rsp+30h] [rbp-D0h]
			//   __int128 v121; // [rsp+40h] [rbp-C0h]
			//   __int128 v122; // [rsp+50h] [rbp-B0h]
			//   __int128 v123; // [rsp+60h] [rbp-A0h] BYREF
			//   __int128 v124; // [rsp+70h] [rbp-90h] BYREF
			//   __int128 v125; // [rsp+80h] [rbp-80h]
			//   __int128 v126; // [rsp+90h] [rbp-70h]
			//   __int128 v127; // [rsp+A0h] [rbp-60h]
			//   __m256i v128; // [rsp+B0h] [rbp-50h] BYREF
			//   FrameSettingsOverrideMask v129; // [rsp+D0h] [rbp-30h]
			//   _BYTE v130[48]; // [rsp+E0h] [rbp-20h] BYREF
			//   _BYTE v131[80]; // [rsp+110h] [rbp+10h] BYREF
			//   CameraSettings_Culling v132; // [rsp+160h] [rbp+60h]
			//   __int128 v133; // [rsp+170h] [rbp+70h]
			//   __int128 v134; // [rsp+180h] [rbp+80h]
			//   Matrix4x4 v135; // [rsp+190h] [rbp+90h] BYREF
			//   CameraSettings v136; // [rsp+1D0h] [rbp+D0h] BYREF
			//   Object *component; // [rsp+2F0h] [rbp+1F0h] BYREF
			// 
			//   if ( !byte_18D8EDB7B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings);
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDB7B = 1;
			//   }
			//   sub_1802F01E0(&v128, 0LL, 224LL);
			//   v123 = 0LL;
			//   component = 0LL;
			//   v124 = 0LL;
			//   v125 = 0LL;
			//   v126 = 0LL;
			//   v127 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v6);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, v6);
			//   if ( wrapperArray.max_length.size > 805 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, v6);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = v7.static_fields.wrapperArray;
			//     if ( !v9 )
			//       sub_180B536AC(v7, v6);
			//     if ( v9.max_length.size <= 0x325u )
			//       sub_180070270(v7, v6);
			//     if ( v9[22].vector[13] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(805, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v12, v11);
			//       v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_306(&v136, Patch, (Object *)hgCamera, 0LL);
			//       v14 = *(_OWORD *)&v13.renderingPathCustomFrameSettings.bitDatas.data2;
			//       *(_OWORD *)&retstr.customRenderingSettings = *(_OWORD *)&v13.customRenderingSettings;
			//       renderingPathCustomFrameSettingsOverrideMask = v13.renderingPathCustomFrameSettingsOverrideMask;
			//       *(_OWORD *)&retstr.renderingPathCustomFrameSettings.bitDatas.data2 = v14;
			//       v16 = *(_OWORD *)&v13.bufferClearing.clearColorMode;
			//       retstr.renderingPathCustomFrameSettingsOverrideMask = renderingPathCustomFrameSettingsOverrideMask;
			//       v17 = *(_OWORD *)&v13.bufferClearing.backgroundColorHDR.a;
			//       *(_OWORD *)&retstr.bufferClearing.clearColorMode = v16;
			//       v18 = *(_OWORD *)&v13.volumes.anchorOverride;
			//       *(_OWORD *)&retstr.bufferClearing.backgroundColorHDR.a = v17;
			//       v19 = *(_OWORD *)&v13.frustum.farClipPlaneRaw;
			//       *(_OWORD *)&retstr.volumes.anchorOverride = v18;
			//       *(_OWORD *)&retstr.frustum.farClipPlaneRaw = v19;
			//       v20 = *(_OWORD *)&v13.frustum.projectionMatrix.m10;
			//       v13 = (CameraSettings *)((char *)v13 + 128);
			//       *(_OWORD *)&retstr.frustum.projectionMatrix.m10 = v20;
			//       v21 = *(_OWORD *)&v13.renderingPathCustomFrameSettings.bitDatas.data2;
			//       *(_OWORD *)&retstr.frustum.projectionMatrix.m11 = *(_OWORD *)&v13.customRenderingSettings;
			//       v22 = v13.renderingPathCustomFrameSettingsOverrideMask;
			//       *(_OWORD *)&retstr.frustum.projectionMatrix.m12 = v21;
			//       v23 = *(CameraSettings_Culling *)&v13.bufferClearing.clearColorMode;
			//       *(FrameSettingsOverrideMask *)&retstr.frustum.projectionMatrix.m13 = v22;
			//       v24 = *(_OWORD *)&v13.bufferClearing.backgroundColorHDR.a;
			//       retstr.culling = v23;
			//       v25 = *(_OWORD *)&v13.volumes.anchorOverride;
			//       result = retstr;
			//       *(_OWORD *)&retstr.invertFaceCulling = v24;
			//       *(_OWORD *)&retstr.probeRangeCompressionFactor = v25;
			//       return result;
			//     }
			//   }
			//   v27 = TypeInfo::HG::Rendering::Runtime::CameraSettings;
			//   if ( !TypeInfo::HG::Rendering::Runtime::CameraSettings._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::CameraSettings, v6);
			//     v27 = TypeInfo::HG::Rendering::Runtime::CameraSettings;
			//   }
			//   p_defaultCameraSettingsNonAlloc = (__int64)&v27.static_fields.defaultCameraSettingsNonAlloc;
			//   v128 = *(__m256i *)p_defaultCameraSettingsNonAlloc;
			//   v129 = *(FrameSettingsOverrideMask *)(p_defaultCameraSettingsNonAlloc + 32);
			//   *(_OWORD *)v130 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 48);
			//   *(_OWORD *)&v130[16] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 64);
			//   *(_OWORD *)&v130[32] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 80);
			//   *(_OWORD *)v131 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 96);
			//   v29 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 112);
			//   p_defaultCameraSettingsNonAlloc += 128LL;
			//   *(_OWORD *)&v131[16] = v29;
			//   *(_OWORD *)&v131[32] = *(_OWORD *)p_defaultCameraSettingsNonAlloc;
			//   *(_OWORD *)&v131[48] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 16);
			//   *(_OWORD *)&v131[64] = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 32);
			//   v132 = *(CameraSettings_Culling *)(p_defaultCameraSettingsNonAlloc + 48);
			//   v133 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 64);
			//   v134 = *(_OWORD *)(p_defaultCameraSettingsNonAlloc + 80);
			//   if ( !hgCamera )
			//     sub_180B536AC(&v131[32], v6);
			//   camera = hgCamera.fields.camera;
			//   if ( !camera )
			//     sub_180B536AC(&v131[32], v6);
			//   v31 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//   if ( !qword_18D8F41E8 )
			//   {
			//     v31 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cullingMask()");
			//     if ( !v31 )
			//     {
			//       v108 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMask()");
			//       sub_18000F750(v108, 0LL);
			//     }
			//     qword_18D8F41E8 = (__int64)v31;
			//   }
			//   v32 = v31(camera);
			//   v35 = hgCamera.fields.camera;
			//   v132.cullingMask.m_Mask = v32;
			//   if ( !v35 )
			//     sub_180B536AC(v34, v33);
			//   v36 = (__int64 (__fastcall *)(Camera *))qword_18D8F4208;
			//   if ( !qword_18D8F4208 )
			//   {
			//     v36 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_useOcclusionCulling()");
			//     if ( !v36 )
			//     {
			//       v109 = sub_1802DBBE8("UnityEngine.Camera::get_useOcclusionCulling()");
			//       sub_18000F750(v109, 0LL);
			//     }
			//     qword_18D8F4208 = (__int64)v36;
			//   }
			//   v37 = v36(v35);
			//   v39 = (Object *)hgCamera.fields.camera;
			//   v132.useOcclusionCulling = v37;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v38);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v40 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v38);
			//     v40 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v41 = v40.static_fields.wrapperArray;
			//   if ( !v41 )
			//     sub_180B536AC(v40, v38);
			//   if ( v41.max_length.size <= 793 )
			//     goto LABEL_42;
			//   if ( !v40._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v40, v38);
			//     v40 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v42 = v40.static_fields.wrapperArray;
			//   if ( !v42 )
			//     sub_180B536AC(v40, v38);
			//   if ( v42.max_length.size <= 0x319u )
			//     sub_180070270(v40, v38);
			//   if ( v42[22].vector[1] )
			//   {
			//     v43 = IFix::WrappersManagerImpl::GetPatch(793, 0LL);
			//     if ( !v43 )
			//       sub_180B536AC(v45, v44);
			//     v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)v43, v39, 0LL);
			//   }
			//   else
			//   {
			// LABEL_42:
			//     v46 = 0LL;
			//   }
			//   v47 = hgCamera.fields.camera;
			//   v132.sceneCullingMaskOverride = v46;
			//   if ( !v47 )
			//     sub_180B536AC(v40, v38);
			//   v48 = (float (__fastcall *)(Camera *))qword_18D8F41E0;
			//   if ( !qword_18D8F41E0 )
			//   {
			//     v48 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_aspect()");
			//     if ( !v48 )
			//     {
			//       v110 = sub_1802DBBE8("UnityEngine.Camera::get_aspect()");
			//       sub_18000F750(v110, 0LL);
			//     }
			//     qword_18D8F41E0 = (__int64)v48;
			//   }
			//   v51 = v48(v47);
			//   v52 = hgCamera.fields.camera;
			//   *(float *)&v130[44] = v51;
			//   if ( !v52 )
			//     sub_180B536AC(v50, v49);
			//   v53 = (float (__fastcall *)(Camera *))qword_18D8F4188;
			//   if ( !qword_18D8F4188 )
			//   {
			//     v53 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_farClipPlane()");
			//     if ( !v53 )
			//     {
			//       v111 = sub_1802DBBE8("UnityEngine.Camera::get_farClipPlane()");
			//       sub_18000F750(v111, 0LL);
			//     }
			//     qword_18D8F4188 = (__int64)v53;
			//   }
			//   v56 = v53(v52);
			//   v57 = hgCamera.fields.camera;
			//   *(float *)v131 = v56;
			//   if ( !v57 )
			//     sub_180B536AC(v55, v54);
			//   v58 = (float (__fastcall *)(Camera *))qword_18D8F4178;
			//   if ( !qword_18D8F4178 )
			//   {
			//     v58 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_nearClipPlane()");
			//     if ( !v58 )
			//     {
			//       v112 = sub_1802DBBE8("UnityEngine.Camera::get_nearClipPlane()");
			//       sub_18000F750(v112, 0LL);
			//     }
			//     qword_18D8F4178 = (__int64)v58;
			//   }
			//   v61 = v58(v57);
			//   v62 = hgCamera.fields.camera;
			//   *(float *)&v131[4] = v61;
			//   if ( !v62 )
			//     sub_180B536AC(v60, v59);
			//   v63 = (float (__fastcall *)(Camera *))qword_18D8F4198;
			//   if ( !qword_18D8F4198 )
			//   {
			//     v63 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_fieldOfView()");
			//     if ( !v63 )
			//     {
			//       v113 = sub_1802DBBE8("UnityEngine.Camera::get_fieldOfView()");
			//       sub_18000F750(v113, 0LL);
			//     }
			//     qword_18D8F4198 = (__int64)v63;
			//   }
			//   v66 = v63(v62);
			//   v67 = hgCamera.fields.camera;
			//   *(float *)&v131[8] = v66;
			//   *(_DWORD *)&v130[40] = 1;
			//   if ( !v67 )
			//     sub_180B536AC(v65, v64);
			//   v68 = (void (__fastcall *)(Camera *, __int128 *))qword_18D8F42F0;
			//   v119 = 0LL;
			//   v120 = 0LL;
			//   v121 = 0LL;
			//   v122 = 0LL;
			//   if ( !qword_18D8F42F0 )
			//   {
			//     v68 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v68 )
			//     {
			//       v114 = sub_1802DBBE8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v114, 0LL);
			//     }
			//     qword_18D8F42F0 = (__int64)v68;
			//   }
			//   v68(v67, &v119);
			//   v71 = (Component *)hgCamera.fields.camera;
			//   LOBYTE(v133) = 0;
			//   *(_OWORD *)&v131[12] = v119;
			//   *(_OWORD *)&v131[28] = v120;
			//   *(_OWORD *)&v131[44] = v121;
			//   *(_OWORD *)&v131[60] = v122;
			//   if ( !v71 )
			//     sub_180B536AC(v70, v69);
			//   if ( UnityEngine::Component::TryGetComponent<System::Object>(
			//          v71,
			//          &component,
			//          MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>) )
			//   {
			//     v73 = component;
			//     if ( !component )
			//       sub_180B536AC(0LL, v72);
			//     v128.m256i_i8[0] = BYTE2(component[8].klass);
			//     *(Object *)&v130[4] = *(Object *)((char *)component + 36);
			//     *(_DWORD *)v130 = component[2].klass;
			//     v130[20] = BYTE4(component[3].klass);
			//     DWORD1(v133) = HIDWORD(component[7].klass);
			//     *(Object *)&v128.m256i_u64[1] = component[11];
			//     v128.m256i_i64[3] = (__int64)component[12].klass;
			//     v74 = *(FrameSettingsOverrideMask *)&component[12].monitor;
			//     *(_QWORD *)&v123 = 0LL;
			//     v129 = v74;
			//     v72 = (unsigned int)dword_18D8E43F8;
			//     *((_QWORD *)&v123 + 1) = component[4].klass;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v75 = ((((unsigned __int64)&v123 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v75 + 36190]);
			//       do
			//         v76 = qword_18D6405E0[v75 + 36190];
			//       while ( v76 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v75 + 36190],
			//                        v76 | (1LL << ((((unsigned __int64)&v123 + 8) >> 12) & 0x3F)),
			//                        v76) );
			//       v73 = component;
			//       v72 = (unsigned int)dword_18D8E43F8;
			//     }
			//     if ( !v73 )
			//       goto LABEL_99;
			//     LODWORD(v123) = v73[3].monitor;
			//     *(_OWORD *)&v130[24] = v123;
			//     if ( (_DWORD)v72 )
			//     {
			//       v72 = (((unsigned __int64)&v130[32] >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v72 + 36190]);
			//       do
			//         v77 = qword_18D6405E0[v72 + 36190];
			//       while ( v77 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v72 + 36190],
			//                        v77 | (1LL << (((unsigned __int64)&v130[32] >> 12) & 0x3F)),
			//                        v77) );
			//       v73 = component;
			//     }
			//     if ( !v73 )
			//       goto LABEL_99;
			//     DWORD2(v133) = HIDWORD(v73[8].klass);
			//     LOBYTE(v133) = BYTE3(v73[8].klass);
			//   }
			//   v78 = hgCamera.fields.camera;
			//   if ( !v78 )
			//     goto LABEL_99;
			//   v79 = (void (__fastcall *)(Camera *, __int128 *))qword_18D8F42E8;
			//   v119 = 0LL;
			//   v120 = 0LL;
			//   v121 = 0LL;
			//   v122 = 0LL;
			//   if ( !qword_18D8F42E8 )
			//   {
			//     v79 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v79 )
			//     {
			//       v115 = sub_1802DBBE8("UnityEngine.Camera::get_worldToCameraMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v115, 0LL);
			//     }
			//     qword_18D8F42E8 = (__int64)v79;
			//   }
			//   v79(v78, &v119);
			//   v80 = (double (__fastcall *)(__int128 *))qword_18D8F4BB0;
			//   v124 = v119;
			//   v125 = v120;
			//   v126 = v121;
			//   v127 = v122;
			//   if ( !qword_18D8F4BB0 )
			//   {
			//     v80 = (double (__fastcall *)(__int128 *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::GetDeterminant_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v80 )
			//     {
			//       v116 = sub_1802DBBE8("UnityEngine.Matrix4x4::GetDeterminant_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v116, 0LL);
			//     }
			//     qword_18D8F4BB0 = (__int64)v80;
			//   }
			//   v81 = v80(&v124);
			//   v82 = hgCamera.fields.camera;
			//   if ( !v82 )
			//     goto LABEL_99;
			//   v83 = (void (__fastcall *)(Camera *, __int128 *))qword_18D8F42F0;
			//   v119 = 0LL;
			//   v120 = 0LL;
			//   v121 = 0LL;
			//   v122 = 0LL;
			//   if ( !qword_18D8F42F0 )
			//   {
			//     v83 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v83 )
			//     {
			//       v117 = sub_1802DBBE8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v117, 0LL);
			//     }
			//     qword_18D8F42F0 = (__int64)v83;
			//   }
			//   v83(v82, &v119);
			//   IsSame = UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v84, -1.0, v3);
			//   v86 = hgCamera.fields.camera;
			//   v87 = IsSame;
			//   if ( !v86 )
			//     goto LABEL_99;
			//   v88 = (void (__fastcall *)(Camera *, __int128 *))qword_18D8F42F0;
			//   v119 = 0LL;
			//   v120 = 0LL;
			//   v121 = 0LL;
			//   v122 = 0LL;
			//   if ( !qword_18D8F42F0 )
			//   {
			//     v88 = (void (__fastcall *)(Camera *, __int128 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//     if ( !v88 )
			//     {
			//       v118 = sub_1802DBBE8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v118, 0LL);
			//     }
			//     qword_18D8F42F0 = (__int64)v88;
			//   }
			//   v88(v86, &v119);
			//   v90 = UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v89, 1.0, v3);
			//   if ( v90 )
			//   {
			//     v72 = (unsigned __int64)hgCamera.fields.camera;
			//     v91 = *(float *)&v81 > 0.0;
			//     if ( v72 )
			//     {
			//       UnityEngine::Camera::get_projectionMatrix(&v135, (Camera *)v72, 0LL);
			//       v90 = UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v92, 1.0, v3);
			//       goto LABEL_96;
			//     }
			// LABEL_99:
			//     sub_1802DC2C8(v73, v72);
			//   }
			//   v91 = *(float *)&v81 > 0.0;
			// LABEL_96:
			//   v93 = (v91 & v87 & v90) == 0;
			//   v94 = v133;
			//   if ( !v93 )
			//     v94 = 1;
			//   LOBYTE(v133) = v94;
			//   v95 = *(_OWORD *)&v128.m256i_u64[2];
			//   *(_OWORD *)&retstr.customRenderingSettings = *(_OWORD *)v128.m256i_i8;
			//   v96 = v129;
			//   *(_OWORD *)&retstr.renderingPathCustomFrameSettings.bitDatas.data2 = v95;
			//   v97 = *(_OWORD *)v130;
			//   retstr.renderingPathCustomFrameSettingsOverrideMask = v96;
			//   v98 = *(_OWORD *)&v130[16];
			//   *(_OWORD *)&retstr.bufferClearing.clearColorMode = v97;
			//   v99 = *(_OWORD *)&v130[32];
			//   *(_OWORD *)&retstr.bufferClearing.backgroundColorHDR.a = v98;
			//   v100 = *(_OWORD *)v131;
			//   *(_OWORD *)&retstr.volumes.anchorOverride = v99;
			//   v101 = *(_OWORD *)&v131[16];
			//   *(_OWORD *)&retstr.frustum.farClipPlaneRaw = v100;
			//   v102 = *(_OWORD *)&v131[32];
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m10 = v101;
			//   v103 = *(_OWORD *)&v131[48];
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m11 = v102;
			//   v104 = *(_OWORD *)&v131[64];
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m12 = v103;
			//   v105 = v132;
			//   *(_OWORD *)&retstr.frustum.projectionMatrix.m13 = v104;
			//   v106 = v133;
			//   retstr.culling = v105;
			//   v107 = v134;
			//   result = retstr;
			//   *(_OWORD *)&retstr.invertFaceCulling = v106;
			//   *(_OWORD *)&retstr.probeRangeCompressionFactor = v107;
			//   return result;
			// }
			// 
			return null;
		}

		internal Hash128 GetHash()
		{
			// // Hash128 GetHash()
			// Hash128 *HG::Rendering::Runtime::CameraSettings::GetHash(
			//         Hash128 *__return_ptr retstr,
			//         CameraSettings *this,
			//         MethodInfo *method)
			// {
			//   CameraSettings_Volumes volumes; // xmm0
			//   int32_t HashCode; // eax
			//   Hash128 v7; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Hash128 *result; // rax
			//   Hash128 inHash; // [rsp+20h] [rbp-40h] BYREF
			//   Hash128 hash; // [rsp+30h] [rbp-30h] BYREF
			//   ValueType v14; // [rsp+40h] [rbp-20h] BYREF
			//   CameraSettings_Volumes v15; // [rsp+50h] [rbp-10h]
			// 
			//   if ( !byte_18D919747 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<bool>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::HGAdditionalCameraData::FlipYMode>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettingsOverrideMask>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettingsRenderType>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettings>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Frustum>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<UnityEngine::LayerMask>);
			//     sub_18003C530(&MethodInfo::UnityEngine::HashUtilities::ComputeHash128<float>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes);
			//     byte_18D919747 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3445, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3445, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     v7 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1233(&hash, Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     hash = 0LL;
			//     inHash = 0LL;
			//     UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>(
			//       &this.bufferClearing,
			//       &hash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>);
			//     UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>(
			//       &this.culling,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<bool>(
			//       &this.customRenderingSettings,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<bool>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<float>(
			//       (float *)&this.defaultFrameSettings,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettingsRenderType>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<float>(
			//       (float *)&this.flipYMode,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::HGAdditionalCameraData::FlipYMode>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Frustum>(
			//       &this.frustum,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Frustum>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<bool>(
			//       &this.invertFaceCulling,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<bool>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<float>(
			//       (float *)&this.probeLayerMask.m_Mask,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<UnityEngine::LayerMask>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<float>(
			//       &this.probeRangeCompressionFactor,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<float>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::BufferClearing>(
			//       (CameraSettings_BufferClearing *)&this.renderingPathCustomFrameSettings,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettings>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::CameraSettings::Culling>(
			//       (CameraSettings_Culling *)&this.renderingPathCustomFrameSettingsOverrideMask,
			//       &inHash,
			//       MethodInfo::UnityEngine::HashUtilities::ComputeHash128<HG::Rendering::Runtime::FrameSettingsOverrideMask>);
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     volumes = this.volumes;
			//     v14.monitor = (MonitorData *)-1LL;
			//     v15 = volumes;
			//     v14.klass = (ValueType__Class *)TypeInfo::HG::Rendering::Runtime::CameraSettings::Volumes;
			//     HashCode = System::ValueType::GetHashCode(&v14, 0LL);
			//     inHash.u64_1 = 0LL;
			//     inHash.u64_0 = HashCode;
			//     UnityEngine::HashUtilities::AppendHash(&inHash, &hash, 0LL);
			//     v7 = hash;
			//   }
			//   result = retstr;
			//   *retstr = v7;
			//   return result;
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		[Obsolete("Since 2019.3, use CameraSettings.defaultCameraSettingsNonAlloc instead.")]
		public static readonly CameraSettings @default;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xE0")]
		public static readonly CameraSettings defaultCameraSettingsNonAlloc;

		public bool customRenderingSettings;

		public FrameSettings renderingPathCustomFrameSettings;

		public FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask;

		public CameraSettings.BufferClearing bufferClearing;

		public CameraSettings.Volumes volumes;

		public CameraSettings.Frustum frustum;

		public CameraSettings.Culling culling;

		public bool invertFaceCulling;

		public HGAdditionalCameraData.FlipYMode flipYMode;

		public LayerMask probeLayerMask;

		public FrameSettingsRenderType defaultFrameSettings;

		internal float probeRangeCompressionFactor;

		[SerializeField]
		[FormerlySerializedAs("renderingPath")]
		[Obsolete("For data migration")]
		internal int m_ObsoleteRenderingPath;

		[SerializeField]
		[FormerlySerializedAs("frameSettings")]
		[Obsolete("For data migration")]
		internal ObsoleteFrameSettings m_ObsoleteFrameSettings;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		public struct BufferClearing
		{
			public static CameraSettings.BufferClearing NewDefault()
			{
				// // CameraSettings+BufferClearing NewDefault()
				// CameraSettings_BufferClearing *HG::Rendering::Runtime::CameraSettings::BufferClearing::NewDefault(
				//         CameraSettings_BufferClearing *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   Color *v3; // rax
				//   __int128 v4; // xmm0
				//   __int64 v5; // xmm1_8
				//   CameraSettings_BufferClearing *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				//   CameraSettings_BufferClearing *v10; // rax
				//   _BYTE v11[16]; // [rsp+20h] [rbp-38h] BYREF
				//   CameraSettings_BufferClearing v12; // [rsp+30h] [rbp-28h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3441, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3441, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v9, v8);
				//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1228(&v12, Patch, 0LL);
				//     v4 = *(_OWORD *)&v10.clearColorMode;
				//     v5 = *(_QWORD *)&v10.backgroundColorHDR.a;
				//   }
				//   else
				//   {
				//     memset(&v12, 0, sizeof(v12));
				//     v3 = (Color *)sub_182562090(v11, 3150342LL);
				//     v12.clearDepth = 1;
				//     v12.backgroundColorHDR = *v3;
				//     v4 = *(_OWORD *)&v12.clearColorMode;
				//     v5 = *(_QWORD *)&v12.backgroundColorHDR.a;
				//   }
				//   *(_OWORD *)&retstr.clearColorMode = v4;
				//   result = retstr;
				//   *(_QWORD *)&retstr.backgroundColorHDR.a = v5;
				//   return result;
				// }
				// 
				return default(CameraSettings.BufferClearing);
			}

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			[Obsolete("Since 2019.3, use BufferClearing.NewDefault() instead.")]
			public static readonly CameraSettings.BufferClearing @default;

			public HGAdditionalCameraData.ClearColorMode clearColorMode;

			[ColorUsage(true, true)]
			public Color backgroundColorHDR;

			public bool clearDepth;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Volumes
		{
			public static CameraSettings.Volumes NewDefault()
			{
				// // CameraSettings+Volumes NewDefault()
				// CameraSettings_Volumes *HG::Rendering::Runtime::CameraSettings::Volumes::NewDefault(
				//         CameraSettings_Volumes *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   OneofDescriptorProto *v3; // rdx
				//   FileDescriptor *v4; // r8
				//   MessageDescriptor *v5; // r9
				//   CameraSettings_Volumes v6; // xmm0
				//   CameraSettings_Volumes *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   CameraSettings_Volumes v11; // [rsp+20h] [rbp-28h] BYREF
				//   CameraSettings_Volumes v12; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3444, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3444, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1231(&v12, Patch, 0LL);
				//   }
				//   else
				//   {
				//     v11 = (CameraSettings_Volumes)0xFFFFFFFFuLL;
				//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *))sub_1800054D0)(
				//       (OneofDescriptor *)&v11.anchorOverride,
				//       v3,
				//       v4,
				//       v5,
				//       *(String__Array **)&v11.layerMask.m_Mask);
				//     v6 = v11;
				//   }
				//   result = retstr;
				//   *retstr = v6;
				//   return result;
				// }
				// 
				return default(CameraSettings.Volumes);
			}

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			[Obsolete("Since 2019.3, use Volumes.NewDefault() instead.")]
			public static readonly CameraSettings.Volumes @default;

			public LayerMask layerMask;

			public Transform anchorOverride;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 84)]
		public struct Frustum
		{
			// (get) Token: 0x0600166A RID: 5738 RVA: 0x000025F0 File Offset: 0x000007F0
			public float farClipPlane
			{
				get
				{
					// // Single get_farClipPlane()
					// float HG::Rendering::Runtime::CameraSettings::Frustum::get_farClipPlane(
					//         CameraSettings_Frustum *this,
					//         MethodInfo *method)
					// {
					//   return fmaxf(this.nearClipPlaneRaw + 0.000099999997, this.farClipPlaneRaw);
					// }
					// 
					return 0f;
				}
			}

			// (get) Token: 0x0600166B RID: 5739 RVA: 0x000025F0 File Offset: 0x000007F0
			public float nearClipPlane
			{
				get
				{
					// // Single get_nearClipPlane()
					// float HG::Rendering::Runtime::CameraSettings::Frustum::get_nearClipPlane(
					//         CameraSettings_Frustum *this,
					//         MethodInfo *method)
					// {
					//   return fmaxf(0.0000099999997, this.nearClipPlaneRaw);
					// }
					// 
					return 0f;
				}
			}

			public static CameraSettings.Frustum NewDefault()
			{
				// // CameraSettings+Frustum NewDefault()
				// CameraSettings_Frustum *HG::Rendering::Runtime::CameraSettings::Frustum::NewDefault(
				//         CameraSettings_Frustum *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   __m128i *v3; // rax
				//   __m128i v4; // xmm1
				//   __m128i v5; // xmm2
				//   __m128i v6; // xmm0
				//   __int128 v7; // xmm1
				//   __int128 v8; // xmm0
				//   __int128 v9; // xmm1
				//   __int128 v10; // xmm0
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   CameraSettings_Frustum *v15; // rax
				//   __int128 v16; // xmm1
				//   __int128 v17; // xmm0
				//   __int128 v18; // xmm1
				//   __int128 v19; // xmm0
				//   CameraSettings_Frustum v20; // [rsp+20h] [rbp-A8h] BYREF
				//   char v21[72]; // [rsp+80h] [rbp-48h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3443, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3443, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v14, v13);
				//     v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1230(&v20, Patch, 0LL);
				//     v16 = *(_OWORD *)&v15.fieldOfView;
				//     *(_OWORD *)&retstr.mode = *(_OWORD *)&v15.mode;
				//     v17 = *(_OWORD *)&v15.projectionMatrix.m30;
				//     *(_OWORD *)&retstr.fieldOfView = v16;
				//     v18 = *(_OWORD *)&v15.projectionMatrix.m31;
				//     *(_OWORD *)&retstr.projectionMatrix.m30 = v17;
				//     v19 = *(_OWORD *)&v15.projectionMatrix.m32;
				//     *(float *)&v15 = v15.projectionMatrix.m33;
				//     *(_OWORD *)&retstr.projectionMatrix.m31 = v18;
				//     *(_OWORD *)&retstr.projectionMatrix.m32 = v19;
				//     LODWORD(retstr.projectionMatrix.m33) = (_DWORD)v15;
				//   }
				//   else
				//   {
				//     *(_QWORD *)&v20.mode = 0x3F80000000000000LL;
				//     *(_QWORD *)&v20.farClipPlaneRaw = 0x3DCCCCCD447A0000LL;
				//     v20.fieldOfView = 90.0;
				//     v3 = (__m128i *)sub_182805160(v21);
				//     v4 = v3[1];
				//     v5 = v3[3];
				//     *(__m128i *)&v20.projectionMatrix.m00 = *v3;
				//     v6 = v3[2];
				//     *(__m128i *)&v20.projectionMatrix.m01 = v4;
				//     v7 = *(_OWORD *)&v20.fieldOfView;
				//     *(__m128i *)&v20.projectionMatrix.m02 = v6;
				//     *(_OWORD *)&retstr.mode = *(_OWORD *)&v20.mode;
				//     v8 = *(_OWORD *)&v20.projectionMatrix.m30;
				//     *(_OWORD *)&retstr.fieldOfView = v7;
				//     v9 = *(_OWORD *)&v20.projectionMatrix.m31;
				//     *(_OWORD *)&retstr.projectionMatrix.m30 = v8;
				//     *(__m128i *)&v20.projectionMatrix.m03 = v5;
				//     v10 = *(_OWORD *)&v20.projectionMatrix.m32;
				//     *(_OWORD *)&retstr.projectionMatrix.m31 = v9;
				//     *(_OWORD *)&retstr.projectionMatrix.m32 = v10;
				//     LODWORD(retstr.projectionMatrix.m33) = _mm_cvtsi128_si32(_mm_srli_si128(v5, 12));
				//   }
				//   return retstr;
				// }
				// 
				return default(CameraSettings.Frustum);
			}

			public Matrix4x4 ComputeProjectionMatrix()
			{
				// // Matrix4x4 ComputeProjectionMatrix()
				// Matrix4x4 *HG::Rendering::Runtime::CameraSettings::Frustum::ComputeProjectionMatrix(
				//         Matrix4x4 *__return_ptr retstr,
				//         CameraSettings_Frustum *this,
				//         MethodInfo *method)
				// {
				//   float fieldOfView; // xmm6_4
				//   float v6; // xmm7_4
				//   float aspect; // xmm6_4
				//   Matrix4x4 *v8; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   __int128 v12; // xmm1
				//   __int128 v13; // xmm0
				//   __int128 v14; // xmm1
				//   Matrix4x4 *result; // rax
				//   Matrix4x4 v16; // [rsp+30h] [rbp-68h] BYREF
				// 
				//   if ( !byte_18D919748 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     byte_18D919748 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3446, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3446, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1234(&v16, Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     fieldOfView = this.fieldOfView;
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
				//     v6 = HG::Rendering::Runtime::HGUtils::ClampFOV(fieldOfView, 0LL);
				//     aspect = this.aspect;
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
				//     v8 = UnityEngine::Matrix4x4::Perspective(
				//            &v16,
				//            v6,
				//            aspect,
				//            fmaxf(0.0000099999997, this.nearClipPlaneRaw),
				//            fmaxf(this.nearClipPlaneRaw + 0.000099999997, this.farClipPlaneRaw),
				//            0LL);
				//   }
				//   v12 = *(_OWORD *)&v8.m01;
				//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v8.m00;
				//   v13 = *(_OWORD *)&v8.m02;
				//   *(_OWORD *)&retstr.m01 = v12;
				//   v14 = *(_OWORD *)&v8.m03;
				//   result = retstr;
				//   *(_OWORD *)&retstr.m02 = v13;
				//   *(_OWORD *)&retstr.m03 = v14;
				//   return result;
				// }
				// 
				return null;
			}

			public Matrix4x4 GetUsedProjectionMatrix()
			{
				// // Matrix4x4 GetUsedProjectionMatrix()
				// Matrix4x4 *HG::Rendering::Runtime::CameraSettings::Frustum::GetUsedProjectionMatrix(
				//         Matrix4x4 *__return_ptr retstr,
				//         CameraSettings_Frustum *this,
				//         MethodInfo *method)
				// {
				//   Matrix4x4 *v5; // rax
				//   __int128 v6; // xmm1
				//   __int128 v7; // xmm0
				//   __int128 v8; // xmm1
				//   __int64 v9; // rax
				//   ArgumentException *v10; // rax
				//   __int64 v11; // rdx
				//   __int64 v12; // rcx
				//   ArgumentException *v13; // rbx
				//   __int64 v14; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int128 v16; // xmm1
				//   Matrix4x4 *result; // rax
				//   Matrix4x4 v18; // [rsp+20h] [rbp-48h] BYREF
				// 
				//   if ( !byte_18D919749 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
				//     byte_18D919749 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3447, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3447, 0LL);
				//     if ( Patch )
				//     {
				//       v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1234(&v18, Patch, this, 0LL);
				//       goto LABEL_13;
				//     }
				// LABEL_11:
				//     sub_180B536AC(v12, v11);
				//   }
				//   if ( !this.mode )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
				//     v5 = HG::Rendering::Runtime::CameraSettings::Frustum::ComputeProjectionMatrix(&v18, this, 0LL);
				// LABEL_13:
				//     v16 = *(_OWORD *)&v5.m01;
				//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v5.m00;
				//     v7 = *(_OWORD *)&v5.m02;
				//     *(_OWORD *)&retstr.m01 = v16;
				//     v8 = *(_OWORD *)&v5.m03;
				//     goto LABEL_14;
				//   }
				//   if ( this.mode != 1 )
				//   {
				//     v9 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
				//     v10 = (ArgumentException *)sub_180004920(v9);
				//     v13 = v10;
				//     if ( v10 )
				//     {
				//       System::ArgumentException::ArgumentException(v10, 0LL);
				//       v14 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::CameraSettings::Frustum::GetUsedProjectionMatrix);
				//       sub_18000F7C0(v13, v14);
				//     }
				//     goto LABEL_11;
				//   }
				//   v6 = *(_OWORD *)&this.projectionMatrix.m01;
				//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&this.projectionMatrix.m00;
				//   v7 = *(_OWORD *)&this.projectionMatrix.m02;
				//   *(_OWORD *)&retstr.m01 = v6;
				//   v8 = *(_OWORD *)&this.projectionMatrix.m03;
				// LABEL_14:
				//   *(_OWORD *)&retstr.m02 = v7;
				//   result = retstr;
				//   *(_OWORD *)&retstr.m03 = v8;
				//   return result;
				// }
				// 
				return null;
			}

			public const float MinNearClipPlane = 1E-05f;

			public const float MinFarClipPlane = 0.0001f;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			[Obsolete("Since 2019.3, use Frustum.NewDefault() instead.")]
			public static readonly CameraSettings.Frustum @default;

			public CameraSettings.Frustum.Mode mode;

			public float aspect;

			[FormerlySerializedAs("farClipPlane")]
			public float farClipPlaneRaw;

			[FormerlySerializedAs("nearClipPlane")]
			public float nearClipPlaneRaw;

			[Range(1f, 179f)]
			public float fieldOfView;

			public Matrix4x4 projectionMatrix;

			public enum Mode
			{
				ComputeProjectionMatrix,
				UseProjectionMatrixField
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct Culling
		{
			public static CameraSettings.Culling NewDefault()
			{
				// // CameraSettings+Culling NewDefault()
				// CameraSettings_Culling *HG::Rendering::Runtime::CameraSettings::Culling::NewDefault(
				//         CameraSettings_Culling *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   CameraSettings_Culling v3; // xmm0
				//   CameraSettings_Culling *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   CameraSettings_Culling v8; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3442, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3442, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     v3 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1229(&v8, Patch, 0LL);
				//   }
				//   else
				//   {
				//     v8 = (CameraSettings_Culling)0xFFFFFFFF00000001uLL;
				//     v3 = (CameraSettings_Culling)0xFFFFFFFF00000001uLL;
				//   }
				//   result = retstr;
				//   *retstr = v3;
				//   return result;
				// }
				// 
				return default(CameraSettings.Culling);
			}

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			[Obsolete("Since 2019.3, use Culling.NewDefault() instead.")]
			public static readonly CameraSettings.Culling @default;

			public bool useOcclusionCulling;

			public LayerMask cullingMask;

			public ulong sceneCullingMaskOverride;
		}
	}
}
