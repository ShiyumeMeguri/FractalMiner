using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Editor
{
	public class HGIrradianceVolumeBakingEditor : MonoBehaviour // TypeDefIndex: 37487
	{
		// Fields
		private const int MAX_SCENE_SIZE = 4096; // Metadata: 0x02302DA5
		private const string HGBAKER_EXE_PATH = "Packages/com.hg.render-pipelines/Editor/Tools/IrradianceVolume/HGBaker.exe"; // Metadata: 0x02302DA7
		private const string GLOBAL_ENV_SETTING_PATH = "Assets/Beyond/Arts/Environment/LightingEnv/GlobalConfigs/map01/Setting.asset"; // Metadata: 0x02302DF3
		private const string IV_VOLUME_ICON_PATH = "Packages/com.hg.render-pipelines/Editor/RenderPipelineResources/Texture/CustomPassVolume.png"; // Metadata: 0x02302E41
		private int iteration; // 0x18
		private int sampleCount; // 0x1C
		public BakingVoxelSize currentBakingVoxelSize; // 0x20
		public BakingQuality currentBakingQuality; // 0x24
		[HideInInspector]
		private float chunkSize; // 0x28
		public bool useAssetCache; // 0x2C
		public bool enableLocalLighting; // 0x2D
		public bool indoor; // 0x2E
		[Header("\u53CC\u91CDVolume\u9632\u6F0F\u5149(\u5F00\u53D1\u4E2D)")]
		public bool dualSet; // 0x2F
		[Header("\u4EC5\u8868\u9762\u751F\u6210")]
		public bool surfaceOnly; // 0x30
		[Header("render\u6307\u5B9A\u573A\u666F\u72B6\u6001")]
		public List<string> renderStateList; // 0x38
		private string m_rootPath; // 0x40
		private HashSet<Vector3> m_BakingStartPosSet; // 0x48
		private HashSet<ValueTuple<Vector3, Vector3>> m_BakingRangeSet; // 0x50
		public static bool shouldDrawGizmo; // 0x00
	
		// Nested types
		public enum BakingVoxelSize // TypeDefIndex: 37484
		{
			HalfMeter = 0,
			TwoMeter = 1,
			SixteenMeter = 3
		}
	
		public enum BakingQuality // TypeDefIndex: 37485
		{
			Low = 0,
			Medium = 1,
			High = 2,
			Ultra = 3
		}
	
		internal class TransformWorldPlacement // TypeDefIndex: 37486
		{
			// Fields
			public Vector3 position; // 0x10
			public Quaternion rotation; // 0x1C
			public Vector3 scale; // 0x2C
	
			// Constructors
			public TransformWorldPlacement() {} // 0x0000000189B427D4-0x0000000189B4282C
			// HGIrradianceVolumeBakingEditor+TransformWorldPlacement()
			void HG::Rendering::Editor::HGIrradianceVolumeBakingEditor::TransformWorldPlacement::TransformWorldPlacement(
			        HGIrradianceVolumeBakingEditor_TransformWorldPlacement *this,
			        MethodInfo *method)
			{
			  MethodInfo *v2; // r9
			  Vector3 *Vector; // rax
			  MethodInfo *z_low; // rdx
			  __int64 v5; // r8
			  Quaternion *identity; // rax
			  __int64 v7; // r8
			  MethodInfo *v8; // rdx
			  Vector3 *one; // rax
			  float z; // ecx
			  __int64 v11; // r8
			  Quaternion v12; // [rsp+20h] [rbp-18h] BYREF
			
			  Vector = UnityEngine::Animator::GetVector((Vector3 *)&v12, (Animator *)method, (int32_t)this, v2);
			  z_low = (MethodInfo *)LODWORD(Vector->z);
			  *(_QWORD *)(v5 + 16) = *(_QWORD *)&Vector->x;
			  *(_DWORD *)(v5 + 24) = (_DWORD)z_low;
			  identity = UnityEngine::Quaternion::get_identity(&v12, z_low);
			  *(__m128i *)(v7 + 28) = _mm_loadu_si128((const __m128i *)identity);
			  one = UnityEngine::Vector3::get_one((Vector3 *)&v12, v8);
			  z = one->z;
			  *(_QWORD *)(v11 + 44) = *(_QWORD *)&one->x;
			  *(float *)(v11 + 52) = z;
			}
			
			public TransformWorldPlacement(Transform t) {} // 0x0000000189B4282C-0x0000000189B428A8
			// HGIrradianceVolumeBakingEditor+TransformWorldPlacement(Transform)
			void HG::Rendering::Editor::HGIrradianceVolumeBakingEditor::TransformWorldPlacement::TransformWorldPlacement(
			        HGIrradianceVolumeBakingEditor_TransformWorldPlacement *this,
			        Transform *t,
			        MethodInfo *method)
			{
			  Vector3 *position; // rax
			  float z; // ecx
			  Vector3 *localScale; // rax
			  float v8; // ecx
			  Quaternion v9; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( !t )
			    sub_1800D8260(this, 0LL);
			  position = UnityEngine::Transform::get_position((Vector3 *)&v9, t, 0LL);
			  z = position->z;
			  *(_QWORD *)&this->fields.position.x = *(_QWORD *)&position->x;
			  this->fields.position.z = z;
			  this->fields.rotation = (Quaternion)_mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_rotation(&v9, t, 0LL));
			  localScale = UnityEngine::Transform::get_localScale((Vector3 *)&v9, t, 0LL);
			  v8 = localScale->z;
			  *(_QWORD *)&this->fields.scale.x = *(_QWORD *)&localScale->x;
			  this->fields.scale.z = v8;
			}
			
		}
	
		// Constructors
		public HGIrradianceVolumeBakingEditor() {} // 0x0000000189B35758-0x0000000189B35838
		// HGIrradianceVolumeBakingEditor()
		void HG::Rendering::Editor::HGIrradianceVolumeBakingEditor::HGIrradianceVolumeBakingEditor(
		        HGIrradianceVolumeBakingEditor *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_System_String_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  HashSet_1_UnityEngine_Vector3_ *v10; // rax
		  HashSet_1_UnityEngine_Vector3_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  HashSet_1_System_ValueTuple_2_UnityEngine_Vector3_UnityEngine_Vector3_ *v15; // rax
		  HashSet_1_System_ValueTuple_2_UnityEngine_Vector3_UnityEngine_Vector3_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		
		  this->fields.iteration = 1024;
		  this->fields.sampleCount = 256;
		  this->fields.currentBakingVoxelSize = 1;
		  this->fields.chunkSize = 64.0;
		  *(_WORD *)&this->fields.useAssetCache = 257;
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<System::String>);
		  v6 = (List_1_System_String_ *)v3;
		  if ( !v3 )
		    goto LABEL_5;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<System::String>::List);
		  this->fields.renderStateList = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.renderStateList, v7, v8, v9, v20);
		  v10 = (HashSet_1_UnityEngine_Vector3_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Vector3>);
		  v11 = v10;
		  if ( !v10
		    || (System::Collections::Generic::HashSet<UnityEngine::Vector3>::HashSet(
		          v10,
		          MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Vector3>::HashSet),
		        this->fields.m_BakingStartPosSet = v11,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_BakingStartPosSet, v12, v13, v14, v21),
		        v15 = (HashSet_1_System_ValueTuple_2_UnityEngine_Vector3_UnityEngine_Vector3_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<System::ValueTuple<UnityEngine::Vector3,UnityEngine::Vector3>>),
		        (v16 = v15) == 0LL) )
		  {
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::HashSet<System::ValueTuple<UnityEngine::Vector3,UnityEngine::Vector3>>::HashSet(
		    v15,
		    MethodInfo::System::Collections::Generic::HashSet<System::ValueTuple<UnityEngine::Vector3,UnityEngine::Vector3>>::HashSet);
		  this->fields.m_BakingRangeSet = v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_BakingRangeSet, v17, v18, v19, v22);
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
		static HGIrradianceVolumeBakingEditor() {} // 0x0000000184DA1200-0x0000000184DA1220
		// HGIrradianceVolumeBakingEditor()
		void HG::Rendering::Editor::HGIrradianceVolumeBakingEditor::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Editor::HGIrradianceVolumeBakingEditor->static_fields->shouldDrawGizmo = 1;
		}
		
	}
}
