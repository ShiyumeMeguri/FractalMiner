using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class CSGPolygon // TypeDefIndex: 38804
	{
		// Fields
		public readonly Plane Plane; // 0x10
		public CSGVertex[] Vertices; // 0x20
		public int objID; // 0x28
		public int materialID; // 0x2C
	
		// Constructors
		public CSGPolygon() {} // Dummy constructor
		public CSGPolygon(CSGVertex a, CSGVertex b, CSGVertex c, int objID, int materialID) {} // 0x0000000189C75858-0x0000000189C759A0
		// CSGPolygon(CSGVertex, CSGVertex, CSGVertex, Int32, Int32)
		void HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		        CSGPolygon *this,
		        CSGVertex *a,
		        CSGVertex *b,
		        CSGVertex *c,
		        int32_t objID,
		        int32_t materialID,
		        MethodInfo *method)
		{
		  float z; // eax
		  __int64 v12; // xmm1_8
		  float v13; // eax
		  __int64 v14; // xmm0_8
		  float v15; // eax
		  __int64 v16; // rax
		  CSGVertex__Array *v17; // r14
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v18; // rdx
		  VolumetricRenderer_VolumetricBounds *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *v21; // [rsp+20h] [rbp-50h]
		  MethodInfo *v22; // [rsp+28h] [rbp-48h]
		  Vector3 v23; // [rsp+30h] [rbp-40h] BYREF
		  Vector3 v24; // [rsp+40h] [rbp-30h] BYREF
		  Vector3 v25; // [rsp+50h] [rbp-20h] BYREF
		  Plane v26; // [rsp+60h] [rbp-10h] BYREF
		
		  if ( !a )
		    goto LABEL_6;
		  if ( !b )
		    goto LABEL_6;
		  if ( !c )
		    goto LABEL_6;
		  z = c->fields.Position.z;
		  v12 = *(_QWORD *)&c->fields.Position.x;
		  v26 = 0LL;
		  v23.z = z;
		  v13 = b->fields.Position.z;
		  *(_QWORD *)&v24.x = *(_QWORD *)&b->fields.Position.x;
		  v14 = *(_QWORD *)&a->fields.Position.x;
		  v24.z = v13;
		  v15 = a->fields.Position.z;
		  *(_QWORD *)&v25.x = v14;
		  *(_QWORD *)&v23.x = v12;
		  v25.z = v15;
		  UnityEngine::Plane::Plane(&v26, &v25, &v24, &v23, 0LL);
		  this->fields.Plane = v26;
		  v16 = il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex, 3LL);
		  v17 = (CSGVertex__Array *)v16;
		  if ( !v16 )
		LABEL_6:
		    sub_1800D8260(this, a);
		  sub_180031B10(v16, a);
		  sub_180378FEC(v17, 0LL, a);
		  sub_180031B10(v17, b);
		  sub_180378FEC(v17, 1LL, b);
		  sub_180031B10(v17, c);
		  sub_180378FEC(v17, 2LL, c);
		  this->fields.Vertices = v17;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.Vertices,
		    v18,
		    v19,
		    v20,
		    v21,
		    v22,
		    SLODWORD(v23.x),
		    SLODWORD(v23.z),
		    v24.x,
		    SLODWORD(v24.z),
		    SLOBYTE(v25.x),
		    SLOBYTE(v25.z),
		    *(MethodInfo **)&v26.m_Normal.x);
		  this->fields.materialID = materialID;
		  this->fields.objID = objID;
		}
		
		public CSGPolygon(IEnumerable<CSGVertex> vertices, int objID, int materialID) {} // 0x0000000189C759A0-0x0000000189C75AEC
		// CSGPolygon(IEnumerable`1[HG.Rendering.Runtime.CSG.CSGVertex], Int32, Int32)
		void HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		        CSGPolygon *this,
		        IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *vertices,
		        int32_t objID,
		        int32_t materialID,
		        MethodInfo *method)
		{
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v9; // rdx
		  VolumetricRenderer_VolumetricBounds *v10; // r8
		  Int32__Array **v11; // r9
		  Object *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Object__Class *klass; // xmm7_8
		  float v16; // edi
		  IEnumerable_1_System_Object_ *v17; // rax
		  Object *v18; // rax
		  Object__Class *v19; // xmm6_8
		  float v20; // ebx
		  IEnumerable_1_System_Object_ *v21; // rax
		  Object *v22; // rax
		  Object__Class *v23; // xmm1_8
		  float v24; // eax
		  MethodInfo *v25; // [rsp+28h] [rbp-21h]
		  MethodInfo *v26; // [rsp+30h] [rbp-19h]
		  Vector3 v27; // [rsp+38h] [rbp-11h] BYREF
		  Vector3 v28; // [rsp+48h] [rbp-1h] BYREF
		  Vector3 v29; // [rsp+58h] [rbp+Fh] BYREF
		  Plane v30; // [rsp+68h] [rbp+1Fh] BYREF
		
		  this->fields.Vertices = (CSGVertex__Array *)System::Linq::Enumerable::ToArray<System::Object>(
		                                                (IEnumerable_1_System_Object_ *)vertices,
		                                                MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::CSG::CSGVertex>);
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.Vertices,
		    v9,
		    v10,
		    v11,
		    v25,
		    v26,
		    SLODWORD(v27.x),
		    SLODWORD(v27.z),
		    v28.x,
		    SLODWORD(v28.z),
		    SLOBYTE(v29.x),
		    SLOBYTE(v29.z),
		    *(MethodInfo **)&v30.m_Normal.x);
		  this->fields.objID = objID;
		  this->fields.materialID = materialID;
		  v12 = System::Linq::Enumerable::First<System::Object>(
		          (IEnumerable_1_System_Object_ *)vertices,
		          MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>);
		  if ( !v12 )
		    goto LABEL_5;
		  klass = v12[1].klass;
		  v16 = *(float *)&v12[1].monitor;
		  v17 = (IEnumerable_1_System_Object_ *)System::Linq::Enumerable::Skip<UnityEngine::Vector3>(
		                                          (IEnumerable_1_UnityEngine_Vector3_ *)vertices,
		                                          1,
		                                          MethodInfo::System::Linq::Enumerable::Skip<HG::Rendering::Runtime::CSG::CSGVertex>);
		  v18 = System::Linq::Enumerable::First<System::Object>(
		          v17,
		          MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>);
		  if ( !v18
		    || (v19 = v18[1].klass,
		        v20 = *(float *)&v18[1].monitor,
		        v21 = (IEnumerable_1_System_Object_ *)System::Linq::Enumerable::Skip<UnityEngine::Vector3>(
		                                                (IEnumerable_1_UnityEngine_Vector3_ *)vertices,
		                                                2,
		                                                MethodInfo::System::Linq::Enumerable::Skip<HG::Rendering::Runtime::CSG::CSGVertex>),
		        (v22 = System::Linq::Enumerable::First<System::Object>(
		                 v21,
		                 MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>)) == 0LL) )
		  {
		LABEL_5:
		    sub_1800D8260(v14, v13);
		  }
		  v23 = v22[1].klass;
		  v24 = *(float *)&v22[1].monitor;
		  *(_QWORD *)&v27.x = v23;
		  v27.z = v24;
		  v30 = 0LL;
		  v28.z = v20;
		  *(_QWORD *)&v28.x = v19;
		  *(_QWORD *)&v29.x = klass;
		  v29.z = v16;
		  UnityEngine::Plane::Plane(&v30, &v29, &v28, &v27, 0LL);
		  this->fields.Plane = v30;
		}
		
	
		// Methods
		public void CalculateVertexNormals() {} // 0x0000000189C75428-0x0000000189C754B0
		// Void CalculateVertexNormals()
		void HG::Rendering::Runtime::CSG::CSGPolygon::CalculateVertexNormals(CSGPolygon *this, MethodInfo *method)
		{
		  CSGVertex__Array *v3; // rcx
		  __int64 v4; // rdx
		  CSGVertex__Array *Vertices; // rax
		  __m128i v6; // xmm1
		  CSGVertex *v7; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5438, 0LL) )
		  {
		    v4 = 0LL;
		    while ( 1 )
		    {
		      Vertices = this->fields.Vertices;
		      if ( !Vertices )
		        break;
		      if ( (int)v4 >= Vertices->max_length.size )
		        return;
		      v3 = this->fields.Vertices;
		      if ( (unsigned int)v4 >= Vertices->max_length.size )
		        sub_1800D2AB0(v3, v4);
		      v6 = _mm_loadu_si128((const __m128i *)&this->fields);
		      v7 = v3->vector[(int)v4];
		      if ( !v7 )
		        break;
		      *(_QWORD *)&v7->fields.Normal.x = v6.m128i_i64[0];
		      v4 = (unsigned int)(v4 + 1);
		      LODWORD(v7->fields.Normal.z) = _mm_cvtsi128_si32(_mm_srli_si128(v6, 8));
		    }
		LABEL_10:
		    sub_1800D8260(v3, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5438, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public CSGPolygon Flip() => default; // 0x0000000189C7554C-0x0000000189C756A0
		public CSGPolygon Clone() => default; // 0x0000000189C754B0-0x0000000189C7554C
		// CSGPolygon Clone()
		CSGPolygon *HG::Rendering::Runtime::CSG::CSGPolygon::Clone(CSGPolygon *this, MethodInfo *method)
		{
		  CSGVertex__Array *Vertices; // rdi
		  int32_t objID; // esi
		  int32_t materialID; // ebp
		  CSGPolygon *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  CSGPolygon *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5258, 0LL) )
		  {
		    Vertices = this->fields.Vertices;
		    objID = this->fields.objID;
		    materialID = this->fields.materialID;
		    v6 = (CSGPolygon *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
		    v9 = v6;
		    if ( v6 )
		    {
		      HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
		        v6,
		        (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)Vertices,
		        objID,
		        materialID,
		        0LL);
		      return v9;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5258, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1520(Patch, this, 0LL);
		}
		
		public static bool IsDegenerateSet(IEnumerable<CSGVertex> set) => default; // 0x0000000189C756A0-0x0000000189C75858
	}
}
