using System;
using System.Runtime.CompilerServices;
using Beyond;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[ExecuteInEditMode]
	[AddComponentMenu("Rendering/Fake Volume Fog(假雾)")]
	public class VFXFakeVolumeFog : TickableMono, IBeyondTrigger, IBeyondTriggerTransform, IBeyondTriggerShape, IBeyondTriggerProxy
	{
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000025D2 File Offset: 0x000007D2
		public MeshRenderer meshRender
		{
			get
			{
				// // StyleValues get_to()
				// StyleValues UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_to(
				//         ValueAnimation_1_StyleValues_ *this,
				//         MethodInfo *method)
				// {
				//   return (StyleValues)this.fields._to_k__BackingField.m_StyleValues;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x000025D2 File Offset: 0x000007D2
		public MeshFilter meshFilter
		{
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::ContactPoint2D>::get_propertyPath(
				//         Variable_1_UnityEngine_ContactPoint2D_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x000025F0 File Offset: 0x000007F0
		protected override float tickInterval
		{
			get
			{
				// // Single get_loopDuration()
				// float Beyond::Rendering::EntityVFXControllerStateBase::get_loopDuration(
				//         EntityVFXControllerStateBase *this,
				//         MethodInfo *method)
				// {
				//   return 1.0;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00002950 File Offset: 0x00000B50
		protected override TickType tickOption
		{
			get
			{
				// // TickType get_tickOption()
				// TickType__Enum HG::Rendering::Runtime::VFXFakeVolumeFog::get_tickOption(VFXFakeVolumeFog *this, MethodInfo *method)
				// {
				//   if ( this.fields.LightArtUSE )
				//     return this.fields.enableDistanceCullTick ? 8 : 0;
				//   else
				//     return 0;
				// }
				// 
				return (TickType)TickType.None;
			}
		}

		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00002968 File Offset: 0x00000B68
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x000025D0 File Offset: 0x000007D0
		public ulong uniqueTriggerId
		{
			[CompilerGenerated]
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<Beyond::Gameplay::AI::AIEntity>::get_propertyPath(
				//         Variable_1_Beyond_Gameplay_AI_AIEntity_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return 0UL;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_uniqueTriggerId(UInt64)
				// void HG::Rendering::Runtime::VFXFakeVolumeFog::set_uniqueTriggerId(
				//         VFXFakeVolumeFog *this,
				//         uint64_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._uniqueTriggerId_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00002980 File Offset: 0x00000B80
		public ETriggerLogicType triggerLogicType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<UnityEngine::Vector4,UnityEngine::Vector4,UnityEngine::Vector4>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return 3;
				// }
				// 
				return (ETriggerLogicType)ETriggerLogicType.None;
			}
		}

		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 position
		{
			get
			{
				// // Vector3 get_position()
				// Vector3 *Slate::ShotCamera::get_position(Vector3 *__return_ptr retstr, ShotCamera *this, MethodInfo *method)
				// {
				//   Transform *transform; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   Vector3 *position; // rax
				//   __int64 v8; // xmm0_8
				//   Vector3 v10[2]; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
				//   if ( !transform )
				//     sub_180B536AC(v6, v5);
				//   position = UnityEngine::Transform::get_position(v10, transform, 0LL);
				//   v8 = *(_QWORD *)&position.x;
				//   *(float *)&position = position.z;
				//   *(_QWORD *)&retstr.x = v8;
				//   LODWORD(retstr.z) = (_DWORD)position;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000025D2 File Offset: 0x000007D2
		public Quaternion rotation
		{
			get
			{
				// // Quaternion get_rotation()
				// Quaternion *Slate::ShotCamera::get_rotation(Quaternion *__return_ptr retstr, ShotCamera *this, MethodInfo *method)
				// {
				//   Transform *transform; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   Quaternion v7; // xmm0
				//   Quaternion *result; // rax
				//   Quaternion v9; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
				//   if ( !transform )
				//     sub_180B536AC(v6, v5);
				//   v7 = *UnityEngine::Transform::get_rotation(&v9, transform, 0LL);
				//   result = retstr;
				//   *retstr = v7;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00002608 File Offset: 0x00000808
		public int shapeType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<Beyond::Gameplay::Core::AbilitySystem::Modifier,System::Object>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_2_Beyond_Gameplay_Core_AbilitySystem_Modifier_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 2;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 shapeOffset
		{
			get
			{
				// // Vector3 get_initialLocalRotation()
				// Vector3 *Slate::DirectorGroup::get_initialLocalRotation(
				//         Vector3 *__return_ptr retstr,
				//         DirectorGroup *this,
				//         MethodInfo *method)
				// {
				//   Vector3 *result; // rax
				// 
				//   result = retstr;
				//   *(_QWORD *)&retstr.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   retstr.z = 0.0;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 shapeSize
		{
			get
			{
				// // Vector3 get_shapeSize()
				// Vector3 *HG::Rendering::Runtime::VFXFakeVolumeFog::get_shapeSize(
				//         Vector3 *__return_ptr retstr,
				//         VFXFakeVolumeFog *this,
				//         MethodInfo *method)
				// {
				//   Transform *transform; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   Vector3 *lossyScale; // rax
				//   __int64 v8; // xmm0_8
				//   Vector3 v10[2]; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
				//   if ( !transform )
				//     sub_180B536AC(v6, v5);
				//   lossyScale = UnityEngine::Transform::get_lossyScale(v10, transform, 0LL);
				//   v8 = *(_QWORD *)&lossyScale.x;
				//   *(float *)&lossyScale = lossyScale.z;
				//   *(_QWORD *)&retstr.x = v8;
				//   LODWORD(retstr.z) = (_DWORD)lossyScale;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000025F0 File Offset: 0x000007F0
		public float shapeRadius
		{
			get
			{
				// // Single get_loopDuration()
				// float Beyond::Rendering::EntityVFXControllerStateBase::get_loopDuration(
				//         EntityVFXControllerStateBase *this,
				//         MethodInfo *method)
				// {
				//   return 1.0;
				// }
				// 
				return 0f;
			}
		}

		public VFXFakeVolumeFog()
		{
			// // VFXFakeVolumeFog()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::VFXFakeVolumeFog(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   __m128i v2; // xmm1
			//   int v3; // edx
			//   __int64 v4; // r8
			//   Vector4 v5; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields.enableDistanceCullTick = 1;
			//   this.fields.nearFadeDisatance = 1.0;
			//   this.fields.nearDisplayDisatance = 1.0;
			//   v2 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v5, (MethodInfo *)0x3F800000));
			//   *(_DWORD *)(v4 + 184) = v3;
			//   *(_QWORD *)(v4 + 232) = _mm_unpacklo_ps((__m128)0x3E4CCCCDu, (__m128)0x3E4CCCCDu).m128_u64[0];
			//   *(_DWORD *)(v4 + 240) = 1045220557;
			//   *(_DWORD *)(v4 + 208) = v3;
			//   *(_DWORD *)(v4 + 220) = v3;
			//   *(_DWORD *)(v4 + 224) = v3;
			//   *(_DWORD *)(v4 + 228) = v3;
			//   *(_DWORD *)(v4 + 244) = 1008981770;
			//   *(_DWORD *)(v4 + 264) = 1008981770;
			//   *(_DWORD *)(v4 + 272) = v3;
			//   *(_QWORD *)(v4 + 248) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
			//   *(_DWORD *)(v4 + 256) = 0;
			//   *(__m128i *)(v4 + 164) = v2;
			//   *(_DWORD *)(v4 + 180) = 1000593162;
			//   *(_DWORD *)(v4 + 200) = 1148846080;
			//   *(_DWORD *)(v4 + 204) = 1056964608;
			//   *(_DWORD *)(v4 + 212) = 1056964608;
			//   *(_DWORD *)(v4 + 260) = 1036831949;
			//   *(_DWORD *)(v4 + 276) = 1157234688;
			//   Beyond::TickableMono::TickableMono((TickableMono *)v4, 0LL);
			// }
			// 
		}

		private void OnCanWalkInChanged()
		{
			// // Void OnCanWalkInChanged()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnCanWalkInChanged(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1986, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1986, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.canWalkIn )
			//   {
			//     this.fields.nearDisplay = 0;
			//   }
			// }
			// 
		}

		private void OnNearDisplayChanged()
		{
			// // Void OnNearDisplayChanged()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnNearDisplayChanged(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1987, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1987, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.nearDisplay )
			//   {
			//     this.fields.canWalkIn = 0;
			//   }
			// }
			// 
		}

		private void _InitMeshFilterAndRender()
		{
		}

		protected override void OnAwake()
		{
			// // Void OnAwake()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnAwake(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1989, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1989, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Beyond::TickableMono::OnAwake((TickableMono *)this, 0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
			//   }
			// }
			// 
		}

		public override void Tick(float deltaTime)
		{
			// // Void Tick(Single)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::Tick(VFXFakeVolumeFog *this, float deltaTime, MethodInfo *method)
			// {
			//   Object_1 *m_meshRenderer; // rbx
			//   int32_t frameCount; // esi
			//   struct VFXFakeVolumeFog__Class *v6; // rdx
			//   Camera *main; // rbx
			//   HGRenderPathBase_HGRenderPathResources *static_fields; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   Object_1 *s_cachedMainCamera; // rbx
			//   __int64 v12; // rdx
			//   Component *v13; // rcx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __int64 v16; // xmm6_8
			//   float z; // ebx
			//   Transform *v18; // rax
			//   Vector3 *v19; // rax
			//   MethodInfo *v20; // xmm0_8
			//   float v21; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v23; // [rsp+20h] [rbp-38h] BYREF
			//   MethodInfo *v24; // [rsp+28h] [rbp-30h]
			//   Vector3 v25; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9193F4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//     byte_18D9193F4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1990, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1990, 0LL);
			//     if ( !Patch )
			//       goto LABEL_15;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       deltaTime,
			//       0LL);
			//   }
			//   else if ( this.fields.LightArtUSE )
			//   {
			//     m_meshRenderer = (Object_1 *)this.fields.m_meshRenderer;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality(m_meshRenderer, 0LL, 0LL) )
			//     {
			//       frameCount = UnityEngine::Time::get_frameCount(0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//       v6 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
			//       if ( TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_cameraCheckFrame != frameCount )
			//       {
			//         main = UnityEngine::Camera::get_main(0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//         static_fields = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//         static_fields[7].defaultResources = (HGRenderPipelineRuntimeResources *)main;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_cachedMainCamera,
			//           static_fields,
			//           v9,
			//           v10,
			//           v23,
			//           v24);
			//         TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_cameraCheckFrame = frameCount;
			//         v6 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog;
			//       }
			//       sub_180002C70(v6);
			//       s_cachedMainCamera = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_cachedMainCamera;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(s_cachedMainCamera, 0LL, 0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//         v13 = (Component *)TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_cachedMainCamera;
			//         if ( v13 )
			//         {
			//           transform = UnityEngine::Component::get_transform(v13, 0LL);
			//           if ( transform )
			//           {
			//             position = UnityEngine::Transform::get_position(&v25, transform, 0LL);
			//             v16 = *(_QWORD *)&position.x;
			//             z = position.z;
			//             v18 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//             if ( v18 )
			//             {
			//               v19 = UnityEngine::Transform::get_position(&v25, v18, 0LL);
			//               v20 = *(MethodInfo **)&v19.x;
			//               *(float *)&v19 = v19.z;
			//               v23 = v20;
			//               LODWORD(v24) = (_DWORD)v19;
			//               *(_QWORD *)&v25.x = v16;
			//               v25.z = z;
			//               v21 = sub_1824AD380(&v25, &v23);
			//               v13 = (Component *)this.fields.m_meshRenderer;
			//               if ( v13 )
			//               {
			//                 UnityEngine::Renderer::set_enabled((Renderer *)v13, this.fields.fogIntensityFadeDistance > v21, 0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			// LABEL_15:
			//         sub_180B536AC(v13, v12);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void ForceRefresh()
		{
			// // Void ForceRefresh()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::ForceRefresh(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193F5 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering);
			//     byte_18D9193F5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1991, 0LL) )
			//   {
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
			//     v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
			//     if ( v3 )
			//     {
			//       System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//         v3,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//         0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//       UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			//       if ( !this.fields.canWalkIn && !this.fields.nearDisplay )
			//         goto LABEL_9;
			//       v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//       v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
			//       if ( v7 )
			//       {
			//         System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//           v7,
			//           (Object *)this,
			//           MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//           0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//         UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v8, 0LL);
			// LABEL_9:
			//         HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
			//         HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1991, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected override void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnEnable(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Renderer *m_meshRenderer; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v5; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193F6 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering);
			//     byte_18D9193F6 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2001, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2001, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_13;
			//   }
			//   Beyond::TickableMono::OnEnable((TickableMono *)this, 0LL);
			//   HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
			//   m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//   if ( !m_meshRenderer )
			//     goto LABEL_13;
			//   UnityEngine::Renderer::set_enabled(m_meshRenderer, !this.fields.nearDisplay, 0LL);
			//   v5 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//   v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v5;
			//   if ( !v5 )
			//     goto LABEL_13;
			//   System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//     v5,
			//     (Object *)this,
			//     MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//     0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//   UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			//   if ( !this.fields.canWalkIn && !this.fields.nearDisplay )
			//     goto LABEL_10;
			//   v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//   v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
			//   if ( !v7 )
			// LABEL_13:
			//     sub_180B536AC(m_meshRenderer, v3);
			//   System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//     v7,
			//     (Object *)this,
			//     MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//     0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//   UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v8, 0LL);
			// LABEL_10:
			//   if ( UnityEngine::Application::get_isPlaying(0LL) )
			//   {
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(this, 0LL);
			//   }
			// }
			// 
		}

		protected override void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnDisable(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   Renderer *v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
			//   Object_1 *m_meshRenderer; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193F7 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering);
			//     byte_18D9193F7 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2002, 0LL) )
			//   {
			//     Beyond::TickableMono::OnDisable((TickableMono *)this, 0LL);
			//     v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
			//     if ( v3 )
			//     {
			//       System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//         v3,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//         0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//       UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			//       m_meshRenderer = (Object_1 *)this.fields.m_meshRenderer;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( !UnityEngine::Object::op_Inequality(m_meshRenderer, 0LL, 0LL) )
			//         return;
			//       v5 = (Renderer *)this.fields.m_meshRenderer;
			//       if ( v5 )
			//       {
			//         UnityEngine::Renderer::set_enabled(v5, 0, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2002, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			// // Void OnBeginCameraRendering(ScriptableRenderContext, Camera)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering(
			//         VFXFakeVolumeFog *this,
			//         ScriptableRenderContext context,
			//         Camera *camera,
			//         MethodInfo *method)
			// {
			//   Object_1 *gameObject; // rbx
			//   Transform *transform; // rax
			//   __int64 v9; // rdx
			//   Renderer *m_meshRenderer; // rcx
			//   Object_1 *main; // rbx
			//   Transform *v12; // rax
			//   Vector3 *position; // rax
			//   __int64 v14; // xmm6_8
			//   float z; // ebx
			//   Transform *v16; // rax
			//   Vector3 *v17; // rax
			//   __int64 v18; // xmm0_8
			//   float v19; // xmm0_4
			//   bool v20; // dl
			//   Transform *v21; // rbx
			//   Transform *v22; // rax
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm0_8
			//   float v25; // eax
			//   Vector3 *v26; // rax
			//   float v27; // xmm1_4
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v28; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v29; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v31; // [rsp+30h] [rbp-40h] BYREF
			//   Vector3 v32; // [rsp+40h] [rbp-30h] BYREF
			//   Vector3 v33; // [rsp+50h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D9193F8 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering);
			//     byte_18D9193F8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1992, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1992, 0LL);
			//     if ( !Patch )
			//       goto LABEL_37;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, context, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)this, 0LL, 0LL)
			//       || (gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL),
			//           sub_180002C70(TypeInfo::UnityEngine::Object),
			//           UnityEngine::Object::op_Equality(gameObject, 0LL, 0LL)) )
			//     {
			//       v28 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//       v29 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v28;
			//       if ( !v28 )
			//         goto LABEL_37;
			//       System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//         v28,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//         0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//       UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v29, 0LL);
			//     }
			//     else
			//     {
			//       if ( !UnityEngine::Application::get_isPlaying(0LL) )
			//       {
			//         transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( !transform )
			//           goto LABEL_37;
			//         UnityEngine::Transform::set_hasChanged(transform, 0, 0LL);
			//         HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
			//       }
			//       if ( this.fields.nearDisplay && !this.fields.LightArtUSE )
			//       {
			//         main = (Object_1 *)UnityEngine::Camera::get_main(0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( !UnityEngine::Object::op_Equality((Object_1 *)camera, main, 0LL) )
			//           return;
			//         if ( camera )
			//         {
			//           v12 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//           if ( v12 )
			//           {
			//             position = UnityEngine::Transform::get_position(&v32, v12, 0LL);
			//             v14 = *(_QWORD *)&position.x;
			//             z = position.z;
			//             v16 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//             if ( v16 )
			//             {
			//               v17 = UnityEngine::Transform::get_position(&v32, v16, 0LL);
			//               v18 = *(_QWORD *)&v17.x;
			//               *(float *)&v17 = v17.z;
			//               *(_QWORD *)&v31.x = v18;
			//               LODWORD(v31.z) = (_DWORD)v17;
			//               *(_QWORD *)&v32.x = v14;
			//               v32.z = z;
			//               v19 = sub_1824AD380(&v32, &v31);
			//               m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//               if ( m_meshRenderer )
			//               {
			//                 v20 = this.fields.nearDisplayDisatance >= v19;
			// LABEL_33:
			//                 UnityEngine::Renderer::set_enabled(m_meshRenderer, v20, 0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//         goto LABEL_37;
			//       }
			//       if ( !UnityEngine::Application::get_isPlaying(0LL) && this.fields.canWalkIn && !this.fields.LightArtUSE )
			//       {
			//         v21 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( camera )
			//         {
			//           v22 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//           if ( v22 )
			//           {
			//             v23 = UnityEngine::Transform::get_position(&v31, v22, 0LL);
			//             if ( v21 )
			//             {
			//               v24 = *(_QWORD *)&v23.x;
			//               v25 = v23.z;
			//               *(_QWORD *)&v32.x = v24;
			//               v32.z = v25;
			//               v26 = UnityEngine::Transform::InverseTransformPoint(&v33, v21, &v32, 0LL);
			//               *(_QWORD *)&v31.x = *(_QWORD *)&v26.x;
			//               if ( v31.x <= -0.5
			//                 || v31.x >= 0.5
			//                 || v31.y <= -0.5
			//                 || v31.y >= 0.5
			//                 || (v27 = v26.z, v27 <= -0.5)
			//                 || v27 >= 0.5 )
			//               {
			//                 m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//                 if ( m_meshRenderer )
			//                 {
			//                   v20 = 1;
			//                   goto LABEL_33;
			//                 }
			//               }
			//               else
			//               {
			//                 m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//                 if ( m_meshRenderer )
			//                 {
			//                   v20 = 0;
			//                   goto LABEL_33;
			//                 }
			//               }
			//             }
			//           }
			//         }
			// LABEL_37:
			//         sub_180B536AC(m_meshRenderer, v9);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void OnValidate()
		{
			// // Void OnValidate()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnValidate(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rdi
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rdi
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v9; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v10; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193F9 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering);
			//     byte_18D9193F9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2003, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2003, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( UnityEngine::Application::get_isPlaying(0LL) )
			//       return;
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(this, 0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(this, 0LL);
			//     if ( !this.fields.canWalkIn && !this.fields.nearDisplay )
			//     {
			//       v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//       v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
			//       if ( v3 )
			//       {
			//         System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//           v3,
			//           (Object *)this,
			//           MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//           0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//         UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			//         return;
			//       }
			// LABEL_13:
			//       sub_180B536AC(v5, v4);
			//     }
			//     v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
			//     if ( !v7 )
			//       goto LABEL_13;
			//     System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//       v7,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//       0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v8, 0LL);
			//     v9 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     v10 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v9;
			//     if ( !v9 )
			//       goto LABEL_13;
			//     System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//       v9,
			//       (Object *)this,
			//       MethodInfo::HG::Rendering::Runtime::VFXFakeVolumeFog::OnBeginCameraRendering,
			//       0LL);
			//     UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v10, 0LL);
			//   }
			// }
			// 
		}

		private void _UpdateMesh()
		{
			// // Void _UpdateMesh()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMesh(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v4; // rdx
			//   MeshFilter *m_meshFilter; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
			//   Object_1 *defaultCubeMesh; // rsi
			//   Object_1 *sharedMesh; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193FA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193FA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2000, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(this, 0LL) )
			//       return;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( currentPipeline )
			//     {
			//       defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
			//       if ( defaultResources )
			//       {
			//         assets = defaultResources.fields.assets;
			//         if ( assets )
			//         {
			//           m_meshFilter = this.fields.m_meshFilter;
			//           defaultCubeMesh = (Object_1 *)assets.fields.defaultCubeMesh;
			//           if ( m_meshFilter )
			//           {
			//             sharedMesh = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( !UnityEngine::Object::op_Inequality(sharedMesh, defaultCubeMesh, 0LL) )
			//               return;
			//             m_meshFilter = this.fields.m_meshFilter;
			//             if ( m_meshFilter )
			//             {
			//               UnityEngine::MeshFilter::set_sharedMesh(m_meshFilter, (Mesh *)defaultCubeMesh, 0LL);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(m_meshFilter, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2000, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private bool _IsPipeLineReady()
		{
			// // Boolean _IsPipeLineReady()
			// bool HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   HGRenderPipeline *currentPipeline; // rax
			//   Object_1 *defaultResources; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193FB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193FB = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1994, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( currentPipeline )
			//       defaultResources = (Object_1 *)HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(
			//                                        currentPipeline,
			//                                        0LL);
			//     else
			//       defaultResources = 0LL;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(defaultResources, 0LL, 0LL) )
			//       return 0;
			//     if ( defaultResources )
			//       return defaultResources[2].klass && defaultResources[1].fields.m_CachedPtr && defaultResources[1].klass;
			// LABEL_15:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1994, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		private void _UpdateMaterial()
		{
			// // Void _UpdateMaterial()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_UpdateMaterial(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   VFXFakeVolumeFog__StaticFields *static_fields; // rdx
			//   int32_t s_NoiseTex3D; // edi
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_TextureResources *textures; // r8
			//   float z; // eax
			//   MethodInfo *v11; // r8
			//   float fogDepthEnd; // xmm6_4
			//   float v13; // xmm6_4
			//   VFXFakeVolumeFog__StaticFields *v14; // rdx
			//   int32_t s_NoiseUVWDir1; // edi
			//   Transform *transform; // rax
			//   __int64 v17; // xmm0_8
			//   Vector3 *v18; // rax
			//   __int64 v19; // xmm0_8
			//   MethodInfo *v20; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v22; // [rsp+20h] [rbp-40h] BYREF
			//   Vector3 v23; // [rsp+30h] [rbp-30h] BYREF
			//   Vector4 fogColor; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D9193FC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//     byte_18D9193FC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1993, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(this, 0LL) )
			//       return;
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_ValidMaterialToRenderer(this, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NearFadeDistance,
			//       this.fields.nearFadeDisatance,
			//       0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NearDisplayDistance,
			//       this.fields.nearDisplayDisatance,
			//       0LL);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//     fogColor = (Vector4)this.fields.fogColor;
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       static_fields.s_FogColor,
			//       (Color *)&fogColor,
			//       0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogExponent,
			//       this.fields.fogExponent,
			//       0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogDensity,
			//       this.fields.fogDensity,
			//       0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_CubEdgeFade,
			//       this.fields.cubeEdge,
			//       0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_HeightOffset,
			//       this.fields.heightOffset,
			//       0LL);
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//       this,
			//       TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_HeightFalloff,
			//       this.fields.heightFalloff,
			//       0LL);
			//     s_NoiseTex3D = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseTex3D;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( currentPipeline )
			//     {
			//       defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
			//       if ( defaultResources )
			//       {
			//         textures = defaultResources.fields.textures;
			//         if ( textures )
			//         {
			//           HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//             this,
			//             s_NoiseTex3D,
			//             (Texture *)textures.fields.HeightFogNoise3DTex,
			//             0LL);
			//           HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//             this,
			//             TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseIntensity,
			//             this.fields.noiseIntensity,
			//             0LL);
			//           HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//             this,
			//             TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseFar,
			//             this.fields.noiseFar,
			//             0LL);
			//           if ( this.fields.LightArtUSE )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseFarIntensity,
			//               this.fields.noiseFarIntensity,
			//               0LL);
			//             v13 = 1.0;
			//             fogColor.x = this.fields.noiseTillingLightArtUSE;
			//             fogColor.y = fogColor.x;
			//             v14 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//             fogColor.z = fogColor.x;
			//             fogColor.w = 1.0;
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               v14.s_NoiseTexTilling1,
			//               &fogColor,
			//               0LL);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogIntensityFadeDistance,
			//               this.fields.fogIntensityFadeDistance,
			//               0LL);
			//             if ( this.fields.fogIntensityFadeUseCenter )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//             }
			//             else
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//               v13 = 0.0;
			//             }
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogIntensityFadeUseCenter,
			//               v13,
			//               0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseUVWSpeed1,
			//               this.fields.noiseSpeedLightArtUSE,
			//               0LL);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogDepthStart,
			//               this.fields.fogDepthStart,
			//               0LL);
			//             fogDepthEnd = this.fields.fogDepthEnd;
			//           }
			//           else
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseFarIntensity,
			//               this.fields.noiseIntensity,
			//               0LL);
			//             z = this.fields.noiseTilling.z;
			//             *(_QWORD *)&v22.x = *(_QWORD *)&this.fields.noiseTilling.x;
			//             v22.z = z;
			//             fogColor = *UnityEngine::Vector4::op_Implicit(&fogColor, &v22, v11);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseTexTilling1,
			//               &fogColor,
			//               0LL);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogIntensityFadeDistance,
			//               10000.0,
			//               0LL);
			//             fogDepthEnd = 0.0;
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogIntensityFadeUseCenter,
			//               0.0,
			//               0LL);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseUVWSpeed1,
			//               this.fields.noiseSpeed,
			//               0LL);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//               this,
			//               TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogDepthStart,
			//               0.0,
			//               0LL);
			//           }
			//           HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//             this,
			//             TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogDepthEnd,
			//             fogDepthEnd,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//           HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//             this,
			//             TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogIntensity,
			//             this.fields.fogIntensity,
			//             0LL);
			//           HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//             this,
			//             TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_FogIntensityFadeOutDistance,
			//             this.fields.fogIntensityFadeOutDistance,
			//             0LL);
			//           s_NoiseUVWDir1 = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields.s_NoiseUVWDir1;
			//           transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//           if ( transform )
			//           {
			//             v17 = *(_QWORD *)&this.fields.noiseDir.x;
			//             v22.z = this.fields.noiseDir.z;
			//             *(_QWORD *)&v22.x = v17;
			//             v18 = UnityEngine::Transform::TransformDirection((Vector3 *)&fogColor, transform, &v22, 0LL);
			//             v19 = *(_QWORD *)&v18.x;
			//             *(float *)&v18 = v18.z;
			//             *(_QWORD *)&v23.x = v19;
			//             LODWORD(v23.z) = (_DWORD)v18;
			//             fogColor = *UnityEngine::Vector4::op_Implicit(&fogColor, &v23, v20);
			//             HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(this, s_NoiseUVWDir1, &fogColor, 0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1993, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void ShowMeshFilterAndRenderer()
		{
			// // Void ShowMeshFilterAndRenderer()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::ShowMeshFilterAndRenderer(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Object_1 *m_meshFilter; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2004, 0LL) )
			//   {
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
			//     m_meshFilter = (Object_1 *)this.fields.m_meshFilter;
			//     if ( m_meshFilter )
			//     {
			//       UnityEngine::Object::set_hideFlags(m_meshFilter, HideFlags__Enum_None, 0LL);
			//       m_meshFilter = (Object_1 *)this.fields.m_meshRenderer;
			//       if ( m_meshFilter )
			//       {
			//         UnityEngine::Object::set_hideFlags(m_meshFilter, HideFlags__Enum_None, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_meshFilter, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2004, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void HideMeshFilterAndRenderer()
		{
			// // Void HideMeshFilterAndRenderer()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::HideMeshFilterAndRenderer(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Object_1 *m_meshFilter; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2005, 0LL) )
			//   {
			//     HG::Rendering::Runtime::VFXFakeVolumeFog::_InitMeshFilterAndRender(this, 0LL);
			//     m_meshFilter = (Object_1 *)this.fields.m_meshFilter;
			//     if ( m_meshFilter )
			//     {
			//       UnityEngine::Object::set_hideFlags(m_meshFilter, HideFlags__Enum_HideInInspector, 0LL);
			//       m_meshFilter = (Object_1 *)this.fields.m_meshRenderer;
			//       if ( m_meshFilter )
			//       {
			//         UnityEngine::Object::set_hideFlags(m_meshFilter, HideFlags__Enum_HideInInspector, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_meshFilter, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2005, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		[IDTag(0)]
		private void _SetMaterialProperty(int propertyId, float value)
		{
			// // Void _SetMaterialProperty(Int32, Single)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//         VFXFakeVolumeFog *this,
			//         int32_t propertyId,
			//         float value,
			//         MethodInfo *method)
			// {
			//   Object_1 *instanceMaterial; // rbx
			//   __int64 v7; // rdx
			//   Material *v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193FD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193FD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1996, 0LL) )
			//   {
			//     instanceMaterial = (Object_1 *)this.fields.instanceMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(instanceMaterial, 0LL, 0LL) )
			//       return;
			//     v8 = this.fields.instanceMaterial;
			//     if ( v8 )
			//     {
			//       UnityEngine::Material::SetFloatImpl(v8, propertyId, value, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1996, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(
			//     (ILFixDynamicMethodWrapper_7 *)Patch,
			//     (Object *)this,
			//     propertyId,
			//     value,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		private void _SetMaterialProperty(int propertyId, Color value)
		{
			// // Void _SetMaterialProperty(Int32, Color)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//         VFXFakeVolumeFog *this,
			//         int32_t propertyId,
			//         Color *value,
			//         MethodInfo *method)
			// {
			//   Object_1 *instanceMaterial; // rbx
			//   __int64 v8; // rdx
			//   Material *v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9193FE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193FE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1997, 0LL) )
			//   {
			//     instanceMaterial = (Object_1 *)this.fields.instanceMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(instanceMaterial, 0LL, 0LL) )
			//       return;
			//     v9 = this.fields.instanceMaterial;
			//     if ( v9 )
			//     {
			//       v11 = *value;
			//       UnityEngine::Material::SetColor(v9, propertyId, &v11, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1997, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   v11 = *value;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_767(Patch, (Object *)this, propertyId, &v11, 0LL);
			// }
			// 
		}

		[IDTag(3)]
		private void _SetMaterialProperty(int propertyId, Vector4 value)
		{
			// // Void _SetMaterialProperty(Int32, Vector4)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//         VFXFakeVolumeFog *this,
			//         int32_t propertyId,
			//         Vector4 *value,
			//         MethodInfo *method)
			// {
			//   Object_1 *instanceMaterial; // rbx
			//   __int64 v8; // rdx
			//   Material *v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9193FF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193FF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1999, 0LL) )
			//   {
			//     instanceMaterial = (Object_1 *)this.fields.instanceMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(instanceMaterial, 0LL, 0LL) )
			//       return;
			//     v9 = this.fields.instanceMaterial;
			//     if ( v9 )
			//     {
			//       v11 = *value;
			//       UnityEngine::Material::SetVector(v9, propertyId, &v11, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1999, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   v11 = *value;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_768(Patch, (Object *)this, propertyId, &v11, 0LL);
			// }
			// 
		}

		[IDTag(2)]
		private void _SetMaterialProperty(int propertyId, Texture value)
		{
			// // Void _SetMaterialProperty(Int32, Texture)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_SetMaterialProperty(
			//         VFXFakeVolumeFog *this,
			//         int32_t propertyId,
			//         Texture *value,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Material *instanceMaterial; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1998, 0LL) )
			//   {
			//     instanceMaterial = this.fields.instanceMaterial;
			//     if ( instanceMaterial )
			//     {
			//       UnityEngine::Material::SetTextureImpl(instanceMaterial, propertyId, value, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(instanceMaterial, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1998, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
			//     (ILFixDynamicMethodWrapper_14 *)Patch,
			//     (Object *)this,
			//     (SCMessageID__Enum)propertyId,
			//     (Object *)value,
			//     0LL);
			// }
			// 
		}

		private void _ValidMaterialToRenderer()
		{
			// // Void _ValidMaterialToRenderer()
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::_ValidMaterialToRenderer(VFXFakeVolumeFog *this, MethodInfo *method)
			// {
			//   Object_1 *instanceMaterial; // rbx
			//   VFXFakeVolumeFog__StaticFields *static_fields; // rdx
			//   Renderer *m_meshRenderer; // rcx
			//   Object_1 *SharedMaterial; // rsi
			//   bool v7; // al
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   Material **p_m_originMaterial; // rcx
			//   HGRenderPipeline *currentPipeline; // rax
			//   Object_1 *defaultResources; // rbx
			//   HGRenderPipeline *v14; // rax
			//   HGRenderPipelineRuntimeResources *v15; // rax
			//   HGRenderPipeline *v16; // rax
			//   HGRenderPipelineRuntimeResources *v17; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   Shader *fakeVolumeFogPS; // rsi
			//   Material *v20; // rax
			//   Material *v21; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   Object *m_originMaterial; // rbx
			//   float v26; // xmm2_4
			//   float v27; // xmm2_4
			//   Material *v28; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v30; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v31; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v32; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v33; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D919400 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Material);
			//     sub_18003C530(&MethodInfo::UnityEngine::Object::Instantiate<UnityEngine::Material>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//     sub_18003C530(&off_18D4E50D0);
			//     sub_18003C530(&off_18D4E50D8);
			//     sub_18003C530(&off_18D4E50E8);
			//     sub_18003C530(&off_18D4E5130);
			//     sub_18003C530(&off_18D4E5140);
			//     sub_18003C530(&off_18C8E1818);
			//     byte_18D919400 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1995, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::VFXFakeVolumeFog::_IsPipeLineReady(this, 0LL) )
			//       return;
			//     instanceMaterial = (Object_1 *)this.fields.instanceMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(instanceMaterial, 0LL, 0LL) )
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       SharedMaterial = (Object_1 *)UnityEngine::Renderer::GetSharedMaterial(m_meshRenderer, 0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       v7 = UnityEngine::Object::op_Inequality(SharedMaterial, 0LL, 0LL);
			//       p_m_originMaterial = &this.fields.m_originMaterial;
			//       if ( v7 )
			//       {
			//         this.fields.m_originMaterial = (Material *)SharedMaterial;
			//         sub_1800054D0((HGRenderPathScene *)p_m_originMaterial, v8, v9, v10, v30, v32);
			//         m_originMaterial = (Object *)this.fields.m_originMaterial;
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         this.fields.instanceMaterial = (Material *)UnityEngine::Object::Instantiate<System::Object>(
			//                                                       m_originMaterial,
			//                                                       MethodInfo::UnityEngine::Object::Instantiate<UnityEngine::Material>);
			//       }
			//       else
			//       {
			//         this.fields.m_originMaterial = 0LL;
			//         sub_1800054D0((HGRenderPathScene *)p_m_originMaterial, v8, v9, v10, v30, v32);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//         if ( !HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
			//           return;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//         currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//         if ( !currentPipeline )
			//           goto LABEL_57;
			//         defaultResources = (Object_1 *)HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(
			//                                          currentPipeline,
			//                                          0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Equality(defaultResources, 0LL, 0LL) )
			//           return;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//         v14 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//         if ( !v14 )
			//           goto LABEL_57;
			//         v15 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v14, 0LL);
			//         if ( !v15 )
			//           goto LABEL_57;
			//         if ( !v15.fields.shaders )
			//           return;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//         v16 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//         if ( !v16 )
			//           goto LABEL_57;
			//         v17 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v16, 0LL);
			//         if ( !v17 )
			//           goto LABEL_57;
			//         shaders = v17.fields.shaders;
			//         if ( !shaders )
			//           goto LABEL_57;
			//         fakeVolumeFogPS = shaders.fields.fakeVolumeFogPS;
			//         v20 = (Material *)sub_180004920(TypeInfo::UnityEngine::Material);
			//         v21 = v20;
			//         if ( !v20 )
			//           goto LABEL_57;
			//         UnityEngine::Material::Material(v20, fakeVolumeFogPS, 0LL);
			//         this.fields.instanceMaterial = v21;
			//       }
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.instanceMaterial, v22, v23, v24, v31, v33);
			//     }
			//     m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//     if ( !m_meshRenderer )
			//       goto LABEL_57;
			//     UnityEngine::Renderer::SetMaterial(m_meshRenderer, this.fields.instanceMaterial, 0LL);
			//     m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//     if ( this.fields.useNoise3D )
			//     {
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::SetFloat((Material *)m_meshRenderer, (String *)"_UseNoise3D", 1.0, 0LL);
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::EnableKeyword((Material *)m_meshRenderer, (String *)"_USE_NOISE3D", 0LL);
			//     }
			//     else
			//     {
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::SetFloat((Material *)m_meshRenderer, (String *)"_UseNoise3D", 0.0, 0LL);
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::DisableKeyword((Material *)m_meshRenderer, (String *)"_USE_NOISE3D", 0LL);
			//     }
			//     m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//     if ( this.fields.LightArtUSE || !this.fields.useFog )
			//     {
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::SetFloat((Material *)m_meshRenderer, (String *)"_UseFog", 0.0, 0LL);
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::DisableKeyword((Material *)m_meshRenderer, (String *)"_USE_FOG", 0LL);
			//     }
			//     else
			//     {
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::SetFloat((Material *)m_meshRenderer, (String *)"_UseFog", 1.0, 0LL);
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       UnityEngine::Material::EnableKeyword((Material *)m_meshRenderer, (String *)"_USE_FOG", 0LL);
			//     }
			//     if ( !this.fields.canWalkIn || this.fields.LightArtUSE )
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       v26 = 1.0;
			//     }
			//     else
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       v26 = 0.0;
			//     }
			//     UnityEngine::Material::SetFloat((Material *)m_meshRenderer, (String *)"_canWalkIn", v26, 0LL);
			//     if ( !this.fields.nearDisplay || this.fields.LightArtUSE )
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       v27 = 0.0;
			//     }
			//     else
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       if ( !m_meshRenderer )
			//         goto LABEL_57;
			//       v27 = 1.0;
			//     }
			//     UnityEngine::Material::SetFloat((Material *)m_meshRenderer, (String *)"_nearDisplay", v27, 0LL);
			//     v28 = this.fields.instanceMaterial;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//     if ( v28 )
			//     {
			//       UnityEngine::Material::SetFloatImpl(v28, static_fields.s_StencilWriteMask, 7.0, 0LL);
			//       m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//       if ( m_meshRenderer )
			//       {
			//         UnityEngine::Material::SetFloatImpl((Material *)m_meshRenderer, static_fields.s_StencilReadMask, 7.0, 0LL);
			//         m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//         if ( m_meshRenderer )
			//         {
			//           UnityEngine::Material::SetFloatImpl((Material *)m_meshRenderer, static_fields.s_StencilRef, 7.0, 0LL);
			//           m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//           if ( m_meshRenderer )
			//           {
			//             UnityEngine::Material::SetFloatImpl((Material *)m_meshRenderer, static_fields.s_StencilOp, 0.0, 0LL);
			//             m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//             static_fields = TypeInfo::HG::Rendering::Runtime::VFXFakeVolumeFog.static_fields;
			//             if ( m_meshRenderer )
			//             {
			//               UnityEngine::Material::SetFloatImpl(
			//                 (Material *)m_meshRenderer,
			//                 static_fields.s_ExcludeVFXMask,
			//                 (float)(this.fields.excludeCharacter ? 6 : 8),
			//                 0LL);
			//               m_meshRenderer = (Renderer *)this.fields.instanceMaterial;
			//               if ( m_meshRenderer )
			//               {
			//                 UnityEngine::Material::set_renderQueue((Material *)m_meshRenderer, 3000, 0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_57:
			//     sub_180B536AC(m_meshRenderer, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1995, 0LL);
			//   if ( !Patch )
			//     goto LABEL_57;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void OnSceneTriggerEnter(ulong triggerId)
		{
			// // Void OnSceneTriggerEnter(UInt64)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnSceneTriggerEnter(
			//         VFXFakeVolumeFog *this,
			//         uint64_t triggerId,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Renderer *m_meshRenderer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2006, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2006, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69(
			//       (ILFixDynamicMethodWrapper_14 *)Patch,
			//       (Object *)this,
			//       triggerId,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.canWalkIn && !this.fields.LightArtUSE )
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//       if ( !m_meshRenderer )
			//         goto LABEL_11;
			//       UnityEngine::Renderer::set_enabled(m_meshRenderer, 0, 0LL);
			//     }
			//     if ( this.fields.nearDisplay && !this.fields.LightArtUSE )
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//       if ( m_meshRenderer )
			//       {
			//         UnityEngine::Renderer::set_enabled(m_meshRenderer, 1, 0LL);
			//         return;
			//       }
			// LABEL_11:
			//       sub_180B536AC(m_meshRenderer, v5);
			//     }
			//   }
			// }
			// 
		}

		public void OnSceneTriggerLeave(ulong triggerId)
		{
			// // Void OnSceneTriggerLeave(UInt64)
			// void HG::Rendering::Runtime::VFXFakeVolumeFog::OnSceneTriggerLeave(
			//         VFXFakeVolumeFog *this,
			//         uint64_t triggerId,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Renderer *m_meshRenderer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2007, 0LL) )
			//   {
			//     if ( this.fields.canWalkIn )
			//     {
			//       m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//       if ( !m_meshRenderer )
			//         goto LABEL_9;
			//       UnityEngine::Renderer::set_enabled(m_meshRenderer, 1, 0LL);
			//     }
			//     if ( !this.fields.nearDisplay )
			//       return;
			//     m_meshRenderer = (Renderer *)this.fields.m_meshRenderer;
			//     if ( m_meshRenderer )
			//     {
			//       UnityEngine::Renderer::set_enabled(m_meshRenderer, 0, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_meshRenderer, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2007, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69((ILFixDynamicMethodWrapper_14 *)Patch, (Object *)this, triggerId, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnAwake()
		{
			// // Void <>iFixBaseProxy_OnAwake()
			// void Beyond::TickableUIMono::__iFixBaseProxy_OnAwake(TickableUIMono *this, MethodInfo *method)
			// {
			//   Beyond::TickableMono::OnAwake((TickableMono *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Tick(float P0)
		{
			// // Void <>iFixBaseProxy_Tick(Single)
			// void Beyond::Login::LoginDecorateUI::__iFixBaseProxy_Tick(LoginDecorateUI *this, float P0, MethodInfo *method)
			// {
			//   Beyond::TickableMono::Tick((TickableMono *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnEnable()
		{
			// // Void <>iFixBaseProxy_OnEnable()
			// void Beyond::UI::UIWaterDroneBar::__iFixBaseProxy_OnEnable(UIWaterDroneBar *this, MethodInfo *method)
			// {
			//   Beyond::TickableMono::OnEnable((TickableMono *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnDisable()
		{
			// // Void <>iFixBaseProxy_OnDisable()
			// void Beyond::UI::UIHeadLabel::__iFixBaseProxy_OnDisable(UIHeadLabel *this, MethodInfo *method)
			// {
			//   Beyond::TickableMono::OnDisable((TickableMono *)this, 0LL);
			// }
			// 
		}

		public bool LightArtUSE;

		public bool enableDistanceCullTick;

		private MeshRenderer m_meshRenderer;

		private MeshFilter m_meshFilter;

		[NonSerialized]
		public Material instanceMaterial;

		private Material m_originMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly int s_NearFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		private static readonly int s_FogColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly int s_FogExponent;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x0C")]
		private static readonly int s_FogDensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly int s_CubEdgeFade;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x14")]
		private static readonly int s_NoiseTex3D;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly int s_NoiseIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1C")]
		private static readonly int s_NoiseTexTilling1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly int s_NoiseFar;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		private static readonly int s_NoiseFarIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static readonly int s_NoiseUVWDir1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		private static readonly int s_NoiseUVWSpeed1;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static readonly int s_HeightOffset;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		private static readonly int s_HeightFalloff;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static readonly int s_FogDepthStart;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x3C")]
		private static readonly int s_FogDepthEnd;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		private static readonly int s_UseFog;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		private static readonly int s_FogIntensity;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		private static readonly int s_FogIntensityFadeOutDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
		private static readonly int s_FogIntensityFadeDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		private static readonly int s_FogIntensityFadeUseCenter;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x54")]
		private static readonly int s_NearDisplayDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		private static readonly int s_ExcludeVFXMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x5C")]
		private static readonly int s_StencilWriteMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		private static readonly int s_StencilReadMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x64")]
		private static readonly int s_StencilRef;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		private static readonly int s_StencilOp;

		public bool canWalkIn;

		[Min(0.01f)]
		public float nearFadeDisatance;

		public bool nearDisplay;

		[Min(0.01f)]
		public float nearDisplayDisatance;

		public bool excludeCharacter;

		[ColorUsage(true, true)]
		public Color fogColor;

		[Range(0.005f, 0.2f)]
		public float fogExponent;

		[Range(0.1f, 10f)]
		public float fogDensity;

		[Range(0f, 200f)]
		public float fogDepthStart;

		[Range(0f, 1f)]
		public float fogDepthEnd;

		public bool fogIntensityFadeUseCenter;

		[Range(10f, 10000f)]
		public float fogIntensityFadeDistance;

		[Range(-0.5f, 0.5f)]
		public float heightOffset;

		[Range(1f, 10f)]
		public float heightFalloff;

		[Range(0.5f, 1f)]
		public float cubeEdge;

		public bool useNoise3D;

		[Range(1f, 100f)]
		public float noiseFar;

		public float noiseIntensity;

		public float noiseFarIntensity;

		public Vector3 noiseTilling;

		[Range(0f, 0.05f)]
		public float noiseTillingLightArtUSE;

		public Vector3 noiseDir;

		public float noiseSpeed;

		[Range(0f, 2f)]
		public float noiseSpeedLightArtUSE;

		public bool useFog;

		[Range(0f, 1f)]
		public float fogIntensity;

		[Range(10f, 10000f)]
		public float fogIntensityFadeOutDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		private static Camera s_cachedMainCamera;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		private static int s_cameraCheckFrame;
	}
}
