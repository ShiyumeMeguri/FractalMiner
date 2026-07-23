using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class CSGVertex // TypeDefIndex: 38805
	{
		// Fields
		public Vector3 Position; // 0x10
		public Vector3 Normal; // 0x1C
		public Vector2 UV; // 0x28
		public int id; // 0x30
	
		// Constructors
		public CSGVertex() {} // Dummy constructor
		public CSGVertex(Vector3 position, Vector3 normal, Vector2 UV1, int id) {} // 0x0000000189C75E6C-0x0000000189C75EDC
		// CSGVertex(Vector3, Vector3, Vector2, Int32)
		void HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
		        CSGVertex *this,
		        Vector3 *position,
		        Vector3 *normal,
		        Vector2 UV1,
		        int32_t id,
		        MethodInfo *method)
		{
		  float z; // eax
		  __int64 v8; // xmm0_8
		  float v9; // eax
		  __int64 v11; // rax
		  float v12; // ecx
		  __int64 v13; // [rsp+20h] [rbp-38h] BYREF
		  float v14; // [rsp+28h] [rbp-30h]
		  _BYTE v15[16]; // [rsp+30h] [rbp-28h] BYREF
		
		  z = position->z;
		  *(_QWORD *)&this->fields.Position.x = *(_QWORD *)&position->x;
		  v8 = *(_QWORD *)&normal->x;
		  this->fields.Position.z = z;
		  v9 = normal->z;
		  v13 = v8;
		  v14 = v9;
		  v11 = sub_182FAE420(v15, &v13);
		  v12 = *(float *)(v11 + 8);
		  *(_QWORD *)&this->fields.Normal.x = *(_QWORD *)v11;
		  this->fields.UV = UV1;
		  this->fields.Normal.z = v12;
		  this->fields.id = id;
		}
		
	
		// Methods
		public CSGVertex Flip() => default; // 0x0000000189C75AEC-0x0000000189C75C10
		// CSGVertex Flip()
		CSGVertex *HG::Rendering::Runtime::CSG::CSGVertex::Flip(CSGVertex *this, MethodInfo *method)
		{
		  MethodInfo *v3; // r8
		  float z; // eax
		  __int64 v5; // xmm6_8
		  float v6; // edi
		  Vector3 *v7; // rax
		  __m128 x_low; // xmm8
		  __m128 y_low; // xmm9
		  __int64 v10; // xmm7_8
		  float v11; // esi
		  int32_t id; // ebp
		  CSGVertex *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  CSGVertex *v16; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v19; // [rsp+30h] [rbp-68h] BYREF
		  Vector3 v20[4]; // [rsp+40h] [rbp-58h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5271, 0LL) )
		  {
		    z = this->fields.Normal.z;
		    v5 = *(_QWORD *)&this->fields.Position.x;
		    v6 = this->fields.Position.z;
		    *(_QWORD *)&v19.x = *(_QWORD *)&this->fields.Normal.x;
		    v19.z = z;
		    v7 = UnityEngine::Vector3::op_UnaryNegation(v20, &v19, v3);
		    x_low = (__m128)LODWORD(this->fields.UV.x);
		    y_low = (__m128)LODWORD(this->fields.UV.y);
		    v10 = *(_QWORD *)&v7->x;
		    v11 = v7->z;
		    id = this->fields.id;
		    v13 = (CSGVertex *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		    v16 = v13;
		    if ( v13 )
		    {
		      *(_QWORD *)&v19.x = v10;
		      v19.z = v11;
		      *(_QWORD *)&v20[0].x = v5;
		      v20[0].z = v6;
		      HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
		        v13,
		        v20,
		        &v19,
		        (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		        id,
		        0LL);
		      return v16;
		    }
		LABEL_5:
		    sub_1800D8260(v15, v14);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5271, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1529(Patch, this, 0LL);
		}
		
		public CSGVertex Interpolate(CSGVertex other, float t) => default; // 0x0000000189C75C10-0x0000000189C75DCC
		// CSGVertex Interpolate(CSGVertex, Single)
		CSGVertex *HG::Rendering::Runtime::CSG::CSGVertex::Interpolate(
		        CSGVertex *this,
		        CSGVertex *other,
		        float t,
		        MethodInfo *method)
		{
		  float v4; // xmm1_4
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  __int64 v10; // xmm0_8
		  float v11; // eax
		  __int64 v12; // rax
		  __int64 v13; // xmm0_8
		  __int64 v14; // xmm9_8
		  float v15; // esi
		  __int64 v16; // rax
		  __int64 v17; // xmm10_8
		  float v18; // r14d
		  Beyond::JobMathf *v19; // rcx
		  __m128 x_low; // xmm7
		  __m128 y_low; // xmm8
		  int32_t id; // edi
		  CSGVertex *v23; // rax
		  CSGVertex *v24; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v27; // [rsp+38h] [rbp-29h] BYREF
		  Vector3 v28; // [rsp+48h] [rbp-19h] BYREF
		  _BYTE v29[96]; // [rsp+58h] [rbp-9h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5266, 0LL) )
		  {
		    if ( other )
		    {
		      z = other->fields.Position.z;
		      *(_QWORD *)&v27.x = *(_QWORD *)&other->fields.Position.x;
		      v10 = *(_QWORD *)&this->fields.Position.x;
		      v27.z = z;
		      v11 = this->fields.Position.z;
		      *(_QWORD *)&v28.x = v10;
		      v28.z = v11;
		      v12 = sub_183276430(v29, &v28, &v27);
		      *(_QWORD *)&v28.x = *(_QWORD *)&other->fields.Normal.x;
		      v13 = *(_QWORD *)&this->fields.Normal.x;
		      v14 = *(_QWORD *)v12;
		      v15 = *(float *)(v12 + 8);
		      v28.z = other->fields.Normal.z;
		      v27.z = this->fields.Normal.z;
		      *(_QWORD *)&v27.x = v13;
		      v16 = sub_183276430(v29, &v27, &v28);
		      x_low = (__m128)LODWORD(other->fields.UV.x);
		      y_low = (__m128)LODWORD(other->fields.UV.y);
		      v17 = *(_QWORD *)v16;
		      v18 = *(float *)(v16 + 8);
		      Beyond::JobMathf::Clamp01(v19, v4);
		      x_low.m128_f32[0] = (float)((float)(x_low.m128_f32[0] - this->fields.UV.x) * t) + this->fields.UV.x;
		      y_low.m128_f32[0] = (float)((float)(y_low.m128_f32[0] - this->fields.UV.y) * t) + this->fields.UV.y;
		      id = this->fields.id;
		      v23 = (CSGVertex *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
		      v24 = v23;
		      if ( v23 )
		      {
		        *(_QWORD *)&v28.x = v17;
		        v28.z = v18;
		        *(_QWORD *)&v27.x = v14;
		        v27.z = v15;
		        HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
		          v23,
		          &v27,
		          &v28,
		          (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
		          id,
		          0LL);
		        return v24;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5266, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1523(Patch, (Object *)this, (Object *)other, t, 0LL);
		}
		
		public override string ToString() => default; // 0x0000000189C75DCC-0x0000000189C75E6C
		// String ToString()
		String *HG::Rendering::Runtime::CSG::CSGVertex::ToString(CSGVertex *this, MethodInfo *method)
		{
		  float z; // eax
		  String *v4; // rax
		  __int64 v5; // xmm0_8
		  String *v6; // rbx
		  String *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector3 v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5439, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5439, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    z = this->fields.Position.z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&this->fields.Position.x;
		    v12.z = z;
		    v4 = UnityEngine::Vector3::ToString(&v12, 0LL);
		    v5 = *(_QWORD *)&this->fields.Normal.x;
		    v6 = v4;
		    v12.z = this->fields.Normal.z;
		    *(_QWORD *)&v12.x = v5;
		    v7 = UnityEngine::Vector3::ToString(&v12, 0LL);
		    return System::String::Concat(v6, (String *)", N=", v7, 0LL);
		  }
		}
		
		public string __iFixBaseProxy_ToString() => default; // 0x000000018669AD6C-0x000000018669AD74
		// String ObjectToString()
		String *IFix::Core::AnonymousStorey::ObjectToString(AnonymousStorey *this, MethodInfo *method)
		{
		  return System::Object::ToString((Object *)this, 0LL);
		}
		
	}
}
