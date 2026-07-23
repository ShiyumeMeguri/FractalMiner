using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class WaterSettings // TypeDefIndex: 38483
	{
		// Fields
		public const int SCREEN_SPACE_MESH_VERTEX_NUM = 16; // Metadata: 0x02303CEB
		public const int MAX_SCREEN_SPACE_MESH_NUM = 16; // Metadata: 0x02303CEC
		private static Vector4 prepassTextureSize_256x256; // 0x00
		private static Vector4 prepassTextureSize_512x512; // 0x10
		private static Vector4 prepassTextureSize_1024x1024; // 0x20
		public static Vector4 prepassTextureSize; // 0x30
	
		// Constructors
		static WaterSettings() {} // 0x0000000184D4F5F0-0x0000000184D4F660
		// WaterSettings()
		void HG::Rendering::Runtime::WaterSettings::cctor(MethodInfo *method)
		{
		  Vector4 si128; // xmm1
		  Vector4 v2; // xmm0
		
		  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18DA45A90);
		  TypeInfo::HG::Rendering::Runtime::WaterSettings->static_fields->prepassTextureSize_256x256 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18DA45AA0);
		  v2 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18DA45A80);
		  TypeInfo::HG::Rendering::Runtime::WaterSettings->static_fields->prepassTextureSize_512x512 = si128;
		  TypeInfo::HG::Rendering::Runtime::WaterSettings->static_fields->prepassTextureSize_1024x1024 = v2;
		  TypeInfo::HG::Rendering::Runtime::WaterSettings->static_fields->prepassTextureSize = TypeInfo::HG::Rendering::Runtime::WaterSettings->static_fields->prepassTextureSize_512x512;
		}
		
	
		// Methods
		public static Mesh CreateQuad(int numVertsX, int numVertsY) => default; // 0x0000000183D9DD50-0x0000000183D9E0C0
		// Mesh CreateQuad(Int32, Int32)
		Mesh *HG::Rendering::Runtime::WaterSettings::CreateQuad(int32_t numVertsX, int32_t numVertsY, MethodInfo *method)
		{
		  Vector3__Array *v5; // rsi
		  Vector2__Array *v6; // rdi
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  int v9; // r11d
		  __int64 v10; // rcx
		  Int32__Array *v11; // rbx
		  int v12; // r10d
		  int v13; // r9d
		  int v14; // r8d
		  __m128 v15; // xmm2
		  __m128 v16; // xmm1
		  __int64 v17; // rax
		  int32_t v18; // r9d
		  int32_t v19; // r10d
		  int v20; // r14d
		  int v21; // r11d
		  int32_t v22; // r8d
		  int32_t v23; // r9d
		  int32_t v24; // r9d
		  __int64 v25; // rax
		  unsigned int v26; // r9d
		  int v27; // eax
		  int v28; // ecx
		  __int64 v29; // rax
		  int32_t v30; // r9d
		  int32_t v31; // r9d
		  __int64 v32; // rax
		  Mesh *v33; // rax
		  Mesh *v34; // rbp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1055, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1055, 0LL);
		    if ( !Patch )
		      goto LABEL_28;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_404(Patch, numVertsX, numVertsY, 0LL);
		  }
		  else
		  {
		    v5 = (Vector3__Array *)il2cpp_array_new_specific_1(
		                             TypeInfo::UnityEngine::Vector3,
		                             (unsigned int)((numVertsY + 1) * (numVertsX + 1)));
		    v6 = (Vector2__Array *)il2cpp_array_new_specific_1(
		                             TypeInfo::UnityEngine::Vector2,
		                             (unsigned int)((numVertsX + 1) * (numVertsY + 1)));
		    v7 = il2cpp_array_new_specific_1(TypeInfo::System::Int32, (unsigned int)(6 * numVertsY * numVertsX));
		    v9 = 0;
		    v10 = (unsigned int)(numVertsX + 1);
		    v11 = (Int32__Array *)v7;
		    if ( (int)v10 > 0 )
		    {
		      v12 = numVertsY + 1;
		      v13 = numVertsX + 1;
		      while ( 1 )
		      {
		        v14 = 0;
		        if ( v12 > 0 )
		          break;
		LABEL_11:
		        if ( ++v9 >= v13 )
		          goto LABEL_12;
		      }
		      v8 = (unsigned int)v9;
		      v15 = (__m128)COERCE_UNSIGNED_INT((float)v9);
		      v15.m128_f32[0] = v15.m128_f32[0] / (float)numVertsX;
		      while ( 1 )
		      {
		        v16 = (__m128)COERCE_UNSIGNED_INT((float)v14);
		        v16.m128_f32[0] = v16.m128_f32[0] / (float)numVertsY;
		        if ( !v6 )
		          break;
		        if ( (unsigned int)v8 >= v6->max_length.size )
		          goto LABEL_40;
		        LODWORD(v6->vector[(int)v8].x) = v15.m128_i32[0];
		        LODWORD(v6->vector[(int)v8].y) = v16.m128_i32[0];
		        if ( !v5 )
		          break;
		        if ( (unsigned int)v8 >= v5->max_length.size )
		LABEL_40:
		          sub_1800D2AB0(v10, v8);
		        v17 = (int)v8;
		        ++v14;
		        v8 = (unsigned int)(v13 + v8);
		        v10 = 3 * v17;
		        *(_QWORD *)(&v5->vector[0].x + v10) = _mm_unpacklo_ps(v15, v16).m128_u64[0];
		        *((_DWORD *)&v5->vector[0].z + v10) = 0;
		        if ( v14 >= v12 )
		          goto LABEL_11;
		      }
		LABEL_28:
		      sub_1800D8260(v10, v8);
		    }
		LABEL_12:
		    v18 = 0;
		    v19 = 0;
		    if ( numVertsX > 0 )
		    {
		      v20 = -1;
		      v21 = numVertsX + 1;
		      do
		      {
		        v22 = 0;
		        if ( numVertsY > 0 )
		        {
		          v8 = (unsigned int)(v19 + 1);
		          do
		          {
		            if ( (((_BYTE)v22 + (_BYTE)v19) & 1) != 0 )
		            {
		              if ( !v11 )
		                goto LABEL_28;
		              if ( (unsigned int)v18 >= v11->max_length.size )
		                goto LABEL_40;
		              v11->vector[v18] = v8 - 1;
		              v10 = v18 + 1LL;
		              if ( (unsigned int)v10 >= v11->max_length.size )
		                goto LABEL_40;
		              v23 = v18 + 2;
		              v11->vector[v10] = v8 + numVertsX;
		              if ( (unsigned int)v23 >= v11->max_length.size )
		                goto LABEL_40;
		              v10 = v23 + 1LL;
		              v11->vector[v23] = v8;
		              if ( (unsigned int)v10 >= v11->max_length.size )
		                goto LABEL_40;
		              v24 = v23 + 2;
		              v11->vector[v10] = v8 + numVertsX;
		              if ( (unsigned int)v24 >= v11->max_length.size )
		                goto LABEL_40;
		              v25 = v24;
		              v10 = (unsigned int)(v8 + v21);
		              v26 = v24 + 1;
		              v11->vector[v25] = v10;
		              if ( v26 >= v11->max_length.size )
		                goto LABEL_40;
		              v27 = v20;
		            }
		            else
		            {
		              if ( !v11 )
		                goto LABEL_28;
		              if ( (unsigned int)v18 >= v11->max_length.size )
		                goto LABEL_40;
		              v11->vector[v18] = v8 - 1;
		              v10 = v18 + 1LL;
		              if ( (unsigned int)v10 >= v11->max_length.size )
		                goto LABEL_40;
		              v30 = v18 + 2;
		              v11->vector[v10] = v8 + v21;
		              if ( (unsigned int)v30 >= v11->max_length.size )
		                goto LABEL_40;
		              v10 = v30 + 1LL;
		              v11->vector[v30] = v8;
		              if ( (unsigned int)v10 >= v11->max_length.size )
		                goto LABEL_40;
		              v31 = v30 + 2;
		              v11->vector[v10] = v8 - 1;
		              if ( (unsigned int)v31 >= v11->max_length.size )
		                goto LABEL_40;
		              v32 = v31;
		              v10 = (unsigned int)(v8 + numVertsX);
		              v26 = v31 + 1;
		              v11->vector[v32] = v10;
		              if ( v26 >= v11->max_length.size )
		                goto LABEL_40;
		              v27 = v20 + v21;
		            }
		            ++v22;
		            v28 = v8 + v27 + 1;
		            v29 = (int)v26;
		            v10 = (unsigned int)(v19 + v28);
		            v8 = (unsigned int)(v21 + v8);
		            v18 = v26 + 1;
		            v11->vector[v29] = v10;
		          }
		          while ( v22 < numVertsY );
		        }
		        ++v19;
		        --v20;
		      }
		      while ( v19 < numVertsX );
		    }
		    if ( !v5 )
		      goto LABEL_28;
		    if ( v5->max_length.size > 65000 )
		    {
		      return 0LL;
		    }
		    else
		    {
		      v33 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		      v34 = v33;
		      if ( !v33 )
		        goto LABEL_28;
		      UnityEngine::Mesh::Mesh(v33, 0LL);
		      UnityEngine::Mesh::set_vertices(v34, v5, 0LL);
		      UnityEngine::Mesh::set_uv(v34, v6, 0LL);
		      UnityEngine::Mesh::set_triangles(v34, v11, 0LL);
		      UnityEngine::Object::set_name((Object_1 *)v34, (String *)"Water Mesh", 0LL);
		      return v34;
		    }
		  }
		}
		
	}
}
