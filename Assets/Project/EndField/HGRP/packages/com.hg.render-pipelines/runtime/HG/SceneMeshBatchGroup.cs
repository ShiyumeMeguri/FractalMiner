using System;
using UnityEngine;

namespace HG
{
	[ExecuteInEditMode]
	public class SceneMeshBatchGroup : MonoBehaviour
	{
		public SceneMeshBatchGroup()
		{
		}

		public global::UnityEngine.Object[] batchedMeshesFbx;

		public global::UnityEngine.Object colliderMeshFbx;

		public global::UnityEngine.Object ikColliderMeshFbx;

		public global::UnityEngine.Object batchedPrefab;

		public BatchGroupSetting batchGroupSetting;
	}
}
