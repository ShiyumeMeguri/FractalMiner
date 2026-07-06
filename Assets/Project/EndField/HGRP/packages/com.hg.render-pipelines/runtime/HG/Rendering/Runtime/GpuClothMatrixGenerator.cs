using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class GpuClothMatrixGenerator : MonoBehaviour
	{
		public GpuClothMatrixGenerator()
		{
			// // GpuClothMatrixGenerator()
			// void HG::Rendering::Runtime::GpuClothMatrixGenerator::GpuClothMatrixGenerator(
			//         GpuClothMatrixGenerator *this,
			//         MethodInfo *method)
			// {
			//   this.fields.matrixInterval = 10.0;
			//   this.fields.matrixWidth = 5;
			//   this.fields.matrixHeight = 5;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void Start()
		{
			// // Void Start()
			// void HG::Rendering::Runtime::GpuClothMatrixGenerator::Start(GpuClothMatrixGenerator *this, MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Transform *v6; // rax
			//   Transform *v7; // rax
			//   __int64 v8; // r8
			//   int v9; // edi
			//   int v10; // esi
			//   Object *v11; // rax
			//   String *v12; // r15
			//   GameObject *v13; // rax
			//   GameObject *v14; // r14
			//   Transform *v15; // r15
			//   Transform *v16; // rax
			//   MethodInfo *v17; // rdx
			//   Vector3 *fwd; // rax
			//   __int64 v19; // xmm3_8
			//   MethodInfo *v20; // rdx
			//   Vector3 *right; // rax
			//   __int64 v22; // xmm1_8
			//   MethodInfo *v23; // r9
			//   Vector3 *v24; // rax
			//   __int64 v25; // xmm1_8
			//   MethodInfo *v26; // r9
			//   Vector3 *v27; // rax
			//   __int64 v28; // xmm1_8
			//   MethodInfo *v29; // r9
			//   Vector3 *v30; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   Transform *v33; // r9
			//   __int64 v34; // xmm0_8
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v37; // [rsp+28h] [rbp-59h] BYREF
			//   Vector3 v38; // [rsp+38h] [rbp-49h] BYREF
			//   Vector3 v39; // [rsp+48h] [rbp-39h] BYREF
			//   Vector3 v40; // [rsp+58h] [rbp-29h] BYREF
			//   Vector3 v41; // [rsp+68h] [rbp-19h] BYREF
			//   Vector3 v42; // [rsp+78h] [rbp-9h] BYREF
			//   Vector3 v43; // [rsp+88h] [rbp+7h] BYREF
			//   Vector3 v44; // [rsp+98h] [rbp+17h] BYREF
			//   Vector3 v45; // [rsp+A8h] [rbp+27h] BYREF
			//   Vector3 v46; // [rsp+B8h] [rbp+37h] BYREF
			//   uint32_t v47; // [rsp+F8h] [rbp+77h] BYREF
			// 
			//   if ( !byte_18D919CF5 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::ClothInfo>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::System::UInt32);
			//     sub_18003C530(&off_18D531E10);
			//     byte_18D919CF5 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1178, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1178, 0LL);
			//     if ( !Patch )
			//       goto LABEL_17;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( !transform )
			//       goto LABEL_17;
			//     UnityEngine::Transform::get_position(&v37, transform, 0LL);
			//     v6 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( !v6 )
			//       goto LABEL_17;
			//     UnityEngine::Transform::get_right(&v37, v6, 0LL);
			//     v7 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( !v7 )
			//       goto LABEL_17;
			//     UnityEngine::Transform::get_forward(&v37, v7, 0LL);
			//     v9 = 0;
			//     if ( this.fields.matrixHeight )
			//     {
			//       while ( 1 )
			//       {
			//         v10 = 0;
			//         if ( this.fields.matrixWidth )
			//           break;
			// LABEL_13:
			//         if ( ++v9 >= this.fields.matrixHeight )
			//           return;
			//       }
			//       while ( 1 )
			//       {
			//         v47 = v10 + this.fields.matrixWidth * v9;
			//         v11 = (Object *)il2cpp_value_box_0(TypeInfo::System::UInt32, &v47, v8);
			//         v12 = System::String::Format((String *)"clothInfo{0}", v11, 0LL);
			//         v13 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//         v14 = v13;
			//         if ( !v13 )
			//           break;
			//         UnityEngine::GameObject::GameObject(v13, v12, 0LL);
			//         v15 = UnityEngine::GameObject::get_transform(v14, 0LL);
			//         v16 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( !v15 )
			//           break;
			//         UnityEngine::Transform::SetParent(v15, v16, 1, 0LL);
			//         UnityEngine::GameObject::get_transform(v14, 0LL);
			//         fwd = UnityEngine::Vector3::get_fwd(&v42, v17);
			//         v19 = *(_QWORD *)&fwd.x;
			//         v39.z = fwd.z;
			//         *(_QWORD *)&v39.x = v19;
			//         right = UnityEngine::Vector3::get_right(&v43, v20);
			//         v22 = *(_QWORD *)&right.x;
			//         *(float *)&right = right.z;
			//         *(_QWORD *)&v38.x = v22;
			//         LODWORD(v38.z) = (_DWORD)right;
			//         v24 = UnityEngine::Vector3::op_Multiply(&v44, (float)v10 * this.fields.matrixInterval, &v38, v23);
			//         v25 = *(_QWORD *)&v24.x;
			//         v40.z = v24.z;
			//         *(_QWORD *)&v40.x = v25;
			//         v27 = UnityEngine::Vector3::op_Multiply(&v45, (float)v9 * this.fields.matrixInterval, &v39, v26);
			//         v28 = *(_QWORD *)&v27.x;
			//         *(float *)&v27 = v27.z;
			//         *(_QWORD *)&v41.x = v28;
			//         LODWORD(v41.z) = (_DWORD)v27;
			//         v30 = UnityEngine::Vector3::op_Addition(&v46, &v41, &v40, v29);
			//         if ( !v33 )
			//           sub_180B536AC(v32, v31);
			//         v34 = *(_QWORD *)&v30.x;
			//         z = v30.z;
			//         *(_QWORD *)&v37.x = v34;
			//         v37.z = z;
			//         UnityEngine::Transform::set_localPosition(v33, &v37, 0LL);
			//         UnityEngine::GameObject::AddComponent<System::Object>(
			//           v14,
			//           MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::ClothInfo>);
			//         if ( ++v10 >= this.fields.matrixWidth )
			//           goto LABEL_13;
			//       }
			// LABEL_17:
			//       sub_180B536AC(v5, v4);
			//     }
			//   }
			// }
			// 
		}

		public float matrixInterval;

		public uint matrixWidth;

		public uint matrixHeight;
	}
}
