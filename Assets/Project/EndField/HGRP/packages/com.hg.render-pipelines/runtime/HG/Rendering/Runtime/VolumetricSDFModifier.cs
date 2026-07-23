using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class VolumetricSDFModifier : MonoBehaviour // TypeDefIndex: 38758
	{
		// Fields
		public EModifierMode m_ModifierMode; // 0x18
		public float m_Radius; // 0x1C
		public float m_FalloffExp; // 0x20
		public Vector4 m_Data; // 0x24
		public ESdfOperation m_SdfOperation; // 0x34
	
		// Nested types
		public enum EModifierMode // TypeDefIndex: 38756
		{
			SDF = 0,
			Density = 1,
			Albedo = 2
		}
	
		public enum ESdfOperation // TypeDefIndex: 38757
		{
			Subtract = 0,
			Union = 1,
			Intersect = 2
		}
	
		// Constructors
		public VolumetricSDFModifier() {} // 0x0000000189C5DADC-0x0000000189C5DB20
		// VolumetricSDFModifier()
		void HG::Rendering::Runtime::VolumetricSDFModifier::VolumetricSDFModifier(
		        VolumetricSDFModifier *this,
		        MethodInfo *method)
		{
		  Vector3Int *v2; // r8
		  ITilemap *v3; // r9
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v5; // rdx
		  TileAnimationData v6; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields.m_Radius = 10.0;
		  this->fields.m_FalloffExp = 1.0;
		  TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                             &v6,
		                             (TileBase *)this,
		                             v2,
		                             v3,
		                             (MethodInfo *)v6.m_AnimatedSprites);
		  *(TileAnimationData *)(v5 + 36) = *TileAnimationDataNoRef;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		public FModifierData GetModifierData() => default; // 0x0000000189C5D9C8-0x0000000189C5DADC
		// FModifierData GetModifierData()
		FModifierData *HG::Rendering::Runtime::VolumetricSDFModifier::GetModifierData(
		        FModifierData *__return_ptr retstr,
		        VolumetricSDFModifier *this,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *position; // rax
		  __int64 v9; // xmm0_8
		  Vector4 m_Data; // xmm0
		  MethodInfo *v11; // r8
		  Vector3 *v12; // rax
		  __int64 v13; // xmm3_8
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FModifierData *v17; // rax
		  FModifierData *result; // rax
		  Vector3 v19; // [rsp+20h] [rbp-50h] BYREF
		  Vector4 v20; // [rsp+30h] [rbp-40h] BYREF
		  FModifierData v21; // [rsp+40h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5237, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5237, 0LL);
		    if ( Patch )
		    {
		      v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1515(&v21, Patch, (Object *)this, 0LL);
		      v14 = *(_OWORD *)&v17->Payload.x;
		      *(_OWORD *)&retstr->Position.x = *(_OWORD *)&v17->Position.x;
		      v15 = *(_OWORD *)&v17->Operation;
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  memset(&v21, 0, sizeof(v21));
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_5;
		  position = UnityEngine::Transform::get_position(&v19, transform, 0LL);
		  v21.FalloffExp = this->fields.m_FalloffExp;
		  v9 = *(_QWORD *)&position->x;
		  *(float *)&position = position->z;
		  *(_QWORD *)&v21.Position.x = v9;
		  v21.Radius = this->fields.m_Radius;
		  m_Data = this->fields.m_Data;
		  LODWORD(v21.Position.z) = (_DWORD)position;
		  v20 = m_Data;
		  v12 = UnityEngine::Vector4::op_Implicit(&v19, &v20, v11);
		  v13 = *(_QWORD *)&v12->x;
		  v21.Payload.z = v12->z;
		  v21.Mode = this->fields.m_ModifierMode;
		  v21.Operation = this->fields.m_SdfOperation;
		  *(_QWORD *)&v21.Payload.x = v13;
		  v14 = *(_OWORD *)&v21.Payload.x;
		  *(_OWORD *)&retstr->Position.x = *(_OWORD *)&v21.Position.x;
		  v15 = *(_OWORD *)&v21.Operation;
		LABEL_7:
		  *(_OWORD *)&retstr->Payload.x = v14;
		  result = retstr;
		  *(_OWORD *)&retstr->Operation = v15;
		  return result;
		}
		
	}
}
