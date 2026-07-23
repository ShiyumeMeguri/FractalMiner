using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.hg.render-pipelines\\Runtime\\Core\\Utilities\\GeometryUtils.cs")]
	internal struct OrientedBBox // TypeDefIndex: 37528
	{
		// Fields
		public Vector3 right; // 0x00
		public float extentX; // 0x0C
		public Vector3 up; // 0x10
		public float extentY; // 0x1C
		public Vector3 center; // 0x20
		public float extentZ; // 0x2C
	
		// Properties
		public Vector3 forward { get => default; } // 0x0000000189C6FE9C-0x0000000189C6FF3C 
		// Vector3 get_forward()
		Vector3 *HG::Rendering::Runtime::OrientedBBox::get_forward(
		        Vector3 *__return_ptr retstr,
		        OrientedBBox *this,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // r9
		  float z; // eax
		  __int64 v7; // xmm0_8
		  float v8; // eax
		  Vector3 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // xmm0_8
		  float v14; // eax
		  Vector3 v16; // [rsp+20h] [rbp-38h] BYREF
		  Vector3 v17; // [rsp+30h] [rbp-28h] BYREF
		  Vector3 v18[2]; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(397, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(397, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_188(v18, Patch, this, 0LL);
		  }
		  else
		  {
		    z = this->right.z;
		    *(_QWORD *)&v16.x = *(_QWORD *)&this->right.x;
		    v7 = *(_QWORD *)&this->up.x;
		    v16.z = z;
		    v8 = this->up.z;
		    *(_QWORD *)&v17.x = v7;
		    v17.z = v8;
		    v9 = UnityEngine::Vector3::Cross(v18, &v17, &v16, v5);
		  }
		  v13 = *(_QWORD *)&v9->x;
		  v14 = v9->z;
		  *(_QWORD *)&retstr->x = v13;
		  retstr->z = v14;
		  return retstr;
		}
		
	
		// Constructors
		public OrientedBBox(Matrix4x4 trs) : this() {
			right = default;
			extentX = default;
			up = default;
			extentY = default;
			center = default;
			extentZ = default;
		} // 0x0000000189C6FCB8-0x0000000189C6FE9C
		// OrientedBBox(Matrix4x4)
		void HG::Rendering::Runtime::OrientedBBox::OrientedBBox(OrientedBBox *this, Matrix4x4 *trs, MethodInfo *method)
		{
		  MethodInfo *v5; // r8
		  Vector3 *v6; // rax
		  __int64 v7; // xmm6_8
		  float z; // edi
		  MethodInfo *v9; // r8
		  Vector3 *v10; // rax
		  __int64 v11; // xmm7_8
		  float v12; // esi
		  MethodInfo *v13; // r8
		  Vector3 *v14; // rax
		  __int64 v15; // xmm3_8
		  MethodInfo *v16; // r8
		  Vector3 *v17; // rax
		  float v18; // ecx
		  float v19; // xmm0_4
		  MethodInfo *v20; // r9
		  Vector3 *v21; // rax
		  float v22; // ecx
		  float v23; // xmm0_4
		  MethodInfo *v24; // r9
		  Vector3 *v25; // rax
		  float v26; // ecx
		  __int64 v27; // [rsp+28h] [rbp-19h] BYREF
		  float v28; // [rsp+30h] [rbp-11h]
		  __int64 v29; // [rsp+38h] [rbp-9h] BYREF
		  float v30; // [rsp+40h] [rbp-1h]
		  Vector3 v31; // [rsp+48h] [rbp+7h] BYREF
		  Vector3 v32; // [rsp+58h] [rbp+17h] BYREF
		  Vector4 v33; // [rsp+68h] [rbp+27h] BYREF
		
		  v33 = *UnityEngine::Matrix4x4::GetColumn(&v33, trs, 0, 0LL);
		  v6 = UnityEngine::Vector4::op_Implicit(&v32, &v33, v5);
		  z = v6->z;
		  v27 = *(_QWORD *)&v6->x;
		  v7 = v27;
		  v28 = z;
		  v33 = *UnityEngine::Matrix4x4::GetColumn(&v33, trs, 1, 0LL);
		  v10 = UnityEngine::Vector4::op_Implicit(&v32, &v33, v9);
		  v12 = v10->z;
		  v29 = *(_QWORD *)&v10->x;
		  v11 = v29;
		  v30 = v12;
		  v33 = *UnityEngine::Matrix4x4::GetColumn(&v33, trs, 2, 0LL);
		  v14 = UnityEngine::Vector4::op_Implicit(&v31, &v33, v13);
		  v15 = *(_QWORD *)&v14->x;
		  *(float *)&v14 = v14->z;
		  *(_QWORD *)&v32.x = v15;
		  LODWORD(v32.z) = (_DWORD)v14;
		  v33 = *UnityEngine::Matrix4x4::GetColumn(&v33, trs, 3, 0LL);
		  v17 = UnityEngine::Vector4::op_Implicit(&v31, &v33, v16);
		  v18 = v17->z;
		  *(_QWORD *)&this->center.x = *(_QWORD *)&v17->x;
		  this->center.z = v18;
		  v19 = sub_182F9FF00(&v27);
		  *(_QWORD *)&v31.x = v7;
		  v31.z = z;
		  v21 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v33, &v31, 1.0 / v19, v20);
		  v22 = v21->z;
		  *(_QWORD *)&this->right.x = *(_QWORD *)&v21->x;
		  this->right.z = v22;
		  v23 = sub_182F9FF00(&v29);
		  v31.z = v12;
		  *(_QWORD *)&v31.x = v11;
		  v25 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v33, &v31, 1.0 / v23, v24);
		  v26 = v25->z;
		  *(_QWORD *)&this->up.x = *(_QWORD *)&v25->x;
		  this->up.z = v26;
		  this->extentX = sub_182F9FF00(&v27) * 0.5;
		  this->extentY = sub_182F9FF00(&v29) * 0.5;
		  this->extentZ = sub_182F9FF00(&v32) * 0.5;
		}
		
	}
}
