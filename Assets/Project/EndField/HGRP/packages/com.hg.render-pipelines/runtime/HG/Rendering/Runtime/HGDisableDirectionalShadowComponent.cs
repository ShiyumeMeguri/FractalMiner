using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Shadowing/Disable Directional Shadow", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class HGDisableDirectionalShadowComponent : VolumeComponent
	{
		public HGDisableDirectionalShadowComponent()
		{
			// // HGDisableDirectionalShadowComponent()
			// void HG::Rendering::Runtime::HGDisableDirectionalShadowComponent::HGDisableDirectionalShadowComponent(
			//         HGDisableDirectionalShadowComponent *this,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v2; // xmm6_8
			//   ClampedFloatParameter *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ClampedFloatParameter *v7; // rdi
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   ClampedFloatParameter *v11; // rax
			//   ClampedFloatParameter *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v20; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8EDD07 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     byte_18D8EDD07 = 1;
			//   }
			//   v4 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v7 = v4;
			//   if ( !v4
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v4, 0.0, 0.0, 1.0, 0, 0LL),
			//         this.fields.m_DisableDirectionalShadow = v7,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.m_DisableDirectionalShadow,
			//           v8,
			//           v9,
			//           v10,
			//           overrideState,
			//           (String *)methoda,
			//           v2),
			//         v11 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v12 = v11) == 0LL) )
			//   {
			//     sub_180B536AC(v6, v5);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v11, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.m_DirectionalShadowAttenuation = v12;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_DirectionalShadowAttenuation,
			//     v13,
			//     v14,
			//     v15,
			//     overrideStatea,
			//     (String *)methodb,
			//     v20);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public ClampedFloatParameter m_DisableDirectionalShadow;

		public ClampedFloatParameter m_DirectionalShadowAttenuation;
	}
}
