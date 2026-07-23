using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class GrassCluster // TypeDefIndex: 37994
	{
		// Fields
		public Bounds bounds; // 0x10
		public float rendererHalfSize; // 0x28
		public HGObjectFlags objectFlags; // 0x2C
		public List<GrassRenderer> renderers; // 0x30
		public List<GrassPerInstanceData> perInstanceDatas; // 0x38
	
		// Constructors
		public GrassCluster() {} // 0x0000000189B6920C-0x0000000189B6928C
		// GrassCluster()
		void HG::Rendering::Runtime::GrassCluster::GrassCluster(GrassCluster *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_GrassRenderer_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v10; // rax
		  List_1_UnityEngine_HyperGryph_ECS_GrassPerInstanceData_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassRenderer>);
		  v6 = (List_1_HG_Rendering_Runtime_GrassRenderer_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		          v3,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassRenderer>::List),
		        this->fields.renderers = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.renderers, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>),
		        (v11 = (List_1_UnityEngine_HyperGryph_ECS_GrassPerInstanceData_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>::List);
		  this->fields.perInstanceDatas = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.perInstanceDatas, v12, v13, v14, v16);
		}
		
	}
}
