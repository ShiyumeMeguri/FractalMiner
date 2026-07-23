using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/ContactShadow", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class ContactShadowVolume : VolumeComponent // TypeDefIndex: 38010
	{
		// Fields
		public ClampedFloatParameter shadowIntensity; // 0x30
		public ClampedFloatParameter surfaceThickness; // 0x38
		public ClampedFloatParameter bilinearThreshold; // 0x40
		public ClampedIntParameter shadowContrast; // 0x48
		public BoolParameter ignoreEdgePixels; // 0x50
	
		// Constructors
		public ContactShadowVolume() {} // 0x00000001844056C0-0x0000000184405820
		// ContactShadowVolume()
		void HG::Rendering::Runtime::ContactShadowVolume::ContactShadowVolume(ContactShadowVolume *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  IntParameter *v14; // rax
		  ClampedIntParameter *v15; // rdi
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  BoolParameter *v19; // rax
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v3 )
		    goto LABEL_7;
		  *(_DWORD *)(v3 + 24) = 1056964608;
		  *(_BYTE *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 32) = 0;
		  *(_DWORD *)(v3 + 36) = 1065353216;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  this->fields.shadowIntensity = (ClampedFloatParameter *)v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowIntensity, v4, v6, v7, v22);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_7;
		  *(_DWORD *)(v8 + 24) = 1061997773;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 1053609165;
		  *(_DWORD *)(v8 + 36) = 1065353216;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.surfaceThickness = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.surfaceThickness, v4, v9, v10, v23);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_7;
		  *(_DWORD *)(v11 + 24) = 0x40000000;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0x40000000;
		  *(_DWORD *)(v11 + 36) = 1084227584;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.bilinearThreshold = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bilinearThreshold, v4, v12, v13, v24);
		  v14 = (IntParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
		  v15 = (ClampedIntParameter *)v14;
		  if ( !v14
		    || (UnityEngine::Rendering::IntParameter::IntParameter(v14, 4, 0, 0LL),
		        v15->fields.min = 1,
		        v15->fields.max = 4,
		        this->fields.shadowContrast = v15,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.shadowContrast, v16, v17, v18, v25),
		        (v19 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter)) == 0LL) )
		  {
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  v19->fields._.m_Value = 0;
		  v19->fields._._.overrideState = 0;
		  this->fields.ignoreEdgePixels = v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.ignoreEdgePixels, v4, v20, v21, v26);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	}
}
