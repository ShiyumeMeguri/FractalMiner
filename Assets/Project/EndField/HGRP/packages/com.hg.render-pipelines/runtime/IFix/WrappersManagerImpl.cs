using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IFix
{
	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 38878
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x00000001853908C0-0x00000001853908D0
		// SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
		void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		        SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
		        SortedList_2_System_Object_System_Object_ *dictionary,
		        MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  VolumetricPipelineRT **v4; // [rsp+28h] [rbp+28h]
		  MethodInfo *v5; // [rsp+30h] [rbp+30h]
		
		  this->fields._dict = dictionary;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields,
		    (UberPostPassUtils_ColorGradingData **)dictionary,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189CDC2C0-0x0000000189CDC314
		// ILFixDynamicMethodWrapper GetPatch(Int32)
		// local variable allocation has failed, the output may be wrong!
		ILFixDynamicMethodWrapper_2 *IFix::WrappersManagerImpl::GetPatch(int32_t id, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  __int64 v3; // rbx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = id;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(*(_QWORD *)&id, 0LL);
		  if ( (unsigned int)v3 >= wrapperArray->max_length.size )
		    sub_1800D2AB0(*(_QWORD *)&id, wrapperArray);
		  return wrapperArray->vector[v3];
		}
		
		public static bool IsPatched(int id) => default; // 0x00000001831068E0-0x0000000183106930
		// Boolean IsPatched(Int32)
		bool IFix::WrappersManagerImpl::IsPatched(int32_t id, MethodInfo *method)
		{
		  __int64 v2; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		
		  v2 = id;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( (int)v2 >= wrapperArray->max_length.size )
		    return 0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  if ( (unsigned int)v2 >= LODWORD(v3->_0.namespaze) )
		    sub_1800D2AB0(v3, wrapperArray);
		  return *((_QWORD *)&v3->_0.byval_arg.data.dummy + v2) != 0;
		}
		
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189CDC1D0-0x0000000189CDC264
		// Delegate CreateDelegate(Type, Int32, Object)
		Delegate *IFix::WrappersManagerImpl::CreateDelegate(
		        WrappersManagerImpl_2 *this,
		        Type *type,
		        int32_t id,
		        Object *anon,
		        MethodInfo *method)
		{
		  VirtualMachine *virtualMachine; // r14
		  ILFixDynamicMethodWrapper_38 *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object *v12; // rbx
		
		  virtualMachine = this->fields.virtualMachine;
		  v9 = (ILFixDynamicMethodWrapper_38 *)sub_1800368D0(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v12 = (Object *)v9;
		  if ( !v9 )
		    sub_1800D8260(v11, v10);
		  IFix::ILFixDynamicMethodWrapper::ILFixDynamicMethodWrapper(v9, virtualMachine, id, anon, 0LL);
		  sub_1800036A0(TypeInfo::IFix::Core::Utils);
		  return IFix::Core::Utils::TryAdapterToDelegate(v12, type, (String *)"__Gen_Wrap_", 0LL);
		}
		
		public object CreateWrapper(int id) => default; // 0x0000000189CDC264-0x0000000189CDC2C0
		// Object CreateWrapper(Int32)
		Object *IFix::WrappersManagerImpl::CreateWrapper(WrappersManagerImpl_2 *this, int32_t id, MethodInfo *method)
		{
		  VirtualMachine *virtualMachine; // rsi
		  ILFixDynamicMethodWrapper_38 *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Object *v8; // rbx
		
		  virtualMachine = this->fields.virtualMachine;
		  v5 = (ILFixDynamicMethodWrapper_38 *)sub_1800368D0(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v8 = (Object *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  IFix::ILFixDynamicMethodWrapper::ILFixDynamicMethodWrapper(v5, virtualMachine, id, 0LL, 0LL);
		  return v8;
		}
		
		public object InitWrapperArray(int len) => default; // 0x0000000189CDC314-0x0000000189CDC374
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189CDC148-0x0000000189CDC1D0
		// AnonymousStorey CreateBridge(Int32, Int32[], Int32, Int32[], Int32[], VirtualMachine)
		AnonymousStorey *IFix::WrappersManagerImpl::CreateBridge(
		        WrappersManagerImpl_2 *this,
		        int32_t fieldNum,
		        Int32__Array *fieldTypes,
		        int32_t typeIndex,
		        Int32__Array *vTable,
		        Int32__Array *slots,
		        VirtualMachine *virtualMachine,
		        MethodInfo *method)
		{
		  ILFixInterfaceBridge_2 *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  AnonymousStorey *v14; // rbx
		
		  v11 = (ILFixInterfaceBridge_2 *)sub_1800368D0(TypeInfo::IFix::ILFixInterfaceBridge);
		  v14 = (AnonymousStorey *)v11;
		  if ( !v11 )
		    sub_1800D8260(v13, v12);
		  IFix::ILFixInterfaceBridge::ILFixInterfaceBridge(
		    v11,
		    fieldNum,
		    fieldTypes,
		    typeIndex,
		    vTable,
		    slots,
		    virtualMachine,
		    0LL);
		  return v14;
		}
		
	}
}
