using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPScanLine(扫描线)")]
	[ExecuteInEditMode]
	public class VFXPPScanLine : VFXPPComponent
	{
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<UnityEngine::Vector3Int,System::Object,int,int>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_4_UnityEngine_Vector3Int_Object_Int32_Int32_ *this,
				//         MethodInfo *method)
				// {
				//   return 4;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPScanLine()
		{
			// // VFXPPVignette()
			// void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
			// {
			//   this.fields._.m_targetEnable = 1;
			//   this.fields._._.m_isPlaying = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::VFXPPScanLine::Awake(VFXPPScanLine *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2114, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2114, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VFXPPScanLine::ResetTreasureHuntPos(this, 0LL);
			//   }
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPScanLine::Apply(
			//         VFXPPScanLine *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   _BYTE *v6; // rdx
			//   _BYTE *klass; // rcx
			//   Object__Class *v8; // rax
			//   MonitorData *monitor; // rax
			//   MonitorData *v10; // rbx
			//   Transform *v11; // rax
			//   Vector3 *position; // rax
			//   __int64 v13; // xmm0_8
			//   MethodInfo *v14; // r8
			//   Vector4 *v15; // rax
			//   MonitorData *v16; // rax
			//   Object__Class *v17; // rax
			//   MonitorData *v18; // rax
			//   MonitorData *v19; // rax
			//   Object__Class *v20; // rax
			//   unsigned __int64 v21; // xmm0_8
			//   MonitorData *v22; // rax
			//   Object__Class *v23; // rax
			//   Object__Class *v24; // rax
			//   MonitorData *v25; // rax
			//   Object__Class *v26; // rax
			//   MonitorData *v27; // rax
			//   Object__Class *v28; // rax
			//   MonitorData *v29; // rax
			//   Object__Class *v30; // rax
			//   MonitorData *v31; // rax
			//   MonitorData *v32; // rax
			//   Object__Class *v33; // rax
			//   MonitorData *v34; // rax
			//   Object__Class *v35; // rax
			//   MonitorData *v36; // rax
			//   Object__Class *v37; // rax
			//   Object__Class *v38; // rax
			//   MonitorData *v39; // rax
			//   Object__Class *v40; // rax
			//   MonitorData *v41; // rax
			//   Object__Class *v42; // rax
			//   MonitorData *v43; // rax
			//   Object__Class *v44; // rax
			//   MonitorData *v45; // rax
			//   Object__Class *v46; // rax
			//   MonitorData *v47; // rax
			//   Object__Class *v48; // rax
			//   MonitorData *v49; // rax
			//   Object__Class *v50; // rax
			//   MonitorData *v51; // rax
			//   Object__Class *v52; // rax
			//   MonitorData *v53; // rax
			//   Object__Class *v54; // rax
			//   MonitorData *v55; // rax
			//   Object__Class *v56; // rax
			//   MonitorData *v57; // rax
			//   Object__Class *v58; // rax
			//   MonitorData *v59; // rax
			//   Object__Class *v60; // rax
			//   Object__Class *v61; // rax
			//   MonitorData *v62; // rax
			//   Object__Class *v63; // rax
			//   MonitorData *v64; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v66; // [rsp+20h] [rbp-40h] BYREF
			//   Vector4 color; // [rsp+30h] [rbp-30h] BYREF
			//   Object *component; // [rsp+88h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D91942E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGScanLine>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGScanLine>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGScanLine>);
			//     byte_18D91942E = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2116, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2116, 0LL);
			//     if ( !Patch )
			//       goto LABEL_242;
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
			//       goto LABEL_242;
			//     if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
			//             volumeProfile,
			//             MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGScanLine>) )
			//       UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
			//         volumeProfile,
			//         0,
			//         MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGScanLine>);
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGScanLine>) )
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
			//                           monitor = component[3].monitor;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 1;
			//                             if ( component )
			//                             {
			//                               v10 = component[3].monitor;
			//                               v11 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//                               if ( v11 )
			//                               {
			//                                 position = UnityEngine::Transform::get_position((Vector3 *)&color, v11, 0LL);
			//                                 v13 = *(_QWORD *)&position.x;
			//                                 *(float *)&position = position.z;
			//                                 *(_QWORD *)&v66.x = v13;
			//                                 LODWORD(v66.z) = (_DWORD)position;
			//                                 v15 = UnityEngine::Vector4::op_Implicit(&color, &v66, v14);
			//                                 if ( v10 )
			//                                 {
			//                                   color = *v15;
			//                                   sub_18048EDCC(11LL, v10, &color);
			//                                   if ( component )
			//                                   {
			//                                     v16 = component[4].monitor;
			//                                     if ( v16 )
			//                                     {
			//                                       *((_BYTE *)v16 + 16) = 1;
			//                                       if ( component )
			//                                       {
			//                                         v6 = component[4].monitor;
			//                                         if ( v6 )
			//                                         {
			//                                           color = (Vector4)this.fields._color;
			//                                           sub_18004EA90(11LL, v6, &color);
			//                                           if ( component )
			//                                           {
			//                                             v17 = component[5].klass;
			//                                             if ( v17 )
			//                                             {
			//                                               LOBYTE(v17._0.name) = 1;
			//                                               if ( component )
			//                                               {
			//                                                 v6 = component[5].klass;
			//                                                 if ( v6 )
			//                                                 {
			//                                                   sub_180042C50(11LL, v6);
			//                                                   if ( component )
			//                                                   {
			//                                                     v18 = component[5].monitor;
			//                                                     if ( v18 )
			//                                                     {
			//                                                       *((_BYTE *)v18 + 16) = 1;
			//                                                       if ( component )
			//                                                       {
			//                                                         v6 = component[5].monitor;
			//                                                         if ( v6 )
			//                                                         {
			//                                                           sub_1800463A0(11LL, v6);
			//                                                           if ( this.fields._useMaskTex )
			//                                                           {
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             klass = component[6].klass;
			//                                                             if ( !klass )
			//                                                               goto LABEL_242;
			//                                                             klass[16] = 1;
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v6 = component[6].klass;
			//                                                             if ( !v6 )
			//                                                               goto LABEL_242;
			//                                                             sub_180086B00(klass, v6, this.fields._maskTex);
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v22 = component[6].monitor;
			//                                                             if ( !v22 )
			//                                                               goto LABEL_242;
			//                                                             *((_BYTE *)v22 + 16) = 1;
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v6 = component[6].monitor;
			//                                                             if ( !v6 )
			//                                                               goto LABEL_242;
			//                                                             sub_18005D940(
			//                                                               11LL,
			//                                                               v6,
			//                                                               _mm_unpacklo_ps(
			//                                                                 (__m128)LODWORD(this.fields._maskTexTiling.x),
			//                                                                 (__m128)LODWORD(this.fields._maskTexTiling.y)).m128_u64[0]);
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v23 = component[7].klass;
			//                                                             if ( !v23 )
			//                                                               goto LABEL_242;
			//                                                             LOBYTE(v23._0.name) = 1;
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v6 = component[7].klass;
			//                                                             if ( !v6 )
			//                                                               goto LABEL_242;
			//                                                             v21 = _mm_unpacklo_ps(
			//                                                                     (__m128)LODWORD(this.fields._maskTexOffset.x),
			//                                                                     (__m128)LODWORD(this.fields._maskTexOffset.y)).m128_u64[0];
			//                                                           }
			//                                                           else
			//                                                           {
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             klass = component[6].klass;
			//                                                             if ( !klass )
			//                                                               goto LABEL_242;
			//                                                             klass[16] = 0;
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v6 = component[6].klass;
			//                                                             if ( !v6 )
			//                                                               goto LABEL_242;
			//                                                             sub_180086B00(klass, v6, 0LL);
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v19 = component[6].monitor;
			//                                                             if ( !v19 )
			//                                                               goto LABEL_242;
			//                                                             *((_BYTE *)v19 + 16) = 0;
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v6 = component[6].monitor;
			//                                                             if ( !v6 )
			//                                                               goto LABEL_242;
			//                                                             sub_18005D940(
			//                                                               11LL,
			//                                                               v6,
			//                                                               _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v20 = component[7].klass;
			//                                                             if ( !v20 )
			//                                                               goto LABEL_242;
			//                                                             LOBYTE(v20._0.name) = 0;
			//                                                             if ( !component )
			//                                                               goto LABEL_242;
			//                                                             v6 = component[7].klass;
			//                                                             if ( !v6 )
			//                                                               goto LABEL_242;
			//                                                             v21 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                                           }
			//                                                           sub_18005D940(11LL, v6, v21);
			//                                                           if ( component )
			//                                                           {
			//                                                             klass = component[7].monitor;
			//                                                             if ( klass )
			//                                                             {
			//                                                               klass[16] = 1;
			//                                                               if ( component )
			//                                                               {
			//                                                                 v6 = component[7].monitor;
			//                                                                 if ( v6 )
			//                                                                 {
			//                                                                   sub_180042C50(11LL, v6);
			//                                                                   if ( component )
			//                                                                   {
			//                                                                     v24 = component[8].klass;
			//                                                                     if ( v24 )
			//                                                                     {
			//                                                                       LOBYTE(v24._0.name) = 1;
			//                                                                       if ( component )
			//                                                                       {
			//                                                                         v6 = component[8].klass;
			//                                                                         if ( v6 )
			//                                                                         {
			//                                                                           sub_180042C50(11LL, v6);
			//                                                                           if ( component )
			//                                                                           {
			//                                                                             v25 = component[8].monitor;
			//                                                                             if ( v25 )
			//                                                                             {
			//                                                                               *((_BYTE *)v25 + 16) = 1;
			//                                                                               if ( component )
			//                                                                               {
			//                                                                                 v6 = component[8].monitor;
			//                                                                                 if ( v6 )
			//                                                                                 {
			//                                                                                   sub_180042C50(11LL, v6);
			//                                                                                   if ( component )
			//                                                                                   {
			//                                                                                     v26 = component[9].klass;
			//                                                                                     if ( v26 )
			//                                                                                     {
			//                                                                                       LOBYTE(v26._0.name) = 1;
			//                                                                                       if ( component )
			//                                                                                       {
			//                                                                                         v6 = component[9].klass;
			//                                                                                         if ( v6 )
			//                                                                                         {
			//                                                                                           sub_180042C50(11LL, v6);
			//                                                                                           if ( component )
			//                                                                                           {
			//                                                                                             v27 = component[9].monitor;
			//                                                                                             if ( v27 )
			//                                                                                             {
			//                                                                                               *((_BYTE *)v27 + 16) = 1;
			//                                                                                               if ( component )
			//                                                                                               {
			//                                                                                                 v6 = component[9].monitor;
			//                                                                                                 if ( v6 )
			//                                                                                                 {
			//                                                                                                   sub_180042C50(
			//                                                                                                     11LL,
			//                                                                                                     v6);
			//                                                                                                   if ( component )
			//                                                                                                   {
			//                                                                                                     v28 = component[10].klass;
			//                                                                                                     if ( v28 )
			//                                                                                                     {
			//                                                                                                       LOBYTE(v28._0.name) = 1;
			//                                                                                                       if ( component )
			//                                                                                                       {
			//                                                                                                         v6 = component[10].klass;
			//                                                                                                         if ( v6 )
			//                                                                                                         {
			//                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                           if ( component )
			//                                                                                                           {
			//                                                                                                             v29 = component[10].monitor;
			//                                                                                                             if ( v29 )
			//                                                                                                             {
			//                                                                                                               *((_BYTE *)v29 + 16) = 1;
			//                                                                                                               if ( component )
			//                                                                                                               {
			//                                                                                                                 v6 = component[10].monitor;
			//                                                                                                                 if ( v6 )
			//                                                                                                                 {
			//                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                   if ( component )
			//                                                                                                                   {
			//                                                                                                                     v30 = component[11].klass;
			//                                                                                                                     if ( v30 )
			//                                                                                                                     {
			//                                                                                                                       LOBYTE(v30._0.name) = 1;
			//                                                                                                                       if ( component )
			//                                                                                                                       {
			//                                                                                                                         v6 = component[11].klass;
			//                                                                                                                         if ( v6 )
			//                                                                                                                         {
			//                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                           if ( component )
			//                                                                                                                           {
			//                                                                                                                             v31 = component[11].monitor;
			//                                                                                                                             if ( v31 )
			//                                                                                                                             {
			//                                                                                                                               *((_BYTE *)v31 + 16) = 1;
			//                                                                                                                               if ( component )
			//                                                                                                                               {
			//                                                                                                                                 v6 = component[11].monitor;
			//                                                                                                                                 if ( v6 )
			//                                                                                                                                 {
			//                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                   if ( component )
			//                                                                                                                                   {
			//                                                                                                                                     v32 = component[12].monitor;
			//                                                                                                                                     if ( v32 )
			//                                                                                                                                     {
			//                                                                                                                                       *((_BYTE *)v32 + 16) = 1;
			//                                                                                                                                       if ( component )
			//                                                                                                                                       {
			//                                                                                                                                         v6 = component[12].monitor;
			//                                                                                                                                         if ( v6 )
			//                                                                                                                                         {
			//                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                           if ( component )
			//                                                                                                                                           {
			//                                                                                                                                             v33 = component[13].klass;
			//                                                                                                                                             if ( v33 )
			//                                                                                                                                             {
			//                                                                                                                                               LOBYTE(v33._0.name) = 1;
			//                                                                                                                                               if ( component )
			//                                                                                                                                               {
			//                                                                                                                                                 v6 = component[13].klass;
			//                                                                                                                                                 if ( v6 )
			//                                                                                                                                                 {
			//                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                   if ( component )
			//                                                                                                                                                   {
			//                                                                                                                                                     v34 = component[13].monitor;
			//                                                                                                                                                     if ( v34 )
			//                                                                                                                                                     {
			//                                                                                                                                                       *((_BYTE *)v34 + 16) = 1;
			//                                                                                                                                                       if ( component )
			//                                                                                                                                                       {
			//                                                                                                                                                         v6 = component[13].monitor;
			//                                                                                                                                                         if ( v6 )
			//                                                                                                                                                         {
			//                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                           if ( component )
			//                                                                                                                                                           {
			//                                                                                                                                                             v35 = component[14].klass;
			//                                                                                                                                                             if ( v35 )
			//                                                                                                                                                             {
			//                                                                                                                                                               LOBYTE(v35._0.name) = 1;
			//                                                                                                                                                               if ( component )
			//                                                                                                                                                               {
			//                                                                                                                                                                 v6 = component[14].klass;
			//                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                 {
			//                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                   if ( component )
			//                                                                                                                                                                   {
			//                                                                                                                                                                     v36 = component[14].monitor;
			//                                                                                                                                                                     if ( v36 )
			//                                                                                                                                                                     {
			//                                                                                                                                                                       *((_BYTE *)v36 + 16) = 1;
			//                                                                                                                                                                       if ( component )
			//                                                                                                                                                                       {
			//                                                                                                                                                                         v6 = component[14].monitor;
			//                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                         {
			//                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                           if ( component )
			//                                                                                                                                                                           {
			//                                                                                                                                                                             v37 = component[12].klass;
			//                                                                                                                                                                             if ( v37 )
			//                                                                                                                                                                             {
			//                                                                                                                                                                               LOBYTE(v37._0.name) = 1;
			//                                                                                                                                                                               if ( component )
			//                                                                                                                                                                               {
			//                                                                                                                                                                                 v6 = component[12].klass;
			//                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                 {
			//                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                   {
			//                                                                                                                                                                                     v38 = component[15].klass;
			//                                                                                                                                                                                     if ( v38 )
			//                                                                                                                                                                                     {
			//                                                                                                                                                                                       LOBYTE(v38._0.name) = 1;
			//                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                       {
			//                                                                                                                                                                                         v6 = component[15].klass;
			//                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                         {
			//                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                           {
			//                                                                                                                                                                                             v39 = component[15].monitor;
			//                                                                                                                                                                                             if ( v39 )
			//                                                                                                                                                                                             {
			//                                                                                                                                                                                               *((_BYTE *)v39 + 16) = 1;
			//                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                               {
			//                                                                                                                                                                                                 v6 = component[15].monitor;
			//                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                 {
			//                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                   {
			//                                                                                                                                                                                                     v40 = component[16].klass;
			//                                                                                                                                                                                                     if ( v40 )
			//                                                                                                                                                                                                     {
			//                                                                                                                                                                                                       LOBYTE(v40._0.name) = 1;
			//                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                       {
			//                                                                                                                                                                                                         v6 = component[16].klass;
			//                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                         {
			//                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                           {
			//                                                                                                                                                                                                             v41 = component[16].monitor;
			//                                                                                                                                                                                                             if ( v41 )
			//                                                                                                                                                                                                             {
			//                                                                                                                                                                                                               *((_BYTE *)v41 + 16) = 1;
			//                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                 v6 = component[16].monitor;
			//                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                     v42 = component[17].klass;
			//                                                                                                                                                                                                                     if ( v42 )
			//                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                       LOBYTE(v42._0.name) = 1;
			//                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                         v6 = component[17].klass;
			//                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                             v43 = component[17].monitor;
			//                                                                                                                                                                                                                             if ( v43 )
			//                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                               *((_BYTE *)v43 + 16) = 1;
			//                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                 v6 = component[17].monitor;
			//                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                     v44 = component[18].klass;
			//                                                                                                                                                                                                                                     if ( v44 )
			//                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                       LOBYTE(v44._0.name) = 1;
			//                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                         v6 = component[18].klass;
			//                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                             v45 = component[18].monitor;
			//                                                                                                                                                                                                                                             if ( v45 )
			//                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                               *((_BYTE *)v45 + 16) = 1;
			//                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                 v6 = component[18].monitor;
			//                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                     v46 = component[19].klass;
			//                                                                                                                                                                                                                                                     if ( v46 )
			//                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                       LOBYTE(v46._0.name) = 1;
			//                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                         v6 = component[19].klass;
			//                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                             v47 = component[19].monitor;
			//                                                                                                                                                                                                                                                             if ( v47 )
			//                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                               *((_BYTE *)v47 + 16) = 1;
			//                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                 v6 = component[19].monitor;
			//                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                     v48 = component[20].klass;
			//                                                                                                                                                                                                                                                                     if ( v48 )
			//                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                       LOBYTE(v48._0.name) = 1;
			//                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                         v6 = component[20].klass;
			//                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                             v49 = component[20].monitor;
			//                                                                                                                                                                                                                                                                             if ( v49 )
			//                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                               *((_BYTE *)v49 + 16) = 1;
			//                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                 v6 = component[20].monitor;
			//                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                     v50 = component[21].klass;
			//                                                                                                                                                                                                                                                                                     if ( v50 )
			//                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                       LOBYTE(v50._0.name) = 1;
			//                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                         v6 = component[21].klass;
			//                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                             v51 = component[21].monitor;
			//                                                                                                                                                                                                                                                                                             if ( v51 )
			//                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                               *((_BYTE *)v51 + 16) = 1;
			//                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                 v6 = component[21].monitor;
			//                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                     v52 = component[22].klass;
			//                                                                                                                                                                                                                                                                                                     if ( v52 )
			//                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                       LOBYTE(v52._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                         v6 = component[22].klass;
			//                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                             v53 = component[22].monitor;
			//                                                                                                                                                                                                                                                                                                             if ( v53 )
			//                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                               *((_BYTE *)v53 + 16) = 1;
			//                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                 v6 = component[22].monitor;
			//                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                     v54 = component[23].klass;
			//                                                                                                                                                                                                                                                                                                                     if ( v54 )
			//                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                       LOBYTE(v54._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                         v6 = component[23].klass;
			//                                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                             v55 = component[23].monitor;
			//                                                                                                                                                                                                                                                                                                                             if ( v55 )
			//                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                               *((_BYTE *)v55 + 16) = 1;
			//                                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                 v6 = component[23].monitor;
			//                                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                     v56 = component[26].klass;
			//                                                                                                                                                                                                                                                                                                                                     if ( v56 )
			//                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                       LOBYTE(v56._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                         v6 = component[26].klass;
			//                                                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                           color = (Vector4)this.fields._highlightColor;
			//                                                                                                                                                                                                                                                                                                                                           sub_18004EA90(11LL, v6, &color);
			//                                                                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                             v57 = component[26].monitor;
			//                                                                                                                                                                                                                                                                                                                                             if ( v57 )
			//                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                               *((_BYTE *)v57 + 16) = 1;
			//                                                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                 v6 = component[26].monitor;
			//                                                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                   color = (Vector4)this.fields._highlightColorBeam;
			//                                                                                                                                                                                                                                                                                                                                                   sub_18004EA90(11LL, v6, &color);
			//                                                                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                     v58 = component[27].klass;
			//                                                                                                                                                                                                                                                                                                                                                     if ( v58 )
			//                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                       LOBYTE(v58._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                         v6 = component[27].klass;
			//                                                                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                           color = this.fields._boxPosition1;
			//                                                                                                                                                                                                                                                                                                                                                           sub_18048EDCC(11LL, v6, &color);
			//                                                                                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                             v59 = component[27].monitor;
			//                                                                                                                                                                                                                                                                                                                                                             if ( v59 )
			//                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                               *((_BYTE *)v59 + 16) = 1;
			//                                                                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                 v6 = component[27].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                   color = this.fields._boxPosition2;
			//                                                                                                                                                                                                                                                                                                                                                                   sub_18048EDCC(11LL, v6, &color);
			//                                                                                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                                     v60 = component[28].klass;
			//                                                                                                                                                                                                                                                                                                                                                                     if ( v60 )
			//                                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                                       LOBYTE(v60._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                                         v6 = component[28].klass;
			//                                                                                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                                           color = this.fields._boxPosition3;
			//                                                                                                                                                                                                                                                                                                                                                                           sub_18048EDCC(11LL, v6, &color);
			//                                                                                                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                                             v61 = component[24].klass;
			//                                                                                                                                                                                                                                                                                                                                                                             if ( v61 )
			//                                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                                               LOBYTE(v61._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                                 v6 = component[24].klass;
			//                                                                                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                                                     v62 = component[24].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                     if ( v62 )
			//                                                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                                                       *((_BYTE *)v62 + 16) = 1;
			//                                                                                                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                                                         v6 = component[24].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                                                                                           if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                                                             v63 = component[25].klass;
			//                                                                                                                                                                                                                                                                                                                                                                                             if ( v63 )
			//                                                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                                                               LOBYTE(v63._0.name) = 1;
			//                                                                                                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                                                 v6 = component[25].klass;
			//                                                                                                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                                                                                                   if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                                                                     v64 = component[25].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                     if ( v64 )
			//                                                                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                                                                       *((_BYTE *)v64 + 16) = 1;
			//                                                                                                                                                                                                                                                                                                                                                                                                       if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                                                                         v6 = component[25].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                         if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                                                                           sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                                                                                                           if ( this.fields._ShouldIgnorePostExposure )
			//                                                                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                                                                               klass = component[28].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                               if ( klass )
			//                                                                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                                                                 klass[16] = 1;
			//                                                                                                                                                                                                                                                                                                                                                                                                                 v6 = component;
			//                                                                                                                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                                                                   v6 = component[28].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                                   if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                                                     goto LABEL_235;
			//                                                                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                                                                           else if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                                                                             v6 = component[28].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                             if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                                                                               v6[16] = 0;
			//                                                                                                                                                                                                                                                                                                                                                                                                               if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                                                                 v6 = component[28].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                                 if ( v6 )
			//                                                                                                                                                                                                                                                                                                                                                                                                                 {
			// LABEL_235:
			//                                                                                                                                                                                                                                                                                                                                                                                                                   sub_180042C50(11LL, v6);
			//                                                                                                                                                                                                                                                                                                                                                                                                                   return;
			//                                                                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                               }
			//                                                                                                                                                                                                             }
			//                                                                                                                                                                                                           }
			//                                                                                                                                                                                                         }
			//                                                                                                                                                                                                       }
			//                                                                                                                                                                                                     }
			//                                                                                                                                                                                                   }
			//                                                                                                                                                                                                 }
			//                                                                                                                                                                                               }
			//                                                                                                                                                                                             }
			//                                                                                                                                                                                           }
			//                                                                                                                                                                                         }
			//                                                                                                                                                                                       }
			//                                                                                                                                                                                     }
			//                                                                                                                                                                                   }
			//                                                                                                                                                                                 }
			//                                                                                                                                                                               }
			//                                                                                                                                                                             }
			//                                                                                                                                                                           }
			//                                                                                                                                                                         }
			//                                                                                                                                                                       }
			//                                                                                                                                                                     }
			//                                                                                                                                                                   }
			//                                                                                                                                                                 }
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
			// LABEL_242:
			//       sub_180B536AC(klass, v6);
			//     }
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPScanLine::ResetByVolumeProfile(
			//         VFXPPScanLine *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   void *v5; // rdx
			//   Object__Class *klass; // rcx
			//   Object__Class *v7; // rax
			//   MethodInfo *v8; // r8
			//   MonitorData *monitor; // rax
			//   Vector4 *v10; // rax
			//   __int64 v11; // r9
			//   MonitorData *v12; // rax
			//   Vector4 *one; // rax
			//   Object__Class *v14; // rax
			//   Object__Class *v15; // rax
			//   MonitorData *v16; // rax
			//   Object__Class *v17; // rax
			//   MonitorData *v18; // rax
			//   Object__Class *v19; // rax
			//   MonitorData *v20; // rax
			//   Object__Class *v21; // rax
			//   MonitorData *v22; // rax
			//   Object__Class *v23; // rax
			//   MonitorData *v24; // rax
			//   MonitorData *v25; // rax
			//   Object__Class *v26; // rax
			//   MonitorData *v27; // rax
			//   Object__Class *v28; // rax
			//   MonitorData *v29; // rax
			//   Object__Class *v30; // rax
			//   Object__Class *v31; // rax
			//   MonitorData *v32; // rax
			//   Object__Class *v33; // rax
			//   MonitorData *v34; // rax
			//   Object__Class *v35; // rax
			//   MonitorData *v36; // rax
			//   Object__Class *v37; // rax
			//   MonitorData *v38; // rax
			//   Object__Class *v39; // rax
			//   MonitorData *v40; // rax
			//   Object__Class *v41; // rax
			//   MonitorData *v42; // rax
			//   Object__Class *v43; // rax
			//   MonitorData *v44; // rax
			//   Object__Class *v45; // rax
			//   MonitorData *v46; // rax
			//   Object__Class *v47; // rax
			//   MonitorData *v48; // rax
			//   Object__Class *v49; // rax
			//   Vector4 *v50; // rax
			//   MonitorData *v51; // rax
			//   Vector4 *v52; // rax
			//   MethodInfo *v53; // r8
			//   Object__Class *v54; // rax
			//   Vector4 *v55; // rax
			//   __int64 v56; // r9
			//   MethodInfo *v57; // r8
			//   MonitorData *v58; // rax
			//   Vector4 *v59; // rax
			//   __int64 v60; // r9
			//   MethodInfo *v61; // r8
			//   Object__Class *v62; // rax
			//   Vector4 *v63; // rax
			//   __int64 v64; // r9
			//   Object__Class *v65; // rax
			//   MonitorData *v66; // rax
			//   Object__Class *v67; // rax
			//   MonitorData *v68; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v70; // [rsp+20h] [rbp-40h] BYREF
			//   Vector4 v71; // [rsp+30h] [rbp-30h] BYREF
			//   Object *component; // [rsp+88h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D91942F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGScanLine>);
			//     byte_18D91942F = 1;
			//   }
			//   component = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2117, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//       return;
			//     if ( volumeProfile )
			//     {
			//       if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//               volumeProfile,
			//               &component,
			//               MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGScanLine>) )
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
			//                           monitor = component[3].monitor;
			//                           if ( monitor )
			//                           {
			//                             *((_BYTE *)monitor + 16) = 0;
			//                             if ( component )
			//                             {
			//                               v70.z = 0.0;
			//                               *(_QWORD *)&v70.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                               v10 = UnityEngine::Vector4::op_Implicit(&v71, (Vector3 *)&v70, v8);
			//                               if ( v11 )
			//                               {
			//                                 v70 = *v10;
			//                                 sub_18048EDCC(11LL, v11, &v70);
			//                                 if ( component )
			//                                 {
			//                                   v12 = component[4].monitor;
			//                                   if ( v12 )
			//                                   {
			//                                     *((_BYTE *)v12 + 16) = 0;
			//                                     if ( component )
			//                                     {
			//                                       one = UnityEngine::Vector4::get_one(&v71, (MethodInfo *)component[4].monitor);
			//                                       if ( v5 )
			//                                       {
			//                                         v70 = *one;
			//                                         sub_18004EA90(11LL, v5, &v70);
			//                                         if ( component )
			//                                         {
			//                                           v14 = component[5].klass;
			//                                           if ( v14 )
			//                                           {
			//                                             LOBYTE(v14._0.name) = 0;
			//                                             if ( component )
			//                                             {
			//                                               v5 = component[5].klass;
			//                                               if ( v5 )
			//                                               {
			//                                                 sub_180042C50(11LL, v5);
			//                                                 if ( component )
			//                                                 {
			//                                                   v15 = component[6].klass;
			//                                                   if ( v15 )
			//                                                   {
			//                                                     LOBYTE(v15._0.name) = 0;
			//                                                     if ( component )
			//                                                     {
			//                                                       v5 = component[6].klass;
			//                                                       if ( v5 )
			//                                                       {
			//                                                         sub_180086B00(klass, v5, 0LL);
			//                                                         if ( component )
			//                                                         {
			//                                                           v16 = component[7].monitor;
			//                                                           if ( v16 )
			//                                                           {
			//                                                             *((_BYTE *)v16 + 16) = 0;
			//                                                             if ( component )
			//                                                             {
			//                                                               v5 = component[7].monitor;
			//                                                               if ( v5 )
			//                                                               {
			//                                                                 sub_180042C50(11LL, v5);
			//                                                                 if ( component )
			//                                                                 {
			//                                                                   v17 = component[8].klass;
			//                                                                   if ( v17 )
			//                                                                   {
			//                                                                     LOBYTE(v17._0.name) = 0;
			//                                                                     if ( component )
			//                                                                     {
			//                                                                       v5 = component[8].klass;
			//                                                                       if ( v5 )
			//                                                                       {
			//                                                                         sub_180042C50(11LL, v5);
			//                                                                         if ( component )
			//                                                                         {
			//                                                                           v18 = component[8].monitor;
			//                                                                           if ( v18 )
			//                                                                           {
			//                                                                             *((_BYTE *)v18 + 16) = 0;
			//                                                                             if ( component )
			//                                                                             {
			//                                                                               v5 = component[8].monitor;
			//                                                                               if ( v5 )
			//                                                                               {
			//                                                                                 sub_180042C50(11LL, v5);
			//                                                                                 if ( component )
			//                                                                                 {
			//                                                                                   v19 = component[9].klass;
			//                                                                                   if ( v19 )
			//                                                                                   {
			//                                                                                     LOBYTE(v19._0.name) = 0;
			//                                                                                     if ( component )
			//                                                                                     {
			//                                                                                       v5 = component[9].klass;
			//                                                                                       if ( v5 )
			//                                                                                       {
			//                                                                                         sub_180042C50(11LL, v5);
			//                                                                                         if ( component )
			//                                                                                         {
			//                                                                                           v20 = component[9].monitor;
			//                                                                                           if ( v20 )
			//                                                                                           {
			//                                                                                             *((_BYTE *)v20 + 16) = 0;
			//                                                                                             if ( component )
			//                                                                                             {
			//                                                                                               v5 = component[9].monitor;
			//                                                                                               if ( v5 )
			//                                                                                               {
			//                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                 if ( component )
			//                                                                                                 {
			//                                                                                                   v21 = component[10].klass;
			//                                                                                                   if ( v21 )
			//                                                                                                   {
			//                                                                                                     LOBYTE(v21._0.name) = 0;
			//                                                                                                     if ( component )
			//                                                                                                     {
			//                                                                                                       v5 = component[10].klass;
			//                                                                                                       if ( v5 )
			//                                                                                                       {
			//                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                         if ( component )
			//                                                                                                         {
			//                                                                                                           v22 = component[10].monitor;
			//                                                                                                           if ( v22 )
			//                                                                                                           {
			//                                                                                                             *((_BYTE *)v22 + 16) = 0;
			//                                                                                                             if ( component )
			//                                                                                                             {
			//                                                                                                               v5 = component[10].monitor;
			//                                                                                                               if ( v5 )
			//                                                                                                               {
			//                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                 if ( component )
			//                                                                                                                 {
			//                                                                                                                   v23 = component[11].klass;
			//                                                                                                                   if ( v23 )
			//                                                                                                                   {
			//                                                                                                                     LOBYTE(v23._0.name) = 0;
			//                                                                                                                     if ( component )
			//                                                                                                                     {
			//                                                                                                                       v5 = component[11].klass;
			//                                                                                                                       if ( v5 )
			//                                                                                                                       {
			//                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                         if ( component )
			//                                                                                                                         {
			//                                                                                                                           v24 = component[11].monitor;
			//                                                                                                                           if ( v24 )
			//                                                                                                                           {
			//                                                                                                                             *((_BYTE *)v24 + 16) = 0;
			//                                                                                                                             if ( component )
			//                                                                                                                             {
			//                                                                                                                               v5 = component[11].monitor;
			//                                                                                                                               if ( v5 )
			//                                                                                                                               {
			//                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                 if ( component )
			//                                                                                                                                 {
			//                                                                                                                                   v25 = component[12].monitor;
			//                                                                                                                                   if ( v25 )
			//                                                                                                                                   {
			//                                                                                                                                     *((_BYTE *)v25 + 16) = 0;
			//                                                                                                                                     if ( component )
			//                                                                                                                                     {
			//                                                                                                                                       v5 = component[12].monitor;
			//                                                                                                                                       if ( v5 )
			//                                                                                                                                       {
			//                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                         if ( component )
			//                                                                                                                                         {
			//                                                                                                                                           v26 = component[13].klass;
			//                                                                                                                                           if ( v26 )
			//                                                                                                                                           {
			//                                                                                                                                             LOBYTE(v26._0.name) = 0;
			//                                                                                                                                             if ( component )
			//                                                                                                                                             {
			//                                                                                                                                               v5 = component[13].klass;
			//                                                                                                                                               if ( v5 )
			//                                                                                                                                               {
			//                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                 if ( component )
			//                                                                                                                                                 {
			//                                                                                                                                                   v27 = component[13].monitor;
			//                                                                                                                                                   if ( v27 )
			//                                                                                                                                                   {
			//                                                                                                                                                     *((_BYTE *)v27 + 16) = 0;
			//                                                                                                                                                     if ( component )
			//                                                                                                                                                     {
			//                                                                                                                                                       v5 = component[13].monitor;
			//                                                                                                                                                       if ( v5 )
			//                                                                                                                                                       {
			//                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                         if ( component )
			//                                                                                                                                                         {
			//                                                                                                                                                           v28 = component[14].klass;
			//                                                                                                                                                           if ( v28 )
			//                                                                                                                                                           {
			//                                                                                                                                                             LOBYTE(v28._0.name) = 0;
			//                                                                                                                                                             if ( component )
			//                                                                                                                                                             {
			//                                                                                                                                                               v5 = component[14].klass;
			//                                                                                                                                                               if ( v5 )
			//                                                                                                                                                               {
			//                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                 if ( component )
			//                                                                                                                                                                 {
			//                                                                                                                                                                   v29 = component[14].monitor;
			//                                                                                                                                                                   if ( v29 )
			//                                                                                                                                                                   {
			//                                                                                                                                                                     *((_BYTE *)v29 + 16) = 0;
			//                                                                                                                                                                     if ( component )
			//                                                                                                                                                                     {
			//                                                                                                                                                                       v5 = component[14].monitor;
			//                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                       {
			//                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                         if ( component )
			//                                                                                                                                                                         {
			//                                                                                                                                                                           v30 = component[12].klass;
			//                                                                                                                                                                           if ( v30 )
			//                                                                                                                                                                           {
			//                                                                                                                                                                             LOBYTE(v30._0.name) = 0;
			//                                                                                                                                                                             if ( component )
			//                                                                                                                                                                             {
			//                                                                                                                                                                               v5 = component[12].klass;
			//                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                               {
			//                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                 {
			//                                                                                                                                                                                   v31 = component[15].klass;
			//                                                                                                                                                                                   if ( v31 )
			//                                                                                                                                                                                   {
			//                                                                                                                                                                                     LOBYTE(v31._0.name) = 0;
			//                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                     {
			//                                                                                                                                                                                       v5 = component[15].klass;
			//                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                       {
			//                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                         {
			//                                                                                                                                                                                           v32 = component[15].monitor;
			//                                                                                                                                                                                           if ( v32 )
			//                                                                                                                                                                                           {
			//                                                                                                                                                                                             *((_BYTE *)v32 + 16) = 0;
			//                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                             {
			//                                                                                                                                                                                               v5 = component[15].monitor;
			//                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                               {
			//                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                 {
			//                                                                                                                                                                                                   v33 = component[16].klass;
			//                                                                                                                                                                                                   if ( v33 )
			//                                                                                                                                                                                                   {
			//                                                                                                                                                                                                     LOBYTE(v33._0.name) = 0;
			//                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                     {
			//                                                                                                                                                                                                       v5 = component[16].klass;
			//                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                       {
			//                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                         {
			//                                                                                                                                                                                                           v34 = component[16].monitor;
			//                                                                                                                                                                                                           if ( v34 )
			//                                                                                                                                                                                                           {
			//                                                                                                                                                                                                             *((_BYTE *)v34 + 16) = 0;
			//                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                             {
			//                                                                                                                                                                                                               v5 = component[16].monitor;
			//                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                   v35 = component[17].klass;
			//                                                                                                                                                                                                                   if ( v35 )
			//                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                     LOBYTE(v35._0.name) = 0;
			//                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                       v5 = component[17].klass;
			//                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                           v36 = component[17].monitor;
			//                                                                                                                                                                                                                           if ( v36 )
			//                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                             *((_BYTE *)v36 + 16) = 0;
			//                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                               v5 = component[17].monitor;
			//                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                   v37 = component[18].klass;
			//                                                                                                                                                                                                                                   if ( v37 )
			//                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                     LOBYTE(v37._0.name) = 0;
			//                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                       v5 = component[18].klass;
			//                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                           v38 = component[18].monitor;
			//                                                                                                                                                                                                                                           if ( v38 )
			//                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                             *((_BYTE *)v38 + 16) = 0;
			//                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                               v5 = component[18].monitor;
			//                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                   v39 = component[19].klass;
			//                                                                                                                                                                                                                                                   if ( v39 )
			//                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                     LOBYTE(v39._0.name) = 0;
			//                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                       v5 = component[19].klass;
			//                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                           v40 = component[19].monitor;
			//                                                                                                                                                                                                                                                           if ( v40 )
			//                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                             *((_BYTE *)v40 + 16) = 0;
			//                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                               v5 = component[19].monitor;
			//                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                   v41 = component[20].klass;
			//                                                                                                                                                                                                                                                                   if ( v41 )
			//                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                     LOBYTE(v41._0.name) = 0;
			//                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                       v5 = component[20].klass;
			//                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                           v42 = component[20].monitor;
			//                                                                                                                                                                                                                                                                           if ( v42 )
			//                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                             *((_BYTE *)v42 + 16) = 0;
			//                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                               v5 = component[20].monitor;
			//                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                   v43 = component[21].klass;
			//                                                                                                                                                                                                                                                                                   if ( v43 )
			//                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                     LOBYTE(v43._0.name) = 0;
			//                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                       v5 = component[21].klass;
			//                                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                           v44 = component[21].monitor;
			//                                                                                                                                                                                                                                                                                           if ( v44 )
			//                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                             *((_BYTE *)v44 + 16) = 0;
			//                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                               v5 = component[21].monitor;
			//                                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                   v45 = component[22].klass;
			//                                                                                                                                                                                                                                                                                                   if ( v45 )
			//                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                     LOBYTE(v45._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                       v5 = component[22].klass;
			//                                                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                           v46 = component[22].monitor;
			//                                                                                                                                                                                                                                                                                                           if ( v46 )
			//                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                             *((_BYTE *)v46 + 16) = 0;
			//                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                               v5 = component[22].monitor;
			//                                                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                   v47 = component[23].klass;
			//                                                                                                                                                                                                                                                                                                                   if ( v47 )
			//                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                     LOBYTE(v47._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                       v5 = component[23].klass;
			//                                                                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                           v48 = component[23].monitor;
			//                                                                                                                                                                                                                                                                                                                           if ( v48 )
			//                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                             *((_BYTE *)v48 + 16) = 0;
			//                                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                               v5 = component[23].monitor;
			//                                                                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                   v49 = component[26].klass;
			//                                                                                                                                                                                                                                                                                                                                   if ( v49 )
			//                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                     LOBYTE(v49._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                       v50 = UnityEngine::Vector4::get_one(&v71, (MethodInfo *)component[26].klass);
			//                                                                                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                         v70 = *v50;
			//                                                                                                                                                                                                                                                                                                                                         sub_18004EA90(11LL, v5, &v70);
			//                                                                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                           v51 = component[26].monitor;
			//                                                                                                                                                                                                                                                                                                                                           if ( v51 )
			//                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                             *((_BYTE *)v51 + 16) = 0;
			//                                                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                               v52 = UnityEngine::Vector4::get_one(&v71, (MethodInfo *)component[26].monitor);
			//                                                                                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                 v70 = *v52;
			//                                                                                                                                                                                                                                                                                                                                                 sub_18004EA90(11LL, v5, &v70);
			//                                                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                   v54 = component[27].klass;
			//                                                                                                                                                                                                                                                                                                                                                   if ( v54 )
			//                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                     LOBYTE(v54._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                       v70.z = 0.0;
			//                                                                                                                                                                                                                                                                                                                                                       *(_QWORD *)&v70.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                                                                                                                                                                                                                                                                                                                                       v55 = UnityEngine::Vector4::op_Implicit(&v71, (Vector3 *)&v70, v53);
			//                                                                                                                                                                                                                                                                                                                                                       if ( v56 )
			//                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                         v70 = *v55;
			//                                                                                                                                                                                                                                                                                                                                                         sub_18048EDCC(11LL, v56, &v70);
			//                                                                                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                           v58 = component[27].monitor;
			//                                                                                                                                                                                                                                                                                                                                                           if ( v58 )
			//                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                             *((_BYTE *)v58 + 16) = 0;
			//                                                                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                               v70.z = 0.0;
			//                                                                                                                                                                                                                                                                                                                                                               *(_QWORD *)&v70.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                                                                                                                                                                                                                                                                                                                                               v59 = UnityEngine::Vector4::op_Implicit(&v71, (Vector3 *)&v70, v57);
			//                                                                                                                                                                                                                                                                                                                                                               if ( v60 )
			//                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                 v70 = *v59;
			//                                                                                                                                                                                                                                                                                                                                                                 sub_18048EDCC(11LL, v60, &v70);
			//                                                                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                   v62 = component[28].klass;
			//                                                                                                                                                                                                                                                                                                                                                                   if ( v62 )
			//                                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                                     LOBYTE(v62._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                                       v70.z = 0.0;
			//                                                                                                                                                                                                                                                                                                                                                                       *(_QWORD *)&v70.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                                                                                                                                                                                                                                                                                                                                                                       v63 = UnityEngine::Vector4::op_Implicit(&v71, (Vector3 *)&v70, v61);
			//                                                                                                                                                                                                                                                                                                                                                                       if ( v64 )
			//                                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                                         v70 = *v63;
			//                                                                                                                                                                                                                                                                                                                                                                         sub_18048EDCC(11LL, v64, &v70);
			//                                                                                                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                                           v65 = component[24].klass;
			//                                                                                                                                                                                                                                                                                                                                                                           if ( v65 )
			//                                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                                             LOBYTE(v65._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                                               v5 = component[24].klass;
			//                                                                                                                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                                   v66 = component[24].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                   if ( v66 )
			//                                                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                                                     *((_BYTE *)v66 + 16) = 0;
			//                                                                                                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                                                       v5 = component[24].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                                                                                         if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                         {
			//                                                                                                                                                                                                                                                                                                                                                                                           v67 = component[25].klass;
			//                                                                                                                                                                                                                                                                                                                                                                                           if ( v67 )
			//                                                                                                                                                                                                                                                                                                                                                                                           {
			//                                                                                                                                                                                                                                                                                                                                                                                             LOBYTE(v67._0.name) = 0;
			//                                                                                                                                                                                                                                                                                                                                                                                             if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                             {
			//                                                                                                                                                                                                                                                                                                                                                                                               v5 = component[25].klass;
			//                                                                                                                                                                                                                                                                                                                                                                                               if ( v5 )
			//                                                                                                                                                                                                                                                                                                                                                                                               {
			//                                                                                                                                                                                                                                                                                                                                                                                                 sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                                                                                                 if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                 {
			//                                                                                                                                                                                                                                                                                                                                                                                                   v68 = component[25].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                   if ( v68 )
			//                                                                                                                                                                                                                                                                                                                                                                                                   {
			//                                                                                                                                                                                                                                                                                                                                                                                                     *((_BYTE *)v68 + 16) = 0;
			//                                                                                                                                                                                                                                                                                                                                                                                                     if ( component )
			//                                                                                                                                                                                                                                                                                                                                                                                                     {
			//                                                                                                                                                                                                                                                                                                                                                                                                       v5 = component[25].monitor;
			//                                                                                                                                                                                                                                                                                                                                                                                                       if ( v5 )
			//                                                                                                                                                                                                                                                                                                                                                                                                       {
			//                                                                                                                                                                                                                                                                                                                                                                                                         sub_180042C50(11LL, v5);
			//                                                                                                                                                                                                                                                                                                                                                                                                         return;
			//                                                                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                                               }
			//                                                                                                                                                                                                                             }
			//                                                                                                                                                                                                                           }
			//                                                                                                                                                                                                                         }
			//                                                                                                                                                                                                                       }
			//                                                                                                                                                                                                                     }
			//                                                                                                                                                                                                                   }
			//                                                                                                                                                                                                                 }
			//                                                                                                                                                                                                               }
			//                                                                                                                                                                                                             }
			//                                                                                                                                                                                                           }
			//                                                                                                                                                                                                         }
			//                                                                                                                                                                                                       }
			//                                                                                                                                                                                                     }
			//                                                                                                                                                                                                   }
			//                                                                                                                                                                                                 }
			//                                                                                                                                                                                               }
			//                                                                                                                                                                                             }
			//                                                                                                                                                                                           }
			//                                                                                                                                                                                         }
			//                                                                                                                                                                                       }
			//                                                                                                                                                                                     }
			//                                                                                                                                                                                   }
			//                                                                                                                                                                                 }
			//                                                                                                                                                                               }
			//                                                                                                                                                                             }
			//                                                                                                                                                                           }
			//                                                                                                                                                                         }
			//                                                                                                                                                                       }
			//                                                                                                                                                                     }
			//                                                                                                                                                                   }
			//                                                                                                                                                                 }
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
			// LABEL_202:
			//     sub_180B536AC(klass, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2117, 0LL);
			//   if ( !Patch )
			//     goto LABEL_202;
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
			// bool HG::Rendering::Runtime::VFXPPScanLine::IsActive(VFXPPScanLine *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2118, 0LL) )
			//     return this.fields._interval != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2118, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void SetCenterPos(Vector4 pos)
		{
			// // Void SetCenterPos(Vector4)
			// void HG::Rendering::Runtime::VFXPPScanLine::SetCenterPos(VFXPPScanLine *this, Vector4 *pos, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2119, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2119, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = *pos;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_783(Patch, (Object *)this, &v8, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._centerPos = *pos;
			//   }
			// }
			// 
		}

		public void ResetTreasureHuntPos()
		{
			// // Void ResetTreasureHuntPos()
			// void HG::Rendering::Runtime::VFXPPScanLine::ResetTreasureHuntPos(VFXPPScanLine *this, MethodInfo *method)
			// {
			//   TileBase *v3; // rdx
			//   Vector3Int *v4; // r8
			//   ITilemap *v5; // r9
			//   TileBase *v6; // rdx
			//   Vector3Int *v7; // r8
			//   ITilemap *v8; // r9
			//   TileBase *v9; // rdx
			//   Vector3Int *v10; // r8
			//   ITilemap *v11; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   TileAnimationData v15; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2115, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2115, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields._boxPosition1 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                              &v15,
			//                                                                              v3,
			//                                                                              v4,
			//                                                                              v5,
			//                                                                              (MethodInfo *)v15.m_AnimatedSprites));
			//     this.fields._boxPosition2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                              &v15,
			//                                                                              v6,
			//                                                                              v7,
			//                                                                              v8,
			//                                                                              (MethodInfo *)v15.m_AnimatedSprites));
			//     this.fields._boxPosition3 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                              &v15,
			//                                                                              v9,
			//                                                                              v10,
			//                                                                              v11,
			//                                                                              (MethodInfo *)v15.m_AnimatedSprites));
			//   }
			// }
			// 
		}

		public void SetTreasureHuntPos(Vector3 position)
		{
			// // Void SetTreasureHuntPos(Vector3)
			// void HG::Rendering::Runtime::VFXPPScanLine::SetTreasureHuntPos(
			//         VFXPPScanLine *this,
			//         Vector3 *position,
			//         MethodInfo *method)
			// {
			//   float y; // xmm1_4
			//   float v6; // xmm1_4
			//   float v7; // xmm1_4
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector4 v11; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2120, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2120, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v8);
			//     z = position.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&position.x;
			//     v11.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, (Vector3 *)&v11, 0LL);
			//   }
			//   else if ( this.fields._boxPosition1.w == 0.0 )
			//   {
			//     y = position.y;
			//     v11.x = position.x;
			//     v11.z = position.z;
			//     v11.y = y;
			//     v11.w = 1.0;
			//     this.fields._boxPosition1 = v11;
			//   }
			//   else if ( this.fields._boxPosition2.w == 0.0 )
			//   {
			//     v6 = position.y;
			//     v11.x = position.x;
			//     v11.z = position.z;
			//     v11.y = v6;
			//     v11.w = 1.0;
			//     this.fields._boxPosition2 = v11;
			//   }
			//   else if ( this.fields._boxPosition3.w == 0.0 )
			//   {
			//     v7 = position.y;
			//     v11.x = position.x;
			//     v11.z = position.z;
			//     v11.y = v7;
			//     v11.w = 1.0;
			//     this.fields._boxPosition3 = v11;
			//   }
			// }
			// 
		}

		public void SetTreasureHuntDistance(float minDistance, float midDistance, float maxDistance)
		{
			// // Void SetTreasureHuntDistance(Single, Single, Single)
			// void HG::Rendering::Runtime::VFXPPScanLine::SetTreasureHuntDistance(
			//         VFXPPScanLine *this,
			//         float minDistance,
			//         float midDistance,
			//         float maxDistance,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2121, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2121, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(
			//       (ILFixDynamicMethodWrapper_7 *)Patch,
			//       (Object *)this,
			//       minDistance,
			//       midDistance,
			//       maxDistance,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields._boxDistMin = minDistance;
			//     this.fields._boxDistMid = midDistance;
			//     this.fields._boxDistMax = maxDistance;
			//   }
			// }
			// 
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
		private Vector4 _centerPos;

		[Range(0f, 50f)]
		[SerializeField]
		private float _progress;

		[SerializeField]
		[ColorUsage(true, true)]
		private Color _color;

		[Range(0.1f, 5f)]
		[SerializeField]
		private float _angleBlendFallOff;

		[SerializeField]
		private bool _useMaskTex;

		[SerializeField]
		private Texture2D _maskTex;

		[SerializeField]
		private Vector2 _maskTexTiling;

		[SerializeField]
		private Vector2 _maskTexOffset;

		[SerializeField]
		[Range(0f, 20f)]
		private float _interval;

		[Range(0f, 1f)]
		[SerializeField]
		private float _width;

		[SerializeField]
		[Range(0f, 20f)]
		private float _minDistance;

		[Range(0f, 100f)]
		[SerializeField]
		private float _maxDistance;

		[SerializeField]
		[Range(1f, 50f)]
		private float _smoothness;

		[Range(5f, 200f)]
		[SerializeField]
		private float _maxFade;

		[Range(0f, 2f)]
		[SerializeField]
		private float _distortScale;

		[Range(-5f, 5f)]
		[SerializeField]
		private float _distortIntensity;

		[SerializeField]
		[Range(0f, 5f)]
		private float _distortSpeed;

		[Header("角色周围扰动属性")]
		[SerializeField]
		[Space(5f)]
		[Range(0f, 10f)]
		private float _charDistortOuter;

		[Range(0f, 2f)]
		[SerializeField]
		private float _charDistortOnEdge;

		[SerializeField]
		[Range(0f, 10f)]
		private float _charBrightIntensity;

		[SerializeField]
		[Range(0f, 5f)]
		private float _charDistortScale;

		[Range(-5f, 5f)]
		[SerializeField]
		private float _charDistortIntensity;

		[Range(0f, 10f)]
		[SerializeField]
		private float _charDistortSpeed;

		[Header("扫描线高亮设置")]
		[SerializeField]
		[Range(0f, 1f)]
		[Space(5f)]
		private float _highlightFading;

		[SerializeField]
		[Range(0.2f, 15f)]
		private float _highlightWidth;

		[SerializeField]
		[Range(0f, 4f)]
		private float _highlightThickness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _nearHighlight;

		[SerializeField]
		[Range(0f, 1f)]
		private float _farHighlight;

		[SerializeField]
		[ColorUsage(true, true)]
		private Color _highlightColor;

		[SerializeField]
		[Range(1f, 10f)]
		private float _midBloom;

		[SerializeField]
		[Range(1f, 10f)]
		private float _maxBloom;

		[Header("光柱设置")]
		[Range(0f, 1f)]
		[Space(5f)]
		[SerializeField]
		private float _headHeight;

		[SerializeField]
		[Range(0f, 1f)]
		private float _tailHeight;

		[SerializeField]
		[Range(0f, 1.5f)]
		private float _headAlpha;

		[SerializeField]
		[Range(0f, 1.5f)]
		private float _tailAlpha;

		[SerializeField]
		[Range(-5f, 5f)]
		private float _flowingSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float _flowingStrength;

		[SerializeField]
		[ColorUsage(true, true)]
		private Color _highlightColorBeam;

		[Range(0.01f, 1f)]
		[SerializeField]
		private float _minHeight;

		[Range(0.01f, 1f)]
		[SerializeField]
		private float _midHeight;

		[SerializeField]
		[Range(0.01f, 1f)]
		private float _maxHeight;

		[Header("光片Mesh的高度")]
		[SerializeField]
		[Range(1f, 5f)]
		private float _meshHeight;

		[Space(5f)]
		[Header("扫描线&光柱进程")]
		[Range(0.01f, 20f)]
		[SerializeField]
		private float _showHighlight;

		[SerializeField]
		[Range(0.01f, 20f)]
		private float _showHighlightBeam;

		[Space(10f)]
		[SerializeField]
		private bool _ShouldIgnorePostExposure;

		[Space(5f)]
		[SerializeField]
		[Header("三段距离&宝箱坐标设置(仅供调整效果测试用,之后会隐藏)")]
		private Vector4 _boxPosition1;

		[SerializeField]
		private Vector4 _boxPosition2;

		[SerializeField]
		private Vector4 _boxPosition3;

		[SerializeField]
		private float _boxDistMin;

		[SerializeField]
		private float _boxDistMid;

		[SerializeField]
		private float _boxDistMax;
	}
}
