using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.CSG;
using IFix.Core;

namespace IFix
{
	public class ILFixInterfaceBridge : AnonymousStorey, IAsyncStateMachine, IDisposable, IEnumerator, IEnumerator<CSGPolygon>, IEnumerable<CSGPolygon>, IEnumerable
	{
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000025D2 File Offset: 0x000007D2
		private CSGPolygon System.Collections.Generic.IEnumerator<HG.Rendering.Runtime.CSG.CSGPolygon>.Current
		{
			[IDTag(4)]
			get
			{
				// // CSGPolygon System.Collections.Generic.IEnumerator<HG.Rendering.Runtime.CSG.CSGPolygon>.get_Current()
				// CSGPolygon *IFix::ILFixInterfaceBridge::System_Collections_Generic_IEnumerator_HG_Rendering_Runtime_CSG_CSGPolygon__get_Current(
				//         ILFixInterfaceBridge_2 *this,
				//         MethodInfo *method)
				// {
				//   Call *v3; // rax
				//   __int128 v4; // xmm1
				//   __int64 v5; // rdx
				//   VirtualMachine *virtualMachine; // rcx
				//   Call call; // [rsp+30h] [rbp-58h] BYREF
				//   Call v9; // [rsp+58h] [rbp-30h] BYREF
				// 
				//   if ( !byte_18D919D4A )
				//   {
				//     sub_18003C530(&MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::CSG::CSGPolygon>);
				//     byte_18D919D4A = 1;
				//   }
				//   v3 = IFix::Core::Call::Begin(&v9, 0LL);
				//   v4 = *(_OWORD *)&v3.managedStack;
				//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
				//   call.topWriteBack = v3.topWriteBack;
				//   *(_OWORD *)&call.managedStack = v4;
				//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
				//   virtualMachine = this.fields._.virtualMachine;
				//   if ( !virtualMachine )
				//     sub_180B536AC(0LL, v5);
				//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_4, &call, 1, 0, 0LL);
				//   return (CSGPolygon *)IFix::Core::Call::GetAsType<System::Object>(
				//                          &call,
				//                          0,
				//                          MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::CSG::CSGPolygon>);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000025D2 File Offset: 0x000007D2
		private object System.Collections.IEnumerator.Current
		{
			[IDTag(6)]
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *IFix::ILFixInterfaceBridge::System_Collections_IEnumerator_get_Current(
				//         ILFixInterfaceBridge_2 *this,
				//         MethodInfo *method)
				// {
				//   Call *v3; // rax
				//   __int128 v4; // xmm1
				//   __int64 v5; // rdx
				//   VirtualMachine *virtualMachine; // rcx
				//   Call call; // [rsp+30h] [rbp-58h] BYREF
				//   Call v9; // [rsp+58h] [rbp-30h] BYREF
				// 
				//   if ( !byte_18D919D4B )
				//   {
				//     sub_18003C530(&MethodInfo::IFix::Core::Call::GetAsType<System::Object>);
				//     byte_18D919D4B = 1;
				//   }
				//   v3 = IFix::Core::Call::Begin(&v9, 0LL);
				//   v4 = *(_OWORD *)&v3.managedStack;
				//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
				//   call.topWriteBack = v3.topWriteBack;
				//   *(_OWORD *)&call.managedStack = v4;
				//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
				//   virtualMachine = this.fields._.virtualMachine;
				//   if ( !virtualMachine )
				//     sub_180B536AC(0LL, v5);
				//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_6, &call, 1, 0, 0LL);
				//   return IFix::Core::Call::GetAsType<System::Object>(&call, 0, MethodInfo::IFix::Core::Call::GetAsType<System::Object>);
				// }
				// 
				return null;
			}
		}

		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine)
		{
			// // ILFixInterfaceBridge(Int32, Int32[], Int32, Int32[], Int32[], VirtualMachine)
			// void IFix::ILFixInterfaceBridge::ILFixInterfaceBridge(
			//         ILFixInterfaceBridge_2 *this,
			//         int32_t fieldNum,
			//         Int32__Array *fieldTypes,
			//         int32_t typeIndex,
			//         Int32__Array *vTable,
			//         Int32__Array *methodIdArray,
			//         VirtualMachine *virtualMachine,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rcx
			//   Int32__Array *v10; // rdx
			//   __int64 v11; // rax
			//   Exception *v12; // rbx
			//   String *v13; // rax
			//   __int64 v14; // rax
			// 
			//   IFix::Core::AnonymousStorey::AnonymousStorey(
			//     (AnonymousStorey *)this,
			//     fieldNum,
			//     fieldTypes,
			//     typeIndex,
			//     vTable,
			//     virtualMachine,
			//     0LL);
			//   v10 = methodIdArray;
			//   if ( !methodIdArray )
			//     goto LABEL_16;
			//   if ( methodIdArray.max_length.size != 9 )
			//   {
			//     v11 = sub_18000F7E0(&TypeInfo::System::Exception);
			//     v12 = (Exception *)sub_180004920(v11);
			//     if ( v12 )
			//     {
			//       v13 = (String *)sub_18000F7E0(&off_18D515510);
			//       System::Exception::Exception(v12, v13, 0LL);
			//       v14 = sub_18000F7E0(&MethodInfo::IFix::ILFixInterfaceBridge::ILFixInterfaceBridge);
			//       sub_18000F7C0(v12, v14);
			//     }
			// LABEL_16:
			//     sub_180B536AC(v9, v10);
			//   }
			//   if ( !methodIdArray.max_length.size )
			//     goto LABEL_13;
			//   this.fields.methodId_0 = methodIdArray.vector[0];
			//   if ( methodIdArray.max_length.size <= 1u
			//     || (this.fields.methodId_1 = methodIdArray.vector[1], methodIdArray.max_length.size <= 2u)
			//     || (this.fields.methodId_2 = methodIdArray.vector[2], methodIdArray.max_length.size <= 3u)
			//     || (this.fields.methodId_3 = methodIdArray.vector[3], methodIdArray.max_length.size <= 4u)
			//     || (this.fields.methodId_4 = methodIdArray.vector[4], methodIdArray.max_length.size <= 5u)
			//     || (this.fields.methodId_5 = methodIdArray.vector[5], methodIdArray.max_length.size <= 6u)
			//     || (this.fields.methodId_6 = methodIdArray.vector[6], methodIdArray.max_length.size <= 7u)
			//     || (this.fields.methodId_7 = methodIdArray.vector[7], methodIdArray.max_length.size <= 8u) )
			//   {
			// LABEL_13:
			//     sub_180070270(v9, methodIdArray);
			//   }
			//   this.fields.methodId_8 = methodIdArray.vector[8];
			// }
			// 
		}

		[IDTag(0)]
		private void MoveNext()
		{
			// // Void MoveNext()
			// void IFix::ILFixInterfaceBridge::MoveNext(ILFixInterfaceBridge_4 *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v6; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   memset(&call, 0, sizeof(call));
			//   call = *IFix::Core::Call::Begin(&v6, 0LL);
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v3);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_0, &call, 1, 0, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		private void SetStateMachine(IAsyncStateMachine P0)
		{
			// // Void SetStateMachine(IAsyncStateMachine)
			// void IFix::ILFixInterfaceBridge::SetStateMachine(
			//         ILFixInterfaceBridge_4 *this,
			//         IAsyncStateMachine *P0,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v8; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   memset(&call, 0, sizeof(call));
			//   call = *IFix::Core::Call::Begin(&v8, 0LL);
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   IFix::Core::Call::PushObject(&call, (Object *)P0, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v5);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_1, &call, 2, 0, 0LL);
			// }
			// 
		}

