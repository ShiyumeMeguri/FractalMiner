using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGGrassData", menuName = "\u2605 Beyond/HG Grass Data")]
	public class HGGrassData : ScriptableObject // TypeDefIndex: 37993
	{
		// Fields
		public int version; // 0x18
		public Bounds bounds; // 0x1C
		public List<GrassCluster> clusters; // 0x38
	
		// Constructors
		public HGGrassData() {} // 0x0000000189B6B954-0x0000000189B6B9AC
		// HGGrassData()
		void HG::Rendering::Runtime::HGGrassData::HGGrassData(HGGrassData *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_GrassCluster_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassCluster>);
		  v6 = (List_1_HG_Rendering_Runtime_GrassCluster_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassCluster>::List);
		  this->fields.clusters = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.clusters, v7, v8, v9, v10);
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
