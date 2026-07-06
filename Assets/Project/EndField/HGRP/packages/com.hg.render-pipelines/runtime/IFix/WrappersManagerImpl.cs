using System;
using IFix.Core;

namespace IFix
{
	public class WrappersManagerImpl : WrappersManager
	{
		public WrappersManagerImpl(VirtualMachine virtualMachine)
		{
			// // SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
			// void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
			//         SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
			//         SortedList_2_System_Object_System_Object_ *dictionary,
			//         MethodInfo *method)
			// {
			//   Transform **v3; // r9
			//   MeshRenderer **v4; // [rsp+28h] [rbp+28h]
			//   Vector3 *v5; // [rsp+30h] [rbp+30h]
			//   Quaternion *v6; // [rsp+38h] [rbp+38h]
			//   Vector3 *v7; // [rsp+40h] [rbp+40h]
			//   Object *v8; // [rsp+48h] [rbp+48h]
			//   Object *v9; // [rsp+50h] [rbp+50h]
			//   Object *v10; // [rsp+58h] [rbp+58h]
			//   Object *v11; // [rsp+60h] [rbp+60h]
			//   MethodInfo *v12; // [rsp+68h] [rbp+68h]
			// 
			//   this.fields._dict = dictionary;
			//   sub_1800054D0(
			//     (ILFixDynamicMethodWrapper_2 *)&this.fields,
			//     (UberPostPassUtils_ColorGradingData **)dictionary,
			//     (VolumetricPipelineRT **)method,
			//     v3,
			//     v4,
			//     v5,
			//     v6,
			//     v7,
			//     v8,
			//     v9,
			//     v10,
			//     v11,
			//     v12);
			// }
			// 
		}

		public static ILFixDynamicMethodWrapper GetPatch(int id)
		{
			// // ILFixDynamicMethodWrapper GetPatch(Int32)
			// ILFixDynamicMethodWrapper_2 *IFix::WrappersManagerImpl::GetPatch(int32_t id, MethodInfo *method)
			// {
			//   __int64 v2; // rbx
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
			// 
			//   v2 = id;
			//   if ( !byte_18D919D50 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D919D50 = 1;
			//   }
			//   sub_180002C70(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//   static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     sub_180B536AC(0LL, static_fields);
			//   if ( (unsigned int)v2 >= wrapperArray.max_length.size )
			//     sub_180070270(wrapperArray, static_fields);
			//   return wrapperArray.vector[v2];
			// }
			// 
			return null;
		}

		public static bool IsPatched(int id)
		{
			// // Boolean IsPatched(Int32)
			// bool IFix::WrappersManagerImpl::IsPatched(int32_t id, MethodInfo *method)
			// {
			//   __int64 v2; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			// 
			//   v2 = id;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( (int)v2 >= wrapperArray.max_length.size )
			//     return 0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( (unsigned int)v2 >= LODWORD(v3._0.namespaze) )
			//     sub_180070270(v3, wrapperArray);
			//   return *((_QWORD *)&v3._0.byval_arg.data.dummy + v2) != 0;
			// }
			// 
			return default(bool);
		}

		public Delegate CreateDelegate(Type type, int id, object anon)
		{
			// // Delegate CreateDelegate(Type, Int32, Object)
			// Delegate *IFix::WrappersManagerImpl::CreateDelegate(
			//         WrappersManagerImpl_2 *this,
			//         Type *type,
			//         int32_t id,
			//         Object *anon,
			//         MethodInfo *method)
			// {
			//   VirtualMachine *virtualMachine; // rdi
			//   ILFixDynamicMethodWrapper_36 *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Object *v13; // rbx
			// 
			//   if ( !byte_18D919D51 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     sub_18003C530(&TypeInfo::IFix::Core::Utils);
			//     sub_18003C530(&off_18D515500);
			//     byte_18D919D51 = 1;
			//   }
			//   virtualMachine = this.fields.virtualMachine;
			//   v10 = (ILFixDynamicMethodWrapper_36 *)sub_180004920(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//   v13 = (Object *)v10;
			//   if ( !v10 )
			//     sub_180B536AC(v12, v11);
			//   IFix::ILFixDynamicMethodWrapper::ILFixDynamicMethodWrapper(v10, virtualMachine, id, anon, 0LL);
			//   sub_180002C70(TypeInfo::IFix::Core::Utils);
			//   return IFix::Core::Utils::TryAdapterToDelegate(v13, type, (String *)"__Gen_Wrap_", 0LL);
			// }
			// 
			return null;
		}

		public object CreateWrapper(int id)
		{
			// // Object CreateWrapper(Int32)
			// Object *IFix::WrappersManagerImpl::CreateWrapper(WrappersManagerImpl_2 *this, int32_t id, MethodInfo *method)
			// {
			//   VirtualMachine *virtualMachine; // rsi
			//   ILFixDynamicMethodWrapper_36 *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Object *v9; // rbx
			// 
			//   if ( !byte_18D919D52 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D919D52 = 1;
			//   }
			//   virtualMachine = this.fields.virtualMachine;
			//   v6 = (ILFixDynamicMethodWrapper_36 *)sub_180004920(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//   v9 = (Object *)v6;
			//   if ( !v6 )
			//     sub_180B536AC(v8, v7);
			//   IFix::ILFixDynamicMethodWrapper::ILFixDynamicMethodWrapper(v6, virtualMachine, id, 0LL, 0LL);
			//   return v9;
			// }
			// 
			return null;
		}

		public object InitWrapperArray(int len)
		{
			return null;
		}

		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine)
		{
			// // AnonymousStorey CreateBridge(Int32, Int32[], Int32, Int32[], Int32[], VirtualMachine)
			// AnonymousStorey *IFix::WrappersManagerImpl::CreateBridge(
			//         WrappersManagerImpl_2 *this,
			//         int32_t fieldNum,
			//         Int32__Array *fieldTypes,
			//         int32_t typeIndex,
			//         Int32__Array *vTable,
			//         Int32__Array *slots,
			//         VirtualMachine *virtualMachine,
			//         MethodInfo *method)
			// {
			//   ILFixInterfaceBridge_2 *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   AnonymousStorey *v14; // rbx
			// 
			//   if ( !byte_18D919D54 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixInterfaceBridge);
			//     byte_18D919D54 = 1;
			//   }
			//   v11 = (ILFixInterfaceBridge_2 *)sub_180004920(TypeInfo::IFix::ILFixInterfaceBridge);
			//   v14 = (AnonymousStorey *)v11;
			//   if ( !v11 )
			//     sub_180B536AC(v13, v12);
			//   IFix::ILFixInterfaceBridge::ILFixInterfaceBridge(
			//     v11,
			//     fieldNum,
			//     fieldTypes,
			//     typeIndex,
			//     vTable,
			//     slots,
			//     virtualMachine,
			//     0LL);
			//   return v14;
			// }
			// 
			return null;
		}

		private VirtualMachine virtualMachine;
	}
}
