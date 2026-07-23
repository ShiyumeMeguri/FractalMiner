using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGFoliageType : MonoBehaviour // TypeDefIndex: 37986
	{
		// Fields
		public static readonly UnityEngine.Color DEFUALT_BLEND_COLOR; // 0x00
		[FormerlySerializedAs("paintOnCollider")]
		[HideInInspector]
		[SerializeField]
		private Collider _paintOnCollider; // 0x18
		[HideInInspector]
		[SerializeField]
		private string _paintOnGUID; // 0x20
		public bool autoHeight; // 0x28
		public bool autoAngle; // 0x29
		[Range(0f, 1f)]
		public float angleVerticalWeight; // 0x2C
		public bool forceLightProbeGI; // 0x30
		public float lightProbeAnchorOffset; // 0x34
		public float overlapCheckMinDistance; // 0x38
		[NonSerialized]
		public bool needUpdateProperty; // 0x3C
		[HideInInspector]
		[SerializeField]
		public Vector4 shAr; // 0x40
		[HideInInspector]
		[SerializeField]
		public Vector4 shAg; // 0x50
		[HideInInspector]
		[SerializeField]
		public Vector4 shAb; // 0x60
		[HideInInspector]
		[SerializeField]
		public UnityEngine.Color rootAlbedo; // 0x70
		[HideInInspector]
		[SerializeField]
		public UnityEngine.Color grassBlendColor; // 0x80
		[HideInInspector]
		[SerializeField]
		public UnityEngine.Color blendColorTerrain; // 0x90
		[HideInInspector]
		[SerializeField]
		private Vector3 _giPosition; // 0xA0
		[HideInInspector]
		[SerializeField]
		public string giInfomation; // 0xB0
		[HideInInspector]
		[SerializeField]
		public string rootAlbedoInfomation; // 0xB8
		[NonSerialized]
		[HideInInspector]
		public bool showDebugInfo; // 0xC0
	
		// Properties
		public ECSColliderResultProxy paintOnCollider { get => default; set {} } // 0x0000000189B6B830-0x0000000189B6B8AC 0x0000000189B6B8AC-0x0000000189B6B954
		// ECSColliderResultProxy get_paintOnCollider()
		ECSColliderResultProxy *HG::Rendering::Runtime::HGFoliageType::get_paintOnCollider(
		        ECSColliderResultProxy *__return_ptr retstr,
		        HGFoliageType *this,
		        MethodInfo *method)
		{
		  ECSColliderResultProxy *v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int128 v9; // xmm0
		  __int64 v10; // xmm1_8
		  ECSColliderResultProxy *result; // rax
		  ECSColliderResultProxy v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2625, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2625, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_967(&v12, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = UnityEngine::Physics::CreateECSProxy(&v12, this->fields._paintOnCollider, 0LL);
		  }
		  v9 = *(_OWORD *)&v5->m_Actor;
		  v10 = *(_QWORD *)&v5->m_Collider;
		  result = retstr;
		  *(_OWORD *)&retstr->m_Actor = v9;
		  *(_QWORD *)&retstr->m_Collider = v10;
		  return result;
		}
		

		// Void set_paintOnCollider(ECSColliderResultProxy)
		void HG::Rendering::Runtime::HGFoliageType::set_paintOnCollider(
		        HGFoliageType *this,
		        ECSColliderResultProxy *value,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // xmm1_8
		  ECSColliderResultProxy v12; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2626, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2626, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v11 = *(_QWORD *)&value->m_Collider;
		    *(_OWORD *)&v12.m_Actor = *(_OWORD *)&value->m_Actor;
		    *(_QWORD *)&v12.m_Collider = v11;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_968(Patch, (Object *)this, &v12, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::ECSColliderResultProxy);
		    if ( !UnityEngine::ECSColliderResultProxy::get_bIsECS(value, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::ECSColliderResultProxy);
		      this->fields._paintOnCollider = UnityEngine::ECSColliderResultProxy::get_collider(value, 0LL);
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields._paintOnCollider, v5, v6, v7, (MethodInfo *)v12.m_Actor);
		    }
		  }
		}
		
		public Vector4 exportRootAlbedo { get => default; } // 0x0000000189B6B7A0-0x0000000189B6B830 
		// Vector4 get_exportRootAlbedo()
		Vector4 *HG::Rendering::Runtime::HGFoliageType::get_exportRootAlbedo(
		        Vector4 *__return_ptr retstr,
		        HGFoliageType *this,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2627, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2627, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350((Vector4 *)&v11, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v10 = *(Vector4 *)sub_183C6CBA0(&v10, &this->fields.rootAlbedo);
		    *retstr = *(Vector4 *)UnityEngine::Color::op_Implicit(&v11, &v10, v5);
		  }
		  return retstr;
		}
		
		public Vector4 exportGrassBlendColor { get => default; } // 0x0000000189B6B6F4-0x0000000189B6B7A0 
		// Vector4 get_exportGrassBlendColor()
		Vector4 *HG::Rendering::Runtime::HGFoliageType::get_exportGrassBlendColor(
		        Vector4 *__return_ptr retstr,
		        HGFoliageType *this,
		        MethodInfo *method)
		{
		  Color *p_grassBlendColor; // rdx
		  MethodInfo *v6; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __m128i v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2628, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2628, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350((Vector4 *)&v12, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    p_grassBlendColor = &this->fields.grassBlendColor;
		    if ( this->fields.grassBlendColor.a <= 0.0099999998 )
		      p_grassBlendColor = &this->fields.blendColorTerrain;
		    v11 = _mm_loadu_si128((const __m128i *)sub_183C6CBA0(&v11, p_grassBlendColor));
		    *retstr = *(Vector4 *)UnityEngine::Color::op_Implicit(&v12, (Vector4 *)&v11, v6);
		  }
		  return retstr;
		}
		
	
		// Constructors
		public HGFoliageType() {} // 0x0000000189B6B664-0x0000000189B6B6F4
		// HGFoliageType()
		void HG::Rendering::Runtime::HGFoliageType::HGFoliageType(HGFoliageType *this, MethodInfo *method)
		{
		  Vector4 si128; // xmm0
		
		  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		  this->fields.shAr = si128;
		  this->fields.overlapCheckMinDistance = 0.30000001;
		  this->fields.shAg = si128;
		  this->fields.shAb = si128;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGFoliageType);
		  this->fields.rootAlbedo = (Color)_mm_loadu_si128((const __m128i *)TypeInfo::HG::Rendering::Runtime::HGFoliageType->static_fields);
		  this->fields.grassBlendColor = (Color)_mm_loadu_si128((const __m128i *)TypeInfo::HG::Rendering::Runtime::HGFoliageType->static_fields);
		  this->fields.blendColorTerrain = (Color)_mm_loadu_si128((const __m128i *)TypeInfo::HG::Rendering::Runtime::HGFoliageType->static_fields);
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
		static HGFoliageType() {} // 0x0000000184DA15B0-0x0000000184DA15D0
		// HGFoliageType()
		void HG::Rendering::Runtime::HGFoliageType::cctor(MethodInfo *method)
		{
		  *(__m128i *)TypeInfo::HG::Rendering::Runtime::HGFoliageType->static_fields = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		}
		
	}
}
