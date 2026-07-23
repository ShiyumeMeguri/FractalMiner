using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG
{
	[ExecuteInEditMode]
	public class SceneMeshBatchGroup : MonoBehaviour // TypeDefIndex: 37397
	{
		// Fields
		public Object[] batchedMeshesFbx; // 0x18
		public Object colliderMeshFbx; // 0x20
		public Object ikColliderMeshFbx; // 0x28
		public Object batchedPrefab; // 0x30
		public BatchGroupSetting batchGroupSetting; // 0x38
	
		// Constructors
		public SceneMeshBatchGroup() {} // 0x0000000189B32250-0x0000000189B32290
		// SceneMeshBatchGroup()
		void HG::SceneMeshBatchGroup::SceneMeshBatchGroup(SceneMeshBatchGroup *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  MethodInfo *v6; // [rsp+20h] [rbp-8h]
		
		  this->fields.batchGroupSetting = HG::BatchGroupSetting::CreateDefault(0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.batchGroupSetting, v3, v4, v5, v6);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	}
}
