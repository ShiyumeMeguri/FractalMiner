using System;
using System.Runtime.InteropServices;
using HG.Rendering.Runtime;
using UnityEngine.Rendering;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct HGColorCurve : IEnvConfig
{
	// (get) Token: 0x06000003 RID: 3 RVA: 0x000025D8 File Offset: 0x000007D8
	// (set) Token: 0x06000004 RID: 4 RVA: 0x000025D0 File Offset: 0x000007D0
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

	public HGColorCurve(bool active)
	{
		// // HGColorCurve(Boolean)
		// void HGColorCurve::HGColorCurve(HGColorCurve *this, bool active, MethodInfo *method)
		// {
		//   __int64 v3; // r9
		//   __int64 v5; // rax
		//   __int64 v6; // rdx
		//   __int64 v7; // rcx
		//   __m128i si128; // xmm0
		//   Keyframe__Array *v9; // rbx
		//   __m128i v10; // xmm0
		//   TextureCurve *v11; // rsi
		//   OneofDescriptorProto *v12; // rdx
		//   FileDescriptor *v13; // r8
		//   MessageDescriptor *v14; // r9
		//   __int64 v15; // r8
		//   __int64 v16; // r9
		//   __int64 v17; // rax
		//   __m128i v18; // xmm0
		//   Keyframe__Array *v19; // rbx
		//   __m128i v20; // xmm0
		//   TextureCurve *v21; // rsi
		//   OneofDescriptorProto *v22; // rdx
		//   FileDescriptor *v23; // r8
		//   MessageDescriptor *v24; // r9
		//   __int64 v25; // r8
		//   __int64 v26; // r9
		//   __int64 v27; // rax
		//   __m128i v28; // xmm0
		//   Keyframe__Array *v29; // rbx
		//   __m128i v30; // xmm0
		//   TextureCurve *v31; // rsi
		//   OneofDescriptorProto *v32; // rdx
		//   FileDescriptor *v33; // r8
		//   MessageDescriptor *v34; // r9
		//   __int64 v35; // r8
		//   __int64 v36; // r9
		//   __int64 v37; // rax
		//   __m128i v38; // xmm0
		//   Keyframe__Array *v39; // rbx
		//   __m128i v40; // xmm0
		//   TextureCurve *v41; // rsi
		//   OneofDescriptorProto *v42; // rdx
		//   FileDescriptor *v43; // r8
		//   MessageDescriptor *v44; // r9
		//   __int64 v45; // r8
		//   __int64 v46; // r9
		//   Keyframe__Array *v47; // rsi
		//   TextureCurve *v48; // rbx
		//   OneofDescriptorProto *v49; // rdx
		//   FileDescriptor *v50; // r8
		//   MessageDescriptor *v51; // r9
		//   __int64 v52; // r8
		//   __int64 v53; // r9
		//   Keyframe__Array *v54; // rsi
		//   TextureCurve *v55; // rbx
		//   OneofDescriptorProto *v56; // rdx
		//   FileDescriptor *v57; // r8
		//   MessageDescriptor *v58; // r9
		//   __int64 v59; // r8
		//   __int64 v60; // r9
		//   Keyframe__Array *v61; // rsi
		//   TextureCurve *v62; // rbx
		//   OneofDescriptorProto *v63; // rdx
		//   FileDescriptor *v64; // r8
		//   MessageDescriptor *v65; // r9
		//   __int64 v66; // r8
		//   __int64 v67; // r9
		//   Keyframe__Array *v68; // rsi
		//   TextureCurve *v69; // rbx
		//   OneofDescriptorProto *v70; // rdx
		//   FileDescriptor *v71; // r8
		//   MessageDescriptor *v72; // r9
		//   String__Array *bounds; // [rsp+20h] [rbp-60h]
		//   String__Array *boundsa; // [rsp+20h] [rbp-60h]
		//   String__Array *boundsb; // [rsp+20h] [rbp-60h]
		//   String__Array *boundsc; // [rsp+20h] [rbp-60h]
		//   String__Array *boundsd; // [rsp+20h] [rbp-60h]
		//   String__Array *boundse; // [rsp+20h] [rbp-60h]
		//   String__Array *boundsf; // [rsp+20h] [rbp-60h]
		//   String__Array *boundsg; // [rsp+20h] [rbp-60h]
		//   MethodInfo *methoda; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methodb; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methodc; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methodd; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methode; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methodf; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methodg; // [rsp+28h] [rbp-58h]
		//   MethodInfo *methodh; // [rsp+28h] [rbp-58h]
		//   MethodInfo *v89; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v90; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v91; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v92; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v93; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v94; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v95; // [rsp+30h] [rbp-50h]
		//   MethodInfo *v96; // [rsp+30h] [rbp-50h]
		//   Vector2 v97; // [rsp+B8h] [rbp+38h] BYREF
		// 
		//   if ( !byte_18D8ED904 )
		//   {
		//     sub_18003C530(&TypeInfo::UnityEngine::Keyframe);
		//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::TextureCurve);
		//     byte_18D8ED904 = 1;
		//   }
		//   v5 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, method, v3);
		//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
		//   v9 = (Keyframe__Array *)v5;
		//   if ( !v5 )
		//     goto LABEL_24;
		//   if ( !*(_DWORD *)(v5 + 24)
		//     || (*(__m128i *)(v5 + 32) = si128,
		//         *(_QWORD *)(v5 + 48) = 0LL,
		//         v10 = _mm_load_si128((const __m128i *)&xmmword_18A357460),
		//         *(_DWORD *)(v5 + 56) = 0,
		//         *(_DWORD *)(v5 + 24) <= 1u) )
		//   {
		// LABEL_25:
		//     sub_180070270(v7, v6);
		//   }
		//   *(__m128i *)(v5 + 60) = v10;
		//   *(_QWORD *)(v5 + 76) = 0LL;
		//   *(_DWORD *)(v5 + 84) = 0;
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v11 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v11
		//     || (UnityEngine::Rendering::TextureCurve::TextureCurve(v11, v9, 0.0, 0, &v97, 0LL),
		//         this.master = v11,
		//         sub_1800054D0((OneofDescriptor *)this, v12, v13, v14, bounds, (String *)methoda, v89),
		//         v17 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v15, v16),
		//         v18 = _mm_load_si128((const __m128i *)&xmmword_18A357450),
		//         (v19 = (Keyframe__Array *)v17) == 0LL) )
		//   {
		// LABEL_24:
		//     sub_180B536AC(v7, v6);
		//   }
		//   if ( !*(_DWORD *)(v17 + 24) )
		//     goto LABEL_25;
		//   *(__m128i *)(v17 + 32) = v18;
		//   *(_QWORD *)(v17 + 48) = 0LL;
		//   v20 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
		//   *(_DWORD *)(v17 + 56) = 0;
		//   if ( *(_DWORD *)(v17 + 24) <= 1u )
		//     goto LABEL_25;
		//   *(__m128i *)(v17 + 60) = v20;
		//   *(_QWORD *)(v17 + 76) = 0LL;
		//   *(_DWORD *)(v17 + 84) = 0;
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v21 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v21 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v21, v19, 0.0, 0, &v97, 0LL);
		//   this.red = v21;
		//   sub_1800054D0((OneofDescriptor *)&this.red, v22, v23, v24, boundsa, (String *)methodb, v90);
		//   v27 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v25, v26);
		//   v28 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
		//   v29 = (Keyframe__Array *)v27;
		//   if ( !v27 )
		//     goto LABEL_24;
		//   if ( !*(_DWORD *)(v27 + 24) )
		//     goto LABEL_25;
		//   *(__m128i *)(v27 + 32) = v28;
		//   *(_QWORD *)(v27 + 48) = 0LL;
		//   v30 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
		//   *(_DWORD *)(v27 + 56) = 0;
		//   if ( *(_DWORD *)(v27 + 24) <= 1u )
		//     goto LABEL_25;
		//   *(__m128i *)(v27 + 60) = v30;
		//   *(_QWORD *)(v27 + 76) = 0LL;
		//   *(_DWORD *)(v27 + 84) = 0;
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v31 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v31 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v31, v29, 0.0, 0, &v97, 0LL);
		//   this.green = v31;
		//   sub_1800054D0((OneofDescriptor *)&this.green, v32, v33, v34, boundsb, (String *)methodc, v91);
		//   v37 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v35, v36);
		//   v38 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
		//   v39 = (Keyframe__Array *)v37;
		//   if ( !v37 )
		//     goto LABEL_24;
		//   if ( !*(_DWORD *)(v37 + 24) )
		//     goto LABEL_25;
		//   *(__m128i *)(v37 + 32) = v38;
		//   *(_QWORD *)(v37 + 48) = 0LL;
		//   v40 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
		//   *(_DWORD *)(v37 + 56) = 0;
		//   if ( *(_DWORD *)(v37 + 24) <= 1u )
		//     goto LABEL_25;
		//   *(__m128i *)(v37 + 60) = v40;
		//   *(_QWORD *)(v37 + 76) = 0LL;
		//   *(_DWORD *)(v37 + 84) = 0;
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v41 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v41 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v41, v39, 0.0, 0, &v97, 0LL);
		//   this.blue = v41;
		//   sub_1800054D0((OneofDescriptor *)&this.blue, v42, v43, v44, boundsc, (String *)methodd, v92);
		//   v47 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v45, v46);
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v48 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v48 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v48, v47, 0.5, 1, &v97, 0LL);
		//   this.hueVsHue = v48;
		//   sub_1800054D0((OneofDescriptor *)&this.hueVsHue, v49, v50, v51, boundsd, (String *)methode, v93);
		//   v54 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v52, v53);
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v55 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v55 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v55, v54, 0.5, 1, &v97, 0LL);
		//   this.hueVsSat = v55;
		//   sub_1800054D0((OneofDescriptor *)&this.hueVsSat, v56, v57, v58, boundse, (String *)methodf, v94);
		//   v61 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v59, v60);
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v62 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v62 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v62, v61, 0.5, 0, &v97, 0LL);
		//   this.satVsSat = v62;
		//   sub_1800054D0((OneofDescriptor *)&this.satVsSat, v63, v64, v65, boundsf, (String *)methodg, v95);
		//   v68 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v66, v67);
		//   v97 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		//   v69 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
		//   if ( !v69 )
		//     goto LABEL_24;
		//   UnityEngine::Rendering::TextureCurve::TextureCurve(v69, v68, 0.5, 0, &v97, 0LL);
		//   this.lumVsSat = v69;
		//   sub_1800054D0((OneofDescriptor *)&this.lumVsSat, v70, v71, v72, boundsg, (String *)methodh, v96);
		//   *(_QWORD *)&this.masterOverriding = 0LL;
		// }
		// 
	}

	public void Lerp<T>(ref T src, ref T dst, float t) where T : struct, IEnvConfig
	{
	}

	public TextureCurve master;

	public TextureCurve red;

	public TextureCurve green;

	public TextureCurve blue;

	public TextureCurve hueVsHue;

	public TextureCurve hueVsSat;

	public TextureCurve satVsSat;

	public TextureCurve lumVsSat;

	public bool masterOverriding;

	public bool redOverriding;

	public bool greenOverriding;

	public bool blueOverriding;

	public bool hueVsHueOverriding;

	public bool hueVsSatOverriding;

	public bool satVsSatOverriding;

	public bool lumVsSatOverriding;

	[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
	public static HGColorCurve defaultConfig;
}
