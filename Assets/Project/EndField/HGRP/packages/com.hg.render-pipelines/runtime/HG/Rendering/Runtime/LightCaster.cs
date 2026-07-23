using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[IsReadOnly]
	public struct LightCaster : IEquatable<HG.Rendering.Runtime.LightCaster> // TypeDefIndex: 37851
	{
		// Fields
		public static LightCaster NULL_CASTER; // 0x00
		public readonly Entity lightEntity; // 0x00
		public readonly int index; // 0x08
		private readonly int m_cachedHashCode; // 0x0C
	
		// Constructors
		public LightCaster(Entity inLightEntity, int inIndex) {
			lightEntity = default;
			index = default;
			m_cachedHashCode = default;
		} // 0x0000000189B52B0C-0x0000000189B52B7C
		// LightCaster(Entity, Int32)
		void HG::Rendering::Runtime::LightCaster::LightCaster(
		        LightCaster *this,
		        Entity_1 inLightEntity,
		        int32_t inIndex,
		        MethodInfo *method)
		{
		  EntityManager *RendererEntityManager; // rax
		  Entity_1 lightEntity; // rdx
		  int32_t v8; // eax
		  EntityManager v9; // [rsp+20h] [rbp-28h] BYREF
		  EntityManager v10; // [rsp+30h] [rbp-18h] BYREF
		
		  this->lightEntity = inLightEntity;
		  this->index = inIndex;
		  v9 = 0LL;
		  RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v10, 0LL);
		  lightEntity = this->lightEntity;
		  v9 = *RendererEntityManager;
		  if ( UnityEngine::HyperGryph::ECS::EntityManager::HasEntity(&v9, lightEntity, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    v8 = inIndex + this->lightEntity.globalIndex;
		  }
		  else
		  {
		    v8 = -this->index;
		  }
		  this->m_cachedHashCode = v8;
		}
		
		static LightCaster() {
			NULL_CASTER = default;
		} // 0x0000000189B52AB4-0x0000000189B52B0C
		// LightCaster()
		void HG::Rendering::Runtime::LightCaster::cctor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct Entity_1__Class *v2; // rcx
		  Entity_1 v3; // rax
		  LightCaster v4; // [rsp+20h] [rbp-18h] BYREF
		
		  v2 = TypeInfo::UnityEngine::HyperGryph::ECS::Entity;
		  if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		  v3 = (Entity_1)sub_183963640(v2, v1);
		  v4 = 0LL;
		  HG::Rendering::Runtime::LightCaster::LightCaster(&v4, v3, -1, 0LL);
		  TypeInfo::HG::Rendering::Runtime::LightCaster->static_fields->NULL_CASTER = v4;
		}
		
	
		// Methods
		public HGSharedLightData GetHGSharedLightData() => default; // 0x0000000189B52934-0x0000000189B52990
		// HGSharedLightData GetHGSharedLightData()
		HGSharedLightData HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(LightCaster *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1951, 0LL) )
		    return (HGSharedLightData)this->lightEntity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1951, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_782(Patch, this, 0LL);
		}
		
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x0000000189B527FC-0x0000000189B528A0
		// Boolean Equals(Object)
		bool HG::Rendering::Runtime::LightCaster::Equals(LightCaster *this, Object *obj, MethodInfo *method)
		{
		  LightCaster v5; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  LightCaster v10; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2175, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2175, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_870(Patch, this, obj, 0LL);
		  }
		  else if ( obj && (struct LightCaster__Class *)obj->klass == TypeInfo::HG::Rendering::Runtime::LightCaster )
		  {
		    v5 = *(LightCaster *)sub_1800422D0(obj);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		    v10 = v5;
		    return HG::Rendering::Runtime::LightCaster::Equals(this, &v10, 0LL);
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		[IDTag(0)]
		public bool Equals(LightCaster otherCaster) => default; // 0x0000000189B528A0-0x0000000189B52934
		// Boolean Equals(LightCaster)
		bool HG::Rendering::Runtime::LightCaster::Equals(LightCaster *this, LightCaster *otherCaster, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  LightCaster v9; // [rsp+20h] [rbp-18h] BYREF
		  Entity_1 lightEntity; // [rsp+58h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1921, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1921, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v9 = *otherCaster;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_771(Patch, this, &v9, 0LL);
		  }
		  else
		  {
		    lightEntity = this->lightEntity;
		    sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    result = UnityEngine::HyperGryph::ECS::Entity::Equals(&lightEntity, otherCaster->lightEntity, 0LL);
		    if ( result )
		      return this->index == otherCaster->index;
		  }
		  return result;
		}
		
		public override int GetHashCode() => default; // 0x0000000189B52990-0x0000000189B529DC
		// Int32 GetHashCode()
		int32_t HG::Rendering::Runtime::LightCaster::GetHashCode(LightCaster *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2176, 0LL) )
		    return this->m_cachedHashCode;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2176, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_871(Patch, this, 0LL);
		}
		
		public static bool operator ==(LightCaster a, LightCaster b) => default; // 0x0000000189B52B7C-0x0000000189B52C0C
		// Boolean op_Equality(LightCaster, LightCaster)
		bool HG::Rendering::Runtime::LightCaster::op_Equality(LightCaster *a, LightCaster *b, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  LightCaster v9; // xmm1
		  LightCaster v10; // [rsp+20h] [rbp-28h] BYREF
		  LightCaster v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1920, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1920, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v9 = *a;
		    v10 = *b;
		    v11 = v9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_772(Patch, &v11, &v10, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		    v10 = *b;
		    return HG::Rendering::Runtime::LightCaster::Equals(a, &v10, 0LL);
		  }
		}
		
		public static bool operator !=(LightCaster a, LightCaster b) => default; // 0x0000000189B52C0C-0x0000000189B52CAC
		// Boolean op_Inequality(LightCaster, LightCaster)
		bool HG::Rendering::Runtime::LightCaster::op_Inequality(LightCaster *a, LightCaster *b, MethodInfo *method)
		{
		  LightCaster v5; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  LightCaster v10; // xmm1
		  LightCaster v11; // [rsp+20h] [rbp-28h] BYREF
		  LightCaster v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2177, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2177, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = *a;
		    v12 = *b;
		    v11 = v10;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_772(Patch, &v11, &v12, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		    v5 = *a;
		    v11 = *b;
		    v12 = v5;
		    return !HG::Rendering::Runtime::LightCaster::op_Equality(&v12, &v11, 0LL);
		  }
		}
		
		public bool IsLightVaild() => default; // 0x0000000189B529DC-0x0000000189B52A50
		// Boolean IsLightVaild()
		bool HG::Rendering::Runtime::LightCaster::IsLightVaild(LightCaster *this, MethodInfo *method)
		{
		  EntityManager *RendererEntityManager; // rax
		  Entity_1 lightEntity; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  EntityManager v9; // [rsp+20h] [rbp-28h] BYREF
		  EntityManager v10; // [rsp+30h] [rbp-18h] BYREF
		
		  v9 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1950, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1950, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_781(Patch, this, 0LL);
		  }
		  else
		  {
		    RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v10, 0LL);
		    lightEntity = this->lightEntity;
		    v9 = *RendererEntityManager;
		    return UnityEngine::HyperGryph::ECS::EntityManager::HasEntity(&v9, lightEntity, 0LL);
		  }
		}
		
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189B52A50-0x0000000189B52A88
		// Boolean <>iFixBaseProxy_Equals(Object)
		bool HG::Rendering::Runtime::LightCaster::__iFixBaseProxy_Equals(LightCaster *this, Object *P0, MethodInfo *method)
		{
		  Object *v4; // rax
		  LightCaster v6; // [rsp+20h] [rbp-18h] BYREF
		
		  v6 = *this;
		  v4 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::LightCaster, &v6);
		  return System::ValueType::DefaultEquals(v4, P0, 0LL);
		}
		
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189B52A88-0x0000000189B52AB4
		// Int32 <>iFixBaseProxy_GetHashCode()
		int32_t HG::Rendering::Runtime::LightCaster::__iFixBaseProxy_GetHashCode(LightCaster *this, MethodInfo *method)
		{
		  ValueType *v2; // rax
		  LightCaster v4; // [rsp+20h] [rbp-18h] BYREF
		
		  v4 = *this;
		  v2 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::LightCaster, &v4);
		  return System::ValueType::GetHashCode(v2, 0LL);
		}
		
	}
}
