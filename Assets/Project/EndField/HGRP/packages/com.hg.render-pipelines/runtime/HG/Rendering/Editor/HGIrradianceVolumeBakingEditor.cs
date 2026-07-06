using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Editor
{
	public class HGIrradianceVolumeBakingEditor : MonoBehaviour
	{
		public HGIrradianceVolumeBakingEditor()
		{
		}

		private const int MAX_SCENE_SIZE = 4096;

		private const string HGBAKER_EXE_PATH = "Packages/com.hg.render-pipelines/Editor/Tools/IrradianceVolume/HGBaker.exe";

		private const string GLOBAL_ENV_SETTING_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/GlobalConfigs/map01/Setting.asset";

		private const string IV_VOLUME_ICON_PATH = "Packages/com.hg.render-pipelines/Editor/RenderPipelineResources/Texture/CustomPassVolume.png";

		private int iteration;

		private int sampleCount;

		public HGIrradianceVolumeBakingEditor.BakingVoxelSize currentBakingVoxelSize;

		public HGIrradianceVolumeBakingEditor.BakingQuality currentBakingQuality;

		[HideInInspector]
		private float chunkSize;

		public bool useAssetCache;

		public bool enableLocalLighting;

		public bool indoor;

		[Header("双重Volume防漏光(开发中)")]
		public bool dualSet;

		[Header("仅表面生成")]
		public bool surfaceOnly;

		[Header("render指定场景状态")]
		public List<string> renderStateList;

		private string m_rootPath;

		private HashSet<Vector3> m_BakingStartPosSet;

		private HashSet<ValueTuple<Vector3, Vector3>> m_BakingRangeSet;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static bool shouldDrawGizmo;

		public enum BakingVoxelSize
		{
			[InspectorName("0.5m")]
			HalfMeter,
			[InspectorName("2m-default")]
			TwoMeter,
			[InspectorName("16m")]
			SixteenMeter = 3
		}

		public enum BakingQuality
		{
			Low,
			Medium,
			High,
			Ultra
		}

		internal class TransformWorldPlacement
		{
			public TransformWorldPlacement()
			{
				// // HGIrradianceVolumeBakingEditor+TransformWorldPlacement()
				// void HG::Rendering::Editor::HGIrradianceVolumeBakingEditor::TransformWorldPlacement::TransformWorldPlacement(
				//         HGIrradianceVolumeBakingEditor_TransformWorldPlacement *this,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v2; // r9
				//   Vector3 *Vector; // rax
				//   MethodInfo *z_low; // rdx
				//   __int64 v5; // r8
				//   Quaternion *identity; // rax
				//   __int64 v7; // r8
				//   MethodInfo *v8; // rdx
				//   Vector3 *one; // rax
				//   float z; // ecx
				//   __int64 v11; // r8
				//   Quaternion v12; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   Vector = UnityEngine::Animator::GetVector((Vector3 *)&v12, (Animator *)method, (int32_t)this, v2);
				//   z_low = (MethodInfo *)LODWORD(Vector.z);
				//   *(_QWORD *)(v5 + 16) = *(_QWORD *)&Vector.x;
				//   *(_DWORD *)(v5 + 24) = (_DWORD)z_low;
				//   identity = UnityEngine::Quaternion::get_identity(&v12, z_low);
				//   *(__m128i *)(v7 + 28) = _mm_loadu_si128((const __m128i *)identity);
				//   one = UnityEngine::Vector3::get_one((Vector3 *)&v12, v8);
				//   z = one.z;
				//   *(_QWORD *)(v11 + 44) = *(_QWORD *)&one.x;
				//   *(float *)(v11 + 52) = z;
				// }
				// 
			}

			public TransformWorldPlacement(Transform t)
			{
				// // HGIrradianceVolumeBakingEditor+TransformWorldPlacement(Transform)
				// void HG::Rendering::Editor::HGIrradianceVolumeBakingEditor::TransformWorldPlacement::TransformWorldPlacement(
				//         HGIrradianceVolumeBakingEditor_TransformWorldPlacement *this,
				//         Transform *t,
				//         MethodInfo *method)
				// {
				//   Vector3 *position; // rax
				//   float z; // ecx
				//   Vector3 *localScale; // rax
				//   float v8; // ecx
				//   Quaternion v9; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !t )
				//     sub_180B536AC(this, 0LL);
				//   position = UnityEngine::Transform::get_position((Vector3 *)&v9, t, 0LL);
				//   z = position.z;
				//   *(_QWORD *)&this.fields.position.x = *(_QWORD *)&position.x;
				//   this.fields.position.z = z;
				//   this.fields.rotation = (Quaternion)_mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_rotation(&v9, t, 0LL));
				//   localScale = UnityEngine::Transform::get_localScale((Vector3 *)&v9, t, 0LL);
				//   v8 = localScale.z;
				//   *(_QWORD *)&this.fields.scale.x = *(_QWORD *)&localScale.x;
				//   this.fields.scale.z = v8;
				// }
				// 
			}

			public Vector3 position;

			public Quaternion rotation;

			public Vector3 scale;
		}
	}
}
