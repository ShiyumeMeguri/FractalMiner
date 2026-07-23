using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Shadowing/Disable Directional Shadow", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class HGDisableDirectionalShadowComponent : VolumeComponent // TypeDefIndex: 37840
	{
		// Fields
		public ClampedFloatParameter m_DisableDirectionalShadow; // 0x30
		public ClampedFloatParameter m_DirectionalShadowAttenuation; // 0x38
	
		// Constructors
		public HGDisableDirectionalShadowComponent() {} // 0x0000000184791D20-0x0000000184791DC0
		// HGDisableDirectionalShadowComponent()
		void HG::Rendering::Runtime::HGDisableDirectionalShadowComponent::HGDisableDirectionalShadowComponent(
		        HGDisableDirectionalShadowComponent *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v3 )
		    goto LABEL_4;
		  *(_DWORD *)(v3 + 36) = 1065353216;
		  *(_DWORD *)(v3 + 24) = 0;
		  *(_BYTE *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 32) = 0;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  this->fields.m_DisableDirectionalShadow = (ClampedFloatParameter *)v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DisableDirectionalShadow, v4, v6, v7, v11);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1065353216;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.m_DirectionalShadowAttenuation = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_DirectionalShadowAttenuation, v4, v9, v10, v12);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	}
}
