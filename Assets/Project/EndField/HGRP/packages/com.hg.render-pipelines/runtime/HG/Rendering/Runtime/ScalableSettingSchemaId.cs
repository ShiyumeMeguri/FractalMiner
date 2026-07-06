using System;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	public struct ScalableSettingSchemaId : IEquatable<ScalableSettingSchemaId>
	{
		internal ScalableSettingSchemaId(string id)
		{
			// // Void WriteUnaligned[Object](Byte ByRef, Object)
			// void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
			//         uint8_t *destination,
			//         Object *value,
			//         MethodInfo *method)
			// {
			//   HGCamera *v3; // r9
			//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
			//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
			// 
			//   *(_QWORD *)destination = value;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)destination,
			//     (HGRenderPathBase_HGRenderPathResources *)value,
			//     (PassConstructorID__Enum__Array *)method,
			//     v3,
			//     v4,
			//     v5);
			// }
			// 
		}

		[IDTag(0)]
		public bool Equals(ScalableSettingSchemaId other)
		{
			// // Boolean Equals(ScalableSettingSchemaId)
			// bool HG::Rendering::Runtime::ScalableSettingSchemaId::Equals(
			//         ScalableSettingSchemaId *this,
			//         ScalableSettingSchemaId other,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3129, 0LL) )
			//     return System::String::Equals(this.m_Id, other.m_Id, 0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3129, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1100(Patch, this, other, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(1)]
		public override bool Equals(object obj)
		{
			// // Boolean Equals(Object)
			// bool HG::Rendering::Runtime::ScalableSettingSchemaId::Equals(
			//         ScalableSettingSchemaId *this,
			//         Object *obj,
			//         MethodInfo *method)
			// {
			//   String **v5; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D919694 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId);
			//     byte_18D919694 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3130, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3130, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1101(Patch, this, obj, 0LL);
			//   }
			//   else if ( obj
			//          && (struct ScalableSettingSchemaId__Class *)obj.klass == TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId )
			//   {
			//     v5 = (String **)sub_18004A160(obj);
			//     return System::String::Equals(*v5, this.m_Id, 0LL);
			//   }
			//   else
			//   {
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public override int GetHashCode()
		{
			// // Int32 GetHashCode()
			// int32_t HG::Rendering::Runtime::ScalableSettingSchemaId::GetHashCode(ScalableSettingSchemaId *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3131, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3131, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1102(Patch, this, 0LL);
			//   }
			//   else if ( this.m_Id )
			//   {
			//     return sub_18003ED00(2LL);
			//   }
			//   else
			//   {
			//     return 0;
			//   }
			// }
			// 
			return 0;
		}

		public override string ToString()
		{
			// // String ToString()
			// String *HG::Rendering::Runtime::ScalableSettingSchemaId::ToString(ScalableSettingSchemaId *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3132, 0LL) )
			//     return this.m_Id;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3132, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1103(Patch, this, 0LL);
			// }
			// 
			return null;
		}

		public bool <>iFixBaseProxy_Equals(object P0)
		{
			// // Boolean <>iFixBaseProxy_Equals(Object)
			// bool HG::Rendering::Runtime::ScalableSettingSchemaId::__iFixBaseProxy_Equals(
			//         ScalableSettingSchemaId *this,
			//         Object *P0,
			//         MethodInfo *method)
			// {
			//   Object *v5; // rax
			//   String *m_Id; // [rsp+30h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D919696 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId);
			//     byte_18D919696 = 1;
			//   }
			//   m_Id = this.m_Id;
			//   v5 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId, &m_Id, method);
			//   return System::ValueType::DefaultEquals(v5, P0, 0LL);
			// }
			// 
			return default(bool);
		}

		public int <>iFixBaseProxy_GetHashCode()
		{
			// // Int32 <>iFixBaseProxy_GetHashCode()
			// int32_t HG::Rendering::Runtime::ScalableSettingSchemaId::__iFixBaseProxy_GetHashCode(
			//         ScalableSettingSchemaId *this,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   ValueType *v4; // rax
			//   String *m_Id; // [rsp+30h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D919697 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId);
			//     byte_18D919697 = 1;
			//   }
			//   m_Id = this.m_Id;
			//   v4 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId, &m_Id, v2);
			//   return System::ValueType::GetHashCode(v4, 0LL);
			// }
			// 
			return 0;
		}

		public string <>iFixBaseProxy_ToString()
		{
			// // String <>iFixBaseProxy_ToString()
			// String *HG::Rendering::Runtime::ScalableSettingSchemaId::__iFixBaseProxy_ToString(
			//         ScalableSettingSchemaId *this,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   ValueType *v4; // rax
			//   String *m_Id; // [rsp+30h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D919698 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId);
			//     byte_18D919698 = 1;
			//   }
			//   m_Id = this.m_Id;
			//   v4 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId, &m_Id, v2);
			//   return System::ValueType::ToString(v4, 0LL);
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly ScalableSettingSchemaId With3Levels;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly ScalableSettingSchemaId With4Levels;

		[SerializeField]
		private string m_Id;
	}
}
