using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGGUIUtils // TypeDefIndex: 38108
	{
		// Fields
		private static Texture2D s_sheetBackground; // 0x00
		private static Vector2 s_scrollPos; // 0x08
	
		// Nested types
		internal class GuiSheetContents // TypeDefIndex: 38107
		{
			// Fields
			public Vector2 topLeft; // 0x10
			public int rowNum; // 0x18
			public int colNum; // 0x1C
			public int[] colWidths; // 0x20
			public Vector2 displayRegion; // 0x28
			public int rowHeight; // 0x30
			public int fontSize; // 0x34
			public bool useWordwrap; // 0x38
			public string[,] contents; // 0x40
	
			// Constructors
			public GuiSheetContents() {} // 0x0000000189B76914-0x0000000189B76934
			// HGGUIUtils+GuiSheetContents()
			void HG::Rendering::Runtime::HGGUIUtils::GuiSheetContents::GuiSheetContents(
			        HGGUIUtils_GuiSheetContents *this,
			        MethodInfo *method)
			{
			  this->fields.displayRegion.x = -1.0;
			  this->fields.topLeft = 0LL;
			  this->fields.displayRegion.y = -1.0;
			  this->fields.fontSize = 24;
			}
			
		}
	
		// Constructors
		static HGGUIUtils() {} // 0x0000000189B7A584-0x0000000189B7A5D0
		// HGGUIUtils()
		void HG::Rendering::Runtime::HGGUIUtils::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  HGGUIUtils__StaticFields *static_fields; // rcx
		  float v4; // r9d
		  MethodInfo *v5; // [rsp+20h] [rbp-8h]
		
		  TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_sheetBackground = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields, v1, v2, 0LL, v5);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields;
		  static_fields->s_scrollPos.x = v4;
		  static_fields->s_scrollPos.y = 0.0;
		}
		
	
		// Methods
		internal static void DrawSheet(GuiSheetContents sheetContents) {} // 0x0000000189B7A070-0x0000000189B7A584
		// Void DrawSheet(HGGUIUtils+GuiSheetContents)
		void HG::Rendering::Runtime::HGGUIUtils::DrawSheet(HGGUIUtils_GuiSheetContents *sheetContents, MethodInfo *method)
		{
		  Int32__Array *colWidths; // rdx
		  float v4; // xmm7_4
		  Texture2D *v5; // rcx
		  __int64 v6; // rax
		  Object_1 *s_sheetBackground; // rbx
		  Texture2D *v8; // rax
		  Type__Class *v9; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  __m128i si128; // xmm0
		  float v14; // xmm3_4
		  float x; // xmm0_4
		  float v16; // xmm1_4
		  Texture *v17; // rbx
		  float v18; // xmm0_4
		  float v19; // xmm2_4
		  float v20; // xmm1_4
		  HGGUIUtils__StaticFields *v21; // rcx
		  int v22; // eax
		  float v23; // xmm3_4
		  __m128 y_low; // xmm2
		  int v25; // eax
		  float y; // xmm2_4
		  Texture *v27; // rbx
		  GUISkin *skin; // rax
		  GUIStyle *m_label; // rbx
		  GUIStyle *v30; // rax
		  GUIStyle *v31; // r15
		  MethodInfo *v32; // rdx
		  Vector4 *one; // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  GUIStyleState *v36; // r9
		  int32_t i; // r14d
		  float v38; // xmm7_4
		  int32_t j; // esi
		  String__Array_1 *contents; // rbx
		  int v41; // eax
		  __m128i v42; // xmm1
		  Il2CppArrayBounds *bounds; // rax
		  String *v44; // rbx
		  __int64 v45; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v47; // [rsp+20h] [rbp-50h]
		  Vector4 v48; // [rsp+30h] [rbp-40h] BYREF
		  Vector4 v49; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2863, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2863, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)sheetContents, 0LL);
		      return;
		    }
		    goto LABEL_38;
		  }
		  v4 = 0.0;
		  v5 = 0LL;
		  if ( !sheetContents )
		    goto LABEL_38;
		  while ( (int)v5 < sheetContents->fields.colNum )
		  {
		    colWidths = sheetContents->fields.colWidths;
		    if ( !colWidths )
		      goto LABEL_38;
		    if ( (unsigned int)v5 >= colWidths->max_length.size )
		LABEL_33:
		      sub_1800D2AB0(v5, colWidths);
		    v6 = (int)v5;
		    v5 = (Texture2D *)(unsigned int)((_DWORD)v5 + 1);
		    v4 = v4 + (float)colWidths->vector[v6];
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
		  s_sheetBackground = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_sheetBackground;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(s_sheetBackground, 0LL, 0LL) )
		  {
		    v8 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		    v9 = (Type__Class *)v8;
		    if ( !v8 )
		      goto LABEL_38;
		    UnityEngine::Texture2D::Texture2D(v8, 1, 1, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
		    static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields;
		    static_fields->klass = v9;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields,
		      static_fields,
		      v11,
		      v12,
		      v47);
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959D60);
		    v5 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_sheetBackground;
		    if ( !v5 )
		      goto LABEL_38;
		    v49 = (Vector4)si128;
		    UnityEngine::Texture2D::SetPixel(v5, 0, 0, (Color *)&v49, 0LL);
		    v5 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_sheetBackground;
		    if ( !v5 )
		      goto LABEL_38;
		    UnityEngine::Texture2D::Apply(v5, 0LL);
		  }
		  if ( sheetContents->fields.displayRegion.x <= 0.0 || sheetContents->fields.displayRegion.y <= 0.0 )
		  {
		    v25 = sheetContents->fields.rowHeight * sheetContents->fields.rowNum;
		    y = sheetContents->fields.topLeft.y;
		    v49.x = sheetContents->fields.topLeft.x;
		    v49.y = y;
		    v49.z = v4;
		    v49.w = (float)v25;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
		    v27 = (Texture *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_sheetBackground;
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    UnityEngine::GUI::DrawTexture((Rect *)&v49, v27, 0LL);
		  }
		  else
		  {
		    v14 = sheetContents->fields.topLeft.y;
		    x = sheetContents->fields.displayRegion.x;
		    v16 = sheetContents->fields.displayRegion.y;
		    v48.x = sheetContents->fields.topLeft.x;
		    v48.y = v14;
		    v48.z = x;
		    v48.w = v16;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGUIUtils);
		    v17 = (Texture *)TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_sheetBackground;
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    v49 = v48;
		    UnityEngine::GUI::DrawTexture((Rect *)&v49, v17, 0LL);
		    v18 = sheetContents->fields.displayRegion.x;
		    v19 = sheetContents->fields.topLeft.x;
		    v20 = sheetContents->fields.displayRegion.y;
		    v21 = TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields;
		    *(_QWORD *)&v48.x = 0LL;
		    v22 = sheetContents->fields.rowNum * sheetContents->fields.rowHeight;
		    v23 = sheetContents->fields.topLeft.y;
		    v49.z = v18;
		    v49.x = v19;
		    y_low = (__m128)LODWORD(v21->s_scrollPos.y);
		    v49.w = v20;
		    v49.y = v23;
		    v48.z = v4;
		    v48.w = (float)v22;
		    TypeInfo::HG::Rendering::Runtime::HGGUIUtils->static_fields->s_scrollPos = UnityEngine::GUI::BeginScrollView(
		                                                                                 (Rect *)&v49,
		                                                                                 (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(v21->s_scrollPos.x), y_low),
		                                                                                 (Rect *)&v48,
		                                                                                 0LL);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::GUI);
		  skin = UnityEngine::GUI::get_skin(0LL);
		  if ( !skin
		    || (m_label = skin->fields.m_label,
		        v30 = (GUIStyle *)sub_18002C620(TypeInfo::UnityEngine::GUIStyle),
		        (v31 = v30) == 0LL) )
		  {
		LABEL_38:
		    sub_1800D8260(v5, colWidths);
		  }
		  UnityEngine::GUIStyle::GUIStyle(v30, m_label, 0LL);
		  UnityEngine::GUIStyle::get_normal(v31, 0LL);
		  one = UnityEngine::Vector4::get_one(&v49, v32);
		  if ( !v36 )
		    sub_1800D8260(v35, v34);
		  v49 = *one;
		  UnityEngine::GUIStyleState::set_textColor(v36, (Color *)&v49, 0LL);
		  UnityEngine::GUIStyle::set_fontSize(v31, sheetContents->fields.fontSize, 0LL);
		  UnityEngine::GUIStyle::set_richText(v31, 1, 0LL);
		  UnityEngine::GUIStyle::set_wordWrap(v31, sheetContents->fields.useWordwrap, 0LL);
		  for ( i = 0; i < sheetContents->fields.rowNum; ++i )
		  {
		    v38 = 0.0;
		    for ( j = 0; j < sheetContents->fields.colNum; ++j )
		    {
		      v5 = (Texture2D *)sheetContents->fields.colWidths;
		      if ( !v5 )
		        goto LABEL_38;
		      if ( (unsigned int)j >= LODWORD(v5[1].klass) )
		        goto LABEL_33;
		      contents = sheetContents->fields.contents;
		      v41 = sheetContents->fields.rowHeight * i;
		      v49.x = v38;
		      v42 = _mm_cvtsi32_si128(*((_DWORD *)&v5[1].monitor + j));
		      v49.y = (float)v41;
		      v49.w = (float)sheetContents->fields.rowHeight;
		      LODWORD(v49.z) = _mm_cvtepi32_ps(v42).m128_u32[0];
		      if ( !contents )
		        goto LABEL_38;
		      bounds = contents->bounds;
		      if ( (unsigned int)i >= LODWORD(bounds->length) || (unsigned int)j >= LODWORD(bounds[1].length) )
		        goto LABEL_33;
		      v44 = (String *)*((_QWORD *)&contents->vector[j] + bounds[1].length * i);
		      sub_1800036A0(TypeInfo::UnityEngine::GUI);
		      v48 = v49;
		      UnityEngine::GUI::Label((Rect *)&v48, v44, v31, 0LL);
		      v5 = (Texture2D *)sheetContents->fields.colWidths;
		      if ( !v5 )
		        goto LABEL_38;
		      if ( (unsigned int)j >= LODWORD(v5[1].klass) )
		        goto LABEL_33;
		      v45 = j;
		      v38 = v38 + (float)*((int *)&v5[1].monitor + v45);
		    }
		  }
		  if ( sheetContents->fields.displayRegion.x > 0.0 && sheetContents->fields.displayRegion.y > 0.0 )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::GUI);
		    UnityEngine::GUI::EndScrollView(0LL);
		  }
		}
		
	}
}
