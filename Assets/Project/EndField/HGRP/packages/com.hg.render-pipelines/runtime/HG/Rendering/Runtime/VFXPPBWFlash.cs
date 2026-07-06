using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[AddComponentMenu("HG/Effect/VFXPPBWFlash(黑白闪)")]
	public class VFXPPBWFlash : VFXPPComponent
	{
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<System::Object,UnityEngine::Vector3,UnityEngine::Vector3,float,System::Int32Enum>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_5_Object_UnityEngine_Vector3_UnityEngine_Vector3_Single_Int32Enum_ *this,
				//         MethodInfo *method)
				// {
				//   return 5;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPBWFlash()
		{
			// // VFXPPBWFlash()
			// void HG::Rendering::Runtime::VFXPPBWFlash::VFXPPBWFlash(VFXPPBWFlash *this, MethodInfo *method)
			// {
			//   Vector4 *one; // rax
			//   Vector4 *v3; // r8
			//   MethodInfo *v4; // rdx
			//   Quaternion v5; // xmm1
			//   __int64 v6; // r8
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields._bwThreshold = 0.50999999;
			//   this.fields._flashTexTiling.x = 1.0;
			//   this.fields._flashTexTiling.y = 1.0;
			//   this.fields._flashIntensity.x = 1.0;
			//   this.fields._flashIntensity.y = 1.0;
			//   this.fields._maskTexTiling.x = 1.0;
			//   this.fields._maskTexTiling.y = 1.0;
			//   one = UnityEngine::Vector4::get_one(&v7, method);
			//   v3[11] = *one;
			//   v5 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v7, v4);
			//   *(_BYTE *)(v6 + 52) = 1;
			//   *(_BYTE *)(v6 + 24) = 1;
			//   *(Quaternion *)(v6 + 192) = v5;
			//   UnityEngine::Component::Component((Component *)v6, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPBWFlash::Apply(VFXPPBWFlash *this, VolumeProfile *volumeProfile, MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   void *v6; // rdx
			//   _BYTE *klass; // rcx
			//   Object__Class *v8; // rax
			//   MonitorData *monitor; // rax
			//   Object__Class *v10; // rax
			//   MonitorData *v11; // rax
			//   MonitorData *v12; // rax
			//   Object__Class *v13; // rax
			//   MonitorData *v14; // rax
			//   Object__Class *v15; // rax
			//   MonitorData *v16; // rax
			//   Object__Class *v17; // rax
			//   unsigned __int64 v18; // xmm0_8
			//   Object__Class *v19; // rax
			//   MonitorData *v20; // rax
			//   Object__Class *v21; // rax
			//   MonitorData *v22; // rax
			//   Object__Class *v23; // rax
			//   MonitorData *v24; // rax
			//   Object__Class *v25; // rax
			//   MonitorData *v26; // rax
			//   Object__Class *v27; // rax
			//   unsigned __int64 v28; // xmm0_8
			//   MonitorData *v29; // rax
			//   Object__Class *v30; // rax
			//   MonitorData *v31; // rax
			//   Object__Class *v32; // rax
			//   Object__Class *v33; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color flashColor; // [rsp+20h] [rbp-30h] BYREF
			//   Object *component; // [rsp+88h] [rbp+38h] BYREF
			// 
			//   if ( !byte_18D919409 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGBWFlash>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGBWFlash>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBWFlash>);
			//     byte_18D919409 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2023, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2023, 0LL);
			//     if ( !Patch )
			//       goto LABEL_138;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//   }
			//   else
			//   {
			//     transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
			//       return;
			//     if ( !volumeProfile )
			//       goto LABEL_138;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGBWFlash>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGBWFlash>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBWFlash>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 1;
			//         if ( component )
			//         {
			//           klass = component[3].klass;
			//           if ( klass )
			//           {
			//             klass[16] = 1;
			//             if ( component )
			//             {
			//               v6 = component[3].klass;
			//               if ( v6 )
			//               {
			//                 sub_1800463A0(11LL, v6);
			//                 if ( component )
			//                 {
			//                   v8 = component[4].klass;
			//                   if ( v8 )
			//                   {
			//                     LOBYTE(v8._0.name) = 1;
			//                     if ( component )
			//                     {
			//                       v6 = component[4].klass;
			//                       if ( v6 )
			//                       {
			//                         sub_180042C50(11LL, v6);
			//                         if ( component )
			//                         {
			//                           monitor = component[4].monitor;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 1;
			//                             if ( component )
			//                             {
			//                               v6 = component[4].monitor;
			//                               if ( v6 )
			//                               {
			//                                 sub_180042C50(11LL, v6);
			//                                 if ( component )
			//                                 {
			//                                   v10 = component[5].klass;
			//                                   if ( v10 )
			//                                   {
			//                                     LOBYTE(v10._0.name) = 1;
			//                                     if ( component )
			//                                     {
			//                                       v6 = component[5].klass;
			//                                       if ( v6 )
			//                                       {
			//                                         sub_1800463A0(11LL, v6);
			//                                         if ( component )
			//                                         {
			//                                           v11 = component[5].monitor;
			//                                           if ( v11 )
			//                                           {
			//                                             *((_BYTE *)v11 + 16) = 1;
			//                                             if ( component )
			//                                             {
			//                                               v6 = component[5].monitor;
			//                                               if ( v6 )
			//                                               {
			//                                                 sub_1800463A0(11LL, v6);
			//                                                 if ( component )
			//                                                 {
			//                                                   v12 = component[8].monitor;
			//                                                   if ( v12 )
			//                                                   {
			//                                                     *((_BYTE *)v12 + 16) = 1;
			//                                                     if ( component )
			//                                                     {
			//                                                       v6 = component[8].monitor;
			//                                                       if ( v6 )
			//                                                       {
			//                                                         sub_1800463A0(11LL, v6);
			//                                                         if ( this.fields._useFlashTex )
			//                                                         {
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           klass = component[3].monitor;
			//                                                           if ( !klass )
			//                                                             goto LABEL_138;
			//                                                           klass[16] = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[3].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps(
			//                                                               (__m128)LODWORD(this.fields._centerPosition.x),
			//                                                               (__m128)LODWORD(this.fields._centerPosition.y)).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v19 = component[6].klass;
			//                                                           if ( !v19 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v19._0.name) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[6].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_180086B00(klass, v6, this.fields._flashTexture);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v20 = component[6].monitor;
			//                                                           if ( !v20 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v20 + 16) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[6].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps(
			//                                                               (__m128)LODWORD(this.fields._flashTexTiling.x),
			//                                                               (__m128)LODWORD(this.fields._flashTexTiling.y)).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v21 = component[7].klass;
			//                                                           if ( !v21 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v21._0.name) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[7].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps(
			//                                                               (__m128)LODWORD(this.fields._flashTexOffset.x),
			//                                                               (__m128)LODWORD(this.fields._flashTexOffset.y)).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v22 = component[7].monitor;
			//                                                           if ( !v22 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v22 + 16) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[7].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps(
			//                                                               (__m128)LODWORD(this.fields._flashTexSpeed.x),
			//                                                               (__m128)LODWORD(this.fields._flashTexSpeed.y)).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v23 = component[8].klass;
			//                                                           if ( !v23 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v23._0.name) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[8].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           v18 = _mm_unpacklo_ps(
			//                                                                   (__m128)LODWORD(this.fields._flashIntensity.x),
			//                                                                   (__m128)LODWORD(this.fields._flashIntensity.y)).m128_u64[0];
			//                                                         }
			//                                                         else
			//                                                         {
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           klass = component[3].monitor;
			//                                                           if ( !klass )
			//                                                             goto LABEL_138;
			//                                                           klass[16] = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[3].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v13 = component[6].klass;
			//                                                           if ( !v13 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v13._0.name) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[6].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_180086B00(klass, v6, 0LL);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v14 = component[6].monitor;
			//                                                           if ( !v14 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v14 + 16) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[6].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v15 = component[7].klass;
			//                                                           if ( !v15 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v15._0.name) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[7].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v16 = component[7].monitor;
			//                                                           if ( !v16 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v16 + 16) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[7].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v17 = component[8].klass;
			//                                                           if ( !v17 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v17._0.name) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[8].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           v18 = _mm_unpacklo_ps(
			//                                                                   (__m128)0x3F800000u,
			//                                                                   (__m128)0x3F800000u).m128_u64[0];
			//                                                         }
			//                                                         sub_18005D940(11LL, v6, v18);
			//                                                         if ( this.fields._useMaskTex )
			//                                                         {
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           klass = component[9].klass;
			//                                                           if ( !klass )
			//                                                             goto LABEL_138;
			//                                                           klass[16] = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[9].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_180086B00(klass, v6, this.fields._maskTexture);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v29 = component[9].monitor;
			//                                                           if ( !v29 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v29 + 16) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[9].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_180042C50(11LL, v6);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v30 = component[10].klass;
			//                                                           if ( !v30 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v30._0.name) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[10].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_1800463A0(11LL, v6);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v31 = component[10].monitor;
			//                                                           if ( !v31 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v31 + 16) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[10].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps(
			//                                                               (__m128)LODWORD(this.fields._maskTexTiling.x),
			//                                                               (__m128)LODWORD(this.fields._maskTexTiling.y)).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v32 = component[11].klass;
			//                                                           if ( !v32 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v32._0.name) = 1;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[11].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           v28 = _mm_unpacklo_ps(
			//                                                                   (__m128)LODWORD(this.fields._maskTexOffset.x),
			//                                                                   (__m128)LODWORD(this.fields._maskTexOffset.y)).m128_u64[0];
			//                                                         }
			//                                                         else
			//                                                         {
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           klass = component[9].klass;
			//                                                           if ( !klass )
			//                                                             goto LABEL_138;
			//                                                           klass[16] = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[9].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_180086B00(klass, v6, 0LL);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v24 = component[9].monitor;
			//                                                           if ( !v24 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v24 + 16) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[9].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_180042C50(11LL, v6);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v25 = component[10].klass;
			//                                                           if ( !v25 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v25._0.name) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[10].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_1800463A0(11LL, v6);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v26 = component[10].monitor;
			//                                                           if ( !v26 )
			//                                                             goto LABEL_138;
			//                                                           *((_BYTE *)v26 + 16) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[10].monitor;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           sub_18005D940(
			//                                                             11LL,
			//                                                             v6,
			//                                                             _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v27 = component[11].klass;
			//                                                           if ( !v27 )
			//                                                             goto LABEL_138;
			//                                                           LOBYTE(v27._0.name) = 0;
			//                                                           if ( !component )
			//                                                             goto LABEL_138;
			//                                                           v6 = component[11].klass;
			//                                                           if ( !v6 )
			//                                                             goto LABEL_138;
			//                                                           v28 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                                         }
			//                                                         sub_18005D940(11LL, v6, v28);
			//                                                         if ( component )
			//                                                         {
			//                                                           klass = component[11].monitor;
			//                                                           if ( klass )
			//                                                           {
			//                                                             klass[16] = 1;
			//                                                             if ( component )
			//                                                             {
			//                                                               v6 = component[11].monitor;
			//                                                               if ( v6 )
			//                                                               {
			//                                                                 flashColor = this.fields._flashColor;
			//                                                                 sub_18004EA90(11LL, v6, &flashColor);
			//                                                                 if ( component )
			//                                                                 {
			//                                                                   v33 = component[12].klass;
			//                                                                   if ( v33 )
			//                                                                   {
			//                                                                     LOBYTE(v33._0.name) = 1;
			//                                                                     if ( component )
			//                                                                     {
			//                                                                       v6 = component[12].klass;
			//                                                                       if ( v6 )
			//                                                                       {
			//                                                                         flashColor = this.fields._backGroundColor;
			//                                                                         sub_18004EA90(11LL, v6, &flashColor);
			//                                                                         return;
			//                                                                       }
			//                                                                     }
			//                                                                   }
			//                                                                 }
			//                                                               }
			//                                                             }
			//                                                           }
			//                                                         }
			//                                                       }
			//                                                     }
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_138:
			//       sub_180B536AC(klass, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPBWFlash::ResetByVolumeProfile(
			//         VFXPPBWFlash *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   void *v5; // rdx
			//   Object__Class *klass; // rcx
			//   Object__Class *v7; // rax
			//   MonitorData *monitor; // rax
			//   Object__Class *v9; // rax
			//   MonitorData *v10; // rax
			//   MonitorData *v11; // rax
			//   Object__Class *v12; // rax
			//   MonitorData *v13; // rax
			//   Object__Class *v14; // rax
			//   MonitorData *v15; // rax
			//   Object__Class *v16; // rax
			//   MonitorData *v17; // rax
			//   Object__Class *v18; // rax
			//   MonitorData *v19; // rax
			//   Object__Class *v20; // rax
			//   MonitorData *v21; // rax
			//   Object__Class *v22; // rax
			//   MonitorData *v23; // rax
			//   Vector4 *one; // rax
			//   Object__Class *v25; // rax
			//   Quaternion *identity; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Quaternion v28; // [rsp+20h] [rbp-30h] BYREF
			//   Object *component; // [rsp+78h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D91940A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBWFlash>);
			//     byte_18D91940A = 1;
			//   }
			//   component = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2024, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//       return;
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBWFlash>) )
			//         return;
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 0;
			//         if ( component )
			//         {
			//           klass = component[3].klass;
			//           if ( klass )
			//           {
			//             LOBYTE(klass._0.name) = 0;
			//             if ( component )
			//             {
			//               v5 = component[3].klass;
			//               if ( v5 )
			//               {
			//                 sub_1800463A0(11LL, v5);
			//                 if ( component )
			//                 {
			//                   v7 = component[4].klass;
			//                   if ( v7 )
			//                   {
			//                     LOBYTE(v7._0.name) = 0;
			//                     if ( component )
			//                     {
			//                       v5 = component[4].klass;
			//                       if ( v5 )
			//                       {
			//                         sub_180042C50(11LL, v5);
			//                         if ( component )
			//                         {
			//                           monitor = component[4].monitor;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 0;
			//                             if ( component )
			//                             {
			//                               v5 = component[4].monitor;
			//                               if ( v5 )
			//                               {
			//                                 sub_180042C50(11LL, v5);
			//                                 if ( component )
			//                                 {
			//                                   v9 = component[5].klass;
			//                                   if ( v9 )
			//                                   {
			//                                     LOBYTE(v9._0.name) = 0;
			//                                     if ( component )
			//                                     {
			//                                       v5 = component[5].klass;
			//                                       if ( v5 )
			//                                       {
			//                                         sub_1800463A0(11LL, v5);
			//                                         if ( component )
			//                                         {
			//                                           v10 = component[5].monitor;
			//                                           if ( v10 )
			//                                           {
			//                                             *((_BYTE *)v10 + 16) = 0;
			//                                             if ( component )
			//                                             {
			//                                               v5 = component[5].monitor;
			//                                               if ( v5 )
			//                                               {
			//                                                 sub_1800463A0(11LL, v5);
			//                                                 if ( component )
			//                                                 {
			//                                                   v11 = component[3].monitor;
			//                                                   if ( v11 )
			//                                                   {
			//                                                     *((_BYTE *)v11 + 16) = 0;
			//                                                     if ( component )
			//                                                     {
			//                                                       v5 = component[3].monitor;
			//                                                       if ( v5 )
			//                                                       {
			//                                                         sub_18005D940(
			//                                                           11LL,
			//                                                           v5,
			//                                                           _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u).m128_u64[0]);
			//                                                         if ( component )
			//                                                         {
			//                                                           v12 = component[6].klass;
			//                                                           if ( v12 )
			//                                                           {
			//                                                             LOBYTE(v12._0.name) = 0;
			//                                                             if ( component )
			//                                                             {
			//                                                               v5 = component[6].klass;
			//                                                               if ( v5 )
			//                                                               {
			//                                                                 sub_180086B00(klass, v5, 0LL);
			//                                                                 if ( component )
			//                                                                 {
			//                                                                   v13 = component[6].monitor;
			//                                                                   if ( v13 )
			//                                                                   {
			//                                                                     *((_BYTE *)v13 + 16) = 0;
			//                                                                     if ( component )
			//                                                                     {
			//                                                                       v5 = component[6].monitor;
			//                                                                       if ( v5 )
			//                                                                       {
			//                                                                         sub_18005D940(
			//                                                                           11LL,
			//                                                                           v5,
			//                                                                           _mm_unpacklo_ps(
			//                                                                             (__m128)0x3F800000u,
			//                                                                             (__m128)0x3F800000u).m128_u64[0]);
			//                                                                         if ( component )
			//                                                                         {
			//                                                                           v14 = component[7].klass;
			//                                                                           if ( v14 )
			//                                                                           {
			//                                                                             LOBYTE(v14._0.name) = 0;
			//                                                                             if ( component )
			//                                                                             {
			//                                                                               v5 = component[7].klass;
			//                                                                               if ( v5 )
			//                                                                               {
			//                                                                                 sub_18005D940(
			//                                                                                   11LL,
			//                                                                                   v5,
			//                                                                                   _mm_unpacklo_ps(
			//                                                                                     (__m128)0LL,
			//                                                                                     (__m128)0LL).m128_u64[0]);
			//                                                                                 if ( component )
			//                                                                                 {
			//                                                                                   v15 = component[7].monitor;
			//                                                                                   if ( v15 )
			//                                                                                   {
			//                                                                                     *((_BYTE *)v15 + 16) = 0;
			//                                                                                     if ( component )
			//                                                                                     {
			//                                                                                       v5 = component[7].monitor;
			//                                                                                       if ( v5 )
			//                                                                                       {
			//                                                                                         sub_18005D940(
			//                                                                                           11LL,
			//                                                                                           v5,
			//                                                                                           _mm_unpacklo_ps(
			//                                                                                             (__m128)0LL,
			//                                                                                             (__m128)0LL).m128_u64[0]);
			//                                                                                         if ( component )
			//                                                                                         {
			//                                                                                           v16 = component[8].klass;
			//                                                                                           if ( v16 )
			//                                                                                           {
			//                                                                                             LOBYTE(v16._0.name) = 0;
			//                                                                                             if ( component )
			//                                                                                             {
			//                                                                                               v5 = component[8].klass;
			//                                                                                               if ( v5 )
			//                                                                                               {
			//                                                                                                 sub_18005D940(
			//                                                                                                   11LL,
			//                                                                                                   v5,
			//                                                                                                   _mm_unpacklo_ps(
			//                                                                                                     (__m128)0x3F800000u,
			//                                                                                                     (__m128)0x3F800000u).m128_u64[0]);
			//                                                                                                 if ( component )
			//                                                                                                 {
			//                                                                                                   v17 = component[8].monitor;
			//                                                                                                   if ( v17 )
			//                                                                                                   {
			//                                                                                                     *((_BYTE *)v17 + 16) = 0;
			//                                                                                                     if ( component )
			//                                                                                                     {
			//                                                                                                       v5 = component[8].monitor;
			//                                                                                                       if ( v5 )
			//                                                                                                       {
			//                                                                                                         sub_1800463A0(11LL, v5);
			//                                                                                                         if ( component )
			//                                                                                                         {
			//                                                                                                           v18 = component[9].klass;
			//                                                                                                           if ( v18 )
			//                                                                                                           {
			//                                                                                                             LOBYTE(v18._0.name) = 0;
			//                                                                                                             if ( component )
			//                                                                                                             {
			//                                                                                                               v5 = component[9].klass;
			//                                                                                                               if ( v5 )
			//                                                                                                               {
			//                                                                                                                 sub_180086B00(klass, v5, 0LL);
			//                                                                                                                 if ( component )
			//                                                                                                                 {
			//                                                                                                                   v19 = component[9].monitor;
			//                                                                                                                   if ( v19 )
			//                                                                                                                   {
			//                                                                                                                     *((_BYTE *)v19 + 16) = 0;
			//                                                                                                                     if ( component )
			//                                                                                                                     {
			//                                                                                                                       v5 = component[9].monitor;
			//                                                                                                                       if ( v5 )
			//                                                                                                                       {
			//                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                         if ( component )
			//                                                                                                                         {
			//                                                                                                                           v20 = component[10].klass;
			//                                                                                                                           if ( v20 )
			//                                                                                                                           {
			//                                                                                                                             LOBYTE(v20._0.name) = 0;
			//                                                                                                                             if ( component )
			//                                                                                                                             {
			//                                                                                                                               v5 = component[10].klass;
			//                                                                                                                               if ( v5 )
			//                                                                                                                               {
			//                                                                                                                                 sub_1800463A0(11LL, v5);
			//                                                                                                                                 if ( component )
			//                                                                                                                                 {
			//                                                                                                                                   v21 = component[10].monitor;
			//                                                                                                                                   if ( v21 )
			//                                                                                                                                   {
			//                                                                                                                                     *((_BYTE *)v21 + 16) = 0;
			//                                                                                                                                     if ( component )
			//                                                                                                                                     {
			//                                                                                                                                       v5 = component[10].monitor;
			//                                                                                                                                       if ( v5 )
			//                                                                                                                                       {
			//                                                                                                                                         sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//                                                                                                                                         if ( component )
			//                                                                                                                                         {
			//                                                                                                                                           v22 = component[11].klass;
			//                                                                                                                                           if ( v22 )
			//                                                                                                                                           {
			//                                                                                                                                             LOBYTE(v22._0.name) = 0;
			//                                                                                                                                             if ( component )
			//                                                                                                                                             {
			//                                                                                                                                               v5 = component[11].klass;
			//                                                                                                                                               if ( v5 )
			//                                                                                                                                               {
			//                                                                                                                                                 sub_18005D940(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
			//                                                                                                                                                 if ( component )
			//                                                                                                                                                 {
			//                                                                                                                                                   v23 = component[11].monitor;
			//                                                                                                                                                   if ( v23 )
			//                                                                                                                                                   {
			//                                                                                                                                                     *((_BYTE *)v23 + 16) = 0;
			//                                                                                                                                                     if ( component )
			//                                                                                                                                                     {
			//                                                                                                                                                       one = UnityEngine::Vector4::get_one((Vector4 *)&v28, (MethodInfo *)component[11].monitor);
			//                                                                                                                                                       if ( v5 )
			//                                                                                                                                                       {
			//                                                                                                                                                         v28 = (Quaternion)*one;
			//                                                                                                                                                         sub_18004EA90(11LL, v5, &v28);
			//                                                                                                                                                         if ( component )
			//                                                                                                                                                         {
			//                                                                                                                                                           v25 = component[12].klass;
			//                                                                                                                                                           if ( v25 )
			//                                                                                                                                                           {
			//                                                                                                                                                             LOBYTE(v25._0.name) = 0;
			//                                                                                                                                                             if ( component )
			//                                                                                                                                                             {
			//                                                                                                                                                               identity = UnityEngine::Quaternion::get_identity(&v28, (MethodInfo *)component[12].klass);
			//                                                                                                                                                               if ( v5 )
			//                                                                                                                                                               {
			//                                                                                                                                                                 v28 = *identity;
			//                                                                                                                                                                 sub_18004EA90(11LL, v5, &v28);
			//                                                                                                                                                                 return;
			//                                                                                                                                                               }
			//                                                                                                                                                             }
			//                                                                                                                                                           }
			//                                                                                                                                                         }
			//                                                                                                                                                       }
			//                                                                                                                                                     }
			//                                                                                                                                                   }
			//                                                                                                                                                 }
			//                                                                                                                                               }
			//                                                                                                                                             }
			//                                                                                                                                           }
			//                                                                                                                                         }
			//                                                                                                                                       }
			//                                                                                                                                     }
			//                                                                                                                                   }
			//                                                                                                                                 }
			//                                                                                                                               }
			//                                                                                                                             }
			//                                                                                                                           }
			//                                                                                                                         }
			//                                                                                                                       }
			//                                                                                                                     }
			//                                                                                                                   }
			//                                                                                                                 }
			//                                                                                                               }
			//                                                                                                             }
			//                                                                                                           }
			//                                                                                                         }
			//                                                                                                       }
			//                                                                                                     }
			//                                                                                                   }
			//                                                                                                 }
			//                                                                                               }
			//                                                                                             }
			//                                                                                           }
			//                                                                                         }
			//                                                                                       }
			//                                                                                     }
			//                                                                                   }
			//                                                                                 }
			//                                                                               }
			//                                                                             }
			//                                                                           }
			//                                                                         }
			//                                                                       }
			//                                                                     }
			//                                                                   }
			//                                                                 }
			//                                                               }
			//                                                             }
			//                                                           }
			//                                                         }
			//                                                       }
			//                                                     }
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_86:
			//     sub_180B536AC(klass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2024, 0LL);
			//   if ( !Patch )
			//     goto LABEL_86;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)volumeProfile,
			//     0LL);
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPBWFlash::IsActive(VFXPPBWFlash *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2025, 0LL) )
			//     return this.fields._bwThreshold != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2025, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_Apply(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public bool <>iFixBaseProxy_IsActive()
		{
			// // Boolean <>iFixBaseProxy_IsActive()
			// bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[SerializeField]
		[Range(0.51f, 1f)]
		private float _bwThreshold;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _colorBias;

		[SerializeField]
		private bool _colorInverse;

		[SerializeField]
		private bool _useFlashTex;

		[SerializeField]
		private Vector2 _centerPosition;

		[SerializeField]
		private Texture2D _flashTexture;

		[SerializeField]
		private Vector2 _flashTexTiling;

		[SerializeField]
		private Vector2 _flashTexOffset;

		[SerializeField]
		private Vector2 _flashTexSpeed;

		[SerializeField]
		private Vector2 _flashIntensity;

		[SerializeField]
		private bool _useMaskTex;

		[SerializeField]
		private Texture2D _maskTexture;

		[Range(0f, 1f)]
		[SerializeField]
		private float _maskIntensity;

		[SerializeField]
		private bool _maskUsePolarUV;

		[SerializeField]
		private Vector2 _maskTexTiling;

		[SerializeField]
		private Vector2 _maskTexOffset;

		[SerializeField]
		[ColorUsage(true, false)]
		private Color _flashColor;

		[SerializeField]
		[ColorUsage(true, false)]
		private Color _backGroundColor;
	}
}
