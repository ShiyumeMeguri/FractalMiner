using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class GpuClothMatrixGenerator : MonoBehaviour // TypeDefIndex: 37581
	{
		// Fields
		public float matrixInterval; // 0x18
		public uint matrixWidth; // 0x1C
		public uint matrixHeight; // 0x20
	
		// Constructors
		public GpuClothMatrixGenerator() {} // 0x0000000189C6D908-0x0000000189C6D934
		// GpuClothMatrixGenerator()
		void HG::Rendering::Runtime::GpuClothMatrixGenerator::GpuClothMatrixGenerator(
		        GpuClothMatrixGenerator *this,
		        MethodInfo *method)
		{
		  this->fields.matrixInterval = 10.0;
		  this->fields.matrixWidth = 5;
		  this->fields.matrixHeight = 5;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void Start() {} // 0x0000000189C6D694-0x0000000189C6D908
		// Void Start()
		void HG::Rendering::Runtime::GpuClothMatrixGenerator::Start(GpuClothMatrixGenerator *this, MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Transform *v6; // rax
		  Transform *v7; // rax
		  int v8; // edi
		  int v9; // esi
		  Object *v10; // rax
		  String *v11; // r15
		  GameObject *v12; // rax
		  GameObject *v13; // r14
		  Transform *v14; // r15
		  Transform *v15; // rax
		  MethodInfo *v16; // rdx
		  Vector3 *fwd; // rax
		  __int64 v18; // xmm3_8
		  MethodInfo *v19; // rdx
		  Vector3 *right; // rax
		  __int64 v21; // xmm1_8
		  MethodInfo *v22; // r9
		  Vector3 *v23; // rax
		  __int64 v24; // xmm1_8
		  MethodInfo *v25; // r9
		  Vector3 *v26; // rax
		  __int64 v27; // xmm1_8
		  MethodInfo *v28; // r9
		  Vector3 *v29; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Transform *v32; // r9
		  __int64 v33; // xmm0_8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v36; // [rsp+28h] [rbp-59h] BYREF
		  Vector3 v37; // [rsp+38h] [rbp-49h] BYREF
		  Vector3 v38; // [rsp+48h] [rbp-39h] BYREF
		  Vector3 v39; // [rsp+58h] [rbp-29h] BYREF
		  Vector3 v40; // [rsp+68h] [rbp-19h] BYREF
		  Vector3 v41; // [rsp+78h] [rbp-9h] BYREF
		  Vector3 v42; // [rsp+88h] [rbp+7h] BYREF
		  Vector3 v43; // [rsp+98h] [rbp+17h] BYREF
		  Vector3 v44; // [rsp+A8h] [rbp+27h] BYREF
		  Vector3 v45; // [rsp+B8h] [rbp+37h] BYREF
		  uint32_t v46; // [rsp+F8h] [rbp+77h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1319, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1319, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( !transform )
		      goto LABEL_15;
		    UnityEngine::Transform::get_position(&v36, transform, 0LL);
		    v6 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( !v6 )
		      goto LABEL_15;
		    UnityEngine::Transform::get_right(&v36, v6, 0LL);
		    v7 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( !v7 )
		      goto LABEL_15;
		    UnityEngine::Transform::get_forward(&v36, v7, 0LL);
		    v8 = 0;
		    if ( this->fields.matrixHeight )
		    {
		      while ( 1 )
		      {
		        v9 = 0;
		        if ( this->fields.matrixWidth )
		          break;
		LABEL_11:
		        if ( ++v8 >= this->fields.matrixHeight )
		          return;
		      }
		      while ( 1 )
		      {
		        v46 = v9 + this->fields.matrixWidth * v8;
		        v10 = (Object *)il2cpp_value_box_0(TypeInfo::System::UInt32, &v46);
		        v11 = System::String::Format((String *)"clothInfo{0}", v10, 0LL);
		        v12 = (GameObject *)sub_18002C620(TypeInfo::UnityEngine::GameObject);
		        v13 = v12;
		        if ( !v12 )
		          break;
		        UnityEngine::GameObject::GameObject(v12, v11, 0LL);
		        v14 = UnityEngine::GameObject::get_transform(v13, 0LL);
		        v15 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( !v14 )
		          break;
		        UnityEngine::Transform::SetParent(v14, v15, 1, 0LL);
		        UnityEngine::GameObject::get_transform(v13, 0LL);
		        fwd = UnityEngine::Vector3::get_fwd(&v41, v16);
		        v18 = *(_QWORD *)&fwd->x;
		        v38.z = fwd->z;
		        *(_QWORD *)&v38.x = v18;
		        right = UnityEngine::Vector3::get_right(&v42, v19);
		        v21 = *(_QWORD *)&right->x;
		        *(float *)&right = right->z;
		        *(_QWORD *)&v37.x = v21;
		        LODWORD(v37.z) = (_DWORD)right;
		        v23 = UnityEngine::Vector3::op_Multiply(&v43, (float)v9 * this->fields.matrixInterval, &v37, v22);
		        v24 = *(_QWORD *)&v23->x;
		        v39.z = v23->z;
		        *(_QWORD *)&v39.x = v24;
		        v26 = UnityEngine::Vector3::op_Multiply(&v44, (float)v8 * this->fields.matrixInterval, &v38, v25);
		        v27 = *(_QWORD *)&v26->x;
		        *(float *)&v26 = v26->z;
		        *(_QWORD *)&v40.x = v27;
		        LODWORD(v40.z) = (_DWORD)v26;
		        v29 = UnityEngine::Vector3::op_Addition(&v45, &v40, &v39, v28);
		        if ( !v32 )
		          sub_1800D8260(v31, v30);
		        v33 = *(_QWORD *)&v29->x;
		        z = v29->z;
		        *(_QWORD *)&v36.x = v33;
		        v36.z = z;
		        UnityEngine::Transform::set_localPosition(v32, &v36, 0LL);
		        UnityEngine::GameObject::AddComponent<System::Object>(
		          v13,
		          MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::ClothInfo>);
		        if ( ++v9 >= this->fields.matrixWidth )
		          goto LABEL_11;
		      }
		LABEL_15:
		      sub_1800D8260(v5, v4);
		    }
		  }
		}
		
	}
}
