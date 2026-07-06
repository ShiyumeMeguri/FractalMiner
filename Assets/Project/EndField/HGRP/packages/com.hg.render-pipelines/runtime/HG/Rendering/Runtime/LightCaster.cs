using System;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public readonly struct LightCaster : IEquatable<LightCaster>
	{
		public LightCaster(Entity inLightEntity, int inIndex)
		{
			// // LightCaster(Entity, Int32)
			// void HG::Rendering::Runtime::LightCaster::LightCaster(
			//         LightCaster *this,
			//         Entity_1 inLightEntity,
			//         int32_t inIndex,
			//         MethodInfo *method)
			// {
			//   EntityManager_1 *RendererEntityManager; // rax
			//   Entity_1 lightEntity; // rdx
			//   int32_t v9; // eax
			//   EntityManager_1 v10; // [rsp+20h] [rbp-28h] BYREF
			//   EntityManager_1 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E8D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D919E8D = 1;
			//   }
			//   this.lightEntity = inLightEntity;
			//   this.index = inIndex;
			//   v10 = 0LL;
			//   RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v11, 0LL);
			//   lightEntity = this.lightEntity;
			//   v10 = *RendererEntityManager;
			//   if ( UnityEngine::HyperGryph::ECS::EntityManager::HasEntity(&v10, lightEntity, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     v9 = inIndex + this.lightEntity.globalIndex;
			//   }
			//   else
			//   {
			//     v9 = -this.index;
			//   }
			//   this.m_cachedHashCode = v9;
			// }
			// 
		}

		public HGSharedLightData GetHGSharedLightData()
		{
			// // HGSharedLightData GetHGSharedLightData()
			// HGSharedLightData HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(LightCaster *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1641, 0LL) )
			//     return (HGSharedLightData)this.lightEntity;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1641, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_629(Patch, this, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public override bool Equals(object obj)
		{
			// // Boolean Equals(Object)
			// bool HG::Rendering::Runtime::LightCaster::Equals(LightCaster *this, Object *obj, MethodInfo *method)
			// {
			//   LightCaster v5; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   LightCaster v10; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919E8E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E8E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1840, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1840, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_709(Patch, this, obj, 0LL);
			//   }
			//   else if ( obj && (struct LightCaster__Class *)obj.klass == TypeInfo::HG::Rendering::Runtime::LightCaster )
			//   {
			//     v5 = *(LightCaster *)sub_18004A160(obj);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     v10 = v5;
			//     return HG::Rendering::Runtime::LightCaster::Equals(this, &v10, 0LL);
			//   }
			//   else
			//   {
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		[IDTag(0)]
		public bool Equals(LightCaster otherCaster)
		{
			// // Boolean Equals(LightCaster)
			// bool HG::Rendering::Runtime::LightCaster::Equals(LightCaster *this, LightCaster *otherCaster, MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   LightCaster v9; // [rsp+20h] [rbp-18h] BYREF
			//   Entity_1 lightEntity; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919E8F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D919E8F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1614, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1614, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v9 = *otherCaster;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_618(Patch, this, &v9, 0LL);
			//   }
			//   else
			//   {
			//     lightEntity = this.lightEntity;
			//     sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     result = UnityEngine::HyperGryph::ECS::Entity::Equals(&lightEntity, otherCaster.lightEntity, 0LL);
			//     if ( result )
			//       return this.index == otherCaster.index;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public override int GetHashCode()
		{
			// // Int32 GetHashCode()
			// int32_t HG::Rendering::Runtime::LightCaster::GetHashCode(LightCaster *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1841, 0LL) )
			//     return this.m_cachedHashCode;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1841, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_710(Patch, this, 0LL);
			// }
			// 
			return 0;
		}

		public static bool operator ==(LightCaster a, LightCaster b)
		{
			// // Boolean op_Equality(LightCaster, LightCaster)
			// bool HG::Rendering::Runtime::LightCaster::op_Equality(LightCaster *a, LightCaster *b, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   LightCaster v9; // xmm1
			//   LightCaster v10; // [rsp+20h] [rbp-28h] BYREF
			//   LightCaster v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E90 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E90 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1613, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1613, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v9 = *a;
			//     v10 = *b;
			//     v11 = v9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_619(Patch, &v11, &v10, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     v10 = *b;
			//     return HG::Rendering::Runtime::LightCaster::Equals(a, &v10, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		public static bool operator !=(LightCaster a, LightCaster b)
		{
			// // Boolean op_Inequality(LightCaster, LightCaster)
			// bool HG::Rendering::Runtime::LightCaster::op_Inequality(LightCaster *a, LightCaster *b, MethodInfo *method)
			// {
			//   LightCaster v5; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   LightCaster v10; // xmm1
			//   LightCaster v11; // [rsp+20h] [rbp-28h] BYREF
			//   LightCaster v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E91 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E91 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1842, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1842, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = *a;
			//     v12 = *b;
			//     v11 = v10;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_619(Patch, &v11, &v12, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     v5 = *a;
			//     v11 = *b;
			//     v12 = v5;
			//     return !HG::Rendering::Runtime::LightCaster::op_Equality(&v12, &v11, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		public bool IsLightVaild()
		{
			// // Boolean IsLightVaild()
			// bool HG::Rendering::Runtime::LightCaster::IsLightVaild(LightCaster *this, MethodInfo *method)
			// {
			//   EntityManager_1 *RendererEntityManager; // rax
			//   Entity_1 lightEntity; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   EntityManager_1 v9; // [rsp+20h] [rbp-28h] BYREF
			//   EntityManager_1 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v9 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1640, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1640, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_628(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v10, 0LL);
			//     lightEntity = this.lightEntity;
			//     v9 = *RendererEntityManager;
			//     return UnityEngine::HyperGryph::ECS::EntityManager::HasEntity(&v9, lightEntity, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		public bool <>iFixBaseProxy_Equals(object P0)
		{
			// // Boolean <>iFixBaseProxy_Equals(Object)
			// bool HG::Rendering::Runtime::LightCaster::__iFixBaseProxy_Equals(LightCaster *this, Object *P0, MethodInfo *method)
			// {
			//   Object *v5; // rax
			//   LightCaster v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E93 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E93 = 1;
			//   }
			//   v7 = *this;
			//   v5 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::LightCaster, &v7, method);
			//   return System::ValueType::DefaultEquals(v5, P0, 0LL);
			// }
			// 
			return default(bool);
		}

		public int <>iFixBaseProxy_GetHashCode()
		{
			// // Int32 <>iFixBaseProxy_GetHashCode()
			// int32_t HG::Rendering::Runtime::LightCaster::__iFixBaseProxy_GetHashCode(LightCaster *this, MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   ValueType *v4; // rax
			//   LightCaster v6; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E94 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E94 = 1;
			//   }
			//   v6 = *this;
			//   v4 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::LightCaster, &v6, v2);
			//   return System::ValueType::GetHashCode(v4, 0LL);
			// }
			// 
			return 0;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static LightCaster NULL_CASTER;

		public readonly Entity lightEntity;

		public readonly int index;

		private readonly int m_cachedHashCode;
	}
}
