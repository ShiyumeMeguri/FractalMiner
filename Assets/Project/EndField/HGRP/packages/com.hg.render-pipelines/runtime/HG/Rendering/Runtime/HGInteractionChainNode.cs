using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 132)]
	public struct HGInteractionChainNode
	{
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGInteractionChainNode DefaultValue
		{
			get
			{
				// // HGInteractionChainNode get_DefaultValue()
				// HGInteractionChainNode *HG::Rendering::Runtime::HGInteractionChainNode::get_DefaultValue(
				//         HGInteractionChainNode *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   Animator *v3; // rdx
				//   int32_t v4; // r8d
				//   MethodInfo *v5; // r9
				//   Vector3 *Vector; // rax
				//   __int64 v7; // xmm1_8
				//   MethodInfo *v8; // rdx
				//   Animator *v9; // rdx
				//   int32_t v10; // r8d
				//   MethodInfo *v11; // r9
				//   Vector3 *v12; // rax
				//   __int64 v13; // xmm1_8
				//   Animator *v14; // rdx
				//   int32_t v15; // r8d
				//   MethodInfo *v16; // r9
				//   Vector3 *v17; // rax
				//   __int64 v18; // xmm1_8
				//   Animator *v19; // rdx
				//   int32_t v20; // r8d
				//   MethodInfo *v21; // r9
				//   Vector3 *v22; // rax
				//   __int64 v23; // xmm1_8
				//   Animator *v24; // rdx
				//   int32_t v25; // r8d
				//   MethodInfo *v26; // r9
				//   Vector3 *v27; // rax
				//   __int64 v28; // xmm1_8
				//   HGInteractionChainNode *v29; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v31; // rdx
				//   __int64 v32; // rcx
				//   __int128 v33; // xmm1
				//   __int128 v34; // xmm0
				//   __int128 v35; // xmm1
				//   __int128 v36; // xmm0
				//   __int128 v37; // xmm1
				//   __int128 v38; // xmm0
				//   __int128 v39; // xmm0
				//   int v40; // eax
				//   Quaternion v42; // [rsp+20h] [rbp-49h] BYREF
				//   HGInteractionChainNode v43; // [rsp+30h] [rbp-39h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1491, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1491, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v32, v31);
				//     v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_567(&v43, Patch, 0LL);
				//   }
				//   else
				//   {
				//     sub_1802F01E0(&v43, 0LL, 132LL);
				//     v43.VRange.x = 0.0;
				//     v43.VRange.y = 0.0;
				//     v43.SectionIndex = -1;
				//     v43.HeightFade.x = 0.0;
				//     *(__m128i *)&v43.HeightFade.y = _mm_load_si128((const __m128i *)&xmmword_18C1756E0);
				//     v43.TimeFade.w = 1.0;
				//     v43.StartDist.x = -1.0;
				//     v43.StartDist.y = -1.0;
				//     Vector = UnityEngine::Animator::GetVector((Vector3 *)&v42, v3, v4, v5);
				//     v7 = *(_QWORD *)&Vector.x;
				//     *(float *)&Vector = Vector.z;
				//     *(_QWORD *)&v43.Position.x = v7;
				//     LODWORD(v43.Position.z) = (_DWORD)Vector;
				//     v43.Rotation = *UnityEngine::Quaternion::get_identity(&v42, v8);
				//     v43.Scale.x = 1.0;
				//     v43.Scale.y = 1.0;
				//     v12 = UnityEngine::Animator::GetVector((Vector3 *)&v42, v9, v10, v11);
				//     v13 = *(_QWORD *)&v12.x;
				//     *(float *)&v12 = v12.z;
				//     *(_QWORD *)&v43.Vertex0.x = v13;
				//     LODWORD(v43.Vertex0.z) = (_DWORD)v12;
				//     v17 = UnityEngine::Animator::GetVector((Vector3 *)&v42, v14, v15, v16);
				//     v18 = *(_QWORD *)&v17.x;
				//     *(float *)&v17 = v17.z;
				//     *(_QWORD *)&v43.Vertex1.x = v18;
				//     LODWORD(v43.Vertex1.z) = (_DWORD)v17;
				//     v22 = UnityEngine::Animator::GetVector((Vector3 *)&v42, v19, v20, v21);
				//     v23 = *(_QWORD *)&v22.x;
				//     *(float *)&v22 = v22.z;
				//     *(_QWORD *)&v43.Vertex2.x = v23;
				//     LODWORD(v43.Vertex2.z) = (_DWORD)v22;
				//     v27 = UnityEngine::Animator::GetVector((Vector3 *)&v42, v24, v25, v26);
				//     v43.Active = 0;
				//     v28 = *(_QWORD *)&v27.x;
				//     v43.Vertex3.z = v27.z;
				//     v29 = &v43;
				//     *(_QWORD *)&v43.Vertex3.x = v28;
				//   }
				//   v33 = *(_OWORD *)&v29.HeightFade.y;
				//   *(_OWORD *)&retstr.VRange.x = *(_OWORD *)&v29.VRange.x;
				//   v34 = *(_OWORD *)&v29.TimeFade.w;
				//   *(_OWORD *)&retstr.HeightFade.y = v33;
				//   v35 = *(_OWORD *)&v29.Position.y;
				//   *(_OWORD *)&retstr.TimeFade.w = v34;
				//   v36 = *(_OWORD *)&v29.Rotation.z;
				//   *(_OWORD *)&retstr.Position.y = v35;
				//   v37 = *(_OWORD *)&v29.Vertex0.x;
				//   *(_OWORD *)&retstr.Rotation.z = v36;
				//   v38 = *(_OWORD *)&v29.Vertex1.y;
				//   *(_OWORD *)&retstr.Vertex0.x = v37;
				//   *(_OWORD *)&retstr.Vertex1.y = v38;
				//   v39 = *(_OWORD *)&v29.Vertex2.z;
				//   v40 = *(_DWORD *)&v29.Active;
				//   *(_OWORD *)&retstr.Vertex2.z = v39;
				//   *(_DWORD *)&retstr.Active = v40;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public Matrix4x4 GetMatrix()
		{
			// // Matrix4x4 GetMatrix()
			// Matrix4x4 *HG::Rendering::Runtime::HGInteractionChainNode::GetMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGInteractionChainNode *this,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   Quaternion Rotation; // xmm0
			//   __int64 v7; // xmm1_8
			//   __int64 v8; // xmm3_8
			//   Matrix4x4 *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   Matrix4x4 *result; // rax
			//   Vector3 v17; // [rsp+30h] [rbp-78h] BYREF
			//   Vector3 v18; // [rsp+40h] [rbp-68h] BYREF
			//   Quaternion v19; // [rsp+50h] [rbp-58h] BYREF
			//   Matrix4x4 v20; // [rsp+60h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1492, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1492, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_568(&v20, Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     v5 = sub_1851404A4(
			//            &v18,
			//            _mm_unpacklo_ps((__m128)LODWORD(this.Scale.x), (__m128)LODWORD(this.Scale.y)).m128_u64[0]);
			//     Rotation = this.Rotation;
			//     v7 = *(_QWORD *)&this.Position.x;
			//     v8 = *(_QWORD *)v5;
			//     v17.z = *(float *)(v5 + 8);
			//     v18.z = this.Position.z;
			//     *(_QWORD *)&v17.x = v8;
			//     v19 = Rotation;
			//     *(_QWORD *)&v18.x = v7;
			//     v9 = UnityEngine::Matrix4x4::TRS(&v20, &v18, &v19, &v17, 0LL);
			//   }
			//   v13 = *(_OWORD *)&v9.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v9.m00;
			//   v14 = *(_OWORD *)&v9.m02;
			//   *(_OWORD *)&retstr.m01 = v13;
			//   v15 = *(_OWORD *)&v9.m03;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v14;
			//   *(_OWORD *)&retstr.m03 = v15;
			//   return result;
			// }
			// 
			return null;
		}

		public Vector2 VRange;

		public int SectionIndex;

		public Vector2 HeightFade;

		public Vector4 TimeFade;

		public Vector2 StartDist;

		public Vector3 Position;

		public Quaternion Rotation;

		public Vector2 Scale;

		public Vector3 Vertex0;

		public Vector3 Vertex1;

		public Vector3 Vertex2;

		public Vector3 Vertex3;

		public bool Active;
	}
}
