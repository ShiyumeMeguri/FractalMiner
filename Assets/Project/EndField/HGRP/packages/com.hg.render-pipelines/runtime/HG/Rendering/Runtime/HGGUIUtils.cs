using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class HGGUIUtils
	{
		internal static void DrawSheet(HGGUIUtils.GuiSheetContents sheetContents)
		{
			// // Void DrawSheet(HGGUIUtils+GuiSheetContents)
			// void HG::Rendering::Runtime::HGGUIUtils::DrawSheet(HGGUIUtils_GuiSheetContents *sheetContents, MethodInfo *method)
			// {
			//   Int32__Array *colWidths; // rdx
			//   float v4; // xmm7_4
			//   Texture2D *v5; // rcx
			//   __int64 v6; // rax
			//   Object_1 *s_sheetBackground; // rbx
			//   Texture2D *v8; // rax
			//   Texture2D *v9; // rbx
			//   OneofDescriptorProto *static_fields; // rdx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   __m128i si128; // xmm0
			//   float v14; // xmm3_4
			//   float x; // xmm0_4
			//   float v16; // xmm1_4
			//   Texture2D *v17; // rbx
			//   float v18; // xmm0_4
			//   float v19; // xmm2_4
			//   float v20; // xmm1_4
			//   HGGUIUtils__StaticFields *v21; // rcx
			//   int v22; // eax
			//   float v23; // xmm3_4
			//   __m128 y_low; // xmm2
			//   int v25; // eax
			//   float y; // xmm2_4
			//   Texture2D *v27; // rbx
			//   GUISkin *skin; // rax
			//   GUIStyle *m_label; // rbx
			//   GUIStyle *v30; // rax
			//   GUIStyle *v31; // r15
			//   MethodInfo *v32; // rdx
			//   Vector4 *one; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   GUIStyleState *v36; // r9
			//   int32_t i; // r14d
			//   float v38; // xmm7_4
			//   int32_t j; // esi
			//   String__Array_1 *contents; // rbx
			//   int v41; // eax
			//   __m128i v42; // xmm1
			//   Il2CppArrayBounds *bounds; // rax
			//   String *v44; // rbx
			//   __int64 v45; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v47; // [rsp+20h] [rbp-50h]
			//   String *v48; // [rsp+28h] [rbp-48h]
			//   Vector4 v49; // [rsp+30h] [rbp-40h] BYREF
			//   Vector4 v50; // [rsp+40h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9194B5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::GUIStyle);
			//     sub_18003C530(&TypeInfo::UnityEngine::GUI);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     byte_18D9194B5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2381, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2381, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)sheetContents, 0LL);
			//       return;
			//     }
			//     goto LABEL_40;
			//   }
			//   v4 = 0.0;
			//   v5 = 0LL;
			//   if ( !sheetContents )
			//     goto LABEL_40;
			//   while ( (int)v5 < sheetContents.fields.colNum )
			//   {
			//     colWidths = sheetContents.fields.colWidths;
			//     if ( !colWidths )
			//       goto LABEL_40;
			//     if ( (unsigned int)v5 >= colWidths.max_length.size )
			// LABEL_35:
			//       sub_180070270(v5, colWidths);
			//     v6 = (int)v5;
			//     v5 = (Texture2D *)(unsigned int)((_DWORD)v5 + 1);
			//     v4 = v4 + (float)colWidths.vector[v6];
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
			//   s_sheetBackground = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields.s_sheetBackground;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(s_sheetBackground, 0LL, 0LL) )
			//   {
			//     v8 = (Texture2D *)sub_180004920(TypeInfo::UnityEngine::Texture2D);
			//     v9 = v8;
			//     if ( !v8 )
			//       goto LABEL_40;
			//     UnityEngine::Texture2D::Texture2D(v8, 1, 1, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
			//     static_fields = (OneofDescriptorProto *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields;
			//     static_fields.klass = (OneofDescriptorProto__Class *)v9;
			//     sub_1800054D0(
			//       (OneofDescriptor *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields,
			//       static_fields,
			//       v11,
			//       v12,
			//       v47,
			//       v48,
			//       *(MethodInfo **)&v49.x);
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A357DF0);
			//     v5 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields.s_sheetBackground;
			//     if ( !v5 )
			//       goto LABEL_40;
			//     v50 = (Vector4)si128;
			//     UnityEngine::Texture2D::SetPixel(v5, 0, 0, (Color *)&v50, 0LL);
			//     v5 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields.s_sheetBackground;
			//     if ( !v5 )
			//       goto LABEL_40;
			//     UnityEngine::Texture2D::Apply(v5, 0LL);
			//   }
			//   if ( sheetContents.fields.displayRegion.x <= 0.0 || sheetContents.fields.displayRegion.y <= 0.0 )
			//   {
			//     v25 = sheetContents.fields.rowHeight * sheetContents.fields.rowNum;
			//     y = sheetContents.fields.topLeft.y;
			//     v50.x = sheetContents.fields.topLeft.x;
			//     v50.y = y;
			//     v50.z = v4;
			//     v50.w = (float)v25;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
			//     v27 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields.s_sheetBackground;
			//     sub_180002C70(TypeInfo::UnityEngine::GUI);
			//     UnityEngine::GUI::DrawTexture((Rect *)&v50, (Texture *)v27, 0LL);
			//   }
			//   else
			//   {
			//     v14 = sheetContents.fields.topLeft.y;
			//     x = sheetContents.fields.displayRegion.x;
			//     v16 = sheetContents.fields.displayRegion.y;
			//     v49.x = sheetContents.fields.topLeft.x;
			//     v49.y = v14;
			//     v49.z = x;
			//     v49.w = v16;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
			//     v17 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields.s_sheetBackground;
			//     sub_180002C70(TypeInfo::UnityEngine::GUI);
			//     v50 = v49;
			//     UnityEngine::GUI::DrawTexture((Rect *)&v50, (Texture *)v17, 0LL);
			//     v18 = sheetContents.fields.displayRegion.x;
			//     v19 = sheetContents.fields.topLeft.x;
			//     v20 = sheetContents.fields.displayRegion.y;
			//     v21 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields;
			//     *(_QWORD *)&v49.x = 0LL;
			//     v22 = sheetContents.fields.rowNum * sheetContents.fields.rowHeight;
			//     v23 = sheetContents.fields.topLeft.y;
			//     v50.z = v18;
			//     v50.x = v19;
			//     y_low = (__m128)LODWORD(v21.s_scrollPos.y);
			//     v50.w = v20;
			//     v50.y = v23;
			//     v49.z = v4;
			//     v49.w = (float)v22;
			//     TypeInfo::HG::Rendering::Runtime::HGGUIUtils.static_fields.s_scrollPos = UnityEngine::GUI::BeginScrollView(
			//                                                                                  (Rect *)&v50,
			//                                                                                  (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v21.s_scrollPos.x), y_low),
			//                                                                                  (Rect *)&v49,
			//                                                                                  0LL);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::GUI);
			//   skin = UnityEngine::GUI::get_skin(0LL);
			//   if ( !skin
			//     || (m_label = skin.fields.m_label,
			//         v30 = (GUIStyle *)sub_180004920(TypeInfo::UnityEngine::GUIStyle),
			//         (v31 = v30) == 0LL) )
			//   {
			// LABEL_40:
			//     sub_180B536AC(v5, colWidths);
			//   }
			//   UnityEngine::GUIStyle::GUIStyle(v30, m_label, 0LL);
			//   UnityEngine::GUIStyle::get_normal(v31, 0LL);
			//   one = UnityEngine::Vector4::get_one(&v50, v32);
			//   if ( !v36 )
			//     sub_180B536AC(v35, v34);
			//   v50 = *one;
			//   UnityEngine::GUIStyleState::set_textColor(v36, (Color *)&v50, 0LL);
			//   UnityEngine::GUIStyle::set_fontSize(v31, sheetContents.fields.fontSize, 0LL);
			//   UnityEngine::GUIStyle::set_richText(v31, 1, 0LL);
			//   UnityEngine::GUIStyle::set_wordWrap(v31, sheetContents.fields.useWordwrap, 0LL);
			//   for ( i = 0; i < sheetContents.fields.rowNum; ++i )
			//   {
			//     v38 = 0.0;
			//     for ( j = 0; j < sheetContents.fields.colNum; ++j )
			//     {
			//       v5 = (Texture2D *)sheetContents.fields.colWidths;
			//       if ( !v5 )
			//         goto LABEL_40;
			//       if ( (unsigned int)j >= LODWORD(v5[1].klass) )
			//         goto LABEL_35;
			//       contents = sheetContents.fields.contents;
			//       v41 = sheetContents.fields.rowHeight * i;
			//       v50.x = v38;
			//       v42 = _mm_cvtsi32_si128(*((_DWORD *)&v5[1].monitor + j));
			//       v50.y = (float)v41;
			//       v50.w = (float)sheetContents.fields.rowHeight;
			//       LODWORD(v50.z) = _mm_cvtepi32_ps(v42).m128_u32[0];
			//       if ( !contents )
			//         goto LABEL_40;
			//       bounds = contents.bounds;
			//       if ( (unsigned int)i >= LODWORD(bounds.length) || (unsigned int)j >= LODWORD(bounds[1].length) )
			//         goto LABEL_35;
			//       v44 = (String *)*((_QWORD *)&contents.vector[j] + bounds[1].length * i);
			//       sub_180002C70(TypeInfo::UnityEngine::GUI);
			//       v49 = v50;
			//       UnityEngine::GUI::Label((Rect *)&v49, v44, v31, 0LL);
			//       v5 = (Texture2D *)sheetContents.fields.colWidths;
			//       if ( !v5 )
			//         goto LABEL_40;
			//       if ( (unsigned int)j >= LODWORD(v5[1].klass) )
			//         goto LABEL_35;
			//       v45 = j;
			//       v38 = v38 + (float)*((int *)&v5[1].monitor + v45);
			//     }
			//   }
			//   if ( sheetContents.fields.displayRegion.x > 0.0 && sheetContents.fields.displayRegion.y > 0.0 )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::GUI);
			//     UnityEngine::GUI::EndScrollView(0LL);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Texture2D s_sheetBackground;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Vector2 s_scrollPos;

		internal class GuiSheetContents
		{
			public GuiSheetContents()
			{
				// // HGGUIUtils+GuiSheetContents()
				// void HG::Rendering::Runtime::HGGUIUtils::GuiSheetContents::GuiSheetContents(
				//         HGGUIUtils_GuiSheetContents *this,
				//         MethodInfo *method)
				// {
				//   this.fields.displayRegion.x = -1.0;
				//   this.fields.topLeft = 0LL;
				//   this.fields.displayRegion.y = -1.0;
				//   this.fields.fontSize = 24;
				// }
				// 
			}

			public Vector2 topLeft;

			public int rowNum;

			public int colNum;

			public int[] colWidths;

			public Vector2 displayRegion;

			public int rowHeight;

			public int fontSize;

			public bool useWordwrap;

			public string[,] contents;
		}
	}
}
