using System;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGCelestialConfig : IEnvConfig
	{
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_isEditorCameraPreview()
				// bool HG::Rendering::Runtime::HGAdditionalCameraData::get_isEditorCameraPreview(
				//         HGAdditionalCameraData *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isEditorCameraPreview_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_isEditorCameraPreview(Boolean)
				// void HG::Rendering::Runtime::HGAdditionalCameraData::set_isEditorCameraPreview(
				//         HGAdditionalCameraData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._isEditorCameraPreview_k__BackingField = value;
				// }
				// 
			}
		}

		public HGCelestialConfig(bool active)
		{
			// // HGCelestialConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialConfig(
			//         HGCelestialConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   struct HGCelestialConfig_HGCelestialObjectConfig__Class *v5; // rax
			//   _OWORD *p_radius; // rax
			//   __int128 v7; // xmm1
			//   __int128 v8; // xmm2
			//   __int128 v9; // xmm3
			//   OneofDescriptorProto *v10; // rdx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   struct HGCelestialConfig_HGCelestialAtmosphereObjectConfig__Class *v13; // rax
			//   HGCelestialConfig_HGCelestialAtmosphereObjectConfig__StaticFields *static_fields; // rax
			//   __int128 v15; // xmm2
			//   __int128 v16; // xmm3
			//   __int128 v17; // xmm4
			//   __int128 v18; // xmm5
			//   __int128 v19; // xmm6
			//   __int128 v20; // xmm7
			//   __int128 v21; // xmm8
			//   __int64 v22; // xmm0_8
			//   MessageDescriptor *v23; // r9
			//   HGCelestialConfig_HGCelestialAtmosphereObjectConfig__StaticFields *v24; // rax
			//   __int128 v25; // xmm2
			//   __int128 v26; // xmm3
			//   __int128 v27; // xmm4
			//   __int128 v28; // xmm5
			//   __int128 v29; // xmm6
			//   __int128 v30; // xmm7
			//   __int128 v31; // xmm8
			//   __int64 v32; // xmm0_8
			//   OneofDescriptorProto *v33; // rdx
			//   FileDescriptor *v34; // r8
			//   OneofDescriptorProto *v35; // rdx
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   struct HGCelestialConfig_HGCelestialAdvancedObjectConfig__Class *v38; // rax
			//   String__Array *v39; // [rsp+20h] [rbp-38h]
			//   String__Array *v40; // [rsp+20h] [rbp-38h]
			//   String__Array *v41; // [rsp+20h] [rbp-38h]
			//   String *v42; // [rsp+28h] [rbp-30h]
			//   String *v43; // [rsp+28h] [rbp-30h]
			//   String *v44; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v45; // [rsp+30h] [rbp-28h]
			//   MethodInfo *v46; // [rsp+30h] [rbp-28h]
			//   MethodInfo *v47; // [rsp+30h] [rbp-28h]
			//   String__Array *v48; // [rsp+80h] [rbp+28h]
			//   String *v49; // [rsp+88h] [rbp+30h]
			//   MethodInfo *v50; // [rsp+90h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDC03 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig);
			//     byte_18D8EDC03 = 1;
			//   }
			//   this.m_active = 0;
			//   v5 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig, active);
			//     v5 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig;
			//   }
			//   p_radius = (_OWORD *)&v5.static_fields.defaultConfig.radius;
			//   v7 = p_radius[1];
			//   v8 = p_radius[2];
			//   v9 = p_radius[3];
			//   *(_OWORD *)&this.moonConfig.radius = *p_radius;
			//   *(_OWORD *)&this.moonConfig.worldLongitude = v7;
			//   *(_OWORD *)&this.moonConfig.ring.outerRadius = v8;
			//   *(_OWORD *)&this.moonConfig.ring.ringColor.b = v9;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.moonConfig.ring.planetRingMap,
			//     (OneofDescriptorProto *)active,
			//     (FileDescriptor *)method,
			//     v3,
			//     v39,
			//     v42,
			//     v45);
			//   v13 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig,
			//       v10);
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig;
			//   }
			//   static_fields = v13.static_fields;
			//   v15 = *(_OWORD *)&static_fields.defaultConfig.objectProperty.selfTiltZ;
			//   v16 = *(_OWORD *)&static_fields.defaultConfig.skydomeDrawer.drawMaterial;
			//   v17 = *(_OWORD *)&static_fields.defaultConfig.skydomeDrawer.incidentLightingPitchYaw.x;
			//   v18 = *(_OWORD *)&static_fields.defaultConfig.ring.outerRadius;
			//   v19 = *(_OWORD *)&static_fields.defaultConfig.ring.ringColor.b;
			//   v20 = *(_OWORD *)&static_fields.defaultConfig.enableAtmosphere;
			//   v21 = *(_OWORD *)&static_fields.defaultConfig.atmosphere.numOpticalDepthSamplePoints;
			//   v22 = *(_QWORD *)&static_fields.defaultConfig.atmosphere.atmosphereHueshift;
			//   *(_OWORD *)&this.talosAlphaConfig.drawPlanetInSkydome = *(_OWORD *)&static_fields.defaultConfig.drawPlanetInSkydome;
			//   *(_OWORD *)&this.talosAlphaConfig.objectProperty.selfTiltZ = v15;
			//   *(_OWORD *)&this.talosAlphaConfig.skydomeDrawer.drawMaterial = v16;
			//   *(_OWORD *)&this.talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x = v17;
			//   *(_OWORD *)&this.talosAlphaConfig.ring.outerRadius = v18;
			//   *(_OWORD *)&this.talosAlphaConfig.ring.ringColor.b = v19;
			//   *(_OWORD *)&this.talosAlphaConfig.enableAtmosphere = v20;
			//   *(_OWORD *)&this.talosAlphaConfig.atmosphere.numOpticalDepthSamplePoints = v21;
			//   *(_QWORD *)&this.talosAlphaConfig.atmosphere.atmosphereHueshift = v22;
			//   sub_1800054D0((OneofDescriptor *)&this.talosAlphaConfig.skydomeDrawer.drawMaterial, v10, v11, v12, v40, v43, v46);
			//   v23 = (MessageDescriptor *)TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig;
			//   v24 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig.static_fields;
			//   v25 = *(_OWORD *)&v24.defaultConfig.objectProperty.selfTiltZ;
			//   v26 = *(_OWORD *)&v24.defaultConfig.skydomeDrawer.drawMaterial;
			//   v27 = *(_OWORD *)&v24.defaultConfig.skydomeDrawer.incidentLightingPitchYaw.x;
			//   v28 = *(_OWORD *)&v24.defaultConfig.ring.outerRadius;
			//   v29 = *(_OWORD *)&v24.defaultConfig.ring.ringColor.b;
			//   v30 = *(_OWORD *)&v24.defaultConfig.enableAtmosphere;
			//   v31 = *(_OWORD *)&v24.defaultConfig.atmosphere.numOpticalDepthSamplePoints;
			//   v32 = *(_QWORD *)&v24.defaultConfig.atmosphere.atmosphereHueshift;
			//   *(_OWORD *)&this.planetConfig.drawPlanetInSkydome = *(_OWORD *)&v24.defaultConfig.drawPlanetInSkydome;
			//   *(_OWORD *)&this.planetConfig.objectProperty.selfTiltZ = v25;
			//   *(_OWORD *)&this.planetConfig.skydomeDrawer.drawMaterial = v26;
			//   *(_OWORD *)&this.planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v27;
			//   *(_OWORD *)&this.planetConfig.ring.outerRadius = v28;
			//   *(_OWORD *)&this.planetConfig.ring.ringColor.b = v29;
			//   *(_OWORD *)&this.planetConfig.enableAtmosphere = v30;
			//   *(_OWORD *)&this.planetConfig.atmosphere.numOpticalDepthSamplePoints = v31;
			//   *(_QWORD *)&this.planetConfig.atmosphere.atmosphereHueshift = v32;
			//   sub_1800054D0((OneofDescriptor *)&this.planetConfig.skydomeDrawer.drawMaterial, v33, v34, v23, v41, v44, v47);
			//   v38 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig,
			//       v35);
			//     v38 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig;
			//   }
			//   this.advancedPlanetConfig = v38.static_fields.defaultConfig;
			//   sub_1800054D0((OneofDescriptor *)&this.advancedPlanetConfig.advancedPlanetMat, v35, v36, v37, v48, v49, v50);
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		private static float PercentageDeg(float deg)
		{
			// // Single PercentageDeg(Single)
			// float HG::Rendering::Runtime::HGCelestialConfig::PercentageDeg(float deg, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1180, 0LL) )
			//     return deg * 0.011111111;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1180, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, deg, 0LL);
			// }
			// 
			return 0f;
		}

		public void GetMapWorldSpaceBasisInPlanetSpace(out Vector3 up, out Vector3 forward, out Vector3 right)
		{
			// // Void GetMapWorldSpaceBasisInPlanetSpace(Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
			// void HG::Rendering::Runtime::HGCelestialConfig::GetMapWorldSpaceBasisInPlanetSpace(
			//         HGCelestialConfig *this,
			//         Vector3 *up,
			//         Vector3 *forward,
			//         Vector3 *right,
			//         MethodInfo *method)
			// {
			//   float worldLatitude; // xmm6_4
			//   MethodInfo *v10; // rdx
			//   Vector3 *v11; // rax
			//   __int64 v12; // xmm3_8
			//   double v13; // xmm0_8
			//   MethodInfo *v14; // r9
			//   Vector3 *v15; // rax
			//   __int64 v16; // xmm6_8
			//   float z; // ebx
			//   MethodInfo *v18; // rdx
			//   Vector3 *v19; // rax
			//   float worldLongitude; // xmm1_4
			//   __int64 v21; // xmm3_8
			//   MethodInfo *v22; // rax
			//   Vector3 *fwd; // rax
			//   Quaternion *v24; // rdx
			//   Quaternion v25; // xmm1
			//   __int64 v26; // xmm3_8
			//   Vector3 *v27; // rax
			//   double v28; // xmm0_8
			//   MethodInfo *v29; // r9
			//   Vector3 *v30; // rax
			//   __int64 v31; // xmm3_8
			//   MethodInfo *v32; // r9
			//   Vector3 *v33; // rax
			//   __int64 v34; // xmm3_8
			//   __int64 v35; // rax
			//   __int64 v36; // xmm3_8
			//   MethodInfo *v37; // rdx
			//   Vector3 *v38; // rax
			//   __int64 v39; // xmm0_8
			//   float v40; // edx
			//   MethodInfo *v41; // r9
			//   Vector3 *v42; // rax
			//   __int64 v43; // xmm4_8
			//   __int64 v44; // rax
			//   __int64 v45; // xmm0_8
			//   MethodInfo *v46; // r8
			//   Vector3 *v47; // rax
			//   float v48; // ecx
			//   __int64 v49; // xmm0_8
			//   MethodInfo *v50; // r9
			//   Vector3 *v51; // rax
			//   __int64 v52; // xmm4_8
			//   __int64 v53; // rax
			//   __int64 v54; // xmm0_8
			//   MethodInfo *v55; // r8
			//   Vector3 *v56; // rax
			//   float v57; // ecx
			//   Quaternion *v58; // rax
			//   float v59; // ecx
			//   Quaternion v60; // xmm0
			//   Vector3 *v61; // rax
			//   float v62; // ecx
			//   Quaternion *v63; // rax
			//   float v64; // ecx
			//   Quaternion v65; // xmm0
			//   Vector3 *v66; // rax
			//   float v67; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v69; // rdx
			//   __int64 v70; // rcx
			//   Vector3 v71; // [rsp+38h] [rbp-21h] BYREF
			//   Vector3 v72; // [rsp+48h] [rbp-11h] BYREF
			//   Quaternion v73; // [rsp+58h] [rbp-1h] BYREF
			//   Quaternion v74; // [rsp+68h] [rbp+Fh] BYREF
			// 
			//   if ( !byte_18D919CF6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     byte_18D919CF6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1181, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1181, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v70, v69);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_441(Patch, this, up, forward, right, 0LL);
			//   }
			//   else
			//   {
			//     worldLatitude = this.moonConfig.worldLatitude;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     HG::Rendering::Runtime::HGCelestialConfig::PercentageDeg(worldLatitude, 0LL);
			//     v11 = UnityEngine::Vector3::get_up((Vector3 *)&v73, v10);
			//     v12 = *(_QWORD *)&v11.x;
			//     *(float *)&v11 = v11.z;
			//     *(_QWORD *)&v71.x = v12;
			//     LODWORD(v71.z) = (_DWORD)v11;
			//     v13 = Beyond::DampingMath::cosf();
			//     v15 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v73, &v71, *(float *)&v13, v14);
			//     v16 = *(_QWORD *)&v15.x;
			//     z = v15.z;
			//     v19 = UnityEngine::Vector3::get_up((Vector3 *)&v73, v18);
			//     worldLongitude = this.moonConfig.worldLongitude;
			//     v21 = *(_QWORD *)&v19.x;
			//     *(float *)&v19 = v19.z;
			//     *(_QWORD *)&v71.x = v21;
			//     LODWORD(v71.z) = (_DWORD)v19;
			//     v22 = (MethodInfo *)UnityEngine::Quaternion::AngleAxis(&v74, worldLongitude, &v71, 0LL);
			//     fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v73, v22);
			//     v25 = *v24;
			//     v26 = *(_QWORD *)&fwd.x;
			//     v72.z = fwd.z;
			//     *(_QWORD *)&v72.x = v26;
			//     v74 = v25;
			//     v27 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v73, &v74, &v72, 0LL);
			//     *(_QWORD *)&v25.x = *(_QWORD *)&v27.x;
			//     *(float *)&v27 = v27.z;
			//     *(_QWORD *)&v72.x = *(_QWORD *)&v25.x;
			//     LODWORD(v72.z) = (_DWORD)v27;
			//     v28 = Beyond::DampingMath::sinf();
			//     v30 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v73, &v72, *(float *)&v28, v29);
			//     *(_QWORD *)&v71.x = v16;
			//     v71.z = z;
			//     v31 = *(_QWORD *)&v30.x;
			//     *(float *)&v30 = v30.z;
			//     *(_QWORD *)&v72.x = v31;
			//     LODWORD(v72.z) = (_DWORD)v30;
			//     v33 = UnityEngine::Vector3::op_Addition((Vector3 *)&v73, &v71, &v72, v32);
			//     v34 = *(_QWORD *)&v33.x;
			//     *(float *)&v33 = v33.z;
			//     *(_QWORD *)&v72.x = v34;
			//     LODWORD(v72.z) = (_DWORD)v33;
			//     v35 = sub_182413460(&v73, &v72);
			//     v36 = *(_QWORD *)v35;
			//     v37 = (MethodInfo *)*(unsigned int *)(v35 + 8);
			//     *(_QWORD *)&up.x = *(_QWORD *)v35;
			//     LODWORD(up.z) = (_DWORD)v37;
			//     v38 = UnityEngine::Vector3::get_up((Vector3 *)&v73, v37);
			//     v39 = *(_QWORD *)&v38.x;
			//     *(float *)&v38 = v38.z;
			//     v72.z = v40;
			//     *(_QWORD *)&v71.x = v39;
			//     LODWORD(v71.z) = (_DWORD)v38;
			//     *(_QWORD *)&v72.x = v36;
			//     v42 = UnityEngine::Vector3::Cross((Vector3 *)&v73, &v71, &v72, v41);
			//     v43 = *(_QWORD *)&v42.x;
			//     *(float *)&v42 = v42.z;
			//     *(_QWORD *)&v71.x = v43;
			//     LODWORD(v71.z) = (_DWORD)v42;
			//     v44 = sub_182413270(&v73, &v71);
			//     v45 = *(_QWORD *)v44;
			//     LODWORD(v44) = *(_DWORD *)(v44 + 8);
			//     *(_QWORD *)&v72.x = v45;
			//     LODWORD(v72.z) = v44;
			//     v47 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v73, &v72, v46);
			//     v48 = v47.z;
			//     *(_QWORD *)&v25.x = *(_QWORD *)&v47.x;
			//     *(_QWORD *)&right.x = *(_QWORD *)&v47.x;
			//     right.z = v48;
			//     v49 = *(_QWORD *)&up.x;
			//     *(float *)&v47 = up.z;
			//     v72.z = v48;
			//     *(_QWORD *)&v73.x = v49;
			//     *(_QWORD *)&v72.x = *(_QWORD *)&v25.x;
			//     LODWORD(v73.z) = (_DWORD)v47;
			//     v51 = UnityEngine::Vector3::Cross((Vector3 *)&v74, (Vector3 *)&v73, &v72, v50);
			//     v52 = *(_QWORD *)&v51.x;
			//     *(float *)&v51 = v51.z;
			//     *(_QWORD *)&v71.x = v52;
			//     LODWORD(v71.z) = (_DWORD)v51;
			//     v53 = sub_182413270(&v74, &v71);
			//     v54 = *(_QWORD *)v53;
			//     LODWORD(v53) = *(_DWORD *)(v53 + 8);
			//     *(_QWORD *)&v73.x = v54;
			//     LODWORD(v73.z) = v53;
			//     v56 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v74, (Vector3 *)&v73, v55);
			//     v57 = v56.z;
			//     *(_QWORD *)&forward.x = *(_QWORD *)&v56.x;
			//     forward.z = v57;
			//     *(float *)&v56 = up.z;
			//     v25.x = this.moonConfig.rotationAroundUp;
			//     *(_QWORD *)&v73.x = *(_QWORD *)&up.x;
			//     LODWORD(v73.z) = (_DWORD)v56;
			//     v58 = UnityEngine::Quaternion::AngleAxis(&v74, v25.x, (Vector3 *)&v73, 0LL);
			//     v59 = right.z;
			//     *(_QWORD *)&v72.x = *(_QWORD *)&right.x;
			//     v60 = *v58;
			//     v72.z = v59;
			//     v73 = v60;
			//     v61 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v74, &v73, &v72, 0LL);
			//     v62 = v61.z;
			//     *(_QWORD *)&right.x = *(_QWORD *)&v61.x;
			//     right.z = v62;
			//     *(_QWORD *)&v60.x = *(_QWORD *)&up.x;
			//     v25.x = this.moonConfig.rotationAroundUp;
			//     v73.z = up.z;
			//     *(_QWORD *)&v73.x = *(_QWORD *)&v60.x;
			//     v63 = UnityEngine::Quaternion::AngleAxis(&v74, v25.x, (Vector3 *)&v73, 0LL);
			//     v64 = forward.z;
			//     *(_QWORD *)&v72.x = *(_QWORD *)&forward.x;
			//     v65 = *v63;
			//     v72.z = v64;
			//     v73 = v65;
			//     v66 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v74, &v73, &v72, 0LL);
			//     v67 = v66.z;
			//     *(_QWORD *)&forward.x = *(_QWORD *)&v66.x;
			//     forward.z = v67;
			//   }
			// }
			// 
		}

		[IDTag(0)]
		public static void CreateBasisFromRotation(Vector3 angRotation, in Vector3 up, in Vector3 right, in Vector3 forward, out Vector3 outUp, out Vector3 outRight, out Vector3 outForward)
		{
			// // Void CreateBasisFromRotation(Vector3, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
			// void HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
			//         Vector3 *angRotation,
			//         Vector3 *up,
			//         Vector3 *right,
			//         Vector3 *forward,
			//         Vector3 *outUp,
			//         Vector3 *outRight,
			//         Vector3 *outForward,
			//         MethodInfo *method)
			// {
			//   Quaternion *v12; // rax
			//   float z; // ecx
			//   Quaternion v14; // xmm0
			//   Vector3 *v15; // rax
			//   float v16; // ecx
			//   Quaternion *v17; // rax
			//   float v18; // ecx
			//   Quaternion v19; // xmm0
			//   Vector3 *v20; // rax
			//   float v21; // ecx
			//   Quaternion *v22; // rax
			//   float v23; // ecx
			//   Quaternion v24; // xmm0
			//   Vector3 *v25; // rax
			//   float y; // xmm1_4
			//   float v27; // ecx
			//   Quaternion *v28; // rax
			//   float v29; // ecx
			//   Quaternion v30; // xmm0
			//   Vector3 *v31; // rax
			//   float v32; // xmm1_4
			//   float v33; // ecx
			//   Quaternion *v34; // rax
			//   float v35; // ecx
			//   Quaternion v36; // xmm0
			//   Vector3 *v37; // rax
			//   float v38; // ecx
			//   __int64 v39; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v41; // xmm0_8
			//   Vector3 v42; // [rsp+50h] [rbp-30h] BYREF
			//   Vector3 v43; // [rsp+60h] [rbp-20h] BYREF
			//   Quaternion v44; // [rsp+70h] [rbp-10h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1182, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1182, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v39);
			//     v41 = *(_QWORD *)&angRotation.x;
			//     v43.z = angRotation.z;
			//     *(_QWORD *)&v43.x = v41;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_442(Patch, &v43, up, right, forward, outUp, outRight, outForward, 0LL);
			//   }
			//   else
			//   {
			//     v12 = (Quaternion *)sub_182504D40(&v44);
			//     z = up.z;
			//     *(_QWORD *)&v42.x = *(_QWORD *)&up.x;
			//     v14 = *v12;
			//     v42.z = z;
			//     v44 = v14;
			//     v15 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
			//     v16 = v15.z;
			//     *(_QWORD *)&outUp.x = *(_QWORD *)&v15.x;
			//     outUp.z = v16;
			//     v17 = (Quaternion *)sub_182504D40(&v44);
			//     v18 = right.z;
			//     *(_QWORD *)&v42.x = *(_QWORD *)&right.x;
			//     v19 = *v17;
			//     v42.z = v18;
			//     v44 = v19;
			//     v20 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
			//     v21 = v20.z;
			//     *(_QWORD *)&outRight.x = *(_QWORD *)&v20.x;
			//     outRight.z = v21;
			//     v22 = (Quaternion *)sub_182504D40(&v44);
			//     v23 = forward.z;
			//     *(_QWORD *)&v42.x = *(_QWORD *)&forward.x;
			//     v24 = *v22;
			//     v42.z = v23;
			//     v44 = v24;
			//     v25 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
			//     y = angRotation.y;
			//     v27 = v25.z;
			//     *(_QWORD *)&outForward.x = *(_QWORD *)&v25.x;
			//     outForward.z = v27;
			//     *(float *)&v25 = outUp.z;
			//     *(_QWORD *)&v42.x = *(_QWORD *)&outUp.x;
			//     LODWORD(v42.z) = (_DWORD)v25;
			//     v28 = UnityEngine::Quaternion::AngleAxis(&v44, y, &v42, 0LL);
			//     v29 = outRight.z;
			//     *(_QWORD *)&v43.x = *(_QWORD *)&outRight.x;
			//     v30 = *v28;
			//     v43.z = v29;
			//     v44 = v30;
			//     v31 = UnityEngine::Quaternion::op_Multiply(&v42, &v44, &v43, 0LL);
			//     v32 = angRotation.y;
			//     v33 = v31.z;
			//     *(_QWORD *)&outRight.x = *(_QWORD *)&v31.x;
			//     outRight.z = v33;
			//     *(float *)&v31 = outUp.z;
			//     *(_QWORD *)&v43.x = *(_QWORD *)&outUp.x;
			//     LODWORD(v43.z) = (_DWORD)v31;
			//     v34 = UnityEngine::Quaternion::AngleAxis(&v44, v32, &v43, 0LL);
			//     v35 = outForward.z;
			//     *(_QWORD *)&v42.x = *(_QWORD *)&outForward.x;
			//     v36 = *v34;
			//     v42.z = v35;
			//     v44 = v36;
			//     v37 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
			//     v38 = v37.z;
			//     *(_QWORD *)&outForward.x = *(_QWORD *)&v37.x;
			//     outForward.z = v38;
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public static void CreateBasisFromRotation(Vector3 angRotation, out Vector3 outUp, out Vector3 outRight, out Vector3 outForward)
		{
			// // Void CreateBasisFromRotation(Vector3, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
			// void HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
			//         Vector3 *angRotation,
			//         Vector3 *outUp,
			//         Vector3 *outRight,
			//         Vector3 *outForward,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v9; // rdx
			//   Vector3 *up; // rax
			//   __int64 v11; // xmm3_8
			//   MethodInfo *v12; // rdx
			//   Vector3 *right; // rax
			//   __int64 v14; // xmm1_8
			//   MethodInfo *v15; // rdx
			//   Vector3 *fwd; // rax
			//   __int64 v17; // xmm3_8
			//   float v18; // eax
			//   __int64 v19; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v22; // [rsp+40h] [rbp-40h] BYREF
			//   Vector3 v23; // [rsp+50h] [rbp-30h] BYREF
			//   Vector3 v24; // [rsp+60h] [rbp-20h] BYREF
			//   Vector3 v25; // [rsp+70h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919CF7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     byte_18D919CF7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1183, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1183, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v19);
			//     z = angRotation.z;
			//     *(_QWORD *)&v25.x = *(_QWORD *)&angRotation.x;
			//     v25.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_443(Patch, &v25, outUp, outRight, outForward, 0LL);
			//   }
			//   else
			//   {
			//     up = UnityEngine::Vector3::get_up(&v25, v9);
			//     v11 = *(_QWORD *)&up.x;
			//     *(float *)&up = up.z;
			//     *(_QWORD *)&v24.x = v11;
			//     LODWORD(v24.z) = (_DWORD)up;
			//     right = UnityEngine::Vector3::get_right(&v25, v12);
			//     v14 = *(_QWORD *)&right.x;
			//     *(float *)&right = right.z;
			//     *(_QWORD *)&v23.x = v14;
			//     LODWORD(v23.z) = (_DWORD)right;
			//     fwd = UnityEngine::Vector3::get_fwd(&v25, v15);
			//     v17 = *(_QWORD *)&fwd.x;
			//     *(float *)&fwd = fwd.z;
			//     *(_QWORD *)&v22.x = v17;
			//     LODWORD(v22.z) = (_DWORD)fwd;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
			//     v18 = angRotation.z;
			//     *(_QWORD *)&v25.x = *(_QWORD *)&angRotation.x;
			//     v25.z = v18;
			//     HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
			//       &v25,
			//       &v24,
			//       &v23,
			//       &v22,
			//       outUp,
			//       outRight,
			//       outForward,
			//       0LL);
			//   }
			// }
			// 
		}

		public HGCelestialConfig.HGCelestialObjectConfig moonConfig;

		public HGCelestialConfig.HGCelestialAtmosphereObjectConfig talosAlphaConfig;

		[Space(5f)]
		public HGCelestialConfig.HGCelestialAtmosphereObjectConfig planetConfig;

		[Space(5f)]
		public HGCelestialConfig.HGCelestialAdvancedObjectConfig advancedPlanetConfig;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGCelestialConfig defaultConfig;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct HGCelestialAtmosphereObjectConfig : IEnvConfig
		{
			// (get) Token: 0x06000509 RID: 1289 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x0600050A RID: 1290 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public HGCelestialAtmosphereObjectConfig(bool active)
			{
				// // HGCelestialConfig+HGCelestialAtmosphereObjectConfig(Boolean)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig::HGCelestialAtmosphereObjectConfig(
				//         HGCelestialConfig_HGCelestialAtmosphereObjectConfig *this,
				//         bool active,
				//         MethodInfo *method)
				// {
				//   __m128i v3; // xmm1
				//   __int64 v4; // r9
				//   OneofDescriptorProto *v5; // rdx
				//   FileDescriptor *v6; // r8
				//   __int64 v7; // r9
				//   char v8; // r10
				//   MethodInfo *v9; // rdx
				//   Vector4 v10; // xmm1
				//   __int64 v11; // r10
				//   OneofDescriptorProto *v12; // rdx
				//   FileDescriptor *v13; // r8
				//   MessageDescriptor *v14; // r9
				//   __int128 v15; // xmm1
				//   __int64 v16; // r9
				//   OneofDescriptorProto *v17; // rdx
				//   FileDescriptor *v18; // r8
				//   __m128i v19; // xmm1
				//   int v20; // r10d
				//   __int128 v21; // xmm0
				//   __int64 v22; // r9
				//   HGCelestialConfig_CelestialObjectProperty v23; // [rsp+20h] [rbp-50h] BYREF
				//   __m256i v24; // [rsp+30h] [rbp-40h] BYREF
				//   __int128 v25; // [rsp+50h] [rbp-20h] BYREF
				//   __m128i si128; // [rsp+60h] [rbp-10h]
				// 
				//   this.drawPlanetInSkydome = 0;
				//   v23 = 0LL;
				//   this.drawPlanetBelowHorizon = 1.0;
				//   v23.radius = 5600.0;
				//   v25 = 1uLL;
				//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A357C30);
				//   this.objectProperty = v23;
				//   sub_1800054D0(
				//     (OneofDescriptor *)((char *)&v25 + 8),
				//     (OneofDescriptorProto *)active,
				//     (FileDescriptor *)method,
				//     (MessageDescriptor *)this,
				//     *(String__Array **)&v23.radius,
				//     *(String **)&v23.selfTiltZ,
				//     (MethodInfo *)v24.m256i_i64[0]);
				//   v3 = si128;
				//   *(_OWORD *)(v4 + 24) = v25;
				//   *(__m128i *)(v4 + 40) = v3;
				//   sub_1800054D0(
				//     (OneofDescriptor *)(v4 + 32),
				//     v5,
				//     v6,
				//     (MessageDescriptor *)v4,
				//     *(String__Array **)&v23.radius,
				//     *(String **)&v23.selfTiltZ,
				//     (MethodInfo *)v24.m256i_i64[0]);
				//   *(_BYTE *)(v7 + 56) = v8;
				//   v24.m256i_i64[0] = 0x453B8000461C4000LL;
				//   *(_OWORD *)&v24.m256i_u64[1] = 0LL;
				//   v10 = *UnityEngine::Vector4::get_one((Vector4 *)&v23, v9);
				//   v24.m256i_i64[3] = v11;
				//   *(Vector4 *)&v24.m256i_u64[1] = v10;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&v24.m256i_u64[3],
				//     v12,
				//     v13,
				//     v14,
				//     *(String__Array **)&v23.radius,
				//     *(String **)&v23.selfTiltZ,
				//     (MethodInfo *)v24.m256i_i64[0]);
				//   v15 = *(_OWORD *)&v24.m256i_u64[2];
				//   *(_OWORD *)(v16 + 64) = *(_OWORD *)v24.m256i_i8;
				//   *(_OWORD *)(v16 + 80) = v15;
				//   sub_1800054D0(
				//     (OneofDescriptor *)(v16 + 88),
				//     v17,
				//     v18,
				//     (MessageDescriptor *)v16,
				//     *(String__Array **)&v23.radius,
				//     *(String **)&v23.selfTiltZ,
				//     (MethodInfo *)v24.m256i_i64[0]);
				//   v19 = _mm_load_si128((const __m128i *)&xmmword_18A357C40);
				//   LODWORD(v25) = v20;
				//   *(_QWORD *)((char *)&v25 + 4) = 0x6443A00000LL;
				//   HIDWORD(v25) = 50;
				//   v21 = v25;
				//   *(_BYTE *)(v22 + 96) = v20;
				//   *(_OWORD *)(v22 + 100) = v21;
				//   *(__m128i *)(v22 + 116) = v19;
				// }
				// 
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Header("是否在天空中绘制")]
			public bool drawPlanetInSkydome;

			[UnclampedRange(0f, 1f)]
			[Header("地平线下元素不可见度")]
			public float drawPlanetBelowHorizon;

			[FormerlySerializedAs("celestialProperty")]
			[Header("星球自身属性")]
			public HGCelestialConfig.CelestialObjectProperty objectProperty;

			[Header("绘制属性")]
			public HGCelestialConfig.CelestialDrawer skydomeDrawer;

			[FormerlySerializedAs("enableRing")]
			[Header("光环设定")]
			public bool enableRing;

			public HGCelestialConfig.RingProperty ring;

			[Header("开启星球大气散射")]
			public bool enableAtmosphere;

			[Header("大气散射属性")]
			public HGCelestialConfig.AtmosphereProperty atmosphere;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static HGCelestialConfig.HGCelestialAtmosphereObjectConfig defaultConfig;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct HGCelestialObjectConfig : IEnvConfig
		{
			// (get) Token: 0x0600050E RID: 1294 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x0600050F RID: 1295 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public HGCelestialObjectConfig(bool active)
			{
				// // HGCelestialConfig+HGCelestialObjectConfig(Boolean)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig::HGCelestialObjectConfig(
				//         HGCelestialConfig_HGCelestialObjectConfig *this,
				//         bool active,
				//         MethodInfo *method)
				// {
				//   Vector4 v3; // xmm1
				//   OneofDescriptorProto *v4; // rdx
				//   FileDescriptor *v5; // r8
				//   MessageDescriptor *v6; // r9
				//   __int128 v7; // xmm1
				//   __int64 v8; // r9
				//   OneofDescriptorProto *v9; // rdx
				//   FileDescriptor *v10; // r8
				//   Vector4 v11; // [rsp+20h] [rbp-38h] BYREF
				//   __m256i v12; // [rsp+30h] [rbp-28h] BYREF
				// 
				//   this.radius = 5600.0;
				//   this.orbitRadius = 185000.0;
				//   this.enableRing = 0;
				//   *(_QWORD *)&this.drawPlanetBelowHorizon = 1065353216LL;
				//   *(_QWORD *)&this.worldLatitude = 1110704128LL;
				//   *(_OWORD *)&v12.m256i_u64[1] = 0LL;
				//   v12.m256i_i64[0] = 0x453B8000461C4000LL;
				//   v3 = *UnityEngine::Vector4::get_one(&v11, 0LL);
				//   v12.m256i_i64[3] = (__int64)v4;
				//   *(Vector4 *)&v12.m256i_u64[1] = v3;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&v12.m256i_u64[3],
				//     v4,
				//     v5,
				//     v6,
				//     *(String__Array **)&v11.x,
				//     *(String **)&v11.z,
				//     (MethodInfo *)v12.m256i_i64[0]);
				//   v7 = *(_OWORD *)&v12.m256i_u64[2];
				//   *(_OWORD *)(v8 + 32) = *(_OWORD *)v12.m256i_i8;
				//   *(_OWORD *)(v8 + 48) = v7;
				//   sub_1800054D0(
				//     (OneofDescriptor *)(v8 + 56),
				//     v9,
				//     v10,
				//     (MessageDescriptor *)v8,
				//     *(String__Array **)&v11.x,
				//     *(String **)&v11.z,
				//     (MethodInfo *)v12.m256i_i64[0]);
				// }
				// 
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Range(1f, 79000f)]
			[Header("天体半径")]
			[FormerlySerializedAs("objectProperty.radius")]
			public float radius;

			[FormerlySerializedAs("orbit.radius")]
			[Header("轨道半径")]
			public float orbitRadius;

			[FormerlySerializedAs("enableRing")]
			[Header("光环设定")]
			public bool enableRing;

			[Header("地平线下星环不可见度")]
			[UnclampedRange(0f, 1f)]
			public float drawPlanetBelowHorizon;

			[Header("本地图所处经度")]
			[FormerlySerializedAs("HGCelestialConfig.worldLongitude")]
			[Range(0f, 360f)]
			public float worldLongitude;

			[FormerlySerializedAs("HGCelestialConfig.worldLatitude")]
			[Header("本地图所处纬度")]
			[Range(-90f, 90f)]
			public float worldLatitude;

			[Range(0f, 360f)]
			[Header("塔卫二绕 Y 轴旋转角度")]
			[FormerlySerializedAs("HGCelestialConfig.rotationAroundUp")]
			public float rotationAroundUp;

			public HGCelestialConfig.RingProperty ring;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static HGCelestialConfig.HGCelestialObjectConfig defaultConfig;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct HGCelestialAdvancedObjectConfig : IEnvConfig
		{
			// (get) Token: 0x06000513 RID: 1299 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x06000514 RID: 1300 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public HGCelestialAdvancedObjectConfig(bool active)
			{
				// // HGCelestialConfig+HGCelestialAdvancedObjectConfig(Boolean)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::HGCelestialAdvancedObjectConfig(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         bool active,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.drawAdvancedPlanet = 0;
				//   this.advancedPlanetMat = 0LL;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.advancedPlanetMat,
				//     (OneofDescriptorProto *)active,
				//     (FileDescriptor *)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Header("绘制一个高精度星球")]
			public bool drawAdvancedPlanet;

			[Header("高精度星球材质")]
			public Material advancedPlanetMat;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static HGCelestialConfig.HGCelestialAdvancedObjectConfig defaultConfig;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct CelestialObjectProperty : IEnvConfig
		{
			// (get) Token: 0x06000518 RID: 1304 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x06000519 RID: 1305 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public CelestialObjectProperty(bool active)
			{
				// // HGCelestialConfig+CelestialObjectProperty(Boolean)
				// void HG::Rendering::Runtime::HGCelestialConfig::CelestialObjectProperty::CelestialObjectProperty(
				//         HGCelestialConfig_CelestialObjectProperty *this,
				//         bool active,
				//         MethodInfo *method)
				// {
				//   *(_QWORD *)&this.radius = 1169096704LL;
				//   *(_QWORD *)&this.selfTiltZ = 0LL;
				// }
				// 
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Header("天体半径")]
			[Range(1f, 79000f)]
			public float radius;

			[Header("自转倾角-X （相对于轨道空间）")]
			[Range(-90f, 90f)]
			public float selfTiltX;

			[Header("自转倾角-Z （相对于轨道空间）")]
			[Range(-90f, 90f)]
			public float selfTiltZ;

			[Header("自转")]
			[Range(0f, 360f)]
			public float selfRotationY;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static HGCelestialConfig.CelestialObjectProperty defaultConfig;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct CelestialDrawer : IEnvConfig
		{
			// (get) Token: 0x0600051D RID: 1309 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x0600051E RID: 1310 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public CelestialDrawer(bool active)
			{
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Header("绘制模式")]
			public HGCelestialConfig.CelestialDrawer.DrawMode drawMode;

			[Header("天幕绘制材质")]
			public Material drawMaterial;

			[Header("绘制 Pitch Yaw")]
			public Vector2 pitchYaw;

			[Header("星球入射 Pitch Yaw")]
			public Vector2 incidentLightingPitchYaw;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static HGCelestialConfig.CelestialDrawer defaultConfig;

			public enum DrawMode
			{
				Texture,
				Simulated
			}
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		public struct AtmosphereProperty : IEnvConfig
		{
			// (get) Token: 0x06000522 RID: 1314 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x06000523 RID: 1315 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public AtmosphereProperty(bool active)
			{
				// // HGCelestialConfig+AtmosphereProperty(Boolean)
				// void HG::Rendering::Runtime::HGCelestialConfig::AtmosphereProperty::AtmosphereProperty(
				//         HGCelestialConfig_AtmosphereProperty *this,
				//         bool active,
				//         MethodInfo *method)
				// {
				//   this.atmosphereHeight = 69.0;
				//   this.bakeFaceVisibility = 0.0;
				//   this.numInscatteredSamplePoints = 10;
				//   this.numOpticalDepthSamplePoints = 10;
				//   this.coff_R = 10.0;
				//   this.heightScale_R = 22.0;
				//   *(_QWORD *)&this.atmosphereBrightness = 1117782016LL;
				// }
				// 
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Range(0f, 1f)]
			[Header("背光面可见度 Backface Visibility")]
			public float bakeFaceVisibility;

			[Range(1f, 1000f)]
			[Header("大气高度 Atmosphere Height")]
			public float atmosphereHeight;

			[Range(1f, 100f)]
			[Header("散射外采样 Outer Scatter Sample")]
			[HideInInspector]
			public int numInscatteredSamplePoints;

			[Range(1f, 100f)]
			[Header("散射内采样 Inner Scatter Sample")]
			[HideInInspector]
			public int numOpticalDepthSamplePoints;

			[Range(0.01f, 10f)]
			[Header("散射对比 Scatter Contrast")]
			public float coff_R;

			[Header("散射高度系数 Scatter Strength")]
			[Range(0.01f, 30f)]
			public float heightScale_R;

			[Header("散射整体亮度 Scatter Brightness")]
			[Range(0.01f, 200f)]
			public float atmosphereBrightness;

			[Range(-1f, 1f)]
			[Header("散射色调偏移 Scatter Hueshift")]
			public float atmosphereHueshift;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static HGCelestialConfig.AtmosphereProperty defaultConfig;
		}

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct RingProperty : IEnvConfig
		{
			// (get) Token: 0x06000527 RID: 1319 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x06000528 RID: 1320 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool active
			{
				get
				{
					// // Boolean get_alwaysRebindOnRefresh()
					// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
					//         VerticalVirtualizationController_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return 1;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
					// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
					//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
					//         HGWindConfig *cSrc,
					//         HGWindConfig *cDst,
					//         float t,
					//         MethodInfo *method)
					// {
					//   ;
					// }
					// 
				}
			}

			public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
			{
			}

			[Range(0f, 160000f)]
			[Header("星环外半径")]
			public float outerRadius;

			[Header("星环宽度")]
			[Range(0f, 50000f)]
			public float width;

			[Header("光环颜色与透明度")]
			[ColorUsage(true, true)]
			public Color ringColor;

			[Header("光环贴图")]
			public Texture planetRingMap;
		}
	}
}