		[IDTag(2)]
		private void System.IDisposable.Dispose()
		{
			// // Void System.IDisposable.Dispose()
			// void IFix::ILFixInterfaceBridge::System_IDisposable_Dispose(ILFixInterfaceBridge_2 *this, MethodInfo *method)
			// {
			//   Call *v3; // rax
			//   __int128 v4; // xmm1
			//   __int64 v5; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v8; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   v3 = IFix::Core::Call::Begin(&v8, 0LL);
			//   v4 = *(_OWORD *)&v3.managedStack;
			//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
			//   call.topWriteBack = v3.topWriteBack;
			//   *(_OWORD *)&call.managedStack = v4;
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v5);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_2, &call, 1, 0, 0LL);
			// }
			// 
		}

		[IDTag(3)]
		private bool MoveNext()
		{
			// // Boolean MoveNext()
			// bool IFix::ILFixInterfaceBridge::MoveNext(ILFixInterfaceBridge_2 *this, MethodInfo *method)
			// {
			//   Call *v3; // rax
			//   __int128 v4; // xmm1
			//   __int64 v5; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v9; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   v3 = IFix::Core::Call::Begin(&v9, 0LL);
			//   v4 = *(_OWORD *)&v3.managedStack;
			//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
			//   call.topWriteBack = v3.topWriteBack;
			//   *(_OWORD *)&call.managedStack = v4;
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v5);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_3, &call, 1, 0, 0LL);
			//   return IFix::Core::Call::GetBoolean(&call, 0, 0LL);
			// }
			// 
			return default(bool);
		}

		[IDTag(5)]
		private void System.Collections.IEnumerator.Reset()
		{
			// // Void System.Collections.IEnumerator.Reset()
			// void IFix::ILFixInterfaceBridge::System_Collections_IEnumerator_Reset(ILFixInterfaceBridge_2 *this, MethodInfo *method)
			// {
			//   Call *v3; // rax
			//   __int128 v4; // xmm1
			//   __int64 v5; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v8; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   v3 = IFix::Core::Call::Begin(&v8, 0LL);
			//   v4 = *(_OWORD *)&v3.managedStack;
			//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
			//   call.topWriteBack = v3.topWriteBack;
			//   *(_OWORD *)&call.managedStack = v4;
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v5);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_5, &call, 1, 0, 0LL);
			// }
			// 
		}

		[IDTag(7)]
		private IEnumerator<CSGPolygon> System.Collections.Generic.IEnumerable<HG.Rendering.Runtime.CSG.CSGPolygon>.GetEnumerator()
		{
			// // IEnumerator`1[HG.Rendering.Runtime.CSG.CSGPolygon] System.Collections.Generic.IEnumerable<HG.Rendering.Runtime.CSG.CSGPolygon>.GetEnumerator()
			// IEnumerator_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *IFix::ILFixInterfaceBridge::System_Collections_Generic_IEnumerable_HG_Rendering_Runtime_CSG_CSGPolygon__GetEnumerator(
			//         ILFixInterfaceBridge_2 *this,
			//         MethodInfo *method)
			// {
			//   Call *v3; // rax
			//   __int128 v4; // xmm1
			//   __int64 v5; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v9; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919D4C )
			//   {
			//     sub_18003C530(&MethodInfo::IFix::Core::Call::GetAsType<System::Collections::Generic::IEnumerator<HG::Rendering::Runtime::CSG::CSGPolygon>>);
			//     byte_18D919D4C = 1;
			//   }
			//   v3 = IFix::Core::Call::Begin(&v9, 0LL);
			//   v4 = *(_OWORD *)&v3.managedStack;
			//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
			//   call.topWriteBack = v3.topWriteBack;
			//   *(_OWORD *)&call.managedStack = v4;
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v5);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_7, &call, 1, 0, 0LL);
			//   return (IEnumerator_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)IFix::Core::Call::GetAsType<System::Object>(
			//                                                                  &call,
			//                                                                  0,
			//                                                                  MethodInfo::IFix::Core::Call::GetAsType<System::Collections::Generic::IEnumerator<HG::Rendering::Runtime::CSG::CSGPolygon>>);
			// }
			// 
			return null;
		}

		[IDTag(8)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			// // IEnumerator System.Collections.IEnumerable.GetEnumerator()
			// IEnumerator *IFix::ILFixInterfaceBridge::System_Collections_IEnumerable_GetEnumerator(
			//         ILFixInterfaceBridge_2 *this,
			//         MethodInfo *method)
			// {
			//   Call *v3; // rax
			//   __int128 v4; // xmm1
			//   __int64 v5; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   Call call; // [rsp+30h] [rbp-58h] BYREF
			//   Call v9; // [rsp+58h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919D4D )
			//   {
			//     sub_18003C530(&MethodInfo::IFix::Core::Call::GetAsType<System::Collections::IEnumerator>);
			//     byte_18D919D4D = 1;
			//   }
			//   v3 = IFix::Core::Call::Begin(&v9, 0LL);
			//   v4 = *(_OWORD *)&v3.managedStack;
			//   *(_OWORD *)&call.argumentBase = *(_OWORD *)&v3.argumentBase;
			//   call.topWriteBack = v3.topWriteBack;
			//   *(_OWORD *)&call.managedStack = v4;
			//   IFix::Core::Call::PushObject(&call, (Object *)this, 0LL);
			//   virtualMachine = this.fields._.virtualMachine;
			//   if ( !virtualMachine )
			//     sub_180B536AC(0LL, v5);
			//   IFix::Core::VirtualMachine::Execute(virtualMachine, this.fields.methodId_8, &call, 1, 0, 0LL);
			//   return (IEnumerator *)IFix::Core::Call::GetAsType<System::Object>(
			//                           &call,
			//                           0,
			//                           MethodInfo::IFix::Core::Call::GetAsType<System::Collections::IEnumerator>);
			// }
			// 
			return null;
		}

		public void RefAwaitUnsafeOnCompleteMethod()
		{
			// // Void RefAwaitUnsafeOnCompleteMethod()
			// void IFix::ILFixInterfaceBridge::RefAwaitUnsafeOnCompleteMethod(ILFixInterfaceBridge_2 *this, MethodInfo *method)
			// {
			//   TaskAwaiter awaiter; // [rsp+20h] [rbp-60h] BYREF
			//   TaskAwaiter v3; // [rsp+28h] [rbp-58h] BYREF
			//   AsyncTaskMethodBuilder_1_System_Object_ v4; // [rsp+30h] [rbp-50h] BYREF
			//   AsyncTaskMethodBuilder_1_System_Object_ v5; // [rsp+48h] [rbp-38h] BYREF
			//   AsyncVoidMethodBuilder v6; // [rsp+60h] [rbp-20h] BYREF
			//   YieldAwaitable_YieldAwaiter v7; // [rsp+A0h] [rbp+20h] BYREF
			//   Object *stateMachine; // [rsp+A8h] [rbp+28h] BYREF
			// 
			//   if ( !byte_18D919D4E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::TaskAwaiter,IFix::ILFixInterfaceBridge>);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::YieldAwaitable::YieldAwaiter,IFix::ILFixInterfaceBridge>);
			//     sub_18003C530(&TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
			//     sub_18003C530(&TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::TaskAwaiter<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>,IFix::ILFixInterfaceBridge>);
			//     byte_18D919D4E = 1;
			//   }
			//   stateMachine = 0LL;
			//   v3.m_task = 0LL;
			//   awaiter.m_task = 0LL;
			//   memset(&v4, 0, sizeof(v4));
			//   v7 = 0;
			//   memset(&v5, 0, sizeof(v5));
			//   memset(&v6, 0, sizeof(v6));
			//   sub_180002C70(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
			//   System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::TaskAwaiter,System::Object>(
			//     &v4,
			//     &awaiter,
			//     &stateMachine,
			//     MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::TaskAwaiter,IFix::ILFixInterfaceBridge>);
			//   sub_180002C70(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
			//   System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Object>::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::YieldAwaitable::YieldAwaiter,System::Object>(
			//     &v5,
			//     &v7,
			//     &stateMachine,
			//     MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::YieldAwaitable::YieldAwaiter,IFix::ILFixInterfaceBridge>);
			//   System::Runtime::CompilerServices::AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::TaskAwaiter,System::Object>(
			//     &v6,
			//     &v3,
			//     &stateMachine,
			//     MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System::Runtime::CompilerServices::TaskAwaiter<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>,IFix::ILFixInterfaceBridge>);
			// }
			// 
		}

		public void RefAsyncBuilderStartMethod()
		{
			// // Void RefAsyncBuilderStartMethod()
			// void IFix::ILFixInterfaceBridge::RefAsyncBuilderStartMethod(ILFixInterfaceBridge_2 *this, MethodInfo *method)
			// {
			//   AsyncVoidMethodBuilder v2; // [rsp+20h] [rbp-28h] BYREF
			//   Object *stateMachine; // [rsp+60h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919D4F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::Start<IFix::ILFixInterfaceBridge>);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::Start<IFix::ILFixInterfaceBridge>);
			//     sub_18003C530(&TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
			//     sub_18003C530(&TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
			//     sub_18003C530(&MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<IFix::ILFixInterfaceBridge>);
			//     byte_18D919D4F = 1;
			//   }
			//   stateMachine = 0LL;
			//   System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<System::Object>(
			//     &v2,
			//     &stateMachine,
			//     MethodInfo::System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<IFix::ILFixInterfaceBridge>);
			//   sub_180002C70(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>);
			//   System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<System::Object>(
			//     &v2,
			//     &stateMachine,
			//     MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<UnityEngine::HyperGryph::HGDrawCallDetailedStats []>::Start<IFix::ILFixInterfaceBridge>);
			//   sub_180002C70(TypeInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>);
			//   System::Runtime::CompilerServices::AsyncVoidMethodBuilder::Start<System::Object>(
			//     &v2,
			//     &stateMachine,
			//     MethodInfo::System::Runtime::CompilerServices::AsyncTaskMethodBuilder<System::Collections::Generic::List<HG::Rendering::Tools::HGShadowDetailDumper::ShadowDetailRowContent>>::Start<IFix::ILFixInterfaceBridge>);
			// }
			// 
		}

		private int methodId_0;

		private int methodId_1;

		private int methodId_2;

		private int methodId_3;

		private int methodId_4;

		private int methodId_5;

		private int methodId_6;

		private int methodId_7;

		private int methodId_8;
	}
}
