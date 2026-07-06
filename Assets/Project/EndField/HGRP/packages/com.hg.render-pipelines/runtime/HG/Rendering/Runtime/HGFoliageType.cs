using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGFoliageType : MonoBehaviour
	{
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x000025D0 File Offset: 0x000007D0
		public ECSColliderResultProxy paintOnCollider
		{
			get
			{
				// // ECSColliderResultProxy get_paintOnCollider()
				// ECSColliderResultProxy *HG::Rendering::Runtime::HGFoliageType::get_paintOnCollider(
				//         ECSColliderResultProxy *__return_ptr retstr,
				//         HGFoliageType *this,
				//         MethodInfo *method)
				// {
				//   ECSColliderResultProxy *v5; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   __int128 v9; // xmm0
				//   __int64 v10; // xmm1_8
				//   ECSColliderResultProxy *result; // rax
				//   ECSColliderResultProxy v12; // [rsp+20h] [rbp-28h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2176, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2176, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_791(&v12, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     v5 = UnityEngine::Physics::CreateECSProxy(&v12, this.fields._paintOnCollider, 0LL);
				//   }
				//   v9 = *(_OWORD *)&v5.m_Actor;
				//   v10 = *(_QWORD *)&v5.m_Collider;
				//   result = retstr;
				//   *(_OWORD *)&retstr.m_Actor = v9;
				//   *(_QWORD *)&retstr.m_Collider = v10;
				//   return result;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_paintOnCollider(ECSColliderResultProxy)
				// void HG::Rendering::Runtime::HGFoliageType::set_paintOnCollider(
				//         HGFoliageType *this,
				//         ECSColliderResultProxy *value,
				//         MethodInfo *method)
				// {
				//   OneofDescriptorProto *v5; // rdx
				//   FileDescriptor *v6; // r8
				//   MessageDescriptor *v7; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   __int64 v11; // xmm1_8
				//   ECSColliderResultProxy v12; // [rsp+20h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D919441 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::ECSColliderResultProxy);
				//     byte_18D919441 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(2177, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2177, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     v11 = *(_QWORD *)&value.m_Collider;
				//     *(_OWORD *)&v12.m_Actor = *(_OWORD *)&value.m_Actor;
				//     *(_QWORD *)&v12.m_Collider = v11;
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_792(Patch, (Object *)this, &v12, 0LL);
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::UnityEngine::ECSColliderResultProxy);
				//     if ( !UnityEngine::ECSColliderResultProxy::get_bIsECS(value, 0LL) )
				//     {
				//       sub_180002C70(TypeInfo::UnityEngine::ECSColliderResultProxy);
				//       this.fields._paintOnCollider = UnityEngine::ECSColliderResultProxy::get_collider(value, 0LL);
				//       sub_1800054D0(
				//         (OneofDescriptor *)&this.fields._paintOnCollider,
				//         v5,
				//         v6,
				//         v7,
				//         (String__Array *)v12.m_Actor,
				//         *(String **)&v12.m_EcsId,
				//         *(MethodInfo **)&v12.m_Collider);
				//     }
				//   }
				// }
				// 
			}
		}

		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector4 exportRootAlbedo
		{
			get
			{
				// // Vector4 get_exportRootAlbedo()
				// Vector4 *HG::Rendering::Runtime::HGFoliageType::get_exportRootAlbedo(
				//         Vector4 *__return_ptr retstr,
				//         HGFoliageType *this,
				//         MethodInfo *method)
				// {
				//   MethodInfo *v4; // r8
				//   Vector4 v5; // xmm0
				//   Vector4 *result; // rax
				//   Vector4 v7; // [rsp+20h] [rbp-28h] BYREF
				//   Color v8; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   v7 = *(Vector4 *)sub_182F8C840(&v7, &this.fields.rootAlbedo);
				//   v5 = (Vector4)*UnityEngine::Color::op_Implicit(&v8, &v7, v4);
				//   result = retstr;
				//   *retstr = v5;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector4 exportGrassBlendColor
		{
			get
			{
				// // Vector4 get_exportGrassBlendColor()
				// Vector4 *HG::Rendering::Runtime::HGFoliageType::get_exportGrassBlendColor(
				//         Vector4 *__return_ptr retstr,
				//         HGFoliageType *this,
				//         MethodInfo *method)
				// {
				//   Color *p_grassBlendColor; // rdx
				//   MethodInfo *v6; // r8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				//   __m128i v11; // [rsp+20h] [rbp-28h] BYREF
				//   Color v12; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(2178, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(2178, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v9, v8);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312((Vector4 *)&v12, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     p_grassBlendColor = &this.fields.grassBlendColor;
				//     if ( this.fields.grassBlendColor.a <= 0.0099999998 )
				//       p_grassBlendColor = &this.fields.blendColorTerrain;
				//     v11 = _mm_loadu_si128((const __m128i *)sub_182F8C840(&v11, p_grassBlendColor));
				//     *retstr = *(Vector4 *)UnityEngine::Color::op_Implicit(&v12, (Vector4 *)&v11, v6);
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public HGFoliageType()
		{
			// // HGFoliageType()
			// void HG::Rendering::Runtime::HGFoliageType::HGFoliageType(HGFoliageType *this, MethodInfo *method)
			// {
			//   Vector4 si128; // xmm0
			//   struct HGFoliageType__Class *v4; // rax
			// 
			//   if ( !byte_18D8ED9B4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFoliageType);
			//     byte_18D8ED9B4 = 1;
			//   }
			//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//   this.fields.shAr = si128;
			//   this.fields.overlapCheckMinDistance = 0.30000001;
			//   this.fields.shAg = si128;
			//   this.fields.shAb = si128;
			//   v4 = TypeInfo::HG::Rendering::Runtime::HGFoliageType;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGFoliageType._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGFoliageType, method);
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGFoliageType;
			//   }
			//   this.fields.rootAlbedo = v4.static_fields.DEFUALT_BLEND_COLOR;
			//   this.fields.grassBlendColor = TypeInfo::HG::Rendering::Runtime::HGFoliageType.static_fields.DEFUALT_BLEND_COLOR;
			//   this.fields.blendColorTerrain = TypeInfo::HG::Rendering::Runtime::HGFoliageType.static_fields.DEFUALT_BLEND_COLOR;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly Color DEFUALT_BLEND_COLOR;

		[SerializeField]
		[FormerlySerializedAs("paintOnCollider")]
		[HideInInspector]
		private Collider _paintOnCollider;

		[HideInInspector]
		[SerializeField]
		private string _paintOnGUID;

		public bool autoHeight;

		public bool autoAngle;

		[Range(0f, 1f)]
		public float angleVerticalWeight;

		public bool forceLightProbeGI;

		public float lightProbeAnchorOffset;

		public float overlapCheckMinDistance;

		[NonSerialized]
		public bool needUpdateProperty;

		[SerializeField]
		[HideInInspector]
		public Vector4 shAr;

		[HideInInspector]
		[SerializeField]
		public Vector4 shAg;

		[SerializeField]
		[HideInInspector]
		public Vector4 shAb;

		[SerializeField]
		[HideInInspector]
		public Color rootAlbedo;

		[SerializeField]
		[HideInInspector]
		public Color grassBlendColor;

		[SerializeField]
		[HideInInspector]
		public Color blendColorTerrain;

		[SerializeField]
		[HideInInspector]
		private Vector3 _giPosition;

		[HideInInspector]
		[SerializeField]
		public string giInfomation;

		[HideInInspector]
		[SerializeField]
		public string rootAlbedoInfomation;

		[HideInInspector]
		[NonSerialized]
		public bool showDebugInfo;
	}
}
