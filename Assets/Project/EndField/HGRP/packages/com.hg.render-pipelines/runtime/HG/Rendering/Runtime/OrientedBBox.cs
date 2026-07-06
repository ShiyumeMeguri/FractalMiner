using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.hg.render-pipelines\\Runtime\\Core\\Utilities\\GeometryUtils.cs")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
	internal struct OrientedBBox
	{
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 forward
		{
			get
			{
				// // Vector3 get_forward()
				// Vector3 *HG::Rendering::Runtime::OrientedBBox::get_forward(
				//         Vector3 *__return_ptr retstr,
				//         OrientedBBox *this,
				//         MethodInfo *method)
				// {
				//   float z; // eax
				//   __int64 v4; // xmm0_8
				//   float v5; // eax
				//   Vector3 *v6; // rax
				//   __int64 v7; // xmm0_8
				//   __int64 v8; // r9
				//   Vector3 v10; // [rsp+20h] [rbp-38h] BYREF
				//   Vector3 v11; // [rsp+30h] [rbp-28h] BYREF
				//   Vector3 v12[2]; // [rsp+40h] [rbp-18h] BYREF
				// 
				//   z = this.right.z;
				//   *(_QWORD *)&v10.x = *(_QWORD *)&this.right.x;
				//   v4 = *(_QWORD *)&this.up.x;
				//   v10.z = z;
				//   v5 = this.up.z;
				//   *(_QWORD *)&v11.x = v4;
				//   v11.z = v5;
				//   v6 = UnityEngine::Vector3::Cross(v12, &v11, &v10, (MethodInfo *)retstr);
				//   v7 = *(_QWORD *)&v6.x;
				//   *(float *)&v6 = v6.z;
				//   *(_QWORD *)v8 = v7;
				//   *(_DWORD *)(v8 + 8) = (_DWORD)v6;
				//   return (Vector3 *)v8;
				// }
				// 
				return null;
			}
		}

		public OrientedBBox(Matrix4x4 trs)
		{
			// // OrientedBBox(Matrix4x4)
			// void HG::Rendering::Runtime::OrientedBBox::OrientedBBox(OrientedBBox *this, Matrix4x4 *trs, MethodInfo *method)
			// {
			//   MethodInfo *v5; // r8
			//   Vector3 *v6; // rax
			//   __int64 v7; // xmm6_8
			//   float z; // edi
			//   MethodInfo *v9; // r8
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm7_8
			//   float v12; // esi
			//   MethodInfo *v13; // r8
			//   Vector3 *v14; // rax
			//   __int64 v15; // xmm3_8
			//   MethodInfo *v16; // r8
			//   Vector3 *v17; // rax
			//   float v18; // ecx
			//   double v19; // xmm0_8
			//   MethodInfo *v20; // r9
			//   Vector3 *v21; // rax
			//   float v22; // ecx
			//   double v23; // xmm0_8
			//   MethodInfo *v24; // r9
			//   Vector3 *v25; // rax
			//   float v26; // ecx
			//   double v27; // xmm0_8
			//   double v28; // xmm0_8
			//   double v29; // xmm0_8
			//   __int64 v30; // [rsp+28h] [rbp-19h] BYREF
			//   float v31; // [rsp+30h] [rbp-11h]
			//   __int64 v32; // [rsp+38h] [rbp-9h] BYREF
			//   float v33; // [rsp+40h] [rbp-1h]
			//   Vector3 v34; // [rsp+48h] [rbp+7h] BYREF
			//   Vector3 v35; // [rsp+58h] [rbp+17h] BYREF
			//   Vector4 v36; // [rsp+68h] [rbp+27h] BYREF
			// 
			//   v36 = *UnityEngine::Matrix4x4::GetColumn(&v36, trs, 0, 0LL);
			//   v6 = UnityEngine::Vector4::op_Implicit(&v35, &v36, v5);
			//   z = v6.z;
			//   v30 = *(_QWORD *)&v6.x;
			//   v7 = v30;
			//   v31 = z;
			//   v36 = *UnityEngine::Matrix4x4::GetColumn(&v36, trs, 1, 0LL);
			//   v10 = UnityEngine::Vector4::op_Implicit(&v35, &v36, v9);
			//   v12 = v10.z;
			//   v32 = *(_QWORD *)&v10.x;
			//   v11 = v32;
			//   v33 = v12;
			//   v36 = *UnityEngine::Matrix4x4::GetColumn(&v36, trs, 2, 0LL);
			//   v14 = UnityEngine::Vector4::op_Implicit(&v34, &v36, v13);
			//   v15 = *(_QWORD *)&v14.x;
			//   *(float *)&v14 = v14.z;
			//   *(_QWORD *)&v35.x = v15;
			//   LODWORD(v35.z) = (_DWORD)v14;
			//   v36 = *UnityEngine::Matrix4x4::GetColumn(&v36, trs, 3, 0LL);
			//   v17 = UnityEngine::Vector4::op_Implicit(&v34, &v36, v16);
			//   v18 = v17.z;
			//   *(_QWORD *)&this.center.x = *(_QWORD *)&v17.x;
			//   this.center.z = v18;
			//   v19 = sub_18238EFA0(&v30);
			//   *(_QWORD *)&v34.x = v7;
			//   v34.z = z;
			//   v21 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v36, &v34, 1.0 / *(float *)&v19, v20);
			//   v22 = v21.z;
			//   *(_QWORD *)&this.right.x = *(_QWORD *)&v21.x;
			//   this.right.z = v22;
			//   v23 = sub_18238EFA0(&v32);
			//   v34.z = v12;
			//   *(_QWORD *)&v34.x = v11;
			//   v25 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v36, &v34, 1.0 / *(float *)&v23, v24);
			//   v26 = v25.z;
			//   *(_QWORD *)&this.up.x = *(_QWORD *)&v25.x;
			//   this.up.z = v26;
			//   v27 = sub_18238EFA0(&v30);
			//   this.extentX = *(float *)&v27 * 0.5;
			//   v28 = sub_18238EFA0(&v32);
			//   this.extentY = *(float *)&v28 * 0.5;
			//   v29 = sub_18238EFA0(&v35);
			//   this.extentZ = *(float *)&v29 * 0.5;
			// }
			// 
		}

		public Vector3 right;

		public float extentX;

		public Vector3 up;

		public float extentY;

		public Vector3 center;

		public float extentZ;
	}
}
