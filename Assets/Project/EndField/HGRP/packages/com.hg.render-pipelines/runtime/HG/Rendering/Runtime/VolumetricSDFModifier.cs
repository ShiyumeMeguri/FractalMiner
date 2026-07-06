using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class VolumetricSDFModifier : MonoBehaviour
	{
		public VolumetricSDFModifier()
		{
			// // VolumetricSDFModifier()
			// void HG::Rendering::Runtime::VolumetricSDFModifier::VolumetricSDFModifier(
			//         VolumetricSDFModifier *this,
			//         MethodInfo *method)
			// {
			//   ITilemap *v2; // r9
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int64 v4; // r8
			//   TileAnimationData v5; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields.m_Radius = 10.0;
			//   this.fields.m_FalloffExp = 1.0;
			//   TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                              &v5,
			//                              (TileBase *)method,
			//                              (Vector3Int *)this,
			//                              v2,
			//                              (MethodInfo *)v5.m_AnimatedSprites);
			//   *(TileAnimationData *)(v4 + 36) = *TileAnimationDataNoRef;
			//   UnityEngine::Component::Component((Component *)v4, 0LL);
			// }
			// 
		}

		public FModifierData GetModifierData()
		{
			// // FModifierData GetModifierData()
			// FModifierData *HG::Rendering::Runtime::VolumetricSDFModifier::GetModifierData(
			//         FModifierData *__return_ptr retstr,
			//         VolumetricSDFModifier *this,
			//         MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *position; // rax
			//   __int64 v9; // xmm0_8
			//   Vector4 m_Data; // xmm0
			//   MethodInfo *v11; // r8
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm3_8
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   FModifierData *v17; // rax
			//   FModifierData *result; // rax
			//   Vector3 v19; // [rsp+20h] [rbp-50h] BYREF
			//   Vector4 v20; // [rsp+30h] [rbp-40h] BYREF
			//   FModifierData v21; // [rsp+40h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4562, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4562, 0LL);
			//     if ( Patch )
			//     {
			//       v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1306(&v21, Patch, (Object *)this, 0LL);
			//       v14 = *(_OWORD *)&v17.Payload.x;
			//       *(_OWORD *)&retstr.Position.x = *(_OWORD *)&v17.Position.x;
			//       v15 = *(_OWORD *)&v17.Operation;
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, v6);
			//   }
			//   memset(&v21, 0, sizeof(v21));
			//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !transform )
			//     goto LABEL_5;
			//   position = UnityEngine::Transform::get_position(&v19, transform, 0LL);
			//   v21.FalloffExp = this.fields.m_FalloffExp;
			//   v9 = *(_QWORD *)&position.x;
			//   *(float *)&position = position.z;
			//   *(_QWORD *)&v21.Position.x = v9;
			//   v21.Radius = this.fields.m_Radius;
			//   m_Data = this.fields.m_Data;
			//   LODWORD(v21.Position.z) = (_DWORD)position;
			//   v20 = m_Data;
			//   v12 = UnityEngine::Vector4::op_Implicit(&v19, &v20, v11);
			//   v13 = *(_QWORD *)&v12.x;
			//   v21.Payload.z = v12.z;
			//   v21.Mode = this.fields.m_ModifierMode;
			//   v21.Operation = this.fields.m_SdfOperation;
			//   *(_QWORD *)&v21.Payload.x = v13;
			//   v14 = *(_OWORD *)&v21.Payload.x;
			//   *(_OWORD *)&retstr.Position.x = *(_OWORD *)&v21.Position.x;
			//   v15 = *(_OWORD *)&v21.Operation;
			// LABEL_7:
			//   *(_OWORD *)&retstr.Payload.x = v14;
			//   result = retstr;
			//   *(_OWORD *)&retstr.Operation = v15;
			//   return result;
			// }
			// 
			return null;
		}

		public VolumetricSDFModifier.EModifierMode m_ModifierMode;

		public float m_Radius;

		public float m_FalloffExp;

		public Vector4 m_Data;

		public VolumetricSDFModifier.ESdfOperation m_SdfOperation;

		public enum EModifierMode
		{
			SDF,
			Density,
			Albedo
		}

		public enum ESdfOperation
		{
			Subtract,
			Union,
			Intersect
		}
	}
}
