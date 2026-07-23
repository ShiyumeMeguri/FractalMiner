using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct ScalableSettingSchemaId : IEquatable<HG.Rendering.Runtime.ScalableSettingSchemaId> // TypeDefIndex: 38560
	{
		// Fields
		public static readonly ScalableSettingSchemaId With3Levels; // 0x00
		public static readonly ScalableSettingSchemaId With4Levels; // 0x08
		[SerializeField]
		private string m_Id; // 0x00
	
		// Constructors
		internal ScalableSettingSchemaId(string id) {
			m_Id = default;
		} // 0x0000000185392320-0x0000000185392328
		// Void WriteUnaligned[Object](Byte ByRef, Object)
		void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
		        uint8_t *destination,
		        Object *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  *(_QWORD *)destination = value;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)destination,
		    (HGRuntimeGrassQuery_Node *)value,
		    (HGRuntimeGrassQuery_Node *)method,
		    v3,
		    v4);
		}
		
		static ScalableSettingSchemaId() {
			With3Levels = default;
			With4Levels = default;
		} // 0x0000000189C11B90-0x0000000189C11C1C
		// ScalableSettingSchemaId()
		void HG::Rendering::Runtime::ScalableSettingSchemaId::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  Int32__Array **v4; // r9
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  String *v16; // [rsp+38h] [rbp+10h] BYREF
		  String *v17; // [rsp+40h] [rbp+18h] BYREF
		
		  v16 = (String *)"With3Levels";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v16, v1, v2, v3, v12);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId;
		  TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId->static_fields->With3Levels.m_Id = v16;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId->static_fields,
		    v5,
		    v6,
		    v4,
		    v13);
		  v17 = (String *)"With4Levels";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v17, v7, v8, (Int32__Array **)"With4Levels", v14);
		  v9 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId;
		  TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId->static_fields->With4Levels.m_Id = v17;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId->static_fields->With4Levels,
		    v10,
		    v11,
		    v9,
		    v15);
		}
		
	
		// Methods
		[IDTag(0)]
		public bool Equals(ScalableSettingSchemaId other) => default; // 0x0000000189C1196C-0x0000000189C119D0
		// Boolean Equals(ScalableSettingSchemaId)
		bool HG::Rendering::Runtime::ScalableSettingSchemaId::Equals(
		        ScalableSettingSchemaId *this,
		        ScalableSettingSchemaId other,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3731, 0LL) )
		    return System::String::Equals(this->m_Id, other.m_Id, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3731, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1305(Patch, this, other, 0LL);
		}
		
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x0000000189C119D0-0x0000000189C11A50
		// Boolean Equals(Object)
		bool HG::Rendering::Runtime::ScalableSettingSchemaId::Equals(
		        ScalableSettingSchemaId *this,
		        Object *obj,
		        MethodInfo *method)
		{
		  String **v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3732, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3732, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1306(Patch, this, obj, 0LL);
		  }
		  else if ( obj
		         && (struct ScalableSettingSchemaId__Class *)obj->klass == TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId )
		  {
		    v5 = (String **)sub_1800422D0(obj);
		    return System::String::Equals(*v5, this->m_Id, 0LL);
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		public override int GetHashCode() => default; // 0x0000000189C11A50-0x0000000189C11AB4
		// Int32 GetHashCode()
		int32_t HG::Rendering::Runtime::ScalableSettingSchemaId::GetHashCode(ScalableSettingSchemaId *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3733, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3733, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1307(Patch, this, 0LL);
		  }
		  else if ( this->m_Id )
		  {
		    return sub_180002F70(2LL, this->m_Id);
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		public override string ToString() => default; // 0x0000000189C11AB4-0x0000000189C11B00
		// String ToString()
		String *HG::Rendering::Runtime::ScalableSettingSchemaId::ToString(ScalableSettingSchemaId *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3734, 0LL) )
		    return this->m_Id;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3734, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1308(Patch, this, 0LL);
		}
		
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189C11B00-0x0000000189C11B38
		// Boolean <>iFixBaseProxy_Equals(Object)
		bool HG::Rendering::Runtime::ScalableSettingSchemaId::__iFixBaseProxy_Equals(
		        ScalableSettingSchemaId *this,
		        Object *P0,
		        MethodInfo *method)
		{
		  Object *v4; // rax
		  String *m_Id; // [rsp+30h] [rbp+8h] BYREF
		
		  m_Id = this->m_Id;
		  v4 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId, &m_Id);
		  return System::ValueType::DefaultEquals(v4, P0, 0LL);
		}
		
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189C11B38-0x0000000189C11B64
		// Int32 <>iFixBaseProxy_GetHashCode()
		int32_t HG::Rendering::Runtime::ScalableSettingSchemaId::__iFixBaseProxy_GetHashCode(
		        ScalableSettingSchemaId *this,
		        MethodInfo *method)
		{
		  ValueType *v2; // rax
		  String *m_Id; // [rsp+30h] [rbp+8h] BYREF
		
		  m_Id = this->m_Id;
		  v2 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId, &m_Id);
		  return System::ValueType::GetHashCode(v2, 0LL);
		}
		
		public string __iFixBaseProxy_ToString() => default; // 0x0000000189C11B64-0x0000000189C11B90
		// String <>iFixBaseProxy_ToString()
		String *HG::Rendering::Runtime::ScalableSettingSchemaId::__iFixBaseProxy_ToString(
		        ScalableSettingSchemaId *this,
		        MethodInfo *method)
		{
		  ValueType *v2; // rax
		  String *m_Id; // [rsp+30h] [rbp+8h] BYREF
		
		  m_Id = this->m_Id;
		  v2 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId, &m_Id);
		  return System::ValueType::ToString(v2, 0LL);
		}
		
	}
}
