using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("RayTracing/RayTracingReflection", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class RayTracingReflectionVolume : VolumeComponent // TypeDefIndex: 38057
	{
		// Fields
		public FloatParameter enable; // 0x30
		public RayTracingReflectionModeParameter mode; // 0x38
	
		// Constructors
		public RayTracingReflectionVolume() {} // 0x00000001848916C0-0x0000000184891740
		// RayTracingReflectionVolume()
		void HG::Rendering::Runtime::RayTracingReflectionVolume::RayTracingReflectionVolume(
		        RayTracingReflectionVolume *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  RayTracingReflectionModeParameter *v8; // rax
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v3
		    || (*(_DWORD *)(v3 + 24) = 0,
		        *(_BYTE *)(v3 + 16) = 0,
		        this->fields.enable = (FloatParameter *)v3,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enable, v4, v6, v7, v11),
		        (v8 = (RayTracingReflectionModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::RayTracingReflectionModeParameter)) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  v8->fields._.m_Value = 0;
		  v8->fields._._.overrideState = 0;
		  this->fields.mode = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mode, v4, v9, v10, v12);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	}
}
